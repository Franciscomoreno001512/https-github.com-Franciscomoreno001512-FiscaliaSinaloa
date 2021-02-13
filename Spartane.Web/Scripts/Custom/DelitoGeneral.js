

//Begin Declarations for Foreigns fields for Configuracion_de_Planeacion MultiRow
var Configuracion_de_PlaneacioncountRowsChecked = 0;

function GetConfiguracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoName(Id) {
    for (var i = 0; i < Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoItems.length; i++) {
        if (Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoItems[i].Clave == Id) {
            return Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoItems[i].Descripcion;
        }
    }
    return "";
}

function GetConfiguracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoDropDown() {
    var Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Configuracion_de_Planeacion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoDropdown);
    if(Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoItems != null)
    {
       for (var i = 0; i < Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoItems.length; i++) {
           $('<option />', { value: Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoItems[i].Clave, text:    Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoItems[i].Descripcion }).appendTo(Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoDropdown);
       }
    }
    return Configuracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoDropdown;
}
function GetConfiguracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoName(Id) {
    for (var i = 0; i < Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoItems.length; i++) {
        if (Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoItems[i].Clave == Id) {
            return Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoItems[i].Servicio;
        }
    }
    return "";
}

function GetConfiguracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoDropDown() {
    var Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Configuracion_de_Planeacion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoDropdown);
    if(Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoItems != null)
    {
       for (var i = 0; i < Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoItems.length; i++) {
           $('<option />', { value: Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoItems[i].Clave, text:    Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoItems[i].Servicio }).appendTo(Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoDropdown);
       }
    }
    return Configuracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoDropdown;
}





function GetInsertConfiguracion_de_PlaneacionRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetConfiguracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoDropDown()).addClass('Configuracion_de_Planeacion_Categoria Categoria').attr('id', 'Configuracion_de_Planeacion_Categoria_' + index).attr('data-field', 'Categoria').after($.parseHTML(addNew('Configuracion_de_Planeacion', 'Categoria_de_Servicio_de_Apoyo', 'Categoria', 267348)));
    columnData[1] = $(GetConfiguracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoDropDown()).addClass('Configuracion_de_Planeacion_Servicio Servicio').attr('id', 'Configuracion_de_Planeacion_Servicio_' + index).attr('data-field', 'Servicio').after($.parseHTML(addNew('Configuracion_de_Planeacion', 'Tipo_de_Servicio_de_Apoyo', 'Servicio', 267349)));
    columnData[2] = $($.parseHTML(inputData)).addClass('Configuracion_de_Planeacion_Entregable Entregable').attr('id', 'Configuracion_de_Planeacion_Entregable_' + index).attr('data-field', 'Entregable');
    columnData[3] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Configuracion_de_Planeacion_Tiempo_Estandar Tiempo_Estandar').attr('id', 'Configuracion_de_Planeacion_Tiempo_Estandar_' + index).attr('data-field', 'Tiempo_Estandar');
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Configuracion_de_Planeacion_Ponderacion Ponderacion').attr('id', 'Configuracion_de_Planeacion_Ponderacion_' + index).attr('data-field', 'Ponderacion');


    initiateUIControls();
    return columnData;
}

function Configuracion_de_PlaneacionInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRConfiguracion_de_Planeacion("Configuracion_de_Planeacion_", "_" + rowIndex)) {
    var iPage = Configuracion_de_PlaneacionTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Configuracion_de_Planeacion';
    var prevData = Configuracion_de_PlaneacionTable.fnGetData(rowIndex);
    var data = Configuracion_de_PlaneacionTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Categoria:  data.childNodes[counter++].childNodes[0].value
        ,Servicio:  data.childNodes[counter++].childNodes[0].value
        ,Entregable:  data.childNodes[counter++].childNodes[0].value
        ,Tiempo_Estandar: data.childNodes[counter++].childNodes[0].value
        ,Ponderacion: data.childNodes[counter++].childNodes[0].value

    }
    Configuracion_de_PlaneacionTable.fnUpdate(newData, rowIndex, null, true);
    Configuracion_de_PlaneacionrowCreationGrid(data, newData, rowIndex);
    Configuracion_de_PlaneacionTable.fnPageChange(iPage);
    Configuracion_de_PlaneacioncountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRConfiguracion_de_Planeacion("Configuracion_de_Planeacion_", "_" + rowIndex);
  }
}

