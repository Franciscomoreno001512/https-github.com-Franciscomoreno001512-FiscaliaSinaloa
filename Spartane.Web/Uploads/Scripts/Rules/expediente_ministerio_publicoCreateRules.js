var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$("#expediente_ministerio_publicoGuardarYNuevo").hide();
$("#expediente_ministerio_publicoGuardarYCopia").hide();

$(document).ready(function () {












//BusinessRuleId:2610, Attribute:267124, Operation:Field, Event:None
$("form#Createexpediente_ministerio_publico").on('change', '#detenido', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'detenido' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divhora_del_detenido').css('display', 'block');$('#divhora_puesto_a_disposicion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'hora_del_detenido' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'hora_puesto_a_disposicion' + rowIndex));} else { $('#divhora_del_detenido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'hora_del_detenido' + rowIndex));$('#divhora_puesto_a_disposicion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'hora_puesto_a_disposicion' + rowIndex));}
});

//BusinessRuleId:2610, Attribute:267124, Operation:Field, Event:None







//BusinessRuleId:2598, Attribute:267141, Operation:Field, Event:None
$("form#Createexpediente_ministerio_publico").on('change', '#acepta_acuerdo', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'acepta_acuerdo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divmotivo_de_rechazo_de_acuerdo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'motivo_de_rechazo_de_acuerdo' + rowIndex));} else { $('#divmotivo_de_rechazo_de_acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_de_rechazo_de_acuerdo' + rowIndex));}
});

//BusinessRuleId:2598, Attribute:267141, Operation:Field, Event:None













//BusinessRuleId:2612, Attribute:267131, Operation:Field, Event:None
$("form#Createexpediente_ministerio_publico").on('change', '#usuario_que_canaliza', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'canalizar_a' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) {} else { AsignarValor($('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex),EvaluaQuery("select ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex),EvaluaQuery("select ''", rowIndex, nameOfTable)); var valor = $('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex).val();   $('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex).empty();         if(!$('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Id_User, Name FROM Spartan_User where Id_User=0", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Id_User, Name FROM Spartan_User where Id_User=0", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex).val(valor).trigger('change');}
});

//BusinessRuleId:2612, Attribute:267131, Operation:Field, Event:None











