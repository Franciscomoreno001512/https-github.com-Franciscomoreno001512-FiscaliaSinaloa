using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Servicios_Periciales;
using Spartane.Core.Domain.Estatus_del_Dictamen;
using Spartane.Core.Domain.Rol_de_Diligencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Diligencias
{
    /// <summary>
    /// Diligencias table
    /// </summary>
    public class Diligencias: BaseEntity
    {
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Servicio { get; set; }
        public int? Especialista { get; set; }
        public int? Estatus_del_Dictamen { get; set; }
        public DateTime? Fecha_del_Dictamen { get; set; }
        public short? Dictamen { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public int Clave { get; set; }
        public string Clave_Diligencia { get; set; }

        [ForeignKey("Servicio")]
        public virtual Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales Servicio_Servicios_Periciales { get; set; }
        [ForeignKey("Estatus_del_Dictamen")]
        public virtual Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen Estatus_del_Dictamen_Estatus_del_Dictamen { get; set; }
        [ForeignKey("Rol_de_Donde_Proviene")]
        public virtual Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia Rol_de_Donde_Proviene_Rol_de_Diligencia { get; set; }

    }
	
	public class Diligencias_Datos_Generales
    {
                public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Servicio { get; set; }
        public int? Especialista { get; set; }
        public int? Estatus_del_Dictamen { get; set; }
        public DateTime? Fecha_del_Dictamen { get; set; }
        public short? Dictamen { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public int Clave { get; set; }
        public string Clave_Diligencia { get; set; }

		        [ForeignKey("Servicio")]
        public virtual Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales Servicio_Servicios_Periciales { get; set; }
        [ForeignKey("Estatus_del_Dictamen")]
        public virtual Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen Estatus_del_Dictamen_Estatus_del_Dictamen { get; set; }
        [ForeignKey("Rol_de_Donde_Proviene")]
        public virtual Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia Rol_de_Donde_Proviene_Rol_de_Diligencia { get; set; }

    }


}

