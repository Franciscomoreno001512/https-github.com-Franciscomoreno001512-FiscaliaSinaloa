

//Begin Declarations for Foreigns fields for Detalle_Medidas_Proteccion MultiRow
var Detalle_Medidas_ProteccioncountRowsChecked = 0;


function GetDetalle_Medidas_Proteccion_Medida_de_ProteccionName(Id) {
    for (var i = 0; i < Detalle_Medidas_Proteccion_Medida_de_ProteccionItems.length; i++) {
        if (Detalle_Medidas_Proteccion_Medida_de_ProteccionItems[i].Clave == Id) {
            return Detalle_Medidas_Proteccion_Medida_de_ProteccionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Medidas_Proteccion_Medida_de_ProteccionDropDown() {
    var Detalle_Medidas_Proteccion_Medida_de_ProteccionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Medidas_Proteccion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Medidas_Proteccion_Medida_de_ProteccionDropdown);
    if(Detalle_Medidas_Proteccion_Medida_de_ProteccionItems != null)
    {
       for (var i = 0; i < Detalle_Medidas_Proteccion_Medida_de_ProteccionItems.length; i++) {
           $('<option />', { value: Detalle_Medidas_Proteccion_Medida_de_ProteccionItems[i].Clave, text:    Detalle_Medidas_Proteccion_Medida_de_ProteccionItems[i].Descripcion }).appendTo(Detalle_Medidas_Proteccion_Medida_de_ProteccionDropdown);
       }
    }
    return Detalle_Medidas_Proteccion_Medida_de_ProteccionDropdown;
}


function GetInsertDetalle_Medidas_ProteccionRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Medidas_Proteccion_Seleccionar Seleccionar').attr('id', 'Detalle_Medidas_Proteccion_Seleccionar_' + index).attr('data-field', 'Seleccionar');
    columnData[1] = $(GetDetalle_Medidas_Proteccion_Medida_de_ProteccionDropDown()).addClass('Detalle_Medidas_Proteccion_Medida Medida').attr('id', 'Detalle_Medidas_Proteccion_Medida_' + index).attr('data-field', 'Medida').after($.parseHTML(addNew('Detalle_Medidas_Proteccion', 'Medida_de_Proteccion', 'Medida', 268472)));


    initiateUIControls();
    return columnData;
}

function Detalle_Medidas_ProteccionInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Medidas_Proteccion("Detalle_Medidas_Proteccion_", "_" + rowIndex)) {
    var iPage = Detalle_Medidas_ProteccionTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Medidas_Proteccion';
    var prevData = Detalle_Medidas_ProteccionTable.fnGetData(rowIndex);
    var data = Detalle_Medidas_ProteccionTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Seleccionar: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Medida:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Medidas_ProteccionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Medidas_ProteccionrowCreationGrid(data, newData, rowIndex);
    Detalle_Medidas_ProteccionTable.fnPageChange(iPage);
    Detalle_Medidas_ProteccioncountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Medidas_Proteccion("Detalle_Medidas_Proteccion_", "_" + rowIndex);
  }
}

