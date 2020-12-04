using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_Medios_de_TransportePropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Clave";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_medios_de_transporte.Descripcion";
                case "Especifique":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Especifique";
                case "Marca[Descripcion]":
                case "MarcaDescripcion":
                    return "Marca_de_Medio_de_transporte.Descripcion";
                case "Submarca":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Submarca";
                case "Modelo[Descripcion]":
                case "ModeloDescripcion":
                    return "Modelo_de_medio_de_transporte.Descripcion";
                case "Placas":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Placas";
                case "Color[Descripcion]":
                case "ColorDescripcion":
                    return "Color_de_medio_de_trasporte.Descripcion";
                case "Numero_de_Motor":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Numero_de_Motor";
                case "Serie":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Serie";
                case "Uso[Descripcion]":
                case "UsoDescripcion":
                    return "Uso_del_medio_de_transporte.Descripcion";
                case "Cap__De_Pasajeros":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Cap__De_Pasajeros";
                case "Procedencia[Descripcion]":
                case "ProcedenciaDescripcion":
                    return "Procedencia_del_medio_de_transporte.Descripcion";
                case "Empresa":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Empresa";
                case "Capacidad_de_Carga":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Capacidad_de_Carga";
                case "Origen":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Origen";
                case "Destino":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Destino";
                case "Observaciones":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_Medios_de_Transporte).GetProperty(columnName));
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

