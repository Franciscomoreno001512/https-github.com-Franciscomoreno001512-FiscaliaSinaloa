        function RemoveAttachmentMainImagen_Tatuaje () {
            $("#hdnRemoveImagen_Tatuaje").val("1");
            $("#divAttachmentImagen_Tatuaje").hide();
        }


//Begin Declarations for Foreigns fields for Otros_Nombres_Requerido_MASC MultiRow
var Otros_Nombres_Requerido_MASCcountRowsChecked = 0;




function GetInsertOtros_Nombres_Requerido_MASCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Otros_Nombres_Requerido_MASC_Descripcion Descripcion').attr('id', 'Otros_Nombres_Requerido_MASC_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Otros_Nombres_Requerido_MASCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMROtros_Nombres_Requerido_MASC("Otros_Nombres_Requerido_MASC_", "_" + rowIndex)) {
    var iPage = Otros_Nombres_Requerido_MASCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Otros_Nombres_Requerido_MASC';
    var prevData = Otros_Nombres_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Otros_Nombres_Requerido_MASCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Otros_Nombres_Requerido_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Otros_Nombres_Requerido_MASCrowCreationGrid(data, newData, rowIndex);
    Otros_Nombres_Requerido_MASCTable.fnPageChange(iPage);
    Otros_Nombres_Requerido_MASCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMROtros_Nombres_Requerido_MASC("Otros_Nombres_Requerido_MASC_", "_" + rowIndex);
  }
}

function Otros_Nombres_Requerido_MASCCancelRow(rowIndex) {
    var prevData = Otros_Nombres_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Otros_Nombres_Requerido_MASCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Otros_Nombres_Requerido_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Otros_Nombres_Requerido_MASCrowCreationGrid(data, prevData, rowIndex);
    }
	showOtros_Nombres_Requerido_MASCGrid(Otros_Nombres_Requerido_MASCTable.fnGetData());
    Otros_Nombres_Requerido_MASCcountRowsChecked--;
	initiateUIControls();
}

function GetOtros_Nombres_Requerido_MASCFromDataTable() {
    var Otros_Nombres_Requerido_MASCData = [];
    var gridData = Otros_Nombres_Requerido_MASCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Otros_Nombres_Requerido_MASCData.push({
                Clave: gridData[i].Clave

                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedOtros_Nombres_Requerido_MASCData.length; i++) {
        if (removedOtros_Nombres_Requerido_MASCData[i] != null && removedOtros_Nombres_Requerido_MASCData[i].Clave > 0)
            Otros_Nombres_Requerido_MASCData.push({
                Clave: removedOtros_Nombres_Requerido_MASCData[i].Clave

                ,Descripcion: removedOtros_Nombres_Requerido_MASCData[i].Descripcion

                , Removed: true
            });
    }	

    return Otros_Nombres_Requerido_MASCData;
}

function Otros_Nombres_Requerido_MASCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Otros_Nombres_Requerido_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Otros_Nombres_Requerido_MASCcountRowsChecked++;
    var Otros_Nombres_Requerido_MASCRowElement = "Otros_Nombres_Requerido_MASC_" + rowIndex.toString();
    var prevData = Otros_Nombres_Requerido_MASCTable.fnGetData(rowIndexTable );
    var row = Otros_Nombres_Requerido_MASCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Otros_Nombres_Requerido_MASC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Otros_Nombres_Requerido_MASCGetUpdateRowControls(prevData, "Otros_Nombres_Requerido_MASC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Otros_Nombres_Requerido_MASCRowElement + "')){ Otros_Nombres_Requerido_MASCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Otros_Nombres_Requerido_MASCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Otros_Nombres_Requerido_MASCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Otros_Nombres_Requerido_MASCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setOtros_Nombres_Requerido_MASCValidation();
    initiateUIControls();
    $('.Otros_Nombres_Requerido_MASC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMROtros_Nombres_Requerido_MASC(nameOfTable, rowIndexFormed);
    }
}

function Otros_Nombres_Requerido_MASCfnOpenAddRowPopUp() {
    var currentRowIndex = Otros_Nombres_Requerido_MASCTable.fnGetData().length;
    Otros_Nombres_Requerido_MASCfnClickAddRow();
    GetAddOtros_Nombres_Requerido_MASCPopup(currentRowIndex, 0);
}

function Otros_Nombres_Requerido_MASCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Otros_Nombres_Requerido_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Otros_Nombres_Requerido_MASCRowElement = "Otros_Nombres_Requerido_MASC_" + rowIndex.toString();
    var prevData = Otros_Nombres_Requerido_MASCTable.fnGetData(rowIndexTable);
    GetAddOtros_Nombres_Requerido_MASCPopup(rowIndex, 1, prevData.Clave);

    $('#Otros_Nombres_Requerido_MASCDescripcion').val(prevData.Descripcion);

    initiateUIControls();



}

function Otros_Nombres_Requerido_MASCAddInsertRow() {
    if (Otros_Nombres_Requerido_MASCinsertRowCurrentIndex < 1)
    {
        Otros_Nombres_Requerido_MASCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Descripcion: ""

    }
}

function Otros_Nombres_Requerido_MASCfnClickAddRow() {
    Otros_Nombres_Requerido_MASCcountRowsChecked++;
    Otros_Nombres_Requerido_MASCTable.fnAddData(Otros_Nombres_Requerido_MASCAddInsertRow(), true);
    Otros_Nombres_Requerido_MASCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Otros_Nombres_Requerido_MASCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Otros_Nombres_Requerido_MASCGrid tbody tr:nth-of-type(' + (Otros_Nombres_Requerido_MASCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMROtros_Nombres_Requerido_MASC("Otros_Nombres_Requerido_MASC_", "_" + Otros_Nombres_Requerido_MASCinsertRowCurrentIndex);
}

function Otros_Nombres_Requerido_MASCClearGridData() {
    Otros_Nombres_Requerido_MASCData = [];
    Otros_Nombres_Requerido_MASCdeletedItem = [];
    Otros_Nombres_Requerido_MASCDataMain = [];
    Otros_Nombres_Requerido_MASCDataMainPages = [];
    Otros_Nombres_Requerido_MASCnewItemCount = 0;
    Otros_Nombres_Requerido_MASCmaxItemIndex = 0;
    $("#Otros_Nombres_Requerido_MASCGrid").DataTable().clear();
    $("#Otros_Nombres_Requerido_MASCGrid").DataTable().destroy();
}

//Used to Get Requeridos Information
function GetOtros_Nombres_Requerido_MASC() {
    var form_data = new FormData();
    for (var i = 0; i < Otros_Nombres_Requerido_MASCData.length; i++) {
        form_data.append('[' + i + '].Clave', Otros_Nombres_Requerido_MASCData[i].Clave);

        form_data.append('[' + i + '].Descripcion', Otros_Nombres_Requerido_MASCData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Otros_Nombres_Requerido_MASCData[i].Removed);
    }
    return form_data;
}
function Otros_Nombres_Requerido_MASCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMROtros_Nombres_Requerido_MASC("Otros_Nombres_Requerido_MASCTable", rowIndex)) {
    var prevData = Otros_Nombres_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Otros_Nombres_Requerido_MASCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion: $('#Otros_Nombres_Requerido_MASCDescripcion').val()

    }

    Otros_Nombres_Requerido_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Otros_Nombres_Requerido_MASCrowCreationGrid(data, newData, rowIndex);
    $('#AddOtros_Nombres_Requerido_MASC-form').modal({ show: false });
    $('#AddOtros_Nombres_Requerido_MASC-form').modal('hide');
    Otros_Nombres_Requerido_MASCEditRow(rowIndex);
    Otros_Nombres_Requerido_MASCInsertRow(rowIndex);
    //}
}
function Otros_Nombres_Requerido_MASCRemoveAddRow(rowIndex) {
    Otros_Nombres_Requerido_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Otros_Nombres_Requerido_MASC MultiRow
//Begin Declarations for Foreigns fields for Otros_Domicilios_Requeridos_MASC MultiRow
var Otros_Domicilios_Requeridos_MASCcountRowsChecked = 0;

function GetOtros_Domicilios_Requeridos_MASC_EstadoName(Id) {
    for (var i = 0; i < Otros_Domicilios_Requeridos_MASC_EstadoItems.length; i++) {
        if (Otros_Domicilios_Requeridos_MASC_EstadoItems[i].Clave == Id) {
            return Otros_Domicilios_Requeridos_MASC_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Requeridos_MASC_EstadoDropDown() {
    var Otros_Domicilios_Requeridos_MASC_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Requeridos_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Requeridos_MASC_EstadoDropdown);

    for (var i = 0; i < Otros_Domicilios_Requeridos_MASC_EstadoItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Requeridos_MASC_EstadoItems[i].Clave, text: Otros_Domicilios_Requeridos_MASC_EstadoItems[i].Nombre }).appendTo(Otros_Domicilios_Requeridos_MASC_EstadoDropdown);
    }
    return Otros_Domicilios_Requeridos_MASC_EstadoDropdown;
}
function GetOtros_Domicilios_Requeridos_MASC_MunicipioName(Id) {
    for (var i = 0; i < Otros_Domicilios_Requeridos_MASC_MunicipioItems.length; i++) {
        if (Otros_Domicilios_Requeridos_MASC_MunicipioItems[i].Clave == Id) {
            return Otros_Domicilios_Requeridos_MASC_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Requeridos_MASC_MunicipioDropDown() {
    var Otros_Domicilios_Requeridos_MASC_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Requeridos_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Requeridos_MASC_MunicipioDropdown);

    for (var i = 0; i < Otros_Domicilios_Requeridos_MASC_MunicipioItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Requeridos_MASC_MunicipioItems[i].Clave, text: Otros_Domicilios_Requeridos_MASC_MunicipioItems[i].Nombre }).appendTo(Otros_Domicilios_Requeridos_MASC_MunicipioDropdown);
    }
    return Otros_Domicilios_Requeridos_MASC_MunicipioDropdown;
}
function GetOtros_Domicilios_Requeridos_MASC_ColoniaName(Id) {
    for (var i = 0; i < Otros_Domicilios_Requeridos_MASC_ColoniaItems.length; i++) {
        if (Otros_Domicilios_Requeridos_MASC_ColoniaItems[i].Clave == Id) {
            return Otros_Domicilios_Requeridos_MASC_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Requeridos_MASC_ColoniaDropDown() {
    var Otros_Domicilios_Requeridos_MASC_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Requeridos_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Requeridos_MASC_ColoniaDropdown);

    for (var i = 0; i < Otros_Domicilios_Requeridos_MASC_ColoniaItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Requeridos_MASC_ColoniaItems[i].Clave, text: Otros_Domicilios_Requeridos_MASC_ColoniaItems[i].Nombre }).appendTo(Otros_Domicilios_Requeridos_MASC_ColoniaDropdown);
    }
    return Otros_Domicilios_Requeridos_MASC_ColoniaDropdown;
}
function GetOtros_Domicilios_Requeridos_MASC_ColoniaName(Id) {
    for (var i = 0; i < Otros_Domicilios_Requeridos_MASC_ColoniaItems.length; i++) {
        if (Otros_Domicilios_Requeridos_MASC_ColoniaItems[i].Clave == Id) {
            return Otros_Domicilios_Requeridos_MASC_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Requeridos_MASC_ColoniaDropDown() {
    var Otros_Domicilios_Requeridos_MASC_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Requeridos_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Requeridos_MASC_ColoniaDropdown);

    for (var i = 0; i < Otros_Domicilios_Requeridos_MASC_ColoniaItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Requeridos_MASC_ColoniaItems[i].Clave, text: Otros_Domicilios_Requeridos_MASC_ColoniaItems[i].Nombre }).appendTo(Otros_Domicilios_Requeridos_MASC_ColoniaDropdown);
    }
    return Otros_Domicilios_Requeridos_MASC_ColoniaDropdown;
}







function GetInsertOtros_Domicilios_Requeridos_MASCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Requeridos_MASC_Estado'))).addClass('Otros_Domicilios_Requeridos_MASC_Estado Estado').attr('id', 'Otros_Domicilios_Requeridos_MASC_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Otros_Domicilios_Requeridos_MASC', 'Estado', 'Estado', 265935)));
    columnData[1] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Requeridos_MASC_Municipio'))).addClass('Otros_Domicilios_Requeridos_MASC_Municipio Municipio').attr('id', 'Otros_Domicilios_Requeridos_MASC_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Otros_Domicilios_Requeridos_MASC', 'Municipio', 'Municipio', 265936)));
    columnData[2] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Requeridos_MASC_Poblacion'))).addClass('Otros_Domicilios_Requeridos_MASC_Poblacion Poblacion').attr('id', 'Otros_Domicilios_Requeridos_MASC_Poblacion_' + index).attr('data-field', 'Poblacion').after($.parseHTML(addNew('Otros_Domicilios_Requeridos_MASC', 'Colonia', 'Poblacion', 265937)));
    columnData[3] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Requeridos_MASC_Colonia'))).addClass('Otros_Domicilios_Requeridos_MASC_Colonia Colonia').attr('id', 'Otros_Domicilios_Requeridos_MASC_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Otros_Domicilios_Requeridos_MASC', 'Colonia', 'Colonia', 265938)));
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Otros_Domicilios_Requeridos_MASC_Codigo_Postal Codigo_Postal').attr('id', 'Otros_Domicilios_Requeridos_MASC_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[5] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Requeridos_MASC_Calle Calle').attr('id', 'Otros_Domicilios_Requeridos_MASC_Calle_' + index).attr('data-field', 'Calle');
    columnData[6] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Requeridos_MASC_Entre_Calle Entre_Calle').attr('id', 'Otros_Domicilios_Requeridos_MASC_Entre_Calle_' + index).attr('data-field', 'Entre_Calle');
    columnData[7] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Requeridos_MASC_Y_Calle Y_Calle').attr('id', 'Otros_Domicilios_Requeridos_MASC_Y_Calle_' + index).attr('data-field', 'Y_Calle');
    columnData[8] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Requeridos_MASC_Numero_Exterior Numero_Exterior').attr('id', 'Otros_Domicilios_Requeridos_MASC_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');


    initiateUIControls();
    return columnData;
}

