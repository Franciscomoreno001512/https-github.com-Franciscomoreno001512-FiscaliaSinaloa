var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//CONVERTIR A MAYUSCULAS AL BLUR
$('input[type="text"],textarea').blur(function() {
	this.value = this.value.toUpperCase();
	});
//END CONVERTIR A MAYUSCULAS AL BLUR

//BusinessRuleId:2495, Attribute:263253, Operation:Field, Event:None
$("form#CreateDetalle_de_Servicio_de_Apoyo").on('change', '#Requiere_Traductor', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Requiere_Traductor' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divLengua_Originaria').css('display', 'block');$('#divIdioma').css('display', 'block');} else { $('#divLengua_Originaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex));$('#divIdioma').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));}
});


//BusinessRuleId:2495, Attribute:263253, Operation:Field, Event:None

//BusinessRuleId:3500, Attribute:269722, Operation:Field, Event:None
$("form#CreateDetalle_de_Servicio_de_Apoyo").on('change', '#Origen', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divModulo_de_Atencion_Inicial').css('display', 'block'); $('#divModulo_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));$('#divModulo_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex));} else {}
});

//BusinessRuleId:3500, Attribute:269722, Operation:Field, Event:None

//BusinessRuleId:3501, Attribute:269722, Operation:Field, Event:None
$("form#CreateDetalle_de_Servicio_de_Apoyo").on('change', '#Origen', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divModulo_Mecanismos_Alternos').css('display', 'block'); $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));$('#divModulo_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex));} else {}
});

//BusinessRuleId:3501, Attribute:269722, Operation:Field, Event:None

//BusinessRuleId:3502, Attribute:269722, Operation:Field, Event:None
$("form#CreateDetalle_de_Servicio_de_Apoyo").on('change', '#Origen', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $('#divModulo_Ministerio_Publico').css('display', 'block'); $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));$('#divModulo_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));} else {}
});

//BusinessRuleId:3502, Attribute:269722, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:1719, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));


}
//BusinessRuleId:1719, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:1753, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1753, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1753, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1753, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1753, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1753, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:2232, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex),EvaluaQuery("SELECT NUAT FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));


}
//BusinessRuleId:2232, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:2496, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divLengua_Originaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex));$('#divIdioma').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));


}
//BusinessRuleId:2496, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2496, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divLengua_Originaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex));$('#divIdioma').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));


}
//BusinessRuleId:2496, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2496, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divLengua_Originaria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex));$('#divIdioma').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));


}
//BusinessRuleId:2496, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:3415, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') ) { $("a[href='#tabCanalizar']").css('display', 'block');} else { $("a[href='#tabCanalizar']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));}

}
//BusinessRuleId:3415, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3415, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') ) { $("a[href='#tabCanalizar']").css('display', 'block');} else { $("a[href='#tabCanalizar']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));}

}
//BusinessRuleId:3415, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3415, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') ) { $("a[href='#tabCanalizar']").css('display', 'block');} else { $("a[href='#tabCanalizar']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));}

}
//BusinessRuleId:3415, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3427, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('116', '116') ) { $("a[href='#tabCanalizar']").css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex)); $('#divArea_Pericial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));} else {}

}
//BusinessRuleId:3427, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3427, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('116', '116') ) { $("a[href='#tabCanalizar']").css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex)); $('#divArea_Pericial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));} else {}

}
//BusinessRuleId:3427, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3427, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('116', '116') ) { $("a[href='#tabCanalizar']").css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex)); $('#divArea_Pericial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));} else {}

}
//BusinessRuleId:3427, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3450, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); $('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:3450, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3450, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); $('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:3450, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3450, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex)); $('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:3450, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3452, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Perito' + rowIndex).val();   $('#' + nameOfTable + 'Perito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Perito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Perito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Id_User, Name FROM dbo.Spartan_User WHERE Role =117", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Perito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Id_User, Name FROM dbo.Spartan_User WHERE Role =117", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Perito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Perito' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3452, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3452, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Perito' + rowIndex).val();   $('#' + nameOfTable + 'Perito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Perito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Perito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Id_User, Name FROM dbo.Spartan_User WHERE Role =117", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Perito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Id_User, Name FROM dbo.Spartan_User WHERE Role =117", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Perito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Perito' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3452, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3452, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Perito' + rowIndex).val();   $('#' + nameOfTable + 'Perito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Perito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Perito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Id_User, Name FROM dbo.Spartan_User WHERE Role =117", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Perito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Id_User, Name FROM dbo.Spartan_User WHERE Role =117", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Perito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Perito' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3452, Attribute:0, Operation:Object, Event:SCREENOPENING

































