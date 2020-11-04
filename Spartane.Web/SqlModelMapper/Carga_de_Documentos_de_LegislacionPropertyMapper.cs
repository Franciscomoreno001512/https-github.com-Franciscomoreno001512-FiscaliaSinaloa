using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Carga_de_Documentos_de_LegislacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Carga_de_Documentos_de_Legislacion.Folio";
                case "Nombre":
                    return "Carga_de_Documentos_de_Legislacion.Nombre";
                case "Descripcion":
                    return "Carga_de_Documentos_de_Legislacion.Descripcion";
                case "Adjuntar_Documento":
                    return "Carga_de_Documentos_de_Legislacion.Adjuntar_Documento";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_de_Documento.Descripcion";
                case "Estatus_de_Actualizacion[Descripcion]":
                case "Estatus_de_ActualizacionDescripcion":
                    return "Estatus_de_Actualizacion_de_Documento.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Carga_de_Documentos_de_Legislacion).GetProperty(columnName));
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

