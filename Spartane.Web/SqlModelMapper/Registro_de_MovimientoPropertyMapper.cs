using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Movimiento;

namespace Spartane.Web.SqlModelMapper
{
    public class Registro_de_MovimientoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Registro_de_Movimiento.Clave";
                case "Judicializacion[causa_o_cuadernillo]":
                case "Judicializacioncausa_o_cuadernillo":
                    return "Judicializacion.causa_o_cuadernillo";
                case "Fase[Descripcion]":
                case "FaseDescripcion":
                    return "Fase_de_Judicializacion.Descripcion";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Movimiento_Realizado[Descripcion]":
                case "Movimiento_RealizadoDescripcion":
                    return "Configurador_de_Movimientos.Descripcion";
                case "Fecha_de_Movimiento":
                    return "Registro_de_Movimiento.Fecha_de_Movimiento";
                case "Hora_de_Movimiento":
                    return "Registro_de_Movimiento.Hora_de_Movimiento";
                case "Informacion":
                    return "Registro_de_Movimiento.Informacion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Registro_de_Movimiento).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Movimiento")
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

