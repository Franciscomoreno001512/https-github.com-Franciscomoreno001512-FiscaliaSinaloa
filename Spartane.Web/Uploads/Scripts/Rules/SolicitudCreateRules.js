var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {


//BusinessRuleId:332, Attribute:262901, Operation:Field, Event:None
$("form#CreateSolicitud").on('change', '#EstadoH', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'EstadoH' + rowIndex).val()!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'MunicipioH' + rowIndex).val();   $('#' + nameOfTable + 'MunicipioH' + rowIndex).empty();         if(!$('#' + nameOfTable + 'MunicipioH' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'MunicipioH' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,nombre from Municipio where Estado = FLD[EstadoH]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'MunicipioH' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,nombre from Municipio where Estado = FLD[EstadoH]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'MunicipioH' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'MunicipioH' + rowIndex).val(valor).trigger('change');} else {}
});

//BusinessRuleId:332, Attribute:262901, Operation:Field, Event:None





//BusinessRuleId:435, Attribute:262897, Operation:Field, Event:None
$("form#CreateSolicitud").on('change', '#ColoniaH', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'ColoniaH' + rowIndex).val()!=TryParseInt('null', 'null') ) { AsignarValor($('#' + nameOfTable + 'Codigo_PostalH' + rowIndex),EvaluaQuery("select codigo_postalc from codigo_postal where colonia=FLD[ColoniaH]", rowIndex, nameOfTable));} else {}
});

//BusinessRuleId:435, Attribute:262897, Operation:Field, Event:None





//BusinessRuleId:2027, Attribute:263024, Operation:Field, Event:None
$("form#CreateSolicitud").on('change', '#PaisH', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'EstadoH' + rowIndex).val();   $('#' + nameOfTable + 'EstadoH' + rowIndex).empty();         if(!$('#' + nameOfTable + 'EstadoH' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'EstadoH' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave,Nombre from Estado where Pais=FLD[PaisH]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'EstadoH' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave,Nombre from Estado where Pais=FLD[PaisH]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'EstadoH' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'EstadoH' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:2027, Attribute:263024, Operation:Field, Event:None

//BusinessRuleId:434, Attribute:262902, Operation:Field, Event:None
$("form#CreateSolicitud").on('change', '#MunicipioH', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'MunicipioH' + rowIndex).val()!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'ColoniaH' + rowIndex).val();   $('#' + nameOfTable + 'ColoniaH' + rowIndex).empty();         if(!$('#' + nameOfTable + 'ColoniaH' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'ColoniaH' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave, nombre from colonia where municipio=FLD[MunicipioH]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'ColoniaH' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave, nombre from colonia where municipio=FLD[MunicipioH]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'ColoniaH' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'ColoniaH' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select clave, nombre from colonia where municipio=FLD[MunicipioH]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select clave, nombre from colonia where municipio=FLD[MunicipioH]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');} else {}
});

//BusinessRuleId:434, Attribute:262902, Operation:Field, Event:None





//BusinessRuleId:1991, Attribute:262924, Operation:Field, Event:None
$("form#CreateSolicitud").on('change', '#Asignar_Especialista_Automatico', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Asignar_Especialista_Automatico' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') ) { $('#divRazone').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razone' + rowIndex)); DisabledControl($("#" + nameOfTable + "Especialista_AsignadoA" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex));} AsignarValor($('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex),EvaluaQuery("exec uspAsignaFacilitadorMASC", rowIndex, nameOfTable));} else { $('#divRazone').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Razone' + rowIndex)); DisabledControl($("#" + nameOfTable + "Especialista_AsignadoA" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex));}}
});

//BusinessRuleId:1991, Attribute:262924, Operation:Field, Event:None





//BusinessRuleId:2051, Attribute:263018, Operation:Field, Event:None
$("form#CreateSolicitud").on('change', '#Rechazar', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Rechazar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') || GetValueByControlType($('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));}
});

//BusinessRuleId:2051, Attribute:263018, Operation:Field, Event:None



