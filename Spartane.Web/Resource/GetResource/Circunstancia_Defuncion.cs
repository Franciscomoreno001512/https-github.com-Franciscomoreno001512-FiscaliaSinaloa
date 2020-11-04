using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Circunstancia_DefuncionResources
    {
        //private static IResourceProvider resourceProviderCircunstancia_Defuncion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Circunstancia_DefuncionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCircunstancia_Defuncion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Circunstancia_DefuncionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCircunstancia_Defuncion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Circunstancia_DefuncionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Circunstancia_Defuncion</summary>
        public static string Circunstancia_Defuncion
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancia_Defuncion.GetResource("Circunstancia_Defuncion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancia_Defuncion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancia_Defuncion.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Defuncion</summary>
        public static string Tipo_Defuncion
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancia_Defuncion.GetResource("Tipo_Defuncion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCircunstancia_Defuncion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
