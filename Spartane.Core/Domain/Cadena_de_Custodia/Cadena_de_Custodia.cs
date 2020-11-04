using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Catalogo_Unidad_Policial;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC;
using Spartane.Core.Domain.Catalogo_Estatus_CC;
using Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Catalogo_de_Recoleccion;
using Spartane.Core.Domain.Catalogo_de_Movil_para_traslado;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Cadena_de_Custodia
{
    /// <summary>
    /// Cadena_de_Custodia table
    /// </summary>
    public class Cadena_de_Custodia: BaseEntity
    {
        public int Clave { get; set; }
        public string NUC { get; set; }
        public string NIC { get; set; }
        public int? Delito_Referencia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Lugar_Exacto_del_Levantamiento { get; set; }
        public string Condicion_y_Ubicacion { get; set; }
        public short? Levantada_por { get; set; }
        public int? Cargo { get; set; }
        public int? Asignar { get; set; }
        public string Folio_NUE { get; set; }
        public int? Unidad_Policial { get; set; }
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
        public string Fijacion_Planimetrica_URL { get; set; }
        public string Mensaje { get; set; }
        public int? Unidad_Administrativa { get; set; }
        public int? Entidad_Federativa { get; set; }
        public int? Municipio { get; set; }
        public string Numero_de_Oficio { get; set; }
        public DateTime? Fecha_CC { get; set; }
        public string Hora_CC { get; set; }
        public int? Motivo_de_Intervencion { get; set; }
        public string Otro { get; set; }
        public int? Estatus { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string FAE { get; set; }
        public DateTime? Fecha_de_la_Emergencia { get; set; }
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
        public DateTime? Fecha_de_la_Detencion { get; set; }
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
        public DateTime? Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public string Estatus_NUE { get; set; }
        public int? Inicio_de_Cadena_de_Custodia { get; set; }
        public int? Calidad_de_quien_aporta { get; set; }
        public DateTime? Fecha_del_arribo { get; set; }
        public string Hora_del_arribo { get; set; }
        public int? Descripcion_de_recoleccion { get; set; }
        public int? Movil_para_Traslado { get; set; }
        public string Servidor_Publico_que_Preserva { get; set; }
        public string Servidor_Publico_que_Busca { get; set; }
        public string Servidor_Publico_que_Localiza { get; set; }
        public string Servidor_Publico_que_Recolecta { get; set; }
        public string Servidor_Publico_que_Traslada { get; set; }
        public string Preservacion { get; set; }
        public string Busqueda { get; set; }
        public string Localizacion { get; set; }
        public string Recoleccion { get; set; }

        [ForeignKey("Delito_Referencia")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Referencia_Delito { get; set; }
        [ForeignKey("Cargo")]
        public virtual Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC Cargo_Catalogo_Tipo_de_Cargo_CC { get; set; }
        [ForeignKey("Asignar")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Asignar_Spartan_User { get; set; }
        [ForeignKey("Unidad_Policial")]
        public virtual Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial Unidad_Policial_Catalogo_Unidad_Policial { get; set; }
        [ForeignKey("Fijacion_Planimetrica")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Fijacion_Planimetrica_Spartane_File { get; set; }
        [ForeignKey("Unidad_Administrativa")]
        public virtual Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC { get; set; }
        [ForeignKey("Entidad_Federativa")]
        public virtual Spartane.Core.Domain.Estado.Estado Entidad_Federativa_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Motivo_de_Intervencion")]
        public virtual Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Catalogo_Estatus_CC.Catalogo_Estatus_CC Estatus_Catalogo_Estatus_CC { get; set; }
        [ForeignKey("Inicio_de_Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia { get; set; }
        [ForeignKey("Calidad_de_quien_aporta")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Calidad_de_quien_aporta_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Descripcion_de_recoleccion")]
        public virtual Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion Descripcion_de_recoleccion_Catalogo_de_Recoleccion { get; set; }
        [ForeignKey("Movil_para_Traslado")]
        public virtual Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado Movil_para_Traslado_Catalogo_de_Movil_para_traslado { get; set; }

    }
	
	public class Cadena_de_Custodia_Asignacion
    {
                public int Clave { get; set; }
        public string NUC { get; set; }
        public string NIC { get; set; }
        public int? Delito_Referencia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Asignar { get; set; }
        public string Folio_NUE { get; set; }
        public string CUIP { get; set; }
        public int? Estatus { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public DateTime? Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public string Estatus_NUE { get; set; }

		        [ForeignKey("Delito_Referencia")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Referencia_Delito { get; set; }
        [ForeignKey("Asignar")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Asignar_Spartan_User { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Catalogo_Estatus_CC.Catalogo_Estatus_CC Estatus_Catalogo_Estatus_CC { get; set; }

    }

	public class Cadena_de_Custodia_Cadena_de_Custodia
    {
                public int Clave { get; set; }
        public string Lugar_Exacto_del_Levantamiento { get; set; }
        public string Condicion_y_Ubicacion { get; set; }
        public short? Levantada_por { get; set; }
        public int? Cargo { get; set; }
        public int? Unidad_Policial { get; set; }
        public string Caracterististicas_del_indicio { get; set; }
        public string Condiciones_De_Manejo { get; set; }
        public string Numero_de_Parte { get; set; }
        public string Observaciones { get; set; }
        public int? Unidad_Administrativa { get; set; }
        public int? Entidad_Federativa { get; set; }
        public int? Municipio { get; set; }
        public string Numero_de_Oficio { get; set; }
        public DateTime? Fecha_CC { get; set; }
        public string Hora_CC { get; set; }
        public int? Motivo_de_Intervencion { get; set; }
        public string Otro { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Inicio_de_Cadena_de_Custodia { get; set; }
        public int? Calidad_de_quien_aporta { get; set; }
        public DateTime? Fecha_del_arribo { get; set; }
        public string Hora_del_arribo { get; set; }
        public int? Descripcion_de_recoleccion { get; set; }
        public int? Movil_para_Traslado { get; set; }
        public string Servidor_Publico_que_Preserva { get; set; }
        public string Servidor_Publico_que_Busca { get; set; }
        public string Servidor_Publico_que_Localiza { get; set; }
        public string Servidor_Publico_que_Recolecta { get; set; }
        public string Servidor_Publico_que_Traslada { get; set; }
        public string Preservacion { get; set; }
        public string Busqueda { get; set; }
        public string Localizacion { get; set; }
        public string Recoleccion { get; set; }

		        [ForeignKey("Cargo")]
        public virtual Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC Cargo_Catalogo_Tipo_de_Cargo_CC { get; set; }
        [ForeignKey("Unidad_Policial")]
        public virtual Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial Unidad_Policial_Catalogo_Unidad_Policial { get; set; }
        [ForeignKey("Unidad_Administrativa")]
        public virtual Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC { get; set; }
        [ForeignKey("Entidad_Federativa")]
        public virtual Spartane.Core.Domain.Estado.Estado Entidad_Federativa_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Motivo_de_Intervencion")]
        public virtual Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC { get; set; }
        [ForeignKey("Inicio_de_Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia { get; set; }
        [ForeignKey("Calidad_de_quien_aporta")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Calidad_de_quien_aporta_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Descripcion_de_recoleccion")]
        public virtual Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion Descripcion_de_recoleccion_Catalogo_de_Recoleccion { get; set; }
        [ForeignKey("Movil_para_Traslado")]
        public virtual Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado Movil_para_Traslado_Catalogo_de_Movil_para_traslado { get; set; }

    }

	public class Cadena_de_Custodia_Fijacion_Planimetrica
    {
                public int Clave { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Clima { get; set; }
        public string Grados { get; set; }
        public int? Fijacion_Planimetrica { get; set; }
        public string Fijacion_Planimetrica_URL { get; set; }

		        [ForeignKey("Fijacion_Planimetrica")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Fijacion_Planimetrica_Spartane_File { get; set; }

    }

	public class Cadena_de_Custodia_Fotos
    {
                public int Clave { get; set; }

		
    }

	public class Cadena_de_Custodia_Videos
    {
                public int Clave { get; set; }

		
    }

	public class Cadena_de_Custodia_Registro_de_Intervinientes
    {
                public int Clave { get; set; }

		
    }

	public class Cadena_de_Custodia_Chat
    {
                public int Clave { get; set; }
        public string Mensaje { get; set; }

		
    }

	public class Cadena_de_Custodia_Documentos
    {
                public int Clave { get; set; }

		
    }

	public class Cadena_de_Custodia_Retroalimentacion
    {
                public int Clave { get; set; }

		
    }

	public class Cadena_de_Custodia_Registro_de_Emergencia
    {
                public int Clave { get; set; }
        public string FAE { get; set; }
        public DateTime? Fecha_de_la_Emergencia { get; set; }
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
        public DateTime? Fecha_de_la_Detencion { get; set; }
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

	public class Cadena_de_Custodia_Registro_de_Detenidos
    {
                public int Clave { get; set; }

		
    }

	public class Cadena_de_Custodia_Registro_de_Testigos
    {
                public int Clave { get; set; }

		
    }

	public class Cadena_de_Custodia_Datos_Generales
    {
                public int Clave { get; set; }

		
    }

	public class Cadena_de_Custodia_Asignaciones
    {
                public int Clave { get; set; }

		
    }

	public class Cadena_de_Custodia_Datos_de_Traslado
    {
                public int Clave { get; set; }

		
    }


}

