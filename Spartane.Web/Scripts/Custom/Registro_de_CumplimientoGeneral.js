

//Begin Declarations for Foreigns fields for Personas_donde_se_ejecuto_mandamiento MultiRow
var Personas_donde_se_ejecuto_mandamientocountRowsChecked = 0;






function GetInsertPersonas_donde_se_ejecuto_mandamientoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Personas_donde_se_ejecuto_mandamiento_Persona Persona').attr('id', 'Personas_donde_se_ejecuto_mandamiento_Persona_' + index).attr('data-field', 'Persona');
    columnData[1] = $($.parseHTML(GetGridCheckBox())).addClass('Personas_donde_se_ejecuto_mandamiento_Seleccionar Seleccionar').attr('id', 'Personas_donde_se_ejecuto_mandamiento_Seleccionar_' + index).attr('data-field', 'Seleccionar');
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Personas_donde_se_ejecuto_mandamiento_PersonaId PersonaId').attr('id', 'Personas_donde_se_ejecuto_mandamiento_PersonaId_' + index).attr('data-field', 'PersonaId');


    initiateUIControls();
    return columnData;
}

function Personas_donde_se_ejecuto_mandamientoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRPersonas_donde_se_ejecuto_mandamiento("Personas_donde_se_ejecuto_mandamiento_", "_" + rowIndex)) {
    var iPage = Personas_donde_se_ejecuto_mandamientoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Personas_donde_se_ejecuto_mandamiento';
    var prevData = Personas_donde_se_ejecuto_mandamientoTable.fnGetData(rowIndex);
    var data = Personas_donde_se_ejecuto_mandamientoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Persona:  data.childNodes[counter++].childNodes[0].value
        ,Seleccionar: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,PersonaId: data.childNodes[counter++].childNodes[0].value

    }
    Personas_donde_se_ejecuto_mandamientoTable.fnUpdate(newData, rowIndex, null, true);
    Personas_donde_se_ejecuto_mandamientorowCreationGrid(data, newData, rowIndex);
    Personas_donde_se_ejecuto_mandamientoTable.fnPageChange(iPage);
    Personas_donde_se_ejecuto_mandamientocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRPersonas_donde_se_ejecuto_mandamiento("Personas_donde_se_ejecuto_mandamiento_", "_" + rowIndex);
  }
}

function Personas_donde_se_ejecuto_mandamientoCancelRow(rowIndex) {
    var prevData = Personas_donde_se_ejecuto_mandamientoTable.fnGetData(rowIndex);
    var data = Personas_donde_se_ejecuto_mandamientoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Personas_donde_se_ejecuto_mandamientoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Personas_donde_se_ejecuto_mandamientorowCreationGrid(data, prevData, rowIndex);
    }
	showPersonas_donde_se_ejecuto_mandamientoGrid(Personas_donde_se_ejecuto_mandamientoTable.fnGetData());
    Personas_donde_se_ejecuto_mandamientocountRowsChecked--;
	initiateUIControls();
}

function GetPersonas_donde_se_ejecuto_mandamientoFromDataTable() {
    var Personas_donde_se_ejecuto_mandamientoData = [];
    var gridData = Personas_donde_se_ejecuto_mandamientoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Personas_donde_se_ejecuto_mandamientoData.push({
                Folio: gridData[i].Folio

                ,Persona: gridData[i].Persona
                ,Seleccionar: gridData[i].Seleccionar
                ,PersonaId: gridData[i].PersonaId

                ,Removed: false
            });
    }

    for (i = 0; i < removedPersonas_donde_se_ejecuto_mandamientoData.length; i++) {
        if (removedPersonas_donde_se_ejecuto_mandamientoData[i] != null && removedPersonas_donde_se_ejecuto_mandamientoData[i].Folio > 0)
            Personas_donde_se_ejecuto_mandamientoData.push({
                Folio: removedPersonas_donde_se_ejecuto_mandamientoData[i].Folio

                ,Persona: removedPersonas_donde_se_ejecuto_mandamientoData[i].Persona
                ,Seleccionar: removedPersonas_donde_se_ejecuto_mandamientoData[i].Seleccionar
                ,PersonaId: removedPersonas_donde_se_ejecuto_mandamientoData[i].PersonaId

                , Removed: true
            });
    }	

    return Personas_donde_se_ejecuto_mandamientoData;
}

