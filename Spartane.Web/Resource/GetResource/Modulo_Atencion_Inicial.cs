using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Modulo_Atencion_InicialResources
    {
        //private static IResourceProvider resourceProviderModulo_Atencion_Inicial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Modulo_Atencion_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderModulo_Atencion_Inicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Modulo_Atencion_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderModulo_Atencion_Inicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Modulo_Atencion_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Modulo_Atencion_Inicial</summary>
        public static string Modulo_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Modulo_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Turno_Asignado</summary>
        public static string Turno_Asignado
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Turno_Asignado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Denuncia</summary>
        public static string Tipo_de_Denuncia
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Tipo_de_Denuncia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT</summary>
        public static string NUAT
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CDI</summary>
        public static string CDI
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("CDI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expedientes_Relacionados</summary>
        public static string Expedientes_Relacionados
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Expedientes_Relacionados", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Generar_Cita</summary>
        public static string Generar_Cita
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Generar_Cita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombres_del_Remitente</summary>
        public static string Nombres_del_Remitente
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Nombres_del_Remitente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_del_Remitente</summary>
        public static string Apellido_Paterno_del_Remitente
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Apellido_Paterno_del_Remitente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_del_Remitente</summary>
        public static string Apellido_Materno_del_Remitente
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Apellido_Materno_del_Remitente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_en_que_llega_para_validacion</summary>
        public static string Fecha_en_que_llega_para_validacion
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Fecha_en_que_llega_para_validacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delegacion</summary>
        public static string Delegacion
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Delegacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agencia</summary>
        public static string Agencia
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Agencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ministerio_Publico_en_Turno</summary>
        public static string Ministerio_Publico_en_Turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Ministerio_Publico_en_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombres_turno</summary>
        public static string Nombres_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Nombres_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_turno</summary>
        public static string Apellido_Paterno_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Apellido_Paterno_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_turno</summary>
        public static string Apellido_Materno_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Apellido_Materno_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo_turno</summary>
        public static string Sexo_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Sexo_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad_turno</summary>
        public static string Edad_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Edad_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Atencion_turno</summary>
        public static string Tipo_de_Atencion_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Tipo_de_Atencion_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion_turno</summary>
        public static string Tipo_de_Identificacion_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Tipo_de_Identificacion_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion_turno</summary>
        public static string Numero_de_Identificacion_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Numero_de_Identificacion_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Urgencia_turno</summary>
        public static string Urgencia_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Urgencia_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Urgencia_turno</summary>
        public static string Tipo_de_Urgencia_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Tipo_de_Urgencia_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_Finalizacion_Turno</summary>
        public static string Motivo_Finalizacion_Turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Motivo_Finalizacion_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_turno</summary>
        public static string Observaciones_turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Observaciones_turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requiere_Traductor</summary>
        public static string Requiere_Traductor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Requiere_Traductor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lengua_Originaria</summary>
        public static string Lengua_Originaria
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Lengua_Originaria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Idioma</summary>
        public static string Idioma
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Idioma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Autoriza_Traductor</summary>
        public static string Autoriza_Traductor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Autoriza_Traductor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Finalizar_Servicios_de_Apoyo</summary>
        public static string Finalizar_Servicios_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Finalizar_Servicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus2</summary>
        public static string Estatus2
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Estatus2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_canaliza</summary>
        public static string Unidad_canaliza
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Unidad_canaliza", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Enviar_a_MP</summary>
        public static string Enviar_a_MP
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Enviar_a_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correccion_de_Estatus</summary>
        public static string Correccion_de_Estatus
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Correccion_de_Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Historial_de_Canalizaciones</summary>
        public static string Historial_de_Canalizaciones
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Historial_de_Canalizaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requiere_Servicios_de_Apoyo</summary>
        public static string Requiere_Servicios_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Requiere_Servicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_Moral</summary>
        public static string Persona_Moral
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Persona_Moral", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Hecho</summary>
        public static string Titulo_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Titulo_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_Breve_de_los_Hechos</summary>
        public static string Narrativa_Breve_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Narrativa_Breve_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Prioridad_del_Hecho</summary>
        public static string Prioridad_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Prioridad_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Orientador</summary>
        public static string Orientador
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Orientador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_del_Hecho</summary>
        public static string Hora_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Hora_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_los_Hechos</summary>
        public static string Pais_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Pais_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_de_los_Hechos</summary>
        public static string Estado_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Estado_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_de_los_Hechos</summary>
        public static string Municipio_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Municipio_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_de_los_Hechos</summary>
        public static string Colonia_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Colonia_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_de_los_Hechos</summary>
        public static string Codigo_Postal_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Codigo_Postal_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_de_los_Hechos</summary>
        public static string Calle_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Calle_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exrterior_de_los_Hechos</summary>
        public static string Numero_Exrterior_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Numero_Exrterior_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_de_los_Hechos</summary>
        public static string Numero_Interior_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Numero_Interior_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia_hechos</summary>
        public static string Referencia_hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Referencia_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento_Extraviado_hechos</summary>
        public static string Documento_Extraviado_hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Documento_Extraviado_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Documento_Extraviado</summary>
        public static string Tipo_de_Documento_Extraviado
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Tipo_de_Documento_Extraviado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar_del_Hecho</summary>
        public static string Tipo_de_Lugar_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Tipo_de_Lugar_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Zona_de_los_Hechos</summary>
        public static string Zona_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Zona_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Turno</summary>
        public static string Turno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Acuerdo</summary>
        public static string Tipo_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Tipo_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Inicio_de_Acuerdo</summary>
        public static string Fecha_de_Inicio_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Fecha_de_Inicio_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cumplimiento_del_Acuerdo</summary>
        public static string Fecha_de_Cumplimiento_del_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Fecha_de_Cumplimiento_del_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Cumplimiento_del_Acuerdo</summary>
        public static string Hora_de_Cumplimiento_del_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Hora_de_Cumplimiento_del_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Domicilio_para_el_Cumplimiento</summary>
        public static string Domicilio_para_el_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Domicilio_para_el_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_de_Reparacion_de_Danos</summary>
        public static string Monto_de_Reparacion_de_Danos
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Monto_de_Reparacion_de_Danos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Parcialidades</summary>
        public static string Parcialidades
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Parcialidades", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Periodicidad</summary>
        public static string Periodicidad
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Periodicidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Se_Acepta_Acuerdo</summary>
        public static string Se_Acepta_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Se_Acepta_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Rechazo_de_Acuerdo</summary>
        public static string Motivo_de_Rechazo_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Motivo_de_Rechazo_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documentos_generados_en_MASC</summary>
        public static string Documentos_generados_en_MASC
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Documentos_generados_en_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Coincidencias</summary>
        public static string Coincidencias
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Coincidencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cerrar</summary>
        public static string Cerrar
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Cerrar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cierre</summary>
        public static string Fecha_de_Cierre
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Fecha_de_Cierre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Cierre</summary>
        public static string Hora_de_Cierre
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Hora_de_Cierre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Historial</summary>
        public static string Historial
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Historial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUC</summary>
        public static string NUC
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("NUC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Vencimiento_1</summary>
        public static string Fecha_de_Vencimiento_1
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Fecha_de_Vencimiento_1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>EspecialistaJA</summary>
        public static string EspecialistaJA
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("EspecialistaJA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Campo_Oculto1</summary>
        public static string Campo_Oculto1
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Campo_Oculto1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>JefeMPO</summary>
        public static string JefeMPO
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("JefeMPO", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Campo_Oculto2</summary>
        public static string Campo_Oculto2
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Campo_Oculto2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Campo_Oculto3</summary>
        public static string Campo_Oculto3
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Campo_Oculto3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CoordinadorJA</summary>
        public static string CoordinadorJA
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("CoordinadorJA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>EspJA</summary>
        public static string EspJA
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("EspJA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ano_Actual</summary>
        public static string Ano_Actual
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Ano_Actual", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Secuencial</summary>
        public static string Secuencial
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Atencion_Inicial.GetResource("Secuencial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos del Caso</summary>	public static string TabDatos_del_Caso 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabDatos_del_Caso", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Información de Turno</summary>	public static string TabInformacion_de_Turno 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabInformacion_de_Turno", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Servicios de Apoyo</summary>	public static string TabServicios_de_Apoyo 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabServicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Canalizar</summary>	public static string TabCanalizar 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabCanalizar", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de los Hechos en MPO</summary>	public static string TabDatos_de_los_Hechos_en_MPO 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabDatos_de_los_Hechos_en_MPO", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Acuerdo</summary>	public static string TabDatos_del_Acuerdo 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabDatos_del_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Bitácora de Coincidencias</summary>	public static string TabBitacora_de_Coincidencias 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabBitacora_de_Coincidencias", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Cierre</summary>	public static string TabCierre 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabCierre", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Historial de movimientos</summary>	public static string TabHistorial_de_movimientos 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabHistorial_de_movimientos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Campos Ocultos</summary>	public static string TabCampos_Ocultos 	{		get		{			SetPath();  			return resourceProviderModulo_Atencion_Inicial.GetResource("TabCampos_Ocultos", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
