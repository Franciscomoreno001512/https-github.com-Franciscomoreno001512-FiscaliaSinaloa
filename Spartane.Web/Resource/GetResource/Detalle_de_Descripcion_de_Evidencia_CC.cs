using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Descripcion_de_Evidencia_CCResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Descripcion_de_Evidencia_CC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Descripcion_de_Evidencia_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Descripcion_de_Evidencia_CC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Descripcion_de_Evidencia_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Descripcion_de_Evidencia_CC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Descripcion_de_Evidencia_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Descripcion_de_Evidencia_CC</summary>
        public static string Detalle_de_Descripcion_de_Evidencia_CC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Descripcion_de_Evidencia_CC.GetResource("Detalle_de_Descripcion_de_Evidencia_CC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Descripcion_de_Evidencia_CC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Evidencia</summary>
        public static string Numero_de_Evidencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Descripcion_de_Evidencia_CC.GetResource("Numero_de_Evidencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_la_Evidencia</summary>
        public static string Descripcion_de_la_Evidencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Descripcion_de_Evidencia_CC.GetResource("Descripcion_de_la_Evidencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Origen</summary>
        public static string Origen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Descripcion_de_Evidencia_CC.GetResource("Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Descripcion_de_Evidencia_CC.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Examen_Solicitado</summary>
        public static string Examen_Solicitado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Descripcion_de_Evidencia_CC.GetResource("Examen_Solicitado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_de_Barras</summary>
        public static string Codigo_de_Barras
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Descripcion_de_Evidencia_CC.GetResource("Codigo_de_Barras", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_de_Foto</summary>
        public static string Archivo_de_Foto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Descripcion_de_Evidencia_CC.GetResource("Archivo_de_Foto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Descripcion_de_Evidencia_CC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