//BusinessRuleId:2052, Attribute:262992, Operation:Field, Event:None
$("form#CreateSolicitud").on('change', '#Acuerdo_Cumplido', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divRazon_de_Incumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));$('#divRazon_de_Incumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex)); SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));} else { $('#divRazon_de_Incumplimiento').css('display', 'block');$('#divRazon_de_Incumplimiento').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));}
});

//BusinessRuleId:2052, Attribute:262992, Operation:Field, Event:None

//BusinessRuleId:2053, Attribute:262992, Operation:Field, Event:None
$("form#CreateSolicitud").on('change', '#Acuerdo_Cumplido', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { $('#divRazon_de_Incumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));$('#divRazon_de_Incumplimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));} else {}
});

//BusinessRuleId:2053, Attribute:262992, Operation:Field, Event:None

//BusinessRuleId:2054, Attribute:266590, Operation:Field, Event:None
$("form#CreateSolicitud").on('change', '#Tipo_de_Conclusion_Anticipada', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Conclusion_Anticipada' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex),EvaluaQuery(" select ''", rowIndex, nameOfTable));}
});

//BusinessRuleId:2054, Attribute:266590, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






//BusinessRuleId:1868, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1868, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1868, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1868, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1868, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1868, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1870, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1870, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1870, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1870, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1870, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1870, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1872, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1872, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1872, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1872, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1872, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1872, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1874, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1874, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1874, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1874, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1874, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1874, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1876, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1876, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1876, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1876, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1876, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1876, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1878, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1878, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1878, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1878, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1878, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1878, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1880, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1880, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1880, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1880, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1880, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1880, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1882, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1882, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1882, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1882, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1882, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1882, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1884, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1884, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1884, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1884, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1884, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1884, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1886, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1886, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1886, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1886, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1886, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1886, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1888, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1888, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1888, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1888, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1888, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) {} else {}

}
//BusinessRuleId:1888, Attribute:0, Operation:Object, Event:SCREENOPENING









//BusinessRuleId:1987, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CalleH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_ExteriorH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_InteriorH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'ColoniaH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_PostalH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'EstadoH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'MunicipioH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'LongitudH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'LatitudH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'PaisH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));

}
//BusinessRuleId:1987, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1981, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_AsignacionA" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_AsignacionA' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_AsignacionA" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_AsignacionA' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Atencion_del_Especialista" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Atencion_del_Especialista' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Atencion_del_Especialista" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Atencion_del_Especialista' + rowIndex));}

}
//BusinessRuleId:1981, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1980, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Agente_del_Ministerio_Publico_Invest" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Agente_del_Ministerio_Publico_Invest' + rowIndex));}DisabledControl($("#" + nameOfTable + "Juez_de_Control" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_de_Control' + rowIndex));}DisabledControl($("#" + nameOfTable + "Agente_del_Ministerio_Publico_Orientador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Agente_del_Ministerio_Publico_Orientador' + rowIndex));}

}
//BusinessRuleId:1980, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1979, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Remitente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Remitente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Expediente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));}DisabledControl($("#" + nameOfTable + "A_Tiempo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'A_Tiempo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_de_Remitente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_Remitente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno_del_Remitente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Remitente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno_del_Remitente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Remitente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_en_que_llega_a_Coordinador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_a_Coordinador' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_en_que_llega_a_Especialista" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_a_Especialista' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Folio' + rowIndex));}DisabledControl($("#" + nameOfTable + "NUC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'NUC' + rowIndex));}DisabledControl($("#" + nameOfTable + "CDI" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'CDI' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad_MASC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_MASC' + rowIndex));}

}
//BusinessRuleId:1979, Attribute:0, Operation:Object, Event:SCREENOPENING





















//BusinessRuleId:1990, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Asignar_Especialista_Automatico' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') ) { $('#divRazone').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Razone' + rowIndex)); DisabledControl($("#" + nameOfTable + "Especialista_AsignadoA" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex));}} else { $('#divRazone').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Especialista_AsignadoA" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex));} SetRequiredToControl( $('#' + nameOfTable + 'Razone' + rowIndex));}

}
//BusinessRuleId:1990, Attribute:0, Operation:Object, Event:SCREENOPENING


















