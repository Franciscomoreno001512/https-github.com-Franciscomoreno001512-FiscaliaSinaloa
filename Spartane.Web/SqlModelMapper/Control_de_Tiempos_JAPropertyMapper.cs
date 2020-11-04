using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Control_de_Tiempos_JA;

namespace Spartane.Web.SqlModelMapper
{
    public class Control_de_Tiempos_JAPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Control_de_Tiempos_JA.Clave";
                case "Fecha":
                    return "Control_de_Tiempos_JA.Fecha";
                case "Hora":
                    return "Control_de_Tiempos_JA.Hora";
                case "Numero_de_Expediente":
                    return "Control_de_Tiempos_JA.Numero_de_Expediente";
                case "Estatus":
                    return "Control_de_Tiempos_JA.Estatus";
                case "Estatus_Destino":
                    return "Control_de_Tiempos_JA.Estatus_Destino";
                case "Tiempo_Transcurrido":
                    return "Control_de_Tiempos_JA.Tiempo_Transcurrido";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Control_de_Tiempos_JA).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha")
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

