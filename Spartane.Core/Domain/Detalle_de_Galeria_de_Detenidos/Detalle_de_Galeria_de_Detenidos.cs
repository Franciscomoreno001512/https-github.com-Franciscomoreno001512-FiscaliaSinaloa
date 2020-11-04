using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_CC;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos
{
    /// <summary>
    /// Detalle_de_Galeria_de_Detenidos table
    /// </summary>
    public class Detalle_de_Galeria_de_Detenidos: BaseEntity
    {
        public int Clave { get; set; }
        public int? Detalle_de_Imputados { get; set; }
        public string Nombre { get; set; }
        public short? Archivo { get; set; }

        [ForeignKey("Detalle_de_Imputados")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_CC.Detalle_de_Datos_del_Imputado_CC Detalle_de_Imputados_Detalle_de_Datos_del_Imputado_CC { get; set; }

    }
	
	public class Detalle_de_Galeria_de_Detenidos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Detalle_de_Imputados { get; set; }
        public string Nombre { get; set; }
        public short? Archivo { get; set; }

		        [ForeignKey("Detalle_de_Imputados")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_CC.Detalle_de_Datos_del_Imputado_CC Detalle_de_Imputados_Detalle_de_Datos_del_Imputado_CC { get; set; }

    }


}

