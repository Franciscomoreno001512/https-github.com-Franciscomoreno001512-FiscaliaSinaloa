

//Begin Declarations for Foreigns fields for Detalle_de_Domicilio MultiRow
var Detalle_de_DomiciliocountRowsChecked = 0;

function GetDetalle_de_Domicilio_Tipo_de_DomicilioName(Id) {
    for (var i = 0; i < Detalle_de_Domicilio_Tipo_de_DomicilioItems.length; i++) {
        if (Detalle_de_Domicilio_Tipo_de_DomicilioItems[i].Clave == Id) {
            return Detalle_de_Domicilio_Tipo_de_DomicilioItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Domicilio_Tipo_de_DomicilioDropDown() {
    var Detalle_de_Domicilio_Tipo_de_DomicilioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Domicilio_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Domicilio_Tipo_de_DomicilioDropdown);
    if(Detalle_de_Domicilio_Tipo_de_DomicilioItems != null)
    {
       for (var i = 0; i < Detalle_de_Domicilio_Tipo_de_DomicilioItems.length; i++) {
           $('<option />', { value: Detalle_de_Domicilio_Tipo_de_DomicilioItems[i].Clave, text:    Detalle_de_Domicilio_Tipo_de_DomicilioItems[i].Descripcion }).appendTo(Detalle_de_Domicilio_Tipo_de_DomicilioDropdown);
       }
    }
    return Detalle_de_Domicilio_Tipo_de_DomicilioDropdown;
}
function GetDetalle_de_Domicilio_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Domicilio_PaisItems.length; i++) {
        if (Detalle_de_Domicilio_PaisItems[i].Clave == Id) {
            return Detalle_de_Domicilio_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Domicilio_PaisDropDown() {
    var Detalle_de_Domicilio_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Domicilio_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Domicilio_PaisDropdown);

    for (var i = 0; i < Detalle_de_Domicilio_PaisItems.length; i++) {
        $('<option />', { value: Detalle_de_Domicilio_PaisItems[i].Clave, text: Detalle_de_Domicilio_PaisItems[i].Nombre }).appendTo(Detalle_de_Domicilio_PaisDropdown);
    }
    return Detalle_de_Domicilio_PaisDropdown;
}
function GetDetalle_de_Domicilio_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Domicilio_EstadoItems.length; i++) {
        if (Detalle_de_Domicilio_EstadoItems[i].Clave == Id) {
            return Detalle_de_Domicilio_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Domicilio_EstadoDropDown() {
    var Detalle_de_Domicilio_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Domicilio_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Domicilio_EstadoDropdown);

    for (var i = 0; i < Detalle_de_Domicilio_EstadoItems.length; i++) {
        $('<option />', { value: Detalle_de_Domicilio_EstadoItems[i].Clave, text: Detalle_de_Domicilio_EstadoItems[i].Nombre }).appendTo(Detalle_de_Domicilio_EstadoDropdown);
    }
    return Detalle_de_Domicilio_EstadoDropdown;
}
function GetDetalle_de_Domicilio_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Domicilio_MunicipioItems.length; i++) {
        if (Detalle_de_Domicilio_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Domicilio_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Domicilio_MunicipioDropDown() {
    var Detalle_de_Domicilio_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Domicilio_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Domicilio_MunicipioDropdown);

    for (var i = 0; i < Detalle_de_Domicilio_MunicipioItems.length; i++) {
        $('<option />', { value: Detalle_de_Domicilio_MunicipioItems[i].Clave, text: Detalle_de_Domicilio_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Domicilio_MunicipioDropdown);
    }
    return Detalle_de_Domicilio_MunicipioDropdown;
}
function GetDetalle_de_Domicilio_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Domicilio_ColoniaItems.length; i++) {
        if (Detalle_de_Domicilio_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Domicilio_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Domicilio_ColoniaDropDown() {
    var Detalle_de_Domicilio_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Domicilio_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Domicilio_ColoniaDropdown);

    for (var i = 0; i < Detalle_de_Domicilio_ColoniaItems.length; i++) {
        $('<option />', { value: Detalle_de_Domicilio_ColoniaItems[i].Clave, text: Detalle_de_Domicilio_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Domicilio_ColoniaDropdown);
    }
    return Detalle_de_Domicilio_ColoniaDropdown;
}







function GetInsertDetalle_de_DomicilioRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_de_Domicilio_Tipo_de_DomicilioDropDown()).addClass('Detalle_de_Domicilio_Tipo_de_Domicilio Tipo_de_Domicilio').attr('id', 'Detalle_de_Domicilio_Tipo_de_Domicilio_' + index).attr('data-field', 'Tipo_de_Domicilio').after($.parseHTML(addNew('Detalle_de_Domicilio', 'Tipo_de_Domicilio', 'Tipo_de_Domicilio', 268867)));
    columnData[1] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Domicilio_Pais'))).addClass('Detalle_de_Domicilio_Pais Pais').attr('id', 'Detalle_de_Domicilio_Pais_' + index).attr('data-field', 'Pais').after($.parseHTML(addNew('Detalle_de_Domicilio', 'Pais', 'Pais', 268868)));
    columnData[2] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Domicilio_Estado'))).addClass('Detalle_de_Domicilio_Estado Estado').attr('id', 'Detalle_de_Domicilio_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_de_Domicilio', 'Estado', 'Estado', 268869)));
    columnData[3] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Domicilio_Municipio'))).addClass('Detalle_de_Domicilio_Municipio Municipio').attr('id', 'Detalle_de_Domicilio_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_de_Domicilio', 'Municipio', 'Municipio', 268870)));
    columnData[4] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Domicilio_Colonia'))).addClass('Detalle_de_Domicilio_Colonia Colonia').attr('id', 'Detalle_de_Domicilio_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_de_Domicilio', 'Colonia', 'Colonia', 268871)));
    columnData[5] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Domicilio_Codigo_Postal Codigo_Postal').attr('id', 'Detalle_de_Domicilio_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[6] = $($.parseHTML(inputData)).addClass('Detalle_de_Domicilio_Calle Calle').attr('id', 'Detalle_de_Domicilio_Calle_' + index).attr('data-field', 'Calle');
    columnData[7] = $($.parseHTML(inputData)).addClass('Detalle_de_Domicilio_Numero_Exterior Numero_Exterior').attr('id', 'Detalle_de_Domicilio_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[8] = $($.parseHTML(inputData)).addClass('Detalle_de_Domicilio_Numero_Interior Numero_Interior').attr('id', 'Detalle_de_Domicilio_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[9] = $($.parseHTML(inputData)).addClass('Detalle_de_Domicilio_Observaciones_Comentarios Observaciones_Comentarios').attr('id', 'Detalle_de_Domicilio_Observaciones_Comentarios_' + index).attr('data-field', 'Observaciones_Comentarios');


    initiateUIControls();
    return columnData;
}

function Detalle_de_DomicilioInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Domicilio("Detalle_de_Domicilio_", "_" + rowIndex)) {
    var iPage = Detalle_de_DomicilioTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Domicilio';
    var prevData = Detalle_de_DomicilioTable.fnGetData(rowIndex);
    var data = Detalle_de_DomicilioTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Domicilio:  data.childNodes[counter++].childNodes[0].value
        , PaisNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Pais:  data.childNodes[counter++].childNodes[0].value 	
        , EstadoNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Estado:  data.childNodes[counter++].childNodes[0].value 	
        , MunicipioNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Municipio:  data.childNodes[counter++].childNodes[0].value 	
        , ColoniaNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Colonia:  data.childNodes[counter++].childNodes[0].value 	
        ,Codigo_Postal: data.childNodes[counter++].childNodes[0].value
        ,Calle:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones_Comentarios:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_DomicilioTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_DomiciliorowCreationGrid(data, newData, rowIndex);
    Detalle_de_DomicilioTable.fnPageChange(iPage);
    Detalle_de_DomiciliocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Domicilio("Detalle_de_Domicilio_", "_" + rowIndex);
  }
}

function Detalle_de_DomicilioCancelRow(rowIndex) {
    var prevData = Detalle_de_DomicilioTable.fnGetData(rowIndex);
    var data = Detalle_de_DomicilioTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_DomicilioTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_DomiciliorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_DomicilioGrid(Detalle_de_DomicilioTable.fnGetData());
    Detalle_de_DomiciliocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_DomicilioFromDataTable() {
    var Detalle_de_DomicilioData = [];
    var gridData = Detalle_de_DomicilioTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_DomicilioData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Domicilio: gridData[i].Tipo_de_Domicilio
                ,Pais: gridData[i].Pais
                ,Estado: gridData[i].Estado
                ,Municipio: gridData[i].Municipio
                ,Colonia: gridData[i].Colonia
                ,Codigo_Postal: gridData[i].Codigo_Postal
                ,Calle: gridData[i].Calle
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior
                ,Observaciones_Comentarios: gridData[i].Observaciones_Comentarios

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_DomicilioData.length; i++) {
        if (removedDetalle_de_DomicilioData[i] != null && removedDetalle_de_DomicilioData[i].Clave > 0)
            Detalle_de_DomicilioData.push({
                Clave: removedDetalle_de_DomicilioData[i].Clave

                ,Tipo_de_Domicilio: removedDetalle_de_DomicilioData[i].Tipo_de_Domicilio
                ,Pais: removedDetalle_de_DomicilioData[i].Pais
                ,Estado: removedDetalle_de_DomicilioData[i].Estado
                ,Municipio: removedDetalle_de_DomicilioData[i].Municipio
                ,Colonia: removedDetalle_de_DomicilioData[i].Colonia
                ,Codigo_Postal: removedDetalle_de_DomicilioData[i].Codigo_Postal
                ,Calle: removedDetalle_de_DomicilioData[i].Calle
                ,Numero_Exterior: removedDetalle_de_DomicilioData[i].Numero_Exterior
                ,Numero_Interior: removedDetalle_de_DomicilioData[i].Numero_Interior
                ,Observaciones_Comentarios: removedDetalle_de_DomicilioData[i].Observaciones_Comentarios

                , Removed: true
            });
    }	

    return Detalle_de_DomicilioData;
}

function Detalle_de_DomicilioEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_DomicilioTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_DomiciliocountRowsChecked++;
    var Detalle_de_DomicilioRowElement = "Detalle_de_Domicilio_" + rowIndex.toString();
    var prevData = Detalle_de_DomicilioTable.fnGetData(rowIndexTable );
    var row = Detalle_de_DomicilioTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Domicilio_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_DomicilioGetUpdateRowControls(prevData, "Detalle_de_Domicilio_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_DomicilioRowElement + "')){ Detalle_de_DomicilioInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_DomicilioCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_DomicilioGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_DomicilioGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_DomicilioValidation();
    initiateUIControls();
    $('.Detalle_de_Domicilio' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Domicilio(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_DomiciliofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_DomicilioTable.fnGetData().length;
    Detalle_de_DomiciliofnClickAddRow();
    GetAddDetalle_de_DomicilioPopup(currentRowIndex, 0);
}

function Detalle_de_DomicilioEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_DomicilioTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_DomicilioRowElement = "Detalle_de_Domicilio_" + rowIndex.toString();
    var prevData = Detalle_de_DomicilioTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_DomicilioPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_DomicilioTipo_de_Domicilio').val(prevData.Tipo_de_Domicilio);
    $('#dvDetalle_de_DomicilioPais').html($($.parseHTML(GetGridAutoComplete(prevData.Pais.label,'AutoCompletePais'))).addClass('Detalle_de_Domicilio_Pais'));
    $('#dvDetalle_de_DomicilioEstado').html($($.parseHTML(GetGridAutoComplete(prevData.Estado.label,'AutoCompleteEstado'))).addClass('Detalle_de_Domicilio_Estado'));
    $('#dvDetalle_de_DomicilioMunicipio').html($($.parseHTML(GetGridAutoComplete(prevData.Municipio.label,'AutoCompleteMunicipio'))).addClass('Detalle_de_Domicilio_Municipio'));
    $('#dvDetalle_de_DomicilioColonia').html($($.parseHTML(GetGridAutoComplete(prevData.Colonia.label,'AutoCompleteColonia'))).addClass('Detalle_de_Domicilio_Colonia'));
    $('#Detalle_de_DomicilioCodigo_Postal').val(prevData.Codigo_Postal);
    $('#Detalle_de_DomicilioCalle').val(prevData.Calle);
    $('#Detalle_de_DomicilioNumero_Exterior').val(prevData.Numero_Exterior);
    $('#Detalle_de_DomicilioNumero_Interior').val(prevData.Numero_Interior);
    $('#Detalle_de_DomicilioObservaciones_Comentarios').val(prevData.Observaciones_Comentarios);

    initiateUIControls();












}

function Detalle_de_DomicilioAddInsertRow() {
    if (Detalle_de_DomicilioinsertRowCurrentIndex < 1)
    {
        Detalle_de_DomicilioinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Domicilio: ""
        ,Pais: ""
        ,Estado: ""
        ,Municipio: ""
        ,Colonia: ""
        ,Codigo_Postal: ""
        ,Calle: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""
        ,Observaciones_Comentarios: ""

    }
}

function Detalle_de_DomiciliofnClickAddRow() {
    Detalle_de_DomiciliocountRowsChecked++;
    Detalle_de_DomicilioTable.fnAddData(Detalle_de_DomicilioAddInsertRow(), true);
    Detalle_de_DomicilioTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_DomicilioGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_DomicilioGrid tbody tr:nth-of-type(' + (Detalle_de_DomicilioinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Domicilio("Detalle_de_Domicilio_", "_" + Detalle_de_DomicilioinsertRowCurrentIndex);
}

function Detalle_de_DomicilioClearGridData() {
    Detalle_de_DomicilioData = [];
    Detalle_de_DomiciliodeletedItem = [];
    Detalle_de_DomicilioDataMain = [];
    Detalle_de_DomicilioDataMainPages = [];
    Detalle_de_DomicilionewItemCount = 0;
    Detalle_de_DomiciliomaxItemIndex = 0;
    $("#Detalle_de_DomicilioGrid").DataTable().clear();
    $("#Detalle_de_DomicilioGrid").DataTable().destroy();
}

//Used to Get Registro de Mandamiento Judicial Information
function GetDetalle_de_Domicilio() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_DomicilioData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_DomicilioData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Domicilio', Detalle_de_DomicilioData[i].Tipo_de_Domicilio);
        form_data.append('[' + i + '].Pais', Detalle_de_DomicilioData[i].Pais);
        form_data.append('[' + i + '].Estado', Detalle_de_DomicilioData[i].Estado);
        form_data.append('[' + i + '].Municipio', Detalle_de_DomicilioData[i].Municipio);
        form_data.append('[' + i + '].Colonia', Detalle_de_DomicilioData[i].Colonia);
        form_data.append('[' + i + '].Codigo_Postal', Detalle_de_DomicilioData[i].Codigo_Postal);
        form_data.append('[' + i + '].Calle', Detalle_de_DomicilioData[i].Calle);
        form_data.append('[' + i + '].Numero_Exterior', Detalle_de_DomicilioData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Detalle_de_DomicilioData[i].Numero_Interior);
        form_data.append('[' + i + '].Observaciones_Comentarios', Detalle_de_DomicilioData[i].Observaciones_Comentarios);

        form_data.append('[' + i + '].Removed', Detalle_de_DomicilioData[i].Removed);
    }
    return form_data;
}
function Detalle_de_DomicilioInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Domicilio("Detalle_de_DomicilioTable", rowIndex)) {
    var prevData = Detalle_de_DomicilioTable.fnGetData(rowIndex);
    var data = Detalle_de_DomicilioTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Domicilio: $('#Detalle_de_DomicilioTipo_de_Domicilio').val()
        ,Pais: $('#Detalle_de_DomicilioPais').val()
        ,Estado: $('#Detalle_de_DomicilioEstado').val()
        ,Municipio: $('#Detalle_de_DomicilioMunicipio').val()
        ,Colonia: $('#Detalle_de_DomicilioColonia').val()
        ,Codigo_Postal: $('#Detalle_de_DomicilioCodigo_Postal').val()

        ,Calle: $('#Detalle_de_DomicilioCalle').val()
        ,Numero_Exterior: $('#Detalle_de_DomicilioNumero_Exterior').val()
        ,Numero_Interior: $('#Detalle_de_DomicilioNumero_Interior').val()
        ,Observaciones_Comentarios: $('#Detalle_de_DomicilioObservaciones_Comentarios').val()

    }

    Detalle_de_DomicilioTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_DomiciliorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Domicilio-form').modal({ show: false });
    $('#AddDetalle_de_Domicilio-form').modal('hide');
    Detalle_de_DomicilioEditRow(rowIndex);
    Detalle_de_DomicilioInsertRow(rowIndex);
    //}
}
function Detalle_de_DomicilioRemoveAddRow(rowIndex) {
    Detalle_de_DomicilioTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Domicilio MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_telefono MultiRow
var Detalle_de_telefonocountRowsChecked = 0;

function GetDetalle_de_telefono_Tipo_de_TelefonoName(Id) {
    for (var i = 0; i < Detalle_de_telefono_Tipo_de_TelefonoItems.length; i++) {
        if (Detalle_de_telefono_Tipo_de_TelefonoItems[i].Clave == Id) {
            return Detalle_de_telefono_Tipo_de_TelefonoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_telefono_Tipo_de_TelefonoDropDown() {
    var Detalle_de_telefono_Tipo_de_TelefonoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_telefono_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_telefono_Tipo_de_TelefonoDropdown);
    if(Detalle_de_telefono_Tipo_de_TelefonoItems != null)
    {
       for (var i = 0; i < Detalle_de_telefono_Tipo_de_TelefonoItems.length; i++) {
           $('<option />', { value: Detalle_de_telefono_Tipo_de_TelefonoItems[i].Clave, text:    Detalle_de_telefono_Tipo_de_TelefonoItems[i].Descripcion }).appendTo(Detalle_de_telefono_Tipo_de_TelefonoDropdown);
       }
    }
    return Detalle_de_telefono_Tipo_de_TelefonoDropdown;
}




function GetInsertDetalle_de_telefonoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_de_telefono_Tipo_de_TelefonoDropDown()).addClass('Detalle_de_telefono_Tipo_de_Telefono Tipo_de_Telefono').attr('id', 'Detalle_de_telefono_Tipo_de_Telefono_' + index).attr('data-field', 'Tipo_de_Telefono').after($.parseHTML(addNew('Detalle_de_telefono', 'Tipo_de_Telefono', 'Tipo_de_Telefono', 268932)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_telefono_Telefono Telefono').attr('id', 'Detalle_de_telefono_Telefono_' + index).attr('data-field', 'Telefono');
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_telefono_Extension Extension').attr('id', 'Detalle_de_telefono_Extension_' + index).attr('data-field', 'Extension');


    initiateUIControls();
    return columnData;
}

function Detalle_de_telefonoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_telefono("Detalle_de_telefono_", "_" + rowIndex)) {
    var iPage = Detalle_de_telefonoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_telefono';
    var prevData = Detalle_de_telefonoTable.fnGetData(rowIndex);
    var data = Detalle_de_telefonoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Telefono:  data.childNodes[counter++].childNodes[0].value
        ,Telefono:  data.childNodes[counter++].childNodes[0].value
        ,Extension: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_telefonoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_telefonorowCreationGrid(data, newData, rowIndex);
    Detalle_de_telefonoTable.fnPageChange(iPage);
    Detalle_de_telefonocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_telefono("Detalle_de_telefono_", "_" + rowIndex);
  }
}

function Detalle_de_telefonoCancelRow(rowIndex) {
    var prevData = Detalle_de_telefonoTable.fnGetData(rowIndex);
    var data = Detalle_de_telefonoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_telefonoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_telefonorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_telefonoGrid(Detalle_de_telefonoTable.fnGetData());
    Detalle_de_telefonocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_telefonoFromDataTable() {
    var Detalle_de_telefonoData = [];
    var gridData = Detalle_de_telefonoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_telefonoData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Telefono: gridData[i].Tipo_de_Telefono
                ,Telefono: gridData[i].Telefono
                ,Extension: gridData[i].Extension

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_telefonoData.length; i++) {
        if (removedDetalle_de_telefonoData[i] != null && removedDetalle_de_telefonoData[i].Clave > 0)
            Detalle_de_telefonoData.push({
                Clave: removedDetalle_de_telefonoData[i].Clave

                ,Tipo_de_Telefono: removedDetalle_de_telefonoData[i].Tipo_de_Telefono
                ,Telefono: removedDetalle_de_telefonoData[i].Telefono
                ,Extension: removedDetalle_de_telefonoData[i].Extension

                , Removed: true
            });
    }	

    return Detalle_de_telefonoData;
}

function Detalle_de_telefonoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_telefonoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_telefonocountRowsChecked++;
    var Detalle_de_telefonoRowElement = "Detalle_de_telefono_" + rowIndex.toString();
    var prevData = Detalle_de_telefonoTable.fnGetData(rowIndexTable );
    var row = Detalle_de_telefonoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_telefono_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_telefonoGetUpdateRowControls(prevData, "Detalle_de_telefono_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_telefonoRowElement + "')){ Detalle_de_telefonoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_telefonoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_telefonoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_telefonoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_telefonoValidation();
    initiateUIControls();
    $('.Detalle_de_telefono' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_telefono(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_telefonofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_telefonoTable.fnGetData().length;
    Detalle_de_telefonofnClickAddRow();
    GetAddDetalle_de_telefonoPopup(currentRowIndex, 0);
}

function Detalle_de_telefonoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_telefonoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_telefonoRowElement = "Detalle_de_telefono_" + rowIndex.toString();
    var prevData = Detalle_de_telefonoTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_telefonoPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_telefonoTipo_de_Telefono').val(prevData.Tipo_de_Telefono);
    $('#Detalle_de_telefonoTelefono').val(prevData.Telefono);
    $('#Detalle_de_telefonoExtension').val(prevData.Extension);

    initiateUIControls();





}

function Detalle_de_telefonoAddInsertRow() {
    if (Detalle_de_telefonoinsertRowCurrentIndex < 1)
    {
        Detalle_de_telefonoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Telefono: ""
        ,Telefono: ""
        ,Extension: ""

    }
}

function Detalle_de_telefonofnClickAddRow() {
    Detalle_de_telefonocountRowsChecked++;
    Detalle_de_telefonoTable.fnAddData(Detalle_de_telefonoAddInsertRow(), true);
    Detalle_de_telefonoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_telefonoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_telefonoGrid tbody tr:nth-of-type(' + (Detalle_de_telefonoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_telefono("Detalle_de_telefono_", "_" + Detalle_de_telefonoinsertRowCurrentIndex);
}

function Detalle_de_telefonoClearGridData() {
    Detalle_de_telefonoData = [];
    Detalle_de_telefonodeletedItem = [];
    Detalle_de_telefonoDataMain = [];
    Detalle_de_telefonoDataMainPages = [];
    Detalle_de_telefononewItemCount = 0;
    Detalle_de_telefonomaxItemIndex = 0;
    $("#Detalle_de_telefonoGrid").DataTable().clear();
    $("#Detalle_de_telefonoGrid").DataTable().destroy();
}

//Used to Get Registro de Mandamiento Judicial Information
function GetDetalle_de_telefono() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_telefonoData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_telefonoData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Telefono', Detalle_de_telefonoData[i].Tipo_de_Telefono);
        form_data.append('[' + i + '].Telefono', Detalle_de_telefonoData[i].Telefono);
        form_data.append('[' + i + '].Extension', Detalle_de_telefonoData[i].Extension);

        form_data.append('[' + i + '].Removed', Detalle_de_telefonoData[i].Removed);
    }
    return form_data;
}
function Detalle_de_telefonoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_telefono("Detalle_de_telefonoTable", rowIndex)) {
    var prevData = Detalle_de_telefonoTable.fnGetData(rowIndex);
    var data = Detalle_de_telefonoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Telefono: $('#Detalle_de_telefonoTipo_de_Telefono').val()
        ,Telefono: $('#Detalle_de_telefonoTelefono').val()
        ,Extension: $('#Detalle_de_telefonoExtension').val()


    }

    Detalle_de_telefonoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_telefonorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_telefono-form').modal({ show: false });
    $('#AddDetalle_de_telefono-form').modal('hide');
    Detalle_de_telefonoEditRow(rowIndex);
    Detalle_de_telefonoInsertRow(rowIndex);
    //}
}
function Detalle_de_telefonoRemoveAddRow(rowIndex) {
    Detalle_de_telefonoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_telefono MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Otro_Nombre MultiRow
var Detalle_de_Otro_NombrecountRowsChecked = 0;







function GetInsertDetalle_de_Otro_NombreRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Otro_Nombre_Otro_Nombre_del_Individuo Otro_Nombre_del_Individuo').attr('id', 'Detalle_de_Otro_Nombre_Otro_Nombre_del_Individuo_' + index).attr('data-field', 'Otro_Nombre_del_Individuo');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Otro_Nombre_Otro_Apellido_Paterno_del_Individuo Otro_Apellido_Paterno_del_Individuo').attr('id', 'Detalle_de_Otro_Nombre_Otro_Apellido_Paterno_del_Individuo_' + index).attr('data-field', 'Otro_Apellido_Paterno_del_Individuo');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Otro_Nombre_Otro_Apellido_Materno_del_Individuo Otro_Apellido_Materno_del_Individuo').attr('id', 'Detalle_de_Otro_Nombre_Otro_Apellido_Materno_del_Individuo_' + index).attr('data-field', 'Otro_Apellido_Materno_del_Individuo');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Otro_Nombre_Otro_Alias_del_Individuo Otro_Alias_del_Individuo').attr('id', 'Detalle_de_Otro_Nombre_Otro_Alias_del_Individuo_' + index).attr('data-field', 'Otro_Alias_del_Individuo');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Otro_NombreInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Otro_Nombre("Detalle_de_Otro_Nombre_", "_" + rowIndex)) {
    var iPage = Detalle_de_Otro_NombreTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Otro_Nombre';
    var prevData = Detalle_de_Otro_NombreTable.fnGetData(rowIndex);
    var data = Detalle_de_Otro_NombreTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Otro_Nombre_del_Individuo:  data.childNodes[counter++].childNodes[0].value
        ,Otro_Apellido_Paterno_del_Individuo:  data.childNodes[counter++].childNodes[0].value
        ,Otro_Apellido_Materno_del_Individuo:  data.childNodes[counter++].childNodes[0].value
        ,Otro_Alias_del_Individuo:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Otro_NombreTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Otro_NombrerowCreationGrid(data, newData, rowIndex);
    Detalle_de_Otro_NombreTable.fnPageChange(iPage);
    Detalle_de_Otro_NombrecountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Otro_Nombre("Detalle_de_Otro_Nombre_", "_" + rowIndex);
  }
}

