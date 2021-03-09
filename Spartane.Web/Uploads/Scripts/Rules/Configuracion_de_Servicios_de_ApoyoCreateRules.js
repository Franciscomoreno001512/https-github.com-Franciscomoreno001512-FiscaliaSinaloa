var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;




$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {



		








//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;






//BusinessRuleId:4298, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(*) FROM Configuracion_de_Servicios_de_Apoyo WHERE REGION = FLD[Region] AND AREA = FLD[Area] AND SUBAREA = FLD[SubArea] AND Clave = FLDD[lblClave]",rowIndex, nameOfTable)>=TryParseInt('1', '1') ) { alert(DecodifyText('Ya existe un registro para esta misma región, área y subárea, favor de verificar.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4298, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4297, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(*) FROM Configuracion_de_Servicios_de_Apoyo WHERE REGION = FLD[Region] AND AREA = FLD[Area] AND SUBAREA = FLD[SubArea]",rowIndex, nameOfTable)>=TryParseInt('1', '1') ) { alert(DecodifyText('Ya existe un registro para esta misma región, área y subárea, favor de verificar.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4297, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Solicitud_Disponibles_Configuracion//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Solicitud_Disponibles_Configuracion//
}
function EjecutarValidacionesAlEliminarMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Solicitud_Disponibles_Configuracion//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:4345, Attribute:273103, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:4345, Attribute:273103, Operation:Object, Event:NEWROWMR

//BusinessRuleId:4345, Attribute:273103, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:4345, Attribute:273103, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Solicitud_Disponibles_Configuracion//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Solicitud_Disponibles_Configuracion(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:4345, Attribute:273103, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:4345, Attribute:273103, Operation:Object, Event:EDITROWMR

//BusinessRuleId:4345, Attribute:273103, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:4345, Attribute:273103, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Solicitud_Disponibles_Configuracion//
    return result;
}

