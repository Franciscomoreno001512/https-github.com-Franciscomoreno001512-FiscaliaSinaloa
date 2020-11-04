using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Control_de_DocumentosMainModel
    {
        public Control_de_DocumentosModel Control_de_DocumentosInfo { set; get; }
        public Detalle_Historial_Control_de_DocumentosGridModelPost Detalle_Historial_Control_de_DocumentosGridInfo { set; get; }

    }

    public class Detalle_Historial_Control_de_DocumentosGridModelPost
    {
        public int Folio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string Modificaciones_Realizadas { get; set; }
        public string Cuerpo_del_Documento { get; set; }

        public bool Removed { set; get; }
    }



}

