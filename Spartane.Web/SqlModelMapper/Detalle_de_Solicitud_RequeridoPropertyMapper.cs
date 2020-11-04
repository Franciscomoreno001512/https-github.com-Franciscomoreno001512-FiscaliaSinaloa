using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Solicitud_RequeridoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Solicitud_Requerido.Clave";
                case "idRegistroAT":
                    return "Detalle_de_Solicitud_Requerido.idRegistroAT";
                case "idRegistroUI":
                    return "Detalle_de_Solicitud_Requerido.idRegistroUI";
                case "Solicitud[Numero_de_Folio]":
                case "SolicitudNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "A_Quien_Sea_Responsable":
                    return "Detalle_de_Solicitud_Requerido.A_Quien_Sea_Responsable";
                case "Nombre":
                    return "Detalle_de_Solicitud_Requerido.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Solicitud_Requerido.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Solicitud_Requerido.Apellido_Materno";
                case "Nombre_Completo":
                    return "Detalle_de_Solicitud_Requerido.Nombre_Completo";
                case "Alias":
                    return "Detalle_de_Solicitud_Requerido.Alias";
                case "Apodo":
                    return "Detalle_de_Solicitud_Requerido.Apodo";
                case "CURP":
                    return "Detalle_de_Solicitud_Requerido.CURP";
                case "RFC":
                    return "Detalle_de_Solicitud_Requerido.RFC";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Solicitud_Requerido.Fecha_de_Nacimiento";
                case "Edad":
                    return "Detalle_de_Solicitud_Requerido.Edad";
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
                    return "Detalle_de_Solicitud_Requerido.Numero_de_Identificacion";
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
                    return "Detalle_de_Solicitud_Requerido.Codigo_Postal";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Calle":
                    return "Detalle_de_Solicitud_Requerido.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Solicitud_Requerido.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Solicitud_Requerido.Numero_Interior";
                case "Entre_Calle":
                    return "Detalle_de_Solicitud_Requerido.Entre_Calle";
                case "Y_Calle":
                    return "Detalle_de_Solicitud_Requerido.Y_Calle";
                case "Referencia_de_Domicilio_Requerido":
                    return "Detalle_de_Solicitud_Requerido.Referencia_de_Domicilio_Requerido";
                case "Latitud":
                    return "Detalle_de_Solicitud_Requerido.Latitud";
                case "Longitud":
                    return "Detalle_de_Solicitud_Requerido.Longitud";
                case "Telefono":
                    return "Detalle_de_Solicitud_Requerido.Telefono";
                case "Extencion":
                    return "Detalle_de_Solicitud_Requerido.Extencion";
                case "Celular":
                    return "Detalle_de_Solicitud_Requerido.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Solicitud_Requerido.Correo_Electronico";
                case "Pais_de_Origen[Nombre]":
                case "Pais_de_OrigenNombre":
                    return "Pais.Nombre";
                case "Originario_de":
                    return "Detalle_de_Solicitud_Requerido.Originario_de";
                case "Estado_de_Nacimiento[Nombre]":
                case "Estado_de_NacimientoNombre":
                    return "Estado.Nombre";
                case "Municipio_de_Nacimiento[Nombre]":
                case "Municipio_de_NacimientoNombre":
                    return "Municipio.Nombre";
                case "Inimputable":
                    return "Detalle_de_Solicitud_Requerido.Inimputable";
                case "Tipo_de_Inimputabilidad[Descripcion]":
                case "Tipo_de_InimputabilidadDescripcion":
                    return "Tipo_de_Inimputabilidad.Descripcion";
                case "Se_Presenta_con_Detenido":
                    return "Detalle_de_Solicitud_Requerido.Se_Presenta_con_Detenido";
                case "Folio_Registro_Nacional_de_Detenciones":
                    return "Detalle_de_Solicitud_Requerido.Folio_Registro_Nacional_de_Detenciones";
                case "Fecha_de_Detencion":
                    return "Detalle_de_Solicitud_Requerido.Fecha_de_Detencion";
                case "Municipio_de_Detencion[Nombre]":
                case "Municipio_de_DetencionNombre":
                    return "Municipio.Nombre";
                case "Corporacion[Descripcion]":
                case "CorporacionDescripcion":
                    return "Corporacion.Descripcion";
                case "Suspension_Condicional":
                    return "Detalle_de_Solicitud_Requerido.Suspension_Condicional";
                case "Fecha_de_Suspension_Condicional":
                    return "Detalle_de_Solicitud_Requerido.Fecha_de_Suspension_Condicional";
                case "Lugar_donde_se_Encuentra_Detenido":
                    return "Detalle_de_Solicitud_Requerido.Lugar_donde_se_Encuentra_Detenido";
                case "Etnia[Descripcion]":
                case "EtniaDescripcion":
                    return "Etnia.Descripcion";
                case "No__de_Hijos":
                    return "Detalle_de_Solicitud_Requerido.No__de_Hijos";
                case "Religion[Descripcion]":
                case "ReligionDescripcion":
                    return "Religion.Descripcion";
                case "Servicio_Medico[Descripcion]":
                case "Servicio_MedicoDescripcion":
                    return "Servicio_Medico.Descripcion";
                case "Especialidad[Descripcion]":
                case "EspecialidadDescripcion":
                    return "Especialidad.Descripcion";
                case "Estudios_Superiores[Descripcion]":
                case "Estudios_SuperioresDescripcion":
                    return "Estudios_Superiores.Descripcion";
                case "Idioma[Descripcion]":
                case "IdiomaDescripcion":
                    return "Idioma.Descripcion";
                case "Calidad_Migratoria[Descripcion]":
                case "Calidad_MigratoriaDescripcion":
                    return "Calidad_Migratoria.Descripcion";
                case "Dialecto[Descripcion]":
                case "DialectoDescripcion":
                    return "Dialecto.Descripcion";
                case "Viene_en_Estado_de_Ebriedad":
                    return "Detalle_de_Solicitud_Requerido.Viene_en_Estado_de_Ebriedad";
                case "Bajo_el_Efecto_de_una_Droga":
                    return "Detalle_de_Solicitud_Requerido.Bajo_el_Efecto_de_una_Droga";
                case "Nombre_de_Droga":
                    return "Detalle_de_Solicitud_Requerido.Nombre_de_Droga";
                case "Discapacidad_Mental[Descripcion]":
                case "Discapacidad_MentalDescripcion":
                    return "Discapacidades_Mentales.Descripcion";
                case "Discapacidad_Fisica[Descripcion]":
                case "Discapacidad_FisicaDescripcion":
                    return "Discapacidades_Fisicas.Descripcion";
                case "Discapacidad_Sensorial[Descripcion]":
                case "Discapacidad_SensorialDescripcion":
                    return "Discapacidades_Sensoriales.Descripcion";
                case "Discapacidad_Psicosocial[Descripcion]":
                case "Discapacidad_PsicosocialDescripcion":
                    return "Discapacidades_Psicosociales.Descripcion";
                case "Nombre_de_Tutor":
                    return "Detalle_de_Solicitud_Requerido.Nombre_de_Tutor";
                case "Apellido_Paterno_Tutor":
                    return "Detalle_de_Solicitud_Requerido.Apellido_Paterno_Tutor";
                case "Apellido_Materno_Tutor":
                    return "Detalle_de_Solicitud_Requerido.Apellido_Materno_Tutor";
                case "Nombre_Completo_Tutor":
                    return "Detalle_de_Solicitud_Requerido.Nombre_Completo_Tutor";
                case "Fecha_de_Nacimiento_tutor":
                    return "Detalle_de_Solicitud_Requerido.Fecha_de_Nacimiento_tutor";
                case "Edad_tutor":
                    return "Detalle_de_Solicitud_Requerido.Edad_tutor";
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
                    return "Detalle_de_Solicitud_Requerido.Numero_de_Identificacion_tutor";
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
                case "Poblacion_tutor[Nombre]":
                case "Poblacion_tutorNombre":
                    return "Colonia.Nombre";
                case "Colonia_tutor[Nombre]":
                case "Colonia_tutorNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_tutor":
                    return "Detalle_de_Solicitud_Requerido.Codigo_Postal_tutor";
                case "Calle_tutor":
                    return "Detalle_de_Solicitud_Requerido.Calle_tutor";
                case "Numero_Exterior_tutor":
                    return "Detalle_de_Solicitud_Requerido.Numero_Exterior_tutor";
                case "Numero_Interior_tutor":
                    return "Detalle_de_Solicitud_Requerido.Numero_Interior_tutor";
                case "Referencia":
                    return "Detalle_de_Solicitud_Requerido.Referencia";
                case "Latitud_tutor":
                    return "Detalle_de_Solicitud_Requerido.Latitud_tutor";
                case "Longitud_tutor":
                    return "Detalle_de_Solicitud_Requerido.Longitud_tutor";
                case "Extension_tutor":
                    return "Detalle_de_Solicitud_Requerido.Extension_tutor";
                case "Celular_tutor":
                    return "Detalle_de_Solicitud_Requerido.Celular_tutor";
                case "Correo_Electronico_tutor":
                    return "Detalle_de_Solicitud_Requerido.Correo_Electronico_tutor";
                case "Pais_de_Origen_Tutor[Nombre]":
                case "Pais_de_Origen_TutorNombre":
                    return "Pais.Nombre";
                case "Originario_de_Tutor":
                    return "Detalle_de_Solicitud_Requerido.Originario_de_Tutor";
                case "CURP_Tutor":
                    return "Detalle_de_Solicitud_Requerido.CURP_Tutor";
                case "RFC_Tutor":
                    return "Detalle_de_Solicitud_Requerido.RFC_Tutor";
                case "Padecimiento_de_Enfermedad":
                    return "Detalle_de_Solicitud_Requerido.Padecimiento_de_Enfermedad";
                case "Cejas[Descripcion]":
                case "CejasDescripcion":
                    return "Cejas.Descripcion";
                case "Tamano_de_Cejas[Descripcion]":
                case "Tamano_de_CejasDescripcion":
                    return "Tamano_de_Cejas.Descripcion";
                case "Anteojos[Descripcion]":
                case "AnteojosDescripcion":
                    return "Anteojos.Descripcion";
                case "Forma_de_Nariz[Descripcion]":
                case "Forma_de_NarizDescripcion":
                    return "Forma_de_Nariz.Descripcion";
                case "Nariz_base[Descripcion]":
                case "Nariz_baseDescripcion":
                    return "Nariz_Base.Descripcion";
                case "Grosor_de_Labios[Descripcion]":
                case "Grosor_de_LabiosDescripcion":
                    return "Grosor_de_Labios.Descripcion";
                case "Forma_de_Menton[Descripcion]":
                case "Forma_de_MentonDescripcion":
                    return "Forma_de_Menton.Descripcion";
                case "Senas_Particulares[Descripcion]":
                case "Senas_ParticularesDescripcion":
                    return "Senas_Particulares.Descripcion";
                case "Otras_Senas_Particulares":
                    return "Detalle_de_Solicitud_Requerido.Otras_Senas_Particulares";
                case "Imputado_Recluido":
                    return "Detalle_de_Solicitud_Requerido.Imputado_Recluido";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Solicitud_Requerido).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "A_Quien_Sea_Responsable")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
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
            if (columnName == "Inimputable")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Se_Presenta_con_Detenido")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Detencion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Suspension_Condicional")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Suspension_Condicional")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Viene_en_Estado_de_Ebriedad")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Bajo_el_Efecto_de_una_Droga")
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

