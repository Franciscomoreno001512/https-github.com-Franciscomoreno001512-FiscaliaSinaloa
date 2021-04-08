var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {

    // INIT COD-MANUAL: SOLO PERMITIR LETRAS - OMAR MARTINEZ
    let validarSoloLetras = [
        "#Nombres",
        "#Apellido_Paterno",
        "Apellido_Materno"
    ];
    AddValidacionesOnInput(3, validarSoloLetras); // General.js
    // END COD-MANUAL: SOLO PERMITIR LETRAS - OMAR MARTINEZ
    // INIT COD-MANUAL: SOLO PERMITIR LETRAS Y NUMEROS - OMAR MARTINEZ
    let validarLetrasYNumeros = [
        "RFC",
        "Numero_de_Identificacion",
        "CURP",
        "Peso",
        "Estatura",
        "Padecimiento_de_Enfermedad"
    ];
    AddValidacionesOnInput(1, validarLetrasYNumeros); // General.js
    // END COD-MANUAL: SOLO PERMITIR LETRAS Y NUMEROS - OMAR MARTINEZ

	$("#Probable_Responsable_PCGuardarYNuevo").addClass("hidden");
	$("#Probable_Responsable_PCGuardarYCopia").addClass("hidden");
if(roleActivo==110 || roleActivo==108){
	$("#ConfigureSave").addClass("hidden");
	$("#Probable_Responsable_PCCancelar").addClass("hidden");
	$("#Probable_Responsable_PCGuardar").addClass("hidden");	
}else{
	$("#Probable_Responsable_PCSiguiente").addClass("hidden");
	$("#Probable_Responsable_PCAnterior").addClass("hidden");		
}
if(roleActivo==110 || roleActivo==108){
	$("#side-menu").addClass("hidden");
	$("#logoutForm").addClass("hidden");
}
//Validar dependiendo del tipo de identificacion seleccionada.
$("form#CreateProbable_Responsable_PC").on('change', '#Tipo_de_Identificacion', function () { 
	var tipoVal = $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex).val();   
			  if(tipoVal == 1) //CREDENCIAL DE ELECTOR
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Elector');
					  
			  }
			  
			  if(tipoVal == 2) //PASAPORTE
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Pasaporte');
					  
			  }
			  if(tipoVal == 3) //LICENCIA DE CONDUCIR
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Licencia de Conducir');
					  
			  }
			  if(tipoVal == 4) //NINGUNA
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Número de Identificación');
					  
			  }
			  if(tipoVal == 5) //CREDENCIAL DE TRABAJO
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Trabajo');
					  
			  }
			  if(tipoVal == 6) //CERTIF. DE MATRICULA CONSULAR
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Certificado de Matrícula Consular');
					  
			  }
			  if(tipoVal == 7) //CARTILLA DE SERVICIO MILITAR
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Cartilla de Servicio Militar');
					  
			  }
			  if(tipoVal == 8) //COTRAS
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Otras');
					  
			  }
			  if(tipoVal == 9) //CEDULA PROFESIONAL
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Cédula Profesional');
					  
			  }
			  if(tipoVal == 10) //CREDENCIAL DE ESTUDIANTE
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Estudiante');
					  
			  }
			  if(tipoVal == 11) //CREDENCIAL PARTIDO POLITICO
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial Partido Político');
					  
			  }
			  if(tipoVal == 12) //HOJA IDENTIFICACION MILITAR
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Hoja Identificación Militar');
					  
			  }
			  if(tipoVal == 13) //CREDENCIAL DE GANADERO
			  {
				$($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Ganadero');
					  
			  }
});


