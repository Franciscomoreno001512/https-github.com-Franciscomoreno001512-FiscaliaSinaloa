var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$('#Proceso_PenalGuardarYNuevo').hide();
$('#Proceso_PenalGuardarYCopia').hide();
$(document).ready(function () {






//BusinessRuleId:2768, Attribute:267807, Operation:Field, Event:None
$("form#CreateProceso_Penal").on('change', '#Resolucion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divPlazo_meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Plazo_meses' + rowIndex));$('#divTipo_de_Sentencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));$('#divcuantia_de_pena_anios').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_anios' + rowIndex));$('#divcuantia_de_pena_meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_meses' + rowIndex));$('#divMonto_de_la_Reparacion_del_Dano').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Reparacion_del_Dano' + rowIndex)); if('true' == 'true')
{
	$('#divCondiciones').css('display', 'none');
}
else
{
	$('#divCondiciones').css('display', 'block');
}} else { $('#divPlazo_meses').css('display', 'block');$('#divTipo_de_Sentencia').css('display', 'block');$('#divcuantia_de_pena_anios').css('display', 'block');$('#divcuantia_de_pena_meses').css('display', 'block');$('#divMonto_de_la_Reparacion_del_Dano').css('display', 'block'); if('false' == 'true')
{
	$('#divCondiciones').css('display', 'none');
}
else
{
	$('#divCondiciones').css('display', 'block');
}}
});


//BusinessRuleId:2768, Attribute:267807, Operation:Field, Event:None













//BusinessRuleId:2770, Attribute:267807, Operation:Field, Event:None
$("form#CreateProceso_Penal").on('change', '#Resolucion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divPlazo_meses').css('display', 'block');$('#divMonto_de_la_Reparacion_del_Dano').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Plazo_meses' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Reparacion_del_Dano' + rowIndex)); $('#divTipo_de_Sentencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));$('#divcuantia_de_pena_anios').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_anios' + rowIndex));$('#divcuantia_de_pena_meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_meses' + rowIndex)); if('false' == 'true')
{
	$('#divCondiciones').css('display', 'none');
}
else
{
	$('#divCondiciones').css('display', 'block');
} if('false' == 'true')
{
	$('#divCondiciones').css('display', 'none');
}
else
{
	$('#divCondiciones').css('display', 'block');
}} else { $('#divPlazo_meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Plazo_meses' + rowIndex));$('#divMonto_de_la_Reparacion_del_Dano').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Reparacion_del_Dano' + rowIndex));}
});


//BusinessRuleId:2770, Attribute:267807, Operation:Field, Event:None

//BusinessRuleId:2774, Attribute:267807, Operation:Field, Event:None
$("form#CreateProceso_Penal").on('change', '#Resolucion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $('#divTipo_de_Sentencia').css('display', 'block');$('#divcuantia_de_pena_anios').css('display', 'block');$('#divcuantia_de_pena_meses').css('display', 'block');$('#divMonto_de_la_Reparacion_del_Dano').css('display', 'block'); $('#divPlazo_meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Plazo_meses' + rowIndex)); if('true' == 'true')
{
	$('#divCondiciones').css('display', 'none');
}
else
{
	$('#divCondiciones').css('display', 'block');
}} else {}
});


//BusinessRuleId:2774, Attribute:267807, Operation:Field, Event:None

//BusinessRuleId:2776, Attribute:267798, Operation:Field, Event:None
$("form#CreateProceso_Penal").on('change', '#Tribunal_de_Enjuiciamiento', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divJuez_Colegiado').css('display', 'block');$('#divJuez_Relator').css('display', 'block');$('#divJuez_Vocal').css('display', 'block');} else { $('#divJuez_Colegiado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Colegiado' + rowIndex));$('#divJuez_Relator').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));$('#divJuez_Vocal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));}
});


//BusinessRuleId:2776, Attribute:267798, Operation:Field, Event:None







