using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.estatus_mpi
{
    /// <summary>
    /// estatus_mpi table
    /// </summary>
    public class estatus_mpi: BaseEntity
    {
        public short clave { get; set; }
        public string descripcion { get; set; }


    }
	
	public class estatus_mpi_Datos_Generales
    {
                public short clave { get; set; }
        public string descripcion { get; set; }

		
    }


}

