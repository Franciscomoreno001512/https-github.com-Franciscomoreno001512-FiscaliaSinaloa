using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class DiligenciasResources
    {
        //private static IResourceProvider resourceProviderDiligencias = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\DiligenciasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDiligencias = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\DiligenciasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDiligencias = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\DiligenciasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Diligencias</summary>
        public static string Diligencias
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Diligencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicio</summary>
        public static string Servicio
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialista</summary>
        public static string Especialista
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_del_Dictamen</summary>
        public static string Estatus_del_Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Estatus_del_Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Dictamen</summary>
        public static string Fecha_del_Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Fecha_del_Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictamen</summary>
        public static string Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Rol_de_Donde_Proviene</summary>
        public static string Rol_de_Donde_Proviene
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Rol_de_Donde_Proviene", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_Diligencia</summary>
        public static string Clave_Diligencia
        {
            get
            {
                SetPath();
                return resourceProviderDiligencias.GetResource("Clave_Diligencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDiligencias.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
