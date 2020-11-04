using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Indicios;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_IndiciosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Indicios.Clave";
                case "Numero_de_Indicio":
                    return "Detalle_de_Indicios.Numero_de_Indicio";
                case "Nombre_de_Indicio":
                    return "Detalle_de_Indicios.Nombre_de_Indicio";
                case "Descripcion_de_Indicio":
                    return "Detalle_de_Indicios.Descripcion_de_Indicio";
                case "Motivo_de_Indicio":
                    return "Detalle_de_Indicios.Motivo_de_Indicio";
                case "Diligencia[Servicio]":
                case "DiligenciaServicio":
                    return "Servicios_Periciales.Servicio";
                case "Ubicacion":
                    return "Detalle_de_Indicios.Ubicacion";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_de_Indicio.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Indicios).GetProperty(columnName));
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

