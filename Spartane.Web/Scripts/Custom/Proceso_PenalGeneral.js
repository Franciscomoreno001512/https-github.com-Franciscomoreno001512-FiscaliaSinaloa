

//Begin Declarations for Foreigns fields for Detalle_Delitos_Proceso_Penal MultiRow
var Detalle_Delitos_Proceso_PenalcountRowsChecked = 0;

function GetDetalle_Delitos_Proceso_Penal_DelitoName(Id) {
    for (var i = 0; i < Detalle_Delitos_Proceso_Penal_DelitoItems.length; i++) {
        if (Detalle_Delitos_Proceso_Penal_DelitoItems[i].Clave == Id) {
            return Detalle_Delitos_Proceso_Penal_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Delitos_Proceso_Penal_DelitoDropDown() {
    var Detalle_Delitos_Proceso_Penal_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Delitos_Proceso_Penal_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Delitos_Proceso_Penal_DelitoDropdown);

    for (var i = 0; i < Detalle_Delitos_Proceso_Penal_DelitoItems.length; i++) {
        $('<option />', { value: Detalle_Delitos_Proceso_Penal_DelitoItems[i].Clave, text: Detalle_Delitos_Proceso_Penal_DelitoItems[i].Descripcion }).appendTo(Detalle_Delitos_Proceso_Penal_DelitoDropdown);
    }
    return Detalle_Delitos_Proceso_Penal_DelitoDropdown;
}


function GetInsertDetalle_Delitos_Proceso_PenalRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Delitos_Proceso_Penal_Delito'))).addClass('Detalle_Delitos_Proceso_Penal_Delito Delito').attr('id', 'Detalle_Delitos_Proceso_Penal_Delito_' + index).attr('data-field', 'Delito').after($.parseHTML(addNew('Detalle_Delitos_Proceso_Penal', 'Delito', 'Delito', 267736)));


    initiateUIControls();
    return columnData;
}

function Detalle_Delitos_Proceso_PenalInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Delitos_Proceso_Penal("Detalle_Delitos_Proceso_Penal_", "_" + rowIndex)) {
    var iPage = Detalle_Delitos_Proceso_PenalTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Delitos_Proceso_Penal';
    var prevData = Detalle_Delitos_Proceso_PenalTable.fnGetData(rowIndex);
    var data = Detalle_Delitos_Proceso_PenalTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , DelitoDescripcion:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Delito:  data.childNodes[counter++].childNodes[0].value 	

    }
    Detalle_Delitos_Proceso_PenalTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Delitos_Proceso_PenalrowCreationGrid(data, newData, rowIndex);
    Detalle_Delitos_Proceso_PenalTable.fnPageChange(iPage);
    Detalle_Delitos_Proceso_PenalcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Delitos_Proceso_Penal("Detalle_Delitos_Proceso_Penal_", "_" + rowIndex);
  }
}

function Detalle_Delitos_Proceso_PenalCancelRow(rowIndex) {
    var prevData = Detalle_Delitos_Proceso_PenalTable.fnGetData(rowIndex);
    var data = Detalle_Delitos_Proceso_PenalTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Delitos_Proceso_PenalTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Delitos_Proceso_PenalrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Delitos_Proceso_PenalGrid(Detalle_Delitos_Proceso_PenalTable.fnGetData());
    Detalle_Delitos_Proceso_PenalcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Delitos_Proceso_PenalFromDataTable() {
    var Detalle_Delitos_Proceso_PenalData = [];
    var gridData = Detalle_Delitos_Proceso_PenalTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Delitos_Proceso_PenalData.push({
                Clave: gridData[i].Clave

                ,Delito: gridData[i].Delito

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Delitos_Proceso_PenalData.length; i++) {
        if (removedDetalle_Delitos_Proceso_PenalData[i] != null && removedDetalle_Delitos_Proceso_PenalData[i].Clave > 0)
            Detalle_Delitos_Proceso_PenalData.push({
                Clave: removedDetalle_Delitos_Proceso_PenalData[i].Clave

                ,Delito: removedDetalle_Delitos_Proceso_PenalData[i].Delito

                , Removed: true
            });
    }	

    return Detalle_Delitos_Proceso_PenalData;
}

function Detalle_Delitos_Proceso_PenalEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Delitos_Proceso_PenalTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Delitos_Proceso_PenalcountRowsChecked++;
    var Detalle_Delitos_Proceso_PenalRowElement = "Detalle_Delitos_Proceso_Penal_" + rowIndex.toString();
    var prevData = Detalle_Delitos_Proceso_PenalTable.fnGetData(rowIndexTable );
    var row = Detalle_Delitos_Proceso_PenalTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Delitos_Proceso_Penal_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Delitos_Proceso_PenalGetUpdateRowControls(prevData, "Detalle_Delitos_Proceso_Penal_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Delitos_Proceso_PenalRowElement + "')){ Detalle_Delitos_Proceso_PenalInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Delitos_Proceso_PenalCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Delitos_Proceso_PenalGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Delitos_Proceso_PenalGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Delitos_Proceso_PenalValidation();
    initiateUIControls();
    $('.Detalle_Delitos_Proceso_Penal' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Delitos_Proceso_PenalfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Delitos_Proceso_PenalTable.fnGetData().length;
    Detalle_Delitos_Proceso_PenalfnClickAddRow();
    GetAddDetalle_Delitos_Proceso_PenalPopup(currentRowIndex, 0);
}

function Detalle_Delitos_Proceso_PenalEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Delitos_Proceso_PenalTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Delitos_Proceso_PenalRowElement = "Detalle_Delitos_Proceso_Penal_" + rowIndex.toString();
    var prevData = Detalle_Delitos_Proceso_PenalTable.fnGetData(rowIndexTable);
    GetAddDetalle_Delitos_Proceso_PenalPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_Delitos_Proceso_PenalDelito').html($($.parseHTML(GetGridAutoComplete(prevData.Delito.label,'AutoCompleteDelito'))).addClass('Detalle_Delitos_Proceso_Penal_Delito'));

    initiateUIControls();



}

function Detalle_Delitos_Proceso_PenalAddInsertRow() {
    if (Detalle_Delitos_Proceso_PenalinsertRowCurrentIndex < 1)
    {
        Detalle_Delitos_Proceso_PenalinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Delito: ""

    }
}

function Detalle_Delitos_Proceso_PenalfnClickAddRow() {
    Detalle_Delitos_Proceso_PenalcountRowsChecked++;
    Detalle_Delitos_Proceso_PenalTable.fnAddData(Detalle_Delitos_Proceso_PenalAddInsertRow(), true);
    Detalle_Delitos_Proceso_PenalTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Delitos_Proceso_PenalGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Delitos_Proceso_PenalGrid tbody tr:nth-of-type(' + (Detalle_Delitos_Proceso_PenalinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Delitos_Proceso_Penal("Detalle_Delitos_Proceso_Penal_", "_" + Detalle_Delitos_Proceso_PenalinsertRowCurrentIndex);
}

function Detalle_Delitos_Proceso_PenalClearGridData() {
    Detalle_Delitos_Proceso_PenalData = [];
    Detalle_Delitos_Proceso_PenaldeletedItem = [];
    Detalle_Delitos_Proceso_PenalDataMain = [];
    Detalle_Delitos_Proceso_PenalDataMainPages = [];
    Detalle_Delitos_Proceso_PenalnewItemCount = 0;
    Detalle_Delitos_Proceso_PenalmaxItemIndex = 0;
    $("#Detalle_Delitos_Proceso_PenalGrid").DataTable().clear();
    $("#Detalle_Delitos_Proceso_PenalGrid").DataTable().destroy();
}

//Used to Get Proceso Penal Information
function GetDetalle_Delitos_Proceso_Penal() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Delitos_Proceso_PenalData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Delitos_Proceso_PenalData[i].Clave);

        form_data.append('[' + i + '].Delito', Detalle_Delitos_Proceso_PenalData[i].Delito);

        form_data.append('[' + i + '].Removed', Detalle_Delitos_Proceso_PenalData[i].Removed);
    }
    return form_data;
}
function Detalle_Delitos_Proceso_PenalInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Delitos_Proceso_Penal("Detalle_Delitos_Proceso_PenalTable", rowIndex)) {
    var prevData = Detalle_Delitos_Proceso_PenalTable.fnGetData(rowIndex);
    var data = Detalle_Delitos_Proceso_PenalTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Delito: $('#Detalle_Delitos_Proceso_PenalDelito').val()

    }

    Detalle_Delitos_Proceso_PenalTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Delitos_Proceso_PenalrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Delitos_Proceso_Penal-form').modal({ show: false });
    $('#AddDetalle_Delitos_Proceso_Penal-form').modal('hide');
    Detalle_Delitos_Proceso_PenalEditRow(rowIndex);
    Detalle_Delitos_Proceso_PenalInsertRow(rowIndex);
    //}
}
function Detalle_Delitos_Proceso_PenalRemoveAddRow(rowIndex) {
    Detalle_Delitos_Proceso_PenalTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Delitos_Proceso_Penal MultiRow
//Begin Declarations for Foreigns fields for Detalle_Medidas_Cautelares_Proceso_Penal MultiRow
var Detalle_Medidas_Cautelares_Proceso_PenalcountRowsChecked = 0;

function GetDetalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresName(Id) {
    for (var i = 0; i < Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresItems.length; i++) {
        if (Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresItems[i].Clave == Id) {
            return Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresDropDown() {
    var Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Medidas_Cautelares_Proceso_Penal_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresDropdown);
    if(Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresItems != null)
    {
       for (var i = 0; i < Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresItems.length; i++) {
           $('<option />', { value: Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresItems[i].Clave, text:    Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresItems[i].Descripcion }).appendTo(Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresDropdown);
       }
    }
    return Detalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresDropdown;
}


function GetInsertDetalle_Medidas_Cautelares_Proceso_PenalRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresDropDown()).addClass('Detalle_Medidas_Cautelares_Proceso_Penal_Medida_Cautelar Medida_Cautelar').attr('id', 'Detalle_Medidas_Cautelares_Proceso_Penal_Medida_Cautelar_' + index).attr('data-field', 'Medida_Cautelar').after($.parseHTML(addNew('Detalle_Medidas_Cautelares_Proceso_Penal', 'Medidas_Cautelares', 'Medida_Cautelar', 267748)));


    initiateUIControls();
    return columnData;
}

function Detalle_Medidas_Cautelares_Proceso_PenalInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Medidas_Cautelares_Proceso_Penal("Detalle_Medidas_Cautelares_Proceso_Penal_", "_" + rowIndex)) {
    var iPage = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Medidas_Cautelares_Proceso_Penal';
    var prevData = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetData(rowIndex);
    var data = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Medida_Cautelar:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Medidas_Cautelares_Proceso_PenalTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Medidas_Cautelares_Proceso_PenalrowCreationGrid(data, newData, rowIndex);
    Detalle_Medidas_Cautelares_Proceso_PenalTable.fnPageChange(iPage);
    Detalle_Medidas_Cautelares_Proceso_PenalcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Medidas_Cautelares_Proceso_Penal("Detalle_Medidas_Cautelares_Proceso_Penal_", "_" + rowIndex);
  }
}

