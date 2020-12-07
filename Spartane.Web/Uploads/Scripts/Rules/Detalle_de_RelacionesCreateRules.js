var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//BusinessRuleId:2443, Attribute:265760, Operation:Field, Event:None
$("form#CreateDetalle_de_Relaciones").on('change', '#Es_Familiar', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Es_Familiar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divParentesco').css('display', 'block');} else { $('#divParentesco').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));}
});

//BusinessRuleId:2443, Attribute:265760, Operation:Field, Event:None

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













//BusinessRuleId:2174, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex),EvaluaQuery(" SELECT NUAT from Modulo_Atencion_Inicial where Clave = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));

}
//BusinessRuleId:2174, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2444, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divParentesco').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));

}
//BusinessRuleId:2444, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2445, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Es_Familiar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divParentesco').css('display', 'block');} else { $('#divParentesco').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));}

}
//BusinessRuleId:2445, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2445, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Es_Familiar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divParentesco').css('display', 'block');} else { $('#divParentesco').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));}

}
//BusinessRuleId:2445, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2553, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));

}
//BusinessRuleId:2553, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { $('#divInvolucrado').css('display', 'block');$('#divProbable_Responsable').css('display', 'block');$('#divDelito').css('display', 'block');} else {}

}
//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { $('#divInvolucrado').css('display', 'block');$('#divProbable_Responsable').css('display', 'block');$('#divDelito').css('display', 'block');} else {}

}
//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { $('#divInvolucrado').css('display', 'block');$('#divProbable_Responsable').css('display', 'block');$('#divDelito').css('display', 'block');} else {}

}
//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2632, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd"
+" 	inner join Delito d on ddd.Delito = d.Clave"
+" 	where ddd.Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd"
+" 	inner join Delito d on ddd.Delito = d.Clave"
+" 	where ddd.Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:2632, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2632, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd"
+" 	inner join Delito d on ddd.Delito = d.Clave"
+" 	where ddd.Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd"
+" 	inner join Delito d on ddd.Delito = d.Clave"
+" 	where ddd.Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:2632, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2169, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, Nombre_Completo_Detenido FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, Nombre_Completo_Detenido FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); $('#divProbable_Responsable').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));} else { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}

}
//BusinessRuleId:2169, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2169, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, Nombre_Completo_Detenido FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, Nombre_Completo_Detenido FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); $('#divProbable_Responsable').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));} else { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}

}
//BusinessRuleId:2169, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2167, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]"
+" ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]"
+" ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); $('#divInvolucrado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));} else { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}

}
//BusinessRuleId:2167, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2167, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]"
+" ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]"
+" ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); $('#divInvolucrado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));} else { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}

}
//BusinessRuleId:2167, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2166, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); $('#divDelito').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));} else { $('#divDelito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}

}
//BusinessRuleId:2166, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2166, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); $('#divDelito').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));} else { $('#divDelito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}

}
//BusinessRuleId:2166, Attribute:0, Operation:Object, Event:SCREENOPENING

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





//BusinessRuleId:2517, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Detalle_de_Relaciones set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:2517, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2517, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Detalle_de_Relaciones set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:2517, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


