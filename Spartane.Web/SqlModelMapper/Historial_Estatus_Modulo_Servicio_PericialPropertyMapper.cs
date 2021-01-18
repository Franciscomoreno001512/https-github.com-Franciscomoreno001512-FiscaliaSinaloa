using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial;

namespace Spartane.Web.SqlModelMapper
{
    public class Historial_Estatus_Modulo_Servicio_PericialPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Historial_Estatus_Modulo_Servicio_Pericial.Clave";
                case "Estatus_Servicio_Pericial[Descripcion]":
                case "Estatus_Servicio_PericialDescripcion":
                    return "Estatus_Servicio_Pericial.Descripcion";
                case "Fecha_Registro":
                    return "Historial_Estatus_Modulo_Servicio_Pericial.Fecha_Registro";
                case "Activo":
                    return "Historial_Estatus_Modulo_Servicio_Pericial.Activo";
                case "Fecha_Cierre":
                    return "Historial_Estatus_Modulo_Servicio_Pericial.Fecha_Cierre";
                case "Modulo_Servicio_Pericial[Descripcion]":
                case "Modulo_Servicio_PericialDescripcion":
                    return "Modulo_Servicio_Pericial.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Historial_Estatus_Modulo_Servicio_Pericial).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_Registro")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Activo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_Cierre")
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

