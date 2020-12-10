using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class ColoniaResources
    {
        //private static IResourceProvider resourceProviderColonia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\ColoniaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderColonia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ColoniaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderColonia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ColoniaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Zona</summary>
        public static string Zona
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("Zona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigente</summary>
        public static string Vigente
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("Vigente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cod_pais</summary>
        public static string cod_pais
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("cod_pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cod_edo</summary>
        public static string cod_edo
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("cod_edo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>loc_justicia</summary>
        public static string loc_justicia
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("loc_justicia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>pob_justicia</summary>
        public static string pob_justicia
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("pob_justicia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>sector</summary>
        public static string sector
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("sector", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>estatus</summary>
        public static string estatus
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cod_localidad</summary>
        public static string cod_localidad
        {
            get
            {
                SetPath();
                return resourceProviderColonia.GetResource("cod_localidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderColonia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
