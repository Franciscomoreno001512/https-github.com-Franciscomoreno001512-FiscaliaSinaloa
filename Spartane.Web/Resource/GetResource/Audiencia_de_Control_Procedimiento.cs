using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Audiencia_de_Control_ProcedimientoResources
    {
        //private static IResourceProvider resourceProviderAudiencia_de_Control_Procedimiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Audiencia_de_Control_ProcedimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAudiencia_de_Control_Procedimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Audiencia_de_Control_ProcedimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAudiencia_de_Control_Procedimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Audiencia_de_Control_ProcedimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Audiencia_de_Control_Procedimiento</summary>
        public static string Audiencia_de_Control_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_de_Control_Procedimiento.GetResource("Audiencia_de_Control_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_de_Control_Procedimiento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_de_Control_Procedimiento.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAudiencia_de_Control_Procedimiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
