

//Begin Declarations for Foreigns fields for Detalle_Plan_Actos_de_Investigacion MultiRow
var Detalle_Plan_Actos_de_InvestigacioncountRowsChecked = 0;

function GetDetalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoName(Id) {
    for (var i = 0; i < Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoItems.length; i++) {
        if (Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoItems[i].Clave == Id) {
            return Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoDropDown() {
    var Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Plan_Actos_de_Investigacion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoDropdown);
    if(Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoItems != null)
    {
       for (var i = 0; i < Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoItems.length; i++) {
           $('<option />', { value: Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoItems[i].Clave, text:    Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoItems[i].Descripcion }).appendTo(Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoDropdown);
       }
    }
    return Detalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoDropdown;
}
function GetDetalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoName(Id) {
    for (var i = 0; i < Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoItems.length; i++) {
        if (Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoItems[i].Clave == Id) {
            return Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoItems[i].Servicio;
        }
    }
    return "";
}

function GetDetalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoDropDown() {
    var Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Plan_Actos_de_Investigacion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoDropdown);
    if(Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoItems != null)
    {
       for (var i = 0; i < Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoItems.length; i++) {
           $('<option />', { value: Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoItems[i].Clave, text:    Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoItems[i].Servicio }).appendTo(Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoDropdown);
       }
    }
    return Detalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoDropdown;
}







function GetDetalle_Plan_Actos_de_Investigacion_Spartan_UserName(Id) {
    for (var i = 0; i < Detalle_Plan_Actos_de_Investigacion_Spartan_UserItems.length; i++) {
        if (Detalle_Plan_Actos_de_Investigacion_Spartan_UserItems[i].Id_User == Id) {
            return Detalle_Plan_Actos_de_Investigacion_Spartan_UserItems[i].Name;
        }
    }
    return "";
}

function GetDetalle_Plan_Actos_de_Investigacion_Spartan_UserDropDown() {
    var Detalle_Plan_Actos_de_Investigacion_Spartan_UserDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Plan_Actos_de_Investigacion_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Plan_Actos_de_Investigacion_Spartan_UserDropdown);

    for (var i = 0; i < Detalle_Plan_Actos_de_Investigacion_Spartan_UserItems.length; i++) {
        $('<option />', { value: Detalle_Plan_Actos_de_Investigacion_Spartan_UserItems[i].Id_User, text: Detalle_Plan_Actos_de_Investigacion_Spartan_UserItems[i].Name }).appendTo(Detalle_Plan_Actos_de_Investigacion_Spartan_UserDropdown);
    }
    return Detalle_Plan_Actos_de_Investigacion_Spartan_UserDropdown;
}


