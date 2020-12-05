using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Medios_de_TransporteGridModel
    {
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public string Especifique { get; set; }
        public short? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public string Submarca { get; set; }
        public short? Modelo { get; set; }
        public string ModeloDescripcion { get; set; }
        public string Placas { get; set; }
        public short? Color { get; set; }
        public string ColorDescripcion { get; set; }
        public string Numero_de_Motor { get; set; }
        public string Serie { get; set; }
        public short? Uso { get; set; }
        public string UsoDescripcion { get; set; }
        public short? Cap__De_Pasajeros { get; set; }
        public short? Procedencia { get; set; }
        public string ProcedenciaDescripcion { get; set; }
        public string Empresa { get; set; }
        public string Capacidad_de_Carga { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Observaciones { get; set; }
        
    }
}

