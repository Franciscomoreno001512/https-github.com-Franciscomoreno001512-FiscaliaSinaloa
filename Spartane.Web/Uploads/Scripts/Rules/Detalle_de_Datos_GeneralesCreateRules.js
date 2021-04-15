var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function() {
    $("#Detalle_de_Datos_GeneralesGuardarYNuevo").remove();
    $("#Detalle_de_Datos_GeneralesGuardarYCopia").remove();
    if (operation == 'Update') {
        if (TryParseInt('107', '107') == EvaluaQuery("SELECT GLOBAL[USERROLEID]", rowIndex, nameOfTable)) {
            $("#Detalle_de_Datos_GeneralesGuardar").remove();
            $("#divMapa").hide();
        }
    }

    if (operation == 'Update') {
        if (EvaluaQuery("select Canalizado from Detalle_de_Datos_Generales where Clave = FLDD[lblClave]", rowIndex, nameOfTable) == TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]')) == TryParseInt('2', '2')) {
            $("#Detalle_de_Datos_GeneralesGuardar").remove();
        }
    }
    if (operation == 'Update') {
        if (TryParseInt('107', '107') == EvaluaQuery("SELECT GLOBAL[USERROLEID]", rowIndex, nameOfTable)) {
            $("#Detalle_de_Datos_GeneralesGuardar").hide();
        }
    }

    //CONVERTIR A MAYUSCULAS AL BLUR
    $('input[type="text"],textarea').blur(function() {
        this.value = this.value.toUpperCase();
    });
    //END CONVERTIR A MAYUSCULAS AL BLUR

    //Validar RFC
    $("#RFC").blur(function() {
        var v = $('#' + nameOfTable + 'RFC' + rowIndex).val();
        if (v != "") {
            var valid = '^(([A-Z]|[a-z]){4})([0-9]{6})((([A-Z]|[a-z]|[0-9]){3}))';
            var validRfc = new RegExp(valid);
            var matchArray = v.match(validRfc);
            if (matchArray == null || v.length > 13) {
                $('#' + nameOfTable + 'RFC' + rowIndex).attr("placeholder", "El formato del RFC es incorrecto.").val("").focus().blur();
                return false;
            }
        }
    });

    //Validar CURP
    $("#CURP").blur(function() {
        var v = $('#' + nameOfTable + 'CURP' + rowIndex).val();
        if (v != "") {
            var valid = /^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/,
                //validado = v.toUpperCase().match(valid);
                validado = valid.test(v)
            if (!validado) { //Coincide con el formato general?
                $('#' + nameOfTable + 'CURP' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").val("").focus().blur();
                return false;
            }
        }
    });

    //Validar Correo
    $('#Correo_Electronico').change(function() {
        let email = $('#Correo_Electronico').val();
        let exp = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/);
        if (exp.test(email) == false) {
            $('#Correo_Electronico').attr("placeholder", "Correo electrónico no válido.").val("").focus().blur();
        }
    });
    $('#Correo_Electronico_del_Tutor').change(function() {
        let email = $('#Correo_Electronico_del_Tutor').val();
        let exp = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/);
        if (exp.test(email) == false) {
            $('#Correo_Electronico_del_Tutor').attr("placeholder", "Correo electrónico no válido.").val("").focus().blur();
        }
    });

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

    //Validar RFC_Tutor
    $("#RFC_Tutor").blur(function() {
        var v = $('#' + nameOfTable + 'RFC_Tutor' + rowIndex).val();
        if (v != "") {
            var valid = '^(([A-Z]|[a-z]){4})([0-9]{6})((([A-Z]|[a-z]|[0-9]){3}))';
            var validRfc = new RegExp(valid);
            var matchArray = v.match(validRfc);
            if (matchArray == null || v.length > 13) {
                $('#' + nameOfTable + 'RFC_Tutor' + rowIndex).attr("placeholder", "El formato del RFC es incorrecto.").val("").focus().blur();
                return false;
            }
        }
    });

    //Validar CURP_Tutor
    $("#CURP_Tutor").blur(function() {
        var v = $('#' + nameOfTable + 'CURP_Tutor' + rowIndex).val();
        if (v != "") {
            var valid = /^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/,
                //validado = v.toUpperCase().match(valid); 
                validado = valid.test(v)
            if (!validado) { //Coincide con el formato general?
                $('#' + nameOfTable + 'CURP_Tutor' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").val("").focus().blur();
                return false;
            }
        }
    });



    //Validar dependiendo del tipo de identificacion seleccionada.
    $("#Numero_de_Identificacion_del_Tutor").blur(function() {
        var tipoVal = $('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex).val();
        var NumeroVal = $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex).val();
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
                    $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").val("").focus().blur();
                    return false;
                }
            }
        }
    });

});

//BusinessRuleId:42, Attribute:263782, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Fecha_de_Nacimiento', function() {
    nameOfTable = '';
    rowIndex = '';
    if (EvaluaQuery("DECLARE @date date, @tmpdate date, @years int" +
            " " +
            " SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento]',103)),103)" +
            " " +
            " SELECT @tmpdate = @date" +
            " " +
            " SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END" +
            " " +
            " SELECT @tmpdate = DATEADD(yy, @years, @tmpdate)" +
            " " +
            " SELECT @years", rowIndex, nameOfTable) < TryParseInt('18', '18') && $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex).val() != TryParseInt('null', 'null')) { $("a[href='#tabDatos_del_Tutor']").css('display', 'block'); } else { $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); }
});


//BusinessRuleId:42, Attribute:263782, Operation:Field, Event:None

//BusinessRuleId:74, Attribute:263782, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Fecha_de_Nacimiento', function() {
    nameOfTable = '';
    rowIndex = '';
    if ($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex).val() != TryParseInt('null', 'null')) {
        AsignarValor($('#' + nameOfTable + 'Edad' + rowIndex), EvaluaQuery("DECLARE @date date, @tmpdate date, @years int" +
            " " +
            " SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento]',103)),103)" +
            " " +
            " SELECT @tmpdate = @date" +
            " " +
            " SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END" +
            " " +
            " SELECT @tmpdate = DATEADD(yy, @years, @tmpdate)" +
            " " +
            " SELECT @years", rowIndex, nameOfTable));
    } else {}
});


//BusinessRuleId:74, Attribute:263782, Operation:Field, Event:None



























//BusinessRuleId:1914, Attribute:263830, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Tipo_de_Compareciente', function() {
    nameOfTable = '';
    rowIndex = '';
    if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('3', '3')) {
        $('#divMunicipio_Corporacion').css('display', 'block');
        $('#divCorporacion').css('display', 'block');
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        $('#divOcupacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
        $('#divEstado_de_Involucrado').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
    } else {}
});


//BusinessRuleId:1914, Attribute:263830, Operation:Field, Event:None



//BusinessRuleId:1917, Attribute:263830, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Tipo_de_Compareciente', function() {
    nameOfTable = '';
    rowIndex = '';
    if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('4', '4')) {
        $('#divOcupacion').css('display', 'block');
        $('#divEstado_de_Involucrado').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
        $('#divMunicipio_Corporacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
        $('#divCorporacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
    } else {}
});


//BusinessRuleId:1917, Attribute:263830, Operation:Field, Event:None







//BusinessRuleId:1918, Attribute:263830, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Tipo_de_Compareciente', function() {
    nameOfTable = '';
    rowIndex = '';
    if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('2', '2')) {
        $('#divOcupacion').css('display', 'block');
        $('#divEstado_de_Involucrado').css('display', 'block');
        $('#divMunicipio_Corporacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
        $('#divCorporacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        $('#divQ_Q_R_O_').css('display', 'block');
        $('#divPersona_Moral').css('display', 'block');
    } else {
        $('#divQ_Q_R_O_').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));
        $('#divPersona_Moral').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
    }
});


//BusinessRuleId:1918, Attribute:263830, Operation:Field, Event:None






//BusinessRuleId:1957, Attribute:266575, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Persona_Moral', function() {
    nameOfTable = '';
    rowIndex = '';
    if ($('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true) {
        $('#divCalidad_Juridica').css('display', 'block');
        $('#divRazon_Social').css('display', 'block');
        $("a[href='#tabRepresentante_Legal']").css('display', 'block');
    } else {
        $('#divCalidad_Juridica').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
        $('#divRazon_Social').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
        $("a[href='#tabRepresentante_Legal']").css('display', 'none');
    }
});


//BusinessRuleId:1957, Attribute:266575, Operation:Field, Event:None





//BusinessRuleId:1994, Attribute:266530, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Q_Q_R_O_', function() {
    nameOfTable = '';
    rowIndex = '';
    if ($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex).prop("checked") === true) {
        $('#divPersona_Moral').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
    } else { $('#divPersona_Moral').css('display', 'block'); }
});


//BusinessRuleId:1994, Attribute:266530, Operation:Field, Event:None

//BusinessRuleId:1995, Attribute:266575, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Persona_Moral', function() {
    nameOfTable = '';
    rowIndex = '';
    if ($('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true) {
        $('#divQ_Q_R_O_').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));
    } else { $('#divQ_Q_R_O_').css('display', 'block'); }
});


//BusinessRuleId:1995, Attribute:266575, Operation:Field, Event:None



//BusinessRuleId:2149, Attribute:263830, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Tipo_de_Compareciente', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
        $('#divMunicipio_Corporacion').css('display', 'block');
        $('#divCorporacion').css('display', 'block');
    } else {
        $('#divMunicipio_Corporacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
        $('#divCorporacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
    }
});


//BusinessRuleId:2149, Attribute:263830, Operation:Field, Event:None









//BusinessRuleId:2460, Attribute:263863, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('keyup', '#CURP', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'CURP' + rowIndex), nameOfTable, rowIndex) > TryParseInt('999999999999999999', '999999999999999999')) {
        alert(DecodifyText('La Curp solo puede tener maximo 18 caracteres', rowIndex, nameOfTable));

        result = false;
    } else {}
});


//BusinessRuleId:2460, Attribute:263863, Operation:Field, Event:None

//BusinessRuleId:570, Attribute:263782, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Fecha_de_Nacimiento', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null') && EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103)," +
            " CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Nacimiento]',103),103))", rowIndex, nameOfTable) > TryParseInt('0', '0')) {
        alert(DecodifyText('No se puede ingresar una fecha mayor al día de hoy', rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex), '');
        AsignarValor($('#' + nameOfTable + 'Edad' + rowIndex), '');
    } else {}
});


//BusinessRuleId:570, Attribute:263782, Operation:Field, Event:None

































//BusinessRuleId:2891, Attribute:268329, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Persona_Aparecio', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
        $('#divFecha_de_Aparicion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));
        $('#divCon_Vida').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex));
    } else {
        $('#divFecha_de_Aparicion').css('display', 'block');
        $('#divCon_Vida').css('display', 'block');
        SetRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));
        SetRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex));
    }
});


//BusinessRuleId:2891, Attribute:268329, Operation:Field, Event:None









//BusinessRuleId:2890, Attribute:268328, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Persona_Desaparecida', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
        $('#divPersona_Aparecio').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex));
        $('#divFecha_de_Aparicion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));
        $('#divCon_Vida').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex));
        AsignarValor($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex), 'false');
    } else { $('#divPersona_Aparecio').css('display', 'block'); }
});


//BusinessRuleId:2890, Attribute:268328, Operation:Field, Event:None

//BusinessRuleId:1920, Attribute:263830, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Tipo_de_Compareciente', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) { $('#divEs_victima').css('display', 'block'); } else {
        $('#divEs_victima').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex));
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
    }
});


//BusinessRuleId:1920, Attribute:263830, Operation:Field, Event:None

//BusinessRuleId:1919, Attribute:263830, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Tipo_de_Compareciente', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
        $('#divOcupacion').css('display', 'block');
        $('#divEstado_de_Involucrado').css('display', 'block');
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'block');
        $('#divMunicipio_Corporacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
        $('#divCorporacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
    } else {}
});


//BusinessRuleId:1919, Attribute:263830, Operation:Field, Event:None



//BusinessRuleId:2935, Attribute:263830, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Tipo_de_Compareciente', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) { $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none'); } else {}
});


//BusinessRuleId:2935, Attribute:263830, Operation:Field, Event:None



//BusinessRuleId:2895, Attribute:263830, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Tipo_de_Compareciente', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('2', '2')) { $('#divPersona_Desaparecida').css('display', 'block'); } else {
        $('#divPersona_Desaparecida').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex));
        $('#divPersona_Aparecio').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex));
        $('#divFecha_de_Aparicion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));
        $('#divCon_Vida').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex));
        AsignarValor($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex), 'false');
        AsignarValor($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex), 'false');
    }
});


//BusinessRuleId:2895, Attribute:263830, Operation:Field, Event:None







//BusinessRuleId:3463, Attribute:263784, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Sexo', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Sexo' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) { $('#divGravidez').css('display', 'block'); } else {
        $('#divGravidez').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex));
        AsignarValor($('#' + nameOfTable + 'Gravidez' + rowIndex), 'false');
    }
});


//BusinessRuleId:3463, Attribute:263784, Operation:Field, Event:None



//BusinessRuleId:3578, Attribute:265664, Operation:Field, Event:None
$("#Otros_Domicilios_InvolucradoGrid").on('change', '.Estado', function() {
    nameOfTable = $(this).parent().parent().parent().parent()[0].id.replace('Grid', '') + '_';
    rowIndex = '_' + $(this).parent().parent()[0].className.replace(' odd', '').replace(' even', '').replace(nameOfTable, '');
    var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();
    $('#' + nameOfTable + 'Municipio' + rowIndex).empty();
    if (!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete')) {
        $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));
        $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value)); });
    } else {
        var selectData = [];
        selectData.push({ id: "", text: "" });
        $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
        $('#' + nameOfTable + 'Municipio' + rowIndex).select2({ data: selectData })
    }
    $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');
    nameOfTable = '';
    rowIndex = '';
});
$("form#CreateOtros_Domicilios_Involucrado").on('change', '#Otros_Domicilios_InvolucradoEstado', function() {
    nameOfTable = 'Otros_Domicilios_Involucrado';
    rowIndex = '';
    var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();
    $('#' + nameOfTable + 'Municipio' + rowIndex).empty();
    if (!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete')) {
        $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));
        $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value)); });
    } else {
        var selectData = [];
        selectData.push({ id: "", text: "" });
        $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
        $('#' + nameOfTable + 'Municipio' + rowIndex).select2({ data: selectData })
    }
    $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');
});
//BusinessRuleId:3578, Attribute:265664, Operation:Field, Event:None













//BusinessRuleId:561, Attribute:263817, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Pais_del_Tutor', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).val();
        $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais_del_Tutor]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais_del_Tutor]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).val(valor).trigger('change');
    } else {}
});

//BusinessRuleId:561, Attribute:263817, Operation:Field, Event:None

//BusinessRuleId:562, Attribute:263818, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Estado_del_Tutor', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado_del_Tutor]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM MUNICIPIO WHERE ESTADO = FLD[Estado_del_Tutor]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).val(valor).trigger('change');
    } else {}
});

//BusinessRuleId:562, Attribute:263818, Operation:Field, Event:None





//BusinessRuleId:3590, Attribute:263782, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Fecha_de_Nacimiento', function() {
    nameOfTable = '';
    rowIndex = '';
    if (EvaluaQuery("DECLARE @date date, @tmpdate date, @years int SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento]',103)),103) SELECT @tmpdate = @date SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(yy, @years, @tmpdate) SELECT @years", rowIndex, nameOfTable) < TryParseInt('18', '18') && GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        SetRequiredToControl($('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));
        SetRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));
        SetRequiredToControl($('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));
        SetRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));
        SetRequiredToControl($('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));
    } else {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));
    }
});

//BusinessRuleId:3590, Attribute:263782, Operation:Field, Event:None





//BusinessRuleId:3591, Attribute:263808, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Fecha_de_Nacimiento_del_Tutor', function() {
    nameOfTable = '';
    rowIndex = '';
    if (EvaluaQuery("DECLARE @date date, @tmpdate date, @years int SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento_del_Tutor]',103)),103) SELECT @tmpdate = @date SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(yy, @years, @tmpdate) SELECT @years", rowIndex, nameOfTable) < TryParseInt('18', '18') && GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        alert(DecodifyText('El tutor debe ser mayor de edad.', rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex), '');
        AsignarValor($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex), ' ');
    } else {}
});

//BusinessRuleId:3591, Attribute:263808, Operation:Field, Event:None

//BusinessRuleId:3595, Attribute:265586, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Grupo_al_que_pertenece', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex), nameOfTable, rowIndex) == TryParseInt('5', '5')) {
        $('#divPreferencia_Sexual').css('display', 'block');
        SetRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
    } else {
        SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
        $('#divPreferencia_Sexual').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
    }
});

//BusinessRuleId:3595, Attribute:265586, Operation:Field, Event:None

//BusinessRuleId:3596, Attribute:265596, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Estado_de_Nacimiento', function() {
    nameOfTable = '';
    rowIndex = '';
    var valor = $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).val();
    $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).empty();
    if (!$('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).hasClass('AutoComplete')) {
        $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).append($("<option selected />").val("").text(""));
        $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Municipio WHERE Estado = FLD[Estado_de_Nacimiento]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).append($("<option />").val(index).text(value)); });
    } else {
        var selectData = [];
        selectData.push({ id: "", text: "" });
        $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Municipio WHERE Estado = FLD[Estado_de_Nacimiento]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
        $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).select2({ data: selectData })
    }
    $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).val(valor).trigger('change');
});

//BusinessRuleId:3596, Attribute:265596, Operation:Field, Event:None

