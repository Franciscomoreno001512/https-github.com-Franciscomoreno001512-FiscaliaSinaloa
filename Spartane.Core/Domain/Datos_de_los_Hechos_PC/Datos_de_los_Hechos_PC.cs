using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Respuesta;
using Spartane.Core.Domain.Respuesta;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Direccion_Exacta;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Datos_de_los_Hechos_PC
{
    /// <summary>
    /// Datos_de_los_Hechos_PC table
    /// </summary>
    public class Datos_de_los_Hechos_PC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tiene_alguna_Foto_o_Evidencia { get; set; }
        public string Tiene_alguna_Foto_o_Evidencia_URL { get; set; }
        public short? Fosa_clandestina { get; set; }
        public short? Conoce_la_direccion { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Es_una_direccion_exacta_o_aproximada { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana Solicitud_Solicitud_de_Denuncia_Ciudadana { get; set; }
        [ForeignKey("Tiene_alguna_Foto_o_Evidencia")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Tiene_alguna_Foto_o_Evidencia_Spartane_File { get; set; }
        [ForeignKey("Fosa_clandestina")]
        public virtual Spartane.Core.Domain.Respuesta.Respuesta Fosa_clandestina_Respuesta { get; set; }
        [ForeignKey("Conoce_la_direccion")]
        public virtual Spartane.Core.Domain.Respuesta.Respuesta Conoce_la_direccion_Respuesta { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Es_una_direccion_exacta_o_aproximada")]
        public virtual Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta Es_una_direccion_exacta_o_aproximada_Direccion_Exacta { get; set; }

    }
	
	public class Datos_de_los_Hechos_PC_Datos_de_los_hechos
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tiene_alguna_Foto_o_Evidencia { get; set; }
        public string Tiene_alguna_Foto_o_Evidencia_URL { get; set; }
        public short? Fosa_clandestina { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana Solicitud_Solicitud_de_Denuncia_Ciudadana { get; set; }
        [ForeignKey("Tiene_alguna_Foto_o_Evidencia")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Tiene_alguna_Foto_o_Evidencia_Spartane_File { get; set; }
        [ForeignKey("Fosa_clandestina")]
        public virtual Spartane.Core.Domain.Respuesta.Respuesta Fosa_clandestina_Respuesta { get; set; }

    }

	public class Datos_de_los_Hechos_PC_Lugar_de_los_Hechos
    {
                public int Clave { get; set; }
        public short? Conoce_la_direccion { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Es_una_direccion_exacta_o_aproximada { get; set; }

		        [ForeignKey("Conoce_la_direccion")]
        public virtual Spartane.Core.Domain.Respuesta.Respuesta Conoce_la_direccion_Respuesta { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Es_una_direccion_exacta_o_aproximada")]
        public virtual Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta Es_una_direccion_exacta_o_aproximada_Direccion_Exacta { get; set; }

    }


}

