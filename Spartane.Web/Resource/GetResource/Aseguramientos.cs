using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class AseguramientosResources
    {
        //private static IResourceProvider resourceProviderAseguramientos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\AseguramientosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAseguramientos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\AseguramientosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAseguramientos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\AseguramientosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Aseguramientos</summary>
        public static string Aseguramientos
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Aseguramientos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente</summary>
        public static string Expediente
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medios_de_Transporte_Involucrados</summary>
        public static string Medios_de_Transporte_Involucrados
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Medios_de_Transporte_Involucrados", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Drogas_Involucradas</summary>
        public static string Drogas_Involucradas
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Drogas_Involucradas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Armas_Involucradas</summary>
        public static string Armas_Involucradas
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Armas_Involucradas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Artefactos_y_Explosivos</summary>
        public static string Artefactos_y_Explosivos
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Artefactos_y_Explosivos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cargadores_y_Cartuchos</summary>
        public static string Cargadores_y_Cartuchos
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Cargadores_y_Cartuchos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Equipo_de_Comunicaciones</summary>
        public static string Equipo_de_Comunicaciones
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Equipo_de_Comunicaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documentos</summary>
        public static string Documentos
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Documentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Moneda</summary>
        public static string Moneda
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Moneda", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Equipo_Tactico</summary>
        public static string Equipo_Tactico
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Equipo_Tactico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Electronicos_y_Multimedia</summary>
        public static string Electronicos_y_Multimedia
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Electronicos_y_Multimedia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pirateria</summary>
        public static string Pirateria
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Pirateria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Inmuebles</summary>
        public static string Inmuebles
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Inmuebles", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Plantios</summary>
        public static string Plantios
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Plantios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pistas_de_Aterrizaje</summary>
        public static string Pistas_de_Aterrizaje
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Pistas_de_Aterrizaje", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otros</summary>
        public static string Otros
        {
            get
            {
                SetPath();
                return resourceProviderAseguramientos.GetResource("Otros", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAseguramientos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Medios de Transporte Involucrados</summary>	public static string TabMedios_de_Transporte_Involucrados 	{		get		{			SetPath();  			return resourceProviderAseguramientos.GetResource("TabMedios_de_Transporte_Involucrados", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Drogas Involucradas</summary>	public static string TabDrogas_Involucradas 	{		get		{			SetPath();  			return resourceProviderAseguramientos.GetResource("TabDrogas_Involucradas", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Armas Involucradas</summary>	public static string TabArmas_Involucradas 	{		get		{			SetPath();  			return resourceProviderAseguramientos.GetResource("TabArmas_Involucradas", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Objetos Asegurados</summary>	public static string TabObjetos_Asegurados 	{		get		{			SetPath();  			return resourceProviderAseguramientos.GetResource("TabObjetos_Asegurados", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Otros Aseguramientos</summary>	public static string TabOtros_Aseguramientos 	{		get		{			SetPath();  			return resourceProviderAseguramientos.GetResource("TabOtros_Aseguramientos", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
