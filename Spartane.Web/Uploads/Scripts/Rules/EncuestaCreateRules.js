var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {






















//BusinessRuleId:2616, Attribute:263924, Operation:Field, Event:None
$("form#CreateEncuesta").on('change', '#Numero_de_Preguntas', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)<TryParseInt('1', '1') ) { $('#divPregunta_1').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));$('#divPregunta_2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));$('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));$('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));$('#divPregunta_6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_6' + rowIndex));$('#divPregunta_7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_7' + rowIndex));$('#divPregunta_8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_8' + rowIndex));$('#divPregunta_9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_9' + rowIndex));$('#divPregunta_10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_10' + rowIndex));} else {}
});

//BusinessRuleId:2616, Attribute:263924, Operation:Field, Event:None



//BusinessRuleId:3100, Attribute:268254, Operation:Field, Event:None
$("form#CreateEncuesta").on('change', '#Modulo', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Tipo_Encuesta' + rowIndex).val();   $('#' + nameOfTable + 'Tipo_Encuesta' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tipo_Encuesta' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tipo_Encuesta' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Tipo_Encuesta WHERE Modulo_Encuesta = FLD[Modulo]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tipo_Encuesta' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Tipo_Encuesta WHERE Modulo_Encuesta = FLD[Modulo]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tipo_Encuesta' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tipo_Encuesta' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3100, Attribute:268254, Operation:Field, Event:None

//BusinessRuleId:484, Attribute:263924, Operation:Field, Event:None
$("form#CreateEncuesta").on('change', '#Numero_de_Preguntas', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divPregunta_1').css('display', 'block'); $('#divPregunta_2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex)); $('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex)); $('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex)); $('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); $('#divPregunta_6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_6' + rowIndex)); $('#divPregunta_7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_7' + rowIndex)); $('#divPregunta_8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_8' + rowIndex)); $('#divPregunta_9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_9' + rowIndex)); $('#divPregunta_10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_10' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); $('#divPregunta_2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));$('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));$('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}
});

//BusinessRuleId:484, Attribute:263924, Operation:Field, Event:None

//BusinessRuleId:485, Attribute:263924, Operation:Field, Event:None
$("form#CreateEncuesta").on('change', '#Numero_de_Preguntas', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divPregunta_1').css('display', 'block'); $('#divPregunta_2').css('display', 'block'); $('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex)); $('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex)); $('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); $('#divPregunta_6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_6' + rowIndex)); $('#divPregunta_7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_7' + rowIndex)); $('#divPregunta_8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_8' + rowIndex)); $('#divPregunta_9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_9' + rowIndex)); $('#divPregunta_10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_10' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}
});

//BusinessRuleId:485, Attribute:263924, Operation:Field, Event:None

//BusinessRuleId:486, Attribute:263924, Operation:Field, Event:None
$("form#CreateEncuesta").on('change', '#Numero_de_Preguntas', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $('#divPregunta_3').css('display', 'block'); $('#divPregunta_1').css('display', 'block'); $('#divPregunta_2').css('display', 'block'); $('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex)); $('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); $('#divPregunta_6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_6' + rowIndex)); $('#divPregunta_7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_7' + rowIndex)); $('#divPregunta_8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_8' + rowIndex)); $('#divPregunta_9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_9' + rowIndex)); $('#divPregunta_10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_10' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}
});

//BusinessRuleId:486, Attribute:263924, Operation:Field, Event:None

//BusinessRuleId:487, Attribute:263924, Operation:Field, Event:None
$("form#CreateEncuesta").on('change', '#Numero_de_Preguntas', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divPregunta_4').css('display', 'block'); $('#divPregunta_1').css('display', 'block'); $('#divPregunta_2').css('display', 'block'); $('#divPregunta_3').css('display', 'block'); $('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); $('#divPregunta_6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_6' + rowIndex)); $('#divPregunta_7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_7' + rowIndex)); $('#divPregunta_8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_8' + rowIndex)); $('#divPregunta_9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_9' + rowIndex)); $('#divPregunta_10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_10' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}
});

//BusinessRuleId:487, Attribute:263924, Operation:Field, Event:None

//BusinessRuleId:488, Attribute:263924, Operation:Field, Event:None
$("form#CreateEncuesta").on('change', '#Numero_de_Preguntas', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('5', '5') ) { $('#divPregunta_1').css('display', 'block'); $('#divPregunta_2').css('display', 'block'); $('#divPregunta_3').css('display', 'block'); $('#divPregunta_4').css('display', 'block'); $('#divPregunta_5').css('display', 'block'); $('#divPregunta_6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_6' + rowIndex)); $('#divPregunta_7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_7' + rowIndex)); $('#divPregunta_8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_8' + rowIndex)); $('#divPregunta_9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_9' + rowIndex)); $('#divPregunta_10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_10' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}
});

