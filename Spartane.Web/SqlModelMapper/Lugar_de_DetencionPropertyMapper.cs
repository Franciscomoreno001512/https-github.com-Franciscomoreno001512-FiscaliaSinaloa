using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Lugar_de_Detencion;

namespace Spartane.Web.SqlModelMapper
{
    public class Lugar_de_DetencionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Lugar_de_Detencion.Clave";
                case "Fecha_de_Detencion":
                    return "Lugar_de_Detencion.Fecha_de_Detencion";
                case "Municipio_de_Detencion[Nombre]":
                case "Municipio_de_DetencionNombre":
                    return "Municipio.Nombre";
                case "Corporacion[Descripcion]":
                case "CorporacionDescripcion":
                    return "Corporacion.Descripcion";
                case "Suspension_Condicional":
                    return "Lugar_de_Detencion.Suspension_Condicional";
                case "Fecha_de_Suspension_Condicional":
                    return "Lugar_de_Detencion.Fecha_de_Suspension_Condicional";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Lugar_de_Detencion).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Detencion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Suspension_Condicional")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Suspension_Condicional")
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

