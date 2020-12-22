var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {

//COD-MANI INI OCULTAR BOTONES
$('#Modulo_Atencion_InicialGuardarYNuevo').css('display', 'none');
$('#Modulo_Atencion_InicialGuardarYCopia').css('display', 'none');
$('#ConfigureSave').css('display', 'none');
$('#Modulo_Atencion_InicialFinalizar').css('display', 'none');
//COD-MANI END OCULTAR BOTONES

//CONVERTIR A MAYUSCULAS AL BLUR
$('input[type="text"],textarea').blur(function() {
	this.value = this.value.toUpperCase();
	});
//END CONVERTIR A MAYUSCULAS AL BLUR





//BusinessRuleId:788, Attribute:262792, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Fecha_de_Registro', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex).val()!=TryParseInt('null', 'null') && $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex).val()!=TryParseInt('null', 'null') && EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Registro]',103),103),"
+" CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Cierre]',103),103))",rowIndex, nameOfTable)<TryParseInt('0', '0') ) { alert(DecodifyText('Fecha de Cierre no puede ser anterior a la Fecha de Registro', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),'');} else {}
});


//BusinessRuleId:788, Attribute:262792, Operation:Field, Event:None

//BusinessRuleId:605, Attribute:262796, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Requiere_Traductor', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex).val()==TryParseInt('true', 'true') ) { $('#divLengua_Originaria').css('display', 'block'); $('#divIdioma').css('display', 'block');} else { $('#divLengua_Originaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex)); $('#divIdioma').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));}
});


//BusinessRuleId:605, Attribute:262796, Operation:Field, Event:None

//BusinessRuleId:790, Attribute:262796, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Requiere_Traductor', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex).val()!=TryParseInt('FALSE', 'FALSE') ) { $('#divLengua_Originaria').css('display', 'block'); $('#divIdioma').css('display', 'block');} else { $('#divLengua_Originaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex)); $('#divIdioma').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));}
});


//BusinessRuleId:790, Attribute:262796, Operation:Field, Event:None

//BusinessRuleId:608, Attribute:262797, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Lengua_Originaria', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex).val()!=TryParseInt('null', 'null') ) { DisabledControl($("#" + nameOfTable + "Idioma" + rowIndex), ("true" == "true"));} else { DisabledControl($("#" + nameOfTable + "Idioma" + rowIndex), ("false" == "true"));}
});


//BusinessRuleId:608, Attribute:262797, Operation:Field, Event:None

//BusinessRuleId:607, Attribute:262848, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Idioma', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Idioma' + rowIndex).val()!=TryParseInt('null', 'null') ) { DisabledControl($("#" + nameOfTable + "Lengua_Originaria" + rowIndex), ("true" == "true"));} else { DisabledControl($("#" + nameOfTable + "Lengua_Originaria" + rowIndex), ("false" == "true"));}
});


//BusinessRuleId:607, Attribute:262848, Operation:Field, Event:None

//BusinessRuleId:159, Attribute:262823, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Requiere_Servicios_de_Apoyo', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Requiere_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('true', 'true') ) { $("a[href='#tabServicios_de_Apoyo']").css('display', 'block'); $("a[href='#tabCanalizar']").css('display', 'none');} else { $("a[href='#tabServicios_de_Apoyo']").css('display', 'none'); $("a[href='#tabCanalizar']").css('display', 'block');}
});


//BusinessRuleId:159, Attribute:262823, Operation:Field, Event:None

//BusinessRuleId:43, Attribute:262844, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Persona_Moral', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Persona_Moral' + rowIndex).val()==TryParseInt('TRUE', 'TRUE') ) { $("a[href='#tabDatos_de_la_Persona_Moral']").css('display', 'block');} else { $("a[href='#tabDatos_de_la_Persona_Moral']").css('display', 'none');}
});


//BusinessRuleId:43, Attribute:262844, Operation:Field, Event:None

//BusinessRuleId:756, Attribute:262802, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Fecha_del_Hecho', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex).val()!=TryParseInt('null', 'null') && EvaluaQuery("select DATEDIFF(day,convert(date,(CONVERT(varchar(10),'FLD[Fecha_del_Hecho]',103)),103),"
+" convert(date,(CONVERT(varchar(10),GETDATE(),103)),103))",rowIndex, nameOfTable)<TryParseInt('0', '0') ) { alert(DecodifyText('Fecha del Hecho No Puede Ser Mayor a Fecha Actual', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex),'');} else {}
});


//BusinessRuleId:756, Attribute:262802, Operation:Field, Event:None

//BusinessRuleId:787, Attribute:262802, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Fecha_del_Hecho', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("if  'FLD[Hora_del_Hecho]' > (Select CONVERT(varchar(10),Getdate(),108))"
+" "
+" begin "
+" "
+" select 1"
+" "
+" end"
+" "
+" else "
+" "
+" begin "
+" "
+" select 2"
+" "
+" end",rowIndex, nameOfTable)==TryParseInt('1', '1') && $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex).val()!=TryParseInt('null', 'null') && $('#' + nameOfTable + 'Hora_del_Hecho' + rowIndex).val()!=TryParseInt('null', 'null') && $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex).val()==EvaluaQuery("select CONVERT(varchar(10),Getdate(),103)",rowIndex, nameOfTable) ) { alert(DecodifyText('La Hora del Hecho no puede ser mayor a la hora actual', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_del_Hecho' + rowIndex),'');} else {}
});


//BusinessRuleId:787, Attribute:262802, Operation:Field, Event:None

//BusinessRuleId:166, Attribute:262814, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Estado_de_los_Hechos', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,Nombre from Municipio where Estado = FLD[Estado_de_los_Hechos] Order by Nombre", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,Nombre from Municipio where Estado = FLD[Estado_de_los_Hechos] Order by Nombre", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:166, Attribute:262814, Operation:Field, Event:None

//BusinessRuleId:167, Attribute:262813, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Municipio_de_los_Hechos', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave, Nombre from Colonia where Municipio =FLD[Municipio_de_los_Hechos] Order by Nombre", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave, Nombre from Colonia where Municipio =FLD[Municipio_de_los_Hechos] Order by Nombre", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:167, Attribute:262813, Operation:Field, Event:None

//BusinessRuleId:621, Attribute:262808, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Colonia_de_los_Hechos', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex),EvaluaQuery("select codigo_postal from Codigo_Postal where Colonia=FLD[Colonia_de_los_Hechos]", rowIndex, nameOfTable));} else {}
});


//BusinessRuleId:621, Attribute:262808, Operation:Field, Event:None

//BusinessRuleId:1029, Attribute:262808, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Colonia_de_los_Hechos', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') ) { CreateSessionVar('globalcolonia', '0');} else {}
});


//BusinessRuleId:1029, Attribute:262808, Operation:Field, Event:None

//BusinessRuleId:174, Attribute:262809, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('keyup', '#Codigo_Postal_de_los_Hechos', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') ) {} else {}
});


//BusinessRuleId:174, Attribute:262809, Operation:Field, Event:None



//BusinessRuleId:789, Attribute:262852, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Fecha_de_Cierre', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("if  'FLD[Hora_de_Cierre]' > 'FLD[Hora_de_Registro]'"
+" "
+" begin "
+" "
+" select 1"
+" "
+" end"
+" "
+" else "
+" "
+" begin "
+" "
+" select 2"
+" "
+" end",rowIndex, nameOfTable)==TryParseInt('2', '2') && $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex).val()!=TryParseInt('null', 'null') && $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex).val()!=TryParseInt('null', 'null') && EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Registro]',103),103),"
+" CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Cierre]',103),103))",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { alert(DecodifyText('La Hora de Cierre no puede ser menor a la Hora de Registro', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),'');} else {}
});


//BusinessRuleId:789, Attribute:262852, Operation:Field, Event:None



















//BusinessRuleId:2038, Attribute:265574, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Turno_Asignado', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Turno_Asignado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Nombres_turno' + rowIndex),EvaluaQuery(" SELECT NOMBRES FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Apellido_Paterno_turno' + rowIndex),EvaluaQuery(" SELECT Apellido_Paterno FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Apellido_Materno_turno' + rowIndex),EvaluaQuery(" SELECT Apellido_Materno FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Sexo_turno' + rowIndex),EvaluaQuery(" SELECT Sexo FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Edad_turno' + rowIndex),EvaluaQuery(" SELECT Edad FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Tipo_de_Atencion_turno' + rowIndex),EvaluaQuery(" SELECT Tipo_de_Atencion FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Tipo_de_Identificacion_turno' + rowIndex),EvaluaQuery(" SELECT Tipo_de_Identificacion FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Numero_de_Identificacion_turno' + rowIndex),EvaluaQuery(" SELECT Numero_de_Identificacion FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Tipo_de_Urgencia_turno' + rowIndex),EvaluaQuery(" SELECT Tipo_de_Urgencia FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex),EvaluaQuery(" SELECT Motivo_Finalizacion_Turno FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Observaciones_turno' + rowIndex),EvaluaQuery(" SELECT Observaciones FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Urgencia_turno' + rowIndex),EvaluaQuery(" SELECT Urgencia FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]", rowIndex, nameOfTable));} else { AsignarValor($('#' + nameOfTable + 'Nombres_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Apellido_Paterno_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Apellido_Materno_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Sexo_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Edad_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Tipo_de_Atencion_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Tipo_de_Identificacion_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Numero_de_Identificacion_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Urgencia_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Tipo_de_Urgencia_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Observaciones_turno' + rowIndex),EvaluaQuery("SELECT ISNULL('', '')", rowIndex, nameOfTable));}
});


//BusinessRuleId:2038, Attribute:265574, Operation:Field, Event:None



//BusinessRuleId:210, Attribute:262832, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Se_Acepta_Acuerdo', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Se_Acepta_Acuerdo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divMotivo_de_Rechazo_de_Acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));} else { $('#divMotivo_de_Rechazo_de_Acuerdo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));}
});


//BusinessRuleId:210, Attribute:262832, Operation:Field, Event:None







