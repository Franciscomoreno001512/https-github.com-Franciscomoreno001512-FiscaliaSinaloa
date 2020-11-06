using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Acuerdos_MASC;

namespace Spartane.Web.SqlModelMapper
{
    public class Acuerdos_MASCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Acuerdos_MASC.Clave";
                case "Numero_de_Expediente[Numero_de_Folio]":
                case "Numero_de_ExpedienteNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Fecha_de_Registro":
                    return "Acuerdos_MASC.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Acuerdos_MASC.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Tipo_de_Acuerdo[Descripcion]":
                case "Tipo_de_AcuerdoDescripcion":
                    return "Tipo_de_Acuerdo.Descripcion";
                case "Solicitante[Nombre_Completo]":
                case "SolicitanteNombre_Completo":
                    return "Detalle_de_Solicitud_Solicitante.Nombre_Completo";
                case "Requerido[Nombre_Completo]":
                case "RequeridoNombre_Completo":
                    return "Detalle_de_Solicitud_Requerido.Nombre_Completo";
                case "Lugar_Acordado":
                    return "Acuerdos_MASC.Lugar_Acordado";
                case "Domicilio_Acordado":
                    return "Acuerdos_MASC.Domicilio_Acordado";
                case "Hora_de_Acuerdo":
                    return "Acuerdos_MASC.Hora_de_Acuerdo";
                case "Fecha_de_Inicio_de_Acuerdo":
                    return "Acuerdos_MASC.Fecha_de_Inicio_de_Acuerdo";
                case "Monto_Total":
                    return "Acuerdos_MASC.Monto_Total";
                case "Parcialidades":
                    return "Acuerdos_MASC.Parcialidades";
                case "Periodicidad[Descripcion]":
                case "PeriodicidadDescripcion":
                    return "Periodicidad.Descripcion";
                case "Monto_de_la_Parcialidad":
                    return "Acuerdos_MASC.Monto_de_la_Parcialidad";
                case "Personal_de_Seguimiento_Asignado[Name]":
                case "Personal_de_Seguimiento_AsignadoName":
                    return "Spartan_User.Name";
                case "Comentarios":
                    return "Acuerdos_MASC.Comentarios";
                case "Acuerdo_Cumplido[Descripcion]":
                case "Acuerdo_CumplidoDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Fecha_de_Cumplimiento_de_Acuerdo":
                    return "Acuerdos_MASC.Fecha_de_Cumplimiento_de_Acuerdo";
                case "Razon_de_Incumplimiento[Descripcion]":
                case "Razon_de_IncumplimientoDescripcion":
                    return "Razon_de_Incumplimiento.Descripcion";
                case "Fecha_de_Revision":
                    return "Acuerdos_MASC.Fecha_de_Revision";
                case "Hora_de_Revision":
                    return "Acuerdos_MASC.Hora_de_Revision";
                case "Usuario_que_Revisa[Name]":
                case "Usuario_que_RevisaName":
                    return "Spartan_User.Name";
                case "Resultado[Descripcion]":
                case "ResultadoDescripcion":
                    return "Resultado_de_Revision.Descripcion";
                case "Motivo_de_Rechazo_de_Acuerdo":
                    return "Acuerdos_MASC.Motivo_de_Rechazo_de_Acuerdo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Acuerdos_MASC).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Registro")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Inicio_de_Acuerdo")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Cumplimiento_de_Acuerdo")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
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

