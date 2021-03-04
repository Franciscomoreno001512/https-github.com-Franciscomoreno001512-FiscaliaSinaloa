using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo;

namespace Spartane.Web.SqlModelMapper
{
    public class Solicitud_de_Servicios_de_ApoyoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Solicitud_de_Servicios_de_Apoyo.Clave";
                case "Tipo_de_Servicio[Servicio]":
                case "Tipo_de_ServicioServicio":
                    return "Tipo_de_Servicio_de_Apoyo.Servicio";
                case "Responsable":
                    return "Solicitud_de_Servicios_de_Apoyo.Responsable";
                case "Clave_MR":
                    return "Solicitud_de_Servicios_de_Apoyo.Clave_MR";
                case "Compareciente[Nombre_Completo]":
                case "ComparecienteNombre_Completo":
                    return "Compareciente.Nombre_Completo";
                case "Fecha_de_Solicitud":
                    return "Solicitud_de_Servicios_de_Apoyo.Fecha_de_Solicitud";
                case "Hora_de_Solicitud":
                    return "Solicitud_de_Servicios_de_Apoyo.Hora_de_Solicitud";
                case "Usuario_que_Solicita[Name]":
                case "Usuario_que_SolicitaName":
                    return "Spartan_User.Name";
                case "Origen[Descripcion]":
                case "OrigenDescripcion":
                    return "Origen_de_Invitacion.Descripcion";
                case "Numero_de_Expediente_AT[NUAT]":
                case "Numero_de_Expediente_ATNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Numero_de_Expediente_MP[nuat]":
                case "Numero_de_Expediente_MPnuat":
                    return "expediente_ministerio_publico.nuat";
                case "NUAT":
                    return "Solicitud_de_Servicios_de_Apoyo.NUAT";
                case "Numero_de_Denuncia":
                    return "Solicitud_de_Servicios_de_Apoyo.Numero_de_Denuncia";
                case "Carpeta_de_Investigacion":
                    return "Solicitud_de_Servicios_de_Apoyo.Carpeta_de_Investigacion";
                case "Numero_de_Oficio":
                    return "Solicitud_de_Servicios_de_Apoyo.Numero_de_Oficio";
                case "Solicitud[Descripcion]":
                case "SolicitudDescripcion":
                    return "Documento.Descripcion";
                case "Observaciones":
                    return "Solicitud_de_Servicios_de_Apoyo.Observaciones";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_de_Solicitud_de_Apoyo.Descripcion";
                case "Fecha_de_Recepcion":
                    return "Solicitud_de_Servicios_de_Apoyo.Fecha_de_Recepcion";
                case "Hora_de_Recepcion":
                    return "Solicitud_de_Servicios_de_Apoyo.Hora_de_Recepcion";
                case "Usuario_que_Recibe[Name]":
                case "Usuario_que_RecibeName":
                    return "Spartan_User.Name";
                case "Area_Asignada[Descripcion]":
                case "Area_AsignadaDescripcion":
                    return "Area_de_Servicios_de_Apoyo.Descripcion";
                case "SubArea_Asignada[Descripcion]":
                case "SubArea_AsignadaDescripcion":
                    return "SubArea_de_Servicios_de_Apoyo.Descripcion";
                case "Observaciones_Recepcion":
                    return "Solicitud_de_Servicios_de_Apoyo.Observaciones_Recepcion";
                case "Fecha_de_Asignacion":
                    return "Solicitud_de_Servicios_de_Apoyo.Fecha_de_Asignacion";
                case "Hora_de_Asignacion":
                    return "Solicitud_de_Servicios_de_Apoyo.Hora_de_Asignacion";
                case "Usuario_que_Asigna[Name]":
                case "Usuario_que_AsignaName":
                    return "Spartan_User.Name";
                case "Tipo_de_Asignacion[Descripcion]":
                case "Tipo_de_AsignacionDescripcion":
                    return "Tipo_de_Asignacion_de_Apoyo.Descripcion";
                case "Responsable_Asignado[Name]":
                case "Responsable_AsignadoName":
                    return "Spartan_User.Name";
                case "Observaciones_Asignacion":
                    return "Solicitud_de_Servicios_de_Apoyo.Observaciones_Asignacion";
                case "Fecha_de_Contestacion":
                    return "Solicitud_de_Servicios_de_Apoyo.Fecha_de_Contestacion";
                case "Hora_de_Contestacion":
                    return "Solicitud_de_Servicios_de_Apoyo.Hora_de_Contestacion";
                case "Usuario_que_contesta[Name]":
                case "Usuario_que_contestaName":
                    return "Spartan_User.Name";
                case "Dictamen[Descripcion]":
                case "DictamenDescripcion":
                    return "Documento.Descripcion";
                case "Enviar_Contestacion":
                    return "Solicitud_de_Servicios_de_Apoyo.Enviar_Contestacion";
                case "Archivo":
                    return "Solicitud_de_Servicios_de_Apoyo.Archivo";
                case "Observaciones_Contestacion":
                    return "Solicitud_de_Servicios_de_Apoyo.Observaciones_Contestacion";
                case "Fecha_de_Revision":
                    return "Solicitud_de_Servicios_de_Apoyo.Fecha_de_Revision";
                case "Hora_de_Revision":
                    return "Solicitud_de_Servicios_de_Apoyo.Hora_de_Revision";
                case "Usuario_que_Revisa[Name]":
                case "Usuario_que_RevisaName":
                    return "Spartan_User.Name";
                case "Resultado_de_Autorizacion[Descripcion]":
                case "Resultado_de_AutorizacionDescripcion":
                    return "Resultado_de_Revision.Descripcion";
                case "Motivo_de_Rechazo":
                    return "Solicitud_de_Servicios_de_Apoyo.Motivo_de_Rechazo";
                case "Observaciones_Autorizacion":
                    return "Solicitud_de_Servicios_de_Apoyo.Observaciones_Autorizacion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Solicitud_de_Servicios_de_Apoyo).GetProperty(columnName));
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
            if (columnName == "Fecha_de_Recepcion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Asignacion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Contestacion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Enviar_Contestacion")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Revision")
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

