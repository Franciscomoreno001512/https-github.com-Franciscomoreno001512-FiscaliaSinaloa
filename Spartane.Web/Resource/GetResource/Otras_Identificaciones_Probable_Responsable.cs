using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Otras_Identificaciones_Probable_ResponsableResources
    {
        //private static IResourceProvider resourceProviderOtras_Identificaciones_Probable_Responsable = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Otras_Identificaciones_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderOtras_Identificaciones_Probable_Responsable = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Otras_Identificaciones_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderOtras_Identificaciones_Probable_Responsable = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Otras_Identificaciones_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Otras_Identificaciones_Probable_Responsable</summary>
        public static string Otras_Identificaciones_Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderOtras_Identificaciones_Probable_Responsable.GetResource("Otras_Identificaciones_Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderOtras_Identificaciones_Probable_Responsable.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_identificacion</summary>
        public static string Tipo_de_identificacion
        {
            get
            {
                SetPath();
                return resourceProviderOtras_Identificaciones_Probable_Responsable.GetResource("Tipo_de_identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderOtras_Identificaciones_Probable_Responsable.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderOtras_Identificaciones_Probable_Responsable.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
