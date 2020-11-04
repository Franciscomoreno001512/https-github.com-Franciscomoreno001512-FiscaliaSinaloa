using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_RDM_Operations_Detail;

namespace Spartane.Web.SqlModelMapper
{
    public class Spartan_RDM_Operations_DetailPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "DetailId":
                    return "Spartan_RDM_Operations_Detail.DetailId";
                case "Object_Name[Description]":
                case "Object_NameDescription":
                    return "Spartan_Object_ByPass.Description";
                case "Object_Label":
                    return "Spartan_RDM_Operations_Detail.Object_Label";
                case "Order_Shown":
                    return "Spartan_RDM_Operations_Detail.Order_Shown";
                case "Count_Query":
                    return "Spartan_RDM_Operations_Detail.Count_Query";
                case "Query_Data":
                    return "Spartan_RDM_Operations_Detail.Query_Data";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Spartan_RDM_Operations_Detail).GetProperty(columnName));
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

