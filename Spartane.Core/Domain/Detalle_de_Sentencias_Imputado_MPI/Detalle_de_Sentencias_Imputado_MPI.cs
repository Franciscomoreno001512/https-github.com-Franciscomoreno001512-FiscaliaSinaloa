using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Sentencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Sentencias_Imputado_MPI
{
    /// <summary>
    /// Detalle_de_Sentencias_Imputado_MPI table
    /// </summary>
    public class Detalle_de_Sentencias_Imputado_MPI: BaseEntity
    {
        public int Clave { get; set; }
        public int? Detalle_Datos_del_Imputado_MPI { get; set; }
        public int? Delito { get; set; }
        public int? Sentencia { get; set; }
        public DateTime? Fecha_de_Devolucion { get; set; }
        public string Hora_de_Devolucion { get; set; }
        public decimal? Repacion_del_Dano { get; set; }
        public string Resolucion { get; set; }

        [ForeignKey("Detalle_Datos_del_Imputado_MPI")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI Detalle_Datos_del_Imputado_MPI_Detalle_de_Datos_del_Imputado_MPI { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Sentencia")]
        public virtual Spartane.Core.Domain.Sentencia.Sentencia Sentencia_Sentencia { get; set; }

    }
	
	public class Detalle_de_Sentencias_Imputado_MPI_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Detalle_Datos_del_Imputado_MPI { get; set; }
        public int? Delito { get; set; }
        public int? Sentencia { get; set; }
        public DateTime? Fecha_de_Devolucion { get; set; }
        public string Hora_de_Devolucion { get; set; }
        public decimal? Repacion_del_Dano { get; set; }
        public string Resolucion { get; set; }

		        [ForeignKey("Detalle_Datos_del_Imputado_MPI")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI Detalle_Datos_del_Imputado_MPI_Detalle_de_Datos_del_Imputado_MPI { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Sentencia")]
        public virtual Spartane.Core.Domain.Sentencia.Sentencia Sentencia_Sentencia { get; set; }

    }


}

