﻿        function RemoveAttachmentMainArchivo_Adjunto () {
            $("#hdnRemoveArchivo_Adjunto").val("1");
            $("#divAttachmentArchivo_Adjunto").hide();
        }


//Begin Declarations for Foreigns fields for Detalle_Delitos_de_Documentos MultiRow
var Detalle_Delitos_de_DocumentoscountRowsChecked = 0;

function GetDetalle_Delitos_de_Documentos_Detalle_de_DelitoName(Id) {
    for (var i = 0; i < Detalle_Delitos_de_Documentos_Detalle_de_DelitoItems.length; i++) {
        if (Detalle_Delitos_de_Documentos_Detalle_de_DelitoItems[i].Clave == Id) {
            return Detalle_Delitos_de_Documentos_Detalle_de_DelitoItems[i].Descripcion_corta;
        }
    }
    return "";
}

function GetDetalle_Delitos_de_Documentos_Detalle_de_DelitoDropDown() {
    var Detalle_Delitos_de_Documentos_Detalle_de_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Delitos_de_Documentos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Delitos_de_Documentos_Detalle_de_DelitoDropdown);

    for (var i = 0; i < Detalle_Delitos_de_Documentos_Detalle_de_DelitoItems.length; i++) {
        $('<option />', { value: Detalle_Delitos_de_Documentos_Detalle_de_DelitoItems[i].Clave, text: Detalle_Delitos_de_Documentos_Detalle_de_DelitoItems[i].Descripcion_corta }).appendTo(Detalle_Delitos_de_Documentos_Detalle_de_DelitoDropdown);
    }
    return Detalle_Delitos_de_Documentos_Detalle_de_DelitoDropdown;
}


function GetInsertDetalle_Delitos_de_DocumentosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Delitos_de_Documentos_Delito'))).addClass('Detalle_Delitos_de_Documentos_Delito Delito').attr('id', 'Detalle_Delitos_de_Documentos_Delito_' + index).attr('data-field', 'Delito').after($.parseHTML(addNew('Detalle_Delitos_de_Documentos', 'Detalle_de_Delito', 'Delito', 266659)));


    initiateUIControls();
    return columnData;
}

function Detalle_Delitos_de_DocumentosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Delitos_de_Documentos("Detalle_Delitos_de_Documentos_", "_" + rowIndex)) {
    var iPage = Detalle_Delitos_de_DocumentosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Delitos_de_Documentos';
    var prevData = Detalle_Delitos_de_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Delitos_de_DocumentosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , DelitoDescripcion_corta:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Delito:  data.childNodes[counter++].childNodes[0].value 	

    }
    Detalle_Delitos_de_DocumentosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Delitos_de_DocumentosrowCreationGrid(data, newData, rowIndex);
    Detalle_Delitos_de_DocumentosTable.fnPageChange(iPage);
    Detalle_Delitos_de_DocumentoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Delitos_de_Documentos("Detalle_Delitos_de_Documentos_", "_" + rowIndex);
  }
}

