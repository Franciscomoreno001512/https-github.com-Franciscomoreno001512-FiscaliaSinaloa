

//Begin Declarations for Foreigns fields for Detalle_de_Descarga_de_Archivo MultiRow
var Detalle_de_Descarga_de_ArchivocountRowsChecked = 0;




function GetInsertDetalle_de_Descarga_de_ArchivoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Descarga_de_Archivo_Documento Documento').attr('id', 'Detalle_de_Descarga_de_Archivo_Documento_' + index).attr('data-field', 'Documento');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Descarga_de_ArchivoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Descarga_de_Archivo("Detalle_de_Descarga_de_Archivo_", "_" + rowIndex)) {
    var iPage = Detalle_de_Descarga_de_ArchivoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Descarga_de_Archivo';
    var prevData = Detalle_de_Descarga_de_ArchivoTable.fnGetData(rowIndex);
    var data = Detalle_de_Descarga_de_ArchivoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Documento: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Descarga_de_ArchivoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Descarga_de_ArchivorowCreationGrid(data, newData, rowIndex);
    Detalle_de_Descarga_de_ArchivoTable.fnPageChange(iPage);
    Detalle_de_Descarga_de_ArchivocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Descarga_de_Archivo("Detalle_de_Descarga_de_Archivo_", "_" + rowIndex);
  }
}

