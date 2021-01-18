using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Fotos
{
    /// <summary>
    /// Detalle_de_Fotos table
    /// </summary>
    public class Detalle_de_Fotos: BaseEntity
    {
        public int Clave { get; set; }
        public int? Registro_de_Orden_de_Aprehension { get; set; }
        public int? Foto_Perfil_Izquierdo { get; set; }
        public string Foto_Perfil_Izquierdo_URL { get; set; }
        public int? Foto_Perfil_Derecho { get; set; }
        public string Foto_Perfil_Derecho_URL { get; set; }
        public int? Foto_de_Frente { get; set; }
        public string Foto_de_Frente_URL { get; set; }

        [ForeignKey("Registro_de_Orden_de_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Registro_de_Orden_de_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Foto_Perfil_Izquierdo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Foto_Perfil_Izquierdo_Spartane_File { get; set; }
        [ForeignKey("Foto_Perfil_Derecho")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Foto_Perfil_Derecho_Spartane_File { get; set; }
        [ForeignKey("Foto_de_Frente")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Foto_de_Frente_Spartane_File { get; set; }

    }
	
	public class Detalle_de_Fotos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Registro_de_Orden_de_Aprehension { get; set; }
        public int? Foto_Perfil_Izquierdo { get; set; }
        public string Foto_Perfil_Izquierdo_URL { get; set; }
        public int? Foto_Perfil_Derecho { get; set; }
        public string Foto_Perfil_Derecho_URL { get; set; }
        public int? Foto_de_Frente { get; set; }
        public string Foto_de_Frente_URL { get; set; }

		        [ForeignKey("Registro_de_Orden_de_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Registro_de_Orden_de_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Foto_Perfil_Izquierdo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Foto_Perfil_Izquierdo_Spartane_File { get; set; }
        [ForeignKey("Foto_Perfil_Derecho")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Foto_Perfil_Derecho_Spartane_File { get; set; }
        [ForeignKey("Foto_de_Frente")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Foto_de_Frente_Spartane_File { get; set; }

    }


}

