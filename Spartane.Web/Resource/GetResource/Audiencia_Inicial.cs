using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Audiencia_InicialResources
    {
        //private static IResourceProvider resourceProviderAudiencia_Inicial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Audiencia_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAudiencia_Inicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Audiencia_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAudiencia_Inicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Audiencia_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Audiencia_Inicial</summary>
        public static string Audiencia_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Audiencia_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Juez_de_Control</summary>
        public static string Nombre_del_Juez_de_Control
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Nombre_del_Juez_de_Control", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>causa_penal</summary>
        public static string causa_penal
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("causa_penal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Audiencia_Inicial</summary>
        public static string Fecha_Audiencia_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Fecha_Audiencia_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Audiencia_Inicial</summary>
        public static string Hora_Audiencia_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Hora_Audiencia_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sala_de_Audiencia</summary>
        public static string Sala_de_Audiencia
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Sala_de_Audiencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Relaciones</summary>
        public static string Relaciones
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Relaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Con_Detenido</summary>
        public static string Con_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Con_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especificar_Detencion</summary>
        public static string Especificar_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Especificar_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Control_de_Detencion</summary>
        public static string Control_de_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Control_de_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especificar_Control_Detencion</summary>
        public static string Especificar_Control_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Especificar_Control_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Formulacion_de_Imputacion</summary>
        public static string Formulacion_de_Imputacion
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_Inicial.GetResource("Formulacion_de_Imputacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAudiencia_Inicial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
