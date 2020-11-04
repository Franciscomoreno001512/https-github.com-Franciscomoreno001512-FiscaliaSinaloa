using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Errores_de_Replicacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Errores_de_ReplicacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Errores_de_Replicacion.Clave";
                case "ID_del_Dispositivo":
                    return "Errores_de_Replicacion.ID_del_Dispositivo";
                case "Usuario[Name]":
                case "UsuarioName":
                    return "Spartan_User.Name";
                case "Fecha_del_Error":
                    return "Errores_de_Replicacion.Fecha_del_Error";
                case "Hora_del_Error":
                    return "Errores_de_Replicacion.Hora_del_Error";
                case "Campo_con_Error":
                    return "Errores_de_Replicacion.Campo_con_Error";
                case "Valor_del_Campo_en_Dispositivo":
                    return "Errores_de_Replicacion.Valor_del_Campo_en_Dispositivo";
                case "Valor_del_Campo_en_Web":
                    return "Errores_de_Replicacion.Valor_del_Campo_en_Web";
                case "Folio":
                    return "Errores_de_Replicacion.Folio";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Errores_de_Replicacion).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_del_Error")
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

