using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Turnos;

namespace Spartane.Web.SqlModelMapper
{
    public class TurnosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Turnos.Clave";
                case "Clave_de_Municipio":
                    return "Turnos.Clave_de_Municipio";
                case "Descripcion":
                    return "Turnos.Descripcion";
                case "Clave_de_Agencia":
                    return "Turnos.Clave_de_Agencia";
                case "Clave_de_MunicipioAgencia":
                    return "Turnos.Clave_de_MunicipioAgencia";
                case "Depende_de":
                    return "Turnos.Depende_de";
                case "Activo":
                    return "Turnos.Activo";
                case "Prioridad":
                    return "Turnos.Prioridad";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Turnos).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Activo")
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

