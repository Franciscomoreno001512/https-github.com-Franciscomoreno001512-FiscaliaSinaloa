using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud_de_Notificacion;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Invitado_de_Notificacion
{
    /// <summary>
    /// Detalle_de_Invitado_de_Notificacion table
    /// </summary>
    public class Detalle_de_Invitado_de_Notificacion: BaseEntity
    {
        public int Folio { get; set; }
        public int? Solicitud_de_Notificacion { get; set; }
        public string Nombre_Completo { get; set; }
        public string Telefono { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }

        [ForeignKey("Solicitud_de_Notificacion")]
        public virtual Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion Solicitud_de_Notificacion_Solicitud_de_Notificacion { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }
	
	public class Detalle_de_Invitado_de_Notificacion_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Solicitud_de_Notificacion { get; set; }
        public string Nombre_Completo { get; set; }
        public string Telefono { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }

		        [ForeignKey("Solicitud_de_Notificacion")]
        public virtual Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion Solicitud_de_Notificacion_Solicitud_de_Notificacion { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }


}

