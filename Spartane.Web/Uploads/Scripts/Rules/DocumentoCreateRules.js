var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {




//BusinessRuleId:4519, Attribute:273208, Operation:Field, Event:None
$("form#CreateDocumento").on('change', '#Area_de_Servicios_de_Apoyo', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).val();   $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).empty();         if(!$('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLD[Area_de_Servicios_de_Apoyo]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLD[Area_de_Servicios_de_Apoyo]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:4519, Attribute:273208, Operation:Field, Event:None

//BusinessRuleId:4386, Attribute:266635, Operation:Field, Event:None
$("form#CreateDocumento").on('change', '#Tipo_de_Documento', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('10', '10') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('9', '9') ) { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); $('#divArea_de_Servicios_de_Apoyo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Area_de_Servicios_de_Apoyo' + rowIndex));} else { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));$('#divArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_de_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Area_de_Servicios_de_Apoyo' + rowIndex));}
});

//BusinessRuleId:4386, Attribute:266635, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {




























//BusinessRuleId:4385, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('10', '10') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('9', '9') ) { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'block');$('#divArea_de_Servicios_de_Apoyo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Area_de_Servicios_de_Apoyo' + rowIndex));} else { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));$('#divArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_de_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Area_de_Servicios_de_Apoyo' + rowIndex));}

}
//BusinessRuleId:4385, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4385, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('10', '10') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Documento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('9', '9') ) { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'block');$('#divArea_de_Servicios_de_Apoyo').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Area_de_Servicios_de_Apoyo' + rowIndex));} else { $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex)); $('#divSubArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));$('#divArea_de_Servicios_de_Apoyo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Area_de_Servicios_de_Apoyo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Area_de_Servicios_de_Apoyo' + rowIndex));}

}
//BusinessRuleId:4385, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4539, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Area_de_Servicios_de_Apoyo' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { var valor = $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).val();   $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).empty();         if(!$('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLD[Area_de_Servicios_de_Apoyo]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM SubArea_de_Servicios_de_Apoyo WHERE AREA = FLD[Area_de_Servicios_de_Apoyo]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'SubArea_de_Servicios_de_Apoyo' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:4539, Attribute:0, Operation:Object, Event:SCREENOPENING

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


