using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Plantios;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_de_PlantiosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_de_Plantios.Clave";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_Plantio.Descripcion";
                case "No__de_Plantios":
                    return "Detalle_Aseguramiento_de_Plantios.No__de_Plantios";
                case "Kilogramos":
                    return "Detalle_Aseguramiento_de_Plantios.Kilogramos";
                case "Metodo_de_Destruccion[Descripcion]":
                case "Metodo_de_DestruccionDescripcion":
                    return "Metodo_de_Destruccion.Descripcion";
                case "Superficie":
                    return "Detalle_Aseguramiento_de_Plantios.Superficie";
                case "Altura":
                    return "Detalle_Aseguramiento_de_Plantios.Altura";
                case "Densidad":
                    return "Detalle_Aseguramiento_de_Plantios.Densidad";
                case "Peso_por_planta":
                    return "Detalle_Aseguramiento_de_Plantios.Peso_por_planta";
                case "Latitud":
                    return "Detalle_Aseguramiento_de_Plantios.Latitud";
                case "Longitud":
                    return "Detalle_Aseguramiento_de_Plantios.Longitud";
                case "Largo":
                    return "Detalle_Aseguramiento_de_Plantios.Largo";
                case "Ancho":
                    return "Detalle_Aseguramiento_de_Plantios.Ancho";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_de_Plantios).GetProperty(columnName));
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

