using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_AbogadoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Abogado = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_AbogadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Abogado = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_AbogadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Abogado = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_AbogadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Abogado</summary>
        public static string Detalle_de_Abogado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Abogado.GetResource("Detalle_de_Abogado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Abogado.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUC</summary>
        public static string NUC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Abogado.GetResource("NUC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Representado</summary>
        public static string Nombre_del_Representado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Abogado.GetResource("Nombre_del_Representado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Representante</summary>
        public static string Tipo_de_Representante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Abogado.GetResource("Tipo_de_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Comentarios</summary>
        public static string Comentarios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Abogado.GetResource("Comentarios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Abogado.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
