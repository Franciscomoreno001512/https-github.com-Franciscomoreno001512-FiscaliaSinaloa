

//Begin Declarations for Foreigns fields for Detalle_Datos_Adicionales_Movimiento MultiRow
var Detalle_Datos_Adicionales_MovimientocountRowsChecked = 0;


function GetDetalle_Datos_Adicionales_Movimiento_Tipo_de_DatoName(Id) {
    for (var i = 0; i < Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoItems.length; i++) {
        if (Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoItems[i].Clave == Id) {
            return Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_Adicionales_Movimiento_Tipo_de_DatoDropDown() {
    var Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_Adicionales_Movimiento_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoDropdown);
    if(Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoItems[i].Clave, text:    Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoItems[i].Descripcion }).appendTo(Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoDropdown);
       }
    }
    return Detalle_Datos_Adicionales_Movimiento_Tipo_de_DatoDropdown;
}
function GetDetalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosName(Id) {
    for (var i = 0; i < Detalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosItems.length; i++) {
        if (Detalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosItems[i].ObjectId == Id) {
            return Detalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosDropDown() {
    var Detalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_Adicionales_Movimiento_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosDropdown);

    for (var i = 0; i < Detalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosItems.length; i++) {
        $('<option />', { value: Detalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosItems[i].ObjectId, text: Detalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosItems[i].Descripcion }).appendTo(Detalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosDropdown);
    }
    return Detalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosDropdown;
}



function GetInsertDetalle_Datos_Adicionales_MovimientoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_Datos_Adicionales_Movimiento_Dato Dato').attr('id', 'Detalle_Datos_Adicionales_Movimiento_Dato_' + index).attr('data-field', 'Dato');
    columnData[1] = $(GetDetalle_Datos_Adicionales_Movimiento_Tipo_de_DatoDropDown()).addClass('Detalle_Datos_Adicionales_Movimiento_Tipo_de_Dato Tipo_de_Dato').attr('id', 'Detalle_Datos_Adicionales_Movimiento_Tipo_de_Dato_' + index).attr('data-field', 'Tipo_de_Dato').after($.parseHTML(addNew('Detalle_Datos_Adicionales_Movimiento', 'Tipo_de_Dato', 'Tipo_de_Dato', 268531)));
    columnData[2] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Datos_Adicionales_Movimiento_Relacion'))).addClass('Detalle_Datos_Adicionales_Movimiento_Relacion Relacion').attr('id', 'Detalle_Datos_Adicionales_Movimiento_Relacion_' + index).attr('data-field', 'Relacion').after($.parseHTML(addNew('Detalle_Datos_Adicionales_Movimiento', 'Relaciones_para_Movimientos', 'Relacion', 268532)));
    columnData[3] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Datos_Adicionales_Movimiento_Obligatorio Obligatorio').attr('id', 'Detalle_Datos_Adicionales_Movimiento_Obligatorio_' + index).attr('data-field', 'Obligatorio');


    initiateUIControls();
    return columnData;
}

function Detalle_Datos_Adicionales_MovimientoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Datos_Adicionales_Movimiento("Detalle_Datos_Adicionales_Movimiento_", "_" + rowIndex)) {
    var iPage = Detalle_Datos_Adicionales_MovimientoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Datos_Adicionales_Movimiento';
    var prevData = Detalle_Datos_Adicionales_MovimientoTable.fnGetData(rowIndex);
    var data = Detalle_Datos_Adicionales_MovimientoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Dato:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Dato:  data.childNodes[counter++].childNodes[0].value
        , RelacionDescripcion:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Relacion:  data.childNodes[counter++].childNodes[0].value 	
        ,Obligatorio: $(data.childNodes[counter++].childNodes[2]).is(':checked')

    }
    Detalle_Datos_Adicionales_MovimientoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Datos_Adicionales_MovimientorowCreationGrid(data, newData, rowIndex);
    Detalle_Datos_Adicionales_MovimientoTable.fnPageChange(iPage);
    Detalle_Datos_Adicionales_MovimientocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Datos_Adicionales_Movimiento("Detalle_Datos_Adicionales_Movimiento_", "_" + rowIndex);
  }
}