//BusinessRuleId:3471, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery("SELECT CONVERT (VARCHAR(11), GETDATE(), 105)", rowIndex, nameOfTable));

}
//BusinessRuleId:3471, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:3426, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') ) { $("a[href='#tabCanalizar']").css('display', 'block'); $('#divPerito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));$('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex));} else {}

}
//BusinessRuleId:3426, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3426, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') ) { $("a[href='#tabCanalizar']").css('display', 'block'); $('#divPerito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));$('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex));} else {}

}
//BusinessRuleId:3426, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3426, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') ) { $("a[href='#tabCanalizar']").css('display', 'block'); $('#divPerito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));$('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex));} else {}

}
//BusinessRuleId:3426, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3473, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') && EvaluaQuery("SELECT Region FROM dbo.Spartan_User WHERE Id_User = GLOBAL[USERID]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { SetRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex)); $('#divPerito').css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex)); $('#divArea_Pericial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex));} else {}

}
//BusinessRuleId:3473, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3473, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') && EvaluaQuery("SELECT Region FROM dbo.Spartan_User WHERE Id_User = GLOBAL[USERID]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { SetRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex)); $('#divPerito').css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex)); $('#divArea_Pericial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex));} else {}

}
//BusinessRuleId:3473, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3473, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('115', '115') && EvaluaQuery("SELECT Region FROM dbo.Spartan_User WHERE Id_User = GLOBAL[USERID]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { SetRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex)); $('#divPerito').css('display', 'block'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex)); $('#divArea_Pericial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex));} else {}

}
//BusinessRuleId:3473, Attribute:0, Operation:Object, Event:SCREENOPENING





























































//BusinessRuleId:3497, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divModulo_de_Atencion_Inicial').css('display', 'block'); $('#divModulo_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));$('#divModulo_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex));} else {}

}
//BusinessRuleId:3497, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3497, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divModulo_de_Atencion_Inicial').css('display', 'block'); $('#divModulo_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));$('#divModulo_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex));} else {}

}
//BusinessRuleId:3497, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3497, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divModulo_de_Atencion_Inicial').css('display', 'block'); $('#divModulo_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));$('#divModulo_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex));} else {}

}
//BusinessRuleId:3497, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1737, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_de_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modulo_Mecanismos_Alternos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modulo_Ministerio_Publico" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex));}

}
//BusinessRuleId:1737, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Oficio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Solicitante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Rango_Solicitante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Autoridades' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Atencion_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Mecanismos_Alternos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Ministerio_Publico' + rowIndex));

}
//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Oficio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Solicitante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Rango_Solicitante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Autoridades' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Atencion_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Mecanismos_Alternos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Ministerio_Publico' + rowIndex));

}
//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Oficio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Solicitante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Rango_Solicitante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Autoridades' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Atencion_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Mecanismos_Alternos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Ministerio_Publico' + rowIndex));

}
//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('117', '117') ) { $('#divDictamen').css('display', 'block');$('#divContestacion_lista_para_enviarse').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); $('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); $('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));$('#divContestacion_lista_para_enviarse').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion_lista_para_enviarse' + rowIndex));}

}
//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('117', '117') ) { $('#divDictamen').css('display', 'block');$('#divContestacion_lista_para_enviarse').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); $('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); $('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));$('#divContestacion_lista_para_enviarse').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion_lista_para_enviarse' + rowIndex));}

}
//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('117', '117') ) { $('#divDictamen').css('display', 'block');$('#divContestacion_lista_para_enviarse').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); $('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); $('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));$('#divContestacion_lista_para_enviarse').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion_lista_para_enviarse' + rowIndex));}

}
//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3507, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("EXEC ValidarGuardadoServicioPericial FLDD[lblClave], GLOBAL[USERID]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { DisabledControl($("#" + nameOfTable + "Tipo_de_Servicio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Diligencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Area_Pericial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Area_Pericial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Perito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Perito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Oficio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Oficio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Imagen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Solicitante" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Solicitante' + rowIndex));}DisabledControl($("#" + nameOfTable + "Rango_Solicitante" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Rango_Solicitante' + rowIndex));}DisabledControl($("#" + nameOfTable + "Autoridades" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Autoridades' + rowIndex));}DisabledControl($("#" + nameOfTable + "Agencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Agencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Dictamen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));}DisabledControl($("#" + nameOfTable + "Origen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));}DisabledControl($("#" + nameOfTable + "Contestacion_lista_para_enviarse" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion_lista_para_enviarse' + rowIndex));}} else {}

}
//BusinessRuleId:3507, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Diligencia' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Diligencia' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Diligencia' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 9", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING











