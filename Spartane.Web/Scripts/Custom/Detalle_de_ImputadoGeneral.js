        function RemoveAttachmentMainImagen_Tatuaje () {
            $("#hdnRemoveImagen_Tatuaje").val("1");
            $("#divAttachmentImagen_Tatuaje").hide();
        }


//Begin Declarations for Foreigns fields for Lugar_de_Detencion MultiRow
var Lugar_de_DetencioncountRowsChecked = 0;


function GetLugar_de_Detencion_MunicipioName(Id) {
    for (var i = 0; i < Lugar_de_Detencion_MunicipioItems.length; i++) {
        if (Lugar_de_Detencion_MunicipioItems[i].Clave == Id) {
            return Lugar_de_Detencion_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetLugar_de_Detencion_MunicipioDropDown() {
    var Lugar_de_Detencion_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Lugar_de_Detencion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Lugar_de_Detencion_MunicipioDropdown);

    for (var i = 0; i < Lugar_de_Detencion_MunicipioItems.length; i++) {
        $('<option />', { value: Lugar_de_Detencion_MunicipioItems[i].Clave, text: Lugar_de_Detencion_MunicipioItems[i].Nombre }).appendTo(Lugar_de_Detencion_MunicipioDropdown);
    }
    return Lugar_de_Detencion_MunicipioDropdown;
}
function GetLugar_de_Detencion_CorporacionName(Id) {
    for (var i = 0; i < Lugar_de_Detencion_CorporacionItems.length; i++) {
        if (Lugar_de_Detencion_CorporacionItems[i].Clave == Id) {
            return Lugar_de_Detencion_CorporacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetLugar_de_Detencion_CorporacionDropDown() {
    var Lugar_de_Detencion_CorporacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Lugar_de_Detencion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Lugar_de_Detencion_CorporacionDropdown);
    if(Lugar_de_Detencion_CorporacionItems != null)
    {
       for (var i = 0; i < Lugar_de_Detencion_CorporacionItems.length; i++) {
           $('<option />', { value: Lugar_de_Detencion_CorporacionItems[i].Clave, text:    Lugar_de_Detencion_CorporacionItems[i].Descripcion }).appendTo(Lugar_de_Detencion_CorporacionDropdown);
       }
    }
    return Lugar_de_Detencion_CorporacionDropdown;
}




function GetInsertLugar_de_DetencionRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Lugar_de_Detencion_Fecha_de_Detencion Fecha_de_Detencion').attr('id', 'Lugar_de_Detencion_Fecha_de_Detencion_' + index).attr('data-field', 'Fecha_de_Detencion');
    columnData[1] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteLugar_de_Detencion_Municipio_de_Detencion'))).addClass('Lugar_de_Detencion_Municipio_de_Detencion Municipio_de_Detencion').attr('id', 'Lugar_de_Detencion_Municipio_de_Detencion_' + index).attr('data-field', 'Municipio_de_Detencion').after($.parseHTML(addNew('Lugar_de_Detencion', 'Municipio', 'Municipio_de_Detencion', 265693)));
    columnData[2] = $(GetLugar_de_Detencion_CorporacionDropDown()).addClass('Lugar_de_Detencion_Corporacion Corporacion').attr('id', 'Lugar_de_Detencion_Corporacion_' + index).attr('data-field', 'Corporacion').after($.parseHTML(addNew('Lugar_de_Detencion', 'Corporacion', 'Corporacion', 265694)));
    columnData[3] = $($.parseHTML(GetGridCheckBox())).addClass('Lugar_de_Detencion_Suspension_Condicional Suspension_Condicional').attr('id', 'Lugar_de_Detencion_Suspension_Condicional_' + index).attr('data-field', 'Suspension_Condicional');
    columnData[4] = $($.parseHTML(GetGridDatePicker())).addClass('Lugar_de_Detencion_Fecha_de_Suspension_Condicional Fecha_de_Suspension_Condicional').attr('id', 'Lugar_de_Detencion_Fecha_de_Suspension_Condicional_' + index).attr('data-field', 'Fecha_de_Suspension_Condicional');


    initiateUIControls();
    return columnData;
}

function Lugar_de_DetencionInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRLugar_de_Detencion("Lugar_de_Detencion_", "_" + rowIndex)) {
    var iPage = Lugar_de_DetencionTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Lugar_de_Detencion';
    var prevData = Lugar_de_DetencionTable.fnGetData(rowIndex);
    var data = Lugar_de_DetencionTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha_de_Detencion:  data.childNodes[counter++].childNodes[0].value
        , Municipio_de_DetencionNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Municipio_de_Detencion:  data.childNodes[counter++].childNodes[0].value 	
        ,Corporacion:  data.childNodes[counter++].childNodes[0].value
        ,Suspension_Condicional: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Fecha_de_Suspension_Condicional:  data.childNodes[counter++].childNodes[0].value

    }
    Lugar_de_DetencionTable.fnUpdate(newData, rowIndex, null, true);
    Lugar_de_DetencionrowCreationGrid(data, newData, rowIndex);
    Lugar_de_DetencionTable.fnPageChange(iPage);
    Lugar_de_DetencioncountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRLugar_de_Detencion("Lugar_de_Detencion_", "_" + rowIndex);
  }
}

function Lugar_de_DetencionCancelRow(rowIndex) {
    var prevData = Lugar_de_DetencionTable.fnGetData(rowIndex);
    var data = Lugar_de_DetencionTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Lugar_de_DetencionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Lugar_de_DetencionrowCreationGrid(data, prevData, rowIndex);
    }
	showLugar_de_DetencionGrid(Lugar_de_DetencionTable.fnGetData());
    Lugar_de_DetencioncountRowsChecked--;
	initiateUIControls();
}

function GetLugar_de_DetencionFromDataTable() {
    var Lugar_de_DetencionData = [];
    var gridData = Lugar_de_DetencionTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Lugar_de_DetencionData.push({
                Clave: gridData[i].Clave

                ,Fecha_de_Detencion: gridData[i].Fecha_de_Detencion
                ,Municipio_de_Detencion: gridData[i].Municipio_de_Detencion
                ,Corporacion: gridData[i].Corporacion
                ,Suspension_Condicional: gridData[i].Suspension_Condicional
                ,Fecha_de_Suspension_Condicional: gridData[i].Fecha_de_Suspension_Condicional

                ,Removed: false
            });
    }

    for (i = 0; i < removedLugar_de_DetencionData.length; i++) {
        if (removedLugar_de_DetencionData[i] != null && removedLugar_de_DetencionData[i].Clave > 0)
            Lugar_de_DetencionData.push({
                Clave: removedLugar_de_DetencionData[i].Clave

                ,Fecha_de_Detencion: removedLugar_de_DetencionData[i].Fecha_de_Detencion
                ,Municipio_de_Detencion: removedLugar_de_DetencionData[i].Municipio_de_Detencion
                ,Corporacion: removedLugar_de_DetencionData[i].Corporacion
                ,Suspension_Condicional: removedLugar_de_DetencionData[i].Suspension_Condicional
                ,Fecha_de_Suspension_Condicional: removedLugar_de_DetencionData[i].Fecha_de_Suspension_Condicional

                , Removed: true
            });
    }	

    return Lugar_de_DetencionData;
}

function Lugar_de_DetencionEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Lugar_de_DetencionTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Lugar_de_DetencioncountRowsChecked++;
    var Lugar_de_DetencionRowElement = "Lugar_de_Detencion_" + rowIndex.toString();
    var prevData = Lugar_de_DetencionTable.fnGetData(rowIndexTable );
    var row = Lugar_de_DetencionTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Lugar_de_Detencion_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Lugar_de_DetencionGetUpdateRowControls(prevData, "Lugar_de_Detencion_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Lugar_de_DetencionRowElement + "')){ Lugar_de_DetencionInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Lugar_de_DetencionCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Lugar_de_DetencionGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Lugar_de_DetencionGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setLugar_de_DetencionValidation();
    initiateUIControls();
    $('.Lugar_de_Detencion' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRLugar_de_Detencion(nameOfTable, rowIndexFormed);
    }
}

function Lugar_de_DetencionfnOpenAddRowPopUp() {
    var currentRowIndex = Lugar_de_DetencionTable.fnGetData().length;
    Lugar_de_DetencionfnClickAddRow();
    GetAddLugar_de_DetencionPopup(currentRowIndex, 0);
}

function Lugar_de_DetencionEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Lugar_de_DetencionTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Lugar_de_DetencionRowElement = "Lugar_de_Detencion_" + rowIndex.toString();
    var prevData = Lugar_de_DetencionTable.fnGetData(rowIndexTable);
    GetAddLugar_de_DetencionPopup(rowIndex, 1, prevData.Clave);

    $('#Lugar_de_DetencionFecha_de_Detencion').val(prevData.Fecha_de_Detencion);
    $('#dvLugar_de_DetencionMunicipio_de_Detencion').html($($.parseHTML(GetGridAutoComplete(prevData.Municipio_de_Detencion.label,'AutoCompleteMunicipio_de_Detencion'))).addClass('Lugar_de_Detencion_Municipio_de_Detencion'));
    $('#Lugar_de_DetencionCorporacion').val(prevData.Corporacion);
    $('#Lugar_de_DetencionSuspension_Condicional').prop('checked', prevData.Suspension_Condicional);
    $('#Lugar_de_DetencionFecha_de_Suspension_Condicional').val(prevData.Fecha_de_Suspension_Condicional);

    initiateUIControls();







}

function Lugar_de_DetencionAddInsertRow() {
    if (Lugar_de_DetencioninsertRowCurrentIndex < 1)
    {
        Lugar_de_DetencioninsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha_de_Detencion: ""
        ,Municipio_de_Detencion: ""
        ,Corporacion: ""
        ,Suspension_Condicional: ""
        ,Fecha_de_Suspension_Condicional: ""

    }
}

function Lugar_de_DetencionfnClickAddRow() {
    Lugar_de_DetencioncountRowsChecked++;
    Lugar_de_DetencionTable.fnAddData(Lugar_de_DetencionAddInsertRow(), true);
    Lugar_de_DetencionTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Lugar_de_DetencionGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Lugar_de_DetencionGrid tbody tr:nth-of-type(' + (Lugar_de_DetencioninsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRLugar_de_Detencion("Lugar_de_Detencion_", "_" + Lugar_de_DetencioninsertRowCurrentIndex);
}

function Lugar_de_DetencionClearGridData() {
    Lugar_de_DetencionData = [];
    Lugar_de_DetenciondeletedItem = [];
    Lugar_de_DetencionDataMain = [];
    Lugar_de_DetencionDataMainPages = [];
    Lugar_de_DetencionnewItemCount = 0;
    Lugar_de_DetencionmaxItemIndex = 0;
    $("#Lugar_de_DetencionGrid").DataTable().clear();
    $("#Lugar_de_DetencionGrid").DataTable().destroy();
}

//Used to Get Probable Responsable Information
function GetLugar_de_Detencion() {
    var form_data = new FormData();
    for (var i = 0; i < Lugar_de_DetencionData.length; i++) {
        form_data.append('[' + i + '].Clave', Lugar_de_DetencionData[i].Clave);

        form_data.append('[' + i + '].Fecha_de_Detencion', Lugar_de_DetencionData[i].Fecha_de_Detencion);
        form_data.append('[' + i + '].Municipio_de_Detencion', Lugar_de_DetencionData[i].Municipio_de_Detencion);
        form_data.append('[' + i + '].Corporacion', Lugar_de_DetencionData[i].Corporacion);
        form_data.append('[' + i + '].Suspension_Condicional', Lugar_de_DetencionData[i].Suspension_Condicional);
        form_data.append('[' + i + '].Fecha_de_Suspension_Condicional', Lugar_de_DetencionData[i].Fecha_de_Suspension_Condicional);

        form_data.append('[' + i + '].Removed', Lugar_de_DetencionData[i].Removed);
    }
    return form_data;
}
function Lugar_de_DetencionInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRLugar_de_Detencion("Lugar_de_DetencionTable", rowIndex)) {
    var prevData = Lugar_de_DetencionTable.fnGetData(rowIndex);
    var data = Lugar_de_DetencionTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha_de_Detencion: $('#Lugar_de_DetencionFecha_de_Detencion').val()
        ,Municipio_de_Detencion: $('#Lugar_de_DetencionMunicipio_de_Detencion').val()
        ,Corporacion: $('#Lugar_de_DetencionCorporacion').val()
        ,Suspension_Condicional: $('#Lugar_de_DetencionSuspension_Condicional').is(':checked')
        ,Fecha_de_Suspension_Condicional: $('#Lugar_de_DetencionFecha_de_Suspension_Condicional').val()

    }

    Lugar_de_DetencionTable.fnUpdate(newData, rowIndex, null, true);
    Lugar_de_DetencionrowCreationGrid(data, newData, rowIndex);
    $('#AddLugar_de_Detencion-form').modal({ show: false });
    $('#AddLugar_de_Detencion-form').modal('hide');
    Lugar_de_DetencionEditRow(rowIndex);
    Lugar_de_DetencionInsertRow(rowIndex);
    //}
}
function Lugar_de_DetencionRemoveAddRow(rowIndex) {
    Lugar_de_DetencionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Lugar_de_Detencion MultiRow
//Begin Declarations for Foreigns fields for Adicciones_Probable_Responsable MultiRow
var Adicciones_Probable_ResponsablecountRowsChecked = 0;

function GetAdicciones_Probable_Responsable_AdiccionesName(Id) {
    for (var i = 0; i < Adicciones_Probable_Responsable_AdiccionesItems.length; i++) {
        if (Adicciones_Probable_Responsable_AdiccionesItems[i].Clave == Id) {
            return Adicciones_Probable_Responsable_AdiccionesItems[i].Descripcion;
        }
    }
    return "";
}

function GetAdicciones_Probable_Responsable_AdiccionesDropDown() {
    var Adicciones_Probable_Responsable_AdiccionesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Adicciones_Probable_Responsable_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Adicciones_Probable_Responsable_AdiccionesDropdown);
    if(Adicciones_Probable_Responsable_AdiccionesItems != null)
    {
       for (var i = 0; i < Adicciones_Probable_Responsable_AdiccionesItems.length; i++) {
           $('<option />', { value: Adicciones_Probable_Responsable_AdiccionesItems[i].Clave, text:    Adicciones_Probable_Responsable_AdiccionesItems[i].Descripcion }).appendTo(Adicciones_Probable_Responsable_AdiccionesDropdown);
       }
    }
    return Adicciones_Probable_Responsable_AdiccionesDropdown;
}


