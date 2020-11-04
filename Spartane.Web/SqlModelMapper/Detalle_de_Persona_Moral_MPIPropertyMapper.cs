using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Persona_Moral_MPI;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Persona_Moral_MPIPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Persona_Moral_MPI.Clave";
                case "Nombre":
                    return "Detalle_de_Persona_Moral_MPI.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Persona_Moral_MPI.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Persona_Moral_MPI.Apellido_Materno";
                case "Nombre_Completo":
                    return "Detalle_de_Persona_Moral_MPI.Nombre_Completo";
                case "Calidad_Juridica":
                    return "Detalle_de_Persona_Moral_MPI.Calidad_Juridica";
                case "Razon_Social":
                    return "Detalle_de_Persona_Moral_MPI.Razon_Social";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Localidad[Descripcion]":
                case "LocalidadDescripcion":
                    return "Localidad.Descripcion";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Calle":
                    return "Detalle_de_Persona_Moral_MPI.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Persona_Moral_MPI.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Persona_Moral_MPI.Numero_Interior";
                case "Telefono":
                    return "Detalle_de_Persona_Moral_MPI.Telefono";
                case "Extension":
                    return "Detalle_de_Persona_Moral_MPI.Extension";
                case "Celular":
                    return "Detalle_de_Persona_Moral_MPI.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Persona_Moral_MPI.Correo_Electronico";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Persona_Moral_MPI).GetProperty(columnName));
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

