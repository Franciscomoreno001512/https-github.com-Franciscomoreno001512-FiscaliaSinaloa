var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function() {

    $('#Resolucion_ATGuardarYNuevo').css('display', 'none');
    $('#Resolucion_ATGuardarYCopia').css('display', 'none');








    

//BusinessRuleId:4149, Attribute:273042, Operation:Field, Event:None
$("form#CreateResolucion_AT").on('change', '#Resolucion', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("SELECT Tipo from Resolucion where Clave = FLD[Resolucion]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'1');} else { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'2');}
});

//BusinessRuleId:4149, Attribute:273042, Operation:Field, Event:None

//BusinessRuleId:4179, Attribute:273048, Operation:Field, Event:None
$("form#CreateResolucion_AT").on('change', '#Resultado_de_Validacion', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("SELECT Tipo FROM Resolucion WHERE Clave = FLD[Resultado_de_Validacion]",rowIndex, nameOfTable)==TryParseInt('3', '3') ) { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'2');} else { AsignarValor($('#' + nameOfTable + 'Estatus' + rowIndex),'3');}
});

//BusinessRuleId:4179, Attribute:273048, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});

function EjecutarValidacionesAlComienzo() {






    //BusinessRuleId:4141, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divModulo_Atencion_Inicial').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        $('#divEstatus').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatus' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatus' + rowIndex));
        DisabledControl($("#" + nameOfTable + "Persona_que_Resuelve" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex)); }
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        var valor = $('#' + nameOfTable + 'Relacion' + rowIndex).val();
        $('#' + nameOfTable + 'Relacion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Relacion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Relacion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Relacion' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:4141, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4141, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divModulo_Atencion_Inicial').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        $('#divEstatus').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatus' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatus' + rowIndex));
        DisabledControl($("#" + nameOfTable + "Persona_que_Resuelve" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex)); }
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        var valor = $('#' + nameOfTable + 'Relacion' + rowIndex).val();
        $('#' + nameOfTable + 'Relacion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Relacion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Relacion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Relacion' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:4141, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4141, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divModulo_Atencion_Inicial').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        $('#divEstatus').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatus' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatus' + rowIndex));
        DisabledControl($("#" + nameOfTable + "Persona_que_Resuelve" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex)); }
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        var valor = $('#' + nameOfTable + 'Relacion' + rowIndex).val();
        $('#' + nameOfTable + 'Relacion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Relacion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Relacion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Relacion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Relacion' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:4141, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4142, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $("a[href='#tabDictaminacion']").css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Dictaminador' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones_Dictaminador' + rowIndex));
        AsignarValor($('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex), EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex), EvaluaQuery(" SELECT ID_USER FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:4142, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4144, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("SELECT COUNT(Folio) FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable) != TryParseInt('1', '1')) {
            alert(DecodifyText('Para resolver el expediente debe contar con Número de Denuncia generado', rowIndex, nameOfTable));
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Persona_que_Resuelve" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Resolucion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Relacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
                $('#Resolucion_ATGuardar').css('display', 'none'); }
        } else {}


    }
    //BusinessRuleId:4144, Attribute:0, Operation:Object, Event:SCREENOPENING

    