function Detalle_Datos_Adicionales_MovimientoCancelRow(rowIndex) {
    var prevData = Detalle_Datos_Adicionales_MovimientoTable.fnGetData(rowIndex);
    var data = Detalle_Datos_Adicionales_MovimientoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Datos_Adicionales_MovimientoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Datos_Adicionales_MovimientorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Datos_Adicionales_MovimientoGrid(Detalle_Datos_Adicionales_MovimientoTable.fnGetData());
    Detalle_Datos_Adicionales_MovimientocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Datos_Adicionales_MovimientoFromDataTable() {
    var Detalle_Datos_Adicionales_MovimientoData = [];
    var gridData = Detalle_Datos_Adicionales_MovimientoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Datos_Adicionales_MovimientoData.push({
                Clave: gridData[i].Clave

                ,Dato: gridData[i].Dato
                ,Tipo_de_Dato: gridData[i].Tipo_de_Dato
                ,Relacion: gridData[i].Relacion
                ,Obligatorio: gridData[i].Obligatorio

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Datos_Adicionales_MovimientoData.length; i++) {
        if (removedDetalle_Datos_Adicionales_MovimientoData[i] != null && removedDetalle_Datos_Adicionales_MovimientoData[i].Clave > 0)
            Detalle_Datos_Adicionales_MovimientoData.push({
                Clave: removedDetalle_Datos_Adicionales_MovimientoData[i].Clave

                ,Dato: removedDetalle_Datos_Adicionales_MovimientoData[i].Dato
                ,Tipo_de_Dato: removedDetalle_Datos_Adicionales_MovimientoData[i].Tipo_de_Dato
                ,Relacion: removedDetalle_Datos_Adicionales_MovimientoData[i].Relacion
                ,Obligatorio: removedDetalle_Datos_Adicionales_MovimientoData[i].Obligatorio

                , Removed: true
            });
    }	

    return Detalle_Datos_Adicionales_MovimientoData;
}

function Detalle_Datos_Adicionales_MovimientoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Datos_Adicionales_MovimientoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Datos_Adicionales_MovimientocountRowsChecked++;
    var Detalle_Datos_Adicionales_MovimientoRowElement = "Detalle_Datos_Adicionales_Movimiento_" + rowIndex.toString();
    var prevData = Detalle_Datos_Adicionales_MovimientoTable.fnGetData(rowIndexTable );
    var row = Detalle_Datos_Adicionales_MovimientoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Datos_Adicionales_Movimiento_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Datos_Adicionales_MovimientoGetUpdateRowControls(prevData, "Detalle_Datos_Adicionales_Movimiento_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Datos_Adicionales_MovimientoRowElement + "')){ Detalle_Datos_Adicionales_MovimientoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Datos_Adicionales_MovimientoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Datos_Adicionales_MovimientoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Datos_Adicionales_MovimientoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Datos_Adicionales_MovimientoValidation();
    initiateUIControls();
    $('.Detalle_Datos_Adicionales_Movimiento' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Datos_Adicionales_Movimiento(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Datos_Adicionales_MovimientofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Datos_Adicionales_MovimientoTable.fnGetData().length;
    Detalle_Datos_Adicionales_MovimientofnClickAddRow();
    GetAddDetalle_Datos_Adicionales_MovimientoPopup(currentRowIndex, 0);
}

function Detalle_Datos_Adicionales_MovimientoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Datos_Adicionales_MovimientoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Datos_Adicionales_MovimientoRowElement = "Detalle_Datos_Adicionales_Movimiento_" + rowIndex.toString();
    var prevData = Detalle_Datos_Adicionales_MovimientoTable.fnGetData(rowIndexTable);
    GetAddDetalle_Datos_Adicionales_MovimientoPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Datos_Adicionales_MovimientoDato').val(prevData.Dato);
    $('#Detalle_Datos_Adicionales_MovimientoTipo_de_Dato').val(prevData.Tipo_de_Dato);
    $('#dvDetalle_Datos_Adicionales_MovimientoRelacion').html($($.parseHTML(GetGridAutoComplete(prevData.Relacion.label,'AutoCompleteRelacion'))).addClass('Detalle_Datos_Adicionales_Movimiento_Relacion'));
    $('#Detalle_Datos_Adicionales_MovimientoObligatorio').prop('checked', prevData.Obligatorio);

    initiateUIControls();






}

function Detalle_Datos_Adicionales_MovimientoAddInsertRow() {
    if (Detalle_Datos_Adicionales_MovimientoinsertRowCurrentIndex < 1)
    {
        Detalle_Datos_Adicionales_MovimientoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Dato: ""
        ,Tipo_de_Dato: ""
        ,Relacion: ""
        ,Obligatorio: ""

    }
}

function Detalle_Datos_Adicionales_MovimientofnClickAddRow() {
    Detalle_Datos_Adicionales_MovimientocountRowsChecked++;
    Detalle_Datos_Adicionales_MovimientoTable.fnAddData(Detalle_Datos_Adicionales_MovimientoAddInsertRow(), true);
    Detalle_Datos_Adicionales_MovimientoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Datos_Adicionales_MovimientoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Datos_Adicionales_MovimientoGrid tbody tr:nth-of-type(' + (Detalle_Datos_Adicionales_MovimientoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Datos_Adicionales_Movimiento("Detalle_Datos_Adicionales_Movimiento_", "_" + Detalle_Datos_Adicionales_MovimientoinsertRowCurrentIndex);
}

function Detalle_Datos_Adicionales_MovimientoClearGridData() {
    Detalle_Datos_Adicionales_MovimientoData = [];
    Detalle_Datos_Adicionales_MovimientodeletedItem = [];
    Detalle_Datos_Adicionales_MovimientoDataMain = [];
    Detalle_Datos_Adicionales_MovimientoDataMainPages = [];
    Detalle_Datos_Adicionales_MovimientonewItemCount = 0;
    Detalle_Datos_Adicionales_MovimientomaxItemIndex = 0;
    $("#Detalle_Datos_Adicionales_MovimientoGrid").DataTable().clear();
    $("#Detalle_Datos_Adicionales_MovimientoGrid").DataTable().destroy();
}

//Used to Get Configurador de Movimientos Information
function GetDetalle_Datos_Adicionales_Movimiento() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Datos_Adicionales_MovimientoData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Datos_Adicionales_MovimientoData[i].Clave);

        form_data.append('[' + i + '].Dato', Detalle_Datos_Adicionales_MovimientoData[i].Dato);
        form_data.append('[' + i + '].Tipo_de_Dato', Detalle_Datos_Adicionales_MovimientoData[i].Tipo_de_Dato);
        form_data.append('[' + i + '].Relacion', Detalle_Datos_Adicionales_MovimientoData[i].Relacion);
        form_data.append('[' + i + '].Obligatorio', Detalle_Datos_Adicionales_MovimientoData[i].Obligatorio);

        form_data.append('[' + i + '].Removed', Detalle_Datos_Adicionales_MovimientoData[i].Removed);
    }
    return form_data;
}
function Detalle_Datos_Adicionales_MovimientoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Datos_Adicionales_Movimiento("Detalle_Datos_Adicionales_MovimientoTable", rowIndex)) {
    var prevData = Detalle_Datos_Adicionales_MovimientoTable.fnGetData(rowIndex);
    var data = Detalle_Datos_Adicionales_MovimientoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Dato: $('#Detalle_Datos_Adicionales_MovimientoDato').val()
        ,Tipo_de_Dato: $('#Detalle_Datos_Adicionales_MovimientoTipo_de_Dato').val()
        ,Relacion: $('#Detalle_Datos_Adicionales_MovimientoRelacion').val()
        ,Obligatorio: $('#Detalle_Datos_Adicionales_MovimientoObligatorio').is(':checked')

    }

    Detalle_Datos_Adicionales_MovimientoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Datos_Adicionales_MovimientorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Datos_Adicionales_Movimiento-form').modal({ show: false });
    $('#AddDetalle_Datos_Adicionales_Movimiento-form').modal('hide');
    Detalle_Datos_Adicionales_MovimientoEditRow(rowIndex);
    Detalle_Datos_Adicionales_MovimientoInsertRow(rowIndex);
    //}
}
function Detalle_Datos_Adicionales_MovimientoRemoveAddRow(rowIndex) {
    Detalle_Datos_Adicionales_MovimientoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Datos_Adicionales_Movimiento MultiRow


$(function () {
    function Detalle_Datos_Adicionales_MovimientoinitializeMainArray(totalCount) {
        if (Detalle_Datos_Adicionales_MovimientoDataMain.length != totalCount && !Detalle_Datos_Adicionales_MovimientoDataMainInitialized) {
            Detalle_Datos_Adicionales_MovimientoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Datos_Adicionales_MovimientoDataMain[i] = null;
            }
        }
    }
    function Detalle_Datos_Adicionales_MovimientoremoveFromMainArray() {
        for (var j = 0; j < Detalle_Datos_Adicionales_MovimientodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Datos_Adicionales_MovimientoDataMain.length; i++) {
                if (Detalle_Datos_Adicionales_MovimientoDataMain[i] != null && Detalle_Datos_Adicionales_MovimientoDataMain[i].Id == Detalle_Datos_Adicionales_MovimientodeletedItem[j]) {
                    hDetalle_Datos_Adicionales_MovimientoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Datos_Adicionales_MovimientocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Datos_Adicionales_MovimientoDataMain.length; i++) {
            data[i] = Detalle_Datos_Adicionales_MovimientoDataMain[i];

        }
        return data;
    }
    function Detalle_Datos_Adicionales_MovimientogetNewResult() {
        var newData = copyMainDetalle_Datos_Adicionales_MovimientoArray();

        for (var i = 0; i < Detalle_Datos_Adicionales_MovimientoData.length; i++) {
            if (Detalle_Datos_Adicionales_MovimientoData[i].Removed == null || Detalle_Datos_Adicionales_MovimientoData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Datos_Adicionales_MovimientoData[i]);
            }
        }
        return newData;
    }
    function Detalle_Datos_Adicionales_MovimientopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Datos_Adicionales_MovimientoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Datos_Adicionales_MovimientoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete
var AutoCompleteRelacionData = [];
function GetAutoCompleteDetalle_Datos_Adicionales_Movimiento_Relacion_Relaciones_para_MovimientosData(data) {
	AutoCompleteRelacionData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteRelacionData.push({
            id: data[i].ObjectId,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteRelacionData;
}



function getDropdown(elementKey) {
    var labelSelect = $("#Configurador_de_Movimientos_cmbLabelSelect").val();
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
    $('#CreateConfigurador_de_Movimientos')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Detalle_Datos_Adicionales_MovimientoClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateConfigurador_de_Movimientos').trigger('reset');
    $('#CreateConfigurador_de_Movimientos').find(':input').each(function () {
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
    var $myForm = $('#CreateConfigurador_de_Movimientos');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Datos_Adicionales_MovimientocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Datos_Adicionales_Movimiento();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateConfigurador_de_Movimientos").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateConfigurador_de_Movimientos").on('click', '#Configurador_de_MovimientosCancelar', function () {
	  if (!isPartial) {
        Configurador_de_MovimientosBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateConfigurador_de_Movimientos").on('click', '#Configurador_de_MovimientosGuardar', function () {
		$('#Configurador_de_MovimientosGuardar').attr('disabled', true);
		$('#Configurador_de_MovimientosGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendConfigurador_de_MovimientosData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Configurador_de_MovimientosBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Configurador_de_MovimientosGuardar').removeAttr('disabled');
                        $('#Configurador_de_MovimientosGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Configurador_de_Movimientos', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Configurador_de_MovimientosItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Configurador_de_MovimientosDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Configurador_de_MovimientosGuardar').removeAttr('disabled');
					$('#Configurador_de_MovimientosGuardar').bind()
				}
		}
		else {
			$('#Configurador_de_MovimientosGuardar').removeAttr('disabled');
			$('#Configurador_de_MovimientosGuardar').bind()
		}
    });
	$("form#CreateConfigurador_de_Movimientos").on('click', '#Configurador_de_MovimientosGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendConfigurador_de_MovimientosData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Datos_Adicionales_MovimientoData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Configurador_de_Movimientos', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Configurador_de_MovimientosItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Configurador_de_MovimientosDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateConfigurador_de_Movimientos").on('click', '#Configurador_de_MovimientosGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendConfigurador_de_MovimientosData(function (currentId) {
					$("#ClaveId").val("0");
	                Detalle_Datos_Adicionales_MovimientoClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Datos_Adicionales_MovimientoData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Configurador_de_Movimientos',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Configurador_de_MovimientosItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Configurador_de_MovimientosDropDown().get(0)').innerHTML);                          
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



var Configurador_de_MovimientosisdisplayBusinessPropery = false;
Configurador_de_MovimientosDisplayBusinessRuleButtons(Configurador_de_MovimientosisdisplayBusinessPropery);
function Configurador_de_MovimientosDisplayBusinessRule() {
    if (!Configurador_de_MovimientosisdisplayBusinessPropery) {
        $('#CreateConfigurador_de_Movimientos').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Configurador_de_MovimientosdisplayBusinessPropery"><button onclick="Configurador_de_MovimientosGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Configurador_de_MovimientosBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Configurador_de_MovimientosdisplayBusinessPropery').remove();
    }
    Configurador_de_MovimientosDisplayBusinessRuleButtons(!Configurador_de_MovimientosisdisplayBusinessPropery);
    Configurador_de_MovimientosisdisplayBusinessPropery = (Configurador_de_MovimientosisdisplayBusinessPropery ? false : true);
}
function Configurador_de_MovimientosDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

