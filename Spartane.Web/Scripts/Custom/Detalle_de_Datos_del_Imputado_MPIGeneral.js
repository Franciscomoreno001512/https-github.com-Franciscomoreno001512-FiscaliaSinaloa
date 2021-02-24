

//Begin Declarations for Foreigns fields for Detalle_del_Abogado_Imputado_MPI MultiRow
var Detalle_del_Abogado_Imputado_MPIcountRowsChecked = 0;

function GetDetalle_del_Abogado_Imputado_MPI_AbogadoName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_AbogadoItems.length; i++) {
        if (Detalle_del_Abogado_Imputado_MPI_AbogadoItems[i].Clave == Id) {
            return Detalle_del_Abogado_Imputado_MPI_AbogadoItems[i].Nombre_Completo;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Imputado_MPI_AbogadoDropDown() {
    var Detalle_del_Abogado_Imputado_MPI_AbogadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Imputado_MPI_AbogadoDropdown);
    if(Detalle_del_Abogado_Imputado_MPI_AbogadoItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_AbogadoItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Imputado_MPI_AbogadoItems[i].Clave, text:    Detalle_del_Abogado_Imputado_MPI_AbogadoItems[i].Nombre_Completo }).appendTo(Detalle_del_Abogado_Imputado_MPI_AbogadoDropdown);
       }
    }
    return Detalle_del_Abogado_Imputado_MPI_AbogadoDropdown;
}





function GetDetalle_del_Abogado_Imputado_MPI_GeneroName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_GeneroItems.length; i++) {
        if (Detalle_del_Abogado_Imputado_MPI_GeneroItems[i].Clave == Id) {
            return Detalle_del_Abogado_Imputado_MPI_GeneroItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Imputado_MPI_GeneroDropDown() {
    var Detalle_del_Abogado_Imputado_MPI_GeneroDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Imputado_MPI_GeneroDropdown);
    if(Detalle_del_Abogado_Imputado_MPI_GeneroItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_GeneroItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Imputado_MPI_GeneroItems[i].Clave, text:    Detalle_del_Abogado_Imputado_MPI_GeneroItems[i].Descripcion }).appendTo(Detalle_del_Abogado_Imputado_MPI_GeneroDropdown);
       }
    }
    return Detalle_del_Abogado_Imputado_MPI_GeneroDropdown;
}
function GetDetalle_del_Abogado_Imputado_MPI_Estado_CivilName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_Estado_CivilItems.length; i++) {
        if (Detalle_del_Abogado_Imputado_MPI_Estado_CivilItems[i].Clave == Id) {
            return Detalle_del_Abogado_Imputado_MPI_Estado_CivilItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Imputado_MPI_Estado_CivilDropDown() {
    var Detalle_del_Abogado_Imputado_MPI_Estado_CivilDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Imputado_MPI_Estado_CivilDropdown);
    if(Detalle_del_Abogado_Imputado_MPI_Estado_CivilItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_Estado_CivilItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Imputado_MPI_Estado_CivilItems[i].Clave, text:    Detalle_del_Abogado_Imputado_MPI_Estado_CivilItems[i].Descripcion }).appendTo(Detalle_del_Abogado_Imputado_MPI_Estado_CivilDropdown);
       }
    }
    return Detalle_del_Abogado_Imputado_MPI_Estado_CivilDropdown;
}
function GetDetalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionItems.length; i++) {
        if (Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionItems[i].Clave == Id) {
            return Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionDropDown() {
    var Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionDropdown);
    if(Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionItems[i].Clave, text:    Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionItems[i].Nombre }).appendTo(Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionDropdown);
       }
    }
    return Detalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionDropdown;
}

function GetDetalle_del_Abogado_Imputado_MPI_NacionalidadName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_NacionalidadItems.length; i++) {
        if (Detalle_del_Abogado_Imputado_MPI_NacionalidadItems[i].Clave == Id) {
            return Detalle_del_Abogado_Imputado_MPI_NacionalidadItems[i].NacionalidadC;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Imputado_MPI_NacionalidadDropDown() {
    var Detalle_del_Abogado_Imputado_MPI_NacionalidadDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Imputado_MPI_NacionalidadDropdown);
    if(Detalle_del_Abogado_Imputado_MPI_NacionalidadItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_NacionalidadItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Imputado_MPI_NacionalidadItems[i].Clave, text:    Detalle_del_Abogado_Imputado_MPI_NacionalidadItems[i].NacionalidadC }).appendTo(Detalle_del_Abogado_Imputado_MPI_NacionalidadDropdown);
       }
    }
    return Detalle_del_Abogado_Imputado_MPI_NacionalidadDropdown;
}

function GetDetalle_del_Abogado_Imputado_MPI_PaisName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_PaisItems.length; i++) {
        if (Detalle_del_Abogado_Imputado_MPI_PaisItems[i].Clave == Id) {
            return Detalle_del_Abogado_Imputado_MPI_PaisItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Imputado_MPI_PaisDropDown() {
    var Detalle_del_Abogado_Imputado_MPI_PaisDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Imputado_MPI_PaisDropdown);
    if(Detalle_del_Abogado_Imputado_MPI_PaisItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_PaisItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Imputado_MPI_PaisItems[i].Clave, text:    Detalle_del_Abogado_Imputado_MPI_PaisItems[i].Nombre }).appendTo(Detalle_del_Abogado_Imputado_MPI_PaisDropdown);
       }
    }
    return Detalle_del_Abogado_Imputado_MPI_PaisDropdown;
}
function GetDetalle_del_Abogado_Imputado_MPI_EstadoName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_EstadoItems.length; i++) {
        if (Detalle_del_Abogado_Imputado_MPI_EstadoItems[i].Clave == Id) {
            return Detalle_del_Abogado_Imputado_MPI_EstadoItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Imputado_MPI_EstadoDropDown() {
    var Detalle_del_Abogado_Imputado_MPI_EstadoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Imputado_MPI_EstadoDropdown);
    if(Detalle_del_Abogado_Imputado_MPI_EstadoItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_EstadoItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Imputado_MPI_EstadoItems[i].Clave, text:    Detalle_del_Abogado_Imputado_MPI_EstadoItems[i].Nombre }).appendTo(Detalle_del_Abogado_Imputado_MPI_EstadoDropdown);
       }
    }
    return Detalle_del_Abogado_Imputado_MPI_EstadoDropdown;
}
function GetDetalle_del_Abogado_Imputado_MPI_MunicipioName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_MunicipioItems.length; i++) {
        if (Detalle_del_Abogado_Imputado_MPI_MunicipioItems[i].Clave == Id) {
            return Detalle_del_Abogado_Imputado_MPI_MunicipioItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Imputado_MPI_MunicipioDropDown() {
    var Detalle_del_Abogado_Imputado_MPI_MunicipioDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Imputado_MPI_MunicipioDropdown);
    if(Detalle_del_Abogado_Imputado_MPI_MunicipioItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_MunicipioItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Imputado_MPI_MunicipioItems[i].Clave, text:    Detalle_del_Abogado_Imputado_MPI_MunicipioItems[i].Nombre }).appendTo(Detalle_del_Abogado_Imputado_MPI_MunicipioDropdown);
       }
    }
    return Detalle_del_Abogado_Imputado_MPI_MunicipioDropdown;
}
function GetDetalle_del_Abogado_Imputado_MPI_ColoniaName(Id) {
    for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_ColoniaItems.length; i++) {
        if (Detalle_del_Abogado_Imputado_MPI_ColoniaItems[i].Clave == Id) {
            return Detalle_del_Abogado_Imputado_MPI_ColoniaItems[i].Nombre;
        }
    }
    return "";
}

