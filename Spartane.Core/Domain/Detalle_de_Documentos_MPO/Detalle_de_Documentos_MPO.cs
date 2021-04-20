using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Documento;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Estatus_Persona;
using Spartane.Core.Domain.Condiciones_de_Localizacion;
using Spartane.Core.Domain.Lugar_del_Hallazgo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Ente_que_localiza;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Documentos_MPO
{
    /// <summary>
    /// Detalle_de_Documentos_MPO table
    /// </summary>
    public class Detalle_de_Documentos_MPO: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public int? Documento { get; set; }
        public int? Involucrado { get; set; }
        public int? Probable_Responsable { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }
        public string Observaciones { get; set; }
        public int? Archivo { get; set; }
        public bool? Lista_para_periciales { get; set; }
        public string Folio { get; set; }
        public int? Expediente_MP { get; set; }
        public string Descripcion { get; set; }
        public int? Estatus_Persona { get; set; }
        public DateTime? Fecha_Localizacion { get; set; }
        public string Hora_Localizacion { get; set; }
        public int? Condiciones_de_Localizacion { get; set; }
        public int? Lugar_de_Hallazgo { get; set; }
        public string Posible_Causa_de_la_Desaparacion { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public string Calle { get; set; }
        public string Numero_Interior { get; set; }
        public string Numero_Exterior { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Ente_que_localiza_al_no_localizado { get; set; }
        public string ente_Paterno { get; set; }
        public string ente_Materno { get; set; }
        public string ente_Nombre { get; set; }
        public string Autoridad_que_conoce_el_hecho { get; set; }
        public string autoridad_Paterno { get; set; }
        public string autoridad_Materno { get; set; }
        public string autoridad_Nombre { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Documento")]
        public virtual Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento Tipo_de_Documento_Tipo_de_Documento { get; set; }
        [ForeignKey("Documento")]
        public virtual Spartane.Core.Domain.Documento.Documento Documento_Documento { get; set; }
        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Probable_Responsable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Responsable_Detalle_de_Imputado { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }
        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Estatus_Persona")]
        public virtual Spartane.Core.Domain.Estatus_Persona.Estatus_Persona Estatus_Persona_Estatus_Persona { get; set; }
        [ForeignKey("Condiciones_de_Localizacion")]
        public virtual Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion Condiciones_de_Localizacion_Condiciones_de_Localizacion { get; set; }
        [ForeignKey("Lugar_de_Hallazgo")]
        public virtual Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo Lugar_de_Hallazgo_Lugar_del_Hallazgo { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Ente_que_localiza_al_no_localizado")]
        public virtual Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza Ente_que_localiza_al_no_localizado_Ente_que_localiza { get; set; }

    }
	
	public class Detalle_de_Documentos_MPO_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public int? Documento { get; set; }
        public int? Involucrado { get; set; }
        public int? Probable_Responsable { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }
        public string Observaciones { get; set; }
        public int? Archivo { get; set; }
        public bool? Lista_para_periciales { get; set; }
        public string Folio { get; set; }
        public int? Expediente_MP { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Documento")]
        public virtual Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento Tipo_de_Documento_Tipo_de_Documento { get; set; }
        [ForeignKey("Documento")]
        public virtual Spartane.Core.Domain.Documento.Documento Documento_Documento { get; set; }
        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Probable_Responsable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Responsable_Detalle_de_Imputado { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }
        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }

    }

	public class Detalle_de_Documentos_MPO_Localizacion
    {
                public int Clave { get; set; }
        public int? Estatus_Persona { get; set; }
        public DateTime? Fecha_Localizacion { get; set; }
        public string Hora_Localizacion { get; set; }
        public int? Condiciones_de_Localizacion { get; set; }
        public int? Lugar_de_Hallazgo { get; set; }
        public string Posible_Causa_de_la_Desaparacion { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public string Calle { get; set; }
        public string Numero_Interior { get; set; }
        public string Numero_Exterior { get; set; }
        public int? Codigo_Postal { get; set; }

		        [ForeignKey("Estatus_Persona")]
        public virtual Spartane.Core.Domain.Estatus_Persona.Estatus_Persona Estatus_Persona_Estatus_Persona { get; set; }
        [ForeignKey("Condiciones_de_Localizacion")]
        public virtual Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion Condiciones_de_Localizacion_Condiciones_de_Localizacion { get; set; }
        [ForeignKey("Lugar_de_Hallazgo")]
        public virtual Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo Lugar_de_Hallazgo_Lugar_del_Hallazgo { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }

	public class Detalle_de_Documentos_MPO_Ente_y_Autoridad
    {
                public int Clave { get; set; }
        public int? Ente_que_localiza_al_no_localizado { get; set; }
        public string ente_Paterno { get; set; }
        public string ente_Materno { get; set; }
        public string ente_Nombre { get; set; }
        public string Autoridad_que_conoce_el_hecho { get; set; }
        public string autoridad_Paterno { get; set; }
        public string autoridad_Materno { get; set; }
        public string autoridad_Nombre { get; set; }

		        [ForeignKey("Ente_que_localiza_al_no_localizado")]
        public virtual Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza Ente_que_localiza_al_no_localizado_Ente_que_localiza { get; set; }

    }


}

