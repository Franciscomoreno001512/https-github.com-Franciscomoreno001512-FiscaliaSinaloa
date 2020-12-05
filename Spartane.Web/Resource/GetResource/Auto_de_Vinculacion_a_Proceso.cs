using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Auto_de_Vinculacion_a_ProcesoResources
    {
        //private static IResourceProvider resourceProviderAuto_de_Vinculacion_a_Proceso = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Auto_de_Vinculacion_a_ProcesoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAuto_de_Vinculacion_a_Proceso = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Auto_de_Vinculacion_a_ProcesoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAuto_de_Vinculacion_a_Proceso = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Auto_de_Vinculacion_a_ProcesoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Auto_de_Vinculacion_a_Proceso</summary>
        public static string Auto_de_Vinculacion_a_Proceso
        {
            get
            {
                SetPath();
                return resourceProviderAuto_de_Vinculacion_a_Proceso.GetResource("Auto_de_Vinculacion_a_Proceso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAuto_de_Vinculacion_a_Proceso.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAuto_de_Vinculacion_a_Proceso.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAuto_de_Vinculacion_a_Proceso.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
