using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitante_MPI;
using Spartane.Core.Domain.Expediente_Inicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitante_en_Audiencias_MPI
{
    /// <summary>
    /// Detalle_de_Solicitante_en_Audiencias_MPI table
    /// </summary>
    public class Detalle_de_Solicitante_en_Audiencias_MPI: BaseEntity
    {
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string Direccion { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }

        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI Nombre_Solicitante_MPI { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }
	
	public class Detalle_de_Solicitante_en_Audiencias_MPI_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string Direccion { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }

		        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI Nombre_Solicitante_MPI { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }


}

