using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Aseguramiento_de_PlantiosResources
    {
        //private static IResourceProvider resourceProviderDetalle_Aseguramiento_de_Plantios = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Aseguramiento_de_PlantiosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Aseguramiento_de_Plantios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_de_PlantiosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Aseguramiento_de_Plantios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_de_PlantiosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Aseguramiento_de_Plantios</summary>
        public static string Detalle_Aseguramiento_de_Plantios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Detalle_Aseguramiento_de_Plantios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>No__de_Plantios</summary>
        public static string No__de_Plantios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("No__de_Plantios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Kilogramos</summary>
        public static string Kilogramos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Kilogramos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Metodo_de_Destruccion</summary>
        public static string Metodo_de_Destruccion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Metodo_de_Destruccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Superficie</summary>
        public static string Superficie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Superficie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Altura</summary>
        public static string Altura
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Altura", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Densidad</summary>
        public static string Densidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Densidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Peso_por_planta</summary>
        public static string Peso_por_planta
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Peso_por_planta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Largo</summary>
        public static string Largo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Largo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ancho</summary>
        public static string Ancho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("Ancho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Aseguramiento_de_Plantios.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
