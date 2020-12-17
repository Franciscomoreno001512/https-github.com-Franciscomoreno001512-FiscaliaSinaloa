var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;

$("#Resolucion_MPGuardarYNuevo").hide();
$('#Resolucion_MPGuardarYCopia').hide();


$(document).ready(function () {




//BusinessRuleId:2978, Attribute:268502, Operation:Field, Event:None
$("form#CreateResolucion_MP").on('change', '#Resolucion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divJuzgado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));$('#divTipo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));$('#divNo__De_Causa_o_Cuadernillo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'No__De_Causa_o_Cuadernillo' + rowIndex));$('#divAno_de_Causa_o_Cuadernillo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ano_de_Causa_o_Cuadernillo' + rowIndex));} else { $('#divJuzgado').css('display', 'block');$('#divTipo').css('display', 'block');$('#divNo__De_Causa_o_Cuadernillo').css('display', 'block');$('#divAno_de_Causa_o_Cuadernillo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'No__De_Causa_o_Cuadernillo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Ano_de_Causa_o_Cuadernillo' + rowIndex));}
});

//BusinessRuleId:2978, Attribute:268502, Operation:Field, Event:None

//BusinessRuleId:2993, Attribute:268516, Operation:Field, Event:None
$("form#CreateResolucion_MP").on('change', '#Resultado_de_Validacion', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Tipo from resolucion where Clave = FLD[Resultado_de_Validacion]",rowIndex, nameOfTable)==TryParseInt('3', '3') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'2');} else {}
});

//BusinessRuleId:2993, Attribute:268516, Operation:Field, Event:None

//BusinessRuleId:2994, Attribute:268516, Operation:Field, Event:None
$("form#CreateResolucion_MP").on('change', '#Resultado_de_Validacion', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Tipo from resolucion where Clave = FLD[Resultado_de_Validacion]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'3');} else {}
});

//BusinessRuleId:2994, Attribute:268516, Operation:Field, Event:None




// if(operation == 'Update'){
	// debugger;
	// CambiarAConsulta();
// }

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
















//BusinessRuleId:2977, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divJuzgado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));$('#divTipo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));$('#divNo__De_Causa_o_Cuadernillo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'No__De_Causa_o_Cuadernillo' + rowIndex));$('#divAno_de_Causa_o_Cuadernillo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ano_de_Causa_o_Cuadernillo' + rowIndex));} else { $('#divJuzgado').css('display', 'block');$('#divTipo').css('display', 'block');$('#divNo__De_Causa_o_Cuadernillo').css('display', 'block');$('#divAno_de_Causa_o_Cuadernillo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'No__De_Causa_o_Cuadernillo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Ano_de_Causa_o_Cuadernillo' + rowIndex));}

}
//BusinessRuleId:2977, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2977, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divJuzgado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));$('#divTipo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));$('#divNo__De_Causa_o_Cuadernillo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'No__De_Causa_o_Cuadernillo' + rowIndex));$('#divAno_de_Causa_o_Cuadernillo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ano_de_Causa_o_Cuadernillo' + rowIndex));} else { $('#divJuzgado').css('display', 'block');$('#divTipo').css('display', 'block');$('#divNo__De_Causa_o_Cuadernillo').css('display', 'block');$('#divAno_de_Causa_o_Cuadernillo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'No__De_Causa_o_Cuadernillo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Ano_de_Causa_o_Cuadernillo' + rowIndex));}

}
//BusinessRuleId:2977, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2977, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divJuzgado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));$('#divTipo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));$('#divNo__De_Causa_o_Cuadernillo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'No__De_Causa_o_Cuadernillo' + rowIndex));$('#divAno_de_Causa_o_Cuadernillo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ano_de_Causa_o_Cuadernillo' + rowIndex));} else { $('#divJuzgado').css('display', 'block');$('#divTipo').css('display', 'block');$('#divNo__De_Causa_o_Cuadernillo').css('display', 'block');$('#divAno_de_Causa_o_Cuadernillo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'No__De_Causa_o_Cuadernillo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Ano_de_Causa_o_Cuadernillo' + rowIndex));}

}
//BusinessRuleId:2977, Attribute:0, Operation:Object, Event:SCREENOPENING



































