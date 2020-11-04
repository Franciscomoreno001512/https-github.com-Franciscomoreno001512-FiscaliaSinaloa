using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Errores_de_Replicacion
{
    /// <summary>
    /// Errores_de_Replicacion table
    /// </summary>
    public class Errores_de_Replicacion: BaseEntity
    {
        public int Clave { get; set; }
        public string ID_del_Dispositivo { get; set; }
        public int? Usuario { get; set; }
        public DateTime? Fecha_del_Error { get; set; }
        public string Hora_del_Error { get; set; }
        public string Campo_con_Error { get; set; }
        public string Valor_del_Campo_en_Dispositivo { get; set; }
        public string Valor_del_Campo_en_Web { get; set; }
        public int? Folio { get; set; }

        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }

    }
	
	public class Errores_de_Replicacion_Datos_Generales
    {
                public int Clave { get; set; }
        public string ID_del_Dispositivo { get; set; }
        public int? Usuario { get; set; }
        public DateTime? Fecha_del_Error { get; set; }
        public string Hora_del_Error { get; set; }
        public string Campo_con_Error { get; set; }
        public string Valor_del_Campo_en_Dispositivo { get; set; }
        public string Valor_del_Campo_en_Web { get; set; }
        public int? Folio { get; set; }

		        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }

    }


}

