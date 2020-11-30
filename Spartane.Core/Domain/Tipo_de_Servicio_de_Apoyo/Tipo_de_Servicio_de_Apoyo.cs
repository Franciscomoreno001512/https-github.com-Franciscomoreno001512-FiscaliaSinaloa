using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo
{
    /// <summary>
    /// Tipo_de_Servicio_de_Apoyo table
    /// </summary>
    public class Tipo_de_Servicio_de_Apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public string Servicio { get; set; }
        public short? Categoria { get; set; }

        [ForeignKey("Categoria")]
        public virtual Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo Categoria_Categoria_de_Servicio_de_Apoyo { get; set; }

    }
	
	public class Tipo_de_Servicio_de_Apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public string Servicio { get; set; }
        public short? Categoria { get; set; }

		        [ForeignKey("Categoria")]
        public virtual Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo Categoria_Categoria_de_Servicio_de_Apoyo { get; set; }

    }


}

