var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {

    $("#Registro_de_Mandamiento_JudicialGuardarYNuevo").remove();
    $("#Registro_de_Mandamiento_JudicialGuardarYCopia").remove();






//BusinessRuleId:4956, Attribute:268888, Operation:Field, Event:None
$("form#CreateRegistro_de_Mandamiento_Judicial").on('change', '#Pais_al_que_Pertenece_la_Informacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Pais_al_que_Pertenece_la_Informacion' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex).val();   $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave, nombre from estado where pais = FLD[Pais_al_que_Pertenece_la_Informacion]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave, nombre from estado where pais = FLD[Pais_al_que_Pertenece_la_Informacion]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:4956, Attribute:268888, Operation:Field, Event:None

//BusinessRuleId:4957, Attribute:268889, Operation:Field, Event:None
$("form#CreateRegistro_de_Mandamiento_Judicial").on('change', '#Estado_que_Envia_la_Informacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave, nombre from municipio where estado = FLD[Estado_que_Envia_la_Informacion]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave, nombre from municipio where estado = FLD[Estado_que_Envia_la_Informacion]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:4957, Attribute:268889, Operation:Field, Event:None











//BusinessRuleId:4970, Attribute:273739, Operation:Field, Event:None
$("form#CreateRegistro_de_Mandamiento_Judicial").on('change', '#Causa_Penal', function () {
	nameOfTable='';
	rowIndex='';
 fillMRFromQuery('Detalle_de_Personas_a_Incluir', "select null as Folio, di.Nombre_Completo_Detenido as Persona, 0 as Seleccionar, di.Clave as PersonaId from Judicializacion j"
+" inner join Detalle_de_Relaciones dr on dr.Clave = j.Relacion"
+" inner join Detalle_de_Imputado di on di.Clave = dr.Probable_Responsable"
+" where j.clave= FLD[Causa_Penal]");
});


//BusinessRuleId:4970, Attribute:273739, Operation:Field, Event:None

//BusinessRuleId:4966, Attribute:273718, Operation:Field, Event:None
$("form#CreateRegistro_de_Mandamiento_Judicial").on('change', '#Fuente', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fuente' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Institucion_que_Remite' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entidad_que_Emite_Mandamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juzgado_que_Emitio_Mandamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Libramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Area_que_envia_Orden' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Oficio_de_Libramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Transcripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Oficio_Transcripcion' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Dependencia_Autoridad_Remitente' + rowIndex)); $("a[href='#tabExpediente']").css('display', 'none'); $('#divDependencia_Autoridad_Remitente').css('display', 'block');} else { SetRequiredToControl( $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Institucion_que_Remite' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Entidad_que_Emite_Mandamiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juzgado_que_Emitio_Mandamiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Libramiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Area_que_envia_Orden' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Oficio_de_Libramiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Transcripcion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Oficio_Transcripcion' + rowIndex)); $('#divDependencia_Autoridad_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dependencia_Autoridad_Remitente' + rowIndex)); $("a[href='#tabExpediente']").css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Institucion_que_Remite' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Entidad_que_Emite_Mandamiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juzgado_que_Emitio_Mandamiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Libramiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Area_que_envia_Orden' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Oficio_de_Libramiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Transcripcion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Oficio_Transcripcion' + rowIndex));}
});


//BusinessRuleId:4966, Attribute:273718, Operation:Field, Event:None



//BusinessRuleId:4959, Attribute:273738, Operation:Field, Event:None
$("form#CreateRegistro_de_Mandamiento_Judicial").on('change', '#Carpeta_de_Investigacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { fillMRFromQuery('Detalle_de_Personas_a_Incluir', "select DISTINCT null as Folio, Nombre_Completo_Detenido as Persona, 0 as Seleccionar, di.Clave as PersonaId "
+" from Detalle_de_Imputado di"
+" inner join Detalle_de_Relaciones dr on dr.Probable_Responsable = di.Clave where di.Expediente_MP = FLD[Carpeta_de_Investigacion]");} else {}
});

//BusinessRuleId:4959, Attribute:273738, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






























































































































//BusinessRuleId:4953, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Numero_de_Mandamiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Mandamiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_Penal' + rowIndex));


}
//BusinessRuleId:4953, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4953, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Numero_de_Mandamiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Mandamiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_Penal' + rowIndex));


}
//BusinessRuleId:4953, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:4954, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); 
 AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); 
 AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery(" select name from Spartan_User where Id_User =  GLOBAL[USERID]  ", rowIndex, nameOfTable));
  AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'1'); AsignarValor($('#' + nameOfTable + 'Numero_de_Mandamiento' + rowIndex),'Se generará automáticamente');
