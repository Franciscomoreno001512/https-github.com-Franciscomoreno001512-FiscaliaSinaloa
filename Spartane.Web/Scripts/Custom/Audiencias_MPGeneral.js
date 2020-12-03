

//Begin Declarations for Foreigns fields for Detalle_Audiencia_Defensor_Imputado MultiRow
var Detalle_Audiencia_Defensor_ImputadocountRowsChecked = 0;

function GetDetalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoName(Id) {
    for (var i = 0; i < Detalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoItems.length; i++) {
        if (Detalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoItems[i].Clave == Id) {
            return Detalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoItems[i].Nombre_Completo_del_Tutor;
        }
    }
    return "";
}

function GetDetalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoDropDown() {
    var Detalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Audiencia_Defensor_Imputado_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoDropdown);

    for (var i = 0; i < Detalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoItems.length; i++) {
        $('<option />', { value: Detalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoItems[i].Clave, text: Detalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoItems[i].Nombre_Completo_del_Tutor }).appendTo(Detalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoDropdown);
    }
    return Detalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoDropdown;
}




function GetInsertDetalle_Audiencia_Defensor_ImputadoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Audiencia_Defensor_Imputado_Nombre_Del_Imputado'))).addClass('Detalle_Audiencia_Defensor_Imputado_Nombre_Del_Imputado Nombre_Del_Imputado').attr('id', 'Detalle_Audiencia_Defensor_Imputado_Nombre_Del_Imputado_' + index).attr('data-field', 'Nombre_Del_Imputado').after($.parseHTML(addNew('Detalle_Audiencia_Defensor_Imputado', 'Detalle_de_Imputado', 'Nombre_Del_Imputado', 267405)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_Audiencia_Defensor_Imputado_Abogado Abogado').attr('id', 'Detalle_Audiencia_Defensor_Imputado_Abogado_' + index).attr('data-field', 'Abogado');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_Audiencia_Defensor_Imputado_Cedula_Profesional Cedula_Profesional').attr('id', 'Detalle_Audiencia_Defensor_Imputado_Cedula_Profesional_' + index).attr('data-field', 'Cedula_Profesional');


    initiateUIControls();
    return columnData;
}

function Detalle_Audiencia_Defensor_ImputadoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Defensor_Imputado("Detalle_Audiencia_Defensor_Imputado_", "_" + rowIndex)) {
    var iPage = Detalle_Audiencia_Defensor_ImputadoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Audiencia_Defensor_Imputado';
    var prevData = Detalle_Audiencia_Defensor_ImputadoTable.fnGetData(rowIndex);
    var data = Detalle_Audiencia_Defensor_ImputadoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , Nombre_Del_ImputadoNombre_Completo_del_Tutor:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Nombre_Del_Imputado:  data.childNodes[counter++].childNodes[0].value 	
        ,Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Cedula_Profesional:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Audiencia_Defensor_ImputadoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Audiencia_Defensor_ImputadorowCreationGrid(data, newData, rowIndex);
    Detalle_Audiencia_Defensor_ImputadoTable.fnPageChange(iPage);
    Detalle_Audiencia_Defensor_ImputadocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Audiencia_Defensor_Imputado("Detalle_Audiencia_Defensor_Imputado_", "_" + rowIndex);
  }
}

