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
                case "Folio":
                    return "Encuesta1.Folio";
                case "Fecha_Enviado":
                    return "Encuesta1.Fecha_Enviado";
                case "Hora_Enviado":
                    return "Encuesta1.Hora_Enviado";
                case "Fecha_Respuesta":
                    return "Encuesta1.Fecha_Respuesta";
                case "Hora_Respuesta":
                    return "Encuesta1.Hora_Respuesta";
                case "NUAT":
                    return "Encuesta1.NUAT";
                case "Modulo[Descripcion]":
                case "ModuloDescripcion":
                    return "Modulo_Encuesta.Descripcion";
                case "Numero_de_Preguntas[Descripcion]":
                case "Numero_de_PreguntasDescripcion":
                    return "Catalogo_Numero_de_Preguntas.Descripcion";
                case "Pregunta1":
                    return "Encuesta1.Pregunta1";
                case "Respuesta_1[Descripcion]":
                case "Respuesta_1Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta2":
                    return "Encuesta1.Pregunta2";
                case "Respuesta_2[Descripcion]":
                case "Respuesta_2Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta3":
                    return "Encuesta1.Pregunta3";
                case "Respuesta_3[Descripcion]":
                case "Respuesta_3Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta4":
                    return "Encuesta1.Pregunta4";
                case "Respuesta_4[Descripcion]":
                case "Respuesta_4Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Pregunta5":
                    return "Encuesta1.Pregunta5";
                case "Respuesta_5[Descripcion]":
                case "Respuesta_5Descripcion":
                    return "Catalogo_Respuesta.Descripcion";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_Encuesta.Descripcion";

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
            if (columnName == "Fecha_Enviado")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_Respuesta")
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

