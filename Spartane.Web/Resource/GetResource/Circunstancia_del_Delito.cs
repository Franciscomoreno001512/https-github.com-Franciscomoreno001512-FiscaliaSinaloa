using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Circunstancia_del_DelitoResources
    {
        //private static IResourceProvider resourceProviderCircunstancia_del_Delito = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Circunstancia_del_DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCircunstancia_del_Delito = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Circunstancia_del_DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCircunstancia_del_Delito = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Circunstancia_del_DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Circunstancia_del_Delito</summary>
        public static string Circunstancia_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancia_del_Delito.GetResource("Circunstancia_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancia_del_Delito.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Delito</summary>
        public static string Titulo_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancia_del_Delito.GetResource("Titulo_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grupo_del_Delito</summary>
        public static string Grupo_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancia_del_Delito.GetResource("Grupo_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito</summary>
        public static string Delito
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancia_del_Delito.GetResource("Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancia_del_Delito.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCircunstancia_del_Delito.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
