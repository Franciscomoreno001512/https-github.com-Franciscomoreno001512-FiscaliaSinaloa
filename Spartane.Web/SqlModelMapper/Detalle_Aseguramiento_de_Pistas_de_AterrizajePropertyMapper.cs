using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_de_Pistas_de_AterrizajePropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Clave";
                case "Motivo_de_Registro[Descripcion]":
                case "Motivo_de_RegistroDescripcion":
                    return "Motivo_de_Registro.Descripcion";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_Pista_de_Aterrizaje.Descripcion";
                case "Suelo":
                    return "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Suelo";
                case "Descripcion":
                    return "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Descripcion";
                case "Localizacion_1":
                    return "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Localizacion_1";
                case "Latitud":
                    return "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Latitud";
                case "Longitud":
                    return "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Longitud";
                case "Orientacion_de[Descripcion]":
                case "Orientacion_deDescripcion":
                    return "Tipo_de_Orientacion.Descripcion";
                case "Orientacion[Descripcion]":
                case "OrientacionDescripcion":
                    return "Tipo_de_Orientacion.Descripcion";
                case "Largo":
                    return "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Largo";
                case "Ancho":
                    return "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Ancho";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_de_Pistas_de_Aterrizaje).GetProperty(columnName));
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

