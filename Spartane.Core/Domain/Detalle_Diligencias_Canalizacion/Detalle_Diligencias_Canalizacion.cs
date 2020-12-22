using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Canalizacion;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Diligencias_Canalizacion
{
    /// <summary>
    /// Detalle_Diligencias_Canalizacion table
    /// </summary>
    public class Detalle_Diligencias_Canalizacion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Canalizacion { get; set; }
        public string Diligencia { get; set; }
        public int? Ver_Documento { get; set; }
        public string Ver_Documento_URL { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Canalizacion")]
        public virtual Spartane.Core.Domain.Canalizacion.Canalizacion Canalizacion_Canalizacion { get; set; }
        [ForeignKey("Ver_Documento")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Ver_Documento_Spartane_File { get; set; }

    }
	
	public class Detalle_Diligencias_Canalizacion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Canalizacion { get; set; }
        public string Diligencia { get; set; }
        public int? Ver_Documento { get; set; }
        public string Ver_Documento_URL { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Canalizacion")]
        public virtual Spartane.Core.Domain.Canalizacion.Canalizacion Canalizacion_Canalizacion { get; set; }
        [ForeignKey("Ver_Documento")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Ver_Documento_Spartane_File { get; set; }

    }


}

