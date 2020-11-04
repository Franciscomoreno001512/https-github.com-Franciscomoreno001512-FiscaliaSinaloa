using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class UsuarioMainModel
    {
        public UsuarioModel UsuarioInfo { set; get; }
        public Detalle_de_Folio_Asignado_de_UsuarioGridModelPost Detalle_de_Folio_Asignado_de_UsuarioGridInfo { set; get; }

    }

    public class Detalle_de_Folio_Asignado_de_UsuarioGridModelPost
    {
        public int Clave { get; set; }
        public int? Folio { get; set; }
        public int? Estatus_de_Folio { get; set; }
        public string Fecha_de_Registro { get; set; }

        public bool Removed { set; get; }
    }



}

