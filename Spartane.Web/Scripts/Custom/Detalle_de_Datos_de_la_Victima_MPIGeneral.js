

//Begin Declarations for Foreigns fields for Detalle_del_Abogado_Victima_MPI MultiRow
var Detalle_del_Abogado_Victima_MPIcountRowsChecked = 0;

function GetDetalle_del_Abogado_Victima_MPI_AbogadoName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_AbogadoItems.length; i++) {
        if (Detalle_del_Abogado_Victima_MPI_AbogadoItems[i].Clave == Id) {
            return Detalle_del_Abogado_Victima_MPI_AbogadoItems[i].Nombre_Completo;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Victima_MPI_AbogadoDropDown() {
    var Detalle_del_Abogado_Victima_MPI_AbogadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Victima_MPI_AbogadoDropdown);
    if(Detalle_del_Abogado_Victima_MPI_AbogadoItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_AbogadoItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Victima_MPI_AbogadoItems[i].Clave, text:    Detalle_del_Abogado_Victima_MPI_AbogadoItems[i].Nombre_Completo }).appendTo(Detalle_del_Abogado_Victima_MPI_AbogadoDropdown);
       }
    }
    return Detalle_del_Abogado_Victima_MPI_AbogadoDropdown;
}





function GetDetalle_del_Abogado_Victima_MPI_GeneroName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_GeneroItems.length; i++) {
        if (Detalle_del_Abogado_Victima_MPI_GeneroItems[i].Clave == Id) {
            return Detalle_del_Abogado_Victima_MPI_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Victima_MPI_GeneroDropDown() {
    var Detalle_del_Abogado_Victima_MPI_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Victima_MPI_GeneroDropdown);
    if(Detalle_del_Abogado_Victima_MPI_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Victima_MPI_GeneroItems[i].Clave, text:    Detalle_del_Abogado_Victima_MPI_GeneroItems[i].Descripcion }).appendTo(Detalle_del_Abogado_Victima_MPI_GeneroDropdown);
       }
    }
    return Detalle_del_Abogado_Victima_MPI_GeneroDropdown;
}
function GetDetalle_del_Abogado_Victima_MPI_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_Estado_CivilItems.length; i++) {
        if (Detalle_del_Abogado_Victima_MPI_Estado_CivilItems[i].Clave == Id) {
            return Detalle_del_Abogado_Victima_MPI_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Victima_MPI_Estado_CivilDropDown() {
    var Detalle_del_Abogado_Victima_MPI_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Victima_MPI_Estado_CivilDropdown);
    if(Detalle_del_Abogado_Victima_MPI_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Victima_MPI_Estado_CivilItems[i].Clave, text:    Detalle_del_Abogado_Victima_MPI_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_del_Abogado_Victima_MPI_Estado_CivilDropdown);
       }
    }
    return Detalle_del_Abogado_Victima_MPI_Estado_CivilDropdown;
}
function GetDetalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionDropDown() {
    var Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionDropdown);
    if(Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionDropdown;
}

function GetDetalle_del_Abogado_Victima_MPI_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_NacionalidadItems.length; i++) {
        if (Detalle_del_Abogado_Victima_MPI_NacionalidadItems[i].Clave == Id) {
            return Detalle_del_Abogado_Victima_MPI_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Victima_MPI_NacionalidadDropDown() {
    var Detalle_del_Abogado_Victima_MPI_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Victima_MPI_NacionalidadDropdown);
    if(Detalle_del_Abogado_Victima_MPI_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Victima_MPI_NacionalidadItems[i].Clave, text:    Detalle_del_Abogado_Victima_MPI_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_del_Abogado_Victima_MPI_NacionalidadDropdown);
       }
    }
    return Detalle_del_Abogado_Victima_MPI_NacionalidadDropdown;
}

