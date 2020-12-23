using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Usuario;

namespace Spartane.Web.SqlModelMapper
{
    public class Registro_de_UsuarioPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Registro_de_Usuario.Clave";
                case "Nombres":
                    return "Registro_de_Usuario.Nombres";
                case "Apellido_Paterno":
                    return "Registro_de_Usuario.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Registro_de_Usuario.Apellido_Materno";
                case "Nombre_Completo":
                    return "Registro_de_Usuario.Nombre_Completo";
                case "Usuario":
                    return "Registro_de_Usuario.Usuario";
                case "Contrasena":
                    return "Registro_de_Usuario.Contrasena";
                case "Confirmar_Contrasena":
                    return "Registro_de_Usuario.Confirmar_Contrasena";
                case "Correo":
                    return "Registro_de_Usuario.Correo";
                case "Celular":
                    return "Registro_de_Usuario.Celular";
                case "Codigo_Verificacion_Correo":
                    return "Registro_de_Usuario.Codigo_Verificacion_Correo";
                case "Codigo_Verificacion_Celular":
                    return "Registro_de_Usuario.Codigo_Verificacion_Celular";
                case "Codigo_Reestablecer_Contrasena":
                    return "Registro_de_Usuario.Codigo_Reestablecer_Contrasena";
                case "El_correo_fue_Validado":
                    return "Registro_de_Usuario.El_correo_fue_Validado";
                case "El_Celular_fue_Validado":
                    return "Registro_de_Usuario.El_Celular_fue_Validado";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Registro_de_Usuario).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "El_correo_fue_Validado")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "El_Celular_fue_Validado")
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

