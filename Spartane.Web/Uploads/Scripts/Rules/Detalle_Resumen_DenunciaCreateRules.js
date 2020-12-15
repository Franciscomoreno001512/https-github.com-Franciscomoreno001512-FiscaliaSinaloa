var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divGenerado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generado' + rowIndex));$('#divFecha_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_registro' + rowIndex));$('#divHora_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex));

}
//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divGenerado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generado' + rowIndex));$('#divFecha_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_registro' + rowIndex));$('#divHora_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex));

}
//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divGenerado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generado' + rowIndex));$('#divFecha_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_registro' + rowIndex));$('#divHora_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex));

}
//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Ofendido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ofendido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Victima" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Victima' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}

}
//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Ofendido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ofendido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Victima" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Victima' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}

}
//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Ofendido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ofendido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Victima" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Victima' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}

}
//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:2973, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 EvaluaQuery(" EXEC UspUpdDatosResumenDenuncia_A_AtencionInicial FLDD[lblClave]", rowIndex, nameOfTable); AsignarValor($('#' + nameOfTable + 'Ofendido' + rowIndex),EvaluaQuery(" SELECT Ofendido FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Delito' + rowIndex),EvaluaQuery(" SELECT Delito FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Victima' + rowIndex),EvaluaQuery(" SELECT Victima FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Relacion' + rowIndex),EvaluaQuery(" SELECT Relacion FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable));

}
//BusinessRuleId:2973, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2973, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 EvaluaQuery(" EXEC UspUpdDatosResumenDenuncia_A_AtencionInicial FLDD[lblClave]", rowIndex, nameOfTable); AsignarValor($('#' + nameOfTable + 'Ofendido' + rowIndex),EvaluaQuery(" SELECT Ofendido FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Delito' + rowIndex),EvaluaQuery(" SELECT Delito FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Victima' + rowIndex),EvaluaQuery(" SELECT Victima FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Relacion' + rowIndex),EvaluaQuery(" SELECT Relacion FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable));

}
//BusinessRuleId:2973, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;






//BusinessRuleId:2971, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("EXEC uspGetPuedeGenerarExpediente FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { alert(DecodifyText(' Datos mínimos para generar Número de Expediente no validos!', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2971, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:2972, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" EXEC uspGeneraFolio FLDD[lblClave]", rowIndex, nameOfTable);

}
//BusinessRuleId:2972, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


