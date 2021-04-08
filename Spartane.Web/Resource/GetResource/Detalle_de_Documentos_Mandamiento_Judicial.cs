using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Documentos_Mandamiento_JudicialResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Documentos_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Documentos_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Documentos_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Documentos_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Documentos_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Documentos_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Documentos_Mandamiento_Judicial</summary>
        public static string Detalle_de_Documentos_Mandamiento_Judicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_Mandamiento_Judicial.GetResource("Detalle_de_Documentos_Mandamiento_Judicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_Mandamiento_Judicial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Registro_de_Orden_de_Aprehension</summary>
        public static string Registro_de_Orden_de_Aprehension
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_Mandamiento_Judicial.GetResource("Registro_de_Orden_de_Aprehension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documentos</summary>
        public static string Documentos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_Mandamiento_Judicial.GetResource("Documentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_Mandamiento_Judicial.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Documentos_Mandamiento_Judicial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
