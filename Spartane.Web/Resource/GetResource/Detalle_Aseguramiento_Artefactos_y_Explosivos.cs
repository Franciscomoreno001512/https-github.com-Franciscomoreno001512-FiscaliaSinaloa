using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Aseguramiento_Artefactos_y_ExplosivosResources
    {
        //private static IResourceProvider resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Aseguramiento_Artefactos_y_ExplosivosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_Artefactos_y_ExplosivosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_Artefactos_y_ExplosivosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Aseguramiento_Artefactos_y_Explosivos</summary>
        public static string Detalle_Aseguramiento_Artefactos_y_Explosivos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos.GetResource("Detalle_Aseguramiento_Artefactos_y_Explosivos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clasificacion</summary>
        public static string Clasificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos.GetResource("Clasificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad</summary>
        public static string Cantidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos.GetResource("Cantidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_de_Hallazgo</summary>
        public static string Lugar_de_Hallazgo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos.GetResource("Lugar_de_Hallazgo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Aseguramiento_Artefactos_y_Explosivos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
