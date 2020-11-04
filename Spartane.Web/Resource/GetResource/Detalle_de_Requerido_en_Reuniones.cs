using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Requerido_en_ReunionesResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Requerido_en_Reuniones = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Requerido_en_ReunionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Requerido_en_Reuniones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Requerido_en_ReunionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Requerido_en_Reuniones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Requerido_en_ReunionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Requerido_en_Reuniones</summary>
        public static string Detalle_de_Requerido_en_Reuniones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Requerido_en_Reuniones.GetResource("Detalle_de_Requerido_en_Reuniones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Requerido_en_Reuniones.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Requerido_en_Reuniones.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Faltante</summary>
        public static string Faltante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Requerido_en_Reuniones.GetResource("Faltante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Requerido_en_Reuniones.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
