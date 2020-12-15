var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//BusinessRuleId:2983, Attribute:268570, Operation:Field, Event:None
$("form#CreateJudicializacion").on('change', '#Tribunal_de_Enjuiciamiento', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divNombre_del_Juez').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex)); $('#divJuez_Presidente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));$('#divJuez_Relator').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));$('#divJuez_Vocal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));} else { $('#divNombre_del_Juez').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex)); $('#divJuez_Presidente').css('display', 'block');$('#divJuez_Relator').css('display', 'block');$('#divJuez_Vocal').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));}
});

//BusinessRuleId:2983, Attribute:268570, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2982, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));$('#divResolucion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));$('#divObservaciones').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex)); DisabledControl($("#" + nameOfTable + "Tipo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));}DisabledControl($("#" + nameOfTable + "causa_o_cuadernillo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'causa_o_cuadernillo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fase_Actual" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fase_Actual' + rowIndex));} if('true' == 'true')
{
	$('#divVinculacion a').attr('disabled', 'disabled');
	$('#divVinculacion a').css("pointer-events","none");
}
else
{
	$('#divVinculacion a').attr('disabled', '');
	$('#divVinculacion a').css("pointer-events","all");
} SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Judicializacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'causa_o_cuadernillo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fase_Actual' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Actos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Actos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Actos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Genericos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Genericos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Genericos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Audiencia_de_Juicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Audiencia_de_Juicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'medios_desahogo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Anos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Meses' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_del_Dano' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Juicio_Oral' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Salidas_Alternas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Salidas_Alternas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Salidas_Alternas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Sobreseimientos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Sobreseimientos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Sobreseimientos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex)); $('#divTipo_de_Sentencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));$('#divCuantia_de_Pena_Anos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Anos' + rowIndex));$('#divCuantia_de_Pena_Meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Meses' + rowIndex));$('#divMonto_de_Reparacion_del_Dano').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_del_Dano' + rowIndex));

}
//BusinessRuleId:2982, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2982, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));$('#divResolucion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));$('#divObservaciones').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex)); DisabledControl($("#" + nameOfTable + "Tipo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));}DisabledControl($("#" + nameOfTable + "causa_o_cuadernillo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'causa_o_cuadernillo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fase_Actual" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fase_Actual' + rowIndex));} if('true' == 'true')
{
	$('#divVinculacion a').attr('disabled', 'disabled');
	$('#divVinculacion a').css("pointer-events","none");
}
else
{
	$('#divVinculacion a').attr('disabled', '');
	$('#divVinculacion a').css("pointer-events","all");
} SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Judicializacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'causa_o_cuadernillo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fase_Actual' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Actos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Actos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Actos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Genericos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Genericos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Genericos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Audiencia_de_Juicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Audiencia_de_Juicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'medios_desahogo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Anos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Meses' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_del_Dano' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Juicio_Oral' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Salidas_Alternas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Salidas_Alternas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Salidas_Alternas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Sobreseimientos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Sobreseimientos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Sobreseimientos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex)); $('#divTipo_de_Sentencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));$('#divCuantia_de_Pena_Anos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Anos' + rowIndex));$('#divCuantia_de_Pena_Meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Meses' + rowIndex));$('#divMonto_de_Reparacion_del_Dano').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_del_Dano' + rowIndex));

}
//BusinessRuleId:2982, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2982, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));$('#divResolucion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));$('#divObservaciones').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex)); DisabledControl($("#" + nameOfTable + "Tipo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));}DisabledControl($("#" + nameOfTable + "causa_o_cuadernillo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'causa_o_cuadernillo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fase_Actual" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fase_Actual' + rowIndex));} if('true' == 'true')
{
	$('#divVinculacion a').attr('disabled', 'disabled');
	$('#divVinculacion a').css("pointer-events","none");
}
else
{
	$('#divVinculacion a').attr('disabled', '');
	$('#divVinculacion a').css("pointer-events","all");
} SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Judicializacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'causa_o_cuadernillo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fase_Actual' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Actos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Actos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Actos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Genericos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Genericos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Genericos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Audiencia_de_Juicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Audiencia_de_Juicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'medios_desahogo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Anos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Meses' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_del_Dano' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Juicio_Oral' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Salidas_Alternas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Salidas_Alternas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Salidas_Alternas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Fase_Sobreseimientos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Fase_Sobreseimientos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Fase_Sobreseimientos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex)); $('#divTipo_de_Sentencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));$('#divCuantia_de_Pena_Anos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Anos' + rowIndex));$('#divCuantia_de_Pena_Meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Cuantia_de_Pena_Meses' + rowIndex));$('#divMonto_de_Reparacion_del_Dano').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_del_Dano' + rowIndex));

}
//BusinessRuleId:2982, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2984, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divNombre_del_Juez').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex)); $('#divJuez_Presidente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));$('#divJuez_Relator').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));$('#divJuez_Vocal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));} else { $('#divNombre_del_Juez').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex)); $('#divJuez_Presidente').css('display', 'block');$('#divJuez_Relator').css('display', 'block');$('#divJuez_Vocal').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));}

}
//BusinessRuleId:2984, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Vinculacion_Judicializacion//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Vinculacion_Judicializacion//
}
function EjecutarValidacionesAlEliminarMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Vinculacion_Judicializacion//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Vinculacion_Judicializacion//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Vinculacion_Judicializacion//
    return result;
}

