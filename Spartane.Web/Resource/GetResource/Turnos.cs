using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class TurnosResources
    {
        //private static IResourceProvider resourceProviderTurnos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\TurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderTurnos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\TurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderTurnos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\TurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Turnos</summary>
        public static string Turnos
        {
            get
            {
                SetPath();
                return resourceProviderTurnos.GetResource("Turnos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderTurnos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_de_Municipio</summary>
        public static string Clave_de_Municipio
        {
            get
            {
                SetPath();
                return resourceProviderTurnos.GetResource("Clave_de_Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderTurnos.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_de_Agencia</summary>
        public static string Clave_de_Agencia
        {
            get
            {
                SetPath();
                return resourceProviderTurnos.GetResource("Clave_de_Agencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_de_MunicipioAgencia</summary>
        public static string Clave_de_MunicipioAgencia
        {
            get
            {
                SetPath();
                return resourceProviderTurnos.GetResource("Clave_de_MunicipioAgencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Depende_de</summary>
        public static string Depende_de
        {
            get
            {
                SetPath();
                return resourceProviderTurnos.GetResource("Depende_de", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Activo</summary>
        public static string Activo
        {
            get
            {
                SetPath();
                return resourceProviderTurnos.GetResource("Activo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Prioridad</summary>
        public static string Prioridad
        {
            get
            {
                SetPath();
                return resourceProviderTurnos.GetResource("Prioridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderTurnos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
