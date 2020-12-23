using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_FotosResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Fotos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_FotosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Fotos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_FotosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Fotos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_FotosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Fotos</summary>
        public static string Detalle_de_Fotos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Fotos.GetResource("Detalle_de_Fotos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Fotos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Foto_Perfil_Izquierdo</summary>
        public static string Foto_Perfil_Izquierdo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Fotos.GetResource("Foto_Perfil_Izquierdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Foto_Perfil_Derecho</summary>
        public static string Foto_Perfil_Derecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Fotos.GetResource("Foto_Perfil_Derecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Foto_de_Frente</summary>
        public static string Foto_de_Frente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Fotos.GetResource("Foto_de_Frente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Fotos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
