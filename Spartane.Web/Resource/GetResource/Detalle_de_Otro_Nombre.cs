using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Otro_NombreResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Otro_Nombre = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Otro_NombreResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Otro_Nombre = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Otro_NombreResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Otro_Nombre = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Otro_NombreResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Otro_Nombre</summary>
        public static string Detalle_de_Otro_Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Otro_Nombre.GetResource("Detalle_de_Otro_Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Otro_Nombre.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otro_Nombre_del_Individuo</summary>
        public static string Otro_Nombre_del_Individuo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Otro_Nombre.GetResource("Otro_Nombre_del_Individuo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otro_Apellido_Paterno_del_Individuo</summary>
        public static string Otro_Apellido_Paterno_del_Individuo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Otro_Nombre.GetResource("Otro_Apellido_Paterno_del_Individuo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otro_Apellido_Materno_del_Individuo</summary>
        public static string Otro_Apellido_Materno_del_Individuo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Otro_Nombre.GetResource("Otro_Apellido_Materno_del_Individuo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otro_Alias_del_Individuo</summary>
        public static string Otro_Alias_del_Individuo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Otro_Nombre.GetResource("Otro_Alias_del_Individuo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Otro_Nombre.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
