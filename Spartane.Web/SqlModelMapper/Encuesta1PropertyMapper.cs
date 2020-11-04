using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Encuesta1;

namespace Spartane.Web.SqlModelMapper
{
    public class Encuesta1PropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Encuesta1.Clave";
                case "Numero_de_Preguntas[Descripcion]":
                case "Numero_de_PreguntasDescripcion":
                    return "Catalogo_Numero_de_Preguntas.Descripcion";
                case "NUAT":
                    return "Encuesta1.NUAT";
                case "Pregunta1[Descripcion]":
                case "Pregunta1Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta2[Descripcion]":
                case "Pregunta2Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta3[Descripcion]":
                case "Pregunta3Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta4[Descripcion]":
                case "Pregunta4Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta5[Descripcion]":
                case "Pregunta5Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta6[Descripcion]":
                case "Pregunta6Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta7[Descripcion]":
                case "Pregunta7Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta8[Descripcion]":
                case "Pregunta8Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta9[Descripcion]":
                case "Pregunta9Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta10[Descripcion]":
                case "Pregunta10Descripcion":
                    return "Catalogo_Respuesta.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Encuesta1).GetProperty(columnName));
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

