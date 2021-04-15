var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function() {

    //$('#Nombres').css("height", "50px");
    //$('#Nombres').css("font-size", "15px");


    //LIMITAR LONGITUD CAMPO NUMERO DE IDENTIFICACIÓN
    $("form#CreateAsignacion_de_Turnos").on('keyup', '#Numero_de_Identificacion', function() {
        if ($(this).val().length > 20) {
            $(this).val($(this).val().substr(0, 20));
        }
    });

    //COD-MANI INI OCULTAR BOTONES
    $('#Asignacion_de_TurnosGuardarYNuevo').css('display', 'none');
    $('#Asignacion_de_TurnosGuardarYCopia').css('display', 'none');


    //INI COD-MAN para limpiar autocompletables Denuncia_Ciudadana y Turno_Previo
    $("form#CreateAsignacion_de_Turnos").on('change', '#Tipo_de_Urgencia', function() {
        nameOfTable = '';
        rowIndex = '';
        TipoUrgenciaanterior = GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex);
        if (GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) != TryParseInt('7', '7')) {
                if ($("#Denuncia_Ciudadana").val() != null && $("#Denuncia_Ciudadana").val() != "") {
                    $("#Denuncia_Ciudadana").val('null').trigger("change");
                }
            }

            if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) != TryParseInt('8', '8')) {
                if ($("#Turno_Previo").val() != null && $("#Turno_Previo").val() != "") {
                    $("#Turno_Previo").val('null').trigger("change");
                }
            }
        } else {
            if (($("#Turno_Previo").val() != null && $("#Turno_Previo").val() != "") || ($("#Denuncia_Ciudadana").val() != null && $("#Denuncia_Ciudadana").val() != "")) {
                $("#Denuncia_Ciudadana").val('null').trigger("change");
                $("#Turno_Previo").val('null').trigger("change");
            }
        }

    });
    //FIN COD-MAN para limpiar autocompletables Denuncia_Ciudadana y Turno_Previo

    //Validar dependiendo del tipo de identificacion seleccionada.
    $("#Numero_de_Identificacion").blur(function() {
        var tipoVal = $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex).val();
        var NumeroVal = $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).val();
        var valid = "";

        if (tipoVal != "" && NumeroVal != "") {
            if (tipoVal == 1) //IFE
            {


            }

            if (tipoVal == 6) //CURP
            {
                valid = /^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/,
                    validado = NumeroVal.toUpperCase().match(valid);

                if (!validado) { //Coincide con el formato general?
                    $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").val("").focus().blur();
                    return false;
                }
            }
        }
    });




    //BusinessRuleId:1862, Attribute:265550, Operation:Field, Event:None
    $("form#CreateAsignacion_de_Turnos").on('keyup', '#Nombres', function() {
        nameOfTable = '';
        rowIndex = '';

        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));

    });


    //BusinessRuleId:1862, Attribute:265550, Operation:Field, Event:None


    //INI SOLO PERMITIR SOLO LETRAS Y ESPACIO CON LIMITE 50
    $("#Nombres, #Apellido_Paterno, #Apellido_Materno").bind('keypress', function(event) {
        var regex = new RegExp("^[a-zA-Z ñÑ]+$");
        var key = String.fromCharCode(!event.charCode ? event.which : event.charCode);
        if (!regex.test(key)) {
            event.preventDefault();
            return false;
        }

        //Valida maximo de caracteres
        if (this.value.length > 49) {
            return false;
        }

    });

    //POR SI PEGAN UN TEXTO MAS LARGO, AL HACER BLUR SE TRUNCA.
    $('#Nombres, #Apellido_Paterno, #Apellido_Materno').blur(function() {
        if (this.value.length > 49) {
            this.value = this.value.slice(0, 50);
        }
    });

    //LIMITE 30, NO SE REPORTA ERROR, POR LO QUE NO SE LE MODIFICA NADA.
    $("form#CreateAsignacion_de_Turnos").on('keyup', '#Numero_de_Identificacion', function() {
        nameOfTable = '';
        rowIndex = '';
        var str = $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).val();
        if (str != "") {
            var regNUM = /^.{1,30}$/
            var validacionnum = regNUM.test(str)
            if (validacionnum == false) {
                $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).val($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).val().slice(0, -1));
            }
        }
    });
    //END SOLO PERMITIR SOLO LETRAS Y ESPACIO CON LIMITE 50


    //BusinessRuleId:1863, Attribute:265551, Operation:Field, Event:None
    $("form#CreateAsignacion_de_Turnos").on('keyup', '#Apellido_Paterno', function() {
        nameOfTable = '';
        rowIndex = '';

        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
    });


    //BusinessRuleId:1863, Attribute:265551, Operation:Field, Event:None

    //BusinessRuleId:1864, Attribute:265552, Operation:Field, Event:None



    //BusinessRuleId:1864, Attribute:265552, Operation:Field, Event:None

    $("form#CreateAsignacion_de_Turnos").on('keyup', '#Apellido_Materno', function() {
        nameOfTable = '';
        rowIndex = '';

        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
    });



















    //BusinessRuleId:1512, Attribute:265557, Operation:Field, Event:None
    $("form#CreateAsignacion_de_Turnos").on('change', '#Urgencia', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divTipo_de_Urgencia').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
        } else {
            $('#divTipo_de_Urgencia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
            AsignarValor($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), '0');
        }
    });


    //BusinessRuleId:1512, Attribute:265557, Operation:Field, Event:None

    //BusinessRuleId:3343, Attribute:265554, Operation:Field, Event:None
    $("form#CreateAsignacion_de_Turnos").on('keyup', '#Edad', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Edad' + rowIndex), nameOfTable, rowIndex) > TryParseInt('127', '127')) { AsignarValor($('#' + nameOfTable + 'Edad' + rowIndex), '127'); } else {}
    });


    //BusinessRuleId:3343, Attribute:265554, Operation:Field, Event:None

    //BusinessRuleId:3612, Attribute:265555, Operation:Field, Event:None
    $("form#CreateAsignacion_de_Turnos").on('change', '#Tipo_de_Identificacion', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('8', '8')) { $('#divOtra_Identificacion').css('display', 'block'); } else {
            $('#divOtra_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otra_Identificacion' + rowIndex));
        }
    });


    //BusinessRuleId:3612, Attribute:265555, Operation:Field, Event:None





    //BusinessRuleId:3886, Attribute:265558, Operation:Field, Event:None
    $("form#CreateAsignacion_de_Turnos").on('change', '#Tipo_de_Urgencia', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('8', '8')) {
            $('#divTurno_Previo').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
            $('#divTurno_Previo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
            AsignarValor($('#' + nameOfTable + 'Turno_Previo' + rowIndex), 'null');
        }
    });


    //BusinessRuleId:3886, Attribute:265558, Operation:Field, Event:None











    //BusinessRuleId:3890, Attribute:272194, Operation:Field, Event:None
    $("form#CreateAsignacion_de_Turnos").on('change', '#Denuncia_Ciudadana', function() {
        nameOfTable = '';
        rowIndex = '';
        if (operation != "Consult") {

            AsignarValor($('#' + nameOfTable + 'Nombres' + rowIndex), EvaluaQuery(" EXEC UspObtenerInformacionDenunciaDesdeRegistroTurno FLD[Denuncia_Ciudadana], 1", rowIndex, nameOfTable));
            AsignarValor($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex), EvaluaQuery(" EXEC UspObtenerInformacionDenunciaDesdeRegistroTurno FLD[Denuncia_Ciudadana], 2", rowIndex, nameOfTable));
            AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex), EvaluaQuery(" EXEC UspObtenerInformacionDenunciaDesdeRegistroTurno FLD[Denuncia_Ciudadana], 3", rowIndex, nameOfTable));
        }
    });


    //BusinessRuleId:3890, Attribute:272194, Operation:Field, Event:None







    //BusinessRuleId:3885, Attribute:265558, Operation:Field, Event:None
    $("form#CreateAsignacion_de_Turnos").on('change', '#Tipo_de_Urgencia', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('7', '7')) {
            $('#divDenuncia_Ciudadana').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
            $('#divDenuncia_Ciudadana').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
            AsignarValor($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex), '0');
            AsignarValor($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex), 'null');
        }
    });


    //BusinessRuleId:3885, Attribute:265558, Operation:Field, Event:None


    //SE COMENTÓ LA REGLA 3891 PORQUE DABA ERROR AL EDITAR - FELIPE RODRÍGUEZ






    //BusinessRuleId:4707, Attribute:265555, Operation:Field, Event:None
    $("form#CreateAsignacion_de_Turnos").on('change', '#Tipo_de_Identificacion', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4') || GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('NULL ', 'NULL ')) {
            $('#divNumero_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        } else { $('#divNumero_de_Identificacion').css('display', 'block'); }
    });


    //BusinessRuleId:4707, Attribute:265555, Operation:Field, Event:None

    //NEWBUSINESSRULE_NONE//
});

