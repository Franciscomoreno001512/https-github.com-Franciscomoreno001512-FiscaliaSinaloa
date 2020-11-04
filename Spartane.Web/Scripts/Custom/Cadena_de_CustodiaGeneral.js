        function RemoveAttachmentMainFijacion_Planimetrica () {
            $("#hdnRemoveFijacion_Planimetrica").val("1");
            $("#divAttachmentFijacion_Planimetrica").hide();
        }


//Begin Declarations for Foreigns fields for Detalle_del_Certificado_CC MultiRow
var Detalle_del_Certificado_CCcountRowsChecked = 0;






function GetInsertDetalle_del_Certificado_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_del_Certificado_CC_Certificado Certificado').attr('id', 'Detalle_del_Certificado_CC_Certificado_' + index).attr('data-field', 'Certificado');
    columnData[1] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_del_Certificado_CC_Archivo Archivo').attr('id', 'Detalle_del_Certificado_CC_Archivo_' + index).attr('data-field', 'Archivo');
    columnData[2] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_del_Certificado_CC_Fecha Fecha').attr('id', 'Detalle_del_Certificado_CC_Fecha_' + index).attr('data-field', 'Fecha');


    initiateUIControls();
    return columnData;
}

function Detalle_del_Certificado_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_del_Certificado_CC("Detalle_del_Certificado_CC_", "_" + rowIndex)) {
    var iPage = Detalle_del_Certificado_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_del_Certificado_CC';
    var prevData = Detalle_del_Certificado_CCTable.fnGetData(rowIndex);
    var data = Detalle_del_Certificado_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Certificado:  data.childNodes[counter++].childNodes[0].value
        ,Archivo: data.childNodes[counter++].childNodes[0].value
        ,Fecha:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_del_Certificado_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_del_Certificado_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_del_Certificado_CCTable.fnPageChange(iPage);
    Detalle_del_Certificado_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_del_Certificado_CC("Detalle_del_Certificado_CC_", "_" + rowIndex);
  }
}

function Detalle_del_Certificado_CCCancelRow(rowIndex) {
    var prevData = Detalle_del_Certificado_CCTable.fnGetData(rowIndex);
    var data = Detalle_del_Certificado_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_del_Certificado_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_del_Certificado_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_del_Certificado_CCGrid(Detalle_del_Certificado_CCTable.fnGetData());
    Detalle_del_Certificado_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_del_Certificado_CCFromDataTable() {
    var Detalle_del_Certificado_CCData = [];
    var gridData = Detalle_del_Certificado_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_del_Certificado_CCData.push({
                Clave: gridData[i].Clave

                ,Certificado: gridData[i].Certificado
                ,Archivo: gridData[i].Archivo
                ,Fecha: gridData[i].Fecha

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_del_Certificado_CCData.length; i++) {
        if (removedDetalle_del_Certificado_CCData[i] != null && removedDetalle_del_Certificado_CCData[i].Clave > 0)
            Detalle_del_Certificado_CCData.push({
                Clave: removedDetalle_del_Certificado_CCData[i].Clave

                ,Certificado: removedDetalle_del_Certificado_CCData[i].Certificado
                ,Archivo: removedDetalle_del_Certificado_CCData[i].Archivo
                ,Fecha: removedDetalle_del_Certificado_CCData[i].Fecha

                , Removed: true
            });
    }	

    return Detalle_del_Certificado_CCData;
}

function Detalle_del_Certificado_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_del_Certificado_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_del_Certificado_CCcountRowsChecked++;
    var Detalle_del_Certificado_CCRowElement = "Detalle_del_Certificado_CC_" + rowIndex.toString();
    var prevData = Detalle_del_Certificado_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_del_Certificado_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_del_Certificado_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_del_Certificado_CCGetUpdateRowControls(prevData, "Detalle_del_Certificado_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_del_Certificado_CCRowElement + "')){ Detalle_del_Certificado_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_del_Certificado_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_del_Certificado_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_del_Certificado_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_del_Certificado_CCValidation();
    initiateUIControls();
    $('.Detalle_del_Certificado_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_del_Certificado_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_del_Certificado_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_del_Certificado_CCTable.fnGetData().length;
    Detalle_del_Certificado_CCfnClickAddRow();
    GetAddDetalle_del_Certificado_CCPopup(currentRowIndex, 0);
}

function Detalle_del_Certificado_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_del_Certificado_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_del_Certificado_CCRowElement = "Detalle_del_Certificado_CC_" + rowIndex.toString();
    var prevData = Detalle_del_Certificado_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_del_Certificado_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_del_Certificado_CCCertificado').val(prevData.Certificado);
    $('#Detalle_del_Certificado_CCArchivo').val(prevData.Archivo);
    $('#Detalle_del_Certificado_CCFecha').val(prevData.Fecha);

    initiateUIControls();





}

function Detalle_del_Certificado_CCAddInsertRow() {
    if (Detalle_del_Certificado_CCinsertRowCurrentIndex < 1)
    {
        Detalle_del_Certificado_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Certificado: ""
        ,Archivo: ""
        ,Fecha: ""

    }
}

function Detalle_del_Certificado_CCfnClickAddRow() {
    Detalle_del_Certificado_CCcountRowsChecked++;
    Detalle_del_Certificado_CCTable.fnAddData(Detalle_del_Certificado_CCAddInsertRow(), true);
    Detalle_del_Certificado_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_del_Certificado_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_del_Certificado_CCGrid tbody tr:nth-of-type(' + (Detalle_del_Certificado_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_del_Certificado_CC("Detalle_del_Certificado_CC_", "_" + Detalle_del_Certificado_CCinsertRowCurrentIndex);
}

function Detalle_del_Certificado_CCClearGridData() {
    Detalle_del_Certificado_CCData = [];
    Detalle_del_Certificado_CCdeletedItem = [];
    Detalle_del_Certificado_CCDataMain = [];
    Detalle_del_Certificado_CCDataMainPages = [];
    Detalle_del_Certificado_CCnewItemCount = 0;
    Detalle_del_Certificado_CCmaxItemIndex = 0;
    $("#Detalle_del_Certificado_CCGrid").DataTable().clear();
    $("#Detalle_del_Certificado_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_del_Certificado_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_del_Certificado_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_del_Certificado_CCData[i].Clave);

        form_data.append('[' + i + '].Certificado', Detalle_del_Certificado_CCData[i].Certificado);
        form_data.append('[' + i + '].Archivo', Detalle_del_Certificado_CCData[i].Archivo);
        form_data.append('[' + i + '].Fecha', Detalle_del_Certificado_CCData[i].Fecha);

        form_data.append('[' + i + '].Removed', Detalle_del_Certificado_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_del_Certificado_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_del_Certificado_CC("Detalle_del_Certificado_CCTable", rowIndex)) {
    var prevData = Detalle_del_Certificado_CCTable.fnGetData(rowIndex);
    var data = Detalle_del_Certificado_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Certificado: $('#Detalle_del_Certificado_CCCertificado').val()
        ,Archivo: $('#Detalle_del_Certificado_CCArchivo').val()

        ,Fecha: $('#Detalle_del_Certificado_CCFecha').val()

    }

    Detalle_del_Certificado_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_del_Certificado_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_del_Certificado_CC-form').modal({ show: false });
    $('#AddDetalle_del_Certificado_CC-form').modal('hide');
    Detalle_del_Certificado_CCEditRow(rowIndex);
    Detalle_del_Certificado_CCInsertRow(rowIndex);
    //}
}
function Detalle_del_Certificado_CCRemoveAddRow(rowIndex) {
    Detalle_del_Certificado_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_del_Certificado_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Fotos_CC MultiRow
var Detalle_de_Fotos_CCcountRowsChecked = 0;





function GetInsertDetalle_de_Fotos_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Fotos_CC_Fotos Fotos').attr('id', 'Detalle_de_Fotos_CC_Fotos_' + index).attr('data-field', 'Fotos');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Fotos_CC_Pie_de_Foto Pie_de_Foto').attr('id', 'Detalle_de_Fotos_CC_Pie_de_Foto_' + index).attr('data-field', 'Pie_de_Foto');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Fotos_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Fotos_CC("Detalle_de_Fotos_CC_", "_" + rowIndex)) {
    var iPage = Detalle_de_Fotos_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Fotos_CC';
    var prevData = Detalle_de_Fotos_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Fotos_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fotos: data.childNodes[counter++].childNodes[0].value
        ,Pie_de_Foto:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Fotos_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Fotos_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Fotos_CCTable.fnPageChange(iPage);
    Detalle_de_Fotos_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Fotos_CC("Detalle_de_Fotos_CC_", "_" + rowIndex);
  }
}

function Detalle_de_Fotos_CCCancelRow(rowIndex) {
    var prevData = Detalle_de_Fotos_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Fotos_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Fotos_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Fotos_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Fotos_CCGrid(Detalle_de_Fotos_CCTable.fnGetData());
    Detalle_de_Fotos_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Fotos_CCFromDataTable() {
    var Detalle_de_Fotos_CCData = [];
    var gridData = Detalle_de_Fotos_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Fotos_CCData.push({
                Clave: gridData[i].Clave

                ,Fotos: gridData[i].Fotos
                ,Pie_de_Foto: gridData[i].Pie_de_Foto

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Fotos_CCData.length; i++) {
        if (removedDetalle_de_Fotos_CCData[i] != null && removedDetalle_de_Fotos_CCData[i].Clave > 0)
            Detalle_de_Fotos_CCData.push({
                Clave: removedDetalle_de_Fotos_CCData[i].Clave

                ,Fotos: removedDetalle_de_Fotos_CCData[i].Fotos
                ,Pie_de_Foto: removedDetalle_de_Fotos_CCData[i].Pie_de_Foto

                , Removed: true
            });
    }	

    return Detalle_de_Fotos_CCData;
}

function Detalle_de_Fotos_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Fotos_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Fotos_CCcountRowsChecked++;
    var Detalle_de_Fotos_CCRowElement = "Detalle_de_Fotos_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Fotos_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Fotos_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Fotos_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Fotos_CCGetUpdateRowControls(prevData, "Detalle_de_Fotos_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Fotos_CCRowElement + "')){ Detalle_de_Fotos_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Fotos_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Fotos_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Fotos_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Fotos_CCValidation();
    initiateUIControls();
    $('.Detalle_de_Fotos_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Fotos_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Fotos_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Fotos_CCTable.fnGetData().length;
    Detalle_de_Fotos_CCfnClickAddRow();
    GetAddDetalle_de_Fotos_CCPopup(currentRowIndex, 0);
}

function Detalle_de_Fotos_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Fotos_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Fotos_CCRowElement = "Detalle_de_Fotos_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Fotos_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Fotos_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Fotos_CCFotos').val(prevData.Fotos);
    $('#Detalle_de_Fotos_CCPie_de_Foto').val(prevData.Pie_de_Foto);

    initiateUIControls();




}

function Detalle_de_Fotos_CCAddInsertRow() {
    if (Detalle_de_Fotos_CCinsertRowCurrentIndex < 1)
    {
        Detalle_de_Fotos_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fotos: ""
        ,Pie_de_Foto: ""

    }
}

function Detalle_de_Fotos_CCfnClickAddRow() {
    Detalle_de_Fotos_CCcountRowsChecked++;
    Detalle_de_Fotos_CCTable.fnAddData(Detalle_de_Fotos_CCAddInsertRow(), true);
    Detalle_de_Fotos_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Fotos_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Fotos_CCGrid tbody tr:nth-of-type(' + (Detalle_de_Fotos_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Fotos_CC("Detalle_de_Fotos_CC_", "_" + Detalle_de_Fotos_CCinsertRowCurrentIndex);
}

function Detalle_de_Fotos_CCClearGridData() {
    Detalle_de_Fotos_CCData = [];
    Detalle_de_Fotos_CCdeletedItem = [];
    Detalle_de_Fotos_CCDataMain = [];
    Detalle_de_Fotos_CCDataMainPages = [];
    Detalle_de_Fotos_CCnewItemCount = 0;
    Detalle_de_Fotos_CCmaxItemIndex = 0;
    $("#Detalle_de_Fotos_CCGrid").DataTable().clear();
    $("#Detalle_de_Fotos_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Fotos_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Fotos_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Fotos_CCData[i].Clave);

        form_data.append('[' + i + '].Fotos', Detalle_de_Fotos_CCData[i].Fotos);
        form_data.append('[' + i + '].Pie_de_Foto', Detalle_de_Fotos_CCData[i].Pie_de_Foto);

        form_data.append('[' + i + '].Removed', Detalle_de_Fotos_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Fotos_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Fotos_CC("Detalle_de_Fotos_CCTable", rowIndex)) {
    var prevData = Detalle_de_Fotos_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Fotos_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fotos: $('#Detalle_de_Fotos_CCFotos').val()

        ,Pie_de_Foto: $('#Detalle_de_Fotos_CCPie_de_Foto').val()

    }

    Detalle_de_Fotos_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Fotos_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Fotos_CC-form').modal({ show: false });
    $('#AddDetalle_de_Fotos_CC-form').modal('hide');
    Detalle_de_Fotos_CCEditRow(rowIndex);
    Detalle_de_Fotos_CCInsertRow(rowIndex);
    //}
}
function Detalle_de_Fotos_CCRemoveAddRow(rowIndex) {
    Detalle_de_Fotos_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Fotos_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Videos_CC MultiRow
var Detalle_de_Videos_CCcountRowsChecked = 0;





function GetInsertDetalle_de_Videos_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Videos_CC_Video Video').attr('id', 'Detalle_de_Videos_CC_Video_' + index).attr('data-field', 'Video');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Videos_CC_Pie_de_Video Pie_de_Video').attr('id', 'Detalle_de_Videos_CC_Pie_de_Video_' + index).attr('data-field', 'Pie_de_Video');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Videos_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Videos_CC("Detalle_de_Videos_CC_", "_" + rowIndex)) {
    var iPage = Detalle_de_Videos_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Videos_CC';
    var prevData = Detalle_de_Videos_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Videos_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Video: data.childNodes[counter++].childNodes[0].value
        ,Pie_de_Video:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Videos_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Videos_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Videos_CCTable.fnPageChange(iPage);
    Detalle_de_Videos_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Videos_CC("Detalle_de_Videos_CC_", "_" + rowIndex);
  }
}

function Detalle_de_Videos_CCCancelRow(rowIndex) {
    var prevData = Detalle_de_Videos_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Videos_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Videos_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Videos_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Videos_CCGrid(Detalle_de_Videos_CCTable.fnGetData());
    Detalle_de_Videos_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Videos_CCFromDataTable() {
    var Detalle_de_Videos_CCData = [];
    var gridData = Detalle_de_Videos_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Videos_CCData.push({
                Clave: gridData[i].Clave

                ,Video: gridData[i].Video
                ,Pie_de_Video: gridData[i].Pie_de_Video

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Videos_CCData.length; i++) {
        if (removedDetalle_de_Videos_CCData[i] != null && removedDetalle_de_Videos_CCData[i].Clave > 0)
            Detalle_de_Videos_CCData.push({
                Clave: removedDetalle_de_Videos_CCData[i].Clave

                ,Video: removedDetalle_de_Videos_CCData[i].Video
                ,Pie_de_Video: removedDetalle_de_Videos_CCData[i].Pie_de_Video

                , Removed: true
            });
    }	

    return Detalle_de_Videos_CCData;
}

function Detalle_de_Videos_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Videos_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Videos_CCcountRowsChecked++;
    var Detalle_de_Videos_CCRowElement = "Detalle_de_Videos_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Videos_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Videos_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Videos_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Videos_CCGetUpdateRowControls(prevData, "Detalle_de_Videos_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Videos_CCRowElement + "')){ Detalle_de_Videos_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Videos_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Videos_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Videos_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Videos_CCValidation();
    initiateUIControls();
    $('.Detalle_de_Videos_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Videos_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Videos_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Videos_CCTable.fnGetData().length;
    Detalle_de_Videos_CCfnClickAddRow();
    GetAddDetalle_de_Videos_CCPopup(currentRowIndex, 0);
}

function Detalle_de_Videos_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Videos_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Videos_CCRowElement = "Detalle_de_Videos_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Videos_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Videos_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Videos_CCVideo').val(prevData.Video);
    $('#Detalle_de_Videos_CCPie_de_Video').val(prevData.Pie_de_Video);

    initiateUIControls();




}

function Detalle_de_Videos_CCAddInsertRow() {
    if (Detalle_de_Videos_CCinsertRowCurrentIndex < 1)
    {
        Detalle_de_Videos_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Video: ""
        ,Pie_de_Video: ""

    }
}

function Detalle_de_Videos_CCfnClickAddRow() {
    Detalle_de_Videos_CCcountRowsChecked++;
    Detalle_de_Videos_CCTable.fnAddData(Detalle_de_Videos_CCAddInsertRow(), true);
    Detalle_de_Videos_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Videos_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Videos_CCGrid tbody tr:nth-of-type(' + (Detalle_de_Videos_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Videos_CC("Detalle_de_Videos_CC_", "_" + Detalle_de_Videos_CCinsertRowCurrentIndex);
}

function Detalle_de_Videos_CCClearGridData() {
    Detalle_de_Videos_CCData = [];
    Detalle_de_Videos_CCdeletedItem = [];
    Detalle_de_Videos_CCDataMain = [];
    Detalle_de_Videos_CCDataMainPages = [];
    Detalle_de_Videos_CCnewItemCount = 0;
    Detalle_de_Videos_CCmaxItemIndex = 0;
    $("#Detalle_de_Videos_CCGrid").DataTable().clear();
    $("#Detalle_de_Videos_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Videos_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Videos_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Videos_CCData[i].Clave);

        form_data.append('[' + i + '].Video', Detalle_de_Videos_CCData[i].Video);
        form_data.append('[' + i + '].Pie_de_Video', Detalle_de_Videos_CCData[i].Pie_de_Video);

        form_data.append('[' + i + '].Removed', Detalle_de_Videos_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Videos_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Videos_CC("Detalle_de_Videos_CCTable", rowIndex)) {
    var prevData = Detalle_de_Videos_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Videos_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Video: $('#Detalle_de_Videos_CCVideo').val()

        ,Pie_de_Video: $('#Detalle_de_Videos_CCPie_de_Video').val()

    }

    Detalle_de_Videos_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Videos_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Videos_CC-form').modal({ show: false });
    $('#AddDetalle_de_Videos_CC-form').modal('hide');
    Detalle_de_Videos_CCEditRow(rowIndex);
    Detalle_de_Videos_CCInsertRow(rowIndex);
    //}
}
function Detalle_de_Videos_CCRemoveAddRow(rowIndex) {
    Detalle_de_Videos_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Videos_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Registro_de_Intervinientes_CC MultiRow
var Detalle_de_Registro_de_Intervinientes_CCcountRowsChecked = 0;








function GetDetalle_de_Registro_de_Intervinientes_CC_GeneroName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_GeneroItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_GeneroItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_GeneroDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_GeneroDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_GeneroItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_GeneroItems[i].Descripcion }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_GeneroDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_GeneroDropdown;
}
function GetDetalle_de_Registro_de_Intervinientes_CC_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_Estado_CivilDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_Estado_CivilDropdown;
}
function GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionDropdown;
}

function GetDetalle_de_Registro_de_Intervinientes_CC_EscolaridadName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_EscolaridadItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_EscolaridadItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_EscolaridadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_EscolaridadDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_EscolaridadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_EscolaridadDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_EscolaridadItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_EscolaridadItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_EscolaridadItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_EscolaridadItems[i].Descripcion }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_EscolaridadDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_EscolaridadDropdown;
}
function GetDetalle_de_Registro_de_Intervinientes_CC_OcupacionName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_OcupacionItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_OcupacionItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_OcupacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_OcupacionDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_OcupacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_OcupacionDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_OcupacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_OcupacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_OcupacionItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_OcupacionItems[i].Descripcion }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_OcupacionDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_OcupacionDropdown;
}
function GetDetalle_de_Registro_de_Intervinientes_CC_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_NacionalidadItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_NacionalidadItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_NacionalidadDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_NacionalidadDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_NacionalidadItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_NacionalidadDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_NacionalidadDropdown;
}
function GetDetalle_de_Registro_de_Intervinientes_CC_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_EstadoItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_EstadoItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_EstadoDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_EstadoDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_EstadoItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_EstadoItems[i].Nombre }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_EstadoDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_EstadoDropdown;
}
function GetDetalle_de_Registro_de_Intervinientes_CC_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_MunicipioItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_MunicipioDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_MunicipioDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_MunicipioItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_MunicipioDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_MunicipioDropdown;
}
function GetDetalle_de_Registro_de_Intervinientes_CC_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_ColoniaItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_ColoniaDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_ColoniaDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_ColoniaItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_ColoniaDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_ColoniaDropdown;
}







function GetDetalle_de_Registro_de_Intervinientes_CC_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_PaisItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_PaisItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_PaisDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_PaisDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_PaisItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_PaisItems[i].Nombre }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_PaisDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_PaisDropdown;
}







function GetDetalle_de_Registro_de_Intervinientes_CC_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_PaisItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_PaisItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_PaisDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_PaisDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_PaisItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_PaisItems[i].Nombre }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_PaisDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_PaisDropdown;
}



function GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteItems[i].Descripcion }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteDropdown;
}
function GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadName(Id) {
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadItems.length; i++) {
        if (Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadItems[i].Clave == Id) {
            return Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadDropDown() {
    var Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Registro_de_Intervinientes_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadDropdown);
    if(Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadItems[i].Clave, text:    Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadItems[i].Descripcion }).appendTo(Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadDropdown);
       }
    }
    return Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadDropdown;
}



function GetInsertDetalle_de_Registro_de_Intervinientes_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Nombres Nombres').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Nombres_' + index).attr('data-field', 'Nombres');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Apellido_Paterno Apellido_Paterno').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Apellido_Paterno_' + index).attr('data-field', 'Apellido_Paterno');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Apellido_Materno Apellido_Materno').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Apellido_Materno_' + index).attr('data-field', 'Apellido_Materno');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Alias Alias').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Alias_' + index).attr('data-field', 'Alias');
    columnData[4] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Registro_de_Intervinientes_CC_Anonimo Anonimo').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Anonimo_' + index).attr('data-field', 'Anonimo');
    columnData[5] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Registro_de_Intervinientes_CC_Fecha_de_Nacimiento Fecha_de_Nacimiento').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Fecha_de_Nacimiento_' + index).attr('data-field', 'Fecha_de_Nacimiento');
    columnData[6] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Registro_de_Intervinientes_CC_Edad Edad').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Edad_' + index).attr('data-field', 'Edad');
    columnData[7] = $(GetDetalle_de_Registro_de_Intervinientes_CC_GeneroDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Sexo Sexo').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Sexo_' + index).attr('data-field', 'Sexo').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Genero', 'Sexo', 264584)));
    columnData[8] = $(GetDetalle_de_Registro_de_Intervinientes_CC_Estado_CivilDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Estado_Civil Estado_Civil').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Estado_Civil_' + index).attr('data-field', 'Estado_Civil').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Estado_Civil', 'Estado_Civil', 264585)));
    columnData[9] = $(GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_Identificacion Tipo_de_Identificacion').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_Identificacion_' + index).attr('data-field', 'Tipo_de_Identificacion').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion', 264586)));
    columnData[10] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Numero_de_Identificacion Numero_de_Identificacion').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Numero_de_Identificacion_' + index).attr('data-field', 'Numero_de_Identificacion');
    columnData[11] = $(GetDetalle_de_Registro_de_Intervinientes_CC_EscolaridadDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Escolaridad Escolaridad').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Escolaridad_' + index).attr('data-field', 'Escolaridad').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Escolaridad', 'Escolaridad', 264588)));
    columnData[12] = $(GetDetalle_de_Registro_de_Intervinientes_CC_OcupacionDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Ocupacion Ocupacion').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Ocupacion_' + index).attr('data-field', 'Ocupacion').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Ocupacion', 'Ocupacion', 264589)));
    columnData[13] = $(GetDetalle_de_Registro_de_Intervinientes_CC_NacionalidadDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Nacionalidad Nacionalidad').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Nacionalidad_' + index).attr('data-field', 'Nacionalidad').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Nacionalidad', 'Nacionalidad', 264590)));
    columnData[14] = $(GetDetalle_de_Registro_de_Intervinientes_CC_EstadoDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Estado Estado').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Estado', 'Estado', 264591)));
    columnData[15] = $(GetDetalle_de_Registro_de_Intervinientes_CC_MunicipioDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Municipio Municipio').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Municipio', 'Municipio', 264592)));
    columnData[16] = $(GetDetalle_de_Registro_de_Intervinientes_CC_ColoniaDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Colonia Colonia').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Colonia', 'Colonia', 264593)));
    columnData[17] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Registro_de_Intervinientes_CC_Codigo_Postal Codigo_Postal').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[18] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Calle Calle').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Calle_' + index).attr('data-field', 'Calle');
    columnData[19] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Numero_Exterior Numero_Exterior').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[20] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Numero_Interior Numero_Interior').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[21] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Telefono Telefono').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Telefono_' + index).attr('data-field', 'Telefono');
    columnData[22] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Celular Celular').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Celular_' + index).attr('data-field', 'Celular');
    columnData[23] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Correo_Electronico Correo_Electronico').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');
    columnData[24] = $(GetDetalle_de_Registro_de_Intervinientes_CC_PaisDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Pais Pais').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Pais_' + index).attr('data-field', 'Pais').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Pais', 'Pais', 264601)));

    columnData[25] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Entre_calle Entre_calle').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Entre_calle_' + index).attr('data-field', 'Entre_calle');
    columnData[26] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Especifique Especifique').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Especifique_' + index).attr('data-field', 'Especifique');
    columnData[27] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Registro_de_Intervinientes_CC_Extension Extension').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Extension_' + index).attr('data-field', 'Extension');
    columnData[28] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Registro_de_Intervinientes_CC_Inimputable Inimputable').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Inimputable_' + index).attr('data-field', 'Inimputable');
    columnData[29] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Nombre_Completo Nombre_Completo').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Nombre_Completo_' + index).attr('data-field', 'Nombre_Completo');
    columnData[30] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Originario_de Originario_de').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Originario_de_' + index).attr('data-field', 'Originario_de');
    columnData[31] = $(GetDetalle_de_Registro_de_Intervinientes_CC_PaisDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Pais_de_Origen Pais_de_Origen').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Pais_de_Origen_' + index).attr('data-field', 'Pais_de_Origen').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Pais', 'Pais_de_Origen', 264609)));
    columnData[32] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Registro_de_Intervinientes_CC_Proteccion_de_Datos Proteccion_de_Datos').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Proteccion_de_Datos_' + index).attr('data-field', 'Proteccion_de_Datos');
    columnData[33] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Referencia_de_Domicilio Referencia_de_Domicilio').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Referencia_de_Domicilio_' + index).attr('data-field', 'Referencia_de_Domicilio');
    columnData[34] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Y_calle Y_calle').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Y_calle_' + index).attr('data-field', 'Y_calle');
    columnData[35] = $(GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_Compareciente Tipo_de_Compareciente').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_Compareciente_' + index).attr('data-field', 'Tipo_de_Compareciente').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Tipo_de_Compareciente', 'Tipo_de_Compareciente', 264613)));
    columnData[36] = $(GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadDropDown()).addClass('Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_inimputabilidad Tipo_de_inimputabilidad').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Tipo_de_inimputabilidad_' + index).attr('data-field', 'Tipo_de_inimputabilidad').after($.parseHTML(addNew('Detalle_de_Registro_de_Intervinientes_CC', 'Tipo_de_Inimputabilidad', 'Tipo_de_inimputabilidad', 264614)));
    columnData[37] = $($.parseHTML(inputData)).addClass('Detalle_de_Registro_de_Intervinientes_CC_Nombre Nombre').attr('id', 'Detalle_de_Registro_de_Intervinientes_CC_Nombre_' + index).attr('data-field', 'Nombre');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Registro_de_Intervinientes_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Registro_de_Intervinientes_CC("Detalle_de_Registro_de_Intervinientes_CC_", "_" + rowIndex)) {
    var iPage = Detalle_de_Registro_de_Intervinientes_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Registro_de_Intervinientes_CC';
    var prevData = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombres:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno:  data.childNodes[counter++].childNodes[0].value
        ,Alias:  data.childNodes[counter++].childNodes[0].value
        ,Anonimo: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Fecha_de_Nacimiento:  data.childNodes[counter++].childNodes[0].value
        ,Edad: data.childNodes[counter++].childNodes[0].value
        ,Sexo:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Escolaridad:  data.childNodes[counter++].childNodes[0].value
        ,Ocupacion:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad:  data.childNodes[counter++].childNodes[0].value
        ,Estado:  data.childNodes[counter++].childNodes[0].value
        ,Municipio:  data.childNodes[counter++].childNodes[0].value
        ,Colonia:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal: data.childNodes[counter++].childNodes[0].value
        ,Calle:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value
        ,Telefono:  data.childNodes[counter++].childNodes[0].value
        ,Celular:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value
        ,Pais:  data.childNodes[counter++].childNodes[0].value

        ,Entre_calle:  data.childNodes[counter++].childNodes[0].value
        ,Especifique:  data.childNodes[counter++].childNodes[0].value
        ,Extension: data.childNodes[counter++].childNodes[0].value
        ,Inimputable: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Nombre_Completo:  data.childNodes[counter++].childNodes[0].value
        ,Originario_de:  data.childNodes[counter++].childNodes[0].value
        ,Pais_de_Origen:  data.childNodes[counter++].childNodes[0].value
        ,Proteccion_de_Datos: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Referencia_de_Domicilio:  data.childNodes[counter++].childNodes[0].value
        ,Y_calle:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Compareciente:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_inimputabilidad:  data.childNodes[counter++].childNodes[0].value
        ,Nombre:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Registro_de_Intervinientes_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Registro_de_Intervinientes_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Registro_de_Intervinientes_CCTable.fnPageChange(iPage);
    Detalle_de_Registro_de_Intervinientes_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Registro_de_Intervinientes_CC("Detalle_de_Registro_de_Intervinientes_CC_", "_" + rowIndex);
  }
}