function Detalle_Audiencia_Defensor_ImputadoCancelRow(rowIndex) {
    var prevData = Detalle_Audiencia_Defensor_ImputadoTable.fnGetData(rowIndex);
    var data = Detalle_Audiencia_Defensor_ImputadoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Audiencia_Defensor_ImputadoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Audiencia_Defensor_ImputadorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Audiencia_Defensor_ImputadoGrid(Detalle_Audiencia_Defensor_ImputadoTable.fnGetData());
    Detalle_Audiencia_Defensor_ImputadocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Audiencia_Defensor_ImputadoFromDataTable() {
    var Detalle_Audiencia_Defensor_ImputadoData = [];
    var gridData = Detalle_Audiencia_Defensor_ImputadoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Audiencia_Defensor_ImputadoData.push({
                Clave: gridData[i].Clave

                ,Nombre_Del_Imputado: gridData[i].Nombre_Del_Imputado
                ,Abogado: gridData[i].Abogado
                ,Cedula_Profesional: gridData[i].Cedula_Profesional

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Audiencia_Defensor_ImputadoData.length; i++) {
        if (removedDetalle_Audiencia_Defensor_ImputadoData[i] != null && removedDetalle_Audiencia_Defensor_ImputadoData[i].Clave > 0)
            Detalle_Audiencia_Defensor_ImputadoData.push({
                Clave: removedDetalle_Audiencia_Defensor_ImputadoData[i].Clave

                ,Nombre_Del_Imputado: removedDetalle_Audiencia_Defensor_ImputadoData[i].Nombre_Del_Imputado
                ,Abogado: removedDetalle_Audiencia_Defensor_ImputadoData[i].Abogado
                ,Cedula_Profesional: removedDetalle_Audiencia_Defensor_ImputadoData[i].Cedula_Profesional

                , Removed: true
            });
    }	

    return Detalle_Audiencia_Defensor_ImputadoData;
}

function Detalle_Audiencia_Defensor_ImputadoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Audiencia_Defensor_ImputadoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Audiencia_Defensor_ImputadocountRowsChecked++;
    var Detalle_Audiencia_Defensor_ImputadoRowElement = "Detalle_Audiencia_Defensor_Imputado_" + rowIndex.toString();
    var prevData = Detalle_Audiencia_Defensor_ImputadoTable.fnGetData(rowIndexTable );
    var row = Detalle_Audiencia_Defensor_ImputadoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Audiencia_Defensor_Imputado_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Audiencia_Defensor_ImputadoGetUpdateRowControls(prevData, "Detalle_Audiencia_Defensor_Imputado_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Audiencia_Defensor_ImputadoRowElement + "')){ Detalle_Audiencia_Defensor_ImputadoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Audiencia_Defensor_ImputadoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Audiencia_Defensor_ImputadoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Audiencia_Defensor_ImputadoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Audiencia_Defensor_ImputadoValidation();
    initiateUIControls();
    $('.Detalle_Audiencia_Defensor_Imputado' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Audiencia_Defensor_ImputadofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Audiencia_Defensor_ImputadoTable.fnGetData().length;
    Detalle_Audiencia_Defensor_ImputadofnClickAddRow();
    GetAddDetalle_Audiencia_Defensor_ImputadoPopup(currentRowIndex, 0);
}

function Detalle_Audiencia_Defensor_ImputadoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Audiencia_Defensor_ImputadoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Audiencia_Defensor_ImputadoRowElement = "Detalle_Audiencia_Defensor_Imputado_" + rowIndex.toString();
    var prevData = Detalle_Audiencia_Defensor_ImputadoTable.fnGetData(rowIndexTable);
    GetAddDetalle_Audiencia_Defensor_ImputadoPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_Audiencia_Defensor_ImputadoNombre_Del_Imputado').html($($.parseHTML(GetGridAutoComplete(prevData.Nombre_Del_Imputado.label,'AutoCompleteNombre_Del_Imputado'))).addClass('Detalle_Audiencia_Defensor_Imputado_Nombre_Del_Imputado'));
    $('#Detalle_Audiencia_Defensor_ImputadoAbogado').val(prevData.Abogado);
    $('#Detalle_Audiencia_Defensor_ImputadoCedula_Profesional').val(prevData.Cedula_Profesional);

    initiateUIControls();





}

function Detalle_Audiencia_Defensor_ImputadoAddInsertRow() {
    if (Detalle_Audiencia_Defensor_ImputadoinsertRowCurrentIndex < 1)
    {
        Detalle_Audiencia_Defensor_ImputadoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre_Del_Imputado: ""
        ,Abogado: ""
        ,Cedula_Profesional: ""

    }
}

function Detalle_Audiencia_Defensor_ImputadofnClickAddRow() {
    Detalle_Audiencia_Defensor_ImputadocountRowsChecked++;
    Detalle_Audiencia_Defensor_ImputadoTable.fnAddData(Detalle_Audiencia_Defensor_ImputadoAddInsertRow(), true);
    Detalle_Audiencia_Defensor_ImputadoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Audiencia_Defensor_ImputadoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Audiencia_Defensor_ImputadoGrid tbody tr:nth-of-type(' + (Detalle_Audiencia_Defensor_ImputadoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Audiencia_Defensor_Imputado("Detalle_Audiencia_Defensor_Imputado_", "_" + Detalle_Audiencia_Defensor_ImputadoinsertRowCurrentIndex);
}

function Detalle_Audiencia_Defensor_ImputadoClearGridData() {
    Detalle_Audiencia_Defensor_ImputadoData = [];
    Detalle_Audiencia_Defensor_ImputadodeletedItem = [];
    Detalle_Audiencia_Defensor_ImputadoDataMain = [];
    Detalle_Audiencia_Defensor_ImputadoDataMainPages = [];
    Detalle_Audiencia_Defensor_ImputadonewItemCount = 0;
    Detalle_Audiencia_Defensor_ImputadomaxItemIndex = 0;
    $("#Detalle_Audiencia_Defensor_ImputadoGrid").DataTable().clear();
    $("#Detalle_Audiencia_Defensor_ImputadoGrid").DataTable().destroy();
}

//Used to Get Audiencias MP Information
function GetDetalle_Audiencia_Defensor_Imputado() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Audiencia_Defensor_ImputadoData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Audiencia_Defensor_ImputadoData[i].Clave);

        form_data.append('[' + i + '].Nombre_Del_Imputado', Detalle_Audiencia_Defensor_ImputadoData[i].Nombre_Del_Imputado);
        form_data.append('[' + i + '].Abogado', Detalle_Audiencia_Defensor_ImputadoData[i].Abogado);
        form_data.append('[' + i + '].Cedula_Profesional', Detalle_Audiencia_Defensor_ImputadoData[i].Cedula_Profesional);

        form_data.append('[' + i + '].Removed', Detalle_Audiencia_Defensor_ImputadoData[i].Removed);
    }
    return form_data;
}
function Detalle_Audiencia_Defensor_ImputadoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Defensor_Imputado("Detalle_Audiencia_Defensor_ImputadoTable", rowIndex)) {
    var prevData = Detalle_Audiencia_Defensor_ImputadoTable.fnGetData(rowIndex);
    var data = Detalle_Audiencia_Defensor_ImputadoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre_Del_Imputado: $('#Detalle_Audiencia_Defensor_ImputadoNombre_Del_Imputado').val()
        ,Abogado: $('#Detalle_Audiencia_Defensor_ImputadoAbogado').val()
        ,Cedula_Profesional: $('#Detalle_Audiencia_Defensor_ImputadoCedula_Profesional').val()

    }

    Detalle_Audiencia_Defensor_ImputadoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Audiencia_Defensor_ImputadorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Audiencia_Defensor_Imputado-form').modal({ show: false });
    $('#AddDetalle_Audiencia_Defensor_Imputado-form').modal('hide');
    Detalle_Audiencia_Defensor_ImputadoEditRow(rowIndex);
    Detalle_Audiencia_Defensor_ImputadoInsertRow(rowIndex);
    //}
}
function Detalle_Audiencia_Defensor_ImputadoRemoveAddRow(rowIndex) {
    Detalle_Audiencia_Defensor_ImputadoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Audiencia_Defensor_Imputado MultiRow
//Begin Declarations for Foreigns fields for Detalle_Audiencia_Defensor_Victima MultiRow
var Detalle_Audiencia_Defensor_VictimacountRowsChecked = 0;

function GetDetalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesName(Id) {
    for (var i = 0; i < Detalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesItems.length; i++) {
        if (Detalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesItems[i].Clave == Id) {
            return Detalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesItems[i].Nombre_Completo;
        }
    }
    return "";
}

function GetDetalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesDropDown() {
    var Detalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Audiencia_Defensor_Victima_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesDropdown);

    for (var i = 0; i < Detalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesItems.length; i++) {
        $('<option />', { value: Detalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesItems[i].Clave, text: Detalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesItems[i].Nombre_Completo }).appendTo(Detalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesDropdown);
    }
    return Detalle_Audiencia_Defensor_Victima_Detalle_de_Datos_GeneralesDropdown;
}




