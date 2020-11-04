using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Datos_del_Imputado_CCMainModel
    {
        public Detalle_de_Datos_del_Imputado_CCModel Detalle_de_Datos_del_Imputado_CCInfo { set; get; }
        public Detalle_de_Galeria_de_DetenidosGridModelPost Detalle_de_Galeria_de_DetenidosGridInfo { set; get; }

    }

    public class Detalle_de_Galeria_de_DetenidosGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public short? Archivo { get; set; }

        public bool Removed { set; get; }
    }



}