function Otros_Domicilios_Requeridos_MASCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMROtros_Domicilios_Requeridos_MASC("Otros_Domicilios_Requeridos_MASC_", "_" + rowIndex)) {
    var iPage = Otros_Domicilios_Requeridos_MASCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Otros_Domicilios_Requeridos_MASC';
    var prevData = Otros_Domicilios_Requeridos_MASCTable.fnGetData(rowIndex);
    var data = Otros_Domicilios_Requeridos_MASCTable.fnGetNodes(rowIndex);
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

    }
    Otros_Domicilios_Requeridos_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Otros_Domicilios_Requeridos_MASCrowCreationGrid(data, newData, rowIndex);
    Otros_Domicilios_Requeridos_MASCTable.fnPageChange(iPage);
    Otros_Domicilios_Requeridos_MASCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMROtros_Domicilios_Requeridos_MASC("Otros_Domicilios_Requeridos_MASC_", "_" + rowIndex);
  }
}

function Otros_Domicilios_Requeridos_MASCCancelRow(rowIndex) {
    var prevData = Otros_Domicilios_Requeridos_MASCTable.fnGetData(rowIndex);
    var data = Otros_Domicilios_Requeridos_MASCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Otros_Domicilios_Requeridos_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Otros_Domicilios_Requeridos_MASCrowCreationGrid(data, prevData, rowIndex);
    }
	showOtros_Domicilios_Requeridos_MASCGrid(Otros_Domicilios_Requeridos_MASCTable.fnGetData());
    Otros_Domicilios_Requeridos_MASCcountRowsChecked--;
	initiateUIControls();
}

function GetOtros_Domicilios_Requeridos_MASCFromDataTable() {
    var Otros_Domicilios_Requeridos_MASCData = [];
    var gridData = Otros_Domicilios_Requeridos_MASCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Otros_Domicilios_Requeridos_MASCData.push({
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

                ,Removed: false
            });
    }

    for (i = 0; i < removedOtros_Domicilios_Requeridos_MASCData.length; i++) {
        if (removedOtros_Domicilios_Requeridos_MASCData[i] != null && removedOtros_Domicilios_Requeridos_MASCData[i].Clave > 0)
            Otros_Domicilios_Requeridos_MASCData.push({
                Clave: removedOtros_Domicilios_Requeridos_MASCData[i].Clave

                ,Estado: removedOtros_Domicilios_Requeridos_MASCData[i].Estado
                ,Municipio: removedOtros_Domicilios_Requeridos_MASCData[i].Municipio
                ,Poblacion: removedOtros_Domicilios_Requeridos_MASCData[i].Poblacion
                ,Colonia: removedOtros_Domicilios_Requeridos_MASCData[i].Colonia
                ,Codigo_Postal: removedOtros_Domicilios_Requeridos_MASCData[i].Codigo_Postal
                ,Calle: removedOtros_Domicilios_Requeridos_MASCData[i].Calle
                ,Entre_Calle: removedOtros_Domicilios_Requeridos_MASCData[i].Entre_Calle
                ,Y_Calle: removedOtros_Domicilios_Requeridos_MASCData[i].Y_Calle
                ,Numero_Exterior: removedOtros_Domicilios_Requeridos_MASCData[i].Numero_Exterior

                , Removed: true
            });
    }	

    return Otros_Domicilios_Requeridos_MASCData;
}

function Otros_Domicilios_Requeridos_MASCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Otros_Domicilios_Requeridos_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Otros_Domicilios_Requeridos_MASCcountRowsChecked++;
    var Otros_Domicilios_Requeridos_MASCRowElement = "Otros_Domicilios_Requeridos_MASC_" + rowIndex.toString();
    var prevData = Otros_Domicilios_Requeridos_MASCTable.fnGetData(rowIndexTable );
    var row = Otros_Domicilios_Requeridos_MASCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Otros_Domicilios_Requeridos_MASC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Otros_Domicilios_Requeridos_MASCGetUpdateRowControls(prevData, "Otros_Domicilios_Requeridos_MASC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Otros_Domicilios_Requeridos_MASCRowElement + "')){ Otros_Domicilios_Requeridos_MASCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Otros_Domicilios_Requeridos_MASCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Otros_Domicilios_Requeridos_MASCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Otros_Domicilios_Requeridos_MASCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setOtros_Domicilios_Requeridos_MASCValidation();
    initiateUIControls();
    $('.Otros_Domicilios_Requeridos_MASC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMROtros_Domicilios_Requeridos_MASC(nameOfTable, rowIndexFormed);
    }
}

function Otros_Domicilios_Requeridos_MASCfnOpenAddRowPopUp() {
    var currentRowIndex = Otros_Domicilios_Requeridos_MASCTable.fnGetData().length;
    Otros_Domicilios_Requeridos_MASCfnClickAddRow();
    GetAddOtros_Domicilios_Requeridos_MASCPopup(currentRowIndex, 0);
}

function Otros_Domicilios_Requeridos_MASCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Otros_Domicilios_Requeridos_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Otros_Domicilios_Requeridos_MASCRowElement = "Otros_Domicilios_Requeridos_MASC_" + rowIndex.toString();
    var prevData = Otros_Domicilios_Requeridos_MASCTable.fnGetData(rowIndexTable);
    GetAddOtros_Domicilios_Requeridos_MASCPopup(rowIndex, 1, prevData.Clave);

    $('#dvOtros_Domicilios_Requeridos_MASCEstado').html($($.parseHTML(GetGridAutoComplete(prevData.Estado.label,'AutoCompleteEstado'))).addClass('Otros_Domicilios_Requeridos_MASC_Estado'));
    $('#dvOtros_Domicilios_Requeridos_MASCMunicipio').html($($.parseHTML(GetGridAutoComplete(prevData.Municipio.label,'AutoCompleteMunicipio'))).addClass('Otros_Domicilios_Requeridos_MASC_Municipio'));
    $('#dvOtros_Domicilios_Requeridos_MASCPoblacion').html($($.parseHTML(GetGridAutoComplete(prevData.Poblacion.label,'AutoCompletePoblacion'))).addClass('Otros_Domicilios_Requeridos_MASC_Poblacion'));
    $('#dvOtros_Domicilios_Requeridos_MASCColonia').html($($.parseHTML(GetGridAutoComplete(prevData.Colonia.label,'AutoCompleteColonia'))).addClass('Otros_Domicilios_Requeridos_MASC_Colonia'));
    $('#Otros_Domicilios_Requeridos_MASCCodigo_Postal').val(prevData.Codigo_Postal);
    $('#Otros_Domicilios_Requeridos_MASCCalle').val(prevData.Calle);
    $('#Otros_Domicilios_Requeridos_MASCEntre_Calle').val(prevData.Entre_Calle);
    $('#Otros_Domicilios_Requeridos_MASCY_Calle').val(prevData.Y_Calle);
    $('#Otros_Domicilios_Requeridos_MASCNumero_Exterior').val(prevData.Numero_Exterior);

    initiateUIControls();











}

function Otros_Domicilios_Requeridos_MASCAddInsertRow() {
    if (Otros_Domicilios_Requeridos_MASCinsertRowCurrentIndex < 1)
    {
        Otros_Domicilios_Requeridos_MASCinsertRowCurrentIndex = 1;
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

    }
}

