using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_Datos_de_Apoyo;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Solicitud_Datos_de_ApoyoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Solicitud_Datos_de_Apoyo.Clave";
                case "Solicitud[Numero_de_Folio]":
                case "SolicitudNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Fecha_de_Registro":
                    return "Detalle_de_Solicitud_Datos_de_Apoyo.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Detalle_de_Solicitud_Datos_de_Apoyo.Hora_de_Registro";
                case "Usuario_que_registra[Name]":
                case "Usuario_que_registraName":
                    return "Spartan_User.Name";
                case "Tipo_de_Servicio[Servicio]":
                case "Tipo_de_ServicioServicio":
                    return "Tipo_de_Servicio_de_Apoyo.Servicio";
                case "Dictamen":
                    return "Detalle_de_Solicitud_Datos_de_Apoyo.Dictamen";
                case "Solicitante[Nombre_Completo]":
                case "SolicitanteNombre_Completo":
                    return "Detalle_de_Solicitud_Solicitante.Nombre_Completo";
                case "Responsable":
                    return "Detalle_de_Solicitud_Datos_de_Apoyo.Responsable";
                case "Idioma[Descripcion]":
                case "IdiomaDescripcion":
                    return "Idioma.Descripcion";
                case "Lengua_Originaria[Descripcion]":
                case "Lengua_OriginariaDescripcion":
                    return "Dialecto.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Solicitud_Datos_de_Apoyo).GetProperty(columnName));
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

