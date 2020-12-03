using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Audiencia_Defensor_VictimaResources
    {
        //private static IResourceProvider resourceProviderDetalle_Audiencia_Defensor_Victima = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Audiencia_Defensor_VictimaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Audiencia_Defensor_Victima = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Audiencia_Defensor_VictimaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Audiencia_Defensor_Victima = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Audiencia_Defensor_VictimaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Audiencia_Defensor_Victima</summary>
        public static string Detalle_Audiencia_Defensor_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Defensor_Victima.GetResource("Detalle_Audiencia_Defensor_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Defensor_Victima.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Imputado</summary>
        public static string Nombre_del_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Defensor_Victima.GetResource("Nombre_del_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Abogado</summary>
        public static string Abogado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Defensor_Victima.GetResource("Abogado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cedula_Profesional</summary>
        public static string Cedula_Profesional
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Defensor_Victima.GetResource("Cedula_Profesional", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Audiencia_Defensor_Victima.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
