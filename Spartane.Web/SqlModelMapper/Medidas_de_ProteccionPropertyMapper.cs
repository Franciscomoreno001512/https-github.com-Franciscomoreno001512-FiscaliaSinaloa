using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Medidas_de_Proteccion;

namespace Spartane.Web.SqlModelMapper
{
    public class Medidas_de_ProteccionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Medidas_de_Proteccion.Clave";
                case "Expediente_AT[NUAT]":
                case "Expediente_ATNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Expediente_MASC[Numero_de_Folio]":
                case "Expediente_MASCNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Fecha_de_Registro":
                    return "Medidas_de_Proteccion.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Medidas_de_Proteccion.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Orden_de_Proteccion":
                    return "Medidas_de_Proteccion.Orden_de_Proteccion";
                case "Tipo_de_Medida[Descripcion]":
                case "Tipo_de_MedidaDescripcion":
                    return "Tipo_de_Medida_de_Proteccion.Descripcion";
                case "Sub_Tipo[Descripcion]":
                case "Sub_TipoDescripcion":
                    return "SubTipo_de_Medida_de_Proteccion.Descripcion";
                case "Fecha_de_Inicio":
                    return "Medidas_de_Proteccion.Fecha_de_Inicio";
                case "Hora_de_Inicio":
                    return "Medidas_de_Proteccion.Hora_de_Inicio";
                case "Fecha_de_Conclusion":
                    return "Medidas_de_Proteccion.Fecha_de_Conclusion";
                case "Hora_de_Conclusion":
                    return "Medidas_de_Proteccion.Hora_de_Conclusion";
                case "Duracion_en_Dias":
                    return "Medidas_de_Proteccion.Duracion_en_Dias";
                case "Aplicar_a[Descripcion]":
                case "Aplicar_aDescripcion":
                    return "Detalle_de_Relaciones.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Medidas_de_Proteccion).GetProperty(columnName));
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
            if (columnName == "Fecha_de_Inicio")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Conclusion")
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

