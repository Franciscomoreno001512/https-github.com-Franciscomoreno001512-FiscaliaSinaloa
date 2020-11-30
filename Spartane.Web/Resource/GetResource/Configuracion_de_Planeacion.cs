using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Configuracion_de_PlaneacionResources
    {
        //private static IResourceProvider resourceProviderConfiguracion_de_Planeacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Configuracion_de_PlaneacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderConfiguracion_de_Planeacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Configuracion_de_PlaneacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderConfiguracion_de_Planeacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Configuracion_de_PlaneacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Configuracion_de_Planeacion</summary>
        public static string Configuracion_de_Planeacion
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Planeacion.GetResource("Configuracion_de_Planeacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Planeacion.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Categoria</summary>
        public static string Categoria
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Planeacion.GetResource("Categoria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicio</summary>
        public static string Servicio
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Planeacion.GetResource("Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entregable</summary>
        public static string Entregable
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Planeacion.GetResource("Entregable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tiempo_Estandar</summary>
        public static string Tiempo_Estandar
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Planeacion.GetResource("Tiempo_Estandar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ponderacion</summary>
        public static string Ponderacion
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Planeacion.GetResource("Ponderacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderConfiguracion_de_Planeacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
