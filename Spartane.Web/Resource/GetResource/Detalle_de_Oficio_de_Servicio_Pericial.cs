using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Oficio_de_Servicio_PericialResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Oficio_de_Servicio_Pericial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Oficio_de_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Oficio_de_Servicio_Pericial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Oficio_de_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Oficio_de_Servicio_Pericial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Oficio_de_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Oficio_de_Servicio_Pericial</summary>
        public static string Detalle_de_Oficio_de_Servicio_Pericial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Oficio_de_Servicio_Pericial.GetResource("Detalle_de_Oficio_de_Servicio_Pericial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Oficio_de_Servicio_Pericial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Oficio</summary>
        public static string Oficio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Oficio_de_Servicio_Pericial.GetResource("Oficio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicio_Pericial</summary>
        public static string Servicio_Pericial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Oficio_de_Servicio_Pericial.GetResource("Servicio_Pericial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Oficio_de_Servicio_Pericial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
