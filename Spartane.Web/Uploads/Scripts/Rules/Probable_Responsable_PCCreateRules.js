var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {

//Validar dependiendo del tipo de identificacion seleccionada.
$("form#CreateProbable_Responsable_PC").on('change', '#Tipo_de_Identificacion', function () { 
	var tipoVal = $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex).val();   
			  if(tipoVal == 1) //CREDENCIAL DE ELECTOR
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Elector');
					  
			  }
			  
			  if(tipoVal == 2) //PASAPORTE
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Pasaporte');
					  
			  }
			  if(tipoVal == 3) //LICENCIA DE CONDUCIR
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Licencia de Conducir');
					  
			  }
			  if(tipoVal == 4) //NINGUNA
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Número de Identificación');
					  
			  }
			  if(tipoVal == 5) //CREDENCIAL DE TRABAJO
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Trabajo');
					  
			  }
			  if(tipoVal == 6) //CERTIF. DE MATRICULA CONSULAR
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Certificado de Matrícula Consular');
					  
			  }
			  if(tipoVal == 7) //CARTILLA DE SERVICIO MILITAR
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Cartilla de Servicio Militar');
					  
			  }
			  if(tipoVal == 8) //COTRAS
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Otras');
					  
			  }
			  if(tipoVal == 9) //CEDULA PROFESIONAL
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Cédula Profesional');
					  
			  }
			  if(tipoVal == 10) //CREDENCIAL DE ESTUDIANTE
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Estudiante');
					  
			  }
			  if(tipoVal == 11) //CREDENCIAL PARTIDO POLITICO
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial Partido Político');
					  
			  }
			  if(tipoVal == 12) //HOJA IDENTIFICACION MILITAR
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Hoja Identificación Militar');
					  
			  }
			  if(tipoVal == 13) //CREDENCIAL DE GANADERO
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Ganadero');
					  
			  }
});







//BusinessRuleId:3108, Attribute:269294, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Fecha_de_Nacimiento', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('NULL', 'NULL') ) { AsignarValor($('#' + nameOfTable + 'Edad' + rowIndex),EvaluaQuery(" DECLARE @date date, @tmpdate date, @years int "
+" SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento]',103)),103) "
+" SELECT @tmpdate = @date "
+" SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) "
+" THEN 1 "
+" ELSE 0 "
+" END "
+" SELECT @tmpdate = DATEADD(yy, @years, @tmpdate) "
+" SELECT @years", rowIndex, nameOfTable));} else {}
});


//BusinessRuleId:3108, Attribute:269294, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));}


}
//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));}


}
//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));}


}
//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING

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


