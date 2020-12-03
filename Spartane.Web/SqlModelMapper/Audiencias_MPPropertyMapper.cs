using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Audiencias_MP;

namespace Spartane.Web.SqlModelMapper
{
    public class Audiencias_MPPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Audiencias_MP.Clave";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Tipo_de_Audiencia[Descripcion]":
                case "Tipo_de_AudienciaDescripcion":
                    return "Tipo_de_Audiencia.Descripcion";
                case "Audiencia[Descripcion]":
                case "AudienciaDescripcion":
                    return "Audiencia.Descripcion";
                case "Fecha":
                    return "Audiencias_MP.Fecha";
                case "Hora":
                    return "Audiencias_MP.Hora";
                case "Observaciones":
                    return "Audiencias_MP.Observaciones";
                case "Resultado_de_Audiencia[Descripcion]":
                case "Resultado_de_AudienciaDescripcion":
                    return "Resultado_de_Audiencia.Descripcion";
                case "Asignar_MP_Litigacion":
                    return "Audiencias_MP.Asignar_MP_Litigacion";
                case "MP_Litigacion[Name]":
                case "MP_LitigacionName":
                    return "Spartan_User.Name";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Audiencias_MP).GetProperty(columnName));
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
            if (columnName == "Asignar_MP_Litigacion")
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

