var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
//Angel Acuña

/*CODIGO ABRIR GRID*/
function CM_CierraMr() {
    $('.fa-check').parent().click();
}
function IniciaMR() {
	var grid='Personas_donde_se_ejecuto_mandamiento';
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



// omar martinez
// INIT-CODIGO-MANUAL Valida que se escoja una persona por lo menos
const ValidarSeleccionados = function(){
    let array = [];
    let td = $("#Personas_donde_se_ejecuto_mandamientoGrid").find('tr').children().not('th');
    $.each(td, function(index, val){
        let id = val.id;
        let length = id.length;
        let campoTabla = id.slice(0, id.lastIndexOf("_"));
        let campo = campoTabla.slice(campoTabla.lastIndexOf("_") + 1 , campoTabla.length);

        // Obtiene los valores de la columna donde esta el checkbox de seleccionar y los almacena en array
        if(campo == 'Seleccionar'){
            array.push(val.textContent);
        }
    });
    // Revisar que por lo menos uno sea true, el texto de la columna
    const anyTrue = array.some((element) => element === 'true');
    return anyTrue;
}
// END-CODIGO-MANUAL

$(document).ready(function () {
    $("#Registro_de_CumplimientoGuardarYNuevo").hide();
    $("#Registro_de_CumplimientoGuardarYCopia").hide();

    /*CODIGO ABRIR GRID*/	
    if(operation == 'Update'){	
        setTimeout(function () {
        IniciaMR();
    }, 500);
    }
    
//BusinessRuleId:4945, Attribute:273755, Operation:Field, Event:None
$("form#CreateRegistro_de_Cumplimiento").on('change', '#Estado', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Estado' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('', '') ) { var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre from Municipio where Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre from Municipio where Estado = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');} else { var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre from Municipio", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre from Municipio", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');}
});


//BusinessRuleId:4945, Attribute:273755, Operation:Field, Event:None

//BusinessRuleId:4946, Attribute:273756, Operation:Field, Event:None
$("form#CreateRegistro_de_Cumplimiento").on('change', '#Municipio', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();   $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
});


//BusinessRuleId:4946, Attribute:273756, Operation:Field, Event:None



//BusinessRuleId:4947, Attribute:273757, Operation:Field, Event:None
$("form#CreateRegistro_de_Cumplimiento").on('change', '#Poblacion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');} else { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');}
});


//BusinessRuleId:4947, Attribute:273757, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






//BusinessRuleId:4943, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divMandamiento_Judicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Mandamiento_Judicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Mandamiento_Judicial' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_de_Registro' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_de_Registro' + rowIndex));


}
//BusinessRuleId:4943, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4943, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divMandamiento_Judicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Mandamiento_Judicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Mandamiento_Judicial' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_de_Registro' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_de_Registro' + rowIndex));


}
//BusinessRuleId:4943, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4943, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divMandamiento_Judicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Mandamiento_Judicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Mandamiento_Judicial' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_de_Registro' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_de_Registro' + rowIndex));


}
//BusinessRuleId:4943, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:4944, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex),EvaluaQuery("select Nombre from Estado where  Clave = 25", rowIndex, nameOfTable)); var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();   $('#' + nameOfTable + 'Estado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Nombre from Estado", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Nombre from Estado", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Estado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:4944, Attribute:0, Operation:Object, Event:SCREENOPENING























