

//Begin Declarations for Foreigns fields for Detalle_de_Galeria_de_Intervinientes MultiRow
var Detalle_de_Galeria_de_IntervinientescountRowsChecked = 0;





function GetInsertDetalle_de_Galeria_de_IntervinientesRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Galeria_de_Intervinientes_Nombre Nombre').attr('id', 'Detalle_de_Galeria_de_Intervinientes_Nombre_' + index).attr('data-field', 'Nombre');
    columnData[1] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Galeria_de_Intervinientes_Archivo Archivo').attr('id', 'Detalle_de_Galeria_de_Intervinientes_Archivo_' + index).attr('data-field', 'Archivo');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Galeria_de_IntervinientesInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Galeria_de_Intervinientes("Detalle_de_Galeria_de_Intervinientes_", "_" + rowIndex)) {
    var iPage = Detalle_de_Galeria_de_IntervinientesTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Galeria_de_Intervinientes';
    var prevData = Detalle_de_Galeria_de_IntervinientesTable.fnGetData(rowIndex);
    var data = Detalle_de_Galeria_de_IntervinientesTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Archivo: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Galeria_de_IntervinientesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Galeria_de_IntervinientesrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Galeria_de_IntervinientesTable.fnPageChange(iPage);
    Detalle_de_Galeria_de_IntervinientescountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Galeria_de_Intervinientes("Detalle_de_Galeria_de_Intervinientes_", "_" + rowIndex);
  }
}

