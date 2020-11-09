var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$('#Detalle_de_Solicitudes_de_InvitacionesGuardarYNuevo').hide();
$('#Detalle_de_Solicitudes_de_InvitacionesGuardarYCopia').hide();
$(document).ready(function () {
//BusinessRuleId:683, Attribute:263119, Operation:Field, Event:None
$("#Detalle_de_Solicitudes_de_InvitacionesGrid").on('change', '.Fecha_de_Recepcion', function () {
	nameOfTable = $(this).parent().parent().parent().parent()[0].id.replace('Grid', '') + '_';
	rowIndex = '_' + $(this).parent().parent()[0].className.replace(' odd', '').replace(' even', '').replace(nameOfTable, '');
if( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex).val()!=TryParseInt('null', 'null') && $('#' + nameOfTable + 'Fecha_de_Aceptacion' + rowIndex).val()!=TryParseInt('null', 'null') && EvaluaQuery("Select DATEDIFF(day,CONVERT(varchar(10),'FLD[Fecha_de_Recepcion]',103),"
+" "
+" 					CONVERT(varchar(10),'FLD[Fecha_de_Aceptacion]',103))",rowIndex, nameOfTable)<TryParseInt('0', '0') ) { alert(DecodifyText('La Fecha de Aceptación Tiene Que Ser Mayor a la Fecha de Recepción', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Aceptacion' + rowIndex),);} else {}
	nameOfTable='';
	rowIndex='';
	
	
	
	


});
$("form#CreateDetalle_de_Solicitudes_de_Invitaciones").on('change', '#Detalle_de_Solicitudes_de_InvitacionesFecha_de_Recepcion', function () {
	nameOfTable='Detalle_de_Solicitudes_de_Invitaciones';
	rowIndex='';
if( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex).val()!=TryParseInt('null', 'null') && $('#' + nameOfTable + 'Fecha_de_Aceptacion' + rowIndex).val()!=TryParseInt('null', 'null') && EvaluaQuery("Select DATEDIFF(day,CONVERT(varchar(10),'FLD[Fecha_de_Recepcion]',103),"
+" "
+" 					CONVERT(varchar(10),'FLD[Fecha_de_Aceptacion]',103))",rowIndex, nameOfTable)<TryParseInt('0', '0') ) { alert(DecodifyText('La Fecha de Aceptación Tiene Que Ser Mayor a la Fecha de Recepción', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Aceptacion' + rowIndex),);} else {}
});
//BusinessRuleId:683, Attribute:263119, Operation:Field, Event:None









































//BusinessRuleId:685, Attribute:263117, Operation:Field, Event:None
$("form#CreateDetalle_de_Solicitudes_de_Invitaciones").on('change', '#Fecha_de_la_cita', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("declare @Fecha nvarchar(10) = 'FLD[Fecha_de_Invitacion]'"
+" declare @Fecha2 nvarchar(10) = 'FLD[Fecha_de_la_cita]'"
+" declare @FechaNueva nvarchar(10)"
+" declare @FechaNueva2 nvarchar(10)"
+" set @FechaNueva = substring(@Fecha,4,2) + '/' + left(@fecha,2) + '/' + right(@fecha,4)"
+" set @FechaNueva2 = substring(@Fecha2,4,2) + '/' + left(@fecha2,2) + '/' + right(@fecha2,4)"
+" select DATEDIFF(day,@FechaNueva, @FechaNueva2)"
+" "
+" ",rowIndex, nameOfTable)<=TryParseInt('0', '0') ) { alert(DecodifyText('La Fecha de la cita no puede ser menor a la fecha de Invitación', rowIndex, nameOfTable));
result=false; AsignarValor($('#' + nameOfTable + 'Fecha_de_la_cita' + rowIndex),EvaluaQuery("select convert(nvarchar(11), dateadd(day, 1, getdate()), 105)", rowIndex, nameOfTable));} else {}
});

//BusinessRuleId:685, Attribute:263117, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {














































//BusinessRuleId:1695, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Invitacion" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Numero_de_Invitacion" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:1695, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1695, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Invitacion" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Numero_de_Invitacion" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:1695, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1695, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Invitacion" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Numero_de_Invitacion" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:1695, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:1701, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Invitacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery("select name from spartan_user where id_user=GLOBAL[USERID]", rowIndex, nameOfTable)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Numero_de_Invitacion' + rowIndex),EvaluaQuery("select isnull(count(clave),0) + 1 from detalle_de_solicitudes_de_invitaciones "
+" with(nolock) where solicitud = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable)); $('#divFecha_de_Recepcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));$('#divFecha_de_Aceptacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Aceptacion' + rowIndex));$('#divA_Tiempo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'A_Tiempo' + rowIndex));$('#divCumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Cumplimiento' + rowIndex));$('#divIncidente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Incidente' + rowIndex));

}
//BusinessRuleId:1701, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:1702, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Formato_de_Invitacion' + rowIndex).val()==TryParseInt('4', '4') ) { $('#divFecha_de_Recepcion').css('display', 'block');$('#divFecha_de_Aceptacion').css('display', 'block');$('#divA_Tiempo').css('display', 'block');$('#divCumplimiento').css('display', 'block');$('#divIncidente').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Fecha_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Aceptacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Aceptacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "A_Tiempo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'A_Tiempo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Incidente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Incidente' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Aceptacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_Tiempo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cumplimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Incidente' + rowIndex));} else { $('#divFecha_de_Recepcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));$('#divFecha_de_Aceptacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Aceptacion' + rowIndex));$('#divA_Tiempo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'A_Tiempo' + rowIndex));$('#divCumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Cumplimiento' + rowIndex));$('#divIncidente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Incidente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Aceptacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_Tiempo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cumplimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Incidente' + rowIndex));}

}
//BusinessRuleId:1702, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1961, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1961, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1961, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1961, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1961, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1961, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2124, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Formato_de_Invitacion' + rowIndex).val();   $('#' + nameOfTable + 'Formato_de_Invitacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Formato_de_Invitacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Formato_de_Invitacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select * from Tipo_de_Invitacion where Descripcion NOT IN ('ENTREGADA POR POLICIAL', 'ENTREGADA POR POLICIA MINISTERIAL', 'ENTREGADA POR NOTIFICADOR')", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Formato_de_Invitacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select * from Tipo_de_Invitacion where Descripcion NOT IN ('ENTREGADA POR POLICIAL', 'ENTREGADA POR POLICIA MINISTERIAL', 'ENTREGADA POR NOTIFICADOR')", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Formato_de_Invitacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Formato_de_Invitacion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2124, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2160, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Domicilio' + rowIndex),EvaluaQuery(" exec uspGetDireccionUnidadMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));

}
//BusinessRuleId:2160, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;








//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1704, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Solicitudes_de_Invitaciones"
+" 	set Solicitud = GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:1704, Attribute:2, Operation:Object, Event:AFTERSAVING









//BusinessRuleId:2011, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Formato_de_Invitacion' + rowIndex).val()==TryParseInt('4', '4') ) { EvaluaQuery(" EXEC uspGeneraInvitacionMASC GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); SendEmailQuery('SAPROJ - Nueva Invitación por realizar', EvaluaQuery("select STUFF((		select ';' + Email + ''		from Spartan_User		where Role =104	for XML PATH('')	), 1, 1, '')"), "Por este medio le informamos que el área de <b>Mecanismos Alternos</b> le ha enviado una solicitud para realizar una invitación."
+" "
+" <br><br>Favor de ingresar al sistema para revisar la solicitud recibida.",rowIndex,nameOfTable);} else {}

}
//BusinessRuleId:2011, Attribute:2, Operation:Object, Event:AFTERSAVING



