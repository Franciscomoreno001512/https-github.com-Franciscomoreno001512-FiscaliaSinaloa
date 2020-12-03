using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Audiencias_MP;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos
{
    /// <summary>
    /// Detalle_Audiencia_Archivos_Adjuntos table
    /// </summary>
    public class Detalle_Audiencia_Archivos_Adjuntos: BaseEntity
    {
        public int Clave { get; set; }
        public int? Audiencia { get; set; }
        public string Nombre_Archivo { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }

        [ForeignKey("Audiencia")]
        public virtual Spartane.Core.Domain.Audiencias_MP.Audiencias_MP Audiencia_Audiencias_MP { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }

    }
	
	public class Detalle_Audiencia_Archivos_Adjuntos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Audiencia { get; set; }
        public string Nombre_Archivo { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }

		        [ForeignKey("Audiencia")]
        public virtual Spartane.Core.Domain.Audiencias_MP.Audiencias_MP Audiencia_Audiencias_MP { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }

    }


}

