using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Seguimiento;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_SeguimientoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Seguimiento.Clave";
                case "Especialista":
                    return "Detalle_de_Seguimiento.Especialista";
                case "Solicitante":
                    return "Detalle_de_Seguimiento.Solicitante";
                case "Requerido":
                    return "Detalle_de_Seguimiento.Requerido";
                case "Archivo":
                    return "Detalle_de_Seguimiento.Archivo";
                case "Observaciones":
                    return "Detalle_de_Seguimiento.Observaciones";
                case "Cumplimiento":
                    return "Detalle_de_Seguimiento.Cumplimiento";
                case "Tipo_de_Seguimiento[Descripcion]":
                case "Tipo_de_SeguimientoDescripcion":
                    return "Tipo_de_Seguimiento.Descripcion";
                case "Cantidad_del_Monto":
                    return "Detalle_de_Seguimiento.Cantidad_del_Monto";
                case "Fecha_de_Cumplimiento":
                    return "Detalle_de_Seguimiento.Fecha_de_Cumplimiento";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Seguimiento).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Cumplimiento")
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

