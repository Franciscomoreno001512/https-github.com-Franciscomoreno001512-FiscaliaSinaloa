using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Circunstancia_Vehiculo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Especifica_Vehiculo
{
    /// <summary>
    /// Especifica_Vehiculo table
    /// </summary>
    public class Especifica_Vehiculo: BaseEntity
    {
        public short? Circunstancia_Vehiculo { get; set; }         public short Clave { get; set; }         public string Descripcion { get; set; } 
        [ForeignKey("Circunstancia_Vehiculo")]
        public virtual Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo Circunstancia_Vehiculo_Circunstancia_Vehiculo { get; set; }

    }
	
	public class Especifica_Vehiculo_Datos_Generales
    {
                public short? Circunstancia_Vehiculo { get; set; }
        public short Clave { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Circunstancia_Vehiculo")]
        public virtual Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo Circunstancia_Vehiculo_Circunstancia_Vehiculo { get; set; }

    }


}

