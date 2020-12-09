        function RemoveAttachmentMainImagen_Tatuaje () {
            $("#hdnRemoveImagen_Tatuaje").val("1");
            $("#divAttachmentImagen_Tatuaje").hide();
        }


//Begin Declarations for Foreigns fields for Adicciones_de_Involucrado MultiRow
var Adicciones_de_InvolucradocountRowsChecked = 0;

function GetAdicciones_de_Involucrado_AdiccionesName(Id) {
    for (var i = 0; i < Adicciones_de_Involucrado_AdiccionesItems.length; i++) {
        if (Adicciones_de_Involucrado_AdiccionesItems[i].Clave == Id) {
            return Adicciones_de_Involucrado_AdiccionesItems[i].Descripcion;
        }
    }
    return "";
}

function GetAdicciones_de_Involucrado_AdiccionesDropDown() {
    var Adicciones_de_Involucrado_AdiccionesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Adicciones_de_Involucrado_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Adicciones_de_Involucrado_AdiccionesDropdown);
    if(Adicciones_de_Involucrado_AdiccionesItems != null)
    {
       for (var i = 0; i < Adicciones_de_Involucrado_AdiccionesItems.length; i++) {
           $('<option />', { value: Adicciones_de_Involucrado_AdiccionesItems[i].Clave, text:    Adicciones_de_Involucrado_AdiccionesItems[i].Descripcion }).appendTo(Adicciones_de_Involucrado_AdiccionesDropdown);
       }
    }
    return Adicciones_de_Involucrado_AdiccionesDropdown;
}


function GetInsertAdicciones_de_InvolucradoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetAdicciones_de_Involucrado_AdiccionesDropDown()).addClass('Adicciones_de_Involucrado_Descripcion Descripcion').attr('id', 'Adicciones_de_Involucrado_Descripcion_' + index).attr('data-field', 'Descripcion').after($.parseHTML(addNew('Adicciones_de_Involucrado', 'Adicciones', 'Descripcion', 265747)));


    initiateUIControls();
    return columnData;
}

function Adicciones_de_InvolucradoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRAdicciones_de_Involucrado("Adicciones_de_Involucrado_", "_" + rowIndex)) {
    var iPage = Adicciones_de_InvolucradoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Adicciones_de_Involucrado';
    var prevData = Adicciones_de_InvolucradoTable.fnGetData(rowIndex);
    var data = Adicciones_de_InvolucradoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Adicciones_de_InvolucradoTable.fnUpdate(newData, rowIndex, null, true);
    Adicciones_de_InvolucradorowCreationGrid(data, newData, rowIndex);
    Adicciones_de_InvolucradoTable.fnPageChange(iPage);
    Adicciones_de_InvolucradocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRAdicciones_de_Involucrado("Adicciones_de_Involucrado_", "_" + rowIndex);
  }
}

function Adicciones_de_InvolucradoCancelRow(rowIndex) {
    var prevData = Adicciones_de_InvolucradoTable.fnGetData(rowIndex);
    var data = Adicciones_de_InvolucradoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Adicciones_de_InvolucradoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Adicciones_de_InvolucradorowCreationGrid(data, prevData, rowIndex);
    }
	showAdicciones_de_InvolucradoGrid(Adicciones_de_InvolucradoTable.fnGetData());
    Adicciones_de_InvolucradocountRowsChecked--;
	initiateUIControls();
}

function GetAdicciones_de_InvolucradoFromDataTable() {
    var Adicciones_de_InvolucradoData = [];
    var gridData = Adicciones_de_InvolucradoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Adicciones_de_InvolucradoData.push({
                Clave: gridData[i].Clave

                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedAdicciones_de_InvolucradoData.length; i++) {
        if (removedAdicciones_de_InvolucradoData[i] != null && removedAdicciones_de_InvolucradoData[i].Clave > 0)
            Adicciones_de_InvolucradoData.push({
                Clave: removedAdicciones_de_InvolucradoData[i].Clave

                ,Descripcion: removedAdicciones_de_InvolucradoData[i].Descripcion

                , Removed: true
            });
    }	

    return Adicciones_de_InvolucradoData;
}

function Adicciones_de_InvolucradoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Adicciones_de_InvolucradoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Adicciones_de_InvolucradocountRowsChecked++;
    var Adicciones_de_InvolucradoRowElement = "Adicciones_de_Involucrado_" + rowIndex.toString();
    var prevData = Adicciones_de_InvolucradoTable.fnGetData(rowIndexTable );
    var row = Adicciones_de_InvolucradoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Adicciones_de_Involucrado_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Adicciones_de_InvolucradoGetUpdateRowControls(prevData, "Adicciones_de_Involucrado_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Adicciones_de_InvolucradoRowElement + "')){ Adicciones_de_InvolucradoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Adicciones_de_InvolucradoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Adicciones_de_InvolucradoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Adicciones_de_InvolucradoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setAdicciones_de_InvolucradoValidation();
    initiateUIControls();
    $('.Adicciones_de_Involucrado' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRAdicciones_de_Involucrado(nameOfTable, rowIndexFormed);
    }
}

function Adicciones_de_InvolucradofnOpenAddRowPopUp() {
    var currentRowIndex = Adicciones_de_InvolucradoTable.fnGetData().length;
    Adicciones_de_InvolucradofnClickAddRow();
    GetAddAdicciones_de_InvolucradoPopup(currentRowIndex, 0);
}

function Adicciones_de_InvolucradoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Adicciones_de_InvolucradoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Adicciones_de_InvolucradoRowElement = "Adicciones_de_Involucrado_" + rowIndex.toString();
    var prevData = Adicciones_de_InvolucradoTable.fnGetData(rowIndexTable);
    GetAddAdicciones_de_InvolucradoPopup(rowIndex, 1, prevData.Clave);

    $('#Adicciones_de_InvolucradoDescripcion').val(prevData.Descripcion);

    initiateUIControls();



}

function Adicciones_de_InvolucradoAddInsertRow() {
    if (Adicciones_de_InvolucradoinsertRowCurrentIndex < 1)
    {
        Adicciones_de_InvolucradoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Descripcion: ""

    }
}

function Adicciones_de_InvolucradofnClickAddRow() {
    Adicciones_de_InvolucradocountRowsChecked++;
    Adicciones_de_InvolucradoTable.fnAddData(Adicciones_de_InvolucradoAddInsertRow(), true);
    Adicciones_de_InvolucradoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Adicciones_de_InvolucradoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Adicciones_de_InvolucradoGrid tbody tr:nth-of-type(' + (Adicciones_de_InvolucradoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRAdicciones_de_Involucrado("Adicciones_de_Involucrado_", "_" + Adicciones_de_InvolucradoinsertRowCurrentIndex);
}

function Adicciones_de_InvolucradoClearGridData() {
    Adicciones_de_InvolucradoData = [];
    Adicciones_de_InvolucradodeletedItem = [];
    Adicciones_de_InvolucradoDataMain = [];
    Adicciones_de_InvolucradoDataMainPages = [];
    Adicciones_de_InvolucradonewItemCount = 0;
    Adicciones_de_InvolucradomaxItemIndex = 0;
    $("#Adicciones_de_InvolucradoGrid").DataTable().clear();
    $("#Adicciones_de_InvolucradoGrid").DataTable().destroy();
}

//Used to Get Involucrados AT Information
function GetAdicciones_de_Involucrado() {
    var form_data = new FormData();
    for (var i = 0; i < Adicciones_de_InvolucradoData.length; i++) {
        form_data.append('[' + i + '].Clave', Adicciones_de_InvolucradoData[i].Clave);

        form_data.append('[' + i + '].Descripcion', Adicciones_de_InvolucradoData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Adicciones_de_InvolucradoData[i].Removed);
    }
    return form_data;
}
function Adicciones_de_InvolucradoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRAdicciones_de_Involucrado("Adicciones_de_InvolucradoTable", rowIndex)) {
    var prevData = Adicciones_de_InvolucradoTable.fnGetData(rowIndex);
    var data = Adicciones_de_InvolucradoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion: $('#Adicciones_de_InvolucradoDescripcion').val()

    }

    Adicciones_de_InvolucradoTable.fnUpdate(newData, rowIndex, null, true);
    Adicciones_de_InvolucradorowCreationGrid(data, newData, rowIndex);
    $('#AddAdicciones_de_Involucrado-form').modal({ show: false });
    $('#AddAdicciones_de_Involucrado-form').modal('hide');
    Adicciones_de_InvolucradoEditRow(rowIndex);
    Adicciones_de_InvolucradoInsertRow(rowIndex);
    //}
}
function Adicciones_de_InvolucradoRemoveAddRow(rowIndex) {
    Adicciones_de_InvolucradoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Adicciones_de_Involucrado MultiRow
//Begin Declarations for Foreigns fields for Lugares_Frecuentes_Involucrado MultiRow
var Lugares_Frecuentes_InvolucradocountRowsChecked = 0;

function GetLugares_Frecuentes_Involucrado_LugaresName(Id) {
    for (var i = 0; i < Lugares_Frecuentes_Involucrado_LugaresItems.length; i++) {
        if (Lugares_Frecuentes_Involucrado_LugaresItems[i].Clave == Id) {
            return Lugares_Frecuentes_Involucrado_LugaresItems[i].Descripcion;
        }
    }
    return "";
}

function GetLugares_Frecuentes_Involucrado_LugaresDropDown() {
    var Lugares_Frecuentes_Involucrado_LugaresDropdown = $('<select class="form-control" />');      var labelSelect = $("#Lugares_Frecuentes_Involucrado_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Lugares_Frecuentes_Involucrado_LugaresDropdown);
    if(Lugares_Frecuentes_Involucrado_LugaresItems != null)
    {
       for (var i = 0; i < Lugares_Frecuentes_Involucrado_LugaresItems.length; i++) {
           $('<option />', { value: Lugares_Frecuentes_Involucrado_LugaresItems[i].Clave, text:    Lugares_Frecuentes_Involucrado_LugaresItems[i].Descripcion }).appendTo(Lugares_Frecuentes_Involucrado_LugaresDropdown);
       }
    }
    return Lugares_Frecuentes_Involucrado_LugaresDropdown;
}



function GetInsertLugares_Frecuentes_InvolucradoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetLugares_Frecuentes_Involucrado_LugaresDropDown()).addClass('Lugares_Frecuentes_Involucrado_Tipo_de_Lugar Tipo_de_Lugar').attr('id', 'Lugares_Frecuentes_Involucrado_Tipo_de_Lugar_' + index).attr('data-field', 'Tipo_de_Lugar').after($.parseHTML(addNew('Lugares_Frecuentes_Involucrado', 'Lugares', 'Tipo_de_Lugar', 265743)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Lugares_Frecuentes_Involucrado_Descripcion Descripcion').attr('id', 'Lugares_Frecuentes_Involucrado_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Lugares_Frecuentes_InvolucradoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRLugares_Frecuentes_Involucrado("Lugares_Frecuentes_Involucrado_", "_" + rowIndex)) {
    var iPage = Lugares_Frecuentes_InvolucradoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Lugares_Frecuentes_Involucrado';
    var prevData = Lugares_Frecuentes_InvolucradoTable.fnGetData(rowIndex);
    var data = Lugares_Frecuentes_InvolucradoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Lugar:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Lugares_Frecuentes_InvolucradoTable.fnUpdate(newData, rowIndex, null, true);
    Lugares_Frecuentes_InvolucradorowCreationGrid(data, newData, rowIndex);
    Lugares_Frecuentes_InvolucradoTable.fnPageChange(iPage);
    Lugares_Frecuentes_InvolucradocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRLugares_Frecuentes_Involucrado("Lugares_Frecuentes_Involucrado_", "_" + rowIndex);
  }
}

function Lugares_Frecuentes_InvolucradoCancelRow(rowIndex) {
    var prevData = Lugares_Frecuentes_InvolucradoTable.fnGetData(rowIndex);
    var data = Lugares_Frecuentes_InvolucradoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Lugares_Frecuentes_InvolucradoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Lugares_Frecuentes_InvolucradorowCreationGrid(data, prevData, rowIndex);
    }
	showLugares_Frecuentes_InvolucradoGrid(Lugares_Frecuentes_InvolucradoTable.fnGetData());
    Lugares_Frecuentes_InvolucradocountRowsChecked--;
	initiateUIControls();
}

