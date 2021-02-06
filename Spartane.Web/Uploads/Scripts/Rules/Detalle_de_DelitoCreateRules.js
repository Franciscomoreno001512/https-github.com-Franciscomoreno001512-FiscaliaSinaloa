var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$('#Detalle_de_DelitoGuardarYNuevo').hide();
$('#Detalle_de_DelitoGuardarYCopia').hide();
$(document).ready(function () {
    if (TryParseInt('3', '3') == EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable) || TryParseInt('2', '2') == EvaluaQuery("select GLOBAL[USERROLEID]"
        + " ", rowIndex, nameOfTable) || TryParseInt('103', '103') == EvaluaQuery("select GLOBAL[USERROLEID]"
            + " ", rowIndex, nameOfTable) || TryParseInt('101', '101') == EvaluaQuery("select GLOBAL[USERROLEID]", rowIndex, nameOfTable)) {
        $('#Detalle_de_DelitoGuardar').remove();

    }

    if( 
        EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable)==TryParseInt('2', '2') 
      ) {
        //$("#Detalle_de_ImputadoGuardar").remove();
        $("#Detalle_de_DelitoGuardarYNuevo").remove();
        $("#Detalle_de_DelitoGuardarYCopia").remove();
    }
	
	//INI SOLO PERMITIR SOLO LETRAS, NUMEROS
    $("#Placas").bind('keypress', function(event) {
        var regex = new RegExp("^[a-zA-Z0-9]+$");
        var key = String.fromCharCode(!event.charCode ? event.which : event.charCode);
        if (!regex.test(key)) {
            event.preventDefault();
            return false;
        }

    });
	//FIN SOLO PERMITIR SOLO LETRAS, NUMEROS
	


//BusinessRuleId:233, Attribute:263456, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Robo_de_Vehiculo', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex).prop("checked") === true ) { $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'block');
$("a[href='#tabAsignar_Dueno']").css('display', 'block');} else { $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'none');$("a[href='#tabAsignar_Dueno']").css('display', 'none');}
});


//BusinessRuleId:233, Attribute:263456, Operation:Field, Event:None

//CONVERTIR A MAYUSCULAS AL BLUR
$('input[type="text"],textarea').blur(function() {
	this.value = this.value.toUpperCase();
	});
//END CONVERTIR A MAYUSCULAS AL BLUR

//BusinessRuleId:632, Attribute:0, Operation:Field, Event:None
if( EvaluaQuery("declare @accidente int"
+" declare @clave int "
+" set @clave=FLD[Circunstancia_Defuncion]"
+" "
+" if @clave not in (select clave from circunstancia_defuncion where descripcion in('ATROPELLADO (A)','POR CHOQUE','ATROPELLADO (A)','POR VOLCADURA','POR CAIDA DE VEHICULO',"
+" 'ARROLLADO POR TREN','DESPLOME DE AERONAVE'))"
+" begin"
+" set @accidente=0"
+" end"
+" else"
+" begin"
+" set @accidente=1"
+" end"
+" select @accidente",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $('#divEstado_del_Conductor').css('display', 'block'); $('#divRuta').css('display', 'block');} else { $('#divEstado_del_Conductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Conductor' + rowIndex)); $('#divRuta').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta' + rowIndex));}


//BusinessRuleId:632, Attribute:0, Operation:Field, Event:None



//BusinessRuleId:569, Attribute:263457, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Levantamiento_de_Cadaver', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Levantamiento_de_Cadaver' + rowIndex).prop("checked") === true ) { $("a[href='#tabDatos_del_Levantamiento_del_Cadaver']").css('display', 'block');} else { $("a[href='#tabDatos_del_Levantamiento_del_Cadaver']").css('display', 'none');}
});


//BusinessRuleId:569, Attribute:263457, Operation:Field, Event:None

//BusinessRuleId:633, Attribute:263475, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Mercancia', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Mercancia' + rowIndex).prop("checked") === true ) { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'block'); $('#divMonto_de_la_Carga').css('display', 'block'); $('#divSenas_Particulares').css('display', 'block'); $('#divModalidad_del_Robo').css('display', 'block');} else { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex)); $('#divMonto_de_la_Carga').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Carga' + rowIndex)); $('#divSenas_Particulares').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex)); $('#divModalidad_del_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_del_Robo' + rowIndex));}
});


//BusinessRuleId:633, Attribute:263475, Operation:Field, Event:None

//BusinessRuleId:1329, Attribute:263475, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Mercancia', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Mercancia' + rowIndex).prop("checked") === true ) { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'block');} else {}
});


//BusinessRuleId:1329, Attribute:263475, Operation:Field, Event:None

//BusinessRuleId:1353, Attribute:263470, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#El_Vehiculo_esta_Asegurado', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'El_Vehiculo_esta_Asegurado' + rowIndex).prop("checked") === true ) { $('#divNombre_de_la_Aseguradora').css('display', 'block');} else { $('#divNombre_de_la_Aseguradora').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_la_Aseguradora' + rowIndex));}
});


//BusinessRuleId:1353, Attribute:263470, Operation:Field, Event:None

//BusinessRuleId:1303, Attribute:263498, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Puede_Ser_Canalizado_a_JA', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex).val()==TryParseInt('2', '2') ) { $('#divMotivo_de_no_canalizacion').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex));} else { $('#divMotivo_de_no_canalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex));}
});


//BusinessRuleId:1303, Attribute:263498, Operation:Field, Event:None

//BusinessRuleId:1922, Attribute:263455, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Violencia_de_Genero', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Violencia_de_Genero' + rowIndex).prop("checked") === true ) { $('#divDelito_Violencia_Genero').css('display', 'block');} else { $('#divDelito_Violencia_Genero').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Violencia_Genero' + rowIndex));}
});


//BusinessRuleId:1922, Attribute:263455, Operation:Field, Event:None





//BusinessRuleId:1932, Attribute:265782, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Denunciante_dueno', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Denunciante_dueno' + rowIndex).prop("checked") === true ) { $('#divNombre_Completo_Dueno').css('display', 'block');} else { $('#divNombre_Completo_Dueno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex));}
});


