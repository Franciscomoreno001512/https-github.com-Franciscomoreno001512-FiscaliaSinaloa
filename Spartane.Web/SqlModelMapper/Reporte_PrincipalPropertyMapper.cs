using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Reporte_Principal;

namespace Spartane.Web.SqlModelMapper
{
    public class Reporte_PrincipalPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Reporte_Principal.Clave";
                case "Expediente":
                    return "Reporte_Principal.Expediente";
                case "Total_de_Expedientes":
                    return "Reporte_Principal.Total_de_Expedientes";
                case "Fecha_de_Registro":
                    return "Reporte_Principal.Fecha_de_Registro";
                case "Numero_de_Caso":
                    return "Reporte_Principal.Numero_de_Caso";
                case "Creciente":
                    return "Reporte_Principal.Creciente";
                case "Folio":
                    return "Reporte_Principal.Folio";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Reporte_Principal).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Registro")
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

