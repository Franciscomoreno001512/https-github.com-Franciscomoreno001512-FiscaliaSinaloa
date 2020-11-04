var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {




























//BusinessRuleId:1967, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1967, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1967, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1967, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1967, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1967, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1717, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1717, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1717, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1717, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2003, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2003, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2003, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2003, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2003, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2003, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){


//BusinessRuleId:2009, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" EXEC uspActualizaDelitos FLDD[lblClave]", rowIndex, nameOfTable);

}
//BusinessRuleId:2009, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRAgravantes_del_Delito_MASC(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Agravantes_del_Delito_MASC//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRAgravantes_del_Delito_MASC(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Agravantes_del_Delito_MASC//
}
function EjecutarValidacionesAlEliminarMRAgravantes_del_Delito_MASC(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Agravantes_del_Delito_MASC//
    return result;
}
function EjecutarValidacionesNewRowMRAgravantes_del_Delito_MASC(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Agravantes_del_Delito_MASC//
    return result;
}
function EjecutarValidacionesEditRowMRAgravantes_del_Delito_MASC(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Agravantes_del_Delito_MASC//
    return result;
}


function EjecutarValidacionesAntesDeGuardarMRCircunstancias_del_Delito_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Circunstancias_del_Delito_MASC// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRCircunstancias_del_Delito_MASC(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Circunstancias_del_Delito_MASC// 
} 

function EjecutarValidacionesAlEliminarMRCircunstancias_del_Delito_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Circunstancias_del_Delito_MASC// 
 return result; 
} 

function EjecutarValidacionesNewRowMRCircunstancias_del_Delito_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Circunstancias_del_Delito_MASC// 
  return result; 
} 

function EjecutarValidacionesEditRowMRCircunstancias_del_Delito_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Circunstancias_del_Delito_MASC// 
 return result; 
} 
