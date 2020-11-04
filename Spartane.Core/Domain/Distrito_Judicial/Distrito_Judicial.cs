using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Municipio;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Distrito_Judicial
{
    /// <summary>
    /// Distrito_Judicial table
    /// </summary>
    public class Distrito_Judicial: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Codigo { get; set; }
        public int? Municipio { get; set; }

        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }

    }
	
	public class Distrito_Judicial_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Codigo { get; set; }
        public int? Municipio { get; set; }

		        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }

    }


}