//BusinessRuleId:2039, Attribute:265574, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Turno_Asignado', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("SELECT Urgencia FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divTipo_de_Urgencia_turno').css('display', 'block'); $('#divUrgencia_turno').css('display', 'block');} else { $('#divTipo_de_Urgencia_turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia_turno' + rowIndex)); $('#divUrgencia_turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Urgencia_turno' + rowIndex));}
});


//BusinessRuleId:2039, Attribute:265574, Operation:Field, Event:None



//BusinessRuleId:2071, Attribute:262851, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Cerrar', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Cerrar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));} else { SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));}
});


//BusinessRuleId:2071, Attribute:262851, Operation:Field, Event:None





//BusinessRuleId:2510, Attribute:262851, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Cerrar', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Cerrar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Fecha_de_Cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));} AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Hora_de_Cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));} DisabledControl($("#" + nameOfTable + "Estatus2" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex));} AsignarValor($('#' + nameOfTable + 'Estatus2' + rowIndex),'0');} else { DisabledControl($("#" + nameOfTable + "Fecha_de_Cierre" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Cierre" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));} AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),' ');AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),' '); DisabledControl($("#" + nameOfTable + "Estatus2" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex));}}
});


//BusinessRuleId:2510, Attribute:262851, Operation:Field, Event:None

//BusinessRuleId:2533, Attribute:262816, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Estatus2', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Estatus2' + rowIndex),nameOfTable,rowIndex)>TryParseInt('0', '0') ) { DisabledControl($("#" + nameOfTable + "Cerrar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cerrar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));} AsignarValor($('#' + nameOfTable + 'Cerrar' + rowIndex),'false'); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),' ');AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),' ');} else { DisabledControl($("#" + nameOfTable + "Cerrar" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cerrar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Cierre" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Cierre" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));}}
});


//BusinessRuleId:2533, Attribute:262816, Operation:Field, Event:None

//BusinessRuleId:2868, Attribute:262816, Operation:Field, Event:None
$("form#CreateModulo_Atencion_Inicial").on('change', '#Estatus2', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Estatus2' + rowIndex),nameOfTable,rowIndex)==TryParseInt('6', '6') ) { $('#divUnidad_canaliza').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));} else { $('#divUnidad_canaliza').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}
});


//BusinessRuleId:2868, Attribute:262816, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {



//BusinessRuleId:41, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); $("a[href='#tabBitacora_de_Cambios']").css('display', 'none'); $('#divEstatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));


}
//BusinessRuleId:41, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:41, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); $("a[href='#tabBitacora_de_Cambios']").css('display', 'none'); $('#divEstatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));


}
//BusinessRuleId:41, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:46, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divAutoriza_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Autoriza_Traductor' + rowIndex)); $('#divEstatus2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex)); $('#divFinalizar_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Finalizar_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex)); $('#divZona_de_los_Hechos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Zona_de_los_Hechos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar_Cita' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exrterior_de_los_Hechos' + rowIndex)); $('#divTurno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno' + rowIndex)); DisabledControl($("#" + nameOfTable + "Agencia" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Delegacion" + rowIndex), ("true" == "true")); $('#divNUC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'NUC' + rowIndex)); $('#divGenerar_Cita').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar_Cita' + rowIndex)); $('#divFecha_de_Vencimiento_1').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Vencimiento_1' + rowIndex));


}
//BusinessRuleId:46, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:46, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divAutoriza_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Autoriza_Traductor' + rowIndex)); $('#divEstatus2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex)); $('#divFinalizar_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Finalizar_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex)); $('#divZona_de_los_Hechos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Zona_de_los_Hechos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar_Cita' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exrterior_de_los_Hechos' + rowIndex)); $('#divTurno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno' + rowIndex)); DisabledControl($("#" + nameOfTable + "Agencia" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Delegacion" + rowIndex), ("true" == "true")); $('#divNUC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'NUC' + rowIndex)); $('#divGenerar_Cita').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar_Cita' + rowIndex)); $('#divFecha_de_Vencimiento_1').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Vencimiento_1' + rowIndex));


}
//BusinessRuleId:46, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:46, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divAutoriza_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Autoriza_Traductor' + rowIndex)); $('#divEstatus2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex)); $('#divFinalizar_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Finalizar_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex)); $('#divZona_de_los_Hechos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Zona_de_los_Hechos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar_Cita' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exrterior_de_los_Hechos' + rowIndex)); $('#divTurno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno' + rowIndex)); DisabledControl($("#" + nameOfTable + "Agencia" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Delegacion" + rowIndex), ("true" == "true")); $('#divNUC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'NUC' + rowIndex)); $('#divGenerar_Cita').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar_Cita' + rowIndex)); $('#divFecha_de_Vencimiento_1').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Vencimiento_1' + rowIndex));


}
//BusinessRuleId:46, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:50, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divEstatus2').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex));} else {}


}
//BusinessRuleId:50, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:50, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divEstatus2').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex));} else {}


}
//BusinessRuleId:50, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:50, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divEstatus2').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex));} else {}


}
//BusinessRuleId:50, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:68, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)==TryParseInt('4', '4') && $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex).val()==TryParseInt('true', 'true') ) { $('#divAutoriza_Traductor').css('display', 'block');} else {}


}
//BusinessRuleId:68, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:68, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)==TryParseInt('4', '4') && $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex).val()==TryParseInt('true', 'true') ) { $('#divAutoriza_Traductor').css('display', 'block');} else {}


}
//BusinessRuleId:68, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:87, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "NUAT" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:87, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:87, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "NUAT" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:87, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:87, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "NUAT" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true")); DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:87, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:149, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){



}
//BusinessRuleId:149, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:160, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('3', '3') || $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('5', '5') ) { $("a[href='#tabServicios_de_Apoyo']").css('display', 'block');} else {}


}
//BusinessRuleId:160, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:160, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('3', '3') || $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('5', '5') ) { $("a[href='#tabServicios_de_Apoyo']").css('display', 'block');} else {}


}
//BusinessRuleId:160, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:160, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('3', '3') || $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('5', '5') ) { $("a[href='#tabServicios_de_Apoyo']").css('display', 'block');} else {}


}
//BusinessRuleId:160, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:176, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Orientador' + rowIndex).val();   $('#' + nameOfTable + 'Orientador' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Orientador' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Orientador' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary(""
+" "
+" select IdUsuario,Nombre from TTUsuarios where IdGrupoUsuarios=4", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Orientador' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary(""
+" "
+" select IdUsuario,Nombre from TTUsuarios where IdGrupoUsuarios=4", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Orientador' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Orientador' + rowIndex).val(valor).trigger('change'); $('#divOrientador').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex));


}
//BusinessRuleId:176, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:176, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Orientador' + rowIndex).val();   $('#' + nameOfTable + 'Orientador' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Orientador' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Orientador' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary(""
+" "
+" select IdUsuario,Nombre from TTUsuarios where IdGrupoUsuarios=4", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Orientador' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary(""
+" "
+" select IdUsuario,Nombre from TTUsuarios where IdGrupoUsuarios=4", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Orientador' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Orientador' + rowIndex).val(valor).trigger('change'); $('#divOrientador').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Orientador' + rowIndex));


}
//BusinessRuleId:176, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:181, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divFinalizar_Servicios_de_Apoyo').css('display', 'block');


}
//BusinessRuleId:181, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:183, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSecuencial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Secuencial' + rowIndex)); $('#divAno_Actual').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ano_Actual' + rowIndex));


}
//BusinessRuleId:183, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:183, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divSecuencial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Secuencial' + rowIndex)); $('#divAno_Actual').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ano_Actual' + rowIndex));


}
//BusinessRuleId:183, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:183, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divSecuencial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Secuencial' + rowIndex)); $('#divAno_Actual').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ano_Actual' + rowIndex));


}
//BusinessRuleId:183, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:190, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Requiere_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('TRUE', 'TRUE') ) { $("a[href='#tabServicios_de_Apoyo']").css('display', 'block');} else { $("a[href='#tabServicios_de_Apoyo']").css('display', 'none');}


}
//BusinessRuleId:190, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:190, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Requiere_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('TRUE', 'TRUE') ) { $("a[href='#tabServicios_de_Apoyo']").css('display', 'block');} else { $("a[href='#tabServicios_de_Apoyo']").css('display', 'none');}


}
//BusinessRuleId:190, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:190, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Requiere_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('TRUE', 'TRUE') ) { $("a[href='#tabServicios_de_Apoyo']").css('display', 'block');} else { $("a[href='#tabServicios_de_Apoyo']").css('display', 'none');}


}
//BusinessRuleId:190, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:193, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Turno' + rowIndex),EvaluaQuery("if ("
+" "
+" select convert(date,fecha_de_registro,103)"
+" "
+"  from Modulo_Atencion_Inicial "
+" "
+" where Clave =(select MAX(clave) from Modulo_Atencion_Inicial where Turno is not null))<>"
+" "
+"  (select convert(date,GETDATE (),103))"
+" "
+" begin "
+" "
+" select 1 "
+" "
+" end"
+" "
+" else "
+" "
+" begin"
+" "
+" select Turno +1"
+" "
+"  from Modulo_Atencion_Inicial "
+" "
+" where Clave =(select MAX(clave) from Modulo_Atencion_Inicial where Turno is not null )"
+" "
+" end", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Turno" + rowIndex), ("true" == "true"));} else {}


}
//BusinessRuleId:193, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:193, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Turno' + rowIndex),EvaluaQuery("if ("
+" "
+" select convert(date,fecha_de_registro,103)"
+" "
+"  from Modulo_Atencion_Inicial "
+" "
+" where Clave =(select MAX(clave) from Modulo_Atencion_Inicial where Turno is not null))<>"
+" "
+"  (select convert(date,GETDATE (),103))"
+" "
+" begin "
+" "
+" select 1 "
+" "
+" end"
+" "
+" else "
+" "
+" begin"
+" "
+" select Turno +1"
+" "
+"  from Modulo_Atencion_Inicial "
+" "
+" where Clave =(select MAX(clave) from Modulo_Atencion_Inicial where Turno is not null )"
+" "
+" end", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Turno" + rowIndex), ("true" == "true"));} else {}


}
//BusinessRuleId:193, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:193, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Turno' + rowIndex),EvaluaQuery("if ("
+" "
+" select convert(date,fecha_de_registro,103)"
+" "
+"  from Modulo_Atencion_Inicial "
+" "
+" where Clave =(select MAX(clave) from Modulo_Atencion_Inicial where Turno is not null))<>"
+" "
+"  (select convert(date,GETDATE (),103))"
+" "
+" begin "
+" "
+" select 1 "
+" "
+" end"
+" "
+" else "
+" "
+" begin"
+" "
+" select Turno +1"
+" "
+"  from Modulo_Atencion_Inicial "
+" "
+" where Clave =(select MAX(clave) from Modulo_Atencion_Inicial where Turno is not null )"
+" "
+" end", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Turno" + rowIndex), ("true" == "true"));} else {}


}
//BusinessRuleId:193, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:203, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave,Nombre from Estado ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave,Nombre from Estado ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:203, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:203, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave,Nombre from Estado ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave,Nombre from Estado ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:203, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:211, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()!=TryParseInt('6', '6') ) { $("a[href='#tabDatos_del_Acuerdo']").css('display', 'none');} else {}


}
//BusinessRuleId:211, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:211, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()!=TryParseInt('6', '6') ) { $("a[href='#tabDatos_del_Acuerdo']").css('display', 'none');} else {}


}
//BusinessRuleId:211, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:211, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()!=TryParseInt('6', '6') ) { $("a[href='#tabDatos_del_Acuerdo']").css('display', 'none');} else {}


}
//BusinessRuleId:211, Attribute:0, Operation:Object, Event:SCREENOPENING


