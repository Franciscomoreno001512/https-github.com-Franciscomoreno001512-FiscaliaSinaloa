using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.Tipo_de_Solicitud;
using Spartane.Core.Domain.Marca_del_Vehiculo;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Vehiculo;
using Spartane.Core.Domain.Color_Vehiculo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Robo_de_Vehiculo_PC
{
    /// <summary>
    /// Robo_de_Vehiculo_PC table
    /// </summary>
    public class Robo_de_Vehiculo_PC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Tipo_de_Solicitud { get; set; }
        public bool? Robo_de_Vehiculo { get; set; }
        public int? Marca { get; set; }
        public int? Sub_Marca { get; set; }
        public int? Tipo_de_Vehiculo { get; set; }
        public int? Modelo { get; set; }
        public int? Color { get; set; }
        public string Placas { get; set; }
        public string Senas_Particulares { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana Solicitud_Solicitud_de_Denuncia_Ciudadana { get; set; }
        [ForeignKey("Tipo_de_Solicitud")]
        public virtual Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud Tipo_de_Solicitud_Tipo_de_Solicitud { get; set; }
        [ForeignKey("Marca")]
        public virtual Spartane.Core.Domain.Marca_del_Vehiculo.Marca_del_Vehiculo Marca_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Sub_Marca")]
        public virtual Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo Sub_Marca_Sub_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Tipo_de_Vehiculo")]
        public virtual Spartane.Core.Domain.Tipo_de_Vehiculo.Tipo_de_Vehiculo Tipo_de_Vehiculo_Tipo_de_Vehiculo { get; set; }
        [ForeignKey("Color")]
        public virtual Spartane.Core.Domain.Color_Vehiculo.Color_Vehiculo Color_Color_Vehiculo { get; set; }

    }
	
	public class Robo_de_Vehiculo_PC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Tipo_de_Solicitud { get; set; }
        public bool? Robo_de_Vehiculo { get; set; }
        public int? Marca { get; set; }
        public int? Sub_Marca { get; set; }
        public int? Tipo_de_Vehiculo { get; set; }
        public int? Modelo { get; set; }
        public int? Color { get; set; }
        public string Placas { get; set; }
        public string Senas_Particulares { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana Solicitud_Solicitud_de_Denuncia_Ciudadana { get; set; }
        [ForeignKey("Tipo_de_Solicitud")]
        public virtual Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud Tipo_de_Solicitud_Tipo_de_Solicitud { get; set; }
        [ForeignKey("Marca")]
        public virtual Spartane.Core.Domain.Marca_del_Vehiculo.Marca_del_Vehiculo Marca_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Sub_Marca")]
        public virtual Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo Sub_Marca_Sub_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Tipo_de_Vehiculo")]
        public virtual Spartane.Core.Domain.Tipo_de_Vehiculo.Tipo_de_Vehiculo Tipo_de_Vehiculo_Tipo_de_Vehiculo { get; set; }
        [ForeignKey("Color")]
        public virtual Spartane.Core.Domain.Color_Vehiculo.Color_Vehiculo Color_Color_Vehiculo { get; set; }

    }


}

