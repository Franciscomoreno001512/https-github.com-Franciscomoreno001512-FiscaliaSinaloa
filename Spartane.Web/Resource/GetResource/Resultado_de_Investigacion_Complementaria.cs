using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Resultado_de_Investigacion_ComplementariaResources
    {
        //private static IResourceProvider resourceProviderResultado_de_Investigacion_Complementaria = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Resultado_de_Investigacion_ComplementariaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderResultado_de_Investigacion_Complementaria = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Resultado_de_Investigacion_ComplementariaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderResultado_de_Investigacion_Complementaria = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Resultado_de_Investigacion_ComplementariaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Resultado_de_Investigacion_Complementaria</summary>
        public static string Resultado_de_Investigacion_Complementaria
        {
            get
            {
                SetPath();
                return resourceProviderResultado_de_Investigacion_Complementaria.GetResource("Resultado_de_Investigacion_Complementaria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderResultado_de_Investigacion_Complementaria.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderResultado_de_Investigacion_Complementaria.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderResultado_de_Investigacion_Complementaria.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
