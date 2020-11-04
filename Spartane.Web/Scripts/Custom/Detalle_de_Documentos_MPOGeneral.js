        function RemoveAttachmentMainArchivo_Adjunto () {
            $("#hdnRemoveArchivo_Adjunto").val("1");
            $("#divAttachmentArchivo_Adjunto").hide();
        }


//Begin Declarations for Foreigns fields for Detalle_Involucrados_en_Documentos MultiRow
var Detalle_Involucrados_en_DocumentoscountRowsChecked = 0;

function GetDetalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesName(Id) {
    for (var i = 0; i < Detalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesItems.length; i++) {
        if (Detalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesItems[i].Clave == Id) {
            return Detalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesItems[i].Nombre_Completo_del_Tutor;
        }
    }
    return "";
}

function GetDetalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesDropDown() {
    var Detalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Involucrados_en_Documentos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesDropdown);

    for (var i = 0; i < Detalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesItems.length; i++) {
        $('<option />', { value: Detalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesItems[i].Clave, text: Detalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesItems[i].Nombre_Completo_del_Tutor }).appendTo(Detalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesDropdown);
    }
    return Detalle_Involucrados_en_Documentos_Detalle_de_Datos_GeneralesDropdown;
}


function GetInsertDetalle_Involucrados_en_DocumentosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Involucrados_en_Documentos_Involucrado'))).addClass('Detalle_Involucrados_en_Documentos_Involucrado Involucrado').attr('id', 'Detalle_Involucrados_en_Documentos_Involucrado_' + index).attr('data-field', 'Involucrado').after($.parseHTML(addNew('Detalle_Involucrados_en_Documentos', 'Detalle_de_Datos_Generales', 'Involucrado', 266653)));


    initiateUIControls();
    return columnData;
}

function Detalle_Involucrados_en_DocumentosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Involucrados_en_Documentos("Detalle_Involucrados_en_Documentos_", "_" + rowIndex)) {
    var iPage = Detalle_Involucrados_en_DocumentosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Involucrados_en_Documentos';
    var prevData = Detalle_Involucrados_en_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Involucrados_en_DocumentosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , InvolucradoNombre_Completo_del_Tutor:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Involucrado:  data.childNodes[counter++].childNodes[0].value 	

    }
    Detalle_Involucrados_en_DocumentosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Involucrados_en_DocumentosrowCreationGrid(data, newData, rowIndex);
    Detalle_Involucrados_en_DocumentosTable.fnPageChange(iPage);
    Detalle_Involucrados_en_DocumentoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Involucrados_en_Documentos("Detalle_Involucrados_en_Documentos_", "_" + rowIndex);
  }
}