function Detalle_de_Registro_de_Intervinientes_CCCancelRow(rowIndex) {
    var prevData = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Registro_de_Intervinientes_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Registro_de_Intervinientes_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Registro_de_Intervinientes_CCGrid(Detalle_de_Registro_de_Intervinientes_CCTable.fnGetData());
    Detalle_de_Registro_de_Intervinientes_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Registro_de_Intervinientes_CCFromDataTable() {
    var Detalle_de_Registro_de_Intervinientes_CCData = [];
    var gridData = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Registro_de_Intervinientes_CCData.push({
                Clave: gridData[i].Clave

                ,Nombres: gridData[i].Nombres
                ,Apellido_Paterno: gridData[i].Apellido_Paterno
                ,Apellido_Materno: gridData[i].Apellido_Materno
                ,Alias: gridData[i].Alias
                ,Anonimo: gridData[i].Anonimo
                ,Fecha_de_Nacimiento: gridData[i].Fecha_de_Nacimiento
                ,Edad: gridData[i].Edad
                ,Sexo: gridData[i].Sexo
                ,Estado_Civil: gridData[i].Estado_Civil
                ,Tipo_de_Identificacion: gridData[i].Tipo_de_Identificacion
                ,Numero_de_Identificacion: gridData[i].Numero_de_Identificacion
                ,Escolaridad: gridData[i].Escolaridad
                ,Ocupacion: gridData[i].Ocupacion
                ,Nacionalidad: gridData[i].Nacionalidad
                ,Estado: gridData[i].Estado
                ,Municipio: gridData[i].Municipio
                ,Colonia: gridData[i].Colonia
                ,Codigo_Postal: gridData[i].Codigo_Postal
                ,Calle: gridData[i].Calle
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior
                ,Telefono: gridData[i].Telefono
                ,Celular: gridData[i].Celular
                ,Correo_Electronico: gridData[i].Correo_Electronico
                ,Pais: gridData[i].Pais

                ,Entre_calle: gridData[i].Entre_calle
                ,Especifique: gridData[i].Especifique
                ,Extension: gridData[i].Extension
                ,Inimputable: gridData[i].Inimputable
                ,Nombre_Completo: gridData[i].Nombre_Completo
                ,Originario_de: gridData[i].Originario_de
                ,Pais_de_Origen: gridData[i].Pais_de_Origen
                ,Proteccion_de_Datos: gridData[i].Proteccion_de_Datos
                ,Referencia_de_Domicilio: gridData[i].Referencia_de_Domicilio
                ,Y_calle: gridData[i].Y_calle
                ,Tipo_de_Compareciente: gridData[i].Tipo_de_Compareciente
                ,Tipo_de_inimputabilidad: gridData[i].Tipo_de_inimputabilidad
                ,Nombre: gridData[i].Nombre

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Registro_de_Intervinientes_CCData.length; i++) {
        if (removedDetalle_de_Registro_de_Intervinientes_CCData[i] != null && removedDetalle_de_Registro_de_Intervinientes_CCData[i].Clave > 0)
            Detalle_de_Registro_de_Intervinientes_CCData.push({
                Clave: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Clave

                ,Nombres: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Nombres
                ,Apellido_Paterno: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Apellido_Paterno
                ,Apellido_Materno: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Apellido_Materno
                ,Alias: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Alias
                ,Anonimo: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Anonimo
                ,Fecha_de_Nacimiento: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Fecha_de_Nacimiento
                ,Edad: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Edad
                ,Sexo: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Sexo
                ,Estado_Civil: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Estado_Civil
                ,Tipo_de_Identificacion: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Tipo_de_Identificacion
                ,Numero_de_Identificacion: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Numero_de_Identificacion
                ,Escolaridad: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Escolaridad
                ,Ocupacion: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Ocupacion
                ,Nacionalidad: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Nacionalidad
                ,Estado: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Estado
                ,Municipio: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Municipio
                ,Colonia: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Colonia
                ,Codigo_Postal: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Codigo_Postal
                ,Calle: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Calle
                ,Numero_Exterior: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Numero_Exterior
                ,Numero_Interior: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Numero_Interior
                ,Telefono: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Telefono
                ,Celular: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Celular
                ,Correo_Electronico: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Correo_Electronico
                ,Pais: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Pais

                ,Entre_calle: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Entre_calle
                ,Especifique: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Especifique
                ,Extension: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Extension
                ,Inimputable: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Inimputable
                ,Nombre_Completo: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Nombre_Completo
                ,Originario_de: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Originario_de
                ,Pais_de_Origen: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Pais_de_Origen
                ,Proteccion_de_Datos: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Proteccion_de_Datos
                ,Referencia_de_Domicilio: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Referencia_de_Domicilio
                ,Y_calle: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Y_calle
                ,Tipo_de_Compareciente: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Tipo_de_Compareciente
                ,Tipo_de_inimputabilidad: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Tipo_de_inimputabilidad
                ,Nombre: removedDetalle_de_Registro_de_Intervinientes_CCData[i].Nombre

                , Removed: true
            });
    }	

    return Detalle_de_Registro_de_Intervinientes_CCData;
}

function Detalle_de_Registro_de_Intervinientes_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Registro_de_Intervinientes_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Registro_de_Intervinientes_CCcountRowsChecked++;
    var Detalle_de_Registro_de_Intervinientes_CCRowElement = "Detalle_de_Registro_de_Intervinientes_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Registro_de_Intervinientes_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Registro_de_Intervinientes_CCGetUpdateRowControls(prevData, "Detalle_de_Registro_de_Intervinientes_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Registro_de_Intervinientes_CCRowElement + "')){ Detalle_de_Registro_de_Intervinientes_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Registro_de_Intervinientes_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Registro_de_Intervinientes_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Registro_de_Intervinientes_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Registro_de_Intervinientes_CCValidation();
    initiateUIControls();
    $('.Detalle_de_Registro_de_Intervinientes_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Registro_de_Intervinientes_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Registro_de_Intervinientes_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetData().length;
    Detalle_de_Registro_de_Intervinientes_CCfnClickAddRow();
    GetAddDetalle_de_Registro_de_Intervinientes_CCPopup(currentRowIndex, 0);
}

function Detalle_de_Registro_de_Intervinientes_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Registro_de_Intervinientes_CCRowElement = "Detalle_de_Registro_de_Intervinientes_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Registro_de_Intervinientes_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Registro_de_Intervinientes_CCNombres').val(prevData.Nombres);
    $('#Detalle_de_Registro_de_Intervinientes_CCApellido_Paterno').val(prevData.Apellido_Paterno);
    $('#Detalle_de_Registro_de_Intervinientes_CCApellido_Materno').val(prevData.Apellido_Materno);
    $('#Detalle_de_Registro_de_Intervinientes_CCAlias').val(prevData.Alias);
    $('#Detalle_de_Registro_de_Intervinientes_CCAnonimo').prop('checked', prevData.Anonimo);
    $('#Detalle_de_Registro_de_Intervinientes_CCFecha_de_Nacimiento').val(prevData.Fecha_de_Nacimiento);
    $('#Detalle_de_Registro_de_Intervinientes_CCEdad').val(prevData.Edad);
    $('#Detalle_de_Registro_de_Intervinientes_CCSexo').val(prevData.Sexo);
    $('#Detalle_de_Registro_de_Intervinientes_CCEstado_Civil').val(prevData.Estado_Civil);
    $('#Detalle_de_Registro_de_Intervinientes_CCTipo_de_Identificacion').val(prevData.Tipo_de_Identificacion);
    $('#Detalle_de_Registro_de_Intervinientes_CCNumero_de_Identificacion').val(prevData.Numero_de_Identificacion);
    $('#Detalle_de_Registro_de_Intervinientes_CCEscolaridad').val(prevData.Escolaridad);
    $('#Detalle_de_Registro_de_Intervinientes_CCOcupacion').val(prevData.Ocupacion);
    $('#Detalle_de_Registro_de_Intervinientes_CCNacionalidad').val(prevData.Nacionalidad);
    $('#Detalle_de_Registro_de_Intervinientes_CCEstado').val(prevData.Estado);
    $('#Detalle_de_Registro_de_Intervinientes_CCMunicipio').val(prevData.Municipio);
    $('#Detalle_de_Registro_de_Intervinientes_CCColonia').val(prevData.Colonia);
    $('#Detalle_de_Registro_de_Intervinientes_CCCodigo_Postal').val(prevData.Codigo_Postal);
    $('#Detalle_de_Registro_de_Intervinientes_CCCalle').val(prevData.Calle);
    $('#Detalle_de_Registro_de_Intervinientes_CCNumero_Exterior').val(prevData.Numero_Exterior);
    $('#Detalle_de_Registro_de_Intervinientes_CCNumero_Interior').val(prevData.Numero_Interior);
    $('#Detalle_de_Registro_de_Intervinientes_CCTelefono').val(prevData.Telefono);
    $('#Detalle_de_Registro_de_Intervinientes_CCCelular').val(prevData.Celular);
    $('#Detalle_de_Registro_de_Intervinientes_CCCorreo_Electronico').val(prevData.Correo_Electronico);
    $('#Detalle_de_Registro_de_Intervinientes_CCPais').val(prevData.Pais);

    $('#Detalle_de_Registro_de_Intervinientes_CCEntre_calle').val(prevData.Entre_calle);
    $('#Detalle_de_Registro_de_Intervinientes_CCEspecifique').val(prevData.Especifique);
    $('#Detalle_de_Registro_de_Intervinientes_CCExtension').val(prevData.Extension);
    $('#Detalle_de_Registro_de_Intervinientes_CCInimputable').prop('checked', prevData.Inimputable);
    $('#Detalle_de_Registro_de_Intervinientes_CCNombre_Completo').val(prevData.Nombre_Completo);
    $('#Detalle_de_Registro_de_Intervinientes_CCOriginario_de').val(prevData.Originario_de);
    $('#Detalle_de_Registro_de_Intervinientes_CCPais_de_Origen').val(prevData.Pais_de_Origen);
    $('#Detalle_de_Registro_de_Intervinientes_CCProteccion_de_Datos').prop('checked', prevData.Proteccion_de_Datos);
    $('#Detalle_de_Registro_de_Intervinientes_CCReferencia_de_Domicilio').val(prevData.Referencia_de_Domicilio);
    $('#Detalle_de_Registro_de_Intervinientes_CCY_calle').val(prevData.Y_calle);
    $('#Detalle_de_Registro_de_Intervinientes_CCTipo_de_Compareciente').val(prevData.Tipo_de_Compareciente);
    $('#Detalle_de_Registro_de_Intervinientes_CCTipo_de_inimputabilidad').val(prevData.Tipo_de_inimputabilidad);
    $('#Detalle_de_Registro_de_Intervinientes_CCNombre').val(prevData.Nombre);

    initiateUIControls();









































}

function Detalle_de_Registro_de_Intervinientes_CCAddInsertRow() {
    if (Detalle_de_Registro_de_Intervinientes_CCinsertRowCurrentIndex < 1)
    {
        Detalle_de_Registro_de_Intervinientes_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombres: ""
        ,Apellido_Paterno: ""
        ,Apellido_Materno: ""
        ,Alias: ""
        ,Anonimo: ""
        ,Fecha_de_Nacimiento: ""
        ,Edad: ""
        ,Sexo: ""
        ,Estado_Civil: ""
        ,Tipo_de_Identificacion: ""
        ,Numero_de_Identificacion: ""
        ,Escolaridad: ""
        ,Ocupacion: ""
        ,Nacionalidad: ""
        ,Estado: ""
        ,Municipio: ""
        ,Colonia: ""
        ,Codigo_Postal: ""
        ,Calle: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""
        ,Telefono: ""
        ,Celular: ""
        ,Correo_Electronico: ""
        ,Pais: ""

        ,Entre_calle: ""
        ,Especifique: ""
        ,Extension: ""
        ,Inimputable: ""
        ,Nombre_Completo: ""
        ,Originario_de: ""
        ,Pais_de_Origen: ""
        ,Proteccion_de_Datos: ""
        ,Referencia_de_Domicilio: ""
        ,Y_calle: ""
        ,Tipo_de_Compareciente: ""
        ,Tipo_de_inimputabilidad: ""
        ,Nombre: ""

    }
}

function Detalle_de_Registro_de_Intervinientes_CCfnClickAddRow() {
    Detalle_de_Registro_de_Intervinientes_CCcountRowsChecked++;
    Detalle_de_Registro_de_Intervinientes_CCTable.fnAddData(Detalle_de_Registro_de_Intervinientes_CCAddInsertRow(), true);
    Detalle_de_Registro_de_Intervinientes_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Registro_de_Intervinientes_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Registro_de_Intervinientes_CCGrid tbody tr:nth-of-type(' + (Detalle_de_Registro_de_Intervinientes_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Registro_de_Intervinientes_CC("Detalle_de_Registro_de_Intervinientes_CC_", "_" + Detalle_de_Registro_de_Intervinientes_CCinsertRowCurrentIndex);
}

function Detalle_de_Registro_de_Intervinientes_CCClearGridData() {
    Detalle_de_Registro_de_Intervinientes_CCData = [];
    Detalle_de_Registro_de_Intervinientes_CCdeletedItem = [];
    Detalle_de_Registro_de_Intervinientes_CCDataMain = [];
    Detalle_de_Registro_de_Intervinientes_CCDataMainPages = [];
    Detalle_de_Registro_de_Intervinientes_CCnewItemCount = 0;
    Detalle_de_Registro_de_Intervinientes_CCmaxItemIndex = 0;
    $("#Detalle_de_Registro_de_Intervinientes_CCGrid").DataTable().clear();
    $("#Detalle_de_Registro_de_Intervinientes_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Registro_de_Intervinientes_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Registro_de_Intervinientes_CCData[i].Clave);

        form_data.append('[' + i + '].Nombres', Detalle_de_Registro_de_Intervinientes_CCData[i].Nombres);
        form_data.append('[' + i + '].Apellido_Paterno', Detalle_de_Registro_de_Intervinientes_CCData[i].Apellido_Paterno);
        form_data.append('[' + i + '].Apellido_Materno', Detalle_de_Registro_de_Intervinientes_CCData[i].Apellido_Materno);
        form_data.append('[' + i + '].Alias', Detalle_de_Registro_de_Intervinientes_CCData[i].Alias);
        form_data.append('[' + i + '].Anonimo', Detalle_de_Registro_de_Intervinientes_CCData[i].Anonimo);
        form_data.append('[' + i + '].Fecha_de_Nacimiento', Detalle_de_Registro_de_Intervinientes_CCData[i].Fecha_de_Nacimiento);
        form_data.append('[' + i + '].Edad', Detalle_de_Registro_de_Intervinientes_CCData[i].Edad);
        form_data.append('[' + i + '].Sexo', Detalle_de_Registro_de_Intervinientes_CCData[i].Sexo);
        form_data.append('[' + i + '].Estado_Civil', Detalle_de_Registro_de_Intervinientes_CCData[i].Estado_Civil);
        form_data.append('[' + i + '].Tipo_de_Identificacion', Detalle_de_Registro_de_Intervinientes_CCData[i].Tipo_de_Identificacion);
        form_data.append('[' + i + '].Numero_de_Identificacion', Detalle_de_Registro_de_Intervinientes_CCData[i].Numero_de_Identificacion);
        form_data.append('[' + i + '].Escolaridad', Detalle_de_Registro_de_Intervinientes_CCData[i].Escolaridad);
        form_data.append('[' + i + '].Ocupacion', Detalle_de_Registro_de_Intervinientes_CCData[i].Ocupacion);
        form_data.append('[' + i + '].Nacionalidad', Detalle_de_Registro_de_Intervinientes_CCData[i].Nacionalidad);
        form_data.append('[' + i + '].Estado', Detalle_de_Registro_de_Intervinientes_CCData[i].Estado);
        form_data.append('[' + i + '].Municipio', Detalle_de_Registro_de_Intervinientes_CCData[i].Municipio);
        form_data.append('[' + i + '].Colonia', Detalle_de_Registro_de_Intervinientes_CCData[i].Colonia);
        form_data.append('[' + i + '].Codigo_Postal', Detalle_de_Registro_de_Intervinientes_CCData[i].Codigo_Postal);
        form_data.append('[' + i + '].Calle', Detalle_de_Registro_de_Intervinientes_CCData[i].Calle);
        form_data.append('[' + i + '].Numero_Exterior', Detalle_de_Registro_de_Intervinientes_CCData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Detalle_de_Registro_de_Intervinientes_CCData[i].Numero_Interior);
        form_data.append('[' + i + '].Telefono', Detalle_de_Registro_de_Intervinientes_CCData[i].Telefono);
        form_data.append('[' + i + '].Celular', Detalle_de_Registro_de_Intervinientes_CCData[i].Celular);
        form_data.append('[' + i + '].Correo_Electronico', Detalle_de_Registro_de_Intervinientes_CCData[i].Correo_Electronico);
        form_data.append('[' + i + '].Pais', Detalle_de_Registro_de_Intervinientes_CCData[i].Pais);

        form_data.append('[' + i + '].Entre_calle', Detalle_de_Registro_de_Intervinientes_CCData[i].Entre_calle);
        form_data.append('[' + i + '].Especifique', Detalle_de_Registro_de_Intervinientes_CCData[i].Especifique);
        form_data.append('[' + i + '].Extension', Detalle_de_Registro_de_Intervinientes_CCData[i].Extension);
        form_data.append('[' + i + '].Inimputable', Detalle_de_Registro_de_Intervinientes_CCData[i].Inimputable);
        form_data.append('[' + i + '].Nombre_Completo', Detalle_de_Registro_de_Intervinientes_CCData[i].Nombre_Completo);
        form_data.append('[' + i + '].Originario_de', Detalle_de_Registro_de_Intervinientes_CCData[i].Originario_de);
        form_data.append('[' + i + '].Pais_de_Origen', Detalle_de_Registro_de_Intervinientes_CCData[i].Pais_de_Origen);
        form_data.append('[' + i + '].Proteccion_de_Datos', Detalle_de_Registro_de_Intervinientes_CCData[i].Proteccion_de_Datos);
        form_data.append('[' + i + '].Referencia_de_Domicilio', Detalle_de_Registro_de_Intervinientes_CCData[i].Referencia_de_Domicilio);
        form_data.append('[' + i + '].Y_calle', Detalle_de_Registro_de_Intervinientes_CCData[i].Y_calle);
        form_data.append('[' + i + '].Tipo_de_Compareciente', Detalle_de_Registro_de_Intervinientes_CCData[i].Tipo_de_Compareciente);
        form_data.append('[' + i + '].Tipo_de_inimputabilidad', Detalle_de_Registro_de_Intervinientes_CCData[i].Tipo_de_inimputabilidad);
        form_data.append('[' + i + '].Nombre', Detalle_de_Registro_de_Intervinientes_CCData[i].Nombre);

        form_data.append('[' + i + '].Removed', Detalle_de_Registro_de_Intervinientes_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Registro_de_Intervinientes_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Registro_de_Intervinientes_CC("Detalle_de_Registro_de_Intervinientes_CCTable", rowIndex)) {
    var prevData = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Registro_de_Intervinientes_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombres: $('#Detalle_de_Registro_de_Intervinientes_CCNombres').val()
        ,Apellido_Paterno: $('#Detalle_de_Registro_de_Intervinientes_CCApellido_Paterno').val()
        ,Apellido_Materno: $('#Detalle_de_Registro_de_Intervinientes_CCApellido_Materno').val()
        ,Alias: $('#Detalle_de_Registro_de_Intervinientes_CCAlias').val()
        ,Anonimo: $('#Detalle_de_Registro_de_Intervinientes_CCAnonimo').is(':checked')
        ,Fecha_de_Nacimiento: $('#Detalle_de_Registro_de_Intervinientes_CCFecha_de_Nacimiento').val()
        ,Edad: $('#Detalle_de_Registro_de_Intervinientes_CCEdad').val()

        ,Sexo: $('#Detalle_de_Registro_de_Intervinientes_CCSexo').val()
        ,Estado_Civil: $('#Detalle_de_Registro_de_Intervinientes_CCEstado_Civil').val()
        ,Tipo_de_Identificacion: $('#Detalle_de_Registro_de_Intervinientes_CCTipo_de_Identificacion').val()
        ,Numero_de_Identificacion: $('#Detalle_de_Registro_de_Intervinientes_CCNumero_de_Identificacion').val()
        ,Escolaridad: $('#Detalle_de_Registro_de_Intervinientes_CCEscolaridad').val()
        ,Ocupacion: $('#Detalle_de_Registro_de_Intervinientes_CCOcupacion').val()
        ,Nacionalidad: $('#Detalle_de_Registro_de_Intervinientes_CCNacionalidad').val()
        ,Estado: $('#Detalle_de_Registro_de_Intervinientes_CCEstado').val()
        ,Municipio: $('#Detalle_de_Registro_de_Intervinientes_CCMunicipio').val()
        ,Colonia: $('#Detalle_de_Registro_de_Intervinientes_CCColonia').val()
        ,Codigo_Postal: $('#Detalle_de_Registro_de_Intervinientes_CCCodigo_Postal').val()

        ,Calle: $('#Detalle_de_Registro_de_Intervinientes_CCCalle').val()
        ,Numero_Exterior: $('#Detalle_de_Registro_de_Intervinientes_CCNumero_Exterior').val()
        ,Numero_Interior: $('#Detalle_de_Registro_de_Intervinientes_CCNumero_Interior').val()
        ,Telefono: $('#Detalle_de_Registro_de_Intervinientes_CCTelefono').val()
        ,Celular: $('#Detalle_de_Registro_de_Intervinientes_CCCelular').val()
        ,Correo_Electronico: $('#Detalle_de_Registro_de_Intervinientes_CCCorreo_Electronico').val()
        ,Pais: $('#Detalle_de_Registro_de_Intervinientes_CCPais').val()

        ,Entre_calle: $('#Detalle_de_Registro_de_Intervinientes_CCEntre_calle').val()
        ,Especifique: $('#Detalle_de_Registro_de_Intervinientes_CCEspecifique').val()
        ,Extension: $('#Detalle_de_Registro_de_Intervinientes_CCExtension').val()

        ,Inimputable: $('#Detalle_de_Registro_de_Intervinientes_CCInimputable').is(':checked')
        ,Nombre_Completo: $('#Detalle_de_Registro_de_Intervinientes_CCNombre_Completo').val()
        ,Originario_de: $('#Detalle_de_Registro_de_Intervinientes_CCOriginario_de').val()
        ,Pais_de_Origen: $('#Detalle_de_Registro_de_Intervinientes_CCPais_de_Origen').val()
        ,Proteccion_de_Datos: $('#Detalle_de_Registro_de_Intervinientes_CCProteccion_de_Datos').is(':checked')
        ,Referencia_de_Domicilio: $('#Detalle_de_Registro_de_Intervinientes_CCReferencia_de_Domicilio').val()
        ,Y_calle: $('#Detalle_de_Registro_de_Intervinientes_CCY_calle').val()
        ,Tipo_de_Compareciente: $('#Detalle_de_Registro_de_Intervinientes_CCTipo_de_Compareciente').val()
        ,Tipo_de_inimputabilidad: $('#Detalle_de_Registro_de_Intervinientes_CCTipo_de_inimputabilidad').val()
        ,Nombre: $('#Detalle_de_Registro_de_Intervinientes_CCNombre').val()

    }

    Detalle_de_Registro_de_Intervinientes_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Registro_de_Intervinientes_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Registro_de_Intervinientes_CC-form').modal({ show: false });
    $('#AddDetalle_de_Registro_de_Intervinientes_CC-form').modal('hide');
    Detalle_de_Registro_de_Intervinientes_CCEditRow(rowIndex);
    Detalle_de_Registro_de_Intervinientes_CCInsertRow(rowIndex);
    //}
}
function Detalle_de_Registro_de_Intervinientes_CCRemoveAddRow(rowIndex) {
    Detalle_de_Registro_de_Intervinientes_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Registro_de_Intervinientes_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Descripcion_de_Evidencia_CC MultiRow
var Detalle_de_Descripcion_de_Evidencia_CCcountRowsChecked = 0;










function GetInsertDetalle_de_Descripcion_de_Evidencia_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Descripcion_de_Evidencia_CC_Numero_de_Evidencia Numero_de_Evidencia').attr('id', 'Detalle_de_Descripcion_de_Evidencia_CC_Numero_de_Evidencia_' + index).attr('data-field', 'Numero_de_Evidencia');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Descripcion_de_Evidencia_CC_Descripcion_de_la_Evidencia Descripcion_de_la_Evidencia').attr('id', 'Detalle_de_Descripcion_de_Evidencia_CC_Descripcion_de_la_Evidencia_' + index).attr('data-field', 'Descripcion_de_la_Evidencia');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Descripcion_de_Evidencia_CC_Origen Origen').attr('id', 'Detalle_de_Descripcion_de_Evidencia_CC_Origen_' + index).attr('data-field', 'Origen');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Descripcion_de_Evidencia_CC_Descripcion Descripcion').attr('id', 'Detalle_de_Descripcion_de_Evidencia_CC_Descripcion_' + index).attr('data-field', 'Descripcion');
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Descripcion_de_Evidencia_CC_Examen_Solicitado Examen_Solicitado').attr('id', 'Detalle_de_Descripcion_de_Evidencia_CC_Examen_Solicitado_' + index).attr('data-field', 'Examen_Solicitado');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_de_Descripcion_de_Evidencia_CC_Codigo_de_Barras Codigo_de_Barras').attr('id', 'Detalle_de_Descripcion_de_Evidencia_CC_Codigo_de_Barras_' + index).attr('data-field', 'Codigo_de_Barras');
    columnData[6] = $($.parseHTML(inputData)).addClass('Detalle_de_Descripcion_de_Evidencia_CC_Archivo_de_Foto Archivo_de_Foto').attr('id', 'Detalle_de_Descripcion_de_Evidencia_CC_Archivo_de_Foto_' + index).attr('data-field', 'Archivo_de_Foto');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Descripcion_de_Evidencia_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Descripcion_de_Evidencia_CC("Detalle_de_Descripcion_de_Evidencia_CC_", "_" + rowIndex)) {
    var iPage = Detalle_de_Descripcion_de_Evidencia_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Descripcion_de_Evidencia_CC';
    var prevData = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_Evidencia: data.childNodes[counter++].childNodes[0].value
        ,Descripcion_de_la_Evidencia:  data.childNodes[counter++].childNodes[0].value
        ,Origen:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value
        ,Examen_Solicitado: data.childNodes[counter++].childNodes[0].value
        ,Codigo_de_Barras:  data.childNodes[counter++].childNodes[0].value
        ,Archivo_de_Foto:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Descripcion_de_Evidencia_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Descripcion_de_Evidencia_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Descripcion_de_Evidencia_CCTable.fnPageChange(iPage);
    Detalle_de_Descripcion_de_Evidencia_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Descripcion_de_Evidencia_CC("Detalle_de_Descripcion_de_Evidencia_CC_", "_" + rowIndex);
  }
}