function Detalle_Delitos_de_DocumentosCancelRow(rowIndex) {
    var prevData = Detalle_Delitos_de_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Delitos_de_DocumentosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Delitos_de_DocumentosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Delitos_de_DocumentosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Delitos_de_DocumentosGrid(Detalle_Delitos_de_DocumentosTable.fnGetData());
    Detalle_Delitos_de_DocumentoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Delitos_de_DocumentosFromDataTable() {
    var Detalle_Delitos_de_DocumentosData = [];
    var gridData = Detalle_Delitos_de_DocumentosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Delitos_de_DocumentosData.push({
                Clave: gridData[i].Clave

                ,Delito: gridData[i].Delito

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Delitos_de_DocumentosData.length; i++) {
        if (removedDetalle_Delitos_de_DocumentosData[i] != null && removedDetalle_Delitos_de_DocumentosData[i].Clave > 0)
            Detalle_Delitos_de_DocumentosData.push({
                Clave: removedDetalle_Delitos_de_DocumentosData[i].Clave

                ,Delito: removedDetalle_Delitos_de_DocumentosData[i].Delito

                , Removed: true
            });
    }	

    return Detalle_Delitos_de_DocumentosData;
}

function Detalle_Delitos_de_DocumentosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Delitos_de_DocumentosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Delitos_de_DocumentoscountRowsChecked++;
    var Detalle_Delitos_de_DocumentosRowElement = "Detalle_Delitos_de_Documentos_" + rowIndex.toString();
    var prevData = Detalle_Delitos_de_DocumentosTable.fnGetData(rowIndexTable );
    var row = Detalle_Delitos_de_DocumentosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Delitos_de_Documentos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Delitos_de_DocumentosGetUpdateRowControls(prevData, "Detalle_Delitos_de_Documentos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Delitos_de_DocumentosRowElement + "')){ Detalle_Delitos_de_DocumentosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Delitos_de_DocumentosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Delitos_de_DocumentosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Delitos_de_DocumentosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Delitos_de_DocumentosValidation();
    initiateUIControls();
    $('.Detalle_Delitos_de_Documentos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Delitos_de_DocumentosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Delitos_de_DocumentosTable.fnGetData().length;
    Detalle_Delitos_de_DocumentosfnClickAddRow();
    GetAddDetalle_Delitos_de_DocumentosPopup(currentRowIndex, 0);
}

function Detalle_Delitos_de_DocumentosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Delitos_de_DocumentosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Delitos_de_DocumentosRowElement = "Detalle_Delitos_de_Documentos_" + rowIndex.toString();
    var prevData = Detalle_Delitos_de_DocumentosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Delitos_de_DocumentosPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_Delitos_de_DocumentosDelito').html($($.parseHTML(GetGridAutoComplete(prevData.Delito.label,'AutoCompleteDelito'))).addClass('Detalle_Delitos_de_Documentos_Delito'));

    initiateUIControls();



}

function Detalle_Delitos_de_DocumentosAddInsertRow() {
    if (Detalle_Delitos_de_DocumentosinsertRowCurrentIndex < 1)
    {
        Detalle_Delitos_de_DocumentosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Delito: ""

    }
}

function Detalle_Delitos_de_DocumentosfnClickAddRow() {
    Detalle_Delitos_de_DocumentoscountRowsChecked++;
    Detalle_Delitos_de_DocumentosTable.fnAddData(Detalle_Delitos_de_DocumentosAddInsertRow(), true);
    Detalle_Delitos_de_DocumentosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Delitos_de_DocumentosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Delitos_de_DocumentosGrid tbody tr:nth-of-type(' + (Detalle_Delitos_de_DocumentosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Delitos_de_Documentos("Detalle_Delitos_de_Documentos_", "_" + Detalle_Delitos_de_DocumentosinsertRowCurrentIndex);
}

function Detalle_Delitos_de_DocumentosClearGridData() {
    Detalle_Delitos_de_DocumentosData = [];
    Detalle_Delitos_de_DocumentosdeletedItem = [];
    Detalle_Delitos_de_DocumentosDataMain = [];
    Detalle_Delitos_de_DocumentosDataMainPages = [];
    Detalle_Delitos_de_DocumentosnewItemCount = 0;
    Detalle_Delitos_de_DocumentosmaxItemIndex = 0;
    $("#Detalle_Delitos_de_DocumentosGrid").DataTable().clear();
    $("#Detalle_Delitos_de_DocumentosGrid").DataTable().destroy();
}

//Used to Get Documentos AT Information
function GetDetalle_Delitos_de_Documentos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Delitos_de_DocumentosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Delitos_de_DocumentosData[i].Clave);

        form_data.append('[' + i + '].Delito', Detalle_Delitos_de_DocumentosData[i].Delito);

        form_data.append('[' + i + '].Removed', Detalle_Delitos_de_DocumentosData[i].Removed);
    }
    return form_data;
}
function Detalle_Delitos_de_DocumentosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Delitos_de_Documentos("Detalle_Delitos_de_DocumentosTable", rowIndex)) {
    var prevData = Detalle_Delitos_de_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Delitos_de_DocumentosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Delito: $('#Detalle_Delitos_de_DocumentosDelito').val()

    }

    Detalle_Delitos_de_DocumentosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Delitos_de_DocumentosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Delitos_de_Documentos-form').modal({ show: false });
    $('#AddDetalle_Delitos_de_Documentos-form').modal('hide');
    Detalle_Delitos_de_DocumentosEditRow(rowIndex);
    Detalle_Delitos_de_DocumentosInsertRow(rowIndex);
    //}
}
function Detalle_Delitos_de_DocumentosRemoveAddRow(rowIndex) {
    Detalle_Delitos_de_DocumentosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Delitos_de_Documentos MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Indicios_de_Diligencia MultiRow
var Detalle_de_Indicios_de_DiligenciacountRowsChecked = 0;






function GetInsertDetalle_de_Indicios_de_DiligenciaRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Indicios_de_Diligencia_Indicio Indicio').attr('id', 'Detalle_de_Indicios_de_Diligencia_Indicio_' + index).attr('data-field', 'Indicio');
    columnData[1] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Indicios_de_Diligencia_Seleccionar Seleccionar').attr('id', 'Detalle_de_Indicios_de_Diligencia_Seleccionar_' + index).attr('data-field', 'Seleccionar');
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Indicios_de_Diligencia_IndicioId IndicioId').attr('id', 'Detalle_de_Indicios_de_Diligencia_IndicioId_' + index).attr('data-field', 'IndicioId');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Indicios_de_DiligenciaInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Indicios_de_Diligencia("Detalle_de_Indicios_de_Diligencia_", "_" + rowIndex)) {
    var iPage = Detalle_de_Indicios_de_DiligenciaTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Indicios_de_Diligencia';
    var prevData = Detalle_de_Indicios_de_DiligenciaTable.fnGetData(rowIndex);
    var data = Detalle_de_Indicios_de_DiligenciaTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Seleccionar: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,IndicioId: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Indicios_de_DiligenciaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Indicios_de_DiligenciarowCreationGrid(data, newData, rowIndex);
    Detalle_de_Indicios_de_DiligenciaTable.fnPageChange(iPage);
    Detalle_de_Indicios_de_DiligenciacountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Indicios_de_Diligencia("Detalle_de_Indicios_de_Diligencia_", "_" + rowIndex);
  }
}

