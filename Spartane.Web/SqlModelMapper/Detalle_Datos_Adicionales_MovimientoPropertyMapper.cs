using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Datos_Adicionales_MovimientoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Datos_Adicionales_Movimiento.Clave";
                case "Dato":
                    return "Detalle_Datos_Adicionales_Movimiento.Dato";
                case "Tipo_de_Dato[Descripcion]":
                case "Tipo_de_DatoDescripcion":
                    return "Tipo_de_Dato.Descripcion";
                case "Query_para_llenado":
                    return "Detalle_Datos_Adicionales_Movimiento.Query_para_llenado";
                case "Obligatorio":
                    return "Detalle_Datos_Adicionales_Movimiento.Obligatorio";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Datos_Adicionales_Movimiento).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Obligatorio")
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