function GetInsertAdicciones_Probable_ResponsableRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetAdicciones_Probable_Responsable_AdiccionesDropDown()).addClass('Adicciones_Probable_Responsable_Descripcion Descripcion').attr('id', 'Adicciones_Probable_Responsable_Descripcion_' + index).attr('data-field', 'Descripcion').after($.parseHTML(addNew('Adicciones_Probable_Responsable', 'Adicciones', 'Descripcion', 265750)));


    initiateUIControls();
    return columnData;
}

function Adicciones_Probable_ResponsableInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRAdicciones_Probable_Responsable("Adicciones_Probable_Responsable_", "_" + rowIndex)) {
    var iPage = Adicciones_Probable_ResponsableTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Adicciones_Probable_Responsable';
    var prevData = Adicciones_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Adicciones_Probable_ResponsableTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Adicciones_Probable_ResponsableTable.fnUpdate(newData, rowIndex, null, true);
    Adicciones_Probable_ResponsablerowCreationGrid(data, newData, rowIndex);
    Adicciones_Probable_ResponsableTable.fnPageChange(iPage);
    Adicciones_Probable_ResponsablecountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRAdicciones_Probable_Responsable("Adicciones_Probable_Responsable_", "_" + rowIndex);
  }
}

function Adicciones_Probable_ResponsableCancelRow(rowIndex) {
    var prevData = Adicciones_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Adicciones_Probable_ResponsableTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Adicciones_Probable_ResponsableTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Adicciones_Probable_ResponsablerowCreationGrid(data, prevData, rowIndex);
    }
	showAdicciones_Probable_ResponsableGrid(Adicciones_Probable_ResponsableTable.fnGetData());
    Adicciones_Probable_ResponsablecountRowsChecked--;
	initiateUIControls();
}

function GetAdicciones_Probable_ResponsableFromDataTable() {
    var Adicciones_Probable_ResponsableData = [];
    var gridData = Adicciones_Probable_ResponsableTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Adicciones_Probable_ResponsableData.push({
                Clave: gridData[i].Clave

                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedAdicciones_Probable_ResponsableData.length; i++) {
        if (removedAdicciones_Probable_ResponsableData[i] != null && removedAdicciones_Probable_ResponsableData[i].Clave > 0)
            Adicciones_Probable_ResponsableData.push({
                Clave: removedAdicciones_Probable_ResponsableData[i].Clave

                ,Descripcion: removedAdicciones_Probable_ResponsableData[i].Descripcion

                , Removed: true
            });
    }	

    return Adicciones_Probable_ResponsableData;
}

function Adicciones_Probable_ResponsableEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Adicciones_Probable_ResponsableTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Adicciones_Probable_ResponsablecountRowsChecked++;
    var Adicciones_Probable_ResponsableRowElement = "Adicciones_Probable_Responsable_" + rowIndex.toString();
    var prevData = Adicciones_Probable_ResponsableTable.fnGetData(rowIndexTable );
    var row = Adicciones_Probable_ResponsableTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Adicciones_Probable_Responsable_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Adicciones_Probable_ResponsableGetUpdateRowControls(prevData, "Adicciones_Probable_Responsable_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Adicciones_Probable_ResponsableRowElement + "')){ Adicciones_Probable_ResponsableInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Adicciones_Probable_ResponsableCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Adicciones_Probable_ResponsableGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Adicciones_Probable_ResponsableGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setAdicciones_Probable_ResponsableValidation();
    initiateUIControls();
    $('.Adicciones_Probable_Responsable' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRAdicciones_Probable_Responsable(nameOfTable, rowIndexFormed);
    }
}

function Adicciones_Probable_ResponsablefnOpenAddRowPopUp() {
    var currentRowIndex = Adicciones_Probable_ResponsableTable.fnGetData().length;
    Adicciones_Probable_ResponsablefnClickAddRow();
    GetAddAdicciones_Probable_ResponsablePopup(currentRowIndex, 0);
}

function Adicciones_Probable_ResponsableEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Adicciones_Probable_ResponsableTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Adicciones_Probable_ResponsableRowElement = "Adicciones_Probable_Responsable_" + rowIndex.toString();
    var prevData = Adicciones_Probable_ResponsableTable.fnGetData(rowIndexTable);
    GetAddAdicciones_Probable_ResponsablePopup(rowIndex, 1, prevData.Clave);

    $('#Adicciones_Probable_ResponsableDescripcion').val(prevData.Descripcion);

    initiateUIControls();



}

function Adicciones_Probable_ResponsableAddInsertRow() {
    if (Adicciones_Probable_ResponsableinsertRowCurrentIndex < 1)
    {
        Adicciones_Probable_ResponsableinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Descripcion: ""

    }
}

function Adicciones_Probable_ResponsablefnClickAddRow() {
    Adicciones_Probable_ResponsablecountRowsChecked++;
    Adicciones_Probable_ResponsableTable.fnAddData(Adicciones_Probable_ResponsableAddInsertRow(), true);
    Adicciones_Probable_ResponsableTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Adicciones_Probable_ResponsableGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Adicciones_Probable_ResponsableGrid tbody tr:nth-of-type(' + (Adicciones_Probable_ResponsableinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRAdicciones_Probable_Responsable("Adicciones_Probable_Responsable_", "_" + Adicciones_Probable_ResponsableinsertRowCurrentIndex);
}

function Adicciones_Probable_ResponsableClearGridData() {
    Adicciones_Probable_ResponsableData = [];
    Adicciones_Probable_ResponsabledeletedItem = [];
    Adicciones_Probable_ResponsableDataMain = [];
    Adicciones_Probable_ResponsableDataMainPages = [];
    Adicciones_Probable_ResponsablenewItemCount = 0;
    Adicciones_Probable_ResponsablemaxItemIndex = 0;
    $("#Adicciones_Probable_ResponsableGrid").DataTable().clear();
    $("#Adicciones_Probable_ResponsableGrid").DataTable().destroy();
}

//Used to Get Probable Responsable Information
function GetAdicciones_Probable_Responsable() {
    var form_data = new FormData();
    for (var i = 0; i < Adicciones_Probable_ResponsableData.length; i++) {
        form_data.append('[' + i + '].Clave', Adicciones_Probable_ResponsableData[i].Clave);

        form_data.append('[' + i + '].Descripcion', Adicciones_Probable_ResponsableData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Adicciones_Probable_ResponsableData[i].Removed);
    }
    return form_data;
}
function Adicciones_Probable_ResponsableInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRAdicciones_Probable_Responsable("Adicciones_Probable_ResponsableTable", rowIndex)) {
    var prevData = Adicciones_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Adicciones_Probable_ResponsableTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Descripcion: $('#Adicciones_Probable_ResponsableDescripcion').val()

    }

    Adicciones_Probable_ResponsableTable.fnUpdate(newData, rowIndex, null, true);
    Adicciones_Probable_ResponsablerowCreationGrid(data, newData, rowIndex);
    $('#AddAdicciones_Probable_Responsable-form').modal({ show: false });
    $('#AddAdicciones_Probable_Responsable-form').modal('hide');
    Adicciones_Probable_ResponsableEditRow(rowIndex);
    Adicciones_Probable_ResponsableInsertRow(rowIndex);
    //}
}
function Adicciones_Probable_ResponsableRemoveAddRow(rowIndex) {
    Adicciones_Probable_ResponsableTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Adicciones_Probable_Responsable MultiRow
//Begin Declarations for Foreigns fields for Lugares_Frecuentes_Probable_Responsable MultiRow
var Lugares_Frecuentes_Probable_ResponsablecountRowsChecked = 0;

function GetLugares_Frecuentes_Probable_Responsable_LugaresName(Id) {
    for (var i = 0; i < Lugares_Frecuentes_Probable_Responsable_LugaresItems.length; i++) {
        if (Lugares_Frecuentes_Probable_Responsable_LugaresItems[i].Clave == Id) {
            return Lugares_Frecuentes_Probable_Responsable_LugaresItems[i].Descripcion;
        }
    }
    return "";
}

function GetLugares_Frecuentes_Probable_Responsable_LugaresDropDown() {
    var Lugares_Frecuentes_Probable_Responsable_LugaresDropdown = $('<select class="form-control" />');      var labelSelect = $("#Lugares_Frecuentes_Probable_Responsable_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Lugares_Frecuentes_Probable_Responsable_LugaresDropdown);
    if(Lugares_Frecuentes_Probable_Responsable_LugaresItems != null)
    {
       for (var i = 0; i < Lugares_Frecuentes_Probable_Responsable_LugaresItems.length; i++) {
           $('<option />', { value: Lugares_Frecuentes_Probable_Responsable_LugaresItems[i].Clave, text:    Lugares_Frecuentes_Probable_Responsable_LugaresItems[i].Descripcion }).appendTo(Lugares_Frecuentes_Probable_Responsable_LugaresDropdown);
       }
    }
    return Lugares_Frecuentes_Probable_Responsable_LugaresDropdown;
}



function GetInsertLugares_Frecuentes_Probable_ResponsableRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetLugares_Frecuentes_Probable_Responsable_LugaresDropDown()).addClass('Lugares_Frecuentes_Probable_Responsable_Tipo_de_Lugar Tipo_de_Lugar').attr('id', 'Lugares_Frecuentes_Probable_Responsable_Tipo_de_Lugar_' + index).attr('data-field', 'Tipo_de_Lugar').after($.parseHTML(addNew('Lugares_Frecuentes_Probable_Responsable', 'Lugares', 'Tipo_de_Lugar', 265697)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Lugares_Frecuentes_Probable_Responsable_Descripcion Descripcion').attr('id', 'Lugares_Frecuentes_Probable_Responsable_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Lugares_Frecuentes_Probable_ResponsableInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRLugares_Frecuentes_Probable_Responsable("Lugares_Frecuentes_Probable_Responsable_", "_" + rowIndex)) {
    var iPage = Lugares_Frecuentes_Probable_ResponsableTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Lugares_Frecuentes_Probable_Responsable';
    var prevData = Lugares_Frecuentes_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Lugares_Frecuentes_Probable_ResponsableTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Lugar:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Lugares_Frecuentes_Probable_ResponsableTable.fnUpdate(newData, rowIndex, null, true);
    Lugares_Frecuentes_Probable_ResponsablerowCreationGrid(data, newData, rowIndex);
    Lugares_Frecuentes_Probable_ResponsableTable.fnPageChange(iPage);
    Lugares_Frecuentes_Probable_ResponsablecountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRLugares_Frecuentes_Probable_Responsable("Lugares_Frecuentes_Probable_Responsable_", "_" + rowIndex);
  }
}

function Lugares_Frecuentes_Probable_ResponsableCancelRow(rowIndex) {
    var prevData = Lugares_Frecuentes_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Lugares_Frecuentes_Probable_ResponsableTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Lugares_Frecuentes_Probable_ResponsableTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Lugares_Frecuentes_Probable_ResponsablerowCreationGrid(data, prevData, rowIndex);
    }
	showLugares_Frecuentes_Probable_ResponsableGrid(Lugares_Frecuentes_Probable_ResponsableTable.fnGetData());
    Lugares_Frecuentes_Probable_ResponsablecountRowsChecked--;
	initiateUIControls();
}

function GetLugares_Frecuentes_Probable_ResponsableFromDataTable() {
    var Lugares_Frecuentes_Probable_ResponsableData = [];
    var gridData = Lugares_Frecuentes_Probable_ResponsableTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Lugares_Frecuentes_Probable_ResponsableData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Lugar: gridData[i].Tipo_de_Lugar
                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedLugares_Frecuentes_Probable_ResponsableData.length; i++) {
        if (removedLugares_Frecuentes_Probable_ResponsableData[i] != null && removedLugares_Frecuentes_Probable_ResponsableData[i].Clave > 0)
            Lugares_Frecuentes_Probable_ResponsableData.push({
                Clave: removedLugares_Frecuentes_Probable_ResponsableData[i].Clave

                ,Tipo_de_Lugar: removedLugares_Frecuentes_Probable_ResponsableData[i].Tipo_de_Lugar
                ,Descripcion: removedLugares_Frecuentes_Probable_ResponsableData[i].Descripcion

                , Removed: true
            });
    }	

    return Lugares_Frecuentes_Probable_ResponsableData;
}

