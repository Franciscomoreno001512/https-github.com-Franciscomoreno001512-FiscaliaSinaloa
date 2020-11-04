using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;
using Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Traslado_de_CC
{
    /// <summary>
    /// Detalle_de_Traslado_de_CC table
    /// </summary>
    public class Detalle_de_Traslado_de_CC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Cadena_de_Custodia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Temperatura { get; set; }
        public string Humedad { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Estatus { get; set; }

        [ForeignKey("Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_de_Custodia_Cadena_de_Custodia { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado Estatus_Catalogo_de_Estatus_de_Traslado { get; set; }

    }
	
	public class Detalle_de_Traslado_de_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Cadena_de_Custodia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Temperatura { get; set; }
        public string Humedad { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Estatus { get; set; }

		        [ForeignKey("Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_de_Custodia_Cadena_de_Custodia { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado Estatus_Catalogo_de_Estatus_de_Traslado { get; set; }

    }


}