function Detalle_de_Descripcion_de_Evidencia_CCCancelRow(rowIndex) {
    var prevData = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Descripcion_de_Evidencia_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Descripcion_de_Evidencia_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Descripcion_de_Evidencia_CCGrid(Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetData());
    Detalle_de_Descripcion_de_Evidencia_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Descripcion_de_Evidencia_CCFromDataTable() {
    var Detalle_de_Descripcion_de_Evidencia_CCData = [];
    var gridData = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Descripcion_de_Evidencia_CCData.push({
                Clave: gridData[i].Clave

                ,Numero_de_Evidencia: gridData[i].Numero_de_Evidencia
                ,Descripcion_de_la_Evidencia: gridData[i].Descripcion_de_la_Evidencia
                ,Origen: gridData[i].Origen
                ,Descripcion: gridData[i].Descripcion
                ,Examen_Solicitado: gridData[i].Examen_Solicitado
                ,Codigo_de_Barras: gridData[i].Codigo_de_Barras
                ,Archivo_de_Foto: gridData[i].Archivo_de_Foto

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Descripcion_de_Evidencia_CCData.length; i++) {
        if (removedDetalle_de_Descripcion_de_Evidencia_CCData[i] != null && removedDetalle_de_Descripcion_de_Evidencia_CCData[i].Clave > 0)
            Detalle_de_Descripcion_de_Evidencia_CCData.push({
                Clave: removedDetalle_de_Descripcion_de_Evidencia_CCData[i].Clave

                ,Numero_de_Evidencia: removedDetalle_de_Descripcion_de_Evidencia_CCData[i].Numero_de_Evidencia
                ,Descripcion_de_la_Evidencia: removedDetalle_de_Descripcion_de_Evidencia_CCData[i].Descripcion_de_la_Evidencia
                ,Origen: removedDetalle_de_Descripcion_de_Evidencia_CCData[i].Origen
                ,Descripcion: removedDetalle_de_Descripcion_de_Evidencia_CCData[i].Descripcion
                ,Examen_Solicitado: removedDetalle_de_Descripcion_de_Evidencia_CCData[i].Examen_Solicitado
                ,Codigo_de_Barras: removedDetalle_de_Descripcion_de_Evidencia_CCData[i].Codigo_de_Barras
                ,Archivo_de_Foto: removedDetalle_de_Descripcion_de_Evidencia_CCData[i].Archivo_de_Foto

                , Removed: true
            });
    }	

    return Detalle_de_Descripcion_de_Evidencia_CCData;
}

function Detalle_de_Descripcion_de_Evidencia_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Descripcion_de_Evidencia_CCcountRowsChecked++;
    var Detalle_de_Descripcion_de_Evidencia_CCRowElement = "Detalle_de_Descripcion_de_Evidencia_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Descripcion_de_Evidencia_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Descripcion_de_Evidencia_CCGetUpdateRowControls(prevData, "Detalle_de_Descripcion_de_Evidencia_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Descripcion_de_Evidencia_CCRowElement + "')){ Detalle_de_Descripcion_de_Evidencia_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Descripcion_de_Evidencia_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Descripcion_de_Evidencia_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Descripcion_de_Evidencia_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Descripcion_de_Evidencia_CCValidation();
    initiateUIControls();
    $('.Detalle_de_Descripcion_de_Evidencia_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Descripcion_de_Evidencia_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Descripcion_de_Evidencia_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetData().length;
    Detalle_de_Descripcion_de_Evidencia_CCfnClickAddRow();
    GetAddDetalle_de_Descripcion_de_Evidencia_CCPopup(currentRowIndex, 0);
}

function Detalle_de_Descripcion_de_Evidencia_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Descripcion_de_Evidencia_CCRowElement = "Detalle_de_Descripcion_de_Evidencia_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Descripcion_de_Evidencia_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Descripcion_de_Evidencia_CCNumero_de_Evidencia').val(prevData.Numero_de_Evidencia);
    $('#Detalle_de_Descripcion_de_Evidencia_CCDescripcion_de_la_Evidencia').val(prevData.Descripcion_de_la_Evidencia);
    $('#Detalle_de_Descripcion_de_Evidencia_CCOrigen').val(prevData.Origen);
    $('#Detalle_de_Descripcion_de_Evidencia_CCDescripcion').val(prevData.Descripcion);
    $('#Detalle_de_Descripcion_de_Evidencia_CCExamen_Solicitado').val(prevData.Examen_Solicitado);
    $('#Detalle_de_Descripcion_de_Evidencia_CCCodigo_de_Barras').val(prevData.Codigo_de_Barras);
    $('#Detalle_de_Descripcion_de_Evidencia_CCArchivo_de_Foto').val(prevData.Archivo_de_Foto);

    initiateUIControls();









}

function Detalle_de_Descripcion_de_Evidencia_CCAddInsertRow() {
    if (Detalle_de_Descripcion_de_Evidencia_CCinsertRowCurrentIndex < 1)
    {
        Detalle_de_Descripcion_de_Evidencia_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Numero_de_Evidencia: ""
        ,Descripcion_de_la_Evidencia: ""
        ,Origen: ""
        ,Descripcion: ""
        ,Examen_Solicitado: ""
        ,Codigo_de_Barras: ""
        ,Archivo_de_Foto: ""

    }
}

function Detalle_de_Descripcion_de_Evidencia_CCfnClickAddRow() {
    Detalle_de_Descripcion_de_Evidencia_CCcountRowsChecked++;
    Detalle_de_Descripcion_de_Evidencia_CCTable.fnAddData(Detalle_de_Descripcion_de_Evidencia_CCAddInsertRow(), true);
    Detalle_de_Descripcion_de_Evidencia_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Descripcion_de_Evidencia_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Descripcion_de_Evidencia_CCGrid tbody tr:nth-of-type(' + (Detalle_de_Descripcion_de_Evidencia_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Descripcion_de_Evidencia_CC("Detalle_de_Descripcion_de_Evidencia_CC_", "_" + Detalle_de_Descripcion_de_Evidencia_CCinsertRowCurrentIndex);
}

function Detalle_de_Descripcion_de_Evidencia_CCClearGridData() {
    Detalle_de_Descripcion_de_Evidencia_CCData = [];
    Detalle_de_Descripcion_de_Evidencia_CCdeletedItem = [];
    Detalle_de_Descripcion_de_Evidencia_CCDataMain = [];
    Detalle_de_Descripcion_de_Evidencia_CCDataMainPages = [];
    Detalle_de_Descripcion_de_Evidencia_CCnewItemCount = 0;
    Detalle_de_Descripcion_de_Evidencia_CCmaxItemIndex = 0;
    $("#Detalle_de_Descripcion_de_Evidencia_CCGrid").DataTable().clear();
    $("#Detalle_de_Descripcion_de_Evidencia_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Descripcion_de_Evidencia_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Descripcion_de_Evidencia_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Descripcion_de_Evidencia_CCData[i].Clave);

        form_data.append('[' + i + '].Numero_de_Evidencia', Detalle_de_Descripcion_de_Evidencia_CCData[i].Numero_de_Evidencia);
        form_data.append('[' + i + '].Descripcion_de_la_Evidencia', Detalle_de_Descripcion_de_Evidencia_CCData[i].Descripcion_de_la_Evidencia);
        form_data.append('[' + i + '].Origen', Detalle_de_Descripcion_de_Evidencia_CCData[i].Origen);
        form_data.append('[' + i + '].Descripcion', Detalle_de_Descripcion_de_Evidencia_CCData[i].Descripcion);
        form_data.append('[' + i + '].Examen_Solicitado', Detalle_de_Descripcion_de_Evidencia_CCData[i].Examen_Solicitado);
        form_data.append('[' + i + '].Codigo_de_Barras', Detalle_de_Descripcion_de_Evidencia_CCData[i].Codigo_de_Barras);
        form_data.append('[' + i + '].Archivo_de_Foto', Detalle_de_Descripcion_de_Evidencia_CCData[i].Archivo_de_Foto);

        form_data.append('[' + i + '].Removed', Detalle_de_Descripcion_de_Evidencia_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Descripcion_de_Evidencia_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Descripcion_de_Evidencia_CC("Detalle_de_Descripcion_de_Evidencia_CCTable", rowIndex)) {
    var prevData = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Descripcion_de_Evidencia_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_Evidencia: $('#Detalle_de_Descripcion_de_Evidencia_CCNumero_de_Evidencia').val()

        ,Descripcion_de_la_Evidencia: $('#Detalle_de_Descripcion_de_Evidencia_CCDescripcion_de_la_Evidencia').val()
        ,Origen: $('#Detalle_de_Descripcion_de_Evidencia_CCOrigen').val()
        ,Descripcion: $('#Detalle_de_Descripcion_de_Evidencia_CCDescripcion').val()
        ,Examen_Solicitado: $('#Detalle_de_Descripcion_de_Evidencia_CCExamen_Solicitado').val()

        ,Codigo_de_Barras: $('#Detalle_de_Descripcion_de_Evidencia_CCCodigo_de_Barras').val()
        ,Archivo_de_Foto: $('#Detalle_de_Descripcion_de_Evidencia_CCArchivo_de_Foto').val()

    }

    Detalle_de_Descripcion_de_Evidencia_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Descripcion_de_Evidencia_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Descripcion_de_Evidencia_CC-form').modal({ show: false });
    $('#AddDetalle_de_Descripcion_de_Evidencia_CC-form').modal('hide');
    Detalle_de_Descripcion_de_Evidencia_CCEditRow(rowIndex);
    Detalle_de_Descripcion_de_Evidencia_CCInsertRow(rowIndex);
    //}
}
function Detalle_de_Descripcion_de_Evidencia_CCRemoveAddRow(rowIndex) {
    Detalle_de_Descripcion_de_Evidencia_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Descripcion_de_Evidencia_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Lista_de_Documentos_CC MultiRow
var Detalle_de_Lista_de_Documentos_CCcountRowsChecked = 0;






function GetInsertDetalle_de_Lista_de_Documentos_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Lista_de_Documentos_CC_Fecha Fecha').attr('id', 'Detalle_de_Lista_de_Documentos_CC_Fecha_' + index).attr('data-field', 'Fecha');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Lista_de_Documentos_CC_Nombre_del_Archivo Nombre_del_Archivo').attr('id', 'Detalle_de_Lista_de_Documentos_CC_Nombre_del_Archivo_' + index).attr('data-field', 'Nombre_del_Archivo');
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Lista_de_Documentos_CC_Archivo Archivo').attr('id', 'Detalle_de_Lista_de_Documentos_CC_Archivo_' + index).attr('data-field', 'Archivo');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Lista_de_Documentos_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Lista_de_Documentos_CC("Detalle_de_Lista_de_Documentos_CC_", "_" + rowIndex)) {
    var iPage = Detalle_de_Lista_de_Documentos_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Lista_de_Documentos_CC';
    var prevData = Detalle_de_Lista_de_Documentos_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Lista_de_Documentos_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_del_Archivo:  data.childNodes[counter++].childNodes[0].value
        ,Archivo: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Lista_de_Documentos_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Lista_de_Documentos_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Lista_de_Documentos_CCTable.fnPageChange(iPage);
    Detalle_de_Lista_de_Documentos_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Lista_de_Documentos_CC("Detalle_de_Lista_de_Documentos_CC_", "_" + rowIndex);
  }
}

function Detalle_de_Lista_de_Documentos_CCCancelRow(rowIndex) {
    var prevData = Detalle_de_Lista_de_Documentos_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Lista_de_Documentos_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Lista_de_Documentos_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Lista_de_Documentos_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Lista_de_Documentos_CCGrid(Detalle_de_Lista_de_Documentos_CCTable.fnGetData());
    Detalle_de_Lista_de_Documentos_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Lista_de_Documentos_CCFromDataTable() {
    var Detalle_de_Lista_de_Documentos_CCData = [];
    var gridData = Detalle_de_Lista_de_Documentos_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Lista_de_Documentos_CCData.push({
                Clave: gridData[i].Clave

                ,Fecha: gridData[i].Fecha
                ,Nombre_del_Archivo: gridData[i].Nombre_del_Archivo
                ,Archivo: gridData[i].Archivo

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Lista_de_Documentos_CCData.length; i++) {
        if (removedDetalle_de_Lista_de_Documentos_CCData[i] != null && removedDetalle_de_Lista_de_Documentos_CCData[i].Clave > 0)
            Detalle_de_Lista_de_Documentos_CCData.push({
                Clave: removedDetalle_de_Lista_de_Documentos_CCData[i].Clave

                ,Fecha: removedDetalle_de_Lista_de_Documentos_CCData[i].Fecha
                ,Nombre_del_Archivo: removedDetalle_de_Lista_de_Documentos_CCData[i].Nombre_del_Archivo
                ,Archivo: removedDetalle_de_Lista_de_Documentos_CCData[i].Archivo

                , Removed: true
            });
    }	

    return Detalle_de_Lista_de_Documentos_CCData;
}

function Detalle_de_Lista_de_Documentos_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Lista_de_Documentos_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Lista_de_Documentos_CCcountRowsChecked++;
    var Detalle_de_Lista_de_Documentos_CCRowElement = "Detalle_de_Lista_de_Documentos_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Lista_de_Documentos_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Lista_de_Documentos_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Lista_de_Documentos_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Lista_de_Documentos_CCGetUpdateRowControls(prevData, "Detalle_de_Lista_de_Documentos_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Lista_de_Documentos_CCRowElement + "')){ Detalle_de_Lista_de_Documentos_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Lista_de_Documentos_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Lista_de_Documentos_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Lista_de_Documentos_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Lista_de_Documentos_CCValidation();
    initiateUIControls();
    $('.Detalle_de_Lista_de_Documentos_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Lista_de_Documentos_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Lista_de_Documentos_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Lista_de_Documentos_CCTable.fnGetData().length;
    Detalle_de_Lista_de_Documentos_CCfnClickAddRow();
    GetAddDetalle_de_Lista_de_Documentos_CCPopup(currentRowIndex, 0);
}

function Detalle_de_Lista_de_Documentos_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Lista_de_Documentos_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Lista_de_Documentos_CCRowElement = "Detalle_de_Lista_de_Documentos_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Lista_de_Documentos_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Lista_de_Documentos_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Lista_de_Documentos_CCFecha').val(prevData.Fecha);
    $('#Detalle_de_Lista_de_Documentos_CCNombre_del_Archivo').val(prevData.Nombre_del_Archivo);
    $('#Detalle_de_Lista_de_Documentos_CCArchivo').val(prevData.Archivo);

    initiateUIControls();





}

function Detalle_de_Lista_de_Documentos_CCAddInsertRow() {
    if (Detalle_de_Lista_de_Documentos_CCinsertRowCurrentIndex < 1)
    {
        Detalle_de_Lista_de_Documentos_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha: ""
        ,Nombre_del_Archivo: ""
        ,Archivo: ""

    }
}

function Detalle_de_Lista_de_Documentos_CCfnClickAddRow() {
    Detalle_de_Lista_de_Documentos_CCcountRowsChecked++;
    Detalle_de_Lista_de_Documentos_CCTable.fnAddData(Detalle_de_Lista_de_Documentos_CCAddInsertRow(), true);
    Detalle_de_Lista_de_Documentos_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Lista_de_Documentos_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Lista_de_Documentos_CCGrid tbody tr:nth-of-type(' + (Detalle_de_Lista_de_Documentos_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Lista_de_Documentos_CC("Detalle_de_Lista_de_Documentos_CC_", "_" + Detalle_de_Lista_de_Documentos_CCinsertRowCurrentIndex);
}

function Detalle_de_Lista_de_Documentos_CCClearGridData() {
    Detalle_de_Lista_de_Documentos_CCData = [];
    Detalle_de_Lista_de_Documentos_CCdeletedItem = [];
    Detalle_de_Lista_de_Documentos_CCDataMain = [];
    Detalle_de_Lista_de_Documentos_CCDataMainPages = [];
    Detalle_de_Lista_de_Documentos_CCnewItemCount = 0;
    Detalle_de_Lista_de_Documentos_CCmaxItemIndex = 0;
    $("#Detalle_de_Lista_de_Documentos_CCGrid").DataTable().clear();
    $("#Detalle_de_Lista_de_Documentos_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Lista_de_Documentos_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Lista_de_Documentos_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Lista_de_Documentos_CCData[i].Clave);

        form_data.append('[' + i + '].Fecha', Detalle_de_Lista_de_Documentos_CCData[i].Fecha);
        form_data.append('[' + i + '].Nombre_del_Archivo', Detalle_de_Lista_de_Documentos_CCData[i].Nombre_del_Archivo);
        form_data.append('[' + i + '].Archivo', Detalle_de_Lista_de_Documentos_CCData[i].Archivo);

        form_data.append('[' + i + '].Removed', Detalle_de_Lista_de_Documentos_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Lista_de_Documentos_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Lista_de_Documentos_CC("Detalle_de_Lista_de_Documentos_CCTable", rowIndex)) {
    var prevData = Detalle_de_Lista_de_Documentos_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Lista_de_Documentos_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha: $('#Detalle_de_Lista_de_Documentos_CCFecha').val()
        ,Nombre_del_Archivo: $('#Detalle_de_Lista_de_Documentos_CCNombre_del_Archivo').val()
        ,Archivo: $('#Detalle_de_Lista_de_Documentos_CCArchivo').val()


    }

    Detalle_de_Lista_de_Documentos_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Lista_de_Documentos_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Lista_de_Documentos_CC-form').modal({ show: false });
    $('#AddDetalle_de_Lista_de_Documentos_CC-form').modal('hide');
    Detalle_de_Lista_de_Documentos_CCEditRow(rowIndex);
    Detalle_de_Lista_de_Documentos_CCInsertRow(rowIndex);
    //}
}
function Detalle_de_Lista_de_Documentos_CCRemoveAddRow(rowIndex) {
    Detalle_de_Lista_de_Documentos_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Lista_de_Documentos_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Retroalimentacion MultiRow
var Detalle_de_RetroalimentacioncountRowsChecked = 0;







function GetInsertDetalle_de_RetroalimentacionRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Retroalimentacion_Usuario_que_Registra Usuario_que_Registra').attr('id', 'Detalle_de_Retroalimentacion_Usuario_que_Registra_' + index).attr('data-field', 'Usuario_que_Registra');
    columnData[1] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Retroalimentacion_Fecha_de_Registro Fecha_de_Registro').attr('id', 'Detalle_de_Retroalimentacion_Fecha_de_Registro_' + index).attr('data-field', 'Fecha_de_Registro');
    columnData[2] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Retroalimentacion_Hora_de_Registro Hora_de_Registro').attr('id', 'Detalle_de_Retroalimentacion_Hora_de_Registro_' + index).attr('data-field', 'Hora_de_Registro');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Retroalimentacion_Retroalimentacion Retroalimentacion').attr('id', 'Detalle_de_Retroalimentacion_Retroalimentacion_' + index).attr('data-field', 'Retroalimentacion');


    initiateUIControls();
    return columnData;
}

function Detalle_de_RetroalimentacionInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Retroalimentacion("Detalle_de_Retroalimentacion_", "_" + rowIndex)) {
    var iPage = Detalle_de_RetroalimentacionTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Retroalimentacion';
    var prevData = Detalle_de_RetroalimentacionTable.fnGetData(rowIndex);
    var data = Detalle_de_RetroalimentacionTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Usuario_que_Registra: data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Hora_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Retroalimentacion:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_RetroalimentacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_RetroalimentacionrowCreationGrid(data, newData, rowIndex);
    Detalle_de_RetroalimentacionTable.fnPageChange(iPage);
    Detalle_de_RetroalimentacioncountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Retroalimentacion("Detalle_de_Retroalimentacion_", "_" + rowIndex);
  }
}

function Detalle_de_RetroalimentacionCancelRow(rowIndex) {
    var prevData = Detalle_de_RetroalimentacionTable.fnGetData(rowIndex);
    var data = Detalle_de_RetroalimentacionTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_RetroalimentacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_RetroalimentacionrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_RetroalimentacionGrid(Detalle_de_RetroalimentacionTable.fnGetData());
    Detalle_de_RetroalimentacioncountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_RetroalimentacionFromDataTable() {
    var Detalle_de_RetroalimentacionData = [];
    var gridData = Detalle_de_RetroalimentacionTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_RetroalimentacionData.push({
                Clave: gridData[i].Clave

                ,Usuario_que_Registra: gridData[i].Usuario_que_Registra
                ,Fecha_de_Registro: gridData[i].Fecha_de_Registro
                ,Hora_de_Registro: gridData[i].Hora_de_Registro
                ,Retroalimentacion: gridData[i].Retroalimentacion

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_RetroalimentacionData.length; i++) {
        if (removedDetalle_de_RetroalimentacionData[i] != null && removedDetalle_de_RetroalimentacionData[i].Clave > 0)
            Detalle_de_RetroalimentacionData.push({
                Clave: removedDetalle_de_RetroalimentacionData[i].Clave

                ,Usuario_que_Registra: removedDetalle_de_RetroalimentacionData[i].Usuario_que_Registra
                ,Fecha_de_Registro: removedDetalle_de_RetroalimentacionData[i].Fecha_de_Registro
                ,Hora_de_Registro: removedDetalle_de_RetroalimentacionData[i].Hora_de_Registro
                ,Retroalimentacion: removedDetalle_de_RetroalimentacionData[i].Retroalimentacion

                , Removed: true
            });
    }	

    return Detalle_de_RetroalimentacionData;
}

function Detalle_de_RetroalimentacionEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_RetroalimentacionTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_RetroalimentacioncountRowsChecked++;
    var Detalle_de_RetroalimentacionRowElement = "Detalle_de_Retroalimentacion_" + rowIndex.toString();
    var prevData = Detalle_de_RetroalimentacionTable.fnGetData(rowIndexTable );
    var row = Detalle_de_RetroalimentacionTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Retroalimentacion_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_RetroalimentacionGetUpdateRowControls(prevData, "Detalle_de_Retroalimentacion_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_RetroalimentacionRowElement + "')){ Detalle_de_RetroalimentacionInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_RetroalimentacionCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_RetroalimentacionGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_RetroalimentacionGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_RetroalimentacionValidation();
    initiateUIControls();
    $('.Detalle_de_Retroalimentacion' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Retroalimentacion(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_RetroalimentacionfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_RetroalimentacionTable.fnGetData().length;
    Detalle_de_RetroalimentacionfnClickAddRow();
    GetAddDetalle_de_RetroalimentacionPopup(currentRowIndex, 0);
}

function Detalle_de_RetroalimentacionEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_RetroalimentacionTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_RetroalimentacionRowElement = "Detalle_de_Retroalimentacion_" + rowIndex.toString();
    var prevData = Detalle_de_RetroalimentacionTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_RetroalimentacionPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_RetroalimentacionUsuario_que_Registra').val(prevData.Usuario_que_Registra);
    $('#Detalle_de_RetroalimentacionFecha_de_Registro').val(prevData.Fecha_de_Registro);
    $('#Detalle_de_RetroalimentacionHora_de_Registro').val(prevData.Hora_de_Registro);
    $('#Detalle_de_RetroalimentacionRetroalimentacion').val(prevData.Retroalimentacion);

    initiateUIControls();






}

function Detalle_de_RetroalimentacionAddInsertRow() {
    if (Detalle_de_RetroalimentacioninsertRowCurrentIndex < 1)
    {
        Detalle_de_RetroalimentacioninsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Usuario_que_Registra: ""
        ,Fecha_de_Registro: ""
        ,Hora_de_Registro: ""
        ,Retroalimentacion: ""

    }
}

function Detalle_de_RetroalimentacionfnClickAddRow() {
    Detalle_de_RetroalimentacioncountRowsChecked++;
    Detalle_de_RetroalimentacionTable.fnAddData(Detalle_de_RetroalimentacionAddInsertRow(), true);
    Detalle_de_RetroalimentacionTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_RetroalimentacionGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_RetroalimentacionGrid tbody tr:nth-of-type(' + (Detalle_de_RetroalimentacioninsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Retroalimentacion("Detalle_de_Retroalimentacion_", "_" + Detalle_de_RetroalimentacioninsertRowCurrentIndex);
}

function Detalle_de_RetroalimentacionClearGridData() {
    Detalle_de_RetroalimentacionData = [];
    Detalle_de_RetroalimentaciondeletedItem = [];
    Detalle_de_RetroalimentacionDataMain = [];
    Detalle_de_RetroalimentacionDataMainPages = [];
    Detalle_de_RetroalimentacionnewItemCount = 0;
    Detalle_de_RetroalimentacionmaxItemIndex = 0;
    $("#Detalle_de_RetroalimentacionGrid").DataTable().clear();
    $("#Detalle_de_RetroalimentacionGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Retroalimentacion() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_RetroalimentacionData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_RetroalimentacionData[i].Clave);

        form_data.append('[' + i + '].Usuario_que_Registra', Detalle_de_RetroalimentacionData[i].Usuario_que_Registra);
        form_data.append('[' + i + '].Fecha_de_Registro', Detalle_de_RetroalimentacionData[i].Fecha_de_Registro);
        form_data.append('[' + i + '].Hora_de_Registro', Detalle_de_RetroalimentacionData[i].Hora_de_Registro);
        form_data.append('[' + i + '].Retroalimentacion', Detalle_de_RetroalimentacionData[i].Retroalimentacion);

        form_data.append('[' + i + '].Removed', Detalle_de_RetroalimentacionData[i].Removed);
    }
    return form_data;
}
function Detalle_de_RetroalimentacionInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Retroalimentacion("Detalle_de_RetroalimentacionTable", rowIndex)) {
    var prevData = Detalle_de_RetroalimentacionTable.fnGetData(rowIndex);
    var data = Detalle_de_RetroalimentacionTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Usuario_que_Registra: $('#Detalle_de_RetroalimentacionUsuario_que_Registra').val()

        ,Fecha_de_Registro: $('#Detalle_de_RetroalimentacionFecha_de_Registro').val()
        ,Hora_de_Registro: $('#Detalle_de_RetroalimentacionHora_de_Registro').val()
        ,Retroalimentacion: $('#Detalle_de_RetroalimentacionRetroalimentacion').val()

    }

    Detalle_de_RetroalimentacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_RetroalimentacionrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Retroalimentacion-form').modal({ show: false });
    $('#AddDetalle_de_Retroalimentacion-form').modal('hide');
    Detalle_de_RetroalimentacionEditRow(rowIndex);
    Detalle_de_RetroalimentacionInsertRow(rowIndex);
    //}
}
function Detalle_de_RetroalimentacionRemoveAddRow(rowIndex) {
    Detalle_de_RetroalimentacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Retroalimentacion MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Referencia MultiRow
var Detalle_de_ReferenciacountRowsChecked = 0;






function GetInsertDetalle_de_ReferenciaRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Referencia_Punto_de_Referencia Punto_de_Referencia').attr('id', 'Detalle_de_Referencia_Punto_de_Referencia_' + index).attr('data-field', 'Punto_de_Referencia');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Referencia_Descripcion Descripcion').attr('id', 'Detalle_de_Referencia_Descripcion_' + index).attr('data-field', 'Descripcion');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Referencia_Distancia Distancia').attr('id', 'Detalle_de_Referencia_Distancia_' + index).attr('data-field', 'Distancia');


    initiateUIControls();
    return columnData;
}

function Detalle_de_ReferenciaInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Referencia("Detalle_de_Referencia_", "_" + rowIndex)) {
    var iPage = Detalle_de_ReferenciaTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Referencia';
    var prevData = Detalle_de_ReferenciaTable.fnGetData(rowIndex);
    var data = Detalle_de_ReferenciaTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Punto_de_Referencia:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value
        ,Distancia:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_ReferenciaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_ReferenciarowCreationGrid(data, newData, rowIndex);
    Detalle_de_ReferenciaTable.fnPageChange(iPage);
    Detalle_de_ReferenciacountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Referencia("Detalle_de_Referencia_", "_" + rowIndex);
  }
}

function Detalle_de_ReferenciaCancelRow(rowIndex) {
    var prevData = Detalle_de_ReferenciaTable.fnGetData(rowIndex);
    var data = Detalle_de_ReferenciaTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_ReferenciaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_ReferenciarowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_ReferenciaGrid(Detalle_de_ReferenciaTable.fnGetData());
    Detalle_de_ReferenciacountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_ReferenciaFromDataTable() {
    var Detalle_de_ReferenciaData = [];
    var gridData = Detalle_de_ReferenciaTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_ReferenciaData.push({
                Clave: gridData[i].Clave

                ,Punto_de_Referencia: gridData[i].Punto_de_Referencia
                ,Descripcion: gridData[i].Descripcion
                ,Distancia: gridData[i].Distancia

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_ReferenciaData.length; i++) {
        if (removedDetalle_de_ReferenciaData[i] != null && removedDetalle_de_ReferenciaData[i].Clave > 0)
            Detalle_de_ReferenciaData.push({
                Clave: removedDetalle_de_ReferenciaData[i].Clave

                ,Punto_de_Referencia: removedDetalle_de_ReferenciaData[i].Punto_de_Referencia
                ,Descripcion: removedDetalle_de_ReferenciaData[i].Descripcion
                ,Distancia: removedDetalle_de_ReferenciaData[i].Distancia

                , Removed: true
            });
    }	

    return Detalle_de_ReferenciaData;
}

function Detalle_de_ReferenciaEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_ReferenciaTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_ReferenciacountRowsChecked++;
    var Detalle_de_ReferenciaRowElement = "Detalle_de_Referencia_" + rowIndex.toString();
    var prevData = Detalle_de_ReferenciaTable.fnGetData(rowIndexTable );
    var row = Detalle_de_ReferenciaTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Referencia_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_ReferenciaGetUpdateRowControls(prevData, "Detalle_de_Referencia_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_ReferenciaRowElement + "')){ Detalle_de_ReferenciaInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_ReferenciaCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_ReferenciaGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_ReferenciaGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_ReferenciaValidation();
    initiateUIControls();
    $('.Detalle_de_Referencia' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Referencia(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_ReferenciafnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_ReferenciaTable.fnGetData().length;
    Detalle_de_ReferenciafnClickAddRow();
    GetAddDetalle_de_ReferenciaPopup(currentRowIndex, 0);
}

function Detalle_de_ReferenciaEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_ReferenciaTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_ReferenciaRowElement = "Detalle_de_Referencia_" + rowIndex.toString();
    var prevData = Detalle_de_ReferenciaTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_ReferenciaPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_ReferenciaPunto_de_Referencia').val(prevData.Punto_de_Referencia);
    $('#Detalle_de_ReferenciaDescripcion').val(prevData.Descripcion);
    $('#Detalle_de_ReferenciaDistancia').val(prevData.Distancia);

    initiateUIControls();





}

function Detalle_de_ReferenciaAddInsertRow() {
    if (Detalle_de_ReferenciainsertRowCurrentIndex < 1)
    {
        Detalle_de_ReferenciainsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Punto_de_Referencia: ""
        ,Descripcion: ""
        ,Distancia: ""

    }
}

function Detalle_de_ReferenciafnClickAddRow() {
    Detalle_de_ReferenciacountRowsChecked++;
    Detalle_de_ReferenciaTable.fnAddData(Detalle_de_ReferenciaAddInsertRow(), true);
    Detalle_de_ReferenciaTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_ReferenciaGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_ReferenciaGrid tbody tr:nth-of-type(' + (Detalle_de_ReferenciainsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Referencia("Detalle_de_Referencia_", "_" + Detalle_de_ReferenciainsertRowCurrentIndex);
}

function Detalle_de_ReferenciaClearGridData() {
    Detalle_de_ReferenciaData = [];
    Detalle_de_ReferenciadeletedItem = [];
    Detalle_de_ReferenciaDataMain = [];
    Detalle_de_ReferenciaDataMainPages = [];
    Detalle_de_ReferencianewItemCount = 0;
    Detalle_de_ReferenciamaxItemIndex = 0;
    $("#Detalle_de_ReferenciaGrid").DataTable().clear();
    $("#Detalle_de_ReferenciaGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Referencia() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_ReferenciaData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_ReferenciaData[i].Clave);

        form_data.append('[' + i + '].Punto_de_Referencia', Detalle_de_ReferenciaData[i].Punto_de_Referencia);
        form_data.append('[' + i + '].Descripcion', Detalle_de_ReferenciaData[i].Descripcion);
        form_data.append('[' + i + '].Distancia', Detalle_de_ReferenciaData[i].Distancia);

        form_data.append('[' + i + '].Removed', Detalle_de_ReferenciaData[i].Removed);
    }
    return form_data;
}
function Detalle_de_ReferenciaInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Referencia("Detalle_de_ReferenciaTable", rowIndex)) {
    var prevData = Detalle_de_ReferenciaTable.fnGetData(rowIndex);
    var data = Detalle_de_ReferenciaTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Punto_de_Referencia: $('#Detalle_de_ReferenciaPunto_de_Referencia').val()
        ,Descripcion: $('#Detalle_de_ReferenciaDescripcion').val()
        ,Distancia: $('#Detalle_de_ReferenciaDistancia').val()

    }

    Detalle_de_ReferenciaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_ReferenciarowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Referencia-form').modal({ show: false });
    $('#AddDetalle_de_Referencia-form').modal('hide');
    Detalle_de_ReferenciaEditRow(rowIndex);
    Detalle_de_ReferenciaInsertRow(rowIndex);
    //}
}
function Detalle_de_ReferenciaRemoveAddRow(rowIndex) {
    Detalle_de_ReferenciaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Referencia MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Fotos_de_Emergencia_CC MultiRow
var Detalle_de_Fotos_de_Emergencia_CCcountRowsChecked = 0;







function GetInsertDetalle_de_Fotos_de_Emergencia_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Fotos_de_Emergencia_CC_Fecha Fecha').attr('id', 'Detalle_de_Fotos_de_Emergencia_CC_Fecha_' + index).attr('data-field', 'Fecha');
    columnData[1] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Fotos_de_Emergencia_CC_Hora Hora').attr('id', 'Detalle_de_Fotos_de_Emergencia_CC_Hora_' + index).attr('data-field', 'Hora');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Fotos_de_Emergencia_CC_Latitud Latitud').attr('id', 'Detalle_de_Fotos_de_Emergencia_CC_Latitud_' + index).attr('data-field', 'Latitud');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Fotos_de_Emergencia_CC_Longitud Longitud').attr('id', 'Detalle_de_Fotos_de_Emergencia_CC_Longitud_' + index).attr('data-field', 'Longitud');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Fotos_de_Emergencia_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Fotos_de_Emergencia_CC("Detalle_de_Fotos_de_Emergencia_CC_", "_" + rowIndex)) {
    var iPage = Detalle_de_Fotos_de_Emergencia_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Fotos_de_Emergencia_CC';
    var prevData = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha:  data.childNodes[counter++].childNodes[0].value
        ,Hora:  data.childNodes[counter++].childNodes[0].value
        ,Latitud:  data.childNodes[counter++].childNodes[0].value
        ,Longitud:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Fotos_de_Emergencia_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Fotos_de_Emergencia_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Fotos_de_Emergencia_CCTable.fnPageChange(iPage);
    Detalle_de_Fotos_de_Emergencia_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Fotos_de_Emergencia_CC("Detalle_de_Fotos_de_Emergencia_CC_", "_" + rowIndex);
  }
}