function Detalle_Medidas_Cautelares_Proceso_PenalCancelRow(rowIndex) {
    var prevData = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetData(rowIndex);
    var data = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Medidas_Cautelares_Proceso_PenalTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Medidas_Cautelares_Proceso_PenalrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Medidas_Cautelares_Proceso_PenalGrid(Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetData());
    Detalle_Medidas_Cautelares_Proceso_PenalcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Medidas_Cautelares_Proceso_PenalFromDataTable() {
    var Detalle_Medidas_Cautelares_Proceso_PenalData = [];
    var gridData = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Medidas_Cautelares_Proceso_PenalData.push({
                Clave: gridData[i].Clave

                ,Medida_Cautelar: gridData[i].Medida_Cautelar

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Medidas_Cautelares_Proceso_PenalData.length; i++) {
        if (removedDetalle_Medidas_Cautelares_Proceso_PenalData[i] != null && removedDetalle_Medidas_Cautelares_Proceso_PenalData[i].Clave > 0)
            Detalle_Medidas_Cautelares_Proceso_PenalData.push({
                Clave: removedDetalle_Medidas_Cautelares_Proceso_PenalData[i].Clave

                ,Medida_Cautelar: removedDetalle_Medidas_Cautelares_Proceso_PenalData[i].Medida_Cautelar

                , Removed: true
            });
    }	

    return Detalle_Medidas_Cautelares_Proceso_PenalData;
}

function Detalle_Medidas_Cautelares_Proceso_PenalEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Medidas_Cautelares_Proceso_PenalcountRowsChecked++;
    var Detalle_Medidas_Cautelares_Proceso_PenalRowElement = "Detalle_Medidas_Cautelares_Proceso_Penal_" + rowIndex.toString();
    var prevData = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetData(rowIndexTable );
    var row = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Medidas_Cautelares_Proceso_Penal_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Medidas_Cautelares_Proceso_PenalGetUpdateRowControls(prevData, "Detalle_Medidas_Cautelares_Proceso_Penal_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Medidas_Cautelares_Proceso_PenalRowElement + "')){ Detalle_Medidas_Cautelares_Proceso_PenalInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Medidas_Cautelares_Proceso_PenalCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Medidas_Cautelares_Proceso_PenalGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Medidas_Cautelares_Proceso_PenalGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Medidas_Cautelares_Proceso_PenalValidation();
    initiateUIControls();
    $('.Detalle_Medidas_Cautelares_Proceso_Penal' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Medidas_Cautelares_Proceso_PenalfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetData().length;
    Detalle_Medidas_Cautelares_Proceso_PenalfnClickAddRow();
    GetAddDetalle_Medidas_Cautelares_Proceso_PenalPopup(currentRowIndex, 0);
}

function Detalle_Medidas_Cautelares_Proceso_PenalEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Medidas_Cautelares_Proceso_PenalRowElement = "Detalle_Medidas_Cautelares_Proceso_Penal_" + rowIndex.toString();
    var prevData = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetData(rowIndexTable);
    GetAddDetalle_Medidas_Cautelares_Proceso_PenalPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Medidas_Cautelares_Proceso_PenalMedida_Cautelar').val(prevData.Medida_Cautelar);

    initiateUIControls();



}

function Detalle_Medidas_Cautelares_Proceso_PenalAddInsertRow() {
    if (Detalle_Medidas_Cautelares_Proceso_PenalinsertRowCurrentIndex < 1)
    {
        Detalle_Medidas_Cautelares_Proceso_PenalinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Medida_Cautelar: ""

    }
}

function Detalle_Medidas_Cautelares_Proceso_PenalfnClickAddRow() {
    Detalle_Medidas_Cautelares_Proceso_PenalcountRowsChecked++;
    Detalle_Medidas_Cautelares_Proceso_PenalTable.fnAddData(Detalle_Medidas_Cautelares_Proceso_PenalAddInsertRow(), true);
    Detalle_Medidas_Cautelares_Proceso_PenalTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Medidas_Cautelares_Proceso_PenalGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Medidas_Cautelares_Proceso_PenalGrid tbody tr:nth-of-type(' + (Detalle_Medidas_Cautelares_Proceso_PenalinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Medidas_Cautelares_Proceso_Penal("Detalle_Medidas_Cautelares_Proceso_Penal_", "_" + Detalle_Medidas_Cautelares_Proceso_PenalinsertRowCurrentIndex);
}

function Detalle_Medidas_Cautelares_Proceso_PenalClearGridData() {
    Detalle_Medidas_Cautelares_Proceso_PenalData = [];
    Detalle_Medidas_Cautelares_Proceso_PenaldeletedItem = [];
    Detalle_Medidas_Cautelares_Proceso_PenalDataMain = [];
    Detalle_Medidas_Cautelares_Proceso_PenalDataMainPages = [];
    Detalle_Medidas_Cautelares_Proceso_PenalnewItemCount = 0;
    Detalle_Medidas_Cautelares_Proceso_PenalmaxItemIndex = 0;
    $("#Detalle_Medidas_Cautelares_Proceso_PenalGrid").DataTable().clear();
    $("#Detalle_Medidas_Cautelares_Proceso_PenalGrid").DataTable().destroy();
}

//Used to Get Proceso Penal Information
function GetDetalle_Medidas_Cautelares_Proceso_Penal() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Medidas_Cautelares_Proceso_PenalData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Medidas_Cautelares_Proceso_PenalData[i].Clave);

        form_data.append('[' + i + '].Medida_Cautelar', Detalle_Medidas_Cautelares_Proceso_PenalData[i].Medida_Cautelar);

        form_data.append('[' + i + '].Removed', Detalle_Medidas_Cautelares_Proceso_PenalData[i].Removed);
    }
    return form_data;
}
function Detalle_Medidas_Cautelares_Proceso_PenalInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Medidas_Cautelares_Proceso_Penal("Detalle_Medidas_Cautelares_Proceso_PenalTable", rowIndex)) {
    var prevData = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetData(rowIndex);
    var data = Detalle_Medidas_Cautelares_Proceso_PenalTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Medida_Cautelar: $('#Detalle_Medidas_Cautelares_Proceso_PenalMedida_Cautelar').val()

    }

    Detalle_Medidas_Cautelares_Proceso_PenalTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Medidas_Cautelares_Proceso_PenalrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Medidas_Cautelares_Proceso_Penal-form').modal({ show: false });
    $('#AddDetalle_Medidas_Cautelares_Proceso_Penal-form').modal('hide');
    Detalle_Medidas_Cautelares_Proceso_PenalEditRow(rowIndex);
    Detalle_Medidas_Cautelares_Proceso_PenalInsertRow(rowIndex);
    //}
}
function Detalle_Medidas_Cautelares_Proceso_PenalRemoveAddRow(rowIndex) {
    Detalle_Medidas_Cautelares_Proceso_PenalTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Medidas_Cautelares_Proceso_Penal MultiRow
//Begin Declarations for Foreigns fields for Detalle_Medios_Prueba_Imputado MultiRow
var Detalle_Medios_Prueba_ImputadocountRowsChecked = 0;






function GetInsertDetalle_Medios_Prueba_ImputadoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_Medios_Prueba_Imputado_Medio_de_Prueba_Presentado Medio_de_Prueba_Presentado').attr('id', 'Detalle_Medios_Prueba_Imputado_Medio_de_Prueba_Presentado_' + index).attr('data-field', 'Medio_de_Prueba_Presentado');
    columnData[1] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_Medios_Prueba_Imputado_Fecha_de_Presentacion Fecha_de_Presentacion').attr('id', 'Detalle_Medios_Prueba_Imputado_Fecha_de_Presentacion_' + index).attr('data-field', 'Fecha_de_Presentacion');
    columnData[2] = $($.parseHTML(GetFileUploader())).addClass('Detalle_Medios_Prueba_Imputado_Archivo_Adjunto_FileUpload Archivo_Adjunto').attr('id', 'Detalle_Medios_Prueba_Imputado_Archivo_Adjunto_' + index).attr('data-field', 'Archivo_Adjunto');


    initiateUIControls();
    return columnData;
}

