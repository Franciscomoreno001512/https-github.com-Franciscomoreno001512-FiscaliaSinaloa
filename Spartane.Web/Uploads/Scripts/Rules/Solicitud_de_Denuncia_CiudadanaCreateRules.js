var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {

	//COD-MANI INI OCULTAR BOTONES
	$('#Solicitud_de_Denuncia_CiudadanaGuardarYNuevo').css('display', 'none');
	$('#Solicitud_de_Denuncia_CiudadanaGuardarYCopia').css('display', 'none');
	if(roleActivo==110 || roleActivo==108){	
		$("#ConfigureSave").addClass("hidden");
		$("#Solicitud_de_Denuncia_CiudadanaCancelar").addClass("hidden");
		$("#Solicitud_de_Denuncia_CiudadanaGuardar").addClass("hidden");		
	}
	
	if(roleActivo==110){
		$("#side-menu").addClass("hidden");
		$("#logoutForm").addClass("hidden");
		
	}



//COD-MANI END OCULTAR BOTONES





	//BusinessRuleId:3203, Attribute:269219, Operation:Field, Event:None
	$("form#CreateSolicitud_de_Denuncia_Ciudadana").on('change', '#Estatus_de_Solicitud', function () {
		nameOfTable='';
		rowIndex='';
	if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') || GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divMotivo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Motivo' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));} else { $('#divMotivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Motivo' + rowIndex),EvaluaQuery(" SELECT ISNULL('', '')", rowIndex, nameOfTable));}
	});


	//BusinessRuleId:3203, Attribute:269219, Operation:Field, Event:None

	//BusinessRuleId:3278, Attribute:269219, Operation:Field, Event:None
	$("form#CreateSolicitud_de_Denuncia_Ciudadana").on('change', '#Estatus_de_Solicitud', function () {
		nameOfTable='';
		rowIndex='';
	if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divUnidad_canaliza').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));} else { $('#divUnidad_canaliza').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}
	});

	//BusinessRuleId:3278, Attribute:269219, Operation:Field, Event:None

	//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
































































































//BusinessRuleId:3144, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3144, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3144, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3144, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3144, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3144, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3146, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3146, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3146, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3146, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3146, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3146, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3148, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3148, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3148, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3148, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3148, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3148, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3150, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3150, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3150, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3150, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3150, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:3150, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3204, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') || GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divMotivo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex));} else { $('#divMotivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex));}


}
//BusinessRuleId:3204, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3204, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') || GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divMotivo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex));} else { $('#divMotivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex));}


}
//BusinessRuleId:3204, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3204, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') || GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divMotivo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex));} else { $('#divMotivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex));}


}
//BusinessRuleId:3204, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contrasena' + rowIndex));}


}
//BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contrasena' + rowIndex));}


}
//BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contrasena' + rowIndex));}


}
//BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3263, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Canalizar_a' + rowIndex),'3');


}
//BusinessRuleId:3263, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divCanalizar_a').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));


}
//BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divCanalizar_a').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));


}
//BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divCanalizar_a').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));


}
//BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('108', '108') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('110', '110') ) { DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contrasena' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divUsuario_que_Registra').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));$('#divContrasena').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Contrasena' + rowIndex));} else {}


}
//BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('108', '108') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('110', '110') ) { DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contrasena' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divUsuario_que_Registra').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));$('#divContrasena').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Contrasena' + rowIndex));} else {}


}
//BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('108', '108') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('110', '110') ) { DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contrasena' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divUsuario_que_Registra').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));$('#divContrasena').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Contrasena' + rowIndex));} else {}


}
//BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 CreateSessionVar('Unidad', EvaluaQuery(" SELECT DESCRIPCION FROM UNIDAD WHERE CLAVE = FLD[Unidad]", rowIndex, nameOfTable));


}
//BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 CreateSessionVar('Unidad', EvaluaQuery(" SELECT DESCRIPCION FROM UNIDAD WHERE CLAVE = FLD[Unidad]", rowIndex, nameOfTable));


}
//BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 CreateSessionVar('Unidad', EvaluaQuery(" SELECT DESCRIPCION FROM UNIDAD WHERE CLAVE = FLD[Unidad]", rowIndex, nameOfTable));


}
//BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divUnidad_canaliza').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));} else { $('#divUnidad_canaliza').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}

}
//BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divUnidad_canaliza').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));} else { $('#divUnidad_canaliza').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}

}
//BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divUnidad_canaliza').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));} else { $('#divUnidad_canaliza').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}

}
//BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:3206, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" EXEC UspInsAtencionInicial_desde_SolicitudDenuncia FLDD[lblClave], FLD[Canalizar_a] ", rowIndex, nameOfTable);


}
//BusinessRuleId:3206, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3206, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" EXEC UspInsAtencionInicial_desde_SolicitudDenuncia FLDD[lblClave], FLD[Canalizar_a] ", rowIndex, nameOfTable);


}
//BusinessRuleId:3206, Attribute:2, Operation:Object, Event:AFTERSAVING











