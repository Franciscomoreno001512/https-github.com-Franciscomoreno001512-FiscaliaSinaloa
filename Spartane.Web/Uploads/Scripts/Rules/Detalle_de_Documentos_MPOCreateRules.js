var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {

//BusinessRuleId:2024, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)"
+" ", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery("select name from spartan_user where id_user = GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:2024, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}


}
//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}


}
//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}


}
//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));

}
//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));

}
//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));

}
//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2156, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));

}
//BusinessRuleId:2156, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2156, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));

}
//BusinessRuleId:2156, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1735, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Documentos_MPO"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:1735, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}



function EjecutarValidacionesAntesDeGuardarMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Involucrados_en_Documentos// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Involucrados_en_Documentos// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_Involucrados_en_Documentos// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_Involucrados_en_Documentos// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_Involucrados_en_Documentos// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Probable_Responsable_de_Documentos// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Probable_Responsable_de_Documentos// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_Probable_Responsable_de_Documentos// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_Probable_Responsable_de_Documentos// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_Probable_Responsable_de_Documentos// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Delitos_de_Documentos// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Delitos_de_Documentos// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_Delitos_de_Documentos// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_Delitos_de_Documentos// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_Delitos_de_Documentos// 
 return result; 
} 
