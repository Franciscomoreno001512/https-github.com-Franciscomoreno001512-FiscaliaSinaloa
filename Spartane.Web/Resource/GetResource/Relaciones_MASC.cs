using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Relaciones_MASCResources
    {
        //private static IResourceProvider resourceProviderRelaciones_MASC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Relaciones_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRelaciones_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Relaciones_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRelaciones_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Relaciones_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Relaciones_MASC</summary>
        public static string Relaciones_MASC
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Relaciones_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Procedimiento</summary>
        public static string Numero_de_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Numero_de_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Relacion</summary>
        public static string Relacion
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Relacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idRelacionOrigen</summary>
        public static string idRelacionOrigen
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("idRelacionOrigen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requiere_cambiar_la_relacion</summary>
        public static string Requiere_cambiar_la_relacion
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Requiere_cambiar_la_relacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Cambio</summary>
        public static string Motivo_de_Cambio
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Motivo_de_Cambio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Resolucion_solicitud</summary>
        public static string Fecha_de_Resolucion_solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Fecha_de_Resolucion_solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Resolucion_solicitud</summary>
        public static string Hora_de_Resolucion_solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Hora_de_Resolucion_solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Resuelve_solicitud</summary>
        public static string Usuario_que_Resuelve_solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Usuario_que_Resuelve_solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion</summary>
        public static string Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Mecanismo</summary>
        public static string Tipo_de_Mecanismo
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Tipo_de_Mecanismo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_solicitud</summary>
        public static string Observaciones_solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Observaciones_solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Validacion_solicitud</summary>
        public static string Fecha_de_Validacion_solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Fecha_de_Validacion_solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Validacion_solicitud</summary>
        public static string Hora_de_Validacion_solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Hora_de_Validacion_solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Valida_solicitud</summary>
        public static string Usuario_que_Valida_solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Usuario_que_Valida_solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>resultado_solicitud</summary>
        public static string resultado_solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("resultado_solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>motivo_rechazo_solicitud</summary>
        public static string motivo_rechazo_solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("motivo_rechazo_solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Resolucion_proc</summary>
        public static string Fecha_de_Resolucion_proc
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Fecha_de_Resolucion_proc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>hora_resolucion_proc</summary>
        public static string hora_resolucion_proc
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("hora_resolucion_proc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>usuario_resuelve_proc</summary>
        public static string usuario_resuelve_proc
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("usuario_resuelve_proc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion_proc</summary>
        public static string Resolucion_proc
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Resolucion_proc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_proc</summary>
        public static string Observaciones_proc
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Observaciones_proc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Validacion_proc</summary>
        public static string Fecha_de_Validacion_proc
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Fecha_de_Validacion_proc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Validacion_proc</summary>
        public static string Hora_de_Validacion_proc
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Hora_de_Validacion_proc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Valida_proc</summary>
        public static string Usuario_que_Valida_proc
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Usuario_que_Valida_proc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado_proc</summary>
        public static string Resultado_proc
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Resultado_proc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Rechazo_proc</summary>
        public static string Motivo_de_Rechazo_proc
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_MASC.GetResource("Motivo_de_Rechazo_proc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRelaciones_MASC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Resolución de Solicitud</summary>	public static string TabResolucion_de_Solicitud 	{		get		{			SetPath();  			return resourceProviderRelaciones_MASC.GetResource("TabResolucion_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Resolución de Procedimiento</summary>	public static string TabResolucion_de_Procedimiento 	{		get		{			SetPath();  			return resourceProviderRelaciones_MASC.GetResource("TabResolucion_de_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
