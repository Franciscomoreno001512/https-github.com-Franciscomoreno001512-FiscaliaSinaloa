using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Control_de_Documentos;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Historial_Control_de_Documentos
{
    /// <summary>
    /// Detalle_Historial_Control_de_Documentos table
    /// </summary>
    public class Detalle_Historial_Control_de_Documentos: BaseEntity
    {
        public int Folio { get; set; }
        public int? Control_de_Documentos { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string Modificaciones_Realizadas { get; set; }
        public string Cuerpo_del_Documento { get; set; }

        [ForeignKey("Control_de_Documentos")]
        public virtual Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos Control_de_Documentos_Control_de_Documentos { get; set; }
        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }

    }
	
	public class Detalle_Historial_Control_de_Documentos_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Control_de_Documentos { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string Modificaciones_Realizadas { get; set; }
        public string Cuerpo_del_Documento { get; set; }

		        [ForeignKey("Control_de_Documentos")]
        public virtual Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos Control_de_Documentos_Control_de_Documentos { get; set; }
        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }

    }


}

