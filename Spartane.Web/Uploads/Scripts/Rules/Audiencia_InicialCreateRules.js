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

function EjecutarValidacionesAntesDeGuardarMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Relaciones_Audiencia_Inicial//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Relaciones_Audiencia_Inicial//
}
function EjecutarValidacionesAlEliminarMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Relaciones_Audiencia_Inicial//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Relaciones_Audiencia_Inicial//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Relaciones_Audiencia_Inicial//
    return result;
}

