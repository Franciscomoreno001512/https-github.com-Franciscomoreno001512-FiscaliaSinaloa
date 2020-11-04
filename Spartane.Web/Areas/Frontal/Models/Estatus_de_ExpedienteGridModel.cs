using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Estatus_de_ExpedienteGridModel
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

