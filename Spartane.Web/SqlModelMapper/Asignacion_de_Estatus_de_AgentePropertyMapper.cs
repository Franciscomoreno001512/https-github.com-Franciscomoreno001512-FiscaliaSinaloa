using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Asignacion_de_Estatus_de_Agente;

namespace Spartane.Web.SqlModelMapper
{
    public class Asignacion_de_Estatus_de_AgentePropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Asignacion_de_Estatus_de_Agente.Clave";
                case "MP[Name]":
                case "MPName":
                    return "Spartan_User.Name";
                case "Unidad[Descripcion]":
                case "UnidadDescripcion":
                    return "Unidad.Descripcion";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_de_Agente_MP.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Asignacion_de_Estatus_de_Agente).GetProperty(columnName));
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

