using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Bitacora_de_Canalizacion_MPIResources
    {
        //private static IResourceProvider resourceProviderDetalle_Bitacora_de_Canalizacion_MPI = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Bitacora_de_Canalizacion_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Bitacora_de_Canalizacion_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Bitacora_de_Canalizacion_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Bitacora_de_Canalizacion_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Bitacora_de_Canalizacion_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Bitacora_de_Canalizacion_MPI</summary>
        public static string Detalle_Bitacora_de_Canalizacion_MPI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Bitacora_de_Canalizacion_MPI.GetResource("Detalle_Bitacora_de_Canalizacion_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Bitacora_de_Canalizacion_MPI.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cambio_de_Estatus</summary>
        public static string Fecha_de_Cambio_de_Estatus
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Bitacora_de_Canalizacion_MPI.GetResource("Fecha_de_Cambio_de_Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Cambio_de_Estatus</summary>
        public static string Hora_de_Cambio_de_Estatus
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Bitacora_de_Canalizacion_MPI.GetResource("Hora_de_Cambio_de_Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Interno</summary>
        public static string Estatus_Interno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Bitacora_de_Canalizacion_MPI.GetResource("Estatus_Interno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_de_Canalizacion</summary>
        public static string Estatus_de_Canalizacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Bitacora_de_Canalizacion_MPI.GetResource("Estatus_de_Canalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Bitacora_de_Canalizacion_MPI.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