function Detalle_de_Fotos_de_Emergencia_CCCancelRow(rowIndex) {
    var prevData = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Fotos_de_Emergencia_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Fotos_de_Emergencia_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Fotos_de_Emergencia_CCGrid(Detalle_de_Fotos_de_Emergencia_CCTable.fnGetData());
    Detalle_de_Fotos_de_Emergencia_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Fotos_de_Emergencia_CCFromDataTable() {
    var Detalle_de_Fotos_de_Emergencia_CCData = [];
    var gridData = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Fotos_de_Emergencia_CCData.push({
                Clave: gridData[i].Clave

                ,Fecha: gridData[i].Fecha
                ,Hora: gridData[i].Hora
                ,Latitud: gridData[i].Latitud
                ,Longitud: gridData[i].Longitud

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Fotos_de_Emergencia_CCData.length; i++) {
        if (removedDetalle_de_Fotos_de_Emergencia_CCData[i] != null && removedDetalle_de_Fotos_de_Emergencia_CCData[i].Clave > 0)
            Detalle_de_Fotos_de_Emergencia_CCData.push({
                Clave: removedDetalle_de_Fotos_de_Emergencia_CCData[i].Clave

                ,Fecha: removedDetalle_de_Fotos_de_Emergencia_CCData[i].Fecha
                ,Hora: removedDetalle_de_Fotos_de_Emergencia_CCData[i].Hora
                ,Latitud: removedDetalle_de_Fotos_de_Emergencia_CCData[i].Latitud
                ,Longitud: removedDetalle_de_Fotos_de_Emergencia_CCData[i].Longitud

                , Removed: true
            });
    }	

    return Detalle_de_Fotos_de_Emergencia_CCData;
}

function Detalle_de_Fotos_de_Emergencia_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Fotos_de_Emergencia_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Fotos_de_Emergencia_CCcountRowsChecked++;
    var Detalle_de_Fotos_de_Emergencia_CCRowElement = "Detalle_de_Fotos_de_Emergencia_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Fotos_de_Emergencia_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Fotos_de_Emergencia_CCGetUpdateRowControls(prevData, "Detalle_de_Fotos_de_Emergencia_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Fotos_de_Emergencia_CCRowElement + "')){ Detalle_de_Fotos_de_Emergencia_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Fotos_de_Emergencia_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Fotos_de_Emergencia_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Fotos_de_Emergencia_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Fotos_de_Emergencia_CCValidation();
    initiateUIControls();
    $('.Detalle_de_Fotos_de_Emergencia_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Fotos_de_Emergencia_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Fotos_de_Emergencia_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetData().length;
    Detalle_de_Fotos_de_Emergencia_CCfnClickAddRow();
    GetAddDetalle_de_Fotos_de_Emergencia_CCPopup(currentRowIndex, 0);
}

function Detalle_de_Fotos_de_Emergencia_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Fotos_de_Emergencia_CCRowElement = "Detalle_de_Fotos_de_Emergencia_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Fotos_de_Emergencia_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Fotos_de_Emergencia_CCFecha').val(prevData.Fecha);
    $('#Detalle_de_Fotos_de_Emergencia_CCHora').val(prevData.Hora);
    $('#Detalle_de_Fotos_de_Emergencia_CCLatitud').val(prevData.Latitud);
    $('#Detalle_de_Fotos_de_Emergencia_CCLongitud').val(prevData.Longitud);

    initiateUIControls();






}

function Detalle_de_Fotos_de_Emergencia_CCAddInsertRow() {
    if (Detalle_de_Fotos_de_Emergencia_CCinsertRowCurrentIndex < 1)
    {
        Detalle_de_Fotos_de_Emergencia_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha: ""
        ,Hora: ""
        ,Latitud: ""
        ,Longitud: ""

    }
}

function Detalle_de_Fotos_de_Emergencia_CCfnClickAddRow() {
    Detalle_de_Fotos_de_Emergencia_CCcountRowsChecked++;
    Detalle_de_Fotos_de_Emergencia_CCTable.fnAddData(Detalle_de_Fotos_de_Emergencia_CCAddInsertRow(), true);
    Detalle_de_Fotos_de_Emergencia_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Fotos_de_Emergencia_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Fotos_de_Emergencia_CCGrid tbody tr:nth-of-type(' + (Detalle_de_Fotos_de_Emergencia_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Fotos_de_Emergencia_CC("Detalle_de_Fotos_de_Emergencia_CC_", "_" + Detalle_de_Fotos_de_Emergencia_CCinsertRowCurrentIndex);
}

function Detalle_de_Fotos_de_Emergencia_CCClearGridData() {
    Detalle_de_Fotos_de_Emergencia_CCData = [];
    Detalle_de_Fotos_de_Emergencia_CCdeletedItem = [];
    Detalle_de_Fotos_de_Emergencia_CCDataMain = [];
    Detalle_de_Fotos_de_Emergencia_CCDataMainPages = [];
    Detalle_de_Fotos_de_Emergencia_CCnewItemCount = 0;
    Detalle_de_Fotos_de_Emergencia_CCmaxItemIndex = 0;
    $("#Detalle_de_Fotos_de_Emergencia_CCGrid").DataTable().clear();
    $("#Detalle_de_Fotos_de_Emergencia_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Fotos_de_Emergencia_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Fotos_de_Emergencia_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Fotos_de_Emergencia_CCData[i].Clave);

        form_data.append('[' + i + '].Fecha', Detalle_de_Fotos_de_Emergencia_CCData[i].Fecha);
        form_data.append('[' + i + '].Hora', Detalle_de_Fotos_de_Emergencia_CCData[i].Hora);
        form_data.append('[' + i + '].Latitud', Detalle_de_Fotos_de_Emergencia_CCData[i].Latitud);
        form_data.append('[' + i + '].Longitud', Detalle_de_Fotos_de_Emergencia_CCData[i].Longitud);

        form_data.append('[' + i + '].Removed', Detalle_de_Fotos_de_Emergencia_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Fotos_de_Emergencia_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Fotos_de_Emergencia_CC("Detalle_de_Fotos_de_Emergencia_CCTable", rowIndex)) {
    var prevData = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Fotos_de_Emergencia_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha: $('#Detalle_de_Fotos_de_Emergencia_CCFecha').val()
        ,Hora: $('#Detalle_de_Fotos_de_Emergencia_CCHora').val()
        ,Latitud: $('#Detalle_de_Fotos_de_Emergencia_CCLatitud').val()
        ,Longitud: $('#Detalle_de_Fotos_de_Emergencia_CCLongitud').val()

    }

    Detalle_de_Fotos_de_Emergencia_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Fotos_de_Emergencia_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Fotos_de_Emergencia_CC-form').modal({ show: false });
    $('#AddDetalle_de_Fotos_de_Emergencia_CC-form').modal('hide');
    Detalle_de_Fotos_de_Emergencia_CCEditRow(rowIndex);
    Detalle_de_Fotos_de_Emergencia_CCInsertRow(rowIndex);
    //}
}
function Detalle_de_Fotos_de_Emergencia_CCRemoveAddRow(rowIndex) {
    Detalle_de_Fotos_de_Emergencia_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Fotos_de_Emergencia_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Historial_de_Emergencia_CC MultiRow
var Detalle_de_Historial_de_Emergencia_CCcountRowsChecked = 0;










function GetInsertDetalle_de_Historial_de_Emergencia_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Historial_de_Emergencia_CC_Fecha Fecha').attr('id', 'Detalle_de_Historial_de_Emergencia_CC_Fecha_' + index).attr('data-field', 'Fecha');
    columnData[1] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Historial_de_Emergencia_CC_Hora Hora').attr('id', 'Detalle_de_Historial_de_Emergencia_CC_Hora_' + index).attr('data-field', 'Hora');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Historial_de_Emergencia_CC_Latitud Latitud').attr('id', 'Detalle_de_Historial_de_Emergencia_CC_Latitud_' + index).attr('data-field', 'Latitud');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Historial_de_Emergencia_CC_Longitud Longitud').attr('id', 'Detalle_de_Historial_de_Emergencia_CC_Longitud_' + index).attr('data-field', 'Longitud');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_de_Historial_de_Emergencia_CC_Estatus Estatus').attr('id', 'Detalle_de_Historial_de_Emergencia_CC_Estatus_' + index).attr('data-field', 'Estatus');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_de_Historial_de_Emergencia_CC_Comentarios Comentarios').attr('id', 'Detalle_de_Historial_de_Emergencia_CC_Comentarios_' + index).attr('data-field', 'Comentarios');
    columnData[6] = $($.parseHTML(inputData)).addClass('Detalle_de_Historial_de_Emergencia_CC_Usuario_que_registra Usuario_que_registra').attr('id', 'Detalle_de_Historial_de_Emergencia_CC_Usuario_que_registra_' + index).attr('data-field', 'Usuario_que_registra');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Historial_de_Emergencia_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Historial_de_Emergencia_CC("Detalle_de_Historial_de_Emergencia_CC_", "_" + rowIndex)) {
    var iPage = Detalle_de_Historial_de_Emergencia_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Historial_de_Emergencia_CC';
    var prevData = Detalle_de_Historial_de_Emergencia_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Historial_de_Emergencia_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha:  data.childNodes[counter++].childNodes[0].value
        ,Hora:  data.childNodes[counter++].childNodes[0].value
        ,Latitud:  data.childNodes[counter++].childNodes[0].value
        ,Longitud:  data.childNodes[counter++].childNodes[0].value
        ,Estatus:  data.childNodes[counter++].childNodes[0].value
        ,Comentarios:  data.childNodes[counter++].childNodes[0].value
        ,Usuario_que_registra:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Historial_de_Emergencia_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Historial_de_Emergencia_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Historial_de_Emergencia_CCTable.fnPageChange(iPage);
    Detalle_de_Historial_de_Emergencia_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Historial_de_Emergencia_CC("Detalle_de_Historial_de_Emergencia_CC_", "_" + rowIndex);
  }
}

function Detalle_de_Historial_de_Emergencia_CCCancelRow(rowIndex) {
    var prevData = Detalle_de_Historial_de_Emergencia_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Historial_de_Emergencia_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Historial_de_Emergencia_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Historial_de_Emergencia_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Historial_de_Emergencia_CCGrid(Detalle_de_Historial_de_Emergencia_CCTable.fnGetData());
    Detalle_de_Historial_de_Emergencia_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Historial_de_Emergencia_CCFromDataTable() {
    var Detalle_de_Historial_de_Emergencia_CCData = [];
    var gridData = Detalle_de_Historial_de_Emergencia_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Historial_de_Emergencia_CCData.push({
                Clave: gridData[i].Clave

                ,Fecha: gridData[i].Fecha
                ,Hora: gridData[i].Hora
                ,Latitud: gridData[i].Latitud
                ,Longitud: gridData[i].Longitud
                ,Estatus: gridData[i].Estatus
                ,Comentarios: gridData[i].Comentarios
                ,Usuario_que_registra: gridData[i].Usuario_que_registra

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Historial_de_Emergencia_CCData.length; i++) {
        if (removedDetalle_de_Historial_de_Emergencia_CCData[i] != null && removedDetalle_de_Historial_de_Emergencia_CCData[i].Clave > 0)
            Detalle_de_Historial_de_Emergencia_CCData.push({
                Clave: removedDetalle_de_Historial_de_Emergencia_CCData[i].Clave

                ,Fecha: removedDetalle_de_Historial_de_Emergencia_CCData[i].Fecha
                ,Hora: removedDetalle_de_Historial_de_Emergencia_CCData[i].Hora
                ,Latitud: removedDetalle_de_Historial_de_Emergencia_CCData[i].Latitud
                ,Longitud: removedDetalle_de_Historial_de_Emergencia_CCData[i].Longitud
                ,Estatus: removedDetalle_de_Historial_de_Emergencia_CCData[i].Estatus
                ,Comentarios: removedDetalle_de_Historial_de_Emergencia_CCData[i].Comentarios
                ,Usuario_que_registra: removedDetalle_de_Historial_de_Emergencia_CCData[i].Usuario_que_registra

                , Removed: true
            });
    }	

    return Detalle_de_Historial_de_Emergencia_CCData;
}

function Detalle_de_Historial_de_Emergencia_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Historial_de_Emergencia_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Historial_de_Emergencia_CCcountRowsChecked++;
    var Detalle_de_Historial_de_Emergencia_CCRowElement = "Detalle_de_Historial_de_Emergencia_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Historial_de_Emergencia_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Historial_de_Emergencia_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Historial_de_Emergencia_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Historial_de_Emergencia_CCGetUpdateRowControls(prevData, "Detalle_de_Historial_de_Emergencia_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Historial_de_Emergencia_CCRowElement + "')){ Detalle_de_Historial_de_Emergencia_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Historial_de_Emergencia_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Historial_de_Emergencia_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Historial_de_Emergencia_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Historial_de_Emergencia_CCValidation();
    initiateUIControls();
    $('.Detalle_de_Historial_de_Emergencia_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Historial_de_Emergencia_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Historial_de_Emergencia_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Historial_de_Emergencia_CCTable.fnGetData().length;
    Detalle_de_Historial_de_Emergencia_CCfnClickAddRow();
    GetAddDetalle_de_Historial_de_Emergencia_CCPopup(currentRowIndex, 0);
}

function Detalle_de_Historial_de_Emergencia_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Historial_de_Emergencia_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Historial_de_Emergencia_CCRowElement = "Detalle_de_Historial_de_Emergencia_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Historial_de_Emergencia_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Historial_de_Emergencia_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Historial_de_Emergencia_CCFecha').val(prevData.Fecha);
    $('#Detalle_de_Historial_de_Emergencia_CCHora').val(prevData.Hora);
    $('#Detalle_de_Historial_de_Emergencia_CCLatitud').val(prevData.Latitud);
    $('#Detalle_de_Historial_de_Emergencia_CCLongitud').val(prevData.Longitud);
    $('#Detalle_de_Historial_de_Emergencia_CCEstatus').val(prevData.Estatus);
    $('#Detalle_de_Historial_de_Emergencia_CCComentarios').val(prevData.Comentarios);
    $('#Detalle_de_Historial_de_Emergencia_CCUsuario_que_registra').val(prevData.Usuario_que_registra);

    initiateUIControls();









}

function Detalle_de_Historial_de_Emergencia_CCAddInsertRow() {
    if (Detalle_de_Historial_de_Emergencia_CCinsertRowCurrentIndex < 1)
    {
        Detalle_de_Historial_de_Emergencia_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha: ""
        ,Hora: ""
        ,Latitud: ""
        ,Longitud: ""
        ,Estatus: ""
        ,Comentarios: ""
        ,Usuario_que_registra: ""

    }
}

function Detalle_de_Historial_de_Emergencia_CCfnClickAddRow() {
    Detalle_de_Historial_de_Emergencia_CCcountRowsChecked++;
    Detalle_de_Historial_de_Emergencia_CCTable.fnAddData(Detalle_de_Historial_de_Emergencia_CCAddInsertRow(), true);
    Detalle_de_Historial_de_Emergencia_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Historial_de_Emergencia_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Historial_de_Emergencia_CCGrid tbody tr:nth-of-type(' + (Detalle_de_Historial_de_Emergencia_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Historial_de_Emergencia_CC("Detalle_de_Historial_de_Emergencia_CC_", "_" + Detalle_de_Historial_de_Emergencia_CCinsertRowCurrentIndex);
}

function Detalle_de_Historial_de_Emergencia_CCClearGridData() {
    Detalle_de_Historial_de_Emergencia_CCData = [];
    Detalle_de_Historial_de_Emergencia_CCdeletedItem = [];
    Detalle_de_Historial_de_Emergencia_CCDataMain = [];
    Detalle_de_Historial_de_Emergencia_CCDataMainPages = [];
    Detalle_de_Historial_de_Emergencia_CCnewItemCount = 0;
    Detalle_de_Historial_de_Emergencia_CCmaxItemIndex = 0;
    $("#Detalle_de_Historial_de_Emergencia_CCGrid").DataTable().clear();
    $("#Detalle_de_Historial_de_Emergencia_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Historial_de_Emergencia_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Historial_de_Emergencia_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Historial_de_Emergencia_CCData[i].Clave);

        form_data.append('[' + i + '].Fecha', Detalle_de_Historial_de_Emergencia_CCData[i].Fecha);
        form_data.append('[' + i + '].Hora', Detalle_de_Historial_de_Emergencia_CCData[i].Hora);
        form_data.append('[' + i + '].Latitud', Detalle_de_Historial_de_Emergencia_CCData[i].Latitud);
        form_data.append('[' + i + '].Longitud', Detalle_de_Historial_de_Emergencia_CCData[i].Longitud);
        form_data.append('[' + i + '].Estatus', Detalle_de_Historial_de_Emergencia_CCData[i].Estatus);
        form_data.append('[' + i + '].Comentarios', Detalle_de_Historial_de_Emergencia_CCData[i].Comentarios);
        form_data.append('[' + i + '].Usuario_que_registra', Detalle_de_Historial_de_Emergencia_CCData[i].Usuario_que_registra);

        form_data.append('[' + i + '].Removed', Detalle_de_Historial_de_Emergencia_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Historial_de_Emergencia_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Historial_de_Emergencia_CC("Detalle_de_Historial_de_Emergencia_CCTable", rowIndex)) {
    var prevData = Detalle_de_Historial_de_Emergencia_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Historial_de_Emergencia_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha: $('#Detalle_de_Historial_de_Emergencia_CCFecha').val()
        ,Hora: $('#Detalle_de_Historial_de_Emergencia_CCHora').val()
        ,Latitud: $('#Detalle_de_Historial_de_Emergencia_CCLatitud').val()
        ,Longitud: $('#Detalle_de_Historial_de_Emergencia_CCLongitud').val()
        ,Estatus: $('#Detalle_de_Historial_de_Emergencia_CCEstatus').val()
        ,Comentarios: $('#Detalle_de_Historial_de_Emergencia_CCComentarios').val()
        ,Usuario_que_registra: $('#Detalle_de_Historial_de_Emergencia_CCUsuario_que_registra').val()

    }

    Detalle_de_Historial_de_Emergencia_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Historial_de_Emergencia_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Historial_de_Emergencia_CC-form').modal({ show: false });
    $('#AddDetalle_de_Historial_de_Emergencia_CC-form').modal('hide');
    Detalle_de_Historial_de_Emergencia_CCEditRow(rowIndex);
    Detalle_de_Historial_de_Emergencia_CCInsertRow(rowIndex);
    //}
}
function Detalle_de_Historial_de_Emergencia_CCRemoveAddRow(rowIndex) {
    Detalle_de_Historial_de_Emergencia_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Historial_de_Emergencia_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Datos_del_Imputado_CC MultiRow
var Detalle_de_Datos_del_Imputado_CCcountRowsChecked = 0;








function GetDetalle_de_Datos_del_Imputado_CC_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_ColoniaDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_ColoniaDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_ColoniaItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_CC_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_ColoniaDropdown;
}




function GetDetalle_de_Datos_del_Imputado_CC_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_EstadoItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_EstadoDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_EstadoDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_EstadoItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_CC_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_EstadoDropdown;
}
function GetDetalle_de_Datos_del_Imputado_CC_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_Estado_CivilItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_Estado_CivilItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_Estado_CivilDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_Estado_CivilDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_Estado_CivilItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_CC_Estado_CivilDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_Estado_CivilDropdown;
}




function GetDetalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadDropdown;
}

function GetDetalle_de_Datos_del_Imputado_CC_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_MunicipioDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_MunicipioDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_MunicipioItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_CC_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_MunicipioDropdown;
}
function GetDetalle_de_Datos_del_Imputado_CC_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_NacionalidadItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_NacionalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_NacionalidadDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_NacionalidadDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_NacionalidadItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_de_Datos_del_Imputado_CC_NacionalidadDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_NacionalidadDropdown;
}





function GetDetalle_de_Datos_del_Imputado_CC_OcupacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_OcupacionItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_OcupacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_OcupacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_OcupacionDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_OcupacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_OcupacionDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_OcupacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_OcupacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_OcupacionItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_OcupacionItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_CC_OcupacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_OcupacionDropdown;
}

function GetDetalle_de_Datos_del_Imputado_CC_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_PaisItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_PaisDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_PaisDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_PaisItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_CC_PaisDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_PaisDropdown;
}
function GetDetalle_de_Datos_del_Imputado_CC_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_PaisItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_PaisDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_PaisDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_PaisItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_CC_PaisDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_PaisDropdown;
}


function GetDetalle_de_Datos_del_Imputado_CC_GeneroName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_GeneroItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_GeneroItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_GeneroDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_GeneroDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_GeneroItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_GeneroItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_CC_GeneroDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_GeneroDropdown;
}

function GetDetalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionDropDown() {
    var Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionDropdown);
    if(Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionDropdown;
}



function GetInsertDetalle_de_Datos_del_Imputado_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Imputado_CC_A_Quien_Resulte_Responsable A_Quien_Resulte_Responsable').attr('id', 'Detalle_de_Datos_del_Imputado_CC_A_Quien_Resulte_Responsable_' + index).attr('data-field', 'A_Quien_Resulte_Responsable');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Alias Alias').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Alias_' + index).attr('data-field', 'Alias');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Apellido_Materno Apellido_Materno').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Apellido_Materno_' + index).attr('data-field', 'Apellido_Materno');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Apellido_Paterno Apellido_Paterno').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Apellido_Paterno_' + index).attr('data-field', 'Apellido_Paterno');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Calle Calle').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Calle_' + index).attr('data-field', 'Calle');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Celular Celular').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Celular_' + index).attr('data-field', 'Celular');
    columnData[6] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_CC_Codigo_Postal Codigo_Postal').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[7] = $(GetDetalle_de_Datos_del_Imputado_CC_ColoniaDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Colonia Colonia').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Colonia', 'Colonia', 265069)));
    columnData[8] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Correo_Electronico Correo_Electronico').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');
    columnData[9] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_CC_Edad Edad').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Edad_' + index).attr('data-field', 'Edad');
    columnData[10] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Entre_calle Entre_calle').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Entre_calle_' + index).attr('data-field', 'Entre_calle');
    columnData[11] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_CC_Escolaridad Escolaridad').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Escolaridad_' + index).attr('data-field', 'Escolaridad');
    columnData[12] = $(GetDetalle_de_Datos_del_Imputado_CC_EstadoDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Estado Estado').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Estado', 'Estado', 265074)));
    columnData[13] = $(GetDetalle_de_Datos_del_Imputado_CC_Estado_CivilDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Estado_Civil Estado_Civil').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Estado_Civil_' + index).attr('data-field', 'Estado_Civil').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Estado_Civil', 'Estado_Civil', 265075)));
    columnData[14] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Estension Estension').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Estension_' + index).attr('data-field', 'Estension');
    columnData[15] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_del_Imputado_CC_Fecha_de_Nacimiento Fecha_de_Nacimiento').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Fecha_de_Nacimiento_' + index).attr('data-field', 'Fecha_de_Nacimiento');

    columnData[16] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Imputado_CC_Inimputable Inimputable').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Inimputable_' + index).attr('data-field', 'Inimputable');
    columnData[17] = $(GetDetalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Tipo_de_Inimputabilidad Tipo_de_Inimputabilidad').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Tipo_de_Inimputabilidad_' + index).attr('data-field', 'Tipo_de_Inimputabilidad').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Tipo_de_Inimputabilidad', 'Tipo_de_Inimputabilidad', 265080)));
    columnData[18] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Especifique Especifique').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Especifique_' + index).attr('data-field', 'Especifique');
    columnData[19] = $(GetDetalle_de_Datos_del_Imputado_CC_MunicipioDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Municipio Municipio').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Municipio', 'Municipio', 265082)));
    columnData[20] = $(GetDetalle_de_Datos_del_Imputado_CC_NacionalidadDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Nacionalidad Nacionalidad').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Nacionalidad_' + index).attr('data-field', 'Nacionalidad').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Nacionalidad', 'Nacionalidad', 265083)));
    columnData[21] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Nombre Nombre').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Nombre_' + index).attr('data-field', 'Nombre');
    columnData[22] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Nombre_Completo Nombre_Completo').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Nombre_Completo_' + index).attr('data-field', 'Nombre_Completo');
    columnData[23] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Numero_de_Identificacion Numero_de_Identificacion').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Numero_de_Identificacion_' + index).attr('data-field', 'Numero_de_Identificacion');
    columnData[24] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Numero_Exterior Numero_Exterior').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[25] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Numero_Interior Numero_Interior').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[26] = $(GetDetalle_de_Datos_del_Imputado_CC_OcupacionDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Ocupacion Ocupacion').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Ocupacion_' + index).attr('data-field', 'Ocupacion').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Ocupacion', 'Ocupacion', 265089)));
    columnData[27] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Originario_de Originario_de').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Originario_de_' + index).attr('data-field', 'Originario_de');
    columnData[28] = $(GetDetalle_de_Datos_del_Imputado_CC_PaisDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Pais Pais').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Pais_' + index).attr('data-field', 'Pais').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Pais', 'Pais', 265091)));
    columnData[29] = $(GetDetalle_de_Datos_del_Imputado_CC_PaisDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Pais_de_Origen Pais_de_Origen').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Pais_de_Origen_' + index).attr('data-field', 'Pais_de_Origen').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Pais', 'Pais_de_Origen', 265092)));
    columnData[30] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Imputado_CC_Proteccion_de_datos Proteccion_de_datos').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Proteccion_de_datos_' + index).attr('data-field', 'Proteccion_de_datos');
    columnData[31] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Referencia_de_domicilio Referencia_de_domicilio').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Referencia_de_domicilio_' + index).attr('data-field', 'Referencia_de_domicilio');
    columnData[32] = $(GetDetalle_de_Datos_del_Imputado_CC_GeneroDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Genero Genero').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Genero_' + index).attr('data-field', 'Genero').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Genero', 'Genero', 265095)));
    columnData[33] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Telefono Telefono').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Telefono_' + index).attr('data-field', 'Telefono');
    columnData[34] = $(GetDetalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionDropDown()).addClass('Detalle_de_Datos_del_Imputado_CC_Tipo_de_Identificacion Tipo_de_Identificacion').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Tipo_de_Identificacion_' + index).attr('data-field', 'Tipo_de_Identificacion').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_CC', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion', 265097)));
    columnData[35] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_CC_Y_calle Y_calle').attr('id', 'Detalle_de_Datos_del_Imputado_CC_Y_calle_' + index).attr('data-field', 'Y_calle');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Datos_del_Imputado_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_del_Imputado_CC("Detalle_de_Datos_del_Imputado_CC_", "_" + rowIndex)) {
    var iPage = Detalle_de_Datos_del_Imputado_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Datos_del_Imputado_CC';
    var prevData = Detalle_de_Datos_del_Imputado_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Imputado_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,A_Quien_Resulte_Responsable: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Alias:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno:  data.childNodes[counter++].childNodes[0].value
        ,Calle:  data.childNodes[counter++].childNodes[0].value
        ,Celular:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal: data.childNodes[counter++].childNodes[0].value
        ,Colonia:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value
        ,Edad: data.childNodes[counter++].childNodes[0].value
        ,Entre_calle:  data.childNodes[counter++].childNodes[0].value
        ,Escolaridad: data.childNodes[counter++].childNodes[0].value
        ,Estado:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil:  data.childNodes[counter++].childNodes[0].value
        ,Estension:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Nacimiento:  data.childNodes[counter++].childNodes[0].value

        ,Inimputable: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Tipo_de_Inimputabilidad:  data.childNodes[counter++].childNodes[0].value
        ,Especifique:  data.childNodes[counter++].childNodes[0].value
        ,Municipio:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad:  data.childNodes[counter++].childNodes[0].value
        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_Completo:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value
        ,Ocupacion:  data.childNodes[counter++].childNodes[0].value
        ,Originario_de:  data.childNodes[counter++].childNodes[0].value
        ,Pais:  data.childNodes[counter++].childNodes[0].value
        ,Pais_de_Origen:  data.childNodes[counter++].childNodes[0].value
        ,Proteccion_de_datos: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Referencia_de_domicilio:  data.childNodes[counter++].childNodes[0].value
        ,Genero:  data.childNodes[counter++].childNodes[0].value
        ,Telefono:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Y_calle:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Datos_del_Imputado_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Datos_del_Imputado_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Datos_del_Imputado_CCTable.fnPageChange(iPage);
    Detalle_de_Datos_del_Imputado_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Datos_del_Imputado_CC("Detalle_de_Datos_del_Imputado_CC_", "_" + rowIndex);
  }
}

