using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitudes_de_Comparecencia;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Solicitudes_de_ComparecenciaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Solicitudes_de_Comparecencia.Clave";
                case "Archivo":
                    return "Detalle_de_Solicitudes_de_Comparecencia.Archivo";
                case "Nombre[Descripcion]":
                case "NombreDescripcion":
                    return "Nombre_Comparecencia.Descripcion";
                case "Fecha_de_la_Comparecencia":
                    return "Detalle_de_Solicitudes_de_Comparecencia.Fecha_de_la_Comparecencia";
                case "Hora_de_la_Comparecencia":
                    return "Detalle_de_Solicitudes_de_Comparecencia.Hora_de_la_Comparecencia";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Solicitudes_de_Comparecencia).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_la_Comparecencia")
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

