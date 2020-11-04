using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class OrientadorModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public bool Atencion_Medica { get; set; }
        public bool Atencion_Psicologica { get; set; }
        public bool Traductor { get; set; }
        public string Narrativa_DM { get; set; }
        public string Narrativa_DP { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        [Range(0, 9999999999)]
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public string SexoDescripcion { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estado_CivilDescripcion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public short? Escolaridad { get; set; }
        public string EscolaridadDescripcion { get; set; }
        public int? Ocupacion { get; set; }
        public string OcupacionDescripcion { get; set; }
        public string Calle { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public int? Localidad { get; set; }
        public string LocalidadDescripcion { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Tipo_de_Lugar_del_HechoDescripcion { get; set; }
        public string Calle2 { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior2 { get; set; }
        public string Numero_Interior2 { get; set; }
        public int? Colonia2 { get; set; }
        public string Colonia2Nombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal2 { get; set; }
        public int? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        public int? Municipio2 { get; set; }
        public string Municipio2Nombre { get; set; }
        public int? Estado2 { get; set; }
        public string Estado2Nombre { get; set; }
        public int? Grupo_Delito { get; set; }
        public string Grupo_DelitoDescripcion { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Circunstancia { get; set; }
        public string CircunstanciaDescripcion { get; set; }
        public int? Tipo_Delito { get; set; }
        public string Tipo_DelitoDescripcion { get; set; }
        public int? Forma_Comision_Delito { get; set; }
        public string Forma_Comision_DelitoDescripcion { get; set; }
        public short? Forma_Accion_Delito { get; set; }
        public string Forma_Accion_DelitoDescripcion { get; set; }
        public short? Modalidad_Delito { get; set; }
        public string Modalidad_DelitoDescripcion { get; set; }
        public int? Elementos_Comision_Delito { get; set; }
        public string Elementos_Comision_DelitoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto { get; set; }
        public bool HViolencia_de_Genero { get; set; }
        public string Calificacion_del_Delito { get; set; }
        public short? CircunstanciaV { get; set; }
        public string CircunstanciaVDescripcion { get; set; }
        public short? Clase_Especifica { get; set; }
        public string Clase_EspecificaDescripcion { get; set; }
        public int? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public int? Sub_Marca { get; set; }
        public string Sub_MarcaDescripcion { get; set; }
        public int? Tipo_de_Vehiculo { get; set; }
        public string Tipo_de_VehiculoDescripcion { get; set; }
        public string Modelo { get; set; }
        public int? Color { get; set; }
        public string ColorDescripcion { get; set; }
        public string Placas { get; set; }
        public int? Estado_Placas { get; set; }
        public string Estado_PlacasNombre { get; set; }
        public bool Vehiculo_Robado { get; set; }
        public bool Seguro { get; set; }
        public int? Aseguradora { get; set; }
        public string AseguradoraDescripcion { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioDescripcion { get; set; }
        public string Ruta_del_Servicio_Publico { get; set; }
        public bool Mercancia { get; set; }
        public string Descripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_la_Carga { get; set; }
        public string Senas_Particulares { get; set; }
        public short? Modalidad_del_Robo { get; set; }
        public string Modalidad_del_RoboDescripcion { get; set; }
        public short? Circunstancia_Defuncion { get; set; }
        public string Circunstancia_DefuncionDescripcion { get; set; }
        public short? Consecuencia_Defuncion { get; set; }
        public string Consecuencia_DefuncionDescripcion { get; set; }
        public string Fecha_Levantamiento { get; set; }
        public string Hora_Levantamiento { get; set; }
        public string Domicilio { get; set; }
        public string Numero_Interior3 { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior3 { get; set; }
        public int? Colonia3 { get; set; }
        public string Colonia3Nombre { get; set; }
        public string Colonia_no_Catalogada { get; set; }
        public int? Zona2 { get; set; }
        public string Zona2Descripcion { get; set; }
        public int? Municipio3 { get; set; }
        public string Municipio3Nombre { get; set; }
        public int? Estado3 { get; set; }
        public string Estado3Nombre { get; set; }
        public string Necropsia { get; set; }
        public string Cronotanatodiagnostico { get; set; }
        public string Ruta { get; set; }
        public bool Estado_Operador { get; set; }
        public bool Delito_Principal_o_Secundario { get; set; }
        public string Concurso { get; set; }
        public int? Compareciente { get; set; }
        public string ComparecienteDescripcion { get; set; }
        public string NombreC { get; set; }
        public string Apellido_PaternoC { get; set; }
        public string Apellido_MaternoC { get; set; }
        public string NombreT { get; set; }
        public string Apellido_PaternoT { get; set; }
        public string Apellido_MaternoT { get; set; }
        public string CalleC { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_ExteriorC { get; set; }
        public string Numero_InteriorC { get; set; }
        public int? ColoniaC { get; set; }
        public string ColoniaCNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_PostalC { get; set; }
        public int? ZonaC { get; set; }
        public string ZonaCDescripcion { get; set; }
        public int? MunicipioC { get; set; }
        public string MunicipioCNombre { get; set; }
        public int? EstadoC { get; set; }
        public string EstadoCNombre { get; set; }
        public string NarrativaC { get; set; }
        public bool Conocido { get; set; }
        public bool Desconocido { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Imputados { get; set; }
        public short? Procedencia { get; set; }
        public string ProcedenciaDescripcion { get; set; }
        public string Motor { get; set; }
        public string Serie { get; set; }
        public string Causa_de_Muerte { get; set; }
        public string Entre_Calle { get; set; }
        public string Entre_Calle2 { get; set; }
        public bool Autoriza { get; set; }
        public bool Autoriza2 { get; set; }
        public bool Autoriza3 { get; set; }
        public bool Menor_de_Edad { get; set; }

    }
	
	public class Orientador_Datos_de_Servicios_de_ApoyoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public bool? Atencion_Medica { get; set; }
        public bool? Atencion_Psicologica { get; set; }
        public bool? Traductor { get; set; }
        public string Narrativa_DM { get; set; }
        public string Narrativa_DP { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public int? Compareciente { get; set; }
        public string ComparecienteDescripcion { get; set; }
        public string NombreC { get; set; }
        public string Apellido_PaternoC { get; set; }
        public string Apellido_MaternoC { get; set; }
        public string NombreT { get; set; }
        public string Apellido_PaternoT { get; set; }
        public string Apellido_MaternoT { get; set; }
        public string CalleC { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_ExteriorC { get; set; }
        public string Numero_InteriorC { get; set; }
        public int? ColoniaC { get; set; }
        public string ColoniaCNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_PostalC { get; set; }
        public int? ZonaC { get; set; }
        public string ZonaCDescripcion { get; set; }
        public int? MunicipioC { get; set; }
        public string MunicipioCNombre { get; set; }
        public int? EstadoC { get; set; }
        public string EstadoCNombre { get; set; }
        public string NarrativaC { get; set; }
        public bool? Autoriza { get; set; }
        public bool? Autoriza2 { get; set; }
        public bool? Autoriza3 { get; set; }
        public bool? Menor_de_Edad { get; set; }

    }

	public class Orientador_Datos_del_ImputadoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        [Range(0, 9999999999)]
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public string SexoDescripcion { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estado_CivilDescripcion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public short? Escolaridad { get; set; }
        public string EscolaridadDescripcion { get; set; }
        public int? Ocupacion { get; set; }
        public string OcupacionDescripcion { get; set; }
        public string Calle { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public int? Localidad { get; set; }
        public string LocalidadDescripcion { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }

    }

	public class Orientador_Datos_de_los_HechosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Tipo_de_Lugar_del_HechoDescripcion { get; set; }
        public string Calle2 { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior2 { get; set; }
        public string Numero_Interior2 { get; set; }
        public int? Colonia2 { get; set; }
        public string Colonia2Nombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal2 { get; set; }
        public int? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        public int? Municipio2 { get; set; }
        public string Municipio2Nombre { get; set; }
        public int? Estado2 { get; set; }
        public string Estado2Nombre { get; set; }
        public string Entre_Calle { get; set; }
        public string Entre_Calle2 { get; set; }

    }

	public class Orientador_Datos_del_DelitoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Grupo_Delito { get; set; }
        public string Grupo_DelitoDescripcion { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Circunstancia { get; set; }
        public string CircunstanciaDescripcion { get; set; }
        public int? Tipo_Delito { get; set; }
        public string Tipo_DelitoDescripcion { get; set; }
        public int? Forma_Comision_Delito { get; set; }
        public string Forma_Comision_DelitoDescripcion { get; set; }
        public short? Forma_Accion_Delito { get; set; }
        public string Forma_Accion_DelitoDescripcion { get; set; }
        public short? Modalidad_Delito { get; set; }
        public string Modalidad_DelitoDescripcion { get; set; }
        public int? Elementos_Comision_Delito { get; set; }
        public string Elementos_Comision_DelitoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto { get; set; }
        public bool? HViolencia_de_Genero { get; set; }
        public string Calificacion_del_Delito { get; set; }
        public bool? Delito_Principal_o_Secundario { get; set; }
        public string Concurso { get; set; }

    }

	public class Orientador_Datos_de_Robo_de_VehiculoModel
    {
        [Required]
        public int Clave { get; set; }
        public short? CircunstanciaV { get; set; }
        public string CircunstanciaVDescripcion { get; set; }
        public short? Clase_Especifica { get; set; }
        public string Clase_EspecificaDescripcion { get; set; }
        public int? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public int? Sub_Marca { get; set; }
        public string Sub_MarcaDescripcion { get; set; }
        public int? Tipo_de_Vehiculo { get; set; }
        public string Tipo_de_VehiculoDescripcion { get; set; }
        public string Modelo { get; set; }
        public int? Color { get; set; }
        public string ColorDescripcion { get; set; }
        public string Placas { get; set; }
        public int? Estado_Placas { get; set; }
        public string Estado_PlacasNombre { get; set; }
        public bool? Vehiculo_Robado { get; set; }
        public bool? Seguro { get; set; }
        public int? Aseguradora { get; set; }
        public string AseguradoraDescripcion { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioDescripcion { get; set; }
        public string Ruta_del_Servicio_Publico { get; set; }
        public bool? Mercancia { get; set; }
        public string Descripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_la_Carga { get; set; }
        public string Senas_Particulares { get; set; }
        public short? Modalidad_del_Robo { get; set; }
        public string Modalidad_del_RoboDescripcion { get; set; }
        public short? Procedencia { get; set; }
        public string ProcedenciaDescripcion { get; set; }
        public string Motor { get; set; }
        public string Serie { get; set; }

    }

	public class Orientador_Datos_de_Levantamiento_de_CadaverModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Circunstancia_Defuncion { get; set; }
        public string Circunstancia_DefuncionDescripcion { get; set; }
        public short? Consecuencia_Defuncion { get; set; }
        public string Consecuencia_DefuncionDescripcion { get; set; }
        public string Fecha_Levantamiento { get; set; }
        public string Hora_Levantamiento { get; set; }
        public string Domicilio { get; set; }
        public string Numero_Interior3 { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior3 { get; set; }
        public int? Colonia3 { get; set; }
        public string Colonia3Nombre { get; set; }
        public string Colonia_no_Catalogada { get; set; }
        public int? Zona2 { get; set; }
        public string Zona2Descripcion { get; set; }
        public int? Municipio3 { get; set; }
        public string Municipio3Nombre { get; set; }
        public int? Estado3 { get; set; }
        public string Estado3Nombre { get; set; }
        public string Necropsia { get; set; }
        public string Cronotanatodiagnostico { get; set; }
        public string Ruta { get; set; }
        public bool? Estado_Operador { get; set; }
        public string Causa_de_Muerte { get; set; }

    }

	public class Orientador_ImputadoModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Conocido { get; set; }
        public bool? Desconocido { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Imputados { get; set; }

    }


}

