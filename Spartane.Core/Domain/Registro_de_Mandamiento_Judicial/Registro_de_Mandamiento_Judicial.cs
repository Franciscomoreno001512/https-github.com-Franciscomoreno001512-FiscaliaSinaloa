using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Mandamiento;
using Spartane.Core.Domain.Fuente_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Institucion_Emisora;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Juzgado;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Judicializacion;

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
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Numero_de_Mandamiento { get; set; }
        public int? Tipo_Mandato { get; set; }
        public int? Fuente { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public int? Pais_al_que_Pertenece_la_Informacion { get; set; }
        public int? Estado_que_Envia_la_Informacion { get; set; }
        public int? Municipio_que_Envia_la_Informacion { get; set; }
        public int? Institucion_que_Remite { get; set; }
        public string Dependencia_Autoridad_Remitente { get; set; }
        public int? Entidad_que_Emite_Mandamiento { get; set; }
        public int? Juzgado_que_Emitio_Mandamiento { get; set; }
        public string Oficio_de_Juzgado { get; set; }
        public int? Area_que_envia_Orden { get; set; }
        public string Observaciones { get; set; }
        public int? Estatus { get; set; }
        public string Numero_de_Proceso_Judicial { get; set; }
        public DateTime? Fecha_de_Libramiento { get; set; }
        public string Oficio_de_Libramiento { get; set; }
        public DateTime? Fecha_de_Transcripcion { get; set; }
        public string Oficio_Transcripcion { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public int? Causa_Penal { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_Mandato")]
        public virtual Spartane.Core.Domain.Tipo_de_Mandamiento.Tipo_de_Mandamiento Tipo_Mandato_Tipo_de_Mandamiento { get; set; }
        [ForeignKey("Fuente")]
        public virtual Spartane.Core.Domain.Fuente_de_Mandamiento_Judicial.Fuente_de_Mandamiento_Judicial Fuente_Fuente_de_Mandamiento_Judicial { get; set; }
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
        [ForeignKey("Area_que_envia_Orden")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Area_que_envia_Orden_Unidad { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial Estatus_Estatus_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Carpeta_de_Investigacion")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Carpeta_de_Investigacion_expediente_ministerio_publico { get; set; }
        [ForeignKey("Causa_Penal")]
        public virtual Spartane.Core.Domain.Judicializacion.Judicializacion Causa_Penal_Judicializacion { get; set; }

    }
	
	public class Registro_de_Mandamiento_Judicial_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Numero_de_Mandamiento { get; set; }
        public int? Tipo_Mandato { get; set; }
        public int? Fuente { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public int? Pais_al_que_Pertenece_la_Informacion { get; set; }
        public int? Estado_que_Envia_la_Informacion { get; set; }
        public int? Municipio_que_Envia_la_Informacion { get; set; }
        public int? Institucion_que_Remite { get; set; }
        public string Dependencia_Autoridad_Remitente { get; set; }
        public int? Entidad_que_Emite_Mandamiento { get; set; }
        public int? Juzgado_que_Emitio_Mandamiento { get; set; }
        public string Oficio_de_Juzgado { get; set; }
        public int? Area_que_envia_Orden { get; set; }
        public string Observaciones { get; set; }
        public int? Estatus { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_Mandato")]
        public virtual Spartane.Core.Domain.Tipo_de_Mandamiento.Tipo_de_Mandamiento Tipo_Mandato_Tipo_de_Mandamiento { get; set; }
        [ForeignKey("Fuente")]
        public virtual Spartane.Core.Domain.Fuente_de_Mandamiento_Judicial.Fuente_de_Mandamiento_Judicial Fuente_Fuente_de_Mandamiento_Judicial { get; set; }
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
        [ForeignKey("Area_que_envia_Orden")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Area_que_envia_Orden_Unidad { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial Estatus_Estatus_de_Mandamiento_Judicial { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_Proceso
    {
                public int Clave { get; set; }
        public string Numero_de_Proceso_Judicial { get; set; }
        public DateTime? Fecha_de_Libramiento { get; set; }
        public string Oficio_de_Libramiento { get; set; }
        public DateTime? Fecha_de_Transcripcion { get; set; }
        public string Oficio_Transcripcion { get; set; }

		
    }

	public class Registro_de_Mandamiento_Judicial_Expediente
    {
                public int Clave { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public int? Causa_Penal { get; set; }

		        [ForeignKey("Carpeta_de_Investigacion")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Carpeta_de_Investigacion_expediente_ministerio_publico { get; set; }
        [ForeignKey("Causa_Penal")]
        public virtual Spartane.Core.Domain.Judicializacion.Judicializacion Causa_Penal_Judicializacion { get; set; }

    }


}

