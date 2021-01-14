using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Modulo_Servicio_PericialResources
    {
        //private static IResourceProvider resourceProviderModulo_Servicio_Pericial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Modulo_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderModulo_Servicio_Pericial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Modulo_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderModulo_Servicio_Pericial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Modulo_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Modulo_Servicio_Pericial</summary>
        public static string Modulo_Servicio_Pericial
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Servicio_Pericial.GetResource("Modulo_Servicio_Pericial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Servicio_Pericial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Atencion_Inicial</summary>
        public static string Modulo_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Servicio_Pericial.GetResource("Modulo_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Servicio_Pericial.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicio_Pericial</summary>
        public static string Servicio_Pericial
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Servicio_Pericial.GetResource("Servicio_Pericial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_Asignado</summary>
        public static string Usuario_Asignado
        {
            get
            {
                SetPath();
                return resourceProviderModulo_Servicio_Pericial.GetResource("Usuario_Asignado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderModulo_Servicio_Pericial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
