$(document).ready(function () {
    var inpuElementArray = [
        { "inputId": "Folio", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Fecha_de_Generador_de_NUAT", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Anio_de_Generador_de_NUAT", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Tipo_de_Denuncia", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Region", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Consecutivo", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "NUAT_Ultimo_Generado", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }

    ];
    setInputEntityAttributes(inpuElementArray, "#", 1);
});


