using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_del_Testigo_CC;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Datos_del_Testigo_CCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Datos_del_Testigo_CC.Clave";
                case "Apellido_Materno":
                    return "Detalle_de_Datos_del_Testigo_CC.Apellido_Materno";
                case "Apellido_Paterno":
                    return "Detalle_de_Datos_del_Testigo_CC.Apellido_Paterno";
                case "Calle":
                    return "Detalle_de_Datos_del_Testigo_CC.Calle";
                case "Celular":
                    return "Detalle_de_Datos_del_Testigo_CC.Celular";
                case "Codigo_Postal":
                    return "Detalle_de_Datos_del_Testigo_CC.Codigo_Postal";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Correo_Electronico":
                    return "Detalle_de_Datos_del_Testigo_CC.Correo_Electronico";
                case "Edad":
                    return "Detalle_de_Datos_del_Testigo_CC.Edad";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Estado_Civil[Descripcion]":
                case "Estado_CivilDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Extension":
                    return "Detalle_de_Datos_del_Testigo_CC.Extension";
                case "Fecha_de_nacimiento":
                    return "Detalle_de_Datos_del_Testigo_CC.Fecha_de_nacimiento";
                case "Inimputable":
                    return "Detalle_de_Datos_del_Testigo_CC.Inimputable";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Nombre":
                    return "Detalle_de_Datos_del_Testigo_CC.Nombre";
                case "Nombre_Completo":
                    return "Detalle_de_Datos_del_Testigo_CC.Nombre_Completo";
                case "Numero_de_identificacion":
                    return "Detalle_de_Datos_del_Testigo_CC.Numero_de_identificacion";
                case "Numero_Exterior":
                    return "Detalle_de_Datos_del_Testigo_CC.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Datos_del_Testigo_CC.Numero_Interior";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Proteccion_de_Datos":
                    return "Detalle_de_Datos_del_Testigo_CC.Proteccion_de_Datos";
                case "Genero[Descripcion]":
                case "GeneroDescripcion":
                    return "Genero.Descripcion";
                case "Telefono":
                    return "Detalle_de_Datos_del_Testigo_CC.Telefono";
                case "Tipo_de_compareciente[Descripcion]":
                case "Tipo_de_comparecienteDescripcion":
                    return "Tipo_de_Compareciente.Descripcion";
                case "Tipo_de_identificacion[Nombre]":
                case "Tipo_de_identificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Tipo_de_inimputabilidad[Descripcion]":
                case "Tipo_de_inimputabilidadDescripcion":
                    return "Tipo_de_Inimputabilidad.Descripcion";
                case "Entre_Calle":
                    return "Detalle_de_Datos_del_Testigo_CC.Entre_Calle";
                case "Y_Calle":
                    return "Detalle_de_Datos_del_Testigo_CC.Y_Calle";
                case "Referencia_del_Domicilio":
                    return "Detalle_de_Datos_del_Testigo_CC.Referencia_del_Domicilio";
                case "Especifique":
                    return "Detalle_de_Datos_del_Testigo_CC.Especifique";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Datos_del_Testigo_CC).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_nacimiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Inimputable")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Proteccion_de_Datos")
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

