

//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Medios_de_Transporte MultiRow
var Detalle_Aseguramiento_Medios_de_TransportecountRowsChecked = 0;

function GetDetalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Medios_de_Transporte_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteItems.length; i++) {
        if (Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteDropDown() {
    var Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Medios_de_Transporte_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteDropdown);
    if(Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteItems[i].Clave, text:    Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteDropdown);
       }
    }
    return Detalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteDropdown;
}
function GetDetalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteItems.length; i++) {
        if (Detalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteDropDown() {
    var Detalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Medios_de_Transporte_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteDropdown);

    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteItems.length; i++) {
        $('<option />', { value: Detalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteItems[i].Clave, text: Detalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteDropdown);
    }
    return Detalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteDropdown;
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteItems.length; i++) {
        if (Detalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteDropDown() {
    var Detalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Medios_de_Transporte_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteDropdown);

    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteItems.length; i++) {
        $('<option />', { value: Detalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteItems[i].Clave, text: Detalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteDropdown);
    }
    return Detalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteDropdown;
}




function GetDetalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteItems.length; i++) {
        if (Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteDropDown() {
    var Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Medios_de_Transporte_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteDropdown);
    if(Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteItems[i].Clave, text:    Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteDropdown);
       }
    }
    return Detalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteDropdown;
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteItems.length; i++) {
        if (Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteDropDown() {
    var Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Medios_de_Transporte_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteDropdown);
    if(Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteItems[i].Clave, text:    Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteDropdown);
       }
    }
    return Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteDropdown;
}
function GetDetalle_Aseguramiento_Medios_de_Transporte_A_TiempoName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoItems.length; i++) {
        if (Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_A_TiempoDropDown() {
    var Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Medios_de_Transporte_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoDropdown);
    if(Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoItems[i].Clave, text:    Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoDropdown);
       }
    }
    return Detalle_Aseguramiento_Medios_de_Transporte_A_TiempoDropdown;
}
function GetDetalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosItems.length; i++) {
        if (Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosDropDown() {
    var Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Medios_de_Transporte_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosDropdown);
    if(Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosItems[i].Clave, text:    Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosDropdown);
       }
    }
    return Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosDropdown;
}




function GetDetalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteItems.length; i++) {
        if (Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteDropDown() {
    var Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Medios_de_Transporte_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteDropdown);
    if(Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteItems[i].Clave, text:    Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteDropdown);
       }
    }
    return Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteDropdown;
}
function GetDetalle_Aseguramiento_Medios_de_Transporte_PensionName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_PensionItems.length; i++) {
        if (Detalle_Aseguramiento_Medios_de_Transporte_PensionItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Medios_de_Transporte_PensionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Medios_de_Transporte_PensionDropDown() {
    var Detalle_Aseguramiento_Medios_de_Transporte_PensionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Medios_de_Transporte_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_PensionDropdown);
    if(Detalle_Aseguramiento_Medios_de_Transporte_PensionItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Medios_de_Transporte_PensionItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Medios_de_Transporte_PensionItems[i].Clave, text:    Detalle_Aseguramiento_Medios_de_Transporte_PensionItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Medios_de_Transporte_PensionDropdown);
       }
    }
    return Detalle_Aseguramiento_Medios_de_Transporte_PensionDropdown;
}




