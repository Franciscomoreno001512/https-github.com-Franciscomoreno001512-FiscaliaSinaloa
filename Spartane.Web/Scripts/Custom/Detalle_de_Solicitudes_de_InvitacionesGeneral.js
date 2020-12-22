

//Begin Declarations for Foreigns fields for Detalle_de_Solicitante_en_Invitaciones MultiRow
var Detalle_de_Solicitante_en_InvitacionescountRowsChecked = 0;

function GetDetalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteName(Id) {
    for (var i = 0; i < Detalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteItems.length; i++) {
        if (Detalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteItems[i].Clave == Id) {
            return Detalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteItems[i].Nombre_Completo;
        }
    }
    return "";
}

function GetDetalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteDropDown() {
    var Detalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Solicitante_en_Invitaciones_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteDropdown);

    for (var i = 0; i < Detalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteItems.length; i++) {
        $('<option />', { value: Detalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteItems[i].Clave, text: Detalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteItems[i].Nombre_Completo }).appendTo(Detalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteDropdown);
    }
    return Detalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteDropdown;
}


function GetInsertDetalle_de_Solicitante_en_InvitacionesRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Solicitante_en_Invitaciones_Nombre'))).addClass('Detalle_de_Solicitante_en_Invitaciones_Nombre Nombre').attr('id', 'Detalle_de_Solicitante_en_Invitaciones_Nombre_' + index).attr('data-field', 'Nombre').after($.parseHTML(addNew('Detalle_de_Solicitante_en_Invitaciones', 'Detalle_de_Solicitud_Solicitante', 'Nombre', 263751)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_Solicitante_en_InvitacionesInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Invitaciones("Detalle_de_Solicitante_en_Invitaciones_", "_" + rowIndex)) {
    var iPage = Detalle_de_Solicitante_en_InvitacionesTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Solicitante_en_Invitaciones';
    var prevData = Detalle_de_Solicitante_en_InvitacionesTable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitante_en_InvitacionesTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , NombreNombre_Completo:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Nombre:  data.childNodes[counter++].childNodes[0].value 	

    }
    Detalle_de_Solicitante_en_InvitacionesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Solicitante_en_InvitacionesrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Solicitante_en_InvitacionesTable.fnPageChange(iPage);
    Detalle_de_Solicitante_en_InvitacionescountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_en_Invitaciones("Detalle_de_Solicitante_en_Invitaciones_", "_" + rowIndex);
  }
}

