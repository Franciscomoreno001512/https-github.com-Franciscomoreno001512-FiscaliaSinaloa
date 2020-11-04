using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Agente_del_Ministerio_PublicoResources
    {
        //private static IResourceProvider resourceProviderAgente_del_Ministerio_Publico = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Agente_del_Ministerio_PublicoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAgente_del_Ministerio_Publico = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Agente_del_Ministerio_PublicoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAgente_del_Ministerio_Publico = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Agente_del_Ministerio_PublicoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Agente_del_Ministerio_Publico</summary>
        public static string Agente_del_Ministerio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderAgente_del_Ministerio_Publico.GetResource("Agente_del_Ministerio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAgente_del_Ministerio_Publico.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAgente_del_Ministerio_Publico.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAgente_del_Ministerio_Publico.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
