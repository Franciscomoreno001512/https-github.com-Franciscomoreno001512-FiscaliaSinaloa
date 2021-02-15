using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Agencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.ErmeOficio
{
    /// <summary>
    /// ErmeOficio table
    /// </summary>
    public class ErmeOficio: BaseEntity
    {
        public int Clave { get; set; }
        public string Oficio { get; set; }
        public int? Municipio { get; set; }
        public int? Agencia { get; set; }

        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia.Agencia Agencia_Agencia { get; set; }

    }
	
	public class ErmeOficio_Datos_Generales
    {
                public int Clave { get; set; }
        public string Oficio { get; set; }
        public int? Municipio { get; set; }
        public int? Agencia { get; set; }

		        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia.Agencia Agencia_Agencia { get; set; }

    }


}

