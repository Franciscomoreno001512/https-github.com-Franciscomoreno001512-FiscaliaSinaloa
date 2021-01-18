using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_Mandamiento_JudicialMainModel
    {
        public Registro_de_Mandamiento_JudicialModel Registro_de_Mandamiento_JudicialInfo { set; get; }
        public Detalle_de_DomicilioGridModelPost Detalle_de_DomicilioGridInfo { set; get; }
        public Detalle_de_telefonoGridModelPost Detalle_de_telefonoGridInfo { set; get; }
        public Detalle_de_Otro_NombreGridModelPost Detalle_de_Otro_NombreGridInfo { set; get; }
        public Detalle_de_Delito_Mandamiento_JudicialGridModelPost Detalle_de_Delito_Mandamiento_JudicialGridInfo { set; get; }
        public Detalle_de_AmparoGridModelPost Detalle_de_AmparoGridInfo { set; get; }
        public Detalle_de_FotosGridModelPost Detalle_de_FotosGridInfo { set; get; }
        public Detalle_de_Documentos_Mandamiento_JudicialGridModelPost Detalle_de_Documentos_Mandamiento_JudicialGridInfo { set; get; }

    }

    public class Detalle_de_DomicilioGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Domicilio { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Observaciones_Comentarios { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_telefonoGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Telefono { get; set; }
        public string Telefono { get; set; }
        public short? Extension { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Otro_NombreGridModelPost
    {
        public int Clave { get; set; }
        public string Otro_Nombre_del_Individuo { get; set; }
        public string Otro_Apellido_Paterno_del_Individuo { get; set; }
        public string Otro_Apellido_Materno_del_Individuo { get; set; }
        public string Otro_Alias_del_Individuo { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Delito_Mandamiento_JudicialGridModelPost
    {
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public short? Modalidad { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_AmparoGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Amparo { get; set; }
        public string Numero_de_Amparo { get; set; }
        public string Fecha_Amparo { get; set; }
        public int? Entidad_que_Emitio_Amparo { get; set; }
        public int? Resolucion { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_FotosGridModelPost
    {
        public int Clave { get; set; }
        public int? Foto_Perfil_Izquierdo { get; set; }
        public Grid_File Foto_Perfil_IzquierdoInfo { set; get; }
        public int? Foto_Perfil_Derecho { get; set; }
        public Grid_File Foto_Perfil_DerechoInfo { set; get; }
        public int? Foto_de_Frente { get; set; }
        public Grid_File Foto_de_FrenteInfo { set; get; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Documentos_Mandamiento_JudicialGridModelPost
    {
        public int Clave { get; set; }
        public int? Documentos { get; set; }
        public Grid_File DocumentosInfo { set; get; }

        public bool Removed { set; get; }
    }



}

