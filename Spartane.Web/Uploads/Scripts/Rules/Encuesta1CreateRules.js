var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//BusinessRuleId:563, Attribute:264367, Operation:Field, Event:None
$("form#CreateEncuesta1").on('keyup', '#NUAT', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'NUAT' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("select count(*) from Encuesta1 where NUAT='FLD[NUAT]'",rowIndex, nameOfTable)>=TryParseInt('1', '1') ) { alert(DecodifyText('Este NUAT ya tiene una encuesta relacionada.', rowIndex, nameOfTable));
result=false;} else {}
});

//BusinessRuleId:563, Attribute:264367, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:499, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex),EvaluaQuery("select Numero_de_Preguntas from encuesta where clave=1", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Numero_de_Preguntas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Preguntas' + rowIndex));}

}
//BusinessRuleId:499, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:503, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta2' + rowIndex)); $('#divPregunta3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta3' + rowIndex)); $('#divPregunta4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta4' + rowIndex)); $('#divPregunta5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta5' + rowIndex)); $('#divPregunta6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta6' + rowIndex)); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:503, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:503, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta2' + rowIndex)); $('#divPregunta3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta3' + rowIndex)); $('#divPregunta4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta4' + rowIndex)); $('#divPregunta5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta5' + rowIndex)); $('#divPregunta6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta6' + rowIndex)); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:503, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:519, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('2', '2') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta3' + rowIndex)); $('#divPregunta4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta4' + rowIndex)); $('#divPregunta5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta5' + rowIndex)); $('#divPregunta6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta6' + rowIndex)); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:519, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:519, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('2', '2') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta3' + rowIndex)); $('#divPregunta4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta4' + rowIndex)); $('#divPregunta5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta5' + rowIndex)); $('#divPregunta6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta6' + rowIndex)); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:519, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:520, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('3', '3') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta4' + rowIndex)); $('#divPregunta5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta5' + rowIndex)); $('#divPregunta6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta6' + rowIndex)); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:520, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:520, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('3', '3') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta4' + rowIndex)); $('#divPregunta5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta5' + rowIndex)); $('#divPregunta6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta6' + rowIndex)); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:520, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:521, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta5' + rowIndex)); $('#divPregunta6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta6' + rowIndex)); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:521, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:521, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta5' + rowIndex)); $('#divPregunta6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta6' + rowIndex)); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:521, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:522, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('5', '5') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta6' + rowIndex)); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:522, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:522, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('5', '5') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta6' + rowIndex)); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:522, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:523, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('6', '6') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'block'); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:523, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:523, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('6', '6') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'block'); $('#divPregunta7').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta7' + rowIndex)); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:523, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:524, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('7', '7') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'block'); $('#divPregunta7').css('display', 'block'); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:524, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:524, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('7', '7') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'block'); $('#divPregunta7').css('display', 'block'); $('#divPregunta8').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta8' + rowIndex)); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:524, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:525, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('8', '8') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'block'); $('#divPregunta7').css('display', 'block'); $('#divPregunta8').css('display', 'block'); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:525, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:525, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('8', '8') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'block'); $('#divPregunta7').css('display', 'block'); $('#divPregunta8').css('display', 'block'); $('#divPregunta9').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta9' + rowIndex)); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:525, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:526, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('9', '9') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'block'); $('#divPregunta7').css('display', 'block'); $('#divPregunta8').css('display', 'block'); $('#divPregunta9').css('display', 'block'); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:526, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:526, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('9', '9') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'block'); $('#divPregunta7').css('display', 'block'); $('#divPregunta8').css('display', 'block'); $('#divPregunta9').css('display', 'block'); $('#divPregunta10').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pregunta10' + rowIndex));} else {}

}
//BusinessRuleId:526, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:527, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('10', '10') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'block'); $('#divPregunta7').css('display', 'block'); $('#divPregunta8').css('display', 'block'); $('#divPregunta9').css('display', 'block'); $('#divPregunta10').css('display', 'block');} else {}

}
//BusinessRuleId:527, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:527, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[varpreguntas]'",rowIndex, nameOfTable)==TryParseInt('10', '10') ) { $('#divPregunta1').css('display', 'block'); $('#divPregunta2').css('display', 'block'); $('#divPregunta3').css('display', 'block'); $('#divPregunta4').css('display', 'block'); $('#divPregunta5').css('display', 'block'); $('#divPregunta6').css('display', 'block'); $('#divPregunta7').css('display', 'block'); $('#divPregunta8').css('display', 'block'); $('#divPregunta9').css('display', 'block'); $('#divPregunta10').css('display', 'block');} else {}

}
//BusinessRuleId:527, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2540, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:2540, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2540, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:2540, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2540, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));

}
//BusinessRuleId:2540, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:500, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta1' + rowIndex),EvaluaQuery("SELECT Pregunta_1 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:500, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:500, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta1' + rowIndex),EvaluaQuery("SELECT Pregunta_1 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:500, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:500, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta1' + rowIndex),EvaluaQuery("SELECT Pregunta_1 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:500, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:501, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta2' + rowIndex),EvaluaQuery("SELECT Pregunta_2 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:501, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:501, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta2' + rowIndex),EvaluaQuery("SELECT Pregunta_2 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:501, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:501, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta2' + rowIndex),EvaluaQuery("SELECT Pregunta_2 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:501, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:502, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta3' + rowIndex),EvaluaQuery(" SELECT Pregunta_3 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:502, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:502, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta3' + rowIndex),EvaluaQuery(" SELECT Pregunta_3 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:502, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:502, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta3' + rowIndex),EvaluaQuery(" SELECT Pregunta_3 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:502, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:529, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta4' + rowIndex),EvaluaQuery(" SELECT Pregunta_4 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:529, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:529, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta4' + rowIndex),EvaluaQuery(" SELECT Pregunta_4 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:529, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:529, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta4' + rowIndex),EvaluaQuery(" SELECT Pregunta_4 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:529, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:530, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta5' + rowIndex),EvaluaQuery(" SELECT Pregunta_5 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:530, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:530, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta5' + rowIndex),EvaluaQuery(" SELECT Pregunta_5 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:530, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:530, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta5' + rowIndex),EvaluaQuery(" SELECT Pregunta_5 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:530, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:531, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta6' + rowIndex),EvaluaQuery(" SELECT Pregunta_6 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:531, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:531, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta6' + rowIndex),EvaluaQuery(" SELECT Pregunta_6 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:531, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:531, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta6' + rowIndex),EvaluaQuery(" SELECT Pregunta_6 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:531, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:532, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta7' + rowIndex),EvaluaQuery(" SELECT Pregunta_7 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:532, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:532, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta7' + rowIndex),EvaluaQuery(" SELECT Pregunta_7 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:532, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:532, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta7' + rowIndex),EvaluaQuery(" SELECT Pregunta_7 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:532, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:534, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta8' + rowIndex),EvaluaQuery(" SELECT Pregunta_8 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:534, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:534, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta8' + rowIndex),EvaluaQuery(" SELECT Pregunta_8 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:534, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:534, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta8' + rowIndex),EvaluaQuery(" SELECT Pregunta_8 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:534, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:535, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta9' + rowIndex),EvaluaQuery(" SELECT Pregunta_9 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:535, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:535, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta9' + rowIndex),EvaluaQuery(" SELECT Pregunta_9 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:535, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:535, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta9' + rowIndex),EvaluaQuery(" SELECT Pregunta_9 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:535, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:536, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta9' + rowIndex),EvaluaQuery("SELECT Pregunta_9 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:536, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:536, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta9' + rowIndex),EvaluaQuery("SELECT Pregunta_9 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:536, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:536, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta9' + rowIndex),EvaluaQuery("SELECT Pregunta_9 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:536, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:537, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pregunta10' + rowIndex),EvaluaQuery(" SELECT Pregunta_10 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:537, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:537, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pregunta10' + rowIndex),EvaluaQuery(" SELECT Pregunta_10 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:537, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:537, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pregunta10' + rowIndex),EvaluaQuery(" SELECT Pregunta_10 FROM Encuesta WHERE Clave = 1", rowIndex, nameOfTable));

}
//BusinessRuleId:537, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//NEWBUSINESSRULE_AFTERSAVING//
}


