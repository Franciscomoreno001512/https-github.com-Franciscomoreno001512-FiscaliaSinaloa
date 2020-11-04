using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Marca_del_Vehiculo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Sub_Marca_del_Vehiculo
{
    /// <summary>
    /// Sub_Marca_del_Vehiculo table
    /// </summary>
    public class Sub_Marca_del_Vehiculo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Marca_del_Vehiculo { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Marca_del_Vehiculo")]
        public virtual Spartane.Core.Domain.Marca_del_Vehiculo.Marca_del_Vehiculo Marca_del_Vehiculo_Marca_del_Vehiculo { get; set; }

    }
	
	public class Sub_Marca_del_Vehiculo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Marca_del_Vehiculo { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Marca_del_Vehiculo")]
        public virtual Spartane.Core.Domain.Marca_del_Vehiculo.Marca_del_Vehiculo Marca_del_Vehiculo_Marca_del_Vehiculo { get; set; }

    }


}

