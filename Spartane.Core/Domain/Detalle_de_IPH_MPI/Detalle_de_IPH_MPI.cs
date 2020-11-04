using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Expediente_Inicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_IPH_MPI
{
    /// <summary>
    /// Detalle_de_IPH_MPI table
    /// </summary>
    public class Detalle_de_IPH_MPI: BaseEntity
    {
        public int Clave { get; set; }
        public string NUE { get; set; }
        public string Folio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Documentos { get; set; }
        public short? Archivo { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }
        public string Hora { get; set; }

        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }
	
	public class Detalle_de_IPH_MPI_Datos_Generales
    {
                public int Clave { get; set; }
        public string NUE { get; set; }
        public string Folio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Documentos { get; set; }
        public short? Archivo { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }
        public string Hora { get; set; }

		        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }


}

