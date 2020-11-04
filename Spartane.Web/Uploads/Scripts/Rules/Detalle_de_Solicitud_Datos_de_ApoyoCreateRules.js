var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;

$("#Detalle_de_Solicitud_Datos_de_ApoyoGuardarYNuevo").hide()
$("#Detalle_de_Solicitud_Datos_de_ApoyoGuardarYCopia").hide()

$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:1712, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));DisabledControl($("#" + nameOfTable + "Usuario_que_registra" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); var valor = $('#' + nameOfTable + 'Solicitante' + rowIndex).val();   $('#' + nameOfTable + 'Solicitante' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Solicitante' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_Solicitante where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_Solicitante where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Solicitante' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Solicitante' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:1712, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1712, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));DisabledControl($("#" + nameOfTable + "Usuario_que_registra" + rowIndex), ("true" == "true")); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); var valor = $('#' + nameOfTable + 'Solicitante' + rowIndex).val();   $('#' + nameOfTable + 'Solicitante' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Solicitante' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_Solicitante where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Solicitante' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre_completo from Detalle_de_Solicitud_Solicitante where solicitud=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Solicitante' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Solicitante' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:1712, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1713, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_registra' + rowIndex),EvaluaQuery(" select Name from  Spartan_User where id_user=GLOBAL[USERID]", rowIndex, nameOfTable)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));


}
//BusinessRuleId:1713, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1972, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1972, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1972, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1972, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1972, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1972, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1714, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Solicitud_Datos_de_Apoyo"
+" 	set Solicitud = GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:1714, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