//BusinessRuleId:252, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divEnviar_a_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Enviar_a_MP' + rowIndex)); $('#divCorreccion_de_Estatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Correccion_de_Estatus' + rowIndex));


}
//BusinessRuleId:252, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:252, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divEnviar_a_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Enviar_a_MP' + rowIndex)); $('#divCorreccion_de_Estatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Correccion_de_Estatus' + rowIndex));


}
//BusinessRuleId:252, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:252, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divEnviar_a_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Enviar_a_MP' + rowIndex)); $('#divCorreccion_de_Estatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Correccion_de_Estatus' + rowIndex));


}
//BusinessRuleId:252, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:253, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)==TryParseInt('6', '6') ) { $('#divEnviar_a_MP').css('display', 'block'); $('#divCorreccion_de_Estatus').css('display', 'block');} else {}


}
//BusinessRuleId:253, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:319, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),2);


}
//BusinessRuleId:319, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:321, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('6', '6') || $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('11', '11') ) { $("a[href='#tabDatos_del_Acuerdo']").css('display', 'block');} else {}


}
//BusinessRuleId:321, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:322, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery("select convert(varchar(8),GETDATE(),108)"
+" "
+" ", rowIndex, nameOfTable));} else {}


}
//BusinessRuleId:322, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:322, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery("select convert(varchar(8),GETDATE(),108)"
+" "
+" ", rowIndex, nameOfTable));} else {}


}
//BusinessRuleId:322, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:322, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery("select convert(varchar(8),GETDATE(),108)"
+" "
+" ", rowIndex, nameOfTable));} else {}


}
//BusinessRuleId:322, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:445, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpedientes_Relacionados').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expedientes_Relacionados' + rowIndex));


}
//BusinessRuleId:445, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:445, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpedientes_Relacionados').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expedientes_Relacionados' + rowIndex));


}
//BusinessRuleId:445, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:445, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpedientes_Relacionados').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expedientes_Relacionados' + rowIndex));


}
//BusinessRuleId:445, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:453, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('11', '11') ) { $('#divCerrar').css('display', 'block');} else {}


}
//BusinessRuleId:453, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:453, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('11', '11') ) { $('#divCerrar').css('display', 'block');} else {}


}
//BusinessRuleId:453, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:453, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('11', '11') ) { $('#divCerrar').css('display', 'block');} else {}


}
//BusinessRuleId:453, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:606, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divLengua_Originaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex)); $('#divIdioma').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));


}
//BusinessRuleId:606, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:606, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divLengua_Originaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex)); $('#divIdioma').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));


}
//BusinessRuleId:606, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:606, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divLengua_Originaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex)); $('#divIdioma').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));


}
//BusinessRuleId:606, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:635, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Delegacion' + rowIndex),EvaluaQuery("select Delegacion from Usuario where nombre=GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:635, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:635, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Delegacion' + rowIndex),EvaluaQuery("select Delegacion from Usuario where nombre=GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:635, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:635, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Delegacion' + rowIndex),EvaluaQuery("select Delegacion from Usuario where nombre=GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:635, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:636, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Agencia' + rowIndex),EvaluaQuery("select Agencia from Usuario where nombre=FLD[Usuario_que_Registra]", rowIndex, nameOfTable));


}
//BusinessRuleId:636, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:636, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Agencia' + rowIndex),EvaluaQuery("select Agencia from Usuario where nombre=FLD[Usuario_que_Registra]", rowIndex, nameOfTable));


}
//BusinessRuleId:636, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:636, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Agencia' + rowIndex),EvaluaQuery("select Agencia from Usuario where nombre=FLD[Usuario_que_Registra]", rowIndex, nameOfTable));


}
//BusinessRuleId:636, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:637, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex),21); var valor = $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,Nombre from Municipio where Estado =21", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,Nombre from Municipio where Estado =21", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val(valor).trigger('change'); AsignarValor($('#' + nameOfTable + 'Pais_de_los_Hechos' + rowIndex),1); AsignarValor($('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex),1682);} else {}


}
//BusinessRuleId:637, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:637, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex),21); var valor = $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,Nombre from Municipio where Estado =21", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,Nombre from Municipio where Estado =21", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val(valor).trigger('change'); AsignarValor($('#' + nameOfTable + 'Pais_de_los_Hechos' + rowIndex),1); AsignarValor($('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex),1682);} else {}


}
//BusinessRuleId:637, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:637, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex),21); var valor = $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,Nombre from Municipio where Estado =21", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,Nombre from Municipio where Estado =21", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val(valor).trigger('change'); AsignarValor($('#' + nameOfTable + 'Pais_de_los_Hechos' + rowIndex),1); AsignarValor($('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex),1682);} else {}


}
//BusinessRuleId:637, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:686, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'NUC' + rowIndex));


}
//BusinessRuleId:686, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:686, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'NUC' + rowIndex));


}
//BusinessRuleId:686, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:686, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'NUC' + rowIndex));


}
//BusinessRuleId:686, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:704, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){



}
//BusinessRuleId:704, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:704, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){



}
//BusinessRuleId:704, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:704, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){



}
//BusinessRuleId:704, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:744, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Persona_Moral' + rowIndex).val()==TryParseInt('null', 'null') || $('#' + nameOfTable + 'Persona_Moral' + rowIndex).val()==TryParseInt('FALSE', 'FALSE') || $('#' + nameOfTable + 'Persona_Moral' + rowIndex).val()==TryParseInt('', '') ) { $("a[href='#tabDatos_de_la_Persona_Moral']").css('display', 'none');} else { $("a[href='#tabDatos_de_la_Persona_Moral']").css('display', 'block');}


}
//BusinessRuleId:744, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:744, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Persona_Moral' + rowIndex).val()==TryParseInt('null', 'null') || $('#' + nameOfTable + 'Persona_Moral' + rowIndex).val()==TryParseInt('FALSE', 'FALSE') || $('#' + nameOfTable + 'Persona_Moral' + rowIndex).val()==TryParseInt('', '') ) { $("a[href='#tabDatos_de_la_Persona_Moral']").css('display', 'none');} else { $("a[href='#tabDatos_de_la_Persona_Moral']").css('display', 'block');}


}
//BusinessRuleId:744, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:744, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Persona_Moral' + rowIndex).val()==TryParseInt('null', 'null') || $('#' + nameOfTable + 'Persona_Moral' + rowIndex).val()==TryParseInt('FALSE', 'FALSE') || $('#' + nameOfTable + 'Persona_Moral' + rowIndex).val()==TryParseInt('', '') ) { $("a[href='#tabDatos_de_la_Persona_Moral']").css('display', 'none');} else { $("a[href='#tabDatos_de_la_Persona_Moral']").css('display', 'block');}


}
//BusinessRuleId:744, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:974, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre from Municipio where Estado= FLD[Estado_de_los_Hechos] Order By nombre", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre from Municipio where Estado= FLD[Estado_de_los_Hechos] Order By nombre", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val(valor).trigger('change');} else {}


}
//BusinessRuleId:974, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:974, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre from Municipio where Estado= FLD[Estado_de_los_Hechos] Order By nombre", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre from Municipio where Estado= FLD[Estado_de_los_Hechos] Order By nombre", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val(valor).trigger('change');} else {}


}
//BusinessRuleId:974, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:974, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre from Municipio where Estado= FLD[Estado_de_los_Hechos] Order By nombre", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre from Municipio where Estado= FLD[Estado_de_los_Hechos] Order By nombre", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val(valor).trigger('change');} else {}


}
//BusinessRuleId:974, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1022, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){



}
//BusinessRuleId:1022, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1022, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){



}
//BusinessRuleId:1022, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1022, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){



}
//BusinessRuleId:1022, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1026, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre from municipio where estado=(select estado_de_los_hechos from modulo_atencion_inicial where Clave=FLD[Clave])", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre from municipio where estado=(select estado_de_los_hechos from modulo_atencion_inicial where Clave=FLD[Clave])", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex).val(valor).trigger('change'); AsignarValor($('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex),EvaluaQuery("select municipio_de_los_hechos from modulo_atencion_inicial where clave=FLD[Clave]", rowIndex, nameOfTable));


}
//BusinessRuleId:1026, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1031, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE,NOMBRE FROM COLONIA WHERE MUNICIPIO =(select Municipio from Modulo_Atencion_Inicial where Clave=FLD[Clave])"
+" "
+" ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE,NOMBRE FROM COLONIA WHERE MUNICIPIO =(select Municipio from Modulo_Atencion_Inicial where Clave=FLD[Clave])"
+" "
+" ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex).val(valor).trigger('change'); AsignarValor($('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex),EvaluaQuery("select colonia_de_los_hechos from Modulo_Atencion_Inicial where Clave=FLD[Clave]", rowIndex, nameOfTable));} else {}


}
//BusinessRuleId:1031, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1193, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') && EvaluaQuery("select pais_de_los_hechos from modulo_atencion_inicial where clave =FLD[Clave]",rowIndex, nameOfTable)!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Pais_de_los_Hechos' + rowIndex),EvaluaQuery("select Pais_de_los_Hechos from modulo_atencion_inicial where clave =FLD[Clave] "
+" "
+" ", rowIndex, nameOfTable));} else {}


}
//BusinessRuleId:1193, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1194, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex).val()!=TryParseInt('null', 'null') && EvaluaQuery("select estado_de_los_hechos from modulo_atencion_inicial where clave =FLD[Clave]",rowIndex, nameOfTable)!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex),EvaluaQuery("select estado_de_los_hechos from modulo_atencion_inicial where clave =FLD[Clave]", rowIndex, nameOfTable));} else {}


}
//BusinessRuleId:1194, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1259, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divEspecialistaJA').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'EspecialistaJA' + rowIndex)); $('#divCampo_Oculto1').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Campo_Oculto1' + rowIndex)); $('#divCampo_Oculto2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Campo_Oculto2' + rowIndex)); $('#divCampo_Oculto3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Campo_Oculto3' + rowIndex)); $('#divJefeMPO').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'JefeMPO' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'JefeMPO' + rowIndex));


}
//BusinessRuleId:1259, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1259, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divEspecialistaJA').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'EspecialistaJA' + rowIndex)); $('#divCampo_Oculto1').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Campo_Oculto1' + rowIndex)); $('#divCampo_Oculto2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Campo_Oculto2' + rowIndex)); $('#divCampo_Oculto3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Campo_Oculto3' + rowIndex)); $('#divJefeMPO').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'JefeMPO' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'JefeMPO' + rowIndex));


}
//BusinessRuleId:1259, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1259, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divEspecialistaJA').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'EspecialistaJA' + rowIndex)); $('#divCampo_Oculto1').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Campo_Oculto1' + rowIndex)); $('#divCampo_Oculto2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Campo_Oculto2' + rowIndex)); $('#divCampo_Oculto3').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Campo_Oculto3' + rowIndex)); $('#divJefeMPO').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'JefeMPO' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'JefeMPO' + rowIndex));


}
//BusinessRuleId:1259, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1276, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divRequiere_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));


}
//BusinessRuleId:1276, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1276, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divRequiere_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));


}
//BusinessRuleId:1276, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1276, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divRequiere_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));


}
//BusinessRuleId:1276, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1304, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divCoordinadorJA').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CoordinadorJA' + rowIndex)); $('#divEspJA').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'EspJA' + rowIndex));


}
//BusinessRuleId:1304, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1304, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divCoordinadorJA').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CoordinadorJA' + rowIndex)); $('#divEspJA').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'EspJA' + rowIndex));


}
//BusinessRuleId:1304, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1407, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); $('#divNombre_de_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Remitente' + rowIndex)); $('#divApellido_Paterno_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Remitente' + rowIndex)); $('#divApellido_Materno_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Remitente' + rowIndex)); $('#divFecha_en_que_llega_para_validacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_para_validacion' + rowIndex));


}
//BusinessRuleId:1407, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1408, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).val()!=TryParseInt('null', 'null') ) { $('#divNumero_de_Expediente').css('display', 'block'); $('#divNombre_de_Remitente').css('display', 'block'); $('#divApellido_Paterno_del_Remitente').css('display', 'block'); $('#divApellido_Materno_del_Remitente').css('display', 'block'); $('#divFecha_en_que_llega_para_validacion').css('display', 'block');} else { $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); $('#divNombre_de_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Remitente' + rowIndex)); $('#divApellido_Paterno_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Remitente' + rowIndex)); $('#divApellido_Materno_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Remitente' + rowIndex)); $('#divFecha_en_que_llega_para_validacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_para_validacion' + rowIndex));}


}
//BusinessRuleId:1408, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1408, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).val()!=TryParseInt('null', 'null') ) { $('#divNumero_de_Expediente').css('display', 'block'); $('#divNombre_de_Remitente').css('display', 'block'); $('#divApellido_Paterno_del_Remitente').css('display', 'block'); $('#divApellido_Materno_del_Remitente').css('display', 'block'); $('#divFecha_en_que_llega_para_validacion').css('display', 'block');} else { $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); $('#divNombre_de_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Remitente' + rowIndex)); $('#divApellido_Paterno_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Remitente' + rowIndex)); $('#divApellido_Materno_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Remitente' + rowIndex)); $('#divFecha_en_que_llega_para_validacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_para_validacion' + rowIndex));}


}
//BusinessRuleId:1408, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1454, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)!=TryParseInt('6', '6') && EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)!=TryParseInt('12', '12') ) { $("a[href='#tabHistorial_de_movimientos']").css('display', 'none');} else {}


}
//BusinessRuleId:1454, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1454, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)!=TryParseInt('6', '6') && EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)!=TryParseInt('12', '12') ) { $("a[href='#tabHistorial_de_movimientos']").css('display', 'none');} else {}


}
//BusinessRuleId:1454, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1454, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)!=TryParseInt('6', '6') && EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)!=TryParseInt('12', '12') ) { $("a[href='#tabHistorial_de_movimientos']").css('display', 'none');} else {}


}
//BusinessRuleId:1454, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1463, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){



}
//BusinessRuleId:1463, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1463, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){



}
//BusinessRuleId:1463, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1463, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){



}
//BusinessRuleId:1463, Attribute:0, Operation:Object, Event:SCREENOPENING


