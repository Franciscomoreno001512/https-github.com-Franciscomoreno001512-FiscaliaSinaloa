using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Director_de_AgenciaResources
    {
        //private static IResourceProvider resourceProviderDirector_de_Agencia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Director_de_AgenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDirector_de_Agencia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Director_de_AgenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDirector_de_Agencia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Director_de_AgenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Director_de_Agencia</summary>
        public static string Director_de_Agencia
        {
            get
            {
                SetPath();
                return resourceProviderDirector_de_Agencia.GetResource("Director_de_Agencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDirector_de_Agencia.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Empleado</summary>
        public static string Numero_de_Empleado
        {
            get
            {
                SetPath();
                return resourceProviderDirector_de_Agencia.GetResource("Numero_de_Empleado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Empleado</summary>
        public static string Nombre_de_Empleado
        {
            get
            {
                SetPath();
                return resourceProviderDirector_de_Agencia.GetResource("Nombre_de_Empleado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDirector_de_Agencia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
