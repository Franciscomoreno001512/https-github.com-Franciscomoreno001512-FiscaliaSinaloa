var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function() {

    //COD-MANI INI OCULTAR BOTONES
    $('#Solicitud_de_Denuncia_CiudadanaGuardarYNuevo').css('display', 'none');
    $('#Solicitud_de_Denuncia_CiudadanaGuardarYCopia').css('display', 'none');
    if (EvaluaQuery("SELECT GLOBAL[USERROLEID]") == 110 || EvaluaQuery("SELECT GLOBAL[USERROLEID]") == 108) {
        $("#ConfigureSave").addClass("hidden");
        $("#Solicitud_de_Denuncia_CiudadanaCancelar").addClass("hidden");
        $("#Solicitud_de_Denuncia_CiudadanaGuardar").addClass("hidden");
    }

    if (EvaluaQuery("SELECT GLOBAL[USERROLEID]") == 110) {
        $("#side-menu").addClass("hidden");
        $("#logoutForm").addClass("hidden");

    }



    //COD-MANI END OCULTAR BOTONES







    //BusinessRuleId:3278, Attribute:269219, Operation:Field, Event:None
    $("form#CreateSolicitud_de_Denuncia_Ciudadana").on('change', '#Estatus_de_Solicitud', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4')) {
            $('#divUnidad_canaliza').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
        } else {
            $('#divUnidad_canaliza').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
        }
    });


    //BusinessRuleId:3278, Attribute:269219, Operation:Field, Event:None



    //BusinessRuleId:4691, Attribute:273376, Operation:Field, Event:None
    $("form#CreateSolicitud_de_Denuncia_Ciudadana").on('change', '#Tipo_de_Resolucion', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
            $('#divUnidad_canaliza').css('display', 'block');
            $('#divRegion').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex));
            DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex)); }
        } else {
            $('#divUnidad_canaliza').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
            $('#divRegion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex));
            DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex)); }
        }
    });


    //BusinessRuleId:4691, Attribute:273376, Operation:Field, Event:None

    





    //BusinessRuleId:4779, Attribute:273377, Operation:Field, Event:None
    $("form#CreateSolicitud_de_Denuncia_Ciudadana").on('change', '#Region', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Region' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
            var valor = $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).val();
            $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).empty();
            if (!$('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).hasClass('AutoComplete')) {
                $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Unidad WHERE CLAVE_DE_REGION = FLD[Region] AND VIGENCIA = 1 AND ESPECIALIDAD NOT IN (25,26)", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).append($("<option />").val(index).text(value)); });
            } else {
                var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Unidad WHERE CLAVE_DE_REGION = FLD[Region] AND VIGENCIA = 1 AND ESPECIALIDAD NOT IN (25,26)", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).select2({ data: selectData })
            }
            $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).val(valor).trigger('change');
        } else {}
    });


    //BusinessRuleId:4779, Attribute:273377, Operation:Field, Event:None







    //BusinessRuleId:4791, Attribute:273376, Operation:Field, Event:None
    $("form#CreateSolicitud_de_Denuncia_Ciudadana").on('change', '#Tipo_de_Resolucion', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) { AsignarValor($('#' + nameOfTable + 'Contestacion' + rowIndex), ' '); } else {}
    });


    //BusinessRuleId:4791, Attribute:273376, Operation:Field, Event:None



    //BusinessRuleId:4792, Attribute:273376, Operation:Field, Event:None
    $("form#CreateSolicitud_de_Denuncia_Ciudadana").on('change', '#Tipo_de_Resolucion', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex), nameOfTable, rowIndex) != TryParseInt('3', '3')) {
            AsignarValor($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex), ' ');
            AsignarValor($('#' + nameOfTable + 'Region' + rowIndex), ' ');
        } else {}
    });


    //BusinessRuleId:4792, Attribute:273376, Operation:Field, Event:None

    //BusinessRuleId:4692, Attribute:273376, Operation:Field, Event:None
$("form#CreateSolicitud_de_Denuncia_Ciudadana").on('change', '#Tipo_de_Resolucion', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divContestacion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Contestacion" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex));}} else { $('#divContestacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex));}}
});

//BusinessRuleId:4692, Attribute:273376, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});