function Detalle_Involucrados_en_DocumentosCancelRow(rowIndex) {
    var prevData = Detalle_Involucrados_en_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Involucrados_en_DocumentosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Involucrados_en_DocumentosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Involucrados_en_DocumentosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Involucrados_en_DocumentosGrid(Detalle_Involucrados_en_DocumentosTable.fnGetData());
    Detalle_Involucrados_en_DocumentoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Involucrados_en_DocumentosFromDataTable() {
    var Detalle_Involucrados_en_DocumentosData = [];
    var gridData = Detalle_Involucrados_en_DocumentosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Involucrados_en_DocumentosData.push({
                Clave: gridData[i].Clave

                ,Involucrado: gridData[i].Involucrado

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Involucrados_en_DocumentosData.length; i++) {
        if (removedDetalle_Involucrados_en_DocumentosData[i] != null && removedDetalle_Involucrados_en_DocumentosData[i].Clave > 0)
            Detalle_Involucrados_en_DocumentosData.push({
                Clave: removedDetalle_Involucrados_en_DocumentosData[i].Clave

                ,Involucrado: removedDetalle_Involucrados_en_DocumentosData[i].Involucrado

                , Removed: true
            });
    }	

    return Detalle_Involucrados_en_DocumentosData;
}

function Detalle_Involucrados_en_DocumentosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Involucrados_en_DocumentosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Involucrados_en_DocumentoscountRowsChecked++;
    var Detalle_Involucrados_en_DocumentosRowElement = "Detalle_Involucrados_en_Documentos_" + rowIndex.toString();
    var prevData = Detalle_Involucrados_en_DocumentosTable.fnGetData(rowIndexTable );
    var row = Detalle_Involucrados_en_DocumentosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Involucrados_en_Documentos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Involucrados_en_DocumentosGetUpdateRowControls(prevData, "Detalle_Involucrados_en_Documentos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Involucrados_en_DocumentosRowElement + "')){ Detalle_Involucrados_en_DocumentosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Involucrados_en_DocumentosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Involucrados_en_DocumentosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Involucrados_en_DocumentosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Involucrados_en_DocumentosValidation();
    initiateUIControls();
    $('.Detalle_Involucrados_en_Documentos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Involucrados_en_DocumentosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Involucrados_en_DocumentosTable.fnGetData().length;
    Detalle_Involucrados_en_DocumentosfnClickAddRow();
    GetAddDetalle_Involucrados_en_DocumentosPopup(currentRowIndex, 0);
}

function Detalle_Involucrados_en_DocumentosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Involucrados_en_DocumentosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Involucrados_en_DocumentosRowElement = "Detalle_Involucrados_en_Documentos_" + rowIndex.toString();
    var prevData = Detalle_Involucrados_en_DocumentosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Involucrados_en_DocumentosPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_Involucrados_en_DocumentosInvolucrado').html($($.parseHTML(GetGridAutoComplete(prevData.Involucrado.label,'AutoCompleteInvolucrado'))).addClass('Detalle_Involucrados_en_Documentos_Involucrado'));

    initiateUIControls();



}

function Detalle_Involucrados_en_DocumentosAddInsertRow() {
    if (Detalle_Involucrados_en_DocumentosinsertRowCurrentIndex < 1)
    {
        Detalle_Involucrados_en_DocumentosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Involucrado: ""

    }
}

function Detalle_Involucrados_en_DocumentosfnClickAddRow() {
    Detalle_Involucrados_en_DocumentoscountRowsChecked++;
    Detalle_Involucrados_en_DocumentosTable.fnAddData(Detalle_Involucrados_en_DocumentosAddInsertRow(), true);
    Detalle_Involucrados_en_DocumentosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Involucrados_en_DocumentosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Involucrados_en_DocumentosGrid tbody tr:nth-of-type(' + (Detalle_Involucrados_en_DocumentosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Involucrados_en_Documentos("Detalle_Involucrados_en_Documentos_", "_" + Detalle_Involucrados_en_DocumentosinsertRowCurrentIndex);
}

function Detalle_Involucrados_en_DocumentosClearGridData() {
    Detalle_Involucrados_en_DocumentosData = [];
    Detalle_Involucrados_en_DocumentosdeletedItem = [];
    Detalle_Involucrados_en_DocumentosDataMain = [];
    Detalle_Involucrados_en_DocumentosDataMainPages = [];
    Detalle_Involucrados_en_DocumentosnewItemCount = 0;
    Detalle_Involucrados_en_DocumentosmaxItemIndex = 0;
    $("#Detalle_Involucrados_en_DocumentosGrid").DataTable().clear();
    $("#Detalle_Involucrados_en_DocumentosGrid").DataTable().destroy();
}

//Used to Get Documentos AT Information
function GetDetalle_Involucrados_en_Documentos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Involucrados_en_DocumentosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Involucrados_en_DocumentosData[i].Clave);

        form_data.append('[' + i + '].Involucrado', Detalle_Involucrados_en_DocumentosData[i].Involucrado);

        form_data.append('[' + i + '].Removed', Detalle_Involucrados_en_DocumentosData[i].Removed);
    }
    return form_data;
}
function Detalle_Involucrados_en_DocumentosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Involucrados_en_Documentos("Detalle_Involucrados_en_DocumentosTable", rowIndex)) {
    var prevData = Detalle_Involucrados_en_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Involucrados_en_DocumentosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Involucrado: $('#Detalle_Involucrados_en_DocumentosInvolucrado').val()

    }

    Detalle_Involucrados_en_DocumentosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Involucrados_en_DocumentosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Involucrados_en_Documentos-form').modal({ show: false });
    $('#AddDetalle_Involucrados_en_Documentos-form').modal('hide');
    Detalle_Involucrados_en_DocumentosEditRow(rowIndex);
    Detalle_Involucrados_en_DocumentosInsertRow(rowIndex);
    //}
}
function Detalle_Involucrados_en_DocumentosRemoveAddRow(rowIndex) {
    Detalle_Involucrados_en_DocumentosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Involucrados_en_Documentos MultiRow
//Begin Declarations for Foreigns fields for Detalle_Probable_Responsable_de_Documentos MultiRow
var Detalle_Probable_Responsable_de_DocumentoscountRowsChecked = 0;

function GetDetalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoName(Id) {
    for (var i = 0; i < Detalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoItems.length; i++) {
        if (Detalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoItems[i].Clave == Id) {
            return Detalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoItems[i].Nombre_Completo_del_Tutor;
        }
    }
    return "";
}

function GetDetalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoDropDown() {
    var Detalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Probable_Responsable_de_Documentos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoDropdown);

    for (var i = 0; i < Detalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoItems.length; i++) {
        $('<option />', { value: Detalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoItems[i].Clave, text: Detalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoItems[i].Nombre_Completo_del_Tutor }).appendTo(Detalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoDropdown);
    }
    return Detalle_Probable_Responsable_de_Documentos_Detalle_de_ImputadoDropdown;
}


