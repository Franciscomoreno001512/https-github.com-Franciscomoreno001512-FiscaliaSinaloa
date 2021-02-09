var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;

$('#Detalle_de_Solicitud_SeguimientoGuardarYNuevo').hide();
$('#Detalle_de_Solicitud_SeguimientoGuardarYCopia').hide();

$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {

















































//BusinessRuleId:1963, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1963, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1963, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1963, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1963, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1963, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:717, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Especialista' + rowIndex),EvaluaQuery("Select Nombre From TTUsuarios where IdUsuario = GLOBAL[NombreEspecialista]", rowIndex, nameOfTable));

}
//BusinessRuleId:717, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:717, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Especialista' + rowIndex),EvaluaQuery("Select Nombre From TTUsuarios where IdUsuario = GLOBAL[NombreEspecialista]", rowIndex, nameOfTable));

}
//BusinessRuleId:717, Attribute:0, Operation:Object, Event:SCREENOPENING























//BusinessRuleId:1706, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery("  select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Especialista' + rowIndex),EvaluaQuery("select name from spartan_user with(nolock) where id_user = GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:1706, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1705, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); var valor = $('#' + nameOfTable + 'Solicitante' + rowIndex).val();   $('#' + nameOfTable + 'Solicitante' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Solicitante' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_Solicitante where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_Solicitante where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Solicitante' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Solicitante' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Requerido' + rowIndex).val();   $('#' + nameOfTable + 'Requerido' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Requerido' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_requerido where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_requerido where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Requerido' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Requerido' + rowIndex).val(valor).trigger('change'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Comentarios' + rowIndex)); DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));} var valor = $('#' + nameOfTable + 'Especialista' + rowIndex).val();   $('#' + nameOfTable + 'Especialista' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Especialista' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Especialista' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Id_User, Name from Spartan_User where role=3", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Especialista' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Id_User, Name from Spartan_User where role=3", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Especialista' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Especialista' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:1705, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1705, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); var valor = $('#' + nameOfTable + 'Solicitante' + rowIndex).val();   $('#' + nameOfTable + 'Solicitante' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Solicitante' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_Solicitante where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_Solicitante where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Solicitante' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Solicitante' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Requerido' + rowIndex).val();   $('#' + nameOfTable + 'Requerido' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Requerido' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_requerido where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Requerido' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_requerido where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Requerido' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Requerido' + rowIndex).val(valor).trigger('change'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Comentarios' + rowIndex)); DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));} var valor = $('#' + nameOfTable + 'Especialista' + rowIndex).val();   $('#' + nameOfTable + 'Especialista' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Especialista' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Especialista' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Id_User, Name from Spartan_User where role=3", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Especialista' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Id_User, Name from Spartan_User where role=3", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Especialista' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Especialista' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:1705, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3603, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}

}
//BusinessRuleId:3603, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3603, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}

}
//BusinessRuleId:3603, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3603, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}

}
//BusinessRuleId:3603, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1707, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Solicitud_Seguimiento"
+" 	   set Solicitud = GLOBAL[SpartanOperationId] "
+" 	   where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:1707, Attribute:2, Operation:Object, Event:AFTERSAVING



//BusinessRuleId:3588, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Concluir_Acuerdo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { EvaluaQuery(" update Solicitud set Estatus = 101 where Clave = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable); EvaluaQuery(" exec usp_AsignarResolucionProcedimiento_DependiendoTipoDeAcuerdo GLOBAL[SpartanOperationId], FLDD[lblClave]", rowIndex, nameOfTable); EvaluaQuery("update relaciones_masc set Estatus = 101 where Clave = FLD[Relacion]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3588, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