function Otros_Domicilios_Requeridos_MASCfnClickAddRow() {
    Otros_Domicilios_Requeridos_MASCcountRowsChecked++;
    Otros_Domicilios_Requeridos_MASCTable.fnAddData(Otros_Domicilios_Requeridos_MASCAddInsertRow(), true);
    Otros_Domicilios_Requeridos_MASCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Otros_Domicilios_Requeridos_MASCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Otros_Domicilios_Requeridos_MASCGrid tbody tr:nth-of-type(' + (Otros_Domicilios_Requeridos_MASCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMROtros_Domicilios_Requeridos_MASC("Otros_Domicilios_Requeridos_MASC_", "_" + Otros_Domicilios_Requeridos_MASCinsertRowCurrentIndex);
}

function Otros_Domicilios_Requeridos_MASCClearGridData() {
    Otros_Domicilios_Requeridos_MASCData = [];
    Otros_Domicilios_Requeridos_MASCdeletedItem = [];
    Otros_Domicilios_Requeridos_MASCDataMain = [];
    Otros_Domicilios_Requeridos_MASCDataMainPages = [];
    Otros_Domicilios_Requeridos_MASCnewItemCount = 0;
    Otros_Domicilios_Requeridos_MASCmaxItemIndex = 0;
    $("#Otros_Domicilios_Requeridos_MASCGrid").DataTable().clear();
    $("#Otros_Domicilios_Requeridos_MASCGrid").DataTable().destroy();
}

//Used to Get Requeridos Information
function GetOtros_Domicilios_Requeridos_MASC() {
    var form_data = new FormData();
    for (var i = 0; i < Otros_Domicilios_Requeridos_MASCData.length; i++) {
        form_data.append('[' + i + '].Clave', Otros_Domicilios_Requeridos_MASCData[i].Clave);

        form_data.append('[' + i + '].Estado', Otros_Domicilios_Requeridos_MASCData[i].Estado);
        form_data.append('[' + i + '].Municipio', Otros_Domicilios_Requeridos_MASCData[i].Municipio);
        form_data.append('[' + i + '].Poblacion', Otros_Domicilios_Requeridos_MASCData[i].Poblacion);
        form_data.append('[' + i + '].Colonia', Otros_Domicilios_Requeridos_MASCData[i].Colonia);
        form_data.append('[' + i + '].Codigo_Postal', Otros_Domicilios_Requeridos_MASCData[i].Codigo_Postal);
        form_data.append('[' + i + '].Calle', Otros_Domicilios_Requeridos_MASCData[i].Calle);
        form_data.append('[' + i + '].Entre_Calle', Otros_Domicilios_Requeridos_MASCData[i].Entre_Calle);
        form_data.append('[' + i + '].Y_Calle', Otros_Domicilios_Requeridos_MASCData[i].Y_Calle);
        form_data.append('[' + i + '].Numero_Exterior', Otros_Domicilios_Requeridos_MASCData[i].Numero_Exterior);

        form_data.append('[' + i + '].Removed', Otros_Domicilios_Requeridos_MASCData[i].Removed);
    }
    return form_data;
}
function Otros_Domicilios_Requeridos_MASCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMROtros_Domicilios_Requeridos_MASC("Otros_Domicilios_Requeridos_MASCTable", rowIndex)) {
    var prevData = Otros_Domicilios_Requeridos_MASCTable.fnGetData(rowIndex);
    var data = Otros_Domicilios_Requeridos_MASCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Estado: $('#Otros_Domicilios_Requeridos_MASCEstado').val()
        ,Municipio: $('#Otros_Domicilios_Requeridos_MASCMunicipio').val()
        ,Poblacion: $('#Otros_Domicilios_Requeridos_MASCPoblacion').val()
        ,Colonia: $('#Otros_Domicilios_Requeridos_MASCColonia').val()
        ,Codigo_Postal: $('#Otros_Domicilios_Requeridos_MASCCodigo_Postal').val()

        ,Calle: $('#Otros_Domicilios_Requeridos_MASCCalle').val()
        ,Entre_Calle: $('#Otros_Domicilios_Requeridos_MASCEntre_Calle').val()
        ,Y_Calle: $('#Otros_Domicilios_Requeridos_MASCY_Calle').val()
        ,Numero_Exterior: $('#Otros_Domicilios_Requeridos_MASCNumero_Exterior').val()

    }

    Otros_Domicilios_Requeridos_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Otros_Domicilios_Requeridos_MASCrowCreationGrid(data, newData, rowIndex);
    $('#AddOtros_Domicilios_Requeridos_MASC-form').modal({ show: false });
    $('#AddOtros_Domicilios_Requeridos_MASC-form').modal('hide');
    Otros_Domicilios_Requeridos_MASCEditRow(rowIndex);
    Otros_Domicilios_Requeridos_MASCInsertRow(rowIndex);
    //}
}
function Otros_Domicilios_Requeridos_MASCRemoveAddRow(rowIndex) {
    Otros_Domicilios_Requeridos_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Otros_Domicilios_Requeridos_MASC MultiRow
//Begin Declarations for Foreigns fields for Adicciones_Requerido_MASC MultiRow
var Adicciones_Requerido_MASCcountRowsChecked = 0;

function GetAdicciones_Requerido_MASC_AdiccionesName(Id) {
    for (var i = 0; i < Adicciones_Requerido_MASC_AdiccionesItems.length; i++) {
        if (Adicciones_Requerido_MASC_AdiccionesItems[i].Clave == Id) {
            return Adicciones_Requerido_MASC_AdiccionesItems[i].Descripcion;
        }
    }
    return "";
}

function GetAdicciones_Requerido_MASC_AdiccionesDropDown() {
    var Adicciones_Requerido_MASC_AdiccionesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Adicciones_Requerido_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Adicciones_Requerido_MASC_AdiccionesDropdown);
    if(Adicciones_Requerido_MASC_AdiccionesItems != null)
    {
       for (var i = 0; i < Adicciones_Requerido_MASC_AdiccionesItems.length; i++) {
           $('<option />', { value: Adicciones_Requerido_MASC_AdiccionesItems[i].Clave, text:    Adicciones_Requerido_MASC_AdiccionesItems[i].Descripcion }).appendTo(Adicciones_Requerido_MASC_AdiccionesDropdown);
       }
    }
    return Adicciones_Requerido_MASC_AdiccionesDropdown;
}


function GetInsertAdicciones_Requerido_MASCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetAdicciones_Requerido_MASC_AdiccionesDropDown()).addClass('Adicciones_Requerido_MASC_Descripcion Descripcion').attr('id', 'Adicciones_Requerido_MASC_Descripcion_' + index).attr('data-field', 'Descripcion').after($.parseHTML(addNew('Adicciones_Requerido_MASC', 'Adicciones', 'Descripcion', 265963)));


    initiateUIControls();
    return columnData;
}

function Adicciones_Requerido_MASCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRAdicciones_Requerido_MASC("Adicciones_Requerido_MASC_", "_" + rowIndex)) {
    var iPage = Adicciones_Requerido_MASCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Adicciones_Requerido_MASC';
    var prevData = Adicciones_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Adicciones_Requerido_MASCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Adicciones_Requerido_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Adicciones_Requerido_MASCrowCreationGrid(data, newData, rowIndex);
    Adicciones_Requerido_MASCTable.fnPageChange(iPage);
    Adicciones_Requerido_MASCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRAdicciones_Requerido_MASC("Adicciones_Requerido_MASC_", "_" + rowIndex);
  }
}

function Adicciones_Requerido_MASCCancelRow(rowIndex) {
    var prevData = Adicciones_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Adicciones_Requerido_MASCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Adicciones_Requerido_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Adicciones_Requerido_MASCrowCreationGrid(data, prevData, rowIndex);
    }
	showAdicciones_Requerido_MASCGrid(Adicciones_Requerido_MASCTable.fnGetData());
    Adicciones_Requerido_MASCcountRowsChecked--;
	initiateUIControls();
}

function GetAdicciones_Requerido_MASCFromDataTable() {
    var Adicciones_Requerido_MASCData = [];
    var gridData = Adicciones_Requerido_MASCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Adicciones_Requerido_MASCData.push({
                Clave: gridData[i].Clave

                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedAdicciones_Requerido_MASCData.length; i++) {
        if (removedAdicciones_Requerido_MASCData[i] != null && removedAdicciones_Requerido_MASCData[i].Clave > 0)
            Adicciones_Requerido_MASCData.push({
                Clave: removedAdicciones_Requerido_MASCData[i].Clave

                ,Descripcion: removedAdicciones_Requerido_MASCData[i].Descripcion

                , Removed: true
            });
    }	

    return Adicciones_Requerido_MASCData;
}

function Adicciones_Requerido_MASCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Adicciones_Requerido_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Adicciones_Requerido_MASCcountRowsChecked++;
    var Adicciones_Requerido_MASCRowElement = "Adicciones_Requerido_MASC_" + rowIndex.toString();
    var prevData = Adicciones_Requerido_MASCTable.fnGetData(rowIndexTable );
    var row = Adicciones_Requerido_MASCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Adicciones_Requerido_MASC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Adicciones_Requerido_MASCGetUpdateRowControls(prevData, "Adicciones_Requerido_MASC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Adicciones_Requerido_MASCRowElement + "')){ Adicciones_Requerido_MASCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Adicciones_Requerido_MASCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Adicciones_Requerido_MASCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Adicciones_Requerido_MASCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setAdicciones_Requerido_MASCValidation();
    initiateUIControls();
    $('.Adicciones_Requerido_MASC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRAdicciones_Requerido_MASC(nameOfTable, rowIndexFormed);
    }
}

function Adicciones_Requerido_MASCfnOpenAddRowPopUp() {
    var currentRowIndex = Adicciones_Requerido_MASCTable.fnGetData().length;
    Adicciones_Requerido_MASCfnClickAddRow();
    GetAddAdicciones_Requerido_MASCPopup(currentRowIndex, 0);
}

function Adicciones_Requerido_MASCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Adicciones_Requerido_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Adicciones_Requerido_MASCRowElement = "Adicciones_Requerido_MASC_" + rowIndex.toString();
    var prevData = Adicciones_Requerido_MASCTable.fnGetData(rowIndexTable);
    GetAddAdicciones_Requerido_MASCPopup(rowIndex, 1, prevData.Clave);

    $('#Adicciones_Requerido_MASCDescripcion').val(prevData.Descripcion);

    initiateUIControls();



}

function Adicciones_Requerido_MASCAddInsertRow() {
    if (Adicciones_Requerido_MASCinsertRowCurrentIndex < 1)
    {
        Adicciones_Requerido_MASCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Descripcion: ""

    }
}

