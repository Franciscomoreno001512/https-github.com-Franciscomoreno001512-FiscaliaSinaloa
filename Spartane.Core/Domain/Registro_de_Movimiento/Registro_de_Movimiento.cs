using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Judicializacion;
using Spartane.Core.Domain.Fase_de_Judicializacion;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Configurador_de_Movimientos;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Registro_de_Movimiento
{
    /// <summary>
    /// Registro_de_Movimiento table
    /// </summary>
    public class Registro_de_Movimiento: BaseEntity
    {
        public int Clave { get; set; }
        public int? Judicializacion { get; set; }
        public int? Fase { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Movimiento_Realizado { get; set; }
        public DateTime? Fecha_de_Movimiento { get; set; }
        public string Hora_de_Movimiento { get; set; }
        public string Informacion { get; set; }

        [ForeignKey("Judicializacion")]
        public virtual Spartane.Core.Domain.Judicializacion.Judicializacion Judicializacion_Judicializacion { get; set; }
        [ForeignKey("Fase")]
        public virtual Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion Fase_Fase_de_Judicializacion { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Movimiento_Realizado")]
        public virtual Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos Movimiento_Realizado_Configurador_de_Movimientos { get; set; }

    }
	
	public class Registro_de_Movimiento_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Judicializacion { get; set; }
        public int? Fase { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Movimiento_Realizado { get; set; }
        public DateTime? Fecha_de_Movimiento { get; set; }
        public string Hora_de_Movimiento { get; set; }
        public string Informacion { get; set; }

		        [ForeignKey("Judicializacion")]
        public virtual Spartane.Core.Domain.Judicializacion.Judicializacion Judicializacion_Judicializacion { get; set; }
        [ForeignKey("Fase")]
        public virtual Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion Fase_Fase_de_Judicializacion { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Movimiento_Realizado")]
        public virtual Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos Movimiento_Realizado_Configurador_de_Movimientos { get; set; }

    }


}

