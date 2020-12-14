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

function EjecutarValidacionesAntesDeGuardarMRDetalle_Datos_Adicionales_Movimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Datos_Adicionales_Movimiento//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Datos_Adicionales_Movimiento(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Datos_Adicionales_Movimiento//
}
function EjecutarValidacionesAlEliminarMRDetalle_Datos_Adicionales_Movimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Datos_Adicionales_Movimiento//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Datos_Adicionales_Movimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Datos_Adicionales_Movimiento//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Datos_Adicionales_Movimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Datos_Adicionales_Movimiento//
    return result;
}