function Adicciones_Requerido_MASCfnClickAddRow() {
    Adicciones_Requerido_MASCcountRowsChecked++;
    Adicciones_Requerido_MASCTable.fnAddData(Adicciones_Requerido_MASCAddInsertRow(), true);
    Adicciones_Requerido_MASCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Adicciones_Requerido_MASCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Adicciones_Requerido_MASCGrid tbody tr:nth-of-type(' + (Adicciones_Requerido_MASCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRAdicciones_Requerido_MASC("Adicciones_Requerido_MASC_", "_" + Adicciones_Requerido_MASCinsertRowCurrentIndex);
}

function Adicciones_Requerido_MASCClearGridData() {
    Adicciones_Requerido_MASCData = [];
    Adicciones_Requerido_MASCdeletedItem = [];
    Adicciones_Requerido_MASCDataMain = [];
    Adicciones_Requerido_MASCDataMainPages = [];
    Adicciones_Requerido_MASCnewItemCount = 0;
    Adicciones_Requerido_MASCmaxItemIndex = 0;
    $("#Adicciones_Requerido_MASCGrid").DataTable().clear();
    $("#Adicciones_Requerido_MASCGrid").DataTable().destroy();
}

//Used to Get Requeridos Information
function GetAdicciones_Requerido_MASC() {
    var form_data = new FormData();
    for (var i = 0; i < Adicciones_Requerido_MASCData.length; i++) {
        form_data.append('[' + i + '].Clave', Adicciones_Requerido_MASCData[i].Clave);

        form_data.append('[' + i + '].Descripcion', Adicciones_Requerido_MASCData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Adicciones_Requerido_MASCData[i].Removed);
    }
    return form_data;
}
function Adicciones_Requerido_MASCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRAdicciones_Requerido_MASC("Adicciones_Requerido_MASCTable", rowIndex)) {
    var prevData = Adicciones_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Adicciones_Requerido_MASCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion: $('#Adicciones_Requerido_MASCDescripcion').val()

    }

    Adicciones_Requerido_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Adicciones_Requerido_MASCrowCreationGrid(data, newData, rowIndex);
    $('#AddAdicciones_Requerido_MASC-form').modal({ show: false });
    $('#AddAdicciones_Requerido_MASC-form').modal('hide');
    Adicciones_Requerido_MASCEditRow(rowIndex);
    Adicciones_Requerido_MASCInsertRow(rowIndex);
    //}
}
function Adicciones_Requerido_MASCRemoveAddRow(rowIndex) {
    Adicciones_Requerido_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Adicciones_Requerido_MASC MultiRow
//Begin Declarations for Foreigns fields for Lugares_Frecuentes_Requerido_MASC MultiRow
var Lugares_Frecuentes_Requerido_MASCcountRowsChecked = 0;

function GetLugares_Frecuentes_Requerido_MASC_LugaresName(Id) {
    for (var i = 0; i < Lugares_Frecuentes_Requerido_MASC_LugaresItems.length; i++) {
        if (Lugares_Frecuentes_Requerido_MASC_LugaresItems[i].Clave == Id) {
            return Lugares_Frecuentes_Requerido_MASC_LugaresItems[i].Descripcion;
        }
    }
    return "";
}

function GetLugares_Frecuentes_Requerido_MASC_LugaresDropDown() {
    var Lugares_Frecuentes_Requerido_MASC_LugaresDropdown = $('<select class="form-control" />');      var labelSelect = $("#Lugares_Frecuentes_Requerido_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Lugares_Frecuentes_Requerido_MASC_LugaresDropdown);
    if(Lugares_Frecuentes_Requerido_MASC_LugaresItems != null)
    {
       for (var i = 0; i < Lugares_Frecuentes_Requerido_MASC_LugaresItems.length; i++) {
           $('<option />', { value: Lugares_Frecuentes_Requerido_MASC_LugaresItems[i].Clave, text:    Lugares_Frecuentes_Requerido_MASC_LugaresItems[i].Descripcion }).appendTo(Lugares_Frecuentes_Requerido_MASC_LugaresDropdown);
       }
    }
    return Lugares_Frecuentes_Requerido_MASC_LugaresDropdown;
}



function GetInsertLugares_Frecuentes_Requerido_MASCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetLugares_Frecuentes_Requerido_MASC_LugaresDropDown()).addClass('Lugares_Frecuentes_Requerido_MASC_Tipo_de_Lugar Tipo_de_Lugar').attr('id', 'Lugares_Frecuentes_Requerido_MASC_Tipo_de_Lugar_' + index).attr('data-field', 'Tipo_de_Lugar').after($.parseHTML(addNew('Lugares_Frecuentes_Requerido_MASC', 'Lugares', 'Tipo_de_Lugar', 265910)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Lugares_Frecuentes_Requerido_MASC_Descripcion Descripcion').attr('id', 'Lugares_Frecuentes_Requerido_MASC_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Lugares_Frecuentes_Requerido_MASCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRLugares_Frecuentes_Requerido_MASC("Lugares_Frecuentes_Requerido_MASC_", "_" + rowIndex)) {
    var iPage = Lugares_Frecuentes_Requerido_MASCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Lugares_Frecuentes_Requerido_MASC';
    var prevData = Lugares_Frecuentes_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Lugares_Frecuentes_Requerido_MASCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Lugar:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Lugares_Frecuentes_Requerido_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Lugares_Frecuentes_Requerido_MASCrowCreationGrid(data, newData, rowIndex);
    Lugares_Frecuentes_Requerido_MASCTable.fnPageChange(iPage);
    Lugares_Frecuentes_Requerido_MASCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRLugares_Frecuentes_Requerido_MASC("Lugares_Frecuentes_Requerido_MASC_", "_" + rowIndex);
  }
}

function Lugares_Frecuentes_Requerido_MASCCancelRow(rowIndex) {
    var prevData = Lugares_Frecuentes_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Lugares_Frecuentes_Requerido_MASCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Lugares_Frecuentes_Requerido_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Lugares_Frecuentes_Requerido_MASCrowCreationGrid(data, prevData, rowIndex);
    }
	showLugares_Frecuentes_Requerido_MASCGrid(Lugares_Frecuentes_Requerido_MASCTable.fnGetData());
    Lugares_Frecuentes_Requerido_MASCcountRowsChecked--;
	initiateUIControls();
}

function GetLugares_Frecuentes_Requerido_MASCFromDataTable() {
    var Lugares_Frecuentes_Requerido_MASCData = [];
    var gridData = Lugares_Frecuentes_Requerido_MASCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Lugares_Frecuentes_Requerido_MASCData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Lugar: gridData[i].Tipo_de_Lugar
                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedLugares_Frecuentes_Requerido_MASCData.length; i++) {
        if (removedLugares_Frecuentes_Requerido_MASCData[i] != null && removedLugares_Frecuentes_Requerido_MASCData[i].Clave > 0)
            Lugares_Frecuentes_Requerido_MASCData.push({
                Clave: removedLugares_Frecuentes_Requerido_MASCData[i].Clave

                ,Tipo_de_Lugar: removedLugares_Frecuentes_Requerido_MASCData[i].Tipo_de_Lugar
                ,Descripcion: removedLugares_Frecuentes_Requerido_MASCData[i].Descripcion

                , Removed: true
            });
    }	

    return Lugares_Frecuentes_Requerido_MASCData;
}

function Lugares_Frecuentes_Requerido_MASCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Lugares_Frecuentes_Requerido_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Lugares_Frecuentes_Requerido_MASCcountRowsChecked++;
    var Lugares_Frecuentes_Requerido_MASCRowElement = "Lugares_Frecuentes_Requerido_MASC_" + rowIndex.toString();
    var prevData = Lugares_Frecuentes_Requerido_MASCTable.fnGetData(rowIndexTable );
    var row = Lugares_Frecuentes_Requerido_MASCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Lugares_Frecuentes_Requerido_MASC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Lugares_Frecuentes_Requerido_MASCGetUpdateRowControls(prevData, "Lugares_Frecuentes_Requerido_MASC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Lugares_Frecuentes_Requerido_MASCRowElement + "')){ Lugares_Frecuentes_Requerido_MASCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Lugares_Frecuentes_Requerido_MASCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Lugares_Frecuentes_Requerido_MASCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Lugares_Frecuentes_Requerido_MASCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setLugares_Frecuentes_Requerido_MASCValidation();
    initiateUIControls();
    $('.Lugares_Frecuentes_Requerido_MASC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRLugares_Frecuentes_Requerido_MASC(nameOfTable, rowIndexFormed);
    }
}

function Lugares_Frecuentes_Requerido_MASCfnOpenAddRowPopUp() {
    var currentRowIndex = Lugares_Frecuentes_Requerido_MASCTable.fnGetData().length;
    Lugares_Frecuentes_Requerido_MASCfnClickAddRow();
    GetAddLugares_Frecuentes_Requerido_MASCPopup(currentRowIndex, 0);
}

function Lugares_Frecuentes_Requerido_MASCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Lugares_Frecuentes_Requerido_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Lugares_Frecuentes_Requerido_MASCRowElement = "Lugares_Frecuentes_Requerido_MASC_" + rowIndex.toString();
    var prevData = Lugares_Frecuentes_Requerido_MASCTable.fnGetData(rowIndexTable);
    GetAddLugares_Frecuentes_Requerido_MASCPopup(rowIndex, 1, prevData.Clave);

    $('#Lugares_Frecuentes_Requerido_MASCTipo_de_Lugar').val(prevData.Tipo_de_Lugar);
    $('#Lugares_Frecuentes_Requerido_MASCDescripcion').val(prevData.Descripcion);

    initiateUIControls();




}

function Lugares_Frecuentes_Requerido_MASCAddInsertRow() {
    if (Lugares_Frecuentes_Requerido_MASCinsertRowCurrentIndex < 1)
    {
        Lugares_Frecuentes_Requerido_MASCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Lugar: ""
        ,Descripcion: ""

    }
}

function Lugares_Frecuentes_Requerido_MASCfnClickAddRow() {
    Lugares_Frecuentes_Requerido_MASCcountRowsChecked++;
    Lugares_Frecuentes_Requerido_MASCTable.fnAddData(Lugares_Frecuentes_Requerido_MASCAddInsertRow(), true);
    Lugares_Frecuentes_Requerido_MASCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Lugares_Frecuentes_Requerido_MASCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Lugares_Frecuentes_Requerido_MASCGrid tbody tr:nth-of-type(' + (Lugares_Frecuentes_Requerido_MASCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRLugares_Frecuentes_Requerido_MASC("Lugares_Frecuentes_Requerido_MASC_", "_" + Lugares_Frecuentes_Requerido_MASCinsertRowCurrentIndex);
}

function Lugares_Frecuentes_Requerido_MASCClearGridData() {
    Lugares_Frecuentes_Requerido_MASCData = [];
    Lugares_Frecuentes_Requerido_MASCdeletedItem = [];
    Lugares_Frecuentes_Requerido_MASCDataMain = [];
    Lugares_Frecuentes_Requerido_MASCDataMainPages = [];
    Lugares_Frecuentes_Requerido_MASCnewItemCount = 0;
    Lugares_Frecuentes_Requerido_MASCmaxItemIndex = 0;
    $("#Lugares_Frecuentes_Requerido_MASCGrid").DataTable().clear();
    $("#Lugares_Frecuentes_Requerido_MASCGrid").DataTable().destroy();
}

//Used to Get Requeridos Information
function GetLugares_Frecuentes_Requerido_MASC() {
    var form_data = new FormData();
    for (var i = 0; i < Lugares_Frecuentes_Requerido_MASCData.length; i++) {
        form_data.append('[' + i + '].Clave', Lugares_Frecuentes_Requerido_MASCData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Lugar', Lugares_Frecuentes_Requerido_MASCData[i].Tipo_de_Lugar);
        form_data.append('[' + i + '].Descripcion', Lugares_Frecuentes_Requerido_MASCData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Lugares_Frecuentes_Requerido_MASCData[i].Removed);
    }
    return form_data;
}
function Lugares_Frecuentes_Requerido_MASCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRLugares_Frecuentes_Requerido_MASC("Lugares_Frecuentes_Requerido_MASCTable", rowIndex)) {
    var prevData = Lugares_Frecuentes_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Lugares_Frecuentes_Requerido_MASCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Lugar: $('#Lugares_Frecuentes_Requerido_MASCTipo_de_Lugar').val()
        ,Descripcion: $('#Lugares_Frecuentes_Requerido_MASCDescripcion').val()

    }

    Lugares_Frecuentes_Requerido_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Lugares_Frecuentes_Requerido_MASCrowCreationGrid(data, newData, rowIndex);
    $('#AddLugares_Frecuentes_Requerido_MASC-form').modal({ show: false });
    $('#AddLugares_Frecuentes_Requerido_MASC-form').modal('hide');
    Lugares_Frecuentes_Requerido_MASCEditRow(rowIndex);
    Lugares_Frecuentes_Requerido_MASCInsertRow(rowIndex);
    //}
}
function Lugares_Frecuentes_Requerido_MASCRemoveAddRow(rowIndex) {
    Lugares_Frecuentes_Requerido_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Lugares_Frecuentes_Requerido_MASC MultiRow
//Begin Declarations for Foreigns fields for Datos_Personales_Adicionales_Requerido_MASC MultiRow
var Datos_Personales_Adicionales_Requerido_MASCcountRowsChecked = 0;



function GetDatos_Personales_Adicionales_Requerido_MASC_Redes_SocialesName(Id) {
    for (var i = 0; i < Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesItems.length; i++) {
        if (Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesItems[i].Clave == Id) {
            return Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesItems[i].Descripcion;
        }
    }
    return "";
}

function GetDatos_Personales_Adicionales_Requerido_MASC_Redes_SocialesDropDown() {
    var Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Datos_Personales_Adicionales_Requerido_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesDropdown);
    if(Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesItems != null)
    {
       for (var i = 0; i < Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesItems.length; i++) {
           $('<option />', { value: Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesItems[i].Clave, text:    Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesItems[i].Descripcion }).appendTo(Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesDropdown);
       }
    }
    return Datos_Personales_Adicionales_Requerido_MASC_Redes_SocialesDropdown;
}



