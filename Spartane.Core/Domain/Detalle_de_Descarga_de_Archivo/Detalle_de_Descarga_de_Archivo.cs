using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Descarga_de_Archivo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Descarga_de_Archivo
{
    /// <summary>
    /// Detalle_de_Descarga_de_Archivo table
    /// </summary>
    public class Detalle_de_Descarga_de_Archivo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Descarga_de_Archivos { get; set; }
        public short? Documento { get; set; }

        [ForeignKey("Descarga_de_Archivos")]
        public virtual Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo Descarga_de_Archivos_Descarga_de_Archivo { get; set; }

    }
	
	public class Detalle_de_Descarga_de_Archivo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Descarga_de_Archivos { get; set; }
        public short? Documento { get; set; }

		        [ForeignKey("Descarga_de_Archivos")]
        public virtual Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo Descarga_de_Archivos_Descarga_de_Archivo { get; set; }

    }


}

