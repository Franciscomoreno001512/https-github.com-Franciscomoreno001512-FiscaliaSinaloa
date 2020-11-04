var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {


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

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:614, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex),1);


}
//BusinessRuleId:614, Attribute:0, Operation:Object, Event:SCREENOPENING







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

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//BusinessRuleId:1998, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex),EvaluaQuery("SELECT 'FLD[Nombres2]' + ' ' + 'FLD[Apellido_Paterno2]' + ' ' + 'FLD[Apellido_Materno2]'", rowIndex, nameOfTable));

}
//BusinessRuleId:1998, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:1998, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex),EvaluaQuery("SELECT 'FLD[Nombres2]' + ' ' + 'FLD[Apellido_Paterno2]' + ' ' + 'FLD[Apellido_Materno2]'", rowIndex, nameOfTable));

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