function Lugares_Frecuentes_Probable_ResponsableEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Lugares_Frecuentes_Probable_ResponsableTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Lugares_Frecuentes_Probable_ResponsablecountRowsChecked++;
    var Lugares_Frecuentes_Probable_ResponsableRowElement = "Lugares_Frecuentes_Probable_Responsable_" + rowIndex.toString();
    var prevData = Lugares_Frecuentes_Probable_ResponsableTable.fnGetData(rowIndexTable );
    var row = Lugares_Frecuentes_Probable_ResponsableTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Lugares_Frecuentes_Probable_Responsable_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Lugares_Frecuentes_Probable_ResponsableGetUpdateRowControls(prevData, "Lugares_Frecuentes_Probable_Responsable_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Lugares_Frecuentes_Probable_ResponsableRowElement + "')){ Lugares_Frecuentes_Probable_ResponsableInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Lugares_Frecuentes_Probable_ResponsableCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Lugares_Frecuentes_Probable_ResponsableGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Lugares_Frecuentes_Probable_ResponsableGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setLugares_Frecuentes_Probable_ResponsableValidation();
    initiateUIControls();
    $('.Lugares_Frecuentes_Probable_Responsable' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndexFormed);
    }
}

function Lugares_Frecuentes_Probable_ResponsablefnOpenAddRowPopUp() {
    var currentRowIndex = Lugares_Frecuentes_Probable_ResponsableTable.fnGetData().length;
    Lugares_Frecuentes_Probable_ResponsablefnClickAddRow();
    GetAddLugares_Frecuentes_Probable_ResponsablePopup(currentRowIndex, 0);
}

function Lugares_Frecuentes_Probable_ResponsableEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Lugares_Frecuentes_Probable_ResponsableTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Lugares_Frecuentes_Probable_ResponsableRowElement = "Lugares_Frecuentes_Probable_Responsable_" + rowIndex.toString();
    var prevData = Lugares_Frecuentes_Probable_ResponsableTable.fnGetData(rowIndexTable);
    GetAddLugares_Frecuentes_Probable_ResponsablePopup(rowIndex, 1, prevData.Clave);

    $('#Lugares_Frecuentes_Probable_ResponsableTipo_de_Lugar').val(prevData.Tipo_de_Lugar);
    $('#Lugares_Frecuentes_Probable_ResponsableDescripcion').val(prevData.Descripcion);

    initiateUIControls();




}

function Lugares_Frecuentes_Probable_ResponsableAddInsertRow() {
    if (Lugares_Frecuentes_Probable_ResponsableinsertRowCurrentIndex < 1)
    {
        Lugares_Frecuentes_Probable_ResponsableinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Lugar: ""
        ,Descripcion: ""

    }
}

function Lugares_Frecuentes_Probable_ResponsablefnClickAddRow() {
    Lugares_Frecuentes_Probable_ResponsablecountRowsChecked++;
    Lugares_Frecuentes_Probable_ResponsableTable.fnAddData(Lugares_Frecuentes_Probable_ResponsableAddInsertRow(), true);
    Lugares_Frecuentes_Probable_ResponsableTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Lugares_Frecuentes_Probable_ResponsableGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Lugares_Frecuentes_Probable_ResponsableGrid tbody tr:nth-of-type(' + (Lugares_Frecuentes_Probable_ResponsableinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRLugares_Frecuentes_Probable_Responsable("Lugares_Frecuentes_Probable_Responsable_", "_" + Lugares_Frecuentes_Probable_ResponsableinsertRowCurrentIndex);
}

function Lugares_Frecuentes_Probable_ResponsableClearGridData() {
    Lugares_Frecuentes_Probable_ResponsableData = [];
    Lugares_Frecuentes_Probable_ResponsabledeletedItem = [];
    Lugares_Frecuentes_Probable_ResponsableDataMain = [];
    Lugares_Frecuentes_Probable_ResponsableDataMainPages = [];
    Lugares_Frecuentes_Probable_ResponsablenewItemCount = 0;
    Lugares_Frecuentes_Probable_ResponsablemaxItemIndex = 0;
    $("#Lugares_Frecuentes_Probable_ResponsableGrid").DataTable().clear();
    $("#Lugares_Frecuentes_Probable_ResponsableGrid").DataTable().destroy();
}

//Used to Get Probable Responsable Information
function GetLugares_Frecuentes_Probable_Responsable() {
    var form_data = new FormData();
    for (var i = 0; i < Lugares_Frecuentes_Probable_ResponsableData.length; i++) {
        form_data.append('[' + i + '].Clave', Lugares_Frecuentes_Probable_ResponsableData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Lugar', Lugares_Frecuentes_Probable_ResponsableData[i].Tipo_de_Lugar);
        form_data.append('[' + i + '].Descripcion', Lugares_Frecuentes_Probable_ResponsableData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Lugares_Frecuentes_Probable_ResponsableData[i].Removed);
    }
    return form_data;
}
function Lugares_Frecuentes_Probable_ResponsableInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRLugares_Frecuentes_Probable_Responsable("Lugares_Frecuentes_Probable_ResponsableTable", rowIndex)) {
    var prevData = Lugares_Frecuentes_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Lugares_Frecuentes_Probable_ResponsableTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Lugar: $('#Lugares_Frecuentes_Probable_ResponsableTipo_de_Lugar').val()
        ,Descripcion: $('#Lugares_Frecuentes_Probable_ResponsableDescripcion').val()

    }

    Lugares_Frecuentes_Probable_ResponsableTable.fnUpdate(newData, rowIndex, null, true);
    Lugares_Frecuentes_Probable_ResponsablerowCreationGrid(data, newData, rowIndex);
    $('#AddLugares_Frecuentes_Probable_Responsable-form').modal({ show: false });
    $('#AddLugares_Frecuentes_Probable_Responsable-form').modal('hide');
    Lugares_Frecuentes_Probable_ResponsableEditRow(rowIndex);
    Lugares_Frecuentes_Probable_ResponsableInsertRow(rowIndex);
    //}
}
function Lugares_Frecuentes_Probable_ResponsableRemoveAddRow(rowIndex) {
    Lugares_Frecuentes_Probable_ResponsableTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Lugares_Frecuentes_Probable_Responsable MultiRow
//Begin Declarations for Foreigns fields for Datos_Personales_Adicionales_Probable_Responsable MultiRow
var Datos_Personales_Adicionales_Probable_ResponsablecountRowsChecked = 0;



function GetDatos_Personales_Adicionales_Probable_Responsable_Redes_SocialesName(Id) {
    for (var i = 0; i < Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesItems.length; i++) {
        if (Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesItems[i].Clave == Id) {
            return Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesItems[i].Descripcion;
        }
    }
    return "";
}

function GetDatos_Personales_Adicionales_Probable_Responsable_Redes_SocialesDropDown() {
    var Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Datos_Personales_Adicionales_Probable_Responsable_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesDropdown);
    if(Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesItems != null)
    {
       for (var i = 0; i < Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesItems.length; i++) {
           $('<option />', { value: Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesItems[i].Clave, text:    Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesItems[i].Descripcion }).appendTo(Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesDropdown);
       }
    }
    return Datos_Personales_Adicionales_Probable_Responsable_Redes_SocialesDropdown;
}



function GetInsertDatos_Personales_Adicionales_Probable_ResponsableRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Datos_Personales_Adicionales_Probable_Responsable_Correo_Electronico Correo_Electronico').attr('id', 'Datos_Personales_Adicionales_Probable_Responsable_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');
    columnData[1] = $($.parseHTML(inputData)).addClass('Datos_Personales_Adicionales_Probable_Responsable_Numero_Telefonico Numero_Telefonico').attr('id', 'Datos_Personales_Adicionales_Probable_Responsable_Numero_Telefonico_' + index).attr('data-field', 'Numero_Telefonico');
    columnData[2] = $(GetDatos_Personales_Adicionales_Probable_Responsable_Redes_SocialesDropDown()).addClass('Datos_Personales_Adicionales_Probable_Responsable_Redes_Sociales Redes_Sociales').attr('id', 'Datos_Personales_Adicionales_Probable_Responsable_Redes_Sociales_' + index).attr('data-field', 'Redes_Sociales').after($.parseHTML(addNew('Datos_Personales_Adicionales_Probable_Responsable', 'Redes_Sociales', 'Redes_Sociales', 265703)));
    columnData[3] = $($.parseHTML(inputData)).addClass('Datos_Personales_Adicionales_Probable_Responsable_Observaciones Observaciones').attr('id', 'Datos_Personales_Adicionales_Probable_Responsable_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Datos_Personales_Adicionales_Probable_ResponsableInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDatos_Personales_Adicionales_Probable_Responsable("Datos_Personales_Adicionales_Probable_Responsable_", "_" + rowIndex)) {
    var iPage = Datos_Personales_Adicionales_Probable_ResponsableTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Datos_Personales_Adicionales_Probable_Responsable';
    var prevData = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Telefonico:  data.childNodes[counter++].childNodes[0].value
        ,Redes_Sociales:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Datos_Personales_Adicionales_Probable_ResponsableTable.fnUpdate(newData, rowIndex, null, true);
    Datos_Personales_Adicionales_Probable_ResponsablerowCreationGrid(data, newData, rowIndex);
    Datos_Personales_Adicionales_Probable_ResponsableTable.fnPageChange(iPage);
    Datos_Personales_Adicionales_Probable_ResponsablecountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDatos_Personales_Adicionales_Probable_Responsable("Datos_Personales_Adicionales_Probable_Responsable_", "_" + rowIndex);
  }
}

function Datos_Personales_Adicionales_Probable_ResponsableCancelRow(rowIndex) {
    var prevData = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Datos_Personales_Adicionales_Probable_ResponsableTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Datos_Personales_Adicionales_Probable_ResponsablerowCreationGrid(data, prevData, rowIndex);
    }
	showDatos_Personales_Adicionales_Probable_ResponsableGrid(Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetData());
    Datos_Personales_Adicionales_Probable_ResponsablecountRowsChecked--;
	initiateUIControls();
}

function GetDatos_Personales_Adicionales_Probable_ResponsableFromDataTable() {
    var Datos_Personales_Adicionales_Probable_ResponsableData = [];
    var gridData = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Datos_Personales_Adicionales_Probable_ResponsableData.push({
                Clave: gridData[i].Clave

                ,Correo_Electronico: gridData[i].Correo_Electronico
                ,Numero_Telefonico: gridData[i].Numero_Telefonico
                ,Redes_Sociales: gridData[i].Redes_Sociales
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDatos_Personales_Adicionales_Probable_ResponsableData.length; i++) {
        if (removedDatos_Personales_Adicionales_Probable_ResponsableData[i] != null && removedDatos_Personales_Adicionales_Probable_ResponsableData[i].Clave > 0)
            Datos_Personales_Adicionales_Probable_ResponsableData.push({
                Clave: removedDatos_Personales_Adicionales_Probable_ResponsableData[i].Clave

                ,Correo_Electronico: removedDatos_Personales_Adicionales_Probable_ResponsableData[i].Correo_Electronico
                ,Numero_Telefonico: removedDatos_Personales_Adicionales_Probable_ResponsableData[i].Numero_Telefonico
                ,Redes_Sociales: removedDatos_Personales_Adicionales_Probable_ResponsableData[i].Redes_Sociales
                ,Observaciones: removedDatos_Personales_Adicionales_Probable_ResponsableData[i].Observaciones

                , Removed: true
            });
    }	

    return Datos_Personales_Adicionales_Probable_ResponsableData;
}

function Datos_Personales_Adicionales_Probable_ResponsableEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Datos_Personales_Adicionales_Probable_ResponsablecountRowsChecked++;
    var Datos_Personales_Adicionales_Probable_ResponsableRowElement = "Datos_Personales_Adicionales_Probable_Responsable_" + rowIndex.toString();
    var prevData = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetData(rowIndexTable );
    var row = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Datos_Personales_Adicionales_Probable_Responsable_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Datos_Personales_Adicionales_Probable_ResponsableGetUpdateRowControls(prevData, "Datos_Personales_Adicionales_Probable_Responsable_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Datos_Personales_Adicionales_Probable_ResponsableRowElement + "')){ Datos_Personales_Adicionales_Probable_ResponsableInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Datos_Personales_Adicionales_Probable_ResponsableCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Datos_Personales_Adicionales_Probable_ResponsableGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Datos_Personales_Adicionales_Probable_ResponsableGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDatos_Personales_Adicionales_Probable_ResponsableValidation();
    initiateUIControls();
    $('.Datos_Personales_Adicionales_Probable_Responsable' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndexFormed);
    }
}

function Datos_Personales_Adicionales_Probable_ResponsablefnOpenAddRowPopUp() {
    var currentRowIndex = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetData().length;
    Datos_Personales_Adicionales_Probable_ResponsablefnClickAddRow();
    GetAddDatos_Personales_Adicionales_Probable_ResponsablePopup(currentRowIndex, 0);
}

function Datos_Personales_Adicionales_Probable_ResponsableEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Datos_Personales_Adicionales_Probable_ResponsableRowElement = "Datos_Personales_Adicionales_Probable_Responsable_" + rowIndex.toString();
    var prevData = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetData(rowIndexTable);
    GetAddDatos_Personales_Adicionales_Probable_ResponsablePopup(rowIndex, 1, prevData.Clave);

    $('#Datos_Personales_Adicionales_Probable_ResponsableCorreo_Electronico').val(prevData.Correo_Electronico);
    $('#Datos_Personales_Adicionales_Probable_ResponsableNumero_Telefonico').val(prevData.Numero_Telefonico);
    $('#Datos_Personales_Adicionales_Probable_ResponsableRedes_Sociales').val(prevData.Redes_Sociales);
    $('#Datos_Personales_Adicionales_Probable_ResponsableObservaciones').val(prevData.Observaciones);

    initiateUIControls();






}

