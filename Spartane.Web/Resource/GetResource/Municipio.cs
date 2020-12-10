using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class MunicipioResources
    {
        //private static IResourceProvider resourceProviderMunicipio = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\MunicipioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderMunicipio = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\MunicipioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderMunicipio = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\MunicipioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Abreviacion</summary>
        public static string Abreviacion
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("Abreviacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigencia</summary>
        public static string Vigencia
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("Vigencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cod_pais</summary>
        public static string cod_pais
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("cod_pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cod_zona</summary>
        public static string cod_zona
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("cod_zona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>MuniNSJP</summary>
        public static string MuniNSJP
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("MuniNSJP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cod_zona_nsjp</summary>
        public static string cod_zona_nsjp
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("cod_zona_nsjp", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cod_mun</summary>
        public static string cod_mun
        {
            get
            {
                SetPath();
                return resourceProviderMunicipio.GetResource("cod_mun", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderMunicipio.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
