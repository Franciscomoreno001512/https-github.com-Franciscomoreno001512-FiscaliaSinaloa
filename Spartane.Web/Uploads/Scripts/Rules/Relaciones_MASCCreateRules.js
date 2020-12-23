var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {


//BusinessRuleId:3079, Attribute:269143, Operation:Field, Event:None
$("form#CreateRelaciones_MASC").on('change', '#resultado_solicitud', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'resultado_solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divmotivo_rechazo_solicitud').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));} else { $('#divmotivo_rechazo_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));}
});

//BusinessRuleId:3079, Attribute:269143, Operation:Field, Event:None

//BusinessRuleId:3078, Attribute:269130, Operation:Field, Event:None
$("form#CreateRelaciones_MASC").on('change', '#Requiere_cambiar_la_relacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Requiere_cambiar_la_relacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divMotivo_de_Cambio').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Cambio' + rowIndex)); if('false' == 'true')
{
	$('#divRelacion a').attr('disabled', 'disabled');
	$('#divRelacion a').css("pointer-events","none");
}
else
{
	$('#divRelacion a').attr('disabled', '');
	$('#divRelacion a').css("pointer-events","all");
}} else { $('#divMotivo_de_Cambio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Cambio' + rowIndex)); if('true' == 'true')
{
	$('#divRelacion a').attr('disabled', 'disabled');
	$('#divRelacion a').css("pointer-events","none");
}
else
{
	$('#divRelacion a').attr('disabled', '');
	$('#divRelacion a').css("pointer-events","all");
}}
});

//BusinessRuleId:3078, Attribute:269130, Operation:Field, Event:None

//BusinessRuleId:3105, Attribute:269137, Operation:Field, Event:None
$("form#CreateRelaciones_MASC").on('change', '#Resolucion', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Rechazo from Resolucion_MASC where Clave = FLD[Resolucion]",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { $('#divTipo_de_Mecanismo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));} else { $('#divTipo_de_Mecanismo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));}
});

//BusinessRuleId:3105, Attribute:269137, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






//BusinessRuleId:3072, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));$('#dividRelacionOrigen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRelacionOrigen' + rowIndex)); DisabledControl($("#" + nameOfTable + "Numero_de_Procedimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Procedimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Resuelve_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Resuelve_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_proc' + rowIndex));

}
//BusinessRuleId:3072, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3072, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));$('#dividRelacionOrigen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRelacionOrigen' + rowIndex)); DisabledControl($("#" + nameOfTable + "Numero_de_Procedimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Procedimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Resuelve_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Resuelve_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_proc' + rowIndex));

}
//BusinessRuleId:3072, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3072, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));$('#dividRelacionOrigen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRelacionOrigen' + rowIndex)); DisabledControl($("#" + nameOfTable + "Numero_de_Procedimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Procedimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Resuelve_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Resuelve_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_proc' + rowIndex));

}
//BusinessRuleId:3072, Attribute:0, Operation:Object, Event:SCREENOPENING















