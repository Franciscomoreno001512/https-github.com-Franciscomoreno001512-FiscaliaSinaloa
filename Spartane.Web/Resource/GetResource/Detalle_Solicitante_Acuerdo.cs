using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Solicitante_AcuerdoResources
    {
        //private static IResourceProvider resourceProviderDetalle_Solicitante_Acuerdo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Solicitante_AcuerdoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Solicitante_Acuerdo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Solicitante_AcuerdoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Solicitante_Acuerdo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Solicitante_AcuerdoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Solicitante_Acuerdo</summary>
        public static string Detalle_Solicitante_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitante_Acuerdo.GetResource("Detalle_Solicitante_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitante_Acuerdo.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitante</summary>
        public static string Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitante_Acuerdo.GetResource("Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Solicitante_Acuerdo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
