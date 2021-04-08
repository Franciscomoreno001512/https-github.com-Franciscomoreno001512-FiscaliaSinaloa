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

function EjecutarValidacionesAntesDeGuardarMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Personas_donde_se_ejecuto_mandamiento//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Personas_donde_se_ejecuto_mandamiento//
}
function EjecutarValidacionesAlEliminarMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Personas_donde_se_ejecuto_mandamiento//
    return result;
}
function EjecutarValidacionesNewRowMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Personas_donde_se_ejecuto_mandamiento//
    return result;
}
function EjecutarValidacionesEditRowMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Personas_donde_se_ejecuto_mandamiento//
    return result;
}