//BusinessRuleId:1932, Attribute:265782, Operation:Field, Event:None

//BusinessRuleId:1931, Attribute:265780, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Persona_Fisica_Dueno', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Persona_Fisica_Dueno' + rowIndex).prop("checked") === true ) { $('#divNombre_Completo_Involucrado').css('display', 'block');} else { $('#divNombre_Completo_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Involucrado' + rowIndex));}
});


//BusinessRuleId:1931, Attribute:265780, Operation:Field, Event:None

//BusinessRuleId:1930, Attribute:265778, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Persona_Moral_Dueno', function () {
	nameOfTable='';
	rowIndex='';
if( $('#' + nameOfTable + 'Persona_Moral_Dueno' + rowIndex).prop("checked") === true ) { $('#divNombre_Completo').css('display', 'block');} else { $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}
});


//BusinessRuleId:1930, Attribute:265778, Operation:Field, Event:None







//BusinessRuleId:2503, Attribute:265612, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Fecha_del_Delito', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha_del_Delito' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103), CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_del_Delito]',103),103))",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText('No se puede ingresar una fecha mayor al día de hoy.', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_del_Delito' + rowIndex),'');} else {}
});


//BusinessRuleId:2503, Attribute:265612, Operation:Field, Event:None



//BusinessRuleId:2529, Attribute:265618, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Municipio_del_Delito', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).val();   $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:2529, Attribute:265618, Operation:Field, Event:None



//BusinessRuleId:2529, Attribute:265617, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Estado_del_Delito', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Estado_del_Delito' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex).val();   $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado_del_Delito]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado_del_Delito]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:2529, Attribute:265617, Operation:Field, Event:None

//BusinessRuleId:2530, Attribute:265618, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Municipio_del_Delito', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') ) { var valor = $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).val();   $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio_del_Delito]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio_del_Delito]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex).val(valor).trigger('change');} else {}
});


//BusinessRuleId:2530, Attribute:265618, Operation:Field, Event:None



//BusinessRuleId:2625, Attribute:263447, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Delito', function () {
	nameOfTable='';
	rowIndex='';
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') && EvaluaQuery("select ISNULL(Robo_de_Vehiculo, 0) from Delito where Clave = FLD[Delito]",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'none');} else {}
});


//BusinessRuleId:2625, Attribute:263447, Operation:Field, Event:None

//BusinessRuleId:2623, Attribute:263447, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Delito', function () {
	nameOfTable='';
	rowIndex='';
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idtablero]'), ReplaceGLOBAL('GLOBAL[idtablero]'))==TryParseInt('3', '3') && EvaluaQuery("select Robo_de_Vehiculo from Delito where Clave = FLD[Delito]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'block'); $("a[href='#tabAsignar_Dueno']").css('display', 'block');} else {}
});


//BusinessRuleId:2623, Attribute:263447, Operation:Field, Event:None

























//BusinessRuleId:3006, Attribute:263456, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Robo_de_Vehiculo', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Descripcion LIKE '%vehiculo%'", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Descripcion LIKE '%vehiculo%'", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change');} else { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Clave > 0", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Clave > 0", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change');}
});


//BusinessRuleId:3006, Attribute:263456, Operation:Field, Event:None

//BusinessRuleId:3005, Attribute:263447, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Delito', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Tipo_de_Delito' + rowIndex),EvaluaQuery("SELECT TD.Descripcion FROM dbo.Delito D"
+" INNER JOIN dbo.Tipo_Delito TD ON TD.Clave = D.TIPO_DELITO"
+" WHERE D.Clave = FLD[Delito]", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Grupo_Delito' + rowIndex),EvaluaQuery("SELECT GD.Descripcion FROM dbo.Delito D"
+" INNER JOIN dbo.Grupo_del_Delito GD ON GD.Clave = D.Grupo_del_Delito"
+" WHERE D.Clave = FLD[Delito]", rowIndex, nameOfTable));
});


//BusinessRuleId:3005, Attribute:263447, Operation:Field, Event:None



//BusinessRuleId:3453, Attribute:265629, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Fecha_del_Robo', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Fecha_del_Robo' + rowIndex),nameOfTable,rowIndex)!=TryParseInt('null', 'null') && EvaluaQuery("	SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103), CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_del_Robo]',103),103))",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { alert(DecodifyText(' No se puede ingresar una fecha mayor al dia de hoy.', rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Fecha_del_Robo' + rowIndex),' ');} else {}
});


//BusinessRuleId:3453, Attribute:265629, Operation:Field, Event:None

//BusinessRuleId:3589, Attribute:263461, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Marca', function () {
	nameOfTable='';
	rowIndex='';
 var valor = $('#' + nameOfTable + 'Sub_Marca' + rowIndex).val();   $('#' + nameOfTable + 'Sub_Marca' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Sub_Marca' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Sub_Marca' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Sub_Marca_del_Vehiculo WHERE MARCA_DEL_VEHICULO = FLD[Marca]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Sub_Marca' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, DESCRIPCION FROM Sub_Marca_del_Vehiculo WHERE MARCA_DEL_VEHICULO = FLD[Marca]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Sub_Marca' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Sub_Marca' + rowIndex).val(valor).trigger('change');
});


//BusinessRuleId:3589, Attribute:263461, Operation:Field, Event:None

//BusinessRuleId:3625, Attribute:263456, Operation:Field, Event:None
$("form#CreateDetalle_de_Delito").on('change', '#Robo_de_Vehiculo', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { SetRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Sub_Marca' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Vehiculo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Robo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Hora_del_Robo' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Numero_de_Serie' + rowIndex));} else { SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sub_Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Vehiculo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Serie' + rowIndex));}
});


//BusinessRuleId:3625, Attribute:263456, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:1924, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
    $('#divDelito_Violencia_Genero').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Violencia_Genero' + rowIndex));
   
   
   }
   //BusinessRuleId:1924, Attribute:0, Operation:Object, Event:SCREENOPENING




    
    
    
    




