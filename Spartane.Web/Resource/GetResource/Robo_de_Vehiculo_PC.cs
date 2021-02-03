using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Robo_de_Vehiculo_PCResources
    {
        //private static IResourceProvider resourceProviderRobo_de_Vehiculo_PC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Robo_de_Vehiculo_PCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRobo_de_Vehiculo_PC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Robo_de_Vehiculo_PCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRobo_de_Vehiculo_PC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Robo_de_Vehiculo_PCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Robo_de_Vehiculo_PC</summary>
        public static string Robo_de_Vehiculo_PC
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Robo_de_Vehiculo_PC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Solicitud</summary>
        public static string Tipo_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Tipo_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Robo_de_Vehiculo</summary>
        public static string Robo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Marca</summary>
        public static string Marca
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sub_Marca</summary>
        public static string Sub_Marca
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Sub_Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Vehiculo</summary>
        public static string Tipo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Tipo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modelo</summary>
        public static string Modelo
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Modelo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color</summary>
        public static string Color
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Color", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Placas</summary>
        public static string Placas
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Placas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Senas_Particulares</summary>
        public static string Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderRobo_de_Vehiculo_PC.GetResource("Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRobo_de_Vehiculo_PC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
