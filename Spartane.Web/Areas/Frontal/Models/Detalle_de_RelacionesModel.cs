using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_RelacionesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public int? Involucrado { get; set; }
        public string InvolucradoNombre_Completo { get; set; }
        public int? Probable_Responsable { get; set; }
        public string Probable_ResponsableNombre_Completo_del_Tutor { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Es_Familiar { get; set; }
        public string Es_FamiliarDescripcion { get; set; }
        public int? Parentesco { get; set; }
        public string ParentescoDescripcion { get; set; }

    }
	
	public class Detalle_de_Relaciones_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public int? Involucrado { get; set; }
        public string InvolucradoNombre_Completo { get; set; }
        public int? Probable_Responsable { get; set; }
        public string Probable_ResponsableNombre_Completo_del_Tutor { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Es_Familiar { get; set; }
        public string Es_FamiliarDescripcion { get; set; }
        public int? Parentesco { get; set; }
        public string ParentescoDescripcion { get; set; }

    }


}

