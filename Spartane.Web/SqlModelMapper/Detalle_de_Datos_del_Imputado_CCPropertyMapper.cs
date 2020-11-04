using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_CC;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Datos_del_Imputado_CCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Datos_del_Imputado_CC.Clave";
                case "A_Quien_Resulte_Responsable":
                    return "Detalle_de_Datos_del_Imputado_CC.A_Quien_Resulte_Responsable";
                case "Alias":
                    return "Detalle_de_Datos_del_Imputado_CC.Alias";
                case "Apellido_Materno":
                    return "Detalle_de_Datos_del_Imputado_CC.Apellido_Materno";
                case "Apellido_Paterno":
                    return "Detalle_de_Datos_del_Imputado_CC.Apellido_Paterno";
                case "Calle":
                    return "Detalle_de_Datos_del_Imputado_CC.Calle";
                case "Celular":
                    return "Detalle_de_Datos_del_Imputado_CC.Celular";
                case "Codigo_Postal":
                    return "Detalle_de_Datos_del_Imputado_CC.Codigo_Postal";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Correo_Electronico":
                    return "Detalle_de_Datos_del_Imputado_CC.Correo_Electronico";
                case "Edad":
                    return "Detalle_de_Datos_del_Imputado_CC.Edad";
                case "Entre_calle":
                    return "Detalle_de_Datos_del_Imputado_CC.Entre_calle";
                case "Escolaridad":
                    return "Detalle_de_Datos_del_Imputado_CC.Escolaridad";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Estado_Civil[Descripcion]":
                case "Estado_CivilDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Estension":
                    return "Detalle_de_Datos_del_Imputado_CC.Estension";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Datos_del_Imputado_CC.Fecha_de_Nacimiento";
                case "Inimputable":
                    return "Detalle_de_Datos_del_Imputado_CC.Inimputable";
                case "Tipo_de_Inimputabilidad[Descripcion]":
                case "Tipo_de_InimputabilidadDescripcion":
                    return "Tipo_de_Inimputabilidad.Descripcion";
                case "Especifique":
                    return "Detalle_de_Datos_del_Imputado_CC.Especifique";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Nombre":
                    return "Detalle_de_Datos_del_Imputado_CC.Nombre";
                case "Nombre_Completo":
                    return "Detalle_de_Datos_del_Imputado_CC.Nombre_Completo";
                case "Numero_de_Identificacion":
                    return "Detalle_de_Datos_del_Imputado_CC.Numero_de_Identificacion";
                case "Numero_Exterior":
                    return "Detalle_de_Datos_del_Imputado_CC.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Datos_del_Imputado_CC.Numero_Interior";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Originario_de":
                    return "Detalle_de_Datos_del_Imputado_CC.Originario_de";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Pais_de_Origen[Nombre]":
                case "Pais_de_OrigenNombre":
                    return "Pais.Nombre";
                case "Proteccion_de_datos":
                    return "Detalle_de_Datos_del_Imputado_CC.Proteccion_de_datos";
                case "Referencia_de_domicilio":
                    return "Detalle_de_Datos_del_Imputado_CC.Referencia_de_domicilio";
                case "Genero[Descripcion]":
                case "GeneroDescripcion":
                    return "Genero.Descripcion";
                case "Telefono":
                    return "Detalle_de_Datos_del_Imputado_CC.Telefono";
                case "Tipo_de_Identificacion[Nombre]":
                case "Tipo_de_IdentificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Y_calle":
                    return "Detalle_de_Datos_del_Imputado_CC.Y_calle";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Datos_del_Imputado_CC).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "A_Quien_Resulte_Responsable")
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
            if (columnName == "Proteccion_de_datos")
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

