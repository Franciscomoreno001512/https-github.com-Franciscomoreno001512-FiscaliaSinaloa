

//Begin Declarations for Foreigns fields for Detalle_Relaciones_Audiencia_Inicial MultiRow
var Detalle_Relaciones_Audiencia_InicialcountRowsChecked = 0;

function GetDetalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoName(Id) {
    for (var i = 0; i < Detalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoItems.length; i++) {
        if (Detalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoItems[i].Clave == Id) {
            return Detalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoItems[i].Nombre_Completo_del_Tutor;
        }
    }
    return "";
}

function GetDetalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoDropDown() {
    var Detalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Relaciones_Audiencia_Inicial_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoDropdown);

    for (var i = 0; i < Detalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoItems.length; i++) {
        $('<option />', { value: Detalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoItems[i].Clave, text: Detalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoItems[i].Nombre_Completo_del_Tutor }).appendTo(Detalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoDropdown);
    }
    return Detalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoDropdown;
}
function GetDetalle_Relaciones_Audiencia_Inicial_DelitoName(Id) {
    for (var i = 0; i < Detalle_Relaciones_Audiencia_Inicial_DelitoItems.length; i++) {
        if (Detalle_Relaciones_Audiencia_Inicial_DelitoItems[i].Clave == Id) {
            return Detalle_Relaciones_Audiencia_Inicial_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Relaciones_Audiencia_Inicial_DelitoDropDown() {
    var Detalle_Relaciones_Audiencia_Inicial_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Relaciones_Audiencia_Inicial_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Relaciones_Audiencia_Inicial_DelitoDropdown);

    for (var i = 0; i < Detalle_Relaciones_Audiencia_Inicial_DelitoItems.length; i++) {
        $('<option />', { value: Detalle_Relaciones_Audiencia_Inicial_DelitoItems[i].Clave, text: Detalle_Relaciones_Audiencia_Inicial_DelitoItems[i].Descripcion }).appendTo(Detalle_Relaciones_Audiencia_Inicial_DelitoDropdown);
    }
    return Detalle_Relaciones_Audiencia_Inicial_DelitoDropdown;
}


function GetInsertDetalle_Relaciones_Audiencia_InicialRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Relaciones_Audiencia_Inicial_Imputado'))).addClass('Detalle_Relaciones_Audiencia_Inicial_Imputado Imputado').attr('id', 'Detalle_Relaciones_Audiencia_Inicial_Imputado_' + index).attr('data-field', 'Imputado').after($.parseHTML(addNew('Detalle_Relaciones_Audiencia_Inicial', 'Detalle_de_Imputado', 'Imputado', 267755)));
    columnData[1] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Relaciones_Audiencia_Inicial_Delito'))).addClass('Detalle_Relaciones_Audiencia_Inicial_Delito Delito').attr('id', 'Detalle_Relaciones_Audiencia_Inicial_Delito_' + index).attr('data-field', 'Delito').after($.parseHTML(addNew('Detalle_Relaciones_Audiencia_Inicial', 'Delito', 'Delito', 267756)));


    initiateUIControls();
    return columnData;
}

function Detalle_Relaciones_Audiencia_InicialInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Relaciones_Audiencia_Inicial("Detalle_Relaciones_Audiencia_Inicial_", "_" + rowIndex)) {
    var iPage = Detalle_Relaciones_Audiencia_InicialTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Relaciones_Audiencia_Inicial';
    var prevData = Detalle_Relaciones_Audiencia_InicialTable.fnGetData(rowIndex);
    var data = Detalle_Relaciones_Audiencia_InicialTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , ImputadoNombre_Completo_del_Tutor:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Imputado:  data.childNodes[counter++].childNodes[0].value 	
        , DelitoDescripcion:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Delito:  data.childNodes[counter++].childNodes[0].value 	

    }
    Detalle_Relaciones_Audiencia_InicialTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Relaciones_Audiencia_InicialrowCreationGrid(data, newData, rowIndex);
    Detalle_Relaciones_Audiencia_InicialTable.fnPageChange(iPage);
    Detalle_Relaciones_Audiencia_InicialcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Relaciones_Audiencia_Inicial("Detalle_Relaciones_Audiencia_Inicial_", "_" + rowIndex);
  }
}

