

//Begin Declarations for Foreigns fields for detalle_de_observaciones_mpi MultiRow
var detalle_de_observaciones_mpicountRowsChecked = 0;




function Getdetalle_de_observaciones_mpi_Spartan_UserName(Id) {
    for (var i = 0; i < detalle_de_observaciones_mpi_Spartan_UserItems.length; i++) {
        if (detalle_de_observaciones_mpi_Spartan_UserItems[i].Id_User == Id) {
            return detalle_de_observaciones_mpi_Spartan_UserItems[i].Name;
        }
    }
    return "";
}

function Getdetalle_de_observaciones_mpi_Spartan_UserDropDown() {
    var detalle_de_observaciones_mpi_Spartan_UserDropdown = $('<select class="form-control" />');      var labelSelect = $("#detalle_de_observaciones_mpi_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(detalle_de_observaciones_mpi_Spartan_UserDropdown);

    for (var i = 0; i < detalle_de_observaciones_mpi_Spartan_UserItems.length; i++) {
        $('<option />', { value: detalle_de_observaciones_mpi_Spartan_UserItems[i].Id_User, text: detalle_de_observaciones_mpi_Spartan_UserItems[i].Name }).appendTo(detalle_de_observaciones_mpi_Spartan_UserDropdown);
    }
    return detalle_de_observaciones_mpi_Spartan_UserDropdown;
}


function GetInsertdetalle_de_observaciones_mpiRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('detalle_de_observaciones_mpi_observaciones observaciones').attr('id', 'detalle_de_observaciones_mpi_observaciones_' + index).attr('data-field', 'observaciones');
    columnData[1] = $($.parseHTML(GetGridDatePicker())).addClass('detalle_de_observaciones_mpi_fecha fecha').attr('id', 'detalle_de_observaciones_mpi_fecha_' + index).attr('data-field', 'fecha');
    columnData[2] = $($.parseHTML(GetGridTimePicker())).addClass('detalle_de_observaciones_mpi_hora hora').attr('id', 'detalle_de_observaciones_mpi_hora_' + index).attr('data-field', 'hora');
    columnData[3] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompletedetalle_de_observaciones_mpi_usuario_que_realiza_observacion'))).addClass('detalle_de_observaciones_mpi_usuario_que_realiza_observacion usuario_que_realiza_observacion').attr('id', 'detalle_de_observaciones_mpi_usuario_que_realiza_observacion_' + index).attr('data-field', 'usuario_que_realiza_observacion').after($.parseHTML(addNew('detalle_de_observaciones_mpi', 'Spartan_User', 'usuario_que_realiza_observacion', 267117)));


    initiateUIControls();
    return columnData;
}

function detalle_de_observaciones_mpiInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRdetalle_de_observaciones_mpi("detalle_de_observaciones_mpi_", "_" + rowIndex)) {
    var iPage = detalle_de_observaciones_mpiTable.fnPagingInfo().iPage;
    var nameOfGrid = 'detalle_de_observaciones_mpi';
    var prevData = detalle_de_observaciones_mpiTable.fnGetData(rowIndex);
    var data = detalle_de_observaciones_mpiTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        clave: prevData.clave,
        IsInsertRow: false

        ,observaciones:  data.childNodes[counter++].childNodes[0].value
        ,fecha:  data.childNodes[counter++].childNodes[0].value
        ,hora:  data.childNodes[counter++].childNodes[0].value
        , usuario_que_realiza_observacionName:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , usuario_que_realiza_observacion:  data.childNodes[counter++].childNodes[0].value 	

    }
    detalle_de_observaciones_mpiTable.fnUpdate(newData, rowIndex, null, true);
    detalle_de_observaciones_mpirowCreationGrid(data, newData, rowIndex);
    detalle_de_observaciones_mpiTable.fnPageChange(iPage);
    detalle_de_observaciones_mpicountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRdetalle_de_observaciones_mpi("detalle_de_observaciones_mpi_", "_" + rowIndex);
  }
}

