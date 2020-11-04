using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_de_Tutor;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Datos_de_TutorPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Datos_de_Tutor.Clave";
                case "Modulo_Atencion_Inicial":
                    return "Detalle_de_Datos_de_Tutor.Modulo_Atencion_Inicial";
                case "Nombre":
                    return "Detalle_de_Datos_de_Tutor.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Datos_de_Tutor.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Datos_de_Tutor.Apellido_Materno";
                case "Nombre_Completo":
                    return "Detalle_de_Datos_de_Tutor.Nombre_Completo";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Datos_de_Tutor.Fecha_de_Nacimiento";
                case "Edad":
                    return "Detalle_de_Datos_de_Tutor.Edad";
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
                    return "Detalle_de_Datos_de_Tutor.Numero_de_Identificacion";
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
                case "Localidad[Descripcion]":
                case "LocalidadDescripcion":
                    return "Localidad.Descripcion";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Detalle_de_Datos_de_Tutor.Codigo_Postal";
                case "Calle":
                    return "Detalle_de_Datos_de_Tutor.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Datos_de_Tutor.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Datos_de_Tutor.Numero_Interior";
                case "Telefono":
                    return "Detalle_de_Datos_de_Tutor.Telefono";
                case "Extension":
                    return "Detalle_de_Datos_de_Tutor.Extension";
                case "Celular":
                    return "Detalle_de_Datos_de_Tutor.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Datos_de_Tutor.Correo_Electronico";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Datos_de_Tutor).GetProperty(columnName));
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

