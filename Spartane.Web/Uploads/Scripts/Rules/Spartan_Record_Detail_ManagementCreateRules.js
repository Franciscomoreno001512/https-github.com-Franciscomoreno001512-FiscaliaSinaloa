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

function EjecutarValidacionesAntesDeGuardarMRSpartan_RDM_Filters_Detail(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Spartan_RDM_Filters_Detail//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRSpartan_RDM_Filters_Detail(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Spartan_RDM_Filters_Detail//
}
function EjecutarValidacionesAlEliminarMRSpartan_RDM_Filters_Detail(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Spartan_RDM_Filters_Detail//
    return result;
}
function EjecutarValidacionesNewRowMRSpartan_RDM_Filters_Detail(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Spartan_RDM_Filters_Detail//
    return result;
}
function EjecutarValidacionesEditRowMRSpartan_RDM_Filters_Detail(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Spartan_RDM_Filters_Detail//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRSpartan_RDM_Operations_Detail(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Spartan_RDM_Operations_Detail//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRSpartan_RDM_Operations_Detail(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Spartan_RDM_Operations_Detail//
}
function EjecutarValidacionesAlEliminarMRSpartan_RDM_Operations_Detail(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Spartan_RDM_Operations_Detail//
    return result;
}
function EjecutarValidacionesNewRowMRSpartan_RDM_Operations_Detail(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Spartan_RDM_Operations_Detail//
    return result;
}
function EjecutarValidacionesEditRowMRSpartan_RDM_Operations_Detail(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Spartan_RDM_Operations_Detail//
    return result;
}