function Detalle_de_Datos_del_Imputado_CCCancelRow(rowIndex) {
    var prevData = Detalle_de_Datos_del_Imputado_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Imputado_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Datos_del_Imputado_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Datos_del_Imputado_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Datos_del_Imputado_CCGrid(Detalle_de_Datos_del_Imputado_CCTable.fnGetData());
    Detalle_de_Datos_del_Imputado_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Datos_del_Imputado_CCFromDataTable() {
    var Detalle_de_Datos_del_Imputado_CCData = [];
    var gridData = Detalle_de_Datos_del_Imputado_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Datos_del_Imputado_CCData.push({
                Clave: gridData[i].Clave

                ,A_Quien_Resulte_Responsable: gridData[i].A_Quien_Resulte_Responsable
                ,Alias: gridData[i].Alias
                ,Apellido_Materno: gridData[i].Apellido_Materno
                ,Apellido_Paterno: gridData[i].Apellido_Paterno
                ,Calle: gridData[i].Calle
                ,Celular: gridData[i].Celular
                ,Codigo_Postal: gridData[i].Codigo_Postal
                ,Colonia: gridData[i].Colonia
                ,Correo_Electronico: gridData[i].Correo_Electronico
                ,Edad: gridData[i].Edad
                ,Entre_calle: gridData[i].Entre_calle
                ,Escolaridad: gridData[i].Escolaridad
                ,Estado: gridData[i].Estado
                ,Estado_Civil: gridData[i].Estado_Civil
                ,Estension: gridData[i].Estension
                ,Fecha_de_Nacimiento: gridData[i].Fecha_de_Nacimiento

                ,Inimputable: gridData[i].Inimputable
                ,Tipo_de_Inimputabilidad: gridData[i].Tipo_de_Inimputabilidad
                ,Especifique: gridData[i].Especifique
                ,Municipio: gridData[i].Municipio
                ,Nacionalidad: gridData[i].Nacionalidad
                ,Nombre: gridData[i].Nombre
                ,Nombre_Completo: gridData[i].Nombre_Completo
                ,Numero_de_Identificacion: gridData[i].Numero_de_Identificacion
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior
                ,Ocupacion: gridData[i].Ocupacion
                ,Originario_de: gridData[i].Originario_de
                ,Pais: gridData[i].Pais
                ,Pais_de_Origen: gridData[i].Pais_de_Origen
                ,Proteccion_de_datos: gridData[i].Proteccion_de_datos
                ,Referencia_de_domicilio: gridData[i].Referencia_de_domicilio
                ,Genero: gridData[i].Genero
                ,Telefono: gridData[i].Telefono
                ,Tipo_de_Identificacion: gridData[i].Tipo_de_Identificacion
                ,Y_calle: gridData[i].Y_calle

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Datos_del_Imputado_CCData.length; i++) {
        if (removedDetalle_de_Datos_del_Imputado_CCData[i] != null && removedDetalle_de_Datos_del_Imputado_CCData[i].Clave > 0)
            Detalle_de_Datos_del_Imputado_CCData.push({
                Clave: removedDetalle_de_Datos_del_Imputado_CCData[i].Clave

                ,A_Quien_Resulte_Responsable: removedDetalle_de_Datos_del_Imputado_CCData[i].A_Quien_Resulte_Responsable
                ,Alias: removedDetalle_de_Datos_del_Imputado_CCData[i].Alias
                ,Apellido_Materno: removedDetalle_de_Datos_del_Imputado_CCData[i].Apellido_Materno
                ,Apellido_Paterno: removedDetalle_de_Datos_del_Imputado_CCData[i].Apellido_Paterno
                ,Calle: removedDetalle_de_Datos_del_Imputado_CCData[i].Calle
                ,Celular: removedDetalle_de_Datos_del_Imputado_CCData[i].Celular
                ,Codigo_Postal: removedDetalle_de_Datos_del_Imputado_CCData[i].Codigo_Postal
                ,Colonia: removedDetalle_de_Datos_del_Imputado_CCData[i].Colonia
                ,Correo_Electronico: removedDetalle_de_Datos_del_Imputado_CCData[i].Correo_Electronico
                ,Edad: removedDetalle_de_Datos_del_Imputado_CCData[i].Edad
                ,Entre_calle: removedDetalle_de_Datos_del_Imputado_CCData[i].Entre_calle
                ,Escolaridad: removedDetalle_de_Datos_del_Imputado_CCData[i].Escolaridad
                ,Estado: removedDetalle_de_Datos_del_Imputado_CCData[i].Estado
                ,Estado_Civil: removedDetalle_de_Datos_del_Imputado_CCData[i].Estado_Civil
                ,Estension: removedDetalle_de_Datos_del_Imputado_CCData[i].Estension
                ,Fecha_de_Nacimiento: removedDetalle_de_Datos_del_Imputado_CCData[i].Fecha_de_Nacimiento

                ,Inimputable: removedDetalle_de_Datos_del_Imputado_CCData[i].Inimputable
                ,Tipo_de_Inimputabilidad: removedDetalle_de_Datos_del_Imputado_CCData[i].Tipo_de_Inimputabilidad
                ,Especifique: removedDetalle_de_Datos_del_Imputado_CCData[i].Especifique
                ,Municipio: removedDetalle_de_Datos_del_Imputado_CCData[i].Municipio
                ,Nacionalidad: removedDetalle_de_Datos_del_Imputado_CCData[i].Nacionalidad
                ,Nombre: removedDetalle_de_Datos_del_Imputado_CCData[i].Nombre
                ,Nombre_Completo: removedDetalle_de_Datos_del_Imputado_CCData[i].Nombre_Completo
                ,Numero_de_Identificacion: removedDetalle_de_Datos_del_Imputado_CCData[i].Numero_de_Identificacion
                ,Numero_Exterior: removedDetalle_de_Datos_del_Imputado_CCData[i].Numero_Exterior
                ,Numero_Interior: removedDetalle_de_Datos_del_Imputado_CCData[i].Numero_Interior
                ,Ocupacion: removedDetalle_de_Datos_del_Imputado_CCData[i].Ocupacion
                ,Originario_de: removedDetalle_de_Datos_del_Imputado_CCData[i].Originario_de
                ,Pais: removedDetalle_de_Datos_del_Imputado_CCData[i].Pais
                ,Pais_de_Origen: removedDetalle_de_Datos_del_Imputado_CCData[i].Pais_de_Origen
                ,Proteccion_de_datos: removedDetalle_de_Datos_del_Imputado_CCData[i].Proteccion_de_datos
                ,Referencia_de_domicilio: removedDetalle_de_Datos_del_Imputado_CCData[i].Referencia_de_domicilio
                ,Genero: removedDetalle_de_Datos_del_Imputado_CCData[i].Genero
                ,Telefono: removedDetalle_de_Datos_del_Imputado_CCData[i].Telefono
                ,Tipo_de_Identificacion: removedDetalle_de_Datos_del_Imputado_CCData[i].Tipo_de_Identificacion
                ,Y_calle: removedDetalle_de_Datos_del_Imputado_CCData[i].Y_calle

                , Removed: true
            });
    }	

    return Detalle_de_Datos_del_Imputado_CCData;
}

function Detalle_de_Datos_del_Imputado_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Datos_del_Imputado_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Datos_del_Imputado_CCcountRowsChecked++;
    var Detalle_de_Datos_del_Imputado_CCRowElement = "Detalle_de_Datos_del_Imputado_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Datos_del_Imputado_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Datos_del_Imputado_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Datos_del_Imputado_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Datos_del_Imputado_CCGetUpdateRowControls(prevData, "Detalle_de_Datos_del_Imputado_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Datos_del_Imputado_CCRowElement + "')){ Detalle_de_Datos_del_Imputado_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Datos_del_Imputado_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Datos_del_Imputado_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Datos_del_Imputado_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Datos_del_Imputado_CCValidation();
    initiateUIControls();
    $('.Detalle_de_Datos_del_Imputado_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Datos_del_Imputado_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Datos_del_Imputado_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Datos_del_Imputado_CCTable.fnGetData().length;
    Detalle_de_Datos_del_Imputado_CCfnClickAddRow();
    GetAddDetalle_de_Datos_del_Imputado_CCPopup(currentRowIndex, 0);
}

function Detalle_de_Datos_del_Imputado_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Datos_del_Imputado_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Datos_del_Imputado_CCRowElement = "Detalle_de_Datos_del_Imputado_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Datos_del_Imputado_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Datos_del_Imputado_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Datos_del_Imputado_CCA_Quien_Resulte_Responsable').prop('checked', prevData.A_Quien_Resulte_Responsable);
    $('#Detalle_de_Datos_del_Imputado_CCAlias').val(prevData.Alias);
    $('#Detalle_de_Datos_del_Imputado_CCApellido_Materno').val(prevData.Apellido_Materno);
    $('#Detalle_de_Datos_del_Imputado_CCApellido_Paterno').val(prevData.Apellido_Paterno);
    $('#Detalle_de_Datos_del_Imputado_CCCalle').val(prevData.Calle);
    $('#Detalle_de_Datos_del_Imputado_CCCelular').val(prevData.Celular);
    $('#Detalle_de_Datos_del_Imputado_CCCodigo_Postal').val(prevData.Codigo_Postal);
    $('#Detalle_de_Datos_del_Imputado_CCColonia').val(prevData.Colonia);
    $('#Detalle_de_Datos_del_Imputado_CCCorreo_Electronico').val(prevData.Correo_Electronico);
    $('#Detalle_de_Datos_del_Imputado_CCEdad').val(prevData.Edad);
    $('#Detalle_de_Datos_del_Imputado_CCEntre_calle').val(prevData.Entre_calle);
    $('#Detalle_de_Datos_del_Imputado_CCEscolaridad').val(prevData.Escolaridad);
    $('#Detalle_de_Datos_del_Imputado_CCEstado').val(prevData.Estado);
    $('#Detalle_de_Datos_del_Imputado_CCEstado_Civil').val(prevData.Estado_Civil);
    $('#Detalle_de_Datos_del_Imputado_CCEstension').val(prevData.Estension);
    $('#Detalle_de_Datos_del_Imputado_CCFecha_de_Nacimiento').val(prevData.Fecha_de_Nacimiento);

    $('#Detalle_de_Datos_del_Imputado_CCInimputable').prop('checked', prevData.Inimputable);
    $('#Detalle_de_Datos_del_Imputado_CCTipo_de_Inimputabilidad').val(prevData.Tipo_de_Inimputabilidad);
    $('#Detalle_de_Datos_del_Imputado_CCEspecifique').val(prevData.Especifique);
    $('#Detalle_de_Datos_del_Imputado_CCMunicipio').val(prevData.Municipio);
    $('#Detalle_de_Datos_del_Imputado_CCNacionalidad').val(prevData.Nacionalidad);
    $('#Detalle_de_Datos_del_Imputado_CCNombre').val(prevData.Nombre);
    $('#Detalle_de_Datos_del_Imputado_CCNombre_Completo').val(prevData.Nombre_Completo);
    $('#Detalle_de_Datos_del_Imputado_CCNumero_de_Identificacion').val(prevData.Numero_de_Identificacion);
    $('#Detalle_de_Datos_del_Imputado_CCNumero_Exterior').val(prevData.Numero_Exterior);
    $('#Detalle_de_Datos_del_Imputado_CCNumero_Interior').val(prevData.Numero_Interior);
    $('#Detalle_de_Datos_del_Imputado_CCOcupacion').val(prevData.Ocupacion);
    $('#Detalle_de_Datos_del_Imputado_CCOriginario_de').val(prevData.Originario_de);
    $('#Detalle_de_Datos_del_Imputado_CCPais').val(prevData.Pais);
    $('#Detalle_de_Datos_del_Imputado_CCPais_de_Origen').val(prevData.Pais_de_Origen);
    $('#Detalle_de_Datos_del_Imputado_CCProteccion_de_datos').prop('checked', prevData.Proteccion_de_datos);
    $('#Detalle_de_Datos_del_Imputado_CCReferencia_de_domicilio').val(prevData.Referencia_de_domicilio);
    $('#Detalle_de_Datos_del_Imputado_CCGenero').val(prevData.Genero);
    $('#Detalle_de_Datos_del_Imputado_CCTelefono').val(prevData.Telefono);
    $('#Detalle_de_Datos_del_Imputado_CCTipo_de_Identificacion').val(prevData.Tipo_de_Identificacion);
    $('#Detalle_de_Datos_del_Imputado_CCY_calle').val(prevData.Y_calle);

    initiateUIControls();







































}

function Detalle_de_Datos_del_Imputado_CCAddInsertRow() {
    if (Detalle_de_Datos_del_Imputado_CCinsertRowCurrentIndex < 1)
    {
        Detalle_de_Datos_del_Imputado_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,A_Quien_Resulte_Responsable: ""
        ,Alias: ""
        ,Apellido_Materno: ""
        ,Apellido_Paterno: ""
        ,Calle: ""
        ,Celular: ""
        ,Codigo_Postal: ""
        ,Colonia: ""
        ,Correo_Electronico: ""
        ,Edad: ""
        ,Entre_calle: ""
        ,Escolaridad: ""
        ,Estado: ""
        ,Estado_Civil: ""
        ,Estension: ""
        ,Fecha_de_Nacimiento: ""

        ,Inimputable: ""
        ,Tipo_de_Inimputabilidad: ""
        ,Especifique: ""
        ,Municipio: ""
        ,Nacionalidad: ""
        ,Nombre: ""
        ,Nombre_Completo: ""
        ,Numero_de_Identificacion: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""
        ,Ocupacion: ""
        ,Originario_de: ""
        ,Pais: ""
        ,Pais_de_Origen: ""
        ,Proteccion_de_datos: ""
        ,Referencia_de_domicilio: ""
        ,Genero: ""
        ,Telefono: ""
        ,Tipo_de_Identificacion: ""
        ,Y_calle: ""

    }
}

function Detalle_de_Datos_del_Imputado_CCfnClickAddRow() {
    Detalle_de_Datos_del_Imputado_CCcountRowsChecked++;
    Detalle_de_Datos_del_Imputado_CCTable.fnAddData(Detalle_de_Datos_del_Imputado_CCAddInsertRow(), true);
    Detalle_de_Datos_del_Imputado_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Datos_del_Imputado_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Datos_del_Imputado_CCGrid tbody tr:nth-of-type(' + (Detalle_de_Datos_del_Imputado_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Datos_del_Imputado_CC("Detalle_de_Datos_del_Imputado_CC_", "_" + Detalle_de_Datos_del_Imputado_CCinsertRowCurrentIndex);
}

function Detalle_de_Datos_del_Imputado_CCClearGridData() {
    Detalle_de_Datos_del_Imputado_CCData = [];
    Detalle_de_Datos_del_Imputado_CCdeletedItem = [];
    Detalle_de_Datos_del_Imputado_CCDataMain = [];
    Detalle_de_Datos_del_Imputado_CCDataMainPages = [];
    Detalle_de_Datos_del_Imputado_CCnewItemCount = 0;
    Detalle_de_Datos_del_Imputado_CCmaxItemIndex = 0;
    $("#Detalle_de_Datos_del_Imputado_CCGrid").DataTable().clear();
    $("#Detalle_de_Datos_del_Imputado_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Datos_del_Imputado_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Datos_del_Imputado_CCData[i].Clave);

        form_data.append('[' + i + '].A_Quien_Resulte_Responsable', Detalle_de_Datos_del_Imputado_CCData[i].A_Quien_Resulte_Responsable);
        form_data.append('[' + i + '].Alias', Detalle_de_Datos_del_Imputado_CCData[i].Alias);
        form_data.append('[' + i + '].Apellido_Materno', Detalle_de_Datos_del_Imputado_CCData[i].Apellido_Materno);
        form_data.append('[' + i + '].Apellido_Paterno', Detalle_de_Datos_del_Imputado_CCData[i].Apellido_Paterno);
        form_data.append('[' + i + '].Calle', Detalle_de_Datos_del_Imputado_CCData[i].Calle);
        form_data.append('[' + i + '].Celular', Detalle_de_Datos_del_Imputado_CCData[i].Celular);
        form_data.append('[' + i + '].Codigo_Postal', Detalle_de_Datos_del_Imputado_CCData[i].Codigo_Postal);
        form_data.append('[' + i + '].Colonia', Detalle_de_Datos_del_Imputado_CCData[i].Colonia);
        form_data.append('[' + i + '].Correo_Electronico', Detalle_de_Datos_del_Imputado_CCData[i].Correo_Electronico);
        form_data.append('[' + i + '].Edad', Detalle_de_Datos_del_Imputado_CCData[i].Edad);
        form_data.append('[' + i + '].Entre_calle', Detalle_de_Datos_del_Imputado_CCData[i].Entre_calle);
        form_data.append('[' + i + '].Escolaridad', Detalle_de_Datos_del_Imputado_CCData[i].Escolaridad);
        form_data.append('[' + i + '].Estado', Detalle_de_Datos_del_Imputado_CCData[i].Estado);
        form_data.append('[' + i + '].Estado_Civil', Detalle_de_Datos_del_Imputado_CCData[i].Estado_Civil);
        form_data.append('[' + i + '].Estension', Detalle_de_Datos_del_Imputado_CCData[i].Estension);
        form_data.append('[' + i + '].Fecha_de_Nacimiento', Detalle_de_Datos_del_Imputado_CCData[i].Fecha_de_Nacimiento);

        form_data.append('[' + i + '].Inimputable', Detalle_de_Datos_del_Imputado_CCData[i].Inimputable);
        form_data.append('[' + i + '].Tipo_de_Inimputabilidad', Detalle_de_Datos_del_Imputado_CCData[i].Tipo_de_Inimputabilidad);
        form_data.append('[' + i + '].Especifique', Detalle_de_Datos_del_Imputado_CCData[i].Especifique);
        form_data.append('[' + i + '].Municipio', Detalle_de_Datos_del_Imputado_CCData[i].Municipio);
        form_data.append('[' + i + '].Nacionalidad', Detalle_de_Datos_del_Imputado_CCData[i].Nacionalidad);
        form_data.append('[' + i + '].Nombre', Detalle_de_Datos_del_Imputado_CCData[i].Nombre);
        form_data.append('[' + i + '].Nombre_Completo', Detalle_de_Datos_del_Imputado_CCData[i].Nombre_Completo);
        form_data.append('[' + i + '].Numero_de_Identificacion', Detalle_de_Datos_del_Imputado_CCData[i].Numero_de_Identificacion);
        form_data.append('[' + i + '].Numero_Exterior', Detalle_de_Datos_del_Imputado_CCData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Detalle_de_Datos_del_Imputado_CCData[i].Numero_Interior);
        form_data.append('[' + i + '].Ocupacion', Detalle_de_Datos_del_Imputado_CCData[i].Ocupacion);
        form_data.append('[' + i + '].Originario_de', Detalle_de_Datos_del_Imputado_CCData[i].Originario_de);
        form_data.append('[' + i + '].Pais', Detalle_de_Datos_del_Imputado_CCData[i].Pais);
        form_data.append('[' + i + '].Pais_de_Origen', Detalle_de_Datos_del_Imputado_CCData[i].Pais_de_Origen);
        form_data.append('[' + i + '].Proteccion_de_datos', Detalle_de_Datos_del_Imputado_CCData[i].Proteccion_de_datos);
        form_data.append('[' + i + '].Referencia_de_domicilio', Detalle_de_Datos_del_Imputado_CCData[i].Referencia_de_domicilio);
        form_data.append('[' + i + '].Genero', Detalle_de_Datos_del_Imputado_CCData[i].Genero);
        form_data.append('[' + i + '].Telefono', Detalle_de_Datos_del_Imputado_CCData[i].Telefono);
        form_data.append('[' + i + '].Tipo_de_Identificacion', Detalle_de_Datos_del_Imputado_CCData[i].Tipo_de_Identificacion);
        form_data.append('[' + i + '].Y_calle', Detalle_de_Datos_del_Imputado_CCData[i].Y_calle);

        form_data.append('[' + i + '].Removed', Detalle_de_Datos_del_Imputado_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Datos_del_Imputado_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_del_Imputado_CC("Detalle_de_Datos_del_Imputado_CCTable", rowIndex)) {
    var prevData = Detalle_de_Datos_del_Imputado_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Imputado_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,A_Quien_Resulte_Responsable: $('#Detalle_de_Datos_del_Imputado_CCA_Quien_Resulte_Responsable').is(':checked')
        ,Alias: $('#Detalle_de_Datos_del_Imputado_CCAlias').val()
        ,Apellido_Materno: $('#Detalle_de_Datos_del_Imputado_CCApellido_Materno').val()
        ,Apellido_Paterno: $('#Detalle_de_Datos_del_Imputado_CCApellido_Paterno').val()
        ,Calle: $('#Detalle_de_Datos_del_Imputado_CCCalle').val()
        ,Celular: $('#Detalle_de_Datos_del_Imputado_CCCelular').val()
        ,Codigo_Postal: $('#Detalle_de_Datos_del_Imputado_CCCodigo_Postal').val()

        ,Colonia: $('#Detalle_de_Datos_del_Imputado_CCColonia').val()
        ,Correo_Electronico: $('#Detalle_de_Datos_del_Imputado_CCCorreo_Electronico').val()
        ,Edad: $('#Detalle_de_Datos_del_Imputado_CCEdad').val()

        ,Entre_calle: $('#Detalle_de_Datos_del_Imputado_CCEntre_calle').val()
        ,Escolaridad: $('#Detalle_de_Datos_del_Imputado_CCEscolaridad').val()

        ,Estado: $('#Detalle_de_Datos_del_Imputado_CCEstado').val()
        ,Estado_Civil: $('#Detalle_de_Datos_del_Imputado_CCEstado_Civil').val()
        ,Estension: $('#Detalle_de_Datos_del_Imputado_CCEstension').val()
        ,Fecha_de_Nacimiento: $('#Detalle_de_Datos_del_Imputado_CCFecha_de_Nacimiento').val()

        ,Inimputable: $('#Detalle_de_Datos_del_Imputado_CCInimputable').is(':checked')
        ,Tipo_de_Inimputabilidad: $('#Detalle_de_Datos_del_Imputado_CCTipo_de_Inimputabilidad').val()
        ,Especifique: $('#Detalle_de_Datos_del_Imputado_CCEspecifique').val()
        ,Municipio: $('#Detalle_de_Datos_del_Imputado_CCMunicipio').val()
        ,Nacionalidad: $('#Detalle_de_Datos_del_Imputado_CCNacionalidad').val()
        ,Nombre: $('#Detalle_de_Datos_del_Imputado_CCNombre').val()
        ,Nombre_Completo: $('#Detalle_de_Datos_del_Imputado_CCNombre_Completo').val()
        ,Numero_de_Identificacion: $('#Detalle_de_Datos_del_Imputado_CCNumero_de_Identificacion').val()
        ,Numero_Exterior: $('#Detalle_de_Datos_del_Imputado_CCNumero_Exterior').val()
        ,Numero_Interior: $('#Detalle_de_Datos_del_Imputado_CCNumero_Interior').val()
        ,Ocupacion: $('#Detalle_de_Datos_del_Imputado_CCOcupacion').val()
        ,Originario_de: $('#Detalle_de_Datos_del_Imputado_CCOriginario_de').val()
        ,Pais: $('#Detalle_de_Datos_del_Imputado_CCPais').val()
        ,Pais_de_Origen: $('#Detalle_de_Datos_del_Imputado_CCPais_de_Origen').val()
        ,Proteccion_de_datos: $('#Detalle_de_Datos_del_Imputado_CCProteccion_de_datos').is(':checked')
        ,Referencia_de_domicilio: $('#Detalle_de_Datos_del_Imputado_CCReferencia_de_domicilio').val()
        ,Genero: $('#Detalle_de_Datos_del_Imputado_CCGenero').val()
        ,Telefono: $('#Detalle_de_Datos_del_Imputado_CCTelefono').val()
        ,Tipo_de_Identificacion: $('#Detalle_de_Datos_del_Imputado_CCTipo_de_Identificacion').val()
        ,Y_calle: $('#Detalle_de_Datos_del_Imputado_CCY_calle').val()

    }

    Detalle_de_Datos_del_Imputado_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Datos_del_Imputado_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Datos_del_Imputado_CC-form').modal({ show: false });
    $('#AddDetalle_de_Datos_del_Imputado_CC-form').modal('hide');
    Detalle_de_Datos_del_Imputado_CCEditRow(rowIndex);
    Detalle_de_Datos_del_Imputado_CCInsertRow(rowIndex);
    //}
}
function Detalle_de_Datos_del_Imputado_CCRemoveAddRow(rowIndex) {
    Detalle_de_Datos_del_Imputado_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Datos_del_Imputado_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Datos_del_Testigo_CC MultiRow
var Detalle_de_Datos_del_Testigo_CCcountRowsChecked = 0;






function GetDetalle_de_Datos_del_Testigo_CC_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_ColoniaDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_ColoniaDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_ColoniaItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_CC_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_ColoniaDropdown;
}


function GetDetalle_de_Datos_del_Testigo_CC_EscolaridadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_EscolaridadItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_EscolaridadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_EscolaridadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_EscolaridadDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_EscolaridadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_EscolaridadDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_EscolaridadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_EscolaridadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_EscolaridadItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_EscolaridadItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_CC_EscolaridadDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_EscolaridadDropdown;
}
function GetDetalle_de_Datos_del_Testigo_CC_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_EstadoItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_EstadoDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_EstadoDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_EstadoItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_CC_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_EstadoDropdown;
}
function GetDetalle_de_Datos_del_Testigo_CC_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_Estado_CivilItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_Estado_CivilItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_Estado_CivilDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_Estado_CivilDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_Estado_CivilItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_CC_Estado_CivilDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_Estado_CivilDropdown;
}



function GetDetalle_de_Datos_del_Testigo_CC_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_MunicipioDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_MunicipioDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_MunicipioItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_CC_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_MunicipioDropdown;
}
function GetDetalle_de_Datos_del_Testigo_CC_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_NacionalidadItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_NacionalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_NacionalidadDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_NacionalidadDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_NacionalidadItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_de_Datos_del_Testigo_CC_NacionalidadDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_NacionalidadDropdown;
}





function GetDetalle_de_Datos_del_Testigo_CC_OcupacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_OcupacionItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_OcupacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_OcupacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_OcupacionDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_OcupacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_OcupacionDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_OcupacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_OcupacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_OcupacionItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_OcupacionItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_CC_OcupacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_OcupacionDropdown;
}
function GetDetalle_de_Datos_del_Testigo_CC_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_PaisItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_PaisDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_PaisDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_PaisItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_CC_PaisDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_PaisDropdown;
}

function GetDetalle_de_Datos_del_Testigo_CC_GeneroName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_GeneroItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_GeneroItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_GeneroDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_GeneroDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_GeneroItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_GeneroItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_CC_GeneroDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_GeneroDropdown;
}

function GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteDropdown;
}
function GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionDropdown;
}
function GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadDropDown() {
    var Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadDropdown);
    if(Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadDropdown;
}







function GetInsertDetalle_de_Datos_del_Testigo_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Apellido_Materno Apellido_Materno').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Apellido_Materno_' + index).attr('data-field', 'Apellido_Materno');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Apellido_Paterno Apellido_Paterno').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Apellido_Paterno_' + index).attr('data-field', 'Apellido_Paterno');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Calle Calle').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Calle_' + index).attr('data-field', 'Calle');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Celular Celular').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Celular_' + index).attr('data-field', 'Celular');
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Testigo_CC_Codigo_Postal Codigo_Postal').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[5] = $(GetDetalle_de_Datos_del_Testigo_CC_ColoniaDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Colonia Colonia').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Colonia', 'Colonia', 265110)));
    columnData[6] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Correo_Electronico Correo_Electronico').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');
    columnData[7] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Testigo_CC_Edad Edad').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Edad_' + index).attr('data-field', 'Edad');
    columnData[8] = $(GetDetalle_de_Datos_del_Testigo_CC_EscolaridadDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Escolaridad Escolaridad').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Escolaridad_' + index).attr('data-field', 'Escolaridad').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Escolaridad', 'Escolaridad', 265113)));
    columnData[9] = $(GetDetalle_de_Datos_del_Testigo_CC_EstadoDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Estado Estado').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Estado', 'Estado', 265114)));
    columnData[10] = $(GetDetalle_de_Datos_del_Testigo_CC_Estado_CivilDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Estado_Civil Estado_Civil').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Estado_Civil_' + index).attr('data-field', 'Estado_Civil').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Estado_Civil', 'Estado_Civil', 265115)));
    columnData[11] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Testigo_CC_Extension Extension').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Extension_' + index).attr('data-field', 'Extension');
    columnData[12] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_del_Testigo_CC_Fecha_de_nacimiento Fecha_de_nacimiento').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Fecha_de_nacimiento_' + index).attr('data-field', 'Fecha_de_nacimiento');
    columnData[13] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Testigo_CC_Inimputable Inimputable').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Inimputable_' + index).attr('data-field', 'Inimputable');
    columnData[14] = $(GetDetalle_de_Datos_del_Testigo_CC_MunicipioDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Municipio Municipio').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Municipio', 'Municipio', 265119)));
    columnData[15] = $(GetDetalle_de_Datos_del_Testigo_CC_NacionalidadDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Nacionalidad Nacionalidad').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Nacionalidad_' + index).attr('data-field', 'Nacionalidad').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Nacionalidad', 'Nacionalidad', 265120)));
    columnData[16] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Nombre Nombre').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Nombre_' + index).attr('data-field', 'Nombre');
    columnData[17] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Nombre_Completo Nombre_Completo').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Nombre_Completo_' + index).attr('data-field', 'Nombre_Completo');
    columnData[18] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Numero_de_identificacion Numero_de_identificacion').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Numero_de_identificacion_' + index).attr('data-field', 'Numero_de_identificacion');
    columnData[19] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Numero_Exterior Numero_Exterior').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[20] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Numero_Interior Numero_Interior').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[21] = $(GetDetalle_de_Datos_del_Testigo_CC_OcupacionDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Ocupacion Ocupacion').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Ocupacion_' + index).attr('data-field', 'Ocupacion').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Ocupacion', 'Ocupacion', 265126)));
    columnData[22] = $(GetDetalle_de_Datos_del_Testigo_CC_PaisDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Pais Pais').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Pais_' + index).attr('data-field', 'Pais').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Pais', 'Pais', 265127)));
    columnData[23] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Testigo_CC_Proteccion_de_Datos Proteccion_de_Datos').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Proteccion_de_Datos_' + index).attr('data-field', 'Proteccion_de_Datos');
    columnData[24] = $(GetDetalle_de_Datos_del_Testigo_CC_GeneroDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Genero Genero').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Genero_' + index).attr('data-field', 'Genero').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Genero', 'Genero', 265129)));
    columnData[25] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Telefono Telefono').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Telefono_' + index).attr('data-field', 'Telefono');
    columnData[26] = $(GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Tipo_de_compareciente Tipo_de_compareciente').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Tipo_de_compareciente_' + index).attr('data-field', 'Tipo_de_compareciente').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Tipo_de_Compareciente', 'Tipo_de_compareciente', 265131)));
    columnData[27] = $(GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Tipo_de_identificacion Tipo_de_identificacion').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Tipo_de_identificacion_' + index).attr('data-field', 'Tipo_de_identificacion').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Tipo_de_Identificacion', 'Tipo_de_identificacion', 265132)));
    columnData[28] = $(GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadDropDown()).addClass('Detalle_de_Datos_del_Testigo_CC_Tipo_de_inimputabilidad Tipo_de_inimputabilidad').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Tipo_de_inimputabilidad_' + index).attr('data-field', 'Tipo_de_inimputabilidad').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_CC', 'Tipo_de_Inimputabilidad', 'Tipo_de_inimputabilidad', 265133)));
    columnData[29] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Entre_Calle Entre_Calle').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Entre_Calle_' + index).attr('data-field', 'Entre_Calle');
    columnData[30] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Y_Calle Y_Calle').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Y_Calle_' + index).attr('data-field', 'Y_Calle');
    columnData[31] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Referencia_del_Domicilio Referencia_del_Domicilio').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Referencia_del_Domicilio_' + index).attr('data-field', 'Referencia_del_Domicilio');
    columnData[32] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_CC_Especifique Especifique').attr('id', 'Detalle_de_Datos_del_Testigo_CC_Especifique_' + index).attr('data-field', 'Especifique');



    initiateUIControls();
    return columnData;
}

function Detalle_de_Datos_del_Testigo_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_del_Testigo_CC("Detalle_de_Datos_del_Testigo_CC_", "_" + rowIndex)) {
    var iPage = Detalle_de_Datos_del_Testigo_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Datos_del_Testigo_CC';
    var prevData = Detalle_de_Datos_del_Testigo_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Testigo_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Apellido_Materno:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno:  data.childNodes[counter++].childNodes[0].value
        ,Calle:  data.childNodes[counter++].childNodes[0].value
        ,Celular:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal: data.childNodes[counter++].childNodes[0].value
        ,Colonia:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value
        ,Edad: data.childNodes[counter++].childNodes[0].value
        ,Escolaridad:  data.childNodes[counter++].childNodes[0].value
        ,Estado:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil:  data.childNodes[counter++].childNodes[0].value
        ,Extension: data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_nacimiento:  data.childNodes[counter++].childNodes[0].value
        ,Inimputable: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Municipio:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad:  data.childNodes[counter++].childNodes[0].value
        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_Completo:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value
        ,Ocupacion:  data.childNodes[counter++].childNodes[0].value
        ,Pais:  data.childNodes[counter++].childNodes[0].value
        ,Proteccion_de_Datos: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Genero:  data.childNodes[counter++].childNodes[0].value
        ,Telefono:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_compareciente:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_inimputabilidad:  data.childNodes[counter++].childNodes[0].value
        ,Entre_Calle:  data.childNodes[counter++].childNodes[0].value
        ,Y_Calle:  data.childNodes[counter++].childNodes[0].value
        ,Referencia_del_Domicilio:  data.childNodes[counter++].childNodes[0].value
        ,Especifique:  data.childNodes[counter++].childNodes[0].value


    }
    Detalle_de_Datos_del_Testigo_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Datos_del_Testigo_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Datos_del_Testigo_CCTable.fnPageChange(iPage);
    Detalle_de_Datos_del_Testigo_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Datos_del_Testigo_CC("Detalle_de_Datos_del_Testigo_CC_", "_" + rowIndex);
  }
}

