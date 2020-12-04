var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2749, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Medio_de_Prueba_Presentado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Presentacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Medida_Cautelar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Proceso_Penal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Medio_de_Prueba_Presentado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Presentacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Proceso_Penal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Medio_de_Prueba_Presentado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Admitido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Proceso_Penal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Reclasificacion_Juridica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Plazo_Constitucional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Vinculacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_No_Vinculacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_Vinculacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'plazo_investigacion_complementaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'fecha_investigacion_complementaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'hora_investigacion_complementaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez_de_Control' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Entrega_de_Escrito_de_Acusacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Entrega_de_Escrito_de_Acusacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Audiencia_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Audiencia_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Acusador_Coadyudante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cumplio_descubrimiento_probatorio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdos_Probatorios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'acuerdos_probatorios_cuales_fueron' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Colegiado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Audiencia_de_Juicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Audiencia_de_Juicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fallo_del_Tribunal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'pruebas_a_desahogar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Plazo_meses' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_anios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_meses' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Reparacion_del_Dano' + rowIndex));

}
//BusinessRuleId:2749, Attribute:0, Operation:Object, Event:SCREENOPENING

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

function EjecutarValidacionesAntesDeGuardarMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Delitos_Proceso_Penal//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Delitos_Proceso_Penal//
}
function EjecutarValidacionesAlEliminarMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Delitos_Proceso_Penal//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Delitos_Proceso_Penal//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Delitos_Proceso_Penal//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Medidas_Cautelares_Proceso_Penal//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Medidas_Cautelares_Proceso_Penal//
}
function EjecutarValidacionesAlEliminarMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Medidas_Cautelares_Proceso_Penal//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Medidas_Cautelares_Proceso_Penal//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Medidas_Cautelares_Proceso_Penal//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Medios_Prueba_Imputado//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Medios_Prueba_Imputado//
}
function EjecutarValidacionesAlEliminarMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Medios_Prueba_Imputado//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Medios_Prueba_Imputado//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Medios_Prueba_Imputado//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Medios_Prueba_Victima//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Medios_Prueba_Victima//
}
function EjecutarValidacionesAlEliminarMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Medios_Prueba_Victima//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Medios_Prueba_Victima//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Medios_Prueba_Victima//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Medios_Prueba_Admitidos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Medios_Prueba_Admitidos//
}
function EjecutarValidacionesAlEliminarMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Medios_Prueba_Admitidos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Medios_Prueba_Admitidos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Medios_Prueba_Admitidos//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Condiciones_Proceso_Penal//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Condiciones_Proceso_Penal//
}
function EjecutarValidacionesAlEliminarMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Condiciones_Proceso_Penal//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Condiciones_Proceso_Penal//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Condiciones_Proceso_Penal//
    return result;
}