function Personas_donde_se_ejecuto_mandamientoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Personas_donde_se_ejecuto_mandamientoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Personas_donde_se_ejecuto_mandamientocountRowsChecked++;
    var Personas_donde_se_ejecuto_mandamientoRowElement = "Personas_donde_se_ejecuto_mandamiento_" + rowIndex.toString();
    var prevData = Personas_donde_se_ejecuto_mandamientoTable.fnGetData(rowIndexTable );
    var row = Personas_donde_se_ejecuto_mandamientoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Personas_donde_se_ejecuto_mandamiento_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Personas_donde_se_ejecuto_mandamientoGetUpdateRowControls(prevData, "Personas_donde_se_ejecuto_mandamiento_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Personas_donde_se_ejecuto_mandamientoRowElement + "')){ Personas_donde_se_ejecuto_mandamientoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Personas_donde_se_ejecuto_mandamientoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Personas_donde_se_ejecuto_mandamientoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Personas_donde_se_ejecuto_mandamientoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setPersonas_donde_se_ejecuto_mandamientoValidation();
    initiateUIControls();
    $('.Personas_donde_se_ejecuto_mandamiento' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndexFormed);
    }
}

function Personas_donde_se_ejecuto_mandamientofnOpenAddRowPopUp() {
    var currentRowIndex = Personas_donde_se_ejecuto_mandamientoTable.fnGetData().length;
    Personas_donde_se_ejecuto_mandamientofnClickAddRow();
    GetAddPersonas_donde_se_ejecuto_mandamientoPopup(currentRowIndex, 0);
}

function Personas_donde_se_ejecuto_mandamientoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Personas_donde_se_ejecuto_mandamientoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Personas_donde_se_ejecuto_mandamientoRowElement = "Personas_donde_se_ejecuto_mandamiento_" + rowIndex.toString();
    var prevData = Personas_donde_se_ejecuto_mandamientoTable.fnGetData(rowIndexTable);
    GetAddPersonas_donde_se_ejecuto_mandamientoPopup(rowIndex, 1, prevData.Folio);

    $('#Personas_donde_se_ejecuto_mandamientoPersona').val(prevData.Persona);
    $('#Personas_donde_se_ejecuto_mandamientoSeleccionar').prop('checked', prevData.Seleccionar);
    $('#Personas_donde_se_ejecuto_mandamientoPersonaId').val(prevData.PersonaId);

    initiateUIControls();





}

function Personas_donde_se_ejecuto_mandamientoAddInsertRow() {
    if (Personas_donde_se_ejecuto_mandamientoinsertRowCurrentIndex < 1)
    {
        Personas_donde_se_ejecuto_mandamientoinsertRowCurrentIndex = 1;
    }
    return {
        Folio: null,
        IsInsertRow: true

        ,Persona: ""
        ,Seleccionar: ""
        ,PersonaId: ""

    }
}

