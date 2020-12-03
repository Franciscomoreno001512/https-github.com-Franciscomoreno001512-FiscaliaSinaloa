using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Condiciones_en_Suspension_CondicionalResources
    {
        //private static IResourceProvider resourceProviderCondiciones_en_Suspension_Condicional = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Condiciones_en_Suspension_CondicionalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCondiciones_en_Suspension_Condicional = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Condiciones_en_Suspension_CondicionalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCondiciones_en_Suspension_Condicional = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Condiciones_en_Suspension_CondicionalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Condiciones_en_Suspension_Condicional</summary>
        public static string Condiciones_en_Suspension_Condicional
        {
            get
            {
                SetPath();
                return resourceProviderCondiciones_en_Suspension_Condicional.GetResource("Condiciones_en_Suspension_Condicional", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCondiciones_en_Suspension_Condicional.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderCondiciones_en_Suspension_Condicional.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCondiciones_en_Suspension_Condicional.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