function Detalle_de_Otro_NombreCancelRow(rowIndex) {
    var prevData = Detalle_de_Otro_NombreTable.fnGetData(rowIndex);
    var data = Detalle_de_Otro_NombreTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Otro_NombreTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Otro_NombrerowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Otro_NombreGrid(Detalle_de_Otro_NombreTable.fnGetData());
    Detalle_de_Otro_NombrecountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Otro_NombreFromDataTable() {
    var Detalle_de_Otro_NombreData = [];
    var gridData = Detalle_de_Otro_NombreTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Otro_NombreData.push({
                Clave: gridData[i].Clave

                ,Otro_Nombre_del_Individuo: gridData[i].Otro_Nombre_del_Individuo
                ,Otro_Apellido_Paterno_del_Individuo: gridData[i].Otro_Apellido_Paterno_del_Individuo
                ,Otro_Apellido_Materno_del_Individuo: gridData[i].Otro_Apellido_Materno_del_Individuo
                ,Otro_Alias_del_Individuo: gridData[i].Otro_Alias_del_Individuo

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Otro_NombreData.length; i++) {
        if (removedDetalle_de_Otro_NombreData[i] != null && removedDetalle_de_Otro_NombreData[i].Clave > 0)
            Detalle_de_Otro_NombreData.push({
                Clave: removedDetalle_de_Otro_NombreData[i].Clave

                ,Otro_Nombre_del_Individuo: removedDetalle_de_Otro_NombreData[i].Otro_Nombre_del_Individuo
                ,Otro_Apellido_Paterno_del_Individuo: removedDetalle_de_Otro_NombreData[i].Otro_Apellido_Paterno_del_Individuo
                ,Otro_Apellido_Materno_del_Individuo: removedDetalle_de_Otro_NombreData[i].Otro_Apellido_Materno_del_Individuo
                ,Otro_Alias_del_Individuo: removedDetalle_de_Otro_NombreData[i].Otro_Alias_del_Individuo

                , Removed: true
            });
    }	

    return Detalle_de_Otro_NombreData;
}

function Detalle_de_Otro_NombreEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Otro_NombreTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Otro_NombrecountRowsChecked++;
    var Detalle_de_Otro_NombreRowElement = "Detalle_de_Otro_Nombre_" + rowIndex.toString();
    var prevData = Detalle_de_Otro_NombreTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Otro_NombreTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Otro_Nombre_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Otro_NombreGetUpdateRowControls(prevData, "Detalle_de_Otro_Nombre_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Otro_NombreRowElement + "')){ Detalle_de_Otro_NombreInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Otro_NombreCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Otro_NombreGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Otro_NombreGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Otro_NombreValidation();
    initiateUIControls();
    $('.Detalle_de_Otro_Nombre' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Otro_Nombre(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Otro_NombrefnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Otro_NombreTable.fnGetData().length;
    Detalle_de_Otro_NombrefnClickAddRow();
    GetAddDetalle_de_Otro_NombrePopup(currentRowIndex, 0);
}

function Detalle_de_Otro_NombreEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Otro_NombreTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Otro_NombreRowElement = "Detalle_de_Otro_Nombre_" + rowIndex.toString();
    var prevData = Detalle_de_Otro_NombreTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Otro_NombrePopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Otro_NombreOtro_Nombre_del_Individuo').val(prevData.Otro_Nombre_del_Individuo);
    $('#Detalle_de_Otro_NombreOtro_Apellido_Paterno_del_Individuo').val(prevData.Otro_Apellido_Paterno_del_Individuo);
    $('#Detalle_de_Otro_NombreOtro_Apellido_Materno_del_Individuo').val(prevData.Otro_Apellido_Materno_del_Individuo);
    $('#Detalle_de_Otro_NombreOtro_Alias_del_Individuo').val(prevData.Otro_Alias_del_Individuo);

    initiateUIControls();






}

function Detalle_de_Otro_NombreAddInsertRow() {
    if (Detalle_de_Otro_NombreinsertRowCurrentIndex < 1)
    {
        Detalle_de_Otro_NombreinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Otro_Nombre_del_Individuo: ""
        ,Otro_Apellido_Paterno_del_Individuo: ""
        ,Otro_Apellido_Materno_del_Individuo: ""
        ,Otro_Alias_del_Individuo: ""

    }
}

function Detalle_de_Otro_NombrefnClickAddRow() {
    Detalle_de_Otro_NombrecountRowsChecked++;
    Detalle_de_Otro_NombreTable.fnAddData(Detalle_de_Otro_NombreAddInsertRow(), true);
    Detalle_de_Otro_NombreTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Otro_NombreGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Otro_NombreGrid tbody tr:nth-of-type(' + (Detalle_de_Otro_NombreinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Otro_Nombre("Detalle_de_Otro_Nombre_", "_" + Detalle_de_Otro_NombreinsertRowCurrentIndex);
}

function Detalle_de_Otro_NombreClearGridData() {
    Detalle_de_Otro_NombreData = [];
    Detalle_de_Otro_NombredeletedItem = [];
    Detalle_de_Otro_NombreDataMain = [];
    Detalle_de_Otro_NombreDataMainPages = [];
    Detalle_de_Otro_NombrenewItemCount = 0;
    Detalle_de_Otro_NombremaxItemIndex = 0;
    $("#Detalle_de_Otro_NombreGrid").DataTable().clear();
    $("#Detalle_de_Otro_NombreGrid").DataTable().destroy();
}

//Used to Get Registro de Mandamiento Judicial Information
function GetDetalle_de_Otro_Nombre() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Otro_NombreData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Otro_NombreData[i].Clave);

        form_data.append('[' + i + '].Otro_Nombre_del_Individuo', Detalle_de_Otro_NombreData[i].Otro_Nombre_del_Individuo);
        form_data.append('[' + i + '].Otro_Apellido_Paterno_del_Individuo', Detalle_de_Otro_NombreData[i].Otro_Apellido_Paterno_del_Individuo);
        form_data.append('[' + i + '].Otro_Apellido_Materno_del_Individuo', Detalle_de_Otro_NombreData[i].Otro_Apellido_Materno_del_Individuo);
        form_data.append('[' + i + '].Otro_Alias_del_Individuo', Detalle_de_Otro_NombreData[i].Otro_Alias_del_Individuo);

        form_data.append('[' + i + '].Removed', Detalle_de_Otro_NombreData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Otro_NombreInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Otro_Nombre("Detalle_de_Otro_NombreTable", rowIndex)) {
    var prevData = Detalle_de_Otro_NombreTable.fnGetData(rowIndex);
    var data = Detalle_de_Otro_NombreTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Otro_Nombre_del_Individuo: $('#Detalle_de_Otro_NombreOtro_Nombre_del_Individuo').val()
        ,Otro_Apellido_Paterno_del_Individuo: $('#Detalle_de_Otro_NombreOtro_Apellido_Paterno_del_Individuo').val()
        ,Otro_Apellido_Materno_del_Individuo: $('#Detalle_de_Otro_NombreOtro_Apellido_Materno_del_Individuo').val()
        ,Otro_Alias_del_Individuo: $('#Detalle_de_Otro_NombreOtro_Alias_del_Individuo').val()

    }

    Detalle_de_Otro_NombreTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Otro_NombrerowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Otro_Nombre-form').modal({ show: false });
    $('#AddDetalle_de_Otro_Nombre-form').modal('hide');
    Detalle_de_Otro_NombreEditRow(rowIndex);
    Detalle_de_Otro_NombreInsertRow(rowIndex);
    //}
}
function Detalle_de_Otro_NombreRemoveAddRow(rowIndex) {
    Detalle_de_Otro_NombreTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Otro_Nombre MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Delito_Mandamiento_Judicial MultiRow
var Detalle_de_Delito_Mandamiento_JudicialcountRowsChecked = 0;

function GetDetalle_de_Delito_Mandamiento_Judicial_DelitoName(Id) {
    for (var i = 0; i < Detalle_de_Delito_Mandamiento_Judicial_DelitoItems.length; i++) {
        if (Detalle_de_Delito_Mandamiento_Judicial_DelitoItems[i].Clave == Id) {
            return Detalle_de_Delito_Mandamiento_Judicial_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Delito_Mandamiento_Judicial_DelitoDropDown() {
    var Detalle_de_Delito_Mandamiento_Judicial_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Delito_Mandamiento_Judicial_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Delito_Mandamiento_Judicial_DelitoDropdown);

    for (var i = 0; i < Detalle_de_Delito_Mandamiento_Judicial_DelitoItems.length; i++) {
        $('<option />', { value: Detalle_de_Delito_Mandamiento_Judicial_DelitoItems[i].Clave, text: Detalle_de_Delito_Mandamiento_Judicial_DelitoItems[i].Descripcion }).appendTo(Detalle_de_Delito_Mandamiento_Judicial_DelitoDropdown);
    }
    return Detalle_de_Delito_Mandamiento_Judicial_DelitoDropdown;
}
function GetDetalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoName(Id) {
    for (var i = 0; i < Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoItems.length; i++) {
        if (Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoItems[i].Clave == Id) {
            return Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoDropDown() {
    var Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Delito_Mandamiento_Judicial_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoDropdown);
    if(Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoItems != null)
    {
       for (var i = 0; i < Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoItems.length; i++) {
           $('<option />', { value: Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoItems[i].Clave, text:    Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoItems[i].Descripcion }).appendTo(Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoDropdown);
       }
    }
    return Detalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoDropdown;
}


function GetInsertDetalle_de_Delito_Mandamiento_JudicialRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Delito_Mandamiento_Judicial_Delito'))).addClass('Detalle_de_Delito_Mandamiento_Judicial_Delito Delito').attr('id', 'Detalle_de_Delito_Mandamiento_Judicial_Delito_' + index).attr('data-field', 'Delito').after($.parseHTML(addNew('Detalle_de_Delito_Mandamiento_Judicial', 'Delito', 'Delito', 268861)));
    columnData[1] = $(GetDetalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoDropDown()).addClass('Detalle_de_Delito_Mandamiento_Judicial_Modalidad Modalidad').attr('id', 'Detalle_de_Delito_Mandamiento_Judicial_Modalidad_' + index).attr('data-field', 'Modalidad').after($.parseHTML(addNew('Detalle_de_Delito_Mandamiento_Judicial', 'Modalidad_Delito', 'Modalidad', 268862)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_Delito_Mandamiento_JudicialInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Delito_Mandamiento_Judicial("Detalle_de_Delito_Mandamiento_Judicial_", "_" + rowIndex)) {
    var iPage = Detalle_de_Delito_Mandamiento_JudicialTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Delito_Mandamiento_Judicial';
    var prevData = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetData(rowIndex);
    var data = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        , DelitoDescripcion:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Delito:  data.childNodes[counter++].childNodes[0].value 	
        ,Modalidad:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Delito_Mandamiento_JudicialTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Delito_Mandamiento_JudicialrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Delito_Mandamiento_JudicialTable.fnPageChange(iPage);
    Detalle_de_Delito_Mandamiento_JudicialcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Delito_Mandamiento_Judicial("Detalle_de_Delito_Mandamiento_Judicial_", "_" + rowIndex);
  }
}

function Detalle_de_Delito_Mandamiento_JudicialCancelRow(rowIndex) {
    var prevData = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetData(rowIndex);
    var data = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Delito_Mandamiento_JudicialTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Delito_Mandamiento_JudicialrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Delito_Mandamiento_JudicialGrid(Detalle_de_Delito_Mandamiento_JudicialTable.fnGetData());
    Detalle_de_Delito_Mandamiento_JudicialcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Delito_Mandamiento_JudicialFromDataTable() {
    var Detalle_de_Delito_Mandamiento_JudicialData = [];
    var gridData = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Delito_Mandamiento_JudicialData.push({
                Clave: gridData[i].Clave

                ,Delito: gridData[i].Delito
                ,Modalidad: gridData[i].Modalidad

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Delito_Mandamiento_JudicialData.length; i++) {
        if (removedDetalle_de_Delito_Mandamiento_JudicialData[i] != null && removedDetalle_de_Delito_Mandamiento_JudicialData[i].Clave > 0)
            Detalle_de_Delito_Mandamiento_JudicialData.push({
                Clave: removedDetalle_de_Delito_Mandamiento_JudicialData[i].Clave

                ,Delito: removedDetalle_de_Delito_Mandamiento_JudicialData[i].Delito
                ,Modalidad: removedDetalle_de_Delito_Mandamiento_JudicialData[i].Modalidad

                , Removed: true
            });
    }	

    return Detalle_de_Delito_Mandamiento_JudicialData;
}

function Detalle_de_Delito_Mandamiento_JudicialEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Delito_Mandamiento_JudicialTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Delito_Mandamiento_JudicialcountRowsChecked++;
    var Detalle_de_Delito_Mandamiento_JudicialRowElement = "Detalle_de_Delito_Mandamiento_Judicial_" + rowIndex.toString();
    var prevData = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Delito_Mandamiento_Judicial_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Delito_Mandamiento_JudicialGetUpdateRowControls(prevData, "Detalle_de_Delito_Mandamiento_Judicial_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Delito_Mandamiento_JudicialRowElement + "')){ Detalle_de_Delito_Mandamiento_JudicialInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Delito_Mandamiento_JudicialCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Delito_Mandamiento_JudicialGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Delito_Mandamiento_JudicialGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Delito_Mandamiento_JudicialValidation();
    initiateUIControls();
    $('.Detalle_de_Delito_Mandamiento_Judicial' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Delito_Mandamiento_JudicialfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetData().length;
    Detalle_de_Delito_Mandamiento_JudicialfnClickAddRow();
    GetAddDetalle_de_Delito_Mandamiento_JudicialPopup(currentRowIndex, 0);
}

function Detalle_de_Delito_Mandamiento_JudicialEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Delito_Mandamiento_JudicialRowElement = "Detalle_de_Delito_Mandamiento_Judicial_" + rowIndex.toString();
    var prevData = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Delito_Mandamiento_JudicialPopup(rowIndex, 1, prevData.Clave);

    $('#dvDetalle_de_Delito_Mandamiento_JudicialDelito').html($($.parseHTML(GetGridAutoComplete(prevData.Delito.label,'AutoCompleteDelito'))).addClass('Detalle_de_Delito_Mandamiento_Judicial_Delito'));
    $('#Detalle_de_Delito_Mandamiento_JudicialModalidad').val(prevData.Modalidad);

    initiateUIControls();




}

function Detalle_de_Delito_Mandamiento_JudicialAddInsertRow() {
    if (Detalle_de_Delito_Mandamiento_JudicialinsertRowCurrentIndex < 1)
    {
        Detalle_de_Delito_Mandamiento_JudicialinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Delito: ""
        ,Modalidad: ""

    }
}

function Detalle_de_Delito_Mandamiento_JudicialfnClickAddRow() {
    Detalle_de_Delito_Mandamiento_JudicialcountRowsChecked++;
    Detalle_de_Delito_Mandamiento_JudicialTable.fnAddData(Detalle_de_Delito_Mandamiento_JudicialAddInsertRow(), true);
    Detalle_de_Delito_Mandamiento_JudicialTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Delito_Mandamiento_JudicialGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Delito_Mandamiento_JudicialGrid tbody tr:nth-of-type(' + (Detalle_de_Delito_Mandamiento_JudicialinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Delito_Mandamiento_Judicial("Detalle_de_Delito_Mandamiento_Judicial_", "_" + Detalle_de_Delito_Mandamiento_JudicialinsertRowCurrentIndex);
}

function Detalle_de_Delito_Mandamiento_JudicialClearGridData() {
    Detalle_de_Delito_Mandamiento_JudicialData = [];
    Detalle_de_Delito_Mandamiento_JudicialdeletedItem = [];
    Detalle_de_Delito_Mandamiento_JudicialDataMain = [];
    Detalle_de_Delito_Mandamiento_JudicialDataMainPages = [];
    Detalle_de_Delito_Mandamiento_JudicialnewItemCount = 0;
    Detalle_de_Delito_Mandamiento_JudicialmaxItemIndex = 0;
    $("#Detalle_de_Delito_Mandamiento_JudicialGrid").DataTable().clear();
    $("#Detalle_de_Delito_Mandamiento_JudicialGrid").DataTable().destroy();
}

//Used to Get Registro de Mandamiento Judicial Information
function GetDetalle_de_Delito_Mandamiento_Judicial() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Delito_Mandamiento_JudicialData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Delito_Mandamiento_JudicialData[i].Clave);

        form_data.append('[' + i + '].Delito', Detalle_de_Delito_Mandamiento_JudicialData[i].Delito);
        form_data.append('[' + i + '].Modalidad', Detalle_de_Delito_Mandamiento_JudicialData[i].Modalidad);

        form_data.append('[' + i + '].Removed', Detalle_de_Delito_Mandamiento_JudicialData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Delito_Mandamiento_JudicialInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Delito_Mandamiento_Judicial("Detalle_de_Delito_Mandamiento_JudicialTable", rowIndex)) {
    var prevData = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetData(rowIndex);
    var data = Detalle_de_Delito_Mandamiento_JudicialTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Delito: $('#Detalle_de_Delito_Mandamiento_JudicialDelito').val()
        ,Modalidad: $('#Detalle_de_Delito_Mandamiento_JudicialModalidad').val()

    }

    Detalle_de_Delito_Mandamiento_JudicialTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Delito_Mandamiento_JudicialrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Delito_Mandamiento_Judicial-form').modal({ show: false });
    $('#AddDetalle_de_Delito_Mandamiento_Judicial-form').modal('hide');
    Detalle_de_Delito_Mandamiento_JudicialEditRow(rowIndex);
    Detalle_de_Delito_Mandamiento_JudicialInsertRow(rowIndex);
    //}
}
function Detalle_de_Delito_Mandamiento_JudicialRemoveAddRow(rowIndex) {
    Detalle_de_Delito_Mandamiento_JudicialTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Delito_Mandamiento_Judicial MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Amparo MultiRow
var Detalle_de_AmparocountRowsChecked = 0;

function GetDetalle_de_Amparo_Tipo_de_AmparoName(Id) {
    for (var i = 0; i < Detalle_de_Amparo_Tipo_de_AmparoItems.length; i++) {
        if (Detalle_de_Amparo_Tipo_de_AmparoItems[i].Clave == Id) {
            return Detalle_de_Amparo_Tipo_de_AmparoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Amparo_Tipo_de_AmparoDropDown() {
    var Detalle_de_Amparo_Tipo_de_AmparoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Amparo_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Amparo_Tipo_de_AmparoDropdown);
    if(Detalle_de_Amparo_Tipo_de_AmparoItems != null)
    {
       for (var i = 0; i < Detalle_de_Amparo_Tipo_de_AmparoItems.length; i++) {
           $('<option />', { value: Detalle_de_Amparo_Tipo_de_AmparoItems[i].Clave, text:    Detalle_de_Amparo_Tipo_de_AmparoItems[i].Descripcion }).appendTo(Detalle_de_Amparo_Tipo_de_AmparoDropdown);
       }
    }
    return Detalle_de_Amparo_Tipo_de_AmparoDropdown;
}


function GetDetalle_de_Amparo_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Amparo_EstadoItems.length; i++) {
        if (Detalle_de_Amparo_EstadoItems[i].Clave == Id) {
            return Detalle_de_Amparo_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Amparo_EstadoDropDown() {
    var Detalle_de_Amparo_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Amparo_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Amparo_EstadoDropdown);

    for (var i = 0; i < Detalle_de_Amparo_EstadoItems.length; i++) {
        $('<option />', { value: Detalle_de_Amparo_EstadoItems[i].Clave, text: Detalle_de_Amparo_EstadoItems[i].Nombre }).appendTo(Detalle_de_Amparo_EstadoDropdown);
    }
    return Detalle_de_Amparo_EstadoDropdown;
}
function GetDetalle_de_Amparo_Tipo_de_ResolucionName(Id) {
    for (var i = 0; i < Detalle_de_Amparo_Tipo_de_ResolucionItems.length; i++) {
        if (Detalle_de_Amparo_Tipo_de_ResolucionItems[i].Clave == Id) {
            return Detalle_de_Amparo_Tipo_de_ResolucionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Amparo_Tipo_de_ResolucionDropDown() {
    var Detalle_de_Amparo_Tipo_de_ResolucionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Amparo_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Amparo_Tipo_de_ResolucionDropdown);
    if(Detalle_de_Amparo_Tipo_de_ResolucionItems != null)
    {
       for (var i = 0; i < Detalle_de_Amparo_Tipo_de_ResolucionItems.length; i++) {
           $('<option />', { value: Detalle_de_Amparo_Tipo_de_ResolucionItems[i].Clave, text:    Detalle_de_Amparo_Tipo_de_ResolucionItems[i].Descripcion }).appendTo(Detalle_de_Amparo_Tipo_de_ResolucionDropdown);
       }
    }
    return Detalle_de_Amparo_Tipo_de_ResolucionDropdown;
}


function GetInsertDetalle_de_AmparoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_de_Amparo_Tipo_de_AmparoDropDown()).addClass('Detalle_de_Amparo_Tipo_de_Amparo Tipo_de_Amparo').attr('id', 'Detalle_de_Amparo_Tipo_de_Amparo_' + index).attr('data-field', 'Tipo_de_Amparo').after($.parseHTML(addNew('Detalle_de_Amparo', 'Tipo_de_Amparo', 'Tipo_de_Amparo', 268847)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Amparo_Numero_de_Amparo Numero_de_Amparo').attr('id', 'Detalle_de_Amparo_Numero_de_Amparo_' + index).attr('data-field', 'Numero_de_Amparo');
    columnData[2] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Amparo_Fecha_Amparo Fecha_Amparo').attr('id', 'Detalle_de_Amparo_Fecha_Amparo_' + index).attr('data-field', 'Fecha_Amparo');
    columnData[3] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Amparo_Entidad_que_Emitio_Amparo'))).addClass('Detalle_de_Amparo_Entidad_que_Emitio_Amparo Entidad_que_Emitio_Amparo').attr('id', 'Detalle_de_Amparo_Entidad_que_Emitio_Amparo_' + index).attr('data-field', 'Entidad_que_Emitio_Amparo').after($.parseHTML(addNew('Detalle_de_Amparo', 'Estado', 'Entidad_que_Emitio_Amparo', 268850)));
    columnData[4] = $(GetDetalle_de_Amparo_Tipo_de_ResolucionDropDown()).addClass('Detalle_de_Amparo_Resolucion Resolucion').attr('id', 'Detalle_de_Amparo_Resolucion_' + index).attr('data-field', 'Resolucion').after($.parseHTML(addNew('Detalle_de_Amparo', 'Tipo_de_Resolucion', 'Resolucion', 268851)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_AmparoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Amparo("Detalle_de_Amparo_", "_" + rowIndex)) {
    var iPage = Detalle_de_AmparoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Amparo';
    var prevData = Detalle_de_AmparoTable.fnGetData(rowIndex);
    var data = Detalle_de_AmparoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Amparo:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Amparo:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_Amparo:  data.childNodes[counter++].childNodes[0].value
        , Entidad_que_Emitio_AmparoNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Entidad_que_Emitio_Amparo:  data.childNodes[counter++].childNodes[0].value 	
        ,Resolucion:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_AmparoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_AmparorowCreationGrid(data, newData, rowIndex);
    Detalle_de_AmparoTable.fnPageChange(iPage);
    Detalle_de_AmparocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Amparo("Detalle_de_Amparo_", "_" + rowIndex);
  }
}

function Detalle_de_AmparoCancelRow(rowIndex) {
    var prevData = Detalle_de_AmparoTable.fnGetData(rowIndex);
    var data = Detalle_de_AmparoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_AmparoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_AmparorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_AmparoGrid(Detalle_de_AmparoTable.fnGetData());
    Detalle_de_AmparocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_AmparoFromDataTable() {
    var Detalle_de_AmparoData = [];
    var gridData = Detalle_de_AmparoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_AmparoData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Amparo: gridData[i].Tipo_de_Amparo
                ,Numero_de_Amparo: gridData[i].Numero_de_Amparo
                ,Fecha_Amparo: gridData[i].Fecha_Amparo
                ,Entidad_que_Emitio_Amparo: gridData[i].Entidad_que_Emitio_Amparo
                ,Resolucion: gridData[i].Resolucion

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_AmparoData.length; i++) {
        if (removedDetalle_de_AmparoData[i] != null && removedDetalle_de_AmparoData[i].Clave > 0)
            Detalle_de_AmparoData.push({
                Clave: removedDetalle_de_AmparoData[i].Clave

                ,Tipo_de_Amparo: removedDetalle_de_AmparoData[i].Tipo_de_Amparo
                ,Numero_de_Amparo: removedDetalle_de_AmparoData[i].Numero_de_Amparo
                ,Fecha_Amparo: removedDetalle_de_AmparoData[i].Fecha_Amparo
                ,Entidad_que_Emitio_Amparo: removedDetalle_de_AmparoData[i].Entidad_que_Emitio_Amparo
                ,Resolucion: removedDetalle_de_AmparoData[i].Resolucion

                , Removed: true
            });
    }	

    return Detalle_de_AmparoData;
}

function Detalle_de_AmparoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_AmparoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_AmparocountRowsChecked++;
    var Detalle_de_AmparoRowElement = "Detalle_de_Amparo_" + rowIndex.toString();
    var prevData = Detalle_de_AmparoTable.fnGetData(rowIndexTable );
    var row = Detalle_de_AmparoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Amparo_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_AmparoGetUpdateRowControls(prevData, "Detalle_de_Amparo_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_AmparoRowElement + "')){ Detalle_de_AmparoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_AmparoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_AmparoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_AmparoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_AmparoValidation();
    initiateUIControls();
    $('.Detalle_de_Amparo' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Amparo(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_AmparofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_AmparoTable.fnGetData().length;
    Detalle_de_AmparofnClickAddRow();
    GetAddDetalle_de_AmparoPopup(currentRowIndex, 0);
}

function Detalle_de_AmparoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_AmparoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_AmparoRowElement = "Detalle_de_Amparo_" + rowIndex.toString();
    var prevData = Detalle_de_AmparoTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_AmparoPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_AmparoTipo_de_Amparo').val(prevData.Tipo_de_Amparo);
    $('#Detalle_de_AmparoNumero_de_Amparo').val(prevData.Numero_de_Amparo);
    $('#Detalle_de_AmparoFecha_Amparo').val(prevData.Fecha_Amparo);
    $('#dvDetalle_de_AmparoEntidad_que_Emitio_Amparo').html($($.parseHTML(GetGridAutoComplete(prevData.Entidad_que_Emitio_Amparo.label,'AutoCompleteEntidad_que_Emitio_Amparo'))).addClass('Detalle_de_Amparo_Entidad_que_Emitio_Amparo'));
    $('#Detalle_de_AmparoResolucion').val(prevData.Resolucion);

    initiateUIControls();







}

function Detalle_de_AmparoAddInsertRow() {
    if (Detalle_de_AmparoinsertRowCurrentIndex < 1)
    {
        Detalle_de_AmparoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Amparo: ""
        ,Numero_de_Amparo: ""
        ,Fecha_Amparo: ""
        ,Entidad_que_Emitio_Amparo: ""
        ,Resolucion: ""

    }
}

function Detalle_de_AmparofnClickAddRow() {
    Detalle_de_AmparocountRowsChecked++;
    Detalle_de_AmparoTable.fnAddData(Detalle_de_AmparoAddInsertRow(), true);
    Detalle_de_AmparoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_AmparoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_AmparoGrid tbody tr:nth-of-type(' + (Detalle_de_AmparoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Amparo("Detalle_de_Amparo_", "_" + Detalle_de_AmparoinsertRowCurrentIndex);
}

function Detalle_de_AmparoClearGridData() {
    Detalle_de_AmparoData = [];
    Detalle_de_AmparodeletedItem = [];
    Detalle_de_AmparoDataMain = [];
    Detalle_de_AmparoDataMainPages = [];
    Detalle_de_AmparonewItemCount = 0;
    Detalle_de_AmparomaxItemIndex = 0;
    $("#Detalle_de_AmparoGrid").DataTable().clear();
    $("#Detalle_de_AmparoGrid").DataTable().destroy();
}

//Used to Get Registro de Mandamiento Judicial Information
function GetDetalle_de_Amparo() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_AmparoData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_AmparoData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Amparo', Detalle_de_AmparoData[i].Tipo_de_Amparo);
        form_data.append('[' + i + '].Numero_de_Amparo', Detalle_de_AmparoData[i].Numero_de_Amparo);
        form_data.append('[' + i + '].Fecha_Amparo', Detalle_de_AmparoData[i].Fecha_Amparo);
        form_data.append('[' + i + '].Entidad_que_Emitio_Amparo', Detalle_de_AmparoData[i].Entidad_que_Emitio_Amparo);
        form_data.append('[' + i + '].Resolucion', Detalle_de_AmparoData[i].Resolucion);

        form_data.append('[' + i + '].Removed', Detalle_de_AmparoData[i].Removed);
    }
    return form_data;
}
function Detalle_de_AmparoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Amparo("Detalle_de_AmparoTable", rowIndex)) {
    var prevData = Detalle_de_AmparoTable.fnGetData(rowIndex);
    var data = Detalle_de_AmparoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Amparo: $('#Detalle_de_AmparoTipo_de_Amparo').val()
        ,Numero_de_Amparo: $('#Detalle_de_AmparoNumero_de_Amparo').val()
        ,Fecha_Amparo: $('#Detalle_de_AmparoFecha_Amparo').val()
        ,Entidad_que_Emitio_Amparo: $('#Detalle_de_AmparoEntidad_que_Emitio_Amparo').val()
        ,Resolucion: $('#Detalle_de_AmparoResolucion').val()

    }

    Detalle_de_AmparoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_AmparorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Amparo-form').modal({ show: false });
    $('#AddDetalle_de_Amparo-form').modal('hide');
    Detalle_de_AmparoEditRow(rowIndex);
    Detalle_de_AmparoInsertRow(rowIndex);
    //}
}
function Detalle_de_AmparoRemoveAddRow(rowIndex) {
    Detalle_de_AmparoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Amparo MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Fotos MultiRow
var Detalle_de_FotoscountRowsChecked = 0;






function GetInsertDetalle_de_FotosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetFileUploader())).addClass('Detalle_de_Fotos_Foto_Perfil_Izquierdo_FileUpload Foto_Perfil_Izquierdo').attr('id', 'Detalle_de_Fotos_Foto_Perfil_Izquierdo_' + index).attr('data-field', 'Foto_Perfil_Izquierdo');
    columnData[1] = $($.parseHTML(GetFileUploader())).addClass('Detalle_de_Fotos_Foto_Perfil_Derecho_FileUpload Foto_Perfil_Derecho').attr('id', 'Detalle_de_Fotos_Foto_Perfil_Derecho_' + index).attr('data-field', 'Foto_Perfil_Derecho');
    columnData[2] = $($.parseHTML(GetFileUploader())).addClass('Detalle_de_Fotos_Foto_de_Frente_FileUpload Foto_de_Frente').attr('id', 'Detalle_de_Fotos_Foto_de_Frente_' + index).attr('data-field', 'Foto_de_Frente');


    initiateUIControls();
    return columnData;
}

function Detalle_de_FotosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Fotos("Detalle_de_Fotos_", "_" + rowIndex)) {
    var iPage = Detalle_de_FotosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Fotos';
    var prevData = Detalle_de_FotosTable.fnGetData(rowIndex);
    var data = Detalle_de_FotosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Foto_Perfil_IzquierdoFileInfo: ($('#' + nameOfGrid + 'Grid .Foto_Perfil_IzquierdoHeader').css('display') != 'none') ? { 
             FileName: prevData.Foto_Perfil_IzquierdoFileInfo != null && prevData.Foto_Perfil_IzquierdoFileInfo.FileName != null && prevData.Foto_Perfil_IzquierdoFileInfo.FileName != ''? prevData.Foto_Perfil_IzquierdoFileInfo.FileName : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : ''),              
			 FileId:   prevData.Foto_Perfil_IzquierdoFileInfo != null && prevData.Foto_Perfil_IzquierdoFileInfo.FileName != null && prevData.Foto_Perfil_IzquierdoFileInfo.FileName != '' ? prevData.Foto_Perfil_IzquierdoFileInfo.FileId :  prevData.Foto_Perfil_IzquierdoFileInfo != null && prevData.Foto_Perfil_IzquierdoFileInfo.FileId != '' && prevData.Foto_Perfil_IzquierdoFileInfo.FileId != undefined ? prevData.Foto_Perfil_IzquierdoFileInfo.FileId : '0',
             FileSize: prevData.Foto_Perfil_IzquierdoFileInfo != null && prevData.Foto_Perfil_IzquierdoFileInfo.FileName != null ? prevData.Foto_Perfil_IzquierdoFileInfo.FileSize : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : '') 
         } : ''
        ,Foto_Perfil_IzquierdoDetail: (data.childNodes[counter] != 'undefined' && data.childNodes[counter].childNodes[0].childNodes.length == 0) ? data.childNodes[counter++].childNodes[0] : prevData.Foto_Perfil_IzquierdoDetail
        ,Foto_Perfil_DerechoFileInfo: ($('#' + nameOfGrid + 'Grid .Foto_Perfil_DerechoHeader').css('display') != 'none') ? { 
             FileName: prevData.Foto_Perfil_DerechoFileInfo != null && prevData.Foto_Perfil_DerechoFileInfo.FileName != null && prevData.Foto_Perfil_DerechoFileInfo.FileName != ''? prevData.Foto_Perfil_DerechoFileInfo.FileName : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : ''),              
			 FileId:   prevData.Foto_Perfil_DerechoFileInfo != null && prevData.Foto_Perfil_DerechoFileInfo.FileName != null && prevData.Foto_Perfil_DerechoFileInfo.FileName != '' ? prevData.Foto_Perfil_DerechoFileInfo.FileId :  prevData.Foto_Perfil_DerechoFileInfo != null && prevData.Foto_Perfil_DerechoFileInfo.FileId != '' && prevData.Foto_Perfil_DerechoFileInfo.FileId != undefined ? prevData.Foto_Perfil_DerechoFileInfo.FileId : '0',
             FileSize: prevData.Foto_Perfil_DerechoFileInfo != null && prevData.Foto_Perfil_DerechoFileInfo.FileName != null ? prevData.Foto_Perfil_DerechoFileInfo.FileSize : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : '') 
         } : ''
        ,Foto_Perfil_DerechoDetail: (data.childNodes[counter] != 'undefined' && data.childNodes[counter].childNodes[0].childNodes.length == 0) ? data.childNodes[counter++].childNodes[0] : prevData.Foto_Perfil_DerechoDetail
        ,Foto_de_FrenteFileInfo: ($('#' + nameOfGrid + 'Grid .Foto_de_FrenteHeader').css('display') != 'none') ? { 
             FileName: prevData.Foto_de_FrenteFileInfo != null && prevData.Foto_de_FrenteFileInfo.FileName != null && prevData.Foto_de_FrenteFileInfo.FileName != ''? prevData.Foto_de_FrenteFileInfo.FileName : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : ''),              
			 FileId:   prevData.Foto_de_FrenteFileInfo != null && prevData.Foto_de_FrenteFileInfo.FileName != null && prevData.Foto_de_FrenteFileInfo.FileName != '' ? prevData.Foto_de_FrenteFileInfo.FileId :  prevData.Foto_de_FrenteFileInfo != null && prevData.Foto_de_FrenteFileInfo.FileId != '' && prevData.Foto_de_FrenteFileInfo.FileId != undefined ? prevData.Foto_de_FrenteFileInfo.FileId : '0',
             FileSize: prevData.Foto_de_FrenteFileInfo != null && prevData.Foto_de_FrenteFileInfo.FileName != null ? prevData.Foto_de_FrenteFileInfo.FileSize : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : '') 
         } : ''
        ,Foto_de_FrenteDetail: (data.childNodes[counter] != 'undefined' && data.childNodes[counter].childNodes[0].childNodes.length == 0) ? data.childNodes[counter++].childNodes[0] : prevData.Foto_de_FrenteDetail

    }
    Detalle_de_FotosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_FotosrowCreationGrid(data, newData, rowIndex);
    Detalle_de_FotosTable.fnPageChange(iPage);
    Detalle_de_FotoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Fotos("Detalle_de_Fotos_", "_" + rowIndex);
  }
}

function Detalle_de_FotosCancelRow(rowIndex) {
    var prevData = Detalle_de_FotosTable.fnGetData(rowIndex);
    var data = Detalle_de_FotosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_FotosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_FotosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_FotosGrid(Detalle_de_FotosTable.fnGetData());
    Detalle_de_FotoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_FotosFromDataTable() {
    var Detalle_de_FotosData = [];
    var gridData = Detalle_de_FotosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_FotosData.push({
                Clave: gridData[i].Clave

                ,Foto_Perfil_IzquierdoInfo: {
                    FileName: gridData[i].Foto_Perfil_IzquierdoFileInfo.FileName, FileId: gridData[i].Foto_Perfil_IzquierdoFileInfo.FileId, FileSize: gridData[i].Foto_Perfil_IzquierdoFileInfo.FileSize,
                    Control: gridData[i].Foto_Perfil_IzquierdoDetail != null && gridData[i].Foto_Perfil_IzquierdoDetail.files != null && gridData[i].Foto_Perfil_IzquierdoDetail.files.length > 0 ? gridData[i].Foto_Perfil_IzquierdoDetail.files[0] : null,
                    Foto_Perfil_IzquierdoRemoveFile: gridData[i].Foto_Perfil_IzquierdoDetail != null
                }
                ,Foto_Perfil_DerechoInfo: {
                    FileName: gridData[i].Foto_Perfil_DerechoFileInfo.FileName, FileId: gridData[i].Foto_Perfil_DerechoFileInfo.FileId, FileSize: gridData[i].Foto_Perfil_DerechoFileInfo.FileSize,
                    Control: gridData[i].Foto_Perfil_DerechoDetail != null && gridData[i].Foto_Perfil_DerechoDetail.files != null && gridData[i].Foto_Perfil_DerechoDetail.files.length > 0 ? gridData[i].Foto_Perfil_DerechoDetail.files[0] : null,
                    Foto_Perfil_DerechoRemoveFile: gridData[i].Foto_Perfil_DerechoDetail != null
                }
                ,Foto_de_FrenteInfo: {
                    FileName: gridData[i].Foto_de_FrenteFileInfo.FileName, FileId: gridData[i].Foto_de_FrenteFileInfo.FileId, FileSize: gridData[i].Foto_de_FrenteFileInfo.FileSize,
                    Control: gridData[i].Foto_de_FrenteDetail != null && gridData[i].Foto_de_FrenteDetail.files != null && gridData[i].Foto_de_FrenteDetail.files.length > 0 ? gridData[i].Foto_de_FrenteDetail.files[0] : null,
                    Foto_de_FrenteRemoveFile: gridData[i].Foto_de_FrenteDetail != null
                }

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_FotosData.length; i++) {
        if (removedDetalle_de_FotosData[i] != null && removedDetalle_de_FotosData[i].Clave > 0)
            Detalle_de_FotosData.push({
                Clave: removedDetalle_de_FotosData[i].Clave

                ,Foto_Perfil_IzquierdoInfo: {
                    FileName: removedDetalle_de_FotosData[i].Foto_Perfil_IzquierdoFileInfo.FileName, 
                    FileId: removedDetalle_de_FotosData[i].Foto_Perfil_IzquierdoFileInfo.FileId, 
                    FileSize: removedDetalle_de_FotosData[i].Foto_Perfil_IzquierdoFileInfo.FileSize,
                    Control: removedDetalle_de_FotosData[i].Foto_Perfil_IzquierdoDetail != null && removedDetalle_de_FotosData[i].Foto_Perfil_IzquierdoDetail.files.length > 0 ? removedDetalle_de_FotosData[i].Foto_Perfil_IzquierdoDetail.files[0] : null,
                    Foto_Perfil_IzquierdoRemoveFile: removedDetalle_de_FotosData[i].Foto_Perfil_IzquierdoDetail != null
                }
                ,Foto_Perfil_DerechoInfo: {
                    FileName: removedDetalle_de_FotosData[i].Foto_Perfil_DerechoFileInfo.FileName, 
                    FileId: removedDetalle_de_FotosData[i].Foto_Perfil_DerechoFileInfo.FileId, 
                    FileSize: removedDetalle_de_FotosData[i].Foto_Perfil_DerechoFileInfo.FileSize,
                    Control: removedDetalle_de_FotosData[i].Foto_Perfil_DerechoDetail != null && removedDetalle_de_FotosData[i].Foto_Perfil_DerechoDetail.files.length > 0 ? removedDetalle_de_FotosData[i].Foto_Perfil_DerechoDetail.files[0] : null,
                    Foto_Perfil_DerechoRemoveFile: removedDetalle_de_FotosData[i].Foto_Perfil_DerechoDetail != null
                }
                ,Foto_de_FrenteInfo: {
                    FileName: removedDetalle_de_FotosData[i].Foto_de_FrenteFileInfo.FileName, 
                    FileId: removedDetalle_de_FotosData[i].Foto_de_FrenteFileInfo.FileId, 
                    FileSize: removedDetalle_de_FotosData[i].Foto_de_FrenteFileInfo.FileSize,
                    Control: removedDetalle_de_FotosData[i].Foto_de_FrenteDetail != null && removedDetalle_de_FotosData[i].Foto_de_FrenteDetail.files.length > 0 ? removedDetalle_de_FotosData[i].Foto_de_FrenteDetail.files[0] : null,
                    Foto_de_FrenteRemoveFile: removedDetalle_de_FotosData[i].Foto_de_FrenteDetail != null
                }

                , Removed: true
            });
    }	

    return Detalle_de_FotosData;
}

function Detalle_de_FotosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_FotosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_FotoscountRowsChecked++;
    var Detalle_de_FotosRowElement = "Detalle_de_Fotos_" + rowIndex.toString();
    var prevData = Detalle_de_FotosTable.fnGetData(rowIndexTable );
    var row = Detalle_de_FotosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Fotos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_FotosGetUpdateRowControls(prevData, "Detalle_de_Fotos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_FotosRowElement + "')){ Detalle_de_FotosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_FotosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_FotosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_FotosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_FotosValidation();
    initiateUIControls();
    $('.Detalle_de_Fotos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Fotos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_FotosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_FotosTable.fnGetData().length;
    Detalle_de_FotosfnClickAddRow();
    GetAddDetalle_de_FotosPopup(currentRowIndex, 0);
}

function Detalle_de_FotosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_FotosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_FotosRowElement = "Detalle_de_Fotos_" + rowIndex.toString();
    var prevData = Detalle_de_FotosTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_FotosPopup(rowIndex, 1, prevData.Clave);





    initiateUIControls();

    $('#existingFoto_Perfil_Izquierdo').html(prevData.Foto_Perfil_IzquierdoFileDetail == null && (prevData.Foto_Perfil_IzquierdoFileInfo.FileId == null || prevData.Foto_Perfil_IzquierdoFileInfo.FileId <= 0) ? $.parseHTML(GetFileUploader()) : GetFileInfo(prevData.Foto_Perfil_IzquierdoFileInfo, prevData.Foto_Perfil_IzquierdoFileDetail));
    $('#existingFoto_Perfil_Derecho').html(prevData.Foto_Perfil_DerechoFileDetail == null && (prevData.Foto_Perfil_DerechoFileInfo.FileId == null || prevData.Foto_Perfil_DerechoFileInfo.FileId <= 0) ? $.parseHTML(GetFileUploader()) : GetFileInfo(prevData.Foto_Perfil_DerechoFileInfo, prevData.Foto_Perfil_DerechoFileDetail));
    $('#existingFoto_de_Frente').html(prevData.Foto_de_FrenteFileDetail == null && (prevData.Foto_de_FrenteFileInfo.FileId == null || prevData.Foto_de_FrenteFileInfo.FileId <= 0) ? $.parseHTML(GetFileUploader()) : GetFileInfo(prevData.Foto_de_FrenteFileInfo, prevData.Foto_de_FrenteFileDetail));

}

function Detalle_de_FotosAddInsertRow() {
    if (Detalle_de_FotosinsertRowCurrentIndex < 1)
    {
        Detalle_de_FotosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Foto_Perfil_IzquierdoFileInfo: ""
        ,Foto_Perfil_DerechoFileInfo: ""
        ,Foto_de_FrenteFileInfo: ""

    }
}

function Detalle_de_FotosfnClickAddRow() {
    Detalle_de_FotoscountRowsChecked++;
    Detalle_de_FotosTable.fnAddData(Detalle_de_FotosAddInsertRow(), true);
    Detalle_de_FotosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_FotosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_FotosGrid tbody tr:nth-of-type(' + (Detalle_de_FotosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Fotos("Detalle_de_Fotos_", "_" + Detalle_de_FotosinsertRowCurrentIndex);
}

function Detalle_de_FotosClearGridData() {
    Detalle_de_FotosData = [];
    Detalle_de_FotosdeletedItem = [];
    Detalle_de_FotosDataMain = [];
    Detalle_de_FotosDataMainPages = [];
    Detalle_de_FotosnewItemCount = 0;
    Detalle_de_FotosmaxItemIndex = 0;
    $("#Detalle_de_FotosGrid").DataTable().clear();
    $("#Detalle_de_FotosGrid").DataTable().destroy();
}

//Used to Get Registro de Mandamiento Judicial Information
function GetDetalle_de_Fotos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_FotosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_FotosData[i].Clave);

        form_data.append('[' + i + '].Foto_Perfil_IzquierdoInfo.FileId', Detalle_de_FotosData[i].Foto_Perfil_IzquierdoInfo.FileId);
        form_data.append('[' + i + '].Foto_Perfil_IzquierdoInfo.FileName', Detalle_de_FotosData[i].Foto_Perfil_IzquierdoInfo.FileName);
        form_data.append('[' + i + '].Foto_Perfil_IzquierdoInfo.FileSize', Detalle_de_FotosData[i].Foto_Perfil_IzquierdoInfo.FileSize);
        form_data.append('[' + i + '].Foto_Perfil_IzquierdoInfo.Control', Detalle_de_FotosData[i].Foto_Perfil_IzquierdoInfo.Control);
        form_data.append('[' + i + '].Foto_Perfil_IzquierdoInfo.RemoveFile', Detalle_de_FotosData[i].Foto_Perfil_IzquierdoInfo.ArchivoRemoveFile);
        form_data.append('[' + i + '].Foto_Perfil_DerechoInfo.FileId', Detalle_de_FotosData[i].Foto_Perfil_DerechoInfo.FileId);
        form_data.append('[' + i + '].Foto_Perfil_DerechoInfo.FileName', Detalle_de_FotosData[i].Foto_Perfil_DerechoInfo.FileName);
        form_data.append('[' + i + '].Foto_Perfil_DerechoInfo.FileSize', Detalle_de_FotosData[i].Foto_Perfil_DerechoInfo.FileSize);
        form_data.append('[' + i + '].Foto_Perfil_DerechoInfo.Control', Detalle_de_FotosData[i].Foto_Perfil_DerechoInfo.Control);
        form_data.append('[' + i + '].Foto_Perfil_DerechoInfo.RemoveFile', Detalle_de_FotosData[i].Foto_Perfil_DerechoInfo.ArchivoRemoveFile);
        form_data.append('[' + i + '].Foto_de_FrenteInfo.FileId', Detalle_de_FotosData[i].Foto_de_FrenteInfo.FileId);
        form_data.append('[' + i + '].Foto_de_FrenteInfo.FileName', Detalle_de_FotosData[i].Foto_de_FrenteInfo.FileName);
        form_data.append('[' + i + '].Foto_de_FrenteInfo.FileSize', Detalle_de_FotosData[i].Foto_de_FrenteInfo.FileSize);
        form_data.append('[' + i + '].Foto_de_FrenteInfo.Control', Detalle_de_FotosData[i].Foto_de_FrenteInfo.Control);
        form_data.append('[' + i + '].Foto_de_FrenteInfo.RemoveFile', Detalle_de_FotosData[i].Foto_de_FrenteInfo.ArchivoRemoveFile);

        form_data.append('[' + i + '].Removed', Detalle_de_FotosData[i].Removed);
    }
    return form_data;
}
function Detalle_de_FotosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Fotos("Detalle_de_FotosTable", rowIndex)) {
    var prevData = Detalle_de_FotosTable.fnGetData(rowIndex);
    var data = Detalle_de_FotosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Foto_Perfil_IzquierdoFileInfo: { Foto_Perfil_IzquierdoFileName: prevData.Foto_Perfil_IzquierdoFileInfo.FileName, Foto_Perfil_IzquierdoFileId: prevData.Foto_Perfil_IzquierdoFileInfo.FileId, Foto_Perfil_IzquierdoFileSize: prevData.Foto_Perfil_IzquierdoFileInfo.FileSize }
        ,Foto_Perfil_IzquierdoFileDetail: $('#Foto_Perfil_Izquierdo').find('label').length == 0 ? $('#Foto_Perfil_IzquierdoFileInfoPop')[0] : prevData.Foto_Perfil_IzquierdoFileDetail
        ,Foto_Perfil_DerechoFileInfo: { Foto_Perfil_DerechoFileName: prevData.Foto_Perfil_DerechoFileInfo.FileName, Foto_Perfil_DerechoFileId: prevData.Foto_Perfil_DerechoFileInfo.FileId, Foto_Perfil_DerechoFileSize: prevData.Foto_Perfil_DerechoFileInfo.FileSize }
        ,Foto_Perfil_DerechoFileDetail: $('#Foto_Perfil_Derecho').find('label').length == 0 ? $('#Foto_Perfil_DerechoFileInfoPop')[0] : prevData.Foto_Perfil_DerechoFileDetail
        ,Foto_de_FrenteFileInfo: { Foto_de_FrenteFileName: prevData.Foto_de_FrenteFileInfo.FileName, Foto_de_FrenteFileId: prevData.Foto_de_FrenteFileInfo.FileId, Foto_de_FrenteFileSize: prevData.Foto_de_FrenteFileInfo.FileSize }
        ,Foto_de_FrenteFileDetail: $('#Foto_de_Frente').find('label').length == 0 ? $('#Foto_de_FrenteFileInfoPop')[0] : prevData.Foto_de_FrenteFileDetail

    }

    Detalle_de_FotosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_FotosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Fotos-form').modal({ show: false });
    $('#AddDetalle_de_Fotos-form').modal('hide');
    Detalle_de_FotosEditRow(rowIndex);
    Detalle_de_FotosInsertRow(rowIndex);
    //}
}
function Detalle_de_FotosRemoveAddRow(rowIndex) {
    Detalle_de_FotosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Fotos MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Documentos_Mandamiento_Judicial MultiRow
var Detalle_de_Documentos_Mandamiento_JudicialcountRowsChecked = 0;




function GetInsertDetalle_de_Documentos_Mandamiento_JudicialRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetFileUploader())).addClass('Detalle_de_Documentos_Mandamiento_Judicial_Documentos_FileUpload Documentos').attr('id', 'Detalle_de_Documentos_Mandamiento_Judicial_Documentos_' + index).attr('data-field', 'Documentos');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Documentos_Mandamiento_JudicialInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Documentos_Mandamiento_Judicial("Detalle_de_Documentos_Mandamiento_Judicial_", "_" + rowIndex)) {
    var iPage = Detalle_de_Documentos_Mandamiento_JudicialTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Documentos_Mandamiento_Judicial';
    var prevData = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetData(rowIndex);
    var data = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,DocumentosFileInfo: ($('#' + nameOfGrid + 'Grid .DocumentosHeader').css('display') != 'none') ? { 
             FileName: prevData.DocumentosFileInfo != null && prevData.DocumentosFileInfo.FileName != null && prevData.DocumentosFileInfo.FileName != ''? prevData.DocumentosFileInfo.FileName : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : ''),              
			 FileId:   prevData.DocumentosFileInfo != null && prevData.DocumentosFileInfo.FileName != null && prevData.DocumentosFileInfo.FileName != '' ? prevData.DocumentosFileInfo.FileId :  prevData.DocumentosFileInfo != null && prevData.DocumentosFileInfo.FileId != '' && prevData.DocumentosFileInfo.FileId != undefined ? prevData.DocumentosFileInfo.FileId : '0',
             FileSize: prevData.DocumentosFileInfo != null && prevData.DocumentosFileInfo.FileName != null ? prevData.DocumentosFileInfo.FileSize : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : '') 
         } : ''
        ,DocumentosDetail: (data.childNodes[counter] != 'undefined' && data.childNodes[counter].childNodes[0].childNodes.length == 0) ? data.childNodes[counter++].childNodes[0] : prevData.DocumentosDetail

    }
    Detalle_de_Documentos_Mandamiento_JudicialTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Documentos_Mandamiento_JudicialrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Documentos_Mandamiento_JudicialTable.fnPageChange(iPage);
    Detalle_de_Documentos_Mandamiento_JudicialcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Documentos_Mandamiento_Judicial("Detalle_de_Documentos_Mandamiento_Judicial_", "_" + rowIndex);
  }
}