//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
    debugger;
 $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMonto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));$('#divArticulado_de_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));$('#divExpediente_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));


}
//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
    debugger;
 $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMonto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));$('#divArticulado_de_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));$('#divExpediente_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));


}
//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
    debugger;
 $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMonto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));$('#divArticulado_de_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));$('#divExpediente_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));


}
//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING


//BusinessRuleId:338, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'none'); $("a[href='#tabDatos_del_Levantamiento_del_Cadaver']").css('display', 'none');


}
//BusinessRuleId:338, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:338, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'none'); $("a[href='#tabDatos_del_Levantamiento_del_Cadaver']").css('display', 'none');


}
//BusinessRuleId:338, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:338, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'none'); $("a[href='#tabDatos_del_Levantamiento_del_Cadaver']").css('display', 'none');


}
//BusinessRuleId:338, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divRuta').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta' + rowIndex)); $('#divEstado_del_Conductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Conductor' + rowIndex)); $('#divTipo_de_Servicio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex)); $('#divModalidad_del_Robo').css('display', 'block');


}
//BusinessRuleId:631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divRuta').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta' + rowIndex)); $('#divEstado_del_Conductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Conductor' + rowIndex)); $('#divTipo_de_Servicio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex)); $('#divModalidad_del_Robo').css('display', 'block');


}
//BusinessRuleId:631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divRuta').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta' + rowIndex)); $('#divEstado_del_Conductor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Conductor' + rowIndex)); $('#divTipo_de_Servicio').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex)); $('#divModalidad_del_Robo').css('display', 'block');


}
//BusinessRuleId:631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1052, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divLevantamiento_de_Cadaver').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Levantamiento_de_Cadaver' + rowIndex));


}
//BusinessRuleId:1052, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1052, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divLevantamiento_de_Cadaver').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Levantamiento_de_Cadaver' + rowIndex));


}
//BusinessRuleId:1052, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1052, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divLevantamiento_de_Cadaver').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Levantamiento_de_Cadaver' + rowIndex));


}
//BusinessRuleId:1052, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1302, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex).val()==TryParseInt('1', '1') || $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex).val()==TryParseInt('null', 'null') ) { $('#divMotivo_de_no_canalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex));} else { $('#divMotivo_de_no_canalizacion').css('display', 'block');}


}
//BusinessRuleId:1302, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1302, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex).val()==TryParseInt('1', '1') || $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex).val()==TryParseInt('null', 'null') ) { $('#divMotivo_de_no_canalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex));} else { $('#divMotivo_de_no_canalizacion').css('display', 'block');}


}
//BusinessRuleId:1302, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1302, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex).val()==TryParseInt('1', '1') || $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex).val()==TryParseInt('null', 'null') ) { $('#divMotivo_de_no_canalizacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex));} else { $('#divMotivo_de_no_canalizacion').css('display', 'block');}


}
//BusinessRuleId:1302, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1348, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( $('#' + nameOfTable + 'Mercancia' + rowIndex).prop("checked") === true ) { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex)); $('#divMonto_de_la_Carga').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Carga' + rowIndex));} else {}


}
//BusinessRuleId:1348, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1348, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( $('#' + nameOfTable + 'Mercancia' + rowIndex).prop("checked") === true ) { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex)); $('#divMonto_de_la_Carga').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Carga' + rowIndex));} else {}


}
//BusinessRuleId:1348, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1348, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( $('#' + nameOfTable + 'Mercancia' + rowIndex).prop("checked") === true ){ $('#divDescripcion_de_lo_que_Transportaba').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex)); $('#divMonto_de_la_Carga').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Carga' + rowIndex));} else {}


}
//BusinessRuleId:1348, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1723, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));


}	
//BusinessRuleId:1723, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1742, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1742, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1742, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1742, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1742, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));


}
//BusinessRuleId:1742, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1743, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Expediente_Inicial" + rowIndex), ("true" == "true"));


}
//BusinessRuleId:1743, Attribute:0, Operation:Object, Event:SCREENOPENING

if(operation == 'New'){
    if( $('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex).prop("checked") === true ) { $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'block');
$("a[href='#tabAsignar_Dueno']").css('display', 'block');} else { $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'none');$("a[href='#tabAsignar_Dueno']").css('display', 'none');}
}

