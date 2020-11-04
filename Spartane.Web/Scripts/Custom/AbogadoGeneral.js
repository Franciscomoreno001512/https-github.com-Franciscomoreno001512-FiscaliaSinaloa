

//Begin Declarations for Foreigns fields for Detalle_de_Abogado MultiRow
var Detalle_de_AbogadocountRowsChecked = 0;







function GetInsertDetalle_de_AbogadoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Abogado_NUC NUC').attr('id', 'Detalle_de_Abogado_NUC_' + index).attr('data-field', 'NUC');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Abogado_Nombre_del_Representado Nombre_del_Representado').attr('id', 'Detalle_de_Abogado_Nombre_del_Representado_' + index).attr('data-field', 'Nombre_del_Representado');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Abogado_Tipo_de_Representante Tipo_de_Representante').attr('id', 'Detalle_de_Abogado_Tipo_de_Representante_' + index).attr('data-field', 'Tipo_de_Representante');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Abogado_Comentarios Comentarios').attr('id', 'Detalle_de_Abogado_Comentarios_' + index).attr('data-field', 'Comentarios');


    initiateUIControls();
    return columnData;
}

function Detalle_de_AbogadoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Abogado("Detalle_de_Abogado_", "_" + rowIndex)) {
    var iPage = Detalle_de_AbogadoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Abogado';
    var prevData = Detalle_de_AbogadoTable.fnGetData(rowIndex);
    var data = Detalle_de_AbogadoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,NUC:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_del_Representado:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Representante:  data.childNodes[counter++].childNodes[0].value
        ,Comentarios:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_AbogadoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_AbogadorowCreationGrid(data, newData, rowIndex);
    Detalle_de_AbogadoTable.fnPageChange(iPage);
    Detalle_de_AbogadocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Abogado("Detalle_de_Abogado_", "_" + rowIndex);
  }
}

