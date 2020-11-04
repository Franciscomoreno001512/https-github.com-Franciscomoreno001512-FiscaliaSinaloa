using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Control_de_CitasResources
    {
        //private static IResourceProvider resourceProviderControl_de_Citas = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Control_de_CitasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderControl_de_Citas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Control_de_CitasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderControl_de_Citas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Control_de_CitasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Control_de_Citas</summary>
        public static string Control_de_Citas
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Control_de_Citas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Atiende</summary>
        public static string Usuario_que_Atiende
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Usuario_que_Atiende", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_la_Cita</summary>
        public static string Fecha_de_la_Cita
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Fecha_de_la_Cita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_la_Cita</summary>
        public static string Hora_de_la_Cita
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Hora_de_la_Cita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Proceso</summary>
        public static string Proceso
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Proceso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Cita</summary>
        public static string Tipo_de_Cita
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Tipo_de_Cita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cita</summary>
        public static string Cita
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Cita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cumplida</summary>
        public static string Cumplida
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Cumplida", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Citas.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderControl_de_Citas.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
