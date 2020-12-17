var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$('#Detalle_de_documentosGuardarYNuevo').hide();
$('#Detalle_de_documentosGuardarYCopia').hide();
$(document).ready(function () {




//BusinessRuleId:2058, Attribute:263060, Operation:Field, Event:None
$("form#CreateDetalle_de_documentos").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divSolicitante').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));} else { $('#divSolicitante').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));}
});

//BusinessRuleId:2058, Attribute:263060, Operation:Field, Event:None

//BusinessRuleId:2059, Attribute:263060, Operation:Field, Event:None
$("form#CreateDetalle_de_documentos").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Requerido from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divRequerido').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));} else { $('#divRequerido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));}
});

//BusinessRuleId:2059, Attribute:263060, Operation:Field, Event:None



//BusinessRuleId:2060, Attribute:263060, Operation:Field, Event:None
$("form#CreateDetalle_de_documentos").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Solicitar_Archivo_Adjunto from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divArchivo_Adjunto').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));} else { $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));}
});

//BusinessRuleId:2060, Attribute:263060, Operation:Field, Event:None









//BusinessRuleId:2173, Attribute:263060, Operation:Field, Event:None
$("form#CreateDetalle_de_documentos").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Descripcion' + rowIndex),EvaluaQuery("select Descripcion from Documento where Clave = FLD[Documento]", rowIndex, nameOfTable));
});

//BusinessRuleId:2173, Attribute:263060, Operation:Field, Event:None



//BusinessRuleId:2172, Attribute:263060, Operation:Field, Event:None
$("form#CreateDetalle_de_documentos").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Solicitar_Numero_de_Oficio from Documento where Clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divNumero_de_Oficio').css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}} else { $('#divNumero_de_Oficio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}
});

//BusinessRuleId:2172, Attribute:263060, Operation:Field, Event:None





//BusinessRuleId:2448, Attribute:263060, Operation:Field, Event:None
$("form#CreateDetalle_de_documentos").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divSolicitante').css('display', 'block');$('#divRequerido').css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));} else {}
});

//BusinessRuleId:2448, Attribute:263060, Operation:Field, Event:None

//BusinessRuleId:2049, Attribute:266641, Operation:Field, Event:None
$("form#CreateDetalle_de_documentos").on('change', '#Tipo_de_Documento', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetDocumentosMASC FLD[Tipo_de_Documento]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetDocumentosMASC FLD[Tipo_de_Documento]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:2049, Attribute:266641, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {


















//BusinessRuleId:1960, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1960, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1960, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1960, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1960, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1960, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1613, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}

}
//BusinessRuleId:1613, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1613, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}

}
//BusinessRuleId:1613, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2026, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:2026, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2026, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:2026, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2026, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:2026, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2047, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2047, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2047, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2047, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2047, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2047, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1614, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha' + rowIndex),EvaluaQuery("select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery("select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery("select name from spartan_user where id_user=GLOBAL[USERID]", rowIndex, nameOfTable)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1614, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2048, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}

}
//BusinessRuleId:2048, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2048, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}

}
//BusinessRuleId:2048, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2048, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}

}
//BusinessRuleId:2048, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2056, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSolicitante').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));$('#divRequerido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));$('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));

}
//BusinessRuleId:2056, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2061, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divSolicitante').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));} else { $('#divSolicitante').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));}

}
//BusinessRuleId:2061, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2061, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divSolicitante').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));} else { $('#divSolicitante').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitante' + rowIndex));}

}
//BusinessRuleId:2061, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2062, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Requerido from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divRequerido').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));} else { $('#divRequerido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));}

}
//BusinessRuleId:2062, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2062, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select Requerido from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divRequerido').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));} else { $('#divRequerido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));}

}
//BusinessRuleId:2062, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2063, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Solicitar_Archivo_Adjunto from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divArchivo_Adjunto').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));} else { $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));}

}
//BusinessRuleId:2063, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2063, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select Solicitar_Archivo_Adjunto from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divArchivo_Adjunto').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));} else { $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));}

}
//BusinessRuleId:2063, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2081, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Solicitante' + rowIndex).val();   $('#' + nameOfTable + 'Solicitante' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Solicitante' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetSolicitantesExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetSolicitantesExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Solicitante' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Solicitante' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2081, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2081, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Solicitante' + rowIndex).val();   $('#' + nameOfTable + 'Solicitante' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Solicitante' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetSolicitantesExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetSolicitantesExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Solicitante' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Solicitante' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2081, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2082, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Requerido' + rowIndex).val();   $('#' + nameOfTable + 'Requerido' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Requerido' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetRequeridosExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetRequeridosExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Requerido' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Requerido' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2082, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2082, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Requerido' + rowIndex).val();   $('#' + nameOfTable + 'Requerido' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Requerido' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetRequeridosExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetRequeridosExpedienteMASC GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Requerido' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Requerido' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2082, Attribute:0, Operation:Object, Event:SCREENOPENING

















