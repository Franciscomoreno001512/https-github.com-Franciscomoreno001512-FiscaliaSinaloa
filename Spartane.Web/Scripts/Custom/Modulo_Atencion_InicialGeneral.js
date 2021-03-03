

//Begin Declarations for Foreigns fields for Detalle_de_coincidencias_a MultiRow
var Detalle_de_coincidencias_acountRowsChecked = 0;







function GetInsertDetalle_de_coincidencias_aRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_coincidencias_a_Nombre_Completo Nombre_Completo').attr('id', 'Detalle_de_coincidencias_a_Nombre_Completo_' + index).attr('data-field', 'Nombre_Completo');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_coincidencias_a_Alias Alias').attr('id', 'Detalle_de_coincidencias_a_Alias_' + index).attr('data-field', 'Alias');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_coincidencias_a_NUAT NUAT').attr('id', 'Detalle_de_coincidencias_a_NUAT_' + index).attr('data-field', 'NUAT');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_coincidencias_a_Fuente_de_Origen Fuente_de_Origen').attr('id', 'Detalle_de_coincidencias_a_Fuente_de_Origen_' + index).attr('data-field', 'Fuente_de_Origen');


    initiateUIControls();
    return columnData;
}

function Detalle_de_coincidencias_aInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_coincidencias_a("Detalle_de_coincidencias_a_", "_" + rowIndex)) {
    var iPage = Detalle_de_coincidencias_aTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_coincidencias_a';
    var prevData = Detalle_de_coincidencias_aTable.fnGetData(rowIndex);
    var data = Detalle_de_coincidencias_aTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre_Completo:  data.childNodes[counter++].childNodes[0].value
        ,Alias:  data.childNodes[counter++].childNodes[0].value
        ,NUAT:  data.childNodes[counter++].childNodes[0].value
        ,Fuente_de_Origen:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_coincidencias_aTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_coincidencias_arowCreationGrid(data, newData, rowIndex);
    Detalle_de_coincidencias_aTable.fnPageChange(iPage);
    Detalle_de_coincidencias_acountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_coincidencias_a("Detalle_de_coincidencias_a_", "_" + rowIndex);
  }
}

