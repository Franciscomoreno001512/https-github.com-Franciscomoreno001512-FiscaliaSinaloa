using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_Seguimiento;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Solicitud_SeguimientoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Solicitud_Seguimiento.Clave";
                case "Solicitud[Numero_de_Folio]":
                case "SolicitudNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Fecha_de_Registro":
                    return "Detalle_de_Solicitud_Seguimiento.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Detalle_de_Solicitud_Seguimiento.Hora_de_Registro";
                case "Requerido[Nombre]":
                case "RequeridoNombre":
                    return "Detalle_de_Solicitud_Requerido.Nombre";
                case "Solicitante[Nombre]":
                case "SolicitanteNombre":
                    return "Detalle_de_Solicitud_Solicitante.Nombre";
                case "Fecha_Requerida":
                    return "Detalle_de_Solicitud_Seguimiento.Fecha_Requerida";
                case "Cumplimiento[Descripcion]":
                case "CumplimientoDescripcion":
                    return "Cumplimiento.Descripcion";
                case "Fecha_de_Cumplimiento":
                    return "Detalle_de_Solicitud_Seguimiento.Fecha_de_Cumplimiento";
                case "Forma_de_Pago[Descripcion]":
                case "Forma_de_PagoDescripcion":
                    return "Forma_de_Cumplimiento.Descripcion";
                case "Cantidad_del_Monto":
                    return "Detalle_de_Solicitud_Seguimiento.Cantidad_del_Monto";
                case "Descripcion_de_Cumplimiento":
                    return "Detalle_de_Solicitud_Seguimiento.Descripcion_de_Cumplimiento";
                case "Concluir_Acuerdo[Descripcion]":
                case "Concluir_AcuerdoDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Especialista[Name]":
                case "EspecialistaName":
                    return "Spartan_User.Name";
                case "Comentarios":
                    return "Detalle_de_Solicitud_Seguimiento.Comentarios";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Solicitud_Seguimiento).GetProperty(columnName));
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
            if (columnName == "Fecha_Requerida")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
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

