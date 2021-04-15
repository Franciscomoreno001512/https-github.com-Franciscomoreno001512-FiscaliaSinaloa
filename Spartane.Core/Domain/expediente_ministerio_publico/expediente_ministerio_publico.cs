using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Tipo_de_Urgencia;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.estatus_mpi;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Tipo_de_Acuerdo;
using Spartane.Core.Domain.Periodicidad;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.tipo_de_cierre;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.expediente_ministerio_publico
{
    /// <summary>
    /// expediente_ministerio_publico table
    /// </summary>
    public class expediente_ministerio_publico: BaseEntity
    {
        public int clave { get; set; }
        public DateTime? fecha_de_registro { get; set; }
        public string hora_de_registro { get; set; }
        public int? usuario_que_registra { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public int? MP_Asignado { get; set; }
        public int? unidad { get; set; }
        public int? Municipio { get; set; }
        public int? Region { get; set; }
        public string nuat { get; set; }
        public string Numero_de_Denuncia { get; set; }
        public string nic { get; set; }
        public short? detenido { get; set; }
        public string hora_del_detenido { get; set; }
        public string hora_puesto_a_disposicion { get; set; }
        public bool? Urgencia { get; set; }
        public int? Tipo_de_urgencia { get; set; }
        public int? Pre_Denuncia { get; set; }
        public short? estatus { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Lugar_de_los_Hechos { get; set; }
        public int? PaisH { get; set; }
        public int? Estado { get; set; }
        public int? Municipio_Hechos { get; set; }
        public int? Poblacion { get; set; }
        public int? ColoniaH { get; set; }
        public string CalleH { get; set; }
        public string Numero_InteriorH { get; set; }
        public string Numero_ExteriorH { get; set; }
        public int? Codigo_PostalH { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string LongitudH { get; set; }
        public string LatitudH { get; set; }
        public int? tipo_de_acuerdo { get; set; }
        public DateTime? fecha_de_inicio_de_acuerdo { get; set; }
        public DateTime? fecha_de_cumplimiento { get; set; }
        public string hora_de_cumplimiento { get; set; }
        public string domicilio_para_el_cumplimiento { get; set; }
        public decimal? monto_de_reparacion_de_danos { get; set; }
        public int? parcialidades { get; set; }
        public int? periodicidad { get; set; }
        public short? acepta_acuerdo { get; set; }
        public string motivo_de_rechazo_de_acuerdo { get; set; }
        public DateTime? fecha_de_cierre { get; set; }
        public string hora_de_cierre { get; set; }
        public int? Usuario_que_Cierra { get; set; }
        public int? tipo_de_cierre { get; set; }
        public string comentarios_de_cierre { get; set; }

        [ForeignKey("usuario_que_registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User usuario_que_registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("MP_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User MP_Asignado_Spartan_User { get; set; }
        [ForeignKey("unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad unidad_Unidad { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("detenido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo detenido_A_Tiempo { get; set; }
        [ForeignKey("Tipo_de_urgencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia Tipo_de_urgencia_Tipo_de_Urgencia { get; set; }
        [ForeignKey("Pre_Denuncia")]
        public virtual Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana Pre_Denuncia_Solicitud_de_Denuncia_Ciudadana { get; set; }
        [ForeignKey("estatus")]
        public virtual Spartane.Core.Domain.estatus_mpi.estatus_mpi estatus_estatus_mpi { get; set; }
        [ForeignKey("Lugar_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Lugar_de_los_Hechos_Lugar_Tipo { get; set; }
        [ForeignKey("PaisH")]
        public virtual Spartane.Core.Domain.Pais.Pais PaisH_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio_Hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Hechos_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("ColoniaH")]
        public virtual Spartane.Core.Domain.Colonia.Colonia ColoniaH_Colonia { get; set; }
        [ForeignKey("tipo_de_acuerdo")]
        public virtual Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo tipo_de_acuerdo_Tipo_de_Acuerdo { get; set; }
        [ForeignKey("periodicidad")]
        public virtual Spartane.Core.Domain.Periodicidad.Periodicidad periodicidad_Periodicidad { get; set; }
        [ForeignKey("acepta_acuerdo")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo acepta_acuerdo_A_Tiempo { get; set; }
        [ForeignKey("Usuario_que_Cierra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Cierra_Spartan_User { get; set; }
        [ForeignKey("tipo_de_cierre")]
        public virtual Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre tipo_de_cierre_tipo_de_cierre { get; set; }

    }
	
	public class expediente_ministerio_publico_Datos_del_Caso
    {
                public int clave { get; set; }
        public DateTime? fecha_de_registro { get; set; }
        public string hora_de_registro { get; set; }
        public int? usuario_que_registra { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public int? MP_Asignado { get; set; }
        public int? unidad { get; set; }
        public int? Municipio { get; set; }
        public int? Region { get; set; }
        public string nuat { get; set; }
        public string Numero_de_Denuncia { get; set; }
        public string nic { get; set; }
        public short? detenido { get; set; }
        public string hora_del_detenido { get; set; }
        public string hora_puesto_a_disposicion { get; set; }
        public bool? Urgencia { get; set; }
        public int? Tipo_de_urgencia { get; set; }
        public int? Pre_Denuncia { get; set; }
        public short? estatus { get; set; }

		        [ForeignKey("usuario_que_registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User usuario_que_registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("MP_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User MP_Asignado_Spartan_User { get; set; }
        [ForeignKey("unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad unidad_Unidad { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("detenido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo detenido_A_Tiempo { get; set; }
        [ForeignKey("Tipo_de_urgencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia Tipo_de_urgencia_Tipo_de_Urgencia { get; set; }
        [ForeignKey("Pre_Denuncia")]
        public virtual Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana Pre_Denuncia_Solicitud_de_Denuncia_Ciudadana { get; set; }
        [ForeignKey("estatus")]
        public virtual Spartane.Core.Domain.estatus_mpi.estatus_mpi estatus_estatus_mpi { get; set; }

    }

	public class expediente_ministerio_publico_Hechos
    {
                public int clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Lugar_de_los_Hechos { get; set; }
        public int? PaisH { get; set; }
        public int? Estado { get; set; }
        public int? Municipio_Hechos { get; set; }
        public int? Poblacion { get; set; }
        public int? ColoniaH { get; set; }
        public string CalleH { get; set; }
        public string Numero_InteriorH { get; set; }
        public string Numero_ExteriorH { get; set; }
        public int? Codigo_PostalH { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string LongitudH { get; set; }
        public string LatitudH { get; set; }

		        [ForeignKey("Lugar_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Lugar_de_los_Hechos_Lugar_Tipo { get; set; }
        [ForeignKey("PaisH")]
        public virtual Spartane.Core.Domain.Pais.Pais PaisH_Pais { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio_Hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Hechos_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("ColoniaH")]
        public virtual Spartane.Core.Domain.Colonia.Colonia ColoniaH_Colonia { get; set; }

    }

	public class expediente_ministerio_publico_Datos_del_Acuerdo
    {
                public int clave { get; set; }
        public int? tipo_de_acuerdo { get; set; }
        public DateTime? fecha_de_inicio_de_acuerdo { get; set; }
        public DateTime? fecha_de_cumplimiento { get; set; }
        public string hora_de_cumplimiento { get; set; }
        public string domicilio_para_el_cumplimiento { get; set; }
        public decimal? monto_de_reparacion_de_danos { get; set; }
        public int? parcialidades { get; set; }
        public int? periodicidad { get; set; }
        public short? acepta_acuerdo { get; set; }
        public string motivo_de_rechazo_de_acuerdo { get; set; }

		        [ForeignKey("tipo_de_acuerdo")]
        public virtual Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo tipo_de_acuerdo_Tipo_de_Acuerdo { get; set; }
        [ForeignKey("periodicidad")]
        public virtual Spartane.Core.Domain.Periodicidad.Periodicidad periodicidad_Periodicidad { get; set; }
        [ForeignKey("acepta_acuerdo")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo acepta_acuerdo_A_Tiempo { get; set; }

    }

	public class expediente_ministerio_publico_Resolucion_o_Dictaminacion
    {
                public int clave { get; set; }
        public DateTime? fecha_de_cierre { get; set; }
        public string hora_de_cierre { get; set; }
        public int? Usuario_que_Cierra { get; set; }
        public int? tipo_de_cierre { get; set; }
        public string comentarios_de_cierre { get; set; }

		        [ForeignKey("Usuario_que_Cierra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Cierra_Spartan_User { get; set; }
        [ForeignKey("tipo_de_cierre")]
        public virtual Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre tipo_de_cierre_tipo_de_cierre { get; set; }

    }


}

