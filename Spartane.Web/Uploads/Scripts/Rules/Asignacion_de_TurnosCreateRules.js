var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {

//Validar dependiendo del tipo de identificacion seleccionada.
$( "#Numero_de_Identificacion" ).blur(function() { 
      var tipoVal = $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex).val();
	  var NumeroVal = $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).val();
	  var valid="";
	  
	  if (tipoVal != "" && NumeroVal != ""){	
		if(tipoVal == 1) //IFE
		{
			
			
		}
		
		if(tipoVal == 6) //CURP
		{
			valid = /^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/,
			validado = NumeroVal.toUpperCase().match(valid);
			
			if (!validado) { //Coincide con el formato general?
				$('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").val("").focus().blur(); 
				return false; 
			}		
		}
	}
  });






//BusinessRuleId:1862, Attribute:265550, Operation:Field, Event:None
$("form#CreateAsignacion_de_Turnos").on('keyup', '#Nombres', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
});


//BusinessRuleId:1862, Attribute:265550, Operation:Field, Event:None

//BusinessRuleId:1863, Attribute:265551, Operation:Field, Event:None
$("form#CreateAsignacion_de_Turnos").on('keyup', '#Apellido_Paterno', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
});


//BusinessRuleId:1863, Attribute:265551, Operation:Field, Event:None

//BusinessRuleId:1864, Attribute:265552, Operation:Field, Event:None
$("form#CreateAsignacion_de_Turnos").on('keyup', '#Apellido_Materno', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
});


//BusinessRuleId:1864, Attribute:265552, Operation:Field, Event:None



//BusinessRuleId:1512, Attribute:265557, Operation:Field, Event:None
$("form#CreateAsignacion_de_Turnos").on('change', '#Urgencia', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divTipo_de_Urgencia').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex),'null');} else { $('#divTipo_de_Urgencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex),'0'); AsignarValor($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex),'null');}
});

//BusinessRuleId:1512, Attribute:265557, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {

//BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Turno" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Hora_de_Turno" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Turno" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Hora_de_Turno" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Turno" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Hora_de_Turno" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1508, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Turno' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable));


}
//BusinessRuleId:1508, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Numero_de_Turno" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Numero_de_Turno" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Numero_de_Turno" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:1510, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Numero_de_Turno' + rowIndex),EvaluaQuery("declare @Num int"
+" set @Num = (SELECT 0)"
+" declare @Count int"
+" set @Count = (SELECT COUNT(Folio) from Asignacion_de_Turnos where DATEDIFF(DAY,Fecha_de_Turno,GETDATE()) = 0)"
+" "
+" "
+" while @Num <= @Count"
+" BEGIN"
+" SET @Num = @Num + 1"
+" END "
+" "
+" SELECT @Num		", rowIndex, nameOfTable));


}
//BusinessRuleId:1510, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { DisabledControl($("#" + nameOfTable + "Recepcion" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Modulo" + rowIndex), ("true" == "true"));} else {}


}
//BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { DisabledControl($("#" + nameOfTable + "Recepcion" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Modulo" + rowIndex), ("true" == "true"));} else {}


}
//BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { DisabledControl($("#" + nameOfTable + "Recepcion" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Modulo" + rowIndex), ("true" == "true"));} else {}


}
//BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('5', '5') ) { 
$('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));
 $('#divFecha_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex)); 
 $('#divHora_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Turno' + rowIndex));
 $('#divUnidad_de_Atencion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));
 $('#divRecepcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Recepcion' + rowIndex)); 
 $('#divOrientador').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex)); 
 $('#divEstatus_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex));
 $('#divModulo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo' + rowIndex)); 
 $('#divMotivo_Finalizacion_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
  $('#divFecha_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
  $('#divHora_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
  $('#divFecha_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
  $('#divHora_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));
 } else {}


}
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { 
$('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));
 $('#divFecha_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex)); 
 $('#divHora_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Turno' + rowIndex));
 $('#divUnidad_de_Atencion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));
 $('#divRecepcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Recepcion' + rowIndex)); 
 $('#divUrgencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Urgencia' + rowIndex)); 
 $('#divEstatus_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex));
 $('#divMotivo_Finalizacion_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
  $('#divFecha_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
  $('#divHora_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
  $('#divFecha_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
  $('#divHora_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));
 } else {}


}
//BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('5', '5') ) { 
$('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); 
$('#divFecha_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex)); 
$('#divHora_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Turno' + rowIndex)); 
$('#divUnidad_de_Atencion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex)); 
$('#divRecepcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Recepcion' + rowIndex)); 
$('#divOrientador').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex)); 
$('#divEstatus_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex)); 
$('#divModulo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo' + rowIndex)); 
$('#divMotivo_Finalizacion_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
  $('#divFecha_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
  $('#divHora_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
  $('#divFecha_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
  $('#divHora_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));

} else {}


}
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { 
$('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));
 $('#divFecha_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex)); 
 $('#divHora_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Turno' + rowIndex));
 $('#divUnidad_de_Atencion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));
 $('#divRecepcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Recepcion' + rowIndex)); 
 $('#divUrgencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Urgencia' + rowIndex)); 
 $('#divEstatus_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex));
 $('#divMotivo_Finalizacion_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
  $('#divFecha_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
  $('#divHora_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
  $('#divFecha_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
  $('#divHora_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));
 } else {}


}
//BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('5', '5') ) { 
$('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); 
$('#divFecha_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex)); 
$('#divHora_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Turno' + rowIndex)); 
$('#divUnidad_de_Atencion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex)); 
$('#divRecepcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Recepcion' + rowIndex)); 
$('#divOrientador').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex)); 
$('#divEstatus_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex)); 
$('#divModulo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo' + rowIndex)); 
$('#divMotivo_Finalizacion_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
  $('#divFecha_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
  $('#divHora_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
  $('#divFecha_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
  $('#divHora_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));
} else {}


}
if(operation == 'Consult'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { 
$('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));
 $('#divFecha_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex)); 
 $('#divHora_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Turno' + rowIndex));
 $('#divUnidad_de_Atencion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));
 $('#divRecepcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Recepcion' + rowIndex)); 
 $('#divUrgencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Urgencia' + rowIndex)); 
 $('#divEstatus_de_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex));
 $('#divMotivo_Finalizacion_Turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
  $('#divFecha_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
  $('#divHora_de_Asignacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
  $('#divFecha_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
  $('#divHora_de_Finalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));
 } else {}


}
//BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
	if( $('#' + nameOfTable + 'Urgencia' + rowIndex).prop("checked") === true ) { 
	$('#divTipo_de_Urgencia').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));} 
	else { $('#divTipo_de_Urgencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex)); 
	SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));}
}

if(operation == 'Update'){
	if( $('#' + nameOfTable + 'Urgencia' + rowIndex).prop("checked") === true ) { 
	$('#divTipo_de_Urgencia').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));} 
	else { $('#divTipo_de_Urgencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex)); 
	SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));}
}

if(operation == 'Consult'){
	if( $('#' + nameOfTable + 'Urgencia' + rowIndex).prop("checked") === true ) { 
	$('#divTipo_de_Urgencia').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));} 
	else { $('#divTipo_de_Urgencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex)); 
	SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));}
}


//BusinessRuleId:1615, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex),'2'); DisabledControl($("#" + nameOfTable + "Estatus_de_Turno" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1615, Attribute:0, Operation:Object, Event:SCREENOPENING

















//BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


}
//BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


}
//BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


}
//BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1867, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


}
//BusinessRuleId:1867, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1867, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


}
//BusinessRuleId:1867, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:1984, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { AsignarValor($('#' + nameOfTable + 'Orientador' + rowIndex),EvaluaQuery(" select GLOBAL[USERID]", rowIndex, nameOfTable));} else {}


}
//BusinessRuleId:1984, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Orientador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex));}


}
//BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Orientador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex));}


}
//BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Orientador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex));}


}
//BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING

























//BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divUrgencia').css('display', 'block');} else {}

}
//BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divUrgencia').css('display', 'block');} else {}

}
//BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divUrgencia').css('display', 'block');} else {}

}
//BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1513, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') || EvaluaQuery("select GLOBAL[USERROLEID]	",rowIndex, nameOfTable)==TryParseInt('5', '5') ) { AsignarValor($('#' + nameOfTable + 'Recepcion' + rowIndex),EvaluaQuery(" select GLOBAL[USERID]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex),EvaluaQuery(" SELECT CLAVE FROM UNIDAD WHERE CLAVE = (SELECT TOP 1 UNIDAD FROM Relacion_Unidad_Usuario WHERE USUARIO = GLOBAL[USERID])", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Unidad_de_Atencion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Recepcion' + rowIndex));}} else {}

}
//BusinessRuleId:1513, Attribute:0, Operation:Object, Event:SCREENOPENING

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


