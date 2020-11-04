using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Solicitudes_de_ComparecenciaResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Solicitudes_de_Comparecencia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Solicitudes_de_ComparecenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Solicitudes_de_Comparecencia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitudes_de_ComparecenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Solicitudes_de_Comparecencia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitudes_de_ComparecenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Solicitudes_de_Comparecencia</summary>
        public static string Detalle_de_Solicitudes_de_Comparecencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Comparecencia.GetResource("Detalle_de_Solicitudes_de_Comparecencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Comparecencia.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Comparecencia.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Comparecencia.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_la_Comparecencia</summary>
        public static string Fecha_de_la_Comparecencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Comparecencia.GetResource("Fecha_de_la_Comparecencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_la_Comparecencia</summary>
        public static string Hora_de_la_Comparecencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Comparecencia.GetResource("Hora_de_la_Comparecencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitudes_de_Comparecencia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