function GetInsertDatos_Personales_Adicionales_Requerido_MASCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Datos_Personales_Adicionales_Requerido_MASC_Correo_Electronico Correo_Electronico').attr('id', 'Datos_Personales_Adicionales_Requerido_MASC_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');
    columnData[1] = $($.parseHTML(inputData)).addClass('Datos_Personales_Adicionales_Requerido_MASC_Numero_Telefonico Numero_Telefonico').attr('id', 'Datos_Personales_Adicionales_Requerido_MASC_Numero_Telefonico_' + index).attr('data-field', 'Numero_Telefonico');
    columnData[2] = $(GetDatos_Personales_Adicionales_Requerido_MASC_Redes_SocialesDropDown()).addClass('Datos_Personales_Adicionales_Requerido_MASC_Redes_Sociales Redes_Sociales').attr('id', 'Datos_Personales_Adicionales_Requerido_MASC_Redes_Sociales_' + index).attr('data-field', 'Redes_Sociales').after($.parseHTML(addNew('Datos_Personales_Adicionales_Requerido_MASC', 'Redes_Sociales', 'Redes_Sociales', 265916)));
    columnData[3] = $($.parseHTML(inputData)).addClass('Datos_Personales_Adicionales_Requerido_MASC_Observaciones Observaciones').attr('id', 'Datos_Personales_Adicionales_Requerido_MASC_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Datos_Personales_Adicionales_Requerido_MASCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDatos_Personales_Adicionales_Requerido_MASC("Datos_Personales_Adicionales_Requerido_MASC_", "_" + rowIndex)) {
    var iPage = Datos_Personales_Adicionales_Requerido_MASCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Datos_Personales_Adicionales_Requerido_MASC';
    var prevData = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Telefonico:  data.childNodes[counter++].childNodes[0].value
        ,Redes_Sociales:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Datos_Personales_Adicionales_Requerido_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Datos_Personales_Adicionales_Requerido_MASCrowCreationGrid(data, newData, rowIndex);
    Datos_Personales_Adicionales_Requerido_MASCTable.fnPageChange(iPage);
    Datos_Personales_Adicionales_Requerido_MASCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDatos_Personales_Adicionales_Requerido_MASC("Datos_Personales_Adicionales_Requerido_MASC_", "_" + rowIndex);
  }
}

function Datos_Personales_Adicionales_Requerido_MASCCancelRow(rowIndex) {
    var prevData = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Datos_Personales_Adicionales_Requerido_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Datos_Personales_Adicionales_Requerido_MASCrowCreationGrid(data, prevData, rowIndex);
    }
	showDatos_Personales_Adicionales_Requerido_MASCGrid(Datos_Personales_Adicionales_Requerido_MASCTable.fnGetData());
    Datos_Personales_Adicionales_Requerido_MASCcountRowsChecked--;
	initiateUIControls();
}

function GetDatos_Personales_Adicionales_Requerido_MASCFromDataTable() {
    var Datos_Personales_Adicionales_Requerido_MASCData = [];
    var gridData = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Datos_Personales_Adicionales_Requerido_MASCData.push({
                Clave: gridData[i].Clave

                ,Correo_Electronico: gridData[i].Correo_Electronico
                ,Numero_Telefonico: gridData[i].Numero_Telefonico
                ,Redes_Sociales: gridData[i].Redes_Sociales
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDatos_Personales_Adicionales_Requerido_MASCData.length; i++) {
        if (removedDatos_Personales_Adicionales_Requerido_MASCData[i] != null && removedDatos_Personales_Adicionales_Requerido_MASCData[i].Clave > 0)
            Datos_Personales_Adicionales_Requerido_MASCData.push({
                Clave: removedDatos_Personales_Adicionales_Requerido_MASCData[i].Clave

                ,Correo_Electronico: removedDatos_Personales_Adicionales_Requerido_MASCData[i].Correo_Electronico
                ,Numero_Telefonico: removedDatos_Personales_Adicionales_Requerido_MASCData[i].Numero_Telefonico
                ,Redes_Sociales: removedDatos_Personales_Adicionales_Requerido_MASCData[i].Redes_Sociales
                ,Observaciones: removedDatos_Personales_Adicionales_Requerido_MASCData[i].Observaciones

                , Removed: true
            });
    }	

    return Datos_Personales_Adicionales_Requerido_MASCData;
}

function Datos_Personales_Adicionales_Requerido_MASCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Datos_Personales_Adicionales_Requerido_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Datos_Personales_Adicionales_Requerido_MASCcountRowsChecked++;
    var Datos_Personales_Adicionales_Requerido_MASCRowElement = "Datos_Personales_Adicionales_Requerido_MASC_" + rowIndex.toString();
    var prevData = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetData(rowIndexTable );
    var row = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Datos_Personales_Adicionales_Requerido_MASC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Datos_Personales_Adicionales_Requerido_MASCGetUpdateRowControls(prevData, "Datos_Personales_Adicionales_Requerido_MASC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Datos_Personales_Adicionales_Requerido_MASCRowElement + "')){ Datos_Personales_Adicionales_Requerido_MASCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Datos_Personales_Adicionales_Requerido_MASCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Datos_Personales_Adicionales_Requerido_MASCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Datos_Personales_Adicionales_Requerido_MASCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDatos_Personales_Adicionales_Requerido_MASCValidation();
    initiateUIControls();
    $('.Datos_Personales_Adicionales_Requerido_MASC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDatos_Personales_Adicionales_Requerido_MASC(nameOfTable, rowIndexFormed);
    }
}

function Datos_Personales_Adicionales_Requerido_MASCfnOpenAddRowPopUp() {
    var currentRowIndex = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetData().length;
    Datos_Personales_Adicionales_Requerido_MASCfnClickAddRow();
    GetAddDatos_Personales_Adicionales_Requerido_MASCPopup(currentRowIndex, 0);
}

function Datos_Personales_Adicionales_Requerido_MASCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Datos_Personales_Adicionales_Requerido_MASCRowElement = "Datos_Personales_Adicionales_Requerido_MASC_" + rowIndex.toString();
    var prevData = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetData(rowIndexTable);
    GetAddDatos_Personales_Adicionales_Requerido_MASCPopup(rowIndex, 1, prevData.Clave);

    $('#Datos_Personales_Adicionales_Requerido_MASCCorreo_Electronico').val(prevData.Correo_Electronico);
    $('#Datos_Personales_Adicionales_Requerido_MASCNumero_Telefonico').val(prevData.Numero_Telefonico);
    $('#Datos_Personales_Adicionales_Requerido_MASCRedes_Sociales').val(prevData.Redes_Sociales);
    $('#Datos_Personales_Adicionales_Requerido_MASCObservaciones').val(prevData.Observaciones);

    initiateUIControls();






}

function Datos_Personales_Adicionales_Requerido_MASCAddInsertRow() {
    if (Datos_Personales_Adicionales_Requerido_MASCinsertRowCurrentIndex < 1)
    {
        Datos_Personales_Adicionales_Requerido_MASCinsertRowCurrentIndex = 1;
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

function Datos_Personales_Adicionales_Requerido_MASCfnClickAddRow() {
    Datos_Personales_Adicionales_Requerido_MASCcountRowsChecked++;
    Datos_Personales_Adicionales_Requerido_MASCTable.fnAddData(Datos_Personales_Adicionales_Requerido_MASCAddInsertRow(), true);
    Datos_Personales_Adicionales_Requerido_MASCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Datos_Personales_Adicionales_Requerido_MASCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Datos_Personales_Adicionales_Requerido_MASCGrid tbody tr:nth-of-type(' + (Datos_Personales_Adicionales_Requerido_MASCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDatos_Personales_Adicionales_Requerido_MASC("Datos_Personales_Adicionales_Requerido_MASC_", "_" + Datos_Personales_Adicionales_Requerido_MASCinsertRowCurrentIndex);
}

function Datos_Personales_Adicionales_Requerido_MASCClearGridData() {
    Datos_Personales_Adicionales_Requerido_MASCData = [];
    Datos_Personales_Adicionales_Requerido_MASCdeletedItem = [];
    Datos_Personales_Adicionales_Requerido_MASCDataMain = [];
    Datos_Personales_Adicionales_Requerido_MASCDataMainPages = [];
    Datos_Personales_Adicionales_Requerido_MASCnewItemCount = 0;
    Datos_Personales_Adicionales_Requerido_MASCmaxItemIndex = 0;
    $("#Datos_Personales_Adicionales_Requerido_MASCGrid").DataTable().clear();
    $("#Datos_Personales_Adicionales_Requerido_MASCGrid").DataTable().destroy();
}

//Used to Get Requeridos Information
function GetDatos_Personales_Adicionales_Requerido_MASC() {
    var form_data = new FormData();
    for (var i = 0; i < Datos_Personales_Adicionales_Requerido_MASCData.length; i++) {
        form_data.append('[' + i + '].Clave', Datos_Personales_Adicionales_Requerido_MASCData[i].Clave);

        form_data.append('[' + i + '].Correo_Electronico', Datos_Personales_Adicionales_Requerido_MASCData[i].Correo_Electronico);
        form_data.append('[' + i + '].Numero_Telefonico', Datos_Personales_Adicionales_Requerido_MASCData[i].Numero_Telefonico);
        form_data.append('[' + i + '].Redes_Sociales', Datos_Personales_Adicionales_Requerido_MASCData[i].Redes_Sociales);
        form_data.append('[' + i + '].Observaciones', Datos_Personales_Adicionales_Requerido_MASCData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Datos_Personales_Adicionales_Requerido_MASCData[i].Removed);
    }
    return form_data;
}
function Datos_Personales_Adicionales_Requerido_MASCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDatos_Personales_Adicionales_Requerido_MASC("Datos_Personales_Adicionales_Requerido_MASCTable", rowIndex)) {
    var prevData = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Datos_Personales_Adicionales_Requerido_MASCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Correo_Electronico: $('#Datos_Personales_Adicionales_Requerido_MASCCorreo_Electronico').val()
        ,Numero_Telefonico: $('#Datos_Personales_Adicionales_Requerido_MASCNumero_Telefonico').val()
        ,Redes_Sociales: $('#Datos_Personales_Adicionales_Requerido_MASCRedes_Sociales').val()
        ,Observaciones: $('#Datos_Personales_Adicionales_Requerido_MASCObservaciones').val()

    }

    Datos_Personales_Adicionales_Requerido_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Datos_Personales_Adicionales_Requerido_MASCrowCreationGrid(data, newData, rowIndex);
    $('#AddDatos_Personales_Adicionales_Requerido_MASC-form').modal({ show: false });
    $('#AddDatos_Personales_Adicionales_Requerido_MASC-form').modal('hide');
    Datos_Personales_Adicionales_Requerido_MASCEditRow(rowIndex);
    Datos_Personales_Adicionales_Requerido_MASCInsertRow(rowIndex);
    //}
}
function Datos_Personales_Adicionales_Requerido_MASCRemoveAddRow(rowIndex) {
    Datos_Personales_Adicionales_Requerido_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Datos_Personales_Adicionales_Requerido_MASC MultiRow
//Begin Declarations for Foreigns fields for Otras_Identificaciones_Requerido_MASC MultiRow
var Otras_Identificaciones_Requerido_MASCcountRowsChecked = 0;

function GetOtras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionItems.length; i++) {
        if (Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetOtras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionDropDown() {
    var Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otras_Identificaciones_Requerido_MASC_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionDropdown);
    if(Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionItems[i].Clave, text:    Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionDropdown);
       }
    }
    return Otras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionDropdown;
}



