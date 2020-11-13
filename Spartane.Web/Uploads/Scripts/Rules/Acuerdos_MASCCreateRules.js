var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;

$("#Acuerdos_MASCGuardarYNuevo").hide()
$("#Acuerdos_MASCGuardarYCopia").hide()
$(document).ready(function () {










//BusinessRuleId:2016, Attribute:266510, Operation:Field, Event:None
$("form#CreateAcuerdos_MASC").on('keyup', '#Monto_Total', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Monto_Total' + rowIndex).val()!=TryParseInt('0', '0') && $('#' + nameOfTable + 'Parcialidades' + rowIndex).val()!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex),EvaluaQuery(" (select FLD[Monto_Total]/FLD[Parcialidades])", rowIndex, nameOfTable));} else {}
});


//BusinessRuleId:2016, Attribute:266510, Operation:Field, Event:None

//BusinessRuleId:2017, Attribute:266511, Operation:Field, Event:None
$("form#CreateAcuerdos_MASC").on('keyup', '#Parcialidades', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Monto_Total' + rowIndex).val()!=TryParseInt('0', '0') || $('#' + nameOfTable + 'Parcialidades' + rowIndex).val()!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex),EvaluaQuery(" (select FLD[Monto_Total]/FLD[Parcialidades])", rowIndex, nameOfTable));} else {}
});

//BusinessRuleId:2017, Attribute:266511, Operation:Field, Event:None



//BusinessRuleId:2101, Attribute:266688, Operation:Field, Event:None
$("form#CreateAcuerdos_MASC").on('change', '#Acuerdo_Cumplido', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divRazon_de_Incumplimiento').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable));} else { $('#divRazon_de_Incumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable));}
});

//BusinessRuleId:2101, Attribute:266688, Operation:Field, Event:None





//BusinessRuleId:2424, Attribute:266722, Operation:Field, Event:None
$("form#CreateAcuerdos_MASC").on('change', '#Forma_de_Cumplimiento', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Forma_de_Cumplimiento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') || GetValueByControlType($('#' + nameOfTable + 'Forma_de_Cumplimiento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divMonto_Total').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Monto_Total' + rowIndex));} else { $('#divMonto_Total').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_Total' + rowIndex));}
});

//BusinessRuleId:2424, Attribute:266722, Operation:Field, Event:None

//BusinessRuleId:2421, Attribute:266505, Operation:Field, Event:None
$("form#CreateAcuerdos_MASC").on('change', '#Tipo_de_Acuerdo', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divParcialidades').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));$('#divPeriodicidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));$('#divMonto_de_la_Parcialidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex));} else { $('#divParcialidades').css('display', 'block');$('#divPeriodicidad').css('display', 'block');$('#divMonto_de_la_Parcialidad').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex));}
});

//BusinessRuleId:2421, Attribute:266505, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






//BusinessRuleId:2013, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Revisa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Comentarios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex)); var valor = $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).val();   $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Id_User,Name from Spartan_USer where Role=103", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Id_User,Name from Spartan_USer where Role=103", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:2013, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2013, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Revisa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Comentarios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex)); var valor = $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).val();   $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Id_User,Name from Spartan_USer where Role=103", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Id_User,Name from Spartan_USer where Role=103", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:2013, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2014, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery(" select Name from Spartan_USer where Id_User=GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:2014, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divAcuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));

}
//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divAcuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));

}
//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divAcuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));

}
//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2074, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else { $("a[href='#tabAutorizacion']").css('display', 'none');}

}
//BusinessRuleId:2074, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2074, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else { $("a[href='#tabAutorizacion']").css('display', 'none');}

}
//BusinessRuleId:2074, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2091, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divPersonal_de_Seguimiento_Asignado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex));} else { $('#divPersonal_de_Seguimiento_Asignado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex));}

}
//BusinessRuleId:2091, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Resultado' + rowIndex).val()!=TryParseInt('null', 'null') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else { $("a[href='#tabAutorizacion']").css('display', 'none');}

}
//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Resultado' + rowIndex).val()!=TryParseInt('null', 'null') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else { $("a[href='#tabAutorizacion']").css('display', 'none');}

}
//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Resultado' + rowIndex).val()!=TryParseInt('null', 'null') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else { $("a[href='#tabAutorizacion']").css('display', 'none');}

}
//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2055, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divPersonal_de_Seguimiento_Asignado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex));$('#divFecha_de_Cumplimiento_de_Acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex));$('#divAcuerdo_Cumplido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex));$('#divRazon_de_Incumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Hora_de_Acuerdo' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));

}
//BusinessRuleId:2055, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2099, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Solicitante' + rowIndex).val();   $('#' + nameOfTable + 'Solicitante' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Solicitante' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetSolicitantesExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetSolicitantesExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Solicitante' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Solicitante' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Requerido' + rowIndex).val();   $('#' + nameOfTable + 'Requerido' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Requerido' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetRequeridosExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetRequeridosExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Requerido' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Requerido' + rowIndex).val(valor).trigger('change'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex));

}
//BusinessRuleId:2099, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2099, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Solicitante' + rowIndex).val();   $('#' + nameOfTable + 'Solicitante' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Solicitante' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetSolicitantesExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetSolicitantesExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Solicitante' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Solicitante' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Requerido' + rowIndex).val();   $('#' + nameOfTable + 'Requerido' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Requerido' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetRequeridosExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetRequeridosExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Requerido' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Requerido' + rowIndex).val(valor).trigger('change'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex));

}
//BusinessRuleId:2099, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2100, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divRazon_de_Incumplimiento').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));} else { $('#divRazon_de_Incumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));}

}
//BusinessRuleId:2100, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2426, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Forma_de_Cumplimiento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') || GetValueByControlType($('#' + nameOfTable + 'Forma_de_Cumplimiento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divMonto_Total').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Monto_Total' + rowIndex));} else { $('#divMonto_Total').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_Total' + rowIndex));}

}
//BusinessRuleId:2426, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2423, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divParcialidades').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));$('#divPeriodicidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));$('#divMonto_de_la_Parcialidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex));

}
//BusinessRuleId:2423, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){

















//BusinessRuleId:2097, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("select estatus from solicitud with(nolock) where clave=FLD[Numero_de_Expediente]",rowIndex, nameOfTable)==TryParseInt('97', '97') && GetValueByControlType($('#' + nameOfTable + 'Resultado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { EvaluaQuery(" exec uspGeneraParcialidadesMASC FLDD[lblClave]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:2097, Attribute:2, Operation:Object, Event:AFTERSAVING



//BusinessRuleId:2147, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
	debugger;
 EvaluaQuery(" exec uspGeneraCierreAcuerdo FLDD[lblClave]", rowIndex, nameOfTable);

}
//BusinessRuleId:2147, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2018, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Acuerdos_MASC set Numero_de_Expediente = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); 
 EvaluaQuery(" exec uspEnviaAcuerdoMAC_a_AT GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); 
}
//BusinessRuleId:2018, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


