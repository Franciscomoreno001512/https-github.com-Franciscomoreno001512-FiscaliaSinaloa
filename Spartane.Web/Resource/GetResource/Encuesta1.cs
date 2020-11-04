using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Encuesta1Resources
    {
        //private static IResourceProvider resourceProviderEncuesta1 = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Encuesta1Resource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderEncuesta1 = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Encuesta1Resource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderEncuesta1 = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Encuesta1Resource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Encuesta1</summary>
        public static string Encuesta1
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Encuesta1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Preguntas</summary>
        public static string Numero_de_Preguntas
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Numero_de_Preguntas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT</summary>
        public static string NUAT
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta1</summary>
        public static string Pregunta1
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta2</summary>
        public static string Pregunta2
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta3</summary>
        public static string Pregunta3
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta4</summary>
        public static string Pregunta4
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta4", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta5</summary>
        public static string Pregunta5
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta5", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta6</summary>
        public static string Pregunta6
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta6", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta7</summary>
        public static string Pregunta7
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta7", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta8</summary>
        public static string Pregunta8
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta8", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta9</summary>
        public static string Pregunta9
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta9", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta10</summary>
        public static string Pregunta10
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta10", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderEncuesta1.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
