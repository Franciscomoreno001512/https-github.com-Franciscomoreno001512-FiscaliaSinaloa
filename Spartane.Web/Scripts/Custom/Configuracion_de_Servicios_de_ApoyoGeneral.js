

//Begin Declarations for Foreigns fields for Detalle_Solicitud_Disponibles_Configuracion MultiRow
var Detalle_Solicitud_Disponibles_ConfiguracioncountRowsChecked = 0;

function GetDetalle_Solicitud_Disponibles_Configuracion_DocumentoName(Id) {
    for (var i = 0; i < Detalle_Solicitud_Disponibles_Configuracion_DocumentoItems.length; i++) {
        if (Detalle_Solicitud_Disponibles_Configuracion_DocumentoItems[i].Clave == Id) {
            return Detalle_Solicitud_Disponibles_Configuracion_DocumentoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Solicitud_Disponibles_Configuracion_DocumentoDropDown() {
    var Detalle_Solicitud_Disponibles_Configuracion_DocumentoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Solicitud_Disponibles_Configuracion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Solicitud_Disponibles_Configuracion_DocumentoDropdown);

    for (var i = 0; i < Detalle_Solicitud_Disponibles_Configuracion_DocumentoItems.length; i++) {
        $('<option />', { value: Detalle_Solicitud_Disponibles_Configuracion_DocumentoItems[i].Clave, text: Detalle_Solicitud_Disponibles_Configuracion_DocumentoItems[i].Descripcion }).appendTo(Detalle_Solicitud_Disponibles_Configuracion_DocumentoDropdown);
    }
    return Detalle_Solicitud_Disponibles_Configuracion_DocumentoDropdown;
}


function GetInsertDetalle_Solicitud_Disponibles_ConfiguracionRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Solicitud_Disponibles_Configuracion_Documento'))).addClass('Detalle_Solicitud_Disponibles_Configuracion_Documento Documento').attr('id', 'Detalle_Solicitud_Disponibles_Configuracion_Documento_' + index).attr('data-field', 'Documento').after($.parseHTML(addNew('Detalle_Solicitud_Disponibles_Configuracion', 'Documento', 'Documento', 273102)));


    initiateUIControls();
    return columnData;
}

function Detalle_Solicitud_Disponibles_ConfiguracionInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Solicitud_Disponibles_Configuracion("Detalle_Solicitud_Disponibles_Configuracion_", "_" + rowIndex)) {
    var iPage = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Solicitud_Disponibles_Configuracion';
    var prevData = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetData(rowIndex);
    var data = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , DocumentoDescripcion:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Documento:  data.childNodes[counter++].childNodes[0].value 	

    }
    Detalle_Solicitud_Disponibles_ConfiguracionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Solicitud_Disponibles_ConfiguracionrowCreationGrid(data, newData, rowIndex);
    Detalle_Solicitud_Disponibles_ConfiguracionTable.fnPageChange(iPage);
    Detalle_Solicitud_Disponibles_ConfiguracioncountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Solicitud_Disponibles_Configuracion("Detalle_Solicitud_Disponibles_Configuracion_", "_" + rowIndex);
  }
}

