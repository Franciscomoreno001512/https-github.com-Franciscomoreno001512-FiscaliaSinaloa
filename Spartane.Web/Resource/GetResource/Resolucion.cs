using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class ResolucionResources
    {
        //private static IResourceProvider resourceProviderResolucion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\ResolucionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderResolucion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ResolucionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderResolucion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ResolucionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Resolucion</summary>
        public static string Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion_Padre_para_Autorizacion</summary>
        public static string Resolucion_Padre_para_Autorizacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Resolucion_Padre_para_Autorizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Generar_Judicializacion</summary>
        public static string Generar_Judicializacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Generar_Judicializacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ClaveFiscalia</summary>
        public static string ClaveFiscalia
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("ClaveFiscalia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion_AT</summary>
        public static string Resolucion_AT
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Resolucion_AT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion_MP</summary>
        public static string Resolucion_MP
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Resolucion_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Aplica_para_Adolescentes</summary>
        public static string Aplica_para_Adolescentes
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Aplica_para_Adolescentes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Aplica_para_Denuncia</summary>
        public static string Aplica_para_Denuncia
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Aplica_para_Denuncia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Aplica_para_Carpeta_de_Investigacion</summary>
        public static string Aplica_para_Carpeta_de_Investigacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Aplica_para_Carpeta_de_Investigacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Abreviacion</summary>
        public static string Abreviacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Abreviacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigencia</summary>
        public static string Vigencia
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Vigencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>MostrarDependencia</summary>
        public static string MostrarDependencia
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("MostrarDependencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Conteo</summary>
        public static string Conteo
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Conteo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_esp</summary>
        public static string Estatus_esp
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Estatus_esp", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mostrar_Estadistico</summary>
        public static string Mostrar_Estadistico
        {
            get
            {
                SetPath();
                return resourceProviderResolucion.GetResource("Mostrar_Estadistico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderResolucion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
