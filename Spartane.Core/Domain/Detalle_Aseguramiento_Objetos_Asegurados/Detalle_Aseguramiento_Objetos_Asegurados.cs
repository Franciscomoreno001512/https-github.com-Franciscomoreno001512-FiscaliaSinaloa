using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Objetos_Asegurados
{
    /// <summary>
    /// Detalle_Aseguramiento_Objetos_Asegurados table
    /// </summary>
    public class Detalle_Aseguramiento_Objetos_Asegurados: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Serie { get; set; }
        public string IMEI { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }

    }
	
	public class Detalle_Aseguramiento_Objetos_Asegurados_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Serie { get; set; }
        public string IMEI { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }

    }


}