function Detalle_Medios_Prueba_ImputadoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Imputado("Detalle_Medios_Prueba_Imputado_", "_" + rowIndex)) {
    var iPage = Detalle_Medios_Prueba_ImputadoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Medios_Prueba_Imputado';
    var prevData = Detalle_Medios_Prueba_ImputadoTable.fnGetData(rowIndex);
    var data = Detalle_Medios_Prueba_ImputadoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Medio_de_Prueba_Presentado:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Presentacion:  data.childNodes[counter++].childNodes[0].value
        ,Archivo_AdjuntoFileInfo: ($('#' + nameOfGrid + 'Grid .Archivo_AdjuntoHeader').css('display') != 'none') ? { 
             FileName: prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null && prevData.Archivo_AdjuntoFileInfo.FileName != ''? prevData.Archivo_AdjuntoFileInfo.FileName : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : ''),              
			 FileId:   prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null && prevData.Archivo_AdjuntoFileInfo.FileName != '' ? prevData.Archivo_AdjuntoFileInfo.FileId :  prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileId != '' && prevData.Archivo_AdjuntoFileInfo.FileId != undefined ? prevData.Archivo_AdjuntoFileInfo.FileId : '0',
             FileSize: prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null ? prevData.Archivo_AdjuntoFileInfo.FileSize : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : '') 
         } : ''
        ,Archivo_AdjuntoDetail: (data.childNodes[counter] != 'undefined' && data.childNodes[counter].childNodes[0].childNodes.length == 0) ? data.childNodes[counter++].childNodes[0] : prevData.Archivo_AdjuntoDetail

    }
    Detalle_Medios_Prueba_ImputadoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Medios_Prueba_ImputadorowCreationGrid(data, newData, rowIndex);
    Detalle_Medios_Prueba_ImputadoTable.fnPageChange(iPage);
    Detalle_Medios_Prueba_ImputadocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Medios_Prueba_Imputado("Detalle_Medios_Prueba_Imputado_", "_" + rowIndex);
  }
}

function Detalle_Medios_Prueba_ImputadoCancelRow(rowIndex) {
    var prevData = Detalle_Medios_Prueba_ImputadoTable.fnGetData(rowIndex);
    var data = Detalle_Medios_Prueba_ImputadoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Medios_Prueba_ImputadoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Medios_Prueba_ImputadorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Medios_Prueba_ImputadoGrid(Detalle_Medios_Prueba_ImputadoTable.fnGetData());
    Detalle_Medios_Prueba_ImputadocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Medios_Prueba_ImputadoFromDataTable() {
    var Detalle_Medios_Prueba_ImputadoData = [];
    var gridData = Detalle_Medios_Prueba_ImputadoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Medios_Prueba_ImputadoData.push({
                Clave: gridData[i].Clave

                ,Medio_de_Prueba_Presentado: gridData[i].Medio_de_Prueba_Presentado
                ,Fecha_de_Presentacion: gridData[i].Fecha_de_Presentacion
                ,Archivo_AdjuntoInfo: {
                    FileName: gridData[i].Archivo_AdjuntoFileInfo.FileName, FileId: gridData[i].Archivo_AdjuntoFileInfo.FileId, FileSize: gridData[i].Archivo_AdjuntoFileInfo.FileSize,
                    Control: gridData[i].Archivo_AdjuntoDetail != null && gridData[i].Archivo_AdjuntoDetail.files != null && gridData[i].Archivo_AdjuntoDetail.files.length > 0 ? gridData[i].Archivo_AdjuntoDetail.files[0] : null,
                    Archivo_AdjuntoRemoveFile: gridData[i].Archivo_AdjuntoDetail != null
                }

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Medios_Prueba_ImputadoData.length; i++) {
        if (removedDetalle_Medios_Prueba_ImputadoData[i] != null && removedDetalle_Medios_Prueba_ImputadoData[i].Clave > 0)
            Detalle_Medios_Prueba_ImputadoData.push({
                Clave: removedDetalle_Medios_Prueba_ImputadoData[i].Clave

                ,Medio_de_Prueba_Presentado: removedDetalle_Medios_Prueba_ImputadoData[i].Medio_de_Prueba_Presentado
                ,Fecha_de_Presentacion: removedDetalle_Medios_Prueba_ImputadoData[i].Fecha_de_Presentacion
                ,Archivo_AdjuntoInfo: {
                    FileName: removedDetalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoFileInfo.FileName, 
                    FileId: removedDetalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoFileInfo.FileId, 
                    FileSize: removedDetalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoFileInfo.FileSize,
                    Control: removedDetalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoDetail != null && removedDetalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoDetail.files.length > 0 ? removedDetalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoDetail.files[0] : null,
                    Archivo_AdjuntoRemoveFile: removedDetalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoDetail != null
                }

                , Removed: true
            });
    }	

    return Detalle_Medios_Prueba_ImputadoData;
}

function Detalle_Medios_Prueba_ImputadoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Medios_Prueba_ImputadoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Medios_Prueba_ImputadocountRowsChecked++;
    var Detalle_Medios_Prueba_ImputadoRowElement = "Detalle_Medios_Prueba_Imputado_" + rowIndex.toString();
    var prevData = Detalle_Medios_Prueba_ImputadoTable.fnGetData(rowIndexTable );
    var row = Detalle_Medios_Prueba_ImputadoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Medios_Prueba_Imputado_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Medios_Prueba_ImputadoGetUpdateRowControls(prevData, "Detalle_Medios_Prueba_Imputado_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Medios_Prueba_ImputadoRowElement + "')){ Detalle_Medios_Prueba_ImputadoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Medios_Prueba_ImputadoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Medios_Prueba_ImputadoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Medios_Prueba_ImputadoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Medios_Prueba_ImputadoValidation();
    initiateUIControls();
    $('.Detalle_Medios_Prueba_Imputado' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Medios_Prueba_ImputadofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Medios_Prueba_ImputadoTable.fnGetData().length;
    Detalle_Medios_Prueba_ImputadofnClickAddRow();
    GetAddDetalle_Medios_Prueba_ImputadoPopup(currentRowIndex, 0);
}

function Detalle_Medios_Prueba_ImputadoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Medios_Prueba_ImputadoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Medios_Prueba_ImputadoRowElement = "Detalle_Medios_Prueba_Imputado_" + rowIndex.toString();
    var prevData = Detalle_Medios_Prueba_ImputadoTable.fnGetData(rowIndexTable);
    GetAddDetalle_Medios_Prueba_ImputadoPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Medios_Prueba_ImputadoMedio_de_Prueba_Presentado').val(prevData.Medio_de_Prueba_Presentado);
    $('#Detalle_Medios_Prueba_ImputadoFecha_de_Presentacion').val(prevData.Fecha_de_Presentacion);


    initiateUIControls();



    $('#existingArchivo_Adjunto').html(prevData.Archivo_AdjuntoFileDetail == null && (prevData.Archivo_AdjuntoFileInfo.FileId == null || prevData.Archivo_AdjuntoFileInfo.FileId <= 0) ? $.parseHTML(GetFileUploader()) : GetFileInfo(prevData.Archivo_AdjuntoFileInfo, prevData.Archivo_AdjuntoFileDetail));

}

function Detalle_Medios_Prueba_ImputadoAddInsertRow() {
    if (Detalle_Medios_Prueba_ImputadoinsertRowCurrentIndex < 1)
    {
        Detalle_Medios_Prueba_ImputadoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Medio_de_Prueba_Presentado: ""
        ,Fecha_de_Presentacion: ""
        ,Archivo_AdjuntoFileInfo: ""

    }
}

function Detalle_Medios_Prueba_ImputadofnClickAddRow() {
    Detalle_Medios_Prueba_ImputadocountRowsChecked++;
    Detalle_Medios_Prueba_ImputadoTable.fnAddData(Detalle_Medios_Prueba_ImputadoAddInsertRow(), true);
    Detalle_Medios_Prueba_ImputadoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Medios_Prueba_ImputadoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Medios_Prueba_ImputadoGrid tbody tr:nth-of-type(' + (Detalle_Medios_Prueba_ImputadoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Medios_Prueba_Imputado("Detalle_Medios_Prueba_Imputado_", "_" + Detalle_Medios_Prueba_ImputadoinsertRowCurrentIndex);
}

function Detalle_Medios_Prueba_ImputadoClearGridData() {
    Detalle_Medios_Prueba_ImputadoData = [];
    Detalle_Medios_Prueba_ImputadodeletedItem = [];
    Detalle_Medios_Prueba_ImputadoDataMain = [];
    Detalle_Medios_Prueba_ImputadoDataMainPages = [];
    Detalle_Medios_Prueba_ImputadonewItemCount = 0;
    Detalle_Medios_Prueba_ImputadomaxItemIndex = 0;
    $("#Detalle_Medios_Prueba_ImputadoGrid").DataTable().clear();
    $("#Detalle_Medios_Prueba_ImputadoGrid").DataTable().destroy();
}

//Used to Get Proceso Penal Information
function GetDetalle_Medios_Prueba_Imputado() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Medios_Prueba_ImputadoData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Medios_Prueba_ImputadoData[i].Clave);

        form_data.append('[' + i + '].Medio_de_Prueba_Presentado', Detalle_Medios_Prueba_ImputadoData[i].Medio_de_Prueba_Presentado);
        form_data.append('[' + i + '].Fecha_de_Presentacion', Detalle_Medios_Prueba_ImputadoData[i].Fecha_de_Presentacion);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileId', Detalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoInfo.FileId);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileName', Detalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoInfo.FileName);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileSize', Detalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoInfo.FileSize);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.Control', Detalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoInfo.Control);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.RemoveFile', Detalle_Medios_Prueba_ImputadoData[i].Archivo_AdjuntoInfo.ArchivoRemoveFile);

        form_data.append('[' + i + '].Removed', Detalle_Medios_Prueba_ImputadoData[i].Removed);
    }
    return form_data;
}
function Detalle_Medios_Prueba_ImputadoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Imputado("Detalle_Medios_Prueba_ImputadoTable", rowIndex)) {
    var prevData = Detalle_Medios_Prueba_ImputadoTable.fnGetData(rowIndex);
    var data = Detalle_Medios_Prueba_ImputadoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Medio_de_Prueba_Presentado: $('#Detalle_Medios_Prueba_ImputadoMedio_de_Prueba_Presentado').val()
        ,Fecha_de_Presentacion: $('#Detalle_Medios_Prueba_ImputadoFecha_de_Presentacion').val()
        ,Archivo_AdjuntoFileInfo: { Archivo_AdjuntoFileName: prevData.Archivo_AdjuntoFileInfo.FileName, Archivo_AdjuntoFileId: prevData.Archivo_AdjuntoFileInfo.FileId, Archivo_AdjuntoFileSize: prevData.Archivo_AdjuntoFileInfo.FileSize }
        ,Archivo_AdjuntoFileDetail: $('#Archivo_Adjunto').find('label').length == 0 ? $('#Archivo_AdjuntoFileInfoPop')[0] : prevData.Archivo_AdjuntoFileDetail

    }

    Detalle_Medios_Prueba_ImputadoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Medios_Prueba_ImputadorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Medios_Prueba_Imputado-form').modal({ show: false });
    $('#AddDetalle_Medios_Prueba_Imputado-form').modal('hide');
    Detalle_Medios_Prueba_ImputadoEditRow(rowIndex);
    Detalle_Medios_Prueba_ImputadoInsertRow(rowIndex);
    //}
}
function Detalle_Medios_Prueba_ImputadoRemoveAddRow(rowIndex) {
    Detalle_Medios_Prueba_ImputadoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Medios_Prueba_Imputado MultiRow
//Begin Declarations for Foreigns fields for Detalle_Medios_Prueba_Victima MultiRow
var Detalle_Medios_Prueba_VictimacountRowsChecked = 0;






function GetInsertDetalle_Medios_Prueba_VictimaRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_Medios_Prueba_Victima_Medio_de_Prueba_Presentado Medio_de_Prueba_Presentado').attr('id', 'Detalle_Medios_Prueba_Victima_Medio_de_Prueba_Presentado_' + index).attr('data-field', 'Medio_de_Prueba_Presentado');
    columnData[1] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_Medios_Prueba_Victima_Fecha_de_Presentacion Fecha_de_Presentacion').attr('id', 'Detalle_Medios_Prueba_Victima_Fecha_de_Presentacion_' + index).attr('data-field', 'Fecha_de_Presentacion');
    columnData[2] = $($.parseHTML(GetFileUploader())).addClass('Detalle_Medios_Prueba_Victima_Archivo_Adjunto_FileUpload Archivo_Adjunto').attr('id', 'Detalle_Medios_Prueba_Victima_Archivo_Adjunto_' + index).attr('data-field', 'Archivo_Adjunto');


    initiateUIControls();
    return columnData;
}

