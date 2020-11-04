using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Diligencias_MASC;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Diligencias_MASCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Diligencias_MASC.Clave";
                case "Solicitud[Numero_de_Folio]":
                case "SolicitudNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Fecha":
                    return "Detalle_Diligencias_MASC.Fecha";
                case "Hora":
                    return "Detalle_Diligencias_MASC.Hora";
                case "Facilitador[Name]":
                case "FacilitadorName":
                    return "Spartan_User.Name";
                case "Tipo_de_Diligencia[Descripcion]":
                case "Tipo_de_DiligenciaDescripcion":
                    return "Tipo_de_Diligencia_MASC.Descripcion";
                case "Diligencia[Descripcion]":
                case "DiligenciaDescripcion":
                    return "Dilgencia_MASC.Descripcion";
                case "Observaciones":
                    return "Detalle_Diligencias_MASC.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Diligencias_MASC).GetProperty(columnName));
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

