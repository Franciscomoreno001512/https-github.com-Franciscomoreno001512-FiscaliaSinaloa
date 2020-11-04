using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Indicios_para_MPI
{
    /// <summary>
    /// Indicios_para_MPI table
    /// </summary>
    public class Indicios_para_MPI: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Clave_Indicio { get; set; }


    }
	
	public class Indicios_para_MPI_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Clave_Indicio { get; set; }

		
    }


}

