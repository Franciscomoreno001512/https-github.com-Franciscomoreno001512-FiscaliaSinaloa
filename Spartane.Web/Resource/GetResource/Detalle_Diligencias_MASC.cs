using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Diligencias_MASCResources
    {
        //private static IResourceProvider resourceProviderDetalle_Diligencias_MASC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Diligencias_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Diligencias_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Diligencias_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Diligencias_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Diligencias_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Diligencias_MASC</summary>
        public static string Detalle_Diligencias_MASC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_MASC.GetResource("Detalle_Diligencias_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_MASC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_MASC.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_MASC.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_MASC.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Facilitador</summary>
        public static string Facilitador
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_MASC.GetResource("Facilitador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Diligencia</summary>
        public static string Tipo_de_Diligencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_MASC.GetResource("Tipo_de_Diligencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencia</summary>
        public static string Diligencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_MASC.GetResource("Diligencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_MASC.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Diligencias_MASC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