//BusinessRuleId:2780, Attribute:267772, Operation:Field, Event:None
$("form#CreateProceso_Penal").on('change', '#Reclasificacion_Juridica', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Reclasificacion_Juridica' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) {

	$('#divDelitos a').attr('disabled', false);
	$('#divDelitos a').css("pointer-events","all");
}
else
{
	$('#divDelitos a').attr('disabled', 'disabled');
	$('#divDelitos a').css("pointer-events","none");
}
});


//BusinessRuleId:2780, Attribute:267772, Operation:Field, Event:None







//BusinessRuleId:2784, Attribute:267775, Operation:Field, Event:None
$("form#CreateProceso_Penal").on('change', '#Vinculacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Vinculacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divResultado_Vinculacion').css('display', 'block'); $('#divResultado_No_Vinculacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_No_Vinculacion' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Resultado_Vinculacion' + rowIndex));} else { $('#divResultado_No_Vinculacion').css('display', 'block'); $('#divResultado_Vinculacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_Vinculacion' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Resultado_No_Vinculacion' + rowIndex));}
});

//BusinessRuleId:2784, Attribute:267775, Operation:Field, Event:None

//BusinessRuleId:2786, Attribute:267777, Operation:Field, Event:None
$("form#CreateProceso_Penal").on('change', '#Resultado_Vinculacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_Vinculacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divplazo_investigacion_complementaria').css('display', 'block'); $('#divResultado_de_Investigacion_Complementari').css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'plazo_investigacion_complementaria' + rowIndex));} else { $('#divplazo_investigacion_complementaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'plazo_investigacion_complementaria' + rowIndex)); $("a[href='#tabFase_Escrita']").css('display', 'none'); $('#divFecha').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));$('#divHora').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex)); $('#divResultado_de_Investigacion_Complementari').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex),EvaluaQuery(" select ' '", rowIndex, nameOfTable));}
});

//BusinessRuleId:2786, Attribute:267777, Operation:Field, Event:None

//BusinessRuleId:2788, Attribute:267867, Operation:Field, Event:None
$("form#CreateProceso_Penal").on('change', '#Resultado_de_Investigacion_Complementari', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { $('#divFecha').css('display', 'block');$('#divHora').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));} else { $('#divFecha').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));$('#divHora').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));}
});

//BusinessRuleId:2788, Attribute:267867, Operation:Field, Event:None

//BusinessRuleId:2790, Attribute:267867, Operation:Field, Event:None
$("form#CreateProceso_Penal").on('change', '#Resultado_de_Investigacion_Complementari', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $("a[href='#tabFase_Escrita']").css('display', 'block');} else { $("a[href='#tabFase_Escrita']").css('display', 'none');}
});

