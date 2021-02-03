using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_Objetos_Asegurados;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_Objetos_AseguradosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_Objetos_Asegurados.Clave";
                case "Motivo_de_Registro[Descripcion]":
                case "Motivo_de_RegistroDescripcion":
                    return "Motivo_de_Registro.Descripcion";
                case "Numero":
                    return "Detalle_Aseguramiento_Objetos_Asegurados.Numero";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_Equipo_de_Comunicacion.Descripcion";
                case "Marca[Descripcion]":
                case "MarcaDescripcion":
                    return "Marca_de_Equipo_de_Comunicacion.Descripcion";
                case "Serie":
                    return "Detalle_Aseguramiento_Objetos_Asegurados.Serie";
                case "IMEI":
                    return "Detalle_Aseguramiento_Objetos_Asegurados.IMEI";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_Objetos_Asegurados).GetProperty(columnName));
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

