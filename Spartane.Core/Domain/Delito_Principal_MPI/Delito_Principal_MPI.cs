using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Delito_Principal_MPI
{
    /// <summary>
    /// Delito_Principal_MPI table
    /// </summary>
    public class Delito_Principal_MPI: BaseEntity
    {
        public int Clave { get; set; }
        public string Delito { get; set; }


    }
	
	public class Delito_Principal_MPI_Datos_Generales
    {
                public int Clave { get; set; }
        public string Delito { get; set; }

		
    }


}

