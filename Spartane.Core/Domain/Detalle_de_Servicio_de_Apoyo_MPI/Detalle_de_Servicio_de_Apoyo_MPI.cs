using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Solicitante_MPI;
using Spartane.Core.Domain.Expediente_Inicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo_MPI
{
    /// <summary>
    /// Detalle_de_Servicio_de_Apoyo_MPI table
    /// </summary>
    public class Detalle_de_Servicio_de_Apoyo_MPI: BaseEntity
    {
        public int Clave { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        public int? Victima { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }

        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Victima")]
        public virtual Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI Victima_Solicitante_MPI { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }
	
	public class Detalle_de_Servicio_de_Apoyo_MPI_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        public int? Victima { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }

		        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Victima")]
        public virtual Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI Victima_Solicitante_MPI { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }


}

