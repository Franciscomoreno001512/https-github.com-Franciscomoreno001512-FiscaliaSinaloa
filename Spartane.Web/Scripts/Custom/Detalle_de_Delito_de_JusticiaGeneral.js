

//Begin Declarations for Foreigns fields for Agravantes_del_Delito_MASC MultiRow
var Agravantes_del_Delito_MASCcountRowsChecked = 0;

function GetAgravantes_del_Delito_MASC_AgravantesName(Id) {
    for (var i = 0; i < Agravantes_del_Delito_MASC_AgravantesItems.length; i++) {
        if (Agravantes_del_Delito_MASC_AgravantesItems[i].Clave == Id) {
            return Agravantes_del_Delito_MASC_AgravantesItems[i].Descripcion;
        }
    }
    return "";
}

function GetAgravantes_del_Delito_MASC_AgravantesDropDown() {
    var Agravantes_del_Delito_MASC_AgravantesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Agravantes_del_Delito_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Agravantes_del_Delito_MASC_AgravantesDropdown);
    if(Agravantes_del_Delito_MASC_AgravantesItems != null)
    {
       for (var i = 0; i < Agravantes_del_Delito_MASC_AgravantesItems.length; i++) {
           $('<option />', { value: Agravantes_del_Delito_MASC_AgravantesItems[i].Clave, text:    Agravantes_del_Delito_MASC_AgravantesItems[i].Descripcion }).appendTo(Agravantes_del_Delito_MASC_AgravantesDropdown);
       }
    }
    return Agravantes_del_Delito_MASC_AgravantesDropdown;
}


function GetInsertAgravantes_del_Delito_MASCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetAgravantes_del_Delito_MASC_AgravantesDropDown()).addClass('Agravantes_del_Delito_MASC_Agravante Agravante').attr('id', 'Agravantes_del_Delito_MASC_Agravante_' + index).attr('data-field', 'Agravante').after($.parseHTML(addNew('Agravantes_del_Delito_MASC', 'Agravantes', 'Agravante', 265903)));


    initiateUIControls();
    return columnData;
}

function Agravantes_del_Delito_MASCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRAgravantes_del_Delito_MASC("Agravantes_del_Delito_MASC_", "_" + rowIndex)) {
    var iPage = Agravantes_del_Delito_MASCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Agravantes_del_Delito_MASC';
    var prevData = Agravantes_del_Delito_MASCTable.fnGetData(rowIndex);
    var data = Agravantes_del_Delito_MASCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Agravante:  data.childNodes[counter++].childNodes[0].value

    }
    Agravantes_del_Delito_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Agravantes_del_Delito_MASCrowCreationGrid(data, newData, rowIndex);
    Agravantes_del_Delito_MASCTable.fnPageChange(iPage);
    Agravantes_del_Delito_MASCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRAgravantes_del_Delito_MASC("Agravantes_del_Delito_MASC_", "_" + rowIndex);
  }
}

function Agravantes_del_Delito_MASCCancelRow(rowIndex) {
    var prevData = Agravantes_del_Delito_MASCTable.fnGetData(rowIndex);
    var data = Agravantes_del_Delito_MASCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Agravantes_del_Delito_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Agravantes_del_Delito_MASCrowCreationGrid(data, prevData, rowIndex);
    }
	showAgravantes_del_Delito_MASCGrid(Agravantes_del_Delito_MASCTable.fnGetData());
    Agravantes_del_Delito_MASCcountRowsChecked--;
	initiateUIControls();
}

function GetAgravantes_del_Delito_MASCFromDataTable() {
    var Agravantes_del_Delito_MASCData = [];
    var gridData = Agravantes_del_Delito_MASCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Agravantes_del_Delito_MASCData.push({
                Clave: gridData[i].Clave

                ,Agravante: gridData[i].Agravante

                ,Removed: false
            });
    }

    for (i = 0; i < removedAgravantes_del_Delito_MASCData.length; i++) {
        if (removedAgravantes_del_Delito_MASCData[i] != null && removedAgravantes_del_Delito_MASCData[i].Clave > 0)
            Agravantes_del_Delito_MASCData.push({
                Clave: removedAgravantes_del_Delito_MASCData[i].Clave

                ,Agravante: removedAgravantes_del_Delito_MASCData[i].Agravante

                , Removed: true
            });
    }	

    return Agravantes_del_Delito_MASCData;
}

