using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Servicio_de_ApoyoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Servicio_de_Apoyo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Servicio_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Servicio_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Servicio_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Servicio_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Servicio_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Servicio_de_Apoyo</summary>
        public static string Detalle_de_Servicio_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Detalle_de_Servicio_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_de_Atencion_Inicial</summary>
        public static string Modulo_de_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Modulo_de_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Servicio</summary>
        public static string Tipo_de_Servicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Tipo_de_Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requiere_Traductor</summary>
        public static string Requiere_Traductor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Requiere_Traductor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lengua_Originaria</summary>
        public static string Lengua_Originaria
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Lengua_Originaria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Idioma</summary>
        public static string Idioma
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Idioma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictamen</summary>
        public static string Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Responsable</summary>
        public static string Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Compareciente</summary>
        public static string Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
