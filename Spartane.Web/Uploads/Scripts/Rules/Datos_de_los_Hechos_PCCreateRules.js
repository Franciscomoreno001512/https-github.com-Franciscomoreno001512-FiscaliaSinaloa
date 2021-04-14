var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
	$("#Datos_de_los_Hechos_PCGuardarYNuevo").addClass("hidden");
	$("#Datos_de_los_Hechos_PCGuardarYCopia").addClass("hidden");
if(roleActivo==110 || roleActivo==108){
	$("#ConfigureSave").addClass("hidden");
	$("#Datos_de_los_Hechos_PCCancelar").addClass("hidden");
	$("#Datos_de_los_Hechos_PCGuardar").addClass("hidden");	
}else{
	$("#Datos_de_los_Hechos_PCSiguiente").addClass("hidden");
	$("#Datos_de_los_Hechos_PCAnterior").addClass("hidden");	
}
if(roleActivo==110 || roleActivo == 108){
	$("#side-menu").addClass("hidden");
	$("#logoutForm").addClass("hidden");
}

//BusinessRuleId:3087, Attribute:269230, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_PC").on('change', '#Estado', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3087, Attribute:269230, Operation:Field, Event:None







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

//BusinessRuleId:3088, Attribute:269231, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_PC").on('change', '#Municipio', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] AND Tipo = 2 AND Estatus = 'v'", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] AND Tipo = 2 AND Estatus = 'v'", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] AND Tipo = 1 AND Estatus = 'v'", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] AND Tipo = 1 AND Estatus = 'v'", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3088, Attribute:269231, Operation:Field, Event:None

//BusinessRuleId:4802, Attribute:269232, Operation:Field, Event:None
$("form#CreateDatos_de_los_Hechos_PC").on('change', '#Poblacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] AND Tipo = 1 AND Estatus = 'v'", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] AND Tipo = 1 AND Estatus = 'v'", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');} else {}
});

//BusinessRuleId:4802, Attribute:269232, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});

$("#Datos_de_los_Hechos_PCSiguiente").on("click", function() {  
	var valform = checkClientValidate('Datos_de_los_Hechos_PCCreateForm');
	if(!valform){			
			return;			
	}else{			 		
		debugger;
		if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
			if (!SendDatos_de_los_Hechos_PCData(function () {
					EjecutarValidacionesDespuesDeGuardar();	
					localStorage.setItem("IdHechos", newIDInv);
					try {
						var IdProbable = localStorage.getItem("IdProbable");
						if(IdProbable != null){																
							window.location="../Probable_Responsable_PC/Create?Id=" + IdProbable;
							return;
						}
					} catch (error) {
								
					}	
					window.location="../Probable_Responsable_PC/Create";	
					return;
			})) {
					
			}									
		}			
		console.log("aqui guarda");				
	}	
});

