using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_de_Drogas_InvolucradasPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_de_Drogas_Involucradas.Clave";
                case "Motivo_de_Registro[Descripcion]":
                case "Motivo_de_RegistroDescripcion":
                    return "Motivo_de_Registro.Descripcion";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_Droga.Descripcion";
                case "Modo_de_Asegurado[Descripcion]":
                case "Modo_de_AseguradoDescripcion":
                    return "Modo_de_Asegurado_de_Drogas.Descripcion";
                case "Unidad_de_Medida[Descripcion]":
                case "Unidad_de_MedidaDescripcion":
                    return "Unidad_de_medida_de_tipo_de_droga.Descripcion";
                case "Cantidad":
                    return "Detalle_Aseguramiento_de_Drogas_Involucradas.Cantidad";
                case "Observaciones":
                    return "Detalle_Aseguramiento_de_Drogas_Involucradas.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_de_Drogas_Involucradas).GetProperty(columnName));
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