function Agravantes_del_Delito_MASCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Agravantes_del_Delito_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Agravantes_del_Delito_MASCcountRowsChecked++;
    var Agravantes_del_Delito_MASCRowElement = "Agravantes_del_Delito_MASC_" + rowIndex.toString();
    var prevData = Agravantes_del_Delito_MASCTable.fnGetData(rowIndexTable );
    var row = Agravantes_del_Delito_MASCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Agravantes_del_Delito_MASC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Agravantes_del_Delito_MASCGetUpdateRowControls(prevData, "Agravantes_del_Delito_MASC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Agravantes_del_Delito_MASCRowElement + "')){ Agravantes_del_Delito_MASCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Agravantes_del_Delito_MASCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Agravantes_del_Delito_MASCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Agravantes_del_Delito_MASCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setAgravantes_del_Delito_MASCValidation();
    initiateUIControls();
    $('.Agravantes_del_Delito_MASC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRAgravantes_del_Delito_MASC(nameOfTable, rowIndexFormed);
    }
}

function Agravantes_del_Delito_MASCfnOpenAddRowPopUp() {
    var currentRowIndex = Agravantes_del_Delito_MASCTable.fnGetData().length;
    Agravantes_del_Delito_MASCfnClickAddRow();
    GetAddAgravantes_del_Delito_MASCPopup(currentRowIndex, 0);
}

function Agravantes_del_Delito_MASCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Agravantes_del_Delito_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Agravantes_del_Delito_MASCRowElement = "Agravantes_del_Delito_MASC_" + rowIndex.toString();
    var prevData = Agravantes_del_Delito_MASCTable.fnGetData(rowIndexTable);
    GetAddAgravantes_del_Delito_MASCPopup(rowIndex, 1, prevData.Clave);

    $('#Agravantes_del_Delito_MASCAgravante').val(prevData.Agravante);

    initiateUIControls();



}

function Agravantes_del_Delito_MASCAddInsertRow() {
    if (Agravantes_del_Delito_MASCinsertRowCurrentIndex < 1)
    {
        Agravantes_del_Delito_MASCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Agravante: ""

    }
}