//BusinessRuleId:556, Attribute:263791, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Pais', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex), nameOfTable, rowIndex) == TryParseInt('82', '82')) {
        var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();
        $('#' + nameOfTable + 'Estado' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE PAIS = FLD[Pais]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Estado' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change');
        $('#divEstado').css('display', 'block');
        $('#divMunicipio').css('display', 'block');
        $('#divColonia').css('display', 'block');
        $('#divPoblacion').css('display', 'block');
        $('#divEstado_de_Nacimiento').css('display', 'block');
        $('#divMunicipio_de_Nacimiento').css('display', 'block');
    } else {
        $('#divEstado').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        $('#divMunicipio').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        $('#divColonia').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        $('#divPoblacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        $('#divEstado_Civil').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
        $('#divMunicipio').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        $('#divColonia').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        $('#divPoblacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        $('#divEstado_de_Nacimiento').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));
        $('#divMunicipio_de_Nacimiento').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));
    }
});


//BusinessRuleId:556, Attribute:263791, Operation:Field, Event:None



//BusinessRuleId:1898, Attribute:263803, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Incapaz', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Incapaz' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
        $('#divTipo_de_Inimputabilidad').css('display', 'block');
        $('#divEspecifique').css('display', 'block');
        $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
    } else {
        $('#divTipo_de_Inimputabilidad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        $('#divEspecifique').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
        $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
    }
});


//BusinessRuleId:1898, Attribute:263803, Operation:Field, Event:None

//BusinessRuleId:1897, Attribute:263789, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Escolaridad', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Escolaridad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('6', '6')) {
        $('#divEspecialidad').css('display', 'block');
        $('#divEstudios_Superiores').css('display', 'block');
        SetNotRequiredToControl($('#' + nameOfTable + 'null' + rowIndex));
    } else {
        $('#divEspecialidad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
        $('#divEstudios_Superiores').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
    }
});


//BusinessRuleId:1897, Attribute:263789, Operation:Field, Event:None



//BusinessRuleId:611, Attribute:263792, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Estado', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Estado' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');
        var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
        $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Colonia WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Colonia WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
    } else {}
});


//BusinessRuleId:611, Attribute:263792, Operation:Field, Event:None



//BusinessRuleId:1905, Attribute:265585, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Situacion_de_Vulnerabilidad', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
        $('#divGrupo_al_que_pertenece').css('display', 'block');
        SetRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
    } else {
        SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
        $('#divGrupo_al_que_pertenece').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
        $('#divPreferencia_Sexual').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
        AsignarValor($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex), 'null');
        AsignarValor($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex), 'null');
    }
});


//BusinessRuleId:1905, Attribute:265585, Operation:Field, Event:None





















//BusinessRuleId:3579, Attribute:265665, Operation:Field, Event:None
$("#Otros_Domicilios_InvolucradoGrid").on('change', '.Municipio', function() {
    nameOfTable = $(this).parent().parent().parent().parent()[0].id.replace('Grid', '') + '_';
    rowIndex = '_' + $(this).parent().parent()[0].className.replace(' odd', '').replace(' even', '').replace(nameOfTable, '');
    if (GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
        $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
    } else {}
    nameOfTable = '';
    rowIndex = '';
});
$("form#CreateOtros_Domicilios_Involucrado").on('change', '#Otros_Domicilios_InvolucradoMunicipio', function() {
    nameOfTable = 'Otros_Domicilios_Involucrado';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
        $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
    } else {}
});
//BusinessRuleId:3579, Attribute:265665, Operation:Field, Event:None

//BusinessRuleId:3580, Attribute:265665, Operation:Field, Event:None
$("#Otros_Domicilios_InvolucradoGrid").on('change', '.Municipio', function() {
    nameOfTable = $(this).parent().parent().parent().parent()[0].id.replace('Grid', '') + '_';
    rowIndex = '_' + $(this).parent().parent()[0].className.replace(' odd', '').replace(' even', '').replace(nameOfTable, '');
    var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
    $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
    if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
        $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
        $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
    } else {
        var selectData = [];
        selectData.push({ id: "", text: "" });
        $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
        $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
    }
    $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
    nameOfTable = '';
    rowIndex = '';
});
$("form#CreateOtros_Domicilios_Involucrado").on('change', '#Otros_Domicilios_InvolucradoMunicipio', function() {
    nameOfTable = 'Otros_Domicilios_Involucrado';
    rowIndex = '';
    var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
    $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
    if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
        $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
        $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
    } else {
        var selectData = [];
        selectData.push({ id: "", text: "" });
        $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
        $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
    }
    $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
});
//BusinessRuleId:3580, Attribute:265665, Operation:Field, Event:None







//BusinessRuleId:4118, Attribute:265666, Operation:Field, Event:None
$("#Otros_Domicilios_InvolucradoGrid").on('change', '.Poblacion', function() {
    nameOfTable = $(this).parent().parent().parent().parent()[0].id.replace('Grid', '') + '_';
    rowIndex = '_' + $(this).parent().parent()[0].className.replace(' odd', '').replace(' even', '').replace(nameOfTable, '');
    if (GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
    } else {
        var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio= FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio= FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
    }
    nameOfTable = '';
    rowIndex = '';
});
$("form#CreateOtros_Domicilios_Involucrado").on('change', '#Otros_Domicilios_InvolucradoPoblacion', function() {
    nameOfTable = 'Otros_Domicilios_Involucrado';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
    } else {
        var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio= FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio= FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
    }
});
//BusinessRuleId:4118, Attribute:265666, Operation:Field, Event:None





//BusinessRuleId:3584, Attribute:263819, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Municipio_del_Tutor', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio_del_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio_del_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val(valor).trigger('change');
        var valor = $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).val();
        $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio_del_Tutor] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio_del_Tutor] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).val(valor).trigger('change');
    } else {}
});

//BusinessRuleId:3584, Attribute:263819, Operation:Field, Event:None



//BusinessRuleId:4116, Attribute:265605, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Poblacion_Tutor', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val(valor).trigger('change');
    } else {
        var valor = $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio_del_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio_del_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val(valor).trigger('change');
    }
});

//BusinessRuleId:4116, Attribute:265605, Operation:Field, Event:None

//BusinessRuleId:4586, Attribute:263793, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Municipio', function() {
debugger;
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
        $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 2 and estatus = 'V'	", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 2 and estatus = 'V'	", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
        var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
    } else {}
});


//BusinessRuleId:4586, Attribute:263793, Operation:Field, Event:None

//BusinessRuleId:4587, Attribute:265581, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Poblacion', function() {
    nameOfTable = '';
    rowIndex = '';
    if (GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
        var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
    } else {
        var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 1 and estatus = 'V'	", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 1 and estatus = 'V'	", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
    }
});


//BusinessRuleId:4587, Attribute:265581, Operation:Field, Event:None



//BusinessRuleId:4709, Attribute:268330, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Fecha_de_Aparicion', function() {
    nameOfTable = '';
    rowIndex = '';
    if (EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103), CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Aparicion]',103),103))", rowIndex, nameOfTable) >= TryParseInt('1', '1')) {
        $('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex).attr("placeholder", "No se permite capturar fechas futuras, favor de revisar.").val("").focus().blur();

        result = false;
    } else {}
});


//BusinessRuleId:4709, Attribute:268330, Operation:Field, Event:None





//BusinessRuleId:4710, Attribute:268331, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Con_Vida', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Con_Vida' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divEstado_de_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));} else {}
});

//BusinessRuleId:4710, Attribute:268331, Operation:Field, Event:None

//BusinessRuleId:4711, Attribute:268331, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Con_Vida', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Con_Vida' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divEstado_de_Involucrado').css('display', 'block');} else {}
});

//BusinessRuleId:4711, Attribute:268331, Operation:Field, Event:None




