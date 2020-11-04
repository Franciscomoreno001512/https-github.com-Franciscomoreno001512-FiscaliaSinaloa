using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Usuario;
using Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Folio_Asignado_de_Usuario
{
    /// <summary>
    /// Detalle_de_Folio_Asignado_de_Usuario table
    /// </summary>
    public class Detalle_de_Folio_Asignado_de_Usuario: BaseEntity
    {
        public int Clave { get; set; }
        public int? Usuario { get; set; }
        public int? Folio { get; set; }
        public int? Estatus_de_Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }

        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Usuario.Usuario Usuario_Usuario { get; set; }
        [ForeignKey("Estatus_de_Folio")]
        public virtual Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio Estatus_de_Folio_Catalogo_de_Estatus_de_Folio { get; set; }

    }
	
	public class Detalle_de_Folio_Asignado_de_Usuario_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Usuario { get; set; }
        public int? Folio { get; set; }
        public int? Estatus_de_Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }

		        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Usuario.Usuario Usuario_Usuario { get; set; }
        [ForeignKey("Estatus_de_Folio")]
        public virtual Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio Estatus_de_Folio_Catalogo_de_Estatus_de_Folio { get; set; }

    }


}

