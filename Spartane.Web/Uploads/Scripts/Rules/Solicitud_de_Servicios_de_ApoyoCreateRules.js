var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {


//COD-MANI INI OCULTAR BOTONES
$('#Solicitud_de_Servicios_de_ApoyoGuardarYNuevo').css('display', 'none');
$('#Solicitud_de_Servicios_de_ApoyoGuardarYCopia').css('display', 'none');


//BusinessRuleId:4384, Attribute:273008, Operation:Field, Event:None
$("form#CreateSolicitud_de_Servicios_de_Apoyo").on('change', '#SubArea_Asignada', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).val();   $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT ID_USER, NAME FROM SPARTAN_USER WHERE ROLE = 117 "
+" AND ID_USER IN (SELECT USUARIO FROM Asignacion_responsable_servicios_apoyo AR"
+" INNER JOIN Detalle_subareas_responsable_servicio_apoyo DS ON DS.Asignacion = AR.Clave"
+" WHERE DS.SubArea_Asignada = FLD[SubArea_Asignada])", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT ID_USER, NAME FROM SPARTAN_USER WHERE ROLE = 117 "
+" AND ID_USER IN (SELECT USUARIO FROM Asignacion_responsable_servicios_apoyo AR"
+" INNER JOIN Detalle_subareas_responsable_servicio_apoyo DS ON DS.Asignacion = AR.Clave"
+" WHERE DS.SubArea_Asignada = FLD[SubArea_Asignada])", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).val(valor).trigger('change');
});


//BusinessRuleId:4384, Attribute:273008, Operation:Field, Event:None







//BusinessRuleId:4536, Attribute:273028, Operation:Field, Event:None
$("form#CreateSolicitud_de_Servicios_de_Apoyo").on('change', '#Resultado_de_Autorizacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divMotivo_de_Rechazo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'5');} else { $('#divMotivo_de_Rechazo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'6');}
});


//BusinessRuleId:4536, Attribute:273028, Operation:Field, Event:None

//BusinessRuleId:4540, Attribute:273013, Operation:Field, Event:None
$("form#CreateSolicitud_de_Servicios_de_Apoyo").on('change', '#Tipo_de_Asignacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Asignacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divResponsable_Asignado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex)); $('#divResponsable_Asignado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));}
});


//BusinessRuleId:4540, Attribute:273013, Operation:Field, Event:None

//BusinessRuleId:4699, Attribute:273022, Operation:Field, Event:None
$("form#CreateSolicitud_de_Servicios_de_Apoyo").on('change', '#Enviar_Contestacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Enviar_Contestacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { SetRequiredToControl( $('#' + nameOfTable + 'numero_contestacion' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'numero_contestacion' + rowIndex));}
});

//BusinessRuleId:4699, Attribute:273022, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {

/*CODIGO MANUAL: RCR - PONER EL DOCUMENTO EN VISTA SOLO CONSULTA*/
	$($("#divAttachmentVer_Documento").find("label")[0]).text('Ver Solicitud');
	$($("#divAttachmentVer_Documento").find("img")[0]).css("display","none");
	$("#divVer_Documento").css("display","none");




//BusinessRuleId:4387, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $("a[href='#tabAsignacion']").css('display', 'none'); $("a[href='#tabContestacion']").css('display', 'none'); $("a[href='#tabAutorizacion']").css('display', 'none'); AsignarValor($('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex),EvaluaQuery(" SELECT NAME FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID]", rowIndex, nameOfTable)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Asignacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Asignacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Contestacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Contestacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_contesta' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Enviar_Contestacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Contestacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Revision' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Autorizacion' + rowIndex));} else {}


}
//BusinessRuleId:4387, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:4390, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divNumero_de_Expediente_AT').css('display', 'block'); $('#divNumero_de_Expediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_MP' + rowIndex));} else { $('#divNumero_de_Expediente_MP').css('display', 'block'); $('#divNumero_de_Expediente_AT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_AT' + rowIndex));}


}
//BusinessRuleId:4390, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:4383, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Solicita" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Solicita' + rowIndex));}DisabledControl($("#" + nameOfTable + "Origen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Expediente_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_AT' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "NUAT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Denuncia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Denuncia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Carpeta_de_Investigacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ver_Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ver_Documento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Recibe" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Contestacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Contestacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_contesta" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_contesta' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Revisa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex));}DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));} $('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Recepcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Asignacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Contestacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Autorizacion' + rowIndex)); var valor = $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).val();   $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT ID_USER, NAME FROM SPARTAN_USER WHERE ROLE = 117 "
+" AND ID_USER IN (SELECT USUARIO FROM Asignacion_responsable_servicios_apoyo AR"
+" INNER JOIN Detalle_subareas_responsable_servicio_apoyo DS ON DS.Asignacion = AR.Clave"
+" WHERE DS.SubArea_Asignada = FLD[SubArea_Asignada])", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT ID_USER, NAME FROM SPARTAN_USER WHERE ROLE = 117 "
+" AND ID_USER IN (SELECT USUARIO FROM Asignacion_responsable_servicios_apoyo AR"
+" INNER JOIN Detalle_subareas_responsable_servicio_apoyo DS ON DS.Asignacion = AR.Clave"
+" WHERE DS.SubArea_Asignada = FLD[SubArea_Asignada])", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Dictamen' + rowIndex).val();   $('#' + nameOfTable + 'Dictamen' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Dictamen' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Dictamen' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Documento WHERE TIPO_DE_DOCUMENTO = 10 AND SUBAREA_DE_SERVICIOS_DE_APOYO = FLD[SubArea_Asignada]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Dictamen' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Documento WHERE TIPO_DE_DOCUMENTO = 10 AND SUBAREA_DE_SERVICIOS_DE_APOYO = FLD[SubArea_Asignada]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Dictamen' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Dictamen' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:4383, Attribute:0, Operation:Object, Event:SCREENOPENING





































































































































































































