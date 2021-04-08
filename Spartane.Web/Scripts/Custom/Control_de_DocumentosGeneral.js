        function RemoveAttachmentMainArchivo () {
            $("#hdnRemoveArchivo").val("1");
            $("#divAttachmentArchivo").hide();
        }


//Begin Declarations for Foreigns fields for Detalle_Historial_Control_de_Documentos MultiRow
var Detalle_Historial_Control_de_DocumentoscountRowsChecked = 0;



function GetDetalle_Historial_Control_de_Documentos_Spartan_UserName(Id) {
    for (var i = 0; i < Detalle_Historial_Control_de_Documentos_Spartan_UserItems.length; i++) {
        if (Detalle_Historial_Control_de_Documentos_Spartan_UserItems[i].Id_User == Id) {
            return Detalle_Historial_Control_de_Documentos_Spartan_UserItems[i].Name;
        }
    }
    return "";
}

function GetDetalle_Historial_Control_de_Documentos_Spartan_UserDropDown() {
    var Detalle_Historial_Control_de_Documentos_Spartan_UserDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Historial_Control_de_Documentos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Historial_Control_de_Documentos_Spartan_UserDropdown);
    if(Detalle_Historial_Control_de_Documentos_Spartan_UserItems != null)
    {
       for (var i = 0; i < Detalle_Historial_Control_de_Documentos_Spartan_UserItems.length; i++) {
           $('<option />', { value: Detalle_Historial_Control_de_Documentos_Spartan_UserItems[i].Id_User, text:    Detalle_Historial_Control_de_Documentos_Spartan_UserItems[i].Name }).appendTo(Detalle_Historial_Control_de_Documentos_Spartan_UserDropdown);
       }
    }
    return Detalle_Historial_Control_de_Documentos_Spartan_UserDropdown;
}




function GetInsertDetalle_Historial_Control_de_DocumentosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_Historial_Control_de_Documentos_Fecha Fecha').attr('id', 'Detalle_Historial_Control_de_Documentos_Fecha_' + index).attr('data-field', 'Fecha');
    columnData[1] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_Historial_Control_de_Documentos_Hora Hora').attr('id', 'Detalle_Historial_Control_de_Documentos_Hora_' + index).attr('data-field', 'Hora');
    columnData[2] = $(GetDetalle_Historial_Control_de_Documentos_Spartan_UserDropDown()).addClass('Detalle_Historial_Control_de_Documentos_Usuario Usuario').attr('id', 'Detalle_Historial_Control_de_Documentos_Usuario_' + index).attr('data-field', 'Usuario').after($.parseHTML(addNew('Detalle_Historial_Control_de_Documentos', 'Spartan_User', 'Usuario', 266168)));
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Historial_Control_de_Documentos_Modificaciones_Realizadas Modificaciones_Realizadas').attr('id', 'Detalle_Historial_Control_de_Documentos_Modificaciones_Realizadas_' + index).attr('data-field', 'Modificaciones_Realizadas');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_Historial_Control_de_Documentos_Cuerpo_del_Documento Cuerpo_del_Documento').attr('id', 'Detalle_Historial_Control_de_Documentos_Cuerpo_del_Documento_' + index).attr('data-field', 'Cuerpo_del_Documento');


    initiateUIControls();
    return columnData;
}

function Detalle_Historial_Control_de_DocumentosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Historial_Control_de_Documentos("Detalle_Historial_Control_de_Documentos_", "_" + rowIndex)) {
    var iPage = Detalle_Historial_Control_de_DocumentosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Historial_Control_de_Documentos';
    var prevData = Detalle_Historial_Control_de_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Historial_Control_de_DocumentosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Fecha:  data.childNodes[counter++].childNodes[0].value
        ,Hora:  data.childNodes[counter++].childNodes[0].value
        ,Usuario:  data.childNodes[counter++].childNodes[0].value
        ,Modificaciones_Realizadas:  data.childNodes[counter++].childNodes[0].value
        ,Cuerpo_del_Documento:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Historial_Control_de_DocumentosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Historial_Control_de_DocumentosrowCreationGrid(data, newData, rowIndex);
    Detalle_Historial_Control_de_DocumentosTable.fnPageChange(iPage);
    Detalle_Historial_Control_de_DocumentoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Historial_Control_de_Documentos("Detalle_Historial_Control_de_Documentos_", "_" + rowIndex);
  }
}

