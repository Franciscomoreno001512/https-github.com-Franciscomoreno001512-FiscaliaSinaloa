using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Medios_Prueba_ImputadoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Medios_Prueba_Imputado.Clave";
                case "Medio_de_Prueba_Presentado":
                    return "Detalle_Medios_Prueba_Imputado.Medio_de_Prueba_Presentado";
                case "Fecha_de_Presentacion":
                    return "Detalle_Medios_Prueba_Imputado.Fecha_de_Presentacion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Medios_Prueba_Imputado).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Presentacion")
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