function Detalle_Relaciones_Audiencia_InicialCancelRow(rowIndex) {
    var prevData = Detalle_Relaciones_Audiencia_InicialTable.fnGetData(rowIndex);
    var data = Detalle_Relaciones_Audiencia_InicialTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Relaciones_Audiencia_InicialTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Relaciones_Audiencia_InicialrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Relaciones_Audiencia_InicialGrid(Detalle_Relaciones_Audiencia_InicialTable.fnGetData());
    Detalle_Relaciones_Audiencia_InicialcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Relaciones_Audiencia_InicialFromDataTable() {
    var Detalle_Relaciones_Audiencia_InicialData = [];
    var gridData = Detalle_Relaciones_Audiencia_InicialTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Relaciones_Audiencia_InicialData.push({
                Clave: gridData[i].Clave

                ,Imputado: gridData[i].Imputado
                ,Delito: gridData[i].Delito

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Relaciones_Audiencia_InicialData.length; i++) {
        if (removedDetalle_Relaciones_Audiencia_InicialData[i] != null && removedDetalle_Relaciones_Audiencia_InicialData[i].Clave > 0)
            Detalle_Relaciones_Audiencia_InicialData.push({
                Clave: removedDetalle_Relaciones_Audiencia_InicialData[i].Clave

                ,Imputado: removedDetalle_Relaciones_Audiencia_InicialData[i].Imputado
                ,Delito: removedDetalle_Relaciones_Audiencia_InicialData[i].Delito

                , Removed: true
            });
    }	

    return Detalle_Relaciones_Audiencia_InicialData;
}

function Detalle_Relaciones_Audiencia_InicialEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Relaciones_Audiencia_InicialTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Relaciones_Audiencia_InicialcountRowsChecked++;
    var Detalle_Relaciones_Audiencia_InicialRowElement = "Detalle_Relaciones_Audiencia_Inicial_" + rowIndex.toString();
    var prevData = Detalle_Relaciones_Audiencia_InicialTable.fnGetData(rowIndexTable );
    var row = Detalle_Relaciones_Audiencia_InicialTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Relaciones_Audiencia_Inicial_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Relaciones_Audiencia_InicialGetUpdateRowControls(prevData, "Detalle_Relaciones_Audiencia_Inicial_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Relaciones_Audiencia_InicialRowElement + "')){ Detalle_Relaciones_Audiencia_InicialInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Relaciones_Audiencia_InicialCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Relaciones_Audiencia_InicialGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Relaciones_Audiencia_InicialGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Relaciones_Audiencia_InicialValidation();
    initiateUIControls();
    $('.Detalle_Relaciones_Audiencia_Inicial' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Relaciones_Audiencia_InicialfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Relaciones_Audiencia_InicialTable.fnGetData().length;
    Detalle_Relaciones_Audiencia_InicialfnClickAddRow();
    GetAddDetalle_Relaciones_Audiencia_InicialPopup(currentRowIndex, 0);
}

function Detalle_Relaciones_Audiencia_InicialEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Relaciones_Audiencia_InicialTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Relaciones_Audiencia_InicialRowElement = "Detalle_Relaciones_Audiencia_Inicial_" + rowIndex.toString();
    var prevData = Detalle_Relaciones_Audiencia_InicialTable.fnGetData(rowIndexTable);
    GetAddDetalle_Relaciones_Audiencia_InicialPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_Relaciones_Audiencia_InicialImputado').html($($.parseHTML(GetGridAutoComplete(prevData.Imputado.label,'AutoCompleteImputado'))).addClass('Detalle_Relaciones_Audiencia_Inicial_Imputado'));
    $('#dvDetalle_Relaciones_Audiencia_InicialDelito').html($($.parseHTML(GetGridAutoComplete(prevData.Delito.label,'AutoCompleteDelito'))).addClass('Detalle_Relaciones_Audiencia_Inicial_Delito'));

    initiateUIControls();




}

function Detalle_Relaciones_Audiencia_InicialAddInsertRow() {
    if (Detalle_Relaciones_Audiencia_InicialinsertRowCurrentIndex < 1)
    {
        Detalle_Relaciones_Audiencia_InicialinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Imputado: ""
        ,Delito: ""

    }
}

function Detalle_Relaciones_Audiencia_InicialfnClickAddRow() {
    Detalle_Relaciones_Audiencia_InicialcountRowsChecked++;
    Detalle_Relaciones_Audiencia_InicialTable.fnAddData(Detalle_Relaciones_Audiencia_InicialAddInsertRow(), true);
    Detalle_Relaciones_Audiencia_InicialTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Relaciones_Audiencia_InicialGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Relaciones_Audiencia_InicialGrid tbody tr:nth-of-type(' + (Detalle_Relaciones_Audiencia_InicialinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Relaciones_Audiencia_Inicial("Detalle_Relaciones_Audiencia_Inicial_", "_" + Detalle_Relaciones_Audiencia_InicialinsertRowCurrentIndex);
}

function Detalle_Relaciones_Audiencia_InicialClearGridData() {
    Detalle_Relaciones_Audiencia_InicialData = [];
    Detalle_Relaciones_Audiencia_InicialdeletedItem = [];
    Detalle_Relaciones_Audiencia_InicialDataMain = [];
    Detalle_Relaciones_Audiencia_InicialDataMainPages = [];
    Detalle_Relaciones_Audiencia_InicialnewItemCount = 0;
    Detalle_Relaciones_Audiencia_InicialmaxItemIndex = 0;
    $("#Detalle_Relaciones_Audiencia_InicialGrid").DataTable().clear();
    $("#Detalle_Relaciones_Audiencia_InicialGrid").DataTable().destroy();
}

//Used to Get Audiencia Inicial Information
function GetDetalle_Relaciones_Audiencia_Inicial() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Relaciones_Audiencia_InicialData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Relaciones_Audiencia_InicialData[i].Clave);

        form_data.append('[' + i + '].Imputado', Detalle_Relaciones_Audiencia_InicialData[i].Imputado);
        form_data.append('[' + i + '].Delito', Detalle_Relaciones_Audiencia_InicialData[i].Delito);

        form_data.append('[' + i + '].Removed', Detalle_Relaciones_Audiencia_InicialData[i].Removed);
    }
    return form_data;
}
function Detalle_Relaciones_Audiencia_InicialInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Relaciones_Audiencia_Inicial("Detalle_Relaciones_Audiencia_InicialTable", rowIndex)) {
    var prevData = Detalle_Relaciones_Audiencia_InicialTable.fnGetData(rowIndex);
    var data = Detalle_Relaciones_Audiencia_InicialTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Imputado: $('#Detalle_Relaciones_Audiencia_InicialImputado').val()
        ,Delito: $('#Detalle_Relaciones_Audiencia_InicialDelito').val()

    }

    Detalle_Relaciones_Audiencia_InicialTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Relaciones_Audiencia_InicialrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Relaciones_Audiencia_Inicial-form').modal({ show: false });
    $('#AddDetalle_Relaciones_Audiencia_Inicial-form').modal('hide');
    Detalle_Relaciones_Audiencia_InicialEditRow(rowIndex);
    Detalle_Relaciones_Audiencia_InicialInsertRow(rowIndex);
    //}
}
function Detalle_Relaciones_Audiencia_InicialRemoveAddRow(rowIndex) {
    Detalle_Relaciones_Audiencia_InicialTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Relaciones_Audiencia_Inicial MultiRow


$(function () {
    function Detalle_Relaciones_Audiencia_InicialinitializeMainArray(totalCount) {
        if (Detalle_Relaciones_Audiencia_InicialDataMain.length != totalCount && !Detalle_Relaciones_Audiencia_InicialDataMainInitialized) {
            Detalle_Relaciones_Audiencia_InicialDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Relaciones_Audiencia_InicialDataMain[i] = null;
            }
        }
    }
    function Detalle_Relaciones_Audiencia_InicialremoveFromMainArray() {
        for (var j = 0; j < Detalle_Relaciones_Audiencia_InicialdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Relaciones_Audiencia_InicialDataMain.length; i++) {
                if (Detalle_Relaciones_Audiencia_InicialDataMain[i] != null && Detalle_Relaciones_Audiencia_InicialDataMain[i].Id == Detalle_Relaciones_Audiencia_InicialdeletedItem[j]) {
                    hDetalle_Relaciones_Audiencia_InicialDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Relaciones_Audiencia_InicialcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Relaciones_Audiencia_InicialDataMain.length; i++) {
            data[i] = Detalle_Relaciones_Audiencia_InicialDataMain[i];

        }
        return data;
    }
    function Detalle_Relaciones_Audiencia_InicialgetNewResult() {
        var newData = copyMainDetalle_Relaciones_Audiencia_InicialArray();

        for (var i = 0; i < Detalle_Relaciones_Audiencia_InicialData.length; i++) {
            if (Detalle_Relaciones_Audiencia_InicialData[i].Removed == null || Detalle_Relaciones_Audiencia_InicialData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Relaciones_Audiencia_InicialData[i]);
            }
        }
        return newData;
    }
    function Detalle_Relaciones_Audiencia_InicialpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Relaciones_Audiencia_InicialDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Relaciones_Audiencia_InicialDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteExpediente_MPData = [];
function GetAutoCompleteAudiencia_Inicial_Expediente_MP_expediente_ministerio_publicoData(data) {
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
function GetAutoCompleteAudiencia_Inicial_Usuario_que_Registra_Spartan_UserData(data) {
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
var AutoCompleteImputadoData = [];
function GetAutoCompleteDetalle_Relaciones_Audiencia_Inicial_Imputado_Detalle_de_ImputadoData(data) {
	AutoCompleteImputadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteImputadoData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo_del_Tutor
        });
    }
    return AutoCompleteImputadoData;
}
var AutoCompleteDelitoData = [];
function GetAutoCompleteDetalle_Relaciones_Audiencia_Inicial_Delito_DelitoData(data) {
	AutoCompleteDelitoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteDelitoData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteDelitoData;
}



function getDropdown(elementKey) {
    var labelSelect = $("#Audiencia_Inicial_cmbLabelSelect").val();
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
    $('#CreateAudiencia_Inicial')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_Relaciones_Audiencia_InicialClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateAudiencia_Inicial').trigger('reset');
    $('#CreateAudiencia_Inicial').find(':input').each(function () {
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
    var $myForm = $('#CreateAudiencia_Inicial');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Relaciones_Audiencia_InicialcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Relaciones_Audiencia_Inicial();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateAudiencia_Inicial").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateAudiencia_Inicial").on('click', '#Audiencia_InicialCancelar', function () {
	  if (!isPartial) {
        Audiencia_InicialBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateAudiencia_Inicial").on('click', '#Audiencia_InicialGuardar', function () {
		$('#Audiencia_InicialGuardar').attr('disabled', true);
		$('#Audiencia_InicialGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendAudiencia_InicialData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Audiencia_InicialBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Audiencia_InicialGuardar').removeAttr('disabled');
                        $('#Audiencia_InicialGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Audiencia_Inicial', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Audiencia_InicialItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Audiencia_InicialDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Audiencia_InicialGuardar').removeAttr('disabled');
					$('#Audiencia_InicialGuardar').bind()
				}
		}
		else {
			$('#Audiencia_InicialGuardar').removeAttr('disabled');
			$('#Audiencia_InicialGuardar').bind()
		}
    });
	$("form#CreateAudiencia_Inicial").on('click', '#Audiencia_InicialGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendAudiencia_InicialData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Relaciones_Audiencia_InicialData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Audiencia_Inicial', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Audiencia_InicialItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Audiencia_InicialDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateAudiencia_Inicial").on('click', '#Audiencia_InicialGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendAudiencia_InicialData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_Relaciones_Audiencia_InicialClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Relaciones_Audiencia_InicialData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Audiencia_Inicial',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Audiencia_InicialItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Audiencia_InicialDropDown().get(0)').innerHTML);                          
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



var Audiencia_InicialisdisplayBusinessPropery = false;
Audiencia_InicialDisplayBusinessRuleButtons(Audiencia_InicialisdisplayBusinessPropery);
function Audiencia_InicialDisplayBusinessRule() {
    if (!Audiencia_InicialisdisplayBusinessPropery) {
        $('#CreateAudiencia_Inicial').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Audiencia_InicialdisplayBusinessPropery"><button onclick="Audiencia_InicialGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Audiencia_InicialBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Audiencia_InicialdisplayBusinessPropery').remove();
    }
    Audiencia_InicialDisplayBusinessRuleButtons(!Audiencia_InicialisdisplayBusinessPropery);
    Audiencia_InicialisdisplayBusinessPropery = (Audiencia_InicialisdisplayBusinessPropery ? false : true);
}
function Audiencia_InicialDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

