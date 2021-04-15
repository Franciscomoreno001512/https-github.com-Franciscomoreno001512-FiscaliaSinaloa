using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Area_envia_CumplimientoResources
    {
        //private static IResourceProvider resourceProviderArea_envia_Cumplimiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Area_envia_CumplimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderArea_envia_Cumplimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Area_envia_CumplimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderArea_envia_Cumplimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Area_envia_CumplimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Area_envia_Cumplimiento</summary>
        public static string Area_envia_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderArea_envia_Cumplimiento.GetResource("Area_envia_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderArea_envia_Cumplimiento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderArea_envia_Cumplimiento.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigente</summary>
        public static string Vigente
        {
            get
            {
                SetPath();
                return resourceProviderArea_envia_Cumplimiento.GetResource("Vigente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderArea_envia_Cumplimiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
