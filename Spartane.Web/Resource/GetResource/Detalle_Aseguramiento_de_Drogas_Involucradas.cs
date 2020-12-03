using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Aseguramiento_de_Drogas_InvolucradasResources
    {
        //private static IResourceProvider resourceProviderDetalle_Aseguramiento_de_Drogas_Involucradas = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Aseguramiento_de_Drogas_InvolucradasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Aseguramiento_de_Drogas_Involucradas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_de_Drogas_InvolucradasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Aseguramiento_de_Drogas_Involucradas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_de_Drogas_InvolucradasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Aseguramiento_de_Drogas_Involucradas</summary>
        public static string Detalle_Aseguramiento_de_Drogas_Involucradas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Drogas_Involucradas.GetResource("Detalle_Aseguramiento_de_Drogas_Involucradas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Drogas_Involucradas.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Drogas_Involucradas.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_de_Medida</summary>
        public static string Unidad_de_Medida
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Drogas_Involucradas.GetResource("Unidad_de_Medida", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad</summary>
        public static string Cantidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Drogas_Involucradas.GetResource("Cantidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Drogas_Involucradas.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Aseguramiento_de_Drogas_Involucradas.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