//BusinessRuleId:2615, Attribute:267434, Operation:Field, Event:None
$("form#Createexpediente_ministerio_publico").on('change', '#Municipio_Hechos', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'ColoniaH' + rowIndex).val();   $('#' + nameOfTable + 'ColoniaH' + rowIndex).empty();         if(!$('#' + nameOfTable + 'ColoniaH' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'ColoniaH' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave,Nombre from Colonia where Municipio = FLD[Municipio_Hechos]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'ColoniaH' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave,Nombre from Colonia where Municipio = FLD[Municipio_Hechos]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'ColoniaH' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'ColoniaH' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave,Nombre from Colonia where Municipio = FLD[Municipio_Hechos]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave,Nombre from Colonia where Municipio = FLD[Municipio_Hechos]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:2615, Attribute:267434, Operation:Field, Event:None













//BusinessRuleId:2613, Attribute:267423, Operation:Field, Event:None
$("form#Createexpediente_ministerio_publico").on('change', '#PaisH', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave,Nombre from Estado where Pais = FLD[PaisH]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave,Nombre from Estado where Pais = FLD[PaisH]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:2613, Attribute:267423, Operation:Field, Event:None

//BusinessRuleId:2614, Attribute:267433, Operation:Field, Event:None
$("form#Createexpediente_ministerio_publico").on('change', '#Estado', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Municipio_Hechos' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_Hechos' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_Hechos' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_Hechos' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave,Nombre from Municipio where Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_Hechos' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave,Nombre from Municipio where Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_Hechos' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_Hechos' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:2614, Attribute:267433, Operation:Field, Event:None





//BusinessRuleId:2607, Attribute:267145, Operation:Field, Event:None
$("form#Createexpediente_ministerio_publico").on('change', '#tipo_de_cierre', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'tipo_de_cierre' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'fecha_de_cierre' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'hora_de_cierre' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Cierra' + rowIndex),EvaluaQuery("SELECT name FROM Spartan_User "
+"     WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));} else { AsignarValor($('#' + nameOfTable + 'fecha_de_cierre' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'hora_de_cierre' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Usuario_que_Cierra' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));}
});

//BusinessRuleId:2607, Attribute:267145, Operation:Field, Event:None

//BusinessRuleId:2606, Attribute:267132, Operation:Field, Event:None
$("form#Createexpediente_ministerio_publico").on('change', '#canalizar_a', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'canalizar_a' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex),EvaluaQuery("SELECT  Name FROM Spartan_User where Id_User=GLOBAL[USERID]", rowIndex, nameOfTable));} else { AsignarValor($('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));}
});

//BusinessRuleId:2606, Attribute:267132, Operation:Field, Event:None









//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






























//BusinessRuleId:2600, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divhora_del_detenido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'hora_del_detenido' + rowIndex));$('#divhora_puesto_a_disposicion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'hora_puesto_a_disposicion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'acepta_acuerdo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_de_rechazo_de_acuerdo' + rowIndex));

}
//BusinessRuleId:2600, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2584, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "fecha_de_registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha_de_registro' + rowIndex));} DisabledControl($("#" + nameOfTable + "hora_de_registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora_de_registro' + rowIndex));} DisabledControl($("#" + nameOfTable + "usuario_que_registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_que_registra' + rowIndex));} DisabledControl($("#" + nameOfTable + "unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'unidad' + rowIndex));} DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));} DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));} DisabledControl($("#" + nameOfTable + "nuat" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'nuat' + rowIndex));} DisabledControl($("#" + nameOfTable + "estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'estatus' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "usuario_que_canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex));} DisabledControl($("#" + nameOfTable + "fecha_de_cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha_de_cierre' + rowIndex));} DisabledControl($("#" + nameOfTable + "hora_de_cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora_de_cierre' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Cierra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Cierra' + rowIndex));} DisabledControl($("#" + nameOfTable + "nic" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'nic' + rowIndex));}

}
//BusinessRuleId:2584, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2584, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "fecha_de_registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha_de_registro' + rowIndex));} DisabledControl($("#" + nameOfTable + "hora_de_registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora_de_registro' + rowIndex));} DisabledControl($("#" + nameOfTable + "usuario_que_registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_que_registra' + rowIndex));} DisabledControl($("#" + nameOfTable + "unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'unidad' + rowIndex));} DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));} DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));} DisabledControl($("#" + nameOfTable + "nuat" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'nuat' + rowIndex));} DisabledControl($("#" + nameOfTable + "estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'estatus' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "usuario_que_canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_que_canaliza' + rowIndex));} DisabledControl($("#" + nameOfTable + "fecha_de_cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha_de_cierre' + rowIndex));} DisabledControl($("#" + nameOfTable + "hora_de_cierre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora_de_cierre' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Cierra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Cierra' + rowIndex));} DisabledControl($("#" + nameOfTable + "nic" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'nic' + rowIndex));}

}
//BusinessRuleId:2584, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2586, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'fecha_de_registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); 
 AsignarValor($('#' + nameOfTable + 'hora_de_registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); 
 AsignarValor($('#' + nameOfTable + 'usuario_que_registra' + rowIndex),
 EvaluaQuery("select name from Spartan_User where Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); 
 debugger;
 AsignarValor($('#' + nameOfTable + 'unidad' + rowIndex),EvaluaQuery(" exec usp_GetUnidadDescByIdUser GLOBAL[USERID]", rowIndex, nameOfTable)); 
 
 AsignarValor($('#' + nameOfTable + 'estatus' + rowIndex),'1'); AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex),EvaluaQuery("select m.Nombre from Spartan_User spu "
+" inner join Unidad u on spu.Unidad = u.Clave "
+" inner join Municipio m on u.Clave_de_Municipio = m.Clave"
+" where spu. Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Region' + rowIndex),EvaluaQuery("select u.Clave_de_Region from Spartan_User spu"
+" inner join Unidad u on spu.Unidad = u.Clave"
+" where spu. Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2586, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2603, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'acepta_acuerdo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divmotivo_de_rechazo_de_acuerdo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'motivo_de_rechazo_de_acuerdo' + rowIndex));} else { $('#divmotivo_de_rechazo_de_acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_de_rechazo_de_acuerdo' + rowIndex));}

}
//BusinessRuleId:2603, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2603, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'acepta_acuerdo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divmotivo_de_rechazo_de_acuerdo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'motivo_de_rechazo_de_acuerdo' + rowIndex));} else { $('#divmotivo_de_rechazo_de_acuerdo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'motivo_de_rechazo_de_acuerdo' + rowIndex));}

}
//BusinessRuleId:2603, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2588, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'detenido' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divhora_del_detenido').css('display', 'block');$('#divhora_puesto_a_disposicion').css('display', 'block');} else { $('#divhora_del_detenido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'hora_del_detenido' + rowIndex));$('#divhora_puesto_a_disposicion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'hora_puesto_a_disposicion' + rowIndex));}

}
//BusinessRuleId:2588, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2588, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'detenido' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divhora_del_detenido').css('display', 'block');$('#divhora_puesto_a_disposicion').css('display', 'block');} else { $('#divhora_del_detenido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'hora_del_detenido' + rowIndex));$('#divhora_puesto_a_disposicion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'hora_puesto_a_disposicion' + rowIndex));}

}
//BusinessRuleId:2588, Attribute:0, Operation:Object, Event:SCREENOPENING











