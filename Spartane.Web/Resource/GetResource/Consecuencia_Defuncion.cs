using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Consecuencia_DefuncionResources
    {
        //private static IResourceProvider resourceProviderConsecuencia_Defuncion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Consecuencia_DefuncionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderConsecuencia_Defuncion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Consecuencia_DefuncionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderConsecuencia_Defuncion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Consecuencia_DefuncionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Consecuencia_Defuncion</summary>
        public static string Consecuencia_Defuncion
        {
            get
            {
                SetPath();
                return resourceProviderConsecuencia_Defuncion.GetResource("Consecuencia_Defuncion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderConsecuencia_Defuncion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderConsecuencia_Defuncion.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Defuncion</summary>
        public static string Tipo_Defuncion
        {
            get
            {
                SetPath();
                return resourceProviderConsecuencia_Defuncion.GetResource("Tipo_Defuncion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderConsecuencia_Defuncion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
