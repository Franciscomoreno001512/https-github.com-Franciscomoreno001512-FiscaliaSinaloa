using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Reuniones_de_MediacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Reuniones_de_Mediacion.Clave";
                case "Numero_de_Expediente[Numero_de_Folio]":
                case "Numero_de_ExpedienteNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Fecha_de_Registro":
                    return "Detalle_de_Reuniones_de_Mediacion.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Detalle_de_Reuniones_de_Mediacion.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Lugar":
                    return "Detalle_de_Reuniones_de_Mediacion.Lugar";
                case "Fecha":
                    return "Detalle_de_Reuniones_de_Mediacion.Fecha";
                case "Hora":
                    return "Detalle_de_Reuniones_de_Mediacion.Hora";
                case "Especialista[Name]":
                case "EspecialistaName":
                    return "Spartan_User.Name";
                case "Tipo_de_Sesion[Descripcion]":
                case "Tipo_de_SesionDescripcion":
                    return "Tipo_de_Sesion.Descripcion";
                case "Cumplimiento[Descripcion]":
                case "CumplimientoDescripcion":
                    return "Cumplimiento.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Reuniones_de_Mediacion).GetProperty(columnName));
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

