using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Estatus_de_Expediente
{
    /// <summary>
    /// Estatus_de_Expediente table
    /// </summary>
    public class Estatus_de_Expediente: BaseEntity
    {
        public int Clave { get; set; }
        public string Estatus_General { get; set; }
        public string Estatus_Especifico { get; set; }
        public string Estatus_Tipo_Caso { get; set; }
        public string Estatus_Descripcion_General { get; set; }
        public string Estatus_Descripcion_Especifico { get; set; }
        public string Estatus_Completo { get; set; }


    }
	
	public class Estatus_de_Expediente_Datos_Generales
    {
                public int Clave { get; set; }
        public string Estatus_General { get; set; }
        public string Estatus_Especifico { get; set; }
        public string Estatus_Tipo_Caso { get; set; }
        public string Estatus_Descripcion_General { get; set; }
        public string Estatus_Descripcion_Especifico { get; set; }
        public string Estatus_Completo { get; set; }

		
    }


}

