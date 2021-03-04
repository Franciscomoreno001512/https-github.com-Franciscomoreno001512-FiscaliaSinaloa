var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function() {

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


    $("#Detalle_de_ImputadoGuardarYNuevo").remove();
    $("#Detalle_de_ImputadoGuardarYCopia").remove();

    //INI OCULTAR BOTON DE MAPA
    $("form#CreateDetalle_de_Imputado").on('change', '#Quien_Resulte_Responsable', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $("#btnOpenMapa").hide();
        } else {
            $("#btnOpenMapa").show();
        }
    });
    //FIN OCULTAR BOTON DE MAPA

    if (operation == 'Update') {
        if (EvaluaQuery("select Canalizado from Detalle_de_Imputado where Clave = FLDD[lblClave]", rowIndex, nameOfTable) == TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]')) == TryParseInt('2', '2')) {
            $("#Detalle_de_ImputadoGuardar").remove();
        }
    }
    //CONVERTIR A MAYUSCULAS AL BLUR
    $('input[type="text"],textarea').blur(function() {
        this.value = this.value.toUpperCase();
    });
    //END CONVERTIR A MAYUSCULAS AL BLUR 

    //CAMBIAR LABEL A ALIAS
    $($("#divAlias").find("label")[0]).text('Alias y/o Apodo');

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

    //Validar correo electrónico
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
                    //$('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").val("").focus().blur(); 
                    return false;
                }
            }
        }
    });

    //BusinessRuleId:1936, Attribute:263148, Operation:Field, Event:None


    //BusinessRuleId:1936, Attribute:263148, Operation:Field, Event:None




    $("form#CreateDetalle_de_Imputado").on('change', '#Inimputable', function() {
        nameOfTable = '';
        rowIndex = '';
        if ($('#' + nameOfTable + 'Inimputable' + rowIndex).prop("checked") === true) {
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
        } else {
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
        }
    });

    //BusinessRuleId:1957, Attribute:266575, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Persona_Moral', function() {
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







    //BusinessRuleId:1978, Attribute:266591, Operation:Field, Event:None

    //BusinessRuleId:688, Attribute:263141, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Fecha_de_Nacimiento', function() {
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
                " SELECT @years", rowIndex, nameOfTable) < TryParseInt('18', '18') && GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { $("a[href='#tabDatos_del_Tutor']").css('display', 'block'); } else { $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); }
    });


    //BusinessRuleId:688, Attribute:263141, Operation:Field, Event:None

    //BusinessRuleId:83, Attribute:263141, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Fecha_de_Nacimiento', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
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


    //BusinessRuleId:83, Attribute:263141, Operation:Field, Event:None

    //BusinessRuleId:597, Attribute:263141, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Fecha_de_Nacimiento', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null') && EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103)," +
                " " +
                " CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Nacimiento]',103),103))", rowIndex, nameOfTable) > TryParseInt('0', '0')) {
            alert(DecodifyText('No se puede ingresar una fecha mayor al día de hoy', rowIndex, nameOfTable));
            AsignarValor($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex), '');
            AsignarValor($('#' + nameOfTable + 'Edad' + rowIndex), '');
        } else {}
    });


    //BusinessRuleId:597, Attribute:263141, Operation:Field, Event:None

    //BusinessRuleId:1384, Attribute:263217, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Fecha_de_Nacimiento_del_Tutor', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null') && EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103)," +
                " CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_Nacimiento_del_Tutor]',103),103))", rowIndex, nameOfTable) > TryParseInt('0', '0')) {
            alert(DecodifyText('No se puede ingresar una fecha mayor al dìa de hoy', rowIndex, nameOfTable));
            AsignarValor($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex), '');
            AsignarValor($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex), '');
        } else {}
    });


    //BusinessRuleId:1384, Attribute:263217, Operation:Field, Event:None

    //BusinessRuleId:1374, Attribute:263217, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Fecha_de_Nacimiento_del_Tutor', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) {
            AsignarValor($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex), EvaluaQuery("DECLARE @date date, @tmpdate date, @years int" +
                " " +
                " SELECT @date = convert(date,(convert(varchar(10),'FLD[Fecha_de_Nacimiento_del_Tutor]',103)),103)" +
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


    //BusinessRuleId:1374, Attribute:263217, Operation:Field, Event:None















    //BusinessRuleId:639, Attribute:263187, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Quien_Resulte_Responsable', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divNombre').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
            $('#divApellido_Paterno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            $('#divApellido_Materno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            $('#divFecha_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
            $('#divAlias').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Alias' + rowIndex));
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
            $('#divCalle_del_Imputado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));
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
        } else {
            $('#divNombre').css('display', 'block');
            $('#divApellido_Paterno').css('display', 'block');
            $('#divApellido_Materno').css('display', 'block');
            $('#divFecha_de_Nacimiento').css('display', 'block');
            $('#divAlias').css('display', 'block');
        }
    });


    //BusinessRuleId:639, Attribute:263187, Operation:Field, Event:None

















    //BusinessRuleId:2532, Attribute:263162, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Pais', function() {
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
        } else {
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        }
    });


    //BusinessRuleId:2532, Attribute:263162, Operation:Field, Event:None



    //BusinessRuleId:3454, Attribute:263143, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Sexo', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Sexo' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) { $('#divGravidez').css('display', 'block'); } else {
            $('#divGravidez').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex));
            AsignarValor($('#' + nameOfTable + 'Gravidez' + rowIndex), 'false');
        }
    });


    //BusinessRuleId:3454, Attribute:263143, Operation:Field, Event:None

    //BusinessRuleId:1978, Attribute:266591, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Persona_Moral', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Persona_Moral' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divCalidad_Juridica').css('display', 'block');
            $('#divRazon_Social').css('display', 'block');
            $("a[href='#tabRepresentante_Legal']").css('display', 'block');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');
        } else {
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            $('#divRazon_Social').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
            $("a[href='#tabRepresentante_Legal']").css('display', 'block');
            $("a[href='#tabRepresentante_Legal']").css('display', 'none');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');
        }
    });


    //BusinessRuleId:1978, Attribute:266591, Operation:Field, Event:None

    //BusinessRuleId:3582, Attribute:265675, Operation:Field, Event:None
    $("#Otros_Domicilios_Probable_ResponsableGrid").on('change', '.Estado', function() {
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

    $("form#CreateOtros_Domicilios_Probable_Responsable").on('change', '#Otros_Domicilios_Probable_ResponsableEstado', function() {
        nameOfTable = 'Otros_Domicilios_Probable_Responsable';
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
    //BusinessRuleId:3582, Attribute:265675, Operation:Field, Event:None





    //BusinessRuleId:3601, Attribute:265803, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Estado_de_Nacimiento', function() {
        nameOfTable = '';
        rowIndex = '';
        var valor = $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).val();
        $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).empty();
        if (!$('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).append($("<option selected />").val("").text(""));
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Municipio WHERE Estado = FLD[Estado_de_Nacimiento]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
            selectData.push({ id: "", text: "" });
            $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Municipio WHERE Estado = FLD[Estado_de_Nacimiento]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
            $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).select2({ data: selectData }) }
        $('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex).val(valor).trigger('change');
    });


    //BusinessRuleId:3601, Attribute:265803, Operation:Field, Event:None



    //BusinessRuleId:2729, Attribute:263187, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Quien_Resulte_Responsable', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            $('#divExpediente_MP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
            $('#divQuien_Resulte_Responsable').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));
            $('#divSe_Presenta_con_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));
            $('#divFolio_Registro_Nacional_de_Detenciones').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));
            $('#divLugar_de_Detencion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Lugar_de_Detencion' + rowIndex));
            $('#divNombre').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
            $('#divApellido_Paterno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            $('#divApellido_Materno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            $('#divNombre_Completo_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
            $('#divAlias').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Alias' + rowIndex));
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
            $('#divCURP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
            $('#divRFC').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex));
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            $('#divRazon_Social').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
            $('#divNacionalidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            $('#divEscolaridad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divPais_de_Origen').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));
            $('#divOriginario_de').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            $('#divPais').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divCodigo_Postal').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
            $('#divCalle_del_Imputado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));
            $('#divNumero_Exterior').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
            $('#divNumero_Interior').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
            $('#divReferencia_de_Domicilio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
            $('#divLatitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
            $('#divLongitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
            $('#divTelefono').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex));
            $('#divExtension').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex));
            $('#divCelular').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex));
            $('#divCorreo_Electronico').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
            $('#divApodo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apodo' + rowIndex));
            $('#divEtnia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex));
            $('#divNo_de_Hijos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex));
            $('#divReligion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex));
            $('#divServicio_Medico').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex));
            $('#divEscolaridad_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex));
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divIncompleto').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Incompleto' + rowIndex));
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
            $('#divViene_en_Estado_de_Ebriedad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));
            $('#divBajo_el_Efecto_de_una_Droga').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));
            $('#divNombre_de_Droga').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
            $('#divInimputable').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Inimputable' + rowIndex));
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $('#divAdicciones_Probable_Responsable').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Adicciones_Probable_Responsable' + rowIndex));
            $('#divLugares_que_Frecuenta').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Lugares_que_Frecuenta' + rowIndex));
            $('#divDatos_Personales_Adicionales').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Personales_Adicionales' + rowIndex));
            $('#divOtras_Identificaciones').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Identificaciones' + rowIndex));
            $('#divDiscapacidad_Mental').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));
            $('#divDiscapacidad_Fisica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));
            $('#divDiscapacidad_Sensorial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));
            $('#divDiscapacidad_Psicosocial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));
            $('#divOtros_Domicilios').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otros_Domicilios' + rowIndex));
            $('#divOtros_Nombres').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otros_Nombres' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            $('#divSexo').css('display', 'block');
            $('#divQuien_Resulte_Responsable').css('display', 'block');
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            $('#divExpediente_MP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
            $("a[href='#tabRepresentante_Legal']").css('display', 'none');
            $('#divSe_Informaron_sus_Derechos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));
            $('#divSe_Informo_el_Procedimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));
            $('#divPais_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex)); } else { $('#divClave').css('display', 'block');
            $('#divPersona_Moral').css('display', 'block');
            $('#divModulo_Atencion_Inicial').css('display', 'block');
            $('#divExpediente_MP').css('display', 'block');
            $('#divQuien_Resulte_Responsable').css('display', 'block');
            $('#divSe_Presenta_con_Detenido').css('display', 'block');
            $('#divFolio_Registro_Nacional_de_Detenciones').css('display', 'block');
            $('#divLugar_de_Detencion').css('display', 'block');
            $('#divNombre').css('display', 'block');
            $('#divApellido_Paterno').css('display', 'block');
            $('#divApellido_Materno').css('display', 'block');
            $('#divNombre_Completo_Detenido').css('display', 'block');
            $('#divAlias').css('display', 'block');
            $('#divFecha_de_Nacimiento').css('display', 'block');
            $('#divEdad').css('display', 'block');
            $('#divSexo').css('display', 'block');
            $('#divEstado_Civil').css('display', 'block');
            $('#divTipo_de_Identificacion').css('display', 'block');
            $('#divNumero_de_Identificacion').css('display', 'block');
            $('#divCURP').css('display', 'block');
            $('#divRFC').css('display', 'block');
            $('#divCalidad_Juridica').css('display', 'block');
            $('#divRazon_Social').css('display', 'block');
            $('#divNacionalidad').css('display', 'block');
            $('#divEscolaridad').css('display', 'block');
            $('#divOcupacion').css('display', 'block');
            $('#divPais_de_Origen').css('display', 'block');
            $('#divOriginario_de').css('display', 'block');
            $('#divPais').css('display', 'block');
            $('#divEstado').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divCodigo_Postal').css('display', 'block');
            $('#divCalle_del_Imputado').css('display', 'block');
            $('#divNumero_Exterior').css('display', 'block');
            $('#divNumero_Interior').css('display', 'block');
            $('#divReferencia_de_Domicilio').css('display', 'block');
            $('#divLatitud').css('display', 'block');
            $('#divLongitud').css('display', 'block');
            $('#divTelefono').css('display', 'block');
            $('#divExtension').css('display', 'block');
            $('#divCelular').css('display', 'block');
            $('#divCorreo_Electronico').css('display', 'block');
            $('#divApodo').css('display', 'block');
            $('#divEtnia').css('display', 'block');
            $('#divNo_de_Hijos').css('display', 'block');
            $('#divReligion').css('display', 'block');
            $('#divServicio_Medico').css('display', 'block');
            $('#divEscolaridad_Detenido').css('display', 'block');
            $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            $('#divIncompleto').css('display', 'block');
            $('#divIdioma').css('display', 'block');
            $('#divCalidad_Migratoria').css('display', 'block');
            $('#divEstado_de_Nacimiento').css('display', 'block');
            $('#divMunicipio_de_Nacimiento').css('display', 'block');
            $('#divDialecto').css('display', 'block');
            $('#divViene_en_Estado_de_Ebriedad').css('display', 'block');
            $('#divBajo_el_Efecto_de_una_Droga').css('display', 'block');
            $('#divNombre_de_Droga').css('display', 'block');
            $('#divInimputable').css('display', 'block');
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $('#divAdicciones_Probable_Responsable').css('display', 'block');
            $('#divLugares_que_Frecuenta').css('display', 'block');
            $('#divDatos_Personales_Adicionales').css('display', 'block');
            $('#divOtras_Identificaciones').css('display', 'block');
            $('#divDiscapacidad_Mental').css('display', 'block');
            $('#divDiscapacidad_Fisica').css('display', 'block');
            $('#divDiscapacidad_Sensorial').css('display', 'block');
            $('#divDiscapacidad_Psicosocial').css('display', 'block');
            $('#divOtros_Domicilios').css('display', 'block');
            $('#divOtros_Nombres').css('display', 'block');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            $('#divExpediente_MP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            AsignarValor($('#' + nameOfTable + 'Inimputable' + rowIndex), 'false');
            AsignarValor($('#' + nameOfTable + 'Persona_Moral' + rowIndex), 'false');
            $('#divNombre_Completo_del_Tutor').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));
            $('#divNombre_Completo_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
            $('#divNombre_Completo2').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));
            $('#divSe_Informaron_sus_Derechos').css('display', 'block');
            $('#divSe_Informo_el_Procedimiento').css('display', 'block');
            $('#divPais_de_Nacimiento').css('display', 'block'); }
    });


    //BusinessRuleId:2729, Attribute:263187, Operation:Field, Event:None



    //BusinessRuleId:1939, Attribute:263211, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Inimputable', function() {
        nameOfTable = '';
        rowIndex = '';
        if (EvaluaQuery("select 'FLD[Inimputable]'", rowIndex, nameOfTable) == TryParseInt('true', 'true')) { $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex)); } else { $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex)); }
    });


    //BusinessRuleId:1939, Attribute:263211, Operation:Field, Event:None



    //BusinessRuleId:1938, Attribute:265807, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Bajo_el_Efecto_de_una_Droga', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $('#divNombre_de_Droga').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex)); } else { $('#divNombre_de_Droga').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex)); }
    });


    //BusinessRuleId:1938, Attribute:265807, Operation:Field, Event:None



    //BusinessRuleId:4082, Attribute:265798, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Escolaridad_Detenido', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex), nameOfTable, rowIndex) == TryParseInt('6', '6')) { $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); } else { SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); }
    });


    //BusinessRuleId:4082, Attribute:265798, Operation:Field, Event:None



    //BusinessRuleId:2534, Attribute:263150, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Estado', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Estado' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();
            $('#' + nameOfTable + 'Municipio' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Municipio' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); } else {}
    });


    //BusinessRuleId:2534, Attribute:263150, Operation:Field, Event:None





















    //BusinessRuleId:4128, Attribute:263226, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Pais_del_Tutor', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null') && GetValueByControlType($('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex), nameOfTable, rowIndex) == TryParseInt('82', '82')) { var valor = $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).val();
            $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE pais = FLD[Pais_del_Tutor]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM ESTADO WHERE pais = FLD[Pais_del_Tutor]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex).val(valor).trigger('change');
            $('#divEstado_del_Tutor').css('display', 'block');
            $('#divMunicipio_del_Tutor').css('display', 'block');
            $('#divColonia_del_Tutor').css('display', 'block'); } else {}
    });


    //BusinessRuleId:4128, Attribute:263226, Operation:Field, Event:None





    //BusinessRuleId:4129, Attribute:263227, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Estado_del_Tutor', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { var valor = $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).val();
            $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio where Estado = FLD[Estado_del_Tutor]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio where Estado = FLD[Estado_del_Tutor]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex).val(valor).trigger('change'); } else {}
    });


    //BusinessRuleId:4129, Attribute:263227, Operation:Field, Event:None









    //BusinessRuleId:2537, Attribute:263151, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Municipio', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
            $('#' + nameOfTable + 'Poblacion' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); } else {}
    });


    //BusinessRuleId:2537, Attribute:263151, Operation:Field, Event:None





    //BusinessRuleId:4122, Attribute:263228, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Municipio_del_Tutor', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { var valor = $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).val();
            $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Colonia WHERE Municipio = FLD[Municipio_del_Tutor] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Colonia WHERE Municipio = FLD[Municipio_del_Tutor] and tipo = 2 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Colonia WHERE Municipio = FLD[Municipio_del_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Colonia WHERE Municipio = FLD[Municipio_del_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val(valor).trigger('change'); } else {}
    });


    //BusinessRuleId:4122, Attribute:263228, Operation:Field, Event:None

    //BusinessRuleId:4125, Attribute:265835, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Poblacion_Tutor', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { var valor = $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Colonia WHERE Poblacion = FLD[Poblacion_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Colonia WHERE Poblacion = FLD[Poblacion_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val(valor).trigger('change'); } else { var valor = $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Colonia WHERE Municipio= FLD[Municipio_del_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT Clave, Nombre FROM Colonia WHERE Municipio= FLD[Municipio_del_Tutor] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex).val(valor).trigger('change'); }
    });


    //BusinessRuleId:4125, Attribute:265835, Operation:Field, Event:None



    //BusinessRuleId:4115, Attribute:265790, Operation:Field, Event:None
    $("form#CreateDetalle_de_Imputado").on('change', '#Poblacion', function() {
        nameOfTable = '';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] and tipo = 1 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE poblacion = FLD[Poblacion] and tipo = 1 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); } else { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 1 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 1 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); }
    });


    //BusinessRuleId:4115, Attribute:265790, Operation:Field, Event:None

    //BusinessRuleId:3583, Attribute:265676, Operation:Field, Event:None
    $("#Otros_Domicilios_Probable_ResponsableGrid").on('change', '.Municipio', function() {
        nameOfTable = $(this).parent().parent().parent().parent()[0].id.replace('Grid', '') + '_';
        rowIndex = '_' + $(this).parent().parent()[0].className.replace(' odd', '').replace(' even', '').replace(nameOfTable, '');
        if (GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
            $('#' + nameOfTable + 'Poblacion' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 2 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 2 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 1 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 1 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); } else {}
        nameOfTable = '';
        rowIndex = '';
    });

    $("form#CreateOtros_Domicilios_Probable_Responsable").on('change', '#Otros_Domicilios_Probable_ResponsableMunicipio', function() {
        nameOfTable = 'Otros_Domicilios_Probable_Responsable';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Municipio' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
            $('#' + nameOfTable + 'Poblacion' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 2 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 2 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 1 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE MUNICIPIO = FLD[Municipio] and tipo = 1 and estatus ='V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); } else {}
    });
    //BusinessRuleId:3583, Attribute:265676, Operation:Field, Event:None

    //BusinessRuleId:4127, Attribute:265677, Operation:Field, Event:None
    $("#Otros_Domicilios_Probable_ResponsableGrid").on('change', '.Poblacion', function() {
        nameOfTable = $(this).parent().parent().parent().parent()[0].id.replace('Grid', '') + '_';
        rowIndex = '_' + $(this).parent().parent()[0].className.replace(' odd', '').replace(' even', '').replace(nameOfTable, '');
        if (GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); } else { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio= FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio= FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); }
        nameOfTable = '';
        rowIndex = '';
    });

    $("form#CreateOtros_Domicilios_Probable_Responsable").on('change', '#Otros_Domicilios_Probable_ResponsablePoblacion', function() {
        nameOfTable = 'Otros_Domicilios_Probable_Responsable';
        rowIndex = '';
        if (GetValueByControlType($('#' + nameOfTable + 'Poblacion' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null')) { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Poblacion = FLD[Poblacion] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); } else { var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty(); if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio= FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); }); } else { var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio= FLD[Municipio] and tipo = 1 and estatus = 'V'", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData }) }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change'); }
    });
    //BusinessRuleId:4127, Attribute:265677, Operation:Field, Event:None





    //NEWBUSINESSRULE_NONE//
});

