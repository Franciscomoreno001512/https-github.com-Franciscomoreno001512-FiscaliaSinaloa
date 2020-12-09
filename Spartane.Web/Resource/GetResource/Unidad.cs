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

        /// <summary>Especialidad</summary>
        public static string Especialidad
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Especialidad", CultureInfo.CurrentUICulture.Name) as String;
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

        /// <summary>cod_pais</summary>
        public static string cod_pais
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("cod_pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cod_edo</summary>
        public static string cod_edo
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("cod_edo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cod_agencia</summary>
        public static string cod_agencia
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("cod_agencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>FTIPO</summary>
        public static string FTIPO
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("FTIPO", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>fcreada</summary>
        public static string fcreada
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("fcreada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>fbaja</summary>
        public static string fbaja
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("fbaja", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ULTAVREGIS</summary>
        public static string ULTAVREGIS
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("ULTAVREGIS", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>FUBICACION</summary>
        public static string FUBICACION
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("FUBICACION", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>vr_agen</summary>
        public static string vr_agen
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("vr_agen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especial</summary>
        public static string Especial
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Especial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>AgenAV</summary>
        public static string AgenAV
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("AgenAV", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>AgenUni_NSJP</summary>
        public static string AgenUni_NSJP
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("AgenUni_NSJP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nomenclatura</summary>
        public static string Nomenclatura
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Nomenclatura", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alcance</summary>
        public static string Alcance
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("Alcance", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ReceptorDeclinaciones</summary>
        public static string ReceptorDeclinaciones
        {
            get
            {
                SetPath();
                return resourceProviderUnidad.GetResource("ReceptorDeclinaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderUnidad.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
