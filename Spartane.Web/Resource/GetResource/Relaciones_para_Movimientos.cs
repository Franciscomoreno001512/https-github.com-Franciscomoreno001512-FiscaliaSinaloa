using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Relaciones_para_MovimientosResources
    {
        //private static IResourceProvider resourceProviderRelaciones_para_Movimientos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Relaciones_para_MovimientosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRelaciones_para_Movimientos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Relaciones_para_MovimientosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRelaciones_para_Movimientos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Relaciones_para_MovimientosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Relaciones_para_Movimientos</summary>
        public static string Relaciones_para_Movimientos
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_para_Movimientos.GetResource("Relaciones_para_Movimientos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ObjectId</summary>
        public static string ObjectId
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_para_Movimientos.GetResource("ObjectId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderRelaciones_para_Movimientos.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRelaciones_para_Movimientos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
