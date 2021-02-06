var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$("#Relaciones_MASCGuardarYNuevo").hide();
$("#Relaciones_MASCGuardarYCopia").hide();

$(document).ready(function () {
	if(
        EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('101', '101') ||
        EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('103', '103')
      ) {
        $("#Relaciones_MASCGuardar").remove();
        $("#Relaciones_MASCGuardarYNuevo").remove();
        $("#Relaciones_MASCGuardarYCopia").remove();
    }
	if(
        EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('2', '2')
      ) {
        $("#Relaciones_MASCGuardarYNuevo").remove();
        $("#Relaciones_MASCGuardarYCopia").remove();
    }


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

//BusinessRuleId:3120, Attribute:269177, Operation:Field, Event:None
$("form#CreateRelaciones_MASC").on('change', '#Resultado_proc', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divMotivo_de_Rechazo_proc').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));} else { $('#divMotivo_de_Rechazo_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));}
});

//BusinessRuleId:3120, Attribute:269177, Operation:Field, Event:None



//BusinessRuleId:3542, Attribute:269172, Operation:Field, Event:None
$("form#CreateRelaciones_MASC").on('change', '#Resolucion_proc', function () {
	nameOfTable='';
	rowIndex='';
	debugger;
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Resolucion_proc' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'hora_resolucion_proc' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));
});

//BusinessRuleId:3542, Attribute:269172, Operation:Field, Event:None

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



//BusinessRuleId:3085, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('2', '2')!=EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resultado_proc' + rowIndex),nameOfTable,rowIndex)!=EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { $('#divFecha_de_Validacion_proc').css('display', 'block');$('#divHora_de_Validacion_proc').css('display', 'block');$('#divUsuario_que_Valida_proc').css('display', 'block');$('#divResultado_proc').css('display', 'block');$('#divMotivo_de_Rechazo_proc').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));}} else {}

}
//BusinessRuleId:3085, Attribute:0, Operation:Object, Event:SCREENOPENING





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







//BusinessRuleId:3121, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Estatus from Solicitud where Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('101', '101') && TryParseInt('2', '2')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)!=EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { $('#divFecha_de_Validacion_proc').css('display', 'block');$('#divHora_de_Validacion_proc').css('display', 'block');$('#divUsuario_que_Valida_proc').css('display', 'block');$('#divResultado_proc').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));} else {}

}
//BusinessRuleId:3121, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:3099, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Estatus from Solicitud where Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('91', '91') && TryParseInt('2', '2')!=EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resultado_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { $('#divFecha_de_Validacion_proc').css('display', 'block');$('#divHora_de_Validacion_proc').css('display', 'block');$('#divUsuario_que_Valida_proc').css('display', 'block');$('#divResultado_proc').css('display', 'block');} else {}

}
//BusinessRuleId:3099, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3102, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divMotivo_de_Rechazo_proc').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));} else { $('#divMotivo_de_Rechazo_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));}

}
//BusinessRuleId:3102, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3102, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divMotivo_de_Rechazo_proc').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));} else { $('#divMotivo_de_Rechazo_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));}

}
//BusinessRuleId:3102, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3534, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:3534, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3534, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:3534, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3534, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:3534, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3094, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Estatus from Solicitud where Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('91', '91') ) { $("a[href='#tabResolucion_de_Procedimiento']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'hora_resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_resuelve_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Resuelve_solicitud' + rowIndex),EvaluaQuery(" SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); $('#divFecha_de_Validacion_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));$('#divHora_de_Validacion_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));$('#divUsuario_que_Valida_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));$('#divresultado_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex)); $('#divFecha_de_Validacion_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));$('#divHora_de_Validacion_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));$('#divUsuario_que_Valida_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));$('#divresultado_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));$('#divmotivo_rechazo_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));} else {}

}
//BusinessRuleId:3094, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:3543, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable)==TryParseInt('101', '101') && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') ) { $("a[href='#tabResolucion_de_Procedimiento']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'hora_resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_resuelve_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));} else {}

}
//BusinessRuleId:3543, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3540, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('2', '2')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable)==TryParseInt('101', '101') ) { $('#divFecha_de_Validacion_solicitud').css('display', 'block');$('#divHora_de_Validacion_solicitud').css('display', 'block');$('#divUsuario_que_Valida_solicitud').css('display', 'block');$('#divresultado_solicitud').css('display', 'block');$('#divmotivo_rechazo_solicitud').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "motivo_rechazo_solicitud" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));} $('#divFecha_de_Resolucion_proc').css('display', 'block');$('#divhora_resolucion_proc').css('display', 'block');$('#divusuario_resuelve_proc').css('display', 'block');$('#divResolucion_proc').css('display', 'block');$('#divObservaciones_proc').css('display', 'block');$('#divFecha_de_Validacion_proc').css('display', 'block');$('#divHora_de_Validacion_proc').css('display', 'block');$('#divUsuario_que_Valida_proc').css('display', 'block');$('#divResultado_proc').css('display', 'block');$('#divMotivo_de_Rechazo_proc').css('display', 'block');} else {}

}
//BusinessRuleId:3540, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3544, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('2', '2')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable)==TryParseInt('101', '101') && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex),EvaluaQuery(" SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); $('#divresultado_solicitud').css('display', 'block'); DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));} SetRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}} else {}

}
//BusinessRuleId:3544, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3548, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable)==TryParseInt('102', '102') && GetValueByControlType($('#' + nameOfTable + 'Resultado_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { $("a[href='#tabResolucion_de_Procedimiento']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'hora_resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_resuelve_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex)); $('#divFecha_de_Validacion_solicitud').css('display', 'block');$('#divHora_de_Validacion_solicitud').css('display', 'block');$('#divUsuario_que_Valida_solicitud').css('display', 'block');$('#divresultado_solicitud').css('display', 'block');$('#divmotivo_rechazo_solicitud').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "motivo_rechazo_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));} else {}

}
//BusinessRuleId:3548, Attribute:0, Operation:Object, Event:SCREENOPENING























