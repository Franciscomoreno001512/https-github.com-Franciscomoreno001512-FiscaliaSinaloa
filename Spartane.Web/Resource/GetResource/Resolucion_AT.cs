using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Resolucion_ATResources
    {
        //private static IResourceProvider resourceProviderResolucion_AT = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Resolucion_ATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderResolucion_AT = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Resolucion_ATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderResolucion_AT = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Resolucion_ATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Resolucion_AT</summary>
        public static string Resolucion_AT
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Resolucion_AT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Atencion_Inicial</summary>
        public static string Modulo_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Modulo_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Resolucion</summary>
        public static string Fecha_de_Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Fecha_de_Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_que_Resuelve</summary>
        public static string Persona_que_Resuelve
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Persona_que_Resuelve", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion</summary>
        public static string Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Relacion</summary>
        public static string Relacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Relacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Validacion</summary>
        public static string Fecha_de_Validacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Fecha_de_Validacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Validacion</summary>
        public static string Hora_de_Validacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Hora_de_Validacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictaminador</summary>
        public static string Dictaminador
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Dictaminador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado_de_Validacion</summary>
        public static string Resultado_de_Validacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Resultado_de_Validacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Dictaminador</summary>
        public static string Observaciones_Dictaminador
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_AT.GetResource("Observaciones_Dictaminador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderResolucion_AT.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Dictaminación</summary>	public static string TabDictaminacion 	{		get		{			SetPath();  			return resourceProviderResolucion_AT.GetResource("TabDictaminacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
