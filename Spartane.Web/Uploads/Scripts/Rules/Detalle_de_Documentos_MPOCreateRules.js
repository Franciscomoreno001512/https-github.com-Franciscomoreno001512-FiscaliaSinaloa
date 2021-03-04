var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$("#Detalle_de_Documentos_MPOGuardarYNuevo , #Detalle_de_Documentos_MPOGuardarYCopia").hide()
$(document).ready(function () {
	if (operation == 'Update') {
		if (EvaluaQuery("select Canalizado from Detalle_de_Documentos_MPO where Clave = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2')) {
			$("#Detalle_de_Documentos_MPOGuardar").remove();
		}
	}
	

	//CONVERTIR A MAYUSCULAS AL BLUR
$('input[type="text"],textarea').blur(function() {
	this.value = this.value.toUpperCase();
	});
//END CONVERTIR A MAYUSCULAS AL BLUR


//BusinessRuleId:3456, Attribute:266646, Operation:Field, Event:None
$("form#CreateDetalle_de_Documentos_MPO").on('change', '#Fecha', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("	SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103), CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha]',103),103))",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText(' No se puede ingresar una fecha mayor al dia de hoy.', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha' + rowIndex),' ');} else {}
});

//BusinessRuleId:3456, Attribute:266646, Operation:Field, Event:None

//BusinessRuleId:3488, Attribute:266650, Operation:Field, Event:None
$("form#CreateDetalle_de_Documentos_MPO").on('change', '#Documento', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("SELECT Tipo_de_Documento FROM dbo.Documento WHERE Clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('9', '9') ) { $('#divLista_para_periciales').css('display', 'block');} else { $('#divLista_para_periciales').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lista_para_periciales' + rowIndex));}
});

//BusinessRuleId:3488, Attribute:266650, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {

//BusinessRuleId:2024, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)"
+" ", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery("select name from spartan_user where id_user = GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:2024, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}


}
//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}


}
//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));$('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}


}
//BusinessRuleId:2023, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));


}
//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));


}
//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));


}
//BusinessRuleId:2065, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2156, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));


}
//BusinessRuleId:2156, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2156, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));


}
//BusinessRuleId:2156, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:2183, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex),EvaluaQuery(" SELECT NUAT FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));


}
//BusinessRuleId:2183, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2311, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]	",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); $('#divInvolucrado').css('display', 'block');} else { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}


}
//BusinessRuleId:2311, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2311, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]	",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); $('#divInvolucrado').css('display', 'block');} else { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}


}
//BusinessRuleId:2311, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:2611, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divTipo_de_Documento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));


}
//BusinessRuleId:2611, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2611, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divTipo_de_Documento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));


}
//BusinessRuleId:2611, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2611, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divTipo_de_Documento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));


}
//BusinessRuleId:2611, Attribute:0, Operation:Object, Event:SCREENOPENING























//BusinessRuleId:3485, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT Tipo_de_Documento FROM dbo.Documento WHERE Clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('9', '9') ) { $('#divLista_para_periciales').css('display', 'block');} else { $('#divLista_para_periciales').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lista_para_periciales' + rowIndex));}

}
//BusinessRuleId:3485, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3485, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT Tipo_de_Documento FROM dbo.Documento WHERE Clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('9', '9') ) { $('#divLista_para_periciales').css('display', 'block');} else { $('#divLista_para_periciales').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lista_para_periciales' + rowIndex));}

}
//BusinessRuleId:3485, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3485, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("SELECT Tipo_de_Documento FROM dbo.Documento WHERE Clave = FLD[Documento]",rowIndex, nameOfTable)==TryParseInt('9', '9') ) { $('#divLista_para_periciales').css('display', 'block');} else { $('#divLista_para_periciales').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lista_para_periciales' + rowIndex));}

}
//BusinessRuleId:3485, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3575, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT Tipo_de_Denuncia FROM dbo.Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Clave = 39", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Clave = 39", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3575, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3575, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT Tipo_de_Denuncia FROM dbo.Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) { var valor = $('#' + nameOfTable + 'Documento' + rowIndex).val();   $('#' + nameOfTable + 'Documento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Documento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Clave = 39", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Documento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Clave = 39", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Documento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Documento' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3575, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2312, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]	",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, CASE WHEN Quien_Resulte_Responsable = 1 THEN 'QUIEN O QUIENES RESULTEN RESPONSABLES'"
+"        ELSE Nombre_Completo_Detenido END FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, CASE WHEN Quien_Resulte_Responsable = 1 THEN 'QUIEN O QUIENES RESULTEN RESPONSABLES'"
+"        ELSE Nombre_Completo_Detenido END FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); $('#divProbable_Responsable').css('display', 'block');} else { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}

}
//BusinessRuleId:2312, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2312, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]	",rowIndex, nameOfTable)!=TryParseInt('0', '0') ) { var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, CASE WHEN Quien_Resulte_Responsable = 1 THEN 'QUIEN O QUIENES RESULTEN RESPONSABLES'"
+"        ELSE Nombre_Completo_Detenido END FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, CASE WHEN Quien_Resulte_Responsable = 1 THEN 'QUIEN O QUIENES RESULTEN RESPONSABLES'"
+"        ELSE Nombre_Completo_Detenido END FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); $('#divProbable_Responsable').css('display', 'block');} else { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}

}
//BusinessRuleId:2312, Attribute:0, Operation:Object, Event:SCREENOPENING