//BusinessRuleId:2790, Attribute:267867, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2749, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Medio_de_Prueba_Presentado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Presentacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Medida_Cautelar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Proceso_Penal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Medio_de_Prueba_Presentado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Presentacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Proceso_Penal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Medio_de_Prueba_Presentado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Admitido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Proceso_Penal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Reclasificacion_Juridica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Plazo_Constitucional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Vinculacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_No_Vinculacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_Vinculacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'plazo_investigacion_complementaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'fecha_investigacion_complementaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'hora_investigacion_complementaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez_de_Control' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Entrega_de_Escrito_de_Acusacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Entrega_de_Escrito_de_Acusacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Audiencia_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Audiencia_Intermedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Acusador_Coadyudante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cumplio_descubrimiento_probatorio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdos_Probatorios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'acuerdos_probatorios_cuales_fueron' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Colegiado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Audiencia_de_Juicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Audiencia_de_Juicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fallo_del_Tribunal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'pruebas_a_desahogar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Plazo_meses' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_anios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_meses' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Reparacion_del_Dano' + rowIndex));


}
//BusinessRuleId:2749, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2761, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2761, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2761, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2761, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2763, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery("select GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:2763, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2769, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divPlazo_meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Plazo_meses' + rowIndex));$('#divTipo_de_Sentencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));$('#divcuantia_de_pena_anios').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_anios' + rowIndex));$('#divcuantia_de_pena_meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_meses' + rowIndex));$('#divMonto_de_la_Reparacion_del_Dano').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Reparacion_del_Dano' + rowIndex)); if('true' == 'true')
{
	$('#divCondiciones').css('display', 'none');
}
else
{
	$('#divCondiciones').css('display', 'block');
}} else { $('#divPlazo_meses').css('display', 'block');$('#divTipo_de_Sentencia').css('display', 'block');$('#divcuantia_de_pena_anios').css('display', 'block');$('#divcuantia_de_pena_meses').css('display', 'block');$('#divMonto_de_la_Reparacion_del_Dano').css('display', 'block'); if('false' == 'true')
{
	$('#divCondiciones').css('display', 'none');
}
else
{
	$('#divCondiciones').css('display', 'block');
}}


}
//BusinessRuleId:2769, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2772, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divPlazo_meses').css('display', 'block');$('#divMonto_de_la_Reparacion_del_Dano').css('display', 'block'); $('#divTipo_de_Sentencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Sentencia' + rowIndex));$('#divcuantia_de_pena_anios').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_anios' + rowIndex));$('#divcuantia_de_pena_meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cuantia_de_pena_meses' + rowIndex)); if('false' == 'true')
{
	$('#divCondiciones').css('display', 'none');
}
else
{
	$('#divCondiciones').css('display', 'block');
}} else { $('#divPlazo_meses').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Plazo_meses' + rowIndex));$('#divMonto_de_la_Reparacion_del_Dano').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Reparacion_del_Dano' + rowIndex));}


}
//BusinessRuleId:2772, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2777, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divJuez_Colegiado').css('display', 'block');$('#divJuez_Relator').css('display', 'block');$('#divJuez_Vocal').css('display', 'block');} else { $('#divJuez_Colegiado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Colegiado' + rowIndex));$('#divJuez_Relator').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));$('#divJuez_Vocal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));}


}
//BusinessRuleId:2777, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2779, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Imputado' + rowIndex).val();   $('#' + nameOfTable + 'Imputado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Imputado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Imputado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP=FLD[Expediente_MP]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Imputado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP=FLD[Expediente_MP]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Imputado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Imputado' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:2779, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2779, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Imputado' + rowIndex).val();   $('#' + nameOfTable + 'Imputado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Imputado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Imputado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP=FLD[Expediente_MP]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Imputado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP=FLD[Expediente_MP]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Imputado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Imputado' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:2779, Attribute:0, Operation:Object, Event:SCREENOPENING








