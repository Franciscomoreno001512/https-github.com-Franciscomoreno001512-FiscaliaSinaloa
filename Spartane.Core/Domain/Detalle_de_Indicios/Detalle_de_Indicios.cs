using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Servicios_Periciales;
using Spartane.Core.Domain.Expediente_Inicial;
using Spartane.Core.Domain.Estatus_de_Indicio;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Indicios
{
    /// <summary>
    /// Detalle_de_Indicios table
    /// </summary>
    public class Detalle_de_Indicios: BaseEntity
    {
        public int Clave { get; set; }
        public string Numero_de_Indicio { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Indicio { get; set; }
        public string Motivo_de_Indicio { get; set; }
        public int? Diligencia { get; set; }
        public string Ubicacion { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }
        public int? Estatus { get; set; }

        [ForeignKey("Diligencia")]
        public virtual Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales Diligencia_Servicios_Periciales { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Indicio.Estatus_de_Indicio Estatus_Estatus_de_Indicio { get; set; }

    }
	
	public class Detalle_de_Indicios_Datos_Generales
    {
                public int Clave { get; set; }
        public string Numero_de_Indicio { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Indicio { get; set; }
        public string Motivo_de_Indicio { get; set; }
        public int? Diligencia { get; set; }
        public string Ubicacion { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }
        public int? Estatus { get; set; }

		        [ForeignKey("Diligencia")]
        public virtual Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales Diligencia_Servicios_Periciales { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Indicio.Estatus_de_Indicio Estatus_Estatus_de_Indicio { get; set; }

    }


}

