using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Asignacion_de_Agente;

namespace Spartane.Web.SqlModelMapper
{
    public class Asignacion_de_AgentePropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Asignacion_de_Agente.Clave";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Fecha_de_Asignacion":
                    return "Asignacion_de_Agente.Fecha_de_Asignacion";
                case "Hora_de_Asignacion":
                    return "Asignacion_de_Agente.Hora_de_Asignacion";
                case "Usuario_que_Asigna[Name]":
                case "Usuario_que_AsignaName":
                    return "Spartan_User.Name";
                case "Agente_Asignado[Name]":
                case "Agente_AsignadoName":
                    return "Spartan_User.Name";
                case "Observaciones":
                    return "Asignacion_de_Agente.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Asignacion_de_Agente).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Asignacion")
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

