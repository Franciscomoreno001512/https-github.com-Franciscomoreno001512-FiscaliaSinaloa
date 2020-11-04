using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Registro_de_CoincidenciasResources
    {
        //private static IResourceProvider resourceProviderRegistro_de_Coincidencias = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Registro_de_CoincidenciasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRegistro_de_Coincidencias = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_CoincidenciasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRegistro_de_Coincidencias = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_CoincidenciasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Registro_de_Coincidencias</summary>
        public static string Registro_de_Coincidencias
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Coincidencias.GetResource("Registro_de_Coincidencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Coincidencias.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT</summary>
        public static string NUAT
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Coincidencias.GetResource("NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Coincidencias</summary>
        public static string Numero_de_Coincidencias
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Coincidencias.GetResource("Numero_de_Coincidencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Coincidencias</summary>
        public static string Coincidencias
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Coincidencias.GetResource("Coincidencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Coincidencias.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
