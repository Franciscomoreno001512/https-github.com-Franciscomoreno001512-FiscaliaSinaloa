using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Tipo_de_Plantio;
using Spartane.Core.Domain.Metodo_de_Destruccion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_de_Plantios
{
    /// <summary>
    /// Detalle_Aseguramiento_de_Plantios table
    /// </summary>
    public class Detalle_Aseguramiento_de_Plantios: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Tipo { get; set; }
        public int? No__de_Plantios { get; set; }
        public decimal? Kilogramos { get; set; }
        public short? Metodo_de_Destruccion { get; set; }
        public string Superficie { get; set; }
        public string Altura { get; set; }
        public string Densidad { get; set; }
        public string Peso_por_planta { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio Tipo_Tipo_de_Plantio { get; set; }
        [ForeignKey("Metodo_de_Destruccion")]
        public virtual Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion Metodo_de_Destruccion_Metodo_de_Destruccion { get; set; }

    }
	
	public class Detalle_Aseguramiento_de_Plantios_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Tipo { get; set; }
        public int? No__de_Plantios { get; set; }
        public decimal? Kilogramos { get; set; }
        public short? Metodo_de_Destruccion { get; set; }
        public string Superficie { get; set; }
        public string Altura { get; set; }
        public string Densidad { get; set; }
        public string Peso_por_planta { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio Tipo_Tipo_de_Plantio { get; set; }
        [ForeignKey("Metodo_de_Destruccion")]
        public virtual Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion Metodo_de_Destruccion_Metodo_de_Destruccion { get; set; }

    }


}

