using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Resolucion;

namespace Spartane.Web.SqlModelMapper
{
    public class ResolucionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Resolucion.Clave";
                case "Descripcion":
                    return "Resolucion.Descripcion";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_Resolucion.Descripcion";
                case "Resolucion_Padre_para_Autorizacion[Descripcion]":
                case "Resolucion_Padre_para_AutorizacionDescripcion":
                    return "Resolucion.Descripcion";
                case "Generar_Judicializacion":
                    return "Resolucion.Generar_Judicializacion";
                case "ClaveFiscalia":
                    return "Resolucion.ClaveFiscalia";
                case "Resolucion_AT":
                    return "Resolucion.Resolucion_AT";
                case "Resolucion_MP":
                    return "Resolucion.Resolucion_MP";
                case "Aplica_para_Adolescentes":
                    return "Resolucion.Aplica_para_Adolescentes";
                case "Aplica_para_Denuncia":
                    return "Resolucion.Aplica_para_Denuncia";
                case "Aplica_para_Carpeta_de_Investigacion":
                    return "Resolucion.Aplica_para_Carpeta_de_Investigacion";
                case "Abreviacion":
                    return "Resolucion.Abreviacion";
                case "Vigencia":
                    return "Resolucion.Vigencia";
                case "MostrarDependencia":
                    return "Resolucion.MostrarDependencia";
                case "Conteo":
                    return "Resolucion.Conteo";
                case "Estatus":
                    return "Resolucion.Estatus";
                case "Estatus_esp":
                    return "Resolucion.Estatus_esp";
                case "Mostrar_Estadistico":
                    return "Resolucion.Mostrar_Estadistico";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Resolucion).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Generar_Judicializacion")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Resolucion_AT")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Resolucion_MP")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Aplica_para_Adolescentes")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Aplica_para_Denuncia")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Aplica_para_Carpeta_de_Investigacion")
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