$("form#CreateDetalle_de_Datos_Generales").on('change', '#Q_Q_R_O_', function () {
    nameOfTable='';
    rowIndex='';
    if( GetValueByControlType($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') )
    {
        $(".div-titulo,#divMapa").hide();
    }
    else{
        $(".div-titulo,#divMapa").show();
    }
});














//BusinessRuleId:1975, Attribute:266530, Operation:Field, Event:None
$("form#CreateDetalle_de_Datos_Generales").on('change', '#Q_Q_R_O_', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divFecha_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));$('#divEdad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));$('#divEstado_Civil').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));$('#divTipo_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));$('#divNacionalidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));$('#divEscolaridad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));$('#divOcupacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));$('#divPais').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));$('#divEstado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));$('#divMunicipio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));$('#divColonia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));$('#divCodigo_Postal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));$('#divCalle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));$('#divNumero_Exterior').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));$('#divNumero_Interior').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));$('#divTelefono').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));$('#divExtension').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex));$('#divCelular').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));$('#divCorreo_Electronico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));$('#divIncapaz').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Incapaz' + rowIndex));$('#divPais_de_Origen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));$('#divOriginario_de').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));$('#divSe_Informaron_sobre_sus_Derechos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex));$('#divSe_Informo_sobre_el_Procedimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_sobre_el_Procedimiento' + rowIndex));$('#divDatos_Confidenciales').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Confidenciales' + rowIndex));$('#divEntre_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));$('#divY_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));$('#divCURP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));$('#divRFC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));$('#divPoblacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));$('#divReferencia_de_Domicilio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));$('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));$('#divSituacion_de_Vulnerabilidad').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex));$('#divEtnia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Etnia' + rowIndex));$('#divNo_de_Hijos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'No_de_Hijos' + rowIndex));$('#divReligion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Religion' + rowIndex));$('#divServicio_Medico').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Servicio_Medico' + rowIndex));$('#divIdioma').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));$('#divCalidad_Migratoria').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));$('#divEstado_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));$('#divMunicipio_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));$('#divDialecto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Dialecto' + rowIndex));$('#divDiscapacidad_Mental').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));$('#divDiscapacidad_Fisica').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));$('#divDiscapacidad_Sensorial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));$('#divDiscapacidad_Psicosocial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));$('#divMunicipio_Corporacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));$('#divCorporacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Corporacion' + rowIndex));$('#divIncompleto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Incompleto' + rowIndex));$('#divCalidad_Juridica').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); if('true' == 'true')
{
	$('#divAdicciones_de_Involucrado').css('display', 'none');
}
else
{
	$('#divAdicciones_de_Involucrado').css('display', 'block');
} if('true' == 'true')
{
	$('#divLugares_que_Frecuenta').css('display', 'none');
}
else
{
	$('#divLugares_que_Frecuenta').css('display', 'block');
} if('true' == 'true')
{
	$('#divDatos_Personales_Adicionales').css('display', 'none');
}
else
{
	$('#divDatos_Personales_Adicionales').css('display', 'block');
} if('true' == 'true')
{
	$('#divOtras_Identificaciones').css('display', 'none');
}
else
{
	$('#divOtras_Identificaciones').css('display', 'block');
} if('true' == 'true')
{
	$('#divOtros_Domicilios').css('display', 'none');
}
else
{
	$('#divOtros_Domicilios').css('display', 'block');
} DisabledControl($("#" + nameOfTable + "Nombre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));} $('#divNumero_de_Identificacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex)); $('#divNombre').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));$('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divPais_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));$('#divEstado_de_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));$('#divGravidez').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Gravidez' + rowIndex)); AsignarValor($('#' + nameOfTable + 'Nombre' + rowIndex),'QUIEN O QUIENES'); AsignarValor($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex),'RESULTEN'); AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex),'OFENDIDOS'); $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));} else { $('#divFecha_de_Nacimiento').css('display', 'block');$('#divEdad').css('display', 'block');$('#divEstado_Civil').css('display', 'block');$('#divTipo_de_Identificacion').css('display', 'block');$('#divNacionalidad').css('display', 'block');$('#divEscolaridad').css('display', 'block');$('#divOcupacion').css('display', 'block');$('#divPais').css('display', 'block');$('#divEstado').css('display', 'block');$('#divColonia').css('display', 'block');$('#divCodigo_Postal').css('display', 'block');$('#divCalle').css('display', 'block');$('#divNumero_Exterior').css('display', 'block');$('#divNumero_Interior').css('display', 'block');$('#divTelefono').css('display', 'block');$('#divExtension').css('display', 'block');$('#divCelular').css('display', 'block');$('#divCorreo_Electronico').css('display', 'block');$('#divIncapaz').css('display', 'block');$('#divPais_de_Origen').css('display', 'block');$('#divOriginario_de').css('display', 'block');$('#divSe_Informaron_sobre_sus_Derechos').css('display', 'block');$('#divSe_Informo_sobre_el_Procedimiento').css('display', 'block');$('#divDatos_Confidenciales').css('display', 'block');$('#divEntre_Calle').css('display', 'block');$('#divY_Calle').css('display', 'block');$('#divCURP').css('display', 'block');$('#divRFC').css('display', 'block');$('#divPoblacion').css('display', 'block');$('#divReferencia_de_Domicilio').css('display', 'block');$('#divLatitud').css('display', 'block');$('#divLongitud').css('display', 'block');$('#divSituacion_de_Vulnerabilidad').css('display', 'block');$('#divEtnia').css('display', 'block');$('#divNo_de_Hijos').css('display', 'block');$('#divReligion').css('display', 'block');$('#divServicio_Medico').css('display', 'block');$('#divIdioma').css('display', 'block');$('#divCalidad_Migratoria').css('display', 'block');$('#divEstado_de_Nacimiento').css('display', 'block');$('#divMunicipio_de_Nacimiento').css('display', 'block');$('#divDialecto').css('display', 'block');$('#divDiscapacidad_Mental').css('display', 'block');$('#divDiscapacidad_Fisica').css('display', 'block');$('#divDiscapacidad_Sensorial').css('display', 'block');$('#divDiscapacidad_Psicosocial').css('display', 'block');$('#divMunicipio').css('display', 'block');$('#divMunicipio_Corporacion').css('display', 'block');$('#divCorporacion').css('display', 'block');$('#divIncompleto').css('display', 'block');$('#divCalidad_Juridica').css('display', 'block'); if('false' == 'true')
{
	$('#divAdicciones_de_Involucrado').css('display', 'none');
}
else
{
	$('#divAdicciones_de_Involucrado').css('display', 'block');
} if('false' == 'true')
{
	$('#divLugares_que_Frecuenta').css('display', 'none');
}
else
{
	$('#divLugares_que_Frecuenta').css('display', 'block');
} if('false' == 'true')
{
	$('#divDatos_Personales_Adicionales').css('display', 'none');
}
else
{
	$('#divDatos_Personales_Adicionales').css('display', 'block');
} if('false' == 'true')
{
	$('#divOtras_Identificaciones').css('display', 'none');
}
else
{
	$('#divOtras_Identificaciones').css('display', 'block');
} if('false' == 'true')
{
	$('#divOtros_Domicilios').css('display', 'none');
}
else
{
	$('#divOtros_Domicilios').css('display', 'block');
} $('#divNumero_de_Identificacion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex)); $('#divNombre').css('display', 'block');$('#divApellido_Paterno').css('display', 'block');$('#divApellido_Materno').css('display', 'block');$('#divSexo').css('display', 'block'); DisabledControl($("#" + nameOfTable + "Nombre" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));} AsignarValor($('#' + nameOfTable + 'Nombre' + rowIndex),' ');AsignarValor($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex),' ');AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex),' ');AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),' '); AsignarValor($('#' + nameOfTable + 'Nombre' + rowIndex),EvaluaQuery("SELECT ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex),EvaluaQuery("SELECT ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex),EvaluaQuery("SELECT ''", rowIndex, nameOfTable));AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery("SELECT ''", rowIndex, nameOfTable));}
});


//BusinessRuleId:1975, Attribute:266530, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
//});
function EjecutarValidacionesAlComienzo() {

    //BusinessRuleId:1720, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divModulo_Atencion_Inicial').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));


    }
    //BusinessRuleId:1720, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1738, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));


    }
    //BusinessRuleId:1738, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1752, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divClave').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));


    }
    //BusinessRuleId:1752, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1752, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divClave').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));


    }
    //BusinessRuleId:1752, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1752, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divClave').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));


    }
    //BusinessRuleId:1752, Attribute:0, Operation:Object, Event:SCREENOPENING

    

    



    //BusinessRuleId:238, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if ($('#' + nameOfTable + 'Incapaz' + rowIndex).val() == TryParseInt('false', 'false') && $('#' + nameOfTable + 'Edad' + rowIndex).val() == TryParseInt('null', 'null')) { $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); } else {}


    }
    //BusinessRuleId:238, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:238, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Incapaz' + rowIndex).val() == TryParseInt('false', 'false') && $('#' + nameOfTable + 'Edad' + rowIndex).val() == TryParseInt('null', 'null')) { $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); } else {}


    }
    //BusinessRuleId:238, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:238, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Incapaz' + rowIndex).val() == TryParseInt('false', 'false') && $('#' + nameOfTable + 'Edad' + rowIndex).val() == TryParseInt('null', 'null')) { $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); } else {}


    }
    //BusinessRuleId:238, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1896, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divNombre_Completo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
            $('#divEscolaridad_').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex));
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        } else {}


    }
    //BusinessRuleId:1896, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1896, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divNombre_Completo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
            $('#divEscolaridad_').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex));
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        } else {}


    }
    //BusinessRuleId:1896, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1896, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divNombre_Completo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
            $('#divEscolaridad_').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex));
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        } else {}


    }
    //BusinessRuleId:1896, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if ($('#' + nameOfTable + 'Escolaridad' + rowIndex).val() == TryParseInt('11', '11')) {
            $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divIncompleto').css('display', 'none');
        } else {
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divIncompleto').css('display', 'block');
        }

    }
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Escolaridad' + rowIndex).val() == TryParseInt('11', '11')) {
            $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divIncompleto').css('display', 'none');
        } else {
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divIncompleto').css('display', 'block');
        }

    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Escolaridad' + rowIndex).val() == TryParseInt('11', '11')) {
            $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divIncompleto').css('display', 'none');
        } else {
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divIncompleto').css('display', 'block');
        }

    }

    if (operation == 'New') {
        if ($('#' + nameOfTable + 'Incapaz' + ':checked').val() == TryParseInt('true', 'true')) {
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
        } else {
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
        }
    }
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Incapaz' + ':checked').val() == TryParseInt('true', 'true')) {
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
        } else {
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
        }
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Incapaz' + ':checked').val() == TryParseInt('true', 'true')) {
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
        } else {
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
        }
    }

    if (operation == 'New') {
        if ($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + ':checked').val() == TryParseInt('true', 'true')) { $('#divGrupo_al_que_pertenece').css('display', 'block'); } else { $('#divGrupo_al_que_pertenece').css('display', 'none'); }
    }
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + ':checked').val() == TryParseInt('true', 'true')) { $('#divGrupo_al_que_pertenece').css('display', 'block'); } else { $('#divGrupo_al_que_pertenece').css('display', 'none'); }
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + ':checked').val() == TryParseInt('true', 'true')) { $('#divGrupo_al_que_pertenece').css('display', 'block'); } else { $('#divGrupo_al_que_pertenece').css('display', 'none'); }
    }


    

    

    

    //BusinessRuleId:1915, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divTipo_de_Inimputabilidad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        $('#divGrupo_al_que_pertenece').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
        $('#divEspecifique').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));


    }
    //BusinessRuleId:1915, Attribute:0, Operation:Object, Event:SCREENOPENING



    //BusinessRuleId:1921, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divEs_victima').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex));


    }
    //BusinessRuleId:1921, Attribute:0, Operation:Object, Event:SCREENOPENING

    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('1', '1')) {
            $('#divEs_victima').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'block');
        } else {
            $('#divEs_victima').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        }
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('1', '1')) {
            $('#divEs_victima').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'block');
        } else {
            $('#divEs_victima').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        }
    }
    //BusinessRuleId:1943, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divTitulo_del_Hecho').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));


    }
    //BusinessRuleId:1943, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1943, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divTitulo_del_Hecho').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));


    }
    //BusinessRuleId:1943, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1943, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divTitulo_del_Hecho').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));


    }
    //BusinessRuleId:1943, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1944, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divTitulo_del_Hecho').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));


    }
    //BusinessRuleId:1944, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1944, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divTitulo_del_Hecho').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));


    }
    //BusinessRuleId:1944, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1944, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divTitulo_del_Hecho').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));


    }
    //BusinessRuleId:1944, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1945, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divEscolaridad_').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex));


    }
    //BusinessRuleId:1945, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1945, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divEscolaridad_').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex));


    }
    //BusinessRuleId:1945, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1945, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divEscolaridad_').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex));


    }
    //BusinessRuleId:1945, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1947, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Peso' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatura' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cara' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Complexion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Piel' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Frente' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calvicie' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Anteojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Boca' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Barba' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Bigote' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Senas_Particulares' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));


    }
    //BusinessRuleId:1947, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1947, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Peso' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatura' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cara' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Complexion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Piel' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Frente' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calvicie' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Anteojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Boca' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Barba' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Bigote' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Senas_Particulares' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));


    }
    //BusinessRuleId:1947, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1947, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Peso' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatura' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cara' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Complexion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Piel' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Frente' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calvicie' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Anteojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Boca' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Barba' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Bigote' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Senas_Particulares' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));


    }
    //BusinessRuleId:1947, Attribute:0, Operation:Object, Event:SCREENOPENING

    if (operation == 'New') {
        if ($('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true) {
            $('#divCalidad_Juridica').css('display', 'block');
            $('#divRazon_Social').css('display', 'block');
            $("a[href='#tabRepresentante_Legal']").css('display', 'block');
        } else {
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            $('#divRazon_Social').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
            $("a[href='#tabRepresentante_Legal']").css('display', 'none');
        }
    }
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true) {
            $('#divCalidad_Juridica').css('display', 'block');
            $('#divRazon_Social').css('display', 'block');
            $("a[href='#tabRepresentante_Legal']").css('display', 'block');
        } else {
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            $('#divRazon_Social').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
            $("a[href='#tabRepresentante_Legal']").css('display', 'none');
        }
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true) {
            $('#divCalidad_Juridica').css('display', 'block');
            $('#divRazon_Social').css('display', 'block');
            $("a[href='#tabRepresentante_Legal']").css('display', 'block');
        } else {
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            $('#divRazon_Social').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
            $("a[href='#tabRepresentante_Legal']").css('display', 'none');
        }
    }

    //BusinessRuleId:1958, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombres2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex));


    }
    //BusinessRuleId:1958, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1958, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombres2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex));


    }
    //BusinessRuleId:1958, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1958, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombres2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad2' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex));


    }
    //BusinessRuleId:1958, Attribute:0, Operation:Object, Event:SCREENOPENING





    //BusinessRuleId:1959, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('null', 'null')) { AsignarValor($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), 'null'); } else {}


    }
    //BusinessRuleId:1959, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1959, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('null', 'null')) { AsignarValor($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), 'null'); } else {}


    }
    //BusinessRuleId:1959, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1959, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('null', 'null')) { AsignarValor($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), 'null'); } else {}


    }
    //BusinessRuleId:1959, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1975, Attribute:266530, Operation:Field, Event:None
    //1975
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex).prop("checked") === true) {
            AsignarValor($('#' + nameOfTable + 'Nombre' + rowIndex), 'Victimas');
            AsignarValor($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex), 'Quien o Quienes');
            AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex), 'Resulten');
            $('#divFecha_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
            $('#divEdad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
            $('#divEstado_Civil').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
            $('#divTipo_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
            $('#divNacionalidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            $('#divEscolaridad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divPais').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divCodigo_Postal').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
            $('#divCalle').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
            $('#divNumero_Exterior').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
            $('#divNumero_Interior').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
            $('#divTelefono').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex));
            $('#divExtension').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex));
            $('#divCelular').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex));
            $('#divCorreo_Electronico').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
            $('#divIncapaz').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Incapaz' + rowIndex));
            $('#divPais_de_Origen').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));
            $('#divOriginario_de').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            $('#divSe_Informaron_sobre_sus_Derechos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex));
            $('#divSe_Informo_sobre_el_Procedimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informo_sobre_el_Procedimiento' + rowIndex));
            $('#divDatos_Confidenciales').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Confidenciales' + rowIndex));
            $('#divEntre_Calle').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
            $('#divY_Calle').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
            $('#divCURP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
            $('#divRFC').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            $('#divReferencia_de_Domicilio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
            $('#divLatitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
            $('#divLongitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
            $('#divSituacion_de_Vulnerabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex));
            $('#divEtnia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex));
            $('#divNo_de_Hijos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex));
            $('#divReligion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex));
            $('#divServicio_Medico').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex));
            $('#divIdioma').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Idioma' + rowIndex));
            $('#divCalidad_Migratoria').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));
            $('#divEstado_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));
            $('#divMunicipio_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));
            $('#divDialecto').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Dialecto' + rowIndex));
            $('#divDiscapacidad_Mental').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));
            $('#divDiscapacidad_Fisica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));
            $('#divDiscapacidad_Sensorial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));
            $('#divDiscapacidad_Psicosocial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $('#divIncompleto').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Incompleto' + rowIndex));
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            if ('true' == 'true') {
                $('#divAdicciones_de_Involucrado').css('display', 'none');
            } else {
                $('#divAdicciones_de_Involucrado').css('display', 'block');
            }
            if ('true' == 'true') {
                $('#divLugares_que_Frecuenta').css('display', 'none');
            } else {
                $('#divLugares_que_Frecuenta').css('display', 'block');
            }
            if ('true' == 'true') {
                $('#divDatos_Personales_Adicionales').css('display', 'none');
            } else {
                $('#divDatos_Personales_Adicionales').css('display', 'block');
            }
            if ('true' == 'true') {
                $('#divOtras_Identificaciones').css('display', 'none');
            } else {
                $('#divOtras_Identificaciones').css('display', 'block');
            }
            if ('true' == 'true') {
                $('#divOtros_Domicilios').css('display', 'none');
            } else {
                $('#divOtros_Domicilios').css('display', 'block');
            }
            DisabledControl($("#" + nameOfTable + "Nombre" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); }
            $('#divNumero_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        } else {
            //$('#' + nameOfTable + 'Nombre' + rowIndex).attr("placeholder", " ").val("").focus().blur();
            //$('#' + nameOfTable + 'Apellido_Paterno' + rowIndex).attr("placeholder", " ").val("").focus().blur();
            //$('#' + nameOfTable + 'Apellido_Materno' + rowIndex).attr("placeholder", " ").val("").focus().blur();
            //AsignarValor($('#' + nameOfTable + 'Nombre' + rowIndex),EvaluaQuery("select '.'", rowIndex, nameOfTable));
            //AsignarValor($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex),EvaluaQuery("select '.'", rowIndex, nameOfTable));
            //AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex),EvaluaQuery("select '.​​'", rowIndex, nameOfTable)); 
            DisabledControl($("#" + nameOfTable + "Nombre" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); }
            $('#divFecha_de_Nacimiento').css('display', 'block');
            $('#divEdad').css('display', 'block');
            $('#divEstado_Civil').css('display', 'block');
            $('#divTipo_de_Identificacion').css('display', 'block');
            $('#divNacionalidad').css('display', 'block');
            $('#divEscolaridad').css('display', 'block');
            $('#divOcupacion').css('display', 'block');
            $('#divPais').css('display', 'block');
            $('#divEstado').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divCodigo_Postal').css('display', 'block');
            $('#divCalle').css('display', 'block');
            $('#divNumero_Exterior').css('display', 'block');
            $('#divNumero_Interior').css('display', 'block');
            $('#divTelefono').css('display', 'block');
            $('#divExtension').css('display', 'block');
            $('#divCelular').css('display', 'block');
            $('#divCorreo_Electronico').css('display', 'block');
            $('#divIncapaz').css('display', 'block');
            $('#divPais_de_Origen').css('display', 'block');
            $('#divOriginario_de').css('display', 'block');
            $('#divSe_Informaron_sobre_sus_Derechos').css('display', 'block');
            $('#divSe_Informo_sobre_el_Procedimiento').css('display', 'block');
            $('#divDatos_Confidenciales').css('display', 'block');
            $('#divEntre_Calle').css('display', 'block');
            $('#divY_Calle').css('display', 'block');
            $('#divCURP').css('display', 'block');
            $('#divRFC').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divReferencia_de_Domicilio').css('display', 'block');
            $('#divLatitud').css('display', 'block');
            $('#divLongitud').css('display', 'block');
            $('#divSituacion_de_Vulnerabilidad').css('display', 'block');
            $('#divEtnia').css('display', 'block');
            $('#divNo_de_Hijos').css('display', 'block');
            $('#divReligion').css('display', 'block');
            $('#divServicio_Medico').css('display', 'block');
            $('#divIdioma').css('display', 'block');
            $('#divCalidad_Migratoria').css('display', 'block');
            $('#divEstado_de_Nacimiento').css('display', 'block');
            $('#divMunicipio_de_Nacimiento').css('display', 'block');
            $('#divDialecto').css('display', 'block');
            $('#divDiscapacidad_Mental').css('display', 'block');
            $('#divDiscapacidad_Fisica').css('display', 'block');
            $('#divDiscapacidad_Sensorial').css('display', 'block');
            $('#divDiscapacidad_Psicosocial').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'block');
            $('#divCorporacion').css('display', 'block');
            $('#divIncompleto').css('display', 'block');
            $('#divCalidad_Juridica').css('display', 'block');
            if ('false' == 'true') {
                $('#divAdicciones_de_Involucrado').css('display', 'none');
            } else {
                $('#divAdicciones_de_Involucrado').css('display', 'block');
            }
            if ('false' == 'true') {
                $('#divLugares_que_Frecuenta').css('display', 'none');
            } else {
                $('#divLugares_que_Frecuenta').css('display', 'block');
            }
            if ('false' == 'true') {
                $('#divDatos_Personales_Adicionales').css('display', 'none');
            } else {
                $('#divDatos_Personales_Adicionales').css('display', 'block');
            }
            if ('false' == 'true') {
                $('#divOtras_Identificaciones').css('display', 'none');
            } else {
                $('#divOtras_Identificaciones').css('display', 'block');
            }
            if ('false' == 'true') {
                $('#divOtros_Domicilios').css('display', 'none');
            } else {
                $('#divOtros_Domicilios').css('display', 'block');
            }
            $('#divNumero_de_Identificacion').css('display', 'block');
        }
    }
    //1975
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex).prop("checked") === true) {
            AsignarValor($('#' + nameOfTable + 'Nombre' + rowIndex), 'Victimas');
            AsignarValor($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex), 'Quien o Quienes');
            AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex), 'Resulten');
            $('#divFecha_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
            $('#divEdad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
            $('#divEstado_Civil').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
            $('#divTipo_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
            $('#divNacionalidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            $('#divEscolaridad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divPais').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divCodigo_Postal').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
            $('#divCalle').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
            $('#divNumero_Exterior').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
            $('#divNumero_Interior').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
            $('#divTelefono').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex));
            $('#divExtension').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex));
            $('#divCelular').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex));
            $('#divCorreo_Electronico').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
            $('#divIncapaz').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Incapaz' + rowIndex));
            $('#divPais_de_Origen').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));
            $('#divOriginario_de').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            $('#divSe_Informaron_sobre_sus_Derechos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex));
            $('#divSe_Informo_sobre_el_Procedimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informo_sobre_el_Procedimiento' + rowIndex));
            $('#divDatos_Confidenciales').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Confidenciales' + rowIndex));
            $('#divEntre_Calle').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
            $('#divY_Calle').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
            $('#divCURP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
            $('#divRFC').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            $('#divReferencia_de_Domicilio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
            $('#divLatitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
            $('#divLongitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
            $('#divSituacion_de_Vulnerabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex));
            $('#divEtnia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex));
            $('#divNo_de_Hijos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex));
            $('#divReligion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex));
            $('#divServicio_Medico').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex));
            $('#divIdioma').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Idioma' + rowIndex));
            $('#divCalidad_Migratoria').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));
            $('#divEstado_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));
            $('#divMunicipio_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));
            $('#divDialecto').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Dialecto' + rowIndex));
            $('#divDiscapacidad_Mental').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));
            $('#divDiscapacidad_Fisica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));
            $('#divDiscapacidad_Sensorial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));
            $('#divDiscapacidad_Psicosocial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $('#divIncompleto').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Incompleto' + rowIndex));
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            if ('true' == 'true') {
                $('#divAdicciones_de_Involucrado').css('display', 'none');
            } else {
                $('#divAdicciones_de_Involucrado').css('display', 'block');
            }
            if ('true' == 'true') {
                $('#divLugares_que_Frecuenta').css('display', 'none');
            } else {
                $('#divLugares_que_Frecuenta').css('display', 'block');
            }
            if ('true' == 'true') {
                $('#divDatos_Personales_Adicionales').css('display', 'none');
            } else {
                $('#divDatos_Personales_Adicionales').css('display', 'block');
            }
            if ('true' == 'true') {
                $('#divOtras_Identificaciones').css('display', 'none');
            } else {
                $('#divOtras_Identificaciones').css('display', 'block');
            }
            if ('true' == 'true') {
                $('#divOtros_Domicilios').css('display', 'none');
            } else {
                $('#divOtros_Domicilios').css('display', 'block');
            }
            DisabledControl($("#" + nameOfTable + "Nombre" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); }
            $('#divNumero_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        } else {
            //$('#' + nameOfTable + 'Nombre' + rowIndex).attr("placeholder", " ").val("").focus().blur();
            //$('#' + nameOfTable + 'Apellido_Paterno' + rowIndex).attr("placeholder", " ").val("").focus().blur();
            //$('#' + nameOfTable + 'Apellido_Materno' + rowIndex).attr("placeholder", " ").val("").focus().blur();
            //AsignarValor($('#' + nameOfTable + 'Nombre' + rowIndex),EvaluaQuery("select '.'", rowIndex, nameOfTable));
            //AsignarValor($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex),EvaluaQuery("select '.'", rowIndex, nameOfTable));
            //AsignarValor($('#' + nameOfTable + 'Apellido_Materno' + rowIndex),EvaluaQuery("select '.​​'", rowIndex, nameOfTable)); 
            DisabledControl($("#" + nameOfTable + "Nombre" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("false" == "true"));
            if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); }
            $('#divFecha_de_Nacimiento').css('display', 'block');
            $('#divEdad').css('display', 'block');
            $('#divEstado_Civil').css('display', 'block');
            $('#divTipo_de_Identificacion').css('display', 'block');
            $('#divNacionalidad').css('display', 'block');
            $('#divEscolaridad').css('display', 'block');
            $('#divOcupacion').css('display', 'block');
            $('#divPais').css('display', 'block');
            $('#divEstado').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divCodigo_Postal').css('display', 'block');
            $('#divCalle').css('display', 'block');
            $('#divNumero_Exterior').css('display', 'block');
            $('#divNumero_Interior').css('display', 'block');
            $('#divTelefono').css('display', 'block');
            $('#divExtension').css('display', 'block');
            $('#divCelular').css('display', 'block');
            $('#divCorreo_Electronico').css('display', 'block');
            $('#divIncapaz').css('display', 'block');
            $('#divPais_de_Origen').css('display', 'block');
            $('#divOriginario_de').css('display', 'block');
            $('#divSe_Informaron_sobre_sus_Derechos').css('display', 'block');
            $('#divSe_Informo_sobre_el_Procedimiento').css('display', 'block');
            $('#divDatos_Confidenciales').css('display', 'block');
            $('#divEntre_Calle').css('display', 'block');
            $('#divY_Calle').css('display', 'block');
            $('#divCURP').css('display', 'block');
            $('#divRFC').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divReferencia_de_Domicilio').css('display', 'block');
            $('#divLatitud').css('display', 'block');
            $('#divLongitud').css('display', 'block');
            $('#divSituacion_de_Vulnerabilidad').css('display', 'block');
            $('#divEtnia').css('display', 'block');
            $('#divNo_de_Hijos').css('display', 'block');
            $('#divReligion').css('display', 'block');
            $('#divServicio_Medico').css('display', 'block');
            $('#divIdioma').css('display', 'block');
            $('#divCalidad_Migratoria').css('display', 'block');
            $('#divEstado_de_Nacimiento').css('display', 'block');
            $('#divMunicipio_de_Nacimiento').css('display', 'block');
            $('#divDialecto').css('display', 'block');
            $('#divDiscapacidad_Mental').css('display', 'block');
            $('#divDiscapacidad_Fisica').css('display', 'block');
            $('#divDiscapacidad_Sensorial').css('display', 'block');
            $('#divDiscapacidad_Psicosocial').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'block');
            $('#divCorporacion').css('display', 'block');
            $('#divIncompleto').css('display', 'block');
            $('#divCalidad_Juridica').css('display', 'block');
            if ('false' == 'true') {
                $('#divAdicciones_de_Involucrado').css('display', 'none');
            } else {
                $('#divAdicciones_de_Involucrado').css('display', 'block');
            }
            if ('false' == 'true') {
                $('#divLugares_que_Frecuenta').css('display', 'none');
            } else {
                $('#divLugares_que_Frecuenta').css('display', 'block');
            }
            if ('false' == 'true') {
                $('#divDatos_Personales_Adicionales').css('display', 'none');
            } else {
                $('#divDatos_Personales_Adicionales').css('display', 'block');
            }
            if ('false' == 'true') {
                $('#divOtras_Identificaciones').css('display', 'none');
            } else {
                $('#divOtras_Identificaciones').css('display', 'block');
            }
            if ('false' == 'true') {
                $('#divOtros_Domicilios').css('display', 'none');
            } else {
                $('#divOtros_Domicilios').css('display', 'block');
            }
            $('#divNumero_de_Identificacion').css('display', 'block');
        }
    }

    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex).prop("checked") === true) {
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        } else { $('#divPersona_Moral').css('display', 'block'); }
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex).prop("checked") === true) {
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        } else { $('#divPersona_Moral').css('display', 'block'); }
    }

    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true) {
            $('#divQ_Q_R_O_').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));
        } else { $('#divQ_Q_R_O_').css('display', 'block'); }
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true) {
            $('#divQ_Q_R_O_').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));
        } else { $('#divQ_Q_R_O_').css('display', 'block'); }
    }


    //BusinessRuleId:1999, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divNombre_Completo2').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));


    }
    //BusinessRuleId:1999, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1999, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divNombre_Completo2').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));


    }
    //BusinessRuleId:1999, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1999, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divNombre_Completo2').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));


    }
    //BusinessRuleId:1999, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2148, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divMunicipio_Corporacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
        $('#divCorporacion').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));


    }
    //BusinessRuleId:2148, Attribute:0, Operation:Object, Event:SCREENOPENING





    //BusinessRuleId:2150, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
            $('#divMunicipio_Corporacion').css('display', 'block');
            $('#divCorporacion').css('display', 'block');
        } else {
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        }


    }
    //BusinessRuleId:2150, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2150, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
            $('#divMunicipio_Corporacion').css('display', 'block');
            $('#divCorporacion').css('display', 'block');
        } else {
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        }


    }
    //BusinessRuleId:2150, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2151, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divEstado_de_Involucrado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        } else {}


    }
    //BusinessRuleId:2151, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2151, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divEstado_de_Involucrado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        } else {}


    }
    //BusinessRuleId:2151, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2154, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $('#divEs_victima').css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        } else {}


    }
    //BusinessRuleId:2154, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2154, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $('#divEs_victima').css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        } else {}


    }
    //BusinessRuleId:2154, Attribute:0, Operation:Object, Event:SCREENOPENING



    //BusinessRuleId:2162, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex), EvaluaQuery("SELECT NUAT FROM Modulo_Atencion_Inicial where Clave = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:2162, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2176, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
            $('#divMunicipio_Corporacion').css('display', 'block');
            $('#divCorporacion').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divEstado_de_Involucrado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
        } else {}


    }
    //BusinessRuleId:2176, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2176, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('3', '3')) {
            $('#divMunicipio_Corporacion').css('display', 'block');
            $('#divCorporacion').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divEstado_de_Involucrado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
        } else {}


    }
    //BusinessRuleId:2176, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2178, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        } else {}


    }
    //BusinessRuleId:2178, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2178, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        } else {}


    }
    //BusinessRuleId:2178, Attribute:0, Operation:Object, Event:SCREENOPENING













    //BusinessRuleId:2181, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true) {
            $('#divCalidad_Juridica').css('display', 'block');
            $('#divRazon_Social').css('display', 'block');
            $("a[href='#tabRepresentante_Legal']").css('display', 'block');
        } else {
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            $('#divRazon_Social').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
            $("a[href='#tabRepresentante_Legal']").css('display', 'none');
        }


    }
    //BusinessRuleId:2181, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2181, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Persona_Moral' + rowIndex).prop("checked") === true) {
            $('#divCalidad_Juridica').css('display', 'block');
            $('#divRazon_Social').css('display', 'block');
            $("a[href='#tabRepresentante_Legal']").css('display', 'block');
        } else {
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            $('#divRazon_Social').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
            $("a[href='#tabRepresentante_Legal']").css('display', 'none');
        }


    }
    //BusinessRuleId:2181, Attribute:0, Operation:Object, Event:SCREENOPENING

    

    
    //1994
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex).prop("checked") === true) {
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        } else { $('#divPersona_Moral').css('display', 'block'); }
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex).prop("checked") === true) {
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        } else { $('#divPersona_Moral').css('display', 'block'); }
    }
    //BusinessRuleId:2177, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        } else {}


    }
    //BusinessRuleId:2177, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2177, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        } else {}


    }
    //BusinessRuleId:2177, Attribute:0, Operation:Object, Event:SCREENOPENING





    //BusinessRuleId:2180, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('2', '2')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $('#divQ_Q_R_O_').css('display', 'block');
            $('#divPersona_Moral').css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        } else {
            $('#divQ_Q_R_O_').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        }


    }
    //BusinessRuleId:2180, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2180, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('2', '2')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $('#divQ_Q_R_O_').css('display', 'block');
            $('#divPersona_Moral').css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        } else {
            $('#divQ_Q_R_O_').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        }


    }
    //BusinessRuleId:2180, Attribute:0, Operation:Object, Event:SCREENOPENING















































    //BusinessRuleId:2430, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));


    }
    //BusinessRuleId:2430, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2430, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));


    }
    //BusinessRuleId:2430, Attribute:0, Operation:Object, Event:SCREENOPENING

















    //BusinessRuleId:1274, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("DECLARE @date date, @tmpdate date, @years int" +
                " " +
                " SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento]',103)),103)" +
                " " +
                " SELECT @tmpdate = @date" +
                " " +
                " SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END" +
                " " +
                " SELECT @tmpdate = DATEADD(yy, @years, @tmpdate)" +
                " " +
                " SELECT @years", rowIndex, nameOfTable) < TryParseInt('18', '18') && GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null') || GetValueByControlType($('#' + nameOfTable + 'Incapaz' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $("a[href='#tabDatos_del_Tutor']").css('display', 'block'); } else { $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); }


    }
    //BusinessRuleId:1274, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2507, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divExpediente_MP').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));


    }
    //BusinessRuleId:2507, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2507, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divExpediente_MP').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));


    }
    //BusinessRuleId:2507, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2507, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divExpediente_MP').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));


    }
    //BusinessRuleId:2507, Attribute:0, Operation:Object, Event:SCREENOPENING

















    //BusinessRuleId:2863, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Cabello' + rowIndex));


    }
    //BusinessRuleId:2863, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2863, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Cabello' + rowIndex));


    }
    //BusinessRuleId:2863, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:2889, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
            $('#divPersona_Aparecio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex));
        } else { $('#divPersona_Aparecio').css('display', 'block'); }


    }
    //BusinessRuleId:2889, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2889, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
            $('#divPersona_Aparecio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex));
        } else { $('#divPersona_Aparecio').css('display', 'block'); }


    }
    //BusinessRuleId:2889, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2889, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
            $('#divPersona_Aparecio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex));
        } else { $('#divPersona_Aparecio').css('display', 'block'); }


    }
    //BusinessRuleId:2889, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2892, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
            $('#divFecha_de_Aparicion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));
            $('#divCon_Vida').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex));
        } else {
            $('#divFecha_de_Aparicion').css('display', 'block');
            $('#divCon_Vida').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex));
        }


    }
    //BusinessRuleId:2892, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2892, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
            $('#divFecha_de_Aparicion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));
            $('#divCon_Vida').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex));
        } else {
            $('#divFecha_de_Aparicion').css('display', 'block');
            $('#divCon_Vida').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex));
        }


    }
    //BusinessRuleId:2892, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2892, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
            $('#divFecha_de_Aparicion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));
            $('#divCon_Vida').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex));
        } else {
            $('#divFecha_de_Aparicion').css('display', 'block');
            $('#divCon_Vida').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex));
        }


    }
    //BusinessRuleId:2892, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2902, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) != TryParseInt('2', '2')) {
            $('#divPersona_Desaparecida').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex));
        } else { $('#divPersona_Desaparecida').css('display', 'block'); }


    }
    //BusinessRuleId:2902, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2902, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) != TryParseInt('2', '2')) {
            $('#divPersona_Desaparecida').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex));
        } else { $('#divPersona_Desaparecida').css('display', 'block'); }


    }
    //BusinessRuleId:2902, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2902, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) != TryParseInt('2', '2')) {
            $('#divPersona_Desaparecida').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex));
        } else { $('#divPersona_Desaparecida').css('display', 'block'); }


    }
    //BusinessRuleId:2902, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2179, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            $('#divEs_victima').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'block');
        } else {
            $('#divEs_victima').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex));
        }


    }
    //BusinessRuleId:2179, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2179, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            $('#divEs_victima').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'block');
        } else {
            $('#divEs_victima').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex));
        }


    }
    //BusinessRuleId:2179, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2942, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divExpediente_MASC').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


    }
    //BusinessRuleId:2942, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2942, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divExpediente_MASC').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


    }
    //BusinessRuleId:2942, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2942, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divExpediente_MASC').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


    }
    //BusinessRuleId:2942, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2986, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');


    }
    //BusinessRuleId:2986, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2986, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');


    }
    //BusinessRuleId:2986, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2986, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');


    }
    //BusinessRuleId:2986, Attribute:0, Operation:Object, Event:SCREENOPENING



























    //BusinessRuleId:2720, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_calle_de_los_hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));

    }
    //BusinessRuleId:2720, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2720, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_calle_de_los_hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));

    }
    //BusinessRuleId:2720, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2494, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Edad_del_Tutor" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex)); }

    }
    //BusinessRuleId:2494, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2494, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Edad_del_Tutor" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex)); }

    }
    //BusinessRuleId:2494, Attribute:0, Operation:Object, Event:SCREENOPENING



















    //BusinessRuleId:3594, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex), nameOfTable, rowIndex) == TryParseInt('5', '5') && GetValueByControlType($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divPreferencia_Sexual').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
            $('#divPreferencia_Sexual').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
        }

    }
    //BusinessRuleId:3594, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3594, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex), nameOfTable, rowIndex) == TryParseInt('5', '5') && GetValueByControlType($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divPreferencia_Sexual').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
            $('#divPreferencia_Sexual').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
        }

    }
    //BusinessRuleId:3594, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3594, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex), nameOfTable, rowIndex) == TryParseInt('5', '5') && GetValueByControlType($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divPreferencia_Sexual').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
            $('#divPreferencia_Sexual').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));
        }

    }
    //BusinessRuleId:3594, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3600, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        var valor = $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Municipio WHERE Estado = FLD[Estado_de_Nacimiento]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Municipio WHERE Estado = FLD[Estado_de_Nacimiento]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).val(valor).trigger('change');

    }
    //BusinessRuleId:3600, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3600, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        var valor = $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Municipio WHERE Estado = FLD[Estado_de_Nacimiento]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Municipio WHERE Estado = FLD[Estado_de_Nacimiento]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).val(valor).trigger('change');

    }
    //BusinessRuleId:3600, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3600, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        var valor = $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Municipio WHERE Estado = FLD[Estado_de_Nacimiento]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Municipio WHERE Estado = FLD[Estado_de_Nacimiento]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).val(valor).trigger('change');

    }
    //BusinessRuleId:3600, Attribute:0, Operation:Object, Event:SCREENOPENING



    //BusinessRuleId:3628, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divLocalidad_del_Tutor').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Localidad_del_Tutor' + rowIndex));
        $('#divOriginario_de_T').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de_T' + rowIndex));


    }
    //BusinessRuleId:3628, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3628, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divLocalidad_del_Tutor').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Localidad_del_Tutor' + rowIndex));
        $('#divOriginario_de_T').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de_T' + rowIndex));


    }
    //BusinessRuleId:3628, Attribute:0, Operation:Object, Event:SCREENOPENING

    

    

    //BusinessRuleId:3851, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));


    }
    //BusinessRuleId:3851, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3851, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));


    }
    //BusinessRuleId:3851, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3851, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));


    }
    //BusinessRuleId:3851, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3854, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divGrupo_al_que_pertenece').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
            $('#divGrupo_al_que_pertenece').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
        }


    }
    //BusinessRuleId:3854, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3854, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divGrupo_al_que_pertenece').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
            $('#divGrupo_al_que_pertenece').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
        }


    }
    //BusinessRuleId:3854, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3854, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divGrupo_al_que_pertenece').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
            $('#divGrupo_al_que_pertenece').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));
        }


    }
    //BusinessRuleId:3854, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2234, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Incapaz' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        } else {
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        }


    }
    //BusinessRuleId:2234, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2234, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Incapaz' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        } else {
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        }


    }
    //BusinessRuleId:2234, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3903, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (TryParseInt('107', '107') == EvaluaQuery("SELECT GLOBAL[USERROLEID]", rowIndex, nameOfTable)) {
            DisabledControl($("#" + nameOfTable + "Nombre" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Sexo" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_Civil" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Ocupacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Telefono" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Extension" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Celular" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Correo_Electronico" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Incapaz" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Incapaz' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_Completo_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Edad_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Sexo_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_Civil_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Ocupacion_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Localidad_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Localidad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Telefono_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Extension_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Celular_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Correo_Electronico_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Compareciente" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_de_Nacimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Titulo_del_Hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Narrativa_Breve_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Prioridad_del_Hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_del_Hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_Aproximada_del_Hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_del_hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_del_Hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Entre_Calle_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Y_calle_de_los_hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Y_calle_de_los_hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_lugar_del_hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_lugar_del_hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_de_Origen_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de_T" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de_T' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Causa_de_Interrupcion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Datos_Insuficientes" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Causal" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Causal' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Actualizacion_de_Sobreseimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Se_Informaron_sobre_sus_Derechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Se_Informo_sobre_el_Procedimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informo_sobre_el_Procedimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Datos_Confidenciales" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Confidenciales' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Inimputabilidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "RFC" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "RFC_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'RFC_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Situacion_de_Vulnerabilidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Grupo_al_que_pertenece" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Etnia" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "No_de_Hijos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Religion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Servicio_Medico" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad_" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Especialidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estudios_Superiores" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Idioma" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Idioma' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calidad_Migratoria" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_de_Nacimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_de_Nacimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Dialecto" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Dialecto' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_de_Involucrado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Especifique" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Mental" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Fisica" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Sensorial" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Psicosocial" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Involucrado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Involucrado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Involucrado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Correo_Electronico" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Telefonico" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Redes_Sociales" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Involucrado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio_Adicciones" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Adicciones' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Documento_Extraviado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Documento_Extraviado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Documento_Extraviado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Q_Q_R_O_" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Es_victima" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_Corporacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Corporacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Incompleto" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Incompleto' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Peso" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Peso' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatura" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatura' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Padecimiento_de_Enfermedad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_Cara" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cara' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Cejas" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tamano_de_Cejas" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Cantidad_Cabello" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Implantacion_Cabello" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Complexion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Complexion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Color_Piel" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Color_Piel' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Frente" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Frente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Largo_de_Cabello" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Color_Cabello" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Color_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calvicie" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calvicie' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Color_Ojos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Color_Ojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tamano_de_Ojos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_Ojos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Ojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Anteojos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Anteojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_de_Nariz" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tamano_Nariz" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Nariz' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Labios" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Labios' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Boca" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Boca' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Grosor_de_Labios" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Menton" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Menton' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_de_Menton" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Menton' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Barba" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Barba' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_Orejas" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Orejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tamano_Orejas" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Orejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_Lobulo" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Bigote" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Bigote' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Senas_Particulares" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Senas_Particulares' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Imagen_Tatuaje" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Situacion_Fisica" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_Fisica' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Otras_Senas_Particulares" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Persona_Moral" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calidad_Juridica" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Razon_Social" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombres2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombres2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_Completo2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Sexo2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Sexo2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "ID_Estado_Institucion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_de_Cabello" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Coordenada_X" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Coordenada_Y" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Gravidez" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Persona_Desaparecida" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Persona_Aparecio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Aparicion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Con_Vida" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Expediente_MASC" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MASC' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Preferencia_Sexual" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex)); }
        } else {}

    }
    //BusinessRuleId:3903, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4081, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Escolaridad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('6', '6')) {
            $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
        }


    }
    //BusinessRuleId:4081, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4081, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Escolaridad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('6', '6')) {
            $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
        }


    }
    //BusinessRuleId:4081, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4081, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Escolaridad' + rowIndex), nameOfTable, rowIndex) == TryParseInt('6', '6')) {
            $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
        } else {
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
        }


    }
    //BusinessRuleId:4081, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:4085, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $("a[href='#tabDesestimacion']").css('display', 'none');
        DisabledControl($("#" + nameOfTable + "Causa_de_Interrupcion" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Datos_Insuficientes" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Causal" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Causal' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Actualizacion_de_Sobreseimiento" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex)); }


    }
    //BusinessRuleId:4085, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4085, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $("a[href='#tabDesestimacion']").css('display', 'none');
        DisabledControl($("#" + nameOfTable + "Causa_de_Interrupcion" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Datos_Insuficientes" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Causal" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Causal' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Actualizacion_de_Sobreseimiento" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex)); }


    }
    //BusinessRuleId:4085, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4085, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $("a[href='#tabDesestimacion']").css('display', 'none');
        DisabledControl($("#" + nameOfTable + "Causa_de_Interrupcion" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Datos_Insuficientes" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Causal" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Causal' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Actualizacion_de_Sobreseimiento" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex)); }


    }
    //BusinessRuleId:4085, Attribute:0, Operation:Object, Event:SCREENOPENING









    

    

    

    



    //BusinessRuleId:4517, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divIncapaz').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Incapaz' + rowIndex));
        $('#divSe_Informaron_sobre_sus_Derechos').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex));


    }
    //BusinessRuleId:4517, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4517, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divIncapaz').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Incapaz' + rowIndex));
        $('#divSe_Informaron_sobre_sus_Derechos').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex));


    }
    //BusinessRuleId:4517, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4517, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divIncapaz').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Incapaz' + rowIndex));
        $('#divSe_Informaron_sobre_sus_Derechos').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex));


    }
    //BusinessRuleId:4517, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4375, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (TryParseInt('107', '107') == EvaluaQuery("SELECT GLOBAL[USERROLEID]", rowIndex, nameOfTable)) {
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Sexo" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_Civil" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Ocupacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Telefono" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Extension" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Celular" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Correo_Electronico" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Incapaz" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Incapaz' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_Completo_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Edad_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Sexo_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_Civil_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Ocupacion_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Localidad_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Localidad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Telefono_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Extension_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Celular_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Correo_Electronico_del_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Compareciente" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_de_Nacimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Titulo_del_Hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Narrativa_Breve_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Prioridad_del_Hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_del_Hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_Aproximada_del_Hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_del_hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_del_Hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Entre_Calle_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Y_calle_de_los_hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Y_calle_de_los_hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud_de_los_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_lugar_del_hecho" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_lugar_del_hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_de_Origen_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de_T" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de_T' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Causa_de_Interrupcion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Datos_Insuficientes" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Causal" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Causal' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Actualizacion_de_Sobreseimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Se_Informaron_sobre_sus_Derechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Se_Informo_sobre_el_Procedimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informo_sobre_el_Procedimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Datos_Confidenciales" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Confidenciales' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Inimputabilidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "RFC" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "RFC_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'RFC_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Situacion_de_Vulnerabilidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Grupo_al_que_pertenece" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Etnia" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "No_de_Hijos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Religion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Servicio_Medico" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad_" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Especialidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estudios_Superiores" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Idioma" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Idioma' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calidad_Migratoria" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_de_Nacimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_de_Nacimiento" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Dialecto" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Dialecto' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_de_Involucrado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Especifique" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Mental" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Fisica" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Sensorial" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Psicosocial" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud_Tutor" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_Hechos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Involucrado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Involucrado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Involucrado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Correo_Electronico" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Telefonico" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Redes_Sociales" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Involucrado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Involucrado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio_Adicciones" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Adicciones' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Documento_Extraviado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Documento_Extraviado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Documento_Extraviado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Q_Q_R_O_" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Es_victima" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_Corporacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Corporacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Incompleto" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Incompleto' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Peso" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Peso' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatura" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatura' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Padecimiento_de_Enfermedad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_Cara" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cara' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Cejas" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tamano_de_Cejas" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Cantidad_Cabello" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Implantacion_Cabello" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Complexion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Complexion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Color_Piel" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Color_Piel' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Frente" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Frente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Largo_de_Cabello" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Color_Cabello" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Color_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calvicie" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calvicie' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Color_Ojos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Color_Ojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tamano_de_Ojos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_Ojos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Ojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Anteojos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Anteojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_de_Nariz" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tamano_Nariz" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Nariz' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Labios" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Labios' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Boca" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Boca' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Grosor_de_Labios" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Menton" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Menton' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_de_Menton" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Menton' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Barba" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Barba' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_Orejas" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Orejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tamano_Orejas" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Orejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_Lobulo" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Bigote" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Bigote' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Senas_Particulares" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Senas_Particulares' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Imagen_Tatuaje" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Situacion_Fisica" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_Fisica' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Otras_Senas_Particulares" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Persona_Moral" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calidad_Juridica" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Razon_Social" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombres2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombres2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_Completo2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Sexo2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Sexo2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad2" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "ID_Estado_Institucion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_de_Cabello" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Coordenada_X" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Coordenada_Y" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Gravidez" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Persona_Desaparecida" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Persona_Aparecio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Aparecio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Aparicion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Con_Vida" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Con_Vida' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Expediente_MASC" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MASC' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Preferencia_Sexual" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex)); }
            if ('true' == 'true') {
                $('#divAdicciones_de_Involucrado a').attr('disabled', 'disabled');
                $('#divAdicciones_de_Involucrado a').css("pointer-events", "none");
            } else {
                $('#divAdicciones_de_Involucrado a').attr('disabled', '');
                $('#divAdicciones_de_Involucrado a').css("pointer-events", "all");
            }
            if ('true' == 'true') {
                $('#divLugares_que_Frecuenta a').attr('disabled', 'disabled');
                $('#divLugares_que_Frecuenta a').css("pointer-events", "none");
            } else {
                $('#divLugares_que_Frecuenta a').attr('disabled', '');
                $('#divLugares_que_Frecuenta a').css("pointer-events", "all");
            }
            if ('true' == 'true') {
                $('#divDatos_Personales_Adicionales a').attr('disabled', 'disabled');
                $('#divDatos_Personales_Adicionales a').css("pointer-events", "none");
            } else {
                $('#divDatos_Personales_Adicionales a').attr('disabled', '');
                $('#divDatos_Personales_Adicionales a').css("pointer-events", "all");
            }
            if ('true' == 'true') {
                $('#divOtras_Identificaciones a').attr('disabled', 'disabled');
                $('#divOtras_Identificaciones a').css("pointer-events", "none");
            } else {
                $('#divOtras_Identificaciones a').attr('disabled', '');
                $('#divOtras_Identificaciones a').css("pointer-events", "all");
            }
            if ('true' == 'true') {
                $('#divOtros_Domicilios a').attr('disabled', 'disabled');
                $('#divOtros_Domicilios a').css("pointer-events", "none");
            } else {
                $('#divOtros_Domicilios a').attr('disabled', '');
                $('#divOtros_Domicilios a').css("pointer-events", "all");
            }
        } else {}

    }
    //BusinessRuleId:4375, Attribute:0, Operation:Object, Event:SCREENOPENING

    























