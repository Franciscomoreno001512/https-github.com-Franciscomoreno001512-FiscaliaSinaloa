

//Begin Declarations for Foreigns fields for Detalle_de_Invitado_de_Notificacion MultiRow
var Detalle_de_Invitado_de_NotificacioncountRowsChecked = 0;




function GetDetalle_de_Invitado_de_Notificacion_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Invitado_de_Notificacion_EstadoItems.length; i++) {
        if (Detalle_de_Invitado_de_Notificacion_EstadoItems[i].Clave == Id) {
            return Detalle_de_Invitado_de_Notificacion_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Invitado_de_Notificacion_EstadoDropDown() {
    var Detalle_de_Invitado_de_Notificacion_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Invitado_de_Notificacion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Invitado_de_Notificacion_EstadoDropdown);

    for (var i = 0; i < Detalle_de_Invitado_de_Notificacion_EstadoItems.length; i++) {
        $('<option />', { value: Detalle_de_Invitado_de_Notificacion_EstadoItems[i].Clave, text: Detalle_de_Invitado_de_Notificacion_EstadoItems[i].Nombre }).appendTo(Detalle_de_Invitado_de_Notificacion_EstadoDropdown);
    }
    return Detalle_de_Invitado_de_Notificacion_EstadoDropdown;
}
function GetDetalle_de_Invitado_de_Notificacion_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Invitado_de_Notificacion_MunicipioItems.length; i++) {
        if (Detalle_de_Invitado_de_Notificacion_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Invitado_de_Notificacion_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Invitado_de_Notificacion_MunicipioDropDown() {
    var Detalle_de_Invitado_de_Notificacion_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Invitado_de_Notificacion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Invitado_de_Notificacion_MunicipioDropdown);

    for (var i = 0; i < Detalle_de_Invitado_de_Notificacion_MunicipioItems.length; i++) {
        $('<option />', { value: Detalle_de_Invitado_de_Notificacion_MunicipioItems[i].Clave, text: Detalle_de_Invitado_de_Notificacion_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Invitado_de_Notificacion_MunicipioDropdown);
    }
    return Detalle_de_Invitado_de_Notificacion_MunicipioDropdown;
}
function GetDetalle_de_Invitado_de_Notificacion_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Invitado_de_Notificacion_ColoniaItems.length; i++) {
        if (Detalle_de_Invitado_de_Notificacion_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Invitado_de_Notificacion_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Invitado_de_Notificacion_ColoniaDropDown() {
    var Detalle_de_Invitado_de_Notificacion_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Invitado_de_Notificacion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Invitado_de_Notificacion_ColoniaDropdown);

    for (var i = 0; i < Detalle_de_Invitado_de_Notificacion_ColoniaItems.length; i++) {
        $('<option />', { value: Detalle_de_Invitado_de_Notificacion_ColoniaItems[i].Clave, text: Detalle_de_Invitado_de_Notificacion_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Invitado_de_Notificacion_ColoniaDropdown);
    }
    return Detalle_de_Invitado_de_Notificacion_ColoniaDropdown;
}
function GetDetalle_de_Invitado_de_Notificacion_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Invitado_de_Notificacion_ColoniaItems.length; i++) {
        if (Detalle_de_Invitado_de_Notificacion_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Invitado_de_Notificacion_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Invitado_de_Notificacion_ColoniaDropDown() {
    var Detalle_de_Invitado_de_Notificacion_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Invitado_de_Notificacion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Invitado_de_Notificacion_ColoniaDropdown);

    for (var i = 0; i < Detalle_de_Invitado_de_Notificacion_ColoniaItems.length; i++) {
        $('<option />', { value: Detalle_de_Invitado_de_Notificacion_ColoniaItems[i].Clave, text: Detalle_de_Invitado_de_Notificacion_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Invitado_de_Notificacion_ColoniaDropdown);
    }
    return Detalle_de_Invitado_de_Notificacion_ColoniaDropdown;
}






function GetInsertDetalle_de_Invitado_de_NotificacionRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Invitado_de_Notificacion_Nombre_Completo Nombre_Completo').attr('id', 'Detalle_de_Invitado_de_Notificacion_Nombre_Completo_' + index).attr('data-field', 'Nombre_Completo');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Invitado_de_Notificacion_Telefono Telefono').attr('id', 'Detalle_de_Invitado_de_Notificacion_Telefono_' + index).attr('data-field', 'Telefono');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Invitado_de_Notificacion_Correo_Electronico Correo_Electronico').attr('id', 'Detalle_de_Invitado_de_Notificacion_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');
    columnData[3] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Invitado_de_Notificacion_Estado'))).addClass('Detalle_de_Invitado_de_Notificacion_Estado Estado').attr('id', 'Detalle_de_Invitado_de_Notificacion_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_de_Invitado_de_Notificacion', 'Estado', 'Estado', 266228)));
    columnData[4] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Invitado_de_Notificacion_Municipio'))).addClass('Detalle_de_Invitado_de_Notificacion_Municipio Municipio').attr('id', 'Detalle_de_Invitado_de_Notificacion_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_de_Invitado_de_Notificacion', 'Municipio', 'Municipio', 266229)));
    columnData[5] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Invitado_de_Notificacion_Poblacion'))).addClass('Detalle_de_Invitado_de_Notificacion_Poblacion Poblacion').attr('id', 'Detalle_de_Invitado_de_Notificacion_Poblacion_' + index).attr('data-field', 'Poblacion').after($.parseHTML(addNew('Detalle_de_Invitado_de_Notificacion', 'Colonia', 'Poblacion', 266230)));
    columnData[6] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_de_Invitado_de_Notificacion_Colonia'))).addClass('Detalle_de_Invitado_de_Notificacion_Colonia Colonia').attr('id', 'Detalle_de_Invitado_de_Notificacion_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_de_Invitado_de_Notificacion', 'Colonia', 'Colonia', 266231)));
    columnData[7] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Invitado_de_Notificacion_Codigo_Postal Codigo_Postal').attr('id', 'Detalle_de_Invitado_de_Notificacion_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[8] = $($.parseHTML(inputData)).addClass('Detalle_de_Invitado_de_Notificacion_Calle Calle').attr('id', 'Detalle_de_Invitado_de_Notificacion_Calle_' + index).attr('data-field', 'Calle');
    columnData[9] = $($.parseHTML(inputData)).addClass('Detalle_de_Invitado_de_Notificacion_Numero_Exterior Numero_Exterior').attr('id', 'Detalle_de_Invitado_de_Notificacion_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[10] = $($.parseHTML(inputData)).addClass('Detalle_de_Invitado_de_Notificacion_Numero_Interior Numero_Interior').attr('id', 'Detalle_de_Invitado_de_Notificacion_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Invitado_de_NotificacionInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Invitado_de_Notificacion("Detalle_de_Invitado_de_Notificacion_", "_" + rowIndex)) {
    var iPage = Detalle_de_Invitado_de_NotificacionTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Invitado_de_Notificacion';
    var prevData = Detalle_de_Invitado_de_NotificacionTable.fnGetData(rowIndex);
    var data = Detalle_de_Invitado_de_NotificacionTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Nombre_Completo:  data.childNodes[counter++].childNodes[0].value
        ,Telefono:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value
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
        ,Numero_Exterior:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Invitado_de_NotificacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Invitado_de_NotificacionrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Invitado_de_NotificacionTable.fnPageChange(iPage);
    Detalle_de_Invitado_de_NotificacioncountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Invitado_de_Notificacion("Detalle_de_Invitado_de_Notificacion_", "_" + rowIndex);
  }
}

function Detalle_de_Invitado_de_NotificacionCancelRow(rowIndex) {
    var prevData = Detalle_de_Invitado_de_NotificacionTable.fnGetData(rowIndex);
    var data = Detalle_de_Invitado_de_NotificacionTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Invitado_de_NotificacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Invitado_de_NotificacionrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Invitado_de_NotificacionGrid(Detalle_de_Invitado_de_NotificacionTable.fnGetData());
    Detalle_de_Invitado_de_NotificacioncountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Invitado_de_NotificacionFromDataTable() {
    var Detalle_de_Invitado_de_NotificacionData = [];
    var gridData = Detalle_de_Invitado_de_NotificacionTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Invitado_de_NotificacionData.push({
                Folio: gridData[i].Folio

                ,Nombre_Completo: gridData[i].Nombre_Completo
                ,Telefono: gridData[i].Telefono
                ,Correo_Electronico: gridData[i].Correo_Electronico
                ,Estado: gridData[i].Estado
                ,Municipio: gridData[i].Municipio
                ,Poblacion: gridData[i].Poblacion
                ,Colonia: gridData[i].Colonia
                ,Codigo_Postal: gridData[i].Codigo_Postal
                ,Calle: gridData[i].Calle
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Invitado_de_NotificacionData.length; i++) {
        if (removedDetalle_de_Invitado_de_NotificacionData[i] != null && removedDetalle_de_Invitado_de_NotificacionData[i].Folio > 0)
            Detalle_de_Invitado_de_NotificacionData.push({
                Folio: removedDetalle_de_Invitado_de_NotificacionData[i].Folio

                ,Nombre_Completo: removedDetalle_de_Invitado_de_NotificacionData[i].Nombre_Completo
                ,Telefono: removedDetalle_de_Invitado_de_NotificacionData[i].Telefono
                ,Correo_Electronico: removedDetalle_de_Invitado_de_NotificacionData[i].Correo_Electronico
                ,Estado: removedDetalle_de_Invitado_de_NotificacionData[i].Estado
                ,Municipio: removedDetalle_de_Invitado_de_NotificacionData[i].Municipio
                ,Poblacion: removedDetalle_de_Invitado_de_NotificacionData[i].Poblacion
                ,Colonia: removedDetalle_de_Invitado_de_NotificacionData[i].Colonia
                ,Codigo_Postal: removedDetalle_de_Invitado_de_NotificacionData[i].Codigo_Postal
                ,Calle: removedDetalle_de_Invitado_de_NotificacionData[i].Calle
                ,Numero_Exterior: removedDetalle_de_Invitado_de_NotificacionData[i].Numero_Exterior
                ,Numero_Interior: removedDetalle_de_Invitado_de_NotificacionData[i].Numero_Interior

                , Removed: true
            });
    }	

    return Detalle_de_Invitado_de_NotificacionData;
}

function Detalle_de_Invitado_de_NotificacionEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Invitado_de_NotificacionTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Invitado_de_NotificacioncountRowsChecked++;
    var Detalle_de_Invitado_de_NotificacionRowElement = "Detalle_de_Invitado_de_Notificacion_" + rowIndex.toString();
    var prevData = Detalle_de_Invitado_de_NotificacionTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Invitado_de_NotificacionTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Invitado_de_Notificacion_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Invitado_de_NotificacionGetUpdateRowControls(prevData, "Detalle_de_Invitado_de_Notificacion_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Invitado_de_NotificacionRowElement + "')){ Detalle_de_Invitado_de_NotificacionInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Invitado_de_NotificacionCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Invitado_de_NotificacionGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Invitado_de_NotificacionGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Invitado_de_NotificacionValidation();
    initiateUIControls();
    $('.Detalle_de_Invitado_de_Notificacion' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Invitado_de_Notificacion(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Invitado_de_NotificacionfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Invitado_de_NotificacionTable.fnGetData().length;
    Detalle_de_Invitado_de_NotificacionfnClickAddRow();
    GetAddDetalle_de_Invitado_de_NotificacionPopup(currentRowIndex, 0);
}

function Detalle_de_Invitado_de_NotificacionEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Invitado_de_NotificacionTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Invitado_de_NotificacionRowElement = "Detalle_de_Invitado_de_Notificacion_" + rowIndex.toString();
    var prevData = Detalle_de_Invitado_de_NotificacionTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Invitado_de_NotificacionPopup(rowIndex, 1, prevData.Folio);

    $('#Detalle_de_Invitado_de_NotificacionNombre_Completo').val(prevData.Nombre_Completo);
    $('#Detalle_de_Invitado_de_NotificacionTelefono').val(prevData.Telefono);
    $('#Detalle_de_Invitado_de_NotificacionCorreo_Electronico').val(prevData.Correo_Electronico);
    $('#dvDetalle_de_Invitado_de_NotificacionEstado').html($($.parseHTML(GetGridAutoComplete(prevData.Estado.label,'AutoCompleteEstado'))).addClass('Detalle_de_Invitado_de_Notificacion_Estado'));
    $('#dvDetalle_de_Invitado_de_NotificacionMunicipio').html($($.parseHTML(GetGridAutoComplete(prevData.Municipio.label,'AutoCompleteMunicipio'))).addClass('Detalle_de_Invitado_de_Notificacion_Municipio'));
    $('#dvDetalle_de_Invitado_de_NotificacionPoblacion').html($($.parseHTML(GetGridAutoComplete(prevData.Poblacion.label,'AutoCompletePoblacion'))).addClass('Detalle_de_Invitado_de_Notificacion_Poblacion'));
    $('#dvDetalle_de_Invitado_de_NotificacionColonia').html($($.parseHTML(GetGridAutoComplete(prevData.Colonia.label,'AutoCompleteColonia'))).addClass('Detalle_de_Invitado_de_Notificacion_Colonia'));
    $('#Detalle_de_Invitado_de_NotificacionCodigo_Postal').val(prevData.Codigo_Postal);
    $('#Detalle_de_Invitado_de_NotificacionCalle').val(prevData.Calle);
    $('#Detalle_de_Invitado_de_NotificacionNumero_Exterior').val(prevData.Numero_Exterior);
    $('#Detalle_de_Invitado_de_NotificacionNumero_Interior').val(prevData.Numero_Interior);

    initiateUIControls();













}

function Detalle_de_Invitado_de_NotificacionAddInsertRow() {
    if (Detalle_de_Invitado_de_NotificacioninsertRowCurrentIndex < 1)
    {
        Detalle_de_Invitado_de_NotificacioninsertRowCurrentIndex = 1;
    }
    return {
        Folio: null,
        IsInsertRow: true

        ,Nombre_Completo: ""
        ,Telefono: ""
        ,Correo_Electronico: ""
        ,Estado: ""
        ,Municipio: ""
        ,Poblacion: ""
        ,Colonia: ""
        ,Codigo_Postal: ""
        ,Calle: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""

    }
}

function Detalle_de_Invitado_de_NotificacionfnClickAddRow() {
    Detalle_de_Invitado_de_NotificacioncountRowsChecked++;
    Detalle_de_Invitado_de_NotificacionTable.fnAddData(Detalle_de_Invitado_de_NotificacionAddInsertRow(), true);
    Detalle_de_Invitado_de_NotificacionTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Invitado_de_NotificacionGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Invitado_de_NotificacionGrid tbody tr:nth-of-type(' + (Detalle_de_Invitado_de_NotificacioninsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Invitado_de_Notificacion("Detalle_de_Invitado_de_Notificacion_", "_" + Detalle_de_Invitado_de_NotificacioninsertRowCurrentIndex);
}

function Detalle_de_Invitado_de_NotificacionClearGridData() {
    Detalle_de_Invitado_de_NotificacionData = [];
    Detalle_de_Invitado_de_NotificaciondeletedItem = [];
    Detalle_de_Invitado_de_NotificacionDataMain = [];
    Detalle_de_Invitado_de_NotificacionDataMainPages = [];
    Detalle_de_Invitado_de_NotificacionnewItemCount = 0;
    Detalle_de_Invitado_de_NotificacionmaxItemIndex = 0;
    $("#Detalle_de_Invitado_de_NotificacionGrid").DataTable().clear();
    $("#Detalle_de_Invitado_de_NotificacionGrid").DataTable().destroy();
}

//Used to Get Solicitud de Notificación Information
function GetDetalle_de_Invitado_de_Notificacion() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Invitado_de_NotificacionData.length; i++) {
        form_data.append('[' + i + '].Folio', Detalle_de_Invitado_de_NotificacionData[i].Folio);

        form_data.append('[' + i + '].Nombre_Completo', Detalle_de_Invitado_de_NotificacionData[i].Nombre_Completo);
        form_data.append('[' + i + '].Telefono', Detalle_de_Invitado_de_NotificacionData[i].Telefono);
        form_data.append('[' + i + '].Correo_Electronico', Detalle_de_Invitado_de_NotificacionData[i].Correo_Electronico);
        form_data.append('[' + i + '].Estado', Detalle_de_Invitado_de_NotificacionData[i].Estado);
        form_data.append('[' + i + '].Municipio', Detalle_de_Invitado_de_NotificacionData[i].Municipio);
        form_data.append('[' + i + '].Poblacion', Detalle_de_Invitado_de_NotificacionData[i].Poblacion);
        form_data.append('[' + i + '].Colonia', Detalle_de_Invitado_de_NotificacionData[i].Colonia);
        form_data.append('[' + i + '].Codigo_Postal', Detalle_de_Invitado_de_NotificacionData[i].Codigo_Postal);
        form_data.append('[' + i + '].Calle', Detalle_de_Invitado_de_NotificacionData[i].Calle);
        form_data.append('[' + i + '].Numero_Exterior', Detalle_de_Invitado_de_NotificacionData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Detalle_de_Invitado_de_NotificacionData[i].Numero_Interior);

        form_data.append('[' + i + '].Removed', Detalle_de_Invitado_de_NotificacionData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Invitado_de_NotificacionInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Invitado_de_Notificacion("Detalle_de_Invitado_de_NotificacionTable", rowIndex)) {
    var prevData = Detalle_de_Invitado_de_NotificacionTable.fnGetData(rowIndex);
    var data = Detalle_de_Invitado_de_NotificacionTable.fnGetNodes(rowIndex);
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Nombre_Completo: $('#Detalle_de_Invitado_de_NotificacionNombre_Completo').val()
        ,Telefono: $('#Detalle_de_Invitado_de_NotificacionTelefono').val()
        ,Correo_Electronico: $('#Detalle_de_Invitado_de_NotificacionCorreo_Electronico').val()
        ,Estado: $('#Detalle_de_Invitado_de_NotificacionEstado').val()
        ,Municipio: $('#Detalle_de_Invitado_de_NotificacionMunicipio').val()
        ,Poblacion: $('#Detalle_de_Invitado_de_NotificacionPoblacion').val()
        ,Colonia: $('#Detalle_de_Invitado_de_NotificacionColonia').val()
        ,Codigo_Postal: $('#Detalle_de_Invitado_de_NotificacionCodigo_Postal').val()

        ,Calle: $('#Detalle_de_Invitado_de_NotificacionCalle').val()
        ,Numero_Exterior: $('#Detalle_de_Invitado_de_NotificacionNumero_Exterior').val()
        ,Numero_Interior: $('#Detalle_de_Invitado_de_NotificacionNumero_Interior').val()

    }

    Detalle_de_Invitado_de_NotificacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Invitado_de_NotificacionrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Invitado_de_Notificacion-form').modal({ show: false });
    $('#AddDetalle_de_Invitado_de_Notificacion-form').modal('hide');
    Detalle_de_Invitado_de_NotificacionEditRow(rowIndex);
    Detalle_de_Invitado_de_NotificacionInsertRow(rowIndex);
    //}
}
function Detalle_de_Invitado_de_NotificacionRemoveAddRow(rowIndex) {
    Detalle_de_Invitado_de_NotificacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Invitado_de_Notificacion MultiRow


$(function () {
    function Detalle_de_Invitado_de_NotificacioninitializeMainArray(totalCount) {
        if (Detalle_de_Invitado_de_NotificacionDataMain.length != totalCount && !Detalle_de_Invitado_de_NotificacionDataMainInitialized) {
            Detalle_de_Invitado_de_NotificacionDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Invitado_de_NotificacionDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Invitado_de_NotificacionremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Invitado_de_NotificaciondeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Invitado_de_NotificacionDataMain.length; i++) {
                if (Detalle_de_Invitado_de_NotificacionDataMain[i] != null && Detalle_de_Invitado_de_NotificacionDataMain[i].Id == Detalle_de_Invitado_de_NotificaciondeletedItem[j]) {
                    hDetalle_de_Invitado_de_NotificacionDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Invitado_de_NotificacioncopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Invitado_de_NotificacionDataMain.length; i++) {
            data[i] = Detalle_de_Invitado_de_NotificacionDataMain[i];

        }
        return data;
    }
    function Detalle_de_Invitado_de_NotificaciongetNewResult() {
        var newData = copyMainDetalle_de_Invitado_de_NotificacionArray();

        for (var i = 0; i < Detalle_de_Invitado_de_NotificacionData.length; i++) {
            if (Detalle_de_Invitado_de_NotificacionData[i].Removed == null || Detalle_de_Invitado_de_NotificacionData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Invitado_de_NotificacionData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Invitado_de_NotificacionpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Invitado_de_NotificacionDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Invitado_de_NotificacionDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteUsuario_que_SolicitaData = [];
function GetAutoCompleteSolicitud_de_Notificacion_Usuario_que_Solicita_Spartan_UserData(data) {
	AutoCompleteUsuario_que_SolicitaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_SolicitaData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_SolicitaData;
}
var AutoCompleteExpediente_Atencion_TempranaData = [];
function GetAutoCompleteSolicitud_de_Notificacion_Expediente_Atencion_Temprana_Modulo_Atencion_InicialData(data) {
	AutoCompleteExpediente_Atencion_TempranaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_Atencion_TempranaData.push({
            id: data[i].Clave,
            text: data[i].Folio
        });
    }
    return AutoCompleteExpediente_Atencion_TempranaData;
}
var AutoCompleteExpediente_Mecanismos_AlternosData = [];
function GetAutoCompleteSolicitud_de_Notificacion_Expediente_Mecanismos_Alternos_SolicitudData(data) {
	AutoCompleteExpediente_Mecanismos_AlternosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_Mecanismos_AlternosData.push({
            id: data[i].Clave,
            text: data[i].Numero_de_Folio
        });
    }
    return AutoCompleteExpediente_Mecanismos_AlternosData;
}
//Grid GetAutocomplete
var AutoCompleteEstadoData = [];
function GetAutoCompleteDetalle_de_Invitado_de_Notificacion_Estado_EstadoData(data) {
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
function GetAutoCompleteDetalle_de_Invitado_de_Notificacion_Municipio_MunicipioData(data) {
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
function GetAutoCompleteDetalle_de_Invitado_de_Notificacion_Poblacion_ColoniaData(data) {
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
function GetAutoCompleteDetalle_de_Invitado_de_Notificacion_Colonia_ColoniaData(data) {
	AutoCompleteColoniaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaData;
}

var AutoCompleteNotificadorData = [];
function GetAutoCompleteSolicitud_de_Notificacion_Notificador_Spartan_UserData(data) {
	AutoCompleteNotificadorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNotificadorData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteNotificadorData;
}
var AutoCompleteDocumentoData = [];
function GetAutoCompleteSolicitud_de_Notificacion_Documento_DocumentoData(data) {
	AutoCompleteDocumentoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteDocumentoData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteDocumentoData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#Solicitud_de_Notificacion_cmbLabelSelect").val();
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
    $('#CreateSolicitud_de_Notificacion')[0].reset();
    ClearFormControls();
    $("#FolioId").val("0");
    $('#Usuario_que_Solicita').empty();
    $("#Usuario_que_Solicita").append('<option value=""></option>');
    $('#Usuario_que_Solicita').val('0').trigger('change');
    $('#Expediente_Atencion_Temprana').empty();
    $("#Expediente_Atencion_Temprana").append('<option value=""></option>');
    $('#Expediente_Atencion_Temprana').val('0').trigger('change');
    $('#Expediente_Mecanismos_Alternos').empty();
    $("#Expediente_Mecanismos_Alternos").append('<option value=""></option>');
    $('#Expediente_Mecanismos_Alternos').val('0').trigger('change');
                Detalle_de_Invitado_de_NotificacionClearGridData();
    $('#Notificador').empty();
    $("#Notificador").append('<option value=""></option>');
    $('#Notificador').val('0').trigger('change');
    $('#Documento').empty();
    $("#Documento").append('<option value=""></option>');
    $('#Documento').val('0').trigger('change');

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateSolicitud_de_Notificacion').trigger('reset');
    $('#CreateSolicitud_de_Notificacion').find(':input').each(function () {
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
    var $myForm = $('#CreateSolicitud_de_Notificacion');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Invitado_de_NotificacioncountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Invitado_de_Notificacion();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblFolio").text("0");
}
$(document).ready(function () {
    $("form#CreateSolicitud_de_Notificacion").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateSolicitud_de_Notificacion").on('click', '#Solicitud_de_NotificacionCancelar', function () {
	  if (!isPartial) {
        Solicitud_de_NotificacionBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateSolicitud_de_Notificacion").on('click', '#Solicitud_de_NotificacionGuardar', function () {
		$('#Solicitud_de_NotificacionGuardar').attr('disabled', true);
        $('#Solicitud_de_NotificacionGuardar').unbind()
        debugger;
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendSolicitud_de_NotificacionData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Solicitud_de_NotificacionBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Solicitud_de_NotificacionGuardar').removeAttr('disabled');
                        $('#Solicitud_de_NotificacionGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Solicitud_de_Notificacion', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Solicitud_de_NotificacionItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Solicitud_de_NotificacionDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Solicitud_de_NotificacionGuardar').removeAttr('disabled');
					$('#Solicitud_de_NotificacionGuardar').bind()
				}
		}
		else {
			$('#Solicitud_de_NotificacionGuardar').removeAttr('disabled');
			$('#Solicitud_de_NotificacionGuardar').bind()
		}
    });
	$("form#CreateSolicitud_de_Notificacion").on('click', '#Solicitud_de_NotificacionGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendSolicitud_de_NotificacionData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Invitado_de_NotificacionData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Solicitud_de_Notificacion', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Solicitud_de_NotificacionItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Solicitud_de_NotificacionDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateSolicitud_de_Notificacion").on('click', '#Solicitud_de_NotificacionGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendSolicitud_de_NotificacionData(function (currentId) {
					$("#FolioId").val("0");
	    $('#Usuario_que_Solicita').empty();
    $("#Usuario_que_Solicita").append('<option value=""></option>');
    $('#Usuario_que_Solicita').val('0').trigger('change');
    $('#Expediente_Atencion_Temprana').empty();
    $("#Expediente_Atencion_Temprana").append('<option value=""></option>');
    $('#Expediente_Atencion_Temprana').val('0').trigger('change');
    $('#Expediente_Mecanismos_Alternos').empty();
    $("#Expediente_Mecanismos_Alternos").append('<option value=""></option>');
    $('#Expediente_Mecanismos_Alternos').val('0').trigger('change');
                Detalle_de_Invitado_de_NotificacionClearGridData();
    $('#Notificador').empty();
    $("#Notificador").append('<option value=""></option>');
    $('#Notificador').val('0').trigger('change');
    $('#Documento').empty();
    $("#Documento").append('<option value=""></option>');
    $('#Documento').val('0').trigger('change');

					ResetClaveLabel();
					$("#ReferenceFolio").val(currentId);
	                getDetalle_de_Invitado_de_NotificacionData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Solicitud_de_Notificacion',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Solicitud_de_NotificacionItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Solicitud_de_NotificacionDropDown().get(0)').innerHTML);                          
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



var Solicitud_de_NotificacionisdisplayBusinessPropery = false;
Solicitud_de_NotificacionDisplayBusinessRuleButtons(Solicitud_de_NotificacionisdisplayBusinessPropery);
function Solicitud_de_NotificacionDisplayBusinessRule() {
    if (!Solicitud_de_NotificacionisdisplayBusinessPropery) {
        $('#CreateSolicitud_de_Notificacion').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Solicitud_de_NotificaciondisplayBusinessPropery"><button onclick="Solicitud_de_NotificacionGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Solicitud_de_NotificacionBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Solicitud_de_NotificaciondisplayBusinessPropery').remove();
    }
    Solicitud_de_NotificacionDisplayBusinessRuleButtons(!Solicitud_de_NotificacionisdisplayBusinessPropery);
    Solicitud_de_NotificacionisdisplayBusinessPropery = (Solicitud_de_NotificacionisdisplayBusinessPropery ? false : true);
}
function Solicitud_de_NotificacionDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

