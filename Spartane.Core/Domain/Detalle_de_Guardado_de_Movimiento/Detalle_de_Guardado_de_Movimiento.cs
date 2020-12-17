using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Movimiento;
using Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Guardado_de_Movimiento
{
    /// <summary>
    /// Detalle_de_Guardado_de_Movimiento table
    /// </summary>
    public class Detalle_de_Guardado_de_Movimiento: BaseEntity
    {
        public int Clave { get; set; }
        public int? Registro_de_Movimiento { get; set; }
        public int? Campo { get; set; }
        public string Etiqueta { get; set; }
        public string Valor { get; set; }

        [ForeignKey("Registro_de_Movimiento")]
        public virtual Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento Registro_de_Movimiento_Registro_de_Movimiento { get; set; }
        [ForeignKey("Campo")]
        public virtual Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento Campo_Detalle_Datos_Adicionales_Movimiento { get; set; }

    }
	
	public class Detalle_de_Guardado_de_Movimiento_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Registro_de_Movimiento { get; set; }
        public int? Campo { get; set; }
        public string Etiqueta { get; set; }
        public string Valor { get; set; }

		        [ForeignKey("Registro_de_Movimiento")]
        public virtual Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento Registro_de_Movimiento_Registro_de_Movimiento { get; set; }
        [ForeignKey("Campo")]
        public virtual Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento Campo_Detalle_Datos_Adicionales_Movimiento { get; set; }

    }


}

