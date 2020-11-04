var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;

$('#Detalle_Diligencias_MASCGuardarYNuevo').hide()
$('#Detalle_Diligencias_MASCGuardarYCopia').hide()

$(document).ready(function () {




//BusinessRuleId:1710, Attribute:265978, Operation:Field, Event:None
$("form#CreateDetalle_Diligencias_MASC").on('change', '#Tipo_de_Diligencia', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Diligencia' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,descripcion from Dilgencia_MASC where tipo_de_diligencia = FLD[Tipo_de_Diligencia] ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,descripcion from Dilgencia_MASC where tipo_de_diligencia = FLD[Tipo_de_Diligencia] ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:1710, Attribute:265978, Operation:Field, Event:None

//BusinessRuleId:1956, Attribute:265979, Operation:Field, Event:None
$("form#CreateDetalle_Diligencias_MASC").on('change', '#Diligencia', function () {
	nameOfTable='';
	rowIndex='';
 SetRequiredToControl( $('#' + nameOfTable + 'Diligencia' + rowIndex));
});

//BusinessRuleId:1956, Attribute:265979, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {


//BusinessRuleId:1709, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Facilitador' + rowIndex),EvaluaQuery(" select Name from  Spartan_User where id_user=GLOBAL[USERID]", rowIndex, nameOfTable)); $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));


}
//BusinessRuleId:1709, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1916, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));}DisabledControl($("#" + nameOfTable + "Facilitador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Facilitador' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:1916, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1708, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora' + rowIndex));}DisabledControl($("#" + nameOfTable + "Facilitador" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Facilitador' + rowIndex));} $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:1708, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1964, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1964, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1964, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1964, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1964, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divSolicitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Solicitud' + rowIndex));

}
//BusinessRuleId:1964, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:1711, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Detalle_Diligencias_MASC"
+" 	set Solicitud = GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:1711, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


