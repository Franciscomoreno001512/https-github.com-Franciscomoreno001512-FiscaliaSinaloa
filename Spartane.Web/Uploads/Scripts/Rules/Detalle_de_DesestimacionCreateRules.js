var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {

//CONVERTIR A MAYUSCULAS AL BLUR
$('input[type="text"],textarea').blur(function() {
	this.value = this.value.toUpperCase();
	});
//END CONVERTIR A MAYUSCULAS AL BLUR

//BusinessRuleId:2818, Attribute:264916, Operation:Field, Event:None
$("form#CreateDetalle_de_Desestimacion").on('change', '#Causal_de_Interrupcion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Causal_de_Interrupcion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { DisabledControl($("#" + nameOfTable + "Causa_de_Interrupcion" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Datos_Insuficientes" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));}DisabledControl($("#" + nameOfTable + "Actualizacion_de_Sobreseimiento" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));}} else {}
});


//BusinessRuleId:2818, Attribute:264916, Operation:Field, Event:None

//BusinessRuleId:2817, Attribute:264916, Operation:Field, Event:None
$("form#CreateDetalle_de_Desestimacion").on('change', '#Causal_de_Interrupcion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Causal_de_Interrupcion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { DisabledControl($("#" + nameOfTable + "Causa_de_Interrupcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Datos_Insuficientes" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));}DisabledControl($("#" + nameOfTable + "Actualizacion_de_Sobreseimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));} AsignarValor($('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex),' ');AsignarValor($('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex),' ');AsignarValor($('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex),' ');} else {}
});


//BusinessRuleId:2817, Attribute:264916, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:1727, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));


}
//BusinessRuleId:1727, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1749, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1748, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1748, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causal_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));


}
//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causal_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));


}
//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causal_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));


}
//BusinessRuleId:1986, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2236, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex),EvaluaQuery("SELECT NUAT FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));


}
//BusinessRuleId:2236, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2314, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_Completo' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).val(valor).trigger('change'); $('#divNombre_Completo').css('display', 'block');} else { $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}


}
//BusinessRuleId:2314, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2314, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_Completo' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_Completo' + rowIndex).val(valor).trigger('change'); $('#divNombre_Completo').css('display', 'block');} else { $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}


}
//BusinessRuleId:2314, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1736, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Desestimacion"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:1736, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2601, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("exec sp_Desestimar_desde_AtencionInicial FLD[Modulo_Atencion_Inicial]", rowIndex, nameOfTable);


}
//BusinessRuleId:2601, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2601, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("exec sp_Desestimar_desde_AtencionInicial FLD[Modulo_Atencion_Inicial]", rowIndex, nameOfTable);


}
//BusinessRuleId:2601, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


