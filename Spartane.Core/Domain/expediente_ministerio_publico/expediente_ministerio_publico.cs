using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.estatus_mpi;
using Spartane.Core.Domain.detalle_de_observaciones_mpi;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Estatus_Orientador;
using Spartane.Core.Domain.Tipo_de_Acuerdo;
using Spartane.Core.Domain.Periodicidad;
using Spartane.Core.Domain.tipo_de_cierre;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.expediente_ministerio_publico
{
    /// <summary>
    /// expediente_ministerio_publico table
    /// </summary>
    public class expediente_ministerio_publico: BaseEntity
    {
        public int clave { get; set; }
        public DateTime? fecha_de_registro { get; set; }
        public string hora_de_registro { get; set; }
        public int? usuario_que_registra { get; set; }
        public int? unidad { get; set; }
        public string nuat { get; set; }
        public string nic { get; set; }
        public short? detenido { get; set; }
        public string hora_del_detenido { get; set; }
        public string hora_puesto_a_disposicion { get; set; }
        public short? estatus { get; set; }
        public int? observaciones { get; set; }
        public DateTime? Fecha_de_Canalizacion { get; set; }
        public string Hora_de_Canalizacion { get; set; }
        public int? usuario_que_canaliza { get; set; }
        public int? canalizar_a { get; set; }
        public int? tipo_de_acuerdo { get; set; }
        public DateTime? fecha_de_inicio_de_acuerdo { get; set; }
        public DateTime? fecha_de_cumplimiento { get; set; }
        public string hora_de_cumplimiento { get; set; }
        public string domicilio_para_el_cumplimiento { get; set; }
        public decimal? monto_de_reparacion_de_danos { get; set; }
        public int? parcialidades { get; set; }
        public int? periodicidad { get; set; }
        public bool? acepta_acuerdo { get; set; }
        public string motivo_de_rechazo_de_acuerdo { get; set; }
        public DateTime? fecha_de_cierre { get; set; }
        public string hora_de_cierre { get; set; }
        public int? tipo_de_cierre { get; set; }
        public string comentarios_de_cierre { get; set; }

        [ForeignKey("usuario_que_registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User usuario_que_registra_Spartan_User { get; set; }
        [ForeignKey("unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad unidad_Unidad { get; set; }
        [ForeignKey("detenido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo detenido_A_Tiempo { get; set; }
        [ForeignKey("estatus")]
        public virtual Spartane.Core.Domain.estatus_mpi.estatus_mpi estatus_estatus_mpi { get; set; }
        [ForeignKey("observaciones")]
        public virtual Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi observaciones_detalle_de_observaciones_mpi { get; set; }
        [ForeignKey("usuario_que_canaliza")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User usuario_que_canaliza_Spartan_User { get; set; }
        [ForeignKey("canalizar_a")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador canalizar_a_Estatus_Orientador { get; set; }
        [ForeignKey("tipo_de_acuerdo")]
        public virtual Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo tipo_de_acuerdo_Tipo_de_Acuerdo { get; set; }
        [ForeignKey("periodicidad")]
        public virtual Spartane.Core.Domain.Periodicidad.Periodicidad periodicidad_Periodicidad { get; set; }
        [ForeignKey("tipo_de_cierre")]
        public virtual Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre tipo_de_cierre_tipo_de_cierre { get; set; }

    }
	
	public class expediente_ministerio_publico_Datos_del_Caso
    {
                public int clave { get; set; }
        public DateTime? fecha_de_registro { get; set; }
        public string hora_de_registro { get; set; }
        public int? usuario_que_registra { get; set; }
        public int? unidad { get; set; }
        public string nuat { get; set; }
        public string nic { get; set; }
        public short? detenido { get; set; }
        public string hora_del_detenido { get; set; }
        public string hora_puesto_a_disposicion { get; set; }
        public short? estatus { get; set; }
        public int? observaciones { get; set; }

		        [ForeignKey("usuario_que_registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User usuario_que_registra_Spartan_User { get; set; }
        [ForeignKey("unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad unidad_Unidad { get; set; }
        [ForeignKey("detenido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo detenido_A_Tiempo { get; set; }
        [ForeignKey("estatus")]
        public virtual Spartane.Core.Domain.estatus_mpi.estatus_mpi estatus_estatus_mpi { get; set; }
        [ForeignKey("observaciones")]
        public virtual Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi observaciones_detalle_de_observaciones_mpi { get; set; }

    }

	public class expediente_ministerio_publico_Canalizar
    {
                public int clave { get; set; }
        public DateTime? Fecha_de_Canalizacion { get; set; }
        public string Hora_de_Canalizacion { get; set; }
        public int? usuario_que_canaliza { get; set; }
        public int? canalizar_a { get; set; }

		        [ForeignKey("usuario_que_canaliza")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User usuario_que_canaliza_Spartan_User { get; set; }
        [ForeignKey("canalizar_a")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador canalizar_a_Estatus_Orientador { get; set; }

    }

	public class expediente_ministerio_publico_Datos_del_Acuerdo
    {
                public int clave { get; set; }
        public int? tipo_de_acuerdo { get; set; }
        public DateTime? fecha_de_inicio_de_acuerdo { get; set; }
        public DateTime? fecha_de_cumplimiento { get; set; }
        public string hora_de_cumplimiento { get; set; }
        public string domicilio_para_el_cumplimiento { get; set; }
        public decimal? monto_de_reparacion_de_danos { get; set; }
        public int? parcialidades { get; set; }
        public int? periodicidad { get; set; }
        public bool? acepta_acuerdo { get; set; }
        public string motivo_de_rechazo_de_acuerdo { get; set; }

		        [ForeignKey("tipo_de_acuerdo")]
        public virtual Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo tipo_de_acuerdo_Tipo_de_Acuerdo { get; set; }
        [ForeignKey("periodicidad")]
        public virtual Spartane.Core.Domain.Periodicidad.Periodicidad periodicidad_Periodicidad { get; set; }

    }

	public class expediente_ministerio_publico_Cierre_de_Expediente
    {
                public int clave { get; set; }
        public DateTime? fecha_de_cierre { get; set; }
        public string hora_de_cierre { get; set; }
        public int? tipo_de_cierre { get; set; }
        public string comentarios_de_cierre { get; set; }

		        [ForeignKey("tipo_de_cierre")]
        public virtual Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre tipo_de_cierre_tipo_de_cierre { get; set; }

    }


}

