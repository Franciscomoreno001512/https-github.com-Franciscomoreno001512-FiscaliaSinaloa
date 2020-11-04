using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Forma_Cara;
using Spartane.Core.Domain.Cejas;
using Spartane.Core.Domain.Cantidad_Cabello;
using Spartane.Core.Domain.Implantacion_Cabello;
using Spartane.Core.Domain.Complexion;
using Spartane.Core.Domain.Color_Piel;
using Spartane.Core.Domain.Frente;
using Spartane.Core.Domain.Forma_Cabello;
using Spartane.Core.Domain.Calvicie;
using Spartane.Core.Domain.Color_Ojos;
using Spartane.Core.Domain.Ojos;
using Spartane.Core.Domain.Froma_Ojos;
using Spartane.Core.Domain.Nariz_Base;
using Spartane.Core.Domain.Labios;
using Spartane.Core.Domain.Boca;
using Spartane.Core.Domain.Menton;
using Spartane.Core.Domain.Barba;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Tipo_Lobulo;
using Spartane.Core.Domain.Bigote;
using Spartane.Core.Domain.Situacion_Fisica;
using Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI;
using Spartane.Core.Domain.Medidas_Cautelares;
using Spartane.Core.Domain.Medidas_Cautelares;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Lugar_Tipo;
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
using Spartane.Core.Domain.Expediente_Inicial;
using Spartane.Core.Domain.Estatus_del_Imputado;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI
{
    /// <summary>
    /// Detalle_de_Datos_del_Imputado_MPI table
    /// </summary>
    public class Detalle_de_Datos_del_Imputado_MPI: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Localidad { get; set; }
        public int? Colonia { get; set; }
        public string Calle_del_Imputado { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais { get; set; }
        public int? Forma_Cara { get; set; }
        public int? Cejas { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public int? Complexion { get; set; }
        public int? Color_Piel { get; set; }
        public int? Frente { get; set; }
        public int? Forma_Cabello { get; set; }
        public int? Calvicie { get; set; }
        public int? Color_Ojos { get; set; }
        public int? Ojos { get; set; }
        public int? Forma_Ojos { get; set; }
        public int? Nariz_Base { get; set; }
        public int? Labios { get; set; }
        public int? Boca { get; set; }
        public int? Menton { get; set; }
        public int? Barba { get; set; }
        public int? Forma_Orejas { get; set; }
        public int? Tamano_Orejas { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public int? Bigote { get; set; }
        public int? Situacion_Fisica { get; set; }
        public string Alias_media_diliacion { get; set; }
        public DateTime? Fecha_de_Detencion { get; set; }
        public string Hora_de_Detencion { get; set; }
        public DateTime? Fecha_de_Puesto_a_Disposicion { get; set; }
        public string Hora_de_Puesto_a_Disposicion { get; set; }
        public int? Con_Detenido { get; set; }
        public bool? A_Quien_Resulte_Responsable { get; set; }
        public string Tiempo_Restante_para_Vinculacion { get; set; }
        public bool? Vincular { get; set; }
        public int? Medidas_Cautelares { get; set; }
        public string Solicitar_Prorroga { get; set; }
        public string Nuevo_Plazo { get; set; }
        public bool? Orden_de_Aprehension { get; set; }
        public int? Medidas_Cautelares_en_Imputado { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_del_Hecho { get; set; }
        public int? Estado_del_Hecho { get; set; }
        public int? Municipio_del_Hecho { get; set; }
        public int? Colonia_del_Hecho { get; set; }
        public int? Codigo_Postal_del_Hecho { get; set; }
        public string Calle_del_Hecho { get; set; }
        public string Entre_Calle_del_Hecho { get; set; }
        public string Y_Calle_del_Hecho { get; set; }
        public string Numero_Exterior_del_Hecho { get; set; }
        public string Numero_Interior_del_Hecho { get; set; }
        public string Latitud_del_Hecho { get; set; }
        public decimal? Longitud_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public bool? Incapaz { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public DateTime? Fecha_de_Nacimiento_del_Tutor { get; set; }
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public string Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public short? Extension_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public bool? Proteccion_de_Datos { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }
        public int? Estatus { get; set; }
        public bool? Judicializar { get; set; }

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
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Localidad")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_Localidad { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Forma_Cara")]
        public virtual Spartane.Core.Domain.Forma_Cara.Forma_Cara Forma_Cara_Forma_Cara { get; set; }
        [ForeignKey("Cejas")]
        public virtual Spartane.Core.Domain.Cejas.Cejas Cejas_Cejas { get; set; }
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
        [ForeignKey("Forma_Cabello")]
        public virtual Spartane.Core.Domain.Forma_Cabello.Forma_Cabello Forma_Cabello_Forma_Cabello { get; set; }
        [ForeignKey("Calvicie")]
        public virtual Spartane.Core.Domain.Calvicie.Calvicie Calvicie_Calvicie { get; set; }
        [ForeignKey("Color_Ojos")]
        public virtual Spartane.Core.Domain.Color_Ojos.Color_Ojos Color_Ojos_Color_Ojos { get; set; }
        [ForeignKey("Ojos")]
        public virtual Spartane.Core.Domain.Ojos.Ojos Ojos_Ojos { get; set; }
        [ForeignKey("Forma_Ojos")]
        public virtual Spartane.Core.Domain.Froma_Ojos.Froma_Ojos Forma_Ojos_Froma_Ojos { get; set; }
        [ForeignKey("Nariz_Base")]
        public virtual Spartane.Core.Domain.Nariz_Base.Nariz_Base Nariz_Base_Nariz_Base { get; set; }
        [ForeignKey("Labios")]
        public virtual Spartane.Core.Domain.Labios.Labios Labios_Labios { get; set; }
        [ForeignKey("Boca")]
        public virtual Spartane.Core.Domain.Boca.Boca Boca_Boca { get; set; }
        [ForeignKey("Menton")]
        public virtual Spartane.Core.Domain.Menton.Menton Menton_Menton { get; set; }
        [ForeignKey("Barba")]
        public virtual Spartane.Core.Domain.Barba.Barba Barba_Barba { get; set; }
        [ForeignKey("Forma_Orejas")]
        public virtual Spartane.Core.Domain.Forma_Orejas.Forma_Orejas Forma_Orejas_Forma_Orejas { get; set; }
        [ForeignKey("Tamano_Orejas")]
        public virtual Spartane.Core.Domain.Forma_Orejas.Forma_Orejas Tamano_Orejas_Forma_Orejas { get; set; }
        [ForeignKey("Tipo_Lobulo")]
        public virtual Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo Tipo_Lobulo_Tipo_Lobulo { get; set; }
        [ForeignKey("Bigote")]
        public virtual Spartane.Core.Domain.Bigote.Bigote Bigote_Bigote { get; set; }
        [ForeignKey("Situacion_Fisica")]
        public virtual Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica Situacion_Fisica_Situacion_Fisica { get; set; }
        [ForeignKey("Con_Detenido")]
        public virtual Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI Con_Detenido_Catalogo_Estatus_Detenido_MPI { get; set; }
        [ForeignKey("Medidas_Cautelares")]
        public virtual Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares Medidas_Cautelares_Medidas_Cautelares { get; set; }
        [ForeignKey("Medidas_Cautelares_en_Imputado")]
        public virtual Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares Medidas_Cautelares_en_Imputado_Medidas_Cautelares { get; set; }
        [ForeignKey("Prioridad_del_Hecho")]
        public virtual Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho Prioridad_del_Hecho_Prioridad_del_Hecho { get; set; }
        [ForeignKey("Pais_del_Hecho")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_del_Hecho_Pais { get; set; }
        [ForeignKey("Estado_del_Hecho")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Hecho_Estado { get; set; }
        [ForeignKey("Municipio_del_Hecho")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Hecho_Municipio { get; set; }
        [ForeignKey("Colonia_del_Hecho")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Hecho_Colonia { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_Lugar_Tipo { get; set; }
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
        [ForeignKey("Pais_del_Tutor")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_del_Tutor_Pais { get; set; }
        [ForeignKey("Estado_del_Tutor")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Tutor_Estado { get; set; }
        [ForeignKey("Municipio_del_Tutor")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Tutor_Municipio { get; set; }
        [ForeignKey("Colonia_del_Tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Tutor_Colonia { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado Estatus_Estatus_del_Imputado { get; set; }

    }
	
	public class Detalle_de_Datos_del_Imputado_MPI_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Localidad { get; set; }
        public int? Colonia { get; set; }
        public string Calle_del_Imputado { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais { get; set; }
        public string Alias_media_diliacion { get; set; }
        public int? Con_Detenido { get; set; }
        public bool? A_Quien_Resulte_Responsable { get; set; }
        public bool? Orden_de_Aprehension { get; set; }
        public int? Medidas_Cautelares_en_Imputado { get; set; }
        public bool? Incapaz { get; set; }
        public bool? Proteccion_de_Datos { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }
        public int? Estatus { get; set; }

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
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Localidad")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_Localidad { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Con_Detenido")]
        public virtual Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI Con_Detenido_Catalogo_Estatus_Detenido_MPI { get; set; }
        [ForeignKey("Medidas_Cautelares_en_Imputado")]
        public virtual Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares Medidas_Cautelares_en_Imputado_Medidas_Cautelares { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado Estatus_Estatus_del_Imputado { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI__Datos_de_Media_Filiacion
    {
                public int Clave { get; set; }
        public int? Forma_Cara { get; set; }
        public int? Cejas { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public int? Complexion { get; set; }
        public int? Color_Piel { get; set; }
        public int? Frente { get; set; }
        public int? Forma_Cabello { get; set; }
        public int? Calvicie { get; set; }
        public int? Color_Ojos { get; set; }
        public int? Ojos { get; set; }
        public int? Forma_Ojos { get; set; }
        public int? Nariz_Base { get; set; }
        public int? Labios { get; set; }
        public int? Boca { get; set; }
        public int? Menton { get; set; }
        public int? Barba { get; set; }
        public int? Forma_Orejas { get; set; }
        public int? Tamano_Orejas { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public int? Bigote { get; set; }
        public int? Situacion_Fisica { get; set; }

		        [ForeignKey("Forma_Cara")]
        public virtual Spartane.Core.Domain.Forma_Cara.Forma_Cara Forma_Cara_Forma_Cara { get; set; }
        [ForeignKey("Cejas")]
        public virtual Spartane.Core.Domain.Cejas.Cejas Cejas_Cejas { get; set; }
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
        [ForeignKey("Forma_Cabello")]
        public virtual Spartane.Core.Domain.Forma_Cabello.Forma_Cabello Forma_Cabello_Forma_Cabello { get; set; }
        [ForeignKey("Calvicie")]
        public virtual Spartane.Core.Domain.Calvicie.Calvicie Calvicie_Calvicie { get; set; }
        [ForeignKey("Color_Ojos")]
        public virtual Spartane.Core.Domain.Color_Ojos.Color_Ojos Color_Ojos_Color_Ojos { get; set; }
        [ForeignKey("Ojos")]
        public virtual Spartane.Core.Domain.Ojos.Ojos Ojos_Ojos { get; set; }
        [ForeignKey("Forma_Ojos")]
        public virtual Spartane.Core.Domain.Froma_Ojos.Froma_Ojos Forma_Ojos_Froma_Ojos { get; set; }
        [ForeignKey("Nariz_Base")]
        public virtual Spartane.Core.Domain.Nariz_Base.Nariz_Base Nariz_Base_Nariz_Base { get; set; }
        [ForeignKey("Labios")]
        public virtual Spartane.Core.Domain.Labios.Labios Labios_Labios { get; set; }
        [ForeignKey("Boca")]
        public virtual Spartane.Core.Domain.Boca.Boca Boca_Boca { get; set; }
        [ForeignKey("Menton")]
        public virtual Spartane.Core.Domain.Menton.Menton Menton_Menton { get; set; }
        [ForeignKey("Barba")]
        public virtual Spartane.Core.Domain.Barba.Barba Barba_Barba { get; set; }
        [ForeignKey("Forma_Orejas")]
        public virtual Spartane.Core.Domain.Forma_Orejas.Forma_Orejas Forma_Orejas_Forma_Orejas { get; set; }
        [ForeignKey("Tamano_Orejas")]
        public virtual Spartane.Core.Domain.Forma_Orejas.Forma_Orejas Tamano_Orejas_Forma_Orejas { get; set; }
        [ForeignKey("Tipo_Lobulo")]
        public virtual Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo Tipo_Lobulo_Tipo_Lobulo { get; set; }
        [ForeignKey("Bigote")]
        public virtual Spartane.Core.Domain.Bigote.Bigote Bigote_Bigote { get; set; }
        [ForeignKey("Situacion_Fisica")]
        public virtual Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica Situacion_Fisica_Situacion_Fisica { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI_Control_de_Tiempos
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Detencion { get; set; }
        public string Hora_de_Detencion { get; set; }
        public DateTime? Fecha_de_Puesto_a_Disposicion { get; set; }
        public string Hora_de_Puesto_a_Disposicion { get; set; }
        public string Tiempo_Restante_para_Vinculacion { get; set; }
        public bool? Vincular { get; set; }
        public int? Medidas_Cautelares { get; set; }
        public string Solicitar_Prorroga { get; set; }
        public string Nuevo_Plazo { get; set; }
        public bool? Judicializar { get; set; }

		        [ForeignKey("Medidas_Cautelares")]
        public virtual Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares Medidas_Cautelares_Medidas_Cautelares { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI_Datos_de_los_Hechos
    {
                public int Clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_del_Hecho { get; set; }
        public int? Estado_del_Hecho { get; set; }
        public int? Municipio_del_Hecho { get; set; }
        public int? Colonia_del_Hecho { get; set; }
        public int? Codigo_Postal_del_Hecho { get; set; }
        public string Calle_del_Hecho { get; set; }
        public string Entre_Calle_del_Hecho { get; set; }
        public string Y_Calle_del_Hecho { get; set; }
        public string Numero_Exterior_del_Hecho { get; set; }
        public string Numero_Interior_del_Hecho { get; set; }
        public string Latitud_del_Hecho { get; set; }
        public decimal? Longitud_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }

		        [ForeignKey("Prioridad_del_Hecho")]
        public virtual Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho Prioridad_del_Hecho_Prioridad_del_Hecho { get; set; }
        [ForeignKey("Pais_del_Hecho")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_del_Hecho_Pais { get; set; }
        [ForeignKey("Estado_del_Hecho")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Hecho_Estado { get; set; }
        [ForeignKey("Municipio_del_Hecho")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Hecho_Municipio { get; set; }
        [ForeignKey("Colonia_del_Hecho")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Hecho_Colonia { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_Lugar_Tipo { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI_Datos_del_Abogado
    {
                public int Clave { get; set; }

		
    }

	public class Detalle_de_Datos_del_Imputado_MPI_Datos_del_Tutor
    {
                public int Clave { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public DateTime? Fecha_de_Nacimiento_del_Tutor { get; set; }
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public string Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public short? Extension_del_Tutor { get; set; }
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
        [ForeignKey("Pais_del_Tutor")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_del_Tutor_Pais { get; set; }
        [ForeignKey("Estado_del_Tutor")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Tutor_Estado { get; set; }
        [ForeignKey("Municipio_del_Tutor")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Tutor_Municipio { get; set; }
        [ForeignKey("Colonia_del_Tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Tutor_Colonia { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI_Sentencias
    {
                public int Clave { get; set; }

		
    }


}