//BusinessRuleId:1857, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));$('#divNombre_Completo_del_Tutor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));

}
//BusinessRuleId:1857, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1857, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));$('#divNombre_Completo_del_Tutor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));

}
//BusinessRuleId:1857, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4744, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:4744, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4744, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:4744, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4744, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));

}
//BusinessRuleId:4744, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:2182, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Persona_Moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divQ_Q_R_O_').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex)); $('#divQ_Q_R_O_').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));} else { $('#divQ_Q_R_O_').css('display', 'block'); $('#divQ_Q_R_O_').css('display', 'block');}

}
//BusinessRuleId:2182, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2182, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Persona_Moral' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divQ_Q_R_O_').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex)); $('#divQ_Q_R_O_').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));} else { $('#divQ_Q_R_O_').css('display', 'block'); $('#divQ_Q_R_O_').css('display', 'block');}

}
//BusinessRuleId:2182, Attribute:0, Operation:Object, Event:SCREENOPENING



if(operation == 'New' || operation == 'Update'){
    if( GetValueByControlType($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true')) { 
        $(".div-titulo,#divMapa").hide();
    } else {
        $(".div-titulo,#divMapa").show();
    }
}



//BusinessRuleId:4746, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divNombre').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); $('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divOcupacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));$('#divPais_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));$('#divEstado_de_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));$('#divGravidez').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Gravidez' + rowIndex));} else {}

}
//BusinessRuleId:4746, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4746, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divNombre').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); $('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divOcupacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));$('#divPais_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));$('#divEstado_de_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));$('#divGravidez').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Gravidez' + rowIndex));} else {}

}
//BusinessRuleId:4746, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4746, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divNombre').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));$('#divApellido_Paterno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));$('#divApellido_Materno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); $('#divSexo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));$('#divOcupacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));$('#divPais_de_Nacimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));$('#divEstado_de_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));$('#divGravidez').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Gravidez' + rowIndex));} else {}

}
//BusinessRuleId:4746, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3713, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divOriginario_de').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));$('#divOriginario_de_T').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_T' + rowIndex));

}
//BusinessRuleId:3713, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3713, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divOriginario_de').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));$('#divOriginario_de_T').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_T' + rowIndex));

}
//BusinessRuleId:3713, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4111, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("SELECT canalizado FROM Detalle_de_Datos_Generales WHERE Clave = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Sexo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_Civil" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nacionalidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Escolaridad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ocupacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Telefono" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));}DisabledControl($("#" + nameOfTable + "Extension" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex));}DisabledControl($("#" + nameOfTable + "Celular" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));}DisabledControl($("#" + nameOfTable + "Correo_Electronico" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));}DisabledControl($("#" + nameOfTable + "Incapaz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Incapaz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Edad_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Sexo_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_Civil_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nacionalidad_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Escolaridad_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ocupacion_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Localidad_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Telefono_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Extension_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Celular_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Correo_Electronico_del_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Compareciente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais_de_Nacimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Originario_de" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));}DisabledControl($("#" + nameOfTable + "Titulo_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Narrativa_Breve_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Prioridad_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_Aproximada_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais_del_hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Entre_Calle_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Y_calle_de_los_hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Y_calle_de_los_hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud_de_los_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_lugar_del_hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_lugar_del_hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais_de_Origen_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Originario_de_T" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_T' + rowIndex));}DisabledControl($("#" + nameOfTable + "Causa_de_Interrupcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Datos_Insuficientes" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));}DisabledControl($("#" + nameOfTable + "Causal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Causal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Actualizacion_de_Sobreseimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Se_Informaron_sobre_sus_Derechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Se_Informo_sobre_el_Procedimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_sobre_el_Procedimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Datos_Confidenciales" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Confidenciales' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Inimputabilidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));}DisabledControl($("#" + nameOfTable + "RFC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));}DisabledControl($("#" + nameOfTable + "CURP_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "RFC_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'RFC_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Situacion_de_Vulnerabilidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grupo_al_que_pertenece" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));}DisabledControl($("#" + nameOfTable + "Etnia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Etnia' + rowIndex));}DisabledControl($("#" + nameOfTable + "No_de_Hijos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'No_de_Hijos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Religion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Religion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Servicio_Medico" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Servicio_Medico' + rowIndex));}DisabledControl($("#" + nameOfTable + "Especialidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estudios_Superiores" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));}DisabledControl($("#" + nameOfTable + "Idioma" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calidad_Migratoria" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_de_Nacimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio_de_Nacimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Dialecto" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Dialecto' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_de_Involucrado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Especifique" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));}DisabledControl($("#" + nameOfTable + "Discapacidad_Mental" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));}DisabledControl($("#" + nameOfTable + "Discapacidad_Fisica" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));}DisabledControl($("#" + nameOfTable + "Discapacidad_Sensorial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Discapacidad_Psicosocial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud_Tutor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Tutor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Poblacion_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia_Hechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Hechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_identificacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Telefonico" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));}DisabledControl($("#" + nameOfTable + "Redes_Sociales" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Redes_Sociales' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Folio_Adicciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Adicciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Documento_Extraviado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Documento_Extraviado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Q_Q_R_O_" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));}DisabledControl($("#" + nameOfTable + "Es_victima" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Es_victima' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio_Corporacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Incompleto" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Incompleto' + rowIndex));}DisabledControl($("#" + nameOfTable + "Peso" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatura" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));}DisabledControl($("#" + nameOfTable + "Padecimiento_de_Enfermedad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Cara" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Cejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_de_Cejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Cantidad_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Implantacion_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Complexion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Piel" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));}DisabledControl($("#" + nameOfTable + "Frente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Largo_de_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calvicie" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_de_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Anteojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Nariz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_Nariz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Labios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Boca" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grosor_de_Labios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Menton" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Menton" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));}DisabledControl($("#" + nameOfTable + "Barba" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Orejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_Orejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_Lobulo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Bigote" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));}DisabledControl($("#" + nameOfTable + "Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Imagen_Tatuaje" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));}DisabledControl($("#" + nameOfTable + "Situacion_Fisica" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));}DisabledControl($("#" + nameOfTable + "Otras_Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_Moral" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Moral' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calidad_Juridica" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));}DisabledControl($("#" + nameOfTable + "Razon_Social" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Razon_Social' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombres2" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombres2' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Paterno2" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex));}DisabledControl($("#" + nameOfTable + "Apellido_Materno2" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno2' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo2" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));}DisabledControl($("#" + nameOfTable + "Sexo2" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo2' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nacionalidad2" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad2' + rowIndex));}DisabledControl($("#" + nameOfTable + "Escolaridad2" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad2' + rowIndex));}DisabledControl($("#" + nameOfTable + "ID_Estado_Institucion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Coordenada_X" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Coordenada_X' + rowIndex));}DisabledControl($("#" + nameOfTable + "Coordenada_Y" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Coordenada_Y' + rowIndex));}DisabledControl($("#" + nameOfTable + "Gravidez" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Gravidez' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_Desaparecida" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Desaparecida' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_Aparecio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Aparecio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_de_Aparicion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Aparicion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Con_Vida" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Con_Vida' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MASC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));}DisabledControl($("#" + nameOfTable + "Preferencia_Sexual" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Preferencia_Sexual' + rowIndex));} DisabledControl($("#" + nameOfTable + "Pais_de_Nacimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Es_victima" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Es_victima' + rowIndex));}DisabledControl($("#" + nameOfTable + "Incompleto" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Incompleto' + rowIndex));}DisabledControl($("#" + nameOfTable + "Gravidez" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Gravidez' + rowIndex));} DisabledControl($("#" + nameOfTable + "Peso" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Peso' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estatura" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estatura' + rowIndex));}DisabledControl($("#" + nameOfTable + "Padecimiento_de_Enfermedad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Cara" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Cara' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Cejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Cejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_de_Cejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Cantidad_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Implantacion_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Complexion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Complexion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Piel" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Piel' + rowIndex));}DisabledControl($("#" + nameOfTable + "Frente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Frente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Largo_de_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Cabello' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calvicie" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calvicie' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_de_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_de_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Ojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Ojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Anteojos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Anteojos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Nariz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_Nariz" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Nariz' + rowIndex));}DisabledControl($("#" + nameOfTable + "Labios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Labios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Boca" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Boca' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grosor_de_Labios" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));}DisabledControl($("#" + nameOfTable + "Menton" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Menton' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Menton" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));}DisabledControl($("#" + nameOfTable + "Barba" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Barba' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Orejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Orejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tamano_Orejas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_Lobulo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Bigote" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Bigote' + rowIndex));}DisabledControl($("#" + nameOfTable + "Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Imagen_Tatuaje" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));}DisabledControl($("#" + nameOfTable + "Situacion_Fisica" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));}DisabledControl($("#" + nameOfTable + "Otras_Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_de_Cabello" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_de_Cabello' + rowIndex));}} else {}

}
//BusinessRuleId:4111, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4712, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Con_Vida' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divEstado_de_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));} else { $('#divEstado_de_Involucrado').css('display', 'block');}

}
//BusinessRuleId:4712, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4712, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Con_Vida' + rowIndex),nameOfTable,rowIndex)==TryParseInt('2', '2') ) { $('#divEstado_de_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));} else { $('#divEstado_de_Involucrado').css('display', 'block');}

}
//BusinessRuleId:4712, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:4714, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select count(*) from Detalle_de_Relaciones r inner join Detalle_de_Datos_Generales dg on dg.Clave = r.Involucrado where "
+" (dg.Es_victima = 1 or dg.Tipo_de_Compareciente = 2) and Involucrado = FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { DisabledControl($("#" + nameOfTable + "Tipo_de_Compareciente" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));}DisabledControl($("#" + nameOfTable + "Es_victima" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Es_victima' + rowIndex));}} else {}

}
//BusinessRuleId:4714, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1911, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Incapaz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_calle_de_los_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_lugar_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_T' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_sobre_el_Procedimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Confidenciales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Etnia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No_de_Hijos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Religion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Servicio_Medico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dialecto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Redes_Sociales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Adicciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_victima' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Incompleto' + rowIndex));

}
//BusinessRuleId:1911, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1911, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Incapaz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_calle_de_los_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_lugar_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_T' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_sobre_el_Procedimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Confidenciales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Etnia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No_de_Hijos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Religion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Servicio_Medico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dialecto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Redes_Sociales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Adicciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_victima' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Incompleto' + rowIndex));

}
//BusinessRuleId:1911, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1911, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Incapaz' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localidad_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Titulo_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_calle_de_los_hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_lugar_del_hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais_de_Origen_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Originario_de_T' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Interrupcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Insuficientes' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Actualizacion_de_Sobreseimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sobre_sus_Derechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_sobre_el_Procedimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Datos_Confidenciales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'CURP_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'RFC_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Situacion_de_Vulnerabilidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_al_que_pertenece' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Etnia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No_de_Hijos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Religion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Servicio_Medico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Idioma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Dialecto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_de_Domicilio_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Tutor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Hechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Redes_Sociales' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Adicciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Documento_Extraviado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Es_victima' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Incompleto' + rowIndex));

}
//BusinessRuleId:1911, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}

