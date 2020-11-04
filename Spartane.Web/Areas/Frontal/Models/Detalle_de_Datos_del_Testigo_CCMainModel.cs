using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Datos_del_Testigo_CCMainModel
    {
        public Detalle_de_Datos_del_Testigo_CCModel Detalle_de_Datos_del_Testigo_CCInfo { set; get; }
        public Detalle_de_Galeria_de_TestigosGridModelPost Detalle_de_Galeria_de_TestigosGridInfo { set; get; }

    }

    public class Detalle_de_Galeria_de_TestigosGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public short? Archivo { get; set; }

        public bool Removed { set; get; }
    }



}

