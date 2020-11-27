using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.detalle_de_observaciones_mpi;

namespace Spartane.Web.SqlModelMapper
{
    public class detalle_de_observaciones_mpiPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "clave":
                    return "detalle_de_observaciones_mpi.clave";
                case "observaciones":
                    return "detalle_de_observaciones_mpi.observaciones";
                case "fecha":
                    return "detalle_de_observaciones_mpi.fecha";
                case "hora":
                    return "detalle_de_observaciones_mpi.hora";
                case "usuario_que_realiza_observacion[Name]":
                case "usuario_que_realiza_observacionName":
                    return "Spartan_User.Name";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(detalle_de_observaciones_mpi).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "fecha")
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

