using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Vigencia;
using Spartane.Core.Domain.Tipo_de_Localidad;
using Spartane.Core.Domain.Colonia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Colonia
{
    /// <summary>
    /// Colonia table
    /// </summary>
    public class Colonia: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Municipio { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Zona { get; set; }
        public int? Vigente { get; set; }
        public string Observaciones { get; set; }
        public int? cod_pais { get; set; }
        public int? cod_edo { get; set; }
        public int? loc_justicia { get; set; }
        public int? pob_justicia { get; set; }
        public int? sector { get; set; }
        public string estatus { get; set; }
        public int? cod_localidad { get; set; }
        public int? Tipo { get; set; }
        public int? Poblacion { get; set; }

        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Vigente")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigente_Vigencia { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Localidad.Tipo_de_Localidad Tipo_Tipo_de_Localidad { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }

    }
	
	public class Colonia_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Municipio { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Zona { get; set; }
        public int? Vigente { get; set; }
        public string Observaciones { get; set; }
        public int? cod_pais { get; set; }
        public int? cod_edo { get; set; }
        public int? loc_justicia { get; set; }
        public int? pob_justicia { get; set; }
        public int? sector { get; set; }
        public string estatus { get; set; }
        public int? cod_localidad { get; set; }
        public int? Tipo { get; set; }
        public int? Poblacion { get; set; }

		        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Vigente")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigente_Vigencia { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Localidad.Tipo_de_Localidad Tipo_Tipo_de_Localidad { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }

    }


}

