var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {


//BusinessRuleId:2641, Attribute:267400, Operation:Field, Event:None
$("form#CreateAudiencias_MP").on('change', '#Asignar_MP_Litigacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Asignar_MP_Litigacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divMP_Litigacion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'MP_Litigacion' + rowIndex));} else { $('#divMP_Litigacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'MP_Litigacion' + rowIndex));}
});

//BusinessRuleId:2641, Attribute:267400, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2633, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2642, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Asignar_MP_Litigacion' + rowIndex),nameOfTable,rowIndex)==EvaluaQuery("select 'true'",rowIndex, nameOfTable) ) { $('#divMP_Litigacion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'MP_Litigacion' + rowIndex));} else { $('#divMP_Litigacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'MP_Litigacion' + rowIndex));}

}
//BusinessRuleId:2642, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2642, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Asignar_MP_Litigacion' + rowIndex),nameOfTable,rowIndex)==EvaluaQuery("select 'true'",rowIndex, nameOfTable) ) { $('#divMP_Litigacion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'MP_Litigacion' + rowIndex));} else { $('#divMP_Litigacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'MP_Litigacion' + rowIndex));}

}
//BusinessRuleId:2642, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2642, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Asignar_MP_Litigacion' + rowIndex),nameOfTable,rowIndex)==EvaluaQuery("select 'true'",rowIndex, nameOfTable) ) { $('#divMP_Litigacion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'MP_Litigacion' + rowIndex));} else { $('#divMP_Litigacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'MP_Litigacion' + rowIndex));}

}
//BusinessRuleId:2642, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2643, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).val();   $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'MP_Litigacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select distinct spu.Id_User, spu.Name from expediente_ministerio_publico emp inner join Spartan_User spu on spu.Unidad = emp.unidad where emp.clave = GLOBAL[SpartanOperationId] and spu.Role = 21", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select distinct spu.Id_User, spu.Name from expediente_ministerio_publico emp inner join Spartan_User spu on spu.Unidad = emp.unidad where emp.clave = GLOBAL[SpartanOperationId] and spu.Role = 21", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2643, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2643, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).val();   $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'MP_Litigacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select distinct spu.Id_User, spu.Name from expediente_ministerio_publico emp inner join Spartan_User spu on spu.Unidad = emp.unidad where emp.clave = GLOBAL[SpartanOperationId] and spu.Role = 21", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select distinct spu.Id_User, spu.Name from expediente_ministerio_publico emp inner join Spartan_User spu on spu.Unidad = emp.unidad where emp.clave = GLOBAL[SpartanOperationId] and spu.Role = 21", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'MP_Litigacion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2643, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:2636, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Audiencias_MP set expediente_mp = GLOBAL[SpartanOperationId] where clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2636, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2636, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" update Audiencias_MP set expediente_mp = GLOBAL[SpartanOperationId] where clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2636, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Audiencia_Defensor_Imputado//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Audiencia_Defensor_Imputado//
}
function EjecutarValidacionesAlEliminarMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Audiencia_Defensor_Imputado//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndex){
    var result = true;
    







//BusinessRuleId:2634, Attribute:267393, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2634, Attribute:267393, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2634, Attribute:267393, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2634, Attribute:267393, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Audiencia_Defensor_Imputado//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Audiencia_Defensor_Imputado(nameOfTable, rowIndex){
    var result = true;
    







//BusinessRuleId:2634, Attribute:267393, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2634, Attribute:267393, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2634, Attribute:267393, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_Del_Imputado' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2634, Attribute:267393, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Audiencia_Defensor_Imputado//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Audiencia_Defensor_Victima//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Audiencia_Defensor_Victima//
}
function EjecutarValidacionesAlEliminarMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Audiencia_Defensor_Victima//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndex){
    var result = true;
    







//BusinessRuleId:2635, Attribute:267394, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2635, Attribute:267394, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2635, Attribute:267394, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2635, Attribute:267394, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Audiencia_Defensor_Victima//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Audiencia_Defensor_Victima(nameOfTable, rowIndex){
    var result = true;
    







//BusinessRuleId:2635, Attribute:267394, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2635, Attribute:267394, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2635, Attribute:267394, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_del_Imputado' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2635, Attribute:267394, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Audiencia_Defensor_Victima//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Audiencia_Archivos_Adjuntos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Audiencia_Archivos_Adjuntos//
}
function EjecutarValidacionesAlEliminarMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Audiencia_Archivos_Adjuntos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Audiencia_Archivos_Adjuntos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Audiencia_Archivos_Adjuntos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Audiencia_Archivos_Adjuntos//
    return result;
}

