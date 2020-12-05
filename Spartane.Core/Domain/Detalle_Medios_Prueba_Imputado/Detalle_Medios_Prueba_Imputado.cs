using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Proceso_Penal;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado
{
    /// <summary>
    /// Detalle_Medios_Prueba_Imputado table
    /// </summary>
    public class Detalle_Medios_Prueba_Imputado: BaseEntity
    {
        public int Clave { get; set; }
        public int? Proceso_Penal { get; set; }
        public string Medio_de_Prueba_Presentado { get; set; }
        public DateTime? Fecha_de_Presentacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }

        [ForeignKey("Proceso_Penal")]
        public virtual Spartane.Core.Domain.Proceso_Penal.Proceso_Penal Proceso_Penal_Proceso_Penal { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }

    }
	
	public class Detalle_Medios_Prueba_Imputado_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Proceso_Penal { get; set; }
        public string Medio_de_Prueba_Presentado { get; set; }
        public DateTime? Fecha_de_Presentacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }

		        [ForeignKey("Proceso_Penal")]
        public virtual Spartane.Core.Domain.Proceso_Penal.Proceso_Penal Proceso_Penal_Proceso_Penal { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }

    }


}

