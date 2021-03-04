

//Begin Declarations for Foreigns fields for Detalle_subareas_responsable_servicio_apoyo MultiRow
var Detalle_subareas_responsable_servicio_apoyocountRowsChecked = 0;

function GetDetalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoName(Id) {
    for (var i = 0; i < Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoItems.length; i++) {
        if (Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoItems[i].Clave == Id) {
            return Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoDropDown() {
    var Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_subareas_responsable_servicio_apoyo_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoDropdown);
    if(Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoItems != null)
    {
       for (var i = 0; i < Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoItems.length; i++) {
           $('<option />', { value: Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoItems[i].Clave, text:    Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoItems[i].Descripcion }).appendTo(Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoDropdown);
       }
    }
    return Detalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoDropdown;
}


function GetInsertDetalle_subareas_responsable_servicio_apoyoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoDropDown()).addClass('Detalle_subareas_responsable_servicio_apoyo_SubArea_Asignada SubArea_Asignada').attr('id', 'Detalle_subareas_responsable_servicio_apoyo_SubArea_Asignada_' + index).attr('data-field', 'SubArea_Asignada').after($.parseHTML(addNew('Detalle_subareas_responsable_servicio_apoyo', 'SubArea_de_Servicios_de_Apoyo', 'SubArea_Asignada', 273109)));


    initiateUIControls();
    return columnData;
}

function Detalle_subareas_responsable_servicio_apoyoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_subareas_responsable_servicio_apoyo("Detalle_subareas_responsable_servicio_apoyo_", "_" + rowIndex)) {
    var iPage = Detalle_subareas_responsable_servicio_apoyoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_subareas_responsable_servicio_apoyo';
    var prevData = Detalle_subareas_responsable_servicio_apoyoTable.fnGetData(rowIndex);
    var data = Detalle_subareas_responsable_servicio_apoyoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,SubArea_Asignada:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_subareas_responsable_servicio_apoyoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_subareas_responsable_servicio_apoyorowCreationGrid(data, newData, rowIndex);
    Detalle_subareas_responsable_servicio_apoyoTable.fnPageChange(iPage);
    Detalle_subareas_responsable_servicio_apoyocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_subareas_responsable_servicio_apoyo("Detalle_subareas_responsable_servicio_apoyo_", "_" + rowIndex);
  }
}

function Detalle_subareas_responsable_servicio_apoyoCancelRow(rowIndex) {
    var prevData = Detalle_subareas_responsable_servicio_apoyoTable.fnGetData(rowIndex);
    var data = Detalle_subareas_responsable_servicio_apoyoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_subareas_responsable_servicio_apoyoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_subareas_responsable_servicio_apoyorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_subareas_responsable_servicio_apoyoGrid(Detalle_subareas_responsable_servicio_apoyoTable.fnGetData());
    Detalle_subareas_responsable_servicio_apoyocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_subareas_responsable_servicio_apoyoFromDataTable() {
    var Detalle_subareas_responsable_servicio_apoyoData = [];
    var gridData = Detalle_subareas_responsable_servicio_apoyoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_subareas_responsable_servicio_apoyoData.push({
                Clave: gridData[i].Clave

                ,SubArea_Asignada: gridData[i].SubArea_Asignada

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_subareas_responsable_servicio_apoyoData.length; i++) {
        if (removedDetalle_subareas_responsable_servicio_apoyoData[i] != null && removedDetalle_subareas_responsable_servicio_apoyoData[i].Clave > 0)
            Detalle_subareas_responsable_servicio_apoyoData.push({
                Clave: removedDetalle_subareas_responsable_servicio_apoyoData[i].Clave

                ,SubArea_Asignada: removedDetalle_subareas_responsable_servicio_apoyoData[i].SubArea_Asignada

                , Removed: true
            });
    }	

    return Detalle_subareas_responsable_servicio_apoyoData;
}

function Detalle_subareas_responsable_servicio_apoyoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_subareas_responsable_servicio_apoyoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_subareas_responsable_servicio_apoyocountRowsChecked++;
    var Detalle_subareas_responsable_servicio_apoyoRowElement = "Detalle_subareas_responsable_servicio_apoyo_" + rowIndex.toString();
    var prevData = Detalle_subareas_responsable_servicio_apoyoTable.fnGetData(rowIndexTable );
    var row = Detalle_subareas_responsable_servicio_apoyoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_subareas_responsable_servicio_apoyo_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_subareas_responsable_servicio_apoyoGetUpdateRowControls(prevData, "Detalle_subareas_responsable_servicio_apoyo_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_subareas_responsable_servicio_apoyoRowElement + "')){ Detalle_subareas_responsable_servicio_apoyoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_subareas_responsable_servicio_apoyoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_subareas_responsable_servicio_apoyoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_subareas_responsable_servicio_apoyoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_subareas_responsable_servicio_apoyoValidation();
    initiateUIControls();
    $('.Detalle_subareas_responsable_servicio_apoyo' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndexFormed);
    }
}

function Detalle_subareas_responsable_servicio_apoyofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_subareas_responsable_servicio_apoyoTable.fnGetData().length;
    Detalle_subareas_responsable_servicio_apoyofnClickAddRow();
    GetAddDetalle_subareas_responsable_servicio_apoyoPopup(currentRowIndex, 0);
}

