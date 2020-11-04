using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Expediente_Inicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Coincidencias_MPI
{
    /// <summary>
    /// Detalle_de_Coincidencias_MPI table
    /// </summary>
    public class Detalle_de_Coincidencias_MPI: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string NUAT { get; set; }
        public string NUC { get; set; }
        public string Rol { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }

        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }
	
	public class Detalle_de_Coincidencias_MPI_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string NUAT { get; set; }
        public string NUC { get; set; }
        public string Rol { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }

		        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }


}

