var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
    if( 
        EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('101', '101') 
      ) {
        $("#Datos_de_los_Hechos_ATGuardar").remove();
        $("#Datos_de_los_Hechos_ATGuardarYNuevo").remove();
        $("#Datos_de_los_Hechos_ATGuardarYCopia").remove();
    }
    if (
        EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('3', '3') ||
        EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('2', '2') ||
        EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('103', '103')
    ) {
        $("#Datos_de_los_Hechos_ATGuardar").remove();
       
    }

//CONVERTIR A MAYUSCULAS AL BLUR
$('input[type="text"],textarea').blur(function() {
	this.value = this.value.toUpperCase();
	});
//END CONVERTIR A MAYUSCULAS AL BLUR

//BusinessRuleId:2932, Attribute:268412, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_AT").on('change', '#Estado', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Estado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:2932, Attribute:268412, Operation:Field, Event:None





//BusinessRuleId:2931, Attribute:268411, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_AT").on('change', '#Pais', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)==TryParseInt('82', '82') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); $('#divEstado').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divPoblacion').css('display', 'block');$('#divColonia').css('display', 'block');} else { $('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}
});


//BusinessRuleId:2931, Attribute:268411, Operation:Field, Event:None































//BusinessRuleId:3445, Attribute:268409, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_AT").on('change', '#Fecha_del_Hecho', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103), "
+" CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_del_Hecho]',103),103))",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText(' No se puede ingresar una fecha mayor al dia de hoy.', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex),' ');} else {}
});


//BusinessRuleId:3445, Attribute:268409, Operation:Field, Event:None



//BusinessRuleId:3446, Attribute:268426, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_AT").on('change', '#Documento_Extraviado', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Documento_Extraviado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divTipo_de_Documento_Extraviado').css('display', 'block');} else { $('#divTipo_de_Documento_Extraviado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));}
});

//BusinessRuleId:3446, Attribute:268426, Operation:Field, Event:None

//BusinessRuleId:2933, Attribute:268413, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_AT").on('change', '#Municipio', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');} else {}
});

//BusinessRuleId:2933, Attribute:268413, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2928, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));


}
//BusinessRuleId:2928, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2928, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));


}
//BusinessRuleId:2928, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2928, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));


}
//BusinessRuleId:2928, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2929, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}


}
//BusinessRuleId:2929, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2929, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}


}
//BusinessRuleId:2929, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2929, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}


}
//BusinessRuleId:2929, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2934, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));


}
//BusinessRuleId:2934, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2934, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));


}
//BusinessRuleId:2934, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2939, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));$('#divExpediente_MASC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


}
//BusinessRuleId:2939, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2939, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));$('#divExpediente_MASC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


}
//BusinessRuleId:2939, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2939, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));$('#divExpediente_MASC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


}
//BusinessRuleId:2939, Attribute:0, Operation:Object, Event:SCREENOPENING

//COD-MANI INI OCULTAR BOTONES
$('#Datos_de_los_Hechos_ATGuardarYNuevo').css('display', 'none');
$('#Datos_de_los_Hechos_ATGuardarYCopia').css('display', 'none');
//COD-MANI END OCULTAR BOTONES

//BusinessRuleId:3016, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT Tipo_de_Denuncia FROM Modulo_Atencion_Inicial WHERE CLAVE = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));} else {}


}
//BusinessRuleId:3016, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3016, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT Tipo_de_Denuncia FROM Modulo_Atencion_Inicial WHERE CLAVE = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));} else {}


}
//BusinessRuleId:3016, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3016, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("SELECT Tipo_de_Denuncia FROM Modulo_Atencion_Inicial WHERE CLAVE = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));} else {}


}
//BusinessRuleId:3016, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2930, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)==TryParseInt('82', '82') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); $('#divEstado').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divPoblacion').css('display', 'block');$('#divColonia').css('display', 'block');} else { $('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}


}
//BusinessRuleId:2930, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2930, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)==TryParseInt('82', '82') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); $('#divEstado').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divPoblacion').css('display', 'block');$('#divColonia').css('display', 'block');} else { $('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}


}
//BusinessRuleId:2930, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3447, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Documento_Extraviado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divTipo_de_Documento_Extraviado').css('display', 'block');} else { $('#divTipo_de_Documento_Extraviado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));}

}
//BusinessRuleId:3447, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3447, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Documento_Extraviado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divTipo_de_Documento_Extraviado').css('display', 'block');} else { $('#divTipo_de_Documento_Extraviado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));}

}
//BusinessRuleId:3447, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3619, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt('3', '3')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('101', '101')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('2', '2')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('103', '103')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Titulo_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Narrativa_Breve_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Prioridad_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_Aproximada_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Documento_Extraviado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Documento_Extraviado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MASC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));}} else {}

}
//BusinessRuleId:3619, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3619, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('101', '101')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('2', '2')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('103', '103')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Titulo_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Narrativa_Breve_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Prioridad_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_Aproximada_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Documento_Extraviado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Documento_Extraviado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MASC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));}} else {}

}
//BusinessRuleId:3619, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//BusinessRuleId:3449, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Documento_Extraviado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') ) { alert(DecodifyText(' Debe seleccionar un tipo de documento extraviado', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3449, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:3449, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Documento_Extraviado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') ) { alert(DecodifyText(' Debe seleccionar un tipo de documento extraviado', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3449, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){






