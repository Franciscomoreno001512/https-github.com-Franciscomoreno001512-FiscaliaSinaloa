using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_Electronicos_y_MultimediaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_Electronicos_y_Multimedia.Clave";
                case "Aparatos[Descripcion]":
                case "AparatosDescripcion":
                    return "Aparato_Electronicos_y_Multimedia.Descripcion";
                case "Documentos_Multimedia[Descripcion]":
                case "Documentos_MultimediaDescripcion":
                    return "Documentos_Multimedia.Descripcion";
                case "Descripcion":
                    return "Detalle_Aseguramiento_Electronicos_y_Multimedia.Descripcion";
                case "Cantidad":
                    return "Detalle_Aseguramiento_Electronicos_y_Multimedia.Cantidad";
                case "A_resguardo":
                    return "Detalle_Aseguramiento_Electronicos_y_Multimedia.A_resguardo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_Electronicos_y_Multimedia).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {


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

