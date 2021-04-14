var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
	if (operation == 'Update') {
		if( EvaluaQuery("select Canalizado from Detalle_de_Relaciones where Clave = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { 
			$("#Detalle_de_RelacionesGuardar").remove();
		} 
	} 
	if(operation == 'Update'){
        if( TryParseInt('107', '107')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ){
            $("#Detalle_de_RelacionesGuardar").hide();
        }
    }


$("#Detalle_de_RelacionesGuardarYNuevo").remove();
$("#Detalle_de_RelacionesGuardarYCopia").remove();

//BusinessRuleId:2443, Attribute:265760, Operation:Field, Event:None
$("form#CreateDetalle_de_Relaciones").on('change', '#Es_Familiar', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Es_Familiar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divParentesco').css('display', 'block');} else { $('#divParentesco').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));}
});

//CONVERTIR A MAYUSCULAS AL BLUR
$('input[type="text"],textarea').blur(function() {
	this.value = this.value.toUpperCase();
	});
//END CONVERTIR A MAYUSCULAS AL BLUR

//BusinessRuleId:2443, Attribute:265760, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:1724, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));


}
//BusinessRuleId:1724, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1744, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1744, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1751, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));


}
//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));


}
//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));


}
//BusinessRuleId:1988, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:2174, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex),EvaluaQuery(" SELECT NUAT from Modulo_Atencion_Inicial where Clave = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));


}
//BusinessRuleId:2174, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2444, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divParentesco').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));


}
//BusinessRuleId:2444, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2445, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Es_Familiar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divParentesco').css('display', 'block');} else { $('#divParentesco').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));}


}
//BusinessRuleId:2445, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2445, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Es_Familiar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divParentesco').css('display', 'block');} else { $('#divParentesco').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));}


}
//BusinessRuleId:2445, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2506, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2553, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divModulo_Atencion_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));


}
//BusinessRuleId:2553, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { $('#divInvolucrado').css('display', 'block');$('#divProbable_Responsable').css('display', 'block');$('#divDelito').css('display', 'block');} else {}


}
//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { $('#divInvolucrado').css('display', 'block');$('#divProbable_Responsable').css('display', 'block');$('#divDelito').css('display', 'block');} else {}


}
//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { $('#divInvolucrado').css('display', 'block');$('#divProbable_Responsable').css('display', 'block');$('#divDelito').css('display', 'block');} else {}


}
//BusinessRuleId:2631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2632, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd"
+" 	inner join Delito d on ddd.Delito = d.Clave"
+" 	where ddd.Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd"
+" 	inner join Delito d on ddd.Delito = d.Clave"
+" 	where ddd.Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change');} else {}


}
//BusinessRuleId:2632, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2632, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo from Detalle_de_Datos_Generales where Expediente_MP = GLOBAL[SpartanOperationId] and Tipo_de_Compareciente in (1,2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd"
+" 	inner join Delito d on ddd.Delito = d.Clave"
+" 	where ddd.Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd"
+" 	inner join Delito d on ddd.Delito = d.Clave"
+" 	where ddd.Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change');} else {}


}
//BusinessRuleId:2632, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:2943, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2943, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2943, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2943, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2943, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divDescripcion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2943, Attribute:0, Operation:Object, Event:SCREENOPENING

































//BusinessRuleId:2948, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])",rowIndex, nameOfTable)==TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { $('#divDelito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));} else {}

}
//BusinessRuleId:2948, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2948, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])",rowIndex, nameOfTable)==TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { $('#divDelito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));} else {}

}
//BusinessRuleId:2948, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2949, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex)); $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));} else {}

}
//BusinessRuleId:2949, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2949, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex)); $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));} else {}

}
//BusinessRuleId:2949, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2950, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));} else {}

}
//BusinessRuleId:2950, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2950, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { $('#divProbable_Responsable').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));} else {}

}
//BusinessRuleId:2950, Attribute:0, Operation:Object, Event:SCREENOPENING

