//    AsignarValor($('#' + nameOfTable + 'Pais_al_que_Pertenece_la_Informacion' + rowIndex),EvaluaQuery(" select Nombre from Pais where clave = 82", rowIndex, nameOfTable));
debugger;
var valor = 82;
$('#' + nameOfTable + 'Pais_al_que_Pertenece_la_Informacion' + rowIndex).empty();
if (!$('#' + nameOfTable + 'Pais_al_que_Pertenece_la_Informacion' + rowIndex).hasClass('AutoComplete')) {
    $('#' + nameOfTable + 'Pais_al_que_Pertenece_la_Informacion' + rowIndex).append($("<option selected />").val("").text(""));
    $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Pais ", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Pais_al_que_Pertenece_la_Informacion' + rowIndex).append($("<option />").val(index).text(value)); });
} else {
    var selectData = [];
    selectData.push({ id: "", text: "" });
    $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Pais ", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
    $('#' + nameOfTable + 'Pais_al_que_Pertenece_la_Informacion' + rowIndex).select2({ data: selectData })
}
$('#' + nameOfTable + 'Pais_al_que_Pertenece_la_Informacion' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:4954, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:4962, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('.PersonaIdHeader').css('display', 'none');
var index = $('.PersonaIdHeader').index();
 eval($('.PersonaIdHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();


}
//BusinessRuleId:4962, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4962, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('.PersonaIdHeader').css('display', 'none');
var index = $('.PersonaIdHeader').index();
 eval($('.PersonaIdHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();


}
//BusinessRuleId:4962, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4960, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 if('true' == 'true')
{
	$('#divPersonas_a_Incluir a').attr('disabled', 'disabled');
	$('#divPersonas_a_Incluir a').css("pointer-events","none");
}
else
{
	$('#divPersonas_a_Incluir a').attr('disabled', '');
	$('#divPersonas_a_Incluir a').css("pointer-events","all");
}


}
//BusinessRuleId:4960, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4960, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 if('true' == 'true')
{
	$('#divPersonas_a_Incluir a').attr('disabled', 'disabled');
	$('#divPersonas_a_Incluir a').css("pointer-events","none");
}
else
{
	$('#divPersonas_a_Incluir a').attr('disabled', '');
	$('#divPersonas_a_Incluir a').css("pointer-events","all");
}


}
//BusinessRuleId:4960, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4967, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Fuente' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Institucion_que_Remite' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entidad_que_Emite_Mandamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juzgado_que_Emitio_Mandamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Libramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Area_que_envia_Orden' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Oficio_de_Libramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Transcripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Oficio_Transcripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_Penal' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Dependencia_Autoridad_Remitente' + rowIndex)); $('#divDependencia_Autoridad_Remitente').css('display', 'block'); $("a[href='#tabExpediente']").css('display', 'none');} else { SetRequiredToControl( $('#' + nameOfTable + 'Estado_que_Envia_la_Informacion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Municipio_que_Envia_la_Informacion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Institucion_que_Remite' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Entidad_que_Emite_Mandamiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juzgado_que_Emitio_Mandamiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Libramiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Area_que_envia_Orden' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Oficio_de_Libramiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Transcripcion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Oficio_Transcripcion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Causa_Penal' + rowIndex)); $('#divDependencia_Autoridad_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dependencia_Autoridad_Remitente' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Dependencia_Autoridad_Remitente' + rowIndex)); $("a[href='#tabExpediente']").css('display', 'block');}


}
//BusinessRuleId:4967, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4968, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==TryParseInt('2', '2') ) { AsignarValor($('#' + nameOfTable + 'Fuente' + rowIndex),'2');} else {}


}
//BusinessRuleId:4968, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4975, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4975, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4975, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4975, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4975, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4975, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4976, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4976, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4976, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4976, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4976, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4976, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4978, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4978, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4978, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4978, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4978, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:4978, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//BusinessRuleId:4955, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Numero_de_Mandamiento' + rowIndex),EvaluaQuery(" exec uspFolioMandamientoJudicial", rowIndex, nameOfTable));


}
//BusinessRuleId:4955, Attribute:2, Operation:Object, Event:BEFORESAVING







//BusinessRuleId:4972, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Causa_Penal' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Fuente' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('2', '2') ) { alert(DecodifyText('Es necesario seleccionar una capeta de investigacion o causa penal.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4972, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:4971, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("exec uspUpdateMandamientoJudicial GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:4971, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Domicilio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Domicilio//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Domicilio(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Domicilio//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Domicilio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Domicilio//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Domicilio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Domicilio//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Domicilio(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Domicilio//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_telefono(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_telefono//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_telefono(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_telefono//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_telefono(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_telefono//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_telefono(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_telefono//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_telefono(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_telefono//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Otro_Nombre(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Otro_Nombre//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Otro_Nombre(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Otro_Nombre//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Otro_Nombre(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Otro_Nombre//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Otro_Nombre(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Otro_Nombre//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Otro_Nombre(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Otro_Nombre//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Delito_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Delito_Mandamiento_Judicial//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Delito_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Delito_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Delito_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Delito_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Amparo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Amparo//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Amparo(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Amparo//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Amparo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Amparo//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Amparo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Amparo//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Amparo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Amparo//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Fotos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Fotos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Fotos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Fotos//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Fotos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Fotos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Fotos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Fotos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Fotos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Fotos//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Documentos_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Documentos_Mandamiento_Judicial//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Documentos_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Documentos_Mandamiento_Judicial//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Documentos_Mandamiento_Judicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Documentos_Mandamiento_Judicial//
    return result;
}


function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Personas_a_Incluir// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Personas_a_Incluir// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_de_Personas_a_Incluir// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_de_Personas_a_Incluir// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_de_Personas_a_Incluir(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_de_Personas_a_Incluir// 
 return result; 
} 
