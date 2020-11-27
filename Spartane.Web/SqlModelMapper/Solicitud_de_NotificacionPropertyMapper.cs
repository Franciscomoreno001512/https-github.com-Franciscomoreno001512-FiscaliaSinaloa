using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud_de_Notificacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Solicitud_de_NotificacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Solicitud_de_Notificacion.Folio";
                case "Fecha_de_Solicitud":
                    return "Solicitud_de_Notificacion.Fecha_de_Solicitud";
                case "Hora_de_Solicitud":
                    return "Solicitud_de_Notificacion.Hora_de_Solicitud";
                case "Usuario_que_Solicita[Name]":
                case "Usuario_que_SolicitaName":
                    return "Spartan_User.Name";
                case "Origen[Descripcion]":
                case "OrigenDescripcion":
                    return "Origen_de_Invitacion.Descripcion";
                case "Expediente_Atencion_Temprana[Folio]":
                case "Expediente_Atencion_TempranaFolio":
                    return "Modulo_Atencion_Inicial.Folio";
                case "Expediente_Mecanismos_Alternos[Numero_de_Folio]":
                case "Expediente_Mecanismos_AlternosNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Carpeta_de_Investigacion":
                    return "Solicitud_de_Notificacion.Carpeta_de_Investigacion";
                case "Numero_de_Invitacion":
                    return "Solicitud_de_Notificacion.Numero_de_Invitacion";
                case "Fecha_de_la_cita":
                    return "Solicitud_de_Notificacion.Fecha_de_la_cita";
                case "Hora_de_la_Cita":
                    return "Solicitud_de_Notificacion.Hora_de_la_Cita";
                case "Lugar_de_la_Cita":
                    return "Solicitud_de_Notificacion.Lugar_de_la_Cita";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_de_Notificacion.Descripcion";
                case "Fecha_de_Notificacion":
                    return "Solicitud_de_Notificacion.Fecha_de_Notificacion";
                case "Hora_de_Notificacion":
                    return "Solicitud_de_Notificacion.Hora_de_Notificacion";
                case "Notificador[Name]":
                case "NotificadorName":
                    return "Spartan_User.Name";
                case "Forma_de_Invitacion[Descripcion]":
                case "Forma_de_InvitacionDescripcion":
                    return "Tipo_de_Invitacion.Descripcion";
                case "Resultado[Descripcion]":
                case "ResultadoDescripcion":
                    return "Resultado_de_Notificacion.Descripcion";
                case "Archivo":
                    return "Solicitud_de_Notificacion.Archivo";
                case "Incidente_en_la_Recepcion[Descripcion]":
                case "Incidente_en_la_RecepcionDescripcion":
                    return "Incidente_con_Invitacion.Descripcion";
                case "Documento[Descripcion]":
                case "DocumentoDescripcion":
                    return "Documento.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Solicitud_de_Notificacion).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Solicitud")
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

