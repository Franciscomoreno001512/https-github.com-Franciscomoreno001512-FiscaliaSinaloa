using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Servicio_de_ApoyoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Servicio_de_Apoyo.Clave";
                case "Modulo_de_Atencion_Inicial[NUAT]":
                case "Modulo_de_Atencion_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Tipo_de_Servicio[Servicio]":
                case "Tipo_de_ServicioServicio":
                    return "Tipo_de_Servicio_de_Apoyo.Servicio";
                case "Requiere_Traductor":
                    return "Detalle_de_Servicio_de_Apoyo.Requiere_Traductor";
                case "Lengua_Originaria[Descripcion]":
                case "Lengua_OriginariaDescripcion":
                    return "Dialecto.Descripcion";
                case "Idioma[Descripcion]":
                case "IdiomaDescripcion":
                    return "Idioma.Descripcion";
                case "Dictamen":
                    return "Detalle_de_Servicio_de_Apoyo.Dictamen";
                case "Responsable":
                    return "Detalle_de_Servicio_de_Apoyo.Responsable";
                case "Compareciente[Nombre_Completo]":
                case "ComparecienteNombre_Completo":
                    return "Compareciente.Nombre_Completo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Servicio_de_Apoyo).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Requiere_Traductor")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
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

