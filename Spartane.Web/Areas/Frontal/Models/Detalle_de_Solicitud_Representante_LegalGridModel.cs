using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_Representante_LegalGridModel
    {
        public int Clave { get; set; }
        public int? idRegistroAT { get; set; }
        public int? idRegistroUI { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_ExpedienteNumero_de_Folio { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public string SexoDescripcion { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estado_CivilDescripcion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public short? Escolaridad { get; set; }
        public string EscolaridadDescripcion { get; set; }
        public int? Ocupacion { get; set; }
        public string OcupacionDescripcion { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Colonia_ { get; set; }
        public string Colonia_Nombre { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Telefono { get; set; }
        public string Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        
    }
}

