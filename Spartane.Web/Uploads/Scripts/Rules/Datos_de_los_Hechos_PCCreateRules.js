var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {




//BusinessRuleId:3087, Attribute:269230, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_PC").on('change', '#Estado', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3087, Attribute:269230, Operation:Field, Event:None





//BusinessRuleId:3088, Attribute:269231, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_PC").on('change', '#Municipio', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3088, Attribute:269231, Operation:Field, Event:None

//BusinessRuleId:3092, Attribute:269374, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_PC").on('change', '#Conoce_la_direccion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divCodigo_Postal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));$('#divCalle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));$('#divEntre_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));$('#divY_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));$('#divNumero_Exterior').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));$('#divNumero_Interior').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));$('#divReferencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));$('#divEs_una_direccion_exacta_o_aproximada').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Es_una_direccion_exacta_o_aproximada' + rowIndex));} else {}
});

//BusinessRuleId:3092, Attribute:269374, Operation:Field, Event:None



//BusinessRuleId:3093, Attribute:269374, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_PC").on('change', '#Conoce_la_direccion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divColonia').css('display', 'block');$('#divCodigo_Postal').css('display', 'block');$('#divCalle').css('display', 'block');$('#divEntre_Calle').css('display', 'block');$('#divY_Calle').css('display', 'block');$('#divNumero_Exterior').css('display', 'block');$('#divNumero_Interior').css('display', 'block');$('#divReferencia').css('display', 'block');$('#divEs_una_direccion_exacta_o_aproximada').css('display', 'block');} else {}
});

//BusinessRuleId:3093, Attribute:269374, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






//BusinessRuleId:3082, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_alguna_Foto_o_Evidencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); $('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:3082, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3082, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_alguna_Foto_o_Evidencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); $('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:3082, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3082, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_alguna_Foto_o_Evidencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); $('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:3082, Attribute:0, Operation:Object, Event:SCREENOPENING



















//BusinessRuleId:3090, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO =  FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO =  FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO =  FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO =  FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3090, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3090, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO =  FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO =  FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO =  FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO =  FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3090, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val();   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val();   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val();   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING





















//BusinessRuleId:3095, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex),EvaluaQuery(" SELECT NOMBRE FROM Estado WHERE CLAVE = 25", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));} var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3095, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3095, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex),EvaluaQuery(" SELECT NOMBRE FROM Estado WHERE CLAVE = 25", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));} var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3095, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3083, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),EvaluaQuery(" SELECT NOMBRE FROM PAIS WHERE CLAVE = 82", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}

}
//BusinessRuleId:3083, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3083, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),EvaluaQuery(" SELECT NOMBRE FROM PAIS WHERE CLAVE = 82", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}

}
//BusinessRuleId:3083, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3083, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),EvaluaQuery(" SELECT NOMBRE FROM PAIS WHERE CLAVE = 82", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}

}
//BusinessRuleId:3083, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:3096, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divCodigo_Postal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));$('#divCalle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));$('#divEntre_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));$('#divY_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));$('#divNumero_Exterior').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));$('#divNumero_Interior').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));$('#divReferencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));$('#divEs_una_direccion_exacta_o_aproximada').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Es_una_direccion_exacta_o_aproximada' + rowIndex));} else {}

}
//BusinessRuleId:3096, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3096, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divCodigo_Postal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));$('#divCalle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));$('#divEntre_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));$('#divY_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));$('#divNumero_Exterior').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));$('#divNumero_Interior').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));$('#divReferencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));$('#divEs_una_direccion_exacta_o_aproximada').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Es_una_direccion_exacta_o_aproximada' + rowIndex));} else {}

}
//BusinessRuleId:3096, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3097, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divColonia').css('display', 'block');$('#divCodigo_Postal').css('display', 'block');$('#divCalle').css('display', 'block');$('#divEntre_Calle').css('display', 'block');$('#divY_Calle').css('display', 'block');$('#divNumero_Exterior').css('display', 'block');$('#divNumero_Interior').css('display', 'block');$('#divReferencia').css('display', 'block');$('#divEs_una_direccion_exacta_o_aproximada').css('display', 'block');} else {}

}
//BusinessRuleId:3097, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3097, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divColonia').css('display', 'block');$('#divCodigo_Postal').css('display', 'block');$('#divCalle').css('display', 'block');$('#divEntre_Calle').css('display', 'block');$('#divY_Calle').css('display', 'block');$('#divNumero_Exterior').css('display', 'block');$('#divNumero_Interior').css('display', 'block');$('#divReferencia').css('display', 'block');$('#divEs_una_direccion_exacta_o_aproximada').css('display', 'block');} else {}

}
//BusinessRuleId:3097, Attribute:0, Operation:Object, Event:SCREENOPENING

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


