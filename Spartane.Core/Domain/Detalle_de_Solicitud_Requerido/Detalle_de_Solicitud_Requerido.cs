using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Corporacion;
using Spartane.Core.Domain.Etnia;
using Spartane.Core.Domain.Religion;
using Spartane.Core.Domain.Servicio_Medico;
using Spartane.Core.Domain.Especialidad;
using Spartane.Core.Domain.Estudios_Superiores;
using Spartane.Core.Domain.Idioma;
using Spartane.Core.Domain.Calidad_Migratoria;
using Spartane.Core.Domain.Dialecto;
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
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Cejas;
using Spartane.Core.Domain.Tamano_de_Cejas;
using Spartane.Core.Domain.Anteojos;
using Spartane.Core.Domain.Forma_de_Nariz;
using Spartane.Core.Domain.Nariz_Base;
using Spartane.Core.Domain.Grosor_de_Labios;
using Spartane.Core.Domain.Forma_de_Menton;
using Spartane.Core.Domain.Senas_Particulares;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitud_Requerido
{
    /// <summary>
    /// Detalle_de_Solicitud_Requerido table
    /// </summary>
    public class Detalle_de_Solicitud_Requerido: BaseEntity
    {
        public int Clave { get; set; }
        public int? idRegistroAT { get; set; }
        public int? idRegistroUI { get; set; }
        public int? Solicitud { get; set; }
        public bool? A_Quien_Sea_Responsable { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Apodo { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Referencia_de_Domicilio_Requerido { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Telefono { get; set; }
        public string Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais_de_Origen { get; set; }
        public string Originario_de { get; set; }
        public int? Estado_de_Nacimiento { get; set; }
        public int? Municipio_de_Nacimiento { get; set; }
        public bool? Inimputable { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public bool? Se_Presenta_con_Detenido { get; set; }
        public string Folio_Registro_Nacional_de_Detenciones { get; set; }
        public DateTime? Fecha_de_Detencion { get; set; }
        public int? Municipio_de_Detencion { get; set; }
        public int? Corporacion { get; set; }
        public bool? Suspension_Condicional { get; set; }
        public DateTime? Fecha_de_Suspension_Condicional { get; set; }
        public string Lugar_donde_se_Encuentra_Detenido { get; set; }
        public int? Etnia { get; set; }
        public short? No__de_Hijos { get; set; }
        public short? Religion { get; set; }
        public int? Servicio_Medico { get; set; }
        public int? Especialidad { get; set; }
        public int? Estudios_Superiores { get; set; }
        public int? Idioma { get; set; }
        public int? Calidad_Migratoria { get; set; }
        public int? Dialecto { get; set; }
        public bool? Viene_en_Estado_de_Ebriedad { get; set; }
        public bool? Bajo_el_Efecto_de_una_Droga { get; set; }
        public string Nombre_de_Droga { get; set; }
        public int? Discapacidad_Mental { get; set; }
        public int? Discapacidad_Fisica { get; set; }
        public int? Discapacidad_Sensorial { get; set; }
        public int? Discapacidad_Psicosocial { get; set; }
        public string Nombre_de_Tutor { get; set; }
        public string Apellido_Paterno_Tutor { get; set; }
        public string Apellido_Materno_Tutor { get; set; }
        public string Nombre_Completo_Tutor { get; set; }
        public DateTime? Fecha_de_Nacimiento_tutor { get; set; }
        public short? Edad_tutor { get; set; }
        public int? Sexo_tutor { get; set; }
        public int? Estado_Civil_tutor { get; set; }
        public int? Tipo_de_Identificacion_tutor { get; set; }
        public string Numero_de_Identificacion_tutor { get; set; }
        public int? Nacionalidad_tutor { get; set; }
        public short? Escolaridad_tutor { get; set; }
        public int? Ocupacion_tutor { get; set; }
        public int? Pais_tutor { get; set; }
        public int? Estado_tutor { get; set; }
        public int? Municipio_tutor { get; set; }
        public int? Poblacion_tutor { get; set; }
        public int? Colonia_tutor { get; set; }
        public int? Codigo_Postal_tutor { get; set; }
        public string Calle_tutor { get; set; }
        public string Numero_Exterior_tutor { get; set; }
        public string Numero_Interior_tutor { get; set; }
        public string Referencia { get; set; }
        public string Latitud_tutor { get; set; }
        public string Longitud_tutor { get; set; }
        public string Extension_tutor { get; set; }
        public string Celular_tutor { get; set; }
        public string Correo_Electronico_tutor { get; set; }
        public int? Pais_de_Origen_Tutor { get; set; }
        public string Originario_de_Tutor { get; set; }
        public string CURP_Tutor { get; set; }
        public string RFC_Tutor { get; set; }
        public string Padecimiento_de_Enfermedad { get; set; }
        public int? Cejas { get; set; }
        public int? Tamano_de_Cejas { get; set; }
        public int? Anteojos { get; set; }
        public int? Forma_de_Nariz { get; set; }
        public int? Nariz_base { get; set; }
        public int? Grosor_de_Labios { get; set; }
        public int? Forma_de_Menton { get; set; }
        public int? Senas_Particulares { get; set; }
        public int? Imagen_Tatuaje { get; set; }
        public string Imagen_Tatuaje_URL { get; set; }
        public string Otras_Senas_Particulares { get; set; }
        public string Imputado_Recluido { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Estado_Civil")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_Escolaridad { get; set; }
        [ForeignKey("Ocupacion")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_Ocupacion { get; set; }
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
        [ForeignKey("Pais_de_Origen")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Origen_Pais { get; set; }
        [ForeignKey("Estado_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_Nacimiento_Estado { get; set; }
        [ForeignKey("Municipio_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Nacimiento_Municipio { get; set; }
        [ForeignKey("Tipo_de_Inimputabilidad")]
        public virtual Spartane.Core.Domain.Tipo_de_Inimputabilidad.Tipo_de_Inimputabilidad Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad { get; set; }
        [ForeignKey("Municipio_de_Detencion")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Detencion_Municipio { get; set; }
        [ForeignKey("Corporacion")]
        public virtual Spartane.Core.Domain.Corporacion.Corporacion Corporacion_Corporacion { get; set; }
        [ForeignKey("Etnia")]
        public virtual Spartane.Core.Domain.Etnia.Etnia Etnia_Etnia { get; set; }
        [ForeignKey("Religion")]
        public virtual Spartane.Core.Domain.Religion.Religion Religion_Religion { get; set; }
        [ForeignKey("Servicio_Medico")]
        public virtual Spartane.Core.Domain.Servicio_Medico.Servicio_Medico Servicio_Medico_Servicio_Medico { get; set; }
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
        [ForeignKey("Discapacidad_Mental")]
        public virtual Spartane.Core.Domain.Discapacidades_Mentales.Discapacidades_Mentales Discapacidad_Mental_Discapacidades_Mentales { get; set; }
        [ForeignKey("Discapacidad_Fisica")]
        public virtual Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas Discapacidad_Fisica_Discapacidades_Fisicas { get; set; }
        [ForeignKey("Discapacidad_Sensorial")]
        public virtual Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales Discapacidad_Sensorial_Discapacidades_Sensoriales { get; set; }
        [ForeignKey("Discapacidad_Psicosocial")]
        public virtual Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales Discapacidad_Psicosocial_Discapacidades_Psicosociales { get; set; }
        [ForeignKey("Sexo_tutor")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_tutor_Genero { get; set; }
        [ForeignKey("Estado_Civil_tutor")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_tutor_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion_tutor")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_tutor_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_tutor")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_tutor_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad_tutor")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_tutor_Escolaridad { get; set; }
        [ForeignKey("Ocupacion_tutor")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_tutor_Ocupacion { get; set; }
        [ForeignKey("Pais_tutor")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_tutor_Pais { get; set; }
        [ForeignKey("Estado_tutor")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_tutor_Estado { get; set; }
        [ForeignKey("Municipio_tutor")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_tutor_Municipio { get; set; }
        [ForeignKey("Poblacion_tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_tutor_Colonia { get; set; }
        [ForeignKey("Colonia_tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_tutor_Colonia { get; set; }
        [ForeignKey("Pais_de_Origen_Tutor")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Origen_Tutor_Pais { get; set; }
        [ForeignKey("Cejas")]
        public virtual Spartane.Core.Domain.Cejas.Cejas Cejas_Cejas { get; set; }
        [ForeignKey("Tamano_de_Cejas")]
        public virtual Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas Tamano_de_Cejas_Tamano_de_Cejas { get; set; }
        [ForeignKey("Anteojos")]
        public virtual Spartane.Core.Domain.Anteojos.Anteojos Anteojos_Anteojos { get; set; }
        [ForeignKey("Forma_de_Nariz")]
        public virtual Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz Forma_de_Nariz_Forma_de_Nariz { get; set; }
        [ForeignKey("Nariz_base")]
        public virtual Spartane.Core.Domain.Nariz_Base.Nariz_Base Nariz_base_Nariz_Base { get; set; }
        [ForeignKey("Grosor_de_Labios")]
        public virtual Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios Grosor_de_Labios_Grosor_de_Labios { get; set; }
        [ForeignKey("Forma_de_Menton")]
        public virtual Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton Forma_de_Menton_Forma_de_Menton { get; set; }
        [ForeignKey("Senas_Particulares")]
        public virtual Spartane.Core.Domain.Senas_Particulares.Senas_Particulares Senas_Particulares_Senas_Particulares { get; set; }
        [ForeignKey("Imagen_Tatuaje")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Imagen_Tatuaje_Spartane_File { get; set; }

    }
	
	public class Detalle_de_Solicitud_Requerido_Datos_Generales
    {
                public int Clave { get; set; }
        public int? idRegistroAT { get; set; }
        public int? idRegistroUI { get; set; }
        public int? Solicitud { get; set; }
        public bool? A_Quien_Sea_Responsable { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Apodo { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Referencia_de_Domicilio_Requerido { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Telefono { get; set; }
        public string Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais_de_Origen { get; set; }
        public string Originario_de { get; set; }
        public int? Estado_de_Nacimiento { get; set; }
        public int? Municipio_de_Nacimiento { get; set; }
        public bool? Inimputable { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public bool? Se_Presenta_con_Detenido { get; set; }
        public string Folio_Registro_Nacional_de_Detenciones { get; set; }
        public DateTime? Fecha_de_Detencion { get; set; }
        public int? Municipio_de_Detencion { get; set; }
        public int? Corporacion { get; set; }
        public bool? Suspension_Condicional { get; set; }
        public DateTime? Fecha_de_Suspension_Condicional { get; set; }
        public string Lugar_donde_se_Encuentra_Detenido { get; set; }
        public int? Etnia { get; set; }
        public short? No__de_Hijos { get; set; }
        public short? Religion { get; set; }
        public int? Servicio_Medico { get; set; }
        public int? Especialidad { get; set; }
        public int? Estudios_Superiores { get; set; }
        public int? Idioma { get; set; }
        public int? Calidad_Migratoria { get; set; }
        public int? Dialecto { get; set; }
        public bool? Viene_en_Estado_de_Ebriedad { get; set; }
        public bool? Bajo_el_Efecto_de_una_Droga { get; set; }
        public string Nombre_de_Droga { get; set; }
        public int? Discapacidad_Mental { get; set; }
        public int? Discapacidad_Fisica { get; set; }
        public int? Discapacidad_Sensorial { get; set; }
        public int? Discapacidad_Psicosocial { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Estado_Civil")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_Escolaridad { get; set; }
        [ForeignKey("Ocupacion")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_Ocupacion { get; set; }
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
        [ForeignKey("Pais_de_Origen")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Origen_Pais { get; set; }
        [ForeignKey("Estado_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_Nacimiento_Estado { get; set; }
        [ForeignKey("Municipio_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Nacimiento_Municipio { get; set; }
        [ForeignKey("Tipo_de_Inimputabilidad")]
        public virtual Spartane.Core.Domain.Tipo_de_Inimputabilidad.Tipo_de_Inimputabilidad Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad { get; set; }
        [ForeignKey("Municipio_de_Detencion")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Detencion_Municipio { get; set; }
        [ForeignKey("Corporacion")]
        public virtual Spartane.Core.Domain.Corporacion.Corporacion Corporacion_Corporacion { get; set; }
        [ForeignKey("Etnia")]
        public virtual Spartane.Core.Domain.Etnia.Etnia Etnia_Etnia { get; set; }
        [ForeignKey("Religion")]
        public virtual Spartane.Core.Domain.Religion.Religion Religion_Religion { get; set; }
        [ForeignKey("Servicio_Medico")]
        public virtual Spartane.Core.Domain.Servicio_Medico.Servicio_Medico Servicio_Medico_Servicio_Medico { get; set; }
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
        [ForeignKey("Discapacidad_Mental")]
        public virtual Spartane.Core.Domain.Discapacidades_Mentales.Discapacidades_Mentales Discapacidad_Mental_Discapacidades_Mentales { get; set; }
        [ForeignKey("Discapacidad_Fisica")]
        public virtual Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas Discapacidad_Fisica_Discapacidades_Fisicas { get; set; }
        [ForeignKey("Discapacidad_Sensorial")]
        public virtual Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales Discapacidad_Sensorial_Discapacidades_Sensoriales { get; set; }
        [ForeignKey("Discapacidad_Psicosocial")]
        public virtual Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales Discapacidad_Psicosocial_Discapacidades_Psicosociales { get; set; }

    }

	public class Detalle_de_Solicitud_Requerido_Datos_del_Tutor
    {
                public int Clave { get; set; }
        public string Nombre_de_Tutor { get; set; }
        public string Apellido_Paterno_Tutor { get; set; }
        public string Apellido_Materno_Tutor { get; set; }
        public string Nombre_Completo_Tutor { get; set; }
        public DateTime? Fecha_de_Nacimiento_tutor { get; set; }
        public short? Edad_tutor { get; set; }
        public int? Sexo_tutor { get; set; }
        public int? Estado_Civil_tutor { get; set; }
        public int? Tipo_de_Identificacion_tutor { get; set; }
        public string Numero_de_Identificacion_tutor { get; set; }
        public int? Nacionalidad_tutor { get; set; }
        public short? Escolaridad_tutor { get; set; }
        public int? Ocupacion_tutor { get; set; }
        public int? Pais_tutor { get; set; }
        public int? Estado_tutor { get; set; }
        public int? Municipio_tutor { get; set; }
        public int? Poblacion_tutor { get; set; }
        public int? Colonia_tutor { get; set; }
        public int? Codigo_Postal_tutor { get; set; }
        public string Calle_tutor { get; set; }
        public string Numero_Exterior_tutor { get; set; }
        public string Numero_Interior_tutor { get; set; }
        public string Referencia { get; set; }
        public string Latitud_tutor { get; set; }
        public string Longitud_tutor { get; set; }
        public string Extension_tutor { get; set; }
        public string Celular_tutor { get; set; }
        public string Correo_Electronico_tutor { get; set; }
        public int? Pais_de_Origen_Tutor { get; set; }
        public string Originario_de_Tutor { get; set; }
        public string CURP_Tutor { get; set; }
        public string RFC_Tutor { get; set; }

		        [ForeignKey("Sexo_tutor")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_tutor_Genero { get; set; }
        [ForeignKey("Estado_Civil_tutor")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_tutor_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion_tutor")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_tutor_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_tutor")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_tutor_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad_tutor")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_tutor_Escolaridad { get; set; }
        [ForeignKey("Ocupacion_tutor")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_tutor_Ocupacion { get; set; }
        [ForeignKey("Pais_tutor")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_tutor_Pais { get; set; }
        [ForeignKey("Estado_tutor")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_tutor_Estado { get; set; }
        [ForeignKey("Municipio_tutor")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_tutor_Municipio { get; set; }
        [ForeignKey("Poblacion_tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_tutor_Colonia { get; set; }
        [ForeignKey("Colonia_tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_tutor_Colonia { get; set; }
        [ForeignKey("Pais_de_Origen_Tutor")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Origen_Tutor_Pais { get; set; }

    }

	public class Detalle_de_Solicitud_Requerido_Datos_de_Media_Filiacion
    {
                public int Clave { get; set; }
        public string Padecimiento_de_Enfermedad { get; set; }
        public int? Cejas { get; set; }
        public int? Tamano_de_Cejas { get; set; }
        public int? Anteojos { get; set; }
        public int? Forma_de_Nariz { get; set; }
        public int? Nariz_base { get; set; }
        public int? Grosor_de_Labios { get; set; }
        public int? Forma_de_Menton { get; set; }
        public int? Senas_Particulares { get; set; }
        public int? Imagen_Tatuaje { get; set; }
        public string Imagen_Tatuaje_URL { get; set; }
        public string Otras_Senas_Particulares { get; set; }
        public string Imputado_Recluido { get; set; }

		        [ForeignKey("Cejas")]
        public virtual Spartane.Core.Domain.Cejas.Cejas Cejas_Cejas { get; set; }
        [ForeignKey("Tamano_de_Cejas")]
        public virtual Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas Tamano_de_Cejas_Tamano_de_Cejas { get; set; }
        [ForeignKey("Anteojos")]
        public virtual Spartane.Core.Domain.Anteojos.Anteojos Anteojos_Anteojos { get; set; }
        [ForeignKey("Forma_de_Nariz")]
        public virtual Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz Forma_de_Nariz_Forma_de_Nariz { get; set; }
        [ForeignKey("Nariz_base")]
        public virtual Spartane.Core.Domain.Nariz_Base.Nariz_Base Nariz_base_Nariz_Base { get; set; }
        [ForeignKey("Grosor_de_Labios")]
        public virtual Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios Grosor_de_Labios_Grosor_de_Labios { get; set; }
        [ForeignKey("Forma_de_Menton")]
        public virtual Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton Forma_de_Menton_Forma_de_Menton { get; set; }
        [ForeignKey("Senas_Particulares")]
        public virtual Spartane.Core.Domain.Senas_Particulares.Senas_Particulares Senas_Particulares_Senas_Particulares { get; set; }
        [ForeignKey("Imagen_Tatuaje")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Imagen_Tatuaje_Spartane_File { get; set; }

    }


}

