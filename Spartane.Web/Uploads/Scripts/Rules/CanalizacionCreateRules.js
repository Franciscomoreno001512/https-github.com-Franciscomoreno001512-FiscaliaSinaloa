var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function() {

    if (operation == 'Update') {
        $('#CanalizacionGuardar').remove();
    }

    /* DESARROLLO PARA LA REGLA 4107
    if (operation == 'Update') {
        if (EvaluaQuery("select Canalizado from Canalizacion where Clave = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2')) {
            $('#CanalizacionGuardar').remove();
        }
    }
    */

   if(operation == 'Update'){
        if( TryParseInt('107', '107')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ){
            $("#CanalizacionGuardar").hide();
        }
    }

    if(operation == 'New'){
        if( EvaluaQuery("select Tipo_de_Denuncia from Modulo_Atencion_Inicial where clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('4', '4') ) {
            $("#CanalizacionGuardar").hide();
        }
    }


    //COD-MANI INI OCULTAR BOTONES
    $('#CanalizacionGuardarYNuevo').css('display', 'none');
    $('#CanalizacionGuardarYCopia').css('display', 'none');
    $('#ConfigureSave').css('display', 'none');
    //COD-MANI END OCULTAR BOTONES






    

    //BusinessRuleId:3897, Attribute:269152, Operation:Field, Event:None
$("form#CreateCanalizacion").on('change', '#Canalizar_a', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("EXEC uspGetMunicipiosCanalizacion FLD[Canalizar_a]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("EXEC uspGetMunicipiosCanalizacion FLD[Canalizar_a]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3897, Attribute:269152, Operation:Field, Event:None

//BusinessRuleId:3898, Attribute:269153, Operation:Field, Event:None
$("form#CreateCanalizacion").on('change', '#Municipio', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Unidad' + rowIndex).val();   $('#' + nameOfTable + 'Unidad' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Unidad' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Unidad' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("exec uspGetUnidadesCanalizacion FLD[Municipio], FLD[Canalizar_a]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Unidad' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("exec uspGetUnidadesCanalizacion FLD[Municipio], FLD[Canalizar_a]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Unidad' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Unidad' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3898, Attribute:269153, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});

function EjecutarValidacionesAlComienzo() {






    //BusinessRuleId:3553, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divClave').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        $('#divExpediente_MP').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
        $('#divExpediente_AT').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_AT' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_AT' + rowIndex));


    }
    //BusinessRuleId:3553, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3553, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divClave').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        $('#divExpediente_MP').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
        $('#divExpediente_AT').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_AT' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_AT' + rowIndex));


    }
    //BusinessRuleId:3553, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3553, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divClave').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        $('#divExpediente_MP').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
        $('#divExpediente_AT').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_AT' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_AT' + rowIndex));


    }
    //BusinessRuleId:3553, Attribute:0, Operation:Object, Event:SCREENOPENING



    //BusinessRuleId:3554, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex), EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex), EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Usuario_que_Canaliza' + rowIndex), EvaluaQuery("SELECT NAME FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:3554, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:3555, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        DisabledControl($("#" + nameOfTable + "Usuario_que_Canaliza" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Canaliza' + rowIndex)); }


    }
    //BusinessRuleId:3555, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3555, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Usuario_que_Canaliza" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Canaliza' + rowIndex)); }


    }
    //BusinessRuleId:3555, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3555, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        DisabledControl($("#" + nameOfTable + "Usuario_que_Canaliza" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Canaliza' + rowIndex)); }


    }
    //BusinessRuleId:3555, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3556, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = 25", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = 25", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3556, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3556, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = 25", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = 25", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3556, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3556, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = 25", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = 25", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3556, Attribute:0, Operation:Object, Event:SCREENOPENING



    //BusinessRuleId:3559, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        var valor = $('#' + nameOfTable + 'Unidad' + rowIndex).val();
        $('#' + nameOfTable + 'Unidad' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Unidad' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Unidad' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM UNIDAD WHERE CLAVE_DE_MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Unidad' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM UNIDAD WHERE CLAVE_DE_MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Unidad' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Unidad' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3559, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3559, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        var valor = $('#' + nameOfTable + 'Unidad' + rowIndex).val();
        $('#' + nameOfTable + 'Unidad' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Unidad' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Unidad' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM UNIDAD WHERE CLAVE_DE_MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Unidad' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM UNIDAD WHERE CLAVE_DE_MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Unidad' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Unidad' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3559, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3559, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        var valor = $('#' + nameOfTable + 'Unidad' + rowIndex).val();
        $('#' + nameOfTable + 'Unidad' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Unidad' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Unidad' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM UNIDAD WHERE CLAVE_DE_MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Unidad' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM UNIDAD WHERE CLAVE_DE_MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Unidad' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Unidad' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3559, Attribute:0, Operation:Object, Event:SCREENOPENING





    //BusinessRuleId:3558, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $("a[href='#tabResolucion']").css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Resolucion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nueva_Relacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'ResolucionId' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Resolucion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Detalle_de_la_Resolucion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:3558, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3560, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'ResolucionId' + rowIndex), nameOfTable, rowIndex) != TryParseInt('NULL', 'NULL') && GetValueByControlType($('#' + nameOfTable + 'ResolucionId' + rowIndex), nameOfTable, rowIndex) > TryParseInt('0', '0')) {
            $("a[href='#tabResolucion']").css('display', 'block');
            DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Resolucion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hubo_modificacion_en_la_relacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hubo_modificacion_en_la_relacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nueva_Relacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nueva_Relacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "ResolucionId" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'ResolucionId' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Resolucion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Detalle_de_la_Resolucion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Detalle_de_la_Resolucion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:3560, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3562, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hubo_modificacion_en_la_relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hubo_modificacion_en_la_relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nueva_Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nueva_Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "ResolucionId" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'ResolucionId' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Detalle_de_la_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Detalle_de_la_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}

}
//BusinessRuleId:3562, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3562, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hubo_modificacion_en_la_relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hubo_modificacion_en_la_relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nueva_Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nueva_Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "ResolucionId" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'ResolucionId' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Detalle_de_la_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Detalle_de_la_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}

}
//BusinessRuleId:3562, Attribute:0, Operation:Object, Event:SCREENOPENING















