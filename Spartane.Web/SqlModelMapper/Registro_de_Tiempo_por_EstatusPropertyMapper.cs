using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus;

namespace Spartane.Web.SqlModelMapper
{
    public class Registro_de_Tiempo_por_EstatusPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Registro_de_Tiempo_por_Estatus.Clave";
                case "Fecha":
                    return "Registro_de_Tiempo_por_Estatus.Fecha";
                case "Hora":
                    return "Registro_de_Tiempo_por_Estatus.Hora";
                case "NUAT[NUAT]":
                case "NUATNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Estatus_Interno[Descripcion]":
                case "Estatus_InternoDescripcion":
                    return "Estatus.Descripcion";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_Orientador.Descripcion";
                case "Estatus_Destino":
                    return "Registro_de_Tiempo_por_Estatus.Estatus_Destino";
                case "Tiempo_Transcurrido":
                    return "Registro_de_Tiempo_por_Estatus.Tiempo_Transcurrido";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Registro_de_Tiempo_por_Estatus).GetProperty(columnName));
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

