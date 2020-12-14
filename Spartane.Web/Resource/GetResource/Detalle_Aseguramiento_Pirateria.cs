using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Aseguramiento_PirateriaResources
    {
        //private static IResourceProvider resourceProviderDetalle_Aseguramiento_Pirateria = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Aseguramiento_PirateriaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Aseguramiento_Pirateria = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_PirateriaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Aseguramiento_Pirateria = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_PirateriaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Aseguramiento_Pirateria</summary>
        public static string Detalle_Aseguramiento_Pirateria
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Pirateria.GetResource("Detalle_Aseguramiento_Pirateria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Pirateria.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Registro</summary>
        public static string Motivo_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Pirateria.GetResource("Motivo_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Pirateria.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Pirateria.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad</summary>
        public static string Cantidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Pirateria.GetResource("Cantidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_de_Medicion</summary>
        public static string Unidad_de_Medicion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Pirateria.GetResource("Unidad_de_Medicion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Pirateria.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Aseguramiento_Pirateria.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
