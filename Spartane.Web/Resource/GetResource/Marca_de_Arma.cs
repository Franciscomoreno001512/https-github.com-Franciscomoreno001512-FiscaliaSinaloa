using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Marca_de_ArmaResources
    {
        //private static IResourceProvider resourceProviderMarca_de_Arma = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Marca_de_ArmaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderMarca_de_Arma = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Marca_de_ArmaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderMarca_de_Arma = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Marca_de_ArmaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Marca_de_Arma</summary>
        public static string Marca_de_Arma
        {
            get
            {
                SetPath();
                return resourceProviderMarca_de_Arma.GetResource("Marca_de_Arma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderMarca_de_Arma.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderMarca_de_Arma.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderMarca_de_Arma.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
