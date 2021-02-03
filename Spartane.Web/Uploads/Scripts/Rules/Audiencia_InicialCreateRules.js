var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
    $("#Audiencia_InicialGuardarYNuevo").hide();
    $("#Audiencia_InicialGuardarYCopia").hide();
//BusinessRuleId:2755, Attribute:267763, Operation:Field, Event:None
$("form#CreateAudiencia_Inicial").on('change', '#Con_Detenido', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Especificar_Detencion' + rowIndex).val();   $('#' + nameOfTable + 'Especificar_Detencion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Especificar_Detencion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Especificar_Detencion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Especificacion_Detencion where Detenido = FLD[Con_Detenido]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Especificar_Detencion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Especificacion_Detencion where Detenido = FLD[Con_Detenido]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Especificar_Detencion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Especificar_Detencion' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:2755, Attribute:267763, Operation:Field, Event:None

//BusinessRuleId:2756, Attribute:267765, Operation:Field, Event:None
$("form#CreateAudiencia_Inicial").on('change', '#Control_de_Detencion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Control_de_Detencion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divEspecificar_Control_Detencion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Especificar_Control_Detencion' + rowIndex));} else { $('#divEspecificar_Control_Detencion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especificar_Control_Detencion' + rowIndex));}
});

//BusinessRuleId:2756, Attribute:267765, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2753, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2753, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2753, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));

}
//BusinessRuleId:2753, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2754, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery("SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2754, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2757, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Control_de_Detencion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divEspecificar_Control_Detencion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Especificar_Control_Detencion' + rowIndex));} else { $('#divEspecificar_Control_Detencion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especificar_Control_Detencion' + rowIndex));}

}
//BusinessRuleId:2757, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2876, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divEspecificar_Control_Detencion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especificar_Control_Detencion' + rowIndex));

}
//BusinessRuleId:2876, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:2758, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Audiencia_Inicial set expediente_mp = GLOBAL[SpartanOperationId] where clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2758, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Relaciones_Audiencia_Inicial//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Relaciones_Audiencia_Inicial//
}
function EjecutarValidacionesAlEliminarMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Relaciones_Audiencia_Inicial//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Relaciones_Audiencia_Inicial//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Relaciones_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Relaciones_Audiencia_Inicial//
    return result;
}