//BusinessRuleId:3077, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'resultado_solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divmotivo_rechazo_solicitud').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));} else { $('#divmotivo_rechazo_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));}

}
//BusinessRuleId:3077, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3077, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'resultado_solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divmotivo_rechazo_solicitud').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));} else { $('#divmotivo_rechazo_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));}

}
//BusinessRuleId:3077, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3081, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('2', '2')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { DisabledControl($("#" + nameOfTable + "Numero_de_Expediente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Procedimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Procedimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Requiere_cambiar_la_relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_cambiar_la_relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Cambio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Cambio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Resolucion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Resuelve_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Resuelve_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Mecanismo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "hora_resolucion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora_resolucion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "usuario_resuelve_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_resuelve_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_proc' + rowIndex));}} else {}

}
//BusinessRuleId:3081, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3084, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('2', '2')!=EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'resultado_solicitud' + rowIndex),nameOfTable,rowIndex)!=EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { $('#divFecha_de_Validacion_solicitud').css('display', 'block');$('#divHora_de_Validacion_solicitud').css('display', 'block');$('#divUsuario_que_Valida_solicitud').css('display', 'block');$('#divresultado_solicitud').css('display', 'block');$('#divmotivo_rechazo_solicitud').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "motivo_rechazo_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));}} else {}

}
//BusinessRuleId:3084, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3085, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('2', '2')!=EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resultado_proc' + rowIndex),nameOfTable,rowIndex)!=EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { $('#divFecha_de_Validacion_proc').css('display', 'block');$('#divHora_de_Validacion_proc').css('display', 'block');$('#divUsuario_que_Valida_proc').css('display', 'block');$('#divResultado_proc').css('display', 'block');$('#divMotivo_de_Rechazo_proc').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));}} else {}

}
//BusinessRuleId:3085, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3094, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Estatus from Solicitud where Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('91', '91') ) { $("a[href='#tabResolucion_de_Procedimiento']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'hora_resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_resuelve_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Resuelve_solicitud' + rowIndex),EvaluaQuery(" SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); $('#divFecha_de_Validacion_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));$('#divHora_de_Validacion_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));$('#divUsuario_que_Valida_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));$('#divresultado_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));} else {}

}
//BusinessRuleId:3094, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3099, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Estatus from Solicitud where Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('91', '91') && TryParseInt('2', '2')!=EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') ) { $('#divFecha_de_Validacion_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));$('#divHora_de_Validacion_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));$('#divUsuario_que_Valida_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));$('#divResultado_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));} else {}

}
//BusinessRuleId:3099, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3076, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Requiere_cambiar_la_relacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divMotivo_de_Cambio').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Cambio' + rowIndex)); if('false' == 'true')
{
	$('#divRelacion a').attr('disabled', 'disabled');
	$('#divRelacion a').css("pointer-events","none");
}
else
{
	$('#divRelacion a').attr('disabled', '');
	$('#divRelacion a').css("pointer-events","all");
}} else { $('#divMotivo_de_Cambio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Cambio' + rowIndex)); if('true' == 'true')
{
	$('#divRelacion a').attr('disabled', 'disabled');
	$('#divRelacion a').css("pointer-events","none");
}
else
{
	$('#divRelacion a').attr('disabled', '');
	$('#divRelacion a').css("pointer-events","all");
}}

}
//BusinessRuleId:3076, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3076, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Requiere_cambiar_la_relacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divMotivo_de_Cambio').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Cambio' + rowIndex)); if('false' == 'true')
{
	$('#divRelacion a').attr('disabled', 'disabled');
	$('#divRelacion a').css("pointer-events","none");
}
else
{
	$('#divRelacion a').attr('disabled', '');
	$('#divRelacion a').css("pointer-events","all");
}} else { $('#divMotivo_de_Cambio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Cambio' + rowIndex)); if('true' == 'true')
{
	$('#divRelacion a').attr('disabled', 'disabled');
	$('#divRelacion a').css("pointer-events","none");
}
else
{
	$('#divRelacion a').attr('disabled', '');
	$('#divRelacion a').css("pointer-events","all");
}}

}
//BusinessRuleId:3076, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3106, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Rechazo from Resolucion_MASC where Clave = FLD[Resolucion]",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { $('#divTipo_de_Mecanismo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));} else { $('#divTipo_de_Mecanismo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));}

}
//BusinessRuleId:3106, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3106, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select Rechazo from Resolucion_MASC where Clave = FLD[Resolucion]",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { $('#divTipo_de_Mecanismo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));} else { $('#divTipo_de_Mecanismo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));}

}
//BusinessRuleId:3106, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion_proc' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion_proc' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion_proc' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:3080, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("exec uspAsignaEstatusRelacionMASC FLDD[lblClave]", rowIndex, nameOfTable);

}
//BusinessRuleId:3080, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3089, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" EXEC usp_SetObservacionesDeRelacionesMASC FLDD[lblClave]", rowIndex, nameOfTable);

}
//BusinessRuleId:3089, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Relaciones_MASC(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Relaciones_MASC//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Relaciones_MASC(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Relaciones_MASC//
}
function EjecutarValidacionesAlEliminarMRDetalle_Relaciones_MASC(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Relaciones_MASC//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Relaciones_MASC(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Relaciones_MASC//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Relaciones_MASC(nameOfTable, rowIndex){
    var result = true;
    







//BusinessRuleId:3075, Attribute:269129, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Solicitante' + rowIndex).val();   $('#' + nameOfTable + 'Solicitante' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Solicitante' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre_completo from detalle_De_Datos_generales with(nolock) where expediente_masc= GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre_completo from detalle_De_Datos_generales with(nolock) where expediente_masc= GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Solicitante' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Solicitante' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Requerido' + rowIndex).val();   $('#' + nameOfTable + 'Requerido' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Requerido' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave, Nombre_Completo_Detenido from Detalle_de_Imputado with(nolock) where expediente_masc= GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave, Nombre_Completo_Detenido from Detalle_de_Imputado with(nolock) where expediente_masc= GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Requerido' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Requerido' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3075, Attribute:269129, Operation:Object, Event:EDITROWMR

//BusinessRuleId:3075, Attribute:269129, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Solicitante' + rowIndex).val();   $('#' + nameOfTable + 'Solicitante' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Solicitante' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre_completo from detalle_De_Datos_generales with(nolock) where expediente_masc= GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre_completo from detalle_De_Datos_generales with(nolock) where expediente_masc= GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Solicitante' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Solicitante' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Requerido' + rowIndex).val();   $('#' + nameOfTable + 'Requerido' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Requerido' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave, Nombre_Completo_Detenido from Detalle_de_Imputado with(nolock) where expediente_masc= GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave, Nombre_Completo_Detenido from Detalle_de_Imputado with(nolock) where expediente_masc= GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Requerido' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Requerido' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3075, Attribute:269129, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Relaciones_MASC//
    return result;
}

