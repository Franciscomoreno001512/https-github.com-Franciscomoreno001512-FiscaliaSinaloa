using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Spartan_Attribute_BypassResources
    {
        //private static IResourceProvider resourceProviderSpartan_Attribute_Bypass = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Spartan_Attribute_BypassResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSpartan_Attribute_Bypass = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Spartan_Attribute_BypassResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSpartan_Attribute_Bypass = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Spartan_Attribute_BypassResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Spartan_Attribute_Bypass</summary>
        public static string Spartan_Attribute_Bypass
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Attribute_Bypass.GetResource("Spartan_Attribute_Bypass", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>AttributeId</summary>
        public static string AttributeId
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Attribute_Bypass.GetResource("AttributeId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Description</summary>
        public static string Description
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Attribute_Bypass.GetResource("Description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ObjectId</summary>
        public static string ObjectId
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Attribute_Bypass.GetResource("ObjectId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSpartan_Attribute_Bypass.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
