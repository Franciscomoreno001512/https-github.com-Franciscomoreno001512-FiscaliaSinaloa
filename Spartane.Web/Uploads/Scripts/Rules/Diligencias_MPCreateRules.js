var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$("#Diligencias_MPGuardarYNuevo , #Diligencias_MPGuardarYCopia").hide()
$(document).ready(function () {








//BusinessRuleId:2568, Attribute:267313, Operation:Field, Event:None
$("form#CreateDiligencias_MP").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Solicitar_Archivo_Adjunto from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divArchivo_Adjunto').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));} else { $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));}
});

//BusinessRuleId:2568, Attribute:267313, Operation:Field, Event:None





//BusinessRuleId:2565, Attribute:267313, Operation:Field, Event:None
$("form#CreateDiligencias_MP").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("  select Requerido from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divProbable_Responsable').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));} else { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}
});

//BusinessRuleId:2565, Attribute:267313, Operation:Field, Event:None

//BusinessRuleId:2579, Attribute:267313, Operation:Field, Event:None
$("form#CreateDiligencias_MP").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divInvolucrado').css('display', 'block');$('#divProbable_Responsable').css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));} else {}
});

//BusinessRuleId:2579, Attribute:267313, Operation:Field, Event:None

//BusinessRuleId:2569, Attribute:267313, Operation:Field, Event:None
$("form#CreateDiligencias_MP").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Solicitar_Numero_de_Oficio from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divNumero_de_Oficio').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));} else { $('#divNumero_de_Oficio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}
});

//BusinessRuleId:2569, Attribute:267313, Operation:Field, Event:None

















//BusinessRuleId:2897, Attribute:267315, Operation:Field, Event:None
$("form#CreateDiligencias_MP").on('change', '#Involucrado', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Persona_Desaparecida from Detalle_de_Datos_Generales"
+" where Tipo_de_Compareciente = 2 AND persona_aparecio = 0 and clave = FLD[Involucrado]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('La persona seleccionada se encuentra desaparecida, favor de registrar la aparición de la persona', rowIndex, nameOfTable));} else {}
});

//BusinessRuleId:2897, Attribute:267315, Operation:Field, Event:None



//BusinessRuleId:2564, Attribute:267313, Operation:Field, Event:None
$("form#CreateDiligencias_MP").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divInvolucrado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));} else { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}
});

//BusinessRuleId:2564, Attribute:267313, Operation:Field, Event:None

//BusinessRuleId:3015, Attribute:267313, Operation:Field, Event:None
$("form#CreateDiligencias_MP").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Descripcion' + rowIndex),EvaluaQuery("select Descripcion from Documento where Clave = FLD[Documento]", rowIndex, nameOfTable));
});

//BusinessRuleId:3015, Attribute:267313, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2557, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));$('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));


}
//BusinessRuleId:2557, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2557, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));$('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));


}
//BusinessRuleId:2557, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2557, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));$('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));


}
//BusinessRuleId:2557, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2558, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery(" select Name from Spartan_User where Id_USer=GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:2558, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:2574, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("  select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divProbable_Responsable').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));} else { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}

}
//BusinessRuleId:2574, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2574, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("  select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divProbable_Responsable').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));} else { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}

}
//BusinessRuleId:2574, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:2577, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select Solicitar_Numero_de_Oficio from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divNumero_de_Oficio').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));} else { $('#divNumero_de_Oficio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}

}
//BusinessRuleId:2577, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2577, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Solicitar_Numero_de_Oficio from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divNumero_de_Oficio').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));} else { $('#divNumero_de_Oficio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}

}
//BusinessRuleId:2577, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2575, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select Solicitar_Archivo_Adjunto from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divArchivo_Adjunto').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));} else { $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));}

}
//BusinessRuleId:2575, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2575, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Solicitar_Archivo_Adjunto from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divArchivo_Adjunto').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));} else { $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));}

}
//BusinessRuleId:2575, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2619, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divTipo_de_Documento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));

}
//BusinessRuleId:2619, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2619, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divTipo_de_Documento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));

}
//BusinessRuleId:2619, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2619, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divTipo_de_Documento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));

}
//BusinessRuleId:2619, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2559, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).val();   $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetTipoDocumentoOrigen 3", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetTipoDocumentoOrigen 3", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2559, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2559, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).val();   $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetTipoDocumentoOrigen 3", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetTipoDocumentoOrigen 3", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2559, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2620, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave,Descripcion from documento where Origen = 3", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave,Descripcion from documento where Origen = 3", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2620, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2620, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave,Descripcion from documento where Origen = 3", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave,Descripcion from documento where Origen = 3", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2620, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2560, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2560, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2560, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2560, Attribute:0, Operation:Object, Event:SCREENOPENING





























//BusinessRuleId:2573, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divInvolucrado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));} else { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}

}
//BusinessRuleId:2573, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2573, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divInvolucrado').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));} else { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}

}
//BusinessRuleId:2573, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;




















//BusinessRuleId:2582, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("	select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Involucrado' + rowIndex),nameOfTable,rowIndex)>=TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Probable_Responsable' + rowIndex),nameOfTable,rowIndex)>=TryParseInt('1', '1') ) { alert(DecodifyText(' 	Debe seleccionar solamente una persona, puede ser Solicitante o Requerido', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2582, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2582, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("	select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Involucrado' + rowIndex),nameOfTable,rowIndex)>=TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Probable_Responsable' + rowIndex),nameOfTable,rowIndex)>=TryParseInt('1', '1') ) { alert(DecodifyText(' 	Debe seleccionar solamente una persona, puede ser Solicitante o Requerido', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2582, Attribute:2, Operation:Object, Event:BEFORESAVING













//BusinessRuleId:2581, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Involucrado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Probable_Responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') ) { alert(DecodifyText(' Debe seleccionar por lo menos una persona, puede ser Solicitante o Requerido', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2581, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2581, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("select Requerido_o_Solicitante from Documento where clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Involucrado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Probable_Responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') ) { alert(DecodifyText(' Debe seleccionar por lo menos una persona, puede ser Solicitante o Requerido', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2581, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2621, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),EvaluaQuery("select Tipo_de_Documento from documento where Clave = FLD[Documento]", rowIndex, nameOfTable));

}
//BusinessRuleId:2621, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2621, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),EvaluaQuery("select Tipo_de_Documento from documento where Clave = FLD[Documento]", rowIndex, nameOfTable));

}
//BusinessRuleId:2621, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:2583, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("  update Diligencias_MP "
+" set expediente_mp = GLOBAL[SpartanOperationId] "
+" where clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2583, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


