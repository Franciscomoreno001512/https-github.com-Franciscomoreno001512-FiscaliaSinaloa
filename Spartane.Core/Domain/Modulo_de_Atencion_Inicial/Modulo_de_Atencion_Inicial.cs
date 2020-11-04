using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Estatus;
using Spartane.Core.Domain.Asignacion_de_Turnos;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Modulo_de_Atencion_Inicial
{
    /// <summary>
    /// Modulo_de_Atencion_Inicial table
    /// </summary>
    public class Modulo_de_Atencion_Inicial: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string NUAT { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public string Calle { get; set; }
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Zona { get; set; }
        public int? Municipio { get; set; }
        public int? Estado { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool? Menor_de_Edad { get; set; }
        public bool? Representante_Legal { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public DateTime? Fecha_de_Nacimiento_del_Tutor { get; set; }
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public int? Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public int? Localidad_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public string Nombre_del_Representante { get; set; }
        public string Apellido_Paterno_del_Representante { get; set; }
        public string Apellido_Materno_del_Representante { get; set; }
        public string Calidad_Juridica { get; set; }
        public string Calle_del_Representante { get; set; }
        public int? Numero_Exterior_del_Representante { get; set; }
        public string Numero_Interior_del_Representante { get; set; }
        public int? Colonia_del_Representante { get; set; }
        public int? Localidad_del_Representante { get; set; }
        public int? Municipio_del_Representante { get; set; }
        public int? Estado_del_Representante { get; set; }
        public string Telefono_del_Representante { get; set; }
        public string Celular_del_Representante { get; set; }
        public string Correo_Electronico_del_Representante { get; set; }
        public string Narrativa { get; set; }
        public bool? Atencion_Medica { get; set; }
        public bool? Atencion_Psicologica { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public int? Estatus { get; set; }
        public int? Turno_Asignado { get; set; }
        public int? Unidad { get; set; }
        public int? Municipio_Caso { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia_Hechos_MPO { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Estado_Civil")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_Escolaridad { get; set; }
        [ForeignKey("Ocupacion")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_Ocupacion { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Zona")]
        public virtual Spartane.Core.Domain.Zona.Zona Zona_Zona { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Sexo_del_Tutor")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_del_Tutor_Genero { get; set; }
        [ForeignKey("Estado_Civil_del_Tutor")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_del_Tutor_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion_del_Tutor")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_del_Tutor")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_del_Tutor_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad_del_Tutor")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_del_Tutor_Escolaridad { get; set; }
        [ForeignKey("Ocupacion_del_Tutor")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_del_Tutor_Ocupacion { get; set; }
        [ForeignKey("Colonia_del_Tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Tutor_Colonia { get; set; }
        [ForeignKey("Localidad_del_Tutor")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_del_Tutor_Localidad { get; set; }
        [ForeignKey("Municipio_del_Tutor")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Tutor_Municipio { get; set; }
        [ForeignKey("Estado_del_Tutor")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Tutor_Estado { get; set; }
        [ForeignKey("Colonia_del_Representante")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Representante_Colonia { get; set; }
        [ForeignKey("Localidad_del_Representante")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_del_Representante_Localidad { get; set; }
        [ForeignKey("Municipio_del_Representante")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Representante_Municipio { get; set; }
        [ForeignKey("Estado_del_Representante")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Representante_Estado { get; set; }
        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus.Estatus Estatus_Estatus { get; set; }
        [ForeignKey("Turno_Asignado")]
        public virtual Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos Turno_Asignado_Asignacion_de_Turnos { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Municipio_Caso")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Caso_Municipio { get; set; }
        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia_Hechos_MPO")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Hechos_MPO_Colonia { get; set; }

    }
	
	public class Modulo_de_Atencion_Inicial_Datos_del_Caso
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string NUAT { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Estatus { get; set; }
        public int? Turno_Asignado { get; set; }
        public int? Unidad { get; set; }
        public int? Municipio_Caso { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public int? Numero_de_Expediente { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus.Estatus Estatus_Estatus { get; set; }
        [ForeignKey("Turno_Asignado")]
        public virtual Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos Turno_Asignado_Asignacion_de_Turnos { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Municipio_Caso")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Caso_Municipio { get; set; }
        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_Generales
    {
                public int Folio { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public DateTime? Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public string Calle { get; set; }
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Zona { get; set; }
        public int? Municipio { get; set; }
        public int? Estado { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool? Menor_de_Edad { get; set; }
        public bool? Representante_Legal { get; set; }

		        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Estado_Civil")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_Escolaridad { get; set; }
        [ForeignKey("Ocupacion")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_Ocupacion { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }
        [ForeignKey("Zona")]
        public virtual Spartane.Core.Domain.Zona.Zona Zona_Zona { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_del_Tutor
    {
                public int Folio { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public DateTime? Fecha_de_Nacimiento_del_Tutor { get; set; }
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public int? Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public int? Localidad_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }

		        [ForeignKey("Sexo_del_Tutor")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_del_Tutor_Genero { get; set; }
        [ForeignKey("Estado_Civil_del_Tutor")]
        public virtual Spartane.Core.Domain.Estado_Civil.Estado_Civil Estado_Civil_del_Tutor_Estado_Civil { get; set; }
        [ForeignKey("Tipo_de_Identificacion_del_Tutor")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_del_Tutor")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_del_Tutor_Nacionalidad { get; set; }
        [ForeignKey("Escolaridad_del_Tutor")]
        public virtual Spartane.Core.Domain.Escolaridad.Escolaridad Escolaridad_del_Tutor_Escolaridad { get; set; }
        [ForeignKey("Ocupacion_del_Tutor")]
        public virtual Spartane.Core.Domain.Ocupacion.Ocupacion Ocupacion_del_Tutor_Ocupacion { get; set; }
        [ForeignKey("Colonia_del_Tutor")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Tutor_Colonia { get; set; }
        [ForeignKey("Localidad_del_Tutor")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_del_Tutor_Localidad { get; set; }
        [ForeignKey("Municipio_del_Tutor")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Tutor_Municipio { get; set; }
        [ForeignKey("Estado_del_Tutor")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Tutor_Estado { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_del_Representante_Legal
    {
                public int Folio { get; set; }
        public string Nombre_del_Representante { get; set; }
        public string Apellido_Paterno_del_Representante { get; set; }
        public string Apellido_Materno_del_Representante { get; set; }
        public string Calidad_Juridica { get; set; }
        public string Calle_del_Representante { get; set; }
        public int? Numero_Exterior_del_Representante { get; set; }
        public string Numero_Interior_del_Representante { get; set; }
        public int? Colonia_del_Representante { get; set; }
        public int? Localidad_del_Representante { get; set; }
        public int? Municipio_del_Representante { get; set; }
        public int? Estado_del_Representante { get; set; }
        public string Telefono_del_Representante { get; set; }
        public string Celular_del_Representante { get; set; }
        public string Correo_Electronico_del_Representante { get; set; }

		        [ForeignKey("Colonia_del_Representante")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Representante_Colonia { get; set; }
        [ForeignKey("Localidad_del_Representante")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_del_Representante_Localidad { get; set; }
        [ForeignKey("Municipio_del_Representante")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Representante_Municipio { get; set; }
        [ForeignKey("Estado_del_Representante")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Representante_Estado { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_de_los_Hechos
    {
                public int Folio { get; set; }
        public string Narrativa { get; set; }

		
    }

	public class Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_Apoyo
    {
                public int Folio { get; set; }
        public bool? Atencion_Medica { get; set; }
        public bool? Atencion_Psicologica { get; set; }

		
    }

	public class Modulo_de_Atencion_Inicial_Servicios_de_Apoyo
    {
                public int Folio { get; set; }
        public bool? Requiere_Traductor { get; set; }

		
    }

	public class Modulo_de_Atencion_Inicial_Tipo_de_Compareciente
    {
                public int Folio { get; set; }
        public int? Tipo_de_Compareciente { get; set; }

		        [ForeignKey("Tipo_de_Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Tipo_de_Compareciente_Tipo_de_Compareciente { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPO
    {
                public int Folio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia_Hechos_MPO { get; set; }

		        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia_Hechos_MPO")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Hechos_MPO_Colonia { get; set; }

    }


}