function GetDetalle_del_Abogado_Imputado_MPI_ColoniaDropDown() {
    var Detalle_del_Abogado_Imputado_MPI_ColoniaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_del_Abogado_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_del_Abogado_Imputado_MPI_ColoniaDropdown);
    if(Detalle_del_Abogado_Imputado_MPI_ColoniaItems != null)
    {
       for (var i = 0; i < Detalle_del_Abogado_Imputado_MPI_ColoniaItems.length; i++) {
           $('<option />', { value: Detalle_del_Abogado_Imputado_MPI_ColoniaItems[i].Clave, text:    Detalle_del_Abogado_Imputado_MPI_ColoniaItems[i].Nombre }).appendTo(Detalle_del_Abogado_Imputado_MPI_ColoniaDropdown);
       }
    }
    return Detalle_del_Abogado_Imputado_MPI_ColoniaDropdown;
}










function GetInsertDetalle_del_Abogado_Imputado_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_del_Abogado_Imputado_MPI_AbogadoDropDown()).addClass('Detalle_del_Abogado_Imputado_MPI_Nombre_Completo_del_Abogado Nombre_Completo_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Nombre_Completo_del_Abogado_' + index).attr('data-field', 'Nombre_Completo_del_Abogado').after($.parseHTML(addNew('Detalle_del_Abogado_Imputado_MPI', 'Abogado', 'Nombre_Completo_del_Abogado', 264647)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Nombre_del_Abogado Nombre_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Nombre_del_Abogado_' + index).attr('data-field', 'Nombre_del_Abogado');
    columnData[2] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Apellido_Paterno_del_Abogado Apellido_Paterno_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Apellido_Paterno_del_Abogado_' + index).attr('data-field', 'Apellido_Paterno_del_Abogado');
    columnData[3] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Apellido_Materno_del_Abogado Apellido_Materno_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Apellido_Materno_del_Abogado_' + index).attr('data-field', 'Apellido_Materno_del_Abogado');
    columnData[4] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_del_Abogado_Imputado_MPI_Fecha_de_Nacimiento_del_Abogado Fecha_de_Nacimiento_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Fecha_de_Nacimiento_del_Abogado_' + index).attr('data-field', 'Fecha_de_Nacimiento_del_Abogado');
    columnData[5] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_del_Abogado_Imputado_MPI_Edad_del_Abogado Edad_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Edad_del_Abogado_' + index).attr('data-field', 'Edad_del_Abogado');
    columnData[6] = $(GetDetalle_del_Abogado_Imputado_MPI_GeneroDropDown()).addClass('Detalle_del_Abogado_Imputado_MPI_Sexo_del_Abogado Sexo_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Sexo_del_Abogado_' + index).attr('data-field', 'Sexo_del_Abogado').after($.parseHTML(addNew('Detalle_del_Abogado_Imputado_MPI', 'Genero', 'Sexo_del_Abogado', 264653)));
    columnData[7] = $(GetDetalle_del_Abogado_Imputado_MPI_Estado_CivilDropDown()).addClass('Detalle_del_Abogado_Imputado_MPI_Estado_Civil_del_Abogado Estado_Civil_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Estado_Civil_del_Abogado_' + index).attr('data-field', 'Estado_Civil_del_Abogado').after($.parseHTML(addNew('Detalle_del_Abogado_Imputado_MPI', 'Estado_Civil', 'Estado_Civil_del_Abogado', 264654)));
    columnData[8] = $(GetDetalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionDropDown()).addClass('Detalle_del_Abogado_Imputado_MPI_Tipo_de_Identificacion_del_Abogado Tipo_de_Identificacion_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Tipo_de_Identificacion_del_Abogado_' + index).attr('data-field', 'Tipo_de_Identificacion_del_Abogado').after($.parseHTML(addNew('Detalle_del_Abogado_Imputado_MPI', 'Tipo_de_Identificacion', 'Tipo_de_Identificacion_del_Abogado', 264655)));
    columnData[9] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Numero_de_Identificacion_del_Abogado Numero_de_Identificacion_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Numero_de_Identificacion_del_Abogado_' + index).attr('data-field', 'Numero_de_Identificacion_del_Abogado');
    columnData[10] = $(GetDetalle_del_Abogado_Imputado_MPI_NacionalidadDropDown()).addClass('Detalle_del_Abogado_Imputado_MPI_Nacionalidad_del_Abogado Nacionalidad_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Nacionalidad_del_Abogado_' + index).attr('data-field', 'Nacionalidad_del_Abogado').after($.parseHTML(addNew('Detalle_del_Abogado_Imputado_MPI', 'Nacionalidad', 'Nacionalidad_del_Abogado', 264657)));
    columnData[11] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Cedula_Profesional_del_Abogado Cedula_Profesional_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Cedula_Profesional_del_Abogado_' + index).attr('data-field', 'Cedula_Profesional_del_Abogado');
    columnData[12] = $(GetDetalle_del_Abogado_Imputado_MPI_PaisDropDown()).addClass('Detalle_del_Abogado_Imputado_MPI_Pais_del_Abogado Pais_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Pais_del_Abogado_' + index).attr('data-field', 'Pais_del_Abogado').after($.parseHTML(addNew('Detalle_del_Abogado_Imputado_MPI', 'Pais', 'Pais_del_Abogado', 264659)));
    columnData[13] = $(GetDetalle_del_Abogado_Imputado_MPI_EstadoDropDown()).addClass('Detalle_del_Abogado_Imputado_MPI_Estado_del_Abogado Estado_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Estado_del_Abogado_' + index).attr('data-field', 'Estado_del_Abogado').after($.parseHTML(addNew('Detalle_del_Abogado_Imputado_MPI', 'Estado', 'Estado_del_Abogado', 264660)));
    columnData[14] = $(GetDetalle_del_Abogado_Imputado_MPI_MunicipioDropDown()).addClass('Detalle_del_Abogado_Imputado_MPI_Municipio_del_Abogado Municipio_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Municipio_del_Abogado_' + index).attr('data-field', 'Municipio_del_Abogado').after($.parseHTML(addNew('Detalle_del_Abogado_Imputado_MPI', 'Municipio', 'Municipio_del_Abogado', 264661)));
    columnData[15] = $(GetDetalle_del_Abogado_Imputado_MPI_ColoniaDropDown()).addClass('Detalle_del_Abogado_Imputado_MPI_Colonia_del_Abogado Colonia_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Colonia_del_Abogado_' + index).attr('data-field', 'Colonia_del_Abogado').after($.parseHTML(addNew('Detalle_del_Abogado_Imputado_MPI', 'Colonia', 'Colonia_del_Abogado', 264662)));
    columnData[16] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_del_Abogado_Imputado_MPI_Codigo_Postal_del_Abogado Codigo_Postal_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Codigo_Postal_del_Abogado_' + index).attr('data-field', 'Codigo_Postal_del_Abogado');
    columnData[17] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Calle_del_Abogado Calle_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Calle_del_Abogado_' + index).attr('data-field', 'Calle_del_Abogado');
    columnData[18] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Numero_Exterior_del_Abogado Numero_Exterior_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Numero_Exterior_del_Abogado_' + index).attr('data-field', 'Numero_Exterior_del_Abogado');
    columnData[19] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Numero_Interior_del_Abogado Numero_Interior_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Numero_Interior_del_Abogado_' + index).attr('data-field', 'Numero_Interior_del_Abogado');
    columnData[20] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Telefono_del_Abogado Telefono_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Telefono_del_Abogado_' + index).attr('data-field', 'Telefono_del_Abogado');
    columnData[21] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Celular_del_Abogado Celular_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Celular_del_Abogado_' + index).attr('data-field', 'Celular_del_Abogado');
    columnData[22] = $($.parseHTML(inputData)).addClass('Detalle_del_Abogado_Imputado_MPI_Correo_Electronico_del_Abogado Correo_Electronico_del_Abogado').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Correo_Electronico_del_Abogado_' + index).attr('data-field', 'Correo_Electronico_del_Abogado');
    columnData[23] = $($.parseHTML(GetGridCheckBox())).addClass('Detalle_del_Abogado_Imputado_MPI_Aceptar_Notificaciones Aceptar_Notificaciones').attr('id', 'Detalle_del_Abogado_Imputado_MPI_Aceptar_Notificaciones_' + index).attr('data-field', 'Aceptar_Notificaciones');


    initiateUIControls();
    return columnData;
}

function Detalle_del_Abogado_Imputado_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_del_Abogado_Imputado_MPI("Detalle_del_Abogado_Imputado_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_del_Abogado_Imputado_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_del_Abogado_Imputado_MPI';
    var prevData = Detalle_del_Abogado_Imputado_MPITable.fnGetData(rowIndex);
    var data = Detalle_del_Abogado_Imputado_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Consecutivo: prevData.Consecutivo,
        IsInsertRow: false

        ,Nombre_Completo_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Nombre_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Paterno_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Apellido_Materno_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Nacimiento_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Edad_del_Abogado: data.childNodes[counter++].childNodes[0].value
        ,Sexo_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Estado_Civil_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Tipo_de_Identificacion_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Numero_de_Identificacion_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Nacionalidad_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Cedula_Profesional_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Pais_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Estado_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Municipio_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Colonia_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Codigo_Postal_del_Abogado: data.childNodes[counter++].childNodes[0].value
        ,Calle_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Exterior_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Numero_Interior_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Telefono_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Celular_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Correo_Electronico_del_Abogado:  data.childNodes[counter++].childNodes[0].value
        ,Aceptar_Notificaciones: $(data.childNodes[counter++].childNodes[2]).is(':checked')

    }
    Detalle_del_Abogado_Imputado_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_del_Abogado_Imputado_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_del_Abogado_Imputado_MPITable.fnPageChange(iPage);
    Detalle_del_Abogado_Imputado_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_del_Abogado_Imputado_MPI("Detalle_del_Abogado_Imputado_MPI_", "_" + rowIndex);
  }
}

