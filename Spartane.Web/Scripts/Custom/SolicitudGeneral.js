

//Begin Declarations for Foreigns fields for Detalle_Solicitud_Historial_de_Asignaciones MultiRow
var Detalle_Solicitud_Historial_de_AsignacionescountRowsChecked = 0;



function GetDetalle_Solicitud_Historial_de_Asignaciones_Spartan_UserName(Id) {
    for (var i = 0; i < Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems.length; i++) {
        if (Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems[i].Id_User == Id) {
            return Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems[i].Name;
        }
    }
    return "";
}

function GetDetalle_Solicitud_Historial_de_Asignaciones_Spartan_UserDropDown() {
    var Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Solicitud_Historial_de_Asignaciones_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserDropdown);

    for (var i = 0; i < Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems.length; i++) {
        $('<option />', { value: Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems[i].Id_User, text: Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems[i].Name }).appendTo(Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserDropdown);
    }
    return Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserDropdown;
}
function GetDetalle_Solicitud_Historial_de_Asignaciones_Spartan_UserName(Id) {
    for (var i = 0; i < Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems.length; i++) {
        if (Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems[i].Id_User == Id) {
            return Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems[i].Name;
        }
    }
    return "";
}

function GetDetalle_Solicitud_Historial_de_Asignaciones_Spartan_UserDropDown() {
    var Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Solicitud_Historial_de_Asignaciones_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserDropdown);

    for (var i = 0; i < Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems.length; i++) {
        $('<option />', { value: Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems[i].Id_User, text: Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserItems[i].Name }).appendTo(Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserDropdown);
    }
    return Detalle_Solicitud_Historial_de_Asignaciones_Spartan_UserDropdown;
}



function GetInsertDetalle_Solicitud_Historial_de_AsignacionesRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_Solicitud_Historial_de_Asignaciones_Fecha_cambio Fecha_cambio').attr('id', 'Detalle_Solicitud_Historial_de_Asignaciones_Fecha_cambio_' + index).attr('data-field', 'Fecha_cambio');
    columnData[1] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_Solicitud_Historial_de_Asignaciones_Hora_cambio Hora_cambio').attr('id', 'Detalle_Solicitud_Historial_de_Asignaciones_Hora_cambio_' + index).attr('data-field', 'Hora_cambio');
    columnData[2] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Solicitud_Historial_de_Asignaciones_Usuario'))).addClass('Detalle_Solicitud_Historial_de_Asignaciones_Usuario Usuario').attr('id', 'Detalle_Solicitud_Historial_de_Asignaciones_Usuario_' + index).attr('data-field', 'Usuario').after($.parseHTML(addNew('Detalle_Solicitud_Historial_de_Asignaciones', 'Spartan_User', 'Usuario', 266705)));
    columnData[3] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Solicitud_Historial_de_Asignaciones_Facilitador_Asignado'))).addClass('Detalle_Solicitud_Historial_de_Asignaciones_Facilitador_Asignado Facilitador_Asignado').attr('id', 'Detalle_Solicitud_Historial_de_Asignaciones_Facilitador_Asignado_' + index).attr('data-field', 'Facilitador_Asignado').after($.parseHTML(addNew('Detalle_Solicitud_Historial_de_Asignaciones', 'Spartan_User', 'Facilitador_Asignado', 266706)));
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_Solicitud_Historial_de_Asignaciones_Motivo_de_cambio Motivo_de_cambio').attr('id', 'Detalle_Solicitud_Historial_de_Asignaciones_Motivo_de_cambio_' + index).attr('data-field', 'Motivo_de_cambio');


    initiateUIControls();
    return columnData;
}

function Detalle_Solicitud_Historial_de_AsignacionesInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Solicitud_Historial_de_Asignaciones("Detalle_Solicitud_Historial_de_Asignaciones_", "_" + rowIndex)) {
    var iPage = Detalle_Solicitud_Historial_de_AsignacionesTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Solicitud_Historial_de_Asignaciones';
    var prevData = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetData(rowIndex);
    var data = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Fecha_cambio:  data.childNodes[counter++].childNodes[0].value
        ,Hora_cambio:  data.childNodes[counter++].childNodes[0].value
        , UsuarioName:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Usuario:  data.childNodes[counter++].childNodes[0].value 	
        , Facilitador_AsignadoName:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Facilitador_Asignado:  data.childNodes[counter++].childNodes[0].value 	
        ,Motivo_de_cambio:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Solicitud_Historial_de_AsignacionesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Solicitud_Historial_de_AsignacionesrowCreationGrid(data, newData, rowIndex);
    Detalle_Solicitud_Historial_de_AsignacionesTable.fnPageChange(iPage);
    Detalle_Solicitud_Historial_de_AsignacionescountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Solicitud_Historial_de_Asignaciones("Detalle_Solicitud_Historial_de_Asignaciones_", "_" + rowIndex);
  }
}

