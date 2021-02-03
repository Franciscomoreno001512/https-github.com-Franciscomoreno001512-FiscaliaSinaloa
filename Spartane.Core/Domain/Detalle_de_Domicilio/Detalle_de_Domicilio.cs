using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Tipo_de_Domicilio;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Domicilio
{
    /// <summary>
    /// Detalle_de_Domicilio table
    /// </summary>
    public class Detalle_de_Domicilio: BaseEntity
    {
        public int Clave { get; set; }
        public int? Registro_Orden_Aprehension { get; set; }
        public int? Tipo_de_Domicilio { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Observaciones_Comentarios { get; set; }

        [ForeignKey("Registro_Orden_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Registro_Orden_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Tipo_de_Domicilio")]
        public virtual Spartane.Core.Domain.Tipo_de_Domicilio.Tipo_de_Domicilio Tipo_de_Domicilio_Tipo_de_Domicilio { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }
	
	public class Detalle_de_Domicilio_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Registro_Orden_Aprehension { get; set; }
        public int? Tipo_de_Domicilio { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Observaciones_Comentarios { get; set; }

		        [ForeignKey("Registro_Orden_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Registro_Orden_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Tipo_de_Domicilio")]
        public virtual Spartane.Core.Domain.Tipo_de_Domicilio.Tipo_de_Domicilio Tipo_de_Domicilio_Tipo_de_Domicilio { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }


}

