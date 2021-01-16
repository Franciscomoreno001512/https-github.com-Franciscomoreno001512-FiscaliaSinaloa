using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Queja_Sugerencia_CiudadanaResources
    {
        //private static IResourceProvider resourceProviderQueja_Sugerencia_Ciudadana = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Queja_Sugerencia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderQueja_Sugerencia_Ciudadana = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Queja_Sugerencia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderQueja_Sugerencia_Ciudadana = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Queja_Sugerencia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Queja_Sugerencia_Ciudadana</summary>
        public static string Queja_Sugerencia_Ciudadana
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Queja_Sugerencia_Ciudadana", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Registro</summary>
        public static string Tipo_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Tipo_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Queja</summary>
        public static string Queja
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Queja", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sugerencia</summary>
        public static string Sugerencia
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Sugerencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Eliminacion</summary>
        public static string Motivo_de_Eliminacion
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Motivo_de_Eliminacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Contestacion</summary>
        public static string Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderQueja_Sugerencia_Ciudadana.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
