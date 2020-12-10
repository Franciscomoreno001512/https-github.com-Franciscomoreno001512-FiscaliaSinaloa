using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Otros_Domicilios_Probable_ResponsableResources
    {
        //private static IResourceProvider resourceProviderOtros_Domicilios_Probable_Responsable = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Otros_Domicilios_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderOtros_Domicilios_Probable_Responsable = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Otros_Domicilios_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderOtros_Domicilios_Probable_Responsable = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Otros_Domicilios_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Otros_Domicilios_Probable_Responsable</summary>
        public static string Otros_Domicilios_Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Otros_Domicilios_Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Coordenada_X</summary>
        public static string Coordenada_X
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Coordenada_X", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Coordenada_Y</summary>
        public static string Coordenada_Y
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Coordenada_Y", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderOtros_Domicilios_Probable_Responsable.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
