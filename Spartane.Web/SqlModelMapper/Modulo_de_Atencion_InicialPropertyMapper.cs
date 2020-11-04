using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_de_Atencion_Inicial;

namespace Spartane.Web.SqlModelMapper
{
    public class Modulo_de_Atencion_InicialPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Modulo_de_Atencion_Inicial.Folio";
                case "Fecha_de_Registro":
                    return "Modulo_de_Atencion_Inicial.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Modulo_de_Atencion_Inicial.Hora_de_Registro";
                case "NUAT":
                    return "Modulo_de_Atencion_Inicial.NUAT";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Nombre":
                    return "Modulo_de_Atencion_Inicial.Nombre";
                case "Apellido_Paterno":
                    return "Modulo_de_Atencion_Inicial.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Modulo_de_Atencion_Inicial.Apellido_Materno";
                case "Fecha_de_Nacimiento":
                    return "Modulo_de_Atencion_Inicial.Fecha_de_Nacimiento";
                case "Edad":
                    return "Modulo_de_Atencion_Inicial.Edad";
                case "Sexo[Descripcion]":
                case "SexoDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil[Descripcion]":
                case "Estado_CivilDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion[Nombre]":
                case "Tipo_de_IdentificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion":
                    return "Modulo_de_Atencion_Inicial.Numero_de_Identificacion";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Calle":
                    return "Modulo_de_Atencion_Inicial.Calle";
                case "Numero_Exterior":
                    return "Modulo_de_Atencion_Inicial.Numero_Exterior";
                case "Numero_Interior":
                    return "Modulo_de_Atencion_Inicial.Numero_Interior";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Modulo_de_Atencion_Inicial.Codigo_Postal";
                case "Zona[Descripcion]":
                case "ZonaDescripcion":
                    return "Zona.Descripcion";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Telefono":
                    return "Modulo_de_Atencion_Inicial.Telefono";
                case "Celular":
                    return "Modulo_de_Atencion_Inicial.Celular";
                case "Correo_Electronico":
                    return "Modulo_de_Atencion_Inicial.Correo_Electronico";
                case "Menor_de_Edad":
                    return "Modulo_de_Atencion_Inicial.Menor_de_Edad";
                case "Representante_Legal":
                    return "Modulo_de_Atencion_Inicial.Representante_Legal";
                case "Nombre_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Nombre_del_Tutor";
                case "Apellido_Paterno_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Apellido_Paterno_del_Tutor";
                case "Apellido_Materno_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Apellido_Materno_del_Tutor";
                case "Fecha_de_Nacimiento_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Fecha_de_Nacimiento_del_Tutor";
                case "Edad_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Edad_del_Tutor";
                case "Sexo_del_Tutor[Descripcion]":
                case "Sexo_del_TutorDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil_del_Tutor[Descripcion]":
                case "Estado_Civil_del_TutorDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion_del_Tutor[Nombre]":
                case "Tipo_de_Identificacion_del_TutorNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Numero_de_Identificacion_del_Tutor";
                case "Nacionalidad_del_Tutor[NacionalidadC]":
                case "Nacionalidad_del_TutorNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad_del_Tutor[Descripcion]":
                case "Escolaridad_del_TutorDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion_del_Tutor[Descripcion]":
                case "Ocupacion_del_TutorDescripcion":
                    return "Ocupacion.Descripcion";
                case "Calle_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Calle_del_Tutor";
                case "Numero_Exterior_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Numero_Exterior_del_Tutor";
                case "Numero_Interior_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Numero_Interior_del_Tutor";
                case "Colonia_del_Tutor[Nombre]":
                case "Colonia_del_TutorNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Codigo_Postal_del_Tutor";
                case "Localidad_del_Tutor[Descripcion]":
                case "Localidad_del_TutorDescripcion":
                    return "Localidad.Descripcion";
                case "Municipio_del_Tutor[Nombre]":
                case "Municipio_del_TutorNombre":
                    return "Municipio.Nombre";
                case "Estado_del_Tutor[Nombre]":
                case "Estado_del_TutorNombre":
                    return "Estado.Nombre";
                case "Telefono_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Telefono_del_Tutor";
                case "Celular_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Celular_del_Tutor";
                case "Correo_Electronico_del_Tutor":
                    return "Modulo_de_Atencion_Inicial.Correo_Electronico_del_Tutor";
                case "Nombre_del_Representante":
                    return "Modulo_de_Atencion_Inicial.Nombre_del_Representante";
                case "Apellido_Paterno_del_Representante":
                    return "Modulo_de_Atencion_Inicial.Apellido_Paterno_del_Representante";
                case "Apellido_Materno_del_Representante":
                    return "Modulo_de_Atencion_Inicial.Apellido_Materno_del_Representante";
                case "Calidad_Juridica":
                    return "Modulo_de_Atencion_Inicial.Calidad_Juridica";
                case "Calle_del_Representante":
                    return "Modulo_de_Atencion_Inicial.Calle_del_Representante";
                case "Numero_Exterior_del_Representante":
                    return "Modulo_de_Atencion_Inicial.Numero_Exterior_del_Representante";
                case "Numero_Interior_del_Representante":
                    return "Modulo_de_Atencion_Inicial.Numero_Interior_del_Representante";
                case "Colonia_del_Representante[Nombre]":
                case "Colonia_del_RepresentanteNombre":
                    return "Colonia.Nombre";
                case "Localidad_del_Representante[Descripcion]":
                case "Localidad_del_RepresentanteDescripcion":
                    return "Localidad.Descripcion";
                case "Municipio_del_Representante[Nombre]":
                case "Municipio_del_RepresentanteNombre":
                    return "Municipio.Nombre";
                case "Estado_del_Representante[Nombre]":
                case "Estado_del_RepresentanteNombre":
                    return "Estado.Nombre";
                case "Telefono_del_Representante":
                    return "Modulo_de_Atencion_Inicial.Telefono_del_Representante";
                case "Celular_del_Representante":
                    return "Modulo_de_Atencion_Inicial.Celular_del_Representante";
                case "Correo_Electronico_del_Representante":
                    return "Modulo_de_Atencion_Inicial.Correo_Electronico_del_Representante";
                case "Narrativa":
                    return "Modulo_de_Atencion_Inicial.Narrativa";
                case "Atencion_Medica":
                    return "Modulo_de_Atencion_Inicial.Atencion_Medica";
                case "Atencion_Psicologica":
                    return "Modulo_de_Atencion_Inicial.Atencion_Psicologica";
                case "Requiere_Traductor":
                    return "Modulo_de_Atencion_Inicial.Requiere_Traductor";
                case "Tipo_de_Compareciente[Descripcion]":
                case "Tipo_de_ComparecienteDescripcion":
                    return "Tipo_de_Compareciente.Descripcion";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus.Descripcion";
                case "Turno_Asignado[Numero_de_Turno]":
                case "Turno_AsignadoNumero_de_Turno":
                    return "Asignacion_de_Turnos.Numero_de_Turno";
                case "Unidad[Descripcion]":
                case "UnidadDescripcion":
                    return "Unidad.Descripcion";
                case "Municipio_Caso[Nombre]":
                case "Municipio_CasoNombre":
                    return "Municipio.Nombre";
                case "Tipo_de_Denuncia[Descripcion]":
                case "Tipo_de_DenunciaDescripcion":
                    return "Tipo_de_Denuncia.Descripcion";
                case "Numero_de_Expediente":
                    return "Modulo_de_Atencion_Inicial.Numero_de_Expediente";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "Colonia_Hechos_MPO[Nombre]":
                case "Colonia_Hechos_MPONombre":
                    return "Colonia.Nombre";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Modulo_de_Atencion_Inicial).GetProperty(columnName));
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
            if (columnName == "Menor_de_Edad")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Representante_Legal")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Nacimiento_del_Tutor")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Atencion_Medica")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Atencion_Psicologica")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Requiere_Traductor")
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

