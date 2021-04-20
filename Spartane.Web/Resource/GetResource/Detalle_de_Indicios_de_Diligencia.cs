using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Indicios_de_DiligenciaResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Indicios_de_Diligencia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Indicios_de_DiligenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Indicios_de_Diligencia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Indicios_de_DiligenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Indicios_de_Diligencia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Indicios_de_DiligenciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Indicios_de_Diligencia</summary>
        public static string Detalle_de_Indicios_de_Diligencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios_de_Diligencia.GetResource("Detalle_de_Indicios_de_Diligencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios_de_Diligencia.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Indicio</summary>
        public static string Indicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios_de_Diligencia.GetResource("Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Seleccionar</summary>
        public static string Seleccionar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios_de_Diligencia.GetResource("Seleccionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>IndicioId</summary>
        public static string IndicioId
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Indicios_de_Diligencia.GetResource("IndicioId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Indicios_de_Diligencia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