function Detalle_de_coincidencias_aCancelRow(rowIndex) {
    var prevData = Detalle_de_coincidencias_aTable.fnGetData(rowIndex);
    var data = Detalle_de_coincidencias_aTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_coincidencias_aTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_coincidencias_arowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_coincidencias_aGrid(Detalle_de_coincidencias_aTable.fnGetData());
    Detalle_de_coincidencias_acountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_coincidencias_aFromDataTable() {
    var Detalle_de_coincidencias_aData = [];
    var gridData = Detalle_de_coincidencias_aTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_coincidencias_aData.push({
                Clave: gridData[i].Clave

                ,Nombre_Completo: gridData[i].Nombre_Completo
                ,Alias: gridData[i].Alias
                ,NUAT: gridData[i].NUAT
                ,Fuente_de_Origen: gridData[i].Fuente_de_Origen

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_coincidencias_aData.length; i++) {
        if (removedDetalle_de_coincidencias_aData[i] != null && removedDetalle_de_coincidencias_aData[i].Clave > 0)
            Detalle_de_coincidencias_aData.push({
                Clave: removedDetalle_de_coincidencias_aData[i].Clave

                ,Nombre_Completo: removedDetalle_de_coincidencias_aData[i].Nombre_Completo
                ,Alias: removedDetalle_de_coincidencias_aData[i].Alias
                ,NUAT: removedDetalle_de_coincidencias_aData[i].NUAT
                ,Fuente_de_Origen: removedDetalle_de_coincidencias_aData[i].Fuente_de_Origen

                , Removed: true
            });
    }	

    return Detalle_de_coincidencias_aData;
}

function Detalle_de_coincidencias_aEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_coincidencias_aTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_coincidencias_acountRowsChecked++;
    var Detalle_de_coincidencias_aRowElement = "Detalle_de_coincidencias_a_" + rowIndex.toString();
    var prevData = Detalle_de_coincidencias_aTable.fnGetData(rowIndexTable );
    var row = Detalle_de_coincidencias_aTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_coincidencias_a_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_coincidencias_aGetUpdateRowControls(prevData, "Detalle_de_coincidencias_a_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_coincidencias_aRowElement + "')){ Detalle_de_coincidencias_aInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_coincidencias_aCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_coincidencias_aGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_coincidencias_aGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_coincidencias_aValidation();
    initiateUIControls();
    $('.Detalle_de_coincidencias_a' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_coincidencias_a(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_coincidencias_afnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_coincidencias_aTable.fnGetData().length;
    Detalle_de_coincidencias_afnClickAddRow();
    GetAddDetalle_de_coincidencias_aPopup(currentRowIndex, 0);
}

function Detalle_de_coincidencias_aEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_coincidencias_aTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_coincidencias_aRowElement = "Detalle_de_coincidencias_a_" + rowIndex.toString();
    var prevData = Detalle_de_coincidencias_aTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_coincidencias_aPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_coincidencias_aNombre_Completo').val(prevData.Nombre_Completo);
    $('#Detalle_de_coincidencias_aAlias').val(prevData.Alias);
    $('#Detalle_de_coincidencias_aNUAT').val(prevData.NUAT);
    $('#Detalle_de_coincidencias_aFuente_de_Origen').val(prevData.Fuente_de_Origen);

    initiateUIControls();






}

function Detalle_de_coincidencias_aAddInsertRow() {
    if (Detalle_de_coincidencias_ainsertRowCurrentIndex < 1)
    {
        Detalle_de_coincidencias_ainsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre_Completo: ""
        ,Alias: ""
        ,NUAT: ""
        ,Fuente_de_Origen: ""

    }
}

function Detalle_de_coincidencias_afnClickAddRow() {
    Detalle_de_coincidencias_acountRowsChecked++;
    Detalle_de_coincidencias_aTable.fnAddData(Detalle_de_coincidencias_aAddInsertRow(), true);
    Detalle_de_coincidencias_aTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_coincidencias_aGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_coincidencias_aGrid tbody tr:nth-of-type(' + (Detalle_de_coincidencias_ainsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_coincidencias_a("Detalle_de_coincidencias_a_", "_" + Detalle_de_coincidencias_ainsertRowCurrentIndex);
}

function Detalle_de_coincidencias_aClearGridData() {
    Detalle_de_coincidencias_aData = [];
    Detalle_de_coincidencias_adeletedItem = [];
    Detalle_de_coincidencias_aDataMain = [];
    Detalle_de_coincidencias_aDataMainPages = [];
    Detalle_de_coincidencias_anewItemCount = 0;
    Detalle_de_coincidencias_amaxItemIndex = 0;
    $("#Detalle_de_coincidencias_aGrid").DataTable().clear();
    $("#Detalle_de_coincidencias_aGrid").DataTable().destroy();
}

//Used to Get Atención Inicial Information
function GetDetalle_de_coincidencias_a() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_coincidencias_aData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_coincidencias_aData[i].Clave);

        form_data.append('[' + i + '].Nombre_Completo', Detalle_de_coincidencias_aData[i].Nombre_Completo);
        form_data.append('[' + i + '].Alias', Detalle_de_coincidencias_aData[i].Alias);
        form_data.append('[' + i + '].NUAT', Detalle_de_coincidencias_aData[i].NUAT);
        form_data.append('[' + i + '].Fuente_de_Origen', Detalle_de_coincidencias_aData[i].Fuente_de_Origen);

        form_data.append('[' + i + '].Removed', Detalle_de_coincidencias_aData[i].Removed);
    }
    return form_data;
}
function Detalle_de_coincidencias_aInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_coincidencias_a("Detalle_de_coincidencias_aTable", rowIndex)) {
    var prevData = Detalle_de_coincidencias_aTable.fnGetData(rowIndex);
    var data = Detalle_de_coincidencias_aTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre_Completo: $('#Detalle_de_coincidencias_aNombre_Completo').val()
        ,Alias: $('#Detalle_de_coincidencias_aAlias').val()
        ,NUAT: $('#Detalle_de_coincidencias_aNUAT').val()
        ,Fuente_de_Origen: $('#Detalle_de_coincidencias_aFuente_de_Origen').val()

    }

    Detalle_de_coincidencias_aTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_coincidencias_arowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_coincidencias_a-form').modal({ show: false });
    $('#AddDetalle_de_coincidencias_a-form').modal('hide');
    Detalle_de_coincidencias_aEditRow(rowIndex);
    Detalle_de_coincidencias_aInsertRow(rowIndex);
    //}
}
function Detalle_de_coincidencias_aRemoveAddRow(rowIndex) {
    Detalle_de_coincidencias_aTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_coincidencias_a MultiRow
//Begin Declarations for Foreigns fields for Detalle_Historico_MPO MultiRow
var Detalle_Historico_MPOcountRowsChecked = 0;







function GetInsertDetalle_Historico_MPORowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_Historico_MPO_Fecha Fecha').attr('id', 'Detalle_Historico_MPO_Fecha_' + index).attr('data-field', 'Fecha');
    columnData[1] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_Historico_MPO_Hora Hora').attr('id', 'Detalle_Historico_MPO_Hora_' + index).attr('data-field', 'Hora');
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Historico_MPO_Usuario Usuario').attr('id', 'Detalle_Historico_MPO_Usuario_' + index).attr('data-field', 'Usuario');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Historico_MPO_Estatus Estatus').attr('id', 'Detalle_Historico_MPO_Estatus_' + index).attr('data-field', 'Estatus');


    initiateUIControls();
    return columnData;
}

