using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Bitacora_de_Usuarios;

namespace Spartane.Web.SqlModelMapper
{
    public class Bitacora_de_UsuariosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Bitacora_de_Usuarios.Clave";
                case "Numero_de_Empleado":
                    return "Bitacora_de_Usuarios.Numero_de_Empleado";
                case "Usuario":
                    return "Bitacora_de_Usuarios.Usuario";
                case "ID_de_Huella":
                    return "Bitacora_de_Usuarios.ID_de_Huella";
                case "ID_de_Dispositivo":
                    return "Bitacora_de_Usuarios.ID_de_Dispositivo";
                case "Fecha":
                    return "Bitacora_de_Usuarios.Fecha";
                case "Hora":
                    return "Bitacora_de_Usuarios.Hora";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Bitacora_de_Usuarios).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha")
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