//BusinessRuleId:224, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'NUAT' + rowIndex).val()==TryParseInt('null', 'null') && $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Folio' + rowIndex),'Automático'); AsignarValor($('#' + nameOfTable + 'NUAT' + rowIndex),'Automático');} else {}


}
//BusinessRuleId:224, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:224, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'NUAT' + rowIndex).val()==TryParseInt('null', 'null') && $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex).val()==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Folio' + rowIndex),'Automático'); AsignarValor($('#' + nameOfTable + 'NUAT' + rowIndex),'Automático');} else {}


}
//BusinessRuleId:224, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:1835, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery(" select name from spartan_user where id_user=GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:1835, Attribute:0, Operation:Object, Event:SCREENOPENING




//BusinessRuleId:1836, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()!=TryParseInt('6', '6') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex)); $("a[href='#tabDatos_del_Acuerdo']").css('display', 'none');} else { SetRequiredToControl( $('#' + nameOfTable + 'Se_Acepta_Acuerdo' + rowIndex)); $("a[href='#tabDatos_del_Acuerdo']").css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));}


}
//BusinessRuleId:1836, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1836, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()!=TryParseInt('6', '6') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex)); $("a[href='#tabDatos_del_Acuerdo']").css('display', 'none');} else { SetRequiredToControl( $('#' + nameOfTable + 'Se_Acepta_Acuerdo' + rowIndex)); $("a[href='#tabDatos_del_Acuerdo']").css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));}


}
//BusinessRuleId:1836, Attribute:0, Operation:Object, Event:SCREENOPENING


//BusinessRuleId:1261, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exrterior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));


}
//BusinessRuleId:1261, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1261, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exrterior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));


}
//BusinessRuleId:1261, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1261, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exrterior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));


}
//BusinessRuleId:1261, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1837, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1837, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1837, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1837, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1837, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1837, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1839, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1839, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1839, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1839, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1839, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1839, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1840, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1840, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1840, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1840, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1840, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1840, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1842, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1842, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1842, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1842, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1842, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1842, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1844, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1844, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1844, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1844, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1844, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1844, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1846, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1846, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1846, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1846, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1846, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1846, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1848, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1848, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1848, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1848, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1848, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1848, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1850, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1850, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1850, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1850, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1850, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1850, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1852, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1852, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1852, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1852, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1852, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1852, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1854, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1854, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1854, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1854, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1854, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1854, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1856, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1856, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1856, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1856, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1856, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:1856, Attribute:0, Operation:Object, Event:SCREENOPENING

























//BusinessRuleId:1893, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $("a[href='#tabCanalizar']").css('display', 'none'); $("a[href='#tabDatos_de_los_Hechos_en_MPO']").css('display', 'none'); $("a[href='#tabBitacora_de_Coincidencias']").css('display', 'none'); $("a[href='#tabCierre']").css('display', 'none');


}
//BusinessRuleId:1893, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:1894, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Unidad' + rowIndex),EvaluaQuery(" SELECT CLAVE FROM UNIDAD WHERE CLAVE = (SELECT UNIDAD FROM Relacion_Unidad_Usuario WHERE USUARIO = GLOBAL[USERID])", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex),EvaluaQuery("SELECT NOMBRE FROM MUNICIPIO WHERE CLAVE = (SELECT CLAVE_DE_MUNICIPIO FROM UNIDAD WHERE CLAVE = (SELECT UNIDAD FROM Relacion_Unidad_Usuario WHERE USUARIO = GLOBAL[USERID]))", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Region' + rowIndex),EvaluaQuery(" SELECT CLAVE_DE_REGION FROM UNIDAD WHERE CLAVE = (SELECT UNIDAD FROM Relacion_Unidad_Usuario WHERE USUARIO = GLOBAL[USERID])", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));}


}
//BusinessRuleId:1894, Attribute:0, Operation:Object, Event:SCREENOPENING






