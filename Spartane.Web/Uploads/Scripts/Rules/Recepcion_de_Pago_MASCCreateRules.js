var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {


//BusinessRuleId:2075, Attribute:266181, Operation:Field, Event:None
$("form#CreateRecepcion_de_Pago_MASC").on('change', '#Numero_de_Expediente', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Requerido' + rowIndex).val();   $('#' + nameOfTable + 'Requerido' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Requerido' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave, Nombre + ' ' + Apellido_Paterno + ' ' + Apellido_Materno from Detalle_de_Solicitud_Requerido where Solicitud = FLD[Numero_de_Expediente]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave, Nombre + ' ' + Apellido_Paterno + ' ' + Apellido_Materno from Detalle_de_Solicitud_Requerido where Solicitud = FLD[Numero_de_Expediente]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Requerido' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Requerido' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:2075, Attribute:266181, Operation:Field, Event:None

//BusinessRuleId:2078, Attribute:266186, Operation:Field, Event:None
$("form#CreateRecepcion_de_Pago_MASC").on('change', '#Pago_Completo', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Pago_Completo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') ) { $('#divPago_Completo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Pago_Completo' + rowIndex));} else { $('#divPago_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pago_Completo' + rowIndex));}
});

//BusinessRuleId:2078, Attribute:266186, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {












//BusinessRuleId:2067, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex),EvaluaQuery("select GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2067, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2066, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Recibe" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex));}

}
//BusinessRuleId:2066, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2066, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Recibe" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex));}

}
//BusinessRuleId:2066, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2066, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Recepcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Recepcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Recibe" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Recibe' + rowIndex));}

}
//BusinessRuleId:2066, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2073, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divMotivo_para_no_entregar_pago_completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_para_no_entregar_pago_completo' + rowIndex));

}
//BusinessRuleId:2073, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2072, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).val();   $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Numero_de_Expediente from Solicitud where Estatus = 98", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Numero_de_Expediente from Solicitud where Estatus = 98", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2072, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:2077, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Pago_Completo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') ) { $('#divPago_Completo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Pago_Completo' + rowIndex));} else { $('#divPago_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pago_Completo' + rowIndex));}

}
//BusinessRuleId:2077, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2077, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Pago_Completo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') ) { $('#divPago_Completo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Pago_Completo' + rowIndex));} else { $('#divPago_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pago_Completo' + rowIndex));}

}
//BusinessRuleId:2077, Attribute:0, Operation:Object, Event:SCREENOPENING

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


