var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {

//VALIDAR CORREO ELECTRÓNICO
$('#Correo').change(function(){ 
	let email = $('#Correo').val(); 
	let exp = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/); 
	if (exp.test(email) == false){ 
			$('#Correo').attr("placeholder", "Correo electrónico no válido.").val("").focus().blur(); 
	} 
});


//COD-MANI INI OCULTAR CONTRASEÑA
//$("#Contrasena").attr("type","password");
//$("#Confirmar_Contrasena").attr("type","password");
//COD-MANI END OCULTAR CONTRASEÑA

//BusinessRuleId:3058, Attribute:269002, Operation:Field, Event:None
$("form#CreateRegistro_de_Usuario").on('keyup', '#Nombres', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
});


//BusinessRuleId:3058, Attribute:269002, Operation:Field, Event:None

//BusinessRuleId:3059, Attribute:269003, Operation:Field, Event:None
$("form#CreateRegistro_de_Usuario").on('keyup', '#Apellido_Paterno', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
});


//BusinessRuleId:3059, Attribute:269003, Operation:Field, Event:None

//BusinessRuleId:3060, Attribute:269004, Operation:Field, Event:None
$("form#CreateRegistro_de_Usuario").on('keyup', '#Apellido_Materno', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
});


//BusinessRuleId:3060, Attribute:269004, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {












//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Correo' + rowIndex));


}
//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Correo' + rowIndex));


}
//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Correo' + rowIndex));


}
//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;










//BusinessRuleId:3064, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Contrasena' + rowIndex),nameOfTable,rowIndex)!=GetValueByControlType($('#' + nameOfTable + 'Confirmar_Contrasena' + rowIndex),nameOfTable,rowIndex) ) { alert(DecodifyText('Las contraseñas no coinciden, favor de revisar.', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:3064, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:3061, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


}
//BusinessRuleId:3061, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3061, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


}
//BusinessRuleId:3061, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3063, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC InsertSpartanRegistroUsuarios GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:3063, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