//BusinessRuleId:2918, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("EXEC UspUpdDatosHechos_A_AtencionInicial FLDD[lblClave]", rowIndex, nameOfTable);


}
//BusinessRuleId:2918, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2916, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" EXEC UspUpdDatosHechos_A_AtencionInicial GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:2916, Attribute:2, Operation:Object, Event:AFTERSAVING

















//BusinessRuleId:2940, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[idTablero]",rowIndex, nameOfTable)==TryParseInt('3', '3') ) { EvaluaQuery(" update Datos_de_los_Hechos_AT set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:2940, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3262, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[idTablero]",rowIndex, nameOfTable)==TryParseInt('3', '3') ) { EvaluaQuery("update Datos_de_los_Hechos_AT set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=FLDD[lblClave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:3262, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


function CambiaPais(deesc) {
    debugger;
    $('#Pais').val(null).trigger('change');
    var control = $('#Pais');
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from pais where dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
	 var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
        control.select2({ data: data });
        control.val(valorPaisId).trigger('change');
 
}
function CambiaEstado(deesc)
{
	debugger;
    $('#Estado').val(null).trigger('change');
    var control = $('#Estado');
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Estado where pais = '" + $('#Pais').val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
	 var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
        control.select2({ data: data });
        control.val(valorPaisId).trigger('change');
   
}




function CambiaMunicipio(deesc) {
    debugger;
    $('#Municipio').val(null).trigger('change');
    var control = $('#Municipio');
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Municipio where estado = '" + $('#Estado').val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
     var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
        control.select2({ data: data });
        control.val(valorPaisId).trigger('change');
}

function CambiaPoblacion(deesc) {
    debugger;
    $('#Poblacion').val(null).trigger('change');
    var control = $('#Poblacion');
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Colonia where Municipio = '" + $('#Municipio').val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
     var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
        control.select2({ data: data });
        control.val(valorPaisId).trigger('change');
}
function CambiaColonia(deesc) {
    debugger;
    $('#Colonia').val(null).trigger('change');
    var control = $('#Colonia');
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Colonia where Municipio = '" + $('#Municipio').val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
     var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
        control.select2({ data: data });
        control.val(valorPaisId).trigger('change');
}


