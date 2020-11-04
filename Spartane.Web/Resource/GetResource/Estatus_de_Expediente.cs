using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Estatus_de_ExpedienteResources
    {
        //private static IResourceProvider resourceProviderEstatus_de_Expediente = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Estatus_de_ExpedienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderEstatus_de_Expediente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Estatus_de_ExpedienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderEstatus_de_Expediente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Estatus_de_ExpedienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Estatus_de_Expediente</summary>
        public static string Estatus_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Expediente.GetResource("Estatus_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Expediente.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_General</summary>
        public static string Estatus_General
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Expediente.GetResource("Estatus_General", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Especifico</summary>
        public static string Estatus_Especifico
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Expediente.GetResource("Estatus_Especifico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Tipo_Caso</summary>
        public static string Estatus_Tipo_Caso
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Expediente.GetResource("Estatus_Tipo_Caso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Descripcion_General</summary>
        public static string Estatus_Descripcion_General
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Expediente.GetResource("Estatus_Descripcion_General", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Descripcion_Especifico</summary>
        public static string Estatus_Descripcion_Especifico
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Expediente.GetResource("Estatus_Descripcion_Especifico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Completo</summary>
        public static string Estatus_Completo
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Expediente.GetResource("Estatus_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderEstatus_de_Expediente.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