function GetLugares_Frecuentes_InvolucradoFromDataTable() {
    var Lugares_Frecuentes_InvolucradoData = [];
    var gridData = Lugares_Frecuentes_InvolucradoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Lugares_Frecuentes_InvolucradoData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Lugar: gridData[i].Tipo_de_Lugar
                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedLugares_Frecuentes_InvolucradoData.length; i++) {
        if (removedLugares_Frecuentes_InvolucradoData[i] != null && removedLugares_Frecuentes_InvolucradoData[i].Clave > 0)
            Lugares_Frecuentes_InvolucradoData.push({
                Clave: removedLugares_Frecuentes_InvolucradoData[i].Clave

                ,Tipo_de_Lugar: removedLugares_Frecuentes_InvolucradoData[i].Tipo_de_Lugar
                ,Descripcion: removedLugares_Frecuentes_InvolucradoData[i].Descripcion

                , Removed: true
            });
    }	

    return Lugares_Frecuentes_InvolucradoData;
}

function Lugares_Frecuentes_InvolucradoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Lugares_Frecuentes_InvolucradoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Lugares_Frecuentes_InvolucradocountRowsChecked++;
    var Lugares_Frecuentes_InvolucradoRowElement = "Lugares_Frecuentes_Involucrado_" + rowIndex.toString();
    var prevData = Lugares_Frecuentes_InvolucradoTable.fnGetData(rowIndexTable );
    var row = Lugares_Frecuentes_InvolucradoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Lugares_Frecuentes_Involucrado_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Lugares_Frecuentes_InvolucradoGetUpdateRowControls(prevData, "Lugares_Frecuentes_Involucrado_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Lugares_Frecuentes_InvolucradoRowElement + "')){ Lugares_Frecuentes_InvolucradoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Lugares_Frecuentes_InvolucradoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Lugares_Frecuentes_InvolucradoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Lugares_Frecuentes_InvolucradoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setLugares_Frecuentes_InvolucradoValidation();
    initiateUIControls();
    $('.Lugares_Frecuentes_Involucrado' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRLugares_Frecuentes_Involucrado(nameOfTable, rowIndexFormed);
    }
}

function Lugares_Frecuentes_InvolucradofnOpenAddRowPopUp() {
    var currentRowIndex = Lugares_Frecuentes_InvolucradoTable.fnGetData().length;
    Lugares_Frecuentes_InvolucradofnClickAddRow();
    GetAddLugares_Frecuentes_InvolucradoPopup(currentRowIndex, 0);
}

function Lugares_Frecuentes_InvolucradoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Lugares_Frecuentes_InvolucradoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Lugares_Frecuentes_InvolucradoRowElement = "Lugares_Frecuentes_Involucrado_" + rowIndex.toString();
    var prevData = Lugares_Frecuentes_InvolucradoTable.fnGetData(rowIndexTable);
    GetAddLugares_Frecuentes_InvolucradoPopup(rowIndex, 1, prevData.Clave);

    $('#Lugares_Frecuentes_InvolucradoTipo_de_Lugar').val(prevData.Tipo_de_Lugar);
    $('#Lugares_Frecuentes_InvolucradoDescripcion').val(prevData.Descripcion);

    initiateUIControls();




}

function Lugares_Frecuentes_InvolucradoAddInsertRow() {
    if (Lugares_Frecuentes_InvolucradoinsertRowCurrentIndex < 1)
    {
        Lugares_Frecuentes_InvolucradoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Lugar: ""
        ,Descripcion: ""

    }
}

function Lugares_Frecuentes_InvolucradofnClickAddRow() {
    Lugares_Frecuentes_InvolucradocountRowsChecked++;
    Lugares_Frecuentes_InvolucradoTable.fnAddData(Lugares_Frecuentes_InvolucradoAddInsertRow(), true);
    Lugares_Frecuentes_InvolucradoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Lugares_Frecuentes_InvolucradoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Lugares_Frecuentes_InvolucradoGrid tbody tr:nth-of-type(' + (Lugares_Frecuentes_InvolucradoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRLugares_Frecuentes_Involucrado("Lugares_Frecuentes_Involucrado_", "_" + Lugares_Frecuentes_InvolucradoinsertRowCurrentIndex);
}

function Lugares_Frecuentes_InvolucradoClearGridData() {
    Lugares_Frecuentes_InvolucradoData = [];
    Lugares_Frecuentes_InvolucradodeletedItem = [];
    Lugares_Frecuentes_InvolucradoDataMain = [];
    Lugares_Frecuentes_InvolucradoDataMainPages = [];
    Lugares_Frecuentes_InvolucradonewItemCount = 0;
    Lugares_Frecuentes_InvolucradomaxItemIndex = 0;
    $("#Lugares_Frecuentes_InvolucradoGrid").DataTable().clear();
    $("#Lugares_Frecuentes_InvolucradoGrid").DataTable().destroy();
}

//Used to Get Involucrados AT Information
function GetLugares_Frecuentes_Involucrado() {
    var form_data = new FormData();
    for (var i = 0; i < Lugares_Frecuentes_InvolucradoData.length; i++) {
        form_data.append('[' + i + '].Clave', Lugares_Frecuentes_InvolucradoData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Lugar', Lugares_Frecuentes_InvolucradoData[i].Tipo_de_Lugar);
        form_data.append('[' + i + '].Descripcion', Lugares_Frecuentes_InvolucradoData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Lugares_Frecuentes_InvolucradoData[i].Removed);
    }
    return form_data;
}
function Lugares_Frecuentes_InvolucradoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRLugares_Frecuentes_Involucrado("Lugares_Frecuentes_InvolucradoTable", rowIndex)) {
    var prevData = Lugares_Frecuentes_InvolucradoTable.fnGetData(rowIndex);
    var data = Lugares_Frecuentes_InvolucradoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Lugar: $('#Lugares_Frecuentes_InvolucradoTipo_de_Lugar').val()
        ,Descripcion: $('#Lugares_Frecuentes_InvolucradoDescripcion').val()

    }

    Lugares_Frecuentes_InvolucradoTable.fnUpdate(newData, rowIndex, null, true);
    Lugares_Frecuentes_InvolucradorowCreationGrid(data, newData, rowIndex);
    $('#AddLugares_Frecuentes_Involucrado-form').modal({ show: false });
    $('#AddLugares_Frecuentes_Involucrado-form').modal('hide');
    Lugares_Frecuentes_InvolucradoEditRow(rowIndex);
    Lugares_Frecuentes_InvolucradoInsertRow(rowIndex);
    //}
}
function Lugares_Frecuentes_InvolucradoRemoveAddRow(rowIndex) {
    Lugares_Frecuentes_InvolucradoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Lugares_Frecuentes_Involucrado MultiRow
//Begin Declarations for Foreigns fields for Datos_Personales_Adicionales_Involucrado MultiRow
var Datos_Personales_Adicionales_InvolucradocountRowsChecked = 0;



function GetDatos_Personales_Adicionales_Involucrado_Redes_SocialesName(Id) {
    for (var i = 0; i < Datos_Personales_Adicionales_Involucrado_Redes_SocialesItems.length; i++) {
        if (Datos_Personales_Adicionales_Involucrado_Redes_SocialesItems[i].Clave == Id) {
            return Datos_Personales_Adicionales_Involucrado_Redes_SocialesItems[i].Descripcion;
        }
    }
    return "";
}

function GetDatos_Personales_Adicionales_Involucrado_Redes_SocialesDropDown() {
    var Datos_Personales_Adicionales_Involucrado_Redes_SocialesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Datos_Personales_Adicionales_Involucrado_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Datos_Personales_Adicionales_Involucrado_Redes_SocialesDropdown);
    if(Datos_Personales_Adicionales_Involucrado_Redes_SocialesItems != null)
    {
       for (var i = 0; i < Datos_Personales_Adicionales_Involucrado_Redes_SocialesItems.length; i++) {
           $('<option />', { value: Datos_Personales_Adicionales_Involucrado_Redes_SocialesItems[i].Clave, text:    Datos_Personales_Adicionales_Involucrado_Redes_SocialesItems[i].Descripcion }).appendTo(Datos_Personales_Adicionales_Involucrado_Redes_SocialesDropdown);
       }
    }
    return Datos_Personales_Adicionales_Involucrado_Redes_SocialesDropdown;
}



function GetInsertDatos_Personales_Adicionales_InvolucradoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Datos_Personales_Adicionales_Involucrado_Correo_Electronico Correo_Electronico').attr('id', 'Datos_Personales_Adicionales_Involucrado_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');
    columnData[1] = $($.parseHTML(inputData)).addClass('Datos_Personales_Adicionales_Involucrado_Numero_Telefonico Numero_Telefonico').attr('id', 'Datos_Personales_Adicionales_Involucrado_Numero_Telefonico_' + index).attr('data-field', 'Numero_Telefonico');
    columnData[2] = $(GetDatos_Personales_Adicionales_Involucrado_Redes_SocialesDropDown()).addClass('Datos_Personales_Adicionales_Involucrado_Redes_Sociales Redes_Sociales').attr('id', 'Datos_Personales_Adicionales_Involucrado_Redes_Sociales_' + index).attr('data-field', 'Redes_Sociales').after($.parseHTML(addNew('Datos_Personales_Adicionales_Involucrado', 'Redes_Sociales', 'Redes_Sociales', 265739)));
    columnData[3] = $($.parseHTML(inputData)).addClass('Datos_Personales_Adicionales_Involucrado_Observaciones Observaciones').attr('id', 'Datos_Personales_Adicionales_Involucrado_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Datos_Personales_Adicionales_InvolucradoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDatos_Personales_Adicionales_Involucrado("Datos_Personales_Adicionales_Involucrado_", "_" + rowIndex)) {
    var iPage = Datos_Personales_Adicionales_InvolucradoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Datos_Personales_Adicionales_Involucrado';
    var prevData = Datos_Personales_Adicionales_InvolucradoTable.fnGetData(rowIndex);
    var data = Datos_Personales_Adicionales_InvolucradoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Telefonico:  data.childNodes[counter++].childNodes[0].value
        ,Redes_Sociales:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Datos_Personales_Adicionales_InvolucradoTable.fnUpdate(newData, rowIndex, null, true);
    Datos_Personales_Adicionales_InvolucradorowCreationGrid(data, newData, rowIndex);
    Datos_Personales_Adicionales_InvolucradoTable.fnPageChange(iPage);
    Datos_Personales_Adicionales_InvolucradocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDatos_Personales_Adicionales_Involucrado("Datos_Personales_Adicionales_Involucrado_", "_" + rowIndex);
  }
}

