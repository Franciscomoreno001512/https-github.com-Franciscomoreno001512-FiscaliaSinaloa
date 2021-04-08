var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
    $("#Detalle_de_AmparoGuardarYNuevo").hide();
    $("#Detalle_de_AmparoGuardarYCopia").hide();

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:4938, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divOrden_de_Aprehension').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Orden_de_Aprehension' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Orden_de_Aprehension' + rowIndex));

}
//BusinessRuleId:4938, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4938, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divOrden_de_Aprehension').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Orden_de_Aprehension' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Orden_de_Aprehension' + rowIndex));

}
//BusinessRuleId:4938, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4938, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divOrden_de_Aprehension').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Orden_de_Aprehension' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Orden_de_Aprehension' + rowIndex));

}
//BusinessRuleId:4938, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){




//BusinessRuleId:4936, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('6', '6') ) { EvaluaQuery("update detalle_de_amparo set Orden_de_Aprehension = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:4936, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


