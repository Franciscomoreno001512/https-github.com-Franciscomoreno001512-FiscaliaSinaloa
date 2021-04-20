using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documentos_MPOGridModel
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public string Tipo_de_DocumentoDescripcion { get; set; }
        public int? Documento { get; set; }
        public string DocumentoDescripcion { get; set; }
        public int? Involucrado { get; set; }
        public string InvolucradoNombre_Completo_del_Tutor { get; set; }
        public int? Probable_Responsable { get; set; }
        public string Probable_ResponsableNombre_Completo_Detenido { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoFileInfo { set; get; }
        public string Observaciones { get; set; }
        public int? Archivo { get; set; }
        public bool? Lista_para_periciales { get; set; }
        public string Folio { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Descripcion { get; set; }
        public int? Estatus_Persona { get; set; }
        public string Estatus_PersonaDescripcion { get; set; }
        public string Fecha_Localizacion { get; set; }
        public string Hora_Localizacion { get; set; }
        public int? Condiciones_de_Localizacion { get; set; }
        public string Condiciones_de_LocalizacionDescripcion { get; set; }
        public int? Lugar_de_Hallazgo { get; set; }
        public string Lugar_de_HallazgoDescripcion { get; set; }
        public string Posible_Causa_de_la_Desaparacion { get; set; }
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
        public string Calle { get; set; }
        public string Numero_Interior { get; set; }
        public string Numero_Exterior { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Ente_que_localiza_al_no_localizado { get; set; }
        public string Ente_que_localiza_al_no_localizadoDescripcion { get; set; }
        public string ente_Paterno { get; set; }
        public string ente_Materno { get; set; }
        public string ente_Nombre { get; set; }
        public string Autoridad_que_conoce_el_hecho { get; set; }
        public string autoridad_Paterno { get; set; }
        public string autoridad_Materno { get; set; }
        public string autoridad_Nombre { get; set; }
        
    }
}