//BusinessRuleId:2958, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])",rowIndex, nameOfTable)!=TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select"
+" 	d.Clave,"
+" 	d.Descripcion"
+" from"
+" 	detalle_de_delito dd with(nolock)"
+" 	inner join delito d with (nolock) on dd.delito = d.clave"
+" where"
+" 	dd.expediente_inicial=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select"
+" 	d.Clave,"
+" 	d.Descripcion"
+" from"
+" 	detalle_de_delito dd with(nolock)"
+" 	inner join delito d with (nolock) on dd.delito = d.clave"
+" where"
+" 	dd.expediente_inicial=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); $('#divDelito').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));} else {}

}
//BusinessRuleId:2958, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2958, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Delito WHERE Clave IN (SELECT DELITO FROM Detalle_de_Delito WHERE Expediente_Inicial = GLOBAL[SpartanOperationId])",rowIndex, nameOfTable)!=TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select"
+" 	d.Clave,"
+" 	d.Descripcion"
+" from"
+" 	detalle_de_delito dd with(nolock)"
+" 	inner join delito d with (nolock) on dd.delito = d.clave"
+" where"
+" 	dd.expediente_inicial=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select"
+" 	d.Clave,"
+" 	d.Descripcion"
+" from"
+" 	detalle_de_delito dd with(nolock)"
+" 	inner join delito d with (nolock) on dd.delito = d.clave"
+" where"
+" 	dd.expediente_inicial=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); $('#divDelito').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));} else {}

}
//BusinessRuleId:2958, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:2957, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId] AND (Detalle_de_Datos_Generales.es_victima = 1 or Detalle_de_Datos_Generales.tipo_de_compareciente = 2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId] AND (Detalle_de_Datos_Generales.es_victima = 1 or Detalle_de_Datos_Generales.tipo_de_compareciente = 2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); SetRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex)); $('#divInvolucrado').css('display', 'block');} else {}

}
//BusinessRuleId:2957, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2957, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Involucrado' + rowIndex).val();   $('#' + nameOfTable + 'Involucrado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Involucrado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId] AND (Detalle_de_Datos_Generales.es_victima = 1 or Detalle_de_Datos_Generales.tipo_de_compareciente = 2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Involucrado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE_COMPLETO FROM Detalle_de_Datos_Generales WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId] AND (Detalle_de_Datos_Generales.es_victima = 1 or Detalle_de_Datos_Generales.tipo_de_compareciente = 2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Involucrado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Involucrado' + rowIndex).val(valor).trigger('change'); SetRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex)); $('#divInvolucrado').css('display', 'block');} else {}

}
//BusinessRuleId:2957, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:2951, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT"
+"   Clave ,"
+"   CASE WHEN Quien_Resulte_Responsable = 1 THEN 'QUIEN O QUIENES RESULTEN RESPONSABLES'"
+"        ELSE ( ISNULL(Nombre_Completo_Detenido,"
+"                      Nombre + ' ' + Apellido_Paterno) )"
+"   END"
+" FROM"
+"   Detalle_de_Imputado"
+" WHERE"
+"   Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT"
+"   Clave ,"
+"   CASE WHEN Quien_Resulte_Responsable = 1 THEN 'QUIEN O QUIENES RESULTEN RESPONSABLES'"
+"        ELSE ( ISNULL(Nombre_Completo_Detenido,"
+"                      Nombre + ' ' + Apellido_Paterno) )"
+"   END"
+" FROM"
+"   Detalle_de_Imputado"
+" WHERE"
+"   Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); $('#divProbable_Responsable').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));} else {}

}
//BusinessRuleId:2951, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2951, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT"
+"   Clave ,"
+"   CASE WHEN Quien_Resulte_Responsable = 1 THEN 'QUIEN O QUIENES RESULTEN RESPONSABLES'"
+"        ELSE ( ISNULL(Nombre_Completo_Detenido,"
+"                      Nombre + ' ' + Apellido_Paterno) )"
+"   END"
+" FROM"
+"   Detalle_de_Imputado"
+" WHERE"
+"   Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT"
+"   Clave ,"
+"   CASE WHEN Quien_Resulte_Responsable = 1 THEN 'QUIEN O QUIENES RESULTEN RESPONSABLES'"
+"        ELSE ( ISNULL(Nombre_Completo_Detenido,"
+"                      Nombre + ' ' + Apellido_Paterno) )"
+"   END"
+" FROM"
+"   Detalle_de_Imputado"
+" WHERE"
+"   Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change'); $('#divProbable_Responsable').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));} else {}

}
//BusinessRuleId:2951, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:4110, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Canalizado from Detalle_de_Relaciones where Clave = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Probable_Responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Es_Familiar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Parentesco" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));}} else {}

}
//BusinessRuleId:4110, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4379, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Probable_Responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Es_Familiar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Parentesco" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Parentesco' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));}


}
//BusinessRuleId:4379, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4860, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { SetRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));} else {}

}
//BusinessRuleId:4860, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4860, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { SetRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Probable_Responsable' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));} else {}

}
//BusinessRuleId:4860, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4940, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('6', '6') ) { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));$('#divEs_Familiar').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));} else {}

}
//BusinessRuleId:4940, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4940, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('6', '6') ) { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));$('#divEs_Familiar').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));} else {}

}
//BusinessRuleId:4940, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4940, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('6', '6') ) { $('#divInvolucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));$('#divEs_Familiar').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_Familiar' + rowIndex));} else {}

}
//BusinessRuleId:4940, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:4941, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('6', '6') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd inner join Delito d on ddd.Delito = d.Clave where ddd.Mandamiento_Judicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd inner join Delito d on ddd.Delito = d.Clave where ddd.Mandamiento_Judicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Mandamiento_Judicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Mandamiento_Judicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:4941, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4941, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('6', '6') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd inner join Delito d on ddd.Delito = d.Clave where ddd.Mandamiento_Judicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select distinct d.Clave, d.Descripcion from Detalle_de_Delito ddd inner join Delito d on ddd.Delito = d.Clave where ddd.Mandamiento_Judicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val();   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Probable_Responsable' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Mandamiento_Judicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select Clave, Nombre_Completo_Detenido from Detalle_de_Imputado where Mandamiento_Judicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Probable_Responsable' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:4941, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
















