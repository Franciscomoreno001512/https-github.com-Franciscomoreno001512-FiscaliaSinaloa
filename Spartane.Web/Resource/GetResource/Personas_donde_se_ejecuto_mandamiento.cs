using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Personas_donde_se_ejecuto_mandamientoResources
    {
        //private static IResourceProvider resourceProviderPersonas_donde_se_ejecuto_mandamiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Personas_donde_se_ejecuto_mandamientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderPersonas_donde_se_ejecuto_mandamiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Personas_donde_se_ejecuto_mandamientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderPersonas_donde_se_ejecuto_mandamiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Personas_donde_se_ejecuto_mandamientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Personas_donde_se_ejecuto_mandamiento</summary>
        public static string Personas_donde_se_ejecuto_mandamiento
        {
            get
            {
                SetPath();
                return resourceProviderPersonas_donde_se_ejecuto_mandamiento.GetResource("Personas_donde_se_ejecuto_mandamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderPersonas_donde_se_ejecuto_mandamiento.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona</summary>
        public static string Persona
        {
            get
            {
                SetPath();
                return resourceProviderPersonas_donde_se_ejecuto_mandamiento.GetResource("Persona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Seleccionar</summary>
        public static string Seleccionar
        {
            get
            {
                SetPath();
                return resourceProviderPersonas_donde_se_ejecuto_mandamiento.GetResource("Seleccionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>PersonaId</summary>
        public static string PersonaId
        {
            get
            {
                SetPath();
                return resourceProviderPersonas_donde_se_ejecuto_mandamiento.GetResource("PersonaId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderPersonas_donde_se_ejecuto_mandamiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