//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
    debugger;
 $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMonto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));$('#divArticulado_de_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));$('#divExpediente_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));


}
//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
    debugger;
 $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMonto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));$('#divArticulado_de_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));$('#divExpediente_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));


}
//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
    debugger;
 $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMonto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));$('#divArticulado_de_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));$('#divExpediente_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));


}
//BusinessRuleId:1926, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1927, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Principal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Comision_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Accion_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Elementos_Comision_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Violencia_de_Genero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Levantamiento_de_Cadaver' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_de_Vehiculo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clase' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Vehiculo_Robado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sub_Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Vehiculo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Origen_de_las_Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'El_Vehiculo_esta_Asegurado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_la_Aseguradora' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta_del_Servicio_Publico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Mercancia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Muerte' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Defuncion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Consecuencia_Defuncion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Levantamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Levantamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_no_Catalogada' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Necropsia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cronotanatodiagnostico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Conductor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Violencia_Genero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion_con_Orden_de_Resultado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Concurso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Federal_Vehicular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Registro_Publico_Vehicular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cuenta_con_GPS' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Carretera' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Agravante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Agravante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Circunstacias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Moral_Dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Fisica_Dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Denunciante_dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));


}
//BusinessRuleId:1927, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1927, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Principal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Comision_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Accion_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Elementos_Comision_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Violencia_de_Genero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Levantamiento_de_Cadaver' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_de_Vehiculo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clase' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Vehiculo_Robado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sub_Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Vehiculo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Origen_de_las_Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'El_Vehiculo_esta_Asegurado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_la_Aseguradora' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta_del_Servicio_Publico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Mercancia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Muerte' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Defuncion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Consecuencia_Defuncion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Levantamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Levantamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_no_Catalogada' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Necropsia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cronotanatodiagnostico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Conductor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Violencia_Genero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion_con_Orden_de_Resultado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Concurso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Federal_Vehicular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Registro_Publico_Vehicular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cuenta_con_GPS' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Carretera' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Agravante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Agravante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Circunstacias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Moral_Dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Fisica_Dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Denunciante_dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));


}
//BusinessRuleId:1927, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1927, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Principal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Comision_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Accion_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Elementos_Comision_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Violencia_de_Genero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Levantamiento_de_Cadaver' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_de_Vehiculo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clase' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Vehiculo_Robado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Sub_Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Vehiculo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Origen_de_las_Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'El_Vehiculo_esta_Asegurado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_la_Aseguradora' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta_del_Servicio_Publico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Mercancia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Muerte' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Defuncion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Consecuencia_Defuncion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Levantamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Levantamiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_no_Catalogada' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Necropsia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cronotanatodiagnostico' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Conductor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Violencia_Genero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion_con_Orden_de_Resultado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Concurso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Federal_Vehicular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Registro_Publico_Vehicular' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cuenta_con_GPS' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Carretera' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Agravante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Agravante' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Circunstacias' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Moral_Dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Fisica_Dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Involucrado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Denunciante_dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));


}
//BusinessRuleId:1927, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1924, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divDelito_Violencia_Genero').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Violencia_Genero' + rowIndex));


}
//BusinessRuleId:1924, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1928, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divCircunstancia_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Delito' + rowIndex));


}
//BusinessRuleId:1928, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1928, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divCircunstancia_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Delito' + rowIndex));


}
//BusinessRuleId:1928, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1928, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divCircunstancia_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Delito' + rowIndex));


}
//BusinessRuleId:1928, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1929, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));$('#divNombre_Completo_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Involucrado' + rowIndex));$('#divNombre_Completo_Dueno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex));


}
//BusinessRuleId:1929, Attribute:0, Operation:Object, Event:SCREENOPENING
//BusinessRuleId:1932, Attribute:265782, Operation:Field, Event:None
if(operation == 'New'){
if( $('#' + nameOfTable + 'Denunciante_dueno' + rowIndex).prop("checked") === true )  { $('#divNombre_Completo_Dueno').css('display', 'block');} else { $('#divNombre_Completo_Dueno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex));}
}
if(operation == 'Update'){
    if( $('#' + nameOfTable + 'Denunciante_dueno' + rowIndex).prop("checked") === true )  { $('#divNombre_Completo_Dueno').css('display', 'block');} else { $('#divNombre_Completo_Dueno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex));}
    }
    if(operation == 'Consult'){
        if( $('#' + nameOfTable + 'Denunciante_dueno' + rowIndex).prop("checked") === true )  { $('#divNombre_Completo_Dueno').css('display', 'block');} else { $('#divNombre_Completo_Dueno').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex));}
        }
//BusinessRuleId:1932, Attribute:265782, Operation:Field, Event:None

//BusinessRuleId:1931, Attribute:265780, Operation:Field, Event:None
if(operation == 'New'){
if( $('#' + nameOfTable + 'Persona_Fisica_Dueno' + rowIndex).prop("checked") === true ) { $('#divNombre_Completo_Involucrado').css('display', 'block');} else { $('#divNombre_Completo_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Involucrado' + rowIndex));}
}
if(operation == 'Update'){
    if( $('#' + nameOfTable + 'Persona_Fisica_Dueno' + rowIndex).prop("checked") === true ) { $('#divNombre_Completo_Involucrado').css('display', 'block');} else { $('#divNombre_Completo_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Involucrado' + rowIndex));}
    }
    if(operation == 'Consult'){
        if( $('#' + nameOfTable + 'Persona_Fisica_Dueno' + rowIndex).prop("checked") === true ) { $('#divNombre_Completo_Involucrado').css('display', 'block');} else { $('#divNombre_Completo_Involucrado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Involucrado' + rowIndex));}
        }
//BusinessRuleId:1931, Attribute:265780, Operation:Field, Event:None