//BusinessRuleId:1913, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divDelegacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delegacion' + rowIndex));$('#divAgencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex));$('#divNombres_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_del_Remitente' + rowIndex)); $("a[href='#tabDatos_Generales']").css('display', 'none'); $("a[href='#tabCampos_Ocultos']").css('display', 'none');} else {}


}
//BusinessRuleId:1913, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1913, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divDelegacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delegacion' + rowIndex));$('#divAgencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex));$('#divNombres_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_del_Remitente' + rowIndex)); $("a[href='#tabDatos_Generales']").css('display', 'none'); $("a[href='#tabCampos_Ocultos']").css('display', 'none');} else {}


}
//BusinessRuleId:1913, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1913, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divDelegacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delegacion' + rowIndex));$('#divAgencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex));$('#divNombres_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_del_Remitente' + rowIndex)); $("a[href='#tabDatos_Generales']").css('display', 'none'); $("a[href='#tabCampos_Ocultos']").css('display', 'none');} else {}


}
//BusinessRuleId:1913, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1946, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno_Asignado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Detenido' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NIC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Detenido' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Puesto_a_Disposicion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitar_Servicos_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Expedientes_Relacionados' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar_Cita' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_del_Remitente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Remitente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Remitente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_para_validacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Delegacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Ministerio_Publico_en_Turno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Oficio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Delegacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitar_Diligencias' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno_Asignado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_Caso' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Inicio_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_para_el_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_de_Danos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Acepta_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Inicio_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_del_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cumplimiento_del_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_para_el_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_de_Danos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Acepta_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_generados_en_MASC' + rowIndex));


}
//BusinessRuleId:1946, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1946, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno_Asignado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Detenido' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NIC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Detenido' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Puesto_a_Disposicion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitar_Servicos_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Expedientes_Relacionados' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar_Cita' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_del_Remitente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Remitente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Remitente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_para_validacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Delegacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Ministerio_Publico_en_Turno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Oficio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Delegacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitar_Diligencias' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno_Asignado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_Caso' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Inicio_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_para_el_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_de_Danos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Acepta_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Inicio_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_del_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cumplimiento_del_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_para_el_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_de_Danos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Acepta_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_generados_en_MASC' + rowIndex));


}
//BusinessRuleId:1946, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1946, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno_Asignado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Detenido' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NIC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Detenido' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Puesto_a_Disposicion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitar_Servicos_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Expedientes_Relacionados' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar_Cita' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_del_Remitente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Remitente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Remitente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_para_validacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Delegacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Ministerio_Publico_en_Turno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Oficio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Delegacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitar_Diligencias' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno_Asignado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_Caso' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Inicio_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_para_el_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_de_Danos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Acepta_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Inicio_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_del_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cumplimiento_del_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_para_el_Cumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_de_Danos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Acepta_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_generados_en_MASC' + rowIndex));


}
//BusinessRuleId:1946, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1976, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divApellido_Paterno_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Remitente' + rowIndex));$('#divApellido_Materno_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Remitente' + rowIndex));$('#divFecha_en_que_llega_para_validacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_para_validacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));}


}
//BusinessRuleId:1976, Attribute:0, Operation:Object, Event:SCREENOPENING

















//BusinessRuleId:2068, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Tipo_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Inicio_de_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Inicio_de_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Cumplimiento_del_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cumplimiento_del_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Cumplimiento_del_Acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cumplimiento_del_Acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Domicilio_para_el_Cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Domicilio_para_el_Cumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Monto_de_Reparacion_de_Danos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_Reparacion_de_Danos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Parcialidades" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Parcialidades' + rowIndex));}DisabledControl($("#" + nameOfTable + "Periodicidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Periodicidad' + rowIndex));}


}
//BusinessRuleId:2068, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2069, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('6', '6') ) { SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_Rechazo_de_Acuerdo' + rowIndex));} else {}


}
//BusinessRuleId:2069, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2070, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Cerrar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));} else { SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));}


}
//BusinessRuleId:2070, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2084, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { 
    $("a[href='#tabCanalizar']").css('display', 'none'); $("a[href='#tabDatos_de_los_Hechos_en_MPO']").css('display', 'none'); 
    $("a[href='#tabBitacora_de_Coincidencias']").css('display', 'none'); 
    $("a[href='#tabCierre']").css('display', 'none'); 
    $('#divApellido_Paterno_del_Remitente').css('display', 'none'); 
    SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Remitente' + rowIndex));
    $('#divApellido_Materno_del_Remitente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Remitente' + rowIndex));$('#divFecha_en_que_llega_para_validacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_para_validacion' + rowIndex));} else {}


}
//BusinessRuleId:2084, Attribute:0, Operation:Object, Event:SCREENOPENING

//OCULTAR BOTÓN FINALIZAR AL CONSULTAR Y CONSULTAR
if(operation == 'Update'){
    $("#Modulo_Atencion_InicialFinalizar").css('display', 'none');
    
    }
    if(operation == 'Consult'){
        $("#Modulo_Atencion_InicialFinalizar").css('display', 'none');
        
        }
//OCULTAR BOTÓN FINALIZAR AL CONSULTAR Y CONSULTAR












//BusinessRuleId:1891, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));$('#divFecha_de_Registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));$('#divHora_de_Registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));$('#divNUAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Ministerio_Publico_en_Turno' + rowIndex));} else {}


}
//BusinessRuleId:1891, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1891, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));$('#divFecha_de_Registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));$('#divHora_de_Registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));$('#divNUAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Ministerio_Publico_en_Turno' + rowIndex));} else {}


}
//BusinessRuleId:1891, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2088, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { DisabledControl($("#" + nameOfTable + "Turno_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Turno_Asignado' + rowIndex));} $("a[href='#tabInformacion_de_Turno']").css('display', 'none'); $("a[href='#tabDatos_de_los_Hechos_en_MPO']").css('display', 'none');} else {}


}
//BusinessRuleId:2088, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2085, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT Urgencia FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]	",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divTipo_de_Urgencia_turno').css('display', 'block'); $('#divUrgencia_turno').css('display', 'block');} else { $('#divTipo_de_Urgencia_turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia_turno' + rowIndex)); $('#divUrgencia_turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Urgencia_turno' + rowIndex));}


}
//BusinessRuleId:2085, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2085, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("SELECT Urgencia FROM Asignacion_de_Turnos WHERE Folio = FLD[Turno_Asignado]	",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divTipo_de_Urgencia_turno').css('display', 'block'); $('#divUrgencia_turno').css('display', 'block');} else { $('#divTipo_de_Urgencia_turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia_turno' + rowIndex)); $('#divUrgencia_turno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Urgencia_turno' + rowIndex));}


}
//BusinessRuleId:2085, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2431, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex));


}
//BusinessRuleId:2431, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2431, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex));


}
//BusinessRuleId:2431, Attribute:0, Operation:Object, Event:SCREENOPENING

















//BusinessRuleId:2487, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex)); DisabledControl($("#" + nameOfTable + "CDI" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex));} $('#divCDI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex));


}
//BusinessRuleId:2487, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2487, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex)); DisabledControl($("#" + nameOfTable + "CDI" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex));} $('#divCDI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex));


}
//BusinessRuleId:2487, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2487, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex)); DisabledControl($("#" + nameOfTable + "CDI" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex));} $('#divCDI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex));


}
//BusinessRuleId:2487, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2488, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') || EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('5', '5') ) { $('#divCDI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex));} else {}


}
//BusinessRuleId:2488, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2504, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex));


}
//BusinessRuleId:2504, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2504, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex));


}
//BusinessRuleId:2504, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2504, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex));


}
//BusinessRuleId:2504, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2535, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus2' + rowIndex),nameOfTable,rowIndex)>TryParseInt('0', '0') ) { DisabledControl($("#" + nameOfTable + "Cerrar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cerrar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));}} else {}


}
//BusinessRuleId:2535, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2536, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Cerrar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { DisabledControl($("#" + nameOfTable + "Estatus2" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus2' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));}} else {}


}
//BusinessRuleId:2536, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:1309, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){



}
//BusinessRuleId:1309, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1309, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){



}
//BusinessRuleId:1309, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1309, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){



}
//BusinessRuleId:1309, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:2867, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));


}
//BusinessRuleId:2867, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2867, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));


}
//BusinessRuleId:2867, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2867, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));


}
//BusinessRuleId:2867, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2869, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus2' + rowIndex),nameOfTable,rowIndex)==TryParseInt('6', '6') ) { $('#divUnidad_canaliza').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));} else { $('#divUnidad_canaliza').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}


}
//BusinessRuleId:2869, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2869, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus2' + rowIndex),nameOfTable,rowIndex)==TryParseInt('6', '6') ) { $('#divUnidad_canaliza').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));} else { $('#divUnidad_canaliza').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}


}
//BusinessRuleId:2869, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2087, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { AsignarValor($('#' + nameOfTable + 'Turno_Asignado' + rowIndex),EvaluaQuery(" SELECT Folio FROM Asignacion_de_Turnos WHERE Estatus_de_Turno = 1 AND ORIENTADOR = GLOBAL[USERID] AND Folio NOT IN (SELECT ISNULL(Turno_Asignado, 0) FROM dbo.Modulo_Atencion_Inicial)", rowIndex, nameOfTable)); SetNotRequiredToControl( $('#' + nameOfTable + 'Turno_Asignado' + rowIndex)); DisabledControl($("#" + nameOfTable + "Turno_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Turno_Asignado' + rowIndex));} var valor = $('#' + nameOfTable + 'Turno_Asignado' + rowIndex).val();   $('#' + nameOfTable + 'Turno_Asignado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Turno_Asignado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Turno_Asignado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Folio, NUMERO_DE_TURNO FROM Asignacion_de_Turnos WHERE Estatus_de_Turno = 1 AND ORIENTADOR = GLOBAL[USERID] AND Folio NOT IN (SELECT ISNULL(Turno_Asignado, 0) FROM dbo.Modulo_Atencion_Inicial)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Turno_Asignado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Folio, NUMERO_DE_TURNO FROM Asignacion_de_Turnos WHERE Estatus_de_Turno = 1 AND ORIENTADOR = GLOBAL[USERID] AND Folio NOT IN (SELECT ISNULL(Turno_Asignado, 0) FROM dbo.Modulo_Atencion_Inicial)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Turno_Asignado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Turno_Asignado' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:2087, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2037, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Atencion_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Urgencia_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_turno' + rowIndex));

}
//BusinessRuleId:2037, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2037, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Atencion_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Urgencia_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_turno' + rowIndex));

}
//BusinessRuleId:2037, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2037, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Atencion_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Urgencia_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Urgencia_turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_turno' + rowIndex));

}
//BusinessRuleId:2037, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2629, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetRequiredToControl( $('#' + nameOfTable + 'Turno_Asignado' + rowIndex));

}
//BusinessRuleId:2629, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2907, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));

}
//BusinessRuleId:2907, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2907, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));

}
//BusinessRuleId:2907, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2907, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));

}
//BusinessRuleId:2907, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3011, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Region' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Region' + rowIndex),EvaluaQuery(" SELECT Region FROM dbo.Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));} else {}

}
//BusinessRuleId:3011, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//BusinessRuleId:385, Attribute:0, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('4', '4') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('2', '2') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),8);} else {}


}
//BusinessRuleId:385, Attribute:0, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:385, Attribute:0, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('4', '4') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('2', '2') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),8);} else {}


}
//BusinessRuleId:385, Attribute:0, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:385, Attribute:0, Operation:Object, Event:BEFORESAVING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('4', '4') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('2', '2') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),8);} else {}


}
//BusinessRuleId:385, Attribute:0, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:540, Attribute:0, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('11', '11') && $('#' + nameOfTable + 'Cerrar' + rowIndex).val()==TryParseInt('true', 'true') ) { AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),EvaluaQuery("Select CONVERT (VARCHAR, Getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),EvaluaQuery("Select CONVERT (VARCHAR(10), Getdate(),103)", rowIndex, nameOfTable));} else {}


}
//BusinessRuleId:540, Attribute:0, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:771, Attribute:0, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("SELECT LEN(REPLACE(REPLACE('FLDGC[Detalle de Delito.Delito Principal]', '0',''), ',',''))",rowIndex, nameOfTable)!=TryParseInt('1', '1') ) {} else {}


}
//BusinessRuleId:771, Attribute:0, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:771, Attribute:0, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("SELECT LEN(REPLACE(REPLACE('FLDGC[Detalle de Delito.Delito Principal]', '0',''), ',',''))",rowIndex, nameOfTable)!=TryParseInt('1', '1') ) {} else {}


}
//BusinessRuleId:771, Attribute:0, Operation:Object, Event:BEFORESAVING









