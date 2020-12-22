using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Canalizacion;

namespace Spartane.Web.SqlModelMapper
{
    public class CanalizacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Canalizacion.Clave";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Expediente_AT[Folio]":
                case "Expediente_ATFolio":
                    return "Modulo_Atencion_Inicial.Folio";
                case "Fecha_de_Canalizacion":
                    return "Canalizacion.Fecha_de_Canalizacion";
                case "Hora_de_Canalizacion":
                    return "Canalizacion.Hora_de_Canalizacion";
                case "Usuario_que_Canaliza[Name]":
                case "Usuario_que_CanalizaName":
                    return "Spartan_User.Name";
                case "Relacion_a_Canalizar[Descripcion]":
                case "Relacion_a_CanalizarDescripcion":
                    return "Detalle_de_Relaciones.Descripcion";
                case "Canalizar_a[Descripcion]":
                case "Canalizar_aDescripcion":
                    return "Estatus_Orientador.Descripcion";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Unidad[Descripcion]":
                case "UnidadDescripcion":
                    return "Unidad.Descripcion";
                case "Fecha_de_Resolucion":
                    return "Canalizacion.Fecha_de_Resolucion";
                case "Hora_de_Resolucion":
                    return "Canalizacion.Hora_de_Resolucion";
                case "Hubo_modificacion_en_la_relacion":
                    return "Canalizacion.Hubo_modificacion_en_la_relacion";
                case "Nueva_Relacion":
                    return "Canalizacion.Nueva_Relacion";
                case "ResolucionId":
                    return "Canalizacion.ResolucionId";
                case "Resolucion":
                    return "Canalizacion.Resolucion";
                case "Detalle_de_la_Resolucion":
                    return "Canalizacion.Detalle_de_la_Resolucion";
                case "Observaciones":
                    return "Canalizacion.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Canalizacion).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
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
            if (columnName == "Fecha_de_Resolucion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Hubo_modificacion_en_la_relacion")
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

