using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Tipo_de_ComparecienteResources
    {
        //private static IResourceProvider resourceProviderTipo_de_Compareciente = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Tipo_de_ComparecienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderTipo_de_Compareciente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Tipo_de_ComparecienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderTipo_de_Compareciente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Tipo_de_ComparecienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Tipo_de_Compareciente</summary>
        public static string Tipo_de_Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderTipo_de_Compareciente.GetResource("Tipo_de_Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderTipo_de_Compareciente.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderTipo_de_Compareciente.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>TP_DescripcionCorta</summary>
        public static string TP_DescripcionCorta
        {
            get
            {
                SetPath();
                return resourceProviderTipo_de_Compareciente.GetResource("TP_DescripcionCorta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderTipo_de_Compareciente.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
