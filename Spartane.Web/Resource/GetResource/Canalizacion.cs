using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class CanalizacionResources
    {
        //private static IResourceProvider resourceProviderCanalizacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\CanalizacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCanalizacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\CanalizacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCanalizacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\CanalizacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Canalizacion</summary>
        public static string Canalizacion
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Canalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_AT</summary>
        public static string Expediente_AT
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Expediente_AT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Canalizacion</summary>
        public static string Fecha_de_Canalizacion
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Fecha_de_Canalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Canalizacion</summary>
        public static string Hora_de_Canalizacion
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Hora_de_Canalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Canaliza</summary>
        public static string Usuario_que_Canaliza
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Usuario_que_Canaliza", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Relacion_a_Canalizar</summary>
        public static string Relacion_a_Canalizar
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Relacion_a_Canalizar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Canalizar_a</summary>
        public static string Canalizar_a
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Canalizar_a", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Resolucion</summary>
        public static string Fecha_de_Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Fecha_de_Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Resolucion</summary>
        public static string Hora_de_Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Hora_de_Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hubo_modificacion_en_la_relacion</summary>
        public static string Hubo_modificacion_en_la_relacion
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Hubo_modificacion_en_la_relacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nueva_Relacion</summary>
        public static string Nueva_Relacion
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Nueva_Relacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ResolucionId</summary>
        public static string ResolucionId
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("ResolucionId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion</summary>
        public static string Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Detalle_de_la_Resolucion</summary>
        public static string Detalle_de_la_Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Detalle_de_la_Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencias_Generadas</summary>
        public static string Diligencias_Generadas
        {
            get
            {
                SetPath();
                return resourceProviderCanalizacion.GetResource("Diligencias_Generadas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCanalizacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Resolución</summary>	public static string TabResolucion 	{		get		{			SetPath();  			return resourceProviderCanalizacion.GetResource("TabResolucion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