function Datos_Personales_Adicionales_InvolucradoCancelRow(rowIndex) {
    var prevData = Datos_Personales_Adicionales_InvolucradoTable.fnGetData(rowIndex);
    var data = Datos_Personales_Adicionales_InvolucradoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Datos_Personales_Adicionales_InvolucradoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Datos_Personales_Adicionales_InvolucradorowCreationGrid(data, prevData, rowIndex);
    }
	showDatos_Personales_Adicionales_InvolucradoGrid(Datos_Personales_Adicionales_InvolucradoTable.fnGetData());
    Datos_Personales_Adicionales_InvolucradocountRowsChecked--;
	initiateUIControls();
}

function GetDatos_Personales_Adicionales_InvolucradoFromDataTable() {
    var Datos_Personales_Adicionales_InvolucradoData = [];
    var gridData = Datos_Personales_Adicionales_InvolucradoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Datos_Personales_Adicionales_InvolucradoData.push({
                Clave: gridData[i].Clave

                ,Correo_Electronico: gridData[i].Correo_Electronico
                ,Numero_Telefonico: gridData[i].Numero_Telefonico
                ,Redes_Sociales: gridData[i].Redes_Sociales
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDatos_Personales_Adicionales_InvolucradoData.length; i++) {
        if (removedDatos_Personales_Adicionales_InvolucradoData[i] != null && removedDatos_Personales_Adicionales_InvolucradoData[i].Clave > 0)
            Datos_Personales_Adicionales_InvolucradoData.push({
                Clave: removedDatos_Personales_Adicionales_InvolucradoData[i].Clave

                ,Correo_Electronico: removedDatos_Personales_Adicionales_InvolucradoData[i].Correo_Electronico
                ,Numero_Telefonico: removedDatos_Personales_Adicionales_InvolucradoData[i].Numero_Telefonico
                ,Redes_Sociales: removedDatos_Personales_Adicionales_InvolucradoData[i].Redes_Sociales
                ,Observaciones: removedDatos_Personales_Adicionales_InvolucradoData[i].Observaciones

                , Removed: true
            });
    }	

    return Datos_Personales_Adicionales_InvolucradoData;
}

function Datos_Personales_Adicionales_InvolucradoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Datos_Personales_Adicionales_InvolucradoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Datos_Personales_Adicionales_InvolucradocountRowsChecked++;
    var Datos_Personales_Adicionales_InvolucradoRowElement = "Datos_Personales_Adicionales_Involucrado_" + rowIndex.toString();
    var prevData = Datos_Personales_Adicionales_InvolucradoTable.fnGetData(rowIndexTable );
    var row = Datos_Personales_Adicionales_InvolucradoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Datos_Personales_Adicionales_Involucrado_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Datos_Personales_Adicionales_InvolucradoGetUpdateRowControls(prevData, "Datos_Personales_Adicionales_Involucrado_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Datos_Personales_Adicionales_InvolucradoRowElement + "')){ Datos_Personales_Adicionales_InvolucradoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Datos_Personales_Adicionales_InvolucradoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Datos_Personales_Adicionales_InvolucradoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Datos_Personales_Adicionales_InvolucradoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDatos_Personales_Adicionales_InvolucradoValidation();
    initiateUIControls();
    $('.Datos_Personales_Adicionales_Involucrado' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDatos_Personales_Adicionales_Involucrado(nameOfTable, rowIndexFormed);
    }
}

function Datos_Personales_Adicionales_InvolucradofnOpenAddRowPopUp() {
    var currentRowIndex = Datos_Personales_Adicionales_InvolucradoTable.fnGetData().length;
    Datos_Personales_Adicionales_InvolucradofnClickAddRow();
    GetAddDatos_Personales_Adicionales_InvolucradoPopup(currentRowIndex, 0);
}

function Datos_Personales_Adicionales_InvolucradoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Datos_Personales_Adicionales_InvolucradoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Datos_Personales_Adicionales_InvolucradoRowElement = "Datos_Personales_Adicionales_Involucrado_" + rowIndex.toString();
    var prevData = Datos_Personales_Adicionales_InvolucradoTable.fnGetData(rowIndexTable);
    GetAddDatos_Personales_Adicionales_InvolucradoPopup(rowIndex, 1, prevData.Clave);

    $('#Datos_Personales_Adicionales_InvolucradoCorreo_Electronico').val(prevData.Correo_Electronico);
    $('#Datos_Personales_Adicionales_InvolucradoNumero_Telefonico').val(prevData.Numero_Telefonico);
    $('#Datos_Personales_Adicionales_InvolucradoRedes_Sociales').val(prevData.Redes_Sociales);
    $('#Datos_Personales_Adicionales_InvolucradoObservaciones').val(prevData.Observaciones);

    initiateUIControls();






}

function Datos_Personales_Adicionales_InvolucradoAddInsertRow() {
    if (Datos_Personales_Adicionales_InvolucradoinsertRowCurrentIndex < 1)
    {
        Datos_Personales_Adicionales_InvolucradoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Correo_Electronico: ""
        ,Numero_Telefonico: ""
        ,Redes_Sociales: ""
        ,Observaciones: ""

    }
}

function Datos_Personales_Adicionales_InvolucradofnClickAddRow() {
    Datos_Personales_Adicionales_InvolucradocountRowsChecked++;
    Datos_Personales_Adicionales_InvolucradoTable.fnAddData(Datos_Personales_Adicionales_InvolucradoAddInsertRow(), true);
    Datos_Personales_Adicionales_InvolucradoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Datos_Personales_Adicionales_InvolucradoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Datos_Personales_Adicionales_InvolucradoGrid tbody tr:nth-of-type(' + (Datos_Personales_Adicionales_InvolucradoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDatos_Personales_Adicionales_Involucrado("Datos_Personales_Adicionales_Involucrado_", "_" + Datos_Personales_Adicionales_InvolucradoinsertRowCurrentIndex);
}

function Datos_Personales_Adicionales_InvolucradoClearGridData() {
    Datos_Personales_Adicionales_InvolucradoData = [];
    Datos_Personales_Adicionales_InvolucradodeletedItem = [];
    Datos_Personales_Adicionales_InvolucradoDataMain = [];
    Datos_Personales_Adicionales_InvolucradoDataMainPages = [];
    Datos_Personales_Adicionales_InvolucradonewItemCount = 0;
    Datos_Personales_Adicionales_InvolucradomaxItemIndex = 0;
    $("#Datos_Personales_Adicionales_InvolucradoGrid").DataTable().clear();
    $("#Datos_Personales_Adicionales_InvolucradoGrid").DataTable().destroy();
}

//Used to Get Involucrados AT Information
function GetDatos_Personales_Adicionales_Involucrado() {
    var form_data = new FormData();
    for (var i = 0; i < Datos_Personales_Adicionales_InvolucradoData.length; i++) {
        form_data.append('[' + i + '].Clave', Datos_Personales_Adicionales_InvolucradoData[i].Clave);

        form_data.append('[' + i + '].Correo_Electronico', Datos_Personales_Adicionales_InvolucradoData[i].Correo_Electronico);
        form_data.append('[' + i + '].Numero_Telefonico', Datos_Personales_Adicionales_InvolucradoData[i].Numero_Telefonico);
        form_data.append('[' + i + '].Redes_Sociales', Datos_Personales_Adicionales_InvolucradoData[i].Redes_Sociales);
        form_data.append('[' + i + '].Observaciones', Datos_Personales_Adicionales_InvolucradoData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Datos_Personales_Adicionales_InvolucradoData[i].Removed);
    }
    return form_data;
}
function Datos_Personales_Adicionales_InvolucradoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDatos_Personales_Adicionales_Involucrado("Datos_Personales_Adicionales_InvolucradoTable", rowIndex)) {
    var prevData = Datos_Personales_Adicionales_InvolucradoTable.fnGetData(rowIndex);
    var data = Datos_Personales_Adicionales_InvolucradoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Correo_Electronico: $('#Datos_Personales_Adicionales_InvolucradoCorreo_Electronico').val()
        ,Numero_Telefonico: $('#Datos_Personales_Adicionales_InvolucradoNumero_Telefonico').val()
        ,Redes_Sociales: $('#Datos_Personales_Adicionales_InvolucradoRedes_Sociales').val()
        ,Observaciones: $('#Datos_Personales_Adicionales_InvolucradoObservaciones').val()

    }

    Datos_Personales_Adicionales_InvolucradoTable.fnUpdate(newData, rowIndex, null, true);
    Datos_Personales_Adicionales_InvolucradorowCreationGrid(data, newData, rowIndex);
    $('#AddDatos_Personales_Adicionales_Involucrado-form').modal({ show: false });
    $('#AddDatos_Personales_Adicionales_Involucrado-form').modal('hide');
    Datos_Personales_Adicionales_InvolucradoEditRow(rowIndex);
    Datos_Personales_Adicionales_InvolucradoInsertRow(rowIndex);
    //}
}
function Datos_Personales_Adicionales_InvolucradoRemoveAddRow(rowIndex) {
    Datos_Personales_Adicionales_InvolucradoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Datos_Personales_Adicionales_Involucrado MultiRow
//Begin Declarations for Foreigns fields for Otras_Identificaciones_Involucrado MultiRow
var Otras_Identificaciones_InvolucradocountRowsChecked = 0;

function GetOtras_Identificaciones_Involucrado_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionItems.length; i++) {
        if (Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetOtras_Identificaciones_Involucrado_Tipo_de_IdentificacionDropDown() {
    var Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otras_Identificaciones_Involucrado_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionDropdown);
    if(Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionItems[i].Clave, text:    Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionDropdown);
       }
    }
    return Otras_Identificaciones_Involucrado_Tipo_de_IdentificacionDropdown;
}



