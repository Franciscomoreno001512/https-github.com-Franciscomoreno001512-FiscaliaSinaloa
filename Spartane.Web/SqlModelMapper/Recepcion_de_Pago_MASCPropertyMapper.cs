using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Recepcion_de_Pago_MASC;

namespace Spartane.Web.SqlModelMapper
{
    public class Recepcion_de_Pago_MASCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Recepcion_de_Pago_MASC.Clave";
                case "Fecha_de_Recepcion":
                    return "Recepcion_de_Pago_MASC.Fecha_de_Recepcion";
                case "Hora_de_Recepcion":
                    return "Recepcion_de_Pago_MASC.Hora_de_Recepcion";
                case "Usuario_que_Recibe[Name]":
                case "Usuario_que_RecibeName":
                    return "Spartan_User.Name";
                case "Numero_de_Expediente[Numero_de_Expediente]":
                case "Numero_de_ExpedienteNumero_de_Expediente":
                    return "Solicitud.Numero_de_Expediente";
                case "Requerido[Nombre_Completo]":
                case "RequeridoNombre_Completo":
                    return "Detalle_de_Solicitud_Requerido.Nombre_Completo";
                case "Nombre_de_la_Persona_que_entrega":
                    return "Recepcion_de_Pago_MASC.Nombre_de_la_Persona_que_entrega";
                case "Numero_de_Pago":
                    return "Recepcion_de_Pago_MASC.Numero_de_Pago";
                case "Monto_del_Pago":
                    return "Recepcion_de_Pago_MASC.Monto_del_Pago";
                case "Pago_Completo":
                    return "Recepcion_de_Pago_MASC.Pago_Completo";
                case "Motivo_para_no_entregar_pago_completo":
                    return "Recepcion_de_Pago_MASC.Motivo_para_no_entregar_pago_completo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Recepcion_de_Pago_MASC).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Recepcion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Pago_Completo")
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

