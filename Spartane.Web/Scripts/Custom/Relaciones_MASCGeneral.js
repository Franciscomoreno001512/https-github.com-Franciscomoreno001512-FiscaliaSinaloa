

//Begin Declarations for Foreigns fields for Detalle_Relaciones_MASC MultiRow
var Detalle_Relaciones_MASCcountRowsChecked = 0;

function GetDetalle_Relaciones_MASC_Detalle_de_ImputadoName(Id) {
    for (var i = 0; i < Detalle_Relaciones_MASC_Detalle_de_ImputadoItems.length; i++) {
        if (Detalle_Relaciones_MASC_Detalle_de_ImputadoItems[i].Clave == Id) {
            return Detalle_Relaciones_MASC_Detalle_de_ImputadoItems[i].Nombre_Completo_Detenido;
        }
    }
    return "";
}

function GetDetalle_Relaciones_MASC_Detalle_de_ImputadoDropDown() {
    var Detalle_Relaciones_MASC_Detalle_de_ImputadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Relaciones_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Relaciones_MASC_Detalle_de_ImputadoDropdown);

    for (var i = 0; i < Detalle_Relaciones_MASC_Detalle_de_ImputadoItems.length; i++) {
        $('<option />', { value: Detalle_Relaciones_MASC_Detalle_de_ImputadoItems[i].Clave, text: Detalle_Relaciones_MASC_Detalle_de_ImputadoItems[i].Nombre_Completo_Detenido }).appendTo(Detalle_Relaciones_MASC_Detalle_de_ImputadoDropdown);
    }
    return Detalle_Relaciones_MASC_Detalle_de_ImputadoDropdown;
}
function GetDetalle_Relaciones_MASC_DelitoName(Id) {
    for (var i = 0; i < Detalle_Relaciones_MASC_DelitoItems.length; i++) {
        if (Detalle_Relaciones_MASC_DelitoItems[i].Clave == Id) {
            return Detalle_Relaciones_MASC_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Relaciones_MASC_DelitoDropDown() {
    var Detalle_Relaciones_MASC_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Relaciones_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Relaciones_MASC_DelitoDropdown);

    for (var i = 0; i < Detalle_Relaciones_MASC_DelitoItems.length; i++) {
        $('<option />', { value: Detalle_Relaciones_MASC_DelitoItems[i].Clave, text: Detalle_Relaciones_MASC_DelitoItems[i].Descripcion }).appendTo(Detalle_Relaciones_MASC_DelitoDropdown);
    }
    return Detalle_Relaciones_MASC_DelitoDropdown;
}
function GetDetalle_Relaciones_MASC_Detalle_de_Datos_GeneralesName(Id) {
    for (var i = 0; i < Detalle_Relaciones_MASC_Detalle_de_Datos_GeneralesItems.length; i++) {
        if (Detalle_Relaciones_MASC_Detalle_de_Datos_GeneralesItems[i].Clave == Id) {
            return Detalle_Relaciones_MASC_Detalle_de_Datos_GeneralesItems[i].Nombre_Completo;
        }
    }
    return "";
}

function GetDetalle_Relaciones_MASC_Detalle_de_Datos_GeneralesDropDown() {
    var Detalle_Relaciones_MASC_Detalle_de_Datos_GeneralesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Relaciones_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Relaciones_MASC_Detalle_de_Datos_GeneralesDropdown);

    for (var i = 0; i < Detalle_Relaciones_MASC_Detalle_de_Datos_GeneralesItems.length; i++) {
        $('<option />', { value: Detalle_Relaciones_MASC_Detalle_de_Datos_GeneralesItems[i].Clave, text: Detalle_Relaciones_MASC_Detalle_de_Datos_GeneralesItems[i].Nombre_Completo }).appendTo(Detalle_Relaciones_MASC_Detalle_de_Datos_GeneralesDropdown);
    }
    return Detalle_Relaciones_MASC_Detalle_de_Datos_GeneralesDropdown;
}


function GetInsertDetalle_Relaciones_MASCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Relaciones_MASC_Requerido'))).addClass('Detalle_Relaciones_MASC_Requerido Requerido').attr('id', 'Detalle_Relaciones_MASC_Requerido_' + index).attr('data-field', 'Requerido').after($.parseHTML(addNew('Detalle_Relaciones_MASC', 'Detalle_de_Imputado', 'Requerido', 269182)));
    columnData[1] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Relaciones_MASC_Delito'))).addClass('Detalle_Relaciones_MASC_Delito Delito').attr('id', 'Detalle_Relaciones_MASC_Delito_' + index).attr('data-field', 'Delito').after($.parseHTML(addNew('Detalle_Relaciones_MASC', 'Delito', 'Delito', 269183)));
    columnData[2] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Relaciones_MASC_Solicitante'))).addClass('Detalle_Relaciones_MASC_Solicitante Solicitante').attr('id', 'Detalle_Relaciones_MASC_Solicitante_' + index).attr('data-field', 'Solicitante').after($.parseHTML(addNew('Detalle_Relaciones_MASC', 'Detalle_de_Datos_Generales', 'Solicitante', 269184)));


    initiateUIControls();
    return columnData;
}

