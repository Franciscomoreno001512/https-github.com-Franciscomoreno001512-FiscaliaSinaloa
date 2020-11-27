

//Begin Declarations for Foreigns fields for Agravantes_del_Delito MultiRow
var Agravantes_del_DelitocountRowsChecked = 0;

function GetAgravantes_del_Delito_AgravantesName(Id) {
    for (var i = 0; i < Agravantes_del_Delito_AgravantesItems.length; i++) {
        if (Agravantes_del_Delito_AgravantesItems[i].Clave == Id) {
            return Agravantes_del_Delito_AgravantesItems[i].Descripcion;
        }
    }
    return "";
}

function GetAgravantes_del_Delito_AgravantesDropDown() {
    var Agravantes_del_Delito_AgravantesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Agravantes_del_Delito_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Agravantes_del_Delito_AgravantesDropdown);
    if(Agravantes_del_Delito_AgravantesItems != null)
    {
       for (var i = 0; i < Agravantes_del_Delito_AgravantesItems.length; i++) {
           $('<option />', { value: Agravantes_del_Delito_AgravantesItems[i].Clave, text:    Agravantes_del_Delito_AgravantesItems[i].Descripcion }).appendTo(Agravantes_del_Delito_AgravantesDropdown);
       }
    }
    return Agravantes_del_Delito_AgravantesDropdown;
}


function GetInsertAgravantes_del_DelitoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetAgravantes_del_Delito_AgravantesDropDown()).addClass('Agravantes_del_Delito_Agravante Agravante').attr('id', 'Agravantes_del_Delito_Agravante_' + index).attr('data-field', 'Agravante').after($.parseHTML(addNew('Agravantes_del_Delito', 'Agravantes', 'Agravante', 265686)));


    initiateUIControls();
    return columnData;
}

function Agravantes_del_DelitoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRAgravantes_del_Delito("Agravantes_del_Delito_", "_" + rowIndex)) {
    var iPage = Agravantes_del_DelitoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Agravantes_del_Delito';
    var prevData = Agravantes_del_DelitoTable.fnGetData(rowIndex);
    var data = Agravantes_del_DelitoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Agravante:  data.childNodes[counter++].childNodes[0].value

    }
    Agravantes_del_DelitoTable.fnUpdate(newData, rowIndex, null, true);
    Agravantes_del_DelitorowCreationGrid(data, newData, rowIndex);
    Agravantes_del_DelitoTable.fnPageChange(iPage);
    Agravantes_del_DelitocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRAgravantes_del_Delito("Agravantes_del_Delito_", "_" + rowIndex);
  }
}

function Agravantes_del_DelitoCancelRow(rowIndex) {
    var prevData = Agravantes_del_DelitoTable.fnGetData(rowIndex);
    var data = Agravantes_del_DelitoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Agravantes_del_DelitoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Agravantes_del_DelitorowCreationGrid(data, prevData, rowIndex);
    }
	showAgravantes_del_DelitoGrid(Agravantes_del_DelitoTable.fnGetData());
    Agravantes_del_DelitocountRowsChecked--;
	initiateUIControls();
}

function GetAgravantes_del_DelitoFromDataTable() {
    var Agravantes_del_DelitoData = [];
    var gridData = Agravantes_del_DelitoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Agravantes_del_DelitoData.push({
                Clave: gridData[i].Clave

                ,Agravante: gridData[i].Agravante

                ,Removed: false
            });
    }

    for (i = 0; i < removedAgravantes_del_DelitoData.length; i++) {
        if (removedAgravantes_del_DelitoData[i] != null && removedAgravantes_del_DelitoData[i].Clave > 0)
            Agravantes_del_DelitoData.push({
                Clave: removedAgravantes_del_DelitoData[i].Clave

                ,Agravante: removedAgravantes_del_DelitoData[i].Agravante

                , Removed: true
            });
    }	

    return Agravantes_del_DelitoData;
}