function Detalle_Solicitud_Historial_de_AsignacionesCancelRow(rowIndex) {
    var prevData = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetData(rowIndex);
    var data = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Solicitud_Historial_de_AsignacionesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Solicitud_Historial_de_AsignacionesrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Solicitud_Historial_de_AsignacionesGrid(Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetData());
    Detalle_Solicitud_Historial_de_AsignacionescountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Solicitud_Historial_de_AsignacionesFromDataTable() {
    var Detalle_Solicitud_Historial_de_AsignacionesData = [];
    var gridData = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Solicitud_Historial_de_AsignacionesData.push({
                Folio: gridData[i].Folio

                ,Fecha_cambio: gridData[i].Fecha_cambio
                ,Hora_cambio: gridData[i].Hora_cambio
                ,Usuario: gridData[i].Usuario
                ,Facilitador_Asignado: gridData[i].Facilitador_Asignado
                ,Motivo_de_cambio: gridData[i].Motivo_de_cambio

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Solicitud_Historial_de_AsignacionesData.length; i++) {
        if (removedDetalle_Solicitud_Historial_de_AsignacionesData[i] != null && removedDetalle_Solicitud_Historial_de_AsignacionesData[i].Folio > 0)
            Detalle_Solicitud_Historial_de_AsignacionesData.push({
                Folio: removedDetalle_Solicitud_Historial_de_AsignacionesData[i].Folio

                ,Fecha_cambio: removedDetalle_Solicitud_Historial_de_AsignacionesData[i].Fecha_cambio
                ,Hora_cambio: removedDetalle_Solicitud_Historial_de_AsignacionesData[i].Hora_cambio
                ,Usuario: removedDetalle_Solicitud_Historial_de_AsignacionesData[i].Usuario
                ,Facilitador_Asignado: removedDetalle_Solicitud_Historial_de_AsignacionesData[i].Facilitador_Asignado
                ,Motivo_de_cambio: removedDetalle_Solicitud_Historial_de_AsignacionesData[i].Motivo_de_cambio

                , Removed: true
            });
    }	

    return Detalle_Solicitud_Historial_de_AsignacionesData;
}

function Detalle_Solicitud_Historial_de_AsignacionesEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Solicitud_Historial_de_AsignacionescountRowsChecked++;
    var Detalle_Solicitud_Historial_de_AsignacionesRowElement = "Detalle_Solicitud_Historial_de_Asignaciones_" + rowIndex.toString();
    var prevData = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetData(rowIndexTable );
    var row = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Solicitud_Historial_de_Asignaciones_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Solicitud_Historial_de_AsignacionesGetUpdateRowControls(prevData, "Detalle_Solicitud_Historial_de_Asignaciones_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Solicitud_Historial_de_AsignacionesRowElement + "')){ Detalle_Solicitud_Historial_de_AsignacionesInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Solicitud_Historial_de_AsignacionesCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Solicitud_Historial_de_AsignacionesGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Solicitud_Historial_de_AsignacionesGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Solicitud_Historial_de_AsignacionesValidation();
    initiateUIControls();
    $('.Detalle_Solicitud_Historial_de_Asignaciones' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Solicitud_Historial_de_Asignaciones(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Solicitud_Historial_de_AsignacionesfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetData().length;
    Detalle_Solicitud_Historial_de_AsignacionesfnClickAddRow();
    GetAddDetalle_Solicitud_Historial_de_AsignacionesPopup(currentRowIndex, 0);
}

function Detalle_Solicitud_Historial_de_AsignacionesEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Solicitud_Historial_de_AsignacionesRowElement = "Detalle_Solicitud_Historial_de_Asignaciones_" + rowIndex.toString();
    var prevData = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetData(rowIndexTable);
    GetAddDetalle_Solicitud_Historial_de_AsignacionesPopup(rowIndex, 1, prevData.Folio);

    $('#Detalle_Solicitud_Historial_de_AsignacionesFecha_cambio').val(prevData.Fecha_cambio);
    $('#Detalle_Solicitud_Historial_de_AsignacionesHora_cambio').val(prevData.Hora_cambio);
    $('#dvDetalle_Solicitud_Historial_de_AsignacionesUsuario').html($($.parseHTML(GetGridAutoComplete(prevData.Usuario.label,'AutoCompleteUsuario'))).addClass('Detalle_Solicitud_Historial_de_Asignaciones_Usuario'));
    $('#dvDetalle_Solicitud_Historial_de_AsignacionesFacilitador_Asignado').html($($.parseHTML(GetGridAutoComplete(prevData.Facilitador_Asignado.label,'AutoCompleteFacilitador_Asignado'))).addClass('Detalle_Solicitud_Historial_de_Asignaciones_Facilitador_Asignado'));
    $('#Detalle_Solicitud_Historial_de_AsignacionesMotivo_de_cambio').val(prevData.Motivo_de_cambio);

    initiateUIControls();







}

function Detalle_Solicitud_Historial_de_AsignacionesAddInsertRow() {
    if (Detalle_Solicitud_Historial_de_AsignacionesinsertRowCurrentIndex < 1)
    {
        Detalle_Solicitud_Historial_de_AsignacionesinsertRowCurrentIndex = 1;
    }
    return {
        Folio: null,
        IsInsertRow: true

        ,Fecha_cambio: ""
        ,Hora_cambio: ""
        ,Usuario: ""
        ,Facilitador_Asignado: ""
        ,Motivo_de_cambio: ""

    }
}

function Detalle_Solicitud_Historial_de_AsignacionesfnClickAddRow() {
    Detalle_Solicitud_Historial_de_AsignacionescountRowsChecked++;
    Detalle_Solicitud_Historial_de_AsignacionesTable.fnAddData(Detalle_Solicitud_Historial_de_AsignacionesAddInsertRow(), true);
    Detalle_Solicitud_Historial_de_AsignacionesTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Solicitud_Historial_de_AsignacionesGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Solicitud_Historial_de_AsignacionesGrid tbody tr:nth-of-type(' + (Detalle_Solicitud_Historial_de_AsignacionesinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Solicitud_Historial_de_Asignaciones("Detalle_Solicitud_Historial_de_Asignaciones_", "_" + Detalle_Solicitud_Historial_de_AsignacionesinsertRowCurrentIndex);
}

function Detalle_Solicitud_Historial_de_AsignacionesClearGridData() {
    Detalle_Solicitud_Historial_de_AsignacionesData = [];
    Detalle_Solicitud_Historial_de_AsignacionesdeletedItem = [];
    Detalle_Solicitud_Historial_de_AsignacionesDataMain = [];
    Detalle_Solicitud_Historial_de_AsignacionesDataMainPages = [];
    Detalle_Solicitud_Historial_de_AsignacionesnewItemCount = 0;
    Detalle_Solicitud_Historial_de_AsignacionesmaxItemIndex = 0;
    $("#Detalle_Solicitud_Historial_de_AsignacionesGrid").DataTable().clear();
    $("#Detalle_Solicitud_Historial_de_AsignacionesGrid").DataTable().destroy();
}

//Used to Get Mecanismos Alternos Information
function GetDetalle_Solicitud_Historial_de_Asignaciones() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Solicitud_Historial_de_AsignacionesData.length; i++) {
        form_data.append('[' + i + '].Folio', Detalle_Solicitud_Historial_de_AsignacionesData[i].Folio);

        form_data.append('[' + i + '].Fecha_cambio', Detalle_Solicitud_Historial_de_AsignacionesData[i].Fecha_cambio);
        form_data.append('[' + i + '].Hora_cambio', Detalle_Solicitud_Historial_de_AsignacionesData[i].Hora_cambio);
        form_data.append('[' + i + '].Usuario', Detalle_Solicitud_Historial_de_AsignacionesData[i].Usuario);
        form_data.append('[' + i + '].Facilitador_Asignado', Detalle_Solicitud_Historial_de_AsignacionesData[i].Facilitador_Asignado);
        form_data.append('[' + i + '].Motivo_de_cambio', Detalle_Solicitud_Historial_de_AsignacionesData[i].Motivo_de_cambio);

        form_data.append('[' + i + '].Removed', Detalle_Solicitud_Historial_de_AsignacionesData[i].Removed);
    }
    return form_data;
}
function Detalle_Solicitud_Historial_de_AsignacionesInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Solicitud_Historial_de_Asignaciones("Detalle_Solicitud_Historial_de_AsignacionesTable", rowIndex)) {
    var prevData = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetData(rowIndex);
    var data = Detalle_Solicitud_Historial_de_AsignacionesTable.fnGetNodes(rowIndex);
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Fecha_cambio: $('#Detalle_Solicitud_Historial_de_AsignacionesFecha_cambio').val()
        ,Hora_cambio: $('#Detalle_Solicitud_Historial_de_AsignacionesHora_cambio').val()
        ,Usuario: $('#Detalle_Solicitud_Historial_de_AsignacionesUsuario').val()
        ,Facilitador_Asignado: $('#Detalle_Solicitud_Historial_de_AsignacionesFacilitador_Asignado').val()
        ,Motivo_de_cambio: $('#Detalle_Solicitud_Historial_de_AsignacionesMotivo_de_cambio').val()

    }

    Detalle_Solicitud_Historial_de_AsignacionesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Solicitud_Historial_de_AsignacionesrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Solicitud_Historial_de_Asignaciones-form').modal({ show: false });
    $('#AddDetalle_Solicitud_Historial_de_Asignaciones-form').modal('hide');
    Detalle_Solicitud_Historial_de_AsignacionesEditRow(rowIndex);
    Detalle_Solicitud_Historial_de_AsignacionesInsertRow(rowIndex);
    //}
}
function Detalle_Solicitud_Historial_de_AsignacionesRemoveAddRow(rowIndex) {
    Detalle_Solicitud_Historial_de_AsignacionesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Solicitud_Historial_de_Asignaciones MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Solicitud_Bitacora_de_Coincid MultiRow
var Detalle_de_Solicitud_Bitacora_de_CoincidcountRowsChecked = 0;





function GetDetalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoName(Id) {
    for (var i = 0; i < Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoItems.length; i++) {
        if (Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoItems[i].Clave == Id) {
            return Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoDropDown() {
    var Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Solicitud_Bitacora_de_Coincid_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoDropdown);
    if(Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoItems != null)
    {
       for (var i = 0; i < Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoItems.length; i++) {
           $('<option />', { value: Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoItems[i].Clave, text:    Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoItems[i].Descripcion }).appendTo(Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoDropdown);
       }
    }
    return Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoDropdown;
}

function GetDetalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoName(Id) {
    for (var i = 0; i < Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoItems.length; i++) {
        if (Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoItems[i].Clave == Id) {
            return Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoDropDown() {
    var Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Solicitud_Bitacora_de_Coincid_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoDropdown);
    if(Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoItems != null)
    {
       for (var i = 0; i < Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoItems.length; i++) {
           $('<option />', { value: Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoItems[i].Clave, text:    Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoItems[i].Descripcion }).appendTo(Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoDropdown);
       }
    }
    return Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoDropdown;
}



function GetInsertDetalle_de_Solicitud_Bitacora_de_CoincidRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Solicitud_Bitacora_de_Coincid_Nombre_Completo Nombre_Completo').attr('id', 'Detalle_de_Solicitud_Bitacora_de_Coincid_Nombre_Completo_' + index).attr('data-field', 'Nombre_Completo');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Solicitud_Bitacora_de_Coincid_Alias Alias').attr('id', 'Detalle_de_Solicitud_Bitacora_de_Coincid_Alias_' + index).attr('data-field', 'Alias');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Solicitud_Bitacora_de_Coincid_Numero_de_Expediente Numero_de_Expediente').attr('id', 'Detalle_de_Solicitud_Bitacora_de_Coincid_Numero_de_Expediente_' + index).attr('data-field', 'Numero_de_Expediente');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Solicitud_Bitacora_de_Coincid_Fuente_de_Origen Fuente_de_Origen').attr('id', 'Detalle_de_Solicitud_Bitacora_de_Coincid_Fuente_de_Origen_' + index).attr('data-field', 'Fuente_de_Origen');
    columnData[4] = $(GetDetalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoDropDown()).addClass('Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_Acuerdo Tipo_de_Acuerdo').attr('id', 'Detalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_Acuerdo_' + index).attr('data-field', 'Tipo_de_Acuerdo').after($.parseHTML(addNew('Detalle_de_Solicitud_Bitacora_de_Coincid', 'Tipo_de_Acuerdo', 'Tipo_de_Acuerdo', 266134)));
    columnData[5] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Solicitud_Bitacora_de_Coincid_Cumplido Cumplido').attr('id', 'Detalle_de_Solicitud_Bitacora_de_Coincid_Cumplido_' + index).attr('data-field', 'Cumplido');
    columnData[6] = $(GetDetalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoDropDown()).addClass('Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_Incumplimiento Razon_de_Incumplimiento').attr('id', 'Detalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_Incumplimiento_' + index).attr('data-field', 'Razon_de_Incumplimiento').after($.parseHTML(addNew('Detalle_de_Solicitud_Bitacora_de_Coincid', 'Razon_de_Incumplimiento', 'Razon_de_Incumplimiento', 266136)));
    columnData[7] = $($.parseHTML(inputData)).addClass('Detalle_de_Solicitud_Bitacora_de_Coincid_Observaciones Observaciones').attr('id', 'Detalle_de_Solicitud_Bitacora_de_Coincid_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Solicitud_Bitacora_de_CoincidInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_Bitacora_de_Coincid("Detalle_de_Solicitud_Bitacora_de_Coincid_", "_" + rowIndex)) {
    var iPage = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Solicitud_Bitacora_de_Coincid';
    var prevData = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre_Completo:  data.childNodes[counter++].childNodes[0].value
        ,Alias:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Expediente:  data.childNodes[counter++].childNodes[0].value
        ,Fuente_de_Origen:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Acuerdo:  data.childNodes[counter++].childNodes[0].value
        ,Cumplido: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Razon_de_Incumplimiento:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Solicitud_Bitacora_de_CoincidrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnPageChange(iPage);
    Detalle_de_Solicitud_Bitacora_de_CoincidcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitud_Bitacora_de_Coincid("Detalle_de_Solicitud_Bitacora_de_Coincid_", "_" + rowIndex);
  }
}

function Detalle_de_Solicitud_Bitacora_de_CoincidCancelRow(rowIndex) {
    var prevData = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Solicitud_Bitacora_de_CoincidrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Solicitud_Bitacora_de_CoincidGrid(Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetData());
    Detalle_de_Solicitud_Bitacora_de_CoincidcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Solicitud_Bitacora_de_CoincidFromDataTable() {
    var Detalle_de_Solicitud_Bitacora_de_CoincidData = [];
    var gridData = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Solicitud_Bitacora_de_CoincidData.push({
                Clave: gridData[i].Clave

                ,Nombre_Completo: gridData[i].Nombre_Completo
                ,Alias: gridData[i].Alias
                ,Numero_de_Expediente: gridData[i].Numero_de_Expediente
                ,Fuente_de_Origen: gridData[i].Fuente_de_Origen
                ,Tipo_de_Acuerdo: gridData[i].Tipo_de_Acuerdo
                ,Cumplido: gridData[i].Cumplido
                ,Razon_de_Incumplimiento: gridData[i].Razon_de_Incumplimiento
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Solicitud_Bitacora_de_CoincidData.length; i++) {
        if (removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i] != null && removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i].Clave > 0)
            Detalle_de_Solicitud_Bitacora_de_CoincidData.push({
                Clave: removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i].Clave

                ,Nombre_Completo: removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i].Nombre_Completo
                ,Alias: removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i].Alias
                ,Numero_de_Expediente: removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i].Numero_de_Expediente
                ,Fuente_de_Origen: removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i].Fuente_de_Origen
                ,Tipo_de_Acuerdo: removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i].Tipo_de_Acuerdo
                ,Cumplido: removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i].Cumplido
                ,Razon_de_Incumplimiento: removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i].Razon_de_Incumplimiento
                ,Observaciones: removedDetalle_de_Solicitud_Bitacora_de_CoincidData[i].Observaciones

                , Removed: true
            });
    }	

    return Detalle_de_Solicitud_Bitacora_de_CoincidData;
}

