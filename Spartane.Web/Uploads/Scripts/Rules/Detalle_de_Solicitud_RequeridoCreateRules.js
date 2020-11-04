var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {




//BusinessRuleId:1716, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1716, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1716, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1716, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:1966, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1966, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1966, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1966, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1966, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1966, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1954, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_Quien_Sea_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio_Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inimputable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Redes_Sociales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Corporacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_donde_se_Encuentra_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apodo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Etnia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Hijos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Religion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Servicio_Medico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dialecto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nariz_base' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));

}
//BusinessRuleId:1954, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1954, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_Quien_Sea_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Alias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio_Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inimputable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Redes_Sociales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requerido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Corporacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_donde_se_Encuentra_Detenido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apodo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Etnia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Hijos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Religion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Servicio_Medico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dialecto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nariz_base' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));

}
//BusinessRuleId:1954, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2002, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2002, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2002, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2002, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2002, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#dividRegistroAT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroAT' + rowIndex));$('#dividRegistroUI').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'idRegistroUI' + rowIndex));

}
//BusinessRuleId:2002, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){


//BusinessRuleId:2008, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("EXEC uspActualizaRequeridos FLDD[lblClave] ", rowIndex, nameOfTable);

}
//BusinessRuleId:2008, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}



function EjecutarValidacionesAntesDeGuardarMROtros_Nombres_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Otros_Nombres_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMROtros_Nombres_Requerido_MASC(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Otros_Nombres_Requerido_MASC// 
} 

function EjecutarValidacionesAlEliminarMROtros_Nombres_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Otros_Nombres_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesNewRowMROtros_Nombres_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Otros_Nombres_Requerido_MASC// 
  return result; 
} 

function EjecutarValidacionesEditRowMROtros_Nombres_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Otros_Nombres_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMROtros_Domicilios_Requeridos_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Otros_Domicilios_Requeridos_MASC// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMROtros_Domicilios_Requeridos_MASC(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Otros_Domicilios_Requeridos_MASC// 
} 

function EjecutarValidacionesAlEliminarMROtros_Domicilios_Requeridos_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Otros_Domicilios_Requeridos_MASC// 
 return result; 
} 

function EjecutarValidacionesNewRowMROtros_Domicilios_Requeridos_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Otros_Domicilios_Requeridos_MASC// 
  return result; 
} 

function EjecutarValidacionesEditRowMROtros_Domicilios_Requeridos_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Otros_Domicilios_Requeridos_MASC// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMRAdicciones_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Adicciones_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRAdicciones_Requerido_MASC(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Adicciones_Requerido_MASC// 
} 

function EjecutarValidacionesAlEliminarMRAdicciones_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Adicciones_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesNewRowMRAdicciones_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Adicciones_Requerido_MASC// 
  return result; 
} 

function EjecutarValidacionesEditRowMRAdicciones_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Adicciones_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMRLugares_Frecuentes_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Lugares_Frecuentes_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRLugares_Frecuentes_Requerido_MASC(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Lugares_Frecuentes_Requerido_MASC// 
} 

function EjecutarValidacionesAlEliminarMRLugares_Frecuentes_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Lugares_Frecuentes_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesNewRowMRLugares_Frecuentes_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Lugares_Frecuentes_Requerido_MASC// 
  return result; 
} 

function EjecutarValidacionesEditRowMRLugares_Frecuentes_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Lugares_Frecuentes_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMRDatos_Personales_Adicionales_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Datos_Personales_Adicionales_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDatos_Personales_Adicionales_Requerido_MASC(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Datos_Personales_Adicionales_Requerido_MASC// 
} 

function EjecutarValidacionesAlEliminarMRDatos_Personales_Adicionales_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Datos_Personales_Adicionales_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDatos_Personales_Adicionales_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Datos_Personales_Adicionales_Requerido_MASC// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDatos_Personales_Adicionales_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Datos_Personales_Adicionales_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMROtras_Identificaciones_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Otras_Identificaciones_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMROtras_Identificaciones_Requerido_MASC(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Otras_Identificaciones_Requerido_MASC// 
} 

function EjecutarValidacionesAlEliminarMROtras_Identificaciones_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Otras_Identificaciones_Requerido_MASC// 
 return result; 
} 

function EjecutarValidacionesNewRowMROtras_Identificaciones_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Otras_Identificaciones_Requerido_MASC// 
  return result; 
} 

function EjecutarValidacionesEditRowMROtras_Identificaciones_Requerido_MASC(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Otras_Identificaciones_Requerido_MASC// 
 return result; 
} 
