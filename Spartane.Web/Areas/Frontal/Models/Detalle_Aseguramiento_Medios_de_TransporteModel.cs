using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Medios_de_TransporteModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public string Especifique { get; set; }
        public short? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public short? Submarca { get; set; }
        public string SubmarcaDescripcion { get; set; }
        public short? Modelo { get; set; }
        public string ModeloDescripcion { get; set; }
        public string Placas { get; set; }
        public short? Color { get; set; }
        public string ColorDescripcion { get; set; }
        public string Numero_de_Motor { get; set; }
        public string Serie { get; set; }
        public short? Uso { get; set; }
        public string UsoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Cap__De_Pasajeros { get; set; }
        public short? Procedencia { get; set; }
        public string ProcedenciaDescripcion { get; set; }
        public string Empresa { get; set; }
        public string Capacidad_de_Carga { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Observaciones { get; set; }
        public short? Detencion { get; set; }
        public string DetencionDescripcion { get; set; }

    }
	
	public class Detalle_Aseguramiento_Medios_de_Transporte_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public string Especifique { get; set; }
        public short? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public short? Submarca { get; set; }
        public string SubmarcaDescripcion { get; set; }
        public short? Modelo { get; set; }
        public string ModeloDescripcion { get; set; }
        public string Placas { get; set; }
        public short? Color { get; set; }
        public string ColorDescripcion { get; set; }
        public string Numero_de_Motor { get; set; }
        public string Serie { get; set; }
        public short? Uso { get; set; }
        public string UsoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Cap__De_Pasajeros { get; set; }
        public short? Procedencia { get; set; }
        public string ProcedenciaDescripcion { get; set; }
        public string Empresa { get; set; }
        public string Capacidad_de_Carga { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Observaciones { get; set; }
        public short? Detencion { get; set; }
        public string DetencionDescripcion { get; set; }

    }


}

