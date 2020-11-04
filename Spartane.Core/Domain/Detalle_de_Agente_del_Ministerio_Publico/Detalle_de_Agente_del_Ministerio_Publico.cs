using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Expediente_Inicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Agente_del_Ministerio_Publico
{
    /// <summary>
    /// Detalle_de_Agente_del_Ministerio_Publico table
    /// </summary>
    public class Detalle_de_Agente_del_Ministerio_Publico: BaseEntity
    {
        public int Clave { get; set; }
        public int? Agente_del_Ministerio_Publico { get; set; }
        public int? Carga_de_Trabajo { get; set; }
        public string Especialidad { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }

        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }
	
	public class Detalle_de_Agente_del_Ministerio_Publico_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Agente_del_Ministerio_Publico { get; set; }
        public int? Carga_de_Trabajo { get; set; }
        public string Especialidad { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }

		        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }


}