function Detalle_Medidas_ProteccionCancelRow(rowIndex) {
    var prevData = Detalle_Medidas_ProteccionTable.fnGetData(rowIndex);
    var data = Detalle_Medidas_ProteccionTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Medidas_ProteccionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Medidas_ProteccionrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Medidas_ProteccionGrid(Detalle_Medidas_ProteccionTable.fnGetData());
    Detalle_Medidas_ProteccioncountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Medidas_ProteccionFromDataTable() {
    var Detalle_Medidas_ProteccionData = [];
    var gridData = Detalle_Medidas_ProteccionTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Medidas_ProteccionData.push({
                Clave: gridData[i].Clave

                ,Seleccionar: gridData[i].Seleccionar
                ,Medida: gridData[i].Medida

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Medidas_ProteccionData.length; i++) {
        if (removedDetalle_Medidas_ProteccionData[i] != null && removedDetalle_Medidas_ProteccionData[i].Clave > 0)
            Detalle_Medidas_ProteccionData.push({
                Clave: removedDetalle_Medidas_ProteccionData[i].Clave

                ,Seleccionar: removedDetalle_Medidas_ProteccionData[i].Seleccionar
                ,Medida: removedDetalle_Medidas_ProteccionData[i].Medida

                , Removed: true
            });
    }	

    return Detalle_Medidas_ProteccionData;
}

function Detalle_Medidas_ProteccionEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Medidas_ProteccionTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Medidas_ProteccioncountRowsChecked++;
    var Detalle_Medidas_ProteccionRowElement = "Detalle_Medidas_Proteccion_" + rowIndex.toString();
    var prevData = Detalle_Medidas_ProteccionTable.fnGetData(rowIndexTable );
    var row = Detalle_Medidas_ProteccionTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Medidas_Proteccion_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Medidas_ProteccionGetUpdateRowControls(prevData, "Detalle_Medidas_Proteccion_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Medidas_ProteccionRowElement + "')){ Detalle_Medidas_ProteccionInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Medidas_ProteccionCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Medidas_ProteccionGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Medidas_ProteccionGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Medidas_ProteccionValidation();
    initiateUIControls();
    $('.Detalle_Medidas_Proteccion' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Medidas_Proteccion(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Medidas_ProteccionfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Medidas_ProteccionTable.fnGetData().length;
    Detalle_Medidas_ProteccionfnClickAddRow();
    GetAddDetalle_Medidas_ProteccionPopup(currentRowIndex, 0);
}

function Detalle_Medidas_ProteccionEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Medidas_ProteccionTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Medidas_ProteccionRowElement = "Detalle_Medidas_Proteccion_" + rowIndex.toString();
    var prevData = Detalle_Medidas_ProteccionTable.fnGetData(rowIndexTable);
    GetAddDetalle_Medidas_ProteccionPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Medidas_ProteccionSeleccionar').prop('checked', prevData.Seleccionar);
    $('#Detalle_Medidas_ProteccionMedida').val(prevData.Medida);

    initiateUIControls();




}

function Detalle_Medidas_ProteccionAddInsertRow() {
    if (Detalle_Medidas_ProteccioninsertRowCurrentIndex < 1)
    {
        Detalle_Medidas_ProteccioninsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Seleccionar: ""
        ,Medida: ""

    }
}

function Detalle_Medidas_ProteccionfnClickAddRow() {
    Detalle_Medidas_ProteccioncountRowsChecked++;
    Detalle_Medidas_ProteccionTable.fnAddData(Detalle_Medidas_ProteccionAddInsertRow(), true);
    Detalle_Medidas_ProteccionTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Medidas_ProteccionGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Medidas_ProteccionGrid tbody tr:nth-of-type(' + (Detalle_Medidas_ProteccioninsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Medidas_Proteccion("Detalle_Medidas_Proteccion_", "_" + Detalle_Medidas_ProteccioninsertRowCurrentIndex);
}

function Detalle_Medidas_ProteccionClearGridData() {
    Detalle_Medidas_ProteccionData = [];
    Detalle_Medidas_ProtecciondeletedItem = [];
    Detalle_Medidas_ProteccionDataMain = [];
    Detalle_Medidas_ProteccionDataMainPages = [];
    Detalle_Medidas_ProteccionnewItemCount = 0;
    Detalle_Medidas_ProteccionmaxItemIndex = 0;
    $("#Detalle_Medidas_ProteccionGrid").DataTable().clear();
    $("#Detalle_Medidas_ProteccionGrid").DataTable().destroy();
}

//Used to Get Medidas de Protección Information
function GetDetalle_Medidas_Proteccion() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Medidas_ProteccionData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Medidas_ProteccionData[i].Clave);

        form_data.append('[' + i + '].Seleccionar', Detalle_Medidas_ProteccionData[i].Seleccionar);
        form_data.append('[' + i + '].Medida', Detalle_Medidas_ProteccionData[i].Medida);

        form_data.append('[' + i + '].Removed', Detalle_Medidas_ProteccionData[i].Removed);
    }
    return form_data;
}
function Detalle_Medidas_ProteccionInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Medidas_Proteccion("Detalle_Medidas_ProteccionTable", rowIndex)) {
    var prevData = Detalle_Medidas_ProteccionTable.fnGetData(rowIndex);
    var data = Detalle_Medidas_ProteccionTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Seleccionar: $('#Detalle_Medidas_ProteccionSeleccionar').is(':checked')
        ,Medida: $('#Detalle_Medidas_ProteccionMedida').val()

    }

    Detalle_Medidas_ProteccionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Medidas_ProteccionrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Medidas_Proteccion-form').modal({ show: false });
    $('#AddDetalle_Medidas_Proteccion-form').modal('hide');
    Detalle_Medidas_ProteccionEditRow(rowIndex);
    Detalle_Medidas_ProteccionInsertRow(rowIndex);
    //}
}
function Detalle_Medidas_ProteccionRemoveAddRow(rowIndex) {
    Detalle_Medidas_ProteccionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Medidas_Proteccion MultiRow


$(function () {
    function Detalle_Medidas_ProteccioninitializeMainArray(totalCount) {
        if (Detalle_Medidas_ProteccionDataMain.length != totalCount && !Detalle_Medidas_ProteccionDataMainInitialized) {
            Detalle_Medidas_ProteccionDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Medidas_ProteccionDataMain[i] = null;
            }
        }
    }
    function Detalle_Medidas_ProteccionremoveFromMainArray() {
        for (var j = 0; j < Detalle_Medidas_ProtecciondeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Medidas_ProteccionDataMain.length; i++) {
                if (Detalle_Medidas_ProteccionDataMain[i] != null && Detalle_Medidas_ProteccionDataMain[i].Id == Detalle_Medidas_ProtecciondeletedItem[j]) {
                    hDetalle_Medidas_ProteccionDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Medidas_ProteccioncopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Medidas_ProteccionDataMain.length; i++) {
            data[i] = Detalle_Medidas_ProteccionDataMain[i];

        }
        return data;
    }
    function Detalle_Medidas_ProtecciongetNewResult() {
        var newData = copyMainDetalle_Medidas_ProteccionArray();

        for (var i = 0; i < Detalle_Medidas_ProteccionData.length; i++) {
            if (Detalle_Medidas_ProteccionData[i].Removed == null || Detalle_Medidas_ProteccionData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Medidas_ProteccionData[i]);
            }
        }
        return newData;
    }
    function Detalle_Medidas_ProteccionpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Medidas_ProteccionDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Medidas_ProteccionDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteExpediente_ATData = [];
function GetAutoCompleteMedidas_de_Proteccion_Expediente_AT_Modulo_Atencion_InicialData(data) {
	AutoCompleteExpediente_ATData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_ATData.push({
            id: data[i].Clave,
            text: data[i].NUAT
        });
    }
    return AutoCompleteExpediente_ATData;
}
var AutoCompleteExpediente_MASCData = [];
function GetAutoCompleteMedidas_de_Proteccion_Expediente_MASC_SolicitudData(data) {
	AutoCompleteExpediente_MASCData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MASCData.push({
            id: data[i].Clave,
            text: data[i].Numero_de_Folio
        });
    }
    return AutoCompleteExpediente_MASCData;
}
var AutoCompleteExpediente_MPData = [];
function GetAutoCompleteMedidas_de_Proteccion_Expediente_MP_expediente_ministerio_publicoData(data) {
	AutoCompleteExpediente_MPData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MPData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteExpediente_MPData;
}
var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompleteMedidas_de_Proteccion_Usuario_que_Registra_Spartan_UserData(data) {
	AutoCompleteUsuario_que_RegistraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_RegistraData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_RegistraData;
}
//Grid GetAutocomplete

