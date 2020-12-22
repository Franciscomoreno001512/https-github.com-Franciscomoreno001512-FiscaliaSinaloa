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

namespace Spartane.Core.Domain.Detalle_de_Huellas_Digitales
{
    /// <summary>
    /// Detalle_de_Huellas_Digitales table
    /// </summary>
    public class Detalle_de_Huellas_Digitales: BaseEntity
    {
        public int Clave { get; set; }
        public int? Registro_de_Orden_de_Aprehension { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Registro_de_Orden_de_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Registro_de_Orden_de_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

    }
	
	public class Detalle_de_Huellas_Digitales_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Registro_de_Orden_de_Aprehension { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Registro_de_Orden_de_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Registro_de_Orden_de_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

    }


}

