using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Unidad;

namespace Spartane.Web.SqlModelMapper
{
    public class UnidadPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Unidad.Clave";
                case "Clave_Unica_Municipio":
                    return "Unidad.Clave_Unica_Municipio";
                case "Clave_de_Municipio[Nombre]":
                case "Clave_de_MunicipioNombre":
                    return "Municipio.Nombre";
                case "Clave_de_Region[Descripcion]":
                case "Clave_de_RegionDescripcion":
                    return "Region.Descripcion";
                case "Abreviacion":
                    return "Unidad.Abreviacion";
                case "Descripcion":
                    return "Unidad.Descripcion";
                case "Descripcion_Corta":
                    return "Unidad.Descripcion_Corta";
                case "Vigencia[Abreviacion]":
                case "VigenciaAbreviacion":
                    return "Vigencia.Abreviacion";
                case "Direccion":
                    return "Unidad.Direccion";
                case "Observaciones":
                    return "Unidad.Observaciones";
                case "Supervisor[Name]":
                case "SupervisorName":
                    return "Spartan_User.Name";
                case "Consecutivo_CDI":
                    return "Unidad.Consecutivo_CDI";
                case "Tipo_de_Asignacion_de_MP[Descripcion]":
                case "Tipo_de_Asignacion_de_MPDescripcion":
                    return "Tipo_de_Asignacion_de_MP.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Unidad).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {


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

