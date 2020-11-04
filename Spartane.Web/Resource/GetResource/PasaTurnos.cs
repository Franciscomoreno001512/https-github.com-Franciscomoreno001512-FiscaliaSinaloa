using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class PasaTurnosResources
    {
        //private static IResourceProvider resourceProviderPasaTurnos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\PasaTurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderPasaTurnos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\PasaTurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderPasaTurnos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\PasaTurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>PasaTurnos</summary>
        public static string PasaTurnos
        {
            get
            {
                SetPath();
                return resourceProviderPasaTurnos.GetResource("PasaTurnos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderPasaTurnos.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Turno</summary>
        public static string Turno
        {
            get
            {
                SetPath();
                return resourceProviderPasaTurnos.GetResource("Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo</summary>
        public static string Modulo
        {
            get
            {
                SetPath();
                return resourceProviderPasaTurnos.GetResource("Modulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderPasaTurnos.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderPasaTurnos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