//BusinessRuleId:2585, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'comentarios_de_cierre' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'tipo_de_cierre' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'PaisH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'ColoniaH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CalleH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_ExteriorH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_InteriorH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_PostalH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'LongitudH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'LatitudH' + rowIndex)); DisabledControl($("#" + nameOfTable + "tipo_de_acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'tipo_de_acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "fecha_de_inicio_de_acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha_de_inicio_de_acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "fecha_de_cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha_de_cumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "hora_de_cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora_de_cumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "domicilio_para_el_cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'domicilio_para_el_cumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "monto_de_reparacion_de_danos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'monto_de_reparacion_de_danos' + rowIndex));}DisabledControl($("#" + nameOfTable + "parcialidades" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'parcialidades' + rowIndex));}DisabledControl($("#" + nameOfTable + "periodicidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'periodicidad' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));

}
//BusinessRuleId:2585, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2585, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'comentarios_de_cierre' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'tipo_de_cierre' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'PaisH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'ColoniaH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CalleH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_ExteriorH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_InteriorH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_PostalH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'LongitudH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'LatitudH' + rowIndex)); DisabledControl($("#" + nameOfTable + "tipo_de_acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'tipo_de_acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "fecha_de_inicio_de_acuerdo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha_de_inicio_de_acuerdo' + rowIndex));}DisabledControl($("#" + nameOfTable + "fecha_de_cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha_de_cumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "hora_de_cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora_de_cumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "domicilio_para_el_cumplimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'domicilio_para_el_cumplimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "monto_de_reparacion_de_danos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'monto_de_reparacion_de_danos' + rowIndex));}DisabledControl($("#" + nameOfTable + "parcialidades" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'parcialidades' + rowIndex));}DisabledControl($("#" + nameOfTable + "periodicidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'periodicidad' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));

}
//BusinessRuleId:2585, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2637, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "MP_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'MP_Asignado' + rowIndex));}

}
//BusinessRuleId:2637, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2637, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "MP_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'MP_Asignado' + rowIndex));}

}
//BusinessRuleId:2637, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2637, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "MP_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'MP_Asignado' + rowIndex));}

}
//BusinessRuleId:2637, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2638, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'MP_Asignado' + rowIndex),EvaluaQuery(" SELECT name FROM Spartan_User "
+"     WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2638, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2599, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $("a[href='#tabDatos_del_Acuerdo']").css('display', 'none'); $("a[href='#tabResolucion_o_Dictaminacion']").css('display', 'none'); $("a[href='#tabCanalizar']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'canalizar_a' + rowIndex));

}
//BusinessRuleId:2599, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//BusinessRuleId:2639, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'nic' + rowIndex),EvaluaQuery("exec uspGetCDI FLD[unidad]", rowIndex, nameOfTable));

}
//BusinessRuleId:2639, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2640, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'nuat' + rowIndex),EvaluaQuery("exec uspGeneraNUAT_MP FLD[Tipo_de_Denuncia],FLD[Region]", rowIndex, nameOfTable));

}
//BusinessRuleId:2640, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){


