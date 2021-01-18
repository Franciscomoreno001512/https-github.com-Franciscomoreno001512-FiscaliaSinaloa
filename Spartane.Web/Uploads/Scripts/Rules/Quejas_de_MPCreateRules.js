var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
$("#Quejas_de_MPGuardarYNuevo").addClass("hidden");
$("#Quejas_de_MPGuardarYCopia").addClass("hidden");
$("#ConfigureSave").addClass("hidden");
//BusinessRuleId:3331, Attribute:269631, Operation:Field, Event:None
$("form#CreateQuejas_de_MP").on('change', '#Pais', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3331, Attribute:269631, Operation:Field, Event:None

//BusinessRuleId:3332, Attribute:269632, Operation:Field, Event:None
$("form#CreateQuejas_de_MP").on('change', '#Estado', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3332, Attribute:269632, Operation:Field, Event:None



//BusinessRuleId:3333, Attribute:269634, Operation:Field, Event:None
$("form#CreateQuejas_de_MP").on('change', '#Municipio', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Colonia WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Colonia WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3333, Attribute:269634, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
























































































































//BusinessRuleId:3293, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Genero_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Identificacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entidad_de_Nacimiento_Hechos' + rowIndex)); DisabledControl($("#" + nameOfTable + "Nombres_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Celular_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Correo_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Hechos' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Nacimiento_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Genero_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Identificacion_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entidad_de_Nacimiento_Identificacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Nombres_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Celular_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_Identificacion' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencias_de_domicilio' + rowIndex));

}
//BusinessRuleId:3293, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3293, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Genero_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Identificacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entidad_de_Nacimiento_Hechos' + rowIndex)); DisabledControl($("#" + nameOfTable + "Nombres_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Celular_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Correo_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Hechos' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Nacimiento_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Genero_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Identificacion_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entidad_de_Nacimiento_Identificacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Nombres_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Celular_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_Identificacion' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencias_de_domicilio' + rowIndex));

}
//BusinessRuleId:3293, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3293, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Genero_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Identificacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entidad_de_Nacimiento_Hechos' + rowIndex)); DisabledControl($("#" + nameOfTable + "Nombres_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Celular_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Correo_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Hechos' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Nacimiento_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Genero_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Identificacion_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entidad_de_Nacimiento_Identificacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Nombres_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Celular_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_Identificacion' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencias_de_domicilio' + rowIndex));

}
//BusinessRuleId:3293, Attribute:0, Operation:Object, Event:SCREENOPENING









































































//BusinessRuleId:3327, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));$('#divEstatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));

}
//BusinessRuleId:3327, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:3330, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('NULL', 'NULL') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Colonia WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Colonia WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3330, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3330, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('NULL', 'NULL') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Colonia WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Colonia WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3330, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3330, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('NULL', 'NULL') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Colonia WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Colonia WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3330, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3329, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),EvaluaQuery("SELECT NOMBRE FROM PAIS WHERE CLAVE = 82", rowIndex, nameOfTable));

}
//BusinessRuleId:3329, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3329, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),EvaluaQuery("SELECT NOMBRE FROM PAIS WHERE CLAVE = 82", rowIndex, nameOfTable));

}
//BusinessRuleId:3329, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3329, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),EvaluaQuery("SELECT NOMBRE FROM PAIS WHERE CLAVE = 82", rowIndex, nameOfTable));

}
//BusinessRuleId:3329, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3334, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3334, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3334, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3334, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3334, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3334, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3336, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3336, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3336, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3336, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3336, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3336, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3338, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3338, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3338, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3338, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3338, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3338, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3340, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3340, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3340, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3340, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3340, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:3340, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){




//BusinessRuleId:3328, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apelllido_Paterno]' + ' ' + 'FLD[Apelllido_Materno]'", rowIndex, nameOfTable));

}
//BusinessRuleId:3328, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


