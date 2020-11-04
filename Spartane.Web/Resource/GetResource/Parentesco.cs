using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class ParentescoResources
    {
        //private static IResourceProvider resourceProviderParentesco = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\ParentescoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderParentesco = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ParentescoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderParentesco = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ParentescoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Parentesco</summary>
        public static string Parentesco
        {
            get
            {
                SetPath();
                return resourceProviderParentesco.GetResource("Parentesco", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderParentesco.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderParentesco.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Complemento</summary>
        public static string Complemento
        {
            get
            {
                SetPath();
                return resourceProviderParentesco.GetResource("Complemento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Relacion</summary>
        public static string Tipo_de_Relacion
        {
            get
            {
                SetPath();
                return resourceProviderParentesco.GetResource("Tipo_de_Relacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Relacion_con_Involucrado</summary>
        public static string Relacion_con_Involucrado
        {
            get
            {
                SetPath();
                return resourceProviderParentesco.GetResource("Relacion_con_Involucrado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigencia</summary>
        public static string Vigencia
        {
            get
            {
                SetPath();
                return resourceProviderParentesco.GetResource("Vigencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderParentesco.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderParentesco.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
