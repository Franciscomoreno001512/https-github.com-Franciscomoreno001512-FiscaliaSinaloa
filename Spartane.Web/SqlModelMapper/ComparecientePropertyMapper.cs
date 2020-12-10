using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Compareciente;

namespace Spartane.Web.SqlModelMapper
{
    public class ComparecientePropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Compareciente.Clave";
                case "Nombre_Completo":
                    return "Compareciente.Nombre_Completo";
                case "Registro_de_Atencion_Inicial":
                    return "Compareciente.Registro_de_Atencion_Inicial";
                case "AVPR_NAVPR":
                    return "Compareciente.AVPR_NAVPR";
                case "AVPR_APBIS":
                    return "Compareciente.AVPR_APBIS";
                case "AVPR_CVEMU":
                    return "Compareciente.AVPR_CVEMU";
                case "AVPR_CVEAG":
                    return "Compareciente.AVPR_CVEAG";
                case "OFEN_CONOF":
                    return "Compareciente.OFEN_CONOF";
                case "OFEN_OPATE":
                    return "Compareciente.OFEN_OPATE";
                case "OFEN_OMATE":
                    return "Compareciente.OFEN_OMATE";
                case "OFEN_ONOMB":
                    return "Compareciente.OFEN_ONOMB";
                case "OFEN_INSTI":
                    return "Compareciente.OFEN_INSTI";
                case "OFEN_ESTAD":
                    return "Compareciente.OFEN_ESTAD";
                case "OFEN_EDAD":
                    return "Compareciente.OFEN_EDAD";
                case "OFEN_OCUPA":
                    return "Compareciente.OFEN_OCUPA";
                case "FECHAREGIS":
                    return "Compareciente.FECHAREGIS";
                case "USUARIO":
                    return "Compareciente.USUARIO";
                case "HORAREGIST":
                    return "Compareciente.HORAREGIST";
                case "fuente":
                    return "Compareciente.fuente";
                case "fecenvio":
                    return "Compareciente.fecenvio";
                case "OFEN_PROBABLE":
                    return "Compareciente.OFEN_PROBABLE";
                case "OFEN_RSOMENOR":
                    return "Compareciente.OFEN_RSOMENOR";
                case "REPR_Sexo":
                    return "Compareciente.REPR_Sexo";
                case "REPR_NACIONALIDAD":
                    return "Compareciente.REPR_NACIONALIDAD";
                case "REPR_ESCOLARIDAD":
                    return "Compareciente.REPR_ESCOLARIDAD";
                case "TIPO_EDAD":
                    return "Compareciente.TIPO_EDAD";
                case "IdEstadoInstitucion":
                    return "Compareciente.IdEstadoInstitucion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Compareciente).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "FECHAREGIS")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "fecenvio")
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