function Detalle_de_Datos_del_Testigo_CCCancelRow(rowIndex) {
    var prevData = Detalle_de_Datos_del_Testigo_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Testigo_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Datos_del_Testigo_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Datos_del_Testigo_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Datos_del_Testigo_CCGrid(Detalle_de_Datos_del_Testigo_CCTable.fnGetData());
    Detalle_de_Datos_del_Testigo_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Datos_del_Testigo_CCFromDataTable() {
    var Detalle_de_Datos_del_Testigo_CCData = [];
    var gridData = Detalle_de_Datos_del_Testigo_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Datos_del_Testigo_CCData.push({
                Clave: gridData[i].Clave

                ,Apellido_Materno: gridData[i].Apellido_Materno
                ,Apellido_Paterno: gridData[i].Apellido_Paterno
                ,Calle: gridData[i].Calle
                ,Celular: gridData[i].Celular
                ,Codigo_Postal: gridData[i].Codigo_Postal
                ,Colonia: gridData[i].Colonia
                ,Correo_Electronico: gridData[i].Correo_Electronico
                ,Edad: gridData[i].Edad
                ,Escolaridad: gridData[i].Escolaridad
                ,Estado: gridData[i].Estado
                ,Estado_Civil: gridData[i].Estado_Civil
                ,Extension: gridData[i].Extension
                ,Fecha_de_nacimiento: gridData[i].Fecha_de_nacimiento
                ,Inimputable: gridData[i].Inimputable
                ,Municipio: gridData[i].Municipio
                ,Nacionalidad: gridData[i].Nacionalidad
                ,Nombre: gridData[i].Nombre
                ,Nombre_Completo: gridData[i].Nombre_Completo
                ,Numero_de_identificacion: gridData[i].Numero_de_identificacion
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior
                ,Ocupacion: gridData[i].Ocupacion
                ,Pais: gridData[i].Pais
                ,Proteccion_de_Datos: gridData[i].Proteccion_de_Datos
                ,Genero: gridData[i].Genero
                ,Telefono: gridData[i].Telefono
                ,Tipo_de_compareciente: gridData[i].Tipo_de_compareciente
                ,Tipo_de_identificacion: gridData[i].Tipo_de_identificacion
                ,Tipo_de_inimputabilidad: gridData[i].Tipo_de_inimputabilidad
                ,Entre_Calle: gridData[i].Entre_Calle
                ,Y_Calle: gridData[i].Y_Calle
                ,Referencia_del_Domicilio: gridData[i].Referencia_del_Domicilio
                ,Especifique: gridData[i].Especifique


                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Datos_del_Testigo_CCData.length; i++) {
        if (removedDetalle_de_Datos_del_Testigo_CCData[i] != null && removedDetalle_de_Datos_del_Testigo_CCData[i].Clave > 0)
            Detalle_de_Datos_del_Testigo_CCData.push({
                Clave: removedDetalle_de_Datos_del_Testigo_CCData[i].Clave

                ,Apellido_Materno: removedDetalle_de_Datos_del_Testigo_CCData[i].Apellido_Materno
                ,Apellido_Paterno: removedDetalle_de_Datos_del_Testigo_CCData[i].Apellido_Paterno
                ,Calle: removedDetalle_de_Datos_del_Testigo_CCData[i].Calle
                ,Celular: removedDetalle_de_Datos_del_Testigo_CCData[i].Celular
                ,Codigo_Postal: removedDetalle_de_Datos_del_Testigo_CCData[i].Codigo_Postal
                ,Colonia: removedDetalle_de_Datos_del_Testigo_CCData[i].Colonia
                ,Correo_Electronico: removedDetalle_de_Datos_del_Testigo_CCData[i].Correo_Electronico
                ,Edad: removedDetalle_de_Datos_del_Testigo_CCData[i].Edad
                ,Escolaridad: removedDetalle_de_Datos_del_Testigo_CCData[i].Escolaridad
                ,Estado: removedDetalle_de_Datos_del_Testigo_CCData[i].Estado
                ,Estado_Civil: removedDetalle_de_Datos_del_Testigo_CCData[i].Estado_Civil
                ,Extension: removedDetalle_de_Datos_del_Testigo_CCData[i].Extension
                ,Fecha_de_nacimiento: removedDetalle_de_Datos_del_Testigo_CCData[i].Fecha_de_nacimiento
                ,Inimputable: removedDetalle_de_Datos_del_Testigo_CCData[i].Inimputable
                ,Municipio: removedDetalle_de_Datos_del_Testigo_CCData[i].Municipio
                ,Nacionalidad: removedDetalle_de_Datos_del_Testigo_CCData[i].Nacionalidad
                ,Nombre: removedDetalle_de_Datos_del_Testigo_CCData[i].Nombre
                ,Nombre_Completo: removedDetalle_de_Datos_del_Testigo_CCData[i].Nombre_Completo
                ,Numero_de_identificacion: removedDetalle_de_Datos_del_Testigo_CCData[i].Numero_de_identificacion
                ,Numero_Exterior: removedDetalle_de_Datos_del_Testigo_CCData[i].Numero_Exterior
                ,Numero_Interior: removedDetalle_de_Datos_del_Testigo_CCData[i].Numero_Interior
                ,Ocupacion: removedDetalle_de_Datos_del_Testigo_CCData[i].Ocupacion
                ,Pais: removedDetalle_de_Datos_del_Testigo_CCData[i].Pais
                ,Proteccion_de_Datos: removedDetalle_de_Datos_del_Testigo_CCData[i].Proteccion_de_Datos
                ,Genero: removedDetalle_de_Datos_del_Testigo_CCData[i].Genero
                ,Telefono: removedDetalle_de_Datos_del_Testigo_CCData[i].Telefono
                ,Tipo_de_compareciente: removedDetalle_de_Datos_del_Testigo_CCData[i].Tipo_de_compareciente
                ,Tipo_de_identificacion: removedDetalle_de_Datos_del_Testigo_CCData[i].Tipo_de_identificacion
                ,Tipo_de_inimputabilidad: removedDetalle_de_Datos_del_Testigo_CCData[i].Tipo_de_inimputabilidad
                ,Entre_Calle: removedDetalle_de_Datos_del_Testigo_CCData[i].Entre_Calle
                ,Y_Calle: removedDetalle_de_Datos_del_Testigo_CCData[i].Y_Calle
                ,Referencia_del_Domicilio: removedDetalle_de_Datos_del_Testigo_CCData[i].Referencia_del_Domicilio
                ,Especifique: removedDetalle_de_Datos_del_Testigo_CCData[i].Especifique


                , Removed: true
            });
    }	

    return Detalle_de_Datos_del_Testigo_CCData;
}

function Detalle_de_Datos_del_Testigo_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Datos_del_Testigo_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Datos_del_Testigo_CCcountRowsChecked++;
    var Detalle_de_Datos_del_Testigo_CCRowElement = "Detalle_de_Datos_del_Testigo_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Datos_del_Testigo_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Datos_del_Testigo_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Datos_del_Testigo_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Datos_del_Testigo_CCGetUpdateRowControls(prevData, "Detalle_de_Datos_del_Testigo_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Datos_del_Testigo_CCRowElement + "')){ Detalle_de_Datos_del_Testigo_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Datos_del_Testigo_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Datos_del_Testigo_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Datos_del_Testigo_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Datos_del_Testigo_CCValidation();
    initiateUIControls();
    $('.Detalle_de_Datos_del_Testigo_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Datos_del_Testigo_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Datos_del_Testigo_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Datos_del_Testigo_CCTable.fnGetData().length;
    Detalle_de_Datos_del_Testigo_CCfnClickAddRow();
    GetAddDetalle_de_Datos_del_Testigo_CCPopup(currentRowIndex, 0);
}

function Detalle_de_Datos_del_Testigo_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Datos_del_Testigo_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Datos_del_Testigo_CCRowElement = "Detalle_de_Datos_del_Testigo_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Datos_del_Testigo_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Datos_del_Testigo_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Datos_del_Testigo_CCApellido_Materno').val(prevData.Apellido_Materno);
    $('#Detalle_de_Datos_del_Testigo_CCApellido_Paterno').val(prevData.Apellido_Paterno);
    $('#Detalle_de_Datos_del_Testigo_CCCalle').val(prevData.Calle);
    $('#Detalle_de_Datos_del_Testigo_CCCelular').val(prevData.Celular);
    $('#Detalle_de_Datos_del_Testigo_CCCodigo_Postal').val(prevData.Codigo_Postal);
    $('#Detalle_de_Datos_del_Testigo_CCColonia').val(prevData.Colonia);
    $('#Detalle_de_Datos_del_Testigo_CCCorreo_Electronico').val(prevData.Correo_Electronico);
    $('#Detalle_de_Datos_del_Testigo_CCEdad').val(prevData.Edad);
    $('#Detalle_de_Datos_del_Testigo_CCEscolaridad').val(prevData.Escolaridad);
    $('#Detalle_de_Datos_del_Testigo_CCEstado').val(prevData.Estado);
    $('#Detalle_de_Datos_del_Testigo_CCEstado_Civil').val(prevData.Estado_Civil);
    $('#Detalle_de_Datos_del_Testigo_CCExtension').val(prevData.Extension);
    $('#Detalle_de_Datos_del_Testigo_CCFecha_de_nacimiento').val(prevData.Fecha_de_nacimiento);
    $('#Detalle_de_Datos_del_Testigo_CCInimputable').prop('checked', prevData.Inimputable);
    $('#Detalle_de_Datos_del_Testigo_CCMunicipio').val(prevData.Municipio);
    $('#Detalle_de_Datos_del_Testigo_CCNacionalidad').val(prevData.Nacionalidad);
    $('#Detalle_de_Datos_del_Testigo_CCNombre').val(prevData.Nombre);
    $('#Detalle_de_Datos_del_Testigo_CCNombre_Completo').val(prevData.Nombre_Completo);
    $('#Detalle_de_Datos_del_Testigo_CCNumero_de_identificacion').val(prevData.Numero_de_identificacion);
    $('#Detalle_de_Datos_del_Testigo_CCNumero_Exterior').val(prevData.Numero_Exterior);
    $('#Detalle_de_Datos_del_Testigo_CCNumero_Interior').val(prevData.Numero_Interior);
    $('#Detalle_de_Datos_del_Testigo_CCOcupacion').val(prevData.Ocupacion);
    $('#Detalle_de_Datos_del_Testigo_CCPais').val(prevData.Pais);
    $('#Detalle_de_Datos_del_Testigo_CCProteccion_de_Datos').prop('checked', prevData.Proteccion_de_Datos);
    $('#Detalle_de_Datos_del_Testigo_CCGenero').val(prevData.Genero);
    $('#Detalle_de_Datos_del_Testigo_CCTelefono').val(prevData.Telefono);
    $('#Detalle_de_Datos_del_Testigo_CCTipo_de_compareciente').val(prevData.Tipo_de_compareciente);
    $('#Detalle_de_Datos_del_Testigo_CCTipo_de_identificacion').val(prevData.Tipo_de_identificacion);
    $('#Detalle_de_Datos_del_Testigo_CCTipo_de_inimputabilidad').val(prevData.Tipo_de_inimputabilidad);
    $('#Detalle_de_Datos_del_Testigo_CCEntre_Calle').val(prevData.Entre_Calle);
    $('#Detalle_de_Datos_del_Testigo_CCY_Calle').val(prevData.Y_Calle);
    $('#Detalle_de_Datos_del_Testigo_CCReferencia_del_Domicilio').val(prevData.Referencia_del_Domicilio);
    $('#Detalle_de_Datos_del_Testigo_CCEspecifique').val(prevData.Especifique);


    initiateUIControls();




































}

function Detalle_de_Datos_del_Testigo_CCAddInsertRow() {
    if (Detalle_de_Datos_del_Testigo_CCinsertRowCurrentIndex < 1)
    {
        Detalle_de_Datos_del_Testigo_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Apellido_Materno: ""
        ,Apellido_Paterno: ""
        ,Calle: ""
        ,Celular: ""
        ,Codigo_Postal: ""
        ,Colonia: ""
        ,Correo_Electronico: ""
        ,Edad: ""
        ,Escolaridad: ""
        ,Estado: ""
        ,Estado_Civil: ""
        ,Extension: ""
        ,Fecha_de_nacimiento: ""
        ,Inimputable: ""
        ,Municipio: ""
        ,Nacionalidad: ""
        ,Nombre: ""
        ,Nombre_Completo: ""
        ,Numero_de_identificacion: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""
        ,Ocupacion: ""
        ,Pais: ""
        ,Proteccion_de_Datos: ""
        ,Genero: ""
        ,Telefono: ""
        ,Tipo_de_compareciente: ""
        ,Tipo_de_identificacion: ""
        ,Tipo_de_inimputabilidad: ""
        ,Entre_Calle: ""
        ,Y_Calle: ""
        ,Referencia_del_Domicilio: ""
        ,Especifique: ""


    }
}

function Detalle_de_Datos_del_Testigo_CCfnClickAddRow() {
    Detalle_de_Datos_del_Testigo_CCcountRowsChecked++;
    Detalle_de_Datos_del_Testigo_CCTable.fnAddData(Detalle_de_Datos_del_Testigo_CCAddInsertRow(), true);
    Detalle_de_Datos_del_Testigo_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Datos_del_Testigo_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Datos_del_Testigo_CCGrid tbody tr:nth-of-type(' + (Detalle_de_Datos_del_Testigo_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Datos_del_Testigo_CC("Detalle_de_Datos_del_Testigo_CC_", "_" + Detalle_de_Datos_del_Testigo_CCinsertRowCurrentIndex);
}

function Detalle_de_Datos_del_Testigo_CCClearGridData() {
    Detalle_de_Datos_del_Testigo_CCData = [];
    Detalle_de_Datos_del_Testigo_CCdeletedItem = [];
    Detalle_de_Datos_del_Testigo_CCDataMain = [];
    Detalle_de_Datos_del_Testigo_CCDataMainPages = [];
    Detalle_de_Datos_del_Testigo_CCnewItemCount = 0;
    Detalle_de_Datos_del_Testigo_CCmaxItemIndex = 0;
    $("#Detalle_de_Datos_del_Testigo_CCGrid").DataTable().clear();
    $("#Detalle_de_Datos_del_Testigo_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Datos_del_Testigo_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Datos_del_Testigo_CCData[i].Clave);

        form_data.append('[' + i + '].Apellido_Materno', Detalle_de_Datos_del_Testigo_CCData[i].Apellido_Materno);
        form_data.append('[' + i + '].Apellido_Paterno', Detalle_de_Datos_del_Testigo_CCData[i].Apellido_Paterno);
        form_data.append('[' + i + '].Calle', Detalle_de_Datos_del_Testigo_CCData[i].Calle);
        form_data.append('[' + i + '].Celular', Detalle_de_Datos_del_Testigo_CCData[i].Celular);
        form_data.append('[' + i + '].Codigo_Postal', Detalle_de_Datos_del_Testigo_CCData[i].Codigo_Postal);
        form_data.append('[' + i + '].Colonia', Detalle_de_Datos_del_Testigo_CCData[i].Colonia);
        form_data.append('[' + i + '].Correo_Electronico', Detalle_de_Datos_del_Testigo_CCData[i].Correo_Electronico);
        form_data.append('[' + i + '].Edad', Detalle_de_Datos_del_Testigo_CCData[i].Edad);
        form_data.append('[' + i + '].Escolaridad', Detalle_de_Datos_del_Testigo_CCData[i].Escolaridad);
        form_data.append('[' + i + '].Estado', Detalle_de_Datos_del_Testigo_CCData[i].Estado);
        form_data.append('[' + i + '].Estado_Civil', Detalle_de_Datos_del_Testigo_CCData[i].Estado_Civil);
        form_data.append('[' + i + '].Extension', Detalle_de_Datos_del_Testigo_CCData[i].Extension);
        form_data.append('[' + i + '].Fecha_de_nacimiento', Detalle_de_Datos_del_Testigo_CCData[i].Fecha_de_nacimiento);
        form_data.append('[' + i + '].Inimputable', Detalle_de_Datos_del_Testigo_CCData[i].Inimputable);
        form_data.append('[' + i + '].Municipio', Detalle_de_Datos_del_Testigo_CCData[i].Municipio);
        form_data.append('[' + i + '].Nacionalidad', Detalle_de_Datos_del_Testigo_CCData[i].Nacionalidad);
        form_data.append('[' + i + '].Nombre', Detalle_de_Datos_del_Testigo_CCData[i].Nombre);
        form_data.append('[' + i + '].Nombre_Completo', Detalle_de_Datos_del_Testigo_CCData[i].Nombre_Completo);
        form_data.append('[' + i + '].Numero_de_identificacion', Detalle_de_Datos_del_Testigo_CCData[i].Numero_de_identificacion);
        form_data.append('[' + i + '].Numero_Exterior', Detalle_de_Datos_del_Testigo_CCData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Detalle_de_Datos_del_Testigo_CCData[i].Numero_Interior);
        form_data.append('[' + i + '].Ocupacion', Detalle_de_Datos_del_Testigo_CCData[i].Ocupacion);
        form_data.append('[' + i + '].Pais', Detalle_de_Datos_del_Testigo_CCData[i].Pais);
        form_data.append('[' + i + '].Proteccion_de_Datos', Detalle_de_Datos_del_Testigo_CCData[i].Proteccion_de_Datos);
        form_data.append('[' + i + '].Genero', Detalle_de_Datos_del_Testigo_CCData[i].Genero);
        form_data.append('[' + i + '].Telefono', Detalle_de_Datos_del_Testigo_CCData[i].Telefono);
        form_data.append('[' + i + '].Tipo_de_compareciente', Detalle_de_Datos_del_Testigo_CCData[i].Tipo_de_compareciente);
        form_data.append('[' + i + '].Tipo_de_identificacion', Detalle_de_Datos_del_Testigo_CCData[i].Tipo_de_identificacion);
        form_data.append('[' + i + '].Tipo_de_inimputabilidad', Detalle_de_Datos_del_Testigo_CCData[i].Tipo_de_inimputabilidad);
        form_data.append('[' + i + '].Entre_Calle', Detalle_de_Datos_del_Testigo_CCData[i].Entre_Calle);
        form_data.append('[' + i + '].Y_Calle', Detalle_de_Datos_del_Testigo_CCData[i].Y_Calle);
        form_data.append('[' + i + '].Referencia_del_Domicilio', Detalle_de_Datos_del_Testigo_CCData[i].Referencia_del_Domicilio);
        form_data.append('[' + i + '].Especifique', Detalle_de_Datos_del_Testigo_CCData[i].Especifique);


        form_data.append('[' + i + '].Removed', Detalle_de_Datos_del_Testigo_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Datos_del_Testigo_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_del_Testigo_CC("Detalle_de_Datos_del_Testigo_CCTable", rowIndex)) {
    var prevData = Detalle_de_Datos_del_Testigo_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Testigo_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Apellido_Materno: $('#Detalle_de_Datos_del_Testigo_CCApellido_Materno').val()
        ,Apellido_Paterno: $('#Detalle_de_Datos_del_Testigo_CCApellido_Paterno').val()
        ,Calle: $('#Detalle_de_Datos_del_Testigo_CCCalle').val()
        ,Celular: $('#Detalle_de_Datos_del_Testigo_CCCelular').val()
        ,Codigo_Postal: $('#Detalle_de_Datos_del_Testigo_CCCodigo_Postal').val()

        ,Colonia: $('#Detalle_de_Datos_del_Testigo_CCColonia').val()
        ,Correo_Electronico: $('#Detalle_de_Datos_del_Testigo_CCCorreo_Electronico').val()
        ,Edad: $('#Detalle_de_Datos_del_Testigo_CCEdad').val()

        ,Escolaridad: $('#Detalle_de_Datos_del_Testigo_CCEscolaridad').val()
        ,Estado: $('#Detalle_de_Datos_del_Testigo_CCEstado').val()
        ,Estado_Civil: $('#Detalle_de_Datos_del_Testigo_CCEstado_Civil').val()
        ,Extension: $('#Detalle_de_Datos_del_Testigo_CCExtension').val()

        ,Fecha_de_nacimiento: $('#Detalle_de_Datos_del_Testigo_CCFecha_de_nacimiento').val()
        ,Inimputable: $('#Detalle_de_Datos_del_Testigo_CCInimputable').is(':checked')
        ,Municipio: $('#Detalle_de_Datos_del_Testigo_CCMunicipio').val()
        ,Nacionalidad: $('#Detalle_de_Datos_del_Testigo_CCNacionalidad').val()
        ,Nombre: $('#Detalle_de_Datos_del_Testigo_CCNombre').val()
        ,Nombre_Completo: $('#Detalle_de_Datos_del_Testigo_CCNombre_Completo').val()
        ,Numero_de_identificacion: $('#Detalle_de_Datos_del_Testigo_CCNumero_de_identificacion').val()
        ,Numero_Exterior: $('#Detalle_de_Datos_del_Testigo_CCNumero_Exterior').val()
        ,Numero_Interior: $('#Detalle_de_Datos_del_Testigo_CCNumero_Interior').val()
        ,Ocupacion: $('#Detalle_de_Datos_del_Testigo_CCOcupacion').val()
        ,Pais: $('#Detalle_de_Datos_del_Testigo_CCPais').val()
        ,Proteccion_de_Datos: $('#Detalle_de_Datos_del_Testigo_CCProteccion_de_Datos').is(':checked')
        ,Genero: $('#Detalle_de_Datos_del_Testigo_CCGenero').val()
        ,Telefono: $('#Detalle_de_Datos_del_Testigo_CCTelefono').val()
        ,Tipo_de_compareciente: $('#Detalle_de_Datos_del_Testigo_CCTipo_de_compareciente').val()
        ,Tipo_de_identificacion: $('#Detalle_de_Datos_del_Testigo_CCTipo_de_identificacion').val()
        ,Tipo_de_inimputabilidad: $('#Detalle_de_Datos_del_Testigo_CCTipo_de_inimputabilidad').val()
        ,Entre_Calle: $('#Detalle_de_Datos_del_Testigo_CCEntre_Calle').val()
        ,Y_Calle: $('#Detalle_de_Datos_del_Testigo_CCY_Calle').val()
        ,Referencia_del_Domicilio: $('#Detalle_de_Datos_del_Testigo_CCReferencia_del_Domicilio').val()
        ,Especifique: $('#Detalle_de_Datos_del_Testigo_CCEspecifique').val()


    }

    Detalle_de_Datos_del_Testigo_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Datos_del_Testigo_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Datos_del_Testigo_CC-form').modal({ show: false });
    $('#AddDetalle_de_Datos_del_Testigo_CC-form').modal('hide');
    Detalle_de_Datos_del_Testigo_CCEditRow(rowIndex);
    Detalle_de_Datos_del_Testigo_CCInsertRow(rowIndex);
    //}
}
function Detalle_de_Datos_del_Testigo_CCRemoveAddRow(rowIndex) {
    Detalle_de_Datos_del_Testigo_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Datos_del_Testigo_CC MultiRow
//Begin Declarations for Foreigns fields for Catalogo_Tipo_de_Embalaje_CC MultiRow
var Catalogo_Tipo_de_Embalaje_CCcountRowsChecked = 0;




function GetInsertCatalogo_Tipo_de_Embalaje_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Catalogo_Tipo_de_Embalaje_CC_Descripcion Descripcion').attr('id', 'Catalogo_Tipo_de_Embalaje_CC_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Catalogo_Tipo_de_Embalaje_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRCatalogo_Tipo_de_Embalaje_CC("Catalogo_Tipo_de_Embalaje_CC_", "_" + rowIndex)) {
    var iPage = Catalogo_Tipo_de_Embalaje_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Catalogo_Tipo_de_Embalaje_CC';
    var prevData = Catalogo_Tipo_de_Embalaje_CCTable.fnGetData(rowIndex);
    var data = Catalogo_Tipo_de_Embalaje_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Catalogo_Tipo_de_Embalaje_CCTable.fnUpdate(newData, rowIndex, null, true);
    Catalogo_Tipo_de_Embalaje_CCrowCreationGrid(data, newData, rowIndex);
    Catalogo_Tipo_de_Embalaje_CCTable.fnPageChange(iPage);
    Catalogo_Tipo_de_Embalaje_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRCatalogo_Tipo_de_Embalaje_CC("Catalogo_Tipo_de_Embalaje_CC_", "_" + rowIndex);
  }
}

function Catalogo_Tipo_de_Embalaje_CCCancelRow(rowIndex) {
    var prevData = Catalogo_Tipo_de_Embalaje_CCTable.fnGetData(rowIndex);
    var data = Catalogo_Tipo_de_Embalaje_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Catalogo_Tipo_de_Embalaje_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Catalogo_Tipo_de_Embalaje_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showCatalogo_Tipo_de_Embalaje_CCGrid(Catalogo_Tipo_de_Embalaje_CCTable.fnGetData());
    Catalogo_Tipo_de_Embalaje_CCcountRowsChecked--;
	initiateUIControls();
}

function GetCatalogo_Tipo_de_Embalaje_CCFromDataTable() {
    var Catalogo_Tipo_de_Embalaje_CCData = [];
    var gridData = Catalogo_Tipo_de_Embalaje_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Catalogo_Tipo_de_Embalaje_CCData.push({
                Clave: gridData[i].Clave

                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedCatalogo_Tipo_de_Embalaje_CCData.length; i++) {
        if (removedCatalogo_Tipo_de_Embalaje_CCData[i] != null && removedCatalogo_Tipo_de_Embalaje_CCData[i].Clave > 0)
            Catalogo_Tipo_de_Embalaje_CCData.push({
                Clave: removedCatalogo_Tipo_de_Embalaje_CCData[i].Clave

                ,Descripcion: removedCatalogo_Tipo_de_Embalaje_CCData[i].Descripcion

                , Removed: true
            });
    }	

    return Catalogo_Tipo_de_Embalaje_CCData;
}

function Catalogo_Tipo_de_Embalaje_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Catalogo_Tipo_de_Embalaje_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Catalogo_Tipo_de_Embalaje_CCcountRowsChecked++;
    var Catalogo_Tipo_de_Embalaje_CCRowElement = "Catalogo_Tipo_de_Embalaje_CC_" + rowIndex.toString();
    var prevData = Catalogo_Tipo_de_Embalaje_CCTable.fnGetData(rowIndexTable );
    var row = Catalogo_Tipo_de_Embalaje_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Catalogo_Tipo_de_Embalaje_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Catalogo_Tipo_de_Embalaje_CCGetUpdateRowControls(prevData, "Catalogo_Tipo_de_Embalaje_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Catalogo_Tipo_de_Embalaje_CCRowElement + "')){ Catalogo_Tipo_de_Embalaje_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Catalogo_Tipo_de_Embalaje_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Catalogo_Tipo_de_Embalaje_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Catalogo_Tipo_de_Embalaje_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setCatalogo_Tipo_de_Embalaje_CCValidation();
    initiateUIControls();
    $('.Catalogo_Tipo_de_Embalaje_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRCatalogo_Tipo_de_Embalaje_CC(nameOfTable, rowIndexFormed);
    }
}

function Catalogo_Tipo_de_Embalaje_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Catalogo_Tipo_de_Embalaje_CCTable.fnGetData().length;
    Catalogo_Tipo_de_Embalaje_CCfnClickAddRow();
    GetAddCatalogo_Tipo_de_Embalaje_CCPopup(currentRowIndex, 0);
}

function Catalogo_Tipo_de_Embalaje_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Catalogo_Tipo_de_Embalaje_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Catalogo_Tipo_de_Embalaje_CCRowElement = "Catalogo_Tipo_de_Embalaje_CC_" + rowIndex.toString();
    var prevData = Catalogo_Tipo_de_Embalaje_CCTable.fnGetData(rowIndexTable);
    GetAddCatalogo_Tipo_de_Embalaje_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Catalogo_Tipo_de_Embalaje_CCDescripcion').val(prevData.Descripcion);

    initiateUIControls();



}

function Catalogo_Tipo_de_Embalaje_CCAddInsertRow() {
    if (Catalogo_Tipo_de_Embalaje_CCinsertRowCurrentIndex < 1)
    {
        Catalogo_Tipo_de_Embalaje_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Descripcion: ""

    }
}

function Catalogo_Tipo_de_Embalaje_CCfnClickAddRow() {
    Catalogo_Tipo_de_Embalaje_CCcountRowsChecked++;
    Catalogo_Tipo_de_Embalaje_CCTable.fnAddData(Catalogo_Tipo_de_Embalaje_CCAddInsertRow(), true);
    Catalogo_Tipo_de_Embalaje_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Catalogo_Tipo_de_Embalaje_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Catalogo_Tipo_de_Embalaje_CCGrid tbody tr:nth-of-type(' + (Catalogo_Tipo_de_Embalaje_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRCatalogo_Tipo_de_Embalaje_CC("Catalogo_Tipo_de_Embalaje_CC_", "_" + Catalogo_Tipo_de_Embalaje_CCinsertRowCurrentIndex);
}

function Catalogo_Tipo_de_Embalaje_CCClearGridData() {
    Catalogo_Tipo_de_Embalaje_CCData = [];
    Catalogo_Tipo_de_Embalaje_CCdeletedItem = [];
    Catalogo_Tipo_de_Embalaje_CCDataMain = [];
    Catalogo_Tipo_de_Embalaje_CCDataMainPages = [];
    Catalogo_Tipo_de_Embalaje_CCnewItemCount = 0;
    Catalogo_Tipo_de_Embalaje_CCmaxItemIndex = 0;
    $("#Catalogo_Tipo_de_Embalaje_CCGrid").DataTable().clear();
    $("#Catalogo_Tipo_de_Embalaje_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetCatalogo_Tipo_de_Embalaje_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Catalogo_Tipo_de_Embalaje_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Catalogo_Tipo_de_Embalaje_CCData[i].Clave);

        form_data.append('[' + i + '].Descripcion', Catalogo_Tipo_de_Embalaje_CCData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Catalogo_Tipo_de_Embalaje_CCData[i].Removed);
    }
    return form_data;
}
function Catalogo_Tipo_de_Embalaje_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRCatalogo_Tipo_de_Embalaje_CC("Catalogo_Tipo_de_Embalaje_CCTable", rowIndex)) {
    var prevData = Catalogo_Tipo_de_Embalaje_CCTable.fnGetData(rowIndex);
    var data = Catalogo_Tipo_de_Embalaje_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion: $('#Catalogo_Tipo_de_Embalaje_CCDescripcion').val()

    }

    Catalogo_Tipo_de_Embalaje_CCTable.fnUpdate(newData, rowIndex, null, true);
    Catalogo_Tipo_de_Embalaje_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddCatalogo_Tipo_de_Embalaje_CC-form').modal({ show: false });
    $('#AddCatalogo_Tipo_de_Embalaje_CC-form').modal('hide');
    Catalogo_Tipo_de_Embalaje_CCEditRow(rowIndex);
    Catalogo_Tipo_de_Embalaje_CCInsertRow(rowIndex);
    //}
}
function Catalogo_Tipo_de_Embalaje_CCRemoveAddRow(rowIndex) {
    Catalogo_Tipo_de_Embalaje_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Catalogo_Tipo_de_Embalaje_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Lista_de_Asignaciones MultiRow
var Detalle_de_Lista_de_AsignacionescountRowsChecked = 0;







function GetInsertDetalle_de_Lista_de_AsignacionesRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Lista_de_Asignaciones_Numero_de_Asignacion Numero_de_Asignacion').attr('id', 'Detalle_de_Lista_de_Asignaciones_Numero_de_Asignacion_' + index).attr('data-field', 'Numero_de_Asignacion');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Lista_de_Asignaciones_Nombre Nombre').attr('id', 'Detalle_de_Lista_de_Asignaciones_Nombre_' + index).attr('data-field', 'Nombre');
    columnData[2] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Lista_de_Asignaciones_Realizado Realizado').attr('id', 'Detalle_de_Lista_de_Asignaciones_Realizado_' + index).attr('data-field', 'Realizado');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Lista_de_Asignaciones_Especifique Especifique').attr('id', 'Detalle_de_Lista_de_Asignaciones_Especifique_' + index).attr('data-field', 'Especifique');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Lista_de_AsignacionesInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Lista_de_Asignaciones("Detalle_de_Lista_de_Asignaciones_", "_" + rowIndex)) {
    var iPage = Detalle_de_Lista_de_AsignacionesTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Lista_de_Asignaciones';
    var prevData = Detalle_de_Lista_de_AsignacionesTable.fnGetData(rowIndex);
    var data = Detalle_de_Lista_de_AsignacionesTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_Asignacion: data.childNodes[counter++].childNodes[0].value
        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Realizado: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Especifique:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Lista_de_AsignacionesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Lista_de_AsignacionesrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Lista_de_AsignacionesTable.fnPageChange(iPage);
    Detalle_de_Lista_de_AsignacionescountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Lista_de_Asignaciones("Detalle_de_Lista_de_Asignaciones_", "_" + rowIndex);
  }
}