//BusinessRuleId:3007, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("EXEC uspGetPuedeGenerarRelacion FLD[Modulo_Atencion_Inicial],FLD[Involucrado],FLD[Probable_Responsable],FLD[Delito]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('Ya existe una Relación con la Victima, Probable Responsable y Delito actual, Favor de Verificar', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3007, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:3008, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("EXEC uspGetPuedeActGenerarRelacion FLDD[lblClave],FLD[Modulo_Atencion_Inicial],FLD[Involucrado],FLD[Probable_Responsable],FLD[Delito]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { alert(DecodifyText('Ya existe una Relación con la Victima, Probable Responsable y Delito actual, Favor de Verificar', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3008, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:3894, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("exec usp_Valida_ExisteRelacion_EnExpediente GLOBAL[SpartanOperationId],FLD[Involucrado],FLD[Probable_Responsable],FLD[Delito]",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText('Ya existe la relación especificada, favor de corregir', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:3894, Attribute:2, Operation:Object, Event:BEFORESAVING











//BusinessRuleId:4969, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("EXEC usp_Valida_ExisteRelacion_EnExpediente_MJ GLOBAL[SpartanOperationId],FLD[Probable_Responsable],FLD[Delito]",rowIndex, nameOfTable)>TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('6', '6') ) { alert(DecodifyText('Ya existe la relación especificada, favor de corregir', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4969, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4969, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("EXEC usp_Valida_ExisteRelacion_EnExpediente_MJ GLOBAL[SpartanOperationId],FLD[Probable_Responsable],FLD[Delito]",rowIndex, nameOfTable)>TryParseInt('0', '0') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('6', '6') ) { alert(DecodifyText('Ya existe la relación especificada, favor de corregir', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4969, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1733, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_de_Relaciones"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:1733, Attribute:2, Operation:Object, Event:AFTERSAVING





//BusinessRuleId:2517, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Detalle_de_Relaciones set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:2517, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2517, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Detalle_de_Relaciones set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:2517, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2947, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" exec usp_UpdateDescripcionDeRelacionDeDelito FLDD[lblClave]", rowIndex, nameOfTable);

}
//BusinessRuleId:2947, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2946, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" exec usp_UpdateDescripcionDeRelacionDeDelito GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2946, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:4121, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" exec uspActualizadatosGeneracionExpediente GLOBAL[SpartanOperationId]", rowIndex, nameOfTable);


}
//BusinessRuleId:4121, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:4121, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" exec uspActualizadatosGeneracionExpediente GLOBAL[SpartanOperationId]", rowIndex, nameOfTable);


}
//BusinessRuleId:4121, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:4935, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('6', '6') ) { EvaluaQuery("update detalle_de_relaciones set Mandamiento_Judicial = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:4935, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


