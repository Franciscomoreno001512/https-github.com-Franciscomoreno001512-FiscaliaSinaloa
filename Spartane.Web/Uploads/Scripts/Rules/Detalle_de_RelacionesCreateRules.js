var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:1724, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));

}
//BusinessRuleId:1724, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1744, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));

}
//BusinessRuleId:1744, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));

}
//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));

}
//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));

}
//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1733, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Relaciones"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:1733, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