//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:158, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==EvaluaQuery("select clave from Estatus where descripcion like 'Solicitar servicios de apoyo'",rowIndex, nameOfTable) && $('#' + nameOfTable + 'Finalizar_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('TRUE', 'TRUE') ) { EvaluaQuery("update Modulo_Atencion_Inicial set Estatus=2 where Clave=FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:158, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:191, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Requiere_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('true', 'true') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('2', '2') && $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('null', 'null') && $('#' + nameOfTable + 'Finalizar_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('false', 'false') ) { EvaluaQuery("insert into Solicitud_de_Servicios_de_Apoyo "
+" "
+" (Folio_del_Caso,Tipo_de_Servicio,Dictamen,clave_mr,responsable,compareciente) "
+" "
+" select mai.folio,dsa.Tipo_de_Servicio,dsa.Dictamen,dsa.Clave,dsa.responsable,dsa.compareciente"
+" "
+" from Modulo_Atencion_Inicial mai inner join Detalle_de_Servicio_de_Apoyo dsa "
+" "
+" on dsa.Modulo_de_Atencion_Inicial =mai.Clave  where dsa.Modulo_de_Atencion_Inicial=FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:191, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:191, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Requiere_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('true', 'true') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('2', '2') && $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('null', 'null') && $('#' + nameOfTable + 'Finalizar_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('false', 'false') ) { EvaluaQuery("insert into Solicitud_de_Servicios_de_Apoyo "
+" "
+" (Folio_del_Caso,Tipo_de_Servicio,Dictamen,clave_mr,responsable,compareciente) "
+" "
+" select mai.folio,dsa.Tipo_de_Servicio,dsa.Dictamen,dsa.Clave,dsa.responsable,dsa.compareciente"
+" "
+" from Modulo_Atencion_Inicial mai inner join Detalle_de_Servicio_de_Apoyo dsa "
+" "
+" on dsa.Modulo_de_Atencion_Inicial =mai.Clave  where dsa.Modulo_de_Atencion_Inicial=FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:191, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:198, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){



}
//BusinessRuleId:198, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:239, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('6', '6') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('2', '2') && EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { EvaluaQuery("update Modulo_Atencion_Inicial set Estatus=9 where Clave=FLD[Clave]"
+" "
+" ", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:239, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:239, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('6', '6') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('2', '2') && EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { EvaluaQuery("update Modulo_Atencion_Inicial set Estatus=9 where Clave=FLD[Clave]"
+" "
+" ", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:239, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:239, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('6', '6') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('2', '2') && EvaluaQuery("Select 'GLOBAL[USERROLEID]'",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { EvaluaQuery("update Modulo_Atencion_Inicial set Estatus=9 where Clave=FLD[Clave]"
+" "
+" ", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:239, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:242, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Correccion_de_Estatus' + rowIndex).val()==TryParseInt('TRUE', 'TRUE') && $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('3', '3') ) { EvaluaQuery("insert into Correccion_de_Error_en_Estatus (NUAT,Estatus_Actual)"
+" "
+" values ((select NUAT from Modulo_Atencion_Inicial where Clave = FLD[Clave]),"
+" "
+" (select clave from Estatus_Orientador where Clave = FLD[estatus2] ))"
+" "
+" ", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:242, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:256, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Requiere_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('true', 'true') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('3', '3') && $('#' + nameOfTable + 'Finalizar_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('false', 'false') ) { EvaluaQuery("insert into Solicitud_de_Servicios_de_Apoyo "
+" "
+" (Folio_del_Caso,Tipo_de_Servicio,Dictamen,clave_mr,responsable,compareciente) "
+" "
+" select mai.folio,dsa.Tipo_de_Servicio,dsa.Dictamen,dsa.Clave,dsa.responsable,dsa.compareciente"
+" "
+" from Modulo_Atencion_Inicial mai inner join Detalle_de_Servicio_de_Apoyo dsa "
+" "
+" on dsa.Modulo_de_Atencion_Inicial =mai.Clave  where dsa.Modulo_de_Atencion_Inicial"
+" "
+" =FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:256, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:256, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Requiere_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('true', 'true') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('3', '3') && $('#' + nameOfTable + 'Finalizar_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('false', 'false') ) { EvaluaQuery("insert into Solicitud_de_Servicios_de_Apoyo "
+" "
+" (Folio_del_Caso,Tipo_de_Servicio,Dictamen,clave_mr,responsable,compareciente) "
+" "
+" select mai.folio,dsa.Tipo_de_Servicio,dsa.Dictamen,dsa.Clave,dsa.responsable,dsa.compareciente"
+" "
+" from Modulo_Atencion_Inicial mai inner join Detalle_de_Servicio_de_Apoyo dsa "
+" "
+" on dsa.Modulo_de_Atencion_Inicial =mai.Clave  where dsa.Modulo_de_Atencion_Inicial"
+" "
+" =FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:256, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:256, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Requiere_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('true', 'true') && $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('3', '3') && $('#' + nameOfTable + 'Finalizar_Servicios_de_Apoyo' + rowIndex).val()==TryParseInt('false', 'false') ) { EvaluaQuery("insert into Solicitud_de_Servicios_de_Apoyo "
+" "
+" (Folio_del_Caso,Tipo_de_Servicio,Dictamen,clave_mr,responsable,compareciente) "
+" "
+" select mai.folio,dsa.Tipo_de_Servicio,dsa.Dictamen,dsa.Clave,dsa.responsable,dsa.compareciente"
+" "
+" from Modulo_Atencion_Inicial mai inner join Detalle_de_Servicio_de_Apoyo dsa "
+" "
+" on dsa.Modulo_de_Atencion_Inicial =mai.Clave  where dsa.Modulo_de_Atencion_Inicial"
+" "
+" =FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:256, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:388, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('6', '6') && $('#' + nameOfTable + 'Se_Acepta_Acuerdo' + rowIndex).val()==TryParseInt('TRUE', 'TRUE') ) { EvaluaQuery("UPDATE Solicitud "
+" "
+" SET Estatus = 12,"
+" "
+" Rechazado_por_MPO = 0,"
+" "
+" Numero_de_Folio = 'FLD[NUAT]' "
+" "
+" WHERE Numero_de_Expediente = 'FLD[Numero_de_Expediente]'"
+" "
+" "
+" INSERT INTO DETALLE_HISTORICO_JA(FECHA,HORA,USUARIO,ESTATUS,SOLICITUD)"
+" "
+" 						  VALUES((SELECT CONVERT(DATE,GETDATE(),101)),"
+" "
+" 								(SELECT CONVERT(TIME,GETDATE(),108)),"
+" "
+" 								('Seguimiento'),"
+" "
+" 								(SELECT USUARIO_QUE_REGISTRA FROM SOLICITUD WHERE NUMERO_DE_EXPEDIENTE = 'FLD[Numero_de_Expediente]'),"
+" "
+" 								(SELECT CLAVE FROM SOLICITUD WHERE NUMERO_DE_EXPEDIENTE = 'FLD[Numero_de_Expediente]'))"
+" "
+" "
+" INSERT INTO DETALLE_HISTORICO_MPO (FECHA,HORA,USUARIO,ESTATUS,MODULO_ATENCION_INICIAL)"
+" "
+" 						  VALUES((SELECT CONVERT(DATE,GETDATE(),101)),"
+" "
+" 							   (SELECT CONVERT(TIME,GETDATE(),108)),"
+" "
+" 							   (SELECT USUARIO_QUE_REGISTRA FROM MODULO_ATENCION_INICIAL WHERE NUMERO_DE_EXPEDIENTE='FLD[Numero_de_Expediente]'),"
+" "
+" 							   ('Acuerdo Aprobado'),"
+" "
+" 							   (SELECT CLAVE FROM MODULO_ATENCION_INICIAL WHERE NUMERO_DE_EXPEDIENTE = 'FLD[Numero_de_Expediente]'))", rowIndex, nameOfTable); EvaluaQuery("update Modulo_Atencion_Inicial set Estatus=8 where Clave=FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:388, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:390, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('6', '6') && $('#' + nameOfTable + 'Se_Acepta_Acuerdo' + rowIndex).val()==TryParseInt('FALSE', 'FALSE') ) { EvaluaQuery("UPDATE Solicitud "
+" "
+" SET Estatus = 12,"
+" "
+" Rechazado_por_MPO = 0,"
+" "
+" Numero_de_Folio = 'FLD[NUAT]' "
+" "
+" WHERE Numero_de_Expediente = 'FLD[Numero_de_Expediente]'"
+" "
+" "
+" ", rowIndex, nameOfTable); EvaluaQuery("update Modulo_Atencion_Inicial set Estatus=8 where Clave=FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:390, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:395, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('11', '11') && $('#' + nameOfTable + 'Cerrar' + rowIndex).val()==TryParseInt('true', 'true') ) { EvaluaQuery("update Modulo_Atencion_Inicial set Estatus=10 where Clave=FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:395, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:449, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("Update Solicitud Set "
+" "
+" Acuerdo_Cumplido=1, "
+" "
+" Fecha_de_Cierre = (SELECT Fecha_de_Cierre From modulo_atencion_inicial Where Clave = FLD[Clave]),"
+" "
+" Hora_de_Cierre = (SELECT Hora_de_Cierre From modulo_atencion_inicial Where Clave = FLD[Clave])"
+" "
+" WHERE Numero_de_Expediente = (Select Numero_de_Expediente From Modulo_Atencion_Inicial Where Clave = FLD[Clave] AND Estatus = 10) "
+" "
+" AND Estatus = 13"
+" "
+" ", rowIndex, nameOfTable);


}
//BusinessRuleId:449, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1027, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( EvaluaQuery("select 'GLOBAL[globalColonia]'",rowIndex, nameOfTable)!=EvaluaQuery("select '0'",rowIndex, nameOfTable) ) { EvaluaQuery("update modulo_atencion_inicial set colonia_de_los_hechos=GLOBAL[globalcolonia] WHERE CLAVE = FLD[Clave]"
+" "
+" ", rowIndex, nameOfTable); EvaluaQuery("if exists (select * from Expediente_Inicial where NUAT='FLD[NUAT]')"
+" "
+" begin"
+" "
+" update Expediente_Inicial set Colonia_de_los_Hechos_MPI=GLOBAL[globalcolonia]"
+" "
+" where NUAT='FLD[NUAT]' "
+" "
+" end", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:1027, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1027, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( EvaluaQuery("select 'GLOBAL[globalColonia]'",rowIndex, nameOfTable)!=EvaluaQuery("select '0'",rowIndex, nameOfTable) ) { EvaluaQuery("update modulo_atencion_inicial set colonia_de_los_hechos=GLOBAL[globalcolonia] WHERE CLAVE = FLD[Clave]"
+" "
+" ", rowIndex, nameOfTable); EvaluaQuery("if exists (select * from Expediente_Inicial where NUAT='FLD[NUAT]')"
+" "
+" begin"
+" "
+" update Expediente_Inicial set Colonia_de_los_Hechos_MPI=GLOBAL[globalcolonia]"
+" "
+" where NUAT='FLD[NUAT]' "
+" "
+" end", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:1027, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1027, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Consult'){
if( EvaluaQuery("select 'GLOBAL[globalColonia]'",rowIndex, nameOfTable)!=EvaluaQuery("select '0'",rowIndex, nameOfTable) ) { EvaluaQuery("update modulo_atencion_inicial set colonia_de_los_hechos=GLOBAL[globalcolonia] WHERE CLAVE = FLD[Clave]"
+" "
+" ", rowIndex, nameOfTable); EvaluaQuery("if exists (select * from Expediente_Inicial where NUAT='FLD[NUAT]')"
+" "
+" begin"
+" "
+" update Expediente_Inicial set Colonia_de_los_Hechos_MPI=GLOBAL[globalcolonia]"
+" "
+" where NUAT='FLD[NUAT]' "
+" "
+" end", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:1027, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1243, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('5', '5') && $('#' + nameOfTable + 'Estatus2' + rowIndex).val()!=TryParseInt('null', 'null') ) { EvaluaQuery("Update modulo_atencion_inicial"
+" "
+" set Estatus = 12"
+" "
+" Where Clave = FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:1243, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1243, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('5', '5') && $('#' + nameOfTable + 'Estatus2' + rowIndex).val()!=TryParseInt('null', 'null') ) { EvaluaQuery("Update modulo_atencion_inicial"
+" "
+" set Estatus = 12"
+" "
+" Where Clave = FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:1243, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1270, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("EXEC spGenerarFolioYNUAT FLD[Clave]", rowIndex, nameOfTable);


}
//BusinessRuleId:1270, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1271, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('2', '2') ) { EvaluaQuery("Exec InsertarEnJA FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:1271, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1288, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("UPDATE Modulo_Atencion_Inicial SET Campo_Oculto1 = "
+" "
+" (SELECT TOP 1 D.Descripcion "
+" "
+" FROM Detalle_de_Delito Dd INNER JOIN Delito D ON D.Clave = Dd.Delito"
+" "
+" WHERE Dd.Delito_Principal = 1 AND Dd.Expediente_Inicial = FLD[Clave]"
+" "
+" )"
+" "
+" WHERE Clave = FLD[Clave]", rowIndex, nameOfTable);


}
//BusinessRuleId:1288, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1289, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("UPDATE Modulo_Atencion_Inicial SET Campo_Oculto2 = "
+" "
+" (SELECT TOP 1 D.Clave "
+" "
+" FROM Detalle_de_Servicio_de_Apoyo Dd INNER JOIN Tipo_de_Servicio_de_Apoyo D ON D.Clave = Dd.Tipo_de_Servicio"
+" "
+" WHERE Dd.Tipo_de_Servicio = 1 AND Dd.Modulo_de_Atencion_Inicial = FLD[Clave]"
+" "
+" )"
+" "
+" WHERE Clave = FLD[Clave]", rowIndex, nameOfTable);


}
//BusinessRuleId:1289, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1290, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("UPDATE Modulo_Atencion_Inicial SET Campo_Oculto3 = "
+" "
+" (SELECT TOP 1 D.Clave "
+" "
+" FROM Detalle_de_Servicio_de_Apoyo Dd INNER JOIN Tipo_de_Servicio_de_Apoyo D ON D.Clave = Dd.Tipo_de_Servicio"
+" "
+" WHERE Dd.Tipo_de_Servicio = 2 AND Dd.Modulo_de_Atencion_Inicial = FLD[Clave]"
+" "
+" )"
+" "
+" WHERE Clave = FLD[Clave]", rowIndex, nameOfTable);


}
//BusinessRuleId:1290, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1429, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("update"
+" "
+"       detalle_de_datos_generales"
+" "
+" set"
+" "
+"       causal = null,"
+" "
+"       causa_de_interrupcion=null,"
+" "
+"       datos_insuficientes=null,"
+" "
+"       actualizacion_de_sobreseimiento=null"
+" "
+" from"
+" "
+"       detalle_de_datos_generales dg"
+" "
+"       left join Detalle_de_Desestimacion dd on dg.modulo_atencion_inicial = dd.modulo_atencion_inicial and dg.clave=dd.nombre_completo"
+" "
+" where"
+" "
+"       dg.modulo_atencion_inicial=GLOBAL[KeyValueInserted]"
+" "
+"       and dd.clave is null"
+" "
+"       "
+" "
+" update"
+" "
+"       detalle_de_datos_generales"
+" "
+" set"
+" "
+"       causal = dd.causal_de_interrupcion,"
+" "
+"       causa_de_interrupcion=dd.causa_de_interrupcion,"
+" "
+"       datos_insuficientes=dd.datos_insuficientes,"
+" "
+"       actualizacion_de_sobreseimiento=dd.actualizacion_de_sobreseimiento"
+" "
+" from"
+" "
+"       detalle_de_datos_generales dg"
+" "
+"       inner join Detalle_de_Desestimacion dd on dg.modulo_atencion_inicial = dd.modulo_atencion_inicial and dg.clave=dd.nombre_completo"
+" "
+" where"
+" "
+"       dg.modulo_atencion_inicial=GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:1429, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1430, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("update"
+" "
+"       detalle_de_datos_generales"
+" "
+" set"
+" "
+"       causal = null,"
+" "
+"       causa_de_interrupcion=null,"
+" "
+"       datos_insuficientes=null,"
+" "
+"       actualizacion_de_sobreseimiento=null"
+" "
+" from"
+" "
+"       detalle_de_datos_generales dg"
+" "
+"       left join Detalle_de_Desestimacion dd on dg.modulo_atencion_inicial = dd.modulo_atencion_inicial and dg.clave=dd.nombre_completo"
+" "
+" where"
+" "
+"       dg.modulo_atencion_inicial=FLD[Clave]"
+" "
+"       and dd.clave is null"
+" "
+"       "
+" "
+" update"
+" "
+"       detalle_de_datos_generales"
+" "
+" set"
+" "
+"       causal = dd.causal_de_interrupcion,"
+" "
+"       causa_de_interrupcion=dd.causa_de_interrupcion,"
+" "
+"       datos_insuficientes=dd.datos_insuficientes,"
+" "
+"       actualizacion_de_sobreseimiento=dd.actualizacion_de_sobreseimiento"
+" "
+" from"
+" "
+"       detalle_de_datos_generales dg"
+" "
+"       inner join Detalle_de_Desestimacion dd on dg.modulo_atencion_inicial = dd.modulo_atencion_inicial and dg.clave=dd.nombre_completo"
+" "
+" where"
+" "
+"       dg.modulo_atencion_inicial=FLD[Clave]", rowIndex, nameOfTable);


}
//BusinessRuleId:1430, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1466, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("exec Historico_mpo FLD[Clave]", rowIndex, nameOfTable);


}
//BusinessRuleId:1466, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1466, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("exec Historico_mpo FLD[Clave]", rowIndex, nameOfTable);


}
//BusinessRuleId:1466, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1469, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC SPHISTORICO_MPOJA 'FLD[Numero_de_Expediente]', FLD[Clave]", rowIndex, nameOfTable);


}
//BusinessRuleId:1469, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1469, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("EXEC SPHISTORICO_MPOJA 'FLD[Numero_de_Expediente]', FLD[Clave]", rowIndex, nameOfTable);


}
//BusinessRuleId:1469, Attribute:0, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1472, Attribute:0, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Estatus' + rowIndex).val()==TryParseInt('2', '2') && $('#' + nameOfTable + 'Estatus2' + rowIndex).val()==TryParseInt('6', '6') ) { EvaluaQuery("exec sp_InsertMPI FLD[Clave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:1472, Attribute:0, Operation:Object, Event:AFTERSAVING