function detalle_de_observaciones_mpiCancelRow(rowIndex) {
    var prevData = detalle_de_observaciones_mpiTable.fnGetData(rowIndex);
    var data = detalle_de_observaciones_mpiTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        detalle_de_observaciones_mpiTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        detalle_de_observaciones_mpirowCreationGrid(data, prevData, rowIndex);
    }
	showdetalle_de_observaciones_mpiGrid(detalle_de_observaciones_mpiTable.fnGetData());
    detalle_de_observaciones_mpicountRowsChecked--;
	initiateUIControls();
}

function Getdetalle_de_observaciones_mpiFromDataTable() {
    var detalle_de_observaciones_mpiData = [];
    var gridData = detalle_de_observaciones_mpiTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            detalle_de_observaciones_mpiData.push({
                clave: gridData[i].clave

                ,observaciones: gridData[i].observaciones
                ,fecha: gridData[i].fecha
                ,hora: gridData[i].hora
                ,usuario_que_realiza_observacion: gridData[i].usuario_que_realiza_observacion

                ,Removed: false
            });
    }

    for (i = 0; i < removeddetalle_de_observaciones_mpiData.length; i++) {
        if (removeddetalle_de_observaciones_mpiData[i] != null && removeddetalle_de_observaciones_mpiData[i].clave > 0)
            detalle_de_observaciones_mpiData.push({
                clave: removeddetalle_de_observaciones_mpiData[i].clave

                ,observaciones: removeddetalle_de_observaciones_mpiData[i].observaciones
                ,fecha: removeddetalle_de_observaciones_mpiData[i].fecha
                ,hora: removeddetalle_de_observaciones_mpiData[i].hora
                ,usuario_que_realiza_observacion: removeddetalle_de_observaciones_mpiData[i].usuario_que_realiza_observacion

                , Removed: true
            });
    }	

    return detalle_de_observaciones_mpiData;
}

function detalle_de_observaciones_mpiEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? detalle_de_observaciones_mpiTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    detalle_de_observaciones_mpicountRowsChecked++;
    var detalle_de_observaciones_mpiRowElement = "detalle_de_observaciones_mpi_" + rowIndex.toString();
    var prevData = detalle_de_observaciones_mpiTable.fnGetData(rowIndexTable );
    var row = detalle_de_observaciones_mpiTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "detalle_de_observaciones_mpi_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = detalle_de_observaciones_mpiGetUpdateRowControls(prevData, "detalle_de_observaciones_mpi_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + detalle_de_observaciones_mpiRowElement + "')){ detalle_de_observaciones_mpiInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='detalle_de_observaciones_mpiCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#detalle_de_observaciones_mpiGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#detalle_de_observaciones_mpiGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setdetalle_de_observaciones_mpiValidation();
    initiateUIControls();
    $('.detalle_de_observaciones_mpi' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRdetalle_de_observaciones_mpi(nameOfTable, rowIndexFormed);
    }
}

function detalle_de_observaciones_mpifnOpenAddRowPopUp() {
    var currentRowIndex = detalle_de_observaciones_mpiTable.fnGetData().length;
    detalle_de_observaciones_mpifnClickAddRow();
    GetAdddetalle_de_observaciones_mpiPopup(currentRowIndex, 0);
}

function detalle_de_observaciones_mpiEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = detalle_de_observaciones_mpiTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var detalle_de_observaciones_mpiRowElement = "detalle_de_observaciones_mpi_" + rowIndex.toString();
    var prevData = detalle_de_observaciones_mpiTable.fnGetData(rowIndexTable);
    GetAdddetalle_de_observaciones_mpiPopup(rowIndex, 1, prevData.clave);

    $('#detalle_de_observaciones_mpiobservaciones').val(prevData.observaciones);
    $('#detalle_de_observaciones_mpifecha').val(prevData.fecha);
    $('#detalle_de_observaciones_mpihora').val(prevData.hora);
    $('#dvdetalle_de_observaciones_mpiusuario_que_realiza_observacion').html($($.parseHTML(GetGridAutoComplete(prevData.usuario_que_realiza_observacion.label,'AutoCompleteusuario_que_realiza_observacion'))).addClass('detalle_de_observaciones_mpi_usuario_que_realiza_observacion'));

    initiateUIControls();






}

