

//Begin Declarations for Foreigns fields for Detalle_de_Mensaje_de_Historial MultiRow
var Detalle_de_Mensaje_de_HistorialcountRowsChecked = 0;





function GetInsertDetalle_de_Mensaje_de_HistorialRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Mensaje_de_Historial_Hora Hora').attr('id', 'Detalle_de_Mensaje_de_Historial_Hora_' + index).attr('data-field', 'Hora');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Mensaje_de_Historial_Mensaje Mensaje').attr('id', 'Detalle_de_Mensaje_de_Historial_Mensaje_' + index).attr('data-field', 'Mensaje');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Mensaje_de_HistorialInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Mensaje_de_Historial("Detalle_de_Mensaje_de_Historial_", "_" + rowIndex)) {
    var iPage = Detalle_de_Mensaje_de_HistorialTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Mensaje_de_Historial';
    var prevData = Detalle_de_Mensaje_de_HistorialTable.fnGetData(rowIndex);
    var data = Detalle_de_Mensaje_de_HistorialTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Hora:  data.childNodes[counter++].childNodes[0].value
        ,Mensaje:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Mensaje_de_HistorialTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Mensaje_de_HistorialrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Mensaje_de_HistorialTable.fnPageChange(iPage);
    Detalle_de_Mensaje_de_HistorialcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Mensaje_de_Historial("Detalle_de_Mensaje_de_Historial_", "_" + rowIndex);
  }
}

