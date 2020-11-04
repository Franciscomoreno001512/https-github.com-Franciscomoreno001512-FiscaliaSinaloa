using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Expediente_InicialMainModel
    {
        public Expediente_InicialModel Expediente_InicialInfo { set; get; }
        public Detalle_de_Datos_de_la_Victima_MPIGridModelPost Detalle_de_Datos_de_la_Victima_MPIGridInfo { set; get; }
        public Detalle_de_Datos_del_Imputado_MPIGridModelPost Detalle_de_Datos_del_Imputado_MPIGridInfo { set; get; }
        public Detalle_Datos_de_Delito_MPIGridModelPost Detalle_Datos_de_Delito_MPIGridInfo { set; get; }
        public Detalle_de_Persona_Moral_MPIGridModelPost Detalle_de_Persona_Moral_MPIGridInfo { set; get; }
        public Detalle_de_Servicio_de_Apoyo_MPIGridModelPost Detalle_de_Servicio_de_Apoyo_MPIGridInfo { set; get; }
        public Detalle_de_Datos_del_Testigo_MPIGridModelPost Detalle_de_Datos_del_Testigo_MPIGridInfo { set; get; }
        public Detalle_de_Agente_del_Ministerio_PublicoGridModelPost Detalle_de_Agente_del_Ministerio_PublicoGridInfo { set; get; }
        public Detalle_de_Servicios_PericialesGridModelPost Detalle_de_Servicios_PericialesGridInfo { set; get; }
        public Detalle_de_Oficio_de_Servicio_PericialGridModelPost Detalle_de_Oficio_de_Servicio_PericialGridInfo { set; get; }
        public Detalle_de_IPH_MPIGridModelPost Detalle_de_IPH_MPIGridInfo { set; get; }
        public Detalle_de_Solicitante_en_Audiencias_MPIGridModelPost Detalle_de_Solicitante_en_Audiencias_MPIGridInfo { set; get; }
        public Detalle_de_Requerido_en_Audiencias_MPIGridModelPost Detalle_de_Requerido_en_Audiencias_MPIGridInfo { set; get; }
        public Detalle_de_Citatorio_AudienciasGridModelPost Detalle_de_Citatorio_AudienciasGridInfo { set; get; }
        public Detalle_de_Documentos_MPIGridModelPost Detalle_de_Documentos_MPIGridInfo { set; get; }
        public Detalle_de_Coincidencias_MPIGridModelPost Detalle_de_Coincidencias_MPIGridInfo { set; get; }
        public Detalle_de_IndiciosGridModelPost Detalle_de_IndiciosGridInfo { set; get; }
        public Detalle_Bitacora_de_Canalizacion_MPIGridModelPost Detalle_Bitacora_de_Canalizacion_MPIGridInfo { set; get; }

    }

    public class Detalle_de_Datos_de_la_Victima_MPIGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool? Incapaz { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Nombre_Completo_del_Tutor { get; set; }
        public string Fecha_de_Nacimiento_del_Tutor { get; set; }
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Localidad_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public int? Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public int? Extencion_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Narrativa_de_los_Hechos { get; set; }

        public string Titulo_del_Hecho { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos { get; set; }
        public int? Estado_de_los_Hechos { get; set; }
        public int? Municipio_de_los_Hechos { get; set; }
        public int? Colonia_de_los_Hechos { get; set; }
        public int? Codigo_Postal_de_los_Hechos { get; set; }
        public string Calle_de_los_Hechos { get; set; }
        public string Entre_Calle_de_los_Hechos { get; set; }
        public string Y_Calle_de_los_Hechos { get; set; }
        public string Numero_Exterior_de_los_Hechos { get; set; }
        public string Numero_Interior_de_los_Hechos { get; set; }
        public string Latitud_de_los_Hechos { get; set; }
        public string Longitud_de_los_Hechos { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public bool? Proteccion_de_Datos { get; set; }
        public string Nombre_de_Persona_Moral { get; set; }
        public string Apellido_Paterno_de_Persona_Moral { get; set; }
        public string Apellido_Materno_de_Persona_Moral { get; set; }
        public string Fecha_de_Nacimiento_de_Persona_Moral { get; set; }
        public short? Edad_de_Persona_Moral { get; set; }
        public int? Sexo_de_Persona_Moral { get; set; }
        public int? Estado_Civil_de_Persona_Moral { get; set; }
        public int? Tipo_de_Identificacion_de_Persona_Moral { get; set; }
        public string Numero_de_Identificacion_de_Persona_Mora { get; set; }
        public int? Nacionalidad_de_Persona_Moral { get; set; }
        public short? Escolaridad_de_Persona_Moral { get; set; }
        public int? Ocupacion_de_Persona_Moral { get; set; }
        public int? Pais_de_Persona_Moral { get; set; }
        public int? Estado_de_Persona_Moral { get; set; }
        public int? Municipio_de_Persona_Moral { get; set; }
        public int? Colonia_de_Persona_Moral { get; set; }
        public int? Codigo_Postal_de_Persona_Moral { get; set; }
        public string Calle_de_Persona_Moral { get; set; }
        public string Numero_Exterior_de_Persona_Moral { get; set; }
        public string Numero_Interior_de_Persona_Moral { get; set; }
        public string Entre_Calle_de_Persona_Moral { get; set; }
        public string Y_Calle_de_Persona_Moral { get; set; }
        public string Longitud_de_Persona_Moral { get; set; }
        public string Latitud_de_Persona_Moral { get; set; }
        public string Telefono_de_Persona_Moral { get; set; }
        public string Extension_de_Persona_Moral { get; set; }
        public string Celular_de_Persona_Moral { get; set; }
        public string Correo_Electronico_de_Persona_Moral { get; set; }
        public bool? Persona_Moral_Victima { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Datos_del_Imputado_MPIGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Localidad { get; set; }
        public int? Colonia { get; set; }
        public string Calle_del_Imputado { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais { get; set; }
        public int? Forma_Cara { get; set; }
        public int? Cejas { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public int? Complexion { get; set; }
        public int? Color_Piel { get; set; }
        public int? Frente { get; set; }
        public int? Forma_Cabello { get; set; }
        public int? Calvicie { get; set; }
        public int? Color_Ojos { get; set; }
        public int? Ojos { get; set; }
        public int? Forma_Ojos { get; set; }
        public int? Nariz_Base { get; set; }
        public int? Labios { get; set; }
        public int? Boca { get; set; }
        public int? Menton { get; set; }
        public int? Barba { get; set; }
        public int? Forma_Orejas { get; set; }
        public int? Tamano_Orejas { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public int? Bigote { get; set; }
        public int? Situacion_Fisica { get; set; }
        public string Alias_media_diliacion { get; set; }
        public string Fecha_de_Detencion { get; set; }
        public string Hora_de_Detencion { get; set; }
        public string Fecha_de_Puesto_a_Disposicion { get; set; }
        public string Hora_de_Puesto_a_Disposicion { get; set; }
        public int? Con_Detenido { get; set; }
        public bool? A_Quien_Resulte_Responsable { get; set; }
        public string Tiempo_Restante_para_Vinculacion { get; set; }
        public bool? Vincular { get; set; }
        public int? Medidas_Cautelares { get; set; }
        public string Solicitar_Prorroga { get; set; }
        public string Nuevo_Plazo { get; set; }
        public bool? Orden_de_Aprehension { get; set; }
        public int? Medidas_Cautelares_en_Imputado { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_del_Hecho { get; set; }
        public int? Estado_del_Hecho { get; set; }
        public int? Municipio_del_Hecho { get; set; }
        public int? Colonia_del_Hecho { get; set; }
        public int? Codigo_Postal_del_Hecho { get; set; }
        public string Calle_del_Hecho { get; set; }
        public string Entre_Calle_del_Hecho { get; set; }
        public string Y_Calle_del_Hecho { get; set; }
        public string Numero_Exterior_del_Hecho { get; set; }
        public string Numero_Interior_del_Hecho { get; set; }
        public string Latitud_del_Hecho { get; set; }
        public decimal? Longitud_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }

        public bool? Incapaz { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Fecha_de_Nacimiento_del_Tutor { get; set; }
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public string Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public short? Extension_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public bool? Proteccion_de_Datos { get; set; }

        public int? Estatus { get; set; }
        public bool? Judicializar { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Datos_de_Delito_MPIGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Delito { get; set; }
        public int? Grupo_Delito { get; set; }
        public int? Delito { get; set; }
        public int? Circunstancia_Delito { get; set; }
        public bool? Delito_Principal { get; set; }
        public int? Forma_Comision_Delito { get; set; }
        public short? Forma_Accion_Delito { get; set; }
        public short? Modalidad_Delito { get; set; }
        public int? Elementos_Comision_Delito { get; set; }
        public decimal? Monto { get; set; }
        public bool? Violencia_de_Genero { get; set; }
        public bool? Robo_de_Vehiculo { get; set; }
        public bool? Levantamiento_de_Cadaver { get; set; }
        public short? Circunstancia_de_Vehiculo { get; set; }
        public short? Clase { get; set; }
        public bool? Vehiculo_Robado { get; set; }
        public int? Marca { get; set; }
        public int? Sub_Marca { get; set; }
        public int? Tipo_de_Vehiculo { get; set; }
        public int? Modelo { get; set; }
        public int? Color { get; set; }
        public string Placas { get; set; }
        public int? Estado_de_Origen_de_las_Placas { get; set; }
        public string Motor { get; set; }
        public string Serie { get; set; }
        public bool? El_Vehiculo_esta_Asegurado { get; set; }
        public int? Nombre_de_la_Aseguradora { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Ruta_del_Servicio_Publico { get; set; }
        public short? Procedencia { get; set; }
        public bool? Mercancia { get; set; }
        public string Descripcion_de_lo_que_Transportaba { get; set; }
        public decimal? Monto_de_la_Carga { get; set; }
        public string Senas_Particulares { get; set; }
        public short? Modalidad_del_Robo { get; set; }
        public string Causa_de_Muerte { get; set; }
        public short? Circunstancia_Defuncion { get; set; }
        public short? Consecuencia_Defuncion { get; set; }
        public string Fecha_Levantamiento { get; set; }
        public string Hora_Levantamiento { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Zona { get; set; }
        public int? Colonia { get; set; }
        public string Colonia_no_Catalogada { get; set; }
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Necropsia { get; set; }
        public string Cronotanatodiagnostico { get; set; }
        public string Ruta { get; set; }
        public bool? Estado_del_Conductor { get; set; }
        public int? Codigo_Postal { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Persona_Moral_MPIGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Calidad_Juridica { get; set; }
        public string Razon_Social { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Localidad { get; set; }
        public int? Colonia { get; set; }
        public string Calle { get; set; }
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public short? Extension { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Servicio_de_Apoyo_MPIGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        public int? Victima { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Datos_del_Testigo_MPIGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool? Incapaz { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Nombre_Completo_del_Tutor { get; set; }
        public string Fecha_de_Nacimento_del_Tutor { get; set; }
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public string Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public short? Extencion_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Narrativa_del_Testigo { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_del_Hecho { get; set; }
        public int? Estado_del_Hecho { get; set; }
        public int? Municipio_del_Hecho { get; set; }
        public int? Colonia_del_Hecho { get; set; }
        public int? Codigo_Postal_del_Hecho { get; set; }
        public string Calle_del_Hecho { get; set; }
        public string Entre_Calle_del_Hecho { get; set; }
        public string Y_Calle_del_Hecho { get; set; }
        public string Numero_Exterior_del_Hecho { get; set; }
        public string Numero_Interior_del_Hecho { get; set; }
        public string Latitud_del_Hecho { get; set; }
        public string Longitud_del_Hecho { get; set; }
        public int? Tipo_del_Lugar_del_Hecho { get; set; }
        public bool? Proteccion_de_Datos { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Agente_del_Ministerio_PublicoGridModelPost
    {
        public int Clave { get; set; }
        public int? Agente_del_Ministerio_Publico { get; set; }
        public int? Carga_de_Trabajo { get; set; }
        public string Especialidad { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Servicios_PericialesGridModelPost
    {
        public int Clave { get; set; }
        public int? Servicio { get; set; }
        public int? Especialista { get; set; }
        public int? Estatus_del_Dictamen { get; set; }
        public string Observaciones { get; set; }
        public string Fecha_del_Dictamen { get; set; }
        public short? Dictamen { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public string ObservacionesD { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Oficio_de_Servicio_PericialGridModelPost
    {
        public int Clave { get; set; }
        public int? Oficio { get; set; }
        public int? Servicio_Pericial { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_IPH_MPIGridModelPost
    {
        public int Clave { get; set; }
        public string NUE { get; set; }
        public string Folio { get; set; }
        public string Fecha { get; set; }
        public string Documentos { get; set; }
        public short? Archivo { get; set; }
        public string Hora { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Solicitante_en_Audiencias_MPIGridModelPost
    {
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string Direccion { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Requerido_en_Audiencias_MPIGridModelPost
    {
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string Direccion { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Citatorio_AudienciasGridModelPost
    {
        public int Clave { get; set; }
        public string Numero_de_audiencia_citatorio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Fecha_de_Aceptacion { get; set; }
        public string Hora_de_Aceptacion { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Documentos_MPIGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Documento { get; set; }
        public short? Archivo { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Coincidencias_MPIGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string NUAT { get; set; }
        public string NUC { get; set; }
        public string Rol { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_IndiciosGridModelPost
    {
        public int Clave { get; set; }
        public string Numero_de_Indicio { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Indicio { get; set; }
        public string Motivo_de_Indicio { get; set; }
        public int? Diligencia { get; set; }
        public string Ubicacion { get; set; }
        public int? Estatus { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Bitacora_de_Canalizacion_MPIGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha_de_Cambio_de_Estatus { get; set; }
        public string Hora_de_Cambio_de_Estatus { get; set; }
        public short? Estatus_Interno { get; set; }
        public int? Estatus_de_Canalizacion { get; set; }

        public bool Removed { set; get; }
    }



}

