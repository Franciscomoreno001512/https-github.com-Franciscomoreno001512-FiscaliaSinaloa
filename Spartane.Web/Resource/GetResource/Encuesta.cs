using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class EncuestaResources
    {
        //private static IResourceProvider resourceProviderEncuesta = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\EncuestaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderEncuesta = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\EncuestaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderEncuesta = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\EncuestaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Encuesta</summary>
        public static string Encuesta
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta.GetResource("Encuesta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo</summary>
        public static string Modulo
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta.GetResource("Modulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Preguntas</summary>
        public static string Numero_de_Preguntas
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta.GetResource("Numero_de_Preguntas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta_1</summary>
        public static string Pregunta_1
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta.GetResource("Pregunta_1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta_2</summary>
        public static string Pregunta_2
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta.GetResource("Pregunta_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta_3</summary>
        public static string Pregunta_3
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta.GetResource("Pregunta_3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta_4</summary>
        public static string Pregunta_4
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta.GetResource("Pregunta_4", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pregunta_5</summary>
        public static string Pregunta_5
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta.GetResource("Pregunta_5", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderEncuesta.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
