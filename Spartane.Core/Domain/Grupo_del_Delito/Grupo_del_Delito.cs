using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_Delito;
using Spartane.Core.Domain.Titulo_del_Delito;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Grupo_del_Delito
{
    /// <summary>
    /// Grupo_del_Delito table
    /// </summary>
    public class Grupo_del_Delito: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Delito { get; set; }
        public int? Titulo_del_Delito { get; set; }

        [ForeignKey("Tipo_de_Delito")]
        public virtual Spartane.Core.Domain.Tipo_Delito.Tipo_Delito Tipo_de_Delito_Tipo_Delito { get; set; }
        [ForeignKey("Titulo_del_Delito")]
        public virtual Spartane.Core.Domain.Titulo_del_Delito.Titulo_del_Delito Titulo_del_Delito_Titulo_del_Delito { get; set; }

    }
	
	public class Grupo_del_Delito_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Delito { get; set; }
        public int? Titulo_del_Delito { get; set; }

		        [ForeignKey("Tipo_de_Delito")]
        public virtual Spartane.Core.Domain.Tipo_Delito.Tipo_Delito Tipo_de_Delito_Tipo_Delito { get; set; }
        [ForeignKey("Titulo_del_Delito")]
        public virtual Spartane.Core.Domain.Titulo_del_Delito.Titulo_del_Delito Titulo_del_Delito_Titulo_del_Delito { get; set; }

    }


}

