using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Documento;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Documentos_MPO
{
    /// <summary>
    /// Detalle_de_Documentos_MPO table
    /// </summary>
    public class Detalle_de_Documentos_MPO: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public int? Documento { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }
        public string Observaciones { get; set; }
        public int? Archivo { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Documento")]
        public virtual Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento Tipo_de_Documento_Tipo_de_Documento { get; set; }
        [ForeignKey("Documento")]
        public virtual Spartane.Core.Domain.Documento.Documento Documento_Documento { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }

    }
	
	public class Detalle_de_Documentos_MPO_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public int? Documento { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }
        public string Observaciones { get; set; }
        public int? Archivo { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Documento")]
        public virtual Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento Tipo_de_Documento_Tipo_de_Documento { get; set; }
        [ForeignKey("Documento")]
        public virtual Spartane.Core.Domain.Documento.Documento Documento_Documento { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }

    }


}

