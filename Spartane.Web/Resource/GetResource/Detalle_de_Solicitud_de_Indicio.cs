using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Solicitud_de_IndicioResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Solicitud_de_Indicio = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Solicitud_de_IndicioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Solicitud_de_Indicio = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_de_IndicioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Solicitud_de_Indicio = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_de_IndicioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Solicitud_de_Indicio</summary>
        public static string Detalle_de_Solicitud_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("Detalle_de_Solicitud_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Solicitud</summary>
        public static string Fecha_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("Fecha_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Solicitud</summary>
        public static string Hora_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("Hora_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Solicitante</summary>
        public static string Nombre_del_Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("Nombre_del_Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo</summary>
        public static string Motivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("Motivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Indicio</summary>
        public static string Numero_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("Numero_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Indicio</summary>
        public static string Nombre_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("Nombre_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_Entrega_de_Indicio</summary>
        public static string Descripcion_de_Entrega_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("Descripcion_de_Entrega_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencia_que_Solicita</summary>
        public static string Diligencia_que_Solicita
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("Diligencia_que_Solicita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitud_de_Indicio.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
