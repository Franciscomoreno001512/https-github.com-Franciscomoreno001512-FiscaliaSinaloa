using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;

namespace Spartane.Web.SqlModelMapper
{
    public class SolicitudPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Solicitud.Clave";
                case "Fecha_de_Registro":
                    return "Solicitud.Fecha_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Numero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Unidad_MASC[Descripcion]":
                case "Unidad_MASCDescripcion":
                    return "Unidad.Descripcion";
                case "Remitente":
                    return "Solicitud.Remitente";
                case "NUAT[NUAT]":
                case "NUATNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Unidad[Descripcion]":
                case "UnidadDescripcion":
                    return "Unidad.Descripcion";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Region[Descripcion]":
                case "RegionDescripcion":
                    return "Region.Descripcion";
                case "NUC":
                    return "Solicitud.NUC";
                case "CDI":
                    return "Solicitud.CDI";
                case "Numero_de_Expediente":
                    return "Solicitud.Numero_de_Expediente";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_Solicitud.Descripcion";
                case "Fecha_en_que_llega_a_Coordinador":
                    return "Solicitud.Fecha_en_que_llega_a_Coordinador";
                case "Fecha_en_que_llega_a_Especialista":
                    return "Solicitud.Fecha_en_que_llega_a_Especialista";
                case "Agente_del_Ministerio_Publico_Orientador[Name]":
                case "Agente_del_Ministerio_Publico_OrientadorName":
                    return "Spartan_User.Name";
                case "Agente_del_Ministerio_Publico_Invest[Name]":
                case "Agente_del_Ministerio_Publico_InvestName":
                    return "Spartan_User.Name";
                case "Juez_de_Control[Name]":
                case "Juez_de_ControlName":
                    return "Spartan_User.Name";
                case "Titulo_del_Hecho":
                    return "Solicitud.Titulo_del_Hecho";
                case "Fecha_del_Hecho":
                    return "Solicitud.Fecha_del_Hecho";
                case "Narrativa_Breve_de_los_Hechos":
                    return "Solicitud.Narrativa_Breve_de_los_Hechos";
                case "Hora_Aproximada_del_Hecho":
                    return "Solicitud.Hora_Aproximada_del_Hecho";
                case "Tipo_de_Lugar_del_Hecho[Descripcion]":
                case "Tipo_de_Lugar_del_HechoDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "PaisH[Nombre]":
                case "PaisHNombre":
                    return "Pais.Nombre";
                case "EstadoH[Nombre]":
                case "EstadoHNombre":
                    return "Estado.Nombre";
                case "MunicipioH[Nombre]":
                case "MunicipioHNombre":
                    return "Municipio.Nombre";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "ColoniaH[Nombre]":
                case "ColoniaHNombre":
                    return "Colonia.Nombre";
                case "CalleH":
                    return "Solicitud.CalleH";
                case "Numero_ExteriorH":
                    return "Solicitud.Numero_ExteriorH";
                case "Numero_InteriorH":
                    return "Solicitud.Numero_InteriorH";
                case "Codigo_PostalH":
                    return "Solicitud.Codigo_PostalH";
                case "Entre_Calle":
                    return "Solicitud.Entre_Calle";
                case "y_Calle":
                    return "Solicitud.y_Calle";
                case "LongitudH":
                    return "Solicitud.LongitudH";
                case "LatitudH":
                    return "Solicitud.LatitudH";
                case "Especialista_AsignadoA[Name]":
                case "Especialista_AsignadoAName":
                    return "Spartan_User.Name";
                case "Asignar_Especialista_Automatico":
                    return "Solicitud.Asignar_Especialista_Automatico";
                case "Razone":
                    return "Solicitud.Razone";
                case "Tipo_de_Mecanismo[Descripcion]":
                case "Tipo_de_MecanismoDescripcion":
                    return "Tipo_de_Mecanismo_Alterno.Descripcion";
                case "Fecha_de_AsignacionA":
                    return "Solicitud.Fecha_de_AsignacionA";
                case "Hora_de_AsignacionA":
                    return "Solicitud.Hora_de_AsignacionA";
                case "Fecha_de_Atencion_del_Especialista":
                    return "Solicitud.Fecha_de_Atencion_del_Especialista";
                case "Hora_de_Atencion_del_Especialista":
                    return "Solicitud.Hora_de_Atencion_del_Especialista";
                case "Rechazar":
                    return "Solicitud.Rechazar";
                case "Acuerdo_Cumplido[Descripcion]":
                case "Acuerdo_CumplidoDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Razon_de_Incumplimiento[Descripcion]":
                case "Razon_de_IncumplimientoDescripcion":
                    return "Razon_de_Incumplimiento.Descripcion";
                case "Tipo_de_Conclusion_Anticipada[Descripcion]":
                case "Tipo_de_Conclusion_AnticipadaDescripcion":
                    return "Tipo_de_Conclusion_Anticipada.Descripcion";
                case "Fecha_de_Cierre":
                    return "Solicitud.Fecha_de_Cierre";
                case "Hora_de_Cierre":
                    return "Solicitud.Hora_de_Cierre";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Solicitud).GetProperty(columnName));
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
            if (columnName == "Fecha_en_que_llega_a_Coordinador")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_en_que_llega_a_Especialista")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_del_Hecho")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Asignar_Especialista_Automatico")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_AsignacionA")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Atencion_del_Especialista")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Rechazar")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Cierre")
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

