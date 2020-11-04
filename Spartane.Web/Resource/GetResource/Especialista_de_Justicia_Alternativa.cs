using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Especialista_de_Justicia_AlternativaResources
    {
        //private static IResourceProvider resourceProviderEspecialista_de_Justicia_Alternativa = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Especialista_de_Justicia_AlternativaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderEspecialista_de_Justicia_Alternativa = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Especialista_de_Justicia_AlternativaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderEspecialista_de_Justicia_Alternativa = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Especialista_de_Justicia_AlternativaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Especialista_de_Justicia_Alternativa</summary>
        public static string Especialista_de_Justicia_Alternativa
        {
            get
            {
                SetPath();
                return resourceProviderEspecialista_de_Justicia_Alternativa.GetResource("Especialista_de_Justicia_Alternativa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderEspecialista_de_Justicia_Alternativa.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Empleado</summary>
        public static string Numero_de_Empleado
        {
            get
            {
                SetPath();
                return resourceProviderEspecialista_de_Justicia_Alternativa.GetResource("Numero_de_Empleado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Especialista</summary>
        public static string Nombre_de_Especialista
        {
            get
            {
                SetPath();
                return resourceProviderEspecialista_de_Justicia_Alternativa.GetResource("Nombre_de_Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Carga_de_Trabajo</summary>
        public static string Carga_de_Trabajo
        {
            get
            {
                SetPath();
                return resourceProviderEspecialista_de_Justicia_Alternativa.GetResource("Carga_de_Trabajo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderEspecialista_de_Justicia_Alternativa.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
