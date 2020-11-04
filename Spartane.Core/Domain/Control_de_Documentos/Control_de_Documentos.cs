using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Control_de_Documentos
{
    /// <summary>
    /// Control_de_Documentos table
    /// </summary>
    public class Control_de_Documentos: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? idFormato { get; set; }
        public int? LlaveRegistro { get; set; }
        public string TablaPersona { get; set; }
        public int? LlaveRegistroPersona { get; set; }
        public int? Proceso { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Cuerpo_del_Documento { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }
        public string Encabezado { get; set; }
        public string Pie_de_Pagina { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Proceso")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Proceso_Origen_de_Invitacion { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

    }
	
	public class Control_de_Documentos_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? idFormato { get; set; }
        public int? LlaveRegistro { get; set; }
        public string TablaPersona { get; set; }
        public int? LlaveRegistroPersona { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }

    }

	public class Control_de_Documentos_Documento
    {
                public int Folio { get; set; }
        public int? Proceso { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Cuerpo_del_Documento { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }

		        [ForeignKey("Proceso")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Proceso_Origen_de_Invitacion { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

    }

	public class Control_de_Documentos_Secciones
    {
                public int Folio { get; set; }
        public string Encabezado { get; set; }
        public string Pie_de_Pagina { get; set; }

		
    }

	public class Control_de_Documentos_Historial
    {
                public int Folio { get; set; }

		
    }


}

