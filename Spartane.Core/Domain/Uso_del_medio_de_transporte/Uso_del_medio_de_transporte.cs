using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Uso_del_medio_de_transporte
{
    /// <summary>
    /// Uso_del_medio_de_transporte table
    /// </summary>
    public class Uso_del_medio_de_transporte: BaseEntity
    {
        public short Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Uso_del_medio_de_transporte_Datos_Generales
    {
                public short Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

