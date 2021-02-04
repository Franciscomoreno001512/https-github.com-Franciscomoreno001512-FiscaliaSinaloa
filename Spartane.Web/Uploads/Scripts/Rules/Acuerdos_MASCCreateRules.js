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





//BusinessRuleId:2746, Attribute:266521, Operation:Field, Event:None
$("form#CreateAcuerdos_MASC").on('change', '#Resultado', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Resultado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divMotivo_de_Rechazo_de_Acuerdo').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_de_Acuerdo" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));} SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));} else { $('#divMotivo_de_Rechazo_de_Acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));}
});

//BusinessRuleId:2746, Attribute:266521, Operation:Field, Event:None

//BusinessRuleId:2421, Attribute:266505, Operation:Field, Event:None
$("form#CreateAcuerdos_MASC").on('change', '#Tipo_de_Acuerdo', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('0', '0') ) { $('#divParcialidades').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));$('#divPeriodicidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));$('#divMonto_de_la_Parcialidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex));} else { $('#divParcialidades').css('display', 'block');$('#divPeriodicidad').css('display', 'block');$('#divMonto_de_la_Parcialidad').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex));}
});

//BusinessRuleId:2421, Attribute:266505, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
































//BusinessRuleId:2091, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divPersonal_de_Seguimiento_Asignado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex));} else { $('#divPersonal_de_Seguimiento_Asignado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex));}

}
//BusinessRuleId:2091, Attribute:0, Operation:Object, Event:SCREENOPENING











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







//BusinessRuleId:2442, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divParcialidades').css('display', 'block');$('#divPeriodicidad').css('display', 'block');$('#divMonto_de_la_Parcialidad').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex));} else {}

}
//BusinessRuleId:2442, Attribute:0, Operation:Object, Event:SCREENOPENING







































































//BusinessRuleId:2745, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('2', '2') ) { AsignarValor($('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Revision' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex),EvaluaQuery(" select Name from Spartan_USer where Id_User=GLOBAL[USERID]", rowIndex, nameOfTable)); SetRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex)); $('#divMotivo_de_Rechazo_de_Acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));} else {}

}
//BusinessRuleId:2745, Attribute:0, Operation:Object, Event:SCREENOPENING























//BusinessRuleId:2743, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('2', '2') ) { $("a[href='#tabAutorizacion']").css('display', 'block'); DisabledControl($("#" + nameOfTable + "Fecha_de_Revision" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Revision" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Revisa" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex));} $('#divMotivo_de_Rechazo_de_Acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));} else {}

}
//BusinessRuleId:2743, Attribute:0, Operation:Object, Event:SCREENOPENING















//BusinessRuleId:2014, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery(" select Name from Spartan_USer where Id_User=GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2014, Attribute:0, Operation:Object, Event:SCREENOPENING





