//BusinessRuleId:3901, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); $('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));

}
//BusinessRuleId:3901, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3901, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); $('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));

}
//BusinessRuleId:3901, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3901, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex)); $('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));

}
//BusinessRuleId:3901, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:4108, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Canalizado from Detalle_de_Documentos_MPO where Clave = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Documento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "IdDocumentos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'IdDocumentos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Probable_Responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Archivo_Adjunto" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo_Adjunto' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Archivo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Lista_para_periciales" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Lista_para_periciales' + rowIndex));}DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));}} else {}

}
//BusinessRuleId:4108, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){

	
var result = true;
//BusinessRuleId:3496, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("SELECT ISNULL(Lista_para_periciales, 0) FROM Detalle_de_Documentos_MPO WHERE Clave = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('El Documento ya se ha mandado a Servicios periciales, por lo que no se puede modificar.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3496, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//

    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){






//BusinessRuleId:3492, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Lista_para_periciales' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { EvaluaQuery("EXEC UspInsertar_Servicio_Pericial_Desde_Diligencias 1, GLOBAL[SpartanOperationId], FLDD[lblClave]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3492, Attribute:2, Operation:Object, Event:AFTERSAVING



//BusinessRuleId:3491, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Lista_para_periciales' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { EvaluaQuery("EXEC UspInsertar_Servicio_Pericial_Desde_Diligencias 1, GLOBAL[SpartanOperationId], GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3491, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:1735, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Documentos_MPO"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); EvaluaQuery("EXEC UspGeneraFolioDocumentos GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:1735, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}



function EjecutarValidacionesAntesDeGuardarMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Involucrados_en_Documentos// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Involucrados_en_Documentos// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_Involucrados_en_Documentos// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_Involucrados_en_Documentos// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_Involucrados_en_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_Involucrados_en_Documentos// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Probable_Responsable_de_Documentos// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Probable_Responsable_de_Documentos// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_Probable_Responsable_de_Documentos// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_NEWROWMR_Detalle_Probable_Responsable_de_Documentos// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_Probable_Responsable_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_EDITROWMR_Detalle_Probable_Responsable_de_Documentos// 
 return result; 
} 

function EjecutarValidacionesAntesDeGuardarMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Delitos_de_Documentos// 
 return result; 
} 

function EjecutarValidacionesDespuesDeGuardarMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndex){ 
//NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Delitos_de_Documentos// 
} 

function EjecutarValidacionesAlEliminarMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 
//NEWBUSINESSRULE_DELETEMR_Detalle_Delitos_de_Documentos// 
 return result; 
} 

function EjecutarValidacionesNewRowMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 












//BusinessRuleId:2866, Attribute:266662, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Detalle_de_Delito.Clave,dbo.Delito.Descripcion FROM Detalle_de_Delito"
+" INNER JOIN dbo.Delito ON Delito.Clave = Detalle_de_Delito.Delito"
+"  WHERE Expediente_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Detalle_de_Delito.Clave,dbo.Delito.Descripcion FROM Detalle_de_Delito"
+" INNER JOIN dbo.Delito ON Delito.Clave = Detalle_de_Delito.Delito"
+"  WHERE Expediente_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); SetRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));

}
//BusinessRuleId:2866, Attribute:266662, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2866, Attribute:266662, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Detalle_de_Delito.Clave,dbo.Delito.Descripcion FROM Detalle_de_Delito"
+" INNER JOIN dbo.Delito ON Delito.Clave = Detalle_de_Delito.Delito"
+"  WHERE Expediente_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Detalle_de_Delito.Clave,dbo.Delito.Descripcion FROM Detalle_de_Delito"
+" INNER JOIN dbo.Delito ON Delito.Clave = Detalle_de_Delito.Delito"
+"  WHERE Expediente_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); SetRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));

}
//BusinessRuleId:2866, Attribute:266662, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Delitos_de_Documentos// 
  return result; 
} 

function EjecutarValidacionesEditRowMRDetalle_Delitos_de_Documentos(nameOfTable, rowIndex){ 
 var result= true; 












//BusinessRuleId:2866, Attribute:266662, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Detalle_de_Delito.Clave,dbo.Delito.Descripcion FROM Detalle_de_Delito"
+" INNER JOIN dbo.Delito ON Delito.Clave = Detalle_de_Delito.Delito"
+"  WHERE Expediente_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Detalle_de_Delito.Clave,dbo.Delito.Descripcion FROM Detalle_de_Delito"
+" INNER JOIN dbo.Delito ON Delito.Clave = Detalle_de_Delito.Delito"
+"  WHERE Expediente_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); SetRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));

}
//BusinessRuleId:2866, Attribute:266662, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2866, Attribute:266662, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Detalle_de_Delito.Clave,dbo.Delito.Descripcion FROM Detalle_de_Delito"
+" INNER JOIN dbo.Delito ON Delito.Clave = Detalle_de_Delito.Delito"
+"  WHERE Expediente_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Detalle_de_Delito.Clave,dbo.Delito.Descripcion FROM Detalle_de_Delito"
+" INNER JOIN dbo.Delito ON Delito.Clave = Detalle_de_Delito.Delito"
+"  WHERE Expediente_Inicial = GLOBAL[SpartanOperationId]	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); SetRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));

}
//BusinessRuleId:2866, Attribute:266662, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Delitos_de_Documentos// 
 return result; 
} 
