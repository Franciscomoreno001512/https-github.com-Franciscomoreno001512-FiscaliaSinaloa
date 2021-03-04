var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
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

function EjecutarValidacionesAntesDeGuardarMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_subareas_responsable_servicio_apoyo//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_subareas_responsable_servicio_apoyo//
}
function EjecutarValidacionesAlEliminarMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_subareas_responsable_servicio_apoyo//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_subareas_responsable_servicio_apoyo//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_subareas_responsable_servicio_apoyo//
    return result;
}

