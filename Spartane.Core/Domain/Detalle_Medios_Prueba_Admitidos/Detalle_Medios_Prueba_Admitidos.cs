using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Proceso_Penal;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos
{
    /// <summary>
    /// Detalle_Medios_Prueba_Admitidos table
    /// </summary>
    public class Detalle_Medios_Prueba_Admitidos: BaseEntity
    {
        public int Clave { get; set; }
        public int? Proceso_Penal { get; set; }
        public string Origen { get; set; }
        public string Medio_de_Prueba_Presentado { get; set; }
        public bool? Admitido { get; set; }

        [ForeignKey("Proceso_Penal")]
        public virtual Spartane.Core.Domain.Proceso_Penal.Proceso_Penal Proceso_Penal_Proceso_Penal { get; set; }

    }
	
	public class Detalle_Medios_Prueba_Admitidos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Proceso_Penal { get; set; }
        public string Origen { get; set; }
        public string Medio_de_Prueba_Presentado { get; set; }
        public bool? Admitido { get; set; }

		        [ForeignKey("Proceso_Penal")]
        public virtual Spartane.Core.Domain.Proceso_Penal.Proceso_Penal Proceso_Penal_Proceso_Penal { get; set; }

    }


}

