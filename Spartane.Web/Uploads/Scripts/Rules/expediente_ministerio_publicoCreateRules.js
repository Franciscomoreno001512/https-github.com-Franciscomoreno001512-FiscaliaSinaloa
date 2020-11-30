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



function EjecutarValidacionesAntesDeGuardarMRdetalle_de_observaciones_mpi(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_detalle_de_observaciones_mpi// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRdetalle_de_observaciones_mpi(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_detalle_de_observaciones_mpi// 
} 

function EjecutarValidacionesAlEliminarMRdetalle_de_observaciones_mpi(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_detalle_de_observaciones_mpi// 
 return result; 
} 

function EjecutarValidacionesNewRowMRdetalle_de_observaciones_mpi(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_detalle_de_observaciones_mpi// 
  return result; 
} 

function EjecutarValidacionesEditRowMRdetalle_de_observaciones_mpi(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_detalle_de_observaciones_mpi// 
 return result; 
} 
