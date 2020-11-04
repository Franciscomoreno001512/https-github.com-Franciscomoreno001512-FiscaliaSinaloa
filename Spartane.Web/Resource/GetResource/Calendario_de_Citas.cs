using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Calendario_de_CitasResources
    {
        //private static IResourceProvider resourceProviderCalendario_de_Citas = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Calendario_de_CitasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCalendario_de_Citas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Calendario_de_CitasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCalendario_de_Citas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Calendario_de_CitasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Calendario_de_Citas</summary>
        public static string Calendario_de_Citas
        {
            get
            {
                SetPath();
                return resourceProviderCalendario_de_Citas.GetResource("Calendario_de_Citas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCalendario_de_Citas.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calendario_de_CitasC</summary>
        public static string Calendario_de_CitasC
        {
            get
            {
                SetPath();
                return resourceProviderCalendario_de_Citas.GetResource("Calendario_de_CitasC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pertenece_a</summary>
        public static string Pertenece_a
        {
            get
            {
                SetPath();
                return resourceProviderCalendario_de_Citas.GetResource("Pertenece_a", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCalendario_de_Citas.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
