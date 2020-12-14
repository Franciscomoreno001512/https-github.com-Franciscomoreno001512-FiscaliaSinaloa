using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Registro_de_MovimientoResources
    {
        //private static IResourceProvider resourceProviderRegistro_de_Movimiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Registro_de_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRegistro_de_Movimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRegistro_de_Movimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Registro_de_Movimiento</summary>
        public static string Registro_de_Movimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Movimiento.GetResource("Registro_de_Movimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Movimiento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Judicializacion</summary>
        public static string Judicializacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Movimiento.GetResource("Judicializacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fase</summary>
        public static string Fase
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Movimiento.GetResource("Fase", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Movimiento.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Movimiento_Realizado</summary>
        public static string Movimiento_Realizado
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Movimiento.GetResource("Movimiento_Realizado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Movimiento</summary>
        public static string Fecha_de_Movimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Movimiento.GetResource("Fecha_de_Movimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Movimiento</summary>
        public static string Hora_de_Movimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Movimiento.GetResource("Hora_de_Movimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Informacion</summary>
        public static string Informacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Movimiento.GetResource("Informacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Movimiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
