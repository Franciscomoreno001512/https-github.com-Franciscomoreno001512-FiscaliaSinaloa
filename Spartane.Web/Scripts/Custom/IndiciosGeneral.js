

//Begin Declarations for Foreigns fields for Detalle_del_Indicio MultiRow
var Detalle_del_IndiciocountRowsChecked = 0;





function GetDetalle_del_Indicio_Estatus_de_IndicioName(Id) {
    for (var i = 0; i < Detalle_del_Indicio_Estatus_de_IndicioItems.length; i++) {
        if (Detalle_del_Indicio_Estatus_de_IndicioItems[i].Clave == Id) {
            return Detalle_del_Indicio_Estatus_de_IndicioItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_del_Indicio_Estatus_de_IndicioDropDown() {
    var Detalle_del_Indicio_Estatus_de_IndicioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Indicio_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Indicio_Estatus_de_IndicioDropdown);
    if(Detalle_del_Indicio_Estatus_de_IndicioItems != null)
    {
       for (var i = 0; i < Detalle_del_Indicio_Estatus_de_IndicioItems.length; i++) {
           $('<option />', { value: Detalle_del_Indicio_Estatus_de_IndicioItems[i].Clave, text:    Detalle_del_Indicio_Estatus_de_IndicioItems[i].Descripcion }).appendTo(Detalle_del_Indicio_Estatus_de_IndicioDropdown);
       }
    }
    return Detalle_del_Indicio_Estatus_de_IndicioDropdown;
}



function GetInsertDetalle_del_IndicioRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_del_Indicio_Numero_de_Indicio Numero_de_Indicio').attr('id', 'Detalle_del_Indicio_Numero_de_Indicio_' + index).attr('data-field', 'Numero_de_Indicio');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_del_Indicio_Nombre_del_Indicio Nombre_del_Indicio').attr('id', 'Detalle_del_Indicio_Nombre_del_Indicio_' + index).attr('data-field', 'Nombre_del_Indicio');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_del_Indicio_Descripcion_del_Indicio Descripcion_del_Indicio').attr('id', 'Detalle_del_Indicio_Descripcion_del_Indicio_' + index).attr('data-field', 'Descripcion_del_Indicio');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_del_Indicio_Motivo Motivo').attr('id', 'Detalle_del_Indicio_Motivo_' + index).attr('data-field', 'Motivo');
    columnData[4] = $(GetDetalle_del_Indicio_Estatus_de_IndicioDropDown()).addClass('Detalle_del_Indicio_Estatus Estatus').attr('id', 'Detalle_del_Indicio_Estatus_' + index).attr('data-field', 'Estatus').after($.parseHTML(addNew('Detalle_del_Indicio', 'Estatus_de_Indicio', 'Estatus', 264871)));
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_del_Indicio_Ubicacion_de_Indicio Ubicacion_de_Indicio').attr('id', 'Detalle_del_Indicio_Ubicacion_de_Indicio_' + index).attr('data-field', 'Ubicacion_de_Indicio');


    initiateUIControls();
    return columnData;
}

function Detalle_del_IndicioInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_del_Indicio("Detalle_del_Indicio_", "_" + rowIndex)) {
    var iPage = Detalle_del_IndicioTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_del_Indicio';
    var prevData = Detalle_del_IndicioTable.fnGetData(rowIndex);
    var data = Detalle_del_IndicioTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_Indicio: data.childNodes[counter++].childNodes[0].value
        ,Nombre_del_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion_del_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Motivo:  data.childNodes[counter++].childNodes[0].value
        ,Estatus:  data.childNodes[counter++].childNodes[0].value
        ,Ubicacion_de_Indicio:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_del_IndicioTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_del_IndiciorowCreationGrid(data, newData, rowIndex);
    Detalle_del_IndicioTable.fnPageChange(iPage);
    Detalle_del_IndiciocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_del_Indicio("Detalle_del_Indicio_", "_" + rowIndex);
  }
}

function Detalle_del_IndicioCancelRow(rowIndex) {
    var prevData = Detalle_del_IndicioTable.fnGetData(rowIndex);
    var data = Detalle_del_IndicioTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_del_IndicioTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_del_IndiciorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_del_IndicioGrid(Detalle_del_IndicioTable.fnGetData());
    Detalle_del_IndiciocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_del_IndicioFromDataTable() {
    var Detalle_del_IndicioData = [];
    var gridData = Detalle_del_IndicioTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_del_IndicioData.push({
                Clave: gridData[i].Clave

                ,Numero_de_Indicio: gridData[i].Numero_de_Indicio
                ,Nombre_del_Indicio: gridData[i].Nombre_del_Indicio
                ,Descripcion_del_Indicio: gridData[i].Descripcion_del_Indicio
                ,Motivo: gridData[i].Motivo
                ,Estatus: gridData[i].Estatus
                ,Ubicacion_de_Indicio: gridData[i].Ubicacion_de_Indicio

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_del_IndicioData.length; i++) {
        if (removedDetalle_del_IndicioData[i] != null && removedDetalle_del_IndicioData[i].Clave > 0)
            Detalle_del_IndicioData.push({
                Clave: removedDetalle_del_IndicioData[i].Clave

                ,Numero_de_Indicio: removedDetalle_del_IndicioData[i].Numero_de_Indicio
                ,Nombre_del_Indicio: removedDetalle_del_IndicioData[i].Nombre_del_Indicio
                ,Descripcion_del_Indicio: removedDetalle_del_IndicioData[i].Descripcion_del_Indicio
                ,Motivo: removedDetalle_del_IndicioData[i].Motivo
                ,Estatus: removedDetalle_del_IndicioData[i].Estatus
                ,Ubicacion_de_Indicio: removedDetalle_del_IndicioData[i].Ubicacion_de_Indicio

                , Removed: true
            });
    }	

    return Detalle_del_IndicioData;
}

function Detalle_del_IndicioEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_del_IndicioTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_del_IndiciocountRowsChecked++;
    var Detalle_del_IndicioRowElement = "Detalle_del_Indicio_" + rowIndex.toString();
    var prevData = Detalle_del_IndicioTable.fnGetData(rowIndexTable );
    var row = Detalle_del_IndicioTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_del_Indicio_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_del_IndicioGetUpdateRowControls(prevData, "Detalle_del_Indicio_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_del_IndicioRowElement + "')){ Detalle_del_IndicioInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_del_IndicioCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_del_IndicioGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_del_IndicioGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_del_IndicioValidation();
    initiateUIControls();
    $('.Detalle_del_Indicio' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_del_Indicio(nameOfTable, rowIndexFormed);
    }
}

function Detalle_del_IndiciofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_del_IndicioTable.fnGetData().length;
    Detalle_del_IndiciofnClickAddRow();
    GetAddDetalle_del_IndicioPopup(currentRowIndex, 0);
}

function Detalle_del_IndicioEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_del_IndicioTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_del_IndicioRowElement = "Detalle_del_Indicio_" + rowIndex.toString();
    var prevData = Detalle_del_IndicioTable.fnGetData(rowIndexTable);
    GetAddDetalle_del_IndicioPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_del_IndicioNumero_de_Indicio').val(prevData.Numero_de_Indicio);
    $('#Detalle_del_IndicioNombre_del_Indicio').val(prevData.Nombre_del_Indicio);
    $('#Detalle_del_IndicioDescripcion_del_Indicio').val(prevData.Descripcion_del_Indicio);
    $('#Detalle_del_IndicioMotivo').val(prevData.Motivo);
    $('#Detalle_del_IndicioEstatus').val(prevData.Estatus);
    $('#Detalle_del_IndicioUbicacion_de_Indicio').val(prevData.Ubicacion_de_Indicio);

    initiateUIControls();








}