function EjecutarValidacionesAlComienzo() {




































































































































    //BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }


    }
    //BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }


    }
    //BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }


    }
    //BusinessRuleId:3257, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3263, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        AsignarValor($('#' + nameOfTable + 'Canalizar_a' + rowIndex), '3');


    }
    //BusinessRuleId:3263, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divCanalizar_a').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Canalizar_a' + rowIndex));


    }
    //BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divCanalizar_a').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Canalizar_a' + rowIndex));


    }
    //BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divCanalizar_a').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Canalizar_a' + rowIndex));


    }
    //BusinessRuleId:3264, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('108', '108') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110')) {
            DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Canalizar_a' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Motivo" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Motivo' + rowIndex)); }
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divUsuario_que_Registra').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
            $('#divContrasena').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex));
        } else {}


    }
    //BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('108', '108') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110')) {
            DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Canalizar_a' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Motivo" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Motivo' + rowIndex)); }
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divUsuario_que_Registra').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
            $('#divContrasena').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex));
        } else {}


    }
    //BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('108', '108') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110')) {
            DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Canalizar_a" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Canalizar_a' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Motivo" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Motivo' + rowIndex)); }
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divUsuario_que_Registra').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
            $('#divContrasena').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex));
        } else {}


    }
    //BusinessRuleId:3266, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        CreateSessionVar('Unidad', EvaluaQuery(" SELECT DESCRIPCION FROM UNIDAD WHERE CLAVE = FLD[Unidad]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        CreateSessionVar('Unidad', EvaluaQuery(" SELECT DESCRIPCION FROM UNIDAD WHERE CLAVE = FLD[Unidad]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        CreateSessionVar('Unidad', EvaluaQuery(" SELECT DESCRIPCION FROM UNIDAD WHERE CLAVE = FLD[Unidad]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:3268, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4')) {
            $('#divUnidad_canaliza').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
        } else {
            $('#divUnidad_canaliza').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
        }


    }
    //BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4')) {
            $('#divUnidad_canaliza').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
        } else {
            $('#divUnidad_canaliza').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
        }


    }
    //BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4')) {
            $('#divUnidad_canaliza').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
        } else {
            $('#divUnidad_canaliza').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
        }


    }
    //BusinessRuleId:3279, Attribute:0, Operation:Object, Event:SCREENOPENING























































































































































































    //BusinessRuleId:4638, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("Select GLOBAL[Phase]", rowIndex, nameOfTable) == TryParseInt('1', '1')) {
            $("a[href='#tabAsignar_Responsable_de_Atencion']").css('display', 'none');
            $("a[href='#tabAtencion']").css('display', 'none');
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:4638, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4638, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("Select GLOBAL[Phase]", rowIndex, nameOfTable) == TryParseInt('1', '1')) {
            $("a[href='#tabAsignar_Responsable_de_Atencion']").css('display', 'none');
            $("a[href='#tabAtencion']").css('display', 'none');
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:4638, Attribute:0, Operation:Object, Event:SCREENOPENING









    //BusinessRuleId:4649, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("Select GLOBAL[Phase]", rowIndex, nameOfTable) == TryParseInt('2', '2')) {
            $("a[href='#tabAtencion']").css('display', 'none');
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:4649, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4649, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("Select GLOBAL[Phase]", rowIndex, nameOfTable) == TryParseInt('2', '2')) {
            $("a[href='#tabAtencion']").css('display', 'none');
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:4649, Attribute:0, Operation:Object, Event:SCREENOPENING











































































    //BusinessRuleId:4651, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("Select GLOBAL[Phase]", rowIndex, nameOfTable) == TryParseInt('3', '3')) {
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Responsable_Asignado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Responsable_Asignado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Observaciones_responsable" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones_responsable' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:4651, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4651, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("Select GLOBAL[Phase]", rowIndex, nameOfTable) == TryParseInt('3', '3')) {
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Contrasena" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Responsable_Asignado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Responsable_Asignado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Observaciones_responsable" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones_responsable' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:4651, Attribute:0, Operation:Object, Event:SCREENOPENING



    //BusinessRuleId:4677, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        AsignarValor($('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex), EvaluaQuery("select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Hora_de_Revision' + rowIndex), EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable));
        //AsignarValor($('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex), EvaluaQuery("select name from Spartan_User where Id_User =  GLOBAL[USERROLEID]  ", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex), EvaluaQuery("select name from Spartan_User where Id_User =  GLOBAL[USERID]  ", rowIndex, nameOfTable));


    }
    //BusinessRuleId:4677, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4686, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('2', '2')) {
            AsignarValor($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex), EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable));
            AsignarValor($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex), EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));
            AsignarValor($('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex), EvaluaQuery("SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));
        } else {}


    }
    //BusinessRuleId:4686, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4688, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
            AsignarValor($('#' + nameOfTable + 'Fecha_de_Atencion' + rowIndex), EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable));
            AsignarValor($('#' + nameOfTable + 'Hora_de_Atencion' + rowIndex), EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable));
            AsignarValor($('#' + nameOfTable + 'Usuario_que_Atiende' + rowIndex), EvaluaQuery("SELECT name FROM Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));
        } else {}


    }
    //BusinessRuleId:4688, Attribute:0, Operation:Object, Event:SCREENOPENING





    

    

    //BusinessRuleId:4689, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
            $('#divUnidad_canaliza').css('display', 'block');
            $('#divRegion').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex));
            DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex)); }
        } else {
            $('#divUnidad_canaliza').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
            $('#divRegion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex));
            DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex)); }
        }


    }
    //BusinessRuleId:4689, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4689, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
            $('#divUnidad_canaliza').css('display', 'block');
            $('#divRegion').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex));
            DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex)); }
        } else {
            $('#divUnidad_canaliza').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));
            $('#divRegion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex));
            DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_canaliza' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Region' + rowIndex)); }
        }


    }
    //BusinessRuleId:4689, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:4676, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones_resolucion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones_responsable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones_atencion' + rowIndex));
        DisabledControl($("#" + nameOfTable + "Fecha_de_Revision" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Revision' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Hora_de_Revision" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Revision' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Usuario_que_Revisa" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Fecha_de_Asignacion" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Hora_de_Asignacion" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Usuario_que_Asigna" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Fecha_de_Atencion" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Atencion' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Hora_de_Atencion" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Atencion' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Usuario_que_Atiende" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Atiende' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Estatus_de_Solicitud" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex)); }
        $('#divContrasena').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Contrasena' + rowIndex));


    }
    //BusinessRuleId:4676, Attribute:0, Operation:Object, Event:SCREENOPENING























































































































    //BusinessRuleId:4780, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '1'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4780, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4780, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '1'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4780, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4780, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '1'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4780, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4782, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '2'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4782, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4782, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '2'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4782, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4782, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '2'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4782, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4784, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '3'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4784, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4784, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '3'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4784, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4784, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '3'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4784, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4786, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '4'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4786, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4786, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '4'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4786, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4786, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '4'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4786, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4788, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '5'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4788, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4788, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '5'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4788, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4788, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("Select 'GLOBAL[Phase]'", rowIndex, nameOfTable) == EvaluaQuery("Select '5'", rowIndex, nameOfTable)) {} else {}


    }
    //BusinessRuleId:4788, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4790, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        var valor = $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).val();
        $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Unidad WHERE CLAVE_DE_REGION = FLD[Region] AND VIGENCIA = 1 AND ESPECIALIDAD NOT IN (25,26)", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Unidad WHERE CLAVE_DE_REGION = FLD[Region] AND VIGENCIA = 1 AND ESPECIALIDAD NOT IN (25,26)", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:4790, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4796, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        CreateSessionVar('RoleUsuario', EvaluaQuery("SELECT GLOBAL[USERROLEID]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:4796, Attribute:0, Operation:Object, Event:SCREENOPENING











    //BusinessRuleId:4767, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('109', '109') &&
            GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            SetNotRequiredToControl($('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Atencion_Realizada' + rowIndex));
            $("a[href='#tabAsignar_Responsable_de_Atencion']").css('display', 'none');
            $("a[href='#tabAtencion']").css('display', 'none');
        } else {}


    }
    //BusinessRuleId:4767, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4767, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('109', '109') && GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            SetNotRequiredToControl($('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Atencion_Realizada' + rowIndex));
            $("a[href='#tabAsignar_Responsable_de_Atencion']").css('display', 'none');
            $("a[href='#tabAtencion']").css('display', 'none');
        } else {}


    }
    //BusinessRuleId:4767, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4768, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (TryParseInt('109', '109') == EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) &&
            GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) { AsignarValor($('#' + nameOfTable + 'Usuario_que_Revisa' + rowIndex), EvaluaQuery(" SELECT NAME FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID]", rowIndex, nameOfTable)); } else {}


    }
    //BusinessRuleId:4768, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:4799, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divMotivo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Motivo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Motivo' + rowIndex));


    }
    //BusinessRuleId:4799, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4799, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divMotivo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Motivo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Motivo' + rowIndex));


    }
    //BusinessRuleId:4799, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4799, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divMotivo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Motivo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Motivo' + rowIndex));


    }
    //BusinessRuleId:4799, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4801, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('5', '5') ) { var valor = $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Tipo_Resolucion_Portal_Ciudadano WITH(nolock) where Clave not in (3)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Tipo_Resolucion_Portal_Ciudadano WITH(nolock) where Clave not in (3)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).val(valor).trigger('change');} else { var valor = $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).val();   $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion from Tipo_Resolucion_Portal_Ciudadano WITH(nolock) where Clave not in (4)", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion from Tipo_Resolucion_Portal_Ciudadano WITH(nolock) where Clave not in (4)", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex).val(valor).trigger('change');}


}
//BusinessRuleId:4801, Attribute:0, Operation:Object, Event:SCREENOPENING













