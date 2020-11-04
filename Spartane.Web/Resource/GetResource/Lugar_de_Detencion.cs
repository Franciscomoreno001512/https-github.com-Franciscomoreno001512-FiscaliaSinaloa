using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Lugar_de_DetencionResources
    {
        //private static IResourceProvider resourceProviderLugar_de_Detencion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Lugar_de_DetencionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderLugar_de_Detencion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Lugar_de_DetencionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderLugar_de_Detencion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Lugar_de_DetencionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Lugar_de_Detencion</summary>
        public static string Lugar_de_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderLugar_de_Detencion.GetResource("Lugar_de_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderLugar_de_Detencion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Detencion</summary>
        public static string Fecha_de_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderLugar_de_Detencion.GetResource("Fecha_de_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_de_Detencion</summary>
        public static string Municipio_de_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderLugar_de_Detencion.GetResource("Municipio_de_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Corporacion</summary>
        public static string Corporacion
        {
            get
            {
                SetPath();
                return resourceProviderLugar_de_Detencion.GetResource("Corporacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Suspension_Condicional</summary>
        public static string Suspension_Condicional
        {
            get
            {
                SetPath();
                return resourceProviderLugar_de_Detencion.GetResource("Suspension_Condicional", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Suspension_Condicional</summary>
        public static string Fecha_de_Suspension_Condicional
        {
            get
            {
                SetPath();
                return resourceProviderLugar_de_Detencion.GetResource("Fecha_de_Suspension_Condicional", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderLugar_de_Detencion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
