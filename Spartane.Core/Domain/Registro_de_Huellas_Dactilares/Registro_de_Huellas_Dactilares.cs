using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Registro_de_Huellas_Dactilares
{
    /// <summary>
    /// Registro_de_Huellas_Dactilares table
    /// </summary>
    public class Registro_de_Huellas_Dactilares: BaseEntity
    {
        public int Clave { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public int? Probable_Responsable { get; set; }
        public int? Mano_Izquierda_4_Dedos { get; set; }
        public string Mano_Izquierda_4_Dedos_URL { get; set; }
        public int? Mano_Derecha_4_Dedos { get; set; }
        public string Mano_Derecha_4_Dedos_URL { get; set; }
        public int? Pulgares { get; set; }
        public string Pulgares_URL { get; set; }
        public int? Izquierda_Menique { get; set; }
        public int? Izquierda_Anular { get; set; }
        public int? Izquierda_Medio { get; set; }
        public int? Izquierda_Indice { get; set; }
        public int? Izquierda_Pulgar { get; set; }
        public int? Derecha_Menique { get; set; }
        public int? Derecha_Anular { get; set; }
        public int? Derecha_Medio { get; set; }
        public int? Derecha_Indice { get; set; }
        public int? Derecha_Pulgar { get; set; }

        [ForeignKey("Carpeta_de_Investigacion")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Carpeta_de_Investigacion_expediente_ministerio_publico { get; set; }
        [ForeignKey("Probable_Responsable")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Probable_Responsable_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Mano_Izquierda_4_Dedos")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Mano_Izquierda_4_Dedos_Spartane_File { get; set; }
        [ForeignKey("Mano_Derecha_4_Dedos")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Mano_Derecha_4_Dedos_Spartane_File { get; set; }
        [ForeignKey("Pulgares")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Pulgares_Spartane_File { get; set; }

    }
	
	public class Registro_de_Huellas_Dactilares_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public int? Probable_Responsable { get; set; }
        public int? Mano_Izquierda_4_Dedos { get; set; }
        public string Mano_Izquierda_4_Dedos_URL { get; set; }
        public int? Mano_Derecha_4_Dedos { get; set; }
        public string Mano_Derecha_4_Dedos_URL { get; set; }
        public int? Pulgares { get; set; }
        public string Pulgares_URL { get; set; }
        public int? Izquierda_Menique { get; set; }
        public int? Izquierda_Anular { get; set; }
        public int? Izquierda_Medio { get; set; }
        public int? Izquierda_Indice { get; set; }
        public int? Izquierda_Pulgar { get; set; }
        public int? Derecha_Menique { get; set; }
        public int? Derecha_Anular { get; set; }
        public int? Derecha_Medio { get; set; }
        public int? Derecha_Indice { get; set; }
        public int? Derecha_Pulgar { get; set; }

		        [ForeignKey("Carpeta_de_Investigacion")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Carpeta_de_Investigacion_expediente_ministerio_publico { get; set; }
        [ForeignKey("Probable_Responsable")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Probable_Responsable_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Mano_Izquierda_4_Dedos")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Mano_Izquierda_4_Dedos_Spartane_File { get; set; }
        [ForeignKey("Mano_Derecha_4_Dedos")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Mano_Derecha_4_Dedos_Spartane_File { get; set; }
        [ForeignKey("Pulgares")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Pulgares_Spartane_File { get; set; }

    }


}