//BusinessRuleId:2064, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('6', '6') ) { EvaluaQuery("exec uspAprobacionAcuerdoMASC GLOBAL[USERID],FLDD[lblClave],null", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:2064, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2155, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("exec uspGenerarInvolucradoTurno GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:2155, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2057, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus2' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') && GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('8', '8') && GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('6', '6') ) { EvaluaQuery(" exec uspGeneraSolicitudMASC_desde_AT FLDD[lblClave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:2057, Attribute:2, Operation:Object, Event:AFTERSAVING

































//BusinessRuleId:2499, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" exec sp_Canalizar_desde_AtencionInicial FLDD[lblClave]", rowIndex, nameOfTable);


}
//BusinessRuleId:2499, Attribute:2, Operation:Object, Event:AFTERSAVING





//BusinessRuleId:2888, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC sp_ActualizaTurnoFinalizar FLD[Turno_Asignado]", rowIndex, nameOfTable);

}
//BusinessRuleId:2888, Attribute:2, Operation:Object, Event:AFTERSAVING











//BusinessRuleId:2893, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC spActualizaInfoTurno GLOBAL[KeyValueInserted], FLD[Turno_Asignado]", rowIndex, nameOfTable);

}
//BusinessRuleId:2893, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2894, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("EXEC spActualizaInfoTurno FLDD[lblClave], FLD[Turno_Asignado]", rowIndex, nameOfTable);

}
//BusinessRuleId:2894, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2927, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC UspInsDatosHechos_desde_AtencionInicial GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2927, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1993, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Folio' + rowIndex),EvaluaQuery("exec uspGeneraFolio GLOBAL[KeyValueInserted],FLD[Tipo_de_Denuncia], FLD[Unidad]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'NUAT' + rowIndex),EvaluaQuery("exec uspGeneraNUAT GLOBAL[KeyValueInserted],FLD[Tipo_de_Denuncia], FLD[Region]	", rowIndex, nameOfTable));

}
//BusinessRuleId:1993, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2938, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" EXEC UspInsDatosResumenDenuncia_desde_AtencionInicial GLOBAL[KeyValueInserted]"
+" ", rowIndex, nameOfTable);

}
//BusinessRuleId:2938, Attribute:2, Operation:Object, Event:AFTERSAVING