function EjecutarValidacionesAlComienzo() {

    //BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        DisabledControl($("#" + nameOfTable + "Fecha_de_Turno" + rowIndex), ("true" == "true"));
        DisabledControl($("#" + nameOfTable + "Hora_de_Turno" + rowIndex), ("true" == "true"));


    }
    //BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Fecha_de_Turno" + rowIndex), ("true" == "true"));
        DisabledControl($("#" + nameOfTable + "Hora_de_Turno" + rowIndex), ("true" == "true"));


    }
    //BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        DisabledControl($("#" + nameOfTable + "Fecha_de_Turno" + rowIndex), ("true" == "true"));
        DisabledControl($("#" + nameOfTable + "Hora_de_Turno" + rowIndex), ("true" == "true"));


    }
    //BusinessRuleId:1509, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1508, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex), EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Hora_de_Turno' + rowIndex), EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable));


    }
    //BusinessRuleId:1508, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        DisabledControl($("#" + nameOfTable + "Numero_de_Turno" + rowIndex), ("true" == "true"));


    }
    //BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Numero_de_Turno" + rowIndex), ("true" == "true"));


    }
    //BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        DisabledControl($("#" + nameOfTable + "Numero_de_Turno" + rowIndex), ("true" == "true"));


    }
    //BusinessRuleId:1511, Attribute:0, Operation:Object, Event:SCREENOPENING





    //BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            DisabledControl($("#" + nameOfTable + "Recepcion" + rowIndex), ("true" == "true"));
            DisabledControl($("#" + nameOfTable + "Modulo" + rowIndex), ("true" == "true"));
        } else {}


    }
    //BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            DisabledControl($("#" + nameOfTable + "Recepcion" + rowIndex), ("true" == "true"));
            DisabledControl($("#" + nameOfTable + "Modulo" + rowIndex), ("true" == "true"));
        } else {}


    }
    //BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            DisabledControl($("#" + nameOfTable + "Recepcion" + rowIndex), ("true" == "true"));
            DisabledControl($("#" + nameOfTable + "Modulo" + rowIndex), ("true" == "true"));
        } else {}


    }
    //BusinessRuleId:1514, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('5', '5')) {
            $('#divFolio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex));
            $('#divFecha_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex));
            $('#divHora_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Turno' + rowIndex));
            $('#divUnidad_de_Atencion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));
            $('#divRecepcion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Recepcion' + rowIndex));
            $('#divOrientador').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Orientador' + rowIndex));
            $('#divEstatus_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex));
            $('#divModulo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo' + rowIndex));
            $('#divMotivo_Finalizacion_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
            $('#divFecha_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
            $('#divHora_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
            $('#divFecha_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
            $('#divHora_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));
        } else {}


    }
    if (operation == 'New') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            $('#divFolio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex));
            $('#divFecha_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex));
            $('#divHora_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Turno' + rowIndex));
            $('#divUnidad_de_Atencion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));
            $('#divRecepcion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Recepcion' + rowIndex));
            $('#divUrgencia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Urgencia' + rowIndex));
            $('#divEstatus_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex));
            $('#divMotivo_Finalizacion_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
            $('#divFecha_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
            $('#divHora_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
            $('#divFecha_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
            $('#divHora_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));
        } else {}


    }
    //BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('5', '5')) {
            $('#divFolio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex));
            $('#divFecha_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex));
            $('#divHora_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Turno' + rowIndex));
            $('#divUnidad_de_Atencion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));
            $('#divRecepcion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Recepcion' + rowIndex));
            $('#divOrientador').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Orientador' + rowIndex));
            $('#divEstatus_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex));
            $('#divModulo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo' + rowIndex));
            $('#divMotivo_Finalizacion_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
            $('#divFecha_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
            $('#divHora_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
            $('#divFecha_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
            $('#divHora_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));

        } else {}


    }
    if (operation == 'Update') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            $('#divFolio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex));
            $('#divFecha_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex));
            $('#divHora_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Turno' + rowIndex));
            $('#divUnidad_de_Atencion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));
            $('#divRecepcion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Recepcion' + rowIndex));
            $('#divUrgencia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Urgencia' + rowIndex));
            $('#divEstatus_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex));
            $('#divMotivo_Finalizacion_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
            $('#divFecha_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
            $('#divHora_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
            $('#divFecha_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
            $('#divHora_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));
        } else {}


    }
    //BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('5', '5')) {
            $('#divFolio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex));
            $('#divFecha_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex));
            $('#divHora_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Turno' + rowIndex));
            $('#divUnidad_de_Atencion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));
            $('#divRecepcion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Recepcion' + rowIndex));
            $('#divOrientador').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Orientador' + rowIndex));
            $('#divEstatus_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex));
            $('#divModulo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo' + rowIndex));
            $('#divMotivo_Finalizacion_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
            $('#divFecha_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
            $('#divHora_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
            $('#divFecha_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
            $('#divHora_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));
        } else {}


    }
    if (operation == 'Consult') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            $('#divFolio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Folio' + rowIndex));
            $('#divFecha_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Turno' + rowIndex));
            $('#divHora_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Turno' + rowIndex));
            $('#divUnidad_de_Atencion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex));
            $('#divRecepcion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Recepcion' + rowIndex));
            $('#divUrgencia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Urgencia' + rowIndex));
            $('#divEstatus_de_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex));
            $('#divMotivo_Finalizacion_Turno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Motivo_Finalizacion_Turno' + rowIndex));
            $('#divFecha_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Asignacion' + rowIndex));
            $('#divHora_de_Asignacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Asignacion' + rowIndex));
            $('#divFecha_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Finalizacion' + rowIndex));
            $('#divHora_de_Finalizacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Finalizacion' + rowIndex));
        } else {}


    }
    //BusinessRuleId:1507, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if ($('#' + nameOfTable + 'Urgencia' + rowIndex).prop("checked") === true) {
            $('#divTipo_de_Urgencia').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
        } else {
            $('#divTipo_de_Urgencia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
        }
    }

    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Urgencia' + rowIndex).prop("checked") === true) {
            $('#divTipo_de_Urgencia').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
        } else {
            $('#divTipo_de_Urgencia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
        }
    }

    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Urgencia' + rowIndex).prop("checked") === true) {
            $('#divTipo_de_Urgencia').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
        } else {
            $('#divTipo_de_Urgencia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex));
        }
    }


    //BusinessRuleId:1615, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Estatus_de_Turno' + rowIndex), '2');
        DisabledControl($("#" + nameOfTable + "Estatus_de_Turno" + rowIndex), ("true" == "true"));


    }
    //BusinessRuleId:1615, Attribute:0, Operation:Object, Event:SCREENOPENING

















    //BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
        $('#divNombre_Completo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


    }
    //BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
        $('#divNombre_Completo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


    }
    //BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
        $('#divNombre_Completo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


    }
    //BusinessRuleId:1865, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1867, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); }
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


    }
    //BusinessRuleId:1867, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1867, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); }
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


    }
    //BusinessRuleId:1867, Attribute:0, Operation:Object, Event:SCREENOPENING









    //BusinessRuleId:1984, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) { AsignarValor($('#' + nameOfTable + 'Orientador' + rowIndex), EvaluaQuery(" select GLOBAL[USERID]", rowIndex, nameOfTable)); } else {}


    }
    //BusinessRuleId:1984, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        DisabledControl($("#" + nameOfTable + "Orientador" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Orientador' + rowIndex)); }


    }
    //BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Orientador" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Orientador' + rowIndex)); }


    }
    //BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        DisabledControl($("#" + nameOfTable + "Orientador" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Orientador' + rowIndex)); }


    }
    //BusinessRuleId:1985, Attribute:0, Operation:Object, Event:SCREENOPENING

























    //BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) { $('#divUrgencia').css('display', 'block'); } else {}


    }
    //BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) { $('#divUrgencia').css('display', 'block'); } else {}


    }
    //BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) { $('#divUrgencia').css('display', 'block'); } else {}


    }
    //BusinessRuleId:1989, Attribute:0, Operation:Object, Event:SCREENOPENING



    //BusinessRuleId:2630, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo' + rowIndex));


    }
    //BusinessRuleId:2630, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2630, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo' + rowIndex));


    }
    //BusinessRuleId:2630, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2630, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo' + rowIndex));


    }
    //BusinessRuleId:2630, Attribute:0, Operation:Object, Event:SCREENOPENING





    //BusinessRuleId:2794, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divNumero_de_Turno').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Turno' + rowIndex));


    }
    //BusinessRuleId:2794, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2794, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divNumero_de_Turno').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Turno' + rowIndex));


    }
    //BusinessRuleId:2794, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2794, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divNumero_de_Turno').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Turno' + rowIndex));


    }
    //BusinessRuleId:2794, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2809, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2809, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2809, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2809, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3592, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:3592, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3592, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:3592, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3607, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divOrientador').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Orientador' + rowIndex));
        $('#divModulo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo' + rowIndex));


    }
    //BusinessRuleId:3607, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3607, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divOrientador').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Orientador' + rowIndex));
        $('#divModulo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo' + rowIndex));


    }
    //BusinessRuleId:3607, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3607, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divOrientador').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Orientador' + rowIndex));
        $('#divModulo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo' + rowIndex));


    }
    //BusinessRuleId:3607, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3611, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Otra_Identificacion' + rowIndex));


    }
    //BusinessRuleId:3611, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3611, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Otra_Identificacion' + rowIndex));


    }
    //BusinessRuleId:3611, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3611, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Otra_Identificacion' + rowIndex));


    }
    //BusinessRuleId:3611, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:3610, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('8', '8')) { $('#divOtra_Identificacion').css('display', 'block'); } else {
            $('#divOtra_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otra_Identificacion' + rowIndex));
        }


    }
    //BusinessRuleId:3610, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3610, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('8', '8')) { $('#divOtra_Identificacion').css('display', 'block'); } else {
            $('#divOtra_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otra_Identificacion' + rowIndex));
        }


    }
    //BusinessRuleId:3610, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3610, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex), nameOfTable, rowIndex) == TryParseInt('8', '8')) { $('#divOtra_Identificacion').css('display', 'block'); } else {
            $('#divOtra_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otra_Identificacion' + rowIndex));
        }


    }
    //BusinessRuleId:3610, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3883, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('7', '7') && GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divDenuncia_Ciudadana').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
            $('#divDenuncia_Ciudadana').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
        }


    }
    //BusinessRuleId:3883, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3883, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('7', '7') && GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divDenuncia_Ciudadana').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
            $('#divDenuncia_Ciudadana').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
        }


    }
    //BusinessRuleId:3883, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3883, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('7', '7') && GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divDenuncia_Ciudadana').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
            $('#divDenuncia_Ciudadana').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex));
        }


    }
    //BusinessRuleId:3883, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:3884, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('8', '8')) {
            $('#divTurno_Previo').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
            $('#divTurno_Previo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
        }


    }
    //BusinessRuleId:3884, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3884, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('8', '8')) {
            $('#divTurno_Previo').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
            $('#divTurno_Previo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
        }


    }
    //BusinessRuleId:3884, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3884, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('8', '8')) {
            $('#divTurno_Previo').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
            $('#divTurno_Previo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Turno_Previo' + rowIndex));
        }


    }
    //BusinessRuleId:3884, Attribute:0, Operation:Object, Event:SCREENOPENING

























    //BusinessRuleId:3887, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        var valor = $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).val();
        $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("EXEC UspGeneraComboDenunciaCiudadanaRegistroTurnos	", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("EXEC UspGeneraComboDenunciaCiudadanaRegistroTurnos	", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3887, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3887, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        var valor = $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).val();
        $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("EXEC UspGeneraComboDenunciaCiudadanaRegistroTurnos	", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("EXEC UspGeneraComboDenunciaCiudadanaRegistroTurnos	", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3887, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3887, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        var valor = $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).val();
        $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("EXEC UspGeneraComboDenunciaCiudadanaRegistroTurnos	", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("EXEC UspGeneraComboDenunciaCiudadanaRegistroTurnos	", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Denuncia_Ciudadana' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3887, Attribute:0, Operation:Object, Event:SCREENOPENING













    //BusinessRuleId:3888, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        var valor = $('#' + nameOfTable + 'Turno_Previo' + rowIndex).val();
        $('#' + nameOfTable + 'Turno_Previo' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Turno_Previo' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Turno_Previo' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT" +
                "   Clave ," +
                "   Numero_Turno" +
                " FROM" +
                "   dbo.Asignacion_de_Turnos_Previos" +
                " WHERE" +
                "   DATEDIFF(DAY, Fecha, GETDATE()) = 0 AND" +
                "   Clave NOT IN ( SELECT" +
                "                   ISNULL(Turno_Previo, 0)" +
                "                  FROM" +
                "                   dbo.Asignacion_de_Turnos" +
                "                  WHERE" +
                "                   DATEDIFF(DAY, Fecha_de_Turno, GETDATE()) = 0 AND" +
                "                   Estatus_de_Turno <> 3 )" +
                " 				  ", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Turno_Previo' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT" +
                "   Clave ," +
                "   Numero_Turno" +
                " FROM" +
                "   dbo.Asignacion_de_Turnos_Previos" +
                " WHERE" +
                "   DATEDIFF(DAY, Fecha, GETDATE()) = 0 AND" +
                "   Clave NOT IN ( SELECT" +
                "                   ISNULL(Turno_Previo, 0)" +
                "                  FROM" +
                "                   dbo.Asignacion_de_Turnos" +
                "                  WHERE" +
                "                   DATEDIFF(DAY, Fecha_de_Turno, GETDATE()) = 0 AND" +
                "                   Estatus_de_Turno <> 3 )" +
                " 				  ", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Turno_Previo' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Turno_Previo' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3888, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3888, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        debugger;
        var valor = $('#' + nameOfTable + 'Turno_Previo' + rowIndex).val();
        $('#' + nameOfTable + 'Turno_Previo' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Turno_Previo' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Turno_Previo' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT" +
                "   Clave ," +
                "   Numero_Turno" +
                " FROM" +
                "   dbo.Asignacion_de_Turnos_Previos" +
                " WHERE" +
                "   DATEDIFF(DAY, Fecha, GETDATE()) = 0 AND" +
                "   Clave NOT IN ( SELECT" +
                "                   ISNULL(Turno_Previo, 0)" +
                "                  FROM" +
                "                   dbo.Asignacion_de_Turnos" +
                "                  WHERE" +
                "                   DATEDIFF(DAY, Fecha_de_Turno, GETDATE()) = 0 AND" +
                "                   Estatus_de_Turno <> 3 )" +
                " 				  ", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Turno_Previo' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT" +
                "   Clave ," +
                "   Numero_Turno" +
                " FROM" +
                "   dbo.Asignacion_de_Turnos_Previos" +
                " WHERE" +
                "   DATEDIFF(DAY, Fecha, GETDATE()) = 0 AND" +
                "   Clave NOT IN ( SELECT" +
                "                   ISNULL(Turno_Previo, 0)" +
                "                  FROM" +
                "                   dbo.Asignacion_de_Turnos" +
                "                  WHERE" +
                "                   DATEDIFF(DAY, Fecha_de_Turno, GETDATE()) = 0 AND" +
                "                   Estatus_de_Turno <> 3 )" +
                " 				  ", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Turno_Previo' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Turno_Previo' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3888, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3888, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        //  var valor = $('#' + nameOfTable + 'Turno_Previo' + rowIndex).val();   $('#' + nameOfTable + 'Turno_Previo' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Turno_Previo' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Turno_Previo' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT"
        // +"   Clave ,"
        // +"   Numero_Turno"
        // +" FROM"
        // +"   dbo.Asignacion_de_Turnos_Previos"
        // +" WHERE"
        // +"   DATEDIFF(DAY, Fecha, GETDATE()) = 0 AND"
        // +"   Clave NOT IN ( SELECT"
        // +"                   ISNULL(Turno_Previo, 0)"
        // +"                  FROM"
        // +"                   dbo.Asignacion_de_Turnos"
        // +"                  WHERE"
        // +"                   DATEDIFF(DAY, Fecha_de_Turno, GETDATE()) = 0 AND"
        // +"                   Estatus_de_Turno <> 3 )"
        // +" 				  ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Turno_Previo' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT"
        // +"   Clave ,"
        // +"   Numero_Turno"
        // +" FROM"
        // +"   dbo.Asignacion_de_Turnos_Previos"
        // +" WHERE"
        // +"   DATEDIFF(DAY, Fecha, GETDATE()) = 0 AND"
        // +"   Clave NOT IN ( SELECT"
        // +"                   ISNULL(Turno_Previo, 0)"
        // +"                  FROM"
        // +"                   dbo.Asignacion_de_Turnos"
        // +"                  WHERE"
        // +"                   DATEDIFF(DAY, Fecha_de_Turno, GETDATE()) = 0 AND"
        // +"                   Estatus_de_Turno <> 3 )"
        // +" 				  ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Turno_Previo' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Turno_Previo' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3888, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1513, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4') || EvaluaQuery("select GLOBAL[USERROLEID]	", rowIndex, nameOfTable) == TryParseInt('5', '5')) {
            AsignarValor($('#' + nameOfTable + 'Recepcion' + rowIndex), EvaluaQuery(" select GLOBAL[USERID]", rowIndex, nameOfTable));
            AsignarValor($('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex), EvaluaQuery(" SELECT CLAVE FROM UNIDAD WHERE CLAVE = (SELECT TOP 1 UNIDAD FROM Relacion_Unidad_Usuario WHERE USUARIO = GLOBAL[USERID])", rowIndex, nameOfTable));
            DisabledControl($("#" + nameOfTable + "Unidad_de_Atencion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Recepcion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Recepcion' + rowIndex)); }
            AsignarValor($('#' + nameOfTable + 'Modulo' + rowIndex), EvaluaQuery(" SELECT CLAVE FROM Modulo WHERE Unidad_de_Atencion = (SELECT TOP 1 UNIDAD FROM Relacion_Unidad_Usuario WHERE USUARIO = GLOBAL[USERID]) AND Orientador = GLOBAL[USERID]", rowIndex, nameOfTable));
            AsignarValor($('#' + nameOfTable + 'Unidad_de_Atencion' + rowIndex), EvaluaQuery("select unidad from Spartan_User WHERE Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));
        } else {}


    }
    //BusinessRuleId:1513, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:4706, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        AsignarValor($('#' + nameOfTable + 'Nombres' + rowIndex), EvaluaQuery(" SELECT Nombres FROM Asignacion_de_Turnos WHERE FOLIO = FLDD[lblFolio]", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex), EvaluaQuery(" SELECT APELLIDO_PATERNO FROM Asignacion_de_Turnos WHERE FOLIO = FLDD[lblFolio]", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex), EvaluaQuery(" SELECT APELLIDO_MATERNO FROM Asignacion_de_Turnos WHERE FOLIO = FLDD[lblFolio]", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery(" SELECT NOMBRE_COMPLETO FROM Asignacion_de_Turnos WHERE FOLIO = FLDD[lblFolio]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:4706, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4745, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        var valor = $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).val();
        $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Tipo_de_Atencion WHERE VIGENTE = 1", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Tipo_de_Atencion WHERE VIGENTE = 1", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:4745, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4745, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        var valor = $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).val();
        $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Tipo_de_Atencion WHERE VIGENTE = 1", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Tipo_de_Atencion WHERE VIGENTE = 1", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:4745, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4745, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        var valor = $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).val();
        $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Tipo_de_Atencion WHERE VIGENTE = 1", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Tipo_de_Atencion WHERE VIGENTE = 1", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Tipo_de_Atencion' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:4745, Attribute:0, Operation:Object, Event:SCREENOPENING

    //NEWBUSINESSRULE_SCREENOPENING//
}

function EjecutarValidacionesAntesDeGuardar() {
    var result = true;


    //BusinessRuleId:3009, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) < TryParseInt('1', '1')) {
            alert(DecodifyText(' El campo Tipo de Urgencia es Requerido.', rowIndex, nameOfTable));

            result = false;
        } else {}


    }
    //BusinessRuleId:3009, Attribute:2, Operation:Object, Event:BEFORESAVING

    //BusinessRuleId:3009, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Urgencia' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Urgencia' + rowIndex), nameOfTable, rowIndex) < TryParseInt('1', '1')) {
            alert(DecodifyText(' El campo Tipo de Urgencia es Requerido.', rowIndex, nameOfTable));

            result = false;
        } else {}


    }
    //BusinessRuleId:3009, Attribute:2, Operation:Object, Event:BEFORESAVING


    //BusinessRuleId:3593, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'New') {
        if (EvaluaQuery("SELECT LEN('FLD[Observaciones]')", rowIndex, nameOfTable) <= TryParseInt('2', '2')) {
            alert(DecodifyText('Se debe agregar una observación.', rowIndex, nameOfTable));

            result = false;
        } else {}


    }
    //BusinessRuleId:3593, Attribute:2, Operation:Object, Event:BEFORESAVING

    //BusinessRuleId:3593, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'Update') {
        if (EvaluaQuery("SELECT LEN('FLD[Observaciones]')", rowIndex, nameOfTable) <= TryParseInt('2', '2')) {
            alert(DecodifyText('Se debe agregar una observación.', rowIndex, nameOfTable));

            result = false;
        } else {}


    }
    //BusinessRuleId:3593, Attribute:2, Operation:Object, Event:BEFORESAVING

    //NEWBUSINESSRULE_BEFORESAVING//
    return result;
}

function EjecutarValidacionesDespuesDeGuardar() {




    //BusinessRuleId:2793, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Numero_de_Turno' + rowIndex), EvaluaQuery(" exec uspGeneraTurnoAutomatico GLOBAL[KeyValueInserted]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:2793, Attribute:2, Operation:Object, Event:AFTERSAVING





    //BusinessRuleId:3853, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        EvaluaQuery(" UPDATE Asignacion_de_Turnos SET Nombre_Completo = Nombres + (CASE WHEN Apellido_Paterno IS null THEN '' ELSE ' ' + Apellido_Paterno END) + (CASE WHEN Apellido_Materno IS null THEN '' ELSE ' ' + Apellido_Materno END) WHERE Folio = GLOBAL[KeyValueInserted]	", rowIndex, nameOfTable);


    }
    //BusinessRuleId:3853, Attribute:2, Operation:Object, Event:AFTERSAVING

    //BusinessRuleId:3889, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        EvaluaQuery(" EXEC UspGuardarTurnoPrevio GLOBAL[KeyValueInserted]" +
            " ", rowIndex, nameOfTable);


    }
    //BusinessRuleId:3889, Attribute:2, Operation:Object, Event:AFTERSAVING

    //NEWBUSINESSRULE_AFTERSAVING//
}