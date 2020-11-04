var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:307, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Nacionalidad' + rowIndex),EvaluaQuery("Select Clave from Nacionalidad where Nacionalidad like '%Mexicana%'", rowIndex, nameOfTable));

}
//BusinessRuleId:307, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:1718, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Numero_de_Expediente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));

}
//BusinessRuleId:1718, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1718, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Numero_de_Expediente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));

}
//BusinessRuleId:1718, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1971, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));

}
//BusinessRuleId:1971, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1971, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));

}
//BusinessRuleId:1971, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1971, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));

}
//BusinessRuleId:1971, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:1974, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_' + rowIndex));

}
//BusinessRuleId:1974, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1974, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_' + rowIndex));

}
//BusinessRuleId:1974, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2005, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2005, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2005, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2005, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2005, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2005, Attribute:0, Operation:Object, Event:SCREENOPENING

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


