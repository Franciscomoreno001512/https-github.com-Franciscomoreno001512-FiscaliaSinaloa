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

function EjecutarValidacionesAntesDeGuardarMRDetalle_del_Indicio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_del_Indicio//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_del_Indicio(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_del_Indicio//
}
function EjecutarValidacionesAlEliminarMRDetalle_del_Indicio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_del_Indicio//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_del_Indicio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_del_Indicio//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_del_Indicio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_del_Indicio//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_de_Indicio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitud_de_Indicio//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitud_de_Indicio(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitud_de_Indicio//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitud_de_Indicio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitud_de_Indicio//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitud_de_Indicio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitud_de_Indicio//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitud_de_Indicio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitud_de_Indicio//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Devolucion_de_Indicios(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Devolucion_de_Indicios//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Devolucion_de_Indicios(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Devolucion_de_Indicios//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Devolucion_de_Indicios(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Devolucion_de_Indicios//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Devolucion_de_Indicios(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Devolucion_de_Indicios//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Devolucion_de_Indicios(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Devolucion_de_Indicios//
    return result;
}