function GetInsertOtras_Identificaciones_InvolucradoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetOtras_Identificaciones_Involucrado_Tipo_de_IdentificacionDropDown()).addClass('Otras_Identificaciones_Involucrado_Tipo_de_identificacion Tipo_de_identificacion').attr('id', 'Otras_Identificaciones_Involucrado_Tipo_de_identificacion_' + index).attr('data-field', 'Tipo_de_identificacion').after($.parseHTML(addNew('Otras_Identificaciones_Involucrado', 'Tipo_de_Identificacion', 'Tipo_de_identificacion', 265733)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Otras_Identificaciones_Involucrado_Descripcion Descripcion').attr('id', 'Otras_Identificaciones_Involucrado_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Otras_Identificaciones_InvolucradoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMROtras_Identificaciones_Involucrado("Otras_Identificaciones_Involucrado_", "_" + rowIndex)) {
    var iPage = Otras_Identificaciones_InvolucradoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Otras_Identificaciones_Involucrado';
    var prevData = Otras_Identificaciones_InvolucradoTable.fnGetData(rowIndex);
    var data = Otras_Identificaciones_InvolucradoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Otras_Identificaciones_InvolucradoTable.fnUpdate(newData, rowIndex, null, true);
    Otras_Identificaciones_InvolucradorowCreationGrid(data, newData, rowIndex);
    Otras_Identificaciones_InvolucradoTable.fnPageChange(iPage);
    Otras_Identificaciones_InvolucradocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMROtras_Identificaciones_Involucrado("Otras_Identificaciones_Involucrado_", "_" + rowIndex);
  }
}

function Otras_Identificaciones_InvolucradoCancelRow(rowIndex) {
    var prevData = Otras_Identificaciones_InvolucradoTable.fnGetData(rowIndex);
    var data = Otras_Identificaciones_InvolucradoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Otras_Identificaciones_InvolucradoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Otras_Identificaciones_InvolucradorowCreationGrid(data, prevData, rowIndex);
    }
	showOtras_Identificaciones_InvolucradoGrid(Otras_Identificaciones_InvolucradoTable.fnGetData());
    Otras_Identificaciones_InvolucradocountRowsChecked--;
	initiateUIControls();
}

function GetOtras_Identificaciones_InvolucradoFromDataTable() {
    var Otras_Identificaciones_InvolucradoData = [];
    var gridData = Otras_Identificaciones_InvolucradoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Otras_Identificaciones_InvolucradoData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_identificacion: gridData[i].Tipo_de_identificacion
                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedOtras_Identificaciones_InvolucradoData.length; i++) {
        if (removedOtras_Identificaciones_InvolucradoData[i] != null && removedOtras_Identificaciones_InvolucradoData[i].Clave > 0)
            Otras_Identificaciones_InvolucradoData.push({
                Clave: removedOtras_Identificaciones_InvolucradoData[i].Clave

                ,Tipo_de_identificacion: removedOtras_Identificaciones_InvolucradoData[i].Tipo_de_identificacion
                ,Descripcion: removedOtras_Identificaciones_InvolucradoData[i].Descripcion

                , Removed: true
            });
    }	

    return Otras_Identificaciones_InvolucradoData;
}

function Otras_Identificaciones_InvolucradoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Otras_Identificaciones_InvolucradoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Otras_Identificaciones_InvolucradocountRowsChecked++;
    var Otras_Identificaciones_InvolucradoRowElement = "Otras_Identificaciones_Involucrado_" + rowIndex.toString();
    var prevData = Otras_Identificaciones_InvolucradoTable.fnGetData(rowIndexTable );
    var row = Otras_Identificaciones_InvolucradoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Otras_Identificaciones_Involucrado_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Otras_Identificaciones_InvolucradoGetUpdateRowControls(prevData, "Otras_Identificaciones_Involucrado_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Otras_Identificaciones_InvolucradoRowElement + "')){ Otras_Identificaciones_InvolucradoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Otras_Identificaciones_InvolucradoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Otras_Identificaciones_InvolucradoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Otras_Identificaciones_InvolucradoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setOtras_Identificaciones_InvolucradoValidation();
    initiateUIControls();
    $('.Otras_Identificaciones_Involucrado' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMROtras_Identificaciones_Involucrado(nameOfTable, rowIndexFormed);
    }
}

function Otras_Identificaciones_InvolucradofnOpenAddRowPopUp() {
    var currentRowIndex = Otras_Identificaciones_InvolucradoTable.fnGetData().length;
    Otras_Identificaciones_InvolucradofnClickAddRow();
    GetAddOtras_Identificaciones_InvolucradoPopup(currentRowIndex, 0);
}

function Otras_Identificaciones_InvolucradoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Otras_Identificaciones_InvolucradoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Otras_Identificaciones_InvolucradoRowElement = "Otras_Identificaciones_Involucrado_" + rowIndex.toString();
    var prevData = Otras_Identificaciones_InvolucradoTable.fnGetData(rowIndexTable);
    GetAddOtras_Identificaciones_InvolucradoPopup(rowIndex, 1, prevData.Clave);

    $('#Otras_Identificaciones_InvolucradoTipo_de_identificacion').val(prevData.Tipo_de_identificacion);
    $('#Otras_Identificaciones_InvolucradoDescripcion').val(prevData.Descripcion);

    initiateUIControls();




}

function Otras_Identificaciones_InvolucradoAddInsertRow() {
    if (Otras_Identificaciones_InvolucradoinsertRowCurrentIndex < 1)
    {
        Otras_Identificaciones_InvolucradoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_identificacion: ""
        ,Descripcion: ""

    }
}

function Otras_Identificaciones_InvolucradofnClickAddRow() {
    Otras_Identificaciones_InvolucradocountRowsChecked++;
    Otras_Identificaciones_InvolucradoTable.fnAddData(Otras_Identificaciones_InvolucradoAddInsertRow(), true);
    Otras_Identificaciones_InvolucradoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Otras_Identificaciones_InvolucradoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Otras_Identificaciones_InvolucradoGrid tbody tr:nth-of-type(' + (Otras_Identificaciones_InvolucradoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMROtras_Identificaciones_Involucrado("Otras_Identificaciones_Involucrado_", "_" + Otras_Identificaciones_InvolucradoinsertRowCurrentIndex);
}

function Otras_Identificaciones_InvolucradoClearGridData() {
    Otras_Identificaciones_InvolucradoData = [];
    Otras_Identificaciones_InvolucradodeletedItem = [];
    Otras_Identificaciones_InvolucradoDataMain = [];
    Otras_Identificaciones_InvolucradoDataMainPages = [];
    Otras_Identificaciones_InvolucradonewItemCount = 0;
    Otras_Identificaciones_InvolucradomaxItemIndex = 0;
    $("#Otras_Identificaciones_InvolucradoGrid").DataTable().clear();
    $("#Otras_Identificaciones_InvolucradoGrid").DataTable().destroy();
}

//Used to Get Involucrados AT Information
function GetOtras_Identificaciones_Involucrado() {
    var form_data = new FormData();
    for (var i = 0; i < Otras_Identificaciones_InvolucradoData.length; i++) {
        form_data.append('[' + i + '].Clave', Otras_Identificaciones_InvolucradoData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_identificacion', Otras_Identificaciones_InvolucradoData[i].Tipo_de_identificacion);
        form_data.append('[' + i + '].Descripcion', Otras_Identificaciones_InvolucradoData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Otras_Identificaciones_InvolucradoData[i].Removed);
    }
    return form_data;
}
function Otras_Identificaciones_InvolucradoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMROtras_Identificaciones_Involucrado("Otras_Identificaciones_InvolucradoTable", rowIndex)) {
    var prevData = Otras_Identificaciones_InvolucradoTable.fnGetData(rowIndex);
    var data = Otras_Identificaciones_InvolucradoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_identificacion: $('#Otras_Identificaciones_InvolucradoTipo_de_identificacion').val()
        ,Descripcion: $('#Otras_Identificaciones_InvolucradoDescripcion').val()

    }

    Otras_Identificaciones_InvolucradoTable.fnUpdate(newData, rowIndex, null, true);
    Otras_Identificaciones_InvolucradorowCreationGrid(data, newData, rowIndex);
    $('#AddOtras_Identificaciones_Involucrado-form').modal({ show: false });
    $('#AddOtras_Identificaciones_Involucrado-form').modal('hide');
    Otras_Identificaciones_InvolucradoEditRow(rowIndex);
    Otras_Identificaciones_InvolucradoInsertRow(rowIndex);
    //}
}
function Otras_Identificaciones_InvolucradoRemoveAddRow(rowIndex) {
    Otras_Identificaciones_InvolucradoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Otras_Identificaciones_Involucrado MultiRow
//Begin Declarations for Foreigns fields for Otros_Domicilios_Involucrado MultiRow
var Otros_Domicilios_InvolucradocountRowsChecked = 0;

function GetOtros_Domicilios_Involucrado_EstadoName(Id) {
    for (var i = 0; i < Otros_Domicilios_Involucrado_EstadoItems.length; i++) {
        if (Otros_Domicilios_Involucrado_EstadoItems[i].Clave == Id) {
            return Otros_Domicilios_Involucrado_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Involucrado_EstadoDropDown() {
    var Otros_Domicilios_Involucrado_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Involucrado_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Involucrado_EstadoDropdown);

    for (var i = 0; i < Otros_Domicilios_Involucrado_EstadoItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Involucrado_EstadoItems[i].Clave, text: Otros_Domicilios_Involucrado_EstadoItems[i].Nombre }).appendTo(Otros_Domicilios_Involucrado_EstadoDropdown);
    }
    return Otros_Domicilios_Involucrado_EstadoDropdown;
}
function GetOtros_Domicilios_Involucrado_MunicipioName(Id) {
    for (var i = 0; i < Otros_Domicilios_Involucrado_MunicipioItems.length; i++) {
        if (Otros_Domicilios_Involucrado_MunicipioItems[i].Clave == Id) {
            return Otros_Domicilios_Involucrado_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Involucrado_MunicipioDropDown() {
    var Otros_Domicilios_Involucrado_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Involucrado_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Involucrado_MunicipioDropdown);

    for (var i = 0; i < Otros_Domicilios_Involucrado_MunicipioItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Involucrado_MunicipioItems[i].Clave, text: Otros_Domicilios_Involucrado_MunicipioItems[i].Nombre }).appendTo(Otros_Domicilios_Involucrado_MunicipioDropdown);
    }
    return Otros_Domicilios_Involucrado_MunicipioDropdown;
}
function GetOtros_Domicilios_Involucrado_ColoniaName(Id) {
    for (var i = 0; i < Otros_Domicilios_Involucrado_ColoniaItems.length; i++) {
        if (Otros_Domicilios_Involucrado_ColoniaItems[i].Clave == Id) {
            return Otros_Domicilios_Involucrado_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Involucrado_ColoniaDropDown() {
    var Otros_Domicilios_Involucrado_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Involucrado_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Involucrado_ColoniaDropdown);

    for (var i = 0; i < Otros_Domicilios_Involucrado_ColoniaItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Involucrado_ColoniaItems[i].Clave, text: Otros_Domicilios_Involucrado_ColoniaItems[i].Nombre }).appendTo(Otros_Domicilios_Involucrado_ColoniaDropdown);
    }
    return Otros_Domicilios_Involucrado_ColoniaDropdown;
}
function GetOtros_Domicilios_Involucrado_ColoniaName(Id) {
    for (var i = 0; i < Otros_Domicilios_Involucrado_ColoniaItems.length; i++) {
        if (Otros_Domicilios_Involucrado_ColoniaItems[i].Clave == Id) {
            return Otros_Domicilios_Involucrado_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Involucrado_ColoniaDropDown() {
    var Otros_Domicilios_Involucrado_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Involucrado_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Involucrado_ColoniaDropdown);

    for (var i = 0; i < Otros_Domicilios_Involucrado_ColoniaItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Involucrado_ColoniaItems[i].Clave, text: Otros_Domicilios_Involucrado_ColoniaItems[i].Nombre }).appendTo(Otros_Domicilios_Involucrado_ColoniaDropdown);
    }
    return Otros_Domicilios_Involucrado_ColoniaDropdown;
}











function GetInsertOtros_Domicilios_InvolucradoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Involucrado_Estado'))).addClass('Otros_Domicilios_Involucrado_Estado Estado').attr('id', 'Otros_Domicilios_Involucrado_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Otros_Domicilios_Involucrado', 'Estado', 'Estado', 265664)));
    columnData[1] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Involucrado_Municipio'))).addClass('Otros_Domicilios_Involucrado_Municipio Municipio').attr('id', 'Otros_Domicilios_Involucrado_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Otros_Domicilios_Involucrado', 'Municipio', 'Municipio', 265665)));
    columnData[2] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Involucrado_Poblacion'))).addClass('Otros_Domicilios_Involucrado_Poblacion Poblacion').attr('id', 'Otros_Domicilios_Involucrado_Poblacion_' + index).attr('data-field', 'Poblacion').after($.parseHTML(addNew('Otros_Domicilios_Involucrado', 'Colonia', 'Poblacion', 265666)));
    columnData[3] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Involucrado_Colonia'))).addClass('Otros_Domicilios_Involucrado_Colonia Colonia').attr('id', 'Otros_Domicilios_Involucrado_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Otros_Domicilios_Involucrado', 'Colonia', 'Colonia', 265667)));
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Otros_Domicilios_Involucrado_Codigo_Postal Codigo_Postal').attr('id', 'Otros_Domicilios_Involucrado_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[5] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Involucrado_Calle Calle').attr('id', 'Otros_Domicilios_Involucrado_Calle_' + index).attr('data-field', 'Calle');
    columnData[6] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Involucrado_Entre_Calle Entre_Calle').attr('id', 'Otros_Domicilios_Involucrado_Entre_Calle_' + index).attr('data-field', 'Entre_Calle');
    columnData[7] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Involucrado_Y_Calle Y_Calle').attr('id', 'Otros_Domicilios_Involucrado_Y_Calle_' + index).attr('data-field', 'Y_Calle');
    columnData[8] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Involucrado_Numero_Exterior Numero_Exterior').attr('id', 'Otros_Domicilios_Involucrado_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[9] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Involucrado_Numero_Interior Numero_Interior').attr('id', 'Otros_Domicilios_Involucrado_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[10] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Involucrado_Coordenada_X Coordenada_X').attr('id', 'Otros_Domicilios_Involucrado_Coordenada_X_' + index).attr('data-field', 'Coordenada_X');
    columnData[11] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Involucrado_Coordenada_Y Coordenada_Y').attr('id', 'Otros_Domicilios_Involucrado_Coordenada_Y_' + index).attr('data-field', 'Coordenada_Y');
    columnData[12] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Involucrado_Observaciones Observaciones').attr('id', 'Otros_Domicilios_Involucrado_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Otros_Domicilios_InvolucradoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMROtros_Domicilios_Involucrado("Otros_Domicilios_Involucrado_", "_" + rowIndex)) {
    var iPage = Otros_Domicilios_InvolucradoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Otros_Domicilios_Involucrado';
    var prevData = Otros_Domicilios_InvolucradoTable.fnGetData(rowIndex);
    var data = Otros_Domicilios_InvolucradoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , EstadoNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Estado:  data.childNodes[counter++].childNodes[0].value 	
        , MunicipioNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Municipio:  data.childNodes[counter++].childNodes[0].value 	
        , PoblacionNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Poblacion:  data.childNodes[counter++].childNodes[0].value 	
        , ColoniaNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Colonia:  data.childNodes[counter++].childNodes[0].value 	
        ,Codigo_Postal: data.childNodes[counter++].childNodes[0].value
        ,Calle:  data.childNodes[counter++].childNodes[0].value
        ,Entre_Calle:  data.childNodes[counter++].childNodes[0].value
        ,Y_Calle:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value
        ,Coordenada_X:  data.childNodes[counter++].childNodes[0].value
        ,Coordenada_Y:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Otros_Domicilios_InvolucradoTable.fnUpdate(newData, rowIndex, null, true);
    Otros_Domicilios_InvolucradorowCreationGrid(data, newData, rowIndex);
    Otros_Domicilios_InvolucradoTable.fnPageChange(iPage);
    Otros_Domicilios_InvolucradocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMROtros_Domicilios_Involucrado("Otros_Domicilios_Involucrado_", "_" + rowIndex);
  }
}

