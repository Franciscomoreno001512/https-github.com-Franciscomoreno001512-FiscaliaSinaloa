using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Audiencia_Defensor_Imputado;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Audiencia_Defensor_ImputadoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Audiencia_Defensor_Imputado.Clave";
                case "Nombre_Del_Imputado[Nombre_Completo_del_Tutor]":
                case "Nombre_Del_ImputadoNombre_Completo_del_Tutor":
                    return "Detalle_de_Imputado.Nombre_Completo_del_Tutor";
                case "Abogado":
                    return "Detalle_Audiencia_Defensor_Imputado.Abogado";
                case "Cedula_Profesional":
                    return "Detalle_Audiencia_Defensor_Imputado.Cedula_Profesional";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Audiencia_Defensor_Imputado).GetProperty(columnName));
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

