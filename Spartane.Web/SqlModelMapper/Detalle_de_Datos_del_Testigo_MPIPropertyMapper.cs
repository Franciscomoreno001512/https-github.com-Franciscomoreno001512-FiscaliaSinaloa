using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_del_Testigo_MPI;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Datos_del_Testigo_MPIPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Datos_del_Testigo_MPI.Clave";
                case "Nombre":
                    return "Detalle_de_Datos_del_Testigo_MPI.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Datos_del_Testigo_MPI.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Datos_del_Testigo_MPI.Apellido_Materno";
                case "Nombre_Completo":
                    return "Detalle_de_Datos_del_Testigo_MPI.Nombre_Completo";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Datos_del_Testigo_MPI.Fecha_de_Nacimiento";
                case "Edad":
                    return "Detalle_de_Datos_del_Testigo_MPI.Edad";
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
                    return "Detalle_de_Datos_del_Testigo_MPI.Numero_de_Identificacion";
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
                    return "Detalle_de_Datos_del_Testigo_MPI.Codigo_Postal";
                case "Calle":
                    return "Detalle_de_Datos_del_Testigo_MPI.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Datos_del_Testigo_MPI.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Datos_del_Testigo_MPI.Numero_Interior";
                case "Telefono":
                    return "Detalle_de_Datos_del_Testigo_MPI.Telefono";
                case "Extencion":
                    return "Detalle_de_Datos_del_Testigo_MPI.Extencion";
                case "Celular":
                    return "Detalle_de_Datos_del_Testigo_MPI.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Datos_del_Testigo_MPI.Correo_Electronico";
                case "Incapaz":
                    return "Detalle_de_Datos_del_Testigo_MPI.Incapaz";
                case "Nombre_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Nombre_del_Tutor";
                case "Apellido_Paterno_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Apellido_Paterno_del_Tutor";
                case "Apellido_Materno_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Apellido_Materno_del_Tutor";
                case "Nombre_Completo_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Nombre_Completo_del_Tutor";
                case "Fecha_de_Nacimento_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Fecha_de_Nacimento_del_Tutor";
                case "Edad_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Edad_del_Tutor";
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
                    return "Detalle_de_Datos_del_Testigo_MPI.Numero_de_Identificacion_del_Tutor";
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
                case "Colonia_del_Tutor[Nombre]":
                case "Colonia_del_TutorNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Codigo_Postal_del_Tutor";
                case "Calle_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Calle_del_Tutor";
                case "Numero_Exterior_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Numero_Exterior_del_Tutor";
                case "Numero_Interior_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Numero_Interior_del_Tutor";
                case "Telefono_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Telefono_del_Tutor";
                case "Extencion_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Extencion_del_Tutor";
                case "Celular_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Celular_del_Tutor";
                case "Correo_Electronico_del_Tutor":
                    return "Detalle_de_Datos_del_Testigo_MPI.Correo_Electronico_del_Tutor";
                case "Tipo_de_Compareciente[Descripcion]":
                case "Tipo_de_ComparecienteDescripcion":
                    return "Tipo_de_Compareciente.Descripcion";
                case "Narrativa_del_Testigo":
                    return "Detalle_de_Datos_del_Testigo_MPI.Narrativa_del_Testigo";
                case "Titulo_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Titulo_del_Hecho";
                case "Prioridad_del_Hecho[Descripcion]":
                case "Prioridad_del_HechoDescripcion":
                    return "Prioridad_del_Hecho.Descripcion";
                case "Fecha_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Fecha_del_Hecho";
                case "Hora_Aproximada_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Hora_Aproximada_del_Hecho";
                case "Pais_del_Hecho[Nombre]":
                case "Pais_del_HechoNombre":
                    return "Pais.Nombre";
                case "Estado_del_Hecho[Nombre]":
                case "Estado_del_HechoNombre":
                    return "Estado.Nombre";
                case "Municipio_del_Hecho[Nombre]":
                case "Municipio_del_HechoNombre":
                    return "Municipio.Nombre";
                case "Colonia_del_Hecho[Nombre]":
                case "Colonia_del_HechoNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Codigo_Postal_del_Hecho";
                case "Calle_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Calle_del_Hecho";
                case "Entre_Calle_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Entre_Calle_del_Hecho";
                case "Y_Calle_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Y_Calle_del_Hecho";
                case "Numero_Exterior_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Numero_Exterior_del_Hecho";
                case "Numero_Interior_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Numero_Interior_del_Hecho";
                case "Latitud_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Latitud_del_Hecho";
                case "Longitud_del_Hecho":
                    return "Detalle_de_Datos_del_Testigo_MPI.Longitud_del_Hecho";
                case "Tipo_del_Lugar_del_Hecho[Descripcion]":
                case "Tipo_del_Lugar_del_HechoDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "Proteccion_de_Datos":
                    return "Detalle_de_Datos_del_Testigo_MPI.Proteccion_de_Datos";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Datos_del_Testigo_MPI).GetProperty(columnName));
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
            if (columnName == "Fecha_de_Nacimento_del_Tutor")
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

