

//Begin Declarations for Foreigns fields for Detalle_Vinculacion_Judicializacion MultiRow
var Detalle_Vinculacion_JudicializacioncountRowsChecked = 0;




function GetInsertDetalle_Vinculacion_JudicializacionRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_Vinculacion_Judicializacion_Relacion Relacion').attr('id', 'Detalle_Vinculacion_Judicializacion_Relacion_' + index).attr('data-field', 'Relacion');


    initiateUIControls();
    return columnData;
}

function Detalle_Vinculacion_JudicializacionInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Vinculacion_Judicializacion("Detalle_Vinculacion_Judicializacion_", "_" + rowIndex)) {
    var iPage = Detalle_Vinculacion_JudicializacionTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Vinculacion_Judicializacion';
    var prevData = Detalle_Vinculacion_JudicializacionTable.fnGetData(rowIndex);
    var data = Detalle_Vinculacion_JudicializacionTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Relacion:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Vinculacion_JudicializacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Vinculacion_JudicializacionrowCreationGrid(data, newData, rowIndex);
    Detalle_Vinculacion_JudicializacionTable.fnPageChange(iPage);
    Detalle_Vinculacion_JudicializacioncountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Vinculacion_Judicializacion("Detalle_Vinculacion_Judicializacion_", "_" + rowIndex);
  }
}