function Datos_Personales_Adicionales_Probable_ResponsableAddInsertRow() {
    if (Datos_Personales_Adicionales_Probable_ResponsableinsertRowCurrentIndex < 1)
    {
        Datos_Personales_Adicionales_Probable_ResponsableinsertRowCurrentIndex = 1;
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

function Datos_Personales_Adicionales_Probable_ResponsablefnClickAddRow() {
    Datos_Personales_Adicionales_Probable_ResponsablecountRowsChecked++;
    Datos_Personales_Adicionales_Probable_ResponsableTable.fnAddData(Datos_Personales_Adicionales_Probable_ResponsableAddInsertRow(), true);
    Datos_Personales_Adicionales_Probable_ResponsableTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Datos_Personales_Adicionales_Probable_ResponsableGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Datos_Personales_Adicionales_Probable_ResponsableGrid tbody tr:nth-of-type(' + (Datos_Personales_Adicionales_Probable_ResponsableinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDatos_Personales_Adicionales_Probable_Responsable("Datos_Personales_Adicionales_Probable_Responsable_", "_" + Datos_Personales_Adicionales_Probable_ResponsableinsertRowCurrentIndex);
}

function Datos_Personales_Adicionales_Probable_ResponsableClearGridData() {
    Datos_Personales_Adicionales_Probable_ResponsableData = [];
    Datos_Personales_Adicionales_Probable_ResponsabledeletedItem = [];
    Datos_Personales_Adicionales_Probable_ResponsableDataMain = [];
    Datos_Personales_Adicionales_Probable_ResponsableDataMainPages = [];
    Datos_Personales_Adicionales_Probable_ResponsablenewItemCount = 0;
    Datos_Personales_Adicionales_Probable_ResponsablemaxItemIndex = 0;
    $("#Datos_Personales_Adicionales_Probable_ResponsableGrid").DataTable().clear();
    $("#Datos_Personales_Adicionales_Probable_ResponsableGrid").DataTable().destroy();
}

//Used to Get Probable Responsable Information
function GetDatos_Personales_Adicionales_Probable_Responsable() {
    var form_data = new FormData();
    for (var i = 0; i < Datos_Personales_Adicionales_Probable_ResponsableData.length; i++) {
        form_data.append('[' + i + '].Clave', Datos_Personales_Adicionales_Probable_ResponsableData[i].Clave);

        form_data.append('[' + i + '].Correo_Electronico', Datos_Personales_Adicionales_Probable_ResponsableData[i].Correo_Electronico);
        form_data.append('[' + i + '].Numero_Telefonico', Datos_Personales_Adicionales_Probable_ResponsableData[i].Numero_Telefonico);
        form_data.append('[' + i + '].Redes_Sociales', Datos_Personales_Adicionales_Probable_ResponsableData[i].Redes_Sociales);
        form_data.append('[' + i + '].Observaciones', Datos_Personales_Adicionales_Probable_ResponsableData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Datos_Personales_Adicionales_Probable_ResponsableData[i].Removed);
    }
    return form_data;
}
function Datos_Personales_Adicionales_Probable_ResponsableInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDatos_Personales_Adicionales_Probable_Responsable("Datos_Personales_Adicionales_Probable_ResponsableTable", rowIndex)) {
    var prevData = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Datos_Personales_Adicionales_Probable_ResponsableTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Correo_Electronico: $('#Datos_Personales_Adicionales_Probable_ResponsableCorreo_Electronico').val()
        ,Numero_Telefonico: $('#Datos_Personales_Adicionales_Probable_ResponsableNumero_Telefonico').val()
        ,Redes_Sociales: $('#Datos_Personales_Adicionales_Probable_ResponsableRedes_Sociales').val()
        ,Observaciones: $('#Datos_Personales_Adicionales_Probable_ResponsableObservaciones').val()

    }

    Datos_Personales_Adicionales_Probable_ResponsableTable.fnUpdate(newData, rowIndex, null, true);
    Datos_Personales_Adicionales_Probable_ResponsablerowCreationGrid(data, newData, rowIndex);
    $('#AddDatos_Personales_Adicionales_Probable_Responsable-form').modal({ show: false });
    $('#AddDatos_Personales_Adicionales_Probable_Responsable-form').modal('hide');
    Datos_Personales_Adicionales_Probable_ResponsableEditRow(rowIndex);
    Datos_Personales_Adicionales_Probable_ResponsableInsertRow(rowIndex);
    //}
}
function Datos_Personales_Adicionales_Probable_ResponsableRemoveAddRow(rowIndex) {
    Datos_Personales_Adicionales_Probable_ResponsableTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Datos_Personales_Adicionales_Probable_Responsable MultiRow
//Begin Declarations for Foreigns fields for Otras_Identificaciones_Probable_Responsable MultiRow
var Otras_Identificaciones_Probable_ResponsablecountRowsChecked = 0;

function GetOtras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionItems.length; i++) {
        if (Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetOtras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionDropDown() {
    var Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otras_Identificaciones_Probable_Responsable_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionDropdown);
    if(Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionItems[i].Clave, text:    Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionDropdown);
       }
    }
    return Otras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionDropdown;
}



function GetInsertOtras_Identificaciones_Probable_ResponsableRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetOtras_Identificaciones_Probable_Responsable_Tipo_de_IdentificacionDropDown()).addClass('Otras_Identificaciones_Probable_Responsable_Tipo_de_identificacion Tipo_de_identificacion').attr('id', 'Otras_Identificaciones_Probable_Responsable_Tipo_de_identificacion_' + index).attr('data-field', 'Tipo_de_identificacion').after($.parseHTML(addNew('Otras_Identificaciones_Probable_Responsable', 'Tipo_de_Identificacion', 'Tipo_de_identificacion', 265707)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Otras_Identificaciones_Probable_Responsable_Descripcion Descripcion').attr('id', 'Otras_Identificaciones_Probable_Responsable_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Otras_Identificaciones_Probable_ResponsableInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMROtras_Identificaciones_Probable_Responsable("Otras_Identificaciones_Probable_Responsable_", "_" + rowIndex)) {
    var iPage = Otras_Identificaciones_Probable_ResponsableTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Otras_Identificaciones_Probable_Responsable';
    var prevData = Otras_Identificaciones_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Otras_Identificaciones_Probable_ResponsableTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Otras_Identificaciones_Probable_ResponsableTable.fnUpdate(newData, rowIndex, null, true);
    Otras_Identificaciones_Probable_ResponsablerowCreationGrid(data, newData, rowIndex);
    Otras_Identificaciones_Probable_ResponsableTable.fnPageChange(iPage);
    Otras_Identificaciones_Probable_ResponsablecountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMROtras_Identificaciones_Probable_Responsable("Otras_Identificaciones_Probable_Responsable_", "_" + rowIndex);
  }
}

function Otras_Identificaciones_Probable_ResponsableCancelRow(rowIndex) {
    var prevData = Otras_Identificaciones_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Otras_Identificaciones_Probable_ResponsableTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Otras_Identificaciones_Probable_ResponsableTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Otras_Identificaciones_Probable_ResponsablerowCreationGrid(data, prevData, rowIndex);
    }
	showOtras_Identificaciones_Probable_ResponsableGrid(Otras_Identificaciones_Probable_ResponsableTable.fnGetData());
    Otras_Identificaciones_Probable_ResponsablecountRowsChecked--;
	initiateUIControls();
}

function GetOtras_Identificaciones_Probable_ResponsableFromDataTable() {
    var Otras_Identificaciones_Probable_ResponsableData = [];
    var gridData = Otras_Identificaciones_Probable_ResponsableTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Otras_Identificaciones_Probable_ResponsableData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_identificacion: gridData[i].Tipo_de_identificacion
                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedOtras_Identificaciones_Probable_ResponsableData.length; i++) {
        if (removedOtras_Identificaciones_Probable_ResponsableData[i] != null && removedOtras_Identificaciones_Probable_ResponsableData[i].Clave > 0)
            Otras_Identificaciones_Probable_ResponsableData.push({
                Clave: removedOtras_Identificaciones_Probable_ResponsableData[i].Clave

                ,Tipo_de_identificacion: removedOtras_Identificaciones_Probable_ResponsableData[i].Tipo_de_identificacion
                ,Descripcion: removedOtras_Identificaciones_Probable_ResponsableData[i].Descripcion

                , Removed: true
            });
    }	

    return Otras_Identificaciones_Probable_ResponsableData;
}

function Otras_Identificaciones_Probable_ResponsableEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Otras_Identificaciones_Probable_ResponsableTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Otras_Identificaciones_Probable_ResponsablecountRowsChecked++;
    var Otras_Identificaciones_Probable_ResponsableRowElement = "Otras_Identificaciones_Probable_Responsable_" + rowIndex.toString();
    var prevData = Otras_Identificaciones_Probable_ResponsableTable.fnGetData(rowIndexTable );
    var row = Otras_Identificaciones_Probable_ResponsableTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Otras_Identificaciones_Probable_Responsable_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Otras_Identificaciones_Probable_ResponsableGetUpdateRowControls(prevData, "Otras_Identificaciones_Probable_Responsable_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Otras_Identificaciones_Probable_ResponsableRowElement + "')){ Otras_Identificaciones_Probable_ResponsableInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Otras_Identificaciones_Probable_ResponsableCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Otras_Identificaciones_Probable_ResponsableGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Otras_Identificaciones_Probable_ResponsableGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setOtras_Identificaciones_Probable_ResponsableValidation();
    initiateUIControls();
    $('.Otras_Identificaciones_Probable_Responsable' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndexFormed);
    }
}

function Otras_Identificaciones_Probable_ResponsablefnOpenAddRowPopUp() {
    var currentRowIndex = Otras_Identificaciones_Probable_ResponsableTable.fnGetData().length;
    Otras_Identificaciones_Probable_ResponsablefnClickAddRow();
    GetAddOtras_Identificaciones_Probable_ResponsablePopup(currentRowIndex, 0);
}

function Otras_Identificaciones_Probable_ResponsableEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Otras_Identificaciones_Probable_ResponsableTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Otras_Identificaciones_Probable_ResponsableRowElement = "Otras_Identificaciones_Probable_Responsable_" + rowIndex.toString();
    var prevData = Otras_Identificaciones_Probable_ResponsableTable.fnGetData(rowIndexTable);
    GetAddOtras_Identificaciones_Probable_ResponsablePopup(rowIndex, 1, prevData.Clave);

    $('#Otras_Identificaciones_Probable_ResponsableTipo_de_identificacion').val(prevData.Tipo_de_identificacion);
    $('#Otras_Identificaciones_Probable_ResponsableDescripcion').val(prevData.Descripcion);

    initiateUIControls();




}

function Otras_Identificaciones_Probable_ResponsableAddInsertRow() {
    if (Otras_Identificaciones_Probable_ResponsableinsertRowCurrentIndex < 1)
    {
        Otras_Identificaciones_Probable_ResponsableinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_identificacion: ""
        ,Descripcion: ""

    }
}

