using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Circunstancia_del_Delito;

namespace Spartane.Web.SqlModelMapper
{
    public class Circunstancia_del_DelitoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Circunstancia_del_Delito.Clave";
                case "Titulo_del_Delito[Descripcion]":
                case "Titulo_del_DelitoDescripcion":
                    return "Titulo_del_Delito.Descripcion";
                case "Grupo_del_Delito[Descripcion]":
                case "Grupo_del_DelitoDescripcion":
                    return "Grupo_del_Delito.Descripcion";
                case "Delito[Descripcion]":
                case "DelitoDescripcion":
                    return "Delito.Descripcion";
                case "Descripcion":
                    return "Circunstancia_del_Delito.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Circunstancia_del_Delito).GetProperty(columnName));
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

