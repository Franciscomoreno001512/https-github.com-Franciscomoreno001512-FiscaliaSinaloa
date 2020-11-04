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
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Tipo_de_Compareciente;
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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Datos_de_la_Victima_MPI
{
    /// <summary>
    /// Detalle_de_Datos_de_la_Victima_MPI table
    /// </summary>
    public class Detalle_de_Datos_de_la_Victima_MPI: BaseEntity
    {
        public int Clave { get; set; }
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
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool? Incapaz { get; set; }
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
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Localidad_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public int? Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public int? Extencion_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Narrativa_de_los_Hechos { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos { get; set; }
        public int? Estado_de_los_Hechos { get; set; }
        public int? Municipio_de_los_Hechos { get; set; }
        public int? Colonia_de_los_Hechos { get; set; }
        public int? Codigo_Postal_de_los_Hechos { get; set; }
        public string Calle_de_los_Hechos { get; set; }
        public string Entre_Calle_de_los_Hechos { get; set; }
        public string Y_Calle_de_los_Hechos { get; set; }
        public string Numero_Exterior_de_los_Hechos { get; set; }
        public string Numero_Interior_de_los_Hechos { get; set; }
        public string Latitud_de_los_Hechos { get; set; }
        public string Longitud_de_los_Hechos { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public bool? Proteccion_de_Datos { get; set; }
        public string Nombre_de_Persona_Moral { get; set; }
        public string Apellido_Paterno_de_Persona_Moral { get; set; }
        public string Apellido_Materno_de_Persona_Moral { get; set; }
        public DateTime? Fecha_de_Nacimiento_de_Persona_Moral { get; set; }
        public short? Edad_de_Persona_Moral { get; set; }
        public int? Sexo_de_Persona_Moral { get; set; }
        public int? Estado_Civil_de_Persona_Moral { get; set; }
        public int? Tipo_de_Identificacion_de_Persona_Moral { get; set; }
        public string Numero_de_Identificacion_de_Persona_Mora { get; set; }
        public int? Nacionalidad_de_Persona_Moral { get; set; }
        public short? Escolaridad_de_Persona_Moral { get; set; }
        public int? Ocupacion_de_Persona_Moral { get; set; }
        public int? Pais_de_Persona_Moral { get; set; }
        public int? Estado_de_Persona_Moral { get; set; }
        public int? Municipio_de_Persona_Moral { get; set; }
        public int? Colonia_de_Persona_Moral { get; set; }
        public int? Codigo_Postal_de_Persona_Moral { get; set; }
        public string Calle_de_Persona_Moral { get; set; }
        public string Numero_Exterior_de_Persona_Moral { get; set; }
        public string Numero_Interior_de_Persona_Moral { get; set; }
        public string Entre_Calle_de_Persona_Moral { get; set; }
        public string Y_Calle_de_Persona_Moral { get; set; }
        public string Longitud_de_Persona_Moral { get; set; }
        public string Latitud_de_Persona_Moral { get; set; }
        public string Telefono_de_Persona_Moral { get; set; }
        public string Extension_de_Persona_Moral { get; set; }
        public string Celular_de_Persona_Moral { get; set; }
        public string Correo_Electronico_de_Persona_Moral { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }
        public bool? Persona_Moral_Victima { get; set; }

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
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
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
        [ForeignKey("Localidad_del_Tutor")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_del_Tutor_Localidad { get; set; }
        [ForeignKey("Colonia_del_Tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Tutor_Colonia { get; set; }
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Prioridad_del_Hecho")]
        public virtual Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho Prioridad_del_Hecho_Prioridad_del_Hecho { get; set; }
        [ForeignKey("Pais_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_los_Hechos_Pais { get; set; }
        [ForeignKey("Estado_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_los_Hechos_Estado { get; set; }
        [ForeignKey("Municipio_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_los_Hechos_Municipio { get; set; }
        [ForeignKey("Colonia_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_los_Hechos_Colonia { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_Lugar_Tipo { get; set; }
        [ForeignKey("Sexo_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_de_Persona_Moral_Genero { get; set; }
        [ForeignKey("Estado_Civil_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_de_Persona_Moral_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_de_Persona_Moral_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_de_Persona_Moral_Escolaridad { get; set; }
        [ForeignKey("Ocupacion_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_de_Persona_Moral_Ocupacion { get; set; }
        [ForeignKey("Pais_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Persona_Moral_Pais { get; set; }
        [ForeignKey("Estado_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_Persona_Moral_Estado { get; set; }
        [ForeignKey("Municipio_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Persona_Moral_Municipio { get; set; }
        [ForeignKey("Colonia_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_Persona_Moral_Colonia { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }
	
	public class Detalle_de_Datos_de_la_Victima_MPI_Datos_Generales
    {
                public int Clave { get; set; }
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
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool? Incapaz { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public bool? Proteccion_de_Datos { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }
        public bool? Persona_Moral_Victima { get; set; }

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
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }

	public class Detalle_de_Datos_de_la_Victima_MPI__Datos_del_Tutor
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
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Localidad_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public int? Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public int? Extencion_del_Tutor { get; set; }
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
        [ForeignKey("Localidad_del_Tutor")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_del_Tutor_Localidad { get; set; }
        [ForeignKey("Colonia_del_Tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Tutor_Colonia { get; set; }

    }

	public class Detalle_de_Datos_de_la_Victima_MPI_Datos_de_los_Hechos
    {
                public int Clave { get; set; }
        public string Narrativa_de_los_Hechos { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos { get; set; }
        public int? Estado_de_los_Hechos { get; set; }
        public int? Municipio_de_los_Hechos { get; set; }
        public int? Colonia_de_los_Hechos { get; set; }
        public int? Codigo_Postal_de_los_Hechos { get; set; }
        public string Calle_de_los_Hechos { get; set; }
        public string Entre_Calle_de_los_Hechos { get; set; }
        public string Y_Calle_de_los_Hechos { get; set; }
        public string Numero_Exterior_de_los_Hechos { get; set; }
        public string Numero_Interior_de_los_Hechos { get; set; }
        public string Latitud_de_los_Hechos { get; set; }
        public string Longitud_de_los_Hechos { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }

		        [ForeignKey("Prioridad_del_Hecho")]
        public virtual Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho Prioridad_del_Hecho_Prioridad_del_Hecho { get; set; }
        [ForeignKey("Pais_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_los_Hechos_Pais { get; set; }
        [ForeignKey("Estado_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_los_Hechos_Estado { get; set; }
        [ForeignKey("Municipio_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_los_Hechos_Municipio { get; set; }
        [ForeignKey("Colonia_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_los_Hechos_Colonia { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_Lugar_Tipo { get; set; }

    }

	public class Detalle_de_Datos_de_la_Victima_MPI_Datos_del_Abogado
    {
                public int Clave { get; set; }

		
    }

	public class Detalle_de_Datos_de_la_Victima_MPI_Datos_de_Persona_Moral
    {
                public int Clave { get; set; }
        public string Nombre_de_Persona_Moral { get; set; }
        public string Apellido_Paterno_de_Persona_Moral { get; set; }
        public string Apellido_Materno_de_Persona_Moral { get; set; }
        public DateTime? Fecha_de_Nacimiento_de_Persona_Moral { get; set; }
        public short? Edad_de_Persona_Moral { get; set; }
        public int? Sexo_de_Persona_Moral { get; set; }
        public int? Estado_Civil_de_Persona_Moral { get; set; }
        public int? Tipo_de_Identificacion_de_Persona_Moral { get; set; }
        public string Numero_de_Identificacion_de_Persona_Mora { get; set; }
        public int? Nacionalidad_de_Persona_Moral { get; set; }
        public short? Escolaridad_de_Persona_Moral { get; set; }
        public int? Ocupacion_de_Persona_Moral { get; set; }
        public int? Pais_de_Persona_Moral { get; set; }
        public int? Estado_de_Persona_Moral { get; set; }
        public int? Municipio_de_Persona_Moral { get; set; }
        public int? Colonia_de_Persona_Moral { get; set; }
        public int? Codigo_Postal_de_Persona_Moral { get; set; }
        public string Calle_de_Persona_Moral { get; set; }
        public string Numero_Exterior_de_Persona_Moral { get; set; }
        public string Numero_Interior_de_Persona_Moral { get; set; }
        public string Entre_Calle_de_Persona_Moral { get; set; }
        public string Y_Calle_de_Persona_Moral { get; set; }
        public string Longitud_de_Persona_Moral { get; set; }
        public string Latitud_de_Persona_Moral { get; set; }
        public string Telefono_de_Persona_Moral { get; set; }
        public string Extension_de_Persona_Moral { get; set; }
        public string Celular_de_Persona_Moral { get; set; }
        public string Correo_Electronico_de_Persona_Moral { get; set; }

		        [ForeignKey("Sexo_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_de_Persona_Moral_Genero { get; set; }
        [ForeignKey("Estado_Civil_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_de_Persona_Moral_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_de_Persona_Moral_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_de_Persona_Moral_Escolaridad { get; set; }
        [ForeignKey("Ocupacion_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_de_Persona_Moral_Ocupacion { get; set; }
        [ForeignKey("Pais_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Persona_Moral_Pais { get; set; }
        [ForeignKey("Estado_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_Persona_Moral_Estado { get; set; }
        [ForeignKey("Municipio_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Persona_Moral_Municipio { get; set; }
        [ForeignKey("Colonia_de_Persona_Moral")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_Persona_Moral_Colonia { get; set; }

    }


}

