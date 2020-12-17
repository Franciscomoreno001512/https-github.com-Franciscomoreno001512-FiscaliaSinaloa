using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Sentencia
{
    /// <summary>
    /// Sentencia table
    /// </summary>
    public class Sentencia: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Descr { get; set; }
        public short? iddatos { get; set; }
        public string CveSentencia { get; set; }


    }
	
	public class Sentencia_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Descr { get; set; }
        public short? iddatos { get; set; }
        public string CveSentencia { get; set; }

		
    }


}

