var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function() {
    $('#Involucrados_PCAnterior').addClass("hidden");
    $("#Involucrados_PCGuardarYNuevo").addClass("hidden");
    $("#Involucrados_PCGuardarYCopia").addClass("hidden");
    if (roleActivo == 110 || roleActivo == 108) {
        $("#ConfigureSave").addClass("hidden");
        $("#Involucrados_PCCancelar").addClass("hidden");
        $("#Involucrados_PCGuardar").addClass("hidden");
        //$("#side-menu").addClass("hidden");	
        try {
            var EsTestigo = localStorage.getItem("EsTestigo");
            if (EsTestigo == "1") {
                $("#tituloINV2").text("Proporcione los datos del Testigo");
                $("#tituloINV").text("Proporcione los datos del Testigo");
                $("#Tipo_de_Compareciente").val(4);
            } else
                $("#Tipo_de_Compareciente").val(2);
        } catch (error) {

        }
    } else {
        $("#Involucrados_PCSiguiente").addClass("hidden");
        $("#Involucrados_PCAnterior").addClass("hidden");
    }

    if (roleActivo == 110 || roleActivo == 108) {
        $("#side-menu").addClass("hidden");
        $("#logoutForm").addClass("hidden");
    }

    //Validar dependiendo del tipo de identificacion seleccionada.
    $("form#CreateInvolucrados_PC").on('change', '#Tipo_de_Identificacion', function() {
        var tipoVal = $('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex).val();
        if (tipoVal == 1) //CREDENCIAL DE ELECTOR
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Elector');

        }

        if (tipoVal == 2) //PASAPORTE
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Pasaporte');

        }
        if (tipoVal == 3) //LICENCIA DE CONDUCIR
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Licencia de Conducir');

        }
        if (tipoVal == 4) //NINGUNA
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Número de Identificación');

        }
        if (tipoVal == 5) //CREDENCIAL DE TRABAJO
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Trabajo');

        }
        if (tipoVal == 6) //CERTIF. DE MATRICULA CONSULAR
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Certificado de Matrícula Consular');

        }
        if (tipoVal == 7) //CARTILLA DE SERVICIO MILITAR
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Cartilla de Servicio Militar');

        }
        if (tipoVal == 8) //COTRAS
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Otras');

        }
        if (tipoVal == 9) //CEDULA PROFESIONAL
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Cédula Profesional');

        }
        if (tipoVal == 10) //CREDENCIAL DE ESTUDIANTE
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Estudiante');

        }
        if (tipoVal == 11) //CREDENCIAL PARTIDO POLITICO
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial Partido Político');

        }
        if (tipoVal == 12) //HOJA IDENTIFICACION MILITAR
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Hoja Identificación Militar');

        }
        if (tipoVal == 13) //CREDENCIAL DE GANADERO
        {
            $($("#divNumero_de_Identificacion").find("label")[0]).text('Credencial de Ganadero');

        }
    });


    //Validar CURP
    $("#CURP").blur(function() {
        var v = $('#' + nameOfTable + 'CURP' + rowIndex).val();
        if (v != "") {
            var valid = /^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/,
                validado = v.toUpperCase().match(valid);

            if (!validado) { //Coincide con el formato general?
                $('#' + nameOfTable + 'CURP' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").val("").focus().blur();
                return false;
            }
        }
    });

    //BusinessRuleId:3171, Attribute:269261, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('change', '#Fecha_de_Nacimiento', function() {
        nameOfTable = '';
        rowIndex = '';
        AsignarValor($('#' + nameOfTable + 'Edad' + rowIndex), EvaluaQuery(" DECLARE @date date, @tmpdate date, @years int SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento]',103)),103) SELECT @tmpdate = @date SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END SELECT @tmpdate = DATEADD(yy, @years, @tmpdate) SELECT @years", rowIndex, nameOfTable));
    });


    //BusinessRuleId:3171, Attribute:269261, Operation:Field, Event:None



    //BusinessRuleId:3177, Attribute:269257, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('keyup', '#Nombres', function() {
        nameOfTable = '';
        rowIndex = '';
        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
    });


    //BusinessRuleId:3177, Attribute:269257, Operation:Field, Event:None

    //BusinessRuleId:3178, Attribute:269258, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('keyup', '#Apellido_Paterno', function() {
        nameOfTable = '';
        rowIndex = '';
        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
    });


    //BusinessRuleId:3178, Attribute:269258, Operation:Field, Event:None

    //BusinessRuleId:3179, Attribute:269259, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('keyup', '#Apellido_Materno', function() {
        nameOfTable = '';
        rowIndex = '';
        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
    });


    //BusinessRuleId:3179, Attribute:269259, Operation:Field, Event:None

    //BusinessRuleId:3214, Attribute:269256, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('change', '#Tipo_de_Compareciente', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4')) {
            $('#divExistieron_testigos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Existieron_testigos' + rowIndex));
        } else { $('#divExistieron_testigos').css('display', 'block'); }
    });


    //BusinessRuleId:3214, Attribute:269256, Operation:Field, Event:None

    //BusinessRuleId:3224, Attribute:269271, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('change', '#Pais', function() {
        nameOfTable = '';
        rowIndex = '';
        var valor = $('#' + nameOfTable + 'Estado' + rowIndex).val();
        $('#' + nameOfTable + 'Estado' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Estado' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Estado' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Estado WHERE Pais = FLD[Pais]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Estado' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Estado' + rowIndex).val(valor).trigger('change');
        var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');
    });


    //BusinessRuleId:3224, Attribute:269271, Operation:Field, Event:None

    //BusinessRuleId:3225, Attribute:269272, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('change', '#Estado', function() {
        nameOfTable = '';
        rowIndex = '';
        var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM dbo.Municipio WHERE Estado = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change');
    });


    //BusinessRuleId:3225, Attribute:269272, Operation:Field, Event:None





    //BusinessRuleId:3284, Attribute:269534, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('change', '#Desea_indicar_datos_adicionales', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divNombres').css('display', 'block');
            $('#divApellido_Paterno').css('display', 'block');
            $('#divApellido_Materno').css('display', 'block');
            $('#divFecha_de_Nacimiento').css('display', 'block');
            $('#divEdad').css('display', 'block');
            $('#divSexo').css('display', 'block');
            $('#divEstado_Civil').css('display', 'block');
            $('#divTipo_de_Identificacion').css('display', 'block');
            $('#divNumero_de_Identificacion').css('display', 'block');
            $('#divFotografia_de_la_identificacion').css('display', 'block');
            $('#divCURP').css('display', 'block');
            $('#divNacionalidad').css('display', 'block');
            $('#divOriginario_de').css('display', 'block');
            $("a[href='#tabDomicilio']").css('display', 'block');
        } else {}
    });


    //BusinessRuleId:3284, Attribute:269534, Operation:Field, Event:None

    //BusinessRuleId:3285, Attribute:269534, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('change', '#Desea_indicar_datos_adicionales', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
            $('#divNombres').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex));
            $('#divApellido_Paterno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            $('#divApellido_Materno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            $('#divFecha_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
            $('#divEdad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
            $('#divSexo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
            $('#divEstado_Civil').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
            $('#divTipo_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
            $('#divNumero_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
            $('#divFotografia_de_la_identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));
            $('#divCURP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
            $('#divNacionalidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            $('#divOriginario_de').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            $("a[href='#tabDomicilio']").css('display', 'none');
        } else {}
    });


    //BusinessRuleId:3285, Attribute:269534, Operation:Field, Event:None



    //BusinessRuleId:4582, Attribute:269273, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('change', '#Municipio', function() {
        nameOfTable = '';
        rowIndex = '';
        var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
        $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] AND Tipo = 2 AND Estatus = 'v'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] AND Tipo = 2 AND Estatus = 'v'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
        var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] AND Tipo = 1 AND Estatus = 'v'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] AND Tipo = 1 AND Estatus = 'v'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
    });


    //BusinessRuleId:4582, Attribute:269273, Operation:Field, Event:None

    //BusinessRuleId:4583, Attribute:269274, Operation:Field, Event:None
    $("form#CreateInvolucrados_PC").on('change', '#Poblacion', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex), nameOfTable, rowIndex) != TryParseInt('', '')) {
            var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
            if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
                $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] AND Tipo = 1 AND Estatus = 'v'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
            } else {
                var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] AND Tipo = 1 AND Estatus = 'v'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
            }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
        } else {
            var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
            if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
                $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] AND Tipo = 1 AND Estatus = 'v'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
            } else {
                var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] AND Tipo = 1 AND Estatus = 'v'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
            }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
        }
    });


    //BusinessRuleId:4583, Attribute:269274, Operation:Field, Event:None

    //NEWBUSINESSRULE_NONE//
});

