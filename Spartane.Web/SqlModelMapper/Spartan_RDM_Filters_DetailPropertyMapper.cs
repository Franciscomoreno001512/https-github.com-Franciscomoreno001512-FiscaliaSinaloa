using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_RDM_Filters_Detail;

namespace Spartane.Web.SqlModelMapper
{
    public class Spartan_RDM_Filters_DetailPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Filters_Detail_Id":
                    return "Spartan_RDM_Filters_Detail.Filters_Detail_Id";
                case "Field_Name[Description]":
                case "Field_NameDescription":
                    return "Spartan_Attribute_Bypass.Description";
                case "Field_Label":
                    return "Spartan_RDM_Filters_Detail.Field_Label";
                case "Order_Shown":
                    return "Spartan_RDM_Filters_Detail.Order_Shown";
                case "Field_Path":
                    return "Spartan_RDM_Filters_Detail.Field_Path";
                case "Physical_Field_Name":
                    return "Spartan_RDM_Filters_Detail.Physical_Field_Name";
                case "Logical_Field_Name":
                    return "Spartan_RDM_Filters_Detail.Logical_Field_Name";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Spartan_RDM_Filters_Detail).GetProperty(columnName));
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