function EjecutarValidacionesAlComienzo() {
    //INI OCULTAR BOTON DE MAPA
    if (GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
        $("#btnOpenMapa").hide();
    } else {
        $("#btnOpenMapa").show();
    }
    //FIN OCULTAR BOTON DE MAPA






    //BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if ($('#' + nameOfTable + 'Inimputable' + rowIndex).val() == TryParseInt('false', 'false') && $('#' + nameOfTable + 'Edad' + rowIndex).val() == TryParseInt('null', 'null')) { $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); } else {}


    }
    //BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Inimputable' + rowIndex).val() == TryParseInt('false', 'false') && $('#' + nameOfTable + 'Edad' + rowIndex).val() == TryParseInt('null', 'null')) { $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); } else {}


    }
    //BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Inimputable' + rowIndex).val() == TryParseInt('false', 'false') && $('#' + nameOfTable + 'Edad' + rowIndex).val() == TryParseInt('null', 'null')) { $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); } else {}


    }
    //BusinessRuleId:1327, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1722, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divModulo_Atencion_Inicial').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));


    }
    //BusinessRuleId:1722, Attribute:0, Operation:Object, Event:SCREENOPENING



















    //BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divClave').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));


    }
    //BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divClave').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));


    }
    //BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divClave').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));


    }
    //BusinessRuleId:1740, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1741, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true"));


    }
    //BusinessRuleId:1741, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            $('#divNombre_Completo_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
        } else {}


    }
    //BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            $('#divNombre_Completo_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
        } else {}


    }
    //BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) == TryParseInt('4', '4')) {
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            $('#divNombre_Completo_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
        } else {}


    }
    //BusinessRuleId:1934, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divEspecialidad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
        $('#divEstudios_Superiores').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));


    }
    //BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divEspecialidad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
        $('#divEstudios_Superiores').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));


    }
    //BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divEspecialidad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
        $('#divEstudios_Superiores').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));


    }
    //BusinessRuleId:1935, Attribute:0, Operation:Object, Event:SCREENOPENING



    //BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divTipo_de_Inimputabilidad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        $('#divNombre_de_Droga').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
        $('#divEspecifique').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));


    }
    //BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divTipo_de_Inimputabilidad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        $('#divNombre_de_Droga').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
        $('#divEspecifique').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));


    }
    //BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divTipo_de_Inimputabilidad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        $('#divNombre_de_Droga').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
        $('#divEspecifique').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));


    }
    //BusinessRuleId:1937, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cara' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Complexion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Piel' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Frente' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calvicie' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nariz_Base' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Boca' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Barba' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Bigote' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Alias' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_interior_de_los_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_de_los_hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_del_lugar_del_he' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Peso' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatura' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Inimputable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen_tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de_tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'RFC_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Responsable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Responsable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Adicciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Folio_otros_Nombres' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apodo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Idioma' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Dialecto' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Anteojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Senas_Particulares' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Referencia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex));


    }
    //BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cara' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Complexion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Piel' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Frente' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calvicie' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nariz_Base' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Boca' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Barba' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Bigote' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Alias' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_interior_de_los_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_de_los_hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_del_lugar_del_he' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Peso' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatura' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Inimputable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen_tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de_tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'RFC_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Responsable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Responsable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Adicciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Folio_otros_Nombres' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apodo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Idioma' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Dialecto' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Anteojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Senas_Particulares' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Referencia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex));


    }
    //BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cara' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Complexion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Piel' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Frente' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calvicie' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Color_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Ojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nariz_Base' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Boca' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Barba' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Orejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Bigote' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_Fisica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Alias' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_del_Hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_interior_de_los_hecho' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_de_los_hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_del_lugar_del_he' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Peso' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estatura' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Inimputable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen_tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de_tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'CURP_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'RFC_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Responsable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Responsable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Adicciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Folio_otros_Nombres' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apodo' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Idioma' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Dialecto' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Anteojos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Menton' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Senas_Particulares' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Imputado_Recluido' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Referencia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_Tutor' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex));


    }
    //BusinessRuleId:1940, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
        $('#divNombre_Completo_Detenido').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));


    }
    //BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
        $('#divNombre_Completo_Detenido').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));


    }
    //BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
        $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
        $('#divNombre_Completo_Detenido').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));


    }
    //BusinessRuleId:1951, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1952, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divIncompleto').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Incompleto' + rowIndex));


    }
    //BusinessRuleId:1952, Attribute:0, Operation:Object, Event:SCREENOPENING


    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex).val() == TryParseInt('11', '11')) {
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
        if ($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex).val() == TryParseInt('11', '11')) {
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
    //BusinessRuleId:1939, Attribute:263211, Operation:Field, Event:None
    if (operation == 'Update') {
        if ($('#' + nameOfTable + 'Inimputable' + rowIndex).prop("checked") === true) {
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
        } else {
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
        }
    }
    if (operation == 'Consult') {
        if ($('#' + nameOfTable + 'Inimputable' + rowIndex).prop("checked") === true) {
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
        } else {
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
        }
    }


    //BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING
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
    //BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING
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
    //BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING
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
    //BusinessRuleId:1977, Attribute:0, Operation:Object, Event:SCREENOPENING

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

    //BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divNombre_Completo2').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));


    }
    //BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divNombre_Completo2').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));


    }
    //BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divNombre_Completo2').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));


    }
    //BusinessRuleId:1997, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2233, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex), EvaluaQuery("SELECT NUAT FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId] ", rowIndex, nameOfTable));


    }
    //BusinessRuleId:2233, Attribute:0, Operation:Object, Event:SCREENOPENING















    //BusinessRuleId:1358, Attribute:0, Operation:Object, Event:SCREENOPENING
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
                " SELECT @years", rowIndex, nameOfTable) < TryParseInt('18', '18') && GetValueByControlType($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex), nameOfTable, rowIndex) != TryParseInt('null', 'null') || GetValueByControlType($('#' + nameOfTable + 'Inimputable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $("a[href='#tabDatos_del_Tutor']").css('display', 'block'); } else { $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); }


    }
    //BusinessRuleId:1358, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divExpediente_MP').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));


    }
    //BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divExpediente_MP').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));


    }
    //BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divExpediente_MP').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));


    }
    //BusinessRuleId:2509, Attribute:0, Operation:Object, Event:SCREENOPENING













    //REGLA QUIEN RESULTE RESPONSABLE
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            $('#divExpediente_MP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
            $('#divQuien_Resulte_Responsable').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));
            $('#divSe_Presenta_con_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));
            $('#divFolio_Registro_Nacional_de_Detenciones').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));
            $('#divLugar_de_Detencion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Lugar_de_Detencion' + rowIndex));
            $('#divNombre').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
            $('#divApellido_Paterno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            $('#divApellido_Materno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            $('#divNombre_Completo_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
            $('#divAlias').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Alias' + rowIndex));
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
            $('#divCURP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
            $('#divRFC').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex));
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            $('#divRazon_Social').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
            $('#divNacionalidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            $('#divEscolaridad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divPais_de_Origen').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));
            $('#divOriginario_de').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            $('#divPais').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divCodigo_Postal').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
            $('#divCalle_del_Imputado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));
            $('#divNumero_Exterior').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
            $('#divNumero_Interior').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
            $('#divReferencia_de_Domicilio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
            $('#divLatitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
            $('#divLongitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
            $('#divTelefono').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex));
            $('#divExtension').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex));
            $('#divCelular').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex));
            $('#divCorreo_Electronico').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
            $('#divApodo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apodo' + rowIndex));
            $('#divEtnia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex));
            $('#divNo_de_Hijos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex));
            $('#divReligion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex));
            $('#divServicio_Medico').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex));
            $('#divEscolaridad_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex));
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divIncompleto').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Incompleto' + rowIndex));
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
            $('#divViene_en_Estado_de_Ebriedad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));
            $('#divBajo_el_Efecto_de_una_Droga').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));
            $('#divNombre_de_Droga').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
            $('#divInimputable').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Inimputable' + rowIndex));
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $('#divAdicciones_Probable_Responsable').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Adicciones_Probable_Responsable' + rowIndex));
            $('#divLugares_que_Frecuenta').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Lugares_que_Frecuenta' + rowIndex));
            $('#divDatos_Personales_Adicionales').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Personales_Adicionales' + rowIndex));
            $('#divOtras_Identificaciones').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Identificaciones' + rowIndex));
            $('#divDiscapacidad_Mental').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));
            $('#divDiscapacidad_Fisica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));
            $('#divDiscapacidad_Sensorial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));
            $('#divDiscapacidad_Psicosocial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));
            $('#divOtros_Domicilios').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otros_Domicilios' + rowIndex));
            $('#divOtros_Nombres').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otros_Nombres' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            $('#divSexo').css('display', 'block');
            $('#divQuien_Resulte_Responsable').css('display', 'block');
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            $('#divExpediente_MP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
            $("a[href='#tabRepresentante_Legal']").css('display', 'none');
        } else {
            $('#divClave').css('display', 'block');
            $('#divPersona_Moral').css('display', 'block');
            $('#divModulo_Atencion_Inicial').css('display', 'block');
            $('#divExpediente_MP').css('display', 'block');
            $('#divQuien_Resulte_Responsable').css('display', 'block');
            $('#divSe_Presenta_con_Detenido').css('display', 'block');
            $('#divFolio_Registro_Nacional_de_Detenciones').css('display', 'block');
            $('#divLugar_de_Detencion').css('display', 'block');
            $('#divNombre').css('display', 'block');
            $('#divApellido_Paterno').css('display', 'block');
            $('#divApellido_Materno').css('display', 'block');
            $('#divNombre_Completo_Detenido').css('display', 'block');
            $('#divAlias').css('display', 'block');
            $('#divFecha_de_Nacimiento').css('display', 'block');
            $('#divEdad').css('display', 'block');
            $('#divSexo').css('display', 'block');
            $('#divEstado_Civil').css('display', 'block');
            $('#divTipo_de_Identificacion').css('display', 'block');
            $('#divNumero_de_Identificacion').css('display', 'block');
            $('#divCURP').css('display', 'block');
            $('#divRFC').css('display', 'block');
            $('#divCalidad_Juridica').css('display', 'block');
            $('#divRazon_Social').css('display', 'block');
            $('#divNacionalidad').css('display', 'block');
            $('#divEscolaridad').css('display', 'block');
            $('#divOcupacion').css('display', 'block');
            $('#divPais_de_Origen').css('display', 'block');
            $('#divOriginario_de').css('display', 'block');
            $('#divPais').css('display', 'block');
            $('#divEstado').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divCodigo_Postal').css('display', 'block');
            $('#divCalle_del_Imputado').css('display', 'block');
            $('#divNumero_Exterior').css('display', 'block');
            $('#divNumero_Interior').css('display', 'block');
            $('#divReferencia_de_Domicilio').css('display', 'block');
            $('#divLatitud').css('display', 'block');
            $('#divLongitud').css('display', 'block');
            $('#divTelefono').css('display', 'block');
            $('#divExtension').css('display', 'block');
            $('#divCelular').css('display', 'block');
            $('#divCorreo_Electronico').css('display', 'block');
            $('#divApodo').css('display', 'block');
            $('#divEtnia').css('display', 'block');
            $('#divNo_de_Hijos').css('display', 'block');
            $('#divReligion').css('display', 'block');
            $('#divServicio_Medico').css('display', 'block');
            $('#divEscolaridad_Detenido').css('display', 'block');
            $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            $('#divIncompleto').css('display', 'block');
            $('#divIdioma').css('display', 'block');
            $('#divCalidad_Migratoria').css('display', 'block');
            $('#divEstado_de_Nacimiento').css('display', 'block');
            $('#divMunicipio_de_Nacimiento').css('display', 'block');
            $('#divDialecto').css('display', 'block');
            $('#divViene_en_Estado_de_Ebriedad').css('display', 'block');
            $('#divBajo_el_Efecto_de_una_Droga').css('display', 'block');
            $('#divNombre_de_Droga').css('display', 'block');
            $('#divInimputable').css('display', 'block');
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $('#divAdicciones_Probable_Responsable').css('display', 'block');
            $('#divLugares_que_Frecuenta').css('display', 'block');
            $('#divDatos_Personales_Adicionales').css('display', 'block');
            $('#divOtras_Identificaciones').css('display', 'block');
            $('#divDiscapacidad_Mental').css('display', 'block');
            $('#divDiscapacidad_Fisica').css('display', 'block');
            $('#divDiscapacidad_Sensorial').css('display', 'block');
            $('#divDiscapacidad_Psicosocial').css('display', 'block');
            $('#divOtros_Domicilios').css('display', 'block');
            $('#divOtros_Nombres').css('display', 'block');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            $('#divExpediente_MP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            AsignarValor($('#' + nameOfTable + 'Inimputable' + rowIndex), 'false');
            //AsignarValor($('#' + nameOfTable + 'Persona_Moral' + rowIndex), 'false');
            $('#divNombre_Completo_del_Tutor').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));
            $('#divNombre_Completo_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
            $('#divNombre_Completo2').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));
        }
    }
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divPersona_Moral').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            $('#divExpediente_MP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
            $('#divQuien_Resulte_Responsable').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex));
            $('#divSe_Presenta_con_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex));
            $('#divFolio_Registro_Nacional_de_Detenciones').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex));
            $('#divLugar_de_Detencion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Lugar_de_Detencion' + rowIndex));
            $('#divNombre').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
            $('#divApellido_Paterno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
            $('#divApellido_Materno').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));
            $('#divNombre_Completo_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
            $('#divAlias').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Alias' + rowIndex));
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
            $('#divCURP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex));
            $('#divRFC').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex));
            $('#divCalidad_Juridica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex));
            $('#divRazon_Social').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex));
            $('#divNacionalidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex));
            $('#divEscolaridad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));
            $('#divOcupacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex));
            $('#divPais_de_Origen').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen' + rowIndex));
            $('#divOriginario_de').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
            $('#divPais').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex));
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divCodigo_Postal').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
            $('#divCalle_del_Imputado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex));
            $('#divNumero_Exterior').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
            $('#divNumero_Interior').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
            $('#divReferencia_de_Domicilio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex));
            $('#divLatitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex));
            $('#divLongitud').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex));
            $('#divTelefono').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex));
            $('#divExtension').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex));
            $('#divCelular').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex));
            $('#divCorreo_Electronico').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
            $('#divApodo').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Apodo' + rowIndex));
            $('#divEtnia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex));
            $('#divNo_de_Hijos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex));
            $('#divReligion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex));
            $('#divServicio_Medico').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex));
            $('#divEscolaridad_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex));
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divIncompleto').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Incompleto' + rowIndex));
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
            $('#divViene_en_Estado_de_Ebriedad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex));
            $('#divBajo_el_Efecto_de_una_Droga').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex));
            $('#divNombre_de_Droga').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
            $('#divInimputable').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Inimputable' + rowIndex));
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $('#divAdicciones_Probable_Responsable').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Adicciones_Probable_Responsable' + rowIndex));
            $('#divLugares_que_Frecuenta').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Lugares_que_Frecuenta' + rowIndex));
            $('#divDatos_Personales_Adicionales').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Datos_Personales_Adicionales' + rowIndex));
            $('#divOtras_Identificaciones').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Identificaciones' + rowIndex));
            $('#divDiscapacidad_Mental').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex));
            $('#divDiscapacidad_Fisica').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex));
            $('#divDiscapacidad_Sensorial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex));
            $('#divDiscapacidad_Psicosocial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex));
            $('#divOtros_Domicilios').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otros_Domicilios' + rowIndex));
            $('#divOtros_Nombres').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Otros_Nombres' + rowIndex));
            $("a[href='#tabDatos_de_los_Hechos']").css('display', 'none');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none');
            $('#divSexo').css('display', 'block');
            $('#divQuien_Resulte_Responsable').css('display', 'block');
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            $('#divExpediente_MP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
            $("a[href='#tabRepresentante_Legal']").css('display', 'none');
        } else {
            $('#divClave').css('display', 'block');
            $('#divPersona_Moral').css('display', 'block');
            $('#divModulo_Atencion_Inicial').css('display', 'block');
            $('#divExpediente_MP').css('display', 'block');
            $('#divQuien_Resulte_Responsable').css('display', 'block');
            $('#divSe_Presenta_con_Detenido').css('display', 'block');
            $('#divFolio_Registro_Nacional_de_Detenciones').css('display', 'block');
            $('#divLugar_de_Detencion').css('display', 'block');
            $('#divNombre').css('display', 'block');
            $('#divApellido_Paterno').css('display', 'block');
            $('#divApellido_Materno').css('display', 'block');
            $('#divNombre_Completo_Detenido').css('display', 'block');
            $('#divAlias').css('display', 'block');
            $('#divFecha_de_Nacimiento').css('display', 'block');
            $('#divEdad').css('display', 'block');
            $('#divSexo').css('display', 'block');
            $('#divEstado_Civil').css('display', 'block');
            $('#divTipo_de_Identificacion').css('display', 'block');
            $('#divNumero_de_Identificacion').css('display', 'block');
            $('#divCURP').css('display', 'block');
            $('#divRFC').css('display', 'block');
            $('#divCalidad_Juridica').css('display', 'block');
            $('#divRazon_Social').css('display', 'block');
            $('#divNacionalidad').css('display', 'block');
            $('#divEscolaridad').css('display', 'block');
            $('#divOcupacion').css('display', 'block');
            $('#divPais_de_Origen').css('display', 'block');
            $('#divOriginario_de').css('display', 'block');
            $('#divPais').css('display', 'block');
            $('#divEstado').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divCodigo_Postal').css('display', 'block');
            $('#divCalle_del_Imputado').css('display', 'block');
            $('#divNumero_Exterior').css('display', 'block');
            $('#divNumero_Interior').css('display', 'block');
            $('#divReferencia_de_Domicilio').css('display', 'block');
            $('#divLatitud').css('display', 'block');
            $('#divLongitud').css('display', 'block');
            $('#divTelefono').css('display', 'block');
            $('#divExtension').css('display', 'block');
            $('#divCelular').css('display', 'block');
            $('#divCorreo_Electronico').css('display', 'block');
            $('#divApodo').css('display', 'block');
            $('#divEtnia').css('display', 'block');
            $('#divNo_de_Hijos').css('display', 'block');
            $('#divReligion').css('display', 'block');
            $('#divServicio_Medico').css('display', 'block');
            $('#divEscolaridad_Detenido').css('display', 'block');
            $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            $('#divIncompleto').css('display', 'block');
            $('#divIdioma').css('display', 'block');
            $('#divCalidad_Migratoria').css('display', 'block');
            $('#divEstado_de_Nacimiento').css('display', 'block');
            $('#divMunicipio_de_Nacimiento').css('display', 'block');
            $('#divDialecto').css('display', 'block');
            $('#divViene_en_Estado_de_Ebriedad').css('display', 'block');
            $('#divBajo_el_Efecto_de_una_Droga').css('display', 'block');
            $('#divNombre_de_Droga').css('display', 'block');
            $('#divInimputable').css('display', 'block');
            $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $('#divAdicciones_Probable_Responsable').css('display', 'block');
            $('#divLugares_que_Frecuenta').css('display', 'block');
            $('#divDatos_Personales_Adicionales').css('display', 'block');
            $('#divOtras_Identificaciones').css('display', 'block');
            $('#divDiscapacidad_Mental').css('display', 'block');
            $('#divDiscapacidad_Fisica').css('display', 'block');
            $('#divDiscapacidad_Sensorial').css('display', 'block');
            $('#divDiscapacidad_Psicosocial').css('display', 'block');
            $('#divOtros_Domicilios').css('display', 'block');
            $('#divOtros_Nombres').css('display', 'block');
            $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');
            $('#divClave').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex));
            $('#divModulo_Atencion_Inicial').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex));
            $('#divExpediente_MP').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex));
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            AsignarValor($('#' + nameOfTable + 'Inimputable' + rowIndex), 'false');
            //AsignarValor($('#' + nameOfTable + 'Persona_Moral' + rowIndex), 'false');
            $('#divNombre_Completo_del_Tutor').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex));
            $('#divNombre_Completo_Detenido').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex));
            $('#divNombre_Completo2').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex));
        }
    }

    //BusinessRuleId:2945, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divExpediente_MASC').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


    }
    //BusinessRuleId:2945, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2945, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divExpediente_MASC').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


    }
    //BusinessRuleId:2945, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2945, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divExpediente_MASC').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


    }
    //BusinessRuleId:2945, Attribute:0, Operation:Object, Event:SCREENOPENING













    //BusinessRuleId:2531, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex), nameOfTable, rowIndex) == TryParseInt('82', '82')) {
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
            var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
            if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
                $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
            } else {
                var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
            }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
            var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
            $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();
            if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) {
                $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); });
            } else {
                var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData })
            }
            $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
            $('#divEstado').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
        } else {
            $('#divEstado').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        }


    }
    //BusinessRuleId:2531, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2531, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex), nameOfTable, rowIndex) == TryParseInt('82', '82')) {
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
            var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
            if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
                $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
            } else {
                var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
            }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
            var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
            $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();
            if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) {
                $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); });
            } else {
                var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData })
            }
            $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
            $('#divEstado').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
        } else {
            $('#divEstado').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        }


    }
    //BusinessRuleId:2531, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2531, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Pais' + rowIndex), nameOfTable, rowIndex) == TryParseInt('82', '82')) {
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
            var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();
            $('#' + nameOfTable + 'Colonia' + rowIndex).empty();
            if (!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete')) {
                $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value)); });
            } else {
                var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Colonia' + rowIndex).select2({ data: selectData })
            }
            $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');
            var valor = $('#' + nameOfTable + 'Poblacion' + rowIndex).val();
            $('#' + nameOfTable + 'Poblacion' + rowIndex).empty();
            if (!$('#' + nameOfTable + 'Poblacion' + rowIndex).hasClass('AutoComplete')) {
                $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option selected />").val("").text(""));
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { $('#' + nameOfTable + 'Poblacion' + rowIndex).append($("<option />").val(index).text(value)); });
            } else {
                var selectData = [];
                selectData.push({ id: "", text: "" });
                $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function(index, value) { selectData.push({ id: index, text: value }); });
                $('#' + nameOfTable + 'Poblacion' + rowIndex).select2({ data: selectData })
            }
            $('#' + nameOfTable + 'Poblacion' + rowIndex).val(valor).trigger('change');
            $('#divEstado').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
        } else {
            $('#divEstado').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        }


    }
    //BusinessRuleId:2531, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3581, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Persona_Moral' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none'); } else { $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block'); }


    }
    //BusinessRuleId:3581, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3581, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Persona_Moral' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none'); } else { $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block'); }


    }
    //BusinessRuleId:3581, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3585, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divApodo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Apodo' + rowIndex));


    }
    //BusinessRuleId:3585, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3585, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divApodo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Apodo' + rowIndex));


    }
    //BusinessRuleId:3585, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3585, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divApodo').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Apodo' + rowIndex));


    }
    //BusinessRuleId:3585, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3714, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divOriginario_de').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
        $('#divOriginario_de_tutor').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de_tutor' + rowIndex));


    }
    //BusinessRuleId:3714, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3714, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divOriginario_de').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex));
        $('#divOriginario_de_tutor').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de_tutor' + rowIndex));


    }
    //BusinessRuleId:3714, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3850, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));


    }
    //BusinessRuleId:3850, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3850, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));


    }
    //BusinessRuleId:3850, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3850, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));


    }
    //BusinessRuleId:3850, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        $('#divEscolaridad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));


    }
    //BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        $('#divEscolaridad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));


    }
    //BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        $('#divEscolaridad').css('display', 'none');
        SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex));


    }
    //BusinessRuleId:2454, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3855, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Inimputable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex)); } else { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); }


    }
    //BusinessRuleId:3855, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3855, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Inimputable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex)); } else { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); }


    }
    //BusinessRuleId:3855, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3855, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Inimputable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $('#divTipo_de_Inimputabilidad').css('display', 'block');
            $('#divEspecifique').css('display', 'block');
            $("a[href='#tabDatos_del_Tutor']").css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex)); } else { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divTipo_de_Inimputabilidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex));
            $('#divEspecifique').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex));
            $("a[href='#tabDatos_del_Tutor']").css('display', 'none'); }


    }
    //BusinessRuleId:3855, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4083, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex), nameOfTable, rowIndex) == TryParseInt('6', '6')) { $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); } else { SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); }


    }
    //BusinessRuleId:4083, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4083, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex), nameOfTable, rowIndex) == TryParseInt('6', '6')) { $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); } else { SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); }


    }
    //BusinessRuleId:4083, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4083, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex), nameOfTable, rowIndex) == TryParseInt('6', '6')) { $('#divEspecialidad').css('display', 'block');
            $('#divEstudios_Superiores').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); } else { SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex));
            $('#divEspecialidad').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex));
            $('#divEstudios_Superiores').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); }


    }
    //BusinessRuleId:4083, Attribute:0, Operation:Object, Event:SCREENOPENING







    //BusinessRuleId:4084, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Sexo' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) { $('#divGravidez').css('display', 'block'); } else { $('#divGravidez').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex)); }


    }
    //BusinessRuleId:4084, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4084, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Sexo' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) { $('#divGravidez').css('display', 'block'); } else { $('#divGravidez').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex)); }


    }
    //BusinessRuleId:4084, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4084, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Sexo' + rowIndex), nameOfTable, rowIndex) == TryParseInt('1', '1')) { $('#divGravidez').css('display', 'block'); } else { $('#divGravidez').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex)); }


    }
    //BusinessRuleId:4084, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3856, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $('#divNombre_de_Droga').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex)); } else { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
            $('#divNombre_de_Droga').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex)); }


    }
    //BusinessRuleId:3856, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3856, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $('#divNombre_de_Droga').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex)); } else { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
            $('#divNombre_de_Droga').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex)); }


    }
    //BusinessRuleId:3856, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3856, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $('#divNombre_de_Droga').css('display', 'block');
            SetRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex)); } else { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex));
            $('#divNombre_de_Droga').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex)); }


    }
    //BusinessRuleId:3856, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:4112, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (EvaluaQuery("SELECT canalizado FROM Detalle_de_Imputado WHERE Clave = FLDD[lblClave]", rowIndex, nameOfTable) == TryParseInt('1', '1') && TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]')) == TryParseInt('2', '2')) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Edad" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Sexo" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Sexo' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_Civil" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Ocupacion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle_del_Imputado" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Imputado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Telefono" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Telefono' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Extension" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Extension' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Celular" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Celular' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Correo_Electronico" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_Cara" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cara' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Cejas" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Cejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Cantidad_Cabello" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Cantidad_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Implantacion_Cabello" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Implantacion_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Complexion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Complexion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Color_Piel" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Color_Piel' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Frente" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Frente' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_Cabello" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Color_Cabello" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Color_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calvicie" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calvicie' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Color_Ojos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Color_Ojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Ojos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Ojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_Ojos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Ojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nariz_Base" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nariz_Base' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Labios" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Labios' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Boca" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Boca' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Menton" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Menton' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Barba" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Barba' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_Orejas" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_Orejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tamano_Orejas" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_Orejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_Lobulo" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_Lobulo' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Bigote" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Bigote' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Situacion_Fisica" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Situacion_Fisica' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Alias" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Alias' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Quien_Resulte_Responsable" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_de_Nacimiento" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia_de_Domicilio" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia_de_Domicilio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Narrativa_Breve_de_los_Hechos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Narrativa_Breve_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Prioridad_del_Hecho" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Prioridad_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_del_Hecho" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Hora_Aproximada_del_Hecho" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_Aproximada_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_del_hecho" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_del_Hecho" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_del_Hecho" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_del_Hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia_del_hecho" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_del_hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal_del_hecho" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle_del_hecho" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior_de_los_Hechos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_interior_de_los_hecho" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_interior_de_los_hecho' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud_de_los_hechos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_de_los_hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud_de_los_Hechos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_de_los_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_del_lugar_del_he" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_del_lugar_del_he' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Peso" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Peso' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estatura" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estatura' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Inimputable" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Inimputable' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Inimputabilidad" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Inimputabilidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_Completo_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Nacimiento_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Nacimiento_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Edad_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Edad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Sexo_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Sexo_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_Civil_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_Civil_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Identificacion_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Identificacion_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_de_Identificacion_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_de_Identificacion_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Ocupacion_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Ocupacion_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Telefono_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Telefono_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Extension_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Extension_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Celular_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Celular_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Correo_Electronico_del_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico_del_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Pais_de_Origen_tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Origen_tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Originario_de_tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Originario_de_tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "RFC" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'RFC' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "CURP_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'CURP_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "RFC_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'RFC_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Probable_Responsable" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Responsable' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Y_Calle" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Probable_Responsable" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Responsable' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Detencion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_de_Detencion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Corporacion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Probable_Resposable" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Probable_Resposable" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Correo_Electronico" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Telefonico" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Redes_Sociales" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Probable_Resposable" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Probable_Resposable' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tipo_de_identificacion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio_Adicciones" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Adicciones' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Clave' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio_otros_Nombres" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio_otros_Nombres' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombres" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombres' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Suspension_Condicional" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Suspension_Condicional' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Fecha_de_Suspension_Condicional" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Se_Presenta_con_Detenido" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Se_Presenta_con_Detenido' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Folio_Registro_Nacional_de_Detenciones" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Folio_Registro_Nacional_de_Detenciones' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_Completo_Detenido" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo_Detenido' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apodo" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apodo' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Etnia" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Etnia' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "No_de_Hijos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'No_de_Hijos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Religion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Religion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Servicio_Medico" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Servicio_Medico' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad_Detenido" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad_Detenido' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Especialidad" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Especialidad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estudios_Superiores" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estudios_Superiores' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Idioma" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Idioma' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calidad_Migratoria" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Migratoria' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Estado_de_Nacimiento" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Estado_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Municipio_de_Nacimiento" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Nacimiento' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Dialecto" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Dialecto' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Viene_en_Estado_de_Ebriedad" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Viene_en_Estado_de_Ebriedad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Bajo_el_Efecto_de_una_Droga" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Bajo_el_Efecto_de_una_Droga' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_de_Droga" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_de_Droga' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Mental" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Mental' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Fisica" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Fisica' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Sensorial" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Sensorial' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Discapacidad_Psicosocial" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Discapacidad_Psicosocial' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Padecimiento_de_Enfermedad" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Padecimiento_de_Enfermedad' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Tamano_de_Cejas" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Tamano_de_Cejas' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Largo_de_Cabello" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Largo_de_Cabello' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Anteojos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Anteojos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_de_Nariz" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Nariz' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Grosor_de_Labios" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Grosor_de_Labios' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Forma_de_Menton" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Forma_de_Menton' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Senas_Particulares" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Senas_Particulares' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Imagen_Tatuaje" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Imagen_Tatuaje' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Otras_Senas_Particulares" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Otras_Senas_Particulares' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Imputado_Recluido" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Imputado_Recluido' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion_Hechos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Hechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Poblacion_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Referencia" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Referencia' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Latitud_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Latitud_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Longitud_Tutor" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Longitud_Tutor' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Especifique" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Especifique' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Modulo_Atencion_Inicial" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Modulo_Atencion_Inicial' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Incompleto" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Incompleto' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Persona_Moral" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Persona_Moral' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Calidad_Juridica" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Calidad_Juridica' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Razon_Social" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Razon_Social' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombres2" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombres2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno2" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno2" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nombre_Completo2" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nombre_Completo2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Sexo2" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Sexo2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Nacionalidad2" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Nacionalidad2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Escolaridad2" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Escolaridad2' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "ID_Estado_Institucion" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'ID_Estado_Institucion' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MP' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Coordenada_X" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Coordenada_Y" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Gravidez" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Expediente_MASC" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Expediente_MASC' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Paterno" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Apellido_Materno" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Se_Informaron_sus_Derechos" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex)); }
            DisabledControl($("#" + nameOfTable + "Se_Informo_el_Procedimiento" + rowIndex), ("true" == "true")); if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex)); } } else {}


    }
    //BusinessRuleId:4112, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3881, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        if (GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');
            $('#divPais_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));
            $('#divGravidez').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex));
            $('#divSe_Informaron_sus_Derechos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));
            $('#divSe_Informo_el_Procedimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex)); } else { $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');
            $('#divPais_de_Nacimiento').css('display', 'block');
            $('#divGravidez').css('display', 'block');
            $('#divSe_Informaron_sus_Derechos').css('display', 'block');
            $('#divSe_Informo_el_Procedimiento').css('display', 'block');
            $('#divEstado').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divPoblacion').css('display', 'block'); }


    }
    //BusinessRuleId:3881, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3881, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        if (GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');
            $('#divPais_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));
            $('#divGravidez').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex));
            $('#divSe_Informaron_sus_Derechos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));
            $('#divSe_Informo_el_Procedimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex)); } else { $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');
            $('#divPais_de_Nacimiento').css('display', 'block');
            $('#divGravidez').css('display', 'block');
            $('#divSe_Informaron_sus_Derechos').css('display', 'block');
            $('#divSe_Informo_el_Procedimiento').css('display', 'block');
            $('#divEstado').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divPoblacion').css('display', 'block'); }


    }
    //BusinessRuleId:3881, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:3881, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Consult') {
        if (GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) { $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'none');
            $('#divPais_de_Nacimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Pais_de_Nacimiento' + rowIndex));
            $('#divGravidez').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Gravidez' + rowIndex));
            $('#divSe_Informaron_sus_Derechos').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));
            $('#divSe_Informo_el_Procedimiento').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));
            $('#divEstado').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
            $('#divMunicipio').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
            $('#divColonia').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
            $('#divPoblacion').css('display', 'none');
            SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex)); } else { $("a[href='#tabDatos_de_Media_Filiacion']").css('display', 'block');
            $('#divPais_de_Nacimiento').css('display', 'block');
            $('#divGravidez').css('display', 'block');
            $('#divSe_Informaron_sus_Derechos').css('display', 'block');
            $('#divSe_Informo_el_Procedimiento').css('display', 'block');
            $('#divEstado').css('display', 'block');
            $('#divMunicipio').css('display', 'block');
            $('#divColonia').css('display', 'block');
            $('#divPoblacion').css('display', 'block');
            $('#divPoblacion').css('display', 'block'); }


    }
    //BusinessRuleId:3881, Attribute:0, Operation:Object, Event:SCREENOPENING

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
                $('#' + nameOfTable + 'Numero_de_Identificacion' + rowIndex).attr("placeholder", "El formato del CURP es incorrecto.").focus();
                return false;
            }
        }
    }



















    //BusinessRuleId:3576, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'New') {
        if (EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId] AND Quien_Resulte_Responsable = 1", rowIndex, nameOfTable) > TryParseInt('0', '0') && GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            alert(DecodifyText('Solo puede existir un probable Responsable del tipo Quien resulte Responsable, favor de verificar.', rowIndex, nameOfTable));

            result = false;
        } else {}


    }
    //BusinessRuleId:3576, Attribute:2, Operation:Object, Event:BEFORESAVING

    //BusinessRuleId:3577, Attribute:2, Operation:Object, Event:BEFORESAVING
    if (operation == 'Update') {
        if (EvaluaQuery("SELECT COUNT(Clave) FROM Detalle_de_Imputado WHERE Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId] AND Quien_Resulte_Responsable = 1 AND Clave <> FLDD[lblClave]", rowIndex, nameOfTable) > TryParseInt('0', '0') && GetValueByControlType($('#' + nameOfTable + 'Quien_Resulte_Responsable' + rowIndex), nameOfTable, rowIndex) == TryParseInt('true', 'true')) {
            alert(DecodifyText('Solo puede existir un probable Responsable del tipo Quien resulte Responsable, favor de verificar.', rowIndex, nameOfTable));

            result = false;
        } else {}


    }
    //BusinessRuleId:3577, Attribute:2, Operation:Object, Event:BEFORESAVING





    //NEWBUSINESSRULE_BEFORESAVING//
    return result;
}

