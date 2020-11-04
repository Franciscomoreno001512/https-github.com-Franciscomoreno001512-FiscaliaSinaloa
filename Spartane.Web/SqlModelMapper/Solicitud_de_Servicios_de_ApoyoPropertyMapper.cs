using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo;

namespace Spartane.Web.SqlModelMapper
{
    public class Solicitud_de_Servicios_de_ApoyoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Solicitud_de_Servicios_de_Apoyo.Clave";
                case "Tipo_de_Servicio[Servicio]":
                case "Tipo_de_ServicioServicio":
                    return "Tipo_de_Servicio_de_Apoyo.Servicio";
                case "Dictamen":
                    return "Solicitud_de_Servicios_de_Apoyo.Dictamen";
                case "Responsable":
                    return "Solicitud_de_Servicios_de_Apoyo.Responsable";
                case "Clave_MR":
                    return "Solicitud_de_Servicios_de_Apoyo.Clave_MR";
                case "Compareciente[Nombre_Completo]":
                case "ComparecienteNombre_Completo":
                    return "Compareciente.Nombre_Completo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Solicitud_de_Servicios_de_Apoyo).GetProperty(columnName));
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

