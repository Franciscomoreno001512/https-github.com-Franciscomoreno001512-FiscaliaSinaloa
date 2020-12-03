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

namespace Spartane.Core.Domain.Aseguramientos
{
    /// <summary>
    /// Aseguramientos table
    /// </summary>
    public class Aseguramientos: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }

        [ForeignKey("Expediente")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }

    }
	
	public class Aseguramientos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }

		        [ForeignKey("Expediente")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }

    }

	public class Aseguramientos_Medios_de_Transporte_Involucrados
    {
                public int Clave { get; set; }

		
    }

	public class Aseguramientos_Drogas_Involucradas
    {
                public int Clave { get; set; }

		
    }

	public class Aseguramientos_Armas_Involucradas
    {
                public int Clave { get; set; }

		
    }

	public class Aseguramientos_Objetos_Asegurados
    {
                public int Clave { get; set; }

		
    }

	public class Aseguramientos_Otros_Aseguramientos
    {
                public int Clave { get; set; }

		
    }


}

