using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Autoridad_Externa;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Estatus_de_Apoyo_Externo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Solicitud_de_Apoyo_Externa
{
    /// <summary>
    /// Solicitud_de_Apoyo_Externa table
    /// </summary>
    public class Solicitud_de_Apoyo_Externa: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Region { get; set; }
        public int? Unidad { get; set; }
        public short? Anio { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public string Numero_de_Oficio_Externo { get; set; }
        public string Solicitante { get; set; }
        public string Rango { get; set; }
        public int? Autoridad_Externa { get; set; }
        public string Narracion_Solicitud { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }
        public int? Area_Asignada { get; set; }
        public int? SubArea_Asignada { get; set; }
        public int? Dictamen_Solicitado { get; set; }
        public int? Estatus { get; set; }
        public DateTime? Fecha_de_Contestacion { get; set; }
        public string Hora_de_Contestacion { get; set; }
        public int? Responsable_que_Contesta { get; set; }
        public string No__Contestacion { get; set; }
        public int? Dictamen { get; set; }
        public string Observaciones { get; set; }
        public int? Ver_Documento { get; set; }
        public string Ver_Documento_URL { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Autoridad_Externa")]
        public virtual Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa Autoridad_Externa_Autoridad_Externa { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }
        [ForeignKey("Area_Asignada")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_Asignada_Area_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("SubArea_Asignada")]
        public virtual Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo.SubArea_de_Servicios_de_Apoyo SubArea_Asignada_SubArea_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("Dictamen_Solicitado")]
        public virtual Spartane.Core.Domain.Documento.Documento Dictamen_Solicitado_Documento { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo Estatus_Estatus_de_Apoyo_Externo { get; set; }
        [ForeignKey("Responsable_que_Contesta")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Responsable_que_Contesta_Spartan_User { get; set; }
        [ForeignKey("Dictamen")]
        public virtual Spartane.Core.Domain.Documento.Documento Dictamen_Documento { get; set; }
        [ForeignKey("Ver_Documento")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Ver_Documento_Spartane_File { get; set; }

    }
	
	public class Solicitud_de_Apoyo_Externa_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Region { get; set; }
        public int? Unidad { get; set; }
        public short? Anio { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public string Numero_de_Oficio_Externo { get; set; }
        public string Solicitante { get; set; }
        public string Rango { get; set; }
        public int? Autoridad_Externa { get; set; }
        public string Narracion_Solicitud { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }
        public int? Area_Asignada { get; set; }
        public int? SubArea_Asignada { get; set; }
        public int? Dictamen_Solicitado { get; set; }
        public int? Estatus { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Autoridad_Externa")]
        public virtual Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa Autoridad_Externa_Autoridad_Externa { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }
        [ForeignKey("Area_Asignada")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_Asignada_Area_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("SubArea_Asignada")]
        public virtual Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo.SubArea_de_Servicios_de_Apoyo SubArea_Asignada_SubArea_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("Dictamen_Solicitado")]
        public virtual Spartane.Core.Domain.Documento.Documento Dictamen_Solicitado_Documento { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo Estatus_Estatus_de_Apoyo_Externo { get; set; }

    }

	public class Solicitud_de_Apoyo_Externa_Contestacion
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Contestacion { get; set; }
        public string Hora_de_Contestacion { get; set; }
        public int? Responsable_que_Contesta { get; set; }
        public string No__Contestacion { get; set; }
        public int? Dictamen { get; set; }
        public string Observaciones { get; set; }
        public int? Ver_Documento { get; set; }
        public string Ver_Documento_URL { get; set; }

		        [ForeignKey("Responsable_que_Contesta")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Responsable_que_Contesta_Spartan_User { get; set; }
        [ForeignKey("Dictamen")]
        public virtual Spartane.Core.Domain.Documento.Documento Dictamen_Documento { get; set; }
        [ForeignKey("Ver_Documento")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Ver_Documento_Spartane_File { get; set; }

    }


}

