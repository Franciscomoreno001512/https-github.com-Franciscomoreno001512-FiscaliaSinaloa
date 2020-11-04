using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Desestimacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_DesestimacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Desestimacion.Clave";
                case "Modulo_Atencion_Inicial[NUAT]":
                case "Modulo_Atencion_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Nombre_Completo[Nombre_Completo]":
                case "Nombre_CompletoNombre_Completo":
                    return "Detalle_de_Datos_Generales.Nombre_Completo";
                case "Causal_de_Interrupcion[Descripcion]":
                case "Causal_de_InterrupcionDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Causa_de_Interrupcion[Descripcion]":
                case "Causa_de_InterrupcionDescripcion":
                    return "Causas_de_Interrupcion.Descripcion";
                case "Datos_Insuficientes[Descripcion]":
                case "Datos_InsuficientesDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Actualizacion_de_Sobreseimiento":
                    return "Detalle_de_Desestimacion.Actualizacion_de_Sobreseimiento";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Desestimacion).GetProperty(columnName));
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

