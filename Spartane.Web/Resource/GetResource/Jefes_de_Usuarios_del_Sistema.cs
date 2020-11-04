using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Jefes_de_Usuarios_del_SistemaResources
    {
        //private static IResourceProvider resourceProviderJefes_de_Usuarios_del_Sistema = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Jefes_de_Usuarios_del_SistemaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderJefes_de_Usuarios_del_Sistema = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Jefes_de_Usuarios_del_SistemaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderJefes_de_Usuarios_del_Sistema = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Jefes_de_Usuarios_del_SistemaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Jefes_de_Usuarios_del_Sistema</summary>
        public static string Jefes_de_Usuarios_del_Sistema
        {
            get
            {
                SetPath();
                return resourceProviderJefes_de_Usuarios_del_Sistema.GetResource("Jefes_de_Usuarios_del_Sistema", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderJefes_de_Usuarios_del_Sistema.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderJefes_de_Usuarios_del_Sistema.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ministerio_Publico_en_Turno</summary>
        public static string Ministerio_Publico_en_Turno
        {
            get
            {
                SetPath();
                return resourceProviderJefes_de_Usuarios_del_Sistema.GetResource("Ministerio_Publico_en_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderJefes_de_Usuarios_del_Sistema.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigencia</summary>
        public static string Vigencia
        {
            get
            {
                SetPath();
                return resourceProviderJefes_de_Usuarios_del_Sistema.GetResource("Vigencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderJefes_de_Usuarios_del_Sistema.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderJefes_de_Usuarios_del_Sistema.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