function Agravantes_del_DelitoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Agravantes_del_DelitoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Agravantes_del_DelitocountRowsChecked++;
    var Agravantes_del_DelitoRowElement = "Agravantes_del_Delito_" + rowIndex.toString();
    var prevData = Agravantes_del_DelitoTable.fnGetData(rowIndexTable );
    var row = Agravantes_del_DelitoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Agravantes_del_Delito_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Agravantes_del_DelitoGetUpdateRowControls(prevData, "Agravantes_del_Delito_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Agravantes_del_DelitoRowElement + "')){ Agravantes_del_DelitoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Agravantes_del_DelitoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Agravantes_del_DelitoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Agravantes_del_DelitoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setAgravantes_del_DelitoValidation();
    initiateUIControls();
    $('.Agravantes_del_Delito' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRAgravantes_del_Delito(nameOfTable, rowIndexFormed);
    }
}

function Agravantes_del_DelitofnOpenAddRowPopUp() {
    var currentRowIndex = Agravantes_del_DelitoTable.fnGetData().length;
    Agravantes_del_DelitofnClickAddRow();
    GetAddAgravantes_del_DelitoPopup(currentRowIndex, 0);
}

function Agravantes_del_DelitoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Agravantes_del_DelitoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Agravantes_del_DelitoRowElement = "Agravantes_del_Delito_" + rowIndex.toString();
    var prevData = Agravantes_del_DelitoTable.fnGetData(rowIndexTable);
    GetAddAgravantes_del_DelitoPopup(rowIndex, 1, prevData.Clave);

    $('#Agravantes_del_DelitoAgravante').val(prevData.Agravante);

    initiateUIControls();



}

function Agravantes_del_DelitoAddInsertRow() {
    if (Agravantes_del_DelitoinsertRowCurrentIndex < 1)
    {
        Agravantes_del_DelitoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Agravante: ""

    }
}

function Agravantes_del_DelitofnClickAddRow() {
    Agravantes_del_DelitocountRowsChecked++;
    Agravantes_del_DelitoTable.fnAddData(Agravantes_del_DelitoAddInsertRow(), true);
    Agravantes_del_DelitoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Agravantes_del_DelitoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Agravantes_del_DelitoGrid tbody tr:nth-of-type(' + (Agravantes_del_DelitoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRAgravantes_del_Delito("Agravantes_del_Delito_", "_" + Agravantes_del_DelitoinsertRowCurrentIndex);
}

function Agravantes_del_DelitoClearGridData() {
    Agravantes_del_DelitoData = [];
    Agravantes_del_DelitodeletedItem = [];
    Agravantes_del_DelitoDataMain = [];
    Agravantes_del_DelitoDataMainPages = [];
    Agravantes_del_DelitonewItemCount = 0;
    Agravantes_del_DelitomaxItemIndex = 0;
    $("#Agravantes_del_DelitoGrid").DataTable().clear();
    $("#Agravantes_del_DelitoGrid").DataTable().destroy();
}

//Used to Get Delitos AT Information
function GetAgravantes_del_Delito() {
    var form_data = new FormData();
    for (var i = 0; i < Agravantes_del_DelitoData.length; i++) {
        form_data.append('[' + i + '].Clave', Agravantes_del_DelitoData[i].Clave);

        form_data.append('[' + i + '].Agravante', Agravantes_del_DelitoData[i].Agravante);

        form_data.append('[' + i + '].Removed', Agravantes_del_DelitoData[i].Removed);
    }
    return form_data;
}
function Agravantes_del_DelitoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRAgravantes_del_Delito("Agravantes_del_DelitoTable", rowIndex)) {
    var prevData = Agravantes_del_DelitoTable.fnGetData(rowIndex);
    var data = Agravantes_del_DelitoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Agravante: $('#Agravantes_del_DelitoAgravante').val()

    }

    Agravantes_del_DelitoTable.fnUpdate(newData, rowIndex, null, true);
    Agravantes_del_DelitorowCreationGrid(data, newData, rowIndex);
    $('#AddAgravantes_del_Delito-form').modal({ show: false });
    $('#AddAgravantes_del_Delito-form').modal('hide');
    Agravantes_del_DelitoEditRow(rowIndex);
    Agravantes_del_DelitoInsertRow(rowIndex);
    //}
}
function Agravantes_del_DelitoRemoveAddRow(rowIndex) {
    Agravantes_del_DelitoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Agravantes_del_Delito MultiRow
//Begin Declarations for Foreigns fields for Circunstancias_del_Delito MultiRow
var Circunstancias_del_DelitocountRowsChecked = 0;

function GetCircunstancias_del_Delito_Tipo_de_Lugar_del_RoboName(Id) {
    for (var i = 0; i < Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboItems.length; i++) {
        if (Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboItems[i].Clave == Id) {
            return Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboItems[i].Descripcion;
        }
    }
    return "";
}

function GetCircunstancias_del_Delito_Tipo_de_Lugar_del_RoboDropDown() {
    var Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboDropdown = $('<select class="form-control" />');      var labelSelect = $("#Circunstancias_del_Delito_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboDropdown);
    if(Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboItems != null)
    {
       for (var i = 0; i < Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboItems.length; i++) {
           $('<option />', { value: Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboItems[i].Clave, text:    Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboItems[i].Descripcion }).appendTo(Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboDropdown);
       }
    }
    return Circunstancias_del_Delito_Tipo_de_Lugar_del_RoboDropdown;
}


function GetInsertCircunstancias_del_DelitoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetCircunstancias_del_Delito_Tipo_de_Lugar_del_RoboDropDown()).addClass('Circunstancias_del_Delito_Tipo_de_Lugar Tipo_de_Lugar').attr('id', 'Circunstancias_del_Delito_Tipo_de_Lugar_' + index).attr('data-field', 'Tipo_de_Lugar').after($.parseHTML(addNew('Circunstancias_del_Delito', 'Tipo_de_Lugar_del_Robo', 'Tipo_de_Lugar', 265689)));


    initiateUIControls();
    return columnData;
}

