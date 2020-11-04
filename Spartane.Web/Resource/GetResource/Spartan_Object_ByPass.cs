using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Spartan_Object_ByPassResources
    {
        //private static IResourceProvider resourceProviderSpartan_Object_ByPass = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Spartan_Object_ByPassResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSpartan_Object_ByPass = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Spartan_Object_ByPassResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSpartan_Object_ByPass = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Spartan_Object_ByPassResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Spartan_Object_ByPass</summary>
        public static string Spartan_Object_ByPass
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Object_ByPass.GetResource("Spartan_Object_ByPass", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ObjectId</summary>
        public static string ObjectId
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Object_ByPass.GetResource("ObjectId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Description</summary>
        public static string Description
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Object_ByPass.GetResource("Description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSpartan_Object_ByPass.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
