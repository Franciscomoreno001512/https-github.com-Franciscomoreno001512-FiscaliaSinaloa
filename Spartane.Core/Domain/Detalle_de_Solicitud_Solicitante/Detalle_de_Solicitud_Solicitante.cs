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
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;
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
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante
{
    /// <summary>
    /// Detalle_de_Solicitud_Solicitante table
    /// </summary>
    public class Detalle_de_Solicitud_Solicitante: BaseEntity
    {
        public int Clave { get; set; }
        public int? idRegistroAT { get; set; }
        public int? idRegistroUI { get; set; }
        public int? Solicitud { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Indentificacion { get; set; }
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
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais_de_Origen { get; set; }
        public string Originario_de { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public bool? Incapaz { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public string Nombre_tutor { get; set; }
        public string Apellido_Paterno_tutor { get; set; }
        public string Apellido_Materno_tutor { get; set; }
        public string Nombre_Completo_tutor { get; set; }
        public DateTime? Fecha_de_Nacimiento_tutor { get; set; }
        public string CURP_Tutor { get; set; }
        public string RFC_Tutor { get; set; }
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
        public int? Localidad_tutor { get; set; }
        public int? Colonia_tutor { get; set; }
        public int? Codigo_Postal_tutor { get; set; }
        public string Calle_tutor { get; set; }
        public string Numero_Exterior_tutor { get; set; }
        public string Numero_Interior_tutor { get; set; }
        public string Telefono_tutor { get; set; }
        public short? Extension_tutor { get; set; }
        public string Celular_tutor { get; set; }
        public string Correo_Electronico_tutor { get; set; }
        public int? Pais_de_Origen_T { get; set; }
        public string Originario_de_T { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Lugar_de_los_Hechos { get; set; }
        public int? Pais_Hechos { get; set; }
        public int? Estado_Hechos { get; set; }
        public int? Municipio_Hechos { get; set; }
        public int? Colonia_Hechos { get; set; }
        public int? Codigo_Postal_Hechos { get; set; }
        public string Calle_Hechos { get; set; }
        public string Numero_Exterior_Hechos { get; set; }
        public string Numero_Interior_Hechos { get; set; }
        public string Entre_Calle_Hechos { get; set; }
        public string y_Calle_Hechos { get; set; }
        public string Longitud_Hechos { get; set; }
        public string Latitud_H { get; set; }

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
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Tipo_de_Inimputabilidad")]
        public virtual Spartane.Core.Domain.Tipo_de_Inimputabilidad.Tipo_de_Inimputabilidad Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad { get; set; }
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
        [ForeignKey("Localidad_tutor")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_tutor_Localidad { get; set; }
        [ForeignKey("Colonia_tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_tutor_Colonia { get; set; }
        [ForeignKey("Pais_de_Origen_T")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Origen_T_Pais { get; set; }
        [ForeignKey("Lugar_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Lugar_de_los_Hechos_Lugar_Tipo { get; set; }
        [ForeignKey("Pais_Hechos")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Hechos_Pais { get; set; }
        [ForeignKey("Estado_Hechos")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Hechos_Estado { get; set; }
        [ForeignKey("Municipio_Hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Hechos_Municipio { get; set; }
        [ForeignKey("Colonia_Hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Hechos_Colonia { get; set; }

    }
	
	public class Detalle_de_Solicitud_Solicitante_Datos_Generales
    {
                public int Clave { get; set; }
        public int? idRegistroAT { get; set; }
        public int? idRegistroUI { get; set; }
        public int? Solicitud { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Indentificacion { get; set; }
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
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais_de_Origen { get; set; }
        public string Originario_de { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public bool? Incapaz { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }

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
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Tipo_de_Inimputabilidad")]
        public virtual Spartane.Core.Domain.Tipo_de_Inimputabilidad.Tipo_de_Inimputabilidad Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad { get; set; }

    }

	public class Detalle_de_Solicitud_Solicitante_Datos_del_Tutor
    {
                public int Clave { get; set; }
        public string Nombre_tutor { get; set; }
        public string Apellido_Paterno_tutor { get; set; }
        public string Apellido_Materno_tutor { get; set; }
        public string Nombre_Completo_tutor { get; set; }
        public DateTime? Fecha_de_Nacimiento_tutor { get; set; }
        public string CURP_Tutor { get; set; }
        public string RFC_Tutor { get; set; }
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
        public int? Localidad_tutor { get; set; }
        public int? Colonia_tutor { get; set; }
        public int? Codigo_Postal_tutor { get; set; }
        public string Calle_tutor { get; set; }
        public string Numero_Exterior_tutor { get; set; }
        public string Numero_Interior_tutor { get; set; }
        public string Telefono_tutor { get; set; }
        public short? Extension_tutor { get; set; }
        public string Celular_tutor { get; set; }
        public string Correo_Electronico_tutor { get; set; }
        public int? Pais_de_Origen_T { get; set; }
        public string Originario_de_T { get; set; }

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
        [ForeignKey("Localidad_tutor")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_tutor_Localidad { get; set; }
        [ForeignKey("Colonia_tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_tutor_Colonia { get; set; }
        [ForeignKey("Pais_de_Origen_T")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Origen_T_Pais { get; set; }

    }

	public class Detalle_de_Solicitud_Solicitante_Datos_de_los_Hechos
    {
                public int Clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Lugar_de_los_Hechos { get; set; }
        public int? Pais_Hechos { get; set; }
        public int? Estado_Hechos { get; set; }
        public int? Municipio_Hechos { get; set; }
        public int? Colonia_Hechos { get; set; }
        public int? Codigo_Postal_Hechos { get; set; }
        public string Calle_Hechos { get; set; }
        public string Numero_Exterior_Hechos { get; set; }
        public string Numero_Interior_Hechos { get; set; }
        public string Entre_Calle_Hechos { get; set; }
        public string y_Calle_Hechos { get; set; }
        public string Longitud_Hechos { get; set; }
        public string Latitud_H { get; set; }

		        [ForeignKey("Lugar_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Lugar_de_los_Hechos_Lugar_Tipo { get; set; }
        [ForeignKey("Pais_Hechos")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Hechos_Pais { get; set; }
        [ForeignKey("Estado_Hechos")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Hechos_Estado { get; set; }
        [ForeignKey("Municipio_Hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Hechos_Municipio { get; set; }
        [ForeignKey("Colonia_Hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Hechos_Colonia { get; set; }

    }


}

