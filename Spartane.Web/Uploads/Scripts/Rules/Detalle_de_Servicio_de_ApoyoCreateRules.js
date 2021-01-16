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

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:1719, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));


}
//BusinessRuleId:1719, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1737, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_de_Atencion_Inicial" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1737, Attribute:0, Operation:Object, Event:SCREENOPENING

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

//BusinessRuleId:3448, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));

}
//BusinessRuleId:3448, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3448, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));

}
//BusinessRuleId:3448, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3448, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divModulo_de_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_de_Atencion_Inicial' + rowIndex));

}
//BusinessRuleId:3448, Attribute:0, Operation:Object, Event:SCREENOPENING

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

//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));

}
//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));

}
//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lengua_Originaria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));

}
//BusinessRuleId:1983, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex)); $('#divResponsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));$('#divCompareciente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));$('#divRequiere_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));

}
//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex)); $('#divResponsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));$('#divCompareciente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));$('#divRequiere_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));

}
//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex)); $('#divResponsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable' + rowIndex));$('#divCompareciente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Compareciente' + rowIndex));$('#divRequiere_Traductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Requiere_Traductor' + rowIndex));

}
//BusinessRuleId:3470, Attribute:0, Operation:Object, Event:SCREENOPENING

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

//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('117', '117') ) { $('#divDictamen').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); $('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));}

}
//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('117', '117') ) { $('#divDictamen').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); $('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));}

}
//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('117', '117') ) { $('#divDictamen').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); $('#divDictamen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));}

}
//BusinessRuleId:3472, Attribute:0, Operation:Object, Event:SCREENOPENING

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







//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Diligencia' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 8", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 8", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Diligencia' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 8", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 8", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Diligencia' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 8", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Tipo_de_Documento = 8", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3466, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3467, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Diligencia' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Clave IN(180, 181)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Clave IN(180, 181)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3467, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3467, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Diligencia' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Clave IN(180, 181)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Clave IN(180, 181)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3467, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3467, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Diligencia' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Clave IN(180, 181)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Documento WHERE Clave IN(180, 181)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:3467, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1728, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Servicio_de_Apoyo"
+" 	set Modulo_de_Atencion_Inicial	 = GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:1728, Attribute:2, Operation:Object, Event:AFTERSAVING





//BusinessRuleId:3444, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC UspInsertar_Servicio_Pericial_Desde_Atencion_Temprana GLOBAL[SpartanOperationId], GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:3444, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3451, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" EXEC uspCambiarEstatusServicioPericial GLOBAL[KeyValueInserted], GLOBAL[USERID]", rowIndex, nameOfTable);

}
//BusinessRuleId:3451, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3451, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" EXEC uspCambiarEstatusServicioPericial GLOBAL[KeyValueInserted], GLOBAL[USERID]", rowIndex, nameOfTable);

}
//BusinessRuleId:3451, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


