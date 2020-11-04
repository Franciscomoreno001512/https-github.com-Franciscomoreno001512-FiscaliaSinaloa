using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Sentencias_Imputado_MPI;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Sentencias_Imputado_MPIPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Sentencias_Imputado_MPI.Clave";
                case "Delito[Descripcion]":
                case "DelitoDescripcion":
                    return "Delito.Descripcion";
                case "Sentencia[Descripcion]":
                case "SentenciaDescripcion":
                    return "Sentencia.Descripcion";
                case "Fecha_de_Devolucion":
                    return "Detalle_de_Sentencias_Imputado_MPI.Fecha_de_Devolucion";
                case "Hora_de_Devolucion":
                    return "Detalle_de_Sentencias_Imputado_MPI.Hora_de_Devolucion";
                case "Repacion_del_Dano":
                    return "Detalle_de_Sentencias_Imputado_MPI.Repacion_del_Dano";
                case "Resolucion":
                    return "Detalle_de_Sentencias_Imputado_MPI.Resolucion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Sentencias_Imputado_MPI).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Devolucion")
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

