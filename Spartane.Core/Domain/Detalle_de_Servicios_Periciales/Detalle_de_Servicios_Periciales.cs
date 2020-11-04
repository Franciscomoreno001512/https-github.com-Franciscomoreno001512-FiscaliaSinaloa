using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Servicios_Periciales;
using Spartane.Core.Domain.Estatus_del_Dictamen;
using Spartane.Core.Domain.Rol_de_Diligencia;
using Spartane.Core.Domain.Expediente_Inicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Servicios_Periciales
{
    /// <summary>
    /// Detalle_de_Servicios_Periciales table
    /// </summary>
    public class Detalle_de_Servicios_Periciales: BaseEntity
    {
        public int Clave { get; set; }
        public int? Servicio { get; set; }
        public int? Especialista { get; set; }
        public int? Estatus_del_Dictamen { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha_del_Dictamen { get; set; }
        public short? Dictamen { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }
        public string ObservacionesD { get; set; }

        [ForeignKey("Servicio")]
        public virtual Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales Servicio_Servicios_Periciales { get; set; }
        [ForeignKey("Estatus_del_Dictamen")]
        public virtual Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen Estatus_del_Dictamen_Estatus_del_Dictamen { get; set; }
        [ForeignKey("Rol_de_Donde_Proviene")]
        public virtual Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia Rol_de_Donde_Proviene_Rol_de_Diligencia { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }
	
	public class Detalle_de_Servicios_Periciales_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Servicio { get; set; }
        public int? Especialista { get; set; }
        public int? Estatus_del_Dictamen { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha_del_Dictamen { get; set; }
        public short? Dictamen { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }
        public string ObservacionesD { get; set; }

		        [ForeignKey("Servicio")]
        public virtual Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales Servicio_Servicios_Periciales { get; set; }
        [ForeignKey("Estatus_del_Dictamen")]
        public virtual Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen Estatus_del_Dictamen_Estatus_del_Dictamen { get; set; }
        [ForeignKey("Rol_de_Donde_Proviene")]
        public virtual Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia Rol_de_Donde_Proviene_Rol_de_Diligencia { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }


}

