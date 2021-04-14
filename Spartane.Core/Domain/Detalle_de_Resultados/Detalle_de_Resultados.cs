using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Resultados
{
    /// <summary>
    /// Detalle_de_Resultados table
    /// </summary>
    public class Detalle_de_Resultados: BaseEntity
    {
        public int Clave { get; set; }
        public int? Consulta_de_Ordenes { get; set; }
        public string Fuente { get; set; }
        public string Tipo_de_Mandamiento { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public string Sexo { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Juzgado { get; set; }
        public string Oficio_Solicitud_Juzgado { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Causa_Penal { get; set; }

        [ForeignKey("Consulta_de_Ordenes")]
        public virtual Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales Consulta_de_Ordenes_Consulta_de_Mandamientos_Judiciales { get; set; }

    }
	
	public class Detalle_de_Resultados_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Consulta_de_Ordenes { get; set; }
        public string Fuente { get; set; }
        public string Tipo_de_Mandamiento { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public string Sexo { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Juzgado { get; set; }
        public string Oficio_Solicitud_Juzgado { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Causa_Penal { get; set; }

		        [ForeignKey("Consulta_de_Ordenes")]
        public virtual Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales Consulta_de_Ordenes_Consulta_de_Mandamientos_Judiciales { get; set; }

    }


}

