using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Partida_que_Cumplimenta;
using Spartane.Core.Domain.Area_envia_Cumplimiento;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Registro_de_Cumplimiento
{
    /// <summary>
    /// Registro_de_Cumplimiento table
    /// </summary>
    public class Registro_de_Cumplimiento: BaseEntity
    {
        public int Clave { get; set; }
        public int? Mandamiento_Judicial { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_de_Registro { get; set; }
        public int? Resolucion { get; set; }
        public DateTime? Fecha_de_Resolucion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public string Radiograma { get; set; }
        public int? Partida_que_cumplimenta { get; set; }
        public int? Area_que_envia_cumplimiento { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public string Observaciones_del_Cumplimiento { get; set; }

        [ForeignKey("Mandamiento_Judicial")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Mandamiento_Judicial_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Usuario_de_Registro")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_de_Registro_Spartan_User { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial Resolucion_Resolucion_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Partida_que_cumplimenta")]
        public virtual Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta Partida_que_cumplimenta_Partida_que_Cumplimenta { get; set; }
        [ForeignKey("Area_que_envia_cumplimiento")]
        public virtual Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento Area_que_envia_cumplimiento_Area_envia_Cumplimiento { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }
	
	public class Registro_de_Cumplimiento_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Mandamiento_Judicial { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_de_Registro { get; set; }
        public int? Resolucion { get; set; }
        public DateTime? Fecha_de_Resolucion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public string Radiograma { get; set; }
        public int? Partida_que_cumplimenta { get; set; }
        public int? Area_que_envia_cumplimiento { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public string Observaciones_del_Cumplimiento { get; set; }

		        [ForeignKey("Mandamiento_Judicial")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Mandamiento_Judicial_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Usuario_de_Registro")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_de_Registro_Spartan_User { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial Resolucion_Resolucion_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Partida_que_cumplimenta")]
        public virtual Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta Partida_que_cumplimenta_Partida_que_Cumplimenta { get; set; }
        [ForeignKey("Area_que_envia_cumplimiento")]
        public virtual Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento Area_que_envia_cumplimiento_Area_envia_Cumplimiento { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }


}

