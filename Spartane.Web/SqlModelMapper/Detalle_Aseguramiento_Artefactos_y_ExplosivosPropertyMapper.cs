using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_Artefactos_y_ExplosivosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_Artefactos_y_Explosivos.Clave";
                case "Motivo_de_Registro[Descripcion]":
                case "Motivo_de_RegistroDescripcion":
                    return "Motivo_de_Registro.Descripcion";
                case "Clasificacion[Descripcion]":
                case "ClasificacionDescripcion":
                    return "Clasificacion_de_Artefacto_y_Explosivo.Descripcion";
                case "Cantidad":
                    return "Detalle_Aseguramiento_Artefactos_y_Explosivos.Cantidad";
                case "Lugar_de_Hallazgo":
                    return "Detalle_Aseguramiento_Artefactos_y_Explosivos.Lugar_de_Hallazgo";
                case "Observaciones":
                    return "Detalle_Aseguramiento_Artefactos_y_Explosivos.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_Artefactos_y_Explosivos).GetProperty(columnName));
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

