$(document).ready(function () {
    var inpuElementArray = [
        { "inputId": "Clave", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Descripcion", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "Descr", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "iddatos", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }
        ,{ "inputId": "CveSentencia", "inputType": "text", "IsRequired": true, "IsVisible": true, "IsReadOnly": false, "DefaultValue": "", "HelpText": "" }

    ];
    setInputEntityAttributes(inpuElementArray, "#", 1);
});