function GetInsertDetalle_Probable_Responsable_de_DocumentosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Probable_Responsable_de_Documentos_Probable_Responsable'))).addClass('Detalle_Probable_Responsable_de_Documentos_Probable_Responsable Probable_Responsable').attr('id', 'Detalle_Probable_Responsable_de_Documentos_Probable_Responsable_' + index).attr('data-field', 'Probable_Responsable').after($.parseHTML(addNew('Detalle_Probable_Responsable_de_Documentos', 'Detalle_de_Imputado', 'Probable_Responsable', 266656)));


    initiateUIControls();
    return columnData;
}

function Detalle_Probable_Responsable_de_DocumentosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Probable_Responsable_de_Documentos("Detalle_Probable_Responsable_de_Documentos_", "_" + rowIndex)) {
    var iPage = Detalle_Probable_Responsable_de_DocumentosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Probable_Responsable_de_Documentos';
    var prevData = Detalle_Probable_Responsable_de_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Probable_Responsable_de_DocumentosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , Probable_ResponsableNombre_Completo_del_Tutor:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Probable_Responsable:  data.childNodes[counter++].childNodes[0].value 	

    }
    Detalle_Probable_Responsable_de_DocumentosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Probable_Responsable_de_DocumentosrowCreationGrid(data, newData, rowIndex);
    Detalle_Probable_Responsable_de_DocumentosTable.fnPageChange(iPage);
    Detalle_Probable_Responsable_de_DocumentoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Probable_Responsable_de_Documentos("Detalle_Probable_Responsable_de_Documentos_", "_" + rowIndex);
  }
}