function GetDetalle_del_Abogado_Victima_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_PaisItems.length; i++) {
        if (Detalle_del_Abogado_Victima_MPI_PaisItems[i].Clave == Id) {
            return Detalle_del_Abogado_Victima_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Victima_MPI_PaisDropDown() {
    var Detalle_del_Abogado_Victima_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Victima_MPI_PaisDropdown);
    if(Detalle_del_Abogado_Victima_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Victima_MPI_PaisItems[i].Clave, text:    Detalle_del_Abogado_Victima_MPI_PaisItems[i].Nombre }).appendTo(Detalle_del_Abogado_Victima_MPI_PaisDropdown);
       }
    }
    return Detalle_del_Abogado_Victima_MPI_PaisDropdown;
}
function GetDetalle_del_Abogado_Victima_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_EstadoItems.length; i++) {
        if (Detalle_del_Abogado_Victima_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_del_Abogado_Victima_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Victima_MPI_EstadoDropDown() {
    var Detalle_del_Abogado_Victima_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Victima_MPI_EstadoDropdown);
    if(Detalle_del_Abogado_Victima_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Victima_MPI_EstadoItems[i].Clave, text:    Detalle_del_Abogado_Victima_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_del_Abogado_Victima_MPI_EstadoDropdown);
       }
    }
    return Detalle_del_Abogado_Victima_MPI_EstadoDropdown;
}
function GetDetalle_del_Abogado_Victima_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_MunicipioItems.length; i++) {
        if (Detalle_del_Abogado_Victima_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_del_Abogado_Victima_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Victima_MPI_MunicipioDropDown() {
    var Detalle_del_Abogado_Victima_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Victima_MPI_MunicipioDropdown);
    if(Detalle_del_Abogado_Victima_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Victima_MPI_MunicipioItems[i].Clave, text:    Detalle_del_Abogado_Victima_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_del_Abogado_Victima_MPI_MunicipioDropdown);
       }
    }
    return Detalle_del_Abogado_Victima_MPI_MunicipioDropdown;
}
function GetDetalle_del_Abogado_Victima_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_ColoniaItems.length; i++) {
        if (Detalle_del_Abogado_Victima_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_del_Abogado_Victima_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Victima_MPI_ColoniaDropDown() {
    var Detalle_del_Abogado_Victima_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Victima_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Victima_MPI_ColoniaDropdown);
    if(Detalle_del_Abogado_Victima_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Victima_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Victima_MPI_ColoniaItems[i].Clave, text:    Detalle_del_Abogado_Victima_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_del_Abogado_Victima_MPI_ColoniaDropdown);
       }
    }
    return Detalle_del_Abogado_Victima_MPI_ColoniaDropdown;
}