//Validar CURP
$( "#CURP" ).blur(function() { 
	var v = $('#' + nameOfTable + 'CURP' + rowIndex).val(); 
	if (v != ""){
			  var valid = /^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/,
			  validado = v.toUpperCase().match(valid);
					  
			  if (!validado) { //Coincide con el formato general?
					  $('#' + nameOfTable + 'CURP' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").val("").focus().blur(); 
		  return false; 
			  }                                
	} 
});

//Validar RFC
$( "#RFC" ).blur(function() { 
	var v = $('#' + nameOfTable + 'RFC' + rowIndex).val(); 
	if (v != ""){ 
		var valid = '^(([A-Z]|[a-z]){4})([0-9]{6})((([A-Z]|[a-z]|[0-9]){3}))'; 
		var validRfc=new RegExp(valid); 
		var matchArray=v.match(validRfc); 
		if (matchArray==null || v.length>13) { 
			$('#' + nameOfTable + 'RFC' + rowIndex).attr("placeholder", "El formato del RFC es incorrecto.").val("").focus().blur(); 
			return false; 
		} 
	} 
});


//BusinessRuleId:3108, Attribute:269294, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Fecha_de_Nacimiento', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('NULL', 'NULL') ) { AsignarValor($('#' + nameOfTable + 'Edad' + rowIndex),EvaluaQuery(" DECLARE @date date, @tmpdate date, @years int "
+" SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento]',103)),103) "
+" SELECT @tmpdate = @date "
+" SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) "
+" THEN 1 "
+" ELSE 0 "
+" END "
+" SELECT @tmpdate = DATEADD(yy, @years, @tmpdate) "
+" SELECT @years", rowIndex, nameOfTable));} else {}
});


//BusinessRuleId:3108, Attribute:269294, Operation:Field, Event:None

//BusinessRuleId:3159, Attribute:269289, Operation:Field, Event:None
// $("form#CreateProbable_Responsable_PC").on('keyup', '#Nombres', function () {
$( "#Nombres" ).blur(function() { 
	nameOfTable='';
	rowIndex='';
//  AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),(
     GetValueByControlType($('#' + nameOfTable + 'Nombres' + rowIndex),nameOfTable,rowIndex) + ' ' +
     GetValueByControlType($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex),nameOfTable,rowIndex) + ' ' +
     GetValueByControlType($('#' + nameOfTable + 'Apellido_Materno' + rowIndex),nameOfTable,rowIndex))
     );
});


//BusinessRuleId:3159, Attribute:269289, Operation:Field, Event:None

//BusinessRuleId:3160, Attribute:269290, Operation:Field, Event:None
// $("form#CreateProbable_Responsable_PC").on('keyup', '#Apellido_Paterno', function () {
$( "#Apellido_Paterno" ).blur(function() { 
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),(
     GetValueByControlType($('#' + nameOfTable + 'Nombres' + rowIndex),nameOfTable,rowIndex) + ' ' +
     GetValueByControlType($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex),nameOfTable,rowIndex) + ' ' +
     GetValueByControlType($('#' + nameOfTable + 'Apellido_Materno' + rowIndex),nameOfTable,rowIndex)));
});


//BusinessRuleId:3160, Attribute:269290, Operation:Field, Event:None

//BusinessRuleId:3161, Attribute:269291, Operation:Field, Event:None
// $("form#CreateProbable_Responsable_PC").on('keyup', '#Apellido_Materno', function () {
$( "#Apellido_Materno" ).blur(function() { 
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),(
     GetValueByControlType($('#' + nameOfTable + 'Nombres' + rowIndex),nameOfTable,rowIndex) + ' ' +
     GetValueByControlType($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex),nameOfTable,rowIndex) + ' ' +
     GetValueByControlType($('#' + nameOfTable + 'Apellido_Materno' + rowIndex),nameOfTable,rowIndex)));
});


//BusinessRuleId:3161, Attribute:269291, Operation:Field, Event:None







//BusinessRuleId:3166, Attribute:269418, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Tiene_informacion__domicilio', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); $("a[href='#tabDomicilio']").css('display', 'none');} else {}
});


//BusinessRuleId:3166, Attribute:269418, Operation:Field, Event:None

//BusinessRuleId:3167, Attribute:269418, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Tiene_informacion__domicilio', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { SetRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); $("a[href='#tabDomicilio']").css('display', 'block');} else {}
});


