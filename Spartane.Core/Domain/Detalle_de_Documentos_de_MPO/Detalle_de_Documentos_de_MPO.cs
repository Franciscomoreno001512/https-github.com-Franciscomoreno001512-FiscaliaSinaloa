using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Documentos_de_MPO
{
    /// <summary>
    /// Detalle_de_Documentos_de_MPO table
    /// </summary>
    public class Detalle_de_Documentos_de_MPO: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_de_Atencion_Inicial { get; set; }
        public DateTime? Fecha { get; set; }
        public string Documento { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }

        [ForeignKey("Modulo_de_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

    }
	
	public class Detalle_de_Documentos_de_MPO_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_de_Atencion_Inicial { get; set; }
        public DateTime? Fecha { get; set; }
        public string Documento { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }

		        [ForeignKey("Modulo_de_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

    }


}