//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex)); $('#divResponsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));$('#divCompareciente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));$('#divRequiere_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));$('#divDocumento_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Atencion_Inicial' + rowIndex));$('#divDocumento_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Mecanismos_Alternos' + rowIndex));$('#divDocumento_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Ministerio_Publico' + rowIndex));

}
//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex)); $('#divResponsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));$('#divCompareciente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));$('#divRequiere_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));$('#divDocumento_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Atencion_Inicial' + rowIndex));$('#divDocumento_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Mecanismos_Alternos' + rowIndex));$('#divDocumento_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Ministerio_Publico' + rowIndex));

}
//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex)); $('#divResponsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));$('#divCompareciente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));$('#divRequiere_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));$('#divDocumento_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Atencion_Inicial' + rowIndex));$('#divDocumento_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Mecanismos_Alternos' + rowIndex));$('#divDocumento_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Ministerio_Publico' + rowIndex));

}
//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3499, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $('#divModulo_Ministerio_Publico').css('display', 'block'); $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));$('#divModulo_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));} else {}

}
//BusinessRuleId:3499, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3499, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $('#divModulo_Ministerio_Publico').css('display', 'block'); $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));$('#divModulo_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));} else {}

}
//BusinessRuleId:3499, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3499, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $('#divModulo_Ministerio_Publico').css('display', 'block'); $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));$('#divModulo_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));} else {}

}
//BusinessRuleId:3499, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3498, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divModulo_Mecanismos_Alternos').css('display', 'block'); $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));$('#divModulo_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex));} else {}

}
//BusinessRuleId:3498, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3498, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divModulo_Mecanismos_Alternos').css('display', 'block'); $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));$('#divModulo_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex));} else {}

}
//BusinessRuleId:3498, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3498, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Origen' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divModulo_Mecanismos_Alternos').css('display', 'block'); $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));$('#divModulo_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex));} else {}

}
//BusinessRuleId:3498, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:3533, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex)); $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));$('#divOrigen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));$('#divModulo_Mecanismos_Alternos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Mecanismos_Alternos' + rowIndex));$('#divModulo_Ministerio_Publico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Ministerio_Publico' + rowIndex));

}
//BusinessRuleId:3533, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//BusinessRuleId:3506, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("EXEC ValidarGuardadoServicioPericial FLDD[lblClave], GLOBAL[USERID]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('El Servicio Pericial se encuentra en otra etapa, por lo que no es posible editarlo', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3506, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){


















//BusinessRuleId:3503, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("EXEC uspCambiarEstatusServicioPericial FLDD[lblClave], GLOBAL[USERID]", rowIndex, nameOfTable);

}
//BusinessRuleId:3503, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3451, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" EXEC uspCambiarEstatusServicioPericial GLOBAL[KeyValueInserted], GLOBAL[USERID]", rowIndex, nameOfTable); EvaluaQuery(" update Detalle_de_Servicio_de_Apoyo set Modulo_de_Atencion_Inicial = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); EvaluaQuery("EXEC uspCambiarEstatusServicioPericial GLOBAL[KeyValueInserted], GLOBAL[USERID]", rowIndex, nameOfTable);

}
//BusinessRuleId:3451, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