//BusinessRuleId:3545, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) &&  EvaluaOperatorIn (EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable), EvaluaQuery("select STUFF((   select ',' + CAST(Clave AS nvarchar(max)) + '' from Estatus_Solicitud where clave not in (102) for XML PATH('')  ), 1, 1, '')",rowIndex, nameOfTable) ) &&  EvaluaOperatorIn (GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex), EvaluaQuery("select STUFF(( select ',' + CAST(Clave AS nvarchar(max)) + '' from Resolucion_MASC where clave in (193000,194000) for XML PATH('') ), 1, 1, '')",rowIndex, nameOfTable) ) ) { $("a[href='#tabResolucion_de_Procedimiento']").css('display', 'block'); $('#divFecha_de_Validacion_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));$('#divHora_de_Validacion_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));$('#divUsuario_que_Valida_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));$('#divResultado_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));$('#divMotivo_de_Rechazo_proc').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex)); AsignarValor($('#' + nameOfTable + 'usuario_resuelve_proc' + rowIndex),EvaluaQuery("SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));} else {}

}
//BusinessRuleId:3545, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3550, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable)==TryParseInt('102', '102') ) { $('#divFecha_de_Resolucion_solicitud').css('display', 'block');$('#divHora_de_Resolucion_solicitud').css('display', 'block');$('#divUsuario_que_Resuelve_solicitud').css('display', 'block');$('#divResolucion').css('display', 'block');$('#divTipo_de_Mecanismo').css('display', 'block');$('#divObservaciones_solicitud').css('display', 'block');$('#divFecha_de_Validacion_solicitud').css('display', 'block');$('#divHora_de_Validacion_solicitud').css('display', 'block');$('#divUsuario_que_Valida_solicitud').css('display', 'block');$('#divresultado_solicitud').css('display', 'block');$('#divmotivo_rechazo_solicitud').css('display', 'block');$('#divFecha_de_Resolucion_proc').css('display', 'block');$('#divhora_resolucion_proc').css('display', 'block');$('#divusuario_resuelve_proc').css('display', 'block');$('#divResolucion_proc').css('display', 'block');$('#divResultado_proc').css('display', 'block');$('#divMotivo_de_Rechazo_proc').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Resolucion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Resuelve_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Resuelve_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Mecanismo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "motivo_rechazo_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));}} else {}

}
//BusinessRuleId:3550, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3551, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "motivo_rechazo_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));}} else {}

}
//BusinessRuleId:3551, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3552, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resultado_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_resuelve_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion_proc' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_proc' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'hora_resolucion_proc' + rowIndex));} else {}

}
//BusinessRuleId:3552, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3541, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('2', '2')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { $('#divFecha_de_Validacion_proc').css('display', 'block');$('#divHora_de_Validacion_proc').css('display', 'block');$('#divUsuario_que_Valida_proc').css('display', 'block');$('#divResultado_proc').css('display', 'block');$('#divMotivo_de_Rechazo_proc').css('display', 'block'); AsignarValor($('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex),EvaluaQuery("SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); SetRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));} else {}

}
//BusinessRuleId:3541, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3561, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('2', '2')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable)==TryParseInt('101', '101') &&  EvaluaOperatorIn (GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex), EvaluaQuery("select STUFF(( select ',' + CAST(Clave AS nvarchar(max)) + '' from Resolucion_MASC where clave in (193000,194000) for XML PATH('') ), 1, 1, '')",rowIndex, nameOfTable) ) ) { $('#divFecha_de_Validacion_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));$('#divHora_de_Validacion_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));$('#divUsuario_que_Valida_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));$('#divresultado_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));$('#divmotivo_rechazo_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "motivo_rechazo_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));}} else {}

}
//BusinessRuleId:3561, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec usp_FiltroResolucionesMASC_ConsiderandoCDI GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec usp_FiltroResolucionesMASC_ConsiderandoCDI GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion_proc' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec usp_FiltroResolucionesMASC_ConsiderandoCDI GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec usp_FiltroResolucionesMASC_ConsiderandoCDI GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion_proc' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec usp_FiltroResolucionesMASC_ConsiderandoCDI GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec usp_FiltroResolucionesMASC_ConsiderandoCDI GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion_proc' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion_MASC where Resolucion_para_Procedimiento =1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion_proc' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3073, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3609, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('2', '2')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { $('#divFecha_de_Validacion_solicitud').css('display', 'block');$('#divHora_de_Validacion_solicitud').css('display', 'block');$('#divUsuario_que_Valida_solicitud').css('display', 'block');$('#divresultado_solicitud').css('display', 'block');$('#divmotivo_rechazo_solicitud').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "motivo_rechazo_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));}} else {}

}
//BusinessRuleId:3609, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3620, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt('103', '103')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('101', '101')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Expediente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Procedimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Procedimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Requiere_cambiar_la_relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_cambiar_la_relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Cambio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Cambio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Resolucion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Resuelve_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Resuelve_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Mecanismo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "motivo_rechazo_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "hora_resolucion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora_resolucion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "usuario_resuelve_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_resuelve_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "idRelacionOrigen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'idRelacionOrigen' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Requerido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Solicitante" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));}} else {}

}
//BusinessRuleId:3620, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3620, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('103', '103')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('101', '101')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Expediente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Procedimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Procedimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Requiere_cambiar_la_relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_cambiar_la_relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Cambio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Cambio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Resolucion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Resuelve_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Resuelve_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Mecanismo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "motivo_rechazo_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "hora_resolucion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora_resolucion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "usuario_resuelve_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_resuelve_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_proc" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_proc' + rowIndex));}DisabledControl($("#" + nameOfTable + "idRelacionOrigen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'idRelacionOrigen' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Requerido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Solicitante" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));}} else {}

}
//BusinessRuleId:3620, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3623, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { $('#divFecha_de_Validacion_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));$('#divHora_de_Validacion_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));$('#divUsuario_que_Valida_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));$('#divresultado_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));$('#divmotivo_rechazo_solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Valida_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Valida_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "resultado_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'resultado_solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "motivo_rechazo_solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_rechazo_solicitud' + rowIndex));}} else {}

}
//BusinessRuleId:3623, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3627, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divEstatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));

}
//BusinessRuleId:3627, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3627, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divEstatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));

}
//BusinessRuleId:3627, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3627, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divEstatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));

}
//BusinessRuleId:3627, Attribute:0, Operation:Object, Event:SCREENOPENING

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





