function Detalle_de_Lista_de_AsignacionesCancelRow(rowIndex) {
    var prevData = Detalle_de_Lista_de_AsignacionesTable.fnGetData(rowIndex);
    var data = Detalle_de_Lista_de_AsignacionesTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Lista_de_AsignacionesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Lista_de_AsignacionesrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Lista_de_AsignacionesGrid(Detalle_de_Lista_de_AsignacionesTable.fnGetData());
    Detalle_de_Lista_de_AsignacionescountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Lista_de_AsignacionesFromDataTable() {
    var Detalle_de_Lista_de_AsignacionesData = [];
    var gridData = Detalle_de_Lista_de_AsignacionesTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Lista_de_AsignacionesData.push({
                Clave: gridData[i].Clave

                ,Numero_de_Asignacion: gridData[i].Numero_de_Asignacion
                ,Nombre: gridData[i].Nombre
                ,Realizado: gridData[i].Realizado
                ,Especifique: gridData[i].Especifique

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Lista_de_AsignacionesData.length; i++) {
        if (removedDetalle_de_Lista_de_AsignacionesData[i] != null && removedDetalle_de_Lista_de_AsignacionesData[i].Clave > 0)
            Detalle_de_Lista_de_AsignacionesData.push({
                Clave: removedDetalle_de_Lista_de_AsignacionesData[i].Clave

                ,Numero_de_Asignacion: removedDetalle_de_Lista_de_AsignacionesData[i].Numero_de_Asignacion
                ,Nombre: removedDetalle_de_Lista_de_AsignacionesData[i].Nombre
                ,Realizado: removedDetalle_de_Lista_de_AsignacionesData[i].Realizado
                ,Especifique: removedDetalle_de_Lista_de_AsignacionesData[i].Especifique

                , Removed: true
            });
    }	

    return Detalle_de_Lista_de_AsignacionesData;
}

function Detalle_de_Lista_de_AsignacionesEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Lista_de_AsignacionesTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Lista_de_AsignacionescountRowsChecked++;
    var Detalle_de_Lista_de_AsignacionesRowElement = "Detalle_de_Lista_de_Asignaciones_" + rowIndex.toString();
    var prevData = Detalle_de_Lista_de_AsignacionesTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Lista_de_AsignacionesTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Lista_de_Asignaciones_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Lista_de_AsignacionesGetUpdateRowControls(prevData, "Detalle_de_Lista_de_Asignaciones_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Lista_de_AsignacionesRowElement + "')){ Detalle_de_Lista_de_AsignacionesInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Lista_de_AsignacionesCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Lista_de_AsignacionesGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Lista_de_AsignacionesGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Lista_de_AsignacionesValidation();
    initiateUIControls();
    $('.Detalle_de_Lista_de_Asignaciones' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Lista_de_Asignaciones(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Lista_de_AsignacionesfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Lista_de_AsignacionesTable.fnGetData().length;
    Detalle_de_Lista_de_AsignacionesfnClickAddRow();
    GetAddDetalle_de_Lista_de_AsignacionesPopup(currentRowIndex, 0);
}

function Detalle_de_Lista_de_AsignacionesEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Lista_de_AsignacionesTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Lista_de_AsignacionesRowElement = "Detalle_de_Lista_de_Asignaciones_" + rowIndex.toString();
    var prevData = Detalle_de_Lista_de_AsignacionesTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Lista_de_AsignacionesPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Lista_de_AsignacionesNumero_de_Asignacion').val(prevData.Numero_de_Asignacion);
    $('#Detalle_de_Lista_de_AsignacionesNombre').val(prevData.Nombre);
    $('#Detalle_de_Lista_de_AsignacionesRealizado').prop('checked', prevData.Realizado);
    $('#Detalle_de_Lista_de_AsignacionesEspecifique').val(prevData.Especifique);

    initiateUIControls();






}

function Detalle_de_Lista_de_AsignacionesAddInsertRow() {
    if (Detalle_de_Lista_de_AsignacionesinsertRowCurrentIndex < 1)
    {
        Detalle_de_Lista_de_AsignacionesinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Numero_de_Asignacion: ""
        ,Nombre: ""
        ,Realizado: ""
        ,Especifique: ""

    }
}

function Detalle_de_Lista_de_AsignacionesfnClickAddRow() {
    Detalle_de_Lista_de_AsignacionescountRowsChecked++;
    Detalle_de_Lista_de_AsignacionesTable.fnAddData(Detalle_de_Lista_de_AsignacionesAddInsertRow(), true);
    Detalle_de_Lista_de_AsignacionesTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Lista_de_AsignacionesGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Lista_de_AsignacionesGrid tbody tr:nth-of-type(' + (Detalle_de_Lista_de_AsignacionesinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Lista_de_Asignaciones("Detalle_de_Lista_de_Asignaciones_", "_" + Detalle_de_Lista_de_AsignacionesinsertRowCurrentIndex);
}

function Detalle_de_Lista_de_AsignacionesClearGridData() {
    Detalle_de_Lista_de_AsignacionesData = [];
    Detalle_de_Lista_de_AsignacionesdeletedItem = [];
    Detalle_de_Lista_de_AsignacionesDataMain = [];
    Detalle_de_Lista_de_AsignacionesDataMainPages = [];
    Detalle_de_Lista_de_AsignacionesnewItemCount = 0;
    Detalle_de_Lista_de_AsignacionesmaxItemIndex = 0;
    $("#Detalle_de_Lista_de_AsignacionesGrid").DataTable().clear();
    $("#Detalle_de_Lista_de_AsignacionesGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Lista_de_Asignaciones() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Lista_de_AsignacionesData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Lista_de_AsignacionesData[i].Clave);

        form_data.append('[' + i + '].Numero_de_Asignacion', Detalle_de_Lista_de_AsignacionesData[i].Numero_de_Asignacion);
        form_data.append('[' + i + '].Nombre', Detalle_de_Lista_de_AsignacionesData[i].Nombre);
        form_data.append('[' + i + '].Realizado', Detalle_de_Lista_de_AsignacionesData[i].Realizado);
        form_data.append('[' + i + '].Especifique', Detalle_de_Lista_de_AsignacionesData[i].Especifique);

        form_data.append('[' + i + '].Removed', Detalle_de_Lista_de_AsignacionesData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Lista_de_AsignacionesInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Lista_de_Asignaciones("Detalle_de_Lista_de_AsignacionesTable", rowIndex)) {
    var prevData = Detalle_de_Lista_de_AsignacionesTable.fnGetData(rowIndex);
    var data = Detalle_de_Lista_de_AsignacionesTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_Asignacion: $('#Detalle_de_Lista_de_AsignacionesNumero_de_Asignacion').val()

        ,Nombre: $('#Detalle_de_Lista_de_AsignacionesNombre').val()
        ,Realizado: $('#Detalle_de_Lista_de_AsignacionesRealizado').is(':checked')
        ,Especifique: $('#Detalle_de_Lista_de_AsignacionesEspecifique').val()

    }

    Detalle_de_Lista_de_AsignacionesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Lista_de_AsignacionesrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Lista_de_Asignaciones-form').modal({ show: false });
    $('#AddDetalle_de_Lista_de_Asignaciones-form').modal('hide');
    Detalle_de_Lista_de_AsignacionesEditRow(rowIndex);
    Detalle_de_Lista_de_AsignacionesInsertRow(rowIndex);
    //}
}
function Detalle_de_Lista_de_AsignacionesRemoveAddRow(rowIndex) {
    Detalle_de_Lista_de_AsignacionesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Lista_de_Asignaciones MultiRow
//Begin Declarations for Foreigns fields for Catalogo_Tipo_de_Fijacion_CC MultiRow
var Catalogo_Tipo_de_Fijacion_CCcountRowsChecked = 0;




function GetInsertCatalogo_Tipo_de_Fijacion_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Catalogo_Tipo_de_Fijacion_CC_Descripcion Descripcion').attr('id', 'Catalogo_Tipo_de_Fijacion_CC_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Catalogo_Tipo_de_Fijacion_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRCatalogo_Tipo_de_Fijacion_CC("Catalogo_Tipo_de_Fijacion_CC_", "_" + rowIndex)) {
    var iPage = Catalogo_Tipo_de_Fijacion_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Catalogo_Tipo_de_Fijacion_CC';
    var prevData = Catalogo_Tipo_de_Fijacion_CCTable.fnGetData(rowIndex);
    var data = Catalogo_Tipo_de_Fijacion_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Catalogo_Tipo_de_Fijacion_CCTable.fnUpdate(newData, rowIndex, null, true);
    Catalogo_Tipo_de_Fijacion_CCrowCreationGrid(data, newData, rowIndex);
    Catalogo_Tipo_de_Fijacion_CCTable.fnPageChange(iPage);
    Catalogo_Tipo_de_Fijacion_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRCatalogo_Tipo_de_Fijacion_CC("Catalogo_Tipo_de_Fijacion_CC_", "_" + rowIndex);
  }
}

function Catalogo_Tipo_de_Fijacion_CCCancelRow(rowIndex) {
    var prevData = Catalogo_Tipo_de_Fijacion_CCTable.fnGetData(rowIndex);
    var data = Catalogo_Tipo_de_Fijacion_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Catalogo_Tipo_de_Fijacion_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Catalogo_Tipo_de_Fijacion_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showCatalogo_Tipo_de_Fijacion_CCGrid(Catalogo_Tipo_de_Fijacion_CCTable.fnGetData());
    Catalogo_Tipo_de_Fijacion_CCcountRowsChecked--;
	initiateUIControls();
}

function GetCatalogo_Tipo_de_Fijacion_CCFromDataTable() {
    var Catalogo_Tipo_de_Fijacion_CCData = [];
    var gridData = Catalogo_Tipo_de_Fijacion_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Catalogo_Tipo_de_Fijacion_CCData.push({
                Clave: gridData[i].Clave

                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedCatalogo_Tipo_de_Fijacion_CCData.length; i++) {
        if (removedCatalogo_Tipo_de_Fijacion_CCData[i] != null && removedCatalogo_Tipo_de_Fijacion_CCData[i].Clave > 0)
            Catalogo_Tipo_de_Fijacion_CCData.push({
                Clave: removedCatalogo_Tipo_de_Fijacion_CCData[i].Clave

                ,Descripcion: removedCatalogo_Tipo_de_Fijacion_CCData[i].Descripcion

                , Removed: true
            });
    }	

    return Catalogo_Tipo_de_Fijacion_CCData;
}

function Catalogo_Tipo_de_Fijacion_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Catalogo_Tipo_de_Fijacion_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Catalogo_Tipo_de_Fijacion_CCcountRowsChecked++;
    var Catalogo_Tipo_de_Fijacion_CCRowElement = "Catalogo_Tipo_de_Fijacion_CC_" + rowIndex.toString();
    var prevData = Catalogo_Tipo_de_Fijacion_CCTable.fnGetData(rowIndexTable );
    var row = Catalogo_Tipo_de_Fijacion_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Catalogo_Tipo_de_Fijacion_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Catalogo_Tipo_de_Fijacion_CCGetUpdateRowControls(prevData, "Catalogo_Tipo_de_Fijacion_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Catalogo_Tipo_de_Fijacion_CCRowElement + "')){ Catalogo_Tipo_de_Fijacion_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Catalogo_Tipo_de_Fijacion_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Catalogo_Tipo_de_Fijacion_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Catalogo_Tipo_de_Fijacion_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setCatalogo_Tipo_de_Fijacion_CCValidation();
    initiateUIControls();
    $('.Catalogo_Tipo_de_Fijacion_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRCatalogo_Tipo_de_Fijacion_CC(nameOfTable, rowIndexFormed);
    }
}

function Catalogo_Tipo_de_Fijacion_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Catalogo_Tipo_de_Fijacion_CCTable.fnGetData().length;
    Catalogo_Tipo_de_Fijacion_CCfnClickAddRow();
    GetAddCatalogo_Tipo_de_Fijacion_CCPopup(currentRowIndex, 0);
}

function Catalogo_Tipo_de_Fijacion_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Catalogo_Tipo_de_Fijacion_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Catalogo_Tipo_de_Fijacion_CCRowElement = "Catalogo_Tipo_de_Fijacion_CC_" + rowIndex.toString();
    var prevData = Catalogo_Tipo_de_Fijacion_CCTable.fnGetData(rowIndexTable);
    GetAddCatalogo_Tipo_de_Fijacion_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Catalogo_Tipo_de_Fijacion_CCDescripcion').val(prevData.Descripcion);

    initiateUIControls();



}

function Catalogo_Tipo_de_Fijacion_CCAddInsertRow() {
    if (Catalogo_Tipo_de_Fijacion_CCinsertRowCurrentIndex < 1)
    {
        Catalogo_Tipo_de_Fijacion_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Descripcion: ""

    }
}

function Catalogo_Tipo_de_Fijacion_CCfnClickAddRow() {
    Catalogo_Tipo_de_Fijacion_CCcountRowsChecked++;
    Catalogo_Tipo_de_Fijacion_CCTable.fnAddData(Catalogo_Tipo_de_Fijacion_CCAddInsertRow(), true);
    Catalogo_Tipo_de_Fijacion_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Catalogo_Tipo_de_Fijacion_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Catalogo_Tipo_de_Fijacion_CCGrid tbody tr:nth-of-type(' + (Catalogo_Tipo_de_Fijacion_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRCatalogo_Tipo_de_Fijacion_CC("Catalogo_Tipo_de_Fijacion_CC_", "_" + Catalogo_Tipo_de_Fijacion_CCinsertRowCurrentIndex);
}

function Catalogo_Tipo_de_Fijacion_CCClearGridData() {
    Catalogo_Tipo_de_Fijacion_CCData = [];
    Catalogo_Tipo_de_Fijacion_CCdeletedItem = [];
    Catalogo_Tipo_de_Fijacion_CCDataMain = [];
    Catalogo_Tipo_de_Fijacion_CCDataMainPages = [];
    Catalogo_Tipo_de_Fijacion_CCnewItemCount = 0;
    Catalogo_Tipo_de_Fijacion_CCmaxItemIndex = 0;
    $("#Catalogo_Tipo_de_Fijacion_CCGrid").DataTable().clear();
    $("#Catalogo_Tipo_de_Fijacion_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetCatalogo_Tipo_de_Fijacion_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Catalogo_Tipo_de_Fijacion_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Catalogo_Tipo_de_Fijacion_CCData[i].Clave);

        form_data.append('[' + i + '].Descripcion', Catalogo_Tipo_de_Fijacion_CCData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Catalogo_Tipo_de_Fijacion_CCData[i].Removed);
    }
    return form_data;
}
function Catalogo_Tipo_de_Fijacion_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRCatalogo_Tipo_de_Fijacion_CC("Catalogo_Tipo_de_Fijacion_CCTable", rowIndex)) {
    var prevData = Catalogo_Tipo_de_Fijacion_CCTable.fnGetData(rowIndex);
    var data = Catalogo_Tipo_de_Fijacion_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion: $('#Catalogo_Tipo_de_Fijacion_CCDescripcion').val()

    }

    Catalogo_Tipo_de_Fijacion_CCTable.fnUpdate(newData, rowIndex, null, true);
    Catalogo_Tipo_de_Fijacion_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddCatalogo_Tipo_de_Fijacion_CC-form').modal({ show: false });
    $('#AddCatalogo_Tipo_de_Fijacion_CC-form').modal('hide');
    Catalogo_Tipo_de_Fijacion_CCEditRow(rowIndex);
    Catalogo_Tipo_de_Fijacion_CCInsertRow(rowIndex);
    //}
}
function Catalogo_Tipo_de_Fijacion_CCRemoveAddRow(rowIndex) {
    Catalogo_Tipo_de_Fijacion_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Catalogo_Tipo_de_Fijacion_CC MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Traslado_de_CC MultiRow
var Detalle_de_Traslado_de_CCcountRowsChecked = 0;







function GetDetalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoName(Id) {
    for (var i = 0; i < Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoItems.length; i++) {
        if (Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoItems[i].Clave == Id) {
            return Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoDropDown() {
    var Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Traslado_de_CC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoDropdown);
    if(Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoItems != null)
    {
       for (var i = 0; i < Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoItems.length; i++) {
           $('<option />', { value: Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoItems[i].Clave, text:    Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoItems[i].Descripcion }).appendTo(Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoDropdown);
       }
    }
    return Detalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoDropdown;
}


function GetInsertDetalle_de_Traslado_de_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Traslado_de_CC_Fecha Fecha').attr('id', 'Detalle_de_Traslado_de_CC_Fecha_' + index).attr('data-field', 'Fecha');
    columnData[1] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Traslado_de_CC_Hora Hora').attr('id', 'Detalle_de_Traslado_de_CC_Hora_' + index).attr('data-field', 'Hora');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Traslado_de_CC_Temperatura Temperatura').attr('id', 'Detalle_de_Traslado_de_CC_Temperatura_' + index).attr('data-field', 'Temperatura');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Traslado_de_CC_Humedad Humedad').attr('id', 'Detalle_de_Traslado_de_CC_Humedad_' + index).attr('data-field', 'Humedad');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_de_Traslado_de_CC_Latitud Latitud').attr('id', 'Detalle_de_Traslado_de_CC_Latitud_' + index).attr('data-field', 'Latitud');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_de_Traslado_de_CC_Longitud Longitud').attr('id', 'Detalle_de_Traslado_de_CC_Longitud_' + index).attr('data-field', 'Longitud');
    columnData[6] = $(GetDetalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoDropDown()).addClass('Detalle_de_Traslado_de_CC_Estatus Estatus').attr('id', 'Detalle_de_Traslado_de_CC_Estatus_' + index).attr('data-field', 'Estatus').after($.parseHTML(addNew('Detalle_de_Traslado_de_CC', 'Catalogo_de_Estatus_de_Traslado', 'Estatus', 265163)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_Traslado_de_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Traslado_de_CC("Detalle_de_Traslado_de_CC_", "_" + rowIndex)) {
    var iPage = Detalle_de_Traslado_de_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Traslado_de_CC';
    var prevData = Detalle_de_Traslado_de_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Traslado_de_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha:  data.childNodes[counter++].childNodes[0].value
        ,Hora:  data.childNodes[counter++].childNodes[0].value
        ,Temperatura:  data.childNodes[counter++].childNodes[0].value
        ,Humedad:  data.childNodes[counter++].childNodes[0].value
        ,Latitud:  data.childNodes[counter++].childNodes[0].value
        ,Longitud:  data.childNodes[counter++].childNodes[0].value
        ,Estatus:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Traslado_de_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Traslado_de_CCrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Traslado_de_CCTable.fnPageChange(iPage);
    Detalle_de_Traslado_de_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Traslado_de_CC("Detalle_de_Traslado_de_CC_", "_" + rowIndex);
  }
}

function Detalle_de_Traslado_de_CCCancelRow(rowIndex) {
    var prevData = Detalle_de_Traslado_de_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Traslado_de_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Traslado_de_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Traslado_de_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Traslado_de_CCGrid(Detalle_de_Traslado_de_CCTable.fnGetData());
    Detalle_de_Traslado_de_CCcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Traslado_de_CCFromDataTable() {
    var Detalle_de_Traslado_de_CCData = [];
    var gridData = Detalle_de_Traslado_de_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Traslado_de_CCData.push({
                Clave: gridData[i].Clave

                ,Fecha: gridData[i].Fecha
                ,Hora: gridData[i].Hora
                ,Temperatura: gridData[i].Temperatura
                ,Humedad: gridData[i].Humedad
                ,Latitud: gridData[i].Latitud
                ,Longitud: gridData[i].Longitud
                ,Estatus: gridData[i].Estatus

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Traslado_de_CCData.length; i++) {
        if (removedDetalle_de_Traslado_de_CCData[i] != null && removedDetalle_de_Traslado_de_CCData[i].Clave > 0)
            Detalle_de_Traslado_de_CCData.push({
                Clave: removedDetalle_de_Traslado_de_CCData[i].Clave

                ,Fecha: removedDetalle_de_Traslado_de_CCData[i].Fecha
                ,Hora: removedDetalle_de_Traslado_de_CCData[i].Hora
                ,Temperatura: removedDetalle_de_Traslado_de_CCData[i].Temperatura
                ,Humedad: removedDetalle_de_Traslado_de_CCData[i].Humedad
                ,Latitud: removedDetalle_de_Traslado_de_CCData[i].Latitud
                ,Longitud: removedDetalle_de_Traslado_de_CCData[i].Longitud
                ,Estatus: removedDetalle_de_Traslado_de_CCData[i].Estatus

                , Removed: true
            });
    }	

    return Detalle_de_Traslado_de_CCData;
}

function Detalle_de_Traslado_de_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Traslado_de_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Traslado_de_CCcountRowsChecked++;
    var Detalle_de_Traslado_de_CCRowElement = "Detalle_de_Traslado_de_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Traslado_de_CCTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Traslado_de_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Traslado_de_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Traslado_de_CCGetUpdateRowControls(prevData, "Detalle_de_Traslado_de_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Traslado_de_CCRowElement + "')){ Detalle_de_Traslado_de_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Traslado_de_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Traslado_de_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Traslado_de_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Traslado_de_CCValidation();
    initiateUIControls();
    $('.Detalle_de_Traslado_de_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Traslado_de_CC(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Traslado_de_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Traslado_de_CCTable.fnGetData().length;
    Detalle_de_Traslado_de_CCfnClickAddRow();
    GetAddDetalle_de_Traslado_de_CCPopup(currentRowIndex, 0);
}

function Detalle_de_Traslado_de_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Traslado_de_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Traslado_de_CCRowElement = "Detalle_de_Traslado_de_CC_" + rowIndex.toString();
    var prevData = Detalle_de_Traslado_de_CCTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Traslado_de_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Traslado_de_CCFecha').val(prevData.Fecha);
    $('#Detalle_de_Traslado_de_CCHora').val(prevData.Hora);
    $('#Detalle_de_Traslado_de_CCTemperatura').val(prevData.Temperatura);
    $('#Detalle_de_Traslado_de_CCHumedad').val(prevData.Humedad);
    $('#Detalle_de_Traslado_de_CCLatitud').val(prevData.Latitud);
    $('#Detalle_de_Traslado_de_CCLongitud').val(prevData.Longitud);
    $('#Detalle_de_Traslado_de_CCEstatus').val(prevData.Estatus);

    initiateUIControls();









}

function Detalle_de_Traslado_de_CCAddInsertRow() {
    if (Detalle_de_Traslado_de_CCinsertRowCurrentIndex < 1)
    {
        Detalle_de_Traslado_de_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha: ""
        ,Hora: ""
        ,Temperatura: ""
        ,Humedad: ""
        ,Latitud: ""
        ,Longitud: ""
        ,Estatus: ""

    }
}

function Detalle_de_Traslado_de_CCfnClickAddRow() {
    Detalle_de_Traslado_de_CCcountRowsChecked++;
    Detalle_de_Traslado_de_CCTable.fnAddData(Detalle_de_Traslado_de_CCAddInsertRow(), true);
    Detalle_de_Traslado_de_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Traslado_de_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Traslado_de_CCGrid tbody tr:nth-of-type(' + (Detalle_de_Traslado_de_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Traslado_de_CC("Detalle_de_Traslado_de_CC_", "_" + Detalle_de_Traslado_de_CCinsertRowCurrentIndex);
}

function Detalle_de_Traslado_de_CCClearGridData() {
    Detalle_de_Traslado_de_CCData = [];
    Detalle_de_Traslado_de_CCdeletedItem = [];
    Detalle_de_Traslado_de_CCDataMain = [];
    Detalle_de_Traslado_de_CCDataMainPages = [];
    Detalle_de_Traslado_de_CCnewItemCount = 0;
    Detalle_de_Traslado_de_CCmaxItemIndex = 0;
    $("#Detalle_de_Traslado_de_CCGrid").DataTable().clear();
    $("#Detalle_de_Traslado_de_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetDetalle_de_Traslado_de_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Traslado_de_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Traslado_de_CCData[i].Clave);

        form_data.append('[' + i + '].Fecha', Detalle_de_Traslado_de_CCData[i].Fecha);
        form_data.append('[' + i + '].Hora', Detalle_de_Traslado_de_CCData[i].Hora);
        form_data.append('[' + i + '].Temperatura', Detalle_de_Traslado_de_CCData[i].Temperatura);
        form_data.append('[' + i + '].Humedad', Detalle_de_Traslado_de_CCData[i].Humedad);
        form_data.append('[' + i + '].Latitud', Detalle_de_Traslado_de_CCData[i].Latitud);
        form_data.append('[' + i + '].Longitud', Detalle_de_Traslado_de_CCData[i].Longitud);
        form_data.append('[' + i + '].Estatus', Detalle_de_Traslado_de_CCData[i].Estatus);

        form_data.append('[' + i + '].Removed', Detalle_de_Traslado_de_CCData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Traslado_de_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Traslado_de_CC("Detalle_de_Traslado_de_CCTable", rowIndex)) {
    var prevData = Detalle_de_Traslado_de_CCTable.fnGetData(rowIndex);
    var data = Detalle_de_Traslado_de_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha: $('#Detalle_de_Traslado_de_CCFecha').val()
        ,Hora: $('#Detalle_de_Traslado_de_CCHora').val()
        ,Temperatura: $('#Detalle_de_Traslado_de_CCTemperatura').val()
        ,Humedad: $('#Detalle_de_Traslado_de_CCHumedad').val()
        ,Latitud: $('#Detalle_de_Traslado_de_CCLatitud').val()
        ,Longitud: $('#Detalle_de_Traslado_de_CCLongitud').val()
        ,Estatus: $('#Detalle_de_Traslado_de_CCEstatus').val()

    }

    Detalle_de_Traslado_de_CCTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Traslado_de_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Traslado_de_CC-form').modal({ show: false });
    $('#AddDetalle_de_Traslado_de_CC-form').modal('hide');
    Detalle_de_Traslado_de_CCEditRow(rowIndex);
    Detalle_de_Traslado_de_CCInsertRow(rowIndex);
    //}
}
function Detalle_de_Traslado_de_CCRemoveAddRow(rowIndex) {
    Detalle_de_Traslado_de_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Traslado_de_CC MultiRow
//Begin Declarations for Foreigns fields for Catalogo_Tipo_de_Indicio_CC MultiRow
var Catalogo_Tipo_de_Indicio_CCcountRowsChecked = 0;




function GetInsertCatalogo_Tipo_de_Indicio_CCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Catalogo_Tipo_de_Indicio_CC_Descripcion Descripcion').attr('id', 'Catalogo_Tipo_de_Indicio_CC_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Catalogo_Tipo_de_Indicio_CCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRCatalogo_Tipo_de_Indicio_CC("Catalogo_Tipo_de_Indicio_CC_", "_" + rowIndex)) {
    var iPage = Catalogo_Tipo_de_Indicio_CCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Catalogo_Tipo_de_Indicio_CC';
    var prevData = Catalogo_Tipo_de_Indicio_CCTable.fnGetData(rowIndex);
    var data = Catalogo_Tipo_de_Indicio_CCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Catalogo_Tipo_de_Indicio_CCTable.fnUpdate(newData, rowIndex, null, true);
    Catalogo_Tipo_de_Indicio_CCrowCreationGrid(data, newData, rowIndex);
    Catalogo_Tipo_de_Indicio_CCTable.fnPageChange(iPage);
    Catalogo_Tipo_de_Indicio_CCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRCatalogo_Tipo_de_Indicio_CC("Catalogo_Tipo_de_Indicio_CC_", "_" + rowIndex);
  }
}

function Catalogo_Tipo_de_Indicio_CCCancelRow(rowIndex) {
    var prevData = Catalogo_Tipo_de_Indicio_CCTable.fnGetData(rowIndex);
    var data = Catalogo_Tipo_de_Indicio_CCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Catalogo_Tipo_de_Indicio_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Catalogo_Tipo_de_Indicio_CCrowCreationGrid(data, prevData, rowIndex);
    }
	showCatalogo_Tipo_de_Indicio_CCGrid(Catalogo_Tipo_de_Indicio_CCTable.fnGetData());
    Catalogo_Tipo_de_Indicio_CCcountRowsChecked--;
	initiateUIControls();
}

function GetCatalogo_Tipo_de_Indicio_CCFromDataTable() {
    var Catalogo_Tipo_de_Indicio_CCData = [];
    var gridData = Catalogo_Tipo_de_Indicio_CCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Catalogo_Tipo_de_Indicio_CCData.push({
                Clave: gridData[i].Clave

                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedCatalogo_Tipo_de_Indicio_CCData.length; i++) {
        if (removedCatalogo_Tipo_de_Indicio_CCData[i] != null && removedCatalogo_Tipo_de_Indicio_CCData[i].Clave > 0)
            Catalogo_Tipo_de_Indicio_CCData.push({
                Clave: removedCatalogo_Tipo_de_Indicio_CCData[i].Clave

                ,Descripcion: removedCatalogo_Tipo_de_Indicio_CCData[i].Descripcion

                , Removed: true
            });
    }	

    return Catalogo_Tipo_de_Indicio_CCData;
}

function Catalogo_Tipo_de_Indicio_CCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Catalogo_Tipo_de_Indicio_CCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Catalogo_Tipo_de_Indicio_CCcountRowsChecked++;
    var Catalogo_Tipo_de_Indicio_CCRowElement = "Catalogo_Tipo_de_Indicio_CC_" + rowIndex.toString();
    var prevData = Catalogo_Tipo_de_Indicio_CCTable.fnGetData(rowIndexTable );
    var row = Catalogo_Tipo_de_Indicio_CCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Catalogo_Tipo_de_Indicio_CC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Catalogo_Tipo_de_Indicio_CCGetUpdateRowControls(prevData, "Catalogo_Tipo_de_Indicio_CC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Catalogo_Tipo_de_Indicio_CCRowElement + "')){ Catalogo_Tipo_de_Indicio_CCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Catalogo_Tipo_de_Indicio_CCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Catalogo_Tipo_de_Indicio_CCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Catalogo_Tipo_de_Indicio_CCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setCatalogo_Tipo_de_Indicio_CCValidation();
    initiateUIControls();
    $('.Catalogo_Tipo_de_Indicio_CC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRCatalogo_Tipo_de_Indicio_CC(nameOfTable, rowIndexFormed);
    }
}

function Catalogo_Tipo_de_Indicio_CCfnOpenAddRowPopUp() {
    var currentRowIndex = Catalogo_Tipo_de_Indicio_CCTable.fnGetData().length;
    Catalogo_Tipo_de_Indicio_CCfnClickAddRow();
    GetAddCatalogo_Tipo_de_Indicio_CCPopup(currentRowIndex, 0);
}

function Catalogo_Tipo_de_Indicio_CCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Catalogo_Tipo_de_Indicio_CCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Catalogo_Tipo_de_Indicio_CCRowElement = "Catalogo_Tipo_de_Indicio_CC_" + rowIndex.toString();
    var prevData = Catalogo_Tipo_de_Indicio_CCTable.fnGetData(rowIndexTable);
    GetAddCatalogo_Tipo_de_Indicio_CCPopup(rowIndex, 1, prevData.Clave);

    $('#Catalogo_Tipo_de_Indicio_CCDescripcion').val(prevData.Descripcion);

    initiateUIControls();



}

function Catalogo_Tipo_de_Indicio_CCAddInsertRow() {
    if (Catalogo_Tipo_de_Indicio_CCinsertRowCurrentIndex < 1)
    {
        Catalogo_Tipo_de_Indicio_CCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Descripcion: ""

    }
}

function Catalogo_Tipo_de_Indicio_CCfnClickAddRow() {
    Catalogo_Tipo_de_Indicio_CCcountRowsChecked++;
    Catalogo_Tipo_de_Indicio_CCTable.fnAddData(Catalogo_Tipo_de_Indicio_CCAddInsertRow(), true);
    Catalogo_Tipo_de_Indicio_CCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Catalogo_Tipo_de_Indicio_CCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Catalogo_Tipo_de_Indicio_CCGrid tbody tr:nth-of-type(' + (Catalogo_Tipo_de_Indicio_CCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRCatalogo_Tipo_de_Indicio_CC("Catalogo_Tipo_de_Indicio_CC_", "_" + Catalogo_Tipo_de_Indicio_CCinsertRowCurrentIndex);
}

function Catalogo_Tipo_de_Indicio_CCClearGridData() {
    Catalogo_Tipo_de_Indicio_CCData = [];
    Catalogo_Tipo_de_Indicio_CCdeletedItem = [];
    Catalogo_Tipo_de_Indicio_CCDataMain = [];
    Catalogo_Tipo_de_Indicio_CCDataMainPages = [];
    Catalogo_Tipo_de_Indicio_CCnewItemCount = 0;
    Catalogo_Tipo_de_Indicio_CCmaxItemIndex = 0;
    $("#Catalogo_Tipo_de_Indicio_CCGrid").DataTable().clear();
    $("#Catalogo_Tipo_de_Indicio_CCGrid").DataTable().destroy();
}

//Used to Get Cadena de Custodia Information
function GetCatalogo_Tipo_de_Indicio_CC() {
    var form_data = new FormData();
    for (var i = 0; i < Catalogo_Tipo_de_Indicio_CCData.length; i++) {
        form_data.append('[' + i + '].Clave', Catalogo_Tipo_de_Indicio_CCData[i].Clave);

        form_data.append('[' + i + '].Descripcion', Catalogo_Tipo_de_Indicio_CCData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Catalogo_Tipo_de_Indicio_CCData[i].Removed);
    }
    return form_data;
}
function Catalogo_Tipo_de_Indicio_CCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRCatalogo_Tipo_de_Indicio_CC("Catalogo_Tipo_de_Indicio_CCTable", rowIndex)) {
    var prevData = Catalogo_Tipo_de_Indicio_CCTable.fnGetData(rowIndex);
    var data = Catalogo_Tipo_de_Indicio_CCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion: $('#Catalogo_Tipo_de_Indicio_CCDescripcion').val()

    }

    Catalogo_Tipo_de_Indicio_CCTable.fnUpdate(newData, rowIndex, null, true);
    Catalogo_Tipo_de_Indicio_CCrowCreationGrid(data, newData, rowIndex);
    $('#AddCatalogo_Tipo_de_Indicio_CC-form').modal({ show: false });
    $('#AddCatalogo_Tipo_de_Indicio_CC-form').modal('hide');
    Catalogo_Tipo_de_Indicio_CCEditRow(rowIndex);
    Catalogo_Tipo_de_Indicio_CCInsertRow(rowIndex);
    //}
}
function Catalogo_Tipo_de_Indicio_CCRemoveAddRow(rowIndex) {
    Catalogo_Tipo_de_Indicio_CCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Catalogo_Tipo_de_Indicio_CC MultiRow


$(function () {
    function Detalle_del_Certificado_CCinitializeMainArray(totalCount) {
        if (Detalle_del_Certificado_CCDataMain.length != totalCount && !Detalle_del_Certificado_CCDataMainInitialized) {
            Detalle_del_Certificado_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_del_Certificado_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_del_Certificado_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_del_Certificado_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_del_Certificado_CCDataMain.length; i++) {
                if (Detalle_del_Certificado_CCDataMain[i] != null && Detalle_del_Certificado_CCDataMain[i].Id == Detalle_del_Certificado_CCdeletedItem[j]) {
                    hDetalle_del_Certificado_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_del_Certificado_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_del_Certificado_CCDataMain.length; i++) {
            data[i] = Detalle_del_Certificado_CCDataMain[i];

        }
        return data;
    }
    function Detalle_del_Certificado_CCgetNewResult() {
        var newData = copyMainDetalle_del_Certificado_CCArray();

        for (var i = 0; i < Detalle_del_Certificado_CCData.length; i++) {
            if (Detalle_del_Certificado_CCData[i].Removed == null || Detalle_del_Certificado_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_del_Certificado_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_del_Certificado_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_del_Certificado_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_del_Certificado_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Fotos_CCinitializeMainArray(totalCount) {
        if (Detalle_de_Fotos_CCDataMain.length != totalCount && !Detalle_de_Fotos_CCDataMainInitialized) {
            Detalle_de_Fotos_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Fotos_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Fotos_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Fotos_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Fotos_CCDataMain.length; i++) {
                if (Detalle_de_Fotos_CCDataMain[i] != null && Detalle_de_Fotos_CCDataMain[i].Id == Detalle_de_Fotos_CCdeletedItem[j]) {
                    hDetalle_de_Fotos_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Fotos_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Fotos_CCDataMain.length; i++) {
            data[i] = Detalle_de_Fotos_CCDataMain[i];

        }
        return data;
    }
    function Detalle_de_Fotos_CCgetNewResult() {
        var newData = copyMainDetalle_de_Fotos_CCArray();

        for (var i = 0; i < Detalle_de_Fotos_CCData.length; i++) {
            if (Detalle_de_Fotos_CCData[i].Removed == null || Detalle_de_Fotos_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Fotos_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Fotos_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Fotos_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Fotos_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Videos_CCinitializeMainArray(totalCount) {
        if (Detalle_de_Videos_CCDataMain.length != totalCount && !Detalle_de_Videos_CCDataMainInitialized) {
            Detalle_de_Videos_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Videos_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Videos_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Videos_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Videos_CCDataMain.length; i++) {
                if (Detalle_de_Videos_CCDataMain[i] != null && Detalle_de_Videos_CCDataMain[i].Id == Detalle_de_Videos_CCdeletedItem[j]) {
                    hDetalle_de_Videos_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Videos_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Videos_CCDataMain.length; i++) {
            data[i] = Detalle_de_Videos_CCDataMain[i];

        }
        return data;
    }
    function Detalle_de_Videos_CCgetNewResult() {
        var newData = copyMainDetalle_de_Videos_CCArray();

        for (var i = 0; i < Detalle_de_Videos_CCData.length; i++) {
            if (Detalle_de_Videos_CCData[i].Removed == null || Detalle_de_Videos_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Videos_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Videos_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Videos_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Videos_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Registro_de_Intervinientes_CCinitializeMainArray(totalCount) {
        if (Detalle_de_Registro_de_Intervinientes_CCDataMain.length != totalCount && !Detalle_de_Registro_de_Intervinientes_CCDataMainInitialized) {
            Detalle_de_Registro_de_Intervinientes_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Registro_de_Intervinientes_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Registro_de_Intervinientes_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Registro_de_Intervinientes_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CCDataMain.length; i++) {
                if (Detalle_de_Registro_de_Intervinientes_CCDataMain[i] != null && Detalle_de_Registro_de_Intervinientes_CCDataMain[i].Id == Detalle_de_Registro_de_Intervinientes_CCdeletedItem[j]) {
                    hDetalle_de_Registro_de_Intervinientes_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Registro_de_Intervinientes_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CCDataMain.length; i++) {
            data[i] = Detalle_de_Registro_de_Intervinientes_CCDataMain[i];

        }
        return data;
    }
    function Detalle_de_Registro_de_Intervinientes_CCgetNewResult() {
        var newData = copyMainDetalle_de_Registro_de_Intervinientes_CCArray();

        for (var i = 0; i < Detalle_de_Registro_de_Intervinientes_CCData.length; i++) {
            if (Detalle_de_Registro_de_Intervinientes_CCData[i].Removed == null || Detalle_de_Registro_de_Intervinientes_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Registro_de_Intervinientes_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Registro_de_Intervinientes_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Registro_de_Intervinientes_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Registro_de_Intervinientes_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Descripcion_de_Evidencia_CCinitializeMainArray(totalCount) {
        if (Detalle_de_Descripcion_de_Evidencia_CCDataMain.length != totalCount && !Detalle_de_Descripcion_de_Evidencia_CCDataMainInitialized) {
            Detalle_de_Descripcion_de_Evidencia_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Descripcion_de_Evidencia_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Descripcion_de_Evidencia_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Descripcion_de_Evidencia_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Descripcion_de_Evidencia_CCDataMain.length; i++) {
                if (Detalle_de_Descripcion_de_Evidencia_CCDataMain[i] != null && Detalle_de_Descripcion_de_Evidencia_CCDataMain[i].Id == Detalle_de_Descripcion_de_Evidencia_CCdeletedItem[j]) {
                    hDetalle_de_Descripcion_de_Evidencia_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Descripcion_de_Evidencia_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Descripcion_de_Evidencia_CCDataMain.length; i++) {
            data[i] = Detalle_de_Descripcion_de_Evidencia_CCDataMain[i];

        }
        return data;
    }
    function Detalle_de_Descripcion_de_Evidencia_CCgetNewResult() {
        var newData = copyMainDetalle_de_Descripcion_de_Evidencia_CCArray();

        for (var i = 0; i < Detalle_de_Descripcion_de_Evidencia_CCData.length; i++) {
            if (Detalle_de_Descripcion_de_Evidencia_CCData[i].Removed == null || Detalle_de_Descripcion_de_Evidencia_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Descripcion_de_Evidencia_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Descripcion_de_Evidencia_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Descripcion_de_Evidencia_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Descripcion_de_Evidencia_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Lista_de_Documentos_CCinitializeMainArray(totalCount) {
        if (Detalle_de_Lista_de_Documentos_CCDataMain.length != totalCount && !Detalle_de_Lista_de_Documentos_CCDataMainInitialized) {
            Detalle_de_Lista_de_Documentos_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Lista_de_Documentos_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Lista_de_Documentos_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Lista_de_Documentos_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Lista_de_Documentos_CCDataMain.length; i++) {
                if (Detalle_de_Lista_de_Documentos_CCDataMain[i] != null && Detalle_de_Lista_de_Documentos_CCDataMain[i].Id == Detalle_de_Lista_de_Documentos_CCdeletedItem[j]) {
                    hDetalle_de_Lista_de_Documentos_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Lista_de_Documentos_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Lista_de_Documentos_CCDataMain.length; i++) {
            data[i] = Detalle_de_Lista_de_Documentos_CCDataMain[i];

        }
        return data;
    }
    function Detalle_de_Lista_de_Documentos_CCgetNewResult() {
        var newData = copyMainDetalle_de_Lista_de_Documentos_CCArray();

        for (var i = 0; i < Detalle_de_Lista_de_Documentos_CCData.length; i++) {
            if (Detalle_de_Lista_de_Documentos_CCData[i].Removed == null || Detalle_de_Lista_de_Documentos_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Lista_de_Documentos_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Lista_de_Documentos_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Lista_de_Documentos_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Lista_de_Documentos_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_RetroalimentacioninitializeMainArray(totalCount) {
        if (Detalle_de_RetroalimentacionDataMain.length != totalCount && !Detalle_de_RetroalimentacionDataMainInitialized) {
            Detalle_de_RetroalimentacionDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_RetroalimentacionDataMain[i] = null;
            }
        }
    }
    function Detalle_de_RetroalimentacionremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_RetroalimentaciondeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_RetroalimentacionDataMain.length; i++) {
                if (Detalle_de_RetroalimentacionDataMain[i] != null && Detalle_de_RetroalimentacionDataMain[i].Id == Detalle_de_RetroalimentaciondeletedItem[j]) {
                    hDetalle_de_RetroalimentacionDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_RetroalimentacioncopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_RetroalimentacionDataMain.length; i++) {
            data[i] = Detalle_de_RetroalimentacionDataMain[i];

        }
        return data;
    }
    function Detalle_de_RetroalimentaciongetNewResult() {
        var newData = copyMainDetalle_de_RetroalimentacionArray();

        for (var i = 0; i < Detalle_de_RetroalimentacionData.length; i++) {
            if (Detalle_de_RetroalimentacionData[i].Removed == null || Detalle_de_RetroalimentacionData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_RetroalimentacionData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_RetroalimentacionpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_RetroalimentacionDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_RetroalimentacionDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_ReferenciainitializeMainArray(totalCount) {
        if (Detalle_de_ReferenciaDataMain.length != totalCount && !Detalle_de_ReferenciaDataMainInitialized) {
            Detalle_de_ReferenciaDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_ReferenciaDataMain[i] = null;
            }
        }
    }
    function Detalle_de_ReferenciaremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_ReferenciadeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_ReferenciaDataMain.length; i++) {
                if (Detalle_de_ReferenciaDataMain[i] != null && Detalle_de_ReferenciaDataMain[i].Id == Detalle_de_ReferenciadeletedItem[j]) {
                    hDetalle_de_ReferenciaDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_ReferenciacopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_ReferenciaDataMain.length; i++) {
            data[i] = Detalle_de_ReferenciaDataMain[i];

        }
        return data;
    }
    function Detalle_de_ReferenciagetNewResult() {
        var newData = copyMainDetalle_de_ReferenciaArray();

        for (var i = 0; i < Detalle_de_ReferenciaData.length; i++) {
            if (Detalle_de_ReferenciaData[i].Removed == null || Detalle_de_ReferenciaData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_ReferenciaData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_ReferenciapushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_ReferenciaDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_ReferenciaDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Fotos_de_Emergencia_CCinitializeMainArray(totalCount) {
        if (Detalle_de_Fotos_de_Emergencia_CCDataMain.length != totalCount && !Detalle_de_Fotos_de_Emergencia_CCDataMainInitialized) {
            Detalle_de_Fotos_de_Emergencia_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Fotos_de_Emergencia_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Fotos_de_Emergencia_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Fotos_de_Emergencia_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Fotos_de_Emergencia_CCDataMain.length; i++) {
                if (Detalle_de_Fotos_de_Emergencia_CCDataMain[i] != null && Detalle_de_Fotos_de_Emergencia_CCDataMain[i].Id == Detalle_de_Fotos_de_Emergencia_CCdeletedItem[j]) {
                    hDetalle_de_Fotos_de_Emergencia_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Fotos_de_Emergencia_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Fotos_de_Emergencia_CCDataMain.length; i++) {
            data[i] = Detalle_de_Fotos_de_Emergencia_CCDataMain[i];

        }
        return data;
    }
    function Detalle_de_Fotos_de_Emergencia_CCgetNewResult() {
        var newData = copyMainDetalle_de_Fotos_de_Emergencia_CCArray();

        for (var i = 0; i < Detalle_de_Fotos_de_Emergencia_CCData.length; i++) {
            if (Detalle_de_Fotos_de_Emergencia_CCData[i].Removed == null || Detalle_de_Fotos_de_Emergencia_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Fotos_de_Emergencia_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Fotos_de_Emergencia_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Fotos_de_Emergencia_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Fotos_de_Emergencia_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Historial_de_Emergencia_CCinitializeMainArray(totalCount) {
        if (Detalle_de_Historial_de_Emergencia_CCDataMain.length != totalCount && !Detalle_de_Historial_de_Emergencia_CCDataMainInitialized) {
            Detalle_de_Historial_de_Emergencia_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Historial_de_Emergencia_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Historial_de_Emergencia_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Historial_de_Emergencia_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Historial_de_Emergencia_CCDataMain.length; i++) {
                if (Detalle_de_Historial_de_Emergencia_CCDataMain[i] != null && Detalle_de_Historial_de_Emergencia_CCDataMain[i].Id == Detalle_de_Historial_de_Emergencia_CCdeletedItem[j]) {
                    hDetalle_de_Historial_de_Emergencia_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Historial_de_Emergencia_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Historial_de_Emergencia_CCDataMain.length; i++) {
            data[i] = Detalle_de_Historial_de_Emergencia_CCDataMain[i];

        }
        return data;
    }
    function Detalle_de_Historial_de_Emergencia_CCgetNewResult() {
        var newData = copyMainDetalle_de_Historial_de_Emergencia_CCArray();

        for (var i = 0; i < Detalle_de_Historial_de_Emergencia_CCData.length; i++) {
            if (Detalle_de_Historial_de_Emergencia_CCData[i].Removed == null || Detalle_de_Historial_de_Emergencia_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Historial_de_Emergencia_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Historial_de_Emergencia_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Historial_de_Emergencia_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Historial_de_Emergencia_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Datos_del_Imputado_CCinitializeMainArray(totalCount) {
        if (Detalle_de_Datos_del_Imputado_CCDataMain.length != totalCount && !Detalle_de_Datos_del_Imputado_CCDataMainInitialized) {
            Detalle_de_Datos_del_Imputado_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Datos_del_Imputado_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Datos_del_Imputado_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Datos_del_Imputado_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Datos_del_Imputado_CCDataMain.length; i++) {
                if (Detalle_de_Datos_del_Imputado_CCDataMain[i] != null && Detalle_de_Datos_del_Imputado_CCDataMain[i].Id == Detalle_de_Datos_del_Imputado_CCdeletedItem[j]) {
                    hDetalle_de_Datos_del_Imputado_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Datos_del_Imputado_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Datos_del_Imputado_CCDataMain.length; i++) {
            data[i] = Detalle_de_Datos_del_Imputado_CCDataMain[i];

        }
        return data;
    }
    function Detalle_de_Datos_del_Imputado_CCgetNewResult() {
        var newData = copyMainDetalle_de_Datos_del_Imputado_CCArray();

        for (var i = 0; i < Detalle_de_Datos_del_Imputado_CCData.length; i++) {
            if (Detalle_de_Datos_del_Imputado_CCData[i].Removed == null || Detalle_de_Datos_del_Imputado_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Datos_del_Imputado_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Datos_del_Imputado_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Datos_del_Imputado_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Datos_del_Imputado_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Datos_del_Testigo_CCinitializeMainArray(totalCount) {
        if (Detalle_de_Datos_del_Testigo_CCDataMain.length != totalCount && !Detalle_de_Datos_del_Testigo_CCDataMainInitialized) {
            Detalle_de_Datos_del_Testigo_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Datos_del_Testigo_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Datos_del_Testigo_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Datos_del_Testigo_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Datos_del_Testigo_CCDataMain.length; i++) {
                if (Detalle_de_Datos_del_Testigo_CCDataMain[i] != null && Detalle_de_Datos_del_Testigo_CCDataMain[i].Id == Detalle_de_Datos_del_Testigo_CCdeletedItem[j]) {
                    hDetalle_de_Datos_del_Testigo_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Datos_del_Testigo_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Datos_del_Testigo_CCDataMain.length; i++) {
            data[i] = Detalle_de_Datos_del_Testigo_CCDataMain[i];

        }
        return data;
    }
    function Detalle_de_Datos_del_Testigo_CCgetNewResult() {
        var newData = copyMainDetalle_de_Datos_del_Testigo_CCArray();

        for (var i = 0; i < Detalle_de_Datos_del_Testigo_CCData.length; i++) {
            if (Detalle_de_Datos_del_Testigo_CCData[i].Removed == null || Detalle_de_Datos_del_Testigo_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Datos_del_Testigo_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Datos_del_Testigo_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Datos_del_Testigo_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Datos_del_Testigo_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Catalogo_Tipo_de_Embalaje_CCinitializeMainArray(totalCount) {
        if (Catalogo_Tipo_de_Embalaje_CCDataMain.length != totalCount && !Catalogo_Tipo_de_Embalaje_CCDataMainInitialized) {
            Catalogo_Tipo_de_Embalaje_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Catalogo_Tipo_de_Embalaje_CCDataMain[i] = null;
            }
        }
    }
    function Catalogo_Tipo_de_Embalaje_CCremoveFromMainArray() {
        for (var j = 0; j < Catalogo_Tipo_de_Embalaje_CCdeletedItem.length; j++) {
            for (var i = 0; i < Catalogo_Tipo_de_Embalaje_CCDataMain.length; i++) {
                if (Catalogo_Tipo_de_Embalaje_CCDataMain[i] != null && Catalogo_Tipo_de_Embalaje_CCDataMain[i].Id == Catalogo_Tipo_de_Embalaje_CCdeletedItem[j]) {
                    hCatalogo_Tipo_de_Embalaje_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Catalogo_Tipo_de_Embalaje_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Catalogo_Tipo_de_Embalaje_CCDataMain.length; i++) {
            data[i] = Catalogo_Tipo_de_Embalaje_CCDataMain[i];

        }
        return data;
    }
    function Catalogo_Tipo_de_Embalaje_CCgetNewResult() {
        var newData = copyMainCatalogo_Tipo_de_Embalaje_CCArray();

        for (var i = 0; i < Catalogo_Tipo_de_Embalaje_CCData.length; i++) {
            if (Catalogo_Tipo_de_Embalaje_CCData[i].Removed == null || Catalogo_Tipo_de_Embalaje_CCData[i].Removed == false) {
                newData.splice(0, 0, Catalogo_Tipo_de_Embalaje_CCData[i]);
            }
        }
        return newData;
    }
    function Catalogo_Tipo_de_Embalaje_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Catalogo_Tipo_de_Embalaje_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Catalogo_Tipo_de_Embalaje_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Lista_de_AsignacionesinitializeMainArray(totalCount) {
        if (Detalle_de_Lista_de_AsignacionesDataMain.length != totalCount && !Detalle_de_Lista_de_AsignacionesDataMainInitialized) {
            Detalle_de_Lista_de_AsignacionesDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Lista_de_AsignacionesDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Lista_de_AsignacionesremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Lista_de_AsignacionesdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Lista_de_AsignacionesDataMain.length; i++) {
                if (Detalle_de_Lista_de_AsignacionesDataMain[i] != null && Detalle_de_Lista_de_AsignacionesDataMain[i].Id == Detalle_de_Lista_de_AsignacionesdeletedItem[j]) {
                    hDetalle_de_Lista_de_AsignacionesDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Lista_de_AsignacionescopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Lista_de_AsignacionesDataMain.length; i++) {
            data[i] = Detalle_de_Lista_de_AsignacionesDataMain[i];

        }
        return data;
    }
    function Detalle_de_Lista_de_AsignacionesgetNewResult() {
        var newData = copyMainDetalle_de_Lista_de_AsignacionesArray();

        for (var i = 0; i < Detalle_de_Lista_de_AsignacionesData.length; i++) {
            if (Detalle_de_Lista_de_AsignacionesData[i].Removed == null || Detalle_de_Lista_de_AsignacionesData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Lista_de_AsignacionesData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Lista_de_AsignacionespushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Lista_de_AsignacionesDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Lista_de_AsignacionesDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Catalogo_Tipo_de_Fijacion_CCinitializeMainArray(totalCount) {
        if (Catalogo_Tipo_de_Fijacion_CCDataMain.length != totalCount && !Catalogo_Tipo_de_Fijacion_CCDataMainInitialized) {
            Catalogo_Tipo_de_Fijacion_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Catalogo_Tipo_de_Fijacion_CCDataMain[i] = null;
            }
        }
    }
    function Catalogo_Tipo_de_Fijacion_CCremoveFromMainArray() {
        for (var j = 0; j < Catalogo_Tipo_de_Fijacion_CCdeletedItem.length; j++) {
            for (var i = 0; i < Catalogo_Tipo_de_Fijacion_CCDataMain.length; i++) {
                if (Catalogo_Tipo_de_Fijacion_CCDataMain[i] != null && Catalogo_Tipo_de_Fijacion_CCDataMain[i].Id == Catalogo_Tipo_de_Fijacion_CCdeletedItem[j]) {
                    hCatalogo_Tipo_de_Fijacion_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Catalogo_Tipo_de_Fijacion_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Catalogo_Tipo_de_Fijacion_CCDataMain.length; i++) {
            data[i] = Catalogo_Tipo_de_Fijacion_CCDataMain[i];

        }
        return data;
    }
    function Catalogo_Tipo_de_Fijacion_CCgetNewResult() {
        var newData = copyMainCatalogo_Tipo_de_Fijacion_CCArray();

        for (var i = 0; i < Catalogo_Tipo_de_Fijacion_CCData.length; i++) {
            if (Catalogo_Tipo_de_Fijacion_CCData[i].Removed == null || Catalogo_Tipo_de_Fijacion_CCData[i].Removed == false) {
                newData.splice(0, 0, Catalogo_Tipo_de_Fijacion_CCData[i]);
            }
        }
        return newData;
    }
    function Catalogo_Tipo_de_Fijacion_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Catalogo_Tipo_de_Fijacion_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Catalogo_Tipo_de_Fijacion_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Traslado_de_CCinitializeMainArray(totalCount) {
        if (Detalle_de_Traslado_de_CCDataMain.length != totalCount && !Detalle_de_Traslado_de_CCDataMainInitialized) {
            Detalle_de_Traslado_de_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Traslado_de_CCDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Traslado_de_CCremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Traslado_de_CCdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Traslado_de_CCDataMain.length; i++) {
                if (Detalle_de_Traslado_de_CCDataMain[i] != null && Detalle_de_Traslado_de_CCDataMain[i].Id == Detalle_de_Traslado_de_CCdeletedItem[j]) {
                    hDetalle_de_Traslado_de_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Traslado_de_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Traslado_de_CCDataMain.length; i++) {
            data[i] = Detalle_de_Traslado_de_CCDataMain[i];

        }
        return data;
    }
    function Detalle_de_Traslado_de_CCgetNewResult() {
        var newData = copyMainDetalle_de_Traslado_de_CCArray();

        for (var i = 0; i < Detalle_de_Traslado_de_CCData.length; i++) {
            if (Detalle_de_Traslado_de_CCData[i].Removed == null || Detalle_de_Traslado_de_CCData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Traslado_de_CCData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Traslado_de_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Traslado_de_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Traslado_de_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Catalogo_Tipo_de_Indicio_CCinitializeMainArray(totalCount) {
        if (Catalogo_Tipo_de_Indicio_CCDataMain.length != totalCount && !Catalogo_Tipo_de_Indicio_CCDataMainInitialized) {
            Catalogo_Tipo_de_Indicio_CCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Catalogo_Tipo_de_Indicio_CCDataMain[i] = null;
            }
        }
    }
    function Catalogo_Tipo_de_Indicio_CCremoveFromMainArray() {
        for (var j = 0; j < Catalogo_Tipo_de_Indicio_CCdeletedItem.length; j++) {
            for (var i = 0; i < Catalogo_Tipo_de_Indicio_CCDataMain.length; i++) {
                if (Catalogo_Tipo_de_Indicio_CCDataMain[i] != null && Catalogo_Tipo_de_Indicio_CCDataMain[i].Id == Catalogo_Tipo_de_Indicio_CCdeletedItem[j]) {
                    hCatalogo_Tipo_de_Indicio_CCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Catalogo_Tipo_de_Indicio_CCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Catalogo_Tipo_de_Indicio_CCDataMain.length; i++) {
            data[i] = Catalogo_Tipo_de_Indicio_CCDataMain[i];

        }
        return data;
    }
    function Catalogo_Tipo_de_Indicio_CCgetNewResult() {
        var newData = copyMainCatalogo_Tipo_de_Indicio_CCArray();

        for (var i = 0; i < Catalogo_Tipo_de_Indicio_CCData.length; i++) {
            if (Catalogo_Tipo_de_Indicio_CCData[i].Removed == null || Catalogo_Tipo_de_Indicio_CCData[i].Removed == false) {
                newData.splice(0, 0, Catalogo_Tipo_de_Indicio_CCData[i]);
            }
        }
        return newData;
    }
    function Catalogo_Tipo_de_Indicio_CCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Catalogo_Tipo_de_Indicio_CCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Catalogo_Tipo_de_Indicio_CCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteAsignarData = [];
function GetAutoCompleteCadena_de_Custodia_Asignar_Spartan_UserData(data) {
	AutoCompleteAsignarData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteAsignarData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteAsignarData;
}
//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Cadena_de_Custodia_cmbLabelSelect").val();
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
    $('#CreateCadena_de_Custodia')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Asignar').empty();
    $("#Asignar").append('<option value=""></option>');
    $('#Asignar').val('0').trigger('change');
                Detalle_del_Certificado_CCClearGridData();
                Detalle_de_Fotos_CCClearGridData();
                Detalle_de_Videos_CCClearGridData();
                Detalle_de_Registro_de_Intervinientes_CCClearGridData();
                Detalle_de_Descripcion_de_Evidencia_CCClearGridData();
                Detalle_de_Lista_de_Documentos_CCClearGridData();
                Detalle_de_RetroalimentacionClearGridData();
                Detalle_de_ReferenciaClearGridData();
                Detalle_de_Fotos_de_Emergencia_CCClearGridData();
                Detalle_de_Historial_de_Emergencia_CCClearGridData();
                Detalle_de_Datos_del_Imputado_CCClearGridData();
                Detalle_de_Datos_del_Testigo_CCClearGridData();
                Catalogo_Tipo_de_Embalaje_CCClearGridData();
                Detalle_de_Lista_de_AsignacionesClearGridData();
                Catalogo_Tipo_de_Fijacion_CCClearGridData();
                Detalle_de_Traslado_de_CCClearGridData();
                Catalogo_Tipo_de_Indicio_CCClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateCadena_de_Custodia').trigger('reset');
    $('#CreateCadena_de_Custodia').find(':input').each(function () {
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
    var $myForm = $('#CreateCadena_de_Custodia');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_del_Certificado_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_del_Certificado_CC();
        return false;
    }
    if (Detalle_de_Fotos_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Fotos_CC();
        return false;
    }
    if (Detalle_de_Videos_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Videos_CC();
        return false;
    }
    if (Detalle_de_Registro_de_Intervinientes_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Registro_de_Intervinientes_CC();
        return false;
    }
    if (Detalle_de_Descripcion_de_Evidencia_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Descripcion_de_Evidencia_CC();
        return false;
    }
    if (Detalle_de_Lista_de_Documentos_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Lista_de_Documentos_CC();
        return false;
    }
    if (Detalle_de_RetroalimentacioncountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Retroalimentacion();
        return false;
    }
    if (Detalle_de_ReferenciacountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Referencia();
        return false;
    }
    if (Detalle_de_Fotos_de_Emergencia_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Fotos_de_Emergencia_CC();
        return false;
    }
    if (Detalle_de_Historial_de_Emergencia_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Historial_de_Emergencia_CC();
        return false;
    }
    if (Detalle_de_Datos_del_Imputado_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Datos_del_Imputado_CC();
        return false;
    }
    if (Detalle_de_Datos_del_Testigo_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Datos_del_Testigo_CC();
        return false;
    }
    if (Catalogo_Tipo_de_Embalaje_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowCatalogo_Tipo_de_Embalaje_CC();
        return false;
    }
    if (Detalle_de_Lista_de_AsignacionescountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Lista_de_Asignaciones();
        return false;
    }
    if (Catalogo_Tipo_de_Fijacion_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowCatalogo_Tipo_de_Fijacion_CC();
        return false;
    }
    if (Detalle_de_Traslado_de_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Traslado_de_CC();
        return false;
    }
    if (Catalogo_Tipo_de_Indicio_CCcountRowsChecked > 0)
    {
        ShowMessagePendingRowCatalogo_Tipo_de_Indicio_CC();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateCadena_de_Custodia").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateCadena_de_Custodia").on('click', '#Cadena_de_CustodiaCancelar', function () {
	  if (!isPartial) {
        Cadena_de_CustodiaBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateCadena_de_Custodia").on('click', '#Cadena_de_CustodiaGuardar', function () {
		$('#Cadena_de_CustodiaGuardar').attr('disabled', true);
		$('#Cadena_de_CustodiaGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendCadena_de_CustodiaData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Cadena_de_CustodiaBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Cadena_de_CustodiaGuardar').removeAttr('disabled');
                        $('#Cadena_de_CustodiaGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Cadena_de_Custodia', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Cadena_de_CustodiaItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Cadena_de_CustodiaDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Cadena_de_CustodiaGuardar').removeAttr('disabled');
					$('#Cadena_de_CustodiaGuardar').bind()
				}
		}
		else {
			$('#Cadena_de_CustodiaGuardar').removeAttr('disabled');
			$('#Cadena_de_CustodiaGuardar').bind()
		}
    });
	$("form#CreateCadena_de_Custodia").on('click', '#Cadena_de_CustodiaGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendCadena_de_CustodiaData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_del_Certificado_CCData();
                getDetalle_de_Fotos_CCData();
                getDetalle_de_Videos_CCData();
                getDetalle_de_Registro_de_Intervinientes_CCData();
                getDetalle_de_Descripcion_de_Evidencia_CCData();
                getDetalle_de_Lista_de_Documentos_CCData();
                getDetalle_de_RetroalimentacionData();
                getDetalle_de_ReferenciaData();
                getDetalle_de_Fotos_de_Emergencia_CCData();
                getDetalle_de_Historial_de_Emergencia_CCData();
                getDetalle_de_Datos_del_Imputado_CCData();
                getDetalle_de_Datos_del_Testigo_CCData();
                getCatalogo_Tipo_de_Embalaje_CCData();
                getDetalle_de_Lista_de_AsignacionesData();
                getCatalogo_Tipo_de_Fijacion_CCData();
                getDetalle_de_Traslado_de_CCData();
                getCatalogo_Tipo_de_Indicio_CCData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Cadena_de_Custodia', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Cadena_de_CustodiaItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Cadena_de_CustodiaDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateCadena_de_Custodia").on('click', '#Cadena_de_CustodiaGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendCadena_de_CustodiaData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Asignar').empty();
    $("#Asignar").append('<option value=""></option>');
    $('#Asignar').val('0').trigger('change');
                Detalle_del_Certificado_CCClearGridData();
                Detalle_de_Fotos_CCClearGridData();
                Detalle_de_Videos_CCClearGridData();
                Detalle_de_Registro_de_Intervinientes_CCClearGridData();
                Detalle_de_Descripcion_de_Evidencia_CCClearGridData();
                Detalle_de_Lista_de_Documentos_CCClearGridData();
                Detalle_de_RetroalimentacionClearGridData();
                Detalle_de_ReferenciaClearGridData();
                Detalle_de_Fotos_de_Emergencia_CCClearGridData();
                Detalle_de_Historial_de_Emergencia_CCClearGridData();
                Detalle_de_Datos_del_Imputado_CCClearGridData();
                Detalle_de_Datos_del_Testigo_CCClearGridData();
                Catalogo_Tipo_de_Embalaje_CCClearGridData();
                Detalle_de_Lista_de_AsignacionesClearGridData();
                Catalogo_Tipo_de_Fijacion_CCClearGridData();
                Detalle_de_Traslado_de_CCClearGridData();
                Catalogo_Tipo_de_Indicio_CCClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_del_Certificado_CCData();
                getDetalle_de_Fotos_CCData();
                getDetalle_de_Videos_CCData();
                getDetalle_de_Registro_de_Intervinientes_CCData();
                getDetalle_de_Descripcion_de_Evidencia_CCData();
                getDetalle_de_Lista_de_Documentos_CCData();
                getDetalle_de_RetroalimentacionData();
                getDetalle_de_ReferenciaData();
                getDetalle_de_Fotos_de_Emergencia_CCData();
                getDetalle_de_Historial_de_Emergencia_CCData();
                getDetalle_de_Datos_del_Imputado_CCData();
                getDetalle_de_Datos_del_Testigo_CCData();
                getCatalogo_Tipo_de_Embalaje_CCData();
                getDetalle_de_Lista_de_AsignacionesData();
                getCatalogo_Tipo_de_Fijacion_CCData();
                getDetalle_de_Traslado_de_CCData();
                getCatalogo_Tipo_de_Indicio_CCData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Cadena_de_Custodia',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Cadena_de_CustodiaItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Cadena_de_CustodiaDropDown().get(0)').innerHTML);                          
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



var Cadena_de_CustodiaisdisplayBusinessPropery = false;
Cadena_de_CustodiaDisplayBusinessRuleButtons(Cadena_de_CustodiaisdisplayBusinessPropery);
function Cadena_de_CustodiaDisplayBusinessRule() {
    if (!Cadena_de_CustodiaisdisplayBusinessPropery) {
        $('#CreateCadena_de_Custodia').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Cadena_de_CustodiadisplayBusinessPropery"><button onclick="Cadena_de_CustodiaGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Cadena_de_CustodiaBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Cadena_de_CustodiadisplayBusinessPropery').remove();
    }
    Cadena_de_CustodiaDisplayBusinessRuleButtons(!Cadena_de_CustodiaisdisplayBusinessPropery);
    Cadena_de_CustodiaisdisplayBusinessPropery = (Cadena_de_CustodiaisdisplayBusinessPropery ? false : true);
}
function Cadena_de_CustodiaDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

