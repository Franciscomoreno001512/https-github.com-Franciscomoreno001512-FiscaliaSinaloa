var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {

























//COD-MANI INI OCULTAR BOTONES
$('#Detalle_Resumen_DenunciaGuardarYNuevo').css('display', 'none');
$('#Detalle_Resumen_DenunciaGuardarYCopia').css('display', 'none');
//COD-MANI END OCULTAR BOTONES




































//BusinessRuleId:2973, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 EvaluaQuery(" EXEC UspUpdDatosResumenDenuncia_A_AtencionInicial FLDD[lblClave]", rowIndex, nameOfTable); AsignarValor($('#' + nameOfTable + 'Probable_Responsable' + rowIndex),EvaluaQuery(" SELECT Probable_Responsable FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Delito' + rowIndex),EvaluaQuery(" SELECT Delito FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Victima' + rowIndex),EvaluaQuery(" SELECT Victima FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Relacion' + rowIndex),EvaluaQuery(" SELECT Relacion FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hechos' + rowIndex),EvaluaQuery("SELECT Hechos FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_registra' + rowIndex),EvaluaQuery("SELECT Name FROM dbo.Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2973, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2973, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 EvaluaQuery(" EXEC UspUpdDatosResumenDenuncia_A_AtencionInicial FLDD[lblClave]", rowIndex, nameOfTable); AsignarValor($('#' + nameOfTable + 'Probable_Responsable' + rowIndex),EvaluaQuery(" SELECT Probable_Responsable FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Delito' + rowIndex),EvaluaQuery(" SELECT Delito FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Victima' + rowIndex),EvaluaQuery(" SELECT Victima FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Relacion' + rowIndex),EvaluaQuery(" SELECT Relacion FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hechos' + rowIndex),EvaluaQuery("SELECT Hechos FROM Detalle_Resumen_Denuncia WHERE Clave = FLDD[lblClave]	", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_registra' + rowIndex),EvaluaQuery("SELECT Name FROM dbo.Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2973, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Probable_Responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Victima" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Victima' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hechos' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_registra" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex));}

}
//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Probable_Responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Victima" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Victima' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hechos' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_registra" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex));}

}
//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Probable_Responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Victima" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Victima' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hechos' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_registra" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex));}

}
//BusinessRuleId:2970, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3019, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:3019, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divGenerado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generado' + rowIndex));$('#divFecha_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_registro' + rowIndex));$('#divHora_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex)); $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));

}
//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divGenerado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generado' + rowIndex));$('#divFecha_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_registro' + rowIndex));$('#divHora_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex)); $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));

}
//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divGenerado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generado' + rowIndex));$('#divFecha_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_registro' + rowIndex));$('#divHora_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex)); $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));

}
//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3018, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Usuario_que_registra' + rowIndex),EvaluaQuery("SELECT Name FROM dbo.Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:3018, Attribute:0, Operation:Object, Event:SCREENOPENING































//BusinessRuleId:3020, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM DOCUMENTO WHERE CLAVE = 179", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM DOCUMENTO WHERE CLAVE = 179", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change'); AsignarValor($('#' + nameOfTable + 'Documento' + rowIndex),EvaluaQuery(" SELECT CLAVE FROM DOCUMENTO WHERE DESCRIPCION ='AVISO DE INICIO DENUNCIA'", rowIndex, nameOfTable)); $('#divTipo_de_Documento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));$('#divDocumento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento' + rowIndex)); $('#divUsuario_que_registra').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex)); $('#divArchivo_Descargado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Descargado' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Descargado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:3020, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3020, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM DOCUMENTO WHERE CLAVE = 179", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM DOCUMENTO WHERE CLAVE = 179", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change'); AsignarValor($('#' + nameOfTable + 'Documento' + rowIndex),EvaluaQuery(" SELECT CLAVE FROM DOCUMENTO WHERE DESCRIPCION ='AVISO DE INICIO DENUNCIA'", rowIndex, nameOfTable)); $('#divTipo_de_Documento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));$('#divDocumento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento' + rowIndex)); $('#divUsuario_que_registra').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex)); $('#divArchivo_Descargado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Descargado' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Descargado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:3020, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3020, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM DOCUMENTO WHERE CLAVE = 179", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM DOCUMENTO WHERE CLAVE = 179", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change'); AsignarValor($('#' + nameOfTable + 'Documento' + rowIndex),EvaluaQuery(" SELECT CLAVE FROM DOCUMENTO WHERE DESCRIPCION ='AVISO DE INICIO DENUNCIA'", rowIndex, nameOfTable)); $('#divTipo_de_Documento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));$('#divDocumento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento' + rowIndex)); $('#divUsuario_que_registra').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex)); $('#divArchivo_Descargado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Descargado' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Descargado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:3020, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;










//BusinessRuleId:3012, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("EXEC uspGetValidaVictimasRelacion FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('Existen victimas sin relacionar', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3012, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:3013, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("EXEC uspGetValidaPRespRelacion FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('Existen probables responsables sin relacionar', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3013, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:3014, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("EXEC uspGetValidaDelitosRelacion FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('Existen delitos sin relacionar', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3014, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2971, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("EXEC uspGetPuedeGenerarExpediente FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { alert(DecodifyText(' Datos mínimos para generar Número de Expediente no validos!', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2971, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){














//BusinessRuleId:2972, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" EXEC uspGeneraFolio FLDD[lblClave]", rowIndex, nameOfTable); alert(DecodifyText(' Se ha Generado correctamente el Expediente', rowIndex, nameOfTable));

}
//BusinessRuleId:2972, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