function Detalle_Historial_Control_de_DocumentosCancelRow(rowIndex) {
    var prevData = Detalle_Historial_Control_de_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Historial_Control_de_DocumentosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Historial_Control_de_DocumentosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Historial_Control_de_DocumentosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Historial_Control_de_DocumentosGrid(Detalle_Historial_Control_de_DocumentosTable.fnGetData());
    Detalle_Historial_Control_de_DocumentoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Historial_Control_de_DocumentosFromDataTable() {
    var Detalle_Historial_Control_de_DocumentosData = [];
    var gridData = Detalle_Historial_Control_de_DocumentosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Historial_Control_de_DocumentosData.push({
                Folio: gridData[i].Folio

                ,Fecha: gridData[i].Fecha
                ,Hora: gridData[i].Hora
                ,Usuario: gridData[i].Usuario
                ,Modificaciones_Realizadas: gridData[i].Modificaciones_Realizadas
                ,Cuerpo_del_Documento: gridData[i].Cuerpo_del_Documento

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Historial_Control_de_DocumentosData.length; i++) {
        if (removedDetalle_Historial_Control_de_DocumentosData[i] != null && removedDetalle_Historial_Control_de_DocumentosData[i].Folio > 0)
            Detalle_Historial_Control_de_DocumentosData.push({
                Folio: removedDetalle_Historial_Control_de_DocumentosData[i].Folio

                ,Fecha: removedDetalle_Historial_Control_de_DocumentosData[i].Fecha
                ,Hora: removedDetalle_Historial_Control_de_DocumentosData[i].Hora
                ,Usuario: removedDetalle_Historial_Control_de_DocumentosData[i].Usuario
                ,Modificaciones_Realizadas: removedDetalle_Historial_Control_de_DocumentosData[i].Modificaciones_Realizadas
                ,Cuerpo_del_Documento: removedDetalle_Historial_Control_de_DocumentosData[i].Cuerpo_del_Documento

                , Removed: true
            });
    }	

    return Detalle_Historial_Control_de_DocumentosData;
}

function Detalle_Historial_Control_de_DocumentosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Historial_Control_de_DocumentosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Historial_Control_de_DocumentoscountRowsChecked++;
    var Detalle_Historial_Control_de_DocumentosRowElement = "Detalle_Historial_Control_de_Documentos_" + rowIndex.toString();
    var prevData = Detalle_Historial_Control_de_DocumentosTable.fnGetData(rowIndexTable );
    var row = Detalle_Historial_Control_de_DocumentosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Historial_Control_de_Documentos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Historial_Control_de_DocumentosGetUpdateRowControls(prevData, "Detalle_Historial_Control_de_Documentos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Historial_Control_de_DocumentosRowElement + "')){ Detalle_Historial_Control_de_DocumentosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Historial_Control_de_DocumentosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Historial_Control_de_DocumentosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Historial_Control_de_DocumentosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Historial_Control_de_DocumentosValidation();
    initiateUIControls();
    $('.Detalle_Historial_Control_de_Documentos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Historial_Control_de_Documentos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Historial_Control_de_DocumentosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Historial_Control_de_DocumentosTable.fnGetData().length;
    Detalle_Historial_Control_de_DocumentosfnClickAddRow();
    GetAddDetalle_Historial_Control_de_DocumentosPopup(currentRowIndex, 0);
}

function Detalle_Historial_Control_de_DocumentosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Historial_Control_de_DocumentosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Historial_Control_de_DocumentosRowElement = "Detalle_Historial_Control_de_Documentos_" + rowIndex.toString();
    var prevData = Detalle_Historial_Control_de_DocumentosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Historial_Control_de_DocumentosPopup(rowIndex, 1, prevData.Folio);

    $('#Detalle_Historial_Control_de_DocumentosFecha').val(prevData.Fecha);
    $('#Detalle_Historial_Control_de_DocumentosHora').val(prevData.Hora);
    $('#Detalle_Historial_Control_de_DocumentosUsuario').val(prevData.Usuario);
    $('#Detalle_Historial_Control_de_DocumentosModificaciones_Realizadas').val(prevData.Modificaciones_Realizadas);
    $('#Detalle_Historial_Control_de_DocumentosCuerpo_del_Documento').val(prevData.Cuerpo_del_Documento);

    initiateUIControls();







}

function Detalle_Historial_Control_de_DocumentosAddInsertRow() {
    if (Detalle_Historial_Control_de_DocumentosinsertRowCurrentIndex < 1)
    {
        Detalle_Historial_Control_de_DocumentosinsertRowCurrentIndex = 1;
    }
    return {
        Folio: null,
        IsInsertRow: true

        ,Fecha: ""
        ,Hora: ""
        ,Usuario: ""
        ,Modificaciones_Realizadas: ""
        ,Cuerpo_del_Documento: ""

    }
}

function Detalle_Historial_Control_de_DocumentosfnClickAddRow() {
    Detalle_Historial_Control_de_DocumentoscountRowsChecked++;
    Detalle_Historial_Control_de_DocumentosTable.fnAddData(Detalle_Historial_Control_de_DocumentosAddInsertRow(), true);
    Detalle_Historial_Control_de_DocumentosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Historial_Control_de_DocumentosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Historial_Control_de_DocumentosGrid tbody tr:nth-of-type(' + (Detalle_Historial_Control_de_DocumentosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Historial_Control_de_Documentos("Detalle_Historial_Control_de_Documentos_", "_" + Detalle_Historial_Control_de_DocumentosinsertRowCurrentIndex);
}

function Detalle_Historial_Control_de_DocumentosClearGridData() {
    Detalle_Historial_Control_de_DocumentosData = [];
    Detalle_Historial_Control_de_DocumentosdeletedItem = [];
    Detalle_Historial_Control_de_DocumentosDataMain = [];
    Detalle_Historial_Control_de_DocumentosDataMainPages = [];
    Detalle_Historial_Control_de_DocumentosnewItemCount = 0;
    Detalle_Historial_Control_de_DocumentosmaxItemIndex = 0;
    $("#Detalle_Historial_Control_de_DocumentosGrid").DataTable().clear();
    $("#Detalle_Historial_Control_de_DocumentosGrid").DataTable().destroy();
}

//Used to Get Control de Documentos Information
function GetDetalle_Historial_Control_de_Documentos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Historial_Control_de_DocumentosData.length; i++) {
        form_data.append('[' + i + '].Folio', Detalle_Historial_Control_de_DocumentosData[i].Folio);

        form_data.append('[' + i + '].Fecha', Detalle_Historial_Control_de_DocumentosData[i].Fecha);
        form_data.append('[' + i + '].Hora', Detalle_Historial_Control_de_DocumentosData[i].Hora);
        form_data.append('[' + i + '].Usuario', Detalle_Historial_Control_de_DocumentosData[i].Usuario);
        form_data.append('[' + i + '].Modificaciones_Realizadas', Detalle_Historial_Control_de_DocumentosData[i].Modificaciones_Realizadas);
        form_data.append('[' + i + '].Cuerpo_del_Documento', Detalle_Historial_Control_de_DocumentosData[i].Cuerpo_del_Documento);

        form_data.append('[' + i + '].Removed', Detalle_Historial_Control_de_DocumentosData[i].Removed);
    }
    return form_data;
}
function Detalle_Historial_Control_de_DocumentosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Historial_Control_de_Documentos("Detalle_Historial_Control_de_DocumentosTable", rowIndex)) {
    var prevData = Detalle_Historial_Control_de_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Historial_Control_de_DocumentosTable.fnGetNodes(rowIndex);
    var newData = {
        Folio: prevData.Folio,
        IsInsertRow: false

        ,Fecha: $('#Detalle_Historial_Control_de_DocumentosFecha').val()
        ,Hora: $('#Detalle_Historial_Control_de_DocumentosHora').val()
        ,Usuario: $('#Detalle_Historial_Control_de_DocumentosUsuario').val()
        ,Modificaciones_Realizadas: $('#Detalle_Historial_Control_de_DocumentosModificaciones_Realizadas').val()
        ,Cuerpo_del_Documento: $('#Detalle_Historial_Control_de_DocumentosCuerpo_del_Documento').val()

    }

    Detalle_Historial_Control_de_DocumentosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Historial_Control_de_DocumentosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Historial_Control_de_Documentos-form').modal({ show: false });
    $('#AddDetalle_Historial_Control_de_Documentos-form').modal('hide');
    Detalle_Historial_Control_de_DocumentosEditRow(rowIndex);
    Detalle_Historial_Control_de_DocumentosInsertRow(rowIndex);
    //}
}
function Detalle_Historial_Control_de_DocumentosRemoveAddRow(rowIndex) {
    Detalle_Historial_Control_de_DocumentosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Historial_Control_de_Documentos MultiRow


$(function () {
    function Detalle_Historial_Control_de_DocumentosinitializeMainArray(totalCount) {
        if (Detalle_Historial_Control_de_DocumentosDataMain.length != totalCount && !Detalle_Historial_Control_de_DocumentosDataMainInitialized) {
            Detalle_Historial_Control_de_DocumentosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Historial_Control_de_DocumentosDataMain[i] = null;
            }
        }
    }
    function Detalle_Historial_Control_de_DocumentosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Historial_Control_de_DocumentosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Historial_Control_de_DocumentosDataMain.length; i++) {
                if (Detalle_Historial_Control_de_DocumentosDataMain[i] != null && Detalle_Historial_Control_de_DocumentosDataMain[i].Id == Detalle_Historial_Control_de_DocumentosdeletedItem[j]) {
                    hDetalle_Historial_Control_de_DocumentosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Historial_Control_de_DocumentoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Historial_Control_de_DocumentosDataMain.length; i++) {
            data[i] = Detalle_Historial_Control_de_DocumentosDataMain[i];

        }
        return data;
    }
    function Detalle_Historial_Control_de_DocumentosgetNewResult() {
        var newData = copyMainDetalle_Historial_Control_de_DocumentosArray();

        for (var i = 0; i < Detalle_Historial_Control_de_DocumentosData.length; i++) {
            if (Detalle_Historial_Control_de_DocumentosData[i].Removed == null || Detalle_Historial_Control_de_DocumentosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Historial_Control_de_DocumentosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Historial_Control_de_DocumentospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Historial_Control_de_DocumentosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Historial_Control_de_DocumentosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Control_de_Documentos_cmbLabelSelect").val();
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
    $('#CreateControl_de_Documentos')[0].reset();
    ClearFormControls();
    $("#FolioId").val("0");
                Detalle_Historial_Control_de_DocumentosClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateControl_de_Documentos').trigger('reset');
    $('#CreateControl_de_Documentos').find(':input').each(function () {
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
    var $myForm = $('#CreateControl_de_Documentos');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Historial_Control_de_DocumentoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Historial_Control_de_Documentos();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblFolio").text("0");
}
$(document).ready(function () {
    $("form#CreateControl_de_Documentos").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateControl_de_Documentos").on('click', '#Control_de_DocumentosCancelar', function () {
	  if (!isPartial) {
        Control_de_DocumentosBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateControl_de_Documentos").on('click', '#Control_de_DocumentosGuardar', function () {
		$('#Control_de_DocumentosGuardar').attr('disabled', true);
		$('#Control_de_DocumentosGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendControl_de_DocumentosData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Control_de_DocumentosBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Control_de_DocumentosGuardar').removeAttr('disabled');
                        $('#Control_de_DocumentosGuardar').bind()
                    }
					else {						
						if (!isMR)
						{}
							//window.opener.RefreshCatalog('Control_de_Documentos', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Control_de_DocumentosItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Control_de_DocumentosDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Control_de_DocumentosGuardar').removeAttr('disabled');
					$('#Control_de_DocumentosGuardar').bind()
				}
		}
		else {
			$('#Control_de_DocumentosGuardar').removeAttr('disabled');
			$('#Control_de_DocumentosGuardar').bind()
		}
    });
	$("form#CreateControl_de_Documentos").on('click', '#Control_de_DocumentosGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendControl_de_DocumentosData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Historial_Control_de_DocumentosData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Control_de_Documentos', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Control_de_DocumentosItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Control_de_DocumentosDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateControl_de_Documentos").on('click', '#Control_de_DocumentosGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendControl_de_DocumentosData(function (currentId) {
					$("#FolioId").val("0");
	                Detalle_Historial_Control_de_DocumentosClearGridData();

					ResetClaveLabel();
					$("#ReferenceFolio").val(currentId);
	                getDetalle_Historial_Control_de_DocumentosData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Control_de_Documentos',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Control_de_DocumentosItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Control_de_DocumentosDropDown().get(0)').innerHTML);                          
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



var Control_de_DocumentosisdisplayBusinessPropery = false;
Control_de_DocumentosDisplayBusinessRuleButtons(Control_de_DocumentosisdisplayBusinessPropery);
function Control_de_DocumentosDisplayBusinessRule() {
    if (!Control_de_DocumentosisdisplayBusinessPropery) {
        $('#CreateControl_de_Documentos').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Control_de_DocumentosdisplayBusinessPropery"><button onclick="Control_de_DocumentosGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Control_de_DocumentosBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Control_de_DocumentosdisplayBusinessPropery').remove();
    }
    Control_de_DocumentosDisplayBusinessRuleButtons(!Control_de_DocumentosisdisplayBusinessPropery);
    Control_de_DocumentosisdisplayBusinessPropery = (Control_de_DocumentosisdisplayBusinessPropery ? false : true);
}
function Control_de_DocumentosDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

