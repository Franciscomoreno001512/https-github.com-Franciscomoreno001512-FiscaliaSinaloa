var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:1727, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));

}
//BusinessRuleId:1727, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1748, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));

}
//BusinessRuleId:1748, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causal_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));

}
//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causal_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));

}
//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causal_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));

}
//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1736, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Desestimacion"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:1736, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