function Agravantes_del_Delito_MASCfnClickAddRow() {
    Agravantes_del_Delito_MASCcountRowsChecked++;
    Agravantes_del_Delito_MASCTable.fnAddData(Agravantes_del_Delito_MASCAddInsertRow(), true);
    Agravantes_del_Delito_MASCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Agravantes_del_Delito_MASCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Agravantes_del_Delito_MASCGrid tbody tr:nth-of-type(' + (Agravantes_del_Delito_MASCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRAgravantes_del_Delito_MASC("Agravantes_del_Delito_MASC_", "_" + Agravantes_del_Delito_MASCinsertRowCurrentIndex);
}

function Agravantes_del_Delito_MASCClearGridData() {
    Agravantes_del_Delito_MASCData = [];
    Agravantes_del_Delito_MASCdeletedItem = [];
    Agravantes_del_Delito_MASCDataMain = [];
    Agravantes_del_Delito_MASCDataMainPages = [];
    Agravantes_del_Delito_MASCnewItemCount = 0;
    Agravantes_del_Delito_MASCmaxItemIndex = 0;
    $("#Agravantes_del_Delito_MASCGrid").DataTable().clear();
    $("#Agravantes_del_Delito_MASCGrid").DataTable().destroy();
}

//Used to Get Delitos Information
function GetAgravantes_del_Delito_MASC() {
    var form_data = new FormData();
    for (var i = 0; i < Agravantes_del_Delito_MASCData.length; i++) {
        form_data.append('[' + i + '].Clave', Agravantes_del_Delito_MASCData[i].Clave);

        form_data.append('[' + i + '].Agravante', Agravantes_del_Delito_MASCData[i].Agravante);

        form_data.append('[' + i + '].Removed', Agravantes_del_Delito_MASCData[i].Removed);
    }
    return form_data;
}
function Agravantes_del_Delito_MASCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRAgravantes_del_Delito_MASC("Agravantes_del_Delito_MASCTable", rowIndex)) {
    var prevData = Agravantes_del_Delito_MASCTable.fnGetData(rowIndex);
    var data = Agravantes_del_Delito_MASCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Agravante: $('#Agravantes_del_Delito_MASCAgravante').val()

    }

    Agravantes_del_Delito_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Agravantes_del_Delito_MASCrowCreationGrid(data, newData, rowIndex);
    $('#AddAgravantes_del_Delito_MASC-form').modal({ show: false });
    $('#AddAgravantes_del_Delito_MASC-form').modal('hide');
    Agravantes_del_Delito_MASCEditRow(rowIndex);
    Agravantes_del_Delito_MASCInsertRow(rowIndex);
    //}
}
function Agravantes_del_Delito_MASCRemoveAddRow(rowIndex) {
    Agravantes_del_Delito_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Agravantes_del_Delito_MASC MultiRow
//Begin Declarations for Foreigns fields for Circunstancias_del_Delito_MASC MultiRow
var Circunstancias_del_Delito_MASCcountRowsChecked = 0;

function GetCircunstancias_del_Delito_MASC_CircunstanciasName(Id) {
    for (var i = 0; i < Circunstancias_del_Delito_MASC_CircunstanciasItems.length; i++) {
        if (Circunstancias_del_Delito_MASC_CircunstanciasItems[i].Clave == Id) {
            return Circunstancias_del_Delito_MASC_CircunstanciasItems[i].Descripcion;
        }
    }
    return "";
}

function GetCircunstancias_del_Delito_MASC_CircunstanciasDropDown() {
    var Circunstancias_del_Delito_MASC_CircunstanciasDropdown = $('<select class="form-control" />');      var labelSelect = $("#Circunstancias_del_Delito_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Circunstancias_del_Delito_MASC_CircunstanciasDropdown);
    if(Circunstancias_del_Delito_MASC_CircunstanciasItems != null)
    {
       for (var i = 0; i < Circunstancias_del_Delito_MASC_CircunstanciasItems.length; i++) {
           $('<option />', { value: Circunstancias_del_Delito_MASC_CircunstanciasItems[i].Clave, text:    Circunstancias_del_Delito_MASC_CircunstanciasItems[i].Descripcion }).appendTo(Circunstancias_del_Delito_MASC_CircunstanciasDropdown);
       }
    }
    return Circunstancias_del_Delito_MASC_CircunstanciasDropdown;
}


function GetInsertCircunstancias_del_Delito_MASCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetCircunstancias_del_Delito_MASC_CircunstanciasDropDown()).addClass('Circunstancias_del_Delito_MASC_Tipo_de_Lugar Tipo_de_Lugar').attr('id', 'Circunstancias_del_Delito_MASC_Tipo_de_Lugar_' + index).attr('data-field', 'Tipo_de_Lugar').after($.parseHTML(addNew('Circunstancias_del_Delito_MASC', 'Circunstancias', 'Tipo_de_Lugar', 265907)));


    initiateUIControls();
    return columnData;
}

function Circunstancias_del_Delito_MASCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRCircunstancias_del_Delito_MASC("Circunstancias_del_Delito_MASC_", "_" + rowIndex)) {
    var iPage = Circunstancias_del_Delito_MASCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Circunstancias_del_Delito_MASC';
    var prevData = Circunstancias_del_Delito_MASCTable.fnGetData(rowIndex);
    var data = Circunstancias_del_Delito_MASCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Lugar:  data.childNodes[counter++].childNodes[0].value

    }
    Circunstancias_del_Delito_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Circunstancias_del_Delito_MASCrowCreationGrid(data, newData, rowIndex);
    Circunstancias_del_Delito_MASCTable.fnPageChange(iPage);
    Circunstancias_del_Delito_MASCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRCircunstancias_del_Delito_MASC("Circunstancias_del_Delito_MASC_", "_" + rowIndex);
  }
}