//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)!=TryParseInt('2', '2') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else { $("a[href='#tabAutorizacion']").css('display', 'none');}

}
//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)!=TryParseInt('2', '2') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else { $("a[href='#tabAutorizacion']").css('display', 'none');}

}
//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)!=TryParseInt('2', '2') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else { $("a[href='#tabAutorizacion']").css('display', 'none');}

}
//BusinessRuleId:2015, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2747, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('2', '2') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else {}

}
//BusinessRuleId:2747, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2747, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('2', '2') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else {}

}
//BusinessRuleId:2747, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2747, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('2', '2') ) { $("a[href='#tabAutorizacion']").css('display', 'block');} else {}

}
//BusinessRuleId:2747, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2013, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Revisa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Comentarios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex)); var valor = $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).val();   $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Id_User,Name from Spartan_USer where Role=103", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Id_User,Name from Spartan_USer where Role=103", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).val(valor).trigger('change'); $('#divFecha_de_Cumplimiento_de_Acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex));$('#divAcuerdo_Cumplido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex));$('#divRazon_de_Incumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));

}
//BusinessRuleId:2013, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2013, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Revisa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Comentarios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex)); var valor = $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).val();   $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Id_User,Name from Spartan_USer where Role=103", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Id_User,Name from Spartan_USer where Role=103", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex).val(valor).trigger('change'); $('#divFecha_de_Cumplimiento_de_Acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex));$('#divAcuerdo_Cumplido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex));$('#divRazon_de_Incumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));

}
//BusinessRuleId:2013, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2423, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('0', '0') ) { $('#divParcialidades').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));$('#divPeriodicidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));$('#divMonto_de_la_Parcialidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex));} else { $('#divParcialidades').css('display', 'block');$('#divPeriodicidad').css('display', 'block');$('#divMonto_de_la_Parcialidad').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex));}

}
//BusinessRuleId:2423, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:3054, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Lugar_Acordado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_Acordado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Domicilio_Acordado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_Acordado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Inicio_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Inicio_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Monto_Total" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_Total' + rowIndex));}DisabledControl($("#" + nameOfTable + "Parcialidades" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));}DisabledControl($("#" + nameOfTable + "Periodicidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Comentarios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Comentarios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Cumplimiento_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Revision" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Revision' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Revisa" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Monto_de_la_Parcialidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Solicitante" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));}DisabledControl($("#" + nameOfTable + "Requerido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Acuerdo_Cumplido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Razon_de_Incumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Cumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion_del_Cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_del_Cumplimiento' + rowIndex));}} else {}

}
//BusinessRuleId:3054, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divDomicilio_Acordado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_Acordado' + rowIndex));$('#divAcuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));

}
//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divDomicilio_Acordado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_Acordado' + rowIndex));$('#divAcuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));

}
//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divDomicilio_Acordado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_Acordado' + rowIndex));$('#divAcuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo' + rowIndex));

}
//BusinessRuleId:1973, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3602, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Relacion' + rowIndex).val();   $('#' + nameOfTable + 'Relacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Relacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Relaciones_MASC where Numero_de_expediente = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Relaciones_MASC where Numero_de_expediente = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Relacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Relacion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3602, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3602, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Relacion' + rowIndex).val();   $('#' + nameOfTable + 'Relacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Relacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Relaciones_MASC where Numero_de_expediente = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Relaciones_MASC where Numero_de_expediente = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Relacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Relacion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3602, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3602, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Relacion' + rowIndex).val();   $('#' + nameOfTable + 'Relacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Relacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Relaciones_MASC where Numero_de_expediente = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Relaciones_MASC where Numero_de_expediente = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Relacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Relacion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3602, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2730, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('2', '2') && EvaluaQuery("select Estatus from Solicitud where Clave=FLD[Numero_de_Expediente] ",rowIndex, nameOfTable)==TryParseInt('94', '94') ) { DisabledControl($("#" + nameOfTable + "Numero_de_Expediente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Lugar_Acordado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_Acordado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Domicilio_Acordado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_Acordado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Inicio_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Inicio_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Monto_Total" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_Total' + rowIndex));}DisabledControl($("#" + nameOfTable + "Parcialidades" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));}DisabledControl($("#" + nameOfTable + "Personal_de_Seguimiento_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Comentarios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Comentarios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Cumplimiento_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_Rechazo_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Monto_de_la_Parcialidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Parcialidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Solicitante" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));}DisabledControl($("#" + nameOfTable + "Requerido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Acuerdo_Cumplido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Razon_de_Incumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Cumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion_del_Cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_del_Cumplimiento' + rowIndex));} DisabledControl($("#" + nameOfTable + "Periodicidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));} DisabledControl($("#" + nameOfTable + "Resultado" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex));} SetRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex),EvaluaQuery(" SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));} else {}

}
//BusinessRuleId:2730, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){











debugger;



























//BusinessRuleId:2741, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("exec uspRealizaValidacionAcuerdo FLDD[lblClave],GLOBAL[USERROLEID]", rowIndex, nameOfTable);

}
//BusinessRuleId:2741, Attribute:2, Operation:Object, Event:AFTERSAVING



//BusinessRuleId:2018, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Acuerdos_MASC "
+" set Numero_de_Expediente = GLOBAL[SpartanOperationId] "
+" where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); EvaluaQuery(" exec uspRealizaValidacionAcuerdo GLOBAL[keyvalueinserted],GLOBAL[USERROLEID]", rowIndex, nameOfTable);

}
//BusinessRuleId:2018, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3606, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Acuerdo_MASC set Solicitud = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]	", rowIndex, nameOfTable);

}
//BusinessRuleId:3606, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


