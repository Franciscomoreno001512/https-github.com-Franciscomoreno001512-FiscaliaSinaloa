using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Citatorio_AudienciasPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Citatorio_Audiencias.Clave";
                case "Numero_de_audiencia_citatorio":
                    return "Detalle_de_Citatorio_Audiencias.Numero_de_audiencia_citatorio";
                case "Fecha":
                    return "Detalle_de_Citatorio_Audiencias.Fecha";
                case "Hora":
                    return "Detalle_de_Citatorio_Audiencias.Hora";
                case "Fecha_de_Aceptacion":
                    return "Detalle_de_Citatorio_Audiencias.Fecha_de_Aceptacion";
                case "Hora_de_Aceptacion":
                    return "Detalle_de_Citatorio_Audiencias.Hora_de_Aceptacion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Citatorio_Audiencias).GetProperty(columnName));
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
            if (columnName == "Fecha_de_Aceptacion")
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

