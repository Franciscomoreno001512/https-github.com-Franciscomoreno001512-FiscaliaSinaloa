var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






































































































//BusinessRuleId:4927, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4927, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4927, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4927, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4927, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4927, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4928, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4928, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4928, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4928, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4928, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4928, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4929, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4929, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4929, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4929, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4929, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4929, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4931, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4931, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4931, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4931, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4931, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4931, Attribute:0, Operation:Object, Event:SCREENOPENING

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

function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Domicilio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Domicilio//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Domicilio(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Domicilio//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Domicilio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Domicilio//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Domicilio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Domicilio//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Domicilio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Domicilio//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_telefono(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_telefono//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_telefono(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_telefono//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_telefono(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_telefono//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_telefono(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_telefono//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_telefono(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_telefono//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Otro_Nombre(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Otro_Nombre//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Otro_Nombre(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Otro_Nombre//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Otro_Nombre(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Otro_Nombre//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Otro_Nombre(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Otro_Nombre//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Otro_Nombre(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Otro_Nombre//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Delito_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Delito_Mandamiento_Judicial//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Delito_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Delito_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Delito_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Amparo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Amparo//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Amparo(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Amparo//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Amparo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Amparo//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Amparo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Amparo//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Amparo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Amparo//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Fotos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Fotos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Fotos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Fotos//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Fotos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Fotos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Fotos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Fotos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Fotos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Fotos//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Documentos_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Documentos_Mandamiento_Judicial//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Documentos_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Documentos_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Documentos_Mandamiento_Judicial//
    return result;
}


function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Personas_a_Incluir// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Personas_a_Incluir// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_de_Personas_a_Incluir// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_de_Personas_a_Incluir// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_de_Personas_a_Incluir// 
 return result; 
} 
