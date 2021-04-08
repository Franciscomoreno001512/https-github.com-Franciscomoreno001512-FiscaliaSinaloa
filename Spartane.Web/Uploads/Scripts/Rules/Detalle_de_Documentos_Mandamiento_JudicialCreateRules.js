var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
    $("#Detalle_de_Documentos_Mandamiento_JudicialGuardarYNuevo").hide();
    $("#Detalle_de_Documentos_Mandamiento_JudicialGuardarYCopia").hide();

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:4939, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divRegistro_de_Orden_de_Aprehension').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_de_Orden_de_Aprehension' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_de_Orden_de_Aprehension' + rowIndex));

}
//BusinessRuleId:4939, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4939, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divRegistro_de_Orden_de_Aprehension').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_de_Orden_de_Aprehension' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_de_Orden_de_Aprehension' + rowIndex));

}
//BusinessRuleId:4939, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4939, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divRegistro_de_Orden_de_Aprehension').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_de_Orden_de_Aprehension' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_de_Orden_de_Aprehension' + rowIndex));

}
//BusinessRuleId:4939, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){




//BusinessRuleId:4937, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('6', '6') ) { EvaluaQuery("update Detalle_de_Documentos_Mandamiento_Judicial set Registro_de_Orden_de_Aprehension = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:4937, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


