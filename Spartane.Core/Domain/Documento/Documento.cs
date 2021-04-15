using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Dilgencia_MASC;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Tipo_de_Documento;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;

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
        public int? Diligencia { get; set; }
        public int? Origen { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public int? Area_de_Servicios_de_Apoyo { get; set; }
        public int? SubArea_de_Servicios_de_Apoyo { get; set; }
        public int? idFormato { get; set; }
        public bool? Requerido { get; set; }
        public bool? Solicitante { get; set; }
        public bool? Requerido_o_Solicitante { get; set; }
        public bool? Solicitar_Archivo_Adjunto { get; set; }
        public bool? Solicitar_Numero_de_Oficio { get; set; }

        [ForeignKey("Diligencia")]
        public virtual Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC Diligencia_Dilgencia_MASC { get; set; }
        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }
        [ForeignKey("Tipo_de_Documento")]
        public virtual Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento Tipo_de_Documento_Tipo_de_Documento { get; set; }
        [ForeignKey("Area_de_Servicios_de_Apoyo")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("SubArea_de_Servicios_de_Apoyo")]
        public virtual Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo.SubArea_de_Servicios_de_Apoyo SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo { get; set; }

    }
	
	public class Documento_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Diligencia { get; set; }
        public int? Origen { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public int? Area_de_Servicios_de_Apoyo { get; set; }
        public int? SubArea_de_Servicios_de_Apoyo { get; set; }
        public int? idFormato { get; set; }
        public bool? Requerido { get; set; }
        public bool? Solicitante { get; set; }
        public bool? Requerido_o_Solicitante { get; set; }
        public bool? Solicitar_Archivo_Adjunto { get; set; }
        public bool? Solicitar_Numero_de_Oficio { get; set; }

		        [ForeignKey("Diligencia")]
        public virtual Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC Diligencia_Dilgencia_MASC { get; set; }
        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }
        [ForeignKey("Tipo_de_Documento")]
        public virtual Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento Tipo_de_Documento_Tipo_de_Documento { get; set; }
        [ForeignKey("Area_de_Servicios_de_Apoyo")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("SubArea_de_Servicios_de_Apoyo")]
        public virtual Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo.SubArea_de_Servicios_de_Apoyo SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo { get; set; }

    }


}