function Circunstancias_del_DelitoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRCircunstancias_del_Delito("Circunstancias_del_Delito_", "_" + rowIndex)) {
    var iPage = Circunstancias_del_DelitoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Circunstancias_del_Delito';
    var prevData = Circunstancias_del_DelitoTable.fnGetData(rowIndex);
    var data = Circunstancias_del_DelitoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Lugar:  data.childNodes[counter++].childNodes[0].value

    }
    Circunstancias_del_DelitoTable.fnUpdate(newData, rowIndex, null, true);
    Circunstancias_del_DelitorowCreationGrid(data, newData, rowIndex);
    Circunstancias_del_DelitoTable.fnPageChange(iPage);
    Circunstancias_del_DelitocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRCircunstancias_del_Delito("Circunstancias_del_Delito_", "_" + rowIndex);
  }
}

function Circunstancias_del_DelitoCancelRow(rowIndex) {
    var prevData = Circunstancias_del_DelitoTable.fnGetData(rowIndex);
    var data = Circunstancias_del_DelitoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Circunstancias_del_DelitoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Circunstancias_del_DelitorowCreationGrid(data, prevData, rowIndex);
    }
	showCircunstancias_del_DelitoGrid(Circunstancias_del_DelitoTable.fnGetData());
    Circunstancias_del_DelitocountRowsChecked--;
	initiateUIControls();
}

function GetCircunstancias_del_DelitoFromDataTable() {
    var Circunstancias_del_DelitoData = [];
    var gridData = Circunstancias_del_DelitoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Circunstancias_del_DelitoData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Lugar: gridData[i].Tipo_de_Lugar

                ,Removed: false
            });
    }

    for (i = 0; i < removedCircunstancias_del_DelitoData.length; i++) {
        if (removedCircunstancias_del_DelitoData[i] != null && removedCircunstancias_del_DelitoData[i].Clave > 0)
            Circunstancias_del_DelitoData.push({
                Clave: removedCircunstancias_del_DelitoData[i].Clave

                ,Tipo_de_Lugar: removedCircunstancias_del_DelitoData[i].Tipo_de_Lugar

                , Removed: true
            });
    }	

    return Circunstancias_del_DelitoData;
}

