using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Servicio_de_ApoyoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Servicio_de_Apoyo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Servicio_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Servicio_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Servicio_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Servicio_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Servicio_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Servicio_de_Apoyo</summary>
        public static string Detalle_de_Servicio_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Detalle_de_Servicio_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Origen</summary>
        public static string Origen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_de_Atencion_Inicial</summary>
        public static string Modulo_de_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Modulo_de_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Mecanismos_Alternos</summary>
        public static string Modulo_Mecanismos_Alternos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Modulo_Mecanismos_Alternos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Ministerio_Publico</summary>
        public static string Modulo_Ministerio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Modulo_Ministerio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Servicio</summary>
        public static string Tipo_de_Servicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Tipo_de_Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requiere_Traductor</summary>
        public static string Requiere_Traductor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Requiere_Traductor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lengua_Originaria</summary>
        public static string Lengua_Originaria
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Lengua_Originaria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Idioma</summary>
        public static string Idioma
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Idioma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Responsable</summary>
        public static string Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Compareciente</summary>
        public static string Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento_Atencion_Inicial</summary>
        public static string Documento_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Documento_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento_Mecanismos_Alternos</summary>
        public static string Documento_Mecanismos_Alternos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Documento_Mecanismos_Alternos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento_Ministerio_Publico</summary>
        public static string Documento_Ministerio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Documento_Ministerio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencia</summary>
        public static string Diligencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Diligencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Solicitud</summary>
        public static string Fecha_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Fecha_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Oficio</summary>
        public static string Numero_Oficio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Numero_Oficio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Imagen</summary>
        public static string Imagen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Imagen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Solicitante</summary>
        public static string Nombre_Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Nombre_Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Rango_Solicitante</summary>
        public static string Rango_Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Rango_Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Autoridades</summary>
        public static string Autoridades
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Autoridades", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agencia</summary>
        public static string Agencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Agencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictamen</summary>
        public static string Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Contestacion_lista_para_enviarse</summary>
        public static string Contestacion_lista_para_enviarse
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Contestacion_lista_para_enviarse", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Area_Pericial</summary>
        public static string Area_Pericial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Area_Pericial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Perito</summary>
        public static string Perito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("Perito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Canalizar</summary>	public static string TabCanalizar 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Servicio_de_Apoyo.GetResource("TabCanalizar", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