function Detalle_de_Galeria_de_IntervinientesCancelRow(rowIndex) {
    var prevData = Detalle_de_Galeria_de_IntervinientesTable.fnGetData(rowIndex);
    var data = Detalle_de_Galeria_de_IntervinientesTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Galeria_de_IntervinientesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Galeria_de_IntervinientesrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Galeria_de_IntervinientesGrid(Detalle_de_Galeria_de_IntervinientesTable.fnGetData());
    Detalle_de_Galeria_de_IntervinientescountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Galeria_de_IntervinientesFromDataTable() {
    var Detalle_de_Galeria_de_IntervinientesData = [];
    var gridData = Detalle_de_Galeria_de_IntervinientesTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Galeria_de_IntervinientesData.push({
                Clave: gridData[i].Clave

                ,Nombre: gridData[i].Nombre
                ,Archivo: gridData[i].Archivo

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Galeria_de_IntervinientesData.length; i++) {
        if (removedDetalle_de_Galeria_de_IntervinientesData[i] != null && removedDetalle_de_Galeria_de_IntervinientesData[i].Clave > 0)
            Detalle_de_Galeria_de_IntervinientesData.push({
                Clave: removedDetalle_de_Galeria_de_IntervinientesData[i].Clave

                ,Nombre: removedDetalle_de_Galeria_de_IntervinientesData[i].Nombre
                ,Archivo: removedDetalle_de_Galeria_de_IntervinientesData[i].Archivo

                , Removed: true
            });
    }	

    return Detalle_de_Galeria_de_IntervinientesData;
}

function Detalle_de_Galeria_de_IntervinientesEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Galeria_de_IntervinientesTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Galeria_de_IntervinientescountRowsChecked++;
    var Detalle_de_Galeria_de_IntervinientesRowElement = "Detalle_de_Galeria_de_Intervinientes_" + rowIndex.toString();
    var prevData = Detalle_de_Galeria_de_IntervinientesTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Galeria_de_IntervinientesTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Galeria_de_Intervinientes_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Galeria_de_IntervinientesGetUpdateRowControls(prevData, "Detalle_de_Galeria_de_Intervinientes_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Galeria_de_IntervinientesRowElement + "')){ Detalle_de_Galeria_de_IntervinientesInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Galeria_de_IntervinientesCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Galeria_de_IntervinientesGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Galeria_de_IntervinientesGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Galeria_de_IntervinientesValidation();
    initiateUIControls();
    $('.Detalle_de_Galeria_de_Intervinientes' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Galeria_de_Intervinientes(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Galeria_de_IntervinientesfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Galeria_de_IntervinientesTable.fnGetData().length;
    Detalle_de_Galeria_de_IntervinientesfnClickAddRow();
    GetAddDetalle_de_Galeria_de_IntervinientesPopup(currentRowIndex, 0);
}

function Detalle_de_Galeria_de_IntervinientesEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Galeria_de_IntervinientesTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Galeria_de_IntervinientesRowElement = "Detalle_de_Galeria_de_Intervinientes_" + rowIndex.toString();
    var prevData = Detalle_de_Galeria_de_IntervinientesTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Galeria_de_IntervinientesPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Galeria_de_IntervinientesNombre').val(prevData.Nombre);
    $('#Detalle_de_Galeria_de_IntervinientesArchivo').val(prevData.Archivo);

    initiateUIControls();




}

function Detalle_de_Galeria_de_IntervinientesAddInsertRow() {
    if (Detalle_de_Galeria_de_IntervinientesinsertRowCurrentIndex < 1)
    {
        Detalle_de_Galeria_de_IntervinientesinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre: ""
        ,Archivo: ""

    }
}

function Detalle_de_Galeria_de_IntervinientesfnClickAddRow() {
    Detalle_de_Galeria_de_IntervinientescountRowsChecked++;
    Detalle_de_Galeria_de_IntervinientesTable.fnAddData(Detalle_de_Galeria_de_IntervinientesAddInsertRow(), true);
    Detalle_de_Galeria_de_IntervinientesTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Galeria_de_IntervinientesGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Galeria_de_IntervinientesGrid tbody tr:nth-of-type(' + (Detalle_de_Galeria_de_IntervinientesinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Galeria_de_Intervinientes("Detalle_de_Galeria_de_Intervinientes_", "_" + Detalle_de_Galeria_de_IntervinientesinsertRowCurrentIndex);
}

function Detalle_de_Galeria_de_IntervinientesClearGridData() {
    Detalle_de_Galeria_de_IntervinientesData = [];
    Detalle_de_Galeria_de_IntervinientesdeletedItem = [];
    Detalle_de_Galeria_de_IntervinientesDataMain = [];
    Detalle_de_Galeria_de_IntervinientesDataMainPages = [];
    Detalle_de_Galeria_de_IntervinientesnewItemCount = 0;
    Detalle_de_Galeria_de_IntervinientesmaxItemIndex = 0;
    $("#Detalle_de_Galeria_de_IntervinientesGrid").DataTable().clear();
    $("#Detalle_de_Galeria_de_IntervinientesGrid").DataTable().destroy();
}

//Used to Get Detalle de Registro de Intervinientes CC Information
function GetDetalle_de_Galeria_de_Intervinientes() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Galeria_de_IntervinientesData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Galeria_de_IntervinientesData[i].Clave);

        form_data.append('[' + i + '].Nombre', Detalle_de_Galeria_de_IntervinientesData[i].Nombre);
        form_data.append('[' + i + '].Archivo', Detalle_de_Galeria_de_IntervinientesData[i].Archivo);

        form_data.append('[' + i + '].Removed', Detalle_de_Galeria_de_IntervinientesData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Galeria_de_IntervinientesInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Galeria_de_Intervinientes("Detalle_de_Galeria_de_IntervinientesTable", rowIndex)) {
    var prevData = Detalle_de_Galeria_de_IntervinientesTable.fnGetData(rowIndex);
    var data = Detalle_de_Galeria_de_IntervinientesTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre: $('#Detalle_de_Galeria_de_IntervinientesNombre').val()
        ,Archivo: $('#Detalle_de_Galeria_de_IntervinientesArchivo').val()


    }

    Detalle_de_Galeria_de_IntervinientesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Galeria_de_IntervinientesrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Galeria_de_Intervinientes-form').modal({ show: false });
    $('#AddDetalle_de_Galeria_de_Intervinientes-form').modal('hide');
    Detalle_de_Galeria_de_IntervinientesEditRow(rowIndex);
    Detalle_de_Galeria_de_IntervinientesInsertRow(rowIndex);
    //}
}
function Detalle_de_Galeria_de_IntervinientesRemoveAddRow(rowIndex) {
    Detalle_de_Galeria_de_IntervinientesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Galeria_de_Intervinientes MultiRow


$(function () {
    function Detalle_de_Galeria_de_IntervinientesinitializeMainArray(totalCount) {
        if (Detalle_de_Galeria_de_IntervinientesDataMain.length != totalCount && !Detalle_de_Galeria_de_IntervinientesDataMainInitialized) {
            Detalle_de_Galeria_de_IntervinientesDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Galeria_de_IntervinientesDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Galeria_de_IntervinientesremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Galeria_de_IntervinientesdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Galeria_de_IntervinientesDataMain.length; i++) {
                if (Detalle_de_Galeria_de_IntervinientesDataMain[i] != null && Detalle_de_Galeria_de_IntervinientesDataMain[i].Id == Detalle_de_Galeria_de_IntervinientesdeletedItem[j]) {
                    hDetalle_de_Galeria_de_IntervinientesDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Galeria_de_IntervinientescopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Galeria_de_IntervinientesDataMain.length; i++) {
            data[i] = Detalle_de_Galeria_de_IntervinientesDataMain[i];

        }
        return data;
    }
    function Detalle_de_Galeria_de_IntervinientesgetNewResult() {
        var newData = copyMainDetalle_de_Galeria_de_IntervinientesArray();

        for (var i = 0; i < Detalle_de_Galeria_de_IntervinientesData.length; i++) {
            if (Detalle_de_Galeria_de_IntervinientesData[i].Removed == null || Detalle_de_Galeria_de_IntervinientesData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Galeria_de_IntervinientesData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Galeria_de_IntervinientespushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Galeria_de_IntervinientesDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Galeria_de_IntervinientesDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Registro_de_Intervinientes_CC')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Detalle_de_Galeria_de_IntervinientesClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Registro_de_Intervinientes_CC').trigger('reset');
    $('#CreateDetalle_de_Registro_de_Intervinientes_CC').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Registro_de_Intervinientes_CC');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Galeria_de_IntervinientescountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Galeria_de_Intervinientes();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Registro_de_Intervinientes_CC").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Registro_de_Intervinientes_CC").on('click', '#Detalle_de_Registro_de_Intervinientes_CCCancelar', function () {
	  if (!isPartial) {
        Detalle_de_Registro_de_Intervinientes_CCBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Registro_de_Intervinientes_CC").on('click', '#Detalle_de_Registro_de_Intervinientes_CCGuardar', function () {
		$('#Detalle_de_Registro_de_Intervinientes_CCGuardar').attr('disabled', true);
		$('#Detalle_de_Registro_de_Intervinientes_CCGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_Registro_de_Intervinientes_CCData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_Registro_de_Intervinientes_CCBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_Registro_de_Intervinientes_CCGuardar').removeAttr('disabled');
                        $('#Detalle_de_Registro_de_Intervinientes_CCGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Registro_de_Intervinientes_CC', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_Registro_de_Intervinientes_CCItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Registro_de_Intervinientes_CCDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Detalle_de_Registro_de_Intervinientes_CCGuardar').removeAttr('disabled');
					$('#Detalle_de_Registro_de_Intervinientes_CCGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_Registro_de_Intervinientes_CCGuardar').removeAttr('disabled');
			$('#Detalle_de_Registro_de_Intervinientes_CCGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Registro_de_Intervinientes_CC").on('click', '#Detalle_de_Registro_de_Intervinientes_CCGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_Registro_de_Intervinientes_CCData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Galeria_de_IntervinientesData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Registro_de_Intervinientes_CC', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Registro_de_Intervinientes_CCItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Registro_de_Intervinientes_CCDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Registro_de_Intervinientes_CC").on('click', '#Detalle_de_Registro_de_Intervinientes_CCGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_Registro_de_Intervinientes_CCData(function (currentId) {
					$("#ClaveId").val("0");
	                Detalle_de_Galeria_de_IntervinientesClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_Galeria_de_IntervinientesData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Registro_de_Intervinientes_CC',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Registro_de_Intervinientes_CCItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Registro_de_Intervinientes_CCDropDown().get(0)').innerHTML);                          
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



var Detalle_de_Registro_de_Intervinientes_CCisdisplayBusinessPropery = false;
Detalle_de_Registro_de_Intervinientes_CCDisplayBusinessRuleButtons(Detalle_de_Registro_de_Intervinientes_CCisdisplayBusinessPropery);
function Detalle_de_Registro_de_Intervinientes_CCDisplayBusinessRule() {
    if (!Detalle_de_Registro_de_Intervinientes_CCisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Registro_de_Intervinientes_CC').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_Registro_de_Intervinientes_CCdisplayBusinessPropery"><button onclick="Detalle_de_Registro_de_Intervinientes_CCGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_Registro_de_Intervinientes_CCBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_Registro_de_Intervinientes_CCdisplayBusinessPropery').remove();
    }
    Detalle_de_Registro_de_Intervinientes_CCDisplayBusinessRuleButtons(!Detalle_de_Registro_de_Intervinientes_CCisdisplayBusinessPropery);
    Detalle_de_Registro_de_Intervinientes_CCisdisplayBusinessPropery = (Detalle_de_Registro_de_Intervinientes_CCisdisplayBusinessPropery ? false : true);
}
function Detalle_de_Registro_de_Intervinientes_CCDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

