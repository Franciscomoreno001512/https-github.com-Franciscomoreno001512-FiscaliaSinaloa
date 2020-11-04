using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_Record_Detail_Management;

namespace Spartane.Web.SqlModelMapper
{
    public class Spartan_Record_Detail_ManagementPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Process_Id":
                    return "Spartan_Record_Detail_Management.Process_Id";
                case "Register_Date":
                    return "Spartan_Record_Detail_Management.Register_Date";
                case "Register_Hour":
                    return "Spartan_Record_Detail_Management.Register_Hour";
                case "Register_User[Name]":
                case "Register_UserName":
                    return "Spartan_User.Name";
                case "Description":
                    return "Spartan_Record_Detail_Management.Description";
                case "Object[Description]":
                case "ObjectDescription":
                    return "Spartan_Object_ByPass.Description";
                case "Reference_Label":
                    return "Spartan_Record_Detail_Management.Reference_Label";
                case "Reference_Field[Description]":
                case "Reference_FieldDescription":
                    return "Spartan_Attribute_Bypass.Description";
                case "Search_Result":
                    return "Spartan_Record_Detail_Management.Search_Result";
                case "Search_Result_Query":
                    return "Spartan_Record_Detail_Management.Search_Result_Query";
                case "Image_Field[Description]":
                case "Image_FieldDescription":
                    return "Spartan_Attribute_Bypass.Description";
                case "Data_Detail":
                    return "Spartan_Record_Detail_Management.Data_Detail";
                case "Query_Data_Detail":
                    return "Spartan_Record_Detail_Management.Query_Data_Detail";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Spartan_Record_Detail_Management).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Register_Date")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
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