//BusinessRuleId:4530, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divDiligencia_AT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia_AT' + rowIndex));$('#divDiligencia_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia_MP' + rowIndex));


}
//BusinessRuleId:4530, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4530, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divDiligencia_AT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia_AT' + rowIndex));$('#divDiligencia_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia_MP' + rowIndex));


}
//BusinessRuleId:4530, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4530, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divDiligencia_AT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia_AT' + rowIndex));$('#divDiligencia_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia_MP' + rowIndex));


}
//BusinessRuleId:4530, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:4531, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { AsignarValor($('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Revision' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex),EvaluaQuery("SELECT NAME FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID]", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Solicita" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Solicita' + rowIndex));} DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));} DisabledControl($("#" + nameOfTable + "Origen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Expediente_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_AT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Diligencia_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia_AT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_MP' + rowIndex));} DisabledControl($("#" + nameOfTable + "Diligencia_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia_MP' + rowIndex));} DisabledControl($("#" + nameOfTable + "NUAT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Denuncia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Denuncia' + rowIndex));} DisabledControl($("#" + nameOfTable + "Carpeta_de_Investigacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));} DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Ver_Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ver_Documento' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));} DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Recibe" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex));} DisabledControl($("#" + nameOfTable + "Area_Asignada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Asignada' + rowIndex));} DisabledControl($("#" + nameOfTable + "SubArea_Asignada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));} DisabledControl($("#" + nameOfTable + "Tipo_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Responsable_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Contestacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Contestacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_contesta" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_contesta' + rowIndex));} DisabledControl($("#" + nameOfTable + "Dictamen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));} DisabledControl($("#" + nameOfTable + "Enviar_Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Enviar_Contestacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Archivo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones_Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Contestacion' + rowIndex));}} else {}


}
//BusinessRuleId:4531, Attribute:0, Operation:Object, Event:SCREENOPENING











//BusinessRuleId:4538, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('6', '6') ) { AsignarValor($('#' + nameOfTable + 'Fecha_de_Contestacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Contestacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_contesta' + rowIndex),EvaluaQuery("SELECT NAME FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID] ", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Enviar_Contestacion' + rowIndex),'false'); AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'3'); DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));} DisabledControl($("#" + nameOfTable + "Tipo_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Responsable_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Revision' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Revisa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex));} DisabledControl($("#" + nameOfTable + "Resultado_de_Autorizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones_Autorizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Autorizacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Solicita" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Solicita' + rowIndex));} DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));} DisabledControl($("#" + nameOfTable + "Origen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Expediente_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_AT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Diligencia_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia_AT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_MP' + rowIndex));} DisabledControl($("#" + nameOfTable + "Diligencia_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia_MP' + rowIndex));} DisabledControl($("#" + nameOfTable + "NUAT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Denuncia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Denuncia' + rowIndex));} DisabledControl($("#" + nameOfTable + "Carpeta_de_Investigacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));} DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Ver_Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ver_Documento' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));} DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Recibe" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex));} DisabledControl($("#" + nameOfTable + "Area_Asignada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Asignada' + rowIndex));} DisabledControl($("#" + nameOfTable + "SubArea_Asignada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Recepcion' + rowIndex));}} else {}


}
//BusinessRuleId:4538, Attribute:0, Operation:Object, Event:SCREENOPENING