function GetInsertDetalle_Plan_Actos_de_InvestigacionRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoDropDown()).addClass('Detalle_Plan_Actos_de_Investigacion_Categoria Categoria').attr('id', 'Detalle_Plan_Actos_de_Investigacion_Categoria_' + index).attr('data-field', 'Categoria').after($.parseHTML(addNew('Detalle_Plan_Actos_de_Investigacion', 'Categoria_de_Servicio_de_Apoyo', 'Categoria', 267368)));
    columnData[1] = $(GetDetalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoDropDown()).addClass('Detalle_Plan_Actos_de_Investigacion_Servicio_a_Solicitar Servicio_a_Solicitar').attr('id', 'Detalle_Plan_Actos_de_Investigacion_Servicio_a_Solicitar_' + index).attr('data-field', 'Servicio_a_Solicitar').after($.parseHTML(addNew('Detalle_Plan_Actos_de_Investigacion', 'Tipo_de_Servicio_de_Apoyo', 'Servicio_a_Solicitar', 267369)));
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_Plan_Actos_de_Investigacion_Hecho_Delictivo_Acreditado Hecho_Delictivo_Acreditado').attr('id', 'Detalle_Plan_Actos_de_Investigacion_Hecho_Delictivo_Acreditado_' + index).attr('data-field', 'Hecho_Delictivo_Acreditado');
    columnData[3] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Plan_Actos_de_Investigacion_Tiempo_Estandar Tiempo_Estandar').attr('id', 'Detalle_Plan_Actos_de_Investigacion_Tiempo_Estandar_' + index).attr('data-field', 'Tiempo_Estandar');
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Plan_Actos_de_Investigacion_Ponderacion Ponderacion').attr('id', 'Detalle_Plan_Actos_de_Investigacion_Ponderacion_' + index).attr('data-field', 'Ponderacion');
    columnData[5] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_Plan_Actos_de_Investigacion_Fecha_Contestacion Fecha_Contestacion').attr('id', 'Detalle_Plan_Actos_de_Investigacion_Fecha_Contestacion_' + index).attr('data-field', 'Fecha_Contestacion');
    columnData[6] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_Plan_Actos_de_Investigacion_Hora_Contestacion Hora_Contestacion').attr('id', 'Detalle_Plan_Actos_de_Investigacion_Hora_Contestacion_' + index).attr('data-field', 'Hora_Contestacion');
    columnData[7] = $($.parseHTML(inputData)).addClass('Detalle_Plan_Actos_de_Investigacion_Contestacion Contestacion').attr('id', 'Detalle_Plan_Actos_de_Investigacion_Contestacion_' + index).attr('data-field', 'Contestacion');
    columnData[8] = $($.parseHTML(GetFileUploader())).addClass('Detalle_Plan_Actos_de_Investigacion_Archivo_Adjunto_FileUpload Archivo_Adjunto').attr('id', 'Detalle_Plan_Actos_de_Investigacion_Archivo_Adjunto_' + index).attr('data-field', 'Archivo_Adjunto');
    columnData[9] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Plan_Actos_de_Investigacion_Usuario_que_Contesta'))).addClass('Detalle_Plan_Actos_de_Investigacion_Usuario_que_Contesta Usuario_que_Contesta').attr('id', 'Detalle_Plan_Actos_de_Investigacion_Usuario_que_Contesta_' + index).attr('data-field', 'Usuario_que_Contesta').after($.parseHTML(addNew('Detalle_Plan_Actos_de_Investigacion', 'Spartan_User', 'Usuario_que_Contesta', 267377)));


    initiateUIControls();
    return columnData;
}

function Detalle_Plan_Actos_de_InvestigacionInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Plan_Actos_de_Investigacion("Detalle_Plan_Actos_de_Investigacion_", "_" + rowIndex)) {
    var iPage = Detalle_Plan_Actos_de_InvestigacionTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Plan_Actos_de_Investigacion';
    var prevData = Detalle_Plan_Actos_de_InvestigacionTable.fnGetData(rowIndex);
    var data = Detalle_Plan_Actos_de_InvestigacionTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Categoria:  data.childNodes[counter++].childNodes[0].value
        ,Servicio_a_Solicitar:  data.childNodes[counter++].childNodes[0].value
        ,Hecho_Delictivo_Acreditado:  data.childNodes[counter++].childNodes[0].value
        ,Tiempo_Estandar: data.childNodes[counter++].childNodes[0].value
        ,Ponderacion: data.childNodes[counter++].childNodes[0].value
        ,Fecha_Contestacion:  data.childNodes[counter++].childNodes[0].value
        ,Hora_Contestacion:  data.childNodes[counter++].childNodes[0].value
        ,Contestacion:  data.childNodes[counter++].childNodes[0].value
        ,Archivo_AdjuntoFileInfo: ($('#' + nameOfGrid + 'Grid .Archivo_AdjuntoHeader').css('display') != 'none') ? { 
             FileName: prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null && prevData.Archivo_AdjuntoFileInfo.FileName != ''? prevData.Archivo_AdjuntoFileInfo.FileName : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : ''),              
			 FileId:   prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null && prevData.Archivo_AdjuntoFileInfo.FileName != '' ? prevData.Archivo_AdjuntoFileInfo.FileId :  prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileId != '' && prevData.Archivo_AdjuntoFileInfo.FileId != undefined ? prevData.Archivo_AdjuntoFileInfo.FileId : '0',
             FileSize: prevData.Archivo_AdjuntoFileInfo != null && prevData.Archivo_AdjuntoFileInfo.FileName != null ? prevData.Archivo_AdjuntoFileInfo.FileSize : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : '') 
         } : ''
        ,Archivo_AdjuntoDetail: (data.childNodes[counter] != 'undefined' && data.childNodes[counter].childNodes[0].childNodes.length == 0) ? data.childNodes[counter++].childNodes[0] : prevData.Archivo_AdjuntoDetail
        , Usuario_que_ContestaName:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Usuario_que_Contesta:  data.childNodes[counter++].childNodes[0].value 	

    }
    Detalle_Plan_Actos_de_InvestigacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Plan_Actos_de_InvestigacionrowCreationGrid(data, newData, rowIndex);
    Detalle_Plan_Actos_de_InvestigacionTable.fnPageChange(iPage);
    Detalle_Plan_Actos_de_InvestigacioncountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Plan_Actos_de_Investigacion("Detalle_Plan_Actos_de_Investigacion_", "_" + rowIndex);
  }
}

