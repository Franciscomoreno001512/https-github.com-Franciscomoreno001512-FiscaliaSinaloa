using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Plan_Actos_de_InvestigacionResources
    {
        //private static IResourceProvider resourceProviderDetalle_Plan_Actos_de_Investigacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Plan_Actos_de_InvestigacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Plan_Actos_de_Investigacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Plan_Actos_de_InvestigacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Plan_Actos_de_Investigacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Plan_Actos_de_InvestigacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Plan_Actos_de_Investigacion</summary>
        public static string Detalle_Plan_Actos_de_Investigacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Detalle_Plan_Actos_de_Investigacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Categoria</summary>
        public static string Categoria
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Categoria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicio_a_Solicitar</summary>
        public static string Servicio_a_Solicitar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Servicio_a_Solicitar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hecho_Delictivo_Acreditado</summary>
        public static string Hecho_Delictivo_Acreditado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Hecho_Delictivo_Acreditado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tiempo_Estandar</summary>
        public static string Tiempo_Estandar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Tiempo_Estandar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ponderacion</summary>
        public static string Ponderacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Ponderacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Contestacion</summary>
        public static string Fecha_Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Fecha_Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Contestacion</summary>
        public static string Hora_Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Hora_Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Contestacion</summary>
        public static string Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Adjunto</summary>
        public static string Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Contesta</summary>
        public static string Usuario_que_Contesta
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("Usuario_que_Contesta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Plan_Actos_de_Investigacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
