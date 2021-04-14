using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Resultados;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_ResultadosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Resultados.Clave";
                case "Fuente":
                    return "Detalle_de_Resultados.Fuente";
                case "Tipo_de_Mandamiento":
                    return "Detalle_de_Resultados.Tipo_de_Mandamiento";
                case "Nombre":
                    return "Detalle_de_Resultados.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Resultados.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Resultados.Apellido_Materno";
                case "Alias":
                    return "Detalle_de_Resultados.Alias";
                case "Sexo":
                    return "Detalle_de_Resultados.Sexo";
                case "Pais":
                    return "Detalle_de_Resultados.Pais";
                case "Estado":
                    return "Detalle_de_Resultados.Estado";
                case "Municipio":
                    return "Detalle_de_Resultados.Municipio";
                case "Juzgado":
                    return "Detalle_de_Resultados.Juzgado";
                case "Oficio_Solicitud_Juzgado":
                    return "Detalle_de_Resultados.Oficio_Solicitud_Juzgado";
                case "Carpeta_de_Investigacion":
                    return "Detalle_de_Resultados.Carpeta_de_Investigacion";
                case "Causa_Penal":
                    return "Detalle_de_Resultados.Causa_Penal";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Resultados).GetProperty(columnName));
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

