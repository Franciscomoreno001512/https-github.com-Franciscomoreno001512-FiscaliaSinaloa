using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Marca_de_Equipo_de_ComunicacionResources
    {
        //private static IResourceProvider resourceProviderMarca_de_Equipo_de_Comunicacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Marca_de_Equipo_de_ComunicacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderMarca_de_Equipo_de_Comunicacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Marca_de_Equipo_de_ComunicacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderMarca_de_Equipo_de_Comunicacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Marca_de_Equipo_de_ComunicacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Marca_de_Equipo_de_Comunicacion</summary>
        public static string Marca_de_Equipo_de_Comunicacion
        {
            get
            {
                SetPath();
                return resourceProviderMarca_de_Equipo_de_Comunicacion.GetResource("Marca_de_Equipo_de_Comunicacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderMarca_de_Equipo_de_Comunicacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderMarca_de_Equipo_de_Comunicacion.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Equipo</summary>
        public static string Tipo_de_Equipo
        {
            get
            {
                SetPath();
                return resourceProviderMarca_de_Equipo_de_Comunicacion.GetResource("Tipo_de_Equipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderMarca_de_Equipo_de_Comunicacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
