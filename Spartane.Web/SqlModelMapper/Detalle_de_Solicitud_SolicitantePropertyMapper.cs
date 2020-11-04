using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Solicitud_SolicitantePropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Solicitud_Solicitante.Clave";
                case "idRegistroAT":
                    return "Detalle_de_Solicitud_Solicitante.idRegistroAT";
                case "idRegistroUI":
                    return "Detalle_de_Solicitud_Solicitante.idRegistroUI";
                case "Solicitud[Numero_de_Folio]":
                case "SolicitudNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Nombre":
                    return "Detalle_de_Solicitud_Solicitante.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Solicitud_Solicitante.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Solicitud_Solicitante.Apellido_Materno";
                case "Nombre_Completo":
                    return "Detalle_de_Solicitud_Solicitante.Nombre_Completo";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento";
                case "CURP":
                    return "Detalle_de_Solicitud_Solicitante.CURP";
                case "RFC":
                    return "Detalle_de_Solicitud_Solicitante.RFC";
                case "Edad":
                    return "Detalle_de_Solicitud_Solicitante.Edad";
                case "Sexo[Descripcion]":
                case "SexoDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil[Descripcion]":
                case "Estado_CivilDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion[Nombre]":
                case "Tipo_de_IdentificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Indentificacion":
                    return "Detalle_de_Solicitud_Solicitante.Numero_de_Indentificacion";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Codigo_Postal":
                    return "Detalle_de_Solicitud_Solicitante.Codigo_Postal";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Calle":
                    return "Detalle_de_Solicitud_Solicitante.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Solicitud_Solicitante.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Solicitud_Solicitante.Numero_Interior";
                case "Entre_Calle":
                    return "Detalle_de_Solicitud_Solicitante.Entre_Calle";
                case "Y_Calle":
                    return "Detalle_de_Solicitud_Solicitante.Y_Calle";
                case "Longitud":
                    return "Detalle_de_Solicitud_Solicitante.Longitud";
                case "Latitud":
                    return "Detalle_de_Solicitud_Solicitante.Latitud";
                case "Telefono":
                    return "Detalle_de_Solicitud_Solicitante.Telefono";
                case "Celular":
                    return "Detalle_de_Solicitud_Solicitante.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Solicitud_Solicitante.Correo_Electronico";
                case "Pais_de_Origen[Nombre]":
                case "Pais_de_OrigenNombre":
                    return "Pais.Nombre";
                case "Originario_de":
                    return "Detalle_de_Solicitud_Solicitante.Originario_de";
                case "Tipo_de_Compareciente[Descripcion]":
                case "Tipo_de_ComparecienteDescripcion":
                    return "Tipo_de_Compareciente.Descripcion";
                case "Incapaz":
                    return "Detalle_de_Solicitud_Solicitante.Incapaz";
                case "Tipo_de_Inimputabilidad[Descripcion]":
                case "Tipo_de_InimputabilidadDescripcion":
                    return "Tipo_de_Inimputabilidad.Descripcion";
                case "Nombre_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Nombre_tutor";
                case "Apellido_Paterno_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Apellido_Paterno_tutor";
                case "Apellido_Materno_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Apellido_Materno_tutor";
                case "Nombre_Completo_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor";
                case "Fecha_de_Nacimiento_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento_tutor";
                case "CURP_Tutor":
                    return "Detalle_de_Solicitud_Solicitante.CURP_Tutor";
                case "RFC_Tutor":
                    return "Detalle_de_Solicitud_Solicitante.RFC_Tutor";
                case "Edad_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Edad_tutor";
                case "Sexo_tutor[Descripcion]":
                case "Sexo_tutorDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil_tutor[Descripcion]":
                case "Estado_Civil_tutorDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion_tutor[Nombre]":
                case "Tipo_de_Identificacion_tutorNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Numero_de_Identificacion_tutor";
                case "Nacionalidad_tutor[NacionalidadC]":
                case "Nacionalidad_tutorNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad_tutor[Descripcion]":
                case "Escolaridad_tutorDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion_tutor[Descripcion]":
                case "Ocupacion_tutorDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais_tutor[Nombre]":
                case "Pais_tutorNombre":
                    return "Pais.Nombre";
                case "Estado_tutor[Nombre]":
                case "Estado_tutorNombre":
                    return "Estado.Nombre";
                case "Municipio_tutor[Nombre]":
                case "Municipio_tutorNombre":
                    return "Municipio.Nombre";
                case "Localidad_tutor[Descripcion]":
                case "Localidad_tutorDescripcion":
                    return "Localidad.Descripcion";
                case "Colonia_tutor[Nombre]":
                case "Colonia_tutorNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Codigo_Postal_tutor";
                case "Calle_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Calle_tutor";
                case "Numero_Exterior_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Numero_Exterior_tutor";
                case "Numero_Interior_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Numero_Interior_tutor";
                case "Telefono_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Telefono_tutor";
                case "Extension_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Extension_tutor";
                case "Celular_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Celular_tutor";
                case "Correo_Electronico_tutor":
                    return "Detalle_de_Solicitud_Solicitante.Correo_Electronico_tutor";
                case "Pais_de_Origen_T[Nombre]":
                case "Pais_de_Origen_TNombre":
                    return "Pais.Nombre";
                case "Originario_de_T":
                    return "Detalle_de_Solicitud_Solicitante.Originario_de_T";
                case "Titulo_del_Hecho":
                    return "Detalle_de_Solicitud_Solicitante.Titulo_del_Hecho";
                case "Narrativa_Breve_de_los_Hechos":
                    return "Detalle_de_Solicitud_Solicitante.Narrativa_Breve_de_los_Hechos";
                case "Fecha_del_Hecho":
                    return "Detalle_de_Solicitud_Solicitante.Fecha_del_Hecho";
                case "Hora_Aproximada_del_Hecho":
                    return "Detalle_de_Solicitud_Solicitante.Hora_Aproximada_del_Hecho";
                case "Lugar_de_los_Hechos[Descripcion]":
                case "Lugar_de_los_HechosDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "Pais_Hechos[Nombre]":
                case "Pais_HechosNombre":
                    return "Pais.Nombre";
                case "Estado_Hechos[Nombre]":
                case "Estado_HechosNombre":
                    return "Estado.Nombre";
                case "Municipio_Hechos[Nombre]":
                case "Municipio_HechosNombre":
                    return "Municipio.Nombre";
                case "Colonia_Hechos[Nombre]":
                case "Colonia_HechosNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_Hechos":
                    return "Detalle_de_Solicitud_Solicitante.Codigo_Postal_Hechos";
                case "Calle_Hechos":
                    return "Detalle_de_Solicitud_Solicitante.Calle_Hechos";
                case "Numero_Exterior_Hechos":
                    return "Detalle_de_Solicitud_Solicitante.Numero_Exterior_Hechos";
                case "Numero_Interior_Hechos":
                    return "Detalle_de_Solicitud_Solicitante.Numero_Interior_Hechos";
                case "Entre_Calle_Hechos":
                    return "Detalle_de_Solicitud_Solicitante.Entre_Calle_Hechos";
                case "y_Calle_Hechos":
                    return "Detalle_de_Solicitud_Solicitante.y_Calle_Hechos";
                case "Longitud_Hechos":
                    return "Detalle_de_Solicitud_Solicitante.Longitud_Hechos";
                case "Latitud_H":
                    return "Detalle_de_Solicitud_Solicitante.Latitud_H";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Solicitud_Solicitante).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Nacimiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Incapaz")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Nacimiento_tutor")
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

