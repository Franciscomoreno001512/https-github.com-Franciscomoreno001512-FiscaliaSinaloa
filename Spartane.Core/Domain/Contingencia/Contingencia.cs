using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Contingencia
{
    /// <summary>
    /// Contingencia table
    /// </summary>
    public class Contingencia: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Usuario { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Observaciones { get; set; }


    }
	
	public class Contingencia_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Usuario { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Observaciones { get; set; }

		
    }


}