//BusinessRuleId:4822, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));}DisabledControl($("#" + nameOfTable + "Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_resolucion' + rowIndex));} $("a[href='#tabAtencion']").css('display', 'none');  SetNotRequiredToControl( $('#' + nameOfTable + 'Atencion_Realizada' + rowIndex));} else {}


}
//BusinessRuleId:4822, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4841, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { DisabledControl($("#" + nameOfTable + "Unidad_canaliza" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_canaliza' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Region' + rowIndex));}DisabledControl($("#" + nameOfTable + "Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_resolucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_resolucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Responsable_Asignado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones_responsable" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_responsable' + rowIndex));}} else {}

}
//BusinessRuleId:4841, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4690, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divContestacion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex));} else { $('#divContestacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex));}}

}
//BusinessRuleId:4690, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4690, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { $('#divContestacion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex));} else { $('#divContestacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex)); DisabledControl($("#" + nameOfTable + "Contestacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Contestacion' + rowIndex));}}

}
//BusinessRuleId:4690, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4803, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).val();   $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Id_User, Name from Spartan_User where Role in (4,9) and unidad = FLD[Unidad_canaliza]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Id_User, Name from Spartan_User where Role in (4,9) and unidad = FLD[Unidad_canaliza]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex).val(valor).trigger('change');} else {}

}
//BusinessRuleId:4803, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:4859, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt('109', '109')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $("a[href='#tabAsignar_Responsable_de_Atencion']").css('display', 'none'); $("a[href='#tabAtencion']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Atencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Atencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Atiende' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Atencion_Realizada' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_atencion' + rowIndex));} else {}

}
//BusinessRuleId:4859, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4859, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('109', '109')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $("a[href='#tabAsignar_Responsable_de_Atencion']").css('display', 'none'); $("a[href='#tabAtencion']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Atencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Atencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Atiende' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Atencion_Realizada' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_atencion' + rowIndex));} else {}

}
//BusinessRuleId:4859, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4859, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt('109', '109')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { $("a[href='#tabAsignar_Responsable_de_Atencion']").css('display', 'none'); $("a[href='#tabAtencion']").css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Asigna' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Responsable_Asignado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_responsable' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Atencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Atencion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Atiende' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Atencion_Realizada' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones_atencion' + rowIndex));} else {}

}
//BusinessRuleId:4859, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}

