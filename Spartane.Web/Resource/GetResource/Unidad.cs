using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class UnidadResources
    {
        //private static IResourceProvider resourceProviderUnidad = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\UnidadResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderUnidad = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\UnidadResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderUnidad = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\UnidadResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_Unica_Municipio</summary>
        public static string Clave_Unica_Municipio
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Clave_Unica_Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_de_Municipio</summary>
        public static string Clave_de_Municipio
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Clave_de_Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_de_Region</summary>
        public static string Clave_de_Region
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Clave_de_Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Abreviacion</summary>
        public static string Abreviacion
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Abreviacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_Corta</summary>
        public static string Descripcion_Corta
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Descripcion_Corta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigencia</summary>
        public static string Vigencia
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Vigencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Direccion</summary>
        public static string Direccion
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Direccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Supervisor</summary>
        public static string Supervisor
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Supervisor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecutivo_CDI</summary>
        public static string Consecutivo_CDI
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Consecutivo_CDI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Asignacion_de_MP</summary>
        public static string Tipo_de_Asignacion_de_MP
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Tipo_de_Asignacion_de_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderUnidad.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
