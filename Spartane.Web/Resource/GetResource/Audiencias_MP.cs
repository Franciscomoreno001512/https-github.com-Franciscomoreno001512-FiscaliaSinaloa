using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Audiencias_MPResources
    {
        //private static IResourceProvider resourceProviderAudiencias_MP = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Audiencias_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAudiencias_MP = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Audiencias_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAudiencias_MP = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Audiencias_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Audiencias_MP</summary>
        public static string Audiencias_MP
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Audiencias_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Audiencia</summary>
        public static string Tipo_de_Audiencia
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Tipo_de_Audiencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Audiencia</summary>
        public static string Audiencia
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Audiencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Defensor_del_Imputado</summary>
        public static string Defensor_del_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Defensor_del_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Defensor_por_Victima</summary>
        public static string Defensor_por_Victima
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Defensor_por_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado_de_Audiencia</summary>
        public static string Resultado_de_Audiencia
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Resultado_de_Audiencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivos</summary>
        public static string Archivos
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Archivos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Asignar_MP_Litigacion</summary>
        public static string Asignar_MP_Litigacion
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("Asignar_MP_Litigacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>MP_Litigacion</summary>
        public static string MP_Litigacion
        {
            get
            {
                SetPath();
                return resourceProviderAudiencias_MP.GetResource("MP_Litigacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAudiencias_MP.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
