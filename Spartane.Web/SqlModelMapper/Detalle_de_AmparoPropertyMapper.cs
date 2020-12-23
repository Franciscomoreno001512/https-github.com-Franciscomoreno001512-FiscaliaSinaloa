using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Amparo;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_AmparoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Amparo.Clave";
                case "Tipo_de_Amparo[Descripcion]":
                case "Tipo_de_AmparoDescripcion":
                    return "Tipo_de_Amparo.Descripcion";
                case "Numero_de_Amparo":
                    return "Detalle_de_Amparo.Numero_de_Amparo";
                case "Fecha_Amparo":
                    return "Detalle_de_Amparo.Fecha_Amparo";
                case "Entidad_que_Emitio_Amparo[Nombre]":
                case "Entidad_que_Emitio_AmparoNombre":
                    return "Estado.Nombre";
                case "Resolucion[Descripcion]":
                case "ResolucionDescripcion":
                    return "Tipo_de_Resolucion.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Amparo).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_Amparo")
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