function EjecutarValidacionesDespuesDeGuardar() {
    //BusinessRuleId:1731, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        EvaluaQuery(" update Detalle_de_Imputado" +
            " 	set Modulo_Atencion_Inicial= GLOBAL[SpartanOperationId]" +
            " 	where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);


    }
    //BusinessRuleId:1731, Attribute:2, Operation:Object, Event:AFTERSAVING









    //BusinessRuleId:2511, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]')) == TryParseInt('3', '3')) { EvaluaQuery(" update Detalle_de_Imputado set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); } else {}


    }
    //BusinessRuleId:2511, Attribute:2, Operation:Object, Event:AFTERSAVING

    //BusinessRuleId:2511, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'Update') {
        if (TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]')) == TryParseInt('3', '3')) { EvaluaQuery(" update Detalle_de_Imputado set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable); } else {}


    }
    //BusinessRuleId:2511, Attribute:2, Operation:Object, Event:AFTERSAVING

    //BusinessRuleId:3604, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        EvaluaQuery(" EXEC ActualizarNombresProbableResponsable GLOBAL[KeyValueInserted] ", rowIndex, nameOfTable);


    }
    //BusinessRuleId:3604, Attribute:2, Operation:Object, Event:AFTERSAVING





    //BusinessRuleId:3605, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'Update') {
        EvaluaQuery("  EXEC ActualizarNombresProbableResponsable FLDD[lblClave]", rowIndex, nameOfTable);

    }
    //BusinessRuleId:3605, Attribute:2, Operation:Object, Event:AFTERSAVING

    //BusinessRuleId:4117, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'New') {
        EvaluaQuery("exec uspActualizadatosGeneracionExpediente GLOBAL[SpartanOperationId]", rowIndex, nameOfTable);


    }
    //BusinessRuleId:4117, Attribute:2, Operation:Object, Event:AFTERSAVING

    //BusinessRuleId:4117, Attribute:2, Operation:Object, Event:AFTERSAVING
    if (operation == 'Update') {
        EvaluaQuery("exec uspActualizadatosGeneracionExpediente GLOBAL[SpartanOperationId]", rowIndex, nameOfTable);


    }
    //BusinessRuleId:4117, Attribute:2, Operation:Object, Event:AFTERSAVING

    //NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRAdicciones_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    var ind = rowIndex.substr(1, 1);
    var i = 0;
    while (i < ind) {
        if ($('#' + nameOfTable + 'Descripcion_' + i).text() == $('#' + nameOfTable + 'Descripcion' + rowIndex).find(":selected").text()) {
            result = false;
            alert(DecodifyText('No se puede duplicar el tipo de identificación.', rowIndex, nameOfTable));
            break;
        }
        i++;
    }
    //NEWBUSINESSRULE_BEFORESAVINGMR_Adicciones_Probable_Responsable//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMRAdicciones_Probable_Responsable(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Adicciones_Probable_Responsable//
}

