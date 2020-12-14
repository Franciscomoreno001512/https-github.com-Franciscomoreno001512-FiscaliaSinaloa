using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class SubTipo_de_Medida_de_ProteccionResources
    {
        //private static IResourceProvider resourceProviderSubTipo_de_Medida_de_Proteccion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\SubTipo_de_Medida_de_ProteccionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSubTipo_de_Medida_de_Proteccion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\SubTipo_de_Medida_de_ProteccionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSubTipo_de_Medida_de_Proteccion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\SubTipo_de_Medida_de_ProteccionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>SubTipo_de_Medida_de_Proteccion</summary>
        public static string SubTipo_de_Medida_de_Proteccion
        {
            get
            {
                SetPath();
                return resourceProviderSubTipo_de_Medida_de_Proteccion.GetResource("SubTipo_de_Medida_de_Proteccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderSubTipo_de_Medida_de_Proteccion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderSubTipo_de_Medida_de_Proteccion.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSubTipo_de_Medida_de_Proteccion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
