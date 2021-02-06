using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Relaciones_MASC;

namespace Spartane.Web.SqlModelMapper
{
    public class Relaciones_MASCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Relaciones_MASC.Clave";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_Solicitud.Descripcion";
                case "Numero_de_Expediente[Numero_de_Expediente]":
                case "Numero_de_ExpedienteNumero_de_Expediente":
                    return "Solicitud.Numero_de_Expediente";
                case "Numero_de_Procedimiento":
                    return "Relaciones_MASC.Numero_de_Procedimiento";
                case "idRelacionOrigen[Descripcion]":
                case "idRelacionOrigenDescripcion":
                    return "Detalle_de_Relaciones.Descripcion";
                case "Requiere_cambiar_la_relacion":
                    return "Relaciones_MASC.Requiere_cambiar_la_relacion";
                case "Motivo_de_Cambio":
                    return "Relaciones_MASC.Motivo_de_Cambio";
                case "Observaciones":
                    return "Relaciones_MASC.Observaciones";
                case "Descripcion":
                    return "Relaciones_MASC.Descripcion";
                case "Fecha_de_Resolucion_solicitud":
                    return "Relaciones_MASC.Fecha_de_Resolucion_solicitud";
                case "Hora_de_Resolucion_solicitud":
                    return "Relaciones_MASC.Hora_de_Resolucion_solicitud";
                case "Usuario_que_Resuelve_solicitud[Name]":
                case "Usuario_que_Resuelve_solicitudName":
                    return "Spartan_User.Name";
                case "Resolucion[Descripcion]":
                case "ResolucionDescripcion":
                    return "Resolucion_MASC.Descripcion";
                case "Tipo_de_Mecanismo[Descripcion]":
                case "Tipo_de_MecanismoDescripcion":
                    return "Tipo_de_Mecanismo_Alterno.Descripcion";
                case "Observaciones_solicitud":
                    return "Relaciones_MASC.Observaciones_solicitud";
                case "Fecha_de_Validacion_solicitud":
                    return "Relaciones_MASC.Fecha_de_Validacion_solicitud";
                case "Hora_de_Validacion_solicitud":
                    return "Relaciones_MASC.Hora_de_Validacion_solicitud";
                case "Usuario_que_Valida_solicitud[Name]":
                case "Usuario_que_Valida_solicitudName":
                    return "Spartan_User.Name";
                case "resultado_solicitud[Descripcion]":
                case "resultado_solicitudDescripcion":
                    return "Resultado_de_Revision.Descripcion";
                case "motivo_rechazo_solicitud":
                    return "Relaciones_MASC.motivo_rechazo_solicitud";
                case "Fecha_de_Resolucion_proc":
                    return "Relaciones_MASC.Fecha_de_Resolucion_proc";
                case "hora_resolucion_proc":
                    return "Relaciones_MASC.hora_resolucion_proc";
                case "usuario_resuelve_proc[Name]":
                case "usuario_resuelve_procName":
                    return "Spartan_User.Name";
                case "Resolucion_proc[Descripcion]":
                case "Resolucion_procDescripcion":
                    return "Resolucion_MASC.Descripcion";
                case "Observaciones_proc":
                    return "Relaciones_MASC.Observaciones_proc";
                case "Fecha_de_Validacion_proc":
                    return "Relaciones_MASC.Fecha_de_Validacion_proc";
                case "Hora_de_Validacion_proc":
                    return "Relaciones_MASC.Hora_de_Validacion_proc";
                case "Usuario_que_Valida_proc[Name]":
                case "Usuario_que_Valida_procName":
                    return "Spartan_User.Name";
                case "Resultado_proc[Descripcion]":
                case "Resultado_procDescripcion":
                    return "Resultado_de_Revision.Descripcion";
                case "Motivo_de_Rechazo_proc":
                    return "Relaciones_MASC.Motivo_de_Rechazo_proc";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Relaciones_MASC).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Requiere_cambiar_la_relacion")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Resolucion_solicitud")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Validacion_solicitud")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Resolucion_proc")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Validacion_proc")
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

