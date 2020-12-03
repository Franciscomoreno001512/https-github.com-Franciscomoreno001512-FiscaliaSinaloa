using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Datos_GeneralesPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Datos_Generales.Clave";
                case "Modulo_Atencion_Inicial[NUAT]":
                case "Modulo_Atencion_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Datos_Confidenciales":
                    return "Detalle_de_Datos_Generales.Datos_Confidenciales";
                case "Se_Informo_sobre_el_Procedimiento":
                    return "Detalle_de_Datos_Generales.Se_Informo_sobre_el_Procedimiento";
                case "Tipo_de_Compareciente[Descripcion]":
                case "Tipo_de_ComparecienteDescripcion":
                    return "Tipo_de_Compareciente.Descripcion";
                case "Persona_Moral":
                    return "Detalle_de_Datos_Generales.Persona_Moral";
                case "Q_Q_R_O_":
                    return "Detalle_de_Datos_Generales.Q_Q_R_O_";
                case "Es_victima":
                    return "Detalle_de_Datos_Generales.Es_victima";
                case "Nombre":
                    return "Detalle_de_Datos_Generales.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Datos_Generales.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Datos_Generales.Apellido_Materno";
                case "Nombre_Completo":
                    return "Detalle_de_Datos_Generales.Nombre_Completo";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Datos_Generales.Fecha_de_Nacimiento";
                case "Edad":
                    return "Detalle_de_Datos_Generales.Edad";
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
                    return "Detalle_de_Datos_Generales.Numero_de_Identificacion";
                case "CURP":
                    return "Detalle_de_Datos_Generales.CURP";
                case "RFC":
                    return "Detalle_de_Datos_Generales.RFC";
                case "Calidad_Juridica":
                    return "Detalle_de_Datos_Generales.Calidad_Juridica";
                case "Razon_Social":
                    return "Detalle_de_Datos_Generales.Razon_Social";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Municipio_Corporacion[Nombre]":
                case "Municipio_CorporacionNombre":
                    return "Municipio.Nombre";
                case "Corporacion[Descripcion]":
                case "CorporacionDescripcion":
                    return "Corporacion.Descripcion";
                case "Pais_de_Origen[Nombre]":
                case "Pais_de_OrigenNombre":
                    return "Pais.Nombre";
                case "Originario_de":
                    return "Detalle_de_Datos_Generales.Originario_de";
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
                    return "Detalle_de_Datos_Generales.Codigo_Postal";
                case "Calle":
                    return "Detalle_de_Datos_Generales.Calle";
                case "Entre_Calle":
                    return "Detalle_de_Datos_Generales.Entre_Calle";
                case "Y_Calle":
                    return "Detalle_de_Datos_Generales.Y_Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Datos_Generales.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Datos_Generales.Numero_Interior";
                case "Referencia_de_Domicilio":
                    return "Detalle_de_Datos_Generales.Referencia_de_Domicilio";
                case "Latitud":
                    return "Detalle_de_Datos_Generales.Latitud";
                case "Longitud":
                    return "Detalle_de_Datos_Generales.Longitud";
                case "Telefono":
                    return "Detalle_de_Datos_Generales.Telefono";
                case "Extension":
                    return "Detalle_de_Datos_Generales.Extension";
                case "Celular":
                    return "Detalle_de_Datos_Generales.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Datos_Generales.Correo_Electronico";
                case "Situacion_de_Vulnerabilidad":
                    return "Detalle_de_Datos_Generales.Situacion_de_Vulnerabilidad";
                case "Grupo_al_que_pertenece[Descripcion]":
                case "Grupo_al_que_perteneceDescripcion":
                    return "Grupo_al_que_Pertenece.Descripcion";
                case "Etnia[Descripcion]":
                case "EtniaDescripcion":
                    return "Etnia.Descripcion";
                case "No_de_Hijos":
                    return "Detalle_de_Datos_Generales.No_de_Hijos";
                case "Religion[Descripcion]":
                case "ReligionDescripcion":
                    return "Religion.Descripcion";
                case "Servicio_Medico[Descripcion]":
                case "Servicio_MedicoDescripcion":
                    return "Servicio_Medico.Descripcion";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Escolaridad_[Descripcion]":
                case "Escolaridad_Descripcion":
                    return "Escolaridad.Descripcion";
                case "Especialidad[Descripcion]":
                case "EspecialidadDescripcion":
                    return "Especialidad.Descripcion";
                case "Estudios_Superiores[Descripcion]":
                case "Estudios_SuperioresDescripcion":
                    return "Estudios_Superiores.Descripcion";
                case "Incompleto":
                    return "Detalle_de_Datos_Generales.Incompleto";
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
                case "Estado_de_Involucrado[Descripcion]":
                case "Estado_de_InvolucradoDescripcion":
                    return "Estado_de_Involucrado.Descripcion";
                case "Incapaz":
                    return "Detalle_de_Datos_Generales.Incapaz";
                case "Tipo_de_Inimputabilidad[Descripcion]":
                case "Tipo_de_InimputabilidadDescripcion":
                    return "Tipo_de_Inimputabilidad.Descripcion";
                case "Especifique":
                    return "Detalle_de_Datos_Generales.Especifique";
                case "Se_Informaron_sobre_sus_Derechos":
                    return "Detalle_de_Datos_Generales.Se_Informaron_sobre_sus_Derechos";
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
                case "Nombre_del_Tutor":
                    return "Detalle_de_Datos_Generales.Nombre_del_Tutor";
                case "Apellido_Paterno_del_Tutor":
                    return "Detalle_de_Datos_Generales.Apellido_Paterno_del_Tutor";
                case "Apellido_Materno_del_Tutor":
                    return "Detalle_de_Datos_Generales.Apellido_Materno_del_Tutor";
                case "Nombre_Completo_del_Tutor":
                    return "Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor";
                case "Fecha_de_Nacimiento_del_Tutor":
                    return "Detalle_de_Datos_Generales.Fecha_de_Nacimiento_del_Tutor";
                case "Edad_del_Tutor":
                    return "Detalle_de_Datos_Generales.Edad_del_Tutor";
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
                    return "Detalle_de_Datos_Generales.Numero_de_Identificacion_del_Tutor";
                case "CURP_Tutor":
                    return "Detalle_de_Datos_Generales.CURP_Tutor";
                case "RFC_Tutor":
                    return "Detalle_de_Datos_Generales.RFC_Tutor";
                case "Nacionalidad_del_Tutor[NacionalidadC]":
                case "Nacionalidad_del_TutorNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad_del_Tutor[Descripcion]":
                case "Escolaridad_del_TutorDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion_del_Tutor[Descripcion]":
                case "Ocupacion_del_TutorDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais_de_Origen_Tutor[Nombre]":
                case "Pais_de_Origen_TutorNombre":
                    return "Pais.Nombre";
                case "Originario_de_T":
                    return "Detalle_de_Datos_Generales.Originario_de_T";
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
                case "Localidad_del_Tutor[Descripcion]":
                case "Localidad_del_TutorDescripcion":
                    return "Localidad.Descripcion";
                case "Colonia_del_Tutor[Nombre]":
                case "Colonia_del_TutorNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_Tutor":
                    return "Detalle_de_Datos_Generales.Codigo_Postal_del_Tutor";
                case "Calle_del_Tutor":
                    return "Detalle_de_Datos_Generales.Calle_del_Tutor";
                case "Numero_Exterior_del_Tutor":
                    return "Detalle_de_Datos_Generales.Numero_Exterior_del_Tutor";
                case "Numero_Interior_del_Tutor":
                    return "Detalle_de_Datos_Generales.Numero_Interior_del_Tutor";
                case "Referencia_de_Domicilio_Tutor":
                    return "Detalle_de_Datos_Generales.Referencia_de_Domicilio_Tutor";
                case "Latitud_Tutor":
                    return "Detalle_de_Datos_Generales.Latitud_Tutor";
                case "Longitud_Tutor":
                    return "Detalle_de_Datos_Generales.Longitud_Tutor";
                case "Telefono_del_Tutor":
                    return "Detalle_de_Datos_Generales.Telefono_del_Tutor";
                case "Extension_del_Tutor":
                    return "Detalle_de_Datos_Generales.Extension_del_Tutor";
                case "Celular_del_Tutor":
                    return "Detalle_de_Datos_Generales.Celular_del_Tutor";
                case "Correo_Electronico_del_Tutor":
                    return "Detalle_de_Datos_Generales.Correo_Electronico_del_Tutor";
                case "Nombres2":
                    return "Detalle_de_Datos_Generales.Nombres2";
                case "Apellido_Paterno2":
                    return "Detalle_de_Datos_Generales.Apellido_Paterno2";
                case "Apellido_Materno2":
                    return "Detalle_de_Datos_Generales.Apellido_Materno2";
                case "Nombre_Completo2":
                    return "Detalle_de_Datos_Generales.Nombre_Completo2";
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
                    return "Detalle_de_Datos_Generales.ID_Estado_Institucion";
                case "Titulo_del_Hecho":
                    return "Detalle_de_Datos_Generales.Titulo_del_Hecho";
                case "Narrativa_Breve_de_los_Hechos":
                    return "Detalle_de_Datos_Generales.Narrativa_Breve_de_los_Hechos";
                case "Prioridad_del_Hecho[Descripcion]":
                case "Prioridad_del_HechoDescripcion":
                    return "Prioridad_del_Hecho.Descripcion";
                case "Fecha_del_Hecho":
                    return "Detalle_de_Datos_Generales.Fecha_del_Hecho";
                case "Hora_Aproximada_del_Hecho":
                    return "Detalle_de_Datos_Generales.Hora_Aproximada_del_Hecho";
                case "Pais_del_hecho[Nombre]":
                case "Pais_del_hechoNombre":
                    return "Pais.Nombre";
                case "Estado_del_Hecho[Nombre]":
                case "Estado_del_HechoNombre":
                    return "Estado.Nombre";
                case "Municipio_de_los_Hechos[Nombre]":
                case "Municipio_de_los_HechosNombre":
                    return "Municipio.Nombre";
                case "Poblacion_Hechos[Nombre]":
                case "Poblacion_HechosNombre":
                    return "Colonia.Nombre";
                case "Colonia_de_los_Hechos[Nombre]":
                case "Colonia_de_los_HechosNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_de_los_Hechos":
                    return "Detalle_de_Datos_Generales.Codigo_Postal_de_los_Hechos";
                case "Calle_de_los_Hechos":
                    return "Detalle_de_Datos_Generales.Calle_de_los_Hechos";
                case "Entre_Calle_de_los_Hechos":
                    return "Detalle_de_Datos_Generales.Entre_Calle_de_los_Hechos";
                case "Y_calle_de_los_hechos":
                    return "Detalle_de_Datos_Generales.Y_calle_de_los_hechos";
                case "Numero_Exterior_de_los_Hechos":
                    return "Detalle_de_Datos_Generales.Numero_Exterior_de_los_Hechos";
                case "Numero_Interior_de_los_Hechos":
                    return "Detalle_de_Datos_Generales.Numero_Interior_de_los_Hechos";
                case "Referencia_Hechos":
                    return "Detalle_de_Datos_Generales.Referencia_Hechos";
                case "Latitud_de_los_Hechos":
                    return "Detalle_de_Datos_Generales.Latitud_de_los_Hechos";
                case "Longitud_de_los_Hechos":
                    return "Detalle_de_Datos_Generales.Longitud_de_los_Hechos";
                case "Documento_Extraviado":
                    return "Detalle_de_Datos_Generales.Documento_Extraviado";
                case "Tipo_de_Documento_Extraviado[Descripcion]":
                case "Tipo_de_Documento_ExtraviadoDescripcion":
                    return "Documento_Extraviado.Descripcion";
                case "Tipo_de_lugar_del_hecho[Descripcion]":
                case "Tipo_de_lugar_del_hechoDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "Peso":
                    return "Detalle_de_Datos_Generales.Peso";
                case "Estatura":
                    return "Detalle_de_Datos_Generales.Estatura";
                case "Padecimiento_de_Enfermedad":
                    return "Detalle_de_Datos_Generales.Padecimiento_de_Enfermedad";
                case "Forma_Cara[Descripcion]":
                case "Forma_CaraDescripcion":
                    return "Forma_Cara.Descripcion";
                case "Tipo_de_Cejas[Descripcion]":
                case "Tipo_de_CejasDescripcion":
                    return "Cejas.Descripcion";
                case "Tamano_de_Cejas[Descripcion]":
                case "Tamano_de_CejasDescripcion":
                    return "Tamano_de_Cejas.Descripcion";
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
                case "Largo_de_Cabello[Descripcion]":
                case "Largo_de_CabelloDescripcion":
                    return "Largo_de_Cabello.Descripcion";
                case "Color_Cabello[Descripcion]":
                case "Color_CabelloDescripcion":
                    return "Color_de_Cabello.Descripcion";
                case "Calvicie[Descripcion]":
                case "CalvicieDescripcion":
                    return "Calvicie.Descripcion";
                case "Color_Ojos[Descripcion]":
                case "Color_OjosDescripcion":
                    return "Color_Ojos.Descripcion";
                case "Tamano_de_Ojos[Descripcion]":
                case "Tamano_de_OjosDescripcion":
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
                case "Tamano_Nariz[Descripcion]":
                case "Tamano_NarizDescripcion":
                    return "Tamano_de_Nariz.Descripcion";
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
                    return "Detalle_de_Datos_Generales.Otras_Senas_Particulares";
                case "Causal[Descripcion]":
                case "CausalDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Causa_de_Interrupcion[Descripcion]":
                case "Causa_de_InterrupcionDescripcion":
                    return "Causas_de_Interrupcion.Descripcion";
                case "Datos_Insuficientes[Descripcion]":
                case "Datos_InsuficientesDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Actualizacion_de_Sobreseimiento":
                    return "Detalle_de_Datos_Generales.Actualizacion_de_Sobreseimiento";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Datos_Generales).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Datos_Confidenciales")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Se_Informo_sobre_el_Procedimiento")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Persona_Moral")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Q_Q_R_O_")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Es_victima")
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
            if (columnName == "Situacion_de_Vulnerabilidad")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Incompleto")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Incapaz")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Se_Informaron_sobre_sus_Derechos")
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
            if (columnName == "Documento_Extraviado")
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

