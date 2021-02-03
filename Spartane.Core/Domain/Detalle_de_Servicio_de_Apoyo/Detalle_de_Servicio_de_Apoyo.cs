using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Dialecto;
using Spartane.Core.Domain.Idioma;
using Spartane.Core.Domain.Compareciente;
using Spartane.Core.Domain.Detalle_de_Documentos_MPO;
using Spartane.Core.Domain.Detalle_de_documentos;
using Spartane.Core.Domain.Diligencias_MP;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Autoridad_Servicio_Pericial;
using Spartane.Core.Domain.Agencia_Servicio_Pericial;
using Spartane.Core.Domain.Dictamen_Servicio_Pericial;
using Spartane.Core.Domain.Area_Pericial;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo
{
    /// <summary>
    /// Detalle_de_Servicio_de_Apoyo table
    /// </summary>
    public class Detalle_de_Servicio_de_Apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Origen { get; set; }
        public int? Modulo_de_Atencion_Inicial { get; set; }
        public int? Modulo_Mecanismos_Alternos { get; set; }
        public int? Modulo_Ministerio_Publico { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public int? Idioma { get; set; }
        public string Responsable { get; set; }
        public int? Compareciente { get; set; }
        public int? Documento_Atencion_Inicial { get; set; }
        public int? Documento_Mecanismos_Alternos { get; set; }
        public int? Documento_Ministerio_Publico { get; set; }
        public int? Diligencia { get; set; }
        public int? Archivo { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public string Numero_Oficio { get; set; }
        public int? Imagen { get; set; }
        public string Imagen_URL { get; set; }
        public string Nombre_Solicitante { get; set; }
        public string Rango_Solicitante { get; set; }
        public int? Autoridades { get; set; }
        public int? Agencia { get; set; }
        public string Observaciones { get; set; }
        public int? Dictamen { get; set; }
        public bool? Contestacion_lista_para_enviarse { get; set; }
        public int? Area_Pericial { get; set; }
        public int? Perito { get; set; }

        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }
        [ForeignKey("Modulo_de_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Modulo_Mecanismos_Alternos")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Modulo_Mecanismos_Alternos_Solicitud { get; set; }
        [ForeignKey("Modulo_Ministerio_Publico")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Modulo_Ministerio_Publico_expediente_ministerio_publico { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Lengua_Originaria")]
        public virtual Spartane.Core.Domain.Dialecto.Dialecto Lengua_Originaria_Dialecto { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Compareciente.Compareciente Compareciente_Compareciente { get; set; }
        [ForeignKey("Documento_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO Documento_Atencion_Inicial_Detalle_de_Documentos_MPO { get; set; }
        [ForeignKey("Documento_Mecanismos_Alternos")]
        public virtual Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos Documento_Mecanismos_Alternos_Detalle_de_documentos { get; set; }
        [ForeignKey("Documento_Ministerio_Publico")]
        public virtual Spartane.Core.Domain.Diligencias_MP.Diligencias_MP Documento_Ministerio_Publico_Diligencias_MP { get; set; }
        [ForeignKey("Diligencia")]
        public virtual Spartane.Core.Domain.Documento.Documento Diligencia_Documento { get; set; }
        [ForeignKey("Imagen")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Imagen_Spartane_File { get; set; }
        [ForeignKey("Autoridades")]
        public virtual Spartane.Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial Autoridades_Autoridad_Servicio_Pericial { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia_Servicio_Pericial.Agencia_Servicio_Pericial Agencia_Agencia_Servicio_Pericial { get; set; }
        [ForeignKey("Dictamen")]
        public virtual Spartane.Core.Domain.Dictamen_Servicio_Pericial.Dictamen_Servicio_Pericial Dictamen_Dictamen_Servicio_Pericial { get; set; }
        [ForeignKey("Area_Pericial")]
        public virtual Spartane.Core.Domain.Area_Pericial.Area_Pericial Area_Pericial_Area_Pericial { get; set; }
        [ForeignKey("Perito")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Perito_Spartan_User { get; set; }

    }
	
	public class Detalle_de_Servicio_de_Apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Origen { get; set; }
        public int? Modulo_de_Atencion_Inicial { get; set; }
        public int? Modulo_Mecanismos_Alternos { get; set; }
        public int? Modulo_Ministerio_Publico { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public int? Idioma { get; set; }
        public string Responsable { get; set; }
        public int? Compareciente { get; set; }
        public int? Documento_Atencion_Inicial { get; set; }
        public int? Documento_Mecanismos_Alternos { get; set; }
        public int? Documento_Ministerio_Publico { get; set; }
        public int? Diligencia { get; set; }
        public int? Archivo { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public string Numero_Oficio { get; set; }
        public int? Imagen { get; set; }
        public string Imagen_URL { get; set; }
        public string Nombre_Solicitante { get; set; }
        public string Rango_Solicitante { get; set; }
        public int? Autoridades { get; set; }
        public int? Agencia { get; set; }
        public string Observaciones { get; set; }
        public int? Dictamen { get; set; }
        public bool? Contestacion_lista_para_enviarse { get; set; }

		        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }
        [ForeignKey("Modulo_de_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Modulo_Mecanismos_Alternos")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Modulo_Mecanismos_Alternos_Solicitud { get; set; }
        [ForeignKey("Modulo_Ministerio_Publico")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Modulo_Ministerio_Publico_expediente_ministerio_publico { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Lengua_Originaria")]
        public virtual Spartane.Core.Domain.Dialecto.Dialecto Lengua_Originaria_Dialecto { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Compareciente.Compareciente Compareciente_Compareciente { get; set; }
        [ForeignKey("Documento_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO Documento_Atencion_Inicial_Detalle_de_Documentos_MPO { get; set; }
        [ForeignKey("Documento_Mecanismos_Alternos")]
        public virtual Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos Documento_Mecanismos_Alternos_Detalle_de_documentos { get; set; }
        [ForeignKey("Documento_Ministerio_Publico")]
        public virtual Spartane.Core.Domain.Diligencias_MP.Diligencias_MP Documento_Ministerio_Publico_Diligencias_MP { get; set; }
        [ForeignKey("Diligencia")]
        public virtual Spartane.Core.Domain.Documento.Documento Diligencia_Documento { get; set; }
        [ForeignKey("Imagen")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Imagen_Spartane_File { get; set; }
        [ForeignKey("Autoridades")]
        public virtual Spartane.Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial Autoridades_Autoridad_Servicio_Pericial { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia_Servicio_Pericial.Agencia_Servicio_Pericial Agencia_Agencia_Servicio_Pericial { get; set; }
        [ForeignKey("Dictamen")]
        public virtual Spartane.Core.Domain.Dictamen_Servicio_Pericial.Dictamen_Servicio_Pericial Dictamen_Dictamen_Servicio_Pericial { get; set; }

    }

	public class Detalle_de_Servicio_de_Apoyo_Canalizar
    {
                public int Clave { get; set; }
        public int? Area_Pericial { get; set; }
        public int? Perito { get; set; }

		        [ForeignKey("Area_Pericial")]
        public virtual Spartane.Core.Domain.Area_Pericial.Area_Pericial Area_Pericial_Area_Pericial { get; set; }
        [ForeignKey("Perito")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Perito_Spartan_User { get; set; }

    }


}