function Circunstancias_del_DelitoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Circunstancias_del_DelitoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Circunstancias_del_DelitocountRowsChecked++;
    var Circunstancias_del_DelitoRowElement = "Circunstancias_del_Delito_" + rowIndex.toString();
    var prevData = Circunstancias_del_DelitoTable.fnGetData(rowIndexTable );
    var row = Circunstancias_del_DelitoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Circunstancias_del_Delito_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Circunstancias_del_DelitoGetUpdateRowControls(prevData, "Circunstancias_del_Delito_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Circunstancias_del_DelitoRowElement + "')){ Circunstancias_del_DelitoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Circunstancias_del_DelitoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Circunstancias_del_DelitoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Circunstancias_del_DelitoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setCircunstancias_del_DelitoValidation();
    initiateUIControls();
    $('.Circunstancias_del_Delito' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRCircunstancias_del_Delito(nameOfTable, rowIndexFormed);
    }
}

function Circunstancias_del_DelitofnOpenAddRowPopUp() {
    var currentRowIndex = Circunstancias_del_DelitoTable.fnGetData().length;
    Circunstancias_del_DelitofnClickAddRow();
    GetAddCircunstancias_del_DelitoPopup(currentRowIndex, 0);
}

function Circunstancias_del_DelitoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Circunstancias_del_DelitoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Circunstancias_del_DelitoRowElement = "Circunstancias_del_Delito_" + rowIndex.toString();
    var prevData = Circunstancias_del_DelitoTable.fnGetData(rowIndexTable);
    GetAddCircunstancias_del_DelitoPopup(rowIndex, 1, prevData.Clave);

    $('#Circunstancias_del_DelitoTipo_de_Lugar').val(prevData.Tipo_de_Lugar);

    initiateUIControls();



}

function Circunstancias_del_DelitoAddInsertRow() {
    if (Circunstancias_del_DelitoinsertRowCurrentIndex < 1)
    {
        Circunstancias_del_DelitoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Lugar: ""

    }
}