//BusinessRuleId:3167, Attribute:269418, Operation:Field, Event:None















//BusinessRuleId:3215, Attribute:269288, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Persona_moral', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Persona_moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divRazon_Social').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));} else { $('#divRazon_Social').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));}
});


//BusinessRuleId:3215, Attribute:269288, Operation:Field, Event:None















//BusinessRuleId:3165, Attribute:269305, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Municipio', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
});


//BusinessRuleId:3165, Attribute:269305, Operation:Field, Event:None

//BusinessRuleId:3221, Attribute:269303, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Pais', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('NULL', 'NULL') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:3221, Attribute:269303, Operation:Field, Event:None

//BusinessRuleId:3222, Attribute:269304, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Estado', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Estado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('NULL', 'NULL') ) { var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]"
+" ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]"
+" ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:3222, Attribute:269304, Operation:Field, Event:None







//BusinessRuleId:3275, Attribute:269288, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Persona_moral', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Persona_moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex)); $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));} else { $('#divFecha_de_Nacimiento').css('display', 'block');$('#divEdad').css('display', 'block');$('#divSexo').css('display', 'block');$('#divEstado_Civil').css('display', 'block'); $('#divNombres').css('display', 'block');$('#divApellido_Paterno').css('display', 'block');$('#divApellido_Materno').css('display', 'block');$('#divAlias').css('display', 'block');$('#divTipo_de_Identificacion').css('display', 'block');$('#divNumero_de_Identificacion').css('display', 'block');$('#divFotografia_de_la_identificacion').css('display', 'block');$('#divCURP').css('display', 'block');}
});


//BusinessRuleId:3275, Attribute:269288, Operation:Field, Event:None

//BusinessRuleId:3277, Attribute:269513, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Conoce_los_datos_del_representante_legal', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Conoce_los_datos_del_representante_legal' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divNombres').css('display', 'block');$('#divApellido_Paterno').css('display', 'block');$('#divApellido_Materno').css('display', 'block');$('#divAlias').css('display', 'block');$('#divFecha_de_Nacimiento').css('display', 'block');$('#divEdad').css('display', 'block');$('#divSexo').css('display', 'block');$('#divEstado_Civil').css('display', 'block');$('#divTipo_de_Identificacion').css('display', 'block');$('#divNumero_de_Identificacion').css('display', 'block');$('#divFotografia_de_la_identificacion').css('display', 'block');$('#divCURP').css('display', 'block');$('#divRFC').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));} else { $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));}
});


//BusinessRuleId:3277, Attribute:269513, Operation:Field, Event:None

//BusinessRuleId:3212, Attribute:269417, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Tiene_informacion_responsable', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divNombres').css('display', 'block');$('#divApellido_Paterno').css('display', 'block');$('#divApellido_Materno').css('display', 'block');$('#divAlias').css('display', 'block');$('#divFecha_de_Nacimiento').css('display', 'block');$('#divEdad').css('display', 'block');$('#divSexo').css('display', 'block');$('#divEstado_Civil').css('display', 'block');$('#divTipo_de_Identificacion').css('display', 'block');$('#divNumero_de_Identificacion').css('display', 'block');$('#divFotografia_de_la_identificacion').css('display', 'block');$('#divCURP').css('display', 'block');$('#divRFC').css('display', 'block'); $('#divQuien_Resulte_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex)); $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');} else {}
});


//BusinessRuleId:3212, Attribute:269417, Operation:Field, Event:None



//BusinessRuleId:3213, Attribute:269417, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Tiene_informacion_responsable', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); $('#divQuien_Resulte_Responsable').css('display', 'block');} else {}
});


//BusinessRuleId:3213, Attribute:269417, Operation:Field, Event:None



//BusinessRuleId:4577, Attribute:269288, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Persona_moral', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') && GetValueByControlType($('#' + nameOfTable + 'Persona_moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divRFC').css('display', 'block');} else {}
});