function EjecutarValidacionesAlEliminarMRAdicciones_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Adicciones_Probable_Responsable//
    return result;
}

function EjecutarValidacionesNewRowMRAdicciones_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:2733, Attribute:265809, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2733, Attribute:265809, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2733, Attribute:265809, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2733, Attribute:265809, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Adicciones_Probable_Responsable//
    return result;
}

function EjecutarValidacionesEditRowMRAdicciones_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:2733, Attribute:265809, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2733, Attribute:265809, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2733, Attribute:265809, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2733, Attribute:265809, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Adicciones_Probable_Responsable//
    return result;
}

function EjecutarValidacionesAntesDeGuardarMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Lugares_Frecuentes_Probable_Responsable//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Lugares_Frecuentes_Probable_Responsable//
}

function EjecutarValidacionesAlEliminarMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Lugares_Frecuentes_Probable_Responsable//
    return result;
}

function EjecutarValidacionesNewRowMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;




    //BusinessRuleId:2734, Attribute:265810, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2734, Attribute:265810, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2734, Attribute:265810, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2734, Attribute:265810, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Lugares_Frecuentes_Probable_Responsable//
    return result;
}

function EjecutarValidacionesEditRowMRLugares_Frecuentes_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;




    //BusinessRuleId:2734, Attribute:265810, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2734, Attribute:265810, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2734, Attribute:265810, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2734, Attribute:265810, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Lugares_Frecuentes_Probable_Responsable//
    return result;
}

function EjecutarValidacionesAntesDeGuardarMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Datos_Personales_Adicionales_Probable_Responsable//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Datos_Personales_Adicionales_Probable_Responsable//
}

function EjecutarValidacionesAlEliminarMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Datos_Personales_Adicionales_Probable_Responsable//
    return result;
}

function EjecutarValidacionesNewRowMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:2735, Attribute:265811, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2735, Attribute:265811, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2735, Attribute:265811, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2735, Attribute:265811, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Datos_Personales_Adicionales_Probable_Responsable//
    return result;
}

function EjecutarValidacionesEditRowMRDatos_Personales_Adicionales_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:2735, Attribute:265811, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2735, Attribute:265811, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2735, Attribute:265811, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Correo_Electronico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Telefonico' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Redes_Sociales' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2735, Attribute:265811, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Datos_Personales_Adicionales_Probable_Responsable//
    return result;
}

function EjecutarValidacionesAntesDeGuardarMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    var ind = rowIndex.substr(1, 1);
    var i = 0;
    while (i < ind) {
        if ($('#' + nameOfTable + 'Tipo_de_identificacion_' + i).text() == $('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex).find(":selected").text()) {
            result = false;
            alert(DecodifyText('No se puede duplicar el tipo de identificación.', rowIndex, nameOfTable));
            break;
        }
        i++;
    }
    //NEWBUSINESSRULE_BEFORESAVINGMR_Otras_Identificaciones_Probable_Responsable//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Otras_Identificaciones_Probable_Responsable//
}

function EjecutarValidacionesAlEliminarMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Otras_Identificaciones_Probable_Responsable//
    return result;
}

function EjecutarValidacionesNewRowMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:2736, Attribute:265812, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2736, Attribute:265812, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2736, Attribute:265812, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2736, Attribute:265812, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Otras_Identificaciones_Probable_Responsable//
    return result;
}

function EjecutarValidacionesEditRowMROtras_Identificaciones_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:2736, Attribute:265812, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2736, Attribute:265812, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2736, Attribute:265812, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Tipo_de_identificacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Descripcion' + rowIndex));


    }
    //BusinessRuleId:2736, Attribute:265812, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Otras_Identificaciones_Probable_Responsable//
    return result;
}

function EjecutarValidacionesAntesDeGuardarMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Otros_Domicilios_Probable_Responsable//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Otros_Domicilios_Probable_Responsable//
}

function EjecutarValidacionesAlEliminarMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Otros_Domicilios_Probable_Responsable//
    return result;
}

function EjecutarValidacionesNewRowMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;




    //BusinessRuleId:2737, Attribute:265889, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex));


    }
    //BusinessRuleId:2737, Attribute:265889, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2737, Attribute:265889, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex));


    }
    //BusinessRuleId:2737, Attribute:265889, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Otros_Domicilios_Probable_Responsable//
    return result;
}

