

//Begin Declarations for Foreigns fields for Detalle_de_Datos_de_la_Victima_MPI MultiRow
var Detalle_de_Datos_de_la_Victima_MPIcountRowsChecked = 0;







function GetDetalle_de_Datos_de_la_Victima_MPI_GeneroName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_GeneroItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_GeneroDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown;
}

function GetDetalle_de_Datos_de_la_Victima_MPI_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_NacionalidadDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_EscolaridadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_EscolaridadDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_OcupacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_OcupacionDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_PaisItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_PaisDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_EstadoDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown;
}















function GetDetalle_de_Datos_de_la_Victima_MPI_GeneroName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_GeneroItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_GeneroDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown;
}

function GetDetalle_de_Datos_de_la_Victima_MPI_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_NacionalidadDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_EscolaridadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_EscolaridadDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_OcupacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_OcupacionDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_PaisItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_PaisDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_EstadoDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_LocalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_LocalidadItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_LocalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_LocalidadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_LocalidadDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_LocalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_LocalidadDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_LocalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_LocalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_LocalidadItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_LocalidadItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_LocalidadDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_LocalidadDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown;
}








function GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteDropdown;
}



function GetDetalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoDropdown;
}


function GetDetalle_de_Datos_de_la_Victima_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_PaisItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_PaisDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_EstadoDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown;
}








function GetDetalle_de_Datos_de_la_Victima_MPI_Lugar_TipoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_Lugar_TipoDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_Lugar_TipoDropdown;
}






function GetDetalle_de_Datos_de_la_Victima_MPI_GeneroName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_GeneroItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_GeneroDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_GeneroItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_GeneroDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropdown;
}

function GetDetalle_de_Datos_de_la_Victima_MPI_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_NacionalidadDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_NacionalidadDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_EscolaridadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_EscolaridadDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_EscolaridadItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_EscolaridadDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_OcupacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_OcupacionDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_OcupacionItems[i].Descripcion }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_OcupacionDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_PaisItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_PaisDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_PaisDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_EstadoDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_EstadoDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_MunicipioDropdown;
}
function GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaDropDown() {
    var Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown);
    if(Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Datos_de_la_Victima_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_de_la_Victima_MPI_ColoniaDropdown;
}















function GetInsertDetalle_de_Datos_de_la_Victima_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Nombre Nombre').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Nombre_' + index).attr('data-field', 'Nombre');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Apellido_Paterno Apellido_Paterno').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Apellido_Paterno_' + index).attr('data-field', 'Apellido_Paterno');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Apellido_Materno Apellido_Materno').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Apellido_Materno_' + index).attr('data-field', 'Apellido_Materno');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Nombre_Completo Nombre_Completo').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Nombre_Completo_' + index).attr('data-field', 'Nombre_Completo');
    columnData[4] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_de_la_Victima_MPI_Fecha_de_Nacimiento Fecha_de_Nacimiento').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Fecha_de_Nacimiento_' + index).attr('data-field', 'Fecha_de_Nacimiento');
    columnData[5] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_de_la_Victima_MPI_Edad Edad').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Edad_' + index).attr('data-field', 'Edad');
    columnData[6] = $(GetDetalle_de_Datos_de_la_Victima_MPI_GeneroDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Sexo Sexo').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Sexo_' + index).attr('data-field', 'Sexo').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Genero', 'Sexo', 264102)));
    columnData[7] = $(GetDetalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Estado_Civil Estado_Civil').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Estado_Civil_' + index).attr('data-field', 'Estado_Civil').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Estado_Civil', 'Estado_Civil', 264103)));
    columnData[8] = $(GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_Identificacion Tipo_de_Identificacion').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_Identificacion_' + index).attr('data-field', 'Tipo_de_Identificacion').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion', 264104)));
    columnData[9] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_de_Identificacion Numero_de_Identificacion').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_de_Identificacion_' + index).attr('data-field', 'Numero_de_Identificacion');
    columnData[10] = $(GetDetalle_de_Datos_de_la_Victima_MPI_NacionalidadDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Nacionalidad Nacionalidad').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Nacionalidad_' + index).attr('data-field', 'Nacionalidad').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Nacionalidad', 'Nacionalidad', 264106)));
    columnData[11] = $(GetDetalle_de_Datos_de_la_Victima_MPI_EscolaridadDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Escolaridad Escolaridad').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Escolaridad_' + index).attr('data-field', 'Escolaridad').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Escolaridad', 'Escolaridad', 264107)));
    columnData[12] = $(GetDetalle_de_Datos_de_la_Victima_MPI_OcupacionDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Ocupacion Ocupacion').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Ocupacion_' + index).attr('data-field', 'Ocupacion').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Ocupacion', 'Ocupacion', 264108)));
    columnData[13] = $(GetDetalle_de_Datos_de_la_Victima_MPI_PaisDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Pais Pais').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Pais_' + index).attr('data-field', 'Pais').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Pais', 'Pais', 264109)));
    columnData[14] = $(GetDetalle_de_Datos_de_la_Victima_MPI_EstadoDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Estado Estado').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Estado', 'Estado', 264110)));
    columnData[15] = $(GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Municipio Municipio').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Municipio', 'Municipio', 264111)));
    columnData[16] = $(GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Colonia Colonia').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Colonia', 'Colonia', 264112)));
    columnData[17] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_de_la_Victima_MPI_Codigo_Postal Codigo_Postal').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[18] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Calle Calle').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Calle_' + index).attr('data-field', 'Calle');
    columnData[19] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_Exterior Numero_Exterior').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[20] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_Interior Numero_Interior').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[21] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Telefono Telefono').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Telefono_' + index).attr('data-field', 'Telefono');
    columnData[22] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_de_la_Victima_MPI_Extencion Extencion').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Extencion_' + index).attr('data-field', 'Extencion');
    columnData[23] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Celular Celular').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Celular_' + index).attr('data-field', 'Celular');
    columnData[24] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Correo_Electronico Correo_Electronico').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');
    columnData[25] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_de_la_Victima_MPI_Incapaz Incapaz').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Incapaz_' + index).attr('data-field', 'Incapaz');
    columnData[26] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Nombre_del_Tutor Nombre_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Nombre_del_Tutor_' + index).attr('data-field', 'Nombre_del_Tutor');
    columnData[27] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Apellido_Paterno_del_Tutor Apellido_Paterno_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Apellido_Paterno_del_Tutor_' + index).attr('data-field', 'Apellido_Paterno_del_Tutor');
    columnData[28] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Apellido_Materno_del_Tutor Apellido_Materno_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Apellido_Materno_del_Tutor_' + index).attr('data-field', 'Apellido_Materno_del_Tutor');
    columnData[29] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Nombre_Completo_del_Tutor Nombre_Completo_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Nombre_Completo_del_Tutor_' + index).attr('data-field', 'Nombre_Completo_del_Tutor');
    columnData[30] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_de_la_Victima_MPI_Fecha_de_Nacimiento_del_Tutor Fecha_de_Nacimiento_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Fecha_de_Nacimiento_del_Tutor_' + index).attr('data-field', 'Fecha_de_Nacimiento_del_Tutor');
    columnData[31] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_de_la_Victima_MPI_Edad_del_Tutor Edad_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Edad_del_Tutor_' + index).attr('data-field', 'Edad_del_Tutor');
    columnData[32] = $(GetDetalle_de_Datos_de_la_Victima_MPI_GeneroDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Sexo_del_Tutor Sexo_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Sexo_del_Tutor_' + index).attr('data-field', 'Sexo_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Genero', 'Sexo_del_Tutor', 264128)));
    columnData[33] = $(GetDetalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Estado_Civil_del_Tutor Estado_Civil_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Estado_Civil_del_Tutor_' + index).attr('data-field', 'Estado_Civil_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Estado_Civil', 'Estado_Civil_del_Tutor', 264129)));
    columnData[34] = $(GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_Identificacion_del_Tutor Tipo_de_Identificacion_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_Identificacion_del_Tutor_' + index).attr('data-field', 'Tipo_de_Identificacion_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion_del_Tutor', 264130)));
    columnData[35] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_de_Identificacion_del_Tutor Numero_de_Identificacion_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_de_Identificacion_del_Tutor_' + index).attr('data-field', 'Numero_de_Identificacion_del_Tutor');
    columnData[36] = $(GetDetalle_de_Datos_de_la_Victima_MPI_NacionalidadDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Nacionalidad_del_Tutor Nacionalidad_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Nacionalidad_del_Tutor_' + index).attr('data-field', 'Nacionalidad_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Nacionalidad', 'Nacionalidad_del_Tutor', 264132)));
    columnData[37] = $(GetDetalle_de_Datos_de_la_Victima_MPI_EscolaridadDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Escolaridad_del_Tutor Escolaridad_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Escolaridad_del_Tutor_' + index).attr('data-field', 'Escolaridad_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Escolaridad', 'Escolaridad_del_Tutor', 264133)));
    columnData[38] = $(GetDetalle_de_Datos_de_la_Victima_MPI_OcupacionDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Ocupacion_del_Tutor Ocupacion_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Ocupacion_del_Tutor_' + index).attr('data-field', 'Ocupacion_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Ocupacion', 'Ocupacion_del_Tutor', 264134)));
    columnData[39] = $(GetDetalle_de_Datos_de_la_Victima_MPI_PaisDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Pais_del_Tutor Pais_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Pais_del_Tutor_' + index).attr('data-field', 'Pais_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Pais', 'Pais_del_Tutor', 264135)));
    columnData[40] = $(GetDetalle_de_Datos_de_la_Victima_MPI_EstadoDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Estado_del_Tutor Estado_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Estado_del_Tutor_' + index).attr('data-field', 'Estado_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Estado', 'Estado_del_Tutor', 264136)));
    columnData[41] = $(GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Municipio_del_Tutor Municipio_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Municipio_del_Tutor_' + index).attr('data-field', 'Municipio_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Municipio', 'Municipio_del_Tutor', 264137)));
    columnData[42] = $(GetDetalle_de_Datos_de_la_Victima_MPI_LocalidadDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Localidad_del_Tutor Localidad_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Localidad_del_Tutor_' + index).attr('data-field', 'Localidad_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Localidad', 'Localidad_del_Tutor', 264138)));
    columnData[43] = $(GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Colonia_del_Tutor Colonia_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Colonia_del_Tutor_' + index).attr('data-field', 'Colonia_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Colonia', 'Colonia_del_Tutor', 264139)));
    columnData[44] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_de_la_Victima_MPI_Codigo_Postal_del_Tutor Codigo_Postal_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Codigo_Postal_del_Tutor_' + index).attr('data-field', 'Codigo_Postal_del_Tutor');
    columnData[45] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Calle_del_Tutor Calle_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Calle_del_Tutor_' + index).attr('data-field', 'Calle_del_Tutor');
    columnData[46] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_Exterior_del_Tutor Numero_Exterior_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_Exterior_del_Tutor_' + index).attr('data-field', 'Numero_Exterior_del_Tutor');
    columnData[47] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_Interior_del_Tutor Numero_Interior_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_Interior_del_Tutor_' + index).attr('data-field', 'Numero_Interior_del_Tutor');
    columnData[48] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Telefono_del_Tutor Telefono_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Telefono_del_Tutor_' + index).attr('data-field', 'Telefono_del_Tutor');
    columnData[49] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_de_la_Victima_MPI_Extencion_del_Tutor Extencion_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Extencion_del_Tutor_' + index).attr('data-field', 'Extencion_del_Tutor');
    columnData[50] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Celular_del_Tutor Celular_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Celular_del_Tutor_' + index).attr('data-field', 'Celular_del_Tutor');
    columnData[51] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Correo_Electronico_del_Tutor Correo_Electronico_del_Tutor').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Correo_Electronico_del_Tutor_' + index).attr('data-field', 'Correo_Electronico_del_Tutor');
    columnData[52] = $(GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_Compareciente Tipo_de_Compareciente').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_Compareciente_' + index).attr('data-field', 'Tipo_de_Compareciente').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Tipo_de_Compareciente', 'Tipo_de_Compareciente', 264148)));
    columnData[53] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Narrativa_de_los_Hechos Narrativa_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Narrativa_de_los_Hechos_' + index).attr('data-field', 'Narrativa_de_los_Hechos');

    columnData[54] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Titulo_del_Hecho Titulo_del_Hecho').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Titulo_del_Hecho_' + index).attr('data-field', 'Titulo_del_Hecho');
    columnData[55] = $(GetDetalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_Hecho Prioridad_del_Hecho').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Prioridad_del_Hecho_' + index).attr('data-field', 'Prioridad_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Prioridad_del_Hecho', 'Prioridad_del_Hecho', 264152)));
    columnData[56] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_de_la_Victima_MPI_Fecha_del_Hecho Fecha_del_Hecho').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Fecha_del_Hecho_' + index).attr('data-field', 'Fecha_del_Hecho');
    columnData[57] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Datos_de_la_Victima_MPI_Hora_Aproximada_del_Hecho Hora_Aproximada_del_Hecho').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Hora_Aproximada_del_Hecho_' + index).attr('data-field', 'Hora_Aproximada_del_Hecho');
    columnData[58] = $(GetDetalle_de_Datos_de_la_Victima_MPI_PaisDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Pais_de_los_Hechos Pais_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Pais_de_los_Hechos_' + index).attr('data-field', 'Pais_de_los_Hechos').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Pais', 'Pais_de_los_Hechos', 264155)));
    columnData[59] = $(GetDetalle_de_Datos_de_la_Victima_MPI_EstadoDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Estado_de_los_Hechos Estado_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Estado_de_los_Hechos_' + index).attr('data-field', 'Estado_de_los_Hechos').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Estado', 'Estado_de_los_Hechos', 264156)));
    columnData[60] = $(GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Municipio_de_los_Hechos Municipio_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Municipio_de_los_Hechos_' + index).attr('data-field', 'Municipio_de_los_Hechos').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Municipio', 'Municipio_de_los_Hechos', 264157)));
    columnData[61] = $(GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Colonia_de_los_Hechos Colonia_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Colonia_de_los_Hechos_' + index).attr('data-field', 'Colonia_de_los_Hechos').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Colonia', 'Colonia_de_los_Hechos', 264158)));
    columnData[62] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_de_la_Victima_MPI_Codigo_Postal_de_los_Hechos Codigo_Postal_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Codigo_Postal_de_los_Hechos_' + index).attr('data-field', 'Codigo_Postal_de_los_Hechos');
    columnData[63] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Calle_de_los_Hechos Calle_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Calle_de_los_Hechos_' + index).attr('data-field', 'Calle_de_los_Hechos');
    columnData[64] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Entre_Calle_de_los_Hechos Entre_Calle_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Entre_Calle_de_los_Hechos_' + index).attr('data-field', 'Entre_Calle_de_los_Hechos');
    columnData[65] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Y_Calle_de_los_Hechos Y_Calle_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Y_Calle_de_los_Hechos_' + index).attr('data-field', 'Y_Calle_de_los_Hechos');
    columnData[66] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_Exterior_de_los_Hechos Numero_Exterior_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_Exterior_de_los_Hechos_' + index).attr('data-field', 'Numero_Exterior_de_los_Hechos');
    columnData[67] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_Interior_de_los_Hechos Numero_Interior_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_Interior_de_los_Hechos_' + index).attr('data-field', 'Numero_Interior_de_los_Hechos');
    columnData[68] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Latitud_de_los_Hechos Latitud_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Latitud_de_los_Hechos_' + index).attr('data-field', 'Latitud_de_los_Hechos');
    columnData[69] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Longitud_de_los_Hechos Longitud_de_los_Hechos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Longitud_de_los_Hechos_' + index).attr('data-field', 'Longitud_de_los_Hechos');
    columnData[70] = $(GetDetalle_de_Datos_de_la_Victima_MPI_Lugar_TipoDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_Lugar_del_Hecho Tipo_de_Lugar_del_Hecho').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_Lugar_del_Hecho_' + index).attr('data-field', 'Tipo_de_Lugar_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Lugar_Tipo', 'Tipo_de_Lugar_del_Hecho', 264167)));
    columnData[71] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_de_la_Victima_MPI_Proteccion_de_Datos Proteccion_de_Datos').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Proteccion_de_Datos_' + index).attr('data-field', 'Proteccion_de_Datos');
    columnData[72] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Nombre_de_Persona_Moral Nombre_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Nombre_de_Persona_Moral_' + index).attr('data-field', 'Nombre_de_Persona_Moral');
    columnData[73] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Apellido_Paterno_de_Persona_Moral Apellido_Paterno_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Apellido_Paterno_de_Persona_Moral_' + index).attr('data-field', 'Apellido_Paterno_de_Persona_Moral');
    columnData[74] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Apellido_Materno_de_Persona_Moral Apellido_Materno_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Apellido_Materno_de_Persona_Moral_' + index).attr('data-field', 'Apellido_Materno_de_Persona_Moral');
    columnData[75] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_de_la_Victima_MPI_Fecha_de_Nacimiento_de_Persona_Moral Fecha_de_Nacimiento_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Fecha_de_Nacimiento_de_Persona_Moral_' + index).attr('data-field', 'Fecha_de_Nacimiento_de_Persona_Moral');
    columnData[76] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_de_la_Victima_MPI_Edad_de_Persona_Moral Edad_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Edad_de_Persona_Moral_' + index).attr('data-field', 'Edad_de_Persona_Moral');
    columnData[77] = $(GetDetalle_de_Datos_de_la_Victima_MPI_GeneroDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Sexo_de_Persona_Moral Sexo_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Sexo_de_Persona_Moral_' + index).attr('data-field', 'Sexo_de_Persona_Moral').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Genero', 'Sexo_de_Persona_Moral', 264174)));
    columnData[78] = $(GetDetalle_de_Datos_de_la_Victima_MPI_Estado_CivilDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Estado_Civil_de_Persona_Moral Estado_Civil_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Estado_Civil_de_Persona_Moral_' + index).attr('data-field', 'Estado_Civil_de_Persona_Moral').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Estado_Civil', 'Estado_Civil_de_Persona_Moral', 264175)));
    columnData[79] = $(GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_Identificacion_de_Persona_Moral Tipo_de_Identificacion_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Tipo_de_Identificacion_de_Persona_Moral_' + index).attr('data-field', 'Tipo_de_Identificacion_de_Persona_Moral').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion_de_Persona_Moral', 264176)));
    columnData[80] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_de_Identificacion_de_Persona_Mora Numero_de_Identificacion_de_Persona_Mora').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_de_Identificacion_de_Persona_Mora_' + index).attr('data-field', 'Numero_de_Identificacion_de_Persona_Mora');
    columnData[81] = $(GetDetalle_de_Datos_de_la_Victima_MPI_NacionalidadDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Nacionalidad_de_Persona_Moral Nacionalidad_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Nacionalidad_de_Persona_Moral_' + index).attr('data-field', 'Nacionalidad_de_Persona_Moral').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Nacionalidad', 'Nacionalidad_de_Persona_Moral', 264178)));
    columnData[82] = $(GetDetalle_de_Datos_de_la_Victima_MPI_EscolaridadDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Escolaridad_de_Persona_Moral Escolaridad_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Escolaridad_de_Persona_Moral_' + index).attr('data-field', 'Escolaridad_de_Persona_Moral').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Escolaridad', 'Escolaridad_de_Persona_Moral', 264179)));
    columnData[83] = $(GetDetalle_de_Datos_de_la_Victima_MPI_OcupacionDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Ocupacion_de_Persona_Moral Ocupacion_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Ocupacion_de_Persona_Moral_' + index).attr('data-field', 'Ocupacion_de_Persona_Moral').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Ocupacion', 'Ocupacion_de_Persona_Moral', 264180)));
    columnData[84] = $(GetDetalle_de_Datos_de_la_Victima_MPI_PaisDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Pais_de_Persona_Moral Pais_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Pais_de_Persona_Moral_' + index).attr('data-field', 'Pais_de_Persona_Moral').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Pais', 'Pais_de_Persona_Moral', 264181)));
    columnData[85] = $(GetDetalle_de_Datos_de_la_Victima_MPI_EstadoDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Estado_de_Persona_Moral Estado_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Estado_de_Persona_Moral_' + index).attr('data-field', 'Estado_de_Persona_Moral').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Estado', 'Estado_de_Persona_Moral', 264182)));
    columnData[86] = $(GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Municipio_de_Persona_Moral Municipio_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Municipio_de_Persona_Moral_' + index).attr('data-field', 'Municipio_de_Persona_Moral').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Municipio', 'Municipio_de_Persona_Moral', 264183)));
    columnData[87] = $(GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaDropDown()).addClass('Detalle_de_Datos_de_la_Victima_MPI_Colonia_de_Persona_Moral Colonia_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Colonia_de_Persona_Moral_' + index).attr('data-field', 'Colonia_de_Persona_Moral').after($.parseHTML(addNew('Detalle_de_Datos_de_la_Victima_MPI', 'Colonia', 'Colonia_de_Persona_Moral', 264184)));
    columnData[88] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_de_la_Victima_MPI_Codigo_Postal_de_Persona_Moral Codigo_Postal_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Codigo_Postal_de_Persona_Moral_' + index).attr('data-field', 'Codigo_Postal_de_Persona_Moral');
    columnData[89] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Calle_de_Persona_Moral Calle_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Calle_de_Persona_Moral_' + index).attr('data-field', 'Calle_de_Persona_Moral');
    columnData[90] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_Exterior_de_Persona_Moral Numero_Exterior_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_Exterior_de_Persona_Moral_' + index).attr('data-field', 'Numero_Exterior_de_Persona_Moral');
    columnData[91] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Numero_Interior_de_Persona_Moral Numero_Interior_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Numero_Interior_de_Persona_Moral_' + index).attr('data-field', 'Numero_Interior_de_Persona_Moral');
    columnData[92] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Entre_Calle_de_Persona_Moral Entre_Calle_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Entre_Calle_de_Persona_Moral_' + index).attr('data-field', 'Entre_Calle_de_Persona_Moral');
    columnData[93] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Y_Calle_de_Persona_Moral Y_Calle_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Y_Calle_de_Persona_Moral_' + index).attr('data-field', 'Y_Calle_de_Persona_Moral');
    columnData[94] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Longitud_de_Persona_Moral Longitud_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Longitud_de_Persona_Moral_' + index).attr('data-field', 'Longitud_de_Persona_Moral');
    columnData[95] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Latitud_de_Persona_Moral Latitud_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Latitud_de_Persona_Moral_' + index).attr('data-field', 'Latitud_de_Persona_Moral');
    columnData[96] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Telefono_de_Persona_Moral Telefono_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Telefono_de_Persona_Moral_' + index).attr('data-field', 'Telefono_de_Persona_Moral');
    columnData[97] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Extension_de_Persona_Moral Extension_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Extension_de_Persona_Moral_' + index).attr('data-field', 'Extension_de_Persona_Moral');
    columnData[98] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Celular_de_Persona_Moral Celular_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Celular_de_Persona_Moral_' + index).attr('data-field', 'Celular_de_Persona_Moral');
    columnData[99] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_de_la_Victima_MPI_Correo_Electronico_de_Persona_Moral Correo_Electronico_de_Persona_Moral').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Correo_Electronico_de_Persona_Moral_' + index).attr('data-field', 'Correo_Electronico_de_Persona_Moral');
    columnData[100] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_de_la_Victima_MPI_Persona_Moral_Victima Persona_Moral_Victima').attr('id', 'Detalle_de_Datos_de_la_Victima_MPI_Persona_Moral_Victima_' + index).attr('data-field', 'Persona_Moral_Victima');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Datos_de_la_Victima_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_de_la_Victima_MPI("Detalle_de_Datos_de_la_Victima_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_Datos_de_la_Victima_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Datos_de_la_Victima_MPI';
    var prevData = Detalle_de_Datos_de_la_Victima_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_de_la_Victima_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_Completo:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Nacimiento:  data.childNodes[counter++].childNodes[0].value
        ,Edad: data.childNodes[counter++].childNodes[0].value
        ,Sexo:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad:  data.childNodes[counter++].childNodes[0].value
        ,Escolaridad:  data.childNodes[counter++].childNodes[0].value
        ,Ocupacion:  data.childNodes[counter++].childNodes[0].value
        ,Pais:  data.childNodes[counter++].childNodes[0].value
        ,Estado:  data.childNodes[counter++].childNodes[0].value
        ,Municipio:  data.childNodes[counter++].childNodes[0].value
        ,Colonia:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal: data.childNodes[counter++].childNodes[0].value
        ,Calle:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value
        ,Telefono:  data.childNodes[counter++].childNodes[0].value
        ,Extencion: data.childNodes[counter++].childNodes[0].value
        ,Celular:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value
        ,Incapaz: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Nombre_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_Completo_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Nacimiento_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Edad_del_Tutor: data.childNodes[counter++].childNodes[0].value
        ,Sexo_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Escolaridad_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Ocupacion_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Pais_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Estado_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Municipio_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Localidad_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Colonia_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal_del_Tutor: data.childNodes[counter++].childNodes[0].value
        ,Calle_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior_del_Tutor: data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Telefono_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Extencion_del_Tutor: data.childNodes[counter++].childNodes[0].value
        ,Celular_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Compareciente:  data.childNodes[counter++].childNodes[0].value
        ,Narrativa_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value

        ,Titulo_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Prioridad_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Hora_Aproximada_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Pais_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Estado_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Municipio_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Colonia_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal_de_los_Hechos: data.childNodes[counter++].childNodes[0].value
        ,Calle_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Entre_Calle_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Y_Calle_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Latitud_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Longitud_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Lugar_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Proteccion_de_Datos: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Nombre_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Nacimiento_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Edad_de_Persona_Moral: data.childNodes[counter++].childNodes[0].value
        ,Sexo_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion_de_Persona_Mora:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Escolaridad_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Ocupacion_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Pais_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Estado_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Municipio_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Colonia_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal_de_Persona_Moral: data.childNodes[counter++].childNodes[0].value
        ,Calle_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Entre_Calle_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Y_Calle_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Longitud_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Latitud_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Telefono_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Extension_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Celular_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico_de_Persona_Moral:  data.childNodes[counter++].childNodes[0].value
        ,Persona_Moral_Victima: $(data.childNodes[counter++].childNodes[2]).is(':checked')

    }
    Detalle_de_Datos_de_la_Victima_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Datos_de_la_Victima_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Datos_de_la_Victima_MPITable.fnPageChange(iPage);
    Detalle_de_Datos_de_la_Victima_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Datos_de_la_Victima_MPI("Detalle_de_Datos_de_la_Victima_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_Datos_de_la_Victima_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_Datos_de_la_Victima_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_de_la_Victima_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Datos_de_la_Victima_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Datos_de_la_Victima_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Datos_de_la_Victima_MPIGrid(Detalle_de_Datos_de_la_Victima_MPITable.fnGetData());
    Detalle_de_Datos_de_la_Victima_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Datos_de_la_Victima_MPIFromDataTable() {
    var Detalle_de_Datos_de_la_Victima_MPIData = [];
    var gridData = Detalle_de_Datos_de_la_Victima_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Datos_de_la_Victima_MPIData.push({
                Clave: gridData[i].Clave

                ,Nombre: gridData[i].Nombre
                ,Apellido_Paterno: gridData[i].Apellido_Paterno
                ,Apellido_Materno: gridData[i].Apellido_Materno
                ,Nombre_Completo: gridData[i].Nombre_Completo
                ,Fecha_de_Nacimiento: gridData[i].Fecha_de_Nacimiento
                ,Edad: gridData[i].Edad
                ,Sexo: gridData[i].Sexo
                ,Estado_Civil: gridData[i].Estado_Civil
                ,Tipo_de_Identificacion: gridData[i].Tipo_de_Identificacion
                ,Numero_de_Identificacion: gridData[i].Numero_de_Identificacion
                ,Nacionalidad: gridData[i].Nacionalidad
                ,Escolaridad: gridData[i].Escolaridad
                ,Ocupacion: gridData[i].Ocupacion
                ,Pais: gridData[i].Pais
                ,Estado: gridData[i].Estado
                ,Municipio: gridData[i].Municipio
                ,Colonia: gridData[i].Colonia
                ,Codigo_Postal: gridData[i].Codigo_Postal
                ,Calle: gridData[i].Calle
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior
                ,Telefono: gridData[i].Telefono
                ,Extencion: gridData[i].Extencion
                ,Celular: gridData[i].Celular
                ,Correo_Electronico: gridData[i].Correo_Electronico
                ,Incapaz: gridData[i].Incapaz
                ,Nombre_del_Tutor: gridData[i].Nombre_del_Tutor
                ,Apellido_Paterno_del_Tutor: gridData[i].Apellido_Paterno_del_Tutor
                ,Apellido_Materno_del_Tutor: gridData[i].Apellido_Materno_del_Tutor
                ,Nombre_Completo_del_Tutor: gridData[i].Nombre_Completo_del_Tutor
                ,Fecha_de_Nacimiento_del_Tutor: gridData[i].Fecha_de_Nacimiento_del_Tutor
                ,Edad_del_Tutor: gridData[i].Edad_del_Tutor
                ,Sexo_del_Tutor: gridData[i].Sexo_del_Tutor
                ,Estado_Civil_del_Tutor: gridData[i].Estado_Civil_del_Tutor
                ,Tipo_de_Identificacion_del_Tutor: gridData[i].Tipo_de_Identificacion_del_Tutor
                ,Numero_de_Identificacion_del_Tutor: gridData[i].Numero_de_Identificacion_del_Tutor
                ,Nacionalidad_del_Tutor: gridData[i].Nacionalidad_del_Tutor
                ,Escolaridad_del_Tutor: gridData[i].Escolaridad_del_Tutor
                ,Ocupacion_del_Tutor: gridData[i].Ocupacion_del_Tutor
                ,Pais_del_Tutor: gridData[i].Pais_del_Tutor
                ,Estado_del_Tutor: gridData[i].Estado_del_Tutor
                ,Municipio_del_Tutor: gridData[i].Municipio_del_Tutor
                ,Localidad_del_Tutor: gridData[i].Localidad_del_Tutor
                ,Colonia_del_Tutor: gridData[i].Colonia_del_Tutor
                ,Codigo_Postal_del_Tutor: gridData[i].Codigo_Postal_del_Tutor
                ,Calle_del_Tutor: gridData[i].Calle_del_Tutor
                ,Numero_Exterior_del_Tutor: gridData[i].Numero_Exterior_del_Tutor
                ,Numero_Interior_del_Tutor: gridData[i].Numero_Interior_del_Tutor
                ,Telefono_del_Tutor: gridData[i].Telefono_del_Tutor
                ,Extencion_del_Tutor: gridData[i].Extencion_del_Tutor
                ,Celular_del_Tutor: gridData[i].Celular_del_Tutor
                ,Correo_Electronico_del_Tutor: gridData[i].Correo_Electronico_del_Tutor
                ,Tipo_de_Compareciente: gridData[i].Tipo_de_Compareciente
                ,Narrativa_de_los_Hechos: gridData[i].Narrativa_de_los_Hechos

                ,Titulo_del_Hecho: gridData[i].Titulo_del_Hecho
                ,Prioridad_del_Hecho: gridData[i].Prioridad_del_Hecho
                ,Fecha_del_Hecho: gridData[i].Fecha_del_Hecho
                ,Hora_Aproximada_del_Hecho: gridData[i].Hora_Aproximada_del_Hecho
                ,Pais_de_los_Hechos: gridData[i].Pais_de_los_Hechos
                ,Estado_de_los_Hechos: gridData[i].Estado_de_los_Hechos
                ,Municipio_de_los_Hechos: gridData[i].Municipio_de_los_Hechos
                ,Colonia_de_los_Hechos: gridData[i].Colonia_de_los_Hechos
                ,Codigo_Postal_de_los_Hechos: gridData[i].Codigo_Postal_de_los_Hechos
                ,Calle_de_los_Hechos: gridData[i].Calle_de_los_Hechos
                ,Entre_Calle_de_los_Hechos: gridData[i].Entre_Calle_de_los_Hechos
                ,Y_Calle_de_los_Hechos: gridData[i].Y_Calle_de_los_Hechos
                ,Numero_Exterior_de_los_Hechos: gridData[i].Numero_Exterior_de_los_Hechos
                ,Numero_Interior_de_los_Hechos: gridData[i].Numero_Interior_de_los_Hechos
                ,Latitud_de_los_Hechos: gridData[i].Latitud_de_los_Hechos
                ,Longitud_de_los_Hechos: gridData[i].Longitud_de_los_Hechos
                ,Tipo_de_Lugar_del_Hecho: gridData[i].Tipo_de_Lugar_del_Hecho
                ,Proteccion_de_Datos: gridData[i].Proteccion_de_Datos
                ,Nombre_de_Persona_Moral: gridData[i].Nombre_de_Persona_Moral
                ,Apellido_Paterno_de_Persona_Moral: gridData[i].Apellido_Paterno_de_Persona_Moral
                ,Apellido_Materno_de_Persona_Moral: gridData[i].Apellido_Materno_de_Persona_Moral
                ,Fecha_de_Nacimiento_de_Persona_Moral: gridData[i].Fecha_de_Nacimiento_de_Persona_Moral
                ,Edad_de_Persona_Moral: gridData[i].Edad_de_Persona_Moral
                ,Sexo_de_Persona_Moral: gridData[i].Sexo_de_Persona_Moral
                ,Estado_Civil_de_Persona_Moral: gridData[i].Estado_Civil_de_Persona_Moral
                ,Tipo_de_Identificacion_de_Persona_Moral: gridData[i].Tipo_de_Identificacion_de_Persona_Moral
                ,Numero_de_Identificacion_de_Persona_Mora: gridData[i].Numero_de_Identificacion_de_Persona_Mora
                ,Nacionalidad_de_Persona_Moral: gridData[i].Nacionalidad_de_Persona_Moral
                ,Escolaridad_de_Persona_Moral: gridData[i].Escolaridad_de_Persona_Moral
                ,Ocupacion_de_Persona_Moral: gridData[i].Ocupacion_de_Persona_Moral
                ,Pais_de_Persona_Moral: gridData[i].Pais_de_Persona_Moral
                ,Estado_de_Persona_Moral: gridData[i].Estado_de_Persona_Moral
                ,Municipio_de_Persona_Moral: gridData[i].Municipio_de_Persona_Moral
                ,Colonia_de_Persona_Moral: gridData[i].Colonia_de_Persona_Moral
                ,Codigo_Postal_de_Persona_Moral: gridData[i].Codigo_Postal_de_Persona_Moral
                ,Calle_de_Persona_Moral: gridData[i].Calle_de_Persona_Moral
                ,Numero_Exterior_de_Persona_Moral: gridData[i].Numero_Exterior_de_Persona_Moral
                ,Numero_Interior_de_Persona_Moral: gridData[i].Numero_Interior_de_Persona_Moral
                ,Entre_Calle_de_Persona_Moral: gridData[i].Entre_Calle_de_Persona_Moral
                ,Y_Calle_de_Persona_Moral: gridData[i].Y_Calle_de_Persona_Moral
                ,Longitud_de_Persona_Moral: gridData[i].Longitud_de_Persona_Moral
                ,Latitud_de_Persona_Moral: gridData[i].Latitud_de_Persona_Moral
                ,Telefono_de_Persona_Moral: gridData[i].Telefono_de_Persona_Moral
                ,Extension_de_Persona_Moral: gridData[i].Extension_de_Persona_Moral
                ,Celular_de_Persona_Moral: gridData[i].Celular_de_Persona_Moral
                ,Correo_Electronico_de_Persona_Moral: gridData[i].Correo_Electronico_de_Persona_Moral
                ,Persona_Moral_Victima: gridData[i].Persona_Moral_Victima

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Datos_de_la_Victima_MPIData.length; i++) {
        if (removedDetalle_de_Datos_de_la_Victima_MPIData[i] != null && removedDetalle_de_Datos_de_la_Victima_MPIData[i].Clave > 0)
            Detalle_de_Datos_de_la_Victima_MPIData.push({
                Clave: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Clave

                ,Nombre: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Nombre
                ,Apellido_Paterno: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Paterno
                ,Apellido_Materno: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Materno
                ,Nombre_Completo: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Nombre_Completo
                ,Fecha_de_Nacimiento: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Fecha_de_Nacimiento
                ,Edad: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Edad
                ,Sexo: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Sexo
                ,Estado_Civil: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Estado_Civil
                ,Tipo_de_Identificacion: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Tipo_de_Identificacion
                ,Numero_de_Identificacion: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_de_Identificacion
                ,Nacionalidad: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Nacionalidad
                ,Escolaridad: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Escolaridad
                ,Ocupacion: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Ocupacion
                ,Pais: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Pais
                ,Estado: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Estado
                ,Municipio: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Municipio
                ,Colonia: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Colonia
                ,Codigo_Postal: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Codigo_Postal
                ,Calle: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Calle
                ,Numero_Exterior: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_Exterior
                ,Numero_Interior: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_Interior
                ,Telefono: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Telefono
                ,Extencion: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Extencion
                ,Celular: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Celular
                ,Correo_Electronico: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Correo_Electronico
                ,Incapaz: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Incapaz
                ,Nombre_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Nombre_del_Tutor
                ,Apellido_Paterno_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Paterno_del_Tutor
                ,Apellido_Materno_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Materno_del_Tutor
                ,Nombre_Completo_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Nombre_Completo_del_Tutor
                ,Fecha_de_Nacimiento_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Fecha_de_Nacimiento_del_Tutor
                ,Edad_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Edad_del_Tutor
                ,Sexo_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Sexo_del_Tutor
                ,Estado_Civil_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Estado_Civil_del_Tutor
                ,Tipo_de_Identificacion_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Tipo_de_Identificacion_del_Tutor
                ,Numero_de_Identificacion_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_de_Identificacion_del_Tutor
                ,Nacionalidad_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Nacionalidad_del_Tutor
                ,Escolaridad_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Escolaridad_del_Tutor
                ,Ocupacion_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Ocupacion_del_Tutor
                ,Pais_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Pais_del_Tutor
                ,Estado_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Estado_del_Tutor
                ,Municipio_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Municipio_del_Tutor
                ,Localidad_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Localidad_del_Tutor
                ,Colonia_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Colonia_del_Tutor
                ,Codigo_Postal_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Codigo_Postal_del_Tutor
                ,Calle_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Calle_del_Tutor
                ,Numero_Exterior_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_Exterior_del_Tutor
                ,Numero_Interior_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_Interior_del_Tutor
                ,Telefono_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Telefono_del_Tutor
                ,Extencion_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Extencion_del_Tutor
                ,Celular_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Celular_del_Tutor
                ,Correo_Electronico_del_Tutor: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Correo_Electronico_del_Tutor
                ,Tipo_de_Compareciente: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Tipo_de_Compareciente
                ,Narrativa_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Narrativa_de_los_Hechos

                ,Titulo_del_Hecho: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Titulo_del_Hecho
                ,Prioridad_del_Hecho: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Prioridad_del_Hecho
                ,Fecha_del_Hecho: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Fecha_del_Hecho
                ,Hora_Aproximada_del_Hecho: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Hora_Aproximada_del_Hecho
                ,Pais_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Pais_de_los_Hechos
                ,Estado_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Estado_de_los_Hechos
                ,Municipio_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Municipio_de_los_Hechos
                ,Colonia_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Colonia_de_los_Hechos
                ,Codigo_Postal_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Codigo_Postal_de_los_Hechos
                ,Calle_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Calle_de_los_Hechos
                ,Entre_Calle_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Entre_Calle_de_los_Hechos
                ,Y_Calle_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Y_Calle_de_los_Hechos
                ,Numero_Exterior_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_Exterior_de_los_Hechos
                ,Numero_Interior_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_Interior_de_los_Hechos
                ,Latitud_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Latitud_de_los_Hechos
                ,Longitud_de_los_Hechos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Longitud_de_los_Hechos
                ,Tipo_de_Lugar_del_Hecho: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Tipo_de_Lugar_del_Hecho
                ,Proteccion_de_Datos: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Proteccion_de_Datos
                ,Nombre_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Nombre_de_Persona_Moral
                ,Apellido_Paterno_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Paterno_de_Persona_Moral
                ,Apellido_Materno_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Materno_de_Persona_Moral
                ,Fecha_de_Nacimiento_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Fecha_de_Nacimiento_de_Persona_Moral
                ,Edad_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Edad_de_Persona_Moral
                ,Sexo_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Sexo_de_Persona_Moral
                ,Estado_Civil_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Estado_Civil_de_Persona_Moral
                ,Tipo_de_Identificacion_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Tipo_de_Identificacion_de_Persona_Moral
                ,Numero_de_Identificacion_de_Persona_Mora: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_de_Identificacion_de_Persona_Mora
                ,Nacionalidad_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Nacionalidad_de_Persona_Moral
                ,Escolaridad_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Escolaridad_de_Persona_Moral
                ,Ocupacion_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Ocupacion_de_Persona_Moral
                ,Pais_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Pais_de_Persona_Moral
                ,Estado_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Estado_de_Persona_Moral
                ,Municipio_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Municipio_de_Persona_Moral
                ,Colonia_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Colonia_de_Persona_Moral
                ,Codigo_Postal_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Codigo_Postal_de_Persona_Moral
                ,Calle_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Calle_de_Persona_Moral
                ,Numero_Exterior_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_Exterior_de_Persona_Moral
                ,Numero_Interior_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Numero_Interior_de_Persona_Moral
                ,Entre_Calle_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Entre_Calle_de_Persona_Moral
                ,Y_Calle_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Y_Calle_de_Persona_Moral
                ,Longitud_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Longitud_de_Persona_Moral
                ,Latitud_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Latitud_de_Persona_Moral
                ,Telefono_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Telefono_de_Persona_Moral
                ,Extension_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Extension_de_Persona_Moral
                ,Celular_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Celular_de_Persona_Moral
                ,Correo_Electronico_de_Persona_Moral: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Correo_Electronico_de_Persona_Moral
                ,Persona_Moral_Victima: removedDetalle_de_Datos_de_la_Victima_MPIData[i].Persona_Moral_Victima

                , Removed: true
            });
    }	

    return Detalle_de_Datos_de_la_Victima_MPIData;
}

function Detalle_de_Datos_de_la_Victima_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Datos_de_la_Victima_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Datos_de_la_Victima_MPIcountRowsChecked++;
    var Detalle_de_Datos_de_la_Victima_MPIRowElement = "Detalle_de_Datos_de_la_Victima_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Datos_de_la_Victima_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_Datos_de_la_Victima_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Datos_de_la_Victima_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Datos_de_la_Victima_MPIGetUpdateRowControls(prevData, "Detalle_de_Datos_de_la_Victima_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Datos_de_la_Victima_MPIRowElement + "')){ Detalle_de_Datos_de_la_Victima_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Datos_de_la_Victima_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Datos_de_la_Victima_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Datos_de_la_Victima_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Datos_de_la_Victima_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_Datos_de_la_Victima_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Datos_de_la_Victima_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Datos_de_la_Victima_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Datos_de_la_Victima_MPITable.fnGetData().length;
    Detalle_de_Datos_de_la_Victima_MPIfnClickAddRow();
    GetAddDetalle_de_Datos_de_la_Victima_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_Datos_de_la_Victima_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Datos_de_la_Victima_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Datos_de_la_Victima_MPIRowElement = "Detalle_de_Datos_de_la_Victima_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Datos_de_la_Victima_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Datos_de_la_Victima_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Datos_de_la_Victima_MPINombre').val(prevData.Nombre);
    $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Paterno').val(prevData.Apellido_Paterno);
    $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Materno').val(prevData.Apellido_Materno);
    $('#Detalle_de_Datos_de_la_Victima_MPINombre_Completo').val(prevData.Nombre_Completo);
    $('#Detalle_de_Datos_de_la_Victima_MPIFecha_de_Nacimiento').val(prevData.Fecha_de_Nacimiento);
    $('#Detalle_de_Datos_de_la_Victima_MPIEdad').val(prevData.Edad);
    $('#Detalle_de_Datos_de_la_Victima_MPISexo').val(prevData.Sexo);
    $('#Detalle_de_Datos_de_la_Victima_MPIEstado_Civil').val(prevData.Estado_Civil);
    $('#Detalle_de_Datos_de_la_Victima_MPITipo_de_Identificacion').val(prevData.Tipo_de_Identificacion);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_de_Identificacion').val(prevData.Numero_de_Identificacion);
    $('#Detalle_de_Datos_de_la_Victima_MPINacionalidad').val(prevData.Nacionalidad);
    $('#Detalle_de_Datos_de_la_Victima_MPIEscolaridad').val(prevData.Escolaridad);
    $('#Detalle_de_Datos_de_la_Victima_MPIOcupacion').val(prevData.Ocupacion);
    $('#Detalle_de_Datos_de_la_Victima_MPIPais').val(prevData.Pais);
    $('#Detalle_de_Datos_de_la_Victima_MPIEstado').val(prevData.Estado);
    $('#Detalle_de_Datos_de_la_Victima_MPIMunicipio').val(prevData.Municipio);
    $('#Detalle_de_Datos_de_la_Victima_MPIColonia').val(prevData.Colonia);
    $('#Detalle_de_Datos_de_la_Victima_MPICodigo_Postal').val(prevData.Codigo_Postal);
    $('#Detalle_de_Datos_de_la_Victima_MPICalle').val(prevData.Calle);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_Exterior').val(prevData.Numero_Exterior);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_Interior').val(prevData.Numero_Interior);
    $('#Detalle_de_Datos_de_la_Victima_MPITelefono').val(prevData.Telefono);
    $('#Detalle_de_Datos_de_la_Victima_MPIExtencion').val(prevData.Extencion);
    $('#Detalle_de_Datos_de_la_Victima_MPICelular').val(prevData.Celular);
    $('#Detalle_de_Datos_de_la_Victima_MPICorreo_Electronico').val(prevData.Correo_Electronico);
    $('#Detalle_de_Datos_de_la_Victima_MPIIncapaz').prop('checked', prevData.Incapaz);
    $('#Detalle_de_Datos_de_la_Victima_MPINombre_del_Tutor').val(prevData.Nombre_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Paterno_del_Tutor').val(prevData.Apellido_Paterno_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Materno_del_Tutor').val(prevData.Apellido_Materno_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPINombre_Completo_del_Tutor').val(prevData.Nombre_Completo_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIFecha_de_Nacimiento_del_Tutor').val(prevData.Fecha_de_Nacimiento_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIEdad_del_Tutor').val(prevData.Edad_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPISexo_del_Tutor').val(prevData.Sexo_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIEstado_Civil_del_Tutor').val(prevData.Estado_Civil_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPITipo_de_Identificacion_del_Tutor').val(prevData.Tipo_de_Identificacion_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_de_Identificacion_del_Tutor').val(prevData.Numero_de_Identificacion_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPINacionalidad_del_Tutor').val(prevData.Nacionalidad_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIEscolaridad_del_Tutor').val(prevData.Escolaridad_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIOcupacion_del_Tutor').val(prevData.Ocupacion_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIPais_del_Tutor').val(prevData.Pais_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIEstado_del_Tutor').val(prevData.Estado_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIMunicipio_del_Tutor').val(prevData.Municipio_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPILocalidad_del_Tutor').val(prevData.Localidad_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIColonia_del_Tutor').val(prevData.Colonia_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPICodigo_Postal_del_Tutor').val(prevData.Codigo_Postal_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPICalle_del_Tutor').val(prevData.Calle_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_Exterior_del_Tutor').val(prevData.Numero_Exterior_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_Interior_del_Tutor').val(prevData.Numero_Interior_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPITelefono_del_Tutor').val(prevData.Telefono_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPIExtencion_del_Tutor').val(prevData.Extencion_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPICelular_del_Tutor').val(prevData.Celular_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPICorreo_Electronico_del_Tutor').val(prevData.Correo_Electronico_del_Tutor);
    $('#Detalle_de_Datos_de_la_Victima_MPITipo_de_Compareciente').val(prevData.Tipo_de_Compareciente);
    $('#Detalle_de_Datos_de_la_Victima_MPINarrativa_de_los_Hechos').val(prevData.Narrativa_de_los_Hechos);

    $('#Detalle_de_Datos_de_la_Victima_MPITitulo_del_Hecho').val(prevData.Titulo_del_Hecho);
    $('#Detalle_de_Datos_de_la_Victima_MPIPrioridad_del_Hecho').val(prevData.Prioridad_del_Hecho);
    $('#Detalle_de_Datos_de_la_Victima_MPIFecha_del_Hecho').val(prevData.Fecha_del_Hecho);
    $('#Detalle_de_Datos_de_la_Victima_MPIHora_Aproximada_del_Hecho').val(prevData.Hora_Aproximada_del_Hecho);
    $('#Detalle_de_Datos_de_la_Victima_MPIPais_de_los_Hechos').val(prevData.Pais_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPIEstado_de_los_Hechos').val(prevData.Estado_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPIMunicipio_de_los_Hechos').val(prevData.Municipio_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPIColonia_de_los_Hechos').val(prevData.Colonia_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPICodigo_Postal_de_los_Hechos').val(prevData.Codigo_Postal_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPICalle_de_los_Hechos').val(prevData.Calle_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPIEntre_Calle_de_los_Hechos').val(prevData.Entre_Calle_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPIY_Calle_de_los_Hechos').val(prevData.Y_Calle_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_Exterior_de_los_Hechos').val(prevData.Numero_Exterior_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_Interior_de_los_Hechos').val(prevData.Numero_Interior_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPILatitud_de_los_Hechos').val(prevData.Latitud_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPILongitud_de_los_Hechos').val(prevData.Longitud_de_los_Hechos);
    $('#Detalle_de_Datos_de_la_Victima_MPITipo_de_Lugar_del_Hecho').val(prevData.Tipo_de_Lugar_del_Hecho);
    $('#Detalle_de_Datos_de_la_Victima_MPIProteccion_de_Datos').prop('checked', prevData.Proteccion_de_Datos);
    $('#Detalle_de_Datos_de_la_Victima_MPINombre_de_Persona_Moral').val(prevData.Nombre_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Paterno_de_Persona_Moral').val(prevData.Apellido_Paterno_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Materno_de_Persona_Moral').val(prevData.Apellido_Materno_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIFecha_de_Nacimiento_de_Persona_Moral').val(prevData.Fecha_de_Nacimiento_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIEdad_de_Persona_Moral').val(prevData.Edad_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPISexo_de_Persona_Moral').val(prevData.Sexo_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIEstado_Civil_de_Persona_Moral').val(prevData.Estado_Civil_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPITipo_de_Identificacion_de_Persona_Moral').val(prevData.Tipo_de_Identificacion_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_de_Identificacion_de_Persona_Mora').val(prevData.Numero_de_Identificacion_de_Persona_Mora);
    $('#Detalle_de_Datos_de_la_Victima_MPINacionalidad_de_Persona_Moral').val(prevData.Nacionalidad_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIEscolaridad_de_Persona_Moral').val(prevData.Escolaridad_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIOcupacion_de_Persona_Moral').val(prevData.Ocupacion_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIPais_de_Persona_Moral').val(prevData.Pais_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIEstado_de_Persona_Moral').val(prevData.Estado_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIMunicipio_de_Persona_Moral').val(prevData.Municipio_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIColonia_de_Persona_Moral').val(prevData.Colonia_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPICodigo_Postal_de_Persona_Moral').val(prevData.Codigo_Postal_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPICalle_de_Persona_Moral').val(prevData.Calle_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_Exterior_de_Persona_Moral').val(prevData.Numero_Exterior_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPINumero_Interior_de_Persona_Moral').val(prevData.Numero_Interior_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIEntre_Calle_de_Persona_Moral').val(prevData.Entre_Calle_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIY_Calle_de_Persona_Moral').val(prevData.Y_Calle_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPILongitud_de_Persona_Moral').val(prevData.Longitud_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPILatitud_de_Persona_Moral').val(prevData.Latitud_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPITelefono_de_Persona_Moral').val(prevData.Telefono_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIExtension_de_Persona_Moral').val(prevData.Extension_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPICelular_de_Persona_Moral').val(prevData.Celular_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPICorreo_Electronico_de_Persona_Moral').val(prevData.Correo_Electronico_de_Persona_Moral);
    $('#Detalle_de_Datos_de_la_Victima_MPIPersona_Moral_Victima').prop('checked', prevData.Persona_Moral_Victima);

    initiateUIControls();








































































































}

function Detalle_de_Datos_de_la_Victima_MPIAddInsertRow() {
    if (Detalle_de_Datos_de_la_Victima_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_Datos_de_la_Victima_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre: ""
        ,Apellido_Paterno: ""
        ,Apellido_Materno: ""
        ,Nombre_Completo: ""
        ,Fecha_de_Nacimiento: ""
        ,Edad: ""
        ,Sexo: ""
        ,Estado_Civil: ""
        ,Tipo_de_Identificacion: ""
        ,Numero_de_Identificacion: ""
        ,Nacionalidad: ""
        ,Escolaridad: ""
        ,Ocupacion: ""
        ,Pais: ""
        ,Estado: ""
        ,Municipio: ""
        ,Colonia: ""
        ,Codigo_Postal: ""
        ,Calle: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""
        ,Telefono: ""
        ,Extencion: ""
        ,Celular: ""
        ,Correo_Electronico: ""
        ,Incapaz: ""
        ,Nombre_del_Tutor: ""
        ,Apellido_Paterno_del_Tutor: ""
        ,Apellido_Materno_del_Tutor: ""
        ,Nombre_Completo_del_Tutor: ""
        ,Fecha_de_Nacimiento_del_Tutor: ""
        ,Edad_del_Tutor: ""
        ,Sexo_del_Tutor: ""
        ,Estado_Civil_del_Tutor: ""
        ,Tipo_de_Identificacion_del_Tutor: ""
        ,Numero_de_Identificacion_del_Tutor: ""
        ,Nacionalidad_del_Tutor: ""
        ,Escolaridad_del_Tutor: ""
        ,Ocupacion_del_Tutor: ""
        ,Pais_del_Tutor: ""
        ,Estado_del_Tutor: ""
        ,Municipio_del_Tutor: ""
        ,Localidad_del_Tutor: ""
        ,Colonia_del_Tutor: ""
        ,Codigo_Postal_del_Tutor: ""
        ,Calle_del_Tutor: ""
        ,Numero_Exterior_del_Tutor: ""
        ,Numero_Interior_del_Tutor: ""
        ,Telefono_del_Tutor: ""
        ,Extencion_del_Tutor: ""
        ,Celular_del_Tutor: ""
        ,Correo_Electronico_del_Tutor: ""
        ,Tipo_de_Compareciente: ""
        ,Narrativa_de_los_Hechos: ""

        ,Titulo_del_Hecho: ""
        ,Prioridad_del_Hecho: ""
        ,Fecha_del_Hecho: ""
        ,Hora_Aproximada_del_Hecho: ""
        ,Pais_de_los_Hechos: ""
        ,Estado_de_los_Hechos: ""
        ,Municipio_de_los_Hechos: ""
        ,Colonia_de_los_Hechos: ""
        ,Codigo_Postal_de_los_Hechos: ""
        ,Calle_de_los_Hechos: ""
        ,Entre_Calle_de_los_Hechos: ""
        ,Y_Calle_de_los_Hechos: ""
        ,Numero_Exterior_de_los_Hechos: ""
        ,Numero_Interior_de_los_Hechos: ""
        ,Latitud_de_los_Hechos: ""
        ,Longitud_de_los_Hechos: ""
        ,Tipo_de_Lugar_del_Hecho: ""
        ,Proteccion_de_Datos: ""
        ,Nombre_de_Persona_Moral: ""
        ,Apellido_Paterno_de_Persona_Moral: ""
        ,Apellido_Materno_de_Persona_Moral: ""
        ,Fecha_de_Nacimiento_de_Persona_Moral: ""
        ,Edad_de_Persona_Moral: ""
        ,Sexo_de_Persona_Moral: ""
        ,Estado_Civil_de_Persona_Moral: ""
        ,Tipo_de_Identificacion_de_Persona_Moral: ""
        ,Numero_de_Identificacion_de_Persona_Mora: ""
        ,Nacionalidad_de_Persona_Moral: ""
        ,Escolaridad_de_Persona_Moral: ""
        ,Ocupacion_de_Persona_Moral: ""
        ,Pais_de_Persona_Moral: ""
        ,Estado_de_Persona_Moral: ""
        ,Municipio_de_Persona_Moral: ""
        ,Colonia_de_Persona_Moral: ""
        ,Codigo_Postal_de_Persona_Moral: ""
        ,Calle_de_Persona_Moral: ""
        ,Numero_Exterior_de_Persona_Moral: ""
        ,Numero_Interior_de_Persona_Moral: ""
        ,Entre_Calle_de_Persona_Moral: ""
        ,Y_Calle_de_Persona_Moral: ""
        ,Longitud_de_Persona_Moral: ""
        ,Latitud_de_Persona_Moral: ""
        ,Telefono_de_Persona_Moral: ""
        ,Extension_de_Persona_Moral: ""
        ,Celular_de_Persona_Moral: ""
        ,Correo_Electronico_de_Persona_Moral: ""
        ,Persona_Moral_Victima: ""

    }
}

function Detalle_de_Datos_de_la_Victima_MPIfnClickAddRow() {
    Detalle_de_Datos_de_la_Victima_MPIcountRowsChecked++;
    Detalle_de_Datos_de_la_Victima_MPITable.fnAddData(Detalle_de_Datos_de_la_Victima_MPIAddInsertRow(), true);
    Detalle_de_Datos_de_la_Victima_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Datos_de_la_Victima_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Datos_de_la_Victima_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_Datos_de_la_Victima_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Datos_de_la_Victima_MPI("Detalle_de_Datos_de_la_Victima_MPI_", "_" + Detalle_de_Datos_de_la_Victima_MPIinsertRowCurrentIndex);
}

function Detalle_de_Datos_de_la_Victima_MPIClearGridData() {
    Detalle_de_Datos_de_la_Victima_MPIData = [];
    Detalle_de_Datos_de_la_Victima_MPIdeletedItem = [];
    Detalle_de_Datos_de_la_Victima_MPIDataMain = [];
    Detalle_de_Datos_de_la_Victima_MPIDataMainPages = [];
    Detalle_de_Datos_de_la_Victima_MPInewItemCount = 0;
    Detalle_de_Datos_de_la_Victima_MPImaxItemIndex = 0;
    $("#Detalle_de_Datos_de_la_Victima_MPIGrid").DataTable().clear();
    $("#Detalle_de_Datos_de_la_Victima_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Datos_de_la_Victima_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Datos_de_la_Victima_MPIData[i].Clave);

        form_data.append('[' + i + '].Nombre', Detalle_de_Datos_de_la_Victima_MPIData[i].Nombre);
        form_data.append('[' + i + '].Apellido_Paterno', Detalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Paterno);
        form_data.append('[' + i + '].Apellido_Materno', Detalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Materno);
        form_data.append('[' + i + '].Nombre_Completo', Detalle_de_Datos_de_la_Victima_MPIData[i].Nombre_Completo);
        form_data.append('[' + i + '].Fecha_de_Nacimiento', Detalle_de_Datos_de_la_Victima_MPIData[i].Fecha_de_Nacimiento);
        form_data.append('[' + i + '].Edad', Detalle_de_Datos_de_la_Victima_MPIData[i].Edad);
        form_data.append('[' + i + '].Sexo', Detalle_de_Datos_de_la_Victima_MPIData[i].Sexo);
        form_data.append('[' + i + '].Estado_Civil', Detalle_de_Datos_de_la_Victima_MPIData[i].Estado_Civil);
        form_data.append('[' + i + '].Tipo_de_Identificacion', Detalle_de_Datos_de_la_Victima_MPIData[i].Tipo_de_Identificacion);
        form_data.append('[' + i + '].Numero_de_Identificacion', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_de_Identificacion);
        form_data.append('[' + i + '].Nacionalidad', Detalle_de_Datos_de_la_Victima_MPIData[i].Nacionalidad);
        form_data.append('[' + i + '].Escolaridad', Detalle_de_Datos_de_la_Victima_MPIData[i].Escolaridad);
        form_data.append('[' + i + '].Ocupacion', Detalle_de_Datos_de_la_Victima_MPIData[i].Ocupacion);
        form_data.append('[' + i + '].Pais', Detalle_de_Datos_de_la_Victima_MPIData[i].Pais);
        form_data.append('[' + i + '].Estado', Detalle_de_Datos_de_la_Victima_MPIData[i].Estado);
        form_data.append('[' + i + '].Municipio', Detalle_de_Datos_de_la_Victima_MPIData[i].Municipio);
        form_data.append('[' + i + '].Colonia', Detalle_de_Datos_de_la_Victima_MPIData[i].Colonia);
        form_data.append('[' + i + '].Codigo_Postal', Detalle_de_Datos_de_la_Victima_MPIData[i].Codigo_Postal);
        form_data.append('[' + i + '].Calle', Detalle_de_Datos_de_la_Victima_MPIData[i].Calle);
        form_data.append('[' + i + '].Numero_Exterior', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_Interior);
        form_data.append('[' + i + '].Telefono', Detalle_de_Datos_de_la_Victima_MPIData[i].Telefono);
        form_data.append('[' + i + '].Extencion', Detalle_de_Datos_de_la_Victima_MPIData[i].Extencion);
        form_data.append('[' + i + '].Celular', Detalle_de_Datos_de_la_Victima_MPIData[i].Celular);
        form_data.append('[' + i + '].Correo_Electronico', Detalle_de_Datos_de_la_Victima_MPIData[i].Correo_Electronico);
        form_data.append('[' + i + '].Incapaz', Detalle_de_Datos_de_la_Victima_MPIData[i].Incapaz);
        form_data.append('[' + i + '].Nombre_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Nombre_del_Tutor);
        form_data.append('[' + i + '].Apellido_Paterno_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Paterno_del_Tutor);
        form_data.append('[' + i + '].Apellido_Materno_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Materno_del_Tutor);
        form_data.append('[' + i + '].Nombre_Completo_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Nombre_Completo_del_Tutor);
        form_data.append('[' + i + '].Fecha_de_Nacimiento_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Fecha_de_Nacimiento_del_Tutor);
        form_data.append('[' + i + '].Edad_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Edad_del_Tutor);
        form_data.append('[' + i + '].Sexo_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Sexo_del_Tutor);
        form_data.append('[' + i + '].Estado_Civil_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Estado_Civil_del_Tutor);
        form_data.append('[' + i + '].Tipo_de_Identificacion_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Tipo_de_Identificacion_del_Tutor);
        form_data.append('[' + i + '].Numero_de_Identificacion_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_de_Identificacion_del_Tutor);
        form_data.append('[' + i + '].Nacionalidad_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Nacionalidad_del_Tutor);
        form_data.append('[' + i + '].Escolaridad_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Escolaridad_del_Tutor);
        form_data.append('[' + i + '].Ocupacion_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Ocupacion_del_Tutor);
        form_data.append('[' + i + '].Pais_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Pais_del_Tutor);
        form_data.append('[' + i + '].Estado_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Estado_del_Tutor);
        form_data.append('[' + i + '].Municipio_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Municipio_del_Tutor);
        form_data.append('[' + i + '].Localidad_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Localidad_del_Tutor);
        form_data.append('[' + i + '].Colonia_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Colonia_del_Tutor);
        form_data.append('[' + i + '].Codigo_Postal_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Codigo_Postal_del_Tutor);
        form_data.append('[' + i + '].Calle_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Calle_del_Tutor);
        form_data.append('[' + i + '].Numero_Exterior_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_Exterior_del_Tutor);
        form_data.append('[' + i + '].Numero_Interior_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_Interior_del_Tutor);
        form_data.append('[' + i + '].Telefono_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Telefono_del_Tutor);
        form_data.append('[' + i + '].Extencion_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Extencion_del_Tutor);
        form_data.append('[' + i + '].Celular_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Celular_del_Tutor);
        form_data.append('[' + i + '].Correo_Electronico_del_Tutor', Detalle_de_Datos_de_la_Victima_MPIData[i].Correo_Electronico_del_Tutor);
        form_data.append('[' + i + '].Tipo_de_Compareciente', Detalle_de_Datos_de_la_Victima_MPIData[i].Tipo_de_Compareciente);
        form_data.append('[' + i + '].Narrativa_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Narrativa_de_los_Hechos);

        form_data.append('[' + i + '].Titulo_del_Hecho', Detalle_de_Datos_de_la_Victima_MPIData[i].Titulo_del_Hecho);
        form_data.append('[' + i + '].Prioridad_del_Hecho', Detalle_de_Datos_de_la_Victima_MPIData[i].Prioridad_del_Hecho);
        form_data.append('[' + i + '].Fecha_del_Hecho', Detalle_de_Datos_de_la_Victima_MPIData[i].Fecha_del_Hecho);
        form_data.append('[' + i + '].Hora_Aproximada_del_Hecho', Detalle_de_Datos_de_la_Victima_MPIData[i].Hora_Aproximada_del_Hecho);
        form_data.append('[' + i + '].Pais_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Pais_de_los_Hechos);
        form_data.append('[' + i + '].Estado_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Estado_de_los_Hechos);
        form_data.append('[' + i + '].Municipio_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Municipio_de_los_Hechos);
        form_data.append('[' + i + '].Colonia_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Colonia_de_los_Hechos);
        form_data.append('[' + i + '].Codigo_Postal_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Codigo_Postal_de_los_Hechos);
        form_data.append('[' + i + '].Calle_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Calle_de_los_Hechos);
        form_data.append('[' + i + '].Entre_Calle_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Entre_Calle_de_los_Hechos);
        form_data.append('[' + i + '].Y_Calle_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Y_Calle_de_los_Hechos);
        form_data.append('[' + i + '].Numero_Exterior_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_Exterior_de_los_Hechos);
        form_data.append('[' + i + '].Numero_Interior_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_Interior_de_los_Hechos);
        form_data.append('[' + i + '].Latitud_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Latitud_de_los_Hechos);
        form_data.append('[' + i + '].Longitud_de_los_Hechos', Detalle_de_Datos_de_la_Victima_MPIData[i].Longitud_de_los_Hechos);
        form_data.append('[' + i + '].Tipo_de_Lugar_del_Hecho', Detalle_de_Datos_de_la_Victima_MPIData[i].Tipo_de_Lugar_del_Hecho);
        form_data.append('[' + i + '].Proteccion_de_Datos', Detalle_de_Datos_de_la_Victima_MPIData[i].Proteccion_de_Datos);
        form_data.append('[' + i + '].Nombre_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Nombre_de_Persona_Moral);
        form_data.append('[' + i + '].Apellido_Paterno_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Paterno_de_Persona_Moral);
        form_data.append('[' + i + '].Apellido_Materno_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Apellido_Materno_de_Persona_Moral);
        form_data.append('[' + i + '].Fecha_de_Nacimiento_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Fecha_de_Nacimiento_de_Persona_Moral);
        form_data.append('[' + i + '].Edad_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Edad_de_Persona_Moral);
        form_data.append('[' + i + '].Sexo_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Sexo_de_Persona_Moral);
        form_data.append('[' + i + '].Estado_Civil_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Estado_Civil_de_Persona_Moral);
        form_data.append('[' + i + '].Tipo_de_Identificacion_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Tipo_de_Identificacion_de_Persona_Moral);
        form_data.append('[' + i + '].Numero_de_Identificacion_de_Persona_Mora', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_de_Identificacion_de_Persona_Mora);
        form_data.append('[' + i + '].Nacionalidad_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Nacionalidad_de_Persona_Moral);
        form_data.append('[' + i + '].Escolaridad_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Escolaridad_de_Persona_Moral);
        form_data.append('[' + i + '].Ocupacion_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Ocupacion_de_Persona_Moral);
        form_data.append('[' + i + '].Pais_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Pais_de_Persona_Moral);
        form_data.append('[' + i + '].Estado_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Estado_de_Persona_Moral);
        form_data.append('[' + i + '].Municipio_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Municipio_de_Persona_Moral);
        form_data.append('[' + i + '].Colonia_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Colonia_de_Persona_Moral);
        form_data.append('[' + i + '].Codigo_Postal_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Codigo_Postal_de_Persona_Moral);
        form_data.append('[' + i + '].Calle_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Calle_de_Persona_Moral);
        form_data.append('[' + i + '].Numero_Exterior_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_Exterior_de_Persona_Moral);
        form_data.append('[' + i + '].Numero_Interior_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Numero_Interior_de_Persona_Moral);
        form_data.append('[' + i + '].Entre_Calle_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Entre_Calle_de_Persona_Moral);
        form_data.append('[' + i + '].Y_Calle_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Y_Calle_de_Persona_Moral);
        form_data.append('[' + i + '].Longitud_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Longitud_de_Persona_Moral);
        form_data.append('[' + i + '].Latitud_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Latitud_de_Persona_Moral);
        form_data.append('[' + i + '].Telefono_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Telefono_de_Persona_Moral);
        form_data.append('[' + i + '].Extension_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Extension_de_Persona_Moral);
        form_data.append('[' + i + '].Celular_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Celular_de_Persona_Moral);
        form_data.append('[' + i + '].Correo_Electronico_de_Persona_Moral', Detalle_de_Datos_de_la_Victima_MPIData[i].Correo_Electronico_de_Persona_Moral);
        form_data.append('[' + i + '].Persona_Moral_Victima', Detalle_de_Datos_de_la_Victima_MPIData[i].Persona_Moral_Victima);

        form_data.append('[' + i + '].Removed', Detalle_de_Datos_de_la_Victima_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Datos_de_la_Victima_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_de_la_Victima_MPI("Detalle_de_Datos_de_la_Victima_MPITable", rowIndex)) {
    var prevData = Detalle_de_Datos_de_la_Victima_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_de_la_Victima_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre: $('#Detalle_de_Datos_de_la_Victima_MPINombre').val()
        ,Apellido_Paterno: $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Paterno').val()
        ,Apellido_Materno: $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Materno').val()
        ,Nombre_Completo: $('#Detalle_de_Datos_de_la_Victima_MPINombre_Completo').val()
        ,Fecha_de_Nacimiento: $('#Detalle_de_Datos_de_la_Victima_MPIFecha_de_Nacimiento').val()
        ,Edad: $('#Detalle_de_Datos_de_la_Victima_MPIEdad').val()

        ,Sexo: $('#Detalle_de_Datos_de_la_Victima_MPISexo').val()
        ,Estado_Civil: $('#Detalle_de_Datos_de_la_Victima_MPIEstado_Civil').val()
        ,Tipo_de_Identificacion: $('#Detalle_de_Datos_de_la_Victima_MPITipo_de_Identificacion').val()
        ,Numero_de_Identificacion: $('#Detalle_de_Datos_de_la_Victima_MPINumero_de_Identificacion').val()
        ,Nacionalidad: $('#Detalle_de_Datos_de_la_Victima_MPINacionalidad').val()
        ,Escolaridad: $('#Detalle_de_Datos_de_la_Victima_MPIEscolaridad').val()
        ,Ocupacion: $('#Detalle_de_Datos_de_la_Victima_MPIOcupacion').val()
        ,Pais: $('#Detalle_de_Datos_de_la_Victima_MPIPais').val()
        ,Estado: $('#Detalle_de_Datos_de_la_Victima_MPIEstado').val()
        ,Municipio: $('#Detalle_de_Datos_de_la_Victima_MPIMunicipio').val()
        ,Colonia: $('#Detalle_de_Datos_de_la_Victima_MPIColonia').val()
        ,Codigo_Postal: $('#Detalle_de_Datos_de_la_Victima_MPICodigo_Postal').val()

        ,Calle: $('#Detalle_de_Datos_de_la_Victima_MPICalle').val()
        ,Numero_Exterior: $('#Detalle_de_Datos_de_la_Victima_MPINumero_Exterior').val()
        ,Numero_Interior: $('#Detalle_de_Datos_de_la_Victima_MPINumero_Interior').val()
        ,Telefono: $('#Detalle_de_Datos_de_la_Victima_MPITelefono').val()
        ,Extencion: $('#Detalle_de_Datos_de_la_Victima_MPIExtencion').val()

        ,Celular: $('#Detalle_de_Datos_de_la_Victima_MPICelular').val()
        ,Correo_Electronico: $('#Detalle_de_Datos_de_la_Victima_MPICorreo_Electronico').val()
        ,Incapaz: $('#Detalle_de_Datos_de_la_Victima_MPIIncapaz').is(':checked')
        ,Nombre_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPINombre_del_Tutor').val()
        ,Apellido_Paterno_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Paterno_del_Tutor').val()
        ,Apellido_Materno_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Materno_del_Tutor').val()
        ,Nombre_Completo_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPINombre_Completo_del_Tutor').val()
        ,Fecha_de_Nacimiento_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIFecha_de_Nacimiento_del_Tutor').val()
        ,Edad_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIEdad_del_Tutor').val()

        ,Sexo_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPISexo_del_Tutor').val()
        ,Estado_Civil_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIEstado_Civil_del_Tutor').val()
        ,Tipo_de_Identificacion_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPITipo_de_Identificacion_del_Tutor').val()
        ,Numero_de_Identificacion_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPINumero_de_Identificacion_del_Tutor').val()
        ,Nacionalidad_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPINacionalidad_del_Tutor').val()
        ,Escolaridad_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIEscolaridad_del_Tutor').val()
        ,Ocupacion_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIOcupacion_del_Tutor').val()
        ,Pais_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIPais_del_Tutor').val()
        ,Estado_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIEstado_del_Tutor').val()
        ,Municipio_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIMunicipio_del_Tutor').val()
        ,Localidad_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPILocalidad_del_Tutor').val()
        ,Colonia_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIColonia_del_Tutor').val()
        ,Codigo_Postal_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPICodigo_Postal_del_Tutor').val()

        ,Calle_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPICalle_del_Tutor').val()
        ,Numero_Exterior_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPINumero_Exterior_del_Tutor').val()

        ,Numero_Interior_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPINumero_Interior_del_Tutor').val()
        ,Telefono_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPITelefono_del_Tutor').val()
        ,Extencion_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPIExtencion_del_Tutor').val()

        ,Celular_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPICelular_del_Tutor').val()
        ,Correo_Electronico_del_Tutor: $('#Detalle_de_Datos_de_la_Victima_MPICorreo_Electronico_del_Tutor').val()
        ,Tipo_de_Compareciente: $('#Detalle_de_Datos_de_la_Victima_MPITipo_de_Compareciente').val()
        ,Narrativa_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPINarrativa_de_los_Hechos').val()

        ,Titulo_del_Hecho: $('#Detalle_de_Datos_de_la_Victima_MPITitulo_del_Hecho').val()
        ,Prioridad_del_Hecho: $('#Detalle_de_Datos_de_la_Victima_MPIPrioridad_del_Hecho').val()
        ,Fecha_del_Hecho: $('#Detalle_de_Datos_de_la_Victima_MPIFecha_del_Hecho').val()
        ,Hora_Aproximada_del_Hecho: $('#Detalle_de_Datos_de_la_Victima_MPIHora_Aproximada_del_Hecho').val()
        ,Pais_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPIPais_de_los_Hechos').val()
        ,Estado_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPIEstado_de_los_Hechos').val()
        ,Municipio_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPIMunicipio_de_los_Hechos').val()
        ,Colonia_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPIColonia_de_los_Hechos').val()
        ,Codigo_Postal_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPICodigo_Postal_de_los_Hechos').val()

        ,Calle_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPICalle_de_los_Hechos').val()
        ,Entre_Calle_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPIEntre_Calle_de_los_Hechos').val()
        ,Y_Calle_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPIY_Calle_de_los_Hechos').val()
        ,Numero_Exterior_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPINumero_Exterior_de_los_Hechos').val()
        ,Numero_Interior_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPINumero_Interior_de_los_Hechos').val()
        ,Latitud_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPILatitud_de_los_Hechos').val()
        ,Longitud_de_los_Hechos: $('#Detalle_de_Datos_de_la_Victima_MPILongitud_de_los_Hechos').val()
        ,Tipo_de_Lugar_del_Hecho: $('#Detalle_de_Datos_de_la_Victima_MPITipo_de_Lugar_del_Hecho').val()
        ,Proteccion_de_Datos: $('#Detalle_de_Datos_de_la_Victima_MPIProteccion_de_Datos').is(':checked')
        ,Nombre_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPINombre_de_Persona_Moral').val()
        ,Apellido_Paterno_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Paterno_de_Persona_Moral').val()
        ,Apellido_Materno_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIApellido_Materno_de_Persona_Moral').val()
        ,Fecha_de_Nacimiento_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIFecha_de_Nacimiento_de_Persona_Moral').val()
        ,Edad_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIEdad_de_Persona_Moral').val()

        ,Sexo_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPISexo_de_Persona_Moral').val()
        ,Estado_Civil_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIEstado_Civil_de_Persona_Moral').val()
        ,Tipo_de_Identificacion_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPITipo_de_Identificacion_de_Persona_Moral').val()
        ,Numero_de_Identificacion_de_Persona_Mora: $('#Detalle_de_Datos_de_la_Victima_MPINumero_de_Identificacion_de_Persona_Mora').val()
        ,Nacionalidad_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPINacionalidad_de_Persona_Moral').val()
        ,Escolaridad_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIEscolaridad_de_Persona_Moral').val()
        ,Ocupacion_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIOcupacion_de_Persona_Moral').val()
        ,Pais_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIPais_de_Persona_Moral').val()
        ,Estado_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIEstado_de_Persona_Moral').val()
        ,Municipio_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIMunicipio_de_Persona_Moral').val()
        ,Colonia_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIColonia_de_Persona_Moral').val()
        ,Codigo_Postal_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPICodigo_Postal_de_Persona_Moral').val()

        ,Calle_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPICalle_de_Persona_Moral').val()
        ,Numero_Exterior_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPINumero_Exterior_de_Persona_Moral').val()
        ,Numero_Interior_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPINumero_Interior_de_Persona_Moral').val()
        ,Entre_Calle_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIEntre_Calle_de_Persona_Moral').val()
        ,Y_Calle_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIY_Calle_de_Persona_Moral').val()
        ,Longitud_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPILongitud_de_Persona_Moral').val()
        ,Latitud_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPILatitud_de_Persona_Moral').val()
        ,Telefono_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPITelefono_de_Persona_Moral').val()
        ,Extension_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPIExtension_de_Persona_Moral').val()
        ,Celular_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPICelular_de_Persona_Moral').val()
        ,Correo_Electronico_de_Persona_Moral: $('#Detalle_de_Datos_de_la_Victima_MPICorreo_Electronico_de_Persona_Moral').val()
        ,Persona_Moral_Victima: $('#Detalle_de_Datos_de_la_Victima_MPIPersona_Moral_Victima').is(':checked')

    }

    Detalle_de_Datos_de_la_Victima_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Datos_de_la_Victima_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Datos_de_la_Victima_MPI-form').modal({ show: false });
    $('#AddDetalle_de_Datos_de_la_Victima_MPI-form').modal('hide');
    Detalle_de_Datos_de_la_Victima_MPIEditRow(rowIndex);
    Detalle_de_Datos_de_la_Victima_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_Datos_de_la_Victima_MPIRemoveAddRow(rowIndex) {
    Detalle_de_Datos_de_la_Victima_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Datos_de_la_Victima_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Datos_del_Imputado_MPI MultiRow
var Detalle_de_Datos_del_Imputado_MPIcountRowsChecked = 0;






function GetDetalle_de_Datos_del_Imputado_MPI_GeneroName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_GeneroItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_GeneroItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_GeneroDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_GeneroDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_GeneroItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_GeneroItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_GeneroDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_GeneroDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Estado_CivilDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Estado_CivilDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Estado_CivilDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Estado_CivilDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropdown;
}

function GetDetalle_de_Datos_del_Imputado_MPI_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_NacionalidadDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_NacionalidadDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_de_Datos_del_Imputado_MPI_NacionalidadDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_NacionalidadDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_EscolaridadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_EscolaridadDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_EscolaridadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_EscolaridadDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_EscolaridadDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_EscolaridadDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_OcupacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_OcupacionItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_OcupacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_OcupacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_OcupacionDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_OcupacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_OcupacionDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_OcupacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_OcupacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_OcupacionItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_OcupacionItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_OcupacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_OcupacionDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_EstadoDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_MunicipioDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown;
}

function GetDetalle_de_Datos_del_Imputado_MPI_LocalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_LocalidadItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_LocalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_LocalidadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_LocalidadDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_LocalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_LocalidadDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_LocalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_LocalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_LocalidadItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_LocalidadItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_LocalidadDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_LocalidadDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_ColoniaDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown;
}







function GetDetalle_de_Datos_del_Imputado_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_PaisItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_PaisDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_PaisDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_PaisDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Forma_CaraName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Forma_CaraItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Forma_CaraItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Forma_CaraItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Forma_CaraDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Forma_CaraDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Forma_CaraDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Forma_CaraItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Forma_CaraItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Forma_CaraItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Forma_CaraItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Forma_CaraDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Forma_CaraDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_CejasName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_CejasItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_CejasItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_CejasItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_CejasDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_CejasDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_CejasDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_CejasItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_CejasItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_CejasItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_CejasItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_CejasDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_CejasDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_ComplexionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_ComplexionItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_ComplexionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_ComplexionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_ComplexionDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_ComplexionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_ComplexionDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_ComplexionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_ComplexionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_ComplexionItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_ComplexionItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_ComplexionDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_ComplexionDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Color_PielName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Color_PielItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Color_PielItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Color_PielItems[i].Descrpicion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Color_PielDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Color_PielDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Color_PielDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Color_PielItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Color_PielItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Color_PielItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Color_PielItems[i].Descrpicion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Color_PielDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Color_PielDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_FrenteName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_FrenteItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_FrenteItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_FrenteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_FrenteDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_FrenteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_FrenteDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_FrenteItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_FrenteItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_FrenteItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_FrenteItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_FrenteDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_FrenteDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Forma_CabelloName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Forma_CabelloDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Forma_CabelloDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_CalvicieName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_CalvicieItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_CalvicieItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_CalvicieItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_CalvicieDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_CalvicieDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_CalvicieDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_CalvicieItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_CalvicieItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_CalvicieItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_CalvicieItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_CalvicieDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_CalvicieDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Color_OjosName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Color_OjosItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Color_OjosItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Color_OjosItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Color_OjosDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Color_OjosDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Color_OjosDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Color_OjosItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Color_OjosItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Color_OjosItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Color_OjosItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Color_OjosDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Color_OjosDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_OjosName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_OjosItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_OjosItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_OjosItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_OjosDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_OjosDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_OjosDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_OjosItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_OjosItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_OjosItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_OjosItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_OjosDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_OjosDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Froma_OjosName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Froma_OjosItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Froma_OjosItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Froma_OjosItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Froma_OjosDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Froma_OjosDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Froma_OjosDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Froma_OjosItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Froma_OjosItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Froma_OjosItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Froma_OjosItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Froma_OjosDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Froma_OjosDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Nariz_BaseName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Nariz_BaseDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Nariz_BaseDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_LabiosName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_LabiosItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_LabiosItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_LabiosItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_LabiosDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_LabiosDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_LabiosDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_LabiosItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_LabiosItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_LabiosItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_LabiosItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_LabiosDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_LabiosDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_BocaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_BocaItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_BocaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_BocaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_BocaDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_BocaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_BocaDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_BocaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_BocaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_BocaItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_BocaItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_BocaDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_BocaDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_MentonName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_MentonItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_MentonItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_MentonItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_MentonDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_MentonDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_MentonDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_MentonItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_MentonItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_MentonItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_MentonItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_MentonDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_MentonDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_BarbaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_BarbaItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_BarbaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_BarbaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_BarbaDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_BarbaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_BarbaDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_BarbaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_BarbaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_BarbaItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_BarbaItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_BarbaDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_BarbaDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Forma_OrejasName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Forma_OrejasName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Tipo_LobuloName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Tipo_LobuloDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Tipo_LobuloDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_BigoteName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_BigoteItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_BigoteItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_BigoteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_BigoteDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_BigoteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_BigoteDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_BigoteItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_BigoteItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_BigoteItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_BigoteItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_BigoteDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_BigoteDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Situacion_FisicaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Situacion_FisicaDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Situacion_FisicaDropdown;
}





function GetDetalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIDropdown;
}



function GetDetalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropdown;
}



function GetDetalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropdown;
}


function GetDetalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoDropdown;
}


function GetDetalle_de_Datos_del_Imputado_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_PaisItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_PaisDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_PaisDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_PaisDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_EstadoDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_MunicipioDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_ColoniaDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown;
}








function GetDetalle_de_Datos_del_Imputado_MPI_Lugar_TipoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Lugar_TipoDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Lugar_TipoDropdown;
}







function GetDetalle_de_Datos_del_Imputado_MPI_GeneroName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_GeneroItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_GeneroItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_GeneroDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_GeneroDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_GeneroItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_GeneroItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_GeneroDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_GeneroDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Estado_CivilDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Estado_CivilDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Estado_CivilDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Estado_CivilDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropdown;
}

function GetDetalle_de_Datos_del_Imputado_MPI_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_NacionalidadDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_NacionalidadDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_de_Datos_del_Imputado_MPI_NacionalidadDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_NacionalidadDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_EscolaridadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_EscolaridadDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_EscolaridadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_EscolaridadDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_EscolaridadItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_EscolaridadDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_EscolaridadDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_OcupacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_OcupacionItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_OcupacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_OcupacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_OcupacionDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_OcupacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_OcupacionDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_OcupacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_OcupacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_OcupacionItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_OcupacionItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_OcupacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_OcupacionDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_PaisItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_PaisDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_PaisDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_PaisDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_EstadoDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_EstadoDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_MunicipioDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_MunicipioDropdown;
}
function GetDetalle_de_Datos_del_Imputado_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_ColoniaDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_ColoniaDropdown;
}










function GetDetalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoItems.length; i++) {
        if (Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoDropDown() {
    var Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoDropdown);
    if(Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoItems[i].Clave, text:    Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoDropdown);
       }
    }
    return Detalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoDropdown;
}



function GetInsertDetalle_de_Datos_del_Imputado_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Nombre Nombre').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Nombre_' + index).attr('data-field', 'Nombre');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Apellido_Paterno Apellido_Paterno').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Apellido_Paterno_' + index).attr('data-field', 'Apellido_Paterno');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Apellido_Materno Apellido_Materno').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Apellido_Materno_' + index).attr('data-field', 'Apellido_Materno');
    columnData[3] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_del_Imputado_MPI_Fecha_de_Nacimiento Fecha_de_Nacimiento').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Fecha_de_Nacimiento_' + index).attr('data-field', 'Fecha_de_Nacimiento');
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_MPI_Edad Edad').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Edad_' + index).attr('data-field', 'Edad');
    columnData[5] = $(GetDetalle_de_Datos_del_Imputado_MPI_GeneroDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Sexo Sexo').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Sexo_' + index).attr('data-field', 'Sexo').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Genero', 'Sexo', 264231)));
    columnData[6] = $(GetDetalle_de_Datos_del_Imputado_MPI_Estado_CivilDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Estado_Civil Estado_Civil').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Estado_Civil_' + index).attr('data-field', 'Estado_Civil').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Estado_Civil', 'Estado_Civil', 264232)));
    columnData[7] = $(GetDetalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Tipo_de_Identificacion Tipo_de_Identificacion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Tipo_de_Identificacion_' + index).attr('data-field', 'Tipo_de_Identificacion').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion', 264233)));
    columnData[8] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Numero_de_Identificacion Numero_de_Identificacion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Numero_de_Identificacion_' + index).attr('data-field', 'Numero_de_Identificacion');
    columnData[9] = $(GetDetalle_de_Datos_del_Imputado_MPI_NacionalidadDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Nacionalidad Nacionalidad').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Nacionalidad_' + index).attr('data-field', 'Nacionalidad').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Nacionalidad', 'Nacionalidad', 264235)));
    columnData[10] = $(GetDetalle_de_Datos_del_Imputado_MPI_EscolaridadDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Escolaridad Escolaridad').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Escolaridad_' + index).attr('data-field', 'Escolaridad').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Escolaridad', 'Escolaridad', 264236)));
    columnData[11] = $(GetDetalle_de_Datos_del_Imputado_MPI_OcupacionDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Ocupacion Ocupacion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Ocupacion_' + index).attr('data-field', 'Ocupacion').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Ocupacion', 'Ocupacion', 264237)));
    columnData[12] = $(GetDetalle_de_Datos_del_Imputado_MPI_EstadoDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Estado Estado').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Estado', 'Estado', 264238)));
    columnData[13] = $(GetDetalle_de_Datos_del_Imputado_MPI_MunicipioDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Municipio Municipio').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Municipio', 'Municipio', 264239)));
    columnData[14] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_MPI_Codigo_Postal Codigo_Postal').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[15] = $(GetDetalle_de_Datos_del_Imputado_MPI_LocalidadDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Localidad Localidad').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Localidad_' + index).attr('data-field', 'Localidad').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Localidad', 'Localidad', 264241)));
    columnData[16] = $(GetDetalle_de_Datos_del_Imputado_MPI_ColoniaDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Colonia Colonia').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Colonia', 'Colonia', 264242)));
    columnData[17] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Calle_del_Imputado Calle_del_Imputado').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Calle_del_Imputado_' + index).attr('data-field', 'Calle_del_Imputado');
    columnData[18] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Numero_Exterior Numero_Exterior').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[19] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Numero_Interior Numero_Interior').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[20] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Telefono Telefono').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Telefono_' + index).attr('data-field', 'Telefono');
    columnData[21] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_MPI_Extencion Extencion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Extencion_' + index).attr('data-field', 'Extencion');
    columnData[22] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Celular Celular').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Celular_' + index).attr('data-field', 'Celular');
    columnData[23] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Correo_Electronico Correo_Electronico').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');
    columnData[24] = $(GetDetalle_de_Datos_del_Imputado_MPI_PaisDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Pais Pais').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Pais_' + index).attr('data-field', 'Pais').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Pais', 'Pais', 264250)));
    columnData[25] = $(GetDetalle_de_Datos_del_Imputado_MPI_Forma_CaraDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Forma_Cara Forma_Cara').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Forma_Cara_' + index).attr('data-field', 'Forma_Cara').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Forma_Cara', 'Forma_Cara', 264251)));
    columnData[26] = $(GetDetalle_de_Datos_del_Imputado_MPI_CejasDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Cejas Cejas').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Cejas_' + index).attr('data-field', 'Cejas').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Cejas', 'Cejas', 264252)));
    columnData[27] = $(GetDetalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Cantidad_Cabello Cantidad_Cabello').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Cantidad_Cabello_' + index).attr('data-field', 'Cantidad_Cabello').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Cantidad_Cabello', 'Cantidad_Cabello', 264253)));
    columnData[28] = $(GetDetalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Implantacion_Cabello Implantacion_Cabello').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Implantacion_Cabello_' + index).attr('data-field', 'Implantacion_Cabello').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Implantacion_Cabello', 'Implantacion_Cabello', 264254)));
    columnData[29] = $(GetDetalle_de_Datos_del_Imputado_MPI_ComplexionDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Complexion Complexion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Complexion_' + index).attr('data-field', 'Complexion').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Complexion', 'Complexion', 264255)));
    columnData[30] = $(GetDetalle_de_Datos_del_Imputado_MPI_Color_PielDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Color_Piel Color_Piel').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Color_Piel_' + index).attr('data-field', 'Color_Piel').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Color_Piel', 'Color_Piel', 264256)));
    columnData[31] = $(GetDetalle_de_Datos_del_Imputado_MPI_FrenteDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Frente Frente').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Frente_' + index).attr('data-field', 'Frente').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Frente', 'Frente', 264257)));
    columnData[32] = $(GetDetalle_de_Datos_del_Imputado_MPI_Forma_CabelloDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Forma_Cabello Forma_Cabello').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Forma_Cabello_' + index).attr('data-field', 'Forma_Cabello').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Forma_Cabello', 'Forma_Cabello', 264258)));
    columnData[33] = $(GetDetalle_de_Datos_del_Imputado_MPI_CalvicieDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Calvicie Calvicie').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Calvicie_' + index).attr('data-field', 'Calvicie').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Calvicie', 'Calvicie', 264259)));
    columnData[34] = $(GetDetalle_de_Datos_del_Imputado_MPI_Color_OjosDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Color_Ojos Color_Ojos').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Color_Ojos_' + index).attr('data-field', 'Color_Ojos').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Color_Ojos', 'Color_Ojos', 264260)));
    columnData[35] = $(GetDetalle_de_Datos_del_Imputado_MPI_OjosDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Ojos Ojos').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Ojos_' + index).attr('data-field', 'Ojos').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Ojos', 'Ojos', 264261)));
    columnData[36] = $(GetDetalle_de_Datos_del_Imputado_MPI_Froma_OjosDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Forma_Ojos Forma_Ojos').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Forma_Ojos_' + index).attr('data-field', 'Forma_Ojos').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Froma_Ojos', 'Forma_Ojos', 264262)));
    columnData[37] = $(GetDetalle_de_Datos_del_Imputado_MPI_Nariz_BaseDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Nariz_Base Nariz_Base').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Nariz_Base_' + index).attr('data-field', 'Nariz_Base').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Nariz_Base', 'Nariz_Base', 264263)));
    columnData[38] = $(GetDetalle_de_Datos_del_Imputado_MPI_LabiosDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Labios Labios').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Labios_' + index).attr('data-field', 'Labios').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Labios', 'Labios', 264264)));
    columnData[39] = $(GetDetalle_de_Datos_del_Imputado_MPI_BocaDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Boca Boca').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Boca_' + index).attr('data-field', 'Boca').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Boca', 'Boca', 264265)));
    columnData[40] = $(GetDetalle_de_Datos_del_Imputado_MPI_MentonDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Menton Menton').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Menton_' + index).attr('data-field', 'Menton').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Menton', 'Menton', 264266)));
    columnData[41] = $(GetDetalle_de_Datos_del_Imputado_MPI_BarbaDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Barba Barba').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Barba_' + index).attr('data-field', 'Barba').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Barba', 'Barba', 264267)));
    columnData[42] = $(GetDetalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Forma_Orejas Forma_Orejas').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Forma_Orejas_' + index).attr('data-field', 'Forma_Orejas').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Forma_Orejas', 'Forma_Orejas', 264268)));
    columnData[43] = $(GetDetalle_de_Datos_del_Imputado_MPI_Forma_OrejasDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Tamano_Orejas Tamano_Orejas').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Tamano_Orejas_' + index).attr('data-field', 'Tamano_Orejas').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Forma_Orejas', 'Tamano_Orejas', 264269)));
    columnData[44] = $(GetDetalle_de_Datos_del_Imputado_MPI_Tipo_LobuloDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Tipo_Lobulo Tipo_Lobulo').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Tipo_Lobulo_' + index).attr('data-field', 'Tipo_Lobulo').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Tipo_Lobulo', 'Tipo_Lobulo', 264270)));
    columnData[45] = $(GetDetalle_de_Datos_del_Imputado_MPI_BigoteDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Bigote Bigote').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Bigote_' + index).attr('data-field', 'Bigote').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Bigote', 'Bigote', 264271)));
    columnData[46] = $(GetDetalle_de_Datos_del_Imputado_MPI_Situacion_FisicaDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Situacion_Fisica Situacion_Fisica').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Situacion_Fisica_' + index).attr('data-field', 'Situacion_Fisica').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Situacion_Fisica', 'Situacion_Fisica', 264272)));
    columnData[47] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Alias_media_diliacion Alias_media_diliacion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Alias_media_diliacion_' + index).attr('data-field', 'Alias_media_diliacion');
    columnData[48] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_del_Imputado_MPI_Fecha_de_Detencion Fecha_de_Detencion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Fecha_de_Detencion_' + index).attr('data-field', 'Fecha_de_Detencion');
    columnData[49] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Datos_del_Imputado_MPI_Hora_de_Detencion Hora_de_Detencion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Hora_de_Detencion_' + index).attr('data-field', 'Hora_de_Detencion');
    columnData[50] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_del_Imputado_MPI_Fecha_de_Puesto_a_Disposicion Fecha_de_Puesto_a_Disposicion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Fecha_de_Puesto_a_Disposicion_' + index).attr('data-field', 'Fecha_de_Puesto_a_Disposicion');
    columnData[51] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Datos_del_Imputado_MPI_Hora_de_Puesto_a_Disposicion Hora_de_Puesto_a_Disposicion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Hora_de_Puesto_a_Disposicion_' + index).attr('data-field', 'Hora_de_Puesto_a_Disposicion');
    columnData[52] = $(GetDetalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Con_Detenido Con_Detenido').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Con_Detenido_' + index).attr('data-field', 'Con_Detenido').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Catalogo_Estatus_Detenido_MPI', 'Con_Detenido', 264278)));
    columnData[53] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Imputado_MPI_A_Quien_Resulte_Responsable A_Quien_Resulte_Responsable').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_A_Quien_Resulte_Responsable_' + index).attr('data-field', 'A_Quien_Resulte_Responsable');
    columnData[54] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Tiempo_Restante_para_Vinculacion Tiempo_Restante_para_Vinculacion').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Tiempo_Restante_para_Vinculacion_' + index).attr('data-field', 'Tiempo_Restante_para_Vinculacion');
    columnData[55] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Imputado_MPI_Vincular Vincular').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Vincular_' + index).attr('data-field', 'Vincular');
    columnData[56] = $(GetDetalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Medidas_Cautelares Medidas_Cautelares').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Medidas_Cautelares_' + index).attr('data-field', 'Medidas_Cautelares').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Medidas_Cautelares', 'Medidas_Cautelares', 264282)));
    columnData[57] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Solicitar_Prorroga Solicitar_Prorroga').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Solicitar_Prorroga_' + index).attr('data-field', 'Solicitar_Prorroga');
    columnData[58] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Nuevo_Plazo Nuevo_Plazo').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Nuevo_Plazo_' + index).attr('data-field', 'Nuevo_Plazo');
    columnData[59] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Imputado_MPI_Orden_de_Aprehension Orden_de_Aprehension').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Orden_de_Aprehension_' + index).attr('data-field', 'Orden_de_Aprehension');
    columnData[60] = $(GetDetalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Medidas_Cautelares_en_Imputado Medidas_Cautelares_en_Imputado').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Medidas_Cautelares_en_Imputado_' + index).attr('data-field', 'Medidas_Cautelares_en_Imputado').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Medidas_Cautelares', 'Medidas_Cautelares_en_Imputado', 264286)));
    columnData[61] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Titulo_del_Hecho Titulo_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Titulo_del_Hecho_' + index).attr('data-field', 'Titulo_del_Hecho');
    columnData[62] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Narrativa_Breve_de_los_Hechos Narrativa_Breve_de_los_Hechos').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Narrativa_Breve_de_los_Hechos_' + index).attr('data-field', 'Narrativa_Breve_de_los_Hechos');
    columnData[63] = $(GetDetalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_Hecho Prioridad_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Prioridad_del_Hecho_' + index).attr('data-field', 'Prioridad_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Prioridad_del_Hecho', 'Prioridad_del_Hecho', 264289)));
    columnData[64] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_del_Imputado_MPI_Fecha_del_Hecho Fecha_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Fecha_del_Hecho_' + index).attr('data-field', 'Fecha_del_Hecho');
    columnData[65] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Datos_del_Imputado_MPI_Hora_Aproximada_del_Hecho Hora_Aproximada_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Hora_Aproximada_del_Hecho_' + index).attr('data-field', 'Hora_Aproximada_del_Hecho');
    columnData[66] = $(GetDetalle_de_Datos_del_Imputado_MPI_PaisDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Pais_del_Hecho Pais_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Pais_del_Hecho_' + index).attr('data-field', 'Pais_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Pais', 'Pais_del_Hecho', 264292)));
    columnData[67] = $(GetDetalle_de_Datos_del_Imputado_MPI_EstadoDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Estado_del_Hecho Estado_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Estado_del_Hecho_' + index).attr('data-field', 'Estado_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Estado', 'Estado_del_Hecho', 264293)));
    columnData[68] = $(GetDetalle_de_Datos_del_Imputado_MPI_MunicipioDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Municipio_del_Hecho Municipio_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Municipio_del_Hecho_' + index).attr('data-field', 'Municipio_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Municipio', 'Municipio_del_Hecho', 264294)));
    columnData[69] = $(GetDetalle_de_Datos_del_Imputado_MPI_ColoniaDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Colonia_del_Hecho Colonia_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Colonia_del_Hecho_' + index).attr('data-field', 'Colonia_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Colonia', 'Colonia_del_Hecho', 264295)));
    columnData[70] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_MPI_Codigo_Postal_del_Hecho Codigo_Postal_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Codigo_Postal_del_Hecho_' + index).attr('data-field', 'Codigo_Postal_del_Hecho');
    columnData[71] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Calle_del_Hecho Calle_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Calle_del_Hecho_' + index).attr('data-field', 'Calle_del_Hecho');
    columnData[72] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Entre_Calle_del_Hecho Entre_Calle_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Entre_Calle_del_Hecho_' + index).attr('data-field', 'Entre_Calle_del_Hecho');
    columnData[73] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Y_Calle_del_Hecho Y_Calle_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Y_Calle_del_Hecho_' + index).attr('data-field', 'Y_Calle_del_Hecho');
    columnData[74] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Numero_Exterior_del_Hecho Numero_Exterior_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Numero_Exterior_del_Hecho_' + index).attr('data-field', 'Numero_Exterior_del_Hecho');
    columnData[75] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Numero_Interior_del_Hecho Numero_Interior_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Numero_Interior_del_Hecho_' + index).attr('data-field', 'Numero_Interior_del_Hecho');
    columnData[76] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Latitud_del_Hecho Latitud_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Latitud_del_Hecho_' + index).attr('data-field', 'Latitud_del_Hecho');
    columnData[77] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_MPI_Longitud_del_Hecho Longitud_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Longitud_del_Hecho_' + index).attr('data-field', 'Longitud_del_Hecho');
    columnData[78] = $(GetDetalle_de_Datos_del_Imputado_MPI_Lugar_TipoDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Tipo_de_Lugar_del_Hecho Tipo_de_Lugar_del_Hecho').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Tipo_de_Lugar_del_Hecho_' + index).attr('data-field', 'Tipo_de_Lugar_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Lugar_Tipo', 'Tipo_de_Lugar_del_Hecho', 264304)));

    columnData[79] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Imputado_MPI_Incapaz Incapaz').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Incapaz_' + index).attr('data-field', 'Incapaz');
    columnData[80] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Nombre_del_Tutor Nombre_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Nombre_del_Tutor_' + index).attr('data-field', 'Nombre_del_Tutor');
    columnData[81] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Apellido_Paterno_del_Tutor Apellido_Paterno_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Apellido_Paterno_del_Tutor_' + index).attr('data-field', 'Apellido_Paterno_del_Tutor');
    columnData[82] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Apellido_Materno_del_Tutor Apellido_Materno_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Apellido_Materno_del_Tutor_' + index).attr('data-field', 'Apellido_Materno_del_Tutor');
    columnData[83] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_del_Imputado_MPI_Fecha_de_Nacimiento_del_Tutor Fecha_de_Nacimiento_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Fecha_de_Nacimiento_del_Tutor_' + index).attr('data-field', 'Fecha_de_Nacimiento_del_Tutor');
    columnData[84] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_MPI_Edad_del_Tutor Edad_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Edad_del_Tutor_' + index).attr('data-field', 'Edad_del_Tutor');
    columnData[85] = $(GetDetalle_de_Datos_del_Imputado_MPI_GeneroDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Sexo_del_Tutor Sexo_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Sexo_del_Tutor_' + index).attr('data-field', 'Sexo_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Genero', 'Sexo_del_Tutor', 264312)));
    columnData[86] = $(GetDetalle_de_Datos_del_Imputado_MPI_Estado_CivilDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Estado_Civil_del_Tutor Estado_Civil_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Estado_Civil_del_Tutor_' + index).attr('data-field', 'Estado_Civil_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Estado_Civil', 'Estado_Civil_del_Tutor', 264313)));
    columnData[87] = $(GetDetalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Tipo_de_Identificacion_del_Tutor Tipo_de_Identificacion_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Tipo_de_Identificacion_del_Tutor_' + index).attr('data-field', 'Tipo_de_Identificacion_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion_del_Tutor', 264314)));
    columnData[88] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Numero_de_Identificacion_del_Tutor Numero_de_Identificacion_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Numero_de_Identificacion_del_Tutor_' + index).attr('data-field', 'Numero_de_Identificacion_del_Tutor');
    columnData[89] = $(GetDetalle_de_Datos_del_Imputado_MPI_NacionalidadDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Nacionalidad_del_Tutor Nacionalidad_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Nacionalidad_del_Tutor_' + index).attr('data-field', 'Nacionalidad_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Nacionalidad', 'Nacionalidad_del_Tutor', 264316)));
    columnData[90] = $(GetDetalle_de_Datos_del_Imputado_MPI_EscolaridadDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Escolaridad_del_Tutor Escolaridad_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Escolaridad_del_Tutor_' + index).attr('data-field', 'Escolaridad_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Escolaridad', 'Escolaridad_del_Tutor', 264317)));
    columnData[91] = $(GetDetalle_de_Datos_del_Imputado_MPI_OcupacionDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Ocupacion_del_Tutor Ocupacion_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Ocupacion_del_Tutor_' + index).attr('data-field', 'Ocupacion_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Ocupacion', 'Ocupacion_del_Tutor', 264318)));
    columnData[92] = $(GetDetalle_de_Datos_del_Imputado_MPI_PaisDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Pais_del_Tutor Pais_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Pais_del_Tutor_' + index).attr('data-field', 'Pais_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Pais', 'Pais_del_Tutor', 264319)));
    columnData[93] = $(GetDetalle_de_Datos_del_Imputado_MPI_EstadoDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Estado_del_Tutor Estado_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Estado_del_Tutor_' + index).attr('data-field', 'Estado_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Estado', 'Estado_del_Tutor', 264320)));
    columnData[94] = $(GetDetalle_de_Datos_del_Imputado_MPI_MunicipioDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Municipio_del_Tutor Municipio_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Municipio_del_Tutor_' + index).attr('data-field', 'Municipio_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Municipio', 'Municipio_del_Tutor', 264321)));
    columnData[95] = $(GetDetalle_de_Datos_del_Imputado_MPI_ColoniaDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Colonia_del_Tutor Colonia_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Colonia_del_Tutor_' + index).attr('data-field', 'Colonia_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Colonia', 'Colonia_del_Tutor', 264322)));
    columnData[96] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_MPI_Codigo_Postal_del_Tutor Codigo_Postal_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Codigo_Postal_del_Tutor_' + index).attr('data-field', 'Codigo_Postal_del_Tutor');
    columnData[97] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Calle_del_Tutor Calle_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Calle_del_Tutor_' + index).attr('data-field', 'Calle_del_Tutor');
    columnData[98] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Numero_Exterior_del_Tutor Numero_Exterior_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Numero_Exterior_del_Tutor_' + index).attr('data-field', 'Numero_Exterior_del_Tutor');
    columnData[99] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Numero_Interior_del_Tutor Numero_Interior_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Numero_Interior_del_Tutor_' + index).attr('data-field', 'Numero_Interior_del_Tutor');
    columnData[100] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Telefono_del_Tutor Telefono_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Telefono_del_Tutor_' + index).attr('data-field', 'Telefono_del_Tutor');
    columnData[101] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Imputado_MPI_Extension_del_Tutor Extension_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Extension_del_Tutor_' + index).attr('data-field', 'Extension_del_Tutor');
    columnData[102] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Celular_del_Tutor Celular_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Celular_del_Tutor_' + index).attr('data-field', 'Celular_del_Tutor');
    columnData[103] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Imputado_MPI_Correo_Electronico_del_Tutor Correo_Electronico_del_Tutor').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Correo_Electronico_del_Tutor_' + index).attr('data-field', 'Correo_Electronico_del_Tutor');
    columnData[104] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Imputado_MPI_Proteccion_de_Datos Proteccion_de_Datos').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Proteccion_de_Datos_' + index).attr('data-field', 'Proteccion_de_Datos');

    columnData[105] = $(GetDetalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoDropDown()).addClass('Detalle_de_Datos_del_Imputado_MPI_Estatus Estatus').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Estatus_' + index).attr('data-field', 'Estatus').after($.parseHTML(addNew('Detalle_de_Datos_del_Imputado_MPI', 'Estatus_del_Imputado', 'Estatus', 264334)));
    columnData[106] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Imputado_MPI_Judicializar Judicializar').attr('id', 'Detalle_de_Datos_del_Imputado_MPI_Judicializar_' + index).attr('data-field', 'Judicializar');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Datos_del_Imputado_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_del_Imputado_MPI("Detalle_de_Datos_del_Imputado_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_Datos_del_Imputado_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Datos_del_Imputado_MPI';
    var prevData = Detalle_de_Datos_del_Imputado_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Imputado_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Nacimiento:  data.childNodes[counter++].childNodes[0].value
        ,Edad: data.childNodes[counter++].childNodes[0].value
        ,Sexo:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad:  data.childNodes[counter++].childNodes[0].value
        ,Escolaridad:  data.childNodes[counter++].childNodes[0].value
        ,Ocupacion:  data.childNodes[counter++].childNodes[0].value
        ,Estado:  data.childNodes[counter++].childNodes[0].value
        ,Municipio:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal: data.childNodes[counter++].childNodes[0].value
        ,Localidad:  data.childNodes[counter++].childNodes[0].value
        ,Colonia:  data.childNodes[counter++].childNodes[0].value
        ,Calle_del_Imputado:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value
        ,Telefono:  data.childNodes[counter++].childNodes[0].value
        ,Extencion: data.childNodes[counter++].childNodes[0].value
        ,Celular:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value
        ,Pais:  data.childNodes[counter++].childNodes[0].value
        ,Forma_Cara:  data.childNodes[counter++].childNodes[0].value
        ,Cejas:  data.childNodes[counter++].childNodes[0].value
        ,Cantidad_Cabello:  data.childNodes[counter++].childNodes[0].value
        ,Implantacion_Cabello:  data.childNodes[counter++].childNodes[0].value
        ,Complexion:  data.childNodes[counter++].childNodes[0].value
        ,Color_Piel:  data.childNodes[counter++].childNodes[0].value
        ,Frente:  data.childNodes[counter++].childNodes[0].value
        ,Forma_Cabello:  data.childNodes[counter++].childNodes[0].value
        ,Calvicie:  data.childNodes[counter++].childNodes[0].value
        ,Color_Ojos:  data.childNodes[counter++].childNodes[0].value
        ,Ojos:  data.childNodes[counter++].childNodes[0].value
        ,Forma_Ojos:  data.childNodes[counter++].childNodes[0].value
        ,Nariz_Base:  data.childNodes[counter++].childNodes[0].value
        ,Labios:  data.childNodes[counter++].childNodes[0].value
        ,Boca:  data.childNodes[counter++].childNodes[0].value
        ,Menton:  data.childNodes[counter++].childNodes[0].value
        ,Barba:  data.childNodes[counter++].childNodes[0].value
        ,Forma_Orejas:  data.childNodes[counter++].childNodes[0].value
        ,Tamano_Orejas:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_Lobulo:  data.childNodes[counter++].childNodes[0].value
        ,Bigote:  data.childNodes[counter++].childNodes[0].value
        ,Situacion_Fisica:  data.childNodes[counter++].childNodes[0].value
        ,Alias_media_diliacion:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Detencion:  data.childNodes[counter++].childNodes[0].value
        ,Hora_de_Detencion:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Puesto_a_Disposicion:  data.childNodes[counter++].childNodes[0].value
        ,Hora_de_Puesto_a_Disposicion:  data.childNodes[counter++].childNodes[0].value
        ,Con_Detenido:  data.childNodes[counter++].childNodes[0].value
        ,A_Quien_Resulte_Responsable: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Tiempo_Restante_para_Vinculacion:  data.childNodes[counter++].childNodes[0].value
        ,Vincular: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Medidas_Cautelares:  data.childNodes[counter++].childNodes[0].value
        ,Solicitar_Prorroga:  data.childNodes[counter++].childNodes[0].value
        ,Nuevo_Plazo:  data.childNodes[counter++].childNodes[0].value
        ,Orden_de_Aprehension: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Medidas_Cautelares_en_Imputado:  data.childNodes[counter++].childNodes[0].value
        ,Titulo_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Narrativa_Breve_de_los_Hechos:  data.childNodes[counter++].childNodes[0].value
        ,Prioridad_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Hora_Aproximada_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Pais_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Estado_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Municipio_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Colonia_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal_del_Hecho: data.childNodes[counter++].childNodes[0].value
        ,Calle_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Entre_Calle_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Y_Calle_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Latitud_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Longitud_del_Hecho: data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Lugar_del_Hecho:  data.childNodes[counter++].childNodes[0].value

        ,Incapaz: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Nombre_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Nacimiento_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Edad_del_Tutor: data.childNodes[counter++].childNodes[0].value
        ,Sexo_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Escolaridad_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Ocupacion_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Pais_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Estado_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Municipio_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Colonia_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal_del_Tutor: data.childNodes[counter++].childNodes[0].value
        ,Calle_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Telefono_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Extension_del_Tutor: data.childNodes[counter++].childNodes[0].value
        ,Celular_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Proteccion_de_Datos: $(data.childNodes[counter++].childNodes[2]).is(':checked')

        ,Estatus:  data.childNodes[counter++].childNodes[0].value
        ,Judicializar: $(data.childNodes[counter++].childNodes[2]).is(':checked')

    }
    Detalle_de_Datos_del_Imputado_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Datos_del_Imputado_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Datos_del_Imputado_MPITable.fnPageChange(iPage);
    Detalle_de_Datos_del_Imputado_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Datos_del_Imputado_MPI("Detalle_de_Datos_del_Imputado_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_Datos_del_Imputado_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_Datos_del_Imputado_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Imputado_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Datos_del_Imputado_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Datos_del_Imputado_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Datos_del_Imputado_MPIGrid(Detalle_de_Datos_del_Imputado_MPITable.fnGetData());
    Detalle_de_Datos_del_Imputado_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Datos_del_Imputado_MPIFromDataTable() {
    var Detalle_de_Datos_del_Imputado_MPIData = [];
    var gridData = Detalle_de_Datos_del_Imputado_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Datos_del_Imputado_MPIData.push({
                Clave: gridData[i].Clave

                ,Nombre: gridData[i].Nombre
                ,Apellido_Paterno: gridData[i].Apellido_Paterno
                ,Apellido_Materno: gridData[i].Apellido_Materno
                ,Fecha_de_Nacimiento: gridData[i].Fecha_de_Nacimiento
                ,Edad: gridData[i].Edad
                ,Sexo: gridData[i].Sexo
                ,Estado_Civil: gridData[i].Estado_Civil
                ,Tipo_de_Identificacion: gridData[i].Tipo_de_Identificacion
                ,Numero_de_Identificacion: gridData[i].Numero_de_Identificacion
                ,Nacionalidad: gridData[i].Nacionalidad
                ,Escolaridad: gridData[i].Escolaridad
                ,Ocupacion: gridData[i].Ocupacion
                ,Estado: gridData[i].Estado
                ,Municipio: gridData[i].Municipio
                ,Codigo_Postal: gridData[i].Codigo_Postal
                ,Localidad: gridData[i].Localidad
                ,Colonia: gridData[i].Colonia
                ,Calle_del_Imputado: gridData[i].Calle_del_Imputado
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior
                ,Telefono: gridData[i].Telefono
                ,Extencion: gridData[i].Extencion
                ,Celular: gridData[i].Celular
                ,Correo_Electronico: gridData[i].Correo_Electronico
                ,Pais: gridData[i].Pais
                ,Forma_Cara: gridData[i].Forma_Cara
                ,Cejas: gridData[i].Cejas
                ,Cantidad_Cabello: gridData[i].Cantidad_Cabello
                ,Implantacion_Cabello: gridData[i].Implantacion_Cabello
                ,Complexion: gridData[i].Complexion
                ,Color_Piel: gridData[i].Color_Piel
                ,Frente: gridData[i].Frente
                ,Forma_Cabello: gridData[i].Forma_Cabello
                ,Calvicie: gridData[i].Calvicie
                ,Color_Ojos: gridData[i].Color_Ojos
                ,Ojos: gridData[i].Ojos
                ,Forma_Ojos: gridData[i].Forma_Ojos
                ,Nariz_Base: gridData[i].Nariz_Base
                ,Labios: gridData[i].Labios
                ,Boca: gridData[i].Boca
                ,Menton: gridData[i].Menton
                ,Barba: gridData[i].Barba
                ,Forma_Orejas: gridData[i].Forma_Orejas
                ,Tamano_Orejas: gridData[i].Tamano_Orejas
                ,Tipo_Lobulo: gridData[i].Tipo_Lobulo
                ,Bigote: gridData[i].Bigote
                ,Situacion_Fisica: gridData[i].Situacion_Fisica
                ,Alias_media_diliacion: gridData[i].Alias_media_diliacion
                ,Fecha_de_Detencion: gridData[i].Fecha_de_Detencion
                ,Hora_de_Detencion: gridData[i].Hora_de_Detencion
                ,Fecha_de_Puesto_a_Disposicion: gridData[i].Fecha_de_Puesto_a_Disposicion
                ,Hora_de_Puesto_a_Disposicion: gridData[i].Hora_de_Puesto_a_Disposicion
                ,Con_Detenido: gridData[i].Con_Detenido
                ,A_Quien_Resulte_Responsable: gridData[i].A_Quien_Resulte_Responsable
                ,Tiempo_Restante_para_Vinculacion: gridData[i].Tiempo_Restante_para_Vinculacion
                ,Vincular: gridData[i].Vincular
                ,Medidas_Cautelares: gridData[i].Medidas_Cautelares
                ,Solicitar_Prorroga: gridData[i].Solicitar_Prorroga
                ,Nuevo_Plazo: gridData[i].Nuevo_Plazo
                ,Orden_de_Aprehension: gridData[i].Orden_de_Aprehension
                ,Medidas_Cautelares_en_Imputado: gridData[i].Medidas_Cautelares_en_Imputado
                ,Titulo_del_Hecho: gridData[i].Titulo_del_Hecho
                ,Narrativa_Breve_de_los_Hechos: gridData[i].Narrativa_Breve_de_los_Hechos
                ,Prioridad_del_Hecho: gridData[i].Prioridad_del_Hecho
                ,Fecha_del_Hecho: gridData[i].Fecha_del_Hecho
                ,Hora_Aproximada_del_Hecho: gridData[i].Hora_Aproximada_del_Hecho
                ,Pais_del_Hecho: gridData[i].Pais_del_Hecho
                ,Estado_del_Hecho: gridData[i].Estado_del_Hecho
                ,Municipio_del_Hecho: gridData[i].Municipio_del_Hecho
                ,Colonia_del_Hecho: gridData[i].Colonia_del_Hecho
                ,Codigo_Postal_del_Hecho: gridData[i].Codigo_Postal_del_Hecho
                ,Calle_del_Hecho: gridData[i].Calle_del_Hecho
                ,Entre_Calle_del_Hecho: gridData[i].Entre_Calle_del_Hecho
                ,Y_Calle_del_Hecho: gridData[i].Y_Calle_del_Hecho
                ,Numero_Exterior_del_Hecho: gridData[i].Numero_Exterior_del_Hecho
                ,Numero_Interior_del_Hecho: gridData[i].Numero_Interior_del_Hecho
                ,Latitud_del_Hecho: gridData[i].Latitud_del_Hecho
                ,Longitud_del_Hecho: gridData[i].Longitud_del_Hecho
                ,Tipo_de_Lugar_del_Hecho: gridData[i].Tipo_de_Lugar_del_Hecho

                ,Incapaz: gridData[i].Incapaz
                ,Nombre_del_Tutor: gridData[i].Nombre_del_Tutor
                ,Apellido_Paterno_del_Tutor: gridData[i].Apellido_Paterno_del_Tutor
                ,Apellido_Materno_del_Tutor: gridData[i].Apellido_Materno_del_Tutor
                ,Fecha_de_Nacimiento_del_Tutor: gridData[i].Fecha_de_Nacimiento_del_Tutor
                ,Edad_del_Tutor: gridData[i].Edad_del_Tutor
                ,Sexo_del_Tutor: gridData[i].Sexo_del_Tutor
                ,Estado_Civil_del_Tutor: gridData[i].Estado_Civil_del_Tutor
                ,Tipo_de_Identificacion_del_Tutor: gridData[i].Tipo_de_Identificacion_del_Tutor
                ,Numero_de_Identificacion_del_Tutor: gridData[i].Numero_de_Identificacion_del_Tutor
                ,Nacionalidad_del_Tutor: gridData[i].Nacionalidad_del_Tutor
                ,Escolaridad_del_Tutor: gridData[i].Escolaridad_del_Tutor
                ,Ocupacion_del_Tutor: gridData[i].Ocupacion_del_Tutor
                ,Pais_del_Tutor: gridData[i].Pais_del_Tutor
                ,Estado_del_Tutor: gridData[i].Estado_del_Tutor
                ,Municipio_del_Tutor: gridData[i].Municipio_del_Tutor
                ,Colonia_del_Tutor: gridData[i].Colonia_del_Tutor
                ,Codigo_Postal_del_Tutor: gridData[i].Codigo_Postal_del_Tutor
                ,Calle_del_Tutor: gridData[i].Calle_del_Tutor
                ,Numero_Exterior_del_Tutor: gridData[i].Numero_Exterior_del_Tutor
                ,Numero_Interior_del_Tutor: gridData[i].Numero_Interior_del_Tutor
                ,Telefono_del_Tutor: gridData[i].Telefono_del_Tutor
                ,Extension_del_Tutor: gridData[i].Extension_del_Tutor
                ,Celular_del_Tutor: gridData[i].Celular_del_Tutor
                ,Correo_Electronico_del_Tutor: gridData[i].Correo_Electronico_del_Tutor
                ,Proteccion_de_Datos: gridData[i].Proteccion_de_Datos

                ,Estatus: gridData[i].Estatus
                ,Judicializar: gridData[i].Judicializar

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Datos_del_Imputado_MPIData.length; i++) {
        if (removedDetalle_de_Datos_del_Imputado_MPIData[i] != null && removedDetalle_de_Datos_del_Imputado_MPIData[i].Clave > 0)
            Detalle_de_Datos_del_Imputado_MPIData.push({
                Clave: removedDetalle_de_Datos_del_Imputado_MPIData[i].Clave

                ,Nombre: removedDetalle_de_Datos_del_Imputado_MPIData[i].Nombre
                ,Apellido_Paterno: removedDetalle_de_Datos_del_Imputado_MPIData[i].Apellido_Paterno
                ,Apellido_Materno: removedDetalle_de_Datos_del_Imputado_MPIData[i].Apellido_Materno
                ,Fecha_de_Nacimiento: removedDetalle_de_Datos_del_Imputado_MPIData[i].Fecha_de_Nacimiento
                ,Edad: removedDetalle_de_Datos_del_Imputado_MPIData[i].Edad
                ,Sexo: removedDetalle_de_Datos_del_Imputado_MPIData[i].Sexo
                ,Estado_Civil: removedDetalle_de_Datos_del_Imputado_MPIData[i].Estado_Civil
                ,Tipo_de_Identificacion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Tipo_de_Identificacion
                ,Numero_de_Identificacion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Numero_de_Identificacion
                ,Nacionalidad: removedDetalle_de_Datos_del_Imputado_MPIData[i].Nacionalidad
                ,Escolaridad: removedDetalle_de_Datos_del_Imputado_MPIData[i].Escolaridad
                ,Ocupacion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Ocupacion
                ,Estado: removedDetalle_de_Datos_del_Imputado_MPIData[i].Estado
                ,Municipio: removedDetalle_de_Datos_del_Imputado_MPIData[i].Municipio
                ,Codigo_Postal: removedDetalle_de_Datos_del_Imputado_MPIData[i].Codigo_Postal
                ,Localidad: removedDetalle_de_Datos_del_Imputado_MPIData[i].Localidad
                ,Colonia: removedDetalle_de_Datos_del_Imputado_MPIData[i].Colonia
                ,Calle_del_Imputado: removedDetalle_de_Datos_del_Imputado_MPIData[i].Calle_del_Imputado
                ,Numero_Exterior: removedDetalle_de_Datos_del_Imputado_MPIData[i].Numero_Exterior
                ,Numero_Interior: removedDetalle_de_Datos_del_Imputado_MPIData[i].Numero_Interior
                ,Telefono: removedDetalle_de_Datos_del_Imputado_MPIData[i].Telefono
                ,Extencion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Extencion
                ,Celular: removedDetalle_de_Datos_del_Imputado_MPIData[i].Celular
                ,Correo_Electronico: removedDetalle_de_Datos_del_Imputado_MPIData[i].Correo_Electronico
                ,Pais: removedDetalle_de_Datos_del_Imputado_MPIData[i].Pais
                ,Forma_Cara: removedDetalle_de_Datos_del_Imputado_MPIData[i].Forma_Cara
                ,Cejas: removedDetalle_de_Datos_del_Imputado_MPIData[i].Cejas
                ,Cantidad_Cabello: removedDetalle_de_Datos_del_Imputado_MPIData[i].Cantidad_Cabello
                ,Implantacion_Cabello: removedDetalle_de_Datos_del_Imputado_MPIData[i].Implantacion_Cabello
                ,Complexion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Complexion
                ,Color_Piel: removedDetalle_de_Datos_del_Imputado_MPIData[i].Color_Piel
                ,Frente: removedDetalle_de_Datos_del_Imputado_MPIData[i].Frente
                ,Forma_Cabello: removedDetalle_de_Datos_del_Imputado_MPIData[i].Forma_Cabello
                ,Calvicie: removedDetalle_de_Datos_del_Imputado_MPIData[i].Calvicie
                ,Color_Ojos: removedDetalle_de_Datos_del_Imputado_MPIData[i].Color_Ojos
                ,Ojos: removedDetalle_de_Datos_del_Imputado_MPIData[i].Ojos
                ,Forma_Ojos: removedDetalle_de_Datos_del_Imputado_MPIData[i].Forma_Ojos
                ,Nariz_Base: removedDetalle_de_Datos_del_Imputado_MPIData[i].Nariz_Base
                ,Labios: removedDetalle_de_Datos_del_Imputado_MPIData[i].Labios
                ,Boca: removedDetalle_de_Datos_del_Imputado_MPIData[i].Boca
                ,Menton: removedDetalle_de_Datos_del_Imputado_MPIData[i].Menton
                ,Barba: removedDetalle_de_Datos_del_Imputado_MPIData[i].Barba
                ,Forma_Orejas: removedDetalle_de_Datos_del_Imputado_MPIData[i].Forma_Orejas
                ,Tamano_Orejas: removedDetalle_de_Datos_del_Imputado_MPIData[i].Tamano_Orejas
                ,Tipo_Lobulo: removedDetalle_de_Datos_del_Imputado_MPIData[i].Tipo_Lobulo
                ,Bigote: removedDetalle_de_Datos_del_Imputado_MPIData[i].Bigote
                ,Situacion_Fisica: removedDetalle_de_Datos_del_Imputado_MPIData[i].Situacion_Fisica
                ,Alias_media_diliacion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Alias_media_diliacion
                ,Fecha_de_Detencion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Fecha_de_Detencion
                ,Hora_de_Detencion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Hora_de_Detencion
                ,Fecha_de_Puesto_a_Disposicion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Fecha_de_Puesto_a_Disposicion
                ,Hora_de_Puesto_a_Disposicion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Hora_de_Puesto_a_Disposicion
                ,Con_Detenido: removedDetalle_de_Datos_del_Imputado_MPIData[i].Con_Detenido
                ,A_Quien_Resulte_Responsable: removedDetalle_de_Datos_del_Imputado_MPIData[i].A_Quien_Resulte_Responsable
                ,Tiempo_Restante_para_Vinculacion: removedDetalle_de_Datos_del_Imputado_MPIData[i].Tiempo_Restante_para_Vinculacion
                ,Vincular: removedDetalle_de_Datos_del_Imputado_MPIData[i].Vincular
                ,Medidas_Cautelares: removedDetalle_de_Datos_del_Imputado_MPIData[i].Medidas_Cautelares
                ,Solicitar_Prorroga: removedDetalle_de_Datos_del_Imputado_MPIData[i].Solicitar_Prorroga
                ,Nuevo_Plazo: removedDetalle_de_Datos_del_Imputado_MPIData[i].Nuevo_Plazo
                ,Orden_de_Aprehension: removedDetalle_de_Datos_del_Imputado_MPIData[i].Orden_de_Aprehension
                ,Medidas_Cautelares_en_Imputado: removedDetalle_de_Datos_del_Imputado_MPIData[i].Medidas_Cautelares_en_Imputado
                ,Titulo_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Titulo_del_Hecho
                ,Narrativa_Breve_de_los_Hechos: removedDetalle_de_Datos_del_Imputado_MPIData[i].Narrativa_Breve_de_los_Hechos
                ,Prioridad_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Prioridad_del_Hecho
                ,Fecha_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Fecha_del_Hecho
                ,Hora_Aproximada_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Hora_Aproximada_del_Hecho
                ,Pais_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Pais_del_Hecho
                ,Estado_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Estado_del_Hecho
                ,Municipio_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Municipio_del_Hecho
                ,Colonia_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Colonia_del_Hecho
                ,Codigo_Postal_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Codigo_Postal_del_Hecho
                ,Calle_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Calle_del_Hecho
                ,Entre_Calle_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Entre_Calle_del_Hecho
                ,Y_Calle_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Y_Calle_del_Hecho
                ,Numero_Exterior_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Numero_Exterior_del_Hecho
                ,Numero_Interior_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Numero_Interior_del_Hecho
                ,Latitud_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Latitud_del_Hecho
                ,Longitud_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Longitud_del_Hecho
                ,Tipo_de_Lugar_del_Hecho: removedDetalle_de_Datos_del_Imputado_MPIData[i].Tipo_de_Lugar_del_Hecho

                ,Incapaz: removedDetalle_de_Datos_del_Imputado_MPIData[i].Incapaz
                ,Nombre_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Nombre_del_Tutor
                ,Apellido_Paterno_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Apellido_Paterno_del_Tutor
                ,Apellido_Materno_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Apellido_Materno_del_Tutor
                ,Fecha_de_Nacimiento_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Fecha_de_Nacimiento_del_Tutor
                ,Edad_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Edad_del_Tutor
                ,Sexo_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Sexo_del_Tutor
                ,Estado_Civil_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Estado_Civil_del_Tutor
                ,Tipo_de_Identificacion_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Tipo_de_Identificacion_del_Tutor
                ,Numero_de_Identificacion_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Numero_de_Identificacion_del_Tutor
                ,Nacionalidad_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Nacionalidad_del_Tutor
                ,Escolaridad_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Escolaridad_del_Tutor
                ,Ocupacion_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Ocupacion_del_Tutor
                ,Pais_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Pais_del_Tutor
                ,Estado_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Estado_del_Tutor
                ,Municipio_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Municipio_del_Tutor
                ,Colonia_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Colonia_del_Tutor
                ,Codigo_Postal_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Codigo_Postal_del_Tutor
                ,Calle_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Calle_del_Tutor
                ,Numero_Exterior_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Numero_Exterior_del_Tutor
                ,Numero_Interior_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Numero_Interior_del_Tutor
                ,Telefono_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Telefono_del_Tutor
                ,Extension_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Extension_del_Tutor
                ,Celular_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Celular_del_Tutor
                ,Correo_Electronico_del_Tutor: removedDetalle_de_Datos_del_Imputado_MPIData[i].Correo_Electronico_del_Tutor
                ,Proteccion_de_Datos: removedDetalle_de_Datos_del_Imputado_MPIData[i].Proteccion_de_Datos

                ,Estatus: removedDetalle_de_Datos_del_Imputado_MPIData[i].Estatus
                ,Judicializar: removedDetalle_de_Datos_del_Imputado_MPIData[i].Judicializar

                , Removed: true
            });
    }	

    return Detalle_de_Datos_del_Imputado_MPIData;
}

function Detalle_de_Datos_del_Imputado_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Datos_del_Imputado_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Datos_del_Imputado_MPIcountRowsChecked++;
    var Detalle_de_Datos_del_Imputado_MPIRowElement = "Detalle_de_Datos_del_Imputado_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Datos_del_Imputado_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_Datos_del_Imputado_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Datos_del_Imputado_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Datos_del_Imputado_MPIGetUpdateRowControls(prevData, "Detalle_de_Datos_del_Imputado_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Datos_del_Imputado_MPIRowElement + "')){ Detalle_de_Datos_del_Imputado_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Datos_del_Imputado_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Datos_del_Imputado_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Datos_del_Imputado_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Datos_del_Imputado_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_Datos_del_Imputado_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Datos_del_Imputado_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Datos_del_Imputado_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Datos_del_Imputado_MPITable.fnGetData().length;
    Detalle_de_Datos_del_Imputado_MPIfnClickAddRow();
    GetAddDetalle_de_Datos_del_Imputado_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_Datos_del_Imputado_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Datos_del_Imputado_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Datos_del_Imputado_MPIRowElement = "Detalle_de_Datos_del_Imputado_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Datos_del_Imputado_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Datos_del_Imputado_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Datos_del_Imputado_MPINombre').val(prevData.Nombre);
    $('#Detalle_de_Datos_del_Imputado_MPIApellido_Paterno').val(prevData.Apellido_Paterno);
    $('#Detalle_de_Datos_del_Imputado_MPIApellido_Materno').val(prevData.Apellido_Materno);
    $('#Detalle_de_Datos_del_Imputado_MPIFecha_de_Nacimiento').val(prevData.Fecha_de_Nacimiento);
    $('#Detalle_de_Datos_del_Imputado_MPIEdad').val(prevData.Edad);
    $('#Detalle_de_Datos_del_Imputado_MPISexo').val(prevData.Sexo);
    $('#Detalle_de_Datos_del_Imputado_MPIEstado_Civil').val(prevData.Estado_Civil);
    $('#Detalle_de_Datos_del_Imputado_MPITipo_de_Identificacion').val(prevData.Tipo_de_Identificacion);
    $('#Detalle_de_Datos_del_Imputado_MPINumero_de_Identificacion').val(prevData.Numero_de_Identificacion);
    $('#Detalle_de_Datos_del_Imputado_MPINacionalidad').val(prevData.Nacionalidad);
    $('#Detalle_de_Datos_del_Imputado_MPIEscolaridad').val(prevData.Escolaridad);
    $('#Detalle_de_Datos_del_Imputado_MPIOcupacion').val(prevData.Ocupacion);
    $('#Detalle_de_Datos_del_Imputado_MPIEstado').val(prevData.Estado);
    $('#Detalle_de_Datos_del_Imputado_MPIMunicipio').val(prevData.Municipio);
    $('#Detalle_de_Datos_del_Imputado_MPICodigo_Postal').val(prevData.Codigo_Postal);
    $('#Detalle_de_Datos_del_Imputado_MPILocalidad').val(prevData.Localidad);
    $('#Detalle_de_Datos_del_Imputado_MPIColonia').val(prevData.Colonia);
    $('#Detalle_de_Datos_del_Imputado_MPICalle_del_Imputado').val(prevData.Calle_del_Imputado);
    $('#Detalle_de_Datos_del_Imputado_MPINumero_Exterior').val(prevData.Numero_Exterior);
    $('#Detalle_de_Datos_del_Imputado_MPINumero_Interior').val(prevData.Numero_Interior);
    $('#Detalle_de_Datos_del_Imputado_MPITelefono').val(prevData.Telefono);
    $('#Detalle_de_Datos_del_Imputado_MPIExtencion').val(prevData.Extencion);
    $('#Detalle_de_Datos_del_Imputado_MPICelular').val(prevData.Celular);
    $('#Detalle_de_Datos_del_Imputado_MPICorreo_Electronico').val(prevData.Correo_Electronico);
    $('#Detalle_de_Datos_del_Imputado_MPIPais').val(prevData.Pais);
    $('#Detalle_de_Datos_del_Imputado_MPIForma_Cara').val(prevData.Forma_Cara);
    $('#Detalle_de_Datos_del_Imputado_MPICejas').val(prevData.Cejas);
    $('#Detalle_de_Datos_del_Imputado_MPICantidad_Cabello').val(prevData.Cantidad_Cabello);
    $('#Detalle_de_Datos_del_Imputado_MPIImplantacion_Cabello').val(prevData.Implantacion_Cabello);
    $('#Detalle_de_Datos_del_Imputado_MPIComplexion').val(prevData.Complexion);
    $('#Detalle_de_Datos_del_Imputado_MPIColor_Piel').val(prevData.Color_Piel);
    $('#Detalle_de_Datos_del_Imputado_MPIFrente').val(prevData.Frente);
    $('#Detalle_de_Datos_del_Imputado_MPIForma_Cabello').val(prevData.Forma_Cabello);
    $('#Detalle_de_Datos_del_Imputado_MPICalvicie').val(prevData.Calvicie);
    $('#Detalle_de_Datos_del_Imputado_MPIColor_Ojos').val(prevData.Color_Ojos);
    $('#Detalle_de_Datos_del_Imputado_MPIOjos').val(prevData.Ojos);
    $('#Detalle_de_Datos_del_Imputado_MPIForma_Ojos').val(prevData.Forma_Ojos);
    $('#Detalle_de_Datos_del_Imputado_MPINariz_Base').val(prevData.Nariz_Base);
    $('#Detalle_de_Datos_del_Imputado_MPILabios').val(prevData.Labios);
    $('#Detalle_de_Datos_del_Imputado_MPIBoca').val(prevData.Boca);
    $('#Detalle_de_Datos_del_Imputado_MPIMenton').val(prevData.Menton);
    $('#Detalle_de_Datos_del_Imputado_MPIBarba').val(prevData.Barba);
    $('#Detalle_de_Datos_del_Imputado_MPIForma_Orejas').val(prevData.Forma_Orejas);
    $('#Detalle_de_Datos_del_Imputado_MPITamano_Orejas').val(prevData.Tamano_Orejas);
    $('#Detalle_de_Datos_del_Imputado_MPITipo_Lobulo').val(prevData.Tipo_Lobulo);
    $('#Detalle_de_Datos_del_Imputado_MPIBigote').val(prevData.Bigote);
    $('#Detalle_de_Datos_del_Imputado_MPISituacion_Fisica').val(prevData.Situacion_Fisica);
    $('#Detalle_de_Datos_del_Imputado_MPIAlias_media_diliacion').val(prevData.Alias_media_diliacion);
    $('#Detalle_de_Datos_del_Imputado_MPIFecha_de_Detencion').val(prevData.Fecha_de_Detencion);
    $('#Detalle_de_Datos_del_Imputado_MPIHora_de_Detencion').val(prevData.Hora_de_Detencion);
    $('#Detalle_de_Datos_del_Imputado_MPIFecha_de_Puesto_a_Disposicion').val(prevData.Fecha_de_Puesto_a_Disposicion);
    $('#Detalle_de_Datos_del_Imputado_MPIHora_de_Puesto_a_Disposicion').val(prevData.Hora_de_Puesto_a_Disposicion);
    $('#Detalle_de_Datos_del_Imputado_MPICon_Detenido').val(prevData.Con_Detenido);
    $('#Detalle_de_Datos_del_Imputado_MPIA_Quien_Resulte_Responsable').prop('checked', prevData.A_Quien_Resulte_Responsable);
    $('#Detalle_de_Datos_del_Imputado_MPITiempo_Restante_para_Vinculacion').val(prevData.Tiempo_Restante_para_Vinculacion);
    $('#Detalle_de_Datos_del_Imputado_MPIVincular').prop('checked', prevData.Vincular);
    $('#Detalle_de_Datos_del_Imputado_MPIMedidas_Cautelares').val(prevData.Medidas_Cautelares);
    $('#Detalle_de_Datos_del_Imputado_MPISolicitar_Prorroga').val(prevData.Solicitar_Prorroga);
    $('#Detalle_de_Datos_del_Imputado_MPINuevo_Plazo').val(prevData.Nuevo_Plazo);
    $('#Detalle_de_Datos_del_Imputado_MPIOrden_de_Aprehension').prop('checked', prevData.Orden_de_Aprehension);
    $('#Detalle_de_Datos_del_Imputado_MPIMedidas_Cautelares_en_Imputado').val(prevData.Medidas_Cautelares_en_Imputado);
    $('#Detalle_de_Datos_del_Imputado_MPITitulo_del_Hecho').val(prevData.Titulo_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPINarrativa_Breve_de_los_Hechos').val(prevData.Narrativa_Breve_de_los_Hechos);
    $('#Detalle_de_Datos_del_Imputado_MPIPrioridad_del_Hecho').val(prevData.Prioridad_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPIFecha_del_Hecho').val(prevData.Fecha_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPIHora_Aproximada_del_Hecho').val(prevData.Hora_Aproximada_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPIPais_del_Hecho').val(prevData.Pais_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPIEstado_del_Hecho').val(prevData.Estado_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPIMunicipio_del_Hecho').val(prevData.Municipio_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPIColonia_del_Hecho').val(prevData.Colonia_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPICodigo_Postal_del_Hecho').val(prevData.Codigo_Postal_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPICalle_del_Hecho').val(prevData.Calle_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPIEntre_Calle_del_Hecho').val(prevData.Entre_Calle_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPIY_Calle_del_Hecho').val(prevData.Y_Calle_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPINumero_Exterior_del_Hecho').val(prevData.Numero_Exterior_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPINumero_Interior_del_Hecho').val(prevData.Numero_Interior_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPILatitud_del_Hecho').val(prevData.Latitud_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPILongitud_del_Hecho').val(prevData.Longitud_del_Hecho);
    $('#Detalle_de_Datos_del_Imputado_MPITipo_de_Lugar_del_Hecho').val(prevData.Tipo_de_Lugar_del_Hecho);

    $('#Detalle_de_Datos_del_Imputado_MPIIncapaz').prop('checked', prevData.Incapaz);
    $('#Detalle_de_Datos_del_Imputado_MPINombre_del_Tutor').val(prevData.Nombre_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIApellido_Paterno_del_Tutor').val(prevData.Apellido_Paterno_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIApellido_Materno_del_Tutor').val(prevData.Apellido_Materno_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIFecha_de_Nacimiento_del_Tutor').val(prevData.Fecha_de_Nacimiento_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIEdad_del_Tutor').val(prevData.Edad_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPISexo_del_Tutor').val(prevData.Sexo_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIEstado_Civil_del_Tutor').val(prevData.Estado_Civil_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPITipo_de_Identificacion_del_Tutor').val(prevData.Tipo_de_Identificacion_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPINumero_de_Identificacion_del_Tutor').val(prevData.Numero_de_Identificacion_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPINacionalidad_del_Tutor').val(prevData.Nacionalidad_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIEscolaridad_del_Tutor').val(prevData.Escolaridad_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIOcupacion_del_Tutor').val(prevData.Ocupacion_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIPais_del_Tutor').val(prevData.Pais_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIEstado_del_Tutor').val(prevData.Estado_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIMunicipio_del_Tutor').val(prevData.Municipio_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIColonia_del_Tutor').val(prevData.Colonia_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPICodigo_Postal_del_Tutor').val(prevData.Codigo_Postal_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPICalle_del_Tutor').val(prevData.Calle_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPINumero_Exterior_del_Tutor').val(prevData.Numero_Exterior_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPINumero_Interior_del_Tutor').val(prevData.Numero_Interior_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPITelefono_del_Tutor').val(prevData.Telefono_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIExtension_del_Tutor').val(prevData.Extension_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPICelular_del_Tutor').val(prevData.Celular_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPICorreo_Electronico_del_Tutor').val(prevData.Correo_Electronico_del_Tutor);
    $('#Detalle_de_Datos_del_Imputado_MPIProteccion_de_Datos').prop('checked', prevData.Proteccion_de_Datos);

    $('#Detalle_de_Datos_del_Imputado_MPIEstatus').val(prevData.Estatus);
    $('#Detalle_de_Datos_del_Imputado_MPIJudicializar').prop('checked', prevData.Judicializar);

    initiateUIControls();















































































































}

function Detalle_de_Datos_del_Imputado_MPIAddInsertRow() {
    if (Detalle_de_Datos_del_Imputado_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_Datos_del_Imputado_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre: ""
        ,Apellido_Paterno: ""
        ,Apellido_Materno: ""
        ,Fecha_de_Nacimiento: ""
        ,Edad: ""
        ,Sexo: ""
        ,Estado_Civil: ""
        ,Tipo_de_Identificacion: ""
        ,Numero_de_Identificacion: ""
        ,Nacionalidad: ""
        ,Escolaridad: ""
        ,Ocupacion: ""
        ,Estado: ""
        ,Municipio: ""
        ,Codigo_Postal: ""
        ,Localidad: ""
        ,Colonia: ""
        ,Calle_del_Imputado: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""
        ,Telefono: ""
        ,Extencion: ""
        ,Celular: ""
        ,Correo_Electronico: ""
        ,Pais: ""
        ,Forma_Cara: ""
        ,Cejas: ""
        ,Cantidad_Cabello: ""
        ,Implantacion_Cabello: ""
        ,Complexion: ""
        ,Color_Piel: ""
        ,Frente: ""
        ,Forma_Cabello: ""
        ,Calvicie: ""
        ,Color_Ojos: ""
        ,Ojos: ""
        ,Forma_Ojos: ""
        ,Nariz_Base: ""
        ,Labios: ""
        ,Boca: ""
        ,Menton: ""
        ,Barba: ""
        ,Forma_Orejas: ""
        ,Tamano_Orejas: ""
        ,Tipo_Lobulo: ""
        ,Bigote: ""
        ,Situacion_Fisica: ""
        ,Alias_media_diliacion: ""
        ,Fecha_de_Detencion: ""
        ,Hora_de_Detencion: ""
        ,Fecha_de_Puesto_a_Disposicion: ""
        ,Hora_de_Puesto_a_Disposicion: ""
        ,Con_Detenido: ""
        ,A_Quien_Resulte_Responsable: ""
        ,Tiempo_Restante_para_Vinculacion: ""
        ,Vincular: ""
        ,Medidas_Cautelares: ""
        ,Solicitar_Prorroga: ""
        ,Nuevo_Plazo: ""
        ,Orden_de_Aprehension: ""
        ,Medidas_Cautelares_en_Imputado: ""
        ,Titulo_del_Hecho: ""
        ,Narrativa_Breve_de_los_Hechos: ""
        ,Prioridad_del_Hecho: ""
        ,Fecha_del_Hecho: ""
        ,Hora_Aproximada_del_Hecho: ""
        ,Pais_del_Hecho: ""
        ,Estado_del_Hecho: ""
        ,Municipio_del_Hecho: ""
        ,Colonia_del_Hecho: ""
        ,Codigo_Postal_del_Hecho: ""
        ,Calle_del_Hecho: ""
        ,Entre_Calle_del_Hecho: ""
        ,Y_Calle_del_Hecho: ""
        ,Numero_Exterior_del_Hecho: ""
        ,Numero_Interior_del_Hecho: ""
        ,Latitud_del_Hecho: ""
        ,Longitud_del_Hecho: ""
        ,Tipo_de_Lugar_del_Hecho: ""

        ,Incapaz: ""
        ,Nombre_del_Tutor: ""
        ,Apellido_Paterno_del_Tutor: ""
        ,Apellido_Materno_del_Tutor: ""
        ,Fecha_de_Nacimiento_del_Tutor: ""
        ,Edad_del_Tutor: ""
        ,Sexo_del_Tutor: ""
        ,Estado_Civil_del_Tutor: ""
        ,Tipo_de_Identificacion_del_Tutor: ""
        ,Numero_de_Identificacion_del_Tutor: ""
        ,Nacionalidad_del_Tutor: ""
        ,Escolaridad_del_Tutor: ""
        ,Ocupacion_del_Tutor: ""
        ,Pais_del_Tutor: ""
        ,Estado_del_Tutor: ""
        ,Municipio_del_Tutor: ""
        ,Colonia_del_Tutor: ""
        ,Codigo_Postal_del_Tutor: ""
        ,Calle_del_Tutor: ""
        ,Numero_Exterior_del_Tutor: ""
        ,Numero_Interior_del_Tutor: ""
        ,Telefono_del_Tutor: ""
        ,Extension_del_Tutor: ""
        ,Celular_del_Tutor: ""
        ,Correo_Electronico_del_Tutor: ""
        ,Proteccion_de_Datos: ""

        ,Estatus: ""
        ,Judicializar: ""

    }
}

function Detalle_de_Datos_del_Imputado_MPIfnClickAddRow() {
    Detalle_de_Datos_del_Imputado_MPIcountRowsChecked++;
    Detalle_de_Datos_del_Imputado_MPITable.fnAddData(Detalle_de_Datos_del_Imputado_MPIAddInsertRow(), true);
    Detalle_de_Datos_del_Imputado_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Datos_del_Imputado_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Datos_del_Imputado_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_Datos_del_Imputado_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Datos_del_Imputado_MPI("Detalle_de_Datos_del_Imputado_MPI_", "_" + Detalle_de_Datos_del_Imputado_MPIinsertRowCurrentIndex);
}

function Detalle_de_Datos_del_Imputado_MPIClearGridData() {
    Detalle_de_Datos_del_Imputado_MPIData = [];
    Detalle_de_Datos_del_Imputado_MPIdeletedItem = [];
    Detalle_de_Datos_del_Imputado_MPIDataMain = [];
    Detalle_de_Datos_del_Imputado_MPIDataMainPages = [];
    Detalle_de_Datos_del_Imputado_MPInewItemCount = 0;
    Detalle_de_Datos_del_Imputado_MPImaxItemIndex = 0;
    $("#Detalle_de_Datos_del_Imputado_MPIGrid").DataTable().clear();
    $("#Detalle_de_Datos_del_Imputado_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Datos_del_Imputado_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Datos_del_Imputado_MPIData[i].Clave);

        form_data.append('[' + i + '].Nombre', Detalle_de_Datos_del_Imputado_MPIData[i].Nombre);
        form_data.append('[' + i + '].Apellido_Paterno', Detalle_de_Datos_del_Imputado_MPIData[i].Apellido_Paterno);
        form_data.append('[' + i + '].Apellido_Materno', Detalle_de_Datos_del_Imputado_MPIData[i].Apellido_Materno);
        form_data.append('[' + i + '].Fecha_de_Nacimiento', Detalle_de_Datos_del_Imputado_MPIData[i].Fecha_de_Nacimiento);
        form_data.append('[' + i + '].Edad', Detalle_de_Datos_del_Imputado_MPIData[i].Edad);
        form_data.append('[' + i + '].Sexo', Detalle_de_Datos_del_Imputado_MPIData[i].Sexo);
        form_data.append('[' + i + '].Estado_Civil', Detalle_de_Datos_del_Imputado_MPIData[i].Estado_Civil);
        form_data.append('[' + i + '].Tipo_de_Identificacion', Detalle_de_Datos_del_Imputado_MPIData[i].Tipo_de_Identificacion);
        form_data.append('[' + i + '].Numero_de_Identificacion', Detalle_de_Datos_del_Imputado_MPIData[i].Numero_de_Identificacion);
        form_data.append('[' + i + '].Nacionalidad', Detalle_de_Datos_del_Imputado_MPIData[i].Nacionalidad);
        form_data.append('[' + i + '].Escolaridad', Detalle_de_Datos_del_Imputado_MPIData[i].Escolaridad);
        form_data.append('[' + i + '].Ocupacion', Detalle_de_Datos_del_Imputado_MPIData[i].Ocupacion);
        form_data.append('[' + i + '].Estado', Detalle_de_Datos_del_Imputado_MPIData[i].Estado);
        form_data.append('[' + i + '].Municipio', Detalle_de_Datos_del_Imputado_MPIData[i].Municipio);
        form_data.append('[' + i + '].Codigo_Postal', Detalle_de_Datos_del_Imputado_MPIData[i].Codigo_Postal);
        form_data.append('[' + i + '].Localidad', Detalle_de_Datos_del_Imputado_MPIData[i].Localidad);
        form_data.append('[' + i + '].Colonia', Detalle_de_Datos_del_Imputado_MPIData[i].Colonia);
        form_data.append('[' + i + '].Calle_del_Imputado', Detalle_de_Datos_del_Imputado_MPIData[i].Calle_del_Imputado);
        form_data.append('[' + i + '].Numero_Exterior', Detalle_de_Datos_del_Imputado_MPIData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Detalle_de_Datos_del_Imputado_MPIData[i].Numero_Interior);
        form_data.append('[' + i + '].Telefono', Detalle_de_Datos_del_Imputado_MPIData[i].Telefono);
        form_data.append('[' + i + '].Extencion', Detalle_de_Datos_del_Imputado_MPIData[i].Extencion);
        form_data.append('[' + i + '].Celular', Detalle_de_Datos_del_Imputado_MPIData[i].Celular);
        form_data.append('[' + i + '].Correo_Electronico', Detalle_de_Datos_del_Imputado_MPIData[i].Correo_Electronico);
        form_data.append('[' + i + '].Pais', Detalle_de_Datos_del_Imputado_MPIData[i].Pais);
        form_data.append('[' + i + '].Forma_Cara', Detalle_de_Datos_del_Imputado_MPIData[i].Forma_Cara);
        form_data.append('[' + i + '].Cejas', Detalle_de_Datos_del_Imputado_MPIData[i].Cejas);
        form_data.append('[' + i + '].Cantidad_Cabello', Detalle_de_Datos_del_Imputado_MPIData[i].Cantidad_Cabello);
        form_data.append('[' + i + '].Implantacion_Cabello', Detalle_de_Datos_del_Imputado_MPIData[i].Implantacion_Cabello);
        form_data.append('[' + i + '].Complexion', Detalle_de_Datos_del_Imputado_MPIData[i].Complexion);
        form_data.append('[' + i + '].Color_Piel', Detalle_de_Datos_del_Imputado_MPIData[i].Color_Piel);
        form_data.append('[' + i + '].Frente', Detalle_de_Datos_del_Imputado_MPIData[i].Frente);
        form_data.append('[' + i + '].Forma_Cabello', Detalle_de_Datos_del_Imputado_MPIData[i].Forma_Cabello);
        form_data.append('[' + i + '].Calvicie', Detalle_de_Datos_del_Imputado_MPIData[i].Calvicie);
        form_data.append('[' + i + '].Color_Ojos', Detalle_de_Datos_del_Imputado_MPIData[i].Color_Ojos);
        form_data.append('[' + i + '].Ojos', Detalle_de_Datos_del_Imputado_MPIData[i].Ojos);
        form_data.append('[' + i + '].Forma_Ojos', Detalle_de_Datos_del_Imputado_MPIData[i].Forma_Ojos);
        form_data.append('[' + i + '].Nariz_Base', Detalle_de_Datos_del_Imputado_MPIData[i].Nariz_Base);
        form_data.append('[' + i + '].Labios', Detalle_de_Datos_del_Imputado_MPIData[i].Labios);
        form_data.append('[' + i + '].Boca', Detalle_de_Datos_del_Imputado_MPIData[i].Boca);
        form_data.append('[' + i + '].Menton', Detalle_de_Datos_del_Imputado_MPIData[i].Menton);
        form_data.append('[' + i + '].Barba', Detalle_de_Datos_del_Imputado_MPIData[i].Barba);
        form_data.append('[' + i + '].Forma_Orejas', Detalle_de_Datos_del_Imputado_MPIData[i].Forma_Orejas);
        form_data.append('[' + i + '].Tamano_Orejas', Detalle_de_Datos_del_Imputado_MPIData[i].Tamano_Orejas);
        form_data.append('[' + i + '].Tipo_Lobulo', Detalle_de_Datos_del_Imputado_MPIData[i].Tipo_Lobulo);
        form_data.append('[' + i + '].Bigote', Detalle_de_Datos_del_Imputado_MPIData[i].Bigote);
        form_data.append('[' + i + '].Situacion_Fisica', Detalle_de_Datos_del_Imputado_MPIData[i].Situacion_Fisica);
        form_data.append('[' + i + '].Alias_media_diliacion', Detalle_de_Datos_del_Imputado_MPIData[i].Alias_media_diliacion);
        form_data.append('[' + i + '].Fecha_de_Detencion', Detalle_de_Datos_del_Imputado_MPIData[i].Fecha_de_Detencion);
        form_data.append('[' + i + '].Hora_de_Detencion', Detalle_de_Datos_del_Imputado_MPIData[i].Hora_de_Detencion);
        form_data.append('[' + i + '].Fecha_de_Puesto_a_Disposicion', Detalle_de_Datos_del_Imputado_MPIData[i].Fecha_de_Puesto_a_Disposicion);
        form_data.append('[' + i + '].Hora_de_Puesto_a_Disposicion', Detalle_de_Datos_del_Imputado_MPIData[i].Hora_de_Puesto_a_Disposicion);
        form_data.append('[' + i + '].Con_Detenido', Detalle_de_Datos_del_Imputado_MPIData[i].Con_Detenido);
        form_data.append('[' + i + '].A_Quien_Resulte_Responsable', Detalle_de_Datos_del_Imputado_MPIData[i].A_Quien_Resulte_Responsable);
        form_data.append('[' + i + '].Tiempo_Restante_para_Vinculacion', Detalle_de_Datos_del_Imputado_MPIData[i].Tiempo_Restante_para_Vinculacion);
        form_data.append('[' + i + '].Vincular', Detalle_de_Datos_del_Imputado_MPIData[i].Vincular);
        form_data.append('[' + i + '].Medidas_Cautelares', Detalle_de_Datos_del_Imputado_MPIData[i].Medidas_Cautelares);
        form_data.append('[' + i + '].Solicitar_Prorroga', Detalle_de_Datos_del_Imputado_MPIData[i].Solicitar_Prorroga);
        form_data.append('[' + i + '].Nuevo_Plazo', Detalle_de_Datos_del_Imputado_MPIData[i].Nuevo_Plazo);
        form_data.append('[' + i + '].Orden_de_Aprehension', Detalle_de_Datos_del_Imputado_MPIData[i].Orden_de_Aprehension);
        form_data.append('[' + i + '].Medidas_Cautelares_en_Imputado', Detalle_de_Datos_del_Imputado_MPIData[i].Medidas_Cautelares_en_Imputado);
        form_data.append('[' + i + '].Titulo_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Titulo_del_Hecho);
        form_data.append('[' + i + '].Narrativa_Breve_de_los_Hechos', Detalle_de_Datos_del_Imputado_MPIData[i].Narrativa_Breve_de_los_Hechos);
        form_data.append('[' + i + '].Prioridad_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Prioridad_del_Hecho);
        form_data.append('[' + i + '].Fecha_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Fecha_del_Hecho);
        form_data.append('[' + i + '].Hora_Aproximada_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Hora_Aproximada_del_Hecho);
        form_data.append('[' + i + '].Pais_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Pais_del_Hecho);
        form_data.append('[' + i + '].Estado_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Estado_del_Hecho);
        form_data.append('[' + i + '].Municipio_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Municipio_del_Hecho);
        form_data.append('[' + i + '].Colonia_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Colonia_del_Hecho);
        form_data.append('[' + i + '].Codigo_Postal_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Codigo_Postal_del_Hecho);
        form_data.append('[' + i + '].Calle_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Calle_del_Hecho);
        form_data.append('[' + i + '].Entre_Calle_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Entre_Calle_del_Hecho);
        form_data.append('[' + i + '].Y_Calle_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Y_Calle_del_Hecho);
        form_data.append('[' + i + '].Numero_Exterior_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Numero_Exterior_del_Hecho);
        form_data.append('[' + i + '].Numero_Interior_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Numero_Interior_del_Hecho);
        form_data.append('[' + i + '].Latitud_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Latitud_del_Hecho);
        form_data.append('[' + i + '].Longitud_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Longitud_del_Hecho);
        form_data.append('[' + i + '].Tipo_de_Lugar_del_Hecho', Detalle_de_Datos_del_Imputado_MPIData[i].Tipo_de_Lugar_del_Hecho);

        form_data.append('[' + i + '].Incapaz', Detalle_de_Datos_del_Imputado_MPIData[i].Incapaz);
        form_data.append('[' + i + '].Nombre_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Nombre_del_Tutor);
        form_data.append('[' + i + '].Apellido_Paterno_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Apellido_Paterno_del_Tutor);
        form_data.append('[' + i + '].Apellido_Materno_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Apellido_Materno_del_Tutor);
        form_data.append('[' + i + '].Fecha_de_Nacimiento_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Fecha_de_Nacimiento_del_Tutor);
        form_data.append('[' + i + '].Edad_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Edad_del_Tutor);
        form_data.append('[' + i + '].Sexo_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Sexo_del_Tutor);
        form_data.append('[' + i + '].Estado_Civil_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Estado_Civil_del_Tutor);
        form_data.append('[' + i + '].Tipo_de_Identificacion_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Tipo_de_Identificacion_del_Tutor);
        form_data.append('[' + i + '].Numero_de_Identificacion_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Numero_de_Identificacion_del_Tutor);
        form_data.append('[' + i + '].Nacionalidad_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Nacionalidad_del_Tutor);
        form_data.append('[' + i + '].Escolaridad_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Escolaridad_del_Tutor);
        form_data.append('[' + i + '].Ocupacion_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Ocupacion_del_Tutor);
        form_data.append('[' + i + '].Pais_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Pais_del_Tutor);
        form_data.append('[' + i + '].Estado_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Estado_del_Tutor);
        form_data.append('[' + i + '].Municipio_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Municipio_del_Tutor);
        form_data.append('[' + i + '].Colonia_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Colonia_del_Tutor);
        form_data.append('[' + i + '].Codigo_Postal_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Codigo_Postal_del_Tutor);
        form_data.append('[' + i + '].Calle_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Calle_del_Tutor);
        form_data.append('[' + i + '].Numero_Exterior_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Numero_Exterior_del_Tutor);
        form_data.append('[' + i + '].Numero_Interior_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Numero_Interior_del_Tutor);
        form_data.append('[' + i + '].Telefono_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Telefono_del_Tutor);
        form_data.append('[' + i + '].Extension_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Extension_del_Tutor);
        form_data.append('[' + i + '].Celular_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Celular_del_Tutor);
        form_data.append('[' + i + '].Correo_Electronico_del_Tutor', Detalle_de_Datos_del_Imputado_MPIData[i].Correo_Electronico_del_Tutor);
        form_data.append('[' + i + '].Proteccion_de_Datos', Detalle_de_Datos_del_Imputado_MPIData[i].Proteccion_de_Datos);

        form_data.append('[' + i + '].Estatus', Detalle_de_Datos_del_Imputado_MPIData[i].Estatus);
        form_data.append('[' + i + '].Judicializar', Detalle_de_Datos_del_Imputado_MPIData[i].Judicializar);

        form_data.append('[' + i + '].Removed', Detalle_de_Datos_del_Imputado_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Datos_del_Imputado_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_del_Imputado_MPI("Detalle_de_Datos_del_Imputado_MPITable", rowIndex)) {
    var prevData = Detalle_de_Datos_del_Imputado_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Imputado_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre: $('#Detalle_de_Datos_del_Imputado_MPINombre').val()
        ,Apellido_Paterno: $('#Detalle_de_Datos_del_Imputado_MPIApellido_Paterno').val()
        ,Apellido_Materno: $('#Detalle_de_Datos_del_Imputado_MPIApellido_Materno').val()
        ,Fecha_de_Nacimiento: $('#Detalle_de_Datos_del_Imputado_MPIFecha_de_Nacimiento').val()
        ,Edad: $('#Detalle_de_Datos_del_Imputado_MPIEdad').val()

        ,Sexo: $('#Detalle_de_Datos_del_Imputado_MPISexo').val()
        ,Estado_Civil: $('#Detalle_de_Datos_del_Imputado_MPIEstado_Civil').val()
        ,Tipo_de_Identificacion: $('#Detalle_de_Datos_del_Imputado_MPITipo_de_Identificacion').val()
        ,Numero_de_Identificacion: $('#Detalle_de_Datos_del_Imputado_MPINumero_de_Identificacion').val()
        ,Nacionalidad: $('#Detalle_de_Datos_del_Imputado_MPINacionalidad').val()
        ,Escolaridad: $('#Detalle_de_Datos_del_Imputado_MPIEscolaridad').val()
        ,Ocupacion: $('#Detalle_de_Datos_del_Imputado_MPIOcupacion').val()
        ,Estado: $('#Detalle_de_Datos_del_Imputado_MPIEstado').val()
        ,Municipio: $('#Detalle_de_Datos_del_Imputado_MPIMunicipio').val()
        ,Codigo_Postal: $('#Detalle_de_Datos_del_Imputado_MPICodigo_Postal').val()

        ,Localidad: $('#Detalle_de_Datos_del_Imputado_MPILocalidad').val()
        ,Colonia: $('#Detalle_de_Datos_del_Imputado_MPIColonia').val()
        ,Calle_del_Imputado: $('#Detalle_de_Datos_del_Imputado_MPICalle_del_Imputado').val()
        ,Numero_Exterior: $('#Detalle_de_Datos_del_Imputado_MPINumero_Exterior').val()
        ,Numero_Interior: $('#Detalle_de_Datos_del_Imputado_MPINumero_Interior').val()
        ,Telefono: $('#Detalle_de_Datos_del_Imputado_MPITelefono').val()
        ,Extencion: $('#Detalle_de_Datos_del_Imputado_MPIExtencion').val()

        ,Celular: $('#Detalle_de_Datos_del_Imputado_MPICelular').val()
        ,Correo_Electronico: $('#Detalle_de_Datos_del_Imputado_MPICorreo_Electronico').val()
        ,Pais: $('#Detalle_de_Datos_del_Imputado_MPIPais').val()
        ,Forma_Cara: $('#Detalle_de_Datos_del_Imputado_MPIForma_Cara').val()
        ,Cejas: $('#Detalle_de_Datos_del_Imputado_MPICejas').val()
        ,Cantidad_Cabello: $('#Detalle_de_Datos_del_Imputado_MPICantidad_Cabello').val()
        ,Implantacion_Cabello: $('#Detalle_de_Datos_del_Imputado_MPIImplantacion_Cabello').val()
        ,Complexion: $('#Detalle_de_Datos_del_Imputado_MPIComplexion').val()
        ,Color_Piel: $('#Detalle_de_Datos_del_Imputado_MPIColor_Piel').val()
        ,Frente: $('#Detalle_de_Datos_del_Imputado_MPIFrente').val()
        ,Forma_Cabello: $('#Detalle_de_Datos_del_Imputado_MPIForma_Cabello').val()
        ,Calvicie: $('#Detalle_de_Datos_del_Imputado_MPICalvicie').val()
        ,Color_Ojos: $('#Detalle_de_Datos_del_Imputado_MPIColor_Ojos').val()
        ,Ojos: $('#Detalle_de_Datos_del_Imputado_MPIOjos').val()
        ,Forma_Ojos: $('#Detalle_de_Datos_del_Imputado_MPIForma_Ojos').val()
        ,Nariz_Base: $('#Detalle_de_Datos_del_Imputado_MPINariz_Base').val()
        ,Labios: $('#Detalle_de_Datos_del_Imputado_MPILabios').val()
        ,Boca: $('#Detalle_de_Datos_del_Imputado_MPIBoca').val()
        ,Menton: $('#Detalle_de_Datos_del_Imputado_MPIMenton').val()
        ,Barba: $('#Detalle_de_Datos_del_Imputado_MPIBarba').val()
        ,Forma_Orejas: $('#Detalle_de_Datos_del_Imputado_MPIForma_Orejas').val()
        ,Tamano_Orejas: $('#Detalle_de_Datos_del_Imputado_MPITamano_Orejas').val()
        ,Tipo_Lobulo: $('#Detalle_de_Datos_del_Imputado_MPITipo_Lobulo').val()
        ,Bigote: $('#Detalle_de_Datos_del_Imputado_MPIBigote').val()
        ,Situacion_Fisica: $('#Detalle_de_Datos_del_Imputado_MPISituacion_Fisica').val()
        ,Alias_media_diliacion: $('#Detalle_de_Datos_del_Imputado_MPIAlias_media_diliacion').val()
        ,Fecha_de_Detencion: $('#Detalle_de_Datos_del_Imputado_MPIFecha_de_Detencion').val()
        ,Hora_de_Detencion: $('#Detalle_de_Datos_del_Imputado_MPIHora_de_Detencion').val()
        ,Fecha_de_Puesto_a_Disposicion: $('#Detalle_de_Datos_del_Imputado_MPIFecha_de_Puesto_a_Disposicion').val()
        ,Hora_de_Puesto_a_Disposicion: $('#Detalle_de_Datos_del_Imputado_MPIHora_de_Puesto_a_Disposicion').val()
        ,Con_Detenido: $('#Detalle_de_Datos_del_Imputado_MPICon_Detenido').val()
        ,A_Quien_Resulte_Responsable: $('#Detalle_de_Datos_del_Imputado_MPIA_Quien_Resulte_Responsable').is(':checked')
        ,Tiempo_Restante_para_Vinculacion: $('#Detalle_de_Datos_del_Imputado_MPITiempo_Restante_para_Vinculacion').val()
        ,Vincular: $('#Detalle_de_Datos_del_Imputado_MPIVincular').is(':checked')
        ,Medidas_Cautelares: $('#Detalle_de_Datos_del_Imputado_MPIMedidas_Cautelares').val()
        ,Solicitar_Prorroga: $('#Detalle_de_Datos_del_Imputado_MPISolicitar_Prorroga').val()
        ,Nuevo_Plazo: $('#Detalle_de_Datos_del_Imputado_MPINuevo_Plazo').val()
        ,Orden_de_Aprehension: $('#Detalle_de_Datos_del_Imputado_MPIOrden_de_Aprehension').is(':checked')
        ,Medidas_Cautelares_en_Imputado: $('#Detalle_de_Datos_del_Imputado_MPIMedidas_Cautelares_en_Imputado').val()
        ,Titulo_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPITitulo_del_Hecho').val()
        ,Narrativa_Breve_de_los_Hechos: $('#Detalle_de_Datos_del_Imputado_MPINarrativa_Breve_de_los_Hechos').val()
        ,Prioridad_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPIPrioridad_del_Hecho').val()
        ,Fecha_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPIFecha_del_Hecho').val()
        ,Hora_Aproximada_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPIHora_Aproximada_del_Hecho').val()
        ,Pais_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPIPais_del_Hecho').val()
        ,Estado_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPIEstado_del_Hecho').val()
        ,Municipio_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPIMunicipio_del_Hecho').val()
        ,Colonia_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPIColonia_del_Hecho').val()
        ,Codigo_Postal_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPICodigo_Postal_del_Hecho').val()

        ,Calle_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPICalle_del_Hecho').val()
        ,Entre_Calle_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPIEntre_Calle_del_Hecho').val()
        ,Y_Calle_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPIY_Calle_del_Hecho').val()
        ,Numero_Exterior_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPINumero_Exterior_del_Hecho').val()
        ,Numero_Interior_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPINumero_Interior_del_Hecho').val()
        ,Latitud_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPILatitud_del_Hecho').val()
        ,Longitud_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPILongitud_del_Hecho').val()
        ,Tipo_de_Lugar_del_Hecho: $('#Detalle_de_Datos_del_Imputado_MPITipo_de_Lugar_del_Hecho').val()

        ,Incapaz: $('#Detalle_de_Datos_del_Imputado_MPIIncapaz').is(':checked')
        ,Nombre_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPINombre_del_Tutor').val()
        ,Apellido_Paterno_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIApellido_Paterno_del_Tutor').val()
        ,Apellido_Materno_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIApellido_Materno_del_Tutor').val()
        ,Fecha_de_Nacimiento_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIFecha_de_Nacimiento_del_Tutor').val()
        ,Edad_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIEdad_del_Tutor').val()

        ,Sexo_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPISexo_del_Tutor').val()
        ,Estado_Civil_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIEstado_Civil_del_Tutor').val()
        ,Tipo_de_Identificacion_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPITipo_de_Identificacion_del_Tutor').val()
        ,Numero_de_Identificacion_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPINumero_de_Identificacion_del_Tutor').val()
        ,Nacionalidad_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPINacionalidad_del_Tutor').val()
        ,Escolaridad_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIEscolaridad_del_Tutor').val()
        ,Ocupacion_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIOcupacion_del_Tutor').val()
        ,Pais_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIPais_del_Tutor').val()
        ,Estado_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIEstado_del_Tutor').val()
        ,Municipio_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIMunicipio_del_Tutor').val()
        ,Colonia_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIColonia_del_Tutor').val()
        ,Codigo_Postal_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPICodigo_Postal_del_Tutor').val()

        ,Calle_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPICalle_del_Tutor').val()
        ,Numero_Exterior_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPINumero_Exterior_del_Tutor').val()
        ,Numero_Interior_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPINumero_Interior_del_Tutor').val()
        ,Telefono_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPITelefono_del_Tutor').val()
        ,Extension_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPIExtension_del_Tutor').val()

        ,Celular_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPICelular_del_Tutor').val()
        ,Correo_Electronico_del_Tutor: $('#Detalle_de_Datos_del_Imputado_MPICorreo_Electronico_del_Tutor').val()
        ,Proteccion_de_Datos: $('#Detalle_de_Datos_del_Imputado_MPIProteccion_de_Datos').is(':checked')

        ,Estatus: $('#Detalle_de_Datos_del_Imputado_MPIEstatus').val()
        ,Judicializar: $('#Detalle_de_Datos_del_Imputado_MPIJudicializar').is(':checked')

    }

    Detalle_de_Datos_del_Imputado_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Datos_del_Imputado_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Datos_del_Imputado_MPI-form').modal({ show: false });
    $('#AddDetalle_de_Datos_del_Imputado_MPI-form').modal('hide');
    Detalle_de_Datos_del_Imputado_MPIEditRow(rowIndex);
    Detalle_de_Datos_del_Imputado_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_Datos_del_Imputado_MPIRemoveAddRow(rowIndex) {
    Detalle_de_Datos_del_Imputado_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Datos_del_Imputado_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_Datos_de_Delito_MPI MultiRow
var Detalle_Datos_de_Delito_MPIcountRowsChecked = 0;

function GetDetalle_Datos_de_Delito_MPI_Tipo_DelitoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Tipo_DelitoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Tipo_DelitoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Tipo_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Tipo_DelitoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Tipo_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Tipo_DelitoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Tipo_DelitoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Tipo_DelitoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Tipo_DelitoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Tipo_DelitoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Tipo_DelitoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Tipo_DelitoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_Grupo_del_DelitoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Grupo_del_DelitoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Grupo_del_DelitoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_DelitoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_DelitoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_DelitoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_DelitoDropDown() {
    var Detalle_Datos_de_Delito_MPI_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_DelitoDropdown);
    if(Detalle_Datos_de_Delito_MPI_DelitoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_DelitoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_DelitoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_DelitoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_DelitoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_DelitoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoDropdown;
}

function GetDetalle_Datos_de_Delito_MPI_Forma_Comision_DelitoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Forma_Comision_DelitoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Forma_Comision_DelitoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_Forma_Accion_DelitoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Forma_Accion_DelitoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Forma_Accion_DelitoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_Modalidad_DelitoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Modalidad_DelitoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Modalidad_DelitoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Modalidad_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Modalidad_DelitoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Modalidad_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Modalidad_DelitoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Modalidad_DelitoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Modalidad_DelitoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Modalidad_DelitoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Modalidad_DelitoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Modalidad_DelitoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Modalidad_DelitoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoDropdown;
}




function GetDetalle_Datos_de_Delito_MPI_Circunstancia_VehiculoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Circunstancia_VehiculoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Circunstancia_VehiculoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_Especifica_VehiculoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Especifica_VehiculoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Especifica_VehiculoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Especifica_VehiculoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Especifica_VehiculoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Especifica_VehiculoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Especifica_VehiculoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Especifica_VehiculoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Especifica_VehiculoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Especifica_VehiculoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Especifica_VehiculoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Especifica_VehiculoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Especifica_VehiculoDropdown;
}

function GetDetalle_Datos_de_Delito_MPI_Marca_del_VehiculoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Marca_del_VehiculoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Marca_del_VehiculoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_Tipo_de_VehiculoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Tipo_de_VehiculoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Tipo_de_VehiculoDropdown;
}

function GetDetalle_Datos_de_Delito_MPI_Color_VehiculoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Color_VehiculoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Color_VehiculoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Color_VehiculoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Color_VehiculoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Color_VehiculoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Color_VehiculoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Color_VehiculoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Color_VehiculoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Color_VehiculoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Color_VehiculoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Color_VehiculoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Color_VehiculoDropdown;
}

function GetDetalle_Datos_de_Delito_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_EstadoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_EstadoDropDown() {
    var Detalle_Datos_de_Delito_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_EstadoDropdown);
    if(Detalle_Datos_de_Delito_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_EstadoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_Datos_de_Delito_MPI_EstadoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_EstadoDropdown;
}



function GetDetalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_Servicio_del_VehiculoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Servicio_del_VehiculoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Servicio_del_VehiculoDropdown;
}

function GetDetalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoDropdown;
}




function GetDetalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoDropdown;
}

function GetDetalle_Datos_de_Delito_MPI_Circunstancia_DefuncionName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Circunstancia_DefuncionDropDown() {
    var Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionDropdown);
    if(Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Circunstancia_DefuncionDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_Consecuencia_DefuncionName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Consecuencia_DefuncionDropDown() {
    var Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionDropdown);
    if(Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Consecuencia_DefuncionDropdown;
}


function GetDetalle_Datos_de_Delito_MPI_Lugar_TipoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Lugar_TipoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_Lugar_TipoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_Lugar_TipoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_Lugar_TipoDropDown() {
    var Detalle_Datos_de_Delito_MPI_Lugar_TipoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_Lugar_TipoDropdown);
    if(Detalle_Datos_de_Delito_MPI_Lugar_TipoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_Lugar_TipoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_Lugar_TipoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_Lugar_TipoItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_Lugar_TipoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_Lugar_TipoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_PaisItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_PaisItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_PaisDropDown() {
    var Detalle_Datos_de_Delito_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_PaisDropdown);
    if(Detalle_Datos_de_Delito_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_PaisItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_PaisItems[i].Nombre }).appendTo(Detalle_Datos_de_Delito_MPI_PaisDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_PaisDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_EstadoItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_EstadoDropDown() {
    var Detalle_Datos_de_Delito_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_EstadoDropdown);
    if(Detalle_Datos_de_Delito_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_EstadoItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_Datos_de_Delito_MPI_EstadoDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_EstadoDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_MunicipioItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_MunicipioDropDown() {
    var Detalle_Datos_de_Delito_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_MunicipioDropdown);
    if(Detalle_Datos_de_Delito_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_MunicipioItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_Datos_de_Delito_MPI_MunicipioDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_MunicipioDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_ZonaName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_ZonaItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_ZonaItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_ZonaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_ZonaDropDown() {
    var Detalle_Datos_de_Delito_MPI_ZonaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_ZonaDropdown);
    if(Detalle_Datos_de_Delito_MPI_ZonaItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_ZonaItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_ZonaItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_ZonaItems[i].Descripcion }).appendTo(Detalle_Datos_de_Delito_MPI_ZonaDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_ZonaDropdown;
}
function GetDetalle_Datos_de_Delito_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_Datos_de_Delito_MPI_ColoniaItems.length; i++) {
        if (Detalle_Datos_de_Delito_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_Datos_de_Delito_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_Datos_de_Delito_MPI_ColoniaDropDown() {
    var Detalle_Datos_de_Delito_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Datos_de_Delito_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Datos_de_Delito_MPI_ColoniaDropdown);
    if(Detalle_Datos_de_Delito_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_Datos_de_Delito_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_Datos_de_Delito_MPI_ColoniaItems[i].Clave, text:    Detalle_Datos_de_Delito_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_Datos_de_Delito_MPI_ColoniaDropdown);
       }
    }
    return Detalle_Datos_de_Delito_MPI_ColoniaDropdown;
}










function GetInsertDetalle_Datos_de_Delito_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_Datos_de_Delito_MPI_Tipo_DelitoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Tipo_de_Delito Tipo_de_Delito').attr('id', 'Detalle_Datos_de_Delito_MPI_Tipo_de_Delito_' + index).attr('data-field', 'Tipo_de_Delito').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Tipo_Delito', 'Tipo_de_Delito', 263958)));
    columnData[1] = $(GetDetalle_Datos_de_Delito_MPI_Grupo_del_DelitoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Grupo_Delito Grupo_Delito').attr('id', 'Detalle_Datos_de_Delito_MPI_Grupo_Delito_' + index).attr('data-field', 'Grupo_Delito').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Grupo_del_Delito', 'Grupo_Delito', 263959)));
    columnData[2] = $(GetDetalle_Datos_de_Delito_MPI_DelitoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Delito Delito').attr('id', 'Detalle_Datos_de_Delito_MPI_Delito_' + index).attr('data-field', 'Delito').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Delito', 'Delito', 263960)));
    columnData[3] = $(GetDetalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Circunstancia_Delito Circunstancia_Delito').attr('id', 'Detalle_Datos_de_Delito_MPI_Circunstancia_Delito_' + index).attr('data-field', 'Circunstancia_Delito').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Circunstancia_del_Delito', 'Circunstancia_Delito', 263961)));
    columnData[4] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Datos_de_Delito_MPI_Delito_Principal Delito_Principal').attr('id', 'Detalle_Datos_de_Delito_MPI_Delito_Principal_' + index).attr('data-field', 'Delito_Principal');
    columnData[5] = $(GetDetalle_Datos_de_Delito_MPI_Forma_Comision_DelitoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Forma_Comision_Delito Forma_Comision_Delito').attr('id', 'Detalle_Datos_de_Delito_MPI_Forma_Comision_Delito_' + index).attr('data-field', 'Forma_Comision_Delito').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Forma_Comision_Delito', 'Forma_Comision_Delito', 263963)));
    columnData[6] = $(GetDetalle_Datos_de_Delito_MPI_Forma_Accion_DelitoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Forma_Accion_Delito Forma_Accion_Delito').attr('id', 'Detalle_Datos_de_Delito_MPI_Forma_Accion_Delito_' + index).attr('data-field', 'Forma_Accion_Delito').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Forma_Accion_Delito', 'Forma_Accion_Delito', 263964)));
    columnData[7] = $(GetDetalle_Datos_de_Delito_MPI_Modalidad_DelitoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Modalidad_Delito Modalidad_Delito').attr('id', 'Detalle_Datos_de_Delito_MPI_Modalidad_Delito_' + index).attr('data-field', 'Modalidad_Delito').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Modalidad_Delito', 'Modalidad_Delito', 263965)));
    columnData[8] = $(GetDetalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Elementos_Comision_Delito Elementos_Comision_Delito').attr('id', 'Detalle_Datos_de_Delito_MPI_Elementos_Comision_Delito_' + index).attr('data-field', 'Elementos_Comision_Delito').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Elementos_Comision_Delito', 'Elementos_Comision_Delito', 263966)));
    columnData[9] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Datos_de_Delito_MPI_Monto Monto inputMoney').attr('id', 'Detalle_Datos_de_Delito_MPI_Monto_' + index).attr('data-field', 'Monto');
    columnData[10] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Datos_de_Delito_MPI_Violencia_de_Genero Violencia_de_Genero').attr('id', 'Detalle_Datos_de_Delito_MPI_Violencia_de_Genero_' + index).attr('data-field', 'Violencia_de_Genero');
    columnData[11] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Datos_de_Delito_MPI_Robo_de_Vehiculo Robo_de_Vehiculo').attr('id', 'Detalle_Datos_de_Delito_MPI_Robo_de_Vehiculo_' + index).attr('data-field', 'Robo_de_Vehiculo');
    columnData[12] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Datos_de_Delito_MPI_Levantamiento_de_Cadaver Levantamiento_de_Cadaver').attr('id', 'Detalle_Datos_de_Delito_MPI_Levantamiento_de_Cadaver_' + index).attr('data-field', 'Levantamiento_de_Cadaver');
    columnData[13] = $(GetDetalle_Datos_de_Delito_MPI_Circunstancia_VehiculoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Circunstancia_de_Vehiculo Circunstancia_de_Vehiculo').attr('id', 'Detalle_Datos_de_Delito_MPI_Circunstancia_de_Vehiculo_' + index).attr('data-field', 'Circunstancia_de_Vehiculo').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Circunstancia_Vehiculo', 'Circunstancia_de_Vehiculo', 263971)));
    columnData[14] = $(GetDetalle_Datos_de_Delito_MPI_Especifica_VehiculoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Clase Clase').attr('id', 'Detalle_Datos_de_Delito_MPI_Clase_' + index).attr('data-field', 'Clase').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Especifica_Vehiculo', 'Clase', 263972)));
    columnData[15] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Datos_de_Delito_MPI_Vehiculo_Robado Vehiculo_Robado').attr('id', 'Detalle_Datos_de_Delito_MPI_Vehiculo_Robado_' + index).attr('data-field', 'Vehiculo_Robado');
    columnData[16] = $(GetDetalle_Datos_de_Delito_MPI_Marca_del_VehiculoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Marca Marca').attr('id', 'Detalle_Datos_de_Delito_MPI_Marca_' + index).attr('data-field', 'Marca').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Marca_del_Vehiculo', 'Marca', 263974)));
    columnData[17] = $(GetDetalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Sub_Marca Sub_Marca').attr('id', 'Detalle_Datos_de_Delito_MPI_Sub_Marca_' + index).attr('data-field', 'Sub_Marca').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Sub_Marca_del_Vehiculo', 'Sub_Marca', 263975)));
    columnData[18] = $(GetDetalle_Datos_de_Delito_MPI_Tipo_de_VehiculoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Tipo_de_Vehiculo Tipo_de_Vehiculo').attr('id', 'Detalle_Datos_de_Delito_MPI_Tipo_de_Vehiculo_' + index).attr('data-field', 'Tipo_de_Vehiculo').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Tipo_de_Vehiculo', 'Tipo_de_Vehiculo', 263976)));
    columnData[19] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Datos_de_Delito_MPI_Modelo Modelo').attr('id', 'Detalle_Datos_de_Delito_MPI_Modelo_' + index).attr('data-field', 'Modelo');
    columnData[20] = $(GetDetalle_Datos_de_Delito_MPI_Color_VehiculoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Color Color').attr('id', 'Detalle_Datos_de_Delito_MPI_Color_' + index).attr('data-field', 'Color').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Color_Vehiculo', 'Color', 263978)));
    columnData[21] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Placas Placas').attr('id', 'Detalle_Datos_de_Delito_MPI_Placas_' + index).attr('data-field', 'Placas');
    columnData[22] = $(GetDetalle_Datos_de_Delito_MPI_EstadoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Estado_de_Origen_de_las_Placas Estado_de_Origen_de_las_Placas').attr('id', 'Detalle_Datos_de_Delito_MPI_Estado_de_Origen_de_las_Placas_' + index).attr('data-field', 'Estado_de_Origen_de_las_Placas').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Estado', 'Estado_de_Origen_de_las_Placas', 263980)));
    columnData[23] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Motor Motor').attr('id', 'Detalle_Datos_de_Delito_MPI_Motor_' + index).attr('data-field', 'Motor');
    columnData[24] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Serie Serie').attr('id', 'Detalle_Datos_de_Delito_MPI_Serie_' + index).attr('data-field', 'Serie');
    columnData[25] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Datos_de_Delito_MPI_El_Vehiculo_esta_Asegurado El_Vehiculo_esta_Asegurado').attr('id', 'Detalle_Datos_de_Delito_MPI_El_Vehiculo_esta_Asegurado_' + index).attr('data-field', 'El_Vehiculo_esta_Asegurado');
    columnData[26] = $(GetDetalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Nombre_de_la_Aseguradora Nombre_de_la_Aseguradora').attr('id', 'Detalle_Datos_de_Delito_MPI_Nombre_de_la_Aseguradora_' + index).attr('data-field', 'Nombre_de_la_Aseguradora').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Aseguradora_de_Vehiculo', 'Nombre_de_la_Aseguradora', 263984)));
    columnData[27] = $(GetDetalle_Datos_de_Delito_MPI_Servicio_del_VehiculoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Tipo_de_Servicio Tipo_de_Servicio').attr('id', 'Detalle_Datos_de_Delito_MPI_Tipo_de_Servicio_' + index).attr('data-field', 'Tipo_de_Servicio').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Servicio_del_Vehiculo', 'Tipo_de_Servicio', 263985)));
    columnData[28] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Ruta_del_Servicio_Publico Ruta_del_Servicio_Publico').attr('id', 'Detalle_Datos_de_Delito_MPI_Ruta_del_Servicio_Publico_' + index).attr('data-field', 'Ruta_del_Servicio_Publico');
    columnData[29] = $(GetDetalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Procedencia Procedencia').attr('id', 'Detalle_Datos_de_Delito_MPI_Procedencia_' + index).attr('data-field', 'Procedencia').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Procedencia_del_Vehiculo', 'Procedencia', 263987)));
    columnData[30] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Datos_de_Delito_MPI_Mercancia Mercancia').attr('id', 'Detalle_Datos_de_Delito_MPI_Mercancia_' + index).attr('data-field', 'Mercancia');
    columnData[31] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Descripcion_de_lo_que_Transportaba Descripcion_de_lo_que_Transportaba').attr('id', 'Detalle_Datos_de_Delito_MPI_Descripcion_de_lo_que_Transportaba_' + index).attr('data-field', 'Descripcion_de_lo_que_Transportaba');
    columnData[32] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Datos_de_Delito_MPI_Monto_de_la_Carga Monto_de_la_Carga inputMoney').attr('id', 'Detalle_Datos_de_Delito_MPI_Monto_de_la_Carga_' + index).attr('data-field', 'Monto_de_la_Carga');
    columnData[33] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Senas_Particulares Senas_Particulares').attr('id', 'Detalle_Datos_de_Delito_MPI_Senas_Particulares_' + index).attr('data-field', 'Senas_Particulares');
    columnData[34] = $(GetDetalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Modalidad_del_Robo Modalidad_del_Robo').attr('id', 'Detalle_Datos_de_Delito_MPI_Modalidad_del_Robo_' + index).attr('data-field', 'Modalidad_del_Robo').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Modalidad_de_Robo_de_Vehiculo', 'Modalidad_del_Robo', 263992)));
    columnData[35] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Causa_de_Muerte Causa_de_Muerte').attr('id', 'Detalle_Datos_de_Delito_MPI_Causa_de_Muerte_' + index).attr('data-field', 'Causa_de_Muerte');
    columnData[36] = $(GetDetalle_Datos_de_Delito_MPI_Circunstancia_DefuncionDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Circunstancia_Defuncion Circunstancia_Defuncion').attr('id', 'Detalle_Datos_de_Delito_MPI_Circunstancia_Defuncion_' + index).attr('data-field', 'Circunstancia_Defuncion').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Circunstancia_Defuncion', 'Circunstancia_Defuncion', 263994)));
    columnData[37] = $(GetDetalle_Datos_de_Delito_MPI_Consecuencia_DefuncionDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Consecuencia_Defuncion Consecuencia_Defuncion').attr('id', 'Detalle_Datos_de_Delito_MPI_Consecuencia_Defuncion_' + index).attr('data-field', 'Consecuencia_Defuncion').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Consecuencia_Defuncion', 'Consecuencia_Defuncion', 263995)));
    columnData[38] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_Datos_de_Delito_MPI_Fecha_Levantamiento Fecha_Levantamiento').attr('id', 'Detalle_Datos_de_Delito_MPI_Fecha_Levantamiento_' + index).attr('data-field', 'Fecha_Levantamiento');
    columnData[39] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_Datos_de_Delito_MPI_Hora_Levantamiento Hora_Levantamiento').attr('id', 'Detalle_Datos_de_Delito_MPI_Hora_Levantamiento_' + index).attr('data-field', 'Hora_Levantamiento');
    columnData[40] = $(GetDetalle_Datos_de_Delito_MPI_Lugar_TipoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Tipo_de_Lugar_del_Hecho Tipo_de_Lugar_del_Hecho').attr('id', 'Detalle_Datos_de_Delito_MPI_Tipo_de_Lugar_del_Hecho_' + index).attr('data-field', 'Tipo_de_Lugar_del_Hecho').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Lugar_Tipo', 'Tipo_de_Lugar_del_Hecho', 263998)));
    columnData[41] = $(GetDetalle_Datos_de_Delito_MPI_PaisDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Pais Pais').attr('id', 'Detalle_Datos_de_Delito_MPI_Pais_' + index).attr('data-field', 'Pais').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Pais', 'Pais', 263999)));
    columnData[42] = $(GetDetalle_Datos_de_Delito_MPI_EstadoDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Estado Estado').attr('id', 'Detalle_Datos_de_Delito_MPI_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Estado', 'Estado', 264000)));
    columnData[43] = $(GetDetalle_Datos_de_Delito_MPI_MunicipioDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Municipio Municipio').attr('id', 'Detalle_Datos_de_Delito_MPI_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Municipio', 'Municipio', 264001)));
    columnData[44] = $(GetDetalle_Datos_de_Delito_MPI_ZonaDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Zona Zona').attr('id', 'Detalle_Datos_de_Delito_MPI_Zona_' + index).attr('data-field', 'Zona').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Zona', 'Zona', 264002)));
    columnData[45] = $(GetDetalle_Datos_de_Delito_MPI_ColoniaDropDown()).addClass('Detalle_Datos_de_Delito_MPI_Colonia Colonia').attr('id', 'Detalle_Datos_de_Delito_MPI_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_Datos_de_Delito_MPI', 'Colonia', 'Colonia', 264003)));
    columnData[46] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Colonia_no_Catalogada Colonia_no_Catalogada').attr('id', 'Detalle_Datos_de_Delito_MPI_Colonia_no_Catalogada_' + index).attr('data-field', 'Colonia_no_Catalogada');
    columnData[47] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Datos_de_Delito_MPI_Numero_Exterior Numero_Exterior').attr('id', 'Detalle_Datos_de_Delito_MPI_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[48] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Numero_Interior Numero_Interior').attr('id', 'Detalle_Datos_de_Delito_MPI_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[49] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Necropsia Necropsia').attr('id', 'Detalle_Datos_de_Delito_MPI_Necropsia_' + index).attr('data-field', 'Necropsia');
    columnData[50] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Cronotanatodiagnostico Cronotanatodiagnostico').attr('id', 'Detalle_Datos_de_Delito_MPI_Cronotanatodiagnostico_' + index).attr('data-field', 'Cronotanatodiagnostico');
    columnData[51] = $($.parseHTML(inputData)).addClass('Detalle_Datos_de_Delito_MPI_Ruta Ruta').attr('id', 'Detalle_Datos_de_Delito_MPI_Ruta_' + index).attr('data-field', 'Ruta');
    columnData[52] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_Datos_de_Delito_MPI_Estado_del_Conductor Estado_del_Conductor').attr('id', 'Detalle_Datos_de_Delito_MPI_Estado_del_Conductor_' + index).attr('data-field', 'Estado_del_Conductor');
    columnData[53] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_Datos_de_Delito_MPI_Codigo_Postal Codigo_Postal').attr('id', 'Detalle_Datos_de_Delito_MPI_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');


    initiateUIControls();
    return columnData;
}

function Detalle_Datos_de_Delito_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Datos_de_Delito_MPI("Detalle_Datos_de_Delito_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_Datos_de_Delito_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Datos_de_Delito_MPI';
    var prevData = Detalle_Datos_de_Delito_MPITable.fnGetData(rowIndex);
    var data = Detalle_Datos_de_Delito_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Delito:  data.childNodes[counter++].childNodes[0].value
        ,Grupo_Delito:  data.childNodes[counter++].childNodes[0].value
        ,Delito:  data.childNodes[counter++].childNodes[0].value
        ,Circunstancia_Delito:  data.childNodes[counter++].childNodes[0].value
        ,Delito_Principal: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Forma_Comision_Delito:  data.childNodes[counter++].childNodes[0].value
        ,Forma_Accion_Delito:  data.childNodes[counter++].childNodes[0].value
        ,Modalidad_Delito:  data.childNodes[counter++].childNodes[0].value
        ,Elementos_Comision_Delito:  data.childNodes[counter++].childNodes[0].value
        ,Monto:  data.childNodes[counter++].childNodes[0].value
        ,Violencia_de_Genero: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Robo_de_Vehiculo: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Levantamiento_de_Cadaver: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Circunstancia_de_Vehiculo:  data.childNodes[counter++].childNodes[0].value
        ,Clase:  data.childNodes[counter++].childNodes[0].value
        ,Vehiculo_Robado: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Marca:  data.childNodes[counter++].childNodes[0].value
        ,Sub_Marca:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Vehiculo:  data.childNodes[counter++].childNodes[0].value
        ,Modelo: data.childNodes[counter++].childNodes[0].value
        ,Color:  data.childNodes[counter++].childNodes[0].value
        ,Placas:  data.childNodes[counter++].childNodes[0].value
        ,Estado_de_Origen_de_las_Placas:  data.childNodes[counter++].childNodes[0].value
        ,Motor:  data.childNodes[counter++].childNodes[0].value
        ,Serie:  data.childNodes[counter++].childNodes[0].value
        ,El_Vehiculo_esta_Asegurado: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Nombre_de_la_Aseguradora:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Servicio:  data.childNodes[counter++].childNodes[0].value
        ,Ruta_del_Servicio_Publico:  data.childNodes[counter++].childNodes[0].value
        ,Procedencia:  data.childNodes[counter++].childNodes[0].value
        ,Mercancia: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Descripcion_de_lo_que_Transportaba:  data.childNodes[counter++].childNodes[0].value
        ,Monto_de_la_Carga:  data.childNodes[counter++].childNodes[0].value
        ,Senas_Particulares:  data.childNodes[counter++].childNodes[0].value
        ,Modalidad_del_Robo:  data.childNodes[counter++].childNodes[0].value
        ,Causa_de_Muerte:  data.childNodes[counter++].childNodes[0].value
        ,Circunstancia_Defuncion:  data.childNodes[counter++].childNodes[0].value
        ,Consecuencia_Defuncion:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_Levantamiento:  data.childNodes[counter++].childNodes[0].value
        ,Hora_Levantamiento:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Lugar_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Pais:  data.childNodes[counter++].childNodes[0].value
        ,Estado:  data.childNodes[counter++].childNodes[0].value
        ,Municipio:  data.childNodes[counter++].childNodes[0].value
        ,Zona:  data.childNodes[counter++].childNodes[0].value
        ,Colonia:  data.childNodes[counter++].childNodes[0].value
        ,Colonia_no_Catalogada:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior: data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value
        ,Necropsia:  data.childNodes[counter++].childNodes[0].value
        ,Cronotanatodiagnostico:  data.childNodes[counter++].childNodes[0].value
        ,Ruta:  data.childNodes[counter++].childNodes[0].value
        ,Estado_del_Conductor: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Codigo_Postal: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Datos_de_Delito_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Datos_de_Delito_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_Datos_de_Delito_MPITable.fnPageChange(iPage);
    Detalle_Datos_de_Delito_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Datos_de_Delito_MPI("Detalle_Datos_de_Delito_MPI_", "_" + rowIndex);
  }
}

function Detalle_Datos_de_Delito_MPICancelRow(rowIndex) {
    var prevData = Detalle_Datos_de_Delito_MPITable.fnGetData(rowIndex);
    var data = Detalle_Datos_de_Delito_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Datos_de_Delito_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Datos_de_Delito_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Datos_de_Delito_MPIGrid(Detalle_Datos_de_Delito_MPITable.fnGetData());
    Detalle_Datos_de_Delito_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Datos_de_Delito_MPIFromDataTable() {
    var Detalle_Datos_de_Delito_MPIData = [];
    var gridData = Detalle_Datos_de_Delito_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Datos_de_Delito_MPIData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Delito: gridData[i].Tipo_de_Delito
                ,Grupo_Delito: gridData[i].Grupo_Delito
                ,Delito: gridData[i].Delito
                ,Circunstancia_Delito: gridData[i].Circunstancia_Delito
                ,Delito_Principal: gridData[i].Delito_Principal
                ,Forma_Comision_Delito: gridData[i].Forma_Comision_Delito
                ,Forma_Accion_Delito: gridData[i].Forma_Accion_Delito
                ,Modalidad_Delito: gridData[i].Modalidad_Delito
                ,Elementos_Comision_Delito: gridData[i].Elementos_Comision_Delito
                ,Monto: gridData[i].Monto
                ,Violencia_de_Genero: gridData[i].Violencia_de_Genero
                ,Robo_de_Vehiculo: gridData[i].Robo_de_Vehiculo
                ,Levantamiento_de_Cadaver: gridData[i].Levantamiento_de_Cadaver
                ,Circunstancia_de_Vehiculo: gridData[i].Circunstancia_de_Vehiculo
                ,Clase: gridData[i].Clase
                ,Vehiculo_Robado: gridData[i].Vehiculo_Robado
                ,Marca: gridData[i].Marca
                ,Sub_Marca: gridData[i].Sub_Marca
                ,Tipo_de_Vehiculo: gridData[i].Tipo_de_Vehiculo
                ,Modelo: gridData[i].Modelo
                ,Color: gridData[i].Color
                ,Placas: gridData[i].Placas
                ,Estado_de_Origen_de_las_Placas: gridData[i].Estado_de_Origen_de_las_Placas
                ,Motor: gridData[i].Motor
                ,Serie: gridData[i].Serie
                ,El_Vehiculo_esta_Asegurado: gridData[i].El_Vehiculo_esta_Asegurado
                ,Nombre_de_la_Aseguradora: gridData[i].Nombre_de_la_Aseguradora
                ,Tipo_de_Servicio: gridData[i].Tipo_de_Servicio
                ,Ruta_del_Servicio_Publico: gridData[i].Ruta_del_Servicio_Publico
                ,Procedencia: gridData[i].Procedencia
                ,Mercancia: gridData[i].Mercancia
                ,Descripcion_de_lo_que_Transportaba: gridData[i].Descripcion_de_lo_que_Transportaba
                ,Monto_de_la_Carga: gridData[i].Monto_de_la_Carga
                ,Senas_Particulares: gridData[i].Senas_Particulares
                ,Modalidad_del_Robo: gridData[i].Modalidad_del_Robo
                ,Causa_de_Muerte: gridData[i].Causa_de_Muerte
                ,Circunstancia_Defuncion: gridData[i].Circunstancia_Defuncion
                ,Consecuencia_Defuncion: gridData[i].Consecuencia_Defuncion
                ,Fecha_Levantamiento: gridData[i].Fecha_Levantamiento
                ,Hora_Levantamiento: gridData[i].Hora_Levantamiento
                ,Tipo_de_Lugar_del_Hecho: gridData[i].Tipo_de_Lugar_del_Hecho
                ,Pais: gridData[i].Pais
                ,Estado: gridData[i].Estado
                ,Municipio: gridData[i].Municipio
                ,Zona: gridData[i].Zona
                ,Colonia: gridData[i].Colonia
                ,Colonia_no_Catalogada: gridData[i].Colonia_no_Catalogada
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior
                ,Necropsia: gridData[i].Necropsia
                ,Cronotanatodiagnostico: gridData[i].Cronotanatodiagnostico
                ,Ruta: gridData[i].Ruta
                ,Estado_del_Conductor: gridData[i].Estado_del_Conductor
                ,Codigo_Postal: gridData[i].Codigo_Postal

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Datos_de_Delito_MPIData.length; i++) {
        if (removedDetalle_Datos_de_Delito_MPIData[i] != null && removedDetalle_Datos_de_Delito_MPIData[i].Clave > 0)
            Detalle_Datos_de_Delito_MPIData.push({
                Clave: removedDetalle_Datos_de_Delito_MPIData[i].Clave

                ,Tipo_de_Delito: removedDetalle_Datos_de_Delito_MPIData[i].Tipo_de_Delito
                ,Grupo_Delito: removedDetalle_Datos_de_Delito_MPIData[i].Grupo_Delito
                ,Delito: removedDetalle_Datos_de_Delito_MPIData[i].Delito
                ,Circunstancia_Delito: removedDetalle_Datos_de_Delito_MPIData[i].Circunstancia_Delito
                ,Delito_Principal: removedDetalle_Datos_de_Delito_MPIData[i].Delito_Principal
                ,Forma_Comision_Delito: removedDetalle_Datos_de_Delito_MPIData[i].Forma_Comision_Delito
                ,Forma_Accion_Delito: removedDetalle_Datos_de_Delito_MPIData[i].Forma_Accion_Delito
                ,Modalidad_Delito: removedDetalle_Datos_de_Delito_MPIData[i].Modalidad_Delito
                ,Elementos_Comision_Delito: removedDetalle_Datos_de_Delito_MPIData[i].Elementos_Comision_Delito
                ,Monto: removedDetalle_Datos_de_Delito_MPIData[i].Monto
                ,Violencia_de_Genero: removedDetalle_Datos_de_Delito_MPIData[i].Violencia_de_Genero
                ,Robo_de_Vehiculo: removedDetalle_Datos_de_Delito_MPIData[i].Robo_de_Vehiculo
                ,Levantamiento_de_Cadaver: removedDetalle_Datos_de_Delito_MPIData[i].Levantamiento_de_Cadaver
                ,Circunstancia_de_Vehiculo: removedDetalle_Datos_de_Delito_MPIData[i].Circunstancia_de_Vehiculo
                ,Clase: removedDetalle_Datos_de_Delito_MPIData[i].Clase
                ,Vehiculo_Robado: removedDetalle_Datos_de_Delito_MPIData[i].Vehiculo_Robado
                ,Marca: removedDetalle_Datos_de_Delito_MPIData[i].Marca
                ,Sub_Marca: removedDetalle_Datos_de_Delito_MPIData[i].Sub_Marca
                ,Tipo_de_Vehiculo: removedDetalle_Datos_de_Delito_MPIData[i].Tipo_de_Vehiculo
                ,Modelo: removedDetalle_Datos_de_Delito_MPIData[i].Modelo
                ,Color: removedDetalle_Datos_de_Delito_MPIData[i].Color
                ,Placas: removedDetalle_Datos_de_Delito_MPIData[i].Placas
                ,Estado_de_Origen_de_las_Placas: removedDetalle_Datos_de_Delito_MPIData[i].Estado_de_Origen_de_las_Placas
                ,Motor: removedDetalle_Datos_de_Delito_MPIData[i].Motor
                ,Serie: removedDetalle_Datos_de_Delito_MPIData[i].Serie
                ,El_Vehiculo_esta_Asegurado: removedDetalle_Datos_de_Delito_MPIData[i].El_Vehiculo_esta_Asegurado
                ,Nombre_de_la_Aseguradora: removedDetalle_Datos_de_Delito_MPIData[i].Nombre_de_la_Aseguradora
                ,Tipo_de_Servicio: removedDetalle_Datos_de_Delito_MPIData[i].Tipo_de_Servicio
                ,Ruta_del_Servicio_Publico: removedDetalle_Datos_de_Delito_MPIData[i].Ruta_del_Servicio_Publico
                ,Procedencia: removedDetalle_Datos_de_Delito_MPIData[i].Procedencia
                ,Mercancia: removedDetalle_Datos_de_Delito_MPIData[i].Mercancia
                ,Descripcion_de_lo_que_Transportaba: removedDetalle_Datos_de_Delito_MPIData[i].Descripcion_de_lo_que_Transportaba
                ,Monto_de_la_Carga: removedDetalle_Datos_de_Delito_MPIData[i].Monto_de_la_Carga
                ,Senas_Particulares: removedDetalle_Datos_de_Delito_MPIData[i].Senas_Particulares
                ,Modalidad_del_Robo: removedDetalle_Datos_de_Delito_MPIData[i].Modalidad_del_Robo
                ,Causa_de_Muerte: removedDetalle_Datos_de_Delito_MPIData[i].Causa_de_Muerte
                ,Circunstancia_Defuncion: removedDetalle_Datos_de_Delito_MPIData[i].Circunstancia_Defuncion
                ,Consecuencia_Defuncion: removedDetalle_Datos_de_Delito_MPIData[i].Consecuencia_Defuncion
                ,Fecha_Levantamiento: removedDetalle_Datos_de_Delito_MPIData[i].Fecha_Levantamiento
                ,Hora_Levantamiento: removedDetalle_Datos_de_Delito_MPIData[i].Hora_Levantamiento
                ,Tipo_de_Lugar_del_Hecho: removedDetalle_Datos_de_Delito_MPIData[i].Tipo_de_Lugar_del_Hecho
                ,Pais: removedDetalle_Datos_de_Delito_MPIData[i].Pais
                ,Estado: removedDetalle_Datos_de_Delito_MPIData[i].Estado
                ,Municipio: removedDetalle_Datos_de_Delito_MPIData[i].Municipio
                ,Zona: removedDetalle_Datos_de_Delito_MPIData[i].Zona
                ,Colonia: removedDetalle_Datos_de_Delito_MPIData[i].Colonia
                ,Colonia_no_Catalogada: removedDetalle_Datos_de_Delito_MPIData[i].Colonia_no_Catalogada
                ,Numero_Exterior: removedDetalle_Datos_de_Delito_MPIData[i].Numero_Exterior
                ,Numero_Interior: removedDetalle_Datos_de_Delito_MPIData[i].Numero_Interior
                ,Necropsia: removedDetalle_Datos_de_Delito_MPIData[i].Necropsia
                ,Cronotanatodiagnostico: removedDetalle_Datos_de_Delito_MPIData[i].Cronotanatodiagnostico
                ,Ruta: removedDetalle_Datos_de_Delito_MPIData[i].Ruta
                ,Estado_del_Conductor: removedDetalle_Datos_de_Delito_MPIData[i].Estado_del_Conductor
                ,Codigo_Postal: removedDetalle_Datos_de_Delito_MPIData[i].Codigo_Postal

                , Removed: true
            });
    }	

    return Detalle_Datos_de_Delito_MPIData;
}

function Detalle_Datos_de_Delito_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Datos_de_Delito_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Datos_de_Delito_MPIcountRowsChecked++;
    var Detalle_Datos_de_Delito_MPIRowElement = "Detalle_Datos_de_Delito_MPI_" + rowIndex.toString();
    var prevData = Detalle_Datos_de_Delito_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_Datos_de_Delito_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Datos_de_Delito_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Datos_de_Delito_MPIGetUpdateRowControls(prevData, "Detalle_Datos_de_Delito_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Datos_de_Delito_MPIRowElement + "')){ Detalle_Datos_de_Delito_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Datos_de_Delito_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Datos_de_Delito_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Datos_de_Delito_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Datos_de_Delito_MPIValidation();
    initiateUIControls();
    $('.Detalle_Datos_de_Delito_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Datos_de_Delito_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Datos_de_Delito_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Datos_de_Delito_MPITable.fnGetData().length;
    Detalle_Datos_de_Delito_MPIfnClickAddRow();
    GetAddDetalle_Datos_de_Delito_MPIPopup(currentRowIndex, 0);
}

function Detalle_Datos_de_Delito_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Datos_de_Delito_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Datos_de_Delito_MPIRowElement = "Detalle_Datos_de_Delito_MPI_" + rowIndex.toString();
    var prevData = Detalle_Datos_de_Delito_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_Datos_de_Delito_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Datos_de_Delito_MPITipo_de_Delito').val(prevData.Tipo_de_Delito);
    $('#Detalle_Datos_de_Delito_MPIGrupo_Delito').val(prevData.Grupo_Delito);
    $('#Detalle_Datos_de_Delito_MPIDelito').val(prevData.Delito);
    $('#Detalle_Datos_de_Delito_MPICircunstancia_Delito').val(prevData.Circunstancia_Delito);
    $('#Detalle_Datos_de_Delito_MPIDelito_Principal').prop('checked', prevData.Delito_Principal);
    $('#Detalle_Datos_de_Delito_MPIForma_Comision_Delito').val(prevData.Forma_Comision_Delito);
    $('#Detalle_Datos_de_Delito_MPIForma_Accion_Delito').val(prevData.Forma_Accion_Delito);
    $('#Detalle_Datos_de_Delito_MPIModalidad_Delito').val(prevData.Modalidad_Delito);
    $('#Detalle_Datos_de_Delito_MPIElementos_Comision_Delito').val(prevData.Elementos_Comision_Delito);
    $('#Detalle_Datos_de_Delito_MPIMonto').val(prevData.Monto);
    $('#Detalle_Datos_de_Delito_MPIViolencia_de_Genero').prop('checked', prevData.Violencia_de_Genero);
    $('#Detalle_Datos_de_Delito_MPIRobo_de_Vehiculo').prop('checked', prevData.Robo_de_Vehiculo);
    $('#Detalle_Datos_de_Delito_MPILevantamiento_de_Cadaver').prop('checked', prevData.Levantamiento_de_Cadaver);
    $('#Detalle_Datos_de_Delito_MPICircunstancia_de_Vehiculo').val(prevData.Circunstancia_de_Vehiculo);
    $('#Detalle_Datos_de_Delito_MPIClase').val(prevData.Clase);
    $('#Detalle_Datos_de_Delito_MPIVehiculo_Robado').prop('checked', prevData.Vehiculo_Robado);
    $('#Detalle_Datos_de_Delito_MPIMarca').val(prevData.Marca);
    $('#Detalle_Datos_de_Delito_MPISub_Marca').val(prevData.Sub_Marca);
    $('#Detalle_Datos_de_Delito_MPITipo_de_Vehiculo').val(prevData.Tipo_de_Vehiculo);
    $('#Detalle_Datos_de_Delito_MPIModelo').val(prevData.Modelo);
    $('#Detalle_Datos_de_Delito_MPIColor').val(prevData.Color);
    $('#Detalle_Datos_de_Delito_MPIPlacas').val(prevData.Placas);
    $('#Detalle_Datos_de_Delito_MPIEstado_de_Origen_de_las_Placas').val(prevData.Estado_de_Origen_de_las_Placas);
    $('#Detalle_Datos_de_Delito_MPIMotor').val(prevData.Motor);
    $('#Detalle_Datos_de_Delito_MPISerie').val(prevData.Serie);
    $('#Detalle_Datos_de_Delito_MPIEl_Vehiculo_esta_Asegurado').prop('checked', prevData.El_Vehiculo_esta_Asegurado);
    $('#Detalle_Datos_de_Delito_MPINombre_de_la_Aseguradora').val(prevData.Nombre_de_la_Aseguradora);
    $('#Detalle_Datos_de_Delito_MPITipo_de_Servicio').val(prevData.Tipo_de_Servicio);
    $('#Detalle_Datos_de_Delito_MPIRuta_del_Servicio_Publico').val(prevData.Ruta_del_Servicio_Publico);
    $('#Detalle_Datos_de_Delito_MPIProcedencia').val(prevData.Procedencia);
    $('#Detalle_Datos_de_Delito_MPIMercancia').prop('checked', prevData.Mercancia);
    $('#Detalle_Datos_de_Delito_MPIDescripcion_de_lo_que_Transportaba').val(prevData.Descripcion_de_lo_que_Transportaba);
    $('#Detalle_Datos_de_Delito_MPIMonto_de_la_Carga').val(prevData.Monto_de_la_Carga);
    $('#Detalle_Datos_de_Delito_MPISenas_Particulares').val(prevData.Senas_Particulares);
    $('#Detalle_Datos_de_Delito_MPIModalidad_del_Robo').val(prevData.Modalidad_del_Robo);
    $('#Detalle_Datos_de_Delito_MPICausa_de_Muerte').val(prevData.Causa_de_Muerte);
    $('#Detalle_Datos_de_Delito_MPICircunstancia_Defuncion').val(prevData.Circunstancia_Defuncion);
    $('#Detalle_Datos_de_Delito_MPIConsecuencia_Defuncion').val(prevData.Consecuencia_Defuncion);
    $('#Detalle_Datos_de_Delito_MPIFecha_Levantamiento').val(prevData.Fecha_Levantamiento);
    $('#Detalle_Datos_de_Delito_MPIHora_Levantamiento').val(prevData.Hora_Levantamiento);
    $('#Detalle_Datos_de_Delito_MPITipo_de_Lugar_del_Hecho').val(prevData.Tipo_de_Lugar_del_Hecho);
    $('#Detalle_Datos_de_Delito_MPIPais').val(prevData.Pais);
    $('#Detalle_Datos_de_Delito_MPIEstado').val(prevData.Estado);
    $('#Detalle_Datos_de_Delito_MPIMunicipio').val(prevData.Municipio);
    $('#Detalle_Datos_de_Delito_MPIZona').val(prevData.Zona);
    $('#Detalle_Datos_de_Delito_MPIColonia').val(prevData.Colonia);
    $('#Detalle_Datos_de_Delito_MPIColonia_no_Catalogada').val(prevData.Colonia_no_Catalogada);
    $('#Detalle_Datos_de_Delito_MPINumero_Exterior').val(prevData.Numero_Exterior);
    $('#Detalle_Datos_de_Delito_MPINumero_Interior').val(prevData.Numero_Interior);
    $('#Detalle_Datos_de_Delito_MPINecropsia').val(prevData.Necropsia);
    $('#Detalle_Datos_de_Delito_MPICronotanatodiagnostico').val(prevData.Cronotanatodiagnostico);
    $('#Detalle_Datos_de_Delito_MPIRuta').val(prevData.Ruta);
    $('#Detalle_Datos_de_Delito_MPIEstado_del_Conductor').prop('checked', prevData.Estado_del_Conductor);
    $('#Detalle_Datos_de_Delito_MPICodigo_Postal').val(prevData.Codigo_Postal);

    initiateUIControls();
























































}

function Detalle_Datos_de_Delito_MPIAddInsertRow() {
    if (Detalle_Datos_de_Delito_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_Datos_de_Delito_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Delito: ""
        ,Grupo_Delito: ""
        ,Delito: ""
        ,Circunstancia_Delito: ""
        ,Delito_Principal: ""
        ,Forma_Comision_Delito: ""
        ,Forma_Accion_Delito: ""
        ,Modalidad_Delito: ""
        ,Elementos_Comision_Delito: ""
        ,Monto: ""
        ,Violencia_de_Genero: ""
        ,Robo_de_Vehiculo: ""
        ,Levantamiento_de_Cadaver: ""
        ,Circunstancia_de_Vehiculo: ""
        ,Clase: ""
        ,Vehiculo_Robado: ""
        ,Marca: ""
        ,Sub_Marca: ""
        ,Tipo_de_Vehiculo: ""
        ,Modelo: ""
        ,Color: ""
        ,Placas: ""
        ,Estado_de_Origen_de_las_Placas: ""
        ,Motor: ""
        ,Serie: ""
        ,El_Vehiculo_esta_Asegurado: ""
        ,Nombre_de_la_Aseguradora: ""
        ,Tipo_de_Servicio: ""
        ,Ruta_del_Servicio_Publico: ""
        ,Procedencia: ""
        ,Mercancia: ""
        ,Descripcion_de_lo_que_Transportaba: ""
        ,Monto_de_la_Carga: ""
        ,Senas_Particulares: ""
        ,Modalidad_del_Robo: ""
        ,Causa_de_Muerte: ""
        ,Circunstancia_Defuncion: ""
        ,Consecuencia_Defuncion: ""
        ,Fecha_Levantamiento: ""
        ,Hora_Levantamiento: ""
        ,Tipo_de_Lugar_del_Hecho: ""
        ,Pais: ""
        ,Estado: ""
        ,Municipio: ""
        ,Zona: ""
        ,Colonia: ""
        ,Colonia_no_Catalogada: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""
        ,Necropsia: ""
        ,Cronotanatodiagnostico: ""
        ,Ruta: ""
        ,Estado_del_Conductor: ""
        ,Codigo_Postal: ""

    }
}

function Detalle_Datos_de_Delito_MPIfnClickAddRow() {
    Detalle_Datos_de_Delito_MPIcountRowsChecked++;
    Detalle_Datos_de_Delito_MPITable.fnAddData(Detalle_Datos_de_Delito_MPIAddInsertRow(), true);
    Detalle_Datos_de_Delito_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Datos_de_Delito_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Datos_de_Delito_MPIGrid tbody tr:nth-of-type(' + (Detalle_Datos_de_Delito_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Datos_de_Delito_MPI("Detalle_Datos_de_Delito_MPI_", "_" + Detalle_Datos_de_Delito_MPIinsertRowCurrentIndex);
}

function Detalle_Datos_de_Delito_MPIClearGridData() {
    Detalle_Datos_de_Delito_MPIData = [];
    Detalle_Datos_de_Delito_MPIdeletedItem = [];
    Detalle_Datos_de_Delito_MPIDataMain = [];
    Detalle_Datos_de_Delito_MPIDataMainPages = [];
    Detalle_Datos_de_Delito_MPInewItemCount = 0;
    Detalle_Datos_de_Delito_MPImaxItemIndex = 0;
    $("#Detalle_Datos_de_Delito_MPIGrid").DataTable().clear();
    $("#Detalle_Datos_de_Delito_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_Datos_de_Delito_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Datos_de_Delito_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Datos_de_Delito_MPIData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Delito', Detalle_Datos_de_Delito_MPIData[i].Tipo_de_Delito);
        form_data.append('[' + i + '].Grupo_Delito', Detalle_Datos_de_Delito_MPIData[i].Grupo_Delito);
        form_data.append('[' + i + '].Delito', Detalle_Datos_de_Delito_MPIData[i].Delito);
        form_data.append('[' + i + '].Circunstancia_Delito', Detalle_Datos_de_Delito_MPIData[i].Circunstancia_Delito);
        form_data.append('[' + i + '].Delito_Principal', Detalle_Datos_de_Delito_MPIData[i].Delito_Principal);
        form_data.append('[' + i + '].Forma_Comision_Delito', Detalle_Datos_de_Delito_MPIData[i].Forma_Comision_Delito);
        form_data.append('[' + i + '].Forma_Accion_Delito', Detalle_Datos_de_Delito_MPIData[i].Forma_Accion_Delito);
        form_data.append('[' + i + '].Modalidad_Delito', Detalle_Datos_de_Delito_MPIData[i].Modalidad_Delito);
        form_data.append('[' + i + '].Elementos_Comision_Delito', Detalle_Datos_de_Delito_MPIData[i].Elementos_Comision_Delito);
        form_data.append('[' + i + '].Monto', Detalle_Datos_de_Delito_MPIData[i].Monto.toString().replace('$',''));
        form_data.append('[' + i + '].Violencia_de_Genero', Detalle_Datos_de_Delito_MPIData[i].Violencia_de_Genero);
        form_data.append('[' + i + '].Robo_de_Vehiculo', Detalle_Datos_de_Delito_MPIData[i].Robo_de_Vehiculo);
        form_data.append('[' + i + '].Levantamiento_de_Cadaver', Detalle_Datos_de_Delito_MPIData[i].Levantamiento_de_Cadaver);
        form_data.append('[' + i + '].Circunstancia_de_Vehiculo', Detalle_Datos_de_Delito_MPIData[i].Circunstancia_de_Vehiculo);
        form_data.append('[' + i + '].Clase', Detalle_Datos_de_Delito_MPIData[i].Clase);
        form_data.append('[' + i + '].Vehiculo_Robado', Detalle_Datos_de_Delito_MPIData[i].Vehiculo_Robado);
        form_data.append('[' + i + '].Marca', Detalle_Datos_de_Delito_MPIData[i].Marca);
        form_data.append('[' + i + '].Sub_Marca', Detalle_Datos_de_Delito_MPIData[i].Sub_Marca);
        form_data.append('[' + i + '].Tipo_de_Vehiculo', Detalle_Datos_de_Delito_MPIData[i].Tipo_de_Vehiculo);
        form_data.append('[' + i + '].Modelo', Detalle_Datos_de_Delito_MPIData[i].Modelo);
        form_data.append('[' + i + '].Color', Detalle_Datos_de_Delito_MPIData[i].Color);
        form_data.append('[' + i + '].Placas', Detalle_Datos_de_Delito_MPIData[i].Placas);
        form_data.append('[' + i + '].Estado_de_Origen_de_las_Placas', Detalle_Datos_de_Delito_MPIData[i].Estado_de_Origen_de_las_Placas);
        form_data.append('[' + i + '].Motor', Detalle_Datos_de_Delito_MPIData[i].Motor);
        form_data.append('[' + i + '].Serie', Detalle_Datos_de_Delito_MPIData[i].Serie);
        form_data.append('[' + i + '].El_Vehiculo_esta_Asegurado', Detalle_Datos_de_Delito_MPIData[i].El_Vehiculo_esta_Asegurado);
        form_data.append('[' + i + '].Nombre_de_la_Aseguradora', Detalle_Datos_de_Delito_MPIData[i].Nombre_de_la_Aseguradora);
        form_data.append('[' + i + '].Tipo_de_Servicio', Detalle_Datos_de_Delito_MPIData[i].Tipo_de_Servicio);
        form_data.append('[' + i + '].Ruta_del_Servicio_Publico', Detalle_Datos_de_Delito_MPIData[i].Ruta_del_Servicio_Publico);
        form_data.append('[' + i + '].Procedencia', Detalle_Datos_de_Delito_MPIData[i].Procedencia);
        form_data.append('[' + i + '].Mercancia', Detalle_Datos_de_Delito_MPIData[i].Mercancia);
        form_data.append('[' + i + '].Descripcion_de_lo_que_Transportaba', Detalle_Datos_de_Delito_MPIData[i].Descripcion_de_lo_que_Transportaba);
        form_data.append('[' + i + '].Monto_de_la_Carga', Detalle_Datos_de_Delito_MPIData[i].Monto_de_la_Carga.toString().replace('$',''));
        form_data.append('[' + i + '].Senas_Particulares', Detalle_Datos_de_Delito_MPIData[i].Senas_Particulares);
        form_data.append('[' + i + '].Modalidad_del_Robo', Detalle_Datos_de_Delito_MPIData[i].Modalidad_del_Robo);
        form_data.append('[' + i + '].Causa_de_Muerte', Detalle_Datos_de_Delito_MPIData[i].Causa_de_Muerte);
        form_data.append('[' + i + '].Circunstancia_Defuncion', Detalle_Datos_de_Delito_MPIData[i].Circunstancia_Defuncion);
        form_data.append('[' + i + '].Consecuencia_Defuncion', Detalle_Datos_de_Delito_MPIData[i].Consecuencia_Defuncion);
        form_data.append('[' + i + '].Fecha_Levantamiento', Detalle_Datos_de_Delito_MPIData[i].Fecha_Levantamiento);
        form_data.append('[' + i + '].Hora_Levantamiento', Detalle_Datos_de_Delito_MPIData[i].Hora_Levantamiento);
        form_data.append('[' + i + '].Tipo_de_Lugar_del_Hecho', Detalle_Datos_de_Delito_MPIData[i].Tipo_de_Lugar_del_Hecho);
        form_data.append('[' + i + '].Pais', Detalle_Datos_de_Delito_MPIData[i].Pais);
        form_data.append('[' + i + '].Estado', Detalle_Datos_de_Delito_MPIData[i].Estado);
        form_data.append('[' + i + '].Municipio', Detalle_Datos_de_Delito_MPIData[i].Municipio);
        form_data.append('[' + i + '].Zona', Detalle_Datos_de_Delito_MPIData[i].Zona);
        form_data.append('[' + i + '].Colonia', Detalle_Datos_de_Delito_MPIData[i].Colonia);
        form_data.append('[' + i + '].Colonia_no_Catalogada', Detalle_Datos_de_Delito_MPIData[i].Colonia_no_Catalogada);
        form_data.append('[' + i + '].Numero_Exterior', Detalle_Datos_de_Delito_MPIData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Detalle_Datos_de_Delito_MPIData[i].Numero_Interior);
        form_data.append('[' + i + '].Necropsia', Detalle_Datos_de_Delito_MPIData[i].Necropsia);
        form_data.append('[' + i + '].Cronotanatodiagnostico', Detalle_Datos_de_Delito_MPIData[i].Cronotanatodiagnostico);
        form_data.append('[' + i + '].Ruta', Detalle_Datos_de_Delito_MPIData[i].Ruta);
        form_data.append('[' + i + '].Estado_del_Conductor', Detalle_Datos_de_Delito_MPIData[i].Estado_del_Conductor);
        form_data.append('[' + i + '].Codigo_Postal', Detalle_Datos_de_Delito_MPIData[i].Codigo_Postal);

        form_data.append('[' + i + '].Removed', Detalle_Datos_de_Delito_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_Datos_de_Delito_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Datos_de_Delito_MPI("Detalle_Datos_de_Delito_MPITable", rowIndex)) {
    var prevData = Detalle_Datos_de_Delito_MPITable.fnGetData(rowIndex);
    var data = Detalle_Datos_de_Delito_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Delito: $('#Detalle_Datos_de_Delito_MPITipo_de_Delito').val()
        ,Grupo_Delito: $('#Detalle_Datos_de_Delito_MPIGrupo_Delito').val()
        ,Delito: $('#Detalle_Datos_de_Delito_MPIDelito').val()
        ,Circunstancia_Delito: $('#Detalle_Datos_de_Delito_MPICircunstancia_Delito').val()
        ,Delito_Principal: $('#Detalle_Datos_de_Delito_MPIDelito_Principal').is(':checked')
        ,Forma_Comision_Delito: $('#Detalle_Datos_de_Delito_MPIForma_Comision_Delito').val()
        ,Forma_Accion_Delito: $('#Detalle_Datos_de_Delito_MPIForma_Accion_Delito').val()
        ,Modalidad_Delito: $('#Detalle_Datos_de_Delito_MPIModalidad_Delito').val()
        ,Elementos_Comision_Delito: $('#Detalle_Datos_de_Delito_MPIElementos_Comision_Delito').val()
        ,Monto: $('#Detalle_Datos_de_Delito_MPIMonto').val()
        ,Violencia_de_Genero: $('#Detalle_Datos_de_Delito_MPIViolencia_de_Genero').is(':checked')
        ,Robo_de_Vehiculo: $('#Detalle_Datos_de_Delito_MPIRobo_de_Vehiculo').is(':checked')
        ,Levantamiento_de_Cadaver: $('#Detalle_Datos_de_Delito_MPILevantamiento_de_Cadaver').is(':checked')
        ,Circunstancia_de_Vehiculo: $('#Detalle_Datos_de_Delito_MPICircunstancia_de_Vehiculo').val()
        ,Clase: $('#Detalle_Datos_de_Delito_MPIClase').val()
        ,Vehiculo_Robado: $('#Detalle_Datos_de_Delito_MPIVehiculo_Robado').is(':checked')
        ,Marca: $('#Detalle_Datos_de_Delito_MPIMarca').val()
        ,Sub_Marca: $('#Detalle_Datos_de_Delito_MPISub_Marca').val()
        ,Tipo_de_Vehiculo: $('#Detalle_Datos_de_Delito_MPITipo_de_Vehiculo').val()
        ,Modelo: $('#Detalle_Datos_de_Delito_MPIModelo').val()

        ,Color: $('#Detalle_Datos_de_Delito_MPIColor').val()
        ,Placas: $('#Detalle_Datos_de_Delito_MPIPlacas').val()
        ,Estado_de_Origen_de_las_Placas: $('#Detalle_Datos_de_Delito_MPIEstado_de_Origen_de_las_Placas').val()
        ,Motor: $('#Detalle_Datos_de_Delito_MPIMotor').val()
        ,Serie: $('#Detalle_Datos_de_Delito_MPISerie').val()
        ,El_Vehiculo_esta_Asegurado: $('#Detalle_Datos_de_Delito_MPIEl_Vehiculo_esta_Asegurado').is(':checked')
        ,Nombre_de_la_Aseguradora: $('#Detalle_Datos_de_Delito_MPINombre_de_la_Aseguradora').val()
        ,Tipo_de_Servicio: $('#Detalle_Datos_de_Delito_MPITipo_de_Servicio').val()
        ,Ruta_del_Servicio_Publico: $('#Detalle_Datos_de_Delito_MPIRuta_del_Servicio_Publico').val()
        ,Procedencia: $('#Detalle_Datos_de_Delito_MPIProcedencia').val()
        ,Mercancia: $('#Detalle_Datos_de_Delito_MPIMercancia').is(':checked')
        ,Descripcion_de_lo_que_Transportaba: $('#Detalle_Datos_de_Delito_MPIDescripcion_de_lo_que_Transportaba').val()
        ,Monto_de_la_Carga: $('#Detalle_Datos_de_Delito_MPIMonto_de_la_Carga').val()
        ,Senas_Particulares: $('#Detalle_Datos_de_Delito_MPISenas_Particulares').val()
        ,Modalidad_del_Robo: $('#Detalle_Datos_de_Delito_MPIModalidad_del_Robo').val()
        ,Causa_de_Muerte: $('#Detalle_Datos_de_Delito_MPICausa_de_Muerte').val()
        ,Circunstancia_Defuncion: $('#Detalle_Datos_de_Delito_MPICircunstancia_Defuncion').val()
        ,Consecuencia_Defuncion: $('#Detalle_Datos_de_Delito_MPIConsecuencia_Defuncion').val()
        ,Fecha_Levantamiento: $('#Detalle_Datos_de_Delito_MPIFecha_Levantamiento').val()
        ,Hora_Levantamiento: $('#Detalle_Datos_de_Delito_MPIHora_Levantamiento').val()
        ,Tipo_de_Lugar_del_Hecho: $('#Detalle_Datos_de_Delito_MPITipo_de_Lugar_del_Hecho').val()
        ,Pais: $('#Detalle_Datos_de_Delito_MPIPais').val()
        ,Estado: $('#Detalle_Datos_de_Delito_MPIEstado').val()
        ,Municipio: $('#Detalle_Datos_de_Delito_MPIMunicipio').val()
        ,Zona: $('#Detalle_Datos_de_Delito_MPIZona').val()
        ,Colonia: $('#Detalle_Datos_de_Delito_MPIColonia').val()
        ,Colonia_no_Catalogada: $('#Detalle_Datos_de_Delito_MPIColonia_no_Catalogada').val()
        ,Numero_Exterior: $('#Detalle_Datos_de_Delito_MPINumero_Exterior').val()

        ,Numero_Interior: $('#Detalle_Datos_de_Delito_MPINumero_Interior').val()
        ,Necropsia: $('#Detalle_Datos_de_Delito_MPINecropsia').val()
        ,Cronotanatodiagnostico: $('#Detalle_Datos_de_Delito_MPICronotanatodiagnostico').val()
        ,Ruta: $('#Detalle_Datos_de_Delito_MPIRuta').val()
        ,Estado_del_Conductor: $('#Detalle_Datos_de_Delito_MPIEstado_del_Conductor').is(':checked')
        ,Codigo_Postal: $('#Detalle_Datos_de_Delito_MPICodigo_Postal').val()


    }

    Detalle_Datos_de_Delito_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Datos_de_Delito_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Datos_de_Delito_MPI-form').modal({ show: false });
    $('#AddDetalle_Datos_de_Delito_MPI-form').modal('hide');
    Detalle_Datos_de_Delito_MPIEditRow(rowIndex);
    Detalle_Datos_de_Delito_MPIInsertRow(rowIndex);
    //}
}
function Detalle_Datos_de_Delito_MPIRemoveAddRow(rowIndex) {
    Detalle_Datos_de_Delito_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Datos_de_Delito_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Persona_Moral_MPI MultiRow
var Detalle_de_Persona_Moral_MPIcountRowsChecked = 0;







function GetDetalle_de_Persona_Moral_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Persona_Moral_MPI_PaisItems.length; i++) {
        if (Detalle_de_Persona_Moral_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Persona_Moral_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Persona_Moral_MPI_PaisDropDown() {
    var Detalle_de_Persona_Moral_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Persona_Moral_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Persona_Moral_MPI_PaisDropdown);
    if(Detalle_de_Persona_Moral_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Persona_Moral_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Persona_Moral_MPI_PaisItems[i].Clave, text:    Detalle_de_Persona_Moral_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Persona_Moral_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Persona_Moral_MPI_PaisDropdown;
}
function GetDetalle_de_Persona_Moral_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Persona_Moral_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Persona_Moral_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Persona_Moral_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Persona_Moral_MPI_EstadoDropDown() {
    var Detalle_de_Persona_Moral_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Persona_Moral_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Persona_Moral_MPI_EstadoDropdown);
    if(Detalle_de_Persona_Moral_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Persona_Moral_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Persona_Moral_MPI_EstadoItems[i].Clave, text:    Detalle_de_Persona_Moral_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Persona_Moral_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Persona_Moral_MPI_EstadoDropdown;
}
function GetDetalle_de_Persona_Moral_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Persona_Moral_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Persona_Moral_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Persona_Moral_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Persona_Moral_MPI_MunicipioDropDown() {
    var Detalle_de_Persona_Moral_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Persona_Moral_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Persona_Moral_MPI_MunicipioDropdown);
    if(Detalle_de_Persona_Moral_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Persona_Moral_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Persona_Moral_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Persona_Moral_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Persona_Moral_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Persona_Moral_MPI_MunicipioDropdown;
}
function GetDetalle_de_Persona_Moral_MPI_LocalidadName(Id) {
    for (var i = 0; i < Detalle_de_Persona_Moral_MPI_LocalidadItems.length; i++) {
        if (Detalle_de_Persona_Moral_MPI_LocalidadItems[i].Clave == Id) {
            return Detalle_de_Persona_Moral_MPI_LocalidadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Persona_Moral_MPI_LocalidadDropDown() {
    var Detalle_de_Persona_Moral_MPI_LocalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Persona_Moral_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Persona_Moral_MPI_LocalidadDropdown);
    if(Detalle_de_Persona_Moral_MPI_LocalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Persona_Moral_MPI_LocalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Persona_Moral_MPI_LocalidadItems[i].Clave, text:    Detalle_de_Persona_Moral_MPI_LocalidadItems[i].Descripcion }).appendTo(Detalle_de_Persona_Moral_MPI_LocalidadDropdown);
       }
    }
    return Detalle_de_Persona_Moral_MPI_LocalidadDropdown;
}
function GetDetalle_de_Persona_Moral_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Persona_Moral_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Persona_Moral_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Persona_Moral_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Persona_Moral_MPI_ColoniaDropDown() {
    var Detalle_de_Persona_Moral_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Persona_Moral_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Persona_Moral_MPI_ColoniaDropdown);
    if(Detalle_de_Persona_Moral_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Persona_Moral_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Persona_Moral_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Persona_Moral_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Persona_Moral_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Persona_Moral_MPI_ColoniaDropdown;
}









function GetInsertDetalle_de_Persona_Moral_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Nombre Nombre').attr('id', 'Detalle_de_Persona_Moral_MPI_Nombre_' + index).attr('data-field', 'Nombre');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Apellido_Paterno Apellido_Paterno').attr('id', 'Detalle_de_Persona_Moral_MPI_Apellido_Paterno_' + index).attr('data-field', 'Apellido_Paterno');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Apellido_Materno Apellido_Materno').attr('id', 'Detalle_de_Persona_Moral_MPI_Apellido_Materno_' + index).attr('data-field', 'Apellido_Materno');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Nombre_Completo Nombre_Completo').attr('id', 'Detalle_de_Persona_Moral_MPI_Nombre_Completo_' + index).attr('data-field', 'Nombre_Completo');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Calidad_Juridica Calidad_Juridica').attr('id', 'Detalle_de_Persona_Moral_MPI_Calidad_Juridica_' + index).attr('data-field', 'Calidad_Juridica');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Razon_Social Razon_Social').attr('id', 'Detalle_de_Persona_Moral_MPI_Razon_Social_' + index).attr('data-field', 'Razon_Social');
    columnData[6] = $(GetDetalle_de_Persona_Moral_MPI_PaisDropDown()).addClass('Detalle_de_Persona_Moral_MPI_Pais Pais').attr('id', 'Detalle_de_Persona_Moral_MPI_Pais_' + index).attr('data-field', 'Pais').after($.parseHTML(addNew('Detalle_de_Persona_Moral_MPI', 'Pais', 'Pais', 264206)));
    columnData[7] = $(GetDetalle_de_Persona_Moral_MPI_EstadoDropDown()).addClass('Detalle_de_Persona_Moral_MPI_Estado Estado').attr('id', 'Detalle_de_Persona_Moral_MPI_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_de_Persona_Moral_MPI', 'Estado', 'Estado', 264207)));
    columnData[8] = $(GetDetalle_de_Persona_Moral_MPI_MunicipioDropDown()).addClass('Detalle_de_Persona_Moral_MPI_Municipio Municipio').attr('id', 'Detalle_de_Persona_Moral_MPI_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_de_Persona_Moral_MPI', 'Municipio', 'Municipio', 264208)));
    columnData[9] = $(GetDetalle_de_Persona_Moral_MPI_LocalidadDropDown()).addClass('Detalle_de_Persona_Moral_MPI_Localidad Localidad').attr('id', 'Detalle_de_Persona_Moral_MPI_Localidad_' + index).attr('data-field', 'Localidad').after($.parseHTML(addNew('Detalle_de_Persona_Moral_MPI', 'Localidad', 'Localidad', 264209)));
    columnData[10] = $(GetDetalle_de_Persona_Moral_MPI_ColoniaDropDown()).addClass('Detalle_de_Persona_Moral_MPI_Colonia Colonia').attr('id', 'Detalle_de_Persona_Moral_MPI_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_de_Persona_Moral_MPI', 'Colonia', 'Colonia', 264210)));
    columnData[11] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Calle Calle').attr('id', 'Detalle_de_Persona_Moral_MPI_Calle_' + index).attr('data-field', 'Calle');
    columnData[12] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Persona_Moral_MPI_Numero_Exterior Numero_Exterior').attr('id', 'Detalle_de_Persona_Moral_MPI_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[13] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Numero_Interior Numero_Interior').attr('id', 'Detalle_de_Persona_Moral_MPI_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[14] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Telefono Telefono').attr('id', 'Detalle_de_Persona_Moral_MPI_Telefono_' + index).attr('data-field', 'Telefono');
    columnData[15] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Persona_Moral_MPI_Extension Extension').attr('id', 'Detalle_de_Persona_Moral_MPI_Extension_' + index).attr('data-field', 'Extension');
    columnData[16] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Celular Celular').attr('id', 'Detalle_de_Persona_Moral_MPI_Celular_' + index).attr('data-field', 'Celular');
    columnData[17] = $($.parseHTML(inputData)).addClass('Detalle_de_Persona_Moral_MPI_Correo_Electronico Correo_Electronico').attr('id', 'Detalle_de_Persona_Moral_MPI_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Persona_Moral_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Persona_Moral_MPI("Detalle_de_Persona_Moral_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_Persona_Moral_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Persona_Moral_MPI';
    var prevData = Detalle_de_Persona_Moral_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Persona_Moral_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_Completo:  data.childNodes[counter++].childNodes[0].value
        ,Calidad_Juridica:  data.childNodes[counter++].childNodes[0].value
        ,Razon_Social:  data.childNodes[counter++].childNodes[0].value
        ,Pais:  data.childNodes[counter++].childNodes[0].value
        ,Estado:  data.childNodes[counter++].childNodes[0].value
        ,Municipio:  data.childNodes[counter++].childNodes[0].value
        ,Localidad:  data.childNodes[counter++].childNodes[0].value
        ,Colonia:  data.childNodes[counter++].childNodes[0].value
        ,Calle:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior: data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value
        ,Telefono:  data.childNodes[counter++].childNodes[0].value
        ,Extension: data.childNodes[counter++].childNodes[0].value
        ,Celular:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Persona_Moral_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Persona_Moral_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Persona_Moral_MPITable.fnPageChange(iPage);
    Detalle_de_Persona_Moral_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Persona_Moral_MPI("Detalle_de_Persona_Moral_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_Persona_Moral_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_Persona_Moral_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Persona_Moral_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Persona_Moral_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Persona_Moral_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Persona_Moral_MPIGrid(Detalle_de_Persona_Moral_MPITable.fnGetData());
    Detalle_de_Persona_Moral_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Persona_Moral_MPIFromDataTable() {
    var Detalle_de_Persona_Moral_MPIData = [];
    var gridData = Detalle_de_Persona_Moral_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Persona_Moral_MPIData.push({
                Clave: gridData[i].Clave

                ,Nombre: gridData[i].Nombre
                ,Apellido_Paterno: gridData[i].Apellido_Paterno
                ,Apellido_Materno: gridData[i].Apellido_Materno
                ,Nombre_Completo: gridData[i].Nombre_Completo
                ,Calidad_Juridica: gridData[i].Calidad_Juridica
                ,Razon_Social: gridData[i].Razon_Social
                ,Pais: gridData[i].Pais
                ,Estado: gridData[i].Estado
                ,Municipio: gridData[i].Municipio
                ,Localidad: gridData[i].Localidad
                ,Colonia: gridData[i].Colonia
                ,Calle: gridData[i].Calle
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior
                ,Telefono: gridData[i].Telefono
                ,Extension: gridData[i].Extension
                ,Celular: gridData[i].Celular
                ,Correo_Electronico: gridData[i].Correo_Electronico

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Persona_Moral_MPIData.length; i++) {
        if (removedDetalle_de_Persona_Moral_MPIData[i] != null && removedDetalle_de_Persona_Moral_MPIData[i].Clave > 0)
            Detalle_de_Persona_Moral_MPIData.push({
                Clave: removedDetalle_de_Persona_Moral_MPIData[i].Clave

                ,Nombre: removedDetalle_de_Persona_Moral_MPIData[i].Nombre
                ,Apellido_Paterno: removedDetalle_de_Persona_Moral_MPIData[i].Apellido_Paterno
                ,Apellido_Materno: removedDetalle_de_Persona_Moral_MPIData[i].Apellido_Materno
                ,Nombre_Completo: removedDetalle_de_Persona_Moral_MPIData[i].Nombre_Completo
                ,Calidad_Juridica: removedDetalle_de_Persona_Moral_MPIData[i].Calidad_Juridica
                ,Razon_Social: removedDetalle_de_Persona_Moral_MPIData[i].Razon_Social
                ,Pais: removedDetalle_de_Persona_Moral_MPIData[i].Pais
                ,Estado: removedDetalle_de_Persona_Moral_MPIData[i].Estado
                ,Municipio: removedDetalle_de_Persona_Moral_MPIData[i].Municipio
                ,Localidad: removedDetalle_de_Persona_Moral_MPIData[i].Localidad
                ,Colonia: removedDetalle_de_Persona_Moral_MPIData[i].Colonia
                ,Calle: removedDetalle_de_Persona_Moral_MPIData[i].Calle
                ,Numero_Exterior: removedDetalle_de_Persona_Moral_MPIData[i].Numero_Exterior
                ,Numero_Interior: removedDetalle_de_Persona_Moral_MPIData[i].Numero_Interior
                ,Telefono: removedDetalle_de_Persona_Moral_MPIData[i].Telefono
                ,Extension: removedDetalle_de_Persona_Moral_MPIData[i].Extension
                ,Celular: removedDetalle_de_Persona_Moral_MPIData[i].Celular
                ,Correo_Electronico: removedDetalle_de_Persona_Moral_MPIData[i].Correo_Electronico

                , Removed: true
            });
    }	

    return Detalle_de_Persona_Moral_MPIData;
}

function Detalle_de_Persona_Moral_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Persona_Moral_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Persona_Moral_MPIcountRowsChecked++;
    var Detalle_de_Persona_Moral_MPIRowElement = "Detalle_de_Persona_Moral_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Persona_Moral_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_Persona_Moral_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Persona_Moral_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Persona_Moral_MPIGetUpdateRowControls(prevData, "Detalle_de_Persona_Moral_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Persona_Moral_MPIRowElement + "')){ Detalle_de_Persona_Moral_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Persona_Moral_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Persona_Moral_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Persona_Moral_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Persona_Moral_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_Persona_Moral_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Persona_Moral_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Persona_Moral_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Persona_Moral_MPITable.fnGetData().length;
    Detalle_de_Persona_Moral_MPIfnClickAddRow();
    GetAddDetalle_de_Persona_Moral_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_Persona_Moral_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Persona_Moral_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Persona_Moral_MPIRowElement = "Detalle_de_Persona_Moral_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Persona_Moral_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Persona_Moral_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Persona_Moral_MPINombre').val(prevData.Nombre);
    $('#Detalle_de_Persona_Moral_MPIApellido_Paterno').val(prevData.Apellido_Paterno);
    $('#Detalle_de_Persona_Moral_MPIApellido_Materno').val(prevData.Apellido_Materno);
    $('#Detalle_de_Persona_Moral_MPINombre_Completo').val(prevData.Nombre_Completo);
    $('#Detalle_de_Persona_Moral_MPICalidad_Juridica').val(prevData.Calidad_Juridica);
    $('#Detalle_de_Persona_Moral_MPIRazon_Social').val(prevData.Razon_Social);
    $('#Detalle_de_Persona_Moral_MPIPais').val(prevData.Pais);
    $('#Detalle_de_Persona_Moral_MPIEstado').val(prevData.Estado);
    $('#Detalle_de_Persona_Moral_MPIMunicipio').val(prevData.Municipio);
    $('#Detalle_de_Persona_Moral_MPILocalidad').val(prevData.Localidad);
    $('#Detalle_de_Persona_Moral_MPIColonia').val(prevData.Colonia);
    $('#Detalle_de_Persona_Moral_MPICalle').val(prevData.Calle);
    $('#Detalle_de_Persona_Moral_MPINumero_Exterior').val(prevData.Numero_Exterior);
    $('#Detalle_de_Persona_Moral_MPINumero_Interior').val(prevData.Numero_Interior);
    $('#Detalle_de_Persona_Moral_MPITelefono').val(prevData.Telefono);
    $('#Detalle_de_Persona_Moral_MPIExtension').val(prevData.Extension);
    $('#Detalle_de_Persona_Moral_MPICelular').val(prevData.Celular);
    $('#Detalle_de_Persona_Moral_MPICorreo_Electronico').val(prevData.Correo_Electronico);

    initiateUIControls();




















}

function Detalle_de_Persona_Moral_MPIAddInsertRow() {
    if (Detalle_de_Persona_Moral_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_Persona_Moral_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre: ""
        ,Apellido_Paterno: ""
        ,Apellido_Materno: ""
        ,Nombre_Completo: ""
        ,Calidad_Juridica: ""
        ,Razon_Social: ""
        ,Pais: ""
        ,Estado: ""
        ,Municipio: ""
        ,Localidad: ""
        ,Colonia: ""
        ,Calle: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""
        ,Telefono: ""
        ,Extension: ""
        ,Celular: ""
        ,Correo_Electronico: ""

    }
}

function Detalle_de_Persona_Moral_MPIfnClickAddRow() {
    Detalle_de_Persona_Moral_MPIcountRowsChecked++;
    Detalle_de_Persona_Moral_MPITable.fnAddData(Detalle_de_Persona_Moral_MPIAddInsertRow(), true);
    Detalle_de_Persona_Moral_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Persona_Moral_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Persona_Moral_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_Persona_Moral_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Persona_Moral_MPI("Detalle_de_Persona_Moral_MPI_", "_" + Detalle_de_Persona_Moral_MPIinsertRowCurrentIndex);
}

function Detalle_de_Persona_Moral_MPIClearGridData() {
    Detalle_de_Persona_Moral_MPIData = [];
    Detalle_de_Persona_Moral_MPIdeletedItem = [];
    Detalle_de_Persona_Moral_MPIDataMain = [];
    Detalle_de_Persona_Moral_MPIDataMainPages = [];
    Detalle_de_Persona_Moral_MPInewItemCount = 0;
    Detalle_de_Persona_Moral_MPImaxItemIndex = 0;
    $("#Detalle_de_Persona_Moral_MPIGrid").DataTable().clear();
    $("#Detalle_de_Persona_Moral_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Persona_Moral_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Persona_Moral_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Persona_Moral_MPIData[i].Clave);

        form_data.append('[' + i + '].Nombre', Detalle_de_Persona_Moral_MPIData[i].Nombre);
        form_data.append('[' + i + '].Apellido_Paterno', Detalle_de_Persona_Moral_MPIData[i].Apellido_Paterno);
        form_data.append('[' + i + '].Apellido_Materno', Detalle_de_Persona_Moral_MPIData[i].Apellido_Materno);
        form_data.append('[' + i + '].Nombre_Completo', Detalle_de_Persona_Moral_MPIData[i].Nombre_Completo);
        form_data.append('[' + i + '].Calidad_Juridica', Detalle_de_Persona_Moral_MPIData[i].Calidad_Juridica);
        form_data.append('[' + i + '].Razon_Social', Detalle_de_Persona_Moral_MPIData[i].Razon_Social);
        form_data.append('[' + i + '].Pais', Detalle_de_Persona_Moral_MPIData[i].Pais);
        form_data.append('[' + i + '].Estado', Detalle_de_Persona_Moral_MPIData[i].Estado);
        form_data.append('[' + i + '].Municipio', Detalle_de_Persona_Moral_MPIData[i].Municipio);
        form_data.append('[' + i + '].Localidad', Detalle_de_Persona_Moral_MPIData[i].Localidad);
        form_data.append('[' + i + '].Colonia', Detalle_de_Persona_Moral_MPIData[i].Colonia);
        form_data.append('[' + i + '].Calle', Detalle_de_Persona_Moral_MPIData[i].Calle);
        form_data.append('[' + i + '].Numero_Exterior', Detalle_de_Persona_Moral_MPIData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Detalle_de_Persona_Moral_MPIData[i].Numero_Interior);
        form_data.append('[' + i + '].Telefono', Detalle_de_Persona_Moral_MPIData[i].Telefono);
        form_data.append('[' + i + '].Extension', Detalle_de_Persona_Moral_MPIData[i].Extension);
        form_data.append('[' + i + '].Celular', Detalle_de_Persona_Moral_MPIData[i].Celular);
        form_data.append('[' + i + '].Correo_Electronico', Detalle_de_Persona_Moral_MPIData[i].Correo_Electronico);

        form_data.append('[' + i + '].Removed', Detalle_de_Persona_Moral_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Persona_Moral_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Persona_Moral_MPI("Detalle_de_Persona_Moral_MPITable", rowIndex)) {
    var prevData = Detalle_de_Persona_Moral_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Persona_Moral_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre: $('#Detalle_de_Persona_Moral_MPINombre').val()
        ,Apellido_Paterno: $('#Detalle_de_Persona_Moral_MPIApellido_Paterno').val()
        ,Apellido_Materno: $('#Detalle_de_Persona_Moral_MPIApellido_Materno').val()
        ,Nombre_Completo: $('#Detalle_de_Persona_Moral_MPINombre_Completo').val()
        ,Calidad_Juridica: $('#Detalle_de_Persona_Moral_MPICalidad_Juridica').val()
        ,Razon_Social: $('#Detalle_de_Persona_Moral_MPIRazon_Social').val()
        ,Pais: $('#Detalle_de_Persona_Moral_MPIPais').val()
        ,Estado: $('#Detalle_de_Persona_Moral_MPIEstado').val()
        ,Municipio: $('#Detalle_de_Persona_Moral_MPIMunicipio').val()
        ,Localidad: $('#Detalle_de_Persona_Moral_MPILocalidad').val()
        ,Colonia: $('#Detalle_de_Persona_Moral_MPIColonia').val()
        ,Calle: $('#Detalle_de_Persona_Moral_MPICalle').val()
        ,Numero_Exterior: $('#Detalle_de_Persona_Moral_MPINumero_Exterior').val()

        ,Numero_Interior: $('#Detalle_de_Persona_Moral_MPINumero_Interior').val()
        ,Telefono: $('#Detalle_de_Persona_Moral_MPITelefono').val()
        ,Extension: $('#Detalle_de_Persona_Moral_MPIExtension').val()

        ,Celular: $('#Detalle_de_Persona_Moral_MPICelular').val()
        ,Correo_Electronico: $('#Detalle_de_Persona_Moral_MPICorreo_Electronico').val()

    }

    Detalle_de_Persona_Moral_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Persona_Moral_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Persona_Moral_MPI-form').modal({ show: false });
    $('#AddDetalle_de_Persona_Moral_MPI-form').modal('hide');
    Detalle_de_Persona_Moral_MPIEditRow(rowIndex);
    Detalle_de_Persona_Moral_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_Persona_Moral_MPIRemoveAddRow(rowIndex) {
    Detalle_de_Persona_Moral_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Persona_Moral_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Servicio_de_Apoyo_MPI MultiRow
var Detalle_de_Servicio_de_Apoyo_MPIcountRowsChecked = 0;

function GetDetalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoName(Id) {
    for (var i = 0; i < Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoItems.length; i++) {
        if (Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoItems[i].Clave == Id) {
            return Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoItems[i].Servicio;
        }
    }
    return "";
}

function GetDetalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoDropDown() {
    var Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Servicio_de_Apoyo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoDropdown);
    if(Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoItems != null)
    {
       for (var i = 0; i < Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoItems.length; i++) {
           $('<option />', { value: Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoItems[i].Clave, text:    Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoItems[i].Servicio }).appendTo(Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoDropdown);
       }
    }
    return Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoDropdown;
}


function GetDetalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIName(Id) {
    for (var i = 0; i < Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIItems.length; i++) {
        if (Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIItems[i].Clave == Id) {
            return Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIDropDown() {
    var Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Servicio_de_Apoyo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIDropdown);
    if(Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIItems != null)
    {
       for (var i = 0; i < Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIItems.length; i++) {
           $('<option />', { value: Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIItems[i].Clave, text:    Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIItems[i].Nombre }).appendTo(Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIDropdown);
       }
    }
    return Detalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIDropdown;
}


function GetInsertDetalle_de_Servicio_de_Apoyo_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoDropDown()).addClass('Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio Tipo_de_Servicio').attr('id', 'Detalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_' + index).attr('data-field', 'Tipo_de_Servicio').after($.parseHTML(addNew('Detalle_de_Servicio_de_Apoyo_MPI', 'Tipo_de_Servicio_de_Apoyo', 'Tipo_de_Servicio', 264220)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Servicio_de_Apoyo_MPI_Dictamen Dictamen').attr('id', 'Detalle_de_Servicio_de_Apoyo_MPI_Dictamen_' + index).attr('data-field', 'Dictamen');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Servicio_de_Apoyo_MPI_Responsable Responsable').attr('id', 'Detalle_de_Servicio_de_Apoyo_MPI_Responsable_' + index).attr('data-field', 'Responsable');
    columnData[3] = $(GetDetalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIDropDown()).addClass('Detalle_de_Servicio_de_Apoyo_MPI_Victima Victima').attr('id', 'Detalle_de_Servicio_de_Apoyo_MPI_Victima_' + index).attr('data-field', 'Victima').after($.parseHTML(addNew('Detalle_de_Servicio_de_Apoyo_MPI', 'Solicitante_MPI', 'Victima', 264223)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_Servicio_de_Apoyo_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Servicio_de_Apoyo_MPI("Detalle_de_Servicio_de_Apoyo_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_Servicio_de_Apoyo_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Servicio_de_Apoyo_MPI';
    var prevData = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Servicio:  data.childNodes[counter++].childNodes[0].value
        ,Dictamen:  data.childNodes[counter++].childNodes[0].value
        ,Responsable:  data.childNodes[counter++].childNodes[0].value
        ,Victima:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Servicio_de_Apoyo_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Servicio_de_Apoyo_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Servicio_de_Apoyo_MPITable.fnPageChange(iPage);
    Detalle_de_Servicio_de_Apoyo_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Servicio_de_Apoyo_MPI("Detalle_de_Servicio_de_Apoyo_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_Servicio_de_Apoyo_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Servicio_de_Apoyo_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Servicio_de_Apoyo_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Servicio_de_Apoyo_MPIGrid(Detalle_de_Servicio_de_Apoyo_MPITable.fnGetData());
    Detalle_de_Servicio_de_Apoyo_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Servicio_de_Apoyo_MPIFromDataTable() {
    var Detalle_de_Servicio_de_Apoyo_MPIData = [];
    var gridData = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Servicio_de_Apoyo_MPIData.push({
                Clave: gridData[i].Clave

                ,Tipo_de_Servicio: gridData[i].Tipo_de_Servicio
                ,Dictamen: gridData[i].Dictamen
                ,Responsable: gridData[i].Responsable
                ,Victima: gridData[i].Victima

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Servicio_de_Apoyo_MPIData.length; i++) {
        if (removedDetalle_de_Servicio_de_Apoyo_MPIData[i] != null && removedDetalle_de_Servicio_de_Apoyo_MPIData[i].Clave > 0)
            Detalle_de_Servicio_de_Apoyo_MPIData.push({
                Clave: removedDetalle_de_Servicio_de_Apoyo_MPIData[i].Clave

                ,Tipo_de_Servicio: removedDetalle_de_Servicio_de_Apoyo_MPIData[i].Tipo_de_Servicio
                ,Dictamen: removedDetalle_de_Servicio_de_Apoyo_MPIData[i].Dictamen
                ,Responsable: removedDetalle_de_Servicio_de_Apoyo_MPIData[i].Responsable
                ,Victima: removedDetalle_de_Servicio_de_Apoyo_MPIData[i].Victima

                , Removed: true
            });
    }	

    return Detalle_de_Servicio_de_Apoyo_MPIData;
}

function Detalle_de_Servicio_de_Apoyo_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Servicio_de_Apoyo_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Servicio_de_Apoyo_MPIcountRowsChecked++;
    var Detalle_de_Servicio_de_Apoyo_MPIRowElement = "Detalle_de_Servicio_de_Apoyo_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Servicio_de_Apoyo_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Servicio_de_Apoyo_MPIGetUpdateRowControls(prevData, "Detalle_de_Servicio_de_Apoyo_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Servicio_de_Apoyo_MPIRowElement + "')){ Detalle_de_Servicio_de_Apoyo_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Servicio_de_Apoyo_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Servicio_de_Apoyo_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Servicio_de_Apoyo_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Servicio_de_Apoyo_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_Servicio_de_Apoyo_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Servicio_de_Apoyo_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Servicio_de_Apoyo_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetData().length;
    Detalle_de_Servicio_de_Apoyo_MPIfnClickAddRow();
    GetAddDetalle_de_Servicio_de_Apoyo_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_Servicio_de_Apoyo_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Servicio_de_Apoyo_MPIRowElement = "Detalle_de_Servicio_de_Apoyo_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Servicio_de_Apoyo_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Servicio_de_Apoyo_MPITipo_de_Servicio').val(prevData.Tipo_de_Servicio);
    $('#Detalle_de_Servicio_de_Apoyo_MPIDictamen').val(prevData.Dictamen);
    $('#Detalle_de_Servicio_de_Apoyo_MPIResponsable').val(prevData.Responsable);
    $('#Detalle_de_Servicio_de_Apoyo_MPIVictima').val(prevData.Victima);

    initiateUIControls();






}

function Detalle_de_Servicio_de_Apoyo_MPIAddInsertRow() {
    if (Detalle_de_Servicio_de_Apoyo_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_Servicio_de_Apoyo_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Tipo_de_Servicio: ""
        ,Dictamen: ""
        ,Responsable: ""
        ,Victima: ""

    }
}

function Detalle_de_Servicio_de_Apoyo_MPIfnClickAddRow() {
    Detalle_de_Servicio_de_Apoyo_MPIcountRowsChecked++;
    Detalle_de_Servicio_de_Apoyo_MPITable.fnAddData(Detalle_de_Servicio_de_Apoyo_MPIAddInsertRow(), true);
    Detalle_de_Servicio_de_Apoyo_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Servicio_de_Apoyo_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Servicio_de_Apoyo_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_Servicio_de_Apoyo_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Servicio_de_Apoyo_MPI("Detalle_de_Servicio_de_Apoyo_MPI_", "_" + Detalle_de_Servicio_de_Apoyo_MPIinsertRowCurrentIndex);
}

function Detalle_de_Servicio_de_Apoyo_MPIClearGridData() {
    Detalle_de_Servicio_de_Apoyo_MPIData = [];
    Detalle_de_Servicio_de_Apoyo_MPIdeletedItem = [];
    Detalle_de_Servicio_de_Apoyo_MPIDataMain = [];
    Detalle_de_Servicio_de_Apoyo_MPIDataMainPages = [];
    Detalle_de_Servicio_de_Apoyo_MPInewItemCount = 0;
    Detalle_de_Servicio_de_Apoyo_MPImaxItemIndex = 0;
    $("#Detalle_de_Servicio_de_Apoyo_MPIGrid").DataTable().clear();
    $("#Detalle_de_Servicio_de_Apoyo_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Servicio_de_Apoyo_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Servicio_de_Apoyo_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Servicio_de_Apoyo_MPIData[i].Clave);

        form_data.append('[' + i + '].Tipo_de_Servicio', Detalle_de_Servicio_de_Apoyo_MPIData[i].Tipo_de_Servicio);
        form_data.append('[' + i + '].Dictamen', Detalle_de_Servicio_de_Apoyo_MPIData[i].Dictamen);
        form_data.append('[' + i + '].Responsable', Detalle_de_Servicio_de_Apoyo_MPIData[i].Responsable);
        form_data.append('[' + i + '].Victima', Detalle_de_Servicio_de_Apoyo_MPIData[i].Victima);

        form_data.append('[' + i + '].Removed', Detalle_de_Servicio_de_Apoyo_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Servicio_de_Apoyo_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Servicio_de_Apoyo_MPI("Detalle_de_Servicio_de_Apoyo_MPITable", rowIndex)) {
    var prevData = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Servicio_de_Apoyo_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Tipo_de_Servicio: $('#Detalle_de_Servicio_de_Apoyo_MPITipo_de_Servicio').val()
        ,Dictamen: $('#Detalle_de_Servicio_de_Apoyo_MPIDictamen').val()
        ,Responsable: $('#Detalle_de_Servicio_de_Apoyo_MPIResponsable').val()
        ,Victima: $('#Detalle_de_Servicio_de_Apoyo_MPIVictima').val()

    }

    Detalle_de_Servicio_de_Apoyo_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Servicio_de_Apoyo_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Servicio_de_Apoyo_MPI-form').modal({ show: false });
    $('#AddDetalle_de_Servicio_de_Apoyo_MPI-form').modal('hide');
    Detalle_de_Servicio_de_Apoyo_MPIEditRow(rowIndex);
    Detalle_de_Servicio_de_Apoyo_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_Servicio_de_Apoyo_MPIRemoveAddRow(rowIndex) {
    Detalle_de_Servicio_de_Apoyo_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Servicio_de_Apoyo_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Datos_del_Testigo_MPI MultiRow
var Detalle_de_Datos_del_Testigo_MPIcountRowsChecked = 0;







function GetDetalle_de_Datos_del_Testigo_MPI_GeneroName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_GeneroItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_GeneroItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_GeneroDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_GeneroDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_GeneroItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_GeneroItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_GeneroDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_GeneroDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_Estado_CivilDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Estado_CivilDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Estado_CivilDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_Estado_CivilDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropdown;
}

function GetDetalle_de_Datos_del_Testigo_MPI_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_NacionalidadDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_NacionalidadDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_de_Datos_del_Testigo_MPI_NacionalidadDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_NacionalidadDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_EscolaridadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_EscolaridadDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_EscolaridadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_EscolaridadDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_EscolaridadDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_EscolaridadDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_OcupacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_OcupacionItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_OcupacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_OcupacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_OcupacionDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_OcupacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_OcupacionDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_OcupacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_OcupacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_OcupacionItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_OcupacionItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_OcupacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_OcupacionDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_PaisItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_PaisDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_PaisDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_PaisDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_EstadoDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_MunicipioDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_ColoniaDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown;
}















function GetDetalle_de_Datos_del_Testigo_MPI_GeneroName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_GeneroItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_GeneroItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_GeneroDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_GeneroDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_GeneroItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_GeneroItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_GeneroDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_GeneroDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_Estado_CivilDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Estado_CivilDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Estado_CivilDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_Estado_CivilDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropdown;
}

function GetDetalle_de_Datos_del_Testigo_MPI_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_NacionalidadDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_NacionalidadDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_de_Datos_del_Testigo_MPI_NacionalidadDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_NacionalidadDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_EscolaridadName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_EscolaridadDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_EscolaridadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_EscolaridadDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_EscolaridadItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_EscolaridadDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_EscolaridadDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_OcupacionName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_OcupacionItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_OcupacionItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_OcupacionItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_OcupacionDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_OcupacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_OcupacionDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_OcupacionItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_OcupacionItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_OcupacionItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_OcupacionItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_OcupacionDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_OcupacionDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_PaisItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_PaisDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_PaisDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_PaisDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_EstadoDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_MunicipioDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_ColoniaDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown;
}








function GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteDropdown;
}


function GetDetalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoDropdown;
}


function GetDetalle_de_Datos_del_Testigo_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_PaisItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_PaisDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_PaisDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_PaisItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_PaisDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_PaisDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_EstadoItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_EstadoDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_EstadoDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_MunicipioItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_MunicipioDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_MunicipioDropdown;
}
function GetDetalle_de_Datos_del_Testigo_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_ColoniaItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_ColoniaDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_ColoniaDropdown;
}








function GetDetalle_de_Datos_del_Testigo_MPI_Lugar_TipoName(Id) {
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoItems.length; i++) {
        if (Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoItems[i].Clave == Id) {
            return Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Datos_del_Testigo_MPI_Lugar_TipoDropDown() {
    var Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Datos_del_Testigo_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoDropdown);
    if(Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoItems != null)
    {
       for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoItems.length; i++) {
           $('<option />', { value: Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoItems[i].Clave, text:    Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoItems[i].Descripcion }).appendTo(Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoDropdown);
       }
    }
    return Detalle_de_Datos_del_Testigo_MPI_Lugar_TipoDropdown;
}



function GetInsertDetalle_de_Datos_del_Testigo_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Nombre Nombre').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Nombre_' + index).attr('data-field', 'Nombre');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Apellido_Paterno Apellido_Paterno').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Apellido_Paterno_' + index).attr('data-field', 'Apellido_Paterno');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Apellido_Materno Apellido_Materno').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Apellido_Materno_' + index).attr('data-field', 'Apellido_Materno');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Nombre_Completo Nombre_Completo').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Nombre_Completo_' + index).attr('data-field', 'Nombre_Completo');
    columnData[4] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_del_Testigo_MPI_Fecha_de_Nacimiento Fecha_de_Nacimiento').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Fecha_de_Nacimiento_' + index).attr('data-field', 'Fecha_de_Nacimiento');
    columnData[5] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Testigo_MPI_Edad Edad').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Edad_' + index).attr('data-field', 'Edad');
    columnData[6] = $(GetDetalle_de_Datos_del_Testigo_MPI_GeneroDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Sexo Sexo').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Sexo_' + index).attr('data-field', 'Sexo').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Genero', 'Sexo', 264385)));
    columnData[7] = $(GetDetalle_de_Datos_del_Testigo_MPI_Estado_CivilDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Estado_Civil Estado_Civil').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Estado_Civil_' + index).attr('data-field', 'Estado_Civil').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Estado_Civil', 'Estado_Civil', 264386)));
    columnData[8] = $(GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Tipo_de_Identificacion Tipo_de_Identificacion').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Tipo_de_Identificacion_' + index).attr('data-field', 'Tipo_de_Identificacion').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion', 264387)));
    columnData[9] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Numero_de_Identificacion Numero_de_Identificacion').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Numero_de_Identificacion_' + index).attr('data-field', 'Numero_de_Identificacion');
    columnData[10] = $(GetDetalle_de_Datos_del_Testigo_MPI_NacionalidadDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Nacionalidad Nacionalidad').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Nacionalidad_' + index).attr('data-field', 'Nacionalidad').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Nacionalidad', 'Nacionalidad', 264389)));
    columnData[11] = $(GetDetalle_de_Datos_del_Testigo_MPI_EscolaridadDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Escolaridad Escolaridad').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Escolaridad_' + index).attr('data-field', 'Escolaridad').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Escolaridad', 'Escolaridad', 264390)));
    columnData[12] = $(GetDetalle_de_Datos_del_Testigo_MPI_OcupacionDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Ocupacion Ocupacion').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Ocupacion_' + index).attr('data-field', 'Ocupacion').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Ocupacion', 'Ocupacion', 264391)));
    columnData[13] = $(GetDetalle_de_Datos_del_Testigo_MPI_PaisDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Pais Pais').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Pais_' + index).attr('data-field', 'Pais').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Pais', 'Pais', 264392)));
    columnData[14] = $(GetDetalle_de_Datos_del_Testigo_MPI_EstadoDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Estado Estado').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Estado_' + index).attr('data-field', 'Estado').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Estado', 'Estado', 264393)));
    columnData[15] = $(GetDetalle_de_Datos_del_Testigo_MPI_MunicipioDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Municipio Municipio').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Municipio_' + index).attr('data-field', 'Municipio').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Municipio', 'Municipio', 264394)));
    columnData[16] = $(GetDetalle_de_Datos_del_Testigo_MPI_ColoniaDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Colonia Colonia').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Colonia_' + index).attr('data-field', 'Colonia').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Colonia', 'Colonia', 264395)));
    columnData[17] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Testigo_MPI_Codigo_Postal Codigo_Postal').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Codigo_Postal_' + index).attr('data-field', 'Codigo_Postal');
    columnData[18] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Calle Calle').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Calle_' + index).attr('data-field', 'Calle');
    columnData[19] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Numero_Exterior Numero_Exterior').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Numero_Exterior_' + index).attr('data-field', 'Numero_Exterior');
    columnData[20] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Numero_Interior Numero_Interior').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Numero_Interior_' + index).attr('data-field', 'Numero_Interior');
    columnData[21] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Telefono Telefono').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Telefono_' + index).attr('data-field', 'Telefono');
    columnData[22] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Testigo_MPI_Extencion Extencion').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Extencion_' + index).attr('data-field', 'Extencion');
    columnData[23] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Celular Celular').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Celular_' + index).attr('data-field', 'Celular');
    columnData[24] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Correo_Electronico Correo_Electronico').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Correo_Electronico_' + index).attr('data-field', 'Correo_Electronico');
    columnData[25] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Testigo_MPI_Incapaz Incapaz').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Incapaz_' + index).attr('data-field', 'Incapaz');
    columnData[26] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Nombre_del_Tutor Nombre_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Nombre_del_Tutor_' + index).attr('data-field', 'Nombre_del_Tutor');
    columnData[27] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Apellido_Paterno_del_Tutor Apellido_Paterno_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Apellido_Paterno_del_Tutor_' + index).attr('data-field', 'Apellido_Paterno_del_Tutor');
    columnData[28] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Apellido_Materno_del_Tutor Apellido_Materno_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Apellido_Materno_del_Tutor_' + index).attr('data-field', 'Apellido_Materno_del_Tutor');
    columnData[29] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Nombre_Completo_del_Tutor Nombre_Completo_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Nombre_Completo_del_Tutor_' + index).attr('data-field', 'Nombre_Completo_del_Tutor');
    columnData[30] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_del_Testigo_MPI_Fecha_de_Nacimento_del_Tutor Fecha_de_Nacimento_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Fecha_de_Nacimento_del_Tutor_' + index).attr('data-field', 'Fecha_de_Nacimento_del_Tutor');
    columnData[31] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Testigo_MPI_Edad_del_Tutor Edad_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Edad_del_Tutor_' + index).attr('data-field', 'Edad_del_Tutor');
    columnData[32] = $(GetDetalle_de_Datos_del_Testigo_MPI_GeneroDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Sexo_del_Tutor Sexo_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Sexo_del_Tutor_' + index).attr('data-field', 'Sexo_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Genero', 'Sexo_del_Tutor', 264411)));
    columnData[33] = $(GetDetalle_de_Datos_del_Testigo_MPI_Estado_CivilDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Estado_Civil_del_Tutor Estado_Civil_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Estado_Civil_del_Tutor_' + index).attr('data-field', 'Estado_Civil_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Estado_Civil', 'Estado_Civil_del_Tutor', 264412)));
    columnData[34] = $(GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Tipo_de_Identificacion_del_Tutor Tipo_de_Identificacion_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Tipo_de_Identificacion_del_Tutor_' + index).attr('data-field', 'Tipo_de_Identificacion_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion_del_Tutor', 264413)));
    columnData[35] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Numero_de_Identificacion_del_Tutor Numero_de_Identificacion_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Numero_de_Identificacion_del_Tutor_' + index).attr('data-field', 'Numero_de_Identificacion_del_Tutor');
    columnData[36] = $(GetDetalle_de_Datos_del_Testigo_MPI_NacionalidadDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Nacionalidad_del_Tutor Nacionalidad_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Nacionalidad_del_Tutor_' + index).attr('data-field', 'Nacionalidad_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Nacionalidad', 'Nacionalidad_del_Tutor', 264415)));
    columnData[37] = $(GetDetalle_de_Datos_del_Testigo_MPI_EscolaridadDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Escolaridad_del_Tutor Escolaridad_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Escolaridad_del_Tutor_' + index).attr('data-field', 'Escolaridad_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Escolaridad', 'Escolaridad_del_Tutor', 264416)));
    columnData[38] = $(GetDetalle_de_Datos_del_Testigo_MPI_OcupacionDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Ocupacion_del_Tutor Ocupacion_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Ocupacion_del_Tutor_' + index).attr('data-field', 'Ocupacion_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Ocupacion', 'Ocupacion_del_Tutor', 264417)));
    columnData[39] = $(GetDetalle_de_Datos_del_Testigo_MPI_PaisDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Pais_del_Tutor Pais_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Pais_del_Tutor_' + index).attr('data-field', 'Pais_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Pais', 'Pais_del_Tutor', 264418)));
    columnData[40] = $(GetDetalle_de_Datos_del_Testigo_MPI_EstadoDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Estado_del_Tutor Estado_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Estado_del_Tutor_' + index).attr('data-field', 'Estado_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Estado', 'Estado_del_Tutor', 264419)));
    columnData[41] = $(GetDetalle_de_Datos_del_Testigo_MPI_MunicipioDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Municipio_del_Tutor Municipio_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Municipio_del_Tutor_' + index).attr('data-field', 'Municipio_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Municipio', 'Municipio_del_Tutor', 264420)));
    columnData[42] = $(GetDetalle_de_Datos_del_Testigo_MPI_ColoniaDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Colonia_del_Tutor Colonia_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Colonia_del_Tutor_' + index).attr('data-field', 'Colonia_del_Tutor').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Colonia', 'Colonia_del_Tutor', 264421)));
    columnData[43] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Testigo_MPI_Codigo_Postal_del_Tutor Codigo_Postal_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Codigo_Postal_del_Tutor_' + index).attr('data-field', 'Codigo_Postal_del_Tutor');
    columnData[44] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Calle_del_Tutor Calle_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Calle_del_Tutor_' + index).attr('data-field', 'Calle_del_Tutor');
    columnData[45] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Numero_Exterior_del_Tutor Numero_Exterior_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Numero_Exterior_del_Tutor_' + index).attr('data-field', 'Numero_Exterior_del_Tutor');
    columnData[46] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Numero_Interior_del_Tutor Numero_Interior_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Numero_Interior_del_Tutor_' + index).attr('data-field', 'Numero_Interior_del_Tutor');
    columnData[47] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Telefono_del_Tutor Telefono_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Telefono_del_Tutor_' + index).attr('data-field', 'Telefono_del_Tutor');
    columnData[48] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Testigo_MPI_Extencion_del_Tutor Extencion_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Extencion_del_Tutor_' + index).attr('data-field', 'Extencion_del_Tutor');
    columnData[49] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Celular_del_Tutor Celular_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Celular_del_Tutor_' + index).attr('data-field', 'Celular_del_Tutor');
    columnData[50] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Correo_Electronico_del_Tutor Correo_Electronico_del_Tutor').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Correo_Electronico_del_Tutor_' + index).attr('data-field', 'Correo_Electronico_del_Tutor');
    columnData[51] = $(GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Tipo_de_Compareciente Tipo_de_Compareciente').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Tipo_de_Compareciente_' + index).attr('data-field', 'Tipo_de_Compareciente').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Tipo_de_Compareciente', 'Tipo_de_Compareciente', 264430)));
    columnData[52] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Narrativa_del_Testigo Narrativa_del_Testigo').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Narrativa_del_Testigo_' + index).attr('data-field', 'Narrativa_del_Testigo');
    columnData[53] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Titulo_del_Hecho Titulo_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Titulo_del_Hecho_' + index).attr('data-field', 'Titulo_del_Hecho');
    columnData[54] = $(GetDetalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_Hecho Prioridad_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Prioridad_del_Hecho_' + index).attr('data-field', 'Prioridad_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Prioridad_del_Hecho', 'Prioridad_del_Hecho', 264433)));
    columnData[55] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Datos_del_Testigo_MPI_Fecha_del_Hecho Fecha_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Fecha_del_Hecho_' + index).attr('data-field', 'Fecha_del_Hecho');
    columnData[56] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Datos_del_Testigo_MPI_Hora_Aproximada_del_Hecho Hora_Aproximada_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Hora_Aproximada_del_Hecho_' + index).attr('data-field', 'Hora_Aproximada_del_Hecho');
    columnData[57] = $(GetDetalle_de_Datos_del_Testigo_MPI_PaisDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Pais_del_Hecho Pais_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Pais_del_Hecho_' + index).attr('data-field', 'Pais_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Pais', 'Pais_del_Hecho', 264436)));
    columnData[58] = $(GetDetalle_de_Datos_del_Testigo_MPI_EstadoDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Estado_del_Hecho Estado_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Estado_del_Hecho_' + index).attr('data-field', 'Estado_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Estado', 'Estado_del_Hecho', 264437)));
    columnData[59] = $(GetDetalle_de_Datos_del_Testigo_MPI_MunicipioDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Municipio_del_Hecho Municipio_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Municipio_del_Hecho_' + index).attr('data-field', 'Municipio_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Municipio', 'Municipio_del_Hecho', 264438)));
    columnData[60] = $(GetDetalle_de_Datos_del_Testigo_MPI_ColoniaDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Colonia_del_Hecho Colonia_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Colonia_del_Hecho_' + index).attr('data-field', 'Colonia_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Colonia', 'Colonia_del_Hecho', 264439)));
    columnData[61] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Datos_del_Testigo_MPI_Codigo_Postal_del_Hecho Codigo_Postal_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Codigo_Postal_del_Hecho_' + index).attr('data-field', 'Codigo_Postal_del_Hecho');
    columnData[62] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Calle_del_Hecho Calle_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Calle_del_Hecho_' + index).attr('data-field', 'Calle_del_Hecho');
    columnData[63] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Entre_Calle_del_Hecho Entre_Calle_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Entre_Calle_del_Hecho_' + index).attr('data-field', 'Entre_Calle_del_Hecho');
    columnData[64] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Y_Calle_del_Hecho Y_Calle_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Y_Calle_del_Hecho_' + index).attr('data-field', 'Y_Calle_del_Hecho');
    columnData[65] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Numero_Exterior_del_Hecho Numero_Exterior_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Numero_Exterior_del_Hecho_' + index).attr('data-field', 'Numero_Exterior_del_Hecho');
    columnData[66] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Numero_Interior_del_Hecho Numero_Interior_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Numero_Interior_del_Hecho_' + index).attr('data-field', 'Numero_Interior_del_Hecho');
    columnData[67] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Latitud_del_Hecho Latitud_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Latitud_del_Hecho_' + index).attr('data-field', 'Latitud_del_Hecho');
    columnData[68] = $($.parseHTML(inputData)).addClass('Detalle_de_Datos_del_Testigo_MPI_Longitud_del_Hecho Longitud_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Longitud_del_Hecho_' + index).attr('data-field', 'Longitud_del_Hecho');
    columnData[69] = $(GetDetalle_de_Datos_del_Testigo_MPI_Lugar_TipoDropDown()).addClass('Detalle_de_Datos_del_Testigo_MPI_Tipo_del_Lugar_del_Hecho Tipo_del_Lugar_del_Hecho').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Tipo_del_Lugar_del_Hecho_' + index).attr('data-field', 'Tipo_del_Lugar_del_Hecho').after($.parseHTML(addNew('Detalle_de_Datos_del_Testigo_MPI', 'Lugar_Tipo', 'Tipo_del_Lugar_del_Hecho', 264448)));
    columnData[70] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_de_Datos_del_Testigo_MPI_Proteccion_de_Datos Proteccion_de_Datos').attr('id', 'Detalle_de_Datos_del_Testigo_MPI_Proteccion_de_Datos_' + index).attr('data-field', 'Proteccion_de_Datos');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Datos_del_Testigo_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_del_Testigo_MPI("Detalle_de_Datos_del_Testigo_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_Datos_del_Testigo_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Datos_del_Testigo_MPI';
    var prevData = Detalle_de_Datos_del_Testigo_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Testigo_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_Completo:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Nacimiento:  data.childNodes[counter++].childNodes[0].value
        ,Edad: data.childNodes[counter++].childNodes[0].value
        ,Sexo:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad:  data.childNodes[counter++].childNodes[0].value
        ,Escolaridad:  data.childNodes[counter++].childNodes[0].value
        ,Ocupacion:  data.childNodes[counter++].childNodes[0].value
        ,Pais:  data.childNodes[counter++].childNodes[0].value
        ,Estado:  data.childNodes[counter++].childNodes[0].value
        ,Municipio:  data.childNodes[counter++].childNodes[0].value
        ,Colonia:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal: data.childNodes[counter++].childNodes[0].value
        ,Calle:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior:  data.childNodes[counter++].childNodes[0].value
        ,Telefono:  data.childNodes[counter++].childNodes[0].value
        ,Extencion: data.childNodes[counter++].childNodes[0].value
        ,Celular:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico:  data.childNodes[counter++].childNodes[0].value
        ,Incapaz: $(data.childNodes[counter++].childNodes[2]).is(':checked')
        ,Nombre_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_Completo_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Nacimento_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Edad_del_Tutor: data.childNodes[counter++].childNodes[0].value
        ,Sexo_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Escolaridad_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Ocupacion_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Pais_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Estado_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Municipio_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Colonia_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal_del_Tutor: data.childNodes[counter++].childNodes[0].value
        ,Calle_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Telefono_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Extencion_del_Tutor: data.childNodes[counter++].childNodes[0].value
        ,Celular_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico_del_Tutor:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Compareciente:  data.childNodes[counter++].childNodes[0].value
        ,Narrativa_del_Testigo:  data.childNodes[counter++].childNodes[0].value
        ,Titulo_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Prioridad_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Hora_Aproximada_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Pais_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Estado_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Municipio_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Colonia_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal_del_Hecho: data.childNodes[counter++].childNodes[0].value
        ,Calle_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Entre_Calle_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Y_Calle_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Latitud_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Longitud_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_del_Lugar_del_Hecho:  data.childNodes[counter++].childNodes[0].value
        ,Proteccion_de_Datos: $(data.childNodes[counter++].childNodes[2]).is(':checked')

    }
    Detalle_de_Datos_del_Testigo_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Datos_del_Testigo_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Datos_del_Testigo_MPITable.fnPageChange(iPage);
    Detalle_de_Datos_del_Testigo_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Datos_del_Testigo_MPI("Detalle_de_Datos_del_Testigo_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_Datos_del_Testigo_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_Datos_del_Testigo_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Testigo_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Datos_del_Testigo_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Datos_del_Testigo_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Datos_del_Testigo_MPIGrid(Detalle_de_Datos_del_Testigo_MPITable.fnGetData());
    Detalle_de_Datos_del_Testigo_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Datos_del_Testigo_MPIFromDataTable() {
    var Detalle_de_Datos_del_Testigo_MPIData = [];
    var gridData = Detalle_de_Datos_del_Testigo_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Datos_del_Testigo_MPIData.push({
                Clave: gridData[i].Clave

                ,Nombre: gridData[i].Nombre
                ,Apellido_Paterno: gridData[i].Apellido_Paterno
                ,Apellido_Materno: gridData[i].Apellido_Materno
                ,Nombre_Completo: gridData[i].Nombre_Completo
                ,Fecha_de_Nacimiento: gridData[i].Fecha_de_Nacimiento
                ,Edad: gridData[i].Edad
                ,Sexo: gridData[i].Sexo
                ,Estado_Civil: gridData[i].Estado_Civil
                ,Tipo_de_Identificacion: gridData[i].Tipo_de_Identificacion
                ,Numero_de_Identificacion: gridData[i].Numero_de_Identificacion
                ,Nacionalidad: gridData[i].Nacionalidad
                ,Escolaridad: gridData[i].Escolaridad
                ,Ocupacion: gridData[i].Ocupacion
                ,Pais: gridData[i].Pais
                ,Estado: gridData[i].Estado
                ,Municipio: gridData[i].Municipio
                ,Colonia: gridData[i].Colonia
                ,Codigo_Postal: gridData[i].Codigo_Postal
                ,Calle: gridData[i].Calle
                ,Numero_Exterior: gridData[i].Numero_Exterior
                ,Numero_Interior: gridData[i].Numero_Interior
                ,Telefono: gridData[i].Telefono
                ,Extencion: gridData[i].Extencion
                ,Celular: gridData[i].Celular
                ,Correo_Electronico: gridData[i].Correo_Electronico
                ,Incapaz: gridData[i].Incapaz
                ,Nombre_del_Tutor: gridData[i].Nombre_del_Tutor
                ,Apellido_Paterno_del_Tutor: gridData[i].Apellido_Paterno_del_Tutor
                ,Apellido_Materno_del_Tutor: gridData[i].Apellido_Materno_del_Tutor
                ,Nombre_Completo_del_Tutor: gridData[i].Nombre_Completo_del_Tutor
                ,Fecha_de_Nacimento_del_Tutor: gridData[i].Fecha_de_Nacimento_del_Tutor
                ,Edad_del_Tutor: gridData[i].Edad_del_Tutor
                ,Sexo_del_Tutor: gridData[i].Sexo_del_Tutor
                ,Estado_Civil_del_Tutor: gridData[i].Estado_Civil_del_Tutor
                ,Tipo_de_Identificacion_del_Tutor: gridData[i].Tipo_de_Identificacion_del_Tutor
                ,Numero_de_Identificacion_del_Tutor: gridData[i].Numero_de_Identificacion_del_Tutor
                ,Nacionalidad_del_Tutor: gridData[i].Nacionalidad_del_Tutor
                ,Escolaridad_del_Tutor: gridData[i].Escolaridad_del_Tutor
                ,Ocupacion_del_Tutor: gridData[i].Ocupacion_del_Tutor
                ,Pais_del_Tutor: gridData[i].Pais_del_Tutor
                ,Estado_del_Tutor: gridData[i].Estado_del_Tutor
                ,Municipio_del_Tutor: gridData[i].Municipio_del_Tutor
                ,Colonia_del_Tutor: gridData[i].Colonia_del_Tutor
                ,Codigo_Postal_del_Tutor: gridData[i].Codigo_Postal_del_Tutor
                ,Calle_del_Tutor: gridData[i].Calle_del_Tutor
                ,Numero_Exterior_del_Tutor: gridData[i].Numero_Exterior_del_Tutor
                ,Numero_Interior_del_Tutor: gridData[i].Numero_Interior_del_Tutor
                ,Telefono_del_Tutor: gridData[i].Telefono_del_Tutor
                ,Extencion_del_Tutor: gridData[i].Extencion_del_Tutor
                ,Celular_del_Tutor: gridData[i].Celular_del_Tutor
                ,Correo_Electronico_del_Tutor: gridData[i].Correo_Electronico_del_Tutor
                ,Tipo_de_Compareciente: gridData[i].Tipo_de_Compareciente
                ,Narrativa_del_Testigo: gridData[i].Narrativa_del_Testigo
                ,Titulo_del_Hecho: gridData[i].Titulo_del_Hecho
                ,Prioridad_del_Hecho: gridData[i].Prioridad_del_Hecho
                ,Fecha_del_Hecho: gridData[i].Fecha_del_Hecho
                ,Hora_Aproximada_del_Hecho: gridData[i].Hora_Aproximada_del_Hecho
                ,Pais_del_Hecho: gridData[i].Pais_del_Hecho
                ,Estado_del_Hecho: gridData[i].Estado_del_Hecho
                ,Municipio_del_Hecho: gridData[i].Municipio_del_Hecho
                ,Colonia_del_Hecho: gridData[i].Colonia_del_Hecho
                ,Codigo_Postal_del_Hecho: gridData[i].Codigo_Postal_del_Hecho
                ,Calle_del_Hecho: gridData[i].Calle_del_Hecho
                ,Entre_Calle_del_Hecho: gridData[i].Entre_Calle_del_Hecho
                ,Y_Calle_del_Hecho: gridData[i].Y_Calle_del_Hecho
                ,Numero_Exterior_del_Hecho: gridData[i].Numero_Exterior_del_Hecho
                ,Numero_Interior_del_Hecho: gridData[i].Numero_Interior_del_Hecho
                ,Latitud_del_Hecho: gridData[i].Latitud_del_Hecho
                ,Longitud_del_Hecho: gridData[i].Longitud_del_Hecho
                ,Tipo_del_Lugar_del_Hecho: gridData[i].Tipo_del_Lugar_del_Hecho
                ,Proteccion_de_Datos: gridData[i].Proteccion_de_Datos

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Datos_del_Testigo_MPIData.length; i++) {
        if (removedDetalle_de_Datos_del_Testigo_MPIData[i] != null && removedDetalle_de_Datos_del_Testigo_MPIData[i].Clave > 0)
            Detalle_de_Datos_del_Testigo_MPIData.push({
                Clave: removedDetalle_de_Datos_del_Testigo_MPIData[i].Clave

                ,Nombre: removedDetalle_de_Datos_del_Testigo_MPIData[i].Nombre
                ,Apellido_Paterno: removedDetalle_de_Datos_del_Testigo_MPIData[i].Apellido_Paterno
                ,Apellido_Materno: removedDetalle_de_Datos_del_Testigo_MPIData[i].Apellido_Materno
                ,Nombre_Completo: removedDetalle_de_Datos_del_Testigo_MPIData[i].Nombre_Completo
                ,Fecha_de_Nacimiento: removedDetalle_de_Datos_del_Testigo_MPIData[i].Fecha_de_Nacimiento
                ,Edad: removedDetalle_de_Datos_del_Testigo_MPIData[i].Edad
                ,Sexo: removedDetalle_de_Datos_del_Testigo_MPIData[i].Sexo
                ,Estado_Civil: removedDetalle_de_Datos_del_Testigo_MPIData[i].Estado_Civil
                ,Tipo_de_Identificacion: removedDetalle_de_Datos_del_Testigo_MPIData[i].Tipo_de_Identificacion
                ,Numero_de_Identificacion: removedDetalle_de_Datos_del_Testigo_MPIData[i].Numero_de_Identificacion
                ,Nacionalidad: removedDetalle_de_Datos_del_Testigo_MPIData[i].Nacionalidad
                ,Escolaridad: removedDetalle_de_Datos_del_Testigo_MPIData[i].Escolaridad
                ,Ocupacion: removedDetalle_de_Datos_del_Testigo_MPIData[i].Ocupacion
                ,Pais: removedDetalle_de_Datos_del_Testigo_MPIData[i].Pais
                ,Estado: removedDetalle_de_Datos_del_Testigo_MPIData[i].Estado
                ,Municipio: removedDetalle_de_Datos_del_Testigo_MPIData[i].Municipio
                ,Colonia: removedDetalle_de_Datos_del_Testigo_MPIData[i].Colonia
                ,Codigo_Postal: removedDetalle_de_Datos_del_Testigo_MPIData[i].Codigo_Postal
                ,Calle: removedDetalle_de_Datos_del_Testigo_MPIData[i].Calle
                ,Numero_Exterior: removedDetalle_de_Datos_del_Testigo_MPIData[i].Numero_Exterior
                ,Numero_Interior: removedDetalle_de_Datos_del_Testigo_MPIData[i].Numero_Interior
                ,Telefono: removedDetalle_de_Datos_del_Testigo_MPIData[i].Telefono
                ,Extencion: removedDetalle_de_Datos_del_Testigo_MPIData[i].Extencion
                ,Celular: removedDetalle_de_Datos_del_Testigo_MPIData[i].Celular
                ,Correo_Electronico: removedDetalle_de_Datos_del_Testigo_MPIData[i].Correo_Electronico
                ,Incapaz: removedDetalle_de_Datos_del_Testigo_MPIData[i].Incapaz
                ,Nombre_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Nombre_del_Tutor
                ,Apellido_Paterno_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Apellido_Paterno_del_Tutor
                ,Apellido_Materno_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Apellido_Materno_del_Tutor
                ,Nombre_Completo_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Nombre_Completo_del_Tutor
                ,Fecha_de_Nacimento_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Fecha_de_Nacimento_del_Tutor
                ,Edad_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Edad_del_Tutor
                ,Sexo_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Sexo_del_Tutor
                ,Estado_Civil_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Estado_Civil_del_Tutor
                ,Tipo_de_Identificacion_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Tipo_de_Identificacion_del_Tutor
                ,Numero_de_Identificacion_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Numero_de_Identificacion_del_Tutor
                ,Nacionalidad_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Nacionalidad_del_Tutor
                ,Escolaridad_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Escolaridad_del_Tutor
                ,Ocupacion_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Ocupacion_del_Tutor
                ,Pais_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Pais_del_Tutor
                ,Estado_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Estado_del_Tutor
                ,Municipio_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Municipio_del_Tutor
                ,Colonia_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Colonia_del_Tutor
                ,Codigo_Postal_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Codigo_Postal_del_Tutor
                ,Calle_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Calle_del_Tutor
                ,Numero_Exterior_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Numero_Exterior_del_Tutor
                ,Numero_Interior_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Numero_Interior_del_Tutor
                ,Telefono_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Telefono_del_Tutor
                ,Extencion_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Extencion_del_Tutor
                ,Celular_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Celular_del_Tutor
                ,Correo_Electronico_del_Tutor: removedDetalle_de_Datos_del_Testigo_MPIData[i].Correo_Electronico_del_Tutor
                ,Tipo_de_Compareciente: removedDetalle_de_Datos_del_Testigo_MPIData[i].Tipo_de_Compareciente
                ,Narrativa_del_Testigo: removedDetalle_de_Datos_del_Testigo_MPIData[i].Narrativa_del_Testigo
                ,Titulo_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Titulo_del_Hecho
                ,Prioridad_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Prioridad_del_Hecho
                ,Fecha_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Fecha_del_Hecho
                ,Hora_Aproximada_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Hora_Aproximada_del_Hecho
                ,Pais_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Pais_del_Hecho
                ,Estado_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Estado_del_Hecho
                ,Municipio_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Municipio_del_Hecho
                ,Colonia_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Colonia_del_Hecho
                ,Codigo_Postal_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Codigo_Postal_del_Hecho
                ,Calle_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Calle_del_Hecho
                ,Entre_Calle_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Entre_Calle_del_Hecho
                ,Y_Calle_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Y_Calle_del_Hecho
                ,Numero_Exterior_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Numero_Exterior_del_Hecho
                ,Numero_Interior_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Numero_Interior_del_Hecho
                ,Latitud_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Latitud_del_Hecho
                ,Longitud_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Longitud_del_Hecho
                ,Tipo_del_Lugar_del_Hecho: removedDetalle_de_Datos_del_Testigo_MPIData[i].Tipo_del_Lugar_del_Hecho
                ,Proteccion_de_Datos: removedDetalle_de_Datos_del_Testigo_MPIData[i].Proteccion_de_Datos

                , Removed: true
            });
    }	

    return Detalle_de_Datos_del_Testigo_MPIData;
}

function Detalle_de_Datos_del_Testigo_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Datos_del_Testigo_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Datos_del_Testigo_MPIcountRowsChecked++;
    var Detalle_de_Datos_del_Testigo_MPIRowElement = "Detalle_de_Datos_del_Testigo_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Datos_del_Testigo_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_Datos_del_Testigo_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Datos_del_Testigo_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Datos_del_Testigo_MPIGetUpdateRowControls(prevData, "Detalle_de_Datos_del_Testigo_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Datos_del_Testigo_MPIRowElement + "')){ Detalle_de_Datos_del_Testigo_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Datos_del_Testigo_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Datos_del_Testigo_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Datos_del_Testigo_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Datos_del_Testigo_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_Datos_del_Testigo_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Datos_del_Testigo_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Datos_del_Testigo_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Datos_del_Testigo_MPITable.fnGetData().length;
    Detalle_de_Datos_del_Testigo_MPIfnClickAddRow();
    GetAddDetalle_de_Datos_del_Testigo_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_Datos_del_Testigo_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Datos_del_Testigo_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Datos_del_Testigo_MPIRowElement = "Detalle_de_Datos_del_Testigo_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Datos_del_Testigo_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Datos_del_Testigo_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Datos_del_Testigo_MPINombre').val(prevData.Nombre);
    $('#Detalle_de_Datos_del_Testigo_MPIApellido_Paterno').val(prevData.Apellido_Paterno);
    $('#Detalle_de_Datos_del_Testigo_MPIApellido_Materno').val(prevData.Apellido_Materno);
    $('#Detalle_de_Datos_del_Testigo_MPINombre_Completo').val(prevData.Nombre_Completo);
    $('#Detalle_de_Datos_del_Testigo_MPIFecha_de_Nacimiento').val(prevData.Fecha_de_Nacimiento);
    $('#Detalle_de_Datos_del_Testigo_MPIEdad').val(prevData.Edad);
    $('#Detalle_de_Datos_del_Testigo_MPISexo').val(prevData.Sexo);
    $('#Detalle_de_Datos_del_Testigo_MPIEstado_Civil').val(prevData.Estado_Civil);
    $('#Detalle_de_Datos_del_Testigo_MPITipo_de_Identificacion').val(prevData.Tipo_de_Identificacion);
    $('#Detalle_de_Datos_del_Testigo_MPINumero_de_Identificacion').val(prevData.Numero_de_Identificacion);
    $('#Detalle_de_Datos_del_Testigo_MPINacionalidad').val(prevData.Nacionalidad);
    $('#Detalle_de_Datos_del_Testigo_MPIEscolaridad').val(prevData.Escolaridad);
    $('#Detalle_de_Datos_del_Testigo_MPIOcupacion').val(prevData.Ocupacion);
    $('#Detalle_de_Datos_del_Testigo_MPIPais').val(prevData.Pais);
    $('#Detalle_de_Datos_del_Testigo_MPIEstado').val(prevData.Estado);
    $('#Detalle_de_Datos_del_Testigo_MPIMunicipio').val(prevData.Municipio);
    $('#Detalle_de_Datos_del_Testigo_MPIColonia').val(prevData.Colonia);
    $('#Detalle_de_Datos_del_Testigo_MPICodigo_Postal').val(prevData.Codigo_Postal);
    $('#Detalle_de_Datos_del_Testigo_MPICalle').val(prevData.Calle);
    $('#Detalle_de_Datos_del_Testigo_MPINumero_Exterior').val(prevData.Numero_Exterior);
    $('#Detalle_de_Datos_del_Testigo_MPINumero_Interior').val(prevData.Numero_Interior);
    $('#Detalle_de_Datos_del_Testigo_MPITelefono').val(prevData.Telefono);
    $('#Detalle_de_Datos_del_Testigo_MPIExtencion').val(prevData.Extencion);
    $('#Detalle_de_Datos_del_Testigo_MPICelular').val(prevData.Celular);
    $('#Detalle_de_Datos_del_Testigo_MPICorreo_Electronico').val(prevData.Correo_Electronico);
    $('#Detalle_de_Datos_del_Testigo_MPIIncapaz').prop('checked', prevData.Incapaz);
    $('#Detalle_de_Datos_del_Testigo_MPINombre_del_Tutor').val(prevData.Nombre_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIApellido_Paterno_del_Tutor').val(prevData.Apellido_Paterno_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIApellido_Materno_del_Tutor').val(prevData.Apellido_Materno_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPINombre_Completo_del_Tutor').val(prevData.Nombre_Completo_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIFecha_de_Nacimento_del_Tutor').val(prevData.Fecha_de_Nacimento_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIEdad_del_Tutor').val(prevData.Edad_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPISexo_del_Tutor').val(prevData.Sexo_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIEstado_Civil_del_Tutor').val(prevData.Estado_Civil_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPITipo_de_Identificacion_del_Tutor').val(prevData.Tipo_de_Identificacion_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPINumero_de_Identificacion_del_Tutor').val(prevData.Numero_de_Identificacion_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPINacionalidad_del_Tutor').val(prevData.Nacionalidad_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIEscolaridad_del_Tutor').val(prevData.Escolaridad_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIOcupacion_del_Tutor').val(prevData.Ocupacion_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIPais_del_Tutor').val(prevData.Pais_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIEstado_del_Tutor').val(prevData.Estado_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIMunicipio_del_Tutor').val(prevData.Municipio_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIColonia_del_Tutor').val(prevData.Colonia_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPICodigo_Postal_del_Tutor').val(prevData.Codigo_Postal_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPICalle_del_Tutor').val(prevData.Calle_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPINumero_Exterior_del_Tutor').val(prevData.Numero_Exterior_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPINumero_Interior_del_Tutor').val(prevData.Numero_Interior_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPITelefono_del_Tutor').val(prevData.Telefono_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPIExtencion_del_Tutor').val(prevData.Extencion_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPICelular_del_Tutor').val(prevData.Celular_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPICorreo_Electronico_del_Tutor').val(prevData.Correo_Electronico_del_Tutor);
    $('#Detalle_de_Datos_del_Testigo_MPITipo_de_Compareciente').val(prevData.Tipo_de_Compareciente);
    $('#Detalle_de_Datos_del_Testigo_MPINarrativa_del_Testigo').val(prevData.Narrativa_del_Testigo);
    $('#Detalle_de_Datos_del_Testigo_MPITitulo_del_Hecho').val(prevData.Titulo_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPIPrioridad_del_Hecho').val(prevData.Prioridad_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPIFecha_del_Hecho').val(prevData.Fecha_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPIHora_Aproximada_del_Hecho').val(prevData.Hora_Aproximada_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPIPais_del_Hecho').val(prevData.Pais_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPIEstado_del_Hecho').val(prevData.Estado_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPIMunicipio_del_Hecho').val(prevData.Municipio_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPIColonia_del_Hecho').val(prevData.Colonia_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPICodigo_Postal_del_Hecho').val(prevData.Codigo_Postal_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPICalle_del_Hecho').val(prevData.Calle_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPIEntre_Calle_del_Hecho').val(prevData.Entre_Calle_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPIY_Calle_del_Hecho').val(prevData.Y_Calle_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPINumero_Exterior_del_Hecho').val(prevData.Numero_Exterior_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPINumero_Interior_del_Hecho').val(prevData.Numero_Interior_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPILatitud_del_Hecho').val(prevData.Latitud_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPILongitud_del_Hecho').val(prevData.Longitud_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPITipo_del_Lugar_del_Hecho').val(prevData.Tipo_del_Lugar_del_Hecho);
    $('#Detalle_de_Datos_del_Testigo_MPIProteccion_de_Datos').prop('checked', prevData.Proteccion_de_Datos);

    initiateUIControls();









































































}

function Detalle_de_Datos_del_Testigo_MPIAddInsertRow() {
    if (Detalle_de_Datos_del_Testigo_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_Datos_del_Testigo_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre: ""
        ,Apellido_Paterno: ""
        ,Apellido_Materno: ""
        ,Nombre_Completo: ""
        ,Fecha_de_Nacimiento: ""
        ,Edad: ""
        ,Sexo: ""
        ,Estado_Civil: ""
        ,Tipo_de_Identificacion: ""
        ,Numero_de_Identificacion: ""
        ,Nacionalidad: ""
        ,Escolaridad: ""
        ,Ocupacion: ""
        ,Pais: ""
        ,Estado: ""
        ,Municipio: ""
        ,Colonia: ""
        ,Codigo_Postal: ""
        ,Calle: ""
        ,Numero_Exterior: ""
        ,Numero_Interior: ""
        ,Telefono: ""
        ,Extencion: ""
        ,Celular: ""
        ,Correo_Electronico: ""
        ,Incapaz: ""
        ,Nombre_del_Tutor: ""
        ,Apellido_Paterno_del_Tutor: ""
        ,Apellido_Materno_del_Tutor: ""
        ,Nombre_Completo_del_Tutor: ""
        ,Fecha_de_Nacimento_del_Tutor: ""
        ,Edad_del_Tutor: ""
        ,Sexo_del_Tutor: ""
        ,Estado_Civil_del_Tutor: ""
        ,Tipo_de_Identificacion_del_Tutor: ""
        ,Numero_de_Identificacion_del_Tutor: ""
        ,Nacionalidad_del_Tutor: ""
        ,Escolaridad_del_Tutor: ""
        ,Ocupacion_del_Tutor: ""
        ,Pais_del_Tutor: ""
        ,Estado_del_Tutor: ""
        ,Municipio_del_Tutor: ""
        ,Colonia_del_Tutor: ""
        ,Codigo_Postal_del_Tutor: ""
        ,Calle_del_Tutor: ""
        ,Numero_Exterior_del_Tutor: ""
        ,Numero_Interior_del_Tutor: ""
        ,Telefono_del_Tutor: ""
        ,Extencion_del_Tutor: ""
        ,Celular_del_Tutor: ""
        ,Correo_Electronico_del_Tutor: ""
        ,Tipo_de_Compareciente: ""
        ,Narrativa_del_Testigo: ""
        ,Titulo_del_Hecho: ""
        ,Prioridad_del_Hecho: ""
        ,Fecha_del_Hecho: ""
        ,Hora_Aproximada_del_Hecho: ""
        ,Pais_del_Hecho: ""
        ,Estado_del_Hecho: ""
        ,Municipio_del_Hecho: ""
        ,Colonia_del_Hecho: ""
        ,Codigo_Postal_del_Hecho: ""
        ,Calle_del_Hecho: ""
        ,Entre_Calle_del_Hecho: ""
        ,Y_Calle_del_Hecho: ""
        ,Numero_Exterior_del_Hecho: ""
        ,Numero_Interior_del_Hecho: ""
        ,Latitud_del_Hecho: ""
        ,Longitud_del_Hecho: ""
        ,Tipo_del_Lugar_del_Hecho: ""
        ,Proteccion_de_Datos: ""

    }
}

function Detalle_de_Datos_del_Testigo_MPIfnClickAddRow() {
    Detalle_de_Datos_del_Testigo_MPIcountRowsChecked++;
    Detalle_de_Datos_del_Testigo_MPITable.fnAddData(Detalle_de_Datos_del_Testigo_MPIAddInsertRow(), true);
    Detalle_de_Datos_del_Testigo_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Datos_del_Testigo_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Datos_del_Testigo_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_Datos_del_Testigo_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Datos_del_Testigo_MPI("Detalle_de_Datos_del_Testigo_MPI_", "_" + Detalle_de_Datos_del_Testigo_MPIinsertRowCurrentIndex);
}

function Detalle_de_Datos_del_Testigo_MPIClearGridData() {
    Detalle_de_Datos_del_Testigo_MPIData = [];
    Detalle_de_Datos_del_Testigo_MPIdeletedItem = [];
    Detalle_de_Datos_del_Testigo_MPIDataMain = [];
    Detalle_de_Datos_del_Testigo_MPIDataMainPages = [];
    Detalle_de_Datos_del_Testigo_MPInewItemCount = 0;
    Detalle_de_Datos_del_Testigo_MPImaxItemIndex = 0;
    $("#Detalle_de_Datos_del_Testigo_MPIGrid").DataTable().clear();
    $("#Detalle_de_Datos_del_Testigo_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Datos_del_Testigo_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Datos_del_Testigo_MPIData[i].Clave);

        form_data.append('[' + i + '].Nombre', Detalle_de_Datos_del_Testigo_MPIData[i].Nombre);
        form_data.append('[' + i + '].Apellido_Paterno', Detalle_de_Datos_del_Testigo_MPIData[i].Apellido_Paterno);
        form_data.append('[' + i + '].Apellido_Materno', Detalle_de_Datos_del_Testigo_MPIData[i].Apellido_Materno);
        form_data.append('[' + i + '].Nombre_Completo', Detalle_de_Datos_del_Testigo_MPIData[i].Nombre_Completo);
        form_data.append('[' + i + '].Fecha_de_Nacimiento', Detalle_de_Datos_del_Testigo_MPIData[i].Fecha_de_Nacimiento);
        form_data.append('[' + i + '].Edad', Detalle_de_Datos_del_Testigo_MPIData[i].Edad);
        form_data.append('[' + i + '].Sexo', Detalle_de_Datos_del_Testigo_MPIData[i].Sexo);
        form_data.append('[' + i + '].Estado_Civil', Detalle_de_Datos_del_Testigo_MPIData[i].Estado_Civil);
        form_data.append('[' + i + '].Tipo_de_Identificacion', Detalle_de_Datos_del_Testigo_MPIData[i].Tipo_de_Identificacion);
        form_data.append('[' + i + '].Numero_de_Identificacion', Detalle_de_Datos_del_Testigo_MPIData[i].Numero_de_Identificacion);
        form_data.append('[' + i + '].Nacionalidad', Detalle_de_Datos_del_Testigo_MPIData[i].Nacionalidad);
        form_data.append('[' + i + '].Escolaridad', Detalle_de_Datos_del_Testigo_MPIData[i].Escolaridad);
        form_data.append('[' + i + '].Ocupacion', Detalle_de_Datos_del_Testigo_MPIData[i].Ocupacion);
        form_data.append('[' + i + '].Pais', Detalle_de_Datos_del_Testigo_MPIData[i].Pais);
        form_data.append('[' + i + '].Estado', Detalle_de_Datos_del_Testigo_MPIData[i].Estado);
        form_data.append('[' + i + '].Municipio', Detalle_de_Datos_del_Testigo_MPIData[i].Municipio);
        form_data.append('[' + i + '].Colonia', Detalle_de_Datos_del_Testigo_MPIData[i].Colonia);
        form_data.append('[' + i + '].Codigo_Postal', Detalle_de_Datos_del_Testigo_MPIData[i].Codigo_Postal);
        form_data.append('[' + i + '].Calle', Detalle_de_Datos_del_Testigo_MPIData[i].Calle);
        form_data.append('[' + i + '].Numero_Exterior', Detalle_de_Datos_del_Testigo_MPIData[i].Numero_Exterior);
        form_data.append('[' + i + '].Numero_Interior', Detalle_de_Datos_del_Testigo_MPIData[i].Numero_Interior);
        form_data.append('[' + i + '].Telefono', Detalle_de_Datos_del_Testigo_MPIData[i].Telefono);
        form_data.append('[' + i + '].Extencion', Detalle_de_Datos_del_Testigo_MPIData[i].Extencion);
        form_data.append('[' + i + '].Celular', Detalle_de_Datos_del_Testigo_MPIData[i].Celular);
        form_data.append('[' + i + '].Correo_Electronico', Detalle_de_Datos_del_Testigo_MPIData[i].Correo_Electronico);
        form_data.append('[' + i + '].Incapaz', Detalle_de_Datos_del_Testigo_MPIData[i].Incapaz);
        form_data.append('[' + i + '].Nombre_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Nombre_del_Tutor);
        form_data.append('[' + i + '].Apellido_Paterno_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Apellido_Paterno_del_Tutor);
        form_data.append('[' + i + '].Apellido_Materno_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Apellido_Materno_del_Tutor);
        form_data.append('[' + i + '].Nombre_Completo_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Nombre_Completo_del_Tutor);
        form_data.append('[' + i + '].Fecha_de_Nacimento_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Fecha_de_Nacimento_del_Tutor);
        form_data.append('[' + i + '].Edad_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Edad_del_Tutor);
        form_data.append('[' + i + '].Sexo_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Sexo_del_Tutor);
        form_data.append('[' + i + '].Estado_Civil_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Estado_Civil_del_Tutor);
        form_data.append('[' + i + '].Tipo_de_Identificacion_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Tipo_de_Identificacion_del_Tutor);
        form_data.append('[' + i + '].Numero_de_Identificacion_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Numero_de_Identificacion_del_Tutor);
        form_data.append('[' + i + '].Nacionalidad_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Nacionalidad_del_Tutor);
        form_data.append('[' + i + '].Escolaridad_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Escolaridad_del_Tutor);
        form_data.append('[' + i + '].Ocupacion_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Ocupacion_del_Tutor);
        form_data.append('[' + i + '].Pais_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Pais_del_Tutor);
        form_data.append('[' + i + '].Estado_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Estado_del_Tutor);
        form_data.append('[' + i + '].Municipio_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Municipio_del_Tutor);
        form_data.append('[' + i + '].Colonia_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Colonia_del_Tutor);
        form_data.append('[' + i + '].Codigo_Postal_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Codigo_Postal_del_Tutor);
        form_data.append('[' + i + '].Calle_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Calle_del_Tutor);
        form_data.append('[' + i + '].Numero_Exterior_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Numero_Exterior_del_Tutor);
        form_data.append('[' + i + '].Numero_Interior_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Numero_Interior_del_Tutor);
        form_data.append('[' + i + '].Telefono_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Telefono_del_Tutor);
        form_data.append('[' + i + '].Extencion_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Extencion_del_Tutor);
        form_data.append('[' + i + '].Celular_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Celular_del_Tutor);
        form_data.append('[' + i + '].Correo_Electronico_del_Tutor', Detalle_de_Datos_del_Testigo_MPIData[i].Correo_Electronico_del_Tutor);
        form_data.append('[' + i + '].Tipo_de_Compareciente', Detalle_de_Datos_del_Testigo_MPIData[i].Tipo_de_Compareciente);
        form_data.append('[' + i + '].Narrativa_del_Testigo', Detalle_de_Datos_del_Testigo_MPIData[i].Narrativa_del_Testigo);
        form_data.append('[' + i + '].Titulo_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Titulo_del_Hecho);
        form_data.append('[' + i + '].Prioridad_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Prioridad_del_Hecho);
        form_data.append('[' + i + '].Fecha_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Fecha_del_Hecho);
        form_data.append('[' + i + '].Hora_Aproximada_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Hora_Aproximada_del_Hecho);
        form_data.append('[' + i + '].Pais_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Pais_del_Hecho);
        form_data.append('[' + i + '].Estado_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Estado_del_Hecho);
        form_data.append('[' + i + '].Municipio_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Municipio_del_Hecho);
        form_data.append('[' + i + '].Colonia_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Colonia_del_Hecho);
        form_data.append('[' + i + '].Codigo_Postal_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Codigo_Postal_del_Hecho);
        form_data.append('[' + i + '].Calle_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Calle_del_Hecho);
        form_data.append('[' + i + '].Entre_Calle_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Entre_Calle_del_Hecho);
        form_data.append('[' + i + '].Y_Calle_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Y_Calle_del_Hecho);
        form_data.append('[' + i + '].Numero_Exterior_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Numero_Exterior_del_Hecho);
        form_data.append('[' + i + '].Numero_Interior_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Numero_Interior_del_Hecho);
        form_data.append('[' + i + '].Latitud_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Latitud_del_Hecho);
        form_data.append('[' + i + '].Longitud_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Longitud_del_Hecho);
        form_data.append('[' + i + '].Tipo_del_Lugar_del_Hecho', Detalle_de_Datos_del_Testigo_MPIData[i].Tipo_del_Lugar_del_Hecho);
        form_data.append('[' + i + '].Proteccion_de_Datos', Detalle_de_Datos_del_Testigo_MPIData[i].Proteccion_de_Datos);

        form_data.append('[' + i + '].Removed', Detalle_de_Datos_del_Testigo_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Datos_del_Testigo_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Datos_del_Testigo_MPI("Detalle_de_Datos_del_Testigo_MPITable", rowIndex)) {
    var prevData = Detalle_de_Datos_del_Testigo_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Datos_del_Testigo_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre: $('#Detalle_de_Datos_del_Testigo_MPINombre').val()
        ,Apellido_Paterno: $('#Detalle_de_Datos_del_Testigo_MPIApellido_Paterno').val()
        ,Apellido_Materno: $('#Detalle_de_Datos_del_Testigo_MPIApellido_Materno').val()
        ,Nombre_Completo: $('#Detalle_de_Datos_del_Testigo_MPINombre_Completo').val()
        ,Fecha_de_Nacimiento: $('#Detalle_de_Datos_del_Testigo_MPIFecha_de_Nacimiento').val()
        ,Edad: $('#Detalle_de_Datos_del_Testigo_MPIEdad').val()

        ,Sexo: $('#Detalle_de_Datos_del_Testigo_MPISexo').val()
        ,Estado_Civil: $('#Detalle_de_Datos_del_Testigo_MPIEstado_Civil').val()
        ,Tipo_de_Identificacion: $('#Detalle_de_Datos_del_Testigo_MPITipo_de_Identificacion').val()
        ,Numero_de_Identificacion: $('#Detalle_de_Datos_del_Testigo_MPINumero_de_Identificacion').val()
        ,Nacionalidad: $('#Detalle_de_Datos_del_Testigo_MPINacionalidad').val()
        ,Escolaridad: $('#Detalle_de_Datos_del_Testigo_MPIEscolaridad').val()
        ,Ocupacion: $('#Detalle_de_Datos_del_Testigo_MPIOcupacion').val()
        ,Pais: $('#Detalle_de_Datos_del_Testigo_MPIPais').val()
        ,Estado: $('#Detalle_de_Datos_del_Testigo_MPIEstado').val()
        ,Municipio: $('#Detalle_de_Datos_del_Testigo_MPIMunicipio').val()
        ,Colonia: $('#Detalle_de_Datos_del_Testigo_MPIColonia').val()
        ,Codigo_Postal: $('#Detalle_de_Datos_del_Testigo_MPICodigo_Postal').val()

        ,Calle: $('#Detalle_de_Datos_del_Testigo_MPICalle').val()
        ,Numero_Exterior: $('#Detalle_de_Datos_del_Testigo_MPINumero_Exterior').val()
        ,Numero_Interior: $('#Detalle_de_Datos_del_Testigo_MPINumero_Interior').val()
        ,Telefono: $('#Detalle_de_Datos_del_Testigo_MPITelefono').val()
        ,Extencion: $('#Detalle_de_Datos_del_Testigo_MPIExtencion').val()

        ,Celular: $('#Detalle_de_Datos_del_Testigo_MPICelular').val()
        ,Correo_Electronico: $('#Detalle_de_Datos_del_Testigo_MPICorreo_Electronico').val()
        ,Incapaz: $('#Detalle_de_Datos_del_Testigo_MPIIncapaz').is(':checked')
        ,Nombre_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPINombre_del_Tutor').val()
        ,Apellido_Paterno_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIApellido_Paterno_del_Tutor').val()
        ,Apellido_Materno_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIApellido_Materno_del_Tutor').val()
        ,Nombre_Completo_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPINombre_Completo_del_Tutor').val()
        ,Fecha_de_Nacimento_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIFecha_de_Nacimento_del_Tutor').val()
        ,Edad_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIEdad_del_Tutor').val()

        ,Sexo_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPISexo_del_Tutor').val()
        ,Estado_Civil_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIEstado_Civil_del_Tutor').val()
        ,Tipo_de_Identificacion_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPITipo_de_Identificacion_del_Tutor').val()
        ,Numero_de_Identificacion_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPINumero_de_Identificacion_del_Tutor').val()
        ,Nacionalidad_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPINacionalidad_del_Tutor').val()
        ,Escolaridad_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIEscolaridad_del_Tutor').val()
        ,Ocupacion_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIOcupacion_del_Tutor').val()
        ,Pais_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIPais_del_Tutor').val()
        ,Estado_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIEstado_del_Tutor').val()
        ,Municipio_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIMunicipio_del_Tutor').val()
        ,Colonia_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIColonia_del_Tutor').val()
        ,Codigo_Postal_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPICodigo_Postal_del_Tutor').val()

        ,Calle_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPICalle_del_Tutor').val()
        ,Numero_Exterior_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPINumero_Exterior_del_Tutor').val()
        ,Numero_Interior_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPINumero_Interior_del_Tutor').val()
        ,Telefono_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPITelefono_del_Tutor').val()
        ,Extencion_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPIExtencion_del_Tutor').val()

        ,Celular_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPICelular_del_Tutor').val()
        ,Correo_Electronico_del_Tutor: $('#Detalle_de_Datos_del_Testigo_MPICorreo_Electronico_del_Tutor').val()
        ,Tipo_de_Compareciente: $('#Detalle_de_Datos_del_Testigo_MPITipo_de_Compareciente').val()
        ,Narrativa_del_Testigo: $('#Detalle_de_Datos_del_Testigo_MPINarrativa_del_Testigo').val()
        ,Titulo_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPITitulo_del_Hecho').val()
        ,Prioridad_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPIPrioridad_del_Hecho').val()
        ,Fecha_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPIFecha_del_Hecho').val()
        ,Hora_Aproximada_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPIHora_Aproximada_del_Hecho').val()
        ,Pais_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPIPais_del_Hecho').val()
        ,Estado_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPIEstado_del_Hecho').val()
        ,Municipio_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPIMunicipio_del_Hecho').val()
        ,Colonia_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPIColonia_del_Hecho').val()
        ,Codigo_Postal_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPICodigo_Postal_del_Hecho').val()

        ,Calle_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPICalle_del_Hecho').val()
        ,Entre_Calle_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPIEntre_Calle_del_Hecho').val()
        ,Y_Calle_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPIY_Calle_del_Hecho').val()
        ,Numero_Exterior_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPINumero_Exterior_del_Hecho').val()
        ,Numero_Interior_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPINumero_Interior_del_Hecho').val()
        ,Latitud_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPILatitud_del_Hecho').val()
        ,Longitud_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPILongitud_del_Hecho').val()
        ,Tipo_del_Lugar_del_Hecho: $('#Detalle_de_Datos_del_Testigo_MPITipo_del_Lugar_del_Hecho').val()
        ,Proteccion_de_Datos: $('#Detalle_de_Datos_del_Testigo_MPIProteccion_de_Datos').is(':checked')

    }

    Detalle_de_Datos_del_Testigo_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Datos_del_Testigo_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Datos_del_Testigo_MPI-form').modal({ show: false });
    $('#AddDetalle_de_Datos_del_Testigo_MPI-form').modal('hide');
    Detalle_de_Datos_del_Testigo_MPIEditRow(rowIndex);
    Detalle_de_Datos_del_Testigo_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_Datos_del_Testigo_MPIRemoveAddRow(rowIndex) {
    Detalle_de_Datos_del_Testigo_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Datos_del_Testigo_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Agente_del_Ministerio_Publico MultiRow
var Detalle_de_Agente_del_Ministerio_PublicocountRowsChecked = 0;






function GetInsertDetalle_de_Agente_del_Ministerio_PublicoRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Agente_del_Ministerio_Publico_Agente_del_Ministerio_Publico Agente_del_Ministerio_Publico').attr('id', 'Detalle_de_Agente_del_Ministerio_Publico_Agente_del_Ministerio_Publico_' + index).attr('data-field', 'Agente_del_Ministerio_Publico');
    columnData[1] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Agente_del_Ministerio_Publico_Carga_de_Trabajo Carga_de_Trabajo').attr('id', 'Detalle_de_Agente_del_Ministerio_Publico_Carga_de_Trabajo_' + index).attr('data-field', 'Carga_de_Trabajo');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Agente_del_Ministerio_Publico_Especialidad Especialidad').attr('id', 'Detalle_de_Agente_del_Ministerio_Publico_Especialidad_' + index).attr('data-field', 'Especialidad');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Agente_del_Ministerio_PublicoInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Agente_del_Ministerio_Publico("Detalle_de_Agente_del_Ministerio_Publico_", "_" + rowIndex)) {
    var iPage = Detalle_de_Agente_del_Ministerio_PublicoTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Agente_del_Ministerio_Publico';
    var prevData = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetData(rowIndex);
    var data = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Agente_del_Ministerio_Publico: data.childNodes[counter++].childNodes[0].value
        ,Carga_de_Trabajo: data.childNodes[counter++].childNodes[0].value
        ,Especialidad:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Agente_del_Ministerio_PublicoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Agente_del_Ministerio_PublicorowCreationGrid(data, newData, rowIndex);
    Detalle_de_Agente_del_Ministerio_PublicoTable.fnPageChange(iPage);
    Detalle_de_Agente_del_Ministerio_PublicocountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Agente_del_Ministerio_Publico("Detalle_de_Agente_del_Ministerio_Publico_", "_" + rowIndex);
  }
}

function Detalle_de_Agente_del_Ministerio_PublicoCancelRow(rowIndex) {
    var prevData = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetData(rowIndex);
    var data = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Agente_del_Ministerio_PublicoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Agente_del_Ministerio_PublicorowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Agente_del_Ministerio_PublicoGrid(Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetData());
    Detalle_de_Agente_del_Ministerio_PublicocountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Agente_del_Ministerio_PublicoFromDataTable() {
    var Detalle_de_Agente_del_Ministerio_PublicoData = [];
    var gridData = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Agente_del_Ministerio_PublicoData.push({
                Clave: gridData[i].Clave

                ,Agente_del_Ministerio_Publico: gridData[i].Agente_del_Ministerio_Publico
                ,Carga_de_Trabajo: gridData[i].Carga_de_Trabajo
                ,Especialidad: gridData[i].Especialidad

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Agente_del_Ministerio_PublicoData.length; i++) {
        if (removedDetalle_de_Agente_del_Ministerio_PublicoData[i] != null && removedDetalle_de_Agente_del_Ministerio_PublicoData[i].Clave > 0)
            Detalle_de_Agente_del_Ministerio_PublicoData.push({
                Clave: removedDetalle_de_Agente_del_Ministerio_PublicoData[i].Clave

                ,Agente_del_Ministerio_Publico: removedDetalle_de_Agente_del_Ministerio_PublicoData[i].Agente_del_Ministerio_Publico
                ,Carga_de_Trabajo: removedDetalle_de_Agente_del_Ministerio_PublicoData[i].Carga_de_Trabajo
                ,Especialidad: removedDetalle_de_Agente_del_Ministerio_PublicoData[i].Especialidad

                , Removed: true
            });
    }	

    return Detalle_de_Agente_del_Ministerio_PublicoData;
}

function Detalle_de_Agente_del_Ministerio_PublicoEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Agente_del_Ministerio_PublicocountRowsChecked++;
    var Detalle_de_Agente_del_Ministerio_PublicoRowElement = "Detalle_de_Agente_del_Ministerio_Publico_" + rowIndex.toString();
    var prevData = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Agente_del_Ministerio_Publico_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Agente_del_Ministerio_PublicoGetUpdateRowControls(prevData, "Detalle_de_Agente_del_Ministerio_Publico_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Agente_del_Ministerio_PublicoRowElement + "')){ Detalle_de_Agente_del_Ministerio_PublicoInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Agente_del_Ministerio_PublicoCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Agente_del_Ministerio_PublicoGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Agente_del_Ministerio_PublicoGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Agente_del_Ministerio_PublicoValidation();
    initiateUIControls();
    $('.Detalle_de_Agente_del_Ministerio_Publico' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Agente_del_Ministerio_Publico(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Agente_del_Ministerio_PublicofnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetData().length;
    Detalle_de_Agente_del_Ministerio_PublicofnClickAddRow();
    GetAddDetalle_de_Agente_del_Ministerio_PublicoPopup(currentRowIndex, 0);
}

function Detalle_de_Agente_del_Ministerio_PublicoEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Agente_del_Ministerio_PublicoRowElement = "Detalle_de_Agente_del_Ministerio_Publico_" + rowIndex.toString();
    var prevData = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Agente_del_Ministerio_PublicoPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Agente_del_Ministerio_PublicoAgente_del_Ministerio_Publico').val(prevData.Agente_del_Ministerio_Publico);
    $('#Detalle_de_Agente_del_Ministerio_PublicoCarga_de_Trabajo').val(prevData.Carga_de_Trabajo);
    $('#Detalle_de_Agente_del_Ministerio_PublicoEspecialidad').val(prevData.Especialidad);

    initiateUIControls();





}

function Detalle_de_Agente_del_Ministerio_PublicoAddInsertRow() {
    if (Detalle_de_Agente_del_Ministerio_PublicoinsertRowCurrentIndex < 1)
    {
        Detalle_de_Agente_del_Ministerio_PublicoinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Agente_del_Ministerio_Publico: ""
        ,Carga_de_Trabajo: ""
        ,Especialidad: ""

    }
}

function Detalle_de_Agente_del_Ministerio_PublicofnClickAddRow() {
    Detalle_de_Agente_del_Ministerio_PublicocountRowsChecked++;
    Detalle_de_Agente_del_Ministerio_PublicoTable.fnAddData(Detalle_de_Agente_del_Ministerio_PublicoAddInsertRow(), true);
    Detalle_de_Agente_del_Ministerio_PublicoTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Agente_del_Ministerio_PublicoGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Agente_del_Ministerio_PublicoGrid tbody tr:nth-of-type(' + (Detalle_de_Agente_del_Ministerio_PublicoinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Agente_del_Ministerio_Publico("Detalle_de_Agente_del_Ministerio_Publico_", "_" + Detalle_de_Agente_del_Ministerio_PublicoinsertRowCurrentIndex);
}

function Detalle_de_Agente_del_Ministerio_PublicoClearGridData() {
    Detalle_de_Agente_del_Ministerio_PublicoData = [];
    Detalle_de_Agente_del_Ministerio_PublicodeletedItem = [];
    Detalle_de_Agente_del_Ministerio_PublicoDataMain = [];
    Detalle_de_Agente_del_Ministerio_PublicoDataMainPages = [];
    Detalle_de_Agente_del_Ministerio_PubliconewItemCount = 0;
    Detalle_de_Agente_del_Ministerio_PublicomaxItemIndex = 0;
    $("#Detalle_de_Agente_del_Ministerio_PublicoGrid").DataTable().clear();
    $("#Detalle_de_Agente_del_Ministerio_PublicoGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Agente_del_Ministerio_Publico() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Agente_del_Ministerio_PublicoData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Agente_del_Ministerio_PublicoData[i].Clave);

        form_data.append('[' + i + '].Agente_del_Ministerio_Publico', Detalle_de_Agente_del_Ministerio_PublicoData[i].Agente_del_Ministerio_Publico);
        form_data.append('[' + i + '].Carga_de_Trabajo', Detalle_de_Agente_del_Ministerio_PublicoData[i].Carga_de_Trabajo);
        form_data.append('[' + i + '].Especialidad', Detalle_de_Agente_del_Ministerio_PublicoData[i].Especialidad);

        form_data.append('[' + i + '].Removed', Detalle_de_Agente_del_Ministerio_PublicoData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Agente_del_Ministerio_PublicoInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Agente_del_Ministerio_Publico("Detalle_de_Agente_del_Ministerio_PublicoTable", rowIndex)) {
    var prevData = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetData(rowIndex);
    var data = Detalle_de_Agente_del_Ministerio_PublicoTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Agente_del_Ministerio_Publico: $('#Detalle_de_Agente_del_Ministerio_PublicoAgente_del_Ministerio_Publico').val()

        ,Carga_de_Trabajo: $('#Detalle_de_Agente_del_Ministerio_PublicoCarga_de_Trabajo').val()

        ,Especialidad: $('#Detalle_de_Agente_del_Ministerio_PublicoEspecialidad').val()

    }

    Detalle_de_Agente_del_Ministerio_PublicoTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Agente_del_Ministerio_PublicorowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Agente_del_Ministerio_Publico-form').modal({ show: false });
    $('#AddDetalle_de_Agente_del_Ministerio_Publico-form').modal('hide');
    Detalle_de_Agente_del_Ministerio_PublicoEditRow(rowIndex);
    Detalle_de_Agente_del_Ministerio_PublicoInsertRow(rowIndex);
    //}
}
function Detalle_de_Agente_del_Ministerio_PublicoRemoveAddRow(rowIndex) {
    Detalle_de_Agente_del_Ministerio_PublicoTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Agente_del_Ministerio_Publico MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Servicios_Periciales MultiRow
var Detalle_de_Servicios_PericialescountRowsChecked = 0;

function GetDetalle_de_Servicios_Periciales_Servicios_PericialesName(Id) {
    for (var i = 0; i < Detalle_de_Servicios_Periciales_Servicios_PericialesItems.length; i++) {
        if (Detalle_de_Servicios_Periciales_Servicios_PericialesItems[i].Clave == Id) {
            return Detalle_de_Servicios_Periciales_Servicios_PericialesItems[i].Servicio;
        }
    }
    return "";
}

function GetDetalle_de_Servicios_Periciales_Servicios_PericialesDropDown() {
    var Detalle_de_Servicios_Periciales_Servicios_PericialesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Servicios_Periciales_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Servicios_Periciales_Servicios_PericialesDropdown);
    if(Detalle_de_Servicios_Periciales_Servicios_PericialesItems != null)
    {
       for (var i = 0; i < Detalle_de_Servicios_Periciales_Servicios_PericialesItems.length; i++) {
           $('<option />', { value: Detalle_de_Servicios_Periciales_Servicios_PericialesItems[i].Clave, text:    Detalle_de_Servicios_Periciales_Servicios_PericialesItems[i].Servicio }).appendTo(Detalle_de_Servicios_Periciales_Servicios_PericialesDropdown);
       }
    }
    return Detalle_de_Servicios_Periciales_Servicios_PericialesDropdown;
}

function GetDetalle_de_Servicios_Periciales_Estatus_del_DictamenName(Id) {
    for (var i = 0; i < Detalle_de_Servicios_Periciales_Estatus_del_DictamenItems.length; i++) {
        if (Detalle_de_Servicios_Periciales_Estatus_del_DictamenItems[i].Clave == Id) {
            return Detalle_de_Servicios_Periciales_Estatus_del_DictamenItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Servicios_Periciales_Estatus_del_DictamenDropDown() {
    var Detalle_de_Servicios_Periciales_Estatus_del_DictamenDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Servicios_Periciales_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Servicios_Periciales_Estatus_del_DictamenDropdown);
    if(Detalle_de_Servicios_Periciales_Estatus_del_DictamenItems != null)
    {
       for (var i = 0; i < Detalle_de_Servicios_Periciales_Estatus_del_DictamenItems.length; i++) {
           $('<option />', { value: Detalle_de_Servicios_Periciales_Estatus_del_DictamenItems[i].Clave, text:    Detalle_de_Servicios_Periciales_Estatus_del_DictamenItems[i].Descripcion }).appendTo(Detalle_de_Servicios_Periciales_Estatus_del_DictamenDropdown);
       }
    }
    return Detalle_de_Servicios_Periciales_Estatus_del_DictamenDropdown;
}



function GetDetalle_de_Servicios_Periciales_Rol_de_DiligenciaName(Id) {
    for (var i = 0; i < Detalle_de_Servicios_Periciales_Rol_de_DiligenciaItems.length; i++) {
        if (Detalle_de_Servicios_Periciales_Rol_de_DiligenciaItems[i].Clave == Id) {
            return Detalle_de_Servicios_Periciales_Rol_de_DiligenciaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Servicios_Periciales_Rol_de_DiligenciaDropDown() {
    var Detalle_de_Servicios_Periciales_Rol_de_DiligenciaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Servicios_Periciales_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Servicios_Periciales_Rol_de_DiligenciaDropdown);
    if(Detalle_de_Servicios_Periciales_Rol_de_DiligenciaItems != null)
    {
       for (var i = 0; i < Detalle_de_Servicios_Periciales_Rol_de_DiligenciaItems.length; i++) {
           $('<option />', { value: Detalle_de_Servicios_Periciales_Rol_de_DiligenciaItems[i].Clave, text:    Detalle_de_Servicios_Periciales_Rol_de_DiligenciaItems[i].Descripcion }).appendTo(Detalle_de_Servicios_Periciales_Rol_de_DiligenciaDropdown);
       }
    }
    return Detalle_de_Servicios_Periciales_Rol_de_DiligenciaDropdown;
}



function GetInsertDetalle_de_Servicios_PericialesRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_de_Servicios_Periciales_Servicios_PericialesDropDown()).addClass('Detalle_de_Servicios_Periciales_Servicio Servicio').attr('id', 'Detalle_de_Servicios_Periciales_Servicio_' + index).attr('data-field', 'Servicio').after($.parseHTML(addNew('Detalle_de_Servicios_Periciales', 'Servicios_Periciales', 'Servicio', 264737)));
    columnData[1] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Servicios_Periciales_Especialista Especialista').attr('id', 'Detalle_de_Servicios_Periciales_Especialista_' + index).attr('data-field', 'Especialista');
    columnData[2] = $(GetDetalle_de_Servicios_Periciales_Estatus_del_DictamenDropDown()).addClass('Detalle_de_Servicios_Periciales_Estatus_del_Dictamen Estatus_del_Dictamen').attr('id', 'Detalle_de_Servicios_Periciales_Estatus_del_Dictamen_' + index).attr('data-field', 'Estatus_del_Dictamen').after($.parseHTML(addNew('Detalle_de_Servicios_Periciales', 'Estatus_del_Dictamen', 'Estatus_del_Dictamen', 264739)));
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Servicios_Periciales_Observaciones Observaciones').attr('id', 'Detalle_de_Servicios_Periciales_Observaciones_' + index).attr('data-field', 'Observaciones');
    columnData[4] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Servicios_Periciales_Fecha_del_Dictamen Fecha_del_Dictamen').attr('id', 'Detalle_de_Servicios_Periciales_Fecha_del_Dictamen_' + index).attr('data-field', 'Fecha_del_Dictamen');
    columnData[5] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Servicios_Periciales_Dictamen Dictamen').attr('id', 'Detalle_de_Servicios_Periciales_Dictamen_' + index).attr('data-field', 'Dictamen');
    columnData[6] = $(GetDetalle_de_Servicios_Periciales_Rol_de_DiligenciaDropDown()).addClass('Detalle_de_Servicios_Periciales_Rol_de_Donde_Proviene Rol_de_Donde_Proviene').attr('id', 'Detalle_de_Servicios_Periciales_Rol_de_Donde_Proviene_' + index).attr('data-field', 'Rol_de_Donde_Proviene').after($.parseHTML(addNew('Detalle_de_Servicios_Periciales', 'Rol_de_Diligencia', 'Rol_de_Donde_Proviene', 264743)));
    columnData[7] = $($.parseHTML(inputData)).addClass('Detalle_de_Servicios_Periciales_ObservacionesD ObservacionesD').attr('id', 'Detalle_de_Servicios_Periciales_ObservacionesD_' + index).attr('data-field', 'ObservacionesD');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Servicios_PericialesInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Servicios_Periciales("Detalle_de_Servicios_Periciales_", "_" + rowIndex)) {
    var iPage = Detalle_de_Servicios_PericialesTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Servicios_Periciales';
    var prevData = Detalle_de_Servicios_PericialesTable.fnGetData(rowIndex);
    var data = Detalle_de_Servicios_PericialesTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Servicio:  data.childNodes[counter++].childNodes[0].value
        ,Especialista: data.childNodes[counter++].childNodes[0].value
        ,Estatus_del_Dictamen:  data.childNodes[counter++].childNodes[0].value
        ,Observaciones:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_del_Dictamen:  data.childNodes[counter++].childNodes[0].value
        ,Dictamen: data.childNodes[counter++].childNodes[0].value
        ,Rol_de_Donde_Proviene:  data.childNodes[counter++].childNodes[0].value
        ,ObservacionesD:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Servicios_PericialesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Servicios_PericialesrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Servicios_PericialesTable.fnPageChange(iPage);
    Detalle_de_Servicios_PericialescountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Servicios_Periciales("Detalle_de_Servicios_Periciales_", "_" + rowIndex);
  }
}

function Detalle_de_Servicios_PericialesCancelRow(rowIndex) {
    var prevData = Detalle_de_Servicios_PericialesTable.fnGetData(rowIndex);
    var data = Detalle_de_Servicios_PericialesTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Servicios_PericialesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Servicios_PericialesrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Servicios_PericialesGrid(Detalle_de_Servicios_PericialesTable.fnGetData());
    Detalle_de_Servicios_PericialescountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Servicios_PericialesFromDataTable() {
    var Detalle_de_Servicios_PericialesData = [];
    var gridData = Detalle_de_Servicios_PericialesTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Servicios_PericialesData.push({
                Clave: gridData[i].Clave

                ,Servicio: gridData[i].Servicio
                ,Especialista: gridData[i].Especialista
                ,Estatus_del_Dictamen: gridData[i].Estatus_del_Dictamen
                ,Observaciones: gridData[i].Observaciones
                ,Fecha_del_Dictamen: gridData[i].Fecha_del_Dictamen
                ,Dictamen: gridData[i].Dictamen
                ,Rol_de_Donde_Proviene: gridData[i].Rol_de_Donde_Proviene
                ,ObservacionesD: gridData[i].ObservacionesD

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Servicios_PericialesData.length; i++) {
        if (removedDetalle_de_Servicios_PericialesData[i] != null && removedDetalle_de_Servicios_PericialesData[i].Clave > 0)
            Detalle_de_Servicios_PericialesData.push({
                Clave: removedDetalle_de_Servicios_PericialesData[i].Clave

                ,Servicio: removedDetalle_de_Servicios_PericialesData[i].Servicio
                ,Especialista: removedDetalle_de_Servicios_PericialesData[i].Especialista
                ,Estatus_del_Dictamen: removedDetalle_de_Servicios_PericialesData[i].Estatus_del_Dictamen
                ,Observaciones: removedDetalle_de_Servicios_PericialesData[i].Observaciones
                ,Fecha_del_Dictamen: removedDetalle_de_Servicios_PericialesData[i].Fecha_del_Dictamen
                ,Dictamen: removedDetalle_de_Servicios_PericialesData[i].Dictamen
                ,Rol_de_Donde_Proviene: removedDetalle_de_Servicios_PericialesData[i].Rol_de_Donde_Proviene
                ,ObservacionesD: removedDetalle_de_Servicios_PericialesData[i].ObservacionesD

                , Removed: true
            });
    }	

    return Detalle_de_Servicios_PericialesData;
}

function Detalle_de_Servicios_PericialesEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Servicios_PericialesTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Servicios_PericialescountRowsChecked++;
    var Detalle_de_Servicios_PericialesRowElement = "Detalle_de_Servicios_Periciales_" + rowIndex.toString();
    var prevData = Detalle_de_Servicios_PericialesTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Servicios_PericialesTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Servicios_Periciales_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Servicios_PericialesGetUpdateRowControls(prevData, "Detalle_de_Servicios_Periciales_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Servicios_PericialesRowElement + "')){ Detalle_de_Servicios_PericialesInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Servicios_PericialesCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Servicios_PericialesGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Servicios_PericialesGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Servicios_PericialesValidation();
    initiateUIControls();
    $('.Detalle_de_Servicios_Periciales' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Servicios_Periciales(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Servicios_PericialesfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Servicios_PericialesTable.fnGetData().length;
    Detalle_de_Servicios_PericialesfnClickAddRow();
    GetAddDetalle_de_Servicios_PericialesPopup(currentRowIndex, 0);
}

function Detalle_de_Servicios_PericialesEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Servicios_PericialesTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Servicios_PericialesRowElement = "Detalle_de_Servicios_Periciales_" + rowIndex.toString();
    var prevData = Detalle_de_Servicios_PericialesTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Servicios_PericialesPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Servicios_PericialesServicio').val(prevData.Servicio);
    $('#Detalle_de_Servicios_PericialesEspecialista').val(prevData.Especialista);
    $('#Detalle_de_Servicios_PericialesEstatus_del_Dictamen').val(prevData.Estatus_del_Dictamen);
    $('#Detalle_de_Servicios_PericialesObservaciones').val(prevData.Observaciones);
    $('#Detalle_de_Servicios_PericialesFecha_del_Dictamen').val(prevData.Fecha_del_Dictamen);
    $('#Detalle_de_Servicios_PericialesDictamen').val(prevData.Dictamen);
    $('#Detalle_de_Servicios_PericialesRol_de_Donde_Proviene').val(prevData.Rol_de_Donde_Proviene);
    $('#Detalle_de_Servicios_PericialesObservacionesD').val(prevData.ObservacionesD);

    initiateUIControls();










}

function Detalle_de_Servicios_PericialesAddInsertRow() {
    if (Detalle_de_Servicios_PericialesinsertRowCurrentIndex < 1)
    {
        Detalle_de_Servicios_PericialesinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Servicio: ""
        ,Especialista: ""
        ,Estatus_del_Dictamen: ""
        ,Observaciones: ""
        ,Fecha_del_Dictamen: ""
        ,Dictamen: ""
        ,Rol_de_Donde_Proviene: ""
        ,ObservacionesD: ""

    }
}

function Detalle_de_Servicios_PericialesfnClickAddRow() {
    Detalle_de_Servicios_PericialescountRowsChecked++;
    Detalle_de_Servicios_PericialesTable.fnAddData(Detalle_de_Servicios_PericialesAddInsertRow(), true);
    Detalle_de_Servicios_PericialesTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Servicios_PericialesGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Servicios_PericialesGrid tbody tr:nth-of-type(' + (Detalle_de_Servicios_PericialesinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Servicios_Periciales("Detalle_de_Servicios_Periciales_", "_" + Detalle_de_Servicios_PericialesinsertRowCurrentIndex);
}

function Detalle_de_Servicios_PericialesClearGridData() {
    Detalle_de_Servicios_PericialesData = [];
    Detalle_de_Servicios_PericialesdeletedItem = [];
    Detalle_de_Servicios_PericialesDataMain = [];
    Detalle_de_Servicios_PericialesDataMainPages = [];
    Detalle_de_Servicios_PericialesnewItemCount = 0;
    Detalle_de_Servicios_PericialesmaxItemIndex = 0;
    $("#Detalle_de_Servicios_PericialesGrid").DataTable().clear();
    $("#Detalle_de_Servicios_PericialesGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Servicios_Periciales() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Servicios_PericialesData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Servicios_PericialesData[i].Clave);

        form_data.append('[' + i + '].Servicio', Detalle_de_Servicios_PericialesData[i].Servicio);
        form_data.append('[' + i + '].Especialista', Detalle_de_Servicios_PericialesData[i].Especialista);
        form_data.append('[' + i + '].Estatus_del_Dictamen', Detalle_de_Servicios_PericialesData[i].Estatus_del_Dictamen);
        form_data.append('[' + i + '].Observaciones', Detalle_de_Servicios_PericialesData[i].Observaciones);
        form_data.append('[' + i + '].Fecha_del_Dictamen', Detalle_de_Servicios_PericialesData[i].Fecha_del_Dictamen);
        form_data.append('[' + i + '].Dictamen', Detalle_de_Servicios_PericialesData[i].Dictamen);
        form_data.append('[' + i + '].Rol_de_Donde_Proviene', Detalle_de_Servicios_PericialesData[i].Rol_de_Donde_Proviene);
        form_data.append('[' + i + '].ObservacionesD', Detalle_de_Servicios_PericialesData[i].ObservacionesD);

        form_data.append('[' + i + '].Removed', Detalle_de_Servicios_PericialesData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Servicios_PericialesInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Servicios_Periciales("Detalle_de_Servicios_PericialesTable", rowIndex)) {
    var prevData = Detalle_de_Servicios_PericialesTable.fnGetData(rowIndex);
    var data = Detalle_de_Servicios_PericialesTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Servicio: $('#Detalle_de_Servicios_PericialesServicio').val()
        ,Especialista: $('#Detalle_de_Servicios_PericialesEspecialista').val()

        ,Estatus_del_Dictamen: $('#Detalle_de_Servicios_PericialesEstatus_del_Dictamen').val()
        ,Observaciones: $('#Detalle_de_Servicios_PericialesObservaciones').val()
        ,Fecha_del_Dictamen: $('#Detalle_de_Servicios_PericialesFecha_del_Dictamen').val()
        ,Dictamen: $('#Detalle_de_Servicios_PericialesDictamen').val()

        ,Rol_de_Donde_Proviene: $('#Detalle_de_Servicios_PericialesRol_de_Donde_Proviene').val()
        ,ObservacionesD: $('#Detalle_de_Servicios_PericialesObservacionesD').val()

    }

    Detalle_de_Servicios_PericialesTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Servicios_PericialesrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Servicios_Periciales-form').modal({ show: false });
    $('#AddDetalle_de_Servicios_Periciales-form').modal('hide');
    Detalle_de_Servicios_PericialesEditRow(rowIndex);
    Detalle_de_Servicios_PericialesInsertRow(rowIndex);
    //}
}
function Detalle_de_Servicios_PericialesRemoveAddRow(rowIndex) {
    Detalle_de_Servicios_PericialesTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Servicios_Periciales MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Oficio_de_Servicio_Pericial MultiRow
var Detalle_de_Oficio_de_Servicio_PericialcountRowsChecked = 0;

function GetDetalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosName(Id) {
    for (var i = 0; i < Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosItems.length; i++) {
        if (Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosItems[i].Clave == Id) {
            return Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosDropDown() {
    var Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Oficio_de_Servicio_Pericial_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosDropdown);
    if(Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosItems != null)
    {
       for (var i = 0; i < Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosItems.length; i++) {
           $('<option />', { value: Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosItems[i].Clave, text:    Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosItems[i].Descripcion }).appendTo(Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosDropdown);
       }
    }
    return Detalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosDropdown;
}
function GetDetalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesName(Id) {
    for (var i = 0; i < Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesItems.length; i++) {
        if (Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesItems[i].Clave == Id) {
            return Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesItems[i].Servicio;
        }
    }
    return "";
}

function GetDetalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesDropDown() {
    var Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Oficio_de_Servicio_Pericial_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesDropdown);
    if(Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesItems != null)
    {
       for (var i = 0; i < Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesItems.length; i++) {
           $('<option />', { value: Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesItems[i].Clave, text:    Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesItems[i].Servicio }).appendTo(Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesDropdown);
       }
    }
    return Detalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesDropdown;
}


function GetInsertDetalle_de_Oficio_de_Servicio_PericialRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosDropDown()).addClass('Detalle_de_Oficio_de_Servicio_Pericial_Oficio Oficio').attr('id', 'Detalle_de_Oficio_de_Servicio_Pericial_Oficio_' + index).attr('data-field', 'Oficio').after($.parseHTML(addNew('Detalle_de_Oficio_de_Servicio_Pericial', 'Tipo_de_Oficios', 'Oficio', 264752)));
    columnData[1] = $(GetDetalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesDropDown()).addClass('Detalle_de_Oficio_de_Servicio_Pericial_Servicio_Pericial Servicio_Pericial').attr('id', 'Detalle_de_Oficio_de_Servicio_Pericial_Servicio_Pericial_' + index).attr('data-field', 'Servicio_Pericial').after($.parseHTML(addNew('Detalle_de_Oficio_de_Servicio_Pericial', 'Servicios_Periciales', 'Servicio_Pericial', 264753)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_Oficio_de_Servicio_PericialInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Oficio_de_Servicio_Pericial("Detalle_de_Oficio_de_Servicio_Pericial_", "_" + rowIndex)) {
    var iPage = Detalle_de_Oficio_de_Servicio_PericialTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Oficio_de_Servicio_Pericial';
    var prevData = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetData(rowIndex);
    var data = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Oficio:  data.childNodes[counter++].childNodes[0].value
        ,Servicio_Pericial:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Oficio_de_Servicio_PericialTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Oficio_de_Servicio_PericialrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Oficio_de_Servicio_PericialTable.fnPageChange(iPage);
    Detalle_de_Oficio_de_Servicio_PericialcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Oficio_de_Servicio_Pericial("Detalle_de_Oficio_de_Servicio_Pericial_", "_" + rowIndex);
  }
}

function Detalle_de_Oficio_de_Servicio_PericialCancelRow(rowIndex) {
    var prevData = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetData(rowIndex);
    var data = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Oficio_de_Servicio_PericialTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Oficio_de_Servicio_PericialrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Oficio_de_Servicio_PericialGrid(Detalle_de_Oficio_de_Servicio_PericialTable.fnGetData());
    Detalle_de_Oficio_de_Servicio_PericialcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Oficio_de_Servicio_PericialFromDataTable() {
    var Detalle_de_Oficio_de_Servicio_PericialData = [];
    var gridData = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Oficio_de_Servicio_PericialData.push({
                Clave: gridData[i].Clave

                ,Oficio: gridData[i].Oficio
                ,Servicio_Pericial: gridData[i].Servicio_Pericial

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Oficio_de_Servicio_PericialData.length; i++) {
        if (removedDetalle_de_Oficio_de_Servicio_PericialData[i] != null && removedDetalle_de_Oficio_de_Servicio_PericialData[i].Clave > 0)
            Detalle_de_Oficio_de_Servicio_PericialData.push({
                Clave: removedDetalle_de_Oficio_de_Servicio_PericialData[i].Clave

                ,Oficio: removedDetalle_de_Oficio_de_Servicio_PericialData[i].Oficio
                ,Servicio_Pericial: removedDetalle_de_Oficio_de_Servicio_PericialData[i].Servicio_Pericial

                , Removed: true
            });
    }	

    return Detalle_de_Oficio_de_Servicio_PericialData;
}

function Detalle_de_Oficio_de_Servicio_PericialEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Oficio_de_Servicio_PericialTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Oficio_de_Servicio_PericialcountRowsChecked++;
    var Detalle_de_Oficio_de_Servicio_PericialRowElement = "Detalle_de_Oficio_de_Servicio_Pericial_" + rowIndex.toString();
    var prevData = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Oficio_de_Servicio_Pericial_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Oficio_de_Servicio_PericialGetUpdateRowControls(prevData, "Detalle_de_Oficio_de_Servicio_Pericial_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Oficio_de_Servicio_PericialRowElement + "')){ Detalle_de_Oficio_de_Servicio_PericialInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Oficio_de_Servicio_PericialCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Oficio_de_Servicio_PericialGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Oficio_de_Servicio_PericialGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Oficio_de_Servicio_PericialValidation();
    initiateUIControls();
    $('.Detalle_de_Oficio_de_Servicio_Pericial' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Oficio_de_Servicio_Pericial(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Oficio_de_Servicio_PericialfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetData().length;
    Detalle_de_Oficio_de_Servicio_PericialfnClickAddRow();
    GetAddDetalle_de_Oficio_de_Servicio_PericialPopup(currentRowIndex, 0);
}

function Detalle_de_Oficio_de_Servicio_PericialEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Oficio_de_Servicio_PericialRowElement = "Detalle_de_Oficio_de_Servicio_Pericial_" + rowIndex.toString();
    var prevData = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Oficio_de_Servicio_PericialPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Oficio_de_Servicio_PericialOficio').val(prevData.Oficio);
    $('#Detalle_de_Oficio_de_Servicio_PericialServicio_Pericial').val(prevData.Servicio_Pericial);

    initiateUIControls();




}

function Detalle_de_Oficio_de_Servicio_PericialAddInsertRow() {
    if (Detalle_de_Oficio_de_Servicio_PericialinsertRowCurrentIndex < 1)
    {
        Detalle_de_Oficio_de_Servicio_PericialinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Oficio: ""
        ,Servicio_Pericial: ""

    }
}

function Detalle_de_Oficio_de_Servicio_PericialfnClickAddRow() {
    Detalle_de_Oficio_de_Servicio_PericialcountRowsChecked++;
    Detalle_de_Oficio_de_Servicio_PericialTable.fnAddData(Detalle_de_Oficio_de_Servicio_PericialAddInsertRow(), true);
    Detalle_de_Oficio_de_Servicio_PericialTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Oficio_de_Servicio_PericialGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Oficio_de_Servicio_PericialGrid tbody tr:nth-of-type(' + (Detalle_de_Oficio_de_Servicio_PericialinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Oficio_de_Servicio_Pericial("Detalle_de_Oficio_de_Servicio_Pericial_", "_" + Detalle_de_Oficio_de_Servicio_PericialinsertRowCurrentIndex);
}

function Detalle_de_Oficio_de_Servicio_PericialClearGridData() {
    Detalle_de_Oficio_de_Servicio_PericialData = [];
    Detalle_de_Oficio_de_Servicio_PericialdeletedItem = [];
    Detalle_de_Oficio_de_Servicio_PericialDataMain = [];
    Detalle_de_Oficio_de_Servicio_PericialDataMainPages = [];
    Detalle_de_Oficio_de_Servicio_PericialnewItemCount = 0;
    Detalle_de_Oficio_de_Servicio_PericialmaxItemIndex = 0;
    $("#Detalle_de_Oficio_de_Servicio_PericialGrid").DataTable().clear();
    $("#Detalle_de_Oficio_de_Servicio_PericialGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Oficio_de_Servicio_Pericial() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Oficio_de_Servicio_PericialData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Oficio_de_Servicio_PericialData[i].Clave);

        form_data.append('[' + i + '].Oficio', Detalle_de_Oficio_de_Servicio_PericialData[i].Oficio);
        form_data.append('[' + i + '].Servicio_Pericial', Detalle_de_Oficio_de_Servicio_PericialData[i].Servicio_Pericial);

        form_data.append('[' + i + '].Removed', Detalle_de_Oficio_de_Servicio_PericialData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Oficio_de_Servicio_PericialInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Oficio_de_Servicio_Pericial("Detalle_de_Oficio_de_Servicio_PericialTable", rowIndex)) {
    var prevData = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetData(rowIndex);
    var data = Detalle_de_Oficio_de_Servicio_PericialTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Oficio: $('#Detalle_de_Oficio_de_Servicio_PericialOficio').val()
        ,Servicio_Pericial: $('#Detalle_de_Oficio_de_Servicio_PericialServicio_Pericial').val()

    }

    Detalle_de_Oficio_de_Servicio_PericialTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Oficio_de_Servicio_PericialrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Oficio_de_Servicio_Pericial-form').modal({ show: false });
    $('#AddDetalle_de_Oficio_de_Servicio_Pericial-form').modal('hide');
    Detalle_de_Oficio_de_Servicio_PericialEditRow(rowIndex);
    Detalle_de_Oficio_de_Servicio_PericialInsertRow(rowIndex);
    //}
}
function Detalle_de_Oficio_de_Servicio_PericialRemoveAddRow(rowIndex) {
    Detalle_de_Oficio_de_Servicio_PericialTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Oficio_de_Servicio_Pericial MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_IPH_MPI MultiRow
var Detalle_de_IPH_MPIcountRowsChecked = 0;









function GetInsertDetalle_de_IPH_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_IPH_MPI_NUE NUE').attr('id', 'Detalle_de_IPH_MPI_NUE_' + index).attr('data-field', 'NUE');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_IPH_MPI_Folio Folio').attr('id', 'Detalle_de_IPH_MPI_Folio_' + index).attr('data-field', 'Folio');
    columnData[2] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_IPH_MPI_Fecha Fecha').attr('id', 'Detalle_de_IPH_MPI_Fecha_' + index).attr('data-field', 'Fecha');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_IPH_MPI_Documentos Documentos').attr('id', 'Detalle_de_IPH_MPI_Documentos_' + index).attr('data-field', 'Documentos');
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_IPH_MPI_Archivo Archivo').attr('id', 'Detalle_de_IPH_MPI_Archivo_' + index).attr('data-field', 'Archivo');
    columnData[5] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_IPH_MPI_Hora Hora').attr('id', 'Detalle_de_IPH_MPI_Hora_' + index).attr('data-field', 'Hora');


    initiateUIControls();
    return columnData;
}

function Detalle_de_IPH_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_IPH_MPI("Detalle_de_IPH_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_IPH_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_IPH_MPI';
    var prevData = Detalle_de_IPH_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_IPH_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,NUE:  data.childNodes[counter++].childNodes[0].value
        ,Folio:  data.childNodes[counter++].childNodes[0].value
        ,Fecha:  data.childNodes[counter++].childNodes[0].value
        ,Documentos:  data.childNodes[counter++].childNodes[0].value
        ,Archivo: data.childNodes[counter++].childNodes[0].value
        ,Hora:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_IPH_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_IPH_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_IPH_MPITable.fnPageChange(iPage);
    Detalle_de_IPH_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_IPH_MPI("Detalle_de_IPH_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_IPH_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_IPH_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_IPH_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_IPH_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_IPH_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_IPH_MPIGrid(Detalle_de_IPH_MPITable.fnGetData());
    Detalle_de_IPH_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_IPH_MPIFromDataTable() {
    var Detalle_de_IPH_MPIData = [];
    var gridData = Detalle_de_IPH_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_IPH_MPIData.push({
                Clave: gridData[i].Clave

                ,NUE: gridData[i].NUE
                ,Folio: gridData[i].Folio
                ,Fecha: gridData[i].Fecha
                ,Documentos: gridData[i].Documentos
                ,Archivo: gridData[i].Archivo
                ,Hora: gridData[i].Hora

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_IPH_MPIData.length; i++) {
        if (removedDetalle_de_IPH_MPIData[i] != null && removedDetalle_de_IPH_MPIData[i].Clave > 0)
            Detalle_de_IPH_MPIData.push({
                Clave: removedDetalle_de_IPH_MPIData[i].Clave

                ,NUE: removedDetalle_de_IPH_MPIData[i].NUE
                ,Folio: removedDetalle_de_IPH_MPIData[i].Folio
                ,Fecha: removedDetalle_de_IPH_MPIData[i].Fecha
                ,Documentos: removedDetalle_de_IPH_MPIData[i].Documentos
                ,Archivo: removedDetalle_de_IPH_MPIData[i].Archivo
                ,Hora: removedDetalle_de_IPH_MPIData[i].Hora

                , Removed: true
            });
    }	

    return Detalle_de_IPH_MPIData;
}

function Detalle_de_IPH_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_IPH_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_IPH_MPIcountRowsChecked++;
    var Detalle_de_IPH_MPIRowElement = "Detalle_de_IPH_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_IPH_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_IPH_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_IPH_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_IPH_MPIGetUpdateRowControls(prevData, "Detalle_de_IPH_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_IPH_MPIRowElement + "')){ Detalle_de_IPH_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_IPH_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_IPH_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_IPH_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_IPH_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_IPH_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_IPH_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_IPH_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_IPH_MPITable.fnGetData().length;
    Detalle_de_IPH_MPIfnClickAddRow();
    GetAddDetalle_de_IPH_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_IPH_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_IPH_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_IPH_MPIRowElement = "Detalle_de_IPH_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_IPH_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_IPH_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_IPH_MPINUE').val(prevData.NUE);
    $('#Detalle_de_IPH_MPIFolio').val(prevData.Folio);
    $('#Detalle_de_IPH_MPIFecha').val(prevData.Fecha);
    $('#Detalle_de_IPH_MPIDocumentos').val(prevData.Documentos);
    $('#Detalle_de_IPH_MPIArchivo').val(prevData.Archivo);
    $('#Detalle_de_IPH_MPIHora').val(prevData.Hora);

    initiateUIControls();








}

function Detalle_de_IPH_MPIAddInsertRow() {
    if (Detalle_de_IPH_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_IPH_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,NUE: ""
        ,Folio: ""
        ,Fecha: ""
        ,Documentos: ""
        ,Archivo: ""
        ,Hora: ""

    }
}

function Detalle_de_IPH_MPIfnClickAddRow() {
    Detalle_de_IPH_MPIcountRowsChecked++;
    Detalle_de_IPH_MPITable.fnAddData(Detalle_de_IPH_MPIAddInsertRow(), true);
    Detalle_de_IPH_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_IPH_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_IPH_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_IPH_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_IPH_MPI("Detalle_de_IPH_MPI_", "_" + Detalle_de_IPH_MPIinsertRowCurrentIndex);
}

function Detalle_de_IPH_MPIClearGridData() {
    Detalle_de_IPH_MPIData = [];
    Detalle_de_IPH_MPIdeletedItem = [];
    Detalle_de_IPH_MPIDataMain = [];
    Detalle_de_IPH_MPIDataMainPages = [];
    Detalle_de_IPH_MPInewItemCount = 0;
    Detalle_de_IPH_MPImaxItemIndex = 0;
    $("#Detalle_de_IPH_MPIGrid").DataTable().clear();
    $("#Detalle_de_IPH_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_IPH_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_IPH_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_IPH_MPIData[i].Clave);

        form_data.append('[' + i + '].NUE', Detalle_de_IPH_MPIData[i].NUE);
        form_data.append('[' + i + '].Folio', Detalle_de_IPH_MPIData[i].Folio);
        form_data.append('[' + i + '].Fecha', Detalle_de_IPH_MPIData[i].Fecha);
        form_data.append('[' + i + '].Documentos', Detalle_de_IPH_MPIData[i].Documentos);
        form_data.append('[' + i + '].Archivo', Detalle_de_IPH_MPIData[i].Archivo);
        form_data.append('[' + i + '].Hora', Detalle_de_IPH_MPIData[i].Hora);

        form_data.append('[' + i + '].Removed', Detalle_de_IPH_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_IPH_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_IPH_MPI("Detalle_de_IPH_MPITable", rowIndex)) {
    var prevData = Detalle_de_IPH_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_IPH_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,NUE: $('#Detalle_de_IPH_MPINUE').val()
        ,Folio: $('#Detalle_de_IPH_MPIFolio').val()
        ,Fecha: $('#Detalle_de_IPH_MPIFecha').val()
        ,Documentos: $('#Detalle_de_IPH_MPIDocumentos').val()
        ,Archivo: $('#Detalle_de_IPH_MPIArchivo').val()

        ,Hora: $('#Detalle_de_IPH_MPIHora').val()

    }

    Detalle_de_IPH_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_IPH_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_IPH_MPI-form').modal({ show: false });
    $('#AddDetalle_de_IPH_MPI-form').modal('hide');
    Detalle_de_IPH_MPIEditRow(rowIndex);
    Detalle_de_IPH_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_IPH_MPIRemoveAddRow(rowIndex) {
    Detalle_de_IPH_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_IPH_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Solicitante_en_Audiencias_MPI MultiRow
var Detalle_de_Solicitante_en_Audiencias_MPIcountRowsChecked = 0;

function GetDetalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIName(Id) {
    for (var i = 0; i < Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIItems.length; i++) {
        if (Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIItems[i].Clave == Id) {
            return Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIDropDown() {
    var Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Solicitante_en_Audiencias_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIDropdown);
    if(Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIItems != null)
    {
       for (var i = 0; i < Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIItems.length; i++) {
           $('<option />', { value: Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIItems[i].Clave, text:    Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIItems[i].Nombre }).appendTo(Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIDropdown);
       }
    }
    return Detalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIDropdown;
}



function GetInsertDetalle_de_Solicitante_en_Audiencias_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIDropDown()).addClass('Detalle_de_Solicitante_en_Audiencias_MPI_Nombre Nombre').attr('id', 'Detalle_de_Solicitante_en_Audiencias_MPI_Nombre_' + index).attr('data-field', 'Nombre').after($.parseHTML(addNew('Detalle_de_Solicitante_en_Audiencias_MPI', 'Solicitante_MPI', 'Nombre', 264777)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Solicitante_en_Audiencias_MPI_Direccion Direccion').attr('id', 'Detalle_de_Solicitante_en_Audiencias_MPI_Direccion_' + index).attr('data-field', 'Direccion');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Solicitante_en_Audiencias_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Audiencias_MPI("Detalle_de_Solicitante_en_Audiencias_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_Solicitante_en_Audiencias_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Solicitante_en_Audiencias_MPI';
    var prevData = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Direccion:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Solicitante_en_Audiencias_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Solicitante_en_Audiencias_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Solicitante_en_Audiencias_MPITable.fnPageChange(iPage);
    Detalle_de_Solicitante_en_Audiencias_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Solicitante_en_Audiencias_MPI("Detalle_de_Solicitante_en_Audiencias_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_Solicitante_en_Audiencias_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Solicitante_en_Audiencias_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Solicitante_en_Audiencias_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Solicitante_en_Audiencias_MPIGrid(Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetData());
    Detalle_de_Solicitante_en_Audiencias_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Solicitante_en_Audiencias_MPIFromDataTable() {
    var Detalle_de_Solicitante_en_Audiencias_MPIData = [];
    var gridData = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Solicitante_en_Audiencias_MPIData.push({
                Clave: gridData[i].Clave

                ,Nombre: gridData[i].Nombre
                ,Direccion: gridData[i].Direccion

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Solicitante_en_Audiencias_MPIData.length; i++) {
        if (removedDetalle_de_Solicitante_en_Audiencias_MPIData[i] != null && removedDetalle_de_Solicitante_en_Audiencias_MPIData[i].Clave > 0)
            Detalle_de_Solicitante_en_Audiencias_MPIData.push({
                Clave: removedDetalle_de_Solicitante_en_Audiencias_MPIData[i].Clave

                ,Nombre: removedDetalle_de_Solicitante_en_Audiencias_MPIData[i].Nombre
                ,Direccion: removedDetalle_de_Solicitante_en_Audiencias_MPIData[i].Direccion

                , Removed: true
            });
    }	

    return Detalle_de_Solicitante_en_Audiencias_MPIData;
}

function Detalle_de_Solicitante_en_Audiencias_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Solicitante_en_Audiencias_MPIcountRowsChecked++;
    var Detalle_de_Solicitante_en_Audiencias_MPIRowElement = "Detalle_de_Solicitante_en_Audiencias_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Solicitante_en_Audiencias_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Solicitante_en_Audiencias_MPIGetUpdateRowControls(prevData, "Detalle_de_Solicitante_en_Audiencias_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Solicitante_en_Audiencias_MPIRowElement + "')){ Detalle_de_Solicitante_en_Audiencias_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Solicitante_en_Audiencias_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Solicitante_en_Audiencias_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Solicitante_en_Audiencias_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Solicitante_en_Audiencias_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_Solicitante_en_Audiencias_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Solicitante_en_Audiencias_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Solicitante_en_Audiencias_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetData().length;
    Detalle_de_Solicitante_en_Audiencias_MPIfnClickAddRow();
    GetAddDetalle_de_Solicitante_en_Audiencias_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_Solicitante_en_Audiencias_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Solicitante_en_Audiencias_MPIRowElement = "Detalle_de_Solicitante_en_Audiencias_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Solicitante_en_Audiencias_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Solicitante_en_Audiencias_MPINombre').val(prevData.Nombre);
    $('#Detalle_de_Solicitante_en_Audiencias_MPIDireccion').val(prevData.Direccion);

    initiateUIControls();




}

function Detalle_de_Solicitante_en_Audiencias_MPIAddInsertRow() {
    if (Detalle_de_Solicitante_en_Audiencias_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_Solicitante_en_Audiencias_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre: ""
        ,Direccion: ""

    }
}

function Detalle_de_Solicitante_en_Audiencias_MPIfnClickAddRow() {
    Detalle_de_Solicitante_en_Audiencias_MPIcountRowsChecked++;
    Detalle_de_Solicitante_en_Audiencias_MPITable.fnAddData(Detalle_de_Solicitante_en_Audiencias_MPIAddInsertRow(), true);
    Detalle_de_Solicitante_en_Audiencias_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Solicitante_en_Audiencias_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Solicitante_en_Audiencias_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_Solicitante_en_Audiencias_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Solicitante_en_Audiencias_MPI("Detalle_de_Solicitante_en_Audiencias_MPI_", "_" + Detalle_de_Solicitante_en_Audiencias_MPIinsertRowCurrentIndex);
}

function Detalle_de_Solicitante_en_Audiencias_MPIClearGridData() {
    Detalle_de_Solicitante_en_Audiencias_MPIData = [];
    Detalle_de_Solicitante_en_Audiencias_MPIdeletedItem = [];
    Detalle_de_Solicitante_en_Audiencias_MPIDataMain = [];
    Detalle_de_Solicitante_en_Audiencias_MPIDataMainPages = [];
    Detalle_de_Solicitante_en_Audiencias_MPInewItemCount = 0;
    Detalle_de_Solicitante_en_Audiencias_MPImaxItemIndex = 0;
    $("#Detalle_de_Solicitante_en_Audiencias_MPIGrid").DataTable().clear();
    $("#Detalle_de_Solicitante_en_Audiencias_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Solicitante_en_Audiencias_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Solicitante_en_Audiencias_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Solicitante_en_Audiencias_MPIData[i].Clave);

        form_data.append('[' + i + '].Nombre', Detalle_de_Solicitante_en_Audiencias_MPIData[i].Nombre);
        form_data.append('[' + i + '].Direccion', Detalle_de_Solicitante_en_Audiencias_MPIData[i].Direccion);

        form_data.append('[' + i + '].Removed', Detalle_de_Solicitante_en_Audiencias_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Solicitante_en_Audiencias_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Solicitante_en_Audiencias_MPI("Detalle_de_Solicitante_en_Audiencias_MPITable", rowIndex)) {
    var prevData = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Solicitante_en_Audiencias_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre: $('#Detalle_de_Solicitante_en_Audiencias_MPINombre').val()
        ,Direccion: $('#Detalle_de_Solicitante_en_Audiencias_MPIDireccion').val()

    }

    Detalle_de_Solicitante_en_Audiencias_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Solicitante_en_Audiencias_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Solicitante_en_Audiencias_MPI-form').modal({ show: false });
    $('#AddDetalle_de_Solicitante_en_Audiencias_MPI-form').modal('hide');
    Detalle_de_Solicitante_en_Audiencias_MPIEditRow(rowIndex);
    Detalle_de_Solicitante_en_Audiencias_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_Solicitante_en_Audiencias_MPIRemoveAddRow(rowIndex) {
    Detalle_de_Solicitante_en_Audiencias_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Solicitante_en_Audiencias_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Requerido_en_Audiencias_MPI MultiRow
var Detalle_de_Requerido_en_Audiencias_MPIcountRowsChecked = 0;

function GetDetalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIName(Id) {
    for (var i = 0; i < Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIItems.length; i++) {
        if (Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIItems[i].Clave == Id) {
            return Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIDropDown() {
    var Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Requerido_en_Audiencias_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIDropdown);
    if(Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIItems != null)
    {
       for (var i = 0; i < Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIItems.length; i++) {
           $('<option />', { value: Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIItems[i].Clave, text:    Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIItems[i].Nombre }).appendTo(Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIDropdown);
       }
    }
    return Detalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIDropdown;
}



function GetInsertDetalle_de_Requerido_en_Audiencias_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIDropDown()).addClass('Detalle_de_Requerido_en_Audiencias_MPI_Nombre Nombre').attr('id', 'Detalle_de_Requerido_en_Audiencias_MPI_Nombre_' + index).attr('data-field', 'Nombre').after($.parseHTML(addNew('Detalle_de_Requerido_en_Audiencias_MPI', 'Requerido_MPI', 'Nombre', 264781)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Requerido_en_Audiencias_MPI_Direccion Direccion').attr('id', 'Detalle_de_Requerido_en_Audiencias_MPI_Direccion_' + index).attr('data-field', 'Direccion');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Requerido_en_Audiencias_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requerido_en_Audiencias_MPI("Detalle_de_Requerido_en_Audiencias_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_Requerido_en_Audiencias_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Requerido_en_Audiencias_MPI';
    var prevData = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre:  data.childNodes[counter++].childNodes[0].value
        ,Direccion:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Requerido_en_Audiencias_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Requerido_en_Audiencias_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Requerido_en_Audiencias_MPITable.fnPageChange(iPage);
    Detalle_de_Requerido_en_Audiencias_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Requerido_en_Audiencias_MPI("Detalle_de_Requerido_en_Audiencias_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_Requerido_en_Audiencias_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Requerido_en_Audiencias_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Requerido_en_Audiencias_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Requerido_en_Audiencias_MPIGrid(Detalle_de_Requerido_en_Audiencias_MPITable.fnGetData());
    Detalle_de_Requerido_en_Audiencias_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Requerido_en_Audiencias_MPIFromDataTable() {
    var Detalle_de_Requerido_en_Audiencias_MPIData = [];
    var gridData = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Requerido_en_Audiencias_MPIData.push({
                Clave: gridData[i].Clave

                ,Nombre: gridData[i].Nombre
                ,Direccion: gridData[i].Direccion

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Requerido_en_Audiencias_MPIData.length; i++) {
        if (removedDetalle_de_Requerido_en_Audiencias_MPIData[i] != null && removedDetalle_de_Requerido_en_Audiencias_MPIData[i].Clave > 0)
            Detalle_de_Requerido_en_Audiencias_MPIData.push({
                Clave: removedDetalle_de_Requerido_en_Audiencias_MPIData[i].Clave

                ,Nombre: removedDetalle_de_Requerido_en_Audiencias_MPIData[i].Nombre
                ,Direccion: removedDetalle_de_Requerido_en_Audiencias_MPIData[i].Direccion

                , Removed: true
            });
    }	

    return Detalle_de_Requerido_en_Audiencias_MPIData;
}

function Detalle_de_Requerido_en_Audiencias_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Requerido_en_Audiencias_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Requerido_en_Audiencias_MPIcountRowsChecked++;
    var Detalle_de_Requerido_en_Audiencias_MPIRowElement = "Detalle_de_Requerido_en_Audiencias_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Requerido_en_Audiencias_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Requerido_en_Audiencias_MPIGetUpdateRowControls(prevData, "Detalle_de_Requerido_en_Audiencias_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Requerido_en_Audiencias_MPIRowElement + "')){ Detalle_de_Requerido_en_Audiencias_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Requerido_en_Audiencias_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Requerido_en_Audiencias_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Requerido_en_Audiencias_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Requerido_en_Audiencias_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_Requerido_en_Audiencias_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Requerido_en_Audiencias_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Requerido_en_Audiencias_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetData().length;
    Detalle_de_Requerido_en_Audiencias_MPIfnClickAddRow();
    GetAddDetalle_de_Requerido_en_Audiencias_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_Requerido_en_Audiencias_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Requerido_en_Audiencias_MPIRowElement = "Detalle_de_Requerido_en_Audiencias_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Requerido_en_Audiencias_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Requerido_en_Audiencias_MPINombre').val(prevData.Nombre);
    $('#Detalle_de_Requerido_en_Audiencias_MPIDireccion').val(prevData.Direccion);

    initiateUIControls();




}

function Detalle_de_Requerido_en_Audiencias_MPIAddInsertRow() {
    if (Detalle_de_Requerido_en_Audiencias_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_Requerido_en_Audiencias_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre: ""
        ,Direccion: ""

    }
}

function Detalle_de_Requerido_en_Audiencias_MPIfnClickAddRow() {
    Detalle_de_Requerido_en_Audiencias_MPIcountRowsChecked++;
    Detalle_de_Requerido_en_Audiencias_MPITable.fnAddData(Detalle_de_Requerido_en_Audiencias_MPIAddInsertRow(), true);
    Detalle_de_Requerido_en_Audiencias_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Requerido_en_Audiencias_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Requerido_en_Audiencias_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_Requerido_en_Audiencias_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Requerido_en_Audiencias_MPI("Detalle_de_Requerido_en_Audiencias_MPI_", "_" + Detalle_de_Requerido_en_Audiencias_MPIinsertRowCurrentIndex);
}

function Detalle_de_Requerido_en_Audiencias_MPIClearGridData() {
    Detalle_de_Requerido_en_Audiencias_MPIData = [];
    Detalle_de_Requerido_en_Audiencias_MPIdeletedItem = [];
    Detalle_de_Requerido_en_Audiencias_MPIDataMain = [];
    Detalle_de_Requerido_en_Audiencias_MPIDataMainPages = [];
    Detalle_de_Requerido_en_Audiencias_MPInewItemCount = 0;
    Detalle_de_Requerido_en_Audiencias_MPImaxItemIndex = 0;
    $("#Detalle_de_Requerido_en_Audiencias_MPIGrid").DataTable().clear();
    $("#Detalle_de_Requerido_en_Audiencias_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Requerido_en_Audiencias_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Requerido_en_Audiencias_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Requerido_en_Audiencias_MPIData[i].Clave);

        form_data.append('[' + i + '].Nombre', Detalle_de_Requerido_en_Audiencias_MPIData[i].Nombre);
        form_data.append('[' + i + '].Direccion', Detalle_de_Requerido_en_Audiencias_MPIData[i].Direccion);

        form_data.append('[' + i + '].Removed', Detalle_de_Requerido_en_Audiencias_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Requerido_en_Audiencias_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Requerido_en_Audiencias_MPI("Detalle_de_Requerido_en_Audiencias_MPITable", rowIndex)) {
    var prevData = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Requerido_en_Audiencias_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre: $('#Detalle_de_Requerido_en_Audiencias_MPINombre').val()
        ,Direccion: $('#Detalle_de_Requerido_en_Audiencias_MPIDireccion').val()

    }

    Detalle_de_Requerido_en_Audiencias_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Requerido_en_Audiencias_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Requerido_en_Audiencias_MPI-form').modal({ show: false });
    $('#AddDetalle_de_Requerido_en_Audiencias_MPI-form').modal('hide');
    Detalle_de_Requerido_en_Audiencias_MPIEditRow(rowIndex);
    Detalle_de_Requerido_en_Audiencias_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_Requerido_en_Audiencias_MPIRemoveAddRow(rowIndex) {
    Detalle_de_Requerido_en_Audiencias_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Requerido_en_Audiencias_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Citatorio_Audiencias MultiRow
var Detalle_de_Citatorio_AudienciascountRowsChecked = 0;








function GetInsertDetalle_de_Citatorio_AudienciasRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Citatorio_Audiencias_Numero_de_audiencia_citatorio Numero_de_audiencia_citatorio').attr('id', 'Detalle_de_Citatorio_Audiencias_Numero_de_audiencia_citatorio_' + index).attr('data-field', 'Numero_de_audiencia_citatorio');
    columnData[1] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Citatorio_Audiencias_Fecha Fecha').attr('id', 'Detalle_de_Citatorio_Audiencias_Fecha_' + index).attr('data-field', 'Fecha');
    columnData[2] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Citatorio_Audiencias_Hora Hora').attr('id', 'Detalle_de_Citatorio_Audiencias_Hora_' + index).attr('data-field', 'Hora');
    columnData[3] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Citatorio_Audiencias_Fecha_de_Aceptacion Fecha_de_Aceptacion').attr('id', 'Detalle_de_Citatorio_Audiencias_Fecha_de_Aceptacion_' + index).attr('data-field', 'Fecha_de_Aceptacion');
    columnData[4] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Citatorio_Audiencias_Hora_de_Aceptacion Hora_de_Aceptacion').attr('id', 'Detalle_de_Citatorio_Audiencias_Hora_de_Aceptacion_' + index).attr('data-field', 'Hora_de_Aceptacion');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Citatorio_AudienciasInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Citatorio_Audiencias("Detalle_de_Citatorio_Audiencias_", "_" + rowIndex)) {
    var iPage = Detalle_de_Citatorio_AudienciasTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Citatorio_Audiencias';
    var prevData = Detalle_de_Citatorio_AudienciasTable.fnGetData(rowIndex);
    var data = Detalle_de_Citatorio_AudienciasTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_audiencia_citatorio:  data.childNodes[counter++].childNodes[0].value
        ,Fecha:  data.childNodes[counter++].childNodes[0].value
        ,Hora:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Aceptacion:  data.childNodes[counter++].childNodes[0].value
        ,Hora_de_Aceptacion:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Citatorio_AudienciasTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Citatorio_AudienciasrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Citatorio_AudienciasTable.fnPageChange(iPage);
    Detalle_de_Citatorio_AudienciascountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Citatorio_Audiencias("Detalle_de_Citatorio_Audiencias_", "_" + rowIndex);
  }
}

function Detalle_de_Citatorio_AudienciasCancelRow(rowIndex) {
    var prevData = Detalle_de_Citatorio_AudienciasTable.fnGetData(rowIndex);
    var data = Detalle_de_Citatorio_AudienciasTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Citatorio_AudienciasTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Citatorio_AudienciasrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Citatorio_AudienciasGrid(Detalle_de_Citatorio_AudienciasTable.fnGetData());
    Detalle_de_Citatorio_AudienciascountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Citatorio_AudienciasFromDataTable() {
    var Detalle_de_Citatorio_AudienciasData = [];
    var gridData = Detalle_de_Citatorio_AudienciasTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Citatorio_AudienciasData.push({
                Clave: gridData[i].Clave

                ,Numero_de_audiencia_citatorio: gridData[i].Numero_de_audiencia_citatorio
                ,Fecha: gridData[i].Fecha
                ,Hora: gridData[i].Hora
                ,Fecha_de_Aceptacion: gridData[i].Fecha_de_Aceptacion
                ,Hora_de_Aceptacion: gridData[i].Hora_de_Aceptacion

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Citatorio_AudienciasData.length; i++) {
        if (removedDetalle_de_Citatorio_AudienciasData[i] != null && removedDetalle_de_Citatorio_AudienciasData[i].Clave > 0)
            Detalle_de_Citatorio_AudienciasData.push({
                Clave: removedDetalle_de_Citatorio_AudienciasData[i].Clave

                ,Numero_de_audiencia_citatorio: removedDetalle_de_Citatorio_AudienciasData[i].Numero_de_audiencia_citatorio
                ,Fecha: removedDetalle_de_Citatorio_AudienciasData[i].Fecha
                ,Hora: removedDetalle_de_Citatorio_AudienciasData[i].Hora
                ,Fecha_de_Aceptacion: removedDetalle_de_Citatorio_AudienciasData[i].Fecha_de_Aceptacion
                ,Hora_de_Aceptacion: removedDetalle_de_Citatorio_AudienciasData[i].Hora_de_Aceptacion

                , Removed: true
            });
    }	

    return Detalle_de_Citatorio_AudienciasData;
}

function Detalle_de_Citatorio_AudienciasEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Citatorio_AudienciasTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Citatorio_AudienciascountRowsChecked++;
    var Detalle_de_Citatorio_AudienciasRowElement = "Detalle_de_Citatorio_Audiencias_" + rowIndex.toString();
    var prevData = Detalle_de_Citatorio_AudienciasTable.fnGetData(rowIndexTable );
    var row = Detalle_de_Citatorio_AudienciasTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Citatorio_Audiencias_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Citatorio_AudienciasGetUpdateRowControls(prevData, "Detalle_de_Citatorio_Audiencias_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Citatorio_AudienciasRowElement + "')){ Detalle_de_Citatorio_AudienciasInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Citatorio_AudienciasCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Citatorio_AudienciasGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Citatorio_AudienciasGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Citatorio_AudienciasValidation();
    initiateUIControls();
    $('.Detalle_de_Citatorio_Audiencias' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Citatorio_Audiencias(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Citatorio_AudienciasfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Citatorio_AudienciasTable.fnGetData().length;
    Detalle_de_Citatorio_AudienciasfnClickAddRow();
    GetAddDetalle_de_Citatorio_AudienciasPopup(currentRowIndex, 0);
}

function Detalle_de_Citatorio_AudienciasEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Citatorio_AudienciasTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Citatorio_AudienciasRowElement = "Detalle_de_Citatorio_Audiencias_" + rowIndex.toString();
    var prevData = Detalle_de_Citatorio_AudienciasTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Citatorio_AudienciasPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Citatorio_AudienciasNumero_de_audiencia_citatorio').val(prevData.Numero_de_audiencia_citatorio);
    $('#Detalle_de_Citatorio_AudienciasFecha').val(prevData.Fecha);
    $('#Detalle_de_Citatorio_AudienciasHora').val(prevData.Hora);
    $('#Detalle_de_Citatorio_AudienciasFecha_de_Aceptacion').val(prevData.Fecha_de_Aceptacion);
    $('#Detalle_de_Citatorio_AudienciasHora_de_Aceptacion').val(prevData.Hora_de_Aceptacion);

    initiateUIControls();







}

function Detalle_de_Citatorio_AudienciasAddInsertRow() {
    if (Detalle_de_Citatorio_AudienciasinsertRowCurrentIndex < 1)
    {
        Detalle_de_Citatorio_AudienciasinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Numero_de_audiencia_citatorio: ""
        ,Fecha: ""
        ,Hora: ""
        ,Fecha_de_Aceptacion: ""
        ,Hora_de_Aceptacion: ""

    }
}

function Detalle_de_Citatorio_AudienciasfnClickAddRow() {
    Detalle_de_Citatorio_AudienciascountRowsChecked++;
    Detalle_de_Citatorio_AudienciasTable.fnAddData(Detalle_de_Citatorio_AudienciasAddInsertRow(), true);
    Detalle_de_Citatorio_AudienciasTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Citatorio_AudienciasGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Citatorio_AudienciasGrid tbody tr:nth-of-type(' + (Detalle_de_Citatorio_AudienciasinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Citatorio_Audiencias("Detalle_de_Citatorio_Audiencias_", "_" + Detalle_de_Citatorio_AudienciasinsertRowCurrentIndex);
}

function Detalle_de_Citatorio_AudienciasClearGridData() {
    Detalle_de_Citatorio_AudienciasData = [];
    Detalle_de_Citatorio_AudienciasdeletedItem = [];
    Detalle_de_Citatorio_AudienciasDataMain = [];
    Detalle_de_Citatorio_AudienciasDataMainPages = [];
    Detalle_de_Citatorio_AudienciasnewItemCount = 0;
    Detalle_de_Citatorio_AudienciasmaxItemIndex = 0;
    $("#Detalle_de_Citatorio_AudienciasGrid").DataTable().clear();
    $("#Detalle_de_Citatorio_AudienciasGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Citatorio_Audiencias() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Citatorio_AudienciasData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Citatorio_AudienciasData[i].Clave);

        form_data.append('[' + i + '].Numero_de_audiencia_citatorio', Detalle_de_Citatorio_AudienciasData[i].Numero_de_audiencia_citatorio);
        form_data.append('[' + i + '].Fecha', Detalle_de_Citatorio_AudienciasData[i].Fecha);
        form_data.append('[' + i + '].Hora', Detalle_de_Citatorio_AudienciasData[i].Hora);
        form_data.append('[' + i + '].Fecha_de_Aceptacion', Detalle_de_Citatorio_AudienciasData[i].Fecha_de_Aceptacion);
        form_data.append('[' + i + '].Hora_de_Aceptacion', Detalle_de_Citatorio_AudienciasData[i].Hora_de_Aceptacion);

        form_data.append('[' + i + '].Removed', Detalle_de_Citatorio_AudienciasData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Citatorio_AudienciasInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Citatorio_Audiencias("Detalle_de_Citatorio_AudienciasTable", rowIndex)) {
    var prevData = Detalle_de_Citatorio_AudienciasTable.fnGetData(rowIndex);
    var data = Detalle_de_Citatorio_AudienciasTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_audiencia_citatorio: $('#Detalle_de_Citatorio_AudienciasNumero_de_audiencia_citatorio').val()
        ,Fecha: $('#Detalle_de_Citatorio_AudienciasFecha').val()
        ,Hora: $('#Detalle_de_Citatorio_AudienciasHora').val()
        ,Fecha_de_Aceptacion: $('#Detalle_de_Citatorio_AudienciasFecha_de_Aceptacion').val()
        ,Hora_de_Aceptacion: $('#Detalle_de_Citatorio_AudienciasHora_de_Aceptacion').val()

    }

    Detalle_de_Citatorio_AudienciasTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Citatorio_AudienciasrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Citatorio_Audiencias-form').modal({ show: false });
    $('#AddDetalle_de_Citatorio_Audiencias-form').modal('hide');
    Detalle_de_Citatorio_AudienciasEditRow(rowIndex);
    Detalle_de_Citatorio_AudienciasInsertRow(rowIndex);
    //}
}
function Detalle_de_Citatorio_AudienciasRemoveAddRow(rowIndex) {
    Detalle_de_Citatorio_AudienciasTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Citatorio_Audiencias MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Documentos_MPI MultiRow
var Detalle_de_Documentos_MPIcountRowsChecked = 0;






function GetInsertDetalle_de_Documentos_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Documentos_MPI_Fecha Fecha').attr('id', 'Detalle_de_Documentos_MPI_Fecha_' + index).attr('data-field', 'Fecha');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Documentos_MPI_Documento Documento').attr('id', 'Detalle_de_Documentos_MPI_Documento_' + index).attr('data-field', 'Documento');
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Documentos_MPI_Archivo Archivo').attr('id', 'Detalle_de_Documentos_MPI_Archivo_' + index).attr('data-field', 'Archivo');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Documentos_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Documentos_MPI("Detalle_de_Documentos_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_Documentos_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Documentos_MPI';
    var prevData = Detalle_de_Documentos_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Documentos_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha:  data.childNodes[counter++].childNodes[0].value
        ,Documento:  data.childNodes[counter++].childNodes[0].value
        ,Archivo: data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Documentos_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Documentos_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Documentos_MPITable.fnPageChange(iPage);
    Detalle_de_Documentos_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Documentos_MPI("Detalle_de_Documentos_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_Documentos_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_Documentos_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Documentos_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Documentos_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Documentos_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Documentos_MPIGrid(Detalle_de_Documentos_MPITable.fnGetData());
    Detalle_de_Documentos_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Documentos_MPIFromDataTable() {
    var Detalle_de_Documentos_MPIData = [];
    var gridData = Detalle_de_Documentos_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Documentos_MPIData.push({
                Clave: gridData[i].Clave

                ,Fecha: gridData[i].Fecha
                ,Documento: gridData[i].Documento
                ,Archivo: gridData[i].Archivo

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Documentos_MPIData.length; i++) {
        if (removedDetalle_de_Documentos_MPIData[i] != null && removedDetalle_de_Documentos_MPIData[i].Clave > 0)
            Detalle_de_Documentos_MPIData.push({
                Clave: removedDetalle_de_Documentos_MPIData[i].Clave

                ,Fecha: removedDetalle_de_Documentos_MPIData[i].Fecha
                ,Documento: removedDetalle_de_Documentos_MPIData[i].Documento
                ,Archivo: removedDetalle_de_Documentos_MPIData[i].Archivo

                , Removed: true
            });
    }	

    return Detalle_de_Documentos_MPIData;
}

function Detalle_de_Documentos_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Documentos_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Documentos_MPIcountRowsChecked++;
    var Detalle_de_Documentos_MPIRowElement = "Detalle_de_Documentos_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Documentos_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_Documentos_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Documentos_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Documentos_MPIGetUpdateRowControls(prevData, "Detalle_de_Documentos_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Documentos_MPIRowElement + "')){ Detalle_de_Documentos_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Documentos_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Documentos_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Documentos_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Documentos_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_Documentos_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Documentos_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Documentos_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Documentos_MPITable.fnGetData().length;
    Detalle_de_Documentos_MPIfnClickAddRow();
    GetAddDetalle_de_Documentos_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_Documentos_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Documentos_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Documentos_MPIRowElement = "Detalle_de_Documentos_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Documentos_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Documentos_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Documentos_MPIFecha').val(prevData.Fecha);
    $('#Detalle_de_Documentos_MPIDocumento').val(prevData.Documento);
    $('#Detalle_de_Documentos_MPIArchivo').val(prevData.Archivo);

    initiateUIControls();





}

function Detalle_de_Documentos_MPIAddInsertRow() {
    if (Detalle_de_Documentos_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_Documentos_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha: ""
        ,Documento: ""
        ,Archivo: ""

    }
}

function Detalle_de_Documentos_MPIfnClickAddRow() {
    Detalle_de_Documentos_MPIcountRowsChecked++;
    Detalle_de_Documentos_MPITable.fnAddData(Detalle_de_Documentos_MPIAddInsertRow(), true);
    Detalle_de_Documentos_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Documentos_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Documentos_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_Documentos_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Documentos_MPI("Detalle_de_Documentos_MPI_", "_" + Detalle_de_Documentos_MPIinsertRowCurrentIndex);
}

function Detalle_de_Documentos_MPIClearGridData() {
    Detalle_de_Documentos_MPIData = [];
    Detalle_de_Documentos_MPIdeletedItem = [];
    Detalle_de_Documentos_MPIDataMain = [];
    Detalle_de_Documentos_MPIDataMainPages = [];
    Detalle_de_Documentos_MPInewItemCount = 0;
    Detalle_de_Documentos_MPImaxItemIndex = 0;
    $("#Detalle_de_Documentos_MPIGrid").DataTable().clear();
    $("#Detalle_de_Documentos_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Documentos_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Documentos_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Documentos_MPIData[i].Clave);

        form_data.append('[' + i + '].Fecha', Detalle_de_Documentos_MPIData[i].Fecha);
        form_data.append('[' + i + '].Documento', Detalle_de_Documentos_MPIData[i].Documento);
        form_data.append('[' + i + '].Archivo', Detalle_de_Documentos_MPIData[i].Archivo);

        form_data.append('[' + i + '].Removed', Detalle_de_Documentos_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Documentos_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Documentos_MPI("Detalle_de_Documentos_MPITable", rowIndex)) {
    var prevData = Detalle_de_Documentos_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Documentos_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha: $('#Detalle_de_Documentos_MPIFecha').val()
        ,Documento: $('#Detalle_de_Documentos_MPIDocumento').val()
        ,Archivo: $('#Detalle_de_Documentos_MPIArchivo').val()


    }

    Detalle_de_Documentos_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Documentos_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Documentos_MPI-form').modal({ show: false });
    $('#AddDetalle_de_Documentos_MPI-form').modal('hide');
    Detalle_de_Documentos_MPIEditRow(rowIndex);
    Detalle_de_Documentos_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_Documentos_MPIRemoveAddRow(rowIndex) {
    Detalle_de_Documentos_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Documentos_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Coincidencias_MPI MultiRow
var Detalle_de_Coincidencias_MPIcountRowsChecked = 0;









function GetInsertDetalle_de_Coincidencias_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Coincidencias_MPI_Nombre_Completo Nombre_Completo').attr('id', 'Detalle_de_Coincidencias_MPI_Nombre_Completo_' + index).attr('data-field', 'Nombre_Completo');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Coincidencias_MPI_Alias Alias').attr('id', 'Detalle_de_Coincidencias_MPI_Alias_' + index).attr('data-field', 'Alias');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Coincidencias_MPI_Numero_de_Expediente Numero_de_Expediente').attr('id', 'Detalle_de_Coincidencias_MPI_Numero_de_Expediente_' + index).attr('data-field', 'Numero_de_Expediente');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Coincidencias_MPI_NUAT NUAT').attr('id', 'Detalle_de_Coincidencias_MPI_NUAT_' + index).attr('data-field', 'NUAT');
    columnData[4] = $($.parseHTML(inputData)).addClass('Detalle_de_Coincidencias_MPI_NUC NUC').attr('id', 'Detalle_de_Coincidencias_MPI_NUC_' + index).attr('data-field', 'NUC');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_de_Coincidencias_MPI_Rol Rol').attr('id', 'Detalle_de_Coincidencias_MPI_Rol_' + index).attr('data-field', 'Rol');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Coincidencias_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Coincidencias_MPI("Detalle_de_Coincidencias_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_Coincidencias_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Coincidencias_MPI';
    var prevData = Detalle_de_Coincidencias_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Coincidencias_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre_Completo:  data.childNodes[counter++].childNodes[0].value
        ,Alias:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Expediente:  data.childNodes[counter++].childNodes[0].value
        ,NUAT:  data.childNodes[counter++].childNodes[0].value
        ,NUC:  data.childNodes[counter++].childNodes[0].value
        ,Rol:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Coincidencias_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Coincidencias_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Coincidencias_MPITable.fnPageChange(iPage);
    Detalle_de_Coincidencias_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Coincidencias_MPI("Detalle_de_Coincidencias_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_Coincidencias_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_Coincidencias_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Coincidencias_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Coincidencias_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Coincidencias_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Coincidencias_MPIGrid(Detalle_de_Coincidencias_MPITable.fnGetData());
    Detalle_de_Coincidencias_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Coincidencias_MPIFromDataTable() {
    var Detalle_de_Coincidencias_MPIData = [];
    var gridData = Detalle_de_Coincidencias_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Coincidencias_MPIData.push({
                Clave: gridData[i].Clave

                ,Nombre_Completo: gridData[i].Nombre_Completo
                ,Alias: gridData[i].Alias
                ,Numero_de_Expediente: gridData[i].Numero_de_Expediente
                ,NUAT: gridData[i].NUAT
                ,NUC: gridData[i].NUC
                ,Rol: gridData[i].Rol

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Coincidencias_MPIData.length; i++) {
        if (removedDetalle_de_Coincidencias_MPIData[i] != null && removedDetalle_de_Coincidencias_MPIData[i].Clave > 0)
            Detalle_de_Coincidencias_MPIData.push({
                Clave: removedDetalle_de_Coincidencias_MPIData[i].Clave

                ,Nombre_Completo: removedDetalle_de_Coincidencias_MPIData[i].Nombre_Completo
                ,Alias: removedDetalle_de_Coincidencias_MPIData[i].Alias
                ,Numero_de_Expediente: removedDetalle_de_Coincidencias_MPIData[i].Numero_de_Expediente
                ,NUAT: removedDetalle_de_Coincidencias_MPIData[i].NUAT
                ,NUC: removedDetalle_de_Coincidencias_MPIData[i].NUC
                ,Rol: removedDetalle_de_Coincidencias_MPIData[i].Rol

                , Removed: true
            });
    }	

    return Detalle_de_Coincidencias_MPIData;
}

function Detalle_de_Coincidencias_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Coincidencias_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Coincidencias_MPIcountRowsChecked++;
    var Detalle_de_Coincidencias_MPIRowElement = "Detalle_de_Coincidencias_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Coincidencias_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_Coincidencias_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Coincidencias_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Coincidencias_MPIGetUpdateRowControls(prevData, "Detalle_de_Coincidencias_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Coincidencias_MPIRowElement + "')){ Detalle_de_Coincidencias_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Coincidencias_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Coincidencias_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Coincidencias_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Coincidencias_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_Coincidencias_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Coincidencias_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Coincidencias_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Coincidencias_MPITable.fnGetData().length;
    Detalle_de_Coincidencias_MPIfnClickAddRow();
    GetAddDetalle_de_Coincidencias_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_Coincidencias_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Coincidencias_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Coincidencias_MPIRowElement = "Detalle_de_Coincidencias_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Coincidencias_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Coincidencias_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Coincidencias_MPINombre_Completo').val(prevData.Nombre_Completo);
    $('#Detalle_de_Coincidencias_MPIAlias').val(prevData.Alias);
    $('#Detalle_de_Coincidencias_MPINumero_de_Expediente').val(prevData.Numero_de_Expediente);
    $('#Detalle_de_Coincidencias_MPINUAT').val(prevData.NUAT);
    $('#Detalle_de_Coincidencias_MPINUC').val(prevData.NUC);
    $('#Detalle_de_Coincidencias_MPIRol').val(prevData.Rol);

    initiateUIControls();








}

function Detalle_de_Coincidencias_MPIAddInsertRow() {
    if (Detalle_de_Coincidencias_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_Coincidencias_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Nombre_Completo: ""
        ,Alias: ""
        ,Numero_de_Expediente: ""
        ,NUAT: ""
        ,NUC: ""
        ,Rol: ""

    }
}

function Detalle_de_Coincidencias_MPIfnClickAddRow() {
    Detalle_de_Coincidencias_MPIcountRowsChecked++;
    Detalle_de_Coincidencias_MPITable.fnAddData(Detalle_de_Coincidencias_MPIAddInsertRow(), true);
    Detalle_de_Coincidencias_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Coincidencias_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Coincidencias_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_Coincidencias_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Coincidencias_MPI("Detalle_de_Coincidencias_MPI_", "_" + Detalle_de_Coincidencias_MPIinsertRowCurrentIndex);
}

function Detalle_de_Coincidencias_MPIClearGridData() {
    Detalle_de_Coincidencias_MPIData = [];
    Detalle_de_Coincidencias_MPIdeletedItem = [];
    Detalle_de_Coincidencias_MPIDataMain = [];
    Detalle_de_Coincidencias_MPIDataMainPages = [];
    Detalle_de_Coincidencias_MPInewItemCount = 0;
    Detalle_de_Coincidencias_MPImaxItemIndex = 0;
    $("#Detalle_de_Coincidencias_MPIGrid").DataTable().clear();
    $("#Detalle_de_Coincidencias_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Coincidencias_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Coincidencias_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Coincidencias_MPIData[i].Clave);

        form_data.append('[' + i + '].Nombre_Completo', Detalle_de_Coincidencias_MPIData[i].Nombre_Completo);
        form_data.append('[' + i + '].Alias', Detalle_de_Coincidencias_MPIData[i].Alias);
        form_data.append('[' + i + '].Numero_de_Expediente', Detalle_de_Coincidencias_MPIData[i].Numero_de_Expediente);
        form_data.append('[' + i + '].NUAT', Detalle_de_Coincidencias_MPIData[i].NUAT);
        form_data.append('[' + i + '].NUC', Detalle_de_Coincidencias_MPIData[i].NUC);
        form_data.append('[' + i + '].Rol', Detalle_de_Coincidencias_MPIData[i].Rol);

        form_data.append('[' + i + '].Removed', Detalle_de_Coincidencias_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Coincidencias_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Coincidencias_MPI("Detalle_de_Coincidencias_MPITable", rowIndex)) {
    var prevData = Detalle_de_Coincidencias_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Coincidencias_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Nombre_Completo: $('#Detalle_de_Coincidencias_MPINombre_Completo').val()
        ,Alias: $('#Detalle_de_Coincidencias_MPIAlias').val()
        ,Numero_de_Expediente: $('#Detalle_de_Coincidencias_MPINumero_de_Expediente').val()
        ,NUAT: $('#Detalle_de_Coincidencias_MPINUAT').val()
        ,NUC: $('#Detalle_de_Coincidencias_MPINUC').val()
        ,Rol: $('#Detalle_de_Coincidencias_MPIRol').val()

    }

    Detalle_de_Coincidencias_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Coincidencias_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Coincidencias_MPI-form').modal({ show: false });
    $('#AddDetalle_de_Coincidencias_MPI-form').modal('hide');
    Detalle_de_Coincidencias_MPIEditRow(rowIndex);
    Detalle_de_Coincidencias_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_Coincidencias_MPIRemoveAddRow(rowIndex) {
    Detalle_de_Coincidencias_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Coincidencias_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Indicios MultiRow
var Detalle_de_IndicioscountRowsChecked = 0;





function GetDetalle_de_Indicios_Servicios_PericialesName(Id) {
    for (var i = 0; i < Detalle_de_Indicios_Servicios_PericialesItems.length; i++) {
        if (Detalle_de_Indicios_Servicios_PericialesItems[i].Clave == Id) {
            return Detalle_de_Indicios_Servicios_PericialesItems[i].Servicio;
        }
    }
    return "";
}

function GetDetalle_de_Indicios_Servicios_PericialesDropDown() {
    var Detalle_de_Indicios_Servicios_PericialesDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Indicios_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Indicios_Servicios_PericialesDropdown);
    if(Detalle_de_Indicios_Servicios_PericialesItems != null)
    {
       for (var i = 0; i < Detalle_de_Indicios_Servicios_PericialesItems.length; i++) {
           $('<option />', { value: Detalle_de_Indicios_Servicios_PericialesItems[i].Clave, text:    Detalle_de_Indicios_Servicios_PericialesItems[i].Servicio }).appendTo(Detalle_de_Indicios_Servicios_PericialesDropdown);
       }
    }
    return Detalle_de_Indicios_Servicios_PericialesDropdown;
}

function GetDetalle_de_Indicios_Estatus_de_IndicioName(Id) {
    for (var i = 0; i < Detalle_de_Indicios_Estatus_de_IndicioItems.length; i++) {
        if (Detalle_de_Indicios_Estatus_de_IndicioItems[i].Clave == Id) {
            return Detalle_de_Indicios_Estatus_de_IndicioItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Indicios_Estatus_de_IndicioDropDown() {
    var Detalle_de_Indicios_Estatus_de_IndicioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Indicios_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Indicios_Estatus_de_IndicioDropdown);
    if(Detalle_de_Indicios_Estatus_de_IndicioItems != null)
    {
       for (var i = 0; i < Detalle_de_Indicios_Estatus_de_IndicioItems.length; i++) {
           $('<option />', { value: Detalle_de_Indicios_Estatus_de_IndicioItems[i].Clave, text:    Detalle_de_Indicios_Estatus_de_IndicioItems[i].Descripcion }).appendTo(Detalle_de_Indicios_Estatus_de_IndicioDropdown);
       }
    }
    return Detalle_de_Indicios_Estatus_de_IndicioDropdown;
}


function GetInsertDetalle_de_IndiciosRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(inputData)).addClass('Detalle_de_Indicios_Numero_de_Indicio Numero_de_Indicio').attr('id', 'Detalle_de_Indicios_Numero_de_Indicio_' + index).attr('data-field', 'Numero_de_Indicio');
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_de_Indicios_Nombre_de_Indicio Nombre_de_Indicio').attr('id', 'Detalle_de_Indicios_Nombre_de_Indicio_' + index).attr('data-field', 'Nombre_de_Indicio');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_de_Indicios_Descripcion_de_Indicio Descripcion_de_Indicio').attr('id', 'Detalle_de_Indicios_Descripcion_de_Indicio_' + index).attr('data-field', 'Descripcion_de_Indicio');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_de_Indicios_Motivo_de_Indicio Motivo_de_Indicio').attr('id', 'Detalle_de_Indicios_Motivo_de_Indicio_' + index).attr('data-field', 'Motivo_de_Indicio');
    columnData[4] = $(GetDetalle_de_Indicios_Servicios_PericialesDropDown()).addClass('Detalle_de_Indicios_Diligencia Diligencia').attr('id', 'Detalle_de_Indicios_Diligencia_' + index).attr('data-field', 'Diligencia').after($.parseHTML(addNew('Detalle_de_Indicios', 'Servicios_Periciales', 'Diligencia', 264818)));
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_de_Indicios_Ubicacion Ubicacion').attr('id', 'Detalle_de_Indicios_Ubicacion_' + index).attr('data-field', 'Ubicacion');
    columnData[6] = $(GetDetalle_de_Indicios_Estatus_de_IndicioDropDown()).addClass('Detalle_de_Indicios_Estatus Estatus').attr('id', 'Detalle_de_Indicios_Estatus_' + index).attr('data-field', 'Estatus').after($.parseHTML(addNew('Detalle_de_Indicios', 'Estatus_de_Indicio', 'Estatus', 264821)));


    initiateUIControls();
    return columnData;
}

function Detalle_de_IndiciosInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Indicios("Detalle_de_Indicios_", "_" + rowIndex)) {
    var iPage = Detalle_de_IndiciosTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Indicios';
    var prevData = Detalle_de_IndiciosTable.fnGetData(rowIndex);
    var data = Detalle_de_IndiciosTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_de_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Descripcion_de_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Motivo_de_Indicio:  data.childNodes[counter++].childNodes[0].value
        ,Diligencia:  data.childNodes[counter++].childNodes[0].value
        ,Ubicacion:  data.childNodes[counter++].childNodes[0].value
        ,Estatus:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_IndiciosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_IndiciosrowCreationGrid(data, newData, rowIndex);
    Detalle_de_IndiciosTable.fnPageChange(iPage);
    Detalle_de_IndicioscountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Indicios("Detalle_de_Indicios_", "_" + rowIndex);
  }
}

function Detalle_de_IndiciosCancelRow(rowIndex) {
    var prevData = Detalle_de_IndiciosTable.fnGetData(rowIndex);
    var data = Detalle_de_IndiciosTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_IndiciosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_IndiciosrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_IndiciosGrid(Detalle_de_IndiciosTable.fnGetData());
    Detalle_de_IndicioscountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_IndiciosFromDataTable() {
    var Detalle_de_IndiciosData = [];
    var gridData = Detalle_de_IndiciosTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_IndiciosData.push({
                Clave: gridData[i].Clave

                ,Numero_de_Indicio: gridData[i].Numero_de_Indicio
                ,Nombre_de_Indicio: gridData[i].Nombre_de_Indicio
                ,Descripcion_de_Indicio: gridData[i].Descripcion_de_Indicio
                ,Motivo_de_Indicio: gridData[i].Motivo_de_Indicio
                ,Diligencia: gridData[i].Diligencia
                ,Ubicacion: gridData[i].Ubicacion
                ,Estatus: gridData[i].Estatus

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_IndiciosData.length; i++) {
        if (removedDetalle_de_IndiciosData[i] != null && removedDetalle_de_IndiciosData[i].Clave > 0)
            Detalle_de_IndiciosData.push({
                Clave: removedDetalle_de_IndiciosData[i].Clave

                ,Numero_de_Indicio: removedDetalle_de_IndiciosData[i].Numero_de_Indicio
                ,Nombre_de_Indicio: removedDetalle_de_IndiciosData[i].Nombre_de_Indicio
                ,Descripcion_de_Indicio: removedDetalle_de_IndiciosData[i].Descripcion_de_Indicio
                ,Motivo_de_Indicio: removedDetalle_de_IndiciosData[i].Motivo_de_Indicio
                ,Diligencia: removedDetalle_de_IndiciosData[i].Diligencia
                ,Ubicacion: removedDetalle_de_IndiciosData[i].Ubicacion
                ,Estatus: removedDetalle_de_IndiciosData[i].Estatus

                , Removed: true
            });
    }	

    return Detalle_de_IndiciosData;
}

function Detalle_de_IndiciosEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_IndiciosTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_IndicioscountRowsChecked++;
    var Detalle_de_IndiciosRowElement = "Detalle_de_Indicios_" + rowIndex.toString();
    var prevData = Detalle_de_IndiciosTable.fnGetData(rowIndexTable );
    var row = Detalle_de_IndiciosTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Indicios_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_IndiciosGetUpdateRowControls(prevData, "Detalle_de_Indicios_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_IndiciosRowElement + "')){ Detalle_de_IndiciosInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_IndiciosCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_IndiciosGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_IndiciosGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_IndiciosValidation();
    initiateUIControls();
    $('.Detalle_de_Indicios' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Indicios(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_IndiciosfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_IndiciosTable.fnGetData().length;
    Detalle_de_IndiciosfnClickAddRow();
    GetAddDetalle_de_IndiciosPopup(currentRowIndex, 0);
}

function Detalle_de_IndiciosEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_IndiciosTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_IndiciosRowElement = "Detalle_de_Indicios_" + rowIndex.toString();
    var prevData = Detalle_de_IndiciosTable.fnGetData(rowIndexTable);
    GetAddDetalle_de_IndiciosPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_IndiciosNumero_de_Indicio').val(prevData.Numero_de_Indicio);
    $('#Detalle_de_IndiciosNombre_de_Indicio').val(prevData.Nombre_de_Indicio);
    $('#Detalle_de_IndiciosDescripcion_de_Indicio').val(prevData.Descripcion_de_Indicio);
    $('#Detalle_de_IndiciosMotivo_de_Indicio').val(prevData.Motivo_de_Indicio);
    $('#Detalle_de_IndiciosDiligencia').val(prevData.Diligencia);
    $('#Detalle_de_IndiciosUbicacion').val(prevData.Ubicacion);
    $('#Detalle_de_IndiciosEstatus').val(prevData.Estatus);

    initiateUIControls();









}

function Detalle_de_IndiciosAddInsertRow() {
    if (Detalle_de_IndiciosinsertRowCurrentIndex < 1)
    {
        Detalle_de_IndiciosinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Numero_de_Indicio: ""
        ,Nombre_de_Indicio: ""
        ,Descripcion_de_Indicio: ""
        ,Motivo_de_Indicio: ""
        ,Diligencia: ""
        ,Ubicacion: ""
        ,Estatus: ""

    }
}

function Detalle_de_IndiciosfnClickAddRow() {
    Detalle_de_IndicioscountRowsChecked++;
    Detalle_de_IndiciosTable.fnAddData(Detalle_de_IndiciosAddInsertRow(), true);
    Detalle_de_IndiciosTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_IndiciosGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_IndiciosGrid tbody tr:nth-of-type(' + (Detalle_de_IndiciosinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Indicios("Detalle_de_Indicios_", "_" + Detalle_de_IndiciosinsertRowCurrentIndex);
}

function Detalle_de_IndiciosClearGridData() {
    Detalle_de_IndiciosData = [];
    Detalle_de_IndiciosdeletedItem = [];
    Detalle_de_IndiciosDataMain = [];
    Detalle_de_IndiciosDataMainPages = [];
    Detalle_de_IndiciosnewItemCount = 0;
    Detalle_de_IndiciosmaxItemIndex = 0;
    $("#Detalle_de_IndiciosGrid").DataTable().clear();
    $("#Detalle_de_IndiciosGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_de_Indicios() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_IndiciosData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_IndiciosData[i].Clave);

        form_data.append('[' + i + '].Numero_de_Indicio', Detalle_de_IndiciosData[i].Numero_de_Indicio);
        form_data.append('[' + i + '].Nombre_de_Indicio', Detalle_de_IndiciosData[i].Nombre_de_Indicio);
        form_data.append('[' + i + '].Descripcion_de_Indicio', Detalle_de_IndiciosData[i].Descripcion_de_Indicio);
        form_data.append('[' + i + '].Motivo_de_Indicio', Detalle_de_IndiciosData[i].Motivo_de_Indicio);
        form_data.append('[' + i + '].Diligencia', Detalle_de_IndiciosData[i].Diligencia);
        form_data.append('[' + i + '].Ubicacion', Detalle_de_IndiciosData[i].Ubicacion);
        form_data.append('[' + i + '].Estatus', Detalle_de_IndiciosData[i].Estatus);

        form_data.append('[' + i + '].Removed', Detalle_de_IndiciosData[i].Removed);
    }
    return form_data;
}
function Detalle_de_IndiciosInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Indicios("Detalle_de_IndiciosTable", rowIndex)) {
    var prevData = Detalle_de_IndiciosTable.fnGetData(rowIndex);
    var data = Detalle_de_IndiciosTable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Numero_de_Indicio: $('#Detalle_de_IndiciosNumero_de_Indicio').val()
        ,Nombre_de_Indicio: $('#Detalle_de_IndiciosNombre_de_Indicio').val()
        ,Descripcion_de_Indicio: $('#Detalle_de_IndiciosDescripcion_de_Indicio').val()
        ,Motivo_de_Indicio: $('#Detalle_de_IndiciosMotivo_de_Indicio').val()
        ,Diligencia: $('#Detalle_de_IndiciosDiligencia').val()
        ,Ubicacion: $('#Detalle_de_IndiciosUbicacion').val()
        ,Estatus: $('#Detalle_de_IndiciosEstatus').val()

    }

    Detalle_de_IndiciosTable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_IndiciosrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Indicios-form').modal({ show: false });
    $('#AddDetalle_de_Indicios-form').modal('hide');
    Detalle_de_IndiciosEditRow(rowIndex);
    Detalle_de_IndiciosInsertRow(rowIndex);
    //}
}
function Detalle_de_IndiciosRemoveAddRow(rowIndex) {
    Detalle_de_IndiciosTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Indicios MultiRow
//Begin Declarations for Foreigns fields for Detalle_Bitacora_de_Canalizacion_MPI MultiRow
var Detalle_Bitacora_de_Canalizacion_MPIcountRowsChecked = 0;



function GetDetalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialName(Id) {
    for (var i = 0; i < Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialItems.length; i++) {
        if (Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialItems[i].Clave == Id) {
            return Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialDropDown() {
    var Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Bitacora_de_Canalizacion_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialDropdown);
    if(Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialItems != null)
    {
       for (var i = 0; i < Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialItems.length; i++) {
           $('<option />', { value: Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialItems[i].Clave, text:    Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialItems[i].Descripcion }).appendTo(Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialDropdown);
       }
    }
    return Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialDropdown;
}
function GetDetalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorName(Id) {
    for (var i = 0; i < Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorItems.length; i++) {
        if (Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorItems[i].Clave == Id) {
            return Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorDropDown() {
    var Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_Bitacora_de_Canalizacion_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorDropdown);
    if(Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorItems != null)
    {
       for (var i = 0; i < Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorItems.length; i++) {
           $('<option />', { value: Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorItems[i].Clave, text:    Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorItems[i].Descripcion }).appendTo(Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorDropdown);
       }
    }
    return Detalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorDropdown;
}


function GetInsertDetalle_Bitacora_de_Canalizacion_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_Bitacora_de_Canalizacion_MPI_Fecha_de_Cambio_de_Estatus Fecha_de_Cambio_de_Estatus').attr('id', 'Detalle_Bitacora_de_Canalizacion_MPI_Fecha_de_Cambio_de_Estatus_' + index).attr('data-field', 'Fecha_de_Cambio_de_Estatus');
    columnData[1] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_Bitacora_de_Canalizacion_MPI_Hora_de_Cambio_de_Estatus Hora_de_Cambio_de_Estatus').attr('id', 'Detalle_Bitacora_de_Canalizacion_MPI_Hora_de_Cambio_de_Estatus_' + index).attr('data-field', 'Hora_de_Cambio_de_Estatus');
    columnData[2] = $(GetDetalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialDropDown()).addClass('Detalle_Bitacora_de_Canalizacion_MPI_Estatus_Interno Estatus_Interno').attr('id', 'Detalle_Bitacora_de_Canalizacion_MPI_Estatus_Interno_' + index).attr('data-field', 'Estatus_Interno').after($.parseHTML(addNew('Detalle_Bitacora_de_Canalizacion_MPI', 'Estatus_de_Expediente_Inicial', 'Estatus_Interno', 264842)));
    columnData[3] = $(GetDetalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorDropDown()).addClass('Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Canalizacion Estatus_de_Canalizacion').attr('id', 'Detalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Canalizacion_' + index).attr('data-field', 'Estatus_de_Canalizacion').after($.parseHTML(addNew('Detalle_Bitacora_de_Canalizacion_MPI', 'Estatus_Orientador', 'Estatus_de_Canalizacion', 264843)));


    initiateUIControls();
    return columnData;
}

function Detalle_Bitacora_de_Canalizacion_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_Bitacora_de_Canalizacion_MPI("Detalle_Bitacora_de_Canalizacion_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_Bitacora_de_Canalizacion_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_Bitacora_de_Canalizacion_MPI';
    var prevData = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetData(rowIndex);
    var data = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha_de_Cambio_de_Estatus:  data.childNodes[counter++].childNodes[0].value
        ,Hora_de_Cambio_de_Estatus:  data.childNodes[counter++].childNodes[0].value
        ,Estatus_Interno:  data.childNodes[counter++].childNodes[0].value
        ,Estatus_de_Canalizacion:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_Bitacora_de_Canalizacion_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Bitacora_de_Canalizacion_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_Bitacora_de_Canalizacion_MPITable.fnPageChange(iPage);
    Detalle_Bitacora_de_Canalizacion_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_Bitacora_de_Canalizacion_MPI("Detalle_Bitacora_de_Canalizacion_MPI_", "_" + rowIndex);
  }
}

function Detalle_Bitacora_de_Canalizacion_MPICancelRow(rowIndex) {
    var prevData = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetData(rowIndex);
    var data = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_Bitacora_de_Canalizacion_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_Bitacora_de_Canalizacion_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_Bitacora_de_Canalizacion_MPIGrid(Detalle_Bitacora_de_Canalizacion_MPITable.fnGetData());
    Detalle_Bitacora_de_Canalizacion_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_Bitacora_de_Canalizacion_MPIFromDataTable() {
    var Detalle_Bitacora_de_Canalizacion_MPIData = [];
    var gridData = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_Bitacora_de_Canalizacion_MPIData.push({
                Clave: gridData[i].Clave

                ,Fecha_de_Cambio_de_Estatus: gridData[i].Fecha_de_Cambio_de_Estatus
                ,Hora_de_Cambio_de_Estatus: gridData[i].Hora_de_Cambio_de_Estatus
                ,Estatus_Interno: gridData[i].Estatus_Interno
                ,Estatus_de_Canalizacion: gridData[i].Estatus_de_Canalizacion

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_Bitacora_de_Canalizacion_MPIData.length; i++) {
        if (removedDetalle_Bitacora_de_Canalizacion_MPIData[i] != null && removedDetalle_Bitacora_de_Canalizacion_MPIData[i].Clave > 0)
            Detalle_Bitacora_de_Canalizacion_MPIData.push({
                Clave: removedDetalle_Bitacora_de_Canalizacion_MPIData[i].Clave

                ,Fecha_de_Cambio_de_Estatus: removedDetalle_Bitacora_de_Canalizacion_MPIData[i].Fecha_de_Cambio_de_Estatus
                ,Hora_de_Cambio_de_Estatus: removedDetalle_Bitacora_de_Canalizacion_MPIData[i].Hora_de_Cambio_de_Estatus
                ,Estatus_Interno: removedDetalle_Bitacora_de_Canalizacion_MPIData[i].Estatus_Interno
                ,Estatus_de_Canalizacion: removedDetalle_Bitacora_de_Canalizacion_MPIData[i].Estatus_de_Canalizacion

                , Removed: true
            });
    }	

    return Detalle_Bitacora_de_Canalizacion_MPIData;
}

function Detalle_Bitacora_de_Canalizacion_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_Bitacora_de_Canalizacion_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_Bitacora_de_Canalizacion_MPIcountRowsChecked++;
    var Detalle_Bitacora_de_Canalizacion_MPIRowElement = "Detalle_Bitacora_de_Canalizacion_MPI_" + rowIndex.toString();
    var prevData = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_Bitacora_de_Canalizacion_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_Bitacora_de_Canalizacion_MPIGetUpdateRowControls(prevData, "Detalle_Bitacora_de_Canalizacion_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_Bitacora_de_Canalizacion_MPIRowElement + "')){ Detalle_Bitacora_de_Canalizacion_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_Bitacora_de_Canalizacion_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_Bitacora_de_Canalizacion_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_Bitacora_de_Canalizacion_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_Bitacora_de_Canalizacion_MPIValidation();
    initiateUIControls();
    $('.Detalle_Bitacora_de_Canalizacion_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_Bitacora_de_Canalizacion_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_Bitacora_de_Canalizacion_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetData().length;
    Detalle_Bitacora_de_Canalizacion_MPIfnClickAddRow();
    GetAddDetalle_Bitacora_de_Canalizacion_MPIPopup(currentRowIndex, 0);
}

function Detalle_Bitacora_de_Canalizacion_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_Bitacora_de_Canalizacion_MPIRowElement = "Detalle_Bitacora_de_Canalizacion_MPI_" + rowIndex.toString();
    var prevData = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_Bitacora_de_Canalizacion_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_Bitacora_de_Canalizacion_MPIFecha_de_Cambio_de_Estatus').val(prevData.Fecha_de_Cambio_de_Estatus);
    $('#Detalle_Bitacora_de_Canalizacion_MPIHora_de_Cambio_de_Estatus').val(prevData.Hora_de_Cambio_de_Estatus);
    $('#Detalle_Bitacora_de_Canalizacion_MPIEstatus_Interno').val(prevData.Estatus_Interno);
    $('#Detalle_Bitacora_de_Canalizacion_MPIEstatus_de_Canalizacion').val(prevData.Estatus_de_Canalizacion);

    initiateUIControls();






}

function Detalle_Bitacora_de_Canalizacion_MPIAddInsertRow() {
    if (Detalle_Bitacora_de_Canalizacion_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_Bitacora_de_Canalizacion_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Fecha_de_Cambio_de_Estatus: ""
        ,Hora_de_Cambio_de_Estatus: ""
        ,Estatus_Interno: ""
        ,Estatus_de_Canalizacion: ""

    }
}

function Detalle_Bitacora_de_Canalizacion_MPIfnClickAddRow() {
    Detalle_Bitacora_de_Canalizacion_MPIcountRowsChecked++;
    Detalle_Bitacora_de_Canalizacion_MPITable.fnAddData(Detalle_Bitacora_de_Canalizacion_MPIAddInsertRow(), true);
    Detalle_Bitacora_de_Canalizacion_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_Bitacora_de_Canalizacion_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_Bitacora_de_Canalizacion_MPIGrid tbody tr:nth-of-type(' + (Detalle_Bitacora_de_Canalizacion_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_Bitacora_de_Canalizacion_MPI("Detalle_Bitacora_de_Canalizacion_MPI_", "_" + Detalle_Bitacora_de_Canalizacion_MPIinsertRowCurrentIndex);
}

function Detalle_Bitacora_de_Canalizacion_MPIClearGridData() {
    Detalle_Bitacora_de_Canalizacion_MPIData = [];
    Detalle_Bitacora_de_Canalizacion_MPIdeletedItem = [];
    Detalle_Bitacora_de_Canalizacion_MPIDataMain = [];
    Detalle_Bitacora_de_Canalizacion_MPIDataMainPages = [];
    Detalle_Bitacora_de_Canalizacion_MPInewItemCount = 0;
    Detalle_Bitacora_de_Canalizacion_MPImaxItemIndex = 0;
    $("#Detalle_Bitacora_de_Canalizacion_MPIGrid").DataTable().clear();
    $("#Detalle_Bitacora_de_Canalizacion_MPIGrid").DataTable().destroy();
}

//Used to Get Expediente Inicial Information
function GetDetalle_Bitacora_de_Canalizacion_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_Bitacora_de_Canalizacion_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_Bitacora_de_Canalizacion_MPIData[i].Clave);

        form_data.append('[' + i + '].Fecha_de_Cambio_de_Estatus', Detalle_Bitacora_de_Canalizacion_MPIData[i].Fecha_de_Cambio_de_Estatus);
        form_data.append('[' + i + '].Hora_de_Cambio_de_Estatus', Detalle_Bitacora_de_Canalizacion_MPIData[i].Hora_de_Cambio_de_Estatus);
        form_data.append('[' + i + '].Estatus_Interno', Detalle_Bitacora_de_Canalizacion_MPIData[i].Estatus_Interno);
        form_data.append('[' + i + '].Estatus_de_Canalizacion', Detalle_Bitacora_de_Canalizacion_MPIData[i].Estatus_de_Canalizacion);

        form_data.append('[' + i + '].Removed', Detalle_Bitacora_de_Canalizacion_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_Bitacora_de_Canalizacion_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_Bitacora_de_Canalizacion_MPI("Detalle_Bitacora_de_Canalizacion_MPITable", rowIndex)) {
    var prevData = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetData(rowIndex);
    var data = Detalle_Bitacora_de_Canalizacion_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Fecha_de_Cambio_de_Estatus: $('#Detalle_Bitacora_de_Canalizacion_MPIFecha_de_Cambio_de_Estatus').val()
        ,Hora_de_Cambio_de_Estatus: $('#Detalle_Bitacora_de_Canalizacion_MPIHora_de_Cambio_de_Estatus').val()
        ,Estatus_Interno: $('#Detalle_Bitacora_de_Canalizacion_MPIEstatus_Interno').val()
        ,Estatus_de_Canalizacion: $('#Detalle_Bitacora_de_Canalizacion_MPIEstatus_de_Canalizacion').val()

    }

    Detalle_Bitacora_de_Canalizacion_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_Bitacora_de_Canalizacion_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_Bitacora_de_Canalizacion_MPI-form').modal({ show: false });
    $('#AddDetalle_Bitacora_de_Canalizacion_MPI-form').modal('hide');
    Detalle_Bitacora_de_Canalizacion_MPIEditRow(rowIndex);
    Detalle_Bitacora_de_Canalizacion_MPIInsertRow(rowIndex);
    //}
}
function Detalle_Bitacora_de_Canalizacion_MPIRemoveAddRow(rowIndex) {
    Detalle_Bitacora_de_Canalizacion_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_Bitacora_de_Canalizacion_MPI MultiRow


$(function () {
    function Detalle_de_Datos_de_la_Victima_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_Datos_de_la_Victima_MPIDataMain.length != totalCount && !Detalle_de_Datos_de_la_Victima_MPIDataMainInitialized) {
            Detalle_de_Datos_de_la_Victima_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Datos_de_la_Victima_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Datos_de_la_Victima_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Datos_de_la_Victima_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPIDataMain.length; i++) {
                if (Detalle_de_Datos_de_la_Victima_MPIDataMain[i] != null && Detalle_de_Datos_de_la_Victima_MPIDataMain[i].Id == Detalle_de_Datos_de_la_Victima_MPIdeletedItem[j]) {
                    hDetalle_de_Datos_de_la_Victima_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Datos_de_la_Victima_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPIDataMain.length; i++) {
            data[i] = Detalle_de_Datos_de_la_Victima_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_Datos_de_la_Victima_MPIgetNewResult() {
        var newData = copyMainDetalle_de_Datos_de_la_Victima_MPIArray();

        for (var i = 0; i < Detalle_de_Datos_de_la_Victima_MPIData.length; i++) {
            if (Detalle_de_Datos_de_la_Victima_MPIData[i].Removed == null || Detalle_de_Datos_de_la_Victima_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Datos_de_la_Victima_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Datos_de_la_Victima_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Datos_de_la_Victima_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Datos_de_la_Victima_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Datos_del_Imputado_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_Datos_del_Imputado_MPIDataMain.length != totalCount && !Detalle_de_Datos_del_Imputado_MPIDataMainInitialized) {
            Detalle_de_Datos_del_Imputado_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Datos_del_Imputado_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Datos_del_Imputado_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Datos_del_Imputado_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPIDataMain.length; i++) {
                if (Detalle_de_Datos_del_Imputado_MPIDataMain[i] != null && Detalle_de_Datos_del_Imputado_MPIDataMain[i].Id == Detalle_de_Datos_del_Imputado_MPIdeletedItem[j]) {
                    hDetalle_de_Datos_del_Imputado_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Datos_del_Imputado_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPIDataMain.length; i++) {
            data[i] = Detalle_de_Datos_del_Imputado_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_Datos_del_Imputado_MPIgetNewResult() {
        var newData = copyMainDetalle_de_Datos_del_Imputado_MPIArray();

        for (var i = 0; i < Detalle_de_Datos_del_Imputado_MPIData.length; i++) {
            if (Detalle_de_Datos_del_Imputado_MPIData[i].Removed == null || Detalle_de_Datos_del_Imputado_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Datos_del_Imputado_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Datos_del_Imputado_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Datos_del_Imputado_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Datos_del_Imputado_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Datos_de_Delito_MPIinitializeMainArray(totalCount) {
        if (Detalle_Datos_de_Delito_MPIDataMain.length != totalCount && !Detalle_Datos_de_Delito_MPIDataMainInitialized) {
            Detalle_Datos_de_Delito_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Datos_de_Delito_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_Datos_de_Delito_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_Datos_de_Delito_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Datos_de_Delito_MPIDataMain.length; i++) {
                if (Detalle_Datos_de_Delito_MPIDataMain[i] != null && Detalle_Datos_de_Delito_MPIDataMain[i].Id == Detalle_Datos_de_Delito_MPIdeletedItem[j]) {
                    hDetalle_Datos_de_Delito_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Datos_de_Delito_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Datos_de_Delito_MPIDataMain.length; i++) {
            data[i] = Detalle_Datos_de_Delito_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_Datos_de_Delito_MPIgetNewResult() {
        var newData = copyMainDetalle_Datos_de_Delito_MPIArray();

        for (var i = 0; i < Detalle_Datos_de_Delito_MPIData.length; i++) {
            if (Detalle_Datos_de_Delito_MPIData[i].Removed == null || Detalle_Datos_de_Delito_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Datos_de_Delito_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_Datos_de_Delito_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Datos_de_Delito_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Datos_de_Delito_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Persona_Moral_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_Persona_Moral_MPIDataMain.length != totalCount && !Detalle_de_Persona_Moral_MPIDataMainInitialized) {
            Detalle_de_Persona_Moral_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Persona_Moral_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Persona_Moral_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Persona_Moral_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Persona_Moral_MPIDataMain.length; i++) {
                if (Detalle_de_Persona_Moral_MPIDataMain[i] != null && Detalle_de_Persona_Moral_MPIDataMain[i].Id == Detalle_de_Persona_Moral_MPIdeletedItem[j]) {
                    hDetalle_de_Persona_Moral_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Persona_Moral_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Persona_Moral_MPIDataMain.length; i++) {
            data[i] = Detalle_de_Persona_Moral_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_Persona_Moral_MPIgetNewResult() {
        var newData = copyMainDetalle_de_Persona_Moral_MPIArray();

        for (var i = 0; i < Detalle_de_Persona_Moral_MPIData.length; i++) {
            if (Detalle_de_Persona_Moral_MPIData[i].Removed == null || Detalle_de_Persona_Moral_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Persona_Moral_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Persona_Moral_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Persona_Moral_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Persona_Moral_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Servicio_de_Apoyo_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_Servicio_de_Apoyo_MPIDataMain.length != totalCount && !Detalle_de_Servicio_de_Apoyo_MPIDataMainInitialized) {
            Detalle_de_Servicio_de_Apoyo_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Servicio_de_Apoyo_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Servicio_de_Apoyo_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Servicio_de_Apoyo_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Servicio_de_Apoyo_MPIDataMain.length; i++) {
                if (Detalle_de_Servicio_de_Apoyo_MPIDataMain[i] != null && Detalle_de_Servicio_de_Apoyo_MPIDataMain[i].Id == Detalle_de_Servicio_de_Apoyo_MPIdeletedItem[j]) {
                    hDetalle_de_Servicio_de_Apoyo_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Servicio_de_Apoyo_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Servicio_de_Apoyo_MPIDataMain.length; i++) {
            data[i] = Detalle_de_Servicio_de_Apoyo_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_Servicio_de_Apoyo_MPIgetNewResult() {
        var newData = copyMainDetalle_de_Servicio_de_Apoyo_MPIArray();

        for (var i = 0; i < Detalle_de_Servicio_de_Apoyo_MPIData.length; i++) {
            if (Detalle_de_Servicio_de_Apoyo_MPIData[i].Removed == null || Detalle_de_Servicio_de_Apoyo_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Servicio_de_Apoyo_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Servicio_de_Apoyo_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Servicio_de_Apoyo_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Servicio_de_Apoyo_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Datos_del_Testigo_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_Datos_del_Testigo_MPIDataMain.length != totalCount && !Detalle_de_Datos_del_Testigo_MPIDataMainInitialized) {
            Detalle_de_Datos_del_Testigo_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Datos_del_Testigo_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Datos_del_Testigo_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Datos_del_Testigo_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPIDataMain.length; i++) {
                if (Detalle_de_Datos_del_Testigo_MPIDataMain[i] != null && Detalle_de_Datos_del_Testigo_MPIDataMain[i].Id == Detalle_de_Datos_del_Testigo_MPIdeletedItem[j]) {
                    hDetalle_de_Datos_del_Testigo_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Datos_del_Testigo_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPIDataMain.length; i++) {
            data[i] = Detalle_de_Datos_del_Testigo_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_Datos_del_Testigo_MPIgetNewResult() {
        var newData = copyMainDetalle_de_Datos_del_Testigo_MPIArray();

        for (var i = 0; i < Detalle_de_Datos_del_Testigo_MPIData.length; i++) {
            if (Detalle_de_Datos_del_Testigo_MPIData[i].Removed == null || Detalle_de_Datos_del_Testigo_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Datos_del_Testigo_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Datos_del_Testigo_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Datos_del_Testigo_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Datos_del_Testigo_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Agente_del_Ministerio_PublicoinitializeMainArray(totalCount) {
        if (Detalle_de_Agente_del_Ministerio_PublicoDataMain.length != totalCount && !Detalle_de_Agente_del_Ministerio_PublicoDataMainInitialized) {
            Detalle_de_Agente_del_Ministerio_PublicoDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Agente_del_Ministerio_PublicoDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Agente_del_Ministerio_PublicoremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Agente_del_Ministerio_PublicodeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Agente_del_Ministerio_PublicoDataMain.length; i++) {
                if (Detalle_de_Agente_del_Ministerio_PublicoDataMain[i] != null && Detalle_de_Agente_del_Ministerio_PublicoDataMain[i].Id == Detalle_de_Agente_del_Ministerio_PublicodeletedItem[j]) {
                    hDetalle_de_Agente_del_Ministerio_PublicoDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Agente_del_Ministerio_PublicocopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Agente_del_Ministerio_PublicoDataMain.length; i++) {
            data[i] = Detalle_de_Agente_del_Ministerio_PublicoDataMain[i];

        }
        return data;
    }
    function Detalle_de_Agente_del_Ministerio_PublicogetNewResult() {
        var newData = copyMainDetalle_de_Agente_del_Ministerio_PublicoArray();

        for (var i = 0; i < Detalle_de_Agente_del_Ministerio_PublicoData.length; i++) {
            if (Detalle_de_Agente_del_Ministerio_PublicoData[i].Removed == null || Detalle_de_Agente_del_Ministerio_PublicoData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Agente_del_Ministerio_PublicoData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Agente_del_Ministerio_PublicopushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Agente_del_Ministerio_PublicoDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Agente_del_Ministerio_PublicoDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Servicios_PericialesinitializeMainArray(totalCount) {
        if (Detalle_de_Servicios_PericialesDataMain.length != totalCount && !Detalle_de_Servicios_PericialesDataMainInitialized) {
            Detalle_de_Servicios_PericialesDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Servicios_PericialesDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Servicios_PericialesremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Servicios_PericialesdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Servicios_PericialesDataMain.length; i++) {
                if (Detalle_de_Servicios_PericialesDataMain[i] != null && Detalle_de_Servicios_PericialesDataMain[i].Id == Detalle_de_Servicios_PericialesdeletedItem[j]) {
                    hDetalle_de_Servicios_PericialesDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Servicios_PericialescopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Servicios_PericialesDataMain.length; i++) {
            data[i] = Detalle_de_Servicios_PericialesDataMain[i];

        }
        return data;
    }
    function Detalle_de_Servicios_PericialesgetNewResult() {
        var newData = copyMainDetalle_de_Servicios_PericialesArray();

        for (var i = 0; i < Detalle_de_Servicios_PericialesData.length; i++) {
            if (Detalle_de_Servicios_PericialesData[i].Removed == null || Detalle_de_Servicios_PericialesData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Servicios_PericialesData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Servicios_PericialespushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Servicios_PericialesDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Servicios_PericialesDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Oficio_de_Servicio_PericialinitializeMainArray(totalCount) {
        if (Detalle_de_Oficio_de_Servicio_PericialDataMain.length != totalCount && !Detalle_de_Oficio_de_Servicio_PericialDataMainInitialized) {
            Detalle_de_Oficio_de_Servicio_PericialDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Oficio_de_Servicio_PericialDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Oficio_de_Servicio_PericialremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Oficio_de_Servicio_PericialdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Oficio_de_Servicio_PericialDataMain.length; i++) {
                if (Detalle_de_Oficio_de_Servicio_PericialDataMain[i] != null && Detalle_de_Oficio_de_Servicio_PericialDataMain[i].Id == Detalle_de_Oficio_de_Servicio_PericialdeletedItem[j]) {
                    hDetalle_de_Oficio_de_Servicio_PericialDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Oficio_de_Servicio_PericialcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Oficio_de_Servicio_PericialDataMain.length; i++) {
            data[i] = Detalle_de_Oficio_de_Servicio_PericialDataMain[i];

        }
        return data;
    }
    function Detalle_de_Oficio_de_Servicio_PericialgetNewResult() {
        var newData = copyMainDetalle_de_Oficio_de_Servicio_PericialArray();

        for (var i = 0; i < Detalle_de_Oficio_de_Servicio_PericialData.length; i++) {
            if (Detalle_de_Oficio_de_Servicio_PericialData[i].Removed == null || Detalle_de_Oficio_de_Servicio_PericialData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Oficio_de_Servicio_PericialData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Oficio_de_Servicio_PericialpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Oficio_de_Servicio_PericialDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Oficio_de_Servicio_PericialDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_IPH_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_IPH_MPIDataMain.length != totalCount && !Detalle_de_IPH_MPIDataMainInitialized) {
            Detalle_de_IPH_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_IPH_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_IPH_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_IPH_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_IPH_MPIDataMain.length; i++) {
                if (Detalle_de_IPH_MPIDataMain[i] != null && Detalle_de_IPH_MPIDataMain[i].Id == Detalle_de_IPH_MPIdeletedItem[j]) {
                    hDetalle_de_IPH_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_IPH_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_IPH_MPIDataMain.length; i++) {
            data[i] = Detalle_de_IPH_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_IPH_MPIgetNewResult() {
        var newData = copyMainDetalle_de_IPH_MPIArray();

        for (var i = 0; i < Detalle_de_IPH_MPIData.length; i++) {
            if (Detalle_de_IPH_MPIData[i].Removed == null || Detalle_de_IPH_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_IPH_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_IPH_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_IPH_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_IPH_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Solicitante_en_Audiencias_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_Solicitante_en_Audiencias_MPIDataMain.length != totalCount && !Detalle_de_Solicitante_en_Audiencias_MPIDataMainInitialized) {
            Detalle_de_Solicitante_en_Audiencias_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Solicitante_en_Audiencias_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Solicitante_en_Audiencias_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Solicitante_en_Audiencias_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Solicitante_en_Audiencias_MPIDataMain.length; i++) {
                if (Detalle_de_Solicitante_en_Audiencias_MPIDataMain[i] != null && Detalle_de_Solicitante_en_Audiencias_MPIDataMain[i].Id == Detalle_de_Solicitante_en_Audiencias_MPIdeletedItem[j]) {
                    hDetalle_de_Solicitante_en_Audiencias_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Solicitante_en_Audiencias_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Solicitante_en_Audiencias_MPIDataMain.length; i++) {
            data[i] = Detalle_de_Solicitante_en_Audiencias_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_Solicitante_en_Audiencias_MPIgetNewResult() {
        var newData = copyMainDetalle_de_Solicitante_en_Audiencias_MPIArray();

        for (var i = 0; i < Detalle_de_Solicitante_en_Audiencias_MPIData.length; i++) {
            if (Detalle_de_Solicitante_en_Audiencias_MPIData[i].Removed == null || Detalle_de_Solicitante_en_Audiencias_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Solicitante_en_Audiencias_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Solicitante_en_Audiencias_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Solicitante_en_Audiencias_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Solicitante_en_Audiencias_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Requerido_en_Audiencias_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_Requerido_en_Audiencias_MPIDataMain.length != totalCount && !Detalle_de_Requerido_en_Audiencias_MPIDataMainInitialized) {
            Detalle_de_Requerido_en_Audiencias_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Requerido_en_Audiencias_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Requerido_en_Audiencias_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Requerido_en_Audiencias_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Requerido_en_Audiencias_MPIDataMain.length; i++) {
                if (Detalle_de_Requerido_en_Audiencias_MPIDataMain[i] != null && Detalle_de_Requerido_en_Audiencias_MPIDataMain[i].Id == Detalle_de_Requerido_en_Audiencias_MPIdeletedItem[j]) {
                    hDetalle_de_Requerido_en_Audiencias_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Requerido_en_Audiencias_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Requerido_en_Audiencias_MPIDataMain.length; i++) {
            data[i] = Detalle_de_Requerido_en_Audiencias_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_Requerido_en_Audiencias_MPIgetNewResult() {
        var newData = copyMainDetalle_de_Requerido_en_Audiencias_MPIArray();

        for (var i = 0; i < Detalle_de_Requerido_en_Audiencias_MPIData.length; i++) {
            if (Detalle_de_Requerido_en_Audiencias_MPIData[i].Removed == null || Detalle_de_Requerido_en_Audiencias_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Requerido_en_Audiencias_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Requerido_en_Audiencias_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Requerido_en_Audiencias_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Requerido_en_Audiencias_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Citatorio_AudienciasinitializeMainArray(totalCount) {
        if (Detalle_de_Citatorio_AudienciasDataMain.length != totalCount && !Detalle_de_Citatorio_AudienciasDataMainInitialized) {
            Detalle_de_Citatorio_AudienciasDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Citatorio_AudienciasDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Citatorio_AudienciasremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Citatorio_AudienciasdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Citatorio_AudienciasDataMain.length; i++) {
                if (Detalle_de_Citatorio_AudienciasDataMain[i] != null && Detalle_de_Citatorio_AudienciasDataMain[i].Id == Detalle_de_Citatorio_AudienciasdeletedItem[j]) {
                    hDetalle_de_Citatorio_AudienciasDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Citatorio_AudienciascopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Citatorio_AudienciasDataMain.length; i++) {
            data[i] = Detalle_de_Citatorio_AudienciasDataMain[i];

        }
        return data;
    }
    function Detalle_de_Citatorio_AudienciasgetNewResult() {
        var newData = copyMainDetalle_de_Citatorio_AudienciasArray();

        for (var i = 0; i < Detalle_de_Citatorio_AudienciasData.length; i++) {
            if (Detalle_de_Citatorio_AudienciasData[i].Removed == null || Detalle_de_Citatorio_AudienciasData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Citatorio_AudienciasData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Citatorio_AudienciaspushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Citatorio_AudienciasDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Citatorio_AudienciasDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Documentos_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_Documentos_MPIDataMain.length != totalCount && !Detalle_de_Documentos_MPIDataMainInitialized) {
            Detalle_de_Documentos_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Documentos_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Documentos_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Documentos_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Documentos_MPIDataMain.length; i++) {
                if (Detalle_de_Documentos_MPIDataMain[i] != null && Detalle_de_Documentos_MPIDataMain[i].Id == Detalle_de_Documentos_MPIdeletedItem[j]) {
                    hDetalle_de_Documentos_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Documentos_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Documentos_MPIDataMain.length; i++) {
            data[i] = Detalle_de_Documentos_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_Documentos_MPIgetNewResult() {
        var newData = copyMainDetalle_de_Documentos_MPIArray();

        for (var i = 0; i < Detalle_de_Documentos_MPIData.length; i++) {
            if (Detalle_de_Documentos_MPIData[i].Removed == null || Detalle_de_Documentos_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Documentos_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Documentos_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Documentos_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Documentos_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Coincidencias_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_Coincidencias_MPIDataMain.length != totalCount && !Detalle_de_Coincidencias_MPIDataMainInitialized) {
            Detalle_de_Coincidencias_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Coincidencias_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Coincidencias_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Coincidencias_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Coincidencias_MPIDataMain.length; i++) {
                if (Detalle_de_Coincidencias_MPIDataMain[i] != null && Detalle_de_Coincidencias_MPIDataMain[i].Id == Detalle_de_Coincidencias_MPIdeletedItem[j]) {
                    hDetalle_de_Coincidencias_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Coincidencias_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Coincidencias_MPIDataMain.length; i++) {
            data[i] = Detalle_de_Coincidencias_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_Coincidencias_MPIgetNewResult() {
        var newData = copyMainDetalle_de_Coincidencias_MPIArray();

        for (var i = 0; i < Detalle_de_Coincidencias_MPIData.length; i++) {
            if (Detalle_de_Coincidencias_MPIData[i].Removed == null || Detalle_de_Coincidencias_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Coincidencias_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Coincidencias_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Coincidencias_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Coincidencias_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_IndiciosinitializeMainArray(totalCount) {
        if (Detalle_de_IndiciosDataMain.length != totalCount && !Detalle_de_IndiciosDataMainInitialized) {
            Detalle_de_IndiciosDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_IndiciosDataMain[i] = null;
            }
        }
    }
    function Detalle_de_IndiciosremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_IndiciosdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_IndiciosDataMain.length; i++) {
                if (Detalle_de_IndiciosDataMain[i] != null && Detalle_de_IndiciosDataMain[i].Id == Detalle_de_IndiciosdeletedItem[j]) {
                    hDetalle_de_IndiciosDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_IndicioscopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_IndiciosDataMain.length; i++) {
            data[i] = Detalle_de_IndiciosDataMain[i];

        }
        return data;
    }
    function Detalle_de_IndiciosgetNewResult() {
        var newData = copyMainDetalle_de_IndiciosArray();

        for (var i = 0; i < Detalle_de_IndiciosData.length; i++) {
            if (Detalle_de_IndiciosData[i].Removed == null || Detalle_de_IndiciosData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_IndiciosData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_IndiciospushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_IndiciosDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_IndiciosDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_Bitacora_de_Canalizacion_MPIinitializeMainArray(totalCount) {
        if (Detalle_Bitacora_de_Canalizacion_MPIDataMain.length != totalCount && !Detalle_Bitacora_de_Canalizacion_MPIDataMainInitialized) {
            Detalle_Bitacora_de_Canalizacion_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_Bitacora_de_Canalizacion_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_Bitacora_de_Canalizacion_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_Bitacora_de_Canalizacion_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_Bitacora_de_Canalizacion_MPIDataMain.length; i++) {
                if (Detalle_Bitacora_de_Canalizacion_MPIDataMain[i] != null && Detalle_Bitacora_de_Canalizacion_MPIDataMain[i].Id == Detalle_Bitacora_de_Canalizacion_MPIdeletedItem[j]) {
                    hDetalle_Bitacora_de_Canalizacion_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_Bitacora_de_Canalizacion_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_Bitacora_de_Canalizacion_MPIDataMain.length; i++) {
            data[i] = Detalle_Bitacora_de_Canalizacion_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_Bitacora_de_Canalizacion_MPIgetNewResult() {
        var newData = copyMainDetalle_Bitacora_de_Canalizacion_MPIArray();

        for (var i = 0; i < Detalle_Bitacora_de_Canalizacion_MPIData.length; i++) {
            if (Detalle_Bitacora_de_Canalizacion_MPIData[i].Removed == null || Detalle_Bitacora_de_Canalizacion_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_Bitacora_de_Canalizacion_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_Bitacora_de_Canalizacion_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_Bitacora_de_Canalizacion_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_Bitacora_de_Canalizacion_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompleteExpediente_Inicial_Usuario_que_Registra_Spartan_UserData(data) {
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

//Grid GetAutocomplete

//Grid GetAutocomplete

var AutoCompletePais_de_los_Hechos_MPIData = [];
function GetAutoCompleteExpediente_Inicial_Pais_de_los_Hechos_MPI_PaisData(data) {
	AutoCompletePais_de_los_Hechos_MPIData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompletePais_de_los_Hechos_MPIData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompletePais_de_los_Hechos_MPIData;
}
var AutoCompleteEstado_de_los_Hechos_MPIData = [];
function GetAutoCompleteExpediente_Inicial_Estado_de_los_Hechos_MPI_EstadoData(data) {
	AutoCompleteEstado_de_los_Hechos_MPIData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_de_los_Hechos_MPIData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_de_los_Hechos_MPIData;
}
var AutoCompleteMunicipio_de_los_Hechos_MPIData = [];
function GetAutoCompleteExpediente_Inicial_Municipio_de_los_Hechos_MPI_MunicipioData(data) {
	AutoCompleteMunicipio_de_los_Hechos_MPIData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio_de_los_Hechos_MPIData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio_de_los_Hechos_MPIData;
}
var AutoCompleteColonia_de_los_Hechos_MPIData = [];
function GetAutoCompleteExpediente_Inicial_Colonia_de_los_Hechos_MPI_ColoniaData(data) {
	AutoCompleteColonia_de_los_Hechos_MPIData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia_de_los_Hechos_MPIData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia_de_los_Hechos_MPIData;
}
//Grid GetAutocomplete

//Grid GetAutocomplete

//Grid GetAutocomplete

var AutoCompleteNombre_de_Agente_del_Ministerio_PublicoData = [];
function GetAutoCompleteExpediente_Inicial_Nombre_de_Agente_del_Ministerio_Publico_Spartan_UserData(data) {
	AutoCompleteNombre_de_Agente_del_Ministerio_PublicoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteNombre_de_Agente_del_Ministerio_PublicoData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteNombre_de_Agente_del_Ministerio_PublicoData;
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



function getDropdown(elementKey) {
    var labelSelect = $("#Expediente_Inicial_cmbLabelSelect").val();
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
    $('#CreateExpediente_Inicial')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_de_Datos_de_la_Victima_MPIClearGridData();
                Detalle_de_Datos_del_Imputado_MPIClearGridData();
                Detalle_Datos_de_Delito_MPIClearGridData();
    $('#Pais_de_los_Hechos_MPI').empty();
    $("#Pais_de_los_Hechos_MPI").append('<option value=""></option>');
    $('#Pais_de_los_Hechos_MPI').val('0').trigger('change');
    $('#Estado_de_los_Hechos_MPI').empty();
    $("#Estado_de_los_Hechos_MPI").append('<option value=""></option>');
    $('#Estado_de_los_Hechos_MPI').val('0').trigger('change');
    $('#Municipio_de_los_Hechos_MPI').empty();
    $("#Municipio_de_los_Hechos_MPI").append('<option value=""></option>');
    $('#Municipio_de_los_Hechos_MPI').val('0').trigger('change');
    $('#Colonia_de_los_Hechos_MPI').empty();
    $("#Colonia_de_los_Hechos_MPI").append('<option value=""></option>');
    $('#Colonia_de_los_Hechos_MPI').val('0').trigger('change');
                Detalle_de_Persona_Moral_MPIClearGridData();
                Detalle_de_Servicio_de_Apoyo_MPIClearGridData();
                Detalle_de_Datos_del_Testigo_MPIClearGridData();
    $('#Nombre_de_Agente_del_Ministerio_Publico').empty();
    $("#Nombre_de_Agente_del_Ministerio_Publico").append('<option value=""></option>');
    $('#Nombre_de_Agente_del_Ministerio_Publico').val('0').trigger('change');
                Detalle_de_Agente_del_Ministerio_PublicoClearGridData();
                Detalle_de_Servicios_PericialesClearGridData();
                Detalle_de_Oficio_de_Servicio_PericialClearGridData();
                Detalle_de_IPH_MPIClearGridData();
                Detalle_de_Solicitante_en_Audiencias_MPIClearGridData();
                Detalle_de_Requerido_en_Audiencias_MPIClearGridData();
                Detalle_de_Citatorio_AudienciasClearGridData();
                Detalle_de_Documentos_MPIClearGridData();
                Detalle_de_Coincidencias_MPIClearGridData();
                Detalle_de_IndiciosClearGridData();
                Detalle_Bitacora_de_Canalizacion_MPIClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateExpediente_Inicial').trigger('reset');
    $('#CreateExpediente_Inicial').find(':input').each(function () {
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
    var $myForm = $('#CreateExpediente_Inicial');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_de_Datos_de_la_Victima_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Datos_de_la_Victima_MPI();
        return false;
    }
    if (Detalle_de_Datos_del_Imputado_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Datos_del_Imputado_MPI();
        return false;
    }
    if (Detalle_Datos_de_Delito_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Datos_de_Delito_MPI();
        return false;
    }
    if (Detalle_de_Persona_Moral_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Persona_Moral_MPI();
        return false;
    }
    if (Detalle_de_Servicio_de_Apoyo_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Servicio_de_Apoyo_MPI();
        return false;
    }
    if (Detalle_de_Datos_del_Testigo_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Datos_del_Testigo_MPI();
        return false;
    }
    if (Detalle_de_Agente_del_Ministerio_PublicocountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Agente_del_Ministerio_Publico();
        return false;
    }
    if (Detalle_de_Servicios_PericialescountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Servicios_Periciales();
        return false;
    }
    if (Detalle_de_Oficio_de_Servicio_PericialcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Oficio_de_Servicio_Pericial();
        return false;
    }
    if (Detalle_de_IPH_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_IPH_MPI();
        return false;
    }
    if (Detalle_de_Solicitante_en_Audiencias_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Solicitante_en_Audiencias_MPI();
        return false;
    }
    if (Detalle_de_Requerido_en_Audiencias_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Requerido_en_Audiencias_MPI();
        return false;
    }
    if (Detalle_de_Citatorio_AudienciascountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Citatorio_Audiencias();
        return false;
    }
    if (Detalle_de_Documentos_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Documentos_MPI();
        return false;
    }
    if (Detalle_de_Coincidencias_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Coincidencias_MPI();
        return false;
    }
    if (Detalle_de_IndicioscountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Indicios();
        return false;
    }
    if (Detalle_Bitacora_de_Canalizacion_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_Bitacora_de_Canalizacion_MPI();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateExpediente_Inicial").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateExpediente_Inicial").on('click', '#Expediente_InicialCancelar', function () {
	  if (!isPartial) {
        Expediente_InicialBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateExpediente_Inicial").on('click', '#Expediente_InicialGuardar', function () {
		$('#Expediente_InicialGuardar').attr('disabled', true);
		$('#Expediente_InicialGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendExpediente_InicialData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Expediente_InicialBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Expediente_InicialGuardar').removeAttr('disabled');
                        $('#Expediente_InicialGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Expediente_Inicial', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Expediente_InicialItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Expediente_InicialDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Expediente_InicialGuardar').removeAttr('disabled');
					$('#Expediente_InicialGuardar').bind()
				}
		}
		else {
			$('#Expediente_InicialGuardar').removeAttr('disabled');
			$('#Expediente_InicialGuardar').bind()
		}
    });
	$("form#CreateExpediente_Inicial").on('click', '#Expediente_InicialGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendExpediente_InicialData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_de_Datos_de_la_Victima_MPIData();
                getDetalle_de_Datos_del_Imputado_MPIData();
                getDetalle_Datos_de_Delito_MPIData();
                getDetalle_de_Persona_Moral_MPIData();
                getDetalle_de_Servicio_de_Apoyo_MPIData();
                getDetalle_de_Datos_del_Testigo_MPIData();
                getDetalle_de_Agente_del_Ministerio_PublicoData();
                getDetalle_de_Servicios_PericialesData();
                getDetalle_de_Oficio_de_Servicio_PericialData();
                getDetalle_de_IPH_MPIData();
                getDetalle_de_Solicitante_en_Audiencias_MPIData();
                getDetalle_de_Requerido_en_Audiencias_MPIData();
                getDetalle_de_Citatorio_AudienciasData();
                getDetalle_de_Documentos_MPIData();
                getDetalle_de_Coincidencias_MPIData();
                getDetalle_de_IndiciosData();
                getDetalle_Bitacora_de_Canalizacion_MPIData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Expediente_Inicial', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Expediente_InicialItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Expediente_InicialDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateExpediente_Inicial").on('click', '#Expediente_InicialGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendExpediente_InicialData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
                Detalle_de_Datos_de_la_Victima_MPIClearGridData();
                Detalle_de_Datos_del_Imputado_MPIClearGridData();
                Detalle_Datos_de_Delito_MPIClearGridData();
    $('#Pais_de_los_Hechos_MPI').empty();
    $("#Pais_de_los_Hechos_MPI").append('<option value=""></option>');
    $('#Pais_de_los_Hechos_MPI').val('0').trigger('change');
    $('#Estado_de_los_Hechos_MPI').empty();
    $("#Estado_de_los_Hechos_MPI").append('<option value=""></option>');
    $('#Estado_de_los_Hechos_MPI').val('0').trigger('change');
    $('#Municipio_de_los_Hechos_MPI').empty();
    $("#Municipio_de_los_Hechos_MPI").append('<option value=""></option>');
    $('#Municipio_de_los_Hechos_MPI').val('0').trigger('change');
    $('#Colonia_de_los_Hechos_MPI').empty();
    $("#Colonia_de_los_Hechos_MPI").append('<option value=""></option>');
    $('#Colonia_de_los_Hechos_MPI').val('0').trigger('change');
                Detalle_de_Persona_Moral_MPIClearGridData();
                Detalle_de_Servicio_de_Apoyo_MPIClearGridData();
                Detalle_de_Datos_del_Testigo_MPIClearGridData();
    $('#Nombre_de_Agente_del_Ministerio_Publico').empty();
    $("#Nombre_de_Agente_del_Ministerio_Publico").append('<option value=""></option>');
    $('#Nombre_de_Agente_del_Ministerio_Publico').val('0').trigger('change');
                Detalle_de_Agente_del_Ministerio_PublicoClearGridData();
                Detalle_de_Servicios_PericialesClearGridData();
                Detalle_de_Oficio_de_Servicio_PericialClearGridData();
                Detalle_de_IPH_MPIClearGridData();
                Detalle_de_Solicitante_en_Audiencias_MPIClearGridData();
                Detalle_de_Requerido_en_Audiencias_MPIClearGridData();
                Detalle_de_Citatorio_AudienciasClearGridData();
                Detalle_de_Documentos_MPIClearGridData();
                Detalle_de_Coincidencias_MPIClearGridData();
                Detalle_de_IndiciosClearGridData();
                Detalle_Bitacora_de_Canalizacion_MPIClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_de_Datos_de_la_Victima_MPIData();
                getDetalle_de_Datos_del_Imputado_MPIData();
                getDetalle_Datos_de_Delito_MPIData();
                getDetalle_de_Persona_Moral_MPIData();
                getDetalle_de_Servicio_de_Apoyo_MPIData();
                getDetalle_de_Datos_del_Testigo_MPIData();
                getDetalle_de_Agente_del_Ministerio_PublicoData();
                getDetalle_de_Servicios_PericialesData();
                getDetalle_de_Oficio_de_Servicio_PericialData();
                getDetalle_de_IPH_MPIData();
                getDetalle_de_Solicitante_en_Audiencias_MPIData();
                getDetalle_de_Requerido_en_Audiencias_MPIData();
                getDetalle_de_Citatorio_AudienciasData();
                getDetalle_de_Documentos_MPIData();
                getDetalle_de_Coincidencias_MPIData();
                getDetalle_de_IndiciosData();
                getDetalle_Bitacora_de_Canalizacion_MPIData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Expediente_Inicial',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Expediente_InicialItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Expediente_InicialDropDown().get(0)').innerHTML);                          
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



var Expediente_InicialisdisplayBusinessPropery = false;
Expediente_InicialDisplayBusinessRuleButtons(Expediente_InicialisdisplayBusinessPropery);
function Expediente_InicialDisplayBusinessRule() {
    if (!Expediente_InicialisdisplayBusinessPropery) {
        $('#CreateExpediente_Inicial').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Expediente_InicialdisplayBusinessPropery"><button onclick="Expediente_InicialGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Expediente_InicialBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Expediente_InicialdisplayBusinessPropery').remove();
    }
    Expediente_InicialDisplayBusinessRuleButtons(!Expediente_InicialisdisplayBusinessPropery);
    Expediente_InicialisdisplayBusinessPropery = (Expediente_InicialisdisplayBusinessPropery ? false : true);
}
function Expediente_InicialDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

