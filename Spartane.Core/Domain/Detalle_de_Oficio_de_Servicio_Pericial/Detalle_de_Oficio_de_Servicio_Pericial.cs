using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Oficios;
using Spartane.Core.Domain.Servicios_Periciales;
using Spartane.Core.Domain.Expediente_Inicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Oficio_de_Servicio_Pericial
{
    /// <summary>
    /// Detalle_de_Oficio_de_Servicio_Pericial table
    /// </summary>
    public class Detalle_de_Oficio_de_Servicio_Pericial: BaseEntity
    {
        public int Clave { get; set; }
        public int? Oficio { get; set; }
        public int? Servicio_Pericial { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }

        [ForeignKey("Oficio")]
        public virtual Spartane.Core.Domain.Tipo_de_Oficios.Tipo_de_Oficios Oficio_Tipo_de_Oficios { get; set; }
        [ForeignKey("Servicio_Pericial")]
        public virtual Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales Servicio_Pericial_Servicios_Periciales { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }
	
	public class Detalle_de_Oficio_de_Servicio_Pericial_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Oficio { get; set; }
        public int? Servicio_Pericial { get; set; }
        public int? Expediente_Inicial_MPI { get; set; }

		        [ForeignKey("Oficio")]
        public virtual Spartane.Core.Domain.Tipo_de_Oficios.Tipo_de_Oficios Oficio_Tipo_de_Oficios { get; set; }
        [ForeignKey("Servicio_Pericial")]
        public virtual Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales Servicio_Pericial_Servicios_Periciales { get; set; }
        [ForeignKey("Expediente_Inicial_MPI")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_MPI_Expediente_Inicial { get; set; }

    }


}