function GetInsertDetalle_Audiencia_Defensor_VictimaRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Audiencia_Defensor_Victima_Nombre_del_Imputado'))).addClass('Detalle_Audiencia_Defensor_Victima_Nombre_del_Imputado Nombre_del_Imputado').attr('id', 'Detalle_Audiencia_Defensor_Victima_Nombre_del_Imputado_' + index).attr('data-field', 'Nombre_del_Imputado').after($.parseHTML(addNew('Detalle_Audiencia_Defensor_Victima', 'Detalle_de_Datos_Generales', 'Nombre_del_Imputado', 267410)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_Audiencia_Defensor_Victima_Abogado Abogado').attr('id', 'Detalle_Audiencia_Defensor_Victima_Abogado_' + index).attr('data-field', 'Abogado');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_Audiencia_Defensor_Victima_Cedula_Profesional Cedula_Profesional').attr('id', 'Detalle_Audiencia_Defensor_Victima_Cedula_Profesional_' + index).attr('data-field', 'Cedula_Profesional');


    initiateUIControls();
    return columnData;
}

function Detalle_Audiencia_Defensor_VictimaInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Defensor_Victima("Detalle_Audiencia_Defensor_Victima_", "_" + rowIndex)) {
    var iPage = Detalle_Audiencia_Defensor_VictimaTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Audiencia_Defensor_Victima';
    var prevData = Detalle_Audiencia_Defensor_VictimaTable.fnGetData(rowIndex);
    var data = Detalle_Audiencia_Defensor_VictimaTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , Nombre_del_ImputadoNombre_Completo:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Nombre_del_Imputado:  data.childNodes[counter++].childNodes[0].value 	
        ,Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Cedula_Profesional:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Audiencia_Defensor_VictimaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Audiencia_Defensor_VictimarowCreationGrid(data, newData, rowIndex);
    Detalle_Audiencia_Defensor_VictimaTable.fnPageChange(iPage);
    Detalle_Audiencia_Defensor_VictimacountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Audiencia_Defensor_Victima("Detalle_Audiencia_Defensor_Victima_", "_" + rowIndex);
  }
}

