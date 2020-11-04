

//Begin Declarations for Foreigns fields for Detalle_de_Folio_Asignado_de_Usuario MultiRow
var Detalle_de_Folio_Asignado_de_UsuariocountRowsChecked = 0;


function GetDetalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioName(Id) {
    for (var i = 0; i < Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioItems.length; i++) {
        if (Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioItems[i].Clave == Id) {
            return Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioDropDown() {
    var Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Folio_Asignado_de_Usuario_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioDropdown);
    if(Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioItems != null)
    {
       for (var i = 0; i < Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioItems.length; i++) {
           $('<option />', { value: Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioItems[i].Clave, text:    Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioItems[i].Descripcion }).appendTo(Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioDropdown);
       }
    }
    return Detalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioDropdown;
}



function GetInsertDetalle_de_Folio_Asignado_de_UsuarioRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Folio_Asignado_de_Usuario_Folio Folio').attr('id', 'Detalle_de_Folio_Asignado_de_Usuario_Folio_' + index).attr('data-field', 'Folio');
    columnData[1] = $(GetDetalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioDropDown()).addClass('Detalle_de_Folio_Asignado_de_Usuario_Estatus_de_Folio Estatus_de_Folio').attr('id', 'Detalle_de_Folio_Asignado_de_Usuario_Estatus_de_Folio_' + index).attr('data-field', 'Estatus_de_Folio').after($.parseHTML(addNew('Detalle_de_Folio_Asignado_de_Usuario', 'Catalogo_de_Estatus_de_Folio', 'Estatus_de_Folio', 265169)));
    columnData[2] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Folio_Asignado_de_Usuario_Fecha_de_Registro Fecha_de_Registro').attr('id', 'Detalle_de_Folio_Asignado_de_Usuario_Fecha_de_Registro_' + index).attr('data-field', 'Fecha_de_Registro');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Folio_Asignado_de_UsuarioInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Folio_Asignado_de_Usuario("Detalle_de_Folio_Asignado_de_Usuario_", "_" + rowIndex)) {
    var iPage = Detalle_de_Folio_Asignado_de_UsuarioTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Folio_Asignado_de_Usuario';
    var prevData = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetData(rowIndex);
    var data = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Folio: data.childNodes[counter++].childNodes[0].value
        ,Estatus_de_Folio:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Registro:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Folio_Asignado_de_UsuarioTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Folio_Asignado_de_UsuariorowCreationGrid(data, newData, rowIndex);
    Detalle_de_Folio_Asignado_de_UsuarioTable.fnPageChange(iPage);
    Detalle_de_Folio_Asignado_de_UsuariocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Folio_Asignado_de_Usuario("Detalle_de_Folio_Asignado_de_Usuario_", "_" + rowIndex);
  }
}