function EjecutarValidacionesAntesDeGuardar() {
    var result = true;

    //Validar RFC
    var v = $('#' + nameOfTable + 'RFC' + rowIndex).val();
    if (v != "") {
        var valid = '^(([A-Z]|[a-z]){4})([0-9]{6})((([A-Z]|[a-z]|[0-9]){3}))';
        var validRfc = new RegExp(valid);
        var matchArray = v.match(validRfc);
        if (matchArray == null || v.length > 13) {
            alert("El formato del RFC es incorrecto.");
            $('#' + nameOfTable + 'RFC' + rowIndex).attr("placeholder", "El formato del RFC es incorrecto.").focus();
            return false;
        }
    }


    //Validar CURP 
    var v = $('#' + nameOfTable + 'CURP' + rowIndex).val();
    if (v != "") {
        var valid = /^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/,
            validado = v.toUpperCase().match(valid);

        if (!validado) { //Coincide con el formato general?
            alert("El formato del CURP es incorrecto.");
            $('#' + nameOfTable + 'CURP' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").focus();
            return false;
        }
    }

    //Validar dependiendo del tipo de identificacion seleccionada.
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
                alert("El formato del CURP es incorrecto.");
                $('#' + nameOfTable + 'CURP' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").focus();
                return false;
            }
        }
    }


    //Validar RFC_Tutor
    var v = $('#' + nameOfTable + 'RFC_Tutor' + rowIndex).val();
    if (v != "") {
        var valid = '^(([A-Z]|[a-z]){4})([0-9]{6})((([A-Z]|[a-z]|[0-9]){3}))';
        var validRfc = new RegExp(valid);
        var matchArray = v.match(validRfc);
        if (matchArray == null || v.length > 13) {
            alert("El formato del RFC es incorrecto.");
            $('#' + nameOfTable + 'RFC_Tutor' + rowIndex).attr("placeholder", "El formato del RFC es incorrecto.").focus();
            return false;
        }
    }

    //Validar CURP_Tutor
    var v = $('#' + nameOfTable + 'CURP_Tutor' + rowIndex).val();
    if (v != "") {
        var valid = /^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/,
            validado = v.toUpperCase().match(valid);

        if (!validado) { //Coincide con el formato general?
            alert("El formato del CURP del Tutor es incorrecto.");
            $('#' + nameOfTable + 'CURP_Tutor' + rowIndex).attr("placeholder", "El formato del CURP del Tutor es incorrecto.").focus();
            return false;
        }
    }

    //Validar dependiendo del tipo de identificacion seleccionada.
    var tipoVal = $('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex).val();
    var NumeroVal = $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex).val();
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
                alert("El formato del CURP del Tutor es incorrecto.");
                $('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex).attr("placeholder", "El formato del CURP del Tutor es incorrecto.").focus();
                return false;
            }
        }
    }























    //BusinessRuleId:2000, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex), EvaluaQuery(" SELECT 'FLD[Nombres2]' + ' ' + 'FLD[Apellido_Paterno2]' + ' ' + 'FLD[Apellido_Materno2]'", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery("SELECT 'FLD[Nombre]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


    }
    //BusinessRuleId:2000, Attribute:2, Operation:Object, Event:BEFORESAVING

    //BusinessRuleId:2000, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'Update') {
        AsignarValor($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex), EvaluaQuery(" SELECT 'FLD[Nombres2]' + ' ' + 'FLD[Apellido_Paterno2]' + ' ' + 'FLD[Apellido_Materno2]'", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery("SELECT 'FLD[Nombre]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


    }
    //BusinessRuleId:2000, Attribute:2, Operation:Object, Event:BEFORESAVING





















    //BusinessRuleId:2604, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'New') {
        if (EvaluaQuery("EXEC uspGetTipoComparecienteAlta GLOBAL[SpartanOperationId]", rowIndex, nameOfTable) == TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            alert(DecodifyText(' Solo puede existir un Tipo Compareciente como denunciante. Favor de revisar.', rowIndex, nameOfTable));

            result = false;
            AsignarValor($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), 'null');
        } else {}


    }
    //BusinessRuleId:2604, Attribute:2, Operation:Object, Event:BEFORESAVING

    //BusinessRuleId:2605, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'Update') {
        if (EvaluaQuery("EXEC uspGetTipoComparecienteEditar GLOBAL[SpartanOperationId], FLDD[lblClave]", rowIndex, nameOfTable) == TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) {
            alert(DecodifyText('Solo puede existir un Tipo Compareciente como denunciante. Favor de revisar.', rowIndex, nameOfTable));

            result = false;
            AsignarValor($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), 'null');
        } else {}


    }
    //BusinessRuleId:2605, Attribute:2, Operation:Object, Event:BEFORESAVING

    