function Detalle_Audiencia_Defensor_VictimaCancelRow(rowIndex) {
    var prevData = Detalle_Audiencia_Defensor_VictimaTable.fnGetData(rowIndex);
    var data = Detalle_Audiencia_Defensor_VictimaTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Audiencia_Defensor_VictimaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Audiencia_Defensor_VictimarowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Audiencia_Defensor_VictimaGrid(Detalle_Audiencia_Defensor_VictimaTable.fnGetData());
    Detalle_Audiencia_Defensor_VictimacountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Audiencia_Defensor_VictimaFromDataTable() {
    var Detalle_Audiencia_Defensor_VictimaData = [];
    var gridData = Detalle_Audiencia_Defensor_VictimaTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Audiencia_Defensor_VictimaData.push({
                Clave: gridData[i].Clave

                ,Nombre_del_Imputado: gridData[i].Nombre_del_Imputado
                ,Abogado: gridData[i].Abogado
                ,Cedula_Profesional: gridData[i].Cedula_Profesional

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Audiencia_Defensor_VictimaData.length; i++) {
        if (removedDetalle_Audiencia_Defensor_VictimaData[i] != null && removedDetalle_Audiencia_Defensor_VictimaData[i].Clave > 0)
            Detalle_Audiencia_Defensor_VictimaData.push({
                Clave: removedDetalle_Audiencia_Defensor_VictimaData[i].Clave

                ,Nombre_del_Imputado: removedDetalle_Audiencia_Defensor_VictimaData[i].Nombre_del_Imputado
                ,Abogado: removedDetalle_Audiencia_Defensor_VictimaData[i].Abogado
                ,Cedula_Profesional: removedDetalle_Audiencia_Defensor_VictimaData[i].Cedula_Profesional

                , Removed: true
            });
    }	

    return Detalle_Audiencia_Defensor_VictimaData;
}

function Detalle_Audiencia_Defensor_VictimaEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Audiencia_Defensor_VictimaTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Audiencia_Defensor_VictimacountRowsChecked++;
    var Detalle_Audiencia_Defensor_VictimaRowElement = "Detalle_Audiencia_Defensor_Victima_" + rowIndex.toString();
    var prevData = Detalle_Audiencia_Defensor_VictimaTable.fnGetData(rowIndexTable );
    var row = Detalle_Audiencia_Defensor_VictimaTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Audiencia_Defensor_Victima_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Audiencia_Defensor_VictimaGetUpdateRowControls(prevData, "Detalle_Audiencia_Defensor_Victima_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Audiencia_Defensor_VictimaRowElement + "')){ Detalle_Audiencia_Defensor_VictimaInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Audiencia_Defensor_VictimaCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Audiencia_Defensor_VictimaGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Audiencia_Defensor_VictimaGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Audiencia_Defensor_VictimaValidation();
    initiateUIControls();
    $('.Detalle_Audiencia_Defensor_Victima' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Audiencia_Defensor_VictimafnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Audiencia_Defensor_VictimaTable.fnGetData().length;
    Detalle_Audiencia_Defensor_VictimafnClickAddRow();
    GetAddDetalle_Audiencia_Defensor_VictimaPopup(currentRowIndex, 0);
}

function Detalle_Audiencia_Defensor_VictimaEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Audiencia_Defensor_VictimaTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Audiencia_Defensor_VictimaRowElement = "Detalle_Audiencia_Defensor_Victima_" + rowIndex.toString();
    var prevData = Detalle_Audiencia_Defensor_VictimaTable.fnGetData(rowIndexTable);
    GetAddDetalle_Audiencia_Defensor_VictimaPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_Audiencia_Defensor_VictimaNombre_del_Imputado').html($($.parseHTML(GetGridAutoComplete(prevData.Nombre_del_Imputado.label,'AutoCompleteNombre_del_Imputado'))).addClass('Detalle_Audiencia_Defensor_Victima_Nombre_del_Imputado'));
    $('#Detalle_Audiencia_Defensor_VictimaAbogado').val(prevData.Abogado);
    $('#Detalle_Audiencia_Defensor_VictimaCedula_Profesional').val(prevData.Cedula_Profesional);

    initiateUIControls();





}

function Detalle_Audiencia_Defensor_VictimaAddInsertRow() {
    if (Detalle_Audiencia_Defensor_VictimainsertRowCurrentIndex < 1)
    {
        Detalle_Audiencia_Defensor_VictimainsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre_del_Imputado: ""
        ,Abogado: ""
        ,Cedula_Profesional: ""

    }
}

function Detalle_Audiencia_Defensor_VictimafnClickAddRow() {
    Detalle_Audiencia_Defensor_VictimacountRowsChecked++;
    Detalle_Audiencia_Defensor_VictimaTable.fnAddData(Detalle_Audiencia_Defensor_VictimaAddInsertRow(), true);
    Detalle_Audiencia_Defensor_VictimaTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Audiencia_Defensor_VictimaGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Audiencia_Defensor_VictimaGrid tbody tr:nth-of-type(' + (Detalle_Audiencia_Defensor_VictimainsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Audiencia_Defensor_Victima("Detalle_Audiencia_Defensor_Victima_", "_" + Detalle_Audiencia_Defensor_VictimainsertRowCurrentIndex);
}

function Detalle_Audiencia_Defensor_VictimaClearGridData() {
    Detalle_Audiencia_Defensor_VictimaData = [];
    Detalle_Audiencia_Defensor_VictimadeletedItem = [];
    Detalle_Audiencia_Defensor_VictimaDataMain = [];
    Detalle_Audiencia_Defensor_VictimaDataMainPages = [];
    Detalle_Audiencia_Defensor_VictimanewItemCount = 0;
    Detalle_Audiencia_Defensor_VictimamaxItemIndex = 0;
    $("#Detalle_Audiencia_Defensor_VictimaGrid").DataTable().clear();
    $("#Detalle_Audiencia_Defensor_VictimaGrid").DataTable().destroy();
}

//Used to Get Audiencias MP Information
function GetDetalle_Audiencia_Defensor_Victima() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Audiencia_Defensor_VictimaData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Audiencia_Defensor_VictimaData[i].Clave);

        form_data.append('[' + i + '].Nombre_del_Imputado', Detalle_Audiencia_Defensor_VictimaData[i].Nombre_del_Imputado);
        form_data.append('[' + i + '].Abogado', Detalle_Audiencia_Defensor_VictimaData[i].Abogado);
        form_data.append('[' + i + '].Cedula_Profesional', Detalle_Audiencia_Defensor_VictimaData[i].Cedula_Profesional);

        form_data.append('[' + i + '].Removed', Detalle_Audiencia_Defensor_VictimaData[i].Removed);
    }
    return form_data;
}
function Detalle_Audiencia_Defensor_VictimaInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Defensor_Victima("Detalle_Audiencia_Defensor_VictimaTable", rowIndex)) {
    var prevData = Detalle_Audiencia_Defensor_VictimaTable.fnGetData(rowIndex);
    var data = Detalle_Audiencia_Defensor_VictimaTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre_del_Imputado: $('#Detalle_Audiencia_Defensor_VictimaNombre_del_Imputado').val()
        ,Abogado: $('#Detalle_Audiencia_Defensor_VictimaAbogado').val()
        ,Cedula_Profesional: $('#Detalle_Audiencia_Defensor_VictimaCedula_Profesional').val()

    }

    Detalle_Audiencia_Defensor_VictimaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Audiencia_Defensor_VictimarowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Audiencia_Defensor_Victima-form').modal({ show: false });
    $('#AddDetalle_Audiencia_Defensor_Victima-form').modal('hide');
    Detalle_Audiencia_Defensor_VictimaEditRow(rowIndex);
    Detalle_Audiencia_Defensor_VictimaInsertRow(rowIndex);
    //}
}
function Detalle_Audiencia_Defensor_VictimaRemoveAddRow(rowIndex) {
    Detalle_Audiencia_Defensor_VictimaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Audiencia_Defensor_Victima MultiRow
//Begin Declarations for Foreigns fields for Detalle_Audiencia_Archivos_Adjuntos MultiRow
var Detalle_Audiencia_Archivos_AdjuntoscountRowsChecked = 0;





function GetInsertDetalle_Audiencia_Archivos_AdjuntosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_Audiencia_Archivos_Adjuntos_Nombre_Archivo Nombre_Archivo').attr('id', 'Detalle_Audiencia_Archivos_Adjuntos_Nombre_Archivo_' + index).attr('data-field', 'Nombre_Archivo');
    columnData[1] = $($.parseHTML(GetFileUploader())).addClass('Detalle_Audiencia_Archivos_Adjuntos_Archivo_Adjunto_FileUpload Archivo_Adjunto').attr('id', 'Detalle_Audiencia_Archivos_Adjuntos_Archivo_Adjunto_' + index).attr('data-field', 'Archivo_Adjunto');


    initiateUIControls();
    return columnData;
}