function Detalle_de_Descarga_de_ArchivoCancelRow(rowIndex) {
    var prevData = Detalle_de_Descarga_de_ArchivoTable.fnGetData(rowIndex);
    var data = Detalle_de_Descarga_de_ArchivoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Descarga_de_ArchivoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Descarga_de_ArchivorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Descarga_de_ArchivoGrid(Detalle_de_Descarga_de_ArchivoTable.fnGetData());
    Detalle_de_Descarga_de_ArchivocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Descarga_de_ArchivoFromDataTable() {
    var Detalle_de_Descarga_de_ArchivoData = [];
    var gridData = Detalle_de_Descarga_de_ArchivoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Descarga_de_ArchivoData.push({
                Clave: gridData[i].Clave

                ,Documento: gridData[i].Documento

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Descarga_de_ArchivoData.length; i++) {
        if (removedDetalle_de_Descarga_de_ArchivoData[i] != null && removedDetalle_de_Descarga_de_ArchivoData[i].Clave > 0)
            Detalle_de_Descarga_de_ArchivoData.push({
                Clave: removedDetalle_de_Descarga_de_ArchivoData[i].Clave

                ,Documento: removedDetalle_de_Descarga_de_ArchivoData[i].Documento

                , Removed: true
            });
    }	

    return Detalle_de_Descarga_de_ArchivoData;
}

function Detalle_de_Descarga_de_ArchivoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Descarga_de_ArchivoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Descarga_de_ArchivocountRowsChecked++;
    var Detalle_de_Descarga_de_ArchivoRowElement = "Detalle_de_Descarga_de_Archivo_" + rowIndex.toString();
    var prevData = Detalle_de_Descarga_de_ArchivoTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Descarga_de_ArchivoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Descarga_de_Archivo_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Descarga_de_ArchivoGetUpdateRowControls(prevData, "Detalle_de_Descarga_de_Archivo_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Descarga_de_ArchivoRowElement + "')){ Detalle_de_Descarga_de_ArchivoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Descarga_de_ArchivoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Descarga_de_ArchivoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Descarga_de_ArchivoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Descarga_de_ArchivoValidation();
    initiateUIControls();
    $('.Detalle_de_Descarga_de_Archivo' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Descarga_de_Archivo(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Descarga_de_ArchivofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Descarga_de_ArchivoTable.fnGetData().length;
    Detalle_de_Descarga_de_ArchivofnClickAddRow();
    GetAddDetalle_de_Descarga_de_ArchivoPopup(currentRowIndex, 0);
}

function Detalle_de_Descarga_de_ArchivoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Descarga_de_ArchivoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Descarga_de_ArchivoRowElement = "Detalle_de_Descarga_de_Archivo_" + rowIndex.toString();
    var prevData = Detalle_de_Descarga_de_ArchivoTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Descarga_de_ArchivoPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Descarga_de_ArchivoDocumento').val(prevData.Documento);

    initiateUIControls();



}

function Detalle_de_Descarga_de_ArchivoAddInsertRow() {
    if (Detalle_de_Descarga_de_ArchivoinsertRowCurrentIndex < 1)
    {
        Detalle_de_Descarga_de_ArchivoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Documento: ""

    }
}

function Detalle_de_Descarga_de_ArchivofnClickAddRow() {
    Detalle_de_Descarga_de_ArchivocountRowsChecked++;
    Detalle_de_Descarga_de_ArchivoTable.fnAddData(Detalle_de_Descarga_de_ArchivoAddInsertRow(), true);
    Detalle_de_Descarga_de_ArchivoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Descarga_de_ArchivoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Descarga_de_ArchivoGrid tbody tr:nth-of-type(' + (Detalle_de_Descarga_de_ArchivoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Descarga_de_Archivo("Detalle_de_Descarga_de_Archivo_", "_" + Detalle_de_Descarga_de_ArchivoinsertRowCurrentIndex);
}

function Detalle_de_Descarga_de_ArchivoClearGridData() {
    Detalle_de_Descarga_de_ArchivoData = [];
    Detalle_de_Descarga_de_ArchivodeletedItem = [];
    Detalle_de_Descarga_de_ArchivoDataMain = [];
    Detalle_de_Descarga_de_ArchivoDataMainPages = [];
    Detalle_de_Descarga_de_ArchivonewItemCount = 0;
    Detalle_de_Descarga_de_ArchivomaxItemIndex = 0;
    $("#Detalle_de_Descarga_de_ArchivoGrid").DataTable().clear();
    $("#Detalle_de_Descarga_de_ArchivoGrid").DataTable().destroy();
}

//Used to Get Descarga de Archivo Information
function GetDetalle_de_Descarga_de_Archivo() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Descarga_de_ArchivoData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Descarga_de_ArchivoData[i].Clave);

        form_data.append('[' + i + '].Documento', Detalle_de_Descarga_de_ArchivoData[i].Documento);

        form_data.append('[' + i + '].Removed', Detalle_de_Descarga_de_ArchivoData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Descarga_de_ArchivoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Descarga_de_Archivo("Detalle_de_Descarga_de_ArchivoTable", rowIndex)) {
    var prevData = Detalle_de_Descarga_de_ArchivoTable.fnGetData(rowIndex);
    var data = Detalle_de_Descarga_de_ArchivoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Documento: $('#Detalle_de_Descarga_de_ArchivoDocumento').val()


    }

    Detalle_de_Descarga_de_ArchivoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Descarga_de_ArchivorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Descarga_de_Archivo-form').modal({ show: false });
    $('#AddDetalle_de_Descarga_de_Archivo-form').modal('hide');
    Detalle_de_Descarga_de_ArchivoEditRow(rowIndex);
    Detalle_de_Descarga_de_ArchivoInsertRow(rowIndex);
    //}
}
function Detalle_de_Descarga_de_ArchivoRemoveAddRow(rowIndex) {
    Detalle_de_Descarga_de_ArchivoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Descarga_de_Archivo MultiRow


$(function () {
    function Detalle_de_Descarga_de_ArchivoinitializeMainArray(totalCount) {
        if (Detalle_de_Descarga_de_ArchivoDataMain.length != totalCount && !Detalle_de_Descarga_de_ArchivoDataMainInitialized) {
            Detalle_de_Descarga_de_ArchivoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Descarga_de_ArchivoDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Descarga_de_ArchivoremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Descarga_de_ArchivodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Descarga_de_ArchivoDataMain.length; i++) {
                if (Detalle_de_Descarga_de_ArchivoDataMain[i] != null && Detalle_de_Descarga_de_ArchivoDataMain[i].Id == Detalle_de_Descarga_de_ArchivodeletedItem[j]) {
                    hDetalle_de_Descarga_de_ArchivoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Descarga_de_ArchivocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Descarga_de_ArchivoDataMain.length; i++) {
            data[i] = Detalle_de_Descarga_de_ArchivoDataMain[i];

        }
        return data;
    }
    function Detalle_de_Descarga_de_ArchivogetNewResult() {
        var newData = copyMainDetalle_de_Descarga_de_ArchivoArray();

        for (var i = 0; i < Detalle_de_Descarga_de_ArchivoData.length; i++) {
            if (Detalle_de_Descarga_de_ArchivoData[i].Removed == null || Detalle_de_Descarga_de_ArchivoData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Descarga_de_ArchivoData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Descarga_de_ArchivopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Descarga_de_ArchivoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Descarga_de_ArchivoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Descarga_de_Archivo_cmbLabelSelect").val();
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
    $('#CreateDescarga_de_Archivo')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Detalle_de_Descarga_de_ArchivoClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDescarga_de_Archivo').trigger('reset');
    $('#CreateDescarga_de_Archivo').find(':input').each(function () {
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
    var $myForm = $('#CreateDescarga_de_Archivo');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Descarga_de_ArchivocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Descarga_de_Archivo();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDescarga_de_Archivo").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDescarga_de_Archivo").on('click', '#Descarga_de_ArchivoCancelar', function () {
	  if (!isPartial) {
        Descarga_de_ArchivoBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDescarga_de_Archivo").on('click', '#Descarga_de_ArchivoGuardar', function () {
		$('#Descarga_de_ArchivoGuardar').attr('disabled', true);
		$('#Descarga_de_ArchivoGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDescarga_de_ArchivoData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Descarga_de_ArchivoBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Descarga_de_ArchivoGuardar').removeAttr('disabled');
                        $('#Descarga_de_ArchivoGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Descarga_de_Archivo', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Descarga_de_ArchivoItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Descarga_de_ArchivoDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Descarga_de_ArchivoGuardar').removeAttr('disabled');
					$('#Descarga_de_ArchivoGuardar').bind()
				}
		}
		else {
			$('#Descarga_de_ArchivoGuardar').removeAttr('disabled');
			$('#Descarga_de_ArchivoGuardar').bind()
		}
    });
	$("form#CreateDescarga_de_Archivo").on('click', '#Descarga_de_ArchivoGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDescarga_de_ArchivoData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Descarga_de_ArchivoData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Descarga_de_Archivo', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Descarga_de_ArchivoItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Descarga_de_ArchivoDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDescarga_de_Archivo").on('click', '#Descarga_de_ArchivoGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDescarga_de_ArchivoData(function (currentId) {
					$("#ClaveId").val("0");
	                Detalle_de_Descarga_de_ArchivoClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_Descarga_de_ArchivoData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Descarga_de_Archivo',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Descarga_de_ArchivoItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Descarga_de_ArchivoDropDown().get(0)').innerHTML);                          
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



var Descarga_de_ArchivoisdisplayBusinessPropery = false;
Descarga_de_ArchivoDisplayBusinessRuleButtons(Descarga_de_ArchivoisdisplayBusinessPropery);
function Descarga_de_ArchivoDisplayBusinessRule() {
    if (!Descarga_de_ArchivoisdisplayBusinessPropery) {
        $('#CreateDescarga_de_Archivo').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Descarga_de_ArchivodisplayBusinessPropery"><button onclick="Descarga_de_ArchivoGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Descarga_de_ArchivoBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Descarga_de_ArchivodisplayBusinessPropery').remove();
    }
    Descarga_de_ArchivoDisplayBusinessRuleButtons(!Descarga_de_ArchivoisdisplayBusinessPropery);
    Descarga_de_ArchivoisdisplayBusinessPropery = (Descarga_de_ArchivoisdisplayBusinessPropery ? false : true);
}
function Descarga_de_ArchivoDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