function Detalle_Solicitud_Disponibles_ConfiguracionCancelRow(rowIndex) {
    var prevData = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetData(rowIndex);
    var data = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Solicitud_Disponibles_ConfiguracionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Solicitud_Disponibles_ConfiguracionrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Solicitud_Disponibles_ConfiguracionGrid(Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetData());
    Detalle_Solicitud_Disponibles_ConfiguracioncountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Solicitud_Disponibles_ConfiguracionFromDataTable() {
    var Detalle_Solicitud_Disponibles_ConfiguracionData = [];
    var gridData = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Solicitud_Disponibles_ConfiguracionData.push({
                Clave: gridData[i].Clave

                ,Documento: gridData[i].Documento

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Solicitud_Disponibles_ConfiguracionData.length; i++) {
        if (removedDetalle_Solicitud_Disponibles_ConfiguracionData[i] != null && removedDetalle_Solicitud_Disponibles_ConfiguracionData[i].Clave > 0)
            Detalle_Solicitud_Disponibles_ConfiguracionData.push({
                Clave: removedDetalle_Solicitud_Disponibles_ConfiguracionData[i].Clave

                ,Documento: removedDetalle_Solicitud_Disponibles_ConfiguracionData[i].Documento

                , Removed: true
            });
    }	

    return Detalle_Solicitud_Disponibles_ConfiguracionData;
}

function Detalle_Solicitud_Disponibles_ConfiguracionEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Solicitud_Disponibles_ConfiguracioncountRowsChecked++;
    var Detalle_Solicitud_Disponibles_ConfiguracionRowElement = "Detalle_Solicitud_Disponibles_Configuracion_" + rowIndex.toString();
    var prevData = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetData(rowIndexTable );
    var row = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Solicitud_Disponibles_Configuracion_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Solicitud_Disponibles_ConfiguracionGetUpdateRowControls(prevData, "Detalle_Solicitud_Disponibles_Configuracion_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Solicitud_Disponibles_ConfiguracionRowElement + "')){ Detalle_Solicitud_Disponibles_ConfiguracionInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Solicitud_Disponibles_ConfiguracionCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Solicitud_Disponibles_ConfiguracionGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Solicitud_Disponibles_ConfiguracionGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Solicitud_Disponibles_ConfiguracionValidation();
    initiateUIControls();
    $('.Detalle_Solicitud_Disponibles_Configuracion' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Solicitud_Disponibles_ConfiguracionfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetData().length;
    Detalle_Solicitud_Disponibles_ConfiguracionfnClickAddRow();
    GetAddDetalle_Solicitud_Disponibles_ConfiguracionPopup(currentRowIndex, 0);
}

function Detalle_Solicitud_Disponibles_ConfiguracionEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Solicitud_Disponibles_ConfiguracionRowElement = "Detalle_Solicitud_Disponibles_Configuracion_" + rowIndex.toString();
    var prevData = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetData(rowIndexTable);
    GetAddDetalle_Solicitud_Disponibles_ConfiguracionPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_Solicitud_Disponibles_ConfiguracionDocumento').html($($.parseHTML(GetGridAutoComplete(prevData.Documento.label,'AutoCompleteDocumento'))).addClass('Detalle_Solicitud_Disponibles_Configuracion_Documento'));

    initiateUIControls();



}

function Detalle_Solicitud_Disponibles_ConfiguracionAddInsertRow() {
    if (Detalle_Solicitud_Disponibles_ConfiguracioninsertRowCurrentIndex < 1)
    {
        Detalle_Solicitud_Disponibles_ConfiguracioninsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Documento: ""

    }
}

function Detalle_Solicitud_Disponibles_ConfiguracionfnClickAddRow() {
    Detalle_Solicitud_Disponibles_ConfiguracioncountRowsChecked++;
    Detalle_Solicitud_Disponibles_ConfiguracionTable.fnAddData(Detalle_Solicitud_Disponibles_ConfiguracionAddInsertRow(), true);
    Detalle_Solicitud_Disponibles_ConfiguracionTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Solicitud_Disponibles_ConfiguracionGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Solicitud_Disponibles_ConfiguracionGrid tbody tr:nth-of-type(' + (Detalle_Solicitud_Disponibles_ConfiguracioninsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Solicitud_Disponibles_Configuracion("Detalle_Solicitud_Disponibles_Configuracion_", "_" + Detalle_Solicitud_Disponibles_ConfiguracioninsertRowCurrentIndex);
}

function Detalle_Solicitud_Disponibles_ConfiguracionClearGridData() {
    Detalle_Solicitud_Disponibles_ConfiguracionData = [];
    Detalle_Solicitud_Disponibles_ConfiguraciondeletedItem = [];
    Detalle_Solicitud_Disponibles_ConfiguracionDataMain = [];
    Detalle_Solicitud_Disponibles_ConfiguracionDataMainPages = [];
    Detalle_Solicitud_Disponibles_ConfiguracionnewItemCount = 0;
    Detalle_Solicitud_Disponibles_ConfiguracionmaxItemIndex = 0;
    $("#Detalle_Solicitud_Disponibles_ConfiguracionGrid").DataTable().clear();
    $("#Detalle_Solicitud_Disponibles_ConfiguracionGrid").DataTable().destroy();
}

//Used to Get Configuración de Servicios de Apoyo Information
function GetDetalle_Solicitud_Disponibles_Configuracion() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Solicitud_Disponibles_ConfiguracionData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Solicitud_Disponibles_ConfiguracionData[i].Clave);

        form_data.append('[' + i + '].Documento', Detalle_Solicitud_Disponibles_ConfiguracionData[i].Documento);

        form_data.append('[' + i + '].Removed', Detalle_Solicitud_Disponibles_ConfiguracionData[i].Removed);
    }
    return form_data;
}
function Detalle_Solicitud_Disponibles_ConfiguracionInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Solicitud_Disponibles_Configuracion("Detalle_Solicitud_Disponibles_ConfiguracionTable", rowIndex)) {
    var prevData = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetData(rowIndex);
    var data = Detalle_Solicitud_Disponibles_ConfiguracionTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Documento: $('#Detalle_Solicitud_Disponibles_ConfiguracionDocumento').val()

    }

    Detalle_Solicitud_Disponibles_ConfiguracionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Solicitud_Disponibles_ConfiguracionrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Solicitud_Disponibles_Configuracion-form').modal({ show: false });
    $('#AddDetalle_Solicitud_Disponibles_Configuracion-form').modal('hide');
    Detalle_Solicitud_Disponibles_ConfiguracionEditRow(rowIndex);
    Detalle_Solicitud_Disponibles_ConfiguracionInsertRow(rowIndex);
    //}
}
function Detalle_Solicitud_Disponibles_ConfiguracionRemoveAddRow(rowIndex) {
    Detalle_Solicitud_Disponibles_ConfiguracionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Solicitud_Disponibles_Configuracion MultiRow


$(function () {
    function Detalle_Solicitud_Disponibles_ConfiguracioninitializeMainArray(totalCount) {
        if (Detalle_Solicitud_Disponibles_ConfiguracionDataMain.length != totalCount && !Detalle_Solicitud_Disponibles_ConfiguracionDataMainInitialized) {
            Detalle_Solicitud_Disponibles_ConfiguracionDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Solicitud_Disponibles_ConfiguracionDataMain[i] = null;
            }
        }
    }
    function Detalle_Solicitud_Disponibles_ConfiguracionremoveFromMainArray() {
        for (var j = 0; j < Detalle_Solicitud_Disponibles_ConfiguraciondeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Solicitud_Disponibles_ConfiguracionDataMain.length; i++) {
                if (Detalle_Solicitud_Disponibles_ConfiguracionDataMain[i] != null && Detalle_Solicitud_Disponibles_ConfiguracionDataMain[i].Id == Detalle_Solicitud_Disponibles_ConfiguraciondeletedItem[j]) {
                    hDetalle_Solicitud_Disponibles_ConfiguracionDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Solicitud_Disponibles_ConfiguracioncopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Solicitud_Disponibles_ConfiguracionDataMain.length; i++) {
            data[i] = Detalle_Solicitud_Disponibles_ConfiguracionDataMain[i];

        }
        return data;
    }
    function Detalle_Solicitud_Disponibles_ConfiguraciongetNewResult() {
        var newData = copyMainDetalle_Solicitud_Disponibles_ConfiguracionArray();

        for (var i = 0; i < Detalle_Solicitud_Disponibles_ConfiguracionData.length; i++) {
            if (Detalle_Solicitud_Disponibles_ConfiguracionData[i].Removed == null || Detalle_Solicitud_Disponibles_ConfiguracionData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Solicitud_Disponibles_ConfiguracionData[i]);
            }
        }
        return newData;
    }
    function Detalle_Solicitud_Disponibles_ConfiguracionpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Solicitud_Disponibles_ConfiguracionDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Solicitud_Disponibles_ConfiguracionDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete
var AutoCompleteDocumentoData = [];
function GetAutoCompleteDetalle_Solicitud_Disponibles_Configuracion_Documento_DocumentoData(data) {
	AutoCompleteDocumentoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteDocumentoData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteDocumentoData;
}



function getDropdown(elementKey) {
    var labelSelect = $("#Configuracion_de_Servicios_de_Apoyo_cmbLabelSelect").val();
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
    $('#CreateConfiguracion_de_Servicios_de_Apoyo')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Detalle_Solicitud_Disponibles_ConfiguracionClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateConfiguracion_de_Servicios_de_Apoyo').trigger('reset');
    $('#CreateConfiguracion_de_Servicios_de_Apoyo').find(':input').each(function () {
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
    var $myForm = $('#CreateConfiguracion_de_Servicios_de_Apoyo');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Solicitud_Disponibles_ConfiguracioncountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Solicitud_Disponibles_Configuracion();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateConfiguracion_de_Servicios_de_Apoyo").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateConfiguracion_de_Servicios_de_Apoyo").on('click', '#Configuracion_de_Servicios_de_ApoyoCancelar', function () {
	  if (!isPartial) {
        Configuracion_de_Servicios_de_ApoyoBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateConfiguracion_de_Servicios_de_Apoyo").on('click', '#Configuracion_de_Servicios_de_ApoyoGuardar', function () {
		$('#Configuracion_de_Servicios_de_ApoyoGuardar').attr('disabled', true);
		$('#Configuracion_de_Servicios_de_ApoyoGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendConfiguracion_de_Servicios_de_ApoyoData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Configuracion_de_Servicios_de_ApoyoBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Configuracion_de_Servicios_de_ApoyoGuardar').removeAttr('disabled');
                        $('#Configuracion_de_Servicios_de_ApoyoGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Configuracion_de_Servicios_de_Apoyo', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Configuracion_de_Servicios_de_ApoyoItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Configuracion_de_Servicios_de_ApoyoDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Configuracion_de_Servicios_de_ApoyoGuardar').removeAttr('disabled');
					$('#Configuracion_de_Servicios_de_ApoyoGuardar').bind()
				}
		}
		else {
			$('#Configuracion_de_Servicios_de_ApoyoGuardar').removeAttr('disabled');
			$('#Configuracion_de_Servicios_de_ApoyoGuardar').bind()
		}
    });
	$("form#CreateConfiguracion_de_Servicios_de_Apoyo").on('click', '#Configuracion_de_Servicios_de_ApoyoGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendConfiguracion_de_Servicios_de_ApoyoData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Solicitud_Disponibles_ConfiguracionData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Configuracion_de_Servicios_de_Apoyo', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Configuracion_de_Servicios_de_ApoyoItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Configuracion_de_Servicios_de_ApoyoDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateConfiguracion_de_Servicios_de_Apoyo").on('click', '#Configuracion_de_Servicios_de_ApoyoGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendConfiguracion_de_Servicios_de_ApoyoData(function (currentId) {
					$("#ClaveId").val("0");
	                Detalle_Solicitud_Disponibles_ConfiguracionClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Solicitud_Disponibles_ConfiguracionData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Configuracion_de_Servicios_de_Apoyo',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Configuracion_de_Servicios_de_ApoyoItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Configuracion_de_Servicios_de_ApoyoDropDown().get(0)').innerHTML);                          
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



var Configuracion_de_Servicios_de_ApoyoisdisplayBusinessPropery = false;
Configuracion_de_Servicios_de_ApoyoDisplayBusinessRuleButtons(Configuracion_de_Servicios_de_ApoyoisdisplayBusinessPropery);
function Configuracion_de_Servicios_de_ApoyoDisplayBusinessRule() {
    if (!Configuracion_de_Servicios_de_ApoyoisdisplayBusinessPropery) {
        $('#CreateConfiguracion_de_Servicios_de_Apoyo').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Configuracion_de_Servicios_de_ApoyodisplayBusinessPropery"><button onclick="Configuracion_de_Servicios_de_ApoyoGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Configuracion_de_Servicios_de_ApoyoBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Configuracion_de_Servicios_de_ApoyodisplayBusinessPropery').remove();
    }
    Configuracion_de_Servicios_de_ApoyoDisplayBusinessRuleButtons(!Configuracion_de_Servicios_de_ApoyoisdisplayBusinessPropery);
    Configuracion_de_Servicios_de_ApoyoisdisplayBusinessPropery = (Configuracion_de_Servicios_de_ApoyoisdisplayBusinessPropery ? false : true);
}
function Configuracion_de_Servicios_de_ApoyoDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

