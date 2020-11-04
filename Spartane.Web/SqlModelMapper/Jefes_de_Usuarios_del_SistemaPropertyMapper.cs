using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema;

namespace Spartane.Web.SqlModelMapper
{
    public class Jefes_de_Usuarios_del_SistemaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Jefes_de_Usuarios_del_Sistema.Clave";
                case "Region[Descripcion]":
                case "RegionDescripcion":
                    return "Region.Descripcion";
                case "Ministerio_Publico_en_Turno":
                    return "Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno";
                case "Unidad[Descripcion]":
                case "UnidadDescripcion":
                    return "Unidad.Descripcion";
                case "Vigencia[Abreviacion]":
                case "VigenciaAbreviacion":
                    return "Vigencia.Abreviacion";
                case "Observaciones":
                    return "Jefes_de_Usuarios_del_Sistema.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Jefes_de_Usuarios_del_Sistema).GetProperty(columnName));
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

