$(document).ready(function () {
    var inpuElementArray = [
        { "inputId": "clave", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "fecha_de_registro", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "hora_de_registro", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "usuario_que_registra", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "unidad", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "nuat", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "nic", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "detenido", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "hora_del_detenido", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "hora_puesto_a_disposicion", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "estatus", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "observaciones", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Fecha_de_Canalizacion", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Hora_de_Canalizacion", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "usuario_que_canaliza", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "canalizar_a", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "tipo_de_acuerdo", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "fecha_de_inicio_de_acuerdo", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "fecha_de_cumplimiento", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "hora_de_cumplimiento", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "domicilio_para_el_cumplimiento", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "monto_de_reparacion_de_danos", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "parcialidades", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "periodicidad", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "acepta_acuerdo", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "motivo_de_rechazo_de_acuerdo", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "fecha_de_cierre", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "hora_de_cierre", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "tipo_de_cierre", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "comentarios_de_cierre", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }

    ];
    setInputEntityAttributes(inpuElementArray, "#", 1);
});