//BusinessRuleId:2617, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("exec ups_LimpiarExpedienteMPUsuarioQueCanaliza GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2617, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2618, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("exec ups_LimpiarExpedienteMPUsuarioQueCanaliza FLDD[lblclave]"
+" ", rowIndex, nameOfTable);

}
//BusinessRuleId:2618, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}



function EjecutarValidacionesAntesDeGuardarMRdetalle_de_observaciones_mpi(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_detalle_de_observaciones_mpi// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRdetalle_de_observaciones_mpi(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_detalle_de_observaciones_mpi// 
} 

function EjecutarValidacionesAlEliminarMRdetalle_de_observaciones_mpi(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_detalle_de_observaciones_mpi// 
 return result; 
} 

function EjecutarValidacionesNewRowMRdetalle_de_observaciones_mpi(nameOfTable, rowIndex){ 
 var result= true; 








//BusinessRuleId:2602, Attribute:267128, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "hora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora' + rowIndex));}DisabledControl($("#" + nameOfTable + "usuario_que_realiza_observacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_que_realiza_observacion' + rowIndex));}

}
//BusinessRuleId:2602, Attribute:267128, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2602, Attribute:267128, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "hora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora' + rowIndex));}DisabledControl($("#" + nameOfTable + "usuario_que_realiza_observacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_que_realiza_observacion' + rowIndex));}

}
//BusinessRuleId:2602, Attribute:267128, Operation:Object, Event:NEWROWMR




























debugger;
//BusinessRuleId:2609, Attribute:267128, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'fecha' + rowIndex),EvaluaQuery("select convert (varchar(11),getdate(),105) ", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'hora' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); 
 debugger;
 AsignarValor2($('#' + nameOfTable + 'usuario_que_realiza_observacion' + rowIndex),EvaluaQuery("SELECT name FROM Spartan_User WHERE Id_User =GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2609, Attribute:267128, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2609, Attribute:267128, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'fecha' + rowIndex),EvaluaQuery("select convert (varchar(11),getdate(),105) ", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'hora' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'usuario_que_realiza_observacion' + rowIndex),EvaluaQuery("SELECT name FROM Spartan_User WHERE Id_User =GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2609, Attribute:267128, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_detalle_de_observaciones_mpi// 
  return result; 
} 

function EjecutarValidacionesEditRowMRdetalle_de_observaciones_mpi(nameOfTable, rowIndex){ 
 var result= true; 
//BusinessRuleId:2602, Attribute:267128, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "hora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora' + rowIndex));}DisabledControl($("#" + nameOfTable + "usuario_que_realiza_observacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_que_realiza_observacion' + rowIndex));}

}
//BusinessRuleId:2602, Attribute:267128, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2602, Attribute:267128, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "hora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'hora' + rowIndex));}DisabledControl($("#" + nameOfTable + "usuario_que_realiza_observacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'usuario_que_realiza_observacion' + rowIndex));}

}
//BusinessRuleId:2602, Attribute:267128, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_detalle_de_observaciones_mpi// 
 return result; 
} 