function Detalle_del_IndicioAddInsertRow() {
    if (Detalle_del_IndicioinsertRowCurrentIndex < 1)
    {
        Detalle_del_IndicioinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Numero_de_Indicio: ""
        ,Nombre_del_Indicio: ""
        ,Descripcion_del_Indicio: ""
        ,Motivo: ""
        ,Estatus: ""
        ,Ubicacion_de_Indicio: ""

    }
}

function Detalle_del_IndiciofnClickAddRow() {
    Detalle_del_IndiciocountRowsChecked++;
    Detalle_del_IndicioTable.fnAddData(Detalle_del_IndicioAddInsertRow(), true);
    Detalle_del_IndicioTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_del_IndicioGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_del_IndicioGrid tbody tr:nth-of-type(' + (Detalle_del_IndicioinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_del_Indicio("Detalle_del_Indicio_", "_" + Detalle_del_IndicioinsertRowCurrentIndex);
}

function Detalle_del_IndicioClearGridData() {
    Detalle_del_IndicioData = [];
    Detalle_del_IndiciodeletedItem = [];
    Detalle_del_IndicioDataMain = [];
    Detalle_del_IndicioDataMainPages = [];
    Detalle_del_IndicionewItemCount = 0;
    Detalle_del_IndiciomaxItemIndex = 0;
    $("#Detalle_del_IndicioGrid").DataTable().clear();
    $("#Detalle_del_IndicioGrid").DataTable().destroy();
}

//Used to Get Indicios Information
function GetDetalle_del_Indicio() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_del_IndicioData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_del_IndicioData[i].Clave);

        form_data.append('[' + i + '].Numero_de_Indicio', Detalle_del_IndicioData[i].Numero_de_Indicio);
        form_data.append('[' + i + '].Nombre_del_Indicio', Detalle_del_IndicioData[i].Nombre_del_Indicio);
        form_data.append('[' + i + '].Descripcion_del_Indicio', Detalle_del_IndicioData[i].Descripcion_del_Indicio);
        form_data.append('[' + i + '].Motivo', Detalle_del_IndicioData[i].Motivo);
        form_data.append('[' + i + '].Estatus', Detalle_del_IndicioData[i].Estatus);
        form_data.append('[' + i + '].Ubicacion_de_Indicio', Detalle_del_IndicioData[i].Ubicacion_de_Indicio);

        form_data.append('[' + i + '].Removed', Detalle_del_IndicioData[i].Removed);
    }
    return form_data;
}
function Detalle_del_IndicioInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_del_Indicio("Detalle_del_IndicioTable", rowIndex)) {
    var prevData = Detalle_del_IndicioTable.fnGetData(rowIndex);
    var data = Detalle_del_IndicioTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_Indicio: $('#Detalle_del_IndicioNumero_de_Indicio').val()

        ,Nombre_del_Indicio: $('#Detalle_del_IndicioNombre_del_Indicio').val()
        ,Descripcion_del_Indicio: $('#Detalle_del_IndicioDescripcion_del_Indicio').val()
        ,Motivo: $('#Detalle_del_IndicioMotivo').val()
        ,Estatus: $('#Detalle_del_IndicioEstatus').val()
        ,Ubicacion_de_Indicio: $('#Detalle_del_IndicioUbicacion_de_Indicio').val()

    }

    Detalle_del_IndicioTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_del_IndiciorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_del_Indicio-form').modal({ show: false });
    $('#AddDetalle_del_Indicio-form').modal('hide');
    Detalle_del_IndicioEditRow(rowIndex);
    Detalle_del_IndicioInsertRow(rowIndex);
    //}
}
function Detalle_del_IndicioRemoveAddRow(rowIndex) {
    Detalle_del_IndicioTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_del_Indicio MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Solicitud_de_Indicio MultiRow
var Detalle_de_Solicitud_de_IndiciocountRowsChecked = 0;





function GetDetalle_de_Solicitud_de_Indicio_Indicios_para_MPIName(Id) {
    for (var i = 0; i < Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIItems.length; i++) {
        if (Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIItems[i].Clave == Id) {
            return Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Solicitud_de_Indicio_Indicios_para_MPIDropDown() {
    var Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Solicitud_de_Indicio_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIDropdown);
    if(Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIItems != null)
    {
       for (var i = 0; i < Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIItems.length; i++) {
           $('<option />', { value: Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIItems[i].Clave, text:    Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIItems[i].Descripcion }).appendTo(Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIDropdown);
       }
    }
    return Detalle_de_Solicitud_de_Indicio_Indicios_para_MPIDropdown;
}


function GetDetalle_de_Solicitud_de_Indicio_Servicios_PericialesName(Id) {
    for (var i = 0; i < Detalle_de_Solicitud_de_Indicio_Servicios_PericialesItems.length; i++) {
        if (Detalle_de_Solicitud_de_Indicio_Servicios_PericialesItems[i].Clave == Id) {
            return Detalle_de_Solicitud_de_Indicio_Servicios_PericialesItems[i].Servicio;
        }
    }
    return "";
}

function GetDetalle_de_Solicitud_de_Indicio_Servicios_PericialesDropDown() {
    var Detalle_de_Solicitud_de_Indicio_Servicios_PericialesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Solicitud_de_Indicio_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Solicitud_de_Indicio_Servicios_PericialesDropdown);
    if(Detalle_de_Solicitud_de_Indicio_Servicios_PericialesItems != null)
    {
       for (var i = 0; i < Detalle_de_Solicitud_de_Indicio_Servicios_PericialesItems.length; i++) {
           $('<option />', { value: Detalle_de_Solicitud_de_Indicio_Servicios_PericialesItems[i].Clave, text:    Detalle_de_Solicitud_de_Indicio_Servicios_PericialesItems[i].Servicio }).appendTo(Detalle_de_Solicitud_de_Indicio_Servicios_PericialesDropdown);
       }
    }
    return Detalle_de_Solicitud_de_Indicio_Servicios_PericialesDropdown;
}


function GetInsertDetalle_de_Solicitud_de_IndicioRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Solicitud_de_Indicio_Fecha_de_Solicitud Fecha_de_Solicitud').attr('id', 'Detalle_de_Solicitud_de_Indicio_Fecha_de_Solicitud_' + index).attr('data-field', 'Fecha_de_Solicitud');
    columnData[1] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Solicitud_de_Indicio_Hora_de_Solicitud Hora_de_Solicitud').attr('id', 'Detalle_de_Solicitud_de_Indicio_Hora_de_Solicitud_' + index).attr('data-field', 'Hora_de_Solicitud');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Solicitud_de_Indicio_Nombre_del_Solicitante Nombre_del_Solicitante').attr('id', 'Detalle_de_Solicitud_de_Indicio_Nombre_del_Solicitante_' + index).attr('data-field', 'Nombre_del_Solicitante');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Solicitud_de_Indicio_Motivo Motivo').attr('id', 'Detalle_de_Solicitud_de_Indicio_Motivo_' + index).attr('data-field', 'Motivo');
    columnData[4] = $(GetDetalle_de_Solicitud_de_Indicio_Indicios_para_MPIDropDown()).addClass('Detalle_de_Solicitud_de_Indicio_Numero_de_Indicio Numero_de_Indicio').attr('id', 'Detalle_de_Solicitud_de_Indicio_Numero_de_Indicio_' + index).attr('data-field', 'Numero_de_Indicio').after($.parseHTML(addNew('Detalle_de_Solicitud_de_Indicio', 'Indicios_para_MPI', 'Numero_de_Indicio', 264879)));
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_de_Solicitud_de_Indicio_Nombre_de_Indicio Nombre_de_Indicio').attr('id', 'Detalle_de_Solicitud_de_Indicio_Nombre_de_Indicio_' + index).attr('data-field', 'Nombre_de_Indicio');
    columnData[6] = $($.parseHTML(inputData)).addClass('Detalle_de_Solicitud_de_Indicio_Descripcion_de_Entrega_de_Indicio Descripcion_de_Entrega_de_Indicio').attr('id', 'Detalle_de_Solicitud_de_Indicio_Descripcion_de_Entrega_de_Indicio_' + index).attr('data-field', 'Descripcion_de_Entrega_de_Indicio');
    columnData[7] = $(GetDetalle_de_Solicitud_de_Indicio_Servicios_PericialesDropDown()).addClass('Detalle_de_Solicitud_de_Indicio_Diligencia_que_Solicita Diligencia_que_Solicita').attr('id', 'Detalle_de_Solicitud_de_Indicio_Diligencia_que_Solicita_' + index).attr('data-field', 'Diligencia_que_Solicita').after($.parseHTML(addNew('Detalle_de_Solicitud_de_Indicio', 'Servicios_Periciales', 'Diligencia_que_Solicita', 264882)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_Solicitud_de_IndicioInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_de_Indicio("Detalle_de_Solicitud_de_Indicio_", "_" + rowIndex)) {
    var iPage = Detalle_de_Solicitud_de_IndicioTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Solicitud_de_Indicio';
    var prevData = Detalle_de_Solicitud_de_IndicioTable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitud_de_IndicioTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha_de_Solicitud:  data.childNodes[counter++].childNodes[0].value
        ,Hora_de_Solicitud:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_del_Solicitante:  data.childNodes[counter++].childNodes[0].value
        ,Motivo:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_de_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion_de_Entrega_de_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Diligencia_que_Solicita:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Solicitud_de_IndicioTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Solicitud_de_IndiciorowCreationGrid(data, newData, rowIndex);
    Detalle_de_Solicitud_de_IndicioTable.fnPageChange(iPage);
    Detalle_de_Solicitud_de_IndiciocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitud_de_Indicio("Detalle_de_Solicitud_de_Indicio_", "_" + rowIndex);
  }
}

function Detalle_de_Solicitud_de_IndicioCancelRow(rowIndex) {
    var prevData = Detalle_de_Solicitud_de_IndicioTable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitud_de_IndicioTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Solicitud_de_IndicioTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Solicitud_de_IndiciorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Solicitud_de_IndicioGrid(Detalle_de_Solicitud_de_IndicioTable.fnGetData());
    Detalle_de_Solicitud_de_IndiciocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Solicitud_de_IndicioFromDataTable() {
    var Detalle_de_Solicitud_de_IndicioData = [];
    var gridData = Detalle_de_Solicitud_de_IndicioTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Solicitud_de_IndicioData.push({
                Clave: gridData[i].Clave

                ,Fecha_de_Solicitud: gridData[i].Fecha_de_Solicitud
                ,Hora_de_Solicitud: gridData[i].Hora_de_Solicitud
                ,Nombre_del_Solicitante: gridData[i].Nombre_del_Solicitante
                ,Motivo: gridData[i].Motivo
                ,Numero_de_Indicio: gridData[i].Numero_de_Indicio
                ,Nombre_de_Indicio: gridData[i].Nombre_de_Indicio
                ,Descripcion_de_Entrega_de_Indicio: gridData[i].Descripcion_de_Entrega_de_Indicio
                ,Diligencia_que_Solicita: gridData[i].Diligencia_que_Solicita

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Solicitud_de_IndicioData.length; i++) {
        if (removedDetalle_de_Solicitud_de_IndicioData[i] != null && removedDetalle_de_Solicitud_de_IndicioData[i].Clave > 0)
            Detalle_de_Solicitud_de_IndicioData.push({
                Clave: removedDetalle_de_Solicitud_de_IndicioData[i].Clave

                ,Fecha_de_Solicitud: removedDetalle_de_Solicitud_de_IndicioData[i].Fecha_de_Solicitud
                ,Hora_de_Solicitud: removedDetalle_de_Solicitud_de_IndicioData[i].Hora_de_Solicitud
                ,Nombre_del_Solicitante: removedDetalle_de_Solicitud_de_IndicioData[i].Nombre_del_Solicitante
                ,Motivo: removedDetalle_de_Solicitud_de_IndicioData[i].Motivo
                ,Numero_de_Indicio: removedDetalle_de_Solicitud_de_IndicioData[i].Numero_de_Indicio
                ,Nombre_de_Indicio: removedDetalle_de_Solicitud_de_IndicioData[i].Nombre_de_Indicio
                ,Descripcion_de_Entrega_de_Indicio: removedDetalle_de_Solicitud_de_IndicioData[i].Descripcion_de_Entrega_de_Indicio
                ,Diligencia_que_Solicita: removedDetalle_de_Solicitud_de_IndicioData[i].Diligencia_que_Solicita

                , Removed: true
            });
    }	

    return Detalle_de_Solicitud_de_IndicioData;
}

function Detalle_de_Solicitud_de_IndicioEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Solicitud_de_IndicioTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Solicitud_de_IndiciocountRowsChecked++;
    var Detalle_de_Solicitud_de_IndicioRowElement = "Detalle_de_Solicitud_de_Indicio_" + rowIndex.toString();
    var prevData = Detalle_de_Solicitud_de_IndicioTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Solicitud_de_IndicioTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Solicitud_de_Indicio_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Solicitud_de_IndicioGetUpdateRowControls(prevData, "Detalle_de_Solicitud_de_Indicio_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Solicitud_de_IndicioRowElement + "')){ Detalle_de_Solicitud_de_IndicioInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Solicitud_de_IndicioCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Solicitud_de_IndicioGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Solicitud_de_IndicioGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Solicitud_de_IndicioValidation();
    initiateUIControls();
    $('.Detalle_de_Solicitud_de_Indicio' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Solicitud_de_Indicio(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Solicitud_de_IndiciofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Solicitud_de_IndicioTable.fnGetData().length;
    Detalle_de_Solicitud_de_IndiciofnClickAddRow();
    GetAddDetalle_de_Solicitud_de_IndicioPopup(currentRowIndex, 0);
}

function Detalle_de_Solicitud_de_IndicioEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Solicitud_de_IndicioTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Solicitud_de_IndicioRowElement = "Detalle_de_Solicitud_de_Indicio_" + rowIndex.toString();
    var prevData = Detalle_de_Solicitud_de_IndicioTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Solicitud_de_IndicioPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Solicitud_de_IndicioFecha_de_Solicitud').val(prevData.Fecha_de_Solicitud);
    $('#Detalle_de_Solicitud_de_IndicioHora_de_Solicitud').val(prevData.Hora_de_Solicitud);
    $('#Detalle_de_Solicitud_de_IndicioNombre_del_Solicitante').val(prevData.Nombre_del_Solicitante);
    $('#Detalle_de_Solicitud_de_IndicioMotivo').val(prevData.Motivo);
    $('#Detalle_de_Solicitud_de_IndicioNumero_de_Indicio').val(prevData.Numero_de_Indicio);
    $('#Detalle_de_Solicitud_de_IndicioNombre_de_Indicio').val(prevData.Nombre_de_Indicio);
    $('#Detalle_de_Solicitud_de_IndicioDescripcion_de_Entrega_de_Indicio').val(prevData.Descripcion_de_Entrega_de_Indicio);
    $('#Detalle_de_Solicitud_de_IndicioDiligencia_que_Solicita').val(prevData.Diligencia_que_Solicita);

    initiateUIControls();










}

function Detalle_de_Solicitud_de_IndicioAddInsertRow() {
    if (Detalle_de_Solicitud_de_IndicioinsertRowCurrentIndex < 1)
    {
        Detalle_de_Solicitud_de_IndicioinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha_de_Solicitud: ""
        ,Hora_de_Solicitud: ""
        ,Nombre_del_Solicitante: ""
        ,Motivo: ""
        ,Numero_de_Indicio: ""
        ,Nombre_de_Indicio: ""
        ,Descripcion_de_Entrega_de_Indicio: ""
        ,Diligencia_que_Solicita: ""

    }
}

function Detalle_de_Solicitud_de_IndiciofnClickAddRow() {
    Detalle_de_Solicitud_de_IndiciocountRowsChecked++;
    Detalle_de_Solicitud_de_IndicioTable.fnAddData(Detalle_de_Solicitud_de_IndicioAddInsertRow(), true);
    Detalle_de_Solicitud_de_IndicioTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Solicitud_de_IndicioGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Solicitud_de_IndicioGrid tbody tr:nth-of-type(' + (Detalle_de_Solicitud_de_IndicioinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Solicitud_de_Indicio("Detalle_de_Solicitud_de_Indicio_", "_" + Detalle_de_Solicitud_de_IndicioinsertRowCurrentIndex);
}

function Detalle_de_Solicitud_de_IndicioClearGridData() {
    Detalle_de_Solicitud_de_IndicioData = [];
    Detalle_de_Solicitud_de_IndiciodeletedItem = [];
    Detalle_de_Solicitud_de_IndicioDataMain = [];
    Detalle_de_Solicitud_de_IndicioDataMainPages = [];
    Detalle_de_Solicitud_de_IndicionewItemCount = 0;
    Detalle_de_Solicitud_de_IndiciomaxItemIndex = 0;
    $("#Detalle_de_Solicitud_de_IndicioGrid").DataTable().clear();
    $("#Detalle_de_Solicitud_de_IndicioGrid").DataTable().destroy();
}

//Used to Get Indicios Information
function GetDetalle_de_Solicitud_de_Indicio() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Solicitud_de_IndicioData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Solicitud_de_IndicioData[i].Clave);

        form_data.append('[' + i + '].Fecha_de_Solicitud', Detalle_de_Solicitud_de_IndicioData[i].Fecha_de_Solicitud);
        form_data.append('[' + i + '].Hora_de_Solicitud', Detalle_de_Solicitud_de_IndicioData[i].Hora_de_Solicitud);
        form_data.append('[' + i + '].Nombre_del_Solicitante', Detalle_de_Solicitud_de_IndicioData[i].Nombre_del_Solicitante);
        form_data.append('[' + i + '].Motivo', Detalle_de_Solicitud_de_IndicioData[i].Motivo);
        form_data.append('[' + i + '].Numero_de_Indicio', Detalle_de_Solicitud_de_IndicioData[i].Numero_de_Indicio);
        form_data.append('[' + i + '].Nombre_de_Indicio', Detalle_de_Solicitud_de_IndicioData[i].Nombre_de_Indicio);
        form_data.append('[' + i + '].Descripcion_de_Entrega_de_Indicio', Detalle_de_Solicitud_de_IndicioData[i].Descripcion_de_Entrega_de_Indicio);
        form_data.append('[' + i + '].Diligencia_que_Solicita', Detalle_de_Solicitud_de_IndicioData[i].Diligencia_que_Solicita);

        form_data.append('[' + i + '].Removed', Detalle_de_Solicitud_de_IndicioData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Solicitud_de_IndicioInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_de_Indicio("Detalle_de_Solicitud_de_IndicioTable", rowIndex)) {
    var prevData = Detalle_de_Solicitud_de_IndicioTable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitud_de_IndicioTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha_de_Solicitud: $('#Detalle_de_Solicitud_de_IndicioFecha_de_Solicitud').val()
        ,Hora_de_Solicitud: $('#Detalle_de_Solicitud_de_IndicioHora_de_Solicitud').val()
        ,Nombre_del_Solicitante: $('#Detalle_de_Solicitud_de_IndicioNombre_del_Solicitante').val()
        ,Motivo: $('#Detalle_de_Solicitud_de_IndicioMotivo').val()
        ,Numero_de_Indicio: $('#Detalle_de_Solicitud_de_IndicioNumero_de_Indicio').val()
        ,Nombre_de_Indicio: $('#Detalle_de_Solicitud_de_IndicioNombre_de_Indicio').val()
        ,Descripcion_de_Entrega_de_Indicio: $('#Detalle_de_Solicitud_de_IndicioDescripcion_de_Entrega_de_Indicio').val()
        ,Diligencia_que_Solicita: $('#Detalle_de_Solicitud_de_IndicioDiligencia_que_Solicita').val()

    }

    Detalle_de_Solicitud_de_IndicioTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Solicitud_de_IndiciorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Solicitud_de_Indicio-form').modal({ show: false });
    $('#AddDetalle_de_Solicitud_de_Indicio-form').modal('hide');
    Detalle_de_Solicitud_de_IndicioEditRow(rowIndex);
    Detalle_de_Solicitud_de_IndicioInsertRow(rowIndex);
    //}
}
function Detalle_de_Solicitud_de_IndicioRemoveAddRow(rowIndex) {
    Detalle_de_Solicitud_de_IndicioTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Solicitud_de_Indicio MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Devolucion_de_Indicios MultiRow
var Detalle_de_Devolucion_de_IndicioscountRowsChecked = 0;




function GetDetalle_de_Devolucion_de_Indicios_Indicios_para_MPIName(Id) {
    for (var i = 0; i < Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIItems.length; i++) {
        if (Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIItems[i].Clave == Id) {
            return Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Devolucion_de_Indicios_Indicios_para_MPIDropDown() {
    var Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Devolucion_de_Indicios_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIDropdown);
    if(Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIItems != null)
    {
       for (var i = 0; i < Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIItems.length; i++) {
           $('<option />', { value: Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIItems[i].Clave, text:    Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIItems[i].Descripcion }).appendTo(Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIDropdown);
       }
    }
    return Detalle_de_Devolucion_de_Indicios_Indicios_para_MPIDropdown;
}


function GetDetalle_de_Devolucion_de_Indicios_Servicios_PericialesName(Id) {
    for (var i = 0; i < Detalle_de_Devolucion_de_Indicios_Servicios_PericialesItems.length; i++) {
        if (Detalle_de_Devolucion_de_Indicios_Servicios_PericialesItems[i].Clave == Id) {
            return Detalle_de_Devolucion_de_Indicios_Servicios_PericialesItems[i].Servicio;
        }
    }
    return "";
}

function GetDetalle_de_Devolucion_de_Indicios_Servicios_PericialesDropDown() {
    var Detalle_de_Devolucion_de_Indicios_Servicios_PericialesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Devolucion_de_Indicios_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Devolucion_de_Indicios_Servicios_PericialesDropdown);
    if(Detalle_de_Devolucion_de_Indicios_Servicios_PericialesItems != null)
    {
       for (var i = 0; i < Detalle_de_Devolucion_de_Indicios_Servicios_PericialesItems.length; i++) {
           $('<option />', { value: Detalle_de_Devolucion_de_Indicios_Servicios_PericialesItems[i].Clave, text:    Detalle_de_Devolucion_de_Indicios_Servicios_PericialesItems[i].Servicio }).appendTo(Detalle_de_Devolucion_de_Indicios_Servicios_PericialesDropdown);
       }
    }
    return Detalle_de_Devolucion_de_Indicios_Servicios_PericialesDropdown;
}


function GetInsertDetalle_de_Devolucion_de_IndiciosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Devolucion_de_Indicios_Fecha_de_Devolucion Fecha_de_Devolucion').attr('id', 'Detalle_de_Devolucion_de_Indicios_Fecha_de_Devolucion_' + index).attr('data-field', 'Fecha_de_Devolucion');
    columnData[1] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Devolucion_de_Indicios_Hora_de_Devolucion Hora_de_Devolucion').attr('id', 'Detalle_de_Devolucion_de_Indicios_Hora_de_Devolucion_' + index).attr('data-field', 'Hora_de_Devolucion');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Devolucion_de_Indicios_Nombre_de_Persona_que_Entrega Nombre_de_Persona_que_Entrega').attr('id', 'Detalle_de_Devolucion_de_Indicios_Nombre_de_Persona_que_Entrega_' + index).attr('data-field', 'Nombre_de_Persona_que_Entrega');
    columnData[3] = $(GetDetalle_de_Devolucion_de_Indicios_Indicios_para_MPIDropDown()).addClass('Detalle_de_Devolucion_de_Indicios_Numero_de_Indicio Numero_de_Indicio').attr('id', 'Detalle_de_Devolucion_de_Indicios_Numero_de_Indicio_' + index).attr('data-field', 'Numero_de_Indicio').after($.parseHTML(addNew('Detalle_de_Devolucion_de_Indicios', 'Indicios_para_MPI', 'Numero_de_Indicio', 264888)));
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_de_Devolucion_de_Indicios_Nombre_de_Indicio Nombre_de_Indicio').attr('id', 'Detalle_de_Devolucion_de_Indicios_Nombre_de_Indicio_' + index).attr('data-field', 'Nombre_de_Indicio');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_de_Devolucion_de_Indicios_Descripcion_de_Devolucion_de_Indicio Descripcion_de_Devolucion_de_Indicio').attr('id', 'Detalle_de_Devolucion_de_Indicios_Descripcion_de_Devolucion_de_Indicio_' + index).attr('data-field', 'Descripcion_de_Devolucion_de_Indicio');
    columnData[6] = $(GetDetalle_de_Devolucion_de_Indicios_Servicios_PericialesDropDown()).addClass('Detalle_de_Devolucion_de_Indicios_Diligencia_que_Devuelve Diligencia_que_Devuelve').attr('id', 'Detalle_de_Devolucion_de_Indicios_Diligencia_que_Devuelve_' + index).attr('data-field', 'Diligencia_que_Devuelve').after($.parseHTML(addNew('Detalle_de_Devolucion_de_Indicios', 'Servicios_Periciales', 'Diligencia_que_Devuelve', 264891)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_Devolucion_de_IndiciosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Devolucion_de_Indicios("Detalle_de_Devolucion_de_Indicios_", "_" + rowIndex)) {
    var iPage = Detalle_de_Devolucion_de_IndiciosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Devolucion_de_Indicios';
    var prevData = Detalle_de_Devolucion_de_IndiciosTable.fnGetData(rowIndex);
    var data = Detalle_de_Devolucion_de_IndiciosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha_de_Devolucion:  data.childNodes[counter++].childNodes[0].value
        ,Hora_de_Devolucion:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_de_Persona_que_Entrega:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_de_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion_de_Devolucion_de_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Diligencia_que_Devuelve:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Devolucion_de_IndiciosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Devolucion_de_IndiciosrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Devolucion_de_IndiciosTable.fnPageChange(iPage);
    Detalle_de_Devolucion_de_IndicioscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Devolucion_de_Indicios("Detalle_de_Devolucion_de_Indicios_", "_" + rowIndex);
  }
}

function Detalle_de_Devolucion_de_IndiciosCancelRow(rowIndex) {
    var prevData = Detalle_de_Devolucion_de_IndiciosTable.fnGetData(rowIndex);
    var data = Detalle_de_Devolucion_de_IndiciosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Devolucion_de_IndiciosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Devolucion_de_IndiciosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Devolucion_de_IndiciosGrid(Detalle_de_Devolucion_de_IndiciosTable.fnGetData());
    Detalle_de_Devolucion_de_IndicioscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Devolucion_de_IndiciosFromDataTable() {
    var Detalle_de_Devolucion_de_IndiciosData = [];
    var gridData = Detalle_de_Devolucion_de_IndiciosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Devolucion_de_IndiciosData.push({
                Clave: gridData[i].Clave

                ,Fecha_de_Devolucion: gridData[i].Fecha_de_Devolucion
                ,Hora_de_Devolucion: gridData[i].Hora_de_Devolucion
                ,Nombre_de_Persona_que_Entrega: gridData[i].Nombre_de_Persona_que_Entrega
                ,Numero_de_Indicio: gridData[i].Numero_de_Indicio
                ,Nombre_de_Indicio: gridData[i].Nombre_de_Indicio
                ,Descripcion_de_Devolucion_de_Indicio: gridData[i].Descripcion_de_Devolucion_de_Indicio
                ,Diligencia_que_Devuelve: gridData[i].Diligencia_que_Devuelve

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Devolucion_de_IndiciosData.length; i++) {
        if (removedDetalle_de_Devolucion_de_IndiciosData[i] != null && removedDetalle_de_Devolucion_de_IndiciosData[i].Clave > 0)
            Detalle_de_Devolucion_de_IndiciosData.push({
                Clave: removedDetalle_de_Devolucion_de_IndiciosData[i].Clave

                ,Fecha_de_Devolucion: removedDetalle_de_Devolucion_de_IndiciosData[i].Fecha_de_Devolucion
                ,Hora_de_Devolucion: removedDetalle_de_Devolucion_de_IndiciosData[i].Hora_de_Devolucion
                ,Nombre_de_Persona_que_Entrega: removedDetalle_de_Devolucion_de_IndiciosData[i].Nombre_de_Persona_que_Entrega
                ,Numero_de_Indicio: removedDetalle_de_Devolucion_de_IndiciosData[i].Numero_de_Indicio
                ,Nombre_de_Indicio: removedDetalle_de_Devolucion_de_IndiciosData[i].Nombre_de_Indicio
                ,Descripcion_de_Devolucion_de_Indicio: removedDetalle_de_Devolucion_de_IndiciosData[i].Descripcion_de_Devolucion_de_Indicio
                ,Diligencia_que_Devuelve: removedDetalle_de_Devolucion_de_IndiciosData[i].Diligencia_que_Devuelve

                , Removed: true
            });
    }	

    return Detalle_de_Devolucion_de_IndiciosData;
}

function Detalle_de_Devolucion_de_IndiciosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Devolucion_de_IndiciosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Devolucion_de_IndicioscountRowsChecked++;
    var Detalle_de_Devolucion_de_IndiciosRowElement = "Detalle_de_Devolucion_de_Indicios_" + rowIndex.toString();
    var prevData = Detalle_de_Devolucion_de_IndiciosTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Devolucion_de_IndiciosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Devolucion_de_Indicios_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Devolucion_de_IndiciosGetUpdateRowControls(prevData, "Detalle_de_Devolucion_de_Indicios_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Devolucion_de_IndiciosRowElement + "')){ Detalle_de_Devolucion_de_IndiciosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Devolucion_de_IndiciosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Devolucion_de_IndiciosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Devolucion_de_IndiciosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Devolucion_de_IndiciosValidation();
    initiateUIControls();
    $('.Detalle_de_Devolucion_de_Indicios' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Devolucion_de_Indicios(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Devolucion_de_IndiciosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Devolucion_de_IndiciosTable.fnGetData().length;
    Detalle_de_Devolucion_de_IndiciosfnClickAddRow();
    GetAddDetalle_de_Devolucion_de_IndiciosPopup(currentRowIndex, 0);
}

function Detalle_de_Devolucion_de_IndiciosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Devolucion_de_IndiciosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Devolucion_de_IndiciosRowElement = "Detalle_de_Devolucion_de_Indicios_" + rowIndex.toString();
    var prevData = Detalle_de_Devolucion_de_IndiciosTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Devolucion_de_IndiciosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Devolucion_de_IndiciosFecha_de_Devolucion').val(prevData.Fecha_de_Devolucion);
    $('#Detalle_de_Devolucion_de_IndiciosHora_de_Devolucion').val(prevData.Hora_de_Devolucion);
    $('#Detalle_de_Devolucion_de_IndiciosNombre_de_Persona_que_Entrega').val(prevData.Nombre_de_Persona_que_Entrega);
    $('#Detalle_de_Devolucion_de_IndiciosNumero_de_Indicio').val(prevData.Numero_de_Indicio);
    $('#Detalle_de_Devolucion_de_IndiciosNombre_de_Indicio').val(prevData.Nombre_de_Indicio);
    $('#Detalle_de_Devolucion_de_IndiciosDescripcion_de_Devolucion_de_Indicio').val(prevData.Descripcion_de_Devolucion_de_Indicio);
    $('#Detalle_de_Devolucion_de_IndiciosDiligencia_que_Devuelve').val(prevData.Diligencia_que_Devuelve);

    initiateUIControls();









}

function Detalle_de_Devolucion_de_IndiciosAddInsertRow() {
    if (Detalle_de_Devolucion_de_IndiciosinsertRowCurrentIndex < 1)
    {
        Detalle_de_Devolucion_de_IndiciosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha_de_Devolucion: ""
        ,Hora_de_Devolucion: ""
        ,Nombre_de_Persona_que_Entrega: ""
        ,Numero_de_Indicio: ""
        ,Nombre_de_Indicio: ""
        ,Descripcion_de_Devolucion_de_Indicio: ""
        ,Diligencia_que_Devuelve: ""

    }
}

function Detalle_de_Devolucion_de_IndiciosfnClickAddRow() {
    Detalle_de_Devolucion_de_IndicioscountRowsChecked++;
    Detalle_de_Devolucion_de_IndiciosTable.fnAddData(Detalle_de_Devolucion_de_IndiciosAddInsertRow(), true);
    Detalle_de_Devolucion_de_IndiciosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Devolucion_de_IndiciosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Devolucion_de_IndiciosGrid tbody tr:nth-of-type(' + (Detalle_de_Devolucion_de_IndiciosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Devolucion_de_Indicios("Detalle_de_Devolucion_de_Indicios_", "_" + Detalle_de_Devolucion_de_IndiciosinsertRowCurrentIndex);
}

function Detalle_de_Devolucion_de_IndiciosClearGridData() {
    Detalle_de_Devolucion_de_IndiciosData = [];
    Detalle_de_Devolucion_de_IndiciosdeletedItem = [];
    Detalle_de_Devolucion_de_IndiciosDataMain = [];
    Detalle_de_Devolucion_de_IndiciosDataMainPages = [];
    Detalle_de_Devolucion_de_IndiciosnewItemCount = 0;
    Detalle_de_Devolucion_de_IndiciosmaxItemIndex = 0;
    $("#Detalle_de_Devolucion_de_IndiciosGrid").DataTable().clear();
    $("#Detalle_de_Devolucion_de_IndiciosGrid").DataTable().destroy();
}

//Used to Get Indicios Information
function GetDetalle_de_Devolucion_de_Indicios() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Devolucion_de_IndiciosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Devolucion_de_IndiciosData[i].Clave);

        form_data.append('[' + i + '].Fecha_de_Devolucion', Detalle_de_Devolucion_de_IndiciosData[i].Fecha_de_Devolucion);
        form_data.append('[' + i + '].Hora_de_Devolucion', Detalle_de_Devolucion_de_IndiciosData[i].Hora_de_Devolucion);
        form_data.append('[' + i + '].Nombre_de_Persona_que_Entrega', Detalle_de_Devolucion_de_IndiciosData[i].Nombre_de_Persona_que_Entrega);
        form_data.append('[' + i + '].Numero_de_Indicio', Detalle_de_Devolucion_de_IndiciosData[i].Numero_de_Indicio);
        form_data.append('[' + i + '].Nombre_de_Indicio', Detalle_de_Devolucion_de_IndiciosData[i].Nombre_de_Indicio);
        form_data.append('[' + i + '].Descripcion_de_Devolucion_de_Indicio', Detalle_de_Devolucion_de_IndiciosData[i].Descripcion_de_Devolucion_de_Indicio);
        form_data.append('[' + i + '].Diligencia_que_Devuelve', Detalle_de_Devolucion_de_IndiciosData[i].Diligencia_que_Devuelve);

        form_data.append('[' + i + '].Removed', Detalle_de_Devolucion_de_IndiciosData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Devolucion_de_IndiciosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Devolucion_de_Indicios("Detalle_de_Devolucion_de_IndiciosTable", rowIndex)) {
    var prevData = Detalle_de_Devolucion_de_IndiciosTable.fnGetData(rowIndex);
    var data = Detalle_de_Devolucion_de_IndiciosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha_de_Devolucion: $('#Detalle_de_Devolucion_de_IndiciosFecha_de_Devolucion').val()
        ,Hora_de_Devolucion: $('#Detalle_de_Devolucion_de_IndiciosHora_de_Devolucion').val()
        ,Nombre_de_Persona_que_Entrega: $('#Detalle_de_Devolucion_de_IndiciosNombre_de_Persona_que_Entrega').val()
        ,Numero_de_Indicio: $('#Detalle_de_Devolucion_de_IndiciosNumero_de_Indicio').val()
        ,Nombre_de_Indicio: $('#Detalle_de_Devolucion_de_IndiciosNombre_de_Indicio').val()
        ,Descripcion_de_Devolucion_de_Indicio: $('#Detalle_de_Devolucion_de_IndiciosDescripcion_de_Devolucion_de_Indicio').val()
        ,Diligencia_que_Devuelve: $('#Detalle_de_Devolucion_de_IndiciosDiligencia_que_Devuelve').val()

    }

    Detalle_de_Devolucion_de_IndiciosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Devolucion_de_IndiciosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Devolucion_de_Indicios-form').modal({ show: false });
    $('#AddDetalle_de_Devolucion_de_Indicios-form').modal('hide');
    Detalle_de_Devolucion_de_IndiciosEditRow(rowIndex);
    Detalle_de_Devolucion_de_IndiciosInsertRow(rowIndex);
    //}
}
function Detalle_de_Devolucion_de_IndiciosRemoveAddRow(rowIndex) {
    Detalle_de_Devolucion_de_IndiciosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Devolucion_de_Indicios MultiRow


$(function () {
    function Detalle_del_IndicioinitializeMainArray(totalCount) {
        if (Detalle_del_IndicioDataMain.length != totalCount && !Detalle_del_IndicioDataMainInitialized) {
            Detalle_del_IndicioDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_del_IndicioDataMain[i] = null;
            }
        }
    }
    function Detalle_del_IndicioremoveFromMainArray() {
        for (var j = 0; j < Detalle_del_IndiciodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_del_IndicioDataMain.length; i++) {
                if (Detalle_del_IndicioDataMain[i] != null && Detalle_del_IndicioDataMain[i].Id == Detalle_del_IndiciodeletedItem[j]) {
                    hDetalle_del_IndicioDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_del_IndiciocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_del_IndicioDataMain.length; i++) {
            data[i] = Detalle_del_IndicioDataMain[i];

        }
        return data;
    }
    function Detalle_del_IndiciogetNewResult() {
        var newData = copyMainDetalle_del_IndicioArray();

        for (var i = 0; i < Detalle_del_IndicioData.length; i++) {
            if (Detalle_del_IndicioData[i].Removed == null || Detalle_del_IndicioData[i].Removed == false) {
                newData.splice(0, 0, Detalle_del_IndicioData[i]);
            }
        }
        return newData;
    }
    function Detalle_del_IndiciopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_del_IndicioDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_del_IndicioDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Solicitud_de_IndicioinitializeMainArray(totalCount) {
        if (Detalle_de_Solicitud_de_IndicioDataMain.length != totalCount && !Detalle_de_Solicitud_de_IndicioDataMainInitialized) {
            Detalle_de_Solicitud_de_IndicioDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Solicitud_de_IndicioDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Solicitud_de_IndicioremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Solicitud_de_IndiciodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Solicitud_de_IndicioDataMain.length; i++) {
                if (Detalle_de_Solicitud_de_IndicioDataMain[i] != null && Detalle_de_Solicitud_de_IndicioDataMain[i].Id == Detalle_de_Solicitud_de_IndiciodeletedItem[j]) {
                    hDetalle_de_Solicitud_de_IndicioDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Solicitud_de_IndiciocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Solicitud_de_IndicioDataMain.length; i++) {
            data[i] = Detalle_de_Solicitud_de_IndicioDataMain[i];

        }
        return data;
    }
    function Detalle_de_Solicitud_de_IndiciogetNewResult() {
        var newData = copyMainDetalle_de_Solicitud_de_IndicioArray();

        for (var i = 0; i < Detalle_de_Solicitud_de_IndicioData.length; i++) {
            if (Detalle_de_Solicitud_de_IndicioData[i].Removed == null || Detalle_de_Solicitud_de_IndicioData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Solicitud_de_IndicioData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Solicitud_de_IndiciopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Solicitud_de_IndicioDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Solicitud_de_IndicioDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Devolucion_de_IndiciosinitializeMainArray(totalCount) {
        if (Detalle_de_Devolucion_de_IndiciosDataMain.length != totalCount && !Detalle_de_Devolucion_de_IndiciosDataMainInitialized) {
            Detalle_de_Devolucion_de_IndiciosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Devolucion_de_IndiciosDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Devolucion_de_IndiciosremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Devolucion_de_IndiciosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Devolucion_de_IndiciosDataMain.length; i++) {
                if (Detalle_de_Devolucion_de_IndiciosDataMain[i] != null && Detalle_de_Devolucion_de_IndiciosDataMain[i].Id == Detalle_de_Devolucion_de_IndiciosdeletedItem[j]) {
                    hDetalle_de_Devolucion_de_IndiciosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Devolucion_de_IndicioscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Devolucion_de_IndiciosDataMain.length; i++) {
            data[i] = Detalle_de_Devolucion_de_IndiciosDataMain[i];

        }
        return data;
    }
    function Detalle_de_Devolucion_de_IndiciosgetNewResult() {
        var newData = copyMainDetalle_de_Devolucion_de_IndiciosArray();

        for (var i = 0; i < Detalle_de_Devolucion_de_IndiciosData.length; i++) {
            if (Detalle_de_Devolucion_de_IndiciosData[i].Removed == null || Detalle_de_Devolucion_de_IndiciosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Devolucion_de_IndiciosData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Devolucion_de_IndiciospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Devolucion_de_IndiciosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Devolucion_de_IndiciosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompleteIndicios_Usuario_que_Registra_Spartan_UserData(data) {
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

//Grid GetAutocomplete

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Indicios_cmbLabelSelect").val();
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
    $('#CreateIndicios')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_del_IndicioClearGridData();
                Detalle_de_Solicitud_de_IndicioClearGridData();
                Detalle_de_Devolucion_de_IndiciosClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateIndicios').trigger('reset');
    $('#CreateIndicios').find(':input').each(function () {
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
    var $myForm = $('#CreateIndicios');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_del_IndiciocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_del_Indicio();
        return false;
    }
    if (Detalle_de_Solicitud_de_IndiciocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Solicitud_de_Indicio();
        return false;
    }
    if (Detalle_de_Devolucion_de_IndicioscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Devolucion_de_Indicios();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateIndicios").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateIndicios").on('click', '#IndiciosCancelar', function () {
	  if (!isPartial) {
        IndiciosBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateIndicios").on('click', '#IndiciosGuardar', function () {
		$('#IndiciosGuardar').attr('disabled', true);
		$('#IndiciosGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendIndiciosData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						IndiciosBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#IndiciosGuardar').removeAttr('disabled');
                        $('#IndiciosGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Indicios', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_IndiciosItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_IndiciosDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#IndiciosGuardar').removeAttr('disabled');
					$('#IndiciosGuardar').bind()
				}
		}
		else {
			$('#IndiciosGuardar').removeAttr('disabled');
			$('#IndiciosGuardar').bind()
		}
    });
	$("form#CreateIndicios").on('click', '#IndiciosGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendIndiciosData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_del_IndicioData();
                getDetalle_de_Solicitud_de_IndicioData();
                getDetalle_de_Devolucion_de_IndiciosData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Indicios', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_IndiciosItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_IndiciosDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateIndicios").on('click', '#IndiciosGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendIndiciosData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_del_IndicioClearGridData();
                Detalle_de_Solicitud_de_IndicioClearGridData();
                Detalle_de_Devolucion_de_IndiciosClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_del_IndicioData();
                getDetalle_de_Solicitud_de_IndicioData();
                getDetalle_de_Devolucion_de_IndiciosData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Indicios',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_IndiciosItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_IndiciosDropDown().get(0)').innerHTML);                          
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



var IndiciosisdisplayBusinessPropery = false;
IndiciosDisplayBusinessRuleButtons(IndiciosisdisplayBusinessPropery);
function IndiciosDisplayBusinessRule() {
    if (!IndiciosisdisplayBusinessPropery) {
        $('#CreateIndicios').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="IndiciosdisplayBusinessPropery"><button onclick="IndiciosGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#IndiciosBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.IndiciosdisplayBusinessPropery').remove();
    }
    IndiciosDisplayBusinessRuleButtons(!IndiciosisdisplayBusinessPropery);
    IndiciosisdisplayBusinessPropery = (IndiciosisdisplayBusinessPropery ? false : true);
}
function IndiciosDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