//BusinessRuleId:4542, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select GLOBAL[Phase]",rowIndex, nameOfTable)==TryParseInt('3', '3') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex));} else {}

}
//BusinessRuleId:4542, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4541, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Asignacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divResponsable_Asignado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} else { $('#divResponsable_Asignado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));}

}
//BusinessRuleId:4541, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4541, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Asignacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divResponsable_Asignado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} else { $('#divResponsable_Asignado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));}

}
//BusinessRuleId:4541, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4541, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Asignacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divResponsable_Asignado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} else { $('#divResponsable_Asignado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));}

}
//BusinessRuleId:4541, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:4527, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $("a[href='#tabAsignacion']").css('display', 'none'); $("a[href='#tabAutorizacion']").css('display', 'none'); AsignarValor($('#' + nameOfTable + 'Fecha_de_Contestacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Contestacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_contesta' + rowIndex),EvaluaQuery("SELECT NAME FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID]", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Solicita" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Solicita' + rowIndex));} DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));} DisabledControl($("#" + nameOfTable + "Origen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Expediente_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_AT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_MP' + rowIndex));} DisabledControl($("#" + nameOfTable + "NUAT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Denuncia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Denuncia' + rowIndex));} DisabledControl($("#" + nameOfTable + "Carpeta_de_Investigacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));} DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Ver_Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ver_Documento' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));} DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Recibe" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex));} DisabledControl($("#" + nameOfTable + "Area_Asignada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Asignada' + rowIndex));} DisabledControl($("#" + nameOfTable + "SubArea_Asignada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));} DisabledControl($("#" + nameOfTable + "Tipo_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Responsable_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Asignacion' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} else {}

}
//BusinessRuleId:4527, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4527, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $("a[href='#tabAsignacion']").css('display', 'none'); $("a[href='#tabAutorizacion']").css('display', 'none'); AsignarValor($('#' + nameOfTable + 'Fecha_de_Contestacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Contestacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_contesta' + rowIndex),EvaluaQuery("SELECT NAME FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID]", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Solicita" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Solicita' + rowIndex));} DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));} DisabledControl($("#" + nameOfTable + "Origen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Expediente_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_AT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente_MP' + rowIndex));} DisabledControl($("#" + nameOfTable + "NUAT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Denuncia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Denuncia' + rowIndex));} DisabledControl($("#" + nameOfTable + "Carpeta_de_Investigacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));} DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Ver_Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ver_Documento' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));} DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Recibe" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex));} DisabledControl($("#" + nameOfTable + "Area_Asignada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Asignada' + rowIndex));} DisabledControl($("#" + nameOfTable + "SubArea_Asignada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Recepcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));} DisabledControl($("#" + nameOfTable + "Tipo_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Asignacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Responsable_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Asignacion' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} else {}

}
//BusinessRuleId:4527, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:4537, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divMotivo_de_Rechazo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex));} else { $('#divMotivo_de_Rechazo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex));}

}
//BusinessRuleId:4537, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4537, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divMotivo_de_Rechazo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex));} else { $('#divMotivo_de_Rechazo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex));}

}
//BusinessRuleId:4537, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4389, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $("a[href='#tabContestacion']").css('display', 'none'); $("a[href='#tabAutorizacion']").css('display', 'none'); DisabledControl($("#" + nameOfTable + "Fecha_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Recibe" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex));}DisabledControl($("#" + nameOfTable + "Area_Asignada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Asignada' + rowIndex));}DisabledControl($("#" + nameOfTable + "SubArea_Asignada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Recepcion' + rowIndex));} AsignarValor($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex),EvaluaQuery(" SELECT NAME FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID]", rowIndex, nameOfTable)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Revision' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Autorizacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Contestacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Contestacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_contesta' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Enviar_Contestacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Contestacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));} else {}

}
//BusinessRuleId:4389, Attribute:0, Operation:Object, Event:SCREENOPENING



















