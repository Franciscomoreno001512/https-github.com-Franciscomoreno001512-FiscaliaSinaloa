using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_del_Abogado_Victima_MPI;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_del_Abogado_Victima_MPIPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Consecutivo_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Consecutivo_Victima";
                case "Nombre_Completo_del_Abogado_Victima[Nombre_Completo]":
                case "Nombre_Completo_del_Abogado_VictimaNombre_Completo":
                    return "Abogado.Nombre_Completo";
                case "Nombre_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Nombre_del_Abogado_Victima";
                case "Apellido_Paterno_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Apellido_Paterno_del_Abogado_Victima";
                case "Apellido_Materno_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Apellido_Materno_del_Abogado_Victima";
                case "Fecha_de_Nacimiento_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Fecha_de_Nacimiento_del_Abogado_Victima";
                case "Edad_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Edad_del_Abogado_Victima";
                case "Sexo_del_Abogado_Victima[Descripcion]":
                case "Sexo_del_Abogado_VictimaDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil_del_Abogado_Victima[Descripcion]":
                case "Estado_Civil_del_Abogado_VictimaDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion_Abogado_Victima[Nombre]":
                case "Tipo_de_Identificacion_Abogado_VictimaNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Numero_de_Identificacion_Abogado_Victima";
                case "Nacionalidad_del_Abogado_Victima[NacionalidadC]":
                case "Nacionalidad_del_Abogado_VictimaNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Cedula_Profesional_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Cedula_Profesional_del_Abogado_Victima";
                case "Pais_del_Abogado_Victima[Nombre]":
                case "Pais_del_Abogado_VictimaNombre":
                    return "Pais.Nombre";
                case "Estado_del_Abogado_Victima[Nombre]":
                case "Estado_del_Abogado_VictimaNombre":
                    return "Estado.Nombre";
                case "Municipio_del_Abogado_Victima[Nombre]":
                case "Municipio_del_Abogado_VictimaNombre":
                    return "Municipio.Nombre";
                case "Colonia_del_Abogado_Victima[Nombre]":
                case "Colonia_del_Abogado_VictimaNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Codigo_Postal_del_Abogado_Victima";
                case "Calle_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Calle_del_Abogado_Victima";
                case "Numero_Exterior_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Numero_Exterior_del_Abogado_Victima";
                case "Numero_Interior_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Numero_Interior_del_Abogado_Victima";
                case "Telefono_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Telefono_del_Abogado_Victima";
                case "Celular_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Celular_del_Abogado_Victima";
                case "Correo_Electronico_del_Abogado_Victima":
                    return "Detalle_del_Abogado_Victima_MPI.Correo_Electronico_del_Abogado_Victima";
                case "Aceptar_Notificaciones":
                    return "Detalle_del_Abogado_Victima_MPI.Aceptar_Notificaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_del_Abogado_Victima_MPI).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Nacimiento_del_Abogado_Victima")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Aceptar_Notificaciones")
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

