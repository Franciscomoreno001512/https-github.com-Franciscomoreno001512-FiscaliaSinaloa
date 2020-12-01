using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Plan_de_Investigacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Plan_de_InvestigacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Plan_de_Investigacion.Clave";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Fecha_de_Registro":
                    return "Plan_de_Investigacion.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Plan_de_Investigacion.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Fecha_Reunion_Mando_Ministerial":
                    return "Plan_de_Investigacion.Fecha_Reunion_Mando_Ministerial";
                case "Hora_Reunion_Mando_Ministerial":
                    return "Plan_de_Investigacion.Hora_Reunion_Mando_Ministerial";
                case "Asistentes":
                    return "Plan_de_Investigacion.Asistentes";
                case "Acuerdos":
                    return "Plan_de_Investigacion.Acuerdos";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Plan_de_Investigacion).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Registro")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_Reunion_Mando_Ministerial")
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

