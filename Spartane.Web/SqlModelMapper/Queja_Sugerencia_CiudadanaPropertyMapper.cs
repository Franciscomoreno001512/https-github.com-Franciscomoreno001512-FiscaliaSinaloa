using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Queja_Sugerencia_Ciudadana;

namespace Spartane.Web.SqlModelMapper
{
    public class Queja_Sugerencia_CiudadanaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Queja_Sugerencia_Ciudadana.Folio";
                case "Fecha_de_Registro":
                    return "Queja_Sugerencia_Ciudadana.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Queja_Sugerencia_Ciudadana.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Tipo_de_Registro[Descripcion]":
                case "Tipo_de_RegistroDescripcion":
                    return "Tipo_de_queja_sugerencia.Descripcion";
                case "Queja":
                    return "Queja_Sugerencia_Ciudadana.Queja";
                case "Sugerencia":
                    return "Queja_Sugerencia_Ciudadana.Sugerencia";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_queja_sugerencia.Descripcion";
                case "Motivo_de_Eliminacion":
                    return "Queja_Sugerencia_Ciudadana.Motivo_de_Eliminacion";
                case "Contestacion":
                    return "Queja_Sugerencia_Ciudadana.Contestacion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Queja_Sugerencia_Ciudadana).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Registro")
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