function GetInsertDetalle_del_Abogado_Victima_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_del_Abogado_Victima_MPI_AbogadoDropDown()).addClass('Detalle_del_Abogado_Victima_MPI_Nombre_Completo_del_Abogado_Victima Nombre_Completo_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Nombre_Completo_del_Abogado_Victima_' + index).attr('data-field', 'Nombre_Completo_del_Abogado_Victima').after($.parseHTML(addNew('Detalle_del_Abogado_Victima_MPI', 'Abogado', 'Nombre_Completo_del_Abogado_Victima', 264702)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Nombre_del_Abogado_Victima Nombre_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Nombre_del_Abogado_Victima_' + index).attr('data-field', 'Nombre_del_Abogado_Victima');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Apellido_Paterno_del_Abogado_Victima Apellido_Paterno_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Apellido_Paterno_del_Abogado_Victima_' + index).attr('data-field', 'Apellido_Paterno_del_Abogado_Victima');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Apellido_Materno_del_Abogado_Victima Apellido_Materno_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Apellido_Materno_del_Abogado_Victima_' + index).attr('data-field', 'Apellido_Materno_del_Abogado_Victima');
    columnData[4] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_del_Abogado_Victima_MPI_Fecha_de_Nacimiento_del_Abogado_Victima Fecha_de_Nacimiento_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Fecha_de_Nacimiento_del_Abogado_Victima_' + index).attr('data-field', 'Fecha_de_Nacimiento_del_Abogado_Victima');
    columnData[5] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_del_Abogado_Victima_MPI_Edad_del_Abogado_Victima Edad_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Edad_del_Abogado_Victima_' + index).attr('data-field', 'Edad_del_Abogado_Victima');
    columnData[6] = $(GetDetalle_del_Abogado_Victima_MPI_GeneroDropDown()).addClass('Detalle_del_Abogado_Victima_MPI_Sexo_del_Abogado_Victima Sexo_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Sexo_del_Abogado_Victima_' + index).attr('data-field', 'Sexo_del_Abogado_Victima').after($.parseHTML(addNew('Detalle_del_Abogado_Victima_MPI', 'Genero', 'Sexo_del_Abogado_Victima', 264708)));
    columnData[7] = $(GetDetalle_del_Abogado_Victima_MPI_Estado_CivilDropDown()).addClass('Detalle_del_Abogado_Victima_MPI_Estado_Civil_del_Abogado_Victima Estado_Civil_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Estado_Civil_del_Abogado_Victima_' + index).attr('data-field', 'Estado_Civil_del_Abogado_Victima').after($.parseHTML(addNew('Detalle_del_Abogado_Victima_MPI', 'Estado_Civil', 'Estado_Civil_del_Abogado_Victima', 264709)));
    columnData[8] = $(GetDetalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionDropDown()).addClass('Detalle_del_Abogado_Victima_MPI_Tipo_de_Identificacion_Abogado_Victima Tipo_de_Identificacion_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Tipo_de_Identificacion_Abogado_Victima_' + index).attr('data-field', 'Tipo_de_Identificacion_Abogado_Victima').after($.parseHTML(addNew('Detalle_del_Abogado_Victima_MPI', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion_Abogado_Victima', 264710)));
    columnData[9] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Numero_de_Identificacion_Abogado_Victima Numero_de_Identificacion_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Numero_de_Identificacion_Abogado_Victima_' + index).attr('data-field', 'Numero_de_Identificacion_Abogado_Victima');
    columnData[10] = $(GetDetalle_del_Abogado_Victima_MPI_NacionalidadDropDown()).addClass('Detalle_del_Abogado_Victima_MPI_Nacionalidad_del_Abogado_Victima Nacionalidad_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Nacionalidad_del_Abogado_Victima_' + index).attr('data-field', 'Nacionalidad_del_Abogado_Victima').after($.parseHTML(addNew('Detalle_del_Abogado_Victima_MPI', 'Nacionalidad', 'Nacionalidad_del_Abogado_Victima', 264712)));
    columnData[11] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Cedula_Profesional_del_Abogado_Victima Cedula_Profesional_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Cedula_Profesional_del_Abogado_Victima_' + index).attr('data-field', 'Cedula_Profesional_del_Abogado_Victima');
    columnData[12] = $(GetDetalle_del_Abogado_Victima_MPI_PaisDropDown()).addClass('Detalle_del_Abogado_Victima_MPI_Pais_del_Abogado_Victima Pais_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Pais_del_Abogado_Victima_' + index).attr('data-field', 'Pais_del_Abogado_Victima').after($.parseHTML(addNew('Detalle_del_Abogado_Victima_MPI', 'Pais', 'Pais_del_Abogado_Victima', 264714)));
    columnData[13] = $(GetDetalle_del_Abogado_Victima_MPI_EstadoDropDown()).addClass('Detalle_del_Abogado_Victima_MPI_Estado_del_Abogado_Victima Estado_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Estado_del_Abogado_Victima_' + index).attr('data-field', 'Estado_del_Abogado_Victima').after($.parseHTML(addNew('Detalle_del_Abogado_Victima_MPI', 'Estado', 'Estado_del_Abogado_Victima', 264715)));
    columnData[14] = $(GetDetalle_del_Abogado_Victima_MPI_MunicipioDropDown()).addClass('Detalle_del_Abogado_Victima_MPI_Municipio_del_Abogado_Victima Municipio_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Municipio_del_Abogado_Victima_' + index).attr('data-field', 'Municipio_del_Abogado_Victima').after($.parseHTML(addNew('Detalle_del_Abogado_Victima_MPI', 'Municipio', 'Municipio_del_Abogado_Victima', 264716)));
    columnData[15] = $(GetDetalle_del_Abogado_Victima_MPI_ColoniaDropDown()).addClass('Detalle_del_Abogado_Victima_MPI_Colonia_del_Abogado_Victima Colonia_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Colonia_del_Abogado_Victima_' + index).attr('data-field', 'Colonia_del_Abogado_Victima').after($.parseHTML(addNew('Detalle_del_Abogado_Victima_MPI', 'Colonia', 'Colonia_del_Abogado_Victima', 264717)));
    columnData[16] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_del_Abogado_Victima_MPI_Codigo_Postal_del_Abogado_Victima Codigo_Postal_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Codigo_Postal_del_Abogado_Victima_' + index).attr('data-field', 'Codigo_Postal_del_Abogado_Victima');
    columnData[17] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Calle_del_Abogado_Victima Calle_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Calle_del_Abogado_Victima_' + index).attr('data-field', 'Calle_del_Abogado_Victima');
    columnData[18] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Numero_Exterior_del_Abogado_Victima Numero_Exterior_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Numero_Exterior_del_Abogado_Victima_' + index).attr('data-field', 'Numero_Exterior_del_Abogado_Victima');
    columnData[19] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Numero_Interior_del_Abogado_Victima Numero_Interior_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Numero_Interior_del_Abogado_Victima_' + index).attr('data-field', 'Numero_Interior_del_Abogado_Victima');
    columnData[20] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Telefono_del_Abogado_Victima Telefono_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Telefono_del_Abogado_Victima_' + index).attr('data-field', 'Telefono_del_Abogado_Victima');
    columnData[21] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Celular_del_Abogado_Victima Celular_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Celular_del_Abogado_Victima_' + index).attr('data-field', 'Celular_del_Abogado_Victima');
    columnData[22] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Victima_MPI_Correo_Electronico_del_Abogado_Victima Correo_Electronico_del_Abogado_Victima').attr('id', 'Detalle_del_Abogado_Victima_MPI_Correo_Electronico_del_Abogado_Victima_' + index).attr('data-field', 'Correo_Electronico_del_Abogado_Victima');
    columnData[23] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_del_Abogado_Victima_MPI_Aceptar_Notificaciones Aceptar_Notificaciones').attr('id', 'Detalle_del_Abogado_Victima_MPI_Aceptar_Notificaciones_' + index).attr('data-field', 'Aceptar_Notificaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_del_Abogado_Victima_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_del_Abogado_Victima_MPI("Detalle_del_Abogado_Victima_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_del_Abogado_Victima_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_del_Abogado_Victima_MPI';
    var prevData = Detalle_del_Abogado_Victima_MPITable.fnGetData(rowIndex);
    var data = Detalle_del_Abogado_Victima_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Consecutivo_Victima: prevData.Consecutivo_Victima,
        IsInsertRow: false

        ,Nombre_Completo_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Nacimiento_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Edad_del_Abogado_Victima: data.childNodes[counter++].childNodes[0].value
        ,Sexo_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Cedula_Profesional_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Pais_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Estado_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Municipio_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Colonia_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal_del_Abogado_Victima: data.childNodes[counter++].childNodes[0].value
        ,Calle_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Telefono_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Celular_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico_del_Abogado_Victima:  data.childNodes[counter++].childNodes[0].value
        ,Aceptar_Notificaciones: $(data.childNodes[counter++].childNodes[2]).is(':checked')

    }
    Detalle_del_Abogado_Victima_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_del_Abogado_Victima_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_del_Abogado_Victima_MPITable.fnPageChange(iPage);
    Detalle_del_Abogado_Victima_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_del_Abogado_Victima_MPI("Detalle_del_Abogado_Victima_MPI_", "_" + rowIndex);
  }
}

function Detalle_del_Abogado_Victima_MPICancelRow(rowIndex) {
    var prevData = Detalle_del_Abogado_Victima_MPITable.fnGetData(rowIndex);
    var data = Detalle_del_Abogado_Victima_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_del_Abogado_Victima_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_del_Abogado_Victima_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_del_Abogado_Victima_MPIGrid(Detalle_del_Abogado_Victima_MPITable.fnGetData());
    Detalle_del_Abogado_Victima_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_del_Abogado_Victima_MPIFromDataTable() {
    var Detalle_del_Abogado_Victima_MPIData = [];
    var gridData = Detalle_del_Abogado_Victima_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_del_Abogado_Victima_MPIData.push({
                Consecutivo_Victima: gridData[i].Consecutivo_Victima

                ,Nombre_Completo_del_Abogado_Victima: gridData[i].Nombre_Completo_del_Abogado_Victima
                ,Nombre_del_Abogado_Victima: gridData[i].Nombre_del_Abogado_Victima
                ,Apellido_Paterno_del_Abogado_Victima: gridData[i].Apellido_Paterno_del_Abogado_Victima
                ,Apellido_Materno_del_Abogado_Victima: gridData[i].Apellido_Materno_del_Abogado_Victima
                ,Fecha_de_Nacimiento_del_Abogado_Victima: gridData[i].Fecha_de_Nacimiento_del_Abogado_Victima
                ,Edad_del_Abogado_Victima: gridData[i].Edad_del_Abogado_Victima
                ,Sexo_del_Abogado_Victima: gridData[i].Sexo_del_Abogado_Victima
                ,Estado_Civil_del_Abogado_Victima: gridData[i].Estado_Civil_del_Abogado_Victima
                ,Tipo_de_Identificacion_Abogado_Victima: gridData[i].Tipo_de_Identificacion_Abogado_Victima
                ,Numero_de_Identificacion_Abogado_Victima: gridData[i].Numero_de_Identificacion_Abogado_Victima
                ,Nacionalidad_del_Abogado_Victima: gridData[i].Nacionalidad_del_Abogado_Victima
                ,Cedula_Profesional_del_Abogado_Victima: gridData[i].Cedula_Profesional_del_Abogado_Victima
                ,Pais_del_Abogado_Victima: gridData[i].Pais_del_Abogado_Victima
                ,Estado_del_Abogado_Victima: gridData[i].Estado_del_Abogado_Victima
                ,Municipio_del_Abogado_Victima: gridData[i].Municipio_del_Abogado_Victima
                ,Colonia_del_Abogado_Victima: gridData[i].Colonia_del_Abogado_Victima
                ,Codigo_Postal_del_Abogado_Victima: gridData[i].Codigo_Postal_del_Abogado_Victima
                ,Calle_del_Abogado_Victima: gridData[i].Calle_del_Abogado_Victima
                ,Numero_Exterior_del_Abogado_Victima: gridData[i].Numero_Exterior_del_Abogado_Victima
                ,Numero_Interior_del_Abogado_Victima: gridData[i].Numero_Interior_del_Abogado_Victima
                ,Telefono_del_Abogado_Victima: gridData[i].Telefono_del_Abogado_Victima
                ,Celular_del_Abogado_Victima: gridData[i].Celular_del_Abogado_Victima
                ,Correo_Electronico_del_Abogado_Victima: gridData[i].Correo_Electronico_del_Abogado_Victima
                ,Aceptar_Notificaciones: gridData[i].Aceptar_Notificaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_del_Abogado_Victima_MPIData.length; i++) {
        if (removedDetalle_del_Abogado_Victima_MPIData[i] != null && removedDetalle_del_Abogado_Victima_MPIData[i].Consecutivo_Victima > 0)
            Detalle_del_Abogado_Victima_MPIData.push({
                Consecutivo_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Consecutivo_Victima

                ,Nombre_Completo_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Nombre_Completo_del_Abogado_Victima
                ,Nombre_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Nombre_del_Abogado_Victima
                ,Apellido_Paterno_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Apellido_Paterno_del_Abogado_Victima
                ,Apellido_Materno_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Apellido_Materno_del_Abogado_Victima
                ,Fecha_de_Nacimiento_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Fecha_de_Nacimiento_del_Abogado_Victima
                ,Edad_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Edad_del_Abogado_Victima
                ,Sexo_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Sexo_del_Abogado_Victima
                ,Estado_Civil_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Estado_Civil_del_Abogado_Victima
                ,Tipo_de_Identificacion_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Tipo_de_Identificacion_Abogado_Victima
                ,Numero_de_Identificacion_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Numero_de_Identificacion_Abogado_Victima
                ,Nacionalidad_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Nacionalidad_del_Abogado_Victima
                ,Cedula_Profesional_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Cedula_Profesional_del_Abogado_Victima
                ,Pais_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Pais_del_Abogado_Victima
                ,Estado_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Estado_del_Abogado_Victima
                ,Municipio_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Municipio_del_Abogado_Victima
                ,Colonia_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Colonia_del_Abogado_Victima
                ,Codigo_Postal_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Codigo_Postal_del_Abogado_Victima
                ,Calle_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Calle_del_Abogado_Victima
                ,Numero_Exterior_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Numero_Exterior_del_Abogado_Victima
                ,Numero_Interior_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Numero_Interior_del_Abogado_Victima
                ,Telefono_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Telefono_del_Abogado_Victima
                ,Celular_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Celular_del_Abogado_Victima
                ,Correo_Electronico_del_Abogado_Victima: removedDetalle_del_Abogado_Victima_MPIData[i].Correo_Electronico_del_Abogado_Victima
                ,Aceptar_Notificaciones: removedDetalle_del_Abogado_Victima_MPIData[i].Aceptar_Notificaciones

                , Removed: true
            });
    }	

    return Detalle_del_Abogado_Victima_MPIData;
}

function Detalle_del_Abogado_Victima_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_del_Abogado_Victima_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_del_Abogado_Victima_MPIcountRowsChecked++;
    var Detalle_del_Abogado_Victima_MPIRowElement = "Detalle_del_Abogado_Victima_MPI_" + rowIndex.toString();
    var prevData = Detalle_del_Abogado_Victima_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_del_Abogado_Victima_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_del_Abogado_Victima_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_del_Abogado_Victima_MPIGetUpdateRowControls(prevData, "Detalle_del_Abogado_Victima_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_del_Abogado_Victima_MPIRowElement + "')){ Detalle_del_Abogado_Victima_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_del_Abogado_Victima_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_del_Abogado_Victima_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_del_Abogado_Victima_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_del_Abogado_Victima_MPIValidation();
    initiateUIControls();
    $('.Detalle_del_Abogado_Victima_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_del_Abogado_Victima_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_del_Abogado_Victima_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_del_Abogado_Victima_MPITable.fnGetData().length;
    Detalle_del_Abogado_Victima_MPIfnClickAddRow();
    GetAddDetalle_del_Abogado_Victima_MPIPopup(currentRowIndex, 0);
}

function Detalle_del_Abogado_Victima_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_del_Abogado_Victima_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_del_Abogado_Victima_MPIRowElement = "Detalle_del_Abogado_Victima_MPI_" + rowIndex.toString();
    var prevData = Detalle_del_Abogado_Victima_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_del_Abogado_Victima_MPIPopup(rowIndex, 1, prevData.Consecutivo_Victima);

    $('#Detalle_del_Abogado_Victima_MPINombre_Completo_del_Abogado_Victima').val(prevData.Nombre_Completo_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPINombre_del_Abogado_Victima').val(prevData.Nombre_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPIApellido_Paterno_del_Abogado_Victima').val(prevData.Apellido_Paterno_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPIApellido_Materno_del_Abogado_Victima').val(prevData.Apellido_Materno_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPIFecha_de_Nacimiento_del_Abogado_Victima').val(prevData.Fecha_de_Nacimiento_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPIEdad_del_Abogado_Victima').val(prevData.Edad_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPISexo_del_Abogado_Victima').val(prevData.Sexo_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPIEstado_Civil_del_Abogado_Victima').val(prevData.Estado_Civil_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPITipo_de_Identificacion_Abogado_Victima').val(prevData.Tipo_de_Identificacion_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPINumero_de_Identificacion_Abogado_Victima').val(prevData.Numero_de_Identificacion_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPINacionalidad_del_Abogado_Victima').val(prevData.Nacionalidad_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPICedula_Profesional_del_Abogado_Victima').val(prevData.Cedula_Profesional_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPIPais_del_Abogado_Victima').val(prevData.Pais_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPIEstado_del_Abogado_Victima').val(prevData.Estado_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPIMunicipio_del_Abogado_Victima').val(prevData.Municipio_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPIColonia_del_Abogado_Victima').val(prevData.Colonia_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPICodigo_Postal_del_Abogado_Victima').val(prevData.Codigo_Postal_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPICalle_del_Abogado_Victima').val(prevData.Calle_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPINumero_Exterior_del_Abogado_Victima').val(prevData.Numero_Exterior_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPINumero_Interior_del_Abogado_Victima').val(prevData.Numero_Interior_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPITelefono_del_Abogado_Victima').val(prevData.Telefono_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPICelular_del_Abogado_Victima').val(prevData.Celular_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPICorreo_Electronico_del_Abogado_Victima').val(prevData.Correo_Electronico_del_Abogado_Victima);
    $('#Detalle_del_Abogado_Victima_MPIAceptar_Notificaciones').prop('checked', prevData.Aceptar_Notificaciones);

    initiateUIControls();


























}

function Detalle_del_Abogado_Victima_MPIAddInsertRow() {
    if (Detalle_del_Abogado_Victima_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_del_Abogado_Victima_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Consecutivo_Victima: null,
        IsInsertRow: true

        ,Nombre_Completo_del_Abogado_Victima: ""
        ,Nombre_del_Abogado_Victima: ""
        ,Apellido_Paterno_del_Abogado_Victima: ""
        ,Apellido_Materno_del_Abogado_Victima: ""
        ,Fecha_de_Nacimiento_del_Abogado_Victima: ""
        ,Edad_del_Abogado_Victima: ""
        ,Sexo_del_Abogado_Victima: ""
        ,Estado_Civil_del_Abogado_Victima: ""
        ,Tipo_de_Identificacion_Abogado_Victima: ""
        ,Numero_de_Identificacion_Abogado_Victima: ""
        ,Nacionalidad_del_Abogado_Victima: ""
        ,Cedula_Profesional_del_Abogado_Victima: ""
        ,Pais_del_Abogado_Victima: ""
        ,Estado_del_Abogado_Victima: ""
        ,Municipio_del_Abogado_Victima: ""
        ,Colonia_del_Abogado_Victima: ""
        ,Codigo_Postal_del_Abogado_Victima: ""
        ,Calle_del_Abogado_Victima: ""
        ,Numero_Exterior_del_Abogado_Victima: ""
        ,Numero_Interior_del_Abogado_Victima: ""
        ,Telefono_del_Abogado_Victima: ""
        ,Celular_del_Abogado_Victima: ""
        ,Correo_Electronico_del_Abogado_Victima: ""
        ,Aceptar_Notificaciones: ""

    }
}

function Detalle_del_Abogado_Victima_MPIfnClickAddRow() {
    Detalle_del_Abogado_Victima_MPIcountRowsChecked++;
    Detalle_del_Abogado_Victima_MPITable.fnAddData(Detalle_del_Abogado_Victima_MPIAddInsertRow(), true);
    Detalle_del_Abogado_Victima_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_del_Abogado_Victima_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_del_Abogado_Victima_MPIGrid tbody tr:nth-of-type(' + (Detalle_del_Abogado_Victima_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_del_Abogado_Victima_MPI("Detalle_del_Abogado_Victima_MPI_", "_" + Detalle_del_Abogado_Victima_MPIinsertRowCurrentIndex);
}

function Detalle_del_Abogado_Victima_MPIClearGridData() {
    Detalle_del_Abogado_Victima_MPIData = [];
    Detalle_del_Abogado_Victima_MPIdeletedItem = [];
    Detalle_del_Abogado_Victima_MPIDataMain = [];
    Detalle_del_Abogado_Victima_MPIDataMainPages = [];
    Detalle_del_Abogado_Victima_MPInewItemCount = 0;
    Detalle_del_Abogado_Victima_MPImaxItemIndex = 0;
    $("#Detalle_del_Abogado_Victima_MPIGrid").DataTable().clear();
    $("#Detalle_del_Abogado_Victima_MPIGrid").DataTable().destroy();
}

//Used to Get Detalle de Datos de la Victima MPI Information
function GetDetalle_del_Abogado_Victima_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_del_Abogado_Victima_MPIData.length; i++) {
        form_data.append('[' + i + '].Consecutivo_Victima', Detalle_del_Abogado_Victima_MPIData[i].Consecutivo_Victima);

        form_data.append('[' + i + '].Nombre_Completo_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Nombre_Completo_del_Abogado_Victima);
        form_data.append('[' + i + '].Nombre_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Nombre_del_Abogado_Victima);
        form_data.append('[' + i + '].Apellido_Paterno_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Apellido_Paterno_del_Abogado_Victima);
        form_data.append('[' + i + '].Apellido_Materno_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Apellido_Materno_del_Abogado_Victima);
        form_data.append('[' + i + '].Fecha_de_Nacimiento_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Fecha_de_Nacimiento_del_Abogado_Victima);
        form_data.append('[' + i + '].Edad_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Edad_del_Abogado_Victima);
        form_data.append('[' + i + '].Sexo_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Sexo_del_Abogado_Victima);
        form_data.append('[' + i + '].Estado_Civil_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Estado_Civil_del_Abogado_Victima);
        form_data.append('[' + i + '].Tipo_de_Identificacion_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Tipo_de_Identificacion_Abogado_Victima);
        form_data.append('[' + i + '].Numero_de_Identificacion_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Numero_de_Identificacion_Abogado_Victima);
        form_data.append('[' + i + '].Nacionalidad_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Nacionalidad_del_Abogado_Victima);
        form_data.append('[' + i + '].Cedula_Profesional_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Cedula_Profesional_del_Abogado_Victima);
        form_data.append('[' + i + '].Pais_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Pais_del_Abogado_Victima);
        form_data.append('[' + i + '].Estado_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Estado_del_Abogado_Victima);
        form_data.append('[' + i + '].Municipio_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Municipio_del_Abogado_Victima);
        form_data.append('[' + i + '].Colonia_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Colonia_del_Abogado_Victima);
        form_data.append('[' + i + '].Codigo_Postal_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Codigo_Postal_del_Abogado_Victima);
        form_data.append('[' + i + '].Calle_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Calle_del_Abogado_Victima);
        form_data.append('[' + i + '].Numero_Exterior_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Numero_Exterior_del_Abogado_Victima);
        form_data.append('[' + i + '].Numero_Interior_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Numero_Interior_del_Abogado_Victima);
        form_data.append('[' + i + '].Telefono_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Telefono_del_Abogado_Victima);
        form_data.append('[' + i + '].Celular_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Celular_del_Abogado_Victima);
        form_data.append('[' + i + '].Correo_Electronico_del_Abogado_Victima', Detalle_del_Abogado_Victima_MPIData[i].Correo_Electronico_del_Abogado_Victima);
        form_data.append('[' + i + '].Aceptar_Notificaciones', Detalle_del_Abogado_Victima_MPIData[i].Aceptar_Notificaciones);

        form_data.append('[' + i + '].Removed', Detalle_del_Abogado_Victima_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_del_Abogado_Victima_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_del_Abogado_Victima_MPI("Detalle_del_Abogado_Victima_MPITable", rowIndex)) {
    var prevData = Detalle_del_Abogado_Victima_MPITable.fnGetData(rowIndex);
    var data = Detalle_del_Abogado_Victima_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Consecutivo_Victima: prevData.Consecutivo_Victima,
        IsInsertRow: false

        ,Nombre_Completo_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPINombre_Completo_del_Abogado_Victima').val()
        ,Nombre_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPINombre_del_Abogado_Victima').val()
        ,Apellido_Paterno_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPIApellido_Paterno_del_Abogado_Victima').val()
        ,Apellido_Materno_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPIApellido_Materno_del_Abogado_Victima').val()
        ,Fecha_de_Nacimiento_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPIFecha_de_Nacimiento_del_Abogado_Victima').val()
        ,Edad_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPIEdad_del_Abogado_Victima').val()

        ,Sexo_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPISexo_del_Abogado_Victima').val()
        ,Estado_Civil_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPIEstado_Civil_del_Abogado_Victima').val()
        ,Tipo_de_Identificacion_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPITipo_de_Identificacion_Abogado_Victima').val()
        ,Numero_de_Identificacion_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPINumero_de_Identificacion_Abogado_Victima').val()
        ,Nacionalidad_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPINacionalidad_del_Abogado_Victima').val()
        ,Cedula_Profesional_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPICedula_Profesional_del_Abogado_Victima').val()
        ,Pais_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPIPais_del_Abogado_Victima').val()
        ,Estado_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPIEstado_del_Abogado_Victima').val()
        ,Municipio_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPIMunicipio_del_Abogado_Victima').val()
        ,Colonia_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPIColonia_del_Abogado_Victima').val()
        ,Codigo_Postal_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPICodigo_Postal_del_Abogado_Victima').val()

        ,Calle_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPICalle_del_Abogado_Victima').val()
        ,Numero_Exterior_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPINumero_Exterior_del_Abogado_Victima').val()
        ,Numero_Interior_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPINumero_Interior_del_Abogado_Victima').val()
        ,Telefono_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPITelefono_del_Abogado_Victima').val()
        ,Celular_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPICelular_del_Abogado_Victima').val()
        ,Correo_Electronico_del_Abogado_Victima: $('#Detalle_del_Abogado_Victima_MPICorreo_Electronico_del_Abogado_Victima').val()
        ,Aceptar_Notificaciones: $('#Detalle_del_Abogado_Victima_MPIAceptar_Notificaciones').is(':checked')

    }

    Detalle_del_Abogado_Victima_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_del_Abogado_Victima_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_del_Abogado_Victima_MPI-form').modal({ show: false });
    $('#AddDetalle_del_Abogado_Victima_MPI-form').modal('hide');
    Detalle_del_Abogado_Victima_MPIEditRow(rowIndex);
    Detalle_del_Abogado_Victima_MPIInsertRow(rowIndex);
    //}
}
function Detalle_del_Abogado_Victima_MPIRemoveAddRow(rowIndex) {
    Detalle_del_Abogado_Victima_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_del_Abogado_Victima_MPI MultiRow


$(function () {
    function Detalle_del_Abogado_Victima_MPIinitializeMainArray(totalCount) {
        if (Detalle_del_Abogado_Victima_MPIDataMain.length != totalCount && !Detalle_del_Abogado_Victima_MPIDataMainInitialized) {
            Detalle_del_Abogado_Victima_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_del_Abogado_Victima_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_del_Abogado_Victima_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_del_Abogado_Victima_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_del_Abogado_Victima_MPIDataMain.length; i++) {
                if (Detalle_del_Abogado_Victima_MPIDataMain[i] != null && Detalle_del_Abogado_Victima_MPIDataMain[i].Id == Detalle_del_Abogado_Victima_MPIdeletedItem[j]) {
                    hDetalle_del_Abogado_Victima_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_del_Abogado_Victima_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_del_Abogado_Victima_MPIDataMain.length; i++) {
            data[i] = Detalle_del_Abogado_Victima_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_del_Abogado_Victima_MPIgetNewResult() {
        var newData = copyMainDetalle_del_Abogado_Victima_MPIArray();

        for (var i = 0; i < Detalle_del_Abogado_Victima_MPIData.length; i++) {
            if (Detalle_del_Abogado_Victima_MPIData[i].Removed == null || Detalle_del_Abogado_Victima_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_del_Abogado_Victima_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_del_Abogado_Victima_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_del_Abogado_Victima_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_del_Abogado_Victima_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Datos_de_la_Victima_MPI_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Datos_de_la_Victima_MPI')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
                Detalle_del_Abogado_Victima_MPIClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Datos_de_la_Victima_MPI').trigger('reset');
    $('#CreateDetalle_de_Datos_de_la_Victima_MPI').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Datos_de_la_Victima_MPI');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_del_Abogado_Victima_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_del_Abogado_Victima_MPI();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Datos_de_la_Victima_MPI").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Datos_de_la_Victima_MPI").on('click', '#Detalle_de_Datos_de_la_Victima_MPICancelar', function () {
	  if (!isPartial) {
        Detalle_de_Datos_de_la_Victima_MPIBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Datos_de_la_Victima_MPI").on('click', '#Detalle_de_Datos_de_la_Victima_MPIGuardar', function () {
		$('#Detalle_de_Datos_de_la_Victima_MPIGuardar').attr('disabled', true);
		$('#Detalle_de_Datos_de_la_Victima_MPIGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_Datos_de_la_Victima_MPIData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_Datos_de_la_Victima_MPIBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_Datos_de_la_Victima_MPIGuardar').removeAttr('disabled');
                        $('#Detalle_de_Datos_de_la_Victima_MPIGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Datos_de_la_Victima_MPI', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_de_la_Victima_MPIItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_de_la_Victima_MPIDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Detalle_de_Datos_de_la_Victima_MPIGuardar').removeAttr('disabled');
					$('#Detalle_de_Datos_de_la_Victima_MPIGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_Datos_de_la_Victima_MPIGuardar').removeAttr('disabled');
			$('#Detalle_de_Datos_de_la_Victima_MPIGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Datos_de_la_Victima_MPI").on('click', '#Detalle_de_Datos_de_la_Victima_MPIGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_Datos_de_la_Victima_MPIData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_del_Abogado_Victima_MPIData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Datos_de_la_Victima_MPI', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_de_la_Victima_MPIItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_de_la_Victima_MPIDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Datos_de_la_Victima_MPI").on('click', '#Detalle_de_Datos_de_la_Victima_MPIGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_Datos_de_la_Victima_MPIData(function (currentId) {
					$("#ClaveId").val("0");
	                Detalle_del_Abogado_Victima_MPIClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_del_Abogado_Victima_MPIData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Datos_de_la_Victima_MPI',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_de_la_Victima_MPIItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_de_la_Victima_MPIDropDown().get(0)').innerHTML);                          
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



var Detalle_de_Datos_de_la_Victima_MPIisdisplayBusinessPropery = false;
Detalle_de_Datos_de_la_Victima_MPIDisplayBusinessRuleButtons(Detalle_de_Datos_de_la_Victima_MPIisdisplayBusinessPropery);
function Detalle_de_Datos_de_la_Victima_MPIDisplayBusinessRule() {
    if (!Detalle_de_Datos_de_la_Victima_MPIisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Datos_de_la_Victima_MPI').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_Datos_de_la_Victima_MPIdisplayBusinessPropery"><button onclick="Detalle_de_Datos_de_la_Victima_MPIGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_Datos_de_la_Victima_MPIBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_Datos_de_la_Victima_MPIdisplayBusinessPropery').remove();
    }
    Detalle_de_Datos_de_la_Victima_MPIDisplayBusinessRuleButtons(!Detalle_de_Datos_de_la_Victima_MPIisdisplayBusinessPropery);
    Detalle_de_Datos_de_la_Victima_MPIisdisplayBusinessPropery = (Detalle_de_Datos_de_la_Victima_MPIisdisplayBusinessPropery ? false : true);
}
function Detalle_de_Datos_de_la_Victima_MPIDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