function Detalle_Vinculacion_JudicializacionCancelRow(rowIndex) {
    var prevData = Detalle_Vinculacion_JudicializacionTable.fnGetData(rowIndex);
    var data = Detalle_Vinculacion_JudicializacionTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Vinculacion_JudicializacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Vinculacion_JudicializacionrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Vinculacion_JudicializacionGrid(Detalle_Vinculacion_JudicializacionTable.fnGetData());
    Detalle_Vinculacion_JudicializacioncountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Vinculacion_JudicializacionFromDataTable() {
    var Detalle_Vinculacion_JudicializacionData = [];
    var gridData = Detalle_Vinculacion_JudicializacionTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Vinculacion_JudicializacionData.push({
                Clave: gridData[i].Clave

                ,Relacion: gridData[i].Relacion

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Vinculacion_JudicializacionData.length; i++) {
        if (removedDetalle_Vinculacion_JudicializacionData[i] != null && removedDetalle_Vinculacion_JudicializacionData[i].Clave > 0)
            Detalle_Vinculacion_JudicializacionData.push({
                Clave: removedDetalle_Vinculacion_JudicializacionData[i].Clave

                ,Relacion: removedDetalle_Vinculacion_JudicializacionData[i].Relacion

                , Removed: true
            });
    }	

    return Detalle_Vinculacion_JudicializacionData;
}

function Detalle_Vinculacion_JudicializacionEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Vinculacion_JudicializacionTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Vinculacion_JudicializacioncountRowsChecked++;
    var Detalle_Vinculacion_JudicializacionRowElement = "Detalle_Vinculacion_Judicializacion_" + rowIndex.toString();
    var prevData = Detalle_Vinculacion_JudicializacionTable.fnGetData(rowIndexTable );
    var row = Detalle_Vinculacion_JudicializacionTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Vinculacion_Judicializacion_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Vinculacion_JudicializacionGetUpdateRowControls(prevData, "Detalle_Vinculacion_Judicializacion_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Vinculacion_JudicializacionRowElement + "')){ Detalle_Vinculacion_JudicializacionInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Vinculacion_JudicializacionCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Vinculacion_JudicializacionGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Vinculacion_JudicializacionGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Vinculacion_JudicializacionValidation();
    initiateUIControls();
    $('.Detalle_Vinculacion_Judicializacion' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Vinculacion_JudicializacionfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Vinculacion_JudicializacionTable.fnGetData().length;
    Detalle_Vinculacion_JudicializacionfnClickAddRow();
    GetAddDetalle_Vinculacion_JudicializacionPopup(currentRowIndex, 0);
}

function Detalle_Vinculacion_JudicializacionEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Vinculacion_JudicializacionTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Vinculacion_JudicializacionRowElement = "Detalle_Vinculacion_Judicializacion_" + rowIndex.toString();
    var prevData = Detalle_Vinculacion_JudicializacionTable.fnGetData(rowIndexTable);
    GetAddDetalle_Vinculacion_JudicializacionPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Vinculacion_JudicializacionRelacion').val(prevData.Relacion);

    initiateUIControls();



}

function Detalle_Vinculacion_JudicializacionAddInsertRow() {
    if (Detalle_Vinculacion_JudicializacioninsertRowCurrentIndex < 1)
    {
        Detalle_Vinculacion_JudicializacioninsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Relacion: ""

    }
}

function Detalle_Vinculacion_JudicializacionfnClickAddRow() {
    Detalle_Vinculacion_JudicializacioncountRowsChecked++;
    Detalle_Vinculacion_JudicializacionTable.fnAddData(Detalle_Vinculacion_JudicializacionAddInsertRow(), true);
    Detalle_Vinculacion_JudicializacionTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Vinculacion_JudicializacionGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Vinculacion_JudicializacionGrid tbody tr:nth-of-type(' + (Detalle_Vinculacion_JudicializacioninsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Vinculacion_Judicializacion("Detalle_Vinculacion_Judicializacion_", "_" + Detalle_Vinculacion_JudicializacioninsertRowCurrentIndex);
}

function Detalle_Vinculacion_JudicializacionClearGridData() {
    Detalle_Vinculacion_JudicializacionData = [];
    Detalle_Vinculacion_JudicializaciondeletedItem = [];
    Detalle_Vinculacion_JudicializacionDataMain = [];
    Detalle_Vinculacion_JudicializacionDataMainPages = [];
    Detalle_Vinculacion_JudicializacionnewItemCount = 0;
    Detalle_Vinculacion_JudicializacionmaxItemIndex = 0;
    $("#Detalle_Vinculacion_JudicializacionGrid").DataTable().clear();
    $("#Detalle_Vinculacion_JudicializacionGrid").DataTable().destroy();
}

//Used to Get Judicialización Information
function GetDetalle_Vinculacion_Judicializacion() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Vinculacion_JudicializacionData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Vinculacion_JudicializacionData[i].Clave);

        form_data.append('[' + i + '].Relacion', Detalle_Vinculacion_JudicializacionData[i].Relacion);

        form_data.append('[' + i + '].Removed', Detalle_Vinculacion_JudicializacionData[i].Removed);
    }
    return form_data;
}
function Detalle_Vinculacion_JudicializacionInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Vinculacion_Judicializacion("Detalle_Vinculacion_JudicializacionTable", rowIndex)) {
    var prevData = Detalle_Vinculacion_JudicializacionTable.fnGetData(rowIndex);
    var data = Detalle_Vinculacion_JudicializacionTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Relacion: $('#Detalle_Vinculacion_JudicializacionRelacion').val()

    }

    Detalle_Vinculacion_JudicializacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Vinculacion_JudicializacionrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Vinculacion_Judicializacion-form').modal({ show: false });
    $('#AddDetalle_Vinculacion_Judicializacion-form').modal('hide');
    Detalle_Vinculacion_JudicializacionEditRow(rowIndex);
    Detalle_Vinculacion_JudicializacionInsertRow(rowIndex);
    //}
}
function Detalle_Vinculacion_JudicializacionRemoveAddRow(rowIndex) {
    Detalle_Vinculacion_JudicializacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Vinculacion_Judicializacion MultiRow


$(function () {
    function Detalle_Vinculacion_JudicializacioninitializeMainArray(totalCount) {
        if (Detalle_Vinculacion_JudicializacionDataMain.length != totalCount && !Detalle_Vinculacion_JudicializacionDataMainInitialized) {
            Detalle_Vinculacion_JudicializacionDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Vinculacion_JudicializacionDataMain[i] = null;
            }
        }
    }
    function Detalle_Vinculacion_JudicializacionremoveFromMainArray() {
        for (var j = 0; j < Detalle_Vinculacion_JudicializaciondeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Vinculacion_JudicializacionDataMain.length; i++) {
                if (Detalle_Vinculacion_JudicializacionDataMain[i] != null && Detalle_Vinculacion_JudicializacionDataMain[i].Id == Detalle_Vinculacion_JudicializaciondeletedItem[j]) {
                    hDetalle_Vinculacion_JudicializacionDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Vinculacion_JudicializacioncopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Vinculacion_JudicializacionDataMain.length; i++) {
            data[i] = Detalle_Vinculacion_JudicializacionDataMain[i];

        }
        return data;
    }
    function Detalle_Vinculacion_JudicializaciongetNewResult() {
        var newData = copyMainDetalle_Vinculacion_JudicializacionArray();

        for (var i = 0; i < Detalle_Vinculacion_JudicializacionData.length; i++) {
            if (Detalle_Vinculacion_JudicializacionData[i].Removed == null || Detalle_Vinculacion_JudicializacionData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Vinculacion_JudicializacionData[i]);
            }
        }
        return newData;
    }
    function Detalle_Vinculacion_JudicializacionpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Vinculacion_JudicializacionDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Vinculacion_JudicializacionDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteExpediente_MPData = [];
function GetAutoCompleteJudicializacion_Expediente_MP_expediente_ministerio_publicoData(data) {
	AutoCompleteExpediente_MPData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MPData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteExpediente_MPData;
}
var AutoCompleteResolucionData = [];
function GetAutoCompleteJudicializacion_Resolucion_Resolucion_MPData(data) {
	AutoCompleteResolucionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteResolucionData.push({
            id: data[i].Clave,
            text: data[i].Observaciones
        });
    }
    return AutoCompleteResolucionData;
}
//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Judicializacion_cmbLabelSelect").val();
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
    $('#CreateJudicializacion')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Resolucion').empty();
    $("#Resolucion").append('<option value=""></option>');
    $('#Resolucion').val('0').trigger('change');
                Detalle_Vinculacion_JudicializacionClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateJudicializacion').trigger('reset');
    $('#CreateJudicializacion').find(':input').each(function () {
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
    var $myForm = $('#CreateJudicializacion');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Vinculacion_JudicializacioncountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Vinculacion_Judicializacion();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateJudicializacion").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateJudicializacion").on('click', '#JudicializacionCancelar', function () {
	  if (!isPartial) {
        JudicializacionBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateJudicializacion").on('click', '#JudicializacionGuardar', function () {
		$('#JudicializacionGuardar').attr('disabled', true);
		$('#JudicializacionGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendJudicializacionData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						JudicializacionBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#JudicializacionGuardar').removeAttr('disabled');
                        $('#JudicializacionGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Judicializacion', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_JudicializacionItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_JudicializacionDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#JudicializacionGuardar').removeAttr('disabled');
					$('#JudicializacionGuardar').bind()
				}
		}
		else {
			$('#JudicializacionGuardar').removeAttr('disabled');
			$('#JudicializacionGuardar').bind()
		}
    });
	$("form#CreateJudicializacion").on('click', '#JudicializacionGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendJudicializacionData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Vinculacion_JudicializacionData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Judicializacion', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_JudicializacionItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_JudicializacionDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateJudicializacion").on('click', '#JudicializacionGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendJudicializacionData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Resolucion').empty();
    $("#Resolucion").append('<option value=""></option>');
    $('#Resolucion').val('0').trigger('change');
                Detalle_Vinculacion_JudicializacionClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Vinculacion_JudicializacionData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Judicializacion',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_JudicializacionItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_JudicializacionDropDown().get(0)').innerHTML);                          
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



var JudicializacionisdisplayBusinessPropery = false;
JudicializacionDisplayBusinessRuleButtons(JudicializacionisdisplayBusinessPropery);
function JudicializacionDisplayBusinessRule() {
    if (!JudicializacionisdisplayBusinessPropery) {
        $('#CreateJudicializacion').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="JudicializaciondisplayBusinessPropery"><button onclick="JudicializacionGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#JudicializacionBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.JudicializaciondisplayBusinessPropery').remove();
    }
    JudicializacionDisplayBusinessRuleButtons(!JudicializacionisdisplayBusinessPropery);
    JudicializacionisdisplayBusinessPropery = (JudicializacionisdisplayBusinessPropery ? false : true);
}
function JudicializacionDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

