var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {

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
  
//Validar dependiendo del tipo de identificacion seleccionada.
$( "#Numero_de_Identificacion" ).blur(function() { 
      var tipoVal = $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex).val();
	  var NumeroVal = $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).val();
	  var valid="";
	  
	  if (tipoVal != "" && NumeroVal != ""){	
		if(tipoVal == 1) //IFE
		{
			
			
		}
		
		if(tipoVal == 6) //CURP
		{
			valid = /^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/,
			validado = NumeroVal.toUpperCase().match(valid);
			
			if (!validado) { //Coincide con el formato general?
				$('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").val("").focus().blur(); 
				return false; 
			}		
		}
	}
  });

//BusinessRuleId:1936, Attribute:263148, Operation:Field, Event:None


//BusinessRuleId:1936, Attribute:263148, Operation:Field, Event:None

//BusinessRuleId:1938, Attribute:265807, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Bajo_el_Efecto_de_una_Droga', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("select 'FLD[Bajo_el_Efecto_de_una_Droga]'",rowIndex, nameOfTable)==TryParseInt('true', 'true') ) { $('#divNombre_de_Droga').css('display', 'block');} else { $('#divNombre_de_Droga').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));}
});


//BusinessRuleId:1938, Attribute:265807, Operation:Field, Event:None

//BusinessRuleId:1939, Attribute:263211, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Escolaridad_Detenido', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex).val()==TryParseInt('11', '11') ) { $('#divEspecialidad').css('display', 'block');$('#divEstudios_Superiores').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));$('#divIncompleto').css('display', 'none');} else { $('#divEspecialidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));$('#divEstudios_Superiores').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));$('#divIncompleto').css('display', 'block');}
});

//BusinessRuleId:1939, Attribute:263211, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Inimputable', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Inimputable' + rowIndex).prop("checked") === true ) { 
    $('#divTipo_de_Inimputabilidad').css('display', 'block');
    $('#divEspecifique').css('display', 'block');
    $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
    } 
    else 
    { 
        $('#divTipo_de_Inimputabilidad').css('display', 'none'); 
        SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        $('#divEspecifique').css('display', 'none'); 
        SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));
        $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
    }
});

//BusinessRuleId:1957, Attribute:266575, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Persona_Moral', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true ) { $('#divCalidad_Juridica').css('display', 'block');$('#divRazon_Social').css('display', 'block'); $("a[href='#tabRepresentante_Legal']").css('display', 'block');} else { $('#divCalidad_Juridica').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));$('#divRazon_Social').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); $("a[href='#tabRepresentante_Legal']").css('display', 'none');}
});







//BusinessRuleId:1978, Attribute:266591, Operation:Field, Event:None

//BusinessRuleId:688, Attribute:263141, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Fecha_de_Nacimiento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("DECLARE @date date, @tmpdate date, @years int"
+" "
+" SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento]',103)),103)"
+" "
+" SELECT @tmpdate = @date"
+" "
+" SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END"
+" "
+" SELECT @tmpdate = DATEADD(yy, @years, @tmpdate)"
+" "
+" SELECT @years",rowIndex, nameOfTable)<TryParseInt('18', '18') && GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { $("a[href='#tabDatos_del_Tutor']").css('display', 'block');} else { $("a[href='#tabDatos_del_Tutor']").css('display', 'none');}
});


//BusinessRuleId:688, Attribute:263141, Operation:Field, Event:None

//BusinessRuleId:83, Attribute:263141, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Fecha_de_Nacimiento', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Edad' + rowIndex),EvaluaQuery("DECLARE @date date, @tmpdate date, @years int"
+" "
+" SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento]',103)),103)"
+" "
+" SELECT @tmpdate = @date"
+" "
+" SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END"
+" "
+" SELECT @tmpdate = DATEADD(yy, @years, @tmpdate)"
+" "
+" SELECT @years", rowIndex, nameOfTable));} else {}
});


//BusinessRuleId:83, Attribute:263141, Operation:Field, Event:None

//BusinessRuleId:597, Attribute:263141, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Fecha_de_Nacimiento', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103),"
+" "
+" CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Nacimiento]',103),103))",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText('No se puede ingresar una fecha mayor al día de hoy', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex),''); AsignarValor($('#' + nameOfTable + 'Edad' + rowIndex),'');} else {}
});


//BusinessRuleId:597, Attribute:263141, Operation:Field, Event:None