function Detalle_de_Solicitud_Bitacora_de_CoincidEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Solicitud_Bitacora_de_CoincidcountRowsChecked++;
    var Detalle_de_Solicitud_Bitacora_de_CoincidRowElement = "Detalle_de_Solicitud_Bitacora_de_Coincid_" + rowIndex.toString();
    var prevData = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Solicitud_Bitacora_de_Coincid_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Solicitud_Bitacora_de_CoincidGetUpdateRowControls(prevData, "Detalle_de_Solicitud_Bitacora_de_Coincid_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Solicitud_Bitacora_de_CoincidRowElement + "')){ Detalle_de_Solicitud_Bitacora_de_CoincidInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Solicitud_Bitacora_de_CoincidCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Solicitud_Bitacora_de_CoincidGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Solicitud_Bitacora_de_CoincidGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Solicitud_Bitacora_de_CoincidValidation();
    initiateUIControls();
    $('.Detalle_de_Solicitud_Bitacora_de_Coincid' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Solicitud_Bitacora_de_Coincid(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Solicitud_Bitacora_de_CoincidfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetData().length;
    Detalle_de_Solicitud_Bitacora_de_CoincidfnClickAddRow();
    GetAddDetalle_de_Solicitud_Bitacora_de_CoincidPopup(currentRowIndex, 0);
}

function Detalle_de_Solicitud_Bitacora_de_CoincidEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Solicitud_Bitacora_de_CoincidRowElement = "Detalle_de_Solicitud_Bitacora_de_Coincid_" + rowIndex.toString();
    var prevData = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Solicitud_Bitacora_de_CoincidPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Solicitud_Bitacora_de_CoincidNombre_Completo').val(prevData.Nombre_Completo);
    $('#Detalle_de_Solicitud_Bitacora_de_CoincidAlias').val(prevData.Alias);
    $('#Detalle_de_Solicitud_Bitacora_de_CoincidNumero_de_Expediente').val(prevData.Numero_de_Expediente);
    $('#Detalle_de_Solicitud_Bitacora_de_CoincidFuente_de_Origen').val(prevData.Fuente_de_Origen);
    $('#Detalle_de_Solicitud_Bitacora_de_CoincidTipo_de_Acuerdo').val(prevData.Tipo_de_Acuerdo);
    $('#Detalle_de_Solicitud_Bitacora_de_CoincidCumplido').prop('checked', prevData.Cumplido);
    $('#Detalle_de_Solicitud_Bitacora_de_CoincidRazon_de_Incumplimiento').val(prevData.Razon_de_Incumplimiento);
    $('#Detalle_de_Solicitud_Bitacora_de_CoincidObservaciones').val(prevData.Observaciones);

    initiateUIControls();










}

function Detalle_de_Solicitud_Bitacora_de_CoincidAddInsertRow() {
    if (Detalle_de_Solicitud_Bitacora_de_CoincidinsertRowCurrentIndex < 1)
    {
        Detalle_de_Solicitud_Bitacora_de_CoincidinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre_Completo: ""
        ,Alias: ""
        ,Numero_de_Expediente: ""
        ,Fuente_de_Origen: ""
        ,Tipo_de_Acuerdo: ""
        ,Cumplido: ""
        ,Razon_de_Incumplimiento: ""
        ,Observaciones: ""

    }
}

function Detalle_de_Solicitud_Bitacora_de_CoincidfnClickAddRow() {
    Detalle_de_Solicitud_Bitacora_de_CoincidcountRowsChecked++;
    Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnAddData(Detalle_de_Solicitud_Bitacora_de_CoincidAddInsertRow(), true);
    Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Solicitud_Bitacora_de_CoincidGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Solicitud_Bitacora_de_CoincidGrid tbody tr:nth-of-type(' + (Detalle_de_Solicitud_Bitacora_de_CoincidinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Solicitud_Bitacora_de_Coincid("Detalle_de_Solicitud_Bitacora_de_Coincid_", "_" + Detalle_de_Solicitud_Bitacora_de_CoincidinsertRowCurrentIndex);
}

function Detalle_de_Solicitud_Bitacora_de_CoincidClearGridData() {
    Detalle_de_Solicitud_Bitacora_de_CoincidData = [];
    Detalle_de_Solicitud_Bitacora_de_CoinciddeletedItem = [];
    Detalle_de_Solicitud_Bitacora_de_CoincidDataMain = [];
    Detalle_de_Solicitud_Bitacora_de_CoincidDataMainPages = [];
    Detalle_de_Solicitud_Bitacora_de_CoincidnewItemCount = 0;
    Detalle_de_Solicitud_Bitacora_de_CoincidmaxItemIndex = 0;
    $("#Detalle_de_Solicitud_Bitacora_de_CoincidGrid").DataTable().clear();
    $("#Detalle_de_Solicitud_Bitacora_de_CoincidGrid").DataTable().destroy();
}

//Used to Get Mecanismos Alternos Information
function GetDetalle_de_Solicitud_Bitacora_de_Coincid() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Solicitud_Bitacora_de_CoincidData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Clave);

        form_data.append('[' + i + '].Nombre_Completo', Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Nombre_Completo);
        form_data.append('[' + i + '].Alias', Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Alias);
        form_data.append('[' + i + '].Numero_de_Expediente', Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Numero_de_Expediente);
        form_data.append('[' + i + '].Fuente_de_Origen', Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Fuente_de_Origen);
        form_data.append('[' + i + '].Tipo_de_Acuerdo', Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Tipo_de_Acuerdo);
        form_data.append('[' + i + '].Cumplido', Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Cumplido);
        form_data.append('[' + i + '].Razon_de_Incumplimiento', Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Razon_de_Incumplimiento);
        form_data.append('[' + i + '].Observaciones', Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Solicitud_Bitacora_de_CoincidInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_Bitacora_de_Coincid("Detalle_de_Solicitud_Bitacora_de_CoincidTable", rowIndex)) {
    var prevData = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre_Completo: $('#Detalle_de_Solicitud_Bitacora_de_CoincidNombre_Completo').val()
        ,Alias: $('#Detalle_de_Solicitud_Bitacora_de_CoincidAlias').val()
        ,Numero_de_Expediente: $('#Detalle_de_Solicitud_Bitacora_de_CoincidNumero_de_Expediente').val()
        ,Fuente_de_Origen: $('#Detalle_de_Solicitud_Bitacora_de_CoincidFuente_de_Origen').val()
        ,Tipo_de_Acuerdo: $('#Detalle_de_Solicitud_Bitacora_de_CoincidTipo_de_Acuerdo').val()
        ,Cumplido: $('#Detalle_de_Solicitud_Bitacora_de_CoincidCumplido').is(':checked')
        ,Razon_de_Incumplimiento: $('#Detalle_de_Solicitud_Bitacora_de_CoincidRazon_de_Incumplimiento').val()
        ,Observaciones: $('#Detalle_de_Solicitud_Bitacora_de_CoincidObservaciones').val()

    }

    Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Solicitud_Bitacora_de_CoincidrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Solicitud_Bitacora_de_Coincid-form').modal({ show: false });
    $('#AddDetalle_de_Solicitud_Bitacora_de_Coincid-form').modal('hide');
    Detalle_de_Solicitud_Bitacora_de_CoincidEditRow(rowIndex);
    Detalle_de_Solicitud_Bitacora_de_CoincidInsertRow(rowIndex);
    //}
}
function Detalle_de_Solicitud_Bitacora_de_CoincidRemoveAddRow(rowIndex) {
    Detalle_de_Solicitud_Bitacora_de_CoincidTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Solicitud_Bitacora_de_Coincid MultiRow
//Begin Declarations for Foreigns fields for Detalle_Historico_JA MultiRow
var Detalle_Historico_JAcountRowsChecked = 0;



function GetDetalle_Historico_JA_Spartan_UserName(Id) {
    for (var i = 0; i < Detalle_Historico_JA_Spartan_UserItems.length; i++) {
        if (Detalle_Historico_JA_Spartan_UserItems[i].Id_User == Id) {
            return Detalle_Historico_JA_Spartan_UserItems[i].Name;
        }
    }
    return "";
}

function GetDetalle_Historico_JA_Spartan_UserDropDown() {
    var Detalle_Historico_JA_Spartan_UserDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Historico_JA_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Historico_JA_Spartan_UserDropdown);

    for (var i = 0; i < Detalle_Historico_JA_Spartan_UserItems.length; i++) {
        $('<option />', { value: Detalle_Historico_JA_Spartan_UserItems[i].Id_User, text: Detalle_Historico_JA_Spartan_UserItems[i].Name }).appendTo(Detalle_Historico_JA_Spartan_UserDropdown);
    }
    return Detalle_Historico_JA_Spartan_UserDropdown;
}



