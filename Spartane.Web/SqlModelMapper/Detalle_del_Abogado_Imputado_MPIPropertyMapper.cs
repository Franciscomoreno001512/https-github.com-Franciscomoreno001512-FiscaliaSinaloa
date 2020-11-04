using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_del_Abogado_Imputado_MPIPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Consecutivo":
                    return "Detalle_del_Abogado_Imputado_MPI.Consecutivo";
                case "Nombre_Completo_del_Abogado[Nombre_Completo]":
                case "Nombre_Completo_del_AbogadoNombre_Completo":
                    return "Abogado.Nombre_Completo";
                case "Nombre_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Nombre_del_Abogado";
                case "Apellido_Paterno_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Apellido_Paterno_del_Abogado";
                case "Apellido_Materno_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Apellido_Materno_del_Abogado";
                case "Fecha_de_Nacimiento_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Fecha_de_Nacimiento_del_Abogado";
                case "Edad_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Edad_del_Abogado";
                case "Sexo_del_Abogado[Descripcion]":
                case "Sexo_del_AbogadoDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil_del_Abogado[Descripcion]":
                case "Estado_Civil_del_AbogadoDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion_del_Abogado[Nombre]":
                case "Tipo_de_Identificacion_del_AbogadoNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Numero_de_Identificacion_del_Abogado";
                case "Nacionalidad_del_Abogado[NacionalidadC]":
                case "Nacionalidad_del_AbogadoNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Cedula_Profesional_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Cedula_Profesional_del_Abogado";
                case "Pais_del_Abogado[Nombre]":
                case "Pais_del_AbogadoNombre":
                    return "Pais.Nombre";
                case "Estado_del_Abogado[Nombre]":
                case "Estado_del_AbogadoNombre":
                    return "Estado.Nombre";
                case "Municipio_del_Abogado[Nombre]":
                case "Municipio_del_AbogadoNombre":
                    return "Municipio.Nombre";
                case "Colonia_del_Abogado[Nombre]":
                case "Colonia_del_AbogadoNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Codigo_Postal_del_Abogado";
                case "Calle_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Calle_del_Abogado";
                case "Numero_Exterior_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Numero_Exterior_del_Abogado";
                case "Numero_Interior_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Numero_Interior_del_Abogado";
                case "Telefono_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Telefono_del_Abogado";
                case "Celular_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Celular_del_Abogado";
                case "Correo_Electronico_del_Abogado":
                    return "Detalle_del_Abogado_Imputado_MPI.Correo_Electronico_del_Abogado";
                case "Aceptar_Notificaciones":
                    return "Detalle_del_Abogado_Imputado_MPI.Aceptar_Notificaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_del_Abogado_Imputado_MPI).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Nacimiento_del_Abogado")
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

