using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Guardado_de_MovimientoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Guardado_de_Movimiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Guardado_de_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Guardado_de_Movimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Guardado_de_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Guardado_de_Movimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Guardado_de_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Guardado_de_Movimiento</summary>
        public static string Detalle_de_Guardado_de_Movimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Guardado_de_Movimiento.GetResource("Detalle_de_Guardado_de_Movimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Guardado_de_Movimiento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Registro_de_Movimiento</summary>
        public static string Registro_de_Movimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Guardado_de_Movimiento.GetResource("Registro_de_Movimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Campo</summary>
        public static string Campo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Guardado_de_Movimiento.GetResource("Campo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Etiqueta</summary>
        public static string Etiqueta
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Guardado_de_Movimiento.GetResource("Etiqueta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Valor</summary>
        public static string Valor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Guardado_de_Movimiento.GetResource("Valor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Guardado_de_Movimiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
