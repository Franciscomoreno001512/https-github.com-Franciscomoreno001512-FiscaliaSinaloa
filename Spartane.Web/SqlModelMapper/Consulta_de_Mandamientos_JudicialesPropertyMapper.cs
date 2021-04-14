using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales;

namespace Spartane.Web.SqlModelMapper
{
    public class Consulta_de_Mandamientos_JudicialesPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Consulta_de_Mandamientos_Judiciales.Clave";
                case "MandamientoJudicialId":
                    return "Consulta_de_Mandamientos_Judiciales.MandamientoJudicialId";
                case "Nombre":
                    return "Consulta_de_Mandamientos_Judiciales.Nombre";
                case "Apellido_Paterno":
                    return "Consulta_de_Mandamientos_Judiciales.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Consulta_de_Mandamientos_Judiciales.Apellido_Materno";
                case "Alias":
                    return "Consulta_de_Mandamientos_Judiciales.Alias";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Juzgado[Nombre]":
                case "JuzgadoNombre":
                    return "Juzgado.Nombre";
                case "Oficio_Solicitud_Juzgado":
                    return "Consulta_de_Mandamientos_Judiciales.Oficio_Solicitud_Juzgado";
                case "Carpeta_de_Investigacion":
                    return "Consulta_de_Mandamientos_Judiciales.Carpeta_de_Investigacion";
                case "Causa_Penal":
                    return "Consulta_de_Mandamientos_Judiciales.Causa_Penal";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Consulta_de_Mandamientos_Judiciales).GetProperty(columnName));
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

