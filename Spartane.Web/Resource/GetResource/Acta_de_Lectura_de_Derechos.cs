using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Acta_de_Lectura_de_DerechosResources
    {
        //private static IResourceProvider resourceProviderActa_de_Lectura_de_Derechos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Acta_de_Lectura_de_DerechosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderActa_de_Lectura_de_Derechos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Acta_de_Lectura_de_DerechosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderActa_de_Lectura_de_Derechos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Acta_de_Lectura_de_DerechosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Acta_de_Lectura_de_Derechos</summary>
        public static string Acta_de_Lectura_de_Derechos
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Acta_de_Lectura_de_Derechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUC</summary>
        public static string NUC
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("NUC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NIC</summary>
        public static string NIC
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("NIC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ubicacion</summary>
        public static string Ubicacion
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Ubicacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agente_de_la_PM</summary>
        public static string Agente_de_la_PM
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Agente_de_la_PM", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Plaza_de_Adscripcion</summary>
        public static string Plaza_de_Adscripcion
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Plaza_de_Adscripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Domicilio_de_la_Comandancia</summary>
        public static string Domicilio_de_la_Comandancia
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Domicilio_de_la_Comandancia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderActa_de_Lectura_de_Derechos.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderActa_de_Lectura_de_Derechos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