function Detalle_Plan_Actos_de_InvestigacionCancelRow(rowIndex) {
    var prevData = Detalle_Plan_Actos_de_InvestigacionTable.fnGetData(rowIndex);
    var data = Detalle_Plan_Actos_de_InvestigacionTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Plan_Actos_de_InvestigacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Plan_Actos_de_InvestigacionrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Plan_Actos_de_InvestigacionGrid(Detalle_Plan_Actos_de_InvestigacionTable.fnGetData());
    Detalle_Plan_Actos_de_InvestigacioncountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Plan_Actos_de_InvestigacionFromDataTable() {
    var Detalle_Plan_Actos_de_InvestigacionData = [];
    var gridData = Detalle_Plan_Actos_de_InvestigacionTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Plan_Actos_de_InvestigacionData.push({
                Clave: gridData[i].Clave

                ,Categoria: gridData[i].Categoria
                ,Servicio_a_Solicitar: gridData[i].Servicio_a_Solicitar
                ,Hecho_Delictivo_Acreditado: gridData[i].Hecho_Delictivo_Acreditado
                ,Tiempo_Estandar: gridData[i].Tiempo_Estandar
                ,Ponderacion: gridData[i].Ponderacion
                ,Fecha_Contestacion: gridData[i].Fecha_Contestacion
                ,Hora_Contestacion: gridData[i].Hora_Contestacion
                ,Contestacion: gridData[i].Contestacion
                ,Archivo_AdjuntoInfo: {
                    FileName: gridData[i].Archivo_AdjuntoFileInfo.FileName, FileId: gridData[i].Archivo_AdjuntoFileInfo.FileId, FileSize: gridData[i].Archivo_AdjuntoFileInfo.FileSize,
                    Control: gridData[i].Archivo_AdjuntoDetail != null && gridData[i].Archivo_AdjuntoDetail.files != null && gridData[i].Archivo_AdjuntoDetail.files.length > 0 ? gridData[i].Archivo_AdjuntoDetail.files[0] : null,
                    Archivo_AdjuntoRemoveFile: gridData[i].Archivo_AdjuntoDetail != null
                }
                ,Usuario_que_Contesta: gridData[i].Usuario_que_Contesta

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Plan_Actos_de_InvestigacionData.length; i++) {
        if (removedDetalle_Plan_Actos_de_InvestigacionData[i] != null && removedDetalle_Plan_Actos_de_InvestigacionData[i].Clave > 0)
            Detalle_Plan_Actos_de_InvestigacionData.push({
                Clave: removedDetalle_Plan_Actos_de_InvestigacionData[i].Clave

                ,Categoria: removedDetalle_Plan_Actos_de_InvestigacionData[i].Categoria
                ,Servicio_a_Solicitar: removedDetalle_Plan_Actos_de_InvestigacionData[i].Servicio_a_Solicitar
                ,Hecho_Delictivo_Acreditado: removedDetalle_Plan_Actos_de_InvestigacionData[i].Hecho_Delictivo_Acreditado
                ,Tiempo_Estandar: removedDetalle_Plan_Actos_de_InvestigacionData[i].Tiempo_Estandar
                ,Ponderacion: removedDetalle_Plan_Actos_de_InvestigacionData[i].Ponderacion
                ,Fecha_Contestacion: removedDetalle_Plan_Actos_de_InvestigacionData[i].Fecha_Contestacion
                ,Hora_Contestacion: removedDetalle_Plan_Actos_de_InvestigacionData[i].Hora_Contestacion
                ,Contestacion: removedDetalle_Plan_Actos_de_InvestigacionData[i].Contestacion
                ,Archivo_AdjuntoInfo: {
                    FileName: removedDetalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoFileInfo.FileName, 
                    FileId: removedDetalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoFileInfo.FileId, 
                    FileSize: removedDetalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoFileInfo.FileSize,
                    Control: removedDetalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoDetail != null && removedDetalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoDetail.files.length > 0 ? removedDetalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoDetail.files[0] : null,
                    Archivo_AdjuntoRemoveFile: removedDetalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoDetail != null
                }
                ,Usuario_que_Contesta: removedDetalle_Plan_Actos_de_InvestigacionData[i].Usuario_que_Contesta

                , Removed: true
            });
    }	

    return Detalle_Plan_Actos_de_InvestigacionData;
}

function Detalle_Plan_Actos_de_InvestigacionEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Plan_Actos_de_InvestigacionTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Plan_Actos_de_InvestigacioncountRowsChecked++;
    var Detalle_Plan_Actos_de_InvestigacionRowElement = "Detalle_Plan_Actos_de_Investigacion_" + rowIndex.toString();
    var prevData = Detalle_Plan_Actos_de_InvestigacionTable.fnGetData(rowIndexTable );
    var row = Detalle_Plan_Actos_de_InvestigacionTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Plan_Actos_de_Investigacion_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Plan_Actos_de_InvestigacionGetUpdateRowControls(prevData, "Detalle_Plan_Actos_de_Investigacion_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Plan_Actos_de_InvestigacionRowElement + "')){ Detalle_Plan_Actos_de_InvestigacionInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Plan_Actos_de_InvestigacionCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Plan_Actos_de_InvestigacionGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Plan_Actos_de_InvestigacionGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Plan_Actos_de_InvestigacionValidation();
    initiateUIControls();
    $('.Detalle_Plan_Actos_de_Investigacion' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Plan_Actos_de_Investigacion(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Plan_Actos_de_InvestigacionfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Plan_Actos_de_InvestigacionTable.fnGetData().length;
    Detalle_Plan_Actos_de_InvestigacionfnClickAddRow();
    GetAddDetalle_Plan_Actos_de_InvestigacionPopup(currentRowIndex, 0);
}

function Detalle_Plan_Actos_de_InvestigacionEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Plan_Actos_de_InvestigacionTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Plan_Actos_de_InvestigacionRowElement = "Detalle_Plan_Actos_de_Investigacion_" + rowIndex.toString();
    var prevData = Detalle_Plan_Actos_de_InvestigacionTable.fnGetData(rowIndexTable);
    GetAddDetalle_Plan_Actos_de_InvestigacionPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Plan_Actos_de_InvestigacionCategoria').val(prevData.Categoria);
    $('#Detalle_Plan_Actos_de_InvestigacionServicio_a_Solicitar').val(prevData.Servicio_a_Solicitar);
    $('#Detalle_Plan_Actos_de_InvestigacionHecho_Delictivo_Acreditado').val(prevData.Hecho_Delictivo_Acreditado);
    $('#Detalle_Plan_Actos_de_InvestigacionTiempo_Estandar').val(prevData.Tiempo_Estandar);
    $('#Detalle_Plan_Actos_de_InvestigacionPonderacion').val(prevData.Ponderacion);
    $('#Detalle_Plan_Actos_de_InvestigacionFecha_Contestacion').val(prevData.Fecha_Contestacion);
    $('#Detalle_Plan_Actos_de_InvestigacionHora_Contestacion').val(prevData.Hora_Contestacion);
    $('#Detalle_Plan_Actos_de_InvestigacionContestacion').val(prevData.Contestacion);

    $('#dvDetalle_Plan_Actos_de_InvestigacionUsuario_que_Contesta').html($($.parseHTML(GetGridAutoComplete(prevData.Usuario_que_Contesta.label,'AutoCompleteUsuario_que_Contesta'))).addClass('Detalle_Plan_Actos_de_Investigacion_Usuario_que_Contesta'));

    initiateUIControls();









    $('#existingArchivo_Adjunto').html(prevData.Archivo_AdjuntoFileDetail == null && (prevData.Archivo_AdjuntoFileInfo.FileId == null || prevData.Archivo_AdjuntoFileInfo.FileId <= 0) ? $.parseHTML(GetFileUploader()) : GetFileInfo(prevData.Archivo_AdjuntoFileInfo, prevData.Archivo_AdjuntoFileDetail));


}

function Detalle_Plan_Actos_de_InvestigacionAddInsertRow() {
    if (Detalle_Plan_Actos_de_InvestigacioninsertRowCurrentIndex < 1)
    {
        Detalle_Plan_Actos_de_InvestigacioninsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Categoria: ""
        ,Servicio_a_Solicitar: ""
        ,Hecho_Delictivo_Acreditado: ""
        ,Tiempo_Estandar: ""
        ,Ponderacion: ""
        ,Fecha_Contestacion: ""
        ,Hora_Contestacion: ""
        ,Contestacion: ""
        ,Archivo_AdjuntoFileInfo: ""
        ,Usuario_que_Contesta: ""

    }
}

function Detalle_Plan_Actos_de_InvestigacionfnClickAddRow() {
    Detalle_Plan_Actos_de_InvestigacioncountRowsChecked++;
    Detalle_Plan_Actos_de_InvestigacionTable.fnAddData(Detalle_Plan_Actos_de_InvestigacionAddInsertRow(), true);
    Detalle_Plan_Actos_de_InvestigacionTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Plan_Actos_de_InvestigacionGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Plan_Actos_de_InvestigacionGrid tbody tr:nth-of-type(' + (Detalle_Plan_Actos_de_InvestigacioninsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Plan_Actos_de_Investigacion("Detalle_Plan_Actos_de_Investigacion_", "_" + Detalle_Plan_Actos_de_InvestigacioninsertRowCurrentIndex);
}

function Detalle_Plan_Actos_de_InvestigacionClearGridData() {
    Detalle_Plan_Actos_de_InvestigacionData = [];
    Detalle_Plan_Actos_de_InvestigaciondeletedItem = [];
    Detalle_Plan_Actos_de_InvestigacionDataMain = [];
    Detalle_Plan_Actos_de_InvestigacionDataMainPages = [];
    Detalle_Plan_Actos_de_InvestigacionnewItemCount = 0;
    Detalle_Plan_Actos_de_InvestigacionmaxItemIndex = 0;
    $("#Detalle_Plan_Actos_de_InvestigacionGrid").DataTable().clear();
    $("#Detalle_Plan_Actos_de_InvestigacionGrid").DataTable().destroy();
}

//Used to Get Plan de Investigación Information
function GetDetalle_Plan_Actos_de_Investigacion() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Plan_Actos_de_InvestigacionData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Plan_Actos_de_InvestigacionData[i].Clave);

        form_data.append('[' + i + '].Categoria', Detalle_Plan_Actos_de_InvestigacionData[i].Categoria);
        form_data.append('[' + i + '].Servicio_a_Solicitar', Detalle_Plan_Actos_de_InvestigacionData[i].Servicio_a_Solicitar);
        form_data.append('[' + i + '].Hecho_Delictivo_Acreditado', Detalle_Plan_Actos_de_InvestigacionData[i].Hecho_Delictivo_Acreditado);
        form_data.append('[' + i + '].Tiempo_Estandar', Detalle_Plan_Actos_de_InvestigacionData[i].Tiempo_Estandar);
        form_data.append('[' + i + '].Ponderacion', Detalle_Plan_Actos_de_InvestigacionData[i].Ponderacion);
        form_data.append('[' + i + '].Fecha_Contestacion', Detalle_Plan_Actos_de_InvestigacionData[i].Fecha_Contestacion);
        form_data.append('[' + i + '].Hora_Contestacion', Detalle_Plan_Actos_de_InvestigacionData[i].Hora_Contestacion);
        form_data.append('[' + i + '].Contestacion', Detalle_Plan_Actos_de_InvestigacionData[i].Contestacion);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileId', Detalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoInfo.FileId);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileName', Detalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoInfo.FileName);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.FileSize', Detalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoInfo.FileSize);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.Control', Detalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoInfo.Control);
        form_data.append('[' + i + '].Archivo_AdjuntoInfo.RemoveFile', Detalle_Plan_Actos_de_InvestigacionData[i].Archivo_AdjuntoInfo.ArchivoRemoveFile);
        form_data.append('[' + i + '].Usuario_que_Contesta', Detalle_Plan_Actos_de_InvestigacionData[i].Usuario_que_Contesta);

        form_data.append('[' + i + '].Removed', Detalle_Plan_Actos_de_InvestigacionData[i].Removed);
    }
    return form_data;
}
function Detalle_Plan_Actos_de_InvestigacionInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Plan_Actos_de_Investigacion("Detalle_Plan_Actos_de_InvestigacionTable", rowIndex)) {
    var prevData = Detalle_Plan_Actos_de_InvestigacionTable.fnGetData(rowIndex);
    var data = Detalle_Plan_Actos_de_InvestigacionTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Categoria: $('#Detalle_Plan_Actos_de_InvestigacionCategoria').val()
        ,Servicio_a_Solicitar: $('#Detalle_Plan_Actos_de_InvestigacionServicio_a_Solicitar').val()
        ,Hecho_Delictivo_Acreditado: $('#Detalle_Plan_Actos_de_InvestigacionHecho_Delictivo_Acreditado').val()
        ,Tiempo_Estandar: $('#Detalle_Plan_Actos_de_InvestigacionTiempo_Estandar').val()

        ,Ponderacion: $('#Detalle_Plan_Actos_de_InvestigacionPonderacion').val()

        ,Fecha_Contestacion: $('#Detalle_Plan_Actos_de_InvestigacionFecha_Contestacion').val()
        ,Hora_Contestacion: $('#Detalle_Plan_Actos_de_InvestigacionHora_Contestacion').val()
        ,Contestacion: $('#Detalle_Plan_Actos_de_InvestigacionContestacion').val()
        ,Archivo_AdjuntoFileInfo: { Archivo_AdjuntoFileName: prevData.Archivo_AdjuntoFileInfo.FileName, Archivo_AdjuntoFileId: prevData.Archivo_AdjuntoFileInfo.FileId, Archivo_AdjuntoFileSize: prevData.Archivo_AdjuntoFileInfo.FileSize }
        ,Archivo_AdjuntoFileDetail: $('#Archivo_Adjunto').find('label').length == 0 ? $('#Archivo_AdjuntoFileInfoPop')[0] : prevData.Archivo_AdjuntoFileDetail
        ,Usuario_que_Contesta: $('#Detalle_Plan_Actos_de_InvestigacionUsuario_que_Contesta').val()

    }

    Detalle_Plan_Actos_de_InvestigacionTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Plan_Actos_de_InvestigacionrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Plan_Actos_de_Investigacion-form').modal({ show: false });
    $('#AddDetalle_Plan_Actos_de_Investigacion-form').modal('hide');
    Detalle_Plan_Actos_de_InvestigacionEditRow(rowIndex);
    Detalle_Plan_Actos_de_InvestigacionInsertRow(rowIndex);
    //}
}
function Detalle_Plan_Actos_de_InvestigacionRemoveAddRow(rowIndex) {
    Detalle_Plan_Actos_de_InvestigacionTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Plan_Actos_de_Investigacion MultiRow


$(function () {
    function Detalle_Plan_Actos_de_InvestigacioninitializeMainArray(totalCount) {
        if (Detalle_Plan_Actos_de_InvestigacionDataMain.length != totalCount && !Detalle_Plan_Actos_de_InvestigacionDataMainInitialized) {
            Detalle_Plan_Actos_de_InvestigacionDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Plan_Actos_de_InvestigacionDataMain[i] = null;
            }
        }
    }
    function Detalle_Plan_Actos_de_InvestigacionremoveFromMainArray() {
        for (var j = 0; j < Detalle_Plan_Actos_de_InvestigaciondeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Plan_Actos_de_InvestigacionDataMain.length; i++) {
                if (Detalle_Plan_Actos_de_InvestigacionDataMain[i] != null && Detalle_Plan_Actos_de_InvestigacionDataMain[i].Id == Detalle_Plan_Actos_de_InvestigaciondeletedItem[j]) {
                    hDetalle_Plan_Actos_de_InvestigacionDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Plan_Actos_de_InvestigacioncopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Plan_Actos_de_InvestigacionDataMain.length; i++) {
            data[i] = Detalle_Plan_Actos_de_InvestigacionDataMain[i];

        }
        return data;
    }
    function Detalle_Plan_Actos_de_InvestigaciongetNewResult() {
        var newData = copyMainDetalle_Plan_Actos_de_InvestigacionArray();

        for (var i = 0; i < Detalle_Plan_Actos_de_InvestigacionData.length; i++) {
            if (Detalle_Plan_Actos_de_InvestigacionData[i].Removed == null || Detalle_Plan_Actos_de_InvestigacionData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Plan_Actos_de_InvestigacionData[i]);
            }
        }
        return newData;
    }
    function Detalle_Plan_Actos_de_InvestigacionpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Plan_Actos_de_InvestigacionDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Plan_Actos_de_InvestigacionDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteExpediente_MPData = [];
function GetAutoCompletePlan_de_Investigacion_Expediente_MP_expediente_ministerio_publicoData(data) {
	AutoCompleteExpediente_MPData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpediente_MPData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteExpediente_MPData;
}
var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompletePlan_de_Investigacion_Usuario_que_Registra_Spartan_UserData(data) {
	AutoCompleteUsuario_que_RegistraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_RegistraData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_RegistraData;
}
//Grid GetAutocomplete
var AutoCompleteUsuario_que_ContestaData = [];
function GetAutoCompleteDetalle_Plan_Actos_de_Investigacion_Usuario_que_Contesta_Spartan_UserData(data) {
	AutoCompleteUsuario_que_ContestaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_ContestaData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_ContestaData;
}



function getDropdown(elementKey) {
    var labelSelect = $("#Plan_de_Investigacion_cmbLabelSelect").val();
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
    $('#CreatePlan_de_Investigacion')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_Plan_Actos_de_InvestigacionClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreatePlan_de_Investigacion').trigger('reset');
    $('#CreatePlan_de_Investigacion').find(':input').each(function () {
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
    var $myForm = $('#CreatePlan_de_Investigacion');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Plan_Actos_de_InvestigacioncountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Plan_Actos_de_Investigacion();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreatePlan_de_Investigacion").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreatePlan_de_Investigacion").on('click', '#Plan_de_InvestigacionCancelar', function () {
	  if (!isPartial) {
        Plan_de_InvestigacionBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreatePlan_de_Investigacion").on('click', '#Plan_de_InvestigacionGuardar', function () {
		$('#Plan_de_InvestigacionGuardar').attr('disabled', true);
		$('#Plan_de_InvestigacionGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendPlan_de_InvestigacionData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Plan_de_InvestigacionBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Plan_de_InvestigacionGuardar').removeAttr('disabled');
                        $('#Plan_de_InvestigacionGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Plan_de_Investigacion', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Plan_de_InvestigacionItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Plan_de_InvestigacionDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Plan_de_InvestigacionGuardar').removeAttr('disabled');
					$('#Plan_de_InvestigacionGuardar').bind()
				}
		}
		else {
			$('#Plan_de_InvestigacionGuardar').removeAttr('disabled');
			$('#Plan_de_InvestigacionGuardar').bind()
		}
    });
	$("form#CreatePlan_de_Investigacion").on('click', '#Plan_de_InvestigacionGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendPlan_de_InvestigacionData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Plan_Actos_de_InvestigacionData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Plan_de_Investigacion', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Plan_de_InvestigacionItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Plan_de_InvestigacionDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreatePlan_de_Investigacion").on('click', '#Plan_de_InvestigacionGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendPlan_de_InvestigacionData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Expediente_MP').empty();
    $("#Expediente_MP").append('<option value=""></option>');
    $('#Expediente_MP').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_Plan_Actos_de_InvestigacionClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Plan_Actos_de_InvestigacionData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Plan_de_Investigacion',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Plan_de_InvestigacionItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Plan_de_InvestigacionDropDown().get(0)').innerHTML);                          
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



var Plan_de_InvestigacionisdisplayBusinessPropery = false;
Plan_de_InvestigacionDisplayBusinessRuleButtons(Plan_de_InvestigacionisdisplayBusinessPropery);
function Plan_de_InvestigacionDisplayBusinessRule() {
    if (!Plan_de_InvestigacionisdisplayBusinessPropery) {
        $('#CreatePlan_de_Investigacion').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Plan_de_InvestigaciondisplayBusinessPropery"><button onclick="Plan_de_InvestigacionGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Plan_de_InvestigacionBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Plan_de_InvestigaciondisplayBusinessPropery').remove();
    }
    Plan_de_InvestigacionDisplayBusinessRuleButtons(!Plan_de_InvestigacionisdisplayBusinessPropery);
    Plan_de_InvestigacionisdisplayBusinessPropery = (Plan_de_InvestigacionisdisplayBusinessPropery ? false : true);
}
function Plan_de_InvestigacionDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