//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}

function EjecutarValidacionesDespuesDeGuardar() {




















    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('3', '3')) {
            $('#divMunicipio_Corporacion').css('display', 'block');
            $('#divCorporacion').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divEstado_de_Involucrado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
        } else {}
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('3', '3')) {
            $('#divMunicipio_Corporacion').css('display', 'block');
            $('#divCorporacion').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divEstado_de_Involucrado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
        } else {}
    }

    //BusinessRuleId:1914, Attribute:263830, Operation:Field, Event:None
    if (operation == 'New') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('2', '2')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divQ_Q_R_O_').css('display', 'block');
            $('#divPersona_Moral').css('display', 'block');
        } else {
            $('#divQ_Q_R_O_').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        }
    }
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('2', '2')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divQ_Q_R_O_').css('display', 'block');
            $('#divPersona_Moral').css('display', 'block');
        } else {
            $('#divQ_Q_R_O_').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        }
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('2', '2')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $('#divQ_Q_R_O_').css('display', 'block');
            $('#divPersona_Moral').css('display', 'block');
        } else {
            $('#divQ_Q_R_O_').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex));
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
        }
    }

    //BusinessRuleId:1918, Attribute:263830, Operation:Field, Event:None

    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('4', '4')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        } else {}
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('4', '4')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Involucrado' + rowIndex));
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        } else {}
    }

    //BusinessRuleId:1917, Attribute:263830, Operation:Field, Event:None

    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('1', '1')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        } else {}
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('1', '1')) {
            $('#divOcupacion').css('display', 'block');
            $('#divEstado_de_Involucrado').css('display', 'block');
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'block');
            $('#divMunicipio_Corporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_Corporacion' + rowIndex));
            $('#divCorporacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        } else {}
    }


    if (operation == 'New') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('1', '1')) { $('#divEs_victima').css('display', 'block'); } else {
            $('#divEs_victima').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex));
        }
    }
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('1', '1')) { $('#divEs_victima').css('display', 'block'); } else {
            $('#divEs_victima').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex));
        }
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex).val() == TryParseInt('1', '1')) { $('#divEs_victima').css('display', 'block'); } else {
            $('#divEs_victima').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Es_victima' + rowIndex));
        }
    }

    //if(operation == 'Update'){

















    //BusinessRuleId:2513, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]')) == TryParseInt('3', '3')) { EvaluaQuery("update Detalle_de_Datos_Generales set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); } else {}


    }
    //BusinessRuleId:2513, Attribute:2, Operation:Object, Event:AFTERSAVING

    //BusinessRuleId:2513, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'Update') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]')) == TryParseInt('3', '3')) { EvaluaQuery("update Detalle_de_Datos_Generales set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); } else {}


    }
    //BusinessRuleId:2513, Attribute:2, Operation:Object, Event:AFTERSAVING

    











    //BusinessRuleId:3573, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        EvaluaQuery("UPDATE Detalle_de_Datos_Generales SET Nombre_Completo = Nombre + (CASE WHEN Apellido_Paterno IS null THEN '' ELSE ' ' + Apellido_Paterno END) + (CASE WHEN Apellido_Materno IS null THEN '' ELSE ' ' + Apellido_Materno END) WHERE Clave = GLOBAL[KeyValueInserted]	", rowIndex, nameOfTable);

    }
    //BusinessRuleId:3573, Attribute:2, Operation:Object, Event:AFTERSAVING

    //BusinessRuleId:3574, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'Update') {
        EvaluaQuery("UPDATE Detalle_de_Datos_Generales SET Nombre_Completo = Nombre + (CASE WHEN Apellido_Paterno IS null THEN '' ELSE ' ' + Apellido_Paterno END) + (CASE WHEN Apellido_Materno IS null THEN '' ELSE ' ' + Apellido_Materno END) WHERE Clave = FLDD[lblClave]", rowIndex, nameOfTable);

    }
    //BusinessRuleId:3574, Attribute:2, Operation:Object, Event:AFTERSAVING





    //BusinessRuleId:4120, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        EvaluaQuery("exec uspActualizadatosGeneracionExpediente GLOBAL[SpartanOperationId]", rowIndex, nameOfTable);


    }
    //BusinessRuleId:4120, Attribute:2, Operation:Object, Event:AFTERSAVING

    //BusinessRuleId:4120, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'Update') {
        EvaluaQuery("exec uspActualizadatosGeneracionExpediente GLOBAL[SpartanOperationId]", rowIndex, nameOfTable);


    }
    //BusinessRuleId:4120, Attribute:2, Operation:Object, Event:AFTERSAVING

    //BusinessRuleId:1729, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { EvaluaQuery("  update Detalle_de_Datos_Generales"
+" 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]"
+" 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:1729, Attribute:2, Operation:Object, Event:AFTERSAVING









//BusinessRuleId:4797, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:4797, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:4797, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Edad' + rowIndex),nameOfTable,rowIndex)<TryParseInt('18', '18') && (
GetValueByControlType($('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') || 
GetValueByControlType($('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') || 
GetValueByControlType($('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') || 
GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') || 
GetValueByControlType($('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex),nameOfTable,rowIndex)==TryParseInt('null', 'null') )&& 
GetValueByControlType($('#' + nameOfTable + 'Q_Q_R_O_' + rowIndex),nameOfTable,rowIndex)==TryParseInt('false', 'false') ) { 
    alert(DecodifyText(' Favor de llenar los campos del Tutor para continuar.', rowIndex, nameOfTable));

result=false;} else {}


}
//BusinessRuleId:4797, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
    //
}

function EjecutarValidacionesAntesDeGuardarMRAdicciones_de_Involucrado(nameOfTable, rowIndex) {
    var result = true;

    //NEWBUSINESSRULE_BEFORESAVINGMR_Adicciones_de_Involucrado//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMRAdicciones_de_Involucrado(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Adicciones_de_Involucrado//
}

function EjecutarValidacionesAlEliminarMRAdicciones_de_Involucrado(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Adicciones_de_Involucrado//
    return result;
}

function EjecutarValidacionesNewRowMRAdicciones_de_Involucrado(nameOfTable, rowIndex) {
    var result = true;




    

    

    //NEWBUSINESSRULE_NEWROWMR_Adicciones_de_Involucrado//
    return result;
}

function EjecutarValidacionesEditRowMRAdicciones_de_Involucrado(nameOfTable, rowIndex) {
    var result = true;




    

    

    //NEWBUSINESSRULE_EDITROWMR_Adicciones_de_Involucrado//
    return result;
}

function EjecutarValidacionesAntesDeGuardarMRLugares_Frecuentes_Involucrado(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:4733, Attribute:265884, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Descripcion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { alert(DecodifyText('Para guardar un renglón debe capturar por lo menos un campo', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4733, Attribute:265884, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:4733, Attribute:265884, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Descripcion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { alert(DecodifyText('Para guardar un renglón debe capturar por lo menos un campo', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4733, Attribute:265884, Operation:Object, Event:BEFORESAVINGMR

//NEWBUSINESSRULE_BEFORESAVINGMR_Lugares_Frecuentes_Involucrado//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMRLugares_Frecuentes_Involucrado(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Lugares_Frecuentes_Involucrado//
}

function EjecutarValidacionesAlEliminarMRLugares_Frecuentes_Involucrado(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Lugares_Frecuentes_Involucrado//
    return result;
}

function EjecutarValidacionesNewRowMRLugares_Frecuentes_Involucrado(nameOfTable, rowIndex) {
    var result = true;




    //BusinessRuleId:2723, Attribute:265884, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2723, Attribute:265884, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2723, Attribute:265884, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2723, Attribute:265884, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Lugares_Frecuentes_Involucrado//
    return result;
}

function EjecutarValidacionesEditRowMRLugares_Frecuentes_Involucrado(nameOfTable, rowIndex) {
    var result = true;




    //BusinessRuleId:2723, Attribute:265884, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2723, Attribute:265884, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2723, Attribute:265884, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2723, Attribute:265884, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Lugares_Frecuentes_Involucrado//
    return result;
}

function EjecutarValidacionesAntesDeGuardarMRDatos_Personales_Adicionales_Involucrado(nameOfTable, rowIndex) {
    var result = true;
    
    // CODIGO_MANUAL: VALIDAR EL CORREO ANTES DE GUARDAR EL MR DE: Datos Personales Adicionales
	if(operation == 'New' || operation == 'Update'){
		let selector = $('#' + nameOfTable + 'Correo_Electronico' + rowIndex);
	    let email = selector.val();
	    let exp = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/);
        if(email != ''){
            if (exp.test(email) == false) {
                selector.attr("placeholder", "Correo electrónico no válido.").val("").focus().blur();
                result = false;
            }    
        }
	}
    
    // CODIGO_MANUAL: VALIDAR EL TELEFONO ANTES DE GUARDAR EL MR DE: Datos Personales Adicionales
	if(operation == 'New' || operation == 'Update'){
		let selector = $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex);
	    let tel = selector.val();
	    let exp = new RegExp(/^\d+$/);
        if(tel != ''){
            if (exp.test(tel) == false || tel.length != 10) {
                selector.attr("placeholder", "Telefóno no válido.").val("").focus().blur();
                result = false;
            }
        }
	}



//BusinessRuleId:4734, Attribute:265885, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Correo_Electronico' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Redes_Sociales' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Observaciones' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { alert(DecodifyText('Para guardar un renglón debe capturar por lo menos un campo', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4734, Attribute:265885, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:4734, Attribute:265885, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Correo_Electronico' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Redes_Sociales' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Observaciones' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { alert(DecodifyText('Para guardar un renglón debe capturar por lo menos un campo', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4734, Attribute:265885, Operation:Object, Event:BEFORESAVINGMR

//NEWBUSINESSRULE_BEFORESAVINGMR_Datos_Personales_Adicionales_Involucrado//
    return result;


}

function EjecutarValidacionesDespuesDeGuardarMRDatos_Personales_Adicionales_Involucrado(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Datos_Personales_Adicionales_Involucrado//

}

function EjecutarValidacionesAlEliminarMRDatos_Personales_Adicionales_Involucrado(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Datos_Personales_Adicionales_Involucrado//
    return result;
}

function EjecutarValidacionesNewRowMRDatos_Personales_Adicionales_Involucrado(nameOfTable, rowIndex) {
    var result = true;

    // CODIGO_MANUAL: SOLO PERMITIR 10 CARACTERES Y SOLO NUMEROS EL MR DE: Datos Personales Adicionales
    if(operation == 'New' || operation == 'Update'){
        let selector = $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex);
        selector.attr("maxlength", 10);
        selector.attr("oninput", "this.value = this.value.replace(/[^0-9]/g, '');");
    }
    //BusinessRuleId:2724, Attribute:265885, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2724, Attribute:265885, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2724, Attribute:265885, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2724, Attribute:265885, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Datos_Personales_Adicionales_Involucrado//
    return result;
}

function EjecutarValidacionesEditRowMRDatos_Personales_Adicionales_Involucrado(nameOfTable, rowIndex) {
    var result = true;

    // CODIGO_MANUAL: SOLO PERMITIR 10 CARACTERES Y SOLO NUMEROS EL MR DE: Datos Personales Adicionales
    if(operation == 'New' || operation == 'Update'){
        let selector = $('#' + nameOfTable + 'Numero_Telefonico' + rowIndex);
        selector.attr("maxlength", 10);
        selector.attr("oninput", "this.value = this.value.replace(/[^0-9]/g, '');");
    }
    //BusinessRuleId:2724, Attribute:265885, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2724, Attribute:265885, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2724, Attribute:265885, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2724, Attribute:265885, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Datos_Personales_Adicionales_Involucrado//
    return result;
}

function EjecutarValidacionesAntesDeGuardarMROtras_Identificaciones_Involucrado(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:4735, Attribute:265886, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Descripcion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { alert(DecodifyText('Para guardar un renglón debe capturar por lo menos un campo', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4735, Attribute:265886, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:4735, Attribute:265886, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Descripcion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { alert(DecodifyText('Para guardar un renglón debe capturar por lo menos un campo', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4735, Attribute:265886, Operation:Object, Event:BEFORESAVINGMR

//NEWBUSINESSRULE_BEFORESAVINGMR_Otras_Identificaciones_Involucrado//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMROtras_Identificaciones_Involucrado(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Otras_Identificaciones_Involucrado//
}

function EjecutarValidacionesAlEliminarMROtras_Identificaciones_Involucrado(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Otras_Identificaciones_Involucrado//
    return result;
}

function EjecutarValidacionesNewRowMROtras_Identificaciones_Involucrado(nameOfTable, rowIndex) {
    var result = true;








    //BusinessRuleId:2725, Attribute:265886, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2725, Attribute:265886, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2725, Attribute:265886, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2725, Attribute:265886, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Otras_Identificaciones_Involucrado//
    return result;
}

function EjecutarValidacionesEditRowMROtras_Identificaciones_Involucrado(nameOfTable, rowIndex) {
    var result = true;








    //BusinessRuleId:2725, Attribute:265886, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2725, Attribute:265886, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2725, Attribute:265886, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2725, Attribute:265886, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Otras_Identificaciones_Involucrado//
    return result;
}

function EjecutarValidacionesAntesDeGuardarMROtros_Domicilios_Involucrado(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:4736, Attribute:265887, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Estado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('undefined', 'undefined') && GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex),nameOfTable,rowIndex)==TryParseInt('undefined', 'undefined') && GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('undefined', 'undefined') && GetValueByControlType($('#' + nameOfTable + 'Colonia' + rowIndex),nameOfTable,rowIndex)==TryParseInt('undefined', 'undefined') && GetValueByControlType($('#' + nameOfTable + 'Codigo_Postal' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Calle' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Entre_Calle' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Y_Calle' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Numero_Exterior' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Numero_Interior' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Coordenada_X' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Coordenada_Y' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Observaciones' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { alert(DecodifyText('Para guardar un renglón debe capturar por lo menos un campo', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4736, Attribute:265887, Operation:Object, Event:BEFORESAVINGMR

//BusinessRuleId:4736, Attribute:265887, Operation:Object, Event:BEFORESAVINGMR
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Estado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('undefined', 'undefined') && GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex),nameOfTable,rowIndex)==TryParseInt('undefined', 'undefined') && GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex),nameOfTable,rowIndex)==TryParseInt('undefined', 'undefined') && GetValueByControlType($('#' + nameOfTable + 'Colonia' + rowIndex),nameOfTable,rowIndex)==TryParseInt('undefined', 'undefined') && GetValueByControlType($('#' + nameOfTable + 'Codigo_Postal' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Calle' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Entre_Calle' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Y_Calle' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Numero_Exterior' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Numero_Interior' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Coordenada_X' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Coordenada_Y' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') && GetValueByControlType($('#' + nameOfTable + 'Observaciones' + rowIndex),nameOfTable,rowIndex)==TryParseInt('', '') ) { alert(DecodifyText('Para guardar un renglón debe capturar por lo menos un campo', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4736, Attribute:265887, Operation:Object, Event:BEFORESAVINGMR

//NEWBUSINESSRULE_BEFORESAVINGMR_Otros_Domicilios_Involucrado//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMROtros_Domicilios_Involucrado(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Otros_Domicilios_Involucrado//
}

function EjecutarValidacionesAlEliminarMROtros_Domicilios_Involucrado(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Otros_Domicilios_Involucrado//
    return result;
}

function EjecutarValidacionesNewRowMROtros_Domicilios_Involucrado(nameOfTable, rowIndex) {
    var result = true;




    //BusinessRuleId:2726, Attribute:265887, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex));

    }
    //BusinessRuleId:2726, Attribute:265887, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2726, Attribute:265887, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex));

    }
    //BusinessRuleId:2726, Attribute:265887, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Otros_Domicilios_Involucrado//
    return result;
}

function EjecutarValidacionesEditRowMROtros_Domicilios_Involucrado(nameOfTable, rowIndex) {
    var result = true;




    //BusinessRuleId:2726, Attribute:265887, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex));

    }
    //BusinessRuleId:2726, Attribute:265887, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2726, Attribute:265887, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex));

    }
    //BusinessRuleId:2726, Attribute:265887, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Otros_Domicilios_Involucrado//
    return result;
}

//regla para los permitir solo nombres y limite de 50
$("#Nombre").keyup(function() {
    var str = $('#' + nameOfTable + 'Nombre' + rowIndex).val();
    if (str != "") {
        var regNUM = /^[ñÑa-zA-Z ]{1,50}$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Nombre' + rowIndex).val($('#' + nameOfTable + 'Nombre' + rowIndex).val().slice(0, -1));
        }
    }
});

$("#Apellido_Paterno").keyup(function() {
    var str = $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex).val();
    if (str != "") {
        var regNUM = /^[ñÑa-zA-Z ]{1,50}$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Apellido_Paterno' + rowIndex).val($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex).val().slice(0, -1));
        }
    }
});

$("#Apellido_Materno").keyup(function() {
    var str = $('#' + nameOfTable + 'Apellido_Materno' + rowIndex).val();
    if (str != "") {
        var regNUM = /^[ñÑa-zA-Z ]{1,50}$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Apellido_Materno' + rowIndex).val($('#' + nameOfTable + 'Apellido_Materno' + rowIndex).val().slice(0, -1));
        }
    }
});


$("#Codigo_Postal").keyup(function() {
    var str = $('#' + nameOfTable + 'Codigo_Postal' + rowIndex).val();
    if (str != "") {
        var regNUM = /^[0-9]{1,5}$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Codigo_Postal' + rowIndex).val($('#' + nameOfTable + 'Codigo_Postal' + rowIndex).val().slice(0, -1));
        }
    }
});

$("#Celular").keyup(function() {
    var str = $('#' + nameOfTable + 'Celular' + rowIndex).val();
    if (str != "") {
        var regNUM = /^[() 0-9 \-]{1,14}$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Celular' + rowIndex).val($('#' + nameOfTable + 'Celular' + rowIndex).val().slice(0, -1));
        } else {
            var formatted = str.replace(/^(\d{3})(\d{3})(\d{4}).*/, '($1) $2-$3');
            $('#' + nameOfTable + 'Celular' + rowIndex).val(formatted);
        }
    }
});

$("#Telefono").keyup(function() {
    var str = $('#' + nameOfTable + 'Telefono' + rowIndex).val();
    if (str != "") {
        var regNUM = /^[() 0-9 \-]{1,14}$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Telefono' + rowIndex).val($('#' + nameOfTable + 'Telefono' + rowIndex).val().slice(0, -1));
        } else {
            var formatted = str.replace(/^(\d{3})(\d{3})(\d{4}).*/, '($1) $2-$3');
            $('#' + nameOfTable + 'Telefono' + rowIndex).val(formatted);
        }
    }
});

$("#Peso").keyup(function() {
    var str = $('#' + nameOfTable + 'Peso' + rowIndex).val();
    if (str != "") {
        var regNUM = /^([0-9]+([.][0-9]*)?|[.][0-9]+)$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Peso' + rowIndex).val($('#' + nameOfTable + 'Peso' + rowIndex).val().slice(0, -1));
        }
    }
});


$("#Estatura").keyup(function() {
    var str = $('#' + nameOfTable + 'Estatura' + rowIndex).val();
    if (str != "") {
        var regNUM = /^([0-9]+([.][0-9]*)?|[.][0-9]+)$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Estatura' + rowIndex).val($('#' + nameOfTable + 'Estatura' + rowIndex).val().slice(0, -1));
        }
    }
});

