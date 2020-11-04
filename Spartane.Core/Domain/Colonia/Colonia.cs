using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Vigencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Colonia
{
    /// <summary>
    /// Colonia table
    /// </summary>
    public class Colonia: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Municipio { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Zona { get; set; }
        public int? Vigente { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Vigente")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigente_Vigencia { get; set; }

    }
	
	public class Colonia_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Municipio { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Zona { get; set; }
        public int? Vigente { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Vigente")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigente_Vigencia { get; set; }

    }


}

