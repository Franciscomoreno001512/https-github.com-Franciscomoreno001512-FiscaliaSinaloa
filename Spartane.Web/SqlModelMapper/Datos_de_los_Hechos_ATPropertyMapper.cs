using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Datos_de_los_Hechos_AT;

namespace Spartane.Web.SqlModelMapper
{
    public class Datos_de_los_Hechos_ATPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Datos_de_los_Hechos_AT.Clave";
                case "Modulo_Atencion_Inicial[NUAT]":
                case "Modulo_Atencion_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Titulo_del_Hecho":
                    return "Datos_de_los_Hechos_AT.Titulo_del_Hecho";
                case "Narrativa_Breve_de_los_Hechos":
                    return "Datos_de_los_Hechos_AT.Narrativa_Breve_de_los_Hechos";
                case "Prioridad_del_Hecho[Descripcion]":
                case "Prioridad_del_HechoDescripcion":
                    return "Prioridad_del_Hecho.Descripcion";
                case "Fecha_del_Hecho":
                    return "Datos_de_los_Hechos_AT.Fecha_del_Hecho";
                case "Hora_Aproximada_del_Hecho":
                    return "Datos_de_los_Hechos_AT.Hora_Aproximada_del_Hecho";
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
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Datos_de_los_Hechos_AT.Codigo_Postal";
                case "Calle":
                    return "Datos_de_los_Hechos_AT.Calle";
                case "Entre_Calle":
                    return "Datos_de_los_Hechos_AT.Entre_Calle";
                case "Y_Calle":
                    return "Datos_de_los_Hechos_AT.Y_Calle";
                case "Numero_Exterior":
                    return "Datos_de_los_Hechos_AT.Numero_Exterior";
                case "Numero_Interior":
                    return "Datos_de_los_Hechos_AT.Numero_Interior";
                case "Referencia":
                    return "Datos_de_los_Hechos_AT.Referencia";
                case "Latitud":
                    return "Datos_de_los_Hechos_AT.Latitud";
                case "Longitud":
                    return "Datos_de_los_Hechos_AT.Longitud";
                case "Documento_Extraviado":
                    return "Datos_de_los_Hechos_AT.Documento_Extraviado";
                case "Tipo_de_Documento_Extraviado[Descripcion]":
                case "Tipo_de_Documento_ExtraviadoDescripcion":
                    return "Documento_Extraviado.Descripcion";
                case "Tipo_de_Lugar_del_Hecho[Descripcion]":
                case "Tipo_de_Lugar_del_HechoDescripcion":
                    return "Lugar_Tipo.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Datos_de_los_Hechos_AT).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_del_Hecho")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Documento_Extraviado")
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

