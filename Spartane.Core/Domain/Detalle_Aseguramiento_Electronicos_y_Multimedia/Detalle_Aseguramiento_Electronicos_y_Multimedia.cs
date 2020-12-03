using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia;
using Spartane.Core.Domain.Documentos_Multimedia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia
{
    /// <summary>
    /// Detalle_Aseguramiento_Electronicos_y_Multimedia table
    /// </summary>
    public class Detalle_Aseguramiento_Electronicos_y_Multimedia: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Aparatos { get; set; }
        public short? Documentos_Multimedia { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public string A_resguardo { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Aparatos")]
        public virtual Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia Aparatos_Aparato_Electronicos_y_Multimedia { get; set; }
        [ForeignKey("Documentos_Multimedia")]
        public virtual Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia Documentos_Multimedia_Documentos_Multimedia { get; set; }

    }
	
	public class Detalle_Aseguramiento_Electronicos_y_Multimedia_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Aparatos { get; set; }
        public short? Documentos_Multimedia { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public string A_resguardo { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Aparatos")]
        public virtual Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia Aparatos_Aparato_Electronicos_y_Multimedia { get; set; }
        [ForeignKey("Documentos_Multimedia")]
        public virtual Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia Documentos_Multimedia_Documentos_Multimedia { get; set; }

    }


}

