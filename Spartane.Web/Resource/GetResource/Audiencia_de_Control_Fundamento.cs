using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Audiencia_de_Control_FundamentoResources
    {
        //private static IResourceProvider resourceProviderAudiencia_de_Control_Fundamento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Audiencia_de_Control_FundamentoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAudiencia_de_Control_Fundamento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Audiencia_de_Control_FundamentoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAudiencia_de_Control_Fundamento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Audiencia_de_Control_FundamentoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Audiencia_de_Control_Fundamento</summary>
        public static string Audiencia_de_Control_Fundamento
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_de_Control_Fundamento.GetResource("Audiencia_de_Control_Fundamento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_de_Control_Fundamento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_de_Control_Fundamento.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAudiencia_de_Control_Fundamento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