//BusinessRuleId:2997, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" IF (SELECT Usuario_que_Registra FROM dbo.Modulo_Atencion_Inicial WHERE Clave = GLOBAL[KeyValueInserted]) IS NULL"
+" BEGIN"
+" 	UPDATE Modulo_Atencion_Inicial SET Usuario_que_Registra = GLOBAL[USERID]"
+" 	WHERE Clave = GLOBAL[KeyValueInserted]"
+" END", rowIndex, nameOfTable);

}
//BusinessRuleId:2997, Attribute:2, Operation:Object, Event:AFTERSAVING


//INI COD-MAN PARA ENVIAR CORREO DE ENCUESTA
if(operation == 'New' || operation == 'Update'){
	//CERRAR
	if( GetValueByControlType($('#' + nameOfTable + 'Cerrar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) 
	{ 
		if( EvaluaQuery("SELECT Correo_Electronico from Detalle_de_Datos_Generales where Modulo_Atencion_Inicial = FLDD[lblClave] and Tipo_de_Compareciente = 1",rowIndex, nameOfTable)!=TryParseInt('NULL', 'NULL') ) { SendEmailQuery('Envio de Encuesta', EvaluaQuery(" SELECT Correo_Electronico from Detalle_de_Datos_Generales where Modulo_Atencion_Inicial = FLDD[lblClave] and Tipo_de_Compareciente = 1"), EvaluaQuery("EXEC dbo.UspGeneraLinkEncuesta 1, FLDD[lblClave], 1"),rowIndex,nameOfTable); alert(DecodifyText('Envío de encuesta.', rowIndex, nameOfTable));} else { alert(DecodifyText('No tiene correo electrónico configurado, por lo que no podrá contestar encuestas.', rowIndex, nameOfTable));}
	}
	else //CANALIZAR
	{
		var OrigenSP = 0
		
		//OTRAS INSTANCIAS
		if( GetValueByControlType($('#' + nameOfTable + 'Estatus2' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4')) 
		{ 
			OrigenSP = 2;
		}
		//MPO O MA = MPI
		if( GetValueByControlType($('#' + nameOfTable + 'Estatus2' + rowIndex),nameOfTable,rowIndex)==TryParseInt('6', '6')) 
		{ 
			OrigenSP = 3;
		}
		
		if(OrigenSP > 0)
		{
			if( EvaluaQuery("SELECT Correo_Electronico from Detalle_de_Datos_Generales where Modulo_Atencion_Inicial = FLDD[lblClave] and Tipo_de_Compareciente = 1",rowIndex, nameOfTable)!=TryParseInt('NULL', 'NULL') ) { SendEmailQuery('Envio de Encuesta', EvaluaQuery(" SELECT Correo_Electronico from Detalle_de_Datos_Generales where Modulo_Atencion_Inicial = FLDD[lblClave] and Tipo_de_Compareciente = 1"), EvaluaQuery("EXEC dbo.UspGeneraLinkEncuesta 1, FLDD[lblClave], " + OrigenSP.toString() ),rowIndex,nameOfTable); alert(DecodifyText('Envío de encuesta.', rowIndex, nameOfTable));} else { alert(DecodifyText('No tiene correo electrónico configurado, por lo que no podrá contestar encuestas.', rowIndex, nameOfTable));}			
		}		 
	}
}
//INI COD-MAN PARA ENVIAR CORREO DE ENCUESTA


//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Imputado//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Imputado(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Imputado//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Imputado//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Imputado//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Imputado//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Servicio_de_Apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Servicio_de_Apoyo//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Servicio_de_Apoyo(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Servicio_de_Apoyo//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Servicio_de_Apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Servicio_de_Apoyo//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Servicio_de_Apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Servicio_de_Apoyo//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Servicio_de_Apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Servicio_de_Apoyo//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Bitacora_de_Cambios(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Bitacora_de_Cambios//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Bitacora_de_Cambios(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Bitacora_de_Cambios//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Bitacora_de_Cambios(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Bitacora_de_Cambios//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Bitacora_de_Cambios(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Bitacora_de_Cambios//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Bitacora_de_Cambios(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Bitacora_de_Cambios//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Delito(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Delito//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Delito(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Delito//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Delito(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Delito//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Delito(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Delito//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Delito(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Delito//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Canalizar_Estatus(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Canalizar_Estatus//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Canalizar_Estatus(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Canalizar_Estatus//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Canalizar_Estatus(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Canalizar_Estatus//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Canalizar_Estatus(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Canalizar_Estatus//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Canalizar_Estatus(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Canalizar_Estatus//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_Generales(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Datos_Generales//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Datos_Generales(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Datos_Generales//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Datos_Generales(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Datos_Generales//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Datos_Generales(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Datos_Generales//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Datos_Generales(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Datos_Generales//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Persona_Moral(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Persona_Moral//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Persona_Moral(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Persona_Moral//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Persona_Moral(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Persona_Moral//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Persona_Moral(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Persona_Moral//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Persona_Moral(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Persona_Moral//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Documentos_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Documentos_MPO//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Documentos_MPO(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Documentos_MPO//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Documentos_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Documentos_MPO//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Documentos_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Documentos_MPO//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Documentos_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Documentos_MPO//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_coincidencias_a(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_coincidencias_a//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_coincidencias_a(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_coincidencias_a//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_coincidencias_a(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_coincidencias_a//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_coincidencias_a(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_coincidencias_a//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_coincidencias_a(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_coincidencias_a//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Documentos_de_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Documentos_de_MPO//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Documentos_de_MPO(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Documentos_de_MPO//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Documentos_de_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Documentos_de_MPO//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Documentos_de_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Documentos_de_MPO//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Documentos_de_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Documentos_de_MPO//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Historico_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Historico_MPO//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Historico_MPO(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Historico_MPO//
}
function EjecutarValidacionesAlEliminarMRDetalle_Historico_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Historico_MPO//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Historico_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Historico_MPO//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Historico_MPO(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Historico_MPO//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Desestimacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Desestimacion//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Desestimacion(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Desestimacion//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Desestimacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Desestimacion//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Desestimacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Desestimacion//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Desestimacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Desestimacion//
    return result;
}


function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Relaciones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Relaciones// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Relaciones(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Relaciones// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_de_Relaciones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_de_Relaciones// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_de_Relaciones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_de_Relaciones// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_de_Relaciones(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_de_Relaciones// 
 return result; 
} 
