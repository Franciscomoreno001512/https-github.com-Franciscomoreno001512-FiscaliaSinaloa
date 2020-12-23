using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Datos_de_los_Hechos_PCGridModel
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudFolio { get; set; }
        public int? Tipo_de_Solicitud { get; set; }
        public string Tipo_de_SolicitudDescripcion { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tiene_alguna_Foto_o_Evidencia { get; set; }
        public Grid_File Tiene_alguna_Foto_o_EvidenciaFileInfo { set; get; }
        public short? Fosa_clandestina { get; set; }
        public string Fosa_clandestinaDescripcion { get; set; }
        public short? Conoce_la_direccion { get; set; }
        public string Conoce_la_direccionDescripcion { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Es_una_direccion_exacta_o_aproximada { get; set; }
        public string Es_una_direccion_exacta_o_aproximadaDescripcion { get; set; }
        
    }
}