//NEWBUSINESSRULE_AFTERSAVING//
}



function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndex){ 
 var result= true; 


































//BusinessRuleId:1860, Attribute:266004, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'New'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()==TryParseInt('undefined', 'undefined') ) { alert(EvaluaQuery("Select 'Seleccione un registro'", rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:1860, Attribute:266004, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:1860, Attribute:266004, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()==TryParseInt('undefined', 'undefined') ) { alert(EvaluaQuery("Select 'Seleccione un registro'", rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:1860, Attribute:266004, Operation:Object, Event:BEFORESAVINGMR

//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitante_en_Invitaciones// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndex){ 




//BusinessRuleId:1860, Attribute:266004, Operation:Object, Event:AFTERSAVINGMR
if(operation == 'New'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex + ' option:selected').text()==EvaluaQuery("select 'Select'",rowIndex, nameOfTable) ) { alert(EvaluaQuery("Select 'Seleccione un registro'", rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:1860, Attribute:266004, Operation:Object, Event:AFTERSAVINGMR

//BusinessRuleId:1860, Attribute:266004, Operation:Object, Event:AFTERSAVINGMR
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex + ' option:selected').text()==EvaluaQuery("select 'Select'",rowIndex, nameOfTable) ) { alert(EvaluaQuery("Select 'Seleccione un registro'", rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:1860, Attribute:266004, Operation:Object, Event:AFTERSAVINGMR

//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitante_en_Invitaciones// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitante_en_Invitaciones// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndex){ 
 var result= true; 


//NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitante_en_Invitaciones// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitante_en_Invitaciones// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndex){ 
 var result= true; 
//BusinessRuleId:1861, Attribute:266005, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'New'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()==TryParseInt('undefined', 'undefined') ) { alert(DecodifyText('Debe seleccionar un registro', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:1861, Attribute:266005, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:1861, Attribute:266005, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()==TryParseInt('undefined', 'undefined') ) { alert(DecodifyText('Debe seleccionar un registro', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:1861, Attribute:266005, Operation:Object, Event:BEFORESAVINGMR

//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Requerido_en_Invitaciones// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Requerido_en_Invitaciones// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_de_Requerido_en_Invitaciones// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_de_Requerido_en_Invitaciones// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_de_Requerido_en_Invitaciones// 
 return result; 
} 
