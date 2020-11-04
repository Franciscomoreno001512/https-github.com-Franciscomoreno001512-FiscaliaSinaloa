using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Datos_Personales_Adicionales_Probable_ResponsableResources
    {
        //private static IResourceProvider resourceProviderDatos_Personales_Adicionales_Probable_Responsable = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Datos_Personales_Adicionales_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDatos_Personales_Adicionales_Probable_Responsable = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Datos_Personales_Adicionales_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDatos_Personales_Adicionales_Probable_Responsable = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Datos_Personales_Adicionales_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Datos_Personales_Adicionales_Probable_Responsable</summary>
        public static string Datos_Personales_Adicionales_Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDatos_Personales_Adicionales_Probable_Responsable.GetResource("Datos_Personales_Adicionales_Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDatos_Personales_Adicionales_Probable_Responsable.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderDatos_Personales_Adicionales_Probable_Responsable.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Telefonico</summary>
        public static string Numero_Telefonico
        {
            get
            {
                SetPath();
                return resourceProviderDatos_Personales_Adicionales_Probable_Responsable.GetResource("Numero_Telefonico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Redes_Sociales</summary>
        public static string Redes_Sociales
        {
            get
            {
                SetPath();
                return resourceProviderDatos_Personales_Adicionales_Probable_Responsable.GetResource("Redes_Sociales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDatos_Personales_Adicionales_Probable_Responsable.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDatos_Personales_Adicionales_Probable_Responsable.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
