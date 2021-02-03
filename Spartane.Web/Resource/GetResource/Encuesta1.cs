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

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Enviado</summary>
        public static string Fecha_Enviado
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Fecha_Enviado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Enviado</summary>
        public static string Hora_Enviado
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Hora_Enviado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Respuesta</summary>
        public static string Fecha_Respuesta
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Fecha_Respuesta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Respuesta</summary>
        public static string Hora_Respuesta
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Hora_Respuesta", CultureInfo.CurrentUICulture.Name) as String;
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

        /// <summary>Modulo</summary>
        public static string Modulo
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Modulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Encuesta</summary>
        public static string Tipo_Encuesta
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Tipo_Encuesta", CultureInfo.CurrentUICulture.Name) as String;
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

        /// <summary>Pregunta1</summary>
        public static string Pregunta1
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Pregunta1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Respuesta_1</summary>
        public static string Respuesta_1
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Respuesta_1", CultureInfo.CurrentUICulture.Name) as String;
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

        /// <summary>Respuesta_2</summary>
        public static string Respuesta_2
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Respuesta_2", CultureInfo.CurrentUICulture.Name) as String;
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

        /// <summary>Respuesta_3</summary>
        public static string Respuesta_3
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Respuesta_3", CultureInfo.CurrentUICulture.Name) as String;
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

        /// <summary>Respuesta_4</summary>
        public static string Respuesta_4
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Respuesta_4", CultureInfo.CurrentUICulture.Name) as String;
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

        /// <summary>Respuesta_5</summary>
        public static string Respuesta_5
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Respuesta_5", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderEncuesta1.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderEncuesta1.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
