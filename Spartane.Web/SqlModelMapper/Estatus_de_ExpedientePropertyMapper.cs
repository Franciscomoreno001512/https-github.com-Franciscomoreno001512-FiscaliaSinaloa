using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Estatus_de_Expediente;

namespace Spartane.Web.SqlModelMapper
{
    public class Estatus_de_ExpedientePropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Estatus_de_Expediente.Clave";
                case "Estatus_General":
                    return "Estatus_de_Expediente.Estatus_General";
                case "Estatus_Especifico":
                    return "Estatus_de_Expediente.Estatus_Especifico";
                case "Estatus_Tipo_Caso":
                    return "Estatus_de_Expediente.Estatus_Tipo_Caso";
                case "Estatus_Descripcion_General":
                    return "Estatus_de_Expediente.Estatus_Descripcion_General";
                case "Estatus_Descripcion_Especifico":
                    return "Estatus_de_Expediente.Estatus_Descripcion_Especifico";
                case "Estatus_Completo":
                    return "Estatus_de_Expediente.Estatus_Completo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Estatus_de_Expediente).GetProperty(columnName));
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

