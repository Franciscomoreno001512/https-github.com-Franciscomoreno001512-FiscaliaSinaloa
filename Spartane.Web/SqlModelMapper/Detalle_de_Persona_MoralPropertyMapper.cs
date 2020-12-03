using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Persona_Moral;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Persona_MoralPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Persona_Moral.Clave";
                case "Modulo_Atencion_Inicial[NUAT]":
                case "Modulo_Atencion_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Nombre":
                    return "Detalle_de_Persona_Moral.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Persona_Moral.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Persona_Moral.Apellido_Materno";
                case "Nombre_Completo":
                    return "Detalle_de_Persona_Moral.Nombre_Completo";
                case "Calidad_Juridica":
                    return "Detalle_de_Persona_Moral.Calidad_Juridica";
                case "Razon_Social":
                    return "Detalle_de_Persona_Moral.Razon_Social";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "Localidad[Descripcion]":
                case "LocalidadDescripcion":
                    return "Localidad.Descripcion";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Calle":
                    return "Detalle_de_Persona_Moral.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Persona_Moral.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Persona_Moral.Numero_Interior";
                case "Referencia":
                    return "Detalle_de_Persona_Moral.Referencia";
                case "Latitud":
                    return "Detalle_de_Persona_Moral.Latitud";
                case "Longitud":
                    return "Detalle_de_Persona_Moral.Longitud";
                case "Telefono":
                    return "Detalle_de_Persona_Moral.Telefono";
                case "Extension":
                    return "Detalle_de_Persona_Moral.Extension";
                case "Celular":
                    return "Detalle_de_Persona_Moral.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Persona_Moral.Correo_Electronico";
                case "Codigo_Postal":
                    return "Detalle_de_Persona_Moral.Codigo_Postal";
                case "RFC":
                    return "Detalle_de_Persona_Moral.RFC";
                case "CURP":
                    return "Detalle_de_Persona_Moral.CURP";
                case "ID_Estado_Institucion":
                    return "Detalle_de_Persona_Moral.ID_Estado_Institucion";
                case "Nombres":
                    return "Detalle_de_Persona_Moral.Nombres";
                case "Apellido_Paterno2":
                    return "Detalle_de_Persona_Moral.Apellido_Paterno2";
                case "Apellido_Materno2":
                    return "Detalle_de_Persona_Moral.Apellido_Materno2";
                case "Nombre_Completo2":
                    return "Detalle_de_Persona_Moral.Nombre_Completo2";
                case "Sexo[Descripcion]":
                case "SexoDescripcion":
                    return "Genero.Descripcion";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Persona_Moral).GetProperty(columnName));
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

