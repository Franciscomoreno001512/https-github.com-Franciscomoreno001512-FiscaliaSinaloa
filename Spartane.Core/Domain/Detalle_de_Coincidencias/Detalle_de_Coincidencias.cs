using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Coincidencias;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Coincidencias
{
    /// <summary>
    /// Detalle_de_Coincidencias table
    /// </summary>
    public class Detalle_de_Coincidencias: BaseEntity
    {
        public int Clave { get; set; }
        public int? Registro_de_Coincidencias { get; set; }

        [ForeignKey("Registro_de_Coincidencias")]
        public virtual Spartane.Core.Domain.Registro_de_Coincidencias.Registro_de_Coincidencias Registro_de_Coincidencias_Registro_de_Coincidencias { get; set; }

    }
	
	public class Detalle_de_Coincidencias_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Registro_de_Coincidencias { get; set; }

		        [ForeignKey("Registro_de_Coincidencias")]
        public virtual Spartane.Core.Domain.Registro_de_Coincidencias.Registro_de_Coincidencias Registro_de_Coincidencias_Registro_de_Coincidencias { get; set; }

    }


}

