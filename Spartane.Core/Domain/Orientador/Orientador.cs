using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Idioma;
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
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Circunstancia_del_Delito;
using Spartane.Core.Domain.Tipo_Delito;
using Spartane.Core.Domain.Forma_Comision_Delito;
using Spartane.Core.Domain.Forma_Accion_Delito;
using Spartane.Core.Domain.Modalidad_Delito;
using Spartane.Core.Domain.Elementos_Comision_Delito;
using Spartane.Core.Domain.Circunstancia_Vehiculo;
using Spartane.Core.Domain.Especifica_Vehiculo;
using Spartane.Core.Domain.Marca_del_Vehiculo;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Vehiculo;
using Spartane.Core.Domain.Color_Vehiculo;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Aseguradora_de_Vehiculo;
using Spartane.Core.Domain.Servicio_del_Vehiculo;
using Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Core.Domain.Circunstancia_Defuncion;
using Spartane.Core.Domain.Consecuencia_Defuncion;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Procedencia_del_Vehiculo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Orientador
{
    /// <summary>
    /// Orientador table
    /// </summary>
    public class Orientador: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public bool? Atencion_Medica { get; set; }
        public bool? Atencion_Psicologica { get; set; }
        public bool? Traductor { get; set; }
        public string Narrativa_DM { get; set; }
        public string Narrativa_DP { get; set; }
        public int? Idioma { get; set; }
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
        public int? Localidad { get; set; }
        public int? Municipio { get; set; }
        public int? Estado { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Calle2 { get; set; }
        public int? Numero_Exterior2 { get; set; }
        public string Numero_Interior2 { get; set; }
        public int? Colonia2 { get; set; }
        public int? Codigo_Postal2 { get; set; }
        public int? Zona { get; set; }
        public int? Municipio2 { get; set; }
        public int? Estado2 { get; set; }
        public int? Grupo_Delito { get; set; }
        public int? Delito { get; set; }
        public int? Circunstancia { get; set; }
        public int? Tipo_Delito { get; set; }
        public int? Forma_Comision_Delito { get; set; }
        public short? Forma_Accion_Delito { get; set; }
        public short? Modalidad_Delito { get; set; }
        public int? Elementos_Comision_Delito { get; set; }
        public decimal? Monto { get; set; }
        public bool? HViolencia_de_Genero { get; set; }
        public string Calificacion_del_Delito { get; set; }
        public short? CircunstanciaV { get; set; }
        public short? Clase_Especifica { get; set; }
        public int? Marca { get; set; }
        public int? Sub_Marca { get; set; }
        public int? Tipo_de_Vehiculo { get; set; }
        public string Modelo { get; set; }
        public int? Color { get; set; }
        public string Placas { get; set; }
        public int? Estado_Placas { get; set; }
        public bool? Vehiculo_Robado { get; set; }
        public bool? Seguro { get; set; }
        public int? Aseguradora { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Ruta_del_Servicio_Publico { get; set; }
        public bool? Mercancia { get; set; }
        public string Descripcion { get; set; }
        public decimal? Monto_de_la_Carga { get; set; }
        public string Senas_Particulares { get; set; }
        public short? Modalidad_del_Robo { get; set; }
        public short? Circunstancia_Defuncion { get; set; }
        public short? Consecuencia_Defuncion { get; set; }
        public DateTime? Fecha_Levantamiento { get; set; }
        public string Hora_Levantamiento { get; set; }
        public string Domicilio { get; set; }
        public string Numero_Interior3 { get; set; }
        public int? Numero_Exterior3 { get; set; }
        public int? Colonia3 { get; set; }
        public string Colonia_no_Catalogada { get; set; }
        public int? Zona2 { get; set; }
        public int? Municipio3 { get; set; }
        public int? Estado3 { get; set; }
        public string Necropsia { get; set; }
        public string Cronotanatodiagnostico { get; set; }
        public string Ruta { get; set; }
        public bool? Estado_Operador { get; set; }
        public bool? Delito_Principal_o_Secundario { get; set; }
        public string Concurso { get; set; }
        public int? Compareciente { get; set; }
        public string NombreC { get; set; }
        public string Apellido_PaternoC { get; set; }
        public string Apellido_MaternoC { get; set; }
        public string NombreT { get; set; }
        public string Apellido_PaternoT { get; set; }
        public string Apellido_MaternoT { get; set; }
        public string CalleC { get; set; }
        public int? Numero_ExteriorC { get; set; }
        public string Numero_InteriorC { get; set; }
        public int? ColoniaC { get; set; }
        public int? Codigo_PostalC { get; set; }
        public int? ZonaC { get; set; }
        public int? MunicipioC { get; set; }
        public int? EstadoC { get; set; }
        public string NarrativaC { get; set; }
        public bool? Conocido { get; set; }
        public bool? Desconocido { get; set; }
        public int? Numero_de_Imputados { get; set; }
        public short? Procedencia { get; set; }
        public string Motor { get; set; }
        public string Serie { get; set; }
        public string Causa_de_Muerte { get; set; }
        public string Entre_Calle { get; set; }
        public string Entre_Calle2 { get; set; }
        public bool? Autoriza { get; set; }
        public bool? Autoriza2 { get; set; }
        public bool? Autoriza3 { get; set; }
        public bool? Menor_de_Edad { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
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
        [ForeignKey("Localidad")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_Localidad { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_Lugar_Tipo { get; set; }
        [ForeignKey("Colonia2")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia2_Colonia { get; set; }
        [ForeignKey("Zona")]
        public virtual Spartane.Core.Domain.Zona.Zona Zona_Zona { get; set; }
        [ForeignKey("Municipio2")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio2_Municipio { get; set; }
        [ForeignKey("Estado2")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado2_Estado { get; set; }
        [ForeignKey("Grupo_Delito")]
        public virtual Spartane.Core.Domain.Grupo_del_Delito.Grupo_del_Delito Grupo_Delito_Grupo_del_Delito { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Circunstancia")]
        public virtual Spartane.Core.Domain.Circunstancia_del_Delito.Circunstancia_del_Delito Circunstancia_Circunstancia_del_Delito { get; set; }
        [ForeignKey("Tipo_Delito")]
        public virtual Spartane.Core.Domain.Tipo_Delito.Tipo_Delito Tipo_Delito_Tipo_Delito { get; set; }
        [ForeignKey("Forma_Comision_Delito")]
        public virtual Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito Forma_Comision_Delito_Forma_Comision_Delito { get; set; }
        [ForeignKey("Forma_Accion_Delito")]
        public virtual Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito Forma_Accion_Delito_Forma_Accion_Delito { get; set; }
        [ForeignKey("Modalidad_Delito")]
        public virtual Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito Modalidad_Delito_Modalidad_Delito { get; set; }
        [ForeignKey("Elementos_Comision_Delito")]
        public virtual Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito Elementos_Comision_Delito_Elementos_Comision_Delito { get; set; }
        [ForeignKey("CircunstanciaV")]
        public virtual Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo CircunstanciaV_Circunstancia_Vehiculo { get; set; }
        [ForeignKey("Clase_Especifica")]
        public virtual Spartane.Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo Clase_Especifica_Especifica_Vehiculo { get; set; }
        [ForeignKey("Marca")]
        public virtual Spartane.Core.Domain.Marca_del_Vehiculo.Marca_del_Vehiculo Marca_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Sub_Marca")]
        public virtual Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo Sub_Marca_Sub_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Tipo_de_Vehiculo")]
        public virtual Spartane.Core.Domain.Tipo_de_Vehiculo.Tipo_de_Vehiculo Tipo_de_Vehiculo_Tipo_de_Vehiculo { get; set; }
        [ForeignKey("Color")]
        public virtual Spartane.Core.Domain.Color_Vehiculo.Color_Vehiculo Color_Color_Vehiculo { get; set; }
        [ForeignKey("Estado_Placas")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Placas_Estado { get; set; }
        [ForeignKey("Aseguradora")]
        public virtual Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo Aseguradora_Aseguradora_de_Vehiculo { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo Tipo_de_Servicio_Servicio_del_Vehiculo { get; set; }
        [ForeignKey("Modalidad_del_Robo")]
        public virtual Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo { get; set; }
        [ForeignKey("Circunstancia_Defuncion")]
        public virtual Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion Circunstancia_Defuncion_Circunstancia_Defuncion { get; set; }
        [ForeignKey("Consecuencia_Defuncion")]
        public virtual Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion Consecuencia_Defuncion_Consecuencia_Defuncion { get; set; }
        [ForeignKey("Colonia3")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia3_Colonia { get; set; }
        [ForeignKey("Zona2")]
        public virtual Spartane.Core.Domain.Zona.Zona Zona2_Zona { get; set; }
        [ForeignKey("Municipio3")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio3_Municipio { get; set; }
        [ForeignKey("Estado3")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado3_Estado { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("ColoniaC")]
        public virtual Spartane.Core.Domain.Colonia.Colonia ColoniaC_Colonia { get; set; }
        [ForeignKey("ZonaC")]
        public virtual Spartane.Core.Domain.Zona.Zona ZonaC_Zona { get; set; }
        [ForeignKey("MunicipioC")]
        public virtual Spartane.Core.Domain.Municipio.Municipio MunicipioC_Municipio { get; set; }
        [ForeignKey("EstadoC")]
        public virtual Spartane.Core.Domain.Estado.Estado EstadoC_Estado { get; set; }
        [ForeignKey("Procedencia")]
        public virtual Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo Procedencia_Procedencia_del_Vehiculo { get; set; }

    }
	
	public class Orientador_Datos_de_Servicios_de_Apoyo
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public bool? Atencion_Medica { get; set; }
        public bool? Atencion_Psicologica { get; set; }
        public bool? Traductor { get; set; }
        public string Narrativa_DM { get; set; }
        public string Narrativa_DP { get; set; }
        public int? Idioma { get; set; }
        public int? Compareciente { get; set; }
        public string NombreC { get; set; }
        public string Apellido_PaternoC { get; set; }
        public string Apellido_MaternoC { get; set; }
        public string NombreT { get; set; }
        public string Apellido_PaternoT { get; set; }
        public string Apellido_MaternoT { get; set; }
        public string CalleC { get; set; }
        public int? Numero_ExteriorC { get; set; }
        public string Numero_InteriorC { get; set; }
        public int? ColoniaC { get; set; }
        public int? Codigo_PostalC { get; set; }
        public int? ZonaC { get; set; }
        public int? MunicipioC { get; set; }
        public int? EstadoC { get; set; }
        public string NarrativaC { get; set; }
        public bool? Autoriza { get; set; }
        public bool? Autoriza2 { get; set; }
        public bool? Autoriza3 { get; set; }
        public bool? Menor_de_Edad { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente Compareciente_Tipo_de_Compareciente { get; set; }
        [ForeignKey("ColoniaC")]
        public virtual Spartane.Core.Domain.Colonia.Colonia ColoniaC_Colonia { get; set; }
        [ForeignKey("ZonaC")]
        public virtual Spartane.Core.Domain.Zona.Zona ZonaC_Zona { get; set; }
        [ForeignKey("MunicipioC")]
        public virtual Spartane.Core.Domain.Municipio.Municipio MunicipioC_Municipio { get; set; }
        [ForeignKey("EstadoC")]
        public virtual Spartane.Core.Domain.Estado.Estado EstadoC_Estado { get; set; }

    }

	public class Orientador_Datos_del_Imputado
    {
                public int Clave { get; set; }
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
        public int? Localidad { get; set; }
        public int? Municipio { get; set; }
        public int? Estado { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }

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
        [ForeignKey("Localidad")]
        public virtual Spartane.Core.Domain.Localidad.Localidad Localidad_Localidad { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Estado")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Estado { get; set; }

    }

	public class Orientador_Datos_de_los_Hechos
    {
                public int Clave { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Calle2 { get; set; }
        public int? Numero_Exterior2 { get; set; }
        public string Numero_Interior2 { get; set; }
        public int? Colonia2 { get; set; }
        public int? Codigo_Postal2 { get; set; }
        public int? Zona { get; set; }
        public int? Municipio2 { get; set; }
        public int? Estado2 { get; set; }
        public string Entre_Calle { get; set; }
        public string Entre_Calle2 { get; set; }

		        [ForeignKey("Tipo_de_Lugar_del_Hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_Lugar_Tipo { get; set; }
        [ForeignKey("Colonia2")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia2_Colonia { get; set; }
        [ForeignKey("Zona")]
        public virtual Spartane.Core.Domain.Zona.Zona Zona_Zona { get; set; }
        [ForeignKey("Municipio2")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio2_Municipio { get; set; }
        [ForeignKey("Estado2")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado2_Estado { get; set; }

    }

	public class Orientador_Datos_del_Delito
    {
                public int Clave { get; set; }
        public int? Grupo_Delito { get; set; }
        public int? Delito { get; set; }
        public int? Circunstancia { get; set; }
        public int? Tipo_Delito { get; set; }
        public int? Forma_Comision_Delito { get; set; }
        public short? Forma_Accion_Delito { get; set; }
        public short? Modalidad_Delito { get; set; }
        public int? Elementos_Comision_Delito { get; set; }
        public decimal? Monto { get; set; }
        public bool? HViolencia_de_Genero { get; set; }
        public string Calificacion_del_Delito { get; set; }
        public bool? Delito_Principal_o_Secundario { get; set; }
        public string Concurso { get; set; }

		        [ForeignKey("Grupo_Delito")]
        public virtual Spartane.Core.Domain.Grupo_del_Delito.Grupo_del_Delito Grupo_Delito_Grupo_del_Delito { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Circunstancia")]
        public virtual Spartane.Core.Domain.Circunstancia_del_Delito.Circunstancia_del_Delito Circunstancia_Circunstancia_del_Delito { get; set; }
        [ForeignKey("Tipo_Delito")]
        public virtual Spartane.Core.Domain.Tipo_Delito.Tipo_Delito Tipo_Delito_Tipo_Delito { get; set; }
        [ForeignKey("Forma_Comision_Delito")]
        public virtual Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito Forma_Comision_Delito_Forma_Comision_Delito { get; set; }
        [ForeignKey("Forma_Accion_Delito")]
        public virtual Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito Forma_Accion_Delito_Forma_Accion_Delito { get; set; }
        [ForeignKey("Modalidad_Delito")]
        public virtual Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito Modalidad_Delito_Modalidad_Delito { get; set; }
        [ForeignKey("Elementos_Comision_Delito")]
        public virtual Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito Elementos_Comision_Delito_Elementos_Comision_Delito { get; set; }

    }

	public class Orientador_Datos_de_Robo_de_Vehiculo
    {
                public int Clave { get; set; }
        public short? CircunstanciaV { get; set; }
        public short? Clase_Especifica { get; set; }
        public int? Marca { get; set; }
        public int? Sub_Marca { get; set; }
        public int? Tipo_de_Vehiculo { get; set; }
        public string Modelo { get; set; }
        public int? Color { get; set; }
        public string Placas { get; set; }
        public int? Estado_Placas { get; set; }
        public bool? Vehiculo_Robado { get; set; }
        public bool? Seguro { get; set; }
        public int? Aseguradora { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Ruta_del_Servicio_Publico { get; set; }
        public bool? Mercancia { get; set; }
        public string Descripcion { get; set; }
        public decimal? Monto_de_la_Carga { get; set; }
        public string Senas_Particulares { get; set; }
        public short? Modalidad_del_Robo { get; set; }
        public short? Procedencia { get; set; }
        public string Motor { get; set; }
        public string Serie { get; set; }

		        [ForeignKey("CircunstanciaV")]
        public virtual Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo CircunstanciaV_Circunstancia_Vehiculo { get; set; }
        [ForeignKey("Clase_Especifica")]
        public virtual Spartane.Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo Clase_Especifica_Especifica_Vehiculo { get; set; }
        [ForeignKey("Marca")]
        public virtual Spartane.Core.Domain.Marca_del_Vehiculo.Marca_del_Vehiculo Marca_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Sub_Marca")]
        public virtual Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo Sub_Marca_Sub_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Tipo_de_Vehiculo")]
        public virtual Spartane.Core.Domain.Tipo_de_Vehiculo.Tipo_de_Vehiculo Tipo_de_Vehiculo_Tipo_de_Vehiculo { get; set; }
        [ForeignKey("Color")]
        public virtual Spartane.Core.Domain.Color_Vehiculo.Color_Vehiculo Color_Color_Vehiculo { get; set; }
        [ForeignKey("Estado_Placas")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_Placas_Estado { get; set; }
        [ForeignKey("Aseguradora")]
        public virtual Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo Aseguradora_Aseguradora_de_Vehiculo { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo Tipo_de_Servicio_Servicio_del_Vehiculo { get; set; }
        [ForeignKey("Modalidad_del_Robo")]
        public virtual Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo { get; set; }
        [ForeignKey("Procedencia")]
        public virtual Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo Procedencia_Procedencia_del_Vehiculo { get; set; }

    }

	public class Orientador_Datos_de_Levantamiento_de_Cadaver
    {
                public int Clave { get; set; }
        public short? Circunstancia_Defuncion { get; set; }
        public short? Consecuencia_Defuncion { get; set; }
        public DateTime? Fecha_Levantamiento { get; set; }
        public string Hora_Levantamiento { get; set; }
        public string Domicilio { get; set; }
        public string Numero_Interior3 { get; set; }
        public int? Numero_Exterior3 { get; set; }
        public int? Colonia3 { get; set; }
        public string Colonia_no_Catalogada { get; set; }
        public int? Zona2 { get; set; }
        public int? Municipio3 { get; set; }
        public int? Estado3 { get; set; }
        public string Necropsia { get; set; }
        public string Cronotanatodiagnostico { get; set; }
        public string Ruta { get; set; }
        public bool? Estado_Operador { get; set; }
        public string Causa_de_Muerte { get; set; }

		        [ForeignKey("Circunstancia_Defuncion")]
        public virtual Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion Circunstancia_Defuncion_Circunstancia_Defuncion { get; set; }
        [ForeignKey("Consecuencia_Defuncion")]
        public virtual Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion Consecuencia_Defuncion_Consecuencia_Defuncion { get; set; }
        [ForeignKey("Colonia3")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia3_Colonia { get; set; }
        [ForeignKey("Zona2")]
        public virtual Spartane.Core.Domain.Zona.Zona Zona2_Zona { get; set; }
        [ForeignKey("Municipio3")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio3_Municipio { get; set; }
        [ForeignKey("Estado3")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado3_Estado { get; set; }

    }

	public class Orientador_Imputado
    {
                public int Clave { get; set; }
        public bool? Conocido { get; set; }
        public bool? Desconocido { get; set; }
        public int? Numero_de_Imputados { get; set; }

		
    }


}

