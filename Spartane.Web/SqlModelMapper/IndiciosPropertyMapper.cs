using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Indicios;

namespace Spartane.Web.SqlModelMapper
{
    public class IndiciosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Indicios.Clave";
                case "Fecha_de_Registro":
                    return "Indicios.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Indicios.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "NUC[NUC]":
                case "NUCNUC":
                    return "Expediente_Inicial.NUC";
                case "NIC":
                    return "Indicios.NIC";
                case "Delegacion[Descripcion]":
                case "DelegacionDescripcion":
                    return "Delegacion.Descripcion";
                case "Agencia[Descripcion]":
                case "AgenciaDescripcion":
                    return "Agencia.Descripcion";
                case "Clave_Indicio":
                    return "Indicios.Clave_Indicio";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Indicios).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Registro")
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