function Detalle_Historico_MPOInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Historico_MPO("Detalle_Historico_MPO_", "_" + rowIndex)) {
    var iPage = Detalle_Historico_MPOTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Historico_MPO';
    var prevData = Detalle_Historico_MPOTable.fnGetData(rowIndex);
    var data = Detalle_Historico_MPOTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha:  data.childNodes[counter++].childNodes[0].value
        ,Hora:  data.childNodes[counter++].childNodes[0].value
        ,Usuario: data.childNodes[counter++].childNodes[0].value
        ,Estatus:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Historico_MPOTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Historico_MPOrowCreationGrid(data, newData, rowIndex);
    Detalle_Historico_MPOTable.fnPageChange(iPage);
    Detalle_Historico_MPOcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Historico_MPO("Detalle_Historico_MPO_", "_" + rowIndex);
  }
}

function Detalle_Historico_MPOCancelRow(rowIndex) {
    var prevData = Detalle_Historico_MPOTable.fnGetData(rowIndex);
    var data = Detalle_Historico_MPOTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Historico_MPOTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Historico_MPOrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Historico_MPOGrid(Detalle_Historico_MPOTable.fnGetData());
    Detalle_Historico_MPOcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Historico_MPOFromDataTable() {
    var Detalle_Historico_MPOData = [];
    var gridData = Detalle_Historico_MPOTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Historico_MPOData.push({
                Clave: gridData[i].Clave

                ,Fecha: gridData[i].Fecha
                ,Hora: gridData[i].Hora
                ,Usuario: gridData[i].Usuario
                ,Estatus: gridData[i].Estatus

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Historico_MPOData.length; i++) {
        if (removedDetalle_Historico_MPOData[i] != null && removedDetalle_Historico_MPOData[i].Clave > 0)
            Detalle_Historico_MPOData.push({
                Clave: removedDetalle_Historico_MPOData[i].Clave

                ,Fecha: removedDetalle_Historico_MPOData[i].Fecha
                ,Hora: removedDetalle_Historico_MPOData[i].Hora
                ,Usuario: removedDetalle_Historico_MPOData[i].Usuario
                ,Estatus: removedDetalle_Historico_MPOData[i].Estatus

                , Removed: true
            });
    }	

    return Detalle_Historico_MPOData;
}

function Detalle_Historico_MPOEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Historico_MPOTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Historico_MPOcountRowsChecked++;
    var Detalle_Historico_MPORowElement = "Detalle_Historico_MPO_" + rowIndex.toString();
    var prevData = Detalle_Historico_MPOTable.fnGetData(rowIndexTable );
    var row = Detalle_Historico_MPOTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Historico_MPO_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Historico_MPOGetUpdateRowControls(prevData, "Detalle_Historico_MPO_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Historico_MPORowElement + "')){ Detalle_Historico_MPOInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Historico_MPOCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Historico_MPOGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Historico_MPOGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Historico_MPOValidation();
    initiateUIControls();
    $('.Detalle_Historico_MPO' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Historico_MPO(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Historico_MPOfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Historico_MPOTable.fnGetData().length;
    Detalle_Historico_MPOfnClickAddRow();
    GetAddDetalle_Historico_MPOPopup(currentRowIndex, 0);
}

function Detalle_Historico_MPOEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Historico_MPOTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Historico_MPORowElement = "Detalle_Historico_MPO_" + rowIndex.toString();
    var prevData = Detalle_Historico_MPOTable.fnGetData(rowIndexTable);
    GetAddDetalle_Historico_MPOPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Historico_MPOFecha').val(prevData.Fecha);
    $('#Detalle_Historico_MPOHora').val(prevData.Hora);
    $('#Detalle_Historico_MPOUsuario').val(prevData.Usuario);
    $('#Detalle_Historico_MPOEstatus').val(prevData.Estatus);

    initiateUIControls();






}

function Detalle_Historico_MPOAddInsertRow() {
    if (Detalle_Historico_MPOinsertRowCurrentIndex < 1)
    {
        Detalle_Historico_MPOinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha: ""
        ,Hora: ""
        ,Usuario: ""
        ,Estatus: ""

    }
}

function Detalle_Historico_MPOfnClickAddRow() {
    Detalle_Historico_MPOcountRowsChecked++;
    Detalle_Historico_MPOTable.fnAddData(Detalle_Historico_MPOAddInsertRow(), true);
    Detalle_Historico_MPOTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Historico_MPOGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Historico_MPOGrid tbody tr:nth-of-type(' + (Detalle_Historico_MPOinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Historico_MPO("Detalle_Historico_MPO_", "_" + Detalle_Historico_MPOinsertRowCurrentIndex);
}

function Detalle_Historico_MPOClearGridData() {
    Detalle_Historico_MPOData = [];
    Detalle_Historico_MPOdeletedItem = [];
    Detalle_Historico_MPODataMain = [];
    Detalle_Historico_MPODataMainPages = [];
    Detalle_Historico_MPOnewItemCount = 0;
    Detalle_Historico_MPOmaxItemIndex = 0;
    $("#Detalle_Historico_MPOGrid").DataTable().clear();
    $("#Detalle_Historico_MPOGrid").DataTable().destroy();
}

//Used to Get Atención Inicial Information
function GetDetalle_Historico_MPO() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Historico_MPOData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Historico_MPOData[i].Clave);

        form_data.append('[' + i + '].Fecha', Detalle_Historico_MPOData[i].Fecha);
        form_data.append('[' + i + '].Hora', Detalle_Historico_MPOData[i].Hora);
        form_data.append('[' + i + '].Usuario', Detalle_Historico_MPOData[i].Usuario);
        form_data.append('[' + i + '].Estatus', Detalle_Historico_MPOData[i].Estatus);

        form_data.append('[' + i + '].Removed', Detalle_Historico_MPOData[i].Removed);
    }
    return form_data;
}
function Detalle_Historico_MPOInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Historico_MPO("Detalle_Historico_MPOTable", rowIndex)) {
    var prevData = Detalle_Historico_MPOTable.fnGetData(rowIndex);
    var data = Detalle_Historico_MPOTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha: $('#Detalle_Historico_MPOFecha').val()
        ,Hora: $('#Detalle_Historico_MPOHora').val()
        ,Usuario: $('#Detalle_Historico_MPOUsuario').val()

        ,Estatus: $('#Detalle_Historico_MPOEstatus').val()

    }

    Detalle_Historico_MPOTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Historico_MPOrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Historico_MPO-form').modal({ show: false });
    $('#AddDetalle_Historico_MPO-form').modal('hide');
    Detalle_Historico_MPOEditRow(rowIndex);
    Detalle_Historico_MPOInsertRow(rowIndex);
    //}
}
function Detalle_Historico_MPORemoveAddRow(rowIndex) {
    Detalle_Historico_MPOTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Historico_MPO MultiRow


$(function () {
    function Detalle_de_coincidencias_ainitializeMainArray(totalCount) {
        if (Detalle_de_coincidencias_aDataMain.length != totalCount && !Detalle_de_coincidencias_aDataMainInitialized) {
            Detalle_de_coincidencias_aDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_coincidencias_aDataMain[i] = null;
            }
        }
    }
    function Detalle_de_coincidencias_aremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_coincidencias_adeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_coincidencias_aDataMain.length; i++) {
                if (Detalle_de_coincidencias_aDataMain[i] != null && Detalle_de_coincidencias_aDataMain[i].Id == Detalle_de_coincidencias_adeletedItem[j]) {
                    hDetalle_de_coincidencias_aDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_coincidencias_acopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_coincidencias_aDataMain.length; i++) {
            data[i] = Detalle_de_coincidencias_aDataMain[i];

        }
        return data;
    }
    function Detalle_de_coincidencias_agetNewResult() {
        var newData = copyMainDetalle_de_coincidencias_aArray();

        for (var i = 0; i < Detalle_de_coincidencias_aData.length; i++) {
            if (Detalle_de_coincidencias_aData[i].Removed == null || Detalle_de_coincidencias_aData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_coincidencias_aData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_coincidencias_apushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_coincidencias_aDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_coincidencias_aDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Historico_MPOinitializeMainArray(totalCount) {
        if (Detalle_Historico_MPODataMain.length != totalCount && !Detalle_Historico_MPODataMainInitialized) {
            Detalle_Historico_MPODataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Historico_MPODataMain[i] = null;
            }
        }
    }
    function Detalle_Historico_MPOremoveFromMainArray() {
        for (var j = 0; j < Detalle_Historico_MPOdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Historico_MPODataMain.length; i++) {
                if (Detalle_Historico_MPODataMain[i] != null && Detalle_Historico_MPODataMain[i].Id == Detalle_Historico_MPOdeletedItem[j]) {
                    hDetalle_Historico_MPODataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Historico_MPOcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Historico_MPODataMain.length; i++) {
            data[i] = Detalle_Historico_MPODataMain[i];

        }
        return data;
    }
    function Detalle_Historico_MPOgetNewResult() {
        var newData = copyMainDetalle_Historico_MPOArray();

        for (var i = 0; i < Detalle_Historico_MPOData.length; i++) {
            if (Detalle_Historico_MPOData[i].Removed == null || Detalle_Historico_MPOData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Historico_MPOData[i]);
            }
        }
        return newData;
    }
    function Detalle_Historico_MPOpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Historico_MPODataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Historico_MPODataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteTurno_AsignadoData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Turno_Asignado_Asignacion_de_TurnosData(data) {
	AutoCompleteTurno_AsignadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteTurno_AsignadoData.push({
            id: data[i].Folio,
            text: data[i].Numero_de_Turno
        });
    }
    return AutoCompleteTurno_AsignadoData;
}
var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Usuario_que_Registra_Spartan_UserData(data) {
	AutoCompleteUsuario_que_RegistraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_RegistraData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_RegistraData;
}
var AutoCompleteMunicipioData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Municipio_MunicipioData(data) {
	AutoCompleteMunicipioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioData;
}
var AutoCompleteMinisterio_Publico_en_TurnoData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_SistemaData(data) {
	AutoCompleteMinisterio_Publico_en_TurnoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMinisterio_Publico_en_TurnoData.push({
            id: data[i].Clave,
            text: data[i].Ministerio_Publico_en_Turno
        });
    }
    return AutoCompleteMinisterio_Publico_en_TurnoData;
}
var AutoCompleteSolicitud_de_Denuncia_CiudadanaData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_CiudadanaData(data) {
	AutoCompleteSolicitud_de_Denuncia_CiudadanaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteSolicitud_de_Denuncia_CiudadanaData.push({
            id: data[i].Clave,
            text: data[i].Folio
        });
    }
    return AutoCompleteSolicitud_de_Denuncia_CiudadanaData;
}
var AutoCompleteOrientadorData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Orientador_Spartan_UserData(data) {
	AutoCompleteOrientadorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteOrientadorData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteOrientadorData;
}
var AutoCompletePais_de_los_HechosData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Pais_de_los_Hechos_PaisData(data) {
	AutoCompletePais_de_los_HechosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_de_los_HechosData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_de_los_HechosData;
}
var AutoCompleteEstado_de_los_HechosData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Estado_de_los_Hechos_EstadoData(data) {
	AutoCompleteEstado_de_los_HechosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_de_los_HechosData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_de_los_HechosData;
}
var AutoCompleteMunicipio_de_los_HechosData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Municipio_de_los_Hechos_MunicipioData(data) {
	AutoCompleteMunicipio_de_los_HechosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_de_los_HechosData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_de_los_HechosData;
}
var AutoCompletePoblacionData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Poblacion_ColoniaData(data) {
	AutoCompletePoblacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePoblacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePoblacionData;
}
var AutoCompleteColonia_de_los_HechosData = [];
function GetAutoCompleteModulo_Atencion_Inicial_Colonia_de_los_Hechos_ColoniaData(data) {
	AutoCompleteColonia_de_los_HechosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_de_los_HechosData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_de_los_HechosData;
}
//Grid GetAutocomplete

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Modulo_Atencion_Inicial_cmbLabelSelect").val();
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
    $('#CreateModulo_Atencion_Inicial')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Turno_Asignado').empty();
    $("#Turno_Asignado").append('<option value=""></option>');
    $('#Turno_Asignado').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Ministerio_Publico_en_Turno').empty();
    $("#Ministerio_Publico_en_Turno").append('<option value=""></option>');
    $('#Ministerio_Publico_en_Turno').val('0').trigger('change');
    $('#Solicitud_de_Denuncia_Ciudadana').empty();
    $("#Solicitud_de_Denuncia_Ciudadana").append('<option value=""></option>');
    $('#Solicitud_de_Denuncia_Ciudadana').val('0').trigger('change');
    $('#Orientador').empty();
    $("#Orientador").append('<option value=""></option>');
    $('#Orientador').val('0').trigger('change');
    $('#Pais_de_los_Hechos').empty();
    $("#Pais_de_los_Hechos").append('<option value=""></option>');
    $('#Pais_de_los_Hechos').val('0').trigger('change');
    $('#Estado_de_los_Hechos').empty();
    $("#Estado_de_los_Hechos").append('<option value=""></option>');
    $('#Estado_de_los_Hechos').val('0').trigger('change');
    $('#Municipio_de_los_Hechos').empty();
    $("#Municipio_de_los_Hechos").append('<option value=""></option>');
    $('#Municipio_de_los_Hechos').val('0').trigger('change');
    $('#Poblacion').empty();
    $("#Poblacion").append('<option value=""></option>');
    $('#Poblacion').val('0').trigger('change');
    $('#Colonia_de_los_Hechos').empty();
    $("#Colonia_de_los_Hechos").append('<option value=""></option>');
    $('#Colonia_de_los_Hechos').val('0').trigger('change');
                Detalle_de_coincidencias_aClearGridData();
                Detalle_Historico_MPOClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateModulo_Atencion_Inicial').trigger('reset');
    $('#CreateModulo_Atencion_Inicial').find(':input').each(function () {
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
    var $myForm = $('#CreateModulo_Atencion_Inicial');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_coincidencias_acountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_coincidencias_a();
        return false;
    }
    if (Detalle_Historico_MPOcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Historico_MPO();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateModulo_Atencion_Inicial").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateModulo_Atencion_Inicial").on('click', '#Modulo_Atencion_InicialCancelar', function () {
	  if (!isPartial) {
        Modulo_Atencion_InicialBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateModulo_Atencion_Inicial").on('click', '#Modulo_Atencion_InicialGuardar', function () {
		$('#Modulo_Atencion_InicialGuardar').attr('disabled', true);
		$('#Modulo_Atencion_InicialGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendModulo_Atencion_InicialData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Modulo_Atencion_InicialBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Modulo_Atencion_InicialGuardar').removeAttr('disabled');
                        $('#Modulo_Atencion_InicialGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Modulo_Atencion_Inicial', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Modulo_Atencion_InicialItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Modulo_Atencion_InicialDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Modulo_Atencion_InicialGuardar').removeAttr('disabled');
					$('#Modulo_Atencion_InicialGuardar').bind()
				}
		}
		else {
			$('#Modulo_Atencion_InicialGuardar').removeAttr('disabled');
			$('#Modulo_Atencion_InicialGuardar').bind()
		}
    });
	$("form#CreateModulo_Atencion_Inicial").on('click', '#Modulo_Atencion_InicialGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendModulo_Atencion_InicialData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_coincidencias_aData();
                getDetalle_Historico_MPOData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Modulo_Atencion_Inicial', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Modulo_Atencion_InicialItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Modulo_Atencion_InicialDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateModulo_Atencion_Inicial").on('click', '#Modulo_Atencion_InicialGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendModulo_Atencion_InicialData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Turno_Asignado').empty();
    $("#Turno_Asignado").append('<option value=""></option>');
    $('#Turno_Asignado').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Ministerio_Publico_en_Turno').empty();
    $("#Ministerio_Publico_en_Turno").append('<option value=""></option>');
    $('#Ministerio_Publico_en_Turno').val('0').trigger('change');
    $('#Solicitud_de_Denuncia_Ciudadana').empty();
    $("#Solicitud_de_Denuncia_Ciudadana").append('<option value=""></option>');
    $('#Solicitud_de_Denuncia_Ciudadana').val('0').trigger('change');
    $('#Orientador').empty();
    $("#Orientador").append('<option value=""></option>');
    $('#Orientador').val('0').trigger('change');
    $('#Pais_de_los_Hechos').empty();
    $("#Pais_de_los_Hechos").append('<option value=""></option>');
    $('#Pais_de_los_Hechos').val('0').trigger('change');
    $('#Estado_de_los_Hechos').empty();
    $("#Estado_de_los_Hechos").append('<option value=""></option>');
    $('#Estado_de_los_Hechos').val('0').trigger('change');
    $('#Municipio_de_los_Hechos').empty();
    $("#Municipio_de_los_Hechos").append('<option value=""></option>');
    $('#Municipio_de_los_Hechos').val('0').trigger('change');
    $('#Poblacion').empty();
    $("#Poblacion").append('<option value=""></option>');
    $('#Poblacion').val('0').trigger('change');
    $('#Colonia_de_los_Hechos').empty();
    $("#Colonia_de_los_Hechos").append('<option value=""></option>');
    $('#Colonia_de_los_Hechos').val('0').trigger('change');
                Detalle_de_coincidencias_aClearGridData();
                Detalle_Historico_MPOClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_coincidencias_aData();
                getDetalle_Historico_MPOData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Modulo_Atencion_Inicial',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Modulo_Atencion_InicialItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Modulo_Atencion_InicialDropDown().get(0)').innerHTML);                          
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



var Modulo_Atencion_InicialisdisplayBusinessPropery = false;
Modulo_Atencion_InicialDisplayBusinessRuleButtons(Modulo_Atencion_InicialisdisplayBusinessPropery);
function Modulo_Atencion_InicialDisplayBusinessRule() {
    if (!Modulo_Atencion_InicialisdisplayBusinessPropery) {
        $('#CreateModulo_Atencion_Inicial').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Modulo_Atencion_InicialdisplayBusinessPropery"><button onclick="Modulo_Atencion_InicialGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Modulo_Atencion_InicialBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Modulo_Atencion_InicialdisplayBusinessPropery').remove();
    }
    Modulo_Atencion_InicialDisplayBusinessRuleButtons(!Modulo_Atencion_InicialisdisplayBusinessPropery);
    Modulo_Atencion_InicialisdisplayBusinessPropery = (Modulo_Atencion_InicialisdisplayBusinessPropery ? false : true);
}
function Modulo_Atencion_InicialDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