function Detalle_de_Documentos_Mandamiento_JudicialCancelRow(rowIndex) {
    var prevData = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetData(rowIndex);
    var data = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Documentos_Mandamiento_JudicialTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Documentos_Mandamiento_JudicialrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Documentos_Mandamiento_JudicialGrid(Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetData());
    Detalle_de_Documentos_Mandamiento_JudicialcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Documentos_Mandamiento_JudicialFromDataTable() {
    var Detalle_de_Documentos_Mandamiento_JudicialData = [];
    var gridData = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Documentos_Mandamiento_JudicialData.push({
                Clave: gridData[i].Clave

                ,DocumentosInfo: {
                    FileName: gridData[i].DocumentosFileInfo.FileName, FileId: gridData[i].DocumentosFileInfo.FileId, FileSize: gridData[i].DocumentosFileInfo.FileSize,
                    Control: gridData[i].DocumentosDetail != null && gridData[i].DocumentosDetail.files != null && gridData[i].DocumentosDetail.files.length > 0 ? gridData[i].DocumentosDetail.files[0] : null,
                    DocumentosRemoveFile: gridData[i].DocumentosDetail != null
                }

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Documentos_Mandamiento_JudicialData.length; i++) {
        if (removedDetalle_de_Documentos_Mandamiento_JudicialData[i] != null && removedDetalle_de_Documentos_Mandamiento_JudicialData[i].Clave > 0)
            Detalle_de_Documentos_Mandamiento_JudicialData.push({
                Clave: removedDetalle_de_Documentos_Mandamiento_JudicialData[i].Clave

                ,DocumentosInfo: {
                    FileName: removedDetalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosFileInfo.FileName, 
                    FileId: removedDetalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosFileInfo.FileId, 
                    FileSize: removedDetalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosFileInfo.FileSize,
                    Control: removedDetalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosDetail != null && removedDetalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosDetail.files.length > 0 ? removedDetalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosDetail.files[0] : null,
                    DocumentosRemoveFile: removedDetalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosDetail != null
                }

                , Removed: true
            });
    }	

    return Detalle_de_Documentos_Mandamiento_JudicialData;
}

function Detalle_de_Documentos_Mandamiento_JudicialEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Documentos_Mandamiento_JudicialcountRowsChecked++;
    var Detalle_de_Documentos_Mandamiento_JudicialRowElement = "Detalle_de_Documentos_Mandamiento_Judicial_" + rowIndex.toString();
    var prevData = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Documentos_Mandamiento_Judicial_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Documentos_Mandamiento_JudicialGetUpdateRowControls(prevData, "Detalle_de_Documentos_Mandamiento_Judicial_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Documentos_Mandamiento_JudicialRowElement + "')){ Detalle_de_Documentos_Mandamiento_JudicialInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Documentos_Mandamiento_JudicialCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Documentos_Mandamiento_JudicialGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Documentos_Mandamiento_JudicialGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Documentos_Mandamiento_JudicialValidation();
    initiateUIControls();
    $('.Detalle_de_Documentos_Mandamiento_Judicial' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Documentos_Mandamiento_JudicialfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetData().length;
    Detalle_de_Documentos_Mandamiento_JudicialfnClickAddRow();
    GetAddDetalle_de_Documentos_Mandamiento_JudicialPopup(currentRowIndex, 0);
}

function Detalle_de_Documentos_Mandamiento_JudicialEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Documentos_Mandamiento_JudicialRowElement = "Detalle_de_Documentos_Mandamiento_Judicial_" + rowIndex.toString();
    var prevData = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Documentos_Mandamiento_JudicialPopup(rowIndex, 1, prevData.Clave);



    initiateUIControls();

    $('#existingDocumentos').html(prevData.DocumentosFileDetail == null && (prevData.DocumentosFileInfo.FileId == null || prevData.DocumentosFileInfo.FileId <= 0) ? $.parseHTML(GetFileUploader()) : GetFileInfo(prevData.DocumentosFileInfo, prevData.DocumentosFileDetail));

}

function Detalle_de_Documentos_Mandamiento_JudicialAddInsertRow() {
    if (Detalle_de_Documentos_Mandamiento_JudicialinsertRowCurrentIndex < 1)
    {
        Detalle_de_Documentos_Mandamiento_JudicialinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,DocumentosFileInfo: ""

    }
}

function Detalle_de_Documentos_Mandamiento_JudicialfnClickAddRow() {
    Detalle_de_Documentos_Mandamiento_JudicialcountRowsChecked++;
    Detalle_de_Documentos_Mandamiento_JudicialTable.fnAddData(Detalle_de_Documentos_Mandamiento_JudicialAddInsertRow(), true);
    Detalle_de_Documentos_Mandamiento_JudicialTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Documentos_Mandamiento_JudicialGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Documentos_Mandamiento_JudicialGrid tbody tr:nth-of-type(' + (Detalle_de_Documentos_Mandamiento_JudicialinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Documentos_Mandamiento_Judicial("Detalle_de_Documentos_Mandamiento_Judicial_", "_" + Detalle_de_Documentos_Mandamiento_JudicialinsertRowCurrentIndex);
}

function Detalle_de_Documentos_Mandamiento_JudicialClearGridData() {
    Detalle_de_Documentos_Mandamiento_JudicialData = [];
    Detalle_de_Documentos_Mandamiento_JudicialdeletedItem = [];
    Detalle_de_Documentos_Mandamiento_JudicialDataMain = [];
    Detalle_de_Documentos_Mandamiento_JudicialDataMainPages = [];
    Detalle_de_Documentos_Mandamiento_JudicialnewItemCount = 0;
    Detalle_de_Documentos_Mandamiento_JudicialmaxItemIndex = 0;
    $("#Detalle_de_Documentos_Mandamiento_JudicialGrid").DataTable().clear();
    $("#Detalle_de_Documentos_Mandamiento_JudicialGrid").DataTable().destroy();
}

//Used to Get Registro de Mandamiento Judicial Information
function GetDetalle_de_Documentos_Mandamiento_Judicial() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Documentos_Mandamiento_JudicialData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Documentos_Mandamiento_JudicialData[i].Clave);

        form_data.append('[' + i + '].DocumentosInfo.FileId', Detalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosInfo.FileId);
        form_data.append('[' + i + '].DocumentosInfo.FileName', Detalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosInfo.FileName);
        form_data.append('[' + i + '].DocumentosInfo.FileSize', Detalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosInfo.FileSize);
        form_data.append('[' + i + '].DocumentosInfo.Control', Detalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosInfo.Control);
        form_data.append('[' + i + '].DocumentosInfo.RemoveFile', Detalle_de_Documentos_Mandamiento_JudicialData[i].DocumentosInfo.ArchivoRemoveFile);

        form_data.append('[' + i + '].Removed', Detalle_de_Documentos_Mandamiento_JudicialData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Documentos_Mandamiento_JudicialInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Documentos_Mandamiento_Judicial("Detalle_de_Documentos_Mandamiento_JudicialTable", rowIndex)) {
    var prevData = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetData(rowIndex);
    var data = Detalle_de_Documentos_Mandamiento_JudicialTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,DocumentosFileInfo: { DocumentosFileName: prevData.DocumentosFileInfo.FileName, DocumentosFileId: prevData.DocumentosFileInfo.FileId, DocumentosFileSize: prevData.DocumentosFileInfo.FileSize }
        ,DocumentosFileDetail: $('#Documentos').find('label').length == 0 ? $('#DocumentosFileInfoPop')[0] : prevData.DocumentosFileDetail

    }

    Detalle_de_Documentos_Mandamiento_JudicialTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Documentos_Mandamiento_JudicialrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Documentos_Mandamiento_Judicial-form').modal({ show: false });
    $('#AddDetalle_de_Documentos_Mandamiento_Judicial-form').modal('hide');
    Detalle_de_Documentos_Mandamiento_JudicialEditRow(rowIndex);
    Detalle_de_Documentos_Mandamiento_JudicialInsertRow(rowIndex);
    //}
}
function Detalle_de_Documentos_Mandamiento_JudicialRemoveAddRow(rowIndex) {
    Detalle_de_Documentos_Mandamiento_JudicialTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Documentos_Mandamiento_Judicial MultiRow


$(function () {
    function Detalle_de_DomicilioinitializeMainArray(totalCount) {
        if (Detalle_de_DomicilioDataMain.length != totalCount && !Detalle_de_DomicilioDataMainInitialized) {
            Detalle_de_DomicilioDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_DomicilioDataMain[i] = null;
            }
        }
    }
    function Detalle_de_DomicilioremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_DomiciliodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_DomicilioDataMain.length; i++) {
                if (Detalle_de_DomicilioDataMain[i] != null && Detalle_de_DomicilioDataMain[i].Id == Detalle_de_DomiciliodeletedItem[j]) {
                    hDetalle_de_DomicilioDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_DomiciliocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_DomicilioDataMain.length; i++) {
            data[i] = Detalle_de_DomicilioDataMain[i];

        }
        return data;
    }
    function Detalle_de_DomiciliogetNewResult() {
        var newData = copyMainDetalle_de_DomicilioArray();

        for (var i = 0; i < Detalle_de_DomicilioData.length; i++) {
            if (Detalle_de_DomicilioData[i].Removed == null || Detalle_de_DomicilioData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_DomicilioData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_DomiciliopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_DomicilioDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_DomicilioDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_telefonoinitializeMainArray(totalCount) {
        if (Detalle_de_telefonoDataMain.length != totalCount && !Detalle_de_telefonoDataMainInitialized) {
            Detalle_de_telefonoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_telefonoDataMain[i] = null;
            }
        }
    }
    function Detalle_de_telefonoremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_telefonodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_telefonoDataMain.length; i++) {
                if (Detalle_de_telefonoDataMain[i] != null && Detalle_de_telefonoDataMain[i].Id == Detalle_de_telefonodeletedItem[j]) {
                    hDetalle_de_telefonoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_telefonocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_telefonoDataMain.length; i++) {
            data[i] = Detalle_de_telefonoDataMain[i];

        }
        return data;
    }
    function Detalle_de_telefonogetNewResult() {
        var newData = copyMainDetalle_de_telefonoArray();

        for (var i = 0; i < Detalle_de_telefonoData.length; i++) {
            if (Detalle_de_telefonoData[i].Removed == null || Detalle_de_telefonoData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_telefonoData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_telefonopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_telefonoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_telefonoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Otro_NombreinitializeMainArray(totalCount) {
        if (Detalle_de_Otro_NombreDataMain.length != totalCount && !Detalle_de_Otro_NombreDataMainInitialized) {
            Detalle_de_Otro_NombreDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Otro_NombreDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Otro_NombreremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Otro_NombredeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Otro_NombreDataMain.length; i++) {
                if (Detalle_de_Otro_NombreDataMain[i] != null && Detalle_de_Otro_NombreDataMain[i].Id == Detalle_de_Otro_NombredeletedItem[j]) {
                    hDetalle_de_Otro_NombreDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Otro_NombrecopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Otro_NombreDataMain.length; i++) {
            data[i] = Detalle_de_Otro_NombreDataMain[i];

        }
        return data;
    }
    function Detalle_de_Otro_NombregetNewResult() {
        var newData = copyMainDetalle_de_Otro_NombreArray();

        for (var i = 0; i < Detalle_de_Otro_NombreData.length; i++) {
            if (Detalle_de_Otro_NombreData[i].Removed == null || Detalle_de_Otro_NombreData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Otro_NombreData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Otro_NombrepushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Otro_NombreDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Otro_NombreDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Delito_Mandamiento_JudicialinitializeMainArray(totalCount) {
        if (Detalle_de_Delito_Mandamiento_JudicialDataMain.length != totalCount && !Detalle_de_Delito_Mandamiento_JudicialDataMainInitialized) {
            Detalle_de_Delito_Mandamiento_JudicialDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Delito_Mandamiento_JudicialDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Delito_Mandamiento_JudicialremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Delito_Mandamiento_JudicialdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Delito_Mandamiento_JudicialDataMain.length; i++) {
                if (Detalle_de_Delito_Mandamiento_JudicialDataMain[i] != null && Detalle_de_Delito_Mandamiento_JudicialDataMain[i].Id == Detalle_de_Delito_Mandamiento_JudicialdeletedItem[j]) {
                    hDetalle_de_Delito_Mandamiento_JudicialDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Delito_Mandamiento_JudicialcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Delito_Mandamiento_JudicialDataMain.length; i++) {
            data[i] = Detalle_de_Delito_Mandamiento_JudicialDataMain[i];

        }
        return data;
    }
    function Detalle_de_Delito_Mandamiento_JudicialgetNewResult() {
        var newData = copyMainDetalle_de_Delito_Mandamiento_JudicialArray();

        for (var i = 0; i < Detalle_de_Delito_Mandamiento_JudicialData.length; i++) {
            if (Detalle_de_Delito_Mandamiento_JudicialData[i].Removed == null || Detalle_de_Delito_Mandamiento_JudicialData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Delito_Mandamiento_JudicialData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Delito_Mandamiento_JudicialpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Delito_Mandamiento_JudicialDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Delito_Mandamiento_JudicialDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_AmparoinitializeMainArray(totalCount) {
        if (Detalle_de_AmparoDataMain.length != totalCount && !Detalle_de_AmparoDataMainInitialized) {
            Detalle_de_AmparoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_AmparoDataMain[i] = null;
            }
        }
    }
    function Detalle_de_AmparoremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_AmparodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_AmparoDataMain.length; i++) {
                if (Detalle_de_AmparoDataMain[i] != null && Detalle_de_AmparoDataMain[i].Id == Detalle_de_AmparodeletedItem[j]) {
                    hDetalle_de_AmparoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_AmparocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_AmparoDataMain.length; i++) {
            data[i] = Detalle_de_AmparoDataMain[i];

        }
        return data;
    }
    function Detalle_de_AmparogetNewResult() {
        var newData = copyMainDetalle_de_AmparoArray();

        for (var i = 0; i < Detalle_de_AmparoData.length; i++) {
            if (Detalle_de_AmparoData[i].Removed == null || Detalle_de_AmparoData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_AmparoData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_AmparopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_AmparoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_AmparoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_FotosinitializeMainArray(totalCount) {
        if (Detalle_de_FotosDataMain.length != totalCount && !Detalle_de_FotosDataMainInitialized) {
            Detalle_de_FotosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_FotosDataMain[i] = null;
            }
        }
    }
    function Detalle_de_FotosremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_FotosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_FotosDataMain.length; i++) {
                if (Detalle_de_FotosDataMain[i] != null && Detalle_de_FotosDataMain[i].Id == Detalle_de_FotosdeletedItem[j]) {
                    hDetalle_de_FotosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_FotoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_FotosDataMain.length; i++) {
            data[i] = Detalle_de_FotosDataMain[i];

        }
        return data;
    }
    function Detalle_de_FotosgetNewResult() {
        var newData = copyMainDetalle_de_FotosArray();

        for (var i = 0; i < Detalle_de_FotosData.length; i++) {
            if (Detalle_de_FotosData[i].Removed == null || Detalle_de_FotosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_FotosData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_FotospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_FotosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_FotosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Documentos_Mandamiento_JudicialinitializeMainArray(totalCount) {
        if (Detalle_de_Documentos_Mandamiento_JudicialDataMain.length != totalCount && !Detalle_de_Documentos_Mandamiento_JudicialDataMainInitialized) {
            Detalle_de_Documentos_Mandamiento_JudicialDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Documentos_Mandamiento_JudicialDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Documentos_Mandamiento_JudicialremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Documentos_Mandamiento_JudicialdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Documentos_Mandamiento_JudicialDataMain.length; i++) {
                if (Detalle_de_Documentos_Mandamiento_JudicialDataMain[i] != null && Detalle_de_Documentos_Mandamiento_JudicialDataMain[i].Id == Detalle_de_Documentos_Mandamiento_JudicialdeletedItem[j]) {
                    hDetalle_de_Documentos_Mandamiento_JudicialDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Documentos_Mandamiento_JudicialcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Documentos_Mandamiento_JudicialDataMain.length; i++) {
            data[i] = Detalle_de_Documentos_Mandamiento_JudicialDataMain[i];

        }
        return data;
    }
    function Detalle_de_Documentos_Mandamiento_JudicialgetNewResult() {
        var newData = copyMainDetalle_de_Documentos_Mandamiento_JudicialArray();

        for (var i = 0; i < Detalle_de_Documentos_Mandamiento_JudicialData.length; i++) {
            if (Detalle_de_Documentos_Mandamiento_JudicialData[i].Removed == null || Detalle_de_Documentos_Mandamiento_JudicialData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Documentos_Mandamiento_JudicialData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Documentos_Mandamiento_JudicialpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Documentos_Mandamiento_JudicialDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Documentos_Mandamiento_JudicialDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompletePais_al_que_Pertenece_la_InformacionData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Pais_al_que_Pertenece_la_Informacion_PaisData(data) {
	AutoCompletePais_al_que_Pertenece_la_InformacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_al_que_Pertenece_la_InformacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_al_que_Pertenece_la_InformacionData;
}
var AutoCompleteEstado_que_Envia_la_InformacionData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Estado_que_Envia_la_Informacion_EstadoData(data) {
	AutoCompleteEstado_que_Envia_la_InformacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_que_Envia_la_InformacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_que_Envia_la_InformacionData;
}
var AutoCompleteMunicipio_que_Envia_la_InformacionData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Municipio_que_Envia_la_Informacion_MunicipioData(data) {
	AutoCompleteMunicipio_que_Envia_la_InformacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_que_Envia_la_InformacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_que_Envia_la_InformacionData;
}
var AutoCompleteEntidad_que_Emite_MandamientoData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Entidad_que_Emite_Mandamiento_EstadoData(data) {
	AutoCompleteEntidad_que_Emite_MandamientoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEntidad_que_Emite_MandamientoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEntidad_que_Emite_MandamientoData;
}
var AutoCompleteNacionalidadData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Nacionalidad_NacionalidadData(data) {
	AutoCompleteNacionalidadData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNacionalidadData.push({
            id: data[i].Clave,
            text: data[i].NacionalidadC
        });
    }
    return AutoCompleteNacionalidadData;
}
var AutoCompletePais_de_NacimientoData = [];
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Pais_de_Nacimiento_PaisData(data) {
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
function GetAutoCompleteRegistro_de_Mandamiento_Judicial_Estado_de_Nacimiento_EstadoData(data) {
	AutoCompleteEstado_de_NacimientoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_de_NacimientoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_de_NacimientoData;
}
//Grid GetAutocomplete
var AutoCompletePaisData = [];
function GetAutoCompleteDetalle_de_Domicilio_Pais_PaisData(data) {
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
function GetAutoCompleteDetalle_de_Domicilio_Estado_EstadoData(data) {
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
function GetAutoCompleteDetalle_de_Domicilio_Municipio_MunicipioData(data) {
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
function GetAutoCompleteDetalle_de_Domicilio_Colonia_ColoniaData(data) {
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
var AutoCompleteDelitoData = [];
function GetAutoCompleteDetalle_de_Delito_Mandamiento_Judicial_Delito_DelitoData(data) {
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
var AutoCompleteEntidad_que_Emitio_AmparoData = [];
function GetAutoCompleteDetalle_de_Amparo_Entidad_que_Emitio_Amparo_EstadoData(data) {
	AutoCompleteEntidad_que_Emitio_AmparoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEntidad_que_Emitio_AmparoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEntidad_que_Emitio_AmparoData;
}

//Grid GetAutocomplete

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Registro_de_Mandamiento_Judicial_cmbLabelSelect").val();
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
    $('#CreateRegistro_de_Mandamiento_Judicial')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Pais_al_que_Pertenece_la_Informacion').empty();
    $("#Pais_al_que_Pertenece_la_Informacion").append('<option value=""></option>');
    $('#Pais_al_que_Pertenece_la_Informacion').val('0').trigger('change');
    $('#Estado_que_Envia_la_Informacion').empty();
    $("#Estado_que_Envia_la_Informacion").append('<option value=""></option>');
    $('#Estado_que_Envia_la_Informacion').val('0').trigger('change');
    $('#Municipio_que_Envia_la_Informacion').empty();
    $("#Municipio_que_Envia_la_Informacion").append('<option value=""></option>');
    $('#Municipio_que_Envia_la_Informacion').val('0').trigger('change');
    $('#Entidad_que_Emite_Mandamiento').empty();
    $("#Entidad_que_Emite_Mandamiento").append('<option value=""></option>');
    $('#Entidad_que_Emite_Mandamiento').val('0').trigger('change');
    $('#Nacionalidad').empty();
    $("#Nacionalidad").append('<option value=""></option>');
    $('#Nacionalidad').val('0').trigger('change');
    $('#Pais_de_Nacimiento').empty();
    $("#Pais_de_Nacimiento").append('<option value=""></option>');
    $('#Pais_de_Nacimiento').val('0').trigger('change');
    $('#Estado_de_Nacimiento').empty();
    $("#Estado_de_Nacimiento").append('<option value=""></option>');
    $('#Estado_de_Nacimiento').val('0').trigger('change');
                Detalle_de_DomicilioClearGridData();
                Detalle_de_telefonoClearGridData();
                Detalle_de_Otro_NombreClearGridData();
                Detalle_de_Delito_Mandamiento_JudicialClearGridData();
                Detalle_de_AmparoClearGridData();
                Detalle_de_FotosClearGridData();
                Detalle_de_Documentos_Mandamiento_JudicialClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateRegistro_de_Mandamiento_Judicial').trigger('reset');
    $('#CreateRegistro_de_Mandamiento_Judicial').find(':input').each(function () {
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
    var $myForm = $('#CreateRegistro_de_Mandamiento_Judicial');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_DomiciliocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Domicilio();
        return false;
    }
    if (Detalle_de_telefonocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_telefono();
        return false;
    }
    if (Detalle_de_Otro_NombrecountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Otro_Nombre();
        return false;
    }
    if (Detalle_de_Delito_Mandamiento_JudicialcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Delito_Mandamiento_Judicial();
        return false;
    }
    if (Detalle_de_AmparocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Amparo();
        return false;
    }
    if (Detalle_de_FotoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Fotos();
        return false;
    }
    if (Detalle_de_Documentos_Mandamiento_JudicialcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Documentos_Mandamiento_Judicial();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateRegistro_de_Mandamiento_Judicial").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateRegistro_de_Mandamiento_Judicial").on('click', '#Registro_de_Mandamiento_JudicialCancelar', function () {
	  if (!isPartial) {
        Registro_de_Mandamiento_JudicialBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateRegistro_de_Mandamiento_Judicial").on('click', '#Registro_de_Mandamiento_JudicialGuardar', function () {
		$('#Registro_de_Mandamiento_JudicialGuardar').attr('disabled', true);
		$('#Registro_de_Mandamiento_JudicialGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendRegistro_de_Mandamiento_JudicialData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Registro_de_Mandamiento_JudicialBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Registro_de_Mandamiento_JudicialGuardar').removeAttr('disabled');
                        $('#Registro_de_Mandamiento_JudicialGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Registro_de_Mandamiento_Judicial', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Registro_de_Mandamiento_JudicialGuardar').removeAttr('disabled');
					$('#Registro_de_Mandamiento_JudicialGuardar').bind()
				}
		}
		else {
			$('#Registro_de_Mandamiento_JudicialGuardar').removeAttr('disabled');
			$('#Registro_de_Mandamiento_JudicialGuardar').bind()
		}
    });
	$("form#CreateRegistro_de_Mandamiento_Judicial").on('click', '#Registro_de_Mandamiento_JudicialGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendRegistro_de_Mandamiento_JudicialData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_DomicilioData();
                getDetalle_de_telefonoData();
                getDetalle_de_Otro_NombreData();
                getDetalle_de_Delito_Mandamiento_JudicialData();
                getDetalle_de_AmparoData();
                getDetalle_de_FotosData();
                getDetalle_de_Documentos_Mandamiento_JudicialData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Registro_de_Mandamiento_Judicial', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateRegistro_de_Mandamiento_Judicial").on('click', '#Registro_de_Mandamiento_JudicialGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendRegistro_de_Mandamiento_JudicialData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Pais_al_que_Pertenece_la_Informacion').empty();
    $("#Pais_al_que_Pertenece_la_Informacion").append('<option value=""></option>');
    $('#Pais_al_que_Pertenece_la_Informacion').val('0').trigger('change');
    $('#Estado_que_Envia_la_Informacion').empty();
    $("#Estado_que_Envia_la_Informacion").append('<option value=""></option>');
    $('#Estado_que_Envia_la_Informacion').val('0').trigger('change');
    $('#Municipio_que_Envia_la_Informacion').empty();
    $("#Municipio_que_Envia_la_Informacion").append('<option value=""></option>');
    $('#Municipio_que_Envia_la_Informacion').val('0').trigger('change');
    $('#Entidad_que_Emite_Mandamiento').empty();
    $("#Entidad_que_Emite_Mandamiento").append('<option value=""></option>');
    $('#Entidad_que_Emite_Mandamiento').val('0').trigger('change');
    $('#Nacionalidad').empty();
    $("#Nacionalidad").append('<option value=""></option>');
    $('#Nacionalidad').val('0').trigger('change');
    $('#Pais_de_Nacimiento').empty();
    $("#Pais_de_Nacimiento").append('<option value=""></option>');
    $('#Pais_de_Nacimiento').val('0').trigger('change');
    $('#Estado_de_Nacimiento').empty();
    $("#Estado_de_Nacimiento").append('<option value=""></option>');
    $('#Estado_de_Nacimiento').val('0').trigger('change');
                Detalle_de_DomicilioClearGridData();
                Detalle_de_telefonoClearGridData();
                Detalle_de_Otro_NombreClearGridData();
                Detalle_de_Delito_Mandamiento_JudicialClearGridData();
                Detalle_de_AmparoClearGridData();
                Detalle_de_FotosClearGridData();
                Detalle_de_Documentos_Mandamiento_JudicialClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_DomicilioData();
                getDetalle_de_telefonoData();
                getDetalle_de_Otro_NombreData();
                getDetalle_de_Delito_Mandamiento_JudicialData();
                getDetalle_de_AmparoData();
                getDetalle_de_FotosData();
                getDetalle_de_Documentos_Mandamiento_JudicialData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Registro_de_Mandamiento_Judicial',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Registro_de_Mandamiento_JudicialDropDown().get(0)').innerHTML);                          
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



var Registro_de_Mandamiento_JudicialisdisplayBusinessPropery = false;
Registro_de_Mandamiento_JudicialDisplayBusinessRuleButtons(Registro_de_Mandamiento_JudicialisdisplayBusinessPropery);
function Registro_de_Mandamiento_JudicialDisplayBusinessRule() {
    if (!Registro_de_Mandamiento_JudicialisdisplayBusinessPropery) {
        $('#CreateRegistro_de_Mandamiento_Judicial').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Registro_de_Mandamiento_JudicialdisplayBusinessPropery"><button onclick="Registro_de_Mandamiento_JudicialGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Registro_de_Mandamiento_JudicialBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Registro_de_Mandamiento_JudicialdisplayBusinessPropery').remove();
    }
    Registro_de_Mandamiento_JudicialDisplayBusinessRuleButtons(!Registro_de_Mandamiento_JudicialisdisplayBusinessPropery);
    Registro_de_Mandamiento_JudicialisdisplayBusinessPropery = (Registro_de_Mandamiento_JudicialisdisplayBusinessPropery ? false : true);
}
function Registro_de_Mandamiento_JudicialDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

