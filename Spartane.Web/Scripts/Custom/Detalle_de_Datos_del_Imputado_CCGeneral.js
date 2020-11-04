

//Begin Declarations for Foreigns fields for Detalle_de_Galeria_de_Detenidos MultiRow
var Detalle_de_Galeria_de_DetenidoscountRowsChecked = 0;





function GetInsertDetalle_de_Galeria_de_DetenidosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Galeria_de_Detenidos_Nombre Nombre').attr('id', 'Detalle_de_Galeria_de_Detenidos_Nombre_' + index).attr('data-field', 'Nombre');
    columnData[1] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Galeria_de_Detenidos_Archivo Archivo').attr('id', 'Detalle_de_Galeria_de_Detenidos_Archivo_' + index).attr('data-field', 'Archivo');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Galeria_de_DetenidosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Galeria_de_Detenidos("Detalle_de_Galeria_de_Detenidos_", "_" + rowIndex)) {
    var iPage = Detalle_de_Galeria_de_DetenidosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Galeria_de_Detenidos';
    var prevData = Detalle_de_Galeria_de_DetenidosTable.fnGetData(rowIndex);
    var data = Detalle_de_Galeria_de_DetenidosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Archivo: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Galeria_de_DetenidosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Galeria_de_DetenidosrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Galeria_de_DetenidosTable.fnPageChange(iPage);
    Detalle_de_Galeria_de_DetenidoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Galeria_de_Detenidos("Detalle_de_Galeria_de_Detenidos_", "_" + rowIndex);
  }
}

