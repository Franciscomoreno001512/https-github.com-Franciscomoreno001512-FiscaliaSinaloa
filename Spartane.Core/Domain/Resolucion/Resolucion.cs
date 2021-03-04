using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Resolucion;
using Spartane.Core.Domain.Resolucion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Resolucion
{
    /// <summary>
    /// Resolucion table
    /// </summary>
    public class Resolucion: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo { get; set; }
        public int? Resolucion_Padre_para_Autorizacion { get; set; }
        public bool? Generar_Judicializacion { get; set; }
        public string ClaveFiscalia { get; set; }
        public bool? Resolucion_AT { get; set; }
        public bool? Resolucion_MP { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }
        public bool? Aplica_para_Denuncia { get; set; }
        public bool? Aplica_para_Carpeta_de_Investigacion { get; set; }
        public string Abreviacion { get; set; }
        public string Vigencia { get; set; }
        public string MostrarDependencia { get; set; }
        public int? Conteo { get; set; }
        public int? Estatus { get; set; }
        public int? Estatus_esp { get; set; }
        public int? Mostrar_Estadistico { get; set; }

        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Resolucion.Tipo_de_Resolucion Tipo_Tipo_de_Resolucion { get; set; }
        [ForeignKey("Resolucion_Padre_para_Autorizacion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resolucion_Padre_para_Autorizacion_Resolucion { get; set; }

    }
	
	public class Resolucion_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo { get; set; }
        public int? Resolucion_Padre_para_Autorizacion { get; set; }
        public bool? Generar_Judicializacion { get; set; }
        public string ClaveFiscalia { get; set; }
        public bool? Resolucion_AT { get; set; }
        public bool? Resolucion_MP { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }
        public bool? Aplica_para_Denuncia { get; set; }
        public bool? Aplica_para_Carpeta_de_Investigacion { get; set; }
        public string Abreviacion { get; set; }
        public string Vigencia { get; set; }
        public string MostrarDependencia { get; set; }
        public int? Conteo { get; set; }
        public int? Estatus { get; set; }
        public int? Estatus_esp { get; set; }
        public int? Mostrar_Estadistico { get; set; }

		        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Resolucion.Tipo_de_Resolucion Tipo_Tipo_de_Resolucion { get; set; }
        [ForeignKey("Resolucion_Padre_para_Autorizacion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resolucion_Padre_para_Autorizacion_Resolucion { get; set; }

    }


}