function GetInsertDetalle_Aseguramiento_Medios_de_TransporteRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Medios_de_Transporte_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Medios_de_Transporte', 'Motivo_de_Registro', 'Motivo_de_Registro', 268334)));
    columnData[1] = $(GetDetalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteDropDown()).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_Medios_de_Transporte', 'Tipo_de_medios_de_transporte', 'Tipo', 267566)));
    columnData[2] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Aseguramiento_Medios_de_Transporte_Marca'))).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Marca Marca').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Marca_' + index).attr('data-field', 'Marca').after($.parseHTML(addNew('Detalle_Aseguramiento_Medios_de_Transporte', 'Marca_de_Medio_de_transporte', 'Marca', 267664)));
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Submarca Submarca').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Submarca_' + index).attr('data-field', 'Submarca');
    columnData[4] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Aseguramiento_Medios_de_Transporte_Modelo'))).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Modelo Modelo').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Modelo_' + index).attr('data-field', 'Modelo').after($.parseHTML(addNew('Detalle_Aseguramiento_Medios_de_Transporte', 'Modelo_de_medio_de_transporte', 'Modelo', 267668)));
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Placas Placas').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Placas_' + index).attr('data-field', 'Placas');
    columnData[6] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Color Color').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Color_' + index).attr('data-field', 'Color');
    columnData[7] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Numero_de_Motor Numero_de_Motor').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Numero_de_Motor_' + index).attr('data-field', 'Numero_de_Motor');
    columnData[8] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Serie Serie').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Serie_' + index).attr('data-field', 'Serie');
    columnData[9] = $(GetDetalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteDropDown()).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Uso Uso').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Uso_' + index).attr('data-field', 'Uso').after($.parseHTML(addNew('Detalle_Aseguramiento_Medios_de_Transporte', 'Uso_del_medio_de_transporte', 'Uso', 267674)));
    columnData[10] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Cap__De_Pasajeros Cap__De_Pasajeros').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Cap__De_Pasajeros_' + index).attr('data-field', 'Cap__De_Pasajeros');
    columnData[11] = $(GetDetalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteDropDown()).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Procedencia Procedencia').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Procedencia_' + index).attr('data-field', 'Procedencia').after($.parseHTML(addNew('Detalle_Aseguramiento_Medios_de_Transporte', 'Procedencia_del_medio_de_transporte', 'Procedencia', 267676)));
    columnData[12] = $(GetDetalle_Aseguramiento_Medios_de_Transporte_A_TiempoDropDown()).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Seguro Seguro').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Seguro_' + index).attr('data-field', 'Seguro').after($.parseHTML(addNew('Detalle_Aseguramiento_Medios_de_Transporte', 'A_Tiempo', 'Seguro', 268342)));
    columnData[13] = $(GetDetalle_Aseguramiento_Medios_de_Transporte_Compania_de_SegurosDropDown()).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_Seguros Compania_de_Seguros').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Compania_de_Seguros_' + index).attr('data-field', 'Compania_de_Seguros').after($.parseHTML(addNew('Detalle_Aseguramiento_Medios_de_Transporte', 'Compania_de_Seguros', 'Compania_de_Seguros', 268356)));
    columnData[14] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Empresa Empresa').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Empresa_' + index).attr('data-field', 'Empresa');
    columnData[15] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Capacidad_de_Carga Capacidad_de_Carga').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Capacidad_de_Carga_' + index).attr('data-field', 'Capacidad_de_Carga');
    columnData[16] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Origen Origen').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Origen_' + index).attr('data-field', 'Origen');
    columnData[17] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Destino Destino').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Destino_' + index).attr('data-field', 'Destino');
    columnData[18] = $(GetDetalle_Aseguramiento_Medios_de_Transporte_Ubicacion_de_Medio_de_TransporteDropDown()).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion Ubicacion').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Ubicacion_' + index).attr('data-field', 'Ubicacion').after($.parseHTML(addNew('Detalle_Aseguramiento_Medios_de_Transporte', 'Ubicacion_de_Medio_de_Transporte', 'Ubicacion', 268357)));
    columnData[19] = $(GetDetalle_Aseguramiento_Medios_de_Transporte_PensionDropDown()).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Pension Pension').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Pension_' + index).attr('data-field', 'Pension').after($.parseHTML(addNew('Detalle_Aseguramiento_Medios_de_Transporte', 'Pension', 'Pension', 268358)));
    columnData[20] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Domicilio_Resguardo Domicilio_Resguardo').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Domicilio_Resguardo_' + index).attr('data-field', 'Domicilio_Resguardo');
    columnData[21] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Observaciones Observaciones').attr('id', 'Detalle_Aseguramiento_Medios_de_Transporte_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_Medios_de_TransporteInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Medios_de_Transporte("Detalle_Aseguramiento_Medios_de_Transporte_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_Medios_de_TransporteTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Medios_de_Transporte';
    var prevData = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        , MarcaDescripcion:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Marca:  data.childNodes[counter++].childNodes[0].value 	
        ,Submarca:  data.childNodes[counter++].childNodes[0].value
        , ModeloDescripcion:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Modelo:  data.childNodes[counter++].childNodes[0].value 	
        ,Placas:  data.childNodes[counter++].childNodes[0].value
        ,Color:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Motor:  data.childNodes[counter++].childNodes[0].value
        ,Serie:  data.childNodes[counter++].childNodes[0].value
        ,Uso:  data.childNodes[counter++].childNodes[0].value
        ,Cap__De_Pasajeros: data.childNodes[counter++].childNodes[0].value
        ,Procedencia:  data.childNodes[counter++].childNodes[0].value
        ,Seguro:  data.childNodes[counter++].childNodes[0].value
        ,Compania_de_Seguros:  data.childNodes[counter++].childNodes[0].value
        ,Empresa:  data.childNodes[counter++].childNodes[0].value
        ,Capacidad_de_Carga:  data.childNodes[counter++].childNodes[0].value
        ,Origen:  data.childNodes[counter++].childNodes[0].value
        ,Destino:  data.childNodes[counter++].childNodes[0].value
        ,Ubicacion:  data.childNodes[counter++].childNodes[0].value
        ,Pension:  data.childNodes[counter++].childNodes[0].value
        ,Domicilio_Resguardo:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_Medios_de_TransporteTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Medios_de_TransporterowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_Medios_de_TransporteTable.fnPageChange(iPage);
    Detalle_Aseguramiento_Medios_de_TransportecountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Medios_de_Transporte("Detalle_Aseguramiento_Medios_de_Transporte_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_Medios_de_TransporteCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_Medios_de_TransporteTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_Medios_de_TransporterowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_Medios_de_TransporteGrid(Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetData());
    Detalle_Aseguramiento_Medios_de_TransportecountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_Medios_de_TransporteFromDataTable() {
    var Detalle_Aseguramiento_Medios_de_TransporteData = [];
    var gridData = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_Medios_de_TransporteData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Tipo: gridData[i].Tipo
                ,Marca: gridData[i].Marca
                ,Submarca: gridData[i].Submarca
                ,Modelo: gridData[i].Modelo
                ,Placas: gridData[i].Placas
                ,Color: gridData[i].Color
                ,Numero_de_Motor: gridData[i].Numero_de_Motor
                ,Serie: gridData[i].Serie
                ,Uso: gridData[i].Uso
                ,Cap__De_Pasajeros: gridData[i].Cap__De_Pasajeros
                ,Procedencia: gridData[i].Procedencia
                ,Seguro: gridData[i].Seguro
                ,Compania_de_Seguros: gridData[i].Compania_de_Seguros
                ,Empresa: gridData[i].Empresa
                ,Capacidad_de_Carga: gridData[i].Capacidad_de_Carga
                ,Origen: gridData[i].Origen
                ,Destino: gridData[i].Destino
                ,Ubicacion: gridData[i].Ubicacion
                ,Pension: gridData[i].Pension
                ,Domicilio_Resguardo: gridData[i].Domicilio_Resguardo
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_Medios_de_TransporteData.length; i++) {
        if (removedDetalle_Aseguramiento_Medios_de_TransporteData[i] != null && removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Clave > 0)
            Detalle_Aseguramiento_Medios_de_TransporteData.push({
                Clave: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Motivo_de_Registro
                ,Tipo: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Tipo
                ,Marca: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Marca
                ,Submarca: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Submarca
                ,Modelo: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Modelo
                ,Placas: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Placas
                ,Color: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Color
                ,Numero_de_Motor: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Numero_de_Motor
                ,Serie: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Serie
                ,Uso: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Uso
                ,Cap__De_Pasajeros: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Cap__De_Pasajeros
                ,Procedencia: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Procedencia
                ,Seguro: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Seguro
                ,Compania_de_Seguros: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Compania_de_Seguros
                ,Empresa: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Empresa
                ,Capacidad_de_Carga: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Capacidad_de_Carga
                ,Origen: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Origen
                ,Destino: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Destino
                ,Ubicacion: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Ubicacion
                ,Pension: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Pension
                ,Domicilio_Resguardo: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Domicilio_Resguardo
                ,Observaciones: removedDetalle_Aseguramiento_Medios_de_TransporteData[i].Observaciones

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_Medios_de_TransporteData;
}

function Detalle_Aseguramiento_Medios_de_TransporteEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_Medios_de_TransportecountRowsChecked++;
    var Detalle_Aseguramiento_Medios_de_TransporteRowElement = "Detalle_Aseguramiento_Medios_de_Transporte_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Medios_de_Transporte_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_Medios_de_TransporteGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Medios_de_Transporte_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_Medios_de_TransporteRowElement + "')){ Detalle_Aseguramiento_Medios_de_TransporteInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_Medios_de_TransporteCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_Medios_de_TransporteGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_Medios_de_TransporteGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_Medios_de_TransporteValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Medios_de_Transporte' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Medios_de_Transporte(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_Medios_de_TransportefnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetData().length;
    Detalle_Aseguramiento_Medios_de_TransportefnClickAddRow();
    GetAddDetalle_Aseguramiento_Medios_de_TransportePopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_Medios_de_TransporteEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_Medios_de_TransporteRowElement = "Detalle_Aseguramiento_Medios_de_Transporte_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_Medios_de_TransportePopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_Medios_de_TransporteMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_Medios_de_TransporteTipo').val(prevData.Tipo);
    $('#dvDetalle_Aseguramiento_Medios_de_TransporteMarca').html($($.parseHTML(GetGridAutoComplete(prevData.Marca.label,'AutoCompleteMarca'))).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Marca'));
    $('#Detalle_Aseguramiento_Medios_de_TransporteSubmarca').val(prevData.Submarca);
    $('#dvDetalle_Aseguramiento_Medios_de_TransporteModelo').html($($.parseHTML(GetGridAutoComplete(prevData.Modelo.label,'AutoCompleteModelo'))).addClass('Detalle_Aseguramiento_Medios_de_Transporte_Modelo'));
    $('#Detalle_Aseguramiento_Medios_de_TransportePlacas').val(prevData.Placas);
    $('#Detalle_Aseguramiento_Medios_de_TransporteColor').val(prevData.Color);
    $('#Detalle_Aseguramiento_Medios_de_TransporteNumero_de_Motor').val(prevData.Numero_de_Motor);
    $('#Detalle_Aseguramiento_Medios_de_TransporteSerie').val(prevData.Serie);
    $('#Detalle_Aseguramiento_Medios_de_TransporteUso').val(prevData.Uso);
    $('#Detalle_Aseguramiento_Medios_de_TransporteCap__De_Pasajeros').val(prevData.Cap__De_Pasajeros);
    $('#Detalle_Aseguramiento_Medios_de_TransporteProcedencia').val(prevData.Procedencia);
    $('#Detalle_Aseguramiento_Medios_de_TransporteSeguro').val(prevData.Seguro);
    $('#Detalle_Aseguramiento_Medios_de_TransporteCompania_de_Seguros').val(prevData.Compania_de_Seguros);
    $('#Detalle_Aseguramiento_Medios_de_TransporteEmpresa').val(prevData.Empresa);
    $('#Detalle_Aseguramiento_Medios_de_TransporteCapacidad_de_Carga').val(prevData.Capacidad_de_Carga);
    $('#Detalle_Aseguramiento_Medios_de_TransporteOrigen').val(prevData.Origen);
    $('#Detalle_Aseguramiento_Medios_de_TransporteDestino').val(prevData.Destino);
    $('#Detalle_Aseguramiento_Medios_de_TransporteUbicacion').val(prevData.Ubicacion);
    $('#Detalle_Aseguramiento_Medios_de_TransportePension').val(prevData.Pension);
    $('#Detalle_Aseguramiento_Medios_de_TransporteDomicilio_Resguardo').val(prevData.Domicilio_Resguardo);
    $('#Detalle_Aseguramiento_Medios_de_TransporteObservaciones').val(prevData.Observaciones);

    initiateUIControls();
























}

function Detalle_Aseguramiento_Medios_de_TransporteAddInsertRow() {
    if (Detalle_Aseguramiento_Medios_de_TransporteinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_Medios_de_TransporteinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Tipo: ""
        ,Marca: ""
        ,Submarca: ""
        ,Modelo: ""
        ,Placas: ""
        ,Color: ""
        ,Numero_de_Motor: ""
        ,Serie: ""
        ,Uso: ""
        ,Cap__De_Pasajeros: ""
        ,Procedencia: ""
        ,Seguro: ""
        ,Compania_de_Seguros: ""
        ,Empresa: ""
        ,Capacidad_de_Carga: ""
        ,Origen: ""
        ,Destino: ""
        ,Ubicacion: ""
        ,Pension: ""
        ,Domicilio_Resguardo: ""
        ,Observaciones: ""

    }
}

function Detalle_Aseguramiento_Medios_de_TransportefnClickAddRow() {
    Detalle_Aseguramiento_Medios_de_TransportecountRowsChecked++;
    Detalle_Aseguramiento_Medios_de_TransporteTable.fnAddData(Detalle_Aseguramiento_Medios_de_TransporteAddInsertRow(), true);
    Detalle_Aseguramiento_Medios_de_TransporteTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_Medios_de_TransporteGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_Medios_de_TransporteGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_Medios_de_TransporteinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Medios_de_Transporte("Detalle_Aseguramiento_Medios_de_Transporte_", "_" + Detalle_Aseguramiento_Medios_de_TransporteinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_Medios_de_TransporteClearGridData() {
    Detalle_Aseguramiento_Medios_de_TransporteData = [];
    Detalle_Aseguramiento_Medios_de_TransportedeletedItem = [];
    Detalle_Aseguramiento_Medios_de_TransporteDataMain = [];
    Detalle_Aseguramiento_Medios_de_TransporteDataMainPages = [];
    Detalle_Aseguramiento_Medios_de_TransportenewItemCount = 0;
    Detalle_Aseguramiento_Medios_de_TransportemaxItemIndex = 0;
    $("#Detalle_Aseguramiento_Medios_de_TransporteGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_Medios_de_TransporteGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Medios_de_Transporte() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_Medios_de_TransporteData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_Medios_de_TransporteData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_Medios_de_TransporteData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_Medios_de_TransporteData[i].Tipo);
        form_data.append('[' + i + '].Marca', Detalle_Aseguramiento_Medios_de_TransporteData[i].Marca);
        form_data.append('[' + i + '].Submarca', Detalle_Aseguramiento_Medios_de_TransporteData[i].Submarca);
        form_data.append('[' + i + '].Modelo', Detalle_Aseguramiento_Medios_de_TransporteData[i].Modelo);
        form_data.append('[' + i + '].Placas', Detalle_Aseguramiento_Medios_de_TransporteData[i].Placas);
        form_data.append('[' + i + '].Color', Detalle_Aseguramiento_Medios_de_TransporteData[i].Color);
        form_data.append('[' + i + '].Numero_de_Motor', Detalle_Aseguramiento_Medios_de_TransporteData[i].Numero_de_Motor);
        form_data.append('[' + i + '].Serie', Detalle_Aseguramiento_Medios_de_TransporteData[i].Serie);
        form_data.append('[' + i + '].Uso', Detalle_Aseguramiento_Medios_de_TransporteData[i].Uso);
        form_data.append('[' + i + '].Cap__De_Pasajeros', Detalle_Aseguramiento_Medios_de_TransporteData[i].Cap__De_Pasajeros);
        form_data.append('[' + i + '].Procedencia', Detalle_Aseguramiento_Medios_de_TransporteData[i].Procedencia);
        form_data.append('[' + i + '].Seguro', Detalle_Aseguramiento_Medios_de_TransporteData[i].Seguro);
        form_data.append('[' + i + '].Compania_de_Seguros', Detalle_Aseguramiento_Medios_de_TransporteData[i].Compania_de_Seguros);
        form_data.append('[' + i + '].Empresa', Detalle_Aseguramiento_Medios_de_TransporteData[i].Empresa);
        form_data.append('[' + i + '].Capacidad_de_Carga', Detalle_Aseguramiento_Medios_de_TransporteData[i].Capacidad_de_Carga);
        form_data.append('[' + i + '].Origen', Detalle_Aseguramiento_Medios_de_TransporteData[i].Origen);
        form_data.append('[' + i + '].Destino', Detalle_Aseguramiento_Medios_de_TransporteData[i].Destino);
        form_data.append('[' + i + '].Ubicacion', Detalle_Aseguramiento_Medios_de_TransporteData[i].Ubicacion);
        form_data.append('[' + i + '].Pension', Detalle_Aseguramiento_Medios_de_TransporteData[i].Pension);
        form_data.append('[' + i + '].Domicilio_Resguardo', Detalle_Aseguramiento_Medios_de_TransporteData[i].Domicilio_Resguardo);
        form_data.append('[' + i + '].Observaciones', Detalle_Aseguramiento_Medios_de_TransporteData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_Medios_de_TransporteData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_Medios_de_TransporteInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Medios_de_Transporte("Detalle_Aseguramiento_Medios_de_TransporteTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Medios_de_TransporteTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_Medios_de_TransporteMotivo_de_Registro').val()
        ,Tipo: $('#Detalle_Aseguramiento_Medios_de_TransporteTipo').val()
        ,Marca: $('#Detalle_Aseguramiento_Medios_de_TransporteMarca').val()
        ,Submarca: $('#Detalle_Aseguramiento_Medios_de_TransporteSubmarca').val()
        ,Modelo: $('#Detalle_Aseguramiento_Medios_de_TransporteModelo').val()
        ,Placas: $('#Detalle_Aseguramiento_Medios_de_TransportePlacas').val()
        ,Color: $('#Detalle_Aseguramiento_Medios_de_TransporteColor').val()
        ,Numero_de_Motor: $('#Detalle_Aseguramiento_Medios_de_TransporteNumero_de_Motor').val()
        ,Serie: $('#Detalle_Aseguramiento_Medios_de_TransporteSerie').val()
        ,Uso: $('#Detalle_Aseguramiento_Medios_de_TransporteUso').val()
        ,Cap__De_Pasajeros: $('#Detalle_Aseguramiento_Medios_de_TransporteCap__De_Pasajeros').val()

        ,Procedencia: $('#Detalle_Aseguramiento_Medios_de_TransporteProcedencia').val()
        ,Seguro: $('#Detalle_Aseguramiento_Medios_de_TransporteSeguro').val()
        ,Compania_de_Seguros: $('#Detalle_Aseguramiento_Medios_de_TransporteCompania_de_Seguros').val()
        ,Empresa: $('#Detalle_Aseguramiento_Medios_de_TransporteEmpresa').val()
        ,Capacidad_de_Carga: $('#Detalle_Aseguramiento_Medios_de_TransporteCapacidad_de_Carga').val()
        ,Origen: $('#Detalle_Aseguramiento_Medios_de_TransporteOrigen').val()
        ,Destino: $('#Detalle_Aseguramiento_Medios_de_TransporteDestino').val()
        ,Ubicacion: $('#Detalle_Aseguramiento_Medios_de_TransporteUbicacion').val()
        ,Pension: $('#Detalle_Aseguramiento_Medios_de_TransportePension').val()
        ,Domicilio_Resguardo: $('#Detalle_Aseguramiento_Medios_de_TransporteDomicilio_Resguardo').val()
        ,Observaciones: $('#Detalle_Aseguramiento_Medios_de_TransporteObservaciones').val()

    }

    Detalle_Aseguramiento_Medios_de_TransporteTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Medios_de_TransporterowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Medios_de_Transporte-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Medios_de_Transporte-form').modal('hide');
    Detalle_Aseguramiento_Medios_de_TransporteEditRow(rowIndex);
    Detalle_Aseguramiento_Medios_de_TransporteInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_Medios_de_TransporteRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_Medios_de_TransporteTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Medios_de_Transporte MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_de_Drogas_Involucradas MultiRow
var Detalle_Aseguramiento_de_Drogas_InvolucradascountRowsChecked = 0;

function GetDetalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Drogas_Involucradas_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaItems.length; i++) {
        if (Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaDropDown() {
    var Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Drogas_Involucradas_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaDropdown);
    if(Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaItems[i].Clave, text:    Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaDropdown;
}
function GetDetalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasItems.length; i++) {
        if (Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasDropDown() {
    var Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Drogas_Involucradas_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasDropdown);
    if(Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasItems[i].Clave, text:    Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasDropdown;
}
function GetDetalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaItems.length; i++) {
        if (Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaDropDown() {
    var Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Drogas_Involucradas_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaDropdown);
    if(Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaItems[i].Clave, text:    Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaDropdown;
}




function GetInsertDetalle_Aseguramiento_de_Drogas_InvolucradasRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_de_Drogas_Involucradas_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Drogas_Involucradas', 'Motivo_de_Registro', 'Motivo_de_Registro', 268335)));
    columnData[1] = $(GetDetalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaDropDown()).addClass('Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_de_Drogas_Involucradas_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Drogas_Involucradas', 'Tipo_de_Droga', 'Tipo', 267612)));
    columnData[2] = $(GetDetalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_de_DrogasDropDown()).addClass('Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado Modo_de_Asegurado').attr('id', 'Detalle_Aseguramiento_de_Drogas_Involucradas_Modo_de_Asegurado_' + index).attr('data-field', 'Modo_de_Asegurado').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Drogas_Involucradas', 'Modo_de_Asegurado_de_Drogas', 'Modo_de_Asegurado', 268365)));
    columnData[3] = $(GetDetalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaDropDown()).addClass('Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_Medida Unidad_de_Medida').attr('id', 'Detalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_Medida_' + index).attr('data-field', 'Unidad_de_Medida').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Drogas_Involucradas', 'Unidad_de_medida_de_tipo_de_droga', 'Unidad_de_Medida', 267613)));
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_de_Drogas_Involucradas_Cantidad Cantidad').attr('id', 'Detalle_Aseguramiento_de_Drogas_Involucradas_Cantidad_' + index).attr('data-field', 'Cantidad');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Drogas_Involucradas_Observaciones Observaciones').attr('id', 'Detalle_Aseguramiento_de_Drogas_Involucradas_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_de_Drogas_InvolucradasInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Drogas_Involucradas("Detalle_Aseguramiento_de_Drogas_Involucradas_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_de_Drogas_Involucradas';
    var prevData = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,Modo_de_Asegurado:  data.childNodes[counter++].childNodes[0].value
        ,Unidad_de_Medida:  data.childNodes[counter++].childNodes[0].value
        ,Cantidad: data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_de_Drogas_InvolucradasrowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnPageChange(iPage);
    Detalle_Aseguramiento_de_Drogas_InvolucradascountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_de_Drogas_Involucradas("Detalle_Aseguramiento_de_Drogas_Involucradas_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_de_Drogas_InvolucradasCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_de_Drogas_InvolucradasrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_de_Drogas_InvolucradasGrid(Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetData());
    Detalle_Aseguramiento_de_Drogas_InvolucradascountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_de_Drogas_InvolucradasFromDataTable() {
    var Detalle_Aseguramiento_de_Drogas_InvolucradasData = [];
    var gridData = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_de_Drogas_InvolucradasData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Tipo: gridData[i].Tipo
                ,Modo_de_Asegurado: gridData[i].Modo_de_Asegurado
                ,Unidad_de_Medida: gridData[i].Unidad_de_Medida
                ,Cantidad: gridData[i].Cantidad
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_de_Drogas_InvolucradasData.length; i++) {
        if (removedDetalle_Aseguramiento_de_Drogas_InvolucradasData[i] != null && removedDetalle_Aseguramiento_de_Drogas_InvolucradasData[i].Clave > 0)
            Detalle_Aseguramiento_de_Drogas_InvolucradasData.push({
                Clave: removedDetalle_Aseguramiento_de_Drogas_InvolucradasData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_de_Drogas_InvolucradasData[i].Motivo_de_Registro
                ,Tipo: removedDetalle_Aseguramiento_de_Drogas_InvolucradasData[i].Tipo
                ,Modo_de_Asegurado: removedDetalle_Aseguramiento_de_Drogas_InvolucradasData[i].Modo_de_Asegurado
                ,Unidad_de_Medida: removedDetalle_Aseguramiento_de_Drogas_InvolucradasData[i].Unidad_de_Medida
                ,Cantidad: removedDetalle_Aseguramiento_de_Drogas_InvolucradasData[i].Cantidad
                ,Observaciones: removedDetalle_Aseguramiento_de_Drogas_InvolucradasData[i].Observaciones

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_de_Drogas_InvolucradasData;
}

function Detalle_Aseguramiento_de_Drogas_InvolucradasEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_de_Drogas_InvolucradascountRowsChecked++;
    var Detalle_Aseguramiento_de_Drogas_InvolucradasRowElement = "Detalle_Aseguramiento_de_Drogas_Involucradas_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_de_Drogas_Involucradas_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_de_Drogas_InvolucradasGetUpdateRowControls(prevData, "Detalle_Aseguramiento_de_Drogas_Involucradas_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_de_Drogas_InvolucradasRowElement + "')){ Detalle_Aseguramiento_de_Drogas_InvolucradasInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_de_Drogas_InvolucradasCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_de_Drogas_InvolucradasGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_de_Drogas_InvolucradasGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_de_Drogas_InvolucradasValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_de_Drogas_Involucradas' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_de_Drogas_Involucradas(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_de_Drogas_InvolucradasfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetData().length;
    Detalle_Aseguramiento_de_Drogas_InvolucradasfnClickAddRow();
    GetAddDetalle_Aseguramiento_de_Drogas_InvolucradasPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_de_Drogas_InvolucradasEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_de_Drogas_InvolucradasRowElement = "Detalle_Aseguramiento_de_Drogas_Involucradas_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_de_Drogas_InvolucradasPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_de_Drogas_InvolucradasMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_de_Drogas_InvolucradasTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_de_Drogas_InvolucradasModo_de_Asegurado').val(prevData.Modo_de_Asegurado);
    $('#Detalle_Aseguramiento_de_Drogas_InvolucradasUnidad_de_Medida').val(prevData.Unidad_de_Medida);
    $('#Detalle_Aseguramiento_de_Drogas_InvolucradasCantidad').val(prevData.Cantidad);
    $('#Detalle_Aseguramiento_de_Drogas_InvolucradasObservaciones').val(prevData.Observaciones);

    initiateUIControls();








}

function Detalle_Aseguramiento_de_Drogas_InvolucradasAddInsertRow() {
    if (Detalle_Aseguramiento_de_Drogas_InvolucradasinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_de_Drogas_InvolucradasinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Tipo: ""
        ,Modo_de_Asegurado: ""
        ,Unidad_de_Medida: ""
        ,Cantidad: ""
        ,Observaciones: ""

    }
}

function Detalle_Aseguramiento_de_Drogas_InvolucradasfnClickAddRow() {
    Detalle_Aseguramiento_de_Drogas_InvolucradascountRowsChecked++;
    Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnAddData(Detalle_Aseguramiento_de_Drogas_InvolucradasAddInsertRow(), true);
    Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_de_Drogas_InvolucradasGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_de_Drogas_InvolucradasGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_de_Drogas_InvolucradasinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_de_Drogas_Involucradas("Detalle_Aseguramiento_de_Drogas_Involucradas_", "_" + Detalle_Aseguramiento_de_Drogas_InvolucradasinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_de_Drogas_InvolucradasClearGridData() {
    Detalle_Aseguramiento_de_Drogas_InvolucradasData = [];
    Detalle_Aseguramiento_de_Drogas_InvolucradasdeletedItem = [];
    Detalle_Aseguramiento_de_Drogas_InvolucradasDataMain = [];
    Detalle_Aseguramiento_de_Drogas_InvolucradasDataMainPages = [];
    Detalle_Aseguramiento_de_Drogas_InvolucradasnewItemCount = 0;
    Detalle_Aseguramiento_de_Drogas_InvolucradasmaxItemIndex = 0;
    $("#Detalle_Aseguramiento_de_Drogas_InvolucradasGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_de_Drogas_InvolucradasGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_de_Drogas_Involucradas() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_InvolucradasData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_de_Drogas_InvolucradasData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_de_Drogas_InvolucradasData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_de_Drogas_InvolucradasData[i].Tipo);
        form_data.append('[' + i + '].Modo_de_Asegurado', Detalle_Aseguramiento_de_Drogas_InvolucradasData[i].Modo_de_Asegurado);
        form_data.append('[' + i + '].Unidad_de_Medida', Detalle_Aseguramiento_de_Drogas_InvolucradasData[i].Unidad_de_Medida);
        form_data.append('[' + i + '].Cantidad', Detalle_Aseguramiento_de_Drogas_InvolucradasData[i].Cantidad);
        form_data.append('[' + i + '].Observaciones', Detalle_Aseguramiento_de_Drogas_InvolucradasData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_de_Drogas_InvolucradasData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_de_Drogas_InvolucradasInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Drogas_Involucradas("Detalle_Aseguramiento_de_Drogas_InvolucradasTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_de_Drogas_InvolucradasMotivo_de_Registro').val()
        ,Tipo: $('#Detalle_Aseguramiento_de_Drogas_InvolucradasTipo').val()
        ,Modo_de_Asegurado: $('#Detalle_Aseguramiento_de_Drogas_InvolucradasModo_de_Asegurado').val()
        ,Unidad_de_Medida: $('#Detalle_Aseguramiento_de_Drogas_InvolucradasUnidad_de_Medida').val()
        ,Cantidad: $('#Detalle_Aseguramiento_de_Drogas_InvolucradasCantidad').val()
        ,Observaciones: $('#Detalle_Aseguramiento_de_Drogas_InvolucradasObservaciones').val()

    }

    Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_de_Drogas_InvolucradasrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_de_Drogas_Involucradas-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_de_Drogas_Involucradas-form').modal('hide');
    Detalle_Aseguramiento_de_Drogas_InvolucradasEditRow(rowIndex);
    Detalle_Aseguramiento_de_Drogas_InvolucradasInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_de_Drogas_InvolucradasRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_de_Drogas_InvolucradasTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_de_Drogas_Involucradas MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Armas_Involucradas MultiRow
var Detalle_Aseguramiento_Armas_InvolucradascountRowsChecked = 0;

function GetDetalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Armas_Involucradas_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaItems.length; i++) {
        if (Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaDropDown() {
    var Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Armas_Involucradas_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaDropdown);
    if(Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaItems[i].Clave, text:    Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaItems[i].Nombre }).appendTo(Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaDropdown);
       }
    }
    return Detalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaDropdown;
}

function GetDetalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaItems.length; i++) {
        if (Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaDropDown() {
    var Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Armas_Involucradas_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaDropdown);
    if(Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaItems[i].Clave, text:    Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaItems[i].Nombre }).appendTo(Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaDropdown);
       }
    }
    return Detalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaDropdown;
}
function GetDetalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaItems.length; i++) {
        if (Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaDropDown() {
    var Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Armas_Involucradas_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaDropdown);
    if(Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaItems[i].Clave, text:    Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaDropdown);
       }
    }
    return Detalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaDropdown;
}




function GetDetalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionItems.length; i++) {
        if (Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionDropDown() {
    var Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Armas_Involucradas_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionDropdown);
    if(Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionItems[i].Clave, text:    Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionDropdown);
       }
    }
    return Detalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionDropdown;
}





function GetInsertDetalle_Aseguramiento_Armas_InvolucradasRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Armas_Involucradas_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Armas_Involucradas', 'Motivo_de_Registro', 'Motivo_de_Registro', 268336)));
    columnData[1] = $(GetDetalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaDropDown()).addClass('Detalle_Aseguramiento_Armas_Involucradas_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_Armas_Involucradas', 'Tipo_de_Arma', 'Tipo', 267531)));
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Armas_Involucradas_Descripcion_del_Arma Descripcion_del_Arma').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Descripcion_del_Arma_' + index).attr('data-field', 'Descripcion_del_Arma');
    columnData[3] = $(GetDetalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaDropDown()).addClass('Detalle_Aseguramiento_Armas_Involucradas_Marca Marca').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Marca_' + index).attr('data-field', 'Marca').after($.parseHTML(addNew('Detalle_Aseguramiento_Armas_Involucradas', 'Marca_de_Arma', 'Marca', 267533)));
    columnData[4] = $(GetDetalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaDropDown()).addClass('Detalle_Aseguramiento_Armas_Involucradas_Calibre Calibre').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Calibre_' + index).attr('data-field', 'Calibre').after($.parseHTML(addNew('Detalle_Aseguramiento_Armas_Involucradas', 'Calibre_de_Arma', 'Calibre', 267534)));
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Armas_Involucradas_Matricula Matricula').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Matricula_' + index).attr('data-field', 'Matricula');
    columnData[6] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Armas_Involucradas_Serie Serie').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Serie_' + index).attr('data-field', 'Serie');
    columnData[7] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Aseguramiento_Armas_Involucradas_Arma_Oficial Arma_Oficial').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Arma_Oficial_' + index).attr('data-field', 'Arma_Oficial');
    columnData[8] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Armas_Involucradas_Inventario Inventario').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Inventario_' + index).attr('data-field', 'Inventario');
    columnData[9] = $(GetDetalle_Aseguramiento_Armas_Involucradas_Tipo_ClasificacionDropDown()).addClass('Detalle_Aseguramiento_Armas_Involucradas_Clasificacion Clasificacion').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Clasificacion_' + index).attr('data-field', 'Clasificacion').after($.parseHTML(addNew('Detalle_Aseguramiento_Armas_Involucradas', 'Tipo_Clasificacion', 'Clasificacion', 267538)));
    columnData[10] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_Armas_Involucradas_Valor_Estimado Valor_Estimado inputMoney').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Valor_Estimado_' + index).attr('data-field', 'Valor_Estimado');
    columnData[11] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Armas_Involucradas_Lugar_de_Hallazgo Lugar_de_Hallazgo').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Lugar_de_Hallazgo_' + index).attr('data-field', 'Lugar_de_Hallazgo');
    columnData[12] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Armas_Involucradas_Observaciones Observaciones').attr('id', 'Detalle_Aseguramiento_Armas_Involucradas_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_Armas_InvolucradasInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Armas_Involucradas("Detalle_Aseguramiento_Armas_Involucradas_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_Armas_InvolucradasTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Armas_Involucradas';
    var prevData = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion_del_Arma:  data.childNodes[counter++].childNodes[0].value
        ,Marca:  data.childNodes[counter++].childNodes[0].value
        ,Calibre:  data.childNodes[counter++].childNodes[0].value
        ,Matricula:  data.childNodes[counter++].childNodes[0].value
        ,Serie:  data.childNodes[counter++].childNodes[0].value
        ,Arma_Oficial: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Inventario:  data.childNodes[counter++].childNodes[0].value
        ,Clasificacion:  data.childNodes[counter++].childNodes[0].value
        ,Valor_Estimado:  data.childNodes[counter++].childNodes[0].value
        ,Lugar_de_Hallazgo:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_Armas_InvolucradasTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Armas_InvolucradasrowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_Armas_InvolucradasTable.fnPageChange(iPage);
    Detalle_Aseguramiento_Armas_InvolucradascountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Armas_Involucradas("Detalle_Aseguramiento_Armas_Involucradas_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_Armas_InvolucradasCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_Armas_InvolucradasTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_Armas_InvolucradasrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_Armas_InvolucradasGrid(Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetData());
    Detalle_Aseguramiento_Armas_InvolucradascountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_Armas_InvolucradasFromDataTable() {
    var Detalle_Aseguramiento_Armas_InvolucradasData = [];
    var gridData = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_Armas_InvolucradasData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Tipo: gridData[i].Tipo
                ,Descripcion_del_Arma: gridData[i].Descripcion_del_Arma
                ,Marca: gridData[i].Marca
                ,Calibre: gridData[i].Calibre
                ,Matricula: gridData[i].Matricula
                ,Serie: gridData[i].Serie
                ,Arma_Oficial: gridData[i].Arma_Oficial
                ,Inventario: gridData[i].Inventario
                ,Clasificacion: gridData[i].Clasificacion
                ,Valor_Estimado: gridData[i].Valor_Estimado
                ,Lugar_de_Hallazgo: gridData[i].Lugar_de_Hallazgo
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_Armas_InvolucradasData.length; i++) {
        if (removedDetalle_Aseguramiento_Armas_InvolucradasData[i] != null && removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Clave > 0)
            Detalle_Aseguramiento_Armas_InvolucradasData.push({
                Clave: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Motivo_de_Registro
                ,Tipo: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Tipo
                ,Descripcion_del_Arma: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Descripcion_del_Arma
                ,Marca: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Marca
                ,Calibre: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Calibre
                ,Matricula: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Matricula
                ,Serie: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Serie
                ,Arma_Oficial: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Arma_Oficial
                ,Inventario: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Inventario
                ,Clasificacion: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Clasificacion
                ,Valor_Estimado: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Valor_Estimado
                ,Lugar_de_Hallazgo: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Lugar_de_Hallazgo
                ,Observaciones: removedDetalle_Aseguramiento_Armas_InvolucradasData[i].Observaciones

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_Armas_InvolucradasData;
}

function Detalle_Aseguramiento_Armas_InvolucradasEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_Armas_InvolucradascountRowsChecked++;
    var Detalle_Aseguramiento_Armas_InvolucradasRowElement = "Detalle_Aseguramiento_Armas_Involucradas_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Armas_Involucradas_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_Armas_InvolucradasGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Armas_Involucradas_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_Armas_InvolucradasRowElement + "')){ Detalle_Aseguramiento_Armas_InvolucradasInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_Armas_InvolucradasCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_Armas_InvolucradasGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_Armas_InvolucradasGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_Armas_InvolucradasValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Armas_Involucradas' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Armas_Involucradas(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_Armas_InvolucradasfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetData().length;
    Detalle_Aseguramiento_Armas_InvolucradasfnClickAddRow();
    GetAddDetalle_Aseguramiento_Armas_InvolucradasPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_Armas_InvolucradasEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_Armas_InvolucradasRowElement = "Detalle_Aseguramiento_Armas_Involucradas_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_Armas_InvolucradasPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_Armas_InvolucradasMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_Armas_InvolucradasTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_Armas_InvolucradasDescripcion_del_Arma').val(prevData.Descripcion_del_Arma);
    $('#Detalle_Aseguramiento_Armas_InvolucradasMarca').val(prevData.Marca);
    $('#Detalle_Aseguramiento_Armas_InvolucradasCalibre').val(prevData.Calibre);
    $('#Detalle_Aseguramiento_Armas_InvolucradasMatricula').val(prevData.Matricula);
    $('#Detalle_Aseguramiento_Armas_InvolucradasSerie').val(prevData.Serie);
    $('#Detalle_Aseguramiento_Armas_InvolucradasArma_Oficial').prop('checked', prevData.Arma_Oficial);
    $('#Detalle_Aseguramiento_Armas_InvolucradasInventario').val(prevData.Inventario);
    $('#Detalle_Aseguramiento_Armas_InvolucradasClasificacion').val(prevData.Clasificacion);
    $('#Detalle_Aseguramiento_Armas_InvolucradasValor_Estimado').val(prevData.Valor_Estimado);
    $('#Detalle_Aseguramiento_Armas_InvolucradasLugar_de_Hallazgo').val(prevData.Lugar_de_Hallazgo);
    $('#Detalle_Aseguramiento_Armas_InvolucradasObservaciones').val(prevData.Observaciones);

    initiateUIControls();















}

function Detalle_Aseguramiento_Armas_InvolucradasAddInsertRow() {
    if (Detalle_Aseguramiento_Armas_InvolucradasinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_Armas_InvolucradasinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Tipo: ""
        ,Descripcion_del_Arma: ""
        ,Marca: ""
        ,Calibre: ""
        ,Matricula: ""
        ,Serie: ""
        ,Arma_Oficial: ""
        ,Inventario: ""
        ,Clasificacion: ""
        ,Valor_Estimado: ""
        ,Lugar_de_Hallazgo: ""
        ,Observaciones: ""

    }
}

function Detalle_Aseguramiento_Armas_InvolucradasfnClickAddRow() {
    Detalle_Aseguramiento_Armas_InvolucradascountRowsChecked++;
    Detalle_Aseguramiento_Armas_InvolucradasTable.fnAddData(Detalle_Aseguramiento_Armas_InvolucradasAddInsertRow(), true);
    Detalle_Aseguramiento_Armas_InvolucradasTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_Armas_InvolucradasGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_Armas_InvolucradasGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_Armas_InvolucradasinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Armas_Involucradas("Detalle_Aseguramiento_Armas_Involucradas_", "_" + Detalle_Aseguramiento_Armas_InvolucradasinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_Armas_InvolucradasClearGridData() {
    Detalle_Aseguramiento_Armas_InvolucradasData = [];
    Detalle_Aseguramiento_Armas_InvolucradasdeletedItem = [];
    Detalle_Aseguramiento_Armas_InvolucradasDataMain = [];
    Detalle_Aseguramiento_Armas_InvolucradasDataMainPages = [];
    Detalle_Aseguramiento_Armas_InvolucradasnewItemCount = 0;
    Detalle_Aseguramiento_Armas_InvolucradasmaxItemIndex = 0;
    $("#Detalle_Aseguramiento_Armas_InvolucradasGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_Armas_InvolucradasGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Armas_Involucradas() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_Armas_InvolucradasData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_Armas_InvolucradasData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_Armas_InvolucradasData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_Armas_InvolucradasData[i].Tipo);
        form_data.append('[' + i + '].Descripcion_del_Arma', Detalle_Aseguramiento_Armas_InvolucradasData[i].Descripcion_del_Arma);
        form_data.append('[' + i + '].Marca', Detalle_Aseguramiento_Armas_InvolucradasData[i].Marca);
        form_data.append('[' + i + '].Calibre', Detalle_Aseguramiento_Armas_InvolucradasData[i].Calibre);
        form_data.append('[' + i + '].Matricula', Detalle_Aseguramiento_Armas_InvolucradasData[i].Matricula);
        form_data.append('[' + i + '].Serie', Detalle_Aseguramiento_Armas_InvolucradasData[i].Serie);
        form_data.append('[' + i + '].Arma_Oficial', Detalle_Aseguramiento_Armas_InvolucradasData[i].Arma_Oficial);
        form_data.append('[' + i + '].Inventario', Detalle_Aseguramiento_Armas_InvolucradasData[i].Inventario);
        form_data.append('[' + i + '].Clasificacion', Detalle_Aseguramiento_Armas_InvolucradasData[i].Clasificacion);
        form_data.append('[' + i + '].Valor_Estimado', Detalle_Aseguramiento_Armas_InvolucradasData[i].Valor_Estimado.toString().replace('$',''));
        form_data.append('[' + i + '].Lugar_de_Hallazgo', Detalle_Aseguramiento_Armas_InvolucradasData[i].Lugar_de_Hallazgo);
        form_data.append('[' + i + '].Observaciones', Detalle_Aseguramiento_Armas_InvolucradasData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_Armas_InvolucradasData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_Armas_InvolucradasInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Armas_Involucradas("Detalle_Aseguramiento_Armas_InvolucradasTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Armas_InvolucradasTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_Armas_InvolucradasMotivo_de_Registro').val()
        ,Tipo: $('#Detalle_Aseguramiento_Armas_InvolucradasTipo').val()
        ,Descripcion_del_Arma: $('#Detalle_Aseguramiento_Armas_InvolucradasDescripcion_del_Arma').val()
        ,Marca: $('#Detalle_Aseguramiento_Armas_InvolucradasMarca').val()
        ,Calibre: $('#Detalle_Aseguramiento_Armas_InvolucradasCalibre').val()
        ,Matricula: $('#Detalle_Aseguramiento_Armas_InvolucradasMatricula').val()
        ,Serie: $('#Detalle_Aseguramiento_Armas_InvolucradasSerie').val()
        ,Arma_Oficial: $('#Detalle_Aseguramiento_Armas_InvolucradasArma_Oficial').is(':checked')
        ,Inventario: $('#Detalle_Aseguramiento_Armas_InvolucradasInventario').val()
        ,Clasificacion: $('#Detalle_Aseguramiento_Armas_InvolucradasClasificacion').val()
        ,Valor_Estimado: $('#Detalle_Aseguramiento_Armas_InvolucradasValor_Estimado').val()
        ,Lugar_de_Hallazgo: $('#Detalle_Aseguramiento_Armas_InvolucradasLugar_de_Hallazgo').val()
        ,Observaciones: $('#Detalle_Aseguramiento_Armas_InvolucradasObservaciones').val()

    }

    Detalle_Aseguramiento_Armas_InvolucradasTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Armas_InvolucradasrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Armas_Involucradas-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Armas_Involucradas-form').modal('hide');
    Detalle_Aseguramiento_Armas_InvolucradasEditRow(rowIndex);
    Detalle_Aseguramiento_Armas_InvolucradasInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_Armas_InvolucradasRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_Armas_InvolucradasTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Armas_Involucradas MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Artefactos_y_Explosivos MultiRow
var Detalle_Aseguramiento_Artefactos_y_ExplosivoscountRowsChecked = 0;

function GetDetalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Artefactos_y_Explosivos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoItems.length; i++) {
        if (Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoDropDown() {
    var Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Artefactos_y_Explosivos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoDropdown);
    if(Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoItems[i].Clave, text:    Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoDropdown);
       }
    }
    return Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoDropdown;
}





function GetInsertDetalle_Aseguramiento_Artefactos_y_ExplosivosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Artefactos_y_Explosivos_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Artefactos_y_Explosivos', 'Motivo_de_Registro', 'Motivo_de_Registro', 268341)));
    columnData[1] = $(GetDetalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_de_Artefacto_y_ExplosivoDropDown()).addClass('Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion Clasificacion').attr('id', 'Detalle_Aseguramiento_Artefactos_y_Explosivos_Clasificacion_' + index).attr('data-field', 'Clasificacion').after($.parseHTML(addNew('Detalle_Aseguramiento_Artefactos_y_Explosivos', 'Clasificacion_de_Artefacto_y_Explosivo', 'Clasificacion', 267544)));
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_Artefactos_y_Explosivos_Cantidad Cantidad').attr('id', 'Detalle_Aseguramiento_Artefactos_y_Explosivos_Cantidad_' + index).attr('data-field', 'Cantidad');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Artefactos_y_Explosivos_Lugar_de_Hallazgo Lugar_de_Hallazgo').attr('id', 'Detalle_Aseguramiento_Artefactos_y_Explosivos_Lugar_de_Hallazgo_' + index).attr('data-field', 'Lugar_de_Hallazgo');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Artefactos_y_Explosivos_Observaciones Observaciones').attr('id', 'Detalle_Aseguramiento_Artefactos_y_Explosivos_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_Artefactos_y_ExplosivosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Artefactos_y_Explosivos("Detalle_Aseguramiento_Artefactos_y_Explosivos_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Artefactos_y_Explosivos';
    var prevData = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Clasificacion:  data.childNodes[counter++].childNodes[0].value
        ,Cantidad: data.childNodes[counter++].childNodes[0].value
        ,Lugar_de_Hallazgo:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Artefactos_y_ExplosivosrowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnPageChange(iPage);
    Detalle_Aseguramiento_Artefactos_y_ExplosivoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Artefactos_y_Explosivos("Detalle_Aseguramiento_Artefactos_y_Explosivos_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_Artefactos_y_ExplosivosCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_Artefactos_y_ExplosivosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_Artefactos_y_ExplosivosGrid(Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetData());
    Detalle_Aseguramiento_Artefactos_y_ExplosivoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_Artefactos_y_ExplosivosFromDataTable() {
    var Detalle_Aseguramiento_Artefactos_y_ExplosivosData = [];
    var gridData = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_Artefactos_y_ExplosivosData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Clasificacion: gridData[i].Clasificacion
                ,Cantidad: gridData[i].Cantidad
                ,Lugar_de_Hallazgo: gridData[i].Lugar_de_Hallazgo
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_Artefactos_y_ExplosivosData.length; i++) {
        if (removedDetalle_Aseguramiento_Artefactos_y_ExplosivosData[i] != null && removedDetalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Clave > 0)
            Detalle_Aseguramiento_Artefactos_y_ExplosivosData.push({
                Clave: removedDetalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Motivo_de_Registro
                ,Clasificacion: removedDetalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Clasificacion
                ,Cantidad: removedDetalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Cantidad
                ,Lugar_de_Hallazgo: removedDetalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Lugar_de_Hallazgo
                ,Observaciones: removedDetalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Observaciones

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_Artefactos_y_ExplosivosData;
}

function Detalle_Aseguramiento_Artefactos_y_ExplosivosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_Artefactos_y_ExplosivoscountRowsChecked++;
    var Detalle_Aseguramiento_Artefactos_y_ExplosivosRowElement = "Detalle_Aseguramiento_Artefactos_y_Explosivos_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Artefactos_y_Explosivos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_Artefactos_y_ExplosivosGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Artefactos_y_Explosivos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_Artefactos_y_ExplosivosRowElement + "')){ Detalle_Aseguramiento_Artefactos_y_ExplosivosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_Artefactos_y_ExplosivosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_Artefactos_y_ExplosivosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_Artefactos_y_ExplosivosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_Artefactos_y_ExplosivosValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Artefactos_y_Explosivos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Artefactos_y_Explosivos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_Artefactos_y_ExplosivosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetData().length;
    Detalle_Aseguramiento_Artefactos_y_ExplosivosfnClickAddRow();
    GetAddDetalle_Aseguramiento_Artefactos_y_ExplosivosPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_Artefactos_y_ExplosivosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_Artefactos_y_ExplosivosRowElement = "Detalle_Aseguramiento_Artefactos_y_Explosivos_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_Artefactos_y_ExplosivosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosClasificacion').val(prevData.Clasificacion);
    $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosCantidad').val(prevData.Cantidad);
    $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosLugar_de_Hallazgo').val(prevData.Lugar_de_Hallazgo);
    $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosObservaciones').val(prevData.Observaciones);

    initiateUIControls();







}

function Detalle_Aseguramiento_Artefactos_y_ExplosivosAddInsertRow() {
    if (Detalle_Aseguramiento_Artefactos_y_ExplosivosinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_Artefactos_y_ExplosivosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Clasificacion: ""
        ,Cantidad: ""
        ,Lugar_de_Hallazgo: ""
        ,Observaciones: ""

    }
}

function Detalle_Aseguramiento_Artefactos_y_ExplosivosfnClickAddRow() {
    Detalle_Aseguramiento_Artefactos_y_ExplosivoscountRowsChecked++;
    Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnAddData(Detalle_Aseguramiento_Artefactos_y_ExplosivosAddInsertRow(), true);
    Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_Artefactos_y_ExplosivosGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_Artefactos_y_ExplosivosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Artefactos_y_Explosivos("Detalle_Aseguramiento_Artefactos_y_Explosivos_", "_" + Detalle_Aseguramiento_Artefactos_y_ExplosivosinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_Artefactos_y_ExplosivosClearGridData() {
    Detalle_Aseguramiento_Artefactos_y_ExplosivosData = [];
    Detalle_Aseguramiento_Artefactos_y_ExplosivosdeletedItem = [];
    Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMain = [];
    Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMainPages = [];
    Detalle_Aseguramiento_Artefactos_y_ExplosivosnewItemCount = 0;
    Detalle_Aseguramiento_Artefactos_y_ExplosivosmaxItemIndex = 0;
    $("#Detalle_Aseguramiento_Artefactos_y_ExplosivosGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_Artefactos_y_ExplosivosGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Artefactos_y_Explosivos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_Artefactos_y_ExplosivosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Clasificacion', Detalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Clasificacion);
        form_data.append('[' + i + '].Cantidad', Detalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Cantidad);
        form_data.append('[' + i + '].Lugar_de_Hallazgo', Detalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Lugar_de_Hallazgo);
        form_data.append('[' + i + '].Observaciones', Detalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_Artefactos_y_ExplosivosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Artefactos_y_Explosivos("Detalle_Aseguramiento_Artefactos_y_ExplosivosTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosMotivo_de_Registro').val()
        ,Clasificacion: $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosClasificacion').val()
        ,Cantidad: $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosCantidad').val()
        ,Lugar_de_Hallazgo: $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosLugar_de_Hallazgo').val()
        ,Observaciones: $('#Detalle_Aseguramiento_Artefactos_y_ExplosivosObservaciones').val()

    }

    Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Artefactos_y_ExplosivosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Artefactos_y_Explosivos-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Artefactos_y_Explosivos-form').modal('hide');
    Detalle_Aseguramiento_Artefactos_y_ExplosivosEditRow(rowIndex);
    Detalle_Aseguramiento_Artefactos_y_ExplosivosInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_Artefactos_y_ExplosivosRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_Artefactos_y_ExplosivosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Artefactos_y_Explosivos MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_de_Cargador_Cartuchos MultiRow
var Detalle_Aseguramiento_de_Cargador_CartuchoscountRowsChecked = 0;

function GetDetalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaItems.length; i++) {
        if (Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaDropDown() {
    var Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Cargador_Cartuchos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaDropdown);
    if(Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaItems[i].Clave, text:    Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaDropdown;
}
function GetDetalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Cargador_Cartuchos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroDropdown;
}






function GetInsertDetalle_Aseguramiento_de_Cargador_CartuchosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_de_ArmaDropDown()).addClass('Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre Calibre').attr('id', 'Detalle_Aseguramiento_de_Cargador_Cartuchos_Calibre_' + index).attr('data-field', 'Calibre').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Cargador_Cartuchos', 'Calibre_de_Arma', 'Calibre', 268366)));
    columnData[1] = $(GetDetalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_de_Cargador_Cartuchos_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Cargador_Cartuchos', 'Motivo_de_Registro', 'Motivo_de_Registro', 268337)));
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_de_Cargador_Cartuchos_cartuchos_municiones cartuchos_municiones').attr('id', 'Detalle_Aseguramiento_de_Cargador_Cartuchos_cartuchos_municiones_' + index).attr('data-field', 'cartuchos_municiones');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Cargador_Cartuchos_Cartuchos_Habiles Cartuchos_Habiles').attr('id', 'Detalle_Aseguramiento_de_Cargador_Cartuchos_Cartuchos_Habiles_' + index).attr('data-field', 'Cartuchos_Habiles');
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_de_Cargador_Cartuchos_Cartuchos_Percutidos Cartuchos_Percutidos').attr('id', 'Detalle_Aseguramiento_de_Cargador_Cartuchos_Cartuchos_Percutidos_' + index).attr('data-field', 'Cartuchos_Percutidos');
    columnData[5] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_de_Cargador_Cartuchos_cargadores cargadores').attr('id', 'Detalle_Aseguramiento_de_Cargador_Cartuchos_cargadores_' + index).attr('data-field', 'cargadores');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_de_Cargador_CartuchosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Cargador_Cartuchos("Detalle_Aseguramiento_de_Cargador_Cartuchos_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_de_Cargador_Cartuchos';
    var prevData = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Calibre:  data.childNodes[counter++].childNodes[0].value
        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,cartuchos_municiones: data.childNodes[counter++].childNodes[0].value
        ,Cartuchos_Habiles:  data.childNodes[counter++].childNodes[0].value
        ,Cartuchos_Percutidos: data.childNodes[counter++].childNodes[0].value
        ,cargadores: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_de_Cargador_CartuchosrowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnPageChange(iPage);
    Detalle_Aseguramiento_de_Cargador_CartuchoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_de_Cargador_Cartuchos("Detalle_Aseguramiento_de_Cargador_Cartuchos_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_de_Cargador_CartuchosCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_de_Cargador_CartuchosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_de_Cargador_CartuchosGrid(Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetData());
    Detalle_Aseguramiento_de_Cargador_CartuchoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_de_Cargador_CartuchosFromDataTable() {
    var Detalle_Aseguramiento_de_Cargador_CartuchosData = [];
    var gridData = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_de_Cargador_CartuchosData.push({
                Clave: gridData[i].Clave

                ,Calibre: gridData[i].Calibre
                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,cartuchos_municiones: gridData[i].cartuchos_municiones
                ,Cartuchos_Habiles: gridData[i].Cartuchos_Habiles
                ,Cartuchos_Percutidos: gridData[i].Cartuchos_Percutidos
                ,cargadores: gridData[i].cargadores

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_de_Cargador_CartuchosData.length; i++) {
        if (removedDetalle_Aseguramiento_de_Cargador_CartuchosData[i] != null && removedDetalle_Aseguramiento_de_Cargador_CartuchosData[i].Clave > 0)
            Detalle_Aseguramiento_de_Cargador_CartuchosData.push({
                Clave: removedDetalle_Aseguramiento_de_Cargador_CartuchosData[i].Clave

                ,Calibre: removedDetalle_Aseguramiento_de_Cargador_CartuchosData[i].Calibre
                ,Motivo_de_Registro: removedDetalle_Aseguramiento_de_Cargador_CartuchosData[i].Motivo_de_Registro
                ,cartuchos_municiones: removedDetalle_Aseguramiento_de_Cargador_CartuchosData[i].cartuchos_municiones
                ,Cartuchos_Habiles: removedDetalle_Aseguramiento_de_Cargador_CartuchosData[i].Cartuchos_Habiles
                ,Cartuchos_Percutidos: removedDetalle_Aseguramiento_de_Cargador_CartuchosData[i].Cartuchos_Percutidos
                ,cargadores: removedDetalle_Aseguramiento_de_Cargador_CartuchosData[i].cargadores

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_de_Cargador_CartuchosData;
}

function Detalle_Aseguramiento_de_Cargador_CartuchosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_de_Cargador_CartuchoscountRowsChecked++;
    var Detalle_Aseguramiento_de_Cargador_CartuchosRowElement = "Detalle_Aseguramiento_de_Cargador_Cartuchos_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_de_Cargador_Cartuchos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_de_Cargador_CartuchosGetUpdateRowControls(prevData, "Detalle_Aseguramiento_de_Cargador_Cartuchos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_de_Cargador_CartuchosRowElement + "')){ Detalle_Aseguramiento_de_Cargador_CartuchosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_de_Cargador_CartuchosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_de_Cargador_CartuchosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_de_Cargador_CartuchosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_de_Cargador_CartuchosValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_de_Cargador_Cartuchos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_de_Cargador_Cartuchos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_de_Cargador_CartuchosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetData().length;
    Detalle_Aseguramiento_de_Cargador_CartuchosfnClickAddRow();
    GetAddDetalle_Aseguramiento_de_Cargador_CartuchosPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_de_Cargador_CartuchosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_de_Cargador_CartuchosRowElement = "Detalle_Aseguramiento_de_Cargador_Cartuchos_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_de_Cargador_CartuchosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_de_Cargador_CartuchosCalibre').val(prevData.Calibre);
    $('#Detalle_Aseguramiento_de_Cargador_CartuchosMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_de_Cargador_Cartuchoscartuchos_municiones').val(prevData.cartuchos_municiones);
    $('#Detalle_Aseguramiento_de_Cargador_CartuchosCartuchos_Habiles').val(prevData.Cartuchos_Habiles);
    $('#Detalle_Aseguramiento_de_Cargador_CartuchosCartuchos_Percutidos').val(prevData.Cartuchos_Percutidos);
    $('#Detalle_Aseguramiento_de_Cargador_Cartuchoscargadores').val(prevData.cargadores);

    initiateUIControls();








}

function Detalle_Aseguramiento_de_Cargador_CartuchosAddInsertRow() {
    if (Detalle_Aseguramiento_de_Cargador_CartuchosinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_de_Cargador_CartuchosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Calibre: ""
        ,Motivo_de_Registro: ""
        ,cartuchos_municiones: ""
        ,Cartuchos_Habiles: ""
        ,Cartuchos_Percutidos: ""
        ,cargadores: ""

    }
}

function Detalle_Aseguramiento_de_Cargador_CartuchosfnClickAddRow() {
    Detalle_Aseguramiento_de_Cargador_CartuchoscountRowsChecked++;
    Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnAddData(Detalle_Aseguramiento_de_Cargador_CartuchosAddInsertRow(), true);
    Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_de_Cargador_CartuchosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_de_Cargador_CartuchosGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_de_Cargador_CartuchosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_de_Cargador_Cartuchos("Detalle_Aseguramiento_de_Cargador_Cartuchos_", "_" + Detalle_Aseguramiento_de_Cargador_CartuchosinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_de_Cargador_CartuchosClearGridData() {
    Detalle_Aseguramiento_de_Cargador_CartuchosData = [];
    Detalle_Aseguramiento_de_Cargador_CartuchosdeletedItem = [];
    Detalle_Aseguramiento_de_Cargador_CartuchosDataMain = [];
    Detalle_Aseguramiento_de_Cargador_CartuchosDataMainPages = [];
    Detalle_Aseguramiento_de_Cargador_CartuchosnewItemCount = 0;
    Detalle_Aseguramiento_de_Cargador_CartuchosmaxItemIndex = 0;
    $("#Detalle_Aseguramiento_de_Cargador_CartuchosGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_de_Cargador_CartuchosGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_de_Cargador_Cartuchos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_de_Cargador_CartuchosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_de_Cargador_CartuchosData[i].Clave);

        form_data.append('[' + i + '].Calibre', Detalle_Aseguramiento_de_Cargador_CartuchosData[i].Calibre);
        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_de_Cargador_CartuchosData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].cartuchos_municiones', Detalle_Aseguramiento_de_Cargador_CartuchosData[i].cartuchos_municiones);
        form_data.append('[' + i + '].Cartuchos_Habiles', Detalle_Aseguramiento_de_Cargador_CartuchosData[i].Cartuchos_Habiles);
        form_data.append('[' + i + '].Cartuchos_Percutidos', Detalle_Aseguramiento_de_Cargador_CartuchosData[i].Cartuchos_Percutidos);
        form_data.append('[' + i + '].cargadores', Detalle_Aseguramiento_de_Cargador_CartuchosData[i].cargadores);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_de_Cargador_CartuchosData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_de_Cargador_CartuchosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Cargador_Cartuchos("Detalle_Aseguramiento_de_Cargador_CartuchosTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Calibre: $('#Detalle_Aseguramiento_de_Cargador_CartuchosCalibre').val()
        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_de_Cargador_CartuchosMotivo_de_Registro').val()
        ,cartuchos_municiones: $('#Detalle_Aseguramiento_de_Cargador_Cartuchoscartuchos_municiones').val()

        ,Cartuchos_Habiles: $('#Detalle_Aseguramiento_de_Cargador_CartuchosCartuchos_Habiles').val()
        ,Cartuchos_Percutidos: $('#Detalle_Aseguramiento_de_Cargador_CartuchosCartuchos_Percutidos').val()

        ,cargadores: $('#Detalle_Aseguramiento_de_Cargador_Cartuchoscargadores').val()


    }

    Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_de_Cargador_CartuchosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_de_Cargador_Cartuchos-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_de_Cargador_Cartuchos-form').modal('hide');
    Detalle_Aseguramiento_de_Cargador_CartuchosEditRow(rowIndex);
    Detalle_Aseguramiento_de_Cargador_CartuchosInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_de_Cargador_CartuchosRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_de_Cargador_CartuchosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_de_Cargador_Cartuchos MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Objetos_Asegurados MultiRow
var Detalle_Aseguramiento_Objetos_AseguradoscountRowsChecked = 0;

function GetDetalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Objetos_Asegurados_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroDropdown;
}

function GetDetalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionItems.length; i++) {
        if (Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionDropDown() {
    var Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Objetos_Asegurados_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionDropdown);
    if(Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionItems[i].Clave, text:    Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionDropdown);
       }
    }
    return Detalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionDropdown;
}
function GetDetalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionItems.length; i++) {
        if (Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionDropDown() {
    var Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Objetos_Asegurados_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionDropdown);
    if(Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionItems[i].Clave, text:    Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionDropdown);
       }
    }
    return Detalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionDropdown;
}




function GetInsertDetalle_Aseguramiento_Objetos_AseguradosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Objetos_Asegurados_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Objetos_Asegurados_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Objetos_Asegurados', 'Motivo_de_Registro', 'Motivo_de_Registro', 268338)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Objetos_Asegurados_Numero Numero').attr('id', 'Detalle_Aseguramiento_Objetos_Asegurados_Numero_' + index).attr('data-field', 'Numero');
    columnData[2] = $(GetDetalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionDropDown()).addClass('Detalle_Aseguramiento_Objetos_Asegurados_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_Objetos_Asegurados_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_Objetos_Asegurados', 'Tipo_de_Equipo_de_Comunicacion', 'Tipo', 267577)));
    columnData[3] = $(GetDetalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionDropDown()).addClass('Detalle_Aseguramiento_Objetos_Asegurados_Marca Marca').attr('id', 'Detalle_Aseguramiento_Objetos_Asegurados_Marca_' + index).attr('data-field', 'Marca').after($.parseHTML(addNew('Detalle_Aseguramiento_Objetos_Asegurados', 'Marca_de_Equipo_de_Comunicacion', 'Marca', 267578)));
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Objetos_Asegurados_Serie Serie').attr('id', 'Detalle_Aseguramiento_Objetos_Asegurados_Serie_' + index).attr('data-field', 'Serie');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Objetos_Asegurados_IMEI IMEI').attr('id', 'Detalle_Aseguramiento_Objetos_Asegurados_IMEI_' + index).attr('data-field', 'IMEI');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_Objetos_AseguradosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Objetos_Asegurados("Detalle_Aseguramiento_Objetos_Asegurados_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_Objetos_AseguradosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Objetos_Asegurados';
    var prevData = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Numero:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,Marca:  data.childNodes[counter++].childNodes[0].value
        ,Serie:  data.childNodes[counter++].childNodes[0].value
        ,IMEI:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_Objetos_AseguradosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Objetos_AseguradosrowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_Objetos_AseguradosTable.fnPageChange(iPage);
    Detalle_Aseguramiento_Objetos_AseguradoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Objetos_Asegurados("Detalle_Aseguramiento_Objetos_Asegurados_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_Objetos_AseguradosCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_Objetos_AseguradosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_Objetos_AseguradosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_Objetos_AseguradosGrid(Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetData());
    Detalle_Aseguramiento_Objetos_AseguradoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_Objetos_AseguradosFromDataTable() {
    var Detalle_Aseguramiento_Objetos_AseguradosData = [];
    var gridData = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_Objetos_AseguradosData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Numero: gridData[i].Numero
                ,Tipo: gridData[i].Tipo
                ,Marca: gridData[i].Marca
                ,Serie: gridData[i].Serie
                ,IMEI: gridData[i].IMEI

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_Objetos_AseguradosData.length; i++) {
        if (removedDetalle_Aseguramiento_Objetos_AseguradosData[i] != null && removedDetalle_Aseguramiento_Objetos_AseguradosData[i].Clave > 0)
            Detalle_Aseguramiento_Objetos_AseguradosData.push({
                Clave: removedDetalle_Aseguramiento_Objetos_AseguradosData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_Objetos_AseguradosData[i].Motivo_de_Registro
                ,Numero: removedDetalle_Aseguramiento_Objetos_AseguradosData[i].Numero
                ,Tipo: removedDetalle_Aseguramiento_Objetos_AseguradosData[i].Tipo
                ,Marca: removedDetalle_Aseguramiento_Objetos_AseguradosData[i].Marca
                ,Serie: removedDetalle_Aseguramiento_Objetos_AseguradosData[i].Serie
                ,IMEI: removedDetalle_Aseguramiento_Objetos_AseguradosData[i].IMEI

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_Objetos_AseguradosData;
}

function Detalle_Aseguramiento_Objetos_AseguradosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_Objetos_AseguradoscountRowsChecked++;
    var Detalle_Aseguramiento_Objetos_AseguradosRowElement = "Detalle_Aseguramiento_Objetos_Asegurados_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Objetos_Asegurados_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_Objetos_AseguradosGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Objetos_Asegurados_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_Objetos_AseguradosRowElement + "')){ Detalle_Aseguramiento_Objetos_AseguradosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_Objetos_AseguradosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_Objetos_AseguradosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_Objetos_AseguradosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_Objetos_AseguradosValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Objetos_Asegurados' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Objetos_Asegurados(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_Objetos_AseguradosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetData().length;
    Detalle_Aseguramiento_Objetos_AseguradosfnClickAddRow();
    GetAddDetalle_Aseguramiento_Objetos_AseguradosPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_Objetos_AseguradosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_Objetos_AseguradosRowElement = "Detalle_Aseguramiento_Objetos_Asegurados_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_Objetos_AseguradosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_Objetos_AseguradosMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_Objetos_AseguradosNumero').val(prevData.Numero);
    $('#Detalle_Aseguramiento_Objetos_AseguradosTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_Objetos_AseguradosMarca').val(prevData.Marca);
    $('#Detalle_Aseguramiento_Objetos_AseguradosSerie').val(prevData.Serie);
    $('#Detalle_Aseguramiento_Objetos_AseguradosIMEI').val(prevData.IMEI);

    initiateUIControls();








}

function Detalle_Aseguramiento_Objetos_AseguradosAddInsertRow() {
    if (Detalle_Aseguramiento_Objetos_AseguradosinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_Objetos_AseguradosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Numero: ""
        ,Tipo: ""
        ,Marca: ""
        ,Serie: ""
        ,IMEI: ""

    }
}

function Detalle_Aseguramiento_Objetos_AseguradosfnClickAddRow() {
    Detalle_Aseguramiento_Objetos_AseguradoscountRowsChecked++;
    Detalle_Aseguramiento_Objetos_AseguradosTable.fnAddData(Detalle_Aseguramiento_Objetos_AseguradosAddInsertRow(), true);
    Detalle_Aseguramiento_Objetos_AseguradosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_Objetos_AseguradosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_Objetos_AseguradosGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_Objetos_AseguradosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Objetos_Asegurados("Detalle_Aseguramiento_Objetos_Asegurados_", "_" + Detalle_Aseguramiento_Objetos_AseguradosinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_Objetos_AseguradosClearGridData() {
    Detalle_Aseguramiento_Objetos_AseguradosData = [];
    Detalle_Aseguramiento_Objetos_AseguradosdeletedItem = [];
    Detalle_Aseguramiento_Objetos_AseguradosDataMain = [];
    Detalle_Aseguramiento_Objetos_AseguradosDataMainPages = [];
    Detalle_Aseguramiento_Objetos_AseguradosnewItemCount = 0;
    Detalle_Aseguramiento_Objetos_AseguradosmaxItemIndex = 0;
    $("#Detalle_Aseguramiento_Objetos_AseguradosGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_Objetos_AseguradosGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Objetos_Asegurados() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_Objetos_AseguradosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_Objetos_AseguradosData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_Objetos_AseguradosData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Numero', Detalle_Aseguramiento_Objetos_AseguradosData[i].Numero);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_Objetos_AseguradosData[i].Tipo);
        form_data.append('[' + i + '].Marca', Detalle_Aseguramiento_Objetos_AseguradosData[i].Marca);
        form_data.append('[' + i + '].Serie', Detalle_Aseguramiento_Objetos_AseguradosData[i].Serie);
        form_data.append('[' + i + '].IMEI', Detalle_Aseguramiento_Objetos_AseguradosData[i].IMEI);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_Objetos_AseguradosData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_Objetos_AseguradosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Objetos_Asegurados("Detalle_Aseguramiento_Objetos_AseguradosTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Objetos_AseguradosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_Objetos_AseguradosMotivo_de_Registro').val()
        ,Numero: $('#Detalle_Aseguramiento_Objetos_AseguradosNumero').val()
        ,Tipo: $('#Detalle_Aseguramiento_Objetos_AseguradosTipo').val()
        ,Marca: $('#Detalle_Aseguramiento_Objetos_AseguradosMarca').val()
        ,Serie: $('#Detalle_Aseguramiento_Objetos_AseguradosSerie').val()
        ,IMEI: $('#Detalle_Aseguramiento_Objetos_AseguradosIMEI').val()

    }

    Detalle_Aseguramiento_Objetos_AseguradosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Objetos_AseguradosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Objetos_Asegurados-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Objetos_Asegurados-form').modal('hide');
    Detalle_Aseguramiento_Objetos_AseguradosEditRow(rowIndex);
    Detalle_Aseguramiento_Objetos_AseguradosInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_Objetos_AseguradosRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_Objetos_AseguradosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Objetos_Asegurados MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Documentos MultiRow
var Detalle_Aseguramiento_DocumentoscountRowsChecked = 0;

function GetDetalle_Aseguramiento_Documentos_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Documentos_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Documentos_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Documentos_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Documentos_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Documentos_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Documentos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Documentos_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Documentos_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Documentos_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Documentos_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Documentos_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Documentos_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Documentos_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_Documentos_Tipo_de_DocumentosName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosItems.length; i++) {
        if (Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Documentos_Tipo_de_DocumentosDropDown() {
    var Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Documentos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosDropdown);
    if(Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosItems[i].Clave, text:    Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosDropdown);
       }
    }
    return Detalle_Aseguramiento_Documentos_Tipo_de_DocumentosDropdown;
}





function GetInsertDetalle_Aseguramiento_DocumentosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Documentos_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Documentos_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Documentos_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Documentos', 'Motivo_de_Registro', 'Motivo_de_Registro', 268339)));
    columnData[1] = $(GetDetalle_Aseguramiento_Documentos_Tipo_de_DocumentosDropDown()).addClass('Detalle_Aseguramiento_Documentos_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_Documentos_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_Documentos', 'Tipo_de_Documentos', 'Tipo', 267645)));
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_Documentos_Cantidad Cantidad').attr('id', 'Detalle_Aseguramiento_Documentos_Cantidad_' + index).attr('data-field', 'Cantidad');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Documentos_Observaciones Observaciones').attr('id', 'Detalle_Aseguramiento_Documentos_Observaciones_' + index).attr('data-field', 'Observaciones');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Documentos_Descipcion_de_Documento Descipcion_de_Documento').attr('id', 'Detalle_Aseguramiento_Documentos_Descipcion_de_Documento_' + index).attr('data-field', 'Descipcion_de_Documento');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_DocumentosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Documentos("Detalle_Aseguramiento_Documentos_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_DocumentosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Documentos';
    var prevData = Detalle_Aseguramiento_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_DocumentosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,Cantidad: data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value
        ,Descipcion_de_Documento:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_DocumentosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_DocumentosrowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_DocumentosTable.fnPageChange(iPage);
    Detalle_Aseguramiento_DocumentoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Documentos("Detalle_Aseguramiento_Documentos_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_DocumentosCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_DocumentosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_DocumentosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_DocumentosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_DocumentosGrid(Detalle_Aseguramiento_DocumentosTable.fnGetData());
    Detalle_Aseguramiento_DocumentoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_DocumentosFromDataTable() {
    var Detalle_Aseguramiento_DocumentosData = [];
    var gridData = Detalle_Aseguramiento_DocumentosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_DocumentosData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Tipo: gridData[i].Tipo
                ,Cantidad: gridData[i].Cantidad
                ,Observaciones: gridData[i].Observaciones
                ,Descipcion_de_Documento: gridData[i].Descipcion_de_Documento

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_DocumentosData.length; i++) {
        if (removedDetalle_Aseguramiento_DocumentosData[i] != null && removedDetalle_Aseguramiento_DocumentosData[i].Clave > 0)
            Detalle_Aseguramiento_DocumentosData.push({
                Clave: removedDetalle_Aseguramiento_DocumentosData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_DocumentosData[i].Motivo_de_Registro
                ,Tipo: removedDetalle_Aseguramiento_DocumentosData[i].Tipo
                ,Cantidad: removedDetalle_Aseguramiento_DocumentosData[i].Cantidad
                ,Observaciones: removedDetalle_Aseguramiento_DocumentosData[i].Observaciones
                ,Descipcion_de_Documento: removedDetalle_Aseguramiento_DocumentosData[i].Descipcion_de_Documento

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_DocumentosData;
}

function Detalle_Aseguramiento_DocumentosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_DocumentosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_DocumentoscountRowsChecked++;
    var Detalle_Aseguramiento_DocumentosRowElement = "Detalle_Aseguramiento_Documentos_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_DocumentosTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_DocumentosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Documentos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_DocumentosGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Documentos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_DocumentosRowElement + "')){ Detalle_Aseguramiento_DocumentosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_DocumentosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_DocumentosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_DocumentosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_DocumentosValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Documentos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Documentos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_DocumentosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_DocumentosTable.fnGetData().length;
    Detalle_Aseguramiento_DocumentosfnClickAddRow();
    GetAddDetalle_Aseguramiento_DocumentosPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_DocumentosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_DocumentosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_DocumentosRowElement = "Detalle_Aseguramiento_Documentos_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_DocumentosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_DocumentosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_DocumentosMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_DocumentosTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_DocumentosCantidad').val(prevData.Cantidad);
    $('#Detalle_Aseguramiento_DocumentosObservaciones').val(prevData.Observaciones);
    $('#Detalle_Aseguramiento_DocumentosDescipcion_de_Documento').val(prevData.Descipcion_de_Documento);

    initiateUIControls();







}

function Detalle_Aseguramiento_DocumentosAddInsertRow() {
    if (Detalle_Aseguramiento_DocumentosinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_DocumentosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Tipo: ""
        ,Cantidad: ""
        ,Observaciones: ""
        ,Descipcion_de_Documento: ""

    }
}

function Detalle_Aseguramiento_DocumentosfnClickAddRow() {
    Detalle_Aseguramiento_DocumentoscountRowsChecked++;
    Detalle_Aseguramiento_DocumentosTable.fnAddData(Detalle_Aseguramiento_DocumentosAddInsertRow(), true);
    Detalle_Aseguramiento_DocumentosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_DocumentosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_DocumentosGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_DocumentosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Documentos("Detalle_Aseguramiento_Documentos_", "_" + Detalle_Aseguramiento_DocumentosinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_DocumentosClearGridData() {
    Detalle_Aseguramiento_DocumentosData = [];
    Detalle_Aseguramiento_DocumentosdeletedItem = [];
    Detalle_Aseguramiento_DocumentosDataMain = [];
    Detalle_Aseguramiento_DocumentosDataMainPages = [];
    Detalle_Aseguramiento_DocumentosnewItemCount = 0;
    Detalle_Aseguramiento_DocumentosmaxItemIndex = 0;
    $("#Detalle_Aseguramiento_DocumentosGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_DocumentosGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Documentos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_DocumentosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_DocumentosData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_DocumentosData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_DocumentosData[i].Tipo);
        form_data.append('[' + i + '].Cantidad', Detalle_Aseguramiento_DocumentosData[i].Cantidad);
        form_data.append('[' + i + '].Observaciones', Detalle_Aseguramiento_DocumentosData[i].Observaciones);
        form_data.append('[' + i + '].Descipcion_de_Documento', Detalle_Aseguramiento_DocumentosData[i].Descipcion_de_Documento);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_DocumentosData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_DocumentosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Documentos("Detalle_Aseguramiento_DocumentosTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_DocumentosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_DocumentosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_DocumentosMotivo_de_Registro').val()
        ,Tipo: $('#Detalle_Aseguramiento_DocumentosTipo').val()
        ,Cantidad: $('#Detalle_Aseguramiento_DocumentosCantidad').val()
        ,Observaciones: $('#Detalle_Aseguramiento_DocumentosObservaciones').val()
        ,Descipcion_de_Documento: $('#Detalle_Aseguramiento_DocumentosDescipcion_de_Documento').val()

    }

    Detalle_Aseguramiento_DocumentosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_DocumentosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Documentos-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Documentos-form').modal('hide');
    Detalle_Aseguramiento_DocumentosEditRow(rowIndex);
    Detalle_Aseguramiento_DocumentosInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_DocumentosRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_DocumentosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Documentos MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Moneda MultiRow
var Detalle_Aseguramiento_MonedacountRowsChecked = 0;

function GetDetalle_Aseguramiento_Moneda_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Moneda_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Moneda_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Moneda_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Moneda_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Moneda_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Moneda_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Moneda_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Moneda_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Moneda_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Moneda_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Moneda_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Moneda_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Moneda_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_Moneda_Tipo_de_MonedaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Moneda_Tipo_de_MonedaItems.length; i++) {
        if (Detalle_Aseguramiento_Moneda_Tipo_de_MonedaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Moneda_Tipo_de_MonedaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Moneda_Tipo_de_MonedaDropDown() {
    var Detalle_Aseguramiento_Moneda_Tipo_de_MonedaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Moneda_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Moneda_Tipo_de_MonedaDropdown);
    if(Detalle_Aseguramiento_Moneda_Tipo_de_MonedaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Moneda_Tipo_de_MonedaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Moneda_Tipo_de_MonedaItems[i].Clave, text:    Detalle_Aseguramiento_Moneda_Tipo_de_MonedaItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Moneda_Tipo_de_MonedaDropdown);
       }
    }
    return Detalle_Aseguramiento_Moneda_Tipo_de_MonedaDropdown;
}


function GetDetalle_Aseguramiento_Moneda_Tipo_de_DineroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Moneda_Tipo_de_DineroItems.length; i++) {
        if (Detalle_Aseguramiento_Moneda_Tipo_de_DineroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Moneda_Tipo_de_DineroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Moneda_Tipo_de_DineroDropDown() {
    var Detalle_Aseguramiento_Moneda_Tipo_de_DineroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Moneda_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Moneda_Tipo_de_DineroDropdown);
    if(Detalle_Aseguramiento_Moneda_Tipo_de_DineroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Moneda_Tipo_de_DineroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Moneda_Tipo_de_DineroItems[i].Clave, text:    Detalle_Aseguramiento_Moneda_Tipo_de_DineroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Moneda_Tipo_de_DineroDropdown);
       }
    }
    return Detalle_Aseguramiento_Moneda_Tipo_de_DineroDropdown;
}


function GetInsertDetalle_Aseguramiento_MonedaRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Moneda_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Moneda_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Moneda_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Moneda', 'Motivo_de_Registro', 'Motivo_de_Registro', 268340)));
    columnData[1] = $(GetDetalle_Aseguramiento_Moneda_Tipo_de_MonedaDropDown()).addClass('Detalle_Aseguramiento_Moneda_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_Moneda_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_Moneda', 'Tipo_de_Moneda', 'Tipo', 267570)));
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_Moneda_Cantidad Cantidad').attr('id', 'Detalle_Aseguramiento_Moneda_Cantidad_' + index).attr('data-field', 'Cantidad');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Moneda_Observaciones Observaciones').attr('id', 'Detalle_Aseguramiento_Moneda_Observaciones_' + index).attr('data-field', 'Observaciones');
    columnData[4] = $(GetDetalle_Aseguramiento_Moneda_Tipo_de_DineroDropDown()).addClass('Detalle_Aseguramiento_Moneda_Descripcion Descripcion').attr('id', 'Detalle_Aseguramiento_Moneda_Descripcion_' + index).attr('data-field', 'Descripcion').after($.parseHTML(addNew('Detalle_Aseguramiento_Moneda', 'Tipo_de_Dinero', 'Descripcion', 267573)));


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_MonedaInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Moneda("Detalle_Aseguramiento_Moneda_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_MonedaTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Moneda';
    var prevData = Detalle_Aseguramiento_MonedaTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_MonedaTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,Cantidad: data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_MonedaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_MonedarowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_MonedaTable.fnPageChange(iPage);
    Detalle_Aseguramiento_MonedacountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Moneda("Detalle_Aseguramiento_Moneda_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_MonedaCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_MonedaTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_MonedaTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_MonedaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_MonedarowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_MonedaGrid(Detalle_Aseguramiento_MonedaTable.fnGetData());
    Detalle_Aseguramiento_MonedacountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_MonedaFromDataTable() {
    var Detalle_Aseguramiento_MonedaData = [];
    var gridData = Detalle_Aseguramiento_MonedaTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_MonedaData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Tipo: gridData[i].Tipo
                ,Cantidad: gridData[i].Cantidad
                ,Observaciones: gridData[i].Observaciones
                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_MonedaData.length; i++) {
        if (removedDetalle_Aseguramiento_MonedaData[i] != null && removedDetalle_Aseguramiento_MonedaData[i].Clave > 0)
            Detalle_Aseguramiento_MonedaData.push({
                Clave: removedDetalle_Aseguramiento_MonedaData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_MonedaData[i].Motivo_de_Registro
                ,Tipo: removedDetalle_Aseguramiento_MonedaData[i].Tipo
                ,Cantidad: removedDetalle_Aseguramiento_MonedaData[i].Cantidad
                ,Observaciones: removedDetalle_Aseguramiento_MonedaData[i].Observaciones
                ,Descripcion: removedDetalle_Aseguramiento_MonedaData[i].Descripcion

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_MonedaData;
}

function Detalle_Aseguramiento_MonedaEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_MonedaTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_MonedacountRowsChecked++;
    var Detalle_Aseguramiento_MonedaRowElement = "Detalle_Aseguramiento_Moneda_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_MonedaTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_MonedaTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Moneda_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_MonedaGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Moneda_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_MonedaRowElement + "')){ Detalle_Aseguramiento_MonedaInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_MonedaCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_MonedaGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_MonedaGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_MonedaValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Moneda' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Moneda(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_MonedafnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_MonedaTable.fnGetData().length;
    Detalle_Aseguramiento_MonedafnClickAddRow();
    GetAddDetalle_Aseguramiento_MonedaPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_MonedaEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_MonedaTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_MonedaRowElement = "Detalle_Aseguramiento_Moneda_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_MonedaTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_MonedaPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_MonedaMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_MonedaTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_MonedaCantidad').val(prevData.Cantidad);
    $('#Detalle_Aseguramiento_MonedaObservaciones').val(prevData.Observaciones);
    $('#Detalle_Aseguramiento_MonedaDescripcion').val(prevData.Descripcion);

    initiateUIControls();







}

function Detalle_Aseguramiento_MonedaAddInsertRow() {
    if (Detalle_Aseguramiento_MonedainsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_MonedainsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Tipo: ""
        ,Cantidad: ""
        ,Observaciones: ""
        ,Descripcion: ""

    }
}

function Detalle_Aseguramiento_MonedafnClickAddRow() {
    Detalle_Aseguramiento_MonedacountRowsChecked++;
    Detalle_Aseguramiento_MonedaTable.fnAddData(Detalle_Aseguramiento_MonedaAddInsertRow(), true);
    Detalle_Aseguramiento_MonedaTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_MonedaGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_MonedaGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_MonedainsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Moneda("Detalle_Aseguramiento_Moneda_", "_" + Detalle_Aseguramiento_MonedainsertRowCurrentIndex);
}

function Detalle_Aseguramiento_MonedaClearGridData() {
    Detalle_Aseguramiento_MonedaData = [];
    Detalle_Aseguramiento_MonedadeletedItem = [];
    Detalle_Aseguramiento_MonedaDataMain = [];
    Detalle_Aseguramiento_MonedaDataMainPages = [];
    Detalle_Aseguramiento_MonedanewItemCount = 0;
    Detalle_Aseguramiento_MonedamaxItemIndex = 0;
    $("#Detalle_Aseguramiento_MonedaGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_MonedaGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Moneda() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_MonedaData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_MonedaData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_MonedaData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_MonedaData[i].Tipo);
        form_data.append('[' + i + '].Cantidad', Detalle_Aseguramiento_MonedaData[i].Cantidad);
        form_data.append('[' + i + '].Observaciones', Detalle_Aseguramiento_MonedaData[i].Observaciones);
        form_data.append('[' + i + '].Descripcion', Detalle_Aseguramiento_MonedaData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_MonedaData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_MonedaInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Moneda("Detalle_Aseguramiento_MonedaTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_MonedaTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_MonedaTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_MonedaMotivo_de_Registro').val()
        ,Tipo: $('#Detalle_Aseguramiento_MonedaTipo').val()
        ,Cantidad: $('#Detalle_Aseguramiento_MonedaCantidad').val()
        ,Observaciones: $('#Detalle_Aseguramiento_MonedaObservaciones').val()
        ,Descripcion: $('#Detalle_Aseguramiento_MonedaDescripcion').val()

    }

    Detalle_Aseguramiento_MonedaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_MonedarowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Moneda-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Moneda-form').modal('hide');
    Detalle_Aseguramiento_MonedaEditRow(rowIndex);
    Detalle_Aseguramiento_MonedaInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_MonedaRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_MonedaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Moneda MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Otros_Aseguramientos MultiRow
var Detalle_Aseguramiento_Otros_AseguramientoscountRowsChecked = 0;

function GetDetalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoItems.length; i++) {
        if (Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoDropDown() {
    var Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Otros_Aseguramientos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoDropdown);
    if(Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoItems[i].Clave, text:    Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoDropdown);
       }
    }
    return Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoDropdown;
}
function GetDetalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Otros_Aseguramientos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroDropdown;
}




function GetDetalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoItems.length; i++) {
        if (Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoDropDown() {
    var Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Otros_Aseguramientos_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoDropdown);
    if(Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoItems[i].Clave, text:    Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoDropdown);
       }
    }
    return Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoDropdown;
}




function GetInsertDetalle_Aseguramiento_Otros_AseguramientosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoDropDown()).addClass('Detalle_Aseguramiento_Otros_Aseguramientos_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_Otros_Aseguramientos_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_Otros_Aseguramientos', 'Tipo_de_Equipo_Tactico', 'Tipo', 267589)));
    columnData[1] = $(GetDetalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Otros_Aseguramientos_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Otros_Aseguramientos', 'Motivo_de_Registro', 'Motivo_de_Registro', 268343)));
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Otros_Aseguramientos_Marca Marca').attr('id', 'Detalle_Aseguramiento_Otros_Aseguramientos_Marca_' + index).attr('data-field', 'Marca');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Otros_Aseguramientos_Modelo Modelo').attr('id', 'Detalle_Aseguramiento_Otros_Aseguramientos_Modelo_' + index).attr('data-field', 'Modelo');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Otros_Aseguramientos_Inventario Inventario').attr('id', 'Detalle_Aseguramiento_Otros_Aseguramientos_Inventario_' + index).attr('data-field', 'Inventario');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Otros_Aseguramientos_Serie Serie').attr('id', 'Detalle_Aseguramiento_Otros_Aseguramientos_Serie_' + index).attr('data-field', 'Serie');
    columnData[6] = $(GetDetalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoDropDown()).addClass('Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida Unidad_de_Medida').attr('id', 'Detalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_' + index).attr('data-field', 'Unidad_de_Medida').after($.parseHTML(addNew('Detalle_Aseguramiento_Otros_Aseguramientos', 'Unidad_de_Medida_de_Equipo_Tactico', 'Unidad_de_Medida', 267594)));
    columnData[7] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_Otros_Aseguramientos_Cantidad Cantidad').attr('id', 'Detalle_Aseguramiento_Otros_Aseguramientos_Cantidad_' + index).attr('data-field', 'Cantidad');
    columnData[8] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Otros_Aseguramientos_Observaciones Observaciones').attr('id', 'Detalle_Aseguramiento_Otros_Aseguramientos_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_Otros_AseguramientosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Otros_Aseguramientos("Detalle_Aseguramiento_Otros_Aseguramientos_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_Otros_AseguramientosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Otros_Aseguramientos';
    var prevData = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Marca:  data.childNodes[counter++].childNodes[0].value
        ,Modelo:  data.childNodes[counter++].childNodes[0].value
        ,Inventario:  data.childNodes[counter++].childNodes[0].value
        ,Serie:  data.childNodes[counter++].childNodes[0].value
        ,Unidad_de_Medida:  data.childNodes[counter++].childNodes[0].value
        ,Cantidad: data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_Otros_AseguramientosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Otros_AseguramientosrowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_Otros_AseguramientosTable.fnPageChange(iPage);
    Detalle_Aseguramiento_Otros_AseguramientoscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Otros_Aseguramientos("Detalle_Aseguramiento_Otros_Aseguramientos_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_Otros_AseguramientosCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_Otros_AseguramientosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_Otros_AseguramientosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_Otros_AseguramientosGrid(Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetData());
    Detalle_Aseguramiento_Otros_AseguramientoscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_Otros_AseguramientosFromDataTable() {
    var Detalle_Aseguramiento_Otros_AseguramientosData = [];
    var gridData = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_Otros_AseguramientosData.push({
                Clave: gridData[i].Clave

                ,Tipo: gridData[i].Tipo
                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Marca: gridData[i].Marca
                ,Modelo: gridData[i].Modelo
                ,Inventario: gridData[i].Inventario
                ,Serie: gridData[i].Serie
                ,Unidad_de_Medida: gridData[i].Unidad_de_Medida
                ,Cantidad: gridData[i].Cantidad
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_Otros_AseguramientosData.length; i++) {
        if (removedDetalle_Aseguramiento_Otros_AseguramientosData[i] != null && removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Clave > 0)
            Detalle_Aseguramiento_Otros_AseguramientosData.push({
                Clave: removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Clave

                ,Tipo: removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Tipo
                ,Motivo_de_Registro: removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Motivo_de_Registro
                ,Marca: removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Marca
                ,Modelo: removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Modelo
                ,Inventario: removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Inventario
                ,Serie: removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Serie
                ,Unidad_de_Medida: removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Unidad_de_Medida
                ,Cantidad: removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Cantidad
                ,Observaciones: removedDetalle_Aseguramiento_Otros_AseguramientosData[i].Observaciones

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_Otros_AseguramientosData;
}

function Detalle_Aseguramiento_Otros_AseguramientosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_Otros_AseguramientoscountRowsChecked++;
    var Detalle_Aseguramiento_Otros_AseguramientosRowElement = "Detalle_Aseguramiento_Otros_Aseguramientos_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Otros_Aseguramientos_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_Otros_AseguramientosGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Otros_Aseguramientos_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_Otros_AseguramientosRowElement + "')){ Detalle_Aseguramiento_Otros_AseguramientosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_Otros_AseguramientosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_Otros_AseguramientosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_Otros_AseguramientosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_Otros_AseguramientosValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Otros_Aseguramientos' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Otros_Aseguramientos(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_Otros_AseguramientosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetData().length;
    Detalle_Aseguramiento_Otros_AseguramientosfnClickAddRow();
    GetAddDetalle_Aseguramiento_Otros_AseguramientosPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_Otros_AseguramientosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_Otros_AseguramientosRowElement = "Detalle_Aseguramiento_Otros_Aseguramientos_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_Otros_AseguramientosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_Otros_AseguramientosTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_Otros_AseguramientosMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_Otros_AseguramientosMarca').val(prevData.Marca);
    $('#Detalle_Aseguramiento_Otros_AseguramientosModelo').val(prevData.Modelo);
    $('#Detalle_Aseguramiento_Otros_AseguramientosInventario').val(prevData.Inventario);
    $('#Detalle_Aseguramiento_Otros_AseguramientosSerie').val(prevData.Serie);
    $('#Detalle_Aseguramiento_Otros_AseguramientosUnidad_de_Medida').val(prevData.Unidad_de_Medida);
    $('#Detalle_Aseguramiento_Otros_AseguramientosCantidad').val(prevData.Cantidad);
    $('#Detalle_Aseguramiento_Otros_AseguramientosObservaciones').val(prevData.Observaciones);

    initiateUIControls();











}

function Detalle_Aseguramiento_Otros_AseguramientosAddInsertRow() {
    if (Detalle_Aseguramiento_Otros_AseguramientosinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_Otros_AseguramientosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo: ""
        ,Motivo_de_Registro: ""
        ,Marca: ""
        ,Modelo: ""
        ,Inventario: ""
        ,Serie: ""
        ,Unidad_de_Medida: ""
        ,Cantidad: ""
        ,Observaciones: ""

    }
}

function Detalle_Aseguramiento_Otros_AseguramientosfnClickAddRow() {
    Detalle_Aseguramiento_Otros_AseguramientoscountRowsChecked++;
    Detalle_Aseguramiento_Otros_AseguramientosTable.fnAddData(Detalle_Aseguramiento_Otros_AseguramientosAddInsertRow(), true);
    Detalle_Aseguramiento_Otros_AseguramientosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_Otros_AseguramientosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_Otros_AseguramientosGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_Otros_AseguramientosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Otros_Aseguramientos("Detalle_Aseguramiento_Otros_Aseguramientos_", "_" + Detalle_Aseguramiento_Otros_AseguramientosinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_Otros_AseguramientosClearGridData() {
    Detalle_Aseguramiento_Otros_AseguramientosData = [];
    Detalle_Aseguramiento_Otros_AseguramientosdeletedItem = [];
    Detalle_Aseguramiento_Otros_AseguramientosDataMain = [];
    Detalle_Aseguramiento_Otros_AseguramientosDataMainPages = [];
    Detalle_Aseguramiento_Otros_AseguramientosnewItemCount = 0;
    Detalle_Aseguramiento_Otros_AseguramientosmaxItemIndex = 0;
    $("#Detalle_Aseguramiento_Otros_AseguramientosGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_Otros_AseguramientosGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Otros_Aseguramientos() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_Otros_AseguramientosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_Otros_AseguramientosData[i].Clave);

        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_Otros_AseguramientosData[i].Tipo);
        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_Otros_AseguramientosData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Marca', Detalle_Aseguramiento_Otros_AseguramientosData[i].Marca);
        form_data.append('[' + i + '].Modelo', Detalle_Aseguramiento_Otros_AseguramientosData[i].Modelo);
        form_data.append('[' + i + '].Inventario', Detalle_Aseguramiento_Otros_AseguramientosData[i].Inventario);
        form_data.append('[' + i + '].Serie', Detalle_Aseguramiento_Otros_AseguramientosData[i].Serie);
        form_data.append('[' + i + '].Unidad_de_Medida', Detalle_Aseguramiento_Otros_AseguramientosData[i].Unidad_de_Medida);
        form_data.append('[' + i + '].Cantidad', Detalle_Aseguramiento_Otros_AseguramientosData[i].Cantidad);
        form_data.append('[' + i + '].Observaciones', Detalle_Aseguramiento_Otros_AseguramientosData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_Otros_AseguramientosData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_Otros_AseguramientosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Otros_Aseguramientos("Detalle_Aseguramiento_Otros_AseguramientosTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Otros_AseguramientosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo: $('#Detalle_Aseguramiento_Otros_AseguramientosTipo').val()
        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_Otros_AseguramientosMotivo_de_Registro').val()
        ,Marca: $('#Detalle_Aseguramiento_Otros_AseguramientosMarca').val()
        ,Modelo: $('#Detalle_Aseguramiento_Otros_AseguramientosModelo').val()
        ,Inventario: $('#Detalle_Aseguramiento_Otros_AseguramientosInventario').val()
        ,Serie: $('#Detalle_Aseguramiento_Otros_AseguramientosSerie').val()
        ,Unidad_de_Medida: $('#Detalle_Aseguramiento_Otros_AseguramientosUnidad_de_Medida').val()
        ,Cantidad: $('#Detalle_Aseguramiento_Otros_AseguramientosCantidad').val()
        ,Observaciones: $('#Detalle_Aseguramiento_Otros_AseguramientosObservaciones').val()

    }

    Detalle_Aseguramiento_Otros_AseguramientosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Otros_AseguramientosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Otros_Aseguramientos-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Otros_Aseguramientos-form').modal('hide');
    Detalle_Aseguramiento_Otros_AseguramientosEditRow(rowIndex);
    Detalle_Aseguramiento_Otros_AseguramientosInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_Otros_AseguramientosRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_Otros_AseguramientosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Otros_Aseguramientos MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Electronicos_y_Multimedia MultiRow
var Detalle_Aseguramiento_Electronicos_y_MultimediacountRowsChecked = 0;

function GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Electronicos_y_Multimedia_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaItems.length; i++) {
        if (Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaDropDown() {
    var Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Electronicos_y_Multimedia_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaDropdown);
    if(Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaItems[i].Clave, text:    Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaDropdown);
       }
    }
    return Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaDropdown;
}
function GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaItems.length; i++) {
        if (Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaDropDown() {
    var Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Electronicos_y_Multimedia_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaDropdown);
    if(Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaItems[i].Clave, text:    Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaDropdown);
       }
    }
    return Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaDropdown;
}





function GetInsertDetalle_Aseguramiento_Electronicos_y_MultimediaRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Electronicos_y_Multimedia_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Electronicos_y_Multimedia', 'Motivo_de_Registro', 'Motivo_de_Registro', 268344)));
    columnData[1] = $(GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaDropDown()).addClass('Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparatos Aparatos').attr('id', 'Detalle_Aseguramiento_Electronicos_y_Multimedia_Aparatos_' + index).attr('data-field', 'Aparatos').after($.parseHTML(addNew('Detalle_Aseguramiento_Electronicos_y_Multimedia', 'Aparato_Electronicos_y_Multimedia', 'Aparatos', 267526)));
    columnData[2] = $(GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaDropDown()).addClass('Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_Multimedia Documentos_Multimedia').attr('id', 'Detalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_Multimedia_' + index).attr('data-field', 'Documentos_Multimedia').after($.parseHTML(addNew('Detalle_Aseguramiento_Electronicos_y_Multimedia', 'Documentos_Multimedia', 'Documentos_Multimedia', 267527)));
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Electronicos_y_Multimedia_Descripcion Descripcion').attr('id', 'Detalle_Aseguramiento_Electronicos_y_Multimedia_Descripcion_' + index).attr('data-field', 'Descripcion');
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_Electronicos_y_Multimedia_Cantidad Cantidad').attr('id', 'Detalle_Aseguramiento_Electronicos_y_Multimedia_Cantidad_' + index).attr('data-field', 'Cantidad');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Electronicos_y_Multimedia_A_resguardo A_resguardo').attr('id', 'Detalle_Aseguramiento_Electronicos_y_Multimedia_A_resguardo_' + index).attr('data-field', 'A_resguardo');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_Electronicos_y_MultimediaInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Electronicos_y_Multimedia("Detalle_Aseguramiento_Electronicos_y_Multimedia_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Electronicos_y_Multimedia';
    var prevData = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Aparatos:  data.childNodes[counter++].childNodes[0].value
        ,Documentos_Multimedia:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value
        ,Cantidad: data.childNodes[counter++].childNodes[0].value
        ,A_resguardo:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Electronicos_y_MultimediarowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnPageChange(iPage);
    Detalle_Aseguramiento_Electronicos_y_MultimediacountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Electronicos_y_Multimedia("Detalle_Aseguramiento_Electronicos_y_Multimedia_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_Electronicos_y_MultimediaCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_Electronicos_y_MultimediarowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_Electronicos_y_MultimediaGrid(Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetData());
    Detalle_Aseguramiento_Electronicos_y_MultimediacountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_Electronicos_y_MultimediaFromDataTable() {
    var Detalle_Aseguramiento_Electronicos_y_MultimediaData = [];
    var gridData = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_Electronicos_y_MultimediaData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Aparatos: gridData[i].Aparatos
                ,Documentos_Multimedia: gridData[i].Documentos_Multimedia
                ,Descripcion: gridData[i].Descripcion
                ,Cantidad: gridData[i].Cantidad
                ,A_resguardo: gridData[i].A_resguardo

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_Electronicos_y_MultimediaData.length; i++) {
        if (removedDetalle_Aseguramiento_Electronicos_y_MultimediaData[i] != null && removedDetalle_Aseguramiento_Electronicos_y_MultimediaData[i].Clave > 0)
            Detalle_Aseguramiento_Electronicos_y_MultimediaData.push({
                Clave: removedDetalle_Aseguramiento_Electronicos_y_MultimediaData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_Electronicos_y_MultimediaData[i].Motivo_de_Registro
                ,Aparatos: removedDetalle_Aseguramiento_Electronicos_y_MultimediaData[i].Aparatos
                ,Documentos_Multimedia: removedDetalle_Aseguramiento_Electronicos_y_MultimediaData[i].Documentos_Multimedia
                ,Descripcion: removedDetalle_Aseguramiento_Electronicos_y_MultimediaData[i].Descripcion
                ,Cantidad: removedDetalle_Aseguramiento_Electronicos_y_MultimediaData[i].Cantidad
                ,A_resguardo: removedDetalle_Aseguramiento_Electronicos_y_MultimediaData[i].A_resguardo

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_Electronicos_y_MultimediaData;
}

function Detalle_Aseguramiento_Electronicos_y_MultimediaEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_Electronicos_y_MultimediacountRowsChecked++;
    var Detalle_Aseguramiento_Electronicos_y_MultimediaRowElement = "Detalle_Aseguramiento_Electronicos_y_Multimedia_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Electronicos_y_Multimedia_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_Electronicos_y_MultimediaGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Electronicos_y_Multimedia_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_Electronicos_y_MultimediaRowElement + "')){ Detalle_Aseguramiento_Electronicos_y_MultimediaInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_Electronicos_y_MultimediaCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_Electronicos_y_MultimediaGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_Electronicos_y_MultimediaGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_Electronicos_y_MultimediaValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Electronicos_y_Multimedia' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Electronicos_y_Multimedia(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_Electronicos_y_MultimediafnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetData().length;
    Detalle_Aseguramiento_Electronicos_y_MultimediafnClickAddRow();
    GetAddDetalle_Aseguramiento_Electronicos_y_MultimediaPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_Electronicos_y_MultimediaEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_Electronicos_y_MultimediaRowElement = "Detalle_Aseguramiento_Electronicos_y_Multimedia_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_Electronicos_y_MultimediaPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_Electronicos_y_MultimediaMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_Electronicos_y_MultimediaAparatos').val(prevData.Aparatos);
    $('#Detalle_Aseguramiento_Electronicos_y_MultimediaDocumentos_Multimedia').val(prevData.Documentos_Multimedia);
    $('#Detalle_Aseguramiento_Electronicos_y_MultimediaDescripcion').val(prevData.Descripcion);
    $('#Detalle_Aseguramiento_Electronicos_y_MultimediaCantidad').val(prevData.Cantidad);
    $('#Detalle_Aseguramiento_Electronicos_y_MultimediaA_resguardo').val(prevData.A_resguardo);

    initiateUIControls();








}

function Detalle_Aseguramiento_Electronicos_y_MultimediaAddInsertRow() {
    if (Detalle_Aseguramiento_Electronicos_y_MultimediainsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_Electronicos_y_MultimediainsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Aparatos: ""
        ,Documentos_Multimedia: ""
        ,Descripcion: ""
        ,Cantidad: ""
        ,A_resguardo: ""

    }
}

function Detalle_Aseguramiento_Electronicos_y_MultimediafnClickAddRow() {
    Detalle_Aseguramiento_Electronicos_y_MultimediacountRowsChecked++;
    Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnAddData(Detalle_Aseguramiento_Electronicos_y_MultimediaAddInsertRow(), true);
    Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_Electronicos_y_MultimediaGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_Electronicos_y_MultimediaGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_Electronicos_y_MultimediainsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Electronicos_y_Multimedia("Detalle_Aseguramiento_Electronicos_y_Multimedia_", "_" + Detalle_Aseguramiento_Electronicos_y_MultimediainsertRowCurrentIndex);
}

function Detalle_Aseguramiento_Electronicos_y_MultimediaClearGridData() {
    Detalle_Aseguramiento_Electronicos_y_MultimediaData = [];
    Detalle_Aseguramiento_Electronicos_y_MultimediadeletedItem = [];
    Detalle_Aseguramiento_Electronicos_y_MultimediaDataMain = [];
    Detalle_Aseguramiento_Electronicos_y_MultimediaDataMainPages = [];
    Detalle_Aseguramiento_Electronicos_y_MultimedianewItemCount = 0;
    Detalle_Aseguramiento_Electronicos_y_MultimediamaxItemIndex = 0;
    $("#Detalle_Aseguramiento_Electronicos_y_MultimediaGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_Electronicos_y_MultimediaGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Electronicos_y_Multimedia() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_Electronicos_y_MultimediaData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_Electronicos_y_MultimediaData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_Electronicos_y_MultimediaData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Aparatos', Detalle_Aseguramiento_Electronicos_y_MultimediaData[i].Aparatos);
        form_data.append('[' + i + '].Documentos_Multimedia', Detalle_Aseguramiento_Electronicos_y_MultimediaData[i].Documentos_Multimedia);
        form_data.append('[' + i + '].Descripcion', Detalle_Aseguramiento_Electronicos_y_MultimediaData[i].Descripcion);
        form_data.append('[' + i + '].Cantidad', Detalle_Aseguramiento_Electronicos_y_MultimediaData[i].Cantidad);
        form_data.append('[' + i + '].A_resguardo', Detalle_Aseguramiento_Electronicos_y_MultimediaData[i].A_resguardo);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_Electronicos_y_MultimediaData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_Electronicos_y_MultimediaInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Electronicos_y_Multimedia("Detalle_Aseguramiento_Electronicos_y_MultimediaTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_Electronicos_y_MultimediaMotivo_de_Registro').val()
        ,Aparatos: $('#Detalle_Aseguramiento_Electronicos_y_MultimediaAparatos').val()
        ,Documentos_Multimedia: $('#Detalle_Aseguramiento_Electronicos_y_MultimediaDocumentos_Multimedia').val()
        ,Descripcion: $('#Detalle_Aseguramiento_Electronicos_y_MultimediaDescripcion').val()
        ,Cantidad: $('#Detalle_Aseguramiento_Electronicos_y_MultimediaCantidad').val()
        ,A_resguardo: $('#Detalle_Aseguramiento_Electronicos_y_MultimediaA_resguardo').val()

    }

    Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_Electronicos_y_MultimediarowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Electronicos_y_Multimedia-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Electronicos_y_Multimedia-form').modal('hide');
    Detalle_Aseguramiento_Electronicos_y_MultimediaEditRow(rowIndex);
    Detalle_Aseguramiento_Electronicos_y_MultimediaInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_Electronicos_y_MultimediaRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_Electronicos_y_MultimediaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Electronicos_y_Multimedia MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Pirateria MultiRow
var Detalle_Aseguramiento_PirateriacountRowsChecked = 0;

function GetDetalle_Aseguramiento_Pirateria_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Pirateria_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Pirateria_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Pirateria_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_Pirateria_Tipo_de_PirateriaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaItems.length; i++) {
        if (Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Pirateria_Tipo_de_PirateriaDropDown() {
    var Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Pirateria_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaDropdown);
    if(Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaItems[i].Clave, text:    Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaDropdown);
       }
    }
    return Detalle_Aseguramiento_Pirateria_Tipo_de_PirateriaDropdown;
}


function GetDetalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaItems.length; i++) {
        if (Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaDropDown() {
    var Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Pirateria_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaDropdown);
    if(Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaItems[i].Clave, text:    Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaDropdown);
       }
    }
    return Detalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaDropdown;
}



function GetInsertDetalle_Aseguramiento_PirateriaRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Pirateria_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Pirateria_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Pirateria_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Pirateria', 'Motivo_de_Registro', 'Motivo_de_Registro', 268347)));
    columnData[1] = $(GetDetalle_Aseguramiento_Pirateria_Tipo_de_PirateriaDropDown()).addClass('Detalle_Aseguramiento_Pirateria_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_Pirateria_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_Pirateria', 'Tipo_de_Pirateria', 'Tipo', 267599)));
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Pirateria_Descripcion Descripcion').attr('id', 'Detalle_Aseguramiento_Pirateria_Descripcion_' + index).attr('data-field', 'Descripcion');
    columnData[3] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_Pirateria_Cantidad Cantidad').attr('id', 'Detalle_Aseguramiento_Pirateria_Cantidad_' + index).attr('data-field', 'Cantidad');
    columnData[4] = $(GetDetalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaDropDown()).addClass('Detalle_Aseguramiento_Pirateria_Unidad_de_Medicion Unidad_de_Medicion').attr('id', 'Detalle_Aseguramiento_Pirateria_Unidad_de_Medicion_' + index).attr('data-field', 'Unidad_de_Medicion').after($.parseHTML(addNew('Detalle_Aseguramiento_Pirateria', 'Unidad_de_Medida_de_pirateria', 'Unidad_de_Medicion', 267602)));
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Pirateria_Observaciones Observaciones').attr('id', 'Detalle_Aseguramiento_Pirateria_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_PirateriaInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Pirateria("Detalle_Aseguramiento_Pirateria_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_PirateriaTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Pirateria';
    var prevData = Detalle_Aseguramiento_PirateriaTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_PirateriaTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value
        ,Cantidad: data.childNodes[counter++].childNodes[0].value
        ,Unidad_de_Medicion:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_PirateriaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_PirateriarowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_PirateriaTable.fnPageChange(iPage);
    Detalle_Aseguramiento_PirateriacountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Pirateria("Detalle_Aseguramiento_Pirateria_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_PirateriaCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_PirateriaTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_PirateriaTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_PirateriaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_PirateriarowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_PirateriaGrid(Detalle_Aseguramiento_PirateriaTable.fnGetData());
    Detalle_Aseguramiento_PirateriacountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_PirateriaFromDataTable() {
    var Detalle_Aseguramiento_PirateriaData = [];
    var gridData = Detalle_Aseguramiento_PirateriaTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_PirateriaData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Tipo: gridData[i].Tipo
                ,Descripcion: gridData[i].Descripcion
                ,Cantidad: gridData[i].Cantidad
                ,Unidad_de_Medicion: gridData[i].Unidad_de_Medicion
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_PirateriaData.length; i++) {
        if (removedDetalle_Aseguramiento_PirateriaData[i] != null && removedDetalle_Aseguramiento_PirateriaData[i].Clave > 0)
            Detalle_Aseguramiento_PirateriaData.push({
                Clave: removedDetalle_Aseguramiento_PirateriaData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_PirateriaData[i].Motivo_de_Registro
                ,Tipo: removedDetalle_Aseguramiento_PirateriaData[i].Tipo
                ,Descripcion: removedDetalle_Aseguramiento_PirateriaData[i].Descripcion
                ,Cantidad: removedDetalle_Aseguramiento_PirateriaData[i].Cantidad
                ,Unidad_de_Medicion: removedDetalle_Aseguramiento_PirateriaData[i].Unidad_de_Medicion
                ,Observaciones: removedDetalle_Aseguramiento_PirateriaData[i].Observaciones

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_PirateriaData;
}

function Detalle_Aseguramiento_PirateriaEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_PirateriaTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_PirateriacountRowsChecked++;
    var Detalle_Aseguramiento_PirateriaRowElement = "Detalle_Aseguramiento_Pirateria_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_PirateriaTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_PirateriaTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Pirateria_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_PirateriaGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Pirateria_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_PirateriaRowElement + "')){ Detalle_Aseguramiento_PirateriaInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_PirateriaCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_PirateriaGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_PirateriaGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_PirateriaValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Pirateria' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Pirateria(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_PirateriafnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_PirateriaTable.fnGetData().length;
    Detalle_Aseguramiento_PirateriafnClickAddRow();
    GetAddDetalle_Aseguramiento_PirateriaPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_PirateriaEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_PirateriaTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_PirateriaRowElement = "Detalle_Aseguramiento_Pirateria_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_PirateriaTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_PirateriaPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_PirateriaMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_PirateriaTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_PirateriaDescripcion').val(prevData.Descripcion);
    $('#Detalle_Aseguramiento_PirateriaCantidad').val(prevData.Cantidad);
    $('#Detalle_Aseguramiento_PirateriaUnidad_de_Medicion').val(prevData.Unidad_de_Medicion);
    $('#Detalle_Aseguramiento_PirateriaObservaciones').val(prevData.Observaciones);

    initiateUIControls();








}

function Detalle_Aseguramiento_PirateriaAddInsertRow() {
    if (Detalle_Aseguramiento_PirateriainsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_PirateriainsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Tipo: ""
        ,Descripcion: ""
        ,Cantidad: ""
        ,Unidad_de_Medicion: ""
        ,Observaciones: ""

    }
}

function Detalle_Aseguramiento_PirateriafnClickAddRow() {
    Detalle_Aseguramiento_PirateriacountRowsChecked++;
    Detalle_Aseguramiento_PirateriaTable.fnAddData(Detalle_Aseguramiento_PirateriaAddInsertRow(), true);
    Detalle_Aseguramiento_PirateriaTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_PirateriaGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_PirateriaGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_PirateriainsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Pirateria("Detalle_Aseguramiento_Pirateria_", "_" + Detalle_Aseguramiento_PirateriainsertRowCurrentIndex);
}

function Detalle_Aseguramiento_PirateriaClearGridData() {
    Detalle_Aseguramiento_PirateriaData = [];
    Detalle_Aseguramiento_PirateriadeletedItem = [];
    Detalle_Aseguramiento_PirateriaDataMain = [];
    Detalle_Aseguramiento_PirateriaDataMainPages = [];
    Detalle_Aseguramiento_PiraterianewItemCount = 0;
    Detalle_Aseguramiento_PirateriamaxItemIndex = 0;
    $("#Detalle_Aseguramiento_PirateriaGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_PirateriaGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Pirateria() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_PirateriaData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_PirateriaData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_PirateriaData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_PirateriaData[i].Tipo);
        form_data.append('[' + i + '].Descripcion', Detalle_Aseguramiento_PirateriaData[i].Descripcion);
        form_data.append('[' + i + '].Cantidad', Detalle_Aseguramiento_PirateriaData[i].Cantidad);
        form_data.append('[' + i + '].Unidad_de_Medicion', Detalle_Aseguramiento_PirateriaData[i].Unidad_de_Medicion);
        form_data.append('[' + i + '].Observaciones', Detalle_Aseguramiento_PirateriaData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_PirateriaData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_PirateriaInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Pirateria("Detalle_Aseguramiento_PirateriaTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_PirateriaTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_PirateriaTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_PirateriaMotivo_de_Registro').val()
        ,Tipo: $('#Detalle_Aseguramiento_PirateriaTipo').val()
        ,Descripcion: $('#Detalle_Aseguramiento_PirateriaDescripcion').val()
        ,Cantidad: $('#Detalle_Aseguramiento_PirateriaCantidad').val()
        ,Unidad_de_Medicion: $('#Detalle_Aseguramiento_PirateriaUnidad_de_Medicion').val()
        ,Observaciones: $('#Detalle_Aseguramiento_PirateriaObservaciones').val()

    }

    Detalle_Aseguramiento_PirateriaTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_PirateriarowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Pirateria-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Pirateria-form').modal('hide');
    Detalle_Aseguramiento_PirateriaEditRow(rowIndex);
    Detalle_Aseguramiento_PirateriaInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_PirateriaRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_PirateriaTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Pirateria MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Inmuebles MultiRow
var Detalle_Aseguramiento_InmueblescountRowsChecked = 0;

function GetDetalle_Aseguramiento_Inmuebles_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Inmuebles_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Inmuebles_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Inmuebles_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_Inmuebles_Tipo_de_ZonaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaItems.length; i++) {
        if (Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Inmuebles_Tipo_de_ZonaDropDown() {
    var Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Inmuebles_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaDropdown);
    if(Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaItems[i].Clave, text:    Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaDropdown);
       }
    }
    return Detalle_Aseguramiento_Inmuebles_Tipo_de_ZonaDropdown;
}
function GetDetalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleItems.length; i++) {
        if (Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleDropDown() {
    var Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Inmuebles_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleDropdown);
    if(Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleItems[i].Clave, text:    Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleDropdown);
       }
    }
    return Detalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleDropdown;
}




function GetDetalle_Aseguramiento_Inmuebles_EstadoName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_EstadoItems.length; i++) {
        if (Detalle_Aseguramiento_Inmuebles_EstadoItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Inmuebles_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Inmuebles_EstadoDropDown() {
    var Detalle_Aseguramiento_Inmuebles_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Inmuebles_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Inmuebles_EstadoDropdown);

    for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_EstadoItems.length; i++) {
        $('<option />', { value: Detalle_Aseguramiento_Inmuebles_EstadoItems[i].Clave, text: Detalle_Aseguramiento_Inmuebles_EstadoItems[i].Nombre }).appendTo(Detalle_Aseguramiento_Inmuebles_EstadoDropdown);
    }
    return Detalle_Aseguramiento_Inmuebles_EstadoDropdown;
}
function GetDetalle_Aseguramiento_Inmuebles_MunicipioName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_MunicipioItems.length; i++) {
        if (Detalle_Aseguramiento_Inmuebles_MunicipioItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Inmuebles_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Inmuebles_MunicipioDropDown() {
    var Detalle_Aseguramiento_Inmuebles_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Inmuebles_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Inmuebles_MunicipioDropdown);

    for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_MunicipioItems.length; i++) {
        $('<option />', { value: Detalle_Aseguramiento_Inmuebles_MunicipioItems[i].Clave, text: Detalle_Aseguramiento_Inmuebles_MunicipioItems[i].Nombre }).appendTo(Detalle_Aseguramiento_Inmuebles_MunicipioDropdown);
    }
    return Detalle_Aseguramiento_Inmuebles_MunicipioDropdown;
}
function GetDetalle_Aseguramiento_Inmuebles_ColoniaName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_ColoniaItems.length; i++) {
        if (Detalle_Aseguramiento_Inmuebles_ColoniaItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Inmuebles_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Inmuebles_ColoniaDropDown() {
    var Detalle_Aseguramiento_Inmuebles_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Inmuebles_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Inmuebles_ColoniaDropdown);

    for (var i = 0; i < Detalle_Aseguramiento_Inmuebles_ColoniaItems.length; i++) {
        $('<option />', { value: Detalle_Aseguramiento_Inmuebles_ColoniaItems[i].Clave, text: Detalle_Aseguramiento_Inmuebles_ColoniaItems[i].Nombre }).appendTo(Detalle_Aseguramiento_Inmuebles_ColoniaDropdown);
    }
    return Detalle_Aseguramiento_Inmuebles_ColoniaDropdown;
}






function GetInsertDetalle_Aseguramiento_InmueblesRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Inmuebles_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Inmuebles_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Inmuebles_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Inmuebles', 'Motivo_de_Registro', 'Motivo_de_Registro', 268352)));
    columnData[1] = $(GetDetalle_Aseguramiento_Inmuebles_Tipo_de_ZonaDropDown()).addClass('Detalle_Aseguramiento_Inmuebles_Zona Zona').attr('id', 'Detalle_Aseguramiento_Inmuebles_Zona_' + index).attr('data-field', 'Zona').after($.parseHTML(addNew('Detalle_Aseguramiento_Inmuebles', 'Tipo_de_Zona', 'Zona', 267549)));
    columnData[2] = $(GetDetalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleDropDown()).addClass('Detalle_Aseguramiento_Inmuebles_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_Inmuebles_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_Inmuebles', 'Tipo_de_Inmueble', 'Tipo', 267550)));
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Inmuebles_Calle Calle').attr('id', 'Detalle_Aseguramiento_Inmuebles_Calle_' + index).attr('data-field', 'Calle');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Inmuebles_Exterior Exterior').attr('id', 'Detalle_Aseguramiento_Inmuebles_Exterior_' + index).attr('data-field', 'Exterior');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Inmuebles_Interior Interior').attr('id', 'Detalle_Aseguramiento_Inmuebles_Interior_' + index).attr('data-field', 'Interior');
    columnData[6] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Inmuebles_C_P C_P').attr('id', 'Detalle_Aseguramiento_Inmuebles_C_P_' + index).attr('data-field', 'C_P');
    columnData[7] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Aseguramiento_Inmuebles_Estado'))).addClass('Detalle_Aseguramiento_Inmuebles_Estado Estado').attr('id', 'Detalle_Aseguramiento_Inmuebles_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_Aseguramiento_Inmuebles', 'Estado', 'Estado', 267557)));
    columnData[8] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Aseguramiento_Inmuebles_Municipio'))).addClass('Detalle_Aseguramiento_Inmuebles_Municipio Municipio').attr('id', 'Detalle_Aseguramiento_Inmuebles_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_Aseguramiento_Inmuebles', 'Municipio', 'Municipio', 267558)));
    columnData[9] = $($.parseHTML(GetGridAutoComplete(null,'AutoCompleteDetalle_Aseguramiento_Inmuebles_Colonia'))).addClass('Detalle_Aseguramiento_Inmuebles_Colonia Colonia').attr('id', 'Detalle_Aseguramiento_Inmuebles_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_Aseguramiento_Inmuebles', 'Colonia', 'Colonia', 267559)));
    columnData[10] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Inmuebles_Registro_Publico_Propiedad Registro_Publico_Propiedad').attr('id', 'Detalle_Aseguramiento_Inmuebles_Registro_Publico_Propiedad_' + index).attr('data-field', 'Registro_Publico_Propiedad');
    columnData[11] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Inmuebles_Entrecalles Entrecalles').attr('id', 'Detalle_Aseguramiento_Inmuebles_Entrecalles_' + index).attr('data-field', 'Entrecalles');
    columnData[12] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Inmuebles_Propietario Propietario').attr('id', 'Detalle_Aseguramiento_Inmuebles_Propietario_' + index).attr('data-field', 'Propietario');
    columnData[13] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Inmuebles_Observaciones Observaciones').attr('id', 'Detalle_Aseguramiento_Inmuebles_Observaciones_' + index).attr('data-field', 'Observaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_InmueblesInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Inmuebles("Detalle_Aseguramiento_Inmuebles_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_InmueblesTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Inmuebles';
    var prevData = Detalle_Aseguramiento_InmueblesTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_InmueblesTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Zona:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,Calle:  data.childNodes[counter++].childNodes[0].value
        ,Exterior:  data.childNodes[counter++].childNodes[0].value
        ,Interior:  data.childNodes[counter++].childNodes[0].value
        ,C_P:  data.childNodes[counter++].childNodes[0].value
        , EstadoNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Estado:  data.childNodes[counter++].childNodes[0].value 	
        , MunicipioNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Municipio:  data.childNodes[counter++].childNodes[0].value 	
        , ColoniaNombre:  $(data.childNodes[counter].childNodes[0]).find('option:selected').text() 
        , Colonia:  data.childNodes[counter++].childNodes[0].value 	
        ,Registro_Publico_Propiedad:  data.childNodes[counter++].childNodes[0].value
        ,Entrecalles:  data.childNodes[counter++].childNodes[0].value
        ,Propietario:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_InmueblesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_InmueblesrowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_InmueblesTable.fnPageChange(iPage);
    Detalle_Aseguramiento_InmueblescountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Inmuebles("Detalle_Aseguramiento_Inmuebles_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_InmueblesCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_InmueblesTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_InmueblesTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_InmueblesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_InmueblesrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_InmueblesGrid(Detalle_Aseguramiento_InmueblesTable.fnGetData());
    Detalle_Aseguramiento_InmueblescountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_InmueblesFromDataTable() {
    var Detalle_Aseguramiento_InmueblesData = [];
    var gridData = Detalle_Aseguramiento_InmueblesTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_InmueblesData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Zona: gridData[i].Zona
                ,Tipo: gridData[i].Tipo
                ,Calle: gridData[i].Calle
                ,Exterior: gridData[i].Exterior
                ,Interior: gridData[i].Interior
                ,C_P: gridData[i].C_P
                ,Estado: gridData[i].Estado
                ,Municipio: gridData[i].Municipio
                ,Colonia: gridData[i].Colonia
                ,Registro_Publico_Propiedad: gridData[i].Registro_Publico_Propiedad
                ,Entrecalles: gridData[i].Entrecalles
                ,Propietario: gridData[i].Propietario
                ,Observaciones: gridData[i].Observaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_InmueblesData.length; i++) {
        if (removedDetalle_Aseguramiento_InmueblesData[i] != null && removedDetalle_Aseguramiento_InmueblesData[i].Clave > 0)
            Detalle_Aseguramiento_InmueblesData.push({
                Clave: removedDetalle_Aseguramiento_InmueblesData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_InmueblesData[i].Motivo_de_Registro
                ,Zona: removedDetalle_Aseguramiento_InmueblesData[i].Zona
                ,Tipo: removedDetalle_Aseguramiento_InmueblesData[i].Tipo
                ,Calle: removedDetalle_Aseguramiento_InmueblesData[i].Calle
                ,Exterior: removedDetalle_Aseguramiento_InmueblesData[i].Exterior
                ,Interior: removedDetalle_Aseguramiento_InmueblesData[i].Interior
                ,C_P: removedDetalle_Aseguramiento_InmueblesData[i].C_P
                ,Estado: removedDetalle_Aseguramiento_InmueblesData[i].Estado
                ,Municipio: removedDetalle_Aseguramiento_InmueblesData[i].Municipio
                ,Colonia: removedDetalle_Aseguramiento_InmueblesData[i].Colonia
                ,Registro_Publico_Propiedad: removedDetalle_Aseguramiento_InmueblesData[i].Registro_Publico_Propiedad
                ,Entrecalles: removedDetalle_Aseguramiento_InmueblesData[i].Entrecalles
                ,Propietario: removedDetalle_Aseguramiento_InmueblesData[i].Propietario
                ,Observaciones: removedDetalle_Aseguramiento_InmueblesData[i].Observaciones

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_InmueblesData;
}

function Detalle_Aseguramiento_InmueblesEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_InmueblesTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_InmueblescountRowsChecked++;
    var Detalle_Aseguramiento_InmueblesRowElement = "Detalle_Aseguramiento_Inmuebles_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_InmueblesTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_InmueblesTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Inmuebles_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_InmueblesGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Inmuebles_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_InmueblesRowElement + "')){ Detalle_Aseguramiento_InmueblesInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_InmueblesCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_InmueblesGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_InmueblesGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_InmueblesValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Inmuebles' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Inmuebles(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_InmueblesfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_InmueblesTable.fnGetData().length;
    Detalle_Aseguramiento_InmueblesfnClickAddRow();
    GetAddDetalle_Aseguramiento_InmueblesPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_InmueblesEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_InmueblesTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_InmueblesRowElement = "Detalle_Aseguramiento_Inmuebles_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_InmueblesTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_InmueblesPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_InmueblesMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_InmueblesZona').val(prevData.Zona);
    $('#Detalle_Aseguramiento_InmueblesTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_InmueblesCalle').val(prevData.Calle);
    $('#Detalle_Aseguramiento_InmueblesExterior').val(prevData.Exterior);
    $('#Detalle_Aseguramiento_InmueblesInterior').val(prevData.Interior);
    $('#Detalle_Aseguramiento_InmueblesC_P').val(prevData.C_P);
    $('#dvDetalle_Aseguramiento_InmueblesEstado').html($($.parseHTML(GetGridAutoComplete(prevData.Estado.label,'AutoCompleteEstado'))).addClass('Detalle_Aseguramiento_Inmuebles_Estado'));
    $('#dvDetalle_Aseguramiento_InmueblesMunicipio').html($($.parseHTML(GetGridAutoComplete(prevData.Municipio.label,'AutoCompleteMunicipio'))).addClass('Detalle_Aseguramiento_Inmuebles_Municipio'));
    $('#dvDetalle_Aseguramiento_InmueblesColonia').html($($.parseHTML(GetGridAutoComplete(prevData.Colonia.label,'AutoCompleteColonia'))).addClass('Detalle_Aseguramiento_Inmuebles_Colonia'));
    $('#Detalle_Aseguramiento_InmueblesRegistro_Publico_Propiedad').val(prevData.Registro_Publico_Propiedad);
    $('#Detalle_Aseguramiento_InmueblesEntrecalles').val(prevData.Entrecalles);
    $('#Detalle_Aseguramiento_InmueblesPropietario').val(prevData.Propietario);
    $('#Detalle_Aseguramiento_InmueblesObservaciones').val(prevData.Observaciones);

    initiateUIControls();
















}

function Detalle_Aseguramiento_InmueblesAddInsertRow() {
    if (Detalle_Aseguramiento_InmueblesinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_InmueblesinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Zona: ""
        ,Tipo: ""
        ,Calle: ""
        ,Exterior: ""
        ,Interior: ""
        ,C_P: ""
        ,Estado: ""
        ,Municipio: ""
        ,Colonia: ""
        ,Registro_Publico_Propiedad: ""
        ,Entrecalles: ""
        ,Propietario: ""
        ,Observaciones: ""

    }
}

function Detalle_Aseguramiento_InmueblesfnClickAddRow() {
    Detalle_Aseguramiento_InmueblescountRowsChecked++;
    Detalle_Aseguramiento_InmueblesTable.fnAddData(Detalle_Aseguramiento_InmueblesAddInsertRow(), true);
    Detalle_Aseguramiento_InmueblesTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_InmueblesGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_InmueblesGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_InmueblesinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Inmuebles("Detalle_Aseguramiento_Inmuebles_", "_" + Detalle_Aseguramiento_InmueblesinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_InmueblesClearGridData() {
    Detalle_Aseguramiento_InmueblesData = [];
    Detalle_Aseguramiento_InmueblesdeletedItem = [];
    Detalle_Aseguramiento_InmueblesDataMain = [];
    Detalle_Aseguramiento_InmueblesDataMainPages = [];
    Detalle_Aseguramiento_InmueblesnewItemCount = 0;
    Detalle_Aseguramiento_InmueblesmaxItemIndex = 0;
    $("#Detalle_Aseguramiento_InmueblesGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_InmueblesGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Inmuebles() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_InmueblesData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_InmueblesData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_InmueblesData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Zona', Detalle_Aseguramiento_InmueblesData[i].Zona);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_InmueblesData[i].Tipo);
        form_data.append('[' + i + '].Calle', Detalle_Aseguramiento_InmueblesData[i].Calle);
        form_data.append('[' + i + '].Exterior', Detalle_Aseguramiento_InmueblesData[i].Exterior);
        form_data.append('[' + i + '].Interior', Detalle_Aseguramiento_InmueblesData[i].Interior);
        form_data.append('[' + i + '].C_P', Detalle_Aseguramiento_InmueblesData[i].C_P);
        form_data.append('[' + i + '].Estado', Detalle_Aseguramiento_InmueblesData[i].Estado);
        form_data.append('[' + i + '].Municipio', Detalle_Aseguramiento_InmueblesData[i].Municipio);
        form_data.append('[' + i + '].Colonia', Detalle_Aseguramiento_InmueblesData[i].Colonia);
        form_data.append('[' + i + '].Registro_Publico_Propiedad', Detalle_Aseguramiento_InmueblesData[i].Registro_Publico_Propiedad);
        form_data.append('[' + i + '].Entrecalles', Detalle_Aseguramiento_InmueblesData[i].Entrecalles);
        form_data.append('[' + i + '].Propietario', Detalle_Aseguramiento_InmueblesData[i].Propietario);
        form_data.append('[' + i + '].Observaciones', Detalle_Aseguramiento_InmueblesData[i].Observaciones);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_InmueblesData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_InmueblesInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Inmuebles("Detalle_Aseguramiento_InmueblesTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_InmueblesTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_InmueblesTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_InmueblesMotivo_de_Registro').val()
        ,Zona: $('#Detalle_Aseguramiento_InmueblesZona').val()
        ,Tipo: $('#Detalle_Aseguramiento_InmueblesTipo').val()
        ,Calle: $('#Detalle_Aseguramiento_InmueblesCalle').val()
        ,Exterior: $('#Detalle_Aseguramiento_InmueblesExterior').val()
        ,Interior: $('#Detalle_Aseguramiento_InmueblesInterior').val()
        ,C_P: $('#Detalle_Aseguramiento_InmueblesC_P').val()
        ,Estado: $('#Detalle_Aseguramiento_InmueblesEstado').val()
        ,Municipio: $('#Detalle_Aseguramiento_InmueblesMunicipio').val()
        ,Colonia: $('#Detalle_Aseguramiento_InmueblesColonia').val()
        ,Registro_Publico_Propiedad: $('#Detalle_Aseguramiento_InmueblesRegistro_Publico_Propiedad').val()
        ,Entrecalles: $('#Detalle_Aseguramiento_InmueblesEntrecalles').val()
        ,Propietario: $('#Detalle_Aseguramiento_InmueblesPropietario').val()
        ,Observaciones: $('#Detalle_Aseguramiento_InmueblesObservaciones').val()

    }

    Detalle_Aseguramiento_InmueblesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_InmueblesrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Inmuebles-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Inmuebles-form').modal('hide');
    Detalle_Aseguramiento_InmueblesEditRow(rowIndex);
    Detalle_Aseguramiento_InmueblesInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_InmueblesRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_InmueblesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Inmuebles MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_de_Plantios MultiRow
var Detalle_Aseguramiento_de_PlantioscountRowsChecked = 0;

function GetDetalle_Aseguramiento_de_Plantios_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Plantios_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Plantios_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Plantios_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_de_Plantios_Tipo_de_PlantioName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioItems.length; i++) {
        if (Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Plantios_Tipo_de_PlantioDropDown() {
    var Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Plantios_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioDropdown);
    if(Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioItems[i].Clave, text:    Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Plantios_Tipo_de_PlantioDropdown;
}


function GetDetalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionItems.length; i++) {
        if (Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionDropDown() {
    var Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Plantios_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionDropdown);
    if(Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionItems[i].Clave, text:    Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionDropdown;
}










function GetInsertDetalle_Aseguramiento_de_PlantiosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_de_Plantios_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_de_Plantios_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_de_Plantios_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Plantios', 'Motivo_de_Registro', 'Motivo_de_Registro', 268353)));
    columnData[1] = $(GetDetalle_Aseguramiento_de_Plantios_Tipo_de_PlantioDropDown()).addClass('Detalle_Aseguramiento_de_Plantios_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_de_Plantios_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Plantios', 'Tipo_de_Plantio', 'Tipo', 267631)));
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_de_Plantios_No__de_Plantios No__de_Plantios').attr('id', 'Detalle_Aseguramiento_de_Plantios_No__de_Plantios_' + index).attr('data-field', 'No__de_Plantios');
    columnData[3] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_de_Plantios_Kilogramos Kilogramos').attr('id', 'Detalle_Aseguramiento_de_Plantios_Kilogramos_' + index).attr('data-field', 'Kilogramos');
    columnData[4] = $(GetDetalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionDropDown()).addClass('Detalle_Aseguramiento_de_Plantios_Metodo_de_Destruccion Metodo_de_Destruccion').attr('id', 'Detalle_Aseguramiento_de_Plantios_Metodo_de_Destruccion_' + index).attr('data-field', 'Metodo_de_Destruccion').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Plantios', 'Metodo_de_Destruccion', 'Metodo_de_Destruccion', 267634)));
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Plantios_Superficie Superficie').attr('id', 'Detalle_Aseguramiento_de_Plantios_Superficie_' + index).attr('data-field', 'Superficie');
    columnData[6] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Plantios_Altura Altura').attr('id', 'Detalle_Aseguramiento_de_Plantios_Altura_' + index).attr('data-field', 'Altura');
    columnData[7] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Plantios_Densidad Densidad').attr('id', 'Detalle_Aseguramiento_de_Plantios_Densidad_' + index).attr('data-field', 'Densidad');
    columnData[8] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Plantios_Peso_por_planta Peso_por_planta').attr('id', 'Detalle_Aseguramiento_de_Plantios_Peso_por_planta_' + index).attr('data-field', 'Peso_por_planta');
    columnData[9] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Plantios_Latitud Latitud').attr('id', 'Detalle_Aseguramiento_de_Plantios_Latitud_' + index).attr('data-field', 'Latitud');
    columnData[10] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Plantios_Longitud Longitud').attr('id', 'Detalle_Aseguramiento_de_Plantios_Longitud_' + index).attr('data-field', 'Longitud');
    columnData[11] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_de_Plantios_Largo Largo').attr('id', 'Detalle_Aseguramiento_de_Plantios_Largo_' + index).attr('data-field', 'Largo');
    columnData[12] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_de_Plantios_Ancho Ancho').attr('id', 'Detalle_Aseguramiento_de_Plantios_Ancho_' + index).attr('data-field', 'Ancho');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_de_PlantiosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Plantios("Detalle_Aseguramiento_de_Plantios_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_de_PlantiosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_de_Plantios';
    var prevData = Detalle_Aseguramiento_de_PlantiosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_PlantiosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,No__de_Plantios: data.childNodes[counter++].childNodes[0].value
        ,Kilogramos: data.childNodes[counter++].childNodes[0].value
        ,Metodo_de_Destruccion:  data.childNodes[counter++].childNodes[0].value
        ,Superficie:  data.childNodes[counter++].childNodes[0].value
        ,Altura:  data.childNodes[counter++].childNodes[0].value
        ,Densidad:  data.childNodes[counter++].childNodes[0].value
        ,Peso_por_planta:  data.childNodes[counter++].childNodes[0].value
        ,Latitud:  data.childNodes[counter++].childNodes[0].value
        ,Longitud:  data.childNodes[counter++].childNodes[0].value
        ,Largo: data.childNodes[counter++].childNodes[0].value
        ,Ancho: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_de_PlantiosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_de_PlantiosrowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_de_PlantiosTable.fnPageChange(iPage);
    Detalle_Aseguramiento_de_PlantioscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_de_Plantios("Detalle_Aseguramiento_de_Plantios_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_de_PlantiosCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_de_PlantiosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_PlantiosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_de_PlantiosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_de_PlantiosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_de_PlantiosGrid(Detalle_Aseguramiento_de_PlantiosTable.fnGetData());
    Detalle_Aseguramiento_de_PlantioscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_de_PlantiosFromDataTable() {
    var Detalle_Aseguramiento_de_PlantiosData = [];
    var gridData = Detalle_Aseguramiento_de_PlantiosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_de_PlantiosData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Tipo: gridData[i].Tipo
                ,No__de_Plantios: gridData[i].No__de_Plantios
                ,Kilogramos: gridData[i].Kilogramos
                ,Metodo_de_Destruccion: gridData[i].Metodo_de_Destruccion
                ,Superficie: gridData[i].Superficie
                ,Altura: gridData[i].Altura
                ,Densidad: gridData[i].Densidad
                ,Peso_por_planta: gridData[i].Peso_por_planta
                ,Latitud: gridData[i].Latitud
                ,Longitud: gridData[i].Longitud
                ,Largo: gridData[i].Largo
                ,Ancho: gridData[i].Ancho

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_de_PlantiosData.length; i++) {
        if (removedDetalle_Aseguramiento_de_PlantiosData[i] != null && removedDetalle_Aseguramiento_de_PlantiosData[i].Clave > 0)
            Detalle_Aseguramiento_de_PlantiosData.push({
                Clave: removedDetalle_Aseguramiento_de_PlantiosData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_de_PlantiosData[i].Motivo_de_Registro
                ,Tipo: removedDetalle_Aseguramiento_de_PlantiosData[i].Tipo
                ,No__de_Plantios: removedDetalle_Aseguramiento_de_PlantiosData[i].No__de_Plantios
                ,Kilogramos: removedDetalle_Aseguramiento_de_PlantiosData[i].Kilogramos
                ,Metodo_de_Destruccion: removedDetalle_Aseguramiento_de_PlantiosData[i].Metodo_de_Destruccion
                ,Superficie: removedDetalle_Aseguramiento_de_PlantiosData[i].Superficie
                ,Altura: removedDetalle_Aseguramiento_de_PlantiosData[i].Altura
                ,Densidad: removedDetalle_Aseguramiento_de_PlantiosData[i].Densidad
                ,Peso_por_planta: removedDetalle_Aseguramiento_de_PlantiosData[i].Peso_por_planta
                ,Latitud: removedDetalle_Aseguramiento_de_PlantiosData[i].Latitud
                ,Longitud: removedDetalle_Aseguramiento_de_PlantiosData[i].Longitud
                ,Largo: removedDetalle_Aseguramiento_de_PlantiosData[i].Largo
                ,Ancho: removedDetalle_Aseguramiento_de_PlantiosData[i].Ancho

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_de_PlantiosData;
}

function Detalle_Aseguramiento_de_PlantiosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_de_PlantiosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_de_PlantioscountRowsChecked++;
    var Detalle_Aseguramiento_de_PlantiosRowElement = "Detalle_Aseguramiento_de_Plantios_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_de_PlantiosTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_de_PlantiosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_de_Plantios_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_de_PlantiosGetUpdateRowControls(prevData, "Detalle_Aseguramiento_de_Plantios_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_de_PlantiosRowElement + "')){ Detalle_Aseguramiento_de_PlantiosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_de_PlantiosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_de_PlantiosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_de_PlantiosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_de_PlantiosValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_de_Plantios' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_de_Plantios(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_de_PlantiosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_de_PlantiosTable.fnGetData().length;
    Detalle_Aseguramiento_de_PlantiosfnClickAddRow();
    GetAddDetalle_Aseguramiento_de_PlantiosPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_de_PlantiosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_de_PlantiosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_de_PlantiosRowElement = "Detalle_Aseguramiento_de_Plantios_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_de_PlantiosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_de_PlantiosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_de_PlantiosMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_de_PlantiosTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_de_PlantiosNo__de_Plantios').val(prevData.No__de_Plantios);
    $('#Detalle_Aseguramiento_de_PlantiosKilogramos').val(prevData.Kilogramos);
    $('#Detalle_Aseguramiento_de_PlantiosMetodo_de_Destruccion').val(prevData.Metodo_de_Destruccion);
    $('#Detalle_Aseguramiento_de_PlantiosSuperficie').val(prevData.Superficie);
    $('#Detalle_Aseguramiento_de_PlantiosAltura').val(prevData.Altura);
    $('#Detalle_Aseguramiento_de_PlantiosDensidad').val(prevData.Densidad);
    $('#Detalle_Aseguramiento_de_PlantiosPeso_por_planta').val(prevData.Peso_por_planta);
    $('#Detalle_Aseguramiento_de_PlantiosLatitud').val(prevData.Latitud);
    $('#Detalle_Aseguramiento_de_PlantiosLongitud').val(prevData.Longitud);
    $('#Detalle_Aseguramiento_de_PlantiosLargo').val(prevData.Largo);
    $('#Detalle_Aseguramiento_de_PlantiosAncho').val(prevData.Ancho);

    initiateUIControls();















}

function Detalle_Aseguramiento_de_PlantiosAddInsertRow() {
    if (Detalle_Aseguramiento_de_PlantiosinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_de_PlantiosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Tipo: ""
        ,No__de_Plantios: ""
        ,Kilogramos: ""
        ,Metodo_de_Destruccion: ""
        ,Superficie: ""
        ,Altura: ""
        ,Densidad: ""
        ,Peso_por_planta: ""
        ,Latitud: ""
        ,Longitud: ""
        ,Largo: ""
        ,Ancho: ""

    }
}

function Detalle_Aseguramiento_de_PlantiosfnClickAddRow() {
    Detalle_Aseguramiento_de_PlantioscountRowsChecked++;
    Detalle_Aseguramiento_de_PlantiosTable.fnAddData(Detalle_Aseguramiento_de_PlantiosAddInsertRow(), true);
    Detalle_Aseguramiento_de_PlantiosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_de_PlantiosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_de_PlantiosGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_de_PlantiosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_de_Plantios("Detalle_Aseguramiento_de_Plantios_", "_" + Detalle_Aseguramiento_de_PlantiosinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_de_PlantiosClearGridData() {
    Detalle_Aseguramiento_de_PlantiosData = [];
    Detalle_Aseguramiento_de_PlantiosdeletedItem = [];
    Detalle_Aseguramiento_de_PlantiosDataMain = [];
    Detalle_Aseguramiento_de_PlantiosDataMainPages = [];
    Detalle_Aseguramiento_de_PlantiosnewItemCount = 0;
    Detalle_Aseguramiento_de_PlantiosmaxItemIndex = 0;
    $("#Detalle_Aseguramiento_de_PlantiosGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_de_PlantiosGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_de_Plantios() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_de_PlantiosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_de_PlantiosData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_de_PlantiosData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_de_PlantiosData[i].Tipo);
        form_data.append('[' + i + '].No__de_Plantios', Detalle_Aseguramiento_de_PlantiosData[i].No__de_Plantios);
        form_data.append('[' + i + '].Kilogramos', Detalle_Aseguramiento_de_PlantiosData[i].Kilogramos);
        form_data.append('[' + i + '].Metodo_de_Destruccion', Detalle_Aseguramiento_de_PlantiosData[i].Metodo_de_Destruccion);
        form_data.append('[' + i + '].Superficie', Detalle_Aseguramiento_de_PlantiosData[i].Superficie);
        form_data.append('[' + i + '].Altura', Detalle_Aseguramiento_de_PlantiosData[i].Altura);
        form_data.append('[' + i + '].Densidad', Detalle_Aseguramiento_de_PlantiosData[i].Densidad);
        form_data.append('[' + i + '].Peso_por_planta', Detalle_Aseguramiento_de_PlantiosData[i].Peso_por_planta);
        form_data.append('[' + i + '].Latitud', Detalle_Aseguramiento_de_PlantiosData[i].Latitud);
        form_data.append('[' + i + '].Longitud', Detalle_Aseguramiento_de_PlantiosData[i].Longitud);
        form_data.append('[' + i + '].Largo', Detalle_Aseguramiento_de_PlantiosData[i].Largo);
        form_data.append('[' + i + '].Ancho', Detalle_Aseguramiento_de_PlantiosData[i].Ancho);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_de_PlantiosData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_de_PlantiosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Plantios("Detalle_Aseguramiento_de_PlantiosTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_de_PlantiosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_PlantiosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_de_PlantiosMotivo_de_Registro').val()
        ,Tipo: $('#Detalle_Aseguramiento_de_PlantiosTipo').val()
        ,No__de_Plantios: $('#Detalle_Aseguramiento_de_PlantiosNo__de_Plantios').val()

        ,Kilogramos: $('#Detalle_Aseguramiento_de_PlantiosKilogramos').val()
        ,Metodo_de_Destruccion: $('#Detalle_Aseguramiento_de_PlantiosMetodo_de_Destruccion').val()
        ,Superficie: $('#Detalle_Aseguramiento_de_PlantiosSuperficie').val()
        ,Altura: $('#Detalle_Aseguramiento_de_PlantiosAltura').val()
        ,Densidad: $('#Detalle_Aseguramiento_de_PlantiosDensidad').val()
        ,Peso_por_planta: $('#Detalle_Aseguramiento_de_PlantiosPeso_por_planta').val()
        ,Latitud: $('#Detalle_Aseguramiento_de_PlantiosLatitud').val()
        ,Longitud: $('#Detalle_Aseguramiento_de_PlantiosLongitud').val()
        ,Largo: $('#Detalle_Aseguramiento_de_PlantiosLargo').val()
        ,Ancho: $('#Detalle_Aseguramiento_de_PlantiosAncho').val()

    }

    Detalle_Aseguramiento_de_PlantiosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_de_PlantiosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_de_Plantios-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_de_Plantios-form').modal('hide');
    Detalle_Aseguramiento_de_PlantiosEditRow(rowIndex);
    Detalle_Aseguramiento_de_PlantiosInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_de_PlantiosRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_de_PlantiosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_de_Plantios MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_de_Pistas_de_Aterrizaje MultiRow
var Detalle_Aseguramiento_de_Pistas_de_AterrizajecountRowsChecked = 0;

function GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroDropdown;
}
function GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeItems.length; i++) {
        if (Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeDropDown() {
    var Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeDropdown);
    if(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeItems[i].Clave, text:    Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeDropdown;
}





function GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems.length; i++) {
        if (Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropDown() {
    var Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropdown);
    if(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems[i].Clave, text:    Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropdown;
}
function GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems.length; i++) {
        if (Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems[i].Clave == Id) {
            return Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropDown() {
    var Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropdown);
    if(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems[i].Clave, text:    Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropdown);
       }
    }
    return Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropdown;
}




function GetInsertDetalle_Aseguramiento_de_Pistas_de_AterrizajeRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje', 'Motivo_de_Registro', 'Motivo_de_Registro', 268354)));
    columnData[1] = $(GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeDropDown()).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_' + index).attr('data-field', 'Tipo').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje', 'Tipo_de_Pista_de_Aterrizaje', 'Tipo', 267618)));
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Suelo Suelo').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Suelo_' + index).attr('data-field', 'Suelo');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Descripcion Descripcion').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Descripcion_' + index).attr('data-field', 'Descripcion');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Localizacion_1 Localizacion_1').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Localizacion_1_' + index).attr('data-field', 'Localizacion_1');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Latitud Latitud').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Latitud_' + index).attr('data-field', 'Latitud');
    columnData[6] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Longitud Longitud').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Longitud_' + index).attr('data-field', 'Longitud');
    columnData[7] = $(GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropDown()).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Orientacion_de Orientacion_de').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Orientacion_de_' + index).attr('data-field', 'Orientacion_de').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje', 'Tipo_de_Orientacion', 'Orientacion_de', 267625)));
    columnData[8] = $(GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionDropDown()).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Orientacion Orientacion').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Orientacion_' + index).attr('data-field', 'Orientacion').after($.parseHTML(addNew('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje', 'Tipo_de_Orientacion', 'Orientacion', 267626)));
    columnData[9] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Largo Largo').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Largo_' + index).attr('data-field', 'Largo');
    columnData[10] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Ancho Ancho').attr('id', 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Ancho_' + index).attr('data-field', 'Ancho');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_de_Pistas_de_AterrizajeInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Pistas_de_Aterrizaje("Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_de_Pistas_de_Aterrizaje';
    var prevData = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,Suelo:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value
        ,Localizacion_1:  data.childNodes[counter++].childNodes[0].value
        ,Latitud:  data.childNodes[counter++].childNodes[0].value
        ,Longitud:  data.childNodes[counter++].childNodes[0].value
        ,Orientacion_de:  data.childNodes[counter++].childNodes[0].value
        ,Orientacion:  data.childNodes[counter++].childNodes[0].value
        ,Largo: data.childNodes[counter++].childNodes[0].value
        ,Ancho: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_de_Pistas_de_AterrizajerowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnPageChange(iPage);
    Detalle_Aseguramiento_de_Pistas_de_AterrizajecountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_de_Pistas_de_Aterrizaje("Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_de_Pistas_de_AterrizajeCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_de_Pistas_de_AterrizajerowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_de_Pistas_de_AterrizajeGrid(Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetData());
    Detalle_Aseguramiento_de_Pistas_de_AterrizajecountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_de_Pistas_de_AterrizajeFromDataTable() {
    var Detalle_Aseguramiento_de_Pistas_de_AterrizajeData = [];
    var gridData = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_de_Pistas_de_AterrizajeData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Tipo: gridData[i].Tipo
                ,Suelo: gridData[i].Suelo
                ,Descripcion: gridData[i].Descripcion
                ,Localizacion_1: gridData[i].Localizacion_1
                ,Latitud: gridData[i].Latitud
                ,Longitud: gridData[i].Longitud
                ,Orientacion_de: gridData[i].Orientacion_de
                ,Orientacion: gridData[i].Orientacion
                ,Largo: gridData[i].Largo
                ,Ancho: gridData[i].Ancho

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData.length; i++) {
        if (removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i] != null && removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Clave > 0)
            Detalle_Aseguramiento_de_Pistas_de_AterrizajeData.push({
                Clave: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Motivo_de_Registro
                ,Tipo: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Tipo
                ,Suelo: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Suelo
                ,Descripcion: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Descripcion
                ,Localizacion_1: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Localizacion_1
                ,Latitud: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Latitud
                ,Longitud: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Longitud
                ,Orientacion_de: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Orientacion_de
                ,Orientacion: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Orientacion
                ,Largo: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Largo
                ,Ancho: removedDetalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Ancho

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_de_Pistas_de_AterrizajeData;
}

function Detalle_Aseguramiento_de_Pistas_de_AterrizajeEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_de_Pistas_de_AterrizajecountRowsChecked++;
    var Detalle_Aseguramiento_de_Pistas_de_AterrizajeRowElement = "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_de_Pistas_de_AterrizajeGetUpdateRowControls(prevData, "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_de_Pistas_de_AterrizajeRowElement + "')){ Detalle_Aseguramiento_de_Pistas_de_AterrizajeInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_de_Pistas_de_AterrizajeCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_de_Pistas_de_AterrizajeValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_de_Pistas_de_Aterrizaje' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_de_Pistas_de_AterrizajefnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetData().length;
    Detalle_Aseguramiento_de_Pistas_de_AterrizajefnClickAddRow();
    GetAddDetalle_Aseguramiento_de_Pistas_de_AterrizajePopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_de_Pistas_de_AterrizajeEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_de_Pistas_de_AterrizajeRowElement = "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_de_Pistas_de_AterrizajePopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeSuelo').val(prevData.Suelo);
    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeDescripcion').val(prevData.Descripcion);
    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeLocalizacion_1').val(prevData.Localizacion_1);
    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeLatitud').val(prevData.Latitud);
    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeLongitud').val(prevData.Longitud);
    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeOrientacion_de').val(prevData.Orientacion_de);
    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeOrientacion').val(prevData.Orientacion);
    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeLargo').val(prevData.Largo);
    $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeAncho').val(prevData.Ancho);

    initiateUIControls();













}

function Detalle_Aseguramiento_de_Pistas_de_AterrizajeAddInsertRow() {
    if (Detalle_Aseguramiento_de_Pistas_de_AterrizajeinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_de_Pistas_de_AterrizajeinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Tipo: ""
        ,Suelo: ""
        ,Descripcion: ""
        ,Localizacion_1: ""
        ,Latitud: ""
        ,Longitud: ""
        ,Orientacion_de: ""
        ,Orientacion: ""
        ,Largo: ""
        ,Ancho: ""

    }
}

function Detalle_Aseguramiento_de_Pistas_de_AterrizajefnClickAddRow() {
    Detalle_Aseguramiento_de_Pistas_de_AterrizajecountRowsChecked++;
    Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnAddData(Detalle_Aseguramiento_de_Pistas_de_AterrizajeAddInsertRow(), true);
    Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_de_Pistas_de_AterrizajeinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_de_Pistas_de_Aterrizaje("Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_", "_" + Detalle_Aseguramiento_de_Pistas_de_AterrizajeinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_de_Pistas_de_AterrizajeClearGridData() {
    Detalle_Aseguramiento_de_Pistas_de_AterrizajeData = [];
    Detalle_Aseguramiento_de_Pistas_de_AterrizajedeletedItem = [];
    Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain = [];
    Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMainPages = [];
    Detalle_Aseguramiento_de_Pistas_de_AterrizajenewItemCount = 0;
    Detalle_Aseguramiento_de_Pistas_de_AterrizajemaxItemIndex = 0;
    $("#Detalle_Aseguramiento_de_Pistas_de_AterrizajeGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_de_Pistas_de_AterrizajeGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_AterrizajeData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Tipo);
        form_data.append('[' + i + '].Suelo', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Suelo);
        form_data.append('[' + i + '].Descripcion', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Descripcion);
        form_data.append('[' + i + '].Localizacion_1', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Localizacion_1);
        form_data.append('[' + i + '].Latitud', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Latitud);
        form_data.append('[' + i + '].Longitud', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Longitud);
        form_data.append('[' + i + '].Orientacion_de', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Orientacion_de);
        form_data.append('[' + i + '].Orientacion', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Orientacion);
        form_data.append('[' + i + '].Largo', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Largo);
        form_data.append('[' + i + '].Ancho', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Ancho);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_de_Pistas_de_AterrizajeInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Pistas_de_Aterrizaje("Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeMotivo_de_Registro').val()
        ,Tipo: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeTipo').val()
        ,Suelo: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeSuelo').val()
        ,Descripcion: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeDescripcion').val()
        ,Localizacion_1: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeLocalizacion_1').val()
        ,Latitud: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeLatitud').val()
        ,Longitud: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeLongitud').val()
        ,Orientacion_de: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeOrientacion_de').val()
        ,Orientacion: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeOrientacion').val()
        ,Largo: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeLargo').val()
        ,Ancho: $('#Detalle_Aseguramiento_de_Pistas_de_AterrizajeAncho').val()

    }

    Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_de_Pistas_de_AterrizajerowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_de_Pistas_de_Aterrizaje-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_de_Pistas_de_Aterrizaje-form').modal('hide');
    Detalle_Aseguramiento_de_Pistas_de_AterrizajeEditRow(rowIndex);
    Detalle_Aseguramiento_de_Pistas_de_AterrizajeInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_de_Pistas_de_AterrizajeRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_de_Pistas_de_AterrizajeTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_de_Pistas_de_Aterrizaje MultiRow
//Begin Declarations for Foreigns fields for Detalle_Aseguramiento_Otros MultiRow
var Detalle_Aseguramiento_OtroscountRowsChecked = 0;

function GetDetalle_Aseguramiento_Otros_Motivo_de_RegistroName(Id) {
    for (var i = 0; i < Detalle_Aseguramiento_Otros_Motivo_de_RegistroItems.length; i++) {
        if (Detalle_Aseguramiento_Otros_Motivo_de_RegistroItems[i].Clave == Id) {
            return Detalle_Aseguramiento_Otros_Motivo_de_RegistroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Aseguramiento_Otros_Motivo_de_RegistroDropDown() {
    var Detalle_Aseguramiento_Otros_Motivo_de_RegistroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Aseguramiento_Otros_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Aseguramiento_Otros_Motivo_de_RegistroDropdown);
    if(Detalle_Aseguramiento_Otros_Motivo_de_RegistroItems != null)
    {
       for (var i = 0; i < Detalle_Aseguramiento_Otros_Motivo_de_RegistroItems.length; i++) {
           $('<option />', { value: Detalle_Aseguramiento_Otros_Motivo_de_RegistroItems[i].Clave, text:    Detalle_Aseguramiento_Otros_Motivo_de_RegistroItems[i].Descripcion }).appendTo(Detalle_Aseguramiento_Otros_Motivo_de_RegistroDropdown);
       }
    }
    return Detalle_Aseguramiento_Otros_Motivo_de_RegistroDropdown;
}






function GetInsertDetalle_Aseguramiento_OtrosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Aseguramiento_Otros_Motivo_de_RegistroDropDown()).addClass('Detalle_Aseguramiento_Otros_Motivo_de_Registro Motivo_de_Registro').attr('id', 'Detalle_Aseguramiento_Otros_Motivo_de_Registro_' + index).attr('data-field', 'Motivo_de_Registro').after($.parseHTML(addNew('Detalle_Aseguramiento_Otros', 'Motivo_de_Registro', 'Motivo_de_Registro', 268355)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Otros_Tipo Tipo').attr('id', 'Detalle_Aseguramiento_Otros_Tipo_' + index).attr('data-field', 'Tipo');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Otros_Unidad_de_medida Unidad_de_medida').attr('id', 'Detalle_Aseguramiento_Otros_Unidad_de_medida_' + index).attr('data-field', 'Unidad_de_medida');
    columnData[3] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Aseguramiento_Otros_Cantidad Cantidad').attr('id', 'Detalle_Aseguramiento_Otros_Cantidad_' + index).attr('data-field', 'Cantidad');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_Aseguramiento_Otros_Descripcion Descripcion').attr('id', 'Detalle_Aseguramiento_Otros_Descripcion_' + index).attr('data-field', 'Descripcion');


    initiateUIControls();
    return columnData;
}

function Detalle_Aseguramiento_OtrosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Otros("Detalle_Aseguramiento_Otros_", "_" + rowIndex)) {
    var iPage = Detalle_Aseguramiento_OtrosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Aseguramiento_Otros';
    var prevData = Detalle_Aseguramiento_OtrosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_OtrosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro:  data.childNodes[counter++].childNodes[0].value
        ,Tipo:  data.childNodes[counter++].childNodes[0].value
        ,Unidad_de_medida:  data.childNodes[counter++].childNodes[0].value
        ,Cantidad: data.childNodes[counter++].childNodes[0].value
        ,Descripcion:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Aseguramiento_OtrosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_OtrosrowCreationGrid(data, newData, rowIndex);
    Detalle_Aseguramiento_OtrosTable.fnPageChange(iPage);
    Detalle_Aseguramiento_OtroscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Otros("Detalle_Aseguramiento_Otros_", "_" + rowIndex);
  }
}

function Detalle_Aseguramiento_OtrosCancelRow(rowIndex) {
    var prevData = Detalle_Aseguramiento_OtrosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_OtrosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Aseguramiento_OtrosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Aseguramiento_OtrosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Aseguramiento_OtrosGrid(Detalle_Aseguramiento_OtrosTable.fnGetData());
    Detalle_Aseguramiento_OtroscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Aseguramiento_OtrosFromDataTable() {
    var Detalle_Aseguramiento_OtrosData = [];
    var gridData = Detalle_Aseguramiento_OtrosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Aseguramiento_OtrosData.push({
                Clave: gridData[i].Clave

                ,Motivo_de_Registro: gridData[i].Motivo_de_Registro
                ,Tipo: gridData[i].Tipo
                ,Unidad_de_medida: gridData[i].Unidad_de_medida
                ,Cantidad: gridData[i].Cantidad
                ,Descripcion: gridData[i].Descripcion

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Aseguramiento_OtrosData.length; i++) {
        if (removedDetalle_Aseguramiento_OtrosData[i] != null && removedDetalle_Aseguramiento_OtrosData[i].Clave > 0)
            Detalle_Aseguramiento_OtrosData.push({
                Clave: removedDetalle_Aseguramiento_OtrosData[i].Clave

                ,Motivo_de_Registro: removedDetalle_Aseguramiento_OtrosData[i].Motivo_de_Registro
                ,Tipo: removedDetalle_Aseguramiento_OtrosData[i].Tipo
                ,Unidad_de_medida: removedDetalle_Aseguramiento_OtrosData[i].Unidad_de_medida
                ,Cantidad: removedDetalle_Aseguramiento_OtrosData[i].Cantidad
                ,Descripcion: removedDetalle_Aseguramiento_OtrosData[i].Descripcion

                , Removed: true
            });
    }	

    return Detalle_Aseguramiento_OtrosData;
}

function Detalle_Aseguramiento_OtrosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Aseguramiento_OtrosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Aseguramiento_OtroscountRowsChecked++;
    var Detalle_Aseguramiento_OtrosRowElement = "Detalle_Aseguramiento_Otros_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_OtrosTable.fnGetData(rowIndexTable );
    var row = Detalle_Aseguramiento_OtrosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Aseguramiento_Otros_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Aseguramiento_OtrosGetUpdateRowControls(prevData, "Detalle_Aseguramiento_Otros_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Aseguramiento_OtrosRowElement + "')){ Detalle_Aseguramiento_OtrosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Aseguramiento_OtrosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Aseguramiento_OtrosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Aseguramiento_OtrosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Aseguramiento_OtrosValidation();
    initiateUIControls();
    $('.Detalle_Aseguramiento_Otros' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Otros(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Aseguramiento_OtrosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Aseguramiento_OtrosTable.fnGetData().length;
    Detalle_Aseguramiento_OtrosfnClickAddRow();
    GetAddDetalle_Aseguramiento_OtrosPopup(currentRowIndex, 0);
}

function Detalle_Aseguramiento_OtrosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Aseguramiento_OtrosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Aseguramiento_OtrosRowElement = "Detalle_Aseguramiento_Otros_" + rowIndex.toString();
    var prevData = Detalle_Aseguramiento_OtrosTable.fnGetData(rowIndexTable);
    GetAddDetalle_Aseguramiento_OtrosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Aseguramiento_OtrosMotivo_de_Registro').val(prevData.Motivo_de_Registro);
    $('#Detalle_Aseguramiento_OtrosTipo').val(prevData.Tipo);
    $('#Detalle_Aseguramiento_OtrosUnidad_de_medida').val(prevData.Unidad_de_medida);
    $('#Detalle_Aseguramiento_OtrosCantidad').val(prevData.Cantidad);
    $('#Detalle_Aseguramiento_OtrosDescripcion').val(prevData.Descripcion);

    initiateUIControls();







}

function Detalle_Aseguramiento_OtrosAddInsertRow() {
    if (Detalle_Aseguramiento_OtrosinsertRowCurrentIndex < 1)
    {
        Detalle_Aseguramiento_OtrosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Motivo_de_Registro: ""
        ,Tipo: ""
        ,Unidad_de_medida: ""
        ,Cantidad: ""
        ,Descripcion: ""

    }
}

function Detalle_Aseguramiento_OtrosfnClickAddRow() {
    Detalle_Aseguramiento_OtroscountRowsChecked++;
    Detalle_Aseguramiento_OtrosTable.fnAddData(Detalle_Aseguramiento_OtrosAddInsertRow(), true);
    Detalle_Aseguramiento_OtrosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Aseguramiento_OtrosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Aseguramiento_OtrosGrid tbody tr:nth-of-type(' + (Detalle_Aseguramiento_OtrosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Otros("Detalle_Aseguramiento_Otros_", "_" + Detalle_Aseguramiento_OtrosinsertRowCurrentIndex);
}

function Detalle_Aseguramiento_OtrosClearGridData() {
    Detalle_Aseguramiento_OtrosData = [];
    Detalle_Aseguramiento_OtrosdeletedItem = [];
    Detalle_Aseguramiento_OtrosDataMain = [];
    Detalle_Aseguramiento_OtrosDataMainPages = [];
    Detalle_Aseguramiento_OtrosnewItemCount = 0;
    Detalle_Aseguramiento_OtrosmaxItemIndex = 0;
    $("#Detalle_Aseguramiento_OtrosGrid").DataTable().clear();
    $("#Detalle_Aseguramiento_OtrosGrid").DataTable().destroy();
}

//Used to Get Aseguramientos Information
function GetDetalle_Aseguramiento_Otros() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Aseguramiento_OtrosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Aseguramiento_OtrosData[i].Clave);

        form_data.append('[' + i + '].Motivo_de_Registro', Detalle_Aseguramiento_OtrosData[i].Motivo_de_Registro);
        form_data.append('[' + i + '].Tipo', Detalle_Aseguramiento_OtrosData[i].Tipo);
        form_data.append('[' + i + '].Unidad_de_medida', Detalle_Aseguramiento_OtrosData[i].Unidad_de_medida);
        form_data.append('[' + i + '].Cantidad', Detalle_Aseguramiento_OtrosData[i].Cantidad);
        form_data.append('[' + i + '].Descripcion', Detalle_Aseguramiento_OtrosData[i].Descripcion);

        form_data.append('[' + i + '].Removed', Detalle_Aseguramiento_OtrosData[i].Removed);
    }
    return form_data;
}
function Detalle_Aseguramiento_OtrosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Otros("Detalle_Aseguramiento_OtrosTable", rowIndex)) {
    var prevData = Detalle_Aseguramiento_OtrosTable.fnGetData(rowIndex);
    var data = Detalle_Aseguramiento_OtrosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Motivo_de_Registro: $('#Detalle_Aseguramiento_OtrosMotivo_de_Registro').val()
        ,Tipo: $('#Detalle_Aseguramiento_OtrosTipo').val()
        ,Unidad_de_medida: $('#Detalle_Aseguramiento_OtrosUnidad_de_medida').val()
        ,Cantidad: $('#Detalle_Aseguramiento_OtrosCantidad').val()
        ,Descripcion: $('#Detalle_Aseguramiento_OtrosDescripcion').val()

    }

    Detalle_Aseguramiento_OtrosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Aseguramiento_OtrosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Aseguramiento_Otros-form').modal({ show: false });
    $('#AddDetalle_Aseguramiento_Otros-form').modal('hide');
    Detalle_Aseguramiento_OtrosEditRow(rowIndex);
    Detalle_Aseguramiento_OtrosInsertRow(rowIndex);
    //}
}
function Detalle_Aseguramiento_OtrosRemoveAddRow(rowIndex) {
    Detalle_Aseguramiento_OtrosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Aseguramiento_Otros MultiRow


$(function () {
    function Detalle_Aseguramiento_Medios_de_TransporteinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_Medios_de_TransporteDataMain.length != totalCount && !Detalle_Aseguramiento_Medios_de_TransporteDataMainInitialized) {
            Detalle_Aseguramiento_Medios_de_TransporteDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_Medios_de_TransporteDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_Medios_de_TransporteremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_Medios_de_TransportedeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_Medios_de_TransporteDataMain.length; i++) {
                if (Detalle_Aseguramiento_Medios_de_TransporteDataMain[i] != null && Detalle_Aseguramiento_Medios_de_TransporteDataMain[i].Id == Detalle_Aseguramiento_Medios_de_TransportedeletedItem[j]) {
                    hDetalle_Aseguramiento_Medios_de_TransporteDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_Medios_de_TransportecopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_Medios_de_TransporteDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_Medios_de_TransporteDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_Medios_de_TransportegetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_Medios_de_TransporteArray();

        for (var i = 0; i < Detalle_Aseguramiento_Medios_de_TransporteData.length; i++) {
            if (Detalle_Aseguramiento_Medios_de_TransporteData[i].Removed == null || Detalle_Aseguramiento_Medios_de_TransporteData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_Medios_de_TransporteData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_Medios_de_TransportepushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_Medios_de_TransporteDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_Medios_de_TransporteDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_de_Drogas_InvolucradasinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_de_Drogas_InvolucradasDataMain.length != totalCount && !Detalle_Aseguramiento_de_Drogas_InvolucradasDataMainInitialized) {
            Detalle_Aseguramiento_de_Drogas_InvolucradasDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_de_Drogas_InvolucradasDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_de_Drogas_InvolucradasremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_de_Drogas_InvolucradasdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_InvolucradasDataMain.length; i++) {
                if (Detalle_Aseguramiento_de_Drogas_InvolucradasDataMain[i] != null && Detalle_Aseguramiento_de_Drogas_InvolucradasDataMain[i].Id == Detalle_Aseguramiento_de_Drogas_InvolucradasdeletedItem[j]) {
                    hDetalle_Aseguramiento_de_Drogas_InvolucradasDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_de_Drogas_InvolucradascopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_InvolucradasDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_de_Drogas_InvolucradasDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_de_Drogas_InvolucradasgetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_de_Drogas_InvolucradasArray();

        for (var i = 0; i < Detalle_Aseguramiento_de_Drogas_InvolucradasData.length; i++) {
            if (Detalle_Aseguramiento_de_Drogas_InvolucradasData[i].Removed == null || Detalle_Aseguramiento_de_Drogas_InvolucradasData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_de_Drogas_InvolucradasData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_de_Drogas_InvolucradaspushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_de_Drogas_InvolucradasDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_de_Drogas_InvolucradasDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_Armas_InvolucradasinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_Armas_InvolucradasDataMain.length != totalCount && !Detalle_Aseguramiento_Armas_InvolucradasDataMainInitialized) {
            Detalle_Aseguramiento_Armas_InvolucradasDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_Armas_InvolucradasDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_Armas_InvolucradasremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_Armas_InvolucradasdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_Armas_InvolucradasDataMain.length; i++) {
                if (Detalle_Aseguramiento_Armas_InvolucradasDataMain[i] != null && Detalle_Aseguramiento_Armas_InvolucradasDataMain[i].Id == Detalle_Aseguramiento_Armas_InvolucradasdeletedItem[j]) {
                    hDetalle_Aseguramiento_Armas_InvolucradasDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_Armas_InvolucradascopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_Armas_InvolucradasDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_Armas_InvolucradasDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_Armas_InvolucradasgetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_Armas_InvolucradasArray();

        for (var i = 0; i < Detalle_Aseguramiento_Armas_InvolucradasData.length; i++) {
            if (Detalle_Aseguramiento_Armas_InvolucradasData[i].Removed == null || Detalle_Aseguramiento_Armas_InvolucradasData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_Armas_InvolucradasData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_Armas_InvolucradaspushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_Armas_InvolucradasDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_Armas_InvolucradasDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_Artefactos_y_ExplosivosinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMain.length != totalCount && !Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMainInitialized) {
            Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_Artefactos_y_ExplosivosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_Artefactos_y_ExplosivosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMain.length; i++) {
                if (Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMain[i] != null && Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMain[i].Id == Detalle_Aseguramiento_Artefactos_y_ExplosivosdeletedItem[j]) {
                    hDetalle_Aseguramiento_Artefactos_y_ExplosivosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_Artefactos_y_ExplosivoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_Artefactos_y_ExplosivosgetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_Artefactos_y_ExplosivosArray();

        for (var i = 0; i < Detalle_Aseguramiento_Artefactos_y_ExplosivosData.length; i++) {
            if (Detalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Removed == null || Detalle_Aseguramiento_Artefactos_y_ExplosivosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_Artefactos_y_ExplosivosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_Artefactos_y_ExplosivospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_Artefactos_y_ExplosivosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_de_Cargador_CartuchosinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_de_Cargador_CartuchosDataMain.length != totalCount && !Detalle_Aseguramiento_de_Cargador_CartuchosDataMainInitialized) {
            Detalle_Aseguramiento_de_Cargador_CartuchosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_de_Cargador_CartuchosDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_de_Cargador_CartuchosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_de_Cargador_CartuchosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_de_Cargador_CartuchosDataMain.length; i++) {
                if (Detalle_Aseguramiento_de_Cargador_CartuchosDataMain[i] != null && Detalle_Aseguramiento_de_Cargador_CartuchosDataMain[i].Id == Detalle_Aseguramiento_de_Cargador_CartuchosdeletedItem[j]) {
                    hDetalle_Aseguramiento_de_Cargador_CartuchosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_de_Cargador_CartuchoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_de_Cargador_CartuchosDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_de_Cargador_CartuchosDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_de_Cargador_CartuchosgetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_de_Cargador_CartuchosArray();

        for (var i = 0; i < Detalle_Aseguramiento_de_Cargador_CartuchosData.length; i++) {
            if (Detalle_Aseguramiento_de_Cargador_CartuchosData[i].Removed == null || Detalle_Aseguramiento_de_Cargador_CartuchosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_de_Cargador_CartuchosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_de_Cargador_CartuchospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_de_Cargador_CartuchosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_de_Cargador_CartuchosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_Objetos_AseguradosinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_Objetos_AseguradosDataMain.length != totalCount && !Detalle_Aseguramiento_Objetos_AseguradosDataMainInitialized) {
            Detalle_Aseguramiento_Objetos_AseguradosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_Objetos_AseguradosDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_Objetos_AseguradosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_Objetos_AseguradosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_Objetos_AseguradosDataMain.length; i++) {
                if (Detalle_Aseguramiento_Objetos_AseguradosDataMain[i] != null && Detalle_Aseguramiento_Objetos_AseguradosDataMain[i].Id == Detalle_Aseguramiento_Objetos_AseguradosdeletedItem[j]) {
                    hDetalle_Aseguramiento_Objetos_AseguradosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_Objetos_AseguradoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_Objetos_AseguradosDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_Objetos_AseguradosDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_Objetos_AseguradosgetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_Objetos_AseguradosArray();

        for (var i = 0; i < Detalle_Aseguramiento_Objetos_AseguradosData.length; i++) {
            if (Detalle_Aseguramiento_Objetos_AseguradosData[i].Removed == null || Detalle_Aseguramiento_Objetos_AseguradosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_Objetos_AseguradosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_Objetos_AseguradospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_Objetos_AseguradosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_Objetos_AseguradosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_DocumentosinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_DocumentosDataMain.length != totalCount && !Detalle_Aseguramiento_DocumentosDataMainInitialized) {
            Detalle_Aseguramiento_DocumentosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_DocumentosDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_DocumentosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_DocumentosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_DocumentosDataMain.length; i++) {
                if (Detalle_Aseguramiento_DocumentosDataMain[i] != null && Detalle_Aseguramiento_DocumentosDataMain[i].Id == Detalle_Aseguramiento_DocumentosdeletedItem[j]) {
                    hDetalle_Aseguramiento_DocumentosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_DocumentoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_DocumentosDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_DocumentosDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_DocumentosgetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_DocumentosArray();

        for (var i = 0; i < Detalle_Aseguramiento_DocumentosData.length; i++) {
            if (Detalle_Aseguramiento_DocumentosData[i].Removed == null || Detalle_Aseguramiento_DocumentosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_DocumentosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_DocumentospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_DocumentosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_DocumentosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_MonedainitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_MonedaDataMain.length != totalCount && !Detalle_Aseguramiento_MonedaDataMainInitialized) {
            Detalle_Aseguramiento_MonedaDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_MonedaDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_MonedaremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_MonedadeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_MonedaDataMain.length; i++) {
                if (Detalle_Aseguramiento_MonedaDataMain[i] != null && Detalle_Aseguramiento_MonedaDataMain[i].Id == Detalle_Aseguramiento_MonedadeletedItem[j]) {
                    hDetalle_Aseguramiento_MonedaDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_MonedacopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_MonedaDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_MonedaDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_MonedagetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_MonedaArray();

        for (var i = 0; i < Detalle_Aseguramiento_MonedaData.length; i++) {
            if (Detalle_Aseguramiento_MonedaData[i].Removed == null || Detalle_Aseguramiento_MonedaData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_MonedaData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_MonedapushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_MonedaDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_MonedaDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_Otros_AseguramientosinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_Otros_AseguramientosDataMain.length != totalCount && !Detalle_Aseguramiento_Otros_AseguramientosDataMainInitialized) {
            Detalle_Aseguramiento_Otros_AseguramientosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_Otros_AseguramientosDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_Otros_AseguramientosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_Otros_AseguramientosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_Otros_AseguramientosDataMain.length; i++) {
                if (Detalle_Aseguramiento_Otros_AseguramientosDataMain[i] != null && Detalle_Aseguramiento_Otros_AseguramientosDataMain[i].Id == Detalle_Aseguramiento_Otros_AseguramientosdeletedItem[j]) {
                    hDetalle_Aseguramiento_Otros_AseguramientosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_Otros_AseguramientoscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_Otros_AseguramientosDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_Otros_AseguramientosDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_Otros_AseguramientosgetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_Otros_AseguramientosArray();

        for (var i = 0; i < Detalle_Aseguramiento_Otros_AseguramientosData.length; i++) {
            if (Detalle_Aseguramiento_Otros_AseguramientosData[i].Removed == null || Detalle_Aseguramiento_Otros_AseguramientosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_Otros_AseguramientosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_Otros_AseguramientospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_Otros_AseguramientosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_Otros_AseguramientosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_Electronicos_y_MultimediainitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_Electronicos_y_MultimediaDataMain.length != totalCount && !Detalle_Aseguramiento_Electronicos_y_MultimediaDataMainInitialized) {
            Detalle_Aseguramiento_Electronicos_y_MultimediaDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_Electronicos_y_MultimediaDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_Electronicos_y_MultimediaremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_Electronicos_y_MultimediadeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_Electronicos_y_MultimediaDataMain.length; i++) {
                if (Detalle_Aseguramiento_Electronicos_y_MultimediaDataMain[i] != null && Detalle_Aseguramiento_Electronicos_y_MultimediaDataMain[i].Id == Detalle_Aseguramiento_Electronicos_y_MultimediadeletedItem[j]) {
                    hDetalle_Aseguramiento_Electronicos_y_MultimediaDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_Electronicos_y_MultimediacopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_Electronicos_y_MultimediaDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_Electronicos_y_MultimediaDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_Electronicos_y_MultimediagetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_Electronicos_y_MultimediaArray();

        for (var i = 0; i < Detalle_Aseguramiento_Electronicos_y_MultimediaData.length; i++) {
            if (Detalle_Aseguramiento_Electronicos_y_MultimediaData[i].Removed == null || Detalle_Aseguramiento_Electronicos_y_MultimediaData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_Electronicos_y_MultimediaData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_Electronicos_y_MultimediapushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_Electronicos_y_MultimediaDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_Electronicos_y_MultimediaDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_PirateriainitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_PirateriaDataMain.length != totalCount && !Detalle_Aseguramiento_PirateriaDataMainInitialized) {
            Detalle_Aseguramiento_PirateriaDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_PirateriaDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_PirateriaremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_PirateriadeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_PirateriaDataMain.length; i++) {
                if (Detalle_Aseguramiento_PirateriaDataMain[i] != null && Detalle_Aseguramiento_PirateriaDataMain[i].Id == Detalle_Aseguramiento_PirateriadeletedItem[j]) {
                    hDetalle_Aseguramiento_PirateriaDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_PirateriacopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_PirateriaDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_PirateriaDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_PirateriagetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_PirateriaArray();

        for (var i = 0; i < Detalle_Aseguramiento_PirateriaData.length; i++) {
            if (Detalle_Aseguramiento_PirateriaData[i].Removed == null || Detalle_Aseguramiento_PirateriaData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_PirateriaData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_PirateriapushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_PirateriaDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_PirateriaDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_InmueblesinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_InmueblesDataMain.length != totalCount && !Detalle_Aseguramiento_InmueblesDataMainInitialized) {
            Detalle_Aseguramiento_InmueblesDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_InmueblesDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_InmueblesremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_InmueblesdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_InmueblesDataMain.length; i++) {
                if (Detalle_Aseguramiento_InmueblesDataMain[i] != null && Detalle_Aseguramiento_InmueblesDataMain[i].Id == Detalle_Aseguramiento_InmueblesdeletedItem[j]) {
                    hDetalle_Aseguramiento_InmueblesDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_InmueblescopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_InmueblesDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_InmueblesDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_InmueblesgetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_InmueblesArray();

        for (var i = 0; i < Detalle_Aseguramiento_InmueblesData.length; i++) {
            if (Detalle_Aseguramiento_InmueblesData[i].Removed == null || Detalle_Aseguramiento_InmueblesData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_InmueblesData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_InmueblespushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_InmueblesDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_InmueblesDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_de_PlantiosinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_de_PlantiosDataMain.length != totalCount && !Detalle_Aseguramiento_de_PlantiosDataMainInitialized) {
            Detalle_Aseguramiento_de_PlantiosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_de_PlantiosDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_de_PlantiosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_de_PlantiosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_de_PlantiosDataMain.length; i++) {
                if (Detalle_Aseguramiento_de_PlantiosDataMain[i] != null && Detalle_Aseguramiento_de_PlantiosDataMain[i].Id == Detalle_Aseguramiento_de_PlantiosdeletedItem[j]) {
                    hDetalle_Aseguramiento_de_PlantiosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_de_PlantioscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_de_PlantiosDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_de_PlantiosDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_de_PlantiosgetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_de_PlantiosArray();

        for (var i = 0; i < Detalle_Aseguramiento_de_PlantiosData.length; i++) {
            if (Detalle_Aseguramiento_de_PlantiosData[i].Removed == null || Detalle_Aseguramiento_de_PlantiosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_de_PlantiosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_de_PlantiospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_de_PlantiosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_de_PlantiosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_de_Pistas_de_AterrizajeinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain.length != totalCount && !Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMainInitialized) {
            Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_de_Pistas_de_AterrizajeremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_de_Pistas_de_AterrizajedeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain.length; i++) {
                if (Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain[i] != null && Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain[i].Id == Detalle_Aseguramiento_de_Pistas_de_AterrizajedeletedItem[j]) {
                    hDetalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_de_Pistas_de_AterrizajecopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_de_Pistas_de_AterrizajegetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_de_Pistas_de_AterrizajeArray();

        for (var i = 0; i < Detalle_Aseguramiento_de_Pistas_de_AterrizajeData.length; i++) {
            if (Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Removed == null || Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_de_Pistas_de_AterrizajeData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_de_Pistas_de_AterrizajepushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_de_Pistas_de_AterrizajeDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Aseguramiento_OtrosinitializeMainArray(totalCount) {
        if (Detalle_Aseguramiento_OtrosDataMain.length != totalCount && !Detalle_Aseguramiento_OtrosDataMainInitialized) {
            Detalle_Aseguramiento_OtrosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Aseguramiento_OtrosDataMain[i] = null;
            }
        }
    }
    function Detalle_Aseguramiento_OtrosremoveFromMainArray() {
        for (var j = 0; j < Detalle_Aseguramiento_OtrosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Aseguramiento_OtrosDataMain.length; i++) {
                if (Detalle_Aseguramiento_OtrosDataMain[i] != null && Detalle_Aseguramiento_OtrosDataMain[i].Id == Detalle_Aseguramiento_OtrosdeletedItem[j]) {
                    hDetalle_Aseguramiento_OtrosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Aseguramiento_OtroscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Aseguramiento_OtrosDataMain.length; i++) {
            data[i] = Detalle_Aseguramiento_OtrosDataMain[i];

        }
        return data;
    }
    function Detalle_Aseguramiento_OtrosgetNewResult() {
        var newData = copyMainDetalle_Aseguramiento_OtrosArray();

        for (var i = 0; i < Detalle_Aseguramiento_OtrosData.length; i++) {
            if (Detalle_Aseguramiento_OtrosData[i].Removed == null || Detalle_Aseguramiento_OtrosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Aseguramiento_OtrosData[i]);
            }
        }
        return newData;
    }
    function Detalle_Aseguramiento_OtrospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Aseguramiento_OtrosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Aseguramiento_OtrosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteExpedienteData = [];
function GetAutoCompleteAseguramientos_Expediente_expediente_ministerio_publicoData(data) {
	AutoCompleteExpedienteData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteExpedienteData.push({
            id: data[i].clave,
            text: data[i].nic
        });
    }
    return AutoCompleteExpedienteData;
}
var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompleteAseguramientos_Usuario_que_Registra_Spartan_UserData(data) {
	AutoCompleteUsuario_que_RegistraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_RegistraData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_RegistraData;
}
//Grid GetAutocomplete
var AutoCompleteMarcaData = [];
function GetAutoCompleteDetalle_Aseguramiento_Medios_de_Transporte_Marca_Marca_de_Medio_de_transporteData(data) {
	AutoCompleteMarcaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMarcaData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteMarcaData;
}
var AutoCompleteModeloData = [];
function GetAutoCompleteDetalle_Aseguramiento_Medios_de_Transporte_Modelo_Modelo_de_medio_de_transporteData(data) {
	AutoCompleteModeloData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteModeloData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteModeloData;
}

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete
var AutoCompleteEstadoData = [];
function GetAutoCompleteDetalle_Aseguramiento_Inmuebles_Estado_EstadoData(data) {
	AutoCompleteEstadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstadoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstadoData;
}
var AutoCompleteMunicipioData = [];
function GetAutoCompleteDetalle_Aseguramiento_Inmuebles_Municipio_MunicipioData(data) {
	AutoCompleteMunicipioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioData;
}
var AutoCompleteColoniaData = [];
function GetAutoCompleteDetalle_Aseguramiento_Inmuebles_Colonia_ColoniaData(data) {
	AutoCompleteColoniaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaData;
}

//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Aseguramientos_cmbLabelSelect").val();
    var dropDown = '<select id="' + elementKey + '" class="form-control"><option value="">' + labelSelect + '</option></select>';
    return dropDown;
}

function GetGridDatePicker() {
    return "<input type='text' class='fullWidth gridDatePicker xyz form-control' >";
}
function GetGridTimePicker() {
    return "<input type='text' class='fullWidth gridTimePicker form-control'  data-autoclose='true'>";
}
function GetGridTextArea() {
    return "<textarea rows='2'></textarea>";
}
function GetGridCheckBox() {
    return " <input type='checkbox' class='fullWidth'> ";
}
function GetFileUploader() {
    return "<input type='file' class='fullWidth'>";
}

function GetGridAutoComplete(data,field, id) {
    
    var dataMain = data == null ? "Select" : data;
    id ==  (id==null   || id==undefined)? "":id;
    
     return "<select class='AutoComplete fullWidth select2-dropDown " + field + " form-control' data-val='true'  ><option value='" + id +"'>" + dataMain + "</option></select>";
}

function ClearControls() {
    $("#ReferenceClave").val("0");
    $('#CreateAseguramientos')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Expediente').empty();
    $("#Expediente").append('<option value=""></option>');
    $('#Expediente').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_Aseguramiento_Medios_de_TransporteClearGridData();
                Detalle_Aseguramiento_de_Drogas_InvolucradasClearGridData();
                Detalle_Aseguramiento_Armas_InvolucradasClearGridData();
                Detalle_Aseguramiento_Artefactos_y_ExplosivosClearGridData();
                Detalle_Aseguramiento_de_Cargador_CartuchosClearGridData();
                Detalle_Aseguramiento_Objetos_AseguradosClearGridData();
                Detalle_Aseguramiento_DocumentosClearGridData();
                Detalle_Aseguramiento_MonedaClearGridData();
                Detalle_Aseguramiento_Otros_AseguramientosClearGridData();
                Detalle_Aseguramiento_Electronicos_y_MultimediaClearGridData();
                Detalle_Aseguramiento_PirateriaClearGridData();
                Detalle_Aseguramiento_InmueblesClearGridData();
                Detalle_Aseguramiento_de_PlantiosClearGridData();
                Detalle_Aseguramiento_de_Pistas_de_AterrizajeClearGridData();
                Detalle_Aseguramiento_OtrosClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateAseguramientos').trigger('reset');
    $('#CreateAseguramientos').find(':input').each(function () {
        switch (this.type) {
            case 'password':
            case 'number':
            case 'select-multiple':
            case 'select-one':
            case 'select':
            case 'text':
            case 'textarea':
                $(this).val('');
				for (instance in CKEDITOR.instances) {
                    CKEDITOR.instances[instance].updateElement();
                    CKEDITOR.instances[instance].setData('');
                }
                break;
            case 'checkbox':
            case 'radio':
                this.checked = false;
        }
    });
}
function CheckValidation() {
    var $myForm = $('#CreateAseguramientos');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_Aseguramiento_Medios_de_TransportecountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Medios_de_Transporte();
        return false;
    }
    if (Detalle_Aseguramiento_de_Drogas_InvolucradascountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_de_Drogas_Involucradas();
        return false;
    }
    if (Detalle_Aseguramiento_Armas_InvolucradascountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Armas_Involucradas();
        return false;
    }
    if (Detalle_Aseguramiento_Artefactos_y_ExplosivoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Artefactos_y_Explosivos();
        return false;
    }
    if (Detalle_Aseguramiento_de_Cargador_CartuchoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_de_Cargador_Cartuchos();
        return false;
    }
    if (Detalle_Aseguramiento_Objetos_AseguradoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Objetos_Asegurados();
        return false;
    }
    if (Detalle_Aseguramiento_DocumentoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Documentos();
        return false;
    }
    if (Detalle_Aseguramiento_MonedacountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Moneda();
        return false;
    }
    if (Detalle_Aseguramiento_Otros_AseguramientoscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Otros_Aseguramientos();
        return false;
    }
    if (Detalle_Aseguramiento_Electronicos_y_MultimediacountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Electronicos_y_Multimedia();
        return false;
    }
    if (Detalle_Aseguramiento_PirateriacountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Pirateria();
        return false;
    }
    if (Detalle_Aseguramiento_InmueblescountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Inmuebles();
        return false;
    }
    if (Detalle_Aseguramiento_de_PlantioscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_de_Plantios();
        return false;
    }
    if (Detalle_Aseguramiento_de_Pistas_de_AterrizajecountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_de_Pistas_de_Aterrizaje();
        return false;
    }
    if (Detalle_Aseguramiento_OtroscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Aseguramiento_Otros();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateAseguramientos").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateAseguramientos").on('click', '#AseguramientosCancelar', function () {
	  if (!isPartial) {
        AseguramientosBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateAseguramientos").on('click', '#AseguramientosGuardar', function () {
		$('#AseguramientosGuardar').attr('disabled', true);
		$('#AseguramientosGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendAseguramientosData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						AseguramientosBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#AseguramientosGuardar').removeAttr('disabled');
                        $('#AseguramientosGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Aseguramientos', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_AseguramientosItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_AseguramientosDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#AseguramientosGuardar').removeAttr('disabled');
					$('#AseguramientosGuardar').bind()
				}
		}
		else {
			$('#AseguramientosGuardar').removeAttr('disabled');
			$('#AseguramientosGuardar').bind()
		}
    });
	$("form#CreateAseguramientos").on('click', '#AseguramientosGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendAseguramientosData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_Aseguramiento_Medios_de_TransporteData();
                getDetalle_Aseguramiento_de_Drogas_InvolucradasData();
                getDetalle_Aseguramiento_Armas_InvolucradasData();
                getDetalle_Aseguramiento_Artefactos_y_ExplosivosData();
                getDetalle_Aseguramiento_de_Cargador_CartuchosData();
                getDetalle_Aseguramiento_Objetos_AseguradosData();
                getDetalle_Aseguramiento_DocumentosData();
                getDetalle_Aseguramiento_MonedaData();
                getDetalle_Aseguramiento_Otros_AseguramientosData();
                getDetalle_Aseguramiento_Electronicos_y_MultimediaData();
                getDetalle_Aseguramiento_PirateriaData();
                getDetalle_Aseguramiento_InmueblesData();
                getDetalle_Aseguramiento_de_PlantiosData();
                getDetalle_Aseguramiento_de_Pistas_de_AterrizajeData();
                getDetalle_Aseguramiento_OtrosData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Aseguramientos', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_AseguramientosItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_AseguramientosDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateAseguramientos").on('click', '#AseguramientosGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendAseguramientosData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Expediente').empty();
    $("#Expediente").append('<option value=""></option>');
    $('#Expediente').val('0').trigger('change');
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_Aseguramiento_Medios_de_TransporteClearGridData();
                Detalle_Aseguramiento_de_Drogas_InvolucradasClearGridData();
                Detalle_Aseguramiento_Armas_InvolucradasClearGridData();
                Detalle_Aseguramiento_Artefactos_y_ExplosivosClearGridData();
                Detalle_Aseguramiento_de_Cargador_CartuchosClearGridData();
                Detalle_Aseguramiento_Objetos_AseguradosClearGridData();
                Detalle_Aseguramiento_DocumentosClearGridData();
                Detalle_Aseguramiento_MonedaClearGridData();
                Detalle_Aseguramiento_Otros_AseguramientosClearGridData();
                Detalle_Aseguramiento_Electronicos_y_MultimediaClearGridData();
                Detalle_Aseguramiento_PirateriaClearGridData();
                Detalle_Aseguramiento_InmueblesClearGridData();
                Detalle_Aseguramiento_de_PlantiosClearGridData();
                Detalle_Aseguramiento_de_Pistas_de_AterrizajeClearGridData();
                Detalle_Aseguramiento_OtrosClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_Aseguramiento_Medios_de_TransporteData();
                getDetalle_Aseguramiento_de_Drogas_InvolucradasData();
                getDetalle_Aseguramiento_Armas_InvolucradasData();
                getDetalle_Aseguramiento_Artefactos_y_ExplosivosData();
                getDetalle_Aseguramiento_de_Cargador_CartuchosData();
                getDetalle_Aseguramiento_Objetos_AseguradosData();
                getDetalle_Aseguramiento_DocumentosData();
                getDetalle_Aseguramiento_MonedaData();
                getDetalle_Aseguramiento_Otros_AseguramientosData();
                getDetalle_Aseguramiento_Electronicos_y_MultimediaData();
                getDetalle_Aseguramiento_PirateriaData();
                getDetalle_Aseguramiento_InmueblesData();
                getDetalle_Aseguramiento_de_PlantiosData();
                getDetalle_Aseguramiento_de_Pistas_de_AterrizajeData();
                getDetalle_Aseguramiento_OtrosData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Aseguramientos',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_AseguramientosItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_AseguramientosDropDown().get(0)').innerHTML);                          
					    }	
					}						
			setIsNew();
				});
		}
    });
});

function setIsNew() {
    $('#hdnIsNew').val("True");
	$('#Operation').val("New");
	operation = "New";
}



var mainElementObject;
var childElementObject;
function DisplayElementAttributes(data) {
}

function getElementTable(elementNumber, table) {

    for (var j = 0; j < childElementObject.length; j++) {
        if (childElementObject[j].table == table) {
            return childElementObject[j].elements[elementNumber];
            break;
        }
    }
}

function setRequired(elementNumber, element, elementType, table) {
    //debugger;
    if (elementType == "1") {
        mainElementObject[elementNumber].IsRequired = (mainElementObject[elementNumber].IsRequired == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsRequired == true ? GetTraduction('Required') : GetTraduction('NotRequired')));
        if (!mainElementObject[elementNumber].IsVisible && mainElementObject[elementNumber].IsRequired) {
            setVisible(elementNumber, $(element).parent().parent().find('div.visibleAttribute').find('a'), elementType);
        }
        if (mainElementObject[elementNumber].IsReadOnly && mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '') {
            setReadOnly(elementNumber, $(element).parent().parent().find('div.readOnlyAttribute').find('a'), elementType);
        }
    } else {
        getElementTable(elementNumber, table).IsRequired = (getElementTable(elementNumber, table).IsRequired == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsRequired == true ? GetTraduction('Required') : GetTraduction('NotRequired')));
        if (!getElementTable(elementNumber, table).IsVisible && getElementTable(elementNumber, table).IsRequired) {
            setVisible(elementNumber, $(element).parent().parent().find('div.visibleAttribute').find('a'), elementType);
        }
        if (getElementTable(elementNumber, table).IsReadOnly && getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '') {
            setReadOnly(elementNumber, $(element).parent().parent().find('div.readOnlyAttribute').find('a'), elementType);
        }
    }
}
function setVisible(elementNumber, element, elementType, table) {
    if (elementType == "1") {
        if (mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '' && mainElementObject[elementNumber].IsVisible) {
            showNotification(GetTraduction("messagedNoInVisible"), "error");
            return;
        }
        mainElementObject[elementNumber].IsVisible = (mainElementObject[elementNumber].IsVisible == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsVisible == true ? "Images/Visible.png" : "Images/inVisible.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsVisible == true ? GetTraduction('Visible') : GetTraduction('InVisible')));
    } else {
        if (getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '' && getElementTable(elementNumber, table).IsVisible) {
            showNotification(GetTraduction("messagedNoInVisible"), "error");
            return;
        }
        getElementTable(elementNumber, table).IsVisible = (getElementTable(elementNumber, table).IsVisible == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsVisible == true ? "Images/Visible.png" : "Images/inVisible.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsVisible == true ? GetTraduction('Visible') : GetTraduction('InVisible')));
    }
}
function setReadOnly(elementNumber, element, elementType, table) {
    if (elementType == "1") {
        if (mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '' && !mainElementObject[elementNumber].IsReadOnly) {
            showNotification(GetTraduction("messagedNoReadOnly"), "error");
            return;
        }
        mainElementObject[elementNumber].IsReadOnly = (mainElementObject[elementNumber].IsReadOnly == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsReadOnly == true ?GetTraduction('Disabled') : GetTraduction('Enabled')));
    } else {
        if (getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '' && !getElementTable(elementNumber, table).IsReadOnly) {
            showNotification(GetTraduction("messagedNoReadOnly"), "error");
            return;
        }
        getElementTable(elementNumber, table).IsReadOnly = (getElementTable(elementNumber, table).IsReadOnly == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsReadOnly == true ? GetTraduction('Disabled') : GetTraduction('Enabled')));
    }
}
function setDefaultValue(elementNumber, element, elementType, table) {
    //debugger;
    $('#hdnAttributType').val('1');
    $('#hdnAttributNumber').val(elementNumber);
    $('#lblAttributeType').text(GetTraduction('DefaultValue'));
    if (elementType == "1") {
        $('#txtAttributeValue').val(mainElementObject[elementNumber].DefaultValue);
        $('#hdnElementType').val("1");
    } else {
        $('#txtAttributeValue').val(getElementTable(elementNumber, table).DefaultValue);
        $('#hdnElementType').val("2");
    }
    $('#dvAttributeValue').show();
}
function setHelpText(elementNumber, element, elementType, table) {
    $('#hdnAttributType').val('2');
    $('#hdnAttributNumber').val(elementNumber);
    $('#lblAttributeType').text(GetTraduction('HelpText'));
    if (elementType == "1") {
        $('#txtAttributeValue').val(mainElementObject[elementNumber].HelpText);
        $('#hdnElementType').val("1");
    } else {
        $('#txtAttributeValue').val(getElementTable(elementNumber, table).HelpText);
        $('#hdnElementType').val("2");
    }
    $('#dvAttributeValue').show();
    //$(element).children().attr("src", "" + (mainElementObject[elementNumber].HelpText == '' ? "Images/red-help.png" : "Images/green-help.png") + "");
}
function SaveValue(table) {
    debugger;
    if ($('#hdnElementType').val() == "1") {
        if ($('#hdnAttributType').val() == "1") {
            mainElementObject[$('#hdnAttributNumber').val()].DefaultValue = $('#txtAttributeValue').val();
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[$('#hdnAttributNumber').val()].DefaultValue == '' ? "Images/Not-Default-Value.png" : "Images/default-value.png") + "");
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).attr('title', (mainElementObject[$('#hdnAttributNumber').val()].DefaultValue));
        } else if ($('#hdnAttributType').val() == "2") {
            mainElementObject[$('#hdnAttributNumber').val()].HelpText = $('#txtAttributeValue').val();
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[$('#hdnAttributNumber').val()].HelpText == '' ? "Images/red-help.jpg" : "Images/green-help.png") + "");
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).attr('title', (mainElementObject[$('#hdnAttributNumber').val()].HelpText));
        }
    } else {
        if ($('#hdnAttributType').val() == "1") {
            getElementTable($('#hdnAttributNumber').val(), table).DefaultValue = $('#txtAttributeValue').val();
            console.log(childElementObject[$('#hdnAttributNumber').val()].DefaultValue);
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable($('#hdnAttributNumber').val(), table).DefaultValue == '' ? "Images/Not-Default-Value.png" : "Images/default-value.png") + "");
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).attr('title', (getElementTable($('#hdnAttributNumber').val(), table).DefaultValue));
            console.log($('#hdnAttributNumber').val());
        } else if ($('#hdnAttributType').val() == "2") {
            getElementTable($('#hdnAttributNumber').val(), table).HelpText = $('#txtAttributeValue').val();
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable($('#hdnAttributNumber').val(), table).HelpText == '' ? "Images/red-help.jpg" : "Images/green-help.png") + "");
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).attr('title', (getElementTable($('#hdnAttributNumber').val(), table).HelpText));
        }
    }
    $('#txtAttributeValue').val('');
    $('#dvAttributeValue').hide();
}
function returnAttributeHTML(element, table, number) {
    var mainElementAttributes = '<div class="col-ld-12" style="display:inline-flex;">';
    mainElementAttributes += '<div class="displayAttributes requiredAttribute"><a class="requiredClick" title="' + (element.IsRequired == true ? GetTraduction("Required") : GetTraduction("NotRequired")) + '" onclick="setRequired(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes visibleAttribute"><a class="visibleClick" title="' + (element.IsVisible == true ? GetTraduction("Visible") : GetTraduction("InVisible")) + '" onclick="setVisible(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsVisible == true ? "Images/Visible.png" : "Images/InVisible.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes readOnlyAttribute"><a class="readOnlyClick" title="' + (element.IsReadOnly == true ?GetTraduction("Disabled") :GetTraduction("Enabled")) + '" onclick="setReadOnly(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes defaultValueAttribute"><a id="hlDefaultValueHeader_' + number.toString() + '" class="defaultValueClick" title="' + (element.DefaultValue) + '" onclick="setDefaultValue(' + number.toString() + ', this, 2,  "' + table + '")"><img src="' + $('#hdnApplicationDirectory').val() + (element.DefaultValue != '' && element.DefaultValue != null ? "Images/default-value.png" : "Images/Not-Default-Value.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes helpTextAttribute"><a id="hlHelpTextHeader_' + number.toString() + '" class="helpTextClick" title="' + (element.HelpText) + '" onclick="setHelpText(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.HelpText != '' && element.HelpText != null ? "Images/green-help.png" : "Images/red-help.jpg") + '" alt="" /></a></div>';
    mainElementAttributes += '</div>';
    return mainElementAttributes;
}



var AseguramientosisdisplayBusinessPropery = false;
AseguramientosDisplayBusinessRuleButtons(AseguramientosisdisplayBusinessPropery);
function AseguramientosDisplayBusinessRule() {
    if (!AseguramientosisdisplayBusinessPropery) {
        $('#CreateAseguramientos').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="AseguramientosdisplayBusinessPropery"><button onclick="AseguramientosGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#AseguramientosBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.AseguramientosdisplayBusinessPropery').remove();
    }
    AseguramientosDisplayBusinessRuleButtons(!AseguramientosisdisplayBusinessPropery);
    AseguramientosisdisplayBusinessPropery = (AseguramientosisdisplayBusinessPropery ? false : true);
}
function AseguramientosDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