function Otras_Identificaciones_Probable_ResponsablefnClickAddRow() {
    Otras_Identificaciones_Probable_ResponsablecountRowsChecked++;
    Otras_Identificaciones_Probable_ResponsableTable.fnAddData(Otras_Identificaciones_Probable_ResponsableAddInsertRow(), true);
    Otras_Identificaciones_Probable_ResponsableTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Otras_Identificaciones_Probable_ResponsableGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Otras_Identificaciones_Probable_ResponsableGrid tbody tr:nth-of-type(' + (Otras_Identificaciones_Probable_ResponsableinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMROtras_Identificaciones_Probable_Responsable("Otras_Identificaciones_Probable_Responsable_", "_" + Otras_Identificaciones_Probable_ResponsableinsertRowCurrentIndex);
}

function Otras_Identificaciones_Probable_ResponsableClearGridData() {
    Otras_Identificaciones_Probable_ResponsableData = [];
    Otras_Identificaciones_Probable_ResponsabledeletedItem = [];
    Otras_Identificaciones_Probable_ResponsableDataMain = [];
    Otras_Identificaciones_Probable_ResponsableDataMainPages = [];
    Otras_Identificaciones_Probable_ResponsablenewItemCount = 0;
    Otras_Identificaciones_Probable_ResponsablemaxItemIndex = 0;
    $("#Otras_Identificaciones_Probable_ResponsableGrid").DataTable().clear();
    $("#Otras_Identificaciones_Probable_ResponsableGrid").DataTable().destroy();
}

//Used to Get Probable Responsable Information
function GetOtras_Identificaciones_Probable_Responsable() {
    var form_data = new FormData();
    for (var i = 0; i < Otras_Identificaciones_Probable_ResponsableData.length; i++) {
        form_data.append('[' + i + '].Clave', Otras_Identificaciones_Probable_ResponsableData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_identificacion', Otras_Identificaciones_Probable_ResponsableData[i].Tipo_de_identificacion);
        form_data.append('[' + i + '].Descripcion', Otras_Identificaciones_Probable_ResponsableData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Otras_Identificaciones_Probable_ResponsableData[i].Removed);
    }
    return form_data;
}
function Otras_Identificaciones_Probable_ResponsableInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMROtras_Identificaciones_Probable_Responsable("Otras_Identificaciones_Probable_ResponsableTable", rowIndex)) {
    var prevData = Otras_Identificaciones_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Otras_Identificaciones_Probable_ResponsableTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_identificacion: $('#Otras_Identificaciones_Probable_ResponsableTipo_de_identificacion').val()
        ,Descripcion: $('#Otras_Identificaciones_Probable_ResponsableDescripcion').val()

    }

    Otras_Identificaciones_Probable_ResponsableTable.fnUpdate(newData, rowIndex, null, true);
    Otras_Identificaciones_Probable_ResponsablerowCreationGrid(data, newData, rowIndex);
    $('#AddOtras_Identificaciones_Probable_Responsable-form').modal({ show: false });
    $('#AddOtras_Identificaciones_Probable_Responsable-form').modal('hide');
    Otras_Identificaciones_Probable_ResponsableEditRow(rowIndex);
    Otras_Identificaciones_Probable_ResponsableInsertRow(rowIndex);
    //}
}
function Otras_Identificaciones_Probable_ResponsableRemoveAddRow(rowIndex) {
    Otras_Identificaciones_Probable_ResponsableTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Otras_Identificaciones_Probable_Responsable MultiRow
//Begin Declarations for Foreigns fields for Otros_Domicilios_Probable_Responsable MultiRow
var Otros_Domicilios_Probable_ResponsablecountRowsChecked = 0;

function GetOtros_Domicilios_Probable_Responsable_EstadoName(Id) {
    for (var i = 0; i < Otros_Domicilios_Probable_Responsable_EstadoItems.length; i++) {
        if (Otros_Domicilios_Probable_Responsable_EstadoItems[i].Clave == Id) {
            return Otros_Domicilios_Probable_Responsable_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Probable_Responsable_EstadoDropDown() {
    var Otros_Domicilios_Probable_Responsable_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Probable_Responsable_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Probable_Responsable_EstadoDropdown);

    for (var i = 0; i < Otros_Domicilios_Probable_Responsable_EstadoItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Probable_Responsable_EstadoItems[i].Clave, text: Otros_Domicilios_Probable_Responsable_EstadoItems[i].Nombre }).appendTo(Otros_Domicilios_Probable_Responsable_EstadoDropdown);
    }
    return Otros_Domicilios_Probable_Responsable_EstadoDropdown;
}
function GetOtros_Domicilios_Probable_Responsable_MunicipioName(Id) {
    for (var i = 0; i < Otros_Domicilios_Probable_Responsable_MunicipioItems.length; i++) {
        if (Otros_Domicilios_Probable_Responsable_MunicipioItems[i].Clave == Id) {
            return Otros_Domicilios_Probable_Responsable_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Probable_Responsable_MunicipioDropDown() {
    var Otros_Domicilios_Probable_Responsable_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Probable_Responsable_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Probable_Responsable_MunicipioDropdown);

    for (var i = 0; i < Otros_Domicilios_Probable_Responsable_MunicipioItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Probable_Responsable_MunicipioItems[i].Clave, text: Otros_Domicilios_Probable_Responsable_MunicipioItems[i].Nombre }).appendTo(Otros_Domicilios_Probable_Responsable_MunicipioDropdown);
    }
    return Otros_Domicilios_Probable_Responsable_MunicipioDropdown;
}
function GetOtros_Domicilios_Probable_Responsable_ColoniaName(Id) {
    for (var i = 0; i < Otros_Domicilios_Probable_Responsable_ColoniaItems.length; i++) {
        if (Otros_Domicilios_Probable_Responsable_ColoniaItems[i].Clave == Id) {
            return Otros_Domicilios_Probable_Responsable_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Probable_Responsable_ColoniaDropDown() {
    var Otros_Domicilios_Probable_Responsable_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Probable_Responsable_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Probable_Responsable_ColoniaDropdown);

    for (var i = 0; i < Otros_Domicilios_Probable_Responsable_ColoniaItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Probable_Responsable_ColoniaItems[i].Clave, text: Otros_Domicilios_Probable_Responsable_ColoniaItems[i].Nombre }).appendTo(Otros_Domicilios_Probable_Responsable_ColoniaDropdown);
    }
    return Otros_Domicilios_Probable_Responsable_ColoniaDropdown;
}
function GetOtros_Domicilios_Probable_Responsable_ColoniaName(Id) {
    for (var i = 0; i < Otros_Domicilios_Probable_Responsable_ColoniaItems.length; i++) {
        if (Otros_Domicilios_Probable_Responsable_ColoniaItems[i].Clave == Id) {
            return Otros_Domicilios_Probable_Responsable_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetOtros_Domicilios_Probable_Responsable_ColoniaDropDown() {
    var Otros_Domicilios_Probable_Responsable_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Otros_Domicilios_Probable_Responsable_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Otros_Domicilios_Probable_Responsable_ColoniaDropdown);

    for (var i = 0; i < Otros_Domicilios_Probable_Responsable_ColoniaItems.length; i++) {
        $('<option />', { value: Otros_Domicilios_Probable_Responsable_ColoniaItems[i].Clave, text: Otros_Domicilios_Probable_Responsable_ColoniaItems[i].Nombre }).appendTo(Otros_Domicilios_Probable_Responsable_ColoniaDropdown);
    }
    return Otros_Domicilios_Probable_Responsable_ColoniaDropdown;
}











function GetInsertOtros_Domicilios_Probable_ResponsableRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Probable_Responsable_Estado'))).addClass('Otros_Domicilios_Probable_Responsable_Estado Estado').attr('id', 'Otros_Domicilios_Probable_Responsable_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Otros_Domicilios_Probable_Responsable', 'Estado', 'Estado', 265675)));
    columnData[1] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Probable_Responsable_Municipio'))).addClass('Otros_Domicilios_Probable_Responsable_Municipio Municipio').attr('id', 'Otros_Domicilios_Probable_Responsable_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Otros_Domicilios_Probable_Responsable', 'Municipio', 'Municipio', 265676)));
    columnData[2] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Probable_Responsable_Poblacion'))).addClass('Otros_Domicilios_Probable_Responsable_Poblacion Poblacion').attr('id', 'Otros_Domicilios_Probable_Responsable_Poblacion_' + index).attr('data-field', 'Poblacion').after($.parseHTML(addNew('Otros_Domicilios_Probable_Responsable', 'Colonia', 'Poblacion', 265677)));
    columnData[3] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteOtros_Domicilios_Probable_Responsable_Colonia'))).addClass('Otros_Domicilios_Probable_Responsable_Colonia Colonia').attr('id', 'Otros_Domicilios_Probable_Responsable_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Otros_Domicilios_Probable_Responsable', 'Colonia', 'Colonia', 265678)));
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Otros_Domicilios_Probable_Responsable_Codigo_Postal Codigo_Postal').attr('id', 'Otros_Domicilios_Probable_Responsable_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[5] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Probable_Responsable_Calle Calle').attr('id', 'Otros_Domicilios_Probable_Responsable_Calle_' + index).attr('data-field', 'Calle');
    columnData[6] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Probable_Responsable_Entre_Calle Entre_Calle').attr('id', 'Otros_Domicilios_Probable_Responsable_Entre_Calle_' + index).attr('data-field', 'Entre_Calle');
    columnData[7] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Probable_Responsable_Y_Calle Y_Calle').attr('id', 'Otros_Domicilios_Probable_Responsable_Y_Calle_' + index).attr('data-field', 'Y_Calle');
    columnData[8] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Probable_Responsable_Numero_Exterior Numero_Exterior').attr('id', 'Otros_Domicilios_Probable_Responsable_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[9] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Probable_Responsable_Numero_Interior Numero_Interior').attr('id', 'Otros_Domicilios_Probable_Responsable_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[10] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Probable_Responsable_Coordenada_X Coordenada_X').attr('id', 'Otros_Domicilios_Probable_Responsable_Coordenada_X_' + index).attr('data-field', 'Coordenada_X');
    columnData[11] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Probable_Responsable_Coordenada_Y Coordenada_Y').attr('id', 'Otros_Domicilios_Probable_Responsable_Coordenada_Y_' + index).attr('data-field', 'Coordenada_Y');
    columnData[12] = $($.parseHTML(inputData)).addClass('Otros_Domicilios_Probable_Responsable_Observaciones Observaciones').attr('id', 'Otros_Domicilios_Probable_Responsable_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Otros_Domicilios_Probable_ResponsableInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMROtros_Domicilios_Probable_Responsable("Otros_Domicilios_Probable_Responsable_", "_" + rowIndex)) {
    var iPage = Otros_Domicilios_Probable_ResponsableTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Otros_Domicilios_Probable_Responsable';
    var prevData = Otros_Domicilios_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Otros_Domicilios_Probable_ResponsableTable.fnGetNodes(rowIndex);
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
    Otros_Domicilios_Probable_ResponsableTable.fnUpdate(newData, rowIndex, null, true);
    Otros_Domicilios_Probable_ResponsablerowCreationGrid(data, newData, rowIndex);
    Otros_Domicilios_Probable_ResponsableTable.fnPageChange(iPage);
    Otros_Domicilios_Probable_ResponsablecountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMROtros_Domicilios_Probable_Responsable("Otros_Domicilios_Probable_Responsable_", "_" + rowIndex);
  }
}

function Otros_Domicilios_Probable_ResponsableCancelRow(rowIndex) {
    var prevData = Otros_Domicilios_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Otros_Domicilios_Probable_ResponsableTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Otros_Domicilios_Probable_ResponsableTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Otros_Domicilios_Probable_ResponsablerowCreationGrid(data, prevData, rowIndex);
    }
	showOtros_Domicilios_Probable_ResponsableGrid(Otros_Domicilios_Probable_ResponsableTable.fnGetData());
    Otros_Domicilios_Probable_ResponsablecountRowsChecked--;
	initiateUIControls();
}

function Otros_Domicilios_Probable_ResponsableMapaRow(rowIndex) {
    debugger;
    $("#RowSelected").val(rowIndex);
    $("#RowSelected").text(rowIndex);
    $("#modalMapa2").click();

}
function GetOtros_Domicilios_Probable_ResponsableFromDataTable() {
    var Otros_Domicilios_Probable_ResponsableData = [];
    var gridData = Otros_Domicilios_Probable_ResponsableTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Otros_Domicilios_Probable_ResponsableData.push({
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

    for (i = 0; i < removedOtros_Domicilios_Probable_ResponsableData.length; i++) {
        if (removedOtros_Domicilios_Probable_ResponsableData[i] != null && removedOtros_Domicilios_Probable_ResponsableData[i].Clave > 0)
            Otros_Domicilios_Probable_ResponsableData.push({
                Clave: removedOtros_Domicilios_Probable_ResponsableData[i].Clave

                ,Estado: removedOtros_Domicilios_Probable_ResponsableData[i].Estado
                ,Municipio: removedOtros_Domicilios_Probable_ResponsableData[i].Municipio
                ,Poblacion: removedOtros_Domicilios_Probable_ResponsableData[i].Poblacion
                ,Colonia: removedOtros_Domicilios_Probable_ResponsableData[i].Colonia
                ,Codigo_Postal: removedOtros_Domicilios_Probable_ResponsableData[i].Codigo_Postal
                ,Calle: removedOtros_Domicilios_Probable_ResponsableData[i].Calle
                ,Entre_Calle: removedOtros_Domicilios_Probable_ResponsableData[i].Entre_Calle
                ,Y_Calle: removedOtros_Domicilios_Probable_ResponsableData[i].Y_Calle
                ,Numero_Exterior: removedOtros_Domicilios_Probable_ResponsableData[i].Numero_Exterior
                ,Numero_Interior: removedOtros_Domicilios_Probable_ResponsableData[i].Numero_Interior
                ,Coordenada_X: removedOtros_Domicilios_Probable_ResponsableData[i].Coordenada_X
                ,Coordenada_Y: removedOtros_Domicilios_Probable_ResponsableData[i].Coordenada_Y
                ,Observaciones: removedOtros_Domicilios_Probable_ResponsableData[i].Observaciones

                , Removed: true
            });
    }	

    return Otros_Domicilios_Probable_ResponsableData;
}

function Otros_Domicilios_Probable_ResponsableEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Otros_Domicilios_Probable_ResponsableTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Otros_Domicilios_Probable_ResponsablecountRowsChecked++;
    var Otros_Domicilios_Probable_ResponsableRowElement = "Otros_Domicilios_Probable_Responsable_" + rowIndex.toString();
    var prevData = Otros_Domicilios_Probable_ResponsableTable.fnGetData(rowIndexTable );
    var row = Otros_Domicilios_Probable_ResponsableTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Otros_Domicilios_Probable_Responsable_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Otros_Domicilios_Probable_ResponsableGetUpdateRowControls(prevData, "Otros_Domicilios_Probable_Responsable_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Otros_Domicilios_Probable_ResponsableRowElement + "')){ Otros_Domicilios_Probable_ResponsableInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Otros_Domicilios_Probable_ResponsableCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Otros_Domicilios_Probable_ResponsableGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Otros_Domicilios_Probable_ResponsableGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setOtros_Domicilios_Probable_ResponsableValidation();
    initiateUIControls();
    $('.Otros_Domicilios_Probable_Responsable' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndexFormed);
    }
}

function Otros_Domicilios_Probable_ResponsablefnOpenAddRowPopUp() {
    var currentRowIndex = Otros_Domicilios_Probable_ResponsableTable.fnGetData().length;
    Otros_Domicilios_Probable_ResponsablefnClickAddRow();
    GetAddOtros_Domicilios_Probable_ResponsablePopup(currentRowIndex, 0);
}

function Otros_Domicilios_Probable_ResponsableEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Otros_Domicilios_Probable_ResponsableTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Otros_Domicilios_Probable_ResponsableRowElement = "Otros_Domicilios_Probable_Responsable_" + rowIndex.toString();
    var prevData = Otros_Domicilios_Probable_ResponsableTable.fnGetData(rowIndexTable);
    GetAddOtros_Domicilios_Probable_ResponsablePopup(rowIndex, 1, prevData.Clave);

    $('#dvOtros_Domicilios_Probable_ResponsableEstado').html($($.parseHTML(GetGridAutoComplete(prevData.Estado.label,'AutoCompleteEstado'))).addClass('Otros_Domicilios_Probable_Responsable_Estado'));
    $('#dvOtros_Domicilios_Probable_ResponsableMunicipio').html($($.parseHTML(GetGridAutoComplete(prevData.Municipio.label,'AutoCompleteMunicipio'))).addClass('Otros_Domicilios_Probable_Responsable_Municipio'));
    $('#dvOtros_Domicilios_Probable_ResponsablePoblacion').html($($.parseHTML(GetGridAutoComplete(prevData.Poblacion.label,'AutoCompletePoblacion'))).addClass('Otros_Domicilios_Probable_Responsable_Poblacion'));
    $('#dvOtros_Domicilios_Probable_ResponsableColonia').html($($.parseHTML(GetGridAutoComplete(prevData.Colonia.label,'AutoCompleteColonia'))).addClass('Otros_Domicilios_Probable_Responsable_Colonia'));
    $('#Otros_Domicilios_Probable_ResponsableCodigo_Postal').val(prevData.Codigo_Postal);
    $('#Otros_Domicilios_Probable_ResponsableCalle').val(prevData.Calle);
    $('#Otros_Domicilios_Probable_ResponsableEntre_Calle').val(prevData.Entre_Calle);
    $('#Otros_Domicilios_Probable_ResponsableY_Calle').val(prevData.Y_Calle);
    $('#Otros_Domicilios_Probable_ResponsableNumero_Exterior').val(prevData.Numero_Exterior);
    $('#Otros_Domicilios_Probable_ResponsableNumero_Interior').val(prevData.Numero_Interior);
    $('#Otros_Domicilios_Probable_ResponsableCoordenada_X').val(prevData.Coordenada_X);
    $('#Otros_Domicilios_Probable_ResponsableCoordenada_Y').val(prevData.Coordenada_Y);
    $('#Otros_Domicilios_Probable_ResponsableObservaciones').val(prevData.Observaciones);

    initiateUIControls();















}

function Otros_Domicilios_Probable_ResponsableAddInsertRow() {
    if (Otros_Domicilios_Probable_ResponsableinsertRowCurrentIndex < 1)
    {
        Otros_Domicilios_Probable_ResponsableinsertRowCurrentIndex = 1;
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

function Otros_Domicilios_Probable_ResponsablefnClickAddRow() {
    Otros_Domicilios_Probable_ResponsablecountRowsChecked++;
    Otros_Domicilios_Probable_ResponsableTable.fnAddData(Otros_Domicilios_Probable_ResponsableAddInsertRow(), true);
    Otros_Domicilios_Probable_ResponsableTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Otros_Domicilios_Probable_ResponsableGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Otros_Domicilios_Probable_ResponsableGrid tbody tr:nth-of-type(' + (Otros_Domicilios_Probable_ResponsableinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMROtros_Domicilios_Probable_Responsable("Otros_Domicilios_Probable_Responsable_", "_" + Otros_Domicilios_Probable_ResponsableinsertRowCurrentIndex);
}

function Otros_Domicilios_Probable_ResponsableClearGridData() {
    Otros_Domicilios_Probable_ResponsableData = [];
    Otros_Domicilios_Probable_ResponsabledeletedItem = [];
    Otros_Domicilios_Probable_ResponsableDataMain = [];
    Otros_Domicilios_Probable_ResponsableDataMainPages = [];
    Otros_Domicilios_Probable_ResponsablenewItemCount = 0;
    Otros_Domicilios_Probable_ResponsablemaxItemIndex = 0;
    $("#Otros_Domicilios_Probable_ResponsableGrid").DataTable().clear();
    $("#Otros_Domicilios_Probable_ResponsableGrid").DataTable().destroy();
}

//Used to Get Probable Responsable Information
function GetOtros_Domicilios_Probable_Responsable() {
    var form_data = new FormData();
    for (var i = 0; i < Otros_Domicilios_Probable_ResponsableData.length; i++) {
        form_data.append('[' + i + '].Clave', Otros_Domicilios_Probable_ResponsableData[i].Clave);

        form_data.append('[' + i + '].Estado', Otros_Domicilios_Probable_ResponsableData[i].Estado);
        form_data.append('[' + i + '].Municipio', Otros_Domicilios_Probable_ResponsableData[i].Municipio);
        form_data.append('[' + i + '].Poblacion', Otros_Domicilios_Probable_ResponsableData[i].Poblacion);
        form_data.append('[' + i + '].Colonia', Otros_Domicilios_Probable_ResponsableData[i].Colonia);
        form_data.append('[' + i + '].Codigo_Postal', Otros_Domicilios_Probable_ResponsableData[i].Codigo_Postal);
        form_data.append('[' + i + '].Calle', Otros_Domicilios_Probable_ResponsableData[i].Calle);
        form_data.append('[' + i + '].Entre_Calle', Otros_Domicilios_Probable_ResponsableData[i].Entre_Calle);
        form_data.append('[' + i + '].Y_Calle', Otros_Domicilios_Probable_ResponsableData[i].Y_Calle);
        form_data.append('[' + i + '].Numero_Exterior', Otros_Domicilios_Probable_ResponsableData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Otros_Domicilios_Probable_ResponsableData[i].Numero_Interior);
        form_data.append('[' + i + '].Coordenada_X', Otros_Domicilios_Probable_ResponsableData[i].Coordenada_X);
        form_data.append('[' + i + '].Coordenada_Y', Otros_Domicilios_Probable_ResponsableData[i].Coordenada_Y);
        form_data.append('[' + i + '].Observaciones', Otros_Domicilios_Probable_ResponsableData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Otros_Domicilios_Probable_ResponsableData[i].Removed);
    }
    return form_data;
}
function Otros_Domicilios_Probable_ResponsableInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMROtros_Domicilios_Probable_Responsable("Otros_Domicilios_Probable_ResponsableTable", rowIndex)) {
    var prevData = Otros_Domicilios_Probable_ResponsableTable.fnGetData(rowIndex);
    var data = Otros_Domicilios_Probable_ResponsableTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Estado: $('#Otros_Domicilios_Probable_ResponsableEstado').val()
        ,Municipio: $('#Otros_Domicilios_Probable_ResponsableMunicipio').val()
        ,Poblacion: $('#Otros_Domicilios_Probable_ResponsablePoblacion').val()
        ,Colonia: $('#Otros_Domicilios_Probable_ResponsableColonia').val()
        ,Codigo_Postal: $('#Otros_Domicilios_Probable_ResponsableCodigo_Postal').val()

        ,Calle: $('#Otros_Domicilios_Probable_ResponsableCalle').val()
        ,Entre_Calle: $('#Otros_Domicilios_Probable_ResponsableEntre_Calle').val()
        ,Y_Calle: $('#Otros_Domicilios_Probable_ResponsableY_Calle').val()
        ,Numero_Exterior: $('#Otros_Domicilios_Probable_ResponsableNumero_Exterior').val()
        ,Numero_Interior: $('#Otros_Domicilios_Probable_ResponsableNumero_Interior').val()
        ,Coordenada_X: $('#Otros_Domicilios_Probable_ResponsableCoordenada_X').val()
        ,Coordenada_Y: $('#Otros_Domicilios_Probable_ResponsableCoordenada_Y').val()
        ,Observaciones: $('#Otros_Domicilios_Probable_ResponsableObservaciones').val()

    }

    Otros_Domicilios_Probable_ResponsableTable.fnUpdate(newData, rowIndex, null, true);
    Otros_Domicilios_Probable_ResponsablerowCreationGrid(data, newData, rowIndex);
    $('#AddOtros_Domicilios_Probable_Responsable-form').modal({ show: false });
    $('#AddOtros_Domicilios_Probable_Responsable-form').modal('hide');
    Otros_Domicilios_Probable_ResponsableEditRow(rowIndex);
    Otros_Domicilios_Probable_ResponsableInsertRow(rowIndex);
    //}
}
function Otros_Domicilios_Probable_ResponsableRemoveAddRow(rowIndex) {
    Otros_Domicilios_Probable_ResponsableTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Otros_Domicilios_Probable_Responsable MultiRow
//Begin Declarations for Foreigns fields for Otros_Nombres MultiRow
var Otros_NombrescountRowsChecked = 0;






function GetInsertOtros_NombresRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Otros_Nombres_Nombres Nombres').attr('id', 'Otros_Nombres_Nombres_' + index).attr('data-field', 'Nombres');
    columnData[1] = $($.parseHTML(inputData)).addClass('Otros_Nombres_Apellido_Paterno Apellido_Paterno').attr('id', 'Otros_Nombres_Apellido_Paterno_' + index).attr('data-field', 'Apellido_Paterno');
    columnData[2] = $($.parseHTML(inputData)).addClass('Otros_Nombres_Apellido_Materno Apellido_Materno').attr('id', 'Otros_Nombres_Apellido_Materno_' + index).attr('data-field', 'Apellido_Materno');


    initiateUIControls();
    return columnData;
}

function Otros_NombresInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMROtros_Nombres("Otros_Nombres_", "_" + rowIndex)) {
    var iPage = Otros_NombresTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Otros_Nombres';
    var prevData = Otros_NombresTable.fnGetData(rowIndex);
    var data = Otros_NombresTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombres:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno:  data.childNodes[counter++].childNodes[0].value

    }
    Otros_NombresTable.fnUpdate(newData, rowIndex, null, true);
    Otros_NombresrowCreationGrid(data, newData, rowIndex);
    Otros_NombresTable.fnPageChange(iPage);
    Otros_NombrescountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMROtros_Nombres("Otros_Nombres_", "_" + rowIndex);
  }
}

