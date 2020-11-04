using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Medios_Alternativos;
using Spartane.Core.Domain.Tipo_de_Instancia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Servicios_de_Apoyo
{
    /// <summary>
    /// Servicios_de_Apoyo table
    /// </summary>
    public class Servicios_de_Apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Folio_del_Caso { get; set; }
        public bool? Justicia_Alternativa { get; set; }
        public int? Medios_Alternativos { get; set; }
        public string Motivo { get; set; }
        public bool? Derechos { get; set; }
        public bool? Procedimiento { get; set; }
        public bool? Solicita_Medios_Alternativos { get; set; }
        public int? Se_Canaliza { get; set; }
        public bool? Investigacion_con_Detenido { get; set; }
        public bool? Investigacion_sin_Detenido { get; set; }
        public bool? Turnar_a_Justicia_Alternativa { get; set; }
        public bool? Instancia_Externa { get; set; }

        [ForeignKey("Folio_del_Caso")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Folio_del_Caso_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Medios_Alternativos")]
        public virtual Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos Medios_Alternativos_Medios_Alternativos { get; set; }
        [ForeignKey("Se_Canaliza")]
        public virtual Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia Se_Canaliza_Tipo_de_Instancia { get; set; }

    }
	
	public class Servicios_de_Apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Folio_del_Caso { get; set; }
        public bool? Justicia_Alternativa { get; set; }
        public int? Medios_Alternativos { get; set; }
        public string Motivo { get; set; }
        public bool? Derechos { get; set; }
        public bool? Procedimiento { get; set; }
        public bool? Solicita_Medios_Alternativos { get; set; }
        public int? Se_Canaliza { get; set; }
        public bool? Investigacion_con_Detenido { get; set; }
        public bool? Investigacion_sin_Detenido { get; set; }
        public bool? Turnar_a_Justicia_Alternativa { get; set; }
        public bool? Instancia_Externa { get; set; }

		        [ForeignKey("Folio_del_Caso")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Folio_del_Caso_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Medios_Alternativos")]
        public virtual Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos Medios_Alternativos_Medios_Alternativos { get; set; }
        [ForeignKey("Se_Canaliza")]
        public virtual Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia Se_Canaliza_Tipo_de_Instancia { get; set; }

    }


}