function Detalle_de_AbogadoCancelRow(rowIndex) {
    var prevData = Detalle_de_AbogadoTable.fnGetData(rowIndex);
    var data = Detalle_de_AbogadoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_AbogadoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_AbogadorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_AbogadoGrid(Detalle_de_AbogadoTable.fnGetData());
    Detalle_de_AbogadocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_AbogadoFromDataTable() {
    var Detalle_de_AbogadoData = [];
    var gridData = Detalle_de_AbogadoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_AbogadoData.push({
                Clave: gridData[i].Clave

                ,NUC: gridData[i].NUC
                ,Nombre_del_Representado: gridData[i].Nombre_del_Representado
                ,Tipo_de_Representante: gridData[i].Tipo_de_Representante
                ,Comentarios: gridData[i].Comentarios

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_AbogadoData.length; i++) {
        if (removedDetalle_de_AbogadoData[i] != null && removedDetalle_de_AbogadoData[i].Clave > 0)
            Detalle_de_AbogadoData.push({
                Clave: removedDetalle_de_AbogadoData[i].Clave

                ,NUC: removedDetalle_de_AbogadoData[i].NUC
                ,Nombre_del_Representado: removedDetalle_de_AbogadoData[i].Nombre_del_Representado
                ,Tipo_de_Representante: removedDetalle_de_AbogadoData[i].Tipo_de_Representante
                ,Comentarios: removedDetalle_de_AbogadoData[i].Comentarios

                , Removed: true
            });
    }	

    return Detalle_de_AbogadoData;
}

function Detalle_de_AbogadoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_AbogadoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_AbogadocountRowsChecked++;
    var Detalle_de_AbogadoRowElement = "Detalle_de_Abogado_" + rowIndex.toString();
    var prevData = Detalle_de_AbogadoTable.fnGetData(rowIndexTable );
    var row = Detalle_de_AbogadoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Abogado_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_AbogadoGetUpdateRowControls(prevData, "Detalle_de_Abogado_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_AbogadoRowElement + "')){ Detalle_de_AbogadoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_AbogadoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_AbogadoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_AbogadoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_AbogadoValidation();
    initiateUIControls();
    $('.Detalle_de_Abogado' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Abogado(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_AbogadofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_AbogadoTable.fnGetData().length;
    Detalle_de_AbogadofnClickAddRow();
    GetAddDetalle_de_AbogadoPopup(currentRowIndex, 0);
}

function Detalle_de_AbogadoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_AbogadoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_AbogadoRowElement = "Detalle_de_Abogado_" + rowIndex.toString();
    var prevData = Detalle_de_AbogadoTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_AbogadoPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_AbogadoNUC').val(prevData.NUC);
    $('#Detalle_de_AbogadoNombre_del_Representado').val(prevData.Nombre_del_Representado);
    $('#Detalle_de_AbogadoTipo_de_Representante').val(prevData.Tipo_de_Representante);
    $('#Detalle_de_AbogadoComentarios').val(prevData.Comentarios);

    initiateUIControls();






}

function Detalle_de_AbogadoAddInsertRow() {
    if (Detalle_de_AbogadoinsertRowCurrentIndex < 1)
    {
        Detalle_de_AbogadoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,NUC: ""
        ,Nombre_del_Representado: ""
        ,Tipo_de_Representante: ""
        ,Comentarios: ""

    }
}

function Detalle_de_AbogadofnClickAddRow() {
    Detalle_de_AbogadocountRowsChecked++;
    Detalle_de_AbogadoTable.fnAddData(Detalle_de_AbogadoAddInsertRow(), true);
    Detalle_de_AbogadoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_AbogadoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_AbogadoGrid tbody tr:nth-of-type(' + (Detalle_de_AbogadoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Abogado("Detalle_de_Abogado_", "_" + Detalle_de_AbogadoinsertRowCurrentIndex);
}

function Detalle_de_AbogadoClearGridData() {
    Detalle_de_AbogadoData = [];
    Detalle_de_AbogadodeletedItem = [];
    Detalle_de_AbogadoDataMain = [];
    Detalle_de_AbogadoDataMainPages = [];
    Detalle_de_AbogadonewItemCount = 0;
    Detalle_de_AbogadomaxItemIndex = 0;
    $("#Detalle_de_AbogadoGrid").DataTable().clear();
    $("#Detalle_de_AbogadoGrid").DataTable().destroy();
}

//Used to Get Abogado Information
function GetDetalle_de_Abogado() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_AbogadoData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_AbogadoData[i].Clave);

        form_data.append('[' + i + '].NUC', Detalle_de_AbogadoData[i].NUC);
        form_data.append('[' + i + '].Nombre_del_Representado', Detalle_de_AbogadoData[i].Nombre_del_Representado);
        form_data.append('[' + i + '].Tipo_de_Representante', Detalle_de_AbogadoData[i].Tipo_de_Representante);
        form_data.append('[' + i + '].Comentarios', Detalle_de_AbogadoData[i].Comentarios);

        form_data.append('[' + i + '].Removed', Detalle_de_AbogadoData[i].Removed);
    }
    return form_data;
}
function Detalle_de_AbogadoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Abogado("Detalle_de_AbogadoTable", rowIndex)) {
    var prevData = Detalle_de_AbogadoTable.fnGetData(rowIndex);
    var data = Detalle_de_AbogadoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,NUC: $('#Detalle_de_AbogadoNUC').val()
        ,Nombre_del_Representado: $('#Detalle_de_AbogadoNombre_del_Representado').val()
        ,Tipo_de_Representante: $('#Detalle_de_AbogadoTipo_de_Representante').val()
        ,Comentarios: $('#Detalle_de_AbogadoComentarios').val()

    }

    Detalle_de_AbogadoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_AbogadorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Abogado-form').modal({ show: false });
    $('#AddDetalle_de_Abogado-form').modal('hide');
    Detalle_de_AbogadoEditRow(rowIndex);
    Detalle_de_AbogadoInsertRow(rowIndex);
    //}
}
function Detalle_de_AbogadoRemoveAddRow(rowIndex) {
    Detalle_de_AbogadoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Abogado MultiRow


$(function () {
    function Detalle_de_AbogadoinitializeMainArray(totalCount) {
        if (Detalle_de_AbogadoDataMain.length != totalCount && !Detalle_de_AbogadoDataMainInitialized) {
            Detalle_de_AbogadoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_AbogadoDataMain[i] = null;
            }
        }
    }
    function Detalle_de_AbogadoremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_AbogadodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_AbogadoDataMain.length; i++) {
                if (Detalle_de_AbogadoDataMain[i] != null && Detalle_de_AbogadoDataMain[i].Id == Detalle_de_AbogadodeletedItem[j]) {
                    hDetalle_de_AbogadoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_AbogadocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_AbogadoDataMain.length; i++) {
            data[i] = Detalle_de_AbogadoDataMain[i];

        }
        return data;
    }
    function Detalle_de_AbogadogetNewResult() {
        var newData = copyMainDetalle_de_AbogadoArray();

        for (var i = 0; i < Detalle_de_AbogadoData.length; i++) {
            if (Detalle_de_AbogadoData[i].Removed == null || Detalle_de_AbogadoData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_AbogadoData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_AbogadopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_AbogadoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_AbogadoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Abogado_cmbLabelSelect").val();
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
    $('#CreateAbogado')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Detalle_de_AbogadoClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateAbogado').trigger('reset');
    $('#CreateAbogado').find(':input').each(function () {
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
    var $myForm = $('#CreateAbogado');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_AbogadocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Abogado();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateAbogado").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateAbogado").on('click', '#AbogadoCancelar', function () {
	  if (!isPartial) {
        AbogadoBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateAbogado").on('click', '#AbogadoGuardar', function () {
		$('#AbogadoGuardar').attr('disabled', true);
		$('#AbogadoGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendAbogadoData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						AbogadoBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#AbogadoGuardar').removeAttr('disabled');
                        $('#AbogadoGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Abogado', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_AbogadoItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_AbogadoDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#AbogadoGuardar').removeAttr('disabled');
					$('#AbogadoGuardar').bind()
				}
		}
		else {
			$('#AbogadoGuardar').removeAttr('disabled');
			$('#AbogadoGuardar').bind()
		}
    });
	$("form#CreateAbogado").on('click', '#AbogadoGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendAbogadoData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_AbogadoData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Abogado', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_AbogadoItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_AbogadoDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateAbogado").on('click', '#AbogadoGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendAbogadoData(function (currentId) {
					$("#ClaveId").val("0");
	                Detalle_de_AbogadoClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_AbogadoData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Abogado',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_AbogadoItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_AbogadoDropDown().get(0)').innerHTML);                          
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



var AbogadoisdisplayBusinessPropery = false;
AbogadoDisplayBusinessRuleButtons(AbogadoisdisplayBusinessPropery);
function AbogadoDisplayBusinessRule() {
    if (!AbogadoisdisplayBusinessPropery) {
        $('#CreateAbogado').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="AbogadodisplayBusinessPropery"><button onclick="AbogadoGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#AbogadoBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.AbogadodisplayBusinessPropery').remove();
    }
    AbogadoDisplayBusinessRuleButtons(!AbogadoisdisplayBusinessPropery);
    AbogadoisdisplayBusinessPropery = (AbogadoisdisplayBusinessPropery ? false : true);
}
function AbogadoDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

