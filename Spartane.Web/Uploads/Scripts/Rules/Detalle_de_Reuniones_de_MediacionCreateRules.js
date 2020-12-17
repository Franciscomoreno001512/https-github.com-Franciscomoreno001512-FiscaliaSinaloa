var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$('#Detalle_de_Reuniones_de_MediacionGuardarYNuevo').hide()
$('#Detalle_de_Reuniones_de_MediacionGuardarYCopia').hide()
$(document).ready(function () {




//BusinessRuleId:1925, Attribute:263429, Operation:Field, Event:None
$("form#CreateDetalle_de_Reuniones_de_Mediacion").on('change', '#Fecha', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select datediff(day, getdate(), convert(date,'FLD[Fecha]',105))	",rowIndex, nameOfTable)<TryParseInt('0', '0') ) { alert(DecodifyText('La fecha de la reunión no puede ser menor al día de hoy', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha' + rowIndex),EvaluaQuery(" select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable));} else {}
});


//BusinessRuleId:1925, Attribute:263429, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {

debugger;




























//BusinessRuleId:1698, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery("select name from spartan_user where id_user=GLOBAL[USERID]", rowIndex, nameOfTable)); $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Especialista' + rowIndex),EvaluaQuery("select name from spartan_user where id_user=GLOBAL[USERID]", rowIndex, nameOfTable)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));


}
//BusinessRuleId:1698, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1694, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Numero_de_Expediente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); var valor = $('#' + nameOfTable + 'Especialista' + rowIndex).val();   $('#' + nameOfTable + 'Especialista' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Especialista' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Especialista' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Id_User, Name from Spartan_User where Role=3", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Especialista' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Id_User, Name from Spartan_User where Role=3", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Especialista' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Especialista' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:1694, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1694, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Numero_de_Expediente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); var valor = $('#' + nameOfTable + 'Especialista' + rowIndex).val();   $('#' + nameOfTable + 'Especialista' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Especialista' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Especialista' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Id_User, Name from Spartan_User where Role=3", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Especialista' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Id_User, Name from Spartan_User where Role=3", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Especialista' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Especialista' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:1694, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1942, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Especialista' + rowIndex),EvaluaQuery(" select name from spartan_user where id_user=GLOBAL[USERID]	", rowIndex, nameOfTable));


}
//BusinessRuleId:1942, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1962, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));


}
//BusinessRuleId:1962, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1962, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));


}
//BusinessRuleId:1962, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1962, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));


}
//BusinessRuleId:1962, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2161, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Lugar' + rowIndex),EvaluaQuery(" exec uspGetDireccionUnidadMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));


}
//BusinessRuleId:2161, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2164, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cumplimiento' + rowIndex));


}
//BusinessRuleId:2164, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2164, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cumplimiento' + rowIndex));


}
//BusinessRuleId:2164, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2164, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cumplimiento' + rowIndex));


}
//BusinessRuleId:2164, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2165, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
	debugger;
    fillMRFromQuery('Detalle_de_Solicitante_en_Reuniones', "exec uspLlenaSolicitantesReunion GLOBAL[SpartanOperationId]"); fillMRFromQuery('Detalle_de_Requerido_en_Reuniones', "exec uspLlenaRequeridosReunion GLOBAL[SpartanOperationId]");


}
//BusinessRuleId:2165, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2453, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divCumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Cumplimiento' + rowIndex));

}
//BusinessRuleId:2453, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;




//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){


//BusinessRuleId:1699, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("update Detalle_de_Reuniones_de_Mediacion"
+" 	   set Numero_de_Expediente= GLOBAL[SpartanOperationId] "
+" 	   where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:1699, Attribute:2, Operation:Object, Event:AFTERSAVING



//BusinessRuleId:2168, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("exec uspGeneraCitaReunion GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:2168, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2170, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("exec uspGeneraCitaReunion FLDD[lblClave]", rowIndex, nameOfTable);


}
//BusinessRuleId:2170, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2998, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('101', '101') ) { EvaluaQuery(" uspAsignarFacilitador GLOBAL[SpartanOperationId],GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:2998, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}



function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requerido_en_Reuniones(nameOfTable, rowIndex){ 
 var result= true; 
//BusinessRuleId:1892, Attribute:265983, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'New'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()==TryParseInt('undefined', 'undefined') ) { alert(DecodifyText('¡Favor a Seleccionar un Nombre!', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:1892, Attribute:265983, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:1892, Attribute:265983, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()==TryParseInt('undefined', 'undefined') ) { alert(DecodifyText('¡Favor a Seleccionar un Nombre!', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:1892, Attribute:265983, Operation:Object, Event:BEFORESAVINGMR

//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Requerido_en_Reuniones// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Requerido_en_Reuniones(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Requerido_en_Reuniones// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_de_Requerido_en_Reuniones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_de_Requerido_en_Reuniones// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_de_Requerido_en_Reuniones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_de_Requerido_en_Reuniones// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_de_Requerido_en_Reuniones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_de_Requerido_en_Reuniones// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Reuniones(nameOfTable, rowIndex){ 
 var result= true; 




//BusinessRuleId:1890, Attribute:265982, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'New'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()==TryParseInt('undefined', 'undefined') ) { alert(DecodifyText('Favor a seleccionar un valor. ', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:1890, Attribute:265982, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:1890, Attribute:265982, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()==TryParseInt('undefined', 'undefined') ) { alert(DecodifyText('Favor a seleccionar un valor. ', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:1890, Attribute:265982, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:1890, Attribute:265982, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'New'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()==TryParseInt('undefined', 'undefined') ) { alert(DecodifyText('¡Favor a seleccionar un Nombre!', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:1890, Attribute:265982, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:1890, Attribute:265982, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Nombre' + rowIndex).val()==TryParseInt('undefined', 'undefined') ) { alert(DecodifyText('¡Favor a seleccionar un Nombre!', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:1890, Attribute:265982, Operation:Object, Event:BEFORESAVINGMR

//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitante_en_Reuniones// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_en_Reuniones(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitante_en_Reuniones// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitante_en_Reuniones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitante_en_Reuniones// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_de_Solicitante_en_Reuniones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitante_en_Reuniones// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_de_Solicitante_en_Reuniones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitante_en_Reuniones// 
 return result; 
} 
