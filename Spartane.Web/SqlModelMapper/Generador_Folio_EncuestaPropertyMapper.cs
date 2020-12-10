using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Generador_Folio_Encuesta;

namespace Spartane.Web.SqlModelMapper
{
    public class Generador_Folio_EncuestaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Generador_Folio_Encuesta.Folio";
                case "Fecha_Genera":
                    return "Generador_Folio_Encuesta.Fecha_Genera";
                case "Anio_Genera":
                    return "Generador_Folio_Encuesta.Anio_Genera";
                case "Modulo_Encuesta[Descripcion]":
                case "Modulo_EncuestaDescripcion":
                    return "Modulo_Encuesta.Descripcion";
                case "Region[Descripcion]":
                case "RegionDescripcion":
                    return "Region.Descripcion";
                case "Consecutivo":
                    return "Generador_Folio_Encuesta.Consecutivo";
                case "Folio_Encuesta_Ultimo_Generado":
                    return "Generador_Folio_Encuesta.Folio_Encuesta_Ultimo_Generado";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Generador_Folio_Encuesta).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_Genera")
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