//BusinessRuleId:3269, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { 
SendEmailQuery('Aprobación de pre-denuncia en Portal Ciudadano.', 
EvaluaQuery("SELECT EMAIL FROM SPARTAN_USER WHERE ID_USER = FLD[Usuario_que_Registra]"), 
"<!doctype html> <html> <head> <meta charset='utf-8'> <!-- utf-8 works for most cases --> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <!-- Forcing initial-scale shouldn't be necessary --> <meta http-equiv='X-UA-Compatible' content='IE=edge'> <!-- Use the latest (edge) version of IE rendering engine --> <title>EmailTemplate-Fluid</title> <!-- The title tag shows in email notifications, like Android 4.4. -->​<!-- Please use an inliner tool to convert all CSS to inline as inpage or external CSS is removed by email clients --> <!-- important in CSS is used to prevent the styles of currently inline CSS from overriding the ones mentioned in media queries when corresponding screen sizes are encountered -->​<!-- CSS Reset --> <style type='text/css'> /* What it does: Remove spaces around the email design added by some email clients. */ /* Beware: It can remove the padding / margin and add a background color to the compose a reply window. */ html, body { margin: 0 !important; padding: 0 !important; height: 100% !important; width: 100% !important; } /* What it does: Stops email clients resizing small text. */ * { -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; } /* What it does: Forces Outlook.com to display emails full width. */ .ExternalClass { width: 100%; } /* What is does: Centers email on Android 4.4 */ div[style*='margin: 16px 0'] { margin: 0 !important; } /* What it does: Stops Outlook from adding extra spacing to tables. */ table, td { mso-table-lspace: 0pt !important; mso-table-rspace: 0pt !important; } /* What it does: Fixes webkit padding issue. Fix for Yahoo mail table alignment bug. Applies table-layout to the first 2 tables then removes for anything nested deeper. */ table { border-spacing: 0 !important; border-collapse: collapse !important; table-layout: fixed !important; margin: 0 auto !important; } table table table { table-layout: auto; } /* What it does: Uses a better rendering method when resizing images in IE. */ img { -ms-interpolation-mode: bicubic; } /* What it does: Overrides styles added when Yahoo's auto-senses a link. */ .yshortcuts a { border-bottom: none !important; } /* What it does: Another work-around for iOS meddling in triggered links. */ a[x-apple-data-detectors] { color: inherit !important; } </style>​<!-- Progressive Enhancements --> <style type='text/css'> /* What it does: Hover styles for buttons */ .button-td, .button-a { transition: all 100ms ease-in; } .button-td:hover, .button-a:hover { color: #000; } </style> </head> <body width='100%' height='100%' bgcolor='#e0e0e0' style='margin: 0;' yahoo='yahoo'> <table cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' bgcolor='#e0e0e0' style='border-collapse:collapse;'> <tr> <td><center style='width: 100%;'> <!-- Visually Hidden Preheader Text : BEGIN --> <div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'> (Optional) This text will appear in the inbox preview, but not the email body. </div> <!-- Visually Hidden Preheader Text : END --> <div style='max-width: 600px;'> <!--[if (gte mso 9)|(IE)]> <table cellspacing='0' cellpadding='0' border='0' align='center'> <tr> <td> <![endif]--> <!-- Email Header : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 600px;'> <tr> <td style='padding: 20px 0; text-align: center'><img src='http://192.168.1.101/MVCfiscaliasinaloa/Images/logo-fiscalia-sinaloa.png' width='108' height='126' alt='alt_text' border='0'></td> </tr> </table> <!-- Email Header : END --> <!-- Email Body : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='100%' style='max-width: 600px;'> <!-- 1 Column Text : BEGIN --> <tr> <td><table cellspacing='0' cellpadding='0' border='0' width='100%'> <tr> <td style='padding: 40px; font-family: sans-serif; font-size: 15px; mso-height-rule: exactly; line-height: 20px; color: #555555;'> <p style='font-size:16px; font-weight: bold; text-align:center'></p>​<p> Su Pre-denuncia con el Folio: FLD[Folio] ha sido registrada, en breve personal de Unidad 'Atención Temprana' atenderá su solicitud </p> </td> </tr> </table></td> </tr> <!-- 1 Column Text : BEGIN -->​</table> <!-- Email Body : END --> <!-- Email Footer : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 680px;'> <tr> <td style='padding: 40px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'><webversion style='color:#aaa; text-decoration:underline; font-weight: bold;'></webversion> <br> <br> <b>Portal Ciudadano</b> <br> Fiscalía General del Estado de Sinaloa<br> <span class='mobile-link--footer'> http://www.fiscaliasinaloa.mx/ </span> <br> <!-- <br> <unsubscribe style='color:#888888; text-decoration:underline;'>unsubscribe</unsubscribe> --> </td> </tr> </table> <!-- Email Footer : END --> <!--[if (gte mso 9)|(IE)]> </td> </tr> </table> <![endif]--> </div> </center></td> </tr> </table> </body> </html>",rowIndex,nameOfTable);} else {}

}
//BusinessRuleId:3269, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3270, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { SendEmailQuery('Rechazo de pre-denuncia en Portal Ciudadano.', EvaluaQuery("SELECT EMAIL FROM SPARTAN_USER WHERE ID_USER = FLD[Usuario_que_Registra]"), "<!doctype html> <html> <head> <meta charset='utf-8'> <!-- utf-8 works for most cases --> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <!-- Forcing initial-scale shouldn't be necessary --> <meta http-equiv='X-UA-Compatible' content='IE=edge'> <!-- Use the latest (edge) version of IE rendering engine --> <title>EmailTemplate-Fluid</title> <!-- The title tag shows in email notifications, like Android 4.4. -->​<!-- Please use an inliner tool to convert all CSS to inline as inpage or external CSS is removed by email clients --> <!-- important in CSS is used to prevent the styles of currently inline CSS from overriding the ones mentioned in media queries when corresponding screen sizes are encountered -->​<!-- CSS Reset --> <style type='text/css'> /* What it does: Remove spaces around the email design added by some email clients. */ /* Beware: It can remove the padding / margin and add a background color to the compose a reply window. */ html, body { margin: 0 !important; padding: 0 !important; height: 100% !important; width: 100% !important; } /* What it does: Stops email clients resizing small text. */ * { -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; } /* What it does: Forces Outlook.com to display emails full width. */ .ExternalClass { width: 100%; } /* What is does: Centers email on Android 4.4 */ div[style*='margin: 16px 0'] { margin: 0 !important; } /* What it does: Stops Outlook from adding extra spacing to tables. */ table, td { mso-table-lspace: 0pt !important; mso-table-rspace: 0pt !important; } /* What it does: Fixes webkit padding issue. Fix for Yahoo mail table alignment bug. Applies table-layout to the first 2 tables then removes for anything nested deeper. */ table { border-spacing: 0 !important; border-collapse: collapse !important; table-layout: fixed !important; margin: 0 auto !important; } table table table { table-layout: auto; } /* What it does: Uses a better rendering method when resizing images in IE. */ img { -ms-interpolation-mode: bicubic; } /* What it does: Overrides styles added when Yahoo's auto-senses a link. */ .yshortcuts a { border-bottom: none !important; } /* What it does: Another work-around for iOS meddling in triggered links. */ a[x-apple-data-detectors] { color: inherit !important; } </style>​<!-- Progressive Enhancements --> <style type='text/css'> /* What it does: Hover styles for buttons */ .button-td, .button-a { transition: all 100ms ease-in; } .button-td:hover, .button-a:hover { color: #000; } </style> </head> <body width='100%' height='100%' bgcolor='#e0e0e0' style='margin: 0;' yahoo='yahoo'> <table cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' bgcolor='#e0e0e0' style='border-collapse:collapse;'> <tr> <td><center style='width: 100%;'> <!-- Visually Hidden Preheader Text : BEGIN --> <div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'> (Optional) This text will appear in the inbox preview, but not the email body. </div> <!-- Visually Hidden Preheader Text : END --> <div style='max-width: 600px;'> <!--[if (gte mso 9)|(IE)]> <table cellspacing='0' cellpadding='0' border='0' align='center'> <tr> <td> <![endif]--> <!-- Email Header : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 600px;'> <tr> <td style='padding: 20px 0; text-align: center'><img src='http://192.168.1.101/MVCfiscaliasinaloa/Images/logo-fiscalia-sinaloa.png' width='108' height='126' alt='alt_text' border='0'></td> </tr> </table> <!-- Email Header : END --> <!-- Email Body : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='100%' style='max-width: 600px;'> <!-- 1 Column Text : BEGIN --> <tr> <td><table cellspacing='0' cellpadding='0' border='0' width='100%'> <tr> <td style='padding: 40px; font-family: sans-serif; font-size: 15px; mso-height-rule: exactly; line-height: 20px; color: #555555;'> <p style='font-size:16px; font-weight: bold; text-align:center'> Su pre-denuncia ha sido rechazada. </p>​<p> Lo sentimos, su pre-denuncia con el Folio: FLD[Folio] no ha sido procesada correctamente por los siguientes motivos: FLD[Motivo]. </p> </td> </tr> </table></td> </tr> <!-- 1 Column Text : BEGIN -->​</table> <!-- Email Body : END --> <!-- Email Footer : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 680px;'> <tr> <td style='padding: 40px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'><webversion style='color:#aaa; text-decoration:underline; font-weight: bold;'></webversion> <br> <br> <b>Portal Ciudadano</b> <br> Fiscalía General del Estado de Sinaloa<br> <span class='mobile-link--footer'> http://www.fiscaliasinaloa.mx/ </span> <br> <!-- <br> <unsubscribe style='color:#888888; text-decoration:underline;'>unsubscribe</unsubscribe> --> </td> </tr> </table> <!-- Email Footer : END --> <!--[if (gte mso 9)|(IE)]> </td> </tr> </table> <![endif]--> </div> </center></td> </tr> </table> </body> </html>",rowIndex,nameOfTable);} else {}

}
//BusinessRuleId:3270, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3271, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { SendEmailQuery('Corrección pendiente de pre-denuncia en Portal Ciudadano.', EvaluaQuery("SELECT EMAIL FROM SPARTAN_USER WHERE ID_USER = FLD[Usuario_que_Registra]"), "<!doctype html> <html> <head> <meta charset='utf-8'> <!-- utf-8 works for most cases --> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <!-- Forcing initial-scale shouldn't be necessary --> <meta http-equiv='X-UA-Compatible' content='IE=edge'> <!-- Use the latest (edge) version of IE rendering engine --> <title>EmailTemplate-Fluid</title> <!-- The title tag shows in email notifications, like Android 4.4. -->​<!-- Please use an inliner tool to convert all CSS to inline as inpage or external CSS is removed by email clients --> <!-- important in CSS is used to prevent the styles of currently inline CSS from overriding the ones mentioned in media queries when corresponding screen sizes are encountered -->​<!-- CSS Reset --> <style type='text/css'> /* What it does: Remove spaces around the email design added by some email clients. */ /* Beware: It can remove the padding / margin and add a background color to the compose a reply window. */ html, body { margin: 0 !important; padding: 0 !important; height: 100% !important; width: 100% !important; } /* What it does: Stops email clients resizing small text. */ * { -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; } /* What it does: Forces Outlook.com to display emails full width. */ .ExternalClass { width: 100%; } /* What is does: Centers email on Android 4.4 */ div[style*='margin: 16px 0'] { margin: 0 !important; } /* What it does: Stops Outlook from adding extra spacing to tables. */ table, td { mso-table-lspace: 0pt !important; mso-table-rspace: 0pt !important; } /* What it does: Fixes webkit padding issue. Fix for Yahoo mail table alignment bug. Applies table-layout to the first 2 tables then removes for anything nested deeper. */ table { border-spacing: 0 !important; border-collapse: collapse !important; table-layout: fixed !important; margin: 0 auto !important; } table table table { table-layout: auto; } /* What it does: Uses a better rendering method when resizing images in IE. */ img { -ms-interpolation-mode: bicubic; } /* What it does: Overrides styles added when Yahoo's auto-senses a link. */ .yshortcuts a { border-bottom: none !important; } /* What it does: Another work-around for iOS meddling in triggered links. */ a[x-apple-data-detectors] { color: inherit !important; } </style>​<!-- Progressive Enhancements --> <style type='text/css'> /* What it does: Hover styles for buttons */ .button-td, .button-a { transition: all 100ms ease-in; } .button-td:hover, .button-a:hover { color: #000; } </style> </head> <body width='100%' height='100%' bgcolor='#e0e0e0' style='margin: 0;' yahoo='yahoo'> <table cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' bgcolor='#e0e0e0' style='border-collapse:collapse;'> <tr> <td><center style='width: 100%;'> <!-- Visually Hidden Preheader Text : BEGIN --> <div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'> (Optional) This text will appear in the inbox preview, but not the email body. </div> <!-- Visually Hidden Preheader Text : END --> <div style='max-width: 600px;'> <!--[if (gte mso 9)|(IE)]> <table cellspacing='0' cellpadding='0' border='0' align='center'> <tr> <td> <![endif]--> <!-- Email Header : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 600px;'> <tr> <td style='padding: 20px 0; text-align: center'><img src='http://192.168.1.101/MVCfiscaliasinaloa/Images/logo-fiscalia-sinaloa.png' width='108' height='126' alt='alt_text' border='0'></td> </tr> </table> <!-- Email Header : END --> <!-- Email Body : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='100%' style='max-width: 600px;'> <!-- 1 Column Text : BEGIN --> <tr> <td><table cellspacing='0' cellpadding='0' border='0' width='100%'> <tr> <td style='padding: 40px; font-family: sans-serif; font-size: 15px; mso-height-rule: exactly; line-height: 20px; color: #555555;'> <p style='font-size:16px; font-weight: bold; text-align:center'> Su pre-denuncia debe ser corregida. </p>​<p> Es necesario se acerque al módulo de atención o marcar a los teléfonos de atención ciudadana </p> </td> </tr> </table></td> </tr> <!-- 1 Column Text : BEGIN -->​</table> <!-- Email Body : END --> <!-- Email Footer : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 680px;'> <tr> <td style='padding: 40px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'><webversion style='color:#aaa; text-decoration:underline; font-weight: bold;'></webversion> <br> <br> <b>Portal Ciudadano</b> <br> Fiscalía General del Estado de Sinaloa<br> <span class='mobile-link--footer'> http://www.fiscaliasinaloa.mx/ </span> <br> <!-- <br> <unsubscribe style='color:#888888; text-decoration:underline;'>unsubscribe</unsubscribe> --> </td> </tr> </table> <!-- Email Footer : END --> <!--[if (gte mso 9)|(IE)]> </td> </tr> </table> <![endif]--> </div> </center></td> </tr> </table> </body> </html>",rowIndex,nameOfTable);} else {}

}
//BusinessRuleId:3271, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