function Detalle_Medios_Prueba_VictimaInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Victima("Detalle_Medios_Prueba_Victima_", "_" + rowIndex)) {
    var iPage = Detalle_Medios_Prueba_VictimaTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Medios_Prueba_Victima';
    var prevData = Detalle_Medios_Prueba_VictimaTable.fnGetData(rowIndex);
    var data = Detalle_Medios_Prueba_VictimaTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Medio_de_Prueba_Presentado:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Presentacion:  data.childNodes[counter++].childNodes[0].value
        ,Archivo_AdjuntoFileInfo: ($('#' + nameOfGrid + 'Grid .Archivo_AdjuntoHeader').css('display') != 'none') ? { 
             FileName: prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null && prevData.Archivo_AdjuntoFileInfo.FileName != ''? prevData.Archivo_AdjuntoFileInfo.FileName : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : ''),              
			 FileId:   prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null && prevData.Archivo_AdjuntoFileInfo.FileName != '' ? prevData.Archivo_AdjuntoFileInfo.FileId :  prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileId != '' && prevData.Archivo_AdjuntoFileInfo.FileId != undefined ? prevData.Archivo_AdjuntoFileInfo.FileId : '0',
             FileSize: prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null ? prevData.Archivo_AdjuntoFileInfo.FileSize : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : '') 
         } : ''
        ,Archivo_AdjuntoDetail: (data.childNodes[counter] != 'undefined' && data.childNodes[counter].childNodes[0].childNodes.length == 0) ? data.childNodes[counter++].childNodes[0] : prevData.Archivo_AdjuntoDetail

    }
    Detalle_Medios_Prueba_VictimaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Medios_Prueba_VictimarowCreationGrid(data, newData, rowIndex);
    Detalle_Medios_Prueba_VictimaTable.fnPageChange(iPage);
    Detalle_Medios_Prueba_VictimacountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Medios_Prueba_Victima("Detalle_Medios_Prueba_Victima_", "_" + rowIndex);
  }
}