function GetInsertDetalle_Historico_JARowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_Historico_JA_Fecha Fecha').attr('id', 'Detalle_Historico_JA_Fecha_' + index).attr('data-field', 'Fecha');
    columnData[1] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_Historico_JA_Hora Hora').attr('id', 'Detalle_Historico_JA_Hora_' + index).attr('data-field', 'Hora');
    columnData[2] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Historico_JA_Usuario'))).addClass('Detalle_Historico_JA_Usuario Usuario').attr('id', 'Detalle_Historico_JA_Usuario_' + index).attr('data-field', 'Usuario').after($.parseHTML(addNew('Detalle_Historico_JA', 'Spartan_User', 'Usuario', 264904)));
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Historico_JA_Estatus Estatus').attr('id', 'Detalle_Historico_JA_Estatus_' + index).attr('data-field', 'Estatus');


    initiateUIControls();
    return columnData;
}

function Detalle_Historico_JAInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Historico_JA("Detalle_Historico_JA_", "_" + rowIndex)) {
    var iPage = Detalle_Historico_JATable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Historico_JA';
    var prevData = Detalle_Historico_JATable.fnGetData(rowIndex);
    var data = Detalle_Historico_JATable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha:  data.childNodes[counter++].childNodes[0].value
        ,Hora:  data.childNodes[counter++].childNodes[0].value
        , UsuarioName:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Usuario:  data.childNodes[counter++].childNodes[0].value 	
        ,Estatus:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Historico_JATable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Historico_JArowCreationGrid(data, newData, rowIndex);
    Detalle_Historico_JATable.fnPageChange(iPage);
    Detalle_Historico_JAcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Historico_JA("Detalle_Historico_JA_", "_" + rowIndex);
  }
}