//BusinessRuleId:4552, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Solicitud_Externa' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divSolicitud_Externa').css('display', 'block');$('#divAutoridad_que_Solicita').css('display', 'block');$('#divNarracion_Solicitud').css('display', 'block');} else { $('#divSolicitud_Externa').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud_Externa' + rowIndex));$('#divAutoridad_que_Solicita').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Autoridad_que_Solicita' + rowIndex));$('#divNarracion_Solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Narracion_Solicitud' + rowIndex));}

}
//BusinessRuleId:4552, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4698, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Enviar_Contestacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { SetRequiredToControl( $('#' + nameOfTable + 'numero_contestacion' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'numero_contestacion' + rowIndex));}

}
//BusinessRuleId:4698, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:4551, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSolicitud_de_Apoyo_Externa').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud_de_Apoyo_Externa' + rowIndex)); DisabledControl($("#" + nameOfTable + "Solicitud_Externa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud_Externa' + rowIndex));}DisabledControl($("#" + nameOfTable + "Autoridad_que_Solicita" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Autoridad_que_Solicita' + rowIndex));}DisabledControl($("#" + nameOfTable + "Narracion_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Narracion_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Solicitud_de_Apoyo_Externa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud_de_Apoyo_Externa' + rowIndex));}

}
//BusinessRuleId:4551, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4551, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divSolicitud_de_Apoyo_Externa').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud_de_Apoyo_Externa' + rowIndex)); DisabledControl($("#" + nameOfTable + "Solicitud_Externa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud_Externa' + rowIndex));}DisabledControl($("#" + nameOfTable + "Autoridad_que_Solicita" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Autoridad_que_Solicita' + rowIndex));}DisabledControl($("#" + nameOfTable + "Narracion_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Narracion_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Solicitud_de_Apoyo_Externa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud_de_Apoyo_Externa' + rowIndex));}

}
//BusinessRuleId:4551, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4551, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divSolicitud_de_Apoyo_Externa').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud_de_Apoyo_Externa' + rowIndex)); DisabledControl($("#" + nameOfTable + "Solicitud_Externa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud_Externa' + rowIndex));}DisabledControl($("#" + nameOfTable + "Autoridad_que_Solicita" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Autoridad_que_Solicita' + rowIndex));}DisabledControl($("#" + nameOfTable + "Narracion_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Narracion_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Solicitud_de_Apoyo_Externa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud_de_Apoyo_Externa' + rowIndex));}

}
//BusinessRuleId:4551, Attribute:0, Operation:Object, Event:SCREENOPENING





















































































//BusinessRuleId:4892, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4892, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4892, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4892, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4892, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4892, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4894, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4894, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4894, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4894, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4894, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4894, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4896, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4896, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4896, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4896, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4896, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4896, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4898, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4898, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4898, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4898, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4898, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4898, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4900, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4900, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4900, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4900, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4900, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4900, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4902, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4902, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4902, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4902, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4902, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4902, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4904, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4904, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4904, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4904, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4904, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4904, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;






//BusinessRuleId:4526, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'3');} else {}


}
//BusinessRuleId:4526, Attribute:2, Operation:Object, Event:BEFORESAVING





















//BusinessRuleId:4529, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') && GetValueByControlType($('#' + nameOfTable + 'Enviar_Contestacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') && EvaluaQuery("SELECT Acreditada FROM Configuracion_de_Servicios_de_Apoyo WHERE SubArea = FLD[SubArea_Asignada] and Area = FLD[Area_Asignada] AND Region = FLD[Region]",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'5');} else {}

}
//BusinessRuleId:4529, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4528, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') && GetValueByControlType($('#' + nameOfTable + 'Enviar_Contestacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') && EvaluaQuery("SELECT Acreditada FROM Configuracion_de_Servicios_de_Apoyo WHERE SubArea = FLD[SubArea_Asignada] and Area = FLD[Area_Asignada] AND Region = FLD[Region]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'4');} else {}

}
//BusinessRuleId:4528, Attribute:2, Operation:Object, Event:BEFORESAVING







//BusinessRuleId:4574, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("Select GLOBAL[Phase]",rowIndex, nameOfTable)==TryParseInt('4', '4') && GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'6');} else {}

}
//BusinessRuleId:4574, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4575, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("Select GLOBAL[Phase]",rowIndex, nameOfTable)==TryParseInt('4', '4') && GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Autorizacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'5');} else {}

}
//BusinessRuleId:4575, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:4388, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'2'); EvaluaQuery("UPDATE Solicitud_de_Servicios_de_Apoyo SET ESTATUS = 2 WHERE FOLIO = FLDD[lblFolio]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:4388, Attribute:2, Operation:Object, Event:AFTERSAVING











//BusinessRuleId:4573, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("EXEC updSolicitudExternaFromSolicitudApoyo FLDD[lblFolio]", rowIndex, nameOfTable);

}
//BusinessRuleId:4573, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


