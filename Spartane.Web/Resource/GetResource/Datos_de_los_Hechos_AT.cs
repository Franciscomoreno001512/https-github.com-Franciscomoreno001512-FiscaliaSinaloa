using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Datos_de_los_Hechos_ATResources
    {
        //private static IResourceProvider resourceProviderDatos_de_los_Hechos_AT = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Datos_de_los_Hechos_ATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDatos_de_los_Hechos_AT = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Datos_de_los_Hechos_ATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDatos_de_los_Hechos_AT = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Datos_de_los_Hechos_ATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Datos_de_los_Hechos_AT</summary>
        public static string Datos_de_los_Hechos_AT
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Datos_de_los_Hechos_AT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Atencion_Inicial</summary>
        public static string Modulo_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Modulo_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MASC</summary>
        public static string Expediente_MASC
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Expediente_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Hecho</summary>
        public static string Titulo_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Titulo_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_Breve_de_los_Hechos</summary>
        public static string Narrativa_Breve_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Narrativa_Breve_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Prioridad_del_Hecho</summary>
        public static string Prioridad_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Prioridad_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Aproximada_del_Hecho</summary>
        public static string Hora_Aproximada_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Hora_Aproximada_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia</summary>
        public static string Referencia
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Referencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento_Extraviado</summary>
        public static string Documento_Extraviado
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Documento_Extraviado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Documento_Extraviado</summary>
        public static string Tipo_de_Documento_Extraviado
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Tipo_de_Documento_Extraviado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar_del_Hecho</summary>
        public static string Tipo_de_Lugar_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_AT.GetResource("Tipo_de_Lugar_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDatos_de_los_Hechos_AT.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
