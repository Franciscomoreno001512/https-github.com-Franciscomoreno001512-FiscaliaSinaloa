using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Invitado_de_Notificacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Invitado_de_NotificacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Detalle_de_Invitado_de_Notificacion.Folio";
                case "Nombre_Completo":
                    return "Detalle_de_Invitado_de_Notificacion.Nombre_Completo";
                case "Telefono":
                    return "Detalle_de_Invitado_de_Notificacion.Telefono";
                case "Correo_Electronico":
                    return "Detalle_de_Invitado_de_Notificacion.Correo_Electronico";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Detalle_de_Invitado_de_Notificacion.Codigo_Postal";
                case "Calle":
                    return "Detalle_de_Invitado_de_Notificacion.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Invitado_de_Notificacion.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Invitado_de_Notificacion.Numero_Interior";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Invitado_de_Notificacion).GetProperty(columnName));
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

