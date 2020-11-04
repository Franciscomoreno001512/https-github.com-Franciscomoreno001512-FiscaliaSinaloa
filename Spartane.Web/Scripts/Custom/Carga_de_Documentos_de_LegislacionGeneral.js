

//Begin Declarations for Foreigns fields for Detalle_de_Documentos_de_Legislacion MultiRow
var Detalle_de_Documentos_de_LegislacioncountRowsChecked = 0;


function GetDetalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionName(Id) {
    for (var i = 0; i < Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionItems.length; i++) {
        if (Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionItems[i].Clave == Id) {
            return Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionDropDown() {
    var Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Documentos_de_Legislacion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionDropdown);
    if(Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionItems[i].Clave, text:    Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionItems[i].Descripcion }).appendTo(Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionDropdown);
       }
    }
    return Detalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionDropdown;
}


function GetInsertDetalle_de_Documentos_de_LegislacionRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Documentos_de_Legislacion_ID_de_Dispositivo ID_de_Dispositivo').attr('id', 'Detalle_de_Documentos_de_Legislacion_ID_de_Dispositivo_' + index).attr('data-field', 'ID_de_Dispositivo');
    columnData[1] = $(GetDetalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionDropDown()).addClass('Detalle_de_Documentos_de_Legislacion_Estatus Estatus').attr('id', 'Detalle_de_Documentos_de_Legislacion_Estatus_' + index).attr('data-field', 'Estatus').after($.parseHTML(addNew('Detalle_de_Documentos_de_Legislacion', 'Estatus_Detalle_Documentos_Legislacion', 'Estatus', 265020)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_Documentos_de_LegislacionInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Documentos_de_Legislacion("Detalle_de_Documentos_de_Legislacion_", "_" + rowIndex)) {
    var iPage = Detalle_de_Documentos_de_LegislacionTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Documentos_de_Legislacion';
    var prevData = Detalle_de_Documentos_de_LegislacionTable.fnGetData(rowIndex);
    var data = Detalle_de_Documentos_de_LegislacionTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,ID_de_Dispositivo:  data.childNodes[counter++].childNodes[0].value
        ,Estatus:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Documentos_de_LegislacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Documentos_de_LegislacionrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Documentos_de_LegislacionTable.fnPageChange(iPage);
    Detalle_de_Documentos_de_LegislacioncountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Documentos_de_Legislacion("Detalle_de_Documentos_de_Legislacion_", "_" + rowIndex);
  }
}