function Configuracion_de_PlaneacionCancelRow(rowIndex) {
    var prevData = Configuracion_de_PlaneacionTable.fnGetData(rowIndex);
    var data = Configuracion_de_PlaneacionTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Configuracion_de_PlaneacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Configuracion_de_PlaneacionrowCreationGrid(data, prevData, rowIndex);
    }
	showConfiguracion_de_PlaneacionGrid(Configuracion_de_PlaneacionTable.fnGetData());
    Configuracion_de_PlaneacioncountRowsChecked--;
	initiateUIControls();
}

function GetConfiguracion_de_PlaneacionFromDataTable() {
    var Configuracion_de_PlaneacionData = [];
    var gridData = Configuracion_de_PlaneacionTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Configuracion_de_PlaneacionData.push({
                Folio: gridData[i].Folio

                ,Categoria: gridData[i].Categoria
                ,Servicio: gridData[i].Servicio
                ,Entregable: gridData[i].Entregable
                ,Tiempo_Estandar: gridData[i].Tiempo_Estandar
                ,Ponderacion: gridData[i].Ponderacion

                ,Removed: false
            });
    }

    for (i = 0; i < removedConfiguracion_de_PlaneacionData.length; i++) {
        if (removedConfiguracion_de_PlaneacionData[i] != null && removedConfiguracion_de_PlaneacionData[i].Folio > 0)
            Configuracion_de_PlaneacionData.push({
                Folio: removedConfiguracion_de_PlaneacionData[i].Folio

                ,Categoria: removedConfiguracion_de_PlaneacionData[i].Categoria
                ,Servicio: removedConfiguracion_de_PlaneacionData[i].Servicio
                ,Entregable: removedConfiguracion_de_PlaneacionData[i].Entregable
                ,Tiempo_Estandar: removedConfiguracion_de_PlaneacionData[i].Tiempo_Estandar
                ,Ponderacion: removedConfiguracion_de_PlaneacionData[i].Ponderacion

                , Removed: true
            });
    }	

    return Configuracion_de_PlaneacionData;
}

function Configuracion_de_PlaneacionEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Configuracion_de_PlaneacionTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Configuracion_de_PlaneacioncountRowsChecked++;
    var Configuracion_de_PlaneacionRowElement = "Configuracion_de_Planeacion_" + rowIndex.toString();
    var prevData = Configuracion_de_PlaneacionTable.fnGetData(rowIndexTable );
    var row = Configuracion_de_PlaneacionTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Configuracion_de_Planeacion_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Configuracion_de_PlaneacionGetUpdateRowControls(prevData, "Configuracion_de_Planeacion_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Configuracion_de_PlaneacionRowElement + "')){ Configuracion_de_PlaneacionInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Configuracion_de_PlaneacionCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Configuracion_de_PlaneacionGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Configuracion_de_PlaneacionGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setConfiguracion_de_PlaneacionValidation();
    initiateUIControls();
    $('.Configuracion_de_Planeacion' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRConfiguracion_de_Planeacion(nameOfTable, rowIndexFormed);
    }
}

function Configuracion_de_PlaneacionfnOpenAddRowPopUp() {
    var currentRowIndex = Configuracion_de_PlaneacionTable.fnGetData().length;
    Configuracion_de_PlaneacionfnClickAddRow();
    GetAddConfiguracion_de_PlaneacionPopup(currentRowIndex, 0);
}

function Configuracion_de_PlaneacionEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Configuracion_de_PlaneacionTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Configuracion_de_PlaneacionRowElement = "Configuracion_de_Planeacion_" + rowIndex.toString();
    var prevData = Configuracion_de_PlaneacionTable.fnGetData(rowIndexTable);
    GetAddConfiguracion_de_PlaneacionPopup(rowIndex, 1, prevData.Folio);

    $('#Configuracion_de_PlaneacionCategoria').val(prevData.Categoria);
    $('#Configuracion_de_PlaneacionServicio').val(prevData.Servicio);
    $('#Configuracion_de_PlaneacionEntregable').val(prevData.Entregable);
    $('#Configuracion_de_PlaneacionTiempo_Estandar').val(prevData.Tiempo_Estandar);
    $('#Configuracion_de_PlaneacionPonderacion').val(prevData.Ponderacion);

    initiateUIControls();







}

