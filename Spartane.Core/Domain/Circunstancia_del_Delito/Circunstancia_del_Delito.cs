using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Titulo_del_Delito;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Core.Domain.Delito;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Circunstancia_del_Delito
{
    /// <summary>
    /// Circunstancia_del_Delito table
    /// </summary>
    public class Circunstancia_del_Delito: BaseEntity
    {
        public int Clave { get; set; }
        public int? Titulo_del_Delito { get; set; }
        public int? Grupo_del_Delito { get; set; }
        public int? Delito { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Titulo_del_Delito")]
        public virtual Spartane.Core.Domain.Titulo_del_Delito.Titulo_del_Delito Titulo_del_Delito_Titulo_del_Delito { get; set; }
        [ForeignKey("Grupo_del_Delito")]
        public virtual Spartane.Core.Domain.Grupo_del_Delito.Grupo_del_Delito Grupo_del_Delito_Grupo_del_Delito { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }

    }
	
	public class Circunstancia_del_Delito_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Titulo_del_Delito { get; set; }
        public int? Grupo_del_Delito { get; set; }
        public int? Delito { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Titulo_del_Delito")]
        public virtual Spartane.Core.Domain.Titulo_del_Delito.Titulo_del_Delito Titulo_del_Delito_Titulo_del_Delito { get; set; }
        [ForeignKey("Grupo_del_Delito")]
        public virtual Spartane.Core.Domain.Grupo_del_Delito.Grupo_del_Delito Grupo_del_Delito_Grupo_del_Delito { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }

    }


}