function Detalle_Relaciones_MASCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Relaciones_MASC("Detalle_Relaciones_MASC_", "_" + rowIndex)) {
    var iPage = Detalle_Relaciones_MASCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Relaciones_MASC';
    var prevData = Detalle_Relaciones_MASCTable.fnGetData(rowIndex);
    var data = Detalle_Relaciones_MASCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , RequeridoNombre_Completo_Detenido:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Requerido:  data.childNodes[counter++].childNodes[0].value 	
        , DelitoDescripcion:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Delito:  data.childNodes[counter++].childNodes[0].value 	
        , SolicitanteNombre_Completo:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Solicitante:  data.childNodes[counter++].childNodes[0].value 	

    }
    Detalle_Relaciones_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Relaciones_MASCrowCreationGrid(data, newData, rowIndex);
    Detalle_Relaciones_MASCTable.fnPageChange(iPage);
    Detalle_Relaciones_MASCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Relaciones_MASC("Detalle_Relaciones_MASC_", "_" + rowIndex);
  }
}

function Detalle_Relaciones_MASCCancelRow(rowIndex) {
    var prevData = Detalle_Relaciones_MASCTable.fnGetData(rowIndex);
    var data = Detalle_Relaciones_MASCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Relaciones_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Relaciones_MASCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Relaciones_MASCGrid(Detalle_Relaciones_MASCTable.fnGetData());
    Detalle_Relaciones_MASCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Relaciones_MASCFromDataTable() {
    var Detalle_Relaciones_MASCData = [];
    var gridData = Detalle_Relaciones_MASCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Relaciones_MASCData.push({
                Clave: gridData[i].Clave

                ,Requerido: gridData[i].Requerido
                ,Delito: gridData[i].Delito
                ,Solicitante: gridData[i].Solicitante

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Relaciones_MASCData.length; i++) {
        if (removedDetalle_Relaciones_MASCData[i] != null && removedDetalle_Relaciones_MASCData[i].Clave > 0)
            Detalle_Relaciones_MASCData.push({
                Clave: removedDetalle_Relaciones_MASCData[i].Clave

                ,Requerido: removedDetalle_Relaciones_MASCData[i].Requerido
                ,Delito: removedDetalle_Relaciones_MASCData[i].Delito
                ,Solicitante: removedDetalle_Relaciones_MASCData[i].Solicitante

                , Removed: true
            });
    }	

    return Detalle_Relaciones_MASCData;
}

function Detalle_Relaciones_MASCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Relaciones_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Relaciones_MASCcountRowsChecked++;
    var Detalle_Relaciones_MASCRowElement = "Detalle_Relaciones_MASC_" + rowIndex.toString();
    var prevData = Detalle_Relaciones_MASCTable.fnGetData(rowIndexTable );
    var row = Detalle_Relaciones_MASCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Relaciones_MASC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Relaciones_MASCGetUpdateRowControls(prevData, "Detalle_Relaciones_MASC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Relaciones_MASCRowElement + "')){ Detalle_Relaciones_MASCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Relaciones_MASCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Relaciones_MASCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Relaciones_MASCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Relaciones_MASCValidation();
    initiateUIControls();
    $('.Detalle_Relaciones_MASC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Relaciones_MASC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Relaciones_MASCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Relaciones_MASCTable.fnGetData().length;
    Detalle_Relaciones_MASCfnClickAddRow();
    GetAddDetalle_Relaciones_MASCPopup(currentRowIndex, 0);
}

function Detalle_Relaciones_MASCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Relaciones_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Relaciones_MASCRowElement = "Detalle_Relaciones_MASC_" + rowIndex.toString();
    var prevData = Detalle_Relaciones_MASCTable.fnGetData(rowIndexTable);
    GetAddDetalle_Relaciones_MASCPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_Relaciones_MASCRequerido').html($($.parseHTML(GetGridAutoComplete(prevData.Requerido.label,'AutoCompleteRequerido'))).addClass('Detalle_Relaciones_MASC_Requerido'));
    $('#dvDetalle_Relaciones_MASCDelito').html($($.parseHTML(GetGridAutoComplete(prevData.Delito.label,'AutoCompleteDelito'))).addClass('Detalle_Relaciones_MASC_Delito'));
    $('#dvDetalle_Relaciones_MASCSolicitante').html($($.parseHTML(GetGridAutoComplete(prevData.Solicitante.label,'AutoCompleteSolicitante'))).addClass('Detalle_Relaciones_MASC_Solicitante'));

    initiateUIControls();





}

function Detalle_Relaciones_MASCAddInsertRow() {
    if (Detalle_Relaciones_MASCinsertRowCurrentIndex < 1)
    {
        Detalle_Relaciones_MASCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Requerido: ""
        ,Delito: ""
        ,Solicitante: ""

    }
}

function Detalle_Relaciones_MASCfnClickAddRow() {
    Detalle_Relaciones_MASCcountRowsChecked++;
    Detalle_Relaciones_MASCTable.fnAddData(Detalle_Relaciones_MASCAddInsertRow(), true);
    Detalle_Relaciones_MASCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Relaciones_MASCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Relaciones_MASCGrid tbody tr:nth-of-type(' + (Detalle_Relaciones_MASCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Relaciones_MASC("Detalle_Relaciones_MASC_", "_" + Detalle_Relaciones_MASCinsertRowCurrentIndex);
}

function Detalle_Relaciones_MASCClearGridData() {
    Detalle_Relaciones_MASCData = [];
    Detalle_Relaciones_MASCdeletedItem = [];
    Detalle_Relaciones_MASCDataMain = [];
    Detalle_Relaciones_MASCDataMainPages = [];
    Detalle_Relaciones_MASCnewItemCount = 0;
    Detalle_Relaciones_MASCmaxItemIndex = 0;
    $("#Detalle_Relaciones_MASCGrid").DataTable().clear();
    $("#Detalle_Relaciones_MASCGrid").DataTable().destroy();
}

//Used to Get Relaciones MASC Information
function GetDetalle_Relaciones_MASC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Relaciones_MASCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Relaciones_MASCData[i].Clave);

        form_data.append('[' + i + '].Requerido', Detalle_Relaciones_MASCData[i].Requerido);
        form_data.append('[' + i + '].Delito', Detalle_Relaciones_MASCData[i].Delito);
        form_data.append('[' + i + '].Solicitante', Detalle_Relaciones_MASCData[i].Solicitante);

        form_data.append('[' + i + '].Removed', Detalle_Relaciones_MASCData[i].Removed);
    }
    return form_data;
}
function Detalle_Relaciones_MASCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Relaciones_MASC("Detalle_Relaciones_MASCTable", rowIndex)) {
    var prevData = Detalle_Relaciones_MASCTable.fnGetData(rowIndex);
    var data = Detalle_Relaciones_MASCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Requerido: $('#Detalle_Relaciones_MASCRequerido').val()
        ,Delito: $('#Detalle_Relaciones_MASCDelito').val()
        ,Solicitante: $('#Detalle_Relaciones_MASCSolicitante').val()

    }

    Detalle_Relaciones_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Relaciones_MASCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Relaciones_MASC-form').modal({ show: false });
    $('#AddDetalle_Relaciones_MASC-form').modal('hide');
    Detalle_Relaciones_MASCEditRow(rowIndex);
    Detalle_Relaciones_MASCInsertRow(rowIndex);
    //}
}
function Detalle_Relaciones_MASCRemoveAddRow(rowIndex) {
    Detalle_Relaciones_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Relaciones_MASC MultiRow


$(function () {
    function Detalle_Relaciones_MASCinitializeMainArray(totalCount) {
        if (Detalle_Relaciones_MASCDataMain.length != totalCount && !Detalle_Relaciones_MASCDataMainInitialized) {
            Detalle_Relaciones_MASCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Relaciones_MASCDataMain[i] = null;
            }
        }
    }
    function Detalle_Relaciones_MASCremoveFromMainArray() {
        for (var j = 0; j < Detalle_Relaciones_MASCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Relaciones_MASCDataMain.length; i++) {
                if (Detalle_Relaciones_MASCDataMain[i] != null && Detalle_Relaciones_MASCDataMain[i].Id == Detalle_Relaciones_MASCdeletedItem[j]) {
                    hDetalle_Relaciones_MASCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Relaciones_MASCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Relaciones_MASCDataMain.length; i++) {
            data[i] = Detalle_Relaciones_MASCDataMain[i];

        }
        return data;
    }
    function Detalle_Relaciones_MASCgetNewResult() {
        var newData = copyMainDetalle_Relaciones_MASCArray();

        for (var i = 0; i < Detalle_Relaciones_MASCData.length; i++) {
            if (Detalle_Relaciones_MASCData[i].Removed == null || Detalle_Relaciones_MASCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Relaciones_MASCData[i]);
            }
        }
        return newData;
    }
    function Detalle_Relaciones_MASCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Relaciones_MASCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Relaciones_MASCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteNumero_de_ExpedienteData = [];
function GetAutoCompleteRelaciones_MASC_Numero_de_Expediente_SolicitudData(data) {
	AutoCompleteNumero_de_ExpedienteData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNumero_de_ExpedienteData.push({
            id: data[i].Clave,
            text: data[i].Numero_de_Expediente
        });
    }
    return AutoCompleteNumero_de_ExpedienteData;
}
//Grid GetAutocomplete
var AutoCompleteRequeridoData = [];
function GetAutoCompleteDetalle_Relaciones_MASC_Requerido_Detalle_de_ImputadoData(data) {
	AutoCompleteRequeridoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteRequeridoData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo_Detenido
        });
    }
    return AutoCompleteRequeridoData;
}
var AutoCompleteDelitoData = [];
function GetAutoCompleteDetalle_Relaciones_MASC_Delito_DelitoData(data) {
	AutoCompleteDelitoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteDelitoData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteDelitoData;
}
var AutoCompleteSolicitanteData = [];
function GetAutoCompleteDetalle_Relaciones_MASC_Solicitante_Detalle_de_Datos_GeneralesData(data) {
	AutoCompleteSolicitanteData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteSolicitanteData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo
        });
    }
    return AutoCompleteSolicitanteData;
}

