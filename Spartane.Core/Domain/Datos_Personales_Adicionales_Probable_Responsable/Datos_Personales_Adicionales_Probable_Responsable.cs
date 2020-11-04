using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Redes_Sociales;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Datos_Personales_Adicionales_Probable_Responsable
{
    /// <summary>
    /// Datos_Personales_Adicionales_Probable_Responsable table
    /// </summary>
    public class Datos_Personales_Adicionales_Probable_Responsable: BaseEntity
    {
        public int Clave { get; set; }
        public int? Probable_Resposable { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Probable_Resposable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Resposable_Detalle_de_Imputado { get; set; }
        [ForeignKey("Redes_Sociales")]
        public virtual Spartane.Core.Domain.Redes_Sociales.Redes_Sociales Redes_Sociales_Redes_Sociales { get; set; }

    }
	
	public class Datos_Personales_Adicionales_Probable_Responsable_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Probable_Resposable { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Probable_Resposable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Resposable_Detalle_de_Imputado { get; set; }
        [ForeignKey("Redes_Sociales")]
        public virtual Spartane.Core.Domain.Redes_Sociales.Redes_Sociales Redes_Sociales_Redes_Sociales { get; set; }

    }


}