function Configuracion_de_PlaneacionAddInsertRow() {
    if (Configuracion_de_PlaneacioninsertRowCurrentIndex < 1)
    {
        Configuracion_de_PlaneacioninsertRowCurrentIndex = 1;
    }
    return {
        Folio: null,
        IsInsertRow: true

        ,Categoria: ""
        ,Servicio: ""
        ,Entregable: ""
        ,Tiempo_Estandar: ""
        ,Ponderacion: ""

    }
}

function Configuracion_de_PlaneacionfnClickAddRow() {
    Configuracion_de_PlaneacioncountRowsChecked++;
    Configuracion_de_PlaneacionTable.fnAddData(Configuracion_de_PlaneacionAddInsertRow(), true);
    Configuracion_de_PlaneacionTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Configuracion_de_PlaneacionGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Configuracion_de_PlaneacionGrid tbody tr:nth-of-type(' + (Configuracion_de_PlaneacioninsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRConfiguracion_de_Planeacion("Configuracion_de_Planeacion_", "_" + Configuracion_de_PlaneacioninsertRowCurrentIndex);
}

function Configuracion_de_PlaneacionClearGridData() {
    Configuracion_de_PlaneacionData = [];
    Configuracion_de_PlaneaciondeletedItem = [];
    Configuracion_de_PlaneacionDataMain = [];
    Configuracion_de_PlaneacionDataMainPages = [];
    Configuracion_de_PlaneacionnewItemCount = 0;
    Configuracion_de_PlaneacionmaxItemIndex = 0;
    $("#Configuracion_de_PlaneacionGrid").DataTable().clear();
    $("#Configuracion_de_PlaneacionGrid").DataTable().destroy();
}

//Used to Get Delito Information
function GetConfiguracion_de_Planeacion() {
    var form_data = new FormData();
    for (var i = 0; i < Configuracion_de_PlaneacionData.length; i++) {
        form_data.append('[' + i + '].Folio', Configuracion_de_PlaneacionData[i].Folio);

        form_data.append('[' + i + '].Categoria', Configuracion_de_PlaneacionData[i].Categoria);
        form_data.append('[' + i + '].Servicio', Configuracion_de_PlaneacionData[i].Servicio);
        form_data.append('[' + i + '].Entregable', Configuracion_de_PlaneacionData[i].Entregable);
        form_data.append('[' + i + '].Tiempo_Estandar', Configuracion_de_PlaneacionData[i].Tiempo_Estandar);
        form_data.append('[' + i + '].Ponderacion', Configuracion_de_PlaneacionData[i].Ponderacion);

        form_data.append('[' + i + '].Removed', Configuracion_de_PlaneacionData[i].Removed);
    }
    return form_data;
}
function Configuracion_de_PlaneacionInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRConfiguracion_de_Planeacion("Configuracion_de_PlaneacionTable", rowIndex)) {
    var prevData = Configuracion_de_PlaneacionTable.fnGetData(rowIndex);
    var data = Configuracion_de_PlaneacionTable.fnGetNodes(rowIndex);
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Categoria: $('#Configuracion_de_PlaneacionCategoria').val()
        ,Servicio: $('#Configuracion_de_PlaneacionServicio').val()
        ,Entregable: $('#Configuracion_de_PlaneacionEntregable').val()
        ,Tiempo_Estandar: $('#Configuracion_de_PlaneacionTiempo_Estandar').val()

        ,Ponderacion: $('#Configuracion_de_PlaneacionPonderacion').val()


    }

    Configuracion_de_PlaneacionTable.fnUpdate(newData, rowIndex, null, true);
    Configuracion_de_PlaneacionrowCreationGrid(data, newData, rowIndex);
    $('#AddConfiguracion_de_Planeacion-form').modal({ show: false });
    $('#AddConfiguracion_de_Planeacion-form').modal('hide');
    Configuracion_de_PlaneacionEditRow(rowIndex);
    Configuracion_de_PlaneacionInsertRow(rowIndex);
    //}
}
function Configuracion_de_PlaneacionRemoveAddRow(rowIndex) {
    Configuracion_de_PlaneacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Configuracion_de_Planeacion MultiRow


$(function () {
    function Configuracion_de_PlaneacioninitializeMainArray(totalCount) {
        if (Configuracion_de_PlaneacionDataMain.length != totalCount && !Configuracion_de_PlaneacionDataMainInitialized) {
            Configuracion_de_PlaneacionDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Configuracion_de_PlaneacionDataMain[i] = null;
            }
        }
    }
    function Configuracion_de_PlaneacionremoveFromMainArray() {
        for (var j = 0; j < Configuracion_de_PlaneaciondeletedItem.length; j++) {
            for (var i = 0; i < Configuracion_de_PlaneacionDataMain.length; i++) {
                if (Configuracion_de_PlaneacionDataMain[i] != null && Configuracion_de_PlaneacionDataMain[i].Id == Configuracion_de_PlaneaciondeletedItem[j]) {
                    hConfiguracion_de_PlaneacionDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Configuracion_de_PlaneacioncopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Configuracion_de_PlaneacionDataMain.length; i++) {
            data[i] = Configuracion_de_PlaneacionDataMain[i];

        }
        return data;
    }
    function Configuracion_de_PlaneaciongetNewResult() {
        var newData = copyMainConfiguracion_de_PlaneacionArray();

        for (var i = 0; i < Configuracion_de_PlaneacionData.length; i++) {
            if (Configuracion_de_PlaneacionData[i].Removed == null || Configuracion_de_PlaneacionData[i].Removed == false) {
                newData.splice(0, 0, Configuracion_de_PlaneacionData[i]);
            }
        }
        return newData;
    }
    function Configuracion_de_PlaneacionpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Configuracion_de_PlaneacionDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Configuracion_de_PlaneacionDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Delito_cmbLabelSelect").val();
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
    $('#CreateDelito')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Configuracion_de_PlaneacionClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDelito').trigger('reset');
    $('#CreateDelito').find(':input').each(function () {
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
    var $myForm = $('#CreateDelito');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Configuracion_de_PlaneacioncountRowsChecked > 0)
    {
        ShowMessagePendingRowConfiguracion_de_Planeacion();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDelito").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDelito").on('click', '#DelitoCancelar', function () {
	  if (!isPartial) {
        DelitoBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDelito").on('click', '#DelitoGuardar', function () {
		$('#DelitoGuardar').attr('disabled', true);
		$('#DelitoGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDelitoData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						DelitoBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#DelitoGuardar').removeAttr('disabled');
                        $('#DelitoGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Delito', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_DelitoItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_DelitoDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#DelitoGuardar').removeAttr('disabled');
					$('#DelitoGuardar').bind()
				}
		}
		else {
			$('#DelitoGuardar').removeAttr('disabled');
			$('#DelitoGuardar').bind()
		}
    });
	$("form#CreateDelito").on('click', '#DelitoGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDelitoData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getConfiguracion_de_PlaneacionData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Delito', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_DelitoItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_DelitoDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDelito").on('click', '#DelitoGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDelitoData(function (currentId) {
					$("#ClaveId").val("0");
	                Configuracion_de_PlaneacionClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getConfiguracion_de_PlaneacionData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Delito',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_DelitoItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_DelitoDropDown().get(0)').innerHTML);                          
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



var DelitoisdisplayBusinessPropery = false;
DelitoDisplayBusinessRuleButtons(DelitoisdisplayBusinessPropery);
function DelitoDisplayBusinessRule() {
    if (!DelitoisdisplayBusinessPropery) {
        $('#CreateDelito').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="DelitodisplayBusinessPropery"><button onclick="DelitoGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#DelitoBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.DelitodisplayBusinessPropery').remove();
    }
    DelitoDisplayBusinessRuleButtons(!DelitoisdisplayBusinessPropery);
    DelitoisdisplayBusinessPropery = (DelitoisdisplayBusinessPropery ? false : true);
}
function DelitoDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

