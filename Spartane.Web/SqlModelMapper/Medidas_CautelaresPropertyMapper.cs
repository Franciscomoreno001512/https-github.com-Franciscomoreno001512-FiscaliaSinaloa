using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Medidas_Cautelares;

namespace Spartane.Web.SqlModelMapper
{
    public class Medidas_CautelaresPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Medidas_Cautelares.Clave";
                case "Descripcion":
                    return "Medidas_Cautelares.Descripcion";
                case "Fraccion":
                    return "Medidas_Cautelares.Fraccion";
                case "Aplica_para_Adolescentes":
                    return "Medidas_Cautelares.Aplica_para_Adolescentes";
                case "Aplica_para_Adultos":
                    return "Medidas_Cautelares.Aplica_para_Adultos";
                case "Tipo":
                    return "Medidas_Cautelares.Tipo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Medidas_Cautelares).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Aplica_para_Adolescentes")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Aplica_para_Adultos")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
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

