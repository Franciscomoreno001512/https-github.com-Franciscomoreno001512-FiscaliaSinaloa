var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
	
	//CONVERTIR A MAYUSCULAS AL BLUR
    $('input[type="text"],textarea').blur(function () {
        this.value = this.value.toUpperCase();
    });
    //END CONVERTIR A MAYUSCULAS AL BLUR


//BusinessRuleId:638, Attribute:263907, Operation:Field, Event:None
$("form#CreateDetalle_de_Persona_Moral").on('change', '#Colonia', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Colonia' + rowIndex).val()!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Codigo_Postal' + rowIndex),EvaluaQuery("select codigo_postal from Codigo_Postal where colonia=FLD[Colonia]", rowIndex, nameOfTable));} else {}
});


//BusinessRuleId:638, Attribute:263907, Operation:Field, Event:None
$( "#Celular" ).blur(function() { 
            var v = $('#' + nameOfTable + 'Celular' + rowIndex).val(); 
            if (v != ""){ 
               let  v=$('#' + nameOfTable + 'Celular' + rowIndex).val()
               var regNUM = /^[0-9]{10}$/ 
               var validacionnum=regNUM.test(v)
                if (validacionnum==false ) { 
					$('#' + nameOfTable + 'Celular' + rowIndex).attr("placeholder", "Ingrese un numero de celular valido").val("").focus().blur(); 
                } 
            } 
        });
		$( "#Telefono" ).blur(function() { 
            var v = $('#' + nameOfTable + 'Telefono' + rowIndex).val(); 
            if (v != ""){ 
               let  v=$('#' + nameOfTable + 'Telefono' + rowIndex).val()
               var regNUM = /^[0-9]{10}$/ 
               var validacionnum=regNUM.test(v)
                if (validacionnum==false ) { 
					$('#' + nameOfTable + 'Telefono' + rowIndex).attr("placeholder", "Ingrese un numero de telefono valido").val("").focus().blur(); 
                } 
            } 
        });

//Validar Correo
$('#Correo_Electronico').change(function(){ 
    let email = $('#Correo_Electronico').val(); 
    let exp = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/); 
    if (exp.test(email) == false){ 
        $('#Correo_Electronico').attr("placeholder", "Correo electrónico no válido.").val("").focus().blur(); 
    } 
});
$('#Correo_Electronico_del_Tutor').change(function(){ 
    let email = $('#Correo_Electronico_del_Tutor').val(); 
    let exp = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/); 
    if (exp.test(email) == false){ 
        $('#Correo_Electronico_del_Tutor').attr("placeholder", "Correo electrónico no válido.").val("").focus().blur(); 
    } 
});



//BusinessRuleId:583, Attribute:263904, Operation:Field, Event:None
$("form#CreateDetalle_de_Persona_Moral").on('change', '#Estado', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Estado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:583, Attribute:263904, Operation:Field, Event:None

//BusinessRuleId:584, Attribute:263905, Operation:Field, Event:None
$("form#CreateDetalle_de_Persona_Moral").on('change', '#Municipio', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:584, Attribute:263905, Operation:Field, Event:None





















//BusinessRuleId:580, Attribute:263903, Operation:Field, Event:None
$("form#CreateDetalle_de_Persona_Moral").on('change', '#Pais', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)==TryParseInt('82', '82') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); $('#divEstado').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divColonia').css('display', 'block');$('#divPoblacion').css('display', 'block');} else { $('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}
});

//BusinessRuleId:580, Attribute:263903, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {












//BusinessRuleId:1326, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Localidad" + rowIndex), ("true" == "true")); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex));


}
//BusinessRuleId:1326, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1326, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Localidad" + rowIndex), ("true" == "true")); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex));


}
//BusinessRuleId:1326, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1721, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); $('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));


}
//BusinessRuleId:1721, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1312, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));


}
//BusinessRuleId:1312, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1312, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));


}
//BusinessRuleId:1312, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); $('#divLocalidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex));


}
//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); $('#divLocalidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex));


}
//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); $('#divLocalidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex));


}
//BusinessRuleId:579, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1739, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1739, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2516, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));


}
//BusinessRuleId:2516, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2516, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));


}
//BusinessRuleId:2516, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2516, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo2' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));


}
//BusinessRuleId:2516, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2551, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2551, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2551, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2551, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2551, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2551, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2539, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)==TryParseInt('82', '82') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); $('#divEstado').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divColonia').css('display', 'block');$('#divPoblacion').css('display', 'block');} else { $('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}

}
//BusinessRuleId:2539, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2539, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)==TryParseInt('82', '82') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); $('#divEstado').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divColonia').css('display', 'block');$('#divPoblacion').css('display', 'block');} else { $('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}

}
//BusinessRuleId:2539, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2539, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)==TryParseInt('82', '82') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); $('#divEstado').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divColonia').css('display', 'block');$('#divPoblacion').css('display', 'block');} else { $('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}

}
//BusinessRuleId:2539, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1730, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("  update Detalle_de_Persona_Moral"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:1730, Attribute:2, Operation:Object, Event:AFTERSAVING





//BusinessRuleId:2552, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Detalle_de_Persona_Moral set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:2552, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2552, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Detalle_de_Persona_Moral set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:2552, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


