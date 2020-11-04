using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Acta_de_Lectura_de_Derechos;

namespace Spartane.Web.SqlModelMapper
{
    public class Acta_de_Lectura_de_DerechosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Acta_de_Lectura_de_Derechos.Clave";
                case "NUC":
                    return "Acta_de_Lectura_de_Derechos.NUC";
                case "NIC":
                    return "Acta_de_Lectura_de_Derechos.NIC";
                case "Folio":
                    return "Acta_de_Lectura_de_Derechos.Folio";
                case "Ubicacion":
                    return "Acta_de_Lectura_de_Derechos.Ubicacion";
                case "Fecha":
                    return "Acta_de_Lectura_de_Derechos.Fecha";
                case "Hora":
                    return "Acta_de_Lectura_de_Derechos.Hora";
                case "Agente_de_la_PM":
                    return "Acta_de_Lectura_de_Derechos.Agente_de_la_PM";
                case "Plaza_de_Adscripcion":
                    return "Acta_de_Lectura_de_Derechos.Plaza_de_Adscripcion";
                case "Domicilio_de_la_Comandancia":
                    return "Acta_de_Lectura_de_Derechos.Domicilio_de_la_Comandancia";
                case "Municipio":
                    return "Acta_de_Lectura_de_Derechos.Municipio";
                case "Estado":
                    return "Acta_de_Lectura_de_Derechos.Estado";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Acta_de_Lectura_de_Derechos).GetProperty(columnName));
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

