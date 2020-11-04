using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_del_IndicioResources
    {
        //private static IResourceProvider resourceProviderDetalle_del_Indicio = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_del_IndicioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_del_Indicio = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_del_IndicioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_del_Indicio = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_del_IndicioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_del_Indicio</summary>
        public static string Detalle_del_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Indicio.GetResource("Detalle_del_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Indicio.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Indicio</summary>
        public static string Numero_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Indicio.GetResource("Numero_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Indicio</summary>
        public static string Nombre_del_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Indicio.GetResource("Nombre_del_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_del_Indicio</summary>
        public static string Descripcion_del_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Indicio.GetResource("Descripcion_del_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo</summary>
        public static string Motivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Indicio.GetResource("Motivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Indicio.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ubicacion_de_Indicio</summary>
        public static string Ubicacion_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Indicio.GetResource("Ubicacion_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_del_Indicio.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
