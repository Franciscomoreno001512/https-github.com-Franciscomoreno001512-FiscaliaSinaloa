using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Registro_de_Coincidencias
{
    /// <summary>
    /// Registro_de_Coincidencias table
    /// </summary>
    public class Registro_de_Coincidencias: BaseEntity
    {
        public int Clave { get; set; }
        public string NUAT { get; set; }
        public short? Numero_de_Coincidencias { get; set; }


    }
	
	public class Registro_de_Coincidencias_Datos_Generales
    {
                public int Clave { get; set; }
        public string NUAT { get; set; }
        public short? Numero_de_Coincidencias { get; set; }

		
    }


}

