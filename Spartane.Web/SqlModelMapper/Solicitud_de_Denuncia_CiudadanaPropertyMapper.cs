using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;

namespace Spartane.Web.SqlModelMapper
{
    public class Solicitud_de_Denuncia_CiudadanaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Solicitud_de_Denuncia_Ciudadana.Clave";
                case "Folio":
                    return "Solicitud_de_Denuncia_Ciudadana.Folio";
                case "Contrasena":
                    return "Solicitud_de_Denuncia_Ciudadana.Contrasena";
                case "Fecha_de_Registro":
                    return "Solicitud_de_Denuncia_Ciudadana.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Solicitud_de_Denuncia_Ciudadana.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Tipo_de_Solicitud[Descripcion]":
                case "Tipo_de_SolicitudDescripcion":
                    return "Tipo_de_Solicitud.Descripcion";
                case "Estatus_de_Solicitud[Descripcion]":
                case "Estatus_de_SolicitudDescripcion":
                    return "Estatus_de_Solicitud.Descripcion";
                case "Motivo":
                    return "Solicitud_de_Denuncia_Ciudadana.Motivo";
                case "Canalizar_a[Descripcion]":
                case "Canalizar_aDescripcion":
                    return "PC_CanalizarA.Descripcion";
                case "Fecha_de_Revision":
                    return "Solicitud_de_Denuncia_Ciudadana.Fecha_de_Revision";
                case "Hora_de_Revision":
                    return "Solicitud_de_Denuncia_Ciudadana.Hora_de_Revision";
                case "Usuario_que_Revisa[Name]":
                case "Usuario_que_RevisaName":
                    return "Spartan_User.Name";
                case "Tipo_de_Resolucion[Descripcion]":
                case "Tipo_de_ResolucionDescripcion":
                    return "Tipo_Resolucion_Portal_Ciudadano.Descripcion";
                case "Region[Descripcion]":
                case "RegionDescripcion":
                    return "Region.Descripcion";
                case "Unidad_canaliza[Descripcion]":
                case "Unidad_canalizaDescripcion":
                    return "Unidad.Descripcion";
                case "Contestacion":
                    return "Solicitud_de_Denuncia_Ciudadana.Contestacion";
                case "Observaciones_resolucion":
                    return "Solicitud_de_Denuncia_Ciudadana.Observaciones_resolucion";
                case "Fecha_de_Asignacion":
                    return "Solicitud_de_Denuncia_Ciudadana.Fecha_de_Asignacion";
                case "Hora_de_Asignacion":
                    return "Solicitud_de_Denuncia_Ciudadana.Hora_de_Asignacion";
                case "Usuario_que_Asigna[Name]":
                case "Usuario_que_AsignaName":
                    return "Spartan_User.Name";
                case "Responsable_Asignado[Name]":
                case "Responsable_AsignadoName":
                    return "Spartan_User.Name";
                case "Observaciones_responsable":
                    return "Solicitud_de_Denuncia_Ciudadana.Observaciones_responsable";
                case "Fecha_de_Atencion":
                    return "Solicitud_de_Denuncia_Ciudadana.Fecha_de_Atencion";
                case "Hora_de_Atencion":
                    return "Solicitud_de_Denuncia_Ciudadana.Hora_de_Atencion";
                case "Usuario_que_Atiende[Name]":
                case "Usuario_que_AtiendeName":
                    return "Spartan_User.Name";
                case "Atencion_Realizada[Descripcion]":
                case "Atencion_RealizadaDescripcion":
                    return "Contestacion_de_Portal_Ciudadano.Descripcion";
                case "Observaciones_atencion":
                    return "Solicitud_de_Denuncia_Ciudadana.Observaciones_atencion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Solicitud_de_Denuncia_Ciudadana).GetProperty(columnName));
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
            if (columnName == "Fecha_de_Revision")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Asignacion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Atencion")
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