//BusinessRuleId:2980, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('#dividRelacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRelacion' + rowIndex)); $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2980, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2980, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('#dividRelacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRelacion' + rowIndex)); $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2980, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2980, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('#dividRelacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRelacion' + rowIndex)); $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2980, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2963, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_que_Resuelve" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Dictaminador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dictaminador' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Dictaminador' + rowIndex));

}
//BusinessRuleId:2963, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2963, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_que_Resuelve" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Dictaminador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dictaminador' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Dictaminador' + rowIndex));

}
//BusinessRuleId:2963, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2963, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_que_Resuelve" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Dictaminador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dictaminador' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Dictaminador' + rowIndex));

}
//BusinessRuleId:2963, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion where Tipo in (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion where Tipo in (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2988, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion where Tipo in (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion where Tipo in (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2988, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2989, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).val();   $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion where Resolucion_Padre_para_Autorizacion =FLD[Resolucion]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Resolucion where Resolucion_Padre_para_Autorizacion =FLD[Resolucion]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2989, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2968, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex),EvaluaQuery("select name from Spartan_User where Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Dictaminador' + rowIndex),EvaluaQuery("select name from Spartan_User where Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); $("a[href='#tabValidacion']").css('display', 'none');

}
//BusinessRuleId:2968, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2987, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('107', '107')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $("a[href='#tabValidacion']").css('display', 'block'); DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_que_Resuelve" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Juzgado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));}DisabledControl($("#" + nameOfTable + "No__De_Causa_o_Cuadernillo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'No__De_Causa_o_Cuadernillo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ano_de_Causa_o_Cuadernillo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ano_de_Causa_o_Cuadernillo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));} AsignarValor($('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Dictaminador' + rowIndex),EvaluaQuery(" select name from Spartan_User where Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));} else {}

}
//BusinessRuleId:2987, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2974, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { SetRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Resultado_de_Validacion" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex));}} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex));}

}
//BusinessRuleId:2974, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2974, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { SetRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Resultado_de_Validacion" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex));}} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex));}

}
//BusinessRuleId:2974, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//BusinessRuleId:2981, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[False]'",rowIndex, nameOfTable)==EvaluaQuery("1",rowIndex, nameOfTable) ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'1');} else {}

}
//BusinessRuleId:2981, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){


//BusinessRuleId:2976, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update resolucion_mp set expediente_mp=GLOBAL[SpartanOperationId] where clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:2976, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Vinculacion_Resolucion(nameOfTable, rowIndex){
    var result = true;
    











//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:BEFORESAVINGMR

//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Vinculacion_Resolucion//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Vinculacion_Resolucion(nameOfTable, rowIndex){
    











//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:AFTERSAVINGMR
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:AFTERSAVINGMR

//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:AFTERSAVINGMR
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:AFTERSAVINGMR

//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:AFTERSAVINGMR
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:AFTERSAVINGMR

//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Vinculacion_Resolucion//
}
function EjecutarValidacionesAlEliminarMRDetalle_Vinculacion_Resolucion(nameOfTable, rowIndex){
    var result = true;
    











//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:DELETEMR
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:DELETEMR

//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:DELETEMR
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:DELETEMR

//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:DELETEMR
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:DELETEMR

//NEWBUSINESSRULE_DELETEMR_Detalle_Vinculacion_Resolucion//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Vinculacion_Resolucion(nameOfTable, rowIndex){
    var result = true;
    











//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:NEWROWMR
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Vinculacion_Resolucion//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Vinculacion_Resolucion(nameOfTable, rowIndex){
    var result = true;
    











//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:EDITROWMR
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));} $('.idRelacionHeader').css('display', 'none');
var index = $('.idRelacionHeader').index();
 eval($('.idRelacionHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

}
//BusinessRuleId:2979, Attribute:268503, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Vinculacion_Resolucion//
    return result;
}







window.onload=function() {
	debugger;
	if(operation == 'Update'){
		
		CambiarAConsulta();
	}
}