//BusinessRuleId:4145, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Folio) FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('1', '1') && EvaluaQuery("SELECT COUNT(CDI) FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('1', '1') ) { var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Resolucion WHERE TIPO IN (1,2) AND RESOLUCION_AT = 1 AND Aplica_para_Denuncia = 1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Resolucion WHERE TIPO IN (1,2) AND RESOLUCION_AT = 1 AND Aplica_para_Denuncia = 1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:4145, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4145, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Folio) FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('1', '1') && EvaluaQuery("SELECT COUNT(CDI) FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)!=TryParseInt('1', '1') ) { var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Resolucion WHERE TIPO IN (1,2) AND RESOLUCION_AT = 1 AND Aplica_para_Denuncia = 1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Resolucion WHERE TIPO IN (1,2) AND RESOLUCION_AT = 1 AND Aplica_para_Denuncia = 1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:4145, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4147, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(Folio) FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('1', '1') && EvaluaQuery("SELECT COUNT(CDI) FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Resolucion WHERE TIPO IN (1,2) AND RESOLUCION_AT = 1 AND Aplica_para_Carpeta_de_Investigacion = 1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Resolucion WHERE TIPO IN (1,2) AND RESOLUCION_AT = 1 AND Aplica_para_Carpeta_de_Investigacion = 1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:4147, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4147, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT COUNT(Folio) FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('1', '1') && EvaluaQuery("SELECT COUNT(CDI) FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { var valor = $('#' + nameOfTable + 'Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Resolucion WHERE TIPO IN (1,2) AND RESOLUCION_AT = 1 AND Aplica_para_Carpeta_de_Investigacion = 1", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Resolucion WHERE TIPO IN (1,2) AND RESOLUCION_AT = 1 AND Aplica_para_Carpeta_de_Investigacion = 1", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resolucion' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:4147, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4152, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') || GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_que_Resuelve" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_que_Resuelve' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatus" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatus' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}} else {}

}
//BusinessRuleId:4152, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4153, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') || GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Dictaminador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dictaminador' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_Dictaminador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Dictaminador' + rowIndex));}} else {}

}
//BusinessRuleId:4153, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4154, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('107', '107')!=EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $("a[href='#tabDictaminacion']").css('display', 'none'); DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Dictaminador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dictaminador' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resultado_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_Dictaminador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Dictaminador' + rowIndex));}} else {}

}
//BusinessRuleId:4154, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4155, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Dictaminador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dictaminador' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Dictaminador' + rowIndex));

}
//BusinessRuleId:4155, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4155, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Validacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Dictaminador" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dictaminador' + rowIndex));} SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_Dictaminador' + rowIndex));

}
//BusinessRuleId:4155, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4178, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') && TryParseInt('107', '107')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { AsignarValor($('#' + nameOfTable + 'Fecha_de_Validacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Validacion' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Dictaminador' + rowIndex),EvaluaQuery("SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable)); var valor = $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).val();   $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from resolucion where resolucion_padre_para_autorizacion=FLD[Resolucion]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from resolucion where resolucion_padre_para_autorizacion=FLD[Resolucion]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Resultado_de_Validacion' + rowIndex).val(valor).trigger('change'); $("a[href='#tabDictaminacion']").css('display', 'block');} else {}

}
//BusinessRuleId:4178, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}

function EjecutarValidacionesAntesDeGuardar() {
    var result = true;
    



//BusinessRuleId:4150, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('50300', '50300') ) { alert(DecodifyText('Para remitir la denuncia al Ministerio Público debe acceder a la opción de Canalización.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4150, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4150, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('50300', '50300') ) { alert(DecodifyText('Para remitir la denuncia al Ministerio Público debe acceder a la opción de Canalización.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4150, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4151, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("EXEC usp_ValidaRelacion_EnResolucion GLOBAL[SpartanOperationId], FLD[Relacion]",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText('No se pueden crear 2 resoluciones para la misma relación, favor de revisar', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4151, Attribute:2, Operation:Object, Event:BEFORESAVING





//BusinessRuleId:4180, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("select DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103),"
+"     CONVERT(DATE,CONVERT(VARCHAR(10), 'FLD[Fecha_de_Resolucion]' ,103),103))",rowIndex, nameOfTable)<TryParseInt('0', '0') ) { alert(DecodifyText('La fecha de resolución no puede ser anterior al día actual, favor de revisar', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4180, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}

function EjecutarValidacionesDespuesDeGuardar() {
    //BusinessRuleId:4146, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" EXEC usp_RevisarResolucionAT_ExpedienteTerminado GLOBAL[SpartanOperationId]", rowIndex, nameOfTable);

}
//BusinessRuleId:4146, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:4146, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 EvaluaQuery(" EXEC usp_RevisarResolucionAT_ExpedienteTerminado GLOBAL[SpartanOperationId]", rowIndex, nameOfTable);

}
//BusinessRuleId:4146, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:4181, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("update Resolucion_AT set Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId] where Clave = GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:4181, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}