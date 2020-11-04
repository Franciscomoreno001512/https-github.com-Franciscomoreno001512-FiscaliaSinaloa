using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Catalogo_Estatus_de_Replicacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Bitacora_de_Sincronizacion
{
    /// <summary>
    /// Bitacora_de_Sincronizacion table
    /// </summary>
    public class Bitacora_de_Sincronizacion: BaseEntity
    {
        public int Clave { get; set; }
        public string ID_Dispositivo { get; set; }
        public int? Usuario { get; set; }
        public string Nombre_de_la_Tabla { get; set; }
        public int? Estatus_de_Replicacion { get; set; }

        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }
        [ForeignKey("Estatus_de_Replicacion")]
        public virtual Spartane.Core.Domain.Catalogo_Estatus_de_Replicacion.Catalogo_Estatus_de_Replicacion Estatus_de_Replicacion_Catalogo_Estatus_de_Replicacion { get; set; }

    }
	
	public class Bitacora_de_Sincronizacion_Datos_Generales
    {
                public int Clave { get; set; }
        public string ID_Dispositivo { get; set; }
        public int? Usuario { get; set; }
        public string Nombre_de_la_Tabla { get; set; }
        public int? Estatus_de_Replicacion { get; set; }

		        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }
        [ForeignKey("Estatus_de_Replicacion")]
        public virtual Spartane.Core.Domain.Catalogo_Estatus_de_Replicacion.Catalogo_Estatus_de_Replicacion Estatus_de_Replicacion_Catalogo_Estatus_de_Replicacion { get; set; }

    }


}