function EjecutarValidacionesAntesDeGuardar() {
    var result = true;


    //BusinessRuleId:4693, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1') && EvaluaQuery("SELECT GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('109', '109') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) { AsignarValor($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), '2'); } else {}


    }
    //BusinessRuleId:4693, Attribute:2, Operation:Object, Event:BEFORESAVING



    

    

    //BusinessRuleId:4696, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1') && EvaluaQuery("SELECT GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('109', '109') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('2', '2')) { AsignarValor($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), '4'); } else {}


    }
    //BusinessRuleId:4696, Attribute:2, Operation:Object, Event:BEFORESAVING

    

    //BusinessRuleId:4687, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1') && TryParseInt('109', '109') == EvaluaQuery("SELECT GLOBAL[USERROLEID]", rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) { AsignarValor($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), '5'); } else {}


    }
    //BusinessRuleId:4687, Attribute:2, Operation:Object, Event:BEFORESAVING

    //BusinessRuleId:4694, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') &&  EvaluaOperatorIn (EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable), TryParseInt('6,17', '6,17') ) ) { AsignarValor($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),'3');} else {}

}
//BusinessRuleId:4694, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4695, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') &&  EvaluaOperatorIn (GetValueByControlType($('#' + nameOfTable + 'Atencion_Realizada' + rowIndex),nameOfTable,rowIndex), TryParseInt('1,2,4', '1,2,4') ) ) { AsignarValor($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),'4');} else {}

}
//BusinessRuleId:4695, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4697, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Atencion_Realizada' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { AsignarValor($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),'5');} else {}

}
//BusinessRuleId:4697, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}

