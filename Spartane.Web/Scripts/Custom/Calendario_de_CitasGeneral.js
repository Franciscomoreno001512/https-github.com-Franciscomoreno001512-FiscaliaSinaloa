

//Begin Declarations for Foreigns fields for Detalle_de_Asignacion_de_Citas MultiRow
var Detalle_de_Asignacion_de_CitascountRowsChecked = 0;

function GetDetalle_de_Asignacion_de_Citas_UsuarioName(Id) {
    for (var i = 0; i < Detalle_de_Asignacion_de_Citas_UsuarioItems.length; i++) {
        if (Detalle_de_Asignacion_de_Citas_UsuarioItems[i].Clave == Id) {
            return Detalle_de_Asignacion_de_Citas_UsuarioItems[i].Numero_de_Empleado;
        }
    }
    return "";
}

function GetDetalle_de_Asignacion_de_Citas_UsuarioDropDown() {
    var Detalle_de_Asignacion_de_Citas_UsuarioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Asignacion_de_Citas_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Asignacion_de_Citas_UsuarioDropdown);
    if(Detalle_de_Asignacion_de_Citas_UsuarioItems != null)
    {
       for (var i = 0; i < Detalle_de_Asignacion_de_Citas_UsuarioItems.length; i++) {
           $('<option />', { value: Detalle_de_Asignacion_de_Citas_UsuarioItems[i].Clave, text:    Detalle_de_Asignacion_de_Citas_UsuarioItems[i].Numero_de_Empleado }).appendTo(Detalle_de_Asignacion_de_Citas_UsuarioDropdown);
       }
    }
    return Detalle_de_Asignacion_de_Citas_UsuarioDropdown;
}












function GetInsertDetalle_de_Asignacion_de_CitasRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_de_Asignacion_de_Citas_UsuarioDropDown()).addClass('Detalle_de_Asignacion_de_Citas_Numero_de_Empleado Numero_de_Empleado').attr('id', 'Detalle_de_Asignacion_de_Citas_Numero_de_Empleado_' + index).attr('data-field', 'Numero_de_Empleado').after($.parseHTML(addNew('Detalle_de_Asignacion_de_Citas', 'Usuario', 'Numero_de_Empleado', 263523)));
    columnData[1] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Asignacion_de_Citas_Nombre_de_Empleado Nombre_de_Empleado').attr('id', 'Detalle_de_Asignacion_de_Citas_Nombre_de_Empleado_' + index).attr('data-field', 'Nombre_de_Empleado');
    columnData[2] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Asignacion_de_Citas_Lunes Lunes').attr('id', 'Detalle_de_Asignacion_de_Citas_Lunes_' + index).attr('data-field', 'Lunes');
    columnData[3] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Asignacion_de_Citas_Martes Martes').attr('id', 'Detalle_de_Asignacion_de_Citas_Martes_' + index).attr('data-field', 'Martes');
    columnData[4] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Asignacion_de_Citas_Miercoles Miercoles').attr('id', 'Detalle_de_Asignacion_de_Citas_Miercoles_' + index).attr('data-field', 'Miercoles');
    columnData[5] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Asignacion_de_Citas_Jueves Jueves').attr('id', 'Detalle_de_Asignacion_de_Citas_Jueves_' + index).attr('data-field', 'Jueves');
    columnData[6] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Asignacion_de_Citas_Viernes Viernes').attr('id', 'Detalle_de_Asignacion_de_Citas_Viernes_' + index).attr('data-field', 'Viernes');
    columnData[7] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Asignacion_de_Citas_Sabado Sabado').attr('id', 'Detalle_de_Asignacion_de_Citas_Sabado_' + index).attr('data-field', 'Sabado');
    columnData[8] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Asignacion_de_Citas_Domingo Domingo').attr('id', 'Detalle_de_Asignacion_de_Citas_Domingo_' + index).attr('data-field', 'Domingo');
    columnData[9] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Asignacion_de_Citas_Hora_Inicio Hora_Inicio').attr('id', 'Detalle_de_Asignacion_de_Citas_Hora_Inicio_' + index).attr('data-field', 'Hora_Inicio');
    columnData[10] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Asignacion_de_Citas_Hora_Fin Hora_Fin').attr('id', 'Detalle_de_Asignacion_de_Citas_Hora_Fin_' + index).attr('data-field', 'Hora_Fin');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Asignacion_de_CitasInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Asignacion_de_Citas("Detalle_de_Asignacion_de_Citas_", "_" + rowIndex)) {
    var iPage = Detalle_de_Asignacion_de_CitasTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Asignacion_de_Citas';
    var prevData = Detalle_de_Asignacion_de_CitasTable.fnGetData(rowIndex);
    var data = Detalle_de_Asignacion_de_CitasTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_Empleado:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_de_Empleado: data.childNodes[counter++].childNodes[0].value
        ,Lunes: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Martes: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Miercoles: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Jueves: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Viernes: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Sabado: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Domingo: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Hora_Inicio:  data.childNodes[counter++].childNodes[0].value
        ,Hora_Fin:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Asignacion_de_CitasTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Asignacion_de_CitasrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Asignacion_de_CitasTable.fnPageChange(iPage);
    Detalle_de_Asignacion_de_CitascountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Asignacion_de_Citas("Detalle_de_Asignacion_de_Citas_", "_" + rowIndex);
  }
}

