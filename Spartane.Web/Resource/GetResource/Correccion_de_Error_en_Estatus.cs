using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Correccion_de_Error_en_EstatusResources
    {
        //private static IResourceProvider resourceProviderCorreccion_de_Error_en_Estatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Correccion_de_Error_en_EstatusResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCorreccion_de_Error_en_Estatus = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Correccion_de_Error_en_EstatusResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCorreccion_de_Error_en_Estatus = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Correccion_de_Error_en_EstatusResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Correccion_de_Error_en_Estatus</summary>
        public static string Correccion_de_Error_en_Estatus
        {
            get
            {
                SetPath();
                return resourceProviderCorreccion_de_Error_en_Estatus.GetResource("Correccion_de_Error_en_Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCorreccion_de_Error_en_Estatus.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT</summary>
        public static string NUAT
        {
            get
            {
                SetPath();
                return resourceProviderCorreccion_de_Error_en_Estatus.GetResource("NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Actual</summary>
        public static string Estatus_Actual
        {
            get
            {
                SetPath();
                return resourceProviderCorreccion_de_Error_en_Estatus.GetResource("Estatus_Actual", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_a_Cambiar</summary>
        public static string Estatus_a_Cambiar
        {
            get
            {
                SetPath();
                return resourceProviderCorreccion_de_Error_en_Estatus.GetResource("Estatus_a_Cambiar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo</summary>
        public static string Motivo
        {
            get
            {
                SetPath();
                return resourceProviderCorreccion_de_Error_en_Estatus.GetResource("Motivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCorreccion_de_Error_en_Estatus.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
