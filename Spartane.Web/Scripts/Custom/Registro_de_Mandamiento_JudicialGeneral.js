

//Begin Declarations for Foreigns fields for Detalle_de_Personas_a_Incluir MultiRow
var Detalle_de_Personas_a_IncluircountRowsChecked = 0;






function GetInsertDetalle_de_Personas_a_IncluirRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Personas_a_Incluir_Persona Persona').attr('id', 'Detalle_de_Personas_a_Incluir_Persona_' + index).attr('data-field', 'Persona');
    columnData[1] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Personas_a_Incluir_Seleccionar Seleccionar').attr('id', 'Detalle_de_Personas_a_Incluir_Seleccionar_' + index).attr('data-field', 'Seleccionar');
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Personas_a_Incluir_PersonaId PersonaId').attr('id', 'Detalle_de_Personas_a_Incluir_PersonaId_' + index).attr('data-field', 'PersonaId');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Personas_a_IncluirInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Personas_a_Incluir("Detalle_de_Personas_a_Incluir_", "_" + rowIndex)) {
    var iPage = Detalle_de_Personas_a_IncluirTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Personas_a_Incluir';
    var prevData = Detalle_de_Personas_a_IncluirTable.fnGetData(rowIndex);
    var data = Detalle_de_Personas_a_IncluirTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Persona:  data.childNodes[counter++].childNodes[0].value
        ,Seleccionar: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,PersonaId: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Personas_a_IncluirTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Personas_a_IncluirrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Personas_a_IncluirTable.fnPageChange(iPage);
    Detalle_de_Personas_a_IncluircountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Personas_a_Incluir("Detalle_de_Personas_a_Incluir_", "_" + rowIndex);
  }
}

