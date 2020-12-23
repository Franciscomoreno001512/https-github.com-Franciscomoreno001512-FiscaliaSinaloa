using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Solicitud_de_Denuncia_CiudadanaResources
    {
        //private static IResourceProvider resourceProviderSolicitud_de_Denuncia_Ciudadana = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Solicitud_de_Denuncia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSolicitud_de_Denuncia_Ciudadana = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_Denuncia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSolicitud_de_Denuncia_Ciudadana = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_Denuncia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Solicitud_de_Denuncia_Ciudadana</summary>
        public static string Solicitud_de_Denuncia_Ciudadana
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Solicitud_de_Denuncia_Ciudadana", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Contrasena</summary>
        public static string Contrasena
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Contrasena", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Solicitud</summary>
        public static string Tipo_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Tipo_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_de_Solicitud</summary>
        public static string Estatus_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Estatus_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Canalizar_a</summary>
        public static string Canalizar_a
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Canalizar_a", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_canaliza</summary>
        public static string Unidad_canaliza
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Unidad_canaliza", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos de la Solicitud</summary>	public static string TabDatos_de_la_Solicitud 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("TabDatos_de_la_Solicitud", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Canalizar</summary>	public static string TabCanalizar 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("TabCanalizar", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
