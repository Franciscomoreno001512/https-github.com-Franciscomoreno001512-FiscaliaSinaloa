using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Estatus_de_Indicio;
using Spartane.Core.Domain.Indicios;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_del_Indicio
{
    /// <summary>
    /// Detalle_del_Indicio table
    /// </summary>
    public class Detalle_del_Indicio: BaseEntity
    {
        public int Clave { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Nombre_del_Indicio { get; set; }
        public string Descripcion_del_Indicio { get; set; }
        public string Motivo { get; set; }
        public int? Estatus { get; set; }
        public string Ubicacion_de_Indicio { get; set; }
        public int? Indicios { get; set; }

        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Indicio.Estatus_de_Indicio Estatus_Estatus_de_Indicio { get; set; }
        [ForeignKey("Indicios")]
        public virtual Spartane.Core.Domain.Indicios.Indicios Indicios_Indicios { get; set; }

    }
	
	public class Detalle_del_Indicio_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Nombre_del_Indicio { get; set; }
        public string Descripcion_del_Indicio { get; set; }
        public string Motivo { get; set; }
        public int? Estatus { get; set; }
        public string Ubicacion_de_Indicio { get; set; }
        public int? Indicios { get; set; }

		        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Indicio.Estatus_de_Indicio Estatus_Estatus_de_Indicio { get; set; }
        [ForeignKey("Indicios")]
        public virtual Spartane.Core.Domain.Indicios.Indicios Indicios_Indicios { get; set; }

    }


}

