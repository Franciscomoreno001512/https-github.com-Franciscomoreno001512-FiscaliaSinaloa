using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_Otros_AseguramientosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_Otros_Aseguramientos.Clave";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_Equipo_Tactico.Descripcion";
                case "Marca[Descripcion]":
                case "MarcaDescripcion":
                    return "Marca_de_Equipo_Tactico.Descripcion";
                case "Modelo[Descripcion]":
                case "ModeloDescripcion":
                    return "Modelo_de_equipo_tactico.Descripcion";
                case "Inventario":
                    return "Detalle_Aseguramiento_Otros_Aseguramientos.Inventario";
                case "Serie":
                    return "Detalle_Aseguramiento_Otros_Aseguramientos.Serie";
                case "Unidad_de_Medida[Descripcion]":
                case "Unidad_de_MedidaDescripcion":
                    return "Unidad_de_Medida_de_Equipo_Tactico.Descripcion";
                case "Cantidad":
                    return "Detalle_Aseguramiento_Otros_Aseguramientos.Cantidad";
                case "Observaciones":
                    return "Detalle_Aseguramiento_Otros_Aseguramientos.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_Otros_Aseguramientos).GetProperty(columnName));
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

