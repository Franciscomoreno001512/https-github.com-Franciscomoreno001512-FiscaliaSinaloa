using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Abogado;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Detalle_de_Datos_de_la_Victima_MPI;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_del_Abogado_Victima_MPI
{
    /// <summary>
    /// Detalle_del_Abogado_Victima_MPI table
    /// </summary>
    public class Detalle_del_Abogado_Victima_MPI: BaseEntity
    {
        public int Consecutivo_Victima { get; set; }
        public int? Nombre_Completo_del_Abogado_Victima { get; set; }
        public string Nombre_del_Abogado_Victima { get; set; }
        public string Apellido_Paterno_del_Abogado_Victima { get; set; }
        public string Apellido_Materno_del_Abogado_Victima { get; set; }
        public DateTime? Fecha_de_Nacimiento_del_Abogado_Victima { get; set; }
        public short? Edad_del_Abogado_Victima { get; set; }
        public int? Sexo_del_Abogado_Victima { get; set; }
        public int? Estado_Civil_del_Abogado_Victima { get; set; }
        public int? Tipo_de_Identificacion_Abogado_Victima { get; set; }
        public string Numero_de_Identificacion_Abogado_Victima { get; set; }
        public int? Nacionalidad_del_Abogado_Victima { get; set; }
        public string Cedula_Profesional_del_Abogado_Victima { get; set; }
        public int? Pais_del_Abogado_Victima { get; set; }
        public int? Estado_del_Abogado_Victima { get; set; }
        public int? Municipio_del_Abogado_Victima { get; set; }
        public int? Colonia_del_Abogado_Victima { get; set; }
        public int? Codigo_Postal_del_Abogado_Victima { get; set; }
        public string Calle_del_Abogado_Victima { get; set; }
        public string Numero_Exterior_del_Abogado_Victima { get; set; }
        public string Numero_Interior_del_Abogado_Victima { get; set; }
        public string Telefono_del_Abogado_Victima { get; set; }
        public string Celular_del_Abogado_Victima { get; set; }
        public string Correo_Electronico_del_Abogado_Victima { get; set; }
        public int? Compareciente { get; set; }
        public bool? Aceptar_Notificaciones { get; set; }

        [ForeignKey("Nombre_Completo_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Abogado.Abogado Nombre_Completo_del_Abogado_Victima_Abogado { get; set; }
        [ForeignKey("Sexo_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_del_Abogado_Victima_Genero { get; set; }
        [ForeignKey("Estado_Civil_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_del_Abogado_Victima_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_del_Abogado_Victima_Nacionalidad { get; set; }
        [ForeignKey("Pais_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_del_Abogado_Victima_Pais { get; set; }
        [ForeignKey("Estado_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Abogado_Victima_Estado { get; set; }
        [ForeignKey("Municipio_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Abogado_Victima_Municipio { get; set; }
        [ForeignKey("Colonia_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Abogado_Victima_Colonia { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_de_la_Victima_MPI.Detalle_de_Datos_de_la_Victima_MPI Compareciente_Detalle_de_Datos_de_la_Victima_MPI { get; set; }

    }
	
	public class Detalle_del_Abogado_Victima_MPI_Datos_Generales
    {
                public int Consecutivo_Victima { get; set; }
        public int? Nombre_Completo_del_Abogado_Victima { get; set; }
        public string Nombre_del_Abogado_Victima { get; set; }
        public string Apellido_Paterno_del_Abogado_Victima { get; set; }
        public string Apellido_Materno_del_Abogado_Victima { get; set; }
        public DateTime? Fecha_de_Nacimiento_del_Abogado_Victima { get; set; }
        public short? Edad_del_Abogado_Victima { get; set; }
        public int? Sexo_del_Abogado_Victima { get; set; }
        public int? Estado_Civil_del_Abogado_Victima { get; set; }
        public int? Tipo_de_Identificacion_Abogado_Victima { get; set; }
        public string Numero_de_Identificacion_Abogado_Victima { get; set; }
        public int? Nacionalidad_del_Abogado_Victima { get; set; }
        public string Cedula_Profesional_del_Abogado_Victima { get; set; }
        public int? Pais_del_Abogado_Victima { get; set; }
        public int? Estado_del_Abogado_Victima { get; set; }
        public int? Municipio_del_Abogado_Victima { get; set; }
        public int? Colonia_del_Abogado_Victima { get; set; }
        public int? Codigo_Postal_del_Abogado_Victima { get; set; }
        public string Calle_del_Abogado_Victima { get; set; }
        public string Numero_Exterior_del_Abogado_Victima { get; set; }
        public string Numero_Interior_del_Abogado_Victima { get; set; }
        public string Telefono_del_Abogado_Victima { get; set; }
        public string Celular_del_Abogado_Victima { get; set; }
        public string Correo_Electronico_del_Abogado_Victima { get; set; }
        public int? Compareciente { get; set; }
        public bool? Aceptar_Notificaciones { get; set; }

		        [ForeignKey("Nombre_Completo_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Abogado.Abogado Nombre_Completo_del_Abogado_Victima_Abogado { get; set; }
        [ForeignKey("Sexo_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_del_Abogado_Victima_Genero { get; set; }
        [ForeignKey("Estado_Civil_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_del_Abogado_Victima_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_del_Abogado_Victima_Nacionalidad { get; set; }
        [ForeignKey("Pais_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_del_Abogado_Victima_Pais { get; set; }
        [ForeignKey("Estado_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Abogado_Victima_Estado { get; set; }
        [ForeignKey("Municipio_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Abogado_Victima_Municipio { get; set; }
        [ForeignKey("Colonia_del_Abogado_Victima")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Abogado_Victima_Colonia { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_de_la_Victima_MPI.Detalle_de_Datos_de_la_Victima_MPI Compareciente_Detalle_de_Datos_de_la_Victima_MPI { get; set; }

    }


}

