using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Expediente_Generado;
using Spartane.Core.Domain.Documento;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Resumen_Denuncia
{
    /// <summary>
    /// Detalle_Resumen_Denuncia table
    /// </summary>
    public class Detalle_Resumen_Denuncia: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_registro { get; set; }
        public string Hora_de_registro { get; set; }
        public int? Usuario_que_registra { get; set; }
        public int? Generar { get; set; }
        public string Numero_Generado { get; set; }
        public string Numero_de_Oficio { get; set; }
        public string Probable_Responsable { get; set; }
        public string Delito { get; set; }
        public string Victima { get; set; }
        public string Relacion { get; set; }
        public string Hechos { get; set; }
        public bool? Generado { get; set; }
        public bool? Archivo_Descargado { get; set; }
        public int? Documento { get; set; }
        public int? Archivo { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_registra_Spartan_User { get; set; }
        [ForeignKey("Generar")]
        public virtual Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado Generar_Tipo_de_Expediente_Generado { get; set; }
        [ForeignKey("Documento")]
        public virtual Spartane.Core.Domain.Documento.Documento Documento_Documento { get; set; }

    }
	
	public class Detalle_Resumen_Denuncia_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_registro { get; set; }
        public string Hora_de_registro { get; set; }
        public int? Usuario_que_registra { get; set; }
        public int? Generar { get; set; }
        public string Numero_Generado { get; set; }
        public string Numero_de_Oficio { get; set; }
        public string Probable_Responsable { get; set; }
        public string Delito { get; set; }
        public string Victima { get; set; }
        public string Relacion { get; set; }
        public string Hechos { get; set; }
        public bool? Generado { get; set; }
        public bool? Archivo_Descargado { get; set; }
        public int? Documento { get; set; }
        public int? Archivo { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_registra_Spartan_User { get; set; }
        [ForeignKey("Generar")]
        public virtual Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado Generar_Tipo_de_Expediente_Generado { get; set; }
        [ForeignKey("Documento")]
        public virtual Spartane.Core.Domain.Documento.Documento Documento_Documento { get; set; }

    }


}