$("#Involucrados_PCSiguiente").on("click", function() {
    var valform = checkClientValidate('Involucrados_PCCreateForm');
    if (!valform) {
        return;
    } else {
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
            if (!SendInvolucrados_PCData(function() {
                    debugger;
                    EjecutarValidacionesDespuesDeGuardar();
                    if ($("#tituloINV").text().trim() == "Proporcione los datos de la Víctima") {
                        localStorage.setItem("IdVictima", newIDInv);
                        if ($("#Existieron_testigos").prop("checked")) {
                            localStorage.setItem("EsTestigo", "1");
                            try {
                                var IdTestigo = localStorage.getItem("IdTestigo");
                                if (IdTestigo != null) {
                                    window.location = "../Involucrados_PC/Create?Id=" + IdTestigo;
                                    return;
                                }
                            } catch (error) {

                            }
                            window.location = "../Involucrados_PC/Create";
                            return;
                        }
                        try {
                            var IdHechos = localStorage.getItem("IdHechos");
                            if (IdHechos != null) {
                                window.location = "../Datos_de_los_Hechos_PC/Create?Id=" + IdHechos;
                                return;
                            }
                        } catch (error) {

                        }
                        window.location = "../Datos_de_los_Hechos_PC/Create";
                        return;
                    } else {
                        localStorage.setItem("IdTestigo", newIDInv);
                        try {
                            var IdHechos = localStorage.getItem("IdHechos");
                            if (IdHechos != null) {
                                window.location = "../Datos_de_los_Hechos_PC/Create?Id=" + IdHechos;
                                return;
                            }
                        } catch (error) {

                        }
                        window.location = "../Datos_de_los_Hechos_PC/Create";
                        return;
                    }
                })) {

            }
        }
        console.log("aqui guarda");
    }
});

