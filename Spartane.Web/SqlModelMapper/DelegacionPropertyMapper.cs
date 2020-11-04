using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Delegacion;

namespace Spartane.Web.SqlModelMapper
{
    public class DelegacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Delegacion.Clave";
                case "Descripcion":
                    return "Delegacion.Descripcion";
                case "Zona[Descripcion]":
                case "ZonaDescripcion":
                    return "Region.Descripcion";
                case "Clave_Expediente":
                    return "Delegacion.Clave_Expediente";
                case "Direccion":
                    return "Delegacion.Direccion";
                case "Consecutivo_MPO":
                    return "Delegacion.Consecutivo_MPO";
                case "Consecutivo_MPI":
                    return "Delegacion.Consecutivo_MPI";
                case "Distrito[Descripcion]":
                case "DistritoDescripcion":
                    return "Distrito_Judicial.Descripcion";
                case "Abreviacion_Delegacion":
                    return "Delegacion.Abreviacion_Delegacion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Delegacion).GetProperty(columnName));
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

