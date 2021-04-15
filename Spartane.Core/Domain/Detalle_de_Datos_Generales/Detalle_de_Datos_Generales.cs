using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Corporacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Grupo_al_que_Pertenece;
using Spartane.Core.Domain.Preferencia_Sexual;
using Spartane.Core.Domain.Etnia;
using Spartane.Core.Domain.Religion;
using Spartane.Core.Domain.Servicio_Medico;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Especialidad;
using Spartane.Core.Domain.Estudios_Superiores;
using Spartane.Core.Domain.Idioma;
using Spartane.Core.Domain.Calidad_Migratoria;
using Spartane.Core.Domain.Dialecto;
using Spartane.Core.Domain.Estado_de_Involucrado;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;
using Spartane.Core.Domain.Discapacidades_Mentales;
using Spartane.Core.Domain.Discapacidades_Fisicas;
using Spartane.Core.Domain.Discapacidades_Sensoriales;
using Spartane.Core.Domain.Discapacidades_Psicosociales;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Documento_Extraviado;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Forma_Cara;
using Spartane.Core.Domain.Cejas;
using Spartane.Core.Domain.Tamano_de_Cejas;
using Spartane.Core.Domain.Cantidad_Cabello;
using Spartane.Core.Domain.Implantacion_Cabello;
using Spartane.Core.Domain.Complexion;
using Spartane.Core.Domain.Color_Piel;
using Spartane.Core.Domain.Frente;
using Spartane.Core.Domain.Largo_de_Cabello;
using Spartane.Core.Domain.Forma_Cabello;
using Spartane.Core.Domain.Color_de_Cabello;
using Spartane.Core.Domain.Calvicie;
using Spartane.Core.Domain.Color_Ojos;
using Spartane.Core.Domain.Ojos;
using Spartane.Core.Domain.Forma_Ojos;
using Spartane.Core.Domain.Anteojos;
using Spartane.Core.Domain.Forma_de_Nariz;
using Spartane.Core.Domain.Tamano_de_Nariz;
using Spartane.Core.Domain.Labios;
using Spartane.Core.Domain.Boca;
using Spartane.Core.Domain.Grosor_de_Labios;
using Spartane.Core.Domain.Menton;
using Spartane.Core.Domain.Forma_de_Menton;
using Spartane.Core.Domain.Barba;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Tamano_Orejas;
using Spartane.Core.Domain.Tipo_Lobulo;
using Spartane.Core.Domain.Bigote;
using Spartane.Core.Domain.Senas_Particulares;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Situacion_Fisica;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Causas_de_Interrupcion;
using Spartane.Core.Domain.A_Tiempo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Datos_Generales
{
    /// <summary>
    /// Detalle_de_Datos_Generales table
    /// </summary>
    public class Detalle_de_Datos_Generales: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public int? Expediente_MP { get; set; }
        public int? Expediente_MASC { get; set; }
        public bool? Datos_Confidenciales { get; set; }
        public bool? Se_Informo_sobre_el_Procedimiento { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public bool? Persona_Desaparecida { get; set; }
        public bool? Persona_Aparecio { get; set; }
        public DateTime? Fecha_de_Aparicion { get; set; }
        public short? Con_Vida { get; set; }
        public bool? Persona_Moral { get; set; }
        public bool? Q_Q_R_O_ { get; set; }
        public bool? Es_victima { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public int? Ocupacion { get; set; }
        public string Calidad_Juridica { get; set; }
        public string Razon_Social { get; set; }
        public int? Nacionalidad { get; set; }
        public int? Municipio_Corporacion { get; set; }
        public int? Corporacion { get; set; }
        public int? Pais_de_Nacimiento { get; set; }
        public int? Estado_de_Nacimiento { get; set; }
        public int? Municipio_de_Nacimiento { get; set; }
        public string Originario_de { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia_de_Domicilio { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Telefono { get; set; }
        public short? Extension { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool? Situacion_de_Vulnerabilidad { get; set; }
        public int? Grupo_al_que_pertenece { get; set; }
        public int? Preferencia_Sexual { get; set; }
        public int? Etnia { get; set; }
        public short? No_de_Hijos { get; set; }
        public short? Religion { get; set; }
        public int? Servicio_Medico { get; set; }
        public short? Escolaridad { get; set; }
        public short? Escolaridad_ { get; set; }
        public int? Especialidad { get; set; }
        public int? Estudios_Superiores { get; set; }
        public bool? Incompleto { get; set; }
        public int? Idioma { get; set; }
        public int? Calidad_Migratoria { get; set; }
        public int? Dialecto { get; set; }
        public int? Estado_de_Involucrado { get; set; }
        public bool? Incapaz { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public string Especifique { get; set; }
        public bool? Se_Informaron_sobre_sus_Derechos { get; set; }
        public bool? Gravidez { get; set; }
        public int? Discapacidad_Mental { get; set; }
        public int? Discapacidad_Fisica { get; set; }
        public int? Discapacidad_Sensorial { get; set; }
        public int? Discapacidad_Psicosocial { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Nombre_Completo_del_Tutor { get; set; }
        public DateTime? Fecha_de_Nacimiento_del_Tutor { get; set; }
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public string CURP_Tutor { get; set; }
        public string RFC_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public int? Pais_de_Origen_Tutor { get; set; }
        public string Originario_de_T { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Poblacion_Tutor { get; set; }
        public int? Localidad_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public string Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Referencia_de_Domicilio_Tutor { get; set; }
        public string Latitud_Tutor { get; set; }
        public string Longitud_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public int? Extension_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public string Nombres2 { get; set; }
        public string Apellido_Paterno2 { get; set; }
        public string Apellido_Materno2 { get; set; }
        public string Nombre_Completo2 { get; set; }
        public int? Sexo2 { get; set; }
        public int? Nacionalidad2 { get; set; }
        public short? Escolaridad2 { get; set; }
        public string ID_Estado_Institucion { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_del_hecho { get; set; }
        public int? Estado_del_Hecho { get; set; }
        public int? Municipio_de_los_Hechos { get; set; }
        public int? Poblacion_Hechos { get; set; }
        public int? Colonia_de_los_Hechos { get; set; }
        public int? Codigo_Postal_de_los_Hechos { get; set; }
        public string Calle_de_los_Hechos { get; set; }
        public string Entre_Calle_de_los_Hechos { get; set; }
        public string Y_calle_de_los_hechos { get; set; }
        public string Numero_Exterior_de_los_Hechos { get; set; }
        public string Numero_Interior_de_los_Hechos { get; set; }
        public string Referencia_Hechos { get; set; }
        public string Latitud_de_los_Hechos { get; set; }
        public string Longitud_de_los_Hechos { get; set; }
        public bool? Documento_Extraviado { get; set; }
        public int? Tipo_de_Documento_Extraviado { get; set; }
        public int? Tipo_de_lugar_del_hecho { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }
        public string Padecimiento_de_Enfermedad { get; set; }
        public int? Forma_Cara { get; set; }
        public int? Tipo_de_Cejas { get; set; }
        public int? Tamano_de_Cejas { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public int? Complexion { get; set; }
        public int? Color_Piel { get; set; }
        public int? Frente { get; set; }
        public int? Largo_de_Cabello { get; set; }
        public int? Forma_de_Cabello { get; set; }
        public int? Color_Cabello { get; set; }
        public int? Calvicie { get; set; }
        public int? Color_Ojos { get; set; }
        public int? Tamano_de_Ojos { get; set; }
        public int? Forma_Ojos { get; set; }
        public int? Anteojos { get; set; }
        public int? Forma_de_Nariz { get; set; }
        public int? Tamano_Nariz { get; set; }
        public int? Labios { get; set; }
        public int? Boca { get; set; }
        public int? Grosor_de_Labios { get; set; }
        public int? Menton { get; set; }
        public int? Forma_de_Menton { get; set; }
        public int? Barba { get; set; }
        public int? Forma_Orejas { get; set; }
        public int? Tamano_Orejas { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public int? Bigote { get; set; }
        public int? Senas_Particulares { get; set; }
        public int? Imagen_Tatuaje { get; set; }
        public string Imagen_Tatuaje_URL { get; set; }
        public int? Situacion_Fisica { get; set; }
        public string Otras_Senas_Particulares { get; set; }
        public short? Causal { get; set; }
        public int? Causa_de_Interrupcion { get; set; }
        public short? Datos_Insuficientes { get; set; }
        public string Actualizacion_de_Sobreseimiento { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Expediente_MASC")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Expediente_MASC_Solicitud { get; set; }
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Con_Vida")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Con_Vida_A_Tiempo { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Estado_Civil")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Ocupacion")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_Ocupacion { get; set; }
        [ForeignKey("Nacionalidad")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Nacionalidad { get; set; }
        [ForeignKey("Municipio_Corporacion")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Corporacion_Municipio { get; set; }
        [ForeignKey("Corporacion")]
        public virtual Spartane.Core.Domain.Corporacion.Corporacion Corporacion_Corporacion { get; set; }
        [ForeignKey("Pais_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Nacimiento_Pais { get; set; }
        [ForeignKey("Estado_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_Nacimiento_Estado { get; set; }
        [ForeignKey("Municipio_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Nacimiento_Municipio { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Grupo_al_que_pertenece")]
        public virtual Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece Grupo_al_que_pertenece_Grupo_al_que_Pertenece { get; set; }
        [ForeignKey("Preferencia_Sexual")]
        public virtual Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual Preferencia_Sexual_Preferencia_Sexual { get; set; }
        [ForeignKey("Etnia")]
        public virtual Spartane.Core.Domain.Etnia.Etnia Etnia_Etnia { get; set; }
        [ForeignKey("Religion")]
        public virtual Spartane.Core.Domain.Religion.Religion Religion_Religion { get; set; }
        [ForeignKey("Servicio_Medico")]
        public virtual Spartane.Core.Domain.Servicio_Medico.Servicio_Medico Servicio_Medico_Servicio_Medico { get; set; }
        [ForeignKey("Escolaridad")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_Escolaridad { get; set; }
        [ForeignKey("Escolaridad_")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad__Escolaridad { get; set; }
        [ForeignKey("Especialidad")]
        public virtual Spartane.Core.Domain.Especialidad.Especialidad Especialidad_Especialidad { get; set; }
        [ForeignKey("Estudios_Superiores")]
        public virtual Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores Estudios_Superiores_Estudios_Superiores { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
        [ForeignKey("Calidad_Migratoria")]
        public virtual Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria Calidad_Migratoria_Calidad_Migratoria { get; set; }
        [ForeignKey("Dialecto")]
        public virtual Spartane.Core.Domain.Dialecto.Dialecto Dialecto_Dialecto { get; set; }
        [ForeignKey("Estado_de_Involucrado")]
        public virtual Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado Estado_de_Involucrado_Estado_de_Involucrado { get; set; }
        [ForeignKey("Tipo_de_Inimputabilidad")]
        public virtual Spartane.Core.Domain.Tipo_de_Inimputabilidad.Tipo_de_Inimputabilidad Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad { get; set; }
        [ForeignKey("Discapacidad_Mental")]
        public virtual Spartane.Core.Domain.Discapacidades_Mentales.Discapacidades_Mentales Discapacidad_Mental_Discapacidades_Mentales { get; set; }
        [ForeignKey("Discapacidad_Fisica")]
        public virtual Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas Discapacidad_Fisica_Discapacidades_Fisicas { get; set; }
        [ForeignKey("Discapacidad_Sensorial")]
        public virtual Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales Discapacidad_Sensorial_Discapacidades_Sensoriales { get; set; }
        [ForeignKey("Discapacidad_Psicosocial")]
        public virtual Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales Discapacidad_Psicosocial_Discapacidades_Psicosociales { get; set; }
        [ForeignKey("Sexo_del_Tutor")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_del_Tutor_Genero { get; set; }
        [ForeignKey("Estado_Civil_del_Tutor")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_del_Tutor_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion_del_Tutor")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_del_Tutor")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_del_Tutor_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad_del_Tutor")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_del_Tutor_Escolaridad { get; set; }
        [ForeignKey("Ocupacion_del_Tutor")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_del_Tutor_Ocupacion { get; set; }
        [ForeignKey("Pais_de_Origen_Tutor")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Origen_Tutor_Pais { get; set; }
        [ForeignKey("Pais_del_Tutor")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_del_Tutor_Pais { get; set; }
        [ForeignKey("Estado_del_Tutor")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Tutor_Estado { get; set; }
        [ForeignKey("Municipio_del_Tutor")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Tutor_Municipio { get; set; }
        [ForeignKey("Poblacion_Tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Tutor_Colonia { get; set; }
        [ForeignKey("Localidad_del_Tutor")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_del_Tutor_Localidad { get; set; }
        [ForeignKey("Colonia_del_Tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Tutor_Colonia { get; set; }
        [ForeignKey("Sexo2")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo2_Genero { get; set; }
        [ForeignKey("Nacionalidad2")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad2_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad2")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad2_Escolaridad { get; set; }
        [ForeignKey("Prioridad_del_Hecho")]
        public virtual Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho Prioridad_del_Hecho_Prioridad_del_Hecho { get; set; }
        [ForeignKey("Pais_del_hecho")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_del_hecho_Pais { get; set; }
        [ForeignKey("Estado_del_Hecho")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Hecho_Estado { get; set; }
        [ForeignKey("Municipio_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_los_Hechos_Municipio { get; set; }
        [ForeignKey("Poblacion_Hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Hechos_Colonia { get; set; }
        [ForeignKey("Colonia_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_los_Hechos_Colonia { get; set; }
        [ForeignKey("Tipo_de_Documento_Extraviado")]
        public virtual Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado Tipo_de_Documento_Extraviado_Documento_Extraviado { get; set; }
        [ForeignKey("Tipo_de_lugar_del_hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_lugar_del_hecho_Lugar_Tipo { get; set; }
        [ForeignKey("Forma_Cara")]
        public virtual Spartane.Core.Domain.Forma_Cara.Forma_Cara Forma_Cara_Forma_Cara { get; set; }
        [ForeignKey("Tipo_de_Cejas")]
        public virtual Spartane.Core.Domain.Cejas.Cejas Tipo_de_Cejas_Cejas { get; set; }
        [ForeignKey("Tamano_de_Cejas")]
        public virtual Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas Tamano_de_Cejas_Tamano_de_Cejas { get; set; }
        [ForeignKey("Cantidad_Cabello")]
        public virtual Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello Cantidad_Cabello_Cantidad_Cabello { get; set; }
        [ForeignKey("Implantacion_Cabello")]
        public virtual Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello Implantacion_Cabello_Implantacion_Cabello { get; set; }
        [ForeignKey("Complexion")]
        public virtual Spartane.Core.Domain.Complexion.Complexion Complexion_Complexion { get; set; }
        [ForeignKey("Color_Piel")]
        public virtual Spartane.Core.Domain.Color_Piel.Color_Piel Color_Piel_Color_Piel { get; set; }
        [ForeignKey("Frente")]
        public virtual Spartane.Core.Domain.Frente.Frente Frente_Frente { get; set; }
        [ForeignKey("Largo_de_Cabello")]
        public virtual Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello Largo_de_Cabello_Largo_de_Cabello { get; set; }
        [ForeignKey("Forma_de_Cabello")]
        public virtual Spartane.Core.Domain.Forma_Cabello.Forma_Cabello Forma_de_Cabello_Forma_Cabello { get; set; }
        [ForeignKey("Color_Cabello")]
        public virtual Spartane.Core.Domain.Color_de_Cabello.Color_de_Cabello Color_Cabello_Color_de_Cabello { get; set; }
        [ForeignKey("Calvicie")]
        public virtual Spartane.Core.Domain.Calvicie.Calvicie Calvicie_Calvicie { get; set; }
        [ForeignKey("Color_Ojos")]
        public virtual Spartane.Core.Domain.Color_Ojos.Color_Ojos Color_Ojos_Color_Ojos { get; set; }
        [ForeignKey("Tamano_de_Ojos")]
        public virtual Spartane.Core.Domain.Ojos.Ojos Tamano_de_Ojos_Ojos { get; set; }
        [ForeignKey("Forma_Ojos")]
        public virtual Spartane.Core.Domain.Forma_Ojos.Forma_Ojos Forma_Ojos_Forma_Ojos { get; set; }
        [ForeignKey("Anteojos")]
        public virtual Spartane.Core.Domain.Anteojos.Anteojos Anteojos_Anteojos { get; set; }
        [ForeignKey("Forma_de_Nariz")]
        public virtual Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz Forma_de_Nariz_Forma_de_Nariz { get; set; }
        [ForeignKey("Tamano_Nariz")]
        public virtual Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz Tamano_Nariz_Tamano_de_Nariz { get; set; }
        [ForeignKey("Labios")]
        public virtual Spartane.Core.Domain.Labios.Labios Labios_Labios { get; set; }
        [ForeignKey("Boca")]
        public virtual Spartane.Core.Domain.Boca.Boca Boca_Boca { get; set; }
        [ForeignKey("Grosor_de_Labios")]
        public virtual Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios Grosor_de_Labios_Grosor_de_Labios { get; set; }
        [ForeignKey("Menton")]
        public virtual Spartane.Core.Domain.Menton.Menton Menton_Menton { get; set; }
        [ForeignKey("Forma_de_Menton")]
        public virtual Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton Forma_de_Menton_Forma_de_Menton { get; set; }
        [ForeignKey("Barba")]
        public virtual Spartane.Core.Domain.Barba.Barba Barba_Barba { get; set; }
        [ForeignKey("Forma_Orejas")]
        public virtual Spartane.Core.Domain.Forma_Orejas.Forma_Orejas Forma_Orejas_Forma_Orejas { get; set; }
        [ForeignKey("Tamano_Orejas")]
        public virtual Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas Tamano_Orejas_Tamano_Orejas { get; set; }
        [ForeignKey("Tipo_Lobulo")]
        public virtual Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo Tipo_Lobulo_Tipo_Lobulo { get; set; }
        [ForeignKey("Bigote")]
        public virtual Spartane.Core.Domain.Bigote.Bigote Bigote_Bigote { get; set; }
        [ForeignKey("Senas_Particulares")]
        public virtual Spartane.Core.Domain.Senas_Particulares.Senas_Particulares Senas_Particulares_Senas_Particulares { get; set; }
        [ForeignKey("Imagen_Tatuaje")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Imagen_Tatuaje_Spartane_File { get; set; }
        [ForeignKey("Situacion_Fisica")]
        public virtual Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica Situacion_Fisica_Situacion_Fisica { get; set; }
        [ForeignKey("Causal")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Causal_A_Tiempo { get; set; }
        [ForeignKey("Causa_de_Interrupcion")]
        public virtual Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion Causa_de_Interrupcion_Causas_de_Interrupcion { get; set; }
        [ForeignKey("Datos_Insuficientes")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Datos_Insuficientes_A_Tiempo { get; set; }

    }
	
	public class Detalle_de_Datos_Generales_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public int? Expediente_MP { get; set; }
        public int? Expediente_MASC { get; set; }
        public bool? Datos_Confidenciales { get; set; }
        public bool? Se_Informo_sobre_el_Procedimiento { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public bool? Persona_Desaparecida { get; set; }
        public bool? Persona_Aparecio { get; set; }
        public DateTime? Fecha_de_Aparicion { get; set; }
        public short? Con_Vida { get; set; }
        public bool? Persona_Moral { get; set; }
        public bool? Q_Q_R_O_ { get; set; }
        public bool? Es_victima { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public int? Ocupacion { get; set; }
        public string Calidad_Juridica { get; set; }
        public string Razon_Social { get; set; }
        public int? Nacionalidad { get; set; }
        public int? Municipio_Corporacion { get; set; }
        public int? Corporacion { get; set; }
        public int? Pais_de_Nacimiento { get; set; }
        public int? Estado_de_Nacimiento { get; set; }
        public int? Municipio_de_Nacimiento { get; set; }
        public string Originario_de { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia_de_Domicilio { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Telefono { get; set; }
        public short? Extension { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool? Situacion_de_Vulnerabilidad { get; set; }
        public int? Grupo_al_que_pertenece { get; set; }
        public int? Preferencia_Sexual { get; set; }
        public int? Etnia { get; set; }
        public short? No_de_Hijos { get; set; }
        public short? Religion { get; set; }
        public int? Servicio_Medico { get; set; }
        public short? Escolaridad { get; set; }
        public short? Escolaridad_ { get; set; }
        public int? Especialidad { get; set; }
        public int? Estudios_Superiores { get; set; }
        public bool? Incompleto { get; set; }
        public int? Idioma { get; set; }
        public int? Calidad_Migratoria { get; set; }
        public int? Dialecto { get; set; }
        public int? Estado_de_Involucrado { get; set; }
        public bool? Incapaz { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public string Especifique { get; set; }
        public bool? Se_Informaron_sobre_sus_Derechos { get; set; }
        public bool? Gravidez { get; set; }
        public int? Discapacidad_Mental { get; set; }
        public int? Discapacidad_Fisica { get; set; }
        public int? Discapacidad_Sensorial { get; set; }
        public int? Discapacidad_Psicosocial { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Expediente_MASC")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Expediente_MASC_Solicitud { get; set; }
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Con_Vida")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Con_Vida_A_Tiempo { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Estado_Civil")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Ocupacion")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_Ocupacion { get; set; }
        [ForeignKey("Nacionalidad")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Nacionalidad { get; set; }
        [ForeignKey("Municipio_Corporacion")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Corporacion_Municipio { get; set; }
        [ForeignKey("Corporacion")]
        public virtual Spartane.Core.Domain.Corporacion.Corporacion Corporacion_Corporacion { get; set; }
        [ForeignKey("Pais_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Nacimiento_Pais { get; set; }
        [ForeignKey("Estado_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_Nacimiento_Estado { get; set; }
        [ForeignKey("Municipio_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Nacimiento_Municipio { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Grupo_al_que_pertenece")]
        public virtual Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece Grupo_al_que_pertenece_Grupo_al_que_Pertenece { get; set; }
        [ForeignKey("Preferencia_Sexual")]
        public virtual Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual Preferencia_Sexual_Preferencia_Sexual { get; set; }
        [ForeignKey("Etnia")]
        public virtual Spartane.Core.Domain.Etnia.Etnia Etnia_Etnia { get; set; }
        [ForeignKey("Religion")]
        public virtual Spartane.Core.Domain.Religion.Religion Religion_Religion { get; set; }
        [ForeignKey("Servicio_Medico")]
        public virtual Spartane.Core.Domain.Servicio_Medico.Servicio_Medico Servicio_Medico_Servicio_Medico { get; set; }
        [ForeignKey("Escolaridad")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_Escolaridad { get; set; }
        [ForeignKey("Escolaridad_")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad__Escolaridad { get; set; }
        [ForeignKey("Especialidad")]
        public virtual Spartane.Core.Domain.Especialidad.Especialidad Especialidad_Especialidad { get; set; }
        [ForeignKey("Estudios_Superiores")]
        public virtual Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores Estudios_Superiores_Estudios_Superiores { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
        [ForeignKey("Calidad_Migratoria")]
        public virtual Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria Calidad_Migratoria_Calidad_Migratoria { get; set; }
        [ForeignKey("Dialecto")]
        public virtual Spartane.Core.Domain.Dialecto.Dialecto Dialecto_Dialecto { get; set; }
        [ForeignKey("Estado_de_Involucrado")]
        public virtual Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado Estado_de_Involucrado_Estado_de_Involucrado { get; set; }
        [ForeignKey("Tipo_de_Inimputabilidad")]
        public virtual Spartane.Core.Domain.Tipo_de_Inimputabilidad.Tipo_de_Inimputabilidad Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad { get; set; }
        [ForeignKey("Discapacidad_Mental")]
        public virtual Spartane.Core.Domain.Discapacidades_Mentales.Discapacidades_Mentales Discapacidad_Mental_Discapacidades_Mentales { get; set; }
        [ForeignKey("Discapacidad_Fisica")]
        public virtual Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas Discapacidad_Fisica_Discapacidades_Fisicas { get; set; }
        [ForeignKey("Discapacidad_Sensorial")]
        public virtual Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales Discapacidad_Sensorial_Discapacidades_Sensoriales { get; set; }
        [ForeignKey("Discapacidad_Psicosocial")]
        public virtual Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales Discapacidad_Psicosocial_Discapacidades_Psicosociales { get; set; }

    }

	public class Detalle_de_Datos_Generales_Datos_del_Tutor
    {
                public int Clave { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Nombre_Completo_del_Tutor { get; set; }
        public DateTime? Fecha_de_Nacimiento_del_Tutor { get; set; }
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public string CURP_Tutor { get; set; }
        public string RFC_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public int? Pais_de_Origen_Tutor { get; set; }
        public string Originario_de_T { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Poblacion_Tutor { get; set; }
        public int? Localidad_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public string Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Referencia_de_Domicilio_Tutor { get; set; }
        public string Latitud_Tutor { get; set; }
        public string Longitud_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public int? Extension_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }

		        [ForeignKey("Sexo_del_Tutor")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_del_Tutor_Genero { get; set; }
        [ForeignKey("Estado_Civil_del_Tutor")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_del_Tutor_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion_del_Tutor")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_del_Tutor")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_del_Tutor_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad_del_Tutor")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_del_Tutor_Escolaridad { get; set; }
        [ForeignKey("Ocupacion_del_Tutor")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_del_Tutor_Ocupacion { get; set; }
        [ForeignKey("Pais_de_Origen_Tutor")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Origen_Tutor_Pais { get; set; }
        [ForeignKey("Pais_del_Tutor")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_del_Tutor_Pais { get; set; }
        [ForeignKey("Estado_del_Tutor")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Tutor_Estado { get; set; }
        [ForeignKey("Municipio_del_Tutor")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Tutor_Municipio { get; set; }
        [ForeignKey("Poblacion_Tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Tutor_Colonia { get; set; }
        [ForeignKey("Localidad_del_Tutor")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_del_Tutor_Localidad { get; set; }
        [ForeignKey("Colonia_del_Tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Tutor_Colonia { get; set; }

    }

	public class Detalle_de_Datos_Generales_Representante_Legal
    {
                public int Clave { get; set; }
        public string Nombres2 { get; set; }
        public string Apellido_Paterno2 { get; set; }
        public string Apellido_Materno2 { get; set; }
        public string Nombre_Completo2 { get; set; }
        public int? Sexo2 { get; set; }
        public int? Nacionalidad2 { get; set; }
        public short? Escolaridad2 { get; set; }
        public string ID_Estado_Institucion { get; set; }

		        [ForeignKey("Sexo2")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo2_Genero { get; set; }
        [ForeignKey("Nacionalidad2")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad2_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad2")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad2_Escolaridad { get; set; }

    }

	public class Detalle_de_Datos_Generales_Datos_de_los_Hechos
    {
                public int Clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_del_hecho { get; set; }
        public int? Estado_del_Hecho { get; set; }
        public int? Municipio_de_los_Hechos { get; set; }
        public int? Poblacion_Hechos { get; set; }
        public int? Colonia_de_los_Hechos { get; set; }
        public int? Codigo_Postal_de_los_Hechos { get; set; }
        public string Calle_de_los_Hechos { get; set; }
        public string Entre_Calle_de_los_Hechos { get; set; }
        public string Y_calle_de_los_hechos { get; set; }
        public string Numero_Exterior_de_los_Hechos { get; set; }
        public string Numero_Interior_de_los_Hechos { get; set; }
        public string Referencia_Hechos { get; set; }
        public string Latitud_de_los_Hechos { get; set; }
        public string Longitud_de_los_Hechos { get; set; }
        public bool? Documento_Extraviado { get; set; }
        public int? Tipo_de_Documento_Extraviado { get; set; }
        public int? Tipo_de_lugar_del_hecho { get; set; }

		        [ForeignKey("Prioridad_del_Hecho")]
        public virtual Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho Prioridad_del_Hecho_Prioridad_del_Hecho { get; set; }
        [ForeignKey("Pais_del_hecho")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_del_hecho_Pais { get; set; }
        [ForeignKey("Estado_del_Hecho")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Hecho_Estado { get; set; }
        [ForeignKey("Municipio_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_los_Hechos_Municipio { get; set; }
        [ForeignKey("Poblacion_Hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Hechos_Colonia { get; set; }
        [ForeignKey("Colonia_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_los_Hechos_Colonia { get; set; }
        [ForeignKey("Tipo_de_Documento_Extraviado")]
        public virtual Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado Tipo_de_Documento_Extraviado_Documento_Extraviado { get; set; }
        [ForeignKey("Tipo_de_lugar_del_hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_lugar_del_hecho_Lugar_Tipo { get; set; }

    }

	public class Detalle_de_Datos_Generales_Datos_de_Media_Filiacion
    {
                public int Clave { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }
        public string Padecimiento_de_Enfermedad { get; set; }
        public int? Forma_Cara { get; set; }
        public int? Tipo_de_Cejas { get; set; }
        public int? Tamano_de_Cejas { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public int? Complexion { get; set; }
        public int? Color_Piel { get; set; }
        public int? Frente { get; set; }
        public int? Largo_de_Cabello { get; set; }
        public int? Forma_de_Cabello { get; set; }
        public int? Color_Cabello { get; set; }
        public int? Calvicie { get; set; }
        public int? Color_Ojos { get; set; }
        public int? Tamano_de_Ojos { get; set; }
        public int? Forma_Ojos { get; set; }
        public int? Anteojos { get; set; }
        public int? Forma_de_Nariz { get; set; }
        public int? Tamano_Nariz { get; set; }
        public int? Labios { get; set; }
        public int? Boca { get; set; }
        public int? Grosor_de_Labios { get; set; }
        public int? Menton { get; set; }
        public int? Forma_de_Menton { get; set; }
        public int? Barba { get; set; }
        public int? Forma_Orejas { get; set; }
        public int? Tamano_Orejas { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public int? Bigote { get; set; }
        public int? Senas_Particulares { get; set; }
        public int? Imagen_Tatuaje { get; set; }
        public string Imagen_Tatuaje_URL { get; set; }
        public int? Situacion_Fisica { get; set; }
        public string Otras_Senas_Particulares { get; set; }

		        [ForeignKey("Forma_Cara")]
        public virtual Spartane.Core.Domain.Forma_Cara.Forma_Cara Forma_Cara_Forma_Cara { get; set; }
        [ForeignKey("Tipo_de_Cejas")]
        public virtual Spartane.Core.Domain.Cejas.Cejas Tipo_de_Cejas_Cejas { get; set; }
        [ForeignKey("Tamano_de_Cejas")]
        public virtual Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas Tamano_de_Cejas_Tamano_de_Cejas { get; set; }
        [ForeignKey("Cantidad_Cabello")]
        public virtual Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello Cantidad_Cabello_Cantidad_Cabello { get; set; }
        [ForeignKey("Implantacion_Cabello")]
        public virtual Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello Implantacion_Cabello_Implantacion_Cabello { get; set; }
        [ForeignKey("Complexion")]
        public virtual Spartane.Core.Domain.Complexion.Complexion Complexion_Complexion { get; set; }
        [ForeignKey("Color_Piel")]
        public virtual Spartane.Core.Domain.Color_Piel.Color_Piel Color_Piel_Color_Piel { get; set; }
        [ForeignKey("Frente")]
        public virtual Spartane.Core.Domain.Frente.Frente Frente_Frente { get; set; }
        [ForeignKey("Largo_de_Cabello")]
        public virtual Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello Largo_de_Cabello_Largo_de_Cabello { get; set; }
        [ForeignKey("Forma_de_Cabello")]
        public virtual Spartane.Core.Domain.Forma_Cabello.Forma_Cabello Forma_de_Cabello_Forma_Cabello { get; set; }
        [ForeignKey("Color_Cabello")]
        public virtual Spartane.Core.Domain.Color_de_Cabello.Color_de_Cabello Color_Cabello_Color_de_Cabello { get; set; }
        [ForeignKey("Calvicie")]
        public virtual Spartane.Core.Domain.Calvicie.Calvicie Calvicie_Calvicie { get; set; }
        [ForeignKey("Color_Ojos")]
        public virtual Spartane.Core.Domain.Color_Ojos.Color_Ojos Color_Ojos_Color_Ojos { get; set; }
        [ForeignKey("Tamano_de_Ojos")]
        public virtual Spartane.Core.Domain.Ojos.Ojos Tamano_de_Ojos_Ojos { get; set; }
        [ForeignKey("Forma_Ojos")]
        public virtual Spartane.Core.Domain.Forma_Ojos.Forma_Ojos Forma_Ojos_Forma_Ojos { get; set; }
        [ForeignKey("Anteojos")]
        public virtual Spartane.Core.Domain.Anteojos.Anteojos Anteojos_Anteojos { get; set; }
        [ForeignKey("Forma_de_Nariz")]
        public virtual Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz Forma_de_Nariz_Forma_de_Nariz { get; set; }
        [ForeignKey("Tamano_Nariz")]
        public virtual Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz Tamano_Nariz_Tamano_de_Nariz { get; set; }
        [ForeignKey("Labios")]
        public virtual Spartane.Core.Domain.Labios.Labios Labios_Labios { get; set; }
        [ForeignKey("Boca")]
        public virtual Spartane.Core.Domain.Boca.Boca Boca_Boca { get; set; }
        [ForeignKey("Grosor_de_Labios")]
        public virtual Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios Grosor_de_Labios_Grosor_de_Labios { get; set; }
        [ForeignKey("Menton")]
        public virtual Spartane.Core.Domain.Menton.Menton Menton_Menton { get; set; }
        [ForeignKey("Forma_de_Menton")]
        public virtual Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton Forma_de_Menton_Forma_de_Menton { get; set; }
        [ForeignKey("Barba")]
        public virtual Spartane.Core.Domain.Barba.Barba Barba_Barba { get; set; }
        [ForeignKey("Forma_Orejas")]
        public virtual Spartane.Core.Domain.Forma_Orejas.Forma_Orejas Forma_Orejas_Forma_Orejas { get; set; }
        [ForeignKey("Tamano_Orejas")]
        public virtual Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas Tamano_Orejas_Tamano_Orejas { get; set; }
        [ForeignKey("Tipo_Lobulo")]
        public virtual Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo Tipo_Lobulo_Tipo_Lobulo { get; set; }
        [ForeignKey("Bigote")]
        public virtual Spartane.Core.Domain.Bigote.Bigote Bigote_Bigote { get; set; }
        [ForeignKey("Senas_Particulares")]
        public virtual Spartane.Core.Domain.Senas_Particulares.Senas_Particulares Senas_Particulares_Senas_Particulares { get; set; }
        [ForeignKey("Imagen_Tatuaje")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Imagen_Tatuaje_Spartane_File { get; set; }
        [ForeignKey("Situacion_Fisica")]
        public virtual Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica Situacion_Fisica_Situacion_Fisica { get; set; }

    }

	public class Detalle_de_Datos_Generales_Desestimacion
    {
                public int Clave { get; set; }
        public short? Causal { get; set; }
        public int? Causa_de_Interrupcion { get; set; }
        public short? Datos_Insuficientes { get; set; }
        public string Actualizacion_de_Sobreseimiento { get; set; }

		        [ForeignKey("Causal")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Causal_A_Tiempo { get; set; }
        [ForeignKey("Causa_de_Interrupcion")]
        public virtual Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion Causa_de_Interrupcion_Causas_de_Interrupcion { get; set; }
        [ForeignKey("Datos_Insuficientes")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Datos_Insuficientes_A_Tiempo { get; set; }

    }


}

