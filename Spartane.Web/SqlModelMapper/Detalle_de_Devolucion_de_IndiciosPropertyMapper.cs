using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Devolucion_de_Indicios;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Devolucion_de_IndiciosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Devolucion_de_Indicios.Clave";
                case "Fecha_de_Devolucion":
                    return "Detalle_de_Devolucion_de_Indicios.Fecha_de_Devolucion";
                case "Hora_de_Devolucion":
                    return "Detalle_de_Devolucion_de_Indicios.Hora_de_Devolucion";
                case "Nombre_de_Persona_que_Entrega":
                    return "Detalle_de_Devolucion_de_Indicios.Nombre_de_Persona_que_Entrega";
                case "Numero_de_Indicio[Descripcion]":
                case "Numero_de_IndicioDescripcion":
                    return "Indicios_para_MPI.Descripcion";
                case "Nombre_de_Indicio":
                    return "Detalle_de_Devolucion_de_Indicios.Nombre_de_Indicio";
                case "Descripcion_de_Devolucion_de_Indicio":
                    return "Detalle_de_Devolucion_de_Indicios.Descripcion_de_Devolucion_de_Indicio";
                case "Diligencia_que_Devuelve[Servicio]":
                case "Diligencia_que_DevuelveServicio":
                    return "Servicios_Periciales.Servicio";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Devolucion_de_Indicios).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Devolucion")
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