function Detalle_Medios_Prueba_VictimaCancelRow(rowIndex) {
    var prevData = Detalle_Medios_Prueba_VictimaTable.fnGetData(rowIndex);
    var data = Detalle_Medios_Prueba_VictimaTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Medios_Prueba_VictimaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Medios_Prueba_VictimarowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Medios_Prueba_VictimaGrid(Detalle_Medios_Prueba_VictimaTable.fnGetData());
    Detalle_Medios_Prueba_VictimacountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Medios_Prueba_VictimaFromDataTable() {
    var Detalle_Medios_Prueba_VictimaData = [];
    var gridData = Detalle_Medios_Prueba_VictimaTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Medios_Prueba_VictimaData.push({
                Clave: gridData[i].Clave

                ,Medio_de_Prueba_Presentado: gridData[i].Medio_de_Prueba_Presentado
                ,Fecha_de_Presentacion: gridData[i].Fecha_de_Presentacion
                ,Archivo_AdjuntoInfo: {
                    FileName: gridData[i].Archivo_AdjuntoFileInfo.FileName, FileId: gridData[i].Archivo_AdjuntoFileInfo.FileId, FileSize: gridData[i].Archivo_AdjuntoFileInfo.FileSize,
                    Control: gridData[i].Archivo_AdjuntoDetail != null && gridData[i].Archivo_AdjuntoDetail.files != null && gridData[i].Archivo_AdjuntoDetail.files.length > 0 ? gridData[i].Archivo_AdjuntoDetail.files[0] : null,
                    Archivo_AdjuntoRemoveFile: gridData[i].Archivo_AdjuntoDetail != null
                }

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Medios_Prueba_VictimaData.length; i++) {
        if (removedDetalle_Medios_Prueba_VictimaData[i] != null && removedDetalle_Medios_Prueba_VictimaData[i].Clave > 0)
            Detalle_Medios_Prueba_VictimaData.push({
                Clave: removedDetalle_Medios_Prueba_VictimaData[i].Clave

                ,Medio_de_Prueba_Presentado: removedDetalle_Medios_Prueba_VictimaData[i].Medio_de_Prueba_Presentado
                ,Fecha_de_Presentacion: removedDetalle_Medios_Prueba_VictimaData[i].Fecha_de_Presentacion
                ,Archivo_AdjuntoInfo: {
                    FileName: removedDetalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoFileInfo.FileName, 
                    FileId: removedDetalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoFileInfo.FileId, 
                    FileSize: removedDetalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoFileInfo.FileSize,
                    Control: removedDetalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoDetail != null && removedDetalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoDetail.files.length > 0 ? removedDetalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoDetail.files[0] : null,
                    Archivo_AdjuntoRemoveFile: removedDetalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoDetail != null
                }

                , Removed: true
            });
    }	

    return Detalle_Medios_Prueba_VictimaData;
}

function Detalle_Medios_Prueba_VictimaEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Medios_Prueba_VictimaTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Medios_Prueba_VictimacountRowsChecked++;
    var Detalle_Medios_Prueba_VictimaRowElement = "Detalle_Medios_Prueba_Victima_" + rowIndex.toString();
    var prevData = Detalle_Medios_Prueba_VictimaTable.fnGetData(rowIndexTable );
    var row = Detalle_Medios_Prueba_VictimaTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Medios_Prueba_Victima_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Medios_Prueba_VictimaGetUpdateRowControls(prevData, "Detalle_Medios_Prueba_Victima_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Medios_Prueba_VictimaRowElement + "')){ Detalle_Medios_Prueba_VictimaInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Medios_Prueba_VictimaCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Medios_Prueba_VictimaGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Medios_Prueba_VictimaGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Medios_Prueba_VictimaValidation();
    initiateUIControls();
    $('.Detalle_Medios_Prueba_Victima' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Medios_Prueba_VictimafnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Medios_Prueba_VictimaTable.fnGetData().length;
    Detalle_Medios_Prueba_VictimafnClickAddRow();
    GetAddDetalle_Medios_Prueba_VictimaPopup(currentRowIndex, 0);
}

function Detalle_Medios_Prueba_VictimaEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Medios_Prueba_VictimaTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Medios_Prueba_VictimaRowElement = "Detalle_Medios_Prueba_Victima_" + rowIndex.toString();
    var prevData = Detalle_Medios_Prueba_VictimaTable.fnGetData(rowIndexTable);
    GetAddDetalle_Medios_Prueba_VictimaPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Medios_Prueba_VictimaMedio_de_Prueba_Presentado').val(prevData.Medio_de_Prueba_Presentado);
    $('#Detalle_Medios_Prueba_VictimaFecha_de_Presentacion').val(prevData.Fecha_de_Presentacion);


    initiateUIControls();



    $('#existingArchivo_Adjunto').html(prevData.Archivo_AdjuntoFileDetail == null && (prevData.Archivo_AdjuntoFileInfo.FileId == null || prevData.Archivo_AdjuntoFileInfo.FileId <= 0) ? $.parseHTML(GetFileUploader()) : GetFileInfo(prevData.Archivo_AdjuntoFileInfo, prevData.Archivo_AdjuntoFileDetail));

}

function Detalle_Medios_Prueba_VictimaAddInsertRow() {
    if (Detalle_Medios_Prueba_VictimainsertRowCurrentIndex < 1)
    {
        Detalle_Medios_Prueba_VictimainsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Medio_de_Prueba_Presentado: ""
        ,Fecha_de_Presentacion: ""
        ,Archivo_AdjuntoFileInfo: ""

    }
}

function Detalle_Medios_Prueba_VictimafnClickAddRow() {
    Detalle_Medios_Prueba_VictimacountRowsChecked++;
    Detalle_Medios_Prueba_VictimaTable.fnAddData(Detalle_Medios_Prueba_VictimaAddInsertRow(), true);
    Detalle_Medios_Prueba_VictimaTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Medios_Prueba_VictimaGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Medios_Prueba_VictimaGrid tbody tr:nth-of-type(' + (Detalle_Medios_Prueba_VictimainsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Medios_Prueba_Victima("Detalle_Medios_Prueba_Victima_", "_" + Detalle_Medios_Prueba_VictimainsertRowCurrentIndex);
}

function Detalle_Medios_Prueba_VictimaClearGridData() {
    Detalle_Medios_Prueba_VictimaData = [];
    Detalle_Medios_Prueba_VictimadeletedItem = [];
    Detalle_Medios_Prueba_VictimaDataMain = [];
    Detalle_Medios_Prueba_VictimaDataMainPages = [];
    Detalle_Medios_Prueba_VictimanewItemCount = 0;
    Detalle_Medios_Prueba_VictimamaxItemIndex = 0;
    $("#Detalle_Medios_Prueba_VictimaGrid").DataTable().clear();
    $("#Detalle_Medios_Prueba_VictimaGrid").DataTable().destroy();
}

//Used to Get Proceso Penal Information
function GetDetalle_Medios_Prueba_Victima() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Medios_Prueba_VictimaData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Medios_Prueba_VictimaData[i].Clave);

        form_data.append('[' + i + '].Medio_de_Prueba_Presentado', Detalle_Medios_Prueba_VictimaData[i].Medio_de_Prueba_Presentado);
        form_data.append('[' + i + '].Fecha_de_Presentacion', Detalle_Medios_Prueba_VictimaData[i].Fecha_de_Presentacion);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileId', Detalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoInfo.FileId);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileName', Detalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoInfo.FileName);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileSize', Detalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoInfo.FileSize);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.Control', Detalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoInfo.Control);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.RemoveFile', Detalle_Medios_Prueba_VictimaData[i].Archivo_AdjuntoInfo.ArchivoRemoveFile);

        form_data.append('[' + i + '].Removed', Detalle_Medios_Prueba_VictimaData[i].Removed);
    }
    return form_data;
}
function Detalle_Medios_Prueba_VictimaInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Victima("Detalle_Medios_Prueba_VictimaTable", rowIndex)) {
    var prevData = Detalle_Medios_Prueba_VictimaTable.fnGetData(rowIndex);
    var data = Detalle_Medios_Prueba_VictimaTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Medio_de_Prueba_Presentado: $('#Detalle_Medios_Prueba_VictimaMedio_de_Prueba_Presentado').val()
        ,Fecha_de_Presentacion: $('#Detalle_Medios_Prueba_VictimaFecha_de_Presentacion').val()
        ,Archivo_AdjuntoFileInfo: { Archivo_AdjuntoFileName: prevData.Archivo_AdjuntoFileInfo.FileName, Archivo_AdjuntoFileId: prevData.Archivo_AdjuntoFileInfo.FileId, Archivo_AdjuntoFileSize: prevData.Archivo_AdjuntoFileInfo.FileSize }
        ,Archivo_AdjuntoFileDetail: $('#Archivo_Adjunto').find('label').length == 0 ? $('#Archivo_AdjuntoFileInfoPop')[0] : prevData.Archivo_AdjuntoFileDetail

    }

    Detalle_Medios_Prueba_VictimaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Medios_Prueba_VictimarowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Medios_Prueba_Victima-form').modal({ show: false });
    $('#AddDetalle_Medios_Prueba_Victima-form').modal('hide');
    Detalle_Medios_Prueba_VictimaEditRow(rowIndex);
    Detalle_Medios_Prueba_VictimaInsertRow(rowIndex);
    //}
}
function Detalle_Medios_Prueba_VictimaRemoveAddRow(rowIndex) {
    Detalle_Medios_Prueba_VictimaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Medios_Prueba_Victima MultiRow
//Begin Declarations for Foreigns fields for Detalle_Medios_Prueba_Admitidos MultiRow
var Detalle_Medios_Prueba_AdmitidoscountRowsChecked = 0;






function GetInsertDetalle_Medios_Prueba_AdmitidosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_Medios_Prueba_Admitidos_Origen Origen').attr('id', 'Detalle_Medios_Prueba_Admitidos_Origen_' + index).attr('data-field', 'Origen');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_Medios_Prueba_Admitidos_Medio_de_Prueba_Presentado Medio_de_Prueba_Presentado').attr('id', 'Detalle_Medios_Prueba_Admitidos_Medio_de_Prueba_Presentado_' + index).attr('data-field', 'Medio_de_Prueba_Presentado');
    columnData[2] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Medios_Prueba_Admitidos_Admitido Admitido').attr('id', 'Detalle_Medios_Prueba_Admitidos_Admitido_' + index).attr('data-field', 'Admitido');


    initiateUIControls();
    return columnData;
}

function Detalle_Medios_Prueba_AdmitidosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Admitidos("Detalle_Medios_Prueba_Admitidos_", "_" + rowIndex)) {
    var iPage = Detalle_Medios_Prueba_AdmitidosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Medios_Prueba_Admitidos';
    var prevData = Detalle_Medios_Prueba_AdmitidosTable.fnGetData(rowIndex);
    var data = Detalle_Medios_Prueba_AdmitidosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Origen:  data.childNodes[counter++].childNodes[0].value
        ,Medio_de_Prueba_Presentado:  data.childNodes[counter++].childNodes[0].value
        ,Admitido: $(data.childNodes[counter++].childNodes[2]).is(':checked')

    }
    Detalle_Medios_Prueba_AdmitidosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Medios_Prueba_AdmitidosrowCreationGrid(data, newData, rowIndex);
    Detalle_Medios_Prueba_AdmitidosTable.fnPageChange(iPage);
    Detalle_Medios_Prueba_AdmitidoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Medios_Prueba_Admitidos("Detalle_Medios_Prueba_Admitidos_", "_" + rowIndex);
  }
}

