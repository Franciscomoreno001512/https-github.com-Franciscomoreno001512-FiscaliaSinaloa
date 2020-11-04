using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Historial_Control_de_Documentos;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Historial_Control_de_DocumentosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Detalle_Historial_Control_de_Documentos.Folio";
                case "Fecha":
                    return "Detalle_Historial_Control_de_Documentos.Fecha";
                case "Hora":
                    return "Detalle_Historial_Control_de_Documentos.Hora";
                case "Usuario[Name]":
                case "UsuarioName":
                    return "Spartan_User.Name";
                case "Modificaciones_Realizadas":
                    return "Detalle_Historial_Control_de_Documentos.Modificaciones_Realizadas";
                case "Cuerpo_del_Documento":
                    return "Detalle_Historial_Control_de_Documentos.Cuerpo_del_Documento";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Historial_Control_de_Documentos).GetProperty(columnName));
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

