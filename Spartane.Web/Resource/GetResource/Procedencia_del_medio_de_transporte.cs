using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Procedencia_del_medio_de_transporteResources
    {
        //private static IResourceProvider resourceProviderProcedencia_del_medio_de_transporte = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Procedencia_del_medio_de_transporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderProcedencia_del_medio_de_transporte = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Procedencia_del_medio_de_transporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderProcedencia_del_medio_de_transporte = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Procedencia_del_medio_de_transporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Procedencia_del_medio_de_transporte</summary>
        public static string Procedencia_del_medio_de_transporte
        {
            get
            {
                SetPath();
                return resourceProviderProcedencia_del_medio_de_transporte.GetResource("Procedencia_del_medio_de_transporte", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderProcedencia_del_medio_de_transporte.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderProcedencia_del_medio_de_transporte.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderProcedencia_del_medio_de_transporte.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
