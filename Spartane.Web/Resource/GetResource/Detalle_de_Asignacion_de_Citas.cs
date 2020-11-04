using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Asignacion_de_CitasResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Asignacion_de_Citas = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Asignacion_de_CitasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Asignacion_de_Citas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Asignacion_de_CitasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Asignacion_de_Citas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Asignacion_de_CitasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Asignacion_de_Citas</summary>
        public static string Detalle_de_Asignacion_de_Citas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Detalle_de_Asignacion_de_Citas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Empleado</summary>
        public static string Numero_de_Empleado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Numero_de_Empleado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Empleado</summary>
        public static string Nombre_de_Empleado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Nombre_de_Empleado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lunes</summary>
        public static string Lunes
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Lunes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Martes</summary>
        public static string Martes
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Martes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Miercoles</summary>
        public static string Miercoles
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Miercoles", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Jueves</summary>
        public static string Jueves
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Jueves", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Viernes</summary>
        public static string Viernes
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Viernes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sabado</summary>
        public static string Sabado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Sabado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Domingo</summary>
        public static string Domingo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Domingo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Inicio</summary>
        public static string Hora_Inicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Hora_Inicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Fin</summary>
        public static string Hora_Fin
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("Hora_Fin", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Asignacion_de_Citas.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
