using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Plan_de_Investigacion;
using Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion
{
    /// <summary>
    /// Detalle_Plan_Actos_de_Investigacion table
    /// </summary>
    public class Detalle_Plan_Actos_de_Investigacion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Plan_de_Investigacion { get; set; }
        public short? Categoria { get; set; }
        public int? Servicio_a_Solicitar { get; set; }
        public string Hecho_Delictivo_Acreditado { get; set; }
        public short? Tiempo_Estandar { get; set; }
        public short? Ponderacion { get; set; }
        public DateTime? Fecha_Contestacion { get; set; }
        public string Hora_Contestacion { get; set; }
        public string Contestacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }
        public int? Usuario_que_Contesta { get; set; }

        [ForeignKey("Plan_de_Investigacion")]
        public virtual Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion Plan_de_Investigacion_Plan_de_Investigacion { get; set; }
        [ForeignKey("Categoria")]
        public virtual Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo Categoria_Categoria_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Servicio_a_Solicitar")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }
        [ForeignKey("Usuario_que_Contesta")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Contesta_Spartan_User { get; set; }

    }
	
	public class Detalle_Plan_Actos_de_Investigacion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Plan_de_Investigacion { get; set; }
        public short? Categoria { get; set; }
        public int? Servicio_a_Solicitar { get; set; }
        public string Hecho_Delictivo_Acreditado { get; set; }
        public short? Tiempo_Estandar { get; set; }
        public short? Ponderacion { get; set; }
        public DateTime? Fecha_Contestacion { get; set; }
        public string Hora_Contestacion { get; set; }
        public string Contestacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public string Archivo_Adjunto_URL { get; set; }
        public int? Usuario_que_Contesta { get; set; }

		        [ForeignKey("Plan_de_Investigacion")]
        public virtual Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion Plan_de_Investigacion_Plan_de_Investigacion { get; set; }
        [ForeignKey("Categoria")]
        public virtual Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo Categoria_Categoria_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Servicio_a_Solicitar")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Archivo_Adjunto")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Adjunto_Spartane_File { get; set; }
        [ForeignKey("Usuario_que_Contesta")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Contesta_Spartan_User { get; set; }

    }


}

