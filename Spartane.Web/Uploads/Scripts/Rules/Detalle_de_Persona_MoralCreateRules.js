var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {


//BusinessRuleId:638, Attribute:263907, Operation:Field, Event:None
$("form#CreateDetalle_de_Persona_Moral").on('change', '#Colonia', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Colonia' + rowIndex).val()!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Codigo_Postal' + rowIndex),EvaluaQuery("select codigo_postal from Codigo_Postal where colonia=FLD[Colonia]", rowIndex, nameOfTable));} else {}
});

//BusinessRuleId:638, Attribute:263907, Operation:Field, Event:None

//BusinessRuleId:661, Attribute:263913, Operation:Field, Event:None
$("form#CreateDetalle_de_Persona_Moral").on('keyup', '#Celular', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Celular' + rowIndex).val()!=TryParseInt('null', 'null') && EvaluaQuery("select LEN('FLD[Celular]')",rowIndex, nameOfTable)<TryParseInt('10', '10') || EvaluaQuery("SELECT ISNUMERIC('FLD[Celular]')",rowIndex, nameOfTable)==TryParseInt('0', '0') && $('#' + nameOfTable + 'Celular' + rowIndex).val()!=TryParseInt('', '') ) { alert(DecodifyText('El número de teléfono debe tener 10 dígitos sin letras', rowIndex, nameOfTable));
result=false; AsignarValor($('#' + nameOfTable + 'Celular' + rowIndex),'');
result=false;
result=false;} else {}
});

//BusinessRuleId:661, Attribute:263913, Operation:Field, Event:None

//BusinessRuleId:662, Attribute:263911, Operation:Field, Event:None
$("form#CreateDetalle_de_Persona_Moral").on('keyup', '#Telefono', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Telefono' + rowIndex).val()!=TryParseInt('null', 'null') && EvaluaQuery("select LEN('FLD[Telefono]')",rowIndex, nameOfTable)<TryParseInt('10', '10') || EvaluaQuery("SELECT ISNUMERIC('FLD[Telefono]')",rowIndex, nameOfTable)==TryParseInt('0', '0') && $('#' + nameOfTable + 'Telefono' + rowIndex).val()!=TryParseInt('', '') ) { alert(DecodifyText('El número de teléfono debe tener 10 dígitos sin letras', rowIndex, nameOfTable));
result=false; AsignarValor($('#' + nameOfTable + 'Telefono' + rowIndex),'');
result=false;
result=false;} else {}
});

//BusinessRuleId:662, Attribute:263911, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






//BusinessRuleId:612, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),'1');

}
//BusinessRuleId:612, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:1326, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Localidad" + rowIndex), ("true" == "true")); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex));

}
//BusinessRuleId:1326, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1326, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Localidad" + rowIndex), ("true" == "true")); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex));

}
//BusinessRuleId:1326, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1453, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));

}
//BusinessRuleId:1453, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1453, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));

}
//BusinessRuleId:1453, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1453, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));

}
//BusinessRuleId:1453, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1721, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); $('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));

}
//BusinessRuleId:1721, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1312, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));

}
//BusinessRuleId:1312, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1312, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));

}
//BusinessRuleId:1312, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); $('#divLocalidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex));

}
//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); $('#divLocalidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex));

}
//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); $('#divLocalidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex));

}
//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1739, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));

}
//BusinessRuleId:1739, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1730, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("  update Detalle_de_Persona_Moral"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:1730, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


