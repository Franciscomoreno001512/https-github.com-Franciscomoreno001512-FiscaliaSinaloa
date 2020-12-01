using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Configuracion_de_Planeacion
{
    /// <summary>
    /// Configuracion_de_Planeacion table
    /// </summary>
    public class Configuracion_de_Planeacion: BaseEntity
    {
        public int Folio { get; set; }
        public int? Delito { get; set; }
        public short? Categoria { get; set; }
        public int? Servicio { get; set; }
        public string Entregable { get; set; }
        public short? Tiempo_Estandar { get; set; }
        public short? Ponderacion { get; set; }

        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Categoria")]
        public virtual Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo Categoria_Categoria_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }

    }
	
	public class Configuracion_de_Planeacion_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Delito { get; set; }
        public short? Categoria { get; set; }
        public int? Servicio { get; set; }
        public string Entregable { get; set; }
        public short? Tiempo_Estandar { get; set; }
        public short? Ponderacion { get; set; }

		        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Categoria")]
        public virtual Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo Categoria_Categoria_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }

    }


}

