using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Solicitud_SeguimientoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Solicitud_Seguimiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Solicitud_SeguimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Solicitud_Seguimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_SeguimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Solicitud_Seguimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_SeguimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Solicitud_Seguimiento</summary>
        public static string Detalle_de_Solicitud_Seguimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Detalle_de_Solicitud_Seguimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Requerida</summary>
        public static string Fecha_Requerida
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Fecha_Requerida", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Relacion</summary>
        public static string Relacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Relacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cumplimiento</summary>
        public static string Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cumplimiento</summary>
        public static string Fecha_de_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Fecha_de_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Pago</summary>
        public static string Forma_de_Pago
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Forma_de_Pago", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad_del_Monto</summary>
        public static string Cantidad_del_Monto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Cantidad_del_Monto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_Cumplimiento</summary>
        public static string Descripcion_de_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Descripcion_de_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Concluir_Acuerdo</summary>
        public static string Concluir_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Concluir_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialista</summary>
        public static string Especialista
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Comentarios</summary>
        public static string Comentarios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Comentarios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitud_Seguimiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
