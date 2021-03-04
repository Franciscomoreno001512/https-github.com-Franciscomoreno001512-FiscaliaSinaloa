using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Configuracion_de_Servicios_de_Apoyo;

namespace Spartane.Web.SqlModelMapper
{
    public class Configuracion_de_Servicios_de_ApoyoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Configuracion_de_Servicios_de_Apoyo.Clave";
                case "Region[Descripcion]":
                case "RegionDescripcion":
                    return "Region.Descripcion";
                case "Area[Descripcion]":
                case "AreaDescripcion":
                    return "Area_de_Servicios_de_Apoyo.Descripcion";
                case "SubArea[Descripcion]":
                case "SubAreaDescripcion":
                    return "SubArea_de_Servicios_de_Apoyo.Descripcion";
                case "Acreditada":
                    return "Configuracion_de_Servicios_de_Apoyo.Acreditada";
                case "Centralizada":
                    return "Configuracion_de_Servicios_de_Apoyo.Centralizada";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Configuracion_de_Servicios_de_Apoyo).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Acreditada")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Centralizada")
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

