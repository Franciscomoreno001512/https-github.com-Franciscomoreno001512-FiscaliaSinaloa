using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class SolicitudResources
    {
        //private static IResourceProvider resourceProviderSolicitud = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\SolicitudResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSolicitud = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\SolicitudResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSolicitud = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\SolicitudResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Folio</summary>
        public static string Numero_de_Folio
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Numero_de_Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_MASC</summary>
        public static string Unidad_MASC
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Unidad_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Remitente</summary>
        public static string Remitente
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Remitente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT</summary>
        public static string NUAT
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT_Codigo</summary>
        public static string NUAT_Codigo
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("NUAT_Codigo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MPI</summary>
        public static string Expediente_MPI
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Expediente_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_CausaPenal</summary>
        public static string Expediente_CausaPenal
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Expediente_CausaPenal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUC</summary>
        public static string NUC
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("NUC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CDI</summary>
        public static string CDI
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("CDI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Causa_Penal</summary>
        public static string Causa_Penal
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Causa_Penal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_en_que_llega_a_Coordinador</summary>
        public static string Fecha_en_que_llega_a_Coordinador
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Fecha_en_que_llega_a_Coordinador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_en_que_llega_a_Especialista</summary>
        public static string Fecha_en_que_llega_a_Especialista
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Fecha_en_que_llega_a_Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agente_del_Ministerio_Publico_Orientador</summary>
        public static string Agente_del_Ministerio_Publico_Orientador
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Agente_del_Ministerio_Publico_Orientador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agente_del_Ministerio_Publico_Invest</summary>
        public static string Agente_del_Ministerio_Publico_Invest
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Agente_del_Ministerio_Publico_Invest", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juez_de_Control</summary>
        public static string Juez_de_Control
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Juez_de_Control", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Hecho</summary>
        public static string Titulo_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Titulo_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_Breve_de_los_Hechos</summary>
        public static string Narrativa_Breve_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Narrativa_Breve_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Aproximada_del_Hecho</summary>
        public static string Hora_Aproximada_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Hora_Aproximada_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar_del_Hecho</summary>
        public static string Tipo_de_Lugar_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Tipo_de_Lugar_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>PaisH</summary>
        public static string PaisH
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("PaisH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>EstadoH</summary>
        public static string EstadoH
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("EstadoH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>MunicipioH</summary>
        public static string MunicipioH
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("MunicipioH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ColoniaH</summary>
        public static string ColoniaH
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("ColoniaH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CalleH</summary>
        public static string CalleH
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("CalleH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_InteriorH</summary>
        public static string Numero_InteriorH
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Numero_InteriorH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_ExteriorH</summary>
        public static string Numero_ExteriorH
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Numero_ExteriorH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_PostalH</summary>
        public static string Codigo_PostalH
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Codigo_PostalH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>y_Calle</summary>
        public static string y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>LongitudH</summary>
        public static string LongitudH
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("LongitudH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>LatitudH</summary>
        public static string LatitudH
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("LatitudH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialista_AsignadoA</summary>
        public static string Especialista_AsignadoA
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Especialista_AsignadoA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_cambio_facilitador</summary>
        public static string Motivo_cambio_facilitador
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Motivo_cambio_facilitador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Asignar_Especialista_Automatico</summary>
        public static string Asignar_Especialista_Automatico
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Asignar_Especialista_Automatico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Razone</summary>
        public static string Razone
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Razone", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_AsignacionA</summary>
        public static string Fecha_de_AsignacionA
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Fecha_de_AsignacionA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_AsignacionA</summary>
        public static string Hora_de_AsignacionA
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Hora_de_AsignacionA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Atencion_del_Especialista</summary>
        public static string Fecha_de_Atencion_del_Especialista
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Fecha_de_Atencion_del_Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Atencion_del_Especialista</summary>
        public static string Hora_de_Atencion_del_Especialista
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Hora_de_Atencion_del_Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Historial_de_Asignaciones</summary>
        public static string Historial_de_Asignaciones
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Historial_de_Asignaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Rechazar</summary>
        public static string Rechazar
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Rechazar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Rechazo</summary>
        public static string Motivo_de_Rechazo
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Motivo_de_Rechazo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Acuerdo_Cumplido</summary>
        public static string Acuerdo_Cumplido
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Acuerdo_Cumplido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Razon_de_Incumplimiento</summary>
        public static string Razon_de_Incumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Razon_de_Incumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Conclusion_Anticipada</summary>
        public static string Tipo_de_Conclusion_Anticipada
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Tipo_de_Conclusion_Anticipada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cierre</summary>
        public static string Fecha_de_Cierre
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Fecha_de_Cierre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Cierre</summary>
        public static string Hora_de_Cierre
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Hora_de_Cierre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Resuelve_Solicitud</summary>
        public static string Usuario_que_Resuelve_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Usuario_que_Resuelve_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion_Solicitud</summary>
        public static string Resolucion_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Resolucion_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Mecanismo</summary>
        public static string Tipo_de_Mecanismo
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Tipo_de_Mecanismo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Solicitud</summary>
        public static string Observaciones_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Observaciones_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Validacion</summary>
        public static string Fecha_Validacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Fecha_Validacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Validacion</summary>
        public static string Hora_Validacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Hora_Validacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Valida</summary>
        public static string Usuario_que_Valida
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Usuario_que_Valida", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Autoriza_Cierre_de_Expediente</summary>
        public static string Autoriza_Cierre_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Autoriza_Cierre_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Rechazo_Solicitud</summary>
        public static string Motivo_de_Rechazo_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Motivo_de_Rechazo_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Resolucion_Procedimiento</summary>
        public static string Fecha_de_Resolucion_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Fecha_de_Resolucion_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Resolucion_Procedimiento</summary>
        public static string Hora_de_Resolucion_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Hora_de_Resolucion_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion_de_Procedimiento</summary>
        public static string Resolucion_de_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Resolucion_de_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Resuelve_Procedimiento</summary>
        public static string Usuario_que_Resuelve_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Usuario_que_Resuelve_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Procedimiento</summary>
        public static string Observaciones_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Observaciones_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Validacion_Procedimiento</summary>
        public static string Fecha_de_Validacion_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Fecha_de_Validacion_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Validacion_Procedimiento</summary>
        public static string Hora_de_Validacion_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Hora_de_Validacion_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Valida_Procedimiento</summary>
        public static string Usuario_que_Valida_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Usuario_que_Valida_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado_Procedimiento</summary>
        public static string Resultado_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Resultado_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Rechazo_Procedimiento</summary>
        public static string Motivo_de_Rechazo_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Motivo_de_Rechazo_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Coincidencias</summary>
        public static string Coincidencias
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Coincidencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Historial</summary>
        public static string Historial
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud.GetResource("Historial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Solicitud</summary>	public static string TabSolicitud 	{		get		{			SetPath();  			return resourceProviderSolicitud.GetResource("TabSolicitud", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Control</summary>	public static string TabControl 	{		get		{			SetPath();  			return resourceProviderSolicitud.GetResource("TabControl", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Hechos</summary>	public static string TabHechos 	{		get		{			SetPath();  			return resourceProviderSolicitud.GetResource("TabHechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Asignación</summary>	public static string TabAsignacion 	{		get		{			SetPath();  			return resourceProviderSolicitud.GetResource("TabAsignacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Resolución de Solicitud</summary>	public static string TabResolucion_de_Solicitud 	{		get		{			SetPath();  			return resourceProviderSolicitud.GetResource("TabResolucion_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Resolución de Procedimiento</summary>	public static string TabResolucion_de_Procedimiento 	{		get		{			SetPath();  			return resourceProviderSolicitud.GetResource("TabResolucion_de_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Bitácora de Coincidencias</summary>	public static string TabBitacora_de_Coincidencias 	{		get		{			SetPath();  			return resourceProviderSolicitud.GetResource("TabBitacora_de_Coincidencias", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Historial de Movimientos</summary>	public static string TabHistorial_de_Movimientos 	{		get		{			SetPath();  			return resourceProviderSolicitud.GetResource("TabHistorial_de_Movimientos", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