//BusinessRuleId:3566, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val();   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3566, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3566, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val();   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3566, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3566, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val();   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3566, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3565, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { var valor = $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val();   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3565, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3565, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { var valor = $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val();   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3565, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3565, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { var valor = $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val();   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM Detalle_de_Relaciones where Expediente_MP = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3565, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:3564, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { var valor = $('#' + nameOfTable + 'Canalizar_a' + rowIndex).val();   $('#' + nameOfTable + 'Canalizar_a' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Canalizar_a' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Canalizar_a' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Estatus_Orientador WHERE Clave IN (2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Canalizar_a' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Estatus_Orientador WHERE Clave IN (2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Canalizar_a' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Canalizar_a' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3564, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3564, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { var valor = $('#' + nameOfTable + 'Canalizar_a' + rowIndex).val();   $('#' + nameOfTable + 'Canalizar_a' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Canalizar_a' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Canalizar_a' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Estatus_Orientador WHERE Clave IN (2)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Canalizar_a' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Estatus_Orientador WHERE Clave IN (2)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Canalizar_a' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Canalizar_a' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3564, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3586, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Canalizar_a' + rowIndex).val();   $('#' + nameOfTable + 'Canalizar_a' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Canalizar_a' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Canalizar_a' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Estatus_Orientador WHERE Clave IN (2,6)	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Canalizar_a' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Estatus_Orientador WHERE Clave IN (2,6)	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Canalizar_a' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Canalizar_a' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3586, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3586, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Canalizar_a' + rowIndex).val();   $('#' + nameOfTable + 'Canalizar_a' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Canalizar_a' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Canalizar_a' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Estatus_Orientador WHERE Clave IN (2,6)	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Canalizar_a' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Estatus_Orientador WHERE Clave IN (2,6)	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Canalizar_a' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Canalizar_a' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:3586, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:3882, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'ResolucionId' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion_a_Canalizar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex));}} else {}

}
//BusinessRuleId:3882, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3882, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'ResolucionId' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));} DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion_a_Canalizar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex));}} else {}

}
//BusinessRuleId:3882, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3895, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Canaliza' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion_a_Canalizar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex));}

}
//BusinessRuleId:3895, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3896, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { AsignarValor($('#' + nameOfTable + 'Canalizar_a' + rowIndex),'2'); DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}} else {}

}
//BusinessRuleId:3896, Attribute:0, Operation:Object, Event:SCREENOPENING



