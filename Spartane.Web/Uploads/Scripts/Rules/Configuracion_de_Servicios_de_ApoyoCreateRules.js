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

function EjecutarValidacionesAntesDeGuardarMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Solicitud_Disponibles_Configuracion//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Solicitud_Disponibles_Configuracion//
}
function EjecutarValidacionesAlEliminarMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Solicitud_Disponibles_Configuracion//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Solicitud_Disponibles_Configuracion//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Solicitud_Disponibles_Configuracion//
    return result;
}