//BusinessRuleId:4950, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('.PersonaIdHeader').css('display', 'none');
var index = $('.PersonaIdHeader').index();
 eval($('.PersonaIdHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide(); DisabledControl($("#" + nameOfTable + "Persona" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona' + rowIndex));}


}
//BusinessRuleId:4950, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4950, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('.PersonaIdHeader').css('display', 'none');
var index = $('.PersonaIdHeader').index();
 eval($('.PersonaIdHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide(); DisabledControl($("#" + nameOfTable + "Persona" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona' + rowIndex));}


}
//BusinessRuleId:4950, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4950, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('.PersonaIdHeader').css('display', 'none');
var index = $('.PersonaIdHeader').index();
 eval($('.PersonaIdHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide(); DisabledControl($("#" + nameOfTable + "Persona" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona' + rowIndex));}


}
//BusinessRuleId:4950, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:4949, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 fillMRFromQuery('Personas_donde_se_ejecuto_mandamiento', "SELECT "
+"     null as Folio, "
+"     null as Cumplimiento, "
+"     responsable.Nombre_Completo_Detenido as Persona, "
+"     null as Seleccionar, "
+"     responsable..Clave as PersonaId "
+" FROM Registro_de_Mandamiento_Judicial MJ WITH(NOLOCK)"
+" INNER JOIN detalle_de_imputado responsable ON MJ.Clave = responsable.Mandamiento_Judicial"
+" LEFT JOIN Personas_donde_se_ejecuto_mandamiento pMJ ON responsable.Clave = pMJ.PersonaId"
+" WHERE MJ.Clave = GLOBAL[SpartanOperationId] AND (pMJ.Seleccionar = 0 OR pMJ.Seleccionar is null)"); $('.PersonaIdHeader').css('display', 'none');
var index = $('.PersonaIdHeader').index();
 eval($('.PersonaIdHeader').parent().parent().parent()[0].id.replace("Grid", "Table")).find("td:eq("+index+")").hide();

 /*CODIGO ABRIR GRID*/
setTimeout(function () {
    IniciaMR();
}, 500);

}
//BusinessRuleId:4949, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4974, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_de_Registro' + rowIndex),EvaluaQuery(" SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));


}
//BusinessRuleId:4974, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4985, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Area_que_envia_cumplimiento' + rowIndex).val();   $('#' + nameOfTable + 'Area_que_envia_cumplimiento' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Area_que_envia_cumplimiento' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Area_que_envia_cumplimiento' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Area_envia_Cumplimiento where vigente = 1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Area_que_envia_cumplimiento' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Area_envia_Cumplimiento where vigente = 1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Area_que_envia_cumplimiento' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Area_que_envia_cumplimiento' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:4985, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
    
    // INIT-CODIGO-MANUAL Aplica validacion de que se escoja una persona por lo menos
    let hayPersonas = ValidarSeleccionados();
    if(!hayPersonas){
        alert('Se debe escoger por lo menos una persona a quien se le ejecutó el mandamiento');
        return false;
    }
    // END-CODIGO-MANUAL

//NEWBUSINESSRULE_BEFORESAVING//

    /*CODIGO CERRAR GRID*/
    if (result)
        CM_CierraMr();
    else{
        setTimeout(function () {
            IniciaMR();
        }, 500);
    }
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:4948, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Registro_de_Cumplimiento set Mandamiento_Judicial = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:4948, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:4973, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC usp_ValidaCerrar_MandamientoJudicial GLOBAL[SpartanOperationId]", rowIndex, nameOfTable);


}
//BusinessRuleId:4973, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Personas_donde_se_ejecuto_mandamiento//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Personas_donde_se_ejecuto_mandamiento//
}
function EjecutarValidacionesAlEliminarMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Personas_donde_se_ejecuto_mandamiento//
    return result;
}
function EjecutarValidacionesNewRowMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndex){
    var result = true;
    



//NEWBUSINESSRULE_NEWROWMR_Personas_donde_se_ejecuto_mandamiento//
    return result;
}
function EjecutarValidacionesEditRowMRPersonas_donde_se_ejecuto_mandamiento(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:4951, Attribute:273766, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Persona" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona' + rowIndex));}


}
//BusinessRuleId:4951, Attribute:273766, Operation:Object, Event:EDITROWMR

//BusinessRuleId:4951, Attribute:273766, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Persona" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona' + rowIndex));}


}
//BusinessRuleId:4951, Attribute:273766, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Personas_donde_se_ejecuto_mandamiento//
    return result;
}