using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Solicitud_de_IndicioPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Solicitud_de_Indicio.Clave";
                case "Fecha_de_Solicitud":
                    return "Detalle_de_Solicitud_de_Indicio.Fecha_de_Solicitud";
                case "Hora_de_Solicitud":
                    return "Detalle_de_Solicitud_de_Indicio.Hora_de_Solicitud";
                case "Nombre_del_Solicitante":
                    return "Detalle_de_Solicitud_de_Indicio.Nombre_del_Solicitante";
                case "Motivo":
                    return "Detalle_de_Solicitud_de_Indicio.Motivo";
                case "Numero_de_Indicio[Descripcion]":
                case "Numero_de_IndicioDescripcion":
                    return "Indicios_para_MPI.Descripcion";
                case "Nombre_de_Indicio":
                    return "Detalle_de_Solicitud_de_Indicio.Nombre_de_Indicio";
                case "Descripcion_de_Entrega_de_Indicio":
                    return "Detalle_de_Solicitud_de_Indicio.Descripcion_de_Entrega_de_Indicio";
                case "Diligencia_que_Solicita[Servicio]":
                case "Diligencia_que_SolicitaServicio":
                    return "Servicios_Periciales.Servicio";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Solicitud_de_Indicio).GetProperty(columnName));
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

