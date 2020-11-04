using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Catalogo_Tipo_de_Indicio_CC
{
    /// <summary>
    /// Catalogo_Tipo_de_Indicio_CC table
    /// </summary>
    public class Catalogo_Tipo_de_Indicio_CC: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Indicio { get; set; }

        [ForeignKey("Tipo_de_Indicio")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Tipo_de_Indicio_Cadena_de_Custodia { get; set; }

    }
	
	public class Catalogo_Tipo_de_Indicio_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Indicio { get; set; }

		        [ForeignKey("Tipo_de_Indicio")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Tipo_de_Indicio_Cadena_de_Custodia { get; set; }

    }


}