function Detalle_subareas_responsable_servicio_apoyoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_subareas_responsable_servicio_apoyoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_subareas_responsable_servicio_apoyoRowElement = "Detalle_subareas_responsable_servicio_apoyo_" + rowIndex.toString();
    var prevData = Detalle_subareas_responsable_servicio_apoyoTable.fnGetData(rowIndexTable);
    GetAddDetalle_subareas_responsable_servicio_apoyoPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_subareas_responsable_servicio_apoyoSubArea_Asignada').val(prevData.SubArea_Asignada);

    initiateUIControls();



}

function Detalle_subareas_responsable_servicio_apoyoAddInsertRow() {
    if (Detalle_subareas_responsable_servicio_apoyoinsertRowCurrentIndex < 1)
    {
        Detalle_subareas_responsable_servicio_apoyoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,SubArea_Asignada: ""

    }
}

function Detalle_subareas_responsable_servicio_apoyofnClickAddRow() {
    Detalle_subareas_responsable_servicio_apoyocountRowsChecked++;
    Detalle_subareas_responsable_servicio_apoyoTable.fnAddData(Detalle_subareas_responsable_servicio_apoyoAddInsertRow(), true);
    Detalle_subareas_responsable_servicio_apoyoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_subareas_responsable_servicio_apoyoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_subareas_responsable_servicio_apoyoGrid tbody tr:nth-of-type(' + (Detalle_subareas_responsable_servicio_apoyoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_subareas_responsable_servicio_apoyo("Detalle_subareas_responsable_servicio_apoyo_", "_" + Detalle_subareas_responsable_servicio_apoyoinsertRowCurrentIndex);
}

function Detalle_subareas_responsable_servicio_apoyoClearGridData() {
    Detalle_subareas_responsable_servicio_apoyoData = [];
    Detalle_subareas_responsable_servicio_apoyodeletedItem = [];
    Detalle_subareas_responsable_servicio_apoyoDataMain = [];
    Detalle_subareas_responsable_servicio_apoyoDataMainPages = [];
    Detalle_subareas_responsable_servicio_apoyonewItemCount = 0;
    Detalle_subareas_responsable_servicio_apoyomaxItemIndex = 0;
    $("#Detalle_subareas_responsable_servicio_apoyoGrid").DataTable().clear();
    $("#Detalle_subareas_responsable_servicio_apoyoGrid").DataTable().destroy();
}

//Used to Get Asignación de Responsable de Servicios de Apoyo Information
function GetDetalle_subareas_responsable_servicio_apoyo() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_subareas_responsable_servicio_apoyoData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_subareas_responsable_servicio_apoyoData[i].Clave);

        form_data.append('[' + i + '].SubArea_Asignada', Detalle_subareas_responsable_servicio_apoyoData[i].SubArea_Asignada);

        form_data.append('[' + i + '].Removed', Detalle_subareas_responsable_servicio_apoyoData[i].Removed);
    }
    return form_data;
}
function Detalle_subareas_responsable_servicio_apoyoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_subareas_responsable_servicio_apoyo("Detalle_subareas_responsable_servicio_apoyoTable", rowIndex)) {
    var prevData = Detalle_subareas_responsable_servicio_apoyoTable.fnGetData(rowIndex);
    var data = Detalle_subareas_responsable_servicio_apoyoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,SubArea_Asignada: $('#Detalle_subareas_responsable_servicio_apoyoSubArea_Asignada').val()

    }

    Detalle_subareas_responsable_servicio_apoyoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_subareas_responsable_servicio_apoyorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_subareas_responsable_servicio_apoyo-form').modal({ show: false });
    $('#AddDetalle_subareas_responsable_servicio_apoyo-form').modal('hide');
    Detalle_subareas_responsable_servicio_apoyoEditRow(rowIndex);
    Detalle_subareas_responsable_servicio_apoyoInsertRow(rowIndex);
    //}
}
function Detalle_subareas_responsable_servicio_apoyoRemoveAddRow(rowIndex) {
    Detalle_subareas_responsable_servicio_apoyoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_subareas_responsable_servicio_apoyo MultiRow


$(function () {
    function Detalle_subareas_responsable_servicio_apoyoinitializeMainArray(totalCount) {
        if (Detalle_subareas_responsable_servicio_apoyoDataMain.length != totalCount && !Detalle_subareas_responsable_servicio_apoyoDataMainInitialized) {
            Detalle_subareas_responsable_servicio_apoyoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_subareas_responsable_servicio_apoyoDataMain[i] = null;
            }
        }
    }
    function Detalle_subareas_responsable_servicio_apoyoremoveFromMainArray() {
        for (var j = 0; j < Detalle_subareas_responsable_servicio_apoyodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_subareas_responsable_servicio_apoyoDataMain.length; i++) {
                if (Detalle_subareas_responsable_servicio_apoyoDataMain[i] != null && Detalle_subareas_responsable_servicio_apoyoDataMain[i].Id == Detalle_subareas_responsable_servicio_apoyodeletedItem[j]) {
                    hDetalle_subareas_responsable_servicio_apoyoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_subareas_responsable_servicio_apoyocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_subareas_responsable_servicio_apoyoDataMain.length; i++) {
            data[i] = Detalle_subareas_responsable_servicio_apoyoDataMain[i];

        }
        return data;
    }
    function Detalle_subareas_responsable_servicio_apoyogetNewResult() {
        var newData = copyMainDetalle_subareas_responsable_servicio_apoyoArray();

        for (var i = 0; i < Detalle_subareas_responsable_servicio_apoyoData.length; i++) {
            if (Detalle_subareas_responsable_servicio_apoyoData[i].Removed == null || Detalle_subareas_responsable_servicio_apoyoData[i].Removed == false) {
                newData.splice(0, 0, Detalle_subareas_responsable_servicio_apoyoData[i]);
            }
        }
        return newData;
    }
    function Detalle_subareas_responsable_servicio_apoyopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_subareas_responsable_servicio_apoyoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_subareas_responsable_servicio_apoyoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteUsuarioData = [];
function GetAutoCompleteAsignacion_responsable_servicios_apoyo_Usuario_Spartan_UserData(data) {
	AutoCompleteUsuarioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuarioData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuarioData;
}
//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Asignacion_responsable_servicios_apoyo_cmbLabelSelect").val();
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
    $('#CreateAsignacion_responsable_servicios_apoyo')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Usuario').empty();
    $("#Usuario").append('<option value=""></option>');
    $('#Usuario').val('0').trigger('change');
                Detalle_subareas_responsable_servicio_apoyoClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateAsignacion_responsable_servicios_apoyo').trigger('reset');
    $('#CreateAsignacion_responsable_servicios_apoyo').find(':input').each(function () {
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
    var $myForm = $('#CreateAsignacion_responsable_servicios_apoyo');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_subareas_responsable_servicio_apoyocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_subareas_responsable_servicio_apoyo();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateAsignacion_responsable_servicios_apoyo").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateAsignacion_responsable_servicios_apoyo").on('click', '#Asignacion_responsable_servicios_apoyoCancelar', function () {
	  if (!isPartial) {
        Asignacion_responsable_servicios_apoyoBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateAsignacion_responsable_servicios_apoyo").on('click', '#Asignacion_responsable_servicios_apoyoGuardar', function () {
		$('#Asignacion_responsable_servicios_apoyoGuardar').attr('disabled', true);
		$('#Asignacion_responsable_servicios_apoyoGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendAsignacion_responsable_servicios_apoyoData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Asignacion_responsable_servicios_apoyoBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Asignacion_responsable_servicios_apoyoGuardar').removeAttr('disabled');
                        $('#Asignacion_responsable_servicios_apoyoGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Asignacion_responsable_servicios_apoyo', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Asignacion_responsable_servicios_apoyoItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Asignacion_responsable_servicios_apoyoDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Asignacion_responsable_servicios_apoyoGuardar').removeAttr('disabled');
					$('#Asignacion_responsable_servicios_apoyoGuardar').bind()
				}
		}
		else {
			$('#Asignacion_responsable_servicios_apoyoGuardar').removeAttr('disabled');
			$('#Asignacion_responsable_servicios_apoyoGuardar').bind()
		}
    });
	$("form#CreateAsignacion_responsable_servicios_apoyo").on('click', '#Asignacion_responsable_servicios_apoyoGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendAsignacion_responsable_servicios_apoyoData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_subareas_responsable_servicio_apoyoData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Asignacion_responsable_servicios_apoyo', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Asignacion_responsable_servicios_apoyoItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Asignacion_responsable_servicios_apoyoDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateAsignacion_responsable_servicios_apoyo").on('click', '#Asignacion_responsable_servicios_apoyoGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendAsignacion_responsable_servicios_apoyoData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Usuario').empty();
    $("#Usuario").append('<option value=""></option>');
    $('#Usuario').val('0').trigger('change');
                Detalle_subareas_responsable_servicio_apoyoClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_subareas_responsable_servicio_apoyoData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Asignacion_responsable_servicios_apoyo',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Asignacion_responsable_servicios_apoyoItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Asignacion_responsable_servicios_apoyoDropDown().get(0)').innerHTML);                          
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



var Asignacion_responsable_servicios_apoyoisdisplayBusinessPropery = false;
Asignacion_responsable_servicios_apoyoDisplayBusinessRuleButtons(Asignacion_responsable_servicios_apoyoisdisplayBusinessPropery);
function Asignacion_responsable_servicios_apoyoDisplayBusinessRule() {
    if (!Asignacion_responsable_servicios_apoyoisdisplayBusinessPropery) {
        $('#CreateAsignacion_responsable_servicios_apoyo').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Asignacion_responsable_servicios_apoyodisplayBusinessPropery"><button onclick="Asignacion_responsable_servicios_apoyoGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Asignacion_responsable_servicios_apoyoBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Asignacion_responsable_servicios_apoyodisplayBusinessPropery').remove();
    }
    Asignacion_responsable_servicios_apoyoDisplayBusinessRuleButtons(!Asignacion_responsable_servicios_apoyoisdisplayBusinessPropery);
    Asignacion_responsable_servicios_apoyoisdisplayBusinessPropery = (Asignacion_responsable_servicios_apoyoisdisplayBusinessPropery ? false : true);
}
function Asignacion_responsable_servicios_apoyoDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

