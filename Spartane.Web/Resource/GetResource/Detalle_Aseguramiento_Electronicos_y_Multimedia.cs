using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Aseguramiento_Electronicos_y_MultimediaResources
    {
        //private static IResourceProvider resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Aseguramiento_Electronicos_y_MultimediaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_Electronicos_y_MultimediaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_Electronicos_y_MultimediaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Aseguramiento_Electronicos_y_Multimedia</summary>
        public static string Detalle_Aseguramiento_Electronicos_y_Multimedia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia.GetResource("Detalle_Aseguramiento_Electronicos_y_Multimedia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Aparatos</summary>
        public static string Aparatos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia.GetResource("Aparatos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documentos_Multimedia</summary>
        public static string Documentos_Multimedia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia.GetResource("Documentos_Multimedia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad</summary>
        public static string Cantidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia.GetResource("Cantidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>A_resguardo</summary>
        public static string A_resguardo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia.GetResource("A_resguardo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Aseguramiento_Electronicos_y_Multimedia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
