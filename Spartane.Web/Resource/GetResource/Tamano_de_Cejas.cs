using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Tamano_de_CejasResources
    {
        //private static IResourceProvider resourceProviderTamano_de_Cejas = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Tamano_de_CejasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderTamano_de_Cejas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Tamano_de_CejasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderTamano_de_Cejas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Tamano_de_CejasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Tamano_de_Cejas</summary>
        public static string Tamano_de_Cejas
        {
            get
            {
                SetPath();
                return resourceProviderTamano_de_Cejas.GetResource("Tamano_de_Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderTamano_de_Cejas.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderTamano_de_Cejas.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigencia</summary>
        public static string Vigencia
        {
            get
            {
                SetPath();
                return resourceProviderTamano_de_Cejas.GetResource("Vigencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderTamano_de_Cejas.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>LLAVE</summary>
        public static string LLAVE
        {
            get
            {
                SetPath();
                return resourceProviderTamano_de_Cejas.GetResource("LLAVE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderTamano_de_Cejas.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