function Otros_Domicilios_InvolucradoCancelRow(rowIndex) {
    var prevData = Otros_Domicilios_InvolucradoTable.fnGetData(rowIndex);
    var data = Otros_Domicilios_InvolucradoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Otros_Domicilios_InvolucradoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Otros_Domicilios_InvolucradorowCreationGrid(data, prevData, rowIndex);
    }
	showOtros_Domicilios_InvolucradoGrid(Otros_Domicilios_InvolucradoTable.fnGetData());
    Otros_Domicilios_InvolucradocountRowsChecked--;
	initiateUIControls();
}

function GetOtros_Domicilios_InvolucradoFromDataTable() {
    var Otros_Domicilios_InvolucradoData = [];
    var gridData = Otros_Domicilios_InvolucradoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Otros_Domicilios_InvolucradoData.push({
                Clave: gridData[i].Clave

                ,Estado: gridData[i].Estado
                ,Municipio: gridData[i].Municipio
                ,Poblacion: gridData[i].Poblacion
                ,Colonia: gridData[i].Colonia
                ,Codigo_Postal: gridData[i].Codigo_Postal
                ,Calle: gridData[i].Calle
                ,Entre_Calle: gridData[i].Entre_Calle
                ,Y_Calle: gridData[i].Y_Calle
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior
                ,Coordenada_X: gridData[i].Coordenada_X
                ,Coordenada_Y: gridData[i].Coordenada_Y
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedOtros_Domicilios_InvolucradoData.length; i++) {
        if (removedOtros_Domicilios_InvolucradoData[i] != null && removedOtros_Domicilios_InvolucradoData[i].Clave > 0)
            Otros_Domicilios_InvolucradoData.push({
                Clave: removedOtros_Domicilios_InvolucradoData[i].Clave

                ,Estado: removedOtros_Domicilios_InvolucradoData[i].Estado
                ,Municipio: removedOtros_Domicilios_InvolucradoData[i].Municipio
                ,Poblacion: removedOtros_Domicilios_InvolucradoData[i].Poblacion
                ,Colonia: removedOtros_Domicilios_InvolucradoData[i].Colonia
                ,Codigo_Postal: removedOtros_Domicilios_InvolucradoData[i].Codigo_Postal
                ,Calle: removedOtros_Domicilios_InvolucradoData[i].Calle
                ,Entre_Calle: removedOtros_Domicilios_InvolucradoData[i].Entre_Calle
                ,Y_Calle: removedOtros_Domicilios_InvolucradoData[i].Y_Calle
                ,Numero_Exterior: removedOtros_Domicilios_InvolucradoData[i].Numero_Exterior
                ,Numero_Interior: removedOtros_Domicilios_InvolucradoData[i].Numero_Interior
                ,Coordenada_X: removedOtros_Domicilios_InvolucradoData[i].Coordenada_X
                ,Coordenada_Y: removedOtros_Domicilios_InvolucradoData[i].Coordenada_Y
                ,Observaciones: removedOtros_Domicilios_InvolucradoData[i].Observaciones

                , Removed: true
            });
    }	

    return Otros_Domicilios_InvolucradoData;
}

function Otros_Domicilios_InvolucradoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Otros_Domicilios_InvolucradoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Otros_Domicilios_InvolucradocountRowsChecked++;
    var Otros_Domicilios_InvolucradoRowElement = "Otros_Domicilios_Involucrado_" + rowIndex.toString();
    var prevData = Otros_Domicilios_InvolucradoTable.fnGetData(rowIndexTable );
    var row = Otros_Domicilios_InvolucradoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Otros_Domicilios_Involucrado_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Otros_Domicilios_InvolucradoGetUpdateRowControls(prevData, "Otros_Domicilios_Involucrado_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Otros_Domicilios_InvolucradoRowElement + "')){ Otros_Domicilios_InvolucradoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Otros_Domicilios_InvolucradoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Otros_Domicilios_InvolucradoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Otros_Domicilios_InvolucradoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setOtros_Domicilios_InvolucradoValidation();
    initiateUIControls();
    $('.Otros_Domicilios_Involucrado' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMROtros_Domicilios_Involucrado(nameOfTable, rowIndexFormed);
    }
}

function Otros_Domicilios_InvolucradofnOpenAddRowPopUp() {
    var currentRowIndex = Otros_Domicilios_InvolucradoTable.fnGetData().length;
    Otros_Domicilios_InvolucradofnClickAddRow();
    GetAddOtros_Domicilios_InvolucradoPopup(currentRowIndex, 0);
}

function Otros_Domicilios_InvolucradoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Otros_Domicilios_InvolucradoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Otros_Domicilios_InvolucradoRowElement = "Otros_Domicilios_Involucrado_" + rowIndex.toString();
    var prevData = Otros_Domicilios_InvolucradoTable.fnGetData(rowIndexTable);
    GetAddOtros_Domicilios_InvolucradoPopup(rowIndex, 1, prevData.Clave);

    $('#dvOtros_Domicilios_InvolucradoEstado').html($($.parseHTML(GetGridAutoComplete(prevData.Estado.label,'AutoCompleteEstado'))).addClass('Otros_Domicilios_Involucrado_Estado'));
    $('#dvOtros_Domicilios_InvolucradoMunicipio').html($($.parseHTML(GetGridAutoComplete(prevData.Municipio.label,'AutoCompleteMunicipio'))).addClass('Otros_Domicilios_Involucrado_Municipio'));
    $('#dvOtros_Domicilios_InvolucradoPoblacion').html($($.parseHTML(GetGridAutoComplete(prevData.Poblacion.label,'AutoCompletePoblacion'))).addClass('Otros_Domicilios_Involucrado_Poblacion'));
    $('#dvOtros_Domicilios_InvolucradoColonia').html($($.parseHTML(GetGridAutoComplete(prevData.Colonia.label,'AutoCompleteColonia'))).addClass('Otros_Domicilios_Involucrado_Colonia'));
    $('#Otros_Domicilios_InvolucradoCodigo_Postal').val(prevData.Codigo_Postal);
    $('#Otros_Domicilios_InvolucradoCalle').val(prevData.Calle);
    $('#Otros_Domicilios_InvolucradoEntre_Calle').val(prevData.Entre_Calle);
    $('#Otros_Domicilios_InvolucradoY_Calle').val(prevData.Y_Calle);
    $('#Otros_Domicilios_InvolucradoNumero_Exterior').val(prevData.Numero_Exterior);
    $('#Otros_Domicilios_InvolucradoNumero_Interior').val(prevData.Numero_Interior);
    $('#Otros_Domicilios_InvolucradoCoordenada_X').val(prevData.Coordenada_X);
    $('#Otros_Domicilios_InvolucradoCoordenada_Y').val(prevData.Coordenada_Y);
    $('#Otros_Domicilios_InvolucradoObservaciones').val(prevData.Observaciones);

    initiateUIControls();















}