//BusinessRuleId:4577, Attribute:269288, Operation:Field, Event:None



//BusinessRuleId:4578, Attribute:269288, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Persona_moral', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') && GetValueByControlType($('#' + nameOfTable + 'Persona_moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') ) { $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));} else {}
});


//BusinessRuleId:4578, Attribute:269288, Operation:Field, Event:None





//BusinessRuleId:4580, Attribute:269417, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Tiene_informacion_responsable', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') && GetValueByControlType($('#' + nameOfTable + 'Persona_moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divRFC').css('display', 'block');} else {}
});


//BusinessRuleId:4580, Attribute:269417, Operation:Field, Event:None

//BusinessRuleId:4579, Attribute:269417, Operation:Field, Event:None
$("form#CreateProbable_Responsable_PC").on('change', '#Tiene_informacion_responsable', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') && GetValueByControlType($('#' + nameOfTable + 'Persona_moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') ) { $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));} else {}
});


//BusinessRuleId:4579, Attribute:269417, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});

$("#Probable_Responsable_PCSiguiente").on("click", function() {  
	var valform = checkClientValidate('Probable_Responsable_PCCreateForm');
	if(!valform){			
			return;			
	}else{			 		
		debugger;
		if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
			if (!SendProbable_Responsable_PCData(function () {
					EjecutarValidacionesDespuesDeGuardar();	
					localStorage.setItem("IdProbable", newIDInv);
					window.location="../Robo_de_Vehiculo_PC/Create";	
			})) {
					
			}									
		}			
		console.log("aqui guarda");				
	}	
});

$("#Probable_Responsable_PCAnterior").on("click", function() {  
var idinvolucrado="0";
			try {
				idinvolucrado = localStorage.getItem("IdHechos");				
			} catch (error) {
				
			}
	window.location="../Datos_de_los_Hechos_PC/Create?Id=" + idinvolucrado;
});

function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));}


}
//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));}


}
//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));}


}
//BusinessRuleId:3107, Attribute:0, Operation:Object, Event:SCREENOPENING








//BusinessRuleId:3109, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).val();   $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).val();   $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:3109, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3109, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).val();   $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).val();   $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:3109, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3109, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).val();   $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).val();   $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM RESPUESTA WHERE CLAVE IN (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:3109, Attribute:0, Operation:Object, Event:SCREENOPENING





























//BusinessRuleId:3157, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Solicitud' + rowIndex),EvaluaQuery(" SELECT FOLIO FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),EvaluaQuery(" SELECT TIPO_DE_SOLICITUD FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));


}
//BusinessRuleId:3157, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3157, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Solicitud' + rowIndex),EvaluaQuery(" SELECT FOLIO FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),EvaluaQuery(" SELECT TIPO_DE_SOLICITUD FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));


}
//BusinessRuleId:3157, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3163, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}


}
//BusinessRuleId:3163, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3163, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}


}
//BusinessRuleId:3163, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3163, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));}


}
//BusinessRuleId:3163, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3158, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


}
//BusinessRuleId:3158, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3158, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


}
//BusinessRuleId:3158, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3158, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


}
//BusinessRuleId:3158, Attribute:0, Operation:Object, Event:SCREENOPENING



















