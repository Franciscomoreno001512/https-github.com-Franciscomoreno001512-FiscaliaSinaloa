using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Bitacora_de_Sincronizacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Bitacora_de_SincronizacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Bitacora_de_Sincronizacion.Clave";
                case "ID_Dispositivo":
                    return "Bitacora_de_Sincronizacion.ID_Dispositivo";
                case "Usuario[Name]":
                case "UsuarioName":
                    return "Spartan_User.Name";
                case "Nombre_de_la_Tabla":
                    return "Bitacora_de_Sincronizacion.Nombre_de_la_Tabla";
                case "Estatus_de_Replicacion[Descripcion]":
                case "Estatus_de_ReplicacionDescripcion":
                    return "Catalogo_Estatus_de_Replicacion.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Bitacora_de_Sincronizacion).GetProperty(columnName));
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

