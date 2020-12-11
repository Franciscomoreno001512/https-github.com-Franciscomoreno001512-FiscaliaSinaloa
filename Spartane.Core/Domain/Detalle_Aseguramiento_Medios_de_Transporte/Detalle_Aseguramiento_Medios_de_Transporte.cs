using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Motivo_de_Registro;
using Spartane.Core.Domain.Tipo_de_medios_de_transporte;
using Spartane.Core.Domain.Marca_de_Medio_de_transporte;
using Spartane.Core.Domain.Modelo_de_medio_de_transporte;
using Spartane.Core.Domain.Uso_del_medio_de_transporte;
using Spartane.Core.Domain.Procedencia_del_medio_de_transporte;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Compania_de_Seguros;
using Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte;
using Spartane.Core.Domain.Pension;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte
{
    /// <summary>
    /// Detalle_Aseguramiento_Medios_de_Transporte table
    /// </summary>
    public class Detalle_Aseguramiento_Medios_de_Transporte: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public short? Tipo { get; set; }
        public short? Marca { get; set; }
        public string Submarca { get; set; }
        public short? Modelo { get; set; }
        public string Placas { get; set; }
        public string Color { get; set; }
        public string Numero_de_Motor { get; set; }
        public string Serie { get; set; }
        public short? Uso { get; set; }
        public short? Cap__De_Pasajeros { get; set; }
        public short? Procedencia { get; set; }
        public short? Seguro { get; set; }
        public int? Compania_de_Seguros { get; set; }
        public string Empresa { get; set; }
        public string Capacidad_de_Carga { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int? Ubicacion { get; set; }
        public int? Pension { get; set; }
        public string Domicilio_Resguardo { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Motivo_de_Registro")]
        public virtual Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro Motivo_de_Registro_Motivo_de_Registro { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte Tipo_Tipo_de_medios_de_transporte { get; set; }
        [ForeignKey("Marca")]
        public virtual Spartane.Core.Domain.Marca_de_Medio_de_transporte.Marca_de_Medio_de_transporte Marca_Marca_de_Medio_de_transporte { get; set; }
        [ForeignKey("Modelo")]
        public virtual Spartane.Core.Domain.Modelo_de_medio_de_transporte.Modelo_de_medio_de_transporte Modelo_Modelo_de_medio_de_transporte { get; set; }
        [ForeignKey("Uso")]
        public virtual Spartane.Core.Domain.Uso_del_medio_de_transporte.Uso_del_medio_de_transporte Uso_Uso_del_medio_de_transporte { get; set; }
        [ForeignKey("Procedencia")]
        public virtual Spartane.Core.Domain.Procedencia_del_medio_de_transporte.Procedencia_del_medio_de_transporte Procedencia_Procedencia_del_medio_de_transporte { get; set; }
        [ForeignKey("Seguro")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Seguro_A_Tiempo { get; set; }
        [ForeignKey("Compania_de_Seguros")]
        public virtual Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros Compania_de_Seguros_Compania_de_Seguros { get; set; }
        [ForeignKey("Ubicacion")]
        public virtual Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte Ubicacion_Ubicacion_de_Medio_de_Transporte { get; set; }
        [ForeignKey("Pension")]
        public virtual Spartane.Core.Domain.Pension.Pension Pension_Pension { get; set; }

    }
	
	public class Detalle_Aseguramiento_Medios_de_Transporte_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public short? Tipo { get; set; }
        public short? Marca { get; set; }
        public string Submarca { get; set; }
        public short? Modelo { get; set; }
        public string Placas { get; set; }
        public string Color { get; set; }
        public string Numero_de_Motor { get; set; }
        public string Serie { get; set; }
        public short? Uso { get; set; }
        public short? Cap__De_Pasajeros { get; set; }
        public short? Procedencia { get; set; }
        public short? Seguro { get; set; }
        public int? Compania_de_Seguros { get; set; }
        public string Empresa { get; set; }
        public string Capacidad_de_Carga { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int? Ubicacion { get; set; }
        public int? Pension { get; set; }
        public string Domicilio_Resguardo { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Motivo_de_Registro")]
        public virtual Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro Motivo_de_Registro_Motivo_de_Registro { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte Tipo_Tipo_de_medios_de_transporte { get; set; }
        [ForeignKey("Marca")]
        public virtual Spartane.Core.Domain.Marca_de_Medio_de_transporte.Marca_de_Medio_de_transporte Marca_Marca_de_Medio_de_transporte { get; set; }
        [ForeignKey("Modelo")]
        public virtual Spartane.Core.Domain.Modelo_de_medio_de_transporte.Modelo_de_medio_de_transporte Modelo_Modelo_de_medio_de_transporte { get; set; }
        [ForeignKey("Uso")]
        public virtual Spartane.Core.Domain.Uso_del_medio_de_transporte.Uso_del_medio_de_transporte Uso_Uso_del_medio_de_transporte { get; set; }
        [ForeignKey("Procedencia")]
        public virtual Spartane.Core.Domain.Procedencia_del_medio_de_transporte.Procedencia_del_medio_de_transporte Procedencia_Procedencia_del_medio_de_transporte { get; set; }
        [ForeignKey("Seguro")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Seguro_A_Tiempo { get; set; }
        [ForeignKey("Compania_de_Seguros")]
        public virtual Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros Compania_de_Seguros_Compania_de_Seguros { get; set; }
        [ForeignKey("Ubicacion")]
        public virtual Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte Ubicacion_Ubicacion_de_Medio_de_Transporte { get; set; }
        [ForeignKey("Pension")]
        public virtual Spartane.Core.Domain.Pension.Pension Pension_Pension { get; set; }

    }


}

