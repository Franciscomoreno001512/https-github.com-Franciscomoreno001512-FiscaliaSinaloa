using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Asignacion_de_Citas;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Asignacion_de_CitasPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Asignacion_de_Citas.Clave";
                case "Numero_de_Empleado[Numero_de_Empleado]":
                case "Numero_de_EmpleadoNumero_de_Empleado":
                    return "Usuario.Numero_de_Empleado";
                case "Nombre_de_Empleado":
                    return "Detalle_de_Asignacion_de_Citas.Nombre_de_Empleado";
                case "Lunes":
                    return "Detalle_de_Asignacion_de_Citas.Lunes";
                case "Martes":
                    return "Detalle_de_Asignacion_de_Citas.Martes";
                case "Miercoles":
                    return "Detalle_de_Asignacion_de_Citas.Miercoles";
                case "Jueves":
                    return "Detalle_de_Asignacion_de_Citas.Jueves";
                case "Viernes":
                    return "Detalle_de_Asignacion_de_Citas.Viernes";
                case "Sabado":
                    return "Detalle_de_Asignacion_de_Citas.Sabado";
                case "Domingo":
                    return "Detalle_de_Asignacion_de_Citas.Domingo";
                case "Hora_Inicio":
                    return "Detalle_de_Asignacion_de_Citas.Hora_Inicio";
                case "Hora_Fin":
                    return "Detalle_de_Asignacion_de_Citas.Hora_Fin";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Asignacion_de_Citas).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Lunes")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Martes")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Miercoles")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Jueves")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Viernes")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Sabado")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Domingo")
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

