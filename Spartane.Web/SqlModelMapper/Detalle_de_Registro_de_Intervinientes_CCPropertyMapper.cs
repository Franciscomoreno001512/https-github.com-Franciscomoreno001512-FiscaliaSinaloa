using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Registro_de_Intervinientes_CC;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Registro_de_Intervinientes_CCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Clave";
                case "Nombres":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Nombres";
                case "Apellido_Paterno":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Apellido_Materno";
                case "Alias":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Alias";
                case "Anonimo":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Anonimo";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Fecha_de_Nacimiento";
                case "Edad":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Edad";
                case "Sexo[Descripcion]":
                case "SexoDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil[Descripcion]":
                case "Estado_CivilDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion[Nombre]":
                case "Tipo_de_IdentificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Numero_de_Identificacion";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Codigo_Postal";
                case "Calle":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Numero_Interior";
                case "Telefono":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Telefono";
                case "Celular":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Correo_Electronico";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Entre_calle":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Entre_calle";
                case "Especifique":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Especifique";
                case "Extension":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Extension";
                case "Inimputable":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Inimputable";
                case "Nombre_Completo":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Nombre_Completo";
                case "Originario_de":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Originario_de";
                case "Pais_de_Origen[Nombre]":
                case "Pais_de_OrigenNombre":
                    return "Pais.Nombre";
                case "Proteccion_de_Datos":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Proteccion_de_Datos";
                case "Referencia_de_Domicilio":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Referencia_de_Domicilio";
                case "Y_calle":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Y_calle";
                case "Tipo_de_Compareciente[Descripcion]":
                case "Tipo_de_ComparecienteDescripcion":
                    return "Tipo_de_Compareciente.Descripcion";
                case "Tipo_de_inimputabilidad[Descripcion]":
                case "Tipo_de_inimputabilidadDescripcion":
                    return "Tipo_de_Inimputabilidad.Descripcion";
                case "Nombre":
                    return "Detalle_de_Registro_de_Intervinientes_CC.Nombre";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Registro_de_Intervinientes_CC).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Anonimo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Nacimiento")
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

