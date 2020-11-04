using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Cadena_de_CustodiaModel
    {
        [Required]
        public int Clave { get; set; }
        public string NUC { get; set; }
        public string NIC { get; set; }
        public int? Delito_Referencia { get; set; }
        public string Delito_ReferenciaDescripcion { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Lugar_Exacto_del_Levantamiento { get; set; }
        public string Condicion_y_Ubicacion { get; set; }
        [Range(0, 9999999999)]
        public short? Levantada_por { get; set; }
        public int? Cargo { get; set; }
        public string CargoTipo_de_Cargo { get; set; }
        public int? Asignar { get; set; }
        public string AsignarName { get; set; }
        public string Folio_NUE { get; set; }
        public int? Unidad_Policial { get; set; }
        public string Unidad_PolicialUnidad_Policial { get; set; }
        public string Caracterististicas_del_indicio { get; set; }
        public string Condiciones_De_Manejo { get; set; }
        public string Numero_de_Parte { get; set; }
        public string CUIP { get; set; }
        public string Observaciones { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Clima { get; set; }
        public string Grados { get; set; }
        public int? Fijacion_Planimetrica { get; set; }
        public HttpPostedFileBase Fijacion_PlanimetricaFile { set; get; }
        public int Fijacion_PlanimetricaRemoveAttachment { set; get; }
        public string Mensaje { get; set; }
        public int? Unidad_Administrativa { get; set; }
        public string Unidad_AdministrativaDescripcion { get; set; }
        public int? Entidad_Federativa { get; set; }
        public string Entidad_FederativaNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public string Numero_de_Oficio { get; set; }
        public string Fecha_CC { get; set; }
        public string Hora_CC { get; set; }
        public int? Motivo_de_Intervencion { get; set; }
        public string Motivo_de_IntervencionDescripcion { get; set; }
        public string Otro { get; set; }
        public int? Estatus { get; set; }
        public string EstatusEstatus { get; set; }
        public string Nombre_Completo { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario_que_Registra { get; set; }
        public string FAE { get; set; }
        public string Fecha_de_la_Emergencia { get; set; }
        public string Hora_de_la_Emergencia { get; set; }
        public string Fuente { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public string Red_Social { get; set; }
        public string Medio_Masivo { get; set; }
        public string Cargo_de_la_Autoridad { get; set; }
        public string Tipo_de_Emergencia { get; set; }
        public string Descripcion_de_la_Emergencia { get; set; }
        public bool Probables_Detenidos { get; set; }
        public string Fecha_de_la_Detencion { get; set; }
        public string Hora_de_la_Detencion { get; set; }
        public string Pais_Emergencia { get; set; }
        public string Estado_Emergencia { get; set; }
        public string Municipio_Emergencia { get; set; }
        public string Colonia_Emergencia { get; set; }
        public string Calle_Emergencia { get; set; }
        public string Entre_Calle_Emergencia { get; set; }
        public string Y_Calle_Emergencia { get; set; }
        public string Latitud_Emergencia { get; set; }
        public string Longitud_Emergencia { get; set; }
        public string Nombre_de_la_Autoridad { get; set; }
        public string Especifique { get; set; }
        public string Tipo_de_Agente { get; set; }
        public string Area { get; set; }
        public string Unidad { get; set; }
        public string Zona { get; set; }
        public string Agente_Investigador { get; set; }
        public string Narrativa_de_los_Hechos { get; set; }
        public string Probable_Delito_Principal { get; set; }
        public string Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public string Estatus_NUE { get; set; }
        public int? Inicio_de_Cadena_de_Custodia { get; set; }
        public string Inicio_de_Cadena_de_CustodiaDescripcion { get; set; }
        public int? Calidad_de_quien_aporta { get; set; }
        public string Calidad_de_quien_aportaDescripcion { get; set; }
        public string Fecha_del_arribo { get; set; }
        public string Hora_del_arribo { get; set; }
        public int? Descripcion_de_recoleccion { get; set; }
        public string Descripcion_de_recoleccionDescripcion { get; set; }
        public int? Movil_para_Traslado { get; set; }
        public string Movil_para_TrasladoDescripcion { get; set; }
        public string Servidor_Publico_que_Preserva { get; set; }
        public string Servidor_Publico_que_Busca { get; set; }
        public string Servidor_Publico_que_Localiza { get; set; }
        public string Servidor_Publico_que_Recolecta { get; set; }
        public string Servidor_Publico_que_Traslada { get; set; }
        public string Preservacion { get; set; }
        public string Busqueda { get; set; }
        public string Localizacion { get; set; }
        public string Recoleccion { get; set; }

    }
	
	public class Cadena_de_Custodia_AsignacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string NUC { get; set; }
        public string NIC { get; set; }
        public int? Delito_Referencia { get; set; }
        public string Delito_ReferenciaDescripcion { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Asignar { get; set; }
        public string AsignarName { get; set; }
        public string Folio_NUE { get; set; }
        public string CUIP { get; set; }
        public int? Estatus { get; set; }
        public string EstatusEstatus { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario_que_Registra { get; set; }
        public string Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public string Estatus_NUE { get; set; }

    }

	public class Cadena_de_Custodia_Cadena_de_CustodiaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Lugar_Exacto_del_Levantamiento { get; set; }
        public string Condicion_y_Ubicacion { get; set; }
        [Range(0, 9999999999)]
        public short? Levantada_por { get; set; }
        public int? Cargo { get; set; }
        public string CargoTipo_de_Cargo { get; set; }
        public int? Unidad_Policial { get; set; }
        public string Unidad_PolicialUnidad_Policial { get; set; }
        public string Caracterististicas_del_indicio { get; set; }
        public string Condiciones_De_Manejo { get; set; }
        public string Numero_de_Parte { get; set; }
        public string Observaciones { get; set; }
        public int? Unidad_Administrativa { get; set; }
        public string Unidad_AdministrativaDescripcion { get; set; }
        public int? Entidad_Federativa { get; set; }
        public string Entidad_FederativaNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public string Numero_de_Oficio { get; set; }
        public string Fecha_CC { get; set; }
        public string Hora_CC { get; set; }
        public int? Motivo_de_Intervencion { get; set; }
        public string Motivo_de_IntervencionDescripcion { get; set; }
        public string Otro { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Inicio_de_Cadena_de_Custodia { get; set; }
        public string Inicio_de_Cadena_de_CustodiaDescripcion { get; set; }
        public int? Calidad_de_quien_aporta { get; set; }
        public string Calidad_de_quien_aportaDescripcion { get; set; }
        public string Fecha_del_arribo { get; set; }
        public string Hora_del_arribo { get; set; }
        public int? Descripcion_de_recoleccion { get; set; }
        public string Descripcion_de_recoleccionDescripcion { get; set; }
        public int? Movil_para_Traslado { get; set; }
        public string Movil_para_TrasladoDescripcion { get; set; }
        public string Servidor_Publico_que_Preserva { get; set; }
        public string Servidor_Publico_que_Busca { get; set; }
        public string Servidor_Publico_que_Localiza { get; set; }
        public string Servidor_Publico_que_Recolecta { get; set; }
        public string Servidor_Publico_que_Traslada { get; set; }
        public string Preservacion { get; set; }
        public string Busqueda { get; set; }
        public string Localizacion { get; set; }
        public string Recoleccion { get; set; }

    }

	public class Cadena_de_Custodia_Fijacion_PlanimetricaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Clima { get; set; }
        public string Grados { get; set; }
        public int? Fijacion_Planimetrica { get; set; }
        public HttpPostedFileBase Fijacion_PlanimetricaFile { set; get; }
        public int Fijacion_PlanimetricaRemoveAttachment { set; get; }

    }

	public class Cadena_de_Custodia_FotosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Cadena_de_Custodia_VideosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Cadena_de_Custodia_Registro_de_IntervinientesModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Cadena_de_Custodia_ChatModel
    {
        [Required]
        public int Clave { get; set; }
        public string Mensaje { get; set; }

    }

	public class Cadena_de_Custodia_DocumentosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Cadena_de_Custodia_RetroalimentacionModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Cadena_de_Custodia_Registro_de_EmergenciaModel
    {
        [Required]
        public int Clave { get; set; }
        public string FAE { get; set; }
        public string Fecha_de_la_Emergencia { get; set; }
        public string Hora_de_la_Emergencia { get; set; }
        public string Fuente { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public string Red_Social { get; set; }
        public string Medio_Masivo { get; set; }
        public string Cargo_de_la_Autoridad { get; set; }
        public string Tipo_de_Emergencia { get; set; }
        public string Descripcion_de_la_Emergencia { get; set; }
        public bool? Probables_Detenidos { get; set; }
        public string Fecha_de_la_Detencion { get; set; }
        public string Hora_de_la_Detencion { get; set; }
        public string Pais_Emergencia { get; set; }
        public string Estado_Emergencia { get; set; }
        public string Municipio_Emergencia { get; set; }
        public string Colonia_Emergencia { get; set; }
        public string Calle_Emergencia { get; set; }
        public string Entre_Calle_Emergencia { get; set; }
        public string Y_Calle_Emergencia { get; set; }
        public string Latitud_Emergencia { get; set; }
        public string Longitud_Emergencia { get; set; }
        public string Nombre_de_la_Autoridad { get; set; }
        public string Especifique { get; set; }
        public string Tipo_de_Agente { get; set; }
        public string Area { get; set; }
        public string Unidad { get; set; }
        public string Zona { get; set; }
        public string Agente_Investigador { get; set; }
        public string Narrativa_de_los_Hechos { get; set; }
        public string Probable_Delito_Principal { get; set; }

    }

	public class Cadena_de_Custodia_Registro_de_DetenidosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Cadena_de_Custodia_Registro_de_TestigosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Cadena_de_Custodia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Cadena_de_Custodia_AsignacionesModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Cadena_de_Custodia_Datos_de_TrasladoModel
    {
        [Required]
        public int Clave { get; set; }

    }


}