function Detalle_de_Personas_a_IncluirCancelRow(rowIndex) {
    var prevData = Detalle_de_Personas_a_IncluirTable.fnGetData(rowIndex);
    var data = Detalle_de_Personas_a_IncluirTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Personas_a_IncluirTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Personas_a_IncluirrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Personas_a_IncluirGrid(Detalle_de_Personas_a_IncluirTable.fnGetData());
    Detalle_de_Personas_a_IncluircountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Personas_a_IncluirFromDataTable() {
    var Detalle_de_Personas_a_IncluirData = [];
    var gridData = Detalle_de_Personas_a_IncluirTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Personas_a_IncluirData.push({
                Folio: gridData[i].Folio

                ,Persona: gridData[i].Persona
                ,Seleccionar: gridData[i].Seleccionar
                ,PersonaId: gridData[i].PersonaId

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Personas_a_IncluirData.length; i++) {
        if (removedDetalle_de_Personas_a_IncluirData[i] != null && removedDetalle_de_Personas_a_IncluirData[i].Folio > 0)
            Detalle_de_Personas_a_IncluirData.push({
                Folio: removedDetalle_de_Personas_a_IncluirData[i].Folio

                ,Persona: removedDetalle_de_Personas_a_IncluirData[i].Persona
                ,Seleccionar: removedDetalle_de_Personas_a_IncluirData[i].Seleccionar
                ,PersonaId: removedDetalle_de_Personas_a_IncluirData[i].PersonaId

                , Removed: true
            });
    }	

    return Detalle_de_Personas_a_IncluirData;
}

function Detalle_de_Personas_a_IncluirEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Personas_a_IncluirTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Personas_a_IncluircountRowsChecked++;
    var Detalle_de_Personas_a_IncluirRowElement = "Detalle_de_Personas_a_Incluir_" + rowIndex.toString();
    var prevData = Detalle_de_Personas_a_IncluirTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Personas_a_IncluirTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Personas_a_Incluir_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Personas_a_IncluirGetUpdateRowControls(prevData, "Detalle_de_Personas_a_Incluir_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Personas_a_IncluirRowElement + "')){ Detalle_de_Personas_a_IncluirInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Personas_a_IncluirCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Personas_a_IncluirGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Personas_a_IncluirGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Personas_a_IncluirValidation();
    initiateUIControls();
    $('.Detalle_de_Personas_a_Incluir' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Personas_a_IncluirfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Personas_a_IncluirTable.fnGetData().length;
    Detalle_de_Personas_a_IncluirfnClickAddRow();
    GetAddDetalle_de_Personas_a_IncluirPopup(currentRowIndex, 0);
}

function Detalle_de_Personas_a_IncluirEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Personas_a_IncluirTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Personas_a_IncluirRowElement = "Detalle_de_Personas_a_Incluir_" + rowIndex.toString();
    var prevData = Detalle_de_Personas_a_IncluirTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Personas_a_IncluirPopup(rowIndex, 1, prevData.Folio);

    $('#Detalle_de_Personas_a_IncluirPersona').val(prevData.Persona);
    $('#Detalle_de_Personas_a_IncluirSeleccionar').prop('checked', prevData.Seleccionar);
    $('#Detalle_de_Personas_a_IncluirPersonaId').val(prevData.PersonaId);

    initiateUIControls();





}

function Detalle_de_Personas_a_IncluirAddInsertRow() {
    if (Detalle_de_Personas_a_IncluirinsertRowCurrentIndex < 1)
    {
        Detalle_de_Personas_a_IncluirinsertRowCurrentIndex = 1;
    }
    return {
        Folio: null,
        IsInsertRow: true

        ,Persona: ""
        ,Seleccionar: ""
        ,PersonaId: ""

    }
}

function Detalle_de_Personas_a_IncluirfnClickAddRow() {
    Detalle_de_Personas_a_IncluircountRowsChecked++;
    Detalle_de_Personas_a_IncluirTable.fnAddData(Detalle_de_Personas_a_IncluirAddInsertRow(), true);
    Detalle_de_Personas_a_IncluirTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Personas_a_IncluirGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Personas_a_IncluirGrid tbody tr:nth-of-type(' + (Detalle_de_Personas_a_IncluirinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Personas_a_Incluir("Detalle_de_Personas_a_Incluir_", "_" + Detalle_de_Personas_a_IncluirinsertRowCurrentIndex);
}

function Detalle_de_Personas_a_IncluirClearGridData() {
    Detalle_de_Personas_a_IncluirData = [];
    Detalle_de_Personas_a_IncluirdeletedItem = [];
    Detalle_de_Personas_a_IncluirDataMain = [];
    Detalle_de_Personas_a_IncluirDataMainPages = [];
    Detalle_de_Personas_a_IncluirnewItemCount = 0;
    Detalle_de_Personas_a_IncluirmaxItemIndex = 0;
    $("#Detalle_de_Personas_a_IncluirGrid").DataTable().clear();
    $("#Detalle_de_Personas_a_IncluirGrid").DataTable().destroy();
}

//Used to Get Registro de Mandamiento Judicial Information
function GetDetalle_de_Personas_a_Incluir() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Personas_a_IncluirData.length; i++) {
        form_data.append('[' + i + '].Folio', Detalle_de_Personas_a_IncluirData[i].Folio);

        form_data.append('[' + i + '].Persona', Detalle_de_Personas_a_IncluirData[i].Persona);
        form_data.append('[' + i + '].Seleccionar', Detalle_de_Personas_a_IncluirData[i].Seleccionar);
        form_data.append('[' + i + '].PersonaId', Detalle_de_Personas_a_IncluirData[i].PersonaId);

        form_data.append('[' + i + '].Removed', Detalle_de_Personas_a_IncluirData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Personas_a_IncluirInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Personas_a_Incluir("Detalle_de_Personas_a_IncluirTable", rowIndex)) {
    var prevData = Detalle_de_Personas_a_IncluirTable.fnGetData(rowIndex);
    var data = Detalle_de_Personas_a_IncluirTable.fnGetNodes(rowIndex);
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Persona: $('#Detalle_de_Personas_a_IncluirPersona').val()
        ,Seleccionar: $('#Detalle_de_Personas_a_IncluirSeleccionar').is(':checked')
        ,PersonaId: $('#Detalle_de_Personas_a_IncluirPersonaId').val()


    }

    Detalle_de_Personas_a_IncluirTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Personas_a_IncluirrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Personas_a_Incluir-form').modal({ show: false });
    $('#AddDetalle_de_Personas_a_Incluir-form').modal('hide');
    Detalle_de_Personas_a_IncluirEditRow(rowIndex);
    Detalle_de_Personas_a_IncluirInsertRow(rowIndex);
    //}
}
function Detalle_de_Personas_a_IncluirRemoveAddRow(rowIndex) {
    Detalle_de_Personas_a_IncluirTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Personas_a_Incluir MultiRow


$(function () {
    function Detalle_de_Personas_a_IncluirinitializeMainArray(totalCount) {
        if (Detalle_de_Personas_a_IncluirDataMain.length != totalCount && !Detalle_de_Personas_a_IncluirDataMainInitialized) {
            Detalle_de_Personas_a_IncluirDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Personas_a_IncluirDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Personas_a_IncluirremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Personas_a_IncluirdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Personas_a_IncluirDataMain.length; i++) {
                if (Detalle_de_Personas_a_IncluirDataMain[i] != null && Detalle_de_Personas_a_IncluirDataMain[i].Id == Detalle_de_Personas_a_IncluirdeletedItem[j]) {
                    hDetalle_de_Personas_a_IncluirDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Personas_a_IncluircopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Personas_a_IncluirDataMain.length; i++) {
            data[i] = Detalle_de_Personas_a_IncluirDataMain[i];

        }
        return data;
    }
    function Detalle_de_Personas_a_IncluirgetNewResult() {
        var newData = copyMainDetalle_de_Personas_a_IncluirArray();

        for (var i = 0; i < Detalle_de_Personas_a_IncluirData.length; i++) {
            if (Detalle_de_Personas_a_IncluirData[i].Removed == null || Detalle_de_Personas_a_IncluirData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Personas_a_IncluirData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Personas_a_IncluirpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Personas_a_IncluirDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Personas_a_IncluirDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Usuario_que_Registra_Spartan_UserData(data) {
	AutoCompleteUsuario_que_RegistraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_RegistraData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_RegistraData;
}
var AutoCompletePais_al_que_Pertenece_la_InformacionData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Pais_al_que_Pertenece_la_Informacion_PaisData(data) {
	AutoCompletePais_al_que_Pertenece_la_InformacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_al_que_Pertenece_la_InformacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_al_que_Pertenece_la_InformacionData;
}
var AutoCompleteEstado_que_Envia_la_InformacionData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Estado_que_Envia_la_Informacion_EstadoData(data) {
	AutoCompleteEstado_que_Envia_la_InformacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_que_Envia_la_InformacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_que_Envia_la_InformacionData;
}
var AutoCompleteMunicipio_que_Envia_la_InformacionData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Municipio_que_Envia_la_Informacion_MunicipioData(data) {
	AutoCompleteMunicipio_que_Envia_la_InformacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_que_Envia_la_InformacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_que_Envia_la_InformacionData;
}
var AutoCompleteEntidad_que_Emite_MandamientoData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Entidad_que_Emite_Mandamiento_EstadoData(data) {
	AutoCompleteEntidad_que_Emite_MandamientoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEntidad_que_Emite_MandamientoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEntidad_que_Emite_MandamientoData;
}
var AutoCompleteArea_que_envia_OrdenData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Area_que_envia_Orden_UnidadData(data) {
	AutoCompleteArea_que_envia_OrdenData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteArea_que_envia_OrdenData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteArea_que_envia_OrdenData;
}
var AutoCompleteCarpeta_de_InvestigacionData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Carpeta_de_Investigacion_expediente_ministerio_publicoData(data) {
	AutoCompleteCarpeta_de_InvestigacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteCarpeta_de_InvestigacionData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteCarpeta_de_InvestigacionData;
}
var AutoCompleteCausa_PenalData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Causa_Penal_JudicializacionData(data) {
	AutoCompleteCausa_PenalData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteCausa_PenalData.push({
            id: data[i].Clave,
            text: data[i].causa_o_cuadernillo
        });
    }
    return AutoCompleteCausa_PenalData;
}
//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Registro_de_Mandamiento_Judicial_cmbLabelSelect").val();
    var dropDown = '<select id="' + elementKey + '" class="form-control"><option value="">' + labelSelect + '</option></select>';
    return dropDown;
}

function GetGridDatePicker() {
    return "<input type='text' class='fullWidth gridDatePicker xyz form-control' >";
}
function GetGridTimePicker() {
    return "<input type='text' class='fullWidth gridTimePicker form-control'  data-autoclose='true'>";
}
function GetGridTextArea() {
    return "<textarea rows='2'></textarea>";
}
function GetGridCheckBox() {
    return " <input type='checkbox' class='fullWidth'> ";
}
function GetFileUploader() {
    return "<input type='file' class='fullWidth'>";
}

function GetGridAutoComplete(data,field, id) {
    
    var dataMain = data == null ? "Select" : data;
    id ==  (id==null   || id==undefined)? "":id;
    
     return "<select class='AutoComplete fullWidth select2-dropDown " + field + " form-control' data-val='true'  ><option value='" + id +"'>" + dataMain + "</option></select>";
}

function ClearControls() {
    $("#ReferenceClave").val("0");
    $('#CreateRegistro_de_Mandamiento_Judicial')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
    $('#Pais_al_que_Pertenece_la_Informacion').empty();
    $("#Pais_al_que_Pertenece_la_Informacion").append('<option value=""></option>');
    $('#Pais_al_que_Pertenece_la_Informacion').val('0').trigger('change');
    $('#Estado_que_Envia_la_Informacion').empty();
    $("#Estado_que_Envia_la_Informacion").append('<option value=""></option>');
    $('#Estado_que_Envia_la_Informacion').val('0').trigger('change');
    $('#Municipio_que_Envia_la_Informacion').empty();
    $("#Municipio_que_Envia_la_Informacion").append('<option value=""></option>');
    $('#Municipio_que_Envia_la_Informacion').val('0').trigger('change');
    $('#Entidad_que_Emite_Mandamiento').empty();
    $("#Entidad_que_Emite_Mandamiento").append('<option value=""></option>');
    $('#Entidad_que_Emite_Mandamiento').val('0').trigger('change');
    $('#Area_que_envia_Orden').empty();
    $("#Area_que_envia_Orden").append('<option value=""></option>');
    $('#Area_que_envia_Orden').val('0').trigger('change');
    $('#Carpeta_de_Investigacion').empty();
    $("#Carpeta_de_Investigacion").append('<option value=""></option>');
    $('#Carpeta_de_Investigacion').val('0').trigger('change');
    $('#Causa_Penal').empty();
    $("#Causa_Penal").append('<option value=""></option>');
    $('#Causa_Penal').val('0').trigger('change');
                Detalle_de_Personas_a_IncluirClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateRegistro_de_Mandamiento_Judicial').trigger('reset');
    $('#CreateRegistro_de_Mandamiento_Judicial').find(':input').each(function () {
        switch (this.type) {
            case 'password':
            case 'number':
            case 'select-multiple':
            case 'select-one':
            case 'select':
            case 'text':
            case 'textarea':
                $(this).val('');
				for (instance in CKEDITOR.instances) {
                    CKEDITOR.instances[instance].updateElement();
                    CKEDITOR.instances[instance].setData('');
                }
                break;
            case 'checkbox':
            case 'radio':
                this.checked = false;
        }
    });
}
function CheckValidation() {
    var $myForm = $('#CreateRegistro_de_Mandamiento_Judicial');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Personas_a_IncluircountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Personas_a_Incluir();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateRegistro_de_Mandamiento_Judicial").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateRegistro_de_Mandamiento_Judicial").on('click', '#Registro_de_Mandamiento_JudicialCancelar', function () {
	  if (!isPartial) {
        Registro_de_Mandamiento_JudicialBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateRegistro_de_Mandamiento_Judicial").on('click', '#Registro_de_Mandamiento_JudicialGuardar', function () {
		$('#Registro_de_Mandamiento_JudicialGuardar').attr('disabled', true);
		$('#Registro_de_Mandamiento_JudicialGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendRegistro_de_Mandamiento_JudicialData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Registro_de_Mandamiento_JudicialBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Registro_de_Mandamiento_JudicialGuardar').removeAttr('disabled');
                        $('#Registro_de_Mandamiento_JudicialGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Registro_de_Mandamiento_Judicial', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Registro_de_Mandamiento_JudicialGuardar').removeAttr('disabled');
					$('#Registro_de_Mandamiento_JudicialGuardar').bind()
				}
		}
		else {
			$('#Registro_de_Mandamiento_JudicialGuardar').removeAttr('disabled');
			$('#Registro_de_Mandamiento_JudicialGuardar').bind()
		}
    });
	$("form#CreateRegistro_de_Mandamiento_Judicial").on('click', '#Registro_de_Mandamiento_JudicialGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendRegistro_de_Mandamiento_JudicialData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Personas_a_IncluirData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Registro_de_Mandamiento_Judicial', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateRegistro_de_Mandamiento_Judicial").on('click', '#Registro_de_Mandamiento_JudicialGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendRegistro_de_Mandamiento_JudicialData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
    $('#Pais_al_que_Pertenece_la_Informacion').empty();
    $("#Pais_al_que_Pertenece_la_Informacion").append('<option value=""></option>');
    $('#Pais_al_que_Pertenece_la_Informacion').val('0').trigger('change');
    $('#Estado_que_Envia_la_Informacion').empty();
    $("#Estado_que_Envia_la_Informacion").append('<option value=""></option>');
    $('#Estado_que_Envia_la_Informacion').val('0').trigger('change');
    $('#Municipio_que_Envia_la_Informacion').empty();
    $("#Municipio_que_Envia_la_Informacion").append('<option value=""></option>');
    $('#Municipio_que_Envia_la_Informacion').val('0').trigger('change');
    $('#Entidad_que_Emite_Mandamiento').empty();
    $("#Entidad_que_Emite_Mandamiento").append('<option value=""></option>');
    $('#Entidad_que_Emite_Mandamiento').val('0').trigger('change');
    $('#Area_que_envia_Orden').empty();
    $("#Area_que_envia_Orden").append('<option value=""></option>');
    $('#Area_que_envia_Orden').val('0').trigger('change');
    $('#Carpeta_de_Investigacion').empty();
    $("#Carpeta_de_Investigacion").append('<option value=""></option>');
    $('#Carpeta_de_Investigacion').val('0').trigger('change');
    $('#Causa_Penal').empty();
    $("#Causa_Penal").append('<option value=""></option>');
    $('#Causa_Penal').val('0').trigger('change');
                Detalle_de_Personas_a_IncluirClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_Personas_a_IncluirData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Registro_de_Mandamiento_Judicial',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialDropDown().get(0)').innerHTML);                          
					    }	
					}						
			setIsNew();
				});
		}
    });
});

