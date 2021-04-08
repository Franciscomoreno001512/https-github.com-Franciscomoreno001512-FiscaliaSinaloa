using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud_de_Apoyo_Externa;

namespace Spartane.Web.SqlModelMapper
{
    public class Solicitud_de_Apoyo_ExternaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Solicitud_de_Apoyo_Externa.Folio";
                case "Fecha_de_Registro":
                    return "Solicitud_de_Apoyo_Externa.Fecha_de_Registro";
                case "Hora_de_registro":
                    return "Solicitud_de_Apoyo_Externa.Hora_de_registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Region[Descripcion]":
                case "RegionDescripcion":
                    return "Region.Descripcion";
                case "Unidad[Descripcion]":
                case "UnidadDescripcion":
                    return "Unidad.Descripcion";
                case "Anio":
                    return "Solicitud_de_Apoyo_Externa.Anio";
                case "Fecha_de_Solicitud":
                    return "Solicitud_de_Apoyo_Externa.Fecha_de_Solicitud";
                case "Numero_de_Oficio_Externo":
                    return "Solicitud_de_Apoyo_Externa.Numero_de_Oficio_Externo";
                case "Solicitante":
                    return "Solicitud_de_Apoyo_Externa.Solicitante";
                case "Rango":
                    return "Solicitud_de_Apoyo_Externa.Rango";
                case "Autoridad_Externa[Descripcion]":
                case "Autoridad_ExternaDescripcion":
                    return "Autoridad_Externa.Descripcion";
                case "Narracion_Solicitud":
                    return "Solicitud_de_Apoyo_Externa.Narracion_Solicitud";
                case "Area_Asignada[Descripcion]":
                case "Area_AsignadaDescripcion":
                    return "Area_de_Servicios_de_Apoyo.Descripcion";
                case "SubArea_Asignada[Descripcion]":
                case "SubArea_AsignadaDescripcion":
                    return "SubArea_de_Servicios_de_Apoyo.Descripcion";
                case "Dictamen_Solicitado[Descripcion]":
                case "Dictamen_SolicitadoDescripcion":
                    return "Documento.Descripcion";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_de_Apoyo_Externo.Descripcion";
                case "Fecha_de_Contestacion":
                    return "Solicitud_de_Apoyo_Externa.Fecha_de_Contestacion";
                case "Hora_de_Contestacion":
                    return "Solicitud_de_Apoyo_Externa.Hora_de_Contestacion";
                case "Responsable_que_Contesta[Name]":
                case "Responsable_que_ContestaName":
                    return "Spartan_User.Name";
                case "No__Contestacion":
                    return "Solicitud_de_Apoyo_Externa.No__Contestacion";
                case "Dictamen[Descripcion]":
                case "DictamenDescripcion":
                    return "Documento.Descripcion";
                case "Observaciones":
                    return "Solicitud_de_Apoyo_Externa.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Solicitud_de_Apoyo_Externa).GetProperty(columnName));
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
            if (columnName == "Fecha_de_Solicitud")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Contestacion")
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

