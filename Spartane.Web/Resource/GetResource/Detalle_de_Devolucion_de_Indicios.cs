using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Devolucion_de_IndiciosResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Devolucion_de_Indicios = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Devolucion_de_IndiciosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Devolucion_de_Indicios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Devolucion_de_IndiciosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Devolucion_de_Indicios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Devolucion_de_IndiciosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Devolucion_de_Indicios</summary>
        public static string Detalle_de_Devolucion_de_Indicios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Devolucion_de_Indicios.GetResource("Detalle_de_Devolucion_de_Indicios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Devolucion_de_Indicios.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Devolucion</summary>
        public static string Fecha_de_Devolucion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Devolucion_de_Indicios.GetResource("Fecha_de_Devolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Devolucion</summary>
        public static string Hora_de_Devolucion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Devolucion_de_Indicios.GetResource("Hora_de_Devolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Persona_que_Entrega</summary>
        public static string Nombre_de_Persona_que_Entrega
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Devolucion_de_Indicios.GetResource("Nombre_de_Persona_que_Entrega", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Indicio</summary>
        public static string Numero_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Devolucion_de_Indicios.GetResource("Numero_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Indicio</summary>
        public static string Nombre_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Devolucion_de_Indicios.GetResource("Nombre_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_Devolucion_de_Indicio</summary>
        public static string Descripcion_de_Devolucion_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Devolucion_de_Indicios.GetResource("Descripcion_de_Devolucion_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencia_que_Devuelve</summary>
        public static string Diligencia_que_Devuelve
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Devolucion_de_Indicios.GetResource("Diligencia_que_Devuelve", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Devolucion_de_Indicios.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