function Detalle_Audiencia_Archivos_AdjuntosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Archivos_Adjuntos("Detalle_Audiencia_Archivos_Adjuntos_", "_" + rowIndex)) {
    var iPage = Detalle_Audiencia_Archivos_AdjuntosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Audiencia_Archivos_Adjuntos';
    var prevData = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetData(rowIndex);
    var data = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre_Archivo:  data.childNodes[counter++].childNodes[0].value
        ,Archivo_AdjuntoFileInfo: ($('#' + nameOfGrid + 'Grid .Archivo_AdjuntoHeader').css('display') != 'none') ? { 
             FileName: prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null && prevData.Archivo_AdjuntoFileInfo.FileName != ''? prevData.Archivo_AdjuntoFileInfo.FileName : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : ''),              
			 FileId:   prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null && prevData.Archivo_AdjuntoFileInfo.FileName != '' ? prevData.Archivo_AdjuntoFileInfo.FileId :  prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileId != '' && prevData.Archivo_AdjuntoFileInfo.FileId != undefined ? prevData.Archivo_AdjuntoFileInfo.FileId : '0',
             FileSize: prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null ? prevData.Archivo_AdjuntoFileInfo.FileSize : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : '') 
         } : ''
        ,Archivo_AdjuntoDetail: (data.childNodes[counter] != 'undefined' && data.childNodes[counter].childNodes[0].childNodes.length == 0) ? data.childNodes[counter++].childNodes[0] : prevData.Archivo_AdjuntoDetail

    }
    Detalle_Audiencia_Archivos_AdjuntosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Audiencia_Archivos_AdjuntosrowCreationGrid(data, newData, rowIndex);
    Detalle_Audiencia_Archivos_AdjuntosTable.fnPageChange(iPage);
    Detalle_Audiencia_Archivos_AdjuntoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Audiencia_Archivos_Adjuntos("Detalle_Audiencia_Archivos_Adjuntos_", "_" + rowIndex);
  }
}