function Detalle_de_Mensaje_de_HistorialCancelRow(rowIndex) {
    var prevData = Detalle_de_Mensaje_de_HistorialTable.fnGetData(rowIndex);
    var data = Detalle_de_Mensaje_de_HistorialTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Mensaje_de_HistorialTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Mensaje_de_HistorialrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Mensaje_de_HistorialGrid(Detalle_de_Mensaje_de_HistorialTable.fnGetData());
    Detalle_de_Mensaje_de_HistorialcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Mensaje_de_HistorialFromDataTable() {
    var Detalle_de_Mensaje_de_HistorialData = [];
    var gridData = Detalle_de_Mensaje_de_HistorialTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Mensaje_de_HistorialData.push({
                Clave: gridData[i].Clave

                ,Hora: gridData[i].Hora
                ,Mensaje: gridData[i].Mensaje

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Mensaje_de_HistorialData.length; i++) {
        if (removedDetalle_de_Mensaje_de_HistorialData[i] != null && removedDetalle_de_Mensaje_de_HistorialData[i].Clave > 0)
            Detalle_de_Mensaje_de_HistorialData.push({
                Clave: removedDetalle_de_Mensaje_de_HistorialData[i].Clave

                ,Hora: removedDetalle_de_Mensaje_de_HistorialData[i].Hora
                ,Mensaje: removedDetalle_de_Mensaje_de_HistorialData[i].Mensaje

                , Removed: true
            });
    }	

    return Detalle_de_Mensaje_de_HistorialData;
}

function Detalle_de_Mensaje_de_HistorialEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Mensaje_de_HistorialTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Mensaje_de_HistorialcountRowsChecked++;
    var Detalle_de_Mensaje_de_HistorialRowElement = "Detalle_de_Mensaje_de_Historial_" + rowIndex.toString();
    var prevData = Detalle_de_Mensaje_de_HistorialTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Mensaje_de_HistorialTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Mensaje_de_Historial_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Mensaje_de_HistorialGetUpdateRowControls(prevData, "Detalle_de_Mensaje_de_Historial_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Mensaje_de_HistorialRowElement + "')){ Detalle_de_Mensaje_de_HistorialInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Mensaje_de_HistorialCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Mensaje_de_HistorialGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Mensaje_de_HistorialGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Mensaje_de_HistorialValidation();
    initiateUIControls();
    $('.Detalle_de_Mensaje_de_Historial' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Mensaje_de_Historial(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Mensaje_de_HistorialfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Mensaje_de_HistorialTable.fnGetData().length;
    Detalle_de_Mensaje_de_HistorialfnClickAddRow();
    GetAddDetalle_de_Mensaje_de_HistorialPopup(currentRowIndex, 0);
}

function Detalle_de_Mensaje_de_HistorialEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Mensaje_de_HistorialTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Mensaje_de_HistorialRowElement = "Detalle_de_Mensaje_de_Historial_" + rowIndex.toString();
    var prevData = Detalle_de_Mensaje_de_HistorialTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Mensaje_de_HistorialPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Mensaje_de_HistorialHora').val(prevData.Hora);
    $('#Detalle_de_Mensaje_de_HistorialMensaje').val(prevData.Mensaje);

    initiateUIControls();




}

function Detalle_de_Mensaje_de_HistorialAddInsertRow() {
    if (Detalle_de_Mensaje_de_HistorialinsertRowCurrentIndex < 1)
    {
        Detalle_de_Mensaje_de_HistorialinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Hora: ""
        ,Mensaje: ""

    }
}

function Detalle_de_Mensaje_de_HistorialfnClickAddRow() {
    Detalle_de_Mensaje_de_HistorialcountRowsChecked++;
    Detalle_de_Mensaje_de_HistorialTable.fnAddData(Detalle_de_Mensaje_de_HistorialAddInsertRow(), true);
    Detalle_de_Mensaje_de_HistorialTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Mensaje_de_HistorialGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Mensaje_de_HistorialGrid tbody tr:nth-of-type(' + (Detalle_de_Mensaje_de_HistorialinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Mensaje_de_Historial("Detalle_de_Mensaje_de_Historial_", "_" + Detalle_de_Mensaje_de_HistorialinsertRowCurrentIndex);
}

function Detalle_de_Mensaje_de_HistorialClearGridData() {
    Detalle_de_Mensaje_de_HistorialData = [];
    Detalle_de_Mensaje_de_HistorialdeletedItem = [];
    Detalle_de_Mensaje_de_HistorialDataMain = [];
    Detalle_de_Mensaje_de_HistorialDataMainPages = [];
    Detalle_de_Mensaje_de_HistorialnewItemCount = 0;
    Detalle_de_Mensaje_de_HistorialmaxItemIndex = 0;
    $("#Detalle_de_Mensaje_de_HistorialGrid").DataTable().clear();
    $("#Detalle_de_Mensaje_de_HistorialGrid").DataTable().destroy();
}

//Used to Get Historial de Conversación Information
function GetDetalle_de_Mensaje_de_Historial() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Mensaje_de_HistorialData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Mensaje_de_HistorialData[i].Clave);

        form_data.append('[' + i + '].Hora', Detalle_de_Mensaje_de_HistorialData[i].Hora);
        form_data.append('[' + i + '].Mensaje', Detalle_de_Mensaje_de_HistorialData[i].Mensaje);

        form_data.append('[' + i + '].Removed', Detalle_de_Mensaje_de_HistorialData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Mensaje_de_HistorialInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Mensaje_de_Historial("Detalle_de_Mensaje_de_HistorialTable", rowIndex)) {
    var prevData = Detalle_de_Mensaje_de_HistorialTable.fnGetData(rowIndex);
    var data = Detalle_de_Mensaje_de_HistorialTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Hora: $('#Detalle_de_Mensaje_de_HistorialHora').val()
        ,Mensaje: $('#Detalle_de_Mensaje_de_HistorialMensaje').val()

    }

    Detalle_de_Mensaje_de_HistorialTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Mensaje_de_HistorialrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Mensaje_de_Historial-form').modal({ show: false });
    $('#AddDetalle_de_Mensaje_de_Historial-form').modal('hide');
    Detalle_de_Mensaje_de_HistorialEditRow(rowIndex);
    Detalle_de_Mensaje_de_HistorialInsertRow(rowIndex);
    //}
}
function Detalle_de_Mensaje_de_HistorialRemoveAddRow(rowIndex) {
    Detalle_de_Mensaje_de_HistorialTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Mensaje_de_Historial MultiRow


$(function () {
    function Detalle_de_Mensaje_de_HistorialinitializeMainArray(totalCount) {
        if (Detalle_de_Mensaje_de_HistorialDataMain.length != totalCount && !Detalle_de_Mensaje_de_HistorialDataMainInitialized) {
            Detalle_de_Mensaje_de_HistorialDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Mensaje_de_HistorialDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Mensaje_de_HistorialremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Mensaje_de_HistorialdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Mensaje_de_HistorialDataMain.length; i++) {
                if (Detalle_de_Mensaje_de_HistorialDataMain[i] != null && Detalle_de_Mensaje_de_HistorialDataMain[i].Id == Detalle_de_Mensaje_de_HistorialdeletedItem[j]) {
                    hDetalle_de_Mensaje_de_HistorialDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Mensaje_de_HistorialcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Mensaje_de_HistorialDataMain.length; i++) {
            data[i] = Detalle_de_Mensaje_de_HistorialDataMain[i];

        }
        return data;
    }
    function Detalle_de_Mensaje_de_HistorialgetNewResult() {
        var newData = copyMainDetalle_de_Mensaje_de_HistorialArray();

        for (var i = 0; i < Detalle_de_Mensaje_de_HistorialData.length; i++) {
            if (Detalle_de_Mensaje_de_HistorialData[i].Removed == null || Detalle_de_Mensaje_de_HistorialData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Mensaje_de_HistorialData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Mensaje_de_HistorialpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Mensaje_de_HistorialDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Mensaje_de_HistorialDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Historial_de_Conversacion_cmbLabelSelect").val();
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
    $("#ReferenceFolio").val("0");
    $('#CreateHistorial_de_Conversacion')[0].reset();
    ClearFormControls();
    $("#FolioId").val("0");
                Detalle_de_Mensaje_de_HistorialClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateHistorial_de_Conversacion').trigger('reset');
    $('#CreateHistorial_de_Conversacion').find(':input').each(function () {
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
    var $myForm = $('#CreateHistorial_de_Conversacion');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Mensaje_de_HistorialcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Mensaje_de_Historial();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblFolio").text("0");
}
$(document).ready(function () {
    $("form#CreateHistorial_de_Conversacion").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateHistorial_de_Conversacion").on('click', '#Historial_de_ConversacionCancelar', function () {
	  if (!isPartial) {
        Historial_de_ConversacionBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateHistorial_de_Conversacion").on('click', '#Historial_de_ConversacionGuardar', function () {
		$('#Historial_de_ConversacionGuardar').attr('disabled', true);
		$('#Historial_de_ConversacionGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendHistorial_de_ConversacionData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Historial_de_ConversacionBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Historial_de_ConversacionGuardar').removeAttr('disabled');
                        $('#Historial_de_ConversacionGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Historial_de_Conversacion', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Historial_de_ConversacionItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Historial_de_ConversacionDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Historial_de_ConversacionGuardar').removeAttr('disabled');
					$('#Historial_de_ConversacionGuardar').bind()
				}
		}
		else {
			$('#Historial_de_ConversacionGuardar').removeAttr('disabled');
			$('#Historial_de_ConversacionGuardar').bind()
		}
    });
	$("form#CreateHistorial_de_Conversacion").on('click', '#Historial_de_ConversacionGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendHistorial_de_ConversacionData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Mensaje_de_HistorialData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Historial_de_Conversacion', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Historial_de_ConversacionItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Historial_de_ConversacionDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateHistorial_de_Conversacion").on('click', '#Historial_de_ConversacionGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendHistorial_de_ConversacionData(function (currentId) {
					$("#FolioId").val("0");
	                Detalle_de_Mensaje_de_HistorialClearGridData();

					ResetClaveLabel();
					$("#ReferenceFolio").val(currentId);
	                getDetalle_de_Mensaje_de_HistorialData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Historial_de_Conversacion',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Historial_de_ConversacionItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Historial_de_ConversacionDropDown().get(0)').innerHTML);                          
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



var Historial_de_ConversacionisdisplayBusinessPropery = false;
Historial_de_ConversacionDisplayBusinessRuleButtons(Historial_de_ConversacionisdisplayBusinessPropery);
function Historial_de_ConversacionDisplayBusinessRule() {
    if (!Historial_de_ConversacionisdisplayBusinessPropery) {
        $('#CreateHistorial_de_Conversacion').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Historial_de_ConversaciondisplayBusinessPropery"><button onclick="Historial_de_ConversacionGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Historial_de_ConversacionBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Historial_de_ConversaciondisplayBusinessPropery').remove();
    }
    Historial_de_ConversacionDisplayBusinessRuleButtons(!Historial_de_ConversacionisdisplayBusinessPropery);
    Historial_de_ConversacionisdisplayBusinessPropery = (Historial_de_ConversacionisdisplayBusinessPropery ? false : true);
}
function Historial_de_ConversacionDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

