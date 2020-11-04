using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_DesestimacionResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Desestimacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_DesestimacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Desestimacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_DesestimacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Desestimacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_DesestimacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Desestimacion</summary>
        public static string Detalle_de_Desestimacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Desestimacion.GetResource("Detalle_de_Desestimacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Desestimacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Atencion_Inicial</summary>
        public static string Modulo_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Desestimacion.GetResource("Modulo_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Desestimacion.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Causal_de_Interrupcion</summary>
        public static string Causal_de_Interrupcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Desestimacion.GetResource("Causal_de_Interrupcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Causa_de_Interrupcion</summary>
        public static string Causa_de_Interrupcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Desestimacion.GetResource("Causa_de_Interrupcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_Insuficientes</summary>
        public static string Datos_Insuficientes
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Desestimacion.GetResource("Datos_Insuficientes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Actualizacion_de_Sobreseimiento</summary>
        public static string Actualizacion_de_Sobreseimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Desestimacion.GetResource("Actualizacion_de_Sobreseimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Desestimacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
