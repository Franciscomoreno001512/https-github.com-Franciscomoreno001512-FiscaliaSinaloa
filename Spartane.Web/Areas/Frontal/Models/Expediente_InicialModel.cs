using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Expediente_InicialModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Detenido { get; set; }
        public string DetenidoDescripcion { get; set; }
        public string NUC { get; set; }
        public string NIC { get; set; }
        public string Hora_del_Detenido { get; set; }
        public string Hora_Puesto_a_Disposicion { get; set; }
        public int? Solicitar_Servicos_de_Apoyo { get; set; }
        public string Solicitar_Servicos_de_ApoyoFolio { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Prioridad_del_HechoDescripcion { get; set; }
        public string Turno { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos_MPI { get; set; }
        public string Pais_de_los_Hechos_MPINombre { get; set; }
        public int? Estado_de_los_Hechos_MPI { get; set; }
        public string Estado_de_los_Hechos_MPINombre { get; set; }
        public int? Municipio_de_los_Hechos_MPI { get; set; }
        public string Municipio_de_los_Hechos_MPINombre { get; set; }
        public int? Colonia_de_los_Hechos_MPI { get; set; }
        public string Colonia_de_los_Hechos_MPINombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_de_los_Hechos_MPI { get; set; }
        public string Calle_de_los_Hechos_MPI { get; set; }
        public string Entre_Calle_MPI { get; set; }
        public string Y_Calle_MPI { get; set; }
        public string Numero_Exrterior_de_los_Hechos_MPI { get; set; }
        public string Numero_Interior_de_los_Hechos_MPI { get; set; }
        public string Latitud_MPI { get; set; }
        public string Longitud_MPI { get; set; }
        public int? Tipo_de_Lugar_del_Hecho_MPI { get; set; }
        public string Tipo_de_Lugar_del_Hecho_MPIDescripcion { get; set; }
        public bool Persona_Moral { get; set; }
        public bool Requiere_Diligencia { get; set; }
        public string Numero_de_Expediente_Victima { get; set; }
        public bool Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public string Lengua_OriginariaDescripcion { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public bool Asignar_Agente_del_Ministerio_Publico { get; set; }
        public int? Nombre_de_Agente_del_Ministerio_Publico { get; set; }
        public string Nombre_de_Agente_del_Ministerio_PublicoName { get; set; }
        public int? Tipo_de_Oficio { get; set; }
        public string Tipo_de_OficioDescripcion { get; set; }
        public int? Delegacion { get; set; }
        public string DelegacionDescripcion { get; set; }
        public int? Agencia { get; set; }
        public string AgenciaDescripcion { get; set; }
        public bool Solicitar_Diligencias { get; set; }
        public string NUC_Audiencias { get; set; }
        public string NIC_Audiencias { get; set; }
        public string Fecha_de_Registro_Audiencias { get; set; }
        public string Hora_de_Registro_Audiencias { get; set; }
        public int? Tipo_de_Oficio_Audiencias { get; set; }
        public string Tipo_de_Oficio_AudienciasDescripcion { get; set; }
        public int? Delegacion_Audiencias { get; set; }
        public string Delegacion_AudienciasDescripcion { get; set; }
        public string Domicilio_Delegacion_A { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string NUAT { get; set; }
        public string Fecha_de_RegistroI { get; set; }
        public string Hora_de_RegistroI { get; set; }
        public short? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Canalizar_a { get; set; }
        public string Canalizar_aDescripcion { get; set; }
        public int? Delito_Principal { get; set; }
        public string Delito_PrincipalDelito { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public string Tipo_de_AcuerdoDescripcion { get; set; }
        public string Fecha_de_Inicio_de_Acuerdo { get; set; }
        public string Fecha_de_Cumplimiento { get; set; }
        public string Hora_de_Cumplimiento { get; set; }
        public string Domicilio_para_el_Cumplimiento { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_Reparacion_de_Danos { get; set; }
        public string Parcialidades { get; set; }
        public int? Periodicidad { get; set; }
        public string PeriodicidadDescripcion { get; set; }
        public bool Acepta_Acuerdo { get; set; }
        public string Motivo_de_Rechazo_de_Acuerdo { get; set; }

    }
	
	public class Expediente_Inicial_Datos_del_CasoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Detenido { get; set; }
        public string DetenidoDescripcion { get; set; }
        public string NUC { get; set; }
        public string NIC { get; set; }
        public string Hora_del_Detenido { get; set; }
        public string Hora_Puesto_a_Disposicion { get; set; }
        public int? Solicitar_Servicos_de_Apoyo { get; set; }
        public string Solicitar_Servicos_de_ApoyoFolio { get; set; }
        public int? Tipo_de_Oficio { get; set; }
        public string Tipo_de_OficioDescripcion { get; set; }
        public int? Delegacion { get; set; }
        public string DelegacionDescripcion { get; set; }
        public int? Agencia { get; set; }
        public string AgenciaDescripcion { get; set; }
        public bool? Solicitar_Diligencias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string NUAT { get; set; }
        public short? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }

	public class Expediente_Inicial_Datos_de_la_VictimaModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Persona_Moral { get; set; }
        public bool? Requiere_Diligencia { get; set; }
        public string Numero_de_Expediente_Victima { get; set; }

    }

	public class Expediente_Inicial_Datos_del_ImputadoModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Expediente_Inicial_Datos_del_DelitoModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Expediente_Inicial_Datos_de_los_HechosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Prioridad_del_HechoDescripcion { get; set; }
        public string Turno { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos_MPI { get; set; }
        public string Pais_de_los_Hechos_MPINombre { get; set; }
        public int? Estado_de_los_Hechos_MPI { get; set; }
        public string Estado_de_los_Hechos_MPINombre { get; set; }
        public int? Municipio_de_los_Hechos_MPI { get; set; }
        public string Municipio_de_los_Hechos_MPINombre { get; set; }
        public int? Colonia_de_los_Hechos_MPI { get; set; }
        public string Colonia_de_los_Hechos_MPINombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_de_los_Hechos_MPI { get; set; }
        public string Calle_de_los_Hechos_MPI { get; set; }
        public string Entre_Calle_MPI { get; set; }
        public string Y_Calle_MPI { get; set; }
        public string Numero_Exrterior_de_los_Hechos_MPI { get; set; }
        public string Numero_Interior_de_los_Hechos_MPI { get; set; }
        public string Latitud_MPI { get; set; }
        public string Longitud_MPI { get; set; }
        public int? Tipo_de_Lugar_del_Hecho_MPI { get; set; }
        public string Tipo_de_Lugar_del_Hecho_MPIDescripcion { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public int? Delito_Principal { get; set; }
        public string Delito_PrincipalDelito { get; set; }

    }

	public class Expediente_Inicial_Datos_de_la_Persona_MoralModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Expediente_Inicial_Servicios_de_ApoyoModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public string Lengua_OriginariaDescripcion { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }

    }

	public class Expediente_Inicial_Datos_del_TestigoModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Expediente_Inicial_Asignar_MPModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Asignar_Agente_del_Ministerio_Publico { get; set; }
        public int? Nombre_de_Agente_del_Ministerio_Publico { get; set; }
        public string Nombre_de_Agente_del_Ministerio_PublicoName { get; set; }

    }

	public class Expediente_Inicial_DiligenciasModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Expediente_Inicial_IPHModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Expediente_Inicial_Agenda_de_Audiencias_y_CitatoriosModel
    {
        [Required]
        public int Clave { get; set; }
        public string NUC_Audiencias { get; set; }
        public string NIC_Audiencias { get; set; }
        public string Fecha_de_Registro_Audiencias { get; set; }
        public string Hora_de_Registro_Audiencias { get; set; }
        public int? Tipo_de_Oficio_Audiencias { get; set; }
        public string Tipo_de_Oficio_AudienciasDescripcion { get; set; }
        public int? Delegacion_Audiencias { get; set; }
        public string Delegacion_AudienciasDescripcion { get; set; }
        public string Domicilio_Delegacion_A { get; set; }

    }

	public class Expediente_Inicial_Audiencias_CitatoriosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Expediente_Inicial_DocumentosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Expediente_Inicial_Bitacora_de_CoincidenciasModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Expediente_Inicial_IndiciosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_RegistroI { get; set; }
        public string Hora_de_RegistroI { get; set; }

    }

	public class Expediente_Inicial_CanalizarModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Canalizar_a { get; set; }
        public string Canalizar_aDescripcion { get; set; }

    }

	public class Expediente_Inicial_Datos_del_AcuerdoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public string Tipo_de_AcuerdoDescripcion { get; set; }
        public string Fecha_de_Inicio_de_Acuerdo { get; set; }
        public string Fecha_de_Cumplimiento { get; set; }
        public string Hora_de_Cumplimiento { get; set; }
        public string Domicilio_para_el_Cumplimiento { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_Reparacion_de_Danos { get; set; }
        public string Parcialidades { get; set; }
        public int? Periodicidad { get; set; }
        public string PeriodicidadDescripcion { get; set; }
        public bool? Acepta_Acuerdo { get; set; }
        public string Motivo_de_Rechazo_de_Acuerdo { get; set; }

    }


}

