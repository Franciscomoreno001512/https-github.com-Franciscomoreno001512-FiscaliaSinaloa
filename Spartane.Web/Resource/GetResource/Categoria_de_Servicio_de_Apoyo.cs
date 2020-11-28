using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Categoria_de_Servicio_de_ApoyoResources
    {
        //private static IResourceProvider resourceProviderCategoria_de_Servicio_de_Apoyo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Categoria_de_Servicio_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCategoria_de_Servicio_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Categoria_de_Servicio_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCategoria_de_Servicio_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Categoria_de_Servicio_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Categoria_de_Servicio_de_Apoyo</summary>
        public static string Categoria_de_Servicio_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderCategoria_de_Servicio_de_Apoyo.GetResource("Categoria_de_Servicio_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCategoria_de_Servicio_de_Apoyo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderCategoria_de_Servicio_de_Apoyo.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCategoria_de_Servicio_de_Apoyo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
