using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Registro_de_Intervinientes_CC;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes
{
    /// <summary>
    /// Detalle_de_Galeria_de_Intervinientes table
    /// </summary>
    public class Detalle_de_Galeria_de_Intervinientes: BaseEntity
    {
        public int Clave { get; set; }
        public int? Detalle_de_Intervinientes { get; set; }
        public string Nombre { get; set; }
        public short? Archivo { get; set; }

        [ForeignKey("Detalle_de_Intervinientes")]
        public virtual Spartane.Core.Domain.Detalle_de_Registro_de_Intervinientes_CC.Detalle_de_Registro_de_Intervinientes_CC Detalle_de_Intervinientes_Detalle_de_Registro_de_Intervinientes_CC { get; set; }

    }
	
	public class Detalle_de_Galeria_de_Intervinientes_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Detalle_de_Intervinientes { get; set; }
        public string Nombre { get; set; }
        public short? Archivo { get; set; }

		        [ForeignKey("Detalle_de_Intervinientes")]
        public virtual Spartane.Core.Domain.Detalle_de_Registro_de_Intervinientes_CC.Detalle_de_Registro_de_Intervinientes_CC Detalle_de_Intervinientes_Detalle_de_Registro_de_Intervinientes_CC { get; set; }

    }


}

