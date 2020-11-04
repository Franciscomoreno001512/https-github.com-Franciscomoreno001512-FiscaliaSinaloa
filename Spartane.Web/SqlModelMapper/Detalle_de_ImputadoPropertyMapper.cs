using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Imputado;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_ImputadoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Imputado.Clave";
                case "Persona_Moral":
                    return "Detalle_de_Imputado.Persona_Moral";
                case "Modulo_Atencion_Inicial[NUAT]":
                case "Modulo_Atencion_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Quien_Resulte_Responsable":
                    return "Detalle_de_Imputado.Quien_Resulte_Responsable";
                case "Se_Presenta_con_Detenido":
                    return "Detalle_de_Imputado.Se_Presenta_con_Detenido";
                case "Folio_Registro_Nacional_de_Detenciones":
                    return "Detalle_de_Imputado.Folio_Registro_Nacional_de_Detenciones";
                case "Nombre":
                    return "Detalle_de_Imputado.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Imputado.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Imputado.Apellido_Materno";
                case "Nombre_Completo_Detenido":
                    return "Detalle_de_Imputado.Nombre_Completo_Detenido";
                case "Alias":
                    return "Detalle_de_Imputado.Alias";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Imputado.Fecha_de_Nacimiento";
                case "Edad":
                    return "Detalle_de_Imputado.Edad";
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
                    return "Detalle_de_Imputado.Numero_de_Identificacion";
                case "CURP":
                    return "Detalle_de_Imputado.CURP";
                case "RFC":
                    return "Detalle_de_Imputado.RFC";
                case "Calidad_Juridica":
                    return "Detalle_de_Imputado.Calidad_Juridica";
                case "Razon_Social":
                    return "Detalle_de_Imputado.Razon_Social";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais_de_Origen[Nombre]":
                case "Pais_de_OrigenNombre":
                    return "Pais.Nombre";
                case "Originario_de":
                    return "Detalle_de_Imputado.Originario_de";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Detalle_de_Imputado.Codigo_Postal";
                case "Calle_del_Imputado":
                    return "Detalle_de_Imputado.Calle_del_Imputado";
                case "Numero_Exterior":
                    return "Detalle_de_Imputado.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Imputado.Numero_Interior";
                case "Referencia_de_Domicilio":
                    return "Detalle_de_Imputado.Referencia_de_Domicilio";
                case "Latitud":
                    return "Detalle_de_Imputado.Latitud";
                case "Longitud":
                    return "Detalle_de_Imputado.Longitud";
                case "Telefono":
                    return "Detalle_de_Imputado.Telefono";
                case "Extension":
                    return "Detalle_de_Imputado.Extension";
                case "Celular":
                    return "Detalle_de_Imputado.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Imputado.Correo_Electronico";
                case "Apodo":
                    return "Detalle_de_Imputado.Apodo";
                case "Etnia[Descripcion]":
                case "EtniaDescripcion":
                    return "Etnia.Descripcion";
                case "No_de_Hijos":
                    return "Detalle_de_Imputado.No_de_Hijos";
                case "Religion[Descripcion]":
                case "ReligionDescripcion":
                    return "Religion.Descripcion";
                case "Servicio_Medico[Descripcion]":
                case "Servicio_MedicoDescripcion":
                    return "Servicio_Medico.Descripcion";
                case "Escolaridad_Detenido[Descripcion]":
                case "Escolaridad_DetenidoDescripcion":
                    return "Escolaridad.Descripcion";
                case "Especialidad[Descripcion]":
                case "EspecialidadDescripcion":
                    return "Especialidad.Descripcion";
                case "Estudios_Superiores[Descripcion]":
                case "Estudios_SuperioresDescripcion":
                    return "Estudios_Superiores.Descripcion";
                case "Incompleto":
                    return "Detalle_de_Imputado.Incompleto";
                case "Idioma[Descripcion]":
                case "IdiomaDescripcion":
                    return "Idioma.Descripcion";
                case "Calidad_Migratoria[Descripcion]":
                case "Calidad_MigratoriaDescripcion":
                    return "Calidad_Migratoria.Descripcion";
                case "Estado_de_Nacimiento[Nombre]":
                case "Estado_de_NacimientoNombre":
                    return "Estado.Nombre";
                case "Municipio_de_Nacimiento[Nombre]":
                case "Municipio_de_NacimientoNombre":
                    return "Municipio.Nombre";
                case "Dialecto[Descripcion]":
                case "DialectoDescripcion":
                    return "Dialecto.Descripcion";
                case "Viene_en_Estado_de_Ebriedad":
                    return "Detalle_de_Imputado.Viene_en_Estado_de_Ebriedad";
                case "Bajo_el_Efecto_de_una_Droga":
                    return "Detalle_de_Imputado.Bajo_el_Efecto_de_una_Droga";
                case "Nombre_de_Droga":
                    return "Detalle_de_Imputado.Nombre_de_Droga";
                case "Inimputable":
                    return "Detalle_de_Imputado.Inimputable";
                case "Tipo_de_Inimputabilidad[Descripcion]":
                case "Tipo_de_InimputabilidadDescripcion":
                    return "Tipo_de_Inimputabilidad.Descripcion";
                case "Especifique":
                    return "Detalle_de_Imputado.Especifique";
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
                case "Nombres2":
                    return "Detalle_de_Imputado.Nombres2";
                case "Apellido_Paterno2":
                    return "Detalle_de_Imputado.Apellido_Paterno2";
                case "Apellido_Materno2":
                    return "Detalle_de_Imputado.Apellido_Materno2";
                case "Nombre_Completo2":
                    return "Detalle_de_Imputado.Nombre_Completo2";
                case "Sexo2[Descripcion]":
                case "Sexo2Descripcion":
                    return "Genero.Descripcion";
                case "Nacionalidad2[NacionalidadC]":
                case "Nacionalidad2NacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad2[Descripcion]":
                case "Escolaridad2Descripcion":
                    return "Escolaridad.Descripcion";
                case "ID_Estado_Institucion":
                    return "Detalle_de_Imputado.ID_Estado_Institucion";
                case "Peso":
                    return "Detalle_de_Imputado.Peso";
                case "Estatura":
                    return "Detalle_de_Imputado.Estatura";
                case "Padecimiento_de_Enfermedad":
                    return "Detalle_de_Imputado.Padecimiento_de_Enfermedad";
                case "Forma_Cara[Descripcion]":
                case "Forma_CaraDescripcion":
                    return "Forma_Cara.Descripcion";
                case "Cejas[Descripcion]":
                case "CejasDescripcion":
                    return "Cejas.Descripcion";
                case "Tamano_de_Cejas[Descripcion]":
                case "Tamano_de_CejasDescripcion":
                    return "Tamano_de_Cejas.Descripcion";
                case "Largo_de_Cabello[Descripcion]":
                case "Largo_de_CabelloDescripcion":
                    return "Largo_de_Cabello.Descripcion";
                case "Cantidad_Cabello[Descripcion]":
                case "Cantidad_CabelloDescripcion":
                    return "Cantidad_Cabello.Descripcion";
                case "Implantacion_Cabello[Descripcion]":
                case "Implantacion_CabelloDescripcion":
                    return "Implantacion_Cabello.Descripcion";
                case "Complexion[Descripcion]":
                case "ComplexionDescripcion":
                    return "Complexion.Descripcion";
                case "Color_Piel[Descrpicion]":
                case "Color_PielDescrpicion":
                    return "Color_Piel.Descrpicion";
                case "Frente[Descripcion]":
                case "FrenteDescripcion":
                    return "Frente.Descripcion";
                case "Forma_Cabello[Descripcion]":
                case "Forma_CabelloDescripcion":
                    return "Forma_Cabello.Descripcion";
                case "Color_Cabello[Descripcion]":
                case "Color_CabelloDescripcion":
                    return "Color_de_Cabello.Descripcion";
                case "Calvicie[Descripcion]":
                case "CalvicieDescripcion":
                    return "Calvicie.Descripcion";
                case "Color_Ojos[Descripcion]":
                case "Color_OjosDescripcion":
                    return "Color_Ojos.Descripcion";
                case "Ojos[Descripcion]":
                case "OjosDescripcion":
                    return "Ojos.Descripcion";
                case "Forma_Ojos[Descripcion]":
                case "Forma_OjosDescripcion":
                    return "Froma_Ojos.Descripcion";
                case "Anteojos[Descripcion]":
                case "AnteojosDescripcion":
                    return "Anteojos.Descripcion";
                case "Forma_de_Nariz[Descripcion]":
                case "Forma_de_NarizDescripcion":
                    return "Forma_de_Nariz.Descripcion";
                case "Nariz_Base[Descripcion]":
                case "Nariz_BaseDescripcion":
                    return "Nariz_Base.Descripcion";
                case "Labios[Descripcion]":
                case "LabiosDescripcion":
                    return "Labios.Descripcion";
                case "Boca[Descripcion]":
                case "BocaDescripcion":
                    return "Boca.Descripcion";
                case "Grosor_de_Labios[Descripcion]":
                case "Grosor_de_LabiosDescripcion":
                    return "Grosor_de_Labios.Descripcion";
                case "Menton[Descripcion]":
                case "MentonDescripcion":
                    return "Menton.Descripcion";
                case "Forma_de_Menton[Descripcion]":
                case "Forma_de_MentonDescripcion":
                    return "Forma_de_Menton.Descripcion";
                case "Barba[Descripcion]":
                case "BarbaDescripcion":
                    return "Barba.Descripcion";
                case "Forma_Orejas[Descripcion]":
                case "Forma_OrejasDescripcion":
                    return "Forma_Orejas.Descripcion";
                case "Tamano_Orejas[Descripcion]":
                case "Tamano_OrejasDescripcion":
                    return "Tamano_Orejas.Descripcion";
                case "Tipo_Lobulo[Descripcion]":
                case "Tipo_LobuloDescripcion":
                    return "Tipo_Lobulo.Descripcion";
                case "Bigote[Descripcion]":
                case "BigoteDescripcion":
                    return "Bigote.Descripcion";
                case "Senas_Particulares[Descripcion]":
                case "Senas_ParticularesDescripcion":
                    return "Senas_Particulares.Descripcion";
                case "Situacion_Fisica[Descripcion]":
                case "Situacion_FisicaDescripcion":
                    return "Situacion_Fisica.Descripcion";
                case "Otras_Senas_Particulares":
                    return "Detalle_de_Imputado.Otras_Senas_Particulares";
                case "Imputado_Recluido":
                    return "Detalle_de_Imputado.Imputado_Recluido";
                case "Narrativa_Breve_de_los_Hechos":
                    return "Detalle_de_Imputado.Narrativa_Breve_de_los_Hechos";
                case "Prioridad_del_Hecho[Descripcion]":
                case "Prioridad_del_HechoDescripcion":
                    return "Prioridad_del_Hecho.Descripcion";
                case "Fecha_del_Hecho":
                    return "Detalle_de_Imputado.Fecha_del_Hecho";
                case "Hora_Aproximada_del_Hecho":
                    return "Detalle_de_Imputado.Hora_Aproximada_del_Hecho";
                case "Pais_del_hecho[Nombre]":
                case "Pais_del_hechoNombre":
                    return "Pais.Nombre";
                case "Estado_del_Hecho[Nombre]":
                case "Estado_del_HechoNombre":
                    return "Estado.Nombre";
                case "Municipio_del_Hecho[Nombre]":
                case "Municipio_del_HechoNombre":
                    return "Municipio.Nombre";
                case "Poblacion_Hechos[Nombre]":
                case "Poblacion_HechosNombre":
                    return "Colonia.Nombre";
                case "Colonia_del_hecho[Nombre]":
                case "Colonia_del_hechoNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_hecho":
                    return "Detalle_de_Imputado.Codigo_Postal_del_hecho";
                case "Calle_del_hecho":
                    return "Detalle_de_Imputado.Calle_del_hecho";
                case "Entre_Calle":
                    return "Detalle_de_Imputado.Entre_Calle";
                case "Y_Calle":
                    return "Detalle_de_Imputado.Y_Calle";
                case "Numero_Exterior_de_los_Hechos":
                    return "Detalle_de_Imputado.Numero_Exterior_de_los_Hechos";
                case "Numero_interior_de_los_hecho":
                    return "Detalle_de_Imputado.Numero_interior_de_los_hecho";
                case "Latitud_de_los_hechos":
                    return "Detalle_de_Imputado.Latitud_de_los_hechos";
                case "Longitud_de_los_Hechos":
                    return "Detalle_de_Imputado.Longitud_de_los_Hechos";
                case "Tipo_del_lugar_del_he[Descripcion]":
                case "Tipo_del_lugar_del_heDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "Nombre_del_Tutor":
                    return "Detalle_de_Imputado.Nombre_del_Tutor";
                case "Apellido_Paterno_del_Tutor":
                    return "Detalle_de_Imputado.Apellido_Paterno_del_Tutor";
                case "Apellido_Materno_del_Tutor":
                    return "Detalle_de_Imputado.Apellido_Materno_del_Tutor";
                case "Nombre_Completo_del_Tutor":
                    return "Detalle_de_Imputado.Nombre_Completo_del_Tutor";
                case "Fecha_de_Nacimiento_del_Tutor":
                    return "Detalle_de_Imputado.Fecha_de_Nacimiento_del_Tutor";
                case "Edad_del_Tutor":
                    return "Detalle_de_Imputado.Edad_del_Tutor";
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
                    return "Detalle_de_Imputado.Numero_de_Identificacion_del_Tutor";
                case "CURP_Tutor":
                    return "Detalle_de_Imputado.CURP_Tutor";
                case "RFC_Tutor":
                    return "Detalle_de_Imputado.RFC_Tutor";
                case "Nacionalidad_del_Tutor[NacionalidadC]":
                case "Nacionalidad_del_TutorNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad_del_Tutor[Descripcion]":
                case "Escolaridad_del_TutorDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion_del_Tutor[Descripcion]":
                case "Ocupacion_del_TutorDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais_de_Origen_tutor[Nombre]":
                case "Pais_de_Origen_tutorNombre":
                    return "Pais.Nombre";
                case "Originario_de_tutor":
                    return "Detalle_de_Imputado.Originario_de_tutor";
                case "Pais_del_Tutor[Nombre]":
                case "Pais_del_TutorNombre":
                    return "Pais.Nombre";
                case "Estado_del_Tutor[Nombre]":
                case "Estado_del_TutorNombre":
                    return "Estado.Nombre";
                case "Municipio_del_Tutor[Nombre]":
                case "Municipio_del_TutorNombre":
                    return "Municipio.Nombre";
                case "Poblacion_Tutor[Nombre]":
                case "Poblacion_TutorNombre":
                    return "Colonia.Nombre";
                case "Colonia_del_Tutor[Nombre]":
                case "Colonia_del_TutorNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_Tutor":
                    return "Detalle_de_Imputado.Codigo_Postal_del_Tutor";
                case "Calle_del_Tutor":
                    return "Detalle_de_Imputado.Calle_del_Tutor";
                case "Numero_Exterior_del_Tutor":
                    return "Detalle_de_Imputado.Numero_Exterior_del_Tutor";
                case "Numero_Interior_del_Tutor":
                    return "Detalle_de_Imputado.Numero_Interior_del_Tutor";
                case "Referencia":
                    return "Detalle_de_Imputado.Referencia";
                case "Latitud_Tutor":
                    return "Detalle_de_Imputado.Latitud_Tutor";
                case "Longitud_Tutor":
                    return "Detalle_de_Imputado.Longitud_Tutor";
                case "Telefono_del_Tutor":
                    return "Detalle_de_Imputado.Telefono_del_Tutor";
                case "Extension_del_Tutor":
                    return "Detalle_de_Imputado.Extension_del_Tutor";
                case "Celular_del_Tutor":
                    return "Detalle_de_Imputado.Celular_del_Tutor";
                case "Correo_Electronico_del_Tutor":
                    return "Detalle_de_Imputado.Correo_Electronico_del_Tutor";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Imputado).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Persona_Moral")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Quien_Resulte_Responsable")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Se_Presenta_con_Detenido")
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
            if (columnName == "Incompleto")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Viene_en_Estado_de_Ebriedad")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Bajo_el_Efecto_de_una_Droga")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Inimputable")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
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

