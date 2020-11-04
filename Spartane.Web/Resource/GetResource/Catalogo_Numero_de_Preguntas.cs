using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Catalogo_Numero_de_PreguntasResources
    {
        //private static IResourceProvider resourceProviderCatalogo_Numero_de_Preguntas = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Catalogo_Numero_de_PreguntasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCatalogo_Numero_de_Preguntas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Catalogo_Numero_de_PreguntasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCatalogo_Numero_de_Preguntas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Catalogo_Numero_de_PreguntasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Catalogo_Numero_de_Preguntas</summary>
        public static string Catalogo_Numero_de_Preguntas
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_Numero_de_Preguntas.GetResource("Catalogo_Numero_de_Preguntas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_Numero_de_Preguntas.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_Numero_de_Preguntas.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCatalogo_Numero_de_Preguntas.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
