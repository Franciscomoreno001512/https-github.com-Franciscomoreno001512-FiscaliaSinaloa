using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Solicitudes_de_InvitacionesPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Solicitudes_de_Invitaciones.Clave";
                case "Solicitud[Numero_de_Folio]":
                case "SolicitudNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Fecha_de_Invitacion":
                    return "Detalle_de_Solicitudes_de_Invitaciones.Fecha_de_Invitacion";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Numero_de_Invitacion":
                    return "Detalle_de_Solicitudes_de_Invitaciones.Numero_de_Invitacion";
                case "Numero_de_Oficio":
                    return "Detalle_de_Solicitudes_de_Invitaciones.Numero_de_Oficio";
                case "Formato_de_Invitacion[Descripcion]":
                case "Formato_de_InvitacionDescripcion":
                    return "Tipo_de_Invitacion.Descripcion";
                case "Tipo_de_Participacion[Descripcion]":
                case "Tipo_de_ParticipacionDescripcion":
                    return "Tipo_de_Funcion.Descripcion";
                case "Fecha_de_la_cita":
                    return "Detalle_de_Solicitudes_de_Invitaciones.Fecha_de_la_cita";
                case "Hora_de_la_Cita":
                    return "Detalle_de_Solicitudes_de_Invitaciones.Hora_de_la_Cita";
                case "Domicilio":
                    return "Detalle_de_Solicitudes_de_Invitaciones.Domicilio";
                case "Fecha_de_Notificacion":
                    return "Detalle_de_Solicitudes_de_Invitaciones.Fecha_de_Notificacion";
                case "Hora_de_Notificacion":
                    return "Detalle_de_Solicitudes_de_Invitaciones.Hora_de_Notificacion";
                case "Notificador[Name]":
                case "NotificadorName":
                    return "Spartan_User.Name";
                case "Resultado[Descripcion]":
                case "ResultadoDescripcion":
                    return "Resultado_de_Notificacion.Descripcion";
                case "Incidente_en_la_Recepcion[Descripcion]":
                case "Incidente_en_la_RecepcionDescripcion":
                    return "Incidente_con_Invitacion.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Solicitudes_de_Invitaciones).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Invitacion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_la_cita")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Notificacion")
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

