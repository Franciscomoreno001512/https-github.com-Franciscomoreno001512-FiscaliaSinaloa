using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Juzgado;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales
{
    /// <summary>
    /// Consulta_de_Mandamientos_Judiciales table
    /// </summary>
    public class Consulta_de_Mandamientos_Judiciales: BaseEntity
    {
        public int Clave { get; set; }
        public int? MandamientoJudicialId { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Juzgado { get; set; }
        public string Oficio_Solicitud_Juzgado { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Causa_Penal { get; set; }

        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Juzgado")]
        public virtual Spartane.Core.Domain.Juzgado.Juzgado Juzgado_Juzgado { get; set; }

    }
	
	public class Consulta_de_Mandamientos_Judiciales_Datos_Generales
    {
                public int Clave { get; set; }
        public int? MandamientoJudicialId { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Juzgado { get; set; }
        public string Oficio_Solicitud_Juzgado { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Causa_Penal { get; set; }

		        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Juzgado")]
        public virtual Spartane.Core.Domain.Juzgado.Juzgado Juzgado_Juzgado { get; set; }

    }


}