function Otros_NombresCancelRow(rowIndex) {
    var prevData = Otros_NombresTable.fnGetData(rowIndex);
    var data = Otros_NombresTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Otros_NombresTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Otros_NombresrowCreationGrid(data, prevData, rowIndex);
    }
	showOtros_NombresGrid(Otros_NombresTable.fnGetData());
    Otros_NombrescountRowsChecked--;
	initiateUIControls();
}

function GetOtros_NombresFromDataTable() {
    var Otros_NombresData = [];
    var gridData = Otros_NombresTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Otros_NombresData.push({
                Clave: gridData[i].Clave

                ,Nombres: gridData[i].Nombres
                ,Apellido_Paterno: gridData[i].Apellido_Paterno
                ,Apellido_Materno: gridData[i].Apellido_Materno

                ,Removed: false
            });
    }

    for (i = 0; i < removedOtros_NombresData.length; i++) {
        if (removedOtros_NombresData[i] != null && removedOtros_NombresData[i].Clave > 0)
            Otros_NombresData.push({
                Clave: removedOtros_NombresData[i].Clave

                ,Nombres: removedOtros_NombresData[i].Nombres
                ,Apellido_Paterno: removedOtros_NombresData[i].Apellido_Paterno
                ,Apellido_Materno: removedOtros_NombresData[i].Apellido_Materno

                , Removed: true
            });
    }	

    return Otros_NombresData;
}

function Otros_NombresEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Otros_NombresTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Otros_NombrescountRowsChecked++;
    var Otros_NombresRowElement = "Otros_Nombres_" + rowIndex.toString();
    var prevData = Otros_NombresTable.fnGetData(rowIndexTable );
    var row = Otros_NombresTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Otros_Nombres_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Otros_NombresGetUpdateRowControls(prevData, "Otros_Nombres_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Otros_NombresRowElement + "')){ Otros_NombresInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Otros_NombresCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Otros_NombresGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Otros_NombresGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setOtros_NombresValidation();
    initiateUIControls();
    $('.Otros_Nombres' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMROtros_Nombres(nameOfTable, rowIndexFormed);
    }
}

function Otros_NombresfnOpenAddRowPopUp() {
    var currentRowIndex = Otros_NombresTable.fnGetData().length;
    Otros_NombresfnClickAddRow();
    GetAddOtros_NombresPopup(currentRowIndex, 0);
}

function Otros_NombresEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Otros_NombresTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Otros_NombresRowElement = "Otros_Nombres_" + rowIndex.toString();
    var prevData = Otros_NombresTable.fnGetData(rowIndexTable);
    GetAddOtros_NombresPopup(rowIndex, 1, prevData.Clave);

    $('#Otros_NombresNombres').val(prevData.Nombres);
    $('#Otros_NombresApellido_Paterno').val(prevData.Apellido_Paterno);
    $('#Otros_NombresApellido_Materno').val(prevData.Apellido_Materno);

    initiateUIControls();





}

function Otros_NombresAddInsertRow() {
    if (Otros_NombresinsertRowCurrentIndex < 1)
    {
        Otros_NombresinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombres: ""
        ,Apellido_Paterno: ""
        ,Apellido_Materno: ""

    }
}

