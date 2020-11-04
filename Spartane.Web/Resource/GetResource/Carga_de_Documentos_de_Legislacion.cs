using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Carga_de_Documentos_de_LegislacionResources
    {
        //private static IResourceProvider resourceProviderCarga_de_Documentos_de_Legislacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Carga_de_Documentos_de_LegislacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCarga_de_Documentos_de_Legislacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Carga_de_Documentos_de_LegislacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCarga_de_Documentos_de_Legislacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Carga_de_Documentos_de_LegislacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Carga_de_Documentos_de_Legislacion</summary>
        public static string Carga_de_Documentos_de_Legislacion
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_de_Legislacion.GetResource("Carga_de_Documentos_de_Legislacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_de_Legislacion.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_de_Legislacion.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_de_Legislacion.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Adjuntar_Documento</summary>
        public static string Adjuntar_Documento
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_de_Legislacion.GetResource("Adjuntar_Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_de_Legislacion.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_de_Actualizacion</summary>
        public static string Estatus_de_Actualizacion
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_de_Legislacion.GetResource("Estatus_de_Actualizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dispositivos</summary>
        public static string Dispositivos
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_de_Legislacion.GetResource("Dispositivos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCarga_de_Documentos_de_Legislacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