//BusinessRuleId:4107, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select Canalizado from Canalizacion where Clave = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Canaliza' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion_a_Canalizar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hubo_modificacion_en_la_relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hubo_modificacion_en_la_relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nueva_Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nueva_Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "ResolucionId" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'ResolucionId' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Detalle_de_la_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Detalle_de_la_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Diligencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ver_Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ver_Documento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_AT' + rowIndex));}} else {}

}
//BusinessRuleId:4107, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4382, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('107', '107')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Canaliza' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion_a_Canalizar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hubo_modificacion_en_la_relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hubo_modificacion_en_la_relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nueva_Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nueva_Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "ResolucionId" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'ResolucionId' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Detalle_de_la_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Detalle_de_la_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Diligencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ver_Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ver_Documento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_AT' + rowIndex));}} else {}


}
//BusinessRuleId:4382, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:4720, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if(  EvaluaOperatorIn (EvaluaQuery("select Tipo_de_Denuncia from Modulo_Atencion_Inicial where clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable), TryParseInt('4,5,6', '4,5,6') ) ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Canaliza' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion_a_Canalizar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hubo_modificacion_en_la_relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hubo_modificacion_en_la_relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nueva_Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nueva_Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "ResolucionId" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'ResolucionId' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Detalle_de_la_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Detalle_de_la_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Diligencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ver_Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ver_Documento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_AT' + rowIndex));} alert(DecodifyText('Este tipo de atención no permite canalización.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4720, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4720, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if(  EvaluaOperatorIn (EvaluaQuery("select Tipo_de_Denuncia from Modulo_Atencion_Inicial where clave = GLOBAL[SpartanOperationId]",rowIndex, nameOfTable), TryParseInt('4,5,6', '4,5,6') ) ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Canaliza' + rowIndex));}DisabledControl($("#" + nameOfTable + "Relacion_a_Canalizar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Relacion_a_Canalizar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizar_a' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Unidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hubo_modificacion_en_la_relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hubo_modificacion_en_la_relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nueva_Relacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nueva_Relacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "ResolucionId" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'ResolucionId' + rowIndex));}DisabledControl($("#" + nameOfTable + "Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Detalle_de_la_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Detalle_de_la_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Diligencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Diligencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ver_Documento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ver_Documento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_AT" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_AT' + rowIndex));} alert(DecodifyText('Este tipo de atención no permite canalización.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4720, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}

function EjecutarValidacionesAntesDeGuardar() {
    var result = true;
    






    
    



    
    

//BusinessRuleId:4132, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("select count(*) from detalle_resumen_denuncia"
+" where modulo_atencion_inicial = GLOBAL[SpartanOperationId]"
+" and Generar = 1"
+" ",rowIndex, nameOfTable)!=TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Canalizar_a' + rowIndex),nameOfTable,rowIndex)==TryParseInt('6', '6') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { alert(DecodifyText('Para canalizar a ministerio público debe generar primero la denuncia.', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:4132, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4132, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("select count(*) from detalle_resumen_denuncia"
+" where modulo_atencion_inicial = GLOBAL[SpartanOperationId]"
+" and Generar = 1"
+" ",rowIndex, nameOfTable)!=TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Canalizar_a' + rowIndex),nameOfTable,rowIndex)==TryParseInt('6', '6') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { alert(DecodifyText('Para canalizar a ministerio público debe generar primero la denuncia.', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:4132, Attribute:2, Operation:Object, Event:BEFORESAVING









