using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Audiencia_Defensor_ImputadoResources
    {
        //private static IResourceProvider resourceProviderDetalle_Audiencia_Defensor_Imputado = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Audiencia_Defensor_ImputadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Audiencia_Defensor_Imputado = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Audiencia_Defensor_ImputadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Audiencia_Defensor_Imputado = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Audiencia_Defensor_ImputadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Audiencia_Defensor_Imputado</summary>
        public static string Detalle_Audiencia_Defensor_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Defensor_Imputado.GetResource("Detalle_Audiencia_Defensor_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Defensor_Imputado.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Del_Imputado</summary>
        public static string Nombre_Del_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Defensor_Imputado.GetResource("Nombre_Del_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Abogado</summary>
        public static string Abogado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Defensor_Imputado.GetResource("Abogado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cedula_Profesional</summary>
        public static string Cedula_Profesional
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Defensor_Imputado.GetResource("Cedula_Profesional", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Audiencia_Defensor_Imputado.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
