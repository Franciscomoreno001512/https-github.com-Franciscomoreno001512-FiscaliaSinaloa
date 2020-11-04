using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Otras_Identificaciones_Solicitante_MASCResources
    {
        //private static IResourceProvider resourceProviderOtras_Identificaciones_Solicitante_MASC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Otras_Identificaciones_Solicitante_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderOtras_Identificaciones_Solicitante_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Otras_Identificaciones_Solicitante_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderOtras_Identificaciones_Solicitante_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Otras_Identificaciones_Solicitante_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Otras_Identificaciones_Solicitante_MASC</summary>
        public static string Otras_Identificaciones_Solicitante_MASC
        {
            get
            {
                SetPath();
                return resourceProviderOtras_Identificaciones_Solicitante_MASC.GetResource("Otras_Identificaciones_Solicitante_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderOtras_Identificaciones_Solicitante_MASC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderOtras_Identificaciones_Solicitante_MASC.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderOtras_Identificaciones_Solicitante_MASC.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderOtras_Identificaciones_Solicitante_MASC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
