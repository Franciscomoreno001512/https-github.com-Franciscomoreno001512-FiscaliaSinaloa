using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Datos_de_los_Hechos_PC;

namespace Spartane.Web.SqlModelMapper
{
    public class Datos_de_los_Hechos_PCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Datos_de_los_Hechos_PC.Clave";
                case "Solicitud[Folio]":
                case "SolicitudFolio":
                    return "Solicitud_de_Denuncia_Ciudadana.Folio";
                case "Titulo_del_Hecho":
                    return "Datos_de_los_Hechos_PC.Titulo_del_Hecho";
                case "Narrativa_Breve_de_los_Hechos":
                    return "Datos_de_los_Hechos_PC.Narrativa_Breve_de_los_Hechos";
                case "Fecha_del_Hecho":
                    return "Datos_de_los_Hechos_PC.Fecha_del_Hecho";
                case "Hora_Aproximada_del_Hecho":
                    return "Datos_de_los_Hechos_PC.Hora_Aproximada_del_Hecho";
                case "Fosa_clandestina[Descripcion]":
                case "Fosa_clandestinaDescripcion":
                    return "Respuesta.Descripcion";
                case "Conoce_la_direccion[Descripcion]":
                case "Conoce_la_direccionDescripcion":
                    return "Respuesta.Descripcion";
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
                    return "Datos_de_los_Hechos_PC.Codigo_Postal";
                case "Calle":
                    return "Datos_de_los_Hechos_PC.Calle";
                case "Entre_Calle":
                    return "Datos_de_los_Hechos_PC.Entre_Calle";
                case "Y_Calle":
                    return "Datos_de_los_Hechos_PC.Y_Calle";
                case "Numero_Exterior":
                    return "Datos_de_los_Hechos_PC.Numero_Exterior";
                case "Numero_Interior":
                    return "Datos_de_los_Hechos_PC.Numero_Interior";
                case "Referencia":
                    return "Datos_de_los_Hechos_PC.Referencia";
                case "Latitud":
                    return "Datos_de_los_Hechos_PC.Latitud";
                case "Longitud":
                    return "Datos_de_los_Hechos_PC.Longitud";
                case "Es_una_direccion_exacta_o_aproximada[Descripcion]":
                case "Es_una_direccion_exacta_o_aproximadaDescripcion":
                    return "Direccion_Exacta.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Datos_de_los_Hechos_PC).GetProperty(columnName));
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

