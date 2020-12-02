using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Audiencias_MP;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima
{
    /// <summary>
    /// Detalle_Audiencia_Defensor_Victima table
    /// </summary>
    public class Detalle_Audiencia_Defensor_Victima: BaseEntity
    {
        public int Clave { get; set; }
        public int? Audiencia { get; set; }
        public int? Nombre_del_Imputado { get; set; }
        public string Abogado { get; set; }
        public string Cedula_Profesional { get; set; }

        [ForeignKey("Audiencia")]
        public virtual Spartane.Core.Domain.Audiencias_MP.Audiencias_MP Audiencia_Audiencias_MP { get; set; }
        [ForeignKey("Nombre_del_Imputado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Nombre_del_Imputado_Detalle_de_Datos_Generales { get; set; }

    }
	
	public class Detalle_Audiencia_Defensor_Victima_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Audiencia { get; set; }
        public int? Nombre_del_Imputado { get; set; }
        public string Abogado { get; set; }
        public string Cedula_Profesional { get; set; }

		        [ForeignKey("Audiencia")]
        public virtual Spartane.Core.Domain.Audiencias_MP.Audiencias_MP Audiencia_Audiencias_MP { get; set; }
        [ForeignKey("Nombre_del_Imputado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Nombre_del_Imputado_Detalle_de_Datos_Generales { get; set; }

    }


}

