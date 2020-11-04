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

function EjecutarValidacionesAntesDeGuardarMRDetalle_del_Abogado_Victima_MPI(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_del_Abogado_Victima_MPI//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_del_Abogado_Victima_MPI(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_del_Abogado_Victima_MPI//
}
function EjecutarValidacionesAlEliminarMRDetalle_del_Abogado_Victima_MPI(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_del_Abogado_Victima_MPI//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_del_Abogado_Victima_MPI(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_del_Abogado_Victima_MPI//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_del_Abogado_Victima_MPI(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_del_Abogado_Victima_MPI//
    return result;
}

