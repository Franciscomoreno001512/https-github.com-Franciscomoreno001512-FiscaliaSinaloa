using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_IndiciosResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Indicios = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_IndiciosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Indicios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_IndiciosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Indicios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_IndiciosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Indicios</summary>
        public static string Detalle_de_Indicios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios.GetResource("Detalle_de_Indicios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Indicio</summary>
        public static string Numero_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios.GetResource("Numero_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Indicio</summary>
        public static string Nombre_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios.GetResource("Nombre_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         /// <summary>Descripcion_de_Indicio</summary>
        public static string Descripcion_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios.GetResource("Descripcion_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         /// <summary>Motivo_de_Indicio</summary>
        public static string Motivo_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios.GetResource("Motivo_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         /// <summary>Diligencia</summary>
        public static string Diligencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios.GetResource("Diligencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ubicacion</summary>
        public static string Ubicacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios.GetResource("Ubicacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
 
	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Indicios.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
