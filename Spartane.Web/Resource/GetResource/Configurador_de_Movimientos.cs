using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Configurador_de_MovimientosResources
    {
        //private static IResourceProvider resourceProviderConfigurador_de_Movimientos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Configurador_de_MovimientosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderConfigurador_de_Movimientos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Configurador_de_MovimientosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderConfigurador_de_Movimientos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Configurador_de_MovimientosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Configurador_de_Movimientos</summary>
        public static string Configurador_de_Movimientos
        {
            get
            {
                SetPath();
                return resourceProviderConfigurador_de_Movimientos.GetResource("Configurador_de_Movimientos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderConfigurador_de_Movimientos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderConfigurador_de_Movimientos.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fase</summary>
        public static string Fase
        {
            get
            {
                SetPath();
                return resourceProviderConfigurador_de_Movimientos.GetResource("Fase", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Aplica_para_Adolescentes</summary>
        public static string Aplica_para_Adolescentes
        {
            get
            {
                SetPath();
                return resourceProviderConfigurador_de_Movimientos.GetResource("Aplica_para_Adolescentes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_Adicionales</summary>
        public static string Datos_Adicionales
        {
            get
            {
                SetPath();
                return resourceProviderConfigurador_de_Movimientos.GetResource("Datos_Adicionales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderConfigurador_de_Movimientos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
