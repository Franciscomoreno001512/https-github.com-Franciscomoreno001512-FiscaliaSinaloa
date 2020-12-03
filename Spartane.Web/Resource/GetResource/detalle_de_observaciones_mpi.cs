using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class detalle_de_observaciones_mpiResources
    {
        //private static IResourceProvider resourceProviderdetalle_de_observaciones_mpi = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\detalle_de_observaciones_mpiResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderdetalle_de_observaciones_mpi = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\detalle_de_observaciones_mpiResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderdetalle_de_observaciones_mpi = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\detalle_de_observaciones_mpiResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>detalle_de_observaciones_mpi</summary>
        public static string detalle_de_observaciones_mpi
        {
            get
            {
                SetPath();
                return resourceProviderdetalle_de_observaciones_mpi.GetResource("detalle_de_observaciones_mpi", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>clave</summary>
        public static string clave
        {
            get
            {
                SetPath();
                return resourceProviderdetalle_de_observaciones_mpi.GetResource("clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>observaciones</summary>
        public static string observaciones
        {
            get
            {
                SetPath();
                return resourceProviderdetalle_de_observaciones_mpi.GetResource("observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>fecha</summary>
        public static string fecha
        {
            get
            {
                SetPath();
                return resourceProviderdetalle_de_observaciones_mpi.GetResource("fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>hora</summary>
        public static string hora
        {
            get
            {
                SetPath();
                return resourceProviderdetalle_de_observaciones_mpi.GetResource("hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>usuario_que_realiza_observacion</summary>
        public static string usuario_que_realiza_observacion
        {
            get
            {
                SetPath();
                return resourceProviderdetalle_de_observaciones_mpi.GetResource("usuario_que_realiza_observacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderdetalle_de_observaciones_mpi.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
