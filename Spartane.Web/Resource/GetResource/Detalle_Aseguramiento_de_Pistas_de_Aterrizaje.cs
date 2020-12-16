using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Aseguramiento_de_Pistas_de_AterrizajeResources
    {
        //private static IResourceProvider resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Aseguramiento_de_Pistas_de_AterrizajeResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_de_Pistas_de_AterrizajeResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_de_Pistas_de_AterrizajeResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Aseguramiento_de_Pistas_de_Aterrizaje</summary>
        public static string Detalle_Aseguramiento_de_Pistas_de_Aterrizaje
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Detalle_Aseguramiento_de_Pistas_de_Aterrizaje", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Registro</summary>
        public static string Motivo_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Motivo_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Suelo</summary>
        public static string Suelo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Suelo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Localizacion_1</summary>
        public static string Localizacion_1
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Localizacion_1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Orientacion_de</summary>
        public static string Orientacion_de
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Orientacion_de", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Orientacion</summary>
        public static string Orientacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Orientacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Largo</summary>
        public static string Largo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Largo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ancho</summary>
        public static string Ancho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("Ancho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