$("#Involucrados_PCAnterior").on("click", function() {
    debugger;
    if ($("#tituloINV2").text().trim() == "Proporcione los datos de la Víctima") {
        window.location = "../../inicio.html";
    } else {
        try {
            var IdVictima = localStorage.getItem("IdVictima");
            if (IdVictima != null) {
                localStorage.setItem("EsTestigo", "0");
                window.location = "../Involucrados_PC/Create?Id=" + IdVictima;
            }
        } catch (error) {

        }
    }
});


function EjecutarValidacionesAlComienzo() {
    debugger;








    //BusinessRuleId:3170, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex)); }
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));


    }
    //BusinessRuleId:3170, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3170, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex)); }
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));


    }
    //BusinessRuleId:3170, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:3172, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        $('#divLatitud').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
        $('#divLongitud').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));


    }
    //BusinessRuleId:3172, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3172, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        $('#divLatitud').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
        $('#divLongitud').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));


    }
    //BusinessRuleId:3172, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3172, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        $('#divLatitud').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
        $('#divLongitud').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));


    }
    //BusinessRuleId:3172, Attribute:0, Operation:Object, Event:SCREENOPENING









    //BusinessRuleId:3175, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
        $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
        var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3175, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3175, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
        $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
        var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
        $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
            $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
        } else {
            var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
        }
        $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');


    }
    //BusinessRuleId:3175, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3181, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
        $('#divNombre_Completo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


    }
    //BusinessRuleId:3181, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3181, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
        $('#divNombre_Completo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


    }
    //BusinessRuleId:3181, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3181, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
        $('#divNombre_Completo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));


    }
    //BusinessRuleId:3181, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3190, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('109', '109') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110')) {
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divSolicitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex));
            $('#divTipo_de_Solicitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));
        } else {}


    }
    //BusinessRuleId:3190, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3190, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('109', '109') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110')) {
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divSolicitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex));
            $('#divTipo_de_Solicitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));
        } else {}


    }
    //BusinessRuleId:3190, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3190, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('109', '109') || TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110')) {
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divSolicitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex));
            $('#divTipo_de_Solicitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex));
        } else {}


    }
    //BusinessRuleId:3190, Attribute:0, Operation:Object, Event:SCREENOPENING





    //BusinessRuleId:3194, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('110', '110')) { AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex), '2'); } else {}


    }
    //BusinessRuleId:3194, Attribute:0, Operation:Object, Event:SCREENOPENING





























    //BusinessRuleId:3219, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("false" == "true"));
        if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("false" == "true"));
        if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }


    }
    //BusinessRuleId:3219, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3219, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("false" == "true"));
        if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("false" == "true"));
        if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }


    }
    //BusinessRuleId:3219, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3219, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("false" == "true"));
        if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("false" == "true"));
        if ('false' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }


    }
    //BusinessRuleId:3219, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3173, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), EvaluaQuery(" SELECT NOMBRE FROM PAIS WHERE CLAVE = 82", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), EvaluaQuery(" SELECT NOMBRE FROM ESTADO WHERE CLAVE = 25", rowIndex, nameOfTable));


    }
    //BusinessRuleId:3173, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3173, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), EvaluaQuery(" SELECT NOMBRE FROM PAIS WHERE CLAVE = 82", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), EvaluaQuery(" SELECT NOMBRE FROM ESTADO WHERE CLAVE = 25", rowIndex, nameOfTable));


    }
    //BusinessRuleId:3173, Attribute:0, Operation:Object, Event:SCREENOPENING













    //BusinessRuleId:3207, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divUsuario_que_Registra').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
        $('#divTipo_de_Compareciente').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));


    }
    //BusinessRuleId:3207, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3207, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divUsuario_que_Registra').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
        $('#divTipo_de_Compareciente').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));


    }
    //BusinessRuleId:3207, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3207, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divUsuario_que_Registra').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
        $('#divTipo_de_Compareciente').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex));


    }
    //BusinessRuleId:3207, Attribute:0, Operation:Object, Event:SCREENOPENING













    //BusinessRuleId:3230, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) != TryParseInt('NULL', 'NULL') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4')) {
            $('#divExistieron_testigos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Existieron_testigos' + rowIndex));
            $('#divTipo_de_Victima').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Victima' + rowIndex));
        } else { $('#divExistieron_testigos').css('display', 'block'); }


    }
    //BusinessRuleId:3230, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3230, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) != TryParseInt('NULL', 'NULL') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4')) {
            $('#divExistieron_testigos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Existieron_testigos' + rowIndex));
            $('#divTipo_de_Victima').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Victima' + rowIndex));
        } else { $('#divExistieron_testigos').css('display', 'block'); }


    }
    //BusinessRuleId:3230, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3230, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) != TryParseInt('NULL', 'NULL') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) == TryParseInt('4', '4')) {
            $('#divExistieron_testigos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Existieron_testigos' + rowIndex));
            $('#divTipo_de_Victima').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Victima' + rowIndex));
        } else { $('#divExistieron_testigos').css('display', 'block'); }


    }
    //BusinessRuleId:3230, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3169, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Solicitud' + rowIndex), EvaluaQuery(" SELECT FOLIO FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex), EvaluaQuery(" SELECT TIPO_DE_SOLICITUD FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));
        DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }


    }
    //BusinessRuleId:3169, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3169, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        AsignarValor($('#' + nameOfTable + 'Solicitud' + rowIndex), EvaluaQuery(" SELECT FOLIO FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex), EvaluaQuery(" SELECT TIPO_DE_SOLICITUD FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE CLAVE = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));
        DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Tipo_de_Solicitud" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Solicitud' + rowIndex)); }


    }
    //BusinessRuleId:3169, Attribute:0, Operation:Object, Event:SCREENOPENING





    //BusinessRuleId:3254, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex), EvaluaQuery(" select GLOBAL[USERID]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:3254, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3254, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex), EvaluaQuery(" select GLOBAL[USERID]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:3254, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:3193, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('108', '108')) {
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divSolicitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex));
            $('#divUsuario_que_Registra').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
        } else {}


    }
    //BusinessRuleId:3193, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3193, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('108', '108')) {
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divSolicitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex));
            $('#divUsuario_que_Registra').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
        } else {}


    }
    //BusinessRuleId:3193, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3193, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('108', '108')) {
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divSolicitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex));
            $('#divUsuario_que_Registra').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));
        } else {}


    }
    //BusinessRuleId:3193, Attribute:0, Operation:Object, Event:SCREENOPENING































    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('109', '109')) {
            DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Compareciente" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombres" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Fotografia_de_la_identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Victima" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Victima' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Existieron_testigos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Existieron_testigos' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('109', '109')) {
            DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Compareciente" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombres" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Fotografia_de_la_identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Victima" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Victima' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Existieron_testigos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Existieron_testigos' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('109', '109')) {
            DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Compareciente" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombres" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Fotografia_de_la_identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Victima" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Victima' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Existieron_testigos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Existieron_testigos' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('109', '109')) {
            DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Compareciente" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombres" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Fotografia_de_la_identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Victima" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Victima' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Existieron_testigos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Existieron_testigos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('109', '109')) {
            DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Compareciente" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombres" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Fotografia_de_la_identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Victima" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Victima' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Existieron_testigos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Existieron_testigos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('109', '109')) {
            DisabledControl($("#" + nameOfTable + "Solicitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Solicitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Compareciente" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombres" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Fotografia_de_la_identificacion" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
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
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Victima" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Victima' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Existieron_testigos" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Existieron_testigos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));
            if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }
        } else {}


    }
    //BusinessRuleId:3256, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:3265, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));


    }
    //BusinessRuleId:3265, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3265, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));


    }
    //BusinessRuleId:3265, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3265, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));


    }
    //BusinessRuleId:3265, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:3282, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) != TryParseInt('4', '4')) { $('#divDesea_indicar_datos_adicionales').css('display', 'block'); } else {
            $('#divDesea_indicar_datos_adicionales').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex));
        }


    }
    //BusinessRuleId:3282, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3282, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) != TryParseInt('4', '4')) { $('#divDesea_indicar_datos_adicionales').css('display', 'block'); } else {
            $('#divDesea_indicar_datos_adicionales').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex));
        }


    }
    //BusinessRuleId:3282, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3282, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110') && GetValueByControlType($('#' + nameOfTable + 'Tipo_de_Compareciente' + rowIndex), nameOfTable, rowIndex) != TryParseInt('4', '4')) { $('#divDesea_indicar_datos_adicionales').css('display', 'block'); } else {
            $('#divDesea_indicar_datos_adicionales').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex));
        }


    }
    //BusinessRuleId:3282, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3281, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110') && GetValueByControlType($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
            $('#divNombres').css('display', 'block');
            $('#divApellido_Paterno').css('display', 'block');
            $('#divApellido_Materno').css('display', 'block');
            $('#divFecha_de_Nacimiento').css('display', 'block');
            $('#divEdad').css('display', 'block');
            $('#divSexo').css('display', 'block');
            $('#divEstado_Civil').css('display', 'block');
            $('#divTipo_de_Identificacion').css('display', 'block');
            $('#divNumero_de_Identificacion').css('display', 'block');
            $('#divFotografia_de_la_identificacion').css('display', 'block');
            $('#divCURP').css('display', 'block');
            $('#divNacionalidad').css('display', 'block');
            $('#divOriginario_de').css('display', 'block');
            $("a[href='#tabDomicilio']").css('display', 'block');
        } else {}


    }
    //BusinessRuleId:3281, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3281, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110') && GetValueByControlType($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
            $('#divNombres').css('display', 'block');
            $('#divApellido_Paterno').css('display', 'block');
            $('#divApellido_Materno').css('display', 'block');
            $('#divFecha_de_Nacimiento').css('display', 'block');
            $('#divEdad').css('display', 'block');
            $('#divSexo').css('display', 'block');
            $('#divEstado_Civil').css('display', 'block');
            $('#divTipo_de_Identificacion').css('display', 'block');
            $('#divNumero_de_Identificacion').css('display', 'block');
            $('#divFotografia_de_la_identificacion').css('display', 'block');
            $('#divCURP').css('display', 'block');
            $('#divNacionalidad').css('display', 'block');
            $('#divOriginario_de').css('display', 'block');
            $("a[href='#tabDomicilio']").css('display', 'block');
        } else {}


    }
    //BusinessRuleId:3281, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3281, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110') && GetValueByControlType($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
            $('#divNombres').css('display', 'block');
            $('#divApellido_Paterno').css('display', 'block');
            $('#divApellido_Materno').css('display', 'block');
            $('#divFecha_de_Nacimiento').css('display', 'block');
            $('#divEdad').css('display', 'block');
            $('#divSexo').css('display', 'block');
            $('#divEstado_Civil').css('display', 'block');
            $('#divTipo_de_Identificacion').css('display', 'block');
            $('#divNumero_de_Identificacion').css('display', 'block');
            $('#divFotografia_de_la_identificacion').css('display', 'block');
            $('#divCURP').css('display', 'block');
            $('#divNacionalidad').css('display', 'block');
            $('#divOriginario_de').css('display', 'block');
            $("a[href='#tabDomicilio']").css('display', 'block');
        } else {}


    }
    //BusinessRuleId:3281, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3283, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110') && GetValueByControlType($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
            $('#divNombres').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex));
            $('#divApellido_Paterno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            $('#divApellido_Materno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            $('#divFecha_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
            $('#divEdad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
            $('#divSexo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
            $('#divEstado_Civil').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
            $('#divTipo_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
            $('#divNumero_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
            $('#divFotografia_de_la_identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));
            $('#divCURP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
            $('#divNacionalidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            $('#divOriginario_de').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            $("a[href='#tabDomicilio']").css('display', 'none');
        } else {}


    }
    //BusinessRuleId:3283, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3283, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110') && GetValueByControlType($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
            $('#divNombres').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex));
            $('#divApellido_Paterno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            $('#divApellido_Materno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            $('#divFecha_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
            $('#divEdad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
            $('#divSexo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
            $('#divEstado_Civil').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
            $('#divTipo_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
            $('#divNumero_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
            $('#divFotografia_de_la_identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));
            $('#divCURP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
            $('#divNacionalidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            $('#divOriginario_de').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            $("a[href='#tabDomicilio']").css('display', 'none');
        } else {}


    }
    //BusinessRuleId:3283, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3283, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]')) == TryParseInt('110', '110') && GetValueByControlType($('#' + nameOfTable + 'Desea_indicar_datos_adicionales' + rowIndex), nameOfTable, rowIndex) == TryParseInt('false', 'false')) {
            $('#divNombres').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex));
            $('#divApellido_Paterno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            $('#divApellido_Materno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            $('#divFecha_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
            $('#divEdad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
            $('#divSexo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
            $('#divEstado_Civil').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
            $('#divTipo_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
            $('#divNumero_de_Identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
            $('#divFotografia_de_la_identificacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));
            $('#divCURP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
            $('#divNacionalidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            $('#divOriginario_de').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            $("a[href='#tabDomicilio']").css('display', 'none');
        } else {}


    }
    //BusinessRuleId:3283, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3286, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));


    }
    //BusinessRuleId:3286, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3286, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));


    }
    //BusinessRuleId:3286, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3286, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fotografia_de_la_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));


    }
    //BusinessRuleId:3286, Attribute:0, Operation:Object, Event:SCREENOPENING

    //NEWBUSINESSRULE_SCREENOPENING//

    ValidaArchivos('#Fotografia_de_la_identificacionFile', ['pdf', 'jpg', 'jpeg', 'pnf', 'gift'], 4); //selector, extensions, filesize
}

function EjecutarValidacionesAntesDeGuardar() {
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVING//
    return result;
}

function EjecutarValidacionesDespuesDeGuardar() {
    //BusinessRuleId:3180, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


    }
    //BusinessRuleId:3180, Attribute:2, Operation:Object, Event:AFTERSAVING

    //BusinessRuleId:3180, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'Update') {
        AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex), EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


    }
    //BusinessRuleId:3180, Attribute:2, Operation:Object, Event:AFTERSAVING

    //NEWBUSINESSRULE_AFTERSAVING//
}




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
    var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
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
    var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
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
     var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
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
    }
    else {
        valorPobla = poblacionP;
    }



    control.select2('open');
    $('.select2-search__field').val(valorPobla).trigger('keyup');
    control.select2('close');
     var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
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
     var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
        control.select2({ data: data });
        control.val(valorPaisId).trigger('change');
}


function CargaGoogleMaps() {


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
                    }
                }
            });
        });
    }

    google.maps.event.addDomListener(window, 'load', initialize);

    // Buscamos la direccion escrita (solo busca todavia no asigna) y no posicionamos sobre ella, se dispara cuando se le da click al boton buscar dentro de la modal que contiene al mapa
    // var geocoder = new google.maps.Geocoder();
    geocoder.geocode({
            address: $('input[name=address]').val() == "" ? "Primer Cuadro, 80000 Culiacán Rosales, Sin., México" : $('input[name=address]').val(),
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