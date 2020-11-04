using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Coincidencias_MPI;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Coincidencias_MPIPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Coincidencias_MPI.Clave";
                case "Nombre_Completo":
                    return "Detalle_de_Coincidencias_MPI.Nombre_Completo";
                case "Alias":
                    return "Detalle_de_Coincidencias_MPI.Alias";
                case "Numero_de_Expediente":
                    return "Detalle_de_Coincidencias_MPI.Numero_de_Expediente";
                case "NUAT":
                    return "Detalle_de_Coincidencias_MPI.NUAT";
                case "NUC":
                    return "Detalle_de_Coincidencias_MPI.NUC";
                case "Rol":
                    return "Detalle_de_Coincidencias_MPI.Rol";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Coincidencias_MPI).GetProperty(columnName));
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

