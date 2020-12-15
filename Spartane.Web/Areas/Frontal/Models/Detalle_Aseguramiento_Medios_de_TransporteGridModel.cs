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
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public short? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public string Submarca { get; set; }
        public short? Modelo { get; set; }
        public string ModeloDescripcion { get; set; }
        public string Placas { get; set; }
        public string Color { get; set; }
        public string Numero_de_Motor { get; set; }
        public string Serie { get; set; }
        public short? Uso { get; set; }
        public string UsoDescripcion { get; set; }
        public short? Cap__De_Pasajeros { get; set; }
        public short? Procedencia { get; set; }
        public string ProcedenciaDescripcion { get; set; }
        public short? Seguro { get; set; }
        public string SeguroDescripcion { get; set; }
        public int? Compania_de_Seguros { get; set; }
        public string Compania_de_SegurosDescripcion { get; set; }
        public string Empresa { get; set; }
        public string Capacidad_de_Carga { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int? Ubicacion { get; set; }
        public string UbicacionDescripcion { get; set; }
        public int? Pension { get; set; }
        public string PensionDescripcion { get; set; }
        public string Domicilio_Resguardo { get; set; }
        public string Observaciones { get; set; }
        
    }
}

