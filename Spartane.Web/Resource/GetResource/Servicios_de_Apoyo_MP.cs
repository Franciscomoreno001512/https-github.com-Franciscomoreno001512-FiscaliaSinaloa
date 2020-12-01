using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Servicios_de_Apoyo_MPResources
    {
        //private static IResourceProvider resourceProviderServicios_de_Apoyo_MP = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Servicios_de_Apoyo_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderServicios_de_Apoyo_MP = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Servicios_de_Apoyo_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderServicios_de_Apoyo_MP = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Servicios_de_Apoyo_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Servicios_de_Apoyo_MP</summary>
        public static string Servicios_de_Apoyo_MP
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Servicios_de_Apoyo_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Categoria</summary>
        public static string Categoria
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Categoria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Servicio</summary>
        public static string Tipo_de_Servicio
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Tipo_de_Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Termino_para_Entrega</summary>
        public static string Fecha_de_Termino_para_Entrega
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Fecha_de_Termino_para_Entrega", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Termino_para_Entrega</summary>
        public static string Hora_de_Termino_para_Entrega
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Hora_de_Termino_para_Entrega", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencia_a_Enviar</summary>
        public static string Diligencia_a_Enviar
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Diligencia_a_Enviar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Atencion</summary>
        public static string Fecha_de_Atencion
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Fecha_de_Atencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Atencion</summary>
        public static string Hora_de_Atencion
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Hora_de_Atencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Atiende</summary>
        public static string Usuario_que_Atiende
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Usuario_que_Atiende", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Adjunto</summary>
        public static string Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderServicios_de_Apoyo_MP.GetResource("Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderServicios_de_Apoyo_MP.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Contestación</summary>	public static string TabContestacion 	{		get		{			SetPath();  			return resourceProviderServicios_de_Apoyo_MP.GetResource("TabContestacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
