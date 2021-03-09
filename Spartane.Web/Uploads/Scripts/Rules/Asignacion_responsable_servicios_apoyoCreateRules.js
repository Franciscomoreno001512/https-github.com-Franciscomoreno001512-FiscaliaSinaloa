var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {


//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {




//BusinessRuleId:4348, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Usuario' + rowIndex).val();   $('#' + nameOfTable + 'Usuario' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Usuario' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Usuario' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT ID_USER, NAME FROM SPARTAN_USER WHERE ROLE IN (7,115,117)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Usuario' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT ID_USER, NAME FROM SPARTAN_USER WHERE ROLE IN (7,115,117)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Usuario' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Usuario' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:4348, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4348, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Usuario' + rowIndex).val();   $('#' + nameOfTable + 'Usuario' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Usuario' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Usuario' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT ID_USER, NAME FROM SPARTAN_USER WHERE ROLE IN (7,115,117)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Usuario' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT ID_USER, NAME FROM SPARTAN_USER WHERE ROLE IN (7,115,117)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Usuario' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Usuario' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:4348, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_subareas_responsable_servicio_apoyo//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_subareas_responsable_servicio_apoyo//
}
function EjecutarValidacionesAlEliminarMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_subareas_responsable_servicio_apoyo//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndex){
    var result = true;
    



















//BusinessRuleId:4349, Attribute:273110, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).val();   $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).empty();         if(!$('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLDP[Area_Asignada]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLDP[Area_Asignada]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:4349, Attribute:273110, Operation:Object, Event:NEWROWMR

//BusinessRuleId:4349, Attribute:273110, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).val();   $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).empty();         if(!$('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLDP[Area_Asignada]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLDP[Area_Asignada]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:4349, Attribute:273110, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_subareas_responsable_servicio_apoyo//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_subareas_responsable_servicio_apoyo(nameOfTable, rowIndex){
    var result = true;
    



















//BusinessRuleId:4349, Attribute:273110, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).val();   $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).empty();         if(!$('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLDP[Area_Asignada]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLDP[Area_Asignada]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:4349, Attribute:273110, Operation:Object, Event:EDITROWMR

//BusinessRuleId:4349, Attribute:273110, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).val();   $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).empty();         if(!$('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLDP[Area_Asignada]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLDP[Area_Asignada]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:4349, Attribute:273110, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_subareas_responsable_servicio_apoyo//
    return result;
}