$("#Datos_de_los_Hechos_PCAnterior").on("click", function() {  
var idinvolucrado="0";
			try {
				var EsTestigo = localStorage.getItem("EsTestigo");
				if(EsTestigo=="1"){									
					idinvolucrado = localStorage.getItem("IdTestigo");
				}else{
					idinvolucrado = localStorage.getItem("IdVictima");
				}
			} catch (error) {
				
			}
	window.location="../Involucrados_PC/Create?Id=" + idinvolucrado;	
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







//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val();   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).val();   $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val();   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).val();   $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val();   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).val();   $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3091, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3153, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));

}
//BusinessRuleId:3153, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3153, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));

}
//BusinessRuleId:3153, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3153, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));

}
//BusinessRuleId:3153, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3152, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Solicitud' + rowIndex),EvaluaQuery(" SELECT FOLIO FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),EvaluaQuery(" SELECT TIPO_DE_SOLICITUD FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));

}
//BusinessRuleId:3152, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3152, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Solicitud' + rowIndex),EvaluaQuery(" SELECT FOLIO FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),EvaluaQuery(" SELECT TIPO_DE_SOLICITUD FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));

}
//BusinessRuleId:3152, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3154, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}

}
//BusinessRuleId:3154, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3154, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}

}
//BusinessRuleId:3154, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3154, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}

}
//BusinessRuleId:3154, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3187, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('110', '110') ) { $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));$('#divTipo_de_Solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));} else {}

}
//BusinessRuleId:3187, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3187, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('110', '110') ) { $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));$('#divTipo_de_Solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));} else {}

}
//BusinessRuleId:3187, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3187, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('110', '110') ) { $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));$('#divTipo_de_Solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));} else {}

}
//BusinessRuleId:3187, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3196, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),'2');

}
//BusinessRuleId:3196, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3258, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') ) { DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Titulo_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Narrativa_Breve_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_Aproximada_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tiene_alguna_Foto_o_Evidencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_alguna_Foto_o_Evidencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Es_una_direccion_exacta_o_aproximada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Es_una_direccion_exacta_o_aproximada' + rowIndex));}DisabledControl($("#" + nameOfTable + "Conoce_la_direccion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fosa_clandestina" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex));}} else {}

}
//BusinessRuleId:3258, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3258, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') ) { DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Titulo_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Narrativa_Breve_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_Aproximada_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tiene_alguna_Foto_o_Evidencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_alguna_Foto_o_Evidencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Es_una_direccion_exacta_o_aproximada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Es_una_direccion_exacta_o_aproximada' + rowIndex));}DisabledControl($("#" + nameOfTable + "Conoce_la_direccion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fosa_clandestina" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex));}} else {}

}
//BusinessRuleId:3258, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3258, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') ) { DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Titulo_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Narrativa_Breve_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_Aproximada_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tiene_alguna_Foto_o_Evidencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_alguna_Foto_o_Evidencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Es_una_direccion_exacta_o_aproximada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Es_una_direccion_exacta_o_aproximada' + rowIndex));}DisabledControl($("#" + nameOfTable + "Conoce_la_direccion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Conoce_la_direccion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fosa_clandestina" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fosa_clandestina' + rowIndex));}} else {}

}
//BusinessRuleId:3258, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3195, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('108', '108') ) { AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),'1'); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));} else {}

}
//BusinessRuleId:3195, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3195, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('108', '108') ) { AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),'1'); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));} else {}

}
//BusinessRuleId:3195, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
ValidaArchivos('#Tiene_alguna_Foto_o_EvidenciaFile',['pdf','jpg','jpeg','pnf','gift'], 4); //selector, extensions, filesize
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//NEWBUSINESSRULE_AFTERSAVING//
}


//fjmore


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




var poblacionP;
function CambiaMunicipio(deesc) {
    debugger;

    if (deesc.toLowerCase() == "Culiacán Rosales".toLowerCase()) {
        deesc = "Culiacán";
    }

    $('#Municipio').val(null).trigger('change');
    var control = $('#Municipio');


    var rdesc = EvaluaQuery("usp_GetMunicipioYPoblacion '" + $('#Estado').val() + "', '" + deesc + "'");
    var split = rdesc.split(',');
    var ValorMunicipio = split[0];

    poblacionP = split[1];

    control.select2('open');
    $('.select2-search__field').val(ValorMunicipio).trigger('keyup');
    control.select2('close');
     var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
        control.select2({ data: data });
    control.val(ValorMunicipio).trigger('change');
}

function CambiaPoblacion(deesc) {
    debugger;
    $('#Poblacion').val(null).trigger('change');
    var control = $('#Poblacion');

     var valorPobla = 0;
    if (poblacionP == "0") {
        var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
        var query = "select top 1 clave from Colonia where Municipio = '" + $('#Municipio').val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
        valorPobla = EvaluaQuery(query);
    }
    else {
        valorPobla = poblacionP;
    }



    control.select2('open');
    $('.select2-search__field').val(valorPobla).trigger('keyup');
    control.select2('close');
     var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
        control.select2({ data: data });
    control.val(valorPobla).trigger('change');
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
		//updated
}