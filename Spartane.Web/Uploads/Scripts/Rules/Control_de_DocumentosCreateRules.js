var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$('#Control_de_DocumentosGuardarYCopia').hide();
$('#Control_de_DocumentosGuardarYNuevo').hide();
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2029, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "idFormato" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'idFormato' + rowIndex));}DisabledControl($("#" + nameOfTable + "LlaveRegistro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'LlaveRegistro' + rowIndex));}DisabledControl($("#" + nameOfTable + "TablaPersona" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'TablaPersona' + rowIndex));}DisabledControl($("#" + nameOfTable + "LlaveRegistroPersona" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'LlaveRegistroPersona' + rowIndex));}

}
//BusinessRuleId:2029, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2029, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "idFormato" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'idFormato' + rowIndex));}DisabledControl($("#" + nameOfTable + "LlaveRegistro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'LlaveRegistro' + rowIndex));}DisabledControl($("#" + nameOfTable + "TablaPersona" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'TablaPersona' + rowIndex));}DisabledControl($("#" + nameOfTable + "LlaveRegistroPersona" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'LlaveRegistroPersona' + rowIndex));}

}
//BusinessRuleId:2029, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2030, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Encabezado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pie_de_Pagina' + rowIndex));

}
//BusinessRuleId:2030, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2030, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Encabezado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pie_de_Pagina' + rowIndex));

}
//BusinessRuleId:2030, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:2031, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divProceso').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Proceso' + rowIndex));$('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:2031, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2031, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divProceso').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Proceso' + rowIndex));$('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:2031, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2035, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery("select GLOBAL[USERID]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));

}
//BusinessRuleId:2035, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2032, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $("a[href='#tabDatos_Generales']").css('display', 'none');
}
//BusinessRuleId:2032, Attribute:0, Operation:Object, Event:SCREENOPENING
// Regla manual para hacer que aparezca activa la pestaña de Documentos
if(operation == 'New' || operation == 'Update'){
 $("#viewmodeledit .tabs-container ul li:nth-child(2)").addClass("active");
 $("#viewmodeledit .tabs-container .tab-content .tab-pane").removeClass("active");
 $("#viewmodeledit .tabs-container .tab-content #tabDocumento").addClass("active");
}
//BusinessRuleId:2032, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $("a[href='#tabDatos_Generales']").css('display', 'none');

}
//BusinessRuleId:2032, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){










































//BusinessRuleId:2041, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("EXEC usp_InsertHistorialControlDeDocumentos FLDD[lblFolio], GLOBAL[USERID]", rowIndex, nameOfTable);

}
//BusinessRuleId:2041, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2046, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" EXEC usp_InsertHistorialControlDeDocumentos GLOBAL[KeyValueInserted], GLOBAL[USERID]", rowIndex, nameOfTable);

}
//BusinessRuleId:2046, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Historial_Control_de_Documentos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Historial_Control_de_Documentos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Historial_Control_de_Documentos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Historial_Control_de_Documentos//
}
function EjecutarValidacionesAlEliminarMRDetalle_Historial_Control_de_Documentos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Historial_Control_de_Documentos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Historial_Control_de_Documentos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Historial_Control_de_Documentos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Historial_Control_de_Documentos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Historial_Control_de_Documentos//
    return result;
}