function setIsNew() {
    $('#hdnIsNew').val("True");
	$('#Operation').val("New");
	operation = "New";
}



var mainElementObject;
var childElementObject;
function DisplayElementAttributes(data) {
}

function getElementTable(elementNumber, table) {

    for (var j = 0; j < childElementObject.length; j++) {
        if (childElementObject[j].table == table) {
            return childElementObject[j].elements[elementNumber];
            break;
        }
    }
}

function setRequired(elementNumber, element, elementType, table) {
    //debugger;
    if (elementType == "1") {
        mainElementObject[elementNumber].IsRequired = (mainElementObject[elementNumber].IsRequired == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsRequired == true ? GetTraduction('Required') : GetTraduction('NotRequired')));
        if (!mainElementObject[elementNumber].IsVisible && mainElementObject[elementNumber].IsRequired) {
            setVisible(elementNumber, $(element).parent().parent().find('div.visibleAttribute').find('a'), elementType);
        }
        if (mainElementObject[elementNumber].IsReadOnly && mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '') {
            setReadOnly(elementNumber, $(element).parent().parent().find('div.readOnlyAttribute').find('a'), elementType);
        }
    } else {
        getElementTable(elementNumber, table).IsRequired = (getElementTable(elementNumber, table).IsRequired == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsRequired == true ? GetTraduction('Required') : GetTraduction('NotRequired')));
        if (!getElementTable(elementNumber, table).IsVisible && getElementTable(elementNumber, table).IsRequired) {
            setVisible(elementNumber, $(element).parent().parent().find('div.visibleAttribute').find('a'), elementType);
        }
        if (getElementTable(elementNumber, table).IsReadOnly && getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '') {
            setReadOnly(elementNumber, $(element).parent().parent().find('div.readOnlyAttribute').find('a'), elementType);
        }
    }
}
function setVisible(elementNumber, element, elementType, table) {
    if (elementType == "1") {
        if (mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '' && mainElementObject[elementNumber].IsVisible) {
            showNotification(GetTraduction("messagedNoInVisible"), "error");
            return;
        }
        mainElementObject[elementNumber].IsVisible = (mainElementObject[elementNumber].IsVisible == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsVisible == true ? "Images/Visible.png" : "Images/inVisible.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsVisible == true ? GetTraduction('Visible') : GetTraduction('InVisible')));
    } else {
        if (getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '' && getElementTable(elementNumber, table).IsVisible) {
            showNotification(GetTraduction("messagedNoInVisible"), "error");
            return;
        }
        getElementTable(elementNumber, table).IsVisible = (getElementTable(elementNumber, table).IsVisible == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsVisible == true ? "Images/Visible.png" : "Images/inVisible.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsVisible == true ? GetTraduction('Visible') : GetTraduction('InVisible')));
    }
}
function setReadOnly(elementNumber, element, elementType, table) {
    if (elementType == "1") {
        if (mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '' && !mainElementObject[elementNumber].IsReadOnly) {
            showNotification(GetTraduction("messagedNoReadOnly"), "error");
            return;
        }
        mainElementObject[elementNumber].IsReadOnly = (mainElementObject[elementNumber].IsReadOnly == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsReadOnly == true ?GetTraduction('Disabled') : GetTraduction('Enabled')));
    } else {
        if (getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '' && !getElementTable(elementNumber, table).IsReadOnly) {
            showNotification(GetTraduction("messagedNoReadOnly"), "error");
            return;
        }
        getElementTable(elementNumber, table).IsReadOnly = (getElementTable(elementNumber, table).IsReadOnly == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsReadOnly == true ? GetTraduction('Disabled') : GetTraduction('Enabled')));
    }
}
function setDefaultValue(elementNumber, element, elementType, table) {
    //debugger;
    $('#hdnAttributType').val('1');
    $('#hdnAttributNumber').val(elementNumber);
    $('#lblAttributeType').text(GetTraduction('DefaultValue'));
    if (elementType == "1") {
        $('#txtAttributeValue').val(mainElementObject[elementNumber].DefaultValue);
        $('#hdnElementType').val("1");
    } else {
        $('#txtAttributeValue').val(getElementTable(elementNumber, table).DefaultValue);
        $('#hdnElementType').val("2");
    }
    $('#dvAttributeValue').show();
}
function setHelpText(elementNumber, element, elementType, table) {
    $('#hdnAttributType').val('2');
    $('#hdnAttributNumber').val(elementNumber);
    $('#lblAttributeType').text(GetTraduction('HelpText'));
    if (elementType == "1") {
        $('#txtAttributeValue').val(mainElementObject[elementNumber].HelpText);
        $('#hdnElementType').val("1");
    } else {
        $('#txtAttributeValue').val(getElementTable(elementNumber, table).HelpText);
        $('#hdnElementType').val("2");
    }
    $('#dvAttributeValue').show();
    //$(element).children().attr("src", "" + (mainElementObject[elementNumber].HelpText == '' ? "Images/red-help.png" : "Images/green-help.png") + "");
}
function SaveValue(table) {
    debugger;
    if ($('#hdnElementType').val() == "1") {
        if ($('#hdnAttributType').val() == "1") {
            mainElementObject[$('#hdnAttributNumber').val()].DefaultValue = $('#txtAttributeValue').val();
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[$('#hdnAttributNumber').val()].DefaultValue == '' ? "Images/Not-Default-Value.png" : "Images/default-value.png") + "");
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).attr('title', (mainElementObject[$('#hdnAttributNumber').val()].DefaultValue));
        } else if ($('#hdnAttributType').val() == "2") {
            mainElementObject[$('#hdnAttributNumber').val()].HelpText = $('#txtAttributeValue').val();
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[$('#hdnAttributNumber').val()].HelpText == '' ? "Images/red-help.jpg" : "Images/green-help.png") + "");
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).attr('title', (mainElementObject[$('#hdnAttributNumber').val()].HelpText));
        }
    } else {
        if ($('#hdnAttributType').val() == "1") {
            getElementTable($('#hdnAttributNumber').val(), table).DefaultValue = $('#txtAttributeValue').val();
            console.log(childElementObject[$('#hdnAttributNumber').val()].DefaultValue);
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable($('#hdnAttributNumber').val(), table).DefaultValue == '' ? "Images/Not-Default-Value.png" : "Images/default-value.png") + "");
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).attr('title', (getElementTable($('#hdnAttributNumber').val(), table).DefaultValue));
            console.log($('#hdnAttributNumber').val());
        } else if ($('#hdnAttributType').val() == "2") {
            getElementTable($('#hdnAttributNumber').val(), table).HelpText = $('#txtAttributeValue').val();
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable($('#hdnAttributNumber').val(), table).HelpText == '' ? "Images/red-help.jpg" : "Images/green-help.png") + "");
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).attr('title', (getElementTable($('#hdnAttributNumber').val(), table).HelpText));
        }
    }
    $('#txtAttributeValue').val('');
    $('#dvAttributeValue').hide();
}
function returnAttributeHTML(element, table, number) {
    var mainElementAttributes = '<div class="col-ld-12" style="display:inline-flex;">';
    mainElementAttributes += '<div class="displayAttributes requiredAttribute"><a class="requiredClick" title="' + (element.IsRequired == true ? GetTraduction("Required") : GetTraduction("NotRequired")) + '" onclick="setRequired(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes visibleAttribute"><a class="visibleClick" title="' + (element.IsVisible == true ? GetTraduction("Visible") : GetTraduction("InVisible")) + '" onclick="setVisible(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsVisible == true ? "Images/Visible.png" : "Images/InVisible.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes readOnlyAttribute"><a class="readOnlyClick" title="' + (element.IsReadOnly == true ?GetTraduction("Disabled") :GetTraduction("Enabled")) + '" onclick="setReadOnly(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes defaultValueAttribute"><a id="hlDefaultValueHeader_' + number.toString() + '" class="defaultValueClick" title="' + (element.DefaultValue) + '" onclick="setDefaultValue(' + number.toString() + ', this, 2,  "' + table + '")"><img src="' + $('#hdnApplicationDirectory').val() + (element.DefaultValue != '' && element.DefaultValue != null ? "Images/default-value.png" : "Images/Not-Default-Value.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes helpTextAttribute"><a id="hlHelpTextHeader_' + number.toString() + '" class="helpTextClick" title="' + (element.HelpText) + '" onclick="setHelpText(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.HelpText != '' && element.HelpText != null ? "Images/green-help.png" : "Images/red-help.jpg") + '" alt="" /></a></div>';
    mainElementAttributes += '</div>';
    return mainElementAttributes;
}



var Registro_de_Mandamiento_JudicialisdisplayBusinessPropery = false;
Registro_de_Mandamiento_JudicialDisplayBusinessRuleButtons(Registro_de_Mandamiento_JudicialisdisplayBusinessPropery);
function Registro_de_Mandamiento_JudicialDisplayBusinessRule() {
    if (!Registro_de_Mandamiento_JudicialisdisplayBusinessPropery) {
        $('#CreateRegistro_de_Mandamiento_Judicial').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Registro_de_Mandamiento_JudicialdisplayBusinessPropery"><button onclick="Registro_de_Mandamiento_JudicialGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Registro_de_Mandamiento_JudicialBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Registro_de_Mandamiento_JudicialdisplayBusinessPropery').remove();
    }
    Registro_de_Mandamiento_JudicialDisplayBusinessRuleButtons(!Registro_de_Mandamiento_JudicialisdisplayBusinessPropery);
    Registro_de_Mandamiento_JudicialisdisplayBusinessPropery = (Registro_de_Mandamiento_JudicialisdisplayBusinessPropery ? false : true);
}
function Registro_de_Mandamiento_JudicialDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

