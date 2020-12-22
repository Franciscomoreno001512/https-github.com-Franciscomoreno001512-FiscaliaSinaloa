using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Encuesta;

namespace Spartane.Web.SqlModelMapper
{
    public class EncuestaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Encuesta.Clave";
                case "Modulo[Descripcion]":
                case "ModuloDescripcion":
                    return "Modulo_Encuesta.Descripcion";
                case "Numero_de_Preguntas[Descripcion]":
                case "Numero_de_PreguntasDescripcion":
                    return "Catalogo_Numero_de_Preguntas.Descripcion";
                case "Pregunta_1":
                    return "Encuesta.Pregunta_1";
                case "Pregunta_2":
                    return "Encuesta.Pregunta_2";
                case "Pregunta_3":
                    return "Encuesta.Pregunta_3";
                case "Pregunta_4":
                    return "Encuesta.Pregunta_4";
                case "Pregunta_5":
                    return "Encuesta.Pregunta_5";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Encuesta).GetProperty(columnName));
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

