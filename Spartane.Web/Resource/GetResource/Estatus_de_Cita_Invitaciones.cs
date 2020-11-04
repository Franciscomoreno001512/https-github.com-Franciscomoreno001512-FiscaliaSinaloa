using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Estatus_de_Cita_InvitacionesResources
    {
        //private static IResourceProvider resourceProviderEstatus_de_Cita_Invitaciones = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Estatus_de_Cita_InvitacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderEstatus_de_Cita_Invitaciones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Estatus_de_Cita_InvitacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderEstatus_de_Cita_Invitaciones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Estatus_de_Cita_InvitacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Estatus_de_Cita_Invitaciones</summary>
        public static string Estatus_de_Cita_Invitaciones
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Cita_Invitaciones.GetResource("Estatus_de_Cita_Invitaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Cita_Invitaciones.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderEstatus_de_Cita_Invitaciones.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderEstatus_de_Cita_Invitaciones.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
