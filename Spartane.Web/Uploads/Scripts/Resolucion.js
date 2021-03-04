$(document).ready(function () {
    var inpuElementArray = [
        { "inputId": "Clave", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Descripcion", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Tipo", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Resolucion_Padre_para_Autorizacion", "inputType": "select", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Generar_Judicializacion", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "ClaveFiscalia", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Resolucion_AT", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "Resolucion_MP", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "Aplica_para_Adolescentes", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "Aplica_para_Denuncia", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "Aplica_para_Carpeta_de_Investigacion", "inputType": "checkbox", "IsRequired": false, "IsVisible": true, "IsReadOnly": false, "DefaultValue": null, "HelpText": "" }
        ,{ "inputId": "Abreviacion", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Vigencia", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "MostrarDependencia", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Conteo", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Estatus", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Estatus_esp", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Mostrar_Estadistico", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }

    ];
    setInputEntityAttributes(inpuElementArray, "#", 1);
});