function GetInsertOtras_Identificaciones_Requerido_MASCRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetOtras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionDropDown()).addClass('Otras_Identificaciones_Requerido_MASC_Tipo_de_Identificacion Tipo_de_Identificacion').attr('id', 'Otras_Identificaciones_Requerido_MASC_Tipo_de_Identificacion_' + index).attr('data-field', 'Tipo_de_Identificacion').after($.parseHTML(addNew('Otras_Identificaciones_Requerido_MASC', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion', 265920)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Otras_Identificaciones_Requerido_MASC_Descripcion Descripcion').attr('id', 'Otras_Identificaciones_Requerido_MASC_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Otras_Identificaciones_Requerido_MASCInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMROtras_Identificaciones_Requerido_MASC("Otras_Identificaciones_Requerido_MASC_", "_" + rowIndex)) {
    var iPage = Otras_Identificaciones_Requerido_MASCTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Otras_Identificaciones_Requerido_MASC';
    var prevData = Otras_Identificaciones_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Otras_Identificaciones_Requerido_MASCTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Otras_Identificaciones_Requerido_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Otras_Identificaciones_Requerido_MASCrowCreationGrid(data, newData, rowIndex);
    Otras_Identificaciones_Requerido_MASCTable.fnPageChange(iPage);
    Otras_Identificaciones_Requerido_MASCcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMROtras_Identificaciones_Requerido_MASC("Otras_Identificaciones_Requerido_MASC_", "_" + rowIndex);
  }
}

function Otras_Identificaciones_Requerido_MASCCancelRow(rowIndex) {
    var prevData = Otras_Identificaciones_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Otras_Identificaciones_Requerido_MASCTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Otras_Identificaciones_Requerido_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Otras_Identificaciones_Requerido_MASCrowCreationGrid(data, prevData, rowIndex);
    }
	showOtras_Identificaciones_Requerido_MASCGrid(Otras_Identificaciones_Requerido_MASCTable.fnGetData());
    Otras_Identificaciones_Requerido_MASCcountRowsChecked--;
	initiateUIControls();
}

function GetOtras_Identificaciones_Requerido_MASCFromDataTable() {
    var Otras_Identificaciones_Requerido_MASCData = [];
    var gridData = Otras_Identificaciones_Requerido_MASCTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Otras_Identificaciones_Requerido_MASCData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Identificacion: gridData[i].Tipo_de_Identificacion
                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedOtras_Identificaciones_Requerido_MASCData.length; i++) {
        if (removedOtras_Identificaciones_Requerido_MASCData[i] != null && removedOtras_Identificaciones_Requerido_MASCData[i].Clave > 0)
            Otras_Identificaciones_Requerido_MASCData.push({
                Clave: removedOtras_Identificaciones_Requerido_MASCData[i].Clave

                ,Tipo_de_Identificacion: removedOtras_Identificaciones_Requerido_MASCData[i].Tipo_de_Identificacion
                ,Descripcion: removedOtras_Identificaciones_Requerido_MASCData[i].Descripcion

                , Removed: true
            });
    }	

    return Otras_Identificaciones_Requerido_MASCData;
}

function Otras_Identificaciones_Requerido_MASCEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Otras_Identificaciones_Requerido_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Otras_Identificaciones_Requerido_MASCcountRowsChecked++;
    var Otras_Identificaciones_Requerido_MASCRowElement = "Otras_Identificaciones_Requerido_MASC_" + rowIndex.toString();
    var prevData = Otras_Identificaciones_Requerido_MASCTable.fnGetData(rowIndexTable );
    var row = Otras_Identificaciones_Requerido_MASCTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Otras_Identificaciones_Requerido_MASC_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Otras_Identificaciones_Requerido_MASCGetUpdateRowControls(prevData, "Otras_Identificaciones_Requerido_MASC_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Otras_Identificaciones_Requerido_MASCRowElement + "')){ Otras_Identificaciones_Requerido_MASCInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Otras_Identificaciones_Requerido_MASCCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Otras_Identificaciones_Requerido_MASCGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Otras_Identificaciones_Requerido_MASCGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setOtras_Identificaciones_Requerido_MASCValidation();
    initiateUIControls();
    $('.Otras_Identificaciones_Requerido_MASC' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMROtras_Identificaciones_Requerido_MASC(nameOfTable, rowIndexFormed);
    }
}

function Otras_Identificaciones_Requerido_MASCfnOpenAddRowPopUp() {
    var currentRowIndex = Otras_Identificaciones_Requerido_MASCTable.fnGetData().length;
    Otras_Identificaciones_Requerido_MASCfnClickAddRow();
    GetAddOtras_Identificaciones_Requerido_MASCPopup(currentRowIndex, 0);
}

function Otras_Identificaciones_Requerido_MASCEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Otras_Identificaciones_Requerido_MASCTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Otras_Identificaciones_Requerido_MASCRowElement = "Otras_Identificaciones_Requerido_MASC_" + rowIndex.toString();
    var prevData = Otras_Identificaciones_Requerido_MASCTable.fnGetData(rowIndexTable);
    GetAddOtras_Identificaciones_Requerido_MASCPopup(rowIndex, 1, prevData.Clave);

    $('#Otras_Identificaciones_Requerido_MASCTipo_de_Identificacion').val(prevData.Tipo_de_Identificacion);
    $('#Otras_Identificaciones_Requerido_MASCDescripcion').val(prevData.Descripcion);

    initiateUIControls();




}

function Otras_Identificaciones_Requerido_MASCAddInsertRow() {
    if (Otras_Identificaciones_Requerido_MASCinsertRowCurrentIndex < 1)
    {
        Otras_Identificaciones_Requerido_MASCinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Identificacion: ""
        ,Descripcion: ""

    }
}

