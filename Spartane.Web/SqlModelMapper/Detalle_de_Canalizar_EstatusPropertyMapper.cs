using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Canalizar_Estatus;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Canalizar_EstatusPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Canalizar_Estatus.Clave";
                case "Fecha_de_Cambio_de_Estatus":
                    return "Detalle_de_Canalizar_Estatus.Fecha_de_Cambio_de_Estatus";
                case "Hora_de_Cambio_de_Estatus":
                    return "Detalle_de_Canalizar_Estatus.Hora_de_Cambio_de_Estatus";
                case "Estatus_Interno[Descripcion]":
                case "Estatus_InternoDescripcion":
                    return "Estatus.Descripcion";
                case "Estatus_de_Canalizacion[Descripcion]":
                case "Estatus_de_CanalizacionDescripcion":
                    return "Estatus_Orientador.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Canalizar_Estatus).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Cambio_de_Estatus")
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

