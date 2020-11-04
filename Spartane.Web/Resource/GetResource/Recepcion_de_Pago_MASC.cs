using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Recepcion_de_Pago_MASCResources
    {
        //private static IResourceProvider resourceProviderRecepcion_de_Pago_MASC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Recepcion_de_Pago_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRecepcion_de_Pago_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Recepcion_de_Pago_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRecepcion_de_Pago_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Recepcion_de_Pago_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Recepcion_de_Pago_MASC</summary>
        public static string Recepcion_de_Pago_MASC
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Recepcion_de_Pago_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Recepcion</summary>
        public static string Fecha_de_Recepcion
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Fecha_de_Recepcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Recepcion</summary>
        public static string Hora_de_Recepcion
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Hora_de_Recepcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Recibe</summary>
        public static string Usuario_que_Recibe
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Usuario_que_Recibe", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requerido</summary>
        public static string Requerido
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Requerido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_la_Persona_que_entrega</summary>
        public static string Nombre_de_la_Persona_que_entrega
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Nombre_de_la_Persona_que_entrega", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Pago</summary>
        public static string Numero_de_Pago
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Numero_de_Pago", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_del_Pago</summary>
        public static string Monto_del_Pago
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Monto_del_Pago", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pago_Completo</summary>
        public static string Pago_Completo
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Pago_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_para_no_entregar_pago_completo</summary>
        public static string Motivo_para_no_entregar_pago_completo
        {
            get
            {
                SetPath();
                return resourceProviderRecepcion_de_Pago_MASC.GetResource("Motivo_para_no_entregar_pago_completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRecepcion_de_Pago_MASC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
