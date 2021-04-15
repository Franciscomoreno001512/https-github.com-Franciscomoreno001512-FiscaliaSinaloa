$(document).ready(function () {
    var inpuElementArray = [
        { "inputId": "Clave", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Descripcion", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Diligencia", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Origen", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Tipo_de_Documento", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Area_de_Servicios_de_Apoyo", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "SubArea_de_Servicios_de_Apoyo", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "idFormato", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Requerido", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "Solicitante", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "Requerido_o_Solicitante", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "Solicitar_Archivo_Adjunto", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "Solicitar_Numero_de_Oficio", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }

    ];
    setInputEntityAttributes(inpuElementArray, "#", 1);
});


