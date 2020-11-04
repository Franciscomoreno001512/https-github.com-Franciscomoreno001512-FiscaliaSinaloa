using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class ModuloResources
    {
        //private static IResourceProvider resourceProviderModulo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\ModuloResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderModulo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ModuloResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderModulo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ModuloResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Modulo</summary>
        public static string Modulo
        {
            get
            {
                SetPath();
                return resourceProviderModulo.GetResource("Modulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderModulo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Modulo</summary>
        public static string Numero_de_Modulo
        {
            get
            {
                SetPath();
                return resourceProviderModulo.GetResource("Numero_de_Modulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderModulo.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_de_Atencion</summary>
        public static string Unidad_de_Atencion
        {
            get
            {
                SetPath();
                return resourceProviderModulo.GetResource("Unidad_de_Atencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Orientador</summary>
        public static string Orientador
        {
            get
            {
                SetPath();
                return resourceProviderModulo.GetResource("Orientador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderModulo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
