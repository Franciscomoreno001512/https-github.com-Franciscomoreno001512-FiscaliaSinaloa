using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Medidas_Cautelares
{
    /// <summary>
    /// Medidas_Cautelares table
    /// </summary>
    public class Medidas_Cautelares: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Fraccion { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }
        public bool? Aplica_para_Adultos { get; set; }
        public string Tipo { get; set; }


    }
	
	public class Medidas_Cautelares_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Fraccion { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }
        public bool? Aplica_para_Adultos { get; set; }
        public string Tipo { get; set; }

		
    }


}

