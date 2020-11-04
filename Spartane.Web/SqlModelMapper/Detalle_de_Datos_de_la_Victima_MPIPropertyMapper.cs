using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_de_la_Victima_MPI;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Datos_de_la_Victima_MPIPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Clave";
                case "Nombre":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Apellido_Materno";
                case "Nombre_Completo":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Nombre_Completo";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Fecha_de_Nacimiento";
                case "Edad":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Edad";
                case "Sexo[Descripcion]":
                case "SexoDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil[Descripcion]":
                case "Estado_CivilDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion[Nombre]":
                case "Tipo_de_IdentificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_de_Identificacion";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Codigo_Postal";
                case "Calle":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_Interior";
                case "Telefono":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Telefono";
                case "Extencion":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Extencion";
                case "Celular":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Correo_Electronico";
                case "Incapaz":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Incapaz";
                case "Nombre_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Nombre_del_Tutor";
                case "Apellido_Paterno_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Apellido_Paterno_del_Tutor";
                case "Apellido_Materno_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Apellido_Materno_del_Tutor";
                case "Nombre_Completo_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Nombre_Completo_del_Tutor";
                case "Fecha_de_Nacimiento_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Fecha_de_Nacimiento_del_Tutor";
                case "Edad_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Edad_del_Tutor";
                case "Sexo_del_Tutor[Descripcion]":
                case "Sexo_del_TutorDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil_del_Tutor[Descripcion]":
                case "Estado_Civil_del_TutorDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion_del_Tutor[Nombre]":
                case "Tipo_de_Identificacion_del_TutorNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_de_Identificacion_del_Tutor";
                case "Nacionalidad_del_Tutor[NacionalidadC]":
                case "Nacionalidad_del_TutorNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad_del_Tutor[Descripcion]":
                case "Escolaridad_del_TutorDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion_del_Tutor[Descripcion]":
                case "Ocupacion_del_TutorDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais_del_Tutor[Nombre]":
                case "Pais_del_TutorNombre":
                    return "Pais.Nombre";
                case "Estado_del_Tutor[Nombre]":
                case "Estado_del_TutorNombre":
                    return "Estado.Nombre";
                case "Municipio_del_Tutor[Nombre]":
                case "Municipio_del_TutorNombre":
                    return "Municipio.Nombre";
                case "Localidad_del_Tutor[Descripcion]":
                case "Localidad_del_TutorDescripcion":
                    return "Localidad.Descripcion";
                case "Colonia_del_Tutor[Nombre]":
                case "Colonia_del_TutorNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Codigo_Postal_del_Tutor";
                case "Calle_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Calle_del_Tutor";
                case "Numero_Exterior_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_Exterior_del_Tutor";
                case "Numero_Interior_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_Interior_del_Tutor";
                case "Telefono_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Telefono_del_Tutor";
                case "Extencion_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Extencion_del_Tutor";
                case "Celular_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Celular_del_Tutor";
                case "Correo_Electronico_del_Tutor":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Correo_Electronico_del_Tutor";
                case "Tipo_de_Compareciente[Descripcion]":
                case "Tipo_de_ComparecienteDescripcion":
                    return "Tipo_de_Compareciente.Descripcion";
                case "Narrativa_de_los_Hechos":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Narrativa_de_los_Hechos";
                case "Titulo_del_Hecho":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Titulo_del_Hecho";
                case "Prioridad_del_Hecho[Descripcion]":
                case "Prioridad_del_HechoDescripcion":
                    return "Prioridad_del_Hecho.Descripcion";
                case "Fecha_del_Hecho":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Fecha_del_Hecho";
                case "Hora_Aproximada_del_Hecho":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Hora_Aproximada_del_Hecho";
                case "Pais_de_los_Hechos[Nombre]":
                case "Pais_de_los_HechosNombre":
                    return "Pais.Nombre";
                case "Estado_de_los_Hechos[Nombre]":
                case "Estado_de_los_HechosNombre":
                    return "Estado.Nombre";
                case "Municipio_de_los_Hechos[Nombre]":
                case "Municipio_de_los_HechosNombre":
                    return "Municipio.Nombre";
                case "Colonia_de_los_Hechos[Nombre]":
                case "Colonia_de_los_HechosNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_de_los_Hechos":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Codigo_Postal_de_los_Hechos";
                case "Calle_de_los_Hechos":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Calle_de_los_Hechos";
                case "Entre_Calle_de_los_Hechos":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Entre_Calle_de_los_Hechos";
                case "Y_Calle_de_los_Hechos":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Y_Calle_de_los_Hechos";
                case "Numero_Exterior_de_los_Hechos":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_Exterior_de_los_Hechos";
                case "Numero_Interior_de_los_Hechos":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_Interior_de_los_Hechos";
                case "Latitud_de_los_Hechos":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Latitud_de_los_Hechos";
                case "Longitud_de_los_Hechos":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Longitud_de_los_Hechos";
                case "Tipo_de_Lugar_del_Hecho[Descripcion]":
                case "Tipo_de_Lugar_del_HechoDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "Proteccion_de_Datos":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Proteccion_de_Datos";
                case "Nombre_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Nombre_de_Persona_Moral";
                case "Apellido_Paterno_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Apellido_Paterno_de_Persona_Moral";
                case "Apellido_Materno_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Apellido_Materno_de_Persona_Moral";
                case "Fecha_de_Nacimiento_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Fecha_de_Nacimiento_de_Persona_Moral";
                case "Edad_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Edad_de_Persona_Moral";
                case "Sexo_de_Persona_Moral[Descripcion]":
                case "Sexo_de_Persona_MoralDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil_de_Persona_Moral[Descripcion]":
                case "Estado_Civil_de_Persona_MoralDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion_de_Persona_Moral[Nombre]":
                case "Tipo_de_Identificacion_de_Persona_MoralNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion_de_Persona_Mora":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_de_Identificacion_de_Persona_Mora";
                case "Nacionalidad_de_Persona_Moral[NacionalidadC]":
                case "Nacionalidad_de_Persona_MoralNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad_de_Persona_Moral[Descripcion]":
                case "Escolaridad_de_Persona_MoralDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion_de_Persona_Moral[Descripcion]":
                case "Ocupacion_de_Persona_MoralDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais_de_Persona_Moral[Nombre]":
                case "Pais_de_Persona_MoralNombre":
                    return "Pais.Nombre";
                case "Estado_de_Persona_Moral[Nombre]":
                case "Estado_de_Persona_MoralNombre":
                    return "Estado.Nombre";
                case "Municipio_de_Persona_Moral[Nombre]":
                case "Municipio_de_Persona_MoralNombre":
                    return "Municipio.Nombre";
                case "Colonia_de_Persona_Moral[Nombre]":
                case "Colonia_de_Persona_MoralNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Codigo_Postal_de_Persona_Moral";
                case "Calle_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Calle_de_Persona_Moral";
                case "Numero_Exterior_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_Exterior_de_Persona_Moral";
                case "Numero_Interior_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Numero_Interior_de_Persona_Moral";
                case "Entre_Calle_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Entre_Calle_de_Persona_Moral";
                case "Y_Calle_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Y_Calle_de_Persona_Moral";
                case "Longitud_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Longitud_de_Persona_Moral";
                case "Latitud_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Latitud_de_Persona_Moral";
                case "Telefono_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Telefono_de_Persona_Moral";
                case "Extension_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Extension_de_Persona_Moral";
                case "Celular_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Celular_de_Persona_Moral";
                case "Correo_Electronico_de_Persona_Moral":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Correo_Electronico_de_Persona_Moral";
                case "Persona_Moral_Victima":
                    return "Detalle_de_Datos_de_la_Victima_MPI.Persona_Moral_Victima";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Datos_de_la_Victima_MPI).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Nacimiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Incapaz")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Nacimiento_del_Tutor")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_del_Hecho")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Proteccion_de_Datos")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Nacimiento_de_Persona_Moral")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Persona_Moral_Victima")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }


            var operatorCondition = GetOperationType(columnName);
            columnName = GetPropertyName(columnName);

            switch (operatorCondition)
            {
                case SqlOperationType.Contains:
                    return string.IsNullOrEmpty(Convert.ToString(value)) ? "" : columnName + " LIKE '%" + value + "%'";
                case SqlOperationType.Equals:
                    return Convert.ToString(value) == "0" || Convert.ToString(value) == "" ? "" : columnName + "='" + value + "'";

            }
            return null;
        }
    }
}

