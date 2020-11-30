var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$('#Servicios_de_Apoyo_MPGuardarYNuevo').hide();
$('#Servicios_de_Apoyo_MPGuardarYCopia').hide();
$(document).ready(function () {




//BusinessRuleId:2571, Attribute:267334, Operation:Field, Event:None
$("form#CreateServicios_de_Apoyo_MP").on('change', '#Categoria', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).val();   $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:2571, Attribute:267334, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2561, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}

}
//BusinessRuleId:2561, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2561, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}

}
//BusinessRuleId:2561, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2561, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex)); DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));}

}
//BusinessRuleId:2561, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2562, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery("select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery(" select name from spartan_user where id_user=GLOBAL[USERID]", rowIndex, nameOfTable)); $('#divArchivo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Archivo' + rowIndex));

}
//BusinessRuleId:2562, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2576, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).val();   $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2576, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2576, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 var valor = $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).val();   $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select Clave, Servicio from Tipo_de_Servicio_de_Apoyo where Categoria = FLD[Categoria]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2576, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2580, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select clave,descripcion from Diligencias_MP where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select clave,descripcion from Diligencias_MP where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2580, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2580, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).val();   $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("Select clave,descripcion from Diligencias_MP where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("Select clave,descripcion from Diligencias_MP where Expediente_MP=GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Diligencia_a_Enviar' + rowIndex).val(valor).trigger('change');

}
//BusinessRuleId:2580, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:2578, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Servicios_de_Apoyo_MP set expediente_mp = GLOBAL[SpartanOperationId] where clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2578, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//

    debugger;
    //fjmore
    if (operation == 'New') {
        debugger;
        var diligencia = $('#Diligencia_a_Enviar').val();
        var query = 'select top 1 cd.Archivo from Diligencias_MP doc with (nolock) inner join Control_de_Documentos cd with (nolock) on doc.Archivo = cd.Folio where doc.Clave = ' + diligencia + '';
        var SpartanFileId = EvaluaQuery(query);

        var resultado = GetSpartanFileAndPost(SpartanFileId);
        if (resultado > 0) {
            var key = EvaluaQuery(" select GLOBAL[keyvalueinserted]");
            var queryUpd = 'update Servicios_de_Apoyo_MP set Archivo_adjunto = ' + resultado + ' where Clave = ' + key + '';
            var dataResult = EvaluaQuery(queryUpd);

        }
        else {

            alert("No se pudo actualizar el archivo en detalle_de_documentos");
        }


    }
}


