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

function EjecutarValidacionesAntesDeGuardarMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Diligencias_Canalizacion//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Diligencias_Canalizacion//
}
function EjecutarValidacionesAlEliminarMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Diligencias_Canalizacion//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Diligencias_Canalizacion//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Diligencias_Canalizacion//
    return result;
}

