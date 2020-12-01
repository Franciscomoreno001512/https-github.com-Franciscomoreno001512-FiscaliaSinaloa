using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Plan_de_InvestigacionResources
    {
        //private static IResourceProvider resourceProviderPlan_de_Investigacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Plan_de_InvestigacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderPlan_de_Investigacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Plan_de_InvestigacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderPlan_de_Investigacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Plan_de_InvestigacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Plan_de_Investigacion</summary>
        public static string Plan_de_Investigacion
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Plan_de_Investigacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Reunion_Mando_Ministerial</summary>
        public static string Fecha_Reunion_Mando_Ministerial
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Fecha_Reunion_Mando_Ministerial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Reunion_Mando_Ministerial</summary>
        public static string Hora_Reunion_Mando_Ministerial
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Hora_Reunion_Mando_Ministerial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Asistentes</summary>
        public static string Asistentes
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Asistentes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Acuerdos</summary>
        public static string Acuerdos
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Acuerdos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Detalle</summary>
        public static string Detalle
        {
            get
            {
                SetPath();
                return resourceProviderPlan_de_Investigacion.GetResource("Detalle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderPlan_de_Investigacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Actos de Investigación</summary>	public static string TabActos_de_Investigacion 	{		get		{			SetPath();  			return resourceProviderPlan_de_Investigacion.GetResource("TabActos_de_Investigacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
