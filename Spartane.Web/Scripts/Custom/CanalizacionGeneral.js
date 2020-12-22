

//Begin Declarations for Foreigns fields for Detalle_Diligencias_Canalizacion MultiRow
var Detalle_Diligencias_CanalizacioncountRowsChecked = 0;






function GetInsertDetalle_Diligencias_CanalizacionRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_Diligencias_Canalizacion_Diligencia Diligencia').attr('id', 'Detalle_Diligencias_Canalizacion_Diligencia_' + index).attr('data-field', 'Diligencia');
    columnData[3] = $($.parseHTML(GetFileUploader())).addClass('Detalle_Diligencias_Canalizacion_Ver_Documento_FileUpload Ver_Documento').attr('id', 'Detalle_Diligencias_Canalizacion_Ver_Documento_' + index).attr('data-field', 'Ver_Documento');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_Diligencias_Canalizacion_Observaciones Observaciones').attr('id', 'Detalle_Diligencias_Canalizacion_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_Diligencias_CanalizacionInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Diligencias_Canalizacion("Detalle_Diligencias_Canalizacion_", "_" + rowIndex)) {
    var iPage = Detalle_Diligencias_CanalizacionTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Diligencias_Canalizacion';
    var prevData = Detalle_Diligencias_CanalizacionTable.fnGetData(rowIndex);
    var data = Detalle_Diligencias_CanalizacionTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Diligencia:  data.childNodes[counter++].childNodes[0].value
        ,Ver_DocumentoFileInfo: ($('#' + nameOfGrid + 'Grid .Ver_DocumentoHeader').css('display') != 'none') ? { 
             FileName: prevData.Ver_DocumentoFileInfo != null && prevData.Ver_DocumentoFileInfo.FileName != null && prevData.Ver_DocumentoFileInfo.FileName != ''? prevData.Ver_DocumentoFileInfo.FileName : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : ''),              
			 FileId:   prevData.Ver_DocumentoFileInfo != null && prevData.Ver_DocumentoFileInfo.FileName != null && prevData.Ver_DocumentoFileInfo.FileName != '' ? prevData.Ver_DocumentoFileInfo.FileId :  prevData.Ver_DocumentoFileInfo != null && prevData.Ver_DocumentoFileInfo.FileId != '' && prevData.Ver_DocumentoFileInfo.FileId != undefined ? prevData.Ver_DocumentoFileInfo.FileId : '0',
             FileSize: prevData.Ver_DocumentoFileInfo != null && prevData.Ver_DocumentoFileInfo.FileName != null ? prevData.Ver_DocumentoFileInfo.FileSize : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : '') 
         } : ''
        ,Ver_DocumentoDetail: (data.childNodes[counter] != 'undefined' && data.childNodes[counter].childNodes[0].childNodes.length == 0) ? data.childNodes[counter++].childNodes[0] : prevData.Ver_DocumentoDetail
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Diligencias_CanalizacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Diligencias_CanalizacionrowCreationGrid(data, newData, rowIndex);
    Detalle_Diligencias_CanalizacionTable.fnPageChange(iPage);
    Detalle_Diligencias_CanalizacioncountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Diligencias_Canalizacion("Detalle_Diligencias_Canalizacion_", "_" + rowIndex);
  }
}