function Detalle_de_Indicios_de_DiligenciaCancelRow(rowIndex) {
    var prevData = Detalle_de_Indicios_de_DiligenciaTable.fnGetData(rowIndex);
    var data = Detalle_de_Indicios_de_DiligenciaTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Indicios_de_DiligenciaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Indicios_de_DiligenciarowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Indicios_de_DiligenciaGrid(Detalle_de_Indicios_de_DiligenciaTable.fnGetData());
    Detalle_de_Indicios_de_DiligenciacountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Indicios_de_DiligenciaFromDataTable() {
    var Detalle_de_Indicios_de_DiligenciaData = [];
    var gridData = Detalle_de_Indicios_de_DiligenciaTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Indicios_de_DiligenciaData.push({
                Folio: gridData[i].Folio

                ,Indicio: gridData[i].Indicio
                ,Seleccionar: gridData[i].Seleccionar
                ,IndicioId: gridData[i].IndicioId

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Indicios_de_DiligenciaData.length; i++) {
        if (removedDetalle_de_Indicios_de_DiligenciaData[i] != null && removedDetalle_de_Indicios_de_DiligenciaData[i].Folio > 0)
            Detalle_de_Indicios_de_DiligenciaData.push({
                Folio: removedDetalle_de_Indicios_de_DiligenciaData[i].Folio

                ,Indicio: removedDetalle_de_Indicios_de_DiligenciaData[i].Indicio
                ,Seleccionar: removedDetalle_de_Indicios_de_DiligenciaData[i].Seleccionar
                ,IndicioId: removedDetalle_de_Indicios_de_DiligenciaData[i].IndicioId

                , Removed: true
            });
    }	

    return Detalle_de_Indicios_de_DiligenciaData;
}

function Detalle_de_Indicios_de_DiligenciaEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Indicios_de_DiligenciaTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Indicios_de_DiligenciacountRowsChecked++;
    var Detalle_de_Indicios_de_DiligenciaRowElement = "Detalle_de_Indicios_de_Diligencia_" + rowIndex.toString();
    var prevData = Detalle_de_Indicios_de_DiligenciaTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Indicios_de_DiligenciaTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Indicios_de_Diligencia_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Indicios_de_DiligenciaGetUpdateRowControls(prevData, "Detalle_de_Indicios_de_Diligencia_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Indicios_de_DiligenciaRowElement + "')){ Detalle_de_Indicios_de_DiligenciaInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Indicios_de_DiligenciaCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Indicios_de_DiligenciaGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Indicios_de_DiligenciaGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Indicios_de_DiligenciaValidation();
    initiateUIControls();
    $('.Detalle_de_Indicios_de_Diligencia' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Indicios_de_Diligencia(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Indicios_de_DiligenciafnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Indicios_de_DiligenciaTable.fnGetData().length;
    Detalle_de_Indicios_de_DiligenciafnClickAddRow();
    GetAddDetalle_de_Indicios_de_DiligenciaPopup(currentRowIndex, 0);
}

function Detalle_de_Indicios_de_DiligenciaEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Indicios_de_DiligenciaTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Indicios_de_DiligenciaRowElement = "Detalle_de_Indicios_de_Diligencia_" + rowIndex.toString();
    var prevData = Detalle_de_Indicios_de_DiligenciaTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Indicios_de_DiligenciaPopup(rowIndex, 1, prevData.Folio);

    $('#Detalle_de_Indicios_de_DiligenciaIndicio').val(prevData.Indicio);
    $('#Detalle_de_Indicios_de_DiligenciaSeleccionar').prop('checked', prevData.Seleccionar);
    $('#Detalle_de_Indicios_de_DiligenciaIndicioId').val(prevData.IndicioId);

    initiateUIControls();





}

function Detalle_de_Indicios_de_DiligenciaAddInsertRow() {
    if (Detalle_de_Indicios_de_DiligenciainsertRowCurrentIndex < 1)
    {
        Detalle_de_Indicios_de_DiligenciainsertRowCurrentIndex = 1;
    }
    return {
        Folio: null,
        IsInsertRow: true

        ,Indicio: ""
        ,Seleccionar: ""
        ,IndicioId: ""

    }
}

function Detalle_de_Indicios_de_DiligenciafnClickAddRow() {
    Detalle_de_Indicios_de_DiligenciacountRowsChecked++;
    Detalle_de_Indicios_de_DiligenciaTable.fnAddData(Detalle_de_Indicios_de_DiligenciaAddInsertRow(), true);
    Detalle_de_Indicios_de_DiligenciaTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Indicios_de_DiligenciaGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Indicios_de_DiligenciaGrid tbody tr:nth-of-type(' + (Detalle_de_Indicios_de_DiligenciainsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Indicios_de_Diligencia("Detalle_de_Indicios_de_Diligencia_", "_" + Detalle_de_Indicios_de_DiligenciainsertRowCurrentIndex);
}

function Detalle_de_Indicios_de_DiligenciaClearGridData() {
    Detalle_de_Indicios_de_DiligenciaData = [];
    Detalle_de_Indicios_de_DiligenciadeletedItem = [];
    Detalle_de_Indicios_de_DiligenciaDataMain = [];
    Detalle_de_Indicios_de_DiligenciaDataMainPages = [];
    Detalle_de_Indicios_de_DiligencianewItemCount = 0;
    Detalle_de_Indicios_de_DiligenciamaxItemIndex = 0;
    $("#Detalle_de_Indicios_de_DiligenciaGrid").DataTable().clear();
    $("#Detalle_de_Indicios_de_DiligenciaGrid").DataTable().destroy();
}

//Used to Get Documentos AT Information
function GetDetalle_de_Indicios_de_Diligencia() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Indicios_de_DiligenciaData.length; i++) {
        form_data.append('[' + i + '].Folio', Detalle_de_Indicios_de_DiligenciaData[i].Folio);

        form_data.append('[' + i + '].Indicio', Detalle_de_Indicios_de_DiligenciaData[i].Indicio);
        form_data.append('[' + i + '].Seleccionar', Detalle_de_Indicios_de_DiligenciaData[i].Seleccionar);
        form_data.append('[' + i + '].IndicioId', Detalle_de_Indicios_de_DiligenciaData[i].IndicioId);

        form_data.append('[' + i + '].Removed', Detalle_de_Indicios_de_DiligenciaData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Indicios_de_DiligenciaInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Indicios_de_Diligencia("Detalle_de_Indicios_de_DiligenciaTable", rowIndex)) {
    var prevData = Detalle_de_Indicios_de_DiligenciaTable.fnGetData(rowIndex);
    var data = Detalle_de_Indicios_de_DiligenciaTable.fnGetNodes(rowIndex);
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Indicio: $('#Detalle_de_Indicios_de_DiligenciaIndicio').val()
        ,Seleccionar: $('#Detalle_de_Indicios_de_DiligenciaSeleccionar').is(':checked')
        ,IndicioId: $('#Detalle_de_Indicios_de_DiligenciaIndicioId').val()


    }

    Detalle_de_Indicios_de_DiligenciaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Indicios_de_DiligenciarowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Indicios_de_Diligencia-form').modal({ show: false });
    $('#AddDetalle_de_Indicios_de_Diligencia-form').modal('hide');
    Detalle_de_Indicios_de_DiligenciaEditRow(rowIndex);
    Detalle_de_Indicios_de_DiligenciaInsertRow(rowIndex);
    //}
}
function Detalle_de_Indicios_de_DiligenciaRemoveAddRow(rowIndex) {
    Detalle_de_Indicios_de_DiligenciaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Indicios_de_Diligencia MultiRow


$(function () {
    function Detalle_Delitos_de_DocumentosinitializeMainArray(totalCount) {
        if (Detalle_Delitos_de_DocumentosDataMain.length != totalCount && !Detalle_Delitos_de_DocumentosDataMainInitialized) {
            Detalle_Delitos_de_DocumentosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Delitos_de_DocumentosDataMain[i] = null;
            }
        }
    }
    function Detalle_Delitos_de_DocumentosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Delitos_de_DocumentosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Delitos_de_DocumentosDataMain.length; i++) {
                if (Detalle_Delitos_de_DocumentosDataMain[i] != null && Detalle_Delitos_de_DocumentosDataMain[i].Id == Detalle_Delitos_de_DocumentosdeletedItem[j]) {
                    hDetalle_Delitos_de_DocumentosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Delitos_de_DocumentoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Delitos_de_DocumentosDataMain.length; i++) {
            data[i] = Detalle_Delitos_de_DocumentosDataMain[i];

        }
        return data;
    }
    function Detalle_Delitos_de_DocumentosgetNewResult() {
        var newData = copyMainDetalle_Delitos_de_DocumentosArray();

        for (var i = 0; i < Detalle_Delitos_de_DocumentosData.length; i++) {
            if (Detalle_Delitos_de_DocumentosData[i].Removed == null || Detalle_Delitos_de_DocumentosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Delitos_de_DocumentosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Delitos_de_DocumentospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Delitos_de_DocumentosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Delitos_de_DocumentosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Indicios_de_DiligenciainitializeMainArray(totalCount) {
        if (Detalle_de_Indicios_de_DiligenciaDataMain.length != totalCount && !Detalle_de_Indicios_de_DiligenciaDataMainInitialized) {
            Detalle_de_Indicios_de_DiligenciaDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Indicios_de_DiligenciaDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Indicios_de_DiligenciaremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Indicios_de_DiligenciadeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Indicios_de_DiligenciaDataMain.length; i++) {
                if (Detalle_de_Indicios_de_DiligenciaDataMain[i] != null && Detalle_de_Indicios_de_DiligenciaDataMain[i].Id == Detalle_de_Indicios_de_DiligenciadeletedItem[j]) {
                    hDetalle_de_Indicios_de_DiligenciaDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Indicios_de_DiligenciacopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Indicios_de_DiligenciaDataMain.length; i++) {
            data[i] = Detalle_de_Indicios_de_DiligenciaDataMain[i];

        }
        return data;
    }
    function Detalle_de_Indicios_de_DiligenciagetNewResult() {
        var newData = copyMainDetalle_de_Indicios_de_DiligenciaArray();

        for (var i = 0; i < Detalle_de_Indicios_de_DiligenciaData.length; i++) {
            if (Detalle_de_Indicios_de_DiligenciaData[i].Removed == null || Detalle_de_Indicios_de_DiligenciaData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Indicios_de_DiligenciaData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Indicios_de_DiligenciapushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Indicios_de_DiligenciaDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Indicios_de_DiligenciaDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteModulo_Atencion_InicialData = [];
function GetAutoCompleteDetalle_de_Documentos_MPO_Modulo_Atencion_Inicial_Modulo_Atencion_InicialData(data) {
	AutoCompleteModulo_Atencion_InicialData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteModulo_Atencion_InicialData.push({
            id: data[i].Clave,
            text: data[i].NUAT
        });
    }
    return AutoCompleteModulo_Atencion_InicialData;
}
var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompleteDetalle_de_Documentos_MPO_Usuario_que_Registra_Spartan_UserData(data) {
	AutoCompleteUsuario_que_RegistraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_RegistraData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_RegistraData;
}
var AutoCompleteDocumentoData = [];
function GetAutoCompleteDetalle_de_Documentos_MPO_Documento_DocumentoData(data) {
	AutoCompleteDocumentoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteDocumentoData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteDocumentoData;
}
var AutoCompleteInvolucradoData = [];
function GetAutoCompleteDetalle_de_Documentos_MPO_Involucrado_Detalle_de_Datos_GeneralesData(data) {
	AutoCompleteInvolucradoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteInvolucradoData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo_del_Tutor
        });
    }
    return AutoCompleteInvolucradoData;
}
var AutoCompleteProbable_ResponsableData = [];
function GetAutoCompleteDetalle_de_Documentos_MPO_Probable_Responsable_Detalle_de_ImputadoData(data) {
	AutoCompleteProbable_ResponsableData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteProbable_ResponsableData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo_Detenido
        });
    }
    return AutoCompleteProbable_ResponsableData;
}
//Grid GetAutocomplete
var AutoCompleteDelitoData = [];
function GetAutoCompleteDetalle_Delitos_de_Documentos_Delito_Detalle_de_DelitoData(data) {
	AutoCompleteDelitoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteDelitoData.push({
            id: data[i].Clave,
            text: data[i].Descripcion_corta
        });
    }
    return AutoCompleteDelitoData;
}

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Documentos_MPO_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Documentos_MPO')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Modulo_Atencion_Inicial').empty();
    $("#Modulo_Atencion_Inicial").append('<option value=""></option>');
    $('#Modulo_Atencion_Inicial').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
    $('#Documento').empty();
    $("#Documento").append('<option value=""></option>');
    $('#Documento').val('0').trigger('change');
    $('#Involucrado').empty();
    $("#Involucrado").append('<option value=""></option>');
    $('#Involucrado').val('0').trigger('change');
    $('#Probable_Responsable').empty();
    $("#Probable_Responsable").append('<option value=""></option>');
    $('#Probable_Responsable').val('0').trigger('change');
                Detalle_Delitos_de_DocumentosClearGridData();
                Detalle_de_Indicios_de_DiligenciaClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Documentos_MPO').trigger('reset');
    $('#CreateDetalle_de_Documentos_MPO').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Documentos_MPO');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Delitos_de_DocumentoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Delitos_de_Documentos();
        return false;
    }
    if (Detalle_de_Indicios_de_DiligenciacountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Indicios_de_Diligencia();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Documentos_MPO").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Documentos_MPO").on('click', '#Detalle_de_Documentos_MPOCancelar', function () {
	  if (!isPartial) {
        Detalle_de_Documentos_MPOBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Documentos_MPO").on('click', '#Detalle_de_Documentos_MPOGuardar', function () {
		$('#Detalle_de_Documentos_MPOGuardar').attr('disabled', true);
		$('#Detalle_de_Documentos_MPOGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_Documentos_MPOData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_Documentos_MPOBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_Documentos_MPOGuardar').removeAttr('disabled');
                        $('#Detalle_de_Documentos_MPOGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Documentos_MPO', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_Documentos_MPOItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Documentos_MPODropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Detalle_de_Documentos_MPOGuardar').removeAttr('disabled');
					$('#Detalle_de_Documentos_MPOGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_Documentos_MPOGuardar').removeAttr('disabled');
			$('#Detalle_de_Documentos_MPOGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Documentos_MPO").on('click', '#Detalle_de_Documentos_MPOGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_Documentos_MPOData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Delitos_de_DocumentosData();
                getDetalle_de_Indicios_de_DiligenciaData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Documentos_MPO', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Documentos_MPOItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Documentos_MPODropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Documentos_MPO").on('click', '#Detalle_de_Documentos_MPOGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_Documentos_MPOData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Modulo_Atencion_Inicial').empty();
    $("#Modulo_Atencion_Inicial").append('<option value=""></option>');
    $('#Modulo_Atencion_Inicial').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
    $('#Documento').empty();
    $("#Documento").append('<option value=""></option>');
    $('#Documento').val('0').trigger('change');
    $('#Involucrado').empty();
    $("#Involucrado").append('<option value=""></option>');
    $('#Involucrado').val('0').trigger('change');
    $('#Probable_Responsable').empty();
    $("#Probable_Responsable").append('<option value=""></option>');
    $('#Probable_Responsable').val('0').trigger('change');
                Detalle_Delitos_de_DocumentosClearGridData();
                Detalle_de_Indicios_de_DiligenciaClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Delitos_de_DocumentosData();
                getDetalle_de_Indicios_de_DiligenciaData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Documentos_MPO',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Documentos_MPOItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Documentos_MPODropDown().get(0)').innerHTML);                          
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



var Detalle_de_Documentos_MPOisdisplayBusinessPropery = false;
Detalle_de_Documentos_MPODisplayBusinessRuleButtons(Detalle_de_Documentos_MPOisdisplayBusinessPropery);
function Detalle_de_Documentos_MPODisplayBusinessRule() {
    if (!Detalle_de_Documentos_MPOisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Documentos_MPO').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_Documentos_MPOdisplayBusinessPropery"><button onclick="Detalle_de_Documentos_MPOGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_Documentos_MPOBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_Documentos_MPOdisplayBusinessPropery').remove();
    }
    Detalle_de_Documentos_MPODisplayBusinessRuleButtons(!Detalle_de_Documentos_MPOisdisplayBusinessPropery);
    Detalle_de_Documentos_MPOisdisplayBusinessPropery = (Detalle_de_Documentos_MPOisdisplayBusinessPropery ? false : true);
}
function Detalle_de_Documentos_MPODisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

