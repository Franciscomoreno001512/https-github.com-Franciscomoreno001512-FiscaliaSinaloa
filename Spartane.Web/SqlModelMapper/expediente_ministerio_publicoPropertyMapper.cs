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
                case "unidad[Descripcion]":
                case "unidadDescripcion":
                    return "Unidad.Descripcion";
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
                case "observaciones[clave]":
                case "observacionesclave":
                    return "detalle_de_observaciones_mpi.clave";
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
                case "acepta_acuerdo":
                    return "expediente_ministerio_publico.acepta_acuerdo";
                case "motivo_de_rechazo_de_acuerdo":
                    return "expediente_ministerio_publico.motivo_de_rechazo_de_acuerdo";
                case "fecha_de_cierre":
                    return "expediente_ministerio_publico.fecha_de_cierre";
                case "hora_de_cierre":
                    return "expediente_ministerio_publico.hora_de_cierre";
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
            if (columnName == "acepta_acuerdo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
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