function Circunstancias_del_Delito_MASCCancelRow(rowIndex) {
    var prevData = Circunstancias_del_Delito_MASCTable.fnGetData(rowIndex);
    var data = Circunstancias_del_Delito_MASCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Circunstancias_del_Delito_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Circunstancias_del_Delito_MASCrowCreationGrid(data, prevData, rowIndex);
    }
	showCircunstancias_del_Delito_MASCGrid(Circunstancias_del_Delito_MASCTable.fnGetData());
    Circunstancias_del_Delito_MASCcountRowsChecked--;
	initiateUIControls();
}

function GetCircunstancias_del_Delito_MASCFromDataTable() {
    var Circunstancias_del_Delito_MASCData = [];
    var gridData = Circunstancias_del_Delito_MASCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Circunstancias_del_Delito_MASCData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Lugar: gridData[i].Tipo_de_Lugar

                ,Removed: false
            });
    }

    for (i = 0; i < removedCircunstancias_del_Delito_MASCData.length; i++) {
        if (removedCircunstancias_del_Delito_MASCData[i] != null && removedCircunstancias_del_Delito_MASCData[i].Clave > 0)
            Circunstancias_del_Delito_MASCData.push({
                Clave: removedCircunstancias_del_Delito_MASCData[i].Clave

                ,Tipo_de_Lugar: removedCircunstancias_del_Delito_MASCData[i].Tipo_de_Lugar

                , Removed: true
            });
    }	

    return Circunstancias_del_Delito_MASCData;
}

function Circunstancias_del_Delito_MASCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Circunstancias_del_Delito_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Circunstancias_del_Delito_MASCcountRowsChecked++;
    var Circunstancias_del_Delito_MASCRowElement = "Circunstancias_del_Delito_MASC_" + rowIndex.toString();
    var prevData = Circunstancias_del_Delito_MASCTable.fnGetData(rowIndexTable );
    var row = Circunstancias_del_Delito_MASCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Circunstancias_del_Delito_MASC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Circunstancias_del_Delito_MASCGetUpdateRowControls(prevData, "Circunstancias_del_Delito_MASC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Circunstancias_del_Delito_MASCRowElement + "')){ Circunstancias_del_Delito_MASCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Circunstancias_del_Delito_MASCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Circunstancias_del_Delito_MASCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Circunstancias_del_Delito_MASCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setCircunstancias_del_Delito_MASCValidation();
    initiateUIControls();
    $('.Circunstancias_del_Delito_MASC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRCircunstancias_del_Delito_MASC(nameOfTable, rowIndexFormed);
    }
}

function Circunstancias_del_Delito_MASCfnOpenAddRowPopUp() {
    var currentRowIndex = Circunstancias_del_Delito_MASCTable.fnGetData().length;
    Circunstancias_del_Delito_MASCfnClickAddRow();
    GetAddCircunstancias_del_Delito_MASCPopup(currentRowIndex, 0);
}

function Circunstancias_del_Delito_MASCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Circunstancias_del_Delito_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Circunstancias_del_Delito_MASCRowElement = "Circunstancias_del_Delito_MASC_" + rowIndex.toString();
    var prevData = Circunstancias_del_Delito_MASCTable.fnGetData(rowIndexTable);
    GetAddCircunstancias_del_Delito_MASCPopup(rowIndex, 1, prevData.Clave);

    $('#Circunstancias_del_Delito_MASCTipo_de_Lugar').val(prevData.Tipo_de_Lugar);

    initiateUIControls();



}

function Circunstancias_del_Delito_MASCAddInsertRow() {
    if (Circunstancias_del_Delito_MASCinsertRowCurrentIndex < 1)
    {
        Circunstancias_del_Delito_MASCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Lugar: ""

    }
}

