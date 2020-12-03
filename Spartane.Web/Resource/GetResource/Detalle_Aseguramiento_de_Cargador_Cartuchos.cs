using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Aseguramiento_de_Cargador_CartuchosResources
    {
        //private static IResourceProvider resourceProviderDetalle_Aseguramiento_de_Cargador_Cartuchos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Aseguramiento_de_Cargador_CartuchosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Aseguramiento_de_Cargador_Cartuchos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_de_Cargador_CartuchosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Aseguramiento_de_Cargador_Cartuchos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_de_Cargador_CartuchosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Aseguramiento_de_Cargador_Cartuchos</summary>
        public static string Detalle_Aseguramiento_de_Cargador_Cartuchos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Cargador_Cartuchos.GetResource("Detalle_Aseguramiento_de_Cargador_Cartuchos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Cargador_Cartuchos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cartuchos_municiones</summary>
        public static string cartuchos_municiones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Cargador_Cartuchos.GetResource("cartuchos_municiones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cartuchos_Habiles</summary>
        public static string Cartuchos_Habiles
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Cargador_Cartuchos.GetResource("Cartuchos_Habiles", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cartuchos_Percutidos</summary>
        public static string Cartuchos_Percutidos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Cargador_Cartuchos.GetResource("Cartuchos_Percutidos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cargadores</summary>
        public static string cargadores
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_de_Cargador_Cartuchos.GetResource("cargadores", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Aseguramiento_de_Cargador_Cartuchos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
