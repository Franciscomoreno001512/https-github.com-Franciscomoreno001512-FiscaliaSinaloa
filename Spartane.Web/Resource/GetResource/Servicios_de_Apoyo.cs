using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Servicios_de_ApoyoResources
    {
        //private static IResourceProvider resourceProviderServicios_de_Apoyo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderServicios_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderServicios_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Servicios_de_Apoyo</summary>
        public static string Servicios_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Servicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Justicia_Alternativa</summary>
        public static string Justicia_Alternativa
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Justicia_Alternativa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medios_Alternativos</summary>
        public static string Medios_Alternativos
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Medios_Alternativos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo</summary>
        public static string Motivo
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Motivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Derechos</summary>
        public static string Derechos
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Derechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Procedimiento</summary>
        public static string Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicita_Medios_Alternativos</summary>
        public static string Solicita_Medios_Alternativos
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Solicita_Medios_Alternativos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Se_Canaliza</summary>
        public static string Se_Canaliza
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Se_Canaliza", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Investigacion_con_Detenido</summary>
        public static string Investigacion_con_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Investigacion_con_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Investigacion_sin_Detenido</summary>
        public static string Investigacion_sin_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Investigacion_sin_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Turnar_a_Justicia_Alternativa</summary>
        public static string Turnar_a_Justicia_Alternativa
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Turnar_a_Justicia_Alternativa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Instancia_Externa</summary>
        public static string Instancia_Externa
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo.GetResource("Instancia_Externa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderServicios_de_Apoyo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