//BusinessRuleId:1930, Attribute:265778, Operation:Field, Event:None
if(operation == 'New'){
if( $('#' + nameOfTable + 'Persona_Moral_Dueno' + rowIndex).prop("checked") === true ) { $('#divNombre_Completo').css('display', 'block');} else { $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}
}
if(operation == 'Update'){
    if( $('#' + nameOfTable + 'Persona_Moral_Dueno' + rowIndex).prop("checked") === true ) { $('#divNombre_Completo').css('display', 'block');} else { $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}
    }
    if(operation == 'Consult'){
        if( $('#' + nameOfTable + 'Persona_Moral_Dueno' + rowIndex).prop("checked") === true ) { $('#divNombre_Completo').css('display', 'block');} else { $('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}
        }
//BusinessRuleId:1933, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divEstado_del_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));$('#divMunicipio_del_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));$('#divColonia_del_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));$('#divCodigo_Postal_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));$('#divCalle_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));$('#divEntre_Calle_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));$('#divy_Calle_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));$('#divNumero_Exterior_del_Delito_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));$('#divNumero_Interior_del_Delito_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));$('#divReferencia_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));$('#divLatitud_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));$('#divLongitud_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex));


}
//BusinessRuleId:1933, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1933, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divEstado_del_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));$('#divMunicipio_del_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));$('#divColonia_del_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));$('#divCodigo_Postal_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));$('#divCalle_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));$('#divEntre_Calle_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));$('#divy_Calle_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));$('#divNumero_Exterior_del_Delito_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));$('#divNumero_Interior_del_Delito_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));$('#divReferencia_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));$('#divLatitud_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));$('#divLongitud_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex));


}
//BusinessRuleId:1933, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1933, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divEstado_del_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));$('#divMunicipio_del_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));$('#divColonia_del_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));$('#divCodigo_Postal_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));$('#divCalle_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));$('#divEntre_Calle_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));$('#divy_Calle_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));$('#divNumero_Exterior_del_Delito_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));$('#divNumero_Interior_del_Delito_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));$('#divReferencia_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));$('#divLatitud_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));$('#divLongitud_Robo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex));


}
//BusinessRuleId:1933, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2235, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Expediente_Inicial' + rowIndex),EvaluaQuery(" SELECT NUAT FROM Modulo_Atencion_Inicial WHERE Clave = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable));


}
//BusinessRuleId:2235, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2508, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2508, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2508, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2508, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2508, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpediente_MP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));


}
//BusinessRuleId:2508, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2526, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:2526, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2526, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 var valor = $('#' + nameOfTable + 'Municipio' + rowIndex).val();   $('#' + nameOfTable + 'Municipio' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Municipio' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Municipio' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM Municipio WHERE ESTADO = FLD[Estado]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Municipio' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Municipio' + rowIndex).val(valor).trigger('change'); var valor = $('#' + nameOfTable + 'Colonia' + rowIndex).val();   $('#' + nameOfTable + 'Colonia' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Colonia' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Colonia' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT CLAVE, NOMBRE FROM COLONIA WHERE Municipio = FLD[Municipio]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Colonia' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Colonia' + rowIndex).val(valor).trigger('change');


}
//BusinessRuleId:2526, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2622, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { $('#divRobo_de_Vehiculo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex));} else {}


}
//BusinessRuleId:2622, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2622, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { $('#divRobo_de_Vehiculo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex));} else {}


}
//BusinessRuleId:2622, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2622, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { $('#divRobo_de_Vehiculo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex));} else {}


}
//BusinessRuleId:2622, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2624, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') && EvaluaQuery("select Robo_de_Vehiculo from Delito where Clave = FLD[Delito]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $("a[href='#tabAsignar_Dueno']").css('display', 'block'); $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'block');} else {}


}
//BusinessRuleId:2624, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2624, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') && EvaluaQuery("select Robo_de_Vehiculo from Delito where Clave = FLD[Delito]",rowIndex, nameOfTable)==TryParseInt('1', '1') ) { $("a[href='#tabAsignar_Dueno']").css('display', 'block'); $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'block');} else {}


}
//BusinessRuleId:2624, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2626, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') && EvaluaQuery("select ISNULL(Robo_de_Vehiculo, 0) from Delito where Clave = FLD[Delito]",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'none');} else {}


}
//BusinessRuleId:2626, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2626, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') && EvaluaQuery("select ISNULL(Robo_de_Vehiculo, 0) from Delito where Clave = FLD[Delito]",rowIndex, nameOfTable)==TryParseInt('0', '0') ) { $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'none');} else {}


}
//BusinessRuleId:2626, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2944, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divExpediente_MASC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


}
//BusinessRuleId:2944, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2944, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divExpediente_MASC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


}
//BusinessRuleId:2944, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2944, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divExpediente_MASC').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));


}
//BusinessRuleId:2944, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:1923, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMonto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));$('#divArticulado_de_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));$('#divExpediente_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex)); $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $('#divEstado_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Delito' + rowIndex));$('#divMunicipio_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex));$('#divColonia_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex));$('#divCodigo_Postal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));$('#divCalle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));$('#divEntre_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));$('#divy_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle' + rowIndex));$('#divNumero_Exterior_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito' + rowIndex));$('#divNumero_Interior_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito' + rowIndex));$('#divReferencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));$('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex)); $('#divPuede_Ser_Canalizado_a_JA').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex));


}
//BusinessRuleId:1923, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1923, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMonto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));$('#divArticulado_de_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));$('#divExpediente_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex)); $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $('#divEstado_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Delito' + rowIndex));$('#divMunicipio_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex));$('#divColonia_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex));$('#divCodigo_Postal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));$('#divCalle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));$('#divEntre_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));$('#divy_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle' + rowIndex));$('#divNumero_Exterior_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito' + rowIndex));$('#divNumero_Interior_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito' + rowIndex));$('#divReferencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));$('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex)); $('#divPuede_Ser_Canalizado_a_JA').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex));


}
//BusinessRuleId:1923, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:1923, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divMonto').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));$('#divArticulado_de_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));$('#divExpediente_Inicial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex)); $("a[href='#tabAsignar_Dueno']").css('display', 'none'); $('#divEstado_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Delito' + rowIndex));$('#divMunicipio_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex));$('#divColonia_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex));$('#divCodigo_Postal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));$('#divCalle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));$('#divEntre_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));$('#divy_Calle').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle' + rowIndex));$('#divNumero_Exterior_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito' + rowIndex));$('#divNumero_Interior_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito' + rowIndex));$('#divReferencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));$('#divLatitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));$('#divLongitud').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex)); $('#divPuede_Ser_Canalizado_a_JA').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex));


}
//BusinessRuleId:1923, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3003, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divFecha_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Delito' + rowIndex));$('#divHora_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Delito' + rowIndex));


}
//BusinessRuleId:3003, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3003, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divFecha_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Delito' + rowIndex));$('#divHora_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Delito' + rowIndex));


}
//BusinessRuleId:3003, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3003, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divFecha_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Delito' + rowIndex));$('#divHora_del_Delito').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Delito' + rowIndex));


}
//BusinessRuleId:3003, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3004, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Tipo_de_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grupo_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_Delito' + rowIndex));}


}
//BusinessRuleId:3004, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3004, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Tipo_de_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grupo_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_Delito' + rowIndex));}


}
//BusinessRuleId:3004, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3004, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Tipo_de_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grupo_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_Delito' + rowIndex));}


}
//BusinessRuleId:3004, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3572, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre_Completo FROM dbo.Detalle_de_Datos_Generales WHERE Tipo_de_Compareciente = 1 AND Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre_Completo FROM dbo.Detalle_de_Datos_Generales WHERE Tipo_de_Compareciente = 1 AND Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).val(valor).trigger('change');} else {}


}
//BusinessRuleId:3572, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3572, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre_Completo FROM dbo.Detalle_de_Datos_Generales WHERE Tipo_de_Compareciente = 1 AND Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre_Completo FROM dbo.Detalle_de_Datos_Generales WHERE Tipo_de_Compareciente = 1 AND Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).val(valor).trigger('change');} else {}


}
//BusinessRuleId:3572, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3572, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('2', '2') ) { var valor = $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).val();   $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Nombre_Completo FROM dbo.Detalle_de_Datos_Generales WHERE Tipo_de_Compareciente = 1 AND Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Nombre_Completo FROM dbo.Detalle_de_Datos_Generales WHERE Tipo_de_Compareciente = 1 AND Modulo_Atencion_Inicial = GLOBAL[SpartanOperationId]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex).val(valor).trigger('change');} else {}


}
//BusinessRuleId:3572, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3587, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Descripcion LIKE '%vehiculo%'	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Descripcion LIKE '%vehiculo%'	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'block');} else { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Clave > 0	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Clave > 0	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'none');}


}
//BusinessRuleId:3587, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3587, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Descripcion LIKE '%vehiculo%'	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Descripcion LIKE '%vehiculo%'	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'block');} else { var valor = $('#' + nameOfTable + 'Delito' + rowIndex).val();   $('#' + nameOfTable + 'Delito' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Delito' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Clave > 0	", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Delito' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("SELECT Clave, Descripcion FROM dbo.Delito WHERE Clave > 0	", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Delito' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Delito' + rowIndex).val(valor).trigger('change'); $("a[href='#tabDatos_de_Robo_de_Vehiculo']").css('display', 'none');}


}
//BusinessRuleId:3587, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3617, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( TryParseInt('3', '3')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('2', '2')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('101', '101')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('103', '103')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grupo_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Circunstancia_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito_Principal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Principal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Comision_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Comision_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Accion_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Accion_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modalidad_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Elementos_Comision_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Elementos_Comision_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Monto" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));}DisabledControl($("#" + nameOfTable + "Violencia_de_Genero" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Violencia_de_Genero' + rowIndex));}DisabledControl($("#" + nameOfTable + "Robo_de_Vehiculo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Levantamiento_de_Cadaver" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Levantamiento_de_Cadaver' + rowIndex));}DisabledControl($("#" + nameOfTable + "Circunstancia_de_Vehiculo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_de_Vehiculo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clase" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clase' + rowIndex));}DisabledControl($("#" + nameOfTable + "Vehiculo_Robado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Vehiculo_Robado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Marca" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));}DisabledControl($("#" + nameOfTable + "Sub_Marca" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Sub_Marca' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Vehiculo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Vehiculo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modelo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));}DisabledControl($("#" + nameOfTable + "Placas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_de_Origen_de_las_Placas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Origen_de_las_Placas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Serie" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));}DisabledControl($("#" + nameOfTable + "El_Vehiculo_esta_Asegurado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'El_Vehiculo_esta_Asegurado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_de_la_Aseguradora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_la_Aseguradora' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Servicio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ruta_del_Servicio_Publico" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta_del_Servicio_Publico' + rowIndex));}DisabledControl($("#" + nameOfTable + "Procedencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Mercancia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Mercancia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion_de_lo_que_Transportaba" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex));}DisabledControl($("#" + nameOfTable + "Monto_de_la_Carga" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Carga' + rowIndex));}DisabledControl($("#" + nameOfTable + "Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modalidad_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Causa_de_Muerte" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Muerte' + rowIndex));}DisabledControl($("#" + nameOfTable + "Circunstancia_Defuncion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Defuncion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Consecuencia_Defuncion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Consecuencia_Defuncion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_Levantamiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Levantamiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_Levantamiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Levantamiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia_no_Catalogada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_no_Catalogada' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Necropsia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Necropsia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Cronotanatodiagnostico" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cronotanatodiagnostico' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ruta" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_del_Conductor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Conductor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Articulado_de_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Puede_Ser_Canalizado_a_JA" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_no_canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Se_Informaron_sus_Derechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Se_Informo_el_Procedimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Denuncia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito_Violencia_Genero" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Violencia_Genero' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clasificacion_con_Orden_de_Resultado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion_con_Orden_de_Resultado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Concurso" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Concurso' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "y_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Robo_de" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de' + rowIndex));}DisabledControl($("#" + nameOfTable + "Registro_Federal_Vehicular" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Federal_Vehicular' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Registro_Publico_Vehicular" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Registro_Publico_Vehicular' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Motor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Serie" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Serie' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Entre_Calle_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "y_Calle_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior_del_Delito_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior_del_Delito_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Lugar_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Cuenta_con_GPS" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cuenta_con_GPS' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Carretera" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Carretera' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Folio_Agravante" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Agravante' + rowIndex));}DisabledControl($("#" + nameOfTable + "Agravante" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Agravante' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Folio_Circunstacias" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Circunstacias' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_Moral_Dueno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Moral_Dueno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_Fisica_Dueno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Fisica_Dueno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo_Involucrado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Involucrado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Denunciante_dueno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Denunciante_dueno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo_Dueno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion_corta" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_corta' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MASC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));}} else {}

}
//BusinessRuleId:3617, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3617, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('3', '3')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('2', '2')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('101', '101')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) || TryParseInt('103', '103')==EvaluaQuery("select GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Grupo_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Grupo_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Circunstancia_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito_Principal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Principal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Comision_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Comision_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Forma_Accion_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Forma_Accion_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modalidad_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Elementos_Comision_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Elementos_Comision_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Monto" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Monto' + rowIndex));}DisabledControl($("#" + nameOfTable + "Violencia_de_Genero" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Violencia_de_Genero' + rowIndex));}DisabledControl($("#" + nameOfTable + "Robo_de_Vehiculo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de_Vehiculo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Levantamiento_de_Cadaver" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Levantamiento_de_Cadaver' + rowIndex));}DisabledControl($("#" + nameOfTable + "Circunstancia_de_Vehiculo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_de_Vehiculo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clase" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clase' + rowIndex));}DisabledControl($("#" + nameOfTable + "Vehiculo_Robado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Vehiculo_Robado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Marca" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));}DisabledControl($("#" + nameOfTable + "Sub_Marca" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Sub_Marca' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Vehiculo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Vehiculo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modelo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Color" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));}DisabledControl($("#" + nameOfTable + "Placas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_de_Origen_de_las_Placas" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_de_Origen_de_las_Placas' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Serie" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));}DisabledControl($("#" + nameOfTable + "El_Vehiculo_esta_Asegurado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'El_Vehiculo_esta_Asegurado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_de_la_Aseguradora" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_la_Aseguradora' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Servicio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Servicio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ruta_del_Servicio_Publico" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta_del_Servicio_Publico' + rowIndex));}DisabledControl($("#" + nameOfTable + "Procedencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Mercancia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Mercancia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion_de_lo_que_Transportaba" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex));}DisabledControl($("#" + nameOfTable + "Monto_de_la_Carga" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Monto_de_la_Carga' + rowIndex));}DisabledControl($("#" + nameOfTable + "Senas_Particulares" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Senas_Particulares' + rowIndex));}DisabledControl($("#" + nameOfTable + "Modalidad_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Modalidad_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Causa_de_Muerte" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Causa_de_Muerte' + rowIndex));}DisabledControl($("#" + nameOfTable + "Circunstancia_Defuncion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Circunstancia_Defuncion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Consecuencia_Defuncion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Consecuencia_Defuncion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_Levantamiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_Levantamiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_Levantamiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_Levantamiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar_del_Hecho" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Hecho' + rowIndex));}DisabledControl($("#" + nameOfTable + "Pais" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Pais' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia_no_Catalogada" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_no_Catalogada' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior' + rowIndex));}DisabledControl($("#" + nameOfTable + "Necropsia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Necropsia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Cronotanatodiagnostico" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cronotanatodiagnostico' + rowIndex));}DisabledControl($("#" + nameOfTable + "Ruta" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Ruta' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_del_Conductor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Conductor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Articulado_de_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Articulado_de_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Puede_Ser_Canalizado_a_JA" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Puede_Ser_Canalizado_a_JA' + rowIndex));}DisabledControl($("#" + nameOfTable + "Motivo_de_no_canalizacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Motivo_de_no_canalizacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Se_Informaron_sus_Derechos" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));}DisabledControl($("#" + nameOfTable + "Se_Informo_el_Procedimiento" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Denuncia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Denuncia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Delito_Violencia_Genero" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Delito_Violencia_Genero' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clasificacion_con_Orden_de_Resultado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion_con_Orden_de_Resultado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Concurso" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Concurso' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Entre_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "y_Calle" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior_del_Delito" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));}DisabledControl($("#" + nameOfTable + "Fecha_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Robo_de" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Robo_de' + rowIndex));}DisabledControl($("#" + nameOfTable + "Registro_Federal_Vehicular" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Federal_Vehicular' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Registro_Publico_Vehicular" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Registro_Publico_Vehicular' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Motor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_de_Serie" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Serie' + rowIndex));}DisabledControl($("#" + nameOfTable + "Estado_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Estado_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Municipio_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Colonia_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Codigo_Postal_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Postal_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Calle_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Calle_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Entre_Calle_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Entre_Calle_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "y_Calle_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'y_Calle_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Exterior_del_Delito_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Exterior_del_Delito_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Numero_Interior_del_Delito_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_Interior_del_Delito_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Referencia_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Referencia_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Latitud_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Longitud_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Lugar_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Cuenta_con_GPS" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Cuenta_con_GPS' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar_del_Robo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar_del_Robo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Carretera" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Carretera' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Folio_Agravante" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Agravante' + rowIndex));}DisabledControl($("#" + nameOfTable + "Agravante" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Agravante' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Folio_Circunstacias" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Folio_Circunstacias' + rowIndex));}DisabledControl($("#" + nameOfTable + "Tipo_de_Lugar" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_Moral_Dueno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Moral_Dueno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex));}DisabledControl($("#" + nameOfTable + "Persona_Fisica_Dueno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Persona_Fisica_Dueno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo_Involucrado" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Involucrado' + rowIndex));}DisabledControl($("#" + nameOfTable + "Denunciante_dueno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Denunciante_dueno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Nombre_Completo_Dueno" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo_Dueno' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_Inicial" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_Inicial' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion_corta" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_corta' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MP" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MP' + rowIndex));}DisabledControl($("#" + nameOfTable + "Expediente_MASC" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente_MASC' + rowIndex));}} else {}

}
//BusinessRuleId:3617, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3624, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divMotor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motor' + rowIndex));$('#divSerie').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));


}
//BusinessRuleId:3624, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3624, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divMotor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motor' + rowIndex));$('#divSerie').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));


}
//BusinessRuleId:3624, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3624, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divMotor').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Motor' + rowIndex));$('#divSerie').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));


}
//BusinessRuleId:3624, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3626, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClase').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clase' + rowIndex));$('#divVehiculo_Robado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Vehiculo_Robado' + rowIndex));


}
//BusinessRuleId:3626, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3626, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClase').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clase' + rowIndex));$('#divVehiculo_Robado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Vehiculo_Robado' + rowIndex));


}
//BusinessRuleId:3626, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3626, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClase').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clase' + rowIndex));$('#divVehiculo_Robado').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Vehiculo_Robado' + rowIndex));


}
//BusinessRuleId:3626, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3629, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Zona_de_Robo' + rowIndex));


}
//BusinessRuleId:3629, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3629, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Zona_de_Robo' + rowIndex));


}
//BusinessRuleId:3629, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3629, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Zona_de_Robo' + rowIndex));


}
//BusinessRuleId:3629, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3630, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'El_Vehiculo_esta_Asegurado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divNombre_de_la_Aseguradora').css('display', 'block');} else { $('#divNombre_de_la_Aseguradora').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_la_Aseguradora' + rowIndex));}


}
//BusinessRuleId:3630, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3630, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'El_Vehiculo_esta_Asegurado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divNombre_de_la_Aseguradora').css('display', 'block');} else { $('#divNombre_de_la_Aseguradora').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_la_Aseguradora' + rowIndex));}


}
//BusinessRuleId:3630, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3630, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'El_Vehiculo_esta_Asegurado' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divNombre_de_la_Aseguradora').css('display', 'block');} else { $('#divNombre_de_la_Aseguradora').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_de_la_Aseguradora' + rowIndex));}


}
//BusinessRuleId:3630, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( GetValueByControlType($('#' + nameOfTable + 'Mercancia' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'block');} else { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex));}


}
//BusinessRuleId:3631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Mercancia' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'block');} else { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex));}


}
//BusinessRuleId:3631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3631, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( GetValueByControlType($('#' + nameOfTable + 'Mercancia' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'block');} else { $('#divDescripcion_de_lo_que_Transportaba').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_de_lo_que_Transportaba' + rowIndex));}


}
//BusinessRuleId:3631, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3632, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divSe_Informaron_sus_Derechos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));$('#divSe_Informo_el_Procedimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));


}
//BusinessRuleId:3632, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3632, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divSe_Informaron_sus_Derechos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));$('#divSe_Informo_el_Procedimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));


}
//BusinessRuleId:3632, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3632, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divSe_Informaron_sus_Derechos').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informaron_sus_Derechos' + rowIndex));$('#divSe_Informo_el_Procedimiento').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Se_Informo_el_Procedimiento' + rowIndex));


}
//BusinessRuleId:3632, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;




