$("#Numero_de_Identificacion").keyup(function() {
    var str = $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).val();
    if (str != "") {
        if (str.length > 20) {
            $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).val($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).val().slice(0, -1));
        }
    }
});

$("#Nombre_del_Tutor").keyup(function() {
    var str = $('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex).val();
    if (str != "") {
        var regNUM = /^[ñÑa-zA-Z ]{1,50}$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex).val($('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex).val().slice(0, -1));
        }
    }
});

$("#Apellido_Paterno_del_Tutor").keyup(function() {
    var str = $('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex).val();
    if (str != "") {
        var regNUM = /^[ñÑa-zA-Z ]{1,50}$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex).val($('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex).val().slice(0, -1));
        }
    }
});

$("#Apellido_Materno_del_Tutor").keyup(function() {
    var str = $('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex).val();
    if (str != "") {
        var regNUM = /^[ñÑa-zA-Z ]{1,50}$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex).val($('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex).val().slice(0, -1));
        }
    }
});




function CambiaPais(deesc) {
    debugger;
    $('#Pais').val(null).trigger('change');
    var control = $('#Pais');
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from pais where dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');

    control.select2('close');
    var data = AutoCompletePaisData;
    control.select2({ data: data });
    control.val(valorPaisId).trigger('change');

}

function CambiaEstado(deesc) {
    debugger;
    $('#Estado').val(null).trigger('change');
    var control = $('#Estado');
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Estado where pais = '" + $('#Pais').val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
    var data = AutoCompleteEstadoData;
    control.select2({ data: data });
    control.val(valorPaisId).trigger('change');

}




var poblacionP;

function CambiaMunicipio(deesc) {
    debugger;

    if (deesc.toLowerCase() == "Culiacán Rosales".toLowerCase()) {
        deesc = "Culiacán";
    }

    $('#Municipio').val(null).trigger('change');
    var control = $('#Municipio');

    //var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    //var query = "select top 1 clave from Municipio where estado = '" + $('#Estado').val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    //var valorPaisId = EvaluaQuery(query)

    var rdesc = EvaluaQuery("usp_GetMunicipioYPoblacion '" + $('#Estado').val() + "', '" + deesc + "'");
    var split = rdesc.split(',');
    var ValorMunicipio = split[0];

    poblacionP = split[1];

    control.select2('open');
    $('.select2-search__field').val(ValorMunicipio).trigger('keyup');
    control.select2('close');
    var data = AutoCompleteMunicipioData;
    control.select2({ data: data });
    control.val(ValorMunicipio).trigger('change');
}

function CambiaPoblacion(deesc) {
    debugger;
    $('#Poblacion').val(null).trigger('change');
    var control = $('#Poblacion');

    var valorPobla = 0;
    if (poblacionP == "0") {
        var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
        var query = "select top 1 clave from Colonia where Municipio = '" + $('#Municipio').val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
        valorPobla = EvaluaQuery(query);
    } else {
        valorPobla = poblacionP;
    }



    control.select2('open');
    $('.select2-search__field').val(valorPobla).trigger('keyup');
    control.select2('close');
    var data = AutoCompletePoblacionData;
    control.select2({ data: data });
    control.val(valorPobla).trigger('change');
}

function CambiaColonia(deesc) {
    debugger;
    $('#Colonia').val(null).trigger('change');
    var control = $('#Colonia');
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Colonia where Municipio = '" + $('#Municipio').val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
    var data = AutoCompleteColoniaData;
    control.select2({ data: data });
    control.val(valorPaisId).trigger('change');
}

function CargaGoogleMaps() {

    debugger;

    debugger;
    $("#Codigo_Postal").val((""));
    $('#Pais').val(null).trigger('change');
    $('#Estado').val(null).trigger('change');
    $('#Municipio').val(null).trigger('change');
    $('#Colonia').val(null).trigger('change');
    $('#Poblacion').val(null).trigger('change');
    $("#Calle").val((""));
    $("#Numero_Exterior").val((""));
    $('#Latitud').val("");
    $('#Longitud').val("");


    var map; // el mapa
    var marker; //el marcador
    var myLatlng; //el objeto latitud y longitud
    var geocoder = new google.maps.Geocoder();
    var infowindow = new google.maps.InfoWindow();
    initialize();

    function initialize() {


        var mapOptions = {
            zoom: jQuery('input[name=address]').val() == "" ? 8 : 18,
            center: myLatlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        }
        map = new google.maps.Map(document.getElementById("gmap"), mapOptions); //gmap es el DIV que contendrá el Mapa
        marker = new google.maps.Marker({
            map: map,
            position: myLatlng,
            draggable: true // se refiere a que se puede navagar por el mapa
        });

        // Se dispara despúes de que se mueve el marcador
        geocoder.geocode({ 'latLng': myLatlng }, function(results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                if (results[0]) {
                    $('#Latitud').val(marker.getPosition().lat());
                    $('#Longitud').val(marker.getPosition().lng());
                    infowindow.setContent(results[0].formatted_address); //presenta la direccion completa sobre el marquer donde estamos posicionados es como una especie de ToolTip
                    infowindow.open(map, marker);
                }
            }
        });

        google.maps.event.addListener(map, 'click', function(event) {
            placeMarker(event.latLng);
            geocoder.geocode({ 'latLng': marker.getPosition() }, function(results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    if (results[0]) {
                        debugger;
                        //  for (var i = results[0].address_components.length; i < 0 ; i--) {
                        for (var i = results[0].address_components.length - 1; i >= 0; i--) {

                            if (results[0].address_components[i].types[0] == "postal_code") {
                                $("#Codigo_Postal").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "country") {
                                debugger;
                                CambiaPais(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), results[0].address_components[i].long_name);


                            }

                            if (results[0].address_components[i].types[0] == "administrative_area_level_1") {
                                CambiaEstado(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), results[0].address_components[i].long_name);
                            }

                            if (results[0].address_components[i].types[0] == "locality") {
                                CambiaMunicipio(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex), results[0].address_components[i].long_name);
                            }


                            if (results[0].address_components[i].types[0] == "political") { // segun spartanMetadata poblacion es igual a colonia

                                CambiaPoblacion(results[0].address_components[i].long_name);
                                CambiaColonia(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Colonia' + rowIndex), results[0].address_components[i].long_name);
                                //AsignarValor($('#' + nameOfTable + 'Poblacion' + rowIndex), results[0].address_components[i].long_name);
                            }



                            if (results[0].address_components[i].types[0] == "route") {
                                $("#Calle").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "street_number") {
                                $("#Numero_Exterior").val((results[0].address_components[i].long_name));
                            }



                        }
                        marker.setPosition(new google.maps.LatLng(marker.getPosition().lat(), marker.getPosition().lng()));
                        map.panTo(new google.maps.LatLng(marker.getPosition().lat(), marker.getPosition().lng()));
                        console.log(marker.getPosition().lat());
                        console.log(marker.getPosition().lng());
                        $('#Latitud').val(marker.getPosition().lat());
                        $('#Longitud').val(marker.getPosition().lng());
                        infowindow.setContent(results[0].formatted_address);
                        infowindow.open(map, marker);


                    }
                }
            });
        });

        function placeMarker(location) {

            if (marker == null) {
                marker = new google.maps.Marker({
                    position: location,
                    map: map
                });
            } else {
                marker.setPosition(location);
            }


        }

        /*google.maps.event.addListener(map, 'click', function(event) {

            geocoder.geocode({ 'latLng': marker.getPosition() }, function(results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    if (results[0]) {
                        debugger;
                        //  for (var i = results[0].address_components.length; i < 0 ; i--) {
                        for (var i = results[0].address_components.length - 1; i >= 0; i--) {

                            if (results[0].address_components[i].types[0] == "postal_code") {
                                $("#Codigo_Postal").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "country") {
                                debugger;
                                CambiaPais(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), results[0].address_components[i].long_name);


                            }

                            if (results[0].address_components[i].types[0] == "administrative_area_level_1") {
                                CambiaEstado(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), results[0].address_components[i].long_name);
                            }

                            if (results[0].address_components[i].types[0] == "locality") {
                                CambiaMunicipio(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex), results[0].address_components[i].long_name);
                            }


                            if (results[0].address_components[i].types[0] == "political") { // segun spartanMetadata poblacion es igual a colonia

                                CambiaPoblacion(results[0].address_components[i].long_name);
                                CambiaColonia(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Colonia' + rowIndex), results[0].address_components[i].long_name);
                                //AsignarValor($('#' + nameOfTable + 'Poblacion' + rowIndex), results[0].address_components[i].long_name);
                            }



                            if (results[0].address_components[i].types[0] == "route") {
                                $("#Calle").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "street_number") {
                                $("#Numero_Exterior").val((results[0].address_components[i].long_name));
                            }



                        }
                        marker.setPosition(new google.maps.LatLng(marker.getPosition().lat(), marker.getPosition().lng()));
                        map.panTo(new google.maps.LatLng(marker.getPosition().lat(), marker.getPosition().lng()));
                        console.log(marker.getPosition().lat());
                        console.log(marker.getPosition().lng());
                        $('#Latitud').val(marker.getPosition().lat());
                        $('#Longitud').val(marker.getPosition().lng());
                        infowindow.setContent(results[0].formatted_address);
                        infowindow.open(map, marker);


                    }
                }
            });
        });

*/


        // Evento que se dispara cuando se mueve el marcador en en el mapa (es el Marcador de posicion de color Rojo)
        // cada pixel que se mueve o se arrastra se recalcula la latitud y la longitud
        google.maps.event.addListener(marker, 'dragend', function() {
            geocoder.geocode({ 'latLng': marker.getPosition() }, function(results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    if (results[0]) {
                        debugger;
                        //  for (var i = results[0].address_components.length; i < 0 ; i--) {
                        for (var i = results[0].address_components.length - 1; i >= 0; i--) {

                            if (results[0].address_components[i].types[0] == "postal_code") {
                                $("#Codigo_Postal").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "country") {
                                debugger;
                                CambiaPais(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), results[0].address_components[i].long_name);


                            }

                            if (results[0].address_components[i].types[0] == "administrative_area_level_1") {
                                CambiaEstado(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), results[0].address_components[i].long_name);
                            }

                            if (results[0].address_components[i].types[0] == "locality") {
                                CambiaMunicipio(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex), results[0].address_components[i].long_name);
                            }


                            if (results[0].address_components[i].types[0] == "political") { // segun spartanMetadata poblacion es igual a colonia

                                CambiaPoblacion(results[0].address_components[i].long_name);
                                CambiaColonia(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Colonia' + rowIndex), results[0].address_components[i].long_name);
                                //AsignarValor($('#' + nameOfTable + 'Poblacion' + rowIndex), results[0].address_components[i].long_name);
                            }



                            if (results[0].address_components[i].types[0] == "route") {
                                $("#Calle").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "street_number") {
                                $("#Numero_Exterior").val((results[0].address_components[i].long_name));
                            }



                        }
                        $('#Latitud').val(marker.getPosition().lat());
                        $('#Longitud').val(marker.getPosition().lng());
                        infowindow.setContent(results[0].formatted_address);
                        infowindow.open(map, marker);
                        var lat = $("#Latitud").val();
                        var long = $("#Longitud").val();
                        if (lat != "" && long != "") {
                            $("#address").val(lat + "," + long);
                        }
                    }
                }
            });
        });
    }

    google.maps.event.addDomListener(window, 'load', initialize);

    // Buscamos la direccion escrita (solo busca todavia no asigna) y no posicionamos sobre ella, se dispara cuando se le da click al boton buscar dentro de la modal que contiene al mapa
    // var geocoder = new google.maps.Geocoder();
    geocoder.geocode({
            address: jQuery('input[name=address]').val() == "" ? "Primer Cuadro, 80000 Culiacán Rosales, Sin., México" : $('input[name=address]').val(),
            region: 'no'
        },
        function(results, status) {
            if (status.toLowerCase() == 'ok') {
                var coords = new google.maps.LatLng(
                    results[0]['geometry']['location'].lat(), //asignamos Latitud de la dirección buscada
                    results[0]['geometry']['location'].lng() //asignamos Longitud de la dirección buscada
                );
                map.setCenter(coords); //para que la direción buscada se muestre centrada en nel mapa

                //map.setZoom(10) //zoom
                marker = new google.maps.Marker({
                    position: coords,
                    map: map,
                    title: jQuery('input[name=address]').val(),
                });
                myLatlng = coords;
                initialize();
            } else {
                alert(status);
                return;
            }
        });
}