//BusinessRuleId:3156, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); $('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));


}
//BusinessRuleId:3156, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3156, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); $('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));


}
//BusinessRuleId:3156, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3156, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); $('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));


}
//BusinessRuleId:3156, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3168, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));


}
//BusinessRuleId:3168, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3168, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));


}
//BusinessRuleId:3168, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3168, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));


}
//BusinessRuleId:3168, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3191, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('110', '110') ) { $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));$('#divTipo_de_Solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));} else {}


}
//BusinessRuleId:3191, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3191, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('110', '110') ) { $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));$('#divTipo_de_Solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));} else {}


}
//BusinessRuleId:3191, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3191, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('110', '110') ) { $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));$('#divTipo_de_Solicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));} else {}


}
//BusinessRuleId:3191, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3198, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('110', '110') ) { AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),'2');} else {}


}
//BusinessRuleId:3198, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3211, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));


}
//BusinessRuleId:3211, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3211, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));


}
//BusinessRuleId:3211, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3211, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));


}
//BusinessRuleId:3211, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3216, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Persona_moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divRazon_Social').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));} else { $('#divRazon_Social').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));}


}
//BusinessRuleId:3216, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3216, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Persona_moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divRazon_Social').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));} else { $('#divRazon_Social').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));}


}
//BusinessRuleId:3216, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3216, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Persona_moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divRazon_Social').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));} else { $('#divRazon_Social').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));}


}
//BusinessRuleId:3216, Attribute:0, Operation:Object, Event:SCREENOPENING







































//BusinessRuleId:3164, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:3164, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3164, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:3164, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3155, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),EvaluaQuery(" SELECT NOMBRE FROM PAIS WHERE CLAVE = 82", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex),EvaluaQuery(" SELECT NOMBRE FROM ESTADO WHERE CLAVE = 25", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}


}
//BusinessRuleId:3155, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3155, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),EvaluaQuery(" SELECT NOMBRE FROM PAIS WHERE CLAVE = 82", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex),EvaluaQuery(" SELECT NOMBRE FROM ESTADO WHERE CLAVE = 25", rowIndex, nameOfTable)); DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}


}
//BusinessRuleId:3155, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3259, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') ) { DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Quien_Resulte_Responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_moral" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_moral' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombres" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Alias" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Sexo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_Civil" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fotografia_de_la_identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));}DisabledControl($("#" + nameOfTable + "RFC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle_del_Imputado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Peso" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatura" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));}DisabledControl($("#" + nameOfTable + "Padecimiento_de_Enfermedad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Cara" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Cejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_de_Cejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Largo_de_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Cantidad_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Implantacion_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Complexion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Piel" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));}DisabledControl($("#" + nameOfTable + "Frente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calvicie" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_de_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Anteojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Nariz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_Nariz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Labios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Boca" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grosor_de_Labios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Menton" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Menton" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));}DisabledControl($("#" + nameOfTable + "Barba" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Orejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_Orejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_Lobulo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Bigote" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));}DisabledControl($("#" + nameOfTable + "Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Imagen_Tatuaje" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));}DisabledControl($("#" + nameOfTable + "Situacion_Fisica" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));}DisabledControl($("#" + nameOfTable + "Otras_Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Imputado_Recluido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tiene_informacion_responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tiene_informacion__domicilio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Razon_Social" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));}} else {}


}
//BusinessRuleId:3259, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3259, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') ) { DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Quien_Resulte_Responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_moral" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_moral' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombres" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Alias" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Sexo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_Civil" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fotografia_de_la_identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));}DisabledControl($("#" + nameOfTable + "RFC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle_del_Imputado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Peso" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatura" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));}DisabledControl($("#" + nameOfTable + "Padecimiento_de_Enfermedad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Cara" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Cejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_de_Cejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Largo_de_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Cantidad_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Implantacion_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Complexion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Piel" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));}DisabledControl($("#" + nameOfTable + "Frente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calvicie" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_de_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Anteojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Nariz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_Nariz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Labios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Boca" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grosor_de_Labios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Menton" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Menton" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));}DisabledControl($("#" + nameOfTable + "Barba" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Orejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_Orejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_Lobulo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Bigote" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));}DisabledControl($("#" + nameOfTable + "Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Imagen_Tatuaje" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));}DisabledControl($("#" + nameOfTable + "Situacion_Fisica" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));}DisabledControl($("#" + nameOfTable + "Otras_Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Imputado_Recluido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tiene_informacion_responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tiene_informacion__domicilio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Razon_Social" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));}} else {}


}
//BusinessRuleId:3259, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3259, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('109', '109') ) { DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Quien_Resulte_Responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_moral" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_moral' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombres" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Alias" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Sexo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_Civil" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fotografia_de_la_identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));}DisabledControl($("#" + nameOfTable + "RFC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle_del_Imputado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Peso" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatura" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));}DisabledControl($("#" + nameOfTable + "Padecimiento_de_Enfermedad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Cara" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Cejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_de_Cejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Largo_de_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Cantidad_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Implantacion_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Complexion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Piel" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));}DisabledControl($("#" + nameOfTable + "Frente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calvicie" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_de_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Anteojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Nariz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_Nariz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Labios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Boca" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grosor_de_Labios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Menton" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Menton" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));}DisabledControl($("#" + nameOfTable + "Barba" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Orejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_Orejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_Lobulo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Bigote" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));}DisabledControl($("#" + nameOfTable + "Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Imagen_Tatuaje" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));}DisabledControl($("#" + nameOfTable + "Situacion_Fisica" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));}DisabledControl($("#" + nameOfTable + "Otras_Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Imputado_Recluido" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tiene_informacion_responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tiene_informacion__domicilio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Razon_Social" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));}} else {}


}
//BusinessRuleId:3259, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3197, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('108', '108') ) { AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),'1'); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));} else {}


}
//BusinessRuleId:3197, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3197, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('108', '108') ) { AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),'1'); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));} else {}


}
//BusinessRuleId:3197, Attribute:0, Operation:Object, Event:SCREENOPENING

