function EjecutarValidacionesEditRowMROtros_Domicilios_Probable_Responsable(nameOfTable, rowIndex) {
    var result = true;




    //BusinessRuleId:2737, Attribute:265889, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex));


    }
    //BusinessRuleId:2737, Attribute:265889, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2737, Attribute:265889, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Estado' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Colonia' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Codigo_Postal' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Entre_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Y_Calle' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Exterior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Poblacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Numero_Interior' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_X' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Coordenada_Y' + rowIndex));


    }
    //BusinessRuleId:2737, Attribute:265889, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Otros_Domicilios_Probable_Responsable//
    return result;
}

function EjecutarValidacionesAntesDeGuardarMROtros_Nombres(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Otros_Nombres//
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMROtros_Nombres(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Otros_Nombres//
}

function EjecutarValidacionesAlEliminarMROtros_Nombres(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Otros_Nombres//
    return result;
}

function EjecutarValidacionesNewRowMROtros_Nombres(nameOfTable, rowIndex) {
    var result = true;




    //BusinessRuleId:2739, Attribute:265817, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));


    }
    //BusinessRuleId:2739, Attribute:265817, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2739, Attribute:265817, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));


    }
    //BusinessRuleId:2739, Attribute:265817, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Otros_Nombres//
    return result;
}

function EjecutarValidacionesEditRowMROtros_Nombres(nameOfTable, rowIndex) {
    var result = true;




    //BusinessRuleId:2739, Attribute:265817, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));


    }
    //BusinessRuleId:2739, Attribute:265817, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2739, Attribute:265817, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Nombre' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Paterno' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Apellido_Materno' + rowIndex));


    }
    //BusinessRuleId:2739, Attribute:265817, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Otros_Nombres//
    return result;
}