function Detalle_de_Solicitante_en_InvitacionesCancelRow(rowIndex) {
    var prevData = Detalle_de_Solicitante_en_InvitacionesTable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitante_en_InvitacionesTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Solicitante_en_InvitacionesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Solicitante_en_InvitacionesrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Solicitante_en_InvitacionesGrid(Detalle_de_Solicitante_en_InvitacionesTable.fnGetData());
    Detalle_de_Solicitante_en_InvitacionescountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Solicitante_en_InvitacionesFromDataTable() {
    var Detalle_de_Solicitante_en_InvitacionesData = [];
    var gridData = Detalle_de_Solicitante_en_InvitacionesTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Solicitante_en_InvitacionesData.push({
                Clave: gridData[i].Clave

                ,Nombre: gridData[i].Nombre

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Solicitante_en_InvitacionesData.length; i++) {
        if (removedDetalle_de_Solicitante_en_InvitacionesData[i] != null && removedDetalle_de_Solicitante_en_InvitacionesData[i].Clave > 0)
            Detalle_de_Solicitante_en_InvitacionesData.push({
                Clave: removedDetalle_de_Solicitante_en_InvitacionesData[i].Clave

                ,Nombre: removedDetalle_de_Solicitante_en_InvitacionesData[i].Nombre

                , Removed: true
            });
    }	

    return Detalle_de_Solicitante_en_InvitacionesData;
}

function Detalle_de_Solicitante_en_InvitacionesEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Solicitante_en_InvitacionesTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Solicitante_en_InvitacionescountRowsChecked++;
    var Detalle_de_Solicitante_en_InvitacionesRowElement = "Detalle_de_Solicitante_en_Invitaciones_" + rowIndex.toString();
    var prevData = Detalle_de_Solicitante_en_InvitacionesTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Solicitante_en_InvitacionesTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Solicitante_en_Invitaciones_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Solicitante_en_InvitacionesGetUpdateRowControls(prevData, "Detalle_de_Solicitante_en_Invitaciones_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Solicitante_en_InvitacionesRowElement + "')){ Detalle_de_Solicitante_en_InvitacionesInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Solicitante_en_InvitacionesCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Solicitante_en_InvitacionesGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Solicitante_en_InvitacionesGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Solicitante_en_InvitacionesValidation();
    initiateUIControls();
    $('.Detalle_de_Solicitante_en_Invitaciones' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Solicitante_en_InvitacionesfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Solicitante_en_InvitacionesTable.fnGetData().length;
    Detalle_de_Solicitante_en_InvitacionesfnClickAddRow();
    GetAddDetalle_de_Solicitante_en_InvitacionesPopup(currentRowIndex, 0);
}

function Detalle_de_Solicitante_en_InvitacionesEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Solicitante_en_InvitacionesTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Solicitante_en_InvitacionesRowElement = "Detalle_de_Solicitante_en_Invitaciones_" + rowIndex.toString();
    var prevData = Detalle_de_Solicitante_en_InvitacionesTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Solicitante_en_InvitacionesPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_de_Solicitante_en_InvitacionesNombre').html($($.parseHTML(GetGridAutoComplete(prevData.Nombre.label,'AutoCompleteNombre'))).addClass('Detalle_de_Solicitante_en_Invitaciones_Nombre'));

    initiateUIControls();



}

function Detalle_de_Solicitante_en_InvitacionesAddInsertRow() {
    if (Detalle_de_Solicitante_en_InvitacionesinsertRowCurrentIndex < 1)
    {
        Detalle_de_Solicitante_en_InvitacionesinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre: ""

    }
}

function Detalle_de_Solicitante_en_InvitacionesfnClickAddRow() {
    Detalle_de_Solicitante_en_InvitacionescountRowsChecked++;
    Detalle_de_Solicitante_en_InvitacionesTable.fnAddData(Detalle_de_Solicitante_en_InvitacionesAddInsertRow(), true);
    Detalle_de_Solicitante_en_InvitacionesTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Solicitante_en_InvitacionesGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Solicitante_en_InvitacionesGrid tbody tr:nth-of-type(' + (Detalle_de_Solicitante_en_InvitacionesinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Solicitante_en_Invitaciones("Detalle_de_Solicitante_en_Invitaciones_", "_" + Detalle_de_Solicitante_en_InvitacionesinsertRowCurrentIndex);
}

function Detalle_de_Solicitante_en_InvitacionesClearGridData() {
    Detalle_de_Solicitante_en_InvitacionesData = [];
    Detalle_de_Solicitante_en_InvitacionesdeletedItem = [];
    Detalle_de_Solicitante_en_InvitacionesDataMain = [];
    Detalle_de_Solicitante_en_InvitacionesDataMainPages = [];
    Detalle_de_Solicitante_en_InvitacionesnewItemCount = 0;
    Detalle_de_Solicitante_en_InvitacionesmaxItemIndex = 0;
    $("#Detalle_de_Solicitante_en_InvitacionesGrid").DataTable().clear();
    $("#Detalle_de_Solicitante_en_InvitacionesGrid").DataTable().destroy();
}

//Used to Get Invitaciones Information
function GetDetalle_de_Solicitante_en_Invitaciones() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Solicitante_en_InvitacionesData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Solicitante_en_InvitacionesData[i].Clave);

        form_data.append('[' + i + '].Nombre', Detalle_de_Solicitante_en_InvitacionesData[i].Nombre);

        form_data.append('[' + i + '].Removed', Detalle_de_Solicitante_en_InvitacionesData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Solicitante_en_InvitacionesInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Invitaciones("Detalle_de_Solicitante_en_InvitacionesTable", rowIndex)) {
    var prevData = Detalle_de_Solicitante_en_InvitacionesTable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitante_en_InvitacionesTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre: $('#Detalle_de_Solicitante_en_InvitacionesNombre').val()

    }

    Detalle_de_Solicitante_en_InvitacionesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Solicitante_en_InvitacionesrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Solicitante_en_Invitaciones-form').modal({ show: false });
    $('#AddDetalle_de_Solicitante_en_Invitaciones-form').modal('hide');
    Detalle_de_Solicitante_en_InvitacionesEditRow(rowIndex);
    Detalle_de_Solicitante_en_InvitacionesInsertRow(rowIndex);
    //}
}
function Detalle_de_Solicitante_en_InvitacionesRemoveAddRow(rowIndex) {
    Detalle_de_Solicitante_en_InvitacionesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Solicitante_en_Invitaciones MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Requerido_en_Invitaciones MultiRow
var Detalle_de_Requerido_en_InvitacionescountRowsChecked = 0;

function GetDetalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoName(Id) {
    for (var i = 0; i < Detalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoItems.length; i++) {
        if (Detalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoItems[i].Clave == Id) {
            return Detalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoItems[i].Nombre_Completo;
        }
    }
    return "";
}

function GetDetalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoDropDown() {
    var Detalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Requerido_en_Invitaciones_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoDropdown);

    for (var i = 0; i < Detalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoItems.length; i++) {
        $('<option />', { value: Detalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoItems[i].Clave, text: Detalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoItems[i].Nombre_Completo }).appendTo(Detalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoDropdown);
    }
    return Detalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoDropdown;
}


function GetInsertDetalle_de_Requerido_en_InvitacionesRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Requerido_en_Invitaciones_Nombre'))).addClass('Detalle_de_Requerido_en_Invitaciones_Nombre Nombre').attr('id', 'Detalle_de_Requerido_en_Invitaciones_Nombre_' + index).attr('data-field', 'Nombre').after($.parseHTML(addNew('Detalle_de_Requerido_en_Invitaciones', 'Detalle_de_Solicitud_Requerido', 'Nombre', 263747)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_Requerido_en_InvitacionesInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requerido_en_Invitaciones("Detalle_de_Requerido_en_Invitaciones_", "_" + rowIndex)) {
    var iPage = Detalle_de_Requerido_en_InvitacionesTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Requerido_en_Invitaciones';
    var prevData = Detalle_de_Requerido_en_InvitacionesTable.fnGetData(rowIndex);
    var data = Detalle_de_Requerido_en_InvitacionesTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , NombreNombre_Completo:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Nombre:  data.childNodes[counter++].childNodes[0].value 	

    }
    Detalle_de_Requerido_en_InvitacionesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Requerido_en_InvitacionesrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Requerido_en_InvitacionesTable.fnPageChange(iPage);
    Detalle_de_Requerido_en_InvitacionescountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Requerido_en_Invitaciones("Detalle_de_Requerido_en_Invitaciones_", "_" + rowIndex);
  }
}