function Detalle_Medios_Prueba_AdmitidosCancelRow(rowIndex) {
    var prevData = Detalle_Medios_Prueba_AdmitidosTable.fnGetData(rowIndex);
    var data = Detalle_Medios_Prueba_AdmitidosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Medios_Prueba_AdmitidosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Medios_Prueba_AdmitidosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Medios_Prueba_AdmitidosGrid(Detalle_Medios_Prueba_AdmitidosTable.fnGetData());
    Detalle_Medios_Prueba_AdmitidoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Medios_Prueba_AdmitidosFromDataTable() {
    var Detalle_Medios_Prueba_AdmitidosData = [];
    var gridData = Detalle_Medios_Prueba_AdmitidosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Medios_Prueba_AdmitidosData.push({
                Clave: gridData[i].Clave

                ,Origen: gridData[i].Origen
                ,Medio_de_Prueba_Presentado: gridData[i].Medio_de_Prueba_Presentado
                ,Admitido: gridData[i].Admitido

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Medios_Prueba_AdmitidosData.length; i++) {
        if (removedDetalle_Medios_Prueba_AdmitidosData[i] != null && removedDetalle_Medios_Prueba_AdmitidosData[i].Clave > 0)
            Detalle_Medios_Prueba_AdmitidosData.push({
                Clave: removedDetalle_Medios_Prueba_AdmitidosData[i].Clave

                ,Origen: removedDetalle_Medios_Prueba_AdmitidosData[i].Origen
                ,Medio_de_Prueba_Presentado: removedDetalle_Medios_Prueba_AdmitidosData[i].Medio_de_Prueba_Presentado
                ,Admitido: removedDetalle_Medios_Prueba_AdmitidosData[i].Admitido

                , Removed: true
            });
    }	

    return Detalle_Medios_Prueba_AdmitidosData;
}

function Detalle_Medios_Prueba_AdmitidosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Medios_Prueba_AdmitidosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Medios_Prueba_AdmitidoscountRowsChecked++;
    var Detalle_Medios_Prueba_AdmitidosRowElement = "Detalle_Medios_Prueba_Admitidos_" + rowIndex.toString();
    var prevData = Detalle_Medios_Prueba_AdmitidosTable.fnGetData(rowIndexTable );
    var row = Detalle_Medios_Prueba_AdmitidosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Medios_Prueba_Admitidos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Medios_Prueba_AdmitidosGetUpdateRowControls(prevData, "Detalle_Medios_Prueba_Admitidos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Medios_Prueba_AdmitidosRowElement + "')){ Detalle_Medios_Prueba_AdmitidosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Medios_Prueba_AdmitidosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Medios_Prueba_AdmitidosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Medios_Prueba_AdmitidosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Medios_Prueba_AdmitidosValidation();
    initiateUIControls();
    $('.Detalle_Medios_Prueba_Admitidos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Medios_Prueba_AdmitidosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Medios_Prueba_AdmitidosTable.fnGetData().length;
    Detalle_Medios_Prueba_AdmitidosfnClickAddRow();
    GetAddDetalle_Medios_Prueba_AdmitidosPopup(currentRowIndex, 0);
}

function Detalle_Medios_Prueba_AdmitidosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Medios_Prueba_AdmitidosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Medios_Prueba_AdmitidosRowElement = "Detalle_Medios_Prueba_Admitidos_" + rowIndex.toString();
    var prevData = Detalle_Medios_Prueba_AdmitidosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Medios_Prueba_AdmitidosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Medios_Prueba_AdmitidosOrigen').val(prevData.Origen);
    $('#Detalle_Medios_Prueba_AdmitidosMedio_de_Prueba_Presentado').val(prevData.Medio_de_Prueba_Presentado);
    $('#Detalle_Medios_Prueba_AdmitidosAdmitido').prop('checked', prevData.Admitido);

    initiateUIControls();





}

function Detalle_Medios_Prueba_AdmitidosAddInsertRow() {
    if (Detalle_Medios_Prueba_AdmitidosinsertRowCurrentIndex < 1)
    {
        Detalle_Medios_Prueba_AdmitidosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Origen: ""
        ,Medio_de_Prueba_Presentado: ""
        ,Admitido: ""

    }
}

function Detalle_Medios_Prueba_AdmitidosfnClickAddRow() {
    Detalle_Medios_Prueba_AdmitidoscountRowsChecked++;
    Detalle_Medios_Prueba_AdmitidosTable.fnAddData(Detalle_Medios_Prueba_AdmitidosAddInsertRow(), true);
    Detalle_Medios_Prueba_AdmitidosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Medios_Prueba_AdmitidosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Medios_Prueba_AdmitidosGrid tbody tr:nth-of-type(' + (Detalle_Medios_Prueba_AdmitidosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Medios_Prueba_Admitidos("Detalle_Medios_Prueba_Admitidos_", "_" + Detalle_Medios_Prueba_AdmitidosinsertRowCurrentIndex);
}

function Detalle_Medios_Prueba_AdmitidosClearGridData() {
    Detalle_Medios_Prueba_AdmitidosData = [];
    Detalle_Medios_Prueba_AdmitidosdeletedItem = [];
    Detalle_Medios_Prueba_AdmitidosDataMain = [];
    Detalle_Medios_Prueba_AdmitidosDataMainPages = [];
    Detalle_Medios_Prueba_AdmitidosnewItemCount = 0;
    Detalle_Medios_Prueba_AdmitidosmaxItemIndex = 0;
    $("#Detalle_Medios_Prueba_AdmitidosGrid").DataTable().clear();
    $("#Detalle_Medios_Prueba_AdmitidosGrid").DataTable().destroy();
}

//Used to Get Proceso Penal Information
function GetDetalle_Medios_Prueba_Admitidos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Medios_Prueba_AdmitidosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Medios_Prueba_AdmitidosData[i].Clave);

        form_data.append('[' + i + '].Origen', Detalle_Medios_Prueba_AdmitidosData[i].Origen);
        form_data.append('[' + i + '].Medio_de_Prueba_Presentado', Detalle_Medios_Prueba_AdmitidosData[i].Medio_de_Prueba_Presentado);
        form_data.append('[' + i + '].Admitido', Detalle_Medios_Prueba_AdmitidosData[i].Admitido);

        form_data.append('[' + i + '].Removed', Detalle_Medios_Prueba_AdmitidosData[i].Removed);
    }
    return form_data;
}
function Detalle_Medios_Prueba_AdmitidosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Admitidos("Detalle_Medios_Prueba_AdmitidosTable", rowIndex)) {
    var prevData = Detalle_Medios_Prueba_AdmitidosTable.fnGetData(rowIndex);
    var data = Detalle_Medios_Prueba_AdmitidosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Origen: $('#Detalle_Medios_Prueba_AdmitidosOrigen').val()
        ,Medio_de_Prueba_Presentado: $('#Detalle_Medios_Prueba_AdmitidosMedio_de_Prueba_Presentado').val()
        ,Admitido: $('#Detalle_Medios_Prueba_AdmitidosAdmitido').is(':checked')

    }

    Detalle_Medios_Prueba_AdmitidosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Medios_Prueba_AdmitidosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Medios_Prueba_Admitidos-form').modal({ show: false });
    $('#AddDetalle_Medios_Prueba_Admitidos-form').modal('hide');
    Detalle_Medios_Prueba_AdmitidosEditRow(rowIndex);
    Detalle_Medios_Prueba_AdmitidosInsertRow(rowIndex);
    //}
}
function Detalle_Medios_Prueba_AdmitidosRemoveAddRow(rowIndex) {
    Detalle_Medios_Prueba_AdmitidosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Medios_Prueba_Admitidos MultiRow
//Begin Declarations for Foreigns fields for Detalle_Condiciones_Proceso_Penal MultiRow
var Detalle_Condiciones_Proceso_PenalcountRowsChecked = 0;

function GetDetalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalName(Id) {
    for (var i = 0; i < Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalItems.length; i++) {
        if (Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalItems[i].Clave == Id) {
            return Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalDropDown() {
    var Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Condiciones_Proceso_Penal_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalDropdown);
    if(Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalItems != null)
    {
       for (var i = 0; i < Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalItems.length; i++) {
           $('<option />', { value: Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalItems[i].Clave, text:    Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalItems[i].Descripcion }).appendTo(Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalDropdown);
       }
    }
    return Detalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalDropdown;
}


function GetInsertDetalle_Condiciones_Proceso_PenalRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalDropDown()).addClass('Detalle_Condiciones_Proceso_Penal_Medida_Cautelar Medida_Cautelar').attr('id', 'Detalle_Condiciones_Proceso_Penal_Medida_Cautelar_' + index).attr('data-field', 'Medida_Cautelar').after($.parseHTML(addNew('Detalle_Condiciones_Proceso_Penal', 'Condiciones_en_Suspension_Condicional', 'Medida_Cautelar', 267770)));


    initiateUIControls();
    return columnData;
}

function Detalle_Condiciones_Proceso_PenalInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Condiciones_Proceso_Penal("Detalle_Condiciones_Proceso_Penal_", "_" + rowIndex)) {
    var iPage = Detalle_Condiciones_Proceso_PenalTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Condiciones_Proceso_Penal';
    var prevData = Detalle_Condiciones_Proceso_PenalTable.fnGetData(rowIndex);
    var data = Detalle_Condiciones_Proceso_PenalTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Medida_Cautelar:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Condiciones_Proceso_PenalTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Condiciones_Proceso_PenalrowCreationGrid(data, newData, rowIndex);
    Detalle_Condiciones_Proceso_PenalTable.fnPageChange(iPage);
    Detalle_Condiciones_Proceso_PenalcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Condiciones_Proceso_Penal("Detalle_Condiciones_Proceso_Penal_", "_" + rowIndex);
  }
}

