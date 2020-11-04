using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Solicitud_Bitacora_de_CoincidPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Solicitud_Bitacora_de_Coincid.Clave";
                case "Nombre_Completo":
                    return "Detalle_de_Solicitud_Bitacora_de_Coincid.Nombre_Completo";
                case "Alias":
                    return "Detalle_de_Solicitud_Bitacora_de_Coincid.Alias";
                case "Numero_de_Expediente":
                    return "Detalle_de_Solicitud_Bitacora_de_Coincid.Numero_de_Expediente";
                case "Fuente_de_Origen":
                    return "Detalle_de_Solicitud_Bitacora_de_Coincid.Fuente_de_Origen";
                case "Tipo_de_Acuerdo[Descripcion]":
                case "Tipo_de_AcuerdoDescripcion":
                    return "Tipo_de_Acuerdo.Descripcion";
                case "Cumplido":
                    return "Detalle_de_Solicitud_Bitacora_de_Coincid.Cumplido";
                case "Razon_de_Incumplimiento[Descripcion]":
                case "Razon_de_IncumplimientoDescripcion":
                    return "Razon_de_Incumplimiento.Descripcion";
                case "Observaciones":
                    return "Detalle_de_Solicitud_Bitacora_de_Coincid.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Solicitud_Bitacora_de_Coincid).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Cumplido")
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

