using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Registro_de_Mandamiento_JudicialResources
    {
        //private static IResourceProvider resourceProviderRegistro_de_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Registro_de_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRegistro_de_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRegistro_de_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Registro_de_Mandamiento_Judicial</summary>
        public static string Registro_de_Mandamiento_Judicial
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Registro_de_Mandamiento_Judicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Mandamiento</summary>
        public static string Numero_de_Mandamiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Numero_de_Mandamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Mandato</summary>
        public static string Tipo_Mandato
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Tipo_Mandato", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fuente</summary>
        public static string Fuente
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fuente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Solicitud</summary>
        public static string Fecha_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_al_que_Pertenece_la_Informacion</summary>
        public static string Pais_al_que_Pertenece_la_Informacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Pais_al_que_Pertenece_la_Informacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_que_Envia_la_Informacion</summary>
        public static string Estado_que_Envia_la_Informacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Estado_que_Envia_la_Informacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_que_Envia_la_Informacion</summary>
        public static string Municipio_que_Envia_la_Informacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Municipio_que_Envia_la_Informacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Institucion_que_Remite</summary>
        public static string Institucion_que_Remite
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Institucion_que_Remite", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dependencia_Autoridad_Remitente</summary>
        public static string Dependencia_Autoridad_Remitente
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Dependencia_Autoridad_Remitente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entidad_que_Emite_Mandamiento</summary>
        public static string Entidad_que_Emite_Mandamiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Entidad_que_Emite_Mandamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juzgado_que_Emitio_Mandamiento</summary>
        public static string Juzgado_que_Emitio_Mandamiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Juzgado_que_Emitio_Mandamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Oficio_de_Juzgado</summary>
        public static string Oficio_de_Juzgado
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Oficio_de_Juzgado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Area_que_envia_Orden</summary>
        public static string Area_que_envia_Orden
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Area_que_envia_Orden", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Proceso_Judicial</summary>
        public static string Numero_de_Proceso_Judicial
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Numero_de_Proceso_Judicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Libramiento</summary>
        public static string Fecha_de_Libramiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Libramiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Oficio_de_Libramiento</summary>
        public static string Oficio_de_Libramiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Oficio_de_Libramiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Transcripcion</summary>
        public static string Fecha_de_Transcripcion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Transcripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Oficio_Transcripcion</summary>
        public static string Oficio_Transcripcion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Oficio_Transcripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Carpeta_de_Investigacion</summary>
        public static string Carpeta_de_Investigacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Carpeta_de_Investigacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Causa_Penal</summary>
        public static string Causa_Penal
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Causa_Penal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Personas_a_Incluir</summary>
        public static string Personas_a_Incluir
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Personas_a_Incluir", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Proceso</summary>	public static string TabProceso 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabProceso", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Expediente</summary>	public static string TabExpediente 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabExpediente", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
