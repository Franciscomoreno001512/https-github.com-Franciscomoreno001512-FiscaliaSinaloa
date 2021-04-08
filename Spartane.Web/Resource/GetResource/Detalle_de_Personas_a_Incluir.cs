using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Personas_a_IncluirResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Personas_a_Incluir = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Personas_a_IncluirResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Personas_a_Incluir = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Personas_a_IncluirResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Personas_a_Incluir = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Personas_a_IncluirResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Personas_a_Incluir</summary>
        public static string Detalle_de_Personas_a_Incluir
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Personas_a_Incluir.GetResource("Detalle_de_Personas_a_Incluir", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Personas_a_Incluir.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona</summary>
        public static string Persona
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Personas_a_Incluir.GetResource("Persona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Seleccionar</summary>
        public static string Seleccionar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Personas_a_Incluir.GetResource("Seleccionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>PersonaId</summary>
        public static string PersonaId
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Personas_a_Incluir.GetResource("PersonaId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Personas_a_Incluir.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