function Detalle_Audiencia_Archivos_AdjuntosCancelRow(rowIndex) {
    var prevData = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetData(rowIndex);
    var data = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Audiencia_Archivos_AdjuntosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Audiencia_Archivos_AdjuntosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Audiencia_Archivos_AdjuntosGrid(Detalle_Audiencia_Archivos_AdjuntosTable.fnGetData());
    Detalle_Audiencia_Archivos_AdjuntoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Audiencia_Archivos_AdjuntosFromDataTable() {
    var Detalle_Audiencia_Archivos_AdjuntosData = [];
    var gridData = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Audiencia_Archivos_AdjuntosData.push({
                Clave: gridData[i].Clave

                ,Nombre_Archivo: gridData[i].Nombre_Archivo
                ,Archivo_AdjuntoInfo: {
                    FileName: gridData[i].Archivo_AdjuntoFileInfo.FileName, FileId: gridData[i].Archivo_AdjuntoFileInfo.FileId, FileSize: gridData[i].Archivo_AdjuntoFileInfo.FileSize,
                    Control: gridData[i].Archivo_AdjuntoDetail != null && gridData[i].Archivo_AdjuntoDetail.files != null && gridData[i].Archivo_AdjuntoDetail.files.length > 0 ? gridData[i].Archivo_AdjuntoDetail.files[0] : null,
                    Archivo_AdjuntoRemoveFile: gridData[i].Archivo_AdjuntoDetail != null
                }

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Audiencia_Archivos_AdjuntosData.length; i++) {
        if (removedDetalle_Audiencia_Archivos_AdjuntosData[i] != null && removedDetalle_Audiencia_Archivos_AdjuntosData[i].Clave > 0)
            Detalle_Audiencia_Archivos_AdjuntosData.push({
                Clave: removedDetalle_Audiencia_Archivos_AdjuntosData[i].Clave

                ,Nombre_Archivo: removedDetalle_Audiencia_Archivos_AdjuntosData[i].Nombre_Archivo
                ,Archivo_AdjuntoInfo: {
                    FileName: removedDetalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoFileInfo.FileName, 
                    FileId: removedDetalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoFileInfo.FileId, 
                    FileSize: removedDetalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoFileInfo.FileSize,
                    Control: removedDetalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoDetail != null && removedDetalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoDetail.files.length > 0 ? removedDetalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoDetail.files[0] : null,
                    Archivo_AdjuntoRemoveFile: removedDetalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoDetail != null
                }

                , Removed: true
            });
    }	

    return Detalle_Audiencia_Archivos_AdjuntosData;
}

function Detalle_Audiencia_Archivos_AdjuntosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Audiencia_Archivos_AdjuntosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Audiencia_Archivos_AdjuntoscountRowsChecked++;
    var Detalle_Audiencia_Archivos_AdjuntosRowElement = "Detalle_Audiencia_Archivos_Adjuntos_" + rowIndex.toString();
    var prevData = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetData(rowIndexTable );
    var row = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Audiencia_Archivos_Adjuntos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Audiencia_Archivos_AdjuntosGetUpdateRowControls(prevData, "Detalle_Audiencia_Archivos_Adjuntos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Audiencia_Archivos_AdjuntosRowElement + "')){ Detalle_Audiencia_Archivos_AdjuntosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Audiencia_Archivos_AdjuntosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Audiencia_Archivos_AdjuntosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Audiencia_Archivos_AdjuntosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Audiencia_Archivos_AdjuntosValidation();
    initiateUIControls();
    $('.Detalle_Audiencia_Archivos_Adjuntos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Audiencia_Archivos_AdjuntosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetData().length;
    Detalle_Audiencia_Archivos_AdjuntosfnClickAddRow();
    GetAddDetalle_Audiencia_Archivos_AdjuntosPopup(currentRowIndex, 0);
}

function Detalle_Audiencia_Archivos_AdjuntosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Audiencia_Archivos_AdjuntosRowElement = "Detalle_Audiencia_Archivos_Adjuntos_" + rowIndex.toString();
    var prevData = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Audiencia_Archivos_AdjuntosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Audiencia_Archivos_AdjuntosNombre_Archivo').val(prevData.Nombre_Archivo);


    initiateUIControls();


    $('#existingArchivo_Adjunto').html(prevData.Archivo_AdjuntoFileDetail == null && (prevData.Archivo_AdjuntoFileInfo.FileId == null || prevData.Archivo_AdjuntoFileInfo.FileId <= 0) ? $.parseHTML(GetFileUploader()) : GetFileInfo(prevData.Archivo_AdjuntoFileInfo, prevData.Archivo_AdjuntoFileDetail));

}

function Detalle_Audiencia_Archivos_AdjuntosAddInsertRow() {
    if (Detalle_Audiencia_Archivos_AdjuntosinsertRowCurrentIndex < 1)
    {
        Detalle_Audiencia_Archivos_AdjuntosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre_Archivo: ""
        ,Archivo_AdjuntoFileInfo: ""

    }
}

function Detalle_Audiencia_Archivos_AdjuntosfnClickAddRow() {
    Detalle_Audiencia_Archivos_AdjuntoscountRowsChecked++;
    Detalle_Audiencia_Archivos_AdjuntosTable.fnAddData(Detalle_Audiencia_Archivos_AdjuntosAddInsertRow(), true);
    Detalle_Audiencia_Archivos_AdjuntosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Audiencia_Archivos_AdjuntosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Audiencia_Archivos_AdjuntosGrid tbody tr:nth-of-type(' + (Detalle_Audiencia_Archivos_AdjuntosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Audiencia_Archivos_Adjuntos("Detalle_Audiencia_Archivos_Adjuntos_", "_" + Detalle_Audiencia_Archivos_AdjuntosinsertRowCurrentIndex);
}

function Detalle_Audiencia_Archivos_AdjuntosClearGridData() {
    Detalle_Audiencia_Archivos_AdjuntosData = [];
    Detalle_Audiencia_Archivos_AdjuntosdeletedItem = [];
    Detalle_Audiencia_Archivos_AdjuntosDataMain = [];
    Detalle_Audiencia_Archivos_AdjuntosDataMainPages = [];
    Detalle_Audiencia_Archivos_AdjuntosnewItemCount = 0;
    Detalle_Audiencia_Archivos_AdjuntosmaxItemIndex = 0;
    $("#Detalle_Audiencia_Archivos_AdjuntosGrid").DataTable().clear();
    $("#Detalle_Audiencia_Archivos_AdjuntosGrid").DataTable().destroy();
}

//Used to Get Audiencias MP Information
function GetDetalle_Audiencia_Archivos_Adjuntos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Audiencia_Archivos_AdjuntosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Audiencia_Archivos_AdjuntosData[i].Clave);

        form_data.append('[' + i + '].Nombre_Archivo', Detalle_Audiencia_Archivos_AdjuntosData[i].Nombre_Archivo);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileId', Detalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoInfo.FileId);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileName', Detalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoInfo.FileName);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileSize', Detalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoInfo.FileSize);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.Control', Detalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoInfo.Control);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.RemoveFile', Detalle_Audiencia_Archivos_AdjuntosData[i].Archivo_AdjuntoInfo.ArchivoRemoveFile);

        form_data.append('[' + i + '].Removed', Detalle_Audiencia_Archivos_AdjuntosData[i].Removed);
    }
    return form_data;
}
function Detalle_Audiencia_Archivos_AdjuntosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Archivos_Adjuntos("Detalle_Audiencia_Archivos_AdjuntosTable", rowIndex)) {
    var prevData = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetData(rowIndex);
    var data = Detalle_Audiencia_Archivos_AdjuntosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre_Archivo: $('#Detalle_Audiencia_Archivos_AdjuntosNombre_Archivo').val()
        ,Archivo_AdjuntoFileInfo: { Archivo_AdjuntoFileName: prevData.Archivo_AdjuntoFileInfo.FileName, Archivo_AdjuntoFileId: prevData.Archivo_AdjuntoFileInfo.FileId, Archivo_AdjuntoFileSize: prevData.Archivo_AdjuntoFileInfo.FileSize }
        ,Archivo_AdjuntoFileDetail: $('#Archivo_Adjunto').find('label').length == 0 ? $('#Archivo_AdjuntoFileInfoPop')[0] : prevData.Archivo_AdjuntoFileDetail

    }

    Detalle_Audiencia_Archivos_AdjuntosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Audiencia_Archivos_AdjuntosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Audiencia_Archivos_Adjuntos-form').modal({ show: false });
    $('#AddDetalle_Audiencia_Archivos_Adjuntos-form').modal('hide');
    Detalle_Audiencia_Archivos_AdjuntosEditRow(rowIndex);
    Detalle_Audiencia_Archivos_AdjuntosInsertRow(rowIndex);
    //}
}
function Detalle_Audiencia_Archivos_AdjuntosRemoveAddRow(rowIndex) {
    Detalle_Audiencia_Archivos_AdjuntosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Audiencia_Archivos_Adjuntos MultiRow


$(function () {
    function Detalle_Audiencia_Defensor_ImputadoinitializeMainArray(totalCount) {
        if (Detalle_Audiencia_Defensor_ImputadoDataMain.length != totalCount && !Detalle_Audiencia_Defensor_ImputadoDataMainInitialized) {
            Detalle_Audiencia_Defensor_ImputadoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Audiencia_Defensor_ImputadoDataMain[i] = null;
            }
        }
    }
    function Detalle_Audiencia_Defensor_ImputadoremoveFromMainArray() {
        for (var j = 0; j < Detalle_Audiencia_Defensor_ImputadodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Audiencia_Defensor_ImputadoDataMain.length; i++) {
                if (Detalle_Audiencia_Defensor_ImputadoDataMain[i] != null && Detalle_Audiencia_Defensor_ImputadoDataMain[i].Id == Detalle_Audiencia_Defensor_ImputadodeletedItem[j]) {
                    hDetalle_Audiencia_Defensor_ImputadoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Audiencia_Defensor_ImputadocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Audiencia_Defensor_ImputadoDataMain.length; i++) {
            data[i] = Detalle_Audiencia_Defensor_ImputadoDataMain[i];

        }
        return data;
    }
    function Detalle_Audiencia_Defensor_ImputadogetNewResult() {
        var newData = copyMainDetalle_Audiencia_Defensor_ImputadoArray();

        for (var i = 0; i < Detalle_Audiencia_Defensor_ImputadoData.length; i++) {
            if (Detalle_Audiencia_Defensor_ImputadoData[i].Removed == null || Detalle_Audiencia_Defensor_ImputadoData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Audiencia_Defensor_ImputadoData[i]);
            }
        }
        return newData;
    }
    function Detalle_Audiencia_Defensor_ImputadopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Audiencia_Defensor_ImputadoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Audiencia_Defensor_ImputadoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Audiencia_Defensor_VictimainitializeMainArray(totalCount) {
        if (Detalle_Audiencia_Defensor_VictimaDataMain.length != totalCount && !Detalle_Audiencia_Defensor_VictimaDataMainInitialized) {
            Detalle_Audiencia_Defensor_VictimaDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Audiencia_Defensor_VictimaDataMain[i] = null;
            }
        }
    }
    function Detalle_Audiencia_Defensor_VictimaremoveFromMainArray() {
        for (var j = 0; j < Detalle_Audiencia_Defensor_VictimadeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Audiencia_Defensor_VictimaDataMain.length; i++) {
                if (Detalle_Audiencia_Defensor_VictimaDataMain[i] != null && Detalle_Audiencia_Defensor_VictimaDataMain[i].Id == Detalle_Audiencia_Defensor_VictimadeletedItem[j]) {
                    hDetalle_Audiencia_Defensor_VictimaDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Audiencia_Defensor_VictimacopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Audiencia_Defensor_VictimaDataMain.length; i++) {
            data[i] = Detalle_Audiencia_Defensor_VictimaDataMain[i];

        }
        return data;
    }
    function Detalle_Audiencia_Defensor_VictimagetNewResult() {
        var newData = copyMainDetalle_Audiencia_Defensor_VictimaArray();

        for (var i = 0; i < Detalle_Audiencia_Defensor_VictimaData.length; i++) {
            if (Detalle_Audiencia_Defensor_VictimaData[i].Removed == null || Detalle_Audiencia_Defensor_VictimaData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Audiencia_Defensor_VictimaData[i]);
            }
        }
        return newData;
    }
    function Detalle_Audiencia_Defensor_VictimapushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Audiencia_Defensor_VictimaDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Audiencia_Defensor_VictimaDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Audiencia_Archivos_AdjuntosinitializeMainArray(totalCount) {
        if (Detalle_Audiencia_Archivos_AdjuntosDataMain.length != totalCount && !Detalle_Audiencia_Archivos_AdjuntosDataMainInitialized) {
            Detalle_Audiencia_Archivos_AdjuntosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Audiencia_Archivos_AdjuntosDataMain[i] = null;
            }
        }
    }
    function Detalle_Audiencia_Archivos_AdjuntosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Audiencia_Archivos_AdjuntosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Audiencia_Archivos_AdjuntosDataMain.length; i++) {
                if (Detalle_Audiencia_Archivos_AdjuntosDataMain[i] != null && Detalle_Audiencia_Archivos_AdjuntosDataMain[i].Id == Detalle_Audiencia_Archivos_AdjuntosdeletedItem[j]) {
                    hDetalle_Audiencia_Archivos_AdjuntosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Audiencia_Archivos_AdjuntoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Audiencia_Archivos_AdjuntosDataMain.length; i++) {
            data[i] = Detalle_Audiencia_Archivos_AdjuntosDataMain[i];

        }
        return data;
    }
    function Detalle_Audiencia_Archivos_AdjuntosgetNewResult() {
        var newData = copyMainDetalle_Audiencia_Archivos_AdjuntosArray();

        for (var i = 0; i < Detalle_Audiencia_Archivos_AdjuntosData.length; i++) {
            if (Detalle_Audiencia_Archivos_AdjuntosData[i].Removed == null || Detalle_Audiencia_Archivos_AdjuntosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Audiencia_Archivos_AdjuntosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Audiencia_Archivos_AdjuntospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Audiencia_Archivos_AdjuntosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Audiencia_Archivos_AdjuntosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteExpediente_MPData = [];
function GetAutoCompleteAudiencias_MP_Expediente_MP_expediente_ministerio_publicoData(data) {
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
var AutoCompleteNombre_Del_ImputadoData = [];
function GetAutoCompleteDetalle_Audiencia_Defensor_Imputado_Nombre_Del_Imputado_Detalle_de_ImputadoData(data) {
	AutoCompleteNombre_Del_ImputadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNombre_Del_ImputadoData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo_del_Tutor
        });
    }
    return AutoCompleteNombre_Del_ImputadoData;
}

//Grid GetAutocomplete
var AutoCompleteNombre_del_ImputadoData = [];
function GetAutoCompleteDetalle_Audiencia_Defensor_Victima_Nombre_del_Imputado_Detalle_de_Datos_GeneralesData(data) {
	AutoCompleteNombre_del_ImputadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNombre_del_ImputadoData.push({
            id: data[i].Clave,
            text: data[i].Nombre_Completo
        });
    }
    return AutoCompleteNombre_del_ImputadoData;
}

