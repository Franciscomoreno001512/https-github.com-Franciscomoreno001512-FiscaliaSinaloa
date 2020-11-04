using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Delito_de_JusticiaModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? idRegistroAT { get; set; }
        [Range(0, 9999999999)]
        public int? idRegistroUI { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        public string Fecha_de_Delito { get; set; }
        public bool Violencia_de_Genero { get; set; }
        public int? Delito_Violencia_Genero { get; set; }
        public string Delito_Violencia_GeneroDescripcion { get; set; }
        public string Hora_de_Delito { get; set; }
        public int? Tipo_de_Delito { get; set; }
        public string Tipo_de_DelitoDescripcion { get; set; }
        public int? Grupo_de_Delito { get; set; }
        public string Grupo_de_DelitoDescripcion { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public bool Delito_Principal { get; set; }
        public int? Forma_de_Comision_de_Delito { get; set; }
        public string Forma_de_Comision_de_DelitoDescripcion { get; set; }
        public short? Forma_de_Accion_de_Delito { get; set; }
        public string Forma_de_Accion_de_DelitoDescripcion { get; set; }
        public short? Modalidad_de_Delito { get; set; }
        public string Modalidad_de_DelitoDescripcion { get; set; }
        public int? Elementos_de_Comision_de_Delito { get; set; }
        public string Elementos_de_Comision_de_DelitoDescripcion { get; set; }
        public int? Clasificacion_con_Orden_de_Resultado { get; set; }
        public string Clasificacion_con_Orden_de_ResultadoDescripcion { get; set; }
        public int? Concurso { get; set; }
        public string ConcursoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_Reparacion_de_Danos { get; set; }
        public int? Estado_del_Delito { get; set; }
        public string Estado_del_DelitoNombre { get; set; }
        public int? Municipio_del_Delito { get; set; }
        public string Municipio_del_DelitoNombre { get; set; }
        public int? Colonia_del_Delito { get; set; }
        public string Colonia_del_DelitoNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public string Calle_del_Delito { get; set; }
        public string Entre_Calle_del_Delito { get; set; }
        public string Y_Calle_del_Delito { get; set; }
        public string Numero_Exterior_del_Delito { get; set; }
        public string Numero_Interior_del_Delito { get; set; }
        public string Referencia { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool Robo_de_Vehiculo { get; set; }
        public string Fecha_del_Robo { get; set; }
        public string Hora_del_Robo { get; set; }
        public int? Robo_de { get; set; }
        public string Robo_deDescripcion { get; set; }
        public string Registro_Federal_Vehicular { get; set; }
        public string Numero_de_Registro_Publico_Vehicular { get; set; }
        public short? Circunstancia_de_Robo_de_Vehiculo { get; set; }
        public string Circunstancia_de_Robo_de_VehiculoDescripcion { get; set; }
        public int? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public int? Sub_Marca { get; set; }
        public string Sub_MarcaDescripcion { get; set; }
        public int? Tipo_de_vehiculo { get; set; }
        public string Tipo_de_vehiculoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Modelo { get; set; }
        public int? Color { get; set; }
        public string ColorDescripcion { get; set; }
        public string Placas { get; set; }
        public int? Estado_de_Origen_de_las_Placas { get; set; }
        public string Estado_de_Origen_de_las_PlacasNombre { get; set; }
        public string Motor { get; set; }
        public string Serie { get; set; }
        public int? Estado_De_Robo { get; set; }
        public string Estado_De_RoboNombre { get; set; }
        public int? Municipio_de_Robo { get; set; }
        public string Municipio_de_RoboNombre { get; set; }
        public int? Colonia_de_Robo { get; set; }
        public string Colonia_de_RoboNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_de_Robo { get; set; }
        public string Calle_de_Robo { get; set; }
        public string Entre_Calle_de_Robo { get; set; }
        public string Y_Calle_de_Robo { get; set; }
        public string Numero_Exterior_de_Robo { get; set; }
        public string Numero_Interior_de_Robo { get; set; }
        public string Referencia_de_Robo { get; set; }
        public string Latitud_de_Robo { get; set; }
        public string Longitud_de_Robo { get; set; }
        public int? Lugar_de_Robo { get; set; }
        public string Lugar_de_RoboDescripcion { get; set; }
        public bool El_vehiculo_esta_asegurado { get; set; }
        public int? Nombre_de_la_Aseguradora { get; set; }
        public string Nombre_de_la_AseguradoraDescripcion { get; set; }
        public string Ruta_del_Servicio_Publico { get; set; }
        public bool El_Vehiculo_Transportaba_Mercancia { get; set; }
        public string Descripcion_de_lo_que_Transportaba { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_carga { get; set; }
        public string Senas_particulares { get; set; }
        public int? Cuenta_con_GPS { get; set; }
        public string Cuenta_con_GPSDescripcion { get; set; }
        public int? Tipo_de_Robo { get; set; }
        public string Tipo_de_RoboDescripcion { get; set; }
        public int? Tipo_de_Lugar_del_Robo { get; set; }
        public string Tipo_de_Lugar_del_RoboDescripcion { get; set; }
        public int? Tipo_de_Carretera { get; set; }
        public string Tipo_de_CarreteraDescripcion { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioDescripcion { get; set; }
        public string Numero_de_Serie { get; set; }
        public string Numero_de_Motor { get; set; }
        public bool Persona_Moral { get; set; }
        public int? Nombre_Completo_Persona_Moral { get; set; }
        public string Nombre_Completo_Persona_MoralNombre { get; set; }
        public bool Persona_Fisica { get; set; }
        public int? Nombre_Completo_Persona_Fisica { get; set; }
        public string Nombre_Completo_Persona_FisicaNombre { get; set; }
        public bool Denunciante { get; set; }
        public int? Nombre_Completo_Denunciante { get; set; }
        public string Nombre_Completo_DenuncianteNombre { get; set; }

    }
	
	public class Detalle_de_Delito_de_Justicia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? idRegistroAT { get; set; }
        [Range(0, 9999999999)]
        public int? idRegistroUI { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        public string Fecha_de_Delito { get; set; }
        public bool? Violencia_de_Genero { get; set; }
        public int? Delito_Violencia_Genero { get; set; }
        public string Delito_Violencia_GeneroDescripcion { get; set; }
        public string Hora_de_Delito { get; set; }
        public int? Tipo_de_Delito { get; set; }
        public string Tipo_de_DelitoDescripcion { get; set; }
        public int? Grupo_de_Delito { get; set; }
        public string Grupo_de_DelitoDescripcion { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public bool? Delito_Principal { get; set; }
        public int? Forma_de_Comision_de_Delito { get; set; }
        public string Forma_de_Comision_de_DelitoDescripcion { get; set; }
        public short? Forma_de_Accion_de_Delito { get; set; }
        public string Forma_de_Accion_de_DelitoDescripcion { get; set; }
        public short? Modalidad_de_Delito { get; set; }
        public string Modalidad_de_DelitoDescripcion { get; set; }
        public int? Elementos_de_Comision_de_Delito { get; set; }
        public string Elementos_de_Comision_de_DelitoDescripcion { get; set; }
        public int? Clasificacion_con_Orden_de_Resultado { get; set; }
        public string Clasificacion_con_Orden_de_ResultadoDescripcion { get; set; }
        public int? Concurso { get; set; }
        public string ConcursoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_Reparacion_de_Danos { get; set; }
        public int? Estado_del_Delito { get; set; }
        public string Estado_del_DelitoNombre { get; set; }
        public int? Municipio_del_Delito { get; set; }
        public string Municipio_del_DelitoNombre { get; set; }
        public int? Colonia_del_Delito { get; set; }
        public string Colonia_del_DelitoNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public string Calle_del_Delito { get; set; }
        public string Entre_Calle_del_Delito { get; set; }
        public string Y_Calle_del_Delito { get; set; }
        public string Numero_Exterior_del_Delito { get; set; }
        public string Numero_Interior_del_Delito { get; set; }
        public string Referencia { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool? Robo_de_Vehiculo { get; set; }

    }

	public class Detalle_de_Delito_de_Justicia_Datos_de_Robo_de_VehiculoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_del_Robo { get; set; }
        public string Hora_del_Robo { get; set; }
        public int? Robo_de { get; set; }
        public string Robo_deDescripcion { get; set; }
        public string Registro_Federal_Vehicular { get; set; }
        public string Numero_de_Registro_Publico_Vehicular { get; set; }
        public short? Circunstancia_de_Robo_de_Vehiculo { get; set; }
        public string Circunstancia_de_Robo_de_VehiculoDescripcion { get; set; }
        public int? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public int? Sub_Marca { get; set; }
        public string Sub_MarcaDescripcion { get; set; }
        public int? Tipo_de_vehiculo { get; set; }
        public string Tipo_de_vehiculoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Modelo { get; set; }
        public int? Color { get; set; }
        public string ColorDescripcion { get; set; }
        public string Placas { get; set; }
        public int? Estado_de_Origen_de_las_Placas { get; set; }
        public string Estado_de_Origen_de_las_PlacasNombre { get; set; }
        public string Motor { get; set; }
        public string Serie { get; set; }
        public int? Estado_De_Robo { get; set; }
        public string Estado_De_RoboNombre { get; set; }
        public int? Municipio_de_Robo { get; set; }
        public string Municipio_de_RoboNombre { get; set; }
        public int? Colonia_de_Robo { get; set; }
        public string Colonia_de_RoboNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_de_Robo { get; set; }
        public string Calle_de_Robo { get; set; }
        public string Entre_Calle_de_Robo { get; set; }
        public string Y_Calle_de_Robo { get; set; }
        public string Numero_Exterior_de_Robo { get; set; }
        public string Numero_Interior_de_Robo { get; set; }
        public string Referencia_de_Robo { get; set; }
        public string Latitud_de_Robo { get; set; }
        public string Longitud_de_Robo { get; set; }
        public int? Lugar_de_Robo { get; set; }
        public string Lugar_de_RoboDescripcion { get; set; }
        public bool? El_vehiculo_esta_asegurado { get; set; }
        public int? Nombre_de_la_Aseguradora { get; set; }
        public string Nombre_de_la_AseguradoraDescripcion { get; set; }
        public string Ruta_del_Servicio_Publico { get; set; }
        public bool? El_Vehiculo_Transportaba_Mercancia { get; set; }
        public string Descripcion_de_lo_que_Transportaba { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_carga { get; set; }
        public string Senas_particulares { get; set; }
        public int? Cuenta_con_GPS { get; set; }
        public string Cuenta_con_GPSDescripcion { get; set; }
        public int? Tipo_de_Robo { get; set; }
        public string Tipo_de_RoboDescripcion { get; set; }
        public int? Tipo_de_Lugar_del_Robo { get; set; }
        public string Tipo_de_Lugar_del_RoboDescripcion { get; set; }
        public int? Tipo_de_Carretera { get; set; }
        public string Tipo_de_CarreteraDescripcion { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioDescripcion { get; set; }
        public string Numero_de_Serie { get; set; }
        public string Numero_de_Motor { get; set; }

    }

	public class Detalle_de_Delito_de_Justicia_Asignar_DuenoModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Persona_Moral { get; set; }
        public int? Nombre_Completo_Persona_Moral { get; set; }
        public string Nombre_Completo_Persona_MoralNombre { get; set; }
        public bool? Persona_Fisica { get; set; }
        public int? Nombre_Completo_Persona_Fisica { get; set; }
        public string Nombre_Completo_Persona_FisicaNombre { get; set; }
        public bool? Denunciante { get; set; }
        public int? Nombre_Completo_Denunciante { get; set; }
        public string Nombre_Completo_DenuncianteNombre { get; set; }

    }


}

