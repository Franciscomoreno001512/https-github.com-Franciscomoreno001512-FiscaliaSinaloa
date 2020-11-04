using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Lista_de_AsignacionesResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Lista_de_Asignaciones = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Lista_de_AsignacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Lista_de_Asignaciones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Lista_de_AsignacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Lista_de_Asignaciones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Lista_de_AsignacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Lista_de_Asignaciones</summary>
        public static string Detalle_de_Lista_de_Asignaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Lista_de_Asignaciones.GetResource("Detalle_de_Lista_de_Asignaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Lista_de_Asignaciones.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Asignacion</summary>
        public static string Numero_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Lista_de_Asignaciones.GetResource("Numero_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Lista_de_Asignaciones.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Realizado</summary>
        public static string Realizado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Lista_de_Asignaciones.GetResource("Realizado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especifique</summary>
        public static string Especifique
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Lista_de_Asignaciones.GetResource("Especifique", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Lista_de_Asignaciones.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
