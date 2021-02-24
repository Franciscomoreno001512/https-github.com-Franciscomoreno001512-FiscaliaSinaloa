using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Institucion_Emisora;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Juzgado;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Tipo_de_Orden;
using Spartane.Core.Domain.Ambito;
using Spartane.Core.Domain.Juzgado;
using Spartane.Core.Domain.Especialidad_MP;
using Spartane.Core.Domain.Tipo_de_Cuantia;
using Spartane.Core.Domain.Forma_Cara;
using Spartane.Core.Domain.Cejas;
using Spartane.Core.Domain.Cantidad_Cabello;
using Spartane.Core.Domain.Implantacion_Cabello;
using Spartane.Core.Domain.Complexion;
using Spartane.Core.Domain.Color_Piel;
using Spartane.Core.Domain.Frente;
using Spartane.Core.Domain.Forma_Cabello;
using Spartane.Core.Domain.Color_de_Cabello;
using Spartane.Core.Domain.Calvicie;
using Spartane.Core.Domain.Color_Ojos;
using Spartane.Core.Domain.Ojos;
using Spartane.Core.Domain.Forma_Ojos;
using Spartane.Core.Domain.Nariz_Base;
using Spartane.Core.Domain.Labios;
using Spartane.Core.Domain.Boca;
using Spartane.Core.Domain.Menton;
using Spartane.Core.Domain.Barba;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Tamano_Orejas;
using Spartane.Core.Domain.Tipo_Lobulo;
using Spartane.Core.Domain.Bigote;
using Spartane.Core.Domain.Situacion_Fisica;
using Spartane.Core.Domain.Fuerzo;
using Spartane.Core.Domain.Tipo_de_Mandamiento;
using Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso;
using Spartane.Core.Domain.Tipo_de_Proceso;
using Spartane.Core.Domain.Tipo_de_Extradiccion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Registro_de_Mandamiento_Judicial
{
    /// <summary>
    /// Registro_de_Mandamiento_Judicial table
    /// </summary>
    public class Registro_de_Mandamiento_Judicial: BaseEntity
    {
        public int Clave { get; set; }
        public string Folio_de_la_Orden_de_Aprehension { get; set; }
        public int? Pais_al_que_Pertenece_la_Informacion { get; set; }
        public int? Estado_que_Envia_la_Informacion { get; set; }
        public int? Municipio_que_Envia_la_Informacion { get; set; }
        public int? Institucion_que_Remite { get; set; }
        public int? Entidad_que_Emite_Mandamiento { get; set; }
        public int? Juzgado_que_Emitio_Mandamiento { get; set; }
        public string Numero_de_Mandamiento { get; set; }
        public string Oficio_de_Juzgado { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public short? Estatura { get; set; }
        public short? Peso { get; set; }
        public bool? Usa_Anteojos { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Pais_de_Nacimiento { get; set; }
        public int? Estado_de_Nacimiento { get; set; }
        public int? Tipo_de_Orden { get; set; }
        public DateTime? Fecha_de_Orden { get; set; }
        public string Hora_de_Orden { get; set; }
        public string Dirigida_Por { get; set; }
        public int? Ambito { get; set; }
        public int? Juzgado { get; set; }
        public string Juez { get; set; }
        public int? Especialidad { get; set; }
        public string Numero_de_Causa { get; set; }
        public DateTime? Fecha_de_Oficio { get; set; }
        public int? Tipo_de_Cuantia { get; set; }
        public string Observaciones { get; set; }
        public int? Forma_Cara { get; set; }
        public int? Cejas { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public int? Complexion { get; set; }
        public int? Color_Piel { get; set; }
        public int? Frente { get; set; }
        public int? Forma_Cabello { get; set; }
        public int? Color_Cabello { get; set; }
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
        public DateTime? Fecha_de_Libramiento { get; set; }
        public int? Fuerzo { get; set; }
        public int? Tipo_Mandato { get; set; }
        public string Numero_de_Proceso_Judicial { get; set; }
        public string Numero_de_Averiguacion { get; set; }
        public DateTime? Fecha_de_Captura { get; set; }
        public DateTime? Fecha_de_Recepcion { get; set; }
        public DateTime? Fecha_de_Prescripcion { get; set; }
        public DateTime? Fecha_de_Cumplimiento { get; set; }
        public string Oficio_de_Cumplimiento { get; set; }
        public DateTime? Fecha_de_Cancelacion { get; set; }
        public int? Motivo_de_Cancelacion { get; set; }
        public string Oficio_de_Cancelacion { get; set; }
        public int? Tipo_de_Proceso { get; set; }
        public int? Proceso_de_Extradiccion { get; set; }
        public string Observacionesx { get; set; }
        public int? Huellas_Digitales { get; set; }
        public int? Mano_Izquierda_dedos { get; set; }
        public int? Mano_Derecha_Pulgar { get; set; }
        public int? Mano_Derecha_Dedos { get; set; }

        [ForeignKey("Pais_al_que_Pertenece_la_Informacion")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_al_que_Pertenece_la_Informacion_Pais { get; set; }
        [ForeignKey("Estado_que_Envia_la_Informacion")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_que_Envia_la_Informacion_Estado { get; set; }
        [ForeignKey("Municipio_que_Envia_la_Informacion")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_que_Envia_la_Informacion_Municipio { get; set; }
        [ForeignKey("Institucion_que_Remite")]
        public virtual Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora Institucion_que_Remite_Institucion_Emisora { get; set; }
        [ForeignKey("Entidad_que_Emite_Mandamiento")]
        public virtual Spartane.Core.Domain.Estado.Estado Entidad_que_Emite_Mandamiento_Estado { get; set; }
        [ForeignKey("Juzgado_que_Emitio_Mandamiento")]
        public virtual Spartane.Core.Domain.Juzgado.Juzgado Juzgado_que_Emitio_Mandamiento_Juzgado { get; set; }
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
        [ForeignKey("Pais_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Nacimiento_Pais { get; set; }
        [ForeignKey("Estado_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_Nacimiento_Estado { get; set; }
        [ForeignKey("Tipo_de_Orden")]
        public virtual Spartane.Core.Domain.Tipo_de_Orden.Tipo_de_Orden Tipo_de_Orden_Tipo_de_Orden { get; set; }
        [ForeignKey("Ambito")]
        public virtual Spartane.Core.Domain.Ambito.Ambito Ambito_Ambito { get; set; }
        [ForeignKey("Juzgado")]
        public virtual Spartane.Core.Domain.Juzgado.Juzgado Juzgado_Juzgado { get; set; }
        [ForeignKey("Especialidad")]
        public virtual Spartane.Core.Domain.Especialidad_MP.Especialidad_MP Especialidad_Especialidad_MP { get; set; }
        [ForeignKey("Tipo_de_Cuantia")]
        public virtual Spartane.Core.Domain.Tipo_de_Cuantia.Tipo_de_Cuantia Tipo_de_Cuantia_Tipo_de_Cuantia { get; set; }
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
        [ForeignKey("Color_Cabello")]
        public virtual Spartane.Core.Domain.Color_de_Cabello.Color_de_Cabello Color_Cabello_Color_de_Cabello { get; set; }
        [ForeignKey("Calvicie")]
        public virtual Spartane.Core.Domain.Calvicie.Calvicie Calvicie_Calvicie { get; set; }
        [ForeignKey("Color_Ojos")]
        public virtual Spartane.Core.Domain.Color_Ojos.Color_Ojos Color_Ojos_Color_Ojos { get; set; }
        [ForeignKey("Ojos")]
        public virtual Spartane.Core.Domain.Ojos.Ojos Ojos_Ojos { get; set; }
        [ForeignKey("Forma_Ojos")]
        public virtual Spartane.Core.Domain.Forma_Ojos.Forma_Ojos Forma_Ojos_Forma_Ojos { get; set; }
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
        public virtual Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas Tamano_Orejas_Tamano_Orejas { get; set; }
        [ForeignKey("Tipo_Lobulo")]
        public virtual Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo Tipo_Lobulo_Tipo_Lobulo { get; set; }
        [ForeignKey("Bigote")]
        public virtual Spartane.Core.Domain.Bigote.Bigote Bigote_Bigote { get; set; }
        [ForeignKey("Situacion_Fisica")]
        public virtual Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica Situacion_Fisica_Situacion_Fisica { get; set; }
        [ForeignKey("Fuerzo")]
        public virtual Spartane.Core.Domain.Fuerzo.Fuerzo Fuerzo_Fuerzo { get; set; }
        [ForeignKey("Tipo_Mandato")]
        public virtual Spartane.Core.Domain.Tipo_de_Mandamiento.Tipo_de_Mandamiento Tipo_Mandato_Tipo_de_Mandamiento { get; set; }
        [ForeignKey("Motivo_de_Cancelacion")]
        public virtual Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso { get; set; }
        [ForeignKey("Tipo_de_Proceso")]
        public virtual Spartane.Core.Domain.Tipo_de_Proceso.Tipo_de_Proceso Tipo_de_Proceso_Tipo_de_Proceso { get; set; }
        [ForeignKey("Proceso_de_Extradiccion")]
        public virtual Spartane.Core.Domain.Tipo_de_Extradiccion.Tipo_de_Extradiccion Proceso_de_Extradiccion_Tipo_de_Extradiccion { get; set; }

    }
	
	public class Registro_de_Mandamiento_Judicial_Datos_Generales
    {
                public int Clave { get; set; }
        public string Folio_de_la_Orden_de_Aprehension { get; set; }
        public int? Pais_al_que_Pertenece_la_Informacion { get; set; }
        public int? Estado_que_Envia_la_Informacion { get; set; }
        public int? Municipio_que_Envia_la_Informacion { get; set; }
        public int? Institucion_que_Remite { get; set; }
        public int? Entidad_que_Emite_Mandamiento { get; set; }
        public int? Juzgado_que_Emitio_Mandamiento { get; set; }
        public string Numero_de_Mandamiento { get; set; }
        public string Oficio_de_Juzgado { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public short? Estatura { get; set; }
        public short? Peso { get; set; }
        public bool? Usa_Anteojos { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Pais_de_Nacimiento { get; set; }
        public int? Estado_de_Nacimiento { get; set; }

		        [ForeignKey("Pais_al_que_Pertenece_la_Informacion")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_al_que_Pertenece_la_Informacion_Pais { get; set; }
        [ForeignKey("Estado_que_Envia_la_Informacion")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_que_Envia_la_Informacion_Estado { get; set; }
        [ForeignKey("Municipio_que_Envia_la_Informacion")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_que_Envia_la_Informacion_Municipio { get; set; }
        [ForeignKey("Institucion_que_Remite")]
        public virtual Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora Institucion_que_Remite_Institucion_Emisora { get; set; }
        [ForeignKey("Entidad_que_Emite_Mandamiento")]
        public virtual Spartane.Core.Domain.Estado.Estado Entidad_que_Emite_Mandamiento_Estado { get; set; }
        [ForeignKey("Juzgado_que_Emitio_Mandamiento")]
        public virtual Spartane.Core.Domain.Juzgado.Juzgado Juzgado_que_Emitio_Mandamiento_Juzgado { get; set; }
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
        [ForeignKey("Pais_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Nacimiento_Pais { get; set; }
        [ForeignKey("Estado_de_Nacimiento")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_Nacimiento_Estado { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_Domicilio
    {
                public int Clave { get; set; }

		
    }

	public class Registro_de_Mandamiento_Judicial_Telefonos
    {
                public int Clave { get; set; }

		
    }

	public class Registro_de_Mandamiento_Judicial_Otros_Nombres
    {
                public int Clave { get; set; }

		
    }

	public class Registro_de_Mandamiento_Judicial_Datos_de_la_Orden
    {
                public int Clave { get; set; }
        public int? Tipo_de_Orden { get; set; }
        public DateTime? Fecha_de_Orden { get; set; }
        public string Hora_de_Orden { get; set; }
        public string Dirigida_Por { get; set; }
        public int? Ambito { get; set; }
        public int? Juzgado { get; set; }
        public string Juez { get; set; }
        public int? Especialidad { get; set; }
        public string Numero_de_Causa { get; set; }
        public DateTime? Fecha_de_Oficio { get; set; }
        public int? Tipo_de_Cuantia { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Tipo_de_Orden")]
        public virtual Spartane.Core.Domain.Tipo_de_Orden.Tipo_de_Orden Tipo_de_Orden_Tipo_de_Orden { get; set; }
        [ForeignKey("Ambito")]
        public virtual Spartane.Core.Domain.Ambito.Ambito Ambito_Ambito { get; set; }
        [ForeignKey("Juzgado")]
        public virtual Spartane.Core.Domain.Juzgado.Juzgado Juzgado_Juzgado { get; set; }
        [ForeignKey("Especialidad")]
        public virtual Spartane.Core.Domain.Especialidad_MP.Especialidad_MP Especialidad_Especialidad_MP { get; set; }
        [ForeignKey("Tipo_de_Cuantia")]
        public virtual Spartane.Core.Domain.Tipo_de_Cuantia.Tipo_de_Cuantia Tipo_de_Cuantia_Tipo_de_Cuantia { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_Delito
    {
                public int Clave { get; set; }

		
    }

	public class Registro_de_Mandamiento_Judicial_Amparo
    {
                public int Clave { get; set; }

		
    }

	public class Registro_de_Mandamiento_Judicial_Media_Filiacion
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
        public int? Color_Cabello { get; set; }
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
        [ForeignKey("Color_Cabello")]
        public virtual Spartane.Core.Domain.Color_de_Cabello.Color_de_Cabello Color_Cabello_Color_de_Cabello { get; set; }
        [ForeignKey("Calvicie")]
        public virtual Spartane.Core.Domain.Calvicie.Calvicie Calvicie_Calvicie { get; set; }
        [ForeignKey("Color_Ojos")]
        public virtual Spartane.Core.Domain.Color_Ojos.Color_Ojos Color_Ojos_Color_Ojos { get; set; }
        [ForeignKey("Ojos")]
        public virtual Spartane.Core.Domain.Ojos.Ojos Ojos_Ojos { get; set; }
        [ForeignKey("Forma_Ojos")]
        public virtual Spartane.Core.Domain.Forma_Ojos.Forma_Ojos Forma_Ojos_Forma_Ojos { get; set; }
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
        public virtual Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas Tamano_Orejas_Tamano_Orejas { get; set; }
        [ForeignKey("Tipo_Lobulo")]
        public virtual Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo Tipo_Lobulo_Tipo_Lobulo { get; set; }
        [ForeignKey("Bigote")]
        public virtual Spartane.Core.Domain.Bigote.Bigote Bigote_Bigote { get; set; }
        [ForeignKey("Situacion_Fisica")]
        public virtual Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica Situacion_Fisica_Situacion_Fisica { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_Proceso
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Libramiento { get; set; }
        public int? Fuerzo { get; set; }
        public int? Tipo_Mandato { get; set; }
        public string Numero_de_Proceso_Judicial { get; set; }
        public string Numero_de_Averiguacion { get; set; }
        public DateTime? Fecha_de_Captura { get; set; }
        public DateTime? Fecha_de_Recepcion { get; set; }
        public DateTime? Fecha_de_Prescripcion { get; set; }
        public DateTime? Fecha_de_Cumplimiento { get; set; }
        public string Oficio_de_Cumplimiento { get; set; }
        public DateTime? Fecha_de_Cancelacion { get; set; }
        public int? Motivo_de_Cancelacion { get; set; }
        public string Oficio_de_Cancelacion { get; set; }
        public int? Tipo_de_Proceso { get; set; }
        public int? Proceso_de_Extradiccion { get; set; }
        public string Observacionesx { get; set; }

		        [ForeignKey("Fuerzo")]
        public virtual Spartane.Core.Domain.Fuerzo.Fuerzo Fuerzo_Fuerzo { get; set; }
        [ForeignKey("Tipo_Mandato")]
        public virtual Spartane.Core.Domain.Tipo_de_Mandamiento.Tipo_de_Mandamiento Tipo_Mandato_Tipo_de_Mandamiento { get; set; }
        [ForeignKey("Motivo_de_Cancelacion")]
        public virtual Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso { get; set; }
        [ForeignKey("Tipo_de_Proceso")]
        public virtual Spartane.Core.Domain.Tipo_de_Proceso.Tipo_de_Proceso Tipo_de_Proceso_Tipo_de_Proceso { get; set; }
        [ForeignKey("Proceso_de_Extradiccion")]
        public virtual Spartane.Core.Domain.Tipo_de_Extradiccion.Tipo_de_Extradiccion Proceso_de_Extradiccion_Tipo_de_Extradiccion { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_Fotos
    {
                public int Clave { get; set; }

		
    }

	public class Registro_de_Mandamiento_Judicial_Documentos
    {
                public int Clave { get; set; }

		
    }

	public class Registro_de_Mandamiento_Judicial_Huellas_Digitales
    {
                public int Clave { get; set; }
        public int? Huellas_Digitales { get; set; }
        public int? Mano_Izquierda_dedos { get; set; }
        public int? Mano_Derecha_Pulgar { get; set; }
        public int? Mano_Derecha_Dedos { get; set; }

		
    }


}