function Detalle_Diligencias_CanalizacionCancelRow(rowIndex) {
    var prevData = Detalle_Diligencias_CanalizacionTable.fnGetData(rowIndex);
    var data = Detalle_Diligencias_CanalizacionTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Diligencias_CanalizacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Diligencias_CanalizacionrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Diligencias_CanalizacionGrid(Detalle_Diligencias_CanalizacionTable.fnGetData());
    Detalle_Diligencias_CanalizacioncountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Diligencias_CanalizacionFromDataTable() {
    var Detalle_Diligencias_CanalizacionData = [];
    var gridData = Detalle_Diligencias_CanalizacionTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Diligencias_CanalizacionData.push({
                Clave: gridData[i].Clave

                ,Diligencia: gridData[i].Diligencia
                ,Ver_DocumentoInfo: {
                    FileName: gridData[i].Ver_DocumentoFileInfo.FileName, FileId: gridData[i].Ver_DocumentoFileInfo.FileId, FileSize: gridData[i].Ver_DocumentoFileInfo.FileSize,
                    Control: gridData[i].Ver_DocumentoDetail != null && gridData[i].Ver_DocumentoDetail.files != null && gridData[i].Ver_DocumentoDetail.files.length > 0 ? gridData[i].Ver_DocumentoDetail.files[0] : null,
                    Ver_DocumentoRemoveFile: gridData[i].Ver_DocumentoDetail != null
                }
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Diligencias_CanalizacionData.length; i++) {
        if (removedDetalle_Diligencias_CanalizacionData[i] != null && removedDetalle_Diligencias_CanalizacionData[i].Clave > 0)
            Detalle_Diligencias_CanalizacionData.push({
                Clave: removedDetalle_Diligencias_CanalizacionData[i].Clave

                ,Diligencia: removedDetalle_Diligencias_CanalizacionData[i].Diligencia
                ,Ver_DocumentoInfo: {
                    FileName: removedDetalle_Diligencias_CanalizacionData[i].Ver_DocumentoFileInfo.FileName, 
                    FileId: removedDetalle_Diligencias_CanalizacionData[i].Ver_DocumentoFileInfo.FileId, 
                    FileSize: removedDetalle_Diligencias_CanalizacionData[i].Ver_DocumentoFileInfo.FileSize,
                    Control: removedDetalle_Diligencias_CanalizacionData[i].Ver_DocumentoDetail != null && removedDetalle_Diligencias_CanalizacionData[i].Ver_DocumentoDetail.files.length > 0 ? removedDetalle_Diligencias_CanalizacionData[i].Ver_DocumentoDetail.files[0] : null,
                    Ver_DocumentoRemoveFile: removedDetalle_Diligencias_CanalizacionData[i].Ver_DocumentoDetail != null
                }
                ,Observaciones: removedDetalle_Diligencias_CanalizacionData[i].Observaciones

                , Removed: true
            });
    }	

    return Detalle_Diligencias_CanalizacionData;
}

function Detalle_Diligencias_CanalizacionEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Diligencias_CanalizacionTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Diligencias_CanalizacioncountRowsChecked++;
    var Detalle_Diligencias_CanalizacionRowElement = "Detalle_Diligencias_Canalizacion_" + rowIndex.toString();
    var prevData = Detalle_Diligencias_CanalizacionTable.fnGetData(rowIndexTable );
    var row = Detalle_Diligencias_CanalizacionTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Diligencias_Canalizacion_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Diligencias_CanalizacionGetUpdateRowControls(prevData, "Detalle_Diligencias_Canalizacion_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Diligencias_CanalizacionRowElement + "')){ Detalle_Diligencias_CanalizacionInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Diligencias_CanalizacionCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Diligencias_CanalizacionGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Diligencias_CanalizacionGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Diligencias_CanalizacionValidation();
    initiateUIControls();
    $('.Detalle_Diligencias_Canalizacion' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Diligencias_CanalizacionfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Diligencias_CanalizacionTable.fnGetData().length;
    Detalle_Diligencias_CanalizacionfnClickAddRow();
    GetAddDetalle_Diligencias_CanalizacionPopup(currentRowIndex, 0);
}

function Detalle_Diligencias_CanalizacionEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Diligencias_CanalizacionTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Diligencias_CanalizacionRowElement = "Detalle_Diligencias_Canalizacion_" + rowIndex.toString();
    var prevData = Detalle_Diligencias_CanalizacionTable.fnGetData(rowIndexTable);
    GetAddDetalle_Diligencias_CanalizacionPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Diligencias_CanalizacionDiligencia').val(prevData.Diligencia);

    $('#Detalle_Diligencias_CanalizacionObservaciones').val(prevData.Observaciones);

    initiateUIControls();


    $('#existingVer_Documento').html(prevData.Ver_DocumentoFileDetail == null && (prevData.Ver_DocumentoFileInfo.FileId == null || prevData.Ver_DocumentoFileInfo.FileId <= 0) ? $.parseHTML(GetFileUploader()) : GetFileInfo(prevData.Ver_DocumentoFileInfo, prevData.Ver_DocumentoFileDetail));


}

function Detalle_Diligencias_CanalizacionAddInsertRow() {
    if (Detalle_Diligencias_CanalizacioninsertRowCurrentIndex < 1)
    {
        Detalle_Diligencias_CanalizacioninsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Diligencia: ""
        ,Ver_DocumentoFileInfo: ""
        ,Observaciones: ""

    }
}

function Detalle_Diligencias_CanalizacionfnClickAddRow() {
    Detalle_Diligencias_CanalizacioncountRowsChecked++;
    Detalle_Diligencias_CanalizacionTable.fnAddData(Detalle_Diligencias_CanalizacionAddInsertRow(), true);
    Detalle_Diligencias_CanalizacionTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Diligencias_CanalizacionGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Diligencias_CanalizacionGrid tbody tr:nth-of-type(' + (Detalle_Diligencias_CanalizacioninsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Diligencias_Canalizacion("Detalle_Diligencias_Canalizacion_", "_" + Detalle_Diligencias_CanalizacioninsertRowCurrentIndex);
}

function Detalle_Diligencias_CanalizacionClearGridData() {
    Detalle_Diligencias_CanalizacionData = [];
    Detalle_Diligencias_CanalizaciondeletedItem = [];
    Detalle_Diligencias_CanalizacionDataMain = [];
    Detalle_Diligencias_CanalizacionDataMainPages = [];
    Detalle_Diligencias_CanalizacionnewItemCount = 0;
    Detalle_Diligencias_CanalizacionmaxItemIndex = 0;
    $("#Detalle_Diligencias_CanalizacionGrid").DataTable().clear();
    $("#Detalle_Diligencias_CanalizacionGrid").DataTable().destroy();
}

//Used to Get Canalización Information
function GetDetalle_Diligencias_Canalizacion() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Diligencias_CanalizacionData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Diligencias_CanalizacionData[i].Clave);

        form_data.append('[' + i + '].Diligencia', Detalle_Diligencias_CanalizacionData[i].Diligencia);
        form_data.append('[' + i + '].Ver_DocumentoInfo.FileId', Detalle_Diligencias_CanalizacionData[i].Ver_DocumentoInfo.FileId);
        form_data.append('[' + i + '].Ver_DocumentoInfo.FileName', Detalle_Diligencias_CanalizacionData[i].Ver_DocumentoInfo.FileName);
        form_data.append('[' + i + '].Ver_DocumentoInfo.FileSize', Detalle_Diligencias_CanalizacionData[i].Ver_DocumentoInfo.FileSize);
        form_data.append('[' + i + '].Ver_DocumentoInfo.Control', Detalle_Diligencias_CanalizacionData[i].Ver_DocumentoInfo.Control);
        form_data.append('[' + i + '].Ver_DocumentoInfo.RemoveFile', Detalle_Diligencias_CanalizacionData[i].Ver_DocumentoInfo.ArchivoRemoveFile);
        form_data.append('[' + i + '].Observaciones', Detalle_Diligencias_CanalizacionData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Detalle_Diligencias_CanalizacionData[i].Removed);
    }
    return form_data;
}
function Detalle_Diligencias_CanalizacionInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Diligencias_Canalizacion("Detalle_Diligencias_CanalizacionTable", rowIndex)) {
    var prevData = Detalle_Diligencias_CanalizacionTable.fnGetData(rowIndex);
    var data = Detalle_Diligencias_CanalizacionTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Diligencia: $('#Detalle_Diligencias_CanalizacionDiligencia').val()
        ,Ver_DocumentoFileInfo: { Ver_DocumentoFileName: prevData.Ver_DocumentoFileInfo.FileName, Ver_DocumentoFileId: prevData.Ver_DocumentoFileInfo.FileId, Ver_DocumentoFileSize: prevData.Ver_DocumentoFileInfo.FileSize }
        ,Ver_DocumentoFileDetail: $('#Ver_Documento').find('label').length == 0 ? $('#Ver_DocumentoFileInfoPop')[0] : prevData.Ver_DocumentoFileDetail
        ,Observaciones: $('#Detalle_Diligencias_CanalizacionObservaciones').val()

    }

    Detalle_Diligencias_CanalizacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Diligencias_CanalizacionrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Diligencias_Canalizacion-form').modal({ show: false });
    $('#AddDetalle_Diligencias_Canalizacion-form').modal('hide');
    Detalle_Diligencias_CanalizacionEditRow(rowIndex);
    Detalle_Diligencias_CanalizacionInsertRow(rowIndex);
    //}
}
function Detalle_Diligencias_CanalizacionRemoveAddRow(rowIndex) {
    Detalle_Diligencias_CanalizacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Diligencias_Canalizacion MultiRow


$(function () {
    function Detalle_Diligencias_CanalizacioninitializeMainArray(totalCount) {
        if (Detalle_Diligencias_CanalizacionDataMain.length != totalCount && !Detalle_Diligencias_CanalizacionDataMainInitialized) {
            Detalle_Diligencias_CanalizacionDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Diligencias_CanalizacionDataMain[i] = null;
            }
        }
    }
    function Detalle_Diligencias_CanalizacionremoveFromMainArray() {
        for (var j = 0; j < Detalle_Diligencias_CanalizaciondeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Diligencias_CanalizacionDataMain.length; i++) {
                if (Detalle_Diligencias_CanalizacionDataMain[i] != null && Detalle_Diligencias_CanalizacionDataMain[i].Id == Detalle_Diligencias_CanalizaciondeletedItem[j]) {
                    hDetalle_Diligencias_CanalizacionDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Diligencias_CanalizacioncopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Diligencias_CanalizacionDataMain.length; i++) {
            data[i] = Detalle_Diligencias_CanalizacionDataMain[i];

        }
        return data;
    }
    function Detalle_Diligencias_CanalizaciongetNewResult() {
        var newData = copyMainDetalle_Diligencias_CanalizacionArray();

        for (var i = 0; i < Detalle_Diligencias_CanalizacionData.length; i++) {
            if (Detalle_Diligencias_CanalizacionData[i].Removed == null || Detalle_Diligencias_CanalizacionData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Diligencias_CanalizacionData[i]);
            }
        }
        return newData;
    }
    function Detalle_Diligencias_CanalizacionpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Diligencias_CanalizacionDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Diligencias_CanalizacionDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteExpediente_MPData = [];
function GetAutoCompleteCanalizacion_Expediente_MP_expediente_ministerio_publicoData(data) {
	AutoCompleteExpediente_MPData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MPData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteExpediente_MPData;
}
var AutoCompleteExpediente_ATData = [];
function GetAutoCompleteCanalizacion_Expediente_AT_Modulo_Atencion_InicialData(data) {
	AutoCompleteExpediente_ATData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_ATData.push({
            id: data[i].Clave,
            text: data[i].Folio
        });
    }
    return AutoCompleteExpediente_ATData;
}
var AutoCompleteUsuario_que_CanalizaData = [];
function GetAutoCompleteCanalizacion_Usuario_que_Canaliza_Spartan_UserData(data) {
	AutoCompleteUsuario_que_CanalizaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_CanalizaData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_CanalizaData;
}
var AutoCompleteRelacion_a_CanalizarData = [];
function GetAutoCompleteCanalizacion_Relacion_a_Canalizar_Detalle_de_RelacionesData(data) {
	AutoCompleteRelacion_a_CanalizarData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteRelacion_a_CanalizarData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteRelacion_a_CanalizarData;
}
var AutoCompleteMunicipioData = [];
function GetAutoCompleteCanalizacion_Municipio_MunicipioData(data) {
	AutoCompleteMunicipioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioData;
}
var AutoCompleteUnidadData = [];
function GetAutoCompleteCanalizacion_Unidad_UnidadData(data) {
	AutoCompleteUnidadData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUnidadData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteUnidadData;
}
//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Canalizacion_cmbLabelSelect").val();
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
    $('#CreateCanalizacion')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Expediente_AT').empty();
    $("#Expediente_AT").append('<option value=""></option>');
    $('#Expediente_AT').val('0').trigger('change');
    $('#Usuario_que_Canaliza').empty();
    $("#Usuario_que_Canaliza").append('<option value=""></option>');
    $('#Usuario_que_Canaliza').val('0').trigger('change');
    $('#Relacion_a_Canalizar').empty();
    $("#Relacion_a_Canalizar").append('<option value=""></option>');
    $('#Relacion_a_Canalizar').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Unidad').empty();
    $("#Unidad").append('<option value=""></option>');
    $('#Unidad').val('0').trigger('change');
                Detalle_Diligencias_CanalizacionClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateCanalizacion').trigger('reset');
    $('#CreateCanalizacion').find(':input').each(function () {
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
    var $myForm = $('#CreateCanalizacion');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Diligencias_CanalizacioncountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Diligencias_Canalizacion();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateCanalizacion").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateCanalizacion").on('click', '#CanalizacionCancelar', function () {
	  if (!isPartial) {
        CanalizacionBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateCanalizacion").on('click', '#CanalizacionGuardar', function () {
		$('#CanalizacionGuardar').attr('disabled', true);
		$('#CanalizacionGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendCanalizacionData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						CanalizacionBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#CanalizacionGuardar').removeAttr('disabled');
                        $('#CanalizacionGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Canalizacion', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_CanalizacionItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_CanalizacionDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#CanalizacionGuardar').removeAttr('disabled');
					$('#CanalizacionGuardar').bind()
				}
		}
		else {
			$('#CanalizacionGuardar').removeAttr('disabled');
			$('#CanalizacionGuardar').bind()
		}
    });
	$("form#CreateCanalizacion").on('click', '#CanalizacionGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendCanalizacionData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Diligencias_CanalizacionData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Canalizacion', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_CanalizacionItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_CanalizacionDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateCanalizacion").on('click', '#CanalizacionGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendCanalizacionData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Expediente_AT').empty();
    $("#Expediente_AT").append('<option value=""></option>');
    $('#Expediente_AT').val('0').trigger('change');
    $('#Usuario_que_Canaliza').empty();
    $("#Usuario_que_Canaliza").append('<option value=""></option>');
    $('#Usuario_que_Canaliza').val('0').trigger('change');
    $('#Relacion_a_Canalizar').empty();
    $("#Relacion_a_Canalizar").append('<option value=""></option>');
    $('#Relacion_a_Canalizar').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Unidad').empty();
    $("#Unidad").append('<option value=""></option>');
    $('#Unidad').val('0').trigger('change');
                Detalle_Diligencias_CanalizacionClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Diligencias_CanalizacionData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Canalizacion',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_CanalizacionItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_CanalizacionDropDown().get(0)').innerHTML);                          
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



var CanalizacionisdisplayBusinessPropery = false;
CanalizacionDisplayBusinessRuleButtons(CanalizacionisdisplayBusinessPropery);
function CanalizacionDisplayBusinessRule() {
    if (!CanalizacionisdisplayBusinessPropery) {
        $('#CreateCanalizacion').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="CanalizaciondisplayBusinessPropery"><button onclick="CanalizacionGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#CanalizacionBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.CanalizaciondisplayBusinessPropery').remove();
    }
    CanalizacionDisplayBusinessRuleButtons(!CanalizacionisdisplayBusinessPropery);
    CanalizacionisdisplayBusinessPropery = (CanalizacionisdisplayBusinessPropery ? false : true);
}
function CanalizacionDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

