using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Relaciones_MASC;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Relaciones_MASCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Relaciones_MASC.Clave";
                case "Requerido[Nombre_Completo_del_Tutor]":
                case "RequeridoNombre_Completo_del_Tutor":
                    return "Detalle_de_Imputado.Nombre_Completo_del_Tutor";
                case "Delito[Descripcion]":
                case "DelitoDescripcion":
                    return "Delito.Descripcion";
                case "Solicitante[Nombre_Completo2]":
                case "SolicitanteNombre_Completo2":
                    return "Detalle_de_Datos_Generales.Nombre_Completo2";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Relaciones_MASC).GetProperty(columnName));
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