//BusinessRuleId:2528, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("EXEC uspGetDelitoPrincipalEditar GLOBAL[SpartanOperationId], FLDD[lblClave]",rowIndex, nameOfTable)==TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Delito_Principal' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { alert(DecodifyText('Solo puede existir un delito principal por denuncia. Favor de revisar.', rowIndex, nameOfTable));

result=false; AsignarValor($('#' + nameOfTable + 'Delito_Principal' + rowIndex),'false');} else {}


}
//BusinessRuleId:2528, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:2502, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("EXEC uspGetDelitoPrincipalAlta GLOBAL[SpartanOperationId]",rowIndex, nameOfTable)==TryParseInt('1', '1') && GetValueByControlType($('#' + nameOfTable + 'Delito_Principal' + rowIndex),nameOfTable,rowIndex)==TryParseInt('true', 'true') ) { alert(DecodifyText('Solo puede existir un delito principal por denuncia. Favor de revisar.', rowIndex, nameOfTable));

result=false; AsignarValor($('#' + nameOfTable + 'Delito_Principal' + rowIndex),'false');} else {}


}
//BusinessRuleId:2502, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){


//BusinessRuleId:2512, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Detalle_de_Delito set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:2512, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:2512, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[idTablero]'), ReplaceGLOBAL('GLOBAL[idTablero]'))==TryParseInt('3', '3') ) { EvaluaQuery(" update Detalle_de_Delito set Expediente_MP = GLOBAL[SpartanOperationId] where Clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);} else {}


}
//BusinessRuleId:2512, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRAgravantes_del_Delito(nameOfTable, rowIndex){
    var result = true;
    var ind = rowIndex.substr(1, 1);
    var i = 0;
    if($('#' + nameOfTable + 'Agravante' + rowIndex).find(":selected").text()==""){
        alert(DecodifyText('Seleccione un registro valido.', rowIndex, nameOfTable));
        return false;
    }
    while (i < ind) {
        if($('#' + nameOfTable + 'Agravante_' + i).text() == $('#' + nameOfTable + 'Agravante' + rowIndex).find(":selected").text() )
        {
            result = false;
            alert(DecodifyText('No se puede duplicar el tipo de identificación.', rowIndex, nameOfTable));
            break;
        }
        i++;
      }
    //NEWBUSINESSRULE_BEFORESAVINGMR_Agravantes_del_Delito//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRAgravantes_del_Delito(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Agravantes_del_Delito//
}
function EjecutarValidacionesAlEliminarMRAgravantes_del_Delito(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Agravantes_del_Delito//
    return result;
}
function EjecutarValidacionesNewRowMRAgravantes_del_Delito(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2742, Attribute:265776, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Agravante' + rowIndex));


}
//BusinessRuleId:2742, Attribute:265776, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2742, Attribute:265776, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Agravante' + rowIndex));


}
//BusinessRuleId:2742, Attribute:265776, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Agravantes_del_Delito//
    return result;
}
function EjecutarValidacionesEditRowMRAgravantes_del_Delito(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2742, Attribute:265776, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Agravante' + rowIndex));


}
//BusinessRuleId:2742, Attribute:265776, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2742, Attribute:265776, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Agravante' + rowIndex));


}
//BusinessRuleId:2742, Attribute:265776, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Agravantes_del_Delito//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRCircunstancias_del_Delito(nameOfTable, rowIndex){
    var result = true;
    var ind = rowIndex.substr(1, 1);
    var i = 0;
    if($('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex).find(":selected").text()==""){
        alert(DecodifyText('Seleccione un registro valido.', rowIndex, nameOfTable));
        return false;
    }
    while (i < ind) {
        if($('#' + nameOfTable + 'Tipo_de_Lugar_' + i).text() == $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex).find(":selected").text() )
        {
            result = false;
            alert(DecodifyText('No se puede duplicar el tipo de identificación.', rowIndex, nameOfTable));
            break;
        }
        i++;
      }
    //NEWBUSINESSRULE_BEFORESAVINGMR_Circunstancias_del_Delito//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRCircunstancias_del_Delito(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Circunstancias_del_Delito//
}
function EjecutarValidacionesAlEliminarMRCircunstancias_del_Delito(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Circunstancias_del_Delito//
    return result;
}
function EjecutarValidacionesNewRowMRCircunstancias_del_Delito(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2744, Attribute:265777, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));


}
//BusinessRuleId:2744, Attribute:265777, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2744, Attribute:265777, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));


}
//BusinessRuleId:2744, Attribute:265777, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Circunstancias_del_Delito//
    return result;
}
function EjecutarValidacionesEditRowMRCircunstancias_del_Delito(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2744, Attribute:265777, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));


}
//BusinessRuleId:2744, Attribute:265777, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2744, Attribute:265777, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo_de_Lugar' + rowIndex));


}
//BusinessRuleId:2744, Attribute:265777, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Circunstancias_del_Delito//
    return result;
}

$( "#divEstado_de_Origen_de_las_Placas" ).on( "click", function() {
    $('#Estado_de_Origen_de_las_Placas').empty();
    $("#Estado_de_Origen_de_las_Placas").append('<option value=""></option>');
    $('#Estado_de_Origen_de_las_Placas').val('0').trigger('change');
  });