function Circunstancias_del_Delito_MASCfnClickAddRow() {
    Circunstancias_del_Delito_MASCcountRowsChecked++;
    Circunstancias_del_Delito_MASCTable.fnAddData(Circunstancias_del_Delito_MASCAddInsertRow(), true);
    Circunstancias_del_Delito_MASCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Circunstancias_del_Delito_MASCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Circunstancias_del_Delito_MASCGrid tbody tr:nth-of-type(' + (Circunstancias_del_Delito_MASCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRCircunstancias_del_Delito_MASC("Circunstancias_del_Delito_MASC_", "_" + Circunstancias_del_Delito_MASCinsertRowCurrentIndex);
}

function Circunstancias_del_Delito_MASCClearGridData() {
    Circunstancias_del_Delito_MASCData = [];
    Circunstancias_del_Delito_MASCdeletedItem = [];
    Circunstancias_del_Delito_MASCDataMain = [];
    Circunstancias_del_Delito_MASCDataMainPages = [];
    Circunstancias_del_Delito_MASCnewItemCount = 0;
    Circunstancias_del_Delito_MASCmaxItemIndex = 0;
    $("#Circunstancias_del_Delito_MASCGrid").DataTable().clear();
    $("#Circunstancias_del_Delito_MASCGrid").DataTable().destroy();
}

//Used to Get Delitos Information
function GetCircunstancias_del_Delito_MASC() {
    var form_data = new FormData();
    for (var i = 0; i < Circunstancias_del_Delito_MASCData.length; i++) {
        form_data.append('[' + i + '].Clave', Circunstancias_del_Delito_MASCData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Lugar', Circunstancias_del_Delito_MASCData[i].Tipo_de_Lugar);

        form_data.append('[' + i + '].Removed', Circunstancias_del_Delito_MASCData[i].Removed);
    }
    return form_data;
}
function Circunstancias_del_Delito_MASCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRCircunstancias_del_Delito_MASC("Circunstancias_del_Delito_MASCTable", rowIndex)) {
    var prevData = Circunstancias_del_Delito_MASCTable.fnGetData(rowIndex);
    var data = Circunstancias_del_Delito_MASCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Lugar: $('#Circunstancias_del_Delito_MASCTipo_de_Lugar').val()

    }

    Circunstancias_del_Delito_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Circunstancias_del_Delito_MASCrowCreationGrid(data, newData, rowIndex);
    $('#AddCircunstancias_del_Delito_MASC-form').modal({ show: false });
    $('#AddCircunstancias_del_Delito_MASC-form').modal('hide');
    Circunstancias_del_Delito_MASCEditRow(rowIndex);
    Circunstancias_del_Delito_MASCInsertRow(rowIndex);
    //}
}
function Circunstancias_del_Delito_MASCRemoveAddRow(rowIndex) {
    Circunstancias_del_Delito_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Circunstancias_del_Delito_MASC MultiRow


$(function () {
    function Agravantes_del_Delito_MASCinitializeMainArray(totalCount) {
        if (Agravantes_del_Delito_MASCDataMain.length != totalCount && !Agravantes_del_Delito_MASCDataMainInitialized) {
            Agravantes_del_Delito_MASCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Agravantes_del_Delito_MASCDataMain[i] = null;
            }
        }
    }
    function Agravantes_del_Delito_MASCremoveFromMainArray() {
        for (var j = 0; j < Agravantes_del_Delito_MASCdeletedItem.length; j++) {
            for (var i = 0; i < Agravantes_del_Delito_MASCDataMain.length; i++) {
                if (Agravantes_del_Delito_MASCDataMain[i] != null && Agravantes_del_Delito_MASCDataMain[i].Id == Agravantes_del_Delito_MASCdeletedItem[j]) {
                    hAgravantes_del_Delito_MASCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Agravantes_del_Delito_MASCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Agravantes_del_Delito_MASCDataMain.length; i++) {
            data[i] = Agravantes_del_Delito_MASCDataMain[i];

        }
        return data;
    }
    function Agravantes_del_Delito_MASCgetNewResult() {
        var newData = copyMainAgravantes_del_Delito_MASCArray();

        for (var i = 0; i < Agravantes_del_Delito_MASCData.length; i++) {
            if (Agravantes_del_Delito_MASCData[i].Removed == null || Agravantes_del_Delito_MASCData[i].Removed == false) {
                newData.splice(0, 0, Agravantes_del_Delito_MASCData[i]);
            }
        }
        return newData;
    }
    function Agravantes_del_Delito_MASCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Agravantes_del_Delito_MASCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Agravantes_del_Delito_MASCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Circunstancias_del_Delito_MASCinitializeMainArray(totalCount) {
        if (Circunstancias_del_Delito_MASCDataMain.length != totalCount && !Circunstancias_del_Delito_MASCDataMainInitialized) {
            Circunstancias_del_Delito_MASCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Circunstancias_del_Delito_MASCDataMain[i] = null;
            }
        }
    }
    function Circunstancias_del_Delito_MASCremoveFromMainArray() {
        for (var j = 0; j < Circunstancias_del_Delito_MASCdeletedItem.length; j++) {
            for (var i = 0; i < Circunstancias_del_Delito_MASCDataMain.length; i++) {
                if (Circunstancias_del_Delito_MASCDataMain[i] != null && Circunstancias_del_Delito_MASCDataMain[i].Id == Circunstancias_del_Delito_MASCdeletedItem[j]) {
                    hCircunstancias_del_Delito_MASCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Circunstancias_del_Delito_MASCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Circunstancias_del_Delito_MASCDataMain.length; i++) {
            data[i] = Circunstancias_del_Delito_MASCDataMain[i];

        }
        return data;
    }
    function Circunstancias_del_Delito_MASCgetNewResult() {
        var newData = copyMainCircunstancias_del_Delito_MASCArray();

        for (var i = 0; i < Circunstancias_del_Delito_MASCData.length; i++) {
            if (Circunstancias_del_Delito_MASCData[i].Removed == null || Circunstancias_del_Delito_MASCData[i].Removed == false) {
                newData.splice(0, 0, Circunstancias_del_Delito_MASCData[i]);
            }
        }
        return newData;
    }
    function Circunstancias_del_Delito_MASCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Circunstancias_del_Delito_MASCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Circunstancias_del_Delito_MASCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteSolicitudData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Solicitud_SolicitudData(data) {
	AutoCompleteSolicitudData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteSolicitudData.push({
            id: data[i].Clave,
            text: data[i].Numero_de_Folio
        });
    }
    return AutoCompleteSolicitudData;
}
var AutoCompleteDelito_Violencia_GeneroData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Delito_Violencia_Genero_Delitos_Violencia_GeneroData(data) {
	AutoCompleteDelito_Violencia_GeneroData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteDelito_Violencia_GeneroData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteDelito_Violencia_GeneroData;
}
//Grid GetAutocomplete

//Grid GetAutocomplete

var AutoCompleteEstado_del_DelitoData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Estado_del_Delito_EstadoData(data) {
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
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Municipio_del_Delito_MunicipioData(data) {
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
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Colonia_del_Delito_ColoniaData(data) {
	AutoCompleteColonia_del_DelitoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_del_DelitoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_del_DelitoData;
}
var AutoCompleteMarcaData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Marca_Marca_del_VehiculoData(data) {
	AutoCompleteMarcaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMarcaData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteMarcaData;
}
var AutoCompleteSub_MarcaData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Sub_Marca_Sub_Marca_del_VehiculoData(data) {
	AutoCompleteSub_MarcaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteSub_MarcaData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteSub_MarcaData;
}
var AutoCompleteEstado_de_Origen_de_las_PlacasData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Estado_de_Origen_de_las_Placas_EstadoData(data) {
	AutoCompleteEstado_de_Origen_de_las_PlacasData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_de_Origen_de_las_PlacasData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_de_Origen_de_las_PlacasData;
}
var AutoCompleteEstado_De_RoboData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Estado_De_Robo_EstadoData(data) {
	AutoCompleteEstado_De_RoboData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_De_RoboData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_De_RoboData;
}
var AutoCompleteMunicipio_de_RoboData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Municipio_de_Robo_MunicipioData(data) {
	AutoCompleteMunicipio_de_RoboData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_de_RoboData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_de_RoboData;
}
var AutoCompleteColonia_de_RoboData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Colonia_de_Robo_ColoniaData(data) {
	AutoCompleteColonia_de_RoboData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_de_RoboData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_de_RoboData;
}
var AutoCompleteNombre_de_la_AseguradoraData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Nombre_de_la_Aseguradora_Aseguradora_de_VehiculoData(data) {
	AutoCompleteNombre_de_la_AseguradoraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNombre_de_la_AseguradoraData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteNombre_de_la_AseguradoraData;
}
var AutoCompleteNombre_Completo_Persona_FisicaData = [];
function GetAutoCompleteDetalle_de_Delito_de_Justicia_Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_SolicitanteData(data) {
	AutoCompleteNombre_Completo_Persona_FisicaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNombre_Completo_Persona_FisicaData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteNombre_Completo_Persona_FisicaData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Delito_de_Justicia_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Delito_de_Justicia')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Solicitud').empty();
    $("#Solicitud").append('<option value=""></option>');
    $('#Solicitud').val('0').trigger('change');
    $('#Delito_Violencia_Genero').empty();
    $("#Delito_Violencia_Genero").append('<option value=""></option>');
    $('#Delito_Violencia_Genero').val('0').trigger('change');
                Agravantes_del_Delito_MASCClearGridData();
                Circunstancias_del_Delito_MASCClearGridData();
    $('#Estado_del_Delito').empty();
    $("#Estado_del_Delito").append('<option value=""></option>');
    $('#Estado_del_Delito').val('0').trigger('change');
    $('#Municipio_del_Delito').empty();
    $("#Municipio_del_Delito").append('<option value=""></option>');
    $('#Municipio_del_Delito').val('0').trigger('change');
    $('#Colonia_del_Delito').empty();
    $("#Colonia_del_Delito").append('<option value=""></option>');
    $('#Colonia_del_Delito').val('0').trigger('change');
    $('#Marca').empty();
    $("#Marca").append('<option value=""></option>');
    $('#Marca').val('0').trigger('change');
    $('#Sub_Marca').empty();
    $("#Sub_Marca").append('<option value=""></option>');
    $('#Sub_Marca').val('0').trigger('change');
    $('#Estado_de_Origen_de_las_Placas').empty();
    $("#Estado_de_Origen_de_las_Placas").append('<option value=""></option>');
    $('#Estado_de_Origen_de_las_Placas').val('0').trigger('change');
    $('#Estado_De_Robo').empty();
    $("#Estado_De_Robo").append('<option value=""></option>');
    $('#Estado_De_Robo').val('0').trigger('change');
    $('#Municipio_de_Robo').empty();
    $("#Municipio_de_Robo").append('<option value=""></option>');
    $('#Municipio_de_Robo').val('0').trigger('change');
    $('#Colonia_de_Robo').empty();
    $("#Colonia_de_Robo").append('<option value=""></option>');
    $('#Colonia_de_Robo').val('0').trigger('change');
    $('#Nombre_de_la_Aseguradora').empty();
    $("#Nombre_de_la_Aseguradora").append('<option value=""></option>');
    $('#Nombre_de_la_Aseguradora').val('0').trigger('change');
    $('#Nombre_Completo_Persona_Fisica').empty();
    $("#Nombre_Completo_Persona_Fisica").append('<option value=""></option>');
    $('#Nombre_Completo_Persona_Fisica').val('0').trigger('change');

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Delito_de_Justicia').trigger('reset');
    $('#CreateDetalle_de_Delito_de_Justicia').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Delito_de_Justicia');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Agravantes_del_Delito_MASCcountRowsChecked > 0)
    {
        ShowMessagePendingRowAgravantes_del_Delito_MASC();
        return false;
    }
    if (Circunstancias_del_Delito_MASCcountRowsChecked > 0)
    {
        ShowMessagePendingRowCircunstancias_del_Delito_MASC();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Delito_de_Justicia").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Delito_de_Justicia").on('click', '#Detalle_de_Delito_de_JusticiaCancelar', function () {
	  if (!isPartial) {
        Detalle_de_Delito_de_JusticiaBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Delito_de_Justicia").on('click', '#Detalle_de_Delito_de_JusticiaGuardar', function () {
		$('#Detalle_de_Delito_de_JusticiaGuardar').attr('disabled', true);
		$('#Detalle_de_Delito_de_JusticiaGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_Delito_de_JusticiaData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_Delito_de_JusticiaBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_Delito_de_JusticiaGuardar').removeAttr('disabled');
                        $('#Detalle_de_Delito_de_JusticiaGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Delito_de_Justicia', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_Delito_de_JusticiaItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Delito_de_JusticiaDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Detalle_de_Delito_de_JusticiaGuardar').removeAttr('disabled');
					$('#Detalle_de_Delito_de_JusticiaGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_Delito_de_JusticiaGuardar').removeAttr('disabled');
			$('#Detalle_de_Delito_de_JusticiaGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Delito_de_Justicia").on('click', '#Detalle_de_Delito_de_JusticiaGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_Delito_de_JusticiaData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getAgravantes_del_Delito_MASCData();
                getCircunstancias_del_Delito_MASCData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Delito_de_Justicia', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Delito_de_JusticiaItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Delito_de_JusticiaDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Delito_de_Justicia").on('click', '#Detalle_de_Delito_de_JusticiaGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_Delito_de_JusticiaData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Solicitud').empty();
    $("#Solicitud").append('<option value=""></option>');
    $('#Solicitud').val('0').trigger('change');
    $('#Delito_Violencia_Genero').empty();
    $("#Delito_Violencia_Genero").append('<option value=""></option>');
    $('#Delito_Violencia_Genero').val('0').trigger('change');
                Agravantes_del_Delito_MASCClearGridData();
                Circunstancias_del_Delito_MASCClearGridData();
    $('#Estado_del_Delito').empty();
    $("#Estado_del_Delito").append('<option value=""></option>');
    $('#Estado_del_Delito').val('0').trigger('change');
    $('#Municipio_del_Delito').empty();
    $("#Municipio_del_Delito").append('<option value=""></option>');
    $('#Municipio_del_Delito').val('0').trigger('change');
    $('#Colonia_del_Delito').empty();
    $("#Colonia_del_Delito").append('<option value=""></option>');
    $('#Colonia_del_Delito').val('0').trigger('change');
    $('#Marca').empty();
    $("#Marca").append('<option value=""></option>');
    $('#Marca').val('0').trigger('change');
    $('#Sub_Marca').empty();
    $("#Sub_Marca").append('<option value=""></option>');
    $('#Sub_Marca').val('0').trigger('change');
    $('#Estado_de_Origen_de_las_Placas').empty();
    $("#Estado_de_Origen_de_las_Placas").append('<option value=""></option>');
    $('#Estado_de_Origen_de_las_Placas').val('0').trigger('change');
    $('#Estado_De_Robo').empty();
    $("#Estado_De_Robo").append('<option value=""></option>');
    $('#Estado_De_Robo').val('0').trigger('change');
    $('#Municipio_de_Robo').empty();
    $("#Municipio_de_Robo").append('<option value=""></option>');
    $('#Municipio_de_Robo').val('0').trigger('change');
    $('#Colonia_de_Robo').empty();
    $("#Colonia_de_Robo").append('<option value=""></option>');
    $('#Colonia_de_Robo').val('0').trigger('change');
    $('#Nombre_de_la_Aseguradora').empty();
    $("#Nombre_de_la_Aseguradora").append('<option value=""></option>');
    $('#Nombre_de_la_Aseguradora').val('0').trigger('change');
    $('#Nombre_Completo_Persona_Fisica').empty();
    $("#Nombre_Completo_Persona_Fisica").append('<option value=""></option>');
    $('#Nombre_Completo_Persona_Fisica').val('0').trigger('change');

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getAgravantes_del_Delito_MASCData();
                getCircunstancias_del_Delito_MASCData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Delito_de_Justicia',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Delito_de_JusticiaItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Delito_de_JusticiaDropDown().get(0)').innerHTML);                          
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



var Detalle_de_Delito_de_JusticiaisdisplayBusinessPropery = false;
Detalle_de_Delito_de_JusticiaDisplayBusinessRuleButtons(Detalle_de_Delito_de_JusticiaisdisplayBusinessPropery);
function Detalle_de_Delito_de_JusticiaDisplayBusinessRule() {
    if (!Detalle_de_Delito_de_JusticiaisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Delito_de_Justicia').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_Delito_de_JusticiadisplayBusinessPropery"><button onclick="Detalle_de_Delito_de_JusticiaGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_Delito_de_JusticiaBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_Delito_de_JusticiadisplayBusinessPropery').remove();
    }
    Detalle_de_Delito_de_JusticiaDisplayBusinessRuleButtons(!Detalle_de_Delito_de_JusticiaisdisplayBusinessPropery);
    Detalle_de_Delito_de_JusticiaisdisplayBusinessPropery = (Detalle_de_Delito_de_JusticiaisdisplayBusinessPropery ? false : true);
}
function Detalle_de_Delito_de_JusticiaDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

