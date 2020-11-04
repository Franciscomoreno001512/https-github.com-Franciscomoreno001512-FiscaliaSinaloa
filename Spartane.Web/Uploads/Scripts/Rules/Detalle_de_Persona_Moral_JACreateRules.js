var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//BusinessRuleId:1291, Attribute:264987, Operation:Field, Event:None
$("#Detalle_de_Persona_Moral_JAGrid").on('keyup', '.Nombre', function () {
	nameOfTable = $(this).parent().parent().parent().parent()[0].id.replace('Grid', '') + '_';
	rowIndex = '_' + $(this).parent().parent()[0].className.replace(' odd', '').replace(' even', '').replace(nameOfTable, '');
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex),aaa);} else {}
	nameOfTable='';
	rowIndex='';
});
$("form#CreateDetalle_de_Persona_Moral_JA").on('keyup', '#Detalle_de_Persona_Moral_JANombre', function () {
	nameOfTable='Detalle_de_Persona_Moral_JA';
	rowIndex='';
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex),aaa);} else {}
});
//BusinessRuleId:1291, Attribute:264987, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:1400, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Pais' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),1);} else {}

}
//BusinessRuleId:1400, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1400, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Pais' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),1);} else {}

}
//BusinessRuleId:1400, Attribute:0, Operation:Object, Event:SCREENOPENING

















//BusinessRuleId:1955, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:1955, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1955, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:1955, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1401, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1401, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1401, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1401, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1401, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1401, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2004, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2004, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2004, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2004, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2004, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2004, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:2010, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" EXEC uspActualizaPersonaMoral FLDD[lblClave]", rowIndex, nameOfTable);

}
//BusinessRuleId:2010, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


