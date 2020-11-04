using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Expediente_InicialResources
    {
        //private static IResourceProvider resourceProviderExpediente_Inicial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Expediente_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderExpediente_Inicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Expediente_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderExpediente_Inicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Expediente_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Expediente_Inicial</summary>
        public static string Expediente_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Expediente_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Detenido</summary>
        public static string Detenido
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUC</summary>
        public static string NUC
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("NUC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NIC</summary>
        public static string NIC
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("NIC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_del_Detenido</summary>
        public static string Hora_del_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Hora_del_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Puesto_a_Disposicion</summary>
        public static string Hora_Puesto_a_Disposicion
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Hora_Puesto_a_Disposicion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitar_Servicos_de_Apoyo</summary>
        public static string Solicitar_Servicos_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Solicitar_Servicos_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_de_la_Victima</summary>
        public static string Datos_de_la_Victima
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Datos_de_la_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_del_Imputado</summary>
        public static string Datos_del_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Datos_del_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_del_Delito</summary>
        public static string Datos_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Datos_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_Breve_de_los_Hechos</summary>
        public static string Narrativa_Breve_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Narrativa_Breve_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Prioridad_del_Hecho</summary>
        public static string Prioridad_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Prioridad_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Turno</summary>
        public static string Turno
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_del_Hecho</summary>
        public static string Hora_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Hora_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_los_Hechos_MPI</summary>
        public static string Pais_de_los_Hechos_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Pais_de_los_Hechos_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_de_los_Hechos_MPI</summary>
        public static string Estado_de_los_Hechos_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Estado_de_los_Hechos_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_de_los_Hechos_MPI</summary>
        public static string Municipio_de_los_Hechos_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Municipio_de_los_Hechos_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_de_los_Hechos_MPI</summary>
        public static string Colonia_de_los_Hechos_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Colonia_de_los_Hechos_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_de_los_Hechos_MPI</summary>
        public static string Codigo_Postal_de_los_Hechos_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Codigo_Postal_de_los_Hechos_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_de_los_Hechos_MPI</summary>
        public static string Calle_de_los_Hechos_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Calle_de_los_Hechos_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle_MPI</summary>
        public static string Entre_Calle_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Entre_Calle_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle_MPI</summary>
        public static string Y_Calle_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Y_Calle_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exrterior_de_los_Hechos_MPI</summary>
        public static string Numero_Exrterior_de_los_Hechos_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Numero_Exrterior_de_los_Hechos_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_de_los_Hechos_MPI</summary>
        public static string Numero_Interior_de_los_Hechos_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Numero_Interior_de_los_Hechos_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_MPI</summary>
        public static string Latitud_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Latitud_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_MPI</summary>
        public static string Longitud_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Longitud_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar_del_Hecho_MPI</summary>
        public static string Tipo_de_Lugar_del_Hecho_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Tipo_de_Lugar_del_Hecho_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_Moral</summary>
        public static string Persona_Moral
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Persona_Moral", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requiere_Diligencia</summary>
        public static string Requiere_Diligencia
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Requiere_Diligencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente_Victima</summary>
        public static string Numero_de_Expediente_Victima
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Numero_de_Expediente_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_de_la_Persona_Moral</summary>
        public static string Datos_de_la_Persona_Moral
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Datos_de_la_Persona_Moral", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requiere_Traductor</summary>
        public static string Requiere_Traductor
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Requiere_Traductor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lengua_Originaria</summary>
        public static string Lengua_Originaria
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Lengua_Originaria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Idioma</summary>
        public static string Idioma
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Idioma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicios_de_Apoyo</summary>
        public static string Servicios_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Servicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Hecho</summary>
        public static string Titulo_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Titulo_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_del_Testigo</summary>
        public static string Datos_del_Testigo
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Datos_del_Testigo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Asignar_Agente_del_Ministerio_Publico</summary>
        public static string Asignar_Agente_del_Ministerio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Asignar_Agente_del_Ministerio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Agente_del_Ministerio_Publico</summary>
        public static string Nombre_de_Agente_del_Ministerio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Nombre_de_Agente_del_Ministerio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agentes_del_Ministerio_Publico</summary>
        public static string Agentes_del_Ministerio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Agentes_del_Ministerio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Oficio</summary>
        public static string Tipo_de_Oficio
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Tipo_de_Oficio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delegacion</summary>
        public static string Delegacion
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Delegacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agencia</summary>
        public static string Agencia
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Agencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitar_Diligencias</summary>
        public static string Solicitar_Diligencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Solicitar_Diligencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicios_Periciales</summary>
        public static string Servicios_Periciales
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Servicios_Periciales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Oficios</summary>
        public static string Oficios
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Oficios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>IPH</summary>
        public static string IPH
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("IPH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUC_Audiencias</summary>
        public static string NUC_Audiencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("NUC_Audiencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NIC_Audiencias</summary>
        public static string NIC_Audiencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("NIC_Audiencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro_Audiencias</summary>
        public static string Fecha_de_Registro_Audiencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Fecha_de_Registro_Audiencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro_Audiencias</summary>
        public static string Hora_de_Registro_Audiencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Hora_de_Registro_Audiencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Oficio_Audiencias</summary>
        public static string Tipo_de_Oficio_Audiencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Tipo_de_Oficio_Audiencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delegacion_Audiencias</summary>
        public static string Delegacion_Audiencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Delegacion_Audiencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Domicilio_Delegacion_A</summary>
        public static string Domicilio_Delegacion_A
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Domicilio_Delegacion_A", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitante_Audiencias</summary>
        public static string Solicitante_Audiencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Solicitante_Audiencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requerido_Audiencias</summary>
        public static string Requerido_Audiencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Requerido_Audiencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Citatorio_Audiencias</summary>
        public static string Citatorio_Audiencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Citatorio_Audiencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documentos_MPI</summary>
        public static string Documentos_MPI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Documentos_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Coincidencias</summary>
        public static string Coincidencias
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Coincidencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT</summary>
        public static string NUAT
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_RegistroI</summary>
        public static string Fecha_de_RegistroI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Fecha_de_RegistroI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_RegistroI</summary>
        public static string Hora_de_RegistroI
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Hora_de_RegistroI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Indicio</summary>
        public static string Indicio
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Canalizar_a</summary>
        public static string Canalizar_a
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Canalizar_a", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Bitacora_de_Canalizacion</summary>
        public static string Bitacora_de_Canalizacion
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Bitacora_de_Canalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito_Principal</summary>
        public static string Delito_Principal
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Delito_Principal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Acuerdo</summary>
        public static string Tipo_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Tipo_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Inicio_de_Acuerdo</summary>
        public static string Fecha_de_Inicio_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Fecha_de_Inicio_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cumplimiento</summary>
        public static string Fecha_de_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Fecha_de_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Cumplimiento</summary>
        public static string Hora_de_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Hora_de_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Domicilio_para_el_Cumplimiento</summary>
        public static string Domicilio_para_el_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Domicilio_para_el_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_de_Reparacion_de_Danos</summary>
        public static string Monto_de_Reparacion_de_Danos
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Monto_de_Reparacion_de_Danos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Parcialidades</summary>
        public static string Parcialidades
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Parcialidades", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Periodicidad</summary>
        public static string Periodicidad
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Periodicidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Acepta_Acuerdo</summary>
        public static string Acepta_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Acepta_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Rechazo_de_Acuerdo</summary>
        public static string Motivo_de_Rechazo_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderExpediente_Inicial.GetResource("Motivo_de_Rechazo_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos del Caso</summary>	public static string TabDatos_del_Caso 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabDatos_del_Caso", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de la Víctima</summary>	public static string TabDatos_de_la_Victima 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabDatos_de_la_Victima", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Imputado</summary>	public static string TabDatos_del_Imputado 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabDatos_del_Imputado", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Delito</summary>	public static string TabDatos_del_Delito 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabDatos_del_Delito", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de los Hechos</summary>	public static string TabDatos_de_los_Hechos 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabDatos_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de la Persona Moral</summary>	public static string TabDatos_de_la_Persona_Moral 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabDatos_de_la_Persona_Moral", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Servicios de Apoyo</summary>	public static string TabServicios_de_Apoyo 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabServicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Testigo</summary>	public static string TabDatos_del_Testigo 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabDatos_del_Testigo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Asignar MP</summary>	public static string TabAsignar_MP 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabAsignar_MP", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Diligencias</summary>	public static string TabDiligencias 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabDiligencias", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>IPH</summary>	public static string TabIPH 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabIPH", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Agenda de Audiencias y Citatorios</summary>	public static string TabAgenda_de_Audiencias_y_Citatorios 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabAgenda_de_Audiencias_y_Citatorios", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Audiencias/Citatorios</summary>	public static string TabAudiencias_Citatorios 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabAudiencias_Citatorios", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Documentos</summary>	public static string TabDocumentos 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabDocumentos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Bitácora de Coincidencias</summary>	public static string TabBitacora_de_Coincidencias 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabBitacora_de_Coincidencias", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Indicios</summary>	public static string TabIndicios 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabIndicios", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Canalizar</summary>	public static string TabCanalizar 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabCanalizar", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Acuerdo</summary>	public static string TabDatos_del_Acuerdo 	{		get		{			SetPath();  			return resourceProviderExpediente_Inicial.GetResource("TabDatos_del_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
