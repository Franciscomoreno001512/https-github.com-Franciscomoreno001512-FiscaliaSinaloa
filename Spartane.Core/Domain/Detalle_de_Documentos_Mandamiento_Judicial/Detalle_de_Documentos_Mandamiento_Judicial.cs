using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Documentos_Mandamiento_Judicial
{
    /// <summary>
    /// Detalle_de_Documentos_Mandamiento_Judicial table
    /// </summary>
    public class Detalle_de_Documentos_Mandamiento_Judicial: BaseEntity
    {
        public int Clave { get; set; }
        public int? Registro_de_Orden_de_Aprehension { get; set; }
        public int? Documentos { get; set; }
        public string Documentos_URL { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Registro_de_Orden_de_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Registro_de_Orden_de_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Documentos")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Documentos_Spartane_File { get; set; }

    }
	
	public class Detalle_de_Documentos_Mandamiento_Judicial_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Registro_de_Orden_de_Aprehension { get; set; }
        public int? Documentos { get; set; }
        public string Documentos_URL { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Registro_de_Orden_de_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Registro_de_Orden_de_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Documentos")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Documentos_Spartane_File { get; set; }

    }


}

