using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Tipo_de_Victima;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Involucrados_PC
{
    /// <summary>
    /// Involucrados_PC table
    /// </summary>
    public class Involucrados_PC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public bool? Desea_indicar_datos_adicionales { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public int? Tipo_de_Victima { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Fotografia_de_la_identificacion { get; set; }
        public string Fotografia_de_la_identificacion_URL { get; set; }
        public string CURP { get; set; }
        public int? Nacionalidad { get; set; }
        public string Originario_de { get; set; }
        public bool? Existieron_testigos { get; set; }
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
        public string Referencia_de_Domicilio { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana Solicitud_Solicitud_de_Denuncia_Ciudadana { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Tipo_de_Victima")]
        public virtual Spartane.Core.Domain.Tipo_de_Victima.Tipo_de_Victima Tipo_de_Victima_Tipo_de_Victima { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Estado_Civil")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Fotografia_de_la_identificacion")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Fotografia_de_la_identificacion_Spartane_File { get; set; }
        [ForeignKey("Nacionalidad")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Nacionalidad { get; set; }
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

    }
	
	public class Involucrados_PC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public bool? Desea_indicar_datos_adicionales { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public int? Tipo_de_Victima { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Fotografia_de_la_identificacion { get; set; }
        public string Fotografia_de_la_identificacion_URL { get; set; }
        public string CURP { get; set; }
        public int? Nacionalidad { get; set; }
        public string Originario_de { get; set; }
        public bool? Existieron_testigos { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana Solicitud_Solicitud_de_Denuncia_Ciudadana { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Tipo_de_Victima")]
        public virtual Spartane.Core.Domain.Tipo_de_Victima.Tipo_de_Victima Tipo_de_Victima_Tipo_de_Victima { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Estado_Civil")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Fotografia_de_la_identificacion")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Fotografia_de_la_identificacion_Spartane_File { get; set; }
        [ForeignKey("Nacionalidad")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Nacionalidad { get; set; }

    }

	public class Involucrados_PC_Domicilio
    {
                public int Clave { get; set; }
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
        public string Referencia_de_Domicilio { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }

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

    }


}

