using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Colonia;

namespace Spartane.Web.SqlModelMapper
{
    public class ColoniaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Colonia.Clave";
                case "Nombre":
                    return "Colonia.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Codigo_Postal":
                    return "Colonia.Codigo_Postal";
                case "Zona":
                    return "Colonia.Zona";
                case "Vigente[Abreviacion]":
                case "VigenteAbreviacion":
                    return "Vigencia.Abreviacion";
                case "Observaciones":
                    return "Colonia.Observaciones";
                case "cod_pais":
                    return "Colonia.cod_pais";
                case "cod_edo":
                    return "Colonia.cod_edo";
                case "loc_justicia":
                    return "Colonia.loc_justicia";
                case "pob_justicia":
                    return "Colonia.pob_justicia";
                case "sector":
                    return "Colonia.sector";
                case "estatus":
                    return "Colonia.estatus";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Colonia).GetProperty(columnName));
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