function Otros_Domicilios_InvolucradoAddInsertRow() {
    if (Otros_Domicilios_InvolucradoinsertRowCurrentIndex < 1)
    {
        Otros_Domicilios_InvolucradoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Estado: ""
        ,Municipio: ""
        ,Poblacion: ""
        ,Colonia: ""
        ,Codigo_Postal: ""
        ,Calle: ""
        ,Entre_Calle: ""
        ,Y_Calle: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""
        ,Coordenada_X: ""
        ,Coordenada_Y: ""
        ,Observaciones: ""

    }
}

function Otros_Domicilios_InvolucradofnClickAddRow() {
    Otros_Domicilios_InvolucradocountRowsChecked++;
    Otros_Domicilios_InvolucradoTable.fnAddData(Otros_Domicilios_InvolucradoAddInsertRow(), true);
    Otros_Domicilios_InvolucradoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Otros_Domicilios_InvolucradoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Otros_Domicilios_InvolucradoGrid tbody tr:nth-of-type(' + (Otros_Domicilios_InvolucradoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMROtros_Domicilios_Involucrado("Otros_Domicilios_Involucrado_", "_" + Otros_Domicilios_InvolucradoinsertRowCurrentIndex);
}

function Otros_Domicilios_InvolucradoClearGridData() {
    Otros_Domicilios_InvolucradoData = [];
    Otros_Domicilios_InvolucradodeletedItem = [];
    Otros_Domicilios_InvolucradoDataMain = [];
    Otros_Domicilios_InvolucradoDataMainPages = [];
    Otros_Domicilios_InvolucradonewItemCount = 0;
    Otros_Domicilios_InvolucradomaxItemIndex = 0;
    $("#Otros_Domicilios_InvolucradoGrid").DataTable().clear();
    $("#Otros_Domicilios_InvolucradoGrid").DataTable().destroy();
}

//Used to Get Involucrados AT Information
function GetOtros_Domicilios_Involucrado() {
    var form_data = new FormData();
    for (var i = 0; i < Otros_Domicilios_InvolucradoData.length; i++) {
        form_data.append('[' + i + '].Clave', Otros_Domicilios_InvolucradoData[i].Clave);

        form_data.append('[' + i + '].Estado', Otros_Domicilios_InvolucradoData[i].Estado);
        form_data.append('[' + i + '].Municipio', Otros_Domicilios_InvolucradoData[i].Municipio);
        form_data.append('[' + i + '].Poblacion', Otros_Domicilios_InvolucradoData[i].Poblacion);
        form_data.append('[' + i + '].Colonia', Otros_Domicilios_InvolucradoData[i].Colonia);
        form_data.append('[' + i + '].Codigo_Postal', Otros_Domicilios_InvolucradoData[i].Codigo_Postal);
        form_data.append('[' + i + '].Calle', Otros_Domicilios_InvolucradoData[i].Calle);
        form_data.append('[' + i + '].Entre_Calle', Otros_Domicilios_InvolucradoData[i].Entre_Calle);
        form_data.append('[' + i + '].Y_Calle', Otros_Domicilios_InvolucradoData[i].Y_Calle);
        form_data.append('[' + i + '].Numero_Exterior', Otros_Domicilios_InvolucradoData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Otros_Domicilios_InvolucradoData[i].Numero_Interior);
        form_data.append('[' + i + '].Coordenada_X', Otros_Domicilios_InvolucradoData[i].Coordenada_X);
        form_data.append('[' + i + '].Coordenada_Y', Otros_Domicilios_InvolucradoData[i].Coordenada_Y);
        form_data.append('[' + i + '].Observaciones', Otros_Domicilios_InvolucradoData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Otros_Domicilios_InvolucradoData[i].Removed);
    }
    return form_data;
}
function Otros_Domicilios_InvolucradoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMROtros_Domicilios_Involucrado("Otros_Domicilios_InvolucradoTable", rowIndex)) {
    var prevData = Otros_Domicilios_InvolucradoTable.fnGetData(rowIndex);
    var data = Otros_Domicilios_InvolucradoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Estado: $('#Otros_Domicilios_InvolucradoEstado').val()
        ,Municipio: $('#Otros_Domicilios_InvolucradoMunicipio').val()
        ,Poblacion: $('#Otros_Domicilios_InvolucradoPoblacion').val()
        ,Colonia: $('#Otros_Domicilios_InvolucradoColonia').val()
        ,Codigo_Postal: $('#Otros_Domicilios_InvolucradoCodigo_Postal').val()

        ,Calle: $('#Otros_Domicilios_InvolucradoCalle').val()
        ,Entre_Calle: $('#Otros_Domicilios_InvolucradoEntre_Calle').val()
        ,Y_Calle: $('#Otros_Domicilios_InvolucradoY_Calle').val()
        ,Numero_Exterior: $('#Otros_Domicilios_InvolucradoNumero_Exterior').val()
        ,Numero_Interior: $('#Otros_Domicilios_InvolucradoNumero_Interior').val()
        ,Coordenada_X: $('#Otros_Domicilios_InvolucradoCoordenada_X').val()
        ,Coordenada_Y: $('#Otros_Domicilios_InvolucradoCoordenada_Y').val()
        ,Observaciones: $('#Otros_Domicilios_InvolucradoObservaciones').val()

    }

    Otros_Domicilios_InvolucradoTable.fnUpdate(newData, rowIndex, null, true);
    Otros_Domicilios_InvolucradorowCreationGrid(data, newData, rowIndex);
    $('#AddOtros_Domicilios_Involucrado-form').modal({ show: false });
    $('#AddOtros_Domicilios_Involucrado-form').modal('hide');
    Otros_Domicilios_InvolucradoEditRow(rowIndex);
    Otros_Domicilios_InvolucradoInsertRow(rowIndex);
    //}
}
function Otros_Domicilios_InvolucradoRemoveAddRow(rowIndex) {
    Otros_Domicilios_InvolucradoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Otros_Domicilios_Involucrado MultiRow


$(function () {
    function Adicciones_de_InvolucradoinitializeMainArray(totalCount) {
        if (Adicciones_de_InvolucradoDataMain.length != totalCount && !Adicciones_de_InvolucradoDataMainInitialized) {
            Adicciones_de_InvolucradoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Adicciones_de_InvolucradoDataMain[i] = null;
            }
        }
    }
    function Adicciones_de_InvolucradoremoveFromMainArray() {
        for (var j = 0; j < Adicciones_de_InvolucradodeletedItem.length; j++) {
            for (var i = 0; i < Adicciones_de_InvolucradoDataMain.length; i++) {
                if (Adicciones_de_InvolucradoDataMain[i] != null && Adicciones_de_InvolucradoDataMain[i].Id == Adicciones_de_InvolucradodeletedItem[j]) {
                    hAdicciones_de_InvolucradoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Adicciones_de_InvolucradocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Adicciones_de_InvolucradoDataMain.length; i++) {
            data[i] = Adicciones_de_InvolucradoDataMain[i];

        }
        return data;
    }
    function Adicciones_de_InvolucradogetNewResult() {
        var newData = copyMainAdicciones_de_InvolucradoArray();

        for (var i = 0; i < Adicciones_de_InvolucradoData.length; i++) {
            if (Adicciones_de_InvolucradoData[i].Removed == null || Adicciones_de_InvolucradoData[i].Removed == false) {
                newData.splice(0, 0, Adicciones_de_InvolucradoData[i]);
            }
        }
        return newData;
    }
    function Adicciones_de_InvolucradopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Adicciones_de_InvolucradoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Adicciones_de_InvolucradoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Lugares_Frecuentes_InvolucradoinitializeMainArray(totalCount) {
        if (Lugares_Frecuentes_InvolucradoDataMain.length != totalCount && !Lugares_Frecuentes_InvolucradoDataMainInitialized) {
            Lugares_Frecuentes_InvolucradoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Lugares_Frecuentes_InvolucradoDataMain[i] = null;
            }
        }
    }
    function Lugares_Frecuentes_InvolucradoremoveFromMainArray() {
        for (var j = 0; j < Lugares_Frecuentes_InvolucradodeletedItem.length; j++) {
            for (var i = 0; i < Lugares_Frecuentes_InvolucradoDataMain.length; i++) {
                if (Lugares_Frecuentes_InvolucradoDataMain[i] != null && Lugares_Frecuentes_InvolucradoDataMain[i].Id == Lugares_Frecuentes_InvolucradodeletedItem[j]) {
                    hLugares_Frecuentes_InvolucradoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Lugares_Frecuentes_InvolucradocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Lugares_Frecuentes_InvolucradoDataMain.length; i++) {
            data[i] = Lugares_Frecuentes_InvolucradoDataMain[i];

        }
        return data;
    }
    function Lugares_Frecuentes_InvolucradogetNewResult() {
        var newData = copyMainLugares_Frecuentes_InvolucradoArray();

        for (var i = 0; i < Lugares_Frecuentes_InvolucradoData.length; i++) {
            if (Lugares_Frecuentes_InvolucradoData[i].Removed == null || Lugares_Frecuentes_InvolucradoData[i].Removed == false) {
                newData.splice(0, 0, Lugares_Frecuentes_InvolucradoData[i]);
            }
        }
        return newData;
    }
    function Lugares_Frecuentes_InvolucradopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Lugares_Frecuentes_InvolucradoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Lugares_Frecuentes_InvolucradoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Datos_Personales_Adicionales_InvolucradoinitializeMainArray(totalCount) {
        if (Datos_Personales_Adicionales_InvolucradoDataMain.length != totalCount && !Datos_Personales_Adicionales_InvolucradoDataMainInitialized) {
            Datos_Personales_Adicionales_InvolucradoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Datos_Personales_Adicionales_InvolucradoDataMain[i] = null;
            }
        }
    }
    function Datos_Personales_Adicionales_InvolucradoremoveFromMainArray() {
        for (var j = 0; j < Datos_Personales_Adicionales_InvolucradodeletedItem.length; j++) {
            for (var i = 0; i < Datos_Personales_Adicionales_InvolucradoDataMain.length; i++) {
                if (Datos_Personales_Adicionales_InvolucradoDataMain[i] != null && Datos_Personales_Adicionales_InvolucradoDataMain[i].Id == Datos_Personales_Adicionales_InvolucradodeletedItem[j]) {
                    hDatos_Personales_Adicionales_InvolucradoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Datos_Personales_Adicionales_InvolucradocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Datos_Personales_Adicionales_InvolucradoDataMain.length; i++) {
            data[i] = Datos_Personales_Adicionales_InvolucradoDataMain[i];

        }
        return data;
    }
    function Datos_Personales_Adicionales_InvolucradogetNewResult() {
        var newData = copyMainDatos_Personales_Adicionales_InvolucradoArray();

        for (var i = 0; i < Datos_Personales_Adicionales_InvolucradoData.length; i++) {
            if (Datos_Personales_Adicionales_InvolucradoData[i].Removed == null || Datos_Personales_Adicionales_InvolucradoData[i].Removed == false) {
                newData.splice(0, 0, Datos_Personales_Adicionales_InvolucradoData[i]);
            }
        }
        return newData;
    }
    function Datos_Personales_Adicionales_InvolucradopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Datos_Personales_Adicionales_InvolucradoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Datos_Personales_Adicionales_InvolucradoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Otras_Identificaciones_InvolucradoinitializeMainArray(totalCount) {
        if (Otras_Identificaciones_InvolucradoDataMain.length != totalCount && !Otras_Identificaciones_InvolucradoDataMainInitialized) {
            Otras_Identificaciones_InvolucradoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Otras_Identificaciones_InvolucradoDataMain[i] = null;
            }
        }
    }
    function Otras_Identificaciones_InvolucradoremoveFromMainArray() {
        for (var j = 0; j < Otras_Identificaciones_InvolucradodeletedItem.length; j++) {
            for (var i = 0; i < Otras_Identificaciones_InvolucradoDataMain.length; i++) {
                if (Otras_Identificaciones_InvolucradoDataMain[i] != null && Otras_Identificaciones_InvolucradoDataMain[i].Id == Otras_Identificaciones_InvolucradodeletedItem[j]) {
                    hOtras_Identificaciones_InvolucradoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Otras_Identificaciones_InvolucradocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Otras_Identificaciones_InvolucradoDataMain.length; i++) {
            data[i] = Otras_Identificaciones_InvolucradoDataMain[i];

        }
        return data;
    }
    function Otras_Identificaciones_InvolucradogetNewResult() {
        var newData = copyMainOtras_Identificaciones_InvolucradoArray();

        for (var i = 0; i < Otras_Identificaciones_InvolucradoData.length; i++) {
            if (Otras_Identificaciones_InvolucradoData[i].Removed == null || Otras_Identificaciones_InvolucradoData[i].Removed == false) {
                newData.splice(0, 0, Otras_Identificaciones_InvolucradoData[i]);
            }
        }
        return newData;
    }
    function Otras_Identificaciones_InvolucradopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Otras_Identificaciones_InvolucradoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Otras_Identificaciones_InvolucradoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Otros_Domicilios_InvolucradoinitializeMainArray(totalCount) {
        if (Otros_Domicilios_InvolucradoDataMain.length != totalCount && !Otros_Domicilios_InvolucradoDataMainInitialized) {
            Otros_Domicilios_InvolucradoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Otros_Domicilios_InvolucradoDataMain[i] = null;
            }
        }
    }
    function Otros_Domicilios_InvolucradoremoveFromMainArray() {
        for (var j = 0; j < Otros_Domicilios_InvolucradodeletedItem.length; j++) {
            for (var i = 0; i < Otros_Domicilios_InvolucradoDataMain.length; i++) {
                if (Otros_Domicilios_InvolucradoDataMain[i] != null && Otros_Domicilios_InvolucradoDataMain[i].Id == Otros_Domicilios_InvolucradodeletedItem[j]) {
                    hOtros_Domicilios_InvolucradoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Otros_Domicilios_InvolucradocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Otros_Domicilios_InvolucradoDataMain.length; i++) {
            data[i] = Otros_Domicilios_InvolucradoDataMain[i];

        }
        return data;
    }
    function Otros_Domicilios_InvolucradogetNewResult() {
        var newData = copyMainOtros_Domicilios_InvolucradoArray();

        for (var i = 0; i < Otros_Domicilios_InvolucradoData.length; i++) {
            if (Otros_Domicilios_InvolucradoData[i].Removed == null || Otros_Domicilios_InvolucradoData[i].Removed == false) {
                newData.splice(0, 0, Otros_Domicilios_InvolucradoData[i]);
            }
        }
        return newData;
    }
    function Otros_Domicilios_InvolucradopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Otros_Domicilios_InvolucradoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Otros_Domicilios_InvolucradoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteModulo_Atencion_InicialData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Modulo_Atencion_Inicial_Modulo_Atencion_InicialData(data) {
	AutoCompleteModulo_Atencion_InicialData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteModulo_Atencion_InicialData.push({
            id: data[i].Clave,
            text: data[i].NUAT
        });
    }
    return AutoCompleteModulo_Atencion_InicialData;
}
var AutoCompleteExpediente_MPData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Expediente_MP_expediente_ministerio_publicoData(data) {
	AutoCompleteExpediente_MPData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MPData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteExpediente_MPData;
}
var AutoCompleteNacionalidadData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Nacionalidad_NacionalidadData(data) {
	AutoCompleteNacionalidadData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNacionalidadData.push({
            id: data[i].Clave,
            text: data[i].NacionalidadC
        });
    }
    return AutoCompleteNacionalidadData;
}
var AutoCompletePais_de_OrigenData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Pais_de_Origen_PaisData(data) {
	AutoCompletePais_de_OrigenData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_de_OrigenData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_de_OrigenData;
}
var AutoCompletePaisData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Pais_PaisData(data) {
	AutoCompletePaisData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePaisData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePaisData;
}
var AutoCompleteEstadoData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Estado_EstadoData(data) {
	AutoCompleteEstadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstadoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstadoData;
}
var AutoCompleteMunicipioData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Municipio_MunicipioData(data) {
	AutoCompleteMunicipioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioData;
}
var AutoCompletePoblacionData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Poblacion_ColoniaData(data) {
	AutoCompletePoblacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePoblacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePoblacionData;
}
var AutoCompleteColoniaData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Colonia_ColoniaData(data) {
	AutoCompleteColoniaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaData;
}
var AutoCompleteEstado_de_NacimientoData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Estado_de_Nacimiento_EstadoData(data) {
	AutoCompleteEstado_de_NacimientoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_de_NacimientoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_de_NacimientoData;
}
var AutoCompleteMunicipio_de_NacimientoData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Municipio_de_Nacimiento_MunicipioData(data) {
	AutoCompleteMunicipio_de_NacimientoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_de_NacimientoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_de_NacimientoData;
}
//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete
var AutoCompleteEstadoData = [];
function GetAutoCompleteOtros_Domicilios_Involucrado_Estado_EstadoData(data) {
	AutoCompleteEstadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstadoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstadoData;
}
var AutoCompleteMunicipioData = [];
function GetAutoCompleteOtros_Domicilios_Involucrado_Municipio_MunicipioData(data) {
	AutoCompleteMunicipioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioData;
}
var AutoCompletePoblacionData = [];
function GetAutoCompleteOtros_Domicilios_Involucrado_Poblacion_ColoniaData(data) {
	AutoCompletePoblacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePoblacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePoblacionData;
}
var AutoCompleteColoniaData = [];
function GetAutoCompleteOtros_Domicilios_Involucrado_Colonia_ColoniaData(data) {
	AutoCompleteColoniaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaData;
}

var AutoCompletePais_de_Origen_TutorData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Pais_de_Origen_Tutor_PaisData(data) {
	AutoCompletePais_de_Origen_TutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_de_Origen_TutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_de_Origen_TutorData;
}
var AutoCompletePais_del_TutorData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Pais_del_Tutor_PaisData(data) {
	AutoCompletePais_del_TutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_del_TutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_del_TutorData;
}
var AutoCompleteEstado_del_TutorData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Estado_del_Tutor_EstadoData(data) {
	AutoCompleteEstado_del_TutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_del_TutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_del_TutorData;
}
var AutoCompleteMunicipio_del_TutorData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Municipio_del_Tutor_MunicipioData(data) {
	AutoCompleteMunicipio_del_TutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_del_TutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_del_TutorData;
}
var AutoCompletePoblacion_TutorData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Poblacion_Tutor_ColoniaData(data) {
	AutoCompletePoblacion_TutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePoblacion_TutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePoblacion_TutorData;
}
var AutoCompleteColonia_del_TutorData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Colonia_del_Tutor_ColoniaData(data) {
	AutoCompleteColonia_del_TutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_del_TutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_del_TutorData;
}
var AutoCompletePais_del_hechoData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Pais_del_hecho_PaisData(data) {
	AutoCompletePais_del_hechoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_del_hechoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_del_hechoData;
}
var AutoCompleteEstado_del_HechoData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Estado_del_Hecho_EstadoData(data) {
	AutoCompleteEstado_del_HechoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_del_HechoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_del_HechoData;
}
var AutoCompleteMunicipio_de_los_HechosData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Municipio_de_los_Hechos_MunicipioData(data) {
	AutoCompleteMunicipio_de_los_HechosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_de_los_HechosData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_de_los_HechosData;
}
var AutoCompletePoblacion_HechosData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Poblacion_Hechos_ColoniaData(data) {
	AutoCompletePoblacion_HechosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePoblacion_HechosData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePoblacion_HechosData;
}
var AutoCompleteColonia_de_los_HechosData = [];
function GetAutoCompleteDetalle_de_Datos_Generales_Colonia_de_los_Hechos_ColoniaData(data) {
	AutoCompleteColonia_de_los_HechosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_de_los_HechosData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_de_los_HechosData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Datos_Generales_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Datos_Generales')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Modulo_Atencion_Inicial').empty();
    $("#Modulo_Atencion_Inicial").append('<option value=""></option>');
    $('#Modulo_Atencion_Inicial').val('0').trigger('change');
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Nacionalidad').empty();
    $("#Nacionalidad").append('<option value=""></option>');
    $('#Nacionalidad').val('0').trigger('change');
    $('#Pais_de_Origen').empty();
    $("#Pais_de_Origen").append('<option value=""></option>');
    $('#Pais_de_Origen').val('0').trigger('change');
    $('#Pais').empty();
    $("#Pais").append('<option value=""></option>');
    $('#Pais').val('0').trigger('change');
    $('#Estado').empty();
    $("#Estado").append('<option value=""></option>');
    $('#Estado').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Poblacion').empty();
    $("#Poblacion").append('<option value=""></option>');
    $('#Poblacion').val('0').trigger('change');
    $('#Colonia').empty();
    $("#Colonia").append('<option value=""></option>');
    $('#Colonia').val('0').trigger('change');
    $('#Estado_de_Nacimiento').empty();
    $("#Estado_de_Nacimiento").append('<option value=""></option>');
    $('#Estado_de_Nacimiento').val('0').trigger('change');
    $('#Municipio_de_Nacimiento').empty();
    $("#Municipio_de_Nacimiento").append('<option value=""></option>');
    $('#Municipio_de_Nacimiento').val('0').trigger('change');
                Adicciones_de_InvolucradoClearGridData();
                Lugares_Frecuentes_InvolucradoClearGridData();
                Datos_Personales_Adicionales_InvolucradoClearGridData();
                Otras_Identificaciones_InvolucradoClearGridData();
                Otros_Domicilios_InvolucradoClearGridData();
    $('#Pais_de_Origen_Tutor').empty();
    $("#Pais_de_Origen_Tutor").append('<option value=""></option>');
    $('#Pais_de_Origen_Tutor').val('0').trigger('change');
    $('#Pais_del_Tutor').empty();
    $("#Pais_del_Tutor").append('<option value=""></option>');
    $('#Pais_del_Tutor').val('0').trigger('change');
    $('#Estado_del_Tutor').empty();
    $("#Estado_del_Tutor").append('<option value=""></option>');
    $('#Estado_del_Tutor').val('0').trigger('change');
    $('#Municipio_del_Tutor').empty();
    $("#Municipio_del_Tutor").append('<option value=""></option>');
    $('#Municipio_del_Tutor').val('0').trigger('change');
    $('#Poblacion_Tutor').empty();
    $("#Poblacion_Tutor").append('<option value=""></option>');
    $('#Poblacion_Tutor').val('0').trigger('change');
    $('#Colonia_del_Tutor').empty();
    $("#Colonia_del_Tutor").append('<option value=""></option>');
    $('#Colonia_del_Tutor').val('0').trigger('change');
    $('#Pais_del_hecho').empty();
    $("#Pais_del_hecho").append('<option value=""></option>');
    $('#Pais_del_hecho').val('0').trigger('change');
    $('#Estado_del_Hecho').empty();
    $("#Estado_del_Hecho").append('<option value=""></option>');
    $('#Estado_del_Hecho').val('0').trigger('change');
    $('#Municipio_de_los_Hechos').empty();
    $("#Municipio_de_los_Hechos").append('<option value=""></option>');
    $('#Municipio_de_los_Hechos').val('0').trigger('change');
    $('#Poblacion_Hechos').empty();
    $("#Poblacion_Hechos").append('<option value=""></option>');
    $('#Poblacion_Hechos').val('0').trigger('change');
    $('#Colonia_de_los_Hechos').empty();
    $("#Colonia_de_los_Hechos").append('<option value=""></option>');
    $('#Colonia_de_los_Hechos').val('0').trigger('change');

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Datos_Generales').trigger('reset');
    $('#CreateDetalle_de_Datos_Generales').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Datos_Generales');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Adicciones_de_InvolucradocountRowsChecked > 0)
    {
        ShowMessagePendingRowAdicciones_de_Involucrado();
        return false;
    }
    if (Lugares_Frecuentes_InvolucradocountRowsChecked > 0)
    {
        ShowMessagePendingRowLugares_Frecuentes_Involucrado();
        return false;
    }
    if (Datos_Personales_Adicionales_InvolucradocountRowsChecked > 0)
    {
        ShowMessagePendingRowDatos_Personales_Adicionales_Involucrado();
        return false;
    }
    if (Otras_Identificaciones_InvolucradocountRowsChecked > 0)
    {
        ShowMessagePendingRowOtras_Identificaciones_Involucrado();
        return false;
    }
    if (Otros_Domicilios_InvolucradocountRowsChecked > 0)
    {
        ShowMessagePendingRowOtros_Domicilios_Involucrado();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Datos_Generales").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Datos_Generales").on('click', '#Detalle_de_Datos_GeneralesCancelar', function () {
	  if (!isPartial) {
        Detalle_de_Datos_GeneralesBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Datos_Generales").on('click', '#Detalle_de_Datos_GeneralesGuardar', function () {
		$('#Detalle_de_Datos_GeneralesGuardar').attr('disabled', true);
		$('#Detalle_de_Datos_GeneralesGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_Datos_GeneralesData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_Datos_GeneralesBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_Datos_GeneralesGuardar').removeAttr('disabled');
                        $('#Detalle_de_Datos_GeneralesGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Datos_Generales', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_GeneralesItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_GeneralesDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Detalle_de_Datos_GeneralesGuardar').removeAttr('disabled');
					$('#Detalle_de_Datos_GeneralesGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_Datos_GeneralesGuardar').removeAttr('disabled');
			$('#Detalle_de_Datos_GeneralesGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Datos_Generales").on('click', '#Detalle_de_Datos_GeneralesGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_Datos_GeneralesData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getAdicciones_de_InvolucradoData();
                getLugares_Frecuentes_InvolucradoData();
                getDatos_Personales_Adicionales_InvolucradoData();
                getOtras_Identificaciones_InvolucradoData();
                getOtros_Domicilios_InvolucradoData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Datos_Generales', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_GeneralesItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_GeneralesDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Datos_Generales").on('click', '#Detalle_de_Datos_GeneralesGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_Datos_GeneralesData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Modulo_Atencion_Inicial').empty();
    $("#Modulo_Atencion_Inicial").append('<option value=""></option>');
    $('#Modulo_Atencion_Inicial').val('0').trigger('change');
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Nacionalidad').empty();
    $("#Nacionalidad").append('<option value=""></option>');
    $('#Nacionalidad').val('0').trigger('change');
    $('#Pais_de_Origen').empty();
    $("#Pais_de_Origen").append('<option value=""></option>');
    $('#Pais_de_Origen').val('0').trigger('change');
    $('#Pais').empty();
    $("#Pais").append('<option value=""></option>');
    $('#Pais').val('0').trigger('change');
    $('#Estado').empty();
    $("#Estado").append('<option value=""></option>');
    $('#Estado').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Poblacion').empty();
    $("#Poblacion").append('<option value=""></option>');
    $('#Poblacion').val('0').trigger('change');
    $('#Colonia').empty();
    $("#Colonia").append('<option value=""></option>');
    $('#Colonia').val('0').trigger('change');
    $('#Estado_de_Nacimiento').empty();
    $("#Estado_de_Nacimiento").append('<option value=""></option>');
    $('#Estado_de_Nacimiento').val('0').trigger('change');
    $('#Municipio_de_Nacimiento').empty();
    $("#Municipio_de_Nacimiento").append('<option value=""></option>');
    $('#Municipio_de_Nacimiento').val('0').trigger('change');
                Adicciones_de_InvolucradoClearGridData();
                Lugares_Frecuentes_InvolucradoClearGridData();
                Datos_Personales_Adicionales_InvolucradoClearGridData();
                Otras_Identificaciones_InvolucradoClearGridData();
                Otros_Domicilios_InvolucradoClearGridData();
    $('#Pais_de_Origen_Tutor').empty();
    $("#Pais_de_Origen_Tutor").append('<option value=""></option>');
    $('#Pais_de_Origen_Tutor').val('0').trigger('change');
    $('#Pais_del_Tutor').empty();
    $("#Pais_del_Tutor").append('<option value=""></option>');
    $('#Pais_del_Tutor').val('0').trigger('change');
    $('#Estado_del_Tutor').empty();
    $("#Estado_del_Tutor").append('<option value=""></option>');
    $('#Estado_del_Tutor').val('0').trigger('change');
    $('#Municipio_del_Tutor').empty();
    $("#Municipio_del_Tutor").append('<option value=""></option>');
    $('#Municipio_del_Tutor').val('0').trigger('change');
    $('#Poblacion_Tutor').empty();
    $("#Poblacion_Tutor").append('<option value=""></option>');
    $('#Poblacion_Tutor').val('0').trigger('change');
    $('#Colonia_del_Tutor').empty();
    $("#Colonia_del_Tutor").append('<option value=""></option>');
    $('#Colonia_del_Tutor').val('0').trigger('change');
    $('#Pais_del_hecho').empty();
    $("#Pais_del_hecho").append('<option value=""></option>');
    $('#Pais_del_hecho').val('0').trigger('change');
    $('#Estado_del_Hecho').empty();
    $("#Estado_del_Hecho").append('<option value=""></option>');
    $('#Estado_del_Hecho').val('0').trigger('change');
    $('#Municipio_de_los_Hechos').empty();
    $("#Municipio_de_los_Hechos").append('<option value=""></option>');
    $('#Municipio_de_los_Hechos').val('0').trigger('change');
    $('#Poblacion_Hechos').empty();
    $("#Poblacion_Hechos").append('<option value=""></option>');
    $('#Poblacion_Hechos').val('0').trigger('change');
    $('#Colonia_de_los_Hechos').empty();
    $("#Colonia_de_los_Hechos").append('<option value=""></option>');
    $('#Colonia_de_los_Hechos').val('0').trigger('change');

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getAdicciones_de_InvolucradoData();
                getLugares_Frecuentes_InvolucradoData();
                getDatos_Personales_Adicionales_InvolucradoData();
                getOtras_Identificaciones_InvolucradoData();
                getOtros_Domicilios_InvolucradoData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Datos_Generales',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_GeneralesItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_GeneralesDropDown().get(0)').innerHTML);                          
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



var Detalle_de_Datos_GeneralesisdisplayBusinessPropery = false;
Detalle_de_Datos_GeneralesDisplayBusinessRuleButtons(Detalle_de_Datos_GeneralesisdisplayBusinessPropery);
function Detalle_de_Datos_GeneralesDisplayBusinessRule() {
    if (!Detalle_de_Datos_GeneralesisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Datos_Generales').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_Datos_GeneralesdisplayBusinessPropery"><button onclick="Detalle_de_Datos_GeneralesGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_Datos_GeneralesBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_Datos_GeneralesdisplayBusinessPropery').remove();
    }
    Detalle_de_Datos_GeneralesDisplayBusinessRuleButtons(!Detalle_de_Datos_GeneralesisdisplayBusinessPropery);
    Detalle_de_Datos_GeneralesisdisplayBusinessPropery = (Detalle_de_Datos_GeneralesisdisplayBusinessPropery ? false : true);
}
function Detalle_de_Datos_GeneralesDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