//BusinessRuleId:1384, Attribute:263217, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Fecha_de_Nacimiento_del_Tutor', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103),"
+" CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Nacimiento_del_Tutor]',103),103))",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText('No se puede ingresar una fecha mayor al dìa de hoy', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex),''); AsignarValor($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex),'');} else {}
});


//BusinessRuleId:1384, Attribute:263217, Operation:Field, Event:None

//BusinessRuleId:1374, Attribute:263217, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Fecha_de_Nacimiento_del_Tutor', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex),EvaluaQuery("DECLARE @date date, @tmpdate date, @years int"
+" "
+" SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento_del_Tutor]',103)),103)"
+" "
+" SELECT @tmpdate = @date"
+" "
+" SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END"
+" "
+" SELECT @tmpdate = DATEADD(yy, @years, @tmpdate)"
+" "
+" SELECT @years", rowIndex, nameOfTable));} else {}
});


//BusinessRuleId:1374, Attribute:263217, Operation:Field, Event:None



//BusinessRuleId:2537, Attribute:263151, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Municipio', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');} else {}
});

//BusinessRuleId:2537, Attribute:263151, Operation:Field, Event:None



//BusinessRuleId:2532, Attribute:263162, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Pais', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); $('#divEstado').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divColonia').css('display', 'block');$('#divPoblacion').css('display', 'block');} else { $('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}
});

//BusinessRuleId:2532, Attribute:263162, Operation:Field, Event:None



//BusinessRuleId:2534, Attribute:263150, Operation:Field, Event:None
$("form#CreateDetalle_de_Imputado").on('change', '#Estado', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Estado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');} else {}
});

//BusinessRuleId:2534, Attribute:263150, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {








//BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Inimputable' + rowIndex).val()==TryParseInt('false', 'false') && $('#' + nameOfTable + 'Edad' + rowIndex).val()==TryParseInt('null', 'null') ) { $("a[href='#tabDatos_del_Tutor']").css('display', 'none');} else {}


}
//BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Inimputable' + rowIndex).val()==TryParseInt('false', 'false') && $('#' + nameOfTable + 'Edad' + rowIndex).val()==TryParseInt('null', 'null') ) { $("a[href='#tabDatos_del_Tutor']").css('display', 'none');} else {}


}
//BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Inimputable' + rowIndex).val()==TryParseInt('false', 'false') && $('#' + nameOfTable + 'Edad' + rowIndex).val()==TryParseInt('null', 'null') ) { $("a[href='#tabDatos_del_Tutor']").css('display', 'none');} else {}


}
//BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1722, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));


}
//BusinessRuleId:1722, Attribute:0, Operation:Object, Event:SCREENOPENING



















//BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1741, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1741, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none'); $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); $('#divNombre_Completo_Detenido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));} else {}


}
//BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none'); $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); $('#divNombre_Completo_Detenido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));} else {}


}
//BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none'); $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); $('#divNombre_Completo_Detenido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));} else {}


}
//BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divEspecialidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));$('#divEstudios_Superiores').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));


}
//BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divEspecialidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));$('#divEstudios_Superiores').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));


}
//BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divEspecialidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));$('#divEstudios_Superiores').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));


}
//BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divTipo_de_Inimputabilidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));$('#divNombre_de_Droga').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));$('#divEspecifique').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));


}
//BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divTipo_de_Inimputabilidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));$('#divNombre_de_Droga').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));$('#divEspecifique').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));


}
//BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divTipo_de_Inimputabilidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));$('#divNombre_de_Droga').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));$('#divEspecifique').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));


}
//BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nariz_Base' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_interior_de_los_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_de_los_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_del_lugar_del_he' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inimputable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Corporacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Resposable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Resposable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Redes_Sociales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Resposable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Adicciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_otros_Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apodo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Etnia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No_de_Hijos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Religion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Servicio_Medico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dialecto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex));


}
//BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nariz_Base' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_interior_de_los_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_de_los_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_del_lugar_del_he' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inimputable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Corporacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Resposable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Resposable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Redes_Sociales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Resposable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Adicciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_otros_Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apodo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Etnia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No_de_Hijos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Religion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Servicio_Medico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dialecto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex));


}
//BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nariz_Base' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_interior_de_los_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_de_los_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_del_lugar_del_he' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inimputable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Corporacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Resposable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Resposable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Redes_Sociales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Resposable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Adicciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_otros_Nombres' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apodo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Etnia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No_de_Hijos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Religion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Servicio_Medico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dialecto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex));


}
//BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none'); $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); $('#divNombre_Completo_Detenido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));


}
//BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none'); $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); $('#divNombre_Completo_Detenido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));


}
//BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none'); $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); $('#divNombre_Completo_Detenido').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));


}
//BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1952, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divIncompleto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Incompleto' + rowIndex));


}
//BusinessRuleId:1952, Attribute:0, Operation:Object, Event:SCREENOPENING


