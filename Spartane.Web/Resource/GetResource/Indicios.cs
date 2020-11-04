using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class IndiciosResources
    {
        //private static IResourceProvider resourceProviderIndicios = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\IndiciosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderIndicios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\IndiciosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderIndicios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\IndiciosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Indicios</summary>
        public static string Indicios
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("Indicios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUC</summary>
        public static string NUC
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("NUC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NIC</summary>
        public static string NIC
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("NIC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delegacion</summary>
        public static string Delegacion
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("Delegacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agencia</summary>
        public static string Agencia
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("Agencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_Indicio</summary>
        public static string Clave_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("Clave_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>IndiciosC</summary>
        public static string IndiciosC
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("IndiciosC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitudes</summary>
        public static string Solicitudes
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("Solicitudes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Devoluciones</summary>
        public static string Devoluciones
        {
            get
            {
                SetPath();
                return resourceProviderIndicios.GetResource("Devoluciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Registro de Indicios</summary>	public static string TabRegistro_de_Indicios 	{		get		{			SetPath();  			return resourceProviderIndicios.GetResource("TabRegistro_de_Indicios", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos Indicios</summary>	public static string TabDatos_Indicios 	{		get		{			SetPath();  			return resourceProviderIndicios.GetResource("TabDatos_Indicios", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Solicitud de Indicios</summary>	public static string TabSolicitud_de_Indicios 	{		get		{			SetPath();  			return resourceProviderIndicios.GetResource("TabSolicitud_de_Indicios", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Devolución de Indicios</summary>	public static string TabDevolucion_de_Indicios 	{		get		{			SetPath();  			return resourceProviderIndicios.GetResource("TabDevolucion_de_Indicios", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
