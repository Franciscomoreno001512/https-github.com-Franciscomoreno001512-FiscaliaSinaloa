var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
    $("#Consulta_de_Mandamientos_JudicialesGuardarYNuevo, #Consulta_de_Mandamientos_JudicialesGuardarYCopia, #Consulta_de_Mandamientos_JudicialesCancelar").remove();

    $("#Buscar_por_Datos").on('click',function(){
        fillMRFromQuery('Detalle_de_Resultados', "exec uspConsultaMandamientosJudiciales ' FLD[MandamientoJudicialId] ',' FLD[Nombre] ',' FLD[Apellido_Paterno] ',' FLD[Apellido_Materno] ',' FLD[Alias] ',' FLD[Pais] ',' FLD[Estado] ',' FLD[Municipio] ' ,' FLD[Juzgado] ',' FLD[Oficio_Solicitud_Juzgado] ',' FLD[Carpeta_de_Investigacion] ',' FLD[Causa_Penal] '");
    });
    $("#Buscar_por_Huellas").on('click',function(){
        fillMRFromQuery('Detalle_de_Resultados', "exec uspConsultaMandamientosJudiciales ' FLD[MandamientoJudicialId] ',' FLD[Nombre] ',' FLD[Apellido_Paterno] ',' FLD[Apellido_Materno] ',' FLD[Alias] ',' FLD[Pais] ',' FLD[Estado] ',' FLD[Municipio] ' ,' FLD[Juzgado] ',' FLD[Oficio_Solicitud_Juzgado] ',' FLD[Carpeta_de_Investigacion] ',' FLD[Causa_Penal] '");
    });


//BusinessRuleId:4963, Attribute:273778, Operation:Field, Event:None
$("form#CreateConsulta_de_Mandamientos_Judiciales").on('change', '#Pais', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre from Estado where Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre from Estado where Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change');} else { var valor = $('#' + nameOfTable + 'Pais' + rowIndex).val();   $('#' + nameOfTable + 'Pais' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Pais' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Pais' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre from Estado", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Pais' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre from Estado", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Pais' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Pais' + rowIndex).val(valor).trigger('change');}
});


//BusinessRuleId:4963, Attribute:273778, Operation:Field, Event:None

//BusinessRuleId:4964, Attribute:273779, Operation:Field, Event:None
$("form#CreateConsulta_de_Mandamientos_Judiciales").on('change', '#Estado', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Estado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre from Municipio where Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre from Municipio where Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');} else { var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre from Municipio", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre from Municipio", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');}
});


//BusinessRuleId:4964, Attribute:273779, Operation:Field, Event:None



























//BusinessRuleId:4965, Attribute:273780, Operation:Field, Event:None
$("form#CreateConsulta_de_Mandamientos_Judiciales").on('change', '#Municipio', function () {
	nameOfTable='';
	rowIndex='';
 fillMRFromQuery('Detalle_de_Resultados', "exec uspConsultaMandamientosJudiciales ' FLD[MandamientoJudicialId] ',' FLD[Nombre] ',' FLD[Apellido_Paterno] ',' FLD[Apellido_Materno] ',' FLD[Alias] ',' FLD[Pais] ',' FLD[Estado] ',' FLD[Municipio] ' ,' FLD[Juzgado] ',' FLD[Oficio_Solicitud_Juzgado] ',' FLD[Carpeta_de_Investigacion] ',' FLD[Causa_Penal] '");
});


//BusinessRuleId:4965, Attribute:273780, Operation:Field, Event:None




//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:4958, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMandamientoJudicialId').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'MandamientoJudicialId' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Consulta_de_Ordenes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'MandamientoJudicialId' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Oficio_Solicitud_Juzgado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_Penal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fuente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mandamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));


}
//BusinessRuleId:4958, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4958, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMandamientoJudicialId').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'MandamientoJudicialId' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Consulta_de_Ordenes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'MandamientoJudicialId' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Oficio_Solicitud_Juzgado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_Penal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fuente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mandamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));


}
//BusinessRuleId:4958, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4958, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMandamientoJudicialId').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'MandamientoJudicialId' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Consulta_de_Ordenes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'MandamientoJudicialId' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juzgado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Oficio_Solicitud_Juzgado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Carpeta_de_Investigacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_Penal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fuente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mandamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));


}
//BusinessRuleId:4958, Attribute:0, Operation:Object, Event:SCREENOPENING











//BusinessRuleId:4961, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex),EvaluaQuery("select Nombre from Estado where  Clave = 25", rowIndex, nameOfTable)); var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre from Estado", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre from Estado", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),EvaluaQuery("select Nombre from Pais where  Clave = 82", rowIndex, nameOfTable));


}
//BusinessRuleId:4961, Attribute:0, Operation:Object, Event:SCREENOPENING

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

function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Resultados(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Resultados//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Resultados(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Resultados//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Resultados(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Resultados//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Resultados(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Resultados//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Resultados(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Resultados//
    return result;
}