function Detalle_de_Galeria_de_DetenidosCancelRow(rowIndex) {
    var prevData = Detalle_de_Galeria_de_DetenidosTable.fnGetData(rowIndex);
    var data = Detalle_de_Galeria_de_DetenidosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Galeria_de_DetenidosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Galeria_de_DetenidosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Galeria_de_DetenidosGrid(Detalle_de_Galeria_de_DetenidosTable.fnGetData());
    Detalle_de_Galeria_de_DetenidoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Galeria_de_DetenidosFromDataTable() {
    var Detalle_de_Galeria_de_DetenidosData = [];
    var gridData = Detalle_de_Galeria_de_DetenidosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Galeria_de_DetenidosData.push({
                Clave: gridData[i].Clave

                ,Nombre: gridData[i].Nombre
                ,Archivo: gridData[i].Archivo

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Galeria_de_DetenidosData.length; i++) {
        if (removedDetalle_de_Galeria_de_DetenidosData[i] != null && removedDetalle_de_Galeria_de_DetenidosData[i].Clave > 0)
            Detalle_de_Galeria_de_DetenidosData.push({
                Clave: removedDetalle_de_Galeria_de_DetenidosData[i].Clave

                ,Nombre: removedDetalle_de_Galeria_de_DetenidosData[i].Nombre
                ,Archivo: removedDetalle_de_Galeria_de_DetenidosData[i].Archivo

                , Removed: true
            });
    }	

    return Detalle_de_Galeria_de_DetenidosData;
}

function Detalle_de_Galeria_de_DetenidosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Galeria_de_DetenidosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Galeria_de_DetenidoscountRowsChecked++;
    var Detalle_de_Galeria_de_DetenidosRowElement = "Detalle_de_Galeria_de_Detenidos_" + rowIndex.toString();
    var prevData = Detalle_de_Galeria_de_DetenidosTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Galeria_de_DetenidosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Galeria_de_Detenidos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Galeria_de_DetenidosGetUpdateRowControls(prevData, "Detalle_de_Galeria_de_Detenidos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Galeria_de_DetenidosRowElement + "')){ Detalle_de_Galeria_de_DetenidosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Galeria_de_DetenidosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Galeria_de_DetenidosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Galeria_de_DetenidosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Galeria_de_DetenidosValidation();
    initiateUIControls();
    $('.Detalle_de_Galeria_de_Detenidos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Galeria_de_Detenidos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Galeria_de_DetenidosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Galeria_de_DetenidosTable.fnGetData().length;
    Detalle_de_Galeria_de_DetenidosfnClickAddRow();
    GetAddDetalle_de_Galeria_de_DetenidosPopup(currentRowIndex, 0);
}

function Detalle_de_Galeria_de_DetenidosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Galeria_de_DetenidosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Galeria_de_DetenidosRowElement = "Detalle_de_Galeria_de_Detenidos_" + rowIndex.toString();
    var prevData = Detalle_de_Galeria_de_DetenidosTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Galeria_de_DetenidosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Galeria_de_DetenidosNombre').val(prevData.Nombre);
    $('#Detalle_de_Galeria_de_DetenidosArchivo').val(prevData.Archivo);

    initiateUIControls();




}

function Detalle_de_Galeria_de_DetenidosAddInsertRow() {
    if (Detalle_de_Galeria_de_DetenidosinsertRowCurrentIndex < 1)
    {
        Detalle_de_Galeria_de_DetenidosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre: ""
        ,Archivo: ""

    }
}

function Detalle_de_Galeria_de_DetenidosfnClickAddRow() {
    Detalle_de_Galeria_de_DetenidoscountRowsChecked++;
    Detalle_de_Galeria_de_DetenidosTable.fnAddData(Detalle_de_Galeria_de_DetenidosAddInsertRow(), true);
    Detalle_de_Galeria_de_DetenidosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Galeria_de_DetenidosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Galeria_de_DetenidosGrid tbody tr:nth-of-type(' + (Detalle_de_Galeria_de_DetenidosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Galeria_de_Detenidos("Detalle_de_Galeria_de_Detenidos_", "_" + Detalle_de_Galeria_de_DetenidosinsertRowCurrentIndex);
}

function Detalle_de_Galeria_de_DetenidosClearGridData() {
    Detalle_de_Galeria_de_DetenidosData = [];
    Detalle_de_Galeria_de_DetenidosdeletedItem = [];
    Detalle_de_Galeria_de_DetenidosDataMain = [];
    Detalle_de_Galeria_de_DetenidosDataMainPages = [];
    Detalle_de_Galeria_de_DetenidosnewItemCount = 0;
    Detalle_de_Galeria_de_DetenidosmaxItemIndex = 0;
    $("#Detalle_de_Galeria_de_DetenidosGrid").DataTable().clear();
    $("#Detalle_de_Galeria_de_DetenidosGrid").DataTable().destroy();
}

//Used to Get Detalle de Datos del Imputado CC Information
function GetDetalle_de_Galeria_de_Detenidos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Galeria_de_DetenidosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Galeria_de_DetenidosData[i].Clave);

        form_data.append('[' + i + '].Nombre', Detalle_de_Galeria_de_DetenidosData[i].Nombre);
        form_data.append('[' + i + '].Archivo', Detalle_de_Galeria_de_DetenidosData[i].Archivo);

        form_data.append('[' + i + '].Removed', Detalle_de_Galeria_de_DetenidosData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Galeria_de_DetenidosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Galeria_de_Detenidos("Detalle_de_Galeria_de_DetenidosTable", rowIndex)) {
    var prevData = Detalle_de_Galeria_de_DetenidosTable.fnGetData(rowIndex);
    var data = Detalle_de_Galeria_de_DetenidosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre: $('#Detalle_de_Galeria_de_DetenidosNombre').val()
        ,Archivo: $('#Detalle_de_Galeria_de_DetenidosArchivo').val()


    }

    Detalle_de_Galeria_de_DetenidosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Galeria_de_DetenidosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Galeria_de_Detenidos-form').modal({ show: false });
    $('#AddDetalle_de_Galeria_de_Detenidos-form').modal('hide');
    Detalle_de_Galeria_de_DetenidosEditRow(rowIndex);
    Detalle_de_Galeria_de_DetenidosInsertRow(rowIndex);
    //}
}
function Detalle_de_Galeria_de_DetenidosRemoveAddRow(rowIndex) {
    Detalle_de_Galeria_de_DetenidosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Galeria_de_Detenidos MultiRow


$(function () {
    function Detalle_de_Galeria_de_DetenidosinitializeMainArray(totalCount) {
        if (Detalle_de_Galeria_de_DetenidosDataMain.length != totalCount && !Detalle_de_Galeria_de_DetenidosDataMainInitialized) {
            Detalle_de_Galeria_de_DetenidosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Galeria_de_DetenidosDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Galeria_de_DetenidosremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Galeria_de_DetenidosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Galeria_de_DetenidosDataMain.length; i++) {
                if (Detalle_de_Galeria_de_DetenidosDataMain[i] != null && Detalle_de_Galeria_de_DetenidosDataMain[i].Id == Detalle_de_Galeria_de_DetenidosdeletedItem[j]) {
                    hDetalle_de_Galeria_de_DetenidosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Galeria_de_DetenidoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Galeria_de_DetenidosDataMain.length; i++) {
            data[i] = Detalle_de_Galeria_de_DetenidosDataMain[i];

        }
        return data;
    }
    function Detalle_de_Galeria_de_DetenidosgetNewResult() {
        var newData = copyMainDetalle_de_Galeria_de_DetenidosArray();

        for (var i = 0; i < Detalle_de_Galeria_de_DetenidosData.length; i++) {
            if (Detalle_de_Galeria_de_DetenidosData[i].Removed == null || Detalle_de_Galeria_de_DetenidosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Galeria_de_DetenidosData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Galeria_de_DetenidospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Galeria_de_DetenidosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Galeria_de_DetenidosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Datos_del_Imputado_CC')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Detalle_de_Galeria_de_DetenidosClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Datos_del_Imputado_CC').trigger('reset');
    $('#CreateDetalle_de_Datos_del_Imputado_CC').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Datos_del_Imputado_CC');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Galeria_de_DetenidoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Galeria_de_Detenidos();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Datos_del_Imputado_CC").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Datos_del_Imputado_CC").on('click', '#Detalle_de_Datos_del_Imputado_CCCancelar', function () {
	  if (!isPartial) {
        Detalle_de_Datos_del_Imputado_CCBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Datos_del_Imputado_CC").on('click', '#Detalle_de_Datos_del_Imputado_CCGuardar', function () {
		$('#Detalle_de_Datos_del_Imputado_CCGuardar').attr('disabled', true);
		$('#Detalle_de_Datos_del_Imputado_CCGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_Datos_del_Imputado_CCData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_Datos_del_Imputado_CCBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_Datos_del_Imputado_CCGuardar').removeAttr('disabled');
                        $('#Detalle_de_Datos_del_Imputado_CCGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Datos_del_Imputado_CC', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_CCItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_CCDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Detalle_de_Datos_del_Imputado_CCGuardar').removeAttr('disabled');
					$('#Detalle_de_Datos_del_Imputado_CCGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_Datos_del_Imputado_CCGuardar').removeAttr('disabled');
			$('#Detalle_de_Datos_del_Imputado_CCGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Datos_del_Imputado_CC").on('click', '#Detalle_de_Datos_del_Imputado_CCGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_Datos_del_Imputado_CCData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Galeria_de_DetenidosData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Datos_del_Imputado_CC', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_CCItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_CCDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Datos_del_Imputado_CC").on('click', '#Detalle_de_Datos_del_Imputado_CCGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_Datos_del_Imputado_CCData(function (currentId) {
					$("#ClaveId").val("0");
	                Detalle_de_Galeria_de_DetenidosClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_Galeria_de_DetenidosData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Datos_del_Imputado_CC',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_CCItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_CCDropDown().get(0)').innerHTML);                          
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



var Detalle_de_Datos_del_Imputado_CCisdisplayBusinessPropery = false;
Detalle_de_Datos_del_Imputado_CCDisplayBusinessRuleButtons(Detalle_de_Datos_del_Imputado_CCisdisplayBusinessPropery);
function Detalle_de_Datos_del_Imputado_CCDisplayBusinessRule() {
    if (!Detalle_de_Datos_del_Imputado_CCisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Datos_del_Imputado_CC').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_Datos_del_Imputado_CCdisplayBusinessPropery"><button onclick="Detalle_de_Datos_del_Imputado_CCGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_Datos_del_Imputado_CCBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_Datos_del_Imputado_CCdisplayBusinessPropery').remove();
    }
    Detalle_de_Datos_del_Imputado_CCDisplayBusinessRuleButtons(!Detalle_de_Datos_del_Imputado_CCisdisplayBusinessPropery);
    Detalle_de_Datos_del_Imputado_CCisdisplayBusinessPropery = (Detalle_de_Datos_del_Imputado_CCisdisplayBusinessPropery ? false : true);
}
function Detalle_de_Datos_del_Imputado_CCDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

