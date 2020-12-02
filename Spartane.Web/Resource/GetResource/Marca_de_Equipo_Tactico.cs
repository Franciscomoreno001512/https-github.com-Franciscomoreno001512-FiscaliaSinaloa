using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Marca_de_Equipo_TacticoResources
    {
        //private static IResourceProvider resourceProviderMarca_de_Equipo_Tactico = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Marca_de_Equipo_TacticoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderMarca_de_Equipo_Tactico = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Marca_de_Equipo_TacticoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderMarca_de_Equipo_Tactico = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Marca_de_Equipo_TacticoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Marca_de_Equipo_Tactico</summary>
        public static string Marca_de_Equipo_Tactico
        {
            get
            {
                SetPath();
                return resourceProviderMarca_de_Equipo_Tactico.GetResource("Marca_de_Equipo_Tactico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderMarca_de_Equipo_Tactico.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderMarca_de_Equipo_Tactico.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderMarca_de_Equipo_Tactico.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
