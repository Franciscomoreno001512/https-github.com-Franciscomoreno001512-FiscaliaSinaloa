using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Reporte_PrincipalResources
    {
        //private static IResourceProvider resourceProviderReporte_Principal = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Reporte_PrincipalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderReporte_Principal = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Reporte_PrincipalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderReporte_Principal = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Reporte_PrincipalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Reporte_Principal</summary>
        public static string Reporte_Principal
        {
            get
            {
                SetPath();
                return resourceProviderReporte_Principal.GetResource("Reporte_Principal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderReporte_Principal.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente</summary>
        public static string Expediente
        {
            get
            {
                SetPath();
                return resourceProviderReporte_Principal.GetResource("Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Total_de_Expedientes</summary>
        public static string Total_de_Expedientes
        {
            get
            {
                SetPath();
                return resourceProviderReporte_Principal.GetResource("Total_de_Expedientes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderReporte_Principal.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Caso</summary>
        public static string Numero_de_Caso
        {
            get
            {
                SetPath();
                return resourceProviderReporte_Principal.GetResource("Numero_de_Caso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Creciente</summary>
        public static string Creciente
        {
            get
            {
                SetPath();
                return resourceProviderReporte_Principal.GetResource("Creciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderReporte_Principal.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderReporte_Principal.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
