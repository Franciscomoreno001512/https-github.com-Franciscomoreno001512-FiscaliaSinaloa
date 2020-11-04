using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Cadena_de_CustodiaResources
    {
        //private static IResourceProvider resourceProviderCadena_de_Custodia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Cadena_de_CustodiaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCadena_de_Custodia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Cadena_de_CustodiaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCadena_de_Custodia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Cadena_de_CustodiaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Cadena_de_Custodia</summary>
        public static string Cadena_de_Custodia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Cadena_de_Custodia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUC</summary>
        public static string NUC
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("NUC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NIC</summary>
        public static string NIC
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("NIC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito_Referencia</summary>
        public static string Delito_Referencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Delito_Referencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_Exacto_del_Levantamiento</summary>
        public static string Lugar_Exacto_del_Levantamiento
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Lugar_Exacto_del_Levantamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Condicion_y_Ubicacion</summary>
        public static string Condicion_y_Ubicacion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Condicion_y_Ubicacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Levantada_por</summary>
        public static string Levantada_por
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Levantada_por", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cargo</summary>
        public static string Cargo
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Cargo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Asignar</summary>
        public static string Asignar
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Asignar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio_NUE</summary>
        public static string Folio_NUE
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Folio_NUE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_Policial</summary>
        public static string Unidad_Policial
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Unidad_Policial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Caracterististicas_del_indicio</summary>
        public static string Caracterististicas_del_indicio
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Caracterististicas_del_indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Condiciones_De_Manejo</summary>
        public static string Condiciones_De_Manejo
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Condiciones_De_Manejo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Parte</summary>
        public static string Numero_de_Parte
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Numero_de_Parte", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CUIP</summary>
        public static string CUIP
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("CUIP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clima</summary>
        public static string Clima
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Clima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grados</summary>
        public static string Grados
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Grados", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Certificado</summary>
        public static string Certificado
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Certificado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fijacion_Planimetrica</summary>
        public static string Fijacion_Planimetrica
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Fijacion_Planimetrica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fotos</summary>
        public static string Fotos
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Fotos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Videos</summary>
        public static string Videos
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Videos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_del_Interviniente</summary>
        public static string Datos_del_Interviniente
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Datos_del_Interviniente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mensaje</summary>
        public static string Mensaje
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Mensaje", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_Administrativa</summary>
        public static string Unidad_Administrativa
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Unidad_Administrativa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entidad_Federativa</summary>
        public static string Entidad_Federativa
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Entidad_Federativa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Oficio</summary>
        public static string Numero_de_Oficio
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Numero_de_Oficio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_CC</summary>
        public static string Fecha_CC
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Fecha_CC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_CC</summary>
        public static string Hora_CC
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Hora_CC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Intervencion</summary>
        public static string Motivo_de_Intervencion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Motivo_de_Intervencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_Evidencia</summary>
        public static string Descripcion_de_Evidencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Descripcion_de_Evidencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lista_de_Documentos</summary>
        public static string Lista_de_Documentos
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Lista_de_Documentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otro</summary>
        public static string Otro
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Otro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Retroalimentacion</summary>
        public static string Retroalimentacion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Retroalimentacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>FAE</summary>
        public static string FAE
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("FAE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_la_Emergencia</summary>
        public static string Fecha_de_la_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Fecha_de_la_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_la_Emergencia</summary>
        public static string Hora_de_la_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Hora_de_la_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fuente</summary>
        public static string Fuente
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Fuente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Red_Social</summary>
        public static string Red_Social
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Red_Social", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medio_Masivo</summary>
        public static string Medio_Masivo
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Medio_Masivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cargo_de_la_Autoridad</summary>
        public static string Cargo_de_la_Autoridad
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Cargo_de_la_Autoridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Emergencia</summary>
        public static string Tipo_de_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Tipo_de_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_la_Emergencia</summary>
        public static string Descripcion_de_la_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Descripcion_de_la_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Probables_Detenidos</summary>
        public static string Probables_Detenidos
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Probables_Detenidos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_la_Detencion</summary>
        public static string Fecha_de_la_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Fecha_de_la_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_la_Detencion</summary>
        public static string Hora_de_la_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Hora_de_la_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_Emergencia</summary>
        public static string Pais_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Pais_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Emergencia</summary>
        public static string Estado_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Estado_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_Emergencia</summary>
        public static string Municipio_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Municipio_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_Emergencia</summary>
        public static string Colonia_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Colonia_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_Emergencia</summary>
        public static string Calle_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Calle_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle_Emergencia</summary>
        public static string Entre_Calle_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Entre_Calle_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle_Emergencia</summary>
        public static string Y_Calle_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Y_Calle_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_Emergencia</summary>
        public static string Latitud_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Latitud_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_Emergencia</summary>
        public static string Longitud_Emergencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Longitud_Emergencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Puntos_de_Referencia</summary>
        public static string Puntos_de_Referencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Puntos_de_Referencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_la_Autoridad</summary>
        public static string Nombre_de_la_Autoridad
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Nombre_de_la_Autoridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especifique</summary>
        public static string Especifique
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Especifique", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Agente</summary>
        public static string Tipo_de_Agente
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Tipo_de_Agente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Area</summary>
        public static string Area
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Area", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Zona</summary>
        public static string Zona
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Zona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agente_Investigador</summary>
        public static string Agente_Investigador
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Agente_Investigador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_de_los_Hechos</summary>
        public static string Narrativa_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Narrativa_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Probable_Delito_Principal</summary>
        public static string Probable_Delito_Principal
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Probable_Delito_Principal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fotos_de_Evidencia</summary>
        public static string Fotos_de_Evidencia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Fotos_de_Evidencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Historial_de_Movimientos</summary>
        public static string Historial_de_Movimientos
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Historial_de_Movimientos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_del_Detenido</summary>
        public static string Datos_del_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Datos_del_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_del_Testigo</summary>
        public static string Datos_del_Testigo
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Datos_del_Testigo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Asignacion</summary>
        public static string Fecha_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Fecha_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Asignacion</summary>
        public static string Hora_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Hora_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_NUE</summary>
        public static string Estatus_NUE
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Estatus_NUE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Inicio_de_Cadena_de_Custodia</summary>
        public static string Inicio_de_Cadena_de_Custodia
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Inicio_de_Cadena_de_Custodia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calidad_de_quien_aporta</summary>
        public static string Calidad_de_quien_aporta
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Calidad_de_quien_aporta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_arribo</summary>
        public static string Fecha_del_arribo
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Fecha_del_arribo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_del_arribo</summary>
        public static string Hora_del_arribo
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Hora_del_arribo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_recoleccion</summary>
        public static string Descripcion_de_recoleccion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Descripcion_de_recoleccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Movil_para_Traslado</summary>
        public static string Movil_para_Traslado
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Movil_para_Traslado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servidor_Publico_que_Preserva</summary>
        public static string Servidor_Publico_que_Preserva
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Servidor_Publico_que_Preserva", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servidor_Publico_que_Busca</summary>
        public static string Servidor_Publico_que_Busca
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Servidor_Publico_que_Busca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servidor_Publico_que_Localiza</summary>
        public static string Servidor_Publico_que_Localiza
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Servidor_Publico_que_Localiza", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servidor_Publico_que_Recolecta</summary>
        public static string Servidor_Publico_que_Recolecta
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Servidor_Publico_que_Recolecta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servidor_Publico_que_Traslada</summary>
        public static string Servidor_Publico_que_Traslada
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Servidor_Publico_que_Traslada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Preservacion</summary>
        public static string Preservacion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Preservacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Busqueda</summary>
        public static string Busqueda
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Busqueda", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Localizacion</summary>
        public static string Localizacion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Localizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Recoleccion</summary>
        public static string Recoleccion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Recoleccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_embalaje</summary>
        public static string Tipo_de_embalaje
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Tipo_de_embalaje", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lista_de_Asignaciones</summary>
        public static string Lista_de_Asignaciones
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Lista_de_Asignaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Fijacion</summary>
        public static string Tipo_de_Fijacion
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Tipo_de_Fijacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_de_Traslado</summary>
        public static string Datos_de_Traslado
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Datos_de_Traslado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Indicio</summary>
        public static string Tipo_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderCadena_de_Custodia.GetResource("Tipo_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Asignación</summary>	public static string TabAsignacion 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabAsignacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Cadena de Custodia</summary>	public static string TabCadena_de_Custodia 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabCadena_de_Custodia", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Fijacion Planimetrica</summary>	public static string TabFijacion_Planimetrica 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabFijacion_Planimetrica", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Fotos</summary>	public static string TabFotos 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabFotos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Videos</summary>	public static string TabVideos 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabVideos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Registro de Intervinientes</summary>	public static string TabRegistro_de_Intervinientes 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabRegistro_de_Intervinientes", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Chat</summary>	public static string TabChat 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabChat", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Documentos</summary>	public static string TabDocumentos 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabDocumentos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Retroalimentación</summary>	public static string TabRetroalimentacion 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabRetroalimentacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Registro de Emergencia</summary>	public static string TabRegistro_de_Emergencia 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabRegistro_de_Emergencia", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Registro de Detenidos</summary>	public static string TabRegistro_de_Detenidos 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabRegistro_de_Detenidos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Registro de Testigos</summary>	public static string TabRegistro_de_Testigos 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabRegistro_de_Testigos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Asignaciones</summary>	public static string TabAsignaciones 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabAsignaciones", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Traslado</summary>	public static string TabDatos_de_Traslado 	{		get		{			SetPath();  			return resourceProviderCadena_de_Custodia.GetResource("TabDatos_de_Traslado", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