function EjecutarValidacionesAntesDeGuardarMRLugar_de_Detencion(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Lugar_de_Detencion// 
    return result;
}

function EjecutarValidacionesDespuesDeGuardarMRLugar_de_Detencion(nameOfTable, rowIndex) {
    //NEWBUSINESSRULE_AFTERSAVINGMR_Lugar_de_Detencion// 
}

function EjecutarValidacionesAlEliminarMRLugar_de_Detencion(nameOfTable, rowIndex) {
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Lugar_de_Detencion// 
    return result;
}

function EjecutarValidacionesNewRowMRLugar_de_Detencion(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:2732, Attribute:265786, Operation:Object, Event:NEWROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));


    }
    //BusinessRuleId:2732, Attribute:265786, Operation:Object, Event:NEWROWMR

    //BusinessRuleId:2732, Attribute:265786, Operation:Object, Event:NEWROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));


    }
    //BusinessRuleId:2732, Attribute:265786, Operation:Object, Event:NEWROWMR

    //NEWBUSINESSRULE_NEWROWMR_Lugar_de_Detencion// 
    return result;
}

function EjecutarValidacionesEditRowMRLugar_de_Detencion(nameOfTable, rowIndex) {
    var result = true;
    //BusinessRuleId:2732, Attribute:265786, Operation:Object, Event:EDITROWMR
    if (operation == 'New') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));


    }
    //BusinessRuleId:2732, Attribute:265786, Operation:Object, Event:EDITROWMR

    //BusinessRuleId:2732, Attribute:265786, Operation:Object, Event:EDITROWMR
    if (operation == 'Update') {
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Municipio_de_Detencion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Corporacion' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Suspension_Condicional' + rowIndex));
        SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Suspension_Condicional' + rowIndex));


    }
    //BusinessRuleId:2732, Attribute:265786, Operation:Object, Event:EDITROWMR

    //NEWBUSINESSRULE_EDITROWMR_Lugar_de_Detencion// 
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
            address: jQuery('input[name=address]').val() == "" ? "Badiraguto Sinaloa,Mexico" : $('input[name=address]').val(),
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
    $('#Pais').val(valorPaisId).trigger('change');

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




function CambiaMunicipio(deesc) {
    debugger;
    $('#Municipio').val(null).trigger('change');
    var control = $('#Municipio');
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Municipio where estado = '" + $('#Estado').val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
    var valorPaisId = EvaluaQuery(query)
    control.select2('open');
    $('.select2-search__field').val(valorPaisId).trigger('keyup');
    control.select2('close');
    var data = eval('AutoComplete' + control.selector.replace('#', '') + 'Data');
    control.select2({ data: data });
    control.val(valorPaisId).trigger('change');
}

function CambiaPoblacion(deesc) {
    debugger;
    $('#Poblacion').val(null).trigger('change');
    var control = $('#Poblacion');
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

function CambiaPaisRow(deesc) {
    debugger;
    var RowSelected = $("#RowSelected").val();
    $("#Otros_Domicilios_Probable_Responsable_Pais_" + RowSelected + "").val(null).trigger('change');
    var control = $("#Otros_Domicilios_Probable_Responsable_Pais_" + RowSelected + "");
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
    $("#Otros_Domicilios_Probable_Responsable_Estado_" + RowSelected + "").val(null).trigger('change');
    var control = $("#Otros_Domicilios_Probable_Responsable_Estado_" + RowSelected + "");
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
    $("#Otros_Domicilios_Probable_Responsable_Municipio_" + RowSelected + "").val(null).trigger('change');
    var control = $("#Otros_Domicilios_Probable_Responsable_Municipio_" + RowSelected + "");
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Municipio where estado = '" + $("#Otros_Domicilios_Probable_Responsable_Estado_" + RowSelected + "").val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
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
    $("#Otros_Domicilios_Probable_Responsable_Poblacion_" + RowSelected + "").val(null).trigger('change');
    var control = $("#Otros_Domicilios_Probable_Responsable_Poblacion_" + RowSelected + "");
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Colonia where Municipio = '" + $("#Otros_Domicilios_Probable_Responsable_Municipio_" + RowSelected + "").val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
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
    $("#Otros_Domicilios_Probable_Responsable_Colonia_" + RowSelected + "").val(null).trigger('change');
    var control = $("#Otros_Domicilios_Probable_Responsable_Colonia_" + RowSelected + "");
    var rdesc = EvaluaQuery("select dbo.RemoveAccentMarks ('" + deesc + "')");
    var query = "select top 1 clave from Colonia where Municipio = '" + $("#Otros_Domicilios_Probable_Responsable_Municipio_" + RowSelected + "").val() + "' and " + " dbo.RemoveAccentMarks(nombre) like '%" + rdesc + "%'";
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
    $("#Otros_Domicilios_Probable_Responsable_Codigo_Postal_" + RowSelected + "").val((""));
    $('#Otros_Domicilios_Probable_Responsable_Estado_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Probable_Responsable_Municipio_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Probable_Responsable_Estado_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Probable_Responsable_Municipio_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Probable_Responsable_Colonia_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Probable_Responsable_Poblacion_' + RowSelected + '').val(null).trigger('change');
    $('#Otros_Domicilios_Probable_Responsable_Calle_' + RowSelected + '').val((""));
    $('#Otros_Domicilios_Probable_Responsable_Numero_Exterior_' + RowSelected + '').val((""));
    $('#Otros_Domicilios_Probable_Responsable_Numero_Interior_' + RowSelected + '').val((""));
    $('#Otros_Domicilios_Probable_Responsable_Coordenada_X_' + RowSelected + '').val((""));
    $('#Otros_Domicilios_Probable_Responsable_Coordenada_Y_' + RowSelected + '').val((""));


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
                    $('#Otros_Domicilios_Probable_Responsable_Coordenada_X_' + RowSelected + '').val(marker.getPosition().lat());
                    $('#Otros_Domicilios_Probable_Responsable_Coordenada_Y_' + RowSelected + '').val(marker.getPosition().lng());
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
                                $("#Otros_Domicilios_Probable_Responsable_Codigo_Postal_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "country") {
                                debugger;
                                CambiaPaisRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), results[0].address_components[i].long_name);


                            }

                            if (results[0].address_components[i].types[0] == "administrative_area_level_1") {
                                CambiaEstadoRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), results[0].address_components[i].long_name);
                            }

                            if (results[0].address_components[i].types[0] == "locality") {
                                CambiaMunicipioRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex), results[0].address_components[i].long_name);
                            }


                            if (results[0].address_components[i].types[0] == "political") { // segun spartanMetadata poblacion es igual a colonia

                                CambiaPoblacionRow(results[0].address_components[i].long_name);
                                CambiaColoniaRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Colonia' + rowIndex), results[0].address_components[i].long_name);
                                //AsignarValor($('#' + nameOfTable + 'Poblacion' + rowIndex), results[0].address_components[i].long_name);
                            }



                            if (results[0].address_components[i].types[0] == "route") {
                                $("#Otros_Domicilios_Probable_Responsable_Calle_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "street_number") {
                                $("#Otros_Domicilios_Probable_Responsable_Numero_Exterior_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }



                        }
                        $('#Otros_Domicilios_Probable_Responsable_Coordenada_X_' + RowSelected + '').val(marker.getPosition().lat());
                        $('#Otros_Domicilios_Probable_Responsable_Coordenada_Y_' + RowSelected + '').val(marker.getPosition().lng());
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
                                $("#Otros_Domicilios_Probable_Responsable_Codigo_Postal_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "country") {
                                debugger;
                                CambiaPaisRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Pais' + rowIndex), results[0].address_components[i].long_name);


                            }

                            if (results[0].address_components[i].types[0] == "administrative_area_level_1") {
                                CambiaEstadoRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Estado' + rowIndex), results[0].address_components[i].long_name);
                            }

                            if (results[0].address_components[i].types[0] == "locality") {
                                CambiaMunicipioRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Municipio' + rowIndex), results[0].address_components[i].long_name);
                            }


                            if (results[0].address_components[i].types[0] == "political") { // segun spartanMetadata poblacion es igual a colonia

                                CambiaPoblacionRow(results[0].address_components[i].long_name);
                                CambiaColoniaRow(results[0].address_components[i].long_name);
                                // AsignarValor($('#' + nameOfTable + 'Colonia' + rowIndex), results[0].address_components[i].long_name);
                                //AsignarValor($('#' + nameOfTable + 'Poblacion' + rowIndex), results[0].address_components[i].long_name);
                            }



                            if (results[0].address_components[i].types[0] == "route") {
                                $("#Otros_Domicilios_Probable_Responsable_Calle_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }

                            if (results[0].address_components[i].types[0] == "street_number") {
                                $("#Otros_Domicilios_Probable_Responsable_Numero_Exterior_" + RowSelected + "").val((results[0].address_components[i].long_name));
                            }



                        }
                        $('#Otros_Domicilios_Probable_Responsable_Coordenada_X_' + RowSelected + '').val(marker.getPosition().lat());
                        $('#Otros_Domicilios_Probable_Responsable_Coordenada_Y_' + RowSelected + '').val(marker.getPosition().lng());
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
            address: jQuery('input[name=address2]').val() == "" ? "Badiraguto Sinaloa,Mexico" : $('input[name=address2]').val(),
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