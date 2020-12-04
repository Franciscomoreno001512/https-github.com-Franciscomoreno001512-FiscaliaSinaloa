using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Tipo_de_Arma;
using Spartane.Core.Domain.Marca_de_Arma;
using Spartane.Core.Domain.Calibre_de_Arma;
using Spartane.Core.Domain.Tipo_Clasificacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas
{
    /// <summary>
    /// Detalle_Aseguramiento_Armas_Involucradas table
    /// </summary>
    public class Detalle_Aseguramiento_Armas_Involucradas: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Tipo { get; set; }
        public string Descripcion_del_Arma { get; set; }
        public int? Marca { get; set; }
        public short? Calibre { get; set; }
        public string Matricula { get; set; }
        public string Serie { get; set; }
        public string Inventario { get; set; }
        public int? Clasificacion { get; set; }
        public int? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Arma.Tipo_de_Arma Tipo_Tipo_de_Arma { get; set; }
        [ForeignKey("Marca")]
        public virtual Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma Marca_Marca_de_Arma { get; set; }
        [ForeignKey("Calibre")]
        public virtual Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma Calibre_Calibre_de_Arma { get; set; }
        [ForeignKey("Clasificacion")]
        public virtual Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion Clasificacion_Tipo_Clasificacion { get; set; }

    }
	
	public class Detalle_Aseguramiento_Armas_Involucradas_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Tipo { get; set; }
        public string Descripcion_del_Arma { get; set; }
        public int? Marca { get; set; }
        public short? Calibre { get; set; }
        public string Matricula { get; set; }
        public string Serie { get; set; }
        public string Inventario { get; set; }
        public int? Clasificacion { get; set; }
        public int? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Arma.Tipo_de_Arma Tipo_Tipo_de_Arma { get; set; }
        [ForeignKey("Marca")]
        public virtual Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma Marca_Marca_de_Arma { get; set; }
        [ForeignKey("Calibre")]
        public virtual Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma Calibre_Calibre_de_Arma { get; set; }
        [ForeignKey("Clasificacion")]
        public virtual Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion Clasificacion_Tipo_Clasificacion { get; set; }

    }


}