//BusinessRuleId:3274, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divImputado_Recluido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));


}
//BusinessRuleId:3274, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3274, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divImputado_Recluido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));


}
//BusinessRuleId:3274, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3274, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divImputado_Recluido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));


}
//BusinessRuleId:3274, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3276, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Conoce_los_datos_del_representante_legal' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divNombres').css('display', 'block');$('#divApellido_Paterno').css('display', 'block');$('#divApellido_Materno').css('display', 'block');$('#divAlias').css('display', 'block');$('#divFecha_de_Nacimiento').css('display', 'block');$('#divEdad').css('display', 'block');$('#divSexo').css('display', 'block');$('#divEstado_Civil').css('display', 'block');$('#divTipo_de_Identificacion').css('display', 'block');$('#divNumero_de_Identificacion').css('display', 'block');$('#divFotografia_de_la_identificacion').css('display', 'block');$('#divCURP').css('display', 'block');$('#divRFC').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));} else { $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));}


}
//BusinessRuleId:3276, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3276, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Conoce_los_datos_del_representante_legal' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divNombres').css('display', 'block');$('#divApellido_Paterno').css('display', 'block');$('#divApellido_Materno').css('display', 'block');$('#divAlias').css('display', 'block');$('#divFecha_de_Nacimiento').css('display', 'block');$('#divEdad').css('display', 'block');$('#divSexo').css('display', 'block');$('#divEstado_Civil').css('display', 'block');$('#divTipo_de_Identificacion').css('display', 'block');$('#divNumero_de_Identificacion').css('display', 'block');$('#divFotografia_de_la_identificacion').css('display', 'block');$('#divCURP').css('display', 'block');$('#divRFC').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));} else { $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));}


}
//BusinessRuleId:3276, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3276, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Conoce_los_datos_del_representante_legal' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divNombres').css('display', 'block');$('#divApellido_Paterno').css('display', 'block');$('#divApellido_Materno').css('display', 'block');$('#divAlias').css('display', 'block');$('#divFecha_de_Nacimiento').css('display', 'block');$('#divEdad').css('display', 'block');$('#divSexo').css('display', 'block');$('#divEstado_Civil').css('display', 'block');$('#divTipo_de_Identificacion').css('display', 'block');$('#divNumero_de_Identificacion').css('display', 'block');$('#divFotografia_de_la_identificacion').css('display', 'block');$('#divCURP').css('display', 'block');$('#divRFC').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));} else { $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));}


}
//BusinessRuleId:3276, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3218, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); $('#divQuien_Resulte_Responsable').css('display', 'block'); $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');} else {}


}
//BusinessRuleId:3218, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3218, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); $('#divQuien_Resulte_Responsable').css('display', 'block'); $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');} else {}


}
//BusinessRuleId:3218, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3218, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divNombres').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divAlias').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));$('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));$('#divFotografia_de_la_identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); $('#divQuien_Resulte_Responsable').css('display', 'block'); $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');} else {}


}
//BusinessRuleId:3218, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3217, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divNombres').css('display', 'block');$('#divApellido_Paterno').css('display', 'block');$('#divApellido_Materno').css('display', 'block');$('#divAlias').css('display', 'block');$('#divFecha_de_Nacimiento').css('display', 'block');$('#divEdad').css('display', 'block');$('#divSexo').css('display', 'block');$('#divEstado_Civil').css('display', 'block');$('#divTipo_de_Identificacion').css('display', 'block');$('#divNumero_de_Identificacion').css('display', 'block');$('#divFotografia_de_la_identificacion').css('display', 'block');$('#divCURP').css('display', 'block');$('#divRFC').css('display', 'block'); $('#divQuien_Resulte_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex)); $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');} else {}


}
//BusinessRuleId:3217, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3217, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divNombres').css('display', 'block');$('#divApellido_Paterno').css('display', 'block');$('#divApellido_Materno').css('display', 'block');$('#divAlias').css('display', 'block');$('#divFecha_de_Nacimiento').css('display', 'block');$('#divEdad').css('display', 'block');$('#divSexo').css('display', 'block');$('#divEstado_Civil').css('display', 'block');$('#divTipo_de_Identificacion').css('display', 'block');$('#divNumero_de_Identificacion').css('display', 'block');$('#divFotografia_de_la_identificacion').css('display', 'block');$('#divCURP').css('display', 'block');$('#divRFC').css('display', 'block'); $('#divQuien_Resulte_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex)); $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');} else {}


}
//BusinessRuleId:3217, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3217, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divNombres').css('display', 'block');$('#divApellido_Paterno').css('display', 'block');$('#divApellido_Materno').css('display', 'block');$('#divAlias').css('display', 'block');$('#divFecha_de_Nacimiento').css('display', 'block');$('#divEdad').css('display', 'block');$('#divSexo').css('display', 'block');$('#divEstado_Civil').css('display', 'block');$('#divTipo_de_Identificacion').css('display', 'block');$('#divNumero_de_Identificacion').css('display', 'block');$('#divFotografia_de_la_identificacion').css('display', 'block');$('#divCURP').css('display', 'block');$('#divRFC').css('display', 'block'); $('#divQuien_Resulte_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex)); $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');} else {}


}
//BusinessRuleId:3217, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:4857, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_moral' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Conoce_los_datos_del_representante_legal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:4857, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4857, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_moral' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Conoce_los_datos_del_representante_legal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:4857, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4857, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion_responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_moral' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Conoce_los_datos_del_representante_legal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tiene_informacion__domicilio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:4857, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
ValidaArchivos('#Fotografia_de_la_identificacionFile',['pdf','jpg','jpeg','pnf','gift'], 4); //selector, extensions, filesize
ValidaArchivos('#Imagen_TatuajeFile',['pdf','jpg','jpeg','pnf','gift'], 4); //selector, extensions, filesize

}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:3162, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


}
//BusinessRuleId:3162, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3162, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


}
//BusinessRuleId:3162, Attribute:2, Operation:Object, Event:AFTERSAVING

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
function CambiaEstado(deesc) {
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
            zoom: jQuery('input[name=address]').val() == "" ? 8 : 18,
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

        // Evento que se dispara cuando se mueve el marcador en en el mapa (es el Marcador de posicion de color Rojo)
        // cada pixel que se mueve o se arrastra se recalcula la latitud y la longitud
        google.maps.event.addListener(marker, 'dragend', function () {
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