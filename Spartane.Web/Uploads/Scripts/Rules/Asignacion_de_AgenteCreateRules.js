var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$('#Asignacion_de_AgenteGuardarYNuevo').hide();
$('#Asignacion_de_AgenteGuardarYCopia').hide();
if(operation == 'Update'){
	$('#Asignacion_de_AgenteGuardar').hide();
}
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {


//BusinessRuleId:2554, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex),EvaluaQuery("select name from Spartan_User where Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2554, Attribute:0, Operation:Object, Event:SCREENOPENING























//BusinessRuleId:2608, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2608, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2608, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2608, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2608, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2608, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:2871, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));}DisabledControl($("#" + nameOfTable + "Agente_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Agente_Asignado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}

}
//BusinessRuleId:2871, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3893, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt('17', '17')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { var valor = $('#' + nameOfTable + 'Agente_Asignado' + rowIndex).val();   $('#' + nameOfTable + 'Agente_Asignado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Agente_Asignado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Agente_Asignado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("EXEC usp_GetAgentesActivosFromUnidadDelUsuario GLOBAL[USERID]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Agente_Asignado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("EXEC usp_GetAgentesActivosFromUnidadDelUsuario GLOBAL[USERID]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Agente_Asignado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Agente_Asignado' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3893, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:2555, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("update Asignacion_de_Agente set expediente_mp = GLOBAL[SpartanOperationId] where clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2555, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2870, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" exec uspAsignaMP GLOBAL[SpartanOperationId] , FLD[Agente_Asignado]", rowIndex, nameOfTable);

}
//BusinessRuleId:2870, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


