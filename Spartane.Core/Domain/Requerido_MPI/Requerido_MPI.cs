using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Requerido_MPI
{
    /// <summary>
    /// Requerido_MPI table
    /// </summary>
    public class Requerido_MPI: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Expediente_Inicial { get; set; }


    }
	
	public class Requerido_MPI_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Expediente_Inicial { get; set; }

		
    }


}

