using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Control_de_Folios_por_EspecialidadResources
    {
        //private static IResourceProvider resourceProviderControl_de_Folios_por_Especialidad = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Control_de_Folios_por_EspecialidadResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderControl_de_Folios_por_Especialidad = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Control_de_Folios_por_EspecialidadResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderControl_de_Folios_por_Especialidad = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Control_de_Folios_por_EspecialidadResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Control_de_Folios_por_Especialidad</summary>
        public static string Control_de_Folios_por_Especialidad
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Folios_por_Especialidad.GetResource("Control_de_Folios_por_Especialidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Folios_por_Especialidad.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ano</summary>
        public static string Ano
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Folios_por_Especialidad.GetResource("Ano", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialidad</summary>
        public static string Especialidad
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Folios_por_Especialidad.GetResource("Especialidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecutivo</summary>
        public static string Consecutivo
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Folios_por_Especialidad.GetResource("Consecutivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderControl_de_Folios_por_Especialidad.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
