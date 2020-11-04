using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Historial_Control_de_DocumentosResources
    {
        //private static IResourceProvider resourceProviderDetalle_Historial_Control_de_Documentos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Historial_Control_de_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Historial_Control_de_Documentos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Historial_Control_de_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Historial_Control_de_Documentos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Historial_Control_de_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Historial_Control_de_Documentos</summary>
        public static string Detalle_Historial_Control_de_Documentos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historial_Control_de_Documentos.GetResource("Detalle_Historial_Control_de_Documentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historial_Control_de_Documentos.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historial_Control_de_Documentos.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historial_Control_de_Documentos.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historial_Control_de_Documentos.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modificaciones_Realizadas</summary>
        public static string Modificaciones_Realizadas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historial_Control_de_Documentos.GetResource("Modificaciones_Realizadas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cuerpo_del_Documento</summary>
        public static string Cuerpo_del_Documento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historial_Control_de_Documentos.GetResource("Cuerpo_del_Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Historial_Control_de_Documentos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
