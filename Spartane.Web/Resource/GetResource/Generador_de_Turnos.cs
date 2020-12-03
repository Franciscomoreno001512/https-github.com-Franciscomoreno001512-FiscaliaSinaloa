using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Generador_de_TurnosResources
    {
        //private static IResourceProvider resourceProviderGenerador_de_Turnos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Generador_de_TurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderGenerador_de_Turnos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Generador_de_TurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderGenerador_de_Turnos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Generador_de_TurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Generador_de_Turnos</summary>
        public static string Generador_de_Turnos
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_Turnos.GetResource("Generador_de_Turnos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_Turnos.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Generador_de_Turno</summary>
        public static string Fecha_de_Generador_de_Turno
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_Turnos.GetResource("Fecha_de_Generador_de_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Turno</summary>
        public static string Numero_de_Turno
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_Turnos.GetResource("Numero_de_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderGenerador_de_Turnos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