//BusinessRuleId:2007, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex).val();   $('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select ID_User, Name from Spartan_User where Role=3", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select ID_User, Name from Spartan_User where Role=3", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Especialista_AsignadoA' + rowIndex).val(valor).trigger('change'); DisabledControl($("#" + nameOfTable + "Fecha_de_AsignacionA" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_AsignacionA' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_AsignacionA" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_AsignacionA' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Atencion_del_Especialista" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Atencion_del_Especialista' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Atencion_del_Especialista" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Atencion_del_Especialista' + rowIndex));}


}
//BusinessRuleId:2007, Attribute:0, Operation:Object, Event:SCREENOPENING








//BusinessRuleId:2043, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('91', '91') ) { SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex));}

}
//BusinessRuleId:2043, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:2045, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Conclusion_Anticipada' + rowIndex)); $("a[href='#tabCierre']").css('display', 'none'); $("a[href='#tabHistorial_de_Movimientos']").css('display', 'none'); $('#divNumero_de_Expediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));$('#divFecha_de_Atencion_del_Especialista').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Atencion_del_Especialista' + rowIndex));$('#divHora_de_Atencion_del_Especialista').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Atencion_del_Especialista' + rowIndex));$('#divTipo_de_Mecanismo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Mecanismo' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Fecha_de_AsignacionA' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_AsignacionA' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));} else {}

}
//BusinessRuleId:2045, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2050, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Rechazar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') && GetValueByControlType($('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex),nameOfTable,rowIndex)==GetValueByControlType($('#' + nameOfTable + '' + rowIndex),nameOfTable,rowIndex) ) { SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Cierre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Cierre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_de_Incumplimiento' + rowIndex));} else {}

}
//BusinessRuleId:2050, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2012, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Remitente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Remitente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Expediente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Expediente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_en_que_llega_a_Coordinador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_a_Coordinador' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_en_que_llega_a_Especialista" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_en_que_llega_a_Especialista' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Folio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Folio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Agente_del_Ministerio_Publico_Invest" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Agente_del_Ministerio_Publico_Invest' + rowIndex));}DisabledControl($("#" + nameOfTable + "Juez_de_Control" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_de_Control' + rowIndex));}DisabledControl($("#" + nameOfTable + "Agente_del_Ministerio_Publico_Orientador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Agente_del_Ministerio_Publico_Orientador' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad_MASC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_MASC' + rowIndex));}DisabledControl($("#" + nameOfTable + "NUAT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'NUAT' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_AsignacionA" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_AsignacionA' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_AsignacionA" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_AsignacionA' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Atencion_del_Especialista" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Atencion_del_Especialista' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Atencion_del_Especialista" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Atencion_del_Especialista' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CalleH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_ExteriorH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_InteriorH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'ColoniaH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_PostalH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'EstadoH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'MunicipioH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'LongitudH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'LatitudH' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Acuerdo_Cumplido' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Conclusion_Anticipada' + rowIndex));

}
//BusinessRuleId:2012, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){




//BusinessRuleId:2021, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery("exec uspAsignaEstatusMecanismosAlternos FLDD[lblClave],GLOBAL[USERID],GLOBAL[USERROLEID]", rowIndex, nameOfTable);

}
//BusinessRuleId:2021, Attribute:2, Operation:Object, Event:AFTERSAVING




