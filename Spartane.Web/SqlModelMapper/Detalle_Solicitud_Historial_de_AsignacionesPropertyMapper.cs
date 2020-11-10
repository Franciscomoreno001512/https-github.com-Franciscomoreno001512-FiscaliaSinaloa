using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Solicitud_Historial_de_AsignacionesPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Detalle_Solicitud_Historial_de_Asignaciones.Folio";
                case "Fecha_cambio":
                    return "Detalle_Solicitud_Historial_de_Asignaciones.Fecha_cambio";
                case "Hora_cambio":
                    return "Detalle_Solicitud_Historial_de_Asignaciones.Hora_cambio";
                case "Usuario[Name]":
                case "UsuarioName":
                    return "Spartan_User.Name";
                case "Facilitador_Asignado[Name]":
                case "Facilitador_AsignadoName":
                    return "Spartan_User.Name";
                case "Motivo_cambio":
                    return "Detalle_Solicitud_Historial_de_Asignaciones.Motivo_cambio";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Solicitud_Historial_de_Asignaciones).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_cambio")
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

