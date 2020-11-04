using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Agente_del_Ministerio_PublicoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Agente_del_Ministerio_Publico = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Agente_del_Ministerio_PublicoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Agente_del_Ministerio_Publico = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Agente_del_Ministerio_PublicoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Agente_del_Ministerio_Publico = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Agente_del_Ministerio_PublicoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Agente_del_Ministerio_Publico</summary>
        public static string Detalle_de_Agente_del_Ministerio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Agente_del_Ministerio_Publico.GetResource("Detalle_de_Agente_del_Ministerio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Agente_del_Ministerio_Publico.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agente_del_Ministerio_Publico</summary>
        public static string Agente_del_Ministerio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Agente_del_Ministerio_Publico.GetResource("Agente_del_Ministerio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Carga_de_Trabajo</summary>
        public static string Carga_de_Trabajo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Agente_del_Ministerio_Publico.GetResource("Carga_de_Trabajo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialidad</summary>
        public static string Especialidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Agente_del_Ministerio_Publico.GetResource("Especialidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Agente_del_Ministerio_Publico.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