//BusinessRuleId:3538, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) &&  EvaluaOperatorIn (GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex), EvaluaQuery("select STUFF((   select ',' + CAST(Clave AS nvarchar(max)) + '' from Resolucion_MASC where Resolucion_para_solicitud = 1 and Rechazo = 1 for XML PATH('')  ), 1, 1, '')",rowIndex, nameOfTable) ) && EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable)==TryParseInt('91', '91') ) { EvaluaQuery("update Solicitud set Estatus = 101 where Clave = FLD[Numero_de_Expediente]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3538, Attribute:2, Operation:Object, Event:AFTERSAVING





//BusinessRuleId:3549, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') &&  EvaluaOperatorIn (EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable), EvaluaQuery("select STUFF((   select ',' + CAST(Clave AS nvarchar(max)) + '' from Estatus_Solicitud where clave not in (101) for XML PATH('')  ), 1, 1, '')",rowIndex, nameOfTable) ) ) { EvaluaQuery(" update Solicitud set Estatus = 101 where Clave = FLD[Numero_de_Expediente]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3549, Attribute:2, Operation:Object, Event:AFTERSAVING



//BusinessRuleId:3537, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt('2', '2')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Resultado_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { EvaluaQuery("update Solicitud set Estatus = 102 where Clave = FLD[Numero_de_Expediente]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3537, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3546, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt('2', '2')==EvaluaQuery("SELECT GLOBAL[USERROLEID] ",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'resultado_solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') && EvaluaQuery("select Rechazo from Resolucion_MASC where Resolucion_para_solicitud = 1 and Clave = FLD[Resolucion]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { EvaluaQuery("update Solicitud set Estatus = 92 where Clave = FLD[Numero_de_Expediente]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3546, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3547, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt('2', '2')==EvaluaQuery("SELECT GLOBAL[USERROLEID] ",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'resultado_solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { EvaluaQuery(" update Solicitud set Estatus = 102 where Clave = FLD[Numero_de_Expediente]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3547, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3608, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable)==TryParseInt('102', '102') &&  EvaluaOperatorIn (GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex), EvaluaQuery("select STUFF((   select ',' + CAST(Clave AS nvarchar(max)) + '' from Resolucion_MASC where clave  in (193000, 194000) for XML PATH('')  ), 1, 1, '')",rowIndex, nameOfTable) ) && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { EvaluaQuery("update Solicitud set Estatus = 93 where Clave = FLD[Numero_de_Expediente]", rowIndex, nameOfTable); EvaluaQuery("exec uspGeneraFolioRelacionesMASC FLDD[lblClave]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3608, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3539, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt('2', '2')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Resolucion_proc' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Resultado_proc' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { EvaluaQuery(" update Solicitud set Estatus = 99 where Clave = FLD[Numero_de_Expediente]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3539, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3535, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( EvaluaQuery("select Estatus from Solicitud where Clave = FLD[Numero_de_Expediente]",rowIndex, nameOfTable)==TryParseInt('91', '91') &&  EvaluaOperatorIn (GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex), EvaluaQuery("select STUFF((   select ',' + CAST(Clave AS nvarchar(max)) + '' from Resolucion_MASC where Resolucion_para_solicitud = 1 and Rechazo = 0 for XML PATH('')  ), 1, 1, '')",rowIndex, nameOfTable) ) ) { EvaluaQuery("exec uspGeneraFolioRelacionesMASC FLDD[lblClave]", rowIndex, nameOfTable); EvaluaQuery("update Solicitud set Estatus = 93 where Clave = FLD[Numero_de_Expediente]", rowIndex, nameOfTable); EvaluaQuery("update Relaciones_MASC set Estatus = 93 where Clave = FLDD[lblClave]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3535, Attribute:2, Operation:Object, Event:AFTERSAVING

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

