using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class DelegacionResources
    {
        //private static IResourceProvider resourceProviderDelegacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\DelegacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDelegacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\DelegacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDelegacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\DelegacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Delegacion</summary>
        public static string Delegacion
        {
            get
            {
                SetPath();
                return resourceProviderDelegacion.GetResource("Delegacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDelegacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDelegacion.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Zona</summary>
        public static string Zona
        {
            get
            {
                SetPath();
                return resourceProviderDelegacion.GetResource("Zona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_Expediente</summary>
        public static string Clave_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderDelegacion.GetResource("Clave_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Direccion</summary>
        public static string Direccion
        {
            get
            {
                SetPath();
                return resourceProviderDelegacion.GetResource("Direccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecutivo_MPO</summary>
        public static string Consecutivo_MPO
        {
            get
            {
                SetPath();
                return resourceProviderDelegacion.GetResource("Consecutivo_MPO", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecutivo_MPI</summary>
        public static string Consecutivo_MPI
        {
            get
            {
                SetPath();
                return resourceProviderDelegacion.GetResource("Consecutivo_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Distrito</summary>
        public static string Distrito
        {
            get
            {
                SetPath();
                return resourceProviderDelegacion.GetResource("Distrito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Abreviacion_Delegacion</summary>
        public static string Abreviacion_Delegacion
        {
            get
            {
                SetPath();
                return resourceProviderDelegacion.GetResource("Abreviacion_Delegacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDelegacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
