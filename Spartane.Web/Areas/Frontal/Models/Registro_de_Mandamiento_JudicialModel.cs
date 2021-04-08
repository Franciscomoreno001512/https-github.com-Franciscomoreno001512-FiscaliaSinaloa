using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_Mandamiento_JudicialModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Numero_de_Mandamiento { get; set; }
        public int? Tipo_Mandato { get; set; }
        public string Tipo_MandatoDescripcion { get; set; }
        public int? Fuente { get; set; }
        public string FuenteDescripcion { get; set; }
        public string Fecha_de_Solicitud { get; set; }
        public int? Pais_al_que_Pertenece_la_Informacion { get; set; }
        public string Pais_al_que_Pertenece_la_InformacionNombre { get; set; }
        public int? Estado_que_Envia_la_Informacion { get; set; }
        public string Estado_que_Envia_la_InformacionNombre { get; set; }
        public int? Municipio_que_Envia_la_Informacion { get; set; }
        public string Municipio_que_Envia_la_InformacionNombre { get; set; }
        public int? Institucion_que_Remite { get; set; }
        public string Institucion_que_RemiteNombre { get; set; }
        public string Dependencia_Autoridad_Remitente { get; set; }
        public int? Entidad_que_Emite_Mandamiento { get; set; }
        public string Entidad_que_Emite_MandamientoNombre { get; set; }
        public int? Juzgado_que_Emitio_Mandamiento { get; set; }
        public string Juzgado_que_Emitio_MandamientoNombre { get; set; }
        public string Oficio_de_Juzgado { get; set; }
        public int? Area_que_envia_Orden { get; set; }
        public string Area_que_envia_OrdenDescripcion { get; set; }
        public string Observaciones { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Numero_de_Proceso_Judicial { get; set; }
        public string Fecha_de_Libramiento { get; set; }
        public string Oficio_de_Libramiento { get; set; }
        public string Fecha_de_Transcripcion { get; set; }
        public string Oficio_Transcripcion { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public string Carpeta_de_Investigacionnic { get; set; }
        public int? Causa_Penal { get; set; }
        public string Causa_Penalcausa_o_cuadernillo { get; set; }

    }
	
	public class Registro_de_Mandamiento_Judicial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Numero_de_Mandamiento { get; set; }
        public int? Tipo_Mandato { get; set; }
        public string Tipo_MandatoDescripcion { get; set; }
        public int? Fuente { get; set; }
        public string FuenteDescripcion { get; set; }
        public string Fecha_de_Solicitud { get; set; }
        public int? Pais_al_que_Pertenece_la_Informacion { get; set; }
        public string Pais_al_que_Pertenece_la_InformacionNombre { get; set; }
        public int? Estado_que_Envia_la_Informacion { get; set; }
        public string Estado_que_Envia_la_InformacionNombre { get; set; }
        public int? Municipio_que_Envia_la_Informacion { get; set; }
        public string Municipio_que_Envia_la_InformacionNombre { get; set; }
        public int? Institucion_que_Remite { get; set; }
        public string Institucion_que_RemiteNombre { get; set; }
        public string Dependencia_Autoridad_Remitente { get; set; }
        public int? Entidad_que_Emite_Mandamiento { get; set; }
        public string Entidad_que_Emite_MandamientoNombre { get; set; }
        public int? Juzgado_que_Emitio_Mandamiento { get; set; }
        public string Juzgado_que_Emitio_MandamientoNombre { get; set; }
        public string Oficio_de_Juzgado { get; set; }
        public int? Area_que_envia_Orden { get; set; }
        public string Area_que_envia_OrdenDescripcion { get; set; }
        public string Observaciones { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_ProcesoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Numero_de_Proceso_Judicial { get; set; }
        public string Fecha_de_Libramiento { get; set; }
        public string Oficio_de_Libramiento { get; set; }
        public string Fecha_de_Transcripcion { get; set; }
        public string Oficio_Transcripcion { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_ExpedienteModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public string Carpeta_de_Investigacionnic { get; set; }
        public int? Causa_Penal { get; set; }
        public string Causa_Penalcausa_o_cuadernillo { get; set; }

    }


}

