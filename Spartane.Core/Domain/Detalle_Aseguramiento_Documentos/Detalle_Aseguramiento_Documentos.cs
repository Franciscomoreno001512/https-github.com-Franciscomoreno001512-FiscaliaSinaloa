using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Motivo_de_Registro;
using Spartane.Core.Domain.Tipo_de_Documentos;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Documentos
{
    /// <summary>
    /// Detalle_Aseguramiento_Documentos table
    /// </summary>
    public class Detalle_Aseguramiento_Documentos: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public int? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public string Descipcion_de_Documento { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Motivo_de_Registro")]
        public virtual Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro Motivo_de_Registro_Motivo_de_Registro { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Documentos.Tipo_de_Documentos Tipo_Tipo_de_Documentos { get; set; }

    }
	
	public class Detalle_Aseguramiento_Documentos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public int? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public string Descipcion_de_Documento { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Motivo_de_Registro")]
        public virtual Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro Motivo_de_Registro_Motivo_de_Registro { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Documentos.Tipo_de_Documentos Tipo_Tipo_de_Documentos { get; set; }

    }


}

