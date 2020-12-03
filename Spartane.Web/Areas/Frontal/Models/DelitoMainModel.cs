using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class DelitoMainModel
    {
        public DelitoModel DelitoInfo { set; get; }
        public Configuracion_de_PlaneacionGridModelPost Configuracion_de_PlaneacionGridInfo { set; get; }

    }

    public class Configuracion_de_PlaneacionGridModelPost
    {
        public int Folio { get; set; }
        public short? Categoria { get; set; }
        public int? Servicio { get; set; }
        public string Entregable { get; set; }
        public short? Tiempo_Estandar { get; set; }
        public short? Ponderacion { get; set; }

        public bool Removed { set; get; }
    }



}