var AutoCompleteUsuario_que_Resuelve_solicitudData = [];
function GetAutoCompleteRelaciones_MASC_Usuario_que_Resuelve_solicitud_Spartan_UserData(data) {
	AutoCompleteUsuario_que_Resuelve_solicitudData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_Resuelve_solicitudData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_Resuelve_solicitudData;
}
var AutoCompleteUsuario_que_Valida_solicitudData = [];
function GetAutoCompleteRelaciones_MASC_Usuario_que_Valida_solicitud_Spartan_UserData(data) {
	AutoCompleteUsuario_que_Valida_solicitudData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_Valida_solicitudData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_Valida_solicitudData;
}
var AutoCompleteusuario_resuelve_procData = [];
function GetAutoCompleteRelaciones_MASC_usuario_resuelve_proc_Spartan_UserData(data) {
	AutoCompleteusuario_resuelve_procData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteusuario_resuelve_procData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteusuario_resuelve_procData;
}
var AutoCompleteUsuario_que_Valida_procData = [];
function GetAutoCompleteRelaciones_MASC_Usuario_que_Valida_proc_Spartan_UserData(data) {
	AutoCompleteUsuario_que_Valida_procData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_Valida_procData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_Valida_procData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#Relaciones_MASC_cmbLabelSelect").val();
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
    $('#CreateRelaciones_MASC')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Numero_de_Expediente').empty();
    $("#Numero_de_Expediente").append('<option value=""></option>');
    $('#Numero_de_Expediente').val('0').trigger('change');
                Detalle_Relaciones_MASCClearGridData();
    $('#Usuario_que_Resuelve_solicitud').empty();
    $("#Usuario_que_Resuelve_solicitud").append('<option value=""></option>');
    $('#Usuario_que_Resuelve_solicitud').val('0').trigger('change');
    $('#Usuario_que_Valida_solicitud').empty();
    $("#Usuario_que_Valida_solicitud").append('<option value=""></option>');
    $('#Usuario_que_Valida_solicitud').val('0').trigger('change');
    $('#usuario_resuelve_proc').empty();
    $("#usuario_resuelve_proc").append('<option value=""></option>');
    $('#usuario_resuelve_proc').val('0').trigger('change');
    $('#Usuario_que_Valida_proc').empty();
    $("#Usuario_que_Valida_proc").append('<option value=""></option>');
    $('#Usuario_que_Valida_proc').val('0').trigger('change');

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateRelaciones_MASC').trigger('reset');
    $('#CreateRelaciones_MASC').find(':input').each(function () {
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
    var $myForm = $('#CreateRelaciones_MASC');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Relaciones_MASCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Relaciones_MASC();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateRelaciones_MASC").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateRelaciones_MASC").on('click', '#Relaciones_MASCCancelar', function () {
	  if (!isPartial) {
        Relaciones_MASCBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateRelaciones_MASC").on('click', '#Relaciones_MASCGuardar', function () {
		$('#Relaciones_MASCGuardar').attr('disabled', true);
		$('#Relaciones_MASCGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendRelaciones_MASCData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Relaciones_MASCBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Relaciones_MASCGuardar').removeAttr('disabled');
                        $('#Relaciones_MASCGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Relaciones_MASC', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Relaciones_MASCItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Relaciones_MASCDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Relaciones_MASCGuardar').removeAttr('disabled');
					$('#Relaciones_MASCGuardar').bind()
				}
		}
		else {
			$('#Relaciones_MASCGuardar').removeAttr('disabled');
			$('#Relaciones_MASCGuardar').bind()
		}
    });
	$("form#CreateRelaciones_MASC").on('click', '#Relaciones_MASCGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendRelaciones_MASCData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Relaciones_MASCData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Relaciones_MASC', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Relaciones_MASCItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Relaciones_MASCDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateRelaciones_MASC").on('click', '#Relaciones_MASCGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendRelaciones_MASCData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Numero_de_Expediente').empty();
    $("#Numero_de_Expediente").append('<option value=""></option>');
    $('#Numero_de_Expediente').val('0').trigger('change');
                Detalle_Relaciones_MASCClearGridData();
    $('#Usuario_que_Resuelve_solicitud').empty();
    $("#Usuario_que_Resuelve_solicitud").append('<option value=""></option>');
    $('#Usuario_que_Resuelve_solicitud').val('0').trigger('change');
    $('#Usuario_que_Valida_solicitud').empty();
    $("#Usuario_que_Valida_solicitud").append('<option value=""></option>');
    $('#Usuario_que_Valida_solicitud').val('0').trigger('change');
    $('#usuario_resuelve_proc').empty();
    $("#usuario_resuelve_proc").append('<option value=""></option>');
    $('#usuario_resuelve_proc').val('0').trigger('change');
    $('#Usuario_que_Valida_proc').empty();
    $("#Usuario_que_Valida_proc").append('<option value=""></option>');
    $('#Usuario_que_Valida_proc').val('0').trigger('change');

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Relaciones_MASCData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Relaciones_MASC',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Relaciones_MASCItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Relaciones_MASCDropDown().get(0)').innerHTML);                          
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



var Relaciones_MASCisdisplayBusinessPropery = false;
Relaciones_MASCDisplayBusinessRuleButtons(Relaciones_MASCisdisplayBusinessPropery);
function Relaciones_MASCDisplayBusinessRule() {
    if (!Relaciones_MASCisdisplayBusinessPropery) {
        $('#CreateRelaciones_MASC').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Relaciones_MASCdisplayBusinessPropery"><button onclick="Relaciones_MASCGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Relaciones_MASCBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Relaciones_MASCdisplayBusinessPropery').remove();
    }
    Relaciones_MASCDisplayBusinessRuleButtons(!Relaciones_MASCisdisplayBusinessPropery);
    Relaciones_MASCisdisplayBusinessPropery = (Relaciones_MASCisdisplayBusinessPropery ? false : true);
}
function Relaciones_MASCDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

