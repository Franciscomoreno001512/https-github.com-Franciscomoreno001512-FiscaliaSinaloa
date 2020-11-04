using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Control_de_Citas;

namespace Spartane.Web.SqlModelMapper
{
    public class Control_de_CitasPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Control_de_Citas.Folio";
                case "Fecha_de_Registro":
                    return "Control_de_Citas.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Control_de_Citas.Hora_de_Registro";
                case "Usuario_que_Atiende[Name]":
                case "Usuario_que_AtiendeName":
                    return "Spartan_User.Name";
                case "Fecha_de_la_Cita":
                    return "Control_de_Citas.Fecha_de_la_Cita";
                case "Hora_de_la_Cita":
                    return "Control_de_Citas.Hora_de_la_Cita";
                case "Proceso[Descripcion]":
                case "ProcesoDescripcion":
                    return "Origen_de_Invitacion.Descripcion";
                case "Numero_de_Expediente":
                    return "Control_de_Citas.Numero_de_Expediente";
                case "Tipo_de_Cita":
                    return "Control_de_Citas.Tipo_de_Cita";
                case "Cita":
                    return "Control_de_Citas.Cita";
                case "Cumplida":
                    return "Control_de_Citas.Cumplida";
                case "Observaciones":
                    return "Control_de_Citas.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Control_de_Citas).GetProperty(columnName));
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
            if (columnName == "Fecha_de_la_Cita")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Cumplida")
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

