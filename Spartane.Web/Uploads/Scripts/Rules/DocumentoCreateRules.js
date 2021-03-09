var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {


//BusinessRuleId:4386, Attribute:266635, Operation:Field, Event:None
$("form#CreateDocumento").on('change', '#Tipo_de_Documento', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('10', '10') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('9', '9') ) { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));} else { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));}
});

//BusinessRuleId:4386, Attribute:266635, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






//BusinessRuleId:4385, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('10', '10') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('9', '9') ) { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));} else { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));}

}
//BusinessRuleId:4385, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4385, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('10', '10') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('9', '9') ) { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));} else { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));}

}
//BusinessRuleId:4385, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4385, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('10', '10') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('9', '9') ) { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));} else { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));}

}
//BusinessRuleId:4385, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//NEWBUSINESSRULE_AFTERSAVING//
}


