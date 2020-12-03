using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class estatus_mpiResources
    {
        //private static IResourceProvider resourceProviderestatus_mpi = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\estatus_mpiResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderestatus_mpi = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\estatus_mpiResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderestatus_mpi = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\estatus_mpiResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>estatus_mpi</summary>
        public static string estatus_mpi
        {
            get
            {
                SetPath();
                return resourceProviderestatus_mpi.GetResource("estatus_mpi", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>clave</summary>
        public static string clave
        {
            get
            {
                SetPath();
                return resourceProviderestatus_mpi.GetResource("clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>descripcion</summary>
        public static string descripcion
        {
            get
            {
                SetPath();
                return resourceProviderestatus_mpi.GetResource("descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderestatus_mpi.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
