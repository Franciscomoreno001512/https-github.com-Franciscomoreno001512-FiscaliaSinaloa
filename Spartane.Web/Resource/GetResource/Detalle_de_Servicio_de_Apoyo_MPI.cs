using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Servicio_de_Apoyo_MPIResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Servicio_de_Apoyo_MPI = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Servicio_de_Apoyo_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Servicio_de_Apoyo_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Servicio_de_Apoyo_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Servicio_de_Apoyo_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Servicio_de_Apoyo_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Servicio_de_Apoyo_MPI</summary>
        public static string Detalle_de_Servicio_de_Apoyo_MPI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo_MPI.GetResource("Detalle_de_Servicio_de_Apoyo_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo_MPI.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Servicio</summary>
        public static string Tipo_de_Servicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo_MPI.GetResource("Tipo_de_Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictamen</summary>
        public static string Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo_MPI.GetResource("Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Responsable</summary>
        public static string Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo_MPI.GetResource("Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Victima</summary>
        public static string Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicio_de_Apoyo_MPI.GetResource("Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Servicio_de_Apoyo_MPI.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
