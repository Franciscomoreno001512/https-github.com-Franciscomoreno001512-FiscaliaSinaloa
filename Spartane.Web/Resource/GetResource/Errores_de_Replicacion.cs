using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Errores_de_ReplicacionResources
    {
        //private static IResourceProvider resourceProviderErrores_de_Replicacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Errores_de_ReplicacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderErrores_de_Replicacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Errores_de_ReplicacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderErrores_de_Replicacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Errores_de_ReplicacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Errores_de_Replicacion</summary>
        public static string Errores_de_Replicacion
        {
            get
            {
                SetPath();
                return resourceProviderErrores_de_Replicacion.GetResource("Errores_de_Replicacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderErrores_de_Replicacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ID_del_Dispositivo</summary>
        public static string ID_del_Dispositivo
        {
            get
            {
                SetPath();
                return resourceProviderErrores_de_Replicacion.GetResource("ID_del_Dispositivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderErrores_de_Replicacion.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Error</summary>
        public static string Fecha_del_Error
        {
            get
            {
                SetPath();
                return resourceProviderErrores_de_Replicacion.GetResource("Fecha_del_Error", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_del_Error</summary>
        public static string Hora_del_Error
        {
            get
            {
                SetPath();
                return resourceProviderErrores_de_Replicacion.GetResource("Hora_del_Error", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Campo_con_Error</summary>
        public static string Campo_con_Error
        {
            get
            {
                SetPath();
                return resourceProviderErrores_de_Replicacion.GetResource("Campo_con_Error", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Valor_del_Campo_en_Dispositivo</summary>
        public static string Valor_del_Campo_en_Dispositivo
        {
            get
            {
                SetPath();
                return resourceProviderErrores_de_Replicacion.GetResource("Valor_del_Campo_en_Dispositivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Valor_del_Campo_en_Web</summary>
        public static string Valor_del_Campo_en_Web
        {
            get
            {
                SetPath();
                return resourceProviderErrores_de_Replicacion.GetResource("Valor_del_Campo_en_Web", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderErrores_de_Replicacion.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderErrores_de_Replicacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