//BusinessRuleId:2782, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Reclasificacion_Juridica' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) 
{
    $('#divDelitos a').attr('disabled', false);
	$('#divDelitos a').css("pointer-events","all");
}
else
{
	$('#divDelitos a').attr('disabled', 'disabled');
	$('#divDelitos a').css("pointer-events","none");
}


}
//BusinessRuleId:2782, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2782, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Reclasificacion_Juridica' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') )
{
	$('#divDelitos a').attr('disabled', false);
	$('#divDelitos a').css("pointer-events","all");
}
else
{
	$('#divDelitos a').attr('disabled', 'disabled');
	$('#divDelitos a').css("pointer-events","none");
}



}
//BusinessRuleId:2782, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2778, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divResultado_No_Vinculacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_No_Vinculacion' + rowIndex));$('#divResultado_Vinculacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_Vinculacion' + rowIndex));$('#divplazo_investigacion_complementaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'plazo_investigacion_complementaria' + rowIndex));$('#divFecha').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));$('#divHora').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex)); if('true' == 'true')
{
	$('#divDelitos a').attr('disabled', 'disabled');
	$('#divDelitos a').css("pointer-events","none");
}
else
{
	$('#divDelitos a').attr('disabled', '');
	$('#divDelitos a').css("pointer-events","all");
} $("a[href='#tabFase_Escrita']").css('display', 'none'); $("a[href='#tabAudiencia_Intermedia']").css('display', 'none'); $("a[href='#tabJuicio_Oral']").css('display', 'none'); $('#divResultado_de_Investigacion_Complementari').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex));

}
//BusinessRuleId:2778, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2785, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Vinculacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divResultado_Vinculacion').css('display', 'block'); $('#divResultado_No_Vinculacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_No_Vinculacion' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Resultado_Vinculacion' + rowIndex));} else { $('#divResultado_No_Vinculacion').css('display', 'block'); $('#divResultado_Vinculacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_Vinculacion' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Resultado_No_Vinculacion' + rowIndex));}

}
//BusinessRuleId:2785, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2787, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_Vinculacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divplazo_investigacion_complementaria').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'plazo_investigacion_complementaria' + rowIndex)); $('#divResultado_de_Investigacion_Complementari').css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex));} else { $('#divplazo_investigacion_complementaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'plazo_investigacion_complementaria' + rowIndex));$('#divFecha').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));$('#divHora').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex)); $('#divResultado_de_Investigacion_Complementari').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex));}

}
//BusinessRuleId:2787, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2789, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { $('#divFecha').css('display', 'block');$('#divHora').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));} else { $('#divFecha').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));$('#divHora').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));}

}
//BusinessRuleId:2789, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2789, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { $('#divFecha').css('display', 'block');$('#divHora').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));} else { $('#divFecha').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));$('#divHora').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));}

}
//BusinessRuleId:2789, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2791, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $("a[href='#tabFase_Escrita']").css('display', 'block');} else { $("a[href='#tabFase_Escrita']").css('display', 'none');}

}
//BusinessRuleId:2791, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2791, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Resultado_de_Investigacion_Complementari' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $("a[href='#tabFase_Escrita']").css('display', 'block');} else { $("a[href='#tabFase_Escrita']").css('display', 'none');}

}
//BusinessRuleId:2791, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){




//BusinessRuleId:2781, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Proceso_Penal set expediente_mp = GLOBAL[SpartanOperationId] where clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:2781, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Delitos_Proceso_Penal//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Delitos_Proceso_Penal//
}
function EjecutarValidacionesAlEliminarMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Delitos_Proceso_Penal//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Delitos_Proceso_Penal//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Delitos_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Delitos_Proceso_Penal//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Medidas_Cautelares_Proceso_Penal//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Medidas_Cautelares_Proceso_Penal//
}
function EjecutarValidacionesAlEliminarMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Medidas_Cautelares_Proceso_Penal//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Medidas_Cautelares_Proceso_Penal//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Medidas_Cautelares_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Medidas_Cautelares_Proceso_Penal//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Medios_Prueba_Imputado//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Medios_Prueba_Imputado//
}
function EjecutarValidacionesAlEliminarMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Medios_Prueba_Imputado//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Medios_Prueba_Imputado//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Medios_Prueba_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Medios_Prueba_Imputado//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Medios_Prueba_Victima//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Medios_Prueba_Victima//
}
function EjecutarValidacionesAlEliminarMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Medios_Prueba_Victima//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Medios_Prueba_Victima//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Medios_Prueba_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Medios_Prueba_Victima//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Medios_Prueba_Admitidos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Medios_Prueba_Admitidos//
}
function EjecutarValidacionesAlEliminarMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Medios_Prueba_Admitidos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Medios_Prueba_Admitidos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Medios_Prueba_Admitidos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Medios_Prueba_Admitidos//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Condiciones_Proceso_Penal//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Condiciones_Proceso_Penal//
}
function EjecutarValidacionesAlEliminarMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Condiciones_Proceso_Penal//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Condiciones_Proceso_Penal//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Condiciones_Proceso_Penal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Condiciones_Proceso_Penal//
    return result;
}