//BusinessRuleId:4138, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("select count(*) from detalle_resumen_denuncia where modulo_atencion_inicial = GLOBAL[SpartanOperationId] and Generar = 2",rowIndex, nameOfTable)!=TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Canalizar_a' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { alert(DecodifyText('Para canalizar a mecanismos alternos primero debe elevar la denuncia a carpeta de investigación', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:4138, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4138, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("select count(*) from detalle_resumen_denuncia where modulo_atencion_inicial = GLOBAL[SpartanOperationId] and Generar = 2",rowIndex, nameOfTable)!=TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Canalizar_a' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { alert(DecodifyText('Para canalizar a mecanismos alternos primero debe elevar la denuncia a carpeta de investigación', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:4138, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4139, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("select count(*) from detalle_resumen_denuncia"
+" where modulo_atencion_inicial = GLOBAL[SpartanOperationId] and Generar = 2",rowIndex, nameOfTable)!=TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Canalizar_a' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { alert(DecodifyText('Para canalizar a mecanismos alternos primero debe elevar la denuncia a carpeta de investigación', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:4139, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4139, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("select count(*) from detalle_resumen_denuncia"
+" where modulo_atencion_inicial = GLOBAL[SpartanOperationId] and Generar = 2",rowIndex, nameOfTable)!=TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Canalizar_a' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { alert(DecodifyText('Para canalizar a mecanismos alternos primero debe elevar la denuncia a carpeta de investigación', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:4139, Attribute:2, Operation:Object, Event:BEFORESAVING



//BusinessRuleId:4518, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("SELECT COUNT(*) FROM Resolucion_AT where Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId] and Relacion = FLD[Relacion_a_Canalizar]",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText('La relación seleccionada ya fue resuelta, solo se pueden canalizar relaciones que aún no han sido resueltas, favor de revisar', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:4518, Attribute:2, Operation:Object, Event:BEFORESAVING










//BusinessRuleId:4725, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery(""
+" select count(*) from Canalizacion where Expediente_AT = GLOBAL[SpartanOperationId] and Relacion_a_Canalizar = FLD[Relacion_a_Canalizar] and ResolucionId is null",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText('No se puede canalizar nuevamente hasta que no haya una respuesta.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4725, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4725, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery(""
+" select count(*) from Canalizacion where Expediente_AT = GLOBAL[SpartanOperationId] and Relacion_a_Canalizar = FLD[Relacion_a_Canalizar] and ResolucionId is null",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText('No se puede canalizar nuevamente hasta que no haya una respuesta.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4725, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}

function EjecutarValidacionesDespuesDeGuardar() {
    //BusinessRuleId:3567, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Canalizacion set Expediente_MP = GLOBAL[SpartanOperationId] where Clave = GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3567, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3568, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { EvaluaQuery(" update Canalizacion set Expediente_AT = GLOBAL[SpartanOperationId] where Clave = GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3568, Attribute:2, Operation:Object, Event:AFTERSAVING



//BusinessRuleId:3570, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') && GetValueByControlType($('#' + nameOfTable + 'Canalizar_a' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { EvaluaQuery("exec uspCanalizarAT_a_MASC GLOBAL[SpartanOperationId], FLD[Relacion_a_Canalizar]", rowIndex, nameOfTable);} else {}

}
//BusinessRuleId:3570, Attribute:2, Operation:Object, Event:AFTERSAVING





//BusinessRuleId:4143, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') && GetValueByControlType($('#' + nameOfTable + 'Canalizar_a' + rowIndex),nameOfTable,rowIndex)==TryParseInt('6', '6') ) { EvaluaQuery(" EXEC usp_GeneraResolucionAT_AlCanalizar GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:4143, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Diligencias_Canalizacion//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Diligencias_Canalizacion//
}

function EjecutarValidacionesAlEliminarMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Diligencias_Canalizacion//
    return result;
}

function EjecutarValidacionesNewRowMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Diligencias_Canalizacion//
    return result;
}

function EjecutarValidacionesEditRowMRDetalle_Diligencias_Canalizacion(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Diligencias_Canalizacion//
    return result;
}