using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;

namespace Spartane.Web.SqlModelMapper
{
    public class expediente_ministerio_publicoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "clave":
                    return "expediente_ministerio_publico.clave";
                case "fecha_de_registro":
                    return "expediente_ministerio_publico.fecha_de_registro";
                case "hora_de_registro":
                    return "expediente_ministerio_publico.hora_de_registro";
                case "usuario_que_registra[Name]":
                case "usuario_que_registraName":
                    return "Spartan_User.Name";
                case "Tipo_de_Denuncia[Descripcion]":
                case "Tipo_de_DenunciaDescripcion":
                    return "Tipo_de_Denuncia.Descripcion";
                case "unidad[Descripcion]":
                case "unidadDescripcion":
                    return "Unidad.Descripcion";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Region[Descripcion]":
                case "RegionDescripcion":
                    return "Region.Descripcion";
                case "nuat":
                    return "expediente_ministerio_publico.nuat";
                case "nic":
                    return "expediente_ministerio_publico.nic";
                case "detenido[Descripcion]":
                case "detenidoDescripcion":
                    return "A_Tiempo.Descripcion";
                case "hora_del_detenido":
                    return "expediente_ministerio_publico.hora_del_detenido";
                case "hora_puesto_a_disposicion":
                    return "expediente_ministerio_publico.hora_puesto_a_disposicion";
                case "estatus[descripcion]":
                case "estatusdescripcion":
                    return "estatus_mpi.descripcion";
                case "Titulo_del_Hecho":
                    return "expediente_ministerio_publico.Titulo_del_Hecho";
                case "Fecha_del_Hecho":
                    return "expediente_ministerio_publico.Fecha_del_Hecho";
                case "Narrativa_Breve_de_los_Hechos":
                    return "expediente_ministerio_publico.Narrativa_Breve_de_los_Hechos";
                case "Hora_Aproximada_del_Hecho":
                    return "expediente_ministerio_publico.Hora_Aproximada_del_Hecho";
                case "Lugar_de_los_Hechos[Descripcion]":
                case "Lugar_de_los_HechosDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "PaisH[Nombre]":
                case "PaisHNombre":
                    return "Pais.Nombre";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "ColoniaH[Nombre]":
                case "ColoniaHNombre":
                    return "Colonia.Nombre";
                case "CalleH":
                    return "expediente_ministerio_publico.CalleH";
                case "Numero_ExteriorH":
                    return "expediente_ministerio_publico.Numero_ExteriorH";
                case "Numero_InteriorH":
                    return "expediente_ministerio_publico.Numero_InteriorH";
                case "Codigo_PostalH":
                    return "expediente_ministerio_publico.Codigo_PostalH";
                case "Entre_Calle":
                    return "expediente_ministerio_publico.Entre_Calle";
                case "LongitudH":
                    return "expediente_ministerio_publico.LongitudH";
                case "LatitudH":
                    return "expediente_ministerio_publico.LatitudH";
                case "Fecha_de_Canalizacion":
                    return "expediente_ministerio_publico.Fecha_de_Canalizacion";
                case "Hora_de_Canalizacion":
                    return "expediente_ministerio_publico.Hora_de_Canalizacion";
                case "usuario_que_canaliza[Name]":
                case "usuario_que_canalizaName":
                    return "Spartan_User.Name";
                case "canalizar_a[Descripcion]":
                case "canalizar_aDescripcion":
                    return "Estatus_Orientador.Descripcion";
                case "tipo_de_acuerdo[Descripcion]":
                case "tipo_de_acuerdoDescripcion":
                    return "Tipo_de_Acuerdo.Descripcion";
                case "fecha_de_inicio_de_acuerdo":
                    return "expediente_ministerio_publico.fecha_de_inicio_de_acuerdo";
                case "fecha_de_cumplimiento":
                    return "expediente_ministerio_publico.fecha_de_cumplimiento";
                case "hora_de_cumplimiento":
                    return "expediente_ministerio_publico.hora_de_cumplimiento";
                case "domicilio_para_el_cumplimiento":
                    return "expediente_ministerio_publico.domicilio_para_el_cumplimiento";
                case "monto_de_reparacion_de_danos":
                    return "expediente_ministerio_publico.monto_de_reparacion_de_danos";
                case "parcialidades":
                    return "expediente_ministerio_publico.parcialidades";
                case "periodicidad[Descripcion]":
                case "periodicidadDescripcion":
                    return "Periodicidad.Descripcion";
                case "acepta_acuerdo[Descripcion]":
                case "acepta_acuerdoDescripcion":
                    return "A_Tiempo.Descripcion";
                case "motivo_de_rechazo_de_acuerdo":
                    return "expediente_ministerio_publico.motivo_de_rechazo_de_acuerdo";
                case "fecha_de_cierre":
                    return "expediente_ministerio_publico.fecha_de_cierre";
                case "hora_de_cierre":
                    return "expediente_ministerio_publico.hora_de_cierre";
                case "Usuario_que_Cierra[Name]":
                case "Usuario_que_CierraName":
                    return "Spartan_User.Name";
                case "tipo_de_cierre[descripcion]":
                case "tipo_de_cierredescripcion":
                    return "tipo_de_cierre.descripcion";
                case "comentarios_de_cierre":
                    return "expediente_ministerio_publico.comentarios_de_cierre";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(expediente_ministerio_publico).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "fecha_de_registro")
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
            if (columnName == "Fecha_de_Canalizacion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "fecha_de_inicio_de_acuerdo")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "fecha_de_cumplimiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "fecha_de_cierre")
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