if(operation == 'Update'){
if( $('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex).val()==TryParseInt('11', '11') ) { $('#divEspecialidad').css('display', 'block');$('#divEstudios_Superiores').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));$('#divIncompleto').css('display', 'none');} else { $('#divEspecialidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));$('#divEstudios_Superiores').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));$('#divIncompleto').css('display', 'block');}
}
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex).val()==TryParseInt('11', '11') ) { $('#divEspecialidad').css('display', 'block');$('#divEstudios_Superiores').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));$('#divIncompleto').css('display', 'none');} else { $('#divEspecialidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));$('#divEstudios_Superiores').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));$('#divIncompleto').css('display', 'block');}
}
//BusinessRuleId:1939, Attribute:263211, Operation:Field, Event:None
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Inimputable' + rowIndex).prop("checked") === true ) { 
    $('#divTipo_de_Inimputabilidad').css('display', 'block');
    $('#divEspecifique').css('display', 'block');
    $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
    } 
    else 
    { 
        $('#divTipo_de_Inimputabilidad').css('display', 'none'); 
        SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        $('#divEspecifique').css('display', 'none'); 
        SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));
        $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
    }
}
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Inimputable' + rowIndex).prop("checked") === true ) { 
    $('#divTipo_de_Inimputabilidad').css('display', 'block');
    $('#divEspecifique').css('display', 'block');
    $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
    } 
    else 
    { 
        $('#divTipo_de_Inimputabilidad').css('display', 'none'); 
        SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        $('#divEspecifique').css('display', 'none'); 
        SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));
        $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
    }
}


//BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Moral' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex));


}
//BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Moral' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex));


}
//BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Moral' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex));


}
//BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING

if(operation == 'New'){
    if( $('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true ) { $('#divCalidad_Juridica').css('display', 'block');$('#divRazon_Social').css('display', 'block'); $("a[href='#tabRepresentante_Legal']").css('display', 'block');} else { $('#divCalidad_Juridica').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));$('#divRazon_Social').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); $("a[href='#tabRepresentante_Legal']").css('display', 'none');}
}
if(operation == 'Update'){
    if( $('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true ) { $('#divCalidad_Juridica').css('display', 'block');$('#divRazon_Social').css('display', 'block'); $("a[href='#tabRepresentante_Legal']").css('display', 'block');} else { $('#divCalidad_Juridica').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));$('#divRazon_Social').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); $("a[href='#tabRepresentante_Legal']").css('display', 'none');}
}
if(operation == 'Consult'){
    if( $('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true ) { $('#divCalidad_Juridica').css('display', 'block');$('#divRazon_Social').css('display', 'block'); $("a[href='#tabRepresentante_Legal']").css('display', 'block');} else { $('#divCalidad_Juridica').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));$('#divRazon_Social').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex)); $("a[href='#tabRepresentante_Legal']").css('display', 'none');}
}

//BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divNombre_Completo2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));


}
//BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divNombre_Completo2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));


}
//BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divNombre_Completo2').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));


}
//BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2233, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex),EvaluaQuery("SELECT NUAT FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId] ", rowIndex, nameOfTable));


}
//BusinessRuleId:2233, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divEscolaridad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));


}
//BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divEscolaridad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));


}
//BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divEscolaridad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));


}
//BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2493, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));} DisabledControl($("#" + nameOfTable + "Edad_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));}

}
//BusinessRuleId:2493, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2493, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));} DisabledControl($("#" + nameOfTable + "Edad_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));}

}
//BusinessRuleId:2493, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1358, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("DECLARE @date date, @tmpdate date, @years int"
+" "
+" SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento]',103)),103)"
+" "
+" SELECT @tmpdate = @date"
+" "
+" SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END"
+" "
+" SELECT @tmpdate = DATEADD(yy, @years, @tmpdate)"
+" "
+" SELECT @years",rowIndex, nameOfTable)<TryParseInt('18', '18') && GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') || GetValueByControlType($('#' + nameOfTable + 'Inimputable' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $("a[href='#tabDatos_del_Tutor']").css('display', 'block');} else { $("a[href='#tabDatos_del_Tutor']").css('display', 'none');}

}
//BusinessRuleId:1358, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:2531, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); $('#divEstado').css('display', 'block');$('#divColonia').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divPoblacion').css('display', 'block');} else { $('#divEstado').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divColonia').css('display', 'block');$('#divPoblacion').css('display', 'block'); $('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}

}
//BusinessRuleId:2531, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2531, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); $('#divEstado').css('display', 'block');$('#divColonia').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divPoblacion').css('display', 'block');} else { $('#divEstado').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divColonia').css('display', 'block');$('#divPoblacion').css('display', 'block'); $('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}

}
//BusinessRuleId:2531, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;