function EjecutarValidacionesDespuesDeGuardar() {
    

    











    //BusinessRuleId:3269, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('2', '2')) {
            SendEmailQuery('Aprobación de pre-denuncia en Portal Ciudadano.',
                EvaluaQuery("SELECT EMAIL FROM SPARTAN_USER WHERE ID_USER = FLD[Usuario_que_Registra]"),
                "<!doctype html> <html> <head> <meta charset='utf-8'> <!-- utf-8 works for most cases --> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <!-- Forcing initial-scale shouldn't be necessary --> <meta http-equiv='X-UA-Compatible' content='IE=edge'> <!-- Use the latest (edge) version of IE rendering engine --> <title>EmailTemplate-Fluid</title> <!-- The title tag shows in email notifications, like Android 4.4. -->​<!-- Please use an inliner tool to convert all CSS to inline as inpage or external CSS is removed by email clients --> <!-- important in CSS is used to prevent the styles of currently inline CSS from overriding the ones mentioned in media queries when corresponding screen sizes are encountered -->​<!-- CSS Reset --> <style type='text/css'> /* What it does: Remove spaces around the email design added by some email clients. */ /* Beware: It can remove the padding / margin and add a background color to the compose a reply window. */ html, body { margin: 0 !important; padding: 0 !important; height: 100% !important; width: 100% !important; } /* What it does: Stops email clients resizing small text. */ * { -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; } /* What it does: Forces Outlook.com to display emails full width. */ .ExternalClass { width: 100%; } /* What is does: Centers email on Android 4.4 */ div[style*='margin: 16px 0'] { margin: 0 !important; } /* What it does: Stops Outlook from adding extra spacing to tables. */ table, td { mso-table-lspace: 0pt !important; mso-table-rspace: 0pt !important; } /* What it does: Fixes webkit padding issue. Fix for Yahoo mail table alignment bug. Applies table-layout to the first 2 tables then removes for anything nested deeper. */ table { border-spacing: 0 !important; border-collapse: collapse !important; table-layout: fixed !important; margin: 0 auto !important; } table table table { table-layout: auto; } /* What it does: Uses a better rendering method when resizing images in IE. */ img { -ms-interpolation-mode: bicubic; } /* What it does: Overrides styles added when Yahoo's auto-senses a link. */ .yshortcuts a { border-bottom: none !important; } /* What it does: Another work-around for iOS meddling in triggered links. */ a[x-apple-data-detectors] { color: inherit !important; } </style>​<!-- Progressive Enhancements --> <style type='text/css'> /* What it does: Hover styles for buttons */ .button-td, .button-a { transition: all 100ms ease-in; } .button-td:hover, .button-a:hover { color: #000; } </style> </head> <body width='100%' height='100%' bgcolor='#e0e0e0' style='margin: 0;' yahoo='yahoo'> <table cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' bgcolor='#e0e0e0' style='border-collapse:collapse;'> <tr> <td><center style='width: 100%;'> <!-- Visually Hidden Preheader Text : BEGIN --> <div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'> (Optional) This text will appear in the inbox preview, but not the email body. </div> <!-- Visually Hidden Preheader Text : END --> <div style='max-width: 600px;'> <!--[if (gte mso 9)|(IE)]> <table cellspacing='0' cellpadding='0' border='0' align='center'> <tr> <td> <![endif]--> <!-- Email Header : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 600px;'> <tr> <td style='padding: 20px 0; text-align: center'><img src='http://192.168.1.101/MVCfiscaliasinaloa/Images/logo-fiscalia-sinaloa.png' width='108' height='126' alt='alt_text' border='0'></td> </tr> </table> <!-- Email Header : END --> <!-- Email Body : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='100%' style='max-width: 600px;'> <!-- 1 Column Text : BEGIN --> <tr> <td><table cellspacing='0' cellpadding='0' border='0' width='100%'> <tr> <td style='padding: 40px; font-family: sans-serif; font-size: 15px; mso-height-rule: exactly; line-height: 20px; color: #555555;'> <p style='font-size:16px; font-weight: bold; text-align:center'></p>​<p> Su Pre-denuncia con el Folio: FLD[Folio] ha sido registrada, en breve personal de Unidad 'Atención Temprana' atenderá su solicitud </p> </td> </tr> </table></td> </tr> <!-- 1 Column Text : BEGIN -->​</table> <!-- Email Body : END --> <!-- Email Footer : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 680px;'> <tr> <td style='padding: 40px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'><webversion style='color:#aaa; text-decoration:underline; font-weight: bold;'></webversion> <br> <br> <b>Portal Ciudadano</b> <br> Fiscalía General del Estado de Sinaloa<br> <span class='mobile-link--footer'> http://www.fiscaliasinaloa.mx/ </span> <br> <!-- <br> <unsubscribe style='color:#888888; text-decoration:underline;'>unsubscribe</unsubscribe> --> </td> </tr> </table> <!-- Email Footer : END --> <!--[if (gte mso 9)|(IE)]> </td> </tr> </table> <![endif]--> </div> </center></td> </tr> </table> </body> </html>", rowIndex, nameOfTable);
        } else {}


    }
    //BusinessRuleId:3269, Attribute:2, Operation:Object, Event:AFTERSAVING

    

    //BusinessRuleId:3271, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) { SendEmailQuery('Corrección pendiente de pre-denuncia en Portal Ciudadano.', EvaluaQuery("SELECT EMAIL FROM SPARTAN_USER WHERE ID_USER = FLD[Usuario_que_Registra]"), "<!doctype html> <html> <head> <meta charset='utf-8'> <!-- utf-8 works for most cases --> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <!-- Forcing initial-scale shouldn't be necessary --> <meta http-equiv='X-UA-Compatible' content='IE=edge'> <!-- Use the latest (edge) version of IE rendering engine --> <title>EmailTemplate-Fluid</title> <!-- The title tag shows in email notifications, like Android 4.4. -->​<!-- Please use an inliner tool to convert all CSS to inline as inpage or external CSS is removed by email clients --> <!-- important in CSS is used to prevent the styles of currently inline CSS from overriding the ones mentioned in media queries when corresponding screen sizes are encountered -->​<!-- CSS Reset --> <style type='text/css'> /* What it does: Remove spaces around the email design added by some email clients. */ /* Beware: It can remove the padding / margin and add a background color to the compose a reply window. */ html, body { margin: 0 !important; padding: 0 !important; height: 100% !important; width: 100% !important; } /* What it does: Stops email clients resizing small text. */ * { -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; } /* What it does: Forces Outlook.com to display emails full width. */ .ExternalClass { width: 100%; } /* What is does: Centers email on Android 4.4 */ div[style*='margin: 16px 0'] { margin: 0 !important; } /* What it does: Stops Outlook from adding extra spacing to tables. */ table, td { mso-table-lspace: 0pt !important; mso-table-rspace: 0pt !important; } /* What it does: Fixes webkit padding issue. Fix for Yahoo mail table alignment bug. Applies table-layout to the first 2 tables then removes for anything nested deeper. */ table { border-spacing: 0 !important; border-collapse: collapse !important; table-layout: fixed !important; margin: 0 auto !important; } table table table { table-layout: auto; } /* What it does: Uses a better rendering method when resizing images in IE. */ img { -ms-interpolation-mode: bicubic; } /* What it does: Overrides styles added when Yahoo's auto-senses a link. */ .yshortcuts a { border-bottom: none !important; } /* What it does: Another work-around for iOS meddling in triggered links. */ a[x-apple-data-detectors] { color: inherit !important; } </style>​<!-- Progressive Enhancements --> <style type='text/css'> /* What it does: Hover styles for buttons */ .button-td, .button-a { transition: all 100ms ease-in; } .button-td:hover, .button-a:hover { color: #000; } </style> </head> <body width='100%' height='100%' bgcolor='#e0e0e0' style='margin: 0;' yahoo='yahoo'> <table cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' bgcolor='#e0e0e0' style='border-collapse:collapse;'> <tr> <td><center style='width: 100%;'> <!-- Visually Hidden Preheader Text : BEGIN --> <div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'> (Optional) This text will appear in the inbox preview, but not the email body. </div> <!-- Visually Hidden Preheader Text : END --> <div style='max-width: 600px;'> <!--[if (gte mso 9)|(IE)]> <table cellspacing='0' cellpadding='0' border='0' align='center'> <tr> <td> <![endif]--> <!-- Email Header : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 600px;'> <tr> <td style='padding: 20px 0; text-align: center'><img src='http://192.168.1.101/MVCfiscaliasinaloa/Images/logo-fiscalia-sinaloa.png' width='108' height='126' alt='alt_text' border='0'></td> </tr> </table> <!-- Email Header : END --> <!-- Email Body : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='100%' style='max-width: 600px;'> <!-- 1 Column Text : BEGIN --> <tr> <td><table cellspacing='0' cellpadding='0' border='0' width='100%'> <tr> <td style='padding: 40px; font-family: sans-serif; font-size: 15px; mso-height-rule: exactly; line-height: 20px; color: #555555;'> <p style='font-size:16px; font-weight: bold; text-align:center'> Su pre-denuncia debe ser corregida. </p>​<p> Es necesario se acerque al módulo de atención o marcar a los teléfonos de atención ciudadana </p> </td> </tr> </table></td> </tr> <!-- 1 Column Text : BEGIN -->​</table> <!-- Email Body : END --> <!-- Email Footer : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 680px;'> <tr> <td style='padding: 40px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'><webversion style='color:#aaa; text-decoration:underline; font-weight: bold;'></webversion> <br> <br> <b>Portal Ciudadano</b> <br> Fiscalía General del Estado de Sinaloa<br> <span class='mobile-link--footer'> http://www.fiscaliasinaloa.mx/ </span> <br> <!-- <br> <unsubscribe style='color:#888888; text-decoration:underline;'>unsubscribe</unsubscribe> --> </td> </tr> </table> <!-- Email Footer : END --> <!--[if (gte mso 9)|(IE)]> </td> </tr> </table> <![endif]--> </div> </center></td> </tr> </table> </body> </html>", rowIndex, nameOfTable); } else {}


    }
    //BusinessRuleId:3271, Attribute:2, Operation:Object, Event:AFTERSAVING

















    //BusinessRuleId:4794, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'Update') {
        if (TryParseInt('109', '109') == EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) &&
            GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1') &&
            GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            debugger;
            EvaluaQuery("EXEC sp_ActRechazoContestacionCiudadano FLDD[lblClave]", rowIndex, nameOfTable);
        } else {}


    }
    //BusinessRuleId:4794, Attribute:2, Operation:Object, Event:AFTERSAVING

    

    





