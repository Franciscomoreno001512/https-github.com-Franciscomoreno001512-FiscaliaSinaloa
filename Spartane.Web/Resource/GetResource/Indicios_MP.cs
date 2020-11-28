using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Indicios_MPResources
    {
        //private static IResourceProvider resourceProviderIndicios_MP = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Indicios_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderIndicios_MP = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Indicios_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderIndicios_MP = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Indicios_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Indicios_MP</summary>
        public static string Indicios_MP
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Indicios_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Indicio</summary>
        public static string Numero_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Numero_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Indicio</summary>
        public static string Nombre_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Nombre_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_Indicio</summary>
        public static string Descripcion_de_Indicio
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Descripcion_de_Indicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ubicacion</summary>
        public static string Ubicacion
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Ubicacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderIndicios_MP.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderIndicios_MP.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
