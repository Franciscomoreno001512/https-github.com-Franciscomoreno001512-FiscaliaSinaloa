using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.detalle_de_observaciones_mpi
{
    /// <summary>
    /// detalle_de_observaciones_mpi table
    /// </summary>
    public class detalle_de_observaciones_mpi: BaseEntity
    {
        public int clave { get; set; }
        public int? expediente_inicial { get; set; }
        public string observaciones { get; set; }
        public DateTime? fecha { get; set; }
        public string hora { get; set; }
        public int? usuario_que_realiza_observacion { get; set; }

        [ForeignKey("expediente_inicial")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico expediente_inicial_expediente_ministerio_publico { get; set; }
        [ForeignKey("usuario_que_realiza_observacion")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User usuario_que_realiza_observacion_Spartan_User { get; set; }

    }
	
	public class detalle_de_observaciones_mpi_Datos_Generales
    {
                public int clave { get; set; }
        public int? expediente_inicial { get; set; }
        public string observaciones { get; set; }
        public DateTime? fecha { get; set; }
        public string hora { get; set; }
        public int? usuario_que_realiza_observacion { get; set; }

		        [ForeignKey("expediente_inicial")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico expediente_inicial_expediente_ministerio_publico { get; set; }
        [ForeignKey("usuario_que_realiza_observacion")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User usuario_que_realiza_observacion_Spartan_User { get; set; }

    }


}