var AutoCompleteAplicar_aData = [];
function GetAutoCompleteMedidas_de_Proteccion_Aplicar_a_Detalle_de_RelacionesData(data) {
	AutoCompleteAplicar_aData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteAplicar_aData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteAplicar_aData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#Medidas_de_Proteccion_cmbLabelSelect").val();
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
    $('#CreateMedidas_de_Proteccion')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Expediente_AT').empty();
    $("#Expediente_AT").append('<option value=""></option>');
    $('#Expediente_AT').val('0').trigger('change');
    $('#Expediente_MASC').empty();
    $("#Expediente_MASC").append('<option value=""></option>');
    $('#Expediente_MASC').val('0').trigger('change');
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_Medidas_ProteccionClearGridData();
    $('#Aplicar_a').empty();
    $("#Aplicar_a").append('<option value=""></option>');
    $('#Aplicar_a').val('0').trigger('change');

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateMedidas_de_Proteccion').trigger('reset');
    $('#CreateMedidas_de_Proteccion').find(':input').each(function () {
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
    var $myForm = $('#CreateMedidas_de_Proteccion');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Medidas_ProteccioncountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Medidas_Proteccion();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateMedidas_de_Proteccion").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateMedidas_de_Proteccion").on('click', '#Medidas_de_ProteccionCancelar', function () {
	  if (!isPartial) {
        Medidas_de_ProteccionBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateMedidas_de_Proteccion").on('click', '#Medidas_de_ProteccionGuardar', function () {
		$('#Medidas_de_ProteccionGuardar').attr('disabled', true);
		$('#Medidas_de_ProteccionGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendMedidas_de_ProteccionData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Medidas_de_ProteccionBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Medidas_de_ProteccionGuardar').removeAttr('disabled');
                        $('#Medidas_de_ProteccionGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Medidas_de_Proteccion', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Medidas_de_ProteccionItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Medidas_de_ProteccionDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Medidas_de_ProteccionGuardar').removeAttr('disabled');
					$('#Medidas_de_ProteccionGuardar').bind()
				}
		}
		else {
			$('#Medidas_de_ProteccionGuardar').removeAttr('disabled');
			$('#Medidas_de_ProteccionGuardar').bind()
		}
    });
	$("form#CreateMedidas_de_Proteccion").on('click', '#Medidas_de_ProteccionGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendMedidas_de_ProteccionData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Medidas_ProteccionData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Medidas_de_Proteccion', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Medidas_de_ProteccionItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Medidas_de_ProteccionDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateMedidas_de_Proteccion").on('click', '#Medidas_de_ProteccionGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendMedidas_de_ProteccionData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Expediente_AT').empty();
    $("#Expediente_AT").append('<option value=""></option>');
    $('#Expediente_AT').val('0').trigger('change');
    $('#Expediente_MASC').empty();
    $("#Expediente_MASC").append('<option value=""></option>');
    $('#Expediente_MASC').val('0').trigger('change');
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_Medidas_ProteccionClearGridData();
    $('#Aplicar_a').empty();
    $("#Aplicar_a").append('<option value=""></option>');
    $('#Aplicar_a').val('0').trigger('change');

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Medidas_ProteccionData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Medidas_de_Proteccion',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Medidas_de_ProteccionItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Medidas_de_ProteccionDropDown().get(0)').innerHTML);                          
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



var Medidas_de_ProteccionisdisplayBusinessPropery = false;
Medidas_de_ProteccionDisplayBusinessRuleButtons(Medidas_de_ProteccionisdisplayBusinessPropery);
function Medidas_de_ProteccionDisplayBusinessRule() {
    if (!Medidas_de_ProteccionisdisplayBusinessPropery) {
        $('#CreateMedidas_de_Proteccion').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Medidas_de_ProtecciondisplayBusinessPropery"><button onclick="Medidas_de_ProteccionGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Medidas_de_ProteccionBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Medidas_de_ProtecciondisplayBusinessPropery').remove();
    }
    Medidas_de_ProteccionDisplayBusinessRuleButtons(!Medidas_de_ProteccionisdisplayBusinessPropery);
    Medidas_de_ProteccionisdisplayBusinessPropery = (Medidas_de_ProteccionisdisplayBusinessPropery ? false : true);
}
function Medidas_de_ProteccionDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

