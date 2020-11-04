

//Begin Declarations for Foreigns fields for Detalle_de_Coincidencias MultiRow
var Detalle_de_CoincidenciascountRowsChecked = 0;



function GetInsertDetalle_de_CoincidenciasRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";



    initiateUIControls();
    return columnData;
}

function Detalle_de_CoincidenciasInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Coincidencias("Detalle_de_Coincidencias_", "_" + rowIndex)) {
    var iPage = Detalle_de_CoincidenciasTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Coincidencias';
    var prevData = Detalle_de_CoincidenciasTable.fnGetData(rowIndex);
    var data = Detalle_de_CoincidenciasTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false


    }
    Detalle_de_CoincidenciasTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_CoincidenciasrowCreationGrid(data, newData, rowIndex);
    Detalle_de_CoincidenciasTable.fnPageChange(iPage);
    Detalle_de_CoincidenciascountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Coincidencias("Detalle_de_Coincidencias_", "_" + rowIndex);
  }
}

function Detalle_de_CoincidenciasCancelRow(rowIndex) {
    var prevData = Detalle_de_CoincidenciasTable.fnGetData(rowIndex);
    var data = Detalle_de_CoincidenciasTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_CoincidenciasTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_CoincidenciasrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_CoincidenciasGrid(Detalle_de_CoincidenciasTable.fnGetData());
    Detalle_de_CoincidenciascountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_CoincidenciasFromDataTable() {
    var Detalle_de_CoincidenciasData = [];
    var gridData = Detalle_de_CoincidenciasTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_CoincidenciasData.push({
                Clave: gridData[i].Clave


                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_CoincidenciasData.length; i++) {
        if (removedDetalle_de_CoincidenciasData[i] != null && removedDetalle_de_CoincidenciasData[i].Clave > 0)
            Detalle_de_CoincidenciasData.push({
                Clave: removedDetalle_de_CoincidenciasData[i].Clave


                , Removed: true
            });
    }	

    return Detalle_de_CoincidenciasData;
}

function Detalle_de_CoincidenciasEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_CoincidenciasTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_CoincidenciascountRowsChecked++;
    var Detalle_de_CoincidenciasRowElement = "Detalle_de_Coincidencias_" + rowIndex.toString();
    var prevData = Detalle_de_CoincidenciasTable.fnGetData(rowIndexTable );
    var row = Detalle_de_CoincidenciasTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Coincidencias_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_CoincidenciasGetUpdateRowControls(prevData, "Detalle_de_Coincidencias_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_CoincidenciasRowElement + "')){ Detalle_de_CoincidenciasInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_CoincidenciasCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_CoincidenciasGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_CoincidenciasGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_CoincidenciasValidation();
    initiateUIControls();
    $('.Detalle_de_Coincidencias' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Coincidencias(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_CoincidenciasfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_CoincidenciasTable.fnGetData().length;
    Detalle_de_CoincidenciasfnClickAddRow();
    GetAddDetalle_de_CoincidenciasPopup(currentRowIndex, 0);
}

function Detalle_de_CoincidenciasEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_CoincidenciasTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_CoincidenciasRowElement = "Detalle_de_Coincidencias_" + rowIndex.toString();
    var prevData = Detalle_de_CoincidenciasTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_CoincidenciasPopup(rowIndex, 1, prevData.Clave);


    initiateUIControls();


}

function Detalle_de_CoincidenciasAddInsertRow() {
    if (Detalle_de_CoincidenciasinsertRowCurrentIndex < 1)
    {
        Detalle_de_CoincidenciasinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true


    }
}

function Detalle_de_CoincidenciasfnClickAddRow() {
    Detalle_de_CoincidenciascountRowsChecked++;
    Detalle_de_CoincidenciasTable.fnAddData(Detalle_de_CoincidenciasAddInsertRow(), true);
    Detalle_de_CoincidenciasTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_CoincidenciasGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_CoincidenciasGrid tbody tr:nth-of-type(' + (Detalle_de_CoincidenciasinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Coincidencias("Detalle_de_Coincidencias_", "_" + Detalle_de_CoincidenciasinsertRowCurrentIndex);
}

function Detalle_de_CoincidenciasClearGridData() {
    Detalle_de_CoincidenciasData = [];
    Detalle_de_CoincidenciasdeletedItem = [];
    Detalle_de_CoincidenciasDataMain = [];
    Detalle_de_CoincidenciasDataMainPages = [];
    Detalle_de_CoincidenciasnewItemCount = 0;
    Detalle_de_CoincidenciasmaxItemIndex = 0;
    $("#Detalle_de_CoincidenciasGrid").DataTable().clear();
    $("#Detalle_de_CoincidenciasGrid").DataTable().destroy();
}

//Used to Get Registro de Coincidencias Information
function GetDetalle_de_Coincidencias() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_CoincidenciasData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_CoincidenciasData[i].Clave);


        form_data.append('[' + i + '].Removed', Detalle_de_CoincidenciasData[i].Removed);
    }
    return form_data;
}
function Detalle_de_CoincidenciasInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Coincidencias("Detalle_de_CoincidenciasTable", rowIndex)) {
    var prevData = Detalle_de_CoincidenciasTable.fnGetData(rowIndex);
    var data = Detalle_de_CoincidenciasTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false


    }

    Detalle_de_CoincidenciasTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_CoincidenciasrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Coincidencias-form').modal({ show: false });
    $('#AddDetalle_de_Coincidencias-form').modal('hide');
    Detalle_de_CoincidenciasEditRow(rowIndex);
    Detalle_de_CoincidenciasInsertRow(rowIndex);
    //}
}
function Detalle_de_CoincidenciasRemoveAddRow(rowIndex) {
    Detalle_de_CoincidenciasTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Coincidencias MultiRow


$(function () {
    function Detalle_de_CoincidenciasinitializeMainArray(totalCount) {
        if (Detalle_de_CoincidenciasDataMain.length != totalCount && !Detalle_de_CoincidenciasDataMainInitialized) {
            Detalle_de_CoincidenciasDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_CoincidenciasDataMain[i] = null;
            }
        }
    }
    function Detalle_de_CoincidenciasremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_CoincidenciasdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_CoincidenciasDataMain.length; i++) {
                if (Detalle_de_CoincidenciasDataMain[i] != null && Detalle_de_CoincidenciasDataMain[i].Id == Detalle_de_CoincidenciasdeletedItem[j]) {
                    hDetalle_de_CoincidenciasDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_CoincidenciascopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_CoincidenciasDataMain.length; i++) {
            data[i] = Detalle_de_CoincidenciasDataMain[i];

        }
        return data;
    }
    function Detalle_de_CoincidenciasgetNewResult() {
        var newData = copyMainDetalle_de_CoincidenciasArray();

        for (var i = 0; i < Detalle_de_CoincidenciasData.length; i++) {
            if (Detalle_de_CoincidenciasData[i].Removed == null || Detalle_de_CoincidenciasData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_CoincidenciasData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_CoincidenciaspushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_CoincidenciasDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_CoincidenciasDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Registro_de_Coincidencias_cmbLabelSelect").val();
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
    $('#CreateRegistro_de_Coincidencias')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Detalle_de_CoincidenciasClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateRegistro_de_Coincidencias').trigger('reset');
    $('#CreateRegistro_de_Coincidencias').find(':input').each(function () {
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
    var $myForm = $('#CreateRegistro_de_Coincidencias');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_CoincidenciascountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Coincidencias();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateRegistro_de_Coincidencias").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateRegistro_de_Coincidencias").on('click', '#Registro_de_CoincidenciasCancelar', function () {
	  if (!isPartial) {
        Registro_de_CoincidenciasBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateRegistro_de_Coincidencias").on('click', '#Registro_de_CoincidenciasGuardar', function () {
		$('#Registro_de_CoincidenciasGuardar').attr('disabled', true);
		$('#Registro_de_CoincidenciasGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendRegistro_de_CoincidenciasData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Registro_de_CoincidenciasBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Registro_de_CoincidenciasGuardar').removeAttr('disabled');
                        $('#Registro_de_CoincidenciasGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Registro_de_Coincidencias', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Registro_de_CoincidenciasItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Registro_de_CoincidenciasDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Registro_de_CoincidenciasGuardar').removeAttr('disabled');
					$('#Registro_de_CoincidenciasGuardar').bind()
				}
		}
		else {
			$('#Registro_de_CoincidenciasGuardar').removeAttr('disabled');
			$('#Registro_de_CoincidenciasGuardar').bind()
		}
    });
	$("form#CreateRegistro_de_Coincidencias").on('click', '#Registro_de_CoincidenciasGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendRegistro_de_CoincidenciasData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_CoincidenciasData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Registro_de_Coincidencias', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Registro_de_CoincidenciasItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Registro_de_CoincidenciasDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateRegistro_de_Coincidencias").on('click', '#Registro_de_CoincidenciasGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendRegistro_de_CoincidenciasData(function (currentId) {
					$("#ClaveId").val("0");
	                Detalle_de_CoincidenciasClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_CoincidenciasData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Registro_de_Coincidencias',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Registro_de_CoincidenciasItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Registro_de_CoincidenciasDropDown().get(0)').innerHTML);                          
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



var Registro_de_CoincidenciasisdisplayBusinessPropery = false;
Registro_de_CoincidenciasDisplayBusinessRuleButtons(Registro_de_CoincidenciasisdisplayBusinessPropery);
function Registro_de_CoincidenciasDisplayBusinessRule() {
    if (!Registro_de_CoincidenciasisdisplayBusinessPropery) {
        $('#CreateRegistro_de_Coincidencias').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Registro_de_CoincidenciasdisplayBusinessPropery"><button onclick="Registro_de_CoincidenciasGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Registro_de_CoincidenciasBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Registro_de_CoincidenciasdisplayBusinessPropery').remove();
    }
    Registro_de_CoincidenciasDisplayBusinessRuleButtons(!Registro_de_CoincidenciasisdisplayBusinessPropery);
    Registro_de_CoincidenciasisdisplayBusinessPropery = (Registro_de_CoincidenciasisdisplayBusinessPropery ? false : true);
}
function Registro_de_CoincidenciasDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

