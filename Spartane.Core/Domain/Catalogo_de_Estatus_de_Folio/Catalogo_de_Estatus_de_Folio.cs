using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio
{
    /// <summary>
    /// Catalogo_de_Estatus_de_Folio table
    /// </summary>
    public class Catalogo_de_Estatus_de_Folio: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Catalogo_de_Estatus_de_Folio_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

