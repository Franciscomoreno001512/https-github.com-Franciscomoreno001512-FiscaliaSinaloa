using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Vigencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Municipio
{
    /// <summary>
    /// Municipio table
    /// </summary>
    public class Municipio: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Abreviacion { get; set; }
        public int? Estado { get; set; }
        public int? Vigencia { get; set; }
        public string Observaciones { get; set; }
        public int? cod_pais { get; set; }
        public string cod_zona { get; set; }
        public string MuniNSJP { get; set; }
        public int? cod_zona_nsjp { get; set; }
        public int? cod_mun { get; set; }

        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }
	
	public class Municipio_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Abreviacion { get; set; }
        public int? Estado { get; set; }
        public int? Vigencia { get; set; }
        public string Observaciones { get; set; }
        public int? cod_pais { get; set; }
        public string cod_zona { get; set; }
        public string MuniNSJP { get; set; }
        public int? cod_zona_nsjp { get; set; }
        public int? cod_mun { get; set; }

		        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }


}

