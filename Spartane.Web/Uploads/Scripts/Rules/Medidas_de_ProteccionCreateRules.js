var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;

$("#Medidas_de_ProteccionGuardarYNuevo, #Medidas_de_ProteccionGuardarYCopia").hide()

/*CODIGO ABRIR GRID*/
function CM_CierraMr() {
    $('.fa-check').parent().click();
}
function IniciaMR() {
	var grid='Detalle_Medidas_Proteccion';
    $('select[name="' + grid + 'Grid_length"]').val('-1').trigger('change');
    $("#" + grid + "Grid_length").css("display", "none");
    $('.fa-pencil').click();
    $('.fa-check').parent().css("display", "none");
    $('.fa-times').parent().css("display", "none");
	$("#" + grid + "Grid_info").css("display", "none");
	$("#" + grid + "Grid_paginate").css("display", "none");
	
	
	$('input[id^="' + grid + '_"]').each(function () {
		if ($(this).attr('disabled')=="disabled")
		{
			$($(this).parent().find('label')[0]).css("display","none");
			$(this).css("display","none");
			$(this).after('<label>' + $(this).val() + '</label>');
		}
    });
	
	$('i[class="glyphicon glyphicon-plus"]').each(function () {
		$(this).css("display","none");
    });	
	
}

$(document).ready(function () {
/*CODIGO ABRIR GRID*/	
if(operation == 'Update'){	
	    setTimeout(function () {
        IniciaMR();
    }, 500);
}
	
//BusinessRuleId:2959, Attribute:268483, Operation:Field, Event:None
$("form#CreateMedidas_de_Proteccion").on('change', '#Fecha_de_Inicio', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Duracion_en_Dias' + rowIndex),EvaluaQuery("   declare @dia1 varchar(30)= dbo.Fn_formatearfecha('FLD[Fecha_de_Inicio]')"
+"     declare @dia2 varchar(30)= dbo.Fn_formatearfecha('FLD[Fecha_de_Conclusion]')"
+"  SELECT DATEDIFF(day,@dia1, @dia2)", rowIndex, nameOfTable));
});


//BusinessRuleId:2959, Attribute:268483, Operation:Field, Event:None

//BusinessRuleId:2960, Attribute:268485, Operation:Field, Event:None
$("form#CreateMedidas_de_Proteccion").on('change', '#Fecha_de_Conclusion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Inicio' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Conclusion' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { AsignarValor($('#' + nameOfTable + 'Duracion_en_Dias' + rowIndex),EvaluaQuery("   declare @dia1 varchar(30)= dbo.Fn_formatearfecha('FLD[Fecha_de_Inicio]')"
+"     declare @dia2 varchar(30)= dbo.Fn_formatearfecha('FLD[Fecha_de_Conclusion]')"
+"  SELECT DATEDIFF(day,@dia1, @dia2)", rowIndex, nameOfTable));} else {}
});


//BusinessRuleId:2960, Attribute:268485, Operation:Field, Event:None

//BusinessRuleId:2961, Attribute:268480, Operation:Field, Event:None
$("form#CreateMedidas_de_Proteccion").on('change', '#Tipo_de_Medida', function () {
	nameOfTable='';
	rowIndex='';
	$("#divMedidas").css("display", "none");
 fillMRFromQuery('Detalle_Medidas_Proteccion', " select null as Clave, null as Medidas_de_Proteccion ,Null as Seleccionar,Clave as Medida From Medida_de_Proteccion where Tipo=FLD[Tipo_de_Medida]");

	 /*CODIGO ABRIR GRID*/
    setTimeout(function () {
        IniciaMR();
    }, 500);
	$("#divMedidas").css("display", "block");
});


//BusinessRuleId:2961, Attribute:268480, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2956, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery("  select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery(" select Name from Spartan_User where Id_USer=GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:2956, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2952, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divExpediente_AT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_AT' + rowIndex));$('#divExpediente_MASC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));$('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Orden_de_Proteccion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Orden_de_Proteccion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Duracion_en_Dias" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Duracion_en_Dias' + rowIndex));} var valor = $('#' + nameOfTable + 'Aplicar_a' + rowIndex).val();   $('#' + nameOfTable + 'Aplicar_a' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Aplicar_a' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Aplicar_a' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary(" select Clave, Descripcion from Detalle_de_Relaciones where expediente_mp = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Aplicar_a' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary(" select Clave, Descripcion from Detalle_de_Relaciones where expediente_mp = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Aplicar_a' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Aplicar_a' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:2952, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2952, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divExpediente_AT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_AT' + rowIndex));$('#divExpediente_MASC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));$('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Orden_de_Proteccion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Orden_de_Proteccion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Duracion_en_Dias" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Duracion_en_Dias' + rowIndex));} var valor = $('#' + nameOfTable + 'Aplicar_a' + rowIndex).val();   $('#' + nameOfTable + 'Aplicar_a' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Aplicar_a' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Aplicar_a' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary(" select Clave, Descripcion from Detalle_de_Relaciones where expediente_mp = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Aplicar_a' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary(" select Clave, Descripcion from Detalle_de_Relaciones where expediente_mp = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Aplicar_a' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Aplicar_a' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:2952, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2952, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divExpediente_AT').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_AT' + rowIndex));$('#divExpediente_MASC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));$('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Orden_de_Proteccion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Orden_de_Proteccion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Duracion_en_Dias" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Duracion_en_Dias' + rowIndex));} var valor = $('#' + nameOfTable + 'Aplicar_a' + rowIndex).val();   $('#' + nameOfTable + 'Aplicar_a' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Aplicar_a' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Aplicar_a' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary(" select Clave, Descripcion from Detalle_de_Relaciones where expediente_mp = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Aplicar_a' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary(" select Clave, Descripcion from Detalle_de_Relaciones where expediente_mp = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Aplicar_a' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Aplicar_a' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:2952, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3899, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Orden_de_Proteccion' + rowIndex),'Se generará en automatico'); DisabledControl($("#" + nameOfTable + "Orden_de_Proteccion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Orden_de_Proteccion' + rowIndex));}

}
//BusinessRuleId:3899, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//

//CODMANINI-ADD CODIGO 
if (result)
    CM_CierraMr();
else{
	 setTimeout(function () {
        IniciaMR();
    }, 500);
}
//CODMANFIN-ADD
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:2962, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update medidas_de_proteccion set expediente_mp=GLOBAL[SpartanOperationId] where clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:2962, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Medidas_Proteccion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Medidas_Proteccion//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Medidas_Proteccion(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Medidas_Proteccion//
}
function EjecutarValidacionesAlEliminarMRDetalle_Medidas_Proteccion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Medidas_Proteccion//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Medidas_Proteccion(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2964, Attribute:268481, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Medida" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Medida' + rowIndex));}

}
//BusinessRuleId:2964, Attribute:268481, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2964, Attribute:268481, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Medida" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Medida' + rowIndex));}

}
//BusinessRuleId:2964, Attribute:268481, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Medidas_Proteccion//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Medidas_Proteccion(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2964, Attribute:268481, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Medida" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Medida' + rowIndex));}

}
//BusinessRuleId:2964, Attribute:268481, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2964, Attribute:268481, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Medida" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Medida' + rowIndex));}

}
//BusinessRuleId:2964, Attribute:268481, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Medidas_Proteccion//
    return result;
}

