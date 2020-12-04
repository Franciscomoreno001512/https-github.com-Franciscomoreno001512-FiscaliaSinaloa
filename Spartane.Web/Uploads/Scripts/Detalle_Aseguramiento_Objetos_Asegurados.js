$(document).ready(function () {
    var inpuElementArray = [
        { "inputId": "Clave", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Numero", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Tipo", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Marca", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Serie", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "IMEI", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }

    ];
    setInputEntityAttributes(inpuElementArray, "#Detalle_Aseguramiento_Objetos_Asegurados", 1);
});


