var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:1724, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));

}
//BusinessRuleId:1724, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1744, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));

}
//BusinessRuleId:1744, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));

}
//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));

}
//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));

}
//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2166, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); $('#divDelito').css('display', 'block');} else { $('#divDelito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}

}
//BusinessRuleId:2166, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2166, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); $('#divDelito').css('display', 'block');} else { $('#divDelito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}

}
//BusinessRuleId:2166, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2167, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]"
+" ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]"
+" ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); $('#divInvolucrado').css('display', 'block');} else { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}

}
//BusinessRuleId:2167, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2167, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]"
+" ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]"
+" ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); $('#divInvolucrado').css('display', 'block');} else { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}

}
//BusinessRuleId:2167, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2169, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, Nombre_Completo_Detenido FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, Nombre_Completo_Detenido FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); $('#divProbable_Responsable').css('display', 'block');} else { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}

}
//BusinessRuleId:2169, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2169, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, Nombre_Completo_Detenido FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, Nombre_Completo_Detenido FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); $('#divProbable_Responsable').css('display', 'block');} else { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}

}
//BusinessRuleId:2169, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2174, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex),EvaluaQuery(" SELECT NUAT from Modulo_Atencion_Inicial where Clave = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));

}
//BusinessRuleId:2174, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1733, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Relaciones"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:1733, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