function detalle_de_observaciones_mpiAddInsertRow() {
    if (detalle_de_observaciones_mpiinsertRowCurrentIndex < 1)
    {
        detalle_de_observaciones_mpiinsertRowCurrentIndex = 1;
    }
    return {
        clave: null,
        IsInsertRow: true

        ,observaciones: ""
        ,fecha: ""
        ,hora: ""
        ,usuario_que_realiza_observacion: ""

    }
}

function detalle_de_observaciones_mpifnClickAddRow() {
    detalle_de_observaciones_mpicountRowsChecked++;
    detalle_de_observaciones_mpiTable.fnAddData(detalle_de_observaciones_mpiAddInsertRow(), true);
    detalle_de_observaciones_mpiTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#detalle_de_observaciones_mpiGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#detalle_de_observaciones_mpiGrid tbody tr:nth-of-type(' + (detalle_de_observaciones_mpiinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRdetalle_de_observaciones_mpi("detalle_de_observaciones_mpi_", "_" + detalle_de_observaciones_mpiinsertRowCurrentIndex);
}

function detalle_de_observaciones_mpiClearGridData() {
    detalle_de_observaciones_mpiData = [];
    detalle_de_observaciones_mpideletedItem = [];
    detalle_de_observaciones_mpiDataMain = [];
    detalle_de_observaciones_mpiDataMainPages = [];
    detalle_de_observaciones_mpinewItemCount = 0;
    detalle_de_observaciones_mpimaxItemIndex = 0;
    $("#detalle_de_observaciones_mpiGrid").DataTable().clear();
    $("#detalle_de_observaciones_mpiGrid").DataTable().destroy();
}

