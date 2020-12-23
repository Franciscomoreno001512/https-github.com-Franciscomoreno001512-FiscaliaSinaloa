using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Otro_Nombre
{
    /// <summary>
    /// Detalle_de_Otro_Nombre table
    /// </summary>
    public class Detalle_de_Otro_Nombre: BaseEntity
    {
        public int Clave { get; set; }
        public int? Orden_Aprehension { get; set; }
        public string Otro_Nombre_del_Individuo { get; set; }
        public string Otro_Apellido_Paterno_del_Individuo { get; set; }
        public string Otro_Apellido_Materno_del_Individuo { get; set; }
        public string Otro_Alias_del_Individuo { get; set; }

        [ForeignKey("Orden_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Orden_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }

    }
	
	public class Detalle_de_Otro_Nombre_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Orden_Aprehension { get; set; }
        public string Otro_Nombre_del_Individuo { get; set; }
        public string Otro_Apellido_Paterno_del_Individuo { get; set; }
        public string Otro_Apellido_Materno_del_Individuo { get; set; }
        public string Otro_Alias_del_Individuo { get; set; }

		        [ForeignKey("Orden_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Orden_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }

    }


}