//BusinessRuleId:2022, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('101', '101') && GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { SendEmailQuery('SAPROJ - Nueva Solicitud de MASC Asignada', EvaluaQuery("exec uspGetCorreoFacilitadorAsignado FLDD[lblClave]"), "		Estimado FLDD[Especialista_AsignadoA],"
+" 		<br><br>"
+" 		Por este medio se le informa que se le ha asignado la solicitud no. <b>FLD[Numero_de_Folio]</b>, favor de acceder a SAPROJ para realizar el seguimiento requerido.",rowIndex,nameOfTable);} else {}

}
//BusinessRuleId:2022, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_Solicitante(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitud_Solicitante//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitud_Solicitante(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitud_Solicitante//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitud_Solicitante(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitud_Solicitante//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitud_Solicitante(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitud_Solicitante//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitud_Solicitante(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitud_Solicitante//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Delito_de_Justicia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Delito_de_Justicia//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Delito_de_Justicia(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Delito_de_Justicia//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Delito_de_Justicia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Delito_de_Justicia//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Delito_de_Justicia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Delito_de_Justicia//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Delito_de_Justicia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Delito_de_Justicia//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Examen(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitante_en_Examen//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_en_Examen(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitante_en_Examen//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitante_en_Examen(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitante_en_Examen//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitante_en_Examen(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitante_en_Examen//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitante_en_Examen(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitante_en_Examen//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requerido_en_Examen(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Requerido_en_Examen//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Requerido_en_Examen(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Requerido_en_Examen//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Requerido_en_Examen(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Requerido_en_Examen//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Requerido_en_Examen(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Requerido_en_Examen//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Requerido_en_Examen(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Requerido_en_Examen//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Asignacion_de_Especialista(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Asignacion_de_Especialista//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Asignacion_de_Especialista(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Asignacion_de_Especialista//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Asignacion_de_Especialista(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Asignacion_de_Especialista//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Asignacion_de_Especialista(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Asignacion_de_Especialista//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Asignacion_de_Especialista(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Asignacion_de_Especialista//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_documentos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_documentos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_documentos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_documentos//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_documentos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_documentos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_documentos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_documentos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_documentos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_documentos//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitante_en_Invitaciones//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitante_en_Invitaciones//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitante_en_Invitaciones//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitante_en_Invitaciones//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitante_en_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitante_en_Invitaciones//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Requerido_en_Invitaciones//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Requerido_en_Invitaciones//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Requerido_en_Invitaciones//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Requerido_en_Invitaciones//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Requerido_en_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Requerido_en_Invitaciones//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitante_en_Comparecencia//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_en_Comparecencia(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitante_en_Comparecencia//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitante_en_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitante_en_Comparecencia//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitante_en_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitante_en_Comparecencia//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitante_en_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitante_en_Comparecencia//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requerido_en_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Requerido_en_Comparecencia//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Requerido_en_Comparecencia(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Requerido_en_Comparecencia//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Requerido_en_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Requerido_en_Comparecencia//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Requerido_en_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Requerido_en_Comparecencia//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Requerido_en_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Requerido_en_Comparecencia//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Reuniones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitante_en_Reuniones//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_en_Reuniones(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitante_en_Reuniones//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitante_en_Reuniones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitante_en_Reuniones//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitante_en_Reuniones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitante_en_Reuniones//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitante_en_Reuniones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitante_en_Reuniones//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requerido_en_Reuniones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Requerido_en_Reuniones//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Requerido_en_Reuniones(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Requerido_en_Reuniones//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Requerido_en_Reuniones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Requerido_en_Reuniones//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Requerido_en_Reuniones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Requerido_en_Reuniones//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Requerido_en_Reuniones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Requerido_en_Reuniones//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitudes_de_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitudes_de_Invitaciones//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitudes_de_Invitaciones(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitudes_de_Invitaciones//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitudes_de_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitudes_de_Invitaciones//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitudes_de_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitudes_de_Invitaciones//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitudes_de_Invitaciones(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitudes_de_Invitaciones//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitudes_de_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitudes_de_Comparecencia//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitudes_de_Comparecencia(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitudes_de_Comparecencia//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitudes_de_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitudes_de_Comparecencia//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitudes_de_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitudes_de_Comparecencia//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitudes_de_Comparecencia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitudes_de_Comparecencia//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_Requerido(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitud_Requerido//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitud_Requerido(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitud_Requerido//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitud_Requerido(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitud_Requerido//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitud_Requerido(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitud_Requerido//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitud_Requerido(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitud_Requerido//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_Datos_de_Apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitud_Datos_de_Apoyo//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitud_Datos_de_Apoyo(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitud_Datos_de_Apoyo//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitud_Datos_de_Apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitud_Datos_de_Apoyo//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitud_Datos_de_Apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitud_Datos_de_Apoyo//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitud_Datos_de_Apoyo(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitud_Datos_de_Apoyo//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Reuniones_de_Mediacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Reuniones_de_Mediacion//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Reuniones_de_Mediacion(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Reuniones_de_Mediacion//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Reuniones_de_Mediacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Reuniones_de_Mediacion//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Reuniones_de_Mediacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Reuniones_de_Mediacion//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Reuniones_de_Mediacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Reuniones_de_Mediacion//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_Seguimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitud_Seguimiento//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitud_Seguimiento(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitud_Seguimiento//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitud_Seguimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitud_Seguimiento//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitud_Seguimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitud_Seguimiento//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitud_Seguimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitud_Seguimiento//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_Representante_Legal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitud_Representante_Legal//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitud_Representante_Legal(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitud_Representante_Legal//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitud_Representante_Legal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitud_Representante_Legal//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitud_Representante_Legal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitud_Representante_Legal//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitud_Representante_Legal(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitud_Representante_Legal//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitud_Bitacora_de_Coincid(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitud_Bitacora_de_Coincid//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitud_Bitacora_de_Coincid(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitud_Bitacora_de_Coincid//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitud_Bitacora_de_Coincid(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitud_Bitacora_de_Coincid//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitud_Bitacora_de_Coincid(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitud_Bitacora_de_Coincid//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitud_Bitacora_de_Coincid(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitud_Bitacora_de_Coincid//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Historico_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Historico_JA//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Historico_JA(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Historico_JA//
}
function EjecutarValidacionesAlEliminarMRDetalle_Historico_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Historico_JA//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Historico_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Historico_JA//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Historico_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Historico_JA//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Audiencias_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitante_en_Audiencias_JA//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_en_Audiencias_JA(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitante_en_Audiencias_JA//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitante_en_Audiencias_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitante_en_Audiencias_JA//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitante_en_Audiencias_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitante_en_Audiencias_JA//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitante_en_Audiencias_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitante_en_Audiencias_JA//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_Fundamentos_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitante_Fundamentos_JA//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_Fundamentos_JA(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitante_Fundamentos_JA//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitante_Fundamentos_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitante_Fundamentos_JA//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitante_Fundamentos_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitante_Fundamentos_JA//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitante_Fundamentos_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitante_Fundamentos_JA//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Hechos_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Hechos_Audiencia_Inicial//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Hechos_Audiencia_Inicial(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Hechos_Audiencia_Inicial//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Hechos_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Hechos_Audiencia_Inicial//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Hechos_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Hechos_Audiencia_Inicial//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Hechos_Audiencia_Inicial(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Hechos_Audiencia_Inicial//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_Procedimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitante_Procedimiento//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_Procedimiento(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitante_Procedimiento//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitante_Procedimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitante_Procedimiento//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitante_Procedimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitante_Procedimiento//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitante_Procedimiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitante_Procedimiento//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_Reiteracion_Salud(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Solicitante_Reiteracion_Salud//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_Reiteracion_Salud(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Solicitante_Reiteracion_Salud//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Solicitante_Reiteracion_Salud(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Solicitante_Reiteracion_Salud//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Solicitante_Reiteracion_Salud(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Solicitante_Reiteracion_Salud//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Solicitante_Reiteracion_Salud(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Solicitante_Reiteracion_Salud//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requeridos_Faltantes(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Requeridos_Faltantes//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Requeridos_Faltantes(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Requeridos_Faltantes//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Requeridos_Faltantes(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Requeridos_Faltantes//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Requeridos_Faltantes(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Requeridos_Faltantes//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Requeridos_Faltantes(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Requeridos_Faltantes//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_de_Persona_Moral_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_de_Persona_Moral_JA//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Persona_Moral_JA(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_de_Persona_Moral_JA//
}
function EjecutarValidacionesAlEliminarMRDetalle_de_Persona_Moral_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_de_Persona_Moral_JA//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_de_Persona_Moral_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_de_Persona_Moral_JA//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_de_Persona_Moral_JA(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_de_Persona_Moral_JA//
    return result;
}

