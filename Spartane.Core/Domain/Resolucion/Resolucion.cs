using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Resolucion;
using Spartane.Core.Domain.Resolucion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Resolucion
{
    /// <summary>
    /// Resolucion table
    /// </summary>
    public class Resolucion: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo { get; set; }
        public int? Resolucion_Padre_para_Autorizacion { get; set; }
        public bool? Generar_Judicializacion { get; set; }

        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Resolucion.Tipo_de_Resolucion Tipo_Tipo_de_Resolucion { get; set; }
        [ForeignKey("Resolucion_Padre_para_Autorizacion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resolucion_Padre_para_Autorizacion_Resolucion { get; set; }

    }
	
	public class Resolucion_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo { get; set; }
        public int? Resolucion_Padre_para_Autorizacion { get; set; }
        public bool? Generar_Judicializacion { get; set; }

		        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Resolucion.Tipo_de_Resolucion Tipo_Tipo_de_Resolucion { get; set; }
        [ForeignKey("Resolucion_Padre_para_Autorizacion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resolucion_Padre_para_Autorizacion_Resolucion { get; set; }

    }


}

