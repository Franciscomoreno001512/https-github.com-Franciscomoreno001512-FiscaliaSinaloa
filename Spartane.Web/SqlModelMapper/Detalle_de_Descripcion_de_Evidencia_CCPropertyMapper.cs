using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Descripcion_de_Evidencia_CC;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Descripcion_de_Evidencia_CCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Descripcion_de_Evidencia_CC.Clave";
                case "Numero_de_Evidencia":
                    return "Detalle_de_Descripcion_de_Evidencia_CC.Numero_de_Evidencia";
                case "Descripcion_de_la_Evidencia":
                    return "Detalle_de_Descripcion_de_Evidencia_CC.Descripcion_de_la_Evidencia";
                case "Origen":
                    return "Detalle_de_Descripcion_de_Evidencia_CC.Origen";
                case "Descripcion":
                    return "Detalle_de_Descripcion_de_Evidencia_CC.Descripcion";
                case "Examen_Solicitado":
                    return "Detalle_de_Descripcion_de_Evidencia_CC.Examen_Solicitado";
                case "Codigo_de_Barras":
                    return "Detalle_de_Descripcion_de_Evidencia_CC.Codigo_de_Barras";
                case "Archivo_de_Foto":
                    return "Detalle_de_Descripcion_de_Evidencia_CC.Archivo_de_Foto";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Descripcion_de_Evidencia_CC).GetProperty(columnName));
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

