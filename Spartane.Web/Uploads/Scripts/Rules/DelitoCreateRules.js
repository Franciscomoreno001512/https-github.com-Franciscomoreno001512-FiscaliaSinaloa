var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//BusinessRuleId:2570, Attribute:267348, Operation:Field, Event:None
$("#Configuracion_de_PlaneacionGrid").on('change', '.Categoria', function () {
	nameOfTable = $(this).parent().parent().parent().parent()[0].id.replace('Grid', '') + '_';
	rowIndex = '_' + $(this).parent().parent()[0].className.replace(' odd', '').replace(' even', '').replace(nameOfTable, '');
 var valor = $('#' + nameOfTable + 'Servicio' + rowIndex).val();   $('#' + nameOfTable + 'Servicio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Servicio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Servicio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Servicio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Servicio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Servicio' + rowIndex).val(valor).trigger('change');
	nameOfTable='';
	rowIndex='';
});

//BusinessRuleId:2570, Attribute:267348, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
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



function EjecutarValidacionesAntesDeGuardarMRConfiguracion_de_Planeacion(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Configuracion_de_Planeacion// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRConfiguracion_de_Planeacion(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Configuracion_de_Planeacion// 
} 

function EjecutarValidacionesAlEliminarMRConfiguracion_de_Planeacion(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Configuracion_de_Planeacion// 
 return result; 
} 

function EjecutarValidacionesNewRowMRConfiguracion_de_Planeacion(nameOfTable, rowIndex){ 
 var result= true; 


//BusinessRuleId:2572, Attribute:267355, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Servicio' + rowIndex).val();   $('#' + nameOfTable + 'Servicio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Servicio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Servicio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Servicio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Servicio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Servicio' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2572, Attribute:267355, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Configuracion_de_Planeacion// 
  return result; 
} 

function EjecutarValidacionesEditRowMRConfiguracion_de_Planeacion(nameOfTable, rowIndex){ 
 var result= true; 
//BusinessRuleId:2572, Attribute:267355, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Servicio' + rowIndex).val();   $('#' + nameOfTable + 'Servicio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Servicio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Servicio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Servicio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Servicio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Servicio' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2572, Attribute:267355, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Configuracion_de_Planeacion// 
 return result; 
} 