//Used to Get Expediente Ministerio Público Information
function Getdetalle_de_observaciones_mpi() {
    var form_data = new FormData();
    for (var i = 0; i < detalle_de_observaciones_mpiData.length; i++) {
        form_data.append('[' + i + '].clave', detalle_de_observaciones_mpiData[i].clave);

        form_data.append('[' + i + '].observaciones', detalle_de_observaciones_mpiData[i].observaciones);
        form_data.append('[' + i + '].fecha', detalle_de_observaciones_mpiData[i].fecha);
        form_data.append('[' + i + '].hora', detalle_de_observaciones_mpiData[i].hora);
        form_data.append('[' + i + '].usuario_que_realiza_observacion', detalle_de_observaciones_mpiData[i].usuario_que_realiza_observacion);

        form_data.append('[' + i + '].Removed', detalle_de_observaciones_mpiData[i].Removed);
    }
    return form_data;
}
function detalle_de_observaciones_mpiInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRdetalle_de_observaciones_mpi("detalle_de_observaciones_mpiTable", rowIndex)) {
    var prevData = detalle_de_observaciones_mpiTable.fnGetData(rowIndex);
    var data = detalle_de_observaciones_mpiTable.fnGetNodes(rowIndex);
    var newData = {
        clave: prevData.clave,
        IsInsertRow: false

        ,observaciones: $('#detalle_de_observaciones_mpiobservaciones').val()
        ,fecha: $('#detalle_de_observaciones_mpifecha').val()
        ,hora: $('#detalle_de_observaciones_mpihora').val()
        ,usuario_que_realiza_observacion: $('#detalle_de_observaciones_mpiusuario_que_realiza_observacion').val()

    }

    detalle_de_observaciones_mpiTable.fnUpdate(newData, rowIndex, null, true);
    detalle_de_observaciones_mpirowCreationGrid(data, newData, rowIndex);
    $('#Adddetalle_de_observaciones_mpi-form').modal({ show: false });
    $('#Adddetalle_de_observaciones_mpi-form').modal('hide');
    detalle_de_observaciones_mpiEditRow(rowIndex);
    detalle_de_observaciones_mpiInsertRow(rowIndex);
    //}
}
function detalle_de_observaciones_mpiRemoveAddRow(rowIndex) {
    detalle_de_observaciones_mpiTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for detalle_de_observaciones_mpi MultiRow


$(function () {
    function detalle_de_observaciones_mpiinitializeMainArray(totalCount) {
        if (detalle_de_observaciones_mpiDataMain.length != totalCount && !detalle_de_observaciones_mpiDataMainInitialized) {
            detalle_de_observaciones_mpiDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                detalle_de_observaciones_mpiDataMain[i] = null;
            }
        }
    }
    function detalle_de_observaciones_mpiremoveFromMainArray() {
        for (var j = 0; j < detalle_de_observaciones_mpideletedItem.length; j++) {
            for (var i = 0; i < detalle_de_observaciones_mpiDataMain.length; i++) {
                if (detalle_de_observaciones_mpiDataMain[i] != null && detalle_de_observaciones_mpiDataMain[i].Id == detalle_de_observaciones_mpideletedItem[j]) {
                    hdetalle_de_observaciones_mpiDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function detalle_de_observaciones_mpicopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < detalle_de_observaciones_mpiDataMain.length; i++) {
            data[i] = detalle_de_observaciones_mpiDataMain[i];

        }
        return data;
    }
    function detalle_de_observaciones_mpigetNewResult() {
        var newData = copyMaindetalle_de_observaciones_mpiArray();

        for (var i = 0; i < detalle_de_observaciones_mpiData.length; i++) {
            if (detalle_de_observaciones_mpiData[i].Removed == null || detalle_de_observaciones_mpiData[i].Removed == false) {
                newData.splice(0, 0, detalle_de_observaciones_mpiData[i]);
            }
        }
        return newData;
    }
    function detalle_de_observaciones_mpipushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (detalle_de_observaciones_mpiDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                detalle_de_observaciones_mpiDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteusuario_que_registraData = [];
function GetAutoCompleteexpediente_ministerio_publico_usuario_que_registra_Spartan_UserData(data) {
	AutoCompleteusuario_que_registraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteusuario_que_registraData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteusuario_que_registraData;
}
var AutoCompleteMP_AsignadoData = [];
function GetAutoCompleteexpediente_ministerio_publico_MP_Asignado_Spartan_UserData(data) {
	AutoCompleteMP_AsignadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMP_AsignadoData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteMP_AsignadoData;
}
var AutoCompleteunidadData = [];
function GetAutoCompleteexpediente_ministerio_publico_unidad_UnidadData(data) {
	AutoCompleteunidadData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteunidadData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteunidadData;
}
var AutoCompleteMunicipioData = [];
function GetAutoCompleteexpediente_ministerio_publico_Municipio_MunicipioData(data) {
	AutoCompleteMunicipioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioData;
}
//Grid GetAutocomplete
var AutoCompleteusuario_que_realiza_observacionData = [];
function GetAutoCompletedetalle_de_observaciones_mpi_usuario_que_realiza_observacion_Spartan_UserData(data) {
	AutoCompleteusuario_que_realiza_observacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteusuario_que_realiza_observacionData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteusuario_que_realiza_observacionData;
}

var AutoCompletePaisHData = [];
function GetAutoCompleteexpediente_ministerio_publico_PaisH_PaisData(data) {
	AutoCompletePaisHData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePaisHData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePaisHData;
}
var AutoCompleteEstadoData = [];
function GetAutoCompleteexpediente_ministerio_publico_Estado_EstadoData(data) {
	AutoCompleteEstadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstadoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstadoData;
}
var AutoCompleteMunicipio_HechosData = [];
function GetAutoCompleteexpediente_ministerio_publico_Municipio_Hechos_MunicipioData(data) {
	AutoCompleteMunicipio_HechosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_HechosData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_HechosData;
}
var AutoCompletePoblacionData = [];
function GetAutoCompleteexpediente_ministerio_publico_Poblacion_ColoniaData(data) {
	AutoCompletePoblacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePoblacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePoblacionData;
}
var AutoCompleteColoniaHData = [];
function GetAutoCompleteexpediente_ministerio_publico_ColoniaH_ColoniaData(data) {
	AutoCompleteColoniaHData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaHData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaHData;
}
var AutoCompleteusuario_que_canalizaData = [];
function GetAutoCompleteexpediente_ministerio_publico_usuario_que_canaliza_Spartan_UserData(data) {
	AutoCompleteusuario_que_canalizaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteusuario_que_canalizaData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteusuario_que_canalizaData;
}
var AutoCompleteUsuario_que_CierraData = [];
function GetAutoCompleteexpediente_ministerio_publico_Usuario_que_Cierra_Spartan_UserData(data) {
	AutoCompleteUsuario_que_CierraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_CierraData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_CierraData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#expediente_ministerio_publico_cmbLabelSelect").val();
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
    $("#Referenceclave").val("0");
    $('#Createexpediente_ministerio_publico')[0].reset();
    ClearFormControls();
    $("#claveId").val("0");
    $('#usuario_que_registra').empty();
    $("#usuario_que_registra").append('<option value=""></option>');
    $('#usuario_que_registra').val('0').trigger('change');
    $('#MP_Asignado').empty();
    $("#MP_Asignado").append('<option value=""></option>');
    $('#MP_Asignado').val('0').trigger('change');
    $('#unidad').empty();
    $("#unidad").append('<option value=""></option>');
    $('#unidad').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
                detalle_de_observaciones_mpiClearGridData();
    $('#PaisH').empty();
    $("#PaisH").append('<option value=""></option>');
    $('#PaisH').val('0').trigger('change');
    $('#Estado').empty();
    $("#Estado").append('<option value=""></option>');
    $('#Estado').val('0').trigger('change');
    $('#Municipio_Hechos').empty();
    $("#Municipio_Hechos").append('<option value=""></option>');
    $('#Municipio_Hechos').val('0').trigger('change');
    $('#Poblacion').empty();
    $("#Poblacion").append('<option value=""></option>');
    $('#Poblacion').val('0').trigger('change');
    $('#ColoniaH').empty();
    $("#ColoniaH").append('<option value=""></option>');
    $('#ColoniaH').val('0').trigger('change');
    $('#usuario_que_canaliza').empty();
    $("#usuario_que_canaliza").append('<option value=""></option>');
    $('#usuario_que_canaliza').val('0').trigger('change');
    $('#Usuario_que_Cierra').empty();
    $("#Usuario_que_Cierra").append('<option value=""></option>');
    $('#Usuario_que_Cierra').val('0').trigger('change');

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#Createexpediente_ministerio_publico').trigger('reset');
    $('#Createexpediente_ministerio_publico').find(':input').each(function () {
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
    var $myForm = $('#Createexpediente_ministerio_publico');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (detalle_de_observaciones_mpicountRowsChecked > 0)
    {
        ShowMessagePendingRowdetalle_de_observaciones_mpi();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblclave").text("0");
}
$(document).ready(function () {
    $("form#Createexpediente_ministerio_publico").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#Createexpediente_ministerio_publico").on('click', '#expediente_ministerio_publicoCancelar', function () {
	  if (!isPartial) {
        expediente_ministerio_publicoBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#Createexpediente_ministerio_publico").on('click', '#expediente_ministerio_publicoGuardar', function () {
		$('#expediente_ministerio_publicoGuardar').attr('disabled', true);
		$('#expediente_ministerio_publicoGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!Sendexpediente_ministerio_publicoData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						expediente_ministerio_publicoBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#expediente_ministerio_publicoGuardar').removeAttr('disabled');
                        $('#expediente_ministerio_publicoGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('expediente_ministerio_publico', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_expediente_ministerio_publicoItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_expediente_ministerio_publicoDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#expediente_ministerio_publicoGuardar').removeAttr('disabled');
					$('#expediente_ministerio_publicoGuardar').bind()
				}
		}
		else {
			$('#expediente_ministerio_publicoGuardar').removeAttr('disabled');
			$('#expediente_ministerio_publicoGuardar').bind()
		}
    });
	$("form#Createexpediente_ministerio_publico").on('click', '#expediente_ministerio_publicoGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				Sendexpediente_ministerio_publicoData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getdetalle_de_observaciones_mpiData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('expediente_ministerio_publico', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_expediente_ministerio_publicoItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_expediente_ministerio_publicoDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#Createexpediente_ministerio_publico").on('click', '#expediente_ministerio_publicoGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				Sendexpediente_ministerio_publicoData(function (currentId) {
					$("#claveId").val("0");
	    $('#usuario_que_registra').empty();
    $("#usuario_que_registra").append('<option value=""></option>');
    $('#usuario_que_registra').val('0').trigger('change');
    $('#MP_Asignado').empty();
    $("#MP_Asignado").append('<option value=""></option>');
    $('#MP_Asignado').val('0').trigger('change');
    $('#unidad').empty();
    $("#unidad").append('<option value=""></option>');
    $('#unidad').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
                detalle_de_observaciones_mpiClearGridData();
    $('#PaisH').empty();
    $("#PaisH").append('<option value=""></option>');
    $('#PaisH').val('0').trigger('change');
    $('#Estado').empty();
    $("#Estado").append('<option value=""></option>');
    $('#Estado').val('0').trigger('change');
    $('#Municipio_Hechos').empty();
    $("#Municipio_Hechos").append('<option value=""></option>');
    $('#Municipio_Hechos').val('0').trigger('change');
    $('#Poblacion').empty();
    $("#Poblacion").append('<option value=""></option>');
    $('#Poblacion').val('0').trigger('change');
    $('#ColoniaH').empty();
    $("#ColoniaH").append('<option value=""></option>');
    $('#ColoniaH').val('0').trigger('change');
    $('#usuario_que_canaliza').empty();
    $("#usuario_que_canaliza").append('<option value=""></option>');
    $('#usuario_que_canaliza').val('0').trigger('change');
    $('#Usuario_que_Cierra').empty();
    $("#Usuario_que_Cierra").append('<option value=""></option>');
    $('#Usuario_que_Cierra').val('0').trigger('change');

					ResetClaveLabel();
					$("#Referenceclave").val(currentId);
	                getdetalle_de_observaciones_mpiData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('expediente_ministerio_publico',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_expediente_ministerio_publicoItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_expediente_ministerio_publicoDropDown().get(0)').innerHTML);                          
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



var expediente_ministerio_publicoisdisplayBusinessPropery = false;
expediente_ministerio_publicoDisplayBusinessRuleButtons(expediente_ministerio_publicoisdisplayBusinessPropery);
function expediente_ministerio_publicoDisplayBusinessRule() {
    if (!expediente_ministerio_publicoisdisplayBusinessPropery) {
        $('#Createexpediente_ministerio_publico').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="expediente_ministerio_publicodisplayBusinessPropery"><button onclick="expediente_ministerio_publicoGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#expediente_ministerio_publicoBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.expediente_ministerio_publicodisplayBusinessPropery').remove();
    }
    expediente_ministerio_publicoDisplayBusinessRuleButtons(!expediente_ministerio_publicoisdisplayBusinessPropery);
    expediente_ministerio_publicoisdisplayBusinessPropery = (expediente_ministerio_publicoisdisplayBusinessPropery ? false : true);
}
function expediente_ministerio_publicoDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