function Detalle_Historico_JACancelRow(rowIndex) {
    var prevData = Detalle_Historico_JATable.fnGetData(rowIndex);
    var data = Detalle_Historico_JATable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Historico_JATable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Historico_JArowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Historico_JAGrid(Detalle_Historico_JATable.fnGetData());
    Detalle_Historico_JAcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Historico_JAFromDataTable() {
    var Detalle_Historico_JAData = [];
    var gridData = Detalle_Historico_JATable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Historico_JAData.push({
                Clave: gridData[i].Clave

                ,Fecha: gridData[i].Fecha
                ,Hora: gridData[i].Hora
                ,Usuario: gridData[i].Usuario
                ,Estatus: gridData[i].Estatus

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Historico_JAData.length; i++) {
        if (removedDetalle_Historico_JAData[i] != null && removedDetalle_Historico_JAData[i].Clave > 0)
            Detalle_Historico_JAData.push({
                Clave: removedDetalle_Historico_JAData[i].Clave

                ,Fecha: removedDetalle_Historico_JAData[i].Fecha
                ,Hora: removedDetalle_Historico_JAData[i].Hora
                ,Usuario: removedDetalle_Historico_JAData[i].Usuario
                ,Estatus: removedDetalle_Historico_JAData[i].Estatus

                , Removed: true
            });
    }	

    return Detalle_Historico_JAData;
}

function Detalle_Historico_JAEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Historico_JATable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Historico_JAcountRowsChecked++;
    var Detalle_Historico_JARowElement = "Detalle_Historico_JA_" + rowIndex.toString();
    var prevData = Detalle_Historico_JATable.fnGetData(rowIndexTable );
    var row = Detalle_Historico_JATable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Historico_JA_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Historico_JAGetUpdateRowControls(prevData, "Detalle_Historico_JA_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Historico_JARowElement + "')){ Detalle_Historico_JAInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Historico_JACancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Historico_JAGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Historico_JAGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Historico_JAValidation();
    initiateUIControls();
    $('.Detalle_Historico_JA' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Historico_JA(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Historico_JAfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Historico_JATable.fnGetData().length;
    Detalle_Historico_JAfnClickAddRow();
    GetAddDetalle_Historico_JAPopup(currentRowIndex, 0);
}

function Detalle_Historico_JAEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Historico_JATable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Historico_JARowElement = "Detalle_Historico_JA_" + rowIndex.toString();
    var prevData = Detalle_Historico_JATable.fnGetData(rowIndexTable);
    GetAddDetalle_Historico_JAPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Historico_JAFecha').val(prevData.Fecha);
    $('#Detalle_Historico_JAHora').val(prevData.Hora);
    $('#dvDetalle_Historico_JAUsuario').html($($.parseHTML(GetGridAutoComplete(prevData.Usuario.label,'AutoCompleteUsuario'))).addClass('Detalle_Historico_JA_Usuario'));
    $('#Detalle_Historico_JAEstatus').val(prevData.Estatus);

    initiateUIControls();






}

function Detalle_Historico_JAAddInsertRow() {
    if (Detalle_Historico_JAinsertRowCurrentIndex < 1)
    {
        Detalle_Historico_JAinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha: ""
        ,Hora: ""
        ,Usuario: ""
        ,Estatus: ""

    }
}

function Detalle_Historico_JAfnClickAddRow() {
    Detalle_Historico_JAcountRowsChecked++;
    Detalle_Historico_JATable.fnAddData(Detalle_Historico_JAAddInsertRow(), true);
    Detalle_Historico_JATable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Historico_JAGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Historico_JAGrid tbody tr:nth-of-type(' + (Detalle_Historico_JAinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Historico_JA("Detalle_Historico_JA_", "_" + Detalle_Historico_JAinsertRowCurrentIndex);
}

function Detalle_Historico_JAClearGridData() {
    Detalle_Historico_JAData = [];
    Detalle_Historico_JAdeletedItem = [];
    Detalle_Historico_JADataMain = [];
    Detalle_Historico_JADataMainPages = [];
    Detalle_Historico_JAnewItemCount = 0;
    Detalle_Historico_JAmaxItemIndex = 0;
    $("#Detalle_Historico_JAGrid").DataTable().clear();
    $("#Detalle_Historico_JAGrid").DataTable().destroy();
}

//Used to Get Mecanismos Alternos Information
function GetDetalle_Historico_JA() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Historico_JAData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Historico_JAData[i].Clave);

        form_data.append('[' + i + '].Fecha', Detalle_Historico_JAData[i].Fecha);
        form_data.append('[' + i + '].Hora', Detalle_Historico_JAData[i].Hora);
        form_data.append('[' + i + '].Usuario', Detalle_Historico_JAData[i].Usuario);
        form_data.append('[' + i + '].Estatus', Detalle_Historico_JAData[i].Estatus);

        form_data.append('[' + i + '].Removed', Detalle_Historico_JAData[i].Removed);
    }
    return form_data;
}
function Detalle_Historico_JAInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Historico_JA("Detalle_Historico_JATable", rowIndex)) {
    var prevData = Detalle_Historico_JATable.fnGetData(rowIndex);
    var data = Detalle_Historico_JATable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha: $('#Detalle_Historico_JAFecha').val()
        ,Hora: $('#Detalle_Historico_JAHora').val()
        ,Usuario: $('#Detalle_Historico_JAUsuario').val()
        ,Estatus: $('#Detalle_Historico_JAEstatus').val()

    }

    Detalle_Historico_JATable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Historico_JArowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Historico_JA-form').modal({ show: false });
    $('#AddDetalle_Historico_JA-form').modal('hide');
    Detalle_Historico_JAEditRow(rowIndex);
    Detalle_Historico_JAInsertRow(rowIndex);
    //}
}
function Detalle_Historico_JARemoveAddRow(rowIndex) {
    Detalle_Historico_JATable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Historico_JA MultiRow


$(function () {
    function Detalle_Solicitud_Historial_de_AsignacionesinitializeMainArray(totalCount) {
        if (Detalle_Solicitud_Historial_de_AsignacionesDataMain.length != totalCount && !Detalle_Solicitud_Historial_de_AsignacionesDataMainInitialized) {
            Detalle_Solicitud_Historial_de_AsignacionesDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Solicitud_Historial_de_AsignacionesDataMain[i] = null;
            }
        }
    }
    function Detalle_Solicitud_Historial_de_AsignacionesremoveFromMainArray() {
        for (var j = 0; j < Detalle_Solicitud_Historial_de_AsignacionesdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Solicitud_Historial_de_AsignacionesDataMain.length; i++) {
                if (Detalle_Solicitud_Historial_de_AsignacionesDataMain[i] != null && Detalle_Solicitud_Historial_de_AsignacionesDataMain[i].Id == Detalle_Solicitud_Historial_de_AsignacionesdeletedItem[j]) {
                    hDetalle_Solicitud_Historial_de_AsignacionesDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Solicitud_Historial_de_AsignacionescopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Solicitud_Historial_de_AsignacionesDataMain.length; i++) {
            data[i] = Detalle_Solicitud_Historial_de_AsignacionesDataMain[i];

        }
        return data;
    }
    function Detalle_Solicitud_Historial_de_AsignacionesgetNewResult() {
        var newData = copyMainDetalle_Solicitud_Historial_de_AsignacionesArray();

        for (var i = 0; i < Detalle_Solicitud_Historial_de_AsignacionesData.length; i++) {
            if (Detalle_Solicitud_Historial_de_AsignacionesData[i].Removed == null || Detalle_Solicitud_Historial_de_AsignacionesData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Solicitud_Historial_de_AsignacionesData[i]);
            }
        }
        return newData;
    }
    function Detalle_Solicitud_Historial_de_AsignacionespushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Solicitud_Historial_de_AsignacionesDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Solicitud_Historial_de_AsignacionesDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Solicitud_Bitacora_de_CoincidinitializeMainArray(totalCount) {
        if (Detalle_de_Solicitud_Bitacora_de_CoincidDataMain.length != totalCount && !Detalle_de_Solicitud_Bitacora_de_CoincidDataMainInitialized) {
            Detalle_de_Solicitud_Bitacora_de_CoincidDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Solicitud_Bitacora_de_CoincidDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Solicitud_Bitacora_de_CoincidremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Solicitud_Bitacora_de_CoinciddeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Solicitud_Bitacora_de_CoincidDataMain.length; i++) {
                if (Detalle_de_Solicitud_Bitacora_de_CoincidDataMain[i] != null && Detalle_de_Solicitud_Bitacora_de_CoincidDataMain[i].Id == Detalle_de_Solicitud_Bitacora_de_CoinciddeletedItem[j]) {
                    hDetalle_de_Solicitud_Bitacora_de_CoincidDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Solicitud_Bitacora_de_CoincidcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Solicitud_Bitacora_de_CoincidDataMain.length; i++) {
            data[i] = Detalle_de_Solicitud_Bitacora_de_CoincidDataMain[i];

        }
        return data;
    }
    function Detalle_de_Solicitud_Bitacora_de_CoincidgetNewResult() {
        var newData = copyMainDetalle_de_Solicitud_Bitacora_de_CoincidArray();

        for (var i = 0; i < Detalle_de_Solicitud_Bitacora_de_CoincidData.length; i++) {
            if (Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Removed == null || Detalle_de_Solicitud_Bitacora_de_CoincidData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Solicitud_Bitacora_de_CoincidData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Solicitud_Bitacora_de_CoincidpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Solicitud_Bitacora_de_CoincidDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Solicitud_Bitacora_de_CoincidDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Historico_JAinitializeMainArray(totalCount) {
        if (Detalle_Historico_JADataMain.length != totalCount && !Detalle_Historico_JADataMainInitialized) {
            Detalle_Historico_JADataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Historico_JADataMain[i] = null;
            }
        }
    }
    function Detalle_Historico_JAremoveFromMainArray() {
        for (var j = 0; j < Detalle_Historico_JAdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Historico_JADataMain.length; i++) {
                if (Detalle_Historico_JADataMain[i] != null && Detalle_Historico_JADataMain[i].Id == Detalle_Historico_JAdeletedItem[j]) {
                    hDetalle_Historico_JADataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Historico_JAcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Historico_JADataMain.length; i++) {
            data[i] = Detalle_Historico_JADataMain[i];

        }
        return data;
    }
    function Detalle_Historico_JAgetNewResult() {
        var newData = copyMainDetalle_Historico_JAArray();

        for (var i = 0; i < Detalle_Historico_JAData.length; i++) {
            if (Detalle_Historico_JAData[i].Removed == null || Detalle_Historico_JAData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Historico_JAData[i]);
            }
        }
        return newData;
    }
    function Detalle_Historico_JApushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Historico_JADataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Historico_JADataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompleteSolicitud_Usuario_que_Registra_Spartan_UserData(data) {
	AutoCompleteUsuario_que_RegistraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_RegistraData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_RegistraData;
}
var AutoCompleteNUATData = [];
function GetAutoCompleteSolicitud_NUAT_Modulo_Atencion_InicialData(data) {
	AutoCompleteNUATData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNUATData.push({
            id: data[i].Clave,
            text: data[i].NUAT
        });
    }
    return AutoCompleteNUATData;
}
var AutoCompleteExpediente_MPIData = [];
function GetAutoCompleteSolicitud_Expediente_MPI_expediente_ministerio_publicoData(data) {
	AutoCompleteExpediente_MPIData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MPIData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteExpediente_MPIData;
}
var AutoCompleteExpediente_CausaPenalData = [];
function GetAutoCompleteSolicitud_Expediente_CausaPenal_Resolucion_MPData(data) {
	AutoCompleteExpediente_CausaPenalData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_CausaPenalData.push({
            id: data[i].Clave,
            text: data[i].Observaciones
        });
    }
    return AutoCompleteExpediente_CausaPenalData;
}
var AutoCompleteMunicipioData = [];
function GetAutoCompleteSolicitud_Municipio_MunicipioData(data) {
	AutoCompleteMunicipioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioData;
}
var AutoCompleteAgente_del_Ministerio_Publico_OrientadorData = [];
function GetAutoCompleteSolicitud_Agente_del_Ministerio_Publico_Orientador_Spartan_UserData(data) {
	AutoCompleteAgente_del_Ministerio_Publico_OrientadorData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteAgente_del_Ministerio_Publico_OrientadorData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteAgente_del_Ministerio_Publico_OrientadorData;
}
var AutoCompleteAgente_del_Ministerio_Publico_InvestData = [];
function GetAutoCompleteSolicitud_Agente_del_Ministerio_Publico_Invest_Spartan_UserData(data) {
	AutoCompleteAgente_del_Ministerio_Publico_InvestData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteAgente_del_Ministerio_Publico_InvestData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteAgente_del_Ministerio_Publico_InvestData;
}
var AutoCompletePaisHData = [];
function GetAutoCompleteSolicitud_PaisH_PaisData(data) {
	AutoCompletePaisHData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePaisHData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePaisHData;
}
var AutoCompleteEstadoHData = [];
function GetAutoCompleteSolicitud_EstadoH_EstadoData(data) {
	AutoCompleteEstadoHData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstadoHData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstadoHData;
}
var AutoCompleteMunicipioHData = [];
function GetAutoCompleteSolicitud_MunicipioH_MunicipioData(data) {
	AutoCompleteMunicipioHData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioHData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioHData;
}
var AutoCompletePoblacionData = [];
function GetAutoCompleteSolicitud_Poblacion_ColoniaData(data) {
	AutoCompletePoblacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePoblacionData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePoblacionData;
}
var AutoCompleteColoniaHData = [];
function GetAutoCompleteSolicitud_ColoniaH_ColoniaData(data) {
	AutoCompleteColoniaHData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaHData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaHData;
}
var AutoCompleteUsuario_que_ValidaData = [];
function GetAutoCompleteSolicitud_Usuario_que_Valida_Spartan_UserData(data) {
	AutoCompleteUsuario_que_ValidaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_ValidaData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_ValidaData;
}
var AutoCompleteEspecialista_AsignadoAData = [];
function GetAutoCompleteSolicitud_Especialista_AsignadoA_Spartan_UserData(data) {
	AutoCompleteEspecialista_AsignadoAData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEspecialista_AsignadoAData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteEspecialista_AsignadoAData;
}
//Grid GetAutocomplete
var AutoCompleteUsuarioData = [];
function GetAutoCompleteDetalle_Solicitud_Historial_de_Asignaciones_Usuario_Spartan_UserData(data) {
	AutoCompleteUsuarioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuarioData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuarioData;
}
var AutoCompleteFacilitador_AsignadoData = [];
function GetAutoCompleteDetalle_Solicitud_Historial_de_Asignaciones_Facilitador_Asignado_Spartan_UserData(data) {
	AutoCompleteFacilitador_AsignadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteFacilitador_AsignadoData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteFacilitador_AsignadoData;
}

//Grid GetAutocomplete

//Grid GetAutocomplete
var AutoCompleteUsuarioData = [];
function GetAutoCompleteDetalle_Historico_JA_Usuario_Spartan_UserData(data) {
	AutoCompleteUsuarioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuarioData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuarioData;
}



function getDropdown(elementKey) {
    var labelSelect = $("#Solicitud_cmbLabelSelect").val();
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
    $('#CreateSolicitud')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
    $('#NUAT').empty();
    $("#NUAT").append('<option value=""></option>');
    $('#NUAT').val('0').trigger('change');
    $('#Expediente_MPI').empty();
    $("#Expediente_MPI").append('<option value=""></option>');
    $('#Expediente_MPI').val('0').trigger('change');
    $('#Expediente_CausaPenal').empty();
    $("#Expediente_CausaPenal").append('<option value=""></option>');
    $('#Expediente_CausaPenal').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Agente_del_Ministerio_Publico_Orientador').empty();
    $("#Agente_del_Ministerio_Publico_Orientador").append('<option value=""></option>');
    $('#Agente_del_Ministerio_Publico_Orientador').val('0').trigger('change');
    $('#Agente_del_Ministerio_Publico_Invest').empty();
    $("#Agente_del_Ministerio_Publico_Invest").append('<option value=""></option>');
    $('#Agente_del_Ministerio_Publico_Invest').val('0').trigger('change');
    $('#PaisH').empty();
    $("#PaisH").append('<option value=""></option>');
    $('#PaisH').val('0').trigger('change');
    $('#EstadoH').empty();
    $("#EstadoH").append('<option value=""></option>');
    $('#EstadoH').val('0').trigger('change');
    $('#MunicipioH').empty();
    $("#MunicipioH").append('<option value=""></option>');
    $('#MunicipioH').val('0').trigger('change');
    $('#Poblacion').empty();
    $("#Poblacion").append('<option value=""></option>');
    $('#Poblacion').val('0').trigger('change');
    $('#ColoniaH').empty();
    $("#ColoniaH").append('<option value=""></option>');
    $('#ColoniaH').val('0').trigger('change');
    $('#Usuario_que_Valida').empty();
    $("#Usuario_que_Valida").append('<option value=""></option>');
    $('#Usuario_que_Valida').val('0').trigger('change');
    $('#Especialista_AsignadoA').empty();
    $("#Especialista_AsignadoA").append('<option value=""></option>');
    $('#Especialista_AsignadoA').val('0').trigger('change');
                Detalle_Solicitud_Historial_de_AsignacionesClearGridData();
                Detalle_de_Solicitud_Bitacora_de_CoincidClearGridData();
                Detalle_Historico_JAClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateSolicitud').trigger('reset');
    $('#CreateSolicitud').find(':input').each(function () {
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
    var $myForm = $('#CreateSolicitud');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Solicitud_Historial_de_AsignacionescountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Solicitud_Historial_de_Asignaciones();
        return false;
    }
    if (Detalle_de_Solicitud_Bitacora_de_CoincidcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Solicitud_Bitacora_de_Coincid();
        return false;
    }
    if (Detalle_Historico_JAcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Historico_JA();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateSolicitud").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateSolicitud").on('click', '#SolicitudCancelar', function () {
	  if (!isPartial) {
        SolicitudBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateSolicitud").on('click', '#SolicitudGuardar', function () {
		$('#SolicitudGuardar').attr('disabled', true);
		$('#SolicitudGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendSolicitudData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						SolicitudBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#SolicitudGuardar').removeAttr('disabled');
                        $('#SolicitudGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Solicitud', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_SolicitudItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_SolicitudDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#SolicitudGuardar').removeAttr('disabled');
					$('#SolicitudGuardar').bind()
				}
		}
		else {
			$('#SolicitudGuardar').removeAttr('disabled');
			$('#SolicitudGuardar').bind()
		}
    });
	$("form#CreateSolicitud").on('click', '#SolicitudGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendSolicitudData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Solicitud_Historial_de_AsignacionesData();
                getDetalle_de_Solicitud_Bitacora_de_CoincidData();
                getDetalle_Historico_JAData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Solicitud', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_SolicitudItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_SolicitudDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateSolicitud").on('click', '#SolicitudGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendSolicitudData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
    $('#NUAT').empty();
    $("#NUAT").append('<option value=""></option>');
    $('#NUAT').val('0').trigger('change');
    $('#Expediente_MPI').empty();
    $("#Expediente_MPI").append('<option value=""></option>');
    $('#Expediente_MPI').val('0').trigger('change');
    $('#Expediente_CausaPenal').empty();
    $("#Expediente_CausaPenal").append('<option value=""></option>');
    $('#Expediente_CausaPenal').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Agente_del_Ministerio_Publico_Orientador').empty();
    $("#Agente_del_Ministerio_Publico_Orientador").append('<option value=""></option>');
    $('#Agente_del_Ministerio_Publico_Orientador').val('0').trigger('change');
    $('#Agente_del_Ministerio_Publico_Invest').empty();
    $("#Agente_del_Ministerio_Publico_Invest").append('<option value=""></option>');
    $('#Agente_del_Ministerio_Publico_Invest').val('0').trigger('change');
    $('#PaisH').empty();
    $("#PaisH").append('<option value=""></option>');
    $('#PaisH').val('0').trigger('change');
    $('#EstadoH').empty();
    $("#EstadoH").append('<option value=""></option>');
    $('#EstadoH').val('0').trigger('change');
    $('#MunicipioH').empty();
    $("#MunicipioH").append('<option value=""></option>');
    $('#MunicipioH').val('0').trigger('change');
    $('#Poblacion').empty();
    $("#Poblacion").append('<option value=""></option>');
    $('#Poblacion').val('0').trigger('change');
    $('#ColoniaH').empty();
    $("#ColoniaH").append('<option value=""></option>');
    $('#ColoniaH').val('0').trigger('change');
    $('#Usuario_que_Valida').empty();
    $("#Usuario_que_Valida").append('<option value=""></option>');
    $('#Usuario_que_Valida').val('0').trigger('change');
    $('#Especialista_AsignadoA').empty();
    $("#Especialista_AsignadoA").append('<option value=""></option>');
    $('#Especialista_AsignadoA').val('0').trigger('change');
                Detalle_Solicitud_Historial_de_AsignacionesClearGridData();
                Detalle_de_Solicitud_Bitacora_de_CoincidClearGridData();
                Detalle_Historico_JAClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Solicitud_Historial_de_AsignacionesData();
                getDetalle_de_Solicitud_Bitacora_de_CoincidData();
                getDetalle_Historico_JAData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Solicitud',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_SolicitudItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_SolicitudDropDown().get(0)').innerHTML);                          
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



var SolicitudisdisplayBusinessPropery = false;
SolicitudDisplayBusinessRuleButtons(SolicitudisdisplayBusinessPropery);
function SolicitudDisplayBusinessRule() {
    if (!SolicitudisdisplayBusinessPropery) {
        $('#CreateSolicitud').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="SolicituddisplayBusinessPropery"><button onclick="SolicitudGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#SolicitudBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.SolicituddisplayBusinessPropery').remove();
    }
    SolicitudDisplayBusinessRuleButtons(!SolicitudisdisplayBusinessPropery);
    SolicitudisdisplayBusinessPropery = (SolicitudisdisplayBusinessPropery ? false : true);
}
function SolicitudDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

