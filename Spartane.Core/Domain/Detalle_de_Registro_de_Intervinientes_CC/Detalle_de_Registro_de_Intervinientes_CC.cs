using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Registro_de_Intervinientes_CC
{
    /// <summary>
    /// Detalle_de_Registro_de_Intervinientes_CC table
    /// </summary>
    public class Detalle_de_Registro_de_Intervinientes_CC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Cadena_de_Custodia { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public bool? Anonimo { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Nacionalidad { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais { get; set; }
        public string Entre_calle { get; set; }
        public string Especifique { get; set; }
        public short? Extension { get; set; }
        public bool? Inimputable { get; set; }
        public string Nombre_Completo { get; set; }
        public string Originario_de { get; set; }
        public int? Pais_de_Origen { get; set; }
        public bool? Proteccion_de_Datos { get; set; }
        public string Referencia_de_Domicilio { get; set; }
        public string Y_calle { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public int? Tipo_de_inimputabilidad { get; set; }
        public string Nombre { get; set; }

        [ForeignKey("Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_de_Custodia_Cadena_de_Custodia { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Estado_Civil")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Escolaridad")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_Escolaridad { get; set; }
        [ForeignKey("Ocupacion")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_Ocupacion { get; set; }
        [ForeignKey("Nacionalidad")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Nacionalidad { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Pais_de_Origen")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Origen_Pais { get; set; }
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Tipo_de_inimputabilidad")]
        public virtual Spartane.Core.Domain.Tipo_de_Inimputabilidad.Tipo_de_Inimputabilidad Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad { get; set; }

    }
	
	public class Detalle_de_Registro_de_Intervinientes_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Cadena_de_Custodia { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public bool? Anonimo { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Nacionalidad { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais { get; set; }
        public string Entre_calle { get; set; }
        public string Especifique { get; set; }
        public short? Extension { get; set; }
        public bool? Inimputable { get; set; }
        public string Nombre_Completo { get; set; }
        public string Originario_de { get; set; }
        public int? Pais_de_Origen { get; set; }
        public bool? Proteccion_de_Datos { get; set; }
        public string Referencia_de_Domicilio { get; set; }
        public string Y_calle { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public int? Tipo_de_inimputabilidad { get; set; }
        public string Nombre { get; set; }

		        [ForeignKey("Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_de_Custodia_Cadena_de_Custodia { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Estado_Civil")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Escolaridad")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_Escolaridad { get; set; }
        [ForeignKey("Ocupacion")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_Ocupacion { get; set; }
        [ForeignKey("Nacionalidad")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Nacionalidad { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Pais")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_Pais { get; set; }
        [ForeignKey("Pais_de_Origen")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_Origen_Pais { get; set; }
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Tipo_de_inimputabilidad")]
        public virtual Spartane.Core.Domain.Tipo_de_Inimputabilidad.Tipo_de_Inimputabilidad Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad { get; set; }

    }

	public class Detalle_de_Registro_de_Intervinientes_CC_Galeria
    {
                public int Clave { get; set; }

		
    }


}

