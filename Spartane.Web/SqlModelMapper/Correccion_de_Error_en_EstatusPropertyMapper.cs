using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Correccion_de_Error_en_Estatus;

namespace Spartane.Web.SqlModelMapper
{
    public class Correccion_de_Error_en_EstatusPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Correccion_de_Error_en_Estatus.Clave";
                case "NUAT":
                    return "Correccion_de_Error_en_Estatus.NUAT";
                case "Estatus_Actual[Descripcion]":
                case "Estatus_ActualDescripcion":
                    return "Estatus_Orientador.Descripcion";
                case "Estatus_a_Cambiar[Descripcion]":
                case "Estatus_a_CambiarDescripcion":
                    return "Estatus_Orientador.Descripcion";
                case "Motivo":
                    return "Correccion_de_Error_en_Estatus.Motivo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Correccion_de_Error_en_Estatus).GetProperty(columnName));
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

