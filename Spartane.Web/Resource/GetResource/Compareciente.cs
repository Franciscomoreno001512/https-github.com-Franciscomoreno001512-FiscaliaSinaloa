using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class ComparecienteResources
    {
        //private static IResourceProvider resourceProviderCompareciente = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\ComparecienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCompareciente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ComparecienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCompareciente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ComparecienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Compareciente</summary>
        public static string Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Registro_de_Atencion_Inicial</summary>
        public static string Registro_de_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("Registro_de_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCompareciente.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
