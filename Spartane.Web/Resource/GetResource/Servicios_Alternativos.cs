using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Servicios_AlternativosResources
    {
        //private static IResourceProvider resourceProviderServicios_Alternativos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Servicios_AlternativosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderServicios_Alternativos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Servicios_AlternativosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderServicios_Alternativos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Servicios_AlternativosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Servicios_Alternativos</summary>
        public static string Servicios_Alternativos
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Servicios_Alternativos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CJusticia_Alternativa</summary>
        public static string CJusticia_Alternativa
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("CJusticia_Alternativa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medios_Alternativos</summary>
        public static string Medios_Alternativos
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Medios_Alternativos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo</summary>
        public static string Motivo
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Motivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Derechos</summary>
        public static string Derechos
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Derechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Procedimiento</summary>
        public static string Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicita_Medios_Alternativos</summary>
        public static string Solicita_Medios_Alternativos
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Solicita_Medios_Alternativos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Se_Canaliza</summary>
        public static string Se_Canaliza
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Se_Canaliza", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Investigacion_con_Detenido</summary>
        public static string Investigacion_con_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Investigacion_con_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Investigacion_sin_Detenido</summary>
        public static string Investigacion_sin_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Investigacion_sin_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Turnar_a_Justicia_Alternativa</summary>
        public static string Turnar_a_Justicia_Alternativa
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Turnar_a_Justicia_Alternativa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Instancia_Externa</summary>
        public static string Instancia_Externa
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Alternativos.GetResource("Instancia_Externa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos de Canalización</summary>	public static string TabDatos_de_Canalizacion 	{		get		{			SetPath();  			return resourceProviderServicios_Alternativos.GetResource("TabDatos_de_Canalizacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
