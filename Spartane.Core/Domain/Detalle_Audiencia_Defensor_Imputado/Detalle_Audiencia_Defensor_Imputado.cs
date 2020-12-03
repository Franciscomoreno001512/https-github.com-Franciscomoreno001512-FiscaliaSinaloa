using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Audiencias_MP;
using Spartane.Core.Domain.Detalle_de_Imputado;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Audiencia_Defensor_Imputado
{
    /// <summary>
    /// Detalle_Audiencia_Defensor_Imputado table
    /// </summary>
    public class Detalle_Audiencia_Defensor_Imputado: BaseEntity
    {
        public int Clave { get; set; }
        public int? Audiencia { get; set; }
        public int? Nombre_Del_Imputado { get; set; }
        public string Abogado { get; set; }
        public string Cedula_Profesional { get; set; }

        [ForeignKey("Audiencia")]
        public virtual Spartane.Core.Domain.Audiencias_MP.Audiencias_MP Audiencia_Audiencias_MP { get; set; }
        [ForeignKey("Nombre_Del_Imputado")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Nombre_Del_Imputado_Detalle_de_Imputado { get; set; }

    }
	
	public class Detalle_Audiencia_Defensor_Imputado_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Audiencia { get; set; }
        public int? Nombre_Del_Imputado { get; set; }
        public string Abogado { get; set; }
        public string Cedula_Profesional { get; set; }

		        [ForeignKey("Audiencia")]
        public virtual Spartane.Core.Domain.Audiencias_MP.Audiencias_MP Audiencia_Audiencias_MP { get; set; }
        [ForeignKey("Nombre_Del_Imputado")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Nombre_Del_Imputado_Detalle_de_Imputado { get; set; }

    }


}

