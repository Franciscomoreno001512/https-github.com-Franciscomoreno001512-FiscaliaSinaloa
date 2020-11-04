using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Lugares;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Lugares_Frecuentes_Probable_Responsable
{
    /// <summary>
    /// Lugares_Frecuentes_Probable_Responsable table
    /// </summary>
    public class Lugares_Frecuentes_Probable_Responsable: BaseEntity
    {
        public int Clave { get; set; }
        public int? Probable_Resposable { get; set; }
        public int? Tipo_de_Lugar { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Probable_Resposable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Resposable_Detalle_de_Imputado { get; set; }
        [ForeignKey("Tipo_de_Lugar")]
        public virtual Spartane.Core.Domain.Lugares.Lugares Tipo_de_Lugar_Lugares { get; set; }

    }
	
	public class Lugares_Frecuentes_Probable_Responsable_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Probable_Resposable { get; set; }
        public int? Tipo_de_Lugar { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Probable_Resposable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Resposable_Detalle_de_Imputado { get; set; }
        [ForeignKey("Tipo_de_Lugar")]
        public virtual Spartane.Core.Domain.Lugares.Lugares Tipo_de_Lugar_Lugares { get; set; }

    }


}

