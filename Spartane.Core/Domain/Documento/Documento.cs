using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Tipo_de_Documento;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Documento
{
    /// <summary>
    /// Documento table
    /// </summary>
    public class Documento: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Origen { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public int? idFormato { get; set; }
        public bool? Requerido { get; set; }
        public bool? Solicitante { get; set; }
        public bool? Solicitar_Archivo_Adjunto { get; set; }

        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }
        [ForeignKey("Tipo_de_Documento")]
        public virtual Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento Tipo_de_Documento_Tipo_de_Documento { get; set; }

    }
	
	public class Documento_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Origen { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public int? idFormato { get; set; }
        public bool? Requerido { get; set; }
        public bool? Solicitante { get; set; }
        public bool? Solicitar_Archivo_Adjunto { get; set; }

		        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }
        [ForeignKey("Tipo_de_Documento")]
        public virtual Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento Tipo_de_Documento_Tipo_de_Documento { get; set; }

    }


}