function Detalle_de_Asignacion_de_CitasCancelRow(rowIndex) {
    var prevData = Detalle_de_Asignacion_de_CitasTable.fnGetData(rowIndex);
    var data = Detalle_de_Asignacion_de_CitasTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Asignacion_de_CitasTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Asignacion_de_CitasrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Asignacion_de_CitasGrid(Detalle_de_Asignacion_de_CitasTable.fnGetData());
    Detalle_de_Asignacion_de_CitascountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Asignacion_de_CitasFromDataTable() {
    var Detalle_de_Asignacion_de_CitasData = [];
    var gridData = Detalle_de_Asignacion_de_CitasTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Asignacion_de_CitasData.push({
                Clave: gridData[i].Clave

                ,Numero_de_Empleado: gridData[i].Numero_de_Empleado
                ,Nombre_de_Empleado: gridData[i].Nombre_de_Empleado
                ,Lunes: gridData[i].Lunes
                ,Martes: gridData[i].Martes
                ,Miercoles: gridData[i].Miercoles
                ,Jueves: gridData[i].Jueves
                ,Viernes: gridData[i].Viernes
                ,Sabado: gridData[i].Sabado
                ,Domingo: gridData[i].Domingo
                ,Hora_Inicio: gridData[i].Hora_Inicio
                ,Hora_Fin: gridData[i].Hora_Fin

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Asignacion_de_CitasData.length; i++) {
        if (removedDetalle_de_Asignacion_de_CitasData[i] != null && removedDetalle_de_Asignacion_de_CitasData[i].Clave > 0)
            Detalle_de_Asignacion_de_CitasData.push({
                Clave: removedDetalle_de_Asignacion_de_CitasData[i].Clave

                ,Numero_de_Empleado: removedDetalle_de_Asignacion_de_CitasData[i].Numero_de_Empleado
                ,Nombre_de_Empleado: removedDetalle_de_Asignacion_de_CitasData[i].Nombre_de_Empleado
                ,Lunes: removedDetalle_de_Asignacion_de_CitasData[i].Lunes
                ,Martes: removedDetalle_de_Asignacion_de_CitasData[i].Martes
                ,Miercoles: removedDetalle_de_Asignacion_de_CitasData[i].Miercoles
                ,Jueves: removedDetalle_de_Asignacion_de_CitasData[i].Jueves
                ,Viernes: removedDetalle_de_Asignacion_de_CitasData[i].Viernes
                ,Sabado: removedDetalle_de_Asignacion_de_CitasData[i].Sabado
                ,Domingo: removedDetalle_de_Asignacion_de_CitasData[i].Domingo
                ,Hora_Inicio: removedDetalle_de_Asignacion_de_CitasData[i].Hora_Inicio
                ,Hora_Fin: removedDetalle_de_Asignacion_de_CitasData[i].Hora_Fin

                , Removed: true
            });
    }	

    return Detalle_de_Asignacion_de_CitasData;
}

function Detalle_de_Asignacion_de_CitasEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Asignacion_de_CitasTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Asignacion_de_CitascountRowsChecked++;
    var Detalle_de_Asignacion_de_CitasRowElement = "Detalle_de_Asignacion_de_Citas_" + rowIndex.toString();
    var prevData = Detalle_de_Asignacion_de_CitasTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Asignacion_de_CitasTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Asignacion_de_Citas_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Asignacion_de_CitasGetUpdateRowControls(prevData, "Detalle_de_Asignacion_de_Citas_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Asignacion_de_CitasRowElement + "')){ Detalle_de_Asignacion_de_CitasInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Asignacion_de_CitasCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Asignacion_de_CitasGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Asignacion_de_CitasGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Asignacion_de_CitasValidation();
    initiateUIControls();
    $('.Detalle_de_Asignacion_de_Citas' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Asignacion_de_Citas(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Asignacion_de_CitasfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Asignacion_de_CitasTable.fnGetData().length;
    Detalle_de_Asignacion_de_CitasfnClickAddRow();
    GetAddDetalle_de_Asignacion_de_CitasPopup(currentRowIndex, 0);
}

function Detalle_de_Asignacion_de_CitasEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Asignacion_de_CitasTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Asignacion_de_CitasRowElement = "Detalle_de_Asignacion_de_Citas_" + rowIndex.toString();
    var prevData = Detalle_de_Asignacion_de_CitasTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Asignacion_de_CitasPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Asignacion_de_CitasNumero_de_Empleado').val(prevData.Numero_de_Empleado);
    $('#Detalle_de_Asignacion_de_CitasNombre_de_Empleado').val(prevData.Nombre_de_Empleado);
    $('#Detalle_de_Asignacion_de_CitasLunes').prop('checked', prevData.Lunes);
    $('#Detalle_de_Asignacion_de_CitasMartes').prop('checked', prevData.Martes);
    $('#Detalle_de_Asignacion_de_CitasMiercoles').prop('checked', prevData.Miercoles);
    $('#Detalle_de_Asignacion_de_CitasJueves').prop('checked', prevData.Jueves);
    $('#Detalle_de_Asignacion_de_CitasViernes').prop('checked', prevData.Viernes);
    $('#Detalle_de_Asignacion_de_CitasSabado').prop('checked', prevData.Sabado);
    $('#Detalle_de_Asignacion_de_CitasDomingo').prop('checked', prevData.Domingo);
    $('#Detalle_de_Asignacion_de_CitasHora_Inicio').val(prevData.Hora_Inicio);
    $('#Detalle_de_Asignacion_de_CitasHora_Fin').val(prevData.Hora_Fin);

    initiateUIControls();













}

function Detalle_de_Asignacion_de_CitasAddInsertRow() {
    if (Detalle_de_Asignacion_de_CitasinsertRowCurrentIndex < 1)
    {
        Detalle_de_Asignacion_de_CitasinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Numero_de_Empleado: ""
        ,Nombre_de_Empleado: ""
        ,Lunes: ""
        ,Martes: ""
        ,Miercoles: ""
        ,Jueves: ""
        ,Viernes: ""
        ,Sabado: ""
        ,Domingo: ""
        ,Hora_Inicio: ""
        ,Hora_Fin: ""

    }
}

function Detalle_de_Asignacion_de_CitasfnClickAddRow() {
    Detalle_de_Asignacion_de_CitascountRowsChecked++;
    Detalle_de_Asignacion_de_CitasTable.fnAddData(Detalle_de_Asignacion_de_CitasAddInsertRow(), true);
    Detalle_de_Asignacion_de_CitasTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Asignacion_de_CitasGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Asignacion_de_CitasGrid tbody tr:nth-of-type(' + (Detalle_de_Asignacion_de_CitasinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Asignacion_de_Citas("Detalle_de_Asignacion_de_Citas_", "_" + Detalle_de_Asignacion_de_CitasinsertRowCurrentIndex);
}

function Detalle_de_Asignacion_de_CitasClearGridData() {
    Detalle_de_Asignacion_de_CitasData = [];
    Detalle_de_Asignacion_de_CitasdeletedItem = [];
    Detalle_de_Asignacion_de_CitasDataMain = [];
    Detalle_de_Asignacion_de_CitasDataMainPages = [];
    Detalle_de_Asignacion_de_CitasnewItemCount = 0;
    Detalle_de_Asignacion_de_CitasmaxItemIndex = 0;
    $("#Detalle_de_Asignacion_de_CitasGrid").DataTable().clear();
    $("#Detalle_de_Asignacion_de_CitasGrid").DataTable().destroy();
}

//Used to Get Calendario de Citas Information
function GetDetalle_de_Asignacion_de_Citas() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Asignacion_de_CitasData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Asignacion_de_CitasData[i].Clave);

        form_data.append('[' + i + '].Numero_de_Empleado', Detalle_de_Asignacion_de_CitasData[i].Numero_de_Empleado);
        form_data.append('[' + i + '].Nombre_de_Empleado', Detalle_de_Asignacion_de_CitasData[i].Nombre_de_Empleado);
        form_data.append('[' + i + '].Lunes', Detalle_de_Asignacion_de_CitasData[i].Lunes);
        form_data.append('[' + i + '].Martes', Detalle_de_Asignacion_de_CitasData[i].Martes);
        form_data.append('[' + i + '].Miercoles', Detalle_de_Asignacion_de_CitasData[i].Miercoles);
        form_data.append('[' + i + '].Jueves', Detalle_de_Asignacion_de_CitasData[i].Jueves);
        form_data.append('[' + i + '].Viernes', Detalle_de_Asignacion_de_CitasData[i].Viernes);
        form_data.append('[' + i + '].Sabado', Detalle_de_Asignacion_de_CitasData[i].Sabado);
        form_data.append('[' + i + '].Domingo', Detalle_de_Asignacion_de_CitasData[i].Domingo);
        form_data.append('[' + i + '].Hora_Inicio', Detalle_de_Asignacion_de_CitasData[i].Hora_Inicio);
        form_data.append('[' + i + '].Hora_Fin', Detalle_de_Asignacion_de_CitasData[i].Hora_Fin);

        form_data.append('[' + i + '].Removed', Detalle_de_Asignacion_de_CitasData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Asignacion_de_CitasInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Asignacion_de_Citas("Detalle_de_Asignacion_de_CitasTable", rowIndex)) {
    var prevData = Detalle_de_Asignacion_de_CitasTable.fnGetData(rowIndex);
    var data = Detalle_de_Asignacion_de_CitasTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_Empleado: $('#Detalle_de_Asignacion_de_CitasNumero_de_Empleado').val()
        ,Nombre_de_Empleado: $('#Detalle_de_Asignacion_de_CitasNombre_de_Empleado').val()

        ,Lunes: $('#Detalle_de_Asignacion_de_CitasLunes').is(':checked')
        ,Martes: $('#Detalle_de_Asignacion_de_CitasMartes').is(':checked')
        ,Miercoles: $('#Detalle_de_Asignacion_de_CitasMiercoles').is(':checked')
        ,Jueves: $('#Detalle_de_Asignacion_de_CitasJueves').is(':checked')
        ,Viernes: $('#Detalle_de_Asignacion_de_CitasViernes').is(':checked')
        ,Sabado: $('#Detalle_de_Asignacion_de_CitasSabado').is(':checked')
        ,Domingo: $('#Detalle_de_Asignacion_de_CitasDomingo').is(':checked')
        ,Hora_Inicio: $('#Detalle_de_Asignacion_de_CitasHora_Inicio').val()
        ,Hora_Fin: $('#Detalle_de_Asignacion_de_CitasHora_Fin').val()

    }

    Detalle_de_Asignacion_de_CitasTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Asignacion_de_CitasrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Asignacion_de_Citas-form').modal({ show: false });
    $('#AddDetalle_de_Asignacion_de_Citas-form').modal('hide');
    Detalle_de_Asignacion_de_CitasEditRow(rowIndex);
    Detalle_de_Asignacion_de_CitasInsertRow(rowIndex);
    //}
}
function Detalle_de_Asignacion_de_CitasRemoveAddRow(rowIndex) {
    Detalle_de_Asignacion_de_CitasTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Asignacion_de_Citas MultiRow


$(function () {
    function Detalle_de_Asignacion_de_CitasinitializeMainArray(totalCount) {
        if (Detalle_de_Asignacion_de_CitasDataMain.length != totalCount && !Detalle_de_Asignacion_de_CitasDataMainInitialized) {
            Detalle_de_Asignacion_de_CitasDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Asignacion_de_CitasDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Asignacion_de_CitasremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Asignacion_de_CitasdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Asignacion_de_CitasDataMain.length; i++) {
                if (Detalle_de_Asignacion_de_CitasDataMain[i] != null && Detalle_de_Asignacion_de_CitasDataMain[i].Id == Detalle_de_Asignacion_de_CitasdeletedItem[j]) {
                    hDetalle_de_Asignacion_de_CitasDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Asignacion_de_CitascopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Asignacion_de_CitasDataMain.length; i++) {
            data[i] = Detalle_de_Asignacion_de_CitasDataMain[i];

        }
        return data;
    }
    function Detalle_de_Asignacion_de_CitasgetNewResult() {
        var newData = copyMainDetalle_de_Asignacion_de_CitasArray();

        for (var i = 0; i < Detalle_de_Asignacion_de_CitasData.length; i++) {
            if (Detalle_de_Asignacion_de_CitasData[i].Removed == null || Detalle_de_Asignacion_de_CitasData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Asignacion_de_CitasData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Asignacion_de_CitaspushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Asignacion_de_CitasDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Asignacion_de_CitasDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Calendario_de_Citas_cmbLabelSelect").val();
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
    $('#CreateCalendario_de_Citas')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Detalle_de_Asignacion_de_CitasClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateCalendario_de_Citas').trigger('reset');
    $('#CreateCalendario_de_Citas').find(':input').each(function () {
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
    var $myForm = $('#CreateCalendario_de_Citas');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Asignacion_de_CitascountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Asignacion_de_Citas();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateCalendario_de_Citas").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateCalendario_de_Citas").on('click', '#Calendario_de_CitasCancelar', function () {
	  if (!isPartial) {
        Calendario_de_CitasBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateCalendario_de_Citas").on('click', '#Calendario_de_CitasGuardar', function () {
		$('#Calendario_de_CitasGuardar').attr('disabled', true);
		$('#Calendario_de_CitasGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendCalendario_de_CitasData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Calendario_de_CitasBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Calendario_de_CitasGuardar').removeAttr('disabled');
                        $('#Calendario_de_CitasGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Calendario_de_Citas', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Calendario_de_CitasItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Calendario_de_CitasDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Calendario_de_CitasGuardar').removeAttr('disabled');
					$('#Calendario_de_CitasGuardar').bind()
				}
		}
		else {
			$('#Calendario_de_CitasGuardar').removeAttr('disabled');
			$('#Calendario_de_CitasGuardar').bind()
		}
    });
	$("form#CreateCalendario_de_Citas").on('click', '#Calendario_de_CitasGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendCalendario_de_CitasData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Asignacion_de_CitasData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Calendario_de_Citas', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Calendario_de_CitasItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Calendario_de_CitasDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateCalendario_de_Citas").on('click', '#Calendario_de_CitasGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendCalendario_de_CitasData(function (currentId) {
					$("#ClaveId").val("0");
	                Detalle_de_Asignacion_de_CitasClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_Asignacion_de_CitasData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Calendario_de_Citas',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Calendario_de_CitasItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Calendario_de_CitasDropDown().get(0)').innerHTML);                          
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



var Calendario_de_CitasisdisplayBusinessPropery = false;
Calendario_de_CitasDisplayBusinessRuleButtons(Calendario_de_CitasisdisplayBusinessPropery);
function Calendario_de_CitasDisplayBusinessRule() {
    if (!Calendario_de_CitasisdisplayBusinessPropery) {
        $('#CreateCalendario_de_Citas').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Calendario_de_CitasdisplayBusinessPropery"><button onclick="Calendario_de_CitasGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Calendario_de_CitasBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Calendario_de_CitasdisplayBusinessPropery').remove();
    }
    Calendario_de_CitasDisplayBusinessRuleButtons(!Calendario_de_CitasisdisplayBusinessPropery);
    Calendario_de_CitasisdisplayBusinessPropery = (Calendario_de_CitasisdisplayBusinessPropery ? false : true);
}
function Calendario_de_CitasDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