function Otras_Identificaciones_Requerido_MASCfnClickAddRow() {
    Otras_Identificaciones_Requerido_MASCcountRowsChecked++;
    Otras_Identificaciones_Requerido_MASCTable.fnAddData(Otras_Identificaciones_Requerido_MASCAddInsertRow(), true);
    Otras_Identificaciones_Requerido_MASCTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Otras_Identificaciones_Requerido_MASCGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Otras_Identificaciones_Requerido_MASCGrid tbody tr:nth-of-type(' + (Otras_Identificaciones_Requerido_MASCinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMROtras_Identificaciones_Requerido_MASC("Otras_Identificaciones_Requerido_MASC_", "_" + Otras_Identificaciones_Requerido_MASCinsertRowCurrentIndex);
}

function Otras_Identificaciones_Requerido_MASCClearGridData() {
    Otras_Identificaciones_Requerido_MASCData = [];
    Otras_Identificaciones_Requerido_MASCdeletedItem = [];
    Otras_Identificaciones_Requerido_MASCDataMain = [];
    Otras_Identificaciones_Requerido_MASCDataMainPages = [];
    Otras_Identificaciones_Requerido_MASCnewItemCount = 0;
    Otras_Identificaciones_Requerido_MASCmaxItemIndex = 0;
    $("#Otras_Identificaciones_Requerido_MASCGrid").DataTable().clear();
    $("#Otras_Identificaciones_Requerido_MASCGrid").DataTable().destroy();
}

//Used to Get Requeridos Information
function GetOtras_Identificaciones_Requerido_MASC() {
    var form_data = new FormData();
    for (var i = 0; i < Otras_Identificaciones_Requerido_MASCData.length; i++) {
        form_data.append('[' + i + '].Clave', Otras_Identificaciones_Requerido_MASCData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Identificacion', Otras_Identificaciones_Requerido_MASCData[i].Tipo_de_Identificacion);
        form_data.append('[' + i + '].Descripcion', Otras_Identificaciones_Requerido_MASCData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Otras_Identificaciones_Requerido_MASCData[i].Removed);
    }
    return form_data;
}
function Otras_Identificaciones_Requerido_MASCInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMROtras_Identificaciones_Requerido_MASC("Otras_Identificaciones_Requerido_MASCTable", rowIndex)) {
    var prevData = Otras_Identificaciones_Requerido_MASCTable.fnGetData(rowIndex);
    var data = Otras_Identificaciones_Requerido_MASCTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Identificacion: $('#Otras_Identificaciones_Requerido_MASCTipo_de_Identificacion').val()
        ,Descripcion: $('#Otras_Identificaciones_Requerido_MASCDescripcion').val()

    }

    Otras_Identificaciones_Requerido_MASCTable.fnUpdate(newData, rowIndex, null, true);
    Otras_Identificaciones_Requerido_MASCrowCreationGrid(data, newData, rowIndex);
    $('#AddOtras_Identificaciones_Requerido_MASC-form').modal({ show: false });
    $('#AddOtras_Identificaciones_Requerido_MASC-form').modal('hide');
    Otras_Identificaciones_Requerido_MASCEditRow(rowIndex);
    Otras_Identificaciones_Requerido_MASCInsertRow(rowIndex);
    //}
}
function Otras_Identificaciones_Requerido_MASCRemoveAddRow(rowIndex) {
    Otras_Identificaciones_Requerido_MASCTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Otras_Identificaciones_Requerido_MASC MultiRow


$(function () {
    function Otros_Nombres_Requerido_MASCinitializeMainArray(totalCount) {
        if (Otros_Nombres_Requerido_MASCDataMain.length != totalCount && !Otros_Nombres_Requerido_MASCDataMainInitialized) {
            Otros_Nombres_Requerido_MASCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Otros_Nombres_Requerido_MASCDataMain[i] = null;
            }
        }
    }
    function Otros_Nombres_Requerido_MASCremoveFromMainArray() {
        for (var j = 0; j < Otros_Nombres_Requerido_MASCdeletedItem.length; j++) {
            for (var i = 0; i < Otros_Nombres_Requerido_MASCDataMain.length; i++) {
                if (Otros_Nombres_Requerido_MASCDataMain[i] != null && Otros_Nombres_Requerido_MASCDataMain[i].Id == Otros_Nombres_Requerido_MASCdeletedItem[j]) {
                    hOtros_Nombres_Requerido_MASCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Otros_Nombres_Requerido_MASCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Otros_Nombres_Requerido_MASCDataMain.length; i++) {
            data[i] = Otros_Nombres_Requerido_MASCDataMain[i];

        }
        return data;
    }
    function Otros_Nombres_Requerido_MASCgetNewResult() {
        var newData = copyMainOtros_Nombres_Requerido_MASCArray();

        for (var i = 0; i < Otros_Nombres_Requerido_MASCData.length; i++) {
            if (Otros_Nombres_Requerido_MASCData[i].Removed == null || Otros_Nombres_Requerido_MASCData[i].Removed == false) {
                newData.splice(0, 0, Otros_Nombres_Requerido_MASCData[i]);
            }
        }
        return newData;
    }
    function Otros_Nombres_Requerido_MASCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Otros_Nombres_Requerido_MASCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Otros_Nombres_Requerido_MASCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Otros_Domicilios_Requeridos_MASCinitializeMainArray(totalCount) {
        if (Otros_Domicilios_Requeridos_MASCDataMain.length != totalCount && !Otros_Domicilios_Requeridos_MASCDataMainInitialized) {
            Otros_Domicilios_Requeridos_MASCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Otros_Domicilios_Requeridos_MASCDataMain[i] = null;
            }
        }
    }
    function Otros_Domicilios_Requeridos_MASCremoveFromMainArray() {
        for (var j = 0; j < Otros_Domicilios_Requeridos_MASCdeletedItem.length; j++) {
            for (var i = 0; i < Otros_Domicilios_Requeridos_MASCDataMain.length; i++) {
                if (Otros_Domicilios_Requeridos_MASCDataMain[i] != null && Otros_Domicilios_Requeridos_MASCDataMain[i].Id == Otros_Domicilios_Requeridos_MASCdeletedItem[j]) {
                    hOtros_Domicilios_Requeridos_MASCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Otros_Domicilios_Requeridos_MASCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Otros_Domicilios_Requeridos_MASCDataMain.length; i++) {
            data[i] = Otros_Domicilios_Requeridos_MASCDataMain[i];

        }
        return data;
    }
    function Otros_Domicilios_Requeridos_MASCgetNewResult() {
        var newData = copyMainOtros_Domicilios_Requeridos_MASCArray();

        for (var i = 0; i < Otros_Domicilios_Requeridos_MASCData.length; i++) {
            if (Otros_Domicilios_Requeridos_MASCData[i].Removed == null || Otros_Domicilios_Requeridos_MASCData[i].Removed == false) {
                newData.splice(0, 0, Otros_Domicilios_Requeridos_MASCData[i]);
            }
        }
        return newData;
    }
    function Otros_Domicilios_Requeridos_MASCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Otros_Domicilios_Requeridos_MASCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Otros_Domicilios_Requeridos_MASCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Adicciones_Requerido_MASCinitializeMainArray(totalCount) {
        if (Adicciones_Requerido_MASCDataMain.length != totalCount && !Adicciones_Requerido_MASCDataMainInitialized) {
            Adicciones_Requerido_MASCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Adicciones_Requerido_MASCDataMain[i] = null;
            }
        }
    }
    function Adicciones_Requerido_MASCremoveFromMainArray() {
        for (var j = 0; j < Adicciones_Requerido_MASCdeletedItem.length; j++) {
            for (var i = 0; i < Adicciones_Requerido_MASCDataMain.length; i++) {
                if (Adicciones_Requerido_MASCDataMain[i] != null && Adicciones_Requerido_MASCDataMain[i].Id == Adicciones_Requerido_MASCdeletedItem[j]) {
                    hAdicciones_Requerido_MASCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Adicciones_Requerido_MASCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Adicciones_Requerido_MASCDataMain.length; i++) {
            data[i] = Adicciones_Requerido_MASCDataMain[i];

        }
        return data;
    }
    function Adicciones_Requerido_MASCgetNewResult() {
        var newData = copyMainAdicciones_Requerido_MASCArray();

        for (var i = 0; i < Adicciones_Requerido_MASCData.length; i++) {
            if (Adicciones_Requerido_MASCData[i].Removed == null || Adicciones_Requerido_MASCData[i].Removed == false) {
                newData.splice(0, 0, Adicciones_Requerido_MASCData[i]);
            }
        }
        return newData;
    }
    function Adicciones_Requerido_MASCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Adicciones_Requerido_MASCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Adicciones_Requerido_MASCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Lugares_Frecuentes_Requerido_MASCinitializeMainArray(totalCount) {
        if (Lugares_Frecuentes_Requerido_MASCDataMain.length != totalCount && !Lugares_Frecuentes_Requerido_MASCDataMainInitialized) {
            Lugares_Frecuentes_Requerido_MASCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Lugares_Frecuentes_Requerido_MASCDataMain[i] = null;
            }
        }
    }
    function Lugares_Frecuentes_Requerido_MASCremoveFromMainArray() {
        for (var j = 0; j < Lugares_Frecuentes_Requerido_MASCdeletedItem.length; j++) {
            for (var i = 0; i < Lugares_Frecuentes_Requerido_MASCDataMain.length; i++) {
                if (Lugares_Frecuentes_Requerido_MASCDataMain[i] != null && Lugares_Frecuentes_Requerido_MASCDataMain[i].Id == Lugares_Frecuentes_Requerido_MASCdeletedItem[j]) {
                    hLugares_Frecuentes_Requerido_MASCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Lugares_Frecuentes_Requerido_MASCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Lugares_Frecuentes_Requerido_MASCDataMain.length; i++) {
            data[i] = Lugares_Frecuentes_Requerido_MASCDataMain[i];

        }
        return data;
    }
    function Lugares_Frecuentes_Requerido_MASCgetNewResult() {
        var newData = copyMainLugares_Frecuentes_Requerido_MASCArray();

        for (var i = 0; i < Lugares_Frecuentes_Requerido_MASCData.length; i++) {
            if (Lugares_Frecuentes_Requerido_MASCData[i].Removed == null || Lugares_Frecuentes_Requerido_MASCData[i].Removed == false) {
                newData.splice(0, 0, Lugares_Frecuentes_Requerido_MASCData[i]);
            }
        }
        return newData;
    }
    function Lugares_Frecuentes_Requerido_MASCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Lugares_Frecuentes_Requerido_MASCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Lugares_Frecuentes_Requerido_MASCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Datos_Personales_Adicionales_Requerido_MASCinitializeMainArray(totalCount) {
        if (Datos_Personales_Adicionales_Requerido_MASCDataMain.length != totalCount && !Datos_Personales_Adicionales_Requerido_MASCDataMainInitialized) {
            Datos_Personales_Adicionales_Requerido_MASCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Datos_Personales_Adicionales_Requerido_MASCDataMain[i] = null;
            }
        }
    }
    function Datos_Personales_Adicionales_Requerido_MASCremoveFromMainArray() {
        for (var j = 0; j < Datos_Personales_Adicionales_Requerido_MASCdeletedItem.length; j++) {
            for (var i = 0; i < Datos_Personales_Adicionales_Requerido_MASCDataMain.length; i++) {
                if (Datos_Personales_Adicionales_Requerido_MASCDataMain[i] != null && Datos_Personales_Adicionales_Requerido_MASCDataMain[i].Id == Datos_Personales_Adicionales_Requerido_MASCdeletedItem[j]) {
                    hDatos_Personales_Adicionales_Requerido_MASCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Datos_Personales_Adicionales_Requerido_MASCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Datos_Personales_Adicionales_Requerido_MASCDataMain.length; i++) {
            data[i] = Datos_Personales_Adicionales_Requerido_MASCDataMain[i];

        }
        return data;
    }
    function Datos_Personales_Adicionales_Requerido_MASCgetNewResult() {
        var newData = copyMainDatos_Personales_Adicionales_Requerido_MASCArray();

        for (var i = 0; i < Datos_Personales_Adicionales_Requerido_MASCData.length; i++) {
            if (Datos_Personales_Adicionales_Requerido_MASCData[i].Removed == null || Datos_Personales_Adicionales_Requerido_MASCData[i].Removed == false) {
                newData.splice(0, 0, Datos_Personales_Adicionales_Requerido_MASCData[i]);
            }
        }
        return newData;
    }
    function Datos_Personales_Adicionales_Requerido_MASCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Datos_Personales_Adicionales_Requerido_MASCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Datos_Personales_Adicionales_Requerido_MASCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Otras_Identificaciones_Requerido_MASCinitializeMainArray(totalCount) {
        if (Otras_Identificaciones_Requerido_MASCDataMain.length != totalCount && !Otras_Identificaciones_Requerido_MASCDataMainInitialized) {
            Otras_Identificaciones_Requerido_MASCDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Otras_Identificaciones_Requerido_MASCDataMain[i] = null;
            }
        }
    }
    function Otras_Identificaciones_Requerido_MASCremoveFromMainArray() {
        for (var j = 0; j < Otras_Identificaciones_Requerido_MASCdeletedItem.length; j++) {
            for (var i = 0; i < Otras_Identificaciones_Requerido_MASCDataMain.length; i++) {
                if (Otras_Identificaciones_Requerido_MASCDataMain[i] != null && Otras_Identificaciones_Requerido_MASCDataMain[i].Id == Otras_Identificaciones_Requerido_MASCdeletedItem[j]) {
                    hOtras_Identificaciones_Requerido_MASCDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Otras_Identificaciones_Requerido_MASCcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Otras_Identificaciones_Requerido_MASCDataMain.length; i++) {
            data[i] = Otras_Identificaciones_Requerido_MASCDataMain[i];

        }
        return data;
    }
    function Otras_Identificaciones_Requerido_MASCgetNewResult() {
        var newData = copyMainOtras_Identificaciones_Requerido_MASCArray();

        for (var i = 0; i < Otras_Identificaciones_Requerido_MASCData.length; i++) {
            if (Otras_Identificaciones_Requerido_MASCData[i].Removed == null || Otras_Identificaciones_Requerido_MASCData[i].Removed == false) {
                newData.splice(0, 0, Otras_Identificaciones_Requerido_MASCData[i]);
            }
        }
        return newData;
    }
    function Otras_Identificaciones_Requerido_MASCpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Otras_Identificaciones_Requerido_MASCDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Otras_Identificaciones_Requerido_MASCDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete

var AutoCompleteNacionalidadData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Nacionalidad_NacionalidadData(data) {
	AutoCompleteNacionalidadData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNacionalidadData.push({
            id: data[i].Clave,
            text: data[i].NacionalidadC
        });
    }
    return AutoCompleteNacionalidadData;
}
var AutoCompletePaisData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Pais_PaisData(data) {
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
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Estado_EstadoData(data) {
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
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Municipio_MunicipioData(data) {
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
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Poblacion_ColoniaData(data) {
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
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Colonia_ColoniaData(data) {
	AutoCompleteColoniaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaData;
}
//Grid GetAutocomplete
var AutoCompleteEstadoData = [];
function GetAutoCompleteOtros_Domicilios_Requeridos_MASC_Estado_EstadoData(data) {
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
function GetAutoCompleteOtros_Domicilios_Requeridos_MASC_Municipio_MunicipioData(data) {
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
function GetAutoCompleteOtros_Domicilios_Requeridos_MASC_Poblacion_ColoniaData(data) {
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
function GetAutoCompleteOtros_Domicilios_Requeridos_MASC_Colonia_ColoniaData(data) {
	AutoCompleteColoniaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaData;
}

var AutoCompletePais_de_OrigenData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Pais_de_Origen_PaisData(data) {
	AutoCompletePais_de_OrigenData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_de_OrigenData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_de_OrigenData;
}
var AutoCompleteEstado_de_NacimientoData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Estado_de_Nacimiento_EstadoData(data) {
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
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Municipio_de_Nacimiento_MunicipioData(data) {
	AutoCompleteMunicipio_de_NacimientoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_de_NacimientoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_de_NacimientoData;
}
var AutoCompleteMunicipio_de_DetencionData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Municipio_de_Detencion_MunicipioData(data) {
	AutoCompleteMunicipio_de_DetencionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_de_DetencionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_de_DetencionData;
}
//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

var AutoCompletePais_tutorData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Pais_tutor_PaisData(data) {
	AutoCompletePais_tutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_tutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_tutorData;
}
var AutoCompleteEstado_tutorData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Estado_tutor_EstadoData(data) {
	AutoCompleteEstado_tutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_tutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_tutorData;
}
var AutoCompleteMunicipio_tutorData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Municipio_tutor_MunicipioData(data) {
	AutoCompleteMunicipio_tutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_tutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_tutorData;
}
var AutoCompletePoblacion_tutorData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Poblacion_tutor_ColoniaData(data) {
	AutoCompletePoblacion_tutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePoblacion_tutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePoblacion_tutorData;
}
var AutoCompleteColonia_tutorData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Colonia_tutor_ColoniaData(data) {
	AutoCompleteColonia_tutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_tutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_tutorData;
}
var AutoCompletePais_de_Origen_TutorData = [];
function GetAutoCompleteDetalle_de_Solicitud_Requerido_Pais_de_Origen_Tutor_PaisData(data) {
	AutoCompletePais_de_Origen_TutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_de_Origen_TutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_de_Origen_TutorData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Solicitud_Requerido_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Solicitud_Requerido')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Otros_Nombres_Requerido_MASCClearGridData();
    $('#Nacionalidad').empty();
    $("#Nacionalidad").append('<option value=""></option>');
    $('#Nacionalidad').val('0').trigger('change');
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
                Otros_Domicilios_Requeridos_MASCClearGridData();
    $('#Pais_de_Origen').empty();
    $("#Pais_de_Origen").append('<option value=""></option>');
    $('#Pais_de_Origen').val('0').trigger('change');
    $('#Estado_de_Nacimiento').empty();
    $("#Estado_de_Nacimiento").append('<option value=""></option>');
    $('#Estado_de_Nacimiento').val('0').trigger('change');
    $('#Municipio_de_Nacimiento').empty();
    $("#Municipio_de_Nacimiento").append('<option value=""></option>');
    $('#Municipio_de_Nacimiento').val('0').trigger('change');
    $('#Municipio_de_Detencion').empty();
    $("#Municipio_de_Detencion").append('<option value=""></option>');
    $('#Municipio_de_Detencion').val('0').trigger('change');
                Adicciones_Requerido_MASCClearGridData();
                Lugares_Frecuentes_Requerido_MASCClearGridData();
                Datos_Personales_Adicionales_Requerido_MASCClearGridData();
                Otras_Identificaciones_Requerido_MASCClearGridData();
    $('#Pais_tutor').empty();
    $("#Pais_tutor").append('<option value=""></option>');
    $('#Pais_tutor').val('0').trigger('change');
    $('#Estado_tutor').empty();
    $("#Estado_tutor").append('<option value=""></option>');
    $('#Estado_tutor').val('0').trigger('change');
    $('#Municipio_tutor').empty();
    $("#Municipio_tutor").append('<option value=""></option>');
    $('#Municipio_tutor').val('0').trigger('change');
    $('#Poblacion_tutor').empty();
    $("#Poblacion_tutor").append('<option value=""></option>');
    $('#Poblacion_tutor').val('0').trigger('change');
    $('#Colonia_tutor').empty();
    $("#Colonia_tutor").append('<option value=""></option>');
    $('#Colonia_tutor').val('0').trigger('change');
    $('#Pais_de_Origen_Tutor').empty();
    $("#Pais_de_Origen_Tutor").append('<option value=""></option>');
    $('#Pais_de_Origen_Tutor').val('0').trigger('change');

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Solicitud_Requerido').trigger('reset');
    $('#CreateDetalle_de_Solicitud_Requerido').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Solicitud_Requerido');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Otros_Nombres_Requerido_MASCcountRowsChecked > 0)
    {
        ShowMessagePendingRowOtros_Nombres_Requerido_MASC();
        return false;
    }
    if (Otros_Domicilios_Requeridos_MASCcountRowsChecked > 0)
    {
        ShowMessagePendingRowOtros_Domicilios_Requeridos_MASC();
        return false;
    }
    if (Adicciones_Requerido_MASCcountRowsChecked > 0)
    {
        ShowMessagePendingRowAdicciones_Requerido_MASC();
        return false;
    }
    if (Lugares_Frecuentes_Requerido_MASCcountRowsChecked > 0)
    {
        ShowMessagePendingRowLugares_Frecuentes_Requerido_MASC();
        return false;
    }
    if (Datos_Personales_Adicionales_Requerido_MASCcountRowsChecked > 0)
    {
        ShowMessagePendingRowDatos_Personales_Adicionales_Requerido_MASC();
        return false;
    }
    if (Otras_Identificaciones_Requerido_MASCcountRowsChecked > 0)
    {
        ShowMessagePendingRowOtras_Identificaciones_Requerido_MASC();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Solicitud_Requerido").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Solicitud_Requerido").on('click', '#Detalle_de_Solicitud_RequeridoCancelar', function () {
	  if (!isPartial) {
        Detalle_de_Solicitud_RequeridoBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Solicitud_Requerido").on('click', '#Detalle_de_Solicitud_RequeridoGuardar', function () {
		$('#Detalle_de_Solicitud_RequeridoGuardar').attr('disabled', true);
		$('#Detalle_de_Solicitud_RequeridoGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_Solicitud_RequeridoData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_Solicitud_RequeridoBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_Solicitud_RequeridoGuardar').removeAttr('disabled');
                        $('#Detalle_de_Solicitud_RequeridoGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Solicitud_Requerido', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitud_RequeridoItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitud_RequeridoDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Detalle_de_Solicitud_RequeridoGuardar').removeAttr('disabled');
					$('#Detalle_de_Solicitud_RequeridoGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_Solicitud_RequeridoGuardar').removeAttr('disabled');
			$('#Detalle_de_Solicitud_RequeridoGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Solicitud_Requerido").on('click', '#Detalle_de_Solicitud_RequeridoGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_Solicitud_RequeridoData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getOtros_Nombres_Requerido_MASCData();
                getOtros_Domicilios_Requeridos_MASCData();
                getAdicciones_Requerido_MASCData();
                getLugares_Frecuentes_Requerido_MASCData();
                getDatos_Personales_Adicionales_Requerido_MASCData();
                getOtras_Identificaciones_Requerido_MASCData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Solicitud_Requerido', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitud_RequeridoItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitud_RequeridoDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Solicitud_Requerido").on('click', '#Detalle_de_Solicitud_RequeridoGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_Solicitud_RequeridoData(function (currentId) {
					$("#ClaveId").val("0");
	                Otros_Nombres_Requerido_MASCClearGridData();
    $('#Nacionalidad').empty();
    $("#Nacionalidad").append('<option value=""></option>');
    $('#Nacionalidad').val('0').trigger('change');
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
                Otros_Domicilios_Requeridos_MASCClearGridData();
    $('#Pais_de_Origen').empty();
    $("#Pais_de_Origen").append('<option value=""></option>');
    $('#Pais_de_Origen').val('0').trigger('change');
    $('#Estado_de_Nacimiento').empty();
    $("#Estado_de_Nacimiento").append('<option value=""></option>');
    $('#Estado_de_Nacimiento').val('0').trigger('change');
    $('#Municipio_de_Nacimiento').empty();
    $("#Municipio_de_Nacimiento").append('<option value=""></option>');
    $('#Municipio_de_Nacimiento').val('0').trigger('change');
    $('#Municipio_de_Detencion').empty();
    $("#Municipio_de_Detencion").append('<option value=""></option>');
    $('#Municipio_de_Detencion').val('0').trigger('change');
                Adicciones_Requerido_MASCClearGridData();
                Lugares_Frecuentes_Requerido_MASCClearGridData();
                Datos_Personales_Adicionales_Requerido_MASCClearGridData();
                Otras_Identificaciones_Requerido_MASCClearGridData();
    $('#Pais_tutor').empty();
    $("#Pais_tutor").append('<option value=""></option>');
    $('#Pais_tutor').val('0').trigger('change');
    $('#Estado_tutor').empty();
    $("#Estado_tutor").append('<option value=""></option>');
    $('#Estado_tutor').val('0').trigger('change');
    $('#Municipio_tutor').empty();
    $("#Municipio_tutor").append('<option value=""></option>');
    $('#Municipio_tutor').val('0').trigger('change');
    $('#Poblacion_tutor').empty();
    $("#Poblacion_tutor").append('<option value=""></option>');
    $('#Poblacion_tutor').val('0').trigger('change');
    $('#Colonia_tutor').empty();
    $("#Colonia_tutor").append('<option value=""></option>');
    $('#Colonia_tutor').val('0').trigger('change');
    $('#Pais_de_Origen_Tutor').empty();
    $("#Pais_de_Origen_Tutor").append('<option value=""></option>');
    $('#Pais_de_Origen_Tutor').val('0').trigger('change');

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getOtros_Nombres_Requerido_MASCData();
                getOtros_Domicilios_Requeridos_MASCData();
                getAdicciones_Requerido_MASCData();
                getLugares_Frecuentes_Requerido_MASCData();
                getDatos_Personales_Adicionales_Requerido_MASCData();
                getOtras_Identificaciones_Requerido_MASCData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Solicitud_Requerido',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitud_RequeridoItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Solicitud_RequeridoDropDown().get(0)').innerHTML);                          
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



var Detalle_de_Solicitud_RequeridoisdisplayBusinessPropery = false;
Detalle_de_Solicitud_RequeridoDisplayBusinessRuleButtons(Detalle_de_Solicitud_RequeridoisdisplayBusinessPropery);
function Detalle_de_Solicitud_RequeridoDisplayBusinessRule() {
    if (!Detalle_de_Solicitud_RequeridoisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Solicitud_Requerido').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_Solicitud_RequeridodisplayBusinessPropery"><button onclick="Detalle_de_Solicitud_RequeridoGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_Solicitud_RequeridoBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_Solicitud_RequeridodisplayBusinessPropery').remove();
    }
    Detalle_de_Solicitud_RequeridoDisplayBusinessRuleButtons(!Detalle_de_Solicitud_RequeridoisdisplayBusinessPropery);
    Detalle_de_Solicitud_RequeridoisdisplayBusinessPropery = (Detalle_de_Solicitud_RequeridoisdisplayBusinessPropery ? false : true);
}
function Detalle_de_Solicitud_RequeridoDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