function Personas_donde_se_ejecuto_mandamientofnClickAddRow() {
    Personas_donde_se_ejecuto_mandamientocountRowsChecked++;
    Personas_donde_se_ejecuto_mandamientoTable.fnAddData(Personas_donde_se_ejecuto_mandamientoAddInsertRow(), true);
    Personas_donde_se_ejecuto_mandamientoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Personas_donde_se_ejecuto_mandamientoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Personas_donde_se_ejecuto_mandamientoGrid tbody tr:nth-of-type(' + (Personas_donde_se_ejecuto_mandamientoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRPersonas_donde_se_ejecuto_mandamiento("Personas_donde_se_ejecuto_mandamiento_", "_" + Personas_donde_se_ejecuto_mandamientoinsertRowCurrentIndex);
}

function Personas_donde_se_ejecuto_mandamientoClearGridData() {
    Personas_donde_se_ejecuto_mandamientoData = [];
    Personas_donde_se_ejecuto_mandamientodeletedItem = [];
    Personas_donde_se_ejecuto_mandamientoDataMain = [];
    Personas_donde_se_ejecuto_mandamientoDataMainPages = [];
    Personas_donde_se_ejecuto_mandamientonewItemCount = 0;
    Personas_donde_se_ejecuto_mandamientomaxItemIndex = 0;
    $("#Personas_donde_se_ejecuto_mandamientoGrid").DataTable().clear();
    $("#Personas_donde_se_ejecuto_mandamientoGrid").DataTable().destroy();
}

//Used to Get Registro de Cumplimiento Information
function GetPersonas_donde_se_ejecuto_mandamiento() {
    var form_data = new FormData();
    for (var i = 0; i < Personas_donde_se_ejecuto_mandamientoData.length; i++) {
        form_data.append('[' + i + '].Folio', Personas_donde_se_ejecuto_mandamientoData[i].Folio);

        form_data.append('[' + i + '].Persona', Personas_donde_se_ejecuto_mandamientoData[i].Persona);
        form_data.append('[' + i + '].Seleccionar', Personas_donde_se_ejecuto_mandamientoData[i].Seleccionar);
        form_data.append('[' + i + '].PersonaId', Personas_donde_se_ejecuto_mandamientoData[i].PersonaId);

        form_data.append('[' + i + '].Removed', Personas_donde_se_ejecuto_mandamientoData[i].Removed);
    }
    return form_data;
}
function Personas_donde_se_ejecuto_mandamientoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRPersonas_donde_se_ejecuto_mandamiento("Personas_donde_se_ejecuto_mandamientoTable", rowIndex)) {
    var prevData = Personas_donde_se_ejecuto_mandamientoTable.fnGetData(rowIndex);
    var data = Personas_donde_se_ejecuto_mandamientoTable.fnGetNodes(rowIndex);
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Persona: $('#Personas_donde_se_ejecuto_mandamientoPersona').val()
        ,Seleccionar: $('#Personas_donde_se_ejecuto_mandamientoSeleccionar').is(':checked')
        ,PersonaId: $('#Personas_donde_se_ejecuto_mandamientoPersonaId').val()


    }

    Personas_donde_se_ejecuto_mandamientoTable.fnUpdate(newData, rowIndex, null, true);
    Personas_donde_se_ejecuto_mandamientorowCreationGrid(data, newData, rowIndex);
    $('#AddPersonas_donde_se_ejecuto_mandamiento-form').modal({ show: false });
    $('#AddPersonas_donde_se_ejecuto_mandamiento-form').modal('hide');
    Personas_donde_se_ejecuto_mandamientoEditRow(rowIndex);
    Personas_donde_se_ejecuto_mandamientoInsertRow(rowIndex);
    //}
}
function Personas_donde_se_ejecuto_mandamientoRemoveAddRow(rowIndex) {
    Personas_donde_se_ejecuto_mandamientoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Personas_donde_se_ejecuto_mandamiento MultiRow


$(function () {
    function Personas_donde_se_ejecuto_mandamientoinitializeMainArray(totalCount) {
        if (Personas_donde_se_ejecuto_mandamientoDataMain.length != totalCount && !Personas_donde_se_ejecuto_mandamientoDataMainInitialized) {
            Personas_donde_se_ejecuto_mandamientoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Personas_donde_se_ejecuto_mandamientoDataMain[i] = null;
            }
        }
    }
    function Personas_donde_se_ejecuto_mandamientoremoveFromMainArray() {
        for (var j = 0; j < Personas_donde_se_ejecuto_mandamientodeletedItem.length; j++) {
            for (var i = 0; i < Personas_donde_se_ejecuto_mandamientoDataMain.length; i++) {
                if (Personas_donde_se_ejecuto_mandamientoDataMain[i] != null && Personas_donde_se_ejecuto_mandamientoDataMain[i].Id == Personas_donde_se_ejecuto_mandamientodeletedItem[j]) {
                    hPersonas_donde_se_ejecuto_mandamientoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Personas_donde_se_ejecuto_mandamientocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Personas_donde_se_ejecuto_mandamientoDataMain.length; i++) {
            data[i] = Personas_donde_se_ejecuto_mandamientoDataMain[i];

        }
        return data;
    }
    function Personas_donde_se_ejecuto_mandamientogetNewResult() {
        var newData = copyMainPersonas_donde_se_ejecuto_mandamientoArray();

        for (var i = 0; i < Personas_donde_se_ejecuto_mandamientoData.length; i++) {
            if (Personas_donde_se_ejecuto_mandamientoData[i].Removed == null || Personas_donde_se_ejecuto_mandamientoData[i].Removed == false) {
                newData.splice(0, 0, Personas_donde_se_ejecuto_mandamientoData[i]);
            }
        }
        return newData;
    }
    function Personas_donde_se_ejecuto_mandamientopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Personas_donde_se_ejecuto_mandamientoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Personas_donde_se_ejecuto_mandamientoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteMandamiento_JudicialData = [];
function GetAutoCompleteRegistro_de_Cumplimiento_Mandamiento_Judicial_Registro_de_Mandamiento_JudicialData(data) {
	AutoCompleteMandamiento_JudicialData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMandamiento_JudicialData.push({
            id: data[i].Clave,
            text: data[i].Numero_de_Mandamiento
        });
    }
    return AutoCompleteMandamiento_JudicialData;
}
var AutoCompleteUsuario_de_RegistroData = [];
function GetAutoCompleteRegistro_de_Cumplimiento_Usuario_de_Registro_Spartan_UserData(data) {
	AutoCompleteUsuario_de_RegistroData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_de_RegistroData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_de_RegistroData;
}
var AutoCompleteEstadoData = [];
function GetAutoCompleteRegistro_de_Cumplimiento_Estado_EstadoData(data) {
	AutoCompleteEstadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstadoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstadoData;
}
var AutoCompleteMunicipioData = [];
function GetAutoCompleteRegistro_de_Cumplimiento_Municipio_MunicipioData(data) {
	AutoCompleteMunicipioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioData;
}
var AutoCompletePoblacionData = [];
function GetAutoCompleteRegistro_de_Cumplimiento_Poblacion_ColoniaData(data) {
	AutoCompletePoblacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePoblacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePoblacionData;
}
var AutoCompleteColoniaData = [];
function GetAutoCompleteRegistro_de_Cumplimiento_Colonia_ColoniaData(data) {
	AutoCompleteColoniaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaData;
}
//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Registro_de_Cumplimiento_cmbLabelSelect").val();
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
    $('#CreateRegistro_de_Cumplimiento')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Mandamiento_Judicial').empty();
    $("#Mandamiento_Judicial").append('<option value=""></option>');
    $('#Mandamiento_Judicial').val('0').trigger('change');
    $('#Usuario_de_Registro').empty();
    $("#Usuario_de_Registro").append('<option value=""></option>');
    $('#Usuario_de_Registro').val('0').trigger('change');
    $('#Estado').empty();
    $("#Estado").append('<option value=""></option>');
    $('#Estado').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Poblacion').empty();
    $("#Poblacion").append('<option value=""></option>');
    $('#Poblacion').val('0').trigger('change');
    $('#Colonia').empty();
    $("#Colonia").append('<option value=""></option>');
    $('#Colonia').val('0').trigger('change');
                Personas_donde_se_ejecuto_mandamientoClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateRegistro_de_Cumplimiento').trigger('reset');
    $('#CreateRegistro_de_Cumplimiento').find(':input').each(function () {
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
    var $myForm = $('#CreateRegistro_de_Cumplimiento');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Personas_donde_se_ejecuto_mandamientocountRowsChecked > 0)
    {
        ShowMessagePendingRowPersonas_donde_se_ejecuto_mandamiento();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateRegistro_de_Cumplimiento").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateRegistro_de_Cumplimiento").on('click', '#Registro_de_CumplimientoCancelar', function () {
	  if (!isPartial) {
        Registro_de_CumplimientoBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateRegistro_de_Cumplimiento").on('click', '#Registro_de_CumplimientoGuardar', function () {
		$('#Registro_de_CumplimientoGuardar').attr('disabled', true);
		$('#Registro_de_CumplimientoGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendRegistro_de_CumplimientoData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Registro_de_CumplimientoBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Registro_de_CumplimientoGuardar').removeAttr('disabled');
                        $('#Registro_de_CumplimientoGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Registro_de_Cumplimiento', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Registro_de_CumplimientoItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Registro_de_CumplimientoDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Registro_de_CumplimientoGuardar').removeAttr('disabled');
					$('#Registro_de_CumplimientoGuardar').bind()
				}
		}
		else {
			$('#Registro_de_CumplimientoGuardar').removeAttr('disabled');
			$('#Registro_de_CumplimientoGuardar').bind()
		}
    });
	$("form#CreateRegistro_de_Cumplimiento").on('click', '#Registro_de_CumplimientoGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendRegistro_de_CumplimientoData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getPersonas_donde_se_ejecuto_mandamientoData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Registro_de_Cumplimiento', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Registro_de_CumplimientoItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Registro_de_CumplimientoDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateRegistro_de_Cumplimiento").on('click', '#Registro_de_CumplimientoGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendRegistro_de_CumplimientoData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Mandamiento_Judicial').empty();
    $("#Mandamiento_Judicial").append('<option value=""></option>');
    $('#Mandamiento_Judicial').val('0').trigger('change');
    $('#Usuario_de_Registro').empty();
    $("#Usuario_de_Registro").append('<option value=""></option>');
    $('#Usuario_de_Registro').val('0').trigger('change');
    $('#Estado').empty();
    $("#Estado").append('<option value=""></option>');
    $('#Estado').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Poblacion').empty();
    $("#Poblacion").append('<option value=""></option>');
    $('#Poblacion').val('0').trigger('change');
    $('#Colonia').empty();
    $("#Colonia").append('<option value=""></option>');
    $('#Colonia').val('0').trigger('change');
                Personas_donde_se_ejecuto_mandamientoClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getPersonas_donde_se_ejecuto_mandamientoData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Registro_de_Cumplimiento',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Registro_de_CumplimientoItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Registro_de_CumplimientoDropDown().get(0)').innerHTML);                          
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



var Registro_de_CumplimientoisdisplayBusinessPropery = false;
Registro_de_CumplimientoDisplayBusinessRuleButtons(Registro_de_CumplimientoisdisplayBusinessPropery);
function Registro_de_CumplimientoDisplayBusinessRule() {
    if (!Registro_de_CumplimientoisdisplayBusinessPropery) {
        $('#CreateRegistro_de_Cumplimiento').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Registro_de_CumplimientodisplayBusinessPropery"><button onclick="Registro_de_CumplimientoGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Registro_de_CumplimientoBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Registro_de_CumplimientodisplayBusinessPropery').remove();
    }
    Registro_de_CumplimientoDisplayBusinessRuleButtons(!Registro_de_CumplimientoisdisplayBusinessPropery);
    Registro_de_CumplimientoisdisplayBusinessPropery = (Registro_de_CumplimientoisdisplayBusinessPropery ? false : true);
}
function Registro_de_CumplimientoDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