function Otros_NombresfnClickAddRow() {
    Otros_NombrescountRowsChecked++;
    Otros_NombresTable.fnAddData(Otros_NombresAddInsertRow(), true);
    Otros_NombresTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Otros_NombresGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Otros_NombresGrid tbody tr:nth-of-type(' + (Otros_NombresinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMROtros_Nombres("Otros_Nombres_", "_" + Otros_NombresinsertRowCurrentIndex);
}

function Otros_NombresClearGridData() {
    Otros_NombresData = [];
    Otros_NombresdeletedItem = [];
    Otros_NombresDataMain = [];
    Otros_NombresDataMainPages = [];
    Otros_NombresnewItemCount = 0;
    Otros_NombresmaxItemIndex = 0;
    $("#Otros_NombresGrid").DataTable().clear();
    $("#Otros_NombresGrid").DataTable().destroy();
}

//Used to Get Probable Responsable Information
function GetOtros_Nombres() {
    var form_data = new FormData();
    for (var i = 0; i < Otros_NombresData.length; i++) {
        form_data.append('[' + i + '].Clave', Otros_NombresData[i].Clave);

        form_data.append('[' + i + '].Nombres', Otros_NombresData[i].Nombres);
        form_data.append('[' + i + '].Apellido_Paterno', Otros_NombresData[i].Apellido_Paterno);
        form_data.append('[' + i + '].Apellido_Materno', Otros_NombresData[i].Apellido_Materno);

        form_data.append('[' + i + '].Removed', Otros_NombresData[i].Removed);
    }
    return form_data;
}
function Otros_NombresInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMROtros_Nombres("Otros_NombresTable", rowIndex)) {
    var prevData = Otros_NombresTable.fnGetData(rowIndex);
    var data = Otros_NombresTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombres: $('#Otros_NombresNombres').val()
        ,Apellido_Paterno: $('#Otros_NombresApellido_Paterno').val()
        ,Apellido_Materno: $('#Otros_NombresApellido_Materno').val()

    }

    Otros_NombresTable.fnUpdate(newData, rowIndex, null, true);
    Otros_NombresrowCreationGrid(data, newData, rowIndex);
    $('#AddOtros_Nombres-form').modal({ show: false });
    $('#AddOtros_Nombres-form').modal('hide');
    Otros_NombresEditRow(rowIndex);
    Otros_NombresInsertRow(rowIndex);
    //}
}
function Otros_NombresRemoveAddRow(rowIndex) {
    Otros_NombresTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Otros_Nombres MultiRow


$(function () {
    function Lugar_de_DetencioninitializeMainArray(totalCount) {
        if (Lugar_de_DetencionDataMain.length != totalCount && !Lugar_de_DetencionDataMainInitialized) {
            Lugar_de_DetencionDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Lugar_de_DetencionDataMain[i] = null;
            }
        }
    }
    function Lugar_de_DetencionremoveFromMainArray() {
        for (var j = 0; j < Lugar_de_DetenciondeletedItem.length; j++) {
            for (var i = 0; i < Lugar_de_DetencionDataMain.length; i++) {
                if (Lugar_de_DetencionDataMain[i] != null && Lugar_de_DetencionDataMain[i].Id == Lugar_de_DetenciondeletedItem[j]) {
                    hLugar_de_DetencionDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Lugar_de_DetencioncopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Lugar_de_DetencionDataMain.length; i++) {
            data[i] = Lugar_de_DetencionDataMain[i];

        }
        return data;
    }
    function Lugar_de_DetenciongetNewResult() {
        var newData = copyMainLugar_de_DetencionArray();

        for (var i = 0; i < Lugar_de_DetencionData.length; i++) {
            if (Lugar_de_DetencionData[i].Removed == null || Lugar_de_DetencionData[i].Removed == false) {
                newData.splice(0, 0, Lugar_de_DetencionData[i]);
            }
        }
        return newData;
    }
    function Lugar_de_DetencionpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Lugar_de_DetencionDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Lugar_de_DetencionDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Adicciones_Probable_ResponsableinitializeMainArray(totalCount) {
        if (Adicciones_Probable_ResponsableDataMain.length != totalCount && !Adicciones_Probable_ResponsableDataMainInitialized) {
            Adicciones_Probable_ResponsableDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Adicciones_Probable_ResponsableDataMain[i] = null;
            }
        }
    }
    function Adicciones_Probable_ResponsableremoveFromMainArray() {
        for (var j = 0; j < Adicciones_Probable_ResponsabledeletedItem.length; j++) {
            for (var i = 0; i < Adicciones_Probable_ResponsableDataMain.length; i++) {
                if (Adicciones_Probable_ResponsableDataMain[i] != null && Adicciones_Probable_ResponsableDataMain[i].Id == Adicciones_Probable_ResponsabledeletedItem[j]) {
                    hAdicciones_Probable_ResponsableDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Adicciones_Probable_ResponsablecopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Adicciones_Probable_ResponsableDataMain.length; i++) {
            data[i] = Adicciones_Probable_ResponsableDataMain[i];

        }
        return data;
    }
    function Adicciones_Probable_ResponsablegetNewResult() {
        var newData = copyMainAdicciones_Probable_ResponsableArray();

        for (var i = 0; i < Adicciones_Probable_ResponsableData.length; i++) {
            if (Adicciones_Probable_ResponsableData[i].Removed == null || Adicciones_Probable_ResponsableData[i].Removed == false) {
                newData.splice(0, 0, Adicciones_Probable_ResponsableData[i]);
            }
        }
        return newData;
    }
    function Adicciones_Probable_ResponsablepushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Adicciones_Probable_ResponsableDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Adicciones_Probable_ResponsableDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Lugares_Frecuentes_Probable_ResponsableinitializeMainArray(totalCount) {
        if (Lugares_Frecuentes_Probable_ResponsableDataMain.length != totalCount && !Lugares_Frecuentes_Probable_ResponsableDataMainInitialized) {
            Lugares_Frecuentes_Probable_ResponsableDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Lugares_Frecuentes_Probable_ResponsableDataMain[i] = null;
            }
        }
    }
    function Lugares_Frecuentes_Probable_ResponsableremoveFromMainArray() {
        for (var j = 0; j < Lugares_Frecuentes_Probable_ResponsabledeletedItem.length; j++) {
            for (var i = 0; i < Lugares_Frecuentes_Probable_ResponsableDataMain.length; i++) {
                if (Lugares_Frecuentes_Probable_ResponsableDataMain[i] != null && Lugares_Frecuentes_Probable_ResponsableDataMain[i].Id == Lugares_Frecuentes_Probable_ResponsabledeletedItem[j]) {
                    hLugares_Frecuentes_Probable_ResponsableDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Lugares_Frecuentes_Probable_ResponsablecopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Lugares_Frecuentes_Probable_ResponsableDataMain.length; i++) {
            data[i] = Lugares_Frecuentes_Probable_ResponsableDataMain[i];

        }
        return data;
    }
    function Lugares_Frecuentes_Probable_ResponsablegetNewResult() {
        var newData = copyMainLugares_Frecuentes_Probable_ResponsableArray();

        for (var i = 0; i < Lugares_Frecuentes_Probable_ResponsableData.length; i++) {
            if (Lugares_Frecuentes_Probable_ResponsableData[i].Removed == null || Lugares_Frecuentes_Probable_ResponsableData[i].Removed == false) {
                newData.splice(0, 0, Lugares_Frecuentes_Probable_ResponsableData[i]);
            }
        }
        return newData;
    }
    function Lugares_Frecuentes_Probable_ResponsablepushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Lugares_Frecuentes_Probable_ResponsableDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Lugares_Frecuentes_Probable_ResponsableDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Datos_Personales_Adicionales_Probable_ResponsableinitializeMainArray(totalCount) {
        if (Datos_Personales_Adicionales_Probable_ResponsableDataMain.length != totalCount && !Datos_Personales_Adicionales_Probable_ResponsableDataMainInitialized) {
            Datos_Personales_Adicionales_Probable_ResponsableDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Datos_Personales_Adicionales_Probable_ResponsableDataMain[i] = null;
            }
        }
    }
    function Datos_Personales_Adicionales_Probable_ResponsableremoveFromMainArray() {
        for (var j = 0; j < Datos_Personales_Adicionales_Probable_ResponsabledeletedItem.length; j++) {
            for (var i = 0; i < Datos_Personales_Adicionales_Probable_ResponsableDataMain.length; i++) {
                if (Datos_Personales_Adicionales_Probable_ResponsableDataMain[i] != null && Datos_Personales_Adicionales_Probable_ResponsableDataMain[i].Id == Datos_Personales_Adicionales_Probable_ResponsabledeletedItem[j]) {
                    hDatos_Personales_Adicionales_Probable_ResponsableDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Datos_Personales_Adicionales_Probable_ResponsablecopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Datos_Personales_Adicionales_Probable_ResponsableDataMain.length; i++) {
            data[i] = Datos_Personales_Adicionales_Probable_ResponsableDataMain[i];

        }
        return data;
    }
    function Datos_Personales_Adicionales_Probable_ResponsablegetNewResult() {
        var newData = copyMainDatos_Personales_Adicionales_Probable_ResponsableArray();

        for (var i = 0; i < Datos_Personales_Adicionales_Probable_ResponsableData.length; i++) {
            if (Datos_Personales_Adicionales_Probable_ResponsableData[i].Removed == null || Datos_Personales_Adicionales_Probable_ResponsableData[i].Removed == false) {
                newData.splice(0, 0, Datos_Personales_Adicionales_Probable_ResponsableData[i]);
            }
        }
        return newData;
    }
    function Datos_Personales_Adicionales_Probable_ResponsablepushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Datos_Personales_Adicionales_Probable_ResponsableDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Datos_Personales_Adicionales_Probable_ResponsableDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Otras_Identificaciones_Probable_ResponsableinitializeMainArray(totalCount) {
        if (Otras_Identificaciones_Probable_ResponsableDataMain.length != totalCount && !Otras_Identificaciones_Probable_ResponsableDataMainInitialized) {
            Otras_Identificaciones_Probable_ResponsableDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Otras_Identificaciones_Probable_ResponsableDataMain[i] = null;
            }
        }
    }
    function Otras_Identificaciones_Probable_ResponsableremoveFromMainArray() {
        for (var j = 0; j < Otras_Identificaciones_Probable_ResponsabledeletedItem.length; j++) {
            for (var i = 0; i < Otras_Identificaciones_Probable_ResponsableDataMain.length; i++) {
                if (Otras_Identificaciones_Probable_ResponsableDataMain[i] != null && Otras_Identificaciones_Probable_ResponsableDataMain[i].Id == Otras_Identificaciones_Probable_ResponsabledeletedItem[j]) {
                    hOtras_Identificaciones_Probable_ResponsableDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Otras_Identificaciones_Probable_ResponsablecopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Otras_Identificaciones_Probable_ResponsableDataMain.length; i++) {
            data[i] = Otras_Identificaciones_Probable_ResponsableDataMain[i];

        }
        return data;
    }
    function Otras_Identificaciones_Probable_ResponsablegetNewResult() {
        var newData = copyMainOtras_Identificaciones_Probable_ResponsableArray();

        for (var i = 0; i < Otras_Identificaciones_Probable_ResponsableData.length; i++) {
            if (Otras_Identificaciones_Probable_ResponsableData[i].Removed == null || Otras_Identificaciones_Probable_ResponsableData[i].Removed == false) {
                newData.splice(0, 0, Otras_Identificaciones_Probable_ResponsableData[i]);
            }
        }
        return newData;
    }
    function Otras_Identificaciones_Probable_ResponsablepushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Otras_Identificaciones_Probable_ResponsableDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Otras_Identificaciones_Probable_ResponsableDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Otros_Domicilios_Probable_ResponsableinitializeMainArray(totalCount) {
        if (Otros_Domicilios_Probable_ResponsableDataMain.length != totalCount && !Otros_Domicilios_Probable_ResponsableDataMainInitialized) {
            Otros_Domicilios_Probable_ResponsableDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Otros_Domicilios_Probable_ResponsableDataMain[i] = null;
            }
        }
    }
    function Otros_Domicilios_Probable_ResponsableremoveFromMainArray() {
        for (var j = 0; j < Otros_Domicilios_Probable_ResponsabledeletedItem.length; j++) {
            for (var i = 0; i < Otros_Domicilios_Probable_ResponsableDataMain.length; i++) {
                if (Otros_Domicilios_Probable_ResponsableDataMain[i] != null && Otros_Domicilios_Probable_ResponsableDataMain[i].Id == Otros_Domicilios_Probable_ResponsabledeletedItem[j]) {
                    hOtros_Domicilios_Probable_ResponsableDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Otros_Domicilios_Probable_ResponsablecopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Otros_Domicilios_Probable_ResponsableDataMain.length; i++) {
            data[i] = Otros_Domicilios_Probable_ResponsableDataMain[i];

        }
        return data;
    }
    function Otros_Domicilios_Probable_ResponsablegetNewResult() {
        var newData = copyMainOtros_Domicilios_Probable_ResponsableArray();

        for (var i = 0; i < Otros_Domicilios_Probable_ResponsableData.length; i++) {
            if (Otros_Domicilios_Probable_ResponsableData[i].Removed == null || Otros_Domicilios_Probable_ResponsableData[i].Removed == false) {
                newData.splice(0, 0, Otros_Domicilios_Probable_ResponsableData[i]);
            }
        }
        return newData;
    }
    function Otros_Domicilios_Probable_ResponsablepushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Otros_Domicilios_Probable_ResponsableDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Otros_Domicilios_Probable_ResponsableDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Otros_NombresinitializeMainArray(totalCount) {
        if (Otros_NombresDataMain.length != totalCount && !Otros_NombresDataMainInitialized) {
            Otros_NombresDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Otros_NombresDataMain[i] = null;
            }
        }
    }
    function Otros_NombresremoveFromMainArray() {
        for (var j = 0; j < Otros_NombresdeletedItem.length; j++) {
            for (var i = 0; i < Otros_NombresDataMain.length; i++) {
                if (Otros_NombresDataMain[i] != null && Otros_NombresDataMain[i].Id == Otros_NombresdeletedItem[j]) {
                    hOtros_NombresDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Otros_NombrescopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Otros_NombresDataMain.length; i++) {
            data[i] = Otros_NombresDataMain[i];

        }
        return data;
    }
    function Otros_NombresgetNewResult() {
        var newData = copyMainOtros_NombresArray();

        for (var i = 0; i < Otros_NombresData.length; i++) {
            if (Otros_NombresData[i].Removed == null || Otros_NombresData[i].Removed == false) {
                newData.splice(0, 0, Otros_NombresData[i]);
            }
        }
        return newData;
    }
    function Otros_NombrespushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Otros_NombresDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Otros_NombresDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteModulo_Atencion_InicialData = [];
function GetAutoCompleteDetalle_de_Imputado_Modulo_Atencion_Inicial_Modulo_Atencion_InicialData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Expediente_MP_expediente_ministerio_publicoData(data) {
	AutoCompleteExpediente_MPData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MPData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteExpediente_MPData;
}
var AutoCompleteExpediente_MASCData = [];
function GetAutoCompleteDetalle_de_Imputado_Expediente_MASC_SolicitudData(data) {
	AutoCompleteExpediente_MASCData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MASCData.push({
            id: data[i].Clave,
            text: data[i].Numero_de_Folio
        });
    }
    return AutoCompleteExpediente_MASCData;
}
//Grid GetAutocomplete
var AutoCompleteMunicipio_de_DetencionData = [];
function GetAutoCompleteLugar_de_Detencion_Municipio_de_Detencion_MunicipioData(data) {
	AutoCompleteMunicipio_de_DetencionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_de_DetencionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_de_DetencionData;
}

var AutoCompletePais_de_NacimientoData = [];
function GetAutoCompleteDetalle_de_Imputado_Pais_de_Nacimiento_PaisData(data) {
	AutoCompletePais_de_NacimientoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_de_NacimientoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_de_NacimientoData;
}
var AutoCompleteEstado_de_NacimientoData = [];
function GetAutoCompleteDetalle_de_Imputado_Estado_de_Nacimiento_EstadoData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Municipio_de_Nacimiento_MunicipioData(data) {
	AutoCompleteMunicipio_de_NacimientoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_de_NacimientoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_de_NacimientoData;
}
var AutoCompletePaisData = [];
function GetAutoCompleteDetalle_de_Imputado_Pais_PaisData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Estado_EstadoData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Municipio_MunicipioData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Poblacion_ColoniaData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Colonia_ColoniaData(data) {
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

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete
var AutoCompleteEstadoData = [];
function GetAutoCompleteOtros_Domicilios_Probable_Responsable_Estado_EstadoData(data) {
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
function GetAutoCompleteOtros_Domicilios_Probable_Responsable_Municipio_MunicipioData(data) {
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
function GetAutoCompleteOtros_Domicilios_Probable_Responsable_Poblacion_ColoniaData(data) {
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
function GetAutoCompleteOtros_Domicilios_Probable_Responsable_Colonia_ColoniaData(data) {
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

var AutoCompletePais_del_hechoData = [];
function GetAutoCompleteDetalle_de_Imputado_Pais_del_hecho_PaisData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Estado_del_Hecho_EstadoData(data) {
	AutoCompleteEstado_del_HechoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_del_HechoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_del_HechoData;
}
var AutoCompleteMunicipio_del_HechoData = [];
function GetAutoCompleteDetalle_de_Imputado_Municipio_del_Hecho_MunicipioData(data) {
	AutoCompleteMunicipio_del_HechoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_del_HechoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_del_HechoData;
}
var AutoCompletePoblacion_HechosData = [];
function GetAutoCompleteDetalle_de_Imputado_Poblacion_Hechos_ColoniaData(data) {
	AutoCompletePoblacion_HechosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePoblacion_HechosData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePoblacion_HechosData;
}
var AutoCompleteColonia_del_hechoData = [];
function GetAutoCompleteDetalle_de_Imputado_Colonia_del_hecho_ColoniaData(data) {
	AutoCompleteColonia_del_hechoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_del_hechoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_del_hechoData;
}
var AutoCompletePais_de_Origen_tutorData = [];
function GetAutoCompleteDetalle_de_Imputado_Pais_de_Origen_tutor_PaisData(data) {
	AutoCompletePais_de_Origen_tutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_de_Origen_tutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_de_Origen_tutorData;
}
var AutoCompletePais_del_TutorData = [];
function GetAutoCompleteDetalle_de_Imputado_Pais_del_Tutor_PaisData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Estado_del_Tutor_EstadoData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Municipio_del_Tutor_MunicipioData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Poblacion_Tutor_ColoniaData(data) {
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
function GetAutoCompleteDetalle_de_Imputado_Colonia_del_Tutor_ColoniaData(data) {
	AutoCompleteColonia_del_TutorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_del_TutorData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_del_TutorData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Imputado_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Imputado')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Modulo_Atencion_Inicial').empty();
    $("#Modulo_Atencion_Inicial").append('<option value=""></option>');
    $('#Modulo_Atencion_Inicial').val('0').trigger('change');
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Expediente_MASC').empty();
    $("#Expediente_MASC").append('<option value=""></option>');
    $('#Expediente_MASC').val('0').trigger('change');
                Lugar_de_DetencionClearGridData();
    $('#Pais_de_Nacimiento').empty();
    $("#Pais_de_Nacimiento").append('<option value=""></option>');
    $('#Pais_de_Nacimiento').val('0').trigger('change');
    $('#Estado_de_Nacimiento').empty();
    $("#Estado_de_Nacimiento").append('<option value=""></option>');
    $('#Estado_de_Nacimiento').val('0').trigger('change');
    $('#Municipio_de_Nacimiento').empty();
    $("#Municipio_de_Nacimiento").append('<option value=""></option>');
    $('#Municipio_de_Nacimiento').val('0').trigger('change');
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
                Adicciones_Probable_ResponsableClearGridData();
                Lugares_Frecuentes_Probable_ResponsableClearGridData();
                Datos_Personales_Adicionales_Probable_ResponsableClearGridData();
                Otras_Identificaciones_Probable_ResponsableClearGridData();
                Otros_Domicilios_Probable_ResponsableClearGridData();
                Otros_NombresClearGridData();
    $('#Pais_del_hecho').empty();
    $("#Pais_del_hecho").append('<option value=""></option>');
    $('#Pais_del_hecho').val('0').trigger('change');
    $('#Estado_del_Hecho').empty();
    $("#Estado_del_Hecho").append('<option value=""></option>');
    $('#Estado_del_Hecho').val('0').trigger('change');
    $('#Municipio_del_Hecho').empty();
    $("#Municipio_del_Hecho").append('<option value=""></option>');
    $('#Municipio_del_Hecho').val('0').trigger('change');
    $('#Poblacion_Hechos').empty();
    $("#Poblacion_Hechos").append('<option value=""></option>');
    $('#Poblacion_Hechos').val('0').trigger('change');
    $('#Colonia_del_hecho').empty();
    $("#Colonia_del_hecho").append('<option value=""></option>');
    $('#Colonia_del_hecho').val('0').trigger('change');
    $('#Pais_de_Origen_tutor').empty();
    $("#Pais_de_Origen_tutor").append('<option value=""></option>');
    $('#Pais_de_Origen_tutor').val('0').trigger('change');
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

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Imputado').trigger('reset');
    $('#CreateDetalle_de_Imputado').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Imputado');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Lugar_de_DetencioncountRowsChecked > 0)
    {
        ShowMessagePendingRowLugar_de_Detencion();
        return false;
    }
    if (Adicciones_Probable_ResponsablecountRowsChecked > 0)
    {
        ShowMessagePendingRowAdicciones_Probable_Responsable();
        return false;
    }
    if (Lugares_Frecuentes_Probable_ResponsablecountRowsChecked > 0)
    {
        ShowMessagePendingRowLugares_Frecuentes_Probable_Responsable();
        return false;
    }
    if (Datos_Personales_Adicionales_Probable_ResponsablecountRowsChecked > 0)
    {
        ShowMessagePendingRowDatos_Personales_Adicionales_Probable_Responsable();
        return false;
    }
    if (Otras_Identificaciones_Probable_ResponsablecountRowsChecked > 0)
    {
        ShowMessagePendingRowOtras_Identificaciones_Probable_Responsable();
        return false;
    }
    if (Otros_Domicilios_Probable_ResponsablecountRowsChecked > 0)
    {
        ShowMessagePendingRowOtros_Domicilios_Probable_Responsable();
        return false;
    }
    if (Otros_NombrescountRowsChecked > 0)
    {
        ShowMessagePendingRowOtros_Nombres();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Imputado").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Imputado").on('click', '#Detalle_de_ImputadoCancelar', function () {
	  if (!isPartial) {
        Detalle_de_ImputadoBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Imputado").on('click', '#Detalle_de_ImputadoGuardar', function () {
		$('#Detalle_de_ImputadoGuardar').attr('disabled', true);
		$('#Detalle_de_ImputadoGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_ImputadoData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_ImputadoBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_ImputadoGuardar').removeAttr('disabled');
                        $('#Detalle_de_ImputadoGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Imputado', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_ImputadoItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_ImputadoDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Detalle_de_ImputadoGuardar').removeAttr('disabled');
					$('#Detalle_de_ImputadoGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_ImputadoGuardar').removeAttr('disabled');
			$('#Detalle_de_ImputadoGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Imputado").on('click', '#Detalle_de_ImputadoGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_ImputadoData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getLugar_de_DetencionData();
                getAdicciones_Probable_ResponsableData();
                getLugares_Frecuentes_Probable_ResponsableData();
                getDatos_Personales_Adicionales_Probable_ResponsableData();
                getOtras_Identificaciones_Probable_ResponsableData();
                getOtros_Domicilios_Probable_ResponsableData();
                getOtros_NombresData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Imputado', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_ImputadoItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_ImputadoDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Imputado").on('click', '#Detalle_de_ImputadoGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_ImputadoData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Modulo_Atencion_Inicial').empty();
    $("#Modulo_Atencion_Inicial").append('<option value=""></option>');
    $('#Modulo_Atencion_Inicial').val('0').trigger('change');
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Expediente_MASC').empty();
    $("#Expediente_MASC").append('<option value=""></option>');
    $('#Expediente_MASC').val('0').trigger('change');
                Lugar_de_DetencionClearGridData();
    $('#Pais_de_Nacimiento').empty();
    $("#Pais_de_Nacimiento").append('<option value=""></option>');
    $('#Pais_de_Nacimiento').val('0').trigger('change');
    $('#Estado_de_Nacimiento').empty();
    $("#Estado_de_Nacimiento").append('<option value=""></option>');
    $('#Estado_de_Nacimiento').val('0').trigger('change');
    $('#Municipio_de_Nacimiento').empty();
    $("#Municipio_de_Nacimiento").append('<option value=""></option>');
    $('#Municipio_de_Nacimiento').val('0').trigger('change');
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
                Adicciones_Probable_ResponsableClearGridData();
                Lugares_Frecuentes_Probable_ResponsableClearGridData();
                Datos_Personales_Adicionales_Probable_ResponsableClearGridData();
                Otras_Identificaciones_Probable_ResponsableClearGridData();
                Otros_Domicilios_Probable_ResponsableClearGridData();
                Otros_NombresClearGridData();
    $('#Pais_del_hecho').empty();
    $("#Pais_del_hecho").append('<option value=""></option>');
    $('#Pais_del_hecho').val('0').trigger('change');
    $('#Estado_del_Hecho').empty();
    $("#Estado_del_Hecho").append('<option value=""></option>');
    $('#Estado_del_Hecho').val('0').trigger('change');
    $('#Municipio_del_Hecho').empty();
    $("#Municipio_del_Hecho").append('<option value=""></option>');
    $('#Municipio_del_Hecho').val('0').trigger('change');
    $('#Poblacion_Hechos').empty();
    $("#Poblacion_Hechos").append('<option value=""></option>');
    $('#Poblacion_Hechos').val('0').trigger('change');
    $('#Colonia_del_hecho').empty();
    $("#Colonia_del_hecho").append('<option value=""></option>');
    $('#Colonia_del_hecho').val('0').trigger('change');
    $('#Pais_de_Origen_tutor').empty();
    $("#Pais_de_Origen_tutor").append('<option value=""></option>');
    $('#Pais_de_Origen_tutor').val('0').trigger('change');
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

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getLugar_de_DetencionData();
                getAdicciones_Probable_ResponsableData();
                getLugares_Frecuentes_Probable_ResponsableData();
                getDatos_Personales_Adicionales_Probable_ResponsableData();
                getOtras_Identificaciones_Probable_ResponsableData();
                getOtros_Domicilios_Probable_ResponsableData();
                getOtros_NombresData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Imputado',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_ImputadoItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_ImputadoDropDown().get(0)').innerHTML);                          
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



var Detalle_de_ImputadoisdisplayBusinessPropery = false;
Detalle_de_ImputadoDisplayBusinessRuleButtons(Detalle_de_ImputadoisdisplayBusinessPropery);
function Detalle_de_ImputadoDisplayBusinessRule() {
    if (!Detalle_de_ImputadoisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Imputado').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_ImputadodisplayBusinessPropery"><button onclick="Detalle_de_ImputadoGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_ImputadoBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_ImputadodisplayBusinessPropery').remove();
    }
    Detalle_de_ImputadoDisplayBusinessRuleButtons(!Detalle_de_ImputadoisdisplayBusinessPropery);
    Detalle_de_ImputadoisdisplayBusinessPropery = (Detalle_de_ImputadoisdisplayBusinessPropery ? false : true);
}
function Detalle_de_ImputadoDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