function Detalle_de_Folio_Asignado_de_UsuarioCancelRow(rowIndex) {
    var prevData = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetData(rowIndex);
    var data = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Folio_Asignado_de_UsuarioTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Folio_Asignado_de_UsuariorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Folio_Asignado_de_UsuarioGrid(Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetData());
    Detalle_de_Folio_Asignado_de_UsuariocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Folio_Asignado_de_UsuarioFromDataTable() {
    var Detalle_de_Folio_Asignado_de_UsuarioData = [];
    var gridData = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Folio_Asignado_de_UsuarioData.push({
                Clave: gridData[i].Clave

                ,Folio: gridData[i].Folio
                ,Estatus_de_Folio: gridData[i].Estatus_de_Folio
                ,Fecha_de_Registro: gridData[i].Fecha_de_Registro

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Folio_Asignado_de_UsuarioData.length; i++) {
        if (removedDetalle_de_Folio_Asignado_de_UsuarioData[i] != null && removedDetalle_de_Folio_Asignado_de_UsuarioData[i].Clave > 0)
            Detalle_de_Folio_Asignado_de_UsuarioData.push({
                Clave: removedDetalle_de_Folio_Asignado_de_UsuarioData[i].Clave

                ,Folio: removedDetalle_de_Folio_Asignado_de_UsuarioData[i].Folio
                ,Estatus_de_Folio: removedDetalle_de_Folio_Asignado_de_UsuarioData[i].Estatus_de_Folio
                ,Fecha_de_Registro: removedDetalle_de_Folio_Asignado_de_UsuarioData[i].Fecha_de_Registro

                , Removed: true
            });
    }	

    return Detalle_de_Folio_Asignado_de_UsuarioData;
}

function Detalle_de_Folio_Asignado_de_UsuarioEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Folio_Asignado_de_UsuariocountRowsChecked++;
    var Detalle_de_Folio_Asignado_de_UsuarioRowElement = "Detalle_de_Folio_Asignado_de_Usuario_" + rowIndex.toString();
    var prevData = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Folio_Asignado_de_Usuario_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Folio_Asignado_de_UsuarioGetUpdateRowControls(prevData, "Detalle_de_Folio_Asignado_de_Usuario_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Folio_Asignado_de_UsuarioRowElement + "')){ Detalle_de_Folio_Asignado_de_UsuarioInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Folio_Asignado_de_UsuarioCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Folio_Asignado_de_UsuarioGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Folio_Asignado_de_UsuarioGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Folio_Asignado_de_UsuarioValidation();
    initiateUIControls();
    $('.Detalle_de_Folio_Asignado_de_Usuario' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Folio_Asignado_de_Usuario(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Folio_Asignado_de_UsuariofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetData().length;
    Detalle_de_Folio_Asignado_de_UsuariofnClickAddRow();
    GetAddDetalle_de_Folio_Asignado_de_UsuarioPopup(currentRowIndex, 0);
}

function Detalle_de_Folio_Asignado_de_UsuarioEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Folio_Asignado_de_UsuarioRowElement = "Detalle_de_Folio_Asignado_de_Usuario_" + rowIndex.toString();
    var prevData = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Folio_Asignado_de_UsuarioPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Folio_Asignado_de_UsuarioFolio').val(prevData.Folio);
    $('#Detalle_de_Folio_Asignado_de_UsuarioEstatus_de_Folio').val(prevData.Estatus_de_Folio);
    $('#Detalle_de_Folio_Asignado_de_UsuarioFecha_de_Registro').val(prevData.Fecha_de_Registro);

    initiateUIControls();





}

function Detalle_de_Folio_Asignado_de_UsuarioAddInsertRow() {
    if (Detalle_de_Folio_Asignado_de_UsuarioinsertRowCurrentIndex < 1)
    {
        Detalle_de_Folio_Asignado_de_UsuarioinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Folio: ""
        ,Estatus_de_Folio: ""
        ,Fecha_de_Registro: ""

    }
}

function Detalle_de_Folio_Asignado_de_UsuariofnClickAddRow() {
    Detalle_de_Folio_Asignado_de_UsuariocountRowsChecked++;
    Detalle_de_Folio_Asignado_de_UsuarioTable.fnAddData(Detalle_de_Folio_Asignado_de_UsuarioAddInsertRow(), true);
    Detalle_de_Folio_Asignado_de_UsuarioTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Folio_Asignado_de_UsuarioGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Folio_Asignado_de_UsuarioGrid tbody tr:nth-of-type(' + (Detalle_de_Folio_Asignado_de_UsuarioinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Folio_Asignado_de_Usuario("Detalle_de_Folio_Asignado_de_Usuario_", "_" + Detalle_de_Folio_Asignado_de_UsuarioinsertRowCurrentIndex);
}

function Detalle_de_Folio_Asignado_de_UsuarioClearGridData() {
    Detalle_de_Folio_Asignado_de_UsuarioData = [];
    Detalle_de_Folio_Asignado_de_UsuariodeletedItem = [];
    Detalle_de_Folio_Asignado_de_UsuarioDataMain = [];
    Detalle_de_Folio_Asignado_de_UsuarioDataMainPages = [];
    Detalle_de_Folio_Asignado_de_UsuarionewItemCount = 0;
    Detalle_de_Folio_Asignado_de_UsuariomaxItemIndex = 0;
    $("#Detalle_de_Folio_Asignado_de_UsuarioGrid").DataTable().clear();
    $("#Detalle_de_Folio_Asignado_de_UsuarioGrid").DataTable().destroy();
}

//Used to Get Registro de Usuario Information
function GetDetalle_de_Folio_Asignado_de_Usuario() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Folio_Asignado_de_UsuarioData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Folio_Asignado_de_UsuarioData[i].Clave);

        form_data.append('[' + i + '].Folio', Detalle_de_Folio_Asignado_de_UsuarioData[i].Folio);
        form_data.append('[' + i + '].Estatus_de_Folio', Detalle_de_Folio_Asignado_de_UsuarioData[i].Estatus_de_Folio);
        form_data.append('[' + i + '].Fecha_de_Registro', Detalle_de_Folio_Asignado_de_UsuarioData[i].Fecha_de_Registro);

        form_data.append('[' + i + '].Removed', Detalle_de_Folio_Asignado_de_UsuarioData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Folio_Asignado_de_UsuarioInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Folio_Asignado_de_Usuario("Detalle_de_Folio_Asignado_de_UsuarioTable", rowIndex)) {
    var prevData = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetData(rowIndex);
    var data = Detalle_de_Folio_Asignado_de_UsuarioTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Folio: $('#Detalle_de_Folio_Asignado_de_UsuarioFolio').val()

        ,Estatus_de_Folio: $('#Detalle_de_Folio_Asignado_de_UsuarioEstatus_de_Folio').val()
        ,Fecha_de_Registro: $('#Detalle_de_Folio_Asignado_de_UsuarioFecha_de_Registro').val()

    }

    Detalle_de_Folio_Asignado_de_UsuarioTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Folio_Asignado_de_UsuariorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Folio_Asignado_de_Usuario-form').modal({ show: false });
    $('#AddDetalle_de_Folio_Asignado_de_Usuario-form').modal('hide');
    Detalle_de_Folio_Asignado_de_UsuarioEditRow(rowIndex);
    Detalle_de_Folio_Asignado_de_UsuarioInsertRow(rowIndex);
    //}
}
function Detalle_de_Folio_Asignado_de_UsuarioRemoveAddRow(rowIndex) {
    Detalle_de_Folio_Asignado_de_UsuarioTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Folio_Asignado_de_Usuario MultiRow


$(function () {
    function Detalle_de_Folio_Asignado_de_UsuarioinitializeMainArray(totalCount) {
        if (Detalle_de_Folio_Asignado_de_UsuarioDataMain.length != totalCount && !Detalle_de_Folio_Asignado_de_UsuarioDataMainInitialized) {
            Detalle_de_Folio_Asignado_de_UsuarioDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Folio_Asignado_de_UsuarioDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Folio_Asignado_de_UsuarioremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Folio_Asignado_de_UsuariodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Folio_Asignado_de_UsuarioDataMain.length; i++) {
                if (Detalle_de_Folio_Asignado_de_UsuarioDataMain[i] != null && Detalle_de_Folio_Asignado_de_UsuarioDataMain[i].Id == Detalle_de_Folio_Asignado_de_UsuariodeletedItem[j]) {
                    hDetalle_de_Folio_Asignado_de_UsuarioDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Folio_Asignado_de_UsuariocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Folio_Asignado_de_UsuarioDataMain.length; i++) {
            data[i] = Detalle_de_Folio_Asignado_de_UsuarioDataMain[i];

        }
        return data;
    }
    function Detalle_de_Folio_Asignado_de_UsuariogetNewResult() {
        var newData = copyMainDetalle_de_Folio_Asignado_de_UsuarioArray();

        for (var i = 0; i < Detalle_de_Folio_Asignado_de_UsuarioData.length; i++) {
            if (Detalle_de_Folio_Asignado_de_UsuarioData[i].Removed == null || Detalle_de_Folio_Asignado_de_UsuarioData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Folio_Asignado_de_UsuarioData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Folio_Asignado_de_UsuariopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Folio_Asignado_de_UsuarioDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Folio_Asignado_de_UsuarioDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteNombreData = [];
function GetAutoCompleteUsuario_Nombre_Spartan_UserData(data) {
	AutoCompleteNombreData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNombreData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteNombreData;
}
//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Usuario_cmbLabelSelect").val();
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
    $('#CreateUsuario')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Nombre').empty();
    $("#Nombre").append('<option value=""></option>');
    $('#Nombre').val('0').trigger('change');
                Detalle_de_Folio_Asignado_de_UsuarioClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateUsuario').trigger('reset');
    $('#CreateUsuario').find(':input').each(function () {
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
    var $myForm = $('#CreateUsuario');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Folio_Asignado_de_UsuariocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Folio_Asignado_de_Usuario();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateUsuario").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateUsuario").on('click', '#UsuarioCancelar', function () {
	  if (!isPartial) {
        UsuarioBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateUsuario").on('click', '#UsuarioGuardar', function () {
		$('#UsuarioGuardar').attr('disabled', true);
		$('#UsuarioGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendUsuarioData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						UsuarioBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#UsuarioGuardar').removeAttr('disabled');
                        $('#UsuarioGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Usuario', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_UsuarioItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_UsuarioDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#UsuarioGuardar').removeAttr('disabled');
					$('#UsuarioGuardar').bind()
				}
		}
		else {
			$('#UsuarioGuardar').removeAttr('disabled');
			$('#UsuarioGuardar').bind()
		}
    });
	$("form#CreateUsuario").on('click', '#UsuarioGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendUsuarioData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Folio_Asignado_de_UsuarioData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Usuario', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_UsuarioItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_UsuarioDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateUsuario").on('click', '#UsuarioGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendUsuarioData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Nombre').empty();
    $("#Nombre").append('<option value=""></option>');
    $('#Nombre').val('0').trigger('change');
                Detalle_de_Folio_Asignado_de_UsuarioClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_Folio_Asignado_de_UsuarioData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Usuario',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_UsuarioItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_UsuarioDropDown().get(0)').innerHTML);                          
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



var UsuarioisdisplayBusinessPropery = false;
UsuarioDisplayBusinessRuleButtons(UsuarioisdisplayBusinessPropery);
function UsuarioDisplayBusinessRule() {
    if (!UsuarioisdisplayBusinessPropery) {
        $('#CreateUsuario').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="UsuariodisplayBusinessPropery"><button onclick="UsuarioGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#UsuarioBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.UsuariodisplayBusinessPropery').remove();
    }
    UsuarioDisplayBusinessRuleButtons(!UsuarioisdisplayBusinessPropery);
    UsuarioisdisplayBusinessPropery = (UsuarioisdisplayBusinessPropery ? false : true);
}
function UsuarioDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

