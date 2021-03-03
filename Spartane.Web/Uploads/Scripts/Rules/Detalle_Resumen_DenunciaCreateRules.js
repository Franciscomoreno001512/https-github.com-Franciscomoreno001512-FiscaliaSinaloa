var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
	if (operation == 'Update'){
		$("#Detalle_Resumen_DenunciaGuardar").remove();
	}
	/*if (operation == 'Update') {
		if (EvaluaQuery("select Canalizado from Detalle_Resumen_Denuncia where Clave = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2')) {
			$("#Detalle_Resumen_DenunciaGuardar").remove();
		}
	}*/
});
function EjecutarValidacionesAlComienzo() {


//INI COD-MAN OCULTAR BOTON DE GUARDAR 
if( EvaluaQuery("EXEC UspExisteFolioGeneracionExpediente FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) 
{ 
	$('#Detalle_Resumen_DenunciaGuardar').css('display', 'none');
	$('#Archivo_EditarDocto').css('display', 'none');	
} 
//FIN COD-MAN OCULTAR BOTON DE GUARDAR





















//COD-MANI INI OCULTAR BOTONES
$('#Detalle_Resumen_DenunciaGuardarYNuevo').css('display', 'none');
$('#Detalle_Resumen_DenunciaGuardarYCopia').css('display', 'none');
//COD-MANI END OCULTAR BOTONES








































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



//BusinessRuleId:4109, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Canalizado from Detalle_Resumen_Denuncia where Clave = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Probable_Responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Generado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Generado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Victima" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Victima' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Archivo_Descargado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Descargado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Documento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Archivo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));}} else {}

}
//BusinessRuleId:4109, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:4124, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divGenerar').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar' + rowIndex));$('#divNumero_Generado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Generado' + rowIndex));$('#divNumero_de_Oficio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); DisabledControl($("#" + nameOfTable + "Generar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Generar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Generado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Generado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}

}
//BusinessRuleId:4124, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4124, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divGenerar').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar' + rowIndex));$('#divNumero_Generado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Generado' + rowIndex));$('#divNumero_de_Oficio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); DisabledControl($("#" + nameOfTable + "Generar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Generar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Generado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Generado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}

}
//BusinessRuleId:4124, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4124, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divGenerar').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generar' + rowIndex));$('#divNumero_Generado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Generado' + rowIndex));$('#divNumero_de_Oficio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex)); DisabledControl($("#" + nameOfTable + "Generar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Generar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Generado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Generado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex));}

}
//BusinessRuleId:4124, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4126, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex),'Se generará automáticamente');

}
//BusinessRuleId:4126, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3019, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_registra' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:3019, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:4133, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:4133, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4133, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:4133, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4133, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:4133, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4130, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Probable_Responsable' + rowIndex),EvaluaQuery("SELECT dbo.fncGetPResponsableRelacionesAT(GLOBAL[SpartanOperationId])", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Delito' + rowIndex),EvaluaQuery("SELECT dbo.fncGetDelitosAT(GLOBAL[SpartanOperationId])", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Victima' + rowIndex),EvaluaQuery("SELECT dbo.fncGetRelacionesVictimasAT(GLOBAL[SpartanOperationId])", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Relacion' + rowIndex),EvaluaQuery("SELECT dbo.fncGetRelacionesAT(GLOBAL[SpartanOperationId])", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hechos' + rowIndex),EvaluaQuery("SELECT dbo.fncGetRelacionesHechosAT(GLOBAL[SpartanOperationId])", rowIndex, nameOfTable));

}
//BusinessRuleId:4130, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4137, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select Folio from Modulo_Atencion_Inicial where Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('', '') ) { AsignarValor($('#' + nameOfTable + 'Generar' + rowIndex),'1');} else { AsignarValor($('#' + nameOfTable + 'Generar' + rowIndex),'2');}

}
//BusinessRuleId:4137, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex)); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divGenerado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generado' + rowIndex)); $('#divFecha_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_registro' + rowIndex));$('#divHora_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex));

}
//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex)); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divGenerado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generado' + rowIndex)); $('#divFecha_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_registro' + rowIndex));$('#divHora_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex));

}
//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divArchivo_Adjunto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex)); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divGenerado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Generado' + rowIndex)); $('#divFecha_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_registro' + rowIndex));$('#divHora_de_registro').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex));

}
//BusinessRuleId:2969, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3018, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Usuario_que_registra' + rowIndex),EvaluaQuery("SELECT Name FROM dbo.Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_de_registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));

}
//BusinessRuleId:3018, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;


















//BusinessRuleId:2971, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("EXEC uspGetPuedeGenerarExpediente FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { alert(DecodifyText(' Datos mínimos para generar Número de Expediente no validos!', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:2971, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:3014, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("EXEC uspGetValidaDelitosRelacion FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('Existen delitos sin relacionar', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3014, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:3013, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("EXEC uspGetValidaPRespRelacion FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('Existen probables responsables sin relacionar', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3013, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:3012, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("EXEC uspGetValidaVictimasRelacion FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('Existen victimas sin relacionar', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3012, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4136, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Numero_de_Oficio' + rowIndex),EvaluaQuery("EXEC uspGeneraFolioAT 3,NULL,GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));

}
//BusinessRuleId:4136, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
















//BusinessRuleId:4134, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { EvaluaQuery("update Detalle_Resumen_Denuncia set Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId] where Clave = GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:4134, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:4135, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery("update Detalle_Resumen_Denuncia set Expediente_MP = GLOBAL[SpartanOperationId] where Clave = GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:4135, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2972, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC uspGeneraExpediente GLOBAL[SpartanOperationId]", rowIndex, nameOfTable); alert(DecodifyText(' Se ha Generado correctamente el Expediente', rowIndex, nameOfTable));

}
//BusinessRuleId:2972, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