function CargaGoogleMaps() {
   
   
    debugger;
    $("#Codigo_Postal").val(("")); 
    $('#Pais').val(null).trigger('change');
    $('#Estado').val(null).trigger('change');
    $('#Municipio').val(null).trigger('change');
    $('#Colonia').val(null).trigger('change');
    $('#Poblacion').val(null).trigger('change');
    $("#Calle").val((""));
    $("#Numero_Exterior").val((""));
    $('#Latitud').val("");
    $('#Longitud').val("");
	
	
    var map; // el mapa
    var marker; //el marcador
    var myLatlng; //el objeto latitud y longitud
    var geocoder = new google.maps.Geocoder();
    var infowindow = new google.maps.InfoWindow();
    initialize();
    function initialize() {
        var mapOptions = {
            zoom: jQuery('input[name=address]').val() == "" ? 8: 18,
            center: myLatlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        }
        map = new google.maps.Map(document.getElementById("gmap"), mapOptions); //gmap es el DIV que contendrá el Mapa
        marker = new google.maps.Marker({
            map: map,
            position: myLatlng,
            draggable: true // se refiere a que se puede navagar por el mapa
        });

        // Se dispara despúes de que se mueve el marcador
        geocoder.geocode({ 'latLng': myLatlng }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                if (results[0]) {
                    $('#Latitud').val(marker.getPosition().lat());
                    $('#Longitud').val(marker.getPosition().lng());
                    infowindow.setContent(results[0].formatted_address); //presenta la direccion completa sobre el marquer donde estamos posicionados es como una especie de ToolTip
                    infowindow.open(map, marker);
                }
            }
        });

        google.maps.event.addListener(map, 'click', function (event) {
            placeMarker(event.latLng);
            geocoder.geocode({ 'latLng': marker.getPosition() }, function (results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    if (results[0]) {
                        debugger;
                        //  for (var i = results[0].address_components.length; i < 0 ; i--) {
                        for (var i = results[0].address_components.length - 1; i >= 0; i--) {

                            if (results[0].address_components[i].types[0] == "postal_code") {
                                $("#Codigo_Postal").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "country") {
                                debugger;
                                CambiaPais(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), results[0].address_components[i].long_name);


                            }

                            if (results[0].address_components[i].types[0] == "administrative_area_level_1") {
                                CambiaEstado(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), results[0].address_components[i].long_name);
                            }

                            if (results[0].address_components[i].types[0] == "locality") {
                                CambiaMunicipio(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex), results[0].address_components[i].long_name);
                            }


                            if (results[0].address_components[i].types[0] == "political") { // segun spartanMetadata poblacion es igual a colonia

                                CambiaPoblacion(results[0].address_components[i].long_name);
                                CambiaColonia(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Colonia' + rowIndex), results[0].address_components[i].long_name);
                                //AsignarValor($('#' + nameOfTable + 'Poblacion' + rowIndex), results[0].address_components[i].long_name);
                            }



                            if (results[0].address_components[i].types[0] == "route") {
                                $("#Calle").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "street_number") {
                                $("#Numero_Exterior").val((results[0].address_components[i].long_name));
                            }



                        }
                        $('#Latitud').val(marker.getPosition().lat());
                        $('#Longitud').val(marker.getPosition().lng());
                        infowindow.setContent(results[0].formatted_address);
                        infowindow.open(map, marker);
                    }
                }
            });

        });
        function placeMarker(location) {

            if (marker == null) {
                marker = new google.maps.Marker({
                    position: location,
                    map: map
                });
            }
            else {
                marker.setPosition(location);
            }


        }


        // Evento que se dispara cuando se mueve el marcador en en el mapa (es el Marcador de posicion de color Rojo)
        // cada pixel que se mueve o se arrastra se recalcula la latitud y la longitud
        google.maps.event.addListener(marker, 'dragend', function () {
            geocoder.geocode({ 'latLng': marker.getPosition() }, function (results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    if (results[0]) {
                        debugger;
                      //  for (var i = results[0].address_components.length; i < 0 ; i--) {
							 for (var i=results[0].address_components.length -1; i>=0; i--) {

                            if (results[0].address_components[i].types[0] == "postal_code") {
                                $("#Codigo_Postal").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "country") {
                                debugger;
                                CambiaPais(results[0].address_components[i].long_name);
                               // AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), results[0].address_components[i].long_name);

                              
                            }

                            if (results[0].address_components[i].types[0] == "administrative_area_level_1") {
                                CambiaEstado(results[0].address_components[i].long_name);
                               // AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), results[0].address_components[i].long_name);
                            }

                            if (results[0].address_components[i].types[0] == "locality") {
                                CambiaMunicipio(results[0].address_components[i].long_name);
                               // AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex), results[0].address_components[i].long_name);
                            }


                            if (results[0].address_components[i].types[0] == "political") { // segun spartanMetadata poblacion es igual a colonia
								
								CambiaPoblacion(results[0].address_components[i].long_name);
								CambiaColonia(results[0].address_components[i].long_name);
                               // AsignarValor($('#' + nameOfTable + 'Colonia' + rowIndex), results[0].address_components[i].long_name);
                                //AsignarValor($('#' + nameOfTable + 'Poblacion' + rowIndex), results[0].address_components[i].long_name);
                            }

                            

                            if (results[0].address_components[i].types[0] == "route") {
                                $("#Calle").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "street_number") {
                                $("#Numero_Exterior").val((results[0].address_components[i].long_name));
                            }
                            


                        }
                        $('#Latitud').val(marker.getPosition().lat());
                        $('#Longitud').val(marker.getPosition().lng());
                        infowindow.setContent(results[0].formatted_address);
                        infowindow.open(map, marker);
                    }
                }
            });
        });
    }

    google.maps.event.addDomListener(window, 'load', initialize);

    // Buscamos la direccion escrita (solo busca todavia no asigna) y no posicionamos sobre ella, se dispara cuando se le da click al boton buscar dentro de la modal que contiene al mapa
    // var geocoder = new google.maps.Geocoder();
    geocoder.geocode({
        address: jQuery('input[name=address]').val() == "" ? "Badiraguto Sinaloa,Mexico" : $('input[name=address]').val(),
        region: 'no'
    },
        function (results, status) {
            if (status.toLowerCase() == 'ok') {
                var coords = new google.maps.LatLng(
                    results[0]['geometry']['location'].lat(), //asignamos Latitud de la dirección buscada
                    results[0]['geometry']['location'].lng() //asignamos Longitud de la dirección buscada
                );
                map.setCenter(coords); //para que la direción buscada se muestre centrada en nel mapa

                //map.setZoom(10) //zoom
                marker = new google.maps.Marker({
                    position: coords,
                    map: map,
                    title: jQuery('input[name=address]').val(),
                });
                myLatlng = coords;
                initialize();
            } else {
                alert(status);
                return;
            }
        });
}

$( "#Codigo_Postal" ).keyup(function() { 
    var str = $('#' + nameOfTable + 'Codigo_Postal' + rowIndex).val(); 
    if (str != ""){ 
        var regNUM = /^[0-9]{1,5}$/ 
        var validacionnum=regNUM.test(str)
        if (validacionnum==false ) { 
            $('#' + nameOfTable + 'Codigo_Postal' + rowIndex).val($('#' + nameOfTable + 'Codigo_Postal' + rowIndex).val().slice(0, -1));
        } 
    } 
    });