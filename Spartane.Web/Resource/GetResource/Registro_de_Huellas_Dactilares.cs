using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Registro_de_Huellas_DactilaresResources
    {
        //private static IResourceProvider resourceProviderRegistro_de_Huellas_Dactilares = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Registro_de_Huellas_DactilaresResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRegistro_de_Huellas_Dactilares = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_Huellas_DactilaresResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRegistro_de_Huellas_Dactilares = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_Huellas_DactilaresResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Registro_de_Huellas_Dactilares</summary>
        public static string Registro_de_Huellas_Dactilares
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Registro_de_Huellas_Dactilares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Carpeta_de_Investigacion</summary>
        public static string Carpeta_de_Investigacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Carpeta_de_Investigacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Probable_Responsable</summary>
        public static string Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mano_Izquierda_4_Dedos</summary>
        public static string Mano_Izquierda_4_Dedos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Mano_Izquierda_4_Dedos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mano_Derecha_4_Dedos</summary>
        public static string Mano_Derecha_4_Dedos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Mano_Derecha_4_Dedos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pulgares</summary>
        public static string Pulgares
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Pulgares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Izquierda_Menique</summary>
        public static string Izquierda_Menique
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Izquierda_Menique", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Izquierda_Anular</summary>
        public static string Izquierda_Anular
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Izquierda_Anular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Izquierda_Medio</summary>
        public static string Izquierda_Medio
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Izquierda_Medio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Izquierda_Indice</summary>
        public static string Izquierda_Indice
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Izquierda_Indice", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Izquierda_Pulgar</summary>
        public static string Izquierda_Pulgar
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Izquierda_Pulgar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Derecha_Menique</summary>
        public static string Derecha_Menique
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Derecha_Menique", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Derecha_Anular</summary>
        public static string Derecha_Anular
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Derecha_Anular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Derecha_Medio</summary>
        public static string Derecha_Medio
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Derecha_Medio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Derecha_Indice</summary>
        public static string Derecha_Indice
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Derecha_Indice", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Derecha_Pulgar</summary>
        public static string Derecha_Pulgar
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("Derecha_Pulgar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Huellas_Dactilares.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