function CargaGoogleMapsOtrosDomicilios() {

    debugger;

    debugger;
    //$("#Codigo_Postal").val((""));
    //$('#Pais').val(null).trigger('change');
    //$('#Estado').val(null).trigger('change');
    //$('#Municipio').val(null).trigger('change');
    //$('#Colonia').val(null).trigger('change');
    //$('#Poblacion').val(null).trigger('change');
    //$("#Calle").val((""));
    //$("#Numero_Exterior").val((""));
    //$('#Latitud').val("");
    //$('#Longitud').val("");

    var RowSelected = $("#RowSelected").val();
    var lat = $('#Otros_Domicilios_Involucrado_Coordenada_X_' + RowSelected + '').val();
    var long = $('#Otros_Domicilios_Involucrado_Coordenada_Y_' + RowSelected + '').val();

    var map; // el mapa
    var marker; //el marcador
    var myLatlng; //el objeto latitud y longitud
    var geocoder = new google.maps.Geocoder();
    var infowindow = new google.maps.InfoWindow();
    initialize();

    function initialize() {
        var mapOptions = {
            zoom: jQuery('input[name=address2]').val() == "" ? 8 : 18,
            center: myLatlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        }
        map = new google.maps.Map(document.getElementById("gmap2"), mapOptions); //gmap es el DIV que contendrá el Mapa
        marker = new google.maps.Marker({
            map: map,
            position: myLatlng,
            draggable: true // se refiere a que se puede navagar por el mapa
        });

        // Se dispara despúes de que se mueve el marcador
        geocoder.geocode({ 'latLng': myLatlng }, function(results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                if (results[0]) {
                    $('#Otros_Domicilios_Involucrado_Coordenada_X_' + RowSelected + '').val(marker.getPosition().lat());
                    $('#Otros_Domicilios_Involucrado_Coordenada_Y_' + RowSelected + '').val(marker.getPosition().lng());
                    infowindow.setContent(results[0].formatted_address); //presenta la direccion completa sobre el marquer donde estamos posicionados es como una especie de ToolTip
                    infowindow.open(map, marker);
                }
            }
        });

        // Evento que se dispara cuando se mueve el marcador en en el mapa (es el Marcador de posicion de color Rojo)
        // cada pixel que se mueve o se arrastra se recalcula la latitud y la longitud
        google.maps.event.addListener(marker, 'dragend', function() {
            geocoder.geocode({ 'latLng': marker.getPosition() }, function(results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    if (results[0]) {
                        debugger;
                        //  for (var i = results[0].address_components.length; i < 0 ; i--) {
                        for (var i = results[0].address_components.length - 1; i >= 0; i--) {

                            if (results[0].address_components[i].types[0] == "postal_code") {
                                $("#Codigo_Postal").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "country") {
                                debugger;
                                CambiaPais(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), results[0].address_components[i].long_name);


                            }

                            if (results[0].address_components[i].types[0] == "administrative_area_level_1") {
                                CambiaEstado(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), results[0].address_components[i].long_name);
                            }

                            if (results[0].address_components[i].types[0] == "locality") {
                                CambiaMunicipio(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex), results[0].address_components[i].long_name);
                            }


                            if (results[0].address_components[i].types[0] == "political") { // segun spartanMetadata poblacion es igual a colonia

                                CambiaPoblacion(results[0].address_components[i].long_name);
                                CambiaColonia(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Colonia' + rowIndex), results[0].address_components[i].long_name);
                                //AsignarValor($('#' + nameOfTable + 'Poblacion' + rowIndex), results[0].address_components[i].long_name);
                            }



                            if (results[0].address_components[i].types[0] == "route") {
                                $("#Calle").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "street_number") {
                                $("#Numero_Exterior").val((results[0].address_components[i].long_name));
                            }



                        }
                        $('#Otros_Domicilios_Involucrado_Coordenada_X_' + RowSelected + '').val(marker.getPosition().lat());
                        $('#Otros_Domicilios_Involucrado_Coordenada_Y_' + RowSelected + '').val(marker.getPosition().lng());
                        infowindow.setContent(results[0].formatted_address);
                        infowindow.open(map, marker);
                    }
                }
            });
        });
    }

    google.maps.event.addDomListener(window, 'load', initialize);

    // Buscamos la direccion escrita (solo busca todavia no asigna) y no posicionamos sobre ella, se dispara cuando se le da click al boton buscar dentro de la modal que contiene al mapa
    // var geocoder = new google.maps.Geocoder();
    geocoder.geocode({
            address: jQuery('input[name=address2]').val() == "" ? "Primer Cuadro, 80000 Culiacán Rosales, Sin., México" : $('input[name=address2]').val(),
            region: 'no'
        },
        function(results, status) {
            if (status.toLowerCase() == 'ok') {
                var coords = new google.maps.LatLng(
                    results[0]['geometry']['location'].lat(), //asignamos Latitud de la dirección buscada
                    results[0]['geometry']['location'].lng() //asignamos Longitud de la dirección buscada
                );
                map.setCenter(coords); //para que la direción buscada se muestre centrada en nel mapa

                //map.setZoom(10) //zoom
                marker = new google.maps.Marker({
                    position: coords,
                    map: map,
                    title: jQuery('input[name=address2]').val(),
                });
                myLatlng = coords;
                initialize();
            } else {
                alert(status);
                return;
            }
        });
}

function CambiaPaisRow(deesc) {
    debugger;
    var RowSelected = $("#RowSelected").val();
    $("#Otros_Domicilios_Involucrado_Pais_" + RowSelected + "").val(null).trigger('change');
    var control = $("#Otros_Domicilios_Involucrado_Pais_" + RowSelected + "");
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from pais where dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
        //control.select2('open');
        //$('.select2-search__field').val(valorPaisId).trigger('keyup');
        //control.select2('close');
        //var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
        //control.select2({ data: data });
    control.val(valorPaisId).trigger('change');

}

function CambiaEstadoRow(deesc) {
    debugger;

    var rdescp = EvaluaQuery("select dbo.RemoveAccentMarks ('México')");
    var queryp = "select top 1 clave from pais where dbo.RemoveAccentMarks(nombre) like '%" + rdescp + "%'";
    var valorPaisId = EvaluaQuery(queryp)


    var RowSelected = $("#RowSelected").val();
    $("#Otros_Domicilios_Involucrado_Estado_" + RowSelected + "").val(null).trigger('change');
    var control = $("#Otros_Domicilios_Involucrado_Estado_" + RowSelected + "");
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Estado where pais = '" + valorPaisId + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
    var data = eval('AutoCompleteEstadoData');
    control.select2({ data: data });
    control.val(valorPaisId).trigger('change');

}

function CambiaMunicipioRow(deesc) {
    debugger;

    var RowSelected = $("#RowSelected").val();
    $("#Otros_Domicilios_Involucrado_Municipio_" + RowSelected + "").val(null).trigger('change');
    var control = $("#Otros_Domicilios_Involucrado_Municipio_" + RowSelected + "");
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Municipio where estado = '" + $("#Otros_Domicilios_Involucrado_Estado_" + RowSelected + "").val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
    var data = eval('AutoCompleteMunicipioData');
    control.select2({ data: data });
    control.val(valorPaisId).trigger('change');
}

function CambiaPoblacionRow(deesc) {
    debugger;

    var RowSelected = $("#RowSelected").val();
    $("#Otros_Domicilios_Involucrado_Poblacion_" + RowSelected + "").val(null).trigger('change');
    var control = $("#Otros_Domicilios_Involucrado_Poblacion_" + RowSelected + "");
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Colonia where Municipio = '" + $("#Otros_Domicilios_Involucrado_Municipio_" + RowSelected + "").val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
    var data = eval('AutoCompletePoblacionData');
    control.select2({ data: data });
    control.val(valorPaisId).trigger('change');
}

function CambiaColoniaRow(deesc) {
    debugger;

    var RowSelected = $("#RowSelected").val();
    $("#Otros_Domicilios_Involucrado_Colonia_" + RowSelected + "").val(null).trigger('change');
    var control = $("#Otros_Domicilios_Involucrado_Colonia_" + RowSelected + "");
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Colonia where Municipio = '" + $("#Otros_Domicilios_Involucrado_Municipio_" + RowSelected + "").val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
    var data = eval('AutoCompleteColoniaData');
    control.select2({ data: data });
    control.val(valorPaisId).trigger('change');
}


function CargaGoogleMapsOtrosDomicilios() {

    debugger;
    var RowSelected = $("#RowSelected").val();
    $("#Otros_Domicilios_Involucrado_Codigo_Postal_" + RowSelected + "").val((""));
    $('#Otros_Domicilios_Involucrado_Estado_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Involucrado_Municipio_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Involucrado_Estado_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Involucrado_Municipio_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Involucrado_Colonia_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Involucrado_Poblacion_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Involucrado_Calle_' + RowSelected + '').val((""));
    $('#Otros_Domicilios_Involucrado_Numero_Exterior_' + RowSelected + '').val((""));
    $('#Otros_Domicilios_Involucrado_Numero_Interior_' + RowSelected + '').val((""));
    $('#Otros_Domicilios_Involucrado_Coordenada_X_' + RowSelected + '').val((""));
    $('#Otros_Domicilios_Involucrado_Coordenada_Y_' + RowSelected + '').val((""));

    var map; // el mapa
    var marker; //el marcador
    var myLatlng; //el objeto latitud y longitud
    var geocoder = new google.maps.Geocoder();
    var infowindow = new google.maps.InfoWindow();
    initialize();

    function initialize() {
        var mapOptions = {
            zoom: jQuery('input[name=address2]').val() == "" ? 8 : 18,
            center: myLatlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        }
        map = new google.maps.Map(document.getElementById("gmap2"), mapOptions); //gmap es el DIV que contendrá el Mapa
        marker = new google.maps.Marker({
            map: map,
            position: myLatlng,
            draggable: true // se refiere a que se puede navagar por el mapa
        });

        // Se dispara despúes de que se mueve el marcador
        geocoder.geocode({ 'latLng': myLatlng }, function(results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                if (results[0]) {
                    $('#Otros_Domicilios_Involucrado_Coordenada_X_' + RowSelected + '').val(marker.getPosition().lat());
                    $('#Otros_Domicilios_Involucrado_Coordenada_Y_' + RowSelected + '').val(marker.getPosition().lng());
                    infowindow.setContent(results[0].formatted_address); //presenta la direccion completa sobre el marquer donde estamos posicionados es como una especie de ToolTip
                    infowindow.open(map, marker);
                }
            }
        });

        google.maps.event.addListener(map, 'click', function(event) {
            placeMarker(event.latLng);
            geocoder.geocode({ 'latLng': marker.getPosition() }, function(results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    if (results[0]) {
                        debugger;
                        //  for (var i = results[0].address_components.length; i < 0 ; i--) {
                        for (var i = results[0].address_components.length - 1; i >= 0; i--) {

                            if (results[0].address_components[i].types[0] == "postal_code") {
                                $("#Otros_Domicilios_Involucrado_Codigo_Postal_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "country") {
                                debugger;
                                console.log(" CambiaPaisRow(results[0].address_components[i].long_name)" + results[0].address_components[i].long_name)
                                CambiaPaisRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), results[0].address_components[i].long_name);


                            }

                            if (results[0].address_components[i].types[0] == "administrative_area_level_1") {
                                console.log(" CambiaEstadoRow(results[0].address_components[i].long_name)" + results[0].address_components[i].long_name)
                                CambiaEstadoRow(results[0].address_components[i].long_name);

                                // AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), results[0].address_components[i].long_name);
                            }

                            if (results[0].address_components[i].types[0] == "locality") {
                                console.log(" CambiaMunicipioRow(results[0].address_components[i].long_name))" + results[0].address_components[i].long_name);

                                CambiaMunicipioRow(results[0].address_components[i].long_name);

                                // AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex), results[0].address_components[i].long_name);
                            }


                            if (results[0].address_components[i].types[0] == "political") { // segun spartanMetadata poblacion es igual a colonia

                                console.log(" CambiaPoblacionRow(results[0].address_components[i].long_name) )" + results[0].address_components[i].long_name);
                                console.log(" CambiaColoniaRow(results[0].address_components[i].long_name); )" + results[0].address_components[i].long_name);
                                CambiaPoblacionRow(results[0].address_components[i].long_name);

                                CambiaColoniaRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Colonia' + rowIndex), results[0].address_components[i].long_name);
                                //AsignarValor($('#' + nameOfTable + 'Poblacion' + rowIndex), results[0].address_components[i].long_name);
                            }



                            if (results[0].address_components[i].types[0] == "route") {
                                $("#Otros_Domicilios_Involucrado_Calle_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "street_number") {
                                $("#Otros_Domicilios_Involucrado_Numero_Exterior_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }



                        }
                        $('#Otros_Domicilios_Involucrado_Coordenada_X_' + RowSelected + '').val(marker.getPosition().lat());
                        $('#Otros_Domicilios_Involucrado_Coordenada_Y_' + RowSelected + '').val(marker.getPosition().lng());
                        infowindow.setContent(results[0].formatted_address);
                        infowindow.open(map, marker);
                    }
                }
            });
        });

        function placeMarker(location) {

            if (marker == null) {
                marker = new google.maps.Marker({
                    position: location,
                    map: map
                });
            } else {
                marker.setPosition(location);
            }
        }


        // Evento que se dispara cuando se mueve el marcador en en el mapa (es el Marcador de posicion de color Rojo)
        // cada pixel que se mueve o se arrastra se recalcula la latitud y la longitud
        google.maps.event.addListener(marker, 'dragend', function() {
            geocoder.geocode({ 'latLng': marker.getPosition() }, function(results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    if (results[0]) {
                        debugger;
                        //  for (var i = results[0].address_components.length; i < 0 ; i--) {
                        for (var i = results[0].address_components.length - 1; i >= 0; i--) {

                            if (results[0].address_components[i].types[0] == "postal_code") {
                                $("#Otros_Domicilios_Involucrado_Codigo_Postal_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "country") {
                                debugger;
                                console.log(" CambiaPaisRow(results[0].address_components[i].long_name)" + results[0].address_components[i].long_name)
                                CambiaPaisRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), results[0].address_components[i].long_name);


                            }

                            if (results[0].address_components[i].types[0] == "administrative_area_level_1") {
                                console.log(" CambiaEstadoRow(results[0].address_components[i].long_name)" + results[0].address_components[i].long_name)
                                CambiaEstadoRow(results[0].address_components[i].long_name);

                                // AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), results[0].address_components[i].long_name);
                            }

                            if (results[0].address_components[i].types[0] == "locality") {
                                console.log(" CambiaMunicipioRow(results[0].address_components[i].long_name))" + results[0].address_components[i].long_name);

                                CambiaMunicipioRow(results[0].address_components[i].long_name);

                                // AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex), results[0].address_components[i].long_name);
                            }


                            if (results[0].address_components[i].types[0] == "political") { // segun spartanMetadata poblacion es igual a colonia

                                console.log(" CambiaPoblacionRow(results[0].address_components[i].long_name) )" + results[0].address_components[i].long_name);
                                console.log(" CambiaColoniaRow(results[0].address_components[i].long_name); )" + results[0].address_components[i].long_name);
                                CambiaPoblacionRow(results[0].address_components[i].long_name);

                                CambiaColoniaRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Colonia' + rowIndex), results[0].address_components[i].long_name);
                                //AsignarValor($('#' + nameOfTable + 'Poblacion' + rowIndex), results[0].address_components[i].long_name);
                            }



                            if (results[0].address_components[i].types[0] == "route") {
                                $("#Otros_Domicilios_Involucrado_Calle_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "street_number") {
                                $("#Otros_Domicilios_Involucrado_Numero_Exterior_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }



                        }
                        $('#Otros_Domicilios_Involucrado_Coordenada_X_' + RowSelected + '').val(marker.getPosition().lat());
                        $('#Otros_Domicilios_Involucrado_Coordenada_Y_' + RowSelected + '').val(marker.getPosition().lng());
                        infowindow.setContent(results[0].formatted_address);
                        infowindow.open(map, marker);
                    }
                }
            });
        });

    }

    google.maps.event.addDomListener(window, 'load', initialize);

    // Buscamos la direccion escrita (solo busca todavia no asigna) y no posicionamos sobre ella, se dispara cuando se le da click al boton buscar dentro de la modal que contiene al mapa
    // var geocoder = new google.maps.Geocoder();
    geocoder.geocode({
            address: jQuery('input[name=address2]').val() == "" ? "Primer Cuadro, 80000 Culiacán Rosales, Sin., México" : $('input[name=address2]').val(),
            region: 'no'
        },
        function(results, status) {
            if (status.toLowerCase() == 'ok') {
                var coords = new google.maps.LatLng(
                    results[0]['geometry']['location'].lat(), //asignamos Latitud de la dirección buscada
                    results[0]['geometry']['location'].lng() //asignamos Longitud de la dirección buscada
                );
                map.setCenter(coords); //para que la direción buscada se muestre centrada en nel mapa

                //map.setZoom(10) //zoom
                marker = new google.maps.Marker({
                    position: coords,
                    map: map,
                    title: jQuery('input[name=address2]').val(),
                });
                myLatlng = coords;
                initialize();
            } else {
                alert(status);
                return;
            }
        });
}


$("#Codigo_Postal").keyup(function() {
    var str = $('#' + nameOfTable + 'Codigo_Postal' + rowIndex).val();
    if (str != "") {
        var regNUM = /^[0-9]{1,5}$/
        var validacionnum = regNUM.test(str)
        if (validacionnum == false) {
            $('#' + nameOfTable + 'Codigo_Postal' + rowIndex).val($('#' + nameOfTable + 'Codigo_Postal' + rowIndex).val().slice(0, -1));
        }
    }
});