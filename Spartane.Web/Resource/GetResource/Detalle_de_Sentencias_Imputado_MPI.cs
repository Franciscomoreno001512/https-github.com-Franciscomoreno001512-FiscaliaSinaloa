using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Sentencias_Imputado_MPIResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Sentencias_Imputado_MPI = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Sentencias_Imputado_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Sentencias_Imputado_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Sentencias_Imputado_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Sentencias_Imputado_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Sentencias_Imputado_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Sentencias_Imputado_MPI</summary>
        public static string Detalle_de_Sentencias_Imputado_MPI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Sentencias_Imputado_MPI.GetResource("Detalle_de_Sentencias_Imputado_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Sentencias_Imputado_MPI.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito</summary>
        public static string Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Sentencias_Imputado_MPI.GetResource("Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sentencia</summary>
        public static string Sentencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Sentencias_Imputado_MPI.GetResource("Sentencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Devolucion</summary>
        public static string Fecha_de_Devolucion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Sentencias_Imputado_MPI.GetResource("Fecha_de_Devolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Devolucion</summary>
        public static string Hora_de_Devolucion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Sentencias_Imputado_MPI.GetResource("Hora_de_Devolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Repacion_del_Dano</summary>
        public static string Repacion_del_Dano
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Sentencias_Imputado_MPI.GetResource("Repacion_del_Dano", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion</summary>
        public static string Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Sentencias_Imputado_MPI.GetResource("Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Sentencias_Imputado_MPI.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