function Circunstancias_del_DelitofnClickAddRow() {
    Circunstancias_del_DelitocountRowsChecked++;
    Circunstancias_del_DelitoTable.fnAddData(Circunstancias_del_DelitoAddInsertRow(), true);
    Circunstancias_del_DelitoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Circunstancias_del_DelitoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Circunstancias_del_DelitoGrid tbody tr:nth-of-type(' + (Circunstancias_del_DelitoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRCircunstancias_del_Delito("Circunstancias_del_Delito_", "_" + Circunstancias_del_DelitoinsertRowCurrentIndex);
}

function Circunstancias_del_DelitoClearGridData() {
    Circunstancias_del_DelitoData = [];
    Circunstancias_del_DelitodeletedItem = [];
    Circunstancias_del_DelitoDataMain = [];
    Circunstancias_del_DelitoDataMainPages = [];
    Circunstancias_del_DelitonewItemCount = 0;
    Circunstancias_del_DelitomaxItemIndex = 0;
    $("#Circunstancias_del_DelitoGrid").DataTable().clear();
    $("#Circunstancias_del_DelitoGrid").DataTable().destroy();
}

//Used to Get Delitos AT Information
function GetCircunstancias_del_Delito() {
    var form_data = new FormData();
    for (var i = 0; i < Circunstancias_del_DelitoData.length; i++) {
        form_data.append('[' + i + '].Clave', Circunstancias_del_DelitoData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Lugar', Circunstancias_del_DelitoData[i].Tipo_de_Lugar);

        form_data.append('[' + i + '].Removed', Circunstancias_del_DelitoData[i].Removed);
    }
    return form_data;
}
function Circunstancias_del_DelitoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRCircunstancias_del_Delito("Circunstancias_del_DelitoTable", rowIndex)) {
    var prevData = Circunstancias_del_DelitoTable.fnGetData(rowIndex);
    var data = Circunstancias_del_DelitoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Lugar: $('#Circunstancias_del_DelitoTipo_de_Lugar').val()

    }

    Circunstancias_del_DelitoTable.fnUpdate(newData, rowIndex, null, true);
    Circunstancias_del_DelitorowCreationGrid(data, newData, rowIndex);
    $('#AddCircunstancias_del_Delito-form').modal({ show: false });
    $('#AddCircunstancias_del_Delito-form').modal('hide');
    Circunstancias_del_DelitoEditRow(rowIndex);
    Circunstancias_del_DelitoInsertRow(rowIndex);
    //}
}
function Circunstancias_del_DelitoRemoveAddRow(rowIndex) {
    Circunstancias_del_DelitoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Circunstancias_del_Delito MultiRow


$(function () {
    function Agravantes_del_DelitoinitializeMainArray(totalCount) {
        if (Agravantes_del_DelitoDataMain.length != totalCount && !Agravantes_del_DelitoDataMainInitialized) {
            Agravantes_del_DelitoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Agravantes_del_DelitoDataMain[i] = null;
            }
        }
    }
    function Agravantes_del_DelitoremoveFromMainArray() {
        for (var j = 0; j < Agravantes_del_DelitodeletedItem.length; j++) {
            for (var i = 0; i < Agravantes_del_DelitoDataMain.length; i++) {
                if (Agravantes_del_DelitoDataMain[i] != null && Agravantes_del_DelitoDataMain[i].Id == Agravantes_del_DelitodeletedItem[j]) {
                    hAgravantes_del_DelitoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Agravantes_del_DelitocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Agravantes_del_DelitoDataMain.length; i++) {
            data[i] = Agravantes_del_DelitoDataMain[i];

        }
        return data;
    }
    function Agravantes_del_DelitogetNewResult() {
        var newData = copyMainAgravantes_del_DelitoArray();

        for (var i = 0; i < Agravantes_del_DelitoData.length; i++) {
            if (Agravantes_del_DelitoData[i].Removed == null || Agravantes_del_DelitoData[i].Removed == false) {
                newData.splice(0, 0, Agravantes_del_DelitoData[i]);
            }
        }
        return newData;
    }
    function Agravantes_del_DelitopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Agravantes_del_DelitoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Agravantes_del_DelitoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Circunstancias_del_DelitoinitializeMainArray(totalCount) {
        if (Circunstancias_del_DelitoDataMain.length != totalCount && !Circunstancias_del_DelitoDataMainInitialized) {
            Circunstancias_del_DelitoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Circunstancias_del_DelitoDataMain[i] = null;
            }
        }
    }
    function Circunstancias_del_DelitoremoveFromMainArray() {
        for (var j = 0; j < Circunstancias_del_DelitodeletedItem.length; j++) {
            for (var i = 0; i < Circunstancias_del_DelitoDataMain.length; i++) {
                if (Circunstancias_del_DelitoDataMain[i] != null && Circunstancias_del_DelitoDataMain[i].Id == Circunstancias_del_DelitodeletedItem[j]) {
                    hCircunstancias_del_DelitoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Circunstancias_del_DelitocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Circunstancias_del_DelitoDataMain.length; i++) {
            data[i] = Circunstancias_del_DelitoDataMain[i];

        }
        return data;
    }
    function Circunstancias_del_DelitogetNewResult() {
        var newData = copyMainCircunstancias_del_DelitoArray();

        for (var i = 0; i < Circunstancias_del_DelitoData.length; i++) {
            if (Circunstancias_del_DelitoData[i].Removed == null || Circunstancias_del_DelitoData[i].Removed == false) {
                newData.splice(0, 0, Circunstancias_del_DelitoData[i]);
            }
        }
        return newData;
    }
    function Circunstancias_del_DelitopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Circunstancias_del_DelitoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Circunstancias_del_DelitoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteExpediente_InicialData = [];
function GetAutoCompleteDetalle_de_Delito_Expediente_Inicial_Modulo_Atencion_InicialData(data) {
	AutoCompleteExpediente_InicialData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_InicialData.push({
            id: data[i].Clave,
            text: data[i].NUAT
        });
    }
    return AutoCompleteExpediente_InicialData;
}
var AutoCompleteExpediente_MPData = [];
function GetAutoCompleteDetalle_de_Delito_Expediente_MP_expediente_ministerio_publicoData(data) {
	AutoCompleteExpediente_MPData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MPData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteExpediente_MPData;
}
//Grid GetAutocomplete

//Grid GetAutocomplete

var AutoCompleteEstado_del_DelitoData = [];
function GetAutoCompleteDetalle_de_Delito_Estado_del_Delito_EstadoData(data) {
	AutoCompleteEstado_del_DelitoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_del_DelitoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_del_DelitoData;
}
var AutoCompleteMunicipio_del_DelitoData = [];
function GetAutoCompleteDetalle_de_Delito_Municipio_del_Delito_MunicipioData(data) {
	AutoCompleteMunicipio_del_DelitoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_del_DelitoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_del_DelitoData;
}
var AutoCompleteColonia_del_DelitoData = [];
function GetAutoCompleteDetalle_de_Delito_Colonia_del_Delito_ColoniaData(data) {
	AutoCompleteColonia_del_DelitoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_del_DelitoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_del_DelitoData;
}
var AutoCompleteEstado_de_Origen_de_las_PlacasData = [];
function GetAutoCompleteDetalle_de_Delito_Estado_de_Origen_de_las_Placas_EstadoData(data) {
	AutoCompleteEstado_de_Origen_de_las_PlacasData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_de_Origen_de_las_PlacasData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_de_Origen_de_las_PlacasData;
}
var AutoCompleteEstado_del_RoboData = [];
function GetAutoCompleteDetalle_de_Delito_Estado_del_Robo_EstadoData(data) {
	AutoCompleteEstado_del_RoboData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_del_RoboData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_del_RoboData;
}
var AutoCompleteMunicipio_del_RoboData = [];
function GetAutoCompleteDetalle_de_Delito_Municipio_del_Robo_MunicipioData(data) {
	AutoCompleteMunicipio_del_RoboData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_del_RoboData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_del_RoboData;
}
var AutoCompleteColonia_del_RoboData = [];
function GetAutoCompleteDetalle_de_Delito_Colonia_del_Robo_ColoniaData(data) {
	AutoCompleteColonia_del_RoboData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_del_RoboData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_del_RoboData;
}
var AutoCompletePaisData = [];
function GetAutoCompleteDetalle_de_Delito_Pais_PaisData(data) {
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
function GetAutoCompleteDetalle_de_Delito_Estado_EstadoData(data) {
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
function GetAutoCompleteDetalle_de_Delito_Municipio_MunicipioData(data) {
	AutoCompleteMunicipioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioData;
}
var AutoCompleteColoniaData = [];
function GetAutoCompleteDetalle_de_Delito_Colonia_ColoniaData(data) {
	AutoCompleteColoniaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Delito_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Delito')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Expediente_Inicial').empty();
    $("#Expediente_Inicial").append('<option value=""></option>');
    $('#Expediente_Inicial').val('0').trigger('change');
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
                Agravantes_del_DelitoClearGridData();
                Circunstancias_del_DelitoClearGridData();
    $('#Estado_del_Delito').empty();
    $("#Estado_del_Delito").append('<option value=""></option>');
    $('#Estado_del_Delito').val('0').trigger('change');
    $('#Municipio_del_Delito').empty();
    $("#Municipio_del_Delito").append('<option value=""></option>');
    $('#Municipio_del_Delito').val('0').trigger('change');
    $('#Colonia_del_Delito').empty();
    $("#Colonia_del_Delito").append('<option value=""></option>');
    $('#Colonia_del_Delito').val('0').trigger('change');
    $('#Estado_de_Origen_de_las_Placas').empty();
    $("#Estado_de_Origen_de_las_Placas").append('<option value=""></option>');
    $('#Estado_de_Origen_de_las_Placas').val('0').trigger('change');
    $('#Estado_del_Robo').empty();
    $("#Estado_del_Robo").append('<option value=""></option>');
    $('#Estado_del_Robo').val('0').trigger('change');
    $('#Municipio_del_Robo').empty();
    $("#Municipio_del_Robo").append('<option value=""></option>');
    $('#Municipio_del_Robo').val('0').trigger('change');
    $('#Colonia_del_Robo').empty();
    $("#Colonia_del_Robo").append('<option value=""></option>');
    $('#Colonia_del_Robo').val('0').trigger('change');
    $('#Pais').empty();
    $("#Pais").append('<option value=""></option>');
    $('#Pais').val('0').trigger('change');
    $('#Estado').empty();
    $("#Estado").append('<option value=""></option>');
    $('#Estado').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Colonia').empty();
    $("#Colonia").append('<option value=""></option>');
    $('#Colonia').val('0').trigger('change');

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Delito').trigger('reset');
    $('#CreateDetalle_de_Delito').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Delito');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Agravantes_del_DelitocountRowsChecked > 0)
    {
        ShowMessagePendingRowAgravantes_del_Delito();
        return false;
    }
    if (Circunstancias_del_DelitocountRowsChecked > 0)
    {
        ShowMessagePendingRowCircunstancias_del_Delito();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Delito").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Delito").on('click', '#Detalle_de_DelitoCancelar', function () {
	  if (!isPartial) {
        Detalle_de_DelitoBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Delito").on('click', '#Detalle_de_DelitoGuardar', function () {
		$('#Detalle_de_DelitoGuardar').attr('disabled', true);
		$('#Detalle_de_DelitoGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_DelitoData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_DelitoBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_DelitoGuardar').removeAttr('disabled');
                        $('#Detalle_de_DelitoGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Delito', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_DelitoItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_DelitoDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Detalle_de_DelitoGuardar').removeAttr('disabled');
					$('#Detalle_de_DelitoGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_DelitoGuardar').removeAttr('disabled');
			$('#Detalle_de_DelitoGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Delito").on('click', '#Detalle_de_DelitoGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_DelitoData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getAgravantes_del_DelitoData();
                getCircunstancias_del_DelitoData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Delito', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_DelitoItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_DelitoDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Delito").on('click', '#Detalle_de_DelitoGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_DelitoData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Expediente_Inicial').empty();
    $("#Expediente_Inicial").append('<option value=""></option>');
    $('#Expediente_Inicial').val('0').trigger('change');
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
                Agravantes_del_DelitoClearGridData();
                Circunstancias_del_DelitoClearGridData();
    $('#Estado_del_Delito').empty();
    $("#Estado_del_Delito").append('<option value=""></option>');
    $('#Estado_del_Delito').val('0').trigger('change');
    $('#Municipio_del_Delito').empty();
    $("#Municipio_del_Delito").append('<option value=""></option>');
    $('#Municipio_del_Delito').val('0').trigger('change');
    $('#Colonia_del_Delito').empty();
    $("#Colonia_del_Delito").append('<option value=""></option>');
    $('#Colonia_del_Delito').val('0').trigger('change');
    $('#Estado_de_Origen_de_las_Placas').empty();
    $("#Estado_de_Origen_de_las_Placas").append('<option value=""></option>');
    $('#Estado_de_Origen_de_las_Placas').val('0').trigger('change');
    $('#Estado_del_Robo').empty();
    $("#Estado_del_Robo").append('<option value=""></option>');
    $('#Estado_del_Robo').val('0').trigger('change');
    $('#Municipio_del_Robo').empty();
    $("#Municipio_del_Robo").append('<option value=""></option>');
    $('#Municipio_del_Robo').val('0').trigger('change');
    $('#Colonia_del_Robo').empty();
    $("#Colonia_del_Robo").append('<option value=""></option>');
    $('#Colonia_del_Robo').val('0').trigger('change');
    $('#Pais').empty();
    $("#Pais").append('<option value=""></option>');
    $('#Pais').val('0').trigger('change');
    $('#Estado').empty();
    $("#Estado").append('<option value=""></option>');
    $('#Estado').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Colonia').empty();
    $("#Colonia").append('<option value=""></option>');
    $('#Colonia').val('0').trigger('change');

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getAgravantes_del_DelitoData();
                getCircunstancias_del_DelitoData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Delito',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_DelitoItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_DelitoDropDown().get(0)').innerHTML);                          
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



var Detalle_de_DelitoisdisplayBusinessPropery = false;
Detalle_de_DelitoDisplayBusinessRuleButtons(Detalle_de_DelitoisdisplayBusinessPropery);
function Detalle_de_DelitoDisplayBusinessRule() {
    if (!Detalle_de_DelitoisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Delito').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_DelitodisplayBusinessPropery"><button onclick="Detalle_de_DelitoGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_DelitoBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_DelitodisplayBusinessPropery').remove();
    }
    Detalle_de_DelitoDisplayBusinessRuleButtons(!Detalle_de_DelitoisdisplayBusinessPropery);
    Detalle_de_DelitoisdisplayBusinessPropery = (Detalle_de_DelitoisdisplayBusinessPropery ? false : true);
}
function Detalle_de_DelitoDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