//BusinessRuleId:488, Attribute:263924, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:480, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divPregunta_1').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex)); $('#divPregunta_2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex)); $('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex)); $('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex)); $('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); $('#divPregunta_6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_6' + rowIndex)); $('#divPregunta_7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_7' + rowIndex)); $('#divPregunta_8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_8' + rowIndex)); $('#divPregunta_9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_9' + rowIndex)); $('#divPregunta_10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_10' + rowIndex));

}
//BusinessRuleId:480, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3101, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Modulo' + rowIndex).val();   $('#' + nameOfTable + 'Modulo' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Modulo' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Modulo' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Modulo_Encuesta WHERE Clave IN(1)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Modulo' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Modulo_Encuesta WHERE Clave IN(1)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Modulo' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Modulo' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3101, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3101, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Modulo' + rowIndex).val();   $('#' + nameOfTable + 'Modulo' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Modulo' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Modulo' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Modulo_Encuesta WHERE Clave IN(1)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Modulo' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Modulo_Encuesta WHERE Clave IN(1)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Modulo' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Modulo' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3101, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3101, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Modulo' + rowIndex).val();   $('#' + nameOfTable + 'Modulo' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Modulo' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Modulo' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Modulo_Encuesta WHERE Clave IN(1)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Modulo' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Modulo_Encuesta WHERE Clave IN(1)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Modulo' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Modulo' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3101, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3110, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divPregunta_1').css('display', 'block'); $('#divPregunta_2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));$('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));$('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3110, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3110, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divPregunta_1').css('display', 'block'); $('#divPregunta_2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));$('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));$('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3110, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3110, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divPregunta_1').css('display', 'block'); $('#divPregunta_2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));$('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));$('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3110, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3111, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block'); $('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));$('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3111, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3111, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block'); $('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));$('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3111, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3111, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block'); $('#divPregunta_3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));$('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3111, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3112, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block');$('#divPregunta_3').css('display', 'block'); $('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3112, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3112, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block');$('#divPregunta_3').css('display', 'block'); $('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3112, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3112, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block');$('#divPregunta_3').css('display', 'block'); $('#divPregunta_4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));$('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3112, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3113, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block');$('#divPregunta_3').css('display', 'block');$('#divPregunta_4').css('display', 'block'); $('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3113, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3113, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block');$('#divPregunta_3').css('display', 'block');$('#divPregunta_4').css('display', 'block'); $('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3113, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3113, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block');$('#divPregunta_3').css('display', 'block');$('#divPregunta_4').css('display', 'block'); $('#divPregunta_5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3113, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3114, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('5', '5') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block');$('#divPregunta_3').css('display', 'block');$('#divPregunta_4').css('display', 'block');$('#divPregunta_5').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3114, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3114, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('5', '5') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block');$('#divPregunta_3').css('display', 'block');$('#divPregunta_4').css('display', 'block');$('#divPregunta_5').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3114, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3114, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),nameOfTable,rowIndex)==TryParseInt('5', '5') ) { $('#divPregunta_1').css('display', 'block');$('#divPregunta_2').css('display', 'block');$('#divPregunta_3').css('display', 'block');$('#divPregunta_4').css('display', 'block');$('#divPregunta_5').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_1' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_2' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_3' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_4' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Pregunta_5' + rowIndex));} else {}

}
//BusinessRuleId:3114, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//BusinessRuleId:517, Attribute:0, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
 CreateSessionVar('varpreguntas', EvaluaQuery("SELECT [Numero_de_Preguntas]", rowIndex, nameOfTable));

}
//BusinessRuleId:517, Attribute:0, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:517, Attribute:0, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
 CreateSessionVar('varpreguntas', EvaluaQuery("SELECT [Numero_de_Preguntas]", rowIndex, nameOfTable));

}
//BusinessRuleId:517, Attribute:0, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:3103, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("SELECT Valor= COUNT(*) FROM dbo.Encuesta WHERE Modulo = FLD[Modulo] AND Tipo_Encuesta = FLD[Tipo_Encuesta]",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText(' Ya existe una encuesta para el Modulo y Tipo de Encuesta seleccionados, favor de verificar.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3103, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:3104, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("SELECT Valor= COUNT(*) FROM dbo.Encuesta WHERE Modulo = FLD[Modulo] AND Tipo_Encuesta = FLD[Tipo_Encuesta] AND Clave <> FLDD[lblClave]",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText('Ya existe una encuesta para el Modulo y Tipo de Encuesta seleccionados, favor de verificar.', rowIndex, nameOfTable));} else {}

}
//BusinessRuleId:3104, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//NEWBUSINESSRULE_AFTERSAVING//
}


