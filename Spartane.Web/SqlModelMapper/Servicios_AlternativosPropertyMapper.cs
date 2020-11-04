using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Servicios_Alternativos;

namespace Spartane.Web.SqlModelMapper
{
    public class Servicios_AlternativosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Servicios_Alternativos.Clave";
                case "CJusticia_Alternativa":
                    return "Servicios_Alternativos.CJusticia_Alternativa";
                case "Medios_Alternativos[Descripcion]":
                case "Medios_AlternativosDescripcion":
                    return "Medios_Alternativos.Descripcion";
                case "Motivo":
                    return "Servicios_Alternativos.Motivo";
                case "Derechos":
                    return "Servicios_Alternativos.Derechos";
                case "Procedimiento":
                    return "Servicios_Alternativos.Procedimiento";
                case "Solicita_Medios_Alternativos":
                    return "Servicios_Alternativos.Solicita_Medios_Alternativos";
                case "Se_Canaliza[Descripcion]":
                case "Se_CanalizaDescripcion":
                    return "Tipo_de_Instancia.Descripcion";
                case "Investigacion_con_Detenido":
                    return "Servicios_Alternativos.Investigacion_con_Detenido";
                case "Investigacion_sin_Detenido":
                    return "Servicios_Alternativos.Investigacion_sin_Detenido";
                case "Turnar_a_Justicia_Alternativa":
                    return "Servicios_Alternativos.Turnar_a_Justicia_Alternativa";
                case "Instancia_Externa":
                    return "Servicios_Alternativos.Instancia_Externa";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Servicios_Alternativos).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "CJusticia_Alternativa")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Derechos")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Procedimiento")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Solicita_Medios_Alternativos")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Investigacion_con_Detenido")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Investigacion_sin_Detenido")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Turnar_a_Justicia_Alternativa")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Instancia_Externa")
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

