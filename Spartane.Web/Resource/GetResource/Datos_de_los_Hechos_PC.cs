using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Datos_de_los_Hechos_PCResources
    {
        //private static IResourceProvider resourceProviderDatos_de_los_Hechos_PC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Datos_de_los_Hechos_PCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDatos_de_los_Hechos_PC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Datos_de_los_Hechos_PCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDatos_de_los_Hechos_PC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Datos_de_los_Hechos_PCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Datos_de_los_Hechos_PC</summary>
        public static string Datos_de_los_Hechos_PC
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Datos_de_los_Hechos_PC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Hecho</summary>
        public static string Titulo_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Titulo_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_Breve_de_los_Hechos</summary>
        public static string Narrativa_Breve_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Narrativa_Breve_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Aproximada_del_Hecho</summary>
        public static string Hora_Aproximada_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Hora_Aproximada_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tiene_alguna_Foto_o_Evidencia</summary>
        public static string Tiene_alguna_Foto_o_Evidencia
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Tiene_alguna_Foto_o_Evidencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fosa_clandestina</summary>
        public static string Fosa_clandestina
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Fosa_clandestina", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Conoce_la_direccion</summary>
        public static string Conoce_la_direccion
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Conoce_la_direccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia</summary>
        public static string Referencia
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Referencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Es_una_direccion_exacta_o_aproximada</summary>
        public static string Es_una_direccion_exacta_o_aproximada
        {
            get
            {
                SetPath();
                return resourceProviderDatos_de_los_Hechos_PC.GetResource("Es_una_direccion_exacta_o_aproximada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos de los hechos</summary>	public static string TabDatos_de_los_hechos 	{		get		{			SetPath();  			return resourceProviderDatos_de_los_Hechos_PC.GetResource("TabDatos_de_los_hechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Lugar de los Hechos</summary>	public static string TabLugar_de_los_Hechos 	{		get		{			SetPath();  			return resourceProviderDatos_de_los_Hechos_PC.GetResource("TabLugar_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