function Detalle_Condiciones_Proceso_PenalCancelRow(rowIndex) {
    var prevData = Detalle_Condiciones_Proceso_PenalTable.fnGetData(rowIndex);
    var data = Detalle_Condiciones_Proceso_PenalTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Condiciones_Proceso_PenalTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Condiciones_Proceso_PenalrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Condiciones_Proceso_PenalGrid(Detalle_Condiciones_Proceso_PenalTable.fnGetData());
    Detalle_Condiciones_Proceso_PenalcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Condiciones_Proceso_PenalFromDataTable() {
    var Detalle_Condiciones_Proceso_PenalData = [];
    var gridData = Detalle_Condiciones_Proceso_PenalTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Condiciones_Proceso_PenalData.push({
                Clave: gridData[i].Clave

                ,Medida_Cautelar: gridData[i].Medida_Cautelar

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Condiciones_Proceso_PenalData.length; i++) {
        if (removedDetalle_Condiciones_Proceso_PenalData[i] != null && removedDetalle_Condiciones_Proceso_PenalData[i].Clave > 0)
            Detalle_Condiciones_Proceso_PenalData.push({
                Clave: removedDetalle_Condiciones_Proceso_PenalData[i].Clave

                ,Medida_Cautelar: removedDetalle_Condiciones_Proceso_PenalData[i].Medida_Cautelar

                , Removed: true
            });
    }	

    return Detalle_Condiciones_Proceso_PenalData;
}

function Detalle_Condiciones_Proceso_PenalEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Condiciones_Proceso_PenalTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Condiciones_Proceso_PenalcountRowsChecked++;
    var Detalle_Condiciones_Proceso_PenalRowElement = "Detalle_Condiciones_Proceso_Penal_" + rowIndex.toString();
    var prevData = Detalle_Condiciones_Proceso_PenalTable.fnGetData(rowIndexTable );
    var row = Detalle_Condiciones_Proceso_PenalTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Condiciones_Proceso_Penal_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Condiciones_Proceso_PenalGetUpdateRowControls(prevData, "Detalle_Condiciones_Proceso_Penal_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Condiciones_Proceso_PenalRowElement + "')){ Detalle_Condiciones_Proceso_PenalInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Condiciones_Proceso_PenalCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Condiciones_Proceso_PenalGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Condiciones_Proceso_PenalGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Condiciones_Proceso_PenalValidation();
    initiateUIControls();
    $('.Detalle_Condiciones_Proceso_Penal' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Condiciones_Proceso_PenalfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Condiciones_Proceso_PenalTable.fnGetData().length;
    Detalle_Condiciones_Proceso_PenalfnClickAddRow();
    GetAddDetalle_Condiciones_Proceso_PenalPopup(currentRowIndex, 0);
}

function Detalle_Condiciones_Proceso_PenalEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Condiciones_Proceso_PenalTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Condiciones_Proceso_PenalRowElement = "Detalle_Condiciones_Proceso_Penal_" + rowIndex.toString();
    var prevData = Detalle_Condiciones_Proceso_PenalTable.fnGetData(rowIndexTable);
    GetAddDetalle_Condiciones_Proceso_PenalPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Condiciones_Proceso_PenalMedida_Cautelar').val(prevData.Medida_Cautelar);

    initiateUIControls();



}

function Detalle_Condiciones_Proceso_PenalAddInsertRow() {
    if (Detalle_Condiciones_Proceso_PenalinsertRowCurrentIndex < 1)
    {
        Detalle_Condiciones_Proceso_PenalinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Medida_Cautelar: ""

    }
}

function Detalle_Condiciones_Proceso_PenalfnClickAddRow() {
    Detalle_Condiciones_Proceso_PenalcountRowsChecked++;
    Detalle_Condiciones_Proceso_PenalTable.fnAddData(Detalle_Condiciones_Proceso_PenalAddInsertRow(), true);
    Detalle_Condiciones_Proceso_PenalTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Condiciones_Proceso_PenalGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Condiciones_Proceso_PenalGrid tbody tr:nth-of-type(' + (Detalle_Condiciones_Proceso_PenalinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Condiciones_Proceso_Penal("Detalle_Condiciones_Proceso_Penal_", "_" + Detalle_Condiciones_Proceso_PenalinsertRowCurrentIndex);
}

function Detalle_Condiciones_Proceso_PenalClearGridData() {
    Detalle_Condiciones_Proceso_PenalData = [];
    Detalle_Condiciones_Proceso_PenaldeletedItem = [];
    Detalle_Condiciones_Proceso_PenalDataMain = [];
    Detalle_Condiciones_Proceso_PenalDataMainPages = [];
    Detalle_Condiciones_Proceso_PenalnewItemCount = 0;
    Detalle_Condiciones_Proceso_PenalmaxItemIndex = 0;
    $("#Detalle_Condiciones_Proceso_PenalGrid").DataTable().clear();
    $("#Detalle_Condiciones_Proceso_PenalGrid").DataTable().destroy();
}

//Used to Get Proceso Penal Information
function GetDetalle_Condiciones_Proceso_Penal() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Condiciones_Proceso_PenalData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Condiciones_Proceso_PenalData[i].Clave);

        form_data.append('[' + i + '].Medida_Cautelar', Detalle_Condiciones_Proceso_PenalData[i].Medida_Cautelar);

        form_data.append('[' + i + '].Removed', Detalle_Condiciones_Proceso_PenalData[i].Removed);
    }
    return form_data;
}
function Detalle_Condiciones_Proceso_PenalInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Condiciones_Proceso_Penal("Detalle_Condiciones_Proceso_PenalTable", rowIndex)) {
    var prevData = Detalle_Condiciones_Proceso_PenalTable.fnGetData(rowIndex);
    var data = Detalle_Condiciones_Proceso_PenalTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Medida_Cautelar: $('#Detalle_Condiciones_Proceso_PenalMedida_Cautelar').val()

    }

    Detalle_Condiciones_Proceso_PenalTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Condiciones_Proceso_PenalrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Condiciones_Proceso_Penal-form').modal({ show: false });
    $('#AddDetalle_Condiciones_Proceso_Penal-form').modal('hide');
    Detalle_Condiciones_Proceso_PenalEditRow(rowIndex);
    Detalle_Condiciones_Proceso_PenalInsertRow(rowIndex);
    //}
}
function Detalle_Condiciones_Proceso_PenalRemoveAddRow(rowIndex) {
    Detalle_Condiciones_Proceso_PenalTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Condiciones_Proceso_Penal MultiRow


$(function () {
    function Detalle_Delitos_Proceso_PenalinitializeMainArray(totalCount) {
        if (Detalle_Delitos_Proceso_PenalDataMain.length != totalCount && !Detalle_Delitos_Proceso_PenalDataMainInitialized) {
            Detalle_Delitos_Proceso_PenalDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Delitos_Proceso_PenalDataMain[i] = null;
            }
        }
    }
    function Detalle_Delitos_Proceso_PenalremoveFromMainArray() {
        for (var j = 0; j < Detalle_Delitos_Proceso_PenaldeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Delitos_Proceso_PenalDataMain.length; i++) {
                if (Detalle_Delitos_Proceso_PenalDataMain[i] != null && Detalle_Delitos_Proceso_PenalDataMain[i].Id == Detalle_Delitos_Proceso_PenaldeletedItem[j]) {
                    hDetalle_Delitos_Proceso_PenalDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Delitos_Proceso_PenalcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Delitos_Proceso_PenalDataMain.length; i++) {
            data[i] = Detalle_Delitos_Proceso_PenalDataMain[i];

        }
        return data;
    }
    function Detalle_Delitos_Proceso_PenalgetNewResult() {
        var newData = copyMainDetalle_Delitos_Proceso_PenalArray();

        for (var i = 0; i < Detalle_Delitos_Proceso_PenalData.length; i++) {
            if (Detalle_Delitos_Proceso_PenalData[i].Removed == null || Detalle_Delitos_Proceso_PenalData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Delitos_Proceso_PenalData[i]);
            }
        }
        return newData;
    }
    function Detalle_Delitos_Proceso_PenalpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Delitos_Proceso_PenalDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Delitos_Proceso_PenalDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Medidas_Cautelares_Proceso_PenalinitializeMainArray(totalCount) {
        if (Detalle_Medidas_Cautelares_Proceso_PenalDataMain.length != totalCount && !Detalle_Medidas_Cautelares_Proceso_PenalDataMainInitialized) {
            Detalle_Medidas_Cautelares_Proceso_PenalDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Medidas_Cautelares_Proceso_PenalDataMain[i] = null;
            }
        }
    }
    function Detalle_Medidas_Cautelares_Proceso_PenalremoveFromMainArray() {
        for (var j = 0; j < Detalle_Medidas_Cautelares_Proceso_PenaldeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Medidas_Cautelares_Proceso_PenalDataMain.length; i++) {
                if (Detalle_Medidas_Cautelares_Proceso_PenalDataMain[i] != null && Detalle_Medidas_Cautelares_Proceso_PenalDataMain[i].Id == Detalle_Medidas_Cautelares_Proceso_PenaldeletedItem[j]) {
                    hDetalle_Medidas_Cautelares_Proceso_PenalDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Medidas_Cautelares_Proceso_PenalcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Medidas_Cautelares_Proceso_PenalDataMain.length; i++) {
            data[i] = Detalle_Medidas_Cautelares_Proceso_PenalDataMain[i];

        }
        return data;
    }
    function Detalle_Medidas_Cautelares_Proceso_PenalgetNewResult() {
        var newData = copyMainDetalle_Medidas_Cautelares_Proceso_PenalArray();

        for (var i = 0; i < Detalle_Medidas_Cautelares_Proceso_PenalData.length; i++) {
            if (Detalle_Medidas_Cautelares_Proceso_PenalData[i].Removed == null || Detalle_Medidas_Cautelares_Proceso_PenalData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Medidas_Cautelares_Proceso_PenalData[i]);
            }
        }
        return newData;
    }
    function Detalle_Medidas_Cautelares_Proceso_PenalpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Medidas_Cautelares_Proceso_PenalDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Medidas_Cautelares_Proceso_PenalDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Medios_Prueba_ImputadoinitializeMainArray(totalCount) {
        if (Detalle_Medios_Prueba_ImputadoDataMain.length != totalCount && !Detalle_Medios_Prueba_ImputadoDataMainInitialized) {
            Detalle_Medios_Prueba_ImputadoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Medios_Prueba_ImputadoDataMain[i] = null;
            }
        }
    }
    function Detalle_Medios_Prueba_ImputadoremoveFromMainArray() {
        for (var j = 0; j < Detalle_Medios_Prueba_ImputadodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Medios_Prueba_ImputadoDataMain.length; i++) {
                if (Detalle_Medios_Prueba_ImputadoDataMain[i] != null && Detalle_Medios_Prueba_ImputadoDataMain[i].Id == Detalle_Medios_Prueba_ImputadodeletedItem[j]) {
                    hDetalle_Medios_Prueba_ImputadoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Medios_Prueba_ImputadocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Medios_Prueba_ImputadoDataMain.length; i++) {
            data[i] = Detalle_Medios_Prueba_ImputadoDataMain[i];

        }
        return data;
    }
    function Detalle_Medios_Prueba_ImputadogetNewResult() {
        var newData = copyMainDetalle_Medios_Prueba_ImputadoArray();

        for (var i = 0; i < Detalle_Medios_Prueba_ImputadoData.length; i++) {
            if (Detalle_Medios_Prueba_ImputadoData[i].Removed == null || Detalle_Medios_Prueba_ImputadoData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Medios_Prueba_ImputadoData[i]);
            }
        }
        return newData;
    }
    function Detalle_Medios_Prueba_ImputadopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Medios_Prueba_ImputadoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Medios_Prueba_ImputadoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Medios_Prueba_VictimainitializeMainArray(totalCount) {
        if (Detalle_Medios_Prueba_VictimaDataMain.length != totalCount && !Detalle_Medios_Prueba_VictimaDataMainInitialized) {
            Detalle_Medios_Prueba_VictimaDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Medios_Prueba_VictimaDataMain[i] = null;
            }
        }
    }
    function Detalle_Medios_Prueba_VictimaremoveFromMainArray() {
        for (var j = 0; j < Detalle_Medios_Prueba_VictimadeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Medios_Prueba_VictimaDataMain.length; i++) {
                if (Detalle_Medios_Prueba_VictimaDataMain[i] != null && Detalle_Medios_Prueba_VictimaDataMain[i].Id == Detalle_Medios_Prueba_VictimadeletedItem[j]) {
                    hDetalle_Medios_Prueba_VictimaDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Medios_Prueba_VictimacopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Medios_Prueba_VictimaDataMain.length; i++) {
            data[i] = Detalle_Medios_Prueba_VictimaDataMain[i];

        }
        return data;
    }
    function Detalle_Medios_Prueba_VictimagetNewResult() {
        var newData = copyMainDetalle_Medios_Prueba_VictimaArray();

        for (var i = 0; i < Detalle_Medios_Prueba_VictimaData.length; i++) {
            if (Detalle_Medios_Prueba_VictimaData[i].Removed == null || Detalle_Medios_Prueba_VictimaData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Medios_Prueba_VictimaData[i]);
            }
        }
        return newData;
    }
    function Detalle_Medios_Prueba_VictimapushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Medios_Prueba_VictimaDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Medios_Prueba_VictimaDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Medios_Prueba_AdmitidosinitializeMainArray(totalCount) {
        if (Detalle_Medios_Prueba_AdmitidosDataMain.length != totalCount && !Detalle_Medios_Prueba_AdmitidosDataMainInitialized) {
            Detalle_Medios_Prueba_AdmitidosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Medios_Prueba_AdmitidosDataMain[i] = null;
            }
        }
    }
    function Detalle_Medios_Prueba_AdmitidosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Medios_Prueba_AdmitidosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Medios_Prueba_AdmitidosDataMain.length; i++) {
                if (Detalle_Medios_Prueba_AdmitidosDataMain[i] != null && Detalle_Medios_Prueba_AdmitidosDataMain[i].Id == Detalle_Medios_Prueba_AdmitidosdeletedItem[j]) {
                    hDetalle_Medios_Prueba_AdmitidosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Medios_Prueba_AdmitidoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Medios_Prueba_AdmitidosDataMain.length; i++) {
            data[i] = Detalle_Medios_Prueba_AdmitidosDataMain[i];

        }
        return data;
    }
    function Detalle_Medios_Prueba_AdmitidosgetNewResult() {
        var newData = copyMainDetalle_Medios_Prueba_AdmitidosArray();

        for (var i = 0; i < Detalle_Medios_Prueba_AdmitidosData.length; i++) {
            if (Detalle_Medios_Prueba_AdmitidosData[i].Removed == null || Detalle_Medios_Prueba_AdmitidosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Medios_Prueba_AdmitidosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Medios_Prueba_AdmitidospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Medios_Prueba_AdmitidosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Medios_Prueba_AdmitidosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Condiciones_Proceso_PenalinitializeMainArray(totalCount) {
        if (Detalle_Condiciones_Proceso_PenalDataMain.length != totalCount && !Detalle_Condiciones_Proceso_PenalDataMainInitialized) {
            Detalle_Condiciones_Proceso_PenalDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Condiciones_Proceso_PenalDataMain[i] = null;
            }
        }
    }
    function Detalle_Condiciones_Proceso_PenalremoveFromMainArray() {
        for (var j = 0; j < Detalle_Condiciones_Proceso_PenaldeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Condiciones_Proceso_PenalDataMain.length; i++) {
                if (Detalle_Condiciones_Proceso_PenalDataMain[i] != null && Detalle_Condiciones_Proceso_PenalDataMain[i].Id == Detalle_Condiciones_Proceso_PenaldeletedItem[j]) {
                    hDetalle_Condiciones_Proceso_PenalDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Condiciones_Proceso_PenalcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Condiciones_Proceso_PenalDataMain.length; i++) {
            data[i] = Detalle_Condiciones_Proceso_PenalDataMain[i];

        }
        return data;
    }
    function Detalle_Condiciones_Proceso_PenalgetNewResult() {
        var newData = copyMainDetalle_Condiciones_Proceso_PenalArray();

        for (var i = 0; i < Detalle_Condiciones_Proceso_PenalData.length; i++) {
            if (Detalle_Condiciones_Proceso_PenalData[i].Removed == null || Detalle_Condiciones_Proceso_PenalData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Condiciones_Proceso_PenalData[i]);
            }
        }
        return newData;
    }
    function Detalle_Condiciones_Proceso_PenalpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Condiciones_Proceso_PenalDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Condiciones_Proceso_PenalDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteExpediente_MPData = [];
function GetAutoCompleteProceso_Penal_Expediente_MP_expediente_ministerio_publicoData(data) {
	AutoCompleteExpediente_MPData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MPData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteExpediente_MPData;
}
var AutoCompleteImputadoData = [];
function GetAutoCompleteProceso_Penal_Imputado_Detalle_de_ImputadoData(data) {
	AutoCompleteImputadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteImputadoData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo_Detenido
        });
    }
    return AutoCompleteImputadoData;
}
//Grid GetAutocomplete
var AutoCompleteDelitoData = [];
function GetAutoCompleteDetalle_Delitos_Proceso_Penal_Delito_DelitoData(data) {
	AutoCompleteDelitoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteDelitoData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteDelitoData;
}

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Proceso_Penal_cmbLabelSelect").val();
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
    $("#ReferenceFolio").val("0");
    $('#CreateProceso_Penal')[0].reset();
    ClearFormControls();
    $("#FolioId").val("0");
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Imputado').empty();
    $("#Imputado").append('<option value=""></option>');
    $('#Imputado').val('0').trigger('change');
                Detalle_Delitos_Proceso_PenalClearGridData();
                Detalle_Medidas_Cautelares_Proceso_PenalClearGridData();
                Detalle_Medios_Prueba_ImputadoClearGridData();
                Detalle_Medios_Prueba_VictimaClearGridData();
                Detalle_Medios_Prueba_AdmitidosClearGridData();
                Detalle_Condiciones_Proceso_PenalClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateProceso_Penal').trigger('reset');
    $('#CreateProceso_Penal').find(':input').each(function () {
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
    var $myForm = $('#CreateProceso_Penal');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Delitos_Proceso_PenalcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Delitos_Proceso_Penal();
        return false;
    }
    if (Detalle_Medidas_Cautelares_Proceso_PenalcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Medidas_Cautelares_Proceso_Penal();
        return false;
    }
    if (Detalle_Medios_Prueba_ImputadocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Medios_Prueba_Imputado();
        return false;
    }
    if (Detalle_Medios_Prueba_VictimacountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Medios_Prueba_Victima();
        return false;
    }
    if (Detalle_Medios_Prueba_AdmitidoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Medios_Prueba_Admitidos();
        return false;
    }
    if (Detalle_Condiciones_Proceso_PenalcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Condiciones_Proceso_Penal();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblFolio").text("0");
}
$(document).ready(function () {
    $("form#CreateProceso_Penal").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateProceso_Penal").on('click', '#Proceso_PenalCancelar', function () {
	  if (!isPartial) {
        Proceso_PenalBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateProceso_Penal").on('click', '#Proceso_PenalGuardar', function () {
		$('#Proceso_PenalGuardar').attr('disabled', true);
		$('#Proceso_PenalGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendProceso_PenalData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Proceso_PenalBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Proceso_PenalGuardar').removeAttr('disabled');
                        $('#Proceso_PenalGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Proceso_Penal', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Proceso_PenalItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Proceso_PenalDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Proceso_PenalGuardar').removeAttr('disabled');
					$('#Proceso_PenalGuardar').bind()
				}
		}
		else {
			$('#Proceso_PenalGuardar').removeAttr('disabled');
			$('#Proceso_PenalGuardar').bind()
		}
    });
	$("form#CreateProceso_Penal").on('click', '#Proceso_PenalGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendProceso_PenalData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Delitos_Proceso_PenalData();
                getDetalle_Medidas_Cautelares_Proceso_PenalData();
                getDetalle_Medios_Prueba_ImputadoData();
                getDetalle_Medios_Prueba_VictimaData();
                getDetalle_Medios_Prueba_AdmitidosData();
                getDetalle_Condiciones_Proceso_PenalData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Proceso_Penal', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Proceso_PenalItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Proceso_PenalDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateProceso_Penal").on('click', '#Proceso_PenalGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendProceso_PenalData(function (currentId) {
					$("#FolioId").val("0");
	    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Imputado').empty();
    $("#Imputado").append('<option value=""></option>');
    $('#Imputado').val('0').trigger('change');
                Detalle_Delitos_Proceso_PenalClearGridData();
                Detalle_Medidas_Cautelares_Proceso_PenalClearGridData();
                Detalle_Medios_Prueba_ImputadoClearGridData();
                Detalle_Medios_Prueba_VictimaClearGridData();
                Detalle_Medios_Prueba_AdmitidosClearGridData();
                Detalle_Condiciones_Proceso_PenalClearGridData();

					ResetClaveLabel();
					$("#ReferenceFolio").val(currentId);
	                getDetalle_Delitos_Proceso_PenalData();
                getDetalle_Medidas_Cautelares_Proceso_PenalData();
                getDetalle_Medios_Prueba_ImputadoData();
                getDetalle_Medios_Prueba_VictimaData();
                getDetalle_Medios_Prueba_AdmitidosData();
                getDetalle_Condiciones_Proceso_PenalData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Proceso_Penal',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Proceso_PenalItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Proceso_PenalDropDown().get(0)').innerHTML);                          
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



var Proceso_PenalisdisplayBusinessPropery = false;
Proceso_PenalDisplayBusinessRuleButtons(Proceso_PenalisdisplayBusinessPropery);
function Proceso_PenalDisplayBusinessRule() {
    if (!Proceso_PenalisdisplayBusinessPropery) {
        $('#CreateProceso_Penal').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Proceso_PenaldisplayBusinessPropery"><button onclick="Proceso_PenalGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Proceso_PenalBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Proceso_PenaldisplayBusinessPropery').remove();
    }
    Proceso_PenalDisplayBusinessRuleButtons(!Proceso_PenalisdisplayBusinessPropery);
    Proceso_PenalisdisplayBusinessPropery = (Proceso_PenalisdisplayBusinessPropery ? false : true);
}
function Proceso_PenalDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

