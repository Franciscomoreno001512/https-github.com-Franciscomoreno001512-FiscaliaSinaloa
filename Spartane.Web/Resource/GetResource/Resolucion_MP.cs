using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Resolucion_MPResources
    {
        //private static IResourceProvider resourceProviderResolucion_MP = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Resolucion_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderResolucion_MP = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Resolucion_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderResolucion_MP = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Resolucion_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Resolucion_MP</summary>
        public static string Resolucion_MP
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Resolucion_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Resolucion</summary>
        public static string Fecha_de_Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Fecha_de_Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_que_Resuelve</summary>
        public static string Persona_que_Resuelve
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Persona_que_Resuelve", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion</summary>
        public static string Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vinculacion</summary>
        public static string Vinculacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Vinculacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juzgado</summary>
        public static string Juzgado
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Juzgado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>No__De_Causa_o_Cuadernillo</summary>
        public static string No__De_Causa_o_Cuadernillo
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("No__De_Causa_o_Cuadernillo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ano_de_Causa_o_Cuadernillo</summary>
        public static string Ano_de_Causa_o_Cuadernillo
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Ano_de_Causa_o_Cuadernillo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Validacion</summary>
        public static string Fecha_de_Validacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Fecha_de_Validacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Validacion</summary>
        public static string Hora_de_Validacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Hora_de_Validacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictaminador</summary>
        public static string Dictaminador
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Dictaminador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado_de_Validacion</summary>
        public static string Resultado_de_Validacion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Resultado_de_Validacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Dictaminador</summary>
        public static string Observaciones_Dictaminador
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MP.GetResource("Observaciones_Dictaminador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderResolucion_MP.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Validación</summary>	public static string TabValidacion 	{		get		{			SetPath();  			return resourceProviderResolucion_MP.GetResource("TabValidacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
