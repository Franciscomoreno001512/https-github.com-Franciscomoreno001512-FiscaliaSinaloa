using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Tipo_de_Zona;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles
{
    /// <summary>
    /// Detalle_Aseguramiento_Inmuebles table
    /// </summary>
    public class Detalle_Aseguramiento_Inmuebles: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Zona { get; set; }
        public string Tipo { get; set; }
        public string Especifique_Otro { get; set; }
        public string Calle { get; set; }
        public string Exterior { get; set; }
        public string Interior { get; set; }
        public string C_P { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public string Colonia { get; set; }
        public string Registro_Publico_Propiedad { get; set; }
        public string Entrecalles { get; set; }
        public string Propietario { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Zona")]
        public virtual Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona Zona_Tipo_de_Zona { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }

    }
	
	public class Detalle_Aseguramiento_Inmuebles_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Zona { get; set; }
        public string Tipo { get; set; }
        public string Especifique_Otro { get; set; }
        public string Calle { get; set; }
        public string Exterior { get; set; }
        public string Interior { get; set; }
        public string C_P { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public string Colonia { get; set; }
        public string Registro_Publico_Propiedad { get; set; }
        public string Entrecalles { get; set; }
        public string Propietario { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Zona")]
        public virtual Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona Zona_Tipo_de_Zona { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }

    }


}