//BusinessRuleId:1998, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex),EvaluaQuery("SELECT 'FLD[Nombres2]' + ' ' + 'FLD[Apellido_Paterno2]' + ' ' + 'FLD[Apellido_Materno2]'", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombre]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


}
//BusinessRuleId:1998, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:1998, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex),EvaluaQuery("SELECT 'FLD[Nombres2]' + ' ' + 'FLD[Apellido_Paterno2]' + ' ' + 'FLD[Apellido_Materno2]'", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombre]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


}
//BusinessRuleId:1998, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1731, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Imputado"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:1731, Attribute:2, Operation:Object, Event:AFTERSAVING





//BusinessRuleId:2511, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Detalle_de_Imputado set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:2511, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2511, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Detalle_de_Imputado set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:2511, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRAdicciones_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Adicciones_Probable_Responsable//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRAdicciones_Probable_Responsable(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Adicciones_Probable_Responsable//
}
function EjecutarValidacionesAlEliminarMRAdicciones_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Adicciones_Probable_Responsable//
    return result;
}
function EjecutarValidacionesNewRowMRAdicciones_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Adicciones_Probable_Responsable//
    return result;
}
function EjecutarValidacionesEditRowMRAdicciones_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Adicciones_Probable_Responsable//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Lugares_Frecuentes_Probable_Responsable//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Lugares_Frecuentes_Probable_Responsable//
}
function EjecutarValidacionesAlEliminarMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Lugares_Frecuentes_Probable_Responsable//
    return result;
}
function EjecutarValidacionesNewRowMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Lugares_Frecuentes_Probable_Responsable//
    return result;
}
function EjecutarValidacionesEditRowMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Lugares_Frecuentes_Probable_Responsable//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Datos_Personales_Adicionales_Probable_Responsable//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Datos_Personales_Adicionales_Probable_Responsable//
}
function EjecutarValidacionesAlEliminarMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Datos_Personales_Adicionales_Probable_Responsable//
    return result;
}
function EjecutarValidacionesNewRowMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Datos_Personales_Adicionales_Probable_Responsable//
    return result;
}
function EjecutarValidacionesEditRowMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Datos_Personales_Adicionales_Probable_Responsable//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Otras_Identificaciones_Probable_Responsable//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Otras_Identificaciones_Probable_Responsable//
}
function EjecutarValidacionesAlEliminarMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Otras_Identificaciones_Probable_Responsable//
    return result;
}
function EjecutarValidacionesNewRowMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Otras_Identificaciones_Probable_Responsable//
    return result;
}
function EjecutarValidacionesEditRowMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Otras_Identificaciones_Probable_Responsable//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Otros_Domicilios_Probable_Responsable//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Otros_Domicilios_Probable_Responsable//
}
function EjecutarValidacionesAlEliminarMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Otros_Domicilios_Probable_Responsable//
    return result;
}
function EjecutarValidacionesNewRowMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Otros_Domicilios_Probable_Responsable//
    return result;
}
function EjecutarValidacionesEditRowMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Otros_Domicilios_Probable_Responsable//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMROtros_Nombres(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Otros_Nombres//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMROtros_Nombres(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Otros_Nombres//
}
function EjecutarValidacionesAlEliminarMROtros_Nombres(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Otros_Nombres//
    return result;
}
function EjecutarValidacionesNewRowMROtros_Nombres(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Otros_Nombres//
    return result;
}
function EjecutarValidacionesEditRowMROtros_Nombres(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Otros_Nombres//
    return result;
}


function EjecutarValidacionesAntesDeGuardarMRLugar_de_Detencion(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Lugar_de_Detencion// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRLugar_de_Detencion(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Lugar_de_Detencion// 
} 

function EjecutarValidacionesAlEliminarMRLugar_de_Detencion(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Lugar_de_Detencion// 
 return result; 
} 

function EjecutarValidacionesNewRowMRLugar_de_Detencion(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Lugar_de_Detencion// 
  return result; 
} 

function EjecutarValidacionesEditRowMRLugar_de_Detencion(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Lugar_de_Detencion// 
 return result; 
} 
