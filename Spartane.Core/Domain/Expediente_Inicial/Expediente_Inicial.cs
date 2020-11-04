using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Dialecto;
using Spartane.Core.Domain.Idioma;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Oficio;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Agencia;
using Spartane.Core.Domain.Tipo_de_Oficio;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Estatus_de_Expediente_Inicial;
using Spartane.Core.Domain.Estatus_Orientador;
using Spartane.Core.Domain.Delito_Principal_MPI;
using Spartane.Core.Domain.Tipo_de_Acuerdo;
using Spartane.Core.Domain.Periodicidad;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Expediente_Inicial
{
    /// <summary>
    /// Expediente_Inicial table
    /// </summary>
    public class Expediente_Inicial: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Detenido { get; set; }
        public string NUC { get; set; }
        public string NIC { get; set; }
        public string Hora_del_Detenido { get; set; }
        public string Hora_Puesto_a_Disposicion { get; set; }
        public int? Solicitar_Servicos_de_Apoyo { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Turno { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos_MPI { get; set; }
        public int? Estado_de_los_Hechos_MPI { get; set; }
        public int? Municipio_de_los_Hechos_MPI { get; set; }
        public int? Colonia_de_los_Hechos_MPI { get; set; }
        public int? Codigo_Postal_de_los_Hechos_MPI { get; set; }
        public string Calle_de_los_Hechos_MPI { get; set; }
        public string Entre_Calle_MPI { get; set; }
        public string Y_Calle_MPI { get; set; }
        public string Numero_Exrterior_de_los_Hechos_MPI { get; set; }
        public string Numero_Interior_de_los_Hechos_MPI { get; set; }
        public string Latitud_MPI { get; set; }
        public string Longitud_MPI { get; set; }
        public int? Tipo_de_Lugar_del_Hecho_MPI { get; set; }
        public bool? Persona_Moral { get; set; }
        public bool? Requiere_Diligencia { get; set; }
        public string Numero_de_Expediente_Victima { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public int? Idioma { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public bool? Asignar_Agente_del_Ministerio_Publico { get; set; }
        public int? Nombre_de_Agente_del_Ministerio_Publico { get; set; }
        public int? Tipo_de_Oficio { get; set; }
        public int? Delegacion { get; set; }
        public int? Agencia { get; set; }
        public bool? Solicitar_Diligencias { get; set; }
        public string NUC_Audiencias { get; set; }
        public string NIC_Audiencias { get; set; }
        public DateTime? Fecha_de_Registro_Audiencias { get; set; }
        public string Hora_de_Registro_Audiencias { get; set; }
        public int? Tipo_de_Oficio_Audiencias { get; set; }
        public int? Delegacion_Audiencias { get; set; }
        public string Domicilio_Delegacion_A { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string NUAT { get; set; }
        public DateTime? Fecha_de_RegistroI { get; set; }
        public string Hora_de_RegistroI { get; set; }
        public short? Estatus { get; set; }
        public int? Canalizar_a { get; set; }
        public int? Delito_Principal { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public DateTime? Fecha_de_Inicio_de_Acuerdo { get; set; }
        public DateTime? Fecha_de_Cumplimiento { get; set; }
        public string Hora_de_Cumplimiento { get; set; }
        public string Domicilio_para_el_Cumplimiento { get; set; }
        public decimal? Monto_de_Reparacion_de_Danos { get; set; }
        public string Parcialidades { get; set; }
        public int? Periodicidad { get; set; }
        public bool? Acepta_Acuerdo { get; set; }
        public string Motivo_de_Rechazo_de_Acuerdo { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Detenido")]
        public virtual Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI Detenido_Catalogo_Estatus_Detenido_MPI { get; set; }
        [ForeignKey("Solicitar_Servicos_de_Apoyo")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Prioridad_del_Hecho")]
        public virtual Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho Prioridad_del_Hecho_Prioridad_del_Hecho { get; set; }
        [ForeignKey("Pais_de_los_Hechos_MPI")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_los_Hechos_MPI_Pais { get; set; }
        [ForeignKey("Estado_de_los_Hechos_MPI")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_los_Hechos_MPI_Estado { get; set; }
        [ForeignKey("Municipio_de_los_Hechos_MPI")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_los_Hechos_MPI_Municipio { get; set; }
        [ForeignKey("Colonia_de_los_Hechos_MPI")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_los_Hechos_MPI_Colonia { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Hecho_MPI")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo { get; set; }
        [ForeignKey("Lengua_Originaria")]
        public virtual Spartane.Core.Domain.Dialecto.Dialecto Lengua_Originaria_Dialecto { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
        [ForeignKey("Nombre_de_Agente_del_Ministerio_Publico")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Nombre_de_Agente_del_Ministerio_Publico_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Oficio")]
        public virtual Spartane.Core.Domain.Tipo_de_Oficio.Tipo_de_Oficio Tipo_de_Oficio_Tipo_de_Oficio { get; set; }
        [ForeignKey("Delegacion")]
        public virtual Spartane.Core.Domain.Delegacion.Delegacion Delegacion_Delegacion { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia.Agencia Agencia_Agencia { get; set; }
        [ForeignKey("Tipo_de_Oficio_Audiencias")]
        public virtual Spartane.Core.Domain.Tipo_de_Oficio.Tipo_de_Oficio Tipo_de_Oficio_Audiencias_Tipo_de_Oficio { get; set; }
        [ForeignKey("Delegacion_Audiencias")]
        public virtual Spartane.Core.Domain.Delegacion.Delegacion Delegacion_Audiencias_Delegacion { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial Estatus_Estatus_de_Expediente_Inicial { get; set; }
        [ForeignKey("Canalizar_a")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Canalizar_a_Estatus_Orientador { get; set; }
        [ForeignKey("Delito_Principal")]
        public virtual Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI Delito_Principal_Delito_Principal_MPI { get; set; }
        [ForeignKey("Tipo_de_Acuerdo")]
        public virtual Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo Tipo_de_Acuerdo_Tipo_de_Acuerdo { get; set; }
        [ForeignKey("Periodicidad")]
        public virtual Spartane.Core.Domain.Periodicidad.Periodicidad Periodicidad_Periodicidad { get; set; }

    }
	
	public class Expediente_Inicial_Datos_del_Caso
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Detenido { get; set; }
        public string NUC { get; set; }
        public string NIC { get; set; }
        public string Hora_del_Detenido { get; set; }
        public string Hora_Puesto_a_Disposicion { get; set; }
        public int? Solicitar_Servicos_de_Apoyo { get; set; }
        public int? Tipo_de_Oficio { get; set; }
        public int? Delegacion { get; set; }
        public int? Agencia { get; set; }
        public bool? Solicitar_Diligencias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string NUAT { get; set; }
        public short? Estatus { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Detenido")]
        public virtual Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI Detenido_Catalogo_Estatus_Detenido_MPI { get; set; }
        [ForeignKey("Solicitar_Servicos_de_Apoyo")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Tipo_de_Oficio")]
        public virtual Spartane.Core.Domain.Tipo_de_Oficio.Tipo_de_Oficio Tipo_de_Oficio_Tipo_de_Oficio { get; set; }
        [ForeignKey("Delegacion")]
        public virtual Spartane.Core.Domain.Delegacion.Delegacion Delegacion_Delegacion { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia.Agencia Agencia_Agencia { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial Estatus_Estatus_de_Expediente_Inicial { get; set; }

    }

	public class Expediente_Inicial_Datos_de_la_Victima
    {
                public int Clave { get; set; }
        public bool? Persona_Moral { get; set; }
        public bool? Requiere_Diligencia { get; set; }
        public string Numero_de_Expediente_Victima { get; set; }

		
    }

	public class Expediente_Inicial_Datos_del_Imputado
    {
                public int Clave { get; set; }

		
    }

	public class Expediente_Inicial_Datos_del_Delito
    {
                public int Clave { get; set; }

		
    }

	public class Expediente_Inicial_Datos_de_los_Hechos
    {
                public int Clave { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Turno { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos_MPI { get; set; }
        public int? Estado_de_los_Hechos_MPI { get; set; }
        public int? Municipio_de_los_Hechos_MPI { get; set; }
        public int? Colonia_de_los_Hechos_MPI { get; set; }
        public int? Codigo_Postal_de_los_Hechos_MPI { get; set; }
        public string Calle_de_los_Hechos_MPI { get; set; }
        public string Entre_Calle_MPI { get; set; }
        public string Y_Calle_MPI { get; set; }
        public string Numero_Exrterior_de_los_Hechos_MPI { get; set; }
        public string Numero_Interior_de_los_Hechos_MPI { get; set; }
        public string Latitud_MPI { get; set; }
        public string Longitud_MPI { get; set; }
        public int? Tipo_de_Lugar_del_Hecho_MPI { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public int? Delito_Principal { get; set; }

		        [ForeignKey("Prioridad_del_Hecho")]
        public virtual Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho Prioridad_del_Hecho_Prioridad_del_Hecho { get; set; }
        [ForeignKey("Pais_de_los_Hechos_MPI")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_los_Hechos_MPI_Pais { get; set; }
        [ForeignKey("Estado_de_los_Hechos_MPI")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_los_Hechos_MPI_Estado { get; set; }
        [ForeignKey("Municipio_de_los_Hechos_MPI")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_los_Hechos_MPI_Municipio { get; set; }
        [ForeignKey("Colonia_de_los_Hechos_MPI")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_los_Hechos_MPI_Colonia { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Hecho_MPI")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo { get; set; }
        [ForeignKey("Delito_Principal")]
        public virtual Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI Delito_Principal_Delito_Principal_MPI { get; set; }

    }

	public class Expediente_Inicial_Datos_de_la_Persona_Moral
    {
                public int Clave { get; set; }

		
    }

	public class Expediente_Inicial_Servicios_de_Apoyo
    {
                public int Clave { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public int? Idioma { get; set; }

		        [ForeignKey("Lengua_Originaria")]
        public virtual Spartane.Core.Domain.Dialecto.Dialecto Lengua_Originaria_Dialecto { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }

    }

	public class Expediente_Inicial_Datos_del_Testigo
    {
                public int Clave { get; set; }

		
    }

	public class Expediente_Inicial_Asignar_MP
    {
                public int Clave { get; set; }
        public bool? Asignar_Agente_del_Ministerio_Publico { get; set; }
        public int? Nombre_de_Agente_del_Ministerio_Publico { get; set; }

		        [ForeignKey("Nombre_de_Agente_del_Ministerio_Publico")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Nombre_de_Agente_del_Ministerio_Publico_Spartan_User { get; set; }

    }

	public class Expediente_Inicial_Diligencias
    {
                public int Clave { get; set; }

		
    }

	public class Expediente_Inicial_IPH
    {
                public int Clave { get; set; }

		
    }

	public class Expediente_Inicial_Agenda_de_Audiencias_y_Citatorios
    {
                public int Clave { get; set; }
        public string NUC_Audiencias { get; set; }
        public string NIC_Audiencias { get; set; }
        public DateTime? Fecha_de_Registro_Audiencias { get; set; }
        public string Hora_de_Registro_Audiencias { get; set; }
        public int? Tipo_de_Oficio_Audiencias { get; set; }
        public int? Delegacion_Audiencias { get; set; }
        public string Domicilio_Delegacion_A { get; set; }

		        [ForeignKey("Tipo_de_Oficio_Audiencias")]
        public virtual Spartane.Core.Domain.Tipo_de_Oficio.Tipo_de_Oficio Tipo_de_Oficio_Audiencias_Tipo_de_Oficio { get; set; }
        [ForeignKey("Delegacion_Audiencias")]
        public virtual Spartane.Core.Domain.Delegacion.Delegacion Delegacion_Audiencias_Delegacion { get; set; }

    }

	public class Expediente_Inicial_Audiencias_Citatorios
    {
                public int Clave { get; set; }

		
    }

	public class Expediente_Inicial_Documentos
    {
                public int Clave { get; set; }

		
    }

	public class Expediente_Inicial_Bitacora_de_Coincidencias
    {
                public int Clave { get; set; }

		
    }

	public class Expediente_Inicial_Indicios
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_RegistroI { get; set; }
        public string Hora_de_RegistroI { get; set; }

		
    }

	public class Expediente_Inicial_Canalizar
    {
                public int Clave { get; set; }
        public int? Canalizar_a { get; set; }

		        [ForeignKey("Canalizar_a")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Canalizar_a_Estatus_Orientador { get; set; }

    }

	public class Expediente_Inicial_Datos_del_Acuerdo
    {
                public int Clave { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public DateTime? Fecha_de_Inicio_de_Acuerdo { get; set; }
        public DateTime? Fecha_de_Cumplimiento { get; set; }
        public string Hora_de_Cumplimiento { get; set; }
        public string Domicilio_para_el_Cumplimiento { get; set; }
        public decimal? Monto_de_Reparacion_de_Danos { get; set; }
        public string Parcialidades { get; set; }
        public int? Periodicidad { get; set; }
        public bool? Acepta_Acuerdo { get; set; }
        public string Motivo_de_Rechazo_de_Acuerdo { get; set; }

		        [ForeignKey("Tipo_de_Acuerdo")]
        public virtual Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo Tipo_de_Acuerdo_Tipo_de_Acuerdo { get; set; }
        [ForeignKey("Periodicidad")]
        public virtual Spartane.Core.Domain.Periodicidad.Periodicidad Periodicidad_Periodicidad { get; set; }

    }


}

