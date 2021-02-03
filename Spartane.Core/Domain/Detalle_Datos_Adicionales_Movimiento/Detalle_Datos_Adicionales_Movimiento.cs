using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Configurador_de_Movimientos;
using Spartane.Core.Domain.Tipo_de_Dato;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento
{
    /// <summary>
    /// Detalle_Datos_Adicionales_Movimiento table
    /// </summary>
    public class Detalle_Datos_Adicionales_Movimiento: BaseEntity
    {
        public int Clave { get; set; }
        public int? Movimiento { get; set; }
        public string Dato { get; set; }
        public int? Tipo_de_Dato { get; set; }
        public string Query_para_llenado { get; set; }
        public bool? Obligatorio { get; set; }

        [ForeignKey("Movimiento")]
        public virtual Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos Movimiento_Configurador_de_Movimientos { get; set; }
        [ForeignKey("Tipo_de_Dato")]
        public virtual Spartane.Core.Domain.Tipo_de_Dato.Tipo_de_Dato Tipo_de_Dato_Tipo_de_Dato { get; set; }

    }
	
	public class Detalle_Datos_Adicionales_Movimiento_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Movimiento { get; set; }
        public string Dato { get; set; }
        public int? Tipo_de_Dato { get; set; }
        public string Query_para_llenado { get; set; }
        public bool? Obligatorio { get; set; }

		        [ForeignKey("Movimiento")]
        public virtual Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos Movimiento_Configurador_de_Movimientos { get; set; }
        [ForeignKey("Tipo_de_Dato")]
        public virtual Spartane.Core.Domain.Tipo_de_Dato.Tipo_de_Dato Tipo_de_Dato_Tipo_de_Dato { get; set; }

    }


}

