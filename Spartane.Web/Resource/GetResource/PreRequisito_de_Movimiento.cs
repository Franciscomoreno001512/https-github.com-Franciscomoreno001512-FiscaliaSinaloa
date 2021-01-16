using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class PreRequisito_de_MovimientoResources
    {
        //private static IResourceProvider resourceProviderPreRequisito_de_Movimiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\PreRequisito_de_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderPreRequisito_de_Movimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\PreRequisito_de_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderPreRequisito_de_Movimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\PreRequisito_de_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>PreRequisito_de_Movimiento</summary>
        public static string PreRequisito_de_Movimiento
        {
            get
            {
                SetPath();
                return resourceProviderPreRequisito_de_Movimiento.GetResource("PreRequisito_de_Movimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderPreRequisito_de_Movimiento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>PreRequisito</summary>
        public static string PreRequisito
        {
            get
            {
                SetPath();
                return resourceProviderPreRequisito_de_Movimiento.GetResource("PreRequisito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderPreRequisito_de_Movimiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