function Detalle_de_Requerido_en_InvitacionesCancelRow(rowIndex) {
    var prevData = Detalle_de_Requerido_en_InvitacionesTable.fnGetData(rowIndex);
    var data = Detalle_de_Requerido_en_InvitacionesTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Requerido_en_InvitacionesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Requerido_en_InvitacionesrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Requerido_en_InvitacionesGrid(Detalle_de_Requerido_en_InvitacionesTable.fnGetData());
    Detalle_de_Requerido_en_InvitacionescountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Requerido_en_InvitacionesFromDataTable() {
    var Detalle_de_Requerido_en_InvitacionesData = [];
    var gridData = Detalle_de_Requerido_en_InvitacionesTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Requerido_en_InvitacionesData.push({
                Clave: gridData[i].Clave

                ,Nombre: gridData[i].Nombre

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Requerido_en_InvitacionesData.length; i++) {
        if (removedDetalle_de_Requerido_en_InvitacionesData[i] != null && removedDetalle_de_Requerido_en_InvitacionesData[i].Clave > 0)
            Detalle_de_Requerido_en_InvitacionesData.push({
                Clave: removedDetalle_de_Requerido_en_InvitacionesData[i].Clave

                ,Nombre: removedDetalle_de_Requerido_en_InvitacionesData[i].Nombre

                , Removed: true
            });
    }	

    return Detalle_de_Requerido_en_InvitacionesData;
}

function Detalle_de_Requerido_en_InvitacionesEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Requerido_en_InvitacionesTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Requerido_en_InvitacionescountRowsChecked++;
    var Detalle_de_Requerido_en_InvitacionesRowElement = "Detalle_de_Requerido_en_Invitaciones_" + rowIndex.toString();
    var prevData = Detalle_de_Requerido_en_InvitacionesTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Requerido_en_InvitacionesTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Requerido_en_Invitaciones_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Requerido_en_InvitacionesGetUpdateRowControls(prevData, "Detalle_de_Requerido_en_Invitaciones_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Requerido_en_InvitacionesRowElement + "')){ Detalle_de_Requerido_en_InvitacionesInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Requerido_en_InvitacionesCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Requerido_en_InvitacionesGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Requerido_en_InvitacionesGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Requerido_en_InvitacionesValidation();
    initiateUIControls();
    $('.Detalle_de_Requerido_en_Invitaciones' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Requerido_en_InvitacionesfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Requerido_en_InvitacionesTable.fnGetData().length;
    Detalle_de_Requerido_en_InvitacionesfnClickAddRow();
    GetAddDetalle_de_Requerido_en_InvitacionesPopup(currentRowIndex, 0);
}

function Detalle_de_Requerido_en_InvitacionesEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Requerido_en_InvitacionesTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Requerido_en_InvitacionesRowElement = "Detalle_de_Requerido_en_Invitaciones_" + rowIndex.toString();
    var prevData = Detalle_de_Requerido_en_InvitacionesTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Requerido_en_InvitacionesPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_de_Requerido_en_InvitacionesNombre').html($($.parseHTML(GetGridAutoComplete(prevData.Nombre.label,'AutoCompleteNombre'))).addClass('Detalle_de_Requerido_en_Invitaciones_Nombre'));

    initiateUIControls();



}

function Detalle_de_Requerido_en_InvitacionesAddInsertRow() {
    if (Detalle_de_Requerido_en_InvitacionesinsertRowCurrentIndex < 1)
    {
        Detalle_de_Requerido_en_InvitacionesinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre: ""

    }
}

function Detalle_de_Requerido_en_InvitacionesfnClickAddRow() {
    Detalle_de_Requerido_en_InvitacionescountRowsChecked++;
    Detalle_de_Requerido_en_InvitacionesTable.fnAddData(Detalle_de_Requerido_en_InvitacionesAddInsertRow(), true);
    Detalle_de_Requerido_en_InvitacionesTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Requerido_en_InvitacionesGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Requerido_en_InvitacionesGrid tbody tr:nth-of-type(' + (Detalle_de_Requerido_en_InvitacionesinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Requerido_en_Invitaciones("Detalle_de_Requerido_en_Invitaciones_", "_" + Detalle_de_Requerido_en_InvitacionesinsertRowCurrentIndex);
}

function Detalle_de_Requerido_en_InvitacionesClearGridData() {
    Detalle_de_Requerido_en_InvitacionesData = [];
    Detalle_de_Requerido_en_InvitacionesdeletedItem = [];
    Detalle_de_Requerido_en_InvitacionesDataMain = [];
    Detalle_de_Requerido_en_InvitacionesDataMainPages = [];
    Detalle_de_Requerido_en_InvitacionesnewItemCount = 0;
    Detalle_de_Requerido_en_InvitacionesmaxItemIndex = 0;
    $("#Detalle_de_Requerido_en_InvitacionesGrid").DataTable().clear();
    $("#Detalle_de_Requerido_en_InvitacionesGrid").DataTable().destroy();
}

//Used to Get Invitaciones Information
function GetDetalle_de_Requerido_en_Invitaciones() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Requerido_en_InvitacionesData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Requerido_en_InvitacionesData[i].Clave);

        form_data.append('[' + i + '].Nombre', Detalle_de_Requerido_en_InvitacionesData[i].Nombre);

        form_data.append('[' + i + '].Removed', Detalle_de_Requerido_en_InvitacionesData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Requerido_en_InvitacionesInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requerido_en_Invitaciones("Detalle_de_Requerido_en_InvitacionesTable", rowIndex)) {
    var prevData = Detalle_de_Requerido_en_InvitacionesTable.fnGetData(rowIndex);
    var data = Detalle_de_Requerido_en_InvitacionesTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre: $('#Detalle_de_Requerido_en_InvitacionesNombre').val()

    }

    Detalle_de_Requerido_en_InvitacionesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Requerido_en_InvitacionesrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Requerido_en_Invitaciones-form').modal({ show: false });
    $('#AddDetalle_de_Requerido_en_Invitaciones-form').modal('hide');
    Detalle_de_Requerido_en_InvitacionesEditRow(rowIndex);
    Detalle_de_Requerido_en_InvitacionesInsertRow(rowIndex);
    //}
}
function Detalle_de_Requerido_en_InvitacionesRemoveAddRow(rowIndex) {
    Detalle_de_Requerido_en_InvitacionesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Requerido_en_Invitaciones MultiRow


$(function () {
    function Detalle_de_Solicitante_en_InvitacionesinitializeMainArray(totalCount) {
        if (Detalle_de_Solicitante_en_InvitacionesDataMain.length != totalCount && !Detalle_de_Solicitante_en_InvitacionesDataMainInitialized) {
            Detalle_de_Solicitante_en_InvitacionesDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Solicitante_en_InvitacionesDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Solicitante_en_InvitacionesremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Solicitante_en_InvitacionesdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Solicitante_en_InvitacionesDataMain.length; i++) {
                if (Detalle_de_Solicitante_en_InvitacionesDataMain[i] != null && Detalle_de_Solicitante_en_InvitacionesDataMain[i].Id == Detalle_de_Solicitante_en_InvitacionesdeletedItem[j]) {
                    hDetalle_de_Solicitante_en_InvitacionesDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Solicitante_en_InvitacionescopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Solicitante_en_InvitacionesDataMain.length; i++) {
            data[i] = Detalle_de_Solicitante_en_InvitacionesDataMain[i];

        }
        return data;
    }
    function Detalle_de_Solicitante_en_InvitacionesgetNewResult() {
        var newData = copyMainDetalle_de_Solicitante_en_InvitacionesArray();

        for (var i = 0; i < Detalle_de_Solicitante_en_InvitacionesData.length; i++) {
            if (Detalle_de_Solicitante_en_InvitacionesData[i].Removed == null || Detalle_de_Solicitante_en_InvitacionesData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Solicitante_en_InvitacionesData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Solicitante_en_InvitacionespushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Solicitante_en_InvitacionesDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Solicitante_en_InvitacionesDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Requerido_en_InvitacionesinitializeMainArray(totalCount) {
        if (Detalle_de_Requerido_en_InvitacionesDataMain.length != totalCount && !Detalle_de_Requerido_en_InvitacionesDataMainInitialized) {
            Detalle_de_Requerido_en_InvitacionesDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Requerido_en_InvitacionesDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Requerido_en_InvitacionesremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Requerido_en_InvitacionesdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Requerido_en_InvitacionesDataMain.length; i++) {
                if (Detalle_de_Requerido_en_InvitacionesDataMain[i] != null && Detalle_de_Requerido_en_InvitacionesDataMain[i].Id == Detalle_de_Requerido_en_InvitacionesdeletedItem[j]) {
                    hDetalle_de_Requerido_en_InvitacionesDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Requerido_en_InvitacionescopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Requerido_en_InvitacionesDataMain.length; i++) {
            data[i] = Detalle_de_Requerido_en_InvitacionesDataMain[i];

        }
        return data;
    }
    function Detalle_de_Requerido_en_InvitacionesgetNewResult() {
        var newData = copyMainDetalle_de_Requerido_en_InvitacionesArray();

        for (var i = 0; i < Detalle_de_Requerido_en_InvitacionesData.length; i++) {
            if (Detalle_de_Requerido_en_InvitacionesData[i].Removed == null || Detalle_de_Requerido_en_InvitacionesData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Requerido_en_InvitacionesData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Requerido_en_InvitacionespushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Requerido_en_InvitacionesDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Requerido_en_InvitacionesDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteSolicitudData = [];
function GetAutoCompleteDetalle_de_Solicitudes_de_Invitaciones_Solicitud_SolicitudData(data) {
	AutoCompleteSolicitudData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteSolicitudData.push({
            id: data[i].Clave,
            text: data[i].Numero_de_Folio
        });
    }
    return AutoCompleteSolicitudData;
}
var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompleteDetalle_de_Solicitudes_de_Invitaciones_Usuario_que_Registra_Spartan_UserData(data) {
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
var AutoCompleteNombreData = [];
function GetAutoCompleteDetalle_de_Solicitante_en_Invitaciones_Nombre_Detalle_de_Solicitud_SolicitanteData(data) {
	AutoCompleteNombreData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNombreData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo
        });
    }
    return AutoCompleteNombreData;
}

//Grid GetAutocomplete
var AutoCompleteNombreData = [];
function GetAutoCompleteDetalle_de_Requerido_en_Invitaciones_Nombre_Detalle_de_Solicitud_RequeridoData(data) {
	AutoCompleteNombreData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNombreData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo
        });
    }
    return AutoCompleteNombreData;
}



function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Solicitudes_de_Invitaciones_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Solicitudes_de_Invitaciones')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Solicitud').empty();
    $("#Solicitud").append('<option value=""></option>');
    $('#Solicitud').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_de_Solicitante_en_InvitacionesClearGridData();
                Detalle_de_Requerido_en_InvitacionesClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Solicitudes_de_Invitaciones').trigger('reset');
    $('#CreateDetalle_de_Solicitudes_de_Invitaciones').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Solicitudes_de_Invitaciones');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Solicitante_en_InvitacionescountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Solicitante_en_Invitaciones();
        return false;
    }
    if (Detalle_de_Requerido_en_InvitacionescountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Requerido_en_Invitaciones();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Solicitudes_de_Invitaciones").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Solicitudes_de_Invitaciones").on('click', '#Detalle_de_Solicitudes_de_InvitacionesCancelar', function () {
	  if (!isPartial) {
        Detalle_de_Solicitudes_de_InvitacionesBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Solicitudes_de_Invitaciones").on('click', '#Detalle_de_Solicitudes_de_InvitacionesGuardar', function () {
		$('#Detalle_de_Solicitudes_de_InvitacionesGuardar').attr('disabled', true);
		$('#Detalle_de_Solicitudes_de_InvitacionesGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_Solicitudes_de_InvitacionesData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_Solicitudes_de_InvitacionesBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_Solicitudes_de_InvitacionesGuardar').removeAttr('disabled');
                        $('#Detalle_de_Solicitudes_de_InvitacionesGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Solicitudes_de_Invitaciones', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitudes_de_InvitacionesItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitudes_de_InvitacionesDropDown().get(0)').innerHTML);  
								}								
							}
                        }

                        RedireccionaX();

						window.close();						
						}
				})) {
					$('#Detalle_de_Solicitudes_de_InvitacionesGuardar').removeAttr('disabled');
					$('#Detalle_de_Solicitudes_de_InvitacionesGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_Solicitudes_de_InvitacionesGuardar').removeAttr('disabled');
			$('#Detalle_de_Solicitudes_de_InvitacionesGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Solicitudes_de_Invitaciones").on('click', '#Detalle_de_Solicitudes_de_InvitacionesGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_Solicitudes_de_InvitacionesData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Solicitante_en_InvitacionesData();
                getDetalle_de_Requerido_en_InvitacionesData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Solicitudes_de_Invitaciones', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitudes_de_InvitacionesItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitudes_de_InvitacionesDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Solicitudes_de_Invitaciones").on('click', '#Detalle_de_Solicitudes_de_InvitacionesGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_Solicitudes_de_InvitacionesData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Solicitud').empty();
    $("#Solicitud").append('<option value=""></option>');
    $('#Solicitud').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_de_Solicitante_en_InvitacionesClearGridData();
                Detalle_de_Requerido_en_InvitacionesClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_Solicitante_en_InvitacionesData();
                getDetalle_de_Requerido_en_InvitacionesData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Solicitudes_de_Invitaciones',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitudes_de_InvitacionesItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitudes_de_InvitacionesDropDown().get(0)').innerHTML);                          
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



var Detalle_de_Solicitudes_de_InvitacionesisdisplayBusinessPropery = false;
Detalle_de_Solicitudes_de_InvitacionesDisplayBusinessRuleButtons(Detalle_de_Solicitudes_de_InvitacionesisdisplayBusinessPropery);
function Detalle_de_Solicitudes_de_InvitacionesDisplayBusinessRule() {
    if (!Detalle_de_Solicitudes_de_InvitacionesisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Solicitudes_de_Invitaciones').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_Solicitudes_de_InvitacionesdisplayBusinessPropery"><button onclick="Detalle_de_Solicitudes_de_InvitacionesGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_Solicitudes_de_InvitacionesBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_Solicitudes_de_InvitacionesdisplayBusinessPropery').remove();
    }
    Detalle_de_Solicitudes_de_InvitacionesDisplayBusinessRuleButtons(!Detalle_de_Solicitudes_de_InvitacionesisdisplayBusinessPropery);
    Detalle_de_Solicitudes_de_InvitacionesisdisplayBusinessPropery = (Detalle_de_Solicitudes_de_InvitacionesisdisplayBusinessPropery ? false : true);
}
function Detalle_de_Solicitudes_de_InvitacionesDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

