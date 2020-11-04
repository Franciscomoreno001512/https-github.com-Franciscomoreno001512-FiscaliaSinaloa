using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Folio_Asignado_de_UsuarioResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Folio_Asignado_de_Usuario = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Folio_Asignado_de_UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Folio_Asignado_de_Usuario = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Folio_Asignado_de_UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Folio_Asignado_de_Usuario = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Folio_Asignado_de_UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Folio_Asignado_de_Usuario</summary>
        public static string Detalle_de_Folio_Asignado_de_Usuario
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Folio_Asignado_de_Usuario.GetResource("Detalle_de_Folio_Asignado_de_Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Folio_Asignado_de_Usuario.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Folio_Asignado_de_Usuario.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_de_Folio</summary>
        public static string Estatus_de_Folio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Folio_Asignado_de_Usuario.GetResource("Estatus_de_Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Folio_Asignado_de_Usuario.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Folio_Asignado_de_Usuario.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