function Detalle_de_Documentos_de_LegislacionCancelRow(rowIndex) {
    var prevData = Detalle_de_Documentos_de_LegislacionTable.fnGetData(rowIndex);
    var data = Detalle_de_Documentos_de_LegislacionTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Documentos_de_LegislacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Documentos_de_LegislacionrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Documentos_de_LegislacionGrid(Detalle_de_Documentos_de_LegislacionTable.fnGetData());
    Detalle_de_Documentos_de_LegislacioncountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Documentos_de_LegislacionFromDataTable() {
    var Detalle_de_Documentos_de_LegislacionData = [];
    var gridData = Detalle_de_Documentos_de_LegislacionTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Documentos_de_LegislacionData.push({
                Clave: gridData[i].Clave

                ,ID_de_Dispositivo: gridData[i].ID_de_Dispositivo
                ,Estatus: gridData[i].Estatus

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Documentos_de_LegislacionData.length; i++) {
        if (removedDetalle_de_Documentos_de_LegislacionData[i] != null && removedDetalle_de_Documentos_de_LegislacionData[i].Clave > 0)
            Detalle_de_Documentos_de_LegislacionData.push({
                Clave: removedDetalle_de_Documentos_de_LegislacionData[i].Clave

                ,ID_de_Dispositivo: removedDetalle_de_Documentos_de_LegislacionData[i].ID_de_Dispositivo
                ,Estatus: removedDetalle_de_Documentos_de_LegislacionData[i].Estatus

                , Removed: true
            });
    }	

    return Detalle_de_Documentos_de_LegislacionData;
}

function Detalle_de_Documentos_de_LegislacionEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Documentos_de_LegislacionTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Documentos_de_LegislacioncountRowsChecked++;
    var Detalle_de_Documentos_de_LegislacionRowElement = "Detalle_de_Documentos_de_Legislacion_" + rowIndex.toString();
    var prevData = Detalle_de_Documentos_de_LegislacionTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Documentos_de_LegislacionTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Documentos_de_Legislacion_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Documentos_de_LegislacionGetUpdateRowControls(prevData, "Detalle_de_Documentos_de_Legislacion_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Documentos_de_LegislacionRowElement + "')){ Detalle_de_Documentos_de_LegislacionInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Documentos_de_LegislacionCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Documentos_de_LegislacionGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Documentos_de_LegislacionGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Documentos_de_LegislacionValidation();
    initiateUIControls();
    $('.Detalle_de_Documentos_de_Legislacion' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Documentos_de_Legislacion(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Documentos_de_LegislacionfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Documentos_de_LegislacionTable.fnGetData().length;
    Detalle_de_Documentos_de_LegislacionfnClickAddRow();
    GetAddDetalle_de_Documentos_de_LegislacionPopup(currentRowIndex, 0);
}

function Detalle_de_Documentos_de_LegislacionEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Documentos_de_LegislacionTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Documentos_de_LegislacionRowElement = "Detalle_de_Documentos_de_Legislacion_" + rowIndex.toString();
    var prevData = Detalle_de_Documentos_de_LegislacionTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Documentos_de_LegislacionPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Documentos_de_LegislacionID_de_Dispositivo').val(prevData.ID_de_Dispositivo);
    $('#Detalle_de_Documentos_de_LegislacionEstatus').val(prevData.Estatus);

    initiateUIControls();




}

function Detalle_de_Documentos_de_LegislacionAddInsertRow() {
    if (Detalle_de_Documentos_de_LegislacioninsertRowCurrentIndex < 1)
    {
        Detalle_de_Documentos_de_LegislacioninsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,ID_de_Dispositivo: ""
        ,Estatus: ""

    }
}

function Detalle_de_Documentos_de_LegislacionfnClickAddRow() {
    Detalle_de_Documentos_de_LegislacioncountRowsChecked++;
    Detalle_de_Documentos_de_LegislacionTable.fnAddData(Detalle_de_Documentos_de_LegislacionAddInsertRow(), true);
    Detalle_de_Documentos_de_LegislacionTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Documentos_de_LegislacionGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Documentos_de_LegislacionGrid tbody tr:nth-of-type(' + (Detalle_de_Documentos_de_LegislacioninsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Documentos_de_Legislacion("Detalle_de_Documentos_de_Legislacion_", "_" + Detalle_de_Documentos_de_LegislacioninsertRowCurrentIndex);
}

function Detalle_de_Documentos_de_LegislacionClearGridData() {
    Detalle_de_Documentos_de_LegislacionData = [];
    Detalle_de_Documentos_de_LegislaciondeletedItem = [];
    Detalle_de_Documentos_de_LegislacionDataMain = [];
    Detalle_de_Documentos_de_LegislacionDataMainPages = [];
    Detalle_de_Documentos_de_LegislacionnewItemCount = 0;
    Detalle_de_Documentos_de_LegislacionmaxItemIndex = 0;
    $("#Detalle_de_Documentos_de_LegislacionGrid").DataTable().clear();
    $("#Detalle_de_Documentos_de_LegislacionGrid").DataTable().destroy();
}

//Used to Get Carga de Documentos de Legislación Information
function GetDetalle_de_Documentos_de_Legislacion() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Documentos_de_LegislacionData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Documentos_de_LegislacionData[i].Clave);

        form_data.append('[' + i + '].ID_de_Dispositivo', Detalle_de_Documentos_de_LegislacionData[i].ID_de_Dispositivo);
        form_data.append('[' + i + '].Estatus', Detalle_de_Documentos_de_LegislacionData[i].Estatus);

        form_data.append('[' + i + '].Removed', Detalle_de_Documentos_de_LegislacionData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Documentos_de_LegislacionInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Documentos_de_Legislacion("Detalle_de_Documentos_de_LegislacionTable", rowIndex)) {
    var prevData = Detalle_de_Documentos_de_LegislacionTable.fnGetData(rowIndex);
    var data = Detalle_de_Documentos_de_LegislacionTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,ID_de_Dispositivo: $('#Detalle_de_Documentos_de_LegislacionID_de_Dispositivo').val()
        ,Estatus: $('#Detalle_de_Documentos_de_LegislacionEstatus').val()

    }

    Detalle_de_Documentos_de_LegislacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Documentos_de_LegislacionrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Documentos_de_Legislacion-form').modal({ show: false });
    $('#AddDetalle_de_Documentos_de_Legislacion-form').modal('hide');
    Detalle_de_Documentos_de_LegislacionEditRow(rowIndex);
    Detalle_de_Documentos_de_LegislacionInsertRow(rowIndex);
    //}
}
function Detalle_de_Documentos_de_LegislacionRemoveAddRow(rowIndex) {
    Detalle_de_Documentos_de_LegislacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Documentos_de_Legislacion MultiRow


$(function () {
    function Detalle_de_Documentos_de_LegislacioninitializeMainArray(totalCount) {
        if (Detalle_de_Documentos_de_LegislacionDataMain.length != totalCount && !Detalle_de_Documentos_de_LegislacionDataMainInitialized) {
            Detalle_de_Documentos_de_LegislacionDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Documentos_de_LegislacionDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Documentos_de_LegislacionremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Documentos_de_LegislaciondeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Documentos_de_LegislacionDataMain.length; i++) {
                if (Detalle_de_Documentos_de_LegislacionDataMain[i] != null && Detalle_de_Documentos_de_LegislacionDataMain[i].Id == Detalle_de_Documentos_de_LegislaciondeletedItem[j]) {
                    hDetalle_de_Documentos_de_LegislacionDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Documentos_de_LegislacioncopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Documentos_de_LegislacionDataMain.length; i++) {
            data[i] = Detalle_de_Documentos_de_LegislacionDataMain[i];

        }
        return data;
    }
    function Detalle_de_Documentos_de_LegislaciongetNewResult() {
        var newData = copyMainDetalle_de_Documentos_de_LegislacionArray();

        for (var i = 0; i < Detalle_de_Documentos_de_LegislacionData.length; i++) {
            if (Detalle_de_Documentos_de_LegislacionData[i].Removed == null || Detalle_de_Documentos_de_LegislacionData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Documentos_de_LegislacionData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Documentos_de_LegislacionpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Documentos_de_LegislacionDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Documentos_de_LegislacionDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Carga_de_Documentos_de_Legislacion_cmbLabelSelect").val();
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
    $('#CreateCarga_de_Documentos_de_Legislacion')[0].reset();
    ClearFormControls();
    $("#FolioId").val("0");
                Detalle_de_Documentos_de_LegislacionClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateCarga_de_Documentos_de_Legislacion').trigger('reset');
    $('#CreateCarga_de_Documentos_de_Legislacion').find(':input').each(function () {
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
    var $myForm = $('#CreateCarga_de_Documentos_de_Legislacion');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Documentos_de_LegislacioncountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Documentos_de_Legislacion();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblFolio").text("0");
}
$(document).ready(function () {
    $("form#CreateCarga_de_Documentos_de_Legislacion").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateCarga_de_Documentos_de_Legislacion").on('click', '#Carga_de_Documentos_de_LegislacionCancelar', function () {
	  if (!isPartial) {
        Carga_de_Documentos_de_LegislacionBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateCarga_de_Documentos_de_Legislacion").on('click', '#Carga_de_Documentos_de_LegislacionGuardar', function () {
		$('#Carga_de_Documentos_de_LegislacionGuardar').attr('disabled', true);
		$('#Carga_de_Documentos_de_LegislacionGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendCarga_de_Documentos_de_LegislacionData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Carga_de_Documentos_de_LegislacionBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Carga_de_Documentos_de_LegislacionGuardar').removeAttr('disabled');
                        $('#Carga_de_Documentos_de_LegislacionGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Carga_de_Documentos_de_Legislacion', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Carga_de_Documentos_de_LegislacionItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Carga_de_Documentos_de_LegislacionDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Carga_de_Documentos_de_LegislacionGuardar').removeAttr('disabled');
					$('#Carga_de_Documentos_de_LegislacionGuardar').bind()
				}
		}
		else {
			$('#Carga_de_Documentos_de_LegislacionGuardar').removeAttr('disabled');
			$('#Carga_de_Documentos_de_LegislacionGuardar').bind()
		}
    });
	$("form#CreateCarga_de_Documentos_de_Legislacion").on('click', '#Carga_de_Documentos_de_LegislacionGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendCarga_de_Documentos_de_LegislacionData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Documentos_de_LegislacionData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Carga_de_Documentos_de_Legislacion', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Carga_de_Documentos_de_LegislacionItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Carga_de_Documentos_de_LegislacionDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateCarga_de_Documentos_de_Legislacion").on('click', '#Carga_de_Documentos_de_LegislacionGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendCarga_de_Documentos_de_LegislacionData(function (currentId) {
					$("#FolioId").val("0");
	                Detalle_de_Documentos_de_LegislacionClearGridData();

					ResetClaveLabel();
					$("#ReferenceFolio").val(currentId);
	                getDetalle_de_Documentos_de_LegislacionData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Carga_de_Documentos_de_Legislacion',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Carga_de_Documentos_de_LegislacionItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Carga_de_Documentos_de_LegislacionDropDown().get(0)').innerHTML);                          
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



var Carga_de_Documentos_de_LegislacionisdisplayBusinessPropery = false;
Carga_de_Documentos_de_LegislacionDisplayBusinessRuleButtons(Carga_de_Documentos_de_LegislacionisdisplayBusinessPropery);
function Carga_de_Documentos_de_LegislacionDisplayBusinessRule() {
    if (!Carga_de_Documentos_de_LegislacionisdisplayBusinessPropery) {
        $('#CreateCarga_de_Documentos_de_Legislacion').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Carga_de_Documentos_de_LegislaciondisplayBusinessPropery"><button onclick="Carga_de_Documentos_de_LegislacionGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Carga_de_Documentos_de_LegislacionBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Carga_de_Documentos_de_LegislaciondisplayBusinessPropery').remove();
    }
    Carga_de_Documentos_de_LegislacionDisplayBusinessRuleButtons(!Carga_de_Documentos_de_LegislacionisdisplayBusinessPropery);
    Carga_de_Documentos_de_LegislacionisdisplayBusinessPropery = (Carga_de_Documentos_de_LegislacionisdisplayBusinessPropery ? false : true);
}
function Carga_de_Documentos_de_LegislacionDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

