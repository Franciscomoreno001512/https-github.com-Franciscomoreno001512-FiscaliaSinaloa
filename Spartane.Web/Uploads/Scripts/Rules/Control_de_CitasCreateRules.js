var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$('#Control_de_CitasGuardarYNuevo').hide();
$('#Control_de_CitasGuardarYCopia').hide();
$(document).ready(function() {






    //BusinessRuleId:4713, Attribute:266142, Operation:Field, Event:None
    $("form#CreateControl_de_Citas").on('change', '#Fecha_de_la_Cita', function() {
        nameOfTable = '';
        rowIndex = '';
        if (EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103), CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_la_Cita]',103),103))", rowIndex, nameOfTable) <= TryParseInt('-1', '-1')) {
            $('#' + nameOfTable + 'Fecha_de_la_Cita' + rowIndex).attr("placeholder", "No se permite capturar fechas pasadas, favor de revisar.").val("").focus().blur();

            result = false;
        } else {}
    });


    //BusinessRuleId:4713, Attribute:266142, Operation:Field, Event:None













    

    //NEWBUSINESSRULE_NONE//
});

function EjecutarValidacionesAlComienzo() {
    //BusinessRuleId:2033, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Usuario_que_Atiende" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Atiende' + rowIndex)); }
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2033, Attribute:0, Operation:Object, Event:SCREENOPENING

    //BusinessRuleId:2033, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'Update') {
        DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex)); }
        DisabledControl($("#" + nameOfTable + "Usuario_que_Atiende" + rowIndex), ("true" == "true"));
        if ('true' == 'true') { SetNotRequiredToControl($('#' + nameOfTable + 'Usuario_que_Atiende' + rowIndex)); }
        SetNotRequiredToControl($('#' + nameOfTable + 'Observaciones' + rowIndex));


    }
    //BusinessRuleId:2033, Attribute:0, Operation:Object, Event:SCREENOPENING



    //BusinessRuleId:2034, Attribute:0, Operation:Object, Event:SCREENOPENING
    if (operation == 'New') {
        AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex), EvaluaQuery(" select convert (varchar(11),getdate(),105)", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex), EvaluaQuery(" select convert (varchar(8),getdate(),108)", rowIndex, nameOfTable));
        AsignarValor($('#' + nameOfTable + 'Usuario_que_Atiende' + rowIndex), EvaluaQuery("select GLOBAL[USERID]", rowIndex, nameOfTable));


    }
    //BusinessRuleId:2034, Attribute:0, Operation:Object, Event:SCREENOPENING

    //NEWBUSINESSRULE_SCREENOPENING//
}

function EjecutarValidacionesAntesDeGuardar() {
    var result = true;












    

    

    







//BusinessRuleId:4737, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'New'){
if( EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103), CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_la_Cita]',103),103))",rowIndex, nameOfTable)==TryParseInt('0', '0') && EvaluaQuery("select  datediff(minute, (SELECT convert (varchar(8),getdate(),108)), 'FLD[Hora_de_la_Cita]') / 60.0",rowIndex, nameOfTable)<TryParseInt('0', '0') ) { alert(DecodifyText('No se permite capturar una hora pasada, favor de revisar.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4737, Attribute:2, Operation:Object, Event:BEFORESAVING

//BusinessRuleId:4737, Attribute:2, Operation:Object, Event:BEFORESAVING
if(operation == 'Update'){
if( EvaluaQuery("SELECT DATEDIFF(DAY,CONVERT(DATE,CONVERT(VARCHAR(10),GETDATE(),103),103), CONVERT(DATE,CONVERT(VARCHAR(10),'FLD[Fecha_de_la_Cita]',103),103))",rowIndex, nameOfTable)==TryParseInt('0', '0') && EvaluaQuery("select  datediff(minute, (SELECT convert (varchar(8),getdate(),108)), 'FLD[Hora_de_la_Cita]') / 60.0",rowIndex, nameOfTable)<TryParseInt('0', '0') ) { alert(DecodifyText('No se permite capturar una hora pasada, favor de revisar.', rowIndex, nameOfTable));
result=false;} else {}

}
//BusinessRuleId:4737, Attribute:2, Operation:Object, Event:BEFORESAVING

//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}

function EjecutarValidacionesDespuesDeGuardar() {
    //NEWBUSINESSRULE_AFTERSAVING//
}