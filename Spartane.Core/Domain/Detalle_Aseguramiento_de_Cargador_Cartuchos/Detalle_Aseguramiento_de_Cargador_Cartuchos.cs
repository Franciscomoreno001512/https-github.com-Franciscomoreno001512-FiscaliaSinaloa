using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Calibre_de_Arma;
using Spartane.Core.Domain.Motivo_de_Registro;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos
{
    /// <summary>
    /// Detalle_Aseguramiento_de_Cargador_Cartuchos table
    /// </summary>
    public class Detalle_Aseguramiento_de_Cargador_Cartuchos: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Calibre { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public int? cartuchos_municiones { get; set; }
        public string Cartuchos_Habiles { get; set; }
        public int? Cartuchos_Percutidos { get; set; }
        public int? cargadores { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Calibre")]
        public virtual Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma Calibre_Calibre_de_Arma { get; set; }
        [ForeignKey("Motivo_de_Registro")]
        public virtual Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro Motivo_de_Registro_Motivo_de_Registro { get; set; }

    }
	
	public class Detalle_Aseguramiento_de_Cargador_Cartuchos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Calibre { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public int? cartuchos_municiones { get; set; }
        public string Cartuchos_Habiles { get; set; }
        public int? Cartuchos_Percutidos { get; set; }
        public int? cargadores { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Calibre")]
        public virtual Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma Calibre_Calibre_de_Arma { get; set; }
        [ForeignKey("Motivo_de_Registro")]
        public virtual Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro Motivo_de_Registro_Motivo_de_Registro { get; set; }

    }


}

