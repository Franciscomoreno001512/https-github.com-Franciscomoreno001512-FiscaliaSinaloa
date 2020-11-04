using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class DelitoResources
    {
        //private static IResourceProvider resourceProviderDelito = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDelito = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDelito = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Delito</summary>
        public static string Delito
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Delito</summary>
        public static string Titulo_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Titulo_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grupo_del_Delito</summary>
        public static string Grupo_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Grupo_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grave</summary>
        public static string Grave
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Grave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alto_Impacto</summary>
        public static string Alto_Impacto
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Alto_Impacto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alta_Incidencia</summary>
        public static string Alta_Incidencia
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Alta_Incidencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tentativa</summary>
        public static string Tentativa
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Tentativa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Activo</summary>
        public static string Activo
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Activo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDelito.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