//BusinessRuleId:3270, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Estatus_de_Solicitud' + rowIndex),nameOfTable,rowIndex)==TryParseInt('3', '3') ) { SendEmailQuery('Rechazo de pre-denuncia en Portal Ciudadano.', EvaluaQuery("SELECT EMAIL FROM SPARTAN_USER WHERE ID_USER = FLD[Usuario_que_Registra]"), "<!doctype html> <html> <head> <meta charset='utf-8'> <!-- utf-8 works for most cases --> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <!-- Forcing initial-scale shouldn't be necessary --> <meta http-equiv='X-UA-Compatible' content='IE=edge'> <!-- Use the latest (edge) version of IE rendering engine --> <title>EmailTemplate-Fluid</title> <!-- The title tag shows in email notifications, like Android 4.4. -->​<!-- Please use an inliner tool to convert all CSS to inline as inpage or external CSS is removed by email clients --> <!-- important in CSS is used to prevent the styles of currently inline CSS from overriding the ones mentioned in media queries when corresponding screen sizes are encountered -->​<!-- CSS Reset --> <style type='text/css'> /* What it does: Remove spaces around the email design added by some email clients. */ /* Beware: It can remove the padding / margin and add a background color to the compose a reply window. */ html, body { margin: 0 !important; padding: 0 !important; height: 100% !important; width: 100% !important; } /* What it does: Stops email clients resizing small text. */ * { -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; } /* What it does: Forces Outlook.com to display emails full width. */ .ExternalClass { width: 100%; } /* What is does: Centers email on Android 4.4 */ div[style*='margin: 16px 0'] { margin: 0 !important; } /* What it does: Stops Outlook from adding extra spacing to tables. */ table, td { mso-table-lspace: 0pt !important; mso-table-rspace: 0pt !important; } /* What it does: Fixes webkit padding issue. Fix for Yahoo mail table alignment bug. Applies table-layout to the first 2 tables then removes for anything nested deeper. */ table { border-spacing: 0 !important; border-collapse: collapse !important; table-layout: fixed !important; margin: 0 auto !important; } table table table { table-layout: auto; } /* What it does: Uses a better rendering method when resizing images in IE. */ img { -ms-interpolation-mode: bicubic; } /* What it does: Overrides styles added when Yahoo's auto-senses a link. */ .yshortcuts a { border-bottom: none !important; } /* What it does: Another work-around for iOS meddling in triggered links. */ a[x-apple-data-detectors] { color: inherit !important; } </style>​<!-- Progressive Enhancements --> <style type='text/css'> /* What it does: Hover styles for buttons */ .button-td, .button-a { transition: all 100ms ease-in; } .button-td:hover, .button-a:hover { color: #000; } </style> </head> <body width='100%' height='100%' bgcolor='#e0e0e0' style='margin: 0;' yahoo='yahoo'> <table cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' bgcolor='#e0e0e0' style='border-collapse:collapse;'> <tr> <td><center style='width: 100%;'> <!-- Visually Hidden Preheader Text : BEGIN --> <div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'> (Optional) This text will appear in the inbox preview, but not the email body. </div> <!-- Visually Hidden Preheader Text : END --> <div style='max-width: 600px;'> <!--[if (gte mso 9)|(IE)]> <table cellspacing='0' cellpadding='0' border='0' align='center'> <tr> <td> <![endif]--> <!-- Email Header : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 600px;'> <tr> <td style='padding: 20px 0; text-align: center'><img src='http://192.168.1.101/MVCfiscaliasinaloa/Images/logo-fiscalia-sinaloa.png' width='108' height='126' alt='alt_text' border='0'></td> </tr> </table> <!-- Email Header : END --> <!-- Email Body : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='100%' style='max-width: 600px;'> <!-- 1 Column Text : BEGIN --> <tr> <td><table cellspacing='0' cellpadding='0' border='0' width='100%'> <tr> <td style='padding: 40px; font-family: sans-serif; font-size: 15px; mso-height-rule: exactly; line-height: 20px; color: #555555;'> <p style='font-size:16px; font-weight: bold; text-align:center'> Su pre-denuncia ha sido rechazada. </p>​<p> Lo sentimos, su pre-denuncia con el Folio: FLD[Folio] no ha sido procesada correctamente por los siguientes motivos: FLD[Contestacion]. </p> </td> </tr> </table></td> </tr> <!-- 1 Column Text : BEGIN -->​</table> <!-- Email Body : END --> <!-- Email Footer : BEGIN --> <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 680px;'> <tr> <td style='padding: 40px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'><webversion style='color:#aaa; text-decoration:underline; font-weight: bold;'></webversion> <br> <br> <b>Portal Ciudadano</b> <br> Fiscalía General del Estado de Sinaloa<br> <span class='mobile-link--footer'> http://www.fiscaliasinaloa.mx/ </span> <br> <!-- <br> <unsubscribe style='color:#888888; text-decoration:underline;'>unsubscribe</unsubscribe> --> </td> </tr> </table> <!-- Email Footer : END --> <!--[if (gte mso 9)|(IE)]> </td> </tr> </table> <![endif]--> </div> </center></td> </tr> </table> </body> </html>",rowIndex,nameOfTable);} else {}


}
//BusinessRuleId:3270, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:4793, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt('109', '109')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { EvaluaQuery(" EXEC sp_ActContestacionCiudadano FLDD[lblClave]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:4793, Attribute:2, Operation:Object, Event:AFTERSAVING



//BusinessRuleId:4842, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt('109', '109')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Resolucion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') ) { EvaluaQuery("EXEC sp_ActContestacionCiudadano FLDD[lblClave]", rowIndex, nameOfTable); SendEmailQuery('Notificación de canalización a órgano interno de control', EvaluaQuery("select STUFF((		select ';' + Email + ''		from Spartan_User		where Role =114	for XML PATH('')	), 1, 1, '')"), "Por medio del presente correo se le notifica que se ha recibido una canalización al órgano interno de control para tomar las acciones necesarias hacia una resolución de la problemática."
+" "
+" Gracias",rowIndex,nameOfTable);} else {}

}
//BusinessRuleId:4842, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}