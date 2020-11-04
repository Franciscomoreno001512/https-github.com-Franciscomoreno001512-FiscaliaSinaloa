using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;
using Spartane.Core.Domain.Idioma;
using Spartane.Core.Domain.Dialecto;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitud_Datos_de_Apoyo
{
    /// <summary>
    /// Detalle_de_Solicitud_Datos_de_Apoyo table
    /// </summary>
    public class Detalle_de_Solicitud_Datos_de_Apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_registra { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Dictamen { get; set; }
        public int? Solicitante { get; set; }
        public string Responsable { get; set; }
        public int? Idioma { get; set; }
        public int? Lengua_Originaria { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Usuario_que_registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Solicitante")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Solicitante_Detalle_de_Solicitud_Solicitante { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
        [ForeignKey("Lengua_Originaria")]
        public virtual Spartane.Core.Domain.Dialecto.Dialecto Lengua_Originaria_Dialecto { get; set; }

    }
	
	public class Detalle_de_Solicitud_Datos_de_Apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_registra { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Dictamen { get; set; }
        public int? Solicitante { get; set; }
        public string Responsable { get; set; }
        public int? Idioma { get; set; }
        public int? Lengua_Originaria { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Usuario_que_registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Solicitante")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Solicitante_Detalle_de_Solicitud_Solicitante { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
        [ForeignKey("Lengua_Originaria")]
        public virtual Spartane.Core.Domain.Dialecto.Dialecto Lengua_Originaria_Dialecto { get; set; }

    }


}