function Detalle_Probable_Responsable_de_DocumentosCancelRow(rowIndex) {
    var prevData = Detalle_Probable_Responsable_de_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Probable_Responsable_de_DocumentosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Probable_Responsable_de_DocumentosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Probable_Responsable_de_DocumentosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Probable_Responsable_de_DocumentosGrid(Detalle_Probable_Responsable_de_DocumentosTable.fnGetData());
    Detalle_Probable_Responsable_de_DocumentoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Probable_Responsable_de_DocumentosFromDataTable() {
    var Detalle_Probable_Responsable_de_DocumentosData = [];
    var gridData = Detalle_Probable_Responsable_de_DocumentosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Probable_Responsable_de_DocumentosData.push({
                Clave: gridData[i].Clave

                ,Probable_Responsable: gridData[i].Probable_Responsable

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Probable_Responsable_de_DocumentosData.length; i++) {
        if (removedDetalle_Probable_Responsable_de_DocumentosData[i] != null && removedDetalle_Probable_Responsable_de_DocumentosData[i].Clave > 0)
            Detalle_Probable_Responsable_de_DocumentosData.push({
                Clave: removedDetalle_Probable_Responsable_de_DocumentosData[i].Clave

                ,Probable_Responsable: removedDetalle_Probable_Responsable_de_DocumentosData[i].Probable_Responsable

                , Removed: true
            });
    }	

    return Detalle_Probable_Responsable_de_DocumentosData;
}

function Detalle_Probable_Responsable_de_DocumentosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Probable_Responsable_de_DocumentosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Probable_Responsable_de_DocumentoscountRowsChecked++;
    var Detalle_Probable_Responsable_de_DocumentosRowElement = "Detalle_Probable_Responsable_de_Documentos_" + rowIndex.toString();
    var prevData = Detalle_Probable_Responsable_de_DocumentosTable.fnGetData(rowIndexTable );
    var row = Detalle_Probable_Responsable_de_DocumentosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Probable_Responsable_de_Documentos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Probable_Responsable_de_DocumentosGetUpdateRowControls(prevData, "Detalle_Probable_Responsable_de_Documentos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Probable_Responsable_de_DocumentosRowElement + "')){ Detalle_Probable_Responsable_de_DocumentosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Probable_Responsable_de_DocumentosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Probable_Responsable_de_DocumentosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Probable_Responsable_de_DocumentosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Probable_Responsable_de_DocumentosValidation();
    initiateUIControls();
    $('.Detalle_Probable_Responsable_de_Documentos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Probable_Responsable_de_DocumentosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Probable_Responsable_de_DocumentosTable.fnGetData().length;
    Detalle_Probable_Responsable_de_DocumentosfnClickAddRow();
    GetAddDetalle_Probable_Responsable_de_DocumentosPopup(currentRowIndex, 0);
}

function Detalle_Probable_Responsable_de_DocumentosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Probable_Responsable_de_DocumentosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Probable_Responsable_de_DocumentosRowElement = "Detalle_Probable_Responsable_de_Documentos_" + rowIndex.toString();
    var prevData = Detalle_Probable_Responsable_de_DocumentosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Probable_Responsable_de_DocumentosPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_Probable_Responsable_de_DocumentosProbable_Responsable').html($($.parseHTML(GetGridAutoComplete(prevData.Probable_Responsable.label,'AutoCompleteProbable_Responsable'))).addClass('Detalle_Probable_Responsable_de_Documentos_Probable_Responsable'));

    initiateUIControls();



}

function Detalle_Probable_Responsable_de_DocumentosAddInsertRow() {
    if (Detalle_Probable_Responsable_de_DocumentosinsertRowCurrentIndex < 1)
    {
        Detalle_Probable_Responsable_de_DocumentosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Probable_Responsable: ""

    }
}

function Detalle_Probable_Responsable_de_DocumentosfnClickAddRow() {
    Detalle_Probable_Responsable_de_DocumentoscountRowsChecked++;
    Detalle_Probable_Responsable_de_DocumentosTable.fnAddData(Detalle_Probable_Responsable_de_DocumentosAddInsertRow(), true);
    Detalle_Probable_Responsable_de_DocumentosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Probable_Responsable_de_DocumentosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Probable_Responsable_de_DocumentosGrid tbody tr:nth-of-type(' + (Detalle_Probable_Responsable_de_DocumentosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Probable_Responsable_de_Documentos("Detalle_Probable_Responsable_de_Documentos_", "_" + Detalle_Probable_Responsable_de_DocumentosinsertRowCurrentIndex);
}

function Detalle_Probable_Responsable_de_DocumentosClearGridData() {
    Detalle_Probable_Responsable_de_DocumentosData = [];
    Detalle_Probable_Responsable_de_DocumentosdeletedItem = [];
    Detalle_Probable_Responsable_de_DocumentosDataMain = [];
    Detalle_Probable_Responsable_de_DocumentosDataMainPages = [];
    Detalle_Probable_Responsable_de_DocumentosnewItemCount = 0;
    Detalle_Probable_Responsable_de_DocumentosmaxItemIndex = 0;
    $("#Detalle_Probable_Responsable_de_DocumentosGrid").DataTable().clear();
    $("#Detalle_Probable_Responsable_de_DocumentosGrid").DataTable().destroy();
}

//Used to Get Documentos AT Information
function GetDetalle_Probable_Responsable_de_Documentos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Probable_Responsable_de_DocumentosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Probable_Responsable_de_DocumentosData[i].Clave);

        form_data.append('[' + i + '].Probable_Responsable', Detalle_Probable_Responsable_de_DocumentosData[i].Probable_Responsable);

        form_data.append('[' + i + '].Removed', Detalle_Probable_Responsable_de_DocumentosData[i].Removed);
    }
    return form_data;
}
function Detalle_Probable_Responsable_de_DocumentosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Probable_Responsable_de_Documentos("Detalle_Probable_Responsable_de_DocumentosTable", rowIndex)) {
    var prevData = Detalle_Probable_Responsable_de_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Probable_Responsable_de_DocumentosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Probable_Responsable: $('#Detalle_Probable_Responsable_de_DocumentosProbable_Responsable').val()

    }

    Detalle_Probable_Responsable_de_DocumentosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Probable_Responsable_de_DocumentosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Probable_Responsable_de_Documentos-form').modal({ show: false });
    $('#AddDetalle_Probable_Responsable_de_Documentos-form').modal('hide');
    Detalle_Probable_Responsable_de_DocumentosEditRow(rowIndex);
    Detalle_Probable_Responsable_de_DocumentosInsertRow(rowIndex);
    //}
}
function Detalle_Probable_Responsable_de_DocumentosRemoveAddRow(rowIndex) {
    Detalle_Probable_Responsable_de_DocumentosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Probable_Responsable_de_Documentos MultiRow
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


$(function () {
    function Detalle_Involucrados_en_DocumentosinitializeMainArray(totalCount) {
        if (Detalle_Involucrados_en_DocumentosDataMain.length != totalCount && !Detalle_Involucrados_en_DocumentosDataMainInitialized) {
            Detalle_Involucrados_en_DocumentosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Involucrados_en_DocumentosDataMain[i] = null;
            }
        }
    }
    function Detalle_Involucrados_en_DocumentosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Involucrados_en_DocumentosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Involucrados_en_DocumentosDataMain.length; i++) {
                if (Detalle_Involucrados_en_DocumentosDataMain[i] != null && Detalle_Involucrados_en_DocumentosDataMain[i].Id == Detalle_Involucrados_en_DocumentosdeletedItem[j]) {
                    hDetalle_Involucrados_en_DocumentosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Involucrados_en_DocumentoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Involucrados_en_DocumentosDataMain.length; i++) {
            data[i] = Detalle_Involucrados_en_DocumentosDataMain[i];

        }
        return data;
    }
    function Detalle_Involucrados_en_DocumentosgetNewResult() {
        var newData = copyMainDetalle_Involucrados_en_DocumentosArray();

        for (var i = 0; i < Detalle_Involucrados_en_DocumentosData.length; i++) {
            if (Detalle_Involucrados_en_DocumentosData[i].Removed == null || Detalle_Involucrados_en_DocumentosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Involucrados_en_DocumentosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Involucrados_en_DocumentospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Involucrados_en_DocumentosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Involucrados_en_DocumentosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Probable_Responsable_de_DocumentosinitializeMainArray(totalCount) {
        if (Detalle_Probable_Responsable_de_DocumentosDataMain.length != totalCount && !Detalle_Probable_Responsable_de_DocumentosDataMainInitialized) {
            Detalle_Probable_Responsable_de_DocumentosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Probable_Responsable_de_DocumentosDataMain[i] = null;
            }
        }
    }
    function Detalle_Probable_Responsable_de_DocumentosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Probable_Responsable_de_DocumentosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Probable_Responsable_de_DocumentosDataMain.length; i++) {
                if (Detalle_Probable_Responsable_de_DocumentosDataMain[i] != null && Detalle_Probable_Responsable_de_DocumentosDataMain[i].Id == Detalle_Probable_Responsable_de_DocumentosdeletedItem[j]) {
                    hDetalle_Probable_Responsable_de_DocumentosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Probable_Responsable_de_DocumentoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Probable_Responsable_de_DocumentosDataMain.length; i++) {
            data[i] = Detalle_Probable_Responsable_de_DocumentosDataMain[i];

        }
        return data;
    }
    function Detalle_Probable_Responsable_de_DocumentosgetNewResult() {
        var newData = copyMainDetalle_Probable_Responsable_de_DocumentosArray();

        for (var i = 0; i < Detalle_Probable_Responsable_de_DocumentosData.length; i++) {
            if (Detalle_Probable_Responsable_de_DocumentosData[i].Removed == null || Detalle_Probable_Responsable_de_DocumentosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Probable_Responsable_de_DocumentosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Probable_Responsable_de_DocumentospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Probable_Responsable_de_DocumentosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Probable_Responsable_de_DocumentosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
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
//Grid GetAutocomplete
var AutoCompleteInvolucradoData = [];
function GetAutoCompleteDetalle_Involucrados_en_Documentos_Involucrado_Detalle_de_Datos_GeneralesData(data) {
	AutoCompleteInvolucradoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteInvolucradoData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo_del_Tutor
        });
    }
    return AutoCompleteInvolucradoData;
}

//Grid GetAutocomplete
var AutoCompleteProbable_ResponsableData = [];
function GetAutoCompleteDetalle_Probable_Responsable_de_Documentos_Probable_Responsable_Detalle_de_ImputadoData(data) {
	AutoCompleteProbable_ResponsableData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteProbable_ResponsableData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo_del_Tutor
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
                Detalle_Involucrados_en_DocumentosClearGridData();
                Detalle_Probable_Responsable_de_DocumentosClearGridData();
                Detalle_Delitos_de_DocumentosClearGridData();

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
    if (Detalle_Involucrados_en_DocumentoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Involucrados_en_Documentos();
        return false;
    }
    if (Detalle_Probable_Responsable_de_DocumentoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Probable_Responsable_de_Documentos();
        return false;
    }
    if (Detalle_Delitos_de_DocumentoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Delitos_de_Documentos();
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
	                getDetalle_Involucrados_en_DocumentosData();
                getDetalle_Probable_Responsable_de_DocumentosData();
                getDetalle_Delitos_de_DocumentosData();

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
                Detalle_Involucrados_en_DocumentosClearGridData();
                Detalle_Probable_Responsable_de_DocumentosClearGridData();
                Detalle_Delitos_de_DocumentosClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Involucrados_en_DocumentosData();
                getDetalle_Probable_Responsable_de_DocumentosData();
                getDetalle_Delitos_de_DocumentosData();

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

