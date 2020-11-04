using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Asignacion_de_EspecialistaResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Asignacion_de_Especialista = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Asignacion_de_EspecialistaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Asignacion_de_Especialista = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Asignacion_de_EspecialistaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Asignacion_de_Especialista = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Asignacion_de_EspecialistaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Asignacion_de_Especialista</summary>
        public static string Detalle_de_Asignacion_de_Especialista
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Especialista.GetResource("Detalle_de_Asignacion_de_Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Especialista.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Especialista</summary>
        public static string Nombre_de_Especialista
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Especialista.GetResource("Nombre_de_Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Carga_de_trabajo</summary>
        public static string Carga_de_trabajo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Especialista.GetResource("Carga_de_trabajo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Asignacion_de_Especialista.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
