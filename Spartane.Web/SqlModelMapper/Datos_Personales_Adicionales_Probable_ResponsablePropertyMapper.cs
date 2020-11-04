using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Datos_Personales_Adicionales_Probable_Responsable;

namespace Spartane.Web.SqlModelMapper
{
    public class Datos_Personales_Adicionales_Probable_ResponsablePropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Datos_Personales_Adicionales_Probable_Responsable.Clave";
                case "Correo_Electronico":
                    return "Datos_Personales_Adicionales_Probable_Responsable.Correo_Electronico";
                case "Numero_Telefonico":
                    return "Datos_Personales_Adicionales_Probable_Responsable.Numero_Telefonico";
                case "Redes_Sociales[Descripcion]":
                case "Redes_SocialesDescripcion":
                    return "Redes_Sociales.Descripcion";
                case "Observaciones":
                    return "Datos_Personales_Adicionales_Probable_Responsable.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Datos_Personales_Adicionales_Probable_Responsable).GetProperty(columnName));
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

