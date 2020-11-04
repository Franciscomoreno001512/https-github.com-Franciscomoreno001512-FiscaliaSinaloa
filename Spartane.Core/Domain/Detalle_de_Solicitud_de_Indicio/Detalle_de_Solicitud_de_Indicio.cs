using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Indicios_para_MPI;
using Spartane.Core.Domain.Servicios_Periciales;
using Spartane.Core.Domain.Indicios;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio
{
    /// <summary>
    /// Detalle_de_Solicitud_de_Indicio table
    /// </summary>
    public class Detalle_de_Solicitud_de_Indicio: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public string Nombre_del_Solicitante { get; set; }
        public string Motivo { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Entrega_de_Indicio { get; set; }
        public int? Diligencia_que_Solicita { get; set; }
        public int? Indicios { get; set; }

        [ForeignKey("Numero_de_Indicio")]
        public virtual Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI Numero_de_Indicio_Indicios_para_MPI { get; set; }
        [ForeignKey("Diligencia_que_Solicita")]
        public virtual Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales Diligencia_que_Solicita_Servicios_Periciales { get; set; }
        [ForeignKey("Indicios")]
        public virtual Spartane.Core.Domain.Indicios.Indicios Indicios_Indicios { get; set; }

    }
	
	public class Detalle_de_Solicitud_de_Indicio_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public string Nombre_del_Solicitante { get; set; }
        public string Motivo { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Entrega_de_Indicio { get; set; }
        public int? Diligencia_que_Solicita { get; set; }
        public int? Indicios { get; set; }

		        [ForeignKey("Numero_de_Indicio")]
        public virtual Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI Numero_de_Indicio_Indicios_para_MPI { get; set; }
        [ForeignKey("Diligencia_que_Solicita")]
        public virtual Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales Diligencia_que_Solicita_Servicios_Periciales { get; set; }
        [ForeignKey("Indicios")]
        public virtual Spartane.Core.Domain.Indicios.Indicios Indicios_Indicios { get; set; }

    }


}