function Detalle_del_Abogado_Imputado_MPICancelRow(rowIndex) {
    var prevData = Detalle_del_Abogado_Imputado_MPITable.fnGetData(rowIndex);
    var data = Detalle_del_Abogado_Imputado_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_del_Abogado_Imputado_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_del_Abogado_Imputado_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_del_Abogado_Imputado_MPIGrid(Detalle_del_Abogado_Imputado_MPITable.fnGetData());
    Detalle_del_Abogado_Imputado_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_del_Abogado_Imputado_MPIFromDataTable() {
    var Detalle_del_Abogado_Imputado_MPIData = [];
    var gridData = Detalle_del_Abogado_Imputado_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_del_Abogado_Imputado_MPIData.push({
                Consecutivo: gridData[i].Consecutivo

                ,Nombre_Completo_del_Abogado: gridData[i].Nombre_Completo_del_Abogado
                ,Nombre_del_Abogado: gridData[i].Nombre_del_Abogado
                ,Apellido_Paterno_del_Abogado: gridData[i].Apellido_Paterno_del_Abogado
                ,Apellido_Materno_del_Abogado: gridData[i].Apellido_Materno_del_Abogado
                ,Fecha_de_Nacimiento_del_Abogado: gridData[i].Fecha_de_Nacimiento_del_Abogado
                ,Edad_del_Abogado: gridData[i].Edad_del_Abogado
                ,Sexo_del_Abogado: gridData[i].Sexo_del_Abogado
                ,Estado_Civil_del_Abogado: gridData[i].Estado_Civil_del_Abogado
                ,Tipo_de_Identificacion_del_Abogado: gridData[i].Tipo_de_Identificacion_del_Abogado
                ,Numero_de_Identificacion_del_Abogado: gridData[i].Numero_de_Identificacion_del_Abogado
                ,Nacionalidad_del_Abogado: gridData[i].Nacionalidad_del_Abogado
                ,Cedula_Profesional_del_Abogado: gridData[i].Cedula_Profesional_del_Abogado
                ,Pais_del_Abogado: gridData[i].Pais_del_Abogado
                ,Estado_del_Abogado: gridData[i].Estado_del_Abogado
                ,Municipio_del_Abogado: gridData[i].Municipio_del_Abogado
                ,Colonia_del_Abogado: gridData[i].Colonia_del_Abogado
                ,Codigo_Postal_del_Abogado: gridData[i].Codigo_Postal_del_Abogado
                ,Calle_del_Abogado: gridData[i].Calle_del_Abogado
                ,Numero_Exterior_del_Abogado: gridData[i].Numero_Exterior_del_Abogado
                ,Numero_Interior_del_Abogado: gridData[i].Numero_Interior_del_Abogado
                ,Telefono_del_Abogado: gridData[i].Telefono_del_Abogado
                ,Celular_del_Abogado: gridData[i].Celular_del_Abogado
                ,Correo_Electronico_del_Abogado: gridData[i].Correo_Electronico_del_Abogado
                ,Aceptar_Notificaciones: gridData[i].Aceptar_Notificaciones

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_del_Abogado_Imputado_MPIData.length; i++) {
        if (removedDetalle_del_Abogado_Imputado_MPIData[i] != null && removedDetalle_del_Abogado_Imputado_MPIData[i].Consecutivo > 0)
            Detalle_del_Abogado_Imputado_MPIData.push({
                Consecutivo: removedDetalle_del_Abogado_Imputado_MPIData[i].Consecutivo

                ,Nombre_Completo_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Nombre_Completo_del_Abogado
                ,Nombre_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Nombre_del_Abogado
                ,Apellido_Paterno_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Apellido_Paterno_del_Abogado
                ,Apellido_Materno_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Apellido_Materno_del_Abogado
                ,Fecha_de_Nacimiento_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Fecha_de_Nacimiento_del_Abogado
                ,Edad_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Edad_del_Abogado
                ,Sexo_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Sexo_del_Abogado
                ,Estado_Civil_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Estado_Civil_del_Abogado
                ,Tipo_de_Identificacion_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Tipo_de_Identificacion_del_Abogado
                ,Numero_de_Identificacion_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Numero_de_Identificacion_del_Abogado
                ,Nacionalidad_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Nacionalidad_del_Abogado
                ,Cedula_Profesional_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Cedula_Profesional_del_Abogado
                ,Pais_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Pais_del_Abogado
                ,Estado_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Estado_del_Abogado
                ,Municipio_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Municipio_del_Abogado
                ,Colonia_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Colonia_del_Abogado
                ,Codigo_Postal_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Codigo_Postal_del_Abogado
                ,Calle_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Calle_del_Abogado
                ,Numero_Exterior_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Numero_Exterior_del_Abogado
                ,Numero_Interior_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Numero_Interior_del_Abogado
                ,Telefono_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Telefono_del_Abogado
                ,Celular_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Celular_del_Abogado
                ,Correo_Electronico_del_Abogado: removedDetalle_del_Abogado_Imputado_MPIData[i].Correo_Electronico_del_Abogado
                ,Aceptar_Notificaciones: removedDetalle_del_Abogado_Imputado_MPIData[i].Aceptar_Notificaciones

                , Removed: true
            });
    }	

    return Detalle_del_Abogado_Imputado_MPIData;
}

function Detalle_del_Abogado_Imputado_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_del_Abogado_Imputado_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_del_Abogado_Imputado_MPIcountRowsChecked++;
    var Detalle_del_Abogado_Imputado_MPIRowElement = "Detalle_del_Abogado_Imputado_MPI_" + rowIndex.toString();
    var prevData = Detalle_del_Abogado_Imputado_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_del_Abogado_Imputado_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_del_Abogado_Imputado_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_del_Abogado_Imputado_MPIGetUpdateRowControls(prevData, "Detalle_del_Abogado_Imputado_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_del_Abogado_Imputado_MPIRowElement + "')){ Detalle_del_Abogado_Imputado_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_del_Abogado_Imputado_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_del_Abogado_Imputado_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_del_Abogado_Imputado_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_del_Abogado_Imputado_MPIValidation();
    initiateUIControls();
    $('.Detalle_del_Abogado_Imputado_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_del_Abogado_Imputado_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_del_Abogado_Imputado_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_del_Abogado_Imputado_MPITable.fnGetData().length;
    Detalle_del_Abogado_Imputado_MPIfnClickAddRow();
    GetAddDetalle_del_Abogado_Imputado_MPIPopup(currentRowIndex, 0);
}

function Detalle_del_Abogado_Imputado_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_del_Abogado_Imputado_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_del_Abogado_Imputado_MPIRowElement = "Detalle_del_Abogado_Imputado_MPI_" + rowIndex.toString();
    var prevData = Detalle_del_Abogado_Imputado_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_del_Abogado_Imputado_MPIPopup(rowIndex, 1, prevData.Consecutivo);

    $('#Detalle_del_Abogado_Imputado_MPINombre_Completo_del_Abogado').val(prevData.Nombre_Completo_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPINombre_del_Abogado').val(prevData.Nombre_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPIApellido_Paterno_del_Abogado').val(prevData.Apellido_Paterno_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPIApellido_Materno_del_Abogado').val(prevData.Apellido_Materno_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPIFecha_de_Nacimiento_del_Abogado').val(prevData.Fecha_de_Nacimiento_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPIEdad_del_Abogado').val(prevData.Edad_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPISexo_del_Abogado').val(prevData.Sexo_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPIEstado_Civil_del_Abogado').val(prevData.Estado_Civil_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPITipo_de_Identificacion_del_Abogado').val(prevData.Tipo_de_Identificacion_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPINumero_de_Identificacion_del_Abogado').val(prevData.Numero_de_Identificacion_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPINacionalidad_del_Abogado').val(prevData.Nacionalidad_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPICedula_Profesional_del_Abogado').val(prevData.Cedula_Profesional_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPIPais_del_Abogado').val(prevData.Pais_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPIEstado_del_Abogado').val(prevData.Estado_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPIMunicipio_del_Abogado').val(prevData.Municipio_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPIColonia_del_Abogado').val(prevData.Colonia_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPICodigo_Postal_del_Abogado').val(prevData.Codigo_Postal_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPICalle_del_Abogado').val(prevData.Calle_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPINumero_Exterior_del_Abogado').val(prevData.Numero_Exterior_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPINumero_Interior_del_Abogado').val(prevData.Numero_Interior_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPITelefono_del_Abogado').val(prevData.Telefono_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPICelular_del_Abogado').val(prevData.Celular_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPICorreo_Electronico_del_Abogado').val(prevData.Correo_Electronico_del_Abogado);
    $('#Detalle_del_Abogado_Imputado_MPIAceptar_Notificaciones').prop('checked', prevData.Aceptar_Notificaciones);

    initiateUIControls();


























}

function Detalle_del_Abogado_Imputado_MPIAddInsertRow() {
    if (Detalle_del_Abogado_Imputado_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_del_Abogado_Imputado_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Consecutivo: null,
        IsInsertRow: true

        ,Nombre_Completo_del_Abogado: ""
        ,Nombre_del_Abogado: ""
        ,Apellido_Paterno_del_Abogado: ""
        ,Apellido_Materno_del_Abogado: ""
        ,Fecha_de_Nacimiento_del_Abogado: ""
        ,Edad_del_Abogado: ""
        ,Sexo_del_Abogado: ""
        ,Estado_Civil_del_Abogado: ""
        ,Tipo_de_Identificacion_del_Abogado: ""
        ,Numero_de_Identificacion_del_Abogado: ""
        ,Nacionalidad_del_Abogado: ""
        ,Cedula_Profesional_del_Abogado: ""
        ,Pais_del_Abogado: ""
        ,Estado_del_Abogado: ""
        ,Municipio_del_Abogado: ""
        ,Colonia_del_Abogado: ""
        ,Codigo_Postal_del_Abogado: ""
        ,Calle_del_Abogado: ""
        ,Numero_Exterior_del_Abogado: ""
        ,Numero_Interior_del_Abogado: ""
        ,Telefono_del_Abogado: ""
        ,Celular_del_Abogado: ""
        ,Correo_Electronico_del_Abogado: ""
        ,Aceptar_Notificaciones: ""

    }
}

function Detalle_del_Abogado_Imputado_MPIfnClickAddRow() {
    Detalle_del_Abogado_Imputado_MPIcountRowsChecked++;
    Detalle_del_Abogado_Imputado_MPITable.fnAddData(Detalle_del_Abogado_Imputado_MPIAddInsertRow(), true);
    Detalle_del_Abogado_Imputado_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_del_Abogado_Imputado_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_del_Abogado_Imputado_MPIGrid tbody tr:nth-of-type(' + (Detalle_del_Abogado_Imputado_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_del_Abogado_Imputado_MPI("Detalle_del_Abogado_Imputado_MPI_", "_" + Detalle_del_Abogado_Imputado_MPIinsertRowCurrentIndex);
}

function Detalle_del_Abogado_Imputado_MPIClearGridData() {
    Detalle_del_Abogado_Imputado_MPIData = [];
    Detalle_del_Abogado_Imputado_MPIdeletedItem = [];
    Detalle_del_Abogado_Imputado_MPIDataMain = [];
    Detalle_del_Abogado_Imputado_MPIDataMainPages = [];
    Detalle_del_Abogado_Imputado_MPInewItemCount = 0;
    Detalle_del_Abogado_Imputado_MPImaxItemIndex = 0;
    $("#Detalle_del_Abogado_Imputado_MPIGrid").DataTable().clear();
    $("#Detalle_del_Abogado_Imputado_MPIGrid").DataTable().destroy();
}

//Used to Get Detalle de Datos del Imputado Information
function GetDetalle_del_Abogado_Imputado_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_del_Abogado_Imputado_MPIData.length; i++) {
        form_data.append('[' + i + '].Consecutivo', Detalle_del_Abogado_Imputado_MPIData[i].Consecutivo);

        form_data.append('[' + i + '].Nombre_Completo_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Nombre_Completo_del_Abogado);
        form_data.append('[' + i + '].Nombre_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Nombre_del_Abogado);
        form_data.append('[' + i + '].Apellido_Paterno_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Apellido_Paterno_del_Abogado);
        form_data.append('[' + i + '].Apellido_Materno_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Apellido_Materno_del_Abogado);
        form_data.append('[' + i + '].Fecha_de_Nacimiento_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Fecha_de_Nacimiento_del_Abogado);
        form_data.append('[' + i + '].Edad_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Edad_del_Abogado);
        form_data.append('[' + i + '].Sexo_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Sexo_del_Abogado);
        form_data.append('[' + i + '].Estado_Civil_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Estado_Civil_del_Abogado);
        form_data.append('[' + i + '].Tipo_de_Identificacion_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Tipo_de_Identificacion_del_Abogado);
        form_data.append('[' + i + '].Numero_de_Identificacion_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Numero_de_Identificacion_del_Abogado);
        form_data.append('[' + i + '].Nacionalidad_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Nacionalidad_del_Abogado);
        form_data.append('[' + i + '].Cedula_Profesional_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Cedula_Profesional_del_Abogado);
        form_data.append('[' + i + '].Pais_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Pais_del_Abogado);
        form_data.append('[' + i + '].Estado_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Estado_del_Abogado);
        form_data.append('[' + i + '].Municipio_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Municipio_del_Abogado);
        form_data.append('[' + i + '].Colonia_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Colonia_del_Abogado);
        form_data.append('[' + i + '].Codigo_Postal_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Codigo_Postal_del_Abogado);
        form_data.append('[' + i + '].Calle_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Calle_del_Abogado);
        form_data.append('[' + i + '].Numero_Exterior_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Numero_Exterior_del_Abogado);
        form_data.append('[' + i + '].Numero_Interior_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Numero_Interior_del_Abogado);
        form_data.append('[' + i + '].Telefono_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Telefono_del_Abogado);
        form_data.append('[' + i + '].Celular_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Celular_del_Abogado);
        form_data.append('[' + i + '].Correo_Electronico_del_Abogado', Detalle_del_Abogado_Imputado_MPIData[i].Correo_Electronico_del_Abogado);
        form_data.append('[' + i + '].Aceptar_Notificaciones', Detalle_del_Abogado_Imputado_MPIData[i].Aceptar_Notificaciones);

        form_data.append('[' + i + '].Removed', Detalle_del_Abogado_Imputado_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_del_Abogado_Imputado_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_del_Abogado_Imputado_MPI("Detalle_del_Abogado_Imputado_MPITable", rowIndex)) {
    var prevData = Detalle_del_Abogado_Imputado_MPITable.fnGetData(rowIndex);
    var data = Detalle_del_Abogado_Imputado_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Consecutivo: prevData.Consecutivo,
        IsInsertRow: false

        ,Nombre_Completo_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPINombre_Completo_del_Abogado').val()
        ,Nombre_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPINombre_del_Abogado').val()
        ,Apellido_Paterno_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPIApellido_Paterno_del_Abogado').val()
        ,Apellido_Materno_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPIApellido_Materno_del_Abogado').val()
        ,Fecha_de_Nacimiento_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPIFecha_de_Nacimiento_del_Abogado').val()
        ,Edad_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPIEdad_del_Abogado').val()

        ,Sexo_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPISexo_del_Abogado').val()
        ,Estado_Civil_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPIEstado_Civil_del_Abogado').val()
        ,Tipo_de_Identificacion_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPITipo_de_Identificacion_del_Abogado').val()
        ,Numero_de_Identificacion_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPINumero_de_Identificacion_del_Abogado').val()
        ,Nacionalidad_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPINacionalidad_del_Abogado').val()
        ,Cedula_Profesional_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPICedula_Profesional_del_Abogado').val()
        ,Pais_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPIPais_del_Abogado').val()
        ,Estado_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPIEstado_del_Abogado').val()
        ,Municipio_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPIMunicipio_del_Abogado').val()
        ,Colonia_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPIColonia_del_Abogado').val()
        ,Codigo_Postal_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPICodigo_Postal_del_Abogado').val()

        ,Calle_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPICalle_del_Abogado').val()
        ,Numero_Exterior_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPINumero_Exterior_del_Abogado').val()
        ,Numero_Interior_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPINumero_Interior_del_Abogado').val()
        ,Telefono_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPITelefono_del_Abogado').val()
        ,Celular_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPICelular_del_Abogado').val()
        ,Correo_Electronico_del_Abogado: $('#Detalle_del_Abogado_Imputado_MPICorreo_Electronico_del_Abogado').val()
        ,Aceptar_Notificaciones: $('#Detalle_del_Abogado_Imputado_MPIAceptar_Notificaciones').is(':checked')

    }

    Detalle_del_Abogado_Imputado_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_del_Abogado_Imputado_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_del_Abogado_Imputado_MPI-form').modal({ show: false });
    $('#AddDetalle_del_Abogado_Imputado_MPI-form').modal('hide');
    Detalle_del_Abogado_Imputado_MPIEditRow(rowIndex);
    Detalle_del_Abogado_Imputado_MPIInsertRow(rowIndex);
    //}
}
function Detalle_del_Abogado_Imputado_MPIRemoveAddRow(rowIndex) {
    Detalle_del_Abogado_Imputado_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_del_Abogado_Imputado_MPI MultiRow
//Begin Declarations for Foreigns fields for Detalle_de_Sentencias_Imputado_MPI MultiRow
var Detalle_de_Sentencias_Imputado_MPIcountRowsChecked = 0;

function GetDetalle_de_Sentencias_Imputado_MPI_DelitoName(Id) {
    for (var i = 0; i < Detalle_de_Sentencias_Imputado_MPI_DelitoItems.length; i++) {
        if (Detalle_de_Sentencias_Imputado_MPI_DelitoItems[i].Clave == Id) {
            return Detalle_de_Sentencias_Imputado_MPI_DelitoItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Sentencias_Imputado_MPI_DelitoDropDown() {
    var Detalle_de_Sentencias_Imputado_MPI_DelitoDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Sentencias_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Sentencias_Imputado_MPI_DelitoDropdown);
    if(Detalle_de_Sentencias_Imputado_MPI_DelitoItems != null)
    {
       for (var i = 0; i < Detalle_de_Sentencias_Imputado_MPI_DelitoItems.length; i++) {
           $('<option />', { value: Detalle_de_Sentencias_Imputado_MPI_DelitoItems[i].Clave, text:    Detalle_de_Sentencias_Imputado_MPI_DelitoItems[i].Descripcion }).appendTo(Detalle_de_Sentencias_Imputado_MPI_DelitoDropdown);
       }
    }
    return Detalle_de_Sentencias_Imputado_MPI_DelitoDropdown;
}
function GetDetalle_de_Sentencias_Imputado_MPI_SentenciaName(Id) {
    for (var i = 0; i < Detalle_de_Sentencias_Imputado_MPI_SentenciaItems.length; i++) {
        if (Detalle_de_Sentencias_Imputado_MPI_SentenciaItems[i].Clave == Id) {
            return Detalle_de_Sentencias_Imputado_MPI_SentenciaItems[i].Descripcion;
        }
    }
    return "";
}

function GetDetalle_de_Sentencias_Imputado_MPI_SentenciaDropDown() {
    var Detalle_de_Sentencias_Imputado_MPI_SentenciaDropdown = $('<select class="form-control" />');      var labelSelect = $("#Detalle_de_Sentencias_Imputado_MPI_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Detalle_de_Sentencias_Imputado_MPI_SentenciaDropdown);
    if(Detalle_de_Sentencias_Imputado_MPI_SentenciaItems != null)
    {
       for (var i = 0; i < Detalle_de_Sentencias_Imputado_MPI_SentenciaItems.length; i++) {
           $('<option />', { value: Detalle_de_Sentencias_Imputado_MPI_SentenciaItems[i].Clave, text:    Detalle_de_Sentencias_Imputado_MPI_SentenciaItems[i].Descripcion }).appendTo(Detalle_de_Sentencias_Imputado_MPI_SentenciaDropdown);
       }
    }
    return Detalle_de_Sentencias_Imputado_MPI_SentenciaDropdown;
}






function GetInsertDetalle_de_Sentencias_Imputado_MPIRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetDetalle_de_Sentencias_Imputado_MPI_DelitoDropDown()).addClass('Detalle_de_Sentencias_Imputado_MPI_Delito Delito').attr('id', 'Detalle_de_Sentencias_Imputado_MPI_Delito_' + index).attr('data-field', 'Delito').after($.parseHTML(addNew('Detalle_de_Sentencias_Imputado_MPI', 'Delito', 'Delito', 264850)));
    columnData[1] = $(GetDetalle_de_Sentencias_Imputado_MPI_SentenciaDropDown()).addClass('Detalle_de_Sentencias_Imputado_MPI_Sentencia Sentencia').attr('id', 'Detalle_de_Sentencias_Imputado_MPI_Sentencia_' + index).attr('data-field', 'Sentencia').after($.parseHTML(addNew('Detalle_de_Sentencias_Imputado_MPI', 'Sentencia', 'Sentencia', 264851)));
    columnData[2] = $($.parseHTML(GetGridDatePicker())).addClass('Detalle_de_Sentencias_Imputado_MPI_Fecha_de_Devolucion Fecha_de_Devolucion').attr('id', 'Detalle_de_Sentencias_Imputado_MPI_Fecha_de_Devolucion_' + index).attr('data-field', 'Fecha_de_Devolucion');
    columnData[3] = $($.parseHTML(GetGridTimePicker())).addClass('Detalle_de_Sentencias_Imputado_MPI_Hora_de_Devolucion Hora_de_Devolucion').attr('id', 'Detalle_de_Sentencias_Imputado_MPI_Hora_de_Devolucion_' + index).attr('data-field', 'Hora_de_Devolucion');
    columnData[4] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Detalle_de_Sentencias_Imputado_MPI_Repacion_del_Dano Repacion_del_Dano inputMoney').attr('id', 'Detalle_de_Sentencias_Imputado_MPI_Repacion_del_Dano_' + index).attr('data-field', 'Repacion_del_Dano');
    columnData[5] = $($.parseHTML(inputData)).addClass('Detalle_de_Sentencias_Imputado_MPI_Resolucion Resolucion').attr('id', 'Detalle_de_Sentencias_Imputado_MPI_Resolucion_' + index).attr('data-field', 'Resolucion');


    initiateUIControls();
    return columnData;
}

function Detalle_de_Sentencias_Imputado_MPIInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Sentencias_Imputado_MPI("Detalle_de_Sentencias_Imputado_MPI_", "_" + rowIndex)) {
    var iPage = Detalle_de_Sentencias_Imputado_MPITable.fnPagingInfo().iPage;
    var nameOfGrid = 'Detalle_de_Sentencias_Imputado_MPI';
    var prevData = Detalle_de_Sentencias_Imputado_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Sentencias_Imputado_MPITable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Delito:  data.childNodes[counter++].childNodes[0].value
        ,Sentencia:  data.childNodes[counter++].childNodes[0].value
        ,Fecha_de_Devolucion:  data.childNodes[counter++].childNodes[0].value
        ,Hora_de_Devolucion:  data.childNodes[counter++].childNodes[0].value
        ,Repacion_del_Dano:  data.childNodes[counter++].childNodes[0].value
        ,Resolucion:  data.childNodes[counter++].childNodes[0].value

    }
    Detalle_de_Sentencias_Imputado_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Sentencias_Imputado_MPIrowCreationGrid(data, newData, rowIndex);
    Detalle_de_Sentencias_Imputado_MPITable.fnPageChange(iPage);
    Detalle_de_Sentencias_Imputado_MPIcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRDetalle_de_Sentencias_Imputado_MPI("Detalle_de_Sentencias_Imputado_MPI_", "_" + rowIndex);
  }
}

function Detalle_de_Sentencias_Imputado_MPICancelRow(rowIndex) {
    var prevData = Detalle_de_Sentencias_Imputado_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Sentencias_Imputado_MPITable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Detalle_de_Sentencias_Imputado_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Detalle_de_Sentencias_Imputado_MPIrowCreationGrid(data, prevData, rowIndex);
    }
	showDetalle_de_Sentencias_Imputado_MPIGrid(Detalle_de_Sentencias_Imputado_MPITable.fnGetData());
    Detalle_de_Sentencias_Imputado_MPIcountRowsChecked--;
	initiateUIControls();
}

function GetDetalle_de_Sentencias_Imputado_MPIFromDataTable() {
    var Detalle_de_Sentencias_Imputado_MPIData = [];
    var gridData = Detalle_de_Sentencias_Imputado_MPITable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Detalle_de_Sentencias_Imputado_MPIData.push({
                Clave: gridData[i].Clave

                ,Delito: gridData[i].Delito
                ,Sentencia: gridData[i].Sentencia
                ,Fecha_de_Devolucion: gridData[i].Fecha_de_Devolucion
                ,Hora_de_Devolucion: gridData[i].Hora_de_Devolucion
                ,Repacion_del_Dano: gridData[i].Repacion_del_Dano
                ,Resolucion: gridData[i].Resolucion

                ,Removed: false
            });
    }

    for (i = 0; i < removedDetalle_de_Sentencias_Imputado_MPIData.length; i++) {
        if (removedDetalle_de_Sentencias_Imputado_MPIData[i] != null && removedDetalle_de_Sentencias_Imputado_MPIData[i].Clave > 0)
            Detalle_de_Sentencias_Imputado_MPIData.push({
                Clave: removedDetalle_de_Sentencias_Imputado_MPIData[i].Clave

                ,Delito: removedDetalle_de_Sentencias_Imputado_MPIData[i].Delito
                ,Sentencia: removedDetalle_de_Sentencias_Imputado_MPIData[i].Sentencia
                ,Fecha_de_Devolucion: removedDetalle_de_Sentencias_Imputado_MPIData[i].Fecha_de_Devolucion
                ,Hora_de_Devolucion: removedDetalle_de_Sentencias_Imputado_MPIData[i].Hora_de_Devolucion
                ,Repacion_del_Dano: removedDetalle_de_Sentencias_Imputado_MPIData[i].Repacion_del_Dano
                ,Resolucion: removedDetalle_de_Sentencias_Imputado_MPIData[i].Resolucion

                , Removed: true
            });
    }	

    return Detalle_de_Sentencias_Imputado_MPIData;
}

function Detalle_de_Sentencias_Imputado_MPIEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Detalle_de_Sentencias_Imputado_MPITable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Detalle_de_Sentencias_Imputado_MPIcountRowsChecked++;
    var Detalle_de_Sentencias_Imputado_MPIRowElement = "Detalle_de_Sentencias_Imputado_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Sentencias_Imputado_MPITable.fnGetData(rowIndexTable );
    var row = Detalle_de_Sentencias_Imputado_MPITable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Detalle_de_Sentencias_Imputado_MPI_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Detalle_de_Sentencias_Imputado_MPIGetUpdateRowControls(prevData, "Detalle_de_Sentencias_Imputado_MPI_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Detalle_de_Sentencias_Imputado_MPIRowElement + "')){ Detalle_de_Sentencias_Imputado_MPIInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Detalle_de_Sentencias_Imputado_MPICancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Detalle_de_Sentencias_Imputado_MPIGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Detalle_de_Sentencias_Imputado_MPIGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setDetalle_de_Sentencias_Imputado_MPIValidation();
    initiateUIControls();
    $('.Detalle_de_Sentencias_Imputado_MPI' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRDetalle_de_Sentencias_Imputado_MPI(nameOfTable, rowIndexFormed);
    }
}

function Detalle_de_Sentencias_Imputado_MPIfnOpenAddRowPopUp() {
    var currentRowIndex = Detalle_de_Sentencias_Imputado_MPITable.fnGetData().length;
    Detalle_de_Sentencias_Imputado_MPIfnClickAddRow();
    GetAddDetalle_de_Sentencias_Imputado_MPIPopup(currentRowIndex, 0);
}

function Detalle_de_Sentencias_Imputado_MPIEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Detalle_de_Sentencias_Imputado_MPITable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Detalle_de_Sentencias_Imputado_MPIRowElement = "Detalle_de_Sentencias_Imputado_MPI_" + rowIndex.toString();
    var prevData = Detalle_de_Sentencias_Imputado_MPITable.fnGetData(rowIndexTable);
    GetAddDetalle_de_Sentencias_Imputado_MPIPopup(rowIndex, 1, prevData.Clave);

    $('#Detalle_de_Sentencias_Imputado_MPIDelito').val(prevData.Delito);
    $('#Detalle_de_Sentencias_Imputado_MPISentencia').val(prevData.Sentencia);
    $('#Detalle_de_Sentencias_Imputado_MPIFecha_de_Devolucion').val(prevData.Fecha_de_Devolucion);
    $('#Detalle_de_Sentencias_Imputado_MPIHora_de_Devolucion').val(prevData.Hora_de_Devolucion);
    $('#Detalle_de_Sentencias_Imputado_MPIRepacion_del_Dano').val(prevData.Repacion_del_Dano);
    $('#Detalle_de_Sentencias_Imputado_MPIResolucion').val(prevData.Resolucion);

    initiateUIControls();








}

function Detalle_de_Sentencias_Imputado_MPIAddInsertRow() {
    if (Detalle_de_Sentencias_Imputado_MPIinsertRowCurrentIndex < 1)
    {
        Detalle_de_Sentencias_Imputado_MPIinsertRowCurrentIndex = 1;
    }
    return {
        Clave: null,
        IsInsertRow: true

        ,Delito: ""
        ,Sentencia: ""
        ,Fecha_de_Devolucion: ""
        ,Hora_de_Devolucion: ""
        ,Repacion_del_Dano: ""
        ,Resolucion: ""

    }
}

function Detalle_de_Sentencias_Imputado_MPIfnClickAddRow() {
    Detalle_de_Sentencias_Imputado_MPIcountRowsChecked++;
    Detalle_de_Sentencias_Imputado_MPITable.fnAddData(Detalle_de_Sentencias_Imputado_MPIAddInsertRow(), true);
    Detalle_de_Sentencias_Imputado_MPITable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Detalle_de_Sentencias_Imputado_MPIGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Detalle_de_Sentencias_Imputado_MPIGrid tbody tr:nth-of-type(' + (Detalle_de_Sentencias_Imputado_MPIinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRDetalle_de_Sentencias_Imputado_MPI("Detalle_de_Sentencias_Imputado_MPI_", "_" + Detalle_de_Sentencias_Imputado_MPIinsertRowCurrentIndex);
}

function Detalle_de_Sentencias_Imputado_MPIClearGridData() {
    Detalle_de_Sentencias_Imputado_MPIData = [];
    Detalle_de_Sentencias_Imputado_MPIdeletedItem = [];
    Detalle_de_Sentencias_Imputado_MPIDataMain = [];
    Detalle_de_Sentencias_Imputado_MPIDataMainPages = [];
    Detalle_de_Sentencias_Imputado_MPInewItemCount = 0;
    Detalle_de_Sentencias_Imputado_MPImaxItemIndex = 0;
    $("#Detalle_de_Sentencias_Imputado_MPIGrid").DataTable().clear();
    $("#Detalle_de_Sentencias_Imputado_MPIGrid").DataTable().destroy();
}

//Used to Get Detalle de Datos del Imputado Information
function GetDetalle_de_Sentencias_Imputado_MPI() {
    var form_data = new FormData();
    for (var i = 0; i < Detalle_de_Sentencias_Imputado_MPIData.length; i++) {
        form_data.append('[' + i + '].Clave', Detalle_de_Sentencias_Imputado_MPIData[i].Clave);

        form_data.append('[' + i + '].Delito', Detalle_de_Sentencias_Imputado_MPIData[i].Delito);
        form_data.append('[' + i + '].Sentencia', Detalle_de_Sentencias_Imputado_MPIData[i].Sentencia);
        form_data.append('[' + i + '].Fecha_de_Devolucion', Detalle_de_Sentencias_Imputado_MPIData[i].Fecha_de_Devolucion);
        form_data.append('[' + i + '].Hora_de_Devolucion', Detalle_de_Sentencias_Imputado_MPIData[i].Hora_de_Devolucion);
        form_data.append('[' + i + '].Repacion_del_Dano', Detalle_de_Sentencias_Imputado_MPIData[i].Repacion_del_Dano.toString().replace('$',''));
        form_data.append('[' + i + '].Resolucion', Detalle_de_Sentencias_Imputado_MPIData[i].Resolucion);

        form_data.append('[' + i + '].Removed', Detalle_de_Sentencias_Imputado_MPIData[i].Removed);
    }
    return form_data;
}
function Detalle_de_Sentencias_Imputado_MPIInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRDetalle_de_Sentencias_Imputado_MPI("Detalle_de_Sentencias_Imputado_MPITable", rowIndex)) {
    var prevData = Detalle_de_Sentencias_Imputado_MPITable.fnGetData(rowIndex);
    var data = Detalle_de_Sentencias_Imputado_MPITable.fnGetNodes(rowIndex);
    var newData = {
        Clave: prevData.Clave,
        IsInsertRow: false

        ,Delito: $('#Detalle_de_Sentencias_Imputado_MPIDelito').val()
        ,Sentencia: $('#Detalle_de_Sentencias_Imputado_MPISentencia').val()
        ,Fecha_de_Devolucion: $('#Detalle_de_Sentencias_Imputado_MPIFecha_de_Devolucion').val()
        ,Hora_de_Devolucion: $('#Detalle_de_Sentencias_Imputado_MPIHora_de_Devolucion').val()
        ,Repacion_del_Dano: $('#Detalle_de_Sentencias_Imputado_MPIRepacion_del_Dano').val()
        ,Resolucion: $('#Detalle_de_Sentencias_Imputado_MPIResolucion').val()

    }

    Detalle_de_Sentencias_Imputado_MPITable.fnUpdate(newData, rowIndex, null, true);
    Detalle_de_Sentencias_Imputado_MPIrowCreationGrid(data, newData, rowIndex);
    $('#AddDetalle_de_Sentencias_Imputado_MPI-form').modal({ show: false });
    $('#AddDetalle_de_Sentencias_Imputado_MPI-form').modal('hide');
    Detalle_de_Sentencias_Imputado_MPIEditRow(rowIndex);
    Detalle_de_Sentencias_Imputado_MPIInsertRow(rowIndex);
    //}
}
function Detalle_de_Sentencias_Imputado_MPIRemoveAddRow(rowIndex) {
    Detalle_de_Sentencias_Imputado_MPITable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Detalle_de_Sentencias_Imputado_MPI MultiRow


$(function () {
    function Detalle_del_Abogado_Imputado_MPIinitializeMainArray(totalCount) {
        if (Detalle_del_Abogado_Imputado_MPIDataMain.length != totalCount && !Detalle_del_Abogado_Imputado_MPIDataMainInitialized) {
            Detalle_del_Abogado_Imputado_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_del_Abogado_Imputado_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_del_Abogado_Imputado_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_del_Abogado_Imputado_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_del_Abogado_Imputado_MPIDataMain.length; i++) {
                if (Detalle_del_Abogado_Imputado_MPIDataMain[i] != null && Detalle_del_Abogado_Imputado_MPIDataMain[i].Id == Detalle_del_Abogado_Imputado_MPIdeletedItem[j]) {
                    hDetalle_del_Abogado_Imputado_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_del_Abogado_Imputado_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_del_Abogado_Imputado_MPIDataMain.length; i++) {
            data[i] = Detalle_del_Abogado_Imputado_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_del_Abogado_Imputado_MPIgetNewResult() {
        var newData = copyMainDetalle_del_Abogado_Imputado_MPIArray();

        for (var i = 0; i < Detalle_del_Abogado_Imputado_MPIData.length; i++) {
            if (Detalle_del_Abogado_Imputado_MPIData[i].Removed == null || Detalle_del_Abogado_Imputado_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_del_Abogado_Imputado_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_del_Abogado_Imputado_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_del_Abogado_Imputado_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_del_Abogado_Imputado_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Detalle_de_Sentencias_Imputado_MPIinitializeMainArray(totalCount) {
        if (Detalle_de_Sentencias_Imputado_MPIDataMain.length != totalCount && !Detalle_de_Sentencias_Imputado_MPIDataMainInitialized) {
            Detalle_de_Sentencias_Imputado_MPIDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Detalle_de_Sentencias_Imputado_MPIDataMain[i] = null;
            }
        }
    }
    function Detalle_de_Sentencias_Imputado_MPIremoveFromMainArray() {
        for (var j = 0; j < Detalle_de_Sentencias_Imputado_MPIdeletedItem.length; j++) {
            for (var i = 0; i < Detalle_de_Sentencias_Imputado_MPIDataMain.length; i++) {
                if (Detalle_de_Sentencias_Imputado_MPIDataMain[i] != null && Detalle_de_Sentencias_Imputado_MPIDataMain[i].Id == Detalle_de_Sentencias_Imputado_MPIdeletedItem[j]) {
                    hDetalle_de_Sentencias_Imputado_MPIDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Detalle_de_Sentencias_Imputado_MPIcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Detalle_de_Sentencias_Imputado_MPIDataMain.length; i++) {
            data[i] = Detalle_de_Sentencias_Imputado_MPIDataMain[i];

        }
        return data;
    }
    function Detalle_de_Sentencias_Imputado_MPIgetNewResult() {
        var newData = copyMainDetalle_de_Sentencias_Imputado_MPIArray();

        for (var i = 0; i < Detalle_de_Sentencias_Imputado_MPIData.length; i++) {
            if (Detalle_de_Sentencias_Imputado_MPIData[i].Removed == null || Detalle_de_Sentencias_Imputado_MPIData[i].Removed == false) {
                newData.splice(0, 0, Detalle_de_Sentencias_Imputado_MPIData[i]);
            }
        }
        return newData;
    }
    function Detalle_de_Sentencias_Imputado_MPIpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Detalle_de_Sentencias_Imputado_MPIDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Detalle_de_Sentencias_Imputado_MPIDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

var AutoCompleteForma_de_OjosData = [];
function GetAutoCompleteDetalle_de_Datos_del_Imputado_MPI_Forma_de_Ojos_Forma_OjosData(data) {
	AutoCompleteForma_de_OjosData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteForma_de_OjosData.push({
            id: data[i].Clave,
            text: data[i].Descripcion
        });
    }
    return AutoCompleteForma_de_OjosData;
}
//Grid GetAutocomplete

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Detalle_de_Datos_del_Imputado_MPI_cmbLabelSelect").val();
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
    $('#CreateDetalle_de_Datos_del_Imputado_MPI')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Forma_de_Ojos').empty();
    $("#Forma_de_Ojos").append('<option value=""></option>');
    $('#Forma_de_Ojos').val('0').trigger('change');
                Detalle_del_Abogado_Imputado_MPIClearGridData();
                Detalle_de_Sentencias_Imputado_MPIClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateDetalle_de_Datos_del_Imputado_MPI').trigger('reset');
    $('#CreateDetalle_de_Datos_del_Imputado_MPI').find(':input').each(function () {
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
    var $myForm = $('#CreateDetalle_de_Datos_del_Imputado_MPI');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Detalle_del_Abogado_Imputado_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_del_Abogado_Imputado_MPI();
        return false;
    }
    if (Detalle_de_Sentencias_Imputado_MPIcountRowsChecked > 0)
    {
        ShowMessagePendingRowDetalle_de_Sentencias_Imputado_MPI();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateDetalle_de_Datos_del_Imputado_MPI").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateDetalle_de_Datos_del_Imputado_MPI").on('click', '#Detalle_de_Datos_del_Imputado_MPICancelar', function () {
	  if (!isPartial) {
        Detalle_de_Datos_del_Imputado_MPIBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateDetalle_de_Datos_del_Imputado_MPI").on('click', '#Detalle_de_Datos_del_Imputado_MPIGuardar', function () {
		$('#Detalle_de_Datos_del_Imputado_MPIGuardar').attr('disabled', true);
		$('#Detalle_de_Datos_del_Imputado_MPIGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendDetalle_de_Datos_del_Imputado_MPIData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Detalle_de_Datos_del_Imputado_MPIBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Detalle_de_Datos_del_Imputado_MPIGuardar').removeAttr('disabled');
                        $('#Detalle_de_Datos_del_Imputado_MPIGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Detalle_de_Datos_del_Imputado_MPI', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_MPIItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_MPIDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Detalle_de_Datos_del_Imputado_MPIGuardar').removeAttr('disabled');
					$('#Detalle_de_Datos_del_Imputado_MPIGuardar').bind()
				}
		}
		else {
			$('#Detalle_de_Datos_del_Imputado_MPIGuardar').removeAttr('disabled');
			$('#Detalle_de_Datos_del_Imputado_MPIGuardar').bind()
		}
    });
	$("form#CreateDetalle_de_Datos_del_Imputado_MPI").on('click', '#Detalle_de_Datos_del_Imputado_MPIGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendDetalle_de_Datos_del_Imputado_MPIData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getDetalle_del_Abogado_Imputado_MPIData();
                getDetalle_de_Sentencias_Imputado_MPIData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Datos_del_Imputado_MPI', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_MPIItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_MPIDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateDetalle_de_Datos_del_Imputado_MPI").on('click', '#Detalle_de_Datos_del_Imputado_MPIGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendDetalle_de_Datos_del_Imputado_MPIData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Forma_de_Ojos').empty();
    $("#Forma_de_Ojos").append('<option value=""></option>');
    $('#Forma_de_Ojos').val('0').trigger('change');
                Detalle_del_Abogado_Imputado_MPIClearGridData();
                Detalle_de_Sentencias_Imputado_MPIClearGridData();

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	                getDetalle_del_Abogado_Imputado_MPIData();
                getDetalle_de_Sentencias_Imputado_MPIData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Detalle_de_Datos_del_Imputado_MPI',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_MPIItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Detalle_de_Datos_del_Imputado_MPIDropDown().get(0)').innerHTML);                          
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



var Detalle_de_Datos_del_Imputado_MPIisdisplayBusinessPropery = false;
Detalle_de_Datos_del_Imputado_MPIDisplayBusinessRuleButtons(Detalle_de_Datos_del_Imputado_MPIisdisplayBusinessPropery);
function Detalle_de_Datos_del_Imputado_MPIDisplayBusinessRule() {
    if (!Detalle_de_Datos_del_Imputado_MPIisdisplayBusinessPropery) {
        $('#CreateDetalle_de_Datos_del_Imputado_MPI').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Detalle_de_Datos_del_Imputado_MPIdisplayBusinessPropery"><button onclick="Detalle_de_Datos_del_Imputado_MPIGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Detalle_de_Datos_del_Imputado_MPIBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Detalle_de_Datos_del_Imputado_MPIdisplayBusinessPropery').remove();
    }
    Detalle_de_Datos_del_Imputado_MPIDisplayBusinessRuleButtons(!Detalle_de_Datos_del_Imputado_MPIisdisplayBusinessPropery);
    Detalle_de_Datos_del_Imputado_MPIisdisplayBusinessPropery = (Detalle_de_Datos_del_Imputado_MPIisdisplayBusinessPropery ? false : true);
}
function Detalle_de_Datos_del_Imputado_MPIDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

