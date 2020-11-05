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



//BusinessRuleId:2055, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divPersonal_de_Seguimiento_Asignado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Personal_de_Seguimiento_Asignado' + rowIndex));$('#divFecha_de_Cumplimiento_de_Acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_de_Acuerdo' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Hora_de_Acuerdo' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));

}
//BusinessRuleId:2055, Attribute:0, Operation:Object, Event:SCREENOPENING

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

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){













//BusinessRuleId:2018, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Acuerdos_MASC "
+" set Numero_de_Expediente = GLOBAL[SpartanOperationId] "
+" where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); EvaluaQuery(" exec uspEnviaAcuerdoMAC_a_AT GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); SendEmailQuery('SAPROJ - Nuevo Acuerdo por Autorizar', EvaluaQuery("exec uspGetCorreoOrigen GLOBAL[SpartanOperationId]"), "Por este medio se le notifica que la unidad de Mecanismos Alternos ha generado un nuevo Acuerdo, el cual requiere su autorización."
+" <br><br>"
+" <b>Acuerdo:</b> FLDD[Tipo_de_Acuerdo]"
+" <br><b>Domicilio Acordado:</b> FLD[Domicilio_Acordado]"
+" <br><b>Monto Total:</b> FLD[Monto_Total]"
+" <br><b>Parcialidades:</b>FLD[Parcialidades]"
+" <br><b>Periodicidad:</b> FLDD[Periodicidad]"
+" <br><br>"
+" Favor de ingresar a SAPROJ para realizar la revisión correspondiente.",rowIndex,nameOfTable);

}
//BusinessRuleId:2018, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


