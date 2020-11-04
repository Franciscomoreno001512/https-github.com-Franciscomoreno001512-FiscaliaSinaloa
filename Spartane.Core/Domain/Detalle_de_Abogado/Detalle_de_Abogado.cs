using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Abogado;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Abogado
{
    /// <summary>
    /// Detalle_de_Abogado table
    /// </summary>
    public class Detalle_de_Abogado: BaseEntity
    {
        public int Clave { get; set; }
        public string NUC { get; set; }
        public string Nombre_del_Representado { get; set; }
        public string Tipo_de_Representante { get; set; }
        public string Comentarios { get; set; }
        public int? Pantalla_Abogados { get; set; }

        [ForeignKey("Pantalla_Abogados")]
        public virtual Spartane.Core.Domain.Abogado.Abogado Pantalla_Abogados_Abogado { get; set; }

    }
	
	public class Detalle_de_Abogado_Datos_Generales
    {
                public int Clave { get; set; }
        public string NUC { get; set; }
        public string Nombre_del_Representado { get; set; }
        public string Tipo_de_Representante { get; set; }
        public string Comentarios { get; set; }
        public int? Pantalla_Abogados { get; set; }

		        [ForeignKey("Pantalla_Abogados")]
        public virtual Spartane.Core.Domain.Abogado.Abogado Pantalla_Abogados_Abogado { get; set; }

    }


}