//BusinessRuleId:2175, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); $('#divNumero_de_Oficio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));

}
//BusinessRuleId:2175, Attribute:0, Operation:Object, Event:SCREENOPENING



































//BusinessRuleId:2163, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Descripcion' + rowIndex),EvaluaQuery("select Descripcion from Documento where Clave = FLD[Documento]", rowIndex, nameOfTable));

}
//BusinessRuleId:2163, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2163, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Descripcion' + rowIndex),EvaluaQuery("select Descripcion from Documento where Clave = FLD[Documento]", rowIndex, nameOfTable));

}
//BusinessRuleId:2163, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2163, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Descripcion' + rowIndex),EvaluaQuery("select Descripcion from Documento where Clave = FLD[Documento]", rowIndex, nameOfTable));

}
//BusinessRuleId:2163, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2171, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Solicitar_Numero_de_Oficio from Documento where Clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divNumero_de_Oficio').css('display', 'block');  DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); $('#divNumero_de_Oficio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}

}
//BusinessRuleId:2171, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2171, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select Solicitar_Numero_de_Oficio from Documento where Clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divNumero_de_Oficio').css('display', 'block');  DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); $('#divNumero_de_Oficio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}

}
//BusinessRuleId:2171, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2449, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divSolicitante').css('display', 'block');$('#divRequerido').css('display', 'block');} else {}

}
//BusinessRuleId:2449, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2547, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).val();   $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetTipoDocumentoOrigen 2", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetTipoDocumentoOrigen 2", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2547, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2547, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).val();   $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetTipoDocumentoOrigen 2", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetTipoDocumentoOrigen 2", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2547, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;


















//BusinessRuleId:2422, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("select Solicitar_Numero_de_Oficio from Documento where Clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { AsignarValor($('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex),EvaluaQuery("exec uspGeneraFolioMASC 3,null,GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));} else {}

}
//BusinessRuleId:2422, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2422, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("select Solicitar_Numero_de_Oficio from Documento where Clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { AsignarValor($('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex),EvaluaQuery("exec uspGeneraFolioMASC 3,null,GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));} else {}

}
//BusinessRuleId:2422, Attribute:2, Operation:Object, Event:BEFORESAVING



















//BusinessRuleId:2450, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') && EvaluaQuery("EXEC usp_ValidarSiSolicitanteYRequeridoSonNull FLD[Solicitante], FLD[Requerido]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('Debe seleccionar por lo menos una persona, puede ser Solicitante o Requerido', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2450, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2450, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') && EvaluaQuery("EXEC usp_ValidarSiSolicitanteYRequeridoSonNull FLD[Solicitante], FLD[Requerido]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('Debe seleccionar por lo menos una persona, puede ser Solicitante o Requerido', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2450, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2451, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') && EvaluaQuery("EXEC usp_ValidarSiSolicitanteYRequeridoNoSonNull FLD[Solicitante], FLD[Requerido]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText(' Debe seleccionar solamente una persona, puede ser Solicitante o Requerido', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2451, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2451, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') && EvaluaQuery("EXEC usp_ValidarSiSolicitanteYRequeridoNoSonNull FLD[Solicitante], FLD[Requerido]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText(' Debe seleccionar solamente una persona, puede ser Solicitante o Requerido', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2451, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){




debugger;









//BusinessRuleId:1616, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_documentos set Solicitud = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:1616, Attribute:2, Operation:Object, Event:AFTERSAVING







//BusinessRuleId:2368, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("EXEC usp_limpitarDiligenciasMASC FLDD[lblClave]", rowIndex, nameOfTable);

}
//BusinessRuleId:2368, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2367, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC usp_limpitarDiligenciasMASC GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2367, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}



function EjecutarValidacionesAntesDeGuardarMRDetalle_Documentos_Solicitantes(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Documentos_Solicitantes// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_Documentos_Solicitantes(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Documentos_Solicitantes// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_Documentos_Solicitantes(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_Documentos_Solicitantes// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_Documentos_Solicitantes(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_Documentos_Solicitantes// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_Documentos_Solicitantes(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_Documentos_Solicitantes// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMRDetalle_Documentos_Requeridos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Documentos_Requeridos// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_Documentos_Requeridos(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Documentos_Requeridos// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_Documentos_Requeridos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_Documentos_Requeridos// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_Documentos_Requeridos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_Documentos_Requeridos// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_Documentos_Requeridos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_Documentos_Requeridos// 
 return result; 
} 
