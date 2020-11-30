using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Diligencias_MP;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Servicios_de_Apoyo_MP
{
    /// <summary>
    /// Servicios_de_Apoyo_MP table
    /// </summary>
    public class Servicios_de_Apoyo_MP: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public short? Categoria { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Solicitud { get; set; }
        public DateTime? Fecha_de_Termino_para_Entrega { get; set; }
        public string Hora_de_Termino_para_Entrega { get; set; }
        public int? Diligencia_a_Enviar { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }
        public DateTime? Fecha_de_Atencion { get; set; }
        public string Hora_de_Atencion { get; set; }
        public int? Usuario_que_Atiende { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }

        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Categoria")]
        public virtual Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo Categoria_Categoria_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Diligencia_a_Enviar")]
        public virtual Spartane.Core.Domain.Diligencias_MP.Diligencias_MP Diligencia_a_Enviar_Diligencias_MP { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }
        [ForeignKey("Usuario_que_Atiende")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Atiende_Spartan_User { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }

    }
	
	public class Servicios_de_Apoyo_MP_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public short? Categoria { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Solicitud { get; set; }
        public DateTime? Fecha_de_Termino_para_Entrega { get; set; }
        public string Hora_de_Termino_para_Entrega { get; set; }
        public int? Diligencia_a_Enviar { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }

		        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Categoria")]
        public virtual Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo Categoria_Categoria_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Diligencia_a_Enviar")]
        public virtual Spartane.Core.Domain.Diligencias_MP.Diligencias_MP Diligencia_a_Enviar_Diligencias_MP { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

    }

	public class Servicios_de_Apoyo_MP_Contestacion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Atencion { get; set; }
        public string Hora_de_Atencion { get; set; }
        public int? Usuario_que_Atiende { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }

		        [ForeignKey("Usuario_que_Atiende")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Atiende_Spartan_User { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }

    }


}

