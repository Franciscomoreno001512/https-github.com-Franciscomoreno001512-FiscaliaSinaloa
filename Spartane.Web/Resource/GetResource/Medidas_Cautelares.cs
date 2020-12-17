using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Medidas_CautelaresResources
    {
        //private static IResourceProvider resourceProviderMedidas_Cautelares = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Medidas_CautelaresResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderMedidas_Cautelares = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Medidas_CautelaresResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderMedidas_Cautelares = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Medidas_CautelaresResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Medidas_Cautelares</summary>
        public static string Medidas_Cautelares
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_Cautelares.GetResource("Medidas_Cautelares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_Cautelares.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_Cautelares.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fraccion</summary>
        public static string Fraccion
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_Cautelares.GetResource("Fraccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Aplica_para_Adolescentes</summary>
        public static string Aplica_para_Adolescentes
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_Cautelares.GetResource("Aplica_para_Adolescentes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Aplica_para_Adultos</summary>
        public static string Aplica_para_Adultos
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_Cautelares.GetResource("Aplica_para_Adultos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_Cautelares.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderMedidas_Cautelares.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
