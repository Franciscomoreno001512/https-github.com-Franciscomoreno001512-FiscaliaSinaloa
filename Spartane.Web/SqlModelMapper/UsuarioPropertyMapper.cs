using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Usuario;

namespace Spartane.Web.SqlModelMapper
{
    public class UsuarioPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Usuario.Clave";
                case "Nombre[Name]":
                case "NombreName":
                    return "Spartan_User.Name";
                case "Clave_de_Acceso":
                    return "Usuario.Clave_de_Acceso";
                case "Grupo_de_Usuario":
                    return "Usuario.Grupo_de_Usuario";
                case "Numero_de_Empleado":
                    return "Usuario.Numero_de_Empleado";
                case "Correo_Institucional":
                    return "Usuario.Correo_Institucional";
                case "CUIP":
                    return "Usuario.CUIP";
                case "Delegacion[Descripcion]":
                case "DelegacionDescripcion":
                    return "Delegacion.Descripcion";
                case "Carga_de_Trabajo":
                    return "Usuario.Carga_de_Trabajo";
                case "Nombre_Remitente":
                    return "Usuario.Nombre_Remitente";
                case "Apellido_Paterno":
                    return "Usuario.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Usuario.Apellido_Materno";
                case "Agencia[Descripcion]":
                case "AgenciaDescripcion":
                    return "Agencia.Descripcion";
                case "Especialidad[Descripcion]":
                case "EspecialidadDescripcion":
                    return "Especialidad_MP.Descripcion";
                case "ID_de_Dispositivo":
                    return "Usuario.ID_de_Dispositivo";
                case "ID_de_Huella":
                    return "Usuario.ID_de_Huella";
                case "Fotografia":
                    return "Usuario.Fotografia";
                case "Usuario_que_Registra":
                    return "Usuario.Usuario_que_Registra";
                case "Fecha_de_Registro":
                    return "Usuario.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Usuario.Hora_de_Registro";
                case "Estatus_de_Registro":
                    return "Usuario.Estatus_de_Registro";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Usuario).GetProperty(columnName));
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

