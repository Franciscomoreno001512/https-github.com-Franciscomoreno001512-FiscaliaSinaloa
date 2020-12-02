var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING

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

function EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Audiencia_Defensor_Imputado//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Audiencia_Defensor_Imputado//
}
function EjecutarValidacionesAlEliminarMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Audiencia_Defensor_Imputado//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Audiencia_Defensor_Imputado//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Audiencia_Defensor_Imputado//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Audiencia_Defensor_Victima//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Audiencia_Defensor_Victima//
}
function EjecutarValidacionesAlEliminarMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Audiencia_Defensor_Victima//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Audiencia_Defensor_Victima//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Audiencia_Defensor_Victima//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Audiencia_Archivos_Adjuntos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Audiencia_Archivos_Adjuntos//
}
function EjecutarValidacionesAlEliminarMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Audiencia_Archivos_Adjuntos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Audiencia_Archivos_Adjuntos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Audiencia_Archivos_Adjuntos//
    return result;
}

