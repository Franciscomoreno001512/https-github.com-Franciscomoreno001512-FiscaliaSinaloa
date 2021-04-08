var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {

	
//COD-MANI INI OCULTAR BOTONES
$('#Solicitud_de_Apoyo_ExternaGuardarYNuevo').css('display', 'none');
$('#Solicitud_de_Apoyo_ExternaGuardarYCopia').css('display', 'none');


//BusinessRuleId:4547, Attribute:273299, Operation:Field, Event:None
$("form#CreateSolicitud_de_Apoyo_Externa").on('change', '#Area_Asignada', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Area_Asignada' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).val();   $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).empty();         if(!$('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from SubArea_de_Servicios_de_Apoyo where area = FLD[Area_Asignada]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from SubArea_de_Servicios_de_Apoyo where area = FLD[Area_Asignada]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'SubArea_Asignada' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:4547, Attribute:273299, Operation:Field, Event:None



$("#Anio").bind('keypress', function(event) {
	var regex = new RegExp("[0-9]{1,4}");
	var key = String.fromCharCode(!event.charCode ? event.which : event.charCode);
	if (!regex.test(key)) {
		event.preventDefault();
		return false;
	}

	//Valida maximo de caracteres
	if (this.value.length > 3) {
		return false;
	}

});


//BusinessRuleId:4550, Attribute:273300, Operation:Field, Event:None
$("form#CreateSolicitud_de_Apoyo_Externa").on('change', '#SubArea_Asignada', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'SubArea_Asignada' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Dictamen_Solicitado' + rowIndex).val();   $('#' + nameOfTable + 'Dictamen_Solicitado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Dictamen_Solicitado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Dictamen_Solicitado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from documento where SubArea_de_Servicios_de_Apoyo = FLD[SubArea_Asignada] and Tipo_de_Documento = 10", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Dictamen_Solicitado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from documento where SubArea_de_Servicios_de_Apoyo = FLD[SubArea_Asignada] and Tipo_de_Documento = 10", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Dictamen_Solicitado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Dictamen_Solicitado' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:4550, Attribute:273300, Operation:Field, Event:None



//BusinessRuleId:4862, Attribute:273292, Operation:Field, Event:None
$("form#CreateSolicitud_de_Apoyo_Externa").on('change', '#Fecha_de_Solicitud', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103), CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Solicitud]',103),103))",rowIndex, nameOfTable)>TryParseInt('0', '0') && GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Solicitud' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { alert(DecodifyText(' No se puede seleccionar una fecha posterior al dia de hoy.', rowIndex, nameOfTable));

result=false; AsignarValor($('#' + nameOfTable + 'Fecha_de_Solicitud' + rowIndex),'');} else {}
});


//BusinessRuleId:4862, Attribute:273292, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {

	/*CODIGO MANUAL: RCR - PONER EL DOCUMENTO EN VISTA SOLO CONSULTA*/
    $($("#divAttachmentVer_Documento").find("label")[0]).text('Ver Contestación');
    $($("#divAttachmentVer_Documento").find("img")[0]).css("display", "none");
    $("#divVer_Documento").css("display", "none");





//BusinessRuleId:4546, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery("select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Fecha_de_Solicitud' + rowIndex),EvaluaQuery("select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_registro' + rowIndex),EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery("SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Region' + rowIndex),EvaluaQuery(" select Region from spartan_user where id_user = GLOBAL[USERID]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Unidad' + rowIndex),EvaluaQuery(" select unidad from spartan_user where id_user = GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:4546, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4545, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));}


}
//BusinessRuleId:4545, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4545, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));}


}
//BusinessRuleId:4545, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4548, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));


}
//BusinessRuleId:4548, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4548, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));


}
//BusinessRuleId:4548, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4548, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divFolio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Folio' + rowIndex));


}
//BusinessRuleId:4548, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4554, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divEstatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));


}
//BusinessRuleId:4554, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4554, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divEstatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));


}
//BusinessRuleId:4554, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4554, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divEstatus').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));


}
//BusinessRuleId:4554, Attribute:0, Operation:Object, Event:SCREENOPENING











//BusinessRuleId:4556, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Contestacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Hora_de_Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Contestacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Responsable_que_Contesta" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_que_Contesta' + rowIndex));} DisabledControl($("#" + nameOfTable + "No__Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'No__Contestacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Dictamen" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex));} DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}


}
//BusinessRuleId:4556, Attribute:0, Operation:Object, Event:SCREENOPENING









































































//BusinessRuleId:4555, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'1'); $("a[href='#tabContestacion']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Contestacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Contestacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_que_Contesta' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'No__Contestacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Dictamen' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Ver_Documento' + rowIndex));


}
//BusinessRuleId:4555, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4681, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:4681, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4681, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:4681, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4681, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:4681, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4682, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:4682, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4682, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:4682, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4682, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:4682, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4684, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:4684, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4684, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:4684, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4684, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) {} else {}


}
//BusinessRuleId:4684, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){


//BusinessRuleId:4553, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC InsertSolicitudExternaASolicitudServicios GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:4553, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


