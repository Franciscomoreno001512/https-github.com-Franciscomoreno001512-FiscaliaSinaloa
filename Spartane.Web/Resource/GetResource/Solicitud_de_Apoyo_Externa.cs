using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Solicitud_de_Apoyo_ExternaResources
    {
        //private static IResourceProvider resourceProviderSolicitud_de_Apoyo_Externa = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Solicitud_de_Apoyo_ExternaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSolicitud_de_Apoyo_Externa = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_Apoyo_ExternaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSolicitud_de_Apoyo_Externa = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_Apoyo_ExternaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Solicitud_de_Apoyo_Externa</summary>
        public static string Solicitud_de_Apoyo_Externa
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Solicitud_de_Apoyo_Externa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_registro</summary>
        public static string Hora_de_registro
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Hora_de_registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Anio</summary>
        public static string Anio
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Anio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Solicitud</summary>
        public static string Fecha_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Fecha_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Oficio_Externo</summary>
        public static string Numero_de_Oficio_Externo
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Numero_de_Oficio_Externo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitante</summary>
        public static string Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Rango</summary>
        public static string Rango
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Rango", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Autoridad_Externa</summary>
        public static string Autoridad_Externa
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Autoridad_Externa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narracion_Solicitud</summary>
        public static string Narracion_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Narracion_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Adjunto</summary>
        public static string Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Area_Asignada</summary>
        public static string Area_Asignada
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Area_Asignada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>SubArea_Asignada</summary>
        public static string SubArea_Asignada
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("SubArea_Asignada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictamen_Solicitado</summary>
        public static string Dictamen_Solicitado
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Dictamen_Solicitado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Contestacion</summary>
        public static string Fecha_de_Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Fecha_de_Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Contestacion</summary>
        public static string Hora_de_Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Hora_de_Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Responsable_que_Contesta</summary>
        public static string Responsable_que_Contesta
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Responsable_que_Contesta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>No__Contestacion</summary>
        public static string No__Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("No__Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictamen</summary>
        public static string Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ver_Documento</summary>
        public static string Ver_Documento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("Ver_Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Contestación</summary>	public static string TabContestacion 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Apoyo_Externa.GetResource("TabContestacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
