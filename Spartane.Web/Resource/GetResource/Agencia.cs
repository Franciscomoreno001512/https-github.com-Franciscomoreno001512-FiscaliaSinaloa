using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class AgenciaResources
    {
        //private static IResourceProvider resourceProviderAgencia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\AgenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAgencia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\AgenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAgencia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\AgenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Agencia</summary>
        public static string Agencia
        {
            get
            {
                SetPath();
                return resourceProviderAgencia.GetResource("Agencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAgencia.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_de_Municipio</summary>
        public static string Clave_de_Municipio
        {
            get
            {
                SetPath();
                return resourceProviderAgencia.GetResource("Clave_de_Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAgencia.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Activa</summary>
        public static string Activa
        {
            get
            {
                SetPath();
                return resourceProviderAgencia.GetResource("Activa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ClaveID</summary>
        public static string ClaveID
        {
            get
            {
                SetPath();
                return resourceProviderAgencia.GetResource("ClaveID", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAgencia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