//Grid GetAutocomplete

var AutoCompleteMP_LitigacionData = [];
function GetAutoCompleteAudiencias_MP_MP_Litigacion_Spartan_UserData(data) {
	AutoCompleteMP_LitigacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMP_LitigacionData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteMP_LitigacionData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#Audiencias_MP_cmbLabelSelect").val();
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
    $('#CreateAudiencias_MP')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
                Detalle_Audiencia_Defensor_ImputadoClearGridData();
                Detalle_Audiencia_Defensor_VictimaClearGridData();
                Detalle_Audiencia_Archivos_AdjuntosClearGridData();
    $('#MP_Litigacion').empty();
    $("#MP_Litigacion").append('<option value=""></option>');
    $('#MP_Litigacion').val('0').trigger('change');

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateAudiencias_MP').trigger('reset');
    $('#CreateAudiencias_MP').find(':input').each(function () {
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
    var $myForm = $('#CreateAudiencias_MP');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Audiencia_Defensor_ImputadocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Audiencia_Defensor_Imputado();
        return false;
    }
    if (Detalle_Audiencia_Defensor_VictimacountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Audiencia_Defensor_Victima();
        return false;
    }
    if (Detalle_Audiencia_Archivos_AdjuntoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Audiencia_Archivos_Adjuntos();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateAudiencias_MP").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateAudiencias_MP").on('click', '#Audiencias_MPCancelar', function () {
	  if (!isPartial) {
        Audiencias_MPBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateAudiencias_MP").on('click', '#Audiencias_MPGuardar', function () {
		$('#Audiencias_MPGuardar').attr('disabled', true);
		$('#Audiencias_MPGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendAudiencias_MPData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Audiencias_MPBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Audiencias_MPGuardar').removeAttr('disabled');
                        $('#Audiencias_MPGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Audiencias_MP', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Audiencias_MPItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Audiencias_MPDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Audiencias_MPGuardar').removeAttr('disabled');
					$('#Audiencias_MPGuardar').bind()
				}
		}
		else {
			$('#Audiencias_MPGuardar').removeAttr('disabled');
			$('#Audiencias_MPGuardar').bind()
		}
    });
	$("form#CreateAudiencias_MP").on('click', '#Audiencias_MPGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendAudiencias_MPData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Audiencia_Defensor_ImputadoData();
                getDetalle_Audiencia_Defensor_VictimaData();
                getDetalle_Audiencia_Archivos_AdjuntosData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Audiencias_MP', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Audiencias_MPItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Audiencias_MPDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateAudiencias_MP").on('click', '#Audiencias_MPGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendAudiencias_MPData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
                Detalle_Audiencia_Defensor_ImputadoClearGridData();
                Detalle_Audiencia_Defensor_VictimaClearGridData();
                Detalle_Audiencia_Archivos_AdjuntosClearGridData();
    $('#MP_Litigacion').empty();
    $("#MP_Litigacion").append('<option value=""></option>');
    $('#MP_Litigacion').val('0').trigger('change');

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Audiencia_Defensor_ImputadoData();
                getDetalle_Audiencia_Defensor_VictimaData();
                getDetalle_Audiencia_Archivos_AdjuntosData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Audiencias_MP',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Audiencias_MPItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Audiencias_MPDropDown().get(0)').innerHTML);                          
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



var Audiencias_MPisdisplayBusinessPropery = false;
Audiencias_MPDisplayBusinessRuleButtons(Audiencias_MPisdisplayBusinessPropery);
function Audiencias_MPDisplayBusinessRule() {
    if (!Audiencias_MPisdisplayBusinessPropery) {
        $('#CreateAudiencias_MP').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Audiencias_MPdisplayBusinessPropery"><button onclick="Audiencias_MPGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Audiencias_MPBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Audiencias_MPdisplayBusinessPropery').remove();
    }
    Audiencias_MPDisplayBusinessRuleButtons(!Audiencias_MPisdisplayBusinessPropery);
    Audiencias_MPisdisplayBusinessPropery = (Audiencias_MPisdisplayBusinessPropery ? false : true);
}
function Audiencias_MPDